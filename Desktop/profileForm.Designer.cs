namespace NStudio.Desktop
{
    partial class profileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.l1 = new FontAwesome.Sharp.IconButton();
            this.l2 = new FontAwesome.Sharp.IconButton();
            this.p2 = new FontAwesome.Sharp.IconButton();
            this.p1 = new FontAwesome.Sharp.IconButton();
            this.panelProfileHeader = new System.Windows.Forms.Panel();
            this.panelProfileLbl = new System.Windows.Forms.Panel();
            this.editProfileLabel = new System.Windows.Forms.Label();
            this.panelProfileBuffor = new System.Windows.Forms.Panel();
            this.panelProfileMain = new System.Windows.Forms.Panel();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.changeAvatarButton = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.panelProfileBufforRight = new System.Windows.Forms.Panel();
            this.panelProfileBufforLeft = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panelProfileHeader.SuspendLayout();
            this.panelProfileLbl.SuspendLayout();
            this.panelProfileMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.panelProfileBufforRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.FlatAppearance.BorderSize = 0;
            this.l1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.IconChar = FontAwesome.Sharp.IconChar.E;
            this.l1.IconColor = System.Drawing.Color.White;
            this.l1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.l1.Location = new System.Drawing.Point(13, 37);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(25, 44);
            this.l1.TabIndex = 0;
            this.l1.UseVisualStyleBackColor = false;
            this.l1.Visible = false;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.FlatAppearance.BorderSize = 0;
            this.l2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.IconChar = FontAwesome.Sharp.IconChar.N;
            this.l2.IconColor = System.Drawing.Color.White;
            this.l2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.l2.Location = new System.Drawing.Point(43, 37);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(25, 44);
            this.l2.TabIndex = 1;
            this.l2.UseVisualStyleBackColor = false;
            this.l2.Visible = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.FlatAppearance.BorderSize = 0;
            this.p2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2.ForeColor = System.Drawing.Color.White;
            this.p2.IconChar = FontAwesome.Sharp.IconChar.L;
            this.p2.IconColor = System.Drawing.Color.White;
            this.p2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.p2.Location = new System.Drawing.Point(33, 99);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(40, 53);
            this.p2.TabIndex = 3;
            this.p2.UseVisualStyleBackColor = false;
            this.p2.Visible = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.FlatAppearance.BorderSize = 0;
            this.p1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1.ForeColor = System.Drawing.Color.White;
            this.p1.IconChar = FontAwesome.Sharp.IconChar.P;
            this.p1.IconColor = System.Drawing.Color.White;
            this.p1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.p1.Location = new System.Drawing.Point(3, 99);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(40, 53);
            this.p1.TabIndex = 2;
            this.p1.UseVisualStyleBackColor = false;
            this.p1.Visible = false;
            // 
            // panelProfileHeader
            // 
            this.panelProfileHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelProfileHeader.Controls.Add(this.panelProfileLbl);
            this.panelProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProfileHeader.Name = "panelProfileHeader";
            this.panelProfileHeader.Size = new System.Drawing.Size(454, 70);
            this.panelProfileHeader.TabIndex = 4;
            // 
            // panelProfileLbl
            // 
            this.panelProfileLbl.Controls.Add(this.editProfileLabel);
            this.panelProfileLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProfileLbl.Location = new System.Drawing.Point(0, 20);
            this.panelProfileLbl.Name = "panelProfileLbl";
            this.panelProfileLbl.Size = new System.Drawing.Size(454, 50);
            this.panelProfileLbl.TabIndex = 0;
            // 
            // editProfileLabel
            // 
            this.editProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProfileLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editProfileLabel.ForeColor = System.Drawing.Color.White;
            this.editProfileLabel.Location = new System.Drawing.Point(10, 0);
            this.editProfileLabel.Name = "editProfileLabel";
            this.editProfileLabel.Size = new System.Drawing.Size(437, 28);
            this.editProfileLabel.TabIndex = 0;
            this.editProfileLabel.Text = "EDIT PROFILE";
            this.editProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProfileBuffor
            // 
            this.panelProfileBuffor.BackColor = System.Drawing.Color.Transparent;
            this.panelProfileBuffor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileBuffor.Location = new System.Drawing.Point(0, 70);
            this.panelProfileBuffor.Name = "panelProfileBuffor";
            this.panelProfileBuffor.Size = new System.Drawing.Size(454, 10);
            this.panelProfileBuffor.TabIndex = 5;
            // 
            // panelProfileMain
            // 
            this.panelProfileMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelProfileMain.Controls.Add(this.changePasswordButton);
            this.panelProfileMain.Controls.Add(this.changePasswordLabel);
            this.panelProfileMain.Controls.Add(this.streetBox);
            this.panelProfileMain.Controls.Add(this.postcodeBox);
            this.panelProfileMain.Controls.Add(this.cityBox);
            this.panelProfileMain.Controls.Add(this.countryBox);
            this.panelProfileMain.Controls.Add(this.usernameBox);
            this.panelProfileMain.Controls.Add(this.rejectButton);
            this.panelProfileMain.Controls.Add(this.acceptButton);
            this.panelProfileMain.Controls.Add(this.changeAvatarButton);
            this.panelProfileMain.Controls.Add(this.avatarBox);
            this.panelProfileMain.Controls.Add(this.streetLabel);
            this.panelProfileMain.Controls.Add(this.postcodeLabel);
            this.panelProfileMain.Controls.Add(this.cityLabel);
            this.panelProfileMain.Controls.Add(this.countryLabel);
            this.panelProfileMain.Controls.Add(this.panelProfileBufforRight);
            this.panelProfileMain.Controls.Add(this.panelProfileBufforLeft);
            this.panelProfileMain.Controls.Add(this.usernameLabel);
            this.panelProfileMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileMain.Location = new System.Drawing.Point(0, 80);
            this.panelProfileMain.Name = "panelProfileMain";
            this.panelProfileMain.Size = new System.Drawing.Size(454, 563);
            this.panelProfileMain.TabIndex = 6;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePasswordButton.BackgroundImage")));
            this.changePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.changePasswordButton.ForeColor = System.Drawing.Color.DimGray;
            this.changePasswordButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changePasswordButton.Location = new System.Drawing.Point(198, 69);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(25, 25);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePasswordLabel.ForeColor = System.Drawing.Color.White;
            this.changePasswordLabel.Location = new System.Drawing.Point(46, 69);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changePasswordLabel.Size = new System.Drawing.Size(146, 22);
            this.changePasswordLabel.TabIndex = 20;
            this.changePasswordLabel.Text = "changePasswordLabel";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // streetBox
            // 
            this.streetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.streetBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.streetBox.ForeColor = System.Drawing.Color.White;
            this.streetBox.Location = new System.Drawing.Point(198, 251);
            this.streetBox.MaxLength = 32;
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(154, 22);
            this.streetBox.TabIndex = 14;
            this.streetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // postcodeBox
            // 
            this.postcodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.postcodeBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postcodeBox.ForeColor = System.Drawing.Color.White;
            this.postcodeBox.Location = new System.Drawing.Point(198, 215);
            this.postcodeBox.MaxLength = 6;
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.Size = new System.Drawing.Size(68, 22);
            this.postcodeBox.TabIndex = 12;
            this.postcodeBox.Text = "XX-XXX";
            this.postcodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cityBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityBox.ForeColor = System.Drawing.Color.White;
            this.cityBox.Location = new System.Drawing.Point(198, 174);
            this.cityBox.MaxLength = 32;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(154, 22);
            this.cityBox.TabIndex = 10;
            this.cityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countryBox
            // 
            this.countryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.countryBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryBox.ForeColor = System.Drawing.Color.White;
            this.countryBox.Location = new System.Drawing.Point(198, 133);
            this.countryBox.MaxLength = 32;
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(154, 22);
            this.countryBox.TabIndex = 8;
            this.countryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.usernameBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameBox.ForeColor = System.Drawing.Color.White;
            this.usernameBox.Location = new System.Drawing.Point(198, 37);
            this.usernameBox.MaxLength = 24;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(154, 22);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.Transparent;
            this.rejectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rejectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rejectButton.ForeColor = System.Drawing.Color.White;
            this.rejectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rejectButton.Location = new System.Drawing.Point(246, 503);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(0);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(110, 25);
            this.rejectButton.TabIndex = 19;
            this.rejectButton.Text = "rejectButton";
            this.rejectButton.UseVisualStyleBackColor = false;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acceptButton.Location = new System.Drawing.Point(94, 503);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(110, 25);
            this.acceptButton.TabIndex = 18;
            this.acceptButton.Text = "acceptButton";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // changeAvatarButton
            // 
            this.changeAvatarButton.BackColor = System.Drawing.Color.Transparent;
            this.changeAvatarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeAvatarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeAvatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeAvatarButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.changeAvatarButton.ForeColor = System.Drawing.Color.White;
            this.changeAvatarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeAvatarButton.Location = new System.Drawing.Point(166, 428);
            this.changeAvatarButton.Margin = new System.Windows.Forms.Padding(0);
            this.changeAvatarButton.Name = "changeAvatarButton";
            this.changeAvatarButton.Size = new System.Drawing.Size(125, 25);
            this.changeAvatarButton.TabIndex = 17;
            this.changeAvatarButton.Text = "changeAvatarButton";
            this.changeAvatarButton.UseVisualStyleBackColor = false;
            this.changeAvatarButton.Click += new System.EventHandler(this.changeAvatarButton_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.avatarBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.Location = new System.Drawing.Point(166, 290);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(125, 125);
            this.avatarBox.TabIndex = 16;
            this.avatarBox.TabStop = false;
            // 
            // streetLabel
            // 
            this.streetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.streetLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.streetLabel.ForeColor = System.Drawing.Color.White;
            this.streetLabel.Location = new System.Drawing.Point(46, 251);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.streetLabel.Size = new System.Drawing.Size(146, 22);
            this.streetLabel.TabIndex = 15;
            this.streetLabel.Text = "streetLabel";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postcodeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postcodeLabel.ForeColor = System.Drawing.Color.White;
            this.postcodeLabel.Location = new System.Drawing.Point(46, 215);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postcodeLabel.Size = new System.Drawing.Size(146, 22);
            this.postcodeLabel.TabIndex = 13;
            this.postcodeLabel.Text = "postcodeLabel";
            this.postcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(46, 174);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cityLabel.Size = new System.Drawing.Size(146, 22);
            this.cityLabel.TabIndex = 11;
            this.cityLabel.Text = "cityLabel";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryLabel.ForeColor = System.Drawing.Color.White;
            this.countryLabel.Location = new System.Drawing.Point(46, 133);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countryLabel.Size = new System.Drawing.Size(146, 22);
            this.countryLabel.TabIndex = 9;
            this.countryLabel.Text = "countryLabel";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelProfileBufforRight
            // 
            this.panelProfileBufforRight.Controls.Add(this.l2);
            this.panelProfileBufforRight.Controls.Add(this.l1);
            this.panelProfileBufforRight.Controls.Add(this.p1);
            this.panelProfileBufforRight.Controls.Add(this.p2);
            this.panelProfileBufforRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProfileBufforRight.Location = new System.Drawing.Point(374, 0);
            this.panelProfileBufforRight.Name = "panelProfileBufforRight";
            this.panelProfileBufforRight.Size = new System.Drawing.Size(80, 563);
            this.panelProfileBufforRight.TabIndex = 7;
            // 
            // panelProfileBufforLeft
            // 
            this.panelProfileBufforLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProfileBufforLeft.Location = new System.Drawing.Point(0, 0);
            this.panelProfileBufforLeft.Name = "panelProfileBufforLeft";
            this.panelProfileBufforLeft.Size = new System.Drawing.Size(29, 563);
            this.panelProfileBufforLeft.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(46, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameLabel.Size = new System.Drawing.Size(146, 22);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "usernameLabel";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(454, 638);
            this.Controls.Add(this.panelProfileMain);
            this.Controls.Add(this.panelProfileBuffor);
            this.Controls.Add(this.panelProfileHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "profileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profileForm";
            this.panelProfileHeader.ResumeLayout(false);
            this.panelProfileLbl.ResumeLayout(false);
            this.panelProfileMain.ResumeLayout(false);
            this.panelProfileMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.panelProfileBufforRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton l1;
        private FontAwesome.Sharp.IconButton l2;
        private FontAwesome.Sharp.IconButton p2;
        private FontAwesome.Sharp.IconButton p1;
        private System.Windows.Forms.Panel panelProfileHeader;
        private System.Windows.Forms.Panel panelProfileLbl;
        private System.Windows.Forms.Label editProfileLabel;
        private System.Windows.Forms.Panel panelProfileBuffor;
        private System.Windows.Forms.Panel panelProfileMain;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Panel panelProfileBufforRight;
        private System.Windows.Forms.Panel panelProfileBufforLeft;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.TextBox postcodeBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Button changeAvatarButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label changePasswordLabel;
    }
}