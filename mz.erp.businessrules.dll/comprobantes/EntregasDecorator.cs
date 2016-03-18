using System;
using mz.erp.businessrules.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de EntregasDecorator.
	/// </summary>
	abstract class EntregasDecorator: ComprobanteDeVenta
	{
		protected ComprobanteDeVenta cdv = null;
		public EntregasDecorator(): base()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public bool Commit() 
		{			
			return cdv.Commit();
		}
	}
}
