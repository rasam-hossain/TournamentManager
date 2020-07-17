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
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vsLabel_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void secondTeamScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
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
    }
}
