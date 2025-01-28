namespace NStudio.Desktop
{
    partial class rulesForm
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
            this.rulesBox = new System.Windows.Forms.TextBox();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesBox
            // 
            this.rulesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rulesBox.ForeColor = System.Drawing.Color.White;
            this.rulesBox.Location = new System.Drawing.Point(12, 12);
            this.rulesBox.Multiline = true;
            this.rulesBox.Name = "rulesBox";
            this.rulesBox.Size = new System.Drawing.Size(425, 186);
            this.rulesBox.TabIndex = 0;
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
            this.rejectButton.Location = new System.Drawing.Point(242, 216);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(0);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(110, 25);
            this.rejectButton.TabIndex = 21;
            this.rejectButton.Tag = "font";
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
            this.acceptButton.Location = new System.Drawing.Point(90, 216);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(110, 25);
            this.acceptButton.TabIndex = 20;
            this.acceptButton.Tag = "font";
            this.acceptButton.Text = "acceptButton";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(449, 271);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.rulesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "rulesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rulesBox;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
    }
}