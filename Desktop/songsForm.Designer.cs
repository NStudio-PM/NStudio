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
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.recordBox = new System.Windows.Forms.ComboBox();
            this.recordLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorSearchBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleSearchBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.yearBox);
            this.panel1.Controls.Add(this.recordBox);
            this.panel1.Controls.Add(this.recordLabel);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.authorSearchBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.titleSearchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 100);
            this.panel1.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(273, 53);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearLabel.Size = new System.Drawing.Size(42, 18);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year";
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.yearBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.ForeColor = System.Drawing.Color.White;
            this.yearBox.Location = new System.Drawing.Point(344, 52);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(67, 22);
            this.yearBox.TabIndex = 6;
            this.yearBox.TextChanged += new System.EventHandler(this.YearSearchTextBox_TextChanged);
            // 
            // recordBox
            // 
            this.recordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.recordBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recordBox.ForeColor = System.Drawing.Color.White;
            this.recordBox.FormattingEnabled = true;
            this.recordBox.Location = new System.Drawing.Point(344, 19);
            this.recordBox.Name = "recordBox";
            this.recordBox.Size = new System.Drawing.Size(135, 24);
            this.recordBox.TabIndex = 5;
            this.recordBox.SelectedValueChanged += new System.EventHandler(this.RecordBox_SelectedValueChanged);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recordLabel.ForeColor = System.Drawing.Color.White;
            this.recordLabel.Location = new System.Drawing.Point(273, 21);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recordLabel.Size = new System.Drawing.Size(62, 18);
            this.recordLabel.TabIndex = 4;
            this.recordLabel.Text = "Record";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorLabel.ForeColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(23, 51);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(56, 18);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author";
            // 
            // authorSearchBox
            // 
            this.authorSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.authorSearchBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorSearchBox.ForeColor = System.Drawing.Color.White;
            this.authorSearchBox.Location = new System.Drawing.Point(118, 52);
            this.authorSearchBox.Name = "authorSearchBox";
            this.authorSearchBox.Size = new System.Drawing.Size(138, 22);
            this.authorSearchBox.TabIndex = 2;
            this.authorSearchBox.TextChanged += new System.EventHandler(this.AuthorSearchTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(23, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLabel.Size = new System.Drawing.Size(36, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // titleSearchBox
            // 
            this.titleSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.titleSearchBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleSearchBox.ForeColor = System.Drawing.Color.White;
            this.titleSearchBox.Location = new System.Drawing.Point(118, 19);
            this.titleSearchBox.Name = "titleSearchBox";
            this.titleSearchBox.Size = new System.Drawing.Size(138, 22);
            this.titleSearchBox.TabIndex = 0;
            this.titleSearchBox.TextChanged += new System.EventHandler(this.TitleSearchTextBox_TextChanged);
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
        private System.Windows.Forms.ComboBox recordBox;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorSearchBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleSearchBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelActions;
        private FontAwesome.Sharp.IconButton SongsEditButton;
        private FontAwesome.Sharp.IconButton SongsMinusButton;
        private FontAwesome.Sharp.IconButton SongsPlusButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearBox;
    }
}