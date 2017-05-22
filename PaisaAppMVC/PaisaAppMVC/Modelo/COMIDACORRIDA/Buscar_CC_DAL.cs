/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:36 a. m.
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
namespace PaisaAppMVC.Modelo.COMIDACORRIDA
{
	/// <summary>
	/// Description of Buscar_CC_DAL.
	/// </summary>
	public class Buscar_CC_DAL
	{
		public Buscar_CC_DAL(){}
		
		
		 public static int Agregar(Buscar_CC1 pBuscar_CC1)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into comidacorrida (nombreComida, tipoGuisado, horario, costo) values ('{0}','{1}','{2}', '{3}')",
            pBuscar_CC1.nombreComida, pBuscar_CC1.tipoGuisado,pBuscar_CC1.horario, pBuscar_CC1.costo), ConexionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
            
      
            
            
        }


		 
	
		
		
		//FIN AGREGAR
		
		
		//BUSCAR
		  public static List<Buscar_CC1> Buscar(string pId)
        {
            List<Buscar_CC1> _lista = new List<Buscar_CC1>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT  	idComidaCorrida,nombreComida,tipoGuisado, horario, costo FROM comidacorrida WHERE idComidaCorrida='{0}'", pId), ConexionBD.ObtenerConexion());
            
     
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Buscar_CC1 pBuscar_CC1 = new Buscar_CC1();
                pBuscar_CC1.Id = _reader.GetInt32(0);
                pBuscar_CC1.nombreComida = _reader.GetString(1);
                pBuscar_CC1.tipoGuisado = _reader.GetString(2);
                pBuscar_CC1.horario = _reader.GetString(3);
                pBuscar_CC1.costo = _reader.GetString(4);


                _lista.Add(pBuscar_CC1);
            }

            return _lista;
        }

		  //FIN BUSCAR
		  
		  
		  //OBTENER id
		  
		          public static Buscar_CC1 ObtenerBuscar_CC1(int pId)
        {
           Buscar_CC1 pBuscar_CC1 = new Buscar_CC1();
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  	idComidaCorrida,nombreComida,tipoGuisado, horario, costo FROM comidacorrida WHERE idComidaCorrida='{0}'", pId), ConexionBD.ObtenerConexion());
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pBuscar_CC1.Id = _reader.GetInt32(0);
                pBuscar_CC1.nombreComida = _reader.GetString(1);
                pBuscar_CC1.tipoGuisado = _reader.GetString(2);
                pBuscar_CC1.horario = _reader.GetString(3);
                pBuscar_CC1.costo = _reader.GetString(4);
            }

            conexion.Close();
            return pBuscar_CC1;

        }
		  
		  //FIN OBTENER id

		  //INCIA ACTUALIZR
		  
		  public static int Actualizar(Buscar_CC1 pBuscar_CC1)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update comidacorrida set nombreComida='{0}', tipoGuisado='{1}', horario='{2}', costo='{3}' where idComidaCorrida={4}",
            pBuscar_CC1.nombreComida, pBuscar_CC1.tipoGuisado,pBuscar_CC1.horario, pBuscar_CC1.costo,pBuscar_CC1.Id), conexion);
                                                                  
                                                                

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

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From comidacorrida where idComidaCorrida={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
		  
		  
		  //FIN ELIMINAR
		
	}
}
