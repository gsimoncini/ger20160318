namespace mz.erp.dataaccess 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tlg_Stock : IDisposable
	{
	
		#region Custom Members		


		public static void Update( tlg_StockDataset.tlg_StockRow row, SqlTransaction trx, SentenciasReplicacion replicacion)
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_StockDataset.tlg_StockDataTable )row.Table ).Addtlg_StockRow( row );
			}
			
			Update( row.Table, trx, replicacion );
		}
		
		public static decimal GetList( string IdVisualizacionDeStock, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD)
		{			
			tlg_Stock_SearchExSumaDataset data = new tlg_Stock_SearchExSumaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SearchExSuma", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}

			cmd.Parameters.Add( new SqlParameter( "@IdSucursalD", SqlDbType.BigInt ) );
			if ( IdSucursalD == long.MinValue )
			{cmd.Parameters[ "@IdSucursalD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursalD" ].Value = IdSucursalD;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresaD", SqlDbType.BigInt ) );
			if ( IdEmpresaD == long.MinValue )
			{cmd.Parameters[ "@IdEmpresaD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresaD" ].Value = IdEmpresaD;}

			adapter.TableMappings.Add( "Table", "tlg_Stock_SearchExSuma" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data );
			//tlg_Stock_SearchExSumaDataset.tlg_Stock_SearchExSumaRow row = (tlg_Stock_SearchExSumaDataset.tlg_Stock_SearchExSumaRow) data.tlg_Stock_SearchExSuma.Rows[0];
			if (data.Tables[0].Rows.Count > 0)
			{
				if (data.Tables[0].Rows[0]["Suma"] != System.DBNull.Value)
				{
					return Convert.ToDecimal(data.Tables[0].Rows[0]["Suma"]);
				}
					
			}
			
			return 0;
								
		}		
		
		public static DataSet GetListVisualizacion( DataSet data,string ListaVisualizacionesDeStock,  string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD)
		{			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SearchExVisualizacion", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
			
			cmd.Parameters.Add( new SqlParameter( "@ListaVisualizacionesDeStock", SqlDbType.VarChar ) );
			if(ListaVisualizacionesDeStock == null || ListaVisualizacionesDeStock.Equals(string.Empty))
				cmd.Parameters[ "@ListaVisualizacionesDeStock" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@ListaVisualizacionesDeStock" ].Value = ListaVisualizacionesDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}

			cmd.Parameters.Add( new SqlParameter( "@IdSucursalD", SqlDbType.BigInt ) );
			if ( IdSucursalD == long.MinValue )
			{cmd.Parameters[ "@IdSucursalD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursalD" ].Value = IdSucursalD;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresaD", SqlDbType.BigInt ) );
			if ( IdEmpresaD == long.MinValue )
			{cmd.Parameters[ "@IdEmpresaD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresaD" ].Value = IdEmpresaD;}

			adapter.TableMappings.Add( "Table", "tlg_Stock_SearchExVisualizacion" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "Visualizacion_De_Stock");
			/*if (data.Tables[0].Rows[0][0] == System.DBNull.Value)
			{
				return null;
			}
			else 
			{*/
				return data;
			//}			
		}
		public static DataSet GetListEstado( DataSet data, string ListaVisualizacionesDeStock, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD)
		{						
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SearchExEstados", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;	
		
			cmd.Parameters.Add( new SqlParameter( "@ListaVisualizacionesDeStock", SqlDbType.VarChar ) );
			if(ListaVisualizacionesDeStock == null || ListaVisualizacionesDeStock.Equals(string.Empty))
				cmd.Parameters[ "@ListaVisualizacionesDeStock" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@ListaVisualizacionesDeStock" ].Value = ListaVisualizacionesDeStock;


			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}

			cmd.Parameters.Add( new SqlParameter( "@IdSucursalD", SqlDbType.BigInt ) );
			if ( IdSucursalD == long.MinValue )
			{cmd.Parameters[ "@IdSucursalD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursalD" ].Value = IdSucursalD;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresaD", SqlDbType.BigInt ) );
			if ( IdEmpresaD == long.MinValue )
			{cmd.Parameters[ "@IdEmpresaD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresaD" ].Value = IdEmpresaD;}

			adapter.TableMappings.Add( "Table", "tlg_Stock_SearchExEstados" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "Estados");
			return data;
		}

		public static DataSet GetListSucursal( DataSet data, string IdProducto, string IdDeposito, string IdSeccion, string IdVisualizacionDeStock, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD)			
		{						
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SearchExSuc", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
		
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;			

			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}

			cmd.Parameters.Add( new SqlParameter( "@IdSucursalD", SqlDbType.BigInt ) );
			if ( IdSucursalD == long.MinValue )
			{cmd.Parameters[ "@IdSucursalD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursalD" ].Value = IdSucursalD;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresaD", SqlDbType.BigInt ) );
			if ( IdEmpresaD == long.MinValue )
			{cmd.Parameters[ "@IdEmpresaD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresaD" ].Value = IdEmpresaD;}

			adapter.TableMappings.Add( "Table", "tlg_Stock_SearchExSuc" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "Sucursal");
			return data;
		}


		public static DataSet GetListStockSucursales( DataSet data, string IdProducto, string IdDeposito, string IdSeccion, string IdVisualizacionDeStock, string IdEstadoDeStock, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD)
		{						
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_SearchSucursales", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;

			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}

			cmd.Parameters.Add( new SqlParameter( "@IdSucursalD", SqlDbType.BigInt ) );
			if ( IdSucursalD == long.MinValue )
			{cmd.Parameters[ "@IdSucursalD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursalD" ].Value = IdSucursalD;}

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresaD", SqlDbType.BigInt ) );
			if ( IdEmpresaD == long.MinValue )
			{cmd.Parameters[ "@IdEmpresaD" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresaD" ].Value = IdEmpresaD;}

			adapter.TableMappings.Add( "Table", "Pr_tlg_Stock_SearchSucursales" );
			adapter.SelectCommand = cmd;		
			adapter.Fill(data);
			return data;
		}


		private static SentenciasReplicacion _replication;
		
		#endregion		
		
		public tlg_Stock()
		{
		}

		public static tlg_StockDataset GetList()
		{
			tlg_StockDataset data = new tlg_StockDataset();

			return ( tlg_StockDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Stock" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_StockDataset GetList( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa )
		{
			tlg_StockDataset data = new tlg_StockDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Stock" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{
				cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_StockDataset.tlg_StockRow NewRow()
		{
			return ( new tlg_StockDataset() ).tlg_Stock.Newtlg_StockRow();
		}

		public static tlg_StockDataset.tlg_StockRow GetByPk( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			tlg_StockDataset.tlg_StockRow _row=null;

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				_row = GetByPk( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, trx);
				trx.Commit();
			}
			catch
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
			return _row;
			
			

		}
		
	
		public static tlg_StockDataset.tlg_StockRow GetByPk( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, SqlTransaction trx )
		{
			tlg_StockDataset data = new tlg_StockDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_GetByPk");
			cmd.Transaction = trx;
			cmd.Connection = trx.Connection;
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_Stock" );

			adapter.Fill( data );

			if ( data.tlg_Stock.Rows.Count == 1 )
			{
				return ( tlg_StockDataset.tlg_StockRow )data.tlg_Stock.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_StockDataset.tlg_StockRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_StockDataset.tlg_StockDataTable )row.Table ).Addtlg_StockRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_StockDataset dataSet )
		{
			Update( dataSet.tlg_Stock );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			
			try
			{
				Update( ( tlg_StockDataset.tlg_StockDataTable )dataTable, trx );
				trx.Commit();
			}
			catch
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
			
		}

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			//Update( ( tlg_StockDataset.tlg_StockDataTable )dataTable, trx );
			
		}
		
		/// <summary>
		/// Actualiza el Stock: ATENCION NO UTILIZAR ESTA FUNCION DIRECTAMENTE, 
		/// HACERLO A TRAVES DE LA CLASE STOCK
		/// Este método sólo manda registros a tlg_Stock, el adaptador los recibe en modo de inserción.
		/// O sea, es necesario crear un NewRow en un tlg_Stock para enviar a este store SIEMPRE.
		/// Los comandos Update y Delete no estan habilitados ni en este capa ni en la BD.
		/// El store identifica si el registro existe y lo inserta o actualiza según sea necesario
		/// </summary>
		/// <param name="dataTable"></param>
		/// <param name="trx"></param>
		/// 



		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{
		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			
		}

		public static void Update( System.Data.DataTable dataTable, SqlTransaction trx ,SentenciasReplicacion replicacion)
		{
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_Stock", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdDeposito", "IdDeposito" ),
																											 new System.Data.Common.DataColumnMapping( "IdSeccion", "IdSeccion" ),
																											 new System.Data.Common.DataColumnMapping( "IdEstadoDeStock", "IdEstadoDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" )										 
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_Stock_Update", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEstadoDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			
/*

			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion
		*/

			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		
	}
}

