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

	public class tfi_TDCompTesoreriasMonedasRecargos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_TDCompTesoreriasMonedasRecargos()
		{
		}

		public static tfi_TDCompTesoreriasMonedasRecargosDataset GetList()
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset data = new tfi_TDCompTesoreriasMonedasRecargosDataset();

			return ( tfi_TDCompTesoreriasMonedasRecargosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreriasMonedasRecargos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreriasMonedasRecargos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreriasMonedasRecargosDataset GetList( string IdTDCompTesoreria, string IdMoneda )
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset data = new tfi_TDCompTesoreriasMonedasRecargosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreriasMonedasRecargos" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreriasMonedasRecargos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;

            /* Silvina 20101026 - Tarea 902 */
            cmd.Parameters.Add(new SqlParameter("@IdMoneda", SqlDbType.VarChar));
            if (IdMoneda.Equals(string.Empty))
                cmd.Parameters["@IdMoneda"].Value = System.Convert.DBNull;
            else
                cmd.Parameters["@IdMoneda"].Value = IdMoneda;
			adapter.SelectCommand = cmd;
            /* Fin Silvina */
			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow NewRow()
		{
			return ( new tfi_TDCompTesoreriasMonedasRecargosDataset() ).tfi_TDCompTesoreriasMonedasRecargos.Newtfi_TDCompTesoreriasMonedasRecargosRow();
		}
	
		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow GetByPk( string IdFormaDePago )
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset data = new tfi_TDCompTesoreriasMonedasRecargosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreriasMonedasRecargos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdFormaDePago", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFormaDePago" ].Value = IdFormaDePago;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreriasMonedasRecargos" );

			adapter.Fill( data );

			if ( data.tfi_TDCompTesoreriasMonedasRecargos.Rows.Count == 1 )
			{
				return ( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow )data.tfi_TDCompTesoreriasMonedasRecargos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable )row.Table ).Addtfi_TDCompTesoreriasMonedasRecargosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset dataSet )
		{
			Update( dataSet.tfi_TDCompTesoreriasMonedasRecargos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable )dataTable, trx );
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
			Update( ( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_TDCompTesoreriasMonedasRecargos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdTDCompTesoreria", "IdTDCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "IdMoneda", "IdMoneda" ),
																											 new System.Data.Common.DataColumnMapping( "Recargo", "Recargo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdFormaDePago", "IdFormaDePago" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_TDCompTesoreriasMonedasRecargos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Recargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Recargo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFormaDePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFormaDePago", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdFormaDePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdFormaDePago", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_TDCompTesoreriasMonedasRecargos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdFormaDePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFormaDePago", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_TDCompTesoreriasMonedasRecargos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Recargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Recargo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFormaDePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFormaDePago", DataRowVersion.Current, null ) );

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

