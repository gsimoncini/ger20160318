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

	public class tpu_ComprobantesDeCompra : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesDeCompra()
		{
		}

		public static tpu_ComprobantesDeCompraDataset GetList()
		{
			tpu_ComprobantesDeCompraDataset data = new tpu_ComprobantesDeCompraDataset();

			return ( tpu_ComprobantesDeCompraDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDeCompra" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesDeCompraDataset GetList( string IdComprobante, string IdTipoDeComprobante, string Numero, DateTime Fecha, string IdProveedor, string IdResponsable, DateTime FechaDeRegistracion, string IdTipoMovimiento, string IdSubtipoMovimiento, DateTime FechaVencimiento, long MesImputacion,long AñoImputacion,  /*, DateTime FechaRecepcionMercaderia, */string CAI, string Leyenda )
		{
			tpu_ComprobantesDeCompraDataset data = new tpu_ComprobantesDeCompraDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDeCompra" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante == null || IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if(IdTipoDeComprobante == null || IdTipoDeComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			if(Numero == null || Numero.Equals(string.Empty))
				cmd.Parameters[ "@Numero" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Numero" ].Value = Numero;

			cmd.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime ) );
			if(Fecha.Equals(DateTime.MinValue))
				cmd.Parameters[ "@Fecha" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Fecha" ].Value = Fecha;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if(IdProveedor == null || IdProveedor.Equals(string.Empty))
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			if(IdResponsable == null || IdResponsable.Equals(string.Empty))
				cmd.Parameters[ "@IdResponsable" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			cmd.Parameters.Add( new SqlParameter( "@FechaDeRegistracion", SqlDbType.DateTime ) );
			if(FechaDeRegistracion.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeRegistracion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDeRegistracion" ].Value = FechaDeRegistracion;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar ) );
			if(IdTipoMovimiento == null || IdTipoMovimiento.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoMovimiento" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoMovimiento" ].Value = IdTipoMovimiento;
			cmd.Parameters.Add( new SqlParameter( "@IdSubtipoMovimiento", SqlDbType.VarChar ) );
			if(IdSubtipoMovimiento == null || IdSubtipoMovimiento.Equals(string.Empty))
				cmd.Parameters[ "@IdSubtipoMovimiento" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdSubtipoMovimiento" ].Value = IdSubtipoMovimiento;
			cmd.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime ) );
			if(FechaVencimiento.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimiento" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimiento" ].Value = FechaVencimiento;
			cmd.Parameters.Add( new SqlParameter( "@MesImputacion", SqlDbType.BigInt ) );
			if(MesImputacion.Equals(long.MinValue))
				cmd.Parameters[ "@MesImputacion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MesImputacion" ].Value = MesImputacion;
			cmd.Parameters.Add( new SqlParameter( "@AñoImputacion", SqlDbType.BigInt ) );
			if(AñoImputacion.Equals(long.MinValue))
				cmd.Parameters[ "@AñoImputacion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@AñoImputacion" ].Value = AñoImputacion;
			/*
			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcionMercaderia", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaRecepcionMercaderia" ].Value = FechaRecepcionMercaderia;
			*/
			cmd.Parameters.Add( new SqlParameter( "@CAI", SqlDbType.VarChar ) );
			if(CAI == null || CAI.Equals(string.Empty))
				cmd.Parameters[ "@CAI" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CAI" ].Value = CAI;
			cmd.Parameters.Add( new SqlParameter( "@Leyenda", SqlDbType.VarChar ) );
			if(Leyenda == null || Leyenda.Equals(string.Empty))
				cmd.Parameters[ "@Leyenda" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Leyenda" ].Value = Leyenda;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow NewRow()
		{
			return ( new tpu_ComprobantesDeCompraDataset() ).tpu_ComprobantesDeCompra.Newtpu_ComprobantesDeCompraRow();
		}
	
		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow GetByPk( string IdComprobante )
		{
			tpu_ComprobantesDeCompraDataset data = new tpu_ComprobantesDeCompraDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesDeCompra" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesDeCompra.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow )data.tpu_ComprobantesDeCompra.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraDataTable )row.Table ).Addtpu_ComprobantesDeCompraRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable,trx);			
		}

		public static void Update( tpu_ComprobantesDeCompraDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesDeCompra );
		}
		
	
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
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
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesDeCompra", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																											 new System.Data.Common.DataColumnMapping( "Fecha", "Fecha" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierre", "IdMonedaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "FechaDeRegistracion", "FechaDeRegistracion" ),
																											 new System.Data.Common.DataColumnMapping( "ValorCotizacionProveedor", "ValorCotizacionProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoMovimiento", "IdTipoMovimiento" ),
																											 new System.Data.Common.DataColumnMapping( "IdSubtipoMovimiento", "IdSubtipoMovimiento" ),
																											 new System.Data.Common.DataColumnMapping( "FechaVencimiento", "FechaVencimiento" ),
																											 new System.Data.Common.DataColumnMapping( "FechaProximoVencimiento", "FechaProximoVencimiento" ),																											  
																											 new System.Data.Common.DataColumnMapping( "MesImputacion", "MesImputacion" ),
																											 new System.Data.Common.DataColumnMapping( "AñoImputacion", "AñoImputacion" ),
																											 //new System.Data.Common.DataColumnMapping( "FechaRecepcionMercaderia", "FechaRecepcionMercaderia" ),
																											 new System.Data.Common.DataColumnMapping( "CAI", "CAI" ),
																											 new System.Data.Common.DataColumnMapping( "Leyenda", "Leyenda" ),

																											 new System.Data.Common.DataColumnMapping( "NetoBruto", "NetoBruto" ),
																											 new System.Data.Common.DataColumnMapping( "Descuento", "Descuento" ),
																											 new System.Data.Common.DataColumnMapping( "SubtotalNeto", "SubtotalNeto" ),

																											 new System.Data.Common.DataColumnMapping( "NetoGravado", "NetoGravado" ),
																											 new System.Data.Common.DataColumnMapping( "GastoGravado", "GastoGravado" ),
																											 new System.Data.Common.DataColumnMapping( "ServicioGravado", "ServicioGravado" ),
																											 new System.Data.Common.DataColumnMapping( "MontoNoGravado", "MontoNoGravado" ),

																											 new System.Data.Common.DataColumnMapping( "IvaInscripto1", "IvaInscripto1" ),
																											 new System.Data.Common.DataColumnMapping( "IvaInscripto2", "IvaInscripto2" ),
																											 new System.Data.Common.DataColumnMapping( "IvaInscripto3", "IvaInscripto3" ),
																											 new System.Data.Common.DataColumnMapping( "PercepcionIB", "PercepcionIB" ),
																											 new System.Data.Common.DataColumnMapping( "PercepcionGanancias", "PercepcionGanancias" ),
																											 new System.Data.Common.DataColumnMapping( "PercepcionIVA", "PercepcionIVA" ),
																											 new System.Data.Common.DataColumnMapping( "ImpuestosInternos", "ImpuestosInternos" ),

																											 new System.Data.Common.DataColumnMapping( "TotalGeneral", "TotalGeneral" ),
																											 new System.Data.Common.DataColumnMapping( "DescuentoGeneral", "DescuentoGeneral" ),
																											 new System.Data.Common.DataColumnMapping( "Total", "Total" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "MesDevengamiento", "MesDevengamiento" ),
																											 new System.Data.Common.DataColumnMapping( "AñoDevengamiento", "AñoDevengamiento" ),
																											 new System.Data.Common.DataColumnMapping( "Autorizada", "Autorizada" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaDeRegistracion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaDeRegistracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorCotizacionProveedor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorCotizacionProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSubtipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSubtipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaProximoVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaProximoVencimiento", DataRowVersion.Current, null ) );
			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MesImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MesImputacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@AñoImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AñoImputacion", DataRowVersion.Current, null ) );
			//sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaRecepcionMercaderia", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaRecepcionMercaderia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CAI", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CAI", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Leyenda", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Leyenda", DataRowVersion.Current, null ) );

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NetoBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NetoBruto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descuento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SubtotalNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SubtotalNeto", DataRowVersion.Current, null ) );

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NetoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NetoGravado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@GastoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "GastoGravado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ServicioGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ServicioGravado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoNoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoNoGravado", DataRowVersion.Current, null ) );
			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IvaInscripto1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IvaInscripto2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IvaInscripto3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PercepcionIB", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercepcionIB", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PercepcionGanancias", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercepcionGanancias", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PercepcionIVA", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercepcionIVA", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ImpuestosInternos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ImpuestosInternos", DataRowVersion.Current, null ) );

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalGeneral", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescuentoGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescuentoGeneral", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MesDevengamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MesDevengamiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@AñoDevengamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AñoDevengamiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Autorizada", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Autorizada", DataRowVersion.Current, null ) );			
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesDeCompra_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaDeRegistracion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaDeRegistracion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorCotizacionProveedor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorCotizacionProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSubtipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSubtipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaProximoVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaProximoVencimiento", DataRowVersion.Current, null ) );
			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MesImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MesImputacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@AñoImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AñoImputacion", DataRowVersion.Current, null ) );
		
			//sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaRecepcionMercaderia", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaRecepcionMercaderia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CAI", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CAI", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Leyenda", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Leyenda", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NetoBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NetoBruto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descuento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SubtotalNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SubtotalNeto", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NetoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NetoGravado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@GastoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "GastoGravado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ServicioGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ServicioGravado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoNoGravado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoNoGravado", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IvaInscripto1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IvaInscripto2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IvaInscripto3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto3", DataRowVersion.Current, null ) );
			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PercepcionIB", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PercepcionIB", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PercepcionGanancias", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PercepcionGanancias", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PercepcionIVA", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PercepcionIVA", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ImpuestosInternos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ImpuestosInternos", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TotalGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TotalGeneral", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescuentoGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescuentoGeneral", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MesDevengamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MesDevengamiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@AñoDevengamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AñoDevengamiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Autorizada", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Autorizada", DataRowVersion.Current, null ) );	
			

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

