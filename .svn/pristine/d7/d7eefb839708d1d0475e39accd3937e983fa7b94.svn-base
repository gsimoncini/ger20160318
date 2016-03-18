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

	public class tfi_InstanciasCaja : IDisposable
	{
	
		#region Custom Members

		public static tfi_InstanciasCajaDataset GetListByIdCaja( string IdCaja)
		{
			tfi_InstanciasCajaDataset data = new tfi_InstanciasCajaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_SearchByIdCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCaja" ].Value = IdCaja;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow NewRowEx()
		{
			return ( new tfi_InstanciasCajaExDataset() ).tfi_InstanciasCaja.Newtfi_InstanciasCajaRow();
		}
		
		public static void Update( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaDataTable )row.Table ).Addtfi_InstanciasCajaRow( row );
			}
			
			Update(( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaDataTable ) row.Table);
		}

		public static void Update(  tfi_InstanciasCajaExDataset.tfi_InstanciasCajaDataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
				trx.Commit();
			}
			catch (Exception e)
			{
				//Debug.WriteLine(e.Message);
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update( tfi_InstanciasCajaExDataset dataSet )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tfi_InstanciasCajaExDataset.tfi_InstanciasCajaDataTable dataTable  = dataSet.tfi_InstanciasCaja;
				tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresDataTable dataTableCierres  = dataSet.tfi_InstanciasCajaCierres;
				Update( dataTable, trx );
				Update( dataTableCierres, trx);
				trx.Commit();
			}
			catch (Exception e)
			{
				//Debug.WriteLine(e.Message);
				
				trx.Rollback();
				

			}
			finally
			{
				cnx.Close();
			}
		}


		public static void Update(DataTable table, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(table, trx);
		}

		
		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_InstanciasCaja", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdCaja", "IdCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "Apertura", "Apertura" ),
																											 new System.Data.Common.DataColumnMapping( "Cierre", "Cierre" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_InstanciasCaja_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Apertura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_InstanciasCaja_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_InstanciasCaja_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Apertura", DataRowVersion.Current, null ) );
			if ((DateTime)dataTable.Rows[0]["Cierre"] == DateTime.MinValue) 
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cierre",System.DBNull.Value));
			else
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}

		public static void Update( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_InstanciasCajaCierres", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdTDCompTesoreria", "IdTDCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "Total", "Total" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierre", "IdMonedaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionCierre", "IdCotizacionCierre" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_InstanciasCajaCierres_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTDCompTesoreria", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_InstanciasCajaCierres_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_InstanciasCajaCierres_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
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
		
		public static tfi_InstanciasCajaExDataset GetList(string IdResponsable)
		{
			tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();

			return ( tfi_InstanciasCajaExDataset )GetList( data, IdResponsable);
		}

		//Para recuparar solo aquellas cajas abiertas
		public static tfi_InstanciasCajaDataset GetList( string IdInstanciaCaja, string IdCaja, DateTime Apertura, string IdResponsable )
		{
			tfi_InstanciasCajaDataset data = new tfi_InstanciasCajaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCaja" ].Value = IdCaja;
			cmd.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime ) );
			if (Apertura.Equals(DateTime.MinValue))
				cmd.Parameters[ "@Apertura" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Apertura" ].Value = Apertura;
			
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		

			/*El SP que se ejecuta con este metodo devuelve aquellas Cajas de las que es responsable
			 * el Responsable que se pasa como parametro sin tener en cuenta si el fue quien abrio la Caja
			 * */
			public static DataSet GetListCajasDeTodosLosResponsables(   string IdResponsable, string IdCajas)
			{
			
				DataSet data  = new DataSet();
				try
				{
				
					SqlDataAdapter adapter = new SqlDataAdapter();
					adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetByResponsableyCajasEx" );

					SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByResponsableyCajasEx", dbhelper.Connection.GetConnection() );
					cmd.CommandType = CommandType.StoredProcedure;
			
					cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
					cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdCajas" ].Value = IdCajas;
					adapter.SelectCommand = cmd;

					adapter.Fill( data );
				}
				catch(Exception e){ ;}
         
				return data;
			}

		public static DataSet GetList(   string IdResponsable, string IdCajas)
		{
			
			DataSet data  = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetByResponsableyCajas" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByResponsableyCajas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
				cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdCajas" ].Value = IdCajas;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
         
			return data;
		}

		public static DataSet GetList( DataSet data ,  string IdResponsable)
		{
			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetByResponsable" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByResponsable", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
         
			return data;
		}
		public static DataSet GetListXPersona(string IdPersona)
		{
			DataSet data = new DataSet();			

			return GetListXPersona( data, IdPersona  );
		}

		public static DataSet GetListXPersona( DataSet data ,  string IdPersona)
		{			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetByPersona" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByPersona", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdPersona" ].Value = IdPersona;
				adapter.SelectCommand = cmd;
				cmd.CommandTimeout = 120;
				adapter.Fill( data );
			}
			catch(Exception e)
			{ 
				Console.WriteLine(e.Message);
			}         
			return data;
		}

		public static DataSet GetListAbiertas()
		{
			DataSet data = new DataSet();			

			return GetListAbiertas( data );
		}

		public static DataSet GetListAbiertas(DataSet data)
		{			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetCajasAbiertas" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetCajasAbiertas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				adapter.SelectCommand = cmd;
				adapter.Fill( data );
			}
			catch(Exception e){ ;}         
			return data;
		}

		public static DataTable GetTotalInstanciaPorTDCompTesoreria( string IdTDCompTesoreria, string IdInstanciaCaja)
		{
			DataTable tabla = new DataTable();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "	" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_TotalPorTDCompTesoreria", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
					
				cmd.Parameters.Add( new SqlParameter( "@idtdcomptesoreria", SqlDbType.VarChar ) );
				cmd.Parameters[ "@idtdcomptesoreria" ].Value = IdTDCompTesoreria;

				cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
				
				adapter.SelectCommand = cmd;

				adapter.Fill(tabla);
			}
			catch(Exception e){ ;}
		         
			return tabla;
		}
		public static DataTable GetListXInstanciaAnterior(string IdInstanciaCaja) 
		{
			DataTable tabla = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "	" );
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_SearchXIdInstanciaCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			adapter.SelectCommand = cmd;
			adapter.Fill(tabla);
			return tabla;
		}

		public static DataTable GetListXInstancia(string IdInstanciaCaja) 
		{
			DataTable tabla = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "	" );
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_SearchXIdInstanciaCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			adapter.SelectCommand = cmd;
			adapter.Fill(tabla);
			return tabla;
		}

		public static tfi_InstanciasCajaExDataset GetCierre(string IdInstanciaCaja)
		{
			tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();
			data = GetByPk(data, IdInstanciaCaja);


			return ( tfi_InstanciasCajaExDataset )GetCierre( data, IdInstanciaCaja  );
		}

		public static tfi_InstanciasCajaExDataset GetByPk( tfi_InstanciasCajaExDataset data , string IdInstanciaCaja )
		{
			

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );

			adapter.Fill( data );


			
			return data;
		}

		public static DataSet GetCierre( DataSet data ,  string IdInstanciaCaja)
		{
			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_CierreCaja" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_CierreCaja", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
         
			return data;
		}
		
		public static tfi_InstanciasCajaExDataset GetDetalleIngresosEgresos(tfi_InstanciasCajaExDataset data ,string IdInstanciaCaja, string TiposDeComprobantes, string TiposDeMovimientos)
		{
				
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetIngresosEgresosByPk" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetIngresosEgresosByPk", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobantes", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TiposDeComprobantes" ].Value = TiposDeComprobantes;
			cmd.Parameters.Add( new SqlParameter( "@TiposDeMovimientos", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TiposDeMovimientos" ].Value = TiposDeMovimientos;
			
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		
		}

		public static tfi_InstanciasCajaExDataset GetDetallePagosComprobantes(tfi_InstanciasCajaExDataset data, string IdComprobante)
		{

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetDetallePagosComprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetDetallePagosComprobantes", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}

		public static tfi_InstanciasCajaExDataset GetDetallePagosMovimientosDeCaja(tfi_InstanciasCajaExDataset data, string IdMovimiento)
		{

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetDetallePagosMovimientosDeCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetDetallePagosMovimientosDeCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimiento" ].Value = IdMovimiento;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}




		public static DataSet GetDetallePagosComprobantes(string IdComprobante)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetDetallePagosComprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetDetallePagosComprobantes", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}

		public static DataSet GetDetallePagosMovimientosDeCaja(string IdMovimiento)
		{

			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_InstanciasCaja_GetDetallePagosMovimientosDeCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetDetallePagosMovimientosDeCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimiento" ].Value = IdMovimiento;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
		}

	




		#endregion
		
		public tfi_InstanciasCaja()
		{
		}

		public static tfi_InstanciasCajaDataset GetList()
		{
			tfi_InstanciasCajaDataset data = new tfi_InstanciasCajaDataset();

			return ( tfi_InstanciasCajaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_InstanciasCajaDataset GetList( string IdInstanciaCaja, string IdCaja, DateTime Apertura, DateTime Cierre, string IdResponsable )
		{
			tfi_InstanciasCajaDataset data = new tfi_InstanciasCajaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCaja" ].Value = IdCaja;
			cmd.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime ) );
			if (Apertura.Equals(DateTime.MinValue))
				cmd.Parameters[ "@Apertura" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Apertura" ].Value = Apertura;
			cmd.Parameters.Add( new SqlParameter( "@Cierre", SqlDbType.DateTime ) );
			if (Cierre.Equals(DateTime.MinValue))
				cmd.Parameters[ "@Cierre" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Cierre" ].Value = Cierre;
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow NewRow()
		{
			return ( new tfi_InstanciasCajaDataset() ).tfi_InstanciasCaja.Newtfi_InstanciasCajaRow();
		}
	
		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow GetByPk( string IdInstanciaCaja )
		{
			tfi_InstanciasCajaDataset data = new tfi_InstanciasCajaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_InstanciasCaja" );

			adapter.Fill( data );

			if ( data.tfi_InstanciasCaja.Rows.Count == 1 )
			{
				return ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow )data.tfi_InstanciasCaja.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable )row.Table ).Addtfi_InstanciasCajaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_InstanciasCajaDataset dataSet )
		{
			Update( dataSet.tfi_InstanciasCaja );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable )dataTable, trx );
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

		/*
		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_InstanciasCaja", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdCaja", "IdCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "Apertura", "Apertura" ),
																											 new System.Data.Common.DataColumnMapping( "Cierre", "Cierre" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_InstanciasCaja_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Apertura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cierre",  System.DBNull.Value) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_InstanciasCaja_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_InstanciasCaja_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Apertura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Apertura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		*/
		public void Dispose()
		{
		}

		
	}
}

