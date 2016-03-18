using System;
using System.Collections;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using System.Data;
using System.Windows.Forms;

namespace mz.erp.businessrules
{
	#region Clases Auxiliares


	
	public class GenerarMovimientosDeStock: System.Collections.ArrayList, IEnumerator
	{
		private string _idDeposito;
		private string _idSeccion;
		public GenerarMovimientosDeStock(string IdDeposito,string IdSeccion)
		{
			_idDeposito = IdDeposito;
			_idSeccion = IdSeccion;
		}

		/*Sobrecarga para los ajustes de Stock*/
		public int Add(string IdEstado,string IdAjusteDeStock, int operacion, string IdProducto, decimal cantidad )
		{
			MovimientosDeStock movimientos = null;
			if(operacion == -1)
			{
				movimientos = new MovimientosDeStock(IdAjusteDeStock, IdEstado, null, _idDeposito, _idSeccion );
				movimientos.Add( IdProducto, cantidad );
			}
			else
				if(operacion == 1)
			{
				movimientos = new MovimientosDeStock(IdAjusteDeStock, null, IdEstado, _idDeposito, _idSeccion );
				movimientos.Add( IdProducto, cantidad );
			}	
			
			return this.Add( movimientos );
			
		}

		public int Add(string IdEstado, int operacion, string IdProducto, decimal cantidad )
		{
			MovimientosDeStock movimientos = null;
			if(operacion == -1)
			{
				movimientos = new MovimientosDeStock( IdEstado, null, _idDeposito, _idSeccion );
				movimientos.Add( IdProducto, cantidad );
			}
			else
				if(operacion == 1)
				{
					movimientos = new MovimientosDeStock( null, IdEstado, _idDeposito, _idSeccion );
					movimientos.Add( IdProducto, cantidad );
				}	
			
			return this.Add( movimientos );
			
		}

		public int Add(long IdTransicion, string IdProducto, decimal Cantidad, string IdTipoDeAjusteOrigen, string IdTipoDeAjusteDestino )
		{
			if (IdTransicion != long.MinValue)
			{
				int indexfounded = this.IndexOf( IdTransicion );
				if (indexfounded != -1)
				{
					MovimientosDeStock movimientos = (MovimientosDeStock)this[ indexfounded ];
					movimientos.Add( IdProducto, Cantidad );
					this[ indexfounded ] = movimientos;
					return indexfounded;
				}
				else
				{
					MovimientosDeStock movimientos = new MovimientosDeStock( IdTransicion, _idDeposito, _idSeccion, IdTipoDeAjusteOrigen, IdTipoDeAjusteDestino );
					movimientos.Add( IdProducto, Cantidad );
					return this.Add( movimientos );
				}
			}
			return -1;
		}

		public int Add(long IdTransicion, string IdProducto, decimal Cantidad )
		{
			if (IdTransicion != long.MinValue)
			{
				int indexfounded = this.IndexOf( IdTransicion );
				if (indexfounded != -1)
				{
					MovimientosDeStock movimientos = (MovimientosDeStock)this[ indexfounded ];
					movimientos.Add( IdProducto, Cantidad );
					this[ indexfounded ] = movimientos;
					return indexfounded;
				}
				else
				{
					MovimientosDeStock movimientos = new MovimientosDeStock( IdTransicion, _idDeposito, _idSeccion );
					movimientos.Add( IdProducto, Cantidad );
					return this.Add( movimientos );
				}
			}
			return -1;
		}
		public int IndexOf( string IdTransicion )
		{
			
			foreach( MovimientosDeStock movimientos in this)
			{
				if (movimientos.IdTransicion.CompareTo( IdTransicion ) == 0)
					return _index;
			}
			return -1;

		}
		#region Miembros de IEnumerator
		private int _index = -1;
		public void Reset()
		{
			_index =  -1;
		}

		public object Current
		{
			get
			{
				return base[ _index ];
				
			}
		}

		public bool MoveNext()
		{
			_index ++;
			return _index < this.Count;
		}

		#endregion
	}
	sealed class MovimientoDeStock
	{
		public MovimientoDeStock(string IdProducto, decimal Cantidad)
		{
			this._cantidad = Cantidad;
			this._idProducto = IdProducto;
		}
		private string _idProducto = string.Empty;
		private decimal _cantidad = 0;
		public string IdProducto 
		{
			get { return _idProducto ; }
		}
		public decimal Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value ;}
		}
	}

	sealed class MovimientosDeStock: ArrayList, System.Collections.IEnumerator
	{
		
		private long _idTransicion;
		private string _idEstadoDeStockOrigen;
		private string _idEstadoDeStockDestino;
		private bool _isValidEstadoDeStockOrigen = true;
		private bool _isValidEstadoDeStockDestino = true;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		//private string _idTipoDeAjuste = string.Empty;
		private string _idTipoDeAjusteOrigen = string.Empty;
		private string _idTipoDeAjusteDestino = string.Empty;

		public MovimientosDeStock(string idEstadoOrigen, string idEstadodestino, string IdDeposito, string IdSeccion)
		{
			this._idDeposito = IdDeposito;
			this._idSeccion = IdSeccion;
			_idEstadoDeStockOrigen = idEstadoOrigen;
			_idEstadoDeStockDestino = idEstadodestino;
			if ( _idEstadoDeStockOrigen == null || _idEstadoDeStockOrigen.CompareTo( string.Empty) == 0)
				_isValidEstadoDeStockOrigen = false;
			if ( _idEstadoDeStockDestino == null || _idEstadoDeStockDestino.CompareTo( string.Empty) == 0 )
				_isValidEstadoDeStockDestino = false;
			
		}

		
		public MovimientosDeStock(string IdTipoDeAjsute, string idEstadoOrigen, string idEstadodestino, string IdDeposito, string IdSeccion)
		{
			//this._idTipoDeAjuste = IdTipoDeAjsute;
			this._idDeposito = IdDeposito;
			this._idSeccion = IdSeccion;
			_idEstadoDeStockOrigen = idEstadoOrigen;
			_idEstadoDeStockDestino = idEstadodestino;
			if ( _idEstadoDeStockOrigen == null || _idEstadoDeStockOrigen.CompareTo( string.Empty) == 0)
			{
				_isValidEstadoDeStockOrigen = false;
				_idTipoDeAjusteDestino = IdTipoDeAjsute;
			}
			if ( _idEstadoDeStockDestino == null || _idEstadoDeStockDestino.CompareTo( string.Empty) == 0 )
			{
				_isValidEstadoDeStockDestino = false;
				_idTipoDeAjusteOrigen = IdTipoDeAjsute;
			}
			
		}
		

		public MovimientosDeStock(long idTransicion, string IdDeposito, string IdSeccion)
		{
			if (idTransicion != long.MinValue)
			{
				mz.erp.commontypes.data.tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow _rowTransicionDeStock = mz.erp.businessrules.tlg_TransicionesDeStock.GetByPk( idTransicion );
				if (_rowTransicionDeStock != null)
				{
					_idEstadoDeStockOrigen = _rowTransicionDeStock.IdEstadoDeStockOrigen;
					_idEstadoDeStockDestino = _rowTransicionDeStock.IdEstadoDeStockDestino;
				}
				_idTransicion = idTransicion;
				if (_idEstadoDeStockOrigen.CompareTo( string.Empty) == 0 || _idEstadoDeStockOrigen == null)
					_isValidEstadoDeStockOrigen = false;
				if (_idEstadoDeStockDestino.CompareTo( string.Empty) == 0 || _idEstadoDeStockDestino == null)
					_isValidEstadoDeStockDestino = false;
				this._idDeposito = IdDeposito;
				this._idSeccion = IdSeccion;
			}
		}


		public MovimientosDeStock(long idTransicion, string IdDeposito, string IdSeccion, string IdTipoDeAjusteOrigen, string IdTipoDeAjusteDestino)
		{
			if (idTransicion != long.MinValue)
			{
				mz.erp.commontypes.data.tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow _rowTransicionDeStock = mz.erp.businessrules.tlg_TransicionesDeStock.GetByPk( idTransicion );
				if (_rowTransicionDeStock != null)
				{
					_idEstadoDeStockOrigen = _rowTransicionDeStock.IdEstadoDeStockOrigen;
					_idEstadoDeStockDestino = _rowTransicionDeStock.IdEstadoDeStockDestino;
				}
				_idTransicion = idTransicion;
				_idTipoDeAjusteOrigen = IdTipoDeAjusteOrigen;
				_idTipoDeAjusteDestino = IdTipoDeAjusteDestino;
				if (_idEstadoDeStockOrigen.CompareTo( string.Empty) == 0 || _idEstadoDeStockOrigen == null)
					_isValidEstadoDeStockOrigen = false;
				if (_idEstadoDeStockDestino.CompareTo( string.Empty) == 0 || _idEstadoDeStockDestino == null)
					_isValidEstadoDeStockDestino = false;
				this._idDeposito = IdDeposito;
				this._idSeccion = IdSeccion;
			}
		}

		public bool IsValidEstadoDeStockOrigen
		{
			get { return _isValidEstadoDeStockOrigen; }
		}
		public bool IsValidEstadoDeStockDestino
		{
			get { return _isValidEstadoDeStockDestino ; }
		}
		public string EstadoDeStockOrigen
		{
			get { return _idEstadoDeStockOrigen ;}
		}
		public string EstadoDeStockDestino
		{
			get { return _idEstadoDeStockDestino ;} 
		}
		public string IdDeposito
		{
			get { return _idDeposito; }
		}
		public long IdTransicion
		{
			get { return _idTransicion ; }
		}
		public string IdSeccion
		{
			get { return _idSeccion ; }
		}
		/*
		public string IdTipoAjuste
		{
			get{return _idTipoDeAjuste;}
		}
		*/

		public string IdTipoAjusteOrigen
		{
			get{return _idTipoDeAjusteOrigen;}
		}

		public string IdTipoAjusteDestino
		{
			get{return _idTipoDeAjusteDestino;}
		}

		public int Add(string _idProducto, decimal _cantidad)
		{
			int _searchedIndex = IndexOf( _idProducto );
			if (_searchedIndex > -1)
			{
				MovimientoDeStock _registro = (MovimientoDeStock)this[ _searchedIndex ];
				_registro.Cantidad = _registro.Cantidad+ _cantidad;
				this[ _searchedIndex ] = _registro;
				return _searchedIndex;
			}
			else
			{
				MovimientoDeStock _registro = new MovimientoDeStock( _idProducto, _cantidad  );
				return base.Add( _registro );
			}

		}
		public override int IndexOf(object _idProducto)
		{
			foreach ( MovimientoDeStock registro in this )
			{
				if (registro.IdProducto.CompareTo( Convert.ToString(_idProducto) ) == 0)
					return _index;
			}
			return -1;

		}
	
		#region Miembros de IEnumerator
		private int _index = -1;
		
		public void Reset()
		{
			_index = -1;
		}

		public object Current
		{
			get
			{
				return base[ _index ] ;
			}
		}

		public bool MoveNext()
		{
			_index ++;
			return _index < this.Count;
		}

		#endregion
	}
	#endregion
	
	/// <summary>
	/// Descripción breve de Stock.
	/// </summary>
	public class Stock
	{
		public Stock()
		{		
			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public static void StockACero()
		{
			mz.erp.dataaccess.Stock.StockACero();
		}



		public enum OperationNumerosDeSerie {Insert, Delete, DeleteInsert, Nothing};

		public static OperationNumerosDeSerie GetOperacionNumerosDeSerie(string processName, string taskName)
		{
			long result = Variables.GetValueLong("Momentos." + taskName + "." + processName + ".OperacionNumerosDeSerie" );
			return result==1?OperationNumerosDeSerie.Insert:result==-1?OperationNumerosDeSerie.Delete:result==2?OperationNumerosDeSerie.DeleteInsert:OperationNumerosDeSerie.Nothing;

			
		}

		/*public static long GetTransicion( string IdComprobanteOrigen, string IdComprobanteDestino)
		{			
			string Mensaje = String.Format("Cambiar a sobrecarga GetTransicion(IdComprobanteOrigen, IdComprobanteDestino, IdTarea, IdProceso). IdComprobanteOrigen = {0}, IdComprobanteDestino = {1}", IdComprobanteOrigen, IdComprobanteDestino );
			Exception e = new Exception(Mensaje);
			throw e;													
			mz.erp.commontypes.data.tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow _row = mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetByPk( IdComprobanteOrigen, IdComprobanteDestino);
			if (_row != null)
			{
				return Convert.ToInt32( _row["IdMomento"] );
			}
			return long.MinValue;
		}		*/
		public static long GetTransicion( string IdComprobanteOrigen, string IdComprobanteDestino, long IdTarea, long IdProceso)
		{			
			IdTarea = long.MinValue;			
			//tlg_TiposComprobantesOrigenDestinoDataset data = mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetList(IdComprobanteOrigen, IdComprobanteDestino, IdTarea, IdProceso);
			tlg_TiposComprobantesOrigenDestinoDataset data = mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetListEx(IdComprobanteOrigen, IdComprobanteDestino, IdTarea, IdProceso);
			if (data.tlg_TiposComprobantesOrigenDestino.Rows.Count == 1) 
			{
				tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow _row = (tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow) data.tlg_TiposComprobantesOrigenDestino.Rows[0];
				if (_row != null)
				{					
					return Convert.ToInt32( _row["IdMomento"] );
				}		
				else 
				{
					string Mensaje = String.Format("No encontró el registro en la tabla tlg_tiposcomprobantesorigendestino. IdComprobanteOrigen = {0}, IdComprobanteDestino = {1}, IdProceso = {2}", IdComprobanteOrigen, IdComprobanteDestino, IdProceso);					
					Exception e = new Exception(Mensaje);
					throw e;											
				}			
			}
			else 
			{
				string Mensaje = String.Format("Hay {3} registro/s en la tabla tlg_tiposcomprobantesorigendestino. IdComprobanteOrigen = {0}, IdComprobanteDestino = {1}, IdProceso = {2}", IdComprobanteOrigen, IdComprobanteDestino, IdProceso, data.tlg_TiposComprobantesOrigenDestino.Rows.Count);									
				Exception e = new Exception(Mensaje);
				throw e;										
			}			
			return long.MinValue;
		}
		public static string GetTransicion( string IdTipoDeAjusteDeStock )
		{
			return null;
		}
		
		public static mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable GetDataTableStock( GenerarMovimientosDeStock _movimientos)
		{
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset _data = new mz.erp.commontypes.data.tlg_MovimientosDeStockDataset();
			foreach (MovimientosDeStock _grupoIdenticoDeMovimientos in _movimientos)
			{
				System.Data.DataTable _conjuntoDeRows = GetDataTableStockP( _grupoIdenticoDeMovimientos );
				foreach( System.Data.DataRow _rows in _conjuntoDeRows.Rows )
				{
					_data.tlg_MovimientosDeStock.Rows.Add( _rows.ItemArray );
				}
			}
			return _data.tlg_MovimientosDeStock;
		}

		/*Coregir eso-----------------------------------------------------------*/
		private static mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable GetDataTableStockP( MovimientosDeStock _movimientosARealizar)
		{
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset _data = new mz.erp.commontypes.data.tlg_MovimientosDeStockDataset();
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = _data.tlg_MovimientosDeStock;
			foreach ( MovimientoDeStock _registro in _movimientosARealizar )
			{
				if (_movimientosARealizar.IsValidEstadoDeStockOrigen )
				{
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow _row = mz.erp.businessrules.Stock.GetDataRowStock(  _registro.IdProducto, _registro.Cantidad, _movimientosARealizar.IdDeposito, _movimientosARealizar.IdSeccion, _movimientosARealizar.EstadoDeStockOrigen,_movimientosARealizar.IdTipoAjusteOrigen, -1 );
					_table.Rows.Add( _row.ItemArray );
				}
				if (_movimientosARealizar.IsValidEstadoDeStockDestino )
				{
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow _row = mz.erp.businessrules.Stock.GetDataRowStock(  _registro.IdProducto, _registro.Cantidad, _movimientosARealizar.IdDeposito, _movimientosARealizar.IdSeccion, _movimientosARealizar.EstadoDeStockDestino,_movimientosARealizar.IdTipoAjusteDestino, 1 );
					_table.Rows.Add( _row.ItemArray );
				}
			}
			return _table;
		}


		
		private static mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow GetDataRowStock( string _idProducto, decimal _cantidad, string _idDeposito, string _idSeccion, string _idEstadoDeStock, string IdTipoAjuste, int signo )
		{
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow _row = mz.erp.businessrules.tlg_MovimientosDeStock.NewRow();
			_row.IdMovimientoDeStock = Util.NewStringId();
			_row.IdProducto = _idProducto;
			_row.Cantidad = _cantidad*signo;
			_row.IdDeposito = _idDeposito;
			_row.IdSeccion = _idSeccion;
			_row.IdEstadoDeStock = _idEstadoDeStock;
			_row.IdTipoDeAjuste = IdTipoAjuste;
			return _row;
		}


		/// <summary>
		/// Para obtener el stock. En esta sobrecarga el usuario de acuerdo a su configuración de variables (IdVisualizacionDeStock, IdEstadoDeStock y IdProducto) puede ver el total de stock por defecto. 
		/// IdSucursalD y IdEmpresaD toman el valor de IdSucursal e IdEmpresa respectivamente para que incluya solo el stock de la sucursal propia.
		/// Se agregó el parámetro SoloPropia para definir si incluye también el stock de las otras sucursales que puede visualizar.
		/// </summary>
		/// <param name="IdVisualizacionDeStock"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <returns></returns>
		public static decimal GetStock(string IdVisualizacionDeStock, string IdEstadoDeStock, string IdProducto, bool SoloPropia) 
		{
			long IdSucursal = Security.IdEmpresa;
			long IdEmpresa = Security.IdEmpresa;
			string IdDeposito = null;
			string IdSeccion = null;			
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			if (SoloPropia == true) 
			{
				IdSucursalD = IdSucursal;
				IdEmpresaD = IdEmpresa;
			}
			else
			{
				IdSucursalD = long.MinValue;
				IdEmpresaD = long.MinValue;
			}
			
			return GetStock(IdVisualizacionDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursalD, IdEmpresaD);
		}
		/// <summary>
		/// Para obtener el stock con requerimientos mínimos.
		/// </summary>
		/// <param name="IdVisualizacionDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <returns></returns>
		public static decimal GetStock(string IdVisualizacionDeStock, string IdProducto) 
		{
			long IdSucursal = Security.IdEmpresa;
			long IdEmpresa = Security.IdEmpresa;
			string IdDeposito = String.Empty;
			string IdSeccion = String.Empty;
			string IdEstadoDeStock = String.Empty;
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			return GetStock(IdVisualizacionDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursalD, IdEmpresaD);
		}
		/// <summary>
		/// Para obtener el stock con requerimientos mínimos más depósito y sección.
		/// </summary>
		/// <param name="IdVisualizacionDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <returns></returns>
		public static decimal GetStock(string IdVisualizacionDeStock, string IdProducto, string IdDeposito, string IdSeccion) 
		{

			long IdSucursal = Security.IdEmpresa;
			long IdEmpresa = Security.IdEmpresa;
			string IdEstadoDeStock = String.Empty;
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			return GetStock(IdVisualizacionDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursalD, IdEmpresaD);
		}
		/// <summary>
		/// Para obtener el stock con requerimientos mínimos más depósito, sección y estado de stock
		/// </summary>
		/// <param name="IdVisualizacionDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <returns></returns>
		public static decimal GetStock(string IdVisualizacionDeStock, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock) 
		{		
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			return GetStock(IdVisualizacionDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursalD, IdEmpresaD);
		}
		/// <summary>
		/// Para obtener el stock especificando todos los parámetros.
		/// </summary>
		/// <param name="IdVisualizacionDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <param name="IdSucursalD"></param>
		/// <param name="IdEmpresaD"></param>
		/// <returns></returns>
		public static decimal GetStock(string IdVisualizacionDeStock, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursalD, long IdEmpresaD) 
		{			
			long IdSucursal = Security.IdEmpresa;
			long IdEmpresa = Security.IdEmpresa;			
			return dataaccess.tlg_Stock.GetList(IdVisualizacionDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);
		}

		public static System.Data.DataTable GetMovimientosByIdProductoOrJerarquia(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, DateTime desde , DateTime hasta)
		{
			return mz.erp.dataaccess.Stock.GetMovimientosByIdProductoOrJerarquia(IdProducto,IdJerarquia1,IdJerarquia2,IdJerarquia3,IdJerarquia4,IdJerarquia5, desde, hasta);
		}

		public static decimal GetStock(string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa)
		{
			decimal stock = 0;
			mz.erp.commontypes.data.tlg_StockDataset data = mz.erp.businessrules.tlg_Stock.GetList( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa );
			if (data != null)
			{
				if (data.tlg_Stock.Rows.Count > 0)
				{
					stock = Convert.ToDecimal( data.tlg_Stock.Rows[0]["Cantidad"] );
				}
			}
			return stock;
		}

		public static decimal GetStockDisponible(string IdProducto) 
		{
			
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row = tsh_ProductosSucursales.GetByPk(IdProducto, Security.IdSucursal, Security.IdEmpresa);
			if (row.IsStockDisponibleNull())
			{
				return 0;
			}
			else 
			{
				return Convert.ToDecimal(row.StockDisponible);
			}
			
		}




		/*public static bool AjusteStock(string IdDeposito, string IdSeccion, string IdTipoDeAjuste, string IdProducto, decimal Cantidad) 
		{		
			long IdSucursal = Security.IdSucursal;
			long IdEmpresa = Security.IdEmpresa;
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row;
			
			return AjusteStock(row, IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdTipoDeAjuste, IdProducto, Cantidad);
		}*/
		/// <summary>
		/// Permite realizar un ajuste de stock sin especificar la sucursal ni la empresa.
		/// </summary>
		/// <param name="row"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdProducto"></param>
		/// <param name="Cantidad"></param>
		/// <returns></returns>
		/// 

		/*public void ActualizarStock(long idSucursal, long idEmpresa, string idProducto)
		{			
			if (MessageBox.Show( "El proceso puede demorar varios minutos. ¿Desea comenzar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
			{
				if (mz.erp.dataaccess.Stock.ActualizarStock(idSucursal, idEmpresa, idProducto) == false)
				{
					MessageBox.Show( "El proceso no pudo ejecutarse", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else 
				{
					MessageBox.Show( "El proceso finalizó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
		}*/

		#region Replication 
		private  static SentenciasReplicacion  GenerateReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdEmpresa;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tlg_Stock";
			return replication;
		}

		#endregion


		/// <summary>
		/// Método para utilizacion de proceso "Stock a cero" (no tiene el parámetro row ni la cantidad)
		/// ya que el ajuste (positivo y negativo) para todos los estados de stock del producto depende 
		/// del stock que tiene.
		/// </summary>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdProducto"></param>
		/// <returns></returns>
		
		
		public static bool AjusteStock(ref DataRow row, string IdDeposito, string IdSeccion, string IdTipoDeAjuste, string IdProducto) 
		{					
			long IdSucursal = Security.IdSucursal;
			long IdEmpresa = Security.IdEmpresa;	
			bool resultado = false;			

			tlg_StockDataset dataS = businessrules.tlg_Stock.GetList(IdProducto, IdDeposito, IdSeccion, IdSucursal, IdEmpresa);			
			
			foreach (tlg_StockDataset.tlg_StockRow rowS in dataS.tlg_Stock.Rows) 
			{
				string IdEstadoDeStock = rowS.IdEstadoDeStock;
				decimal Cantidad = rowS.Cantidad;
				if (Cantidad != 0) 
				{
					resultado = AjusteStock(ref row, IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdTipoDeAjuste, IdEstadoDeStock, IdProducto, Cantidad) && resultado;
				}								
			}			
			return resultado;
		}
		

		/// Método para utilizacion de proceso "Stock a cero" (no tiene el parámetro row ni la cantidad)
		/// ya que el ajuste (positivo y negativo) para todos los estados de stock del producto depende 
		/// del stock que tiene.
		/// <param name="row"></param>
		/// <param name="IdSucursal"></param>
		/// <param name="IdEmpresa"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <param name="IdProducto"></param>
		/// <returns></returns>
		public static bool AjusteStock(ref DataRow row, long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, string IdTipoDeAjuste, string IdEstadoDeStock, string IdProducto, decimal Cantidad)
		{								
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowS = tlg_MovimientosDeStock.NewRow();						
			if (IdProducto == String.Empty) 
			{				
				row = (DataRow) rowS;				

				row.SetColumnError( "IdProducto" , "Falta ingresar el producto");
				return false;
			}
			if (IdTipoDeAjuste == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdTipoDeAjuste" , "Falta ingresar el tipo de ajuste");
				return false;
			}	
			if (IdDeposito == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdDeposito" , "Falta ingresar el depósito");
				return false;
			}			
			if (IdSeccion == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdSeccion" , "Falta ingresar la sección");
				return false;
			}			

			rowS = GetMovimiento(IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdEstadoDeStock, IdTipoDeAjuste, IdProducto, Cantidad * (-1));	
			SentenciasReplicacion replicacion =  GenerateReplication();
			dataaccess.Stock.UpdateStockACero(rowS, String.Empty, IdEstadoDeStock, replicacion);
			row = (DataRow) rowS;
			return true;
		}
		/*


		public static bool AjusteStock(ref DataRow row, string IdDeposito, string IdSeccion, string IdTipoDeAjuste, string IdProducto, decimal Cantidad) 
		{					
			long IdSucursal = Security.IdSucursal;
			long IdEmpresa = Security.IdEmpresa;	
			
			return AjusteStock(ref row, IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdTipoDeAjuste, IdProducto, Cantidad);
		}


		/// <summary>
		/// Permite realizar un ajuste de stock especificando todos los parámetros.
		/// </summary>
		/// <param name="row"></param>
		/// <param name="IdSucursal"></param>
		/// <param name="IdEmpresa"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdProducto"></param>
		/// <param name="Cantidad"></param>
		/// <returns></returns>
		public static bool AjusteStock(ref DataRow row, long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, string IdTipoDeAjuste, string IdProducto, decimal Cantidad)
		{								
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowS = tlg_MovimientosDeStock.NewRow();						
			if (IdProducto == String.Empty) 
			{				
				row = (DataRow) rowS;				

				row.SetColumnError( "IdProducto" , "Falta ingresar el producto");
				return false;
			}
			if (IdTipoDeAjuste == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdTipoDeAjuste" , "Falta ingresar el tipo de ajuste");
				return false;
			}	
			if (IdDeposito == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdDeposito" , "Falta ingresar el depósito");
				return false;
			}			
			if (IdSeccion == String.Empty) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "IdSeccion" , "Falta ingresar la sección");
				return false;
			}			
			if (Cantidad <= 0) 
			{				
				row = (DataRow) rowS;				
				row.SetColumnError( "Cantidad" , "La cantidad debe ser mayor a cero");
				return false;
			}		

			string IdEstadoDeStockDestino = String.Empty;
			decimal Signo = 1;
			GetEstadoDeStock(IdTipoDeAjuste, ref IdEstadoDeStockDestino, ref Signo);		
			
			Cantidad = Signo * Cantidad;			
			rowS = GetMovimiento(IdSucursal, IdEmpresa, IdDeposito, IdSeccion,  null, IdEstadoDeStockDestino, IdTipoDeAjuste, IdProducto, Cantidad);						
			
			SentenciasReplicacion replicacion =  GenerateReplication();
			dataaccess.Stock.Update(rowS, String.Empty, IdEstadoDeStockDestino, replicacion);
			row = (DataRow) rowS;
			return true;
		}
		
		/// <summary>
		/// Función que realiza el movimiento de stock de los dos estados de stock definidos por el momento sin especificar sucursal ni empresa.
		/// </summary>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdMomento"></param>
		/// <param name="IdProducto"></param>
		/// <param name="Cantidad"></param>
		/// <returns></returns>
		public static bool MueveStock(string IdDeposito, string IdSeccion, long IdMomento, string IdProducto, decimal Cantidad) 
		{

			long IdSucursal = Security.IdSucursal;
			long IdEmpresa = Security.IdEmpresa;			
			return MueveStock(IdSucursal, IdEmpresa, IdDeposito, IdSeccion, IdMomento, IdProducto, Cantidad);
		}
		/// <summary>
		/// Función que realiza el movimiento de stock de los dos estados de stock definidos por el momento.
		/// </summary>
		/// <param name="IdSucursal"></param>
		/// <param name="IdEmpresa"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdMomento"></param>
		/// <param name="IdProducto"></param>
		/// <param name="Cantidad"></param>
		/// <remarks > Dentro de Update row se graba dos veces, primero con origen y luego con destino.</remarks>
		/// <returns></returns>
		public static bool MueveStock(long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion, long IdMomento, string IdProducto, decimal Cantidad)
		{
			if (Cantidad <= 0) {return false;}						
			
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row = tlg_MovimientosDeStock.NewRow();
			string IdTipoDeAjuste = String.Empty;
			string EstadoStockOrigen = String.Empty;
			string EstadoStockDestino = String.Empty;

			GetEstados(IdMomento, ref EstadoStockOrigen, ref EstadoStockDestino);						
			row = GetMovimiento(IdSucursal, IdEmpresa, IdDeposito, IdSeccion, EstadoStockOrigen,EstadoStockDestino, IdTipoDeAjuste, IdProducto, Cantidad);

			SentenciasReplicacion replicacion =  GenerateReplication();
			return dataaccess.Stock.Update(row, EstadoStockOrigen, EstadoStockDestino, replicacion);			
		}	
		/// <summary>
		/// Función que copia todos los valores pasados por parámetros a la row de Movimientos de stock.
		/// </summary>
		/// <param name="IdSucursal"></param>
		/// <param name="IdEmpresa"></param>
		/// <param name="IdDeposito"></param>
		/// <param name="IdSeccion"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdProducto"></param>
		/// <param name="Cantidad"></param>
		/// <returns></returns>
		/// 
		*/
		public static tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow GetMovimiento(long IdSucursal, long IdEmpresa, string IdDeposito, string IdSeccion,  string IdEstadoDeStock, string IdTipoDeAjuste, string IdProducto, decimal Cantidad)
		{
			tlg_MovimientosDeStockDataset data = new tlg_MovimientosDeStockDataset();

			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row = data.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();
			row.IdMovimientoDeStock = Util.NewStringId(); 
			row.IdSucursal = IdSucursal;
			row.IdEmpresa = IdEmpresa;
			row.IdDeposito = IdDeposito;
			row.IdSeccion = IdSeccion;
			row.IdEstadoDeStock = IdEstadoDeStock;
			row.IdTipoDeAjuste = IdTipoDeAjuste;
			row.IdProducto = IdProducto;
			row.Cantidad = Cantidad;								
			row.IdConexionCreacion = Security.IdConexion;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			data.tlg_MovimientosDeStock.Addtlg_MovimientosDeStockRow(row);

			return row;
		}

		public static void RecomponerStock() 
		{
			dataaccess.Stock.RecomponerStock();
		}
		/*
		/// <summary>
		/// Obtiene los estados de stock de origen y destino de acuerdo al momento especificado.
		/// </summary>
		/// <param name="IdMomento"></param>
		/// <param name="EstadoStockOrigen"></param>
		/// <param name="EstadoStockDestino"></param>
		public static void GetEstados(long IdMomento, ref string EstadoStockOrigen, ref string EstadoStockDestino)
		{
			tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow rowTransicion = tlg_TransicionesDeStock.GetByPk(IdMomento);
			if (rowTransicion != null)
			{
				if (!rowTransicion.IsNull("IdEstadoDeStockOrigen"))
				{
					EstadoStockOrigen = rowTransicion.IdEstadoDeStockOrigen;				
				}
				else
				{
					EstadoStockOrigen = null;
				}
				if (!rowTransicion.IsNull("IdEstadoDeStockDestino"))
				{
					EstadoStockDestino = rowTransicion.IdEstadoDeStockDestino;
				}
				else
				{
					EstadoStockDestino = null;
				}
			}
			else
			{
				EstadoStockOrigen = null;
				EstadoStockDestino = null;
			}
				

		}		
		/// <summary>
		/// Función que devuelve el estado de stock al que se debe realizar el ajuste de stock de acuerdo al tipo de ajuste especificado.
		/// </summary>
		/// <param name="IdTipoDeAjuste"></param>
		/// <param name="IdEstadoDeStock"></param>
		/// <param name="Signo"></param>
		public static void GetEstadoDeStock(string IdTipoDeAjuste, ref string IdEstadoDeStock, ref decimal Signo) 
		{		
			tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow rowTiposAjuste = tlg_TiposDeAjuste.GetByPk(IdTipoDeAjuste);
			IdEstadoDeStock = rowTiposAjuste.IdEstadoDeStock;
			Signo = rowTiposAjuste.Operacion;			
		}

		
		public static void Update_Stock_Forced( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, decimal Cantidad)
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.IdTipoDeSentencia = "Update";
			replication.NombreTabla = "dataaccess.tlg_Stock";
			mz.erp.dataaccess.Stock.Replicacion = replication;
			mz.erp.dataaccess.Stock.Update_Stock_Forced(IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa, Cantidad);
			replication.Update();
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replication.Data.sy_SentenciasReplicacion);
		}
		*/
	}
}
