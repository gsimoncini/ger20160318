using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tsa_CuentaCorriente.
	/// </summary>
	public class tsa_CuentaCorriente
	{
		public tsa_CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetSaldoAnterior (string IdCuenta, DateTime desde, string ComprobantesCtaCte)
		{

			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_GetSaldoAnterior", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
	
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@desde", SqlDbType.DateTime ) );
			if (desde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@desde" ].Value =System.DBNull.Value;
			else
			{
				desde = mz.erp.systemframework.Util.GetEndPriorDay(desde);
				cmd.Parameters[ "@desde" ].Value = desde;
				
			}
			cmd.Parameters.Add( new SqlParameter( "@ComprobantesCtaCte", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ComprobantesCtaCte" ].Value = ComprobantesCtaCte;

			adapter.TableMappings.Add( "Table", "SaldoAnterior" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "SaldoAnterior");
			
			return data;

		}



		public static System.Data.DataSet GetDetalleCuentaCorriente(string IdCuenta,DateTime desde,DateTime hasta, string ComprobantesCtaCte, string OrderBy, bool verHTML)
		{

			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentaCorrienteDetalle", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
	
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@desde", SqlDbType.DateTime ) );
			DateTime aux = new DateTime(desde.Year, desde.Month, desde.Day,0,0,0,0);
			if (desde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@desde" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@desde" ].Value = aux;

			cmd.Parameters.Add( new SqlParameter( "@hasta", SqlDbType.DateTime ) );
			aux = new DateTime(hasta.Year, hasta.Month, hasta.Day,23,59,59);
			if (hasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@hasta" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@hasta" ].Value = aux;
			cmd.Parameters.Add( new SqlParameter( "@ComprobantesCtaCte", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ComprobantesCtaCte" ].Value = ComprobantesCtaCte;

			cmd.Parameters.Add( new SqlParameter( "@temporal", SqlDbType.VarChar) );
			cmd.Parameters[ "@temporal" ].Value =System.DBNull.Value;
			
			cmd.Parameters.Add( new SqlParameter( "@stringOrder", SqlDbType.VarChar) );
			if (OrderBy == null || OrderBy.Equals(string.Empty))
				cmd.Parameters[ "@stringOrder" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@stringOrder" ].Value = OrderBy;

			cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
			cmd.Parameters[ "@VerHTML"].Value = verHTML;
			

			adapter.TableMappings.Add( "Table", "DetalleCuentaCorriente" );			
			adapter.SelectCommand = cmd;	
	
			adapter.Fill( data, "DetalleCuentaCorriente");
		
			return data;
		}
		/*Sobrecarga que deberia usarse cuando el flujo viene por un comprobante de pago*/
		public static System.Data.DataSet GetDetalleCuentaCorriente(string IdCuenta,DateTime desde,DateTime hasta, string ComprobantesCtaCte)
		{

			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_GetDetalleCuentaCorriente", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
	
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@desde", SqlDbType.DateTime ) );
			DateTime aux = new DateTime(desde.Year, desde.Month, desde.Day,0,0,0,0);
			if (desde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@desde" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@desde" ].Value = aux;

			cmd.Parameters.Add( new SqlParameter( "@hasta", SqlDbType.DateTime ) );
			aux = new DateTime(hasta.Year, hasta.Month, hasta.Day,23,59,59);
			if (hasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@hasta" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@hasta" ].Value = aux;
			cmd.Parameters.Add( new SqlParameter( "@ComprobantesCtaCte", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ComprobantesCtaCte" ].Value = ComprobantesCtaCte;
			

		

			adapter.TableMappings.Add( "Table", "DetalleCuentaCorriente" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "DetalleCuentaCorriente");
		
			return data;
		}



		public static System.Data.DataSet GetDetalleCuentaCorrienteGeneral(DateTime fecha, string ComprobantesCtaCte, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentaCorrienteGeneralAAA", dbhelper.Connection.GetConnection() );			
			cmd.CommandType = CommandType.StoredProcedure;			
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
	
			cmd.Parameters.Add( new SqlParameter( "@fecha", SqlDbType.DateTime ) );
		//	DateTime aux = new DateTime(fecha.Year, fecha.Month, fecha.Day,0,0,0,0);
			DateTime aux=mz.erp.systemframework.Util.GetEndDay(fecha);
			if (fecha.Equals(DateTime.MinValue))
				cmd.Parameters[ "@fecha" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@fecha" ].Value = aux;

			cmd.Parameters.Add( new SqlParameter( "@comprobantes", SqlDbType.VarChar ) );
			cmd.Parameters[ "@comprobantes" ].Value = ComprobantesCtaCte;

			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
			if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
			if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
			if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
			if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
			if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
			if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
			if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


			cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
			if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;

			
			adapter.TableMappings.Add( "Table", "DetalleCuentaCorriente" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "DetalleCuentaCorriente");
		
			return data;
		}


		public static System.Data.DataSet GetSaldoPosterior (string IdCuenta, DateTime hasta, string ComprobantesCtaCte)
		{

			System.Data.DataSet data = new System.Data.DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_GetSaldoPosterior", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
	
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@hasta", SqlDbType.DateTime ) );
			if (hasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@hasta" ].Value =System.DBNull.Value;
			else
			{
				hasta = mz.erp.systemframework.Util.GetNextStartDay(hasta);
				cmd.Parameters[ "@hasta" ].Value = hasta;
			}
			cmd.Parameters.Add( new SqlParameter( "@ComprobantesCtaCte", SqlDbType.VarChar ) );
			cmd.Parameters[ "@ComprobantesCtaCte" ].Value = ComprobantesCtaCte;
		

			adapter.TableMappings.Add( "Table", "SaldoPosterior" );
			adapter.SelectCommand = cmd;		
			adapter.Fill( data, "SaldoPosterior");
	
			return data;

		}
 
		public static void Update(tsa_AplicacionPagosDataset dataAplicacionPago, tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda)
		{

			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				string IdSentenciaReplicacion = "-1";
				mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update(dataDetalleDeuda.tsa_ComprobanteDetalleDeuda,trx);
				mz.erp.dataaccess.tsa_AplicacionPagos.Update( dataAplicacionPago.tsa_AplicacionPagos, trx );
			
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
		
		public static System.Data.DataSet GetDetalleCuentaCorrienteVentas(string IdCuenta, long TipoCtaCte)
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_GetCuentaCorrienteSimple", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
	
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@TipoCtaCte", SqlDbType.BigInt ) );
			if (TipoCtaCte.Equals(long.MinValue))
				cmd.Parameters[ "@TipoCtaCte" ].Value = System.DBNull.Value;
			else			
				cmd.Parameters[ "@TipoCtaCte" ].Value = TipoCtaCte;
			
			adapter.TableMappings.Add( "Table", "DetalleCuentaCorriente" );			
			adapter.SelectCommand = cmd;	
	
			adapter.Fill( data, "DetalleCuentaCorriente");
		
			return data;
		}

        //German 20120222 -  Tarea 0000247
        public static System.Data.DataSet GetRemitosSinFacturar(string IdCuenta, long TipoCtaCte, bool ActualizaPrecios)
        {
            System.Data.DataSet data = new System.Data.DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Pr_tsa_GetRemitosSinFacturarCliente", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

            cmd.Parameters.Add(new SqlParameter("@IdCuenta", SqlDbType.VarChar));
            cmd.Parameters["@IdCuenta"].Value = IdCuenta;

            cmd.Parameters.Add(new SqlParameter("@TipoCtaCte", SqlDbType.BigInt));
            if (TipoCtaCte.Equals(long.MinValue))
                cmd.Parameters["@TipoCtaCte"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@TipoCtaCte"].Value = TipoCtaCte;

            cmd.Parameters.Add(new SqlParameter("@ActualizaPrecios", SqlDbType.BigInt));
            if (ActualizaPrecios)
                cmd.Parameters["@ActualizaPrecios"].Value = 1;
            else
                cmd.Parameters["@ActualizaPrecios"].Value = 0;

            adapter.TableMappings.Add("Table", "DetalleRemitosSinFacturarCliente");
            adapter.SelectCommand = cmd;

            adapter.Fill(data, "DetalleRemitosSinFacturarCliente");

            return data;
        }

        public static System.Data.DataSet GetAcopiosPendientes(string IdCuenta, long TipoCtaCte)
        {
            System.Data.DataSet data = new System.Data.DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Pr_tsa_GetAcopiosPendientes", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

            cmd.Parameters.Add(new SqlParameter("@IdCuenta", SqlDbType.VarChar));
            cmd.Parameters["@IdCuenta"].Value = IdCuenta;

            cmd.Parameters.Add(new SqlParameter("@TipoCtaCte", SqlDbType.BigInt));
            if (TipoCtaCte.Equals(long.MinValue))
                cmd.Parameters["@TipoCtaCte"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@TipoCtaCte"].Value = TipoCtaCte;

            adapter.TableMappings.Add("Table", "DetalleAcopiosPendientes");
            adapter.SelectCommand = cmd;

            adapter.Fill(data, "DetalleAcopiosPendientes");

            return data;
        }
        //German 20120222 -  Tarea 0000247

		public static System.Data.DataSet GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte,  string TiposDeComprobantesValidos, bool SoloPendientes, bool SoloPendientesSaldoTemporal)
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tpu_GetCuentaCorrienteSimple", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
	
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

			cmd.Parameters.Add( new SqlParameter( "@TipoCtaCte", SqlDbType.BigInt ) );
			if (TipoCtaCte.Equals(long.MinValue))
				cmd.Parameters[ "@TipoCtaCte" ].Value = System.DBNull.Value;
			else			
				cmd.Parameters[ "@TipoCtaCte" ].Value = TipoCtaCte;

			cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobantesValidos", SqlDbType.VarChar ) );
			if (TiposDeComprobantesValidos == null || TiposDeComprobantesValidos == string.Empty )
				cmd.Parameters[ "@TiposDeComprobantesValidos" ].Value = System.DBNull.Value;
			else			
				cmd.Parameters[ "@TiposDeComprobantesValidos" ].Value = TiposDeComprobantesValidos;

			cmd.Parameters.Add( new SqlParameter( "@SoloPendientes", SqlDbType.Bit ) );
			cmd.Parameters[ "@SoloPendientes" ].Value = SoloPendientes;

			
			cmd.Parameters.Add( new SqlParameter( "@SoloPendientesSaldoTemporal", SqlDbType.Bit ) );
			cmd.Parameters[ "@SoloPendientesSaldoTemporal" ].Value = SoloPendientesSaldoTemporal;

			adapter.TableMappings.Add( "Table", "DetalleCuentaCorriente" );			
			adapter.SelectCommand = cmd;	
	
			adapter.Fill( data, "DetalleCuentaCorriente");
		
			return data;
		}


		public static System.Data.DataSet GetImputacionesDetalleCuentaCorrienteVentas(string IdTipoComprobante, string IdComprobante,  short Cuota, int Signo)
		{			
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();					
			SqlCommand cmd = new SqlCommand( "Pr_tsa_GetImputacionesCuentaCorrienteSimple", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;			
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
	
			cmd.Parameters.Add( new SqlParameter( "@IdTipoComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoComprobante" ].Value = IdTipoComprobante;


			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante == null || IdComprobante == string.Empty )
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else			
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;

			cmd.Parameters.Add( new SqlParameter( "@Cuota", SqlDbType.SmallInt ) );
			cmd.Parameters[ "@Cuota" ].Value = Cuota;

			
			cmd.Parameters.Add( new SqlParameter( "@Signo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Signo" ].Value = Signo;

			adapter.SelectCommand = cmd;
			try
			{
				adapter.Fill( data);
			}
			catch(Exception e)
			{
				string mje = e.Message;
			}
		
			return data;
		}
	}
}
