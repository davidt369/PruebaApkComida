using System;
using System.Windows.Forms;

namespace PruebaApkComida
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            Form frm_desayuno = new frmDesayuno();
            frm_desayuno.Show();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm_cena = new frmCena();
            frm_cena.Show();
  
        }

        private void btnAlmuerzo_Click(object sender, EventArgs e)
        {
            Form frm_almuerzo = new frmAlmuerzo();
            frm_almuerzo.Show();
       
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
