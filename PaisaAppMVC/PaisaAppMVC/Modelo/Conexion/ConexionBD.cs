using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PaisaAppMVC.Conexion
{
   public class ConexionBD
    {
       public static MySqlConnection ObtenerConexion()
       {
           MySqlConnection conectar = new MySqlConnection("server=localhost; database=paisaapp; Uid=jazmin; pwd=1234;");//server=127.0.0.1

           conectar.Open();
           return conectar;
       }
    }
}
