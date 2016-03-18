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
	/// Descripción breve de tfi_ReporteCierreCaja.
	/// </summary>
	public class tfi_ReporteCierreCaja
	{
		public tfi_ReporteCierreCaja()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetCierreCaja (string IdInstanciaCaja)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			

			SqlCommand cmd = new SqlCommand( "Pr_tfi_InstanciasCaja_CierreCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja;
			adapter.SelectCommand = cmd;
			adapter.Fill( data,"TablaCierreCaja" );
         
			return data;

		}

	}
}
