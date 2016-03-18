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

	public class tpu_NetosImpuestos : IDisposable
	{
	
		#region Custom Members

		public static tpu_NetosImpuestosDataset GetListEx( long IdNetoImpuestos, long IdNeto, string IdImpuesto, string IdTipoDeComprobante, bool Activo )
		{
			tpu_NetosImpuestosDataset data = new tpu_NetosImpuestosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt ) );
			if ( IdNetoImpuestos == long.MinValue )
			{
				cmd.Parameters[ "@IdNetoImpuestos" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdNetoImpuestos" ].Value = IdNetoImpuestos;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt ) );
			if ( IdNeto == long.MinValue )
			{
				cmd.Parameters[ "@IdNeto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdNeto" ].Value = IdNeto;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		public static DataTable GetListImpuestosAsociados(string IdTipoDeComprobante)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );
			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_SearchByTipoDeComprobante", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if ( IdTipoDeComprobante == null )
			{
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			}

			adapter.SelectCommand = cmd;
			adapter.Fill( data );
         
			return data.Tables[0];
		}

		public static DataTable GetListNetosAsociados(string IdTipoDeComprobante)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );
			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_SearchNetosByTipoDeComprobante", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if ( IdTipoDeComprobante == null )
			{
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			}

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data.Tables[0];
		}
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow GetByPk( long IdNeto, string IdImpuesto, string IdTipoDeComprobante)
		{
			tpu_NetosImpuestosDataset data = new tpu_NetosImpuestosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt ) );			
			cmd.Parameters[ "@IdNetoImpuestos" ].Value = System.DBNull.Value;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdNeto" ].Value = IdNeto;
			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
			adapter.SelectCommand = cmd;
			
			adapter.Fill( data );

			if ( data.tpu_NetosImpuestos.Rows.Count == 1 )
			{
				return ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow )data.tpu_NetosImpuestos.Rows[ 0 ];
			}
			
			return null;
		}
		
		#endregion
		
		public tpu_NetosImpuestos()
		{
		}

		public static tpu_NetosImpuestosDataset GetList()
		{
			tpu_NetosImpuestosDataset data = new tpu_NetosImpuestosDataset();

			return ( tpu_NetosImpuestosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_NetosImpuestosDataset GetList( long IdNetoImpuestos, long IdNeto, string IdImpuesto, string IdTipoDeComprobante, bool Activo )
		{
			tpu_NetosImpuestosDataset data = new tpu_NetosImpuestosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt ) );
			if ( IdNetoImpuestos == long.MinValue )
			{
				cmd.Parameters[ "@IdNetoImpuestos" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdNetoImpuestos" ].Value = IdNetoImpuestos;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt ) );
			if ( IdNeto == long.MinValue )
			{
				cmd.Parameters[ "@IdNeto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdNeto" ].Value = IdNeto;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow NewRow()
		{
			return ( new tpu_NetosImpuestosDataset() ).tpu_NetosImpuestos.Newtpu_NetosImpuestosRow();
		}
	
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow GetByPk( long IdNetoImpuestos )
		{
			tpu_NetosImpuestosDataset data = new tpu_NetosImpuestosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_NetosImpuestos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdNetoImpuestos" ].Value = IdNetoImpuestos;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_NetosImpuestos" );

			adapter.Fill( data );

			if ( data.tpu_NetosImpuestos.Rows.Count == 1 )
			{
				return ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow )data.tpu_NetosImpuestos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable )row.Table ).Addtpu_NetosImpuestosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_NetosImpuestosDataset dataSet )
		{
			Update( dataSet.tpu_NetosImpuestos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable )dataTable, trx );
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
			Update( ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_NetosImpuestos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdNetoImpuestos", "IdNetoImpuestos" ),
																											 new System.Data.Common.DataColumnMapping( "IdNeto", "IdNeto" ),
																											 new System.Data.Common.DataColumnMapping( "IdImpuesto", "IdImpuesto" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_NetosImpuestos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNetoImpuestos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNetoImpuestos", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNetoImpuestos", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_NetosImpuestos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNetoImpuestos", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_NetosImpuestos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNetoImpuestos", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNetoImpuestos", DataRowVersion.Current, null ) );

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

