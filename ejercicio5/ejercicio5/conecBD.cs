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

        

        //Metodo para abrir la conexion
        public void abrir()
        {
            
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
