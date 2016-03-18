using System;
using System.Data;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultaMovimientosStock.
	/// </summary>
	public class ConsultaMovimientosStock: ITask
	{
		
		
		#region Constructores
		
		public ConsultaMovimientosStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		#endregion

		#region Variables Privadas
		
		private string _idProducto = string.Empty;
		private string _codigo = string.Empty;
		private string _idjerarquia5 = string.Empty;
		private string _idjerarquia1 = string.Empty;
		private string _idjerarquia2 = string.Empty;
		private string _idjerarquia3 = string.Empty;
		private string _idjerarquia4 = string.Empty;
		private string _raizJerarquia1 = string.Empty;
		private string _raizJerarquia2 = string.Empty;
		private string _raizJerarquia3 = string.Empty;
		private string _raizJerarquia4 = string.Empty;
		private string _raizJerarquia5 = string.Empty;
		private string _DescripcionRaizJerarquia1 = string.Empty;
		private string _DescripcionRaizJerarquia2 = string.Empty;
		private string _DescripcionRaizJerarquia3 = string.Empty;
		private string _DescripcionRaizJerarquia4 = string.Empty;
		private string _DescripcionRaizJerarquia5 = string.Empty;
		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		private DateTime _fechaHasta = DateTime.Now;
		private DataTable _result = new DataTable();
		private bool _byHierarchy = false;
		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byFechas = false;
			


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


		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set
			{
				if(value != _byJerarquia1)
				{
					_byJerarquia1 = value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set
			{
				if(value != _byJerarquia2)
				{
					_byJerarquia2 = value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set
			{
				if(value != _byJerarquia3)
				{
					_byJerarquia3 = value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set
			{
				if(value != _byJerarquia4)
				{
					_byJerarquia4= value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set
			{
				if(value != _byJerarquia5)
				{
					_byJerarquia5 = value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public string DescripcionRaizJerarquia1
		{
			get{return _DescripcionRaizJerarquia1;}
		}

		public string DescripcionRaizJerarquia2
		{
			get{return _DescripcionRaizJerarquia2;}
		}

		public string DescripcionRaizJerarquia3
		{
			get{return _DescripcionRaizJerarquia3;}
		}

		public string DescripcionRaizJerarquia4
		{
			get{return _DescripcionRaizJerarquia4;}
		}

		public string DescripcionRaizJerarquia5
		{
			get{return _DescripcionRaizJerarquia5;}
		}


		
		public string RaizJerarquia1
		{
			get{return _raizJerarquia1;}
		}

		public string RaizJerarquia2
		{
			get{return _raizJerarquia2;}
		}

		public string RaizJerarquia3
		{
			get{return _raizJerarquia3;}
		}

		public string RaizJerarquia4
		{
			get{return _raizJerarquia4;}
		}

		public bool ByFechas
		{
			get{return _byFechas;}
			set
			{
				if(value != _byFechas)
				{
					_byFechas = value;
					if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public string RaizJerarquia5
		{
			get{return _raizJerarquia5;}
		}

		public bool ByHierarchy
		{
			set{_byHierarchy = value;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
			set{_idProducto = value;}
		}

		public string Codigo
		{
			get{return _codigo;}
			set
			{
				if(value !=  null && !value.Equals(string.Empty))
				{
					if(_codigo != value)
					{
						_codigo = value;
						_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigo);
					}
				}
				else
				{
					_codigo = value;
					_idProducto = string.Empty;
				}
			
			}
		}

		public string IdJerarquia5
		{
			get{return _idjerarquia5;}
			set{_idjerarquia5 = value;}
		}

		public string IdJerarquia1
		{
			get{return _idjerarquia1;}
			set{_idjerarquia1 = value;}
		}

		public string IdJerarquia2
		{
			get{return _idjerarquia2;}
			set{_idjerarquia2 = value;}
		}

		public string IdJerarquia3
		{
			get{return _idjerarquia3;}
			set{_idjerarquia3 = value;}
		}

		public string IdJerarquia4
		{
			get{return _idjerarquia4;}
			set{_idjerarquia4 = value;}
		}


		

		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set
			{
				if(_fechaDesde != value)
					_fechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set
			{
				if(_fechaHasta != value)
				_fechaHasta = value;
			}
		}

		

		public DataTable Result
		{
			get{return _result;}
		}


		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;


		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent = null;

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
			this._raizJerarquia1 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia1");
			if(!this._raizJerarquia1.Equals(string.Empty))
				this._DescripcionRaizJerarquia1 = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(this._raizJerarquia1).Descripcion;
			this._raizJerarquia2 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia2");
			if(!this._raizJerarquia2.Equals(string.Empty))
				this._DescripcionRaizJerarquia2 = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(this._raizJerarquia2).Descripcion;
			this._raizJerarquia3 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia3");
			if(!this._raizJerarquia3.Equals(string.Empty))
				this._DescripcionRaizJerarquia3 = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(this._raizJerarquia3).Descripcion;
			this._raizJerarquia4 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia4");
			if(!this._raizJerarquia4.Equals(string.Empty))
				this._DescripcionRaizJerarquia4 = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(this._raizJerarquia4).Descripcion;
			this._raizJerarquia5 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia5");
			if(!this._raizJerarquia5.Equals(string.Empty))
				this._DescripcionRaizJerarquia5 = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(this._raizJerarquia5).Descripcion;
			
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
			// TODO: agregar la implementación StockNDias.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación StockNDias.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Metodos publicos

		public void RefreshData()
		{
			if(!_byFechas)
			{
				_fechaDesde = DateTime.MinValue;
				_fechaHasta = DateTime.MinValue;
			}
			string j1 = _byJerarquia1?this.IdJerarquia1:null;
			string j2 = _byJerarquia2?this.IdJerarquia2:null;
			string j3 = _byJerarquia3?this.IdJerarquia3:null;
			string j4 = _byJerarquia4?this.IdJerarquia4:null;
			string j5 = _byJerarquia5?this.IdJerarquia5:null;
			_result = mz.erp.businessrules.Stock.GetMovimientosByIdProductoOrJerarquia(IdProducto,j1,j2,j3,j4,j5, _fechaDesde , _fechaHasta);
			
			
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		#endregion
	}
}
