namespace NStudio
{
    partial class DatabaseControl
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
            this.dbSaveButton = new System.Windows.Forms.Button();
            this.dbHostname = new ZBobb.AlphaBlendTextBox();
            this.dbName = new ZBobb.AlphaBlendTextBox();
            this.dbUser = new ZBobb.AlphaBlendTextBox();
            this.dbHostnameL = new System.Windows.Forms.Label();
            this.dbNameL = new System.Windows.Forms.Label();
            this.dbUserL = new System.Windows.Forms.Label();
            this.dbPassL = new System.Windows.Forms.Label();
            this.dbPass = new ZBobb.AlphaBlendTextBox();
            this.mysql = new System.Windows.Forms.RadioButton();
            this.postgresql = new System.Windows.Forms.RadioButton();
            this.sqlite = new System.Windows.Forms.RadioButton();
            this.mongodb = new System.Windows.Forms.RadioButton();
            this.dbCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbSaveButton
            // 
            this.dbSaveButton.AutoSize = true;
            this.dbSaveButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbSaveButton.Location = new System.Drawing.Point(145, 159);
            this.dbSaveButton.MaximumSize = new System.Drawing.Size(120, 120);
            this.dbSaveButton.Name = "dbSaveButton";
            this.dbSaveButton.Size = new System.Drawing.Size(120, 27);
            this.dbSaveButton.TabIndex = 9;
            this.dbSaveButton.Text = "dbSaveButton";
            this.dbSaveButton.UseVisualStyleBackColor = true;
            this.dbSaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dbHostname
            // 
            this.dbHostname.BackAlpha = 10;
            this.dbHostname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbHostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbHostname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbHostname.Location = new System.Drawing.Point(114, 12);
            this.dbHostname.Multiline = true;
            this.dbHostname.Name = "dbHostname";
            this.dbHostname.Size = new System.Drawing.Size(151, 23);
            this.dbHostname.TabIndex = 1;
            this.dbHostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbName
            // 
            this.dbName.BackAlpha = 10;
            this.dbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbName.Location = new System.Drawing.Point(114, 41);
            this.dbName.Multiline = true;
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(151, 23);
            this.dbName.TabIndex = 2;
            this.dbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbUser
            // 
            this.dbUser.BackAlpha = 10;
            this.dbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbUser.Location = new System.Drawing.Point(114, 70);
            this.dbUser.Multiline = true;
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(151, 23);
            this.dbUser.TabIndex = 3;
            this.dbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbHostnameL
            // 
            this.dbHostnameL.BackColor = System.Drawing.Color.Transparent;
            this.dbHostnameL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbHostnameL.Location = new System.Drawing.Point(19, 21);
            this.dbHostnameL.Name = "dbHostnameL";
            this.dbHostnameL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbHostnameL.Size = new System.Drawing.Size(89, 14);
            this.dbHostnameL.TabIndex = 4;
            this.dbHostnameL.Text = "dbHostnameL";
            // 
            // dbNameL
            // 
            this.dbNameL.BackColor = System.Drawing.Color.Transparent;
            this.dbNameL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbNameL.Location = new System.Drawing.Point(19, 50);
            this.dbNameL.Name = "dbNameL";
            this.dbNameL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbNameL.Size = new System.Drawing.Size(89, 14);
            this.dbNameL.TabIndex = 5;
            this.dbNameL.Text = "dbNameL";
            // 
            // dbUserL
            // 
            this.dbUserL.BackColor = System.Drawing.Color.Transparent;
            this.dbUserL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbUserL.Location = new System.Drawing.Point(19, 79);
            this.dbUserL.Name = "dbUserL";
            this.dbUserL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbUserL.Size = new System.Drawing.Size(89, 14);
            this.dbUserL.TabIndex = 6;
            this.dbUserL.Text = "dbUserL";
            // 
            // dbPassL
            // 
            this.dbPassL.BackColor = System.Drawing.Color.Transparent;
            this.dbPassL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbPassL.Location = new System.Drawing.Point(19, 108);
            this.dbPassL.Name = "dbPassL";
            this.dbPassL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbPassL.Size = new System.Drawing.Size(89, 14);
            this.dbPassL.TabIndex = 8;
            this.dbPassL.Text = "dbPassL";
            // 
            // dbPass
            // 
            this.dbPass.BackAlpha = 10;
            this.dbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbPass.Location = new System.Drawing.Point(114, 99);
            this.dbPass.Multiline = true;
            this.dbPass.Name = "dbPass";
            this.dbPass.PasswordChar = '*';
            this.dbPass.Size = new System.Drawing.Size(151, 23);
            this.dbPass.TabIndex = 4;
            this.dbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mysql
            // 
            this.mysql.AutoSize = true;
            this.mysql.BackColor = System.Drawing.Color.Transparent;
            this.mysql.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mysql.Location = new System.Drawing.Point(20, 143);
            this.mysql.Name = "mysql";
            this.mysql.Size = new System.Drawing.Size(64, 20);
            this.mysql.TabIndex = 5;
            this.mysql.TabStop = true;
            this.mysql.Text = "MySQL";
            this.mysql.UseVisualStyleBackColor = false;
            // 
            // postgresql
            // 
            this.postgresql.AutoSize = true;
            this.postgresql.BackColor = System.Drawing.Color.Transparent;
            this.postgresql.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postgresql.Location = new System.Drawing.Point(20, 166);
            this.postgresql.Name = "postgresql";
            this.postgresql.Size = new System.Drawing.Size(89, 20);
            this.postgresql.TabIndex = 6;
            this.postgresql.TabStop = true;
            this.postgresql.Text = "PostgreSQL";
            this.postgresql.UseVisualStyleBackColor = false;
            // 
            // sqlite
            // 
            this.sqlite.AutoSize = true;
            this.sqlite.BackColor = System.Drawing.Color.Transparent;
            this.sqlite.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqlite.Location = new System.Drawing.Point(20, 189);
            this.sqlite.Name = "sqlite";
            this.sqlite.Size = new System.Drawing.Size(60, 20);
            this.sqlite.TabIndex = 7;
            this.sqlite.TabStop = true;
            this.sqlite.Text = "SQLite";
            this.sqlite.UseVisualStyleBackColor = false;
            // 
            // mongodb
            // 
            this.mongodb.AutoSize = true;
            this.mongodb.BackColor = System.Drawing.Color.Transparent;
            this.mongodb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mongodb.Location = new System.Drawing.Point(20, 212);
            this.mongodb.Name = "mongodb";
            this.mongodb.Size = new System.Drawing.Size(82, 20);
            this.mongodb.TabIndex = 8;
            this.mongodb.TabStop = true;
            this.mongodb.Text = "MongoDB";
            this.mongodb.UseVisualStyleBackColor = false;
            // 
            // dbCancelButton
            // 
            this.dbCancelButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbCancelButton.Location = new System.Drawing.Point(145, 192);
            this.dbCancelButton.Name = "dbCancelButton";
            this.dbCancelButton.Size = new System.Drawing.Size(121, 26);
            this.dbCancelButton.TabIndex = 10;
            this.dbCancelButton.Text = "dbCancelButton";
            this.dbCancelButton.UseVisualStyleBackColor = true;
            this.dbCancelButton.Click += new System.EventHandler(this.dbCancelButton_Click);
            // 
            // DatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 254);
            this.Controls.Add(this.dbCancelButton);
            this.Controls.Add(this.mongodb);
            this.Controls.Add(this.sqlite);
            this.Controls.Add(this.postgresql);
            this.Controls.Add(this.mysql);
            this.Controls.Add(this.dbPassL);
            this.Controls.Add(this.dbPass);
            this.Controls.Add(this.dbUserL);
            this.Controls.Add(this.dbNameL);
            this.Controls.Add(this.dbHostnameL);
            this.Controls.Add(this.dbUser);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.dbHostname);
            this.Controls.Add(this.dbSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DatabaseControl";
            this.Load += new System.EventHandler(this.DatabaseControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dbSaveButton;
        private ZBobb.AlphaBlendTextBox dbHostname;
        private ZBobb.AlphaBlendTextBox dbName;
        private ZBobb.AlphaBlendTextBox dbUser;
        private System.Windows.Forms.Label dbHostnameL;
        private System.Windows.Forms.Label dbNameL;
        private System.Windows.Forms.Label dbUserL;
        private System.Windows.Forms.Label dbPassL;
        private ZBobb.AlphaBlendTextBox dbPass;
        private System.Windows.Forms.RadioButton mysql;
        private System.Windows.Forms.RadioButton postgresql;
        private System.Windows.Forms.RadioButton sqlite;
        private System.Windows.Forms.RadioButton mongodb;
        private System.Windows.Forms.Button dbCancelButton;
    }
}