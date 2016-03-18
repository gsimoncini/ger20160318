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


	public class tsa_Comprobantes : IDisposable
	{
	
		#region Custom Members

        /* Silvina 20110704 - Tarea 0000136 */
        public static DataTable ReimprimeTicketDeCambio(string IdComprobante)
        {
            DataSet data = new DataSet();

            SqlCommand cmd = new SqlCommand("Pr_tsa_Comprobantes_ReimprimeTicketDeCambio", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobante"].Value = IdComprobante;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_Comprobantes");

            adapter.Fill(data);

            return data.Tables[0];	
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

		public static DataTable GetComprobanteDePagoView(string IdComprobanteDePago)
		{
			
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_Tsa_ComprobanteDePago_View", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobanteDePago;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );

			adapter.Fill( data );

			
			return data.Tables[0];	
		}

		public static bool ExistsNumeration(string numero,  string idTipoComprobante)
		{
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_ExistsNumeration", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Numero" ].Value = numero;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobante" ].Value = idTipoComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );
			DataSet data = new DataSet();
			adapter.Fill( data );

			return data.Tables[0].Rows.Count > 0;

		}




		public static System.Data.DataSet GetByPk( DataSet data , string IdComprobante )
		{
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );

			adapter.Fill( data );

			
			return data;
		}


		private static SentenciasReplicacion _replication;
		
		#endregion
		
		public tsa_Comprobantes()
		{
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_ComprobantesDataset GetList(  )
		{
			tsa_ComprobantesDataset data = new tsa_ComprobantesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataTable GetListByNroYTipoComprobante( string nroComprobante, string idTipoComprobante )
		{
			tsa_ComprobantesDataset data = new tsa_ComprobantesDataset();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_GetListByNroYTipoComprobante", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@nroComprobante", SqlDbType.VarChar ) );
			if (nroComprobante==null || nroComprobante.Equals(string.Empty))
				cmd.Parameters[ "@nroComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@nroComprobante" ].Value = nroComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@idTipoComprobante", SqlDbType.VarChar ) );
			if (idTipoComprobante==null || idTipoComprobante.Equals(string.Empty))
				cmd.Parameters[ "@idTipoComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@idTipoComprobante" ].Value = idTipoComprobante;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data.Tables[0];
		}

        //Matias - 20110906 - Tarea 0000131
        public static DataRow GetByNroComprobante(string nroComprobante)
        {
            tsa_ComprobantesDataset data = new tsa_ComprobantesDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsa_Comprobantes");

            SqlCommand cmd = new SqlCommand("Pr_tsa_Comprobantes_GetByNroComprobante", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@nroComprobante", SqlDbType.VarChar));
            if (nroComprobante == null || nroComprobante.Equals(string.Empty))
                cmd.Parameters["@nroComprobante"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@nroComprobante"].Value = nroComprobante;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            if (data.tsa_Comprobantes.Rows.Count == 1)
            {
                return (tsa_ComprobantesDataset.tsa_ComprobantesRow)data.tsa_Comprobantes.Rows[0];
            }

            return null;
        }
        //FinMatias - 20110906 - Tarea 0000131

		public static tsa_ComprobantesDataset.tsa_ComprobantesRow NewRow()
		{
			return ( new tsa_ComprobantesDataset() ).tsa_Comprobantes.Newtsa_ComprobantesRow();
		}
	
		public static tsa_ComprobantesDataset.tsa_ComprobantesRow GetByPk( string IdComprobante )
		{
			tsa_ComprobantesDataset data = new tsa_ComprobantesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );

			adapter.Fill( data );

			if ( data.tsa_Comprobantes.Rows.Count == 1 )
			{
				return ( tsa_ComprobantesDataset.tsa_ComprobantesRow )data.tsa_Comprobantes.Rows[ 0 ];
			}
			
			return null;
		}

		//Cristian Tarea 0000064 20110317
        public static void UpdateNroDeComprobante(string IdTransaction, string IdComprobante, string nroDeComprobante)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);

            SqlCommand cmd = new SqlCommand("Pr_tsa_Comprobantes_UpdateNroComprobante");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = trx.Connection;
            cmd.Transaction = trx;

            cmd.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.VarChar));
            if (IdComprobante == null || IdComprobante.Equals(string.Empty))
                cmd.Parameters["@IdComprobante"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@IdComprobante"].Value = IdComprobante;

            cmd.Parameters.Add(new SqlParameter("@NroDeComprobante", SqlDbType.VarChar));
            if (nroDeComprobante == null || nroDeComprobante.Equals(string.Empty))
                cmd.Parameters["@NroDeComprobante"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@NroDeComprobante"].Value = nroDeComprobante;

            cmd.ExecuteNonQuery();
        }
        //Fin Cristian
		public static void UpdateIdTipoDeComprobante(string IdTransaction, string IdComprobante, string IdTipoDeComprobante)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Comprobantes_UpdateIdTipoComprobante");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante==null || IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@idTipoDeComprobante", SqlDbType.VarChar ) );
			if (IdTipoDeComprobante==null || IdTipoDeComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

			cmd.ExecuteNonQuery();
		}

		public static void Update( tsa_ComprobantesDataset.tsa_ComprobantesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_ComprobantesDataset.tsa_ComprobantesDataTable )row.Table ).Addtsa_ComprobantesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_ComprobantesDataset dataSet )
		{
			Update( dataSet.tsa_Comprobantes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				string IdSentenciaReplicacion = "-1";
				//Update( dataTable, trx, ref IdSentenciaReplicacion);
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
		public static void Update( DataTable dataTable, string IdTransaction, SentenciasReplicacion replication)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update( dataTable, trx, replication );

		}
		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_Comprobantes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																											 new System.Data.Common.DataColumnMapping( "Fecha", "Fecha" ),
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "Total", "Total" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierre", "IdMonedaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionCierre", "IdCotizacionCierre" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),	
																											 new System.Data.Common.DataColumnMapping( "IdGenerado", "IdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "Cliente", "Cliente" ),
																											 new System.Data.Common.DataColumnMapping( "Domicilio", "Domicilio" ),
																											 new System.Data.Common.DataColumnMapping( "TipoDocumento", "TipoDocumento" ),
																											 new System.Data.Common.DataColumnMapping( "Documento", "Documento" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "Aux1", "Aux1" ),
																											 new System.Data.Common.DataColumnMapping( "Aux2", "Aux2" ),
																											 new System.Data.Common.DataColumnMapping( "Aux3", "Aux3" ),
																											 new System.Data.Common.DataColumnMapping( "IdCondicionDeVenta", "IdCondicionDeVenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdCotizacionCierreDolarOficial", "IdCotizacionCierreDolarOficial" ),
                                                                                                             //German 20111201 - Tarea 0000232
                                                                                                             new System.Data.Common.DataColumnMapping( "FechaVencimientoReserva", "FechaVencimientoReserva" )
                                                                                                             //Fin German 20111201 - Tarea 0000232
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_Comprobantes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cliente", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cliente", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TipoDocumento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar, 13, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Documento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux3", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierreDolarOficial", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionCierreDolarOficial", DataRowVersion.Current, null ) );
            //German 20111201 - Tarea 0000232
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaVencimientoReserva", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVencimientoReserva", DataRowVersion.Current, null));
            //Fin German 20111201 - Tarea 0000232
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_Comprobantes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_Comprobantes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );												
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cliente", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cliente", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TipoDocumento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar, 13, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Documento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux3", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierreDolarOficial", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionCierreDolarOficial", DataRowVersion.Current, null ) );
            //German 20111201 - Tarea 0000232
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaVencimientoReserva", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVencimientoReserva", DataRowVersion.Current, null));
            //Fin German 20111201 - Tarea 0000232
			


			#region Replicacion

			_replication = replication;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

	

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

