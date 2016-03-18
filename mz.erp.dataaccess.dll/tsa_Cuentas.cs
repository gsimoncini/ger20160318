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


	public class tsa_Cuentas : IDisposable
	{
	
		#region Custom Members

        /* Silvina 20110405 - Tarea 0000047 */

        public static tsa_CuentasDataset.tsa_CuentasRow GetByDocumento(string IdTipoDocumento, string Documento)
        {
            tsa_CuentasDataset data = new tsa_CuentasDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsa_Cuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsa_Cuentas_GetByDocumento", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDocumento", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDocumento"].Value = IdTipoDocumento;

            cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar));
            cmd.Parameters["@Documento"].Value = Documento; 

            adapter.SelectCommand = cmd;
            adapter.Fill(data);

            if (data.tsa_Cuentas.Rows.Count >= 1)
            {
                return (tsa_CuentasDataset.tsa_CuentasRow)data.tsa_Cuentas.Rows[0];
            }

            return null;
        }

        /* Fin Silvina 20110405 - Tarea 0000047 */

        /* Silvina 20110712 - Tarea 0000121 */

        public static DataTable GetAlertas(decimal ValorLimite, bool ValidaPorMonto, bool ValidaPorFecha, int CantDias)
        {
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsa_Cuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsa_Cuentas_GetAlertas", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ValorLimite", SqlDbType.Decimal));
            cmd.Parameters["@ValorLimite"].Value = ValorLimite;

            cmd.Parameters.Add(new SqlParameter("@ValidaPorMonto", SqlDbType.Bit));
            cmd.Parameters["@ValidaPorMonto"].Value = ValidaPorMonto;

            cmd.Parameters.Add(new SqlParameter("@ValidaPorFecha", SqlDbType.Bit));
            cmd.Parameters["@ValidaPorFecha"].Value = ValidaPorFecha;

            cmd.Parameters.Add(new SqlParameter("@CantDias", SqlDbType.Int));
            cmd.Parameters["@CantDias"].Value = CantDias;

            adapter.SelectCommand = cmd;
            adapter.Fill(data);

            return data;
        }

        /* Fin Silvina 20110712 - Tarea 0000121 */

		public static DataSet GetListJerarquias(string IdCuenta, string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchJerarquias", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if (IdCuenta == "") {	cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;}

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


		public static DataSet GetListContactos(string IdCuenta)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchContactos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if (IdCuenta == "") {	cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;}

			

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

		public static DataSet GetListGeneral(
			string Codigo, 
			string Nombre,  
			string IdTipoDocumento, 
			string Documento, 
			string IdTitular,
			string CampoAuxiliar1,
			string CampoAuxiliar2,
			string CampoAuxiliar3,
			string Calle,
			string IdLocalidad,
			string Telefonos,
			string Email,
			bool Activo,
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8,
			long IdSucursal,
			long IdEmpresa,
			string IdContacto,
			string IdResponsableCreacion,
			DateTime FechaAltaDesde,
			DateTime FechaAltaHasta
            /* Silvina 20110906 - Tarea 0000203 */
            , int Cantidad
            /* Fin Silvina 20110906 - Tarea 0000203 */
            /* Silvina 20111226 - Tarea 0000241 */
            , string CampoAuxiliar6
            , string Separador
            /* Fin Silvina 20111226 - Tarea 0000241 */
			)
		{		
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchGeneral", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") {	cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Codigo" ].Value = Codigo;}

			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			if (Nombre == "") {	cmd.Parameters[ "@Nombre" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Nombre" ].Value = Nombre;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDocumento", SqlDbType.VarChar ) );
			if (IdTipoDocumento == "") {	cmd.Parameters[ "@IdTipoDocumento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdTipoDocumento" ].Value = IdTipoDocumento;}

			cmd.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar ) );
			if (Documento == "") {	cmd.Parameters[ "@Documento" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Documento" ].Value = Documento;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
			if (IdTitular == "") {	cmd.Parameters[ "@IdTitular" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdTitular" ].Value = IdTitular;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
			if (CampoAuxiliar1 == "") {	cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
			if (CampoAuxiliar2 == "") {	cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;}

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
			if (CampoAuxiliar3 == "") {	cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;}

			cmd.Parameters.Add( new SqlParameter( "@Calle", SqlDbType.VarChar ) );
			if (Calle == "") {	cmd.Parameters[ "@Calle" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Calle" ].Value = Calle;}

			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			if (IdLocalidad == "") {	cmd.Parameters[ "@IdLocalidad" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;}

			cmd.Parameters.Add( new SqlParameter( "@Telefonos", SqlDbType.VarChar ) );
			if (Telefonos == "") {	cmd.Parameters[ "@Telefonos" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Telefonos" ].Value = Telefonos;}

			cmd.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar ) );
			if (Email == "") {	cmd.Parameters[ "@Email" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Email" ].Value = Email;}

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

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

			cmd.Parameters.Add( new SqlParameter( "@IdContacto", SqlDbType.VarChar ) );
			if(IdContacto.Equals(""))
				cmd.Parameters[ "@IdContacto" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdContacto" ].Value = IdContacto;

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

            /* Silvina 20110906 - Tarea 0000203 */ 
            cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));
            cmd.Parameters["@Cantidad"].Value = Cantidad;
            /* Fin Silvina 20110906 - Tarea 0000203 */

            /* Silvina 20111226 - Tarea 0000241 */
            cmd.Parameters.Add(new SqlParameter("@CampoAuxiliar6", SqlDbType.VarChar));
            if (string.IsNullOrEmpty(CampoAuxiliar6)){ cmd.Parameters["@CampoAuxiliar6"].Value = System.DBNull.Value; }
            else { cmd.Parameters["@CampoAuxiliar6"].Value = CampoAuxiliar6; }

            cmd.Parameters.Add(new SqlParameter("@Separador", SqlDbType.Char));
            cmd.Parameters["@Separador"].Value = Separador; 

            /* Fin Silvina 20111226 - Tarea 0000241 */
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

		public static DataSet GetListGeneral(
			string Codigo, 
			string Nombre,  
			string IdTipoDocumento, 
			string Documento, 
			string IdTitular,
			string CampoAuxiliar1,
			string CampoAuxiliar2,
			string CampoAuxiliar3,
			string Calle,
			string IdLocalidad,
			string Telefonos,
			string Email,
			bool Activo,
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8,
			long IdSucursal,
			long IdEmpresa
            /* Silvina 20110906 - Tarea 0000203 */
            , int Cantidad
            /* Fin Silvina 20110906 - Tarea 0000203 */
            /* Silvina 20111226 - Tarea 0000241 */
            , string CampoAuxiliar6
            , string Separador
            /* Fin Silvina 20111226 - Tarea 0000241 */
			)
		{		
         
			return GetListGeneral(
				Codigo, 
				Nombre,  
				IdTipoDocumento, 
				Documento, 
				IdTitular,
				CampoAuxiliar1,
				CampoAuxiliar2,
				CampoAuxiliar3,
				Calle,
				IdLocalidad,
				Telefonos,
				Email,
				Activo,
				Jerarquia1,
				Jerarquia2,
				Jerarquia3,
				Jerarquia4,
				Jerarquia5,
				Jerarquia6,
				Jerarquia7,
				Jerarquia8,
				IdSucursal,
				IdEmpresa,
				"",
				string.Empty,
				DateTime.MinValue,
				DateTime.MinValue
                /* Silvina 20110906 - Tarea 0000203 */
                , Cantidad
                /* Fin Silvina 20110906 - Tarea 0000203 */
                /* Silvina 20111226 - Tarea 0000241 */
                , CampoAuxiliar6
                , Separador
                /* Fin Silvina 20111226 - Tarea 0000241 */
				);
		}

		public static tsa_CuentasDataset GetListByUK( string Codigo, long IdTipoDomicilio ,long IdSucursal, long IdEmpresa)
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchByCodigo", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") {	cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Codigo" ].Value = Codigo;}
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDomicilio", SqlDbType.BigInt ) );
			if(IdTipoDomicilio.Equals(long.MinValue))
				cmd.Parameters[ "@IdTipoDomicilio" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDomicilio" ].Value = IdTipoDomicilio;
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
		
		private static SentenciasReplicacion _replication;

		

		public static tsa_CuentasDataset GetListEx( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, long IdTipoDomicilio, long IdSucursal, long IdEmpresa, bool Activo, decimal LimiteDeCredito)
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();
			
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
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDomicilio", SqlDbType.BigInt ) );
			if(IdTipoDomicilio.Equals(long.MinValue))
				cmd.Parameters[ "@IdTipoDomicilio" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDomicilio" ].Value = IdTipoDomicilio;

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

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Activo" ].Value = Activo;

			cmd.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.BigInt ) );
			if(LimiteDeCredito.Equals(decimal.MinValue))
				cmd.Parameters[ "@LimiteDeCredito" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@LimiteDeCredito" ].Value = LimiteDeCredito;

			

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

		//Sabrina 20100615 - Tarea 766
		public static tsa_CuentasDataset SearchCuentasByJerarquia(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal,long IdEmpresa)
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_SearchCuentasByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );
			adapter.Fill( data);
			return data;

		}
		//Fin Sabrina 20100615 - Tarea 766

		#endregion
		


		public tsa_Cuentas()
		{
		}

		public static tsa_CuentasDataset GetList()
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();

			return ( tsa_CuentasDataset )GetList( data );
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

		public static tsa_CuentasDataset GetList( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, long IdTipoDomicilio ,long IdSucursal, long IdEmpresa, bool Activo, decimal LimiteDeCredito)
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") {	cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Codigo" ].Value = Codigo;}
			
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			if (Nombre == "") {	cmd.Parameters[ "@Nombre" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Nombre" ].Value = Nombre;}

   			cmd.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Domicilio" ].Value = Domicilio;
   			cmd.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@idTipoDocumento" ].Value = idTipoDocumento;
   			cmd.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Documento" ].Value = Documento;
   			cmd.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@IdTitular" ].Value = IdTitular;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDomicilio", SqlDbType.BigInt ) );
            if(IdTipoDomicilio.Equals(long.MinValue))
				cmd.Parameters[ "@IdTipoDomicilio" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDomicilio" ].Value = IdTipoDomicilio;
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

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			cmd.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.BigInt ) );
			if(LimiteDeCredito.Equals(decimal.MinValue))
				cmd.Parameters[ "@LimiteDeCredito" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@LimiteDeCredito" ].Value = LimiteDeCredito;

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

		public static tsa_CuentasDataset.tsa_CuentasRow NewRow()
		{
			return ( new tsa_CuentasDataset() ).tsa_Cuentas.Newtsa_CuentasRow();
		}
	
		public static tsa_CuentasDataset.tsa_CuentasRow GetByPk( string IdCuenta )
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			adapter.Fill( data );

			if ( data.tsa_Cuentas.Rows.Count == 1 )
			{
				return ( tsa_CuentasDataset.tsa_CuentasRow )data.tsa_Cuentas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static tsa_CuentasDataset.tsa_CuentasRow GetByCodigo( string Codigo )
		{
			tsa_CuentasDataset data = new tsa_CuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_Cuentas_GetByCodigo", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_Cuentas" );

			adapter.Fill( data );

			if ( data.tsa_Cuentas.Rows.Count == 1 )
			{
				return ( tsa_CuentasDataset.tsa_CuentasRow )data.tsa_Cuentas.Rows[ 0 ];
			}
			
			return null;
		}
		

		public static void Update( tsa_CuentasDataset.tsa_CuentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CuentasDataset.tsa_CuentasDataTable )row.Table ).Addtsa_CuentasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CuentasDataset dataSet )
		{
			Update( dataSet.tsa_Cuentas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				//Update( ( tsa_CuentasDataset.tsa_CuentasDataTable )dataTable, trx );
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

		
	/*	public static void Update( tsa_CuentasDataset.tsa_CuentasDataTable dataTable, SqlTransaction trx )
		{
			Update( ( DataTable ) dataTable, trx );
		}*/

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
	
		public static void Update(DataTable dataTable, string IdTransaction, SentenciasReplicacion replicacion)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update( dataTable, trx, replicacion ) ;
		}
				
		public static void Update( DataTable dataTable, SqlTransaction trx , SentenciasReplicacion replication)		
		{
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			_replication = replication;
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_Cuentas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Nombre", "Nombre" ),
																											 new System.Data.Common.DataColumnMapping( "Domicilio", "Domicilio" ),
																											 new System.Data.Common.DataColumnMapping( "HorarioComercial", "HorarioComercial" ),
																											 new System.Data.Common.DataColumnMapping( "idTipoDocumento", "idTipoDocumento" ),
																											 new System.Data.Common.DataColumnMapping( "Documento", "Documento" ),
																											 new System.Data.Common.DataColumnMapping( "IdCategoriaIva", "IdCategoriaIva" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar1", "CampoAuxiliar1" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar2", "CampoAuxiliar2" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar3", "CampoAuxiliar3" ),
																											 new System.Data.Common.DataColumnMapping( "IdTitular", "IdTitular" ),
																											 new System.Data.Common.DataColumnMapping( "IdBonificacion", "IdBonificacion" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdGenerado", "IdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "LimiteDeCredito", "LimiteDeCredito" ),
																											 new System.Data.Common.DataColumnMapping( "ExcluyePercepcionIB", "ExcluyePercepcionIB" ),
																											 new System.Data.Common.DataColumnMapping( "Email", "Email" ),
																											 new System.Data.Common.DataColumnMapping( "Telefono", "Telefono" ),
															                                                 new System.Data.Common.DataColumnMapping( "IdDomicilioDefault", "IdDomicilioDefault" ),
															                                                 new System.Data.Common.DataColumnMapping( "OldIdCuenta", "OldIdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdListaDePreciosDefault", "IdListaDePreciosDefault" ),
																											 new System.Data.Common.DataColumnMapping( "AlicuotaPercepcionIngresosBrutos", "AlicuotaPercepcionIngresosBrutos" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoCtaCte", "SaldoCtaCte" ),
																											 new System.Data.Common.DataColumnMapping( "SaldoCtaCteDV", "SaldoCtaCteDV" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsableCreacion", "IdResponsableCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "DiasLimiteDeCredito", "DiasLimiteDeCredito" ),
																											 /* Silvina 20111104 - Tarea 0000222 */
                                                                                                             new System.Data.Common.DataColumnMapping( "CampoAuxiliar6", "CampoAuxiliar6" )
																											 /* Fin Silvina 20111104 - Tarea 0000222 */
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_Cuentas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 15, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@HorarioComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "HorarioComercial", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "idTipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar, 13, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Documento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCategoriaIva", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCategoriaIva", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTitular", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LimiteDeCredito", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ExcluyePercepcionIB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ExcluyePercepcionIB", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Email", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Telefono", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Telefono", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDomicilioDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDomicilioDefault", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdListaDePreciosDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdListaDePreciosDefault", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@AlicuotaPercepcionIngresosBrutos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaPercepcionIngresosBrutos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoCtaCte", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCte", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SaldoCtaCteDV", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCteDV", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsableCreacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DiasLimiteDeCredito", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DiasLimiteDeCredito", DataRowVersion.Current, null ) );
            /* Silvina 20111104 - Tarea 0000222 */
            sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar6", DataRowVersion.Current, null));
            /* Fin Silvina 20111104 - Tarea 0000222 */
			
			/*SqlParameter parametroIOU = new SqlParameter();
			parametroIOU.ParameterName = "@IdSentenciaReplicacion";
			parametroIOU.SqlDbType = SqlDbType.BigInt;
			parametroIOU.Size = 0;
			parametroIOU.Direction = ParameterDirection.InputOutput;
			parametroIOU.Value = -1;
			sqlCommandUpdate.Parameters.Add (parametroIOU);
			sqlCommandUpdate.Parameters.Add("@NombreTabla", SqlDbType.VarChar, 300).Value = "dataaccess.tsa_Cuentas";
			sqlCommandUpdate.Parameters.Add("@GeneraReplicacion", SqlDbType.Bit).Value = 1; */
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_Cuentas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_Cuentas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 15, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@HorarioComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "HorarioComercial", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "idTipoDocumento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar, 13, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Documento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCategoriaIva", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCategoriaIva", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTitular", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LimiteDeCredito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ExcluyePercepcionIB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ExcluyePercepcionIB", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Email", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Telefono", SqlDbType.VarChar, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Telefono", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDomicilioDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDomicilioDefault", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdListaDePreciosDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdListaDePreciosDefault", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@AlicuotaPercepcionIngresosBrutos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaPercepcionIngresosBrutos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoCtaCte", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCte", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SaldoCtaCteDV", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SaldoCtaCteDV", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsableCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DiasLimiteDeCredito", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DiasLimiteDeCredito", DataRowVersion.Current, null ) );
            /* Silvina 20111104 - Tarea 0000222 */
            sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CampoAuxiliar6", DataRowVersion.Current, null));
            /* Fin Silvina 20111104 - Tarea 0000222 */

			/*sqlCommandInsert.Parameters.Add("@NombreTabla", SqlDbType.VarChar, 300).Value = "dataaccess.tsa_Cuentas";

			SqlParameter parametroIO = new SqlParameter();
			parametroIO.ParameterName = "@IdSentenciaReplicacion";
			parametroIO.SqlDbType = SqlDbType.BigInt;
			parametroIO.Size = 0;
			parametroIO.Direction = ParameterDirection.InputOutput;
			parametroIO.Value = -1;
			sqlCommandInsert.Parameters.Add (parametroIO);		*/

			//Parametros adicionales para las modificaciones de replicacion
			sqlCommandInsert.Parameters.Add("@IdGenerado", SqlDbType.VarChar, 300).Value = System.DBNull.Value;
			sqlCommandInsert.Parameters["@IdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;
			
			sqlCommandInsert.Parameters.Add("@RowIdGenerado", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value;
			sqlCommandInsert.Parameters["@RowIdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;
			//	sqlCommandInsert.Parameters.Add("@GeneraReplicacion", SqlDbType.Bit).Value = 1;

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;

			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
			
			adapter.Update ( dataTable );

		}
		
		
		public void Dispose()
		{
		}


		public SqlCommand SqlCommandInsert
		{
			
			get
			{
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_Cuentas_Insert");
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 15, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Domicilio", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@HorarioComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "HorarioComercial", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@idTipoDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "idTipoDocumento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Documento", SqlDbType.VarChar, 13, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Documento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCategoriaIva", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCategoriaIva", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTitular", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTitular", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );			
				sqlCommandInsert.Parameters.Add("@IdGenerado", SqlDbType.VarChar, 300).Value = System.DBNull.Value;
				sqlCommandInsert.Parameters["@IdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;
				sqlCommandInsert.Parameters.Add("@RowIdGenerado", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value;
				sqlCommandInsert.Parameters["@RowIdGenerado"].Direction = System.Data.ParameterDirection.InputOutput;	
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@LimiteDeCredito", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "LimiteDeCredito", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@AlicuotaPercepcionIngresosBrutos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "AlicuotaPercepcionIngresosBrutos", DataRowVersion.Current, null ) );
				


				return sqlCommandInsert;

			}

		}

		
	}
}

