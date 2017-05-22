/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:37 a. m.
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

namespace PaisaAppMVC.Modelo.COMIDARAPIDA
{
	public class Buscar_CR_DAL
	{
		public Buscar_CR_DAL(){}
		
		 public static int Agregar(Buscar_CR1 pBuscar_CR1)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into comidarapida (nombreComida, tipoComida, horario, costo) values ('{0}','{1}','{2}', '{3}')",
            pBuscar_CR1.nombreComida, pBuscar_CR1.tipoComida,pBuscar_CR1.horario, pBuscar_CR1.costo), ConexionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
            
      
            
            
        }


		 
	
		
		
		//FIN AGREGAR
		
		
		//BUSCAR
		  public static List<Buscar_CR1> Buscar(string pId)
        {
            List<Buscar_CR1> _lista = new List<Buscar_CR1>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT  	idComidaRapida,nombreComida,tipoComida, horario, costo FROM comidarapida WHERE idComidaRapida='{0}'", pId), ConexionBD.ObtenerConexion());
            
     
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Buscar_CR1 pBuscar_CR1 = new Buscar_CR1();
                pBuscar_CR1.Id = _reader.GetInt32(0);
                pBuscar_CR1.nombreComida = _reader.GetString(1);
                pBuscar_CR1.tipoComida = _reader.GetString(2);
                pBuscar_CR1.horario = _reader.GetString(3);
                pBuscar_CR1.costo = _reader.GetString(4);


                _lista.Add(pBuscar_CR1);
            }

            return _lista;
        }

		  //FIN BUSCAR
		  
		  
		  //OBTENER id
		  
		          public static Buscar_CR1 ObtenerBuscar_CR1(int pId)
        {
           Buscar_CR1 pBuscar_CR1 = new Buscar_CR1();
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  	idComidaRapida,nombreComida,tipoComida, horario, costo FROM comidarapida WHERE idComidaRapida='{0}'", pId), ConexionBD.ObtenerConexion());
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pBuscar_CR1.Id = _reader.GetInt32(0);
                pBuscar_CR1.nombreComida = _reader.GetString(1);
                pBuscar_CR1.tipoComida = _reader.GetString(2);
                pBuscar_CR1.horario = _reader.GetString(3);
                pBuscar_CR1.costo = _reader.GetString(4);
            }

            conexion.Close();
            return pBuscar_CR1;

        }
		  
		  //FIN OBTENER id

		  //INCIA ACTUALIZR
		  
		  public static int Actualizar(Buscar_CR1 pBuscar_CR1)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionBD.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update comidarapida set nombreComida='{0}', tipoComida='{1}', horario='{2}', costo='{3}' where idComidaRapida={4}",
            pBuscar_CR1.nombreComida, pBuscar_CR1.tipoComida,pBuscar_CR1.horario, pBuscar_CR1.costo,pBuscar_CR1.Id), conexion);
                                                                  
                                                                

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

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From comidacorrida where idComidaRapida={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
		  
		  
		  //FIN ELIMINAR
	}
}
