namespace Cinema
{
    partial class adauga_filme
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
            this.nume_film = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.TextBox();
            this.descriere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actori = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.an = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pret_bilet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id_film_eticheta = new System.Windows.Forms.Label();
            this.new_film_record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume_film
            // 
            this.nume_film.Location = new System.Drawing.Point(71, 53);
            this.nume_film.Multiline = true;
            this.nume_film.Name = "nume_film";
            this.nume_film.Size = new System.Drawing.Size(597, 20);
            this.nume_film.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gen";
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(75, 104);
            this.gen.Multiline = true;
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(597, 20);
            this.gen.TabIndex = 3;
            // 
            // descriere
            // 
            this.descriere.Location = new System.Drawing.Point(71, 159);
            this.descriere.Multiline = true;
            this.descriere.Name = "descriere";
            this.descriere.Size = new System.Drawing.Size(597, 20);
            this.descriere.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descriere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Actori";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // actori
            // 
            this.actori.Location = new System.Drawing.Point(75, 220);
            this.actori.Multiline = true;
            this.actori.Name = "actori";
            this.actori.Size = new System.Drawing.Size(597, 19);
            this.actori.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "An release";
            // 
            // an
            // 
            this.an.Location = new System.Drawing.Point(75, 278);
            this.an.Multiline = true;
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(597, 20);
            this.an.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rating";
            // 
            // pret_bilet
            // 
            this.pret_bilet.Location = new System.Drawing.Point(75, 379);
            this.pret_bilet.Multiline = true;
            this.pret_bilet.Name = "pret_bilet";
            this.pret_bilet.Size = new System.Drawing.Size(597, 20);
            this.pret_bilet.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pret Bilet";
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(75, 325);
            this.rating.Multiline = true;
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(597, 20);
            this.rating.TabIndex = 13;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(500, 506);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 14;
            this.save.Text = "Salveaza";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(175, 506);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Renunta";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id_film_eticheta
            // 
            this.id_film_eticheta.AutoSize = true;
            this.id_film_eticheta.Location = new System.Drawing.Point(12, 9);
            this.id_film_eticheta.Name = "id_film_eticheta";
            this.id_film_eticheta.Size = new System.Drawing.Size(39, 13);
            this.id_film_eticheta.TabIndex = 17;
            this.id_film_eticheta.Text = "ID Film";
            // 
            // new_film_record
            // 
            this.new_film_record.Location = new System.Drawing.Point(316, 506);
            this.new_film_record.Name = "new_film_record";
            this.new_film_record.Size = new System.Drawing.Size(111, 23);
            this.new_film_record.TabIndex = 18;
            this.new_film_record.Text = "Inregistrare noua";
            this.new_film_record.UseVisualStyleBackColor = true;
            this.new_film_record.Click += new System.EventHandler(this.new_film_record_Click);
            // 
            // adauga_filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 564);
            this.Controls.Add(this.new_film_record);
            this.Controls.Add(this.id_film_eticheta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pret_bilet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.an);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.actori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriere);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nume_film);
            this.Name = "adauga_filme";
            this.Text = "Adauga/Modifica Film";
            this.Click += new System.EventHandler(this.label4_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nume_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gen;
        private System.Windows.Forms.TextBox descriere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox an;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pret_bilet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label id_film_eticheta;
        private System.Windows.Forms.Button new_film_record;
    }
}