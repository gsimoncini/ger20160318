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

	public class tfi_VariablesAuxiliaresTDCompTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_VariablesAuxiliaresTDCompTesoreria()
		{
		}

		public static tfi_VariablesAuxiliaresTDCompTesoreriaDataset GetList()
		{
			tfi_VariablesAuxiliaresTDCompTesoreriaDataset data = new tfi_VariablesAuxiliaresTDCompTesoreriaDataset();

			return ( tfi_VariablesAuxiliaresTDCompTesoreriaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_VariablesAuxiliaresTDCompTesoreria" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_VariablesAuxiliaresTDCompTesoreria_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_VariablesAuxiliaresTDCompTesoreriaDataset GetList( string IdVariableAuxiliarTDCompTesoreria, string IdTDCompTesoreria, string Descripcion, string Tipo )
		{
			tfi_VariablesAuxiliaresTDCompTesoreriaDataset data = new tfi_VariablesAuxiliaresTDCompTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_VariablesAuxiliaresTDCompTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_VariablesAuxiliaresTDCompTesoreria_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariableAuxiliarTDCompTesoreria" ].Value = IdVariableAuxiliarTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Tipo" ].Value = Tipo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaRow NewRow()
		{
			return ( new tfi_VariablesAuxiliaresTDCompTesoreriaDataset() ).tfi_VariablesAuxiliaresTDCompTesoreria.Newtfi_VariablesAuxiliaresTDCompTesoreriaRow();
		}
	
		public static tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaRow GetByPk( string IdVariableAuxiliarTDCompTesoreria )
		{
			tfi_VariablesAuxiliaresTDCompTesoreriaDataset data = new tfi_VariablesAuxiliaresTDCompTesoreriaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_VariablesAuxiliaresTDCompTesoreria_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariableAuxiliarTDCompTesoreria" ].Value = IdVariableAuxiliarTDCompTesoreria;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_VariablesAuxiliaresTDCompTesoreria" );

			adapter.Fill( data );

			if ( data.tfi_VariablesAuxiliaresTDCompTesoreria.Rows.Count == 1 )
			{
				return ( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaRow )data.tfi_VariablesAuxiliaresTDCompTesoreria.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaDataTable )row.Table ).Addtfi_VariablesAuxiliaresTDCompTesoreriaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_VariablesAuxiliaresTDCompTesoreriaDataset dataSet )
		{
			Update( dataSet.tfi_VariablesAuxiliaresTDCompTesoreria );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaDataTable )dataTable, trx );
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
			Update( ( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_VariablesAuxiliaresTDCompTesoreriaDataset.tfi_VariablesAuxiliaresTDCompTesoreriaDataTable dataTable, SqlTransaction trx )
		{
		
			
				SqlDataAdapter adapter = new SqlDataAdapter();
			
				adapter.TableMappings.AddRange(
					new System.Data.Common.DataTableMapping[] {
																  new System.Data.Common.DataTableMapping( "Table", "tfi_VariablesAuxiliaresTDCompTesoreria", 
																  new System.Data.Common.DataColumnMapping[] {
																												 new System.Data.Common.DataColumnMapping( "IdVariableAuxiliarTDCompTesoreria", "IdVariableAuxiliarTDCompTesoreria" ),
																												 new System.Data.Common.DataColumnMapping( "IdTDCompTesoreria", "IdTDCompTesoreria" ),
																												 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																												 new System.Data.Common.DataColumnMapping( "Tipo", "Tipo" ),
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
			
				SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_VariablesAuxiliaresTDCompTesoreria_Update", trx.Connection );
				sqlCommandUpdate.Transaction = trx;
				sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVariableAuxiliarTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVariableAuxiliarTDCompTesoreria", DataRowVersion.Original, null ) );
			
				SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_VariablesAuxiliaresTDCompTesoreria_Delete", trx.Connection );
				sqlCommandDelete.Transaction = trx;
				sqlCommandDelete.CommandType = CommandType.StoredProcedure;
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariableAuxiliarTDCompTesoreria", DataRowVersion.Original, null ) );
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_VariablesAuxiliaresTDCompTesoreria_Insert", trx.Connection );
				sqlCommandInsert.Transaction = trx;
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariableAuxiliarTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
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

		
	}
}

