namespace NStudio.Desktop
{
    partial class recordsForm
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
            this.RecordsEditButton = new FontAwesome.Sharp.IconButton();
            this.RecordsPlusButton = new FontAwesome.Sharp.IconButton();
            this.panelActions = new System.Windows.Forms.Panel();
            this.RecordsMinusButton = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.labelBox = new System.Windows.Forms.ComboBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorSearchBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleSearchBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelActions.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordsEditButton
            // 
            this.RecordsEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecordsEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordsEditButton.Enabled = false;
            this.RecordsEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecordsEditButton.FlatAppearance.BorderSize = 0;
            this.RecordsEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.RecordsEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.RecordsEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordsEditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.RecordsEditButton.IconColor = System.Drawing.Color.LightSeaGreen;
            this.RecordsEditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RecordsEditButton.IconSize = 45;
            this.RecordsEditButton.Location = new System.Drawing.Point(16, 223);
            this.RecordsEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordsEditButton.Name = "RecordsEditButton";
            this.RecordsEditButton.Size = new System.Drawing.Size(55, 46);
            this.RecordsEditButton.TabIndex = 2;
            this.RecordsEditButton.UseVisualStyleBackColor = true;
            this.RecordsEditButton.Click += new System.EventHandler(this.RecordsEditButton_Click);
            // 
            // RecordsPlusButton
            // 
            this.RecordsPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecordsPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordsPlusButton.Enabled = false;
            this.RecordsPlusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecordsPlusButton.FlatAppearance.BorderSize = 0;
            this.RecordsPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.RecordsPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.RecordsPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordsPlusButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.RecordsPlusButton.IconColor = System.Drawing.Color.Green;
            this.RecordsPlusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.RecordsPlusButton.IconSize = 60;
            this.RecordsPlusButton.Location = new System.Drawing.Point(16, 131);
            this.RecordsPlusButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordsPlusButton.Name = "RecordsPlusButton";
            this.RecordsPlusButton.Size = new System.Drawing.Size(55, 46);
            this.RecordsPlusButton.TabIndex = 0;
            this.RecordsPlusButton.UseVisualStyleBackColor = true;
            this.RecordsPlusButton.Click += new System.EventHandler(this.RecordsPlusButton_Click);
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelActions.Controls.Add(this.RecordsEditButton);
            this.panelActions.Controls.Add(this.RecordsMinusButton);
            this.panelActions.Controls.Add(this.RecordsPlusButton);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(674, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(80, 461);
            this.panelActions.TabIndex = 8;
            // 
            // RecordsMinusButton
            // 
            this.RecordsMinusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecordsMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordsMinusButton.Enabled = false;
            this.RecordsMinusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecordsMinusButton.FlatAppearance.BorderSize = 0;
            this.RecordsMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.RecordsMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.RecordsMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordsMinusButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.RecordsMinusButton.IconColor = System.Drawing.Color.Maroon;
            this.RecordsMinusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.RecordsMinusButton.IconSize = 60;
            this.RecordsMinusButton.Location = new System.Drawing.Point(16, 177);
            this.RecordsMinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordsMinusButton.Name = "RecordsMinusButton";
            this.RecordsMinusButton.Size = new System.Drawing.Size(55, 46);
            this.RecordsMinusButton.TabIndex = 1;
            this.RecordsMinusButton.UseVisualStyleBackColor = true;
            this.RecordsMinusButton.Click += new System.EventHandler(this.RecordsMinusButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(754, 25);
            this.flowLayoutPanel1.TabIndex = 4;
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
            // labelBox
            // 
            this.labelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.labelBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBox.ForeColor = System.Drawing.Color.White;
            this.labelBox.FormattingEnabled = true;
            this.labelBox.Location = new System.Drawing.Point(344, 19);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(135, 24);
            this.labelBox.TabIndex = 5;
            this.labelBox.SelectedValueChanged += new System.EventHandler(this.LabelBox_SelectedValueChanged);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLabel.ForeColor = System.Drawing.Color.White;
            this.labelLabel.Location = new System.Drawing.Point(273, 21);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLabel.Size = new System.Drawing.Size(62, 18);
            this.labelLabel.TabIndex = 4;
            this.labelLabel.Text = "Record";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 336);
            this.panel3.TabIndex = 6;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.flowPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(90, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 336);
            this.panel4.TabIndex = 7;
            // 
            // flowPanel
            // 
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.MinimumSize = new System.Drawing.Size(520, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(564, 336);
            this.flowPanel.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(754, 336);
            this.panel2.TabIndex = 6;
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
            this.panelMain.Size = new System.Drawing.Size(754, 461);
            this.panelMain.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.yearBox);
            this.panel1.Controls.Add(this.labelBox);
            this.panel1.Controls.Add(this.labelLabel);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.authorSearchBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.titleSearchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 100);
            this.panel1.TabIndex = 5;
            // 
            // recordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(754, 461);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelMain);
            this.Name = "recordsForm";
            this.Text = "recordsForm";
            this.panelActions.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton RecordsEditButton;
        private FontAwesome.Sharp.IconButton RecordsPlusButton;
        private System.Windows.Forms.Panel panelActions;
        private FontAwesome.Sharp.IconButton RecordsMinusButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox labelBox;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorSearchBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleSearchBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
    }
}