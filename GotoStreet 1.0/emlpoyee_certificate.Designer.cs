namespace GotoStreet_1._0
{
    partial class emlpoyee_certificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emlpoyee_certificate));
            this.welcome_label = new System.Windows.Forms.Label();
            this.employye_label = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.welcome_label.Location = new System.Drawing.Point(171, 24);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(0, 28);
            this.welcome_label.TabIndex = 0;
            // 
            // employye_label
            // 
            this.employye_label.AutoSize = true;
            this.employye_label.Location = new System.Drawing.Point(45, 106);
            this.employye_label.Name = "employye_label";
            this.employye_label.Size = new System.Drawing.Size(0, 13);
            this.employye_label.TabIndex = 1;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(322, 346);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 43);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Kilépés";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(86, 346);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(150, 43);
            this.button_print.TabIndex = 3;
            this.button_print.Text = "Nyomtatás";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.Button_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // emlpoyee_certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(554, 391);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.employye_label);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emlpoyee_certificate";
            this.Text = "GotoStreet 1.0 Kijárási Igazolás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label employye_label;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}