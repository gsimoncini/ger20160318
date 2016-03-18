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
	/// Descripción breve de tpu_ComprobantesEx.
	/// </summary>
	public class tpu_ComprobantesEx
	{
		public tpu_ComprobantesEx()
		{
			
		}

		public static tpu_ComprobantesExDataset GetList( string IdComprobante)
		{
			mz.erp.commontypes.data.tpu_ComprobantesExDataset data = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
			data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_Comprobantes.GetByPk( (System.Data.DataSet)data, IdComprobante);
			data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_ComprobantesDet.GetList( (System.Data.DataSet)data, IdComprobante,null, long.MinValue );
		/*	data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_ComprobanteDetalleDescripcionAdicional.GetListDataSet( (System.Data.DataSet)data, IdComprobante, long.MinValue, null);
			data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.GetList( (System.Data.DataSet)data, IdComprobante, null, null);
			data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_ComprobanteDetalleImpuestos.GetList( (System.Data.DataSet)data, IdComprobante, long.MinValue, null);
			data = (tpu_ComprobantesExDataset)mz.erp.dataaccess.tpu_ComprobanteValoresVarAux.GetList( (System.Data.DataSet)data, IdComprobante, null, null);*/
			return data;
		}


		public static tpu_ComprobantesExDataset  NewDataSet()
		{	
			mz.erp.commontypes.data.tpu_ComprobantesExDataset data = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
			System.Data.DataRow row = mz.erp.businessrules.tpu_Comprobantes.NewRow();
			data.Tables["tpu_Comprobantes"].LoadDataRow(row.ItemArray, false);
			return data;


				

		}


		#region Replication 
		private static SentenciasReplicacion  GenerateReplicaction()
		{
			return GenerateReplicaction(string.Empty,long.MinValue);
			
		}
		private static SentenciasReplicacion  GenerateReplicaction(string momento,long IdSucursalDestino)
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			string destino = Variables.GetValueString("Momentos."+momento+".Replicacion.Destino");
			if (destino != string.Empty && destino.Equals("IdOrigen") && (IdSucursalDestino != long.MinValue))
			{
				replication.Destino = Convert.ToString(IdSucursalDestino);
			}
			else
			{
				replication.Destino = null;
			}
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_Comprobantes";
			return replication;
			
		}

		#endregion

		#region Workflow
		/*	
		public static void Update(tpu_ComprobantesDataset dataComprobantes, tpu_ComprobantesDetDataset dataComprobantesDet,
			tlg_MovimientosDeStockDataset dataMov, tpu_ComprobantesRelacionOrigenDestinoDataset dataRel,
			bool ActualizaNumeracion, string IdTransaction, SentenciasReplicacion replicacion)
		{
			string IdVariable;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(dataComprobantes,IdTransaction);
			}
			else 
			{
				IdVariable = dataComprobantes.tpu_Comprobantes.Rows[0]["Numero"].ToString();
			} 
			mz.erp.dataaccess.tpu_ComprobantesEx.Update(dataComprobantes,dataComprobantesDet,dataMov,dataRel,
				IdVariable, replicacion,IdTransaction);
		}
*/
		#endregion

		public static void Update(tpu_ComprobantesExDataset data, bool ActualizaNumeracion, string Momento,long IdSucursalDestino)
		{
			string IdVariable;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(data);
			}
			else 
			{
				IdVariable = data.tpu_Comprobantes.Rows[0]["Numero"].ToString();
			} 
			SentenciasReplicacion replicacion = GenerateReplicaction(Momento,IdSucursalDestino);
			mz.erp.dataaccess.tpu_ComprobantesEx.Update(data, IdVariable, replicacion);
		}

		public static void Update(tpu_ComprobantesExDataset data, bool ActualizaNumeracion)
		{
			Update(data,ActualizaNumeracion,string.Empty,long.MinValue);
		}

		private static string  UpdateNumero(tpu_ComprobantesExDataset data)
		{
			foreach(System.Data.DataRow row1 in data.tpu_Comprobantes.Rows)
			{
				if((string)row1["Numero"] == "")
				{
					string numeracion = Variables.GetValueString("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"]);
					string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"]);

					return row.IdVariable;
				}
				
			}

			return null;
		}

		private static string UpdateNumero(tpu_ComprobantesDataset data, string IdTransaction)
		{
			foreach(System.Data.DataRow row1 in data.tpu_Comprobantes.Rows)
			{
				if (true) 
				{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"],IdTransaction);
					string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"],IdTransaction);

					return row.IdVariable;
				}
				
			}

			return null;
		}
	

		public  static string  GetComprobanteNumero(string IdTipoDeComprobante)
		{
			string numeracion = Variables.GetValueString("Comprobantes.Numeracion." + IdTipoDeComprobante);
			string Numero = Util.StcZero( numeracion, 8 ) ;
			return Numero;

		}

		public static string NextFileName()
		{

			string Numero = null;
			sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = mz.erp.businessrules.sy_VariablesUsuarios.GetByPk("Momentos.Pedir.NumeracionArchivo",Security.IdUsuario);
			if (row != null)
			{
				Numero = Util.StcZero( row.Valor, 8 ) ;
				row.Valor = Numero;
				mz.erp.dataaccess.sy_VariablesUsuarios.Update(row);
			}
			else
			{
				sy_VariablesDataset.sy_VariablesRow rowV = mz.erp.businessrules.sy_Variables.GetByPk("Momentos.Pedir.NumeracionArchivo");
				Numero = Util.StcZero( rowV.ValorDefault, 8 ) ;
				rowV.ValorDefault = Numero;
				mz.erp.dataaccess.sy_Variables.Update(rowV);

			}
			return Numero;
			
		}


