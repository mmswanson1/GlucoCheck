﻿
namespace GlucoCheck.Forms
{
    partial class FrmLogin
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
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.UserExistsErrorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.cBoxRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(352, 169);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(178, 26);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(352, 229);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(178, 26);
            this.PasswordTextbox.TabIndex = 1;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(260, 171);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(260, 231);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(241, 390);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(147, 48);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(408, 390);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(150, 48);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(270, 330);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(257, 20);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Username or password is incorrect.";
            this.ErrorLabel.Visible = false;
            // 
            // UserExistsErrorLabel
            // 
            this.UserExistsErrorLabel.AutoSize = true;
            this.UserExistsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UserExistsErrorLabel.Location = new System.Drawing.Point(270, 351);
            this.UserExistsErrorLabel.Name = "UserExistsErrorLabel";
            this.UserExistsErrorLabel.Size = new System.Drawing.Size(243, 20);
            this.UserExistsErrorLabel.TabIndex = 7;
            this.UserExistsErrorLabel.Text = "User already exists. Please log in.";
            this.UserExistsErrorLabel.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(246, 68);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(298, 58);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "GlucoCheck";
            // 
            // cBoxRemember
            // 
            this.cBoxRemember.AutoSize = true;
            this.cBoxRemember.Location = new System.Drawing.Point(322, 271);
            this.cBoxRemember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxRemember.Name = "cBoxRemember";
            this.cBoxRemember.Size = new System.Drawing.Size(157, 24);
            this.cBoxRemember.TabIndex = 9;
            this.cBoxRemember.Text = "Remember Login";
            this.cBoxRemember.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 478);
            this.Controls.Add(this.cBoxRemember);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UserExistsErrorLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlucoCheck - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label UserExistsErrorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckBox cBoxRemember;
    }
}