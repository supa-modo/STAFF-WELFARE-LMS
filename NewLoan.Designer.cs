namespace EAC_STAFF_WELFARE_LMS
{
    partial class NewLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLoan));
            this.panelTopNewLoan = new System.Windows.Forms.Panel();
            this.picBxClose = new System.Windows.Forms.PictureBox();
            this.lblAddLoan = new System.Windows.Forms.Label();
            this.txtInstallments = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtPFNo = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.metroBtnCancel = new MetroFramework.Controls.MetroButton();
            this.metroBtnSave = new MetroFramework.Controls.MetroButton();
            this.labelLoanID = new System.Windows.Forms.Label();
            this.panelTopNewLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopNewLoan
            // 
            this.panelTopNewLoan.Controls.Add(this.picBxClose);
            this.panelTopNewLoan.Controls.Add(this.lblAddLoan);
            this.panelTopNewLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNewLoan.Location = new System.Drawing.Point(0, 0);
            this.panelTopNewLoan.Name = "panelTopNewLoan";
            this.panelTopNewLoan.Size = new System.Drawing.Size(1041, 43);
            this.panelTopNewLoan.TabIndex = 1;
            // 
            // picBxClose
            // 
            this.picBxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxClose.Image")));
            this.picBxClose.Location = new System.Drawing.Point(1009, 11);
            this.picBxClose.Name = "picBxClose";
            this.picBxClose.Size = new System.Drawing.Size(20, 20);
            this.picBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxClose.TabIndex = 17;
            this.picBxClose.TabStop = false;
            this.picBxClose.Click += new System.EventHandler(this.picBxClose_Click);
            // 
            // lblAddLoan
            // 
            this.lblAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddLoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLoan.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAddLoan.Location = new System.Drawing.Point(12, 7);
            this.lblAddLoan.Name = "lblAddLoan";
            this.lblAddLoan.Size = new System.Drawing.Size(219, 28);
            this.lblAddLoan.TabIndex = 1;
            this.lblAddLoan.Text = "Add a New Loan";
            this.lblAddLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstallments
            // 
            this.txtInstallments.ForeColor = System.Drawing.Color.Gray;
            this.txtInstallments.Location = new System.Drawing.Point(377, 425);
            this.txtInstallments.Name = "txtInstallments";
            this.txtInstallments.Size = new System.Drawing.Size(417, 29);
            this.txtInstallments.TabIndex = 162;
            // 
            // txtDuration
            // 
            this.txtDuration.ForeColor = System.Drawing.Color.Gray;
            this.txtDuration.Location = new System.Drawing.Point(377, 356);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(417, 29);
            this.txtDuration.TabIndex = 161;
            // 
            // txtInterest
            // 
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.ForeColor = System.Drawing.Color.Gray;
            this.txtInterest.Location = new System.Drawing.Point(377, 292);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(417, 29);
            this.txtInterest.TabIndex = 160;
            this.txtInterest.Text = "5";
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.ForeColor = System.Drawing.Color.Gray;
            this.txtLoanAmt.Location = new System.Drawing.Point(377, 225);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(417, 29);
            this.txtLoanAmt.TabIndex = 157;
            // 
            // txtPFNo
            // 
            this.txtPFNo.ForeColor = System.Drawing.Color.Gray;
            this.txtPFNo.Location = new System.Drawing.Point(377, 165);
            this.txtPFNo.Name = "txtPFNo";
            this.txtPFNo.Size = new System.Drawing.Size(417, 29);
            this.txtPFNo.TabIndex = 156;
            // 
            // label45
            // 
            this.label45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label45.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label45.Location = new System.Drawing.Point(190, 429);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(172, 25);
            this.label45.TabIndex = 154;
            this.label45.Text = "Monthly Installments";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label43.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label43.Location = new System.Drawing.Point(190, 360);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(172, 25);
            this.label43.TabIndex = 153;
            this.label43.Text = "Duration of Payment";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.Location = new System.Drawing.Point(190, 296);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(172, 25);
            this.label40.TabIndex = 152;
            this.label40.Text = "Interest Rate";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMName
            // 
            this.labelMName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMName.Location = new System.Drawing.Point(190, 169);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(172, 25);
            this.labelMName.TabIndex = 151;
            this.labelMName.Text = "PF No";
            this.labelMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLName
            // 
            this.labelLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLName.Location = new System.Drawing.Point(190, 229);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(172, 25);
            this.labelLName.TabIndex = 150;
            this.labelLName.Text = "Loan Amount";
            this.labelLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFName
            // 
            this.labelFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFName.Location = new System.Drawing.Point(190, 103);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(172, 25);
            this.labelFName.TabIndex = 145;
            this.labelFName.Text = "Loan ID";
            this.labelFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroBtnCancel
            // 
            this.metroBtnCancel.BackColor = System.Drawing.Color.Gray;
            this.metroBtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnCancel.ForeColor = System.Drawing.Color.White;
            this.metroBtnCancel.Location = new System.Drawing.Point(680, 503);
            this.metroBtnCancel.Name = "metroBtnCancel";
            this.metroBtnCancel.Size = new System.Drawing.Size(137, 40);
            this.metroBtnCancel.TabIndex = 164;
            this.metroBtnCancel.Text = "Cancel";
            this.metroBtnCancel.UseCustomBackColor = true;
            this.metroBtnCancel.UseCustomForeColor = true;
            this.metroBtnCancel.UseSelectable = true;
            // 
            // metroBtnSave
            // 
            this.metroBtnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.metroBtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnSave.ForeColor = System.Drawing.Color.White;
            this.metroBtnSave.Location = new System.Drawing.Point(474, 503);
            this.metroBtnSave.Name = "metroBtnSave";
            this.metroBtnSave.Size = new System.Drawing.Size(137, 40);
            this.metroBtnSave.TabIndex = 163;
            this.metroBtnSave.Text = "Save";
            this.metroBtnSave.UseCustomBackColor = true;
            this.metroBtnSave.UseCustomForeColor = true;
            this.metroBtnSave.UseSelectable = true;
            this.metroBtnSave.Click += new System.EventHandler(this.metroBtnSave_Click);
            // 
            // labelLoanID
            // 
            this.labelLoanID.BackColor = System.Drawing.SystemColors.Window;
            this.labelLoanID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoanID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanID.Location = new System.Drawing.Point(377, 99);
            this.labelLoanID.Name = "labelLoanID";
            this.labelLoanID.Size = new System.Drawing.Size(417, 29);
            this.labelLoanID.TabIndex = 165;
            // 
            // NewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1041, 591);
            this.ControlBox = false;
            this.Controls.Add(this.labelLoanID);
            this.Controls.Add(this.metroBtnCancel);
            this.Controls.Add(this.metroBtnSave);
            this.Controls.Add(this.txtInstallments);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtLoanAmt);
            this.Controls.Add(this.txtPFNo);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.panelTopNewLoan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLoan";
            this.panelTopNewLoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopNewLoan;
        private System.Windows.Forms.PictureBox picBxClose;
        private System.Windows.Forms.Label lblAddLoan;
        private System.Windows.Forms.TextBox txtInstallments;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtPFNo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private MetroFramework.Controls.MetroButton metroBtnCancel;
        private MetroFramework.Controls.MetroButton metroBtnSave;
        private System.Windows.Forms.Label labelLoanID;
    }
}