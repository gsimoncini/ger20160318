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

	public class sy_AgrupVariables : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_AgrupVariables()
		{
		}

		public static sy_AgrupVariablesDataset GetList()
		{
			sy_AgrupVariablesDataset data = new sy_AgrupVariablesDataset();

			return ( sy_AgrupVariablesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_AgrupVariables" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_AgrupVariables_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		/*public static sy_AgrupVariablesDataset GetList(  )
		{
			sy_AgrupVariablesDataset data = new sy_AgrupVariablesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_AgrupVariables" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_AgrupVariables_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		*/
		public static sy_AgrupVariablesDataset.sy_AgrupVariablesRow NewRow()
		{
			return ( new sy_AgrupVariablesDataset() ).sy_AgrupVariables.Newsy_AgrupVariablesRow();
		}
	
		public static sy_AgrupVariablesDataset.sy_AgrupVariablesRow GetByPk( string IdVariable, string Jerarquia )
		{
			sy_AgrupVariablesDataset data = new sy_AgrupVariablesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_AgrupVariables_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_AgrupVariables" );

			adapter.Fill( data );

			if ( data.sy_AgrupVariables.Rows.Count == 1 )
			{
				return ( sy_AgrupVariablesDataset.sy_AgrupVariablesRow )data.sy_AgrupVariables.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_AgrupVariablesDataset.sy_AgrupVariablesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_AgrupVariablesDataset.sy_AgrupVariablesDataTable )row.Table ).Addsy_AgrupVariablesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_AgrupVariablesDataset dataSet )
		{
			Update( dataSet.sy_AgrupVariables );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_AgrupVariablesDataset.sy_AgrupVariablesDataTable )dataTable, trx );
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
			Update( ( sy_AgrupVariablesDataset.sy_AgrupVariablesDataTable )dataTable, trx );
		}
				

		public static void Update( sy_AgrupVariablesDataset.sy_AgrupVariablesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_AgrupVariables", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdVariable", "IdVariable" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
																											 new System.Data.Common.DataColumnMapping( "Ayuda", "Ayuda" ),
																											 new System.Data.Common.DataColumnMapping( "Ejemplo", "Ejemplo" ),
																											 new System.Data.Common.DataColumnMapping( "MenuAfectado", "MenuAfectado" ),
																											 new System.Data.Common.DataColumnMapping( "VarRelacionadas", "VarRelacionadas" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_AgrupVariables_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ayuda", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ayuda", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ejemplo", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ejemplo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MenuAfectado", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MenuAfectado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@VarRelacionadas", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "VarRelacionadas", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldJerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Jerarquia", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_AgrupVariables_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_AgrupVariables_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ayuda", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ayuda", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ejemplo", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ejemplo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MenuAfectado", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MenuAfectado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@VarRelacionadas", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "VarRelacionadas", DataRowVersion.Current, null ) );
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
