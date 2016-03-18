// Modelo estático
using System;

namespace mz.erp.businessrules.comprobantes
{
	public class Factura: ComprobanteDeVenta
	{
		public Factura( string idCuenta, System.DateTime fecha, string idResponsable, string idCondicionDeVenta )
		{
			new ComprobanteDeVenta( "NEW", "Vender", idCuenta, fecha, idResponsable, idCondicionDeVenta);
			this.Signo = 1;
		}
		public Factura( string idComprobante )
		{
			new ComprobanteDeVenta( "EDIT", idComprobante, null);
			this.Signo = 1;
		}
	}
}