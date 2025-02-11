﻿namespace NStudio
{
    partial class LogInModule
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInModule));
            this.logo = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.PassPic = new System.Windows.Forms.PictureBox();
            this.passInputLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.rPassPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rPassPic = new System.Windows.Forms.PictureBox();
            this.rPassInputLabel = new System.Windows.Forms.Label();
            this.rPassInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.dbBox = new System.Windows.Forms.PictureBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.acceptRulesInput = new System.Windows.Forms.CheckBox();
            this.acceptRulesLabel = new System.Windows.Forms.LinkLabel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.passPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeLanguageButton = new System.Windows.Forms.Button();
            this.lockBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).BeginInit();
            this.rPassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rPassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Name = "loginLabel";
            // 
            // userInputLabel
            // 
            resources.ApplyResources(this.userInputLabel, "userInputLabel");
            this.userInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.userInputLabel.Name = "userInputLabel";
            // 
            // userPic
            // 
            this.userPic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.userPic, "userPic");
            this.userPic.Name = "userPic";
            this.userPic.TabStop = false;
            // 
            // PassPic
            // 
            this.PassPic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PassPic, "PassPic");
            this.PassPic.Name = "PassPic";
            this.PassPic.TabStop = false;
            // 
            // passInputLabel
            // 
            resources.ApplyResources(this.passInputLabel, "passInputLabel");
            this.passInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.passInputLabel.Name = "passInputLabel";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.LightGray;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.usernameInput, "usernameInput");
            this.usernameInput.ForeColor = System.Drawing.Color.Black;
            this.usernameInput.Name = "usernameInput";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.LightGray;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.passwordInput, "passwordInput");
            this.passwordInput.ForeColor = System.Drawing.Color.Black;
            this.passwordInput.Name = "passwordInput";
            // 
            // rPassPanel
            // 
            resources.ApplyResources(this.rPassPanel, "rPassPanel");
            this.rPassPanel.BackColor = System.Drawing.Color.Transparent;
            this.rPassPanel.Controls.Add(this.panel3);
            this.rPassPanel.Controls.Add(this.rPassPic);
            this.rPassPanel.Controls.Add(this.rPassInputLabel);
            this.rPassPanel.Controls.Add(this.rPassInput);
            this.rPassPanel.Name = "rPassPanel";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Name = "panel3";
            // 
            // rPassPic
            // 
            this.rPassPic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.rPassPic, "rPassPic");
            this.rPassPic.Name = "rPassPic";
            this.rPassPic.TabStop = false;
            // 
            // rPassInputLabel
            // 
            resources.ApplyResources(this.rPassInputLabel, "rPassInputLabel");
            this.rPassInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.rPassInputLabel.Name = "rPassInputLabel";
            // 
            // rPassInput
            // 
            this.rPassInput.BackColor = System.Drawing.Color.LightGray;
            this.rPassInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rPassInput, "rPassInput");
            this.rPassInput.ForeColor = System.Drawing.Color.Black;
            this.rPassInput.Name = "rPassInput";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblConnectionStatus, "lblConnectionStatus");
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            // 
            // dbBox
            // 
            resources.ApplyResources(this.dbBox, "dbBox");
            this.dbBox.BackColor = System.Drawing.Color.Transparent;
            this.dbBox.Name = "dbBox";
            this.dbBox.TabStop = false;
            this.dbBox.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.registerButton, "registerButton");
            this.registerButton.Name = "registerButton";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // acceptRulesInput
            // 
            resources.ApplyResources(this.acceptRulesInput, "acceptRulesInput");
            this.acceptRulesInput.BackColor = System.Drawing.Color.Transparent;
            this.acceptRulesInput.Name = "acceptRulesInput";
            this.acceptRulesInput.UseVisualStyleBackColor = false;
            // 
            // acceptRulesLabel
            // 
            resources.ApplyResources(this.acceptRulesLabel, "acceptRulesLabel");
            this.acceptRulesLabel.BackColor = System.Drawing.Color.Transparent;
            this.acceptRulesLabel.Name = "acceptRulesLabel";
            this.acceptRulesLabel.TabStop = true;
            this.acceptRulesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.acceptRulesLabel_LinkClicked);
            // 
            // userPanel
            // 
            resources.ApplyResources(this.userPanel, "userPanel");
            this.userPanel.BackColor = System.Drawing.Color.Black;
            this.userPanel.Name = "userPanel";
            // 
            // passPanel
            // 
            this.passPanel.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.passPanel, "passPanel");
            this.passPanel.Name = "passPanel";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.Name = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // changeLanguageButton
            // 
            resources.ApplyResources(this.changeLanguageButton, "changeLanguageButton");
            this.changeLanguageButton.BackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeLanguageButton.FlatAppearance.BorderSize = 0;
            this.changeLanguageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.ForeColor = System.Drawing.Color.White;
            this.changeLanguageButton.Name = "changeLanguageButton";
            this.changeLanguageButton.UseVisualStyleBackColor = false;
            this.changeLanguageButton.Click += new System.EventHandler(this.changeLanguageButton_Click);
            // 
            // lockBox
            // 
            resources.ApplyResources(this.lockBox, "lockBox");
            this.lockBox.BackColor = System.Drawing.Color.Transparent;
            this.lockBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockBox.FlatAppearance.BorderSize = 0;
            this.lockBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lockBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lockBox.ForeColor = System.Drawing.Color.White;
            this.lockBox.Name = "lockBox";
            this.lockBox.UseVisualStyleBackColor = false;
            this.lockBox.Click += new System.EventHandler(this.lockBox_Click);
            // 
            // LogInModule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.lockBox);
            this.Controls.Add(this.changeLanguageButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.passPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.acceptRulesLabel);
            this.Controls.Add(this.acceptRulesInput);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.dbBox);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.rPassPanel);
            this.Controls.Add(this.PassPic);
            this.Controls.Add(this.passInputLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.logo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogInModule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInModule_FormClosing);
            this.Load += new System.EventHandler(this.LogInModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).EndInit();
            this.rPassPanel.ResumeLayout(false);
            this.rPassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rPassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.PictureBox PassPic;
        private System.Windows.Forms.Label passInputLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Panel rPassPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.PictureBox dbBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox rPassPic;
        private System.Windows.Forms.Label rPassInputLabel;
        private System.Windows.Forms.TextBox rPassInput;
        private System.Windows.Forms.CheckBox acceptRulesInput;
        private System.Windows.Forms.LinkLabel acceptRulesLabel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel passPanel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button changeLanguageButton;
        private System.Windows.Forms.Button lockBox;
    }
}

