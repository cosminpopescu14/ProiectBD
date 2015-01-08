using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema
{
    public partial class adauga_filme : Form
    {
        private db dbConnection = new db(); // se  poate initializa din orice clasa. contine  clasa in care se afla metoda de conectre la baza de date

        public adauga_filme()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ;
        }

        private void save_Click(object sender, EventArgs e)//adaug datele din casute in tabela filme a bazei de date
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))//am instrdus blocul de sql intr-un if-else pt a nu executa cererea daca campul id_film este gol
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nu ati completat id-ul filmului");
                }
                else
                {
                    /*@ previne ca in camprile aplicatiei sa se introduca script sql(sql injection) */
                    SqlCommand cmd = new SqlCommand("INSERT INTO filme (ID, Nume, Gen, Descriere, Actori, An, Rating, Pret) VALUES (@ID, @Nume, @Gen, @Descriere, @Actori, @An, @Rating, @Pret)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Nume", nume_film.Text);
                    cmd.Parameters.AddWithValue("@Gen", gen.Text);
                    cmd.Parameters.AddWithValue("@Descriere", descriere.Text);
                    cmd.Parameters.AddWithValue("@Actori", actori.Text);
                    cmd.Parameters.AddWithValue("@An", an.Text);
                    cmd.Parameters.AddWithValue("@Rating", rating.Text);
                    cmd.Parameters.AddWithValue("@Pret", pret_bilet.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//verifica daca idul este numeric
        {
            int is_number = 0;

            if (int.TryParse(textBox1.Text, out is_number))
            {
                ; 
            }

            else
            {
                MessageBox.Show("ID-ul trebuie sa contina cifre");
            }
  
        }

        private void new_film_record_Click(object sender, EventArgs e)//sterg continuturile din campuri in caz ca vreau sa adaug noi filme
        {
            textBox1.Clear();
            nume_film.Clear();
            gen.Clear();
            descriere.Clear();
            actori.Clear();
            an.Clear();
            rating.Clear();
            pret_bilet.Clear();
            
        }
    }
}
