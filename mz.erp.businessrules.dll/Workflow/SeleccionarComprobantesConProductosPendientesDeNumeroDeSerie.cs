using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.
	/// </summary>
	public class SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie: ITask
	{
		#region Constructores
		
		public SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		#endregion

		#region Variables privadas

		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
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

		private ArrayList _productosPendientesDeNumeroDeSerie = new ArrayList();


		private string _estadosValidos = string.Empty;
		private string _tiposDeComprobantesValidos = string.Empty;

		#endregion

		#region Variables Publicas

		public ArrayList ProductosPendientesDeNumeroDeSerie
		{
			get{return _productosPendientesDeNumeroDeSerie;}
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
					GenerateItemsNroSerie();
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

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
			// TODO: agregar la implementación SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.ListenerAfterExecuteDependentTask
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.ListenerBeforeExecuteDependentTask
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
			this._fechaDesde = DateTime.Now.AddDays(-30);
			this._fechaHasta = DateTime.Now;
			_arrayIdComprobantesPendientes = new ArrayList();
			this._estadosValidos = Variables.GetValueString("Momentos." + this._taskName + "." + this._processManager.Process.ProcessName + ".EstadosDeStock");
			this._tiposDeComprobantesValidos = Variables.GetValueString("Momentos." + this._taskName + "." + this._processManager.Process.ProcessName + ".TiposDeComprobantes");

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
			// TODO: agregar la implementación SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Metodos Privados

		private void GenerateItemsNroSerie()
		{ 
			_productosPendientesDeNumeroDeSerie.Clear();
			foreach(string IdComprobante in _arrayIdComprobantesPendientes)
			{
				DataTable table = mz.erp.businessrules.tpu_ComprobantesMovimientosDeStock.GetProductosPendientesDeNumeroDeSerie(IdComprobante);
				foreach(DataRow row in table.Rows)
				{
					ProductoNumeroDeSerie p = new ProductoNumeroDeSerie();
					p.IdProducto = Convert.ToString(row["IdProducto"]);
					p.Codigo = Convert.ToString(row["Codigo"]);
					p.Descripcion = Convert.ToString(row["Descripcion"]);
					p.Cantidad = Convert.ToDecimal(row["cantNroSeriesPendientes"]);
					//p.IdMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
					_productosPendientesDeNumeroDeSerie.Add(p);

				}
			}
		}

		public DataTable RefreshData()
		{
			
		return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesConProductosPendientesDeNumeroDeSerie(this._fechaDesde, this._fechaHasta, this._tiposDeComprobantesValidos, this._estadosValidos);
		}

		#endregion
        #region Metodos públicos


        //Cristian Tsrea 0000050 20110721
        //Cristian Tsrea 0000146 20110310
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
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

	public class ProductoNumeroDeSerie
	{
		#region contructor
	

		public ProductoNumeroDeSerie()
		{
		}
		#endregion
		#region variables
		
		string _idProducto= string.Empty;
		string  _codigo = string.Empty;
		string _descripcion = string.Empty;
		string _idMovimientoDeStock = string.Empty;
		
		decimal _cantidad = 0;
		#endregion
		#region Set y Get

		public string IdMovimientoDeStock
		{
			get{return _idMovimientoDeStock;}
			set{_idMovimientoDeStock = value;}
		}
		public string IdProducto
		{
			set { _idProducto = value;}
			get { return _idProducto;}
		}
		public string  Codigo
		{
			set { _codigo = value;}
			get { return _codigo;}
		}
		public string Descripcion
		{
			set { _descripcion = value;}
			get { return _descripcion;}
		}
		
		public decimal Cantidad
		{
			get{return _cantidad;}
			set{_cantidad = value;}
		}
		#endregion
	}

}
