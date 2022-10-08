namespace AdatkapcsolatGyakorlas
{
    partial class Index
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
            this.lbOrszagok = new System.Windows.Forms.ListBox();
            this.gpbAdatok = new System.Windows.Forms.GroupBox();
            this.lblFovaros = new System.Windows.Forms.Label();
            this.lblTerulet = new System.Windows.Forms.Label();
            this.lblNepesseg = new System.Windows.Forms.Label();
            this.lblAutojel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbFovaros = new System.Windows.Forms.TextBox();
            this.tbTerulet = new System.Windows.Forms.TextBox();
            this.tbNepesseg = new System.Windows.Forms.TextBox();
            this.tbAutojel = new System.Windows.Forms.TextBox();
            this.btTorol = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újRekordFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újRekordFelvételeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meglévőFrissítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meglévőTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbAdatok.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrszagok
            // 
            this.lbOrszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbOrszagok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOrszagok.FormattingEnabled = true;
            this.lbOrszagok.ItemHeight = 25;
            this.lbOrszagok.Location = new System.Drawing.Point(0, 29);
            this.lbOrszagok.Name = "lbOrszagok";
            this.lbOrszagok.Size = new System.Drawing.Size(410, 421);
            this.lbOrszagok.TabIndex = 0;
            this.lbOrszagok.SelectedIndexChanged += new System.EventHandler(this.lbOrszagok_SelectedIndexChanged);
            // 
            // gpbAdatok
            // 
            this.gpbAdatok.Controls.Add(this.btTorol);
            this.gpbAdatok.Controls.Add(this.tbAutojel);
            this.gpbAdatok.Controls.Add(this.tbNepesseg);
            this.gpbAdatok.Controls.Add(this.tbTerulet);
            this.gpbAdatok.Controls.Add(this.tbFovaros);
            this.gpbAdatok.Controls.Add(this.lblAutojel);
            this.gpbAdatok.Controls.Add(this.lblNepesseg);
            this.gpbAdatok.Controls.Add(this.lblTerulet);
            this.gpbAdatok.Controls.Add(this.lblFovaros);
            this.gpbAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbAdatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbAdatok.Location = new System.Drawing.Point(410, 29);
            this.gpbAdatok.Name = "gpbAdatok";
            this.gpbAdatok.Size = new System.Drawing.Size(390, 421);
            this.gpbAdatok.TabIndex = 1;
            this.gpbAdatok.TabStop = false;
            this.gpbAdatok.Text = "Az ország adatai";
            // 
            // lblFovaros
            // 
            this.lblFovaros.AutoSize = true;
            this.lblFovaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFovaros.Location = new System.Drawing.Point(15, 32);
            this.lblFovaros.Name = "lblFovaros";
            this.lblFovaros.Size = new System.Drawing.Size(90, 25);
            this.lblFovaros.TabIndex = 0;
            this.lblFovaros.Text = "Főváros";
            // 
            // lblTerulet
            // 
            this.lblTerulet.AutoSize = true;
            this.lblTerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTerulet.Location = new System.Drawing.Point(15, 84);
            this.lblTerulet.Name = "lblTerulet";
            this.lblTerulet.Size = new System.Drawing.Size(79, 25);
            this.lblTerulet.TabIndex = 1;
            this.lblTerulet.Text = "Terület";
            // 
            // lblNepesseg
            // 
            this.lblNepesseg.AutoSize = true;
            this.lblNepesseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNepesseg.Location = new System.Drawing.Point(15, 136);
            this.lblNepesseg.Name = "lblNepesseg";
            this.lblNepesseg.Size = new System.Drawing.Size(109, 25);
            this.lblNepesseg.TabIndex = 2;
            this.lblNepesseg.Text = "Népesség";
            // 
            // lblAutojel
            // 
            this.lblAutojel.AutoSize = true;
            this.lblAutojel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutojel.Location = new System.Drawing.Point(15, 188);
            this.lblAutojel.Name = "lblAutojel";
            this.lblAutojel.Size = new System.Drawing.Size(78, 25);
            this.lblAutojel.TabIndex = 3;
            this.lblAutojel.Text = "Autójel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "label14";
            // 
            // tbFovaros
            // 
            this.tbFovaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFovaros.Location = new System.Drawing.Point(123, 32);
            this.tbFovaros.Name = "tbFovaros";
            this.tbFovaros.Size = new System.Drawing.Size(255, 31);
            this.tbFovaros.TabIndex = 8;
            // 
            // tbTerulet
            // 
            this.tbTerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTerulet.Location = new System.Drawing.Point(123, 81);
            this.tbTerulet.Name = "tbTerulet";
            this.tbTerulet.Size = new System.Drawing.Size(255, 31);
            this.tbTerulet.TabIndex = 9;
            // 
            // tbNepesseg
            // 
            this.tbNepesseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNepesseg.Location = new System.Drawing.Point(123, 133);
            this.tbNepesseg.Name = "tbNepesseg";
            this.tbNepesseg.Size = new System.Drawing.Size(255, 31);
            this.tbNepesseg.TabIndex = 10;
            // 
            // tbAutojel
            // 
            this.tbAutojel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAutojel.Location = new System.Drawing.Point(123, 185);
            this.tbAutojel.Name = "tbAutojel";
            this.tbAutojel.Size = new System.Drawing.Size(255, 31);
            this.tbAutojel.TabIndex = 11;
            // 
            // btTorol
            // 
            this.btTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btTorol.Location = new System.Drawing.Point(19, 293);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(105, 35);
            this.btTorol.TabIndex = 12;
            this.btTorol.Text = "Törlés";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újRekordFelvételeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újRekordFelvételeToolStripMenuItem
            // 
            this.újRekordFelvételeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újRekordFelvételeToolStripMenuItem1,
            this.meglévőFrissítéseToolStripMenuItem,
            this.meglévőTörléseToolStripMenuItem});
            this.újRekordFelvételeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.újRekordFelvételeToolStripMenuItem.Name = "újRekordFelvételeToolStripMenuItem";
            this.újRekordFelvételeToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.újRekordFelvételeToolStripMenuItem.Text = "Műveletek";
            // 
            // újRekordFelvételeToolStripMenuItem1
            // 
            this.újRekordFelvételeToolStripMenuItem1.Name = "újRekordFelvételeToolStripMenuItem1";
            this.újRekordFelvételeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újRekordFelvételeToolStripMenuItem1.Text = "Új rekord felvétele";
            this.újRekordFelvételeToolStripMenuItem1.Click += new System.EventHandler(this.újRekordFelvételeToolStripMenuItem1_Click);
            // 
            // meglévőFrissítéseToolStripMenuItem
            // 
            this.meglévőFrissítéseToolStripMenuItem.Name = "meglévőFrissítéseToolStripMenuItem";
            this.meglévőFrissítéseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meglévőFrissítéseToolStripMenuItem.Text = "Meglévő frissítése";
            this.meglévőFrissítéseToolStripMenuItem.Click += new System.EventHandler(this.meglévőFrissítéseToolStripMenuItem_Click);
            // 
            // meglévőTörléseToolStripMenuItem
            // 
            this.meglévőTörléseToolStripMenuItem.Name = "meglévőTörléseToolStripMenuItem";
            this.meglévőTörléseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meglévőTörléseToolStripMenuItem.Text = "Meglévő törlése";
            this.meglévőTörléseToolStripMenuItem.Click += new System.EventHandler(this.meglévőTörléseToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbAdatok);
            this.Controls.Add(this.lbOrszagok);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Országok";
            this.Load += new System.EventHandler(this.Index_Load);
            this.gpbAdatok.ResumeLayout(false);
            this.gpbAdatok.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrszagok;
        private System.Windows.Forms.GroupBox gpbAdatok;
        private System.Windows.Forms.Button btTorol;
        private System.Windows.Forms.TextBox tbAutojel;
        private System.Windows.Forms.TextBox tbNepesseg;
        private System.Windows.Forms.TextBox tbTerulet;
        private System.Windows.Forms.TextBox tbFovaros;
        private System.Windows.Forms.Label lblAutojel;
        private System.Windows.Forms.Label lblNepesseg;
        private System.Windows.Forms.Label lblTerulet;
        private System.Windows.Forms.Label lblFovaros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újRekordFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újRekordFelvételeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem meglévőFrissítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meglévőTörléseToolStripMenuItem;
    }
}

