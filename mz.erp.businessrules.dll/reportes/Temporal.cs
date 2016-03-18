using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de Temporal.
	/// </summary>
	public class Temporal
	{
		public Temporal()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void ActualizarConsolidadoCheques()  
		{
			dataaccess.reportes.Temporal.ActualizarConsolidadoCheques();
		}
		public static void ActualizarConsolidadoTarjetas()  
		{
			dataaccess.reportes.Temporal.ActualizarConsolidadoTarjetas();
		}
	}
}
