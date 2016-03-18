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

	public class st_EstadisticaOrdenReparacionDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_EstadisticaOrdenReparacionDet()
		{
		}

		public static st_EstadisticaOrdenReparacionDetDataset GetList()
		{
			st_EstadisticaOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionDetDataset();

			return ( st_EstadisticaOrdenReparacionDetDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionDet" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionDet_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionDetDataset GetList( long IdOrdenReparacion, long IdInstaciaOrdenReparacion, decimal Cantidad, long IdTarea, string Complejidad, decimal ValorTecnico, decimal ValorTecnicoProvisorio, decimal ValorCliente, decimal Subtotal )
		{
			st_EstadisticaOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionDetDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionDet" );

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionDet_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@IdInstaciaOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdInstaciaOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdInstaciaOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdInstaciaOrdenReparacion" ].Value = IdInstaciaOrdenReparacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Cantidad" ].Value = Cantidad;
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}
			cmd.Parameters.Add( new SqlParameter( "@Complejidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Complejidad" ].Value = Complejidad;
			cmd.Parameters.Add( new SqlParameter( "@ValorTecnico", SqlDbType.Decimal ) );
			cmd.Parameters[ "@ValorTecnico" ].Value = ValorTecnico;
			cmd.Parameters.Add( new SqlParameter( "@ValorTecnicoProvisorio", SqlDbType.Decimal ) );
			cmd.Parameters[ "@ValorTecnicoProvisorio" ].Value = ValorTecnicoProvisorio;
			cmd.Parameters.Add( new SqlParameter( "@ValorCliente", SqlDbType.Decimal ) );
			cmd.Parameters[ "@ValorCliente" ].Value = ValorCliente;
			cmd.Parameters.Add( new SqlParameter( "@Subtotal", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Subtotal" ].Value = Subtotal;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow NewRow()
		{
			return ( new st_EstadisticaOrdenReparacionDetDataset() ).st_EstadisticaOrdenReparacionDet.Newst_EstadisticaOrdenReparacionDetRow();
		}
	
		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow GetByPk( long IdOrdenReparacion, long IdInstaciaOrdenReparacion, long IdTarea )
		{
			st_EstadisticaOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionDetDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionDet_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstaciaOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdInstaciaOrdenReparacion" ].Value = IdInstaciaOrdenReparacion;

			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionDet" );

			adapter.Fill( data );

			if ( data.st_EstadisticaOrdenReparacionDet.Rows.Count == 1 )
			{
				return ( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow )data.st_EstadisticaOrdenReparacionDet.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable )row.Table ).Addst_EstadisticaOrdenReparacionDetRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_EstadisticaOrdenReparacionDetDataset dataSet )
		{
			Update( dataSet.st_EstadisticaOrdenReparacionDet );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable )dataTable, trx );
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
			Update( ( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable )dataTable, trx );
		}
				

		public static void Update( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_EstadisticaOrdenReparacionDet", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdInstaciaOrdenReparacion", "IdInstaciaOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "Complejidad", "Complejidad" ),
																											 new System.Data.Common.DataColumnMapping( "ValorTecnico", "ValorTecnico" ),
																											 new System.Data.Common.DataColumnMapping( "ValorTecnicoProvisorio", "ValorTecnicoProvisorio" ),
																											 new System.Data.Common.DataColumnMapping( "ValorCliente", "ValorCliente" ),
																											 new System.Data.Common.DataColumnMapping( "Subtotal", "Subtotal" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionDet_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstaciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstaciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Complejidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Complejidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorTecnico", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorTecnico", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorTecnicoProvisorio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorTecnicoProvisorio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorCliente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorCliente", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Subtotal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Subtotal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdInstaciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstaciaOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionDet_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdInstaciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstaciaOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_EstadisticaOrdenReparacionDet_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstaciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstaciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Complejidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Complejidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorTecnico", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorTecnico", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorTecnicoProvisorio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorTecnicoProvisorio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorCliente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorCliente", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Subtotal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Subtotal", DataRowVersion.Current, null ) );
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

