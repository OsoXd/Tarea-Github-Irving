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
            
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                throw;
            }
            conectar.Close();
        }

    }
}
