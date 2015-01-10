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
                    SqlCommand cmd = new SqlCommand(/*"select * from rezervari_bilete"*/ "select  Nume , Prenume from clienti c inner join rezervari_bilete rb  on c.id = rb.[[ID Client] ");
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
    }
}