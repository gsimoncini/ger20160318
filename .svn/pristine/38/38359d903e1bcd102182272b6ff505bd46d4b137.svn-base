

namespace mz.erp.dataaccess
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.IO;
	using System.Collections;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using mz.erp.systemframework;
	/// <summary>
	/// Descripción breve de Stock.
	/// </summary>
	public class Stock: IDisposable
	{
		public Stock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void Dispose()
		{
		}


		public static void StockACero()
		{
			//Update con el agregado que la cantidad a ajustar a cero la calcula dentro de la transacción.
			SqlConnection cnx = null;
			SqlTransaction trx = null;
			try
			{
				
				cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				trx = cnx.BeginTransaction( IsolationLevel.Serializable );
				mz.erp.dataaccess.Stock.StockACero(trx);
				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
				throw e;
			}
			finally 
			{
				cnx.Close();
			}
			
		}

		public static void StockACero(SqlTransaction trx)
		{
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_StockACero");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;
			cmd.ExecuteNonQuery();
		}


		public static decimal GetStockPorSucursal(SqlTransaction trx,string IdProducto, string IdEstadoDeStock, long IdEmpresa, long IdSucursal)
		{
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SumaPorSucursal");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdProducto"].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdEstadoDeStock"].Value = IdEstadoDeStock;
			

			return Convert.ToDecimal(cmd.ExecuteScalar());
			
			
		}

		public static void UpdateFromMovimientosDeStock(System.Data.DataTable _tableMovimientos, SqlTransaction trx )
		{
			mz.erp.commontypes.data.tlg_StockDataset _data = new tlg_StockDataset();
			mz.erp.commontypes.data.tlg_StockDataset.tlg_StockDataTable _table = _data.tlg_Stock;
			foreach (System.Data.DataRow _rowTableMovimientos in _tableMovimientos.Rows)
			{
				
				mz.erp.commontypes.data.tlg_StockDataset.tlg_StockRow _row = _table.FindByIdProductoIdDepositoIdSeccionIdEstadoDeStock( Convert.ToString(_rowTableMovimientos["IdProducto"]),Convert.ToString(_rowTableMovimientos["IdDeposito"]),Convert.ToString(_rowTableMovimientos["IdSeccion"]), Convert.ToString(_rowTableMovimientos["IdEstadoDeStock"]));
				if (_row != null)
				{
					_row["Cantidad"] = Convert.ToDecimal(_rowTableMovimientos["Cantidad"])+Convert.ToDecimal(_row["Cantidad"]);
				}
				else
				{
					_row = _table.Newtlg_StockRow();
					_row["Cantidad"] = _rowTableMovimientos["Cantidad"];
					_row["FechaCreacion"] = _rowTableMovimientos["FechaCreacion"];
					_row["IdConexionCreacion"] = _rowTableMovimientos["IdConexionCreacion"];
					_row["IdConexionUltimaModificacion"] = _rowTableMovimientos["IdConexionUltimaModificacion"];
					_row["IdDeposito"] = _rowTableMovimientos["IdDeposito"];
					_row["IdEmpresa"] = _rowTableMovimientos["IdEmpresa"];
					_row["IdEstadoDeStock"] = _rowTableMovimientos["IdEstadoDeStock"];
					_row["IdProducto"] = _rowTableMovimientos["IdProducto"];
					_row["IdReservado"] = _rowTableMovimientos["IdReservado"];
					_row["IdSeccion"]= _rowTableMovimientos["IdSeccion"];
					_row["IdSucursal"] = _rowTableMovimientos["IdSucursal"];
					_table.Rows.Add((System.Data.DataRow)_row );
				}
				
			}

			mz.erp.commontypes.SentenciasReplicacion _replicacion = new SentenciasReplicacion();
			mz.erp.dataaccess.tlg_Stock.Update( (System.Data.DataTable)_table, trx, _replicacion );

			foreach (System.Data.DataRow _rowDeStock in _table.Rows)
			{
				if(Convert.ToString(_rowDeStock["IdEstadoDeStock"]).Equals("3"))
				{
					decimal cant = Stock.GetStockPorSucursal(trx, Convert.ToString(_rowDeStock["IdProducto"]),Convert.ToString(_rowDeStock["IdEstadoDeStock"]),Convert.ToInt32(_rowDeStock["IdSucursal"]), Convert.ToInt32( _rowDeStock["IdEmpresa"]));			
					ActualizarStock( trx, Convert.ToInt32( _rowDeStock["IdSucursal"]), Convert.ToInt32( _rowDeStock["IdEmpresa"]), Convert.ToString(_rowDeStock["IdProducto"]),Convert.ToString(_rowDeStock["IdEstadoDeStock"]),cant );
				}
			}
			

			/*
			foreach (System.Data.DataRow _rowTableMovimientos in _table.Rows)
			{
				tlg_StockDataset.tlg_StockRow _rowDeStock = mz.erp.dataaccess.tlg_Stock.GetByPk(  Convert.ToString(_rowTableMovimientos["IdProducto"]),Convert.ToString(_rowTableMovimientos["IdDeposito"]),Convert.ToString(_rowTableMovimientos["IdSeccion"]), Convert.ToString(_rowTableMovimientos["IdEstadoDeStock"]), trx);
				ActualizarStock( trx, Convert.ToInt32( _rowDeStock["IdSucursal"]), Convert.ToInt32( _rowDeStock["IdEmpresa"]), Convert.ToString(_rowDeStock["IdProducto"]),Convert.ToString(_rowDeStock["IdEstadoDeStock"]),Convert.ToDecimal( _rowDeStock["Cantidad"] ) );
			}
			*/

/*
			foreach (System.Data.DataRow _rowTableMovimientos in _tableMovimientos.Rows)
			{
				long IdSucursal = Convert.ToInt32(_rowTableMovimientos["IdSucursal"]);
				long IdEmpresa = Convert.ToInt32(_rowTableMovimientos["IdEmpresa"]);
				string IdProducto = Convert.ToString(_rowTableMovimientos["IdProducto"]);

				ActualizarStock(trx, IdSucursal, IdEmpresa, IdProducto);
			}*/
		}
		

		public static bool ActualizarStock( SqlTransaction trx, long idSucursal, long idEmpresa, string idProducto, string IdEstadoDeStock, decimal Cantidad)
		{ 
			SqlCommand cmd = new SqlCommand( "Pr_tsh_productosSucursales_UpdateDeStock");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdSucursal"].Value = idSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdEmpresa"].Value = idEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdProducto"].Value = idProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdEstadoDeStock"].Value = IdEstadoDeStock;
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ));
			cmd.Parameters[ "@Cantidad"].Value = Cantidad;

			cmd.ExecuteNonQuery();
			return true;
			
		}

		public static System.Data.DataTable GetMovimientosByIdProductoOrJerarquia(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, DateTime desde, DateTime hasta)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStock_ByIdProductoOrJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if(IdProducto == "" || IdProducto == null)
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
			if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
			if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
			if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
			if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
			if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


			cmd.Parameters.Add( new SqlParameter( "@desde", SqlDbType.DateTime ) );
			if(desde == DateTime.MinValue) cmd.Parameters[ "@desde" ].Value = System.DBNull.Value;
			else cmd.Parameters[ "@desde" ].Value = Util.GetStartDay(desde);
			cmd.Parameters.Add( new SqlParameter( "@hasta", SqlDbType.DateTime ) );
			if(hasta == DateTime.MinValue) cmd.Parameters[ "@hasta" ].Value = System.DBNull.Value;
			else cmd.Parameters[ "@hasta" ].Value = Util.GetEndDay(hasta);
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];
		}
		
/*

		public static bool Update(System.Data.DataRow origen, SqlTransaction trx, SentenciasReplicacion replicacion)
		{ //Este método es llamado desde tsa_ComprobantesEx
			Hashtable tabCantVendXProd = new Hashtable(); //Tabla que agrupa las ventas por producto para actualizar una única vez en tlg_Stock			

			bool Resultado = true;
			tlg_MovimientosDeStockDataset datatipada = new tlg_MovimientosDeStockDataset();
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row= datatipada.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();	
			
			row.IdMovimientoDeStock= (string)origen["IdMovimientoDeStock"];
			row.IdProducto = (string)origen["IdProducto"];
			row.Cantidad = (decimal)origen["Cantidad"];
			row.IdDeposito = (string)origen["IdDeposito"];
			row.IdSeccion = (string)origen["IdSeccion"];
			
			row.IdEstadoDeStockOrigen = Convert.ToString(origen["IdEstadoDeStockOrigen"]);
			row.IdEstadoDeStockDestino = Convert.ToString(origen["IdEstadoDeStockDestino"]);

			row.IdEmpresa= (long)origen["IdEmpresa"];
			row.IdSucursal = (long)origen["IdSucursal"];

			row.FechaCreacion = (DateTime)origen["FechaCreacion"];
			row.IdConexionCreacion = (long)origen["IdConexionCreacion"];
			row.IdConexionUltimaModificacion= (long)origen["IdConexionUltimaModificacion"];
			row.IdReservado = (long)origen["IdReservado"];

			if (origen["IdTipoDeAjuste"] != System.DBNull.Value)
			{
				row.IdTipoDeAjuste = (string)origen["IdTipoDeAjuste"];
			}
			else
			{
				row.IdTipoDeAjuste = string.Empty;
			}
			
			AgregarProducto(origen, tabCantVendXProd);
			
			Resultado = Resultado && UpdateMovimientos(trx, row, replicacion);				
			Resultado = Resultado && UpdateStock(trx, tabCantVendXProd, replicacion);
			Resultado = Resultado && ActualizarStock(trx, row.IdSucursal, row.IdEmpresa, row.IdProducto); //ST 15/07/2005

			return Resultado;
		}
		public static bool Update(System.Data.DataTable data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{ //Este método es llamado desde tsa_ComprobantesEx
			Hashtable tabCantVendXProd = new Hashtable(); //Tabla que agrupa las ventas por producto para actualizar una única vez en tlg_Stock			

			bool Resultado = true;
			tlg_MovimientosDeStockDataset datatipada = new tlg_MovimientosDeStockDataset();
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row= datatipada.tlg_MovimientosDeStock.Newtlg_MovimientosDeStockRow();	
			foreach ( System.Data.DataRow origen in data.Rows )
			{
				row.IdMovimientoDeStock= (string)origen["IdMovimientoDeStock"];
				row.IdProducto = (string)origen["IdProducto"];
				row.Cantidad = (decimal)origen["Cantidad"];

				row.IdDeposito = (string)origen["IdDeposito"];
				row.IdSeccion = (string)origen["IdSeccion"];
				row.IdEmpresa= (long)origen["IdEmpresa"];
				row.IdSucursal = (long)origen["IdSucursal"];


				row.FechaCreacion = (DateTime)origen["FechaCreacion"];
				row.IdConexionCreacion = (long)origen["IdConexionCreacion"];
				row.IdConexionUltimaModificacion= (long)origen["IdConexionUltimaModificacion"];
				row.IdReservado = (long)origen["IdReservado"];
				
				row.IdEstadoDeStockOrigen = Convert.ToString(origen["IdEstadoDeStockOrigen"]);
				row.IdEstadoDeStockDestino = Convert.ToString(origen["IdEstadoDeStockDestino"]);
				if (origen["IdTipoDeAjuste"] != System.DBNull.Value)
				{
					row.IdTipoDeAjuste = (string)origen["IdTipoDeAjuste"];
				}
				else
				{
					row.IdTipoDeAjuste = string.Empty;
				}
				AgregarProducto(origen, tabCantVendXProd);
				
				Resultado = Resultado && UpdateMovimientos(trx, row, replicacion);				
			}
			if (row != null)
			{
				if (! (row.IsNull("IdSucursal") || row.IsNull("IdEmpresa") || row.IsNull("IdProducto") ))
				{
					Resultado = Resultado && UpdateStock(trx, tabCantVendXProd, replicacion);
					Resultado = Resultado && ActualizarStock(trx,row.IdSucursal, row.IdEmpresa, row.IdProducto); //ST 15/07/2005
				}
			}

			return Resultado;
		}


		private static void AgregarProducto(DataRow item, Hashtable tabCantVendXProd) 
		{
			string IdProducto = (string)item["IdProducto"];		
			string IdEstadoDeStockOrigen = Convert.ToString(item["IdEstadoDeStockOrigen"]);
			string IdEstadoDeStockDestino = Convert.ToString(item["IdEstadoDeStockDestino"]);
			string IdDeposito = (string)item["IdDeposito"];
			string IdSeccion = (string)item["IdSeccion"];
			string IdEmpresa= item["IdEmpresa"].ToString();
			string IdSucursal = item["IdSucursal"].ToString();
			decimal Cantidad = (decimal)item["Cantidad"];

			string clave = IdProducto + ';' + IdEstadoDeStockOrigen + ';'+ IdEstadoDeStockDestino+';' + IdDeposito + ';' + IdSeccion + ';' + IdEmpresa + ';' + IdSucursal;
			if (tabCantVendXProd.Contains(clave)) 
			{				
				tabCantVendXProd[clave] = (decimal) tabCantVendXProd[clave] + Cantidad;
			}
			else 
			{
				tabCantVendXProd.Add(clave, Cantidad);
			}					 
		}

		#region Custom Members
		//Nuevo para replicacion
		private static SentenciasReplicacion _replicacion;
		public static SentenciasReplicacion Replicacion
		{
			get{return _replicacion;}
			set{_replicacion = value;}
		}
		#endregion

*/
		public static bool UpdateStockACero(tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row, string EstadoStockOrigen, string EstadoStockDestino, SentenciasReplicacion replicacion) 
		{ 
			//Update con el agregado que la cantidad a ajustar a cero la calcula dentro de la transacción.
			SqlConnection cnx = null;
			SqlTransaction trx = null;
			try
			{
				
				cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				trx = cnx.BeginTransaction( IsolationLevel.Serializable );

				//row.Cantidad = GetCantidad(row.IdProducto, row.IdDeposito, row.IdSeccion, row.IdEstadoDeStock, trx);
				mz.erp.dataaccess.tlg_MovimientosDeStock.Update(row.Table, trx, replicacion);
				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
				throw e;
			}
			finally 
			{
				cnx.Close();
			}
			return true;
		}
		/*

		public static bool Update(tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row, string EstadoStockOrigen, string EstadoStockDestino, SentenciasReplicacion replicacion) 
		{ 
			
			bool Resultado = true;
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

					
			//Resultado= UpdateMovimientos(trx, row, EstadoStockOrigen, EstadoStockDestino, ref IdSentenciaReplicacion);					
			Resultado= Update((System.Data.DataRow)row,  trx, replicacion);					
			if (Resultado) 
			{trx.Commit();}
			else 
			{trx.Rollback();}

			cnx.Close();			
			return Resultado;
		}
*/
		public static Decimal GetCantidad(string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, SqlTransaction trx) 
		{
			tlg_StockDataset.tlg_StockRow row = dataaccess.tlg_Stock.GetByPk(IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, trx);
			return (decimal) (-1) * row.Cantidad;
		}

		public static void RecomponerStock() 
		{		
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tlg_ActualizacionDeStock", dbhelper.Connection.GetConnection() );			
				cmd.Connection.Open();
				cmd.CommandType = CommandType.StoredProcedure;						
				cmd.ExecuteNonQuery();					
			}
			catch(Exception e)	{}
		}
		
/*
		public static bool UpdateStock(SqlTransaction trx, Hashtable tabCantVendXProd, SentenciasReplicacion replicacion) 
		{
			bool Resultado = true;
			string IdProducto = String.Empty;
			string IdEstadoDeStockOrigen = String.Empty;
			string IdEstadoDeStockDestino = String.Empty;
			string IdDeposito = String.Empty;
			string IdSeccion = String.Empty;
			long IdEmpresa= 0;
			long IdSucursal = 0;
			decimal Cantidad = 0;
			//Pendiente: 
			/*me queda probar que esté llegando bien la hashtable, que el split lo haga bien y que los
			campos idproducto, idestado de stock. etc se estén pasando bien en el case.
			Por último verificar que la información se pase bien a la BD.*/
			/*
			tlg_StockDataset.tlg_StockRow rowStock;
			foreach (DictionaryEntry d in tabCantVendXProd) 
			{				
				string[] CamposClave = d.Key.ToString().Split(';');
				ArrayList lista = new ArrayList(CamposClave);
				for (int i = 0; i < lista.Count; i++) 
				{ 
					switch (i)
					{						
						case 0: IdProducto = lista[i].ToString();
							break;
						case 1: IdEstadoDeStockOrigen = lista[i].ToString();
							break;
						case 2: IdEstadoDeStockDestino = lista[i].ToString();
							break;
						case 3: IdDeposito = lista[i].ToString();
							break;
						case 4: IdSeccion = lista[i].ToString();
							break;
						case 5: IdEmpresa = long.Parse(lista[i].ToString());
							break;
						case 6: IdSucursal = long.Parse(lista[i].ToString());
							break;
					}
				}
				Cantidad = (decimal) d.Value;

				#region Actualizo Stock Origen				
				if (IdEstadoDeStockOrigen != String.Empty && IdEstadoDeStockOrigen != null) 
				{
					//rowStock = tlg_Stock.GetByPk(IdProducto, IdDeposito, IdSeccion, IdEstadoDeStockOrigen);
					/*if (rowStock == null)
					{*/
				/*	rowStock = tlg_Stock.NewRow();
					rowStock.IdProducto = IdProducto;						
					//rowStock.Cantidad = Cantidad; Comentado por Oscar x lo siguiente:
					rowStock.Cantidad = - Cantidad;
					rowStock.IdDeposito = IdDeposito;
					rowStock.IdSeccion = IdSeccion;
					rowStock.IdEstadoDeStock = IdEstadoDeStockOrigen;
					rowStock.IdSucursal = IdSucursal;
					rowStock.IdEmpresa = IdEmpresa;
					/*}*/
					/*rowStock.Cantidad = rowStock.Cantidad - Cantidad;*/
				/*	tlg_Stock.Update(rowStock, trx,replicacion);
				}
				#endregion
				#region Actualizo Stock Destino
				if (IdEstadoDeStockDestino != String.Empty && IdEstadoDeStockDestino != null) 
				{
					/*rowStock = tlg_Stock.GetByPk(IdProducto, IdDeposito, IdSeccion, IdEstadoDeStockDestino);
					if (rowStock == null)
					{*/
				/*	rowStock = tlg_Stock.NewRow();
					rowStock.IdProducto = IdProducto;						
					//rowStock.Cantidad = Cantidad; //Habìa un 0. Puse cantidad porque no funcionaba el ajuste de stock.
					//Lo anterior comentado por Oscar para prueba x lo siguiente:
					rowStock.Cantidad = Cantidad;
					rowStock.IdDeposito = IdDeposito;
					rowStock.IdSeccion = IdSeccion;
					rowStock.IdEstadoDeStock = IdEstadoDeStockDestino;
					rowStock.IdSucursal = IdSucursal;
					rowStock.IdEmpresa = IdEmpresa;
					/*}					
					rowStock.Cantidad = rowStock.Cantidad + Cantidad;*/
				/*	tlg_Stock.Update(rowStock, trx, replicacion);
				}
				#endregion
			}
			return Resultado;
		}

		public static bool UpdateMovimientos(SqlTransaction trx, tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row, SentenciasReplicacion replicacion) 
		{
			bool Resultado = true;
			
			//tlg_StockDataset.tlg_StockRow rowStock;				
			#region Actualizo Movimiento Origen
			if (row.IdEstadoDeStockOrigen != String.Empty && row.IdEstadoDeStockOrigen  != null) 
			{								
				tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowMSorigen = tlg_MovimientosDeStock.NewRow();
				PasarCampos(row, rowMSorigen);			
				rowMSorigen.IdMovimientoDeStock = Util.NewStringId();
				rowMSorigen.Cantidad = - row.Cantidad;
				rowMSorigen.IdEstadoDeStockOrigen = row.IdEstadoDeStockOrigen;
				tlg_MovimientosDeStock.Update(rowMSorigen, trx, replicacion);
			}
			#endregion
			#region Actualizo Movimiento Destino
			if (row.IdEstadoDeStockDestino != String.Empty && row.IdEstadoDeStockDestino != null) 
			{
				tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowMSdestino = tlg_MovimientosDeStock.NewRow();
				PasarCampos(row, rowMSdestino);			
				rowMSdestino.IdMovimientoDeStock = Util.NewStringId();					
				rowMSdestino.Cantidad = + row.Cantidad;					
				rowMSdestino.IdEstadoDeStockOrigen = row.IdEstadoDeStockDestino;					
				tlg_MovimientosDeStock.Update(rowMSdestino, trx, replicacion);	
			}
			#endregion			
			
			return Resultado;
		}
	
		private static void PasarCampos(tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowOrigen, tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow rowDestino) 
		{			
			/*	foreach ( DataColumn dc in rowOrigen.Table.Columns ) 
				{
					rowDestino[dc] = rowOrigen[dc];				
				}*/
		/*	rowDestino.IdProducto = rowOrigen.IdProducto;
			rowDestino.IdDeposito = rowOrigen.IdDeposito;
			rowDestino.IdSeccion = rowOrigen.IdSeccion;
			rowDestino.IdTipoDeAjuste = rowOrigen.IdTipoDeAjuste;
			rowDestino.IdSucursal = rowOrigen.IdSucursal;
			rowDestino.IdEmpresa = rowOrigen.IdEmpresa;					
			rowDestino.IdConexionCreacion = rowOrigen.IdConexionCreacion;
			rowDestino.FechaCreacion = rowOrigen.FechaCreacion;
		}
		

		public static System.Data.DataTable GetMovimientosByIdProductoOrJerarquia(string IdProducto, string Jerarquia, DateTime desde, DateTime hasta)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStock_ByIdProductoOrJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if(IdProducto == "" || IdProducto == null)
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			if(Jerarquia == "" || Jerarquia == null)
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@desde", SqlDbType.DateTime ) );
			if(desde == DateTime.MinValue) cmd.Parameters[ "@desde" ].Value = System.DBNull.Value;
			else cmd.Parameters[ "@desde" ].Value = Util.GetStartDay(desde);
			cmd.Parameters.Add( new SqlParameter( "@hasta", SqlDbType.DateTime ) );
			if(hasta == DateTime.MinValue) cmd.Parameters[ "@hasta" ].Value = System.DBNull.Value;
			else cmd.Parameters[ "@hasta" ].Value = Util.GetEndDay(hasta);
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];
		}

		public static bool ActualizarStock( SqlTransaction trx, long idSucursal, long idEmpresa, string idProducto)
		{//ST 
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tsh_productosSucursales_UpdateDeStock");
				//cmd.Connection.Open();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = trx.Connection;
				cmd.Transaction = trx;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = idSucursal;
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = idEmpresa;
				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdProducto"].Value = idProducto;
				cmd.ExecuteNonQuery();
				
				return true;
			}
			
			catch(Exception e)
			{	

				;return false;}
		}
		*/

	/*	public static bool ActualizarStock(  long idSucursal, long idEmpresa, string idProducto)
		{
			
			SqlConnection connection = dbhelper.Connection.GetConnection();
			connection.Open();
			SqlTransaction trx = connection.BeginTransaction();
			try
			{
				bool result =  ActualizarStock(  trx,  idSucursal,  idEmpresa,idProducto);
				trx.Commit();
				return result;
			}
			catch(Exception e)
			{
				trx.Rollback();
				connection.Close();
				return false;
			}
		}
		/*
		public static void Update_Stock_Forced( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, decimal Cantidad)
		{
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_Update_Forced",dbhelper.Connection.GetConnection());
			cmd.Connection.Open();
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdProducto"].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdDeposito"].Value = IdDeposito;
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdSeccion"].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ));
			cmd.Parameters[ "@IdEstadoDeStock"].Value = IdEstadoDeStock;
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ));
			cmd.Parameters[ "@Cantidad"].Value = Cantidad;
			
			cmd.ExecuteNonQuery();

			StatementSQLForReplicationFactory.GetSqlStatement( cmd, Replicacion.Sentence);
			cmd.Connection.Close();
			
		}	
		*/
	}
}
