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
    public partial class frmFactura : Form
    {
        public DateTime fechaHoraActual;

        frmCliente cliente;
        public string[] productos;


        public frmFactura(frmCliente cliente,   string[] productos)
        {
            InitializeComponent();
            
            fechaHoraActual = DateTime.Now;
            lblMostrarFecha.Text = $"{fechaHoraActual.Day}/" +
                $"{fechaHoraActual.Month}/" +
                $"{fechaHoraActual.Year}";
            lblMostrarHora.Text = $"{fechaHoraActual.Hour}:" +
                $"{fechaHoraActual.Minute}:" +
                $"{fechaHoraActual.Second}";

            this.cliente = cliente;

            lblMostraNombre.Text = $"{cliente.nombre} {cliente.apellidoP} {cliente.apellidoM}";
            lblMostraNit.Text = $"{cliente.nit}";
            this.productos = productos;
            lbxProductos.Items.Clear();

            // Agrega los elementos del arreglo a la ListBox
            lbxProductos.Items.AddRange(productos);
            CalcularPrecioTotal();
            lblCantidadProductos.Text = $"Cantidad de Productos: {(productos.Length).ToString()}\n" +
                $"Unidades";
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lblMostrarFecha_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CalcularPrecioTotal()
        {
            double precioTotal = 0;

            foreach (var producto in productos)
            {
                // Dividir la cadena para obtener el precio (suponiendo que el precio está al final de la cadena)
                string[] partes = producto.Split(' ');

                // Intentar encontrar el precio en la cadena
                double precio;
                if (EncontrarPrecio(partes, out precio))
                {
                    precioTotal += precio;
                }
                else
                {
                    // Manejar el caso en el que no se pueda encontrar el precio
                    // Puedes mostrar un mensaje de error, asignar un valor predeterminado, etc.
                }
            }

            // Mostrar el precio total en algún lugar de tu formulario
            lblPrecioTotal.Text = $"Precio Total: {precioTotal} Bs.";
        }

        // Método auxiliar para encontrar el precio en un array de strings
        private bool EncontrarPrecio(string[] partes, out double precio)
        {
            precio = 0;

            // Iterar sobre las partes en reversa para encontrar la primera que pueda convertirse a double
            for (int i = partes.Length - 1; i >= 0; i--)
            {
                if (double.TryParse(partes[i], out precio))
                {
                    return true;
                }
            }

            return false;
        }

        private void lblCantidadProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
