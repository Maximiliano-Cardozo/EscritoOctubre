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
    public partial class frmSouvenir : Form
    {
        

        public frmSouvenir()
        {
            InitializeComponent();
            ListarSouvenirDesdeBd();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           
            try
            {
                SouvenirControlador.AltaSouvenir(
                    txtNombre.Text,
                    txtDescripcion.Text,
                    Int32.Parse(txtStock.Text),
                    float.Parse(txtPrecio.Text));

                MessageBox.Show("Producto agregado correctamente.");
                LimpiarTabla();
                ListarSouvenirDesdeBd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no puedo ser realizada." );
                Console.WriteLine(ex);
            }
            
                   
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new frmPrincipal();
            formulario.Show();
        }

        private void frmProducto_Load_1(object sender, EventArgs e)
        {
   
        }

        private void ListarSouvenirDesdeBd()
        {
            DataTable dtsouvenir = SouvenirControlador.ListarSouvenir();

            for (int i =0; i < dtsouvenir.Rows.Count; i++)
            {
                dgvSouvenir.Rows.Add(dtsouvenir.Rows[i][0],
                    dtsouvenir.Rows[i][1],
                    dtsouvenir.Rows[i][2],
                    dtsouvenir.Rows[i][3],
                    dtsouvenir.Rows[i][4],
                    dtsouvenir.Rows[i][5]);
                               
            }
                   
        }
      

        private void btnLlamarAVentanaPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new frmPrincipal();
            formulario.Show();
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
           ListarSouvenirDesdeBd();
        }

        

    

        private void btnLimpiarTxtBox_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ActivarBotonAlta();
        }

        private void LimpiarCampos()
        {
            txtId.Text = null ;
            txtFecha.Text = null;
            txtDescripcion.Text = null;
            txtNombre.Text = null;
            txtPrecio.Text = null;
            txtStock.Text = null;
        }

        private void dgvSouvenir_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtId.Text = row.Cells[0].Value.ToString();
        }


        private void LimpiarTabla()
        {
            dgvSouvenir.Rows.Clear();


        }

        private void dgvSouvenir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            txtId.Text = row.Cells[0].Value.ToString();
            txtFecha.Text = row.Cells[5].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtStock.Text = row.Cells[3].Value.ToString();
            txtPrecio.Text = row.Cells[4].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            ActivarBotonAlta();
          }

        private void ActivarBotonAlta()
        {
            if (txtId.Text.ToString() == string.Empty) 
                btnAlta.Enabled = true;

            else
                btnAlta.Enabled = false;
            }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SouvenirControlador.ModificarSouvenir(
                    Int32.Parse(txtId.Text),
                    txtNombre.Text,
                    txtDescripcion.Text,
                    Int32.Parse(txtStock.Text),
                    float.Parse(txtPrecio.Text));

                MessageBox.Show("Producto actualizado correctamente." );

                LimpiarTabla();
                ListarSouvenirDesdeBd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no puedo ser realizada." );
                Console.WriteLine(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SouvenirControlador.EliminarSouvenir(
                    Int32.Parse(txtId.Text));

                MessageBox.Show("Producto eliminado correctamente.");
                LimpiarTabla();
                LimpiarCampos();
                ListarSouvenirDesdeBd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no puedo ser realizada." + ex);
                Console.WriteLine(ex);
            }
        }
    }
    }

    
    

