﻿namespace LockCent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDrag = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsLoginBtn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsUsername = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsPass = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.lblError);
            this.pnlBackground.Controls.Add(this.lblRegister);
            this.pnlBackground.Controls.Add(this.lblPass);
            this.pnlBackground.Controls.Add(this.lblUser);
            this.pnlBackground.Controls.Add(this.btnLogin);
            this.pnlBackground.Controls.Add(this.txtUser);
            this.pnlBackground.Controls.Add(this.txtPassword);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.pnlDrag);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(730, 512);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(285, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(155, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.Location = new System.Drawing.Point(265, 179);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(200, 36);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(265, 235);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(608, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "LockCent @2022";
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrag.Controls.Add(this.lblTitle);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.ShadowDecoration.Parent = this.pnlDrag;
            this.pnlDrag.Size = new System.Drawing.Size(730, 40);
            this.pnlDrag.TabIndex = 1;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(690, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 25;
            this.elpsMain.TargetControl = this;
            // 
            // elpsLoginBtn
            // 
            this.elpsLoginBtn.BorderRadius = 15;
            this.elpsLoginBtn.TargetControl = this.btnLogin;
            // 
            // elpsUsername
            // 
            this.elpsUsername.BorderRadius = 15;
            this.elpsUsername.TargetControl = this.txtUser;
            // 
            // elpsPass
            // 
            this.elpsPass.BorderRadius = 15;
            this.elpsPass.TargetControl = this.txtPassword;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(166, 185);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 21);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(170, 241);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(83, 21);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(261, 276);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(205, 21);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "I don\'t have an account yet";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LOGIN";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(261, 348);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(70, 21);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "An Error";
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.pnlBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlDrag;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Elipse elpsLoginBtn;
        private Guna.UI2.WinForms.Guna2Elipse elpsUsername;
        private Guna.UI2.WinForms.Guna2Elipse elpsPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
    }
}

