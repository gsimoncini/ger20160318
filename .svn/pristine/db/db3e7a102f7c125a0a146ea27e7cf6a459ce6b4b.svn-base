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

	public class tsh_JerarquiaAgrupProd : IDisposable
	{
	
		#region Custom Members
		
		//Nuevo para replicacion
		private static SentenciasReplicacion _replicacion;
		public static SentenciasReplicacion Replicacion
		{
			get{return _replicacion;}
			set{_replicacion = value;}
		}


		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetPkByDescripcion(string Descripcion)
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetPkByDescripcion", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return (tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow)data.Tables[0].Rows[0];
            return null;
		}

		public static string  GetIdNomenclaturaByDescripcion(string Descripcion)
		{
			tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row = GetPkByDescripcion(Descripcion);
			if ( row != null )
			{
				return row.IdNomenclatura;
			}
			
			return string.Empty;	
			
		}
		public static string GetJerarquiaByIdNomenclatura(string IdNomenclatura)
		{
			tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row = GetByPk(IdNomenclatura);
			if ( row != null )
			{
				return row.Jerarquia;
			}
			
			return string.Empty;	
			
		}

		public static tsh_JerarquiaAgrupProdDataset  GetListByJerarquia(string Jerarquia)
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetNomenclaturasByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );

			return data;
			
		}


        //German 06/01/2012 - Tarea 0000248 
        public static tsh_JerarquiaAgrupProdDataset GetListByJerarquia(string Jerarquia, bool activo)
        {
            tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_GetNomenclaturasByJerarquiaActivo", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Jerarquia", SqlDbType.VarChar));
            cmd.Parameters["@Jerarquia"].Value = Jerarquia;

            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
            cmd.Parameters["@Activo"].Value = activo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_JerarquiaAgrupProd");

            adapter.Fill(data);

            return data;

        }

        //German 06/01/2012 - Tarea 0000248 

		public static string  GetPkByJerarquia(string Jerarquia)
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetPkByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );

			if ( data.tsh_JerarquiaAgrupProd.Rows.Count == 1 )
			{
				return (( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow )data.tsh_JerarquiaAgrupProd.Rows[ 0 ]).IdNomenclatura;
			}
			
			return string.Empty;	
			
		}
		

		public static tsh_JerarquiaAgrupProdDataset GetNomenclaturas()
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_AgrupProductos" );
			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetNomenclaturas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
					
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;			
		}

		#endregion
		
		public tsh_JerarquiaAgrupProd()
		{
		}

        //German 20120412 - Tarea 0000271
        public static tsh_JerarquiaAgrupProdDataset GetListFiltrandoCampoAuxiliar6(Char IdTipoProducto, bool Activo)
        {
            tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_GetNomenclaturasFiltrandoCampoAuxiliar6", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoProducto", SqlDbType.Char));
            if (IdTipoProducto.Equals(char.MinValue))
                cmd.Parameters["@IdTipoProducto"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@IdTipoProducto"].Value = IdTipoProducto;

            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
            cmd.Parameters["@Activo"].Value = Activo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_JerarquiaAgrupProd");

            adapter.Fill(data);
            int cuenta = data.tsh_JerarquiaAgrupProd.Rows.Count;
            return (data);	
        }

        //Fin German 20120412 - Tarea 0000271


		public static tsh_JerarquiaAgrupProdDataset GetList (char IdTipoProducto, bool Activo) 
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetNomenclaturas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.Char ) );
			if(IdTipoProducto.Equals(char.MinValue))
				cmd.Parameters[ "@IdTipoProducto" ].Value = System.DBNull.Value;
			else
			cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Activo" ].Value = Activo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );
			int cuenta = data.tsh_JerarquiaAgrupProd.Rows.Count;
			return (data);									
		}

		public static tsh_JerarquiaAgrupProdDataset GetList (string IdPadre, bool Activo) 
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetAgrupProd", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Activo" ].Value = Activo;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );
			int cuenta = data.tsh_JerarquiaAgrupProd.Rows.Count;
			return (data);									
			//exec Pr_tsh_JerarquiaAgrupProd_GetAgrupProd "00001000010000000001"
		}

			
		public static tsh_JerarquiaAgrupProdDataset GetList()
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			return ( tsh_JerarquiaAgrupProdDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );
			
				SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetList", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
         
			return data;
		}


		/*public static tsh_JerarquiaAgrupProdDataset GetList(  )
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}*/

		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow NewRow()
		{
			return ( new tsh_JerarquiaAgrupProdDataset() ).tsh_JerarquiaAgrupProd.Newtsh_JerarquiaAgrupProdRow();
		}
	
		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetByPk( string IdNomenclatura )
		{
			tsh_JerarquiaAgrupProdDataset data = new tsh_JerarquiaAgrupProdDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_JerarquiaAgrupProd" );

			adapter.Fill( data );

			if ( data.tsh_JerarquiaAgrupProd.Rows.Count == 1 )
			{
				return ( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow )data.tsh_JerarquiaAgrupProd.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row )
		{
		    if (row.RowState == DataRowState.Detached)
		    {
		        ((tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable) row.Table).Addtsh_JerarquiaAgrupProdRow(row);

		    }
		    //Cristian Tarea 0000192 20110818

            //German Tarea 0000239 20111221
            Update(row.Table);
            //Fin German

            
		    bool campoActivo = (Boolean) row["activo"];
		    
		    if (campoActivo)
		    {
                string jerarquia = (String)row["Jerarquia"];
                Update_Padres(row.Table,jerarquia);
		    }

		    else
		    {
                string nomenclatura = (String)row["idNomenclatura"];
                Update_Descendientes(row.Table, nomenclatura);
		    }
		}

	    //Fin Cristian Tarea 0000192 20110818
		

		public static void Update( tsh_JerarquiaAgrupProdDataset dataSet )
		{
			Update( dataSet.tsh_JerarquiaAgrupProd );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			//SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
            //Cristian Tarea 000192 20110819
            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);
            //Fin Cristian
			try
			{				
				Update( ( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable )dataTable, trx );
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch(Exception e)
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
			Update( ( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable )dataTable, trx );
		}
			
		
		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			
		
			StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
			if(Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
				Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			
			
			
		}
		

		public static void Update( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_JerarquiaAgrupProd", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura", "IdNomenclatura" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Nivel", "Nivel" ),
																											 new System.Data.Common.DataColumnMapping( "IdPadre", "IdPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoProducto", "IdTipoProducto" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdGenerado", "IdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" )
                                                                                                             /* Silvina 20120420 - Tarea 0000294 */
                                                                                                             , new System.Data.Common.DataColumnMapping( "Comision", "Comision" )
                                                                                                             /* Fin Silvina 20120420 - Tarea 0000294 */
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );
            /* Silvina 20120420 - Tarea 0000294 */
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Comision", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Comision", DataRowVersion.Current, null));
            /* Fin Silvina 20120420 - Tarea 0000294 */

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_JerarquiaAgrupProd_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Original, null ) );
			//sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.InputOutput , false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );
            /* Silvina 20120420 - Tarea 0000294 */
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Comision", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Comision", DataRowVersion.Current, null));
            /* Fin Silvina 20120420 - Tarea 0000294 */


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
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_Insert");
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdGenerado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
                /* Silvina 20120420 - Tarea 0000294 */
                sqlCommandInsert.Parameters.Add(new SqlParameter("@Comision", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Comision", DataRowVersion.Current, null));
                /* Fin Silvina 20120420 - Tarea 0000294 */
				return sqlCommandInsert;

			}
		}

        //Cristian Tarea 0000192 20110818
        public static void Update_Descendientes(DataTable dataTable, string idNomenclatura)
	    {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsh_JerarquiaAgrupProd");

                SqlCommand cmd = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_updateDescendientes", dbhelper.Connection.GetConnection());
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
                adapter.TableMappings.Add("Table", "tsh_JerarquiaAgrupProd");
                //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Current, null));

                SqlCommand cmd = new SqlCommand("Pr_tsh_JerarquiaAgrupProd_updatePadres", dbhelper.Connection.GetConnection());
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

		
	}
}

