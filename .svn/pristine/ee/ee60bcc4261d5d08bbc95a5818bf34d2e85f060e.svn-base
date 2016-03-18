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

	public class st_ListaDePreciosTarea : IDisposable
	{
	
		#region Custom Members
		
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow GetByIdTarea( long IdTarea )
		{
			st_ListaDePreciosTareaDataset data = new st_ListaDePreciosTareaDataset();

            //German 20100726 - Tarea 800
			//SqlCommand cmd = new SqlCommand( "Pr_st_ListaDePreciosTarea_GetByIdTarea", dbhelper.Connection.GetConnection()  );
            SqlCommand cmd = new SqlCommand("sp_st_ListaDePreciosTarea_GetTarea", dbhelper.Connection.GetConnection());
            //Fin German 20100726 - Tarea 800
            
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_ListaDePreciosTarea" );

			adapter.Fill( data );


            //German 20100726 - Tarea 800
            /*
			if ( data.st_ListaDePreciosTarea.Rows.Count == 1 )
			{
				return ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow )data.st_ListaDePreciosTarea.Rows[ 0 ];
			}
            */
            if (data.st_ListaDePreciosTarea.Rows.Count > 0)
            {
                return (st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow)data.st_ListaDePreciosTarea.Rows[0];
            }
            //Fin German 20100726 - Tarea 800
			
			return null;
		}
		
		#endregion
		
		public st_ListaDePreciosTarea()
		{
		}

		public static st_ListaDePreciosTareaDataset GetList()
		{
			st_ListaDePreciosTareaDataset data = new st_ListaDePreciosTareaDataset();

			return ( st_ListaDePreciosTareaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_ListaDePreciosTarea" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_ListaDePreciosTarea_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_ListaDePreciosTareaDataset GetList( long IdListaDePreciosTarea, long IdTarea, DateTime FechaInicio, DateTime FechaFin, decimal Precio, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			st_ListaDePreciosTareaDataset data = new st_ListaDePreciosTareaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_ListaDePreciosTarea" );

			SqlCommand cmd = new SqlCommand( "Pr_st_ListaDePreciosTarea_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdListaDePreciosTarea", SqlDbType.BigInt ) );
			if ( IdListaDePreciosTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdListaDePreciosTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdListaDePreciosTarea" ].Value = IdListaDePreciosTarea;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}
			cmd.Parameters.Add( new SqlParameter( "@FechaInicio", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaInicio" ].Value = FechaInicio;
			cmd.Parameters.Add( new SqlParameter( "@FechaFin", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaFin" ].Value = FechaFin;
			cmd.Parameters.Add( new SqlParameter( "@Precio", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Precio" ].Value = Precio;
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

		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow NewRow()
		{
			return ( new st_ListaDePreciosTareaDataset() ).st_ListaDePreciosTarea.Newst_ListaDePreciosTareaRow();
		}
	
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow GetByPk( long IdListaDePreciosTarea )
		{
			st_ListaDePreciosTareaDataset data = new st_ListaDePreciosTareaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_ListaDePreciosTarea_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdListaDePreciosTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdListaDePreciosTarea" ].Value = IdListaDePreciosTarea;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_ListaDePreciosTarea" );

			adapter.Fill( data );

			if ( data.st_ListaDePreciosTarea.Rows.Count == 1 )
			{
				return ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow )data.st_ListaDePreciosTarea.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable )row.Table ).Addst_ListaDePreciosTareaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_ListaDePreciosTareaDataset dataSet )
		{
			Update( dataSet.st_ListaDePreciosTarea );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable )dataTable, trx );
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
			Update( ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable )dataTable, trx );
		}
				

		public static void Update( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_ListaDePreciosTarea", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdListaDePreciosTarea", "IdListaDePreciosTarea" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "FechaInicio", "FechaInicio" ),
																											 new System.Data.Common.DataColumnMapping( "FechaFin", "FechaFin" ),
																											 new System.Data.Common.DataColumnMapping( "Precio", "Precio" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_ListaDePreciosTarea_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdListaDePreciosTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdListaDePreciosTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaInicio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaFin", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Precio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Precio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdListaDePreciosTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePreciosTarea", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_ListaDePreciosTarea_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdListaDePreciosTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdListaDePreciosTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_ListaDePreciosTarea_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaInicio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaFin", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Precio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Precio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdListaDePreciosTarea", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdListaDePreciosTarea", DataRowVersion.Current, null ) );

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

