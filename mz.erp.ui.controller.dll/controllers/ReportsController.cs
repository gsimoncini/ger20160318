using System;
using mz.erp.businessrules;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ReportsController.
	/// </summary>
	public class ReportsController:ITaskController
	{
		public ReportsController(ImprimirReporteComprobanteDeVenta imprimirReporteDeComprobante)
		{
			_imprimirReporteDeComprobante = imprimirReporteDeComprobante;	
			Init();
		}

		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData()
		{

		}

		private void InitEvents()
		{
			this._imprimirReporteDeComprobante.OnTaskAfterExecute +=new EventHandler(_imprimirReporteDeComprobante_OnTaskAfterExecute);
		}
		
		
		#region Variables Privadas
		
		private ImprimirReporteComprobanteDeVenta _imprimirReporteDeComprobante;

		#endregion

		#region Eventos

		public event EventHandler OnTaskAfterExecute;

		#endregion

		#region Propiedades

        //German 20100713 - Tarea 793
        public bool AllowBandejaPorTipoDeComprobante
        {
            get { return _imprimirReporteDeComprobante.AllowBandejaPorTipoDeComprobante; }
        }

        public string BandejaPorTipoDeComprobante
        {
            get
            {
                return _imprimirReporteDeComprobante.BandejaPorTipoDeComprobante;
            }
        }

        public bool BandejaPersonalizada
        {
            get { return Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "BandejaPersonalizada"); }
        }

        public string Bandeja
        {
            get { return Variables.GetValueString(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "Bandeja"); }
        }
        //Fin German 20100713 - Tarea 793


		public bool AllowImpresoraPorTipoDeComprobante
		{
			get{return _imprimirReporteDeComprobante.AllowImpresoraPorTipoDeComprobante;}
		}

		public string ImpresoraPorTipoDeComprobante
		{
			get
			{
				return _imprimirReporteDeComprobante.ImpresoraPorTipoDeComprobante;
			}
		}

		public bool CustomPrinter
		{
			get{return Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "UsaImpresoraPersonalizada");}
		}

		public string PrinterName
		{
			get{return Variables.GetValueString(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "NombreImpresora");}
		}

		public decimal Copies
		{
			get
			{
				decimal copies = Variables.GetValueDecimal(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "Copias");
				if(copies.Equals(decimal.MinValue))
					return 1;
				return copies;
			}
		}

		public bool PrintProgress
		{
			get{return Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "MuestraProgresoImpresion");}
		}

		public bool AskPrint
		{
			get{return Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "PreguntaImpresion");}
		}
		
		public bool Print
		{
			get
			{
				bool imprimeAuto = false;
				imprimeAuto = Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "ImpresionAutomatica");				
				/*
				if (imprimeAuto)
				{
					bool imprimeAuto2 = false;
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
				*/				
				return imprimeAuto;
			}
		}

		public bool PrintSetup
		{
			get{return Variables.GetValueBool(_imprimirReporteDeComprobante.GetProcessManagerParent().Process.ProcessName, _imprimirReporteDeComprobante.GetTaskName(), "MuestraConfiguracionImpresora");}
		}
	


		public DataTable DataSource
		{
			get
			{
				return _imprimirReporteDeComprobante.DataSource;
			}
		}

		public string FileName
		{
			get
			{
				
				return "ReportComprobantes" + _imprimirReporteDeComprobante.FamiliaDeComprobantes + ".rpx" ;			
			}
		}

		public ReportParameterCollection Parametros
		{
			get
			{
				return _imprimirReporteDeComprobante.Parametros;
			}
		}

		public string TextoBotonSiguiente
		{
			get 
			{
				return _imprimirReporteDeComprobante.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _imprimirReporteDeComprobante.TextoBotonAnterior;
			}
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


		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_imprimirReporteDeComprobante.GetTaskName());
		}

		public string GetTaskName()
		{
			return _imprimirReporteDeComprobante.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_imprimirReporteDeComprobante.GetTaskName());
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

		public bool AllowPrevious()
		{
			return _imprimirReporteDeComprobante.AllowPrevious();
		}

		public void Previous()
		{
			_imprimirReporteDeComprobante.Previous();
		}


		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			
			return _imprimirReporteDeComprobante.GetErrors();
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
			_imprimirReporteDeComprobante.Execute();
		}

		public bool AllowShow()
		{			
			return !(_imprimirReporteDeComprobante.SoportaComprobanteFiscal) && _imprimirReporteDeComprobante.AllowShow();		
		}

		#endregion

		private void _imprimirReporteDeComprobante_OnTaskAfterExecute(object sender, EventArgs e)
		{			
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
	}
}
