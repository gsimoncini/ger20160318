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

	public class tfi_ValoresEx : IDisposable
	{
	
		#region Custom Members
		public static tfi_ValoresExDataset GetByPk( DataSet data, string IdValor )
		{
			

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_Valores" );

			adapter.Fill( data );

			return (tfi_ValoresExDataset)data;
		}

		/*public static Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset GetList(string IdTDCompTesoreria)
		{
			Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset  data = new Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset ();

			return ( Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset  )GetList( data ,IdTDCompTesoreria);
		}

		public static Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset GetList(DataSet data,string IdTDCompTesoreria)
		{
			

			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria", dbhelper.Connection.GetConnection()  );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IDTDCompTesoreria" ].Value = IdTDCompTesoreria;
			
				SqlDataAdapter adapter = new SqlDataAdapter( cmd );
				adapter.TableMappings.Add( "Table", "Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria" );
			
				adapter.Fill( data );
				int cant= data.Tables["Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria"].Rows.Count ;}
			catch(Exception e) {Debug.WriteLine(e.Message); Debug.WriteLine(e.StackTrace);}
			

			return (Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset)data;
		}



		public static tfi_ValoresExDataset GetList(string IdTDCompTesoreria)
		{
			tfi_ValoresExDataset  data = new tfi_ValoresExDataset ();

			return ( tfi_ValoresExDataset  )GetList( data ,IdTDCompTesoreria);
		}*/

		public static tfi_ValoresExDataset GetVariablesAuxiliares(DataSet data,string IdValor,string IdTDCompTesoreria)
		{
			

			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria", dbhelper.Connection.GetConnection()  );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IDTDCompTesoreria" ].Value = IdTDCompTesoreria;

				cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IDValor" ].Value = IdValor;
			
				SqlDataAdapter adapter = new SqlDataAdapter( cmd );
				adapter.TableMappings.Add( "Table", "Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria" );
			
				adapter.Fill( data.Tables ["Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria"] );
			
			/*	cmd = new SqlCommand( "Pr_tfi_ValoresVariablesAuxiliares_GetByPk", dbhelper.Connection.GetConnection()  );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdVariableAuxiliarTDCompTesoreria", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IDVariableAuxiliarTDCompTesoreria" ].Value = null;

				cmd.Parameters.Add( new SqlParameter( "@IdValorVariable", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IDValorVariable" ].Value = IdValor;
			
				SqlDataAdapter adapter1 = new SqlDataAdapter( cmd );
				adapter1.TableMappings.Add( "Table", "tfi_ValoresVariablesAuxiliares" );
			
				adapter1.Fill( data.Tables ["tfi_ValoresVariablesAuxiliares"] );*/
			
			
			
			
			
			
			}
				
			catch(Exception e) {;}
			

			return (tfi_ValoresExDataset)data;
		}

		public static tfi_ValoresExDataset GetList( string IdValor, string IdTDCompTesoreria, string Numero, string IdEntidad, DateTime FechaVencimiento, decimal Valor, string IdMoneda, string IdCotizacionMoneda )
		{
			tfi_ValoresExDataset data = new tfi_ValoresExDataset();
			try 
			{

				
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tfi_Valores" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdValor" ].Value = IdValor;
				cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
				cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
				cmd.Parameters[ "@Numero" ].Value = Numero;
				cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
				cmd.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime ) );
				cmd.Parameters[ "@FechaVencimiento" ].Value = FechaVencimiento;
				cmd.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal ) );
				cmd.Parameters[ "@Valor" ].Value = Valor;
				cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdMoneda" ].Value = IdMoneda;
				cmd.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdCotizacionMoneda" ].Value = IdCotizacionMoneda;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e){;}
			return data;
		}







		
		#endregion
		
		

		
		public static tfi_ValoresExDataset.tfi_ValoresRow NewRow()
		{
			return ( new tfi_ValoresExDataset() ).tfi_Valores.Newtfi_ValoresRow();
		}

		
		
		public static void Update( tfi_ValoresExDataset.tfi_ValoresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_ValoresExDataset.tfi_ValoresDataTable )row.Table ).Addtfi_ValoresRow( row );
			}
			
			Update( row.Table );
		}


		public static void Update( tfi_ValoresExDataset dataset, string IdTransaction, SentenciasReplicacion replicacion)
		{
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				Update(dataset.Tables["tfi_Valores"], trx);
				mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update(dataset.Tables["tfi_ValoresDatosAuxiliares"],trx, replicacion);
				//mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.Update(dataset.Tables["tfi_ValoresVariablesAuxiliares"], trx);
		}



		public static void Update( tfi_ValoresExDataset dataSet )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				SqlDataAdapter adapter = Update( dataSet.tfi_Valores, trx );
				tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataTable table=dataSet.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
				for(int i=0; i< table.Rows.Count;i++)
				{
					tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow row=(tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow) table.Rows[i];	
					tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow rowMod=(tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow)dataSet.tfi_ValoresDatosAuxiliares.Rows[i];
				}
				Update(dataSet.tfi_ValoresDatosAuxiliares,trx);
				trx.Commit();

				

			}
			catch (Exception e)
			{
				;
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}


		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_ValoresExDataset.tfi_ValoresDataTable )dataTable, trx );
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

	

		public static SqlDataAdapter Update( System.Data.DataTable dataTable, SqlTransaction trx )
		{
			
			SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.AddRange(
					new System.Data.Common.DataTableMapping[] {
																  new System.Data.Common.DataTableMapping( "Table", "tfi_Valores", 
																  new System.Data.Common.DataColumnMapping[] {
																												 new System.Data.Common.DataColumnMapping( "IdValor", "IdValor" ),
																												 new System.Data.Common.DataColumnMapping( "IdTDCompTesoreria", "IdTDCompTesoreria" ),
																												 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																												 new System.Data.Common.DataColumnMapping( "IdEntidad", "IdEntidad" ),
																												 new System.Data.Common.DataColumnMapping( "Fecha", "Fecha" ),
																												 new System.Data.Common.DataColumnMapping( "FechaVencimiento", "FechaVencimiento" ),
																												 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																												 new System.Data.Common.DataColumnMapping( "IdMoneda", "IdMoneda" ),
																												 new System.Data.Common.DataColumnMapping( "IdCotizacionMoneda", "IdCotizacionMoneda" ),
																												 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																												 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																												 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																												 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																												 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																												 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																												 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																												 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																												 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																												 new System.Data.Common.DataColumnMapping( "Signo", "Signo" ),
																												 new System.Data.Common.DataColumnMapping( "IdEstadoCheque", "IdEstadoCheque" )
																											 }
																  )
															  }
					);
			
				SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_Valores_Update", trx.Connection );
				sqlCommandUpdate.Transaction = trx;
				sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdValor", DataRowVersion.Original, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaCaja", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Signo", SqlDbType.Int, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signo", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEstadoCheque", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEstadoCheque", DataRowVersion.Current, null ) );

				SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_Valores_Delete", trx.Connection );
				sqlCommandDelete.Transaction = trx;
				sqlCommandDelete.CommandType = CommandType.StoredProcedure;
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Original, null ) );
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_Valores_Insert", trx.Connection );
				sqlCommandInsert.Transaction = trx;
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionMoneda", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaCaja", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Signo", SqlDbType.Int, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signo", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstadoCheque", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEstadoCheque", DataRowVersion.Current, null ) );
				
				adapter.UpdateCommand = sqlCommandUpdate;
				adapter.DeleteCommand = sqlCommandDelete;
				adapter.InsertCommand = sqlCommandInsert;
				adapter.Update ( dataTable );
			
				return adapter;
		}


		public static void Update( tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_ValoresDatosAuxiliares", 
															  new System.Data.Common.DataColumnMapping[] {

																											 new System.Data.Common.DataColumnMapping( "IdValor", "IdValor" ),
																											 new System.Data.Common.DataColumnMapping( "SUCURSAL_CHE_T_C_DT_D_DP_", "SUCURSAL_CHE_T_C_DT_D_DP_" ),
																											 new System.Data.Common.DataColumnMapping( "LOTE_TC_TD_TCCUO_", "LOTE_TC_TD_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "LIBRADOR_CHE_T_DT_", "LIBRADOR_CHE_T_DT_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_RECEP_CHE_T_C_DT_D_", "FECHA_RECEP_CHE_T_C_DT_D_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_PAGO_CHE_T_DT_", "FECHA_PAGO_CHE_T_DT_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_AUT_TC_TD_TCCUO_", "FECHA_AUT_TC_TD_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_ACREDIT_TC_TCCUO_", "FECHA_ACREDIT_TC_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "CUPON_TC_TD_TCCUO_", "CUPON_TC_TD_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "CTA_BANCARIA_CHE_T_C_DT_D_DP_", "CTA_BANCARIA_CHE_T_C_DT_D_DP_" ),
																											 new System.Data.Common.DataColumnMapping( "CODIGO_AUT_TC_TD_TCCUO_", "CODIGO_AUT_TC_TD_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "CANTIDAD_CUOTAS_TCCUO_", "CANTIDAD_CUOTAS_TCCUO_" ),
																											 new System.Data.Common.DataColumnMapping( "TIPO_RETENCION_RET_", "TIPO_RETENCION_RET_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_INGRESO_RET_", "FECHA_INGRESO_RET_" ),
																											 new System.Data.Common.DataColumnMapping( "FECHA_COMP_RET_", "FECHA_COMP_RET_" ),
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
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SUCURSAL_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SUCURSAL_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@LOTE_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LOTE_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@LIBRADOR_CHE_T_DT_", SqlDbType.VarChar, 50, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LIBRADOR_CHE_T_DT_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_RECEP_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_RECEP_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_PAGO_CHE_T_DT_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_PAGO_CHE_T_DT_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_AUT_TC_TD_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_ACREDIT_TC_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_ACREDIT_TC_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CUPON_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CUPON_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CTA_BANCARIA_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CTA_BANCARIA_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CODIGO_AUT_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CODIGO_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CANTIDAD_CUOTAS_TCCUO_", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CANTIDAD_CUOTAS_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_INGRESO_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_INGRESO_RET_", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FECHA_COMP_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_COMP_RET_", DataRowVersion.Current, null ) );
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
			
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_ValoresDatosAuxiliares_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SUCURSAL_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SUCURSAL_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@LOTE_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LOTE_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@LIBRADOR_CHE_T_DT_", SqlDbType.VarChar, 50, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LIBRADOR_CHE_T_DT_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_RECEP_CHE_T_C_DT_D_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_RECEP_CHE_T_C_DT_D_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_PAGO_CHE_T_DT_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_PAGO_CHE_T_DT_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_AUT_TC_TD_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_ACREDIT_TC_TCCUO_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_ACREDIT_TC_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CUPON_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CUPON_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CTA_BANCARIA_CHE_T_C_DT_D_DP_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CTA_BANCARIA_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CODIGO_AUT_TC_TD_TCCUO_", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CODIGO_AUT_TC_TD_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CANTIDAD_CUOTAS_TCCUO_", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CANTIDAD_CUOTAS_TCCUO_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TIPO_RETENCION_RET_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TIPO_RETENCION_RET_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_INGRESO_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_INGRESO_RET_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FECHA_COMP_RET_", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FECHA_COMP_RET_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DESTINATARIO_CHE_DP_", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CRUZADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CRUZADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SELLADO_CHE_T_C_DT_D_DP_", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SELLADO_CHE_T_C_DT_D_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IDDESTINATARIO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDDESTINATARIO_CHE_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IDBANCO_CHE_DP_", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IDBANCO_CHE_DP_", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@BANCO_CHE_DP_", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "BANCO_CHE_DP_", DataRowVersion.Current, null ) );


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


