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
    public partial class modif_sala : Form
    {
        private db dbConnection = new db();
        public modif_sala()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow data_row = dataGridView1.Rows[i];
                        if (data_row.Selected == true)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            SqlCommand cmd = new SqlCommand("DELETE FROM sala_cinema WHERE ID = @ID");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.Add("@ID", dataGridView1.Rows[0].Cells[0].Value.ToString());
                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void show_Click(object sender, EventArgs e)//afiseaza salile din tabela sali
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM sala_cinema");
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.dbConnection.connectrionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update sala_cinema set id = @id, nume = @nume, nr_locuri = @nr_locuri, nr_rand = @nr_rand, nr_loc = @nr_loc where id = @id");
                    cmd.CommandType = CommandType.Text;
                    int rind = dataGridView1.CurrentRow.Index;//citesc indexul randului
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[rind].Cells["id"].Value.ToString());
                    cmd.Parameters.AddWithValue("@nume", dataGridView1.Rows[rind].Cells["nume"].Value.ToString());
                    cmd.Parameters.AddWithValue("@nr_locuri", dataGridView1.Rows[rind].Cells["nr_locuri"].Value.ToString());
                    cmd.Parameters.AddWithValue("@nr_rand", dataGridView1.Rows[rind].Cells["nr_rand"].Value.ToString());
                    cmd.Parameters.AddWithValue("@nr_loc", dataGridView1.Rows[rind].Cells["nr_loc"].Value.ToString());
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

        private void modif_sala_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataError +=
               new DataGridViewDataErrorEventHandler(datagridView_error);
        }
    }
}
