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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new frmSouvenir();
            formulario.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new t();
            formulario.Show();
        }
    }
}
