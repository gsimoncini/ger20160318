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

	public class tlg_TiposComprobantesOrigenDestino : IDisposable
	{
	
		#region Custom Members

		public static long GetMomento( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino )
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_SearchEx", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar ) );
			if ( IdTipoComprobanteOrigen == String.Empty )
			{
				cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = IdTipoComprobanteOrigen;
			}			

			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar ) );
			if ( IdTipoComprobanteDestino == String.Empty )
			{
				cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = IdTipoComprobanteDestino;
			}			

			cmd.Parameters.Add( new SqlParameter( "@IdMomento", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdMomento" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;

			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );

			adapter.Fill( data );

			if (data.Tables[0].Rows.Count > 0)
			{
				if (data.Tables[0].Rows[0]["IdMomento"] != System.DBNull.Value)
				{
					return Convert.ToInt64(data.Tables[0].Rows[0]["IdMomento"]);
				}					
			}			
			return 0;
		}		
		#endregion
		
		public tlg_TiposComprobantesOrigenDestino()
		{
		}

		public static tlg_TiposComprobantesOrigenDestinoDataset GetList()
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();

			return ( tlg_TiposComprobantesOrigenDestinoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		public static tlg_TiposComprobantesOrigenDestinoDataset GetList( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino, long IdTarea, long IdProceso)
		{

			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			if (IdTipoComprobanteOrigen == String.Empty) 
			{
				IdTipoComprobanteOrigen = null;
			}		
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = IdTipoComprobanteOrigen;

			
			if (IdTipoComprobanteDestino == String.Empty) 
			{
				IdTipoComprobanteDestino = null;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = IdTipoComprobanteDestino;

			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
			{
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			}
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}

		public static tlg_TiposComprobantesOrigenDestinoDataset GetListEx( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino, long IdTarea, long IdProceso)
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			if (IdTipoComprobanteOrigen == String.Empty) 
			{
				IdTipoComprobanteOrigen = null;
			}		
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = IdTipoComprobanteOrigen;

			
			if (IdTipoComprobanteDestino == String.Empty) 
			{
				IdTipoComprobanteDestino = null;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = IdTipoComprobanteDestino;

			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
			{
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			}
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}

		public static tlg_TiposComprobantesOrigenDestinoDataset GetList( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino, long IdMomento, long IdSucursal, long IdEmpresa)
		{
			
			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = IdTipoComprobanteOrigen ;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = IdTipoComprobanteDestino ;
			cmd.Parameters.Add( new SqlParameter( "@IdMomento", SqlDbType.BigInt ) ) ;
			if ( IdMomento == long.MinValue )
			{
				cmd.Parameters[ "@IdMomento" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdMomento" ].Value = IdMomento;
			}

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
			try 
			{
				adapter.Fill( data );
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.Message.ToString());				
			}

			
         
			return data;
		}

		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow NewRow()
		{
			return ( new tlg_TiposComprobantesOrigenDestinoDataset() ).tlg_TiposComprobantesOrigenDestino.Newtlg_TiposComprobantesOrigenDestinoRow();
		}
	
		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow GetByPk( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino )
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = new tlg_TiposComprobantesOrigenDestinoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar ) );
			if (IdTipoComprobanteOrigen == null)
			{
				cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoComprobanteOrigen" ].Value = IdTipoComprobanteOrigen;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobanteDestino" ].Value = IdTipoComprobanteDestino;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_TiposComprobantesOrigenDestino" );
			try
			{
				adapter.Fill( data );
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.ToString());
			}

			if ( data.tlg_TiposComprobantesOrigenDestino.Rows.Count == 1 )
			{
				return ( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow )data.tlg_TiposComprobantesOrigenDestino.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable )row.Table ).Addtlg_TiposComprobantesOrigenDestinoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset dataSet )
		{
			Update( dataSet.tlg_TiposComprobantesOrigenDestino );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable )dataTable, trx );
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
			Update( ( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable )dataTable, trx );
		}
				

		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_TiposComprobantesOrigenDestino", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdTipoComprobanteOrigen", "IdTipoComprobanteOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoComprobanteDestino", "IdTipoComprobanteDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdMomento", "IdMomento" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "OldIdMomento", "OldIdMomento" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMomento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMomento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMomento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OldIdMomento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoComprobanteDestino", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_TiposComprobantesOrigenDestino_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteDestino", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_TiposComprobantesOrigenDestino_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMomento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMomento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OldIdMomento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OldIdMomento", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		
	}
}

