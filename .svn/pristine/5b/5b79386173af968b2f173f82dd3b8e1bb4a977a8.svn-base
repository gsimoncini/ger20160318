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

	public class tfi_ControlDeCajasFamiliasComprobanteTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_ControlDeCajasFamiliasComprobanteTesoreria()
		{
		}

		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset GetList()
		{
			tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset data = new tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset();

			return ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_ControlDeCajasFamiliasComprobanteTesoreria" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset GetList( string IdControlDeCajasFamiliasComprobanteTesoreria, string Descripcion, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset data = new tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_ControlDeCajasFamiliasComprobanteTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdControlDeCajasFamiliasComprobanteTesoreria" ].Value = IdControlDeCajasFamiliasComprobanteTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			if ( IdConexionCreacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			if ( IdConexionUltimaModificacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow NewRow()
		{
			return ( new tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset() ).tfi_ControlDeCajasFamiliasComprobanteTesoreria.Newtfi_ControlDeCajasFamiliasComprobanteTesoreriaRow();
		}
	
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow GetByPk( string IdControlDeCajasFamiliasComprobanteTesoreria )
		{
			tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset data = new tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdControlDeCajasFamiliasComprobanteTesoreria" ].Value = IdControlDeCajasFamiliasComprobanteTesoreria;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_ControlDeCajasFamiliasComprobanteTesoreria" );

			adapter.Fill( data );

			if ( data.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Rows.Count == 1 )
			{
				return ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow )data.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable )row.Table ).Addtfi_ControlDeCajasFamiliasComprobanteTesoreriaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset dataSet )
		{
			Update( dataSet.tfi_ControlDeCajasFamiliasComprobanteTesoreria );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable )dataTable, trx );
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
			Update( ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_ControlDeCajasFamiliasComprobanteTesoreria", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdControlDeCajasFamiliasComprobanteTesoreria", "IdControlDeCajasFamiliasComprobanteTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdControlDeCajasFamiliasComprobanteTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdControlDeCajasFamiliasComprobanteTesoreria", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdControlDeCajasFamiliasComprobanteTesoreria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_ControlDeCajasFamiliasComprobanteTesoreria_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdControlDeCajasFamiliasComprobanteTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdControlDeCajasFamiliasComprobanteTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
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

