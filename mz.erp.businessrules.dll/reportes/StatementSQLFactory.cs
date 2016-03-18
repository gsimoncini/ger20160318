using System;
using System.Collections;
using System.Windows.Forms;
using mz.erp.systemframework;

namespace mz.erp.businessrules.reportes
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

		public  static System.Data.DataTable  GetSQLForImpuestosReport(DateTime desde, DateTime hasta, ArrayList impuestos,string compVenta)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Util.ResourcePath()+ "\\resources\\Reports\\" + "ReportImpuestos.RPX.config"));
			int i= 2;
			foreach (string IdImp in impuestos)
			{
				((ReportParameterConfig)rc.ParametersSQL.GetValue(i)).ValorPorDefecto = IdImp;
				i++;
			}
			((ReportParameterConfig)rc.ParametersSQL.GetValue(7)).ValorPorDefecto = compVenta;
			return rc.GetDataTable();
		}


		public  static System.Data.DataTable  GetSQLForImpuestosReport(DateTime desde, DateTime hasta, int NroFolio, ArrayList impuestos,string compVenta)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Util.ResourcePath()+ "\\resources\\Reports\\" + "ReportImpuestos.RPX.config"));
			int i= 2;
			foreach (string IdImp in impuestos)
			{
				((ReportParameterConfig)rc.ParametersSQL.GetValue(i)).ValorPorDefecto = IdImp;
				i++;
			}
			((ReportParameterConfig)rc.ParametersSQL.GetValue(7)).ValorPorDefecto = compVenta;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(8)).ValorPorDefecto = NroFolio;
			return rc.GetDataTable();
		
			
		}


		public static System.Data.DataTable GetSQLForCierreCajaReport(string IdInstanciaCaja)
		{	
			
			ReportConfig rc = ReportConfig.Read(String.Format(Util.ResourcePath() + "\\resources\\Reports\\" + "ReportCierreCaja.RPX.config"));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdInstanciaCaja;
			return rc.GetDataTable();
		}

		public static System.Data.DataTable GetSQLForCuentaCorrienteReport(DateTime desde, DateTime hasta, string Cuenta, string ComprobantesCtaCte, string OrderBy)
		{
			ReportConfig rc = ReportConfig.Read(String.Format( Util.ResourcePath() + "\\resources\\Reports\\" + "ReportCuentaCorriente.RPX.config"));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = Cuenta;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(1)).ValorPorDefecto = Convert.ToString(new DateTime(desde.Year,desde.Month,desde.Day,0,0,0)) ;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(2)).ValorPorDefecto = Convert.ToString(new DateTime(hasta.Year,hasta.Month,hasta.Day,23,59,59));
			((ReportParameterConfig)rc.ParametersSQL.GetValue(3)).ValorPorDefecto = ComprobantesCtaCte;
			((ReportParameterConfig)rc.ParametersSQL.GetValue(4)).ValorPorDefecto = OrderBy;
			return rc.GetDataTable();
		}

		public static System.Data.DataTable GetSQLForComprobantesComprasReport(string IdComprobante, string family)
		{
			bool configPersonalizado = Variables.GetValueBool("Reportes.ComprobantesCompras." + family + ".UsaConfigParticular");
			ReportConfig rc = null;
			if(!configPersonalizado)
			{
				rc = ReportConfig.Read(String.Format( Util.ResourcePath() + "\\resources\\Reports\\" + "ReportComprobantesCompras.RPX.config"));
				/* Silvina 20100707 - Tarea 525 */
				if (rc.ParametersSQL.Length >= 1)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdComprobante;
				if (rc.ParametersSQL.Length >= 2)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(1)).ValorPorDefecto = Variables.GetValueString("Reportes.ComprobantesCompras." + family + ".TipoDomicilio" );
				if (rc.ParametersSQL.Length >= 3)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(2)).ValorPorDefecto = Variables.GetValueString("Reportes.ComprobantesCompras." + family + ".VariablesAuxiliares" );
                if (rc.ParametersSQL.Length >= 4)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(3)).ValorPorDefecto = Variables.GetValueString("Reportes.ComprobantesCompras." + family + ".Orden");
				/* Fin Silvina */			
			}
			else
			{
				rc = ReportConfig.Read(String.Format( Util.ResourcePath() + "\\resources\\Reports\\" + "ReportComprobantesCompras" + family + ".RPX.config"));
				((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdComprobante;
				
			}
			return rc.GetDataTable();

		}

		public static System.Data.DataTable GetSQLForComprobantesReport(string IdComprobante, string family)
		{
			bool configPersonalizado = Variables.GetValueBool("Reportes.Comprobantes." + family + ".UsaConfigParticular");
			ReportConfig rc = null;
			if(!configPersonalizado)
			{
				rc = ReportConfig.Read(String.Format( Util.ResourcePath() + "\\resources\\Reports\\" + "ReportComprobantes.RPX.config"));
				/* Silvina 20100707 - Tarea 525 */
				if (rc.ParametersSQL.Length >= 1)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdComprobante;
				if (rc.ParametersSQL.Length >= 2)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(1)).ValorPorDefecto = Variables.GetValueString("Reportes.Comprobantes." + family + ".TipoDomicilio" );
				if (rc.ParametersSQL.Length >= 3)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(2)).ValorPorDefecto = Variables.GetValueString("Reportes.Comprobantes." + family + ".VariablesAuxiliares" );
				if (rc.ParametersSQL.Length >= 4)
					((ReportParameterConfig)rc.ParametersSQL.GetValue(3)).ValorPorDefecto = Variables.GetValueString("Reportes.Comprobantes." + family + ".Orden");
				/* Fin Silvina */
			}
			else
			{
				rc = ReportConfig.Read(String.Format( Util.ResourcePath() + "\\resources\\Reports\\" + "ReportComprobantes" + family + ".RPX.config"));
				((ReportParameterConfig)rc.ParametersSQL.GetValue(0)).ValorPorDefecto = IdComprobante;
				
			}
			return rc.GetDataTable();

		}
		/// <summary>
		/// Establece los valores de los parámetros del reporte con los datos que posee la coleccion ReportParameterCollection.
		/// La carga de los datos se efectúa por la asignación por referencia del objeto a las variables. 
		/// </summary>
		/// <param name="_reportName"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public static System.Data.DataTable GetSQLForGenericReport( string _configName, ReportParameterCollection parameters )
		{
			string ArchivoConfig = Util.ResourcePath()+ " \\resources\\Reports\\" + _configName+".RPX.config";
			ReportConfig rc = ReportConfig.Read(String.Format( ArchivoConfig));
			ReportParameterConfig[] arrayParams = rc.ParametersSQL;
			for(int i=0;i<arrayParams.Length;i++)
			{
				ReportParameterConfig reportparam = arrayParams[i];
				foreach( ReportParameter param in parameters )
				{
					if (reportparam.Nombre.CompareTo(param.ParameterName) == 0)
					{
						reportparam.ValorPorDefecto = param.ParameterValue;
					}
				}
			}
			return rc.GetDataTable();
		}
		

	}
}
