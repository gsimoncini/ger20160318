using System;
using System.Collections;

using mz.erp.businessrules;

using System.Windows.Forms;
using mz.erp.ui.forms;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules.reportes;
using System.Data;

using mz.erp.commontypes.data;
/* Silvina 20110223 - Tarea */
using mz.erp.businessrules;
using mz.erp.commontypes;
/* Fin Silvina */

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ReportsManager.
	/// </summary>
	public class ReportsManager
	{
		public ReportsManager()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void PrintReportComprobantesCompras(string IdComprobante,string idTipoDecomprobante, Form parent)
		{
		
			string family = string.Empty;
			DataRow rowTipoComp = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(idTipoDecomprobante);
			if(rowTipoComp != null)
			{
				family = Convert.ToString(rowTipoComp["Familia"]);
				bool impresionHabilitada = Variables.GetValueBool("Comprobantes." +  family + ".ImpresionManualHabilitada");
				ArrayList tiposcomp = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Reportes.TiposDeComprobantesCompras." + family),",");
				if(impresionHabilitada)
				{
					if(tiposcomp.Contains(idTipoDecomprobante))
					{
						FrmPreviewReport preview2 = new FrmPreviewReport();
						ReportParameterCollection datos = new ReportParameterCollection();
						datos.Add(new ReportParameter("DireccionEmpresa", Variables.GetValueString("Sistema.DireccionEmpresa")));
						datos.Add(new ReportParameter("CategoriaIvaEmpresa",Variables.GetValueString("Sistema.CategoriaDeIvaEmpresa")));
						datos.Add(new ReportParameter("TelefonoEmpresa",	Variables.GetValueString("Sistema.TelefonosEmpresa")));
						datos.Add(new ReportParameter("CUITEmpresa",Variables.GetValueString("Sistema.CUITEmpresa")));
						datos.Add(new ReportParameter("IngresosBrutosEmpresa",Variables.GetValueString("Sistema.IngresosBrutosEmpresa")));
						datos.Add(new ReportParameter("InicioActividadesEmpresa",Variables.GetValueString("Sistema.InicioActividadesEmpresa")));
						datos.Add(new ReportParameter("Logo",Variables.GetValueString("Reportes.Logo")));
						/*
						datos.Add(new ReportParameter("Etiqueta1",Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta")));
						datos.Add(new ReportParameter("Etiqueta2",Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta")));
						datos.Add(new ReportParameter("Etiqueta3",Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta")));
						*/
													
						string IdVariablesAuxiliares = Variables.GetValueString("Reportes.Comprobantes." + family + ".VariablesAuxiliares" );
						//los id de variables 
						ArrayList ids = mz.erp.systemframework.Util.Parse(IdVariablesAuxiliares,",");

						VariablesAuxiliares varAuxs = new VariablesAuxiliares(IdComprobante,idTipoDecomprobante);
					
						foreach(VariableAuxiliar var in varAuxs.VariablesDeUsuario)
						{
							if(ids.Contains(var.Id))
							{
								string valor = var.Descripcion +": " +var.Valor;
								datos.Add(new ReportParameter("Param" + var.Id, valor));
							
							}
						}
						DataTable table =  mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForComprobantesComprasReport(IdComprobante, family);
						preview2.ShowReport(table,"ReportComprobantesCompras" + family +  ".RPX",parent,datos);
					}
				}
				else MessageBox.Show(parent,"No esta habilitada la impresion para este tipo de comprobante","Informacion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			}
			
				
		}

		public static void PrintReportComprobantes(string IdComprobante,string idTipoDecomprobante, Form parent)
		{
		
			string family = string.Empty;
			DataRow rowTipoComp = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(idTipoDecomprobante);
			if(rowTipoComp != null)
			{
				family = Convert.ToString(rowTipoComp["Familia"]);
				bool impresionHabilitada = Variables.GetValueBool("Comprobantes." +  family + ".ImpresionManualHabilitada");
				ArrayList tiposcomp = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Reportes.TiposDeComprobantes." + family),",");
				if(impresionHabilitada)
				{
					if(tiposcomp.Contains(idTipoDecomprobante))
					{
                        /* Silvina 20110223 - Tarea 36 */

                        ArrayList compPagos = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Comprobantes.ComprobantesDePago"), ",");
                        if (compPagos.Contains(idTipoDecomprobante))
                        {
                            FrmPreviewReport preview2 = new FrmPreviewReport();
                            ReportParameterCollection datos = new ReportParameterCollection();
                            tsa_ComprobantesDataset.tsa_ComprobantesRow comp = mz.erp.businessrules.tsa_Comprobantes.GetByPk(IdComprobante);
                            decimal Total = comp.Total;
                            DataTable table = mz.erp.businessrules.tsa_Comprobantes.GetComprobanteDePagoView(IdComprobante);

                            string moneda = mz.erp.businessrules.tfi_Monedas.GetDescripcionMoneda(comp.IdMonedaCierre);

                            string textoNumeros = NumberToText.NumberToWords(Total, moneda);

                            string nombreEmpresa = Variables.GetValueString("Sistema.NombreEmpresa");
                            table = AddColumn.AddColumnToTable(table, "NombreEmpresa", nombreEmpresa);
                            string domicilioEmpresa = Variables.GetValueString("Sistema.DireccionEmpresa");
                            table = AddColumn.AddColumnToTable(table, "DomicilioEmpresa", domicilioEmpresa);
                            string cuitEmpresa = Variables.GetValueString("Sistema.CUITEmpresa");
                            table = AddColumn.AddColumnToTable(table, "CUITEmpresa", cuitEmpresa);

                            foreach (DataRow row in table.Rows)
                            {
                                row["TextoTotal"] = textoNumeros;
                            }
                            
                            preview2.ShowReport(table, "ReportComprobantes" + family + ".RPX", parent,datos);
                        }
                        else
                        {
                        /* Fin Silvina */

                            FrmPreviewReport preview2 = new FrmPreviewReport();
                            ReportParameterCollection datos = new ReportParameterCollection();
                            datos.Add(new ReportParameter("DireccionEmpresa", Variables.GetValueString("Sistema.DireccionEmpresa")));
                            datos.Add(new ReportParameter("CategoriaIvaEmpresa", Variables.GetValueString("Sistema.CategoriaDeIvaEmpresa")));
                            datos.Add(new ReportParameter("TelefonoEmpresa", Variables.GetValueString("Sistema.TelefonosEmpresa")));
                            datos.Add(new ReportParameter("CUITEmpresa", Variables.GetValueString("Sistema.CUITEmpresa")));
                            datos.Add(new ReportParameter("IngresosBrutosEmpresa", Variables.GetValueString("Sistema.IngresosBrutosEmpresa")));
                            datos.Add(new ReportParameter("InicioActividadesEmpresa", Variables.GetValueString("Sistema.InicioActividadesEmpresa")));
                            datos.Add(new ReportParameter("Logo", Variables.GetValueString("Reportes.Logo")));
                            datos.Add(new ReportParameter("Etiqueta1", Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta")));
                            datos.Add(new ReportParameter("Etiqueta2", Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta")));
                            datos.Add(new ReportParameter("Etiqueta3", Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta")));

                            string IdVariablesAuxiliares = Variables.GetValueString("Reportes.Comprobantes." + family + ".VariablesAuxiliares");
                            //los id de variables 
                            ArrayList ids = mz.erp.systemframework.Util.Parse(IdVariablesAuxiliares, ",");

                            VariablesAuxiliares varAuxs = new VariablesAuxiliares(IdComprobante, idTipoDecomprobante);

                            foreach (VariableAuxiliar var in varAuxs.VariablesDeUsuario)
                            {
                                if (ids.Contains(var.Id))
                                {
                                    string valor = var.Descripcion + ": " + var.Valor;
                                    datos.Add(new ReportParameter("Param" + var.Id, valor));

                                }
                            }
                            DataTable table = mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForComprobantesReport(IdComprobante, family);
                            preview2.ShowReport(table, "ReportComprobantes" + family + ".RPX", parent, datos);
                        }
					}
				}
				else MessageBox.Show(parent,"No esta habilitada la impresion para este tipo de comprobante","Informacion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			}
			
				
		}
		public static void PrintReportComprobantes(string IdComprobante, Form parent)
		{
			
			System.Data.DataRow rowComp = mz.erp.businessrules.tsa_Comprobantes.GetByPk(IdComprobante);
			//CUIDADO SI ROWCOMP ES NULO!!!!!!! POR ACA ENTRO AL QUERER GUARDAR UNA PREFACTURA
			string idTipoDeComprobante = (string)rowComp["IdTipoDeComprobante"];
			PrintReportComprobantes( IdComprobante,idTipoDeComprobante, parent);
				
		}

		public static void PrintReportCierreCaja(string IdInstanciaCaja,Form parent)
		{
			FrmPreviewReport frmPR = new FrmPreviewReport();
			DataTable table  =  mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForCierreCajaReport(IdInstanciaCaja);
			frmPR.ShowReport(table,"ReportCierreCaja.RPX",parent, new object [] {});
		}

		public static void PrintReportCuentaCorriente(mz.erp.businessrules.comprobantes.CuentaCorriente _ctaCte,Form parent, string _process, bool soloPendientes, bool SoloFacturas, bool SoloNotasDeCreditos)
		{
			FrmPreviewReport frmpr = new FrmPreviewReport();
			string ComprobantesCtaCte = Variables.GetValueString("Momentos."+ _process+ ".Comprobantes");
			ArrayList FacturasList = new ArrayList();
			ArrayList NotasDeCreditosList = new ArrayList();
			if(SoloFacturas)
			{
				string Facturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas");
				FacturasList = mz.erp.systemframework.Util.Parse(Facturas,",");
				string FacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas DV");
				FacturasList.AddRange( mz.erp.systemframework.Util.Parse(FacturasDV,","));
			}

			if(SoloNotasDeCreditos)
			{
				string NotasDeCreditos = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Notas de Crédito");
				NotasDeCreditosList = mz.erp.systemframework.Util.Parse(NotasDeCreditos,",");
				string NotasDeCreditosDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Notas de Crédito DV");
				FacturasList.AddRange( mz.erp.systemframework.Util.Parse(NotasDeCreditosDV,","));
			}


			//string ComprobantesCtaCte =  Variables.GetValueString("Cuentas.CuentaCorriente.Comprobantes");
			/*
			table  =  mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForCuentaCorrienteReport(_ctaCte.FechaDesde, _ctaCte.FechaHasta, _ctaCte.IdCuenta, ComprobantesCtaCte, _ctaCte.OrderBy);
			frmpr.ShowReport(table, "ReportCuentaCorriente.RPX", parent, new object []{});
			*/
			ArrayList aux = new ArrayList();
			foreach(DetalleCuentaCorriente dcc in _ctaCte.Detalle)
			{
				bool cond1 = !SoloNotasDeCreditos && !SoloFacturas;
				bool cond2 = SoloFacturas && FacturasList.Contains(dcc.IdTipoDeComprobante);
				bool cond3 = SoloNotasDeCreditos && NotasDeCreditosList.Contains(dcc.IdTipoDeComprobante);
				if(cond1 || cond2 || cond3)
				{
					DetalleCuentaCorrienteView dccw = new DetalleCuentaCorrienteView(dcc,_ctaCte.SaldoAnterior, _ctaCte.SaldoPosterior, soloPendientes,_ctaCte.Cuenta,_ctaCte.FechaDesde, _ctaCte.FechaHasta);
					aux.Add(dccw);
				}
			}
			DataTable table = (new mz.erp.commontypes.DataTableConverter()).GetDataTable(aux);
			FrmPreviewReport frmpr1 = new FrmPreviewReport();
			frmpr1.ShowReport(table, "ReportCuentaCorriente.RPX", parent, new object []{});
		}

		public static void PrintReportCuentaCorriente(ArrayList array,Form parent, string _process, bool soloPendientes, bool SoloFacturas, bool SoloNotasDeCreditos, decimal SaldoAnterior, decimal SaldoPosterior, DateTime FechaDesde, DateTime FechaHasta, string Codigo)
		{
			/*FrmPreviewReport frmpr = new FrmPreviewReport();
			string ComprobantesCtaCte = Variables.GetValueString("Momentos."+ _process+ ".Comprobantes");
			ArrayList FacturasList = new ArrayList();
			ArrayList NotasDeCreditosList = new ArrayList();
			if(SoloFacturas)
			{
				string Facturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas");
				FacturasList = mz.erp.systemframework.Util.Parse(Facturas,",");
				string FacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas DV");
				FacturasList.AddRange( mz.erp.systemframework.Util.Parse(FacturasDV,","));
			}

			if(SoloNotasDeCreditos)
			{
				string NotasDeCreditos = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Notas de Crédito");
				NotasDeCreditosList = mz.erp.systemframework.Util.Parse(NotasDeCreditos,",");
				string NotasDeCreditosDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Notas de Crédito DV");
				FacturasList.AddRange( mz.erp.systemframework.Util.Parse(NotasDeCreditosDV,","));
			}*/
			
			
			ArrayList aux = new ArrayList();			 
			foreach(ItemCuentaCorriente icc in array)
			{
				/*bool cond1 = !SoloNotasDeCreditos && !SoloFacturas;
				bool cond2 = SoloFacturas && FacturasList.Contains(dcc.IdTipoDeComprobante);
				bool cond3 = SoloNotasDeCreditos && NotasDeCreditosList.Contains(dcc.IdTipoDeComprobante);*/
				//if(cond1 || cond2 || cond3)
				//{
					DetalleCuentaCorrienteView dccw = new DetalleCuentaCorrienteView(icc, SaldoAnterior, SaldoPosterior, soloPendientes, Codigo, FechaDesde, FechaHasta);
					aux.Add(dccw);
				//}
			}
			DataTable table = (new mz.erp.commontypes.DataTableConverter()).GetDataTable(aux);
			FrmPreviewReport frmpr1 = new FrmPreviewReport();
			frmpr1.ShowReport(table, "ReportCuentaCorriente.RPX", parent, new object []{});
		}
		public static void PrintReportLibroDeIVA(Form parent)
		{
			FrmPreviewReport preview2 = new FrmPreviewReport();
					
			ArrayList impuestos = new ArrayList();
			impuestos.Add("IVA");
			impuestos.Add("IVADIF");	
			DataTable table  = mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForImpuestosReport(DateTime.MinValue, DateTime.MinValue, 0 ,impuestos, Variables.GetValueString("Reportes.SubdiarioVentas.Comprobantes"));
			preview2.ShowReport(table ,"ReportImpuestos.RPX",parent, new object [] {impuestos});	
		}

		public static void PrintReportImpuestos(DateTime fechaDesde, DateTime fechaHasta, ArrayList impuestos,Form parent)
		{
			DataTable table  =  mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForImpuestosReport(fechaDesde, fechaHasta, impuestos,Variables.GetValueString("Comprobantes.ComprobantesDeVenta"));
			//	System.Data.DataSet data = mz.erp.businessrules.reportes.tsa_ReporteImpuestos.GetList(fechaDesde, fechaHasta, impuestos);
			FrmPreviewReport preview = new FrmPreviewReport();
			
			preview.ShowReport(table, "ReportImpuestos.RPX",parent, new object [] {impuestos});
		}	

		public static void PrintReportRetenciones(long IdRetencion, Form parent)
		{
			FrmPreviewReport preview2 = new FrmPreviewReport();
					
			DataSet data = tpu_Retenciones.GetList(IdRetencion);
			DataTable table = data.Tables[0];
			string nombreEmpresa = Variables.GetValueString("Sistema.NombreEmpresa");
			table = mz.erp.commontypes.AddColumn.AddColumnToTable(table, "NombreEmpresa", nombreEmpresa);
			string domicilioEmpresa = Variables.GetValueString("Sistema.DireccionEmpresa");
			table = mz.erp.commontypes.AddColumn.AddColumnToTable(table, "DomicilioEmpresa", domicilioEmpresa);
			string cuitEmpresa = Variables.GetValueString("Sistema.CUITEmpresa");
			table = mz.erp.commontypes.AddColumn.AddColumnToTable(table, "CUITEmpresa", cuitEmpresa);
			string IdTipoDeRetencion = (string)table.Rows[0]["IdTipoDeRetencion"];
			if(IdTipoDeRetencion.Equals("G"))
                preview2.ShowReport(table ,"ReportRetencionGanancias.RPX",parent, new object [] {});	
			else
				preview2.ShowReport(table ,"ReportRetencionIIBB.RPX",parent, new object [] {});	
		}

        /* Silvina 20120420 - Tarea 0000294 */
        public static void PrintReportConsultaComisiones(DataTable Data, Form parent)
        {
            FrmPreviewReport preview2 = new FrmPreviewReport();
            preview2.ShowReport(Data, "ReportConsultarComisiones.RPX", parent, new object[] { });
        }

        public static void PrintReportConsultaVentas(DataTable Data, Form parent)
        {
            FrmPreviewReport preview2 = new FrmPreviewReport();
            preview2.ShowReport(Data, "ReportConsultarVentas.RPX", parent, new object[] { });
        }

        public static void PrintReportConsultaCobranzas(DataTable Data, Form parent)
        {
            FrmPreviewReport preview2 = new FrmPreviewReport();
            preview2.ShowReport(Data, "ReportConsultarCobranzas.RPX", parent, new object[] { });
        }

        /* Fin Silvina 20120420 - Tarea 0000294 */

	}
}
