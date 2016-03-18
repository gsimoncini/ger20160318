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

	public class tfi_Cajas : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetUltimaInstancia(string IdCajas )
		{
			DataSet data = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_cajas_GetUltimaInstancia" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_cajas_GetUltimaInstancia", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter( "@Idcajas", SqlDbType.VarChar ));
				cmd.Parameters[ "@Idcajas" ].Value = IdCajas;
				adapter.SelectCommand = cmd;
				adapter.Fill( data );
			}
			catch(Exception e){ ;}
			return data;
			
		}

		public static DataSet GetTiposDeMovimientosDeCaja( string IdTipo, System.Int16 signo, bool Sistema )
		{
			DataSet data = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_Cajas_TiposDeMovimientosDeCaja" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_TiposDeMovimientosDeCaja", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdTipo", SqlDbType.VarChar ) );
				if(IdTipo == null || IdTipo.Equals(string.Empty))
					cmd.Parameters[ "@IdTipo" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipo" ].Value = IdTipo;
				
				cmd.Parameters.Add( new SqlParameter( "@Signo", SqlDbType.SmallInt ) );
				if (!(signo.Equals( System.Int16.MinValue )))
				{  cmd.Parameters[ "@Signo" ].Value = signo;}
				else
				{  cmd.Parameters[ "@Signo" ].Value = System.DBNull.Value; }
				cmd.Parameters.Add( new SqlParameter( "@Sistema", SqlDbType.Bit) );
				cmd.Parameters[ "@Sistema" ].Value = Sistema;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
			return data;
			
		}
		public static DataSet GetTiposDeMovimientos( string IdTipo, System.Int16 signo )
		{
			DataSet data = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_Cajas_TiposDeMovimientos" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_TiposDeMovimientos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdTipo", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdTipo" ].Value = IdTipo;
				
				cmd.Parameters.Add( new SqlParameter( "@Signo", SqlDbType.SmallInt ) );
				if (!(signo.Equals( System.Int16.MinValue )))
					{  cmd.Parameters[ "@Signo" ].Value = signo;}
				else
					{  cmd.Parameters[ "@Signo" ].Value = System.DBNull.Value; }

				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
			return data;
		}
		public static tfi_InstanciasCajaExDataset GetList( string IdResponsable )
		{
			tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();

			return ( tfi_InstanciasCajaExDataset )GetList( data, IdResponsable );
		}	

		public static tfi_InstanciasCajaExDataset GetList( tfi_InstanciasCajaExDataset data, string IdResponsable )
		{
			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_Cajas_GetByResponsable" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetByResponsable", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){ ;}
         
			return data;
		}



		#endregion
		
		public tfi_Cajas()
		{
		}



		public static DataSet rep_ListadoEstadoCajas()
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Result" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_EstadoAcutal", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CajasDataset GetList()
		{
			tfi_CajasDataset data = new tfi_CajasDataset();

			return ( tfi_CajasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_Cajas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CajasDataset GetList( string IdCaja, string Descripcion )
		{
			tfi_CajasDataset data = new tfi_CajasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_Cajas" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
   			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@IdCaja" ].Value = IdCaja;
   			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CajasDataset.tfi_CajasRow NewRow()
		{
			return ( new tfi_CajasDataset() ).tfi_Cajas.Newtfi_CajasRow();
		}


		public static System.Data.DataTable GetByResponsableTodasLasCajas(string IdPersona, string cajas)
		{
			System.Data.DataTable data = new DataTable();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetByResponsableTodasLasCajas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdPersona;

			cmd.Parameters.Add( new SqlParameter( "@Cajas", SqlDbType.VarChar ) );
			if(cajas == null || cajas.Equals(string.Empty))
				cmd.Parameters[ "@Cajas" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Cajas" ].Value = cajas;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
					
		}

		


			public static System.Data.DataTable GetByResponsableTodasLasCajasConAperturaConSaldo(string IdPersona, string cajas)
			{
				System.Data.DataTable data = new DataTable();

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetByResponsableTodasLasCajasConAperturaConSaldo", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdResponsable" ].Value = IdPersona;

				cmd.Parameters.Add( new SqlParameter( "@Cajas", SqlDbType.VarChar ) );
				if(cajas == null || cajas.Equals(string.Empty))
					cmd.Parameters[ "@Cajas" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Cajas" ].Value = cajas;
			
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
         
				return data;
					
			}

	


		public static System.Data.DataTable GetByResponsableConAperturaConSaldo(string IdPersona)
		{
			System.Data.DataTable data = new DataTable();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetByResponsableConAperturaConSaldo", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdPersona;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
					
		}

	
		public static tfi_CajasDataset.tfi_CajasRow GetByPk( string IdCaja )
		{
			tfi_CajasDataset data = new tfi_CajasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCaja" ].Value = IdCaja;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_Cajas" );

			adapter.Fill( data );

			if ( data.tfi_Cajas.Rows.Count == 1 )
			{
				return ( tfi_CajasDataset.tfi_CajasRow )data.tfi_Cajas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_CajasDataset.tfi_CajasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_CajasDataset.tfi_CajasDataTable )row.Table ).Addtfi_CajasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_CajasDataset dataSet )
		{
			Update( dataSet.tfi_Cajas );
		}


		public static void Update( DataTable dataTable, DataTable dataTableVariables )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_CajasDataset.tfi_CajasDataTable )dataTable, trx );
				mz.erp.dataaccess.sy_Variables.Update( dataTableVariables, trx);
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


		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_CajasDataset.tfi_CajasDataTable )dataTable, trx );
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
			Update( ( tfi_CajasDataset.tfi_CajasDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_CajasDataset.tfi_CajasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tfi_Cajas", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdCaja", "IdCaja" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
							new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_Cajas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCaja", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_Cajas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_Cajas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

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

