using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Cinema
{
    class db
    {
        public SqlConnection con = null;

        public string connectrionString()
        {
            return @"Server = COSMIN-Y5070; Database = Cinema Cos; Trusted_Connection = True ";//stringul de conectare
        }

        public void connect()
        {
            string connectionString = "Server = COSMIN-Y5070; Database = Cinema Cos; Trusted_Connection = True "; //ma conectez la baza de date
            this.con = new SqlConnection(connectionString);

            try
            {
                this.con.Open();
                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Nu se poate conecta la baza de date ! ");
            }
            
        }

        public SqlDataReader getResult(string query)
        {
            connect();
            
            SqlCommand cmd = new SqlCommand(query, this.con);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

      

    }
}
