using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ejercicio5
{
    internal class conecBD
    {
        string cadena = "data source = DESKTOP-EQHDL07; Initial Catalog = BaseDatos22; Integrated Security=True";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public conecBD()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                Console.WriteLine("conectado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }

        public void mostrar(String datos, DataGridView grid)
        {
            string cadena = "data source = DESKTOP-EQHDL07; Initial Catalog = ejercicio5; Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = cadena;
            conectar.Open();
            string query = "SELECT * FROM " + datos;
            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                throw;
            }
            conectar.Close();
        }

    }
}
