

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tpu_ComprobantesDet.
	/// </summary>
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_ComprobantesDet : IDisposable
	{
	
		#region Custom Members

		private static SentenciasReplicacion _replication;
		
		public static tpu_ComprobantesDetDataset ComprobantesPendientesDet( string IdComprobante, long Ordinal, string IdProducto)
		{			
			
				tpu_ComprobantesDetDataset data = new tpu_ComprobantesDetDataset();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPendientesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection.Open();

				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if (IdComprobante =="" || IdComprobante == null) 
					cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				if (Ordinal == long.MinValue)
				{
					cmd.Parameters[ "@Ordinal"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@Ordinal"].Value = Ordinal;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto=="" || IdProducto == null)
					cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tpu_ComprobantesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			
			
		}
	

		#endregion
		
		public tpu_ComprobantesDet()
		{
		}

		public static tpu_ComprobantesDetDataset GetList()
		{
			tpu_ComprobantesDetDataset data = new tpu_ComprobantesDetDataset();

			return ( tpu_ComprobantesDetDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDet" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDet_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesDetDataset GetList( string IdComprobante,  string IdProducto, long Ordinal )
		{
			tpu_ComprobantesDetDataset data = new tpu_ComprobantesDetDataset();
			data = (tpu_ComprobantesDetDataset)GetList( (System.Data.DataSet)data, IdComprobante, IdProducto, Ordinal);
			return data;
		}
		
		public static System.Data.DataSet GetList( System.Data.DataSet data, string IdComprobante, string IdProducto, long Ordinal )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDet" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDet_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if(IdProducto.Equals(string.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			if (Ordinal == long.MinValue)
			{
				cmd.Parameters[ "@Ordinal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			}

			adapter.SelectCommand = cmd;
			
			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow NewRow()
		{
			return ( new tpu_ComprobantesDetDataset() ).tpu_ComprobantesDet.Newtpu_ComprobantesDetRow();
		}
	
		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow GetByPk( string IdComprobante, long Ordinal )
		{
			tpu_ComprobantesDetDataset data = new tpu_ComprobantesDetDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDet_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDet" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesDet.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow )data.tpu_ComprobantesDet.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable )row.Table ).Addtpu_ComprobantesDetRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ComprobantesDetDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesDet );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable )dataTable, trx );
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

		public static void Update( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable dataTable, SqlTransaction trx )		
		{
			//string IdSentenciaReplicacion = "-1";
			//Update( ( System.Data.DataTable )dataTable, trx, ref IdSentenciaReplicacion);
		}

		public static void Update( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable dataTable, string IdTransaction ,  SentenciasReplicacion replicacion)		
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update( ( System.Data.DataTable )dataTable, trx, replicacion);
		}


		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{
		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			
		}
				

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesDet", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCosto", "PrecioDeCosto" ),
																											 new System.Data.Common.DataColumnMapping( "ImpuestosDirectos", "ImpuestosDirectos" ),
																											 new System.Data.Common.DataColumnMapping( "ImpuestosIndirectos", "ImpuestosIndirectos" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaOrigen", "IdMonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierre", "IdMonedaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionCierre", "IdCotizacionCierre" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "ValorCotizacionProveedor", "ValorCotizacionProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "Estado", "Estado" ),
																											 new System.Data.Common.DataColumnMapping( "Bonificacion1MonedaOrigen", "Bonificacion1MonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "Bonificacion2MonedaOrigen", "Bonificacion2MonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "Bonificacion3MonedaOrigen", "Bonificacion3MonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "Bonificacion4MonedaOrigen", "Bonificacion4MonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "Bonificacion5MonedaOrigen", "Bonificacion5MonedaOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeBonificacion1", "PorcentajeBonificacion1" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeBonificacion2", "PorcentajeBonificacion2" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeBonificacion3", "PorcentajeBonificacion3" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeBonificacion4", "PorcentajeBonificacion4" ),
																											 new System.Data.Common.DataColumnMapping( "PorcentajeBonificacion5", "PorcentajeBonificacion5" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoNetoMonedaOrigen", "PrecioDeCostoNetoMonedaOrigen" ),
															  												 new System.Data.Common.DataColumnMapping( "PrecioDeCostoMonedaOrigen", "PrecioDeCostoMonedaOrigen" ),

																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesDet_Update", trx.Connection);
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCosto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCosto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ImpuestosDirectos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ImpuestosDirectos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ImpuestosIndirectos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ImpuestosIndirectos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorCotizacionProveedor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ValorCotizacionProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bonificacion1MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion1MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bonificacion2MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion2MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bonificacion3MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion3MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bonificacion4MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion4MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bonificacion5MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion5MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoNetoMonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoNetoMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoMonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Estado", DataRowVersion.Current, null ) );
			

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesDet_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesDet_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCosto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCosto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ImpuestosDirectos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ImpuestosDirectos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ImpuestosIndirectos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ImpuestosIndirectos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorCotizacionProveedor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ValorCotizacionProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bonificacion1MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion1MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bonificacion2MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion2MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bonificacion3MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion3MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bonificacion4MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion4MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bonificacion5MonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Bonificacion5MonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PorcentajeBonificacion5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorcentajeBonificacion5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoNetoMonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoNetoMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoMonedaOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoMonedaOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Estado", DataRowVersion.Current, null ) );
			

			
			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			
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
