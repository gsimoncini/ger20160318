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

	public class tsh_ProductosAuxiliares : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosAuxiliares()
		{
		}

		public static tsh_ProductosAuxiliaresDataset GetList()
		{
			tsh_ProductosAuxiliaresDataset data = new tsh_ProductosAuxiliaresDataset();

			return ( tsh_ProductosAuxiliaresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosAuxiliares" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosAuxiliares_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

/*		public static tsh_ProductosAuxiliaresDataset GetList(  )
		{
			tsh_ProductosAuxiliaresDataset data = new tsh_ProductosAuxiliaresDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosAuxiliares" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosAuxiliares_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}*/

		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow NewRow()
		{
			return ( new tsh_ProductosAuxiliaresDataset() ).tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();
		}

	
		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow GetByPk( string IdProducto )
		{
			tsh_ProductosAuxiliaresDataset data = new tsh_ProductosAuxiliaresDataset();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosAuxiliares_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;	
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProductosAuxiliares" );

			adapter.Fill( data );

			if ( data.tsh_ProductosAuxiliares.Rows.Count == 1 )
			{
				return ( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow )data.tsh_ProductosAuxiliares.Rows[ 0 ];
			}
			
			return null;
		}

		public static DataSet GetByPk( DataSet data, string IdProducto )
		{
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosAuxiliares_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProductosAuxiliares" );

			adapter.Fill( data );
			return data;

		}
		
		public static void Update( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresDataTable )row.Table ).Addtsh_ProductosAuxiliaresRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProductosAuxiliaresDataset dataSet )
		{
			Update( dataSet.tsh_ProductosAuxiliares );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresDataTable )dataTable, trx );
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

		/*public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresDataTable )dataTable, trx );
		}*/
		public static void Update(System.Data.DataTable dataTable, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update( dataTable, trx) ;
		}					

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_ProductosAuxiliares", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Contador", "Contador" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "Thumb", "Thumb" ),
																											 new System.Data.Common.DataColumnMapping( "Imagen", "Imagen" ),
																											 new System.Data.Common.DataColumnMapping( "Thumb2", "Thumb2" ),
																											 new System.Data.Common.DataColumnMapping( "Imagen2", "Imagen2" ),
																											 new System.Data.Common.DataColumnMapping( "Thumb3", "Thumb3" ),
																											 new System.Data.Common.DataColumnMapping( "Imagen3", "Imagen3" ),
																											 new System.Data.Common.DataColumnMapping( "Thumb4", "Thumb4" ),
																											 new System.Data.Common.DataColumnMapping( "Imagen4", "Imagen4" ),
																											 new System.Data.Common.DataColumnMapping( "Thumb5", "Thumb5" ),
																											 new System.Data.Common.DataColumnMapping( "Imagen5", "Imagen5" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente1", "Coeficiente1" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente2", "Coeficiente2" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente3", "Coeficiente3" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente4", "Coeficiente4" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente5", "Coeficiente5" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente6", "Coeficiente6" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente7", "Coeficiente7" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente8", "Coeficiente8" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente9", "Coeficiente9" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente10", "Coeficiente10" ),
																											 new System.Data.Common.DataColumnMapping( "CodigoSecundario1", "CodigoSecundario1" ),																											 
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario2", "CodigoSecundario2" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario3", "CodigoSecundario3" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario4", "CodigoSecundario4" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario5", "CodigoSecundario5" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario6", "CodigoSecundario6" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario7", "CodigoSecundario7" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario8", "CodigoSecundario8" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario9", "CodigoSecundario9" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario10", "CodigoSecundario10" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario11", "CodigoSecundario11" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario12", "CodigoSecundario12" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario13", "CodigoSecundario13" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario14", "CodigoSecundario14" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario15", "CodigoSecundario15" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario16", "CodigoSecundario16" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario17", "CodigoSecundario17" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario18", "CodigoSecundario18" ),
															  new System.Data.Common.DataColumnMapping( "CodigoSecundario19", "CodigoSecundario19" ),
     													      new System.Data.Common.DataColumnMapping( "CodigoSecundario20", "CodigoSecundario20" ),
															  new System.Data.Common.DataColumnMapping( "TieneCodigoSecundarioSegmentado", "TieneCodigoSecundarioSegmentado" ),
															  new System.Data.Common.DataColumnMapping( "IdComprobanteProximaRecepcionMercaderia", "IdComprobanteProximaRecepcionMercaderia" ),
															  new System.Data.Common.DataColumnMapping( "FechaRecepcion", "FechaRecepcion" ),
															  new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
                                                              /* Silvina 20110630 - Tarea 0000136 */
                                                              new System.Data.Common.DataColumnMapping( "PermiteCambio", "PermiteCambio" ),
                                                              /* Fin Silvina 20110630 - Tarea 0000136 */
															  new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" )

																												 
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_ProductosAuxiliares_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Contador", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Contador", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Thumb", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Imagen", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Thumb2", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Imagen2", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Thumb3", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Imagen3", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Thumb4", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Imagen4", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Thumb5", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Imagen5", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente6", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente6", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente7", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente7", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente8", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente8", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente9", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente9", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente10", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente10", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Link1", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Link2", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Link3", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Link4", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario4", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario5", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario6", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario6", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario7", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario7", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario8", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario8", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario9", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario9", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario10", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario10", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario11", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario11", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario12", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario12", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario13", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario13", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario14", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario14", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario15", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario15", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario16", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario16", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario17", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario17", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario18", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario18", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario19", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario19", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario20", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario20", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TieneCodigoSecundarioSegmentado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TieneCodigoSecundarioSegmentado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteProximaRecepcionMercaderia", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteProximaRecepcionMercaderia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaRecepcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null ) );
            /* Silvina 20110630 - Tarea 0000136 */
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PermiteCambio", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PermiteCambio", DataRowVersion.Current, null));
            /* Fin Silvina 20110630 - Tarea 0000136 */

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_ProductosAuxiliares_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProductosAuxiliares_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Contador", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Contador", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Thumb", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Imagen", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Thumb2", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Imagen2", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Thumb3", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Imagen3", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Thumb4", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Imagen4", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Thumb5", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Thumb5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Imagen5", SqlDbType.Image, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imagen5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente6", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente6", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente7", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente7", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente8", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente8", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente9", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente9", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente10", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente10", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Link1", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Link2", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Link3", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Link4", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Link5", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Link5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario4", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario5", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario6", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario6", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario7", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario7", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario8", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario8", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario9", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario9", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario10", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario10", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario11", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario11", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario12", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario12", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario13", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario13", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario14", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario14", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario15", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario15", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario16", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario16", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario17", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario17", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario18", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario18", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario19", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario19", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario20", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoSecundario20", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TieneCodigoSecundarioSegmentado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TieneCodigoSecundarioSegmentado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteProximaRecepcionMercaderia", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteProximaRecepcionMercaderia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaRecepcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null ) );
            /* Silvina 20110630 - Tarea 0000136 */
            sqlCommandInsert.Parameters.Add( new SqlParameter( "@PermiteCambio", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PermiteCambio", DataRowVersion.Current, null));
            /* Fin Silvina 20110630 - Tarea 0000136 */
			
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

