namespace mz.erp.dataaccess 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
	using System.Text;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using System.Collections;

	public class tsa_CuentasEx : IDisposable
	{
	
		#region Custom Members
		
		public static tsa_CuentasExDataset GetListEx( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, long IdTipoDomicilio, decimal LimiteDeCredito )
		{
			tsa_CuentasExDataset data = new tsa_CuentasExDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Nombre" ].Value = Nombre;
			cmd.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Domicilio" ].Value = Domicilio;
			cmd.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@idTipoDocumento" ].Value = idTipoDocumento;
			cmd.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Documento" ].Value = Documento;
			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTitular" ].Value = IdTitular;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDomicilio", SqlDbType.VarChar ) );
			if(IdTipoDomicilio.Equals(long.MinValue))
				cmd.Parameters[ "@IdTipoDomicilio" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDomicilio" ].Value = IdTipoDomicilio;

			cmd.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.BigInt ) );
			if(LimiteDeCredito.Equals(decimal.MinValue))
				cmd.Parameters[ "@LimiteDeCredito" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@LimiteDeCredito" ].Value = LimiteDeCredito;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		#endregion


		
		public tsa_CuentasEx()
		{
		}

		public static tsa_CuentasExDataset GetList()
		{
			tsa_CuentasExDataset data = new tsa_CuentasExDataset();

			return ( tsa_CuentasExDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasExDataset GetList( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, long IdTipoDomicilio, decimal LimiteDeCredito)
		{
			tsa_CuentasExDataset data = new tsa_CuentasExDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Nombre" ].Value = Nombre;
			cmd.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Domicilio" ].Value = Domicilio;
			cmd.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@idTipoDocumento" ].Value = idTipoDocumento;
			cmd.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Documento" ].Value = Documento;
			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTitular" ].Value = IdTitular;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDomicilio", SqlDbType.VarChar ) );
			if(IdTipoDomicilio.Equals(long.MinValue))
				cmd.Parameters[ "@IdTipoDomicilio" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDomicilio" ].Value = IdTipoDomicilio;

			cmd.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.BigInt ) );
			if(LimiteDeCredito.Equals(decimal.MinValue))
				cmd.Parameters[ "@LimiteDeCredito" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@LimiteDeCredito" ].Value = LimiteDeCredito;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasExDataset.tsa_CuentasRow NewRow()
		{
			return ( new tsa_CuentasExDataset() ).tsa_Cuentas.Newtsa_CuentasRow();
		}
	
		public static tsa_CuentasExDataset GetByPk( DataSet data, string IdCuenta )
		{
			

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			adapter.Fill( data );

			
			return (tsa_CuentasExDataset)data;
		}
		
		public static void Update( tsa_CuentasExDataset.tsa_CuentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CuentasExDataset.tsa_CuentasDataTable )row.Table ).Addtsa_CuentasRow( row );
			}
			
			//Update( row.Table );
		}
		
		private static DataSet BuilAddModifiedDataset(DataSet data)
		{
			tsa_CuentasExDataset dataResult = new tsa_CuentasExDataset();
			DataTable table;
			table = data.Tables["tcs_domicilios"].GetChanges(System.Data.DataRowState.Added);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tcs_domicilios"].GetChanges(System.Data.DataRowState.Modified);
			if(table != null)
				dataResult.Merge(table);

            //German 20100518
            table = data.Tables["tcs_domicilios"].GetChanges(System.Data.DataRowState.Unchanged);
            if (table != null)
                dataResult.Merge(table);
            //Fin German 20100518

			dataResult.Merge(data.Tables["tsa_cuentas"]);
			table = data.Tables["tcs_domicilioscuentas"].GetChanges(System.Data.DataRowState.Added);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tcs_domicilioscuentas"].GetChanges(System.Data.DataRowState.Added);
			if(table != null)
				dataResult.Merge(table);
			dataResult.Merge(data.Tables["tsy_ImpuestosCuentas"]);
			dataResult.Merge(data.Tables["tsa_AgrupCuentas"]);
			dataResult.Merge(data.Tables["tsa_CuentasJerarquias"]);

			table = data.Tables["tsh_Personas"].GetChanges(System.Data.DataRowState.Added);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tsh_Personas"].GetChanges(System.Data.DataRowState.Modified);
			if(table != null)
				dataResult.Merge(table);

			table = data.Tables["tsh_Contactos"].GetChanges(System.Data.DataRowState.Added);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tsh_Contactos"].GetChanges(System.Data.DataRowState.Modified);
			if(table != null)
				dataResult.Merge(table);
			return dataResult;



		}

		private static DataSet BuilDeletedDataset(DataSet data)
		{
			tsa_CuentasExDataset dataResult = new tsa_CuentasExDataset();
			DataTable table;
			table = data.Tables["tcs_domicilios"].GetChanges(System.Data.DataRowState.Deleted);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tcs_domicilioscuentas"].GetChanges(System.Data.DataRowState.Deleted);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tsa_AgrupCuentas"].GetChanges(System.Data.DataRowState.Deleted);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tsa_CuentasJerarquias"].GetChanges(System.Data.DataRowState.Deleted);
			if(table != null)
				dataResult.Merge(table);
			table = data.Tables["tsh_Contactos"].GetChanges(System.Data.DataRowState.Deleted);
			if(table != null)
				dataResult.Merge(table);
			return dataResult;



		}


		

		public static void Update( DataSet data, SentenciasReplicacion Replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			ArrayList backup =  BackUpData(data);
			
			//DataSet dataDelete = BuildDeleteDataset(data);
			
			try
			{		
					
				tsa_CuentasExDataset dataEx = (tsa_CuentasExDataset) BuilAddModifiedDataset(data);
				tcs_Domicilios.Update( dataEx.Tables["tcs_Domicilios"], trx, Replicacion);
				tsa_Cuentas.Update( dataEx.Tables["tsa_cuentas"], trx, Replicacion);
				tcs_DomiciliosCuentas.Update( dataEx.Tables["tcs_DomiciliosCuentas"], trx, Replicacion);
				tsa_AgrupCuentas.Update(dataEx.Tables["tsa_AgrupCuentas"], trx, Replicacion);
				tsa_CuentasJerarquias.Update(dataEx.Tables["tsa_CuentasJerarquias"], trx, Replicacion);
				tsh_Personas.Update(dataEx.Tables["tsh_Personas"], trx, Replicacion);
				tsh_Contactos.Update(dataEx.Tables["tsh_Contactos"], trx, Replicacion);
				tsa_CuentasExDataset dataEx1 = (tsa_CuentasExDataset)BuilDeletedDataset(data);
				tcs_DomiciliosCuentas.Update( dataEx1.Tables["tcs_DomiciliosCuentas"], trx, Replicacion);
				tcs_Domicilios.Update( dataEx1.Tables["tcs_Domicilios"], trx, Replicacion);
				tsy_ImpuestosCuentas.Update(dataEx.Tables["tsy_ImpuestosCuentas"],trx);
				tsa_AgrupCuentas.Update(dataEx.Tables["tsa_AgrupCuentas"], trx, Replicacion);
				tsa_CuentasJerarquias.Update(dataEx.Tables["tsa_CuentasJerarquias"], trx, Replicacion);
				tsh_Contactos.Update(dataEx1.Tables["tsh_Contactos"], trx, Replicacion);
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);

				trx.Commit();
				dataEx.Merge(dataEx1);
				data.Clear();
				data.Merge(dataEx);
			}
			catch(Exception re)
			{
				trx.Rollback();
				RecoverBackUp(backup, data);
				
			}
			finally
			{
				cnx.Close();
			}
		}

		private static ArrayList BackUpData(DataSet data)
		{
			ArrayList aux = new ArrayList();
			foreach(DataTable table in data.Tables)
			{
				ArrayList aux1 = new ArrayList();
				foreach(DataRow row in table.Rows)
				{
					if(row.RowState.Equals(System.Data.DataRowState.Added) || row.RowState.Equals(System.Data.DataRowState.Modified) )
						aux1.Add(row["UltimaModificacion"]);
				}
				aux.Add(aux1);
			}


			return aux;


		}

		private static void RecoverBackUp(ArrayList back, DataSet data)
		{	
			int index = 0;
			ArrayList aux;
			foreach(DataTable table in data.Tables)
			{
				aux = (ArrayList)back[index];
				int indexAux = 0;
				foreach(DataRow row in table.Rows)
				{
					try
					{
						row["UltimaModificacion"] = aux[indexAux];
						indexAux++;
					}
					catch(Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
				index++;
			}
		}



		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tsa_CuentasExDataset.tsa_CuentasDataTable )dataTable, trx );
		}
				

		public void Dispose()
		{
		}

		
	}
}

