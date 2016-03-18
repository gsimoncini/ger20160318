using System;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tsa_CuentaCorriente.
	/// </summary>
	public class tsa_CuentaCorriente
	{
		public tsa_CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetSaldoAnterior(string IdCuenta, DateTime desde, string comprobantes)
		{
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetSaldoAnterior(IdCuenta, desde, comprobantes);
		}
		public static System.Data.DataSet GetDetalleCuentaCorriente(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string OrderBy, string comprobantes, bool verHTML)
		{
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorriente(IdCuenta, FechaDesde, FechaHasta, comprobantes, OrderBy, verHTML);
		}
		/*Sobrecarga que deberia ser usada cuando el flujo viene desde un ComprobantDePago*/
		public static System.Data.DataSet GetDetalleCuentaCorriente(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string comprobantes)
		{
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorriente(IdCuenta, FechaDesde, FechaHasta, comprobantes);
		}


		public static System.Data.DataSet GetSaldoPosterior(string IdCuenta, DateTime hasta, string comprobantes)
		{
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetSaldoPosterior(IdCuenta, hasta, comprobantes);
		}

		public static void Update(tsa_AplicacionPagosDataset dataAplicacionPago, tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda)
		{
			mz.erp.dataaccess.tsa_CuentaCorriente.Update(dataAplicacionPago,dataDetalleDeuda);
		}
		
		public static System.Data.DataSet GetDetalleCuentaCorrienteVentas(string IdCuenta, long TipoCtaCte)
		{			
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorrienteVentas(IdCuenta, TipoCtaCte);
		}

        //German 20120222 -  Tarea 0000247
        public static System.Data.DataSet GetRemitosSinFacturar(string IdCuenta, long TipoCtaCte, bool ActualizaPrecios)
        {
            return mz.erp.dataaccess.tsa_CuentaCorriente.GetRemitosSinFacturar(IdCuenta, TipoCtaCte, ActualizaPrecios);
        }

        public static System.Data.DataSet GetAcopiosPendientes(string IdCuenta, long TipoCtaCte)
        {
            return mz.erp.dataaccess.tsa_CuentaCorriente.GetAcopiosPendientes(IdCuenta, TipoCtaCte);
        }
        //Fin German 20120222 -  Tarea 0000247
		public static System.Data.DataSet GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte,  string TiposDeComprobantesValidos, bool SoloPendientes, bool SoloPendientesSaldoTemporal)
		{			
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte,  TiposDeComprobantesValidos, SoloPendientes, SoloPendientesSaldoTemporal);
		}
			
		public static System.Data.DataSet GetImputacionesDetalleCuentaCorrienteVentas(string IdTipoComprobante, string IdComprobante,  short Cuota, int Signo)
		{			
			return mz.erp.dataaccess.tsa_CuentaCorriente.GetImputacionesDetalleCuentaCorrienteVentas(IdTipoComprobante, IdComprobante,  Cuota, Signo);
		}
	}
}
