
namespace GotoStreet_1._0
{
    partial class DocumentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentViewer));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Open_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(4, 117);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(794, 331);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18.25F);
            this.label1.Location = new System.Drawing.Point(248, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "GotoStreet 1.0 Felhasználói kézikönyv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Open_Button
            // 
            this.Open_Button.Location = new System.Drawing.Point(99, 74);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(75, 23);
            this.Open_Button.TabIndex = 2;
            this.Open_Button.Text = "Megnyitás";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocumentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axAcroPDF1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentViewer";
            this.Text = "GotoStreet 1.0 (Felhasználói felület)";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Open_Button;
    }
}