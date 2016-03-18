using System;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripci�n breve de GenerarListadoFacturasImpagas.
	/// </summary>
	public class GenerarListadoFacturasImpagas
	{
		#region Variables Privadas
		private static GenerarListadoFacturasImpagas instance = null;
		#endregion

		#region Constructores y Destructores
		private GenerarListadoFacturasImpagas()
		{
		}
		#endregion

		#region M�todos Publicos

		public static GenerarListadoFacturasImpagas GetInstance()
		{
			if(instance == null)
				instance = new GenerarListadoFacturasImpagas();
			return instance;
		}

		public void GeneraListadoFacturasImpagas()
		{
			tsa_FacturasImpagas.GenerarListadoFacturasImpagas();
		}

		#endregion

		#region M�todos Privados
		#endregion	
	}
}
