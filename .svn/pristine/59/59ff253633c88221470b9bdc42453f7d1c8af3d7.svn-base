using System;
using System.Data;
using System.Collections;


using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de tsa_ReporteImpuestos.
	/// </summary>
	public class tsa_ReporteImpuestos
	{
		public tsa_ReporteImpuestos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetLibroIVACompras(int AñoDesde, int MesDesde, int AñoHasta, int MesHasta, string ListaTiposDeComprobantes)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
			

				SqlCommand cmd = new SqlCommand( "Pr_ComprobantesImpuestos_GetImpuestos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@AñoDesde", SqlDbType.BigInt ) );
				cmd.Parameters[ "@AñoDesde" ].Value = AñoDesde;
				cmd.Parameters.Add( new SqlParameter( "@AñoHasta", SqlDbType.BigInt ) );
				cmd.Parameters[ "@AñoHasta" ].Value = AñoHasta;

				cmd.Parameters.Add( new SqlParameter( "@MesDesde", SqlDbType.BigInt ) );
				cmd.Parameters[ "@MesDesde" ].Value = MesDesde;
				cmd.Parameters.Add( new SqlParameter( "@MesHasta", SqlDbType.BigInt ) );
				cmd.Parameters[ "@MesHasta" ].Value = MesHasta;
				
				cmd.Parameters.Add( new SqlParameter( "@ListaTiposDeComprobantes", SqlDbType.VarChar));
				cmd.Parameters["@ListaTiposDeComprobantes"].Value = ListaTiposDeComprobantes;
			
				adapter.SelectCommand = cmd;

				adapter.Fill( data,"TablaDetalleDeImpuestos" );
			}
			catch (Exception e){;}
			return data;


		
			
		}

		public static System.Data.DataSet GetList(DateTime fechaDesde, DateTime fechaHasta, ArrayList impuestos, string CompDeVentas)
		{

			System.Data.DataSet data = new DataSet();
			try
			{
				
				SqlDataAdapter adapter = new SqlDataAdapter();
			

				SqlCommand cmd = new SqlCommand( "Pr_tsa_ImpuestosComprobantes_GetImpuestos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@dDesde", SqlDbType.DateTime ) );
				if (fechaDesde.Equals(DateTime.MinValue)) 
					cmd.Parameters[ "@dDesde" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@dDesde" ].Value = fechaDesde;
				cmd.Parameters.Add( new SqlParameter( "@dHasta", SqlDbType.DateTime) );
				if (fechaHasta.Equals(DateTime.MinValue))
					cmd.Parameters[ "@dHasta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@dHasta" ].Value = fechaHasta;
				int i = 0;
				foreach(object obj in impuestos)
				{
					i++;
					cmd.Parameters.Add( new SqlParameter( "@IdImpuestoFijo"+i.ToString(), SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdImpuestoFijo"+i.ToString() ].Value = obj;

				}
				cmd.Parameters.Add( new SqlParameter( "@TiposDeCompVentas", SqlDbType.VarChar));
				cmd.Parameters["@TiposDeCompVentas"].Value = CompDeVentas;
			
				adapter.SelectCommand = cmd;

				adapter.Fill( data,"TablaDetalleDeImpuestos" );
			}
			catch (Exception e){;}
			return data;


		}
	}
}
