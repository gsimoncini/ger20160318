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

	public class tsa_ComprobantesRelacionOrigenDestino : IDisposable
	{
	
		#region Custom Members
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

		public static DataTable ValidarFlujo(string IdTransaction,string IdComprobanteOrigen, long OrdinalOrigen,string IdTipoDeComprobanteDestino)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			tsa_ComprobantesRelacionOrigenDestinoDataset data = new tsa_ComprobantesRelacionOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesRelacionOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_ValidarFlujo", trx.Connection );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Transaction = trx;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			
			
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdinalOrigen" ].Value = OrdinalOrigen;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobanteDestino" ].Value = IdTipoDeComprobanteDestino;
			
			
			adapter.SelectCommand = cmd;
			
			adapter.Fill( data );
         
			return data.Tables[0];
		}



		#endregion
		
		public tsa_ComprobantesRelacionOrigenDestino()
		{
		}

		public static tsa_ComprobantesRelacionOrigenDestinoDataset GetList()
		{
			tsa_ComprobantesRelacionOrigenDestinoDataset data = new tsa_ComprobantesRelacionOrigenDestinoDataset();

			return ( tsa_ComprobantesRelacionOrigenDestinoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesRelacionOrigenDestino" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_ComprobantesRelacionOrigenDestinoDataset GetList( string IdComprobanteOrigen, string IdComprobanteDestino, long IdOrdinalOrigen, long IdOrdinalDestino )
		{
			tsa_ComprobantesRelacionOrigenDestinoDataset data = new tsa_ComprobantesRelacionOrigenDestinoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesRelacionOrigenDestino" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt ) );
			if ( IdOrdinalOrigen == long.MinValue )
			{
				cmd.Parameters[ "@IdOrdinalOrigen" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdOrdinalOrigen" ].Value = IdOrdinalOrigen;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt ) );
			if ( IdOrdinalDestino == long.MinValue )
			{
				cmd.Parameters[ "@IdOrdinalDestino" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdOrdinalDestino" ].Value = IdOrdinalDestino;
			}
			adapter.SelectCommand = cmd;
			
			adapter.Fill( data );
         
			return data;
		}

		public static tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow NewRow()
		{
			return ( new tsa_ComprobantesRelacionOrigenDestinoDataset() ).tsa_ComprobantesRelacionOrigenDestino.Newtsa_ComprobantesRelacionOrigenDestinoRow();
		}
	
		public static tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow GetByPk( string IdComprobanteOrigen, string IdComprobanteDestino )
		{
			tsa_ComprobantesRelacionOrigenDestinoDataset data = new tsa_ComprobantesRelacionOrigenDestinoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesRelacionOrigenDestino" );

			adapter.Fill( data );

			if ( data.tsa_ComprobantesRelacionOrigenDestino.Rows.Count == 1 )
			{
				return ( tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow )data.tsa_ComprobantesRelacionOrigenDestino.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoDataTable )row.Table ).Addtsa_ComprobantesRelacionOrigenDestinoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_ComprobantesRelacionOrigenDestinoDataset dataSet )
		{
			Update( dataSet.tsa_ComprobantesRelacionOrigenDestino );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{			
				Update( ( tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoDataTable )dataTable, trx);
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
		public static void Update( tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoDataTable dataTable, SqlTransaction trx)
		{
			//string IdSentenciaReplicacion = "-1";
			//Update( ( DataTable )dataTable, trx, ref IdSentenciaReplicacion);
		}
				
		
		private static bool Update( DataRow row, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_Update", trx.Connection  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ));
			if ((string)row["IdComprobanteOrigen"] == Convert.ToString( long.MaxValue ))
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
			if ((long)row["IdOrdinalOrigen"] != long.MinValue)
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

			cmd.Parameters.Add( new SqlParameter( "@OldIdComprobanteOrigen", SqlDbType.VarChar));
			cmd.Parameters["@OldIdComprobanteOrigen"].Value = row["OldIdComprobanteOrigen"];

			cmd.Parameters.Add( new SqlParameter( "@OldIdComprobanteDestino", SqlDbType.VarChar));
			cmd.Parameters["@OldIdComprobanteDestino"].Value = row["OldIdComprobanteDestino"];
			
		/*	cmd.Parameters.Add( new SqlParameter( "@NombreTabla", SqlDbType.VarChar));
			cmd.Parameters["@NombreTabla"].Value = "dataaccess.tsa_ComprobantesRelacionOrigenDestino";

			cmd.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.VarChar));
			cmd.Parameters["@IdSentenciaReplicacion"].Value = IdSentenciaReplicacion;*/

			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion
			
			adapter.InsertCommand = cmd;
			adapter.Update(row.Table);
			return true;

		}
		private static bool Insert( DataRow row, SqlTransaction trx, SentenciasReplicacion replicacion, string IdComprobanteGenerado)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_Insert", trx.Connection );
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

			
			cmd.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			


			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			adapter.InsertCommand = cmd;
			adapter.Update( new System.Data.DataRow[] {row});
			return true;
						
			
		}
		public static void Update( DataTable dataTable, string IdTransaction, SentenciasReplicacion replicacion, string IdComprobanteDestino)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update( dataTable, trx, replicacion, IdComprobanteDestino );
		}
		public static void Update( DataTable dataTable, SqlTransaction trx,SentenciasReplicacion replicacion, string IdComprobanteDestino)
		{
			foreach (System.Data.DataRow row in dataTable.Rows)
			{
				switch (row.RowState)
				{
					case (System.Data.DataRowState.Added):
						Insert( row, trx, replicacion, IdComprobanteDestino );
						break;
					case (System.Data.DataRowState.Modified):
						Update( row, trx, replicacion, IdComprobanteDestino );
						break;
				}
			}
			/*SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_ComprobantesRelacionOrigenDestino", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteOrigen", "IdComprobanteOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteDestino", "IdComprobanteDestino" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalOrigen", "IdOrdinalOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdinalDestino", "IdOrdinalDestino" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteDestino", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_ComprobantesRelacionOrigenDestino_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_ComprobantesRelacionOrigenDestino_Insert", trx.Connection );			
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			SqlParameter parametroIO = new SqlParameter();
			parametroIO.ParameterName = "@IdSentenciaReplicacion";
			parametroIO.SqlDbType = SqlDbType.BigInt;
			parametroIO.Size = 0;
			parametroIO.Direction = ParameterDirection.InputOutput;
			parametroIO.Value = IdSentenciaReplicacion;
			sqlCommandInsert.Parameters.Add (parametroIO);
			sqlCommandInsert.Parameters.Add("@NombreTabla", SqlDbType.VarChar, 300).Value = "dataaccess.tsa_ComprobantesRelacionOrigenDestino";
			
			//Parametros adicionales para las modificaciones de replicacion			
			sqlCommandInsert.Parameters.Add("@GeneraReplicacion", SqlDbType.Bit).Value = 1;

			
			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );

			IdSentenciaReplicacion = parametroIO.Value.ToString();*/
		}
		
		public void Dispose()
		{
		}

		
	}
}

