namespace EAC_STAFF_WELFARE_LMS
{
    partial class LoansReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansReport));
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelDash2 = new System.Windows.Forms.Panel();
            this.panelTotalDiv = new System.Windows.Forms.Panel();
            this.panelDividend = new System.Windows.Forms.Panel();
            this.labelDivAmt = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelDividend = new System.Windows.Forms.Label();
            this.panelActiveLoans = new System.Windows.Forms.Panel();
            this.panelLoans = new System.Windows.Forms.Panel();
            this.labelLoanAmt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelActiveLoans = new System.Windows.Forms.Label();
            this.panelSavingsAccounts = new System.Windows.Forms.Panel();
            this.panelSavings = new System.Windows.Forms.Panel();
            this.labelSavingsAmt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSavings = new System.Windows.Forms.Label();
            this.panelDash2.SuspendLayout();
            this.panelTotalDiv.SuspendLayout();
            this.panelDividend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelActiveLoans.SuspendLayout();
            this.panelLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSavingsAccounts.SuspendLayout();
            this.panelSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample Test Loans Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(68, 397);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1008, 208);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelDash2
            // 
            this.panelDash2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDash2.BackColor = System.Drawing.Color.LightGray;
            this.panelDash2.Controls.Add(this.panelTotalDiv);
            this.panelDash2.Controls.Add(this.panelActiveLoans);
            this.panelDash2.Controls.Add(this.panelSavingsAccounts);
            this.panelDash2.Location = new System.Drawing.Point(68, 84);
            this.panelDash2.Name = "panelDash2";
            this.panelDash2.Size = new System.Drawing.Size(932, 141);
            this.panelDash2.TabIndex = 10;
            // 
            // panelTotalDiv
            // 
            this.panelTotalDiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotalDiv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalDiv.Controls.Add(this.panelDividend);
            this.panelTotalDiv.Controls.Add(this.labelDividend);
            this.panelTotalDiv.Location = new System.Drawing.Point(626, 5);
            this.panelTotalDiv.Name = "panelTotalDiv";
            this.panelTotalDiv.Size = new System.Drawing.Size(287, 122);
            this.panelTotalDiv.TabIndex = 22;
            // 
            // panelDividend
            // 
            this.panelDividend.Controls.Add(this.labelDivAmt);
            this.panelDividend.Controls.Add(this.pictureBox3);
            this.panelDividend.Location = new System.Drawing.Point(14, 9);
            this.panelDividend.Name = "panelDividend";
            this.panelDividend.Size = new System.Drawing.Size(261, 83);
            this.panelDividend.TabIndex = 0;
            // 
            // labelDivAmt
            // 
            this.labelDivAmt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivAmt.ForeColor = System.Drawing.Color.Red;
            this.labelDivAmt.Location = new System.Drawing.Point(94, 3);
            this.labelDivAmt.Name = "labelDivAmt";
            this.labelDivAmt.Size = new System.Drawing.Size(163, 77);
            this.labelDivAmt.TabIndex = 1;
            this.labelDivAmt.Text = "437,980";
            this.labelDivAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // labelDividend
            // 
            this.labelDividend.BackColor = System.Drawing.Color.CadetBlue;
            this.labelDividend.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelDividend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDividend.Location = new System.Drawing.Point(0, 96);
            this.labelDividend.Name = "labelDividend";
            this.labelDividend.Size = new System.Drawing.Size(287, 26);
            this.labelDividend.TabIndex = 16;
            this.labelDividend.Text = "TOTAL PAYABLE DIVIDEND";
            this.labelDividend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDividend.UseWaitCursor = true;
            // 
            // panelActiveLoans
            // 
            this.panelActiveLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelActiveLoans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelActiveLoans.Controls.Add(this.panelLoans);
            this.panelActiveLoans.Controls.Add(this.labelActiveLoans);
            this.panelActiveLoans.Location = new System.Drawing.Point(315, 5);
            this.panelActiveLoans.Name = "panelActiveLoans";
            this.panelActiveLoans.Size = new System.Drawing.Size(287, 122);
            this.panelActiveLoans.TabIndex = 21;
            // 
            // panelLoans
            // 
            this.panelLoans.Controls.Add(this.labelLoanAmt);
            this.panelLoans.Controls.Add(this.pictureBox2);
            this.panelLoans.Location = new System.Drawing.Point(14, 9);
            this.panelLoans.Name = "panelLoans";
            this.panelLoans.Size = new System.Drawing.Size(261, 83);
            this.panelLoans.TabIndex = 0;
            // 
            // labelLoanAmt
            // 
            this.labelLoanAmt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanAmt.ForeColor = System.Drawing.Color.Red;
            this.labelLoanAmt.Location = new System.Drawing.Point(94, 3);
            this.labelLoanAmt.Name = "labelLoanAmt";
            this.labelLoanAmt.Size = new System.Drawing.Size(163, 77);
            this.labelLoanAmt.TabIndex = 1;
            this.labelLoanAmt.Text = "437,980";
            this.labelLoanAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelActiveLoans
            // 
            this.labelActiveLoans.BackColor = System.Drawing.Color.CadetBlue;
            this.labelActiveLoans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelActiveLoans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelActiveLoans.Location = new System.Drawing.Point(0, 96);
            this.labelActiveLoans.Name = "labelActiveLoans";
            this.labelActiveLoans.Size = new System.Drawing.Size(287, 26);
            this.labelActiveLoans.TabIndex = 16;
            this.labelActiveLoans.Text = "ACTIVE LOANS";
            this.labelActiveLoans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelActiveLoans.UseWaitCursor = true;
            // 
            // panelSavingsAccounts
            // 
            this.panelSavingsAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSavingsAccounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSavingsAccounts.Controls.Add(this.panelSavings);
            this.panelSavingsAccounts.Controls.Add(this.labelSavings);
            this.panelSavingsAccounts.Location = new System.Drawing.Point(3, 5);
            this.panelSavingsAccounts.Name = "panelSavingsAccounts";
            this.panelSavingsAccounts.Size = new System.Drawing.Size(287, 122);
            this.panelSavingsAccounts.TabIndex = 20;
            // 
            // panelSavings
            // 
            this.panelSavings.Controls.Add(this.labelSavingsAmt);
            this.panelSavings.Controls.Add(this.pictureBox1);
            this.panelSavings.Location = new System.Drawing.Point(14, 9);
            this.panelSavings.Name = "panelSavings";
            this.panelSavings.Size = new System.Drawing.Size(261, 83);
            this.panelSavings.TabIndex = 0;
            // 
            // labelSavingsAmt
            // 
            this.labelSavingsAmt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSavingsAmt.ForeColor = System.Drawing.Color.Red;
            this.labelSavingsAmt.Location = new System.Drawing.Point(94, 3);
            this.labelSavingsAmt.Name = "labelSavingsAmt";
            this.labelSavingsAmt.Size = new System.Drawing.Size(163, 77);
            this.labelSavingsAmt.TabIndex = 1;
            this.labelSavingsAmt.Text = "437,980";
            this.labelSavingsAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSavings
            // 
            this.labelSavings.BackColor = System.Drawing.Color.CadetBlue;
            this.labelSavings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelSavings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSavings.Location = new System.Drawing.Point(0, 96);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(287, 26);
            this.labelSavings.TabIndex = 16;
            this.labelSavings.Text = "SAVINGS ACCOUNT";
            this.labelSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSavings.UseWaitCursor = true;
            // 
            // LoansReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panelDash2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoansReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoansReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoansReport_Load);
            this.panelDash2.ResumeLayout(false);
            this.panelTotalDiv.ResumeLayout(false);
            this.panelDividend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelActiveLoans.ResumeLayout(false);
            this.panelLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSavingsAccounts.ResumeLayout(false);
            this.panelSavings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panelDash2;
        private System.Windows.Forms.Panel panelTotalDiv;
        private System.Windows.Forms.Panel panelDividend;
        private System.Windows.Forms.Label labelDivAmt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelDividend;
        private System.Windows.Forms.Panel panelActiveLoans;
        private System.Windows.Forms.Panel panelLoans;
        private System.Windows.Forms.Label labelLoanAmt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelActiveLoans;
        private System.Windows.Forms.Panel panelSavingsAccounts;
        private System.Windows.Forms.Panel panelSavings;
        private System.Windows.Forms.Label labelSavingsAmt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSavings;
    }
}