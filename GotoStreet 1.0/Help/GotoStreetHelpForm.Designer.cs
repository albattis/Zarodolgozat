namespace GotoStreet_1._0.Help
{
    partial class GotoStreetHelpForm
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
            this.SugoMenu = new System.Windows.Forms.MenuStrip();
            this.bejelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználónévToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jelszóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisztrációToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisztrációToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kijárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_title = new System.Windows.Forms.Label();
            this.label_tag = new System.Windows.Forms.Label();
            this.label_screen = new System.Windows.Forms.Label();
            this.GotoStreetPictureBox = new System.Windows.Forms.PictureBox();
            this.kijárásiKérelemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GotoStreetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SugoMenu
            // 
            this.SugoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bejelentkezésToolStripMenuItem,
            this.regisztrációToolStripMenuItem,
            this.kijárásToolStripMenuItem});
            this.SugoMenu.Location = new System.Drawing.Point(0, 0);
            this.SugoMenu.Name = "SugoMenu";
            this.SugoMenu.Size = new System.Drawing.Size(800, 24);
            this.SugoMenu.TabIndex = 0;
            this.SugoMenu.Text = "menuStrip1";
            // 
            // bejelentkezésToolStripMenuItem
            // 
            this.bejelentkezésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználónévToolStripMenuItem,
            this.jelszóToolStripMenuItem});
            this.bejelentkezésToolStripMenuItem.Name = "bejelentkezésToolStripMenuItem";
            this.bejelentkezésToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bejelentkezésToolStripMenuItem.Text = "Bejelentkezés";
            // 
            // felhasználónévToolStripMenuItem
            // 
            this.felhasználónévToolStripMenuItem.Name = "felhasználónévToolStripMenuItem";
            this.felhasználónévToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.felhasználónévToolStripMenuItem.Text = "Felhasználónév";
            this.felhasználónévToolStripMenuItem.Click += new System.EventHandler(this.FelhasználónévToolStripMenuItem_Click);
            // 
            // jelszóToolStripMenuItem
            // 
            this.jelszóToolStripMenuItem.Name = "jelszóToolStripMenuItem";
            this.jelszóToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jelszóToolStripMenuItem.Text = "Jelszó";
            this.jelszóToolStripMenuItem.Click += new System.EventHandler(this.JelszóToolStripMenuItem_Click);
            // 
            // regisztrációToolStripMenuItem
            // 
            this.regisztrációToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regisztrációToolStripMenuItem1});
            this.regisztrációToolStripMenuItem.Name = "regisztrációToolStripMenuItem";
            this.regisztrációToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.regisztrációToolStripMenuItem.Text = "Regisztráció";
            // 
            // regisztrációToolStripMenuItem1
            // 
            this.regisztrációToolStripMenuItem1.Name = "regisztrációToolStripMenuItem1";
            this.regisztrációToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.regisztrációToolStripMenuItem1.Text = "Regisztráció";
            this.regisztrációToolStripMenuItem1.Click += new System.EventHandler(this.RegisztrációToolStripMenuItem1_Click);
            // 
            // kijárásToolStripMenuItem
            // 
            this.kijárásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kijárásiKérelemToolStripMenuItem});
            this.kijárásToolStripMenuItem.Name = "kijárásToolStripMenuItem";
            this.kijárásToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.kijárásToolStripMenuItem.Text = "Kijárás";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial", 18.25F);
            this.label_title.Location = new System.Drawing.Point(279, 60);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(58, 28);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Title";
            // 
            // label_tag
            // 
            this.label_tag.AutoSize = true;
            this.label_tag.Location = new System.Drawing.Point(174, 112);
            this.label_tag.Name = "label_tag";
            this.label_tag.Size = new System.Drawing.Size(0, 13);
            this.label_tag.TabIndex = 2;
            // 
            // label_screen
            // 
            this.label_screen.AutoSize = true;
            this.label_screen.Location = new System.Drawing.Point(116, 157);
            this.label_screen.Name = "label_screen";
            this.label_screen.Size = new System.Drawing.Size(0, 13);
            this.label_screen.TabIndex = 3;
            // 
            // GotoStreetPictureBox
            // 
            this.GotoStreetPictureBox.Location = new System.Drawing.Point(73, 194);
            this.GotoStreetPictureBox.Name = "GotoStreetPictureBox";
            this.GotoStreetPictureBox.Size = new System.Drawing.Size(619, 420);
            this.GotoStreetPictureBox.TabIndex = 4;
            this.GotoStreetPictureBox.TabStop = false;
            // 
            // kijárásiKérelemToolStripMenuItem
            // 
            this.kijárásiKérelemToolStripMenuItem.Name = "kijárásiKérelemToolStripMenuItem";
            this.kijárásiKérelemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kijárásiKérelemToolStripMenuItem.Text = "Kijárási Kérelem";
            this.kijárásiKérelemToolStripMenuItem.Click += new System.EventHandler(this.KijárásiKérelemToolStripMenuItem_Click);
            // 
            // GotoStreetHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.GotoStreetPictureBox);
            this.Controls.Add(this.label_screen);
            this.Controls.Add(this.label_tag);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.SugoMenu);
            this.MainMenuStrip = this.SugoMenu;
            this.Name = "GotoStreetHelpForm";
            this.Text = "GotoStreet 1.0 Súgó";
            this.SugoMenu.ResumeLayout(false);
            this.SugoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GotoStreetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SugoMenu;
        private System.Windows.Forms.ToolStripMenuItem bejelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regisztrációToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijárásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználónévToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jelszóToolStripMenuItem;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_tag;
        private System.Windows.Forms.Label label_screen;
        private System.Windows.Forms.PictureBox GotoStreetPictureBox;
        private System.Windows.Forms.ToolStripMenuItem regisztrációToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kijárásiKérelemToolStripMenuItem;
    }
}