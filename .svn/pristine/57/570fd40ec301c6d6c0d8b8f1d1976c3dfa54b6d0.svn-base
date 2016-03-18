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

	public class tsy_MotivoOrdenReparacion : IDisposable
	{
	
		#region Custom Members
		public static tsy_MotivoOrdenReparacionDataset GetListPadres()
		{
			tsy_MotivoOrdenReparacionDataset data = new tsy_MotivoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_MotivoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_GetListPadres", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_MotivoOrdenReparacionDataset GetListHijos(long IdMotivoPadre)
		{
			tsy_MotivoOrdenReparacionDataset data = new tsy_MotivoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_MotivoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_GetListHijos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMotivoPadre", SqlDbType.BigInt ) );
			if ( IdMotivoPadre == long.MinValue )
			{
				cmd.Parameters[ "@IdMotivoPadre" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdMotivoPadre" ].Value = IdMotivoPadre;
			}

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		
		public tsy_MotivoOrdenReparacion()
		{
		}

		public static tsy_MotivoOrdenReparacionDataset GetList()
		{
			tsy_MotivoOrdenReparacionDataset data = new tsy_MotivoOrdenReparacionDataset();

			return ( tsy_MotivoOrdenReparacionDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_MotivoOrdenReparacion" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_MotivoOrdenReparacionDataset GetList( long IdMotivo, long IdMotivoPadre, bool EsVerdadero, string Descripcion )
		{
			tsy_MotivoOrdenReparacionDataset data = new tsy_MotivoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_MotivoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt ) );
			if ( IdMotivo == long.MinValue )
			{
				cmd.Parameters[ "@IdMotivo" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdMotivo" ].Value = IdMotivo;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdMotivoPadre", SqlDbType.BigInt ) );
			if ( IdMotivoPadre == long.MinValue )
			{
				cmd.Parameters[ "@IdMotivoPadre" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdMotivoPadre" ].Value = IdMotivoPadre;
			}
			cmd.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit ) );
			cmd.Parameters[ "@EsVerdadero" ].Value = EsVerdadero;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow NewRow()
		{
			return ( new tsy_MotivoOrdenReparacionDataset() ).tsy_MotivoOrdenReparacion.Newtsy_MotivoOrdenReparacionRow();
		}
	
		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow GetByPk( long IdMotivo )
		{
			tsy_MotivoOrdenReparacionDataset data = new tsy_MotivoOrdenReparacionDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdMotivo" ].Value = IdMotivo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsy_MotivoOrdenReparacion" );

			adapter.Fill( data );

			if ( data.tsy_MotivoOrdenReparacion.Rows.Count == 1 )
			{
				return ( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow )data.tsy_MotivoOrdenReparacion.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable )row.Table ).Addtsy_MotivoOrdenReparacionRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsy_MotivoOrdenReparacionDataset dataSet )
		{
			Update( dataSet.tsy_MotivoOrdenReparacion );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable )dataTable, trx );
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
			Update( ( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable )dataTable, trx );
		}
				

		public static void Update( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_MotivoOrdenReparacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdMotivo", "IdMotivo" ),
																											 new System.Data.Common.DataColumnMapping( "IdMotivoPadre", "IdMotivoPadre" ),
																											 new System.Data.Common.DataColumnMapping( "EsVerdadero", "EsVerdadero" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMotivoPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMotivoPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "EsVerdadero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMotivo", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsy_MotivoOrdenReparacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_MotivoOrdenReparacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMotivoPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivoPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "EsVerdadero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Current, null ) );

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

