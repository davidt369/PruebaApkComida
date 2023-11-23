using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaApkComida
{
    public partial class frmCliente : Form
    {
        public string nombre;
        public string apellidoP;
        public string apellidoM;
        public string nit;
        public string[] productos;
        public frmCliente(string nombre, string apellidoP, string apellidoM, string nit,  string[] productos)
        {

            InitializeComponent();
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.nit = nit;
            this.productos = productos;
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txbNombre.Text;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            
        
        
        
            frmCliente cliente = new frmCliente(txbNombre.Text, txbApellidoP.Text, txbApellidoM.Text, txbNit.Text, productos);
            frmFactura frmFactura = new frmFactura(cliente, productos);
            frmFactura.Show();
        
        }

        private void txbApellidoP_TextChanged(object sender, EventArgs e)
        {
            apellidoP = txbApellidoP.Text;
        }

        private void txbApellidoM_TextChanged(object sender, EventArgs e)
        {
            apellidoM = txbApellidoM.Text;
        }

        private void txbNit_TextChanged(object sender, EventArgs e)
        {
            nit = txbNit.Text;
        }
    }
}

