namespace GotoStreet_1._0_ControlStreet
{
    partial class LoginControlStreet
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.Escape_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.welcome_label.Location = new System.Drawing.Point(65, 27);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(487, 28);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Üdvözlöm a ControlStreet 1.0 Programban";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial", 10.25F);
            this.username_label.Location = new System.Drawing.Point(158, 106);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(111, 16);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Felhasználónév:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial", 10.25F);
            this.password_label.Location = new System.Drawing.Point(219, 156);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(50, 16);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Jelszó:";
            // 
            // Escape_button
            // 
            this.Escape_button.Location = new System.Drawing.Point(363, 210);
            this.Escape_button.Name = "Escape_button";
            this.Escape_button.Size = new System.Drawing.Size(119, 41);
            this.Escape_button.TabIndex = 3;
            this.Escape_button.Text = "Kilépés";
            this.Escape_button.UseVisualStyleBackColor = true;
            this.Escape_button.Click += new System.EventHandler(this.Escape_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(153, 210);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(119, 41);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Bejelentkezés";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(285, 142);
            this.Password_textbox.Multiline = true;
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '#';
            this.Password_textbox.Size = new System.Drawing.Size(183, 30);
            this.Password_textbox.TabIndex = 6;
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(285, 92);
            this.Username_textbox.Multiline = true;
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(183, 30);
            this.Username_textbox.TabIndex = 7;
            // 
            // LoginControlStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 313);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Escape_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "LoginControlStreet";
            this.Text = "Gotostreet Control 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button Escape_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.TextBox Username_textbox;
    }
}

