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

namespace ejercicio5
{
    public partial class Form1 : Form
    {

        string cadena = "data source = DESKTOP-EQHDL07; Initial Catalog = ejercicio5; Integrated Security=True";

        SqlConnection Conectarbd = new SqlConnection();

        conecBD cnbd = new conecBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conecBD conectar = new conecBD();
            conectar.abrir();
            MessageBox.Show("conectado");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            Conectarbd.ConnectionString = cadena;
            Conectarbd.Open();
            

            try
            {
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            cnbd.mostrar("datos", dataGridView1);
            Conectarbd.Close();
            
        }
    }
}
