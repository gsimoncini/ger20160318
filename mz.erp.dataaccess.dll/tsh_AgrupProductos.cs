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

	public class tsh_AgrupProductos : IDisposable
	{
	
		#region Custom Members


		
		public static tsh_AgrupProductosExDataset GetList( string IdProducto, long IdEmpresa) 
		{
			string Jerarquia = String.Empty;
			/*DateTime FechaCreacion = DateTime.MinValue;
			long IdConexionCreacion = long.MinValue;
			byte[] UltimaModificacion = null;
			long IdConexionUltimaModificacion = long.MinValue;
			long IdReservado = long.MinValue;
			Guid RowId = Guid.Empty;			*/
			return GetListEx(IdProducto, IdEmpresa );
		}
		public static tsh_AgrupProductosExDataset GetListEx( string IdProducto, long IdEmpresa )
		{
			tsh_AgrupProductosExDataset data = new tsh_AgrupProductosExDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_AgrupProductos_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

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

		public static tsh_AgrupProductosDataset GetListExistePadre( string Jerarquia)
		{
			tsh_AgrupProductosDataset data = new tsh_AgrupProductosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_AgrupProductos_SearchExistePadre", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			if ( Jerarquia == String.Empty) 
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else 
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		//Nuevo para replicacion
		private static SentenciasReplicacion _replicacion;
		public static SentenciasReplicacion Replicacion
		{
			get{return _replicacion;}
			set{_replicacion = value;}
		}


		
		#endregion
		
		public tsh_AgrupProductos()
		{
		}

		public static tsh_AgrupProductosDataset GetList()
		{
			tsh_AgrupProductosDataset data = new tsh_AgrupProductosDataset();

			return ( tsh_AgrupProductosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_AgrupProductos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		

		public static tsh_AgrupProductosDataset GetList( string IdProducto, string Jerarquia)
		{
			tsh_AgrupProductosDataset data = new tsh_AgrupProductosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_AgrupProductos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			if ( Jerarquia == String.Empty) 
			{
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			}
			else 
			{
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			}			

			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow NewRow()
		{
			return ( new tsh_AgrupProductosDataset() ).tsh_AgrupProductos.Newtsh_AgrupProductosRow();
		}
	
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow GetByPk( string IdProducto, string Jerarquia )
		{
			tsh_AgrupProductosDataset data = new tsh_AgrupProductosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_AgrupProductos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );

			adapter.Fill( data );

			if ( data.tsh_AgrupProductos.Rows.Count == 1 )
			{
				return ( tsh_AgrupProductosDataset.tsh_AgrupProductosRow )data.tsh_AgrupProductos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_AgrupProductosDataset.tsh_AgrupProductosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_AgrupProductosDataset.tsh_AgrupProductosDataTable )row.Table ).Addtsh_AgrupProductosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_AgrupProductosDataset dataSet )
		{
			Update( dataSet.tsh_AgrupProductos );
		}
		

		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			
		
			StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
			if(Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
				Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			
			
			
		}
		

		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx, Replicacion );
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
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

				
		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			Replicacion = replicacion;
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_AgrupProductos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_AgrupProductos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldJerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Jerarquia", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_AgrupProductos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_AgrupProductos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );


			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);


			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;


			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		public static SqlCommand SqlCommandInsert
		{
			get
			{
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_AgrupProductos_Insert");
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
				return sqlCommandInsert;
			}
		}

		
	}
}

