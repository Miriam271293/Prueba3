﻿/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace PaisaAppMVC.Modelo.COMIDARAPIDA
{

	public class Buscar_CR1
	{
		public int Id { get; set; }
        public string nombreComida { get; set; }
        public string tipoComida { get; set; }
        public string horario { get; set; }
        public string costo { get; set; }
		public Buscar_CR1() {}
		
		 public Buscar_CR1(int pId, string pnombreComida , string ptipoComida, string phorario, string pcosto)
        {
            this.Id = pId;
            this.nombreComida = pnombreComida;
            this.tipoComida = ptipoComida;
            this.horario = phorario;
            this.costo = pcosto;
        }
	}
}
