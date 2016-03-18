using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarFacturasImpagas.
	/// </summary>
	public class ConsultarFacturasImpagas : ITask
	{
        #region Constructores
		public ConsultarFacturasImpagas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private DataTable _result = new DataTable();
		private string _idCuenta;
		private string _tiposDeComprobantesEnBlanco;
		private string _tiposDeComprobantesDV;
		private string _todosLosTiposDeComprobantes;
		#endregion

		#region Eventos
		public event System.EventHandler DataChanged;
		#endregion

		#region Variables Públicas

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
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

		public DataTable Result
		{
			get{return _result;}
		}

		private string _codigoCuenta = String.Empty;
		public string CodigoCuenta
		{
			get{return _codigoCuenta;}
			set
			{				 
				if(_codigoCuenta != value)
				{
					_codigoCuenta = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);						
				}
			}
		}

		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set{_fechaDesde = value;}
		}

		private DateTime _fechaHasta = DateTime.Now;
		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
		}

		private bool _porFechaEmision = true;
		public bool PorFechaEmision
		{
			get{return _porFechaEmision ;}
			set{_porFechaEmision = value;}
		}

		private bool _porFechaVencimiento = false;
		public bool PorFechaVencimiento
		{
			get{return _porFechaVencimiento ;}
			set{_porFechaVencimiento = value;}
		}
		
		private int _periodos;
		public int Periodos
		{
			get{return _periodos ;}
			set{_periodos = value;}
		}

		private bool _periodosEnDias = true;
		public bool PeriodosEnDias
		{
			get{return _periodosEnDias ;}
			set{_periodosEnDias = value;}
		}
		
		private bool _periodosEnSemanas = false;
		public bool PeriodosEnSemanas
		{
			get{return _periodosEnSemanas ;}
			set{_periodosEnSemanas = value;}
		}
		
		private bool _periodosEnMeses = false;
		public bool PeriodosEnMeses
		{
			get{return _periodosEnMeses;}
			set{_periodosEnMeses = value;}
		}
		
		private bool _mostrarElResto = false;
		public bool MostrarElResto
		{
			get{return _mostrarElResto;}
			set{_mostrarElResto = value;}
		}
		
		private bool _periodosPorFechaEmision = true;
		public bool PeriodosPorFechaEmision
		{
			get{return _periodosPorFechaEmision ;}
			set{_periodosPorFechaEmision = value;}
		}

		private bool _periodosPorFechaVencimiento = false;
		public bool PeriodosPorFechaVencimiento
		{
			get{return _periodosPorFechaVencimiento ;}
			set{_periodosPorFechaVencimiento = value;}
		}
		#endregion

		#region Métodos Privados
		#endregion

		#region Métodos Públicos
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            long dias = Variables.GetValueLong(this.GetProcessManagerParent().Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            this.FechaDesde = fechaDesde;
            if (this.FechaHasta < fechaDesde)
            {
                _fechaHasta = Util.GenerateFechaHasta(fechaDesde, dias);
            }
        }
        //Fin Cristian
		public void RefreshData()
		{						
			DateTime DesdeEmision = (_porFechaEmision)? _fechaDesde: DateTime.MinValue;
			DateTime HastaEmision = (_porFechaEmision)? _fechaHasta: DateTime.MinValue;
			DateTime DesdeVencimiento = (_porFechaVencimiento) ? _fechaDesde : DateTime.MinValue;
			DateTime HastaVencimiento = (_porFechaVencimiento) ? _fechaHasta : DateTime.MinValue;
			
			string IdTiposComprobantes = string.Empty;
			switch(this.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoConsultarFacturasImpagas":
				{
                    IdTiposComprobantes = _tiposDeComprobantesEnBlanco;
                 }
					break;
				case "ProcesoConsultarFacturasImpagasDV":
				{
					IdTiposComprobantes = _tiposDeComprobantesDV;
				}
					break;
				case "ProcesoConsultarFacturasImpagasConsolidado":
				{
					IdTiposComprobantes = _todosLosTiposDeComprobantes;
				}
					break;
			}

			_result = tsa_FacturasImpagas.GetList(IdTiposComprobantes, _idCuenta, DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, PeriodosPorFechaEmision, Periodos, PeriodosEnDias, PeriodosEnSemanas, PeriodosEnMeses, MostrarElResto).Tables[1];
			if (this.DataChanged != null)
			{
				this.DataChanged(this, new System.EventArgs() );
			}
			
		}


		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;			
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			_tiposDeComprobantesEnBlanco = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteCliente.ListaTiposDeComprobantes.Facturas");
			_tiposDeComprobantesDV = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteClienteDV.ListaTiposDeComprobantes.Facturas");
			_todosLosTiposDeComprobantes = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteClienteConsolidada.ListaTiposDeComprobantes.Facturas");
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
			_errores.Clear();
			bool isvalid = true;
			return isvalid;
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
			return string.Empty;
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
			return this._taskName;
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

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion
	}
}
