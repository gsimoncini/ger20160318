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

	public class tpu_Proveedores : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;

        /* Silvina 20110228 - Tarea 0000017 */
        public static tpu_ProveedoresDataset GetByIdCondicionDeCompra(string IdCondicionDeCompra)
        {
            tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

            SqlCommand cmd = new SqlCommand("Pr_tpu_Proveedores_GetByIdCondicionDeCompra", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdCondicionDeCompra", SqlDbType.VarChar));
            cmd.Parameters["@IdCondicionDeCompra"].Value = IdCondicionDeCompra;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tpu_Proveedores");

            adapter.Fill(data);
            return data;
        }
        /* Fin Silvina */

        /* Silvina 20110405 - Tarea 0000047 */

        public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByDocumento(string IdTipoDocumento, string Documento)
        {
            tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tpu_Proveedores");

            SqlCommand cmd = new SqlCommand("Pr_tpu_Proveedores_GetByDocumento", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDocumento", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDocumento"].Value = IdTipoDocumento;

            cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar));
            cmd.Parameters["@Documento"].Value = Documento;

            adapter.SelectCommand = cmd;
            adapter.Fill(data);

            if (data.tpu_Proveedores.Rows.Count >= 1)
            {
                return (tpu_ProveedoresDataset.tpu_ProveedoresRow)data.tpu_Proveedores.Rows[0];
            }

            return null;
        }

        /* Fin Silvina 20110405 - Tarea 0000047 */

		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByCodigo( string Codigo )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetByCodigo", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			adapter.Fill( data );

			if ( data.tpu_Proveedores.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresDataset.tpu_ProveedoresRow )data.tpu_Proveedores.Rows[ 0 ];
			}
			
			return null;
		}
		

		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByNombre( string Nombre )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetByNombre", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Nombre" ].Value = Nombre;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			adapter.Fill( data );

			if ( data.tpu_Proveedores.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresDataset.tpu_ProveedoresRow )data.tpu_Proveedores.Rows[ 0 ];
			}
			
			return null;
		}

		public static tpu_ProveedoresDataset GetListByUK( string Codigo, long IdSucursal, long IdEmpresa)
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_SearchByCodigo", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") {	cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Codigo" ].Value = Codigo;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if(IdSucursal.Equals(long.MinValue))
				cmd.Parameters[ "@IdSucursal" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if(IdEmpresa.Equals(long.MinValue))
				cmd.Parameters[ "@IdEmpresa" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			
			adapter.SelectCommand = cmd;
			try
			{
				adapter.Fill( data );
			}
			catch (Exception e )
			{
				System.Console.WriteLine( e.Message);
			}
         
			return data;
		}
		

		#endregion
		
		public tpu_Proveedores()
		{
		}

		public static tpu_ProveedoresDataset GetList()
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			return ( tpu_ProveedoresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresDataset GetList( string IdProveedor, string Nombre, string IdTitular, string IdLocalidad )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Nombre" ].Value = Nombre;
			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTitular" ].Value = IdTitular;
			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresDataset.tpu_ProveedoresRow NewRow()
		{
			return ( new tpu_ProveedoresDataset() ).tpu_Proveedores.Newtpu_ProveedoresRow();
		}
	
		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByPk( string IdProveedor )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			adapter.Fill( data );

			if ( data.tpu_Proveedores.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresDataset.tpu_ProveedoresRow )data.tpu_Proveedores.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static tpu_ProveedoresDataset GetByPkToDataSet( string IdProveedor )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			adapter.Fill( data );

			if ( data.tpu_Proveedores.Rows.Count == 1 )
			{
				return data;
			}			
			return null;
		}
		public static tpu_ProveedoresDataset.tpu_ProveedoresDataTable GetByPkToDataTable( string IdProveedor )
		{
			tpu_ProveedoresDataset data = new tpu_ProveedoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			adapter.Fill( data );

			if ( data.tpu_Proveedores.Rows.Count == 1 )
			{
				return data.tpu_Proveedores;
			}			
			return null;
		}

	
		public static DataSet GetListGeneral(string Codigo, string Nombre, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, decimal CampoAuxiliar5, bool CampoAuxiliar5Activo

			,  
			
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8,
			string Calle,
			string IdTipoDocumento, 
			string Documento, 
			string IdTitular,
			bool Activo,
			string Email,
			string IdLocalidad,
			string Telefonos,
			string IdTipoMovimiento, 
			string IdSubTipoMovimiento,
			string IdCondicionDeCompra,
			long CondicionImpuestoGanancias,
			bool ExcluyeRetencionIVAActivo, 
			bool ExcluyeRetencionIVA, 
			bool ExcluyeRetencionIIBBActivo, 
			bool ExcluyeRetencionIIBB,
			string IdResponsableCreacion,
			DateTime FechaAltaDesde,
			DateTime FechaAltaHasta			
			
			/*,long IdSucursal,
			long IdEmpresa*/				
			)
		{		
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Proveedores" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Proveedores_SearchGeneral", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") {	cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Codigo" ].Value = Codigo;}

			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			if (Nombre == "") {	cmd.Parameters[ "@Nombre" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Nombre" ].Value = Nombre;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
			if (CampoAuxiliar1 == "") {	cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
			if (CampoAuxiliar2 == "") {	cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
			if (CampoAuxiliar3 == "") {	cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar ) );
			if (CampoAuxiliar4 == "") {	cmd.Parameters[ "@CampoAuxiliar4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar4" ].Value = CampoAuxiliar4;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.Decimal ) );
			if (!CampoAuxiliar5Activo) {	cmd.Parameters[ "@CampoAuxiliar5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar5" ].Value = CampoAuxiliar5;}

		
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}
			
			cmd.Parameters.Add( new SqlParameter( "@Calle", SqlDbType.VarChar ) );
			if (Calle == "") {	cmd.Parameters[ "@Calle" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Calle" ].Value = Calle;}

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDocumento", SqlDbType.VarChar ) );
			if (IdTipoDocumento == "") {	cmd.Parameters[ "@IdTipoDocumento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdTipoDocumento" ].Value = IdTipoDocumento;}

			cmd.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar ) );
			if (Documento == "") {	cmd.Parameters[ "@Documento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Documento" ].Value = Documento;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
			if (IdTitular == "") {	cmd.Parameters[ "@IdTitular" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdTitular" ].Value = IdTitular;}

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			cmd.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar ) );
			if (Email == "") {	cmd.Parameters[ "@Email" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Email" ].Value = Email;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			if (IdLocalidad == "") {	cmd.Parameters[ "@IdLocalidad" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;}

			cmd.Parameters.Add( new SqlParameter( "@Telefonos", SqlDbType.VarChar ) );
			if (Telefonos == "") {	cmd.Parameters[ "@Telefonos" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Telefonos" ].Value = Telefonos;}

			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar ) );
			if (IdTipoMovimiento == "") {	cmd.Parameters[ "@IdTipoMovimiento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdTipoMovimiento" ].Value = IdTipoMovimiento;}

			cmd.Parameters.Add( new SqlParameter( "@IdSubTipoMovimiento", SqlDbType.VarChar ) );
			if (IdSubTipoMovimiento == "") {	cmd.Parameters[ "@IdSubTipoMovimiento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdSubTipoMovimiento" ].Value = IdSubTipoMovimiento;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeCompra", SqlDbType.VarChar ) );
			if (IdCondicionDeCompra == "") {	cmd.Parameters[ "@IdCondicionDeCompra" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdCondicionDeCompra" ].Value = IdCondicionDeCompra;}

			cmd.Parameters.Add( new SqlParameter( "@CondicionImpuestoGanancias", SqlDbType.BigInt ) );
			if (CondicionImpuestoGanancias == long.MinValue) {	cmd.Parameters[ "@CondicionImpuestoGanancias" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CondicionImpuestoGanancias" ].Value = CondicionImpuestoGanancias;}

			cmd.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIVA", SqlDbType.Bit ) );
			if (!ExcluyeRetencionIVAActivo) {	cmd.Parameters[ "@ExcluyeRetencionIVA" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@ExcluyeRetencionIVA" ].Value = ExcluyeRetencionIVA;}

			cmd.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIIBB", SqlDbType.Bit ) );
			if (!ExcluyeRetencionIIBBActivo) {	cmd.Parameters[ "@ExcluyeRetencionIIBB" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@ExcluyeRetencionIIBB" ].Value = ExcluyeRetencionIIBB;}
			
			/*cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if(IdSucursal.Equals(long.MinValue))
				cmd.Parameters[ "@IdSucursal" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if(IdEmpresa.Equals(long.MinValue))
				cmd.Parameters[ "@IdEmpresa" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
*/

			cmd.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar ) );
			if(IdResponsableCreacion.Equals(string.Empty))
				cmd.Parameters[ "@IdResponsableCreacion" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdResponsableCreacion" ].Value = IdResponsableCreacion;

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaDesde", SqlDbType.DateTime ));
			if (FechaAltaDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaDesde"].Value = System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaDesde.Year, FechaAltaDesde.Month, FechaAltaDesde.Day, 0, 0, 0, 0);
				cmd.Parameters[ "@FechaAltaDesde"].Value = d;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaHasta", SqlDbType.DateTime ));
			if (FechaAltaHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaHasta"].Value = System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaHasta.Year, FechaAltaHasta.Month, FechaAltaHasta.Day, 23, 59, 59, 0);
				cmd.Parameters[ "@FechaAltaHasta"].Value = d;
			}
			
			adapter.SelectCommand = cmd;
			try
			{
				adapter.Fill( data );
			}
			catch (Exception e )
			{
				System.Console.WriteLine( e.Message);
			}
         
			return data;
		}
		public static void Update( tpu_ProveedoresDataset.tpu_ProveedoresRow row , SentenciasReplicacion replicacion)
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ProveedoresDataset.tpu_ProveedoresDataTable )row.Table ).Addtpu_ProveedoresRow( row );
			}
			
			Update( row.Table, replicacion );
		}

		public static void Update( tpu_ProveedoresDataset dataSet, SentenciasReplicacion replicacion )
		{
			//Update( dataSet.tpu_Proveedores , replicacion);
		}
		
		public static void Update( DataTable dataTable,SentenciasReplicacion replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			_replication = replicacion;

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
				_replication.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(_replication.Data.sy_SentenciasReplicacion, trx);
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

	/*	public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tpu_ProveedoresDataset.tpu_ProveedoresDataTable )dataTable, trx );
		}
			*/	


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
	

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_Proveedores", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "Nombre", "Nombre" ),
																											 new System.Data.Common.DataColumnMapping( "IdTitular", "IdTitular" ),
																											 new System.Data.Common.DataColumnMapping( "IdCategoriaIva", "IdCategoriaIva" ),
																											 new System.Data.Common.DataColumnMapping( "idTipoDocumento", "idTipoDocumento" ),
																											 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "Domicilio", "Domicilio" ),
																											 new System.Data.Common.DataColumnMapping( "HorarioComercial", "HorarioComercial" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "Telefonos", "Telefonos" ),
																											 new System.Data.Common.DataColumnMapping( "Email", "Email" ),
																											 new System.Data.Common.DataColumnMapping( "InstantMessenger", "InstantMessenger" ),
																											 new System.Data.Common.DataColumnMapping( "Web", "Web" ),
																											 new System.Data.Common.DataColumnMapping( "BonificacionGeneral", "BonificacionGeneral" ),
																											 new System.Data.Common.DataColumnMapping( "IdLocalidad", "IdLocalidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdGenerado", "IdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoMovimiento", "IdTipoMovimiento" ),
																											 new System.Data.Common.DataColumnMapping( "IdSubTipoMovimiento", "IdSubTipoMovimiento" ),
																											 new System.Data.Common.DataColumnMapping( "ExcluyeRetenciones", "ExcluyeRetenciones" ),
																											 new System.Data.Common.DataColumnMapping( "ExcluyeRetencionIVA", "ExcluyeRetencionIVA" ),
																											 new System.Data.Common.DataColumnMapping( "ExcluyeRetencionIIBB", "ExcluyeRetencionIIBB" ),
																											 new System.Data.Common.DataColumnMapping( "CondicionImpuestoGanancias", "CondicionImpuestoGanancias" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "IdCondicionDeCompra", "IdCondicionDeCompra" ),
																											 new System.Data.Common.DataColumnMapping( "DiasDemoraEntrega", "DiasDemoraEntrega" ),
																											 new System.Data.Common.DataColumnMapping( "IdEstado", "IdEstado" ),
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar1", "CampoAuxiliar1" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar2", "CampoAuxiliar2" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar3", "CampoAuxiliar3" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar4", "CampoAuxiliar4" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar5", "CampoAuxiliar5" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "OldIdProveedor", "OldIdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "AlicuotaRetencionIIBBServicios", "AlicuotaRetencionIIBBServicios" ),
																											 new System.Data.Common.DataColumnMapping( "AlicuotaRetencionIIBBCompras", "AlicuotaRetencionIIBBCompras" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsableCreacion", "IdResponsableCreacion" )
																										
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_Proveedores_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTitular", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCategoriaIva", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCategoriaIva", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "idTipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@HorarioComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "HorarioComercial", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Telefonos", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Telefonos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Email", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@InstantMessenger", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "InstantMessenger", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Web", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Web", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@BonificacionGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "BonificacionGeneral", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdLocalidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSubTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSubTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ExcluyeRetenciones", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetenciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIVA", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetencionIVA", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIIBB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetencionIIBB", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CondicionImpuestoGanancias", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CondicionImpuestoGanancias", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicionDeCompra", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCondicionDeCompra", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DiasDemoraEntrega", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DiasDemoraEntrega", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEstado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEstado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 15, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@AlicuotaRetencionIIBBCompras", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaRetencionIIBBCompras", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@AlicuotaRetencionIIBBServicios", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaRetencionIIBBServicios", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdResponsableCreacion", DataRowVersion.Current, null ) );

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_Proveedores_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_Proveedores_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 50, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTitular", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCategoriaIva", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCategoriaIva", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "idTipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@HorarioComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "HorarioComercial", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Telefonos", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Telefonos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Email", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@InstantMessenger", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "InstantMessenger", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Web", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Web", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@BonificacionGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "BonificacionGeneral", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdLocalidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSubTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSubTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ExcluyeRetenciones", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetenciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicionDeCompra", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCondicionDeCompra", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DiasDemoraEntrega", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DiasDemoraEntrega", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEstado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 15, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null ) );	
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIVA", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetencionIVA", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ExcluyeRetencionIIBB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ExcluyeRetencionIIBB", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CondicionImpuestoGanancias", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CondicionImpuestoGanancias", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@AlicuotaRetencionIIBBCompras", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaRetencionIIBBCompras", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@AlicuotaRetencionIIBBServicios", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaRetencionIIBBServicios", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdResponsableCreacion", DataRowVersion.Current, null ) );

			/*sqlCommandInsert.Parameters.Add("@IdGenerado", SqlDbType.VarChar, 300).Value = System.DBNull.Value;
			sqlCommandInsert.Parameters["@IdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;
			
			sqlCommandInsert.Parameters.Add("@RowIdGenerado", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value;
			sqlCommandInsert.Parameters["@RowIdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;*/
			

			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
			adapter.RowUpdating+=new SqlRowUpdatingEventHandler(adapter_RowUpdating);

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		private static void adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
		{
			foreach(SqlParameter param in e.Command.Parameters)
			{
				if (param.ParameterName == "@IdCondicionDeCompra") 
				{
					if ( e.Row["IdCondicionDeCompra"].Equals(String.Empty))
					{
						e.Command.Parameters[ "@IdCondicionDeCompra" ].Value = System.DBNull.Value;
					}
				}
				if (param.ParameterName == "@IdEstado") 
				{
					if ( e.Row["IdEstado"].Equals(long.MinValue))
					{
						e.Command.Parameters[ "@IdEstado" ].Value = System.DBNull.Value;
					}
				}
			}
		}
	}
}

