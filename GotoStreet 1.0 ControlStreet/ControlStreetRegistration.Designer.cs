namespace GotoStreet_1._0_ControlStreet
{
    partial class ControlStreetRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlStreetRegistration));
            this.welcome_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.employee_textbox = new System.Windows.Forms.TextBox();
            this.policeid_textbox = new System.Windows.Forms.TextBox();
            this.Registracion_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.welcome_label.Location = new System.Drawing.Point(145, 27);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(306, 28);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "ControlStreet Regisztráció";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teljes Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beosztás:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iroda Azonósító:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(288, 104);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(288, 147);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = 'X';
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 6;
            // 
            // employee_textbox
            // 
            this.employee_textbox.Location = new System.Drawing.Point(288, 190);
            this.employee_textbox.Name = "employee_textbox";
            this.employee_textbox.Size = new System.Drawing.Size(100, 20);
            this.employee_textbox.TabIndex = 7;
            // 
            // policeid_textbox
            // 
            this.policeid_textbox.Location = new System.Drawing.Point(288, 233);
            this.policeid_textbox.Name = "policeid_textbox";
            this.policeid_textbox.Size = new System.Drawing.Size(100, 20);
            this.policeid_textbox.TabIndex = 8;
            // 
            // Registracion_button
            // 
            this.Registracion_button.Location = new System.Drawing.Point(160, 309);
            this.Registracion_button.Name = "Registracion_button";
            this.Registracion_button.Size = new System.Drawing.Size(86, 36);
            this.Registracion_button.TabIndex = 9;
            this.Registracion_button.Text = "Regisztráció";
            this.Registracion_button.UseVisualStyleBackColor = true;
            this.Registracion_button.Click += new System.EventHandler(this.Registration_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_button);
            // 
            // ControlStreetRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Registracion_button);
            this.Controls.Add(this.policeid_textbox);
            this.Controls.Add(this.employee_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlStreetRegistration";
            this.Text = "GotoStreet 1.0 Control (Regisztráció)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox employee_textbox;
        private System.Windows.Forms.TextBox policeid_textbox;
        private System.Windows.Forms.Button Registracion_button;
        private System.Windows.Forms.Button button2;
    }
}