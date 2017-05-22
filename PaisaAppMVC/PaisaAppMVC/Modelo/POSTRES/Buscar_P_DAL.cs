/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:40 a. m.
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

namespace PaisaAppMVC.Modelo.POSTRES
{
	public class Buscar_P_DAL
	{
		public Buscar_P_DAL()
		{
		}
		
		 public static int Agregar(Buscar_P1 pBuscar_P1)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into postres (nombrePostre, tipoPostre, horario, costo) values ('{0}','{1}','{2}', '{3}')",
            pBuscar_P1.nombrePostre, pBuscar_P1.tipoPostre,pBuscar_P1.horario, pBuscar_P1.costo), ConexionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
            
      
            
            
        }


		 
	
		
		
		//FIN AGREGAR
		
		
		//BUSCAR
		  public static List<Buscar_P1> Buscar(string pId)
        {
            List<Buscar_P1> _lista = new List<Buscar_P1>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT  	idPostres,nombrePostre,tipoPostre, horario, costo FROM postres WHERE idPostres='{0}'", pId), ConexionBD.ObtenerConexion());
            
     
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Buscar_P1 pBuscar_P1 = new Buscar_P1();
                pBuscar_P1.Id = _reader.GetInt32(0);
                pBuscar_P1.nombrePostre = _reader.GetString(1);
                pBuscar_P1.tipoPostre = _reader.GetString(2);
                pBuscar_P1.horario = _reader.GetString(3);
                pBuscar_P1.costo = _reader.GetString(4);


                _lista.Add(pBuscar_P1);
            }

            return _lista;
        }

		  //FIN BUSCAR
		  
		  
		  //OBTENER id
		  
		          public static Buscar_P1 ObtenerBuscar_P1(int pId)
        {
           Buscar_P1 pBuscar_P1 = new Buscar_P1();
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  	idPostres,nombrePostre,tipoPostre, horario, costo FROM postres WHERE idPostres='{0}'", pId), ConexionBD.ObtenerConexion());
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pBuscar_P1.Id = _reader.GetInt32(0);
                pBuscar_P1.nombrePostre = _reader.GetString(1);
                pBuscar_P1.tipoPostre = _reader.GetString(2);
                pBuscar_P1.horario = _reader.GetString(3);
                pBuscar_P1.costo = _reader.GetString(4);
            }

            conexion.Close();
            return pBuscar_P1;

        }
		  
		  //FIN OBTENER id

		  //INCIA ACTUALIZR
		  
		  public static int Actualizar(Buscar_P1 pBuscar_P1)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update postres set nombrePostre='{0}', tipoPostre='{1}', horario='{2}', costo='{3}' where idPostres={4}",
            pBuscar_P1.nombrePostre, pBuscar_P1.tipoPostre,pBuscar_P1.horario, pBuscar_P1.costo,pBuscar_P1.Id), conexion);
                                                                  
                                                                

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

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From postres where idPostres={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
		
		
	}
}
