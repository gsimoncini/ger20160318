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

	public class tpu_ComprobantesImpuestos : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetListEx( string IdComprobante, long IdNeto, string IdImpuesto, decimal ValorNeto, decimal ValorImpuesto, decimal PorcentajeAplicado )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesImpuestosEx" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
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

			cmd.Parameters.Add( new SqlParameter( "@ValorNeto", SqlDbType.Decimal ) );
			if ( ValorNeto == decimal.MinValue )
			{
				cmd.Parameters[ "@ValorNeto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@ValorNeto" ].Value = ValorNeto;
			}			

			cmd.Parameters.Add( new SqlParameter( "@ValorImpuesto", SqlDbType.Decimal ) );
			if ( ValorImpuesto == decimal.MinValue )
			{
				cmd.Parameters[ "@ValorImpuesto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@ValorImpuesto" ].Value = ValorImpuesto;
			}	

			
			cmd.Parameters.Add( new SqlParameter( "@PorcentajeAplicado", SqlDbType.Decimal ) );
			if ( PorcentajeAplicado == decimal.MinValue )
			{
				cmd.Parameters[ "@PorcentajeAplicado" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@PorcentajeAplicado" ].Value = PorcentajeAplicado;
			}	
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}	
		#endregion
		
		public tpu_ComprobantesImpuestos()
		{
		}

		public static tpu_ComprobantesImpuestosDataset GetList()
		{
			tpu_ComprobantesImpuestosDataset data = new tpu_ComprobantesImpuestosDataset();

			return ( tpu_ComprobantesImpuestosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesImpuestos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesImpuestosDataset GetList( string IdComprobante, long IdNeto, string IdImpuesto, decimal ValorNeto, decimal ValorImpuesto, decimal PorcentajeAplicado )
		{
			tpu_ComprobantesImpuestosDataset data = new tpu_ComprobantesImpuestosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesImpuestos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
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

			cmd.Parameters.Add( new SqlParameter( "@ValorNeto", SqlDbType.Decimal ) );
			if ( ValorNeto == decimal.MinValue )
			{
				cmd.Parameters[ "@ValorNeto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@ValorNeto" ].Value = ValorNeto;
			}			

			cmd.Parameters.Add( new SqlParameter( "@ValorImpuesto", SqlDbType.Decimal ) );
			if ( ValorImpuesto == decimal.MinValue )
			{
				cmd.Parameters[ "@ValorImpuesto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@ValorImpuesto" ].Value = ValorImpuesto;
			}	

			
			cmd.Parameters.Add( new SqlParameter( "@PorcentajeAplicado", SqlDbType.Decimal ) );
			if ( PorcentajeAplicado == decimal.MinValue )
			{
				cmd.Parameters[ "@PorcentajeAplicado" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@PorcentajeAplicado" ].Value = PorcentajeAplicado;
			}	
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow NewRow()
		{
			return ( new tpu_ComprobantesImpuestosDataset() ).tpu_ComprobantesImpuestos.Newtpu_ComprobantesImpuestosRow();
		}
	
		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow GetByPk( string IdComprobante, long IdNeto, string IdImpuesto )
		{
			tpu_ComprobantesImpuestosDataset data = new tpu_ComprobantesImpuestosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdNeto" ].Value = IdNeto;
			
			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesImpuestos" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesImpuestos.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow )data.tpu_ComprobantesImpuestos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosDataTable )row.Table ).Addtpu_ComprobantesImpuestosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( DataTable dataTable, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx);
		}
		

		public static void Update( tpu_ComprobantesImpuestosDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesImpuestos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosDataTable )dataTable, trx );
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
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesImpuestos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdNeto", "IdNeto" ),
																											 new System.Data.Common.DataColumnMapping( "IdImpuesto", "IdImpuesto" ),
																											 new System.Data.Common.DataColumnMapping( "ValorNeto", "ValorNeto" ),
																											 new System.Data.Common.DataColumnMapping( "ValorImpuesto", "ValorImpuesto" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeAplicado", "PorcentajeAplicado" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorImpuesto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorImpuesto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeAplicado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PorcentajeAplicado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNeto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdImpuesto", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesImpuestos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNeto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesImpuestos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNeto", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorImpuesto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorImpuesto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeAplicado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PorcentajeAplicado", DataRowVersion.Current, null ) );
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

