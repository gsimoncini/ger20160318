using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionReparacionAjustes.
	/// </summary>
	public class SeleccionReparacionAjustes:ITask
	{
		public SeleccionReparacionAjustes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables privadas
			
		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
		private string _idCuenta = string.Empty;
		private string _codigoCuenta = string.Empty;
		private string _idResponsable = Security.IdPersona;
		private string _familiaComprobantes = string.Empty;
		private string _idProveedor = string.Empty;
		private DataTable _tableEstadosFiltrados = new DataTable();
	
		private string _idEstadosPermitidos = string.Empty;
		private string _idEstado = string.Empty;
		private string _idOrdenReparacion = string.Empty;

		private ArrayList _tiposDeComprobantesOrigen = new ArrayList();
		private ArrayList _tiposDeComprobantesDestino = new ArrayList();
			
		private ArrayList _arrayIdComprobantesPendientes = new ArrayList();
		private RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;
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


		public string IdOrdenReparacion
		{
			get
			{
				return _idOrdenReparacion;
			}
			set
			{
				_idOrdenReparacion = value;
			}

			
		}

		public DataTable TableEstadosFiltrados
		{
			get
			{
				return _tableEstadosFiltrados;
			}
		}

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
		
		public RelacionesComprobanteOrigenDestino RelacionesComprobanteOrigenDestino
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
		
		public string CodigoCuenta
		{
			get
			{
				return _codigoCuenta;
			}
			set
			{
				if(value != _codigoCuenta)
				{
					_codigoCuenta = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);

				}
			}
		}
		
		public string IdCuenta
		{
			get
			{
				return _idCuenta;
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
		
		public string IdEstado
		{
			get
			{
				return _idEstado;
			}
			set
			{
				_idEstado = value;

			}
				
		}

		public string ProcesoEnEjecucion
		{
			get { return this.GetProcessManagerParent().Process.ProcessName; }
		}
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.ListenerAfterExecuteDependentTask
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;

			string processName = processManager.Process.ProcessName;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-7);
			long  cantDias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			this._fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
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
			this._idEstadosPermitidos = Variables.GetValueString("Momentos." + this._taskName + "." + processName+".EstadosOrdenDeReparacion");
			this._idEstado = Variables.GetValueString("Momentos." + this._taskName + "." + processName+".EstadoOrdenDeReparacion.Default");
			_tableEstadosFiltrados = mz.erp.businessrules.st_EstadoOrdenReparacion.GetList(this._idEstadosPermitidos).Tables[0];
			DataRow row = _tableEstadosFiltrados.NewRow();
			row["Descripcion"] = String.Empty;
			row["IdEstadoOrdenReparacion"] = 0;//Convert.ToInt32("-1");
			row["Codigo"] = String.Empty;
			_tableEstadosFiltrados.Rows.Add(row);
			ArrayList estados = mz.erp.systemframework.Util.Parse(this._idEstadosPermitidos,",");
		}

		public bool IsValid()
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.IsValid
			return true;
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


		public bool AllowShow()
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.AllowShow
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
			if(_arrayIdComprobantesPendientes.Count > 0)
				_idOrdenReparacion = Convert.ToString(_arrayIdComprobantesPendientes[0]);
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
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionReparacionesPendientes.ListenerBeforePreviousDependentTask
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
			

			ArrayList result = new ArrayList();
			string relacionComprobantesPrevios = Variables.GetValueString( "Momentos."+this.GetProcessManagerParent().Process.MainTask.KeyTask+".RelacionComprobantesPrevios" );
			string[] arelacionComprobantesPrevios = relacionComprobantesPrevios.Split( ',');
			if (arelacionComprobantesPrevios.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
				{
					string[] atupla = arelacionComprobantesPrevios[i].Split(':');
					if (atupla.Length == 2)
					{
						hash.Add( atupla[0],atupla[1]);
					}
				}
				foreach (string tipo in aComprobantesDeLaTarea)
				{
					if (hash.ContainsKey( tipo ))
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


		public DataTable RefreshData()
		{
			
			
			string _filtroEstados = string.Empty;
			if(_idEstado.Equals(string.Empty))
				_filtroEstados = _idEstadosPermitidos;
			else _filtroEstados = _idEstado;
			if(_processManager.Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST"))
				return mz.erp.businessrules.reportes.ReportsFactory.ReparacionesAjustarStockTransferencia(this._idOrdenReparacion,this._idCuenta,this._fechaDesde, this._fechaHasta,_filtroEstados);
			if(_processManager.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
				return mz.erp.businessrules.reportes.ReportsFactory.ReparacionesAjustarStockDevolucion(this._idOrdenReparacion,this._idCuenta,this._fechaDesde, this._fechaHasta,_filtroEstados);
			return null;


		}
		#endregion
        #region Métodos Públicos
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(_processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian
        #endregion
	}
}
