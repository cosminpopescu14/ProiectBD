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
using System.Configuration;

namespace Cinema
{
    public partial class modif_filme : Form
    {
        private db dbConnection = new db();
        public modif_filme()
        {
            InitializeComponent();
        }

        private void show_films_Click(object sender, EventArgs e)//afisez datele din tabela filme intr-un data grid.
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM filme");
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
                    MessageBox.Show("Eroare la conexiunea cu baza de date!");
                }

                finally
                {
                    connection.Close();
                }
            }
            
        }
       
        private void update_db_Click(object sender, EventArgs e)//actualizare folosind update, baza de date cu modificarile facute in datagrid, 
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try 
                {
                    SqlCommand cmd = new SqlCommand("update filme set ID = @ID, Nume = @Nume, Gen = @Gen, Descriere = @Descriere, Actori = @Actori, An = @An, Rating = @Rating, Pret = @Pret where ID = @ID");
                    cmd.CommandType = CommandType.Text;
                    int rind = dataGridView1.CurrentRow.Index;//citesc indexul randului
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[rind].Cells["ID"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Nume", dataGridView1.Rows[rind].Cells["Nume"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Gen", dataGridView1.Rows[rind].Cells["Gen"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Descriere", dataGridView1.Rows[rind].Cells["Descriere"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Actori", dataGridView1.Rows[rind].Cells["Actori"].Value.ToString());
                    cmd.Parameters.AddWithValue("@An", dataGridView1.Rows[rind].Cells["An"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Rating", dataGridView1.Rows[rind].Cells["Rating"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Pret", dataGridView1.Rows[rind].Cells["Pret"].Value.ToString());
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare");
                    
                } 
            }
        }

      private void datagridView_error(object sender, DataGridViewDataErrorEventArgs e)//utilizatorul nu poate lasa coloanele care nu aceept nul, vide.
      {
          e.ThrowException = false;
          string err_text = "Eroare la " + dataGridView1.Columns[e.ColumnIndex].HeaderText + "\n\n" + e.Exception.Message;
          MessageBox.Show(err_text, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          e.Cancel = false;
      }

        private void delete_film_Click(object sender, EventArgs e)//stergere inregistrare din baza de date
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    
                    for(int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow data_row = dataGridView1.Rows[i];
                        
                        if(data_row.Selected == true)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            SqlCommand cmd = new SqlCommand("DELETE FROM filme WHERE ID = @ID");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[0].Cells["ID"].Value.ToString());
                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare");
                }
                finally
                {
                    connection.Close();
                }
            }       
        }

        private void modif_filme_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataError +=
               new DataGridViewDataErrorEventHandler(datagridView_error);
        }
    }
} 
