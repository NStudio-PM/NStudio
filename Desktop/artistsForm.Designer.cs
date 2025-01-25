namespace NStudio.Desktop
{
    partial class artistsForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelBox = new System.Windows.Forms.ComboBox();
            this.ArtistLabelLabel = new System.Windows.Forms.Label();
            this.ArtistNickLabel = new System.Windows.Forms.Label();
            this.nickSearchTextBox = new System.Windows.Forms.TextBox();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.ArtistEditButton = new FontAwesome.Sharp.IconButton();
            this.ArtistMinusButton = new FontAwesome.Sharp.IconButton();
            this.ArtistPlusButton = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMain.Controls.Add(this.flowPanel);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.MinimumSize = new System.Drawing.Size(550, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(674, 461);
            this.panelMain.TabIndex = 3;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(35, 25);
            this.flowPanel.MinimumSize = new System.Drawing.Size(520, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.flowPanel.Size = new System.Drawing.Size(639, 336);
            this.flowPanel.TabIndex = 7;
            this.flowPanel.Tag = "down";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 336);
            this.panel2.TabIndex = 6;
            this.panel2.Tag = "down";
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
            this.panel1.Tag = "down";
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
            this.LabelBox.SelectedValueChanged += new System.EventHandler(this.LabelBox_SelectedValueChanged);
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
            this.ArtistLabelLabel.Tag = "font";
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
            this.ArtistNickLabel.Tag = "font";
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
            this.nickSearchTextBox.TextChanged += new System.EventHandler(this.nickSearchTextBox_TextChanged);
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
            this.ArtistNameLabel.Tag = "font";
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
            this.nameSearchTextBox.TextChanged += new System.EventHandler(this.nameSearchTextBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 25);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Tag = "down";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelActions.Controls.Add(this.ArtistEditButton);
            this.panelActions.Controls.Add(this.ArtistMinusButton);
            this.panelActions.Controls.Add(this.ArtistPlusButton);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(674, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(80, 461);
            this.panelActions.TabIndex = 4;
            this.panelActions.Tag = "up";
            // 
            // ArtistEditButton
            // 
            this.ArtistEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArtistEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArtistEditButton.Enabled = false;
            this.ArtistEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArtistEditButton.FlatAppearance.BorderSize = 0;
            this.ArtistEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ArtistEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ArtistEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistEditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ArtistEditButton.IconColor = System.Drawing.Color.LightSeaGreen;
            this.ArtistEditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArtistEditButton.IconSize = 45;
            this.ArtistEditButton.Location = new System.Drawing.Point(16, 223);
            this.ArtistEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.ArtistEditButton.Name = "ArtistEditButton";
            this.ArtistEditButton.Size = new System.Drawing.Size(55, 46);
            this.ArtistEditButton.TabIndex = 2;
            this.ArtistEditButton.UseVisualStyleBackColor = true;
            this.ArtistEditButton.Click += new System.EventHandler(this.ArtistEditButton_Click);
            // 
            // ArtistMinusButton
            // 
            this.ArtistMinusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArtistMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArtistMinusButton.Enabled = false;
            this.ArtistMinusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArtistMinusButton.FlatAppearance.BorderSize = 0;
            this.ArtistMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ArtistMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ArtistMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistMinusButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ArtistMinusButton.IconColor = System.Drawing.Color.Maroon;
            this.ArtistMinusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ArtistMinusButton.IconSize = 60;
            this.ArtistMinusButton.Location = new System.Drawing.Point(16, 177);
            this.ArtistMinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.ArtistMinusButton.Name = "ArtistMinusButton";
            this.ArtistMinusButton.Size = new System.Drawing.Size(55, 46);
            this.ArtistMinusButton.TabIndex = 1;
            this.ArtistMinusButton.UseVisualStyleBackColor = true;
            this.ArtistMinusButton.Click += new System.EventHandler(this.ArtistMinusButton_Click);
            // 
            // ArtistPlusButton
            // 
            this.ArtistPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArtistPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArtistPlusButton.Enabled = false;
            this.ArtistPlusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArtistPlusButton.FlatAppearance.BorderSize = 0;
            this.ArtistPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ArtistPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ArtistPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistPlusButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ArtistPlusButton.IconColor = System.Drawing.Color.Green;
            this.ArtistPlusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ArtistPlusButton.IconSize = 60;
            this.ArtistPlusButton.Location = new System.Drawing.Point(16, 131);
            this.ArtistPlusButton.Margin = new System.Windows.Forms.Padding(0);
            this.ArtistPlusButton.Name = "ArtistPlusButton";
            this.ArtistPlusButton.Size = new System.Drawing.Size(55, 46);
            this.ArtistPlusButton.TabIndex = 0;
            this.ArtistPlusButton.UseVisualStyleBackColor = true;
            this.ArtistPlusButton.Click += new System.EventHandler(this.ArtistPlusButton_Click);
            // 
            // artistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(754, 461);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.Name = "artistsForm";
            this.Text = "artistsForm";
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private FontAwesome.Sharp.IconButton ArtistPlusButton;
        private FontAwesome.Sharp.IconButton ArtistMinusButton;
        private FontAwesome.Sharp.IconButton ArtistEditButton;
        private System.Windows.Forms.Label ArtistLabelLabel;
        private System.Windows.Forms.Label ArtistNickLabel;
        private System.Windows.Forms.TextBox nickSearchTextBox;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.ComboBox LabelBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}