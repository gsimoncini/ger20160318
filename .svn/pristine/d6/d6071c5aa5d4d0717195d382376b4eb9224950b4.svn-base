using System;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de GridConfigurationLoader.
	/// </summary>
	public class GridConfigurationLoader
	{
		#region Constructores

		public GridConfigurationLoader()
		{
			
		}

		#endregion

		#region variables privadas

			
			

		#endregion

		#region Metodos Publicos
		
		public Hashtable LoadConfiguration(string GridName, long IdProceso, long IdTarea)
		{
			return mz.erp.businessrules.GridConfigurationLoader.LoadConfiguration(GridName, IdProceso, IdTarea, null);
		}
		public Hashtable LoadConfiguration(string GridName, long IdProceso, long IdTarea, string Formulario)
		{
			return mz.erp.businessrules.GridConfigurationLoader.LoadConfiguration(GridName, IdProceso, IdTarea, Formulario);
		}
		#endregion
	}
}
