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
using PaisaAppMVC.Modelo.COMIDARAPIDA;
using PaisaAppMVC.Conexion;

namespace PaisaAppMVC.Vista.COMIDARAPIDA
{
    public partial class FrmComidaRapida : Form
    {
        public FrmComidaRapida()
        {
            InitializeComponent();
        }
              public Buscar_CR1 CCACTUAL2 { get; set; }
                 //public CC CCACTUAL { get; set; }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        
       

        private void FrmComidaRapida_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                lblError.Text = "Los campos no pueden estar vacios.";
                return;
            }

            if (textBox2.Text == "")
            {
                lblError.Text = "Los campos no pueden estar vacios.";
                return;
            }

            if (textBox3.Text == "")
            {
                lblError.Text = "Los campos no pueden estar vacios.";
                return;
            }

            if (textBox4.Text == "")
            {
                lblError.Text = "Los campos no pueden estar vacios.";
                return;
            }


            try
            {
                MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
                string Query = "insert into paisaapp.comidarapida( nombreComida,tipoComida,horario,costo) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);//
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                MessageBox.Show("Agregado");
                // this.Close();
            }
            catch (FormatException exception01)
            {
                MessageBox.Show(exception01.Message, "Error Desconocido ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select * from paisaapp.comidarapida;";
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
        
        void BtnGuardarClick(object sender, EventArgs e)
        {
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {
                Buscar_CR1 pCC2 = new Buscar_CR1();
                pCC2.nombreComida = textBox1.Text.Trim();
                pCC2.tipoComida = textBox2.Text.Trim();
                pCC2.horario = textBox3.Text.Trim();
              	pCC2.costo = textBox4.Text.Trim();

                int resultado = Buscar_CR_DAL.Agregar(pCC2);
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
            Habilitar();
        	
        }
        
        void BtnBuscarClick(object sender, EventArgs e)
        {
            Buscar_CR buscar2 = new Buscar_CR();
            buscar2.ShowDialog();

            if (buscar2.CCSelecionado != null)
//CCSelecionado            	
            {
               CCACTUAL2 = buscar2.CCSelecionado;
                textBox1.Text = buscar2.CCSelecionado.nombreComida;
                textBox2.Text = buscar2.CCSelecionado.tipoComida;
                textBox3.Text = buscar2.CCSelecionado.horario;
                textBox4.Text = buscar2.CCSelecionado.costo;

                btnActualizar.Enabled = true;
                button2.Enabled = true;
                Habilitar();
                btnGuardar.Enabled = false;
            }
        }
        
        void Button2Click(object sender, EventArgs e)
        {
        	if (MessageBox.Show("Esta Seguro que desea eliminar", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Buscar_CR_DAL.Eliminar(CCACTUAL2.Id) > 0)
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
        
        void BtnActualizarClick(object sender, EventArgs e)
        {
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {

            Buscar_CR1 pCC = new Buscar_CR1();
            pCC.nombreComida = textBox1.Text.Trim();
            pCC.tipoComida = textBox2.Text.Trim();
            pCC.horario = textBox3.Text.Trim();
            pCC.costo = textBox4.Text.Trim();
            pCC.Id = CCACTUAL2.Id;

            if (Buscar_CR_DAL.Actualizar(pCC) > 0)
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
        
        void Button4Click(object sender, EventArgs e)
        {
        	
        	
            try
            {
                string Query = "select * from paisaapp.comidarapida;";
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
        	Habilitar();
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
