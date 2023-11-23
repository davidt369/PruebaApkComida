using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PruebaApkComida
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
    public class Plato
    {
        public string nombre;
        public double precio;
        public string moneda;

        public Plato(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.moneda = " Bs.";
        }
    }
   
    
}
