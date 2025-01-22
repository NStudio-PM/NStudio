namespace NStudio.Desktop
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.changeLanguageLabel = new System.Windows.Forms.Label();
            this.changeLanguageButton = new System.Windows.Forms.Button();
            this.bufforPanel = new System.Windows.Forms.Panel();
            this.bufforPanel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoutPanel = new System.Windows.Forms.Panel();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.logoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeLanguageLabel
            // 
            this.changeLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeLanguageLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeLanguageLabel.ForeColor = System.Drawing.Color.White;
            this.changeLanguageLabel.Location = new System.Drawing.Point(70, 13);
            this.changeLanguageLabel.MaximumSize = new System.Drawing.Size(252, 28);
            this.changeLanguageLabel.MinimumSize = new System.Drawing.Size(252, 28);
            this.changeLanguageLabel.Name = "changeLanguageLabel";
            this.changeLanguageLabel.Size = new System.Drawing.Size(252, 28);
            this.changeLanguageLabel.TabIndex = 1;
            this.changeLanguageLabel.Text = "changeLanguageLabel";
            this.changeLanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLanguageButton
            // 
            this.changeLanguageButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeLanguageButton.BackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeLanguageButton.BackgroundImage")));
            this.changeLanguageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeLanguageButton.FlatAppearance.BorderSize = 0;
            this.changeLanguageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeLanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLanguageButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.changeLanguageButton.ForeColor = System.Drawing.Color.White;
            this.changeLanguageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeLanguageButton.Location = new System.Drawing.Point(325, 11);
            this.changeLanguageButton.Margin = new System.Windows.Forms.Padding(0);
            this.changeLanguageButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.changeLanguageButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.changeLanguageButton.Name = "changeLanguageButton";
            this.changeLanguageButton.Size = new System.Drawing.Size(40, 40);
            this.changeLanguageButton.TabIndex = 21;
            this.changeLanguageButton.UseVisualStyleBackColor = false;
            this.changeLanguageButton.Click += new System.EventHandler(this.changeLanguageButton_Click);
            // 
            // bufforPanel
            // 
            this.bufforPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bufforPanel.Location = new System.Drawing.Point(604, 0);
            this.bufforPanel.Name = "bufforPanel";
            this.bufforPanel.Size = new System.Drawing.Size(150, 461);
            this.bufforPanel.TabIndex = 22;
            // 
            // bufforPanel2
            // 
            this.bufforPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bufforPanel2.Location = new System.Drawing.Point(0, 0);
            this.bufforPanel2.Name = "bufforPanel2";
            this.bufforPanel2.Size = new System.Drawing.Size(150, 461);
            this.bufforPanel2.TabIndex = 23;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.logoutPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(150, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(454, 461);
            this.mainPanel.TabIndex = 24;
            // 
            // logoutPanel
            // 
            this.logoutPanel.Controls.Add(this.logOutLabel);
            this.logoutPanel.Controls.Add(this.logOutButton);
            this.logoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutPanel.Location = new System.Drawing.Point(0, 403);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.Size = new System.Drawing.Size(454, 58);
            this.logoutPanel.TabIndex = 24;
            // 
            // logOutLabel
            // 
            this.logOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutLabel.ForeColor = System.Drawing.Color.White;
            this.logOutLabel.Location = new System.Drawing.Point(125, 10);
            this.logOutLabel.MaximumSize = new System.Drawing.Size(139, 30);
            this.logOutLabel.MinimumSize = new System.Drawing.Size(139, 30);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(139, 30);
            this.logOutLabel.TabIndex = 22;
            this.logOutLabel.Text = "logOutLabel";
            this.logOutLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutButton.BackgroundImage")));
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logOutButton.Location = new System.Drawing.Point(278, 9);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logOutButton.MaximumSize = new System.Drawing.Size(44, 40);
            this.logOutButton.MinimumSize = new System.Drawing.Size(44, 40);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(44, 40);
            this.logOutButton.TabIndex = 23;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeLanguageLabel);
            this.panel1.Controls.Add(this.changeLanguageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 58);
            this.panel1.TabIndex = 25;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(754, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bufforPanel2);
            this.Controls.Add(this.bufforPanel);
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.mainPanel.ResumeLayout(false);
            this.logoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label changeLanguageLabel;
        private System.Windows.Forms.Button changeLanguageButton;
        private System.Windows.Forms.Panel bufforPanel;
        private System.Windows.Forms.Panel bufforPanel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel logoutPanel;
        private System.Windows.Forms.Panel panel1;
    }
}