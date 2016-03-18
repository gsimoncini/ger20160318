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

	public class twf_ProcesosTareas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_ProcesosTareas()
		{
		}

		public static twf_ProcesosTareasDataset GetList()
		{
			twf_ProcesosTareasDataset data = new twf_ProcesosTareasDataset();

			return ( twf_ProcesosTareasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static twf_ProcesosTareasDataset GetList( long IdProceso, long IdTarea, int Orden, string Descripcion, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones, int OrdenBR, int OrdenDA, int OrdenUI )
		{
			twf_ProcesosTareasDataset data = new twf_ProcesosTareasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareas" );

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
   			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
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
   			cmd.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.Int ) );
               		cmd.Parameters[ "@Orden" ].Value = Orden;
   			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
   			cmd.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt ) );
			if ( IdConexion == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdConexion" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdConexion" ].Value = IdConexion;
		   	}
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
   			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Binary ) );
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
   			cmd.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Observaciones" ].Value = Observaciones;
   			cmd.Parameters.Add( new SqlParameter( "@OrdenBR", SqlDbType.Int ) );
               		cmd.Parameters[ "@OrdenBR" ].Value = OrdenBR;
   			cmd.Parameters.Add( new SqlParameter( "@OrdenDA", SqlDbType.Int ) );
               		cmd.Parameters[ "@OrdenDA" ].Value = OrdenDA;
   			cmd.Parameters.Add( new SqlParameter( "@OrdenUI", SqlDbType.Int ) );
               		cmd.Parameters[ "@OrdenUI" ].Value = OrdenUI;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static System.Data.DataSet GetList( long IdProceso, long IdTarea, int Orden, string Descripcion )
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Result" );

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareas_SearchFiltrado", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			cmd.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.Int ) );
			if ( Orden == int.MinValue )
				cmd.Parameters[ "@Orden" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Orden" ].Value = Orden;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow NewRow()
		{
			return ( new twf_ProcesosTareasDataset() ).twf_ProcesosTareas.Newtwf_ProcesosTareasRow();
		}
	
		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow GetByPk( long IdProceso, long IdTarea )
		{
			twf_ProcesosTareasDataset data = new twf_ProcesosTareasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareas" );

			adapter.Fill( data );

			if ( data.twf_ProcesosTareas.Rows.Count == 1 )
			{
				return ( twf_ProcesosTareasDataset.twf_ProcesosTareasRow )data.twf_ProcesosTareas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( twf_ProcesosTareasDataset.twf_ProcesosTareasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable )row.Table ).Addtwf_ProcesosTareasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( twf_ProcesosTareasDataset dataSet )
		{
			Update( dataSet.twf_ProcesosTareas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable )dataTable, trx );
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
			Update( ( twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable )dataTable, trx );
		}
				

		public static void Update( twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "twf_ProcesosTareas", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
							new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
							new System.Data.Common.DataColumnMapping( "Orden", "Orden" ),
							new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
							new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
							new System.Data.Common.DataColumnMapping( "OrdenBR", "OrdenBR" ),
							new System.Data.Common.DataColumnMapping( "OrdenDA", "OrdenDA" ),
							new System.Data.Common.DataColumnMapping( "OrdenUI", "OrdenUI" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_twf_ProcesosTareas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Orden", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Binary, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OrdenBR", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OrdenBR", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OrdenDA", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OrdenDA", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OrdenUI", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OrdenUI", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_twf_ProcesosTareas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_twf_ProcesosTareas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Orden", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OrdenBR", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdenBR", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OrdenDA", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdenDA", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OrdenUI", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdenUI", DataRowVersion.Current, null ) );

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

