namespace EAC_STAFF_WELFARE_LMS
{
    partial class loginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.labelEAC = new System.Windows.Forms.Label();
            this.labelSyst = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.chkBxRememberMe = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picBxUser = new System.Windows.Forms.PictureBox();
            this.picBxPwd = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.picBxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLogo
            // 
            this.loginLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginLogo.Image")));
            this.loginLogo.Location = new System.Drawing.Point(307, 43);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(158, 130);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginLogo.TabIndex = 1;
            this.loginLogo.TabStop = false;
            // 
            // labelEAC
            // 
            this.labelEAC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEAC.ForeColor = System.Drawing.Color.Green;
            this.labelEAC.Location = new System.Drawing.Point(230, 173);
            this.labelEAC.Name = "labelEAC";
            this.labelEAC.Size = new System.Drawing.Size(312, 34);
            this.labelEAC.TabIndex = 2;
            this.labelEAC.Text = "EAST AFRICAN COMMUNITY";
            this.labelEAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSyst
            // 
            this.labelSyst.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSyst.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSyst.Location = new System.Drawing.Point(193, 208);
            this.labelSyst.Name = "labelSyst";
            this.labelSyst.Size = new System.Drawing.Size(387, 31);
            this.labelSyst.TabIndex = 3;
            this.labelSyst.Text = "STAFF WELFARE MANAGEMENT SYSTEM";
            this.labelSyst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.txtPwd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPwd.Location = new System.Drawing.Point(157, 308);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(458, 31);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // chkBxRememberMe
            // 
            this.chkBxRememberMe.AutoSize = true;
            this.chkBxRememberMe.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkBxRememberMe.Location = new System.Drawing.Point(160, 348);
            this.chkBxRememberMe.Name = "chkBxRememberMe";
            this.chkBxRememberMe.Size = new System.Drawing.Size(99, 17);
            this.chkBxRememberMe.TabIndex = 7;
            this.chkBxRememberMe.Text = "Remember Me";
            this.chkBxRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(335, 376);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(102, 38);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Cornsilk;
            this.txtUsername.Font = new System.Drawing.Font("Cocon", 11F);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.Location = new System.Drawing.Point(157, 256);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(458, 30);
            this.txtUsername.TabIndex = 5;
            // 
            // picBxUser
            // 
            this.picBxUser.BackColor = System.Drawing.Color.Cornsilk;
            this.picBxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBxUser.Image")));
            this.picBxUser.Location = new System.Drawing.Point(584, 258);
            this.picBxUser.Name = "picBxUser";
            this.picBxUser.Size = new System.Drawing.Size(25, 25);
            this.picBxUser.TabIndex = 11;
            this.picBxUser.TabStop = false;
            // 
            // picBxPwd
            // 
            this.picBxPwd.BackColor = System.Drawing.Color.Cornsilk;
            this.picBxPwd.Image = ((System.Drawing.Image)(resources.GetObject("picBxPwd.Image")));
            this.picBxPwd.Location = new System.Drawing.Point(584, 311);
            this.picBxPwd.Name = "picBxPwd";
            this.picBxPwd.Size = new System.Drawing.Size(25, 25);
            this.picBxPwd.TabIndex = 12;
            this.picBxPwd.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.labelUsername.Location = new System.Drawing.Point(160, 238);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(54, 13);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.labelPwd.Location = new System.Drawing.Point(160, 292);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(51, 13);
            this.labelPwd.TabIndex = 15;
            this.labelPwd.Text = "Password";
            // 
            // picBxClose
            // 
            this.picBxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxClose.Image")));
            this.picBxClose.Location = new System.Drawing.Point(828, 4);
            this.picBxClose.Name = "picBxClose";
            this.picBxClose.Size = new System.Drawing.Size(20, 20);
            this.picBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxClose.TabIndex = 16;
            this.picBxClose.TabStop = false;
            this.picBxClose.Click += new System.EventHandler(this.picBxClose_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.ControlBox = false;
            this.Controls.Add(this.picBxClose);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.picBxPwd);
            this.Controls.Add(this.picBxUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.chkBxRememberMe);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelSyst);
            this.Controls.Add(this.labelEAC);
            this.Controls.Add(this.loginLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.Label labelEAC;
        private System.Windows.Forms.Label labelSyst;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.CheckBox chkBxRememberMe;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picBxUser;
        private System.Windows.Forms.PictureBox picBxPwd;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.PictureBox picBxClose;
    }
}

