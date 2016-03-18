using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de mzProductosSearchFormWorkflow.
	/// </summary>
	public class mzProductosSearchFormWorkflow: ITask
	{
		#region Constructores
		public mzProductosSearchFormWorkflow()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private string _orderBy = Variables.GetValueString("Productos.Busquedas.OrderBy");
		private string _idCondicionDeVentaVisualizacionPrecio = Variables.GetValueString("Productos.Buscador.Precio.CondicionDeVentaVisualizacion");
		private string _tiposDeComprobantes = string.Empty;
		private DataTable _result = new DataTable();
		#endregion

		#region Eventos
		#endregion

		#region Variables Públicas

		public DataTable Result
		{
			get
			{
				return _result;
			}
		}

		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		public DateTime FechaDesde
		{
			get { return _fechaDesde;}
			set { _fechaDesde = value;}
		}

		private DateTime _fechaHasta = DateTime.Now;
		public DateTime FechaHasta
		{
			get { return _fechaHasta;}
			set { _fechaHasta = value;}
		}

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

		private bool _byJerarquia1 = false;
		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}

		private bool _byJerarquia2 = false;
		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}

		private bool _byJerarquia3 = false;
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}

		private bool _byJerarquia4 = false;
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}

		private bool _byJerarquia5 = false;
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}

		private bool _byJerarquia6 = false;
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}

		private bool _byJerarquia7 = false;
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}

		private bool _byJerarquia8 = false;
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		private ArrayList _jerarquia1 = new ArrayList();
		public ArrayList Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}

		private ArrayList _jerarquia2 = new ArrayList();
		public ArrayList Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}

		private ArrayList _jerarquia3 = new ArrayList();
		public ArrayList Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}

		private ArrayList _jerarquia4 = new ArrayList();
		public ArrayList Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4 = value;}
		}

		private ArrayList _jerarquia5 = new ArrayList();		
		public ArrayList Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}

		private ArrayList _jerarquia6 = new ArrayList();
		public ArrayList Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}

		private ArrayList _jerarquia7 = new ArrayList();
		public ArrayList Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}

		private ArrayList _jerarquia8 = new ArrayList();
		public ArrayList Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}

		private string _codigo = String.Empty;
		public string Codigo
		{
			get { return _codigo;}
			set { _codigo = value;}
		}

		private string _codigoSecundario = String.Empty;
		public string CodigoSecundario
		{
			get { return _codigoSecundario;}
			set { _codigoSecundario = value;}
		}

		private string _descripcion = String.Empty;
		public string Descripcion
		{
			get { return _descripcion;}
			set { _descripcion = value;}
		}

		private string _descripcionCorta = String.Empty;
		public string DescripcionCorta
		{
			get { return _descripcionCorta;}
			set { _descripcionCorta = value;}
		}

		private string _descripcionLarga = String.Empty;
		public string DescripcionLarga
		{
			get { return _descripcionLarga;}
			set { _descripcionLarga = value;}
		}

		private bool _activo = false;
		public bool Activo
		{
			get{return _activo;}
			set{_activo = value;}
		}

		private bool _byActivo = false;
		public bool ByActivo
		{
			get{return _byActivo;}
			set{_byActivo = value;}
		}

		private string _idTipoProducto = String.Empty;
		public string IdTipoProducto
		{
			get { return _idTipoProducto;}
			set { _idTipoProducto = value;}
		}

		private string _observaciones = String.Empty;
		public string Observaciones
		{
			get { return _observaciones;}
			set { _observaciones = value;}
		}

		private string _campoAuxiliar1 = String.Empty;
		public string CampoAuxiliar1
		{
			get { return _campoAuxiliar1;}
			set { _campoAuxiliar1 = value;}
		}

		private string _campoAuxiliar2 = String.Empty;
		public string CampoAuxiliar2
		{
			get { return _campoAuxiliar2;}
			set { _campoAuxiliar2 = value;}
		}

		private string _campoAuxiliar3 = String.Empty;
		public string CampoAuxiliar3
		{
			get { return _campoAuxiliar3;}
			set { _campoAuxiliar3 = value;}
		}

		private string _campoAuxiliar4 = String.Empty;
		public string CampoAuxiliar4
		{
			get { return _campoAuxiliar4;}
			set { _campoAuxiliar4 = value;}
		}

		private string _campoAuxiliar5 = String.Empty;
		public string CampoAuxiliar5
		{
			get { return _campoAuxiliar5;}
			set { _campoAuxiliar5 = value;}
		}

		private string _idBonificacion = String.Empty;
		public string IdBonificacion
		{
			get { return _idBonificacion;}
			set { _idBonificacion = value;}
		}
		
		private bool _obligaCodigoBarra = false;
		public bool ObligaCodigoBarra
		{
			get{return _obligaCodigoBarra;}
			set{_obligaCodigoBarra = value;}
		}

		private bool _byObligaCodigoBarra = false;
		public bool ByObligaCodigoBarra
		{
			get{return _byObligaCodigoBarra;}
			set{_byObligaCodigoBarra = value;}
		}

		private bool _obligaNumeroSerie = false;
		public bool ObligaNumeroSerie
		{
			get{return _obligaNumeroSerie;}
			set{_obligaNumeroSerie = value;}
		}

		private bool _byObligaNumeroSerie = false;
		public bool ByObligaNumeroSerie
		{
			get{return _byObligaNumeroSerie;}
			set{_byObligaNumeroSerie = value;}
		}

		private bool _percibeIB = false;
		public bool PercibeIB
		{
			get{return _percibeIB;}
			set{_percibeIB = value;}
		}

		private bool _byPercibeIB = false;
		public bool ByPercibeIB
		{
			get{return _byPercibeIB;}
			set{_byPercibeIB = value;}
		}

		private DataTable _tiposProductos = null;
		public System.Data.DataTable TiposProductos
		{
			get {return _tiposProductos;}
		}

		public string KeyValueTiposProductos
		{
			get { return "IdTipoProducto" ; }
		}				
		public string KeyListTiposProductos
		{
			get { return "Descripcion" ; }
		}

		private DataTable _bonificaciones = null;
		public System.Data.DataTable Bonificaciones
		{
			get {return _bonificaciones;}
		}
		public string KeyValueBonificaciones
		{
			get { return "IdBonificacion" ; }
		}				
		public string KeyListBonificaciones
		{
			get { return "Descripcion" ; }
		}

		public string _idResponsable = string.Empty;
		public string IdResponsable
		{
			get{return _idResponsable;}
			set{_idResponsable=value;}
		}

		public DateTime _fechaAltaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaAltaDesde
		{
			get{return _fechaAltaDesde;}
			set{_fechaAltaDesde=value;}
		}

		public DateTime _fechaAltaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
		public DateTime FechaAltaHasta
		{
			get{return _fechaAltaHasta;}
			set{_fechaAltaHasta=value;}
		}

		private bool _buscarPorFechaAlta = false;
		public bool BuscarPorFechaAlta
		{
			get{return _buscarPorFechaAlta;}
			set{_buscarPorFechaAlta=value;}
		}

		public bool _buscarPorResponsable = false;
		public bool BuscarPorResponsable
		{
			get{return _buscarPorResponsable;}
			set{_buscarPorResponsable=value;}
		}

		#endregion

		#region Métodos Privados
		private string BuildJerarquia(ArrayList je)
		{
				
			ArrayList narray = new ArrayList();
			foreach (object item in je) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				narray.Add(it.NodeKey);				
			}
			return mz.erp.systemframework.Util.PackString(narray);
		}

		#endregion

		#region Métodos Públicos

		public void SearchNow()
		{
			string j1 = BuildJerarquia(_jerarquia1);
			string j2 = BuildJerarquia(_jerarquia2);
			string j3 = BuildJerarquia(_jerarquia3);
			string j4 = BuildJerarquia(_jerarquia4);
			string j5 = BuildJerarquia(_jerarquia5);
			string j6 = BuildJerarquia(_jerarquia6);
			string j7 = BuildJerarquia(_jerarquia7);
			string j8 = BuildJerarquia(_jerarquia8);

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			
			/**
			string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
			for(int i = 0; i<8;i++)
			{
				if(aux[i])
				{
					for(int j = 0; j<8; j++)
					{
						if(jers[j] == string.Empty)
						{
							jers[j] = jerarquias[i];
							break;
						}
					}
				}
			}
			*/

			j1 = jerarquias[0];
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];

			if (!_buscarPorResponsable)
				this.IdResponsable=string.Empty;

			if (!_buscarPorFechaAlta)
			{
				this.FechaAltaDesde=DateTime.MinValue;
				this.FechaAltaHasta=DateTime.MinValue;
			}

			if (this.GetTaskName().Equals("ConsultarProductosSinMovimientos"))
			{
				_result = mz.erp.businessrules.tsh_ProductosEx.SearchProductosSinMovimientos(_descripcion, _descripcionCorta, _descripcionLarga, j1,j2,j3,j4,j5,j6,j7,j8, Security.IdSucursal, Security.IdEmpresa, _idCondicionDeVentaVisualizacionPrecio, _fechaDesde, _fechaHasta, _tiposDeComprobantes);	
				_result = AddColumn.AddColumnToTable(_result, "Marca", false);
			}
			else
                _result = mz.erp.businessrules.tsh_ProductosEx.SearchProductos(_codigo, _codigoSecundario, _descripcion, _descripcionCorta, _descripcionLarga,  _activo, _byActivo, _idTipoProducto , _observaciones, _campoAuxiliar1, _campoAuxiliar2, _campoAuxiliar3, _campoAuxiliar4, _campoAuxiliar5,string.Empty, _idBonificacion, _obligaCodigoBarra, _byObligaCodigoBarra, _obligaNumeroSerie, _byObligaNumeroSerie,_percibeIB, _byPercibeIB,j1,j2,j3,j4,j5,j6,j7,j8, Security.IdSucursal, Security.IdEmpresa, _idCondicionDeVentaVisualizacionPrecio, _idResponsable, _fechaAltaDesde, _fechaAltaHasta);


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
			_tiposDeComprobantes = Variables.GetValueString(this._processParent.Process.ProcessName, GetTaskName(), "Buscador.TiposDeComprobantes");

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
