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

	public class tsa_CondicionesDeVentaDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_CondicionesDeVentaDet()
		{
		}

		public static tsa_CondicionesDeVentaDetDataset GetList()
		{
			tsa_CondicionesDeVentaDetDataset data = new tsa_CondicionesDeVentaDetDataset();

			return ( tsa_CondicionesDeVentaDetDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentaDet" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CondicionesDeVentaDetDataset GetList( string IdCondicionDeVentaDet, short Cuota, short DiasVencimiento, decimal Porcentual, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			tsa_CondicionesDeVentaDetDataset data = new tsa_CondicionesDeVentaDetDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentaDet" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
   			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaDet", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@IdCondicionDeVentaDet" ].Value = IdCondicionDeVentaDet;
   			cmd.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt ) );
               		cmd.Parameters[ "@Cuota" ].Value = Cuota;
   			cmd.Parameters.Add( new SqlParameter( "@DiasVencimiento", SqlDbType.SmallInt ) );
               		cmd.Parameters[ "@DiasVencimiento" ].Value = DiasVencimiento;
   			cmd.Parameters.Add( new SqlParameter( "@Porcentual", SqlDbType.Decimal ) );
               		cmd.Parameters[ "@Porcentual" ].Value = Porcentual;
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
   			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt ) );
			if ( IdReservado == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdReservado" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdReservado" ].Value = IdReservado;
		   	}
   			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
               		cmd.Parameters[ "@RowId" ].Value = RowId;
   			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
		   	}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow NewRow()
		{
			return ( new tsa_CondicionesDeVentaDetDataset() ).tsa_CondicionesDeVentaDet.Newtsa_CondicionesDeVentaDetRow();
		}
	
		public static tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow GetByPk( string IdCondicionDeVentaDet, short Cuota )
		{
			tsa_CondicionesDeVentaDetDataset data = new tsa_CondicionesDeVentaDetDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaDet", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVentaDet" ].Value = IdCondicionDeVentaDet;
			
			cmd.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt ) );
			cmd.Parameters[ "@Cuota" ].Value = Cuota;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentaDet" );

			adapter.Fill( data );

			if ( data.tsa_CondicionesDeVentaDet.Rows.Count == 1 )
			{
				return ( tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow )data.tsa_CondicionesDeVentaDet.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetDataTable )row.Table ).Addtsa_CondicionesDeVentaDetRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CondicionesDeVentaDetDataset dataSet )
		{
			Update( dataSet.tsa_CondicionesDeVentaDet );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				//Update( dataTable, trx );
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

		/*
		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetDataTable )dataTable, trx );
		}
		*/		

		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable,trx);			
		}

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsa_CondicionesDeVentaDet", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdCondicionDeVentaDet", "IdCondicionDeVentaDet" ),
							new System.Data.Common.DataColumnMapping( "Cuota", "Cuota" ),
							new System.Data.Common.DataColumnMapping( "DiasVencimiento", "DiasVencimiento" ),
							new System.Data.Common.DataColumnMapping( "Porcentual", "Porcentual" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaDet", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicionDeVentaDet", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cuota", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DiasVencimiento", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DiasVencimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Porcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Porcentual", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCondicionDeVentaDet", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCondicionDeVentaDet", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldCuota", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cuota", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaDet", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicionDeVentaDet", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cuota", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CondicionesDeVentaDet_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaDet", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicionDeVentaDet", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cuota", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DiasVencimiento", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DiasVencimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Porcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Porcentual", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}


		public static tsa_CondicionesDeVentaDetDataset GetListByIdCondicionDeVenta( string IdCondicionDeVenta)
		{
			tsa_CondicionesDeVentaDetDataset data = new tsa_CondicionesDeVentaDetDataset();
		
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentaDet_GetListByIdCondicionDeVenta", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
		
		
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentaDet" );

			adapter.Fill( data );
			return data;
		}

		
	}
}

