namespace GotoStreet_1._0
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Loginname_Textbox = new System.Windows.Forms.TextBox();
            this.Pasword_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Escape_Button = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Arial", 18.25F);
            this.WelcomeMessage.ForeColor = System.Drawing.Color.Black;
            this.WelcomeMessage.Location = new System.Drawing.Point(156, 39);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(469, 28);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Üdvözöllek a GotoStreet Alkalmazásban.";
            // 
            // Loginname_Textbox
            // 
            this.Loginname_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginname_Textbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.Loginname_Textbox.Location = new System.Drawing.Point(325, 114);
            this.Loginname_Textbox.Multiline = true;
            this.Loginname_Textbox.Name = "Loginname_Textbox";
            this.Loginname_Textbox.Size = new System.Drawing.Size(219, 35);
            this.Loginname_Textbox.TabIndex = 1;
            this.Loginname_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pasword_Textbox
            // 
            this.Pasword_Textbox.AcceptsReturn = true;
            this.Pasword_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Pasword_Textbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.Pasword_Textbox.Location = new System.Drawing.Point(325, 180);
            this.Pasword_Textbox.Multiline = true;
            this.Pasword_Textbox.Name = "Pasword_Textbox";
            this.Pasword_Textbox.PasswordChar = '#';
            this.Pasword_Textbox.Size = new System.Drawing.Size(219, 35);
            this.Pasword_Textbox.TabIndex = 2;
            this.Pasword_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Username_Label.Location = new System.Drawing.Point(166, 125);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(148, 24);
            this.Username_Label.TabIndex = 3;
            this.Username_Label.Text = "Felhasználónév:";
            this.Username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Password_Label.Location = new System.Drawing.Point(210, 191);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(68, 24);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Jelszó:";
            this.Password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Arial", 12.25F);
            this.Login_Button.Location = new System.Drawing.Point(232, 258);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(226, 45);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Bejelentkezés";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Escape_Button
            // 
            this.Escape_Button.Font = new System.Drawing.Font("Arial", 12.25F);
            this.Escape_Button.Location = new System.Drawing.Point(542, 258);
            this.Escape_Button.Name = "Escape_Button";
            this.Escape_Button.Size = new System.Drawing.Size(128, 45);
            this.Escape_Button.TabIndex = 6;
            this.Escape_Button.Text = "Kilépés";
            this.Escape_Button.UseVisualStyleBackColor = true;
            this.Escape_Button.Click += new System.EventHandler(this.Escape_Button_Click);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("Arial", 12.25F);
            this.Registration.Location = new System.Drawing.Point(25, 258);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(140, 45);
            this.Registration.TabIndex = 7;
            this.Registration.Text = "Regisztráció";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(706, 330);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Escape_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Pasword_Textbox);
            this.Controls.Add(this.Loginname_Textbox);
            this.Controls.Add(this.WelcomeMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "GotoStreet 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TextBox Loginname_Textbox;
        private System.Windows.Forms.TextBox Pasword_Textbox;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Escape_Button;
        private System.Windows.Forms.Button Registration;
    }
}

