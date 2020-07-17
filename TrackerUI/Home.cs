using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class Home : Form
    {
        // fields
        private Button currentButton;
        private Random random;

        /// <summary>
        /// Constructor
        /// </summary>
        public Home()
        {
            InitializeComponent();
            random = new Random();
        }

        /// <summary>
        /// This method selects a random theme color
        /// If a color has already been chosen, it re-randomizes it
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorsList.Count);
            string color = ThemeColor.ColorsList[index];
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

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void tournamentViewerButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
