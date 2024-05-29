namespace EAC_STAFF_WELFARE_LMS
{
    partial class Reports
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
            this.btnLoanReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllMembersReport = new System.Windows.Forms.Button();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSavingsReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoanReport
            // 
            this.btnLoanReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanReport.Location = new System.Drawing.Point(3, 46);
            this.btnLoanReport.Name = "btnLoanReport";
            this.btnLoanReport.Size = new System.Drawing.Size(215, 44);
            this.btnLoanReport.TabIndex = 0;
            this.btnLoanReport.Text = "Sample Loan Report";
            this.btnLoanReport.UseVisualStyleBackColor = true;
            this.btnLoanReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnSavingsReport);
            this.panel1.Controls.Add(this.btnAllMembersReport);
            this.panel1.Controls.Add(this.btnLoanReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 630);
            this.panel1.TabIndex = 2;
            // 
            // btnAllMembersReport
            // 
            this.btnAllMembersReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMembersReport.Location = new System.Drawing.Point(3, 105);
            this.btnAllMembersReport.Name = "btnAllMembersReport";
            this.btnAllMembersReport.Size = new System.Drawing.Size(215, 44);
            this.btnAllMembersReport.TabIndex = 1;
            this.btnAllMembersReport.Text = "Sample Members Report";
            this.btnAllMembersReport.UseVisualStyleBackColor = true;
            this.btnAllMembersReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReportViewer.Controls.Add(this.reportViewer);
            this.panelReportViewer.Location = new System.Drawing.Point(227, 7);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(1111, 618);
            this.panelReportViewer.TabIndex = 3;
            // 
            // reportViewer
            // 
            this.reportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "EAC_STAFF_WELFARE_LMS.LoansReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1111, 618);
            this.reportViewer.TabIndex = 2;
            // 
            // btnSavingsReport
            // 
            this.btnSavingsReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsReport.Location = new System.Drawing.Point(3, 165);
            this.btnSavingsReport.Name = "btnSavingsReport";
            this.btnSavingsReport.Size = new System.Drawing.Size(215, 44);
            this.btnSavingsReport.TabIndex = 2;
            this.btnSavingsReport.Text = "Sample Savings Report";
            this.btnSavingsReport.UseVisualStyleBackColor = true;
            this.btnSavingsReport.Click += new System.EventHandler(this.btnSavingsReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1350, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panelReportViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoanReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button btnAllMembersReport;
        private System.Windows.Forms.Button btnSavingsReport;
    }
}