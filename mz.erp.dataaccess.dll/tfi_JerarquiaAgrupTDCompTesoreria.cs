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

	public class tfi_JerarquiaAgrupTDCompTesoreria : IDisposable
	{
	
		#region Custom Members

		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow GetByJerarquia(string IdPadre, string Jerarquia)
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data = new tfi_JerarquiaAgrupTDCompTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_JerarquiaAgrupTDCompTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPadre" ].Value = IdPadre;
			adapter.SelectCommand = cmd;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			if ( data.tfi_JerarquiaAgrupTDCompTesoreria.Rows.Count == 1 )
			{
				return ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow )data.tfi_JerarquiaAgrupTDCompTesoreria.Rows[ 0 ];
			}
			
			return null;
		}

		#endregion
		
		public tfi_JerarquiaAgrupTDCompTesoreria()
		{
		}

		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset GetList()
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data = new tfi_JerarquiaAgrupTDCompTesoreriaDataset();

			return ( tfi_JerarquiaAgrupTDCompTesoreriaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_JerarquiaAgrupTDCompTesoreria" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset GetList(string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, string OldIdNomenclatura, bool Agrupado,string ClaveCorta,string ClaveLarga )
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data = new tfi_JerarquiaAgrupTDCompTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_JerarquiaAgrupTDCompTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			if ( FechaCreacion == DateTime.MinValue )
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			}
			//cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
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
			cmd.Parameters.Add( new SqlParameter( "@Agrupado", SqlDbType.Bit ) );
			cmd.Parameters[ "@Agrupado" ].Value = Agrupado;
			cmd.Parameters.Add( new SqlParameter( "@ClaveCorta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ClaveCorta" ].Value = ClaveCorta;
			cmd.Parameters.Add( new SqlParameter( "@ClaveLarga", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ClaveLarga" ].Value = ClaveLarga;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
//Trae todos sin importar si esta o no agrupado
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset GetList(string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, string OldIdNomenclatura,string ClaveCorta,string ClaveLarga )
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data = new tfi_JerarquiaAgrupTDCompTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_JerarquiaAgrupTDCompTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			if ( FechaCreacion == DateTime.MinValue )
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			}
			//cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
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
			/*cmd.Parameters.Add( new SqlParameter( "@Agrupado", SqlDbType.Bit ) );
			cmd.Parameters[ "@Agrupado" ].Value =  System.DBNull.Value;*/
			cmd.Parameters.Add( new SqlParameter( "@ClaveCorta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ClaveCorta" ].Value = ClaveCorta;
			cmd.Parameters.Add( new SqlParameter( "@ClaveLarga", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ClaveLarga" ].Value = ClaveLarga;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow NewRow()
		{
			return ( new tfi_JerarquiaAgrupTDCompTesoreriaDataset() ).tfi_JerarquiaAgrupTDCompTesoreria.Newtfi_JerarquiaAgrupTDCompTesoreriaRow();
		}
	
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow GetByPk( string IdNomenclatura )
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data = new tfi_JerarquiaAgrupTDCompTesoreriaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_JerarquiaAgrupTDCompTesoreria" );

			adapter.Fill( data );

			if ( data.tfi_JerarquiaAgrupTDCompTesoreria.Rows.Count == 1 )
			{
				return ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow )data.tfi_JerarquiaAgrupTDCompTesoreria.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable )row.Table ).Addtfi_JerarquiaAgrupTDCompTesoreriaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset dataSet )
		{
			Update( dataSet.tfi_JerarquiaAgrupTDCompTesoreria );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable )dataTable, trx );
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
			Update( ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_JerarquiaAgrupTDCompTesoreria", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura", "IdNomenclatura" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Nivel", "Nivel" ),
																											 new System.Data.Common.DataColumnMapping( "IdPadre", "IdPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Jerarquia", "Jerarquia" ),
																											 new System.Data.Common.DataColumnMapping( "Agrupado", "Agrupado" ),
																											 new System.Data.Common.DataColumnMapping( "ClaveCorta", "ClaveCorta" ),
																											 new System.Data.Common.DataColumnMapping( "ClaveLarga", "ClaveLarga" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "OldIdNomenclatura", "OldIdNomenclatura" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Agrupado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Agrupado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ClaveCorta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ClaveCorta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ClaveLarga", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ClaveLarga", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OldIdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclatura", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_JerarquiaAgrupTDCompTesoreria_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_JerarquiaAgrupTDCompTesoreria_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nivel", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nivel", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Jerarquia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Agrupado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Agrupado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ClaveCorta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ClaveCorta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ClaveLarga", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ClaveLarga", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OldIdNomenclatura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OldIdNomenclatura", DataRowVersion.Current, null ) );

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

