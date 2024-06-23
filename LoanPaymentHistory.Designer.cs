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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanPaymentHistory));
            this.dgvLoanPaymentHistory = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBxClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoanPaymentHistory
            // 
            this.dgvLoanPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvLoanPaymentHistory.AllowUserToOrderColumns = true;
            this.dgvLoanPaymentHistory.AllowUserToResizeColumns = false;
            this.dgvLoanPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanPaymentHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoanPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.Loan_ID,
            this.AmountPaid,
            this.PendingBalance,
            this.PaymentDate});
            this.dgvLoanPaymentHistory.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoanPaymentHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvLoanPaymentHistory.Location = new System.Drawing.Point(0, 217);
            this.dgvLoanPaymentHistory.Name = "dgvLoanPaymentHistory";
            this.dgvLoanPaymentHistory.ReadOnly = true;
            this.dgvLoanPaymentHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoanPaymentHistory.RowTemplate.Height = 24;
            this.dgvLoanPaymentHistory.Size = new System.Drawing.Size(1081, 434);
            this.dgvLoanPaymentHistory.TabIndex = 0;
            this.dgvLoanPaymentHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanPaymentHistory_CellClick);
            // 
            // PaymentID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PaymentID.DefaultCellStyle = dataGridViewCellStyle2;
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.Width = 170;
            // 
            // Loan_ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Loan_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Loan_ID.HeaderText = "Loan ID";
            this.Loan_ID.Name = "Loan_ID";
            this.Loan_ID.ReadOnly = true;
            this.Loan_ID.Width = 240;
            // 
            // AmountPaid
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AmountPaid.DefaultCellStyle = dataGridViewCellStyle4;
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Width = 200;
            // 
            // PendingBalance
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PendingBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.PendingBalance.HeaderText = "Pending Balance";
            this.PendingBalance.Name = "PendingBalance";
            this.PendingBalance.ReadOnly = true;
            this.PendingBalance.Width = 220;
            // 
            // PaymentDate
            // 
            this.PaymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PaymentDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // picBxClose
            // 
            this.picBxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxClose.Image")));
            this.picBxClose.Location = new System.Drawing.Point(1055, 6);
            this.picBxClose.Name = "picBxClose";
            this.picBxClose.Size = new System.Drawing.Size(20, 20);
            this.picBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxClose.TabIndex = 18;
            this.picBxClose.TabStop = false;
            this.picBxClose.Click += new System.EventHandler(this.picBxClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.labelApplicant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 41);
            this.panel1.TabIndex = 19;
            // 
            // labelApplicant
            // 
            this.labelApplicant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelApplicant.ForeColor = System.Drawing.Color.White;
            this.labelApplicant.Location = new System.Drawing.Point(416, 9);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(178, 26);
            this.labelApplicant.TabIndex = 20;
            this.labelApplicant.Text = "Loan Applicant";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Payment History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 176);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // LoanPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1081, 651);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoanPaymentHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanPaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoanPaymentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanPaymentHistory;
        private System.Windows.Forms.PictureBox picBxClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
    }
}