using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PruebaApkComida
{
    public partial class frmDesayuno : Form
    {
        
       
        public Plato[] platosDesayuno = {
            new Plato("Taza de Api", 3.0),
            new Plato("Taza de Cafe", 2.0),
            new Plato("Taza de Leche", 3.0),
            new Plato("Pan", 1.0),
            new Plato("Buñuelo", 1.5),
            new Plato("Pastel", 2.0)
        };
   
        public frmDesayuno()
        {
            InitializeComponent();
           
            
        }

        private void btnAgregarApi_Click(object sender, EventArgs e)
        {

           
            string producto = $"{platosDesayuno[0].nombre} {platosDesayuno[0].precio} {platosDesayuno[0].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
          

        }

        private void frmDesayuno_Load(object sender, EventArgs e)
        {

        }

        private void lblCarrito_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCarrito.SelectedIndex != -1)
            {
                lblCarritoC.Text = lstCarrito.Items[lstCarrito.SelectedIndex].ToString();
            }
        }


        private void btnAgregarPan_Click(object sender, EventArgs e)
        {

            string producto = $"{platosDesayuno[3].nombre} {platosDesayuno[3].precio} {platosDesayuno[3].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarCafe_Click(object sender, EventArgs e)
        {
            string producto = $"{platosDesayuno[1].nombre} {platosDesayuno[1].precio} {platosDesayuno[1].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarLeche_Click(object sender, EventArgs e)
        {
            string producto = $"{platosDesayuno[2].nombre} {platosDesayuno[2].precio} {platosDesayuno[2].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarPastel_Click(object sender, EventArgs e)
        {
            string producto = $"{platosDesayuno[4].nombre} {platosDesayuno[4].precio} {platosDesayuno[4].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnAgregarBueniolo_Click(object sender, EventArgs e)
        {
            string producto = $"{platosDesayuno[5].nombre} {platosDesayuno[5].precio} {platosDesayuno[5].moneda}";
            lstCarrito.Items.Add(producto);
            ActualizarInformacionCarrito();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstCarrito.SelectedIndex;
            if (indice != -1)
            {
                lstCarrito.Items.RemoveAt(indice);
                ActualizarInformacionCarrito();
            }
        }

        private void lblCarritoC_Click_1(object sender, EventArgs e)
        {

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

            lblCarritoC.Text = $"Numero de desayuno: {numeroElementos} \nTotal: {sumaPrecios} {platosDesayuno[0].moneda}";
            
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



        private void frmDesayuno_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCompraAqui_Click(object sender, EventArgs e)
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

        private void btnCompraLlevar_Click(object sender, EventArgs e)
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

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lstCarrito.Items.Clear();
            lblCarritoC.Text = $"Numero de desayuno: {0} \nTotal: {0} {platosDesayuno[0].moneda}";
        }
    }
}
