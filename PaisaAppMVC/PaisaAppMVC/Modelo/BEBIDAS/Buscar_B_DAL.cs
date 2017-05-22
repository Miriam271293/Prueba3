/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PaisaAppMVC.Conexion;

	//namespace WindowsFormsApplication1;

//namespace PaisaAppMVC.Modelo.BEBIDAS
namespace PaisaAppMVC.Modelo.BEBIDAS
{
	public class Buscar_B_DAL
	{
		public Buscar_B_DAL() {}
		
		 public static int Agregar(Buscar_B1 pBuscar_B1)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into bebidas (nombreBebida, tipoBebida, horario, costo) values ('{0}','{1}','{2}', '{3}')",
            pBuscar_B1.nombreBebida, pBuscar_B1.tipoBebida,pBuscar_B1.horario, pBuscar_B1.costo), ConexionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
            
      
            
            
        }


		 
	
		
		
		//FIN AGREGAR
		
		//HASTA AQUI
		//BUSCAR
		  public static List<Buscar_B1> Buscar(string pId)
        {
            List<Buscar_B1> _lista = new List<Buscar_B1>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT  	idBebidas,nombreBebida,tipoBebida, horario, costo FROM bebidas WHERE idBebidas='{0}'", pId), ConexionBD.ObtenerConexion());
            
     
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Buscar_B1 pBuscar_B1 = new Buscar_B1();
                pBuscar_B1.Id = _reader.GetInt32(0);
                pBuscar_B1.nombreBebida = _reader.GetString(1);
                pBuscar_B1.tipoBebida = _reader.GetString(2);
                pBuscar_B1.horario = _reader.GetString(3);
                pBuscar_B1.costo = _reader.GetString(4);


                _lista.Add(pBuscar_B1);
            }

            return _lista;
        }

		  //FIN BUSCAR
		  
		  
		  //OBTENER id
		  
		          public static Buscar_B1 ObtenerBuscar_B1(int pId)
        {
           Buscar_B1 pBuscar_B1 = new Buscar_B1();
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  	idBebidas,nombreBebida,tipoBebida, horario, costo FROM bebidas WHERE idBebidas='{0}'", pId), ConexionBD.ObtenerConexion());
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pBuscar_B1.Id = _reader.GetInt32(0);
                pBuscar_B1.nombreBebida = _reader.GetString(1);
                pBuscar_B1.tipoBebida = _reader.GetString(2);
                pBuscar_B1.horario = _reader.GetString(3);
                pBuscar_B1.costo = _reader.GetString(4);
            }

            conexion.Close();
            return pBuscar_B1;

        }
		  
		  //FIN OBTENER id

		  //INCIA ACTUALIZR
		  
		  public static int Actualizar(Buscar_B1 pBuscar_B1)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update bebidas set nombreBebida='{0}', tipoBebida='{1}', horario='{2}', costo='{3}' where idBebidas={4}",
            pBuscar_B1.nombreBebida, pBuscar_B1.tipoBebida,pBuscar_B1.horario, pBuscar_B1.costo,pBuscar_B1.Id), conexion);
                                                                  
                                                                

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
		  
		  
		  //FIN ACTUALIZAR
		  
		  //INICIA ELIMINAR
		  
		          public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From bebidas where idBebidas={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
	}
}
