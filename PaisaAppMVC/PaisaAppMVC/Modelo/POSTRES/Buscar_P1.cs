/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:39 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace PaisaAppMVC.Modelo.POSTRES
{
	public class Buscar_P1
	{
		public int Id { get; set; }
        public string nombrePostre { get; set; }
        public string tipoPostre { get; set; }
        public string horario { get; set; }
        public string costo { get; set; }
		public Buscar_P1(){
		
		}
		
        public Buscar_P1(int pId, string pnombrePostre , string ptipoPostre, string phorario, string pcosto)
        {
            this.Id = pId;
            this.nombrePostre = pnombrePostre;
            this.tipoPostre = ptipoPostre;
            this.horario = phorario;
            this.costo = pcosto;
        }
        
	}
}
