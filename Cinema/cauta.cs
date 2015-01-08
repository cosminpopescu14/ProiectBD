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
    public partial class cauta : Form

    {
        private db dbConnection = new db();
        public cauta()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)//cautare in tabelul filme al bazei de date.
        {
            listView1.Items.Clear();
            using(SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select Nume, Gen, Actori, An from filme where Nume like " + textBox1.Text);//comanda sql  pt cautare in tabela film. sablonul este preluat din textbox1. nu este scrisa corect
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();//incep executia comenzii de citire a datelor din baza
                    while(reader.Read())//citesc dim baza de date si afisez in listbox1
                    {
                        ListViewItem item = new ListViewItem(reader["Nume"].ToString());
                        item.SubItems.Add(reader["Gen"].ToString());
                        item.SubItems.Add(reader["Actori"].ToString());
                        item.SubItems.Add(reader["An"].ToString());
                        listView1.Items.Add(item);
                    }
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare");
                }
            }
        }
    }
}
