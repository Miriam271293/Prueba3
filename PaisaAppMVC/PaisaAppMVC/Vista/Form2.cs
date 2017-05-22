using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaisaAppMVC.Vista.BEBIDAS;
using PaisaAppMVC.Vista.POSTRES;
using PaisaAppMVC.Vista.COMIDACORRIDA;
using PaisaAppMVC.Vista.COMIDARAPIDA;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Login regreso = new Login();  //creando el objeto mnu2 
            regreso.Show();   //entra al form menu invitado
            this.Hide();  //Cerrando ventada
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicación", "PaisaApp");
            this.Close();  //Cerrando ventada 
            Application.Exit();  //finalizando toda ejecucion
        }

        private void comidaCorridaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComidaCorrida frm = new FrmComidaCorrida();
           frm.MdiParent = this;
           frm.Show();

        }

        private void comidaRapidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComidaRapida frm = new FrmComidaRapida();
            frm.Show();
        }

        private void postresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPostres frm = new FrmPostres();
            frm.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBebidas frm = new FrmBebidas();
            frm.Show();
        }

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEmpresa frmDatosEmpresa = new frmDatosEmpresa();
            frmDatosEmpresa.MdiParent = this;  //Coreguir 
            frmDatosEmpresa.Show();
        }
    }
}
