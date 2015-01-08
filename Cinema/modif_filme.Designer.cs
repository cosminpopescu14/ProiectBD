namespace Cinema
{
    partial class modif_filme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_films = new System.Windows.Forms.Button();
            this.update_db = new System.Windows.Forms.Button();
            this.delete_film = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // show_films
            // 
            this.show_films.Location = new System.Drawing.Point(881, 73);
            this.show_films.Name = "show_films";
            this.show_films.Size = new System.Drawing.Size(105, 37);
            this.show_films.TabIndex = 1;
            this.show_films.Text = "Afiseaza filmele";
            this.show_films.UseVisualStyleBackColor = true;
            this.show_films.Click += new System.EventHandler(this.show_films_Click);
            // 
            // update_db
            // 
            this.update_db.Location = new System.Drawing.Point(881, 147);
            this.update_db.Name = "update_db";
            this.update_db.Size = new System.Drawing.Size(105, 41);
            this.update_db.TabIndex = 2;
            this.update_db.Text = "Salveaza Modificarile";
            this.update_db.UseVisualStyleBackColor = true;
            this.update_db.Click += new System.EventHandler(this.update_db_Click);
            // 
            // delete_film
            // 
            this.delete_film.Location = new System.Drawing.Point(881, 227);
            this.delete_film.Name = "delete_film";
            this.delete_film.Size = new System.Drawing.Size(105, 38);
            this.delete_film.TabIndex = 3;
            this.delete_film.Text = "Sterge film";
            this.delete_film.UseVisualStyleBackColor = true;
            this.delete_film.Click += new System.EventHandler(this.delete_film_Click);
            // 
            // modif_filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 577);
            this.Controls.Add(this.delete_film);
            this.Controls.Add(this.update_db);
            this.Controls.Add(this.show_films);
            this.Controls.Add(this.dataGridView1);
            this.Name = "modif_filme";
            this.Text = "Modificare filme";
            this.Load += new System.EventHandler(this.modif_filme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_films;
        private System.Windows.Forms.Button update_db;
        private System.Windows.Forms.Button delete_film;
    }
}