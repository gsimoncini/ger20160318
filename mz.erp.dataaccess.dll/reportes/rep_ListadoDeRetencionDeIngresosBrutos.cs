//German 20120412 - Tarea 0000286
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeRetencionDeIngresosBrutos.
	/// </summary>
	public class rep_ListadoDeRetencionDeIngresosBrutos
	{
		public rep_ListadoDeRetencionDeIngresosBrutos()
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
				adapter.TableMappings.Add( "Table", "tpu_Retenciones" );

				SqlCommand cmd = new SqlCommand( "Pr_tpu_ListarRetencionIngresosBrutosEntreFechas", dbhelper.Connection.GetConnection() );
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
//German 20120412 - Tarea 0000286