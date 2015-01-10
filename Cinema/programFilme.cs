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
    public partial class programFilme : Form
    {
        private db dbConnection = new db();
        public programFilme()
        {
            InitializeComponent();
        }

        private void programFilme_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using(SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("select f.Nume, sc.nume as nume_sala, pf.Zi, pf.Ora from program_filme pf, sala_cinema sc, filme f where pf.ID_film = f.ID and pf.ID_Sala = sc.id");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem items = new ListViewItem(reader["Nume"].ToString());
                        items.SubItems.Add(reader["nume_sala"].ToString());
                        items.SubItems.Add(reader["Zi"].ToString());
                        items.SubItems.Add(reader["Ora"].ToString());
                        listView1.Items.Add(items);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
