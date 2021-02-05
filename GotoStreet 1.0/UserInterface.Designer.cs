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
            this.engedélyezettKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elutasitottKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKijárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóiKézikönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoStreet_Views = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Welcomae_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.GotoStreetMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GotoStreet_Views)).BeginInit();
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
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.KilépésToolStripMenuItem_Click);
            // 
            // kijárásokToolStripMenuItem
            // 
            this.kijárásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engedélyezettKijárásokToolStripMenuItem,
            this.elutasitottKijárásokToolStripMenuItem,
            this.újKijárásToolStripMenuItem});
            this.kijárásokToolStripMenuItem.Name = "kijárásokToolStripMenuItem";
            this.kijárásokToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kijárásokToolStripMenuItem.Text = "Kijárások";
            // 
            // engedélyezettKijárásokToolStripMenuItem
            // 
            this.engedélyezettKijárásokToolStripMenuItem.Name = "engedélyezettKijárásokToolStripMenuItem";
            this.engedélyezettKijárásokToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.engedélyezettKijárásokToolStripMenuItem.Text = "Engedélyezett Kijárások";
            this.engedélyezettKijárásokToolStripMenuItem.Click += new System.EventHandler(this.EngedélyezettKijárásokToolStripMenuItem_Click);
            // 
            // elutasitottKijárásokToolStripMenuItem
            // 
            this.elutasitottKijárásokToolStripMenuItem.Name = "elutasitottKijárásokToolStripMenuItem";
            this.elutasitottKijárásokToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.elutasitottKijárásokToolStripMenuItem.Text = "Elutasitott Kijárások";
            this.elutasitottKijárásokToolStripMenuItem.Click += new System.EventHandler(this.ElutasitottKijárásokToolStripMenuItem_Click);
            // 
            // újKijárásToolStripMenuItem
            // 
            this.újKijárásToolStripMenuItem.Name = "újKijárásToolStripMenuItem";
            this.újKijárásToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.újKijárásToolStripMenuItem.Text = "Új kijárás..";
            this.újKijárásToolStripMenuItem.Click += new System.EventHandler(this.ÚjKijárásToolStripMenuItem_Click);
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
            // GotoStreet_Views
            // 
            this.GotoStreet_Views.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GotoStreet_Views.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GotoStreet_Views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GotoStreet_Views.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GotoStreet_Views.Location = new System.Drawing.Point(110, 124);
            this.GotoStreet_Views.Name = "GotoStreet_Views";
            this.GotoStreet_Views.Size = new System.Drawing.Size(522, 116);
            this.GotoStreet_Views.TabIndex = 1;
            this.GotoStreet_Views.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GotoStreet_Views_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Név";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kijárás Ideje";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kijárás Célja";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Státusz";
            this.Column4.Name = "Column4";
            // 
            // Welcomae_Label
            // 
            this.Welcomae_Label.AutoSize = true;
            this.Welcomae_Label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.Welcomae_Label.Location = new System.Drawing.Point(248, 46);
            this.Welcomae_Label.Name = "Welcomae_Label";
            this.Welcomae_Label.Size = new System.Drawing.Size(0, 28);
            this.Welcomae_Label.TabIndex = 2;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Arial", 15.75F);
            this.Date_Label.Location = new System.Drawing.Point(178, 364);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(0, 24);
            this.Date_Label.TabIndex = 3;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Welcomae_Label);
            this.Controls.Add(this.GotoStreet_Views);
            this.Controls.Add(this.GotoStreetMenu);
            this.MainMenuStrip = this.GotoStreetMenu;
            this.Name = "UserInterface";
            this.Text = "GotoStreet 1.0 (Felhasználói környezet.)";
            this.GotoStreetMenu.ResumeLayout(false);
            this.GotoStreetMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GotoStreet_Views)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem sugóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóiKézikönyvToolStripMenuItem;
        private System.Windows.Forms.DataGridView GotoStreet_Views;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label Welcomae_Label;
        private System.Windows.Forms.Label Date_Label;
    }
}