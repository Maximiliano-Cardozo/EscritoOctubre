using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Visual
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnIngresar.Enabled = false;
        }
        //public void ModificarVisibilidadDelBotonIngresar() {
        //    if (txtNombre.Text is null = false)
        //        if (txtPassword.Text is null)
        //            btnIngresar.Enabled = false;
                  
        //}

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposCompletos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void VerificarCamposCompletos()
        {
            if  (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPassword.Text))
                btnIngresar.Enabled = false;
            else
                btnIngresar.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposCompletos();
        }
    }
}
