namespace NStudio.Desktop.Query
{
    partial class adminInfo
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
            this.adminChoiceLabel = new System.Windows.Forms.Label();
            this.adminChoiceBox = new System.Windows.Forms.ComboBox();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminChoiceLabel
            // 
            this.adminChoiceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.adminChoiceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminChoiceLabel.Location = new System.Drawing.Point(3, 19);
            this.adminChoiceLabel.Name = "adminChoiceLabel";
            this.adminChoiceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminChoiceLabel.Size = new System.Drawing.Size(253, 22);
            this.adminChoiceLabel.TabIndex = 7;
            this.adminChoiceLabel.Text = "adminChoiceLabel";
            this.adminChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminChoiceBox
            // 
            this.adminChoiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.adminChoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminChoiceBox.ForeColor = System.Drawing.Color.White;
            this.adminChoiceBox.FormattingEnabled = true;
            this.adminChoiceBox.Location = new System.Drawing.Point(35, 44);
            this.adminChoiceBox.Name = "adminChoiceBox";
            this.adminChoiceBox.Size = new System.Drawing.Size(192, 23);
            this.adminChoiceBox.TabIndex = 8;
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
            this.rejectButton.Location = new System.Drawing.Point(143, 84);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(0);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(70, 25);
            this.rejectButton.TabIndex = 21;
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
            this.acceptButton.Location = new System.Drawing.Point(46, 84);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(70, 25);
            this.acceptButton.TabIndex = 20;
            this.acceptButton.Text = "acceptButton";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // adminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(258, 136);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.adminChoiceBox);
            this.Controls.Add(this.adminChoiceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminChoiceLabel;
        private System.Windows.Forms.ComboBox adminChoiceBox;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
    }
}