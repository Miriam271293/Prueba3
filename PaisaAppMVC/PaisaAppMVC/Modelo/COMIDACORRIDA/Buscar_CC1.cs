/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisaAppMVC.Modelo.COMIDACORRIDA
{
	
	public class Buscar_CC1{
		public int Id { get; set; }
        public string nombreComida { get; set; }
        public string tipoGuisado { get; set; }
        public string horario { get; set; }
        public string costo { get; set; }
	
		public Buscar_CC1()
		{}
		 public Buscar_CC1 (int pId, string pnombreComida , string ptipoGuisado, string phorario, string pcosto)
        {
            this.Id = pId;
            this.nombreComida = pnombreComida;
            this.tipoGuisado = ptipoGuisado;
            this.horario = phorario;
            this.costo = pcosto;
        }
		
	}
}
