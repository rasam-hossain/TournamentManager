using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerUI.Forms;

namespace TrackerUI
{
    public partial class TournamentManagerHome : Form
    {
        // fields
        private Button currentButton;
        private int prevColor;
        private Form activeForm;

        /// <summary>
        /// Constructor
        /// </summary>
        public TournamentManagerHome()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            // The application starts from the dashboard form
            OpenChildForm(new TournamentDashboardForm(), dashboardButton);
        }

        /*
        // The next bock of code makes the drag function work on the 
        // titleBar panel
        */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// This method selects a random theme color
        /// If a color has already been chosen, it re-randomizes it
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            Random random = new Random();
            int selectedColor = random.Next(ThemeColor.ColorsList.Count);
            while(selectedColor == prevColor)
            {
                selectedColor = random.Next(ThemeColor.ColorsList.Count);
            }
            prevColor = selectedColor;
            string color = ThemeColor.ColorsList[selectedColor];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// Highlight the button that has been clicked changing the following 
        /// Background color, font color, font size
        /// </summary>
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new 
                        System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    titleBarPanel.BackColor = color;
                    // panel logo back color is not set yet
                }
            }
        }


        /// <summary>
        /// This method is responsible to disable the button effects
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousButton in menuPanel.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(32, 32, 32);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new
                        System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        
        /// <summary>
        /// This method is responsible to open the child forms
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="btnSender"></param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            titleLabel.Text = childForm.Text;
        }


        // Click event generated for each of the buttons
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TournamentDashboardForm(), sender);
        }

        private void tournamentViewerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TournamentViewerForm(), sender);
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateTournamentForm(), sender);
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddTeamForm(), sender);
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreatePrizeForm(), sender);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.maximizeButton.Image = TrackerUI.Properties.Resources.restoreDownIcon;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.maximizeButton.Image = TrackerUI.Properties.Resources.maximizeIcon;
            }
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
