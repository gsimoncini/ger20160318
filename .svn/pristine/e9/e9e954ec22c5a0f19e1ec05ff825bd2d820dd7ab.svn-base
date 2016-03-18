using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ComprobantesDeCompraPendientes.
	/// </summary>
	public class ComprobantesDeCompraPendientes: ITask
	{
		public ComprobantesDeCompraPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables privadas
			
		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
		private string _idResponsable = Security.IdPersona;
		private string _familiaComprobantes = string.Empty;
		private string _idProveedor = string.Empty;

		private ArrayList _tiposDeComprobantesOrigen = new ArrayList();
		private ArrayList _tiposDeComprobantesDestino = new ArrayList();
			
		private ArrayList _arrayIdComprobantesPendientes = new ArrayList();
		private RelacionesComprobanteDeCompraOrigenDestino _relacionesComprobanteOrigenDestino;
		private ProcessManager _processManager;
		private string _taskName;
		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;
		private bool _hasShowSeleccionItems = false;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			

		#endregion

		#region Variables Publicas

		public bool HasShowSeleccionItems
		{
			set
			{
				_hasShowSeleccionItems = value;
			}
			get
			{
				return _hasShowSeleccionItems;
			}
		}
		
		public RelacionesComprobanteDeCompraOrigenDestino RelacionesComprobanteDeCompraOrigenDestino
		{
			get
			{
				return _relacionesComprobanteOrigenDestino;
			}
			set
			{
				if(_relacionesComprobanteOrigenDestino != value)
				{
					_relacionesComprobanteOrigenDestino = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		public ArrayList TiposDeComprobantesDestino
		{
			get
			{
				return _tiposDeComprobantesDestino;
			}
		}
		public ArrayList TiposDeComprobantesOrigen
		{
			get
			{
				return _tiposDeComprobantesOrigen;
			}
		}

		

		public ArrayList ArrayIdComporbantesPendientes
		{
			get
			{
				return _arrayIdComprobantesPendientes;
			}
			set
			{
				if(value != _arrayIdComprobantesPendientes)
				{
					_arrayIdComprobantesPendientes = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

			}

		}

		public string IdProveedor 
		{
			get
			{
				return _idProveedor;
			}
			set
			{
				_idProveedor = value;
			}
		}
		
		
		
		
		public string IdResponsable
		{
			get
			{
				return _idResponsable;
			}
			set
			{		
				_idResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _fechaDesde;
			}
			set
			{
				_fechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _fechaHasta;
			}
			set
			{
				_fechaHasta = value;
			}
		}

		public string FamiliaComprobantes
		{
			get
			{
				return _familiaComprobantes;
			}
			set
			{
				_familiaComprobantes = value;
			}
		}
		public string ProcesoEnEjecucion
		{
			get { return this.GetProcessManagerParent().Process.ProcessName; }
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
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
			this.AllowPrevious();
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
		
		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		
		

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientes.ListenerTaskDependentChanged
		}
		public void ListenerAfterExecuteDependentTask( object sender ){}
		public void ListenerBeforeExecuteDependentTask( object sender ){}

		public void Init()
		{
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			long dias = Variables.GetValueLong("Momentos." +  this._taskName + "." +_processManager.Process.ProcessName+ ".RangoFechas.DiasAnteriores");
			this.FechaDesde = DateTime.Now;
			if(!dias.Equals(long.MinValue))
				this._fechaDesde = DateTime.Now.AddDays(-dias);
			this._fechaHasta = DateTime.Now;
			string responsable = Variables.GetValueString("Momentos."+_idPrimaryTask+".ResponsableEmision");
			
			if ((responsable != null) && !(responsable.Equals(string.Empty)))
			{
				if (responsable.Equals("Todos")) { this._idResponsable = null ; }
				else 
				{
					if (responsable.Equals("Usuario")) { this._idResponsable = Security.IdPersona ; }
					else { this._idResponsable = responsable; }
				}
			}
			else
			{
				this._idResponsable = string.Empty;
			}
			
			this._idProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
			_arrayIdComprobantesPendientes = new ArrayList();
			this._tiposDeComprobantesOrigen = this.GetTiposDeComprobantesOrigen();
			this._tiposDeComprobantesDestino = this.GetTiposDeComprobantesDestinos();
			this._familiaComprobantes = this.ObtenerFamiliaComprobante(this._tiposDeComprobantesOrigen);

		}

		public bool IsValid()
		{
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

		#region Metodos Privados
		private string ObtenerFamiliaComprobante(ArrayList comprobantesorigen)
		{
			
			string family = string.Empty;
			sy_VariablesDataset  data = mz.erp.businessrules.sy_Variables.GetList("Comprobantes.TiposDeComprobantes.");
			System.Data.DataTable table = data.Tables[0];
			if (comprobantesorigen.Count != 0)
			{
				string IdTipoComprobante = Convert.ToString(comprobantesorigen[0]);
				foreach(System.Data.DataRow row in table.Rows)
				{
					ArrayList ar = mz.erp.systemframework.Util.Parse((string)row["ValorDefault"],",");
					if (ar.Contains(IdTipoComprobante))
					{
						bool ok= true;
						foreach(string tipodecomprobante in comprobantesorigen)
						{
							ok = ok && ar.Contains(tipodecomprobante);
						}	
						if(ok)
						{
							string [] partes = ((string)row["IdVariable"]).Split('.');
							family  = partes[partes.Length-1];
						}
						

					}
				}
			}			
			return family;
		}
		/// <summary>
		/// Devuelve una lista de los comprobantes previos definidos.
		/// La tabla de Tareas-Tipos De Comprboantes define todos los id de los tipos de comprobantes para la tarea determinada
		/// En caso de que para una tarea exista más un tipo de comprobante definido, se consulta en la variable
		/// Momentos.xx.RelacionComprobantesPrevios para filtrar solamente aquellos que estan definidos para el proceso.
		/// </summary>
		/// <returns></returns>
		private ArrayList GetTiposDeComprobantesOrigen()
		{
			ArrayList aComprobantesDeLaTarea = new ArrayList();

			System.Data.DataSet dataPreviousTasks = Workflow.GetPreviousTasksOfProcess(this._idPrimaryTask,this._idProcess);
			if(dataPreviousTasks.Tables.Count > 0)
			{
				if(dataPreviousTasks.Tables[0].Rows.Count > 0)
				{	
					foreach(System.Data.DataRow row in dataPreviousTasks.Tables[0].Rows)
					{
						long idPreviousTask =  Convert.ToInt32(row[0]);
						System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(idPreviousTask);
						foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
						{
							string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
							aComprobantesDeLaTarea.Add(IdTipoComprobante);
						}
					}
				}
			}
			//
			//
			//
			//Sabrina lo q vos decis esta aca
			//
			//
			//

			ArrayList result = new ArrayList();
			string relacionComprobantesPrevios = Variables.GetValueString( this.GetProcessManagerParent().Process.ProcessName, this.GetProcessManagerParent().Process.MainTask.KeyTask, "RelacionComprobantesPrevios");
			string[] arelacionComprobantesPrevios = relacionComprobantesPrevios.Split( ',');
			if (arelacionComprobantesPrevios.Length > 0)
			{
				ArrayList hash = new ArrayList();
				for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
				{
					string[] atupla = arelacionComprobantesPrevios[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!hash.Contains(atupla[0]))
							hash.Add( atupla[0]);
					}
				}
				foreach (string tipo in aComprobantesDeLaTarea)
				{
					if (hash.Contains ( tipo ))
					{
						result.Add( tipo );
					}
				}
				return result;
			}
			else
			{
				return result;
			}
			
			
		}

		private ArrayList GetTiposDeComprobantesDestinos()
		{
			ArrayList result = new ArrayList();
			System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(this._idPrimaryTask);
			foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
			{
				string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
				result.Add(IdTipoComprobante);


			}
			return result;
		}
		#endregion
	}
}
