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
    public partial class sali_cinema : Form
    {
        private db dbConnection = new db();

        public sali_cinema()
        {
            InitializeComponent();
        }

        private void cancel_sali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void id_sala_TextChanged(object sender, EventArgs e)
        {
            is_number();
        }

        public void is_number()
        {
            int is_number = 0;

            if (int.TryParse(id_sala.Text, out is_number))
            {
                ;
            }

            else
            {
                MessageBox.Show("ID-ul trebuie sa contina cifre");
            }
        }

        private void save_sala_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {

                if(id_sala.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nu ati completat id-ul salii");
                }
                else
                {
                    /*@ previne ca in campurile aplicatiei sa se introduca script sql(sql injection) */
                    SqlCommand cmd = new SqlCommand("INSERT INTO sala_cinema (id, nume, nr_locuri, nr_rand, nr_loc) VALUES (@id, @nume, @nr_locuri, @nr_rand, @nr_loc)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", id_sala.Text);
                    cmd.Parameters.AddWithValue("@nume", nume_sala.Text);
                    cmd.Parameters.AddWithValue("@nr_locuri", nr_locuri.Text);
                    cmd.Parameters.AddWithValue("@nr_rand", nr_rand.Text);
                    cmd.Parameters.AddWithValue("@nr_loc", nr_loc.Text);//mutam in rezervari
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
               
            }

        }

        private void new_record_Click(object sender, EventArgs e)
        {
            id_sala.Clear();
            nume_sala.Clear();
            nr_locuri.Clear();
            nr_rand.Clear();
            nr_loc.Clear();
        }
    }
}
