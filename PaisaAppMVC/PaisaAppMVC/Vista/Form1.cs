using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using PaisaAppMVC.Conexion;
using PaisaAppMVC.Vista;

namespace WindowsFormsApplication1
//namespace PaisaAppMVC.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ConexionBD.ObtenerConexion();
        }

        private void Salir1_Click(object sender, EventArgs e) //boton salir
        {
            MessageBox.Show("Cerrando aplicación", "PaisaApp");
            this.Close();  //Cerrando ventada 
            Application.Exit();  //finalizando toda ejecucion
        }

        private void Invitado_Click(object sender, EventArgs e)
        {
            /*
            Menu mnu2 = new Menu();  //creando el objeto mnu2 
            mnu2.Show();   //entra al form menu invitado
            this.Hide();   //oculta form
             */
            MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarioInvitado WHERE usuario='" + usuarioBox.Text + "'AND contrasena='" + contraseñaBox.Text + "' ", MyConn2);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string usuario = leer.GetString("idempleado");
                string Query = "UPDATE datosempresa SET datosempresa.usuario='" + usuario + "' WHERE datosempresa.idempresa=1;";
                leer.Close();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();

                Menu inicio = new Menu();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valida", "PaisaApp");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn2 = ConexionBD.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarioInvitado WHERE usuario='" + usuarioBox.Text + "'AND contrasena='" + contraseñaBox.Text + "' ", MyConn2);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string usuario = leer.GetString("idempleado");
                string Query = "UPDATE datosempresa SET datosempresa.usuario='" + usuario + "' WHERE datosempresa.idempresa=1;";
                leer.Close();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();

                Menu inicio = new Menu();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valida", "PaisaApp");
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
