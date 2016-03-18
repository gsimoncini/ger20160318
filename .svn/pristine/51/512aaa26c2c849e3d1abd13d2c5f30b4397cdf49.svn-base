using System;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tpu_CuentaCorriente.
	/// </summary>
	public class tpu_CuentaCorriente
	{
		public tpu_CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetImputacionesDetalleCuentaCorrienteCompras(string IdTipoComprobante, string IdComprobante,  short Cuota, int Signo)
		{			
			return mz.erp.dataaccess.tpu_CuentaCorriente.GetImputacionesDetalleCuentaCorrienteCompras(IdTipoComprobante, IdComprobante,  Cuota, Signo);
		}

		public static System.Data.DataSet GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte,  string TiposDeComprobantesValidos, bool SoloPendientes, bool SoloPendientesSaldoTemporal)
		{			
			return mz.erp.dataaccess.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte,  TiposDeComprobantesValidos, SoloPendientes, SoloPendientesSaldoTemporal);
		}

		public static System.Data.DataSet GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte)
		{			
			return mz.erp.dataaccess.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte);
		}
	}
}
