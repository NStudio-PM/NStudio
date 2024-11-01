namespace NStudio
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.panelMenuBuffor = new System.Windows.Forms.Panel();
            this.shopButton = new FontAwesome.Sharp.IconButton();
            this.artistsButton = new FontAwesome.Sharp.IconButton();
            this.recordsButton = new FontAwesome.Sharp.IconButton();
            this.songsButton = new FontAwesome.Sharp.IconButton();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.panelTopBuffor = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.profileButton = new FontAwesome.Sharp.IconButton();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.panelMenuBuffor);
            this.panelMenu.Controls.Add(this.shopButton);
            this.panelMenu.Controls.Add(this.artistsButton);
            this.panelMenu.Controls.Add(this.recordsButton);
            this.panelMenu.Controls.Add(this.songsButton);
            this.panelMenu.Controls.Add(this.panelDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 30;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 420);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.settingsButton.Size = new System.Drawing.Size(220, 60);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "settingsButton";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // panelMenuBuffor
            // 
            this.panelMenuBuffor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBuffor.Location = new System.Drawing.Point(0, 360);
            this.panelMenuBuffor.Name = "panelMenuBuffor";
            this.panelMenuBuffor.Size = new System.Drawing.Size(220, 60);
            this.panelMenuBuffor.TabIndex = 6;
            // 
            // shopButton
            // 
            this.shopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.shopButton.FlatAppearance.BorderSize = 0;
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.shopButton.ForeColor = System.Drawing.Color.White;
            this.shopButton.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.shopButton.IconColor = System.Drawing.Color.White;
            this.shopButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.shopButton.IconSize = 30;
            this.shopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopButton.Location = new System.Drawing.Point(0, 300);
            this.shopButton.Name = "shopButton";
            this.shopButton.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.shopButton.Size = new System.Drawing.Size(220, 60);
            this.shopButton.TabIndex = 4;
            this.shopButton.Text = "shopButton";
            this.shopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // artistsButton
            // 
            this.artistsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.artistsButton.FlatAppearance.BorderSize = 0;
            this.artistsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistsButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.artistsButton.ForeColor = System.Drawing.Color.White;
            this.artistsButton.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.artistsButton.IconColor = System.Drawing.Color.White;
            this.artistsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.artistsButton.IconSize = 30;
            this.artistsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artistsButton.Location = new System.Drawing.Point(0, 240);
            this.artistsButton.Name = "artistsButton";
            this.artistsButton.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.artistsButton.Size = new System.Drawing.Size(220, 60);
            this.artistsButton.TabIndex = 3;
            this.artistsButton.Text = "artistsButton";
            this.artistsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artistsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.artistsButton.UseVisualStyleBackColor = true;
            this.artistsButton.Click += new System.EventHandler(this.artistsButton_Click);
            // 
            // recordsButton
            // 
            this.recordsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordsButton.FlatAppearance.BorderSize = 0;
            this.recordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.recordsButton.ForeColor = System.Drawing.Color.White;
            this.recordsButton.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            this.recordsButton.IconColor = System.Drawing.Color.White;
            this.recordsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.recordsButton.IconSize = 30;
            this.recordsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordsButton.Location = new System.Drawing.Point(0, 180);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.recordsButton.Size = new System.Drawing.Size(220, 60);
            this.recordsButton.TabIndex = 2;
            this.recordsButton.Text = "recordsButton";
            this.recordsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordsButton.UseVisualStyleBackColor = true;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            // 
            // songsButton
            // 
            this.songsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.songsButton.FlatAppearance.BorderSize = 0;
            this.songsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.songsButton.ForeColor = System.Drawing.Color.White;
            this.songsButton.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.songsButton.IconColor = System.Drawing.Color.White;
            this.songsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.songsButton.IconSize = 30;
            this.songsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songsButton.Location = new System.Drawing.Point(0, 120);
            this.songsButton.Name = "songsButton";
            this.songsButton.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.songsButton.Size = new System.Drawing.Size(220, 60);
            this.songsButton.TabIndex = 1;
            this.songsButton.Text = "songsButton";
            this.songsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.songsButton.UseVisualStyleBackColor = true;
            this.songsButton.Click += new System.EventHandler(this.songsButton_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.lblLogo);
            this.panelDashboard.Controls.Add(this.logo);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(220, 120);
            this.panelDashboard.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 62);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 24);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "NStudio";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(220, 62);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTitle.Controls.Add(this.userInfoPanel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(764, 65);
            this.panelTitle.TabIndex = 1;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoPanel.AutoSize = true;
            this.userInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.userInfoPanel.Controls.Add(this.profileNameLabel);
            this.userInfoPanel.Controls.Add(this.profileButton);
            this.userInfoPanel.Location = new System.Drawing.Point(541, 12);
            this.userInfoPanel.MaximumSize = new System.Drawing.Size(255, 44);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(211, 44);
            this.userInfoPanel.TabIndex = 0;
            // 
            // panelTopBuffor
            // 
            this.panelTopBuffor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelTopBuffor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBuffor.Location = new System.Drawing.Point(220, 65);
            this.panelTopBuffor.Name = "panelTopBuffor";
            this.panelTopBuffor.Size = new System.Drawing.Size(764, 7);
            this.panelTopBuffor.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(764, 489);
            this.panelDesktop.TabIndex = 3;
            // 
            // profileButton
            // 
            this.profileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.Color.Transparent;
            this.profileButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profileButton.IconColor = System.Drawing.Color.White;
            this.profileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileButton.IconSize = 36;
            this.profileButton.Location = new System.Drawing.Point(155, 3);
            this.profileButton.MaximumSize = new System.Drawing.Size(38, 38);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(38, 38);
            this.profileButton.TabIndex = 0;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(5, 3);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileNameLabel.Size = new System.Drawing.Size(144, 38);
            this.profileNameLabel.TabIndex = 1;
            this.profileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTopBuffor);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.userInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDashboard;
        private FontAwesome.Sharp.IconButton songsButton;
        private FontAwesome.Sharp.IconButton shopButton;
        private FontAwesome.Sharp.IconButton artistsButton;
        private FontAwesome.Sharp.IconButton recordsButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelTopBuffor;
        private System.Windows.Forms.Panel panelMenuBuffor;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel userInfoPanel;
        private FontAwesome.Sharp.IconButton profileButton;
        private System.Windows.Forms.Label profileNameLabel;
    }
}