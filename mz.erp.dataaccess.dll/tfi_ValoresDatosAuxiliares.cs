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
	


	public class tfi_ValoresDatosAuxiliares : IDisposable
	{

		#region Custom Members
		public static DataSet  GetHTML(string IdValor)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_ValoresDatosAuxiliares" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_GetHTML", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );

			return data;
		}
		#endregion

		public tfi_ValoresDatosAuxiliares()
		{
		}

		public static tfi_ValoresDatosAuxiliaresDataset GetList()
		{
			tfi_ValoresDatosAuxiliaresDataset data = new tfi_ValoresDatosAuxiliaresDataset();

			return ( tfi_ValoresDatosAuxiliaresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_ValoresDatosAuxiliares" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );

			return data;
		}

		public static tfi_ValoresDatosAuxiliaresDataset GetList(string IdValor )
		{
			
				tfi_ValoresDatosAuxiliaresDataset data = new tfi_ValoresDatosAuxiliaresDataset();

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tfi_ValoresDatosAuxiliares" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdValor" ].Value = IdValor;

				adapter.SelectCommand = cmd;

				adapter.Fill( data );

				return data;
			
		}

		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow NewRow()
		{
			return ( new tfi_ValoresDatosAuxiliaresDataset() ).tfi_ValoresDatosAuxiliares.Newtfi_ValoresDatosAuxiliaresRow();
		}

		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow GetByPk( string IdValor )
		{
			tfi_ValoresDatosAuxiliaresDataset data = new tfi_ValoresDatosAuxiliaresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_GetByPk", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_ValoresDatosAuxiliares" );

			adapter.Fill( data );

			if ( data.tfi_ValoresDatosAuxiliares.Rows.Count == 1 )
			{
				return ( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow )data.tfi_ValoresDatosAuxiliares.Rows[ 0 ];
			}

			return null;
		}

		public static void Update( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresDataTable )row.Table ).Addtfi_ValoresDatosAuxiliaresRow( row );
			}

			Update( row.Table );
		}

		public static void Update( tfi_ValoresDatosAuxiliaresDataset dataSet )
		{
			Update( dataSet.tfi_ValoresDatosAuxiliares );
		}

		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			SentenciasReplicacion replication = null;

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx , replication);
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

		public static void Update(System.Data.DataTable dataTable, string IdTransaction, SentenciasReplicacion replication )		
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx, replication);
		}

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.AddRange(
					new System.Data.Common.DataTableMapping[] {
																  new System.Data.Common.DataTableMapping( "Table", "tfi_ValoresDatosAuxiliares",
																  new System.Data.Common.DataColumnMapping[] {
																												 new System.Data.Common.DataColumnMapping( "IdValor", "IdValor" ),
																												 new System.Data.Common.DataColumnMapping( "CODIGO_AUT_TC_TD_TCCUO_", "CODIGO_AUT_TC_TD_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "CUPON_TC_TD_TCCUO_", "CUPON_TC_TD_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_ACREDIT_TC_TCCUO_", "FECHA_ACREDIT_TC_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_AUT_TC_TD_TCCUO_", "FECHA_AUT_TC_TD_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "LOTE_TC_TD_TCCUO_", "LOTE_TC_TD_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "CANTIDAD_CUOTAS_TCCUO_", "CANTIDAD_CUOTAS_TCCUO_" ),
																												 new System.Data.Common.DataColumnMapping( "CTA_BANCARIA_CHE_T_C_DT_D_DP_", "CTA_BANCARIA_CHE_T_C_DT_D_DP_" ),
																												 new System.Data.Common.DataColumnMapping( "LIBRADOR_CHE_T_DT_", "LIBRADOR_CHE_T_DT_" ),
																												 new System.Data.Common.DataColumnMapping( "SUCURSAL_CHE_T_C_DT_D_DP_", "SUCURSAL_CHE_T_C_DT_D_DP_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_PAGO_CHE_T_DT_", "FECHA_PAGO_CHE_T_DT_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_RECEP_CHE_T_C_DT_D_", "FECHA_RECEP_CHE_T_C_DT_D_" ),
																												 new System.Data.Common.DataColumnMapping( "TIPO_RETENCION_RET_", "TIPO_RETENCION_RET_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_INGRESO_RET_", "FECHA_INGRESO_RET_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHA_COMP_RET_", "FECHA_COMP_RET_" ),
																												 new System.Data.Common.DataColumnMapping( "NROBOLETA_CHE_T_C_DT_D_", "NROBOLETA_CHE_T_C_DT_D_" ),
																												 new System.Data.Common.DataColumnMapping( "FECHAINGBANCO_CHE_T_C_DT_D_", "FECHAINGBANCO_CHE_T_C_DT_D_" ),
																												 new System.Data.Common.DataColumnMapping( "CODIGO10_TC_TD_TCCUO_", "CODIGO10_TC_TD_TCCUO_" ),
																												new System.Data.Common.DataColumnMapping( "DESTINATARIO_CHE_DP_", "DESTINATARIO_CHE_DP_" ),
																												new System.Data.Common.DataColumnMapping( "SELLADO_CHE_T_C_DT_D_DP_", "SELLADO_CHE_T_C_DT_D_DP_" ),
																												new System.Data.Common.DataColumnMapping( "CRUZADO_CHE_T_C_DT_D_DP_", "CRUZADO_CHE_T_C_DT_D_DP_" ),
																												 new System.Data.Common.DataColumnMapping( "IDBANCO_CHE_DP_", "IDBANCO_CHE_DP_" ),
																												 new System.Data.Common.DataColumnMapping( "BANCO_CHE_DP_", "BANCO_CHE_DP_" ),
																												 new System.Data.Common.DataColumnMapping( "IDDESTINATARIO_CHE_DP_", "IDDESTINATARIO_CHE_DP_" )
																											 }
																  )
															  }
					);

				SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_Update", trx.Connection );
				sqlCommandUpdate.Transaction = trx;
				sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CODIGO_AUT_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CODIGO_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CUPON_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CUPON_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_ACREDIT_TC_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_ACREDIT_TC_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_AUT_TC_TD_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@LOTE_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LOTE_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CANTIDAD_CUOTAS_TCCUO_", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CANTIDAD_CUOTAS_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CTA_BANCARIA_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CTA_BANCARIA_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@LIBRADOR_CHE_T_DT_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LIBRADOR_CHE_T_DT_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SUCURSAL_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SUCURSAL_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_PAGO_CHE_T_DT_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_PAGO_CHE_T_DT_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_RECEP_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_RECEP_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdValor", DataRowVersion.Original, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TIPO_RETENCION_RET_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TIPO_RETENCION_RET_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_INGRESO_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_INGRESO_RET_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_COMP_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_COMP_RET_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NROBOLETA_CHE_T_C_DT_D_", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NROBOLETA_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHAINGBANCO_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHAINGBANCO_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CODIGO10_TC_TD_TCCUO_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CODIGO10_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DESTINATARIO_CHE_DP_", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CRUZADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CRUZADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SELLADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SELLADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IDDESTINATARIO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDDESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IDBANCO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDBANCO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@BANCO_CHE_DP_", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "BANCO_CHE_DP_", DataRowVersion.Current, null ) );

				SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_ValoresDatosAuxiliares_Delete", trx.Connection );
				sqlCommandDelete.Transaction = trx;
				sqlCommandDelete.CommandType = CommandType.StoredProcedure;
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Original, null ) );
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );

				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_ValoresDatosAuxiliares_Insert", trx.Connection );
				sqlCommandInsert.Transaction = trx;
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CODIGO_AUT_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CODIGO_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CUPON_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CUPON_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_ACREDIT_TC_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_ACREDIT_TC_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_AUT_TC_TD_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@LOTE_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "LOTE_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CANTIDAD_CUOTAS_TCCUO_", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CANTIDAD_CUOTAS_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CTA_BANCARIA_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CTA_BANCARIA_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@LIBRADOR_CHE_T_DT_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "LIBRADOR_CHE_T_DT_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@SUCURSAL_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SUCURSAL_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_PAGO_CHE_T_DT_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_PAGO_CHE_T_DT_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_RECEP_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_RECEP_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@TIPO_RETENCION_RET_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TIPO_RETENCION_RET_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_INGRESO_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_INGRESO_RET_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_COMP_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FECHA_COMP_RET_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@NROBOLETA_CHE_T_C_DT_D_", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NROBOLETA_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHAINGBANCO_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHAINGBANCO_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CODIGO10_TC_TD_TCCUO_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CODIGO10_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@DESTINATARIO_CHE_DP_", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CRUZADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CRUZADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@SELLADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SELLADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IDDESTINATARIO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDDESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IDBANCO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDBANCO_CHE_DP_", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@BANCO_CHE_DP_", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "BANCO_CHE_DP_", DataRowVersion.Current, null ) );

			
				_replication = replication;
				
				adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

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
