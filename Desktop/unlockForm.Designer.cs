namespace NStudio.Desktop
{
    partial class unlockForm
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
            this.unlockTextBox = new System.Windows.Forms.TextBox();
            this.unlockLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unlockTextBox
            // 
            this.unlockTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.unlockTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unlockTextBox.ForeColor = System.Drawing.Color.White;
            this.unlockTextBox.Location = new System.Drawing.Point(43, 34);
            this.unlockTextBox.MaxLength = 32;
            this.unlockTextBox.Name = "unlockTextBox";
            this.unlockTextBox.PasswordChar = '*';
            this.unlockTextBox.Size = new System.Drawing.Size(154, 22);
            this.unlockTextBox.TabIndex = 11;
            this.unlockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unlockLabel
            // 
            this.unlockLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unlockLabel.ForeColor = System.Drawing.Color.White;
            this.unlockLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unlockLabel.Location = new System.Drawing.Point(12, 9);
            this.unlockLabel.Name = "unlockLabel";
            this.unlockLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.unlockLabel.Size = new System.Drawing.Size(212, 22);
            this.unlockLabel.TabIndex = 10;
            this.unlockLabel.Text = "unlockLabel";
            this.unlockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acceptButton.BackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acceptButton.Location = new System.Drawing.Point(57, 71);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(120, 25);
            this.acceptButton.TabIndex = 21;
            this.acceptButton.Text = "acceptButton";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // unlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(236, 115);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.unlockTextBox);
            this.Controls.Add(this.unlockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(252, 154);
            this.MinimumSize = new System.Drawing.Size(252, 154);
            this.Name = "unlockForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "unlockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unlockTextBox;
        private System.Windows.Forms.Label unlockLabel;
        private System.Windows.Forms.Button acceptButton;
    }
}