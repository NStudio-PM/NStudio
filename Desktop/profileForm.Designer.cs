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
            this.l1 = new FontAwesome.Sharp.IconButton();
            this.l2 = new FontAwesome.Sharp.IconButton();
            this.p2 = new FontAwesome.Sharp.IconButton();
            this.p1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.FlatAppearance.BorderSize = 0;
            this.l1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l1.IconChar = FontAwesome.Sharp.IconChar.E;
            this.l1.IconColor = System.Drawing.Color.Black;
            this.l1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.l1.Location = new System.Drawing.Point(85, 88);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(34, 53);
            this.l1.TabIndex = 0;
            this.l1.UseVisualStyleBackColor = false;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.FlatAppearance.BorderSize = 0;
            this.l2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l2.IconChar = FontAwesome.Sharp.IconChar.N;
            this.l2.IconColor = System.Drawing.Color.Black;
            this.l2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.l2.Location = new System.Drawing.Point(115, 88);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(34, 53);
            this.l2.TabIndex = 1;
            this.l2.UseVisualStyleBackColor = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.FlatAppearance.BorderSize = 0;
            this.p2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2.IconChar = FontAwesome.Sharp.IconChar.L;
            this.p2.IconColor = System.Drawing.Color.Black;
            this.p2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.p2.Location = new System.Drawing.Point(366, 88);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(34, 53);
            this.p2.TabIndex = 3;
            this.p2.UseVisualStyleBackColor = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.FlatAppearance.BorderSize = 0;
            this.p1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1.IconChar = FontAwesome.Sharp.IconChar.P;
            this.p1.IconColor = System.Drawing.Color.Black;
            this.p1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.p1.Location = new System.Drawing.Point(336, 88);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(34, 53);
            this.p1.TabIndex = 2;
            this.p1.UseVisualStyleBackColor = false;
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 217);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "profileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton l1;
        private FontAwesome.Sharp.IconButton l2;
        private FontAwesome.Sharp.IconButton p2;
        private FontAwesome.Sharp.IconButton p1;
    }
}