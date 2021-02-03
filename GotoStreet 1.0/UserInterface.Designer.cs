namespace GotoStreet_1._0
{
    partial class UserInterface
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
            this.GotoStreetMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóiKézikönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engedélyezettKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elutasitottKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKijárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkáltatóiIgazolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoStreetMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GotoStreetMenu
            // 
            this.GotoStreetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kijárásokToolStripMenuItem,
            this.sugóToolStripMenuItem});
            this.GotoStreetMenu.Location = new System.Drawing.Point(0, 0);
            this.GotoStreetMenu.Name = "GotoStreetMenu";
            this.GotoStreetMenu.Size = new System.Drawing.Size(800, 24);
            this.GotoStreetMenu.TabIndex = 0;
            this.GotoStreetMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.KilépésToolStripMenuItem_Click);
            // 
            // kijárásokToolStripMenuItem
            // 
            this.kijárásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engedélyezettKijárásokToolStripMenuItem,
            this.elutasitottKijárásokToolStripMenuItem,
            this.újKijárásToolStripMenuItem,
            this.munkáltatóiIgazolásToolStripMenuItem});
            this.kijárásokToolStripMenuItem.Name = "kijárásokToolStripMenuItem";
            this.kijárásokToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kijárásokToolStripMenuItem.Text = "Kijárások";
            // 
            // sugóToolStripMenuItem
            // 
            this.sugóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.felhasználóiKézikönyvToolStripMenuItem});
            this.sugóToolStripMenuItem.Name = "sugóToolStripMenuItem";
            this.sugóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sugóToolStripMenuItem.Text = "Sugó";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // felhasználóiKézikönyvToolStripMenuItem
            // 
            this.felhasználóiKézikönyvToolStripMenuItem.Name = "felhasználóiKézikönyvToolStripMenuItem";
            this.felhasználóiKézikönyvToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.felhasználóiKézikönyvToolStripMenuItem.Text = "Felhasználói Kézikönyv";
            // 
            // engedélyezettKijárásokToolStripMenuItem
            // 
            this.engedélyezettKijárásokToolStripMenuItem.Name = "engedélyezettKijárásokToolStripMenuItem";
            this.engedélyezettKijárásokToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.engedélyezettKijárásokToolStripMenuItem.Text = "Engedélyezett Kijárások";
            // 
            // elutasitottKijárásokToolStripMenuItem
            // 
            this.elutasitottKijárásokToolStripMenuItem.Name = "elutasitottKijárásokToolStripMenuItem";
            this.elutasitottKijárásokToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.elutasitottKijárásokToolStripMenuItem.Text = "Elutasitott Kijárások";
            // 
            // újKijárásToolStripMenuItem
            // 
            this.újKijárásToolStripMenuItem.Name = "újKijárásToolStripMenuItem";
            this.újKijárásToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.újKijárásToolStripMenuItem.Text = "Új kijárás..";
            // 
            // munkáltatóiIgazolásToolStripMenuItem
            // 
            this.munkáltatóiIgazolásToolStripMenuItem.Name = "munkáltatóiIgazolásToolStripMenuItem";
            this.munkáltatóiIgazolásToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.munkáltatóiIgazolásToolStripMenuItem.Text = "Munkáltatói Igazolás";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GotoStreetMenu);
            this.MainMenuStrip = this.GotoStreetMenu;
            this.Name = "UserInterface";
            this.Text = "GotoStreet 1.0 (Felhasználói környezet.)";
            this.GotoStreetMenu.ResumeLayout(false);
            this.GotoStreetMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GotoStreetMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijárásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engedélyezettKijárásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elutasitottKijárásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKijárásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkáltatóiIgazolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóiKézikönyvToolStripMenuItem;
    }
}