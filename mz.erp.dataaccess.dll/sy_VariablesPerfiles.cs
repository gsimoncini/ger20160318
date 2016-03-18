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

	public class sy_VariablesPerfiles : IDisposable
	{
	
		#region Custom Members

		//German 20090804
		public static void Update(string IdVariable, string Numero, long IdPerfil, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update(IdVariable, Numero, IdPerfil, trx );
		}
		public static void Update(string IdVariable, string Numero,long IdPerfil ,SqlTransaction trx)
		{

			try
			{
				sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "sy_Variables" );

				SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_UpdateComprobanteNumber", trx.Connection );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Transaction = trx;
			
				cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdVariable" ].Value = IdVariable;

				cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;

				cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
				cmd.Parameters[ "@Numero" ].Value = Numero;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
        

		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow GetByPk( string IdVariable, long IdPerfil, string IdTransaction )
		{
			sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_VariablesPerfiles" );

			adapter.Fill( data );

			if ( data.sy_VariablesPerfiles.Rows.Count == 1 )
			{
				return ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow )data.sy_VariablesPerfiles.Rows[ 0 ];
			}
			
			return null;
		}
		//Fin German 20090804



		public static sy_VariablesPerfilesDataset GetListByCola( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesPerfiles" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_SearchByCola", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
			{
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		
		public sy_VariablesPerfiles()
		{
		}

		public static sy_VariablesPerfilesDataset GetList()
		{
			sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();

			return ( sy_VariablesPerfilesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesPerfiles" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

        /* Silvina 20101021 - Tarea 902 */
        public static sy_VariablesPerfilesDataset GetListBy(string IdVariable)
        {
            sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "sy_VariablesPerfiles");

            SqlCommand cmd = new SqlCommand("Pr_sy_VariablesPerfiles_SearchBy", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdVariable", SqlDbType.VarChar));
            cmd.Parameters["@IdVariable"].Value = IdVariable;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }
        /* Fin Silvina */

		public static sy_VariablesPerfilesDataset GetList( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesPerfiles" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
			{
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow NewRow()
		{
			return ( new sy_VariablesPerfilesDataset() ).sy_VariablesPerfiles.Newsy_VariablesPerfilesRow();
		}
	
		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow GetByPk( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset data = new sy_VariablesPerfilesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesPerfiles_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_VariablesPerfiles" );

			adapter.Fill( data );

			if ( data.sy_VariablesPerfiles.Rows.Count == 1 )
			{
				return ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow )data.sy_VariablesPerfiles.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )row.Table ).Addsy_VariablesPerfilesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_VariablesPerfilesDataset dataSet )
		{
			Update( dataSet.sy_VariablesPerfiles );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )dataTable, trx );
				trx.Commit();
			}
			catch (Exception e)
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update( DataTable dataTable, string transaction )
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(transaction);
			Update( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )dataTable, trx );
		}

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )dataTable, trx );
		}
				
		public static void Update( DataTable dataTable, SqlTransaction trx, string IdCuentaObservacionTipoGenerado)
		{
			Update( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )dataTable, trx, IdCuentaObservacionTipoGenerado);
		}

		public static void Update( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_VariablesPerfiles", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdVariable", "IdVariable" ),
																											 new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
																											 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_VariablesPerfiles_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPerfil", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_VariablesPerfiles_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_VariablesPerfiles_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );

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

