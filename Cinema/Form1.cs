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


    public partial class cinema : Form
    {

        private db dbConnection = new db(); // se  poate initializa din orice clasa


        
        public cinema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }



        private void adaugaFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adauga_filme FILM = new adauga_filme();
            FILM.Show();
        }

       /* private void connect_to_db_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = this.dbConnection.getResult("select * from Filme");

            while (reader.Read())
            {
                Console.WriteLine(reader["Descriere"]);
            }
        }*/

       

        private void adaugaSaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sali_cinema SALA = new sali_cinema();
            SALA.Show();
        }

        private void modificaFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modif_filme FILM_MODIF = new modif_filme();
            FILM_MODIF.Show();
        }

        private void stergeFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }

        private void modificaSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modif_sala SALA_MODIF = new modif_sala();
            SALA_MODIF.Show();
        }

        private void show_reservation_Click(object sender, EventArgs e)
        {
            rezervari REZ = new rezervari();
            REZ.Show();
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cauta c = new cauta();
            c.Show();
        }

        
    }
}
