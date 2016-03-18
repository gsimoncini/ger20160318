using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDePercepcionDeIngresosBrutos.
	/// </summary>
	public class rep_ListadoDePercepcionDeIngresosBrutos
	{
		public rep_ListadoDePercepcionDeIngresosBrutos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataTable GetList(DateTime FechaDesde, DateTime FechaHasta)
		{			
			try
			{
				DataTable data = new DataTable();

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsa_Comprobantes" );

				SqlCommand cmd = new SqlCommand( "Pr_tsa_ListarPercepcionIngresosBrutosEntreFechas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaDesde"].Value = System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) 
					cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);				
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}
				
				cmd.CommandTimeout = 60;

				adapter.SelectCommand = cmd;
				adapter.Fill( data );
				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}
		
	}
}
