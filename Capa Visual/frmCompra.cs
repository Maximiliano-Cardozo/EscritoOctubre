using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Visual
{
    public partial class t : Form
    {
        DataTable Tabla;

        public t()
        {
           
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void t_Load(object sender, EventArgs e)
        {
            ListarSouvenirDesdeBd();
          

            
        }

        private void ListarSouvenirDesdeBd()
        {
         Tabla = SouvenirControlador.ListarSouvenir();
            

            for (int i = 0; i < Tabla.Rows.Count; i++)
            {


                dgvSouvenir.Rows.Add(Tabla.Rows[i][1],
                        Tabla.Rows[i][3]);



            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new frmPrincipal();
            formulario.Show();
        }

        private void dgvSouvenir_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
         
            var row = (sender as DataGridView).CurrentRow;
            txtArticulo.Text = row.Cells[0].Value.ToString();
            int stock = int.Parse(dgvSouvenir.CurrentRow.Cells[1].Value.ToString());
            txtCantidad.Text = null;
            lblStock.ForeColor = Color.FromArgb(0, 143, 57);
            lblStock.Text = "Stock disponible: " + stock.ToString();
        }

        

        
        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
           
        }

        //private void ActivarBotonAlta()
        //{
        //    if (txtArticulo.Text.ToString() == string.Empty | txtCantidad.Text == string.Empty)
        //        btnRealizarCompra.Enabled = false;

        //    else
        //        btnRealizarCompra.Enabled = true;
        //}

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ComprobarStockDisponible();
           
        }

        private void ComprobarStockDisponible()
        {
            int cantidad;
            if (txtCantidad.Text == string.Empty)
                cantidad = 0;
            else
                cantidad = int.Parse(txtCantidad.Text);

            int stock = int.Parse( dgvSouvenir.CurrentRow.Cells[1].Value.ToString());

            if (stock >= cantidad )
            {
                btnRealizarCompra.Enabled = true;
                lblStock.ForeColor = Color.FromArgb(0, 143, 57);
                lblStock.Text = "Stock disponible: " + stock.ToString();

            }
            else
            {
                btnRealizarCompra.Enabled = false;
                lblStock.ForeColor = Color.FromArgb(255,0,0);
                lblStock.Text = "No hay stock disponible.";
            }
        
        }

        private void dgvSouvenir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
