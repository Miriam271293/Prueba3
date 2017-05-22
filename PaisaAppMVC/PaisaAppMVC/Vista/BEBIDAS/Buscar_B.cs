/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using PaisaAppMVC.Modelo.BEBIDAS;

namespace PaisaAppMVC.Vista.BEBIDAS
{
	public partial class Buscar_B : Form
	{
		public Buscar_B()
		{ InitializeComponent();}
		

	public Buscar_B1 CCSelecionado { get; set; }
		
		
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
		dgvBuscar.DataSource = Buscar_B_DAL.Buscar(txtBuscar.Text);
		}
		
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                CCSelecionado = Buscar_B_DAL.ObtenerBuscar_B1(id);

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
