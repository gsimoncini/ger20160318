namespace mz.erp.ui.forms.classes
{
	using System;	
	using System.Collections;
	using System.Windows.Forms;	
	using mz.erp.businessrules;
	using mz.erp.businessrules.comprobantes;
	using mz.erp.ui.controls;
	using mz.erp.ui.forms;

	/// <summary>
	/// Descripción breve de Impresion.
	/// </summary>
	public class Impresion
	{
		private bool _ok = false; 
		private bool _cerrar = true; 
		private ComprobanteDeVenta _comprobante;
		private Form _mdiParent;		
		public bool Ok
		{
			get 
			{
				return _ok;
			}
		}
		public bool Cerrar
		{
			get 
			{
				return _cerrar;
			}
		}
		
		public Impresion(Form MdiParent, ComprobanteDeVenta comprobante)
		{
			_comprobante = comprobante;
			_mdiParent = MdiParent;			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void Imprimir()
		{						
			ArrayList ComprobantesFiscales = new ArrayList();
			ComprobantesFiscales = systemframework.Util.Parse(Variables.GetValueString("Fiscal.Comprobantes"), ",");
			if (ComprobantesFiscales.Contains(_comprobante.TipoComprobanteDestino)) 
			{				
				if (Variables.GetValueBool("Fiscal.Activo") == true) 
				{
					bool ok = false;					
					if (ImprimeFiscal(_comprobante, ref ok)) 
					{						
						/*if (Variables.GetValueBool("Fiscal.InformacionAdicional"))  
						{
							MessageBox.Show("1-Va a grabar");
						}*/
						_comprobante.Commit();
						_comprobante.Flush();
					}
					else 
					{						
						if (ok) 
						{							
							/*if (Variables.GetValueBool("Fiscal.InformacionAdicional"))  
							{
								MessageBox.Show("2-Va a grabar");
							}*/
							_comprobante.Commit();
							_comprobante.Flush();
							ReportsManager.PrintReportComprobantes(_comprobante.IdComprobante,_mdiParent);
						}
					}					
					_ok = ok;
				}
				else
				{
					//El comprobante lo mando a imprimir con un reporte
					/*if (Variables.GetValueBool("Fiscal.InformacionAdicional"))  
					{
						MessageBox.Show("3-Va a grabar");
					}*/
					/*if (_comprobante.Commit())
					{
						//MessageBox.Show("La acción se ha ejecutado con éxito");
						_comprobante.Flush();
						_ok = true;	
						ReportsManager.PrintReportComprobantes(_comprobante.IdComprobante, _mdiParent);						
					}*/
				}
			}
			else 
			{
				//otros tipos de comprobantes
				_ok = true;

				/*if (Variables.GetValueBool("Fiscal.InformacionAdicional"))  
				{
					MessageBox.Show("4-Va a grabar");
				}*/

				_comprobante.Commit();
				_comprobante.Flush();

				//MessageBox.Show("La acción se ha ejecutado con éxito");				

				ReportsManager.PrintReportComprobantes(_comprobante.IdComprobante, _mdiParent);
			}
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		private bool ImprimeFiscal(ComprobanteDeVenta comprobante, ref bool Grabar) 
		{												
			FrmFiscal frmFis = new FrmFiscal();			
			String Momento = "Fiscal.Momentos." + comprobante.Momento;
			String TipoComprobante = Variables.GetValueString(Momento);			
			if (frmFis.ImpresionFiscal(comprobante, TipoComprobante)) 
			{
				if (Variables.GetValueBool("Fiscal.CierreAutomatico")) 
				{
					frmFis.Close();
				}						
				Grabar = true;								
			}
			else 
			{
				if (frmFis.SoportaComprobante) 
				{       
					MessageBox.Show("El comprobante es soportado. Posible error en impresion."); 											
					Grabar = false;
					_cerrar = false;
				}
				else 
				{
					MessageBox.Show("El comprobante no es soportado"); 
					Grabar = true;															
				}
			}			
			return Grabar;
		}

		/*public static void ImprimirReciboFiscal(ComprobanteDePago Comprobante)
		{
			FrmFiscal frmFis = new FrmFiscal();			
			//String Momento = "Fiscal.Momentos." + comprobante.Momento;
			//String TipoComprobante = Variables.GetValueString(Momento);
			string TipoComprobante = "RX";
			if (frmFis.ImpresionFiscal(Comprobante, TipoComprobante)) 
			{
				if (Variables.GetValueBool("Fiscal.CierreAutomatico")) 
				{
					frmFis.Close();
				}						
				//Grabar = true;								
			}
			else 
			{
				if (frmFis.SoportaComprobante) 
				{       
					MessageBox.Show("El comprobante es soportado. Posible error en impresion."); 											
					//Grabar = false;
					//_cerrar = false;
				}
				else 
				{
					MessageBox.Show("El comprobante no es soportado"); 
					//Grabar = true;															
				}
			}			
			//return Grabar;
		}*/

	}
}
