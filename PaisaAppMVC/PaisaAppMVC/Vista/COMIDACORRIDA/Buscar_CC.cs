using System;
using System.Drawing;
using System.Windows.Forms;
using PaisaAppMVC.Modelo.COMIDACORRIDA;

namespace PaisaAppMVC.Vista.COMIDACORRIDA
{
	/// <summary>
	/// Description of Buscar_CC.
	/// </summary>
	public partial class Buscar_CC : Form
	{
		public Buscar_CC()
		{
			InitializeComponent();
			
		}
				public Buscar_CC1 CCSelecionado { get; set; }
		
		void Buscar_CCLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			 dgvBuscar.DataSource = Buscar_CC_DAL.Buscar(txtBuscar.Text);
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			 if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                CCSelecionado = Buscar_CC_DAL.ObtenerBuscar_CC1(id);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			  this.Close();		
			
		}
	}
}
