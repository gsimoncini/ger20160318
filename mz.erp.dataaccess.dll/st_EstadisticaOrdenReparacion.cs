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

	public class st_EstadisticaOrdenReparacion : IDisposable
	{
	
		#region Custom Members
		public static DataSet ListarDetalleTecnico (DateTime FechaDesde, DateTime FechaHasta, bool PorFechaAltaOrdenReparacion, bool PorFechaAsignacionATecnico, bool PorFechaFactura, bool PorFechaCierre, bool PorFechaCierreTecnico, string IdPersona, long IdEstadoOrdenReparacion, string IdTecnicosSelecionados)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_ListarDetalle", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaDesde" ].Value = FechaDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaHasta" ].Value = FechaHasta;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaAltaOrdenReparacion", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaAltaOrdenReparacion" ].Value = PorFechaAltaOrdenReparacion;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaAsignacionATecnico", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaAsignacionATecnico" ].Value = PorFechaAsignacionATecnico;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaFactura", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaFactura" ].Value = PorFechaFactura;
			
			cmd.Parameters.Add( new SqlParameter( "@PorFechaCierre", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaCierre" ].Value = PorFechaCierre;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaCierreTecnico", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaCierreTecnico" ].Value = PorFechaCierreTecnico;

			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
			if(IdPersona.Equals(string.Empty))
				cmd.Parameters[ "@IdPersona" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdPersona" ].Value = IdPersona;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoOrdenReparacion", SqlDbType.BigInt ) );
			if(IdEstadoOrdenReparacion.Equals(long.MinValue))
				cmd.Parameters[ "@IdEstadoOrdenReparacion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEstadoOrdenReparacion" ].Value = IdEstadoOrdenReparacion;

			cmd.Parameters.Add( new SqlParameter( "@IdTecnicosSelecionados", SqlDbType.VarChar ) );
			if(IdTecnicosSelecionados.Equals(string.Empty))
				cmd.Parameters[ "@IdTecnicosSelecionados" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTecnicosSelecionados" ].Value = IdTecnicosSelecionados;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			
			//adapter.TableMappings.Add( "Table", "st_InstanciaOrdenReparacion" );

			adapter.Fill( data );			
			return data;
		}


		public static DataSet ListarOrdenesACerrar (string CodigosEstadosOrdenReparacionACerrar)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_ListarOrdenesACerrar", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@CodigosEstadosOrdenReparacionACerrar", SqlDbType.VarChar ) );
			if(CodigosEstadosOrdenReparacionACerrar.Equals(string.Empty))
				cmd.Parameters[ "@CodigosEstadosOrdenReparacionACerrar" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CodigosEstadosOrdenReparacionACerrar" ].Value = CodigosEstadosOrdenReparacionACerrar;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			

			adapter.Fill( data );	
			return data;
		}

		public static DataSet ListarOrdenesAAbrir (string CodigosEstadosOrdenReparacionAAbrir)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_ListarOrdenesAAbrir", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@CodigosEstadosOrdenReparacionAAbrir", SqlDbType.VarChar ) );
			if(CodigosEstadosOrdenReparacionAAbrir.Equals(string.Empty))
				cmd.Parameters[ "@CodigosEstadosOrdenReparacionAAbrir" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CodigosEstadosOrdenReparacionAAbrir" ].Value = CodigosEstadosOrdenReparacionAAbrir;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			

			adapter.Fill( data );	
			return data;
		}

		#endregion
		
		public st_EstadisticaOrdenReparacion()
		{
		}

		public static st_EstadisticaOrdenReparacionDataset GetList()
		{
			st_EstadisticaOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionDataset();

			return ( st_EstadisticaOrdenReparacionDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacion" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionDataset GetList( long IdOrdenReparacion, bool Cerrado, string NumeroRemito, decimal TiempoDeEspera, DateTime FechaCierre )
		{
			st_EstadisticaOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit ) );
			cmd.Parameters[ "@Cerrado" ].Value = Cerrado;

			cmd.Parameters.Add( new SqlParameter( "@NumeroRemito", SqlDbType.VarChar ) );
			if ( NumeroRemito == string.Empty )
			{
				cmd.Parameters[ "@NumeroRemito" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@NumeroRemito" ].Value = NumeroRemito;
			}

			cmd.Parameters.Add( new SqlParameter( "@TiempoDeEspera", SqlDbType.Decimal ) );
			if ( TiempoDeEspera == decimal.MinValue )
			{
				cmd.Parameters[ "@TiempoDeEspera" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@TiempoDeEspera" ].Value = TiempoDeEspera;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCierre" ].Value = FechaCierre;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow NewRow()
		{
			return ( new st_EstadisticaOrdenReparacionDataset() ).st_EstadisticaOrdenReparacion.Newst_EstadisticaOrdenReparacionRow();
		}
	
		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow GetByPk( long IdOrdenReparacion )
		{
			st_EstadisticaOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacion" );

			adapter.Fill( data );

			if ( data.st_EstadisticaOrdenReparacion.Rows.Count == 1 )
			{
				return ( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow )data.st_EstadisticaOrdenReparacion.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable )row.Table ).Addst_EstadisticaOrdenReparacionRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_EstadisticaOrdenReparacionDataset dataSet )
		{
			Update( dataSet.st_EstadisticaOrdenReparacion );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable )dataTable, trx );
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
			Update( ( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable )dataTable, trx );
		}
				

		public static void Update( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_EstadisticaOrdenReparacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "Cerrado", "Cerrado" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroRemito", "NumeroRemito" ),
																											 new System.Data.Common.DataColumnMapping( "TiempoDeEspera", "TiempoDeEspera" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCierre", "FechaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cerrado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroRemito", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroRemito", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TiempoDeEspera", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TiempoDeEspera", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_EstadisticaOrdenReparacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_EstadisticaOrdenReparacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cerrado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroRemito", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroRemito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TiempoDeEspera", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TiempoDeEspera", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCierre", DataRowVersion.Current, null ) );
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

