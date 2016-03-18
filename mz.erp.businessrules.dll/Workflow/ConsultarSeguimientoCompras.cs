using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarSeguimientoCompras.
	/// </summary>
	public class ConsultarSeguimientoCompras : ITask
	{
		#region Constructores
		public ConsultarSeguimientoCompras()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

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
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}




		public void Init()
		{			
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			_allowShowDetail = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "VisualizaDetalleComprobantes");
			_showDetailBy = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "MetodoVisualizacionDetalle");			

		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
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
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
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

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processManager;	

		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;

		private bool _allowShowDetail = false;
		private string _showDetailBy = string.Empty;
		#endregion

		#region Propiedades

		private DataTable _result = new DataTable();	
		public DataTable Result
		{
			get{return _result;}
		}

		private string _idProveedor = string.Empty;
		/*public string IdProveedor
		{
			get{return _idProveedor;}
			set
			{				 
				if(_idProveedor != value)
				{
					_idProveedor = value;						
				}
			}
		}*/

		private string _codigoProveedor = "";
		public string CodigoProveedor
		{
			get{return _codigoProveedor;}
			set
			{
				_codigoProveedor = value;
				Proveedor proveedor = new Proveedor();
				proveedor.GetCuenta_CodigoProveedor(_codigoProveedor);
				if (!value.Equals(string.Empty))
					_idProveedor = proveedor.IdProveedor;
				else
					_idProveedor=string.Empty;				
			}
		}


		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set
			{				 
				if(_fechaDesde != value)
				{
					_fechaDesde = value;						
				}
			}
		}

		private DateTime _fechaHasta = DateTime.Now;
		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set
			{				 
				if(_fechaHasta != value)
				{
					_fechaHasta = value;						
				}
			}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonAnterior");
				if (valor == String.Empty)
				{
					 
					valor = Variables.GetValueString("Sistema.Interfaz.TextoBotonAnterior");				
				}
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonSiguiente");
				if (valor == String.Empty)
				{
					
					valor = Variables.GetValueString("Sistema.Interfaz.TextoBotonSiguiente");				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _leyendaFormulario = string.Empty;
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
				if (valor == String.Empty) 
				{
					return this._taskName;
				}
				else 
				{
					return valor;
				}
			}
		}
		
		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		#endregion

		#region Eventos

		#endregion

		#region Metodos Privados

		#endregion

		#region Metodos Publicos
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            long dias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            this._fechaDesde = fechaDesde;
            if (this.FechaHasta < fechaDesde)
            {
                _fechaHasta = mz.erp.systemframework.Util.GenerateFechaHasta(fechaDesde, dias);
            }
        }
        //Fin Cristian	
		public void RefreshData()
		{
			bool verHTML = false;
			if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
				verHTML = true;
			System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompraPendientes( _idProveedor,_fechaDesde, _fechaHasta, Security.IdSucursal, Security.IdEmpresa, verHTML);
			_result = data.Tables[0];
		}
		public void ResetFechas()
		{
			_fechaDesde = DateTime.Now.AddDays(-30);
			_fechaHasta = DateTime.Now;
		}
		#endregion

	}
}
