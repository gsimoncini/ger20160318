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

	public class tui_ConfiguracionGrillas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tui_ConfiguracionGrillas()
		{
		}

		public static tui_ConfiguracionGrillasDataset GetList()
		{
			tui_ConfiguracionGrillasDataset data = new tui_ConfiguracionGrillasDataset();

			return ( tui_ConfiguracionGrillasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillasDataset GetList( long IdProceso, long IdTarea, string Grilla, string Campo, string Propiedad, string Formulario )
		{
			tui_ConfiguracionGrillasDataset data = new tui_ConfiguracionGrillasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillas" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillas_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Grilla" ].Value = Grilla;
			cmd.Parameters.Add( new SqlParameter( "@Campo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Campo" ].Value = Campo;
			cmd.Parameters.Add( new SqlParameter( "@Propiedad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Propiedad" ].Value = Propiedad;
			cmd.Parameters.Add( new SqlParameter( "@Formulario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Formulario" ].Value = Formulario;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow NewRow()
		{
			return ( new tui_ConfiguracionGrillasDataset() ).tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
		}
	
		public static tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow GetByPk( long IdProceso, long IdTarea, string Grilla, string Campo, string Propiedad )
		{
			tui_ConfiguracionGrillasDataset data = new tui_ConfiguracionGrillasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			cmd.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Grilla" ].Value = Grilla;
			
			cmd.Parameters.Add( new SqlParameter( "@Campo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Campo" ].Value = Campo;
			
			cmd.Parameters.Add( new SqlParameter( "@Propiedad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Propiedad" ].Value = Propiedad;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillas" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionGrillas.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow )data.tui_ConfiguracionGrillas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasDataTable )row.Table ).Addtui_ConfiguracionGrillasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tui_ConfiguracionGrillasDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionGrillas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
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
		public static void Update( DataTable dataTable , string IdTransaction)
		{
			SqlTransaction cnx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, cnx);
			
		}


		
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "Grilla", "Grilla" ),
																											 new System.Data.Common.DataColumnMapping( "Campo", "Campo" ),
																											 new System.Data.Common.DataColumnMapping( "Propiedad", "Propiedad" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "ValorDefault", "ValorDefault" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionGrillas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Campo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Propiedad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorDefault", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldGrilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldCampo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Campo", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldPropiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Propiedad", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionGrillas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Campo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Propiedad", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Campo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Propiedad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorDefault", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

        #region Matias 20101018 - Tarea 898
        //Matias 20101018 - Tarea 898
        public static void Update(DataTable data, SentenciasReplicacion replicacion)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update(data, trx, replicacion);
                trx.Commit();
            }
            catch (Exception e)
            {
                trx.Rollback();
                //Debug.WriteLine(e.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private static SentenciasReplicacion _replication;
        public static void Update(DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "Grilla", "Grilla" ),
																											 new System.Data.Common.DataColumnMapping( "Campo", "Campo" ),
																											 new System.Data.Common.DataColumnMapping( "Propiedad", "Propiedad" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "ValorDefault", "ValorDefault" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tui_ConfiguracionGrillas_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Campo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Propiedad", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Descripcion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ValorDefault", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Comentario", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldGrilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldCampo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Campo", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldPropiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Propiedad", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tui_ConfiguracionGrillas_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Campo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Propiedad", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillas_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Campo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Campo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Propiedad", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Propiedad", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Descripcion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@ValorDefault", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ValorDefault", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Comentario", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));

            #region Replicacion
            _replication = replicacion;
            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            #endregion

            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;
            adapter.Update(dataTable);
        }

        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            try
            {
                StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
                if (_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
                    _replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //FinMatias 20101018 - Tarea 898
        #endregion
		
	}
}

