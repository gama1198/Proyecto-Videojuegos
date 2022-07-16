using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCertamen3
{
    public partial class pryListadejuegos : Form
    {
        public pryListadejuegos()
        {
            InitializeComponent();
        }
        
        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {

        }
        bool archivoleido = false;
        private void btnVerLista_Click(object sender, EventArgs e)
        {
            if (!archivoleido)
            {
             
                string datos;
                StreamReader juegos = new StreamReader("../../../Datos.juegos.txt",true);
                while ((datos = juegos.ReadLine()) != null)
                {
                    string[] campos = datos.Split(';');
                    dgvMostrar1.Rows.Add(campos[0], campos[1]);
                    

                }
                
                archivoleido = true;



            }
            else
                MessageBox.Show("Archivo leido");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("../../../Datos.juegos.txt",true);
            try
            {
              
                dgvMostrar1.Rows.Remove(dgvMostrar1.CurrentRow);
                MessageBox.Show("Juego Eliminado", "Correcto");
               
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar un juego", "Error");
            }
            archivo.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int actualizar = int.Parse(txbActualizar.Text);
                int posicion = dgvMostrar1.CurrentRow.Index;
                dgvMostrar1[1, posicion].Value = actualizar;
                MessageBox.Show("Numero de usuarios actualizado", "Correcto");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
                
            }

            txbActualizar.Clear();
        }

        private void dgvMostrar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvMostrar1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvMostrar1.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            
        }

        private void txbActualizar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
