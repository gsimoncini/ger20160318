using System;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de CancelacionComprobanteDePago.
	/// </summary>
	public class CancelacionComprobanteDePago: CancelacionComprobante
	{
		private tsa_ComprobantesExDataset _dataComprobante;

		public tsa_ComprobantesExDataset DataComprobante
		{
			get
			{
				return _dataComprobante;
			}
		}

		public CancelacionComprobanteDePago()
		{
			_dataComprobante = new tsa_ComprobantesExDataset();
		}

		public void Anular(string IdComprobante)
		{
			this.IdComprobante = IdComprobante;
			
		

		}

		public override void Commit()
		{
			base.Commit ();
			tsa_ComprobantesDataset.tsa_ComprobantesRow row = mz.erp.businessrules.tsa_Comprobantes.GetByPk(IdComprobante);
			//Agrego el comprobante anulado a la tabla de tsa_Comprobantes para evitar problemas de Foreign key
			_dataComprobante.tsa_Comprobantes.ImportRow(row);
			string IdTipoComprobante = row.IdTipoDeComprobante;
			
			//Creo el nuevo comprobante de Anulacion que es similar al comprobante anulado
			tsa_ComprobantesExDataset.tsa_ComprobantesRow rowComprobante = _dataComprobante.tsa_Comprobantes.Newtsa_ComprobantesRow();
			rowComprobante.IdComprobante = mz.erp.systemframework.Util.NewStringId();
			rowComprobante.Numero = row.Numero;
			rowComprobante.IdTipoDeComprobante = Variables.GetValueString("Momentos.Anular.Comprobantes." + IdTipoComprobante);
			rowComprobante.IdInstanciaCaja = row.IdInstanciaCaja;
			rowComprobante.IdCuenta = row.IdCuenta;
			rowComprobante.IdResponsable = row.IdResponsable;
			rowComprobante.Total = row.Total;
			rowComprobante.IdMonedaCierre = row.IdMonedaCierre;
			rowComprobante.IdCotizacionCierre = row.IdCotizacionCierre;
			rowComprobante.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			rowComprobante.IdConexionCreacion = Security.IdConexion;
			//rowComprobante.UltimaModificacion = null;
			rowComprobante.IdConexionUltimaModificacion = Security.IdConexion;
			rowComprobante.IdReservado = 0;
			rowComprobante.RowId = Guid.Empty;
			rowComprobante.IdEmpresa = Security.IdEmpresa;
			rowComprobante.IdSucursal = Security.IdSucursal;

			_dataComprobante.tsa_Comprobantes.Addtsa_ComprobantesRow(rowComprobante);

			
			
			//Recupera los valores relacionados con el comprobante de pago a anular
			tsa_ComprobanteDetalleDePagosDataset dataDetalleDePagos = mz.erp.businessrules.tsa_ComprobanteDetalleDePagos.GetList(null,null,this.IdComprobante,null,decimal.MinValue);
			
			foreach(tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow rowDetalleDePagos in dataDetalleDePagos.tsa_ComprobanteDetalleDePagos.Rows)
			{
				_dataComprobante.tfi_Valores.LoadDataRow(mz.erp.businessrules.tfi_Valores.GetByPk(rowDetalleDePagos.IdValor).ItemArray,true);
				tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDePagosRow rowDP = _dataComprobante.tsa_ComprobanteDetalleDePagos.Newtsa_ComprobanteDetalleDePagosRow();
				rowDP.IdComprobante = rowComprobante.IdComprobante; 
				rowDP.IdValor = rowDetalleDePagos.IdValor; 
				rowDP.IdTipoDeComprobante = rowComprobante.IdTipoDeComprobante;
				rowDP.Numero = rowComprobante.Numero;
				rowDP.Monto = rowComprobante.Total;
				rowDP.IdMoneda = rowComprobante.IdMonedaCierre;
				rowDP.IdCotizaicon = rowComprobante.IdCotizacionCierre;
				rowDP.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				rowDP.IdConexionCreacion = Security.IdConexion;
				//rowDP.UltimaModificacion = null;
				rowDP.IdConexionUltimaModificacion = Security.IdConexion;
				rowDP.IdReservado = 0;
				rowDP.RowId = Guid.Empty;
				rowDP.IdSucursal = Security.IdSucursal;
				rowDP.IdEmpresa = Security.IdEmpresa;
				_dataComprobante.tsa_ComprobanteDetalleDePagos.Addtsa_ComprobanteDetalleDePagosRow(rowDP);
			}

			//Recuperar de detalle de deuda las filas relacionadas con el comprobante a anular
			tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetList(row.IdComprobante,row.IdTipoDeComprobante,row.Numero);
			
	
			
			//Crear una nueva fila en detalle de deuda para el comprobante de anulacion
			int signo =  Convert.ToInt32( mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(rowComprobante.IdTipoDeComprobante).signo);
			tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDeudaRow rowDetalleDeuda = _dataComprobante.tsa_ComprobanteDetalleDeuda.Newtsa_ComprobanteDetalleDeudaRow();
			rowDetalleDeuda.IdComprobante = rowComprobante.IdComprobante; 
			rowDetalleDeuda.Cuota = 1; 
			rowDetalleDeuda.IdTipoDeComprobante = rowComprobante.IdTipoDeComprobante;
			rowDetalleDeuda.Numero = rowComprobante.Numero;
			rowDetalleDeuda.FechaEmision = mz.erp.businessrules.Sistema.DateTime.Now;
			rowDetalleDeuda.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			rowDetalleDeuda.Importe = rowComprobante.Total * signo;
			rowDetalleDeuda.Saldo = 0;
			rowDetalleDeuda.IdMonedaCierre = string.Empty;
			rowDetalleDeuda.IdCotizacionCierre = string.Empty;
			rowDetalleDeuda.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			rowDetalleDeuda.IdConexionCreacion = Security.IdConexion;
			//rowDetalleDeuda.UltimaModificacion = null;
			rowDetalleDeuda.IdConexionUltimaModificacion = Security.IdConexion;
			rowDetalleDeuda.IdReservado = 0;
			rowDetalleDeuda.RowId = Guid.Empty;
			rowDetalleDeuda.IdSucursal = Security.IdSucursal;
			rowDetalleDeuda.IdEmpresa = Security.IdEmpresa;
			
			_dataComprobante.tsa_ComprobanteDetalleDeuda.Addtsa_ComprobanteDetalleDeudaRow(rowDetalleDeuda);
			
			//Asociar en tsa_AplicaciondePagos el comprobante anulado con el comprobante que lo anula
			//el comprobante de pago anulado va como destino y el comrpobante que anula va como origen
			foreach(tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDD in dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.Rows)
			{
				tsa_ComprobantesExDataset.tsa_AplicacionPagosRow rowAplicacionPago = _dataComprobante.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
				rowAplicacionPago.IdComprobanteOrigen = rowDetalleDeuda.IdComprobante; 
				rowAplicacionPago.CuotaOrigen = rowDetalleDeuda.Cuota; 
				rowAplicacionPago.IdComprobanteDestino = rowDD.IdComprobante; 
				rowAplicacionPago.IdTipoComprobanteOrigen = rowDetalleDeuda.IdTipoDeComprobante;
				rowAplicacionPago.Importe = rowDD.Importe;
				rowAplicacionPago.IdTipoDeComprobanteDestino = rowDD.IdTipoDeComprobante;
				rowAplicacionPago.CuotaDestino = rowDD.Cuota;
				rowAplicacionPago.IdEmpresa = Security.IdEmpresa;
				rowAplicacionPago.IdSucursal = Security.IdSucursal;
				rowAplicacionPago.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				rowAplicacionPago.IdConexionCreacion = Security.IdConexion;
				//rowAplicacionPago.UltimaModificacion = null;
				rowAplicacionPago.IdConexionUltimaModificacion = Security.IdConexion;
				rowAplicacionPago.IdReservado = 0;
				rowAplicacionPago.RowId = Guid.Empty;
				_dataComprobante.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(rowAplicacionPago);
				//Actualizo el saldo del comprobante anulado, lo ponemos en 0
				rowDD.Saldo=0;
				_dataComprobante.tsa_ComprobanteDetalleDeuda.ImportRow(rowDD);


			}
			


		}

		public override void Flush()
		{
			base.Flush ();
			mz.erp.businessrules.tsa_ComprobantesEx.UpdateComprobanteDePago(_dataComprobante,false);

		}

		public bool IsValid()
		{
			return true;
	
		}






	}
}
