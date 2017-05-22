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
using PaisaAppMVC.Modelo.BEBIDAS;
using PaisaAppMVC.Conexion;
//namespace WindowsFormsApplication1
namespace PaisaAppMVC.Vista.BEBIDAS
{
    public partial class FrmBebidas : Form
    {
        public FrmBebidas()
        {
            InitializeComponent();
        }
               //public CC4 CCACTUAL4 { get; set; }
               public Buscar_B1 CCACTUAL4 { get; set; }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
        
        void BtnGuardarClick(object sender, EventArgs e)
        {
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {
            	// Buscar_CR1 pCC2 = new Buscar_CR1();
                Buscar_B1 pCC4 = new Buscar_B1();
                pCC4.nombreBebida = textBox1.Text.Trim();
                pCC4.tipoBebida = textBox2.Text.Trim();
                pCC4.horario = textBox3.Text.Trim();
              	pCC4.costo = textBox4.Text.Trim();

                int resultado = Buscar_B_DAL.Agregar(pCC4);
                if (resultado > 0)
                {
                    MessageBox.Show(" Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
          }
        }
        
        void BtnNuevoClick(object sender, EventArgs e)
        {
        	Limpiar();
            Deshabilitar();   
        	
        }
        
        void BtnBuscarClick(object sender, EventArgs e)
        {
        	Buscar_B buscar2 = new Buscar_B();
            buscar2.ShowDialog();

            if (buscar2.CCSelecionado != null)
//CCSelecionado            	
            {
                CCACTUAL4 = buscar2.CCSelecionado;
                textBox1.Text = buscar2.CCSelecionado.nombreBebida;
                textBox2.Text = buscar2.CCSelecionado.tipoBebida;
                textBox3.Text = buscar2.CCSelecionado.horario;
                textBox4.Text = buscar2.CCSelecionado.costo;

                btnActualizar.Enabled = true;
                button2.Enabled = true;
                Habilitar();
                btnGuardar.Enabled = false;
            }
        }
        
        void BtnActualizarClick(object sender, EventArgs e)
        {
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {

            Buscar_B1 pCC4 = new Buscar_B1();
            pCC4.nombreBebida = textBox1.Text.Trim();
            pCC4.tipoBebida = textBox2.Text.Trim();
            pCC4.horario = textBox3.Text.Trim();
            pCC4.costo = textBox4.Text.Trim();
            pCC4.Id = CCACTUAL4.Id;

            if (Buscar_B_DAL.Actualizar(pCC4) > 0)
            {
                MessageBox.Show("Los datos se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Deshabilitar();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
          }
        	
        }
        
        void Button2Click(object sender, EventArgs e)
        {
        	if (MessageBox.Show("Esta Seguro que desea eliminar", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Buscar_B_DAL.Eliminar(CCACTUAL4.Id) > 0)
                {
                    MessageBox.Show(" Eliminado Correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else

                {
                    MessageBox.Show("No se pudo eliminar ", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	
        }
        
        void Button4Click(object sender, EventArgs e)
        {
        	 try
            {
                string Query = "select * from paisaapp.bebidas;";
                MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;//sobrecarga 3
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        	
        }
        
        void BtnCancelarClick(object sender, EventArgs e)
        {
        	Limpiar();
            Deshabilitar();
        }
        
         void Limpiar()
        {
            textBox1.Clear();
           textBox2.Clear();
            textBox3.Clear();
            textBox4.ResetText();

        }

        void Habilitar()
        {
            textBox1.Enabled = true;
           textBox2.Enabled = true;
            textBox3.Enabled = true;
           textBox4.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }


        void Deshabilitar()
        {
           textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
           textBox4.Enabled = false;
            btnGuardar.Enabled = false;
            button2.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;

            btnNuevo.Enabled = true;

        }
        
     
    }
}
