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

	public class sy_VariablesUsuarios : IDisposable
	{
	
		#region Custom Members
		public static sy_VariablesUsuariosDataset GetListByCola( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesUsuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesUsuarios_SearchByCola", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			if(IdUsuario.Equals(string.Empty))
				cmd.Parameters[ "@IdUsuario" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

        /* Silvina 20111230 - Tarea 0000245 */
        public static void Update(string IdVariable, string Numero, string IdUsuario, string IdTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            Update(IdVariable, Numero, IdUsuario, trx);
        }

        public static void Update(string IdVariable, string Numero, string IdUsuario, SqlTransaction trx)
        {

            try
            {
                sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "sy_Variables");

                SqlCommand cmd = new SqlCommand("Pr_sy_VariablesUsuarios_UpdateComprobanteNumber", trx.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Transaction = trx;

                cmd.Parameters.Add(new SqlParameter("@IdVariable", SqlDbType.VarChar));
                cmd.Parameters["@IdVariable"].Value = IdVariable;

                cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.VarChar));
                cmd.Parameters["@IdUsuario"].Value = IdUsuario;

                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.VarChar));
                cmd.Parameters["@Numero"].Value = Numero;
                adapter.SelectCommand = cmd;

                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow GetByPk(string IdVariable, string IdUsuario, string IdTransaction)
        {
            sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();

            SqlCommand cmd = new SqlCommand("Pr_sy_VariablesUsuarios_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            cmd.Connection = trx.Connection;
            cmd.Transaction = trx;

            cmd.Parameters.Add(new SqlParameter("@IdVariable", SqlDbType.VarChar));
            cmd.Parameters["@IdVariable"].Value = IdVariable;

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.VarChar));
            cmd.Parameters["@IdUsuario"].Value = IdUsuario;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "sy_VariablesUsuarios");

            adapter.Fill(data);

            if (data.sy_VariablesUsuarios.Rows.Count == 1)
            {
                return (sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow)data.sy_VariablesUsuarios.Rows[0];
            }

            return null;
        }

        /* Fin Silvina 20111230 - Tarea 0000245 */

		#endregion
		
		public sy_VariablesUsuarios()
		{
		}

		public static sy_VariablesUsuariosDataset GetList()
		{
			sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();

			return ( sy_VariablesUsuariosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesUsuarios" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesUsuarios_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_VariablesUsuariosDataset GetList( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_VariablesUsuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesUsuarios_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			if(IdUsuario.Equals(string.Empty))
				cmd.Parameters[ "@IdUsuario" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow NewRow()
		{
			return ( new sy_VariablesUsuariosDataset() ).sy_VariablesUsuarios.Newsy_VariablesUsuariosRow();
		}
	
		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow GetByPk( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset data = new sy_VariablesUsuariosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_VariablesUsuarios_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVariable" ].Value = IdVariable;
			
			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_VariablesUsuarios" );

			adapter.Fill( data );

			if ( data.sy_VariablesUsuarios.Rows.Count == 1 )
			{
				return ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow )data.sy_VariablesUsuarios.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable )row.Table ).Addsy_VariablesUsuariosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_VariablesUsuariosDataset dataSet )
		{
			Update( dataSet.sy_VariablesUsuarios );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable )dataTable, trx );
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
			Update( ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable )dataTable, trx );
		}
				

		public static void Update( sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_VariablesUsuarios", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdVariable", "IdVariable" ),
																											 new System.Data.Common.DataColumnMapping( "IdUsuario", "IdUsuario" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_VariablesUsuarios_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdUsuario", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_VariablesUsuarios_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_VariablesUsuarios_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVariable", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVariable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
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

