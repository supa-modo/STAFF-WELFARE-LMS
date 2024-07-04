namespace EAC_STAFF_WELFARE_LMS
{
    partial class LoanApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanApplications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalLoans = new System.Windows.Forms.Label();
            this.labelLoansTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoanApplications = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnNewLoan = new MetroFramework.Controls.MetroButton();
            this.metroBtnRunLoansDeduction = new MetroFramework.Controls.MetroButton();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayableLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateApplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyInstallments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApplications)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelTotalLoans);
            this.panel2.Controls.Add(this.labelLoansTotal);
            this.panel2.Location = new System.Drawing.Point(433, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 40);
            this.panel2.TabIndex = 9;
            // 
            // labelTotalLoans
            // 
            this.labelTotalLoans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalLoans.BackColor = System.Drawing.SystemColors.Control;
            this.labelTotalLoans.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTotalLoans.ForeColor = System.Drawing.Color.Salmon;
            this.labelTotalLoans.Location = new System.Drawing.Point(312, 3);
            this.labelTotalLoans.Name = "labelTotalLoans";
            this.labelTotalLoans.Size = new System.Drawing.Size(165, 33);
            this.labelTotalLoans.TabIndex = 1;
            this.labelTotalLoans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoansTotal
            // 
            this.labelLoansTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLoansTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoansTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelLoansTotal.Location = new System.Drawing.Point(35, 3);
            this.labelLoansTotal.Name = "labelLoansTotal";
            this.labelLoansTotal.Size = new System.Drawing.Size(271, 33);
            this.labelLoansTotal.TabIndex = 0;
            this.labelLoansTotal.Text = "Active Loans Total Balance:";
            this.labelLoansTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Applications";
            // 
            // dgvLoanApplications
            // 
            this.dgvLoanApplications.AllowUserToAddRows = false;
            this.dgvLoanApplications.AllowUserToDeleteRows = false;
            this.dgvLoanApplications.AllowUserToOrderColumns = true;
            this.dgvLoanApplications.AllowUserToResizeColumns = false;
            this.dgvLoanApplications.AllowUserToResizeRows = false;
            this.dgvLoanApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoanApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoanApplications.ColumnHeadersHeight = 30;
            this.dgvLoanApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoanApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.LoanID,
            this.PFNo,
            this.ApplicantName,
            this.LoanAmount,
            this.PayableLoan,
            this.Duration,
            this.DateApplied,
            this.DueDate,
            this.MonthlyInstallments,
            this.PendingBalance,
            this.LoanStatus});
            this.dgvLoanApplications.EnableHeadersVisualStyles = false;
            this.dgvLoanApplications.Location = new System.Drawing.Point(0, 86);
            this.dgvLoanApplications.Name = "dgvLoanApplications";
            this.dgvLoanApplications.ReadOnly = true;
            this.dgvLoanApplications.RowHeadersVisible = false;
            this.dgvLoanApplications.RowTemplate.Height = 30;
            this.dgvLoanApplications.Size = new System.Drawing.Size(1350, 546);
            this.dgvLoanApplications.TabIndex = 3;
            this.dgvLoanApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanApplications_CellClick);
            this.dgvLoanApplications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanApplications_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.metroBtnNewLoan);
            this.panel3.Controls.Add(this.metroBtnRunLoansDeduction);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 40);
            this.panel3.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(972, 6);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(368, 31);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // metroBtnNewLoan
            // 
            this.metroBtnNewLoan.BackColor = System.Drawing.Color.SeaGreen;
            this.metroBtnNewLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroBtnNewLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnNewLoan.ForeColor = System.Drawing.Color.White;
            this.metroBtnNewLoan.Location = new System.Drawing.Point(17, 3);
            this.metroBtnNewLoan.Name = "metroBtnNewLoan";
            this.metroBtnNewLoan.Size = new System.Drawing.Size(240, 33);
            this.metroBtnNewLoan.Style = MetroFramework.MetroColorStyle.Green;
            this.metroBtnNewLoan.TabIndex = 10;
            this.metroBtnNewLoan.Text = "Add New Loan";
            this.metroBtnNewLoan.UseCustomBackColor = true;
            this.metroBtnNewLoan.UseCustomForeColor = true;
            this.metroBtnNewLoan.UseSelectable = true;
            this.metroBtnNewLoan.UseStyleColors = true;
            this.metroBtnNewLoan.Click += new System.EventHandler(this.metroBtnNewLoan_Click_1);
            // 
            // metroBtnRunLoansDeduction
            // 
            this.metroBtnRunLoansDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroBtnRunLoansDeduction.BackColor = System.Drawing.Color.SeaGreen;
            this.metroBtnRunLoansDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroBtnRunLoansDeduction.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnRunLoansDeduction.ForeColor = System.Drawing.Color.White;
            this.metroBtnRunLoansDeduction.Location = new System.Drawing.Point(501, 3);
            this.metroBtnRunLoansDeduction.Name = "metroBtnRunLoansDeduction";
            this.metroBtnRunLoansDeduction.Size = new System.Drawing.Size(342, 35);
            this.metroBtnRunLoansDeduction.Style = MetroFramework.MetroColorStyle.Green;
            this.metroBtnRunLoansDeduction.TabIndex = 9;
            this.metroBtnRunLoansDeduction.Text = "Run Monthly Loan Deductions";
            this.metroBtnRunLoansDeduction.UseCustomBackColor = true;
            this.metroBtnRunLoansDeduction.UseCustomForeColor = true;
            this.metroBtnRunLoansDeduction.UseSelectable = true;
            this.metroBtnRunLoansDeduction.UseStyleColors = true;
            this.metroBtnRunLoansDeduction.Click += new System.EventHandler(this.metroBtnRunLoansDeduction_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "S/No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 50;
            // 
            // LoanID
            // 
            this.LoanID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LoanID.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoanID.HeaderText = "Loan ID";
            this.LoanID.Name = "LoanID";
            this.LoanID.ReadOnly = true;
            this.LoanID.Width = 83;
            // 
            // PFNo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PFNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.PFNo.HeaderText = "PF NO.";
            this.PFNo.Name = "PFNo";
            this.PFNo.ReadOnly = true;
            this.PFNo.Width = 90;
            // 
            // ApplicantName
            // 
            this.ApplicantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ApplicantName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ApplicantName.HeaderText = "Applicant Name";
            this.ApplicantName.Name = "ApplicantName";
            this.ApplicantName.ReadOnly = true;
            this.ApplicantName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LoanAmount
            // 
            this.LoanAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.LoanAmount.HeaderText = "Loan Amount";
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.ReadOnly = true;
            this.LoanAmount.Width = 121;
            // 
            // PayableLoan
            // 
            this.PayableLoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableLoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.PayableLoan.HeaderText = "Payable Loan";
            this.PayableLoan.Name = "PayableLoan";
            this.PayableLoan.ReadOnly = true;
            this.PayableLoan.Width = 119;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.DefaultCellStyle = dataGridViewCellStyle7;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 90;
            // 
            // DateApplied
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateApplied.DefaultCellStyle = dataGridViewCellStyle8;
            this.DateApplied.HeaderText = "Date Applied";
            this.DateApplied.Name = "DateApplied";
            this.DateApplied.ReadOnly = true;
            this.DateApplied.Width = 120;
            // 
            // DueDate
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 120;
            // 
            // MonthlyInstallments
            // 
            this.MonthlyInstallments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MonthlyInstallments.DefaultCellStyle = dataGridViewCellStyle10;
            this.MonthlyInstallments.HeaderText = "Monthly Installments";
            this.MonthlyInstallments.Name = "MonthlyInstallments";
            this.MonthlyInstallments.ReadOnly = true;
            this.MonthlyInstallments.Width = 169;
            // 
            // PendingBalance
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingBalance.DefaultCellStyle = dataGridViewCellStyle11;
            this.PendingBalance.HeaderText = "Pending Balance";
            this.PendingBalance.Name = "PendingBalance";
            this.PendingBalance.ReadOnly = true;
            this.PendingBalance.Width = 130;
            // 
            // LoanStatus
            // 
            this.LoanStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LoanStatus.DefaultCellStyle = dataGridViewCellStyle12;
            this.LoanStatus.HeaderText = "Loan Status";
            this.LoanStatus.Name = "LoanStatus";
            this.LoanStatus.ReadOnly = true;
            this.LoanStatus.Width = 108;
            // 
            // LoanApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1350, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvLoanApplications);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoanApplications";
            this.Text = "LoanApplications";
            this.Load += new System.EventHandler(this.LoanApplications_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApplications)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoanApplications;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalLoans;
        private System.Windows.Forms.Label labelLoansTotal;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton metroBtnRunLoansDeduction;
        private MetroFramework.Controls.MetroButton metroBtnNewLoan;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayableLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateApplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyInstallments;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanStatus;
    }
}