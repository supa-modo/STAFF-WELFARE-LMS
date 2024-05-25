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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.loanReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Sample Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 630);
            this.panel1.TabIndex = 2;
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReportViewer.Controls.Add(this.loanReportViewer);
            this.panelReportViewer.Location = new System.Drawing.Point(227, 7);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(1111, 618);
            this.panelReportViewer.TabIndex = 3;
            // 
            // loanReportViewer
            // 
            this.loanReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loanReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loanReportViewer.LocalReport.ReportEmbeddedResource = "EAC_STAFF_WELFARE_LMS.LoansReport.rdlc";
            this.loanReportViewer.Location = new System.Drawing.Point(0, 0);
            this.loanReportViewer.Name = "loanReportViewer";
            this.loanReportViewer.ServerReport.BearerToken = null;
            this.loanReportViewer.Size = new System.Drawing.Size(1111, 618);
            this.loanReportViewer.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sample Members Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panelReportViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer loanReportViewer;
        private System.Windows.Forms.Button button2;
    }
}