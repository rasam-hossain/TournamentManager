using System.Windows.Forms;

namespace TrackerUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.tournamentViewerButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPicturebox = new System.Windows.Forms.PictureBox();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).BeginInit();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.menuPanel.Controls.Add(this.createPrizeButton);
            this.menuPanel.Controls.Add(this.createTeamButton);
            this.menuPanel.Controls.Add(this.createTournamentButton);
            this.menuPanel.Controls.Add(this.tournamentViewerButton);
            this.menuPanel.Controls.Add(this.dashboardButton);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 670);
            this.menuPanel.TabIndex = 0;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPrizeButton.FlatAppearance.BorderSize = 0;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.createPrizeButton.Image = ((System.Drawing.Image)(resources.GetObject("createPrizeButton.Image")));
            this.createPrizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPrizeButton.Location = new System.Drawing.Point(0, 340);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createPrizeButton.Size = new System.Drawing.Size(200, 60);
            this.createPrizeButton.TabIndex = 5;
            this.createPrizeButton.Text = "  Select Prize";
            this.createPrizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPrizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTeamButton.FlatAppearance.BorderSize = 0;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.createTeamButton.Image = ((System.Drawing.Image)(resources.GetObject("createTeamButton.Image")));
            this.createTeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTeamButton.Location = new System.Drawing.Point(0, 280);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createTeamButton.Size = new System.Drawing.Size(200, 60);
            this.createTeamButton.TabIndex = 4;
            this.createTeamButton.Text = "   Add Team";
            this.createTeamButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTeamButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTournamentButton.FlatAppearance.BorderSize = 0;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.createTournamentButton.Image = ((System.Drawing.Image)(resources.GetObject("createTournamentButton.Image")));
            this.createTournamentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTournamentButton.Location = new System.Drawing.Point(0, 220);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createTournamentButton.Size = new System.Drawing.Size(200, 60);
            this.createTournamentButton.TabIndex = 3;
            this.createTournamentButton.Text = "  Create Tournament";
            this.createTournamentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // tournamentViewerButton
            // 
            this.tournamentViewerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tournamentViewerButton.FlatAppearance.BorderSize = 0;
            this.tournamentViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentViewerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentViewerButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tournamentViewerButton.Image = ((System.Drawing.Image)(resources.GetObject("tournamentViewerButton.Image")));
            this.tournamentViewerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tournamentViewerButton.Location = new System.Drawing.Point(0, 160);
            this.tournamentViewerButton.Name = "tournamentViewerButton";
            this.tournamentViewerButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tournamentViewerButton.Size = new System.Drawing.Size(200, 60);
            this.tournamentViewerButton.TabIndex = 2;
            this.tournamentViewerButton.Text = " Tournament Viewer";
            this.tournamentViewerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tournamentViewerButton.UseVisualStyleBackColor = true;
            this.tournamentViewerButton.Click += new System.EventHandler(this.tournamentViewerButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 100);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(200, 60);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.logoPicturebox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // logoPicturebox
            // 
            this.logoPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicturebox.Image = global::TrackerUI.Properties.Resources.tounamentmanagerlogo;
            this.logoPicturebox.Location = new System.Drawing.Point(10, 0);
            this.logoPicturebox.Name = "logoPicturebox";
            this.logoPicturebox.Size = new System.Drawing.Size(190, 100);
            this.logoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicturebox.TabIndex = 0;
            this.logoPicturebox.TabStop = false;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.titleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.maximizeButton);
            this.titleBarPanel.Controls.Add(this.buttonClose);
            this.titleBarPanel.Controls.Add(this.titleLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.ForeColor = System.Drawing.Color.White;
            this.titleBarPanel.Location = new System.Drawing.Point(200, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(934, 75);
            this.titleBarPanel.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(821, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 35);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.ForeColor = System.Drawing.Color.Black;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(858, 0);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(1);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(35, 35);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(895, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(930, 71);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dashboard";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(200, 75);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(934, 595);
            this.containerPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1134, 670);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournamenet Manager";
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).EndInit();
            this.titleBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button tournamentViewerButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.PictureBox logoPicturebox;
        private Button buttonClose;
        private Button maximizeButton;
        private Button minimizeButton;
    }
}