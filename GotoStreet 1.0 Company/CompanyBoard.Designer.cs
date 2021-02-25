namespace GotoStreet_1._0_Company
{
    partial class CompanyBoard
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
            this.Insert_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Company_information = new System.Windows.Forms.Label();
            this.Ids_label = new System.Windows.Forms.Label();
            this.Id_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Return_label = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(78, 251);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(105, 38);
            this.Insert_button.TabIndex = 0;
            this.Insert_button.Text = "Igény Feltöltése";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(270, 251);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 38);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "Adatok Törlése";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Company_information
            // 
            this.Company_information.AutoSize = true;
            this.Company_information.Location = new System.Drawing.Point(48, 332);
            this.Company_information.Name = "Company_information";
            this.Company_information.Size = new System.Drawing.Size(64, 13);
            this.Company_information.TabIndex = 2;
            this.Company_information.Text = "Cég adatai :";
            // 
            // Ids_label
            // 
            this.Ids_label.AutoSize = true;
            this.Ids_label.Location = new System.Drawing.Point(75, 96);
            this.Ids_label.Name = "Ids_label";
            this.Ids_label.Size = new System.Drawing.Size(129, 13);
            this.Ids_label.TabIndex = 3;
            this.Ids_label.Text = "Dolgozó GotoStreet Id-ja :";
            // 
            // Id_textbox
            // 
            this.Id_textbox.Location = new System.Drawing.Point(220, 93);
            this.Id_textbox.Name = "Id_textbox";
            this.Id_textbox.Size = new System.Drawing.Size(75, 20);
            this.Id_textbox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Id Ellenörzése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return_label
            // 
            this.Return_label.AutoSize = true;
            this.Return_label.Location = new System.Drawing.Point(112, 201);
            this.Return_label.Name = "Return_label";
            this.Return_label.Size = new System.Drawing.Size(35, 13);
            this.Return_label.TabIndex = 6;
            this.Return_label.Text = "label2";
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.Welcome_label.Location = new System.Drawing.Point(115, 28);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(284, 28);
            this.Welcome_label.TabIndex = 7;
            this.Welcome_label.Text = "Üdvözli a GotoStreet 1.0";
            // 
            // CompanyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Return_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id_textbox);
            this.Controls.Add(this.Ids_label);
            this.Controls.Add(this.Company_information);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Insert_button);
            this.Name = "CompanyBoard";
            this.Text = "GotoStreet 1.0 (Vállalati felület)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label Company_information;
        private System.Windows.Forms.Label Ids_label;
        private System.Windows.Forms.TextBox Id_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Return_label;
        private System.Windows.Forms.Label Welcome_label;
    }
}