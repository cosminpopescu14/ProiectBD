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
    public partial class rezervari : Form
    {
        private db dbConnection = new db();
        public rezervari()
        {
            InitializeComponent();
        }

        private void rezervari_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select c.Nume , c.Prenume , f.Nume, sc.nume from clienti c, rezervari_bilete rb, filme f, sala_cinema sc where rb.[[ID Client] = c.id and rb.[ID Film] = f.ID and rb.[ID Sala] = sc.id");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable DT = new DataTable();
                        DT.Load(reader);
                        dataGridView1.DataSource = DT;
                    }
                }
                catch
                {
                    MessageBox.Show("Eroare !");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ;
        }
    }
}