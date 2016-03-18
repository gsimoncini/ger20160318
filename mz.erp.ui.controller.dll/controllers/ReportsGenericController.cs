using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules.reportes;
using System.Data;
using System.Collections;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ImpresionComprobanteDeVentaController.
	/// </summary>	
	public class ReportsGenericController: ITaskController
	{
		ImprimirReporte  _brclass;		

		#region Contructores
		public ReportsGenericController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			this._brclass = new ImprimirReporte();
		}

		public ReportsGenericController( ImprimirReporte brSenderInstance )
		{
			this._brclass = brSenderInstance;
		
		}
	

		private void Init()
		{
		}
		#endregion

		#region Variables Públicas

		public event EventHandler OnTaskAfterExecute;
		public event EventHandler OnModelChanged;

        //German 20100713 - Tarea 793
        public bool AllowBandejaPorTipoDeComprobante
        {
            get { return _brclass.AllowBandejaPorTipoDeComprobante; }
        }

        public string BandejaPorTipoDeComprobante
        {
            get
            {
                return _brclass.BandejaPorTipoDeComprobante;
            }
        }

        public bool BandejaPersonalizada
        {
            get { return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "BandejaPersonalizada"); }
        }

        public string Bandeja
        {
            get { return Variables.GetValueString(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "Bandeja"); }
        }
        //Fin German 20100713 - Tarea 793

	

		
		public bool AllowImpresoraPorTipoDeComprobante
		{
			get{return _brclass.AllowImpresoraPorTipoDeComprobante;}
		}

		public string ImpresoraPorTipoDeComprobante
		{
			get
			{
				return _brclass.ImpresoraPorTipoDeComprobante;
			}
		}
		
		public bool CustomPrinter
		{
			get{return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "UsaImpresoraPersonalizada");}
		}

		public string PrinterName
		{
			get{return Variables.GetValueString(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "NombreImpresora");}
		}

		public decimal Copies
		{
			get
			{
				decimal copies = Variables.GetValueDecimal(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "Copias");
				if(copies.Equals(decimal.MinValue))
					return 1;
				return copies;
			}
		}

		
		public bool PrintProgress
		{
			get{return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "MuestraProgresoImpresion");}
		}

		public bool AskPrint
		{
			get{return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "PreguntaImpresion");}
		}
		
		public bool Print
		{
			get
			{
				bool imprimeAuto = false;
				imprimeAuto = Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "ImpresionAutomatica");				
				if (imprimeAuto)
				{
					bool imprimeAuto2 = false;
					//Chequeo antes que el proceso actual determine la NO impresion del reporte					
					imprimeAuto2 = Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "RequiereValidarComprobantesPrevios");						

					if (imprimeAuto2 && ! _brclass.HasPrintExceptions) 
					{						
						bool imprime = false;
						string ListaComprobantesPreviosVar = Variables.GetValueString(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "ListaComprobantesPrevios");
						ArrayList listaVar= mz.erp.systemframework.Util.Parse(ListaComprobantesPreviosVar,",");
						foreach(object cpv in listaVar)
						{
							if (_brclass.TiposDeComprobantesPrevios.Contains(cpv))
							{
								imprime = true;
							}
						}															
						return imprime;						
					}
					else 
					{
						if ( _brclass.HasPrintExceptions)
							return false;
						else
							return true;
					}
				}				
				return imprimeAuto;
			}
		}

		public bool PrintSetup
		{
			get{return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "MuestraConfiguracionImpresora");}
		}
	
		public DataView  DataSource
		{
			get
			{
				return _brclass.DataSource;
			}
		}

		public string FileName
		{
			get
			{
				
				return _brclass.FileName;
			}
		}

		public ReportParameterCollection Parameters
		{
			get
			{
				return _brclass.Parameters;
			}
		}
	
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brclass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brclass.TextoBotonAnterior;
			}
		}

		#endregion
		
		#region Métodos  Públicos
		
		public string Empresa
		{
			get{ return _brclass.Empresa;}
		}
		public string DireccionEmpresa
		{
			get{ return _brclass.DireccionEmpresa;}
		}
		public string TelefonoEmpresa
		{
			get{ return _brclass.TelefonoEmpresa;}
		}
		public string Usuario
		{
			get{ return _brclass.Usuario;}
		}

		#endregion

		#region Métodos  Privados
		

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ValidBackState;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public string GetTaskName()
		{
			return _brclass.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brclass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brclass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _brclass.GetErrors();
		}

		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

		public void Execute()
		{
			this._brclass.Execute();
		}

		public bool AllowPrevious()
		{
			return _brclass.AllowPrevious();
		}

		public void Previous()
		{
			_brclass.Previous();
		}


		public bool AllowShow()
		{
			//return Variables.GetValueBool(_brclass.GetProcessManagerParent().Process.ProcessName, _brclass.GetTaskName(), "MuestraFormulario", true);
			return _brclass.AllowShow();
		}

		#endregion
	}
}
