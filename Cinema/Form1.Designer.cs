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
            this.licentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show_reservation = new System.Windows.Forms.Button();
            this.progrm_filme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrareFilmeToolStripMenuItem,
            this.administrareSaliToolStripMenuItem,
            this.despreAplicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
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
            this.despreAplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licentaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // licentaToolStripMenuItem
            // 
            this.licentaToolStripMenuItem.Name = "licentaToolStripMenuItem";
            this.licentaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.licentaToolStripMenuItem.Text = "Licenta";
            this.licentaToolStripMenuItem.Click += new System.EventHandler(this.licentaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // show_reservation
            // 
            this.show_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.show_reservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.show_reservation.Location = new System.Drawing.Point(157, 103);
            this.show_reservation.Name = "show_reservation";
            this.show_reservation.Size = new System.Drawing.Size(115, 74);
            this.show_reservation.TabIndex = 2;
            this.show_reservation.Text = "Arata toate rezervarile";
            this.show_reservation.UseVisualStyleBackColor = false;
            this.show_reservation.Click += new System.EventHandler(this.show_reservation_Click);
            // 
            // progrm_filme
            // 
            this.progrm_filme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progrm_filme.Location = new System.Drawing.Point(157, 253);
            this.progrm_filme.Name = "progrm_filme";
            this.progrm_filme.Size = new System.Drawing.Size(115, 74);
            this.progrm_filme.TabIndex = 3;
            this.progrm_filme.Text = "Programul filmelor";
            this.progrm_filme.UseVisualStyleBackColor = false;
            this.progrm_filme.Click += new System.EventHandler(this.progrm_filme_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(481, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(813, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progrm_filme);
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
        private System.Windows.Forms.ToolStripMenuItem licentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button progrm_filme;
        private System.Windows.Forms.Button button1;
    }
}