/*
		public static tpu_ComprobantesExDataset SetMovimientosDeStock( tpu_ComprobantesExDataset data, long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, string IdMomentoDeStock, string IdEstadoDeStockOrigen, string IdEstadoDeStockDestino, string IdTipoDeAjuste, string IdProducto, decimal Cantidad)
		{
			//tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow	rowDefinicionMovimiento = mz.erp.businessrules.Stock.GetMovimiento(IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdEstadoDeStock, IdTipoDeAjuste, IdProducto, Cantidad);
			tpu_ComprobantesExDataset.tlg_MovimientosDeStockRow rowNuevoMovimiento = data.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();
			
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
			
			data.tlg_MovimientosDeStock.Addtlg_MovimientosDeStockRow( rowNuevoMovimiento );
			return data;		
		}
		*/

		/*public static void SetMovimientosDeStock( tlg_MovimientosDeStockDataset data, long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, string IdMomentoDeStock, string IdEstadoDeStockOrigen, string IdEstadoDeStockDestino, string IdTipoDeAjuste, string IdProducto, decimal Cantidad)
		{
			
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowNuevoMovimiento = data.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();
			
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

			
			
			data.tlg_MovimientosDeStock.Addtlg_MovimientosDeStockRow( rowNuevoMovimiento );
			
		}
*/



		public static void SetRelacionOrigenDestino( tpu_ComprobantesRelacionOrigenDestinoDataset data, long IdRelacionOrigenDestino, string IdComprobanteOrigen, string IdComprobanteDestino, long IdOrdinalOrigen, long IdOrdinalDestino, decimal Cantidad, bool CierraCircuito)		
		{			
			
			tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow rowEx = data.tpu_ComprobantesRelacionOrigenDestino.Newtpu_ComprobantesRelacionOrigenDestinoRow();
            rowEx.IdRelacionOrigenDestino = IdRelacionOrigenDestino;   

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
		
			data.tpu_ComprobantesRelacionOrigenDestino.Addtpu_ComprobantesRelacionOrigenDestinoRow(rowEx);	
			
			if (CierraCircuito)
			{
				rowEx = data.tpu_ComprobantesRelacionOrigenDestino.Newtpu_ComprobantesRelacionOrigenDestinoRow();
				rowEx.IdRelacionOrigenDestino = Convert.ToInt64(mz.erp.systemframework.Util.NewStringId());   
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
		
				data.tpu_ComprobantesRelacionOrigenDestino.Addtpu_ComprobantesRelacionOrigenDestinoRow(rowEx);	

			}

			
		}


		public static System.Data.DataRow ComprobantesPendientesDet(string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal) 
		{
			System.Data.DataTable tabla = dataaccess.tpu_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, Ordinal);
			System.Data.DataRow row=null;
			if (tabla.Rows.Count> 0)
			{
				row = tabla.Rows[0];
			}
			return row;
		}

		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow GetRelacionOrigenDestinoPreOrdenDeCompra(string IdComprobanteDestino, long IdOrdinalDestino)		
		{
			tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row = null;
			tpu_ComprobantesRelacionOrigenDestinoDataset data = dataaccess.tpu_ComprobantesEx.GetRelacionOrigenDestinoPreOrdenDeCompra(IdComprobanteDestino, IdOrdinalDestino);
			if (data.tpu_ComprobantesRelacionOrigenDestino.Rows.Count > 0)
				row = (tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow) data.tpu_ComprobantesRelacionOrigenDestino.Rows[0];
			return row;
		}


	}
}
