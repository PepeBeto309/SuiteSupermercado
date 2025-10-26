using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuiteSupermercado
{
    public partial class MenuPrinicpal : Form
    {
        private moduloPuntoDeVenta formularioPuntoVenta = null;
        private moduloInventarios formularioInventarios = null;
        private moduloClientes formularioClientes = null;
        private moduloCuentas formularioCuentas = null;


        public MenuPrinicpal()
        {
            InitializeComponent();
        }

        private void pbPuntoDeVenta_Click(object sender, EventArgs e)
        {
            if (formularioPuntoVenta == null || formularioPuntoVenta.IsDisposed)
            {
                formularioPuntoVenta = new moduloPuntoDeVenta();
                formularioPuntoVenta.Show();
            }
            else
            {
                formularioPuntoVenta.BringToFront();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (formularioCuentas == null || formularioCuentas.IsDisposed)
            {
                formularioCuentas = new moduloCuentas();
                formularioCuentas.Show();
            }
            else
            {
                formularioCuentas.BringToFront();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (formularioClientes == null || formularioClientes.IsDisposed)
            {
                formularioClientes = new moduloClientes();
                formularioClientes.Show();
            }
            else
            {
                formularioClientes.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (formularioInventarios == null || formularioInventarios.IsDisposed)
            {
                formularioInventarios = new moduloInventarios();
                formularioInventarios.Show();
            }
            else
            {
                formularioInventarios.BringToFront();
            }
        }

    }
}
