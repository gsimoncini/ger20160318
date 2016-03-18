using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using ParaisoFiscal;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de FiscalCierre.
	/// </summary>
	public class FiscalSincronizacion: ITask
	{
		public FiscalSincronizacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public event System.EventHandler OnCloseFiscal;

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{				
				//ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				//LoadDataFromComprobanteDeVenta( _comprobante );
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			if (!(_impresionExitosa))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Impresora Fiscal","Sincronización","Ha ocurrido un error al intentar sincronizar"));
			}
			return IsValid;
		}
		public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());

			this.PrinterFiscal();
			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion
		
		#region Variables privadas
		private string _taskName = string.Empty;
		private bool _impresionExitosa = false;
		private char _tipo;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		
		private InterfaceFiscal _iFiscal;
	
		#endregion		

		private void PrinterFiscal()
		{
			_iFiscal = new InterfaceFiscal(this._processParent, this._taskName);
			_iFiscal.OnChangeEstadoFiscal += new EventHandler(this.ListenerChangesInterfaceFiscal);

			_impresionExitosa = _iFiscal.Sincronizacion();			

			/*if (_impresionExitosa) 
			{
				ReporteFiscal reporte = _iFiscal.ReporteFiscal;			
				Console.WriteLine(reporte.NroReporte);							
			}*/
		}

		private string _mensaje = "";
		public string Mensaje 
		{
			get {return _mensaje;	}
		}
		
		private bool _cierreAutomatico = true;//Variables.GetValueBool("Fiscal.CierreAutomatico");		
		public bool CierreAutomatico
		{
			get {return _cierreAutomatico;}			
		}

        /* Silvina 20111025 - Tarea 0000221 */
        public bool EFacturaHabilitada
        {
            get { return false; }
        }

        private bool _eFacturaGenerar = false;
        public bool EFacturaGenerar
        {
            set { _eFacturaGenerar = value; }
            get { return false; }
        }
        /* Fin Silvina 20111025 - Tarea 0000221 */

		private void ListenerChangesInterfaceFiscal( object sender, System.EventArgs e )
		{
			_mensaje = _iFiscal.Mensaje;
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

	}
}


