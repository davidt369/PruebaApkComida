using System.Windows.Forms;

namespace PruebaApkComida
{
    public partial class frmAlmuerzo : Form
    {
        public Plato[] platosAlmuerzo = {
            new Plato("Milanesa de pollo", 12),
            new Plato("Pique Macho", 12),
            new Plato("Sopa de mani", 5),
            new Plato("Silpancho", 15),
            new Plato("Sopa Chairo", 5),
            new Plato("Lawa de chuño", 6)
        };
        public frmAlmuerzo()
        {
            InitializeComponent();
        }

        private void btnAgregarMilanesaPollo_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[0].nombre} {platosAlmuerzo[0].precio} {platosAlmuerzo[0].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarPique_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[1].nombre} {platosAlmuerzo[1].precio} {platosAlmuerzo[1].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarSopaMani_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[2].nombre} {platosAlmuerzo[2].precio} {platosAlmuerzo[2].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarSilpancho_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[3].nombre} {platosAlmuerzo[3].precio} {platosAlmuerzo[3].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarSopaChairo_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[4].nombre} {platosAlmuerzo[4].precio} {platosAlmuerzo[4].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarLawaChuño_Click(object sender, System.EventArgs e)
        {
            string producto = $"{platosAlmuerzo[5].nombre} {platosAlmuerzo[5].precio} {platosAlmuerzo[5].moneda}";
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

            lblCarritoC.Text = $"Numero de Platos: {numeroElementos}, \nTotal: {sumaPrecios} {platosAlmuerzo[0].moneda}";

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
