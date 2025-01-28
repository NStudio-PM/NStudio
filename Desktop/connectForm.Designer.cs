namespace NStudio.Desktop
{
    partial class connectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.recordsBox = new System.Windows.Forms.Button();
            this.songsBox = new System.Windows.Forms.Button();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.songsLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.recordsBox);
            this.mainPanel.Controls.Add(this.songsBox);
            this.mainPanel.Controls.Add(this.recordsLabel);
            this.mainPanel.Controls.Add(this.songsLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(236, 100);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Tag = "up";
            // 
            // recordsBox
            // 
            this.recordsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recordsBox.BackColor = System.Drawing.Color.Transparent;
            this.recordsBox.BackgroundImage = global::NStudio.Properties.Resources.vinyl;
            this.recordsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recordsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordsBox.FlatAppearance.BorderSize = 0;
            this.recordsBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.recordsBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.recordsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.recordsBox.ForeColor = System.Drawing.Color.White;
            this.recordsBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recordsBox.Location = new System.Drawing.Point(146, 14);
            this.recordsBox.Margin = new System.Windows.Forms.Padding(0);
            this.recordsBox.Name = "recordsBox";
            this.recordsBox.Size = new System.Drawing.Size(50, 50);
            this.recordsBox.TabIndex = 29;
            this.recordsBox.UseVisualStyleBackColor = false;
            this.recordsBox.Click += new System.EventHandler(this.recordsBox_Click);
            // 
            // songsBox
            // 
            this.songsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.songsBox.BackColor = System.Drawing.Color.Transparent;
            this.songsBox.BackgroundImage = global::NStudio.Properties.Resources.notes;
            this.songsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.songsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songsBox.FlatAppearance.BorderSize = 0;
            this.songsBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.songsBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.songsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.songsBox.ForeColor = System.Drawing.Color.White;
            this.songsBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songsBox.Location = new System.Drawing.Point(41, 14);
            this.songsBox.Margin = new System.Windows.Forms.Padding(0);
            this.songsBox.Name = "songsBox";
            this.songsBox.Size = new System.Drawing.Size(50, 50);
            this.songsBox.TabIndex = 28;
            this.songsBox.UseVisualStyleBackColor = false;
            this.songsBox.Click += new System.EventHandler(this.songsBox_Click);
            // 
            // recordsLabel
            // 
            this.recordsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recordsLabel.ForeColor = System.Drawing.Color.White;
            this.recordsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordsLabel.Location = new System.Drawing.Point(132, 64);
            this.recordsLabel.Name = "recordsLabel";
            this.recordsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recordsLabel.Size = new System.Drawing.Size(77, 22);
            this.recordsLabel.TabIndex = 27;
            this.recordsLabel.Tag = "font";
            this.recordsLabel.Text = "recordsLabel";
            this.recordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songsLabel
            // 
            this.songsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.songsLabel.ForeColor = System.Drawing.Color.White;
            this.songsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songsLabel.Location = new System.Drawing.Point(28, 64);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.songsLabel.Size = new System.Drawing.Size(77, 22);
            this.songsLabel.TabIndex = 26;
            this.songsLabel.Tag = "font";
            this.songsLabel.Text = "songsLabel";
            this.songsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(236, 100);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(252, 139);
            this.MinimumSize = new System.Drawing.Size(252, 139);
            this.Name = "connectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "up";
            this.Text = "connectForm";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button recordsBox;
        private System.Windows.Forms.Button songsBox;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.Label songsLabel;
    }
}