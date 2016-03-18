using System;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de OpcionDeMenu.
	/// </summary>
	public class OpcionDeMenu
	{
		public OpcionDeMenu()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Update(string OpcionPadre, string Opcion, string Titulo, string Perfiles) 
		{
			int BarraHerramienta = 1;
			dataaccess.OpcionDeMenu.Update(OpcionPadre, Opcion, Titulo, Perfiles, BarraHerramienta);
		}
	}
}
