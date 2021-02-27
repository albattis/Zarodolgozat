namespace GotoStreet_1._0_Company
{
    partial class CompanyLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyLogin));
            this.welcome_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Escape_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.welcome_label.Location = new System.Drawing.Point(54, 35);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(314, 28);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Üdvözlöm a GotoStreet 1.0";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.username_label.Location = new System.Drawing.Point(90, 133);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(89, 14);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Felhasználónév :";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.password_label.Location = new System.Drawing.Point(136, 173);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(44, 14);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Jelszó :";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(203, 130);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(203, 170);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.PasswordChar = 'C';
            this.password_Textbox.Size = new System.Drawing.Size(100, 20);
            this.password_Textbox.TabIndex = 4;
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Login_button.Location = new System.Drawing.Point(59, 235);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(119, 29);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Bejelentkezés";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.login_button);
            // 
            // Escape_button
            // 
            this.Escape_button.Location = new System.Drawing.Point(269, 235);
            this.Escape_button.Name = "Escape_button";
            this.Escape_button.Size = new System.Drawing.Size(119, 29);
            this.Escape_button.TabIndex = 6;
            this.Escape_button.Text = "Kilépés";
            this.Escape_button.UseVisualStyleBackColor = true;
            this.Escape_button.Click += new System.EventHandler(this.Escape_button_Click);
            // 
            // CompanyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(477, 308);
            this.Controls.Add(this.Escape_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanyLogin";
            this.Text = "GotoStreet 1.0 (Company)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Escape_button;
    }
}

