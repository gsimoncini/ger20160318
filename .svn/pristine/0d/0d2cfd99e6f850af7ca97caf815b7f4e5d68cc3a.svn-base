using System;
using System.Collections;
using System.Windows.Forms;


namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripción breve de StatementSQLFactory.
	/// </summary>
	public class StatementSQLFactory
	{
		public StatementSQLFactory()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public  static string GetSQLForImpuestosReport(DateTime desde, DateTime hasta, ArrayList impuestos,string compVenta)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Application.StartupPath + "\\resources\\Reports\\" + "ReportImpuestos.RPX.config"));
			int i= 0;
			foreach (string IdImp in impuestos)
			{
				((ReportParameterConfig)rc.ParametersSQL.GetValue(i)).ValorPorDefecto = IdImp;
				i++;
			}
			((ReportParameterConfig)rc.ParametersSQL.GetValue(5)).ValorPorDefecto = compVenta;
			return rc.Format();
		
			
		}

		public static string GetSQLForCierreCajaReport(string IdInstanciaCaja)
		{
			
			
			ReportConfig rc = ReportConfig.Read(String.Format( Application.StartupPath + "\\resources\\Reports\\" + "ReportCierreCaja.RPX.config"));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdInstanciaCaja;
			return rc.Format();
		}

		public static string GetSQLForCuentaCorrienteReport(DateTime desde, DateTime hasta, string Cuenta, string ComprobantesCtaCte)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Application.StartupPath + "\\resources\\Reports\\" + "ReportCuentaCorriente.RPX.config"));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = Cuenta;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(1)).ValorPorDefecto = Convert.ToString((new DateTime(desde.Year,desde.Month,desde.Day,0,0,0))) ;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(2)).ValorPorDefecto = Convert.ToString((new DateTime(hasta.Year,hasta.Month,hasta.Day,0,0,0)) );
			((ReportParameterConfig)rc.ParametersSQL.GetValue(2)).ValorPorDefecto = ComprobantesCtaCte;
			return rc.Format();
			

		}
		public static string GetSQLForComprobantesReport(string IdComprobante)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Application.StartupPath + "\\resources\\Reports\\" + "ReportComprobantes.RPX.config"));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdComprobante;
			return rc.Format();

		}

	}
}
