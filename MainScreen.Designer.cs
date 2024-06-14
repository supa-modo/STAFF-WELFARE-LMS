namespace EAC_STAFF_WELFARE_LMS
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.logoMainScrn = new System.Windows.Forms.PictureBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.picBxUser = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnLoanApps = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.panelMainScreen = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1Footer = new System.Windows.Forms.Label();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMainScrn)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTopBar.Controls.Add(this.logoMainScrn);
            this.panelTopBar.Controls.Add(this.labelTop);
            this.panelTopBar.Controls.Add(this.panelUser);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1350, 62);
            this.panelTopBar.TabIndex = 0;
            // 
            // logoMainScrn
            // 
            this.logoMainScrn.Image = ((System.Drawing.Image)(resources.GetObject("logoMainScrn.Image")));
            this.logoMainScrn.Location = new System.Drawing.Point(5, 1);
            this.logoMainScrn.Name = "logoMainScrn";
            this.logoMainScrn.Size = new System.Drawing.Size(74, 60);
            this.logoMainScrn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoMainScrn.TabIndex = 5;
            this.logoMainScrn.TabStop = false;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTop.ForeColor = System.Drawing.Color.Green;
            this.labelTop.Location = new System.Drawing.Point(292, 10);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(711, 42);
            this.labelTop.TabIndex = 3;
            this.labelTop.Text = "EAST AFRICAN COMMUNITY STAFF WELFARE SACCO";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.Color.Khaki;
            this.panelUser.Controls.Add(this.labelLoggedInUser);
            this.panelUser.Controls.Add(this.picBxUser);
            this.panelUser.Location = new System.Drawing.Point(1103, 15);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(235, 34);
            this.panelUser.TabIndex = 2;
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLoggedInUser.Location = new System.Drawing.Point(38, 6);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(193, 22);
            this.labelLoggedInUser.TabIndex = 1;
            this.labelLoggedInUser.Text = "Logged In User";
            this.labelLoggedInUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBxUser
            // 
            this.picBxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBxUser.Image")));
            this.picBxUser.Location = new System.Drawing.Point(3, 3);
            this.picBxUser.Name = "picBxUser";
            this.picBxUser.Size = new System.Drawing.Size(28, 28);
            this.picBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxUser.TabIndex = 0;
            this.picBxUser.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDashboard.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(3, -2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDashboard.Size = new System.Drawing.Size(196, 38);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.SeaGreen;
            this.panelNavBar.Controls.Add(this.btnSettings);
            this.panelNavBar.Controls.Add(this.btnReports);
            this.panelNavBar.Controls.Add(this.btnMembers);
            this.panelNavBar.Controls.Add(this.btnLoanApps);
            this.panelNavBar.Controls.Add(this.btnSavings);
            this.panelNavBar.Controls.Add(this.btnDashboard);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 62);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(1350, 38);
            this.panelNavBar.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(1042, -2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSettings.Size = new System.Drawing.Size(236, 38);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReports.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(846, -2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReports.Size = new System.Drawing.Size(196, 38);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMembers.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Location = new System.Drawing.Point(614, -2);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMembers.Size = new System.Drawing.Size(232, 38);
            this.btnMembers.TabIndex = 6;
            this.btnMembers.Text = "Members (Staff)";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnLoanApps
            // 
            this.btnLoanApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoanApps.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoanApps.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLoanApps.FlatAppearance.BorderSize = 0;
            this.btnLoanApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanApps.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoanApps.ForeColor = System.Drawing.Color.White;
            this.btnLoanApps.Location = new System.Drawing.Point(395, -2);
            this.btnLoanApps.Name = "btnLoanApps";
            this.btnLoanApps.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLoanApps.Size = new System.Drawing.Size(219, 38);
            this.btnLoanApps.TabIndex = 5;
            this.btnLoanApps.Text = "Loan Applications";
            this.btnLoanApps.UseVisualStyleBackColor = false;
            this.btnLoanApps.Click += new System.EventHandler(this.btnLoanApps_Click);
            // 
            // btnSavings
            // 
            this.btnSavings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavings.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSavings.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSavings.FlatAppearance.BorderSize = 0;
            this.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSavings.ForeColor = System.Drawing.Color.White;
            this.btnSavings.Location = new System.Drawing.Point(199, -2);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSavings.Size = new System.Drawing.Size(196, 38);
            this.btnSavings.TabIndex = 4;
            this.btnSavings.Text = "Savings";
            this.btnSavings.UseVisualStyleBackColor = false;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // panelMainScreen
            // 
            this.panelMainScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainScreen.Location = new System.Drawing.Point(7, 100);
            this.panelMainScreen.Name = "panelMainScreen";
            this.panelMainScreen.Size = new System.Drawing.Size(1336, 608);
            this.panelMainScreen.TabIndex = 5;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.SeaGreen;
            this.panelFooter.Controls.Add(this.label2);
            this.panelFooter.Controls.Add(this.label1Footer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 709);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1350, 20);
            this.panelFooter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(210, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "      2024";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1Footer
            // 
            this.label1Footer.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label1Footer.ForeColor = System.Drawing.Color.White;
            this.label1Footer.Location = new System.Drawing.Point(9, 4);
            this.label1Footer.Name = "label1Footer";
            this.label1Footer.Size = new System.Drawing.Size(208, 13);
            this.label1Footer.TabIndex = 0;
            this.label1Footer.Text = "EAC STAFF WELFARE MANAGEMENT SYSTEM ";
            this.label1Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMainScrn)).EndInit();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnLoanApps;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.PictureBox logoMainScrn;
        private System.Windows.Forms.Panel panelMainScreen;
        private System.Windows.Forms.PictureBox picBxUser;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label1Footer;
        private System.Windows.Forms.Label label2;
    }
}