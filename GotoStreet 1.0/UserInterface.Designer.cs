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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.GotoStreetMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóiAdataimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóiRegisztrációToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engedélyezettKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elutasitottKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKijárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkáltatóiIgazolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.userdatas = new System.Windows.Forms.Label();
            this.usedata_button = new System.Windows.Forms.Button();
            this.Authenticated_label = new System.Windows.Forms.Label();
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
            this.felhasználóiAdataimToolStripMenuItem,
            this.kilépésToolStripMenuItem,
            this.felhasználóiRegisztrációToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // felhasználóiAdataimToolStripMenuItem
            // 
            this.felhasználóiAdataimToolStripMenuItem.Name = "felhasználóiAdataimToolStripMenuItem";
            this.felhasználóiAdataimToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.felhasználóiAdataimToolStripMenuItem.Text = "Felhasználói adataim";
            this.felhasználóiAdataimToolStripMenuItem.Click += new System.EventHandler(this.FelhasználóiAdataimToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.KilépésToolStripMenuItem_Click);
            // 
            // felhasználóiRegisztrációToolStripMenuItem
            // 
            this.felhasználóiRegisztrációToolStripMenuItem.Name = "felhasználóiRegisztrációToolStripMenuItem";
            this.felhasználóiRegisztrációToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.felhasználóiRegisztrációToolStripMenuItem.Text = "Hitelesités";
            this.felhasználóiRegisztrációToolStripMenuItem.Click += new System.EventHandler(this.FelhasználóiRegisztrációToolStripMenuItem_Click);
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
            // munkáltatóiIgazolásToolStripMenuItem
            // 
            this.munkáltatóiIgazolásToolStripMenuItem.Name = "munkáltatóiIgazolásToolStripMenuItem";
            this.munkáltatóiIgazolásToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.munkáltatóiIgazolásToolStripMenuItem.Text = "Munkáltatói Igazolás";
            this.munkáltatóiIgazolásToolStripMenuItem.Click += new System.EventHandler(this.MunkáltatóiIgazolásToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // felhasználóiKézikönyvToolStripMenuItem
            // 
            this.felhasználóiKézikönyvToolStripMenuItem.Name = "felhasználóiKézikönyvToolStripMenuItem";
            this.felhasználóiKézikönyvToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.felhasználóiKézikönyvToolStripMenuItem.Text = "Felhasználói Kézikönyv";
            this.felhasználóiKézikönyvToolStripMenuItem.Click += new System.EventHandler(this.FelhasználóiKézikönyvToolStripMenuItem_Click);
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
            this.Date_Label.Location = new System.Drawing.Point(188, 301);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(0, 24);
            this.Date_Label.TabIndex = 3;
            // 
            // userdatas
            // 
            this.userdatas.AutoSize = true;
            this.userdatas.Location = new System.Drawing.Point(61, 363);
            this.userdatas.Name = "userdatas";
            this.userdatas.Size = new System.Drawing.Size(0, 13);
            this.userdatas.TabIndex = 4;
            // 
            // usedata_button
            // 
            this.usedata_button.Location = new System.Drawing.Point(512, 387);
            this.usedata_button.Name = "usedata_button";
            this.usedata_button.Size = new System.Drawing.Size(120, 40);
            this.usedata_button.TabIndex = 5;
            this.usedata_button.Text = "Adatok elrejtése";
            this.usedata_button.UseVisualStyleBackColor = true;
            this.usedata_button.Click += new System.EventHandler(this.Usedata_button_Click);
            // 
            // Authenticated_label
            // 
            this.Authenticated_label.AutoSize = true;
            this.Authenticated_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Authenticated_label.ForeColor = System.Drawing.Color.Coral;
            this.Authenticated_label.Location = new System.Drawing.Point(293, 89);
            this.Authenticated_label.Name = "Authenticated_label";
            this.Authenticated_label.Size = new System.Drawing.Size(216, 20);
            this.Authenticated_label.TabIndex = 6;
            this.Authenticated_label.Text = "Nem hitelesitett felhasználó";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Authenticated_label);
            this.Controls.Add(this.usedata_button);
            this.Controls.Add(this.userdatas);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Welcomae_Label);
            this.Controls.Add(this.GotoStreet_Views);
            this.Controls.Add(this.GotoStreetMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem felhasználóiAdataimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkáltatóiIgazolásToolStripMenuItem;
        private System.Windows.Forms.Label userdatas;
        private System.Windows.Forms.Button usedata_button;
        private System.Windows.Forms.Label Authenticated_label;
        private System.Windows.Forms.ToolStripMenuItem felhasználóiRegisztrációToolStripMenuItem;
    }
}