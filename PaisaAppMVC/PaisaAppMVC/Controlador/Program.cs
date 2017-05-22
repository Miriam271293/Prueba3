/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 09/05/2017
 * Hora: 11:50 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PaisaAppMVC.Vista;
using WindowsFormsApplication1;

namespace PaisaAppMVC
{
	
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            

            
            
            
            
            
		}
		
	}
}
