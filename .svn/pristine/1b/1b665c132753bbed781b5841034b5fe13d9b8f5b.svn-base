using System;

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

	public class tpu_ComprobantesRelacionOrigenDestino : IDisposable
	{
	
		#region Custom Members
			
			private static SentenciasReplicacion _replication;	
			
		#endregion
		
		public tpu_ComprobantesRelacionOrigenDestino()
		{
		}

		public static tpu_ComprobantesRelacionOrigenDestinoDataset GetList()
		{
			tpu_ComprobantesRelacionOrigenDestinoDataset data = new tpu_ComprobantesRelacionOrigenDestinoDataset();

			return ( tpu_ComprobantesRelacionOrigenDestinoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesRelacionOrigenDestino" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesRelacionOrigenDestinoDataset GetList( string IdComprobanteOrigen, string IdComprobanteDestino )
		{
			tpu_ComprobantesRelacionOrigenDestinoDataset data = new tpu_ComprobantesRelacionOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesRelacionOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow NewRow()
		{
			return ( new tpu_ComprobantesRelacionOrigenDestinoDataset() ).tpu_ComprobantesRelacionOrigenDestino.Newtpu_ComprobantesRelacionOrigenDestinoRow();
		}
	
		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow GetByPk( string IdComprobanteOrigen, string IdComprobanteDestino )
		{
			tpu_ComprobantesRelacionOrigenDestinoDataset data = new tpu_ComprobantesRelacionOrigenDestinoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesRelacionOrigenDestino" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesRelacionOrigenDestino.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow )data.tpu_ComprobantesRelacionOrigenDestino.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoDataTable )row.Table ).Addtpu_ComprobantesRelacionOrigenDestinoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesRelacionOrigenDestino );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{			
				Update( ( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoDataTable )dataTable, trx);
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
		/// <summary>
		/// This function is deprecated
		/// </summary>
		/// <param name="dataTable"></param>
		/// <param name="trx"></param>
		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoDataTable dataTable, SqlTransaction trx)
		{
			string IdSentenciaReplicacion = "-1";
			//Update( ( DataTable )dataTable, trx, ref IdSentenciaReplicacion);
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
				
		private static bool Update( DataRow row, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesRelacionOrigenDestino", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdRelacionOrigenDestino", "IdRelacionOrigenDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteOrigen", "IdComprobanteOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteDestino", "IdComprobanteDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalOrigen", "IdOrdinalOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalDestino", "IdOrdinalDestino" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),																									 
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Update", trx.Connection  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@IdRelacionOrigenDestino", SqlDbType.BigInt ));
			cmd.Parameters["@IdRelacionOrigenDestino"].Value = row["IdRelacionOrigenDestino"];		

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ));
			if (row["IdComprobanteOrigen"] != System.DBNull.Value  && (string)row["IdComprobanteOrigen"] == Convert.ToString( long.MaxValue ))
			{
				cmd.Parameters["@IdComprobanteOrigen"].Value= IdComprobanteGenerado;
			}
			else
			{
				cmd.Parameters["@IdComprobanteOrigen"].Value = row["IdComprobanteOrigen"];
			}
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ));
			if ((string)row["IdComprobanteDestino"] == Convert.ToString( long.MaxValue ))
			{
				cmd.Parameters["IdComprobanteDestino"].Value = IdComprobanteGenerado;
			}
			else
			{
				cmd.Parameters["@IdComprobanteDestino"].Value = row["IdComprobanteDestino"];
			}

			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt ));
			if (row["IdOrdinalOrigen"] != System.DBNull.Value  && (long)row["IdOrdinalOrigen"] != long.MinValue)
			{
				cmd.Parameters["@IdOrdinalOrigen"].Value = row["IdOrdinalOrigen"];
			}
			else
			{
				cmd.Parameters["@IdOrdinalOrigen"].Value = System.DBNull.Value;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt ));
			if ((long)row["IdOrdinalDestino"] != long.MinValue)
			{
				cmd.Parameters["@IdOrdinalDestino"].Value = row["IdOrdinalDestino"];
			}
			else
			{
				cmd.Parameters["@IdOrdinalDestino"].Value = System.DBNull.Value;
			}
			


			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal));
			cmd.Parameters["@Cantidad"].Value = row["Cantidad"];

			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );

			/*cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime));
			cmd.Parameters["@FechaCreacion"].Value = row["FechaCreacion"];*/

			/*cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt));
			cmd.Parameters["@IdConexionCreacion"].Value = row["IdConexionCreacion"];*/

			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt));
			cmd.Parameters["@IdReservado"].Value = row["IdReservado"];

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt));
			cmd.Parameters["@IdEmpresa"].Value = row["IdEmpresa"];

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt));
			cmd.Parameters["@IdSucursal"].Value = row["IdSucursal"];

			cmd.Parameters.Add( new SqlParameter( "@OldIdRelacionOrigenDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdRelacionOrigenDestino", DataRowVersion.Original, null ) );

			/*	cmd.Parameters.Add( new SqlParameter( "@NombreTabla", SqlDbType.VarChar));
				cmd.Parameters["@NombreTabla"].Value = "dataaccess.tpu_ComprobantesRelacionOrigenDestino";

				cmd.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.BigInt));
				cmd.Parameters["@IdSentenciaReplicacion"].Value = System.DBNull.Value;*/

			
			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			adapter.UpdateCommand = cmd;
			adapter.Update(new System.Data.DataRow[] {row});
			return true;

		}
		private static bool Insert( DataRow row, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Insert", trx.Connection );
			cmd.Transaction = trx;
			cmd.CommandType = CommandType.StoredProcedure;
			

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ));
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ));
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt ));
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt ));

			//De un comprobante a otro
			if (row["IdComprobanteOrigen"] != row["IdComprobanteDestino"])
			{
				if (row["IdComprobanteOrigen"] == null || Convert.ToString(row["IdComprobanteOrigen"]) == String.Empty ) // == Convert.ToString( long.MaxValue ))
				{
					cmd.Parameters["@IdComprobanteOrigen"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@IdComprobanteOrigen"].Value = row["IdComprobanteOrigen"];
				}

				
				if (row["IdComprobanteDestino"] == null || Convert.ToString(row["IdComprobanteDestino"]) == String.Empty ) 
				{
					cmd.Parameters["IdComprobanteDestino"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@IdComprobanteDestino"].Value = IdComprobanteGenerado;
				}

			

				if ((long)row["IdOrdinalOrigen"] == long.MinValue)
				{
					cmd.Parameters["@IdOrdinalOrigen"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@IdOrdinalOrigen"].Value = row["IdOrdinalOrigen"];
				}
			
			
				if ((long)row["IdOrdinalDestino"] == long.MinValue)
				{
					cmd.Parameters["@IdOrdinalDestino"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@IdOrdinalDestino"].Value = row["IdOrdinalDestino"];
				}
			
			}
				//Es un cierre
			else
			{
				cmd.Parameters["@IdComprobanteOrigen"].Value = IdComprobanteGenerado;
				cmd.Parameters["@IdComprobanteDestino"].Value = System.DBNull.Value;
				cmd.Parameters["@IdOrdinalOrigen"].Value = row["IdOrdinalDestino"];
				cmd.Parameters["@IdOrdinalDestino"].Value = System.DBNull.Value;
			}

			
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal));
			cmd.Parameters["@Cantidad"].Value = row["Cantidad"];

			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime));
			cmd.Parameters["@FechaCreacion"].Value = row["FechaCreacion"];

			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt));
			cmd.Parameters["@IdConexionCreacion"].Value = row["IdConexionCreacion"];

			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt));
			cmd.Parameters["@IdReservado"].Value = row["IdReservado"];

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt));
			cmd.Parameters["@IdEmpresa"].Value = row["IdEmpresa"];

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt));
			cmd.Parameters["@IdSucursal"].Value = row["IdSucursal"];


			cmd.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier));
			cmd.Parameters["@RowIdGenerado"].Value = System.DBNull.Value;
			cmd.Parameters["@RowIdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;
			


			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion



			adapter.InsertCommand = cmd;
			adapter.Update( new System.Data.DataRow[] {row});
			return true;
						
			
		}

		private static bool Delete( DataRow row, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Delete", trx.Connection );
			cmd.Transaction = trx;
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdRelacionOrigenDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRelacionOrigenDestino", DataRowVersion.Original, null ) );
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );


			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion



			adapter.DeleteCommand = cmd;
			adapter.Update( row.Table);
			return true;
						
			
		}
		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			/*foreach (System.Data.DataRow row in dataTable.Rows)
			{
				switch (row.RowState)
				{
					case (System.Data.DataRowState.Added):
						Insert( row, trx, replicacion, IdComprobanteGenerado );
						break;
					case (System.Data.DataRowState.Modified):
						Update( row, trx, replicacion, IdComprobanteGenerado );
						break;
					case (System.Data.DataRowState.Deleted):
						Delete( row, trx, replicacion, IdComprobanteGenerado );
						break;
				}
			}*/

			foreach (System.Data.DataRow row in dataTable.Rows)
			{
				switch (row.RowState)
				{
					case (System.Data.DataRowState.Added):
					{
						//De un comprobante a otro
						if (row["IdComprobanteOrigen"] != row["IdComprobanteDestino"])
						{
							if (row["IdComprobanteOrigen"] == null || Convert.ToString(row["IdComprobanteOrigen"]) == String.Empty ) // == Convert.ToString( long.MaxValue ))
							{
								row["IdComprobanteOrigen"] = System.DBNull.Value;
							}
				
							if (row["IdComprobanteDestino"] == null || Convert.ToString(row["IdComprobanteDestino"]) == String.Empty ) 
							{
								row["IdComprobanteDestino"] = System.DBNull.Value;
							}
							else
							{
								row["IdComprobanteDestino"] = IdComprobanteGenerado;
							}			

							if ((long)row["IdOrdinalOrigen"] == long.MinValue)
							{
								row["IdOrdinalOrigen"] = System.DBNull.Value;
							}
			
							if ((long)row["IdOrdinalDestino"] == long.MinValue)
							{
								row["IdOrdinalDestino"] = System.DBNull.Value;
							}
			
						}
							//Es un cierre
						else
						{
							row["IdComprobanteOrigen"] = IdComprobanteGenerado;
							row["IdComprobanteDestino"] = System.DBNull.Value;
							row["IdOrdinalOrigen"] = row["IdOrdinalDestino"];
							row["IdOrdinalDestino"] = System.DBNull.Value;
						}

						break;
					}
					case (System.Data.DataRowState.Modified):
					{
						if (row["IdComprobanteOrigen"] != System.DBNull.Value  && (string)row["IdComprobanteOrigen"] == Convert.ToString( long.MaxValue ))
						{
							row["IdComprobanteOrigen"]= IdComprobanteGenerado;
						}

						if ((string)row["IdComprobanteDestino"] == Convert.ToString( long.MaxValue ))
						{
							row["IdComprobanteDestino"] = IdComprobanteGenerado;
						}

						if (row["IdOrdinalOrigen"] == System.DBNull.Value  || (long)row["IdOrdinalOrigen"] == long.MinValue)
						{
							row["IdOrdinalOrigen"] = System.DBNull.Value;
						}
			
						if ((long)row["IdOrdinalDestino"] == long.MinValue)
						{
							row["IdOrdinalDestino"] = System.DBNull.Value;
						}
						break;
					}
				}
			}
		


			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesRelacionOrigenDestino", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdRelacionOrigenDestino", "IdRelacionOrigenDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteOrigen", "IdComprobanteOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteDestino", "IdComprobanteDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalOrigen", "IdOrdinalOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalDestino", "IdOrdinalDestino" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),																									 
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdRelacionOrigenDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdRelacionOrigenDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdRelacionOrigenDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdRelacionOrigenDestino", DataRowVersion.Original, null ) );

			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesRelacionOrigenDestino_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdRelacionOrigenDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRelacionOrigenDestino", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesRelacionOrigenDestino_Insert", trx.Connection );			
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );

			#region Replicacion

			_replication = replicacion;
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
