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

	public class tsa_FacturasImpagas : IDisposable
	{
	
		#region Custom Members
		public static void GenerarListadoFacturasImpagas( )
		{
			tsa_FacturasImpagasDataset data = new tsa_FacturasImpagasDataset();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_FacturasImpagas" );			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_FacturasImpagas_GenerarListadoFacturasImpagas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
		}
		
		public static tsa_FacturasImpagasDataset GetList( string TiposDeComprobantes, string IdCuenta, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, bool PeriodosPorFechaEmision, int Periodo, bool PeriodosEnDias, bool PeriodosEnSemanas, bool PeriodosEnMeses, bool MostrarElResto)
		{
			tsa_FacturasImpagasDataset data = new tsa_FacturasImpagasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			//adapter.TableMappings.Add( "Table", "tsa_FacturasImpagas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_FacturasImpagas_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@TiposComprobantes", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TiposComprobantes" ].Value = TiposDeComprobantes;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if(IdCuenta == null || IdCuenta.Equals(string.Empty))
				cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ) );
			if(EmisionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@EmisionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@EmisionDesde" ].Value = EmisionDesde;
			
			cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ) );
			if(EmisionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@EmisionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@EmisionHasta" ].Value = EmisionHasta;

			cmd.Parameters.Add( new SqlParameter( "@VencimientoDesde", SqlDbType.DateTime ) );
			if(VencimientoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@VencimientoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@VencimientoDesde" ].Value = VencimientoDesde;

			cmd.Parameters.Add( new SqlParameter( "@VencimientoHasta", SqlDbType.DateTime ) );
			if(VencimientoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@VencimientoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@VencimientoHasta" ].Value = VencimientoHasta;

			cmd.Parameters.Add( new SqlParameter( "@PeriodosPorFechaEmision", SqlDbType.Bit ) );
			cmd.Parameters[ "@PeriodosPorFechaEmision" ].Value = PeriodosPorFechaEmision;
			
			cmd.Parameters.Add( new SqlParameter( "@Periodo", SqlDbType.Int ) );
			cmd.Parameters[ "@Periodo" ].Value = Periodo;

			cmd.Parameters.Add( new SqlParameter( "@PeriodosEnDias", SqlDbType.Bit ) );
			cmd.Parameters[ "@PeriodosEnDias" ].Value = PeriodosEnDias;

			cmd.Parameters.Add( new SqlParameter( "@PeriodosEnSemanas", SqlDbType.Bit ) );
			cmd.Parameters[ "@PeriodosEnSemanas" ].Value = PeriodosEnSemanas;

			cmd.Parameters.Add( new SqlParameter( "@PeriodosEnMeses", SqlDbType.Bit ) );
			cmd.Parameters[ "@PeriodosEnMeses" ].Value = PeriodosEnMeses;

			cmd.Parameters.Add( new SqlParameter( "@MostrarElResto", SqlDbType.Bit ) );
			cmd.Parameters[ "@MostrarElResto" ].Value = MostrarElResto;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		
		public tsa_FacturasImpagas()
		{
		}

		public static tsa_FacturasImpagasDataset GetList()
		{
			tsa_FacturasImpagasDataset data = new tsa_FacturasImpagasDataset();

			return ( tsa_FacturasImpagasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_FacturasImpagas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_FacturasImpagas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_FacturasImpagasDataset GetList( string IdCuenta, string IdComprobante, string IdTipoDeComprobante, DateTime FechaEmision, DateTime FechaVencimiento, string Vendedores, decimal Total, decimal SaldoFactura, string IdTiposComprobantesPredecesores, string IdOrdenReparaciones, decimal SaldoCtaCte, decimal SaldoCtaCteDV, decimal SaldoCtaCteConsolidado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			tsa_FacturasImpagasDataset data = new tsa_FacturasImpagasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_FacturasImpagas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_FacturasImpagas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@FechaEmision", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaEmision" ].Value = FechaEmision;
			cmd.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaVencimiento" ].Value = FechaVencimiento;
			cmd.Parameters.Add( new SqlParameter( "@Vendedores", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Vendedores" ].Value = Vendedores;
			cmd.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Total" ].Value = Total;
			cmd.Parameters.Add( new SqlParameter( "@SaldoFactura", SqlDbType.Decimal ) );
			cmd.Parameters[ "@SaldoFactura" ].Value = SaldoFactura;
			cmd.Parameters.Add( new SqlParameter( "@IdTiposComprobantesPredecesores", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTiposComprobantesPredecesores" ].Value = IdTiposComprobantesPredecesores;
			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparaciones", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdOrdenReparaciones" ].Value = IdOrdenReparaciones;
			cmd.Parameters.Add( new SqlParameter( "@SaldoCtaCte", SqlDbType.Decimal ) );
			cmd.Parameters[ "@SaldoCtaCte" ].Value = SaldoCtaCte;
			cmd.Parameters.Add( new SqlParameter( "@SaldoCtaCteDV", SqlDbType.Decimal ) );
			cmd.Parameters[ "@SaldoCtaCteDV" ].Value = SaldoCtaCteDV;
			cmd.Parameters.Add( new SqlParameter( "@SaldoCtaCteConsolidado", SqlDbType.Decimal ) );
			cmd.Parameters[ "@SaldoCtaCteConsolidado" ].Value = SaldoCtaCteConsolidado;
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

		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow NewRow()
		{
			return ( new tsa_FacturasImpagasDataset() ).tsa_FacturasImpagas.Newtsa_FacturasImpagasRow();
		}
	
		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow GetByPk( string IdCuenta, string IdComprobante )
		{
			tsa_FacturasImpagasDataset data = new tsa_FacturasImpagasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_FacturasImpagas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_FacturasImpagas" );

			adapter.Fill( data );

			if ( data.tsa_FacturasImpagas.Rows.Count == 1 )
			{
				return ( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow )data.tsa_FacturasImpagas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable )row.Table ).Addtsa_FacturasImpagasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_FacturasImpagasDataset dataSet )
		{
			Update( dataSet.tsa_FacturasImpagas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable )dataTable, trx );
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
			Update( ( tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_FacturasImpagas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "Cuenta", "Cuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "TipoDeComprobante", "TipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "FechaEmision", "FechaEmision" ),
																											 new System.Data.Common.DataColumnMapping( "FechaVencimiento", "FechaVencimiento" ),
																											 new System.Data.Common.DataColumnMapping( "Vendedores", "Vendedores" ),
																											 new System.Data.Common.DataColumnMapping( "Total", "Total" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoFactura", "SaldoFactura" ),
																											 new System.Data.Common.DataColumnMapping( "IdTiposComprobantesPredecesores", "IdTiposComprobantesPredecesores" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparaciones", "IdOrdenReparaciones" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoCtaCte", "SaldoCtaCte" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoCtaCteDV", "SaldoCtaCteDV" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoCtaCteConsolidado", "SaldoCtaCteConsolidado" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_FacturasImpagas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cuenta", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TipoDeComprobante", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaEmision", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaEmision", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Vendedores", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Vendedores", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoFactura", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoFactura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTiposComprobantesPredecesores", SqlDbType.VarChar, 4000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTiposComprobantesPredecesores", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparaciones", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoCtaCte", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCte", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoCtaCteDV", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCteDV", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoCtaCteConsolidado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCteConsolidado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_FacturasImpagas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_FacturasImpagas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cuenta", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TipoDeComprobante", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaEmision", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaEmision", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Vendedores", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Vendedores", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoFactura", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SaldoFactura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTiposComprobantesPredecesores", SqlDbType.VarChar, 4000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTiposComprobantesPredecesores", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparaciones", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoCtaCte", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SaldoCtaCte", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoCtaCteDV", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SaldoCtaCteDV", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoCtaCteConsolidado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SaldoCtaCteConsolidado", DataRowVersion.Current, null ) );
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

