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

	public class tpu_ProveedoresObservaciones : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetListEx( string IdProveedorObservacion, string IdProveedor, long IdPerfil, DateTime FechaDesde, DateTime FechaHasta, string IdProveedorObservacionTipo, string IdProveedorObservacionSubTipo, string IdProveedorObservacionEstado, string IdResponsable, bool Activo, long IdSucursal, long IdEmpresa)
		{			
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesEx" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacion" ].Value = IdProveedorObservacion;
	
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if (IdProveedor != String.Empty)
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.Int ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime) );
			if(FechaDesde == DateTime.MinValue)
				cmd.Parameters[ "@FechaDesde" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDesde" ].Value = FechaDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ) );
			if(FechaHasta == DateTime.MinValue)
				cmd.Parameters[ "@FechaHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaHasta" ].Value = FechaHasta;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar ) );
			if (IdProveedorObservacionTipo != String.Empty)
				cmd.Parameters[ "@IdProveedorObservacionTipo" ].Value = IdProveedorObservacionTipo;
			else
				cmd.Parameters[ "@IdProveedorObservacionTipo" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionSubTipo", SqlDbType.VarChar ) );
			if (IdProveedorObservacionSubTipo != String.Empty)			
				cmd.Parameters[ "@IdProveedorObservacionSubTipo" ].Value = IdProveedorObservacionSubTipo;
			else
				cmd.Parameters[ "@IdProveedorObservacionSubTipo" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionEstado", SqlDbType.VarChar ) );
			if (IdProveedorObservacionEstado != String.Empty)			
				cmd.Parameters[ "@IdProveedorObservacionEstado" ].Value = IdProveedorObservacionEstado;
			else
				cmd.Parameters[ "@IdProveedorObservacionEstado" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			if (IdResponsable != String.Empty)			
				cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			else
				cmd.Parameters[ "@IdResponsable" ].Value = System.DBNull.Value;
		
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		#endregion
		
		public tpu_ProveedoresObservaciones()
		{
		}

		public static tpu_ProveedoresObservacionesDataset GetList()
		{
			tpu_ProveedoresObservacionesDataset data = new tpu_ProveedoresObservacionesDataset();

			return ( tpu_ProveedoresObservacionesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservaciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesDataset GetList( string IdProveedorObservacion, string IdProveedor, string Titulo, string Observacion, string IdResponsable, DateTime Fecha, string IdProveedorObservacionTipo, string IdProveedorObservacionSubTipo, string IdProveedorObservacionEstado, DateTime FechaCreacion, bool Activo )
		{
			tpu_ProveedoresObservacionesDataset data = new tpu_ProveedoresObservacionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservaciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacion" ].Value = IdProveedorObservacion;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			cmd.Parameters.Add( new SqlParameter( "@Titulo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Titulo" ].Value = Titulo;
			cmd.Parameters.Add( new SqlParameter( "@Observacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Observacion" ].Value = Observacion;
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			cmd.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime ) );
			cmd.Parameters[ "@Fecha" ].Value = Fecha;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionTipo" ].Value = IdProveedorObservacionTipo;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionSubTipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionSubTipo" ].Value = IdProveedorObservacionSubTipo;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionEstado", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionEstado" ].Value = IdProveedorObservacionEstado;
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow NewRow()
		{
			return ( new tpu_ProveedoresObservacionesDataset() ).tpu_ProveedoresObservaciones.Newtpu_ProveedoresObservacionesRow();
		}
	
		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow GetByPk( string IdProveedorObservacion )
		{
			tpu_ProveedoresObservacionesDataset data = new tpu_ProveedoresObservacionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacion" ].Value = IdProveedorObservacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservaciones" );

			adapter.Fill( data );

			if ( data.tpu_ProveedoresObservaciones.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow )data.tpu_ProveedoresObservaciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesDataTable )row.Table ).Addtpu_ProveedoresObservacionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ProveedoresObservacionesDataset dataSet )
		{
			Update( dataSet.tpu_ProveedoresObservaciones );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesDataTable )dataTable, trx );
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
			SentenciasReplicacion replicacion = new SentenciasReplicacion();
			Update( dataTable, trx, replicacion );
		}
				

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ProveedoresObservaciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacion", "IdProveedorObservacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "Titulo", "Titulo" ),
																											 new System.Data.Common.DataColumnMapping( "Observacion", "Observacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "Fecha", "Fecha" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacionTipo", "IdProveedorObservacionTipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacionSubTipo", "IdProveedorObservacionSubTipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacionEstado", "IdProveedorObservacionEstado" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "FechaVencimiento", "FechaVencimiento" ),
																											 new System.Data.Common.DataColumnMapping( "FechaAviso", "FechaAviso" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Titulo", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Titulo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observacion", SqlDbType.VarChar, 8000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacionSubTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionSubTipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionEstado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaAviso", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaAviso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProveedorObservacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorObservacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ProveedoresObservaciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ProveedoresObservaciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Titulo", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Titulo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observacion", SqlDbType.VarChar, 8000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacionSubTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionSubTipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionEstado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaAviso", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaAviso", DataRowVersion.Current, null ) );

			#region Replicacion
			_replication = replication;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
			#endregion

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}

		private static SentenciasReplicacion _replication;
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

		public void Dispose()
		{
		}

		
	}
}

