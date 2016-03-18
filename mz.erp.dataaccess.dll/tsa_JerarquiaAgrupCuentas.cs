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

	public class tsa_JerarquiaAgrupCuentas : IDisposable
	{
	
		#region Custom Members

        //German 20120517 - Tarea 0000329
        public static DataSet GetNomenclaturasFiltrandoCampoAuxiliar6()
        {
            DataSet data = new DataSet();

            SqlCommand cmd = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_GetNomenclaturasFiltrandoCampoAuxiliar6", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoCuenta", SqlDbType.Char));
            cmd.Parameters["@IdTipoCuenta"].Value = System.DBNull.Value;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_JerarquiaAgrupCuentas");

            adapter.Fill(data);
            return (data);	
        }
        //Fin German 20120517 - Tarea 0000329

		public static DataSet GetNomenclaturas() 
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetNomenclaturas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoCuenta", SqlDbType.Char ) );
			cmd.Parameters[ "@IdTipoCuenta" ].Value = System.DBNull.Value;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );

			adapter.Fill( data );
			return (data);									
		}
        //Cristian Tarea 0000069 20110907
        public static commontypes.data.tsa_JerarquiaAgrupCuentasDataset GetList(string IdPadre, bool activo)
        {
            tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_GetAgrupCuentasJerarquiasActivas", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdPadre", SqlDbType.VarChar));
            cmd.Parameters["@IdPadre"].Value = IdPadre;

            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
            cmd.Parameters["@Activo"].Value = activo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_JerarquiaAgrupCuentas");

            adapter.Fill(data);
            return (data);

        }
        //Fin Cristian Tarea 0000069
        
		public static commontypes.data.tsa_JerarquiaAgrupCuentasDataset GetList (string IdPadre) 
		{
			
            tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetAgrupCuentas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );

			adapter.Fill( data );
			return (data);									
			
		}
        
		public static DataSet GetList (char IdTipoCuenta) 
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetNomenclaturas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoCuenta", SqlDbType.Char ) );
			if(IdTipoCuenta.Equals(char.MinValue))
				cmd.Parameters[ "@IdTipoCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoCuenta" ].Value = IdTipoCuenta;

			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );
			int cuenta = data.tsh_JerarquiaAgrupProd.Rows.Count;
			return (data);									
		}

		
		public static string  GetPkByJerarquia(string Jerarquia)
		{
			tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetPkByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );

			adapter.Fill( data );

			if ( data.tsa_JerarquiaAgrupCuentas.Rows.Count == 1 )
			{
				return (( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow )data.tsa_JerarquiaAgrupCuentas.Rows[ 0 ]).IdNomenclatura;
			}
			
			return string.Empty;	
			
		}

        /* Silvina 20111104 - Tarea 0000222 */
        public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow GetPkByDescripcion(string Descripcion)
        {
            tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_GetPkByDescripcion", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            cmd.Parameters["@Descripcion"].Value = Descripcion;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_JerarquiaAgrupCuentas");

            adapter.Fill(data);

            if (data.tsa_JerarquiaAgrupCuentas.Rows.Count == 1)
            {
                return ((tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow)data.tsa_JerarquiaAgrupCuentas.Rows[0]);
            }
            return null;

        }
        /* Fin Silvina 20111104 - Tarea 0000222 */
		
		#endregion
		
		public tsa_JerarquiaAgrupCuentas()
		{
		}

		public static tsa_JerarquiaAgrupCuentasDataset GetList()
		{
			tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

			return ( tsa_JerarquiaAgrupCuentasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_JerarquiaAgrupCuentasDataset GetList( string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, string IdTipoCuenta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, string OldIdNomenclatura )
		{
			tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt ) );
			if ( Nivel == long.MinValue )
			{
				cmd.Parameters[ "@Nivel" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Nivel" ].Value = Nivel;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoCuenta" ].Value = IdTipoCuenta;
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			if ( IdConexionCreacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			if ( IdConexionUltimaModificacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt ) );
			if ( IdReservado == long.MinValue )
			{
				cmd.Parameters[ "@IdReservado" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdReservado" ].Value = IdReservado;
			}
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{
				cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			}
			cmd.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@OldIdNomenclatura" ].Value = OldIdNomenclatura;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow NewRow()
		{
			return ( new tsa_JerarquiaAgrupCuentasDataset() ).tsa_JerarquiaAgrupCuentas.Newtsa_JerarquiaAgrupCuentasRow();
		}
	
		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow GetByPk( string IdNomenclatura )
		{
			tsa_JerarquiaAgrupCuentasDataset data = new tsa_JerarquiaAgrupCuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_JerarquiaAgrupCuentas" );

			adapter.Fill( data );

			if ( data.tsa_JerarquiaAgrupCuentas.Rows.Count == 1 )
			{
				return ( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow )data.tsa_JerarquiaAgrupCuentas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable )row.Table ).Addtsa_JerarquiaAgrupCuentasRow( row );
                //Cristian Tarea 000069 20110818

            }

            //German Tarea 0000239 20111221
            Update(row.Table);
            //Fin German
            //Cristian Tarea 000069 20110818
            bool campoActivo = (Boolean)row["activo"];

            if (campoActivo)
            {
                string jerarquia = (String)row["Jerarquia"];
                Update_Padres(row.Table, jerarquia);
            }

            else
            {
                string nomenclatura = (String)row["idNomenclatura"];
                Update_Descendientes(row.Table, nomenclatura);
            }
        }
        //Fin Cristian Tarea 000069 20110818

		public static void Update( tsa_JerarquiaAgrupCuentasDataset dataSet )
		{
			Update( dataSet.tsa_JerarquiaAgrupCuentas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.ReadCommitted );

			try
			{
				Update( ( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable )dataTable, trx );
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
			Update( ( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_JerarquiaAgrupCuentas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura", "IdNomenclatura" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Nivel", "Nivel" ),
																											 new System.Data.Common.DataColumnMapping( "IdPadre", "IdPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoCuenta", "IdTipoCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "OldIdNomenclatura", "OldIdNomenclatura" ),
																											new System.Data.Common.DataColumnMapping( "Activo", "Activo" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 300, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_JerarquiaAgrupCuentas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 300, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}

        //Cristian Tarea 0000192 20110818
        public static void Update_Descendientes(DataTable dataTable, string idNomenclatura)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsa_JerarquiaAgrupCuentas");

                SqlCommand cmd = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_updateDescendientes", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdNomenclatura", SqlDbType.VarChar));
                cmd.Parameters["@IdNomenclatura"].Value = idNomenclatura;

                adapter.UpdateCommand = cmd;
                adapter.Update(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Update_Padres(DataTable dataTable, string jerarquia)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsa_JerarquiaAgrupCuentas");
                //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Current, null));

                SqlCommand cmd = new SqlCommand("Pr_tsa_JerarquiaAgrupCuentas_updatePadres", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@jerarquia", SqlDbType.VarChar));
                cmd.Parameters["@jerarquia"].Value = jerarquia;

                adapter.UpdateCommand = cmd;
                adapter.Update(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Fin Cristian Tarea 0000192		
		

		public void Dispose()
		{
		}

		
	}
}


