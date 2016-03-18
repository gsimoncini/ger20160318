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

	public class tsy_TiposAgrupamiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_TiposAgrupamiento()
		{
		}

		public static tsy_TiposAgrupamientoDataset GetList()
		{
			tsy_TiposAgrupamientoDataset data = new tsy_TiposAgrupamientoDataset();

			return ( tsy_TiposAgrupamientoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_TiposAgrupamiento" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_TiposAgrupamiento_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow NewRow()
		{
			return ( new tsy_TiposAgrupamientoDataset() ).tsy_TiposAgrupamiento.Newtsy_TiposAgrupamientoRow();
		}
	
		public static tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow GetByPk( long IdTipoAgrup )
		{
			tsy_TiposAgrupamientoDataset data = new tsy_TiposAgrupamientoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsy_TiposAgrupamiento_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoAgrup", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTipoAgrup" ].Value = IdTipoAgrup;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsy_TiposAgrupamiento" );

			adapter.Fill( data );

			if ( data.tsy_TiposAgrupamiento.Rows.Count == 1 )
			{
				return ( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow )data.tsy_TiposAgrupamiento.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable )row.Table ).Addtsy_TiposAgrupamientoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsy_TiposAgrupamientoDataset dataSet )
		{
			Update( dataSet.tsy_TiposAgrupamiento );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable )dataTable, trx );
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
			Update( ( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable )dataTable, trx );
		}
				

		public static void Update( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsy_TiposAgrupamiento", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdTipoAgrup", "IdTipoAgrup" ),
							new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
							new System.Data.Common.DataColumnMapping( "Categoria", "Categoria" ),
							new System.Data.Common.DataColumnMapping( "Estilo", "Estilo" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsy_TiposAgrupamiento_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoAgrup", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoAgrup", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Categoria", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Categoria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Estilo", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Estilo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoAgrup", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoAgrup", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsy_TiposAgrupamiento_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoAgrup", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoAgrup", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_TiposAgrupamiento_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Categoria", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Categoria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Estilo", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Estilo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoAgrup", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoAgrup", DataRowVersion.Current, null ) );

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

