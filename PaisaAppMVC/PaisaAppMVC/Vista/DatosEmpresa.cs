using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PaisaAppMVC.Conexion;

namespace WindowsFormsApplication1
{
    public partial class frmDatosEmpresa : Form
    {
        public frmDatosEmpresa()
        {
            InitializeComponent();
            try
            {
                MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
                string Query = "select * from datosempresa where idempresa= 1";
                MySqlCommand mcd = new MySqlCommand(Query, MyConn2);
                MySqlDataReader mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    txtRFC.Text = mdr.GetString("rfc");
                    txtNombre.Text = mdr.GetString("nombre");
                    txtTelefono.Text = mdr.GetString("telefono");
                    txtEstado.Text = mdr.GetString("estado");
                    txtCalle.Text = mdr.GetString("calle");
                    txtCP.Text = mdr.GetString("cp");
                    txtInterior.Text = mdr.GetString("numint");
                    txtExterior.Text = mdr.GetString("numext");
                    txtManzana.Text = mdr.GetString("manzana");
                    txtLote.Text = mdr.GetString("lote");
                    txtColonia.Text = mdr.GetString("nombrecolonia");
                    txtDelMun.Text = mdr.GetString("nombremundel");
                }
                else
                {
                    MessageBox.Show("NO DATA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
                string Query = "UPDATE datosempresa SET datosempresa.rfc='" + txtRFC.Text + "', datosempresa.nombre='" + txtNombre.Text + "', datosempresa.telefono='" + txtTelefono.Text + "', datosempresa.estado='" + txtEstado.Text + "', datosempresa.calle='" + txtCalle.Text + "', datosempresa.cp='" + txtCP.Text + "', datosempresa.numint='" + txtInterior.Text + "', datosempresa.numext='" + txtExterior.Text + "', datosempresa.manzana='" + txtManzana.Text + "', datosempresa.lote='" + txtLote.Text + "', datosempresa.nombrecolonia='" + txtColonia.Text + "', datosempresa.nombremundel='" + txtDelMun.Text + "' WHERE datosempresa.idempresa=1;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Actualizados");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
