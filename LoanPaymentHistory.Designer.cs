namespace EAC_STAFF_WELFARE_LMS
{
    partial class LoanPaymentHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanPaymentHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoanPaymentHistory = new System.Windows.Forms.DataGridView();
            this.picBxClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoanPaymentHistory
            // 
            this.dgvLoanPaymentHistory.AllowUserToAddRows = false;
            this.dgvLoanPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvLoanPaymentHistory.AllowUserToResizeColumns = false;
            this.dgvLoanPaymentHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvLoanPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.Loan_ID,
            this.AmountPaid,
            this.PendingBalance,
            this.PaymentDate});
            this.dgvLoanPaymentHistory.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoanPaymentHistory.Location = new System.Drawing.Point(5, 47);
            this.dgvLoanPaymentHistory.Name = "dgvLoanPaymentHistory";
            this.dgvLoanPaymentHistory.ReadOnly = true;
            this.dgvLoanPaymentHistory.RowTemplate.Height = 24;
            this.dgvLoanPaymentHistory.Size = new System.Drawing.Size(1069, 473);
            this.dgvLoanPaymentHistory.TabIndex = 0;
            // 
            // picBxClose
            // 
            this.picBxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxClose.Image")));
            this.picBxClose.Location = new System.Drawing.Point(1054, 6);
            this.picBxClose.Name = "picBxClose";
            this.picBxClose.Size = new System.Drawing.Size(20, 20);
            this.picBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxClose.TabIndex = 18;
            this.picBxClose.TabStop = false;
            this.picBxClose.Click += new System.EventHandler(this.picBxClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelApplicant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 41);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Payment History";
            // 
            // labelApplicant
            // 
            this.labelApplicant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelApplicant.Location = new System.Drawing.Point(416, 9);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(178, 26);
            this.labelApplicant.TabIndex = 20;
            this.labelApplicant.Text = "Loan Applicatnt";
            // 
            // PaymentID
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentID.DefaultCellStyle = dataGridViewCellStyle20;
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.Width = 150;
            // 
            // Loan_ID
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loan_ID.DefaultCellStyle = dataGridViewCellStyle21;
            this.Loan_ID.HeaderText = "Loan ID";
            this.Loan_ID.Name = "Loan_ID";
            this.Loan_ID.ReadOnly = true;
            this.Loan_ID.Width = 216;
            // 
            // AmountPaid
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaid.DefaultCellStyle = dataGridViewCellStyle22;
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Width = 200;
            // 
            // PendingBalance
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingBalance.DefaultCellStyle = dataGridViewCellStyle23;
            this.PendingBalance.HeaderText = "Pending Balance";
            this.PendingBalance.Name = "PendingBalance";
            this.PendingBalance.ReadOnly = true;
            this.PendingBalance.Width = 220;
            // 
            // PaymentDate
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDate.DefaultCellStyle = dataGridViewCellStyle24;
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 240;
            // 
            // LoanPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1080, 525);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoanPaymentHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanPaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanPaymentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanPaymentHistory;
        private System.Windows.Forms.PictureBox picBxClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
    }
}