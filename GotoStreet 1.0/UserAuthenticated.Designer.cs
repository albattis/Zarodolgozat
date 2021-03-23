
namespace GotoStreet_1._0
{
    partial class UserAuthenticated
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
            this.important_label = new System.Windows.Forms.Label();
            this.mothername_label = new System.Windows.Forms.Label();
            this.birthdate_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mthn = new System.Windows.Forms.TextBox();
            this.textBox_bd = new System.Windows.Forms.TextBox();
            this.textBox_icn = new System.Windows.Forms.TextBox();
            this.Authenticate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.welcome_label.Location = new System.Drawing.Point(155, 42);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(443, 28);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "GotoStreet 1.0 Felhasználó Hitelesités";
            // 
            // important_label
            // 
            this.important_label.AutoSize = true;
            this.important_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.important_label.Location = new System.Drawing.Point(236, 88);
            this.important_label.Name = "important_label";
            this.important_label.Size = new System.Drawing.Size(250, 20);
            this.important_label.TabIndex = 1;
            this.important_label.Text = "A következö mezök kitöltése kötelezö!!!";
            // 
            // mothername_label
            // 
            this.mothername_label.AutoSize = true;
            this.mothername_label.Font = new System.Drawing.Font("Arial", 10F);
            this.mothername_label.Location = new System.Drawing.Point(109, 156);
            this.mothername_label.Name = "mothername_label";
            this.mothername_label.Size = new System.Drawing.Size(82, 16);
            this.mothername_label.TabIndex = 2;
            this.mothername_label.Text = "Anyja neve:";
            // 
            // birthdate_label
            // 
            this.birthdate_label.AutoSize = true;
            this.birthdate_label.Font = new System.Drawing.Font("Arial", 10F);
            this.birthdate_label.Location = new System.Drawing.Point(109, 196);
            this.birthdate_label.Name = "birthdate_label";
            this.birthdate_label.Size = new System.Drawing.Size(91, 16);
            this.birthdate_label.TabIndex = 3;
            this.birthdate_label.Text = "Születési Idő:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(46, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Személyi Igazolvány / Jogistvány száma:";
            // 
            // textBox_mthn
            // 
            this.textBox_mthn.Location = new System.Drawing.Point(212, 154);
            this.textBox_mthn.Multiline = true;
            this.textBox_mthn.Name = "textBox_mthn";
            this.textBox_mthn.Size = new System.Drawing.Size(140, 20);
            this.textBox_mthn.TabIndex = 5;
            // 
            // textBox_bd
            // 
            this.textBox_bd.Location = new System.Drawing.Point(212, 194);
            this.textBox_bd.Multiline = true;
            this.textBox_bd.Name = "textBox_bd";
            this.textBox_bd.Size = new System.Drawing.Size(140, 20);
            this.textBox_bd.TabIndex = 6;
            // 
            // textBox_icn
            // 
            this.textBox_icn.Location = new System.Drawing.Point(311, 233);
            this.textBox_icn.Multiline = true;
            this.textBox_icn.Name = "textBox_icn";
            this.textBox_icn.Size = new System.Drawing.Size(140, 20);
            this.textBox_icn.TabIndex = 7;
            // 
            // Authenticate_button
            // 
            this.Authenticate_button.Location = new System.Drawing.Point(225, 288);
            this.Authenticate_button.Name = "Authenticate_button";
            this.Authenticate_button.Size = new System.Drawing.Size(107, 38);
            this.Authenticate_button.TabIndex = 8;
            this.Authenticate_button.Text = "Hitelesités";
            this.Authenticate_button.UseVisualStyleBackColor = true;
            this.Authenticate_button.Click += new System.EventHandler(this.Authenticate_button_Click);
            // 
            // UserAuthenticated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(636, 338);
            this.Controls.Add(this.Authenticate_button);
            this.Controls.Add(this.textBox_icn);
            this.Controls.Add(this.textBox_bd);
            this.Controls.Add(this.textBox_mthn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdate_label);
            this.Controls.Add(this.mothername_label);
            this.Controls.Add(this.important_label);
            this.Controls.Add(this.welcome_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserAuthenticated";
            this.Text = "GotoStreet 1.0 (Felhasználói felület)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label important_label;
        private System.Windows.Forms.Label mothername_label;
        private System.Windows.Forms.Label birthdate_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mthn;
        private System.Windows.Forms.TextBox textBox_bd;
        private System.Windows.Forms.TextBox textBox_icn;
        private System.Windows.Forms.Button Authenticate_button;
    }
}