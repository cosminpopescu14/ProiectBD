namespace Cinema
{
    partial class sali_cinema
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
            this.save_sala = new System.Windows.Forms.Button();
            this.cancel_sali = new System.Windows.Forms.Button();
            this.id_sala_eticheta = new System.Windows.Forms.Label();
            this.id_sala = new System.Windows.Forms.TextBox();
            this.nr_loc = new System.Windows.Forms.TextBox();
            this.nr_loc_eticheta = new System.Windows.Forms.Label();
            this.nr_rand = new System.Windows.Forms.TextBox();
            this.Nr_rand_eticheta = new System.Windows.Forms.Label();
            this.nr_locuri = new System.Windows.Forms.TextBox();
            this.nr_locuri_eticheta = new System.Windows.Forms.Label();
            this.nume_sala = new System.Windows.Forms.TextBox();
            this.nume_sala_eticheta = new System.Windows.Forms.Label();
            this.new_record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_sala
            // 
            this.save_sala.Location = new System.Drawing.Point(261, 286);
            this.save_sala.Name = "save_sala";
            this.save_sala.Size = new System.Drawing.Size(75, 23);
            this.save_sala.TabIndex = 0;
            this.save_sala.Text = "Salveaza";
            this.save_sala.UseVisualStyleBackColor = true;
            this.save_sala.Click += new System.EventHandler(this.save_sala_Click);
            // 
            // cancel_sali
            // 
            this.cancel_sali.Location = new System.Drawing.Point(31, 286);
            this.cancel_sali.Name = "cancel_sali";
            this.cancel_sali.Size = new System.Drawing.Size(75, 23);
            this.cancel_sali.TabIndex = 1;
            this.cancel_sali.Text = "Renunta";
            this.cancel_sali.UseVisualStyleBackColor = true;
            this.cancel_sali.Click += new System.EventHandler(this.cancel_sali_Click);
            // 
            // id_sala_eticheta
            // 
            this.id_sala_eticheta.AutoSize = true;
            this.id_sala_eticheta.Location = new System.Drawing.Point(28, 27);
            this.id_sala_eticheta.Name = "id_sala_eticheta";
            this.id_sala_eticheta.Size = new System.Drawing.Size(42, 13);
            this.id_sala_eticheta.TabIndex = 2;
            this.id_sala_eticheta.Text = "ID Sala";
            // 
            // id_sala
            // 
            this.id_sala.Location = new System.Drawing.Point(86, 27);
            this.id_sala.Name = "id_sala";
            this.id_sala.Size = new System.Drawing.Size(100, 20);
            this.id_sala.TabIndex = 3;
            this.id_sala.TextChanged += new System.EventHandler(this.id_sala_TextChanged);
            // 
            // nr_loc
            // 
            this.nr_loc.Location = new System.Drawing.Point(86, 191);
            this.nr_loc.Name = "nr_loc";
            this.nr_loc.Size = new System.Drawing.Size(100, 20);
            this.nr_loc.TabIndex = 5;
            // 
            // nr_loc_eticheta
            // 
            this.nr_loc_eticheta.AutoSize = true;
            this.nr_loc_eticheta.Location = new System.Drawing.Point(28, 194);
            this.nr_loc_eticheta.Name = "nr_loc_eticheta";
            this.nr_loc_eticheta.Size = new System.Drawing.Size(35, 13);
            this.nr_loc_eticheta.TabIndex = 4;
            this.nr_loc_eticheta.Text = "Nr loc";
            // 
            // nr_rand
            // 
            this.nr_rand.Location = new System.Drawing.Point(86, 145);
            this.nr_rand.Name = "nr_rand";
            this.nr_rand.Size = new System.Drawing.Size(100, 20);
            this.nr_rand.TabIndex = 7;
            // 
            // Nr_rand_eticheta
            // 
            this.Nr_rand_eticheta.AutoSize = true;
            this.Nr_rand_eticheta.Location = new System.Drawing.Point(28, 145);
            this.Nr_rand_eticheta.Name = "Nr_rand_eticheta";
            this.Nr_rand_eticheta.Size = new System.Drawing.Size(42, 13);
            this.Nr_rand_eticheta.TabIndex = 6;
            this.Nr_rand_eticheta.Text = "Nr rand";
            // 
            // nr_locuri
            // 
            this.nr_locuri.Location = new System.Drawing.Point(86, 99);
            this.nr_locuri.Name = "nr_locuri";
            this.nr_locuri.Size = new System.Drawing.Size(100, 20);
            this.nr_locuri.TabIndex = 9;
            // 
            // nr_locuri_eticheta
            // 
            this.nr_locuri_eticheta.AutoSize = true;
            this.nr_locuri_eticheta.Location = new System.Drawing.Point(28, 99);
            this.nr_locuri_eticheta.Name = "nr_locuri_eticheta";
            this.nr_locuri_eticheta.Size = new System.Drawing.Size(46, 13);
            this.nr_locuri_eticheta.TabIndex = 8;
            this.nr_locuri_eticheta.Text = "Nr locuri";
            // 
            // nume_sala
            // 
            this.nume_sala.Location = new System.Drawing.Point(86, 60);
            this.nume_sala.Name = "nume_sala";
            this.nume_sala.Size = new System.Drawing.Size(100, 20);
            this.nume_sala.TabIndex = 11;
            // 
            // nume_sala_eticheta
            // 
            this.nume_sala_eticheta.AutoSize = true;
            this.nume_sala_eticheta.Location = new System.Drawing.Point(22, 60);
            this.nume_sala_eticheta.Name = "nume_sala_eticheta";
            this.nume_sala_eticheta.Size = new System.Drawing.Size(57, 13);
            this.nume_sala_eticheta.TabIndex = 10;
            this.nume_sala_eticheta.Text = "Nume sala";
            // 
            // new_record
            // 
            this.new_record.Location = new System.Drawing.Point(133, 286);
            this.new_record.Name = "new_record";
            this.new_record.Size = new System.Drawing.Size(101, 23);
            this.new_record.TabIndex = 12;
            this.new_record.Text = "Inregistrare noua";
            this.new_record.UseVisualStyleBackColor = true;
            this.new_record.Click += new System.EventHandler(this.new_record_Click);
            // 
            // sali_cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 392);
            this.Controls.Add(this.new_record);
            this.Controls.Add(this.nume_sala);
            this.Controls.Add(this.nume_sala_eticheta);
            this.Controls.Add(this.nr_locuri);
            this.Controls.Add(this.nr_locuri_eticheta);
            this.Controls.Add(this.nr_rand);
            this.Controls.Add(this.Nr_rand_eticheta);
            this.Controls.Add(this.nr_loc);
            this.Controls.Add(this.nr_loc_eticheta);
            this.Controls.Add(this.id_sala);
            this.Controls.Add(this.id_sala_eticheta);
            this.Controls.Add(this.cancel_sali);
            this.Controls.Add(this.save_sala);
            this.Name = "sali_cinema";
            this.Text = "Adaugare sali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_sala;
        private System.Windows.Forms.Button cancel_sali;
        private System.Windows.Forms.Label id_sala_eticheta;
        private System.Windows.Forms.TextBox id_sala;
        private System.Windows.Forms.TextBox nr_loc;
        private System.Windows.Forms.Label nr_loc_eticheta;
        private System.Windows.Forms.TextBox nr_rand;
        private System.Windows.Forms.Label Nr_rand_eticheta;
        private System.Windows.Forms.TextBox nr_locuri;
        private System.Windows.Forms.Label nr_locuri_eticheta;
        private System.Windows.Forms.TextBox nume_sala;
        private System.Windows.Forms.Label nume_sala_eticheta;
        private System.Windows.Forms.Button new_record;
    }
}