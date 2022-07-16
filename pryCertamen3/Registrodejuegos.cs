using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace pryCertamen3
{
    public partial class Registrodejuegos : Form
    {
        public Registrodejuegos()
        {
            InitializeComponent();
        }
       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("../../../Datos.juegos.txt", true);
            try
            {
                string nombre = (txbNombre.Text).ToString();
                int cantidad = int.Parse(txbCantidad.Text);
                archivo.WriteLine(nombre + ";" + cantidad);
                txbNombre.Clear();
                txbCantidad.Clear();
               


            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar datos", "Error");



            }

            archivo.Close();
        }

        private void btnmusica_Click(object sender, EventArgs e)
        {
           
        
           
        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
       
                
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form formulario = new pryListadejuegos();
            formulario.Show();
              
        }
    }
}
