namespace Cinema
{
    partial class cinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cinema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrareFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareSaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaSaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show_reservation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrareFilmeToolStripMenuItem,
            this.administrareSaliToolStripMenuItem,
            this.despreAplicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrareFilmeToolStripMenuItem
            // 
            this.administrareFilmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaFilmToolStripMenuItem,
            this.modificaFilmToolStripMenuItem,
            this.cautareToolStripMenuItem});
            this.administrareFilmeToolStripMenuItem.Name = "administrareFilmeToolStripMenuItem";
            this.administrareFilmeToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.administrareFilmeToolStripMenuItem.Text = "Administrare Filme";
            // 
            // adaugaFilmToolStripMenuItem
            // 
            this.adaugaFilmToolStripMenuItem.Name = "adaugaFilmToolStripMenuItem";
            this.adaugaFilmToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.adaugaFilmToolStripMenuItem.Text = "Adauga film";
            this.adaugaFilmToolStripMenuItem.Click += new System.EventHandler(this.adaugaFilmToolStripMenuItem_Click);
            // 
            // modificaFilmToolStripMenuItem
            // 
            this.modificaFilmToolStripMenuItem.Name = "modificaFilmToolStripMenuItem";
            this.modificaFilmToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.modificaFilmToolStripMenuItem.Text = "Modifica film";
            this.modificaFilmToolStripMenuItem.Click += new System.EventHandler(this.modificaFilmToolStripMenuItem_Click);
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cautareToolStripMenuItem.Text = "Cautare";
            this.cautareToolStripMenuItem.Click += new System.EventHandler(this.cautareToolStripMenuItem_Click);
            // 
            // administrareSaliToolStripMenuItem
            // 
            this.administrareSaliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaSaliToolStripMenuItem,
            this.modificaSalaToolStripMenuItem});
            this.administrareSaliToolStripMenuItem.Name = "administrareSaliToolStripMenuItem";
            this.administrareSaliToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.administrareSaliToolStripMenuItem.Text = "Administrare sali";
            // 
            // adaugaSaliToolStripMenuItem
            // 
            this.adaugaSaliToolStripMenuItem.Name = "adaugaSaliToolStripMenuItem";
            this.adaugaSaliToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.adaugaSaliToolStripMenuItem.Text = "Adauga sala";
            this.adaugaSaliToolStripMenuItem.Click += new System.EventHandler(this.adaugaSaliToolStripMenuItem_Click);
            // 
            // modificaSalaToolStripMenuItem
            // 
            this.modificaSalaToolStripMenuItem.Name = "modificaSalaToolStripMenuItem";
            this.modificaSalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificaSalaToolStripMenuItem.Text = "Modifica sala";
            this.modificaSalaToolStripMenuItem.Click += new System.EventHandler(this.modificaSalaToolStripMenuItem_Click);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // show_reservation
            // 
            this.show_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.show_reservation.Location = new System.Drawing.Point(115, 160);
            this.show_reservation.Name = "show_reservation";
            this.show_reservation.Size = new System.Drawing.Size(115, 74);
            this.show_reservation.TabIndex = 2;
            this.show_reservation.Text = "Arata toate rezervarile";
            this.show_reservation.UseVisualStyleBackColor = false;
            this.show_reservation.Click += new System.EventHandler(this.show_reservation_Click);
            // 
            // cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 571);
            this.Controls.Add(this.show_reservation);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "cinema";
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrareFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrareSaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaSaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaSalaToolStripMenuItem;
        private System.Windows.Forms.Button show_reservation;
        private System.Windows.Forms.ToolStripMenuItem cautareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
    }
}

