﻿namespace EAC_STAFF_WELFARE_LMS
{
    partial class PFNoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PFNoDialog));
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.labelEnterPFNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPFNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(322, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 157;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(167, 150);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 31);
            this.btnOk.TabIndex = 156;
            this.btnOk.Text = "OK";
            this.btnOk.UseCustomBackColor = true;
            this.btnOk.UseCustomForeColor = true;
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelEnterPFNo
            // 
            this.labelEnterPFNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPFNo.Location = new System.Drawing.Point(26, 77);
            this.labelEnterPFNo.Name = "labelEnterPFNo";
            this.labelEnterPFNo.Size = new System.Drawing.Size(237, 38);
            this.labelEnterPFNo.TabIndex = 158;
            this.labelEnterPFNo.Text = "Enter Member PF Number";
            this.labelEnterPFNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.picBxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 34);
            this.panel1.TabIndex = 159;
            // 
            // picBxClose
            // 
            this.picBxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxClose.Image")));
            this.picBxClose.Location = new System.Drawing.Point(550, 5);
            this.picBxClose.Name = "picBxClose";
            this.picBxClose.Size = new System.Drawing.Size(20, 20);
            this.picBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxClose.TabIndex = 19;
            this.picBxClose.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PF Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPFNo
            // 
            this.txtPFNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPFNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPFNo.Location = new System.Drawing.Point(281, 77);
            this.txtPFNo.Multiline = true;
            this.txtPFNo.Name = "txtPFNo";
            this.txtPFNo.Size = new System.Drawing.Size(217, 38);
            this.txtPFNo.TabIndex = 160;
            // 
            // PFNoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 209);
            this.Controls.Add(this.txtPFNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEnterPFNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PFNoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PFNoDialog";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private System.Windows.Forms.Label labelEnterPFNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPFNo;
        private System.Windows.Forms.PictureBox picBxClose;
    }
}