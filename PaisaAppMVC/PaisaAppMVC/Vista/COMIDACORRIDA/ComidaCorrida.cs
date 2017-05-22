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
using PaisaAppMVC.Modelo.COMIDACORRIDA;
using PaisaAppMVC.Conexion;


namespace	PaisaAppMVC.Vista.COMIDACORRIDA
{
    public partial class FrmComidaCorrida : Form
    {
        public FrmComidaCorrida()
        {
            InitializeComponent();
        }
        ConexionBD bd = new ConexionBD();
          public Buscar_CC1 CCACTUAL { get; set; }

         
        private void button5_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Altas 
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
                string Query = "insert into paisaapp.comidacorrida( nombreComida,tipoGuisado,horario,costo) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";
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
            /*
            ConsultasCC TodosEmpleados = new ConsultasCC();
            TodosEmpleados.MdiParent = this;
            TodosEmpleados.Show();
            */

            try
            {
                string Query = "select * from paisaapp.comidacorrida;";
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

        private void label6_Click(object sender, EventArgs e)
        {
       


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//eliminar
        {


            MySqlConnection MyConnEliminar = ConexionBD.ObtenerConexion();
           
           /* MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM comidacorrida WHERE comidacorrida.idComidaCorrida='" + txtBoxIngresarId + "'", MyConn2);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                MySqlConnection MyConn3 = ConexionBD.ObtenerConexion();
                try
                {
                    //string Query2 = "UPDATE comidacorrida SET comidacorrida.status = 0 WHERE idComidaCorrida='" + txtBoxIngresarId.Text + "' ;";

                    //string Query = "insert into paisaapp.( nombrePostre,tipoPostre,horario,costo) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";

                    string Query2 = "DELETE FROM comidacorrida WHERE idComidaCorrida='" + txtBoxIngresarId.Text + "' ;";

                    //Delete From clientes where IdCliente={0}
                    MySqlCommand MyCommand2 = new MySqlCommand(Query2, MyConn3);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();
                    lblError.Text = "Cancelada con exito";
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    lblError.Text = "Error desconocido";
                    MessageBox.Show(ex.Message);
                }
            }
            else
                lblError.Text = "No se encontro el registro";

            */
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmComidaCorrida_Load(object sender, EventArgs e)
        {
            
        }
        
        void BtnNuevoClick(object sender, EventArgs e)
        {
        	 Limpiar();
            Habilitar();
        	
        }
        
        public void BtnGuardarClick(object sender, EventArgs e)
        {
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {
                Buscar_CC1 pCC = new Buscar_CC1();
                pCC.nombreComida = textBox1.Text.Trim();
                pCC.tipoGuisado = textBox2.Text.Trim();
                pCC.horario = textBox3.Text.Trim();
              	pCC.costo = textBox4.Text.Trim();

                int resultado = Buscar_CC_DAL.Agregar(pCC);
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
        
      public  void BtnBuscarClick(object sender, EventArgs e)
        {
        	
        	Buscar_CC buscar = new Buscar_CC();
            buscar.ShowDialog();

            if (buscar.CCSelecionado != null)
//CCSelecionado            	
            {
                CCACTUAL = buscar.CCSelecionado;
                textBox1.Text = buscar.CCSelecionado.nombreComida;
                textBox2.Text = buscar.CCSelecionado.tipoGuisado;
                textBox3.Text = buscar.CCSelecionado.horario;
                textBox4.Text = buscar.CCSelecionado.costo;

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
                if (Buscar_CC_DAL.Eliminar(CCACTUAL.Id) > 0)
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
        
        void Button5Click(object sender, EventArgs e)
        {
        	
        	
        }
        
        void BtnActualizarClick(object sender, EventArgs e)
        {
        	
        	if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        	    string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {

            Buscar_CC1 pCC = new Buscar_CC1();
            pCC.nombreComida = textBox1.Text.Trim();
            pCC.tipoGuisado = textBox2.Text.Trim();
            pCC.horario = textBox3.Text.Trim();
            pCC.costo = textBox4.Text.Trim();
            pCC.Id = CCACTUAL.Id;

            if (Buscar_CC_DAL.Actualizar(pCC) > 0)
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
                string Query = "select * from paisaapp.comidacorrida;";
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

      
        
        
        void PictureBox4Click(object sender, EventArgs e)
        {
        	
        }
    }
}
