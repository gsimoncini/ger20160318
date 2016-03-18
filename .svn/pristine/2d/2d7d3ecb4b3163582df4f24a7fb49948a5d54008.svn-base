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

	public class sy_Variables : IDisposable
	{
	
		#region Custom Members
		

		/*
		public static sy_VariablesDataset GetListByCola( string IdVariable )
		{
			sy_VariablesDataset data = new sy_VariablesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Variables" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_SearchByCola", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		*/
		public static void Update(string IdVariable, string Numero, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update(IdVariable, Numero, trx );
		}
		public static void Update(string IdVariable, string Numero, SqlTransaction trx)
		{

			try
			{
				sy_VariablesDataset data = new sy_VariablesDataset();
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "sy_Variables" );

				SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_UpdateComprobanteNumber", trx.Connection );
				cmd.Transaction = trx;
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdVariable" ].Value = IdVariable;

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
         	
		public static void Update(string IdVariable, string Numero , int n)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				sy_VariablesDataset data = new sy_VariablesDataset();
		
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "sy_Variables" );

				SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_UpdateComprobanteNumber", trx.Connection );
				cmd.Transaction = trx;
				cmd.CommandType = CommandType.StoredProcedure;
		
				cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdVariable" ].Value = IdVariable;

				cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
				cmd.Parameters[ "@Numero" ].Value = Numero;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}
	
		public static sy_VariablesDataset GetListByCola( string IdVariable )
		{
			sy_VariablesDataset data = new sy_VariablesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Variables" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_SearchByCola", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_VariablesDataset GetListByInicio( string IdVariable )
		{
			sy_VariablesDataset data = new sy_VariablesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Variables" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_SearchByInicio", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		

		#endregion
		
		public sy_Variables()
		{
		}

		public static sy_VariablesDataset GetList()
		{
			sy_VariablesDataset data = new sy_VariablesDataset();

			return ( sy_VariablesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Variables" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_VariablesDataset GetList( string IdVariable )
		{
			sy_VariablesDataset data = new sy_VariablesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Variables" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static sy_VariablesDataset.sy_VariablesRow NewRow()
		{
			return ( new sy_VariablesDataset() ).sy_Variables.Newsy_VariablesRow();
		}
	
		public static sy_VariablesDataset.sy_VariablesRow GetByPk( string IdVariable )
		{
            try
            {
                sy_VariablesDataset data = new sy_VariablesDataset();

                SqlCommand cmd = new SqlCommand("Pr_sy_Variables_GetByPk", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdVariable", SqlDbType.VarChar));
                cmd.Parameters["@IdVariable"].Value = IdVariable;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.TableMappings.Add("Table", "sy_Variables");

                adapter.Fill(data);

                if (data.sy_Variables.Rows.Count == 1)
                {
                    return (sy_VariablesDataset.sy_VariablesRow)data.sy_Variables.Rows[0];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
			
			return null;
		}

		public static sy_VariablesDataset.sy_VariablesRow GetByPk( string IdVariable, string IdTransaction)
		{
			sy_VariablesDataset data = new sy_VariablesDataset();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			SqlCommand cmd = new SqlCommand( "Pr_sy_Variables_GetByPk");
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_Variables" );

			adapter.Fill( data );

			if ( data.sy_Variables.Rows.Count == 1 )
			{
				return ( sy_VariablesDataset.sy_VariablesRow )data.sy_Variables.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_VariablesDataset.sy_VariablesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_VariablesDataset.sy_VariablesDataTable )row.Table ).Addsy_VariablesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_VariablesDataset dataSet )
		{
			Update( dataSet.sy_Variables );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_VariablesDataset.sy_VariablesDataTable )dataTable, trx );
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

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( sy_VariablesDataset.sy_VariablesDataTable )dataTable, trx );
		}
				
		public static void Update( sy_VariablesDataset.sy_VariablesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_Variables", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdVariable", "IdVariable" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "ValorDefault", "ValorDefault" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoVariable", "IdTipoVariable" ),
																											 new System.Data.Common.DataColumnMapping( "Categoria", "Categoria" ),
																											 new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_Variables_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorDefault", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoVariable", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoVariable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Categoria", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Categoria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVariable", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_Variables_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_Variables_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorDefault", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoVariable", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoVariable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Categoria", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Categoria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
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

