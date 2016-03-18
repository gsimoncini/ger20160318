using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.businessrules;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tsa_Comprobantes.
	/// </summary>
	public class tsa_ComprobantesEx
	{
		public tsa_ComprobantesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		/// <summary>
		/// Deprecated
		/// </summary>
		/// <param name="data"></param>
		/// <param name="IdComprobante"></param>
		/// <param name="IdTipoComprobante"></param>
		/// <param name="Numero"></param>
		/// <param name="fecha"></param>
		/// <param name="cuotas"></param>
		/// <param name="IdMoneda"></param>
		/// <param name="IdCotizacionCierre"></param>
		/// <returns></returns>
		public static tsa_ComprobantesExDataset SetDetalleDeuda(tsa_ComprobantesExDataset data,
			string IdComprobante, string IdTipoComprobante, string Numero, DateTime fecha,
			System.Collections.ICollection cuotas, string IdMoneda, string IdCotizacionCierre)
		{
		/*	foreach (DetalleCuotas dc in cuotas)
			{
				System.Data.DataRow row= mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.NewRow(data, IdComprobante);
				row["IdTipoDeComprobante"]= IdTipoComprobante;
				row["Numero"]= Numero;
				row["FechaEmision"]= fecha;
				row["Cuota"]= dc.GetIdCuota();
				row["FechaVencimiento"]= dc.GetFechaVencimiento();
				row["Importe"]= dc.GetMonto();
				row["Saldo"]= dc.GetMonto();
				row["IdMonedaCierre"]= IdMoneda;
				row["IdCotizacionCierre"]= IdCotizacionCierre;
				data.tsa_ComprobanteDetalleDeuda.Rows.Add(row);

			}
		*/


			return data;
		}
		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow NewRow(tsa_ComprobantesExDataset data)
		{
			return mz.erp.dataaccess.tsa_ComprobantesEx.NewRow(data);
		}

		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow NewRow()
		{
			return mz.erp.dataaccess.tsa_ComprobantesEx.NewRow();
		}
		
		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow SetRowComprobantesDefaultValues( tsa_ComprobantesExDataset.tsa_ComprobantesRow row )
		{
			return (tsa_ComprobantesExDataset.tsa_ComprobantesRow)mz.erp.businessrules.tsa_Comprobantes.SetRowDefaultValues( (System.Data.DataRow)row );
		}
				
		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow GetRowComprobantes( tsa_ComprobantesExDataset data )
		{
			if (data.tsa_Comprobantes.Rows.Count > 0)
			{
				return (tsa_ComprobantesExDataset.tsa_ComprobantesRow)data.tsa_Comprobantes.Rows[0];
			}
			else
			{
				return null;
			}
		}
		
		public static System.Data.DataRow GetDataRowComprobantes( System.Data.DataSet data )
		{
			return GetDataRowComprobantes( (tsa_ComprobantesExDataset)data);
		}

		public static System.Data.DataRow GetDataRowComprobantes( tsa_ComprobantesExDataset data )
		{
			if (data.tsa_Comprobantes.Rows.Count > 0)
			{
				return data.tsa_Comprobantes.Rows[0];
			}
			else
			{
				return null;
			}
		}

		public static System.Data.DataSet AddRowComprobantes( tsa_ComprobantesExDataset data, tsa_ComprobantesExDataset.tsa_ComprobantesRow row )
		{
			
			return mz.erp.dataaccess.tsa_ComprobantesEx.AddRowComprobantes(data,row);
		}


	/*	public static tsa_ComprobantesExDataset SetMovimientosDeStock( tsa_ComprobantesExDataset data, long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, string IdMomentoDeStock, string IdEstadoDeStockOrigen, string IdEstadoDeStockDestino, string IdTipoDeAjuste, string IdProducto, decimal Cantidad)
		{
			//tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow	rowDefinicionMovimiento = mz.erp.businessrules.Stock.GetMovimiento(IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdEstadoDeStock, IdTipoDeAjuste, IdProducto, Cantidad);
			tsa_ComprobantesExDataset.tlg_MovimientosDeStockRow rowNuevoMovimiento = data.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();
			
			rowNuevoMovimiento.IdProducto = IdProducto;
			rowNuevoMovimiento.Cantidad = Cantidad;
			rowNuevoMovimiento.IdDeposito = IdDeposito;
			rowNuevoMovimiento.IdSeccion = IdSeccion;

			rowNuevoMovimiento.IdMovimientoDeStock = Util.NewStringId();

			rowNuevoMovimiento.IdEstadoDeStockOrigen = IdEstadoDeStockOrigen;
			rowNuevoMovimiento.IdEstadoDeStockDestino = IdEstadoDeStockDestino;

			rowNuevoMovimiento.IdEmpresa = Security.IdEmpresa;
			rowNuevoMovimiento.IdSucursal = Security.IdSucursal;
			
			rowNuevoMovimiento.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			rowNuevoMovimiento.IdConexionCreacion = Security.IdConexion;
			rowNuevoMovimiento.IdConexionUltimaModificacion = Security.IdConexion;
			rowNuevoMovimiento.IdReservado = 0;

			
			//rowNuevoMovimiento.IdTipoDeAjuste = rowDefinicionMovimiento.IdTipoDeAjuste;
			try 
			{
				data.tlg_MovimientosDeStock.Addtlg_MovimientosDeStockRow( rowNuevoMovimiento );
			}
			catch (Exception e)
			{
				string s = "";
			}
			
			return data;		
		}*/
		/// <summary>
		/// Compone la row para generar los movimientos de relacion con la tabla ComprobantesRelacionOrigenDestino
		/// </summary>
		/// <param name="data"></param>
		/// <param name="IdComprobanteOrigen">
		/// Si el parametro es null inicializa el valor en la row como String(Long.MaxId) para luego reemplazarlo
		/// por el numero de comprobrobante real asignado al realizarse el primer update de la tabla comprobantes
		/// </param>
		/// <param name="IdComprobanteDestino">
		/// Si el parametro es null inicializa el valor en la row como String(Long.MaxId) para luego reemplazarlo
		/// por el numero de comprobrobante real asignado al realizarse el primer update de la tabla comprobantes
		/// </param>
		/// <param name="IdOrdinalOrigen"></param>
		/// <param name="IdOrdinalDestino"></param>
		/// <param name="Cantidad"></param>
		/// <returns></returns>
		public static tsa_ComprobantesExDataset SetRelacionOrigenDestino( tsa_ComprobantesExDataset data, string IdComprobanteOrigen, string IdComprobanteDestino, long IdOrdinalOrigen, long IdOrdinalDestino, decimal Cantidad, bool CierraCircuito)		
		{			
			
			tsa_ComprobantesExDataset.tsa_ComprobantesRelacionOrigenDestinoRow rowEx = data.tsa_ComprobantesRelacionOrigenDestino.Newtsa_ComprobantesRelacionOrigenDestinoRow();
			if (IdComprobanteOrigen != null)
			{
				rowEx.IdComprobanteOrigen = IdComprobanteOrigen;
			}
			else
			{
				rowEx.IdComprobanteOrigen = null;
			}
			if (IdComprobanteDestino != null)
			{
				rowEx.IdComprobanteDestino = IdComprobanteDestino;
			}
			else
			{
				rowEx.IdComprobanteDestino = null;
			}
			rowEx.IdOrdinalOrigen = IdOrdinalOrigen;
			rowEx.IdOrdinalDestino = IdOrdinalDestino;
			rowEx.Cantidad = Cantidad;

			rowEx.IdConexionCreacion = Security.IdConexion;
			rowEx.IdConexionUltimaModificacion = Security.IdConexion;
			rowEx.IdReservado = 0;
			rowEx.IdEmpresa = Security.IdEmpresa;
			rowEx.IdSucursal = Security.IdSucursal;
		
			data.tsa_ComprobantesRelacionOrigenDestino.Addtsa_ComprobantesRelacionOrigenDestinoRow(rowEx);	
			
			if (CierraCircuito)
			{
				rowEx = data.tsa_ComprobantesRelacionOrigenDestino.Newtsa_ComprobantesRelacionOrigenDestinoRow();
				rowEx.IdComprobanteOrigen = IdComprobanteDestino;
				rowEx.IdComprobanteDestino = IdComprobanteDestino;
				rowEx.IdOrdinalOrigen = IdOrdinalDestino;
				rowEx.IdOrdinalDestino = IdOrdinalDestino;

				rowEx.Cantidad = Cantidad;

				rowEx.IdConexionCreacion = Security.IdConexion;
				rowEx.IdConexionUltimaModificacion = Security.IdConexion;
				rowEx.IdReservado = 0;
				rowEx.IdEmpresa = Security.IdEmpresa;
				rowEx.IdSucursal = Security.IdSucursal;
		
				data.tsa_ComprobantesRelacionOrigenDestino.Addtsa_ComprobantesRelacionOrigenDestinoRow(rowEx);	

			}

			return data;
		}

		public static tsa_ComprobantesExDataset GetList( string IdComprobante)
		{
			mz.erp.commontypes.data.tsa_ComprobantesExDataset data = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_Comprobantes.GetByPk( (System.Data.DataSet)data, IdComprobante);
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_ComprobantesDet.GetList( (System.Data.DataSet)data, IdComprobante, DateTime.MinValue, null, null, long.MinValue );
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.GetListDataSet( (System.Data.DataSet)data, IdComprobante, long.MinValue, null);
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetList( (System.Data.DataSet)data, IdComprobante, null, null);
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_ComprobanteDetalleImpuestos.GetList( (System.Data.DataSet)data, IdComprobante, long.MinValue, null);
			data = (tsa_ComprobantesExDataset)mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.GetList( (System.Data.DataSet)data, IdComprobante, null, null);
			return data;
		}

		#region Replication 
		private static SentenciasReplicacion  GenerateReplicaction()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Comprobantes";
			return replication;
			
		}

		#endregion

		public static void UpdateComprobanteDeVentaYComprobanteDePago( tsa_ComprobantesExDataset comprobanteDeVenta, tsa_ComprobantesExDataset comprobanteDePago, bool ActualizaNumeracionVenta, bool ActualizaNumeracionPago, ref string IdComprobanteDeVenta, ref string IdComprobanteDePago )
		{
			string IdVariableVenta;
			string IdVariablePago;
			if (ActualizaNumeracionVenta) 
			{
				IdVariableVenta = UpdateNumero(comprobanteDeVenta);
			}
			else 
			{
				IdVariableVenta = comprobanteDeVenta.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}   

			if (ActualizaNumeracionPago) 
			{
				IdVariablePago = UpdateNumero(comprobanteDePago);
			}
			else 
			{
				IdVariablePago = comprobanteDePago.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}   
			SentenciasReplicacion replicacion = GenerateReplicaction();
			string ComprobantesDeVentas = Variables.GetValueString("Comprobantes.ComprobantesDeVenta");
			mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDeVentaYComprobanteDePago( comprobanteDeVenta, comprobanteDePago, IdVariableVenta, IdVariablePago, ref IdComprobanteDeVenta, ref IdComprobanteDePago,  replicacion, ComprobantesDeVentas);
		}



		public static void UpdateComprobanteDeVentaYComprobanteDePago( tsa_ComprobantesExDataset comprobanteDeVenta, tsa_ComprobantesExDataset comprobanteDePago, bool ActualizaNumeracionVenta, bool ActualizaNumeracionPago, ref string IdComprobanteDeVenta, ref string IdComprobanteDePago,tsa_AplicacionPagosDataset dataAplicacionDePagos , tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda, tsa_ComprobantesExDataset dataComprobanteCancelacion)
		{
			string IdVariableVenta;
			string IdVariablePago;
			if (ActualizaNumeracionVenta) 
			{
				IdVariableVenta = UpdateNumero(comprobanteDeVenta);
			}
			else 
			{
				IdVariableVenta = comprobanteDeVenta.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}   

			if (ActualizaNumeracionPago) 
			{
				IdVariablePago = UpdateNumero(comprobanteDePago);
			}
			else 
			{
				IdVariablePago = comprobanteDePago.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}   
			SentenciasReplicacion replicacion = GenerateReplicaction();
			string ComprobantesDeVentas = Variables.GetValueString("Comprobantes.ComprobantesDeVenta");
			mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDeVentaYComprobanteDePago( comprobanteDeVenta, comprobanteDePago, IdVariableVenta, IdVariablePago, ref IdComprobanteDeVenta, ref IdComprobanteDePago,  replicacion,ComprobantesDeVentas, dataAplicacionDePagos, dataDetalleDeuda, dataComprobanteCancelacion);
		}

		public static void Update(tsa_ComprobantesExDataset data, bool ActualizaNumeracion,ref string  IdComprobante)
		{
			string IdVariable;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(data);
			}
			else 
			{
				IdVariable = data.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}
			SentenciasReplicacion replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsa_ComprobantesEx.Update(data, IdVariable, ref IdComprobante, replicacion);
		}


		public static void Update(tsa_ComprobantesExDataset data, bool ActualizaNumeracion,ref string  IdComprobante,tsa_AplicacionPagosDataset dataAplicacionDePagos , tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda, tsa_ComprobantesExDataset dataComprobanteCancelacion)
		{
			string IdVariable;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(data);
			}
			else 
			{
				IdVariable = data.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}
			SentenciasReplicacion replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsa_ComprobantesEx.Update(data, IdVariable, ref IdComprobante, replicacion, dataAplicacionDePagos, dataDetalleDeuda, dataComprobanteCancelacion);
		}




		public static void UpdateComprobanteDePago(tsa_ComprobantesExDataset data, bool ActualizaNumeracion)
		{
			string IdVariable;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(data);
			}
			else 
			{
				IdVariable = data.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			} 
			SentenciasReplicacion replicacion = GenerateReplicaction();
			string IdComprobanteDePago = null;
			mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDePago(data,ref IdComprobanteDePago, IdVariable, replicacion);
		}

		public static void UpdateTipoDeComprobanteDeVenta(tsa_ComprobantesExDataset data, string IdTransaction)
		{			
			SentenciasReplicacion replicacion = GenerateReplicaction();			
			mz.erp.dataaccess.tsa_ComprobantesEx.UpdateTipoDeComprobanteDeVenta(data, IdTransaction, replicacion);
		}

		private static string  UpdateNumero(tsa_ComprobantesExDataset data)
		{
			foreach(System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
			{
				if (true) /*((string)row1["Numero"] == "")*/
				{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"]);
					string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"]);

					return row.IdVariable;
				}
				
			}

			return null;
		}
		public  static string  GetComprobanteNumero(string IdTipoDeComprobante)
		{
			string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + IdTipoDeComprobante);
			string Numero = Util.StcZero( numeracion, 8 ) ;
			return Numero;

		}

		public static System.Data.DataRow ComprobantesPendientesDet(string IdComprobante, long Ordinal) 
		{
			System.Data.DataTable tabla = dataaccess.tsa_ComprobantesEx.ComprobantesPendientesDet(IdComprobante, Ordinal);
			System.Data.DataRow row=null;
			if (tabla.Rows.Count> 0)
			{
				row = tabla.Rows[0];
			}
			return row;
		}

		public static System.Data.DataRow ComprobantesPendientesDet(string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal) 
		{
			System.Data.DataTable tabla = dataaccess.tsa_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, Ordinal);
			System.Data.DataRow row=null;
			if (tabla.Rows.Count> 0)
			{
				row = tabla.Rows[0];
			}
			return row;
		}
		public static System.Data.DataRow ComprobantesDet(string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal) 
		{
			System.Data.DataTable tabla = dataaccess.tsa_ComprobantesEx.ComprobantesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, Ordinal);
			System.Data.DataRow row=null;
			if (tabla.Rows.Count> 0)
			{
				row = tabla.Rows[0];
			}
			return row;
		}

		public static bool PercibeIB(string IdComprobante)
		{
			string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
			return mz.erp.dataaccess.tsa_ComprobantesEx.IncluyeImpuestos(IdComprobante, listaIBstr);


		}

	}
}
