﻿namespace LockCent.Pages
{
    partial class Notificator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificator));
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.txtHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtMain = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.elpsButton = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrag
            // 
            this.pnlDrag.Controls.Add(this.txtHeader);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(404, 47);
            this.pnlDrag.TabIndex = 0;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseUp);
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.Color.White;
            this.txtHeader.Location = new System.Drawing.Point(12, 13);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(46, 21);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Error";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(362, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMain
            // 
            this.txtMain.AutoSize = true;
            this.txtMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.ForeColor = System.Drawing.Color.White;
            this.txtMain.Location = new System.Drawing.Point(12, 64);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(96, 21);
            this.txtMain.TabIndex = 1;
            this.txtMain.Text = "Placeholder";
            // 
            // btnOK
            // 
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(101, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(180, 45);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // elpsButton
            // 
            this.elpsButton.BorderRadius = 10;
            this.elpsButton.TargetControl = this.btnOK;
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 10;
            this.elpsMain.TargetControl = this;
            // 
            // Notificator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(404, 208);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificator";
            this.Load += new System.EventHandler(this.Notificator_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label txtMain;
        private System.Windows.Forms.Label txtHeader;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Elipse elpsButton;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
    }
}