using System.Windows.Forms;

namespace PruebaApkComida
{
    public partial class frmCena : Form
    {
        public Plato[] platosCena = {
            new Plato("Anticucho", 6.0),
            new Plato("Salchipapa", 12.0),
            new Plato("Tucumana", 6.0),
            new Plato("Relleno de papa", 6.0),
            new Plato("Majadito", 10.0),
            new Plato("Huminta", 5.0)
        };
        public frmCena()
        {
            InitializeComponent();
        }

        private void btnAgregarAnticucho_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[0].nombre} {platosCena[0].precio} {platosCena[0].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarSalchipapa_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[1].nombre} {platosCena[1].precio} {platosCena[1].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarTucumanas_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[2].nombre} {platosCena[2].precio} {platosCena[2].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }


        private void btnAgregarRellenoPapa_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[3].nombre} {platosCena[3].precio} {platosCena[3].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarMajadito_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[4].nombre} {platosCena[4].precio} {platosCena[4].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarHumintas_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosCena[5].nombre} {platosCena[5].precio} {platosCena[5].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void lblCarritoC_Click(object sender, System.EventArgs e)
        {

        }

        private void lstCarrito_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstCarrito.SelectedIndex != -1)
            {
                lblCarritoC.Text = lstCarrito.Items[lstCarrito.SelectedIndex].ToString();
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            int indice = lstCarrito.SelectedIndex;
            if (indice != -1)
            {
                lstCarrito.Items.RemoveAt(indice);
                ActualizarInformacionCarrito();
            }
        }

        private void btnCompraLlevar_Click(object sender, System.EventArgs e)
        {
            string[] arregloProductos = new string[lstCarrito.Items.Count];

            // Llenar el arreglo con los productos del carrito
            for (int i = 0; i < lstCarrito.Items.Count; i++)
            {
                arregloProductos[i] = lstCarrito.Items[i].ToString();
            }
            frmCliente frm_cliente = new frmCliente("", "", "", "", arregloProductos);
            frmFactura frm_factura = new frmFactura(frm_cliente, arregloProductos);
            frm_cliente.Show();
        }

        private void btnCompraAqui_Click(object sender, System.EventArgs e)
        {
            string[] arregloProductos = new string[lstCarrito.Items.Count];

            // Llenar el arreglo con los productos del carrito
            for (int i = 0; i < lstCarrito.Items.Count; i++)
            {
                arregloProductos[i] = lstCarrito.Items[i].ToString();
            }
            frmCliente frm_cliente = new frmCliente("", "", "", "", arregloProductos);
            frmFactura frm_factura = new frmFactura(frm_cliente, arregloProductos);
            frm_cliente.Show();
        }

        private void ActualizarInformacionCarrito()
        {
            int numeroElementos = lstCarrito.Items.Count;
            double sumaPrecios = 0;

            foreach (string item in lstCarrito.Items)
            {
                // Dividir la cadena para obtener el precio (suponiendo que el precio está al final de la cadena)
                string[] partes = item.Split(' ');

                // Intentar encontrar el precio en la cadena
                double precio;
                if (EncontrarPrecio(partes, out precio))
                {
                    sumaPrecios += precio;
                }
                else
                {
                    // Manejar el caso en el que no se pueda encontrar el precio
                    // Puedes mostrar un mensaje de error, asignar un valor predeterminado, etc.
                }
            }

            lblCarritoC.Text = $"Numero de compras: {numeroElementos}, \nTotal: {sumaPrecios} {platosCena[0].moneda}";

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

    }
}
