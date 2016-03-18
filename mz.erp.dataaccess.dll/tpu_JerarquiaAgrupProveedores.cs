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

	public class tpu_JerarquiaAgrupProveedores : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetNomenclaturas() 
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_GetNomenclaturas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );

			adapter.Fill( data );
			return (data);									
		}

		public static commontypes.data.tpu_JerarquiaAgrupProveedoresDataset GetList (string IdPadre) 
		{
			tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_GetAgrupProveedores", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );

			adapter.Fill( data );
			return (data);									
			
		}

        //Cristian Tarea 00069 20110907
        public static commontypes.data.tpu_JerarquiaAgrupProveedoresDataset GetList(string IdPadre, bool Activo)
        {
            tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();

            SqlCommand cmd = new SqlCommand("Pr_tpu_JerarquiaAgrupProveedores_GetAgrupProveedoresJerarquiasActivas", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdPadre", SqlDbType.VarChar));
            cmd.Parameters["@IdPadre"].Value = IdPadre;
            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
            cmd.Parameters["@Activo"].Value = Activo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tpu_JerarquiaAgrupProveedores");

            adapter.Fill(data);
            return (data);

        }

        //Fin Cristian Tarea 00069

		public static string  GetPkByJerarquia(string Jerarquia)
		{
			tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_GetPkByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );

			adapter.Fill( data );

			if ( data.tpu_JerarquiaAgrupProveedores.Rows.Count == 1 )
			{
				return (( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow )data.tpu_JerarquiaAgrupProveedores.Rows[ 0 ]).IdNomenclatura;
			}
			
			return string.Empty;	
			
		}
		

		#endregion
		
		public tpu_JerarquiaAgrupProveedores()
		{
		}

		public static tpu_JerarquiaAgrupProveedoresDataset GetList()
		{
			tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();

			return ( tpu_JerarquiaAgrupProveedoresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_JerarquiaAgrupProveedoresDataset GetList( string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, long IdEmpresa, long IdSucursal, string OldIdNomenclatura, bool Activo )
		{
			tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			if(IdNomenclatura.Equals(string.Empty))
				cmd.Parameters[ "@IdNomenclatura" ].Value = System.DBNull.Value;
			else
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
			if(IdPadre.Equals(string.Empty))
				cmd.Parameters[ "@IdPadre" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			if(Jerarquia.Equals(string.Empty))
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
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
			if(OldIdNomenclatura.Equals(string.Empty))
				cmd.Parameters[ "@OldIdNomenclatura" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@OldIdNomenclatura" ].Value = OldIdNomenclatura;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow NewRow()
		{
			return ( new tpu_JerarquiaAgrupProveedoresDataset() ).tpu_JerarquiaAgrupProveedores.Newtpu_JerarquiaAgrupProveedoresRow();
		}
	
		public static tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow GetByPk( string IdNomenclatura )
		{
			tpu_JerarquiaAgrupProveedoresDataset data = new tpu_JerarquiaAgrupProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_JerarquiaAgrupProveedores" );

			adapter.Fill( data );

			if ( data.tpu_JerarquiaAgrupProveedores.Rows.Count == 1 )
			{
				return ( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow )data.tpu_JerarquiaAgrupProveedores.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable )row.Table ).Addtpu_JerarquiaAgrupProveedoresRow( row );

            }

            //German Tarea 0000239 20111221
            Update(row.Table);
            //Fin German
            //Cristian Tarea 0000192 20110818
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
        //Fin Cristian Tarea 0000192 20110818

		public static void Update( tpu_JerarquiaAgrupProveedoresDataset dataSet )
		{
			Update( dataSet.tpu_JerarquiaAgrupProveedores );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable )dataTable, trx );
				trx.Commit();
			}
			catch (Exception e)
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
			Update( ( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_JerarquiaAgrupProveedores", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura", "IdNomenclatura" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Nivel", "Nivel" ),
																											 new System.Data.Common.DataColumnMapping( "IdPadre", "IdPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Original, null ) );
			

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_JerarquiaAgrupProveedores_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_JerarquiaAgrupProveedores_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );

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
                adapter.TableMappings.Add("Table", "tpu_JerarquiaAgrupProveedores");

                SqlCommand cmd = new SqlCommand("Pr_tpu_JerarquiaAgrupProveedores_updateDescendientes", dbhelper.Connection.GetConnection());
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
                adapter.TableMappings.Add("Table", "tpu_JerarquiaAgrupProveedores");
                //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Current, null));

                SqlCommand cmd = new SqlCommand("Pr_tpu_JerarquiaAgrupProveedores_updatePadres", dbhelper.Connection.GetConnection());
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

