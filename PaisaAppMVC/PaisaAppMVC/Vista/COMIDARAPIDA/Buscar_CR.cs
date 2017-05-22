/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:36 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using PaisaAppMVC.Modelo.COMIDARAPIDA;

namespace PaisaAppMVC.Vista.COMIDARAPIDA
{
	/// <summary>
	/// Description of Buscar_CR.
	/// </summary>
	public partial class Buscar_CR : Form
	{
		public Buscar_CR()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Buscar_CR1 CCSelecionado { get; set; }
		
		public void BtnBuscarClick(object sender, EventArgs e)
		{
			
			dgvBuscar.DataSource = Buscar_CR_DAL.Buscar(txtBuscar.Text);
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                CCSelecionado = Buscar_CR_DAL.ObtenerBuscar_CR1(id);

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
