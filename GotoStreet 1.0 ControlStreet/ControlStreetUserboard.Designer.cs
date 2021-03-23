namespace GotoStreet_1._0_ControlStreet
{
    partial class ControlStreetUserboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlStreetUserboard));
            this.ControlStreetMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elfogadottKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elutasitottKijárásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idAlapjánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dátumAlapjánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijárásiOkAlapjánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisztrációToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisztrációToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlStreetGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hidden_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idsearch_label = new System.Windows.Forms.Label();
            this.idsearch_textbox = new System.Windows.Forms.TextBox();
            this.datesearch_label = new System.Windows.Forms.Label();
            this.oksearch_label = new System.Windows.Forms.Label();
            this.date_Search_textbox = new System.Windows.Forms.TextBox();
            this.ok_search_textbox = new System.Windows.Forms.TextBox();
            this.hitelesitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlStreetMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStreetGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlStreetMenu
            // 
            this.ControlStreetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.regisztrációToolStripMenuItem});
            this.ControlStreetMenu.Location = new System.Drawing.Point(0, 0);
            this.ControlStreetMenu.Name = "ControlStreetMenu";
            this.ControlStreetMenu.Size = new System.Drawing.Size(800, 24);
            this.ControlStreetMenu.TabIndex = 0;
            this.ControlStreetMenu.Text = "menuStrip1";
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elfogadottKijárásokToolStripMenuItem,
            this.elutasitottKijárásokToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.hitelesitésToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Kijárások";
            // 
            // elfogadottKijárásokToolStripMenuItem
            // 
            this.elfogadottKijárásokToolStripMenuItem.Name = "elfogadottKijárásokToolStripMenuItem";
            this.elfogadottKijárásokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elfogadottKijárásokToolStripMenuItem.Text = "Elfogadott Kijárások";
            this.elfogadottKijárásokToolStripMenuItem.Click += new System.EventHandler(this.ElfogadottKijárásokToolStripMenuItem_Click);
            // 
            // elutasitottKijárásokToolStripMenuItem
            // 
            this.elutasitottKijárásokToolStripMenuItem.Name = "elutasitottKijárásokToolStripMenuItem";
            this.elutasitottKijárásokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elutasitottKijárásokToolStripMenuItem.Text = "Elutasitott Kijárások";
            this.elutasitottKijárásokToolStripMenuItem.Click += new System.EventHandler(this.ElutasitottKijárásokToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idAlapjánToolStripMenuItem,
            this.dátumAlapjánToolStripMenuItem,
            this.kijárásiOkAlapjánToolStripMenuItem});
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // idAlapjánToolStripMenuItem
            // 
            this.idAlapjánToolStripMenuItem.Name = "idAlapjánToolStripMenuItem";
            this.idAlapjánToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.idAlapjánToolStripMenuItem.Text = "Id alapján";
            this.idAlapjánToolStripMenuItem.Click += new System.EventHandler(this.IdAlapjánToolStripMenuItem_Click);
            // 
            // dátumAlapjánToolStripMenuItem
            // 
            this.dátumAlapjánToolStripMenuItem.Name = "dátumAlapjánToolStripMenuItem";
            this.dátumAlapjánToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dátumAlapjánToolStripMenuItem.Text = "Dátum alapján";
            this.dátumAlapjánToolStripMenuItem.Click += new System.EventHandler(this.DátumAlapjánToolStripMenuItem_Click);
            // 
            // kijárásiOkAlapjánToolStripMenuItem
            // 
            this.kijárásiOkAlapjánToolStripMenuItem.Name = "kijárásiOkAlapjánToolStripMenuItem";
            this.kijárásiOkAlapjánToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.kijárásiOkAlapjánToolStripMenuItem.Text = "Kijárási Ok alapján";
            this.kijárásiOkAlapjánToolStripMenuItem.Click += new System.EventHandler(this.KijárásiOkAlapjánToolStripMenuItem_Click);
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
            this.regisztrációToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.regisztrációToolStripMenuItem1.Text = "Regisztráció";
            this.regisztrációToolStripMenuItem1.Click += new System.EventHandler(this.RegisztrációToolStripMenuItem1_Click);
            // 
            // ControlStreetGridView
            // 
            this.ControlStreetGridView.AllowUserToAddRows = false;
            this.ControlStreetGridView.AllowUserToDeleteRows = false;
            this.ControlStreetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ControlStreetGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ControlStreetGridView.Location = new System.Drawing.Point(100, 127);
            this.ControlStreetGridView.Name = "ControlStreetGridView";
            this.ControlStreetGridView.ReadOnly = true;
            this.ControlStreetGridView.Size = new System.Drawing.Size(545, 150);
            this.ControlStreetGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Név";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dátum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kijárási Ok";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Státusz";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Hidden_button
            // 
            this.Hidden_button.Location = new System.Drawing.Point(111, 301);
            this.Hidden_button.Name = "Hidden_button";
            this.Hidden_button.Size = new System.Drawing.Size(520, 27);
            this.Hidden_button.TabIndex = 2;
            this.Hidden_button.Text = "Táblázat Törlése";
            this.Hidden_button.UseVisualStyleBackColor = true;
            this.Hidden_button.Click += new System.EventHandler(this.Hidden_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Arial", 18.25F);
            this.Welcome_label.Location = new System.Drawing.Point(239, 52);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(0, 28);
            this.Welcome_label.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keresési Feltételek:";
            // 
            // idsearch_label
            // 
            this.idsearch_label.AutoSize = true;
            this.idsearch_label.Location = new System.Drawing.Point(161, 370);
            this.idsearch_label.Name = "idsearch_label";
            this.idsearch_label.Size = new System.Drawing.Size(19, 13);
            this.idsearch_label.TabIndex = 5;
            this.idsearch_label.Text = "Id:";
            // 
            // idsearch_textbox
            // 
            this.idsearch_textbox.Location = new System.Drawing.Point(186, 367);
            this.idsearch_textbox.Name = "idsearch_textbox";
            this.idsearch_textbox.Size = new System.Drawing.Size(75, 20);
            this.idsearch_textbox.TabIndex = 6;
            // 
            // datesearch_label
            // 
            this.datesearch_label.AutoSize = true;
            this.datesearch_label.Location = new System.Drawing.Point(145, 405);
            this.datesearch_label.Name = "datesearch_label";
            this.datesearch_label.Size = new System.Drawing.Size(41, 13);
            this.datesearch_label.TabIndex = 7;
            this.datesearch_label.Text = "Dátum:";
            // 
            // oksearch_label
            // 
            this.oksearch_label.AutoSize = true;
            this.oksearch_label.Location = new System.Drawing.Point(156, 441);
            this.oksearch_label.Name = "oksearch_label";
            this.oksearch_label.Size = new System.Drawing.Size(24, 13);
            this.oksearch_label.TabIndex = 8;
            this.oksearch_label.Text = "Ok:";
            // 
            // date_Search_textbox
            // 
            this.date_Search_textbox.Location = new System.Drawing.Point(186, 402);
            this.date_Search_textbox.Name = "date_Search_textbox";
            this.date_Search_textbox.Size = new System.Drawing.Size(75, 20);
            this.date_Search_textbox.TabIndex = 9;
            // 
            // ok_search_textbox
            // 
            this.ok_search_textbox.Location = new System.Drawing.Point(186, 438);
            this.ok_search_textbox.Name = "ok_search_textbox";
            this.ok_search_textbox.Size = new System.Drawing.Size(75, 20);
            this.ok_search_textbox.TabIndex = 10;
            // 
            // hitelesitésToolStripMenuItem
            // 
            this.hitelesitésToolStripMenuItem.Name = "hitelesitésToolStripMenuItem";
            this.hitelesitésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hitelesitésToolStripMenuItem.Text = "Hitelesités";
            this.hitelesitésToolStripMenuItem.Click += new System.EventHandler(this.HitelesitésToolStripMenuItem_Click);
            // 
            // ControlStreetUserboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.ok_search_textbox);
            this.Controls.Add(this.date_Search_textbox);
            this.Controls.Add(this.oksearch_label);
            this.Controls.Add(this.datesearch_label);
            this.Controls.Add(this.idsearch_textbox);
            this.Controls.Add(this.idsearch_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Hidden_button);
            this.Controls.Add(this.ControlStreetGridView);
            this.Controls.Add(this.ControlStreetMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ControlStreetMenu;
            this.Name = "ControlStreetUserboard";
            this.Text = "GotoStreet Control 1.0 (Felhasználói környezet)";
            this.ControlStreetMenu.ResumeLayout(false);
            this.ControlStreetMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStreetGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ControlStreetMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elfogadottKijárásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elutasitottKijárásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idAlapjánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dátumAlapjánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijárásiOkAlapjánToolStripMenuItem;
        private System.Windows.Forms.DataGridView ControlStreetGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Hidden_button;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idsearch_label;
        private System.Windows.Forms.TextBox idsearch_textbox;
        private System.Windows.Forms.Label datesearch_label;
        private System.Windows.Forms.Label oksearch_label;
        private System.Windows.Forms.TextBox date_Search_textbox;
        private System.Windows.Forms.TextBox ok_search_textbox;
        private System.Windows.Forms.ToolStripMenuItem regisztrációToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regisztrációToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hitelesitésToolStripMenuItem;
    }
}