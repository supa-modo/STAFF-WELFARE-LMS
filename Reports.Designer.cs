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
            this.panelReportsSide = new System.Windows.Forms.Panel();
            this.btnSavingsReport = new System.Windows.Forms.Button();
            this.btnAllMembersReport = new System.Windows.Forms.Button();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panelReportsSide.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoanReport
            // 
            this.btnLoanReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanReport.Location = new System.Drawing.Point(6, 543);
            this.btnLoanReport.Name = "btnLoanReport";
            this.btnLoanReport.Size = new System.Drawing.Size(215, 27);
            this.btnLoanReport.TabIndex = 0;
            this.btnLoanReport.Text = "Sample Loan Report";
            this.btnLoanReport.UseVisualStyleBackColor = true;
            this.btnLoanReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelReportsSide
            // 
            this.panelReportsSide.BackColor = System.Drawing.Color.LightGray;
            this.panelReportsSide.Controls.Add(this.panel3);
            this.panelReportsSide.Controls.Add(this.label3);
            this.panelReportsSide.Controls.Add(this.panel5);
            this.panelReportsSide.Controls.Add(this.label2);
            this.panelReportsSide.Controls.Add(this.panel2);
            this.panelReportsSide.Controls.Add(this.label1);
            this.panelReportsSide.Controls.Add(this.btnSavingsReport);
            this.panelReportsSide.Controls.Add(this.btnAllMembersReport);
            this.panelReportsSide.Controls.Add(this.btnLoanReport);
            this.panelReportsSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReportsSide.Location = new System.Drawing.Point(0, 0);
            this.panelReportsSide.Name = "panelReportsSide";
            this.panelReportsSide.Size = new System.Drawing.Size(221, 630);
            this.panelReportsSide.TabIndex = 2;
            // 
            // btnSavingsReport
            // 
            this.btnSavingsReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsReport.Location = new System.Drawing.Point(6, 597);
            this.btnSavingsReport.Name = "btnSavingsReport";
            this.btnSavingsReport.Size = new System.Drawing.Size(215, 27);
            this.btnSavingsReport.TabIndex = 2;
            this.btnSavingsReport.Text = "Sample Savings Report";
            this.btnSavingsReport.UseVisualStyleBackColor = true;
            this.btnSavingsReport.Click += new System.EventHandler(this.btnSavingsReport_Click);
            // 
            // btnAllMembersReport
            // 
            this.btnAllMembersReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMembersReport.Location = new System.Drawing.Point(6, 569);
            this.btnAllMembersReport.Name = "btnAllMembersReport";
            this.btnAllMembersReport.Size = new System.Drawing.Size(215, 27);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loans Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 117);
            this.panel2.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Location = new System.Drawing.Point(0, 78);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(221, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Individual Loan";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(0, 39);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(221, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Active Loans";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(221, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "All Loans";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Members Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 78);
            this.panel5.TabIndex = 27;
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button8.Location = new System.Drawing.Point(0, 39);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(221, 39);
            this.button8.TabIndex = 17;
            this.button8.Text = "Individual Member Details";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(221, 39);
            this.button11.TabIndex = 16;
            this.button11.Text = "All members details";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Savings Reports";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 78);
            this.panel3.TabIndex = 29;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button10.Location = new System.Drawing.Point(0, 39);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(221, 39);
            this.button10.TabIndex = 14;
            this.button10.Text = "Individual Savings";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(221, 39);
            this.button12.TabIndex = 13;
            this.button12.Text = "Total Savings";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1350, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panelReportsSide);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.Text = "Reports";
            this.panelReportsSide.ResumeLayout(false);
            this.panelReportViewer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoanReport;
        private System.Windows.Forms.Panel panelReportsSide;
        private System.Windows.Forms.Panel panelReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button btnAllMembersReport;
        private System.Windows.Forms.Button btnSavingsReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
    }
}