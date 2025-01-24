namespace NStudio.Desktop
{
    partial class songsForm
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelBox = new System.Windows.Forms.ComboBox();
            this.ArtistLabelLabel = new System.Windows.Forms.Label();
            this.ArtistNickLabel = new System.Windows.Forms.Label();
            this.nickSearchTextBox = new System.Windows.Forms.TextBox();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.SongsEditButton = new FontAwesome.Sharp.IconButton();
            this.SongsMinusButton = new FontAwesome.Sharp.IconButton();
            this.SongsPlusButton = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.MinimumSize = new System.Drawing.Size(520, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(520, 336);
            this.flowPanel.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.MinimumSize = new System.Drawing.Size(550, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(674, 461);
            this.panelMain.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.panel2.Size = new System.Drawing.Size(674, 336);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(90, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 336);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 336);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelBox);
            this.panel1.Controls.Add(this.ArtistLabelLabel);
            this.panel1.Controls.Add(this.ArtistNickLabel);
            this.panel1.Controls.Add(this.nickSearchTextBox);
            this.panel1.Controls.Add(this.ArtistNameLabel);
            this.panel1.Controls.Add(this.nameSearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 100);
            this.panel1.TabIndex = 5;
            // 
            // LabelBox
            // 
            this.LabelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.LabelBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBox.ForeColor = System.Drawing.Color.White;
            this.LabelBox.FormattingEnabled = true;
            this.LabelBox.Location = new System.Drawing.Point(344, 19);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(135, 24);
            this.LabelBox.TabIndex = 5;
            // 
            // ArtistLabelLabel
            // 
            this.ArtistLabelLabel.AutoSize = true;
            this.ArtistLabelLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArtistLabelLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistLabelLabel.Location = new System.Drawing.Point(289, 21);
            this.ArtistLabelLabel.Name = "ArtistLabelLabel";
            this.ArtistLabelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ArtistLabelLabel.Size = new System.Drawing.Size(49, 18);
            this.ArtistLabelLabel.TabIndex = 4;
            this.ArtistLabelLabel.Text = "Label";
            // 
            // ArtistNickLabel
            // 
            this.ArtistNickLabel.AutoSize = true;
            this.ArtistNickLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArtistNickLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistNickLabel.Location = new System.Drawing.Point(23, 51);
            this.ArtistNickLabel.Name = "ArtistNickLabel";
            this.ArtistNickLabel.Size = new System.Drawing.Size(88, 18);
            this.ArtistNickLabel.TabIndex = 3;
            this.ArtistNickLabel.Text = "Pseudonim";
            // 
            // nickSearchTextBox
            // 
            this.nickSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.nickSearchTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickSearchTextBox.ForeColor = System.Drawing.Color.White;
            this.nickSearchTextBox.Location = new System.Drawing.Point(118, 52);
            this.nickSearchTextBox.Name = "nickSearchTextBox";
            this.nickSearchTextBox.Size = new System.Drawing.Size(138, 22);
            this.nickSearchTextBox.TabIndex = 2;
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArtistNameLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistNameLabel.Location = new System.Drawing.Point(23, 21);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ArtistNameLabel.Size = new System.Drawing.Size(58, 18);
            this.ArtistNameLabel.TabIndex = 1;
            this.ArtistNameLabel.Text = "Nazwa";
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.nameSearchTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameSearchTextBox.ForeColor = System.Drawing.Color.White;
            this.nameSearchTextBox.Location = new System.Drawing.Point(118, 19);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(138, 22);
            this.nameSearchTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 25);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelActions.Controls.Add(this.SongsEditButton);
            this.panelActions.Controls.Add(this.SongsMinusButton);
            this.panelActions.Controls.Add(this.SongsPlusButton);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(674, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(80, 461);
            this.panelActions.TabIndex = 6;
            // 
            // SongsEditButton
            // 
            this.SongsEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SongsEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongsEditButton.Enabled = false;
            this.SongsEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SongsEditButton.FlatAppearance.BorderSize = 0;
            this.SongsEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.SongsEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.SongsEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongsEditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.SongsEditButton.IconColor = System.Drawing.Color.LightSeaGreen;
            this.SongsEditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SongsEditButton.IconSize = 45;
            this.SongsEditButton.Location = new System.Drawing.Point(16, 223);
            this.SongsEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.SongsEditButton.Name = "SongsEditButton";
            this.SongsEditButton.Size = new System.Drawing.Size(55, 46);
            this.SongsEditButton.TabIndex = 2;
            this.SongsEditButton.UseVisualStyleBackColor = true;
            this.SongsEditButton.Click += new System.EventHandler(this.SongsEditButton_Click);
            // 
            // SongsMinusButton
            // 
            this.SongsMinusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SongsMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongsMinusButton.Enabled = false;
            this.SongsMinusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SongsMinusButton.FlatAppearance.BorderSize = 0;
            this.SongsMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.SongsMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.SongsMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongsMinusButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.SongsMinusButton.IconColor = System.Drawing.Color.Maroon;
            this.SongsMinusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SongsMinusButton.IconSize = 60;
            this.SongsMinusButton.Location = new System.Drawing.Point(16, 177);
            this.SongsMinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.SongsMinusButton.Name = "SongsMinusButton";
            this.SongsMinusButton.Size = new System.Drawing.Size(55, 46);
            this.SongsMinusButton.TabIndex = 1;
            this.SongsMinusButton.UseVisualStyleBackColor = true;
            this.SongsMinusButton.Click += new System.EventHandler(this.SongsMinusButton_Click);
            // 
            // SongsPlusButton
            // 
            this.SongsPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SongsPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongsPlusButton.Enabled = false;
            this.SongsPlusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SongsPlusButton.FlatAppearance.BorderSize = 0;
            this.SongsPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.SongsPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.SongsPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongsPlusButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.SongsPlusButton.IconColor = System.Drawing.Color.Green;
            this.SongsPlusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SongsPlusButton.IconSize = 60;
            this.SongsPlusButton.Location = new System.Drawing.Point(16, 131);
            this.SongsPlusButton.Margin = new System.Windows.Forms.Padding(0);
            this.SongsPlusButton.Name = "SongsPlusButton";
            this.SongsPlusButton.Size = new System.Drawing.Size(55, 46);
            this.SongsPlusButton.TabIndex = 0;
            this.SongsPlusButton.UseVisualStyleBackColor = true;
            this.SongsPlusButton.Click += new System.EventHandler(this.SongsPlusButton_Click);
            // 
            // songsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(754, 461);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.Name = "songsForm";
            this.Text = "songsForm";
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox LabelBox;
        private System.Windows.Forms.Label ArtistLabelLabel;
        private System.Windows.Forms.Label ArtistNickLabel;
        private System.Windows.Forms.TextBox nickSearchTextBox;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelActions;
        private FontAwesome.Sharp.IconButton SongsEditButton;
        private FontAwesome.Sharp.IconButton SongsMinusButton;
        private FontAwesome.Sharp.IconButton SongsPlusButton;
        private System.Windows.Forms.Panel panel4;
    }
}