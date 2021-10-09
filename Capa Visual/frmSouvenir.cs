﻿using System;
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
                SouvenirControlador.AltaProducto(
                    txtNombre.Text,
                    txtDescripcion.Text,
                    Int32.Parse(txtStock.Text),
                    float.Parse(txtPrecio.Text));

                MessageBox.Show("Producto agregado correctamente.");

                ListarSouvenirDesdeBd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no puedo ser realizada." + ex);

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
                dgwSouvenir.Rows.Add(dtsouvenir.Rows[i][0],
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
           
           ListarSouvenirDesdeBd();
        }

        private void dgwSouvenir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            MessageBox.Show(n.ToString());
            //if (n != -1)
            //{
            //    txtId.Text = (String)dgwSouvenir.Rows[n].Cells[1].Value;
            //    txtNombre.Text = (String)dgwSouvenir.Rows[n].Cells[2].Value;
            //    txtDescripcion.Text = (String)dgwSouvenir.Rows[n].Cells[3].Value;
            //    txtStock.Text = (String)dgwSouvenir.Rows[n].Cells[4].Value;
            //    txtPrecio.Text = (String)dgwSouvenir.Rows[n].Cells[5].Value;
            //    txtFecha.Text = (String)dgwSouvenir.Rows[n].Cells[6].Value;
            //}
        }

        private void dgwSouvenir_selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 FilaSeleccionada =dgwSouvenir.Rows.GetRowCount(DataGridViewElementStates.Selected);
            MessageBox.Show(FilaSeleccionada.ToString());
        }

    }

    
    
}
