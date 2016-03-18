using System;
using System.Data;
using System.Data.SqlClient;
//using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de Temporal.
	/// </summary>
	public class Temporal
	{
		public Temporal()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void ActualizarConsolidadoCheques() 
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_ListadoDeCheques", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_Valores_ListadoDeCheques" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);								
			}
			catch(Exception e){	}
		}
		public static void ActualizarConsolidadoTarjetas() 
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tfi_Valores_ListadoDeTarjetas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_Valores_ListadoDeTarjetas" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);								
			}
			catch(Exception e){	}
		}
	}
}
