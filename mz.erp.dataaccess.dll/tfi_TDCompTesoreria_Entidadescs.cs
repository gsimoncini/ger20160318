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

	public class tfi_TDCompTesoreria_Entidades : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetListEx(string ListaTDCompTesoreria, bool Activo)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_Entidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar ) );
			if(ListaTDCompTesoreria == null || ListaTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters[ "@TDCompTesoreria" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@TDCompTesoreria" ].Value = ListaTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreria_EntidadesDataset GetByIdEntidad(string IdEntidad)
		{
			tfi_TDCompTesoreria_EntidadesDataset data = new tfi_TDCompTesoreria_EntidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_Entidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		#endregion
		
		public tfi_TDCompTesoreria_Entidades()
		{
		}

		public static tfi_TDCompTesoreria_EntidadesDataset GetList()
		{
			tfi_TDCompTesoreria_EntidadesDataset data = new tfi_TDCompTesoreria_EntidadesDataset();

			return ( tfi_TDCompTesoreria_EntidadesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_Entidades" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreria_EntidadesDataset GetList( string IdEntidad, string TDCompTesoreria, bool Activo, string Aux1, string Aux2 )
		{
			tfi_TDCompTesoreria_EntidadesDataset data = new tfi_TDCompTesoreria_EntidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_Entidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			cmd.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TDCompTesoreria" ].Value = TDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Aux1" ].Value = Aux1;
			cmd.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Aux2" ].Value = Aux2;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		public static tfi_TDCompTesoreria_EntidadesDataset GetList( string TDCompTesoreria)
		{
			return GetList(null, TDCompTesoreria, true, null , null);
		}

		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow NewRow()
		{
			return ( new tfi_TDCompTesoreria_EntidadesDataset() ).tfi_TDCompTesoreria_Entidades.Newtfi_TDCompTesoreria_EntidadesRow();
		}
	
		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow GetByPk( string IdEntidad, string TDCompTesoreria )
		{
			tfi_TDCompTesoreria_EntidadesDataset data = new tfi_TDCompTesoreria_EntidadesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			
			cmd.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TDCompTesoreria" ].Value = TDCompTesoreria;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_Entidades" );

			adapter.Fill( data );

			if ( data.tfi_TDCompTesoreria_Entidades.Rows.Count == 1 )
			{
				return ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow )data.tfi_TDCompTesoreria_Entidades.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable )row.Table ).Addtfi_TDCompTesoreria_EntidadesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable,trx);			
		}

		public static void Update( tfi_TDCompTesoreria_EntidadesDataset dataSet )
		{
			Update( dataSet.tfi_TDCompTesoreria_Entidades );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable )dataTable, trx );
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
			Update( ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_TDCompTesoreria_Entidades", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdEntidad", "IdEntidad" ),
																											 new System.Data.Common.DataColumnMapping( "TDCompTesoreria", "TDCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "Aux1", "Aux1" ),
																											 new System.Data.Common.DataColumnMapping( "Aux2", "Aux2" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEntidad", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TDCompTesoreria", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_TDCompTesoreria_Entidades_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TDCompTesoreria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_TDCompTesoreria_Entidades_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

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

