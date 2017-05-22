/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
//namespace WindowsFormsApplication1
namespace PaisaAppMVC.Modelo.BEBIDAS
{
	public class Buscar_B1
	{
		public int Id { get; set; }
        public string nombreBebida { get; set; }
        public string tipoBebida { get; set; }
        public string horario { get; set; }
        public string costo { get; set; }
		
		public Buscar_B1(){}
		 public Buscar_B1(int pId, string pnombreBebida , string ptipoBebida, string phorario, string pcosto)
        {
            this.Id = pId;
            this.nombreBebida = pnombreBebida;
            this.tipoBebida = ptipoBebida;
            this.horario = phorario;
            this.costo = pcosto;
        }
		
		
	}
}
