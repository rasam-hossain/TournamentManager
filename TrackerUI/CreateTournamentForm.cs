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
    public partial class CreateTournamentForm : Form
    {
        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The follwoing method is to draw a line in the middle of the frame
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Color back = this.BackColor;
            Color dark = Color.FromArgb(220, 220, 220);
            int x = this.ClientSize.Width / 2;
            using (var pen = new Pen(dark))
            {
                e.Graphics.DrawLine(pen, x, 50, x, this.ClientSize.Height - 50);
            }
        }

        private void roundEdgedButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
