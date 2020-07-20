namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.firstTeamLabel = new System.Windows.Forms.Label();
            this.firstTeamScoreLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.firstTeamScore = new System.Windows.Forms.TextBox();
            this.secondTeamScore = new System.Windows.Forms.TextBox();
            this.secondTeamScoreLabel = new System.Windows.Forms.Label();
            this.secondTeamLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstTeamLabel
            // 
            this.firstTeamLabel.AutoSize = true;
            this.firstTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstTeamLabel.Location = new System.Drawing.Point(590, 74);
            this.firstTeamLabel.Name = "firstTeamLabel";
            this.firstTeamLabel.Size = new System.Drawing.Size(164, 37);
            this.firstTeamLabel.TabIndex = 6;
            this.firstTeamLabel.Text = "<first team>";
            // 
            // firstTeamScoreLabel
            // 
            this.firstTeamScoreLabel.AutoSize = true;
            this.firstTeamScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTeamScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstTeamScoreLabel.Location = new System.Drawing.Point(590, 121);
            this.firstTeamScoreLabel.Name = "firstTeamScoreLabel";
            this.firstTeamScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.firstTeamScoreLabel.TabIndex = 8;
            this.firstTeamScoreLabel.Text = "Score";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // firstTeamScore
            // 
            this.firstTeamScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstTeamScore.ForeColor = System.Drawing.Color.White;
            this.firstTeamScore.Location = new System.Drawing.Point(678, 124);
            this.firstTeamScore.Name = "firstTeamScore";
            this.firstTeamScore.Size = new System.Drawing.Size(100, 35);
            this.firstTeamScore.TabIndex = 9;
            // 
            // secondTeamScore
            // 
            this.secondTeamScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secondTeamScore.ForeColor = System.Drawing.Color.White;
            this.secondTeamScore.Location = new System.Drawing.Point(678, 351);
            this.secondTeamScore.Name = "secondTeamScore";
            this.secondTeamScore.Size = new System.Drawing.Size(100, 35);
            this.secondTeamScore.TabIndex = 12;
            this.secondTeamScore.TextChanged += new System.EventHandler(this.secondTeamScore_TextChanged);
            // 
            // secondTeamScoreLabel
            // 
            this.secondTeamScoreLabel.AutoSize = true;
            this.secondTeamScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTeamScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.secondTeamScoreLabel.Location = new System.Drawing.Point(590, 348);
            this.secondTeamScoreLabel.Name = "secondTeamScoreLabel";
            this.secondTeamScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.secondTeamScoreLabel.TabIndex = 11;
            this.secondTeamScoreLabel.Text = "Score";
            // 
            // secondTeamLabel
            // 
            this.secondTeamLabel.AutoSize = true;
            this.secondTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.secondTeamLabel.Location = new System.Drawing.Point(590, 301);
            this.secondTeamLabel.Name = "secondTeamLabel";
            this.secondTeamLabel.Size = new System.Drawing.Size(204, 37);
            this.secondTeamLabel.TabIndex = 10;
            this.secondTeamLabel.Text = "<second team>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(652, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "V/S";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.ForeColor = System.Drawing.Color.White;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(14, 257);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(361, 212);
            this.matchupListBox.TabIndex = 24;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(107, 191);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(116, 34);
            this.unplayedOnlyCheckbox.TabIndex = 23;
            this.unplayedOnlyCheckbox.Text = "Unplayed";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // roundDropdown
            // 
            this.roundDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundDropdown.ForeColor = System.Drawing.Color.White;
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(107, 147);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(268, 38);
            this.roundDropdown.TabIndex = 22;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(7, 148);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 21;
            this.roundLabel.Text = "Round";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(225, 74);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(155, 50);
            this.tournamentName.TabIndex = 20;
            this.tournamentName.Text = "<none>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(5, 74);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(226, 50);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "Tournament:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(754, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 55);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Score";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondTeamScore);
            this.Controls.Add(this.secondTeamScoreLabel);
            this.Controls.Add(this.secondTeamLabel);
            this.Controls.Add(this.firstTeamScore);
            this.Controls.Add(this.firstTeamScoreLabel);
            this.Controls.Add(this.firstTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstTeamLabel;
        private System.Windows.Forms.Label firstTeamScoreLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox firstTeamScore;
        private System.Windows.Forms.TextBox secondTeamScore;
        private System.Windows.Forms.Label secondTeamScoreLabel;
        private System.Windows.Forms.Label secondTeamLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addButton;
    }
}

