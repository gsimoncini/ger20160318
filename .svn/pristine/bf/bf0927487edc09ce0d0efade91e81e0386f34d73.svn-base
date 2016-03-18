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

	public class tfi_Valores : IDisposable
	{
	
		#region Custom Members



		public static DataTable SearchRetenciones( 
			string Jerarquia,
			string IdTDCompTesoreria, 
			string IdCajas,
			string Numero, 
			string IdEntidad,
			DateTime FechaEmisionDesde,
			DateTime FechaEmisionHasta,
			DateTime FechaVencimientoDesde,
			DateTime FechaVencimientoHasta,
			decimal MontoDesde,
			decimal MontoHasta,
			string IdMoneda,
			DateTime FechaIngresoRetencionDesde,
			DateTime FechaIngresoRetencionHasta,
			DateTime FechaRetencionDesde,
			DateTime FechaRetencionHasta,
			string TipoRetencion
			)
		{
			
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_SearchRetenciones", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			
			if(Jerarquia == null || Jerarquia.Equals(string.Empty))
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			if(IdTDCompTesoreria == null || IdTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@IdsCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdsCaja" ].Value = IdCajas;		
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			if(Numero == null || Numero.Equals(string.Empty))
				cmd.Parameters[ "@Numero" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Numero" ].Value = Numero;
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			if(IdEntidad == null || IdEntidad.Equals(string.Empty))
				cmd.Parameters[ "@IdEntidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionDesde", SqlDbType.DateTime ) );
			if(FechaEmisionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = FechaEmisionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionHasta", SqlDbType.DateTime ) );
			if(FechaEmisionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = FechaEmisionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoDesde", SqlDbType.DateTime ) );
			if(FechaVencimientoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = FechaVencimientoDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoHasta", SqlDbType.DateTime ) );
			if(FechaVencimientoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = FechaVencimientoHasta;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaIngresoRetencionDesde", SqlDbType.DateTime ) );
			if(FechaIngresoRetencionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaIngresoRetencionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaIngresoRetencionDesde" ].Value = FechaIngresoRetencionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaIngresoRetencionHasta", SqlDbType.DateTime ) );
			if(FechaIngresoRetencionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaIngresoRetencionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaIngresoRetencionHasta" ].Value = FechaIngresoRetencionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaRetencionDesde", SqlDbType.DateTime ) );
			if(FechaRetencionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRetencionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRetencionDesde" ].Value = FechaRetencionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaRetencionHasta", SqlDbType.DateTime ) );
			if(FechaRetencionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRetencionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRetencionHasta" ].Value = FechaRetencionHasta;

			
			cmd.Parameters.Add( new SqlParameter( "@MontoDesde", SqlDbType.Decimal ) );
			if(MontoDesde.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoDesde" ].Value = MontoDesde;

			cmd.Parameters.Add( new SqlParameter( "@MontoHasta", SqlDbType.Decimal ) );
			if(MontoHasta.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoHasta" ].Value = MontoHasta;


			cmd.Parameters.Add( new SqlParameter( "@TipoRetencion", SqlDbType.VarChar ) );
			if(TipoRetencion == null || TipoRetencion.Equals(string.Empty))
				cmd.Parameters[ "@TipoRetencion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@TipoRetencion" ].Value = TipoRetencion;

			cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar ) );
			if(IdMoneda == null || IdMoneda.Equals(string.Empty))
				cmd.Parameters[ "@IdMoneda" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdMoneda" ].Value = IdMoneda;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data.Tables[0];
		}
		

		public static DataTable SearchTarjetas( 
			string Jerarquia, 
			string IdTDCompTesoreria, 
			string IdCajas,
			string Numero, 
			string IdEntidad,
			DateTime FechaEmisionDesde,
			DateTime FechaEmisionHasta,
			DateTime FechaVencimientoDesde,
			DateTime FechaVencimientoHasta,
			decimal MontoDesde,
			decimal MontoHasta,
			string IdMoneda,
			DateTime FechaDeAcreditacionDesde,
			DateTime FechaDeAcreditacionHasta,
			DateTime FechaDeAutorizacionDesde,
			DateTime FechaDeAutorizacionHasta,
			string CodigoAutorizacion,
			string Cupon,
			string Lote,
			string CodigoDiez,
			short CantidadCuotas
			)
		{
			
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_SearchTarjetas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			
			if(Jerarquia == null || Jerarquia.Equals(string.Empty))
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
					cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			if(IdTDCompTesoreria == null || IdTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			
			cmd.Parameters.Add( new SqlParameter( "@IdsCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdsCaja" ].Value = IdCajas;		
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			if(Numero == null || Numero.Equals(string.Empty))
				cmd.Parameters[ "@Numero" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Numero" ].Value = Numero;
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			if(IdEntidad == null || IdEntidad.Equals(string.Empty))
				cmd.Parameters[ "@IdEntidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionDesde", SqlDbType.DateTime ) );
			if(FechaEmisionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = FechaEmisionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionHasta", SqlDbType.DateTime ) );
			if(FechaEmisionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = FechaEmisionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoDesde", SqlDbType.DateTime ) );
			if(FechaVencimientoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = FechaVencimientoDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoHasta", SqlDbType.DateTime ) );
			if(FechaVencimientoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = FechaVencimientoHasta;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaDeAcreditacionDesde", SqlDbType.DateTime ) );
			if(FechaDeAcreditacionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeAcreditacionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDeAcreditacionDesde" ].Value = FechaDeAcreditacionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaDeAcreditacionHasta", SqlDbType.DateTime ) );
			if(FechaDeAcreditacionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeAcreditacionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDeAcreditacionHasta" ].Value = FechaDeAcreditacionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaDeAutorizacionDesde", SqlDbType.DateTime ) );
			if(FechaDeAutorizacionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeAutorizacionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDeAutorizacionDesde" ].Value = FechaDeAutorizacionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaDeAutorizacionHasta", SqlDbType.DateTime ) );
			if(FechaDeAutorizacionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDeAutorizacionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaDeAutorizacionHasta" ].Value = FechaDeAutorizacionHasta;

			
			cmd.Parameters.Add( new SqlParameter( "@MontoDesde", SqlDbType.Decimal ) );
			if(MontoDesde.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoDesde" ].Value = MontoDesde;

			cmd.Parameters.Add( new SqlParameter( "@MontoHasta", SqlDbType.Decimal ) );
			if(MontoHasta.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoHasta" ].Value = MontoHasta;


			cmd.Parameters.Add( new SqlParameter( "@CodigoAutorizacion", SqlDbType.VarChar ) );
			if(CodigoAutorizacion == null || CodigoAutorizacion.Equals(string.Empty))
				cmd.Parameters[ "@CodigoAutorizacion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CodigoAutorizacion" ].Value = CodigoAutorizacion;

			cmd.Parameters.Add( new SqlParameter( "@Cupon", SqlDbType.VarChar ) );
			if(Cupon == null || Cupon.Equals(string.Empty))
				cmd.Parameters[ "@Cupon" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Cupon" ].Value = Cupon;


			cmd.Parameters.Add( new SqlParameter( "@Lote", SqlDbType.VarChar ) );
			if(Lote == null || Lote.Equals(string.Empty))
				cmd.Parameters[ "@Lote" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Lote" ].Value = Lote;

			cmd.Parameters.Add( new SqlParameter( "@CodigoDiez", SqlDbType.VarChar ) );
			if(CodigoDiez == null || CodigoDiez.Equals(string.Empty))
				cmd.Parameters[ "@CodigoDiez" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CodigoDiez" ].Value = CodigoDiez;

			cmd.Parameters.Add( new SqlParameter( "@CantidadCuotas", SqlDbType.Int ) );
			if(CantidadCuotas.Equals(short.MinValue))
				cmd.Parameters[ "@CantidadCuotas" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CantidadCuotas" ].Value = CantidadCuotas;

			cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar ) );
			if(IdMoneda == null || IdMoneda.Equals(string.Empty))
				cmd.Parameters[ "@IdMoneda" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdMoneda" ].Value = IdMoneda;
			

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data.Tables[0];
		}
		
		
		
		public static DataTable SearchCheques( 
			string Jerarquia, 
			string IdTDCompTesoreria, 
			string IdCajas,
			string Numero, 
			string IdEntidad,
			DateTime FechaEmisionDesde,
			DateTime FechaEmisionHasta,
			DateTime FechaVencimientoDesde,
			DateTime FechaVencimientoHasta,
			decimal MontoDesde,
			decimal MontoHasta,
			string IdMoneda,
			DateTime FechaRecepcionDesde,
			DateTime FechaRecepcionHasta,
			DateTime FechaPagoDesde,
			DateTime FechaPagoHasta,
			DateTime FechaIngresoBancoDesde,
			DateTime FechaIngresoBancoHasta,
			string NroBoleta,
			string CuentaBancaria,
			string Librador,
			string Sucursal,
			string IdEstadoCheque
			)
		{
			
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_SearchCheques", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			
			if(Jerarquia == null || Jerarquia.Equals(string.Empty))
				cmd.Parameters[ "@Jerarquia" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			if(IdTDCompTesoreria == null || IdTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@IdsCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdsCaja" ].Value = IdCajas;			
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			if(Numero == null || Numero.Equals(string.Empty))
				cmd.Parameters[ "@Numero" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Numero" ].Value = Numero;
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			if(IdEntidad == null || IdEntidad.Equals(string.Empty))
				cmd.Parameters[ "@IdEntidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionDesde", SqlDbType.DateTime ) );
			if(FechaEmisionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionDesde" ].Value = FechaEmisionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaEmisionHasta", SqlDbType.DateTime ) );
			if(FechaEmisionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaEmisionHasta" ].Value = FechaEmisionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoDesde", SqlDbType.DateTime ) );
			if(FechaVencimientoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoDesde" ].Value = FechaVencimientoDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoHasta", SqlDbType.DateTime ) );
			if(FechaVencimientoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaVencimientoHasta" ].Value = FechaVencimientoHasta;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaPagoDesde", SqlDbType.DateTime ) );
			if(FechaPagoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaPagoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaPagoDesde" ].Value = FechaPagoDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaPagoHasta", SqlDbType.DateTime ) );
			if(FechaPagoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaPagoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaPagoHasta" ].Value = FechaPagoHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcionDesde", SqlDbType.DateTime ) );
			if(FechaRecepcionDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRecepcionDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRecepcionDesde" ].Value = FechaRecepcionDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcionHasta", SqlDbType.DateTime ) );
			if(FechaRecepcionHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRecepcionHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRecepcionHasta" ].Value = FechaRecepcionHasta;

			cmd.Parameters.Add( new SqlParameter( "@FechaIngresoBancoDesde", SqlDbType.DateTime ) );
			if(FechaIngresoBancoDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaIngresoBancoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaIngresoBancoDesde" ].Value = FechaIngresoBancoDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaIngresoBancoHasta", SqlDbType.DateTime ) );
			if(FechaIngresoBancoHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaIngresoBancoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaIngresoBancoHasta" ].Value = FechaIngresoBancoHasta;

			cmd.Parameters.Add( new SqlParameter( "@MontoDesde", SqlDbType.Decimal ) );
			if(MontoDesde.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoDesde" ].Value = MontoDesde;

			cmd.Parameters.Add( new SqlParameter( "@MontoHasta", SqlDbType.Decimal ) );
			if(MontoHasta.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoHasta" ].Value = MontoHasta;

			cmd.Parameters.Add( new SqlParameter( "@NroBoleta", SqlDbType.VarChar ) );
			if(NroBoleta == null || NroBoleta.Equals(string.Empty))
				cmd.Parameters[ "@NroBoleta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@NroBoleta" ].Value = NroBoleta;

			cmd.Parameters.Add( new SqlParameter( "@CuentaBancaria", SqlDbType.VarChar ) );
			if(CuentaBancaria == null || CuentaBancaria.Equals(string.Empty))
				cmd.Parameters[ "@CuentaBancaria" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CuentaBancaria" ].Value = CuentaBancaria;


			cmd.Parameters.Add( new SqlParameter( "@Librador", SqlDbType.VarChar ) );
			if(Librador == null || Librador.Equals(string.Empty))
				cmd.Parameters[ "@Librador" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Librador" ].Value = Librador;

			cmd.Parameters.Add( new SqlParameter( "@Sucursal", SqlDbType.VarChar ) );
			if(Sucursal == null || Sucursal.Equals(string.Empty))
				cmd.Parameters[ "@Sucursal" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Sucursal" ].Value = Sucursal;

			cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar ) );
			if(IdMoneda == null || IdMoneda.Equals(string.Empty))
				cmd.Parameters[ "@IdMoneda" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdMoneda" ].Value = IdMoneda;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadoCheque", SqlDbType.VarChar ) );
			if(IdEstadoCheque == null || IdEstadoCheque.Equals(string.Empty))
				cmd.Parameters[ "@IdEstadoCheque" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEstadoCheque" ].Value = IdEstadoCheque;
			


			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data.Tables[0];
		}
		
		
		public static DataSet GetValores( string IdCuenta, string IdTDCompTesoreria, string Numero, string TipoRetencion)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_Valores_GetByIdCuenta" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_GetByIdCuenta", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;			
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Numero" ].Value = Numero;
			cmd.Parameters.Add( new SqlParameter( "@TipoRetencion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@TipoRetencion" ].Value = TipoRetencion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		

		public static tfi_ValoresControlCajaDataset GetValoresCaja( string IdInstanciaCaja )
		{
			tfi_ValoresControlCajaDataset data = new tfi_ValoresControlCajaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_ValoresControlCaja" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_GetValoresCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		

		public static tfi_ValoresDataset GetList()
		{
			tfi_ValoresDataset data = new tfi_ValoresDataset();

			return ( tfi_ValoresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_Valores" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static tfi_ValoresDataset GetList( string IdValor, string IdTDCompTesoreria, string Numero, string IdEntidad, DateTime FechaVencimiento, decimal Valor, string IdMoneda, string IdCotizacionMoneda , string IdEstadoCheque)
		{
			tfi_ValoresDataset data = new tfi_ValoresDataset();
			
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
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoCheque", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoCheque" ].Value = IdEstadoCheque;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
         
			return data;
		}

		public static tfi_ValoresDataset.tfi_ValoresRow NewRow()
		{
			return ( new tfi_ValoresDataset() ).tfi_Valores.Newtfi_ValoresRow();
		}
	
		public static tfi_ValoresDataset.tfi_ValoresRow GetByPk( string IdValor )
		{
			tfi_ValoresDataset data = new tfi_ValoresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_Valores" );

			adapter.Fill( data );

			if ( data.tfi_Valores.Rows.Count == 1 )
			{
				return ( tfi_ValoresDataset.tfi_ValoresRow )data.tfi_Valores.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_ValoresDataset.tfi_ValoresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_ValoresDataset.tfi_ValoresDataTable )row.Table ).Addtfi_ValoresRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_ValoresDataset dataSet )
		{
			Update( dataSet.tfi_Valores );
		}


		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			SentenciasReplicacion replication = null;
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_ValoresDataset.tfi_ValoresDataTable )dataTable, trx, replication );
				trx.Commit();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
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
				

		public static void Update(System.Data.DataTable dataTable,  SqlTransaction trx,  SentenciasReplicacion replication )
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



