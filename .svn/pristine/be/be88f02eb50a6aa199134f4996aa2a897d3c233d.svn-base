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

	/// <summary>
	/// Descripción breve de tfi_GetValorCotizacionEx.
	/// </summary>
	public class tfi_GetValorCotizacionEx
	{
		public tfi_GetValorCotizacionEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static decimal GetValorCotizacion(string IdMonedaOrigen, string IdMonedaDestino)
		{

			tfi_GetValorCotizacionExDataset data = new tfi_GetValorCotizacionExDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_GetValorCotizacion" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CotizacionesMoneda_GetValorCotizacion", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaOrigen" ].Value = IdMonedaOrigen;
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			if (data.Pr_tfi_CotizacionesMoneda_GetValorCotizacion.Rows.Count > 0) return (decimal) data.Pr_tfi_CotizacionesMoneda_GetValorCotizacion.Rows[0]["Valor"];
			return 0;
		}
		
	}
}
