using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarEstadisticaOrdenReparacion.
	/// </summary>
	public class ConsultarEstadisticaOrdenReparacion: ITask
	{
		#region Constructores

		public ConsultarEstadisticaOrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

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
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			_estadosOrdenReparacion = mz.erp.businessrules.st_EstadoOrdenReparacion.GetList().Tables[0];
			DataRow row = _estadosOrdenReparacion.NewRow();
			row["IdEstadoOrdenReparacion"]= long.MinValue;
			row["Codigo"]= string.Empty;
			row["Descripcion"]= "Todos";
			row["FechaCreacion"]= DateTime.Now;
			row["ValorPorDefecto"]= 0;
			_estadosOrdenReparacion.Rows.Add(row);

			st_TecnicoDataset.st_TecnicoDataTable tecnicosEnBD = st_Tecnico.GetList("S").st_Tecnico;
			foreach(st_TecnicoDataset.st_TecnicoRow rowTecnico in tecnicosEnBD.Rows)
			{
				long IdTecnico = rowTecnico.IdTecnico;
				string Codigo = rowTecnico.Codigo;
				string Habilitado = rowTecnico.Habilitado;
				string IdPersona = rowTecnico.IdPersona;
				Tecnico tecnico = new Tecnico(IdTecnico, Codigo, Habilitado, IdPersona);
				_tecnicos.Add(tecnico);
			}

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
			//ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
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

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private DataTable _result = new DataTable();	
		#endregion

		#region Eventos y Delegados
		public event System.EventHandler DataChanged;
		#endregion

		#region Propiedades
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

		private string _leyendaFormulario = "Configuración de Menues";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
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
		public DataTable Result
		{
			get{return _result;}
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

		private bool _porFechaAltaOrdenReparacion = true;
		public bool PorFechaAltaOrdenReparacion
		{
			get{return _porFechaAltaOrdenReparacion;}
			set{_porFechaAltaOrdenReparacion = value;}
		}

		private bool _porFechaAsignacionATecnico = false;
		public bool PorFechaAsignacionATecnico
		{
			get{return _porFechaAsignacionATecnico;}
			set{_porFechaAsignacionATecnico = value;}
		}

		private bool _porFechaFactura = false;
		public bool PorFechaFactura
		{
			get{return _porFechaFactura;}
			set{_porFechaFactura = value;}
		}

		private bool _porFechaCierre = false;
		public bool PorFechaCierre
		{
			get{return _porFechaCierre;}
			set{_porFechaCierre = value;}
		}

		private bool _porFechaCierreTecnico = false;
		public bool PorFechaCierreTecnico
		{
			get{return _porFechaCierreTecnico;}
			set{_porFechaCierreTecnico = value;}
		}

		private decimal _totalTecnicoProvisorio;
		public decimal TotalTecnicoProvisorio
		{
			get{return _totalTecnicoProvisorio;}
			set{_totalTecnicoProvisorio = value;}
		}

		private decimal _totalCerrado;
		public decimal TotalCerrado
		{
			get{return _totalCerrado;}
			set{_totalCerrado = value;}
		}

		private decimal _totalPorCerrar;
		public decimal TotalPorCerrar
		{
			get{return _totalPorCerrar;}
			set{_totalPorCerrar = value;}
		}

		private DataTable _estadosOrdenReparacion;
		public DataTable EstadosOrdenReparacion
		{
			get {return _estadosOrdenReparacion;}
		}

		private long _idEstadoOrdenReparacion = long.MinValue;
		public long IdEstadoOrdenReparacion
		{
			get{return _idEstadoOrdenReparacion;}
			set
			{				 
				if(_idEstadoOrdenReparacion != value)
				{
					_idEstadoOrdenReparacion = value;						
				}
			}
		}

		public bool EsSupervisorST
		{
			get 
			{		
				return Security.IdPerfil.Equals(Convert.ToInt64(14));
			}
		}

		private ArrayList _tecnicos = new ArrayList();
		public ArrayList Tecnicos
		{
			get {return _tecnicos;}
		}

		private string _idTecnicosSelecionados = string.Empty;
		public string IdTecnicosSelecionados
		{
			get{return _idTecnicosSelecionados;}
			set{_idTecnicosSelecionados = value;}
		}


		#endregion

		#region Métodos públicos
		public void RefreshData()
		{
			string IdPersonaLogueada = Security.IdPersona;
			if(EsSupervisorST)
				IdPersonaLogueada = string.Empty;
			_result = st_EstadisticaOrdenReparacion.ListarDetalleTecnico(_fechaDesde, _fechaHasta, _porFechaAltaOrdenReparacion, _porFechaAsignacionATecnico, _porFechaFactura, _porFechaCierre, _porFechaCierreTecnico, IdPersonaLogueada, _idEstadoOrdenReparacion, _idTecnicosSelecionados).Tables[0];
			_totalTecnicoProvisorio = 0;
			_totalCerrado = 0;
			_totalPorCerrar = 0;
			
			/** Para los estilos de la grilla*/
			DataColumn col1 = new DataColumn("BackColorRojo", typeof(int) );
			_result.Columns.Add(col1);

			foreach(DataRow row in _result.Rows)
			{   
				bool Cerrado = Convert.ToBoolean(row["Cerrado"]);
				decimal ValorTecnicoProvisorio = Convert.ToInt32(row["ValorTecnicoProvisorio"]);
				_totalTecnicoProvisorio = _totalTecnicoProvisorio + ValorTecnicoProvisorio;
				if(Cerrado)
					_totalCerrado = _totalCerrado + ValorTecnicoProvisorio;
				else
					_totalPorCerrar = _totalPorCerrar + ValorTecnicoProvisorio;

				decimal TiempoTecnico = 0;
				if(row["TiempoTecnico"] != null && row["TiempoTecnico"] != System.DBNull.Value)
					TiempoTecnico = Convert.ToDecimal(row["TiempoTecnico"]);
				decimal TiempoTarea = 0;
				if(row["TiempoTarea"] != null && row["TiempoTarea"] != System.DBNull.Value)
					TiempoTarea = Convert.ToDecimal(row["TiempoTarea"]);

				if(TiempoTecnico > TiempoTarea)
					row["BackColorRojo"] = Convert.ToInt32(1);
				else
					row["BackColorRojo"] = Convert.ToInt32(0);

			}

			if (this.DataChanged != null)
			{
				this.DataChanged(this, new System.EventArgs() );
			}

		}

		#endregion

		#region Métodos Privados

		#endregion

	}

	public class Tecnico 
	{
		#region Constructores
		public Tecnico(long IdTecnico, string Codigo, string Habilitado, string IdPersona)
		{		
			_idTecnico = IdTecnico;
			_codigo = Codigo;
			_habilitado = Habilitado;
			_idPersona = IdPersona;
		}
		#endregion

		#region Propiedades
		private long _idTecnico;
		public long IdTecnico 
		{
			get {return _idTecnico;}
		}

		private string _codigo;
		public string Codigo 
		{
			get {return _codigo;}
		}

		private string _habilitado;
		public string Habilitado 
		{
			get {return _habilitado;}
		}

		private string _idPersona;
		public string IdPersona 
		{
			get {return _idPersona;}
		}
		#endregion

		#region Metodos Publicos
		#endregion

		public override String ToString()
		{
			string str = _codigo;
			return str;
		}


	}

}
