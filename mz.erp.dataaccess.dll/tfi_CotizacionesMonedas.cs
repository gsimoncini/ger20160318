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

	public class tfi_CotizacionesMonedas : IDisposable
	{
	
		#region Custom Members
		public static System.Data.DataSet GetCotizaciones (string IdMonedaReferencia)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "CotizacionActual" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMoneda_GetCotizacionActual", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaReferencia" ].Value = IdMonedaReferencia;

			adapter.SelectCommand = cmd;
			adapter.Fill( data, "CotizacionActual" );
			return  data ;
		}

		public static System.Data.DataRow GetValorCotizacion( string IdMonedaOrigen, string IdMonedaDestino, string IdFuenteDeCambio)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetValorCotizacion" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMoneda_GetValorCotizacion", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaOrigen" ].Value = IdMonedaOrigen;
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			if (data.Tables[0].Rows.Count > 0)
			{
				return data.Tables[0].Rows[0];
			}
			else
			{
				return null;
			}
		}
	
		public static void InsertWithValidation(  DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.RowUpdating+=new SqlRowUpdatingEventHandler(adapter_RowUpdating);
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_CotizacionesMonedas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionMoneda", "IdCotizacionMoneda" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaOrigen", "IdMonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaDestino", "IdMonedaDestino" ),
																											 new System.Data.Common.DataColumnMapping( "FechaDeCambioInicio", "FechaDeCambioInicio" ),
																											 new System.Data.Common.DataColumnMapping( "FechaDeCambioFin", "FechaDeCambioFin" ),
																											 new System.Data.Common.DataColumnMapping( "IdFuenteDeCambio", "IdFuenteDeCambio" ),
																											 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_CotizacionesMonedas_InsertWithValidation", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaDeCambioInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaDeCambioInicio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaDeCambioFin", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaDeCambioFin", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFuenteDeCambio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );



			#region Replicacion

			_replication = replication;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			/*adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;*/
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		private static SentenciasReplicacion _replication;
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
		#endregion
		
		public tfi_CotizacionesMonedas()
		{
		}

		public static tfi_CotizacionesMonedasDataset GetList()
		{
			tfi_CotizacionesMonedasDataset data = new tfi_CotizacionesMonedasDataset();

			return ( tfi_CotizacionesMonedasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_CotizacionesMonedas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMonedas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CotizacionesMonedasDataset GetList( string IdCotizacionMoneda, string IdMonedaOrigen, string IdMonedaDestino, DateTime FechaDeCambioInicio, DateTime FechaDeCambioFin, decimal Valor , string IdFuenteDeCambio)
		{
			tfi_CotizacionesMonedasDataset data = new tfi_CotizacionesMonedasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_CotizacionesMonedas" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMonedas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar ) );
			if(IdCotizacionMoneda != null && !IdCotizacionMoneda.Equals(string.Empty))
				cmd.Parameters[ "@IdCotizacionMoneda" ].Value = IdCotizacionMoneda;
			else
				cmd.Parameters[ "@IdCotizacionMoneda" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar ) );
			if(IdMonedaOrigen != null && !IdMonedaOrigen.Equals(string.Empty))
				cmd.Parameters[ "@IdMonedaOrigen" ].Value = IdMonedaOrigen;
			else
				cmd.Parameters[ "@IdMonedaOrigen" ].Value = System.DBNull.Value;

			
			
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			if(IdFuenteDeCambio != null && !IdFuenteDeCambio.Equals(string.Empty))
				cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;
			else
				cmd.Parameters[ "@IdFuenteDeCambio" ].Value = System.DBNull.Value;


			
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			if(IdMonedaDestino != null && !IdMonedaDestino.Equals(string.Empty))
				cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			else
				cmd.Parameters[ "@IdMonedaDestino" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@FechaDeCambioInicio", SqlDbType.DateTime ) );
			if(!FechaDeCambioInicio.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeCambioInicio" ].Value = FechaDeCambioInicio;
			else
				cmd.Parameters[ "@FechaDeCambioInicio" ].Value = System.DBNull.Value;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaDeCambioFin", SqlDbType.DateTime ) );
			if(!FechaDeCambioFin.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeCambioFin" ].Value = FechaDeCambioFin;
			else
				cmd.Parameters[ "@FechaDeCambioFin" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal ) );
			if(!Valor.Equals(decimal.MinValue))
				cmd.Parameters[ "@Valor" ].Value = Valor;
			else
				cmd.Parameters[ "@Valor" ].Value = System.DBNull.Value;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow NewRow()
		{
			return ( new tfi_CotizacionesMonedasDataset() ).tfi_CotizacionesMonedas.Newtfi_CotizacionesMonedasRow();
		}
	
		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow GetByPk( string IdCotizacionMoneda )
		{
			tfi_CotizacionesMonedasDataset data = new tfi_CotizacionesMonedasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMonedas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCotizacionMoneda" ].Value = IdCotizacionMoneda;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_CotizacionesMonedas" );

			adapter.Fill( data );

			if ( data.tfi_CotizacionesMonedas.Rows.Count == 1 )
			{
				return ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow )data.tfi_CotizacionesMonedas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable )row.Table ).Addtfi_CotizacionesMonedasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_CotizacionesMonedasDataset dataSet )
		{
			Update( dataSet.tfi_CotizacionesMonedas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable )dataTable, trx );
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
			Update( ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_CotizacionesMonedas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionMoneda", "IdCotizacionMoneda" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaOrigen", "IdMonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaDestino", "IdMonedaDestino" ),
																											 new System.Data.Common.DataColumnMapping( "FechaDeCambioInicio", "FechaDeCambioInicio" ),
																											 new System.Data.Common.DataColumnMapping( "FechaDeCambioFin", "FechaDeCambioFin" ),
																											 new System.Data.Common.DataColumnMapping( "IdFuenteDeCambio", "IdFuenteDeCambio" ),
																											 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_CotizacionesMonedas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaDeCambioInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaDeCambioInicio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaDeCambioFin", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaDeCambioFin", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFuenteDeCambio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCotizacionMoneda", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_CotizacionesMonedas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_CotizacionesMonedas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaDeCambioInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaDeCambioInicio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaDeCambioFin", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaDeCambioFin", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFuenteDeCambio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		private static void adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
		{
			foreach(SqlParameter param in e.Command.Parameters)
			{
				if (param.ParameterName == "@FechaDeCambioFin") 
				{
					if ( e.Row["FechaDeCambioFin"].Equals(DateTime.MinValue))
					{
						e.Command.Parameters[ "@FechaDeCambioFin" ].Value = System.DBNull.Value;
					}
				}
			}
		}
	}
}

