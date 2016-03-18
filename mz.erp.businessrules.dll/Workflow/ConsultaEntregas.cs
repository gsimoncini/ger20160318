using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultaEntregas.
	/// </summary>
	public class ConsultaEntregas : ITask
	{
		public ConsultaEntregas()
		{
		}

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
			_allowMultipleSelect = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowMultipleSelect");			
			_listaFiltros = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaFiltros");
            _listaFiltrosSecundarios = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaFiltrosSecundarios");
			ArrayList arrFiltros = systemframework.Util.Parse(_listaFiltros);
			_allowSearchByNumero = arrFiltros.Contains("Numero");

			long  cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
			{
				/** OJO NO RESTA BIEN*/
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
				_fechaConvDesde = _fechaDesde;
				_fechaVtoDesde = _fechaDesde;
			}
			_fechaDesdeDefault = _fechaDesde;
			_fechaHastaDefault = _fechaHasta;
			_numeroDesde = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Numero.Default");			
			_numeroHasta = _numeroDesde;

			_allowGeneralSearch = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowGeneralSearch");		
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
			if(_processParent.Process.ProcessName.Equals("ProcesoValorizarStock"))
				return "Desea guardar La Valorización de Stock Actual?";
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
		private string _idProducto = string.Empty;
		private string _codigoProducto = string.Empty;
		private string _idCuenta = string.Empty;		
		private string _codigoCuenta = String.Empty;
		private string _responsableEmision = String.Empty;
		private string _familiaComprobantes = String.Empty;

		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		private DateTime _fechaHasta = DateTime.Now;
		private DateTime _fechaDesdeDefault;
		private DateTime _fechaHastaDefault;

		private DateTime _fechaConvDesde = DateTime.Now.AddDays(-30);
		private DateTime _fechaConvHasta = DateTime.Now;

		private DateTime _fechaVtoDesde = DateTime.Now.AddDays(-30);
		private DateTime _fechaVtoHasta = DateTime.Now;


		
		
		private string _numeroDesde = "";
		private string _numeroHasta = "";


		private bool _allowMultipleSelect = false;
		private bool _allowSearchByNumero = false;		
		
		private ArrayList _jerarquias1 = new ArrayList();
		private ArrayList _jerarquias2 = new ArrayList();
		private ArrayList _jerarquias3 = new ArrayList();
		private ArrayList _jerarquias4 = new ArrayList();
		private ArrayList _jerarquias5 = new ArrayList();
		private ArrayList _jerarquias6 = new ArrayList();
		private ArrayList _jerarquias7 = new ArrayList();
		private ArrayList _jerarquias8 = new ArrayList();
		private ArrayList _jerarquias9 = new ArrayList();
		private ArrayList _jerarquias10 = new ArrayList();
		private ArrayList _jerarquias11 = new ArrayList();
		private ArrayList _jerarquias12 = new ArrayList();
		private ArrayList _jerarquias13 = new ArrayList();
		private ArrayList _jerarquias14 = new ArrayList();
		private ArrayList _jerarquias15 = new ArrayList();		
		private ArrayList _jerarquias16 = new ArrayList();

		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byJerarquia6 = false;
		private bool _byJerarquia7 = false;
		private bool _byJerarquia8 = false;
		private bool _byJerarquia9 = false;
		private bool _byJerarquia10 = false;
		private bool _byJerarquia11 = false;
		private bool _byJerarquia12 = false;
		private bool _byJerarquia13 = false;
		private bool _byJerarquia14 = false;
		private bool _byJerarquia15 = false;
		private bool _byJerarquia16 = false;
		private bool _byFechas = true;
		
		#endregion

		#region Propiedades


		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}

		public bool AllowSearchByNumero
		{
			get{return _allowSearchByNumero;}
		}

		private bool _filterByNumero = false;
		public bool FilterByNumero
		{
			get{return _filterByNumero;}
			set{_filterByNumero = value;}
		}

		private bool _filterByFecha = false;
		public bool FilterByFecha
		{
			get{return _filterByFecha;}
			set{_filterByFecha = value;}
		}

		private bool _filterByFechaConv = false;
		public bool FilterByFechaConv
		{
			get{return _filterByFechaConv;}
			set{_filterByFechaConv = value;}
		}
		
		private bool _filterByFechaVto = false;
		public bool FilterByFechaVto
		{
			get{return _filterByFechaVto;}
			set{_filterByFechaVto = value;}
		}
		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}
		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		public bool ByJerarquia9
		{
			get{return _byJerarquia9;}
			set{_byJerarquia9 = value;}
		}		
		public bool ByJerarquia10
		{
			get{return _byJerarquia10;}
			set{_byJerarquia10 = value;}
		}
		public bool ByJerarquia11
		{
			get{return _byJerarquia11;}
			set{_byJerarquia11 = value;}
		}
		public bool ByJerarquia12
		{
			get{return _byJerarquia12;}
			set{_byJerarquia12 = value;}
		}
		public bool ByJerarquia13
		{
			get{return _byJerarquia13;}
			set{_byJerarquia13 = value;}
		}
		public bool ByJerarquia14
		{
			get{return _byJerarquia14;}
			set{_byJerarquia14 = value;}
		}
		public bool ByJerarquia15
		{
			get{return _byJerarquia15;}
			set{_byJerarquia15 = value;}
		}
		public bool ByJerarquia16
		{
			get{return _byJerarquia16;}
			set{_byJerarquia16 = value;}
		}

		
		public ArrayList  Jerarquias9
		{
			get{return _jerarquias9;}
			set{_jerarquias9 = value;}
		}

		public ArrayList  Jerarquias10
		{
			get{return _jerarquias10;}
			set{_jerarquias10 = value;}
		}

		public ArrayList  Jerarquias11
		{
			get{return _jerarquias11;}
			set{_jerarquias11 = value;}
		}

		public ArrayList  Jerarquias12
		{
			get{return _jerarquias12;}
			set{_jerarquias12 = value;}
		}

		public ArrayList  Jerarquias13
		{
			get{return _jerarquias13;}
			set{_jerarquias13 = value;}
		}

		public ArrayList  Jerarquias14
		{
			get{return _jerarquias14;}
			set{_jerarquias14 = value;}
		}

		public ArrayList  Jerarquias15
		{
			get{return _jerarquias15;}
			set{_jerarquias15 = value;}
		}

		public ArrayList  Jerarquias16
		{
			get{return _jerarquias16;}
			set{_jerarquias16 = value;}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				valor = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(),"TextoBotonAnterior");
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
				valor = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(),"TextoBotonSiguiente");
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
				valor = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
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

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		public DataTable Result
		{
			get{return _result;}
		}

	
		public string CodigoProducto
		{
			get{return _codigoProducto;}
			set
			{
				if(_codigoProducto != value)
				{
					_codigoProducto = value;
					_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigoProducto);
				}
			}
		}

		public string CodigoCuenta
		{
			get{return _codigoCuenta;}
			set
			{				 
				if(_codigoCuenta != value)
				{
					_codigoCuenta = value;
					if (_codigoCuenta.Equals(string.Empty))
						_idCuenta=string.Empty;
					else
                        _idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);						
				}
			}
		}

		public string ResponsableEmision
		{
			get{return _responsableEmision;}
			set
			{				 
				if(_responsableEmision != value)
				{
					_responsableEmision = value;						
				}
			}
		}
		
		public string FamiliaComprobantes
		{
			get{return _familiaComprobantes;}
			set
			{				 
				if(value !=  null && !value.Equals(string.Empty))
				{
					if(_familiaComprobantes != value)
					{
						_familiaComprobantes = value;						
					}
				}
			}
		}

		private string _listaFamiliaDeComprobantesEntregas = Variables.GetValueString("Comprobantes.FamiliasDeComprobantesEntregas");
		private string _familiaDefault = "";

		public string ListaFamiliaDeComprobantesEntregas 
		{
			get {return _listaFamiliaDeComprobantesEntregas;}
		}
		public string FamiliaDefault 
		{
			get 
			{
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(), "FamiliaComprobantes");
				return valor.Trim();
			}
		}
		
		public ArrayList  Jerarquias1
		{
			get{return _jerarquias1;}
			set{_jerarquias1 = value;}
		}
		public ArrayList  Jerarquias2
		{
			get{return _jerarquias2;}
			set{_jerarquias2 = value;}
		}

		public ArrayList  Jerarquias3
		{
			get{return _jerarquias3;}
			set{_jerarquias3 = value;}
		}

		public ArrayList  Jerarquias4
		{
			get{return _jerarquias4;}
			set{_jerarquias4 = value;}
		}

		public ArrayList  Jerarquias5
		{
			get{return _jerarquias5;}
			set{_jerarquias5 = value;}
		}

		public ArrayList  Jerarquias6
		{
			get{return _jerarquias6;}
			set{_jerarquias6 = value;}
		}

		public ArrayList  Jerarquias7
		{
			get{return _jerarquias7;}
			set{_jerarquias7 = value;}
		}

		public ArrayList  Jerarquias8
		{
			get{return _jerarquias8;}
			set{_jerarquias8 = value;}
		}

		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set{_fechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
		}


		public DateTime FechaDesdeDefault
		{
			get{return _fechaDesdeDefault;}			
		}

		public DateTime FechaHastaDefault
		{
			get{return _fechaHastaDefault;}		
		}

		public DateTime FechaConvDesde
		{
			get{return _fechaConvDesde;}
			set{_fechaConvDesde = value;}
		}

		public DateTime FechaConvHasta
		{
			get{return _fechaConvHasta;}
			set{_fechaConvHasta = value;}
		}

		public DateTime FechaVtoDesde
		{
			get{return _fechaVtoDesde;}
			set{_fechaVtoDesde = value;}
		}

		public DateTime FechaVtoHasta
		{
			get{return _fechaVtoHasta;}
			set{_fechaVtoHasta = value;}
		}
		
		public string NumeroDesde
		{
			get{return _numeroDesde;}
			set{_numeroDesde = value;}
		}

		public string NumeroHasta
		{
			get{return _numeroHasta;}
			set{_numeroHasta = value;}
		}

		private bool _allowGeneralSearch = false;
		public bool AllowGeneralSearch 
		{
			get{return _allowGeneralSearch;}
		}

		
		private string _listaFiltros = "";
		public string ListaFiltros 
		{
			get{return _listaFiltros;}
		}

		private string _listaFiltrosSecundarios = "";
		public string ListaFiltrosSecundarios 
		{
			get{return _listaFiltrosSecundarios;}
		}

		private string _observaciones = "";
		public string Observaciones 
		{
			get{return _observaciones;}
			set{_observaciones = value;}
		}

		private string _campoAuxiliar1 = "";
		public string CampoAuxiliar1 
		{
			get{return _campoAuxiliar1;}
			set{_campoAuxiliar1 = value;}
		}

		private string _campoAuxiliar2 = "";
		public string CampoAuxiliar2 
		{
			get{return _campoAuxiliar2;}
			set{_campoAuxiliar2 = value;}
		}
		
		private string _campoAuxiliar3 = "";
		public string CampoAuxiliar3 
		{
			get{return _campoAuxiliar3;}
			set{_campoAuxiliar3 = value;}
		}
		
		private string _campoAuxiliar4 = "";
		public string CampoAuxiliar4 
		{
			get{return _campoAuxiliar4;}
			set{_campoAuxiliar4 = value;}
		}
		
		private string _campoAuxiliar5 = "";
		public string CampoAuxiliar5 
		{
			get{return _campoAuxiliar5;}
			set{_campoAuxiliar5 = value;}
		}

		private bool _pendientes = false;
		public bool Pendientes 
		{
			get{return _pendientes;}
			set{_pendientes = value;}
		}

		#endregion

		public void RefreshData()
		{						
			
			/*Esto depende de cada Tarea - Big Case*/
			string j1 = BuildJerarquia(_jerarquias1);
			string j2 = BuildJerarquia(_jerarquias2);
			string j3 = BuildJerarquia(_jerarquias3);
			string j4 = BuildJerarquia(_jerarquias4);
			string j5 = BuildJerarquia(_jerarquias5);
			string j6 = BuildJerarquia(_jerarquias6);
			string j7 = BuildJerarquia(_jerarquias7);
			string j8 = BuildJerarquia(_jerarquias8);
			string j9 = BuildJerarquia(_jerarquias9);
			string j10 = BuildJerarquia(_jerarquias10);
			string j11 = BuildJerarquia(_jerarquias11);
			string j12 = BuildJerarquia(_jerarquias12);
			string j13 = BuildJerarquia(_jerarquias13);
			string j14 = BuildJerarquia(_jerarquias14);
			string j15 = BuildJerarquia(_jerarquias15);
			string j16 = BuildJerarquia(_jerarquias16);

			bool[] aux = new bool[16]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8, _byJerarquia9, _byJerarquia10, _byJerarquia11, _byJerarquia12, _byJerarquia13, _byJerarquia14, _byJerarquia15, _byJerarquia16};
			string[] jerarquias = new string[16]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty,_byJerarquia9?j9:string.Empty,_byJerarquia10?j10:string.Empty,_byJerarquia11?j11:string.Empty,_byJerarquia12?j12:string.Empty,_byJerarquia13?j13:string.Empty,_byJerarquia14?j14:string.Empty,_byJerarquia15?j15:string.Empty,_byJerarquia16?j16:string.Empty };

			//bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			//string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			/*
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
			j9 = jerarquias[8];
			j10 = jerarquias[9];
			j11 = jerarquias[10];
			j12 = jerarquias[11];
			j13 = jerarquias[12];
			j14 = jerarquias[13];
			j15 = jerarquias[14];
			j16 = jerarquias[15];

			DateTime FechaEmisionDesde = _filterByFecha ? this.FechaDesde : DateTime.MinValue;
			DateTime FechaEmisionHasta = _filterByFecha ? this.FechaHasta : DateTime.MinValue;
			DateTime FechaConvDesde = _filterByFechaConv ? this.FechaConvDesde : DateTime.MinValue;
			DateTime FechaConvHasta = _filterByFechaConv ? this.FechaConvHasta : DateTime.MinValue;
			DateTime FechaVtoDesde = _filterByFechaVto ? this.FechaVtoDesde : DateTime.MinValue;
			DateTime FechaVtoHasta = _filterByFechaVto ? this.FechaVtoHasta : DateTime.MinValue;

			_numeroDesde = _allowSearchByNumero ? _numeroDesde : string.Empty;
			_numeroHasta = _allowSearchByNumero ? _numeroHasta : string.Empty;
			
			string TiposDeComprobantes = "";

			if (_familiaComprobantes !="")
				if (_familiaComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantesEntrega");
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+_familiaComprobantes);



			if (_allowSearchByNumero == false || _filterByNumero == false)
			{
				_numeroDesde = "";
				_numeroHasta = "";
			}

			switch (this._taskName)
			{
				case "ConsultarDetalleComprobantesEntregas":
				{
					_result = mz.erp.businessrules.reportes.tlg_ReporteDetalleComprobantesDeEntrega.GetList( _idCuenta, FechaEmisionDesde, FechaEmisionHasta, FechaConvDesde, FechaConvHasta,FechaVtoDesde, FechaVtoHasta,_responsableEmision, TiposDeComprobantes,_idProducto, j1, j2, j3, j4, j5, j6, j7, j8, _numeroDesde, _numeroHasta, Observaciones, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5).Tables[0];
					break;
				}

				case "ConsultarEntrega":
				{
					switch (this._processParent.Process.ProcessName)
					{
						// tarea 2.1 --> ProcesoEntregasConsultaOrdenesPendientes
						case "ProcesoEntregasConsultaOrdenesPendientes":
						{
							string _listaTiposDeComprobantesExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesExcluidos");
							string _tiposComprobantesOrigen = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesOrigen");
							/*borrar --> */string _tiposComprobantesDestino = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesDestino");
							_result = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesEntregasWF( _tiposComprobantesOrigen, _tiposComprobantesOrigen, this._idCuenta, this._fechaVtoDesde, this._fechaVtoHasta,  this._responsableEmision, Security.IdSucursal, Security.IdEmpresa, false, this._pendientes,_listaTiposDeComprobantesExcluidos, j9, j10, j11, j12, j13, j14, j15, j16).Tables[0];
							break;							
						}
						// tarea 2.2 --> ProcesoEntregasConsultaEntregaDeposito
						case "ProcesoEntregasConsultaEntregaDeposito":
						{
							/*borrar --> */string _listaTiposDeComprobantesExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesExcluidos");
							string _tiposComprobantesOrigen = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesOrigen");
							/*borrar --> */string _tiposComprobantesDestino = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesDestino");
							_result = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesEntregasWF( _tiposComprobantesOrigen, _tiposComprobantesOrigen, this._idCuenta, this._fechaVtoDesde, this._fechaVtoHasta,  this._responsableEmision, Security.IdSucursal, Security.IdEmpresa, false, this._pendientes,_listaTiposDeComprobantesExcluidos, j9, j10, j11, j12, j13, j14, j15, j16).Tables[0];
							break;
						}
						// tarea 2.3 --> ProcesoEntregasConsultarArticulosPendienteDePreparacion
						case "ProcesoEntregasConsultarArticulosPendienteDePreparacion":
						{
							string _listaTiposDeComprobantesExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesExcluidos");
							string _tiposComprobantesOrigen = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesOrigen");
							_result = mz.erp.businessrules.reportes.rep_ListadoDeArticulosPendienteDePreparacion.GetList(_tiposComprobantesOrigen, _listaTiposDeComprobantesExcluidos, this._idCuenta, this._fechaVtoDesde, this._fechaVtoHasta, this._responsableEmision, Security.IdEmpresa, Security.IdSucursal, false /*verHTML*/, this._pendientes, j1, j2, j3,j4,j5,j6,j7,j8,j9,j10,j11,j12,j13,j14,j15,j16).Tables[0];
							break;
						}
						// tarea 2.4 --> ProcesoConsultaOrdenesPreparadasPendientesEntrega
						case "ProcesoConsultaOrdenesPreparadasPendientesEntrega":
						{
							string _tiposComprobantesOrigen = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesOrigen");
							/*borrar --> */string _tiposComprobantesDestino = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesDestino");
							string _listaTiposDeComprobantesExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName,"TiposComprobantesExcluidos");
							_result = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesEntregasWF( _tiposComprobantesOrigen, _tiposComprobantesOrigen, this._idCuenta, this._fechaVtoDesde, this._fechaVtoHasta,  this._responsableEmision, Security.IdSucursal, Security.IdEmpresa, false, this._pendientes,_listaTiposDeComprobantesExcluidos, j9, j10, j11, j12, j13, j14, j15, j16).Tables[0];
							break;
						}
					}
				
				}
			break;
			}
			
			if (this.DataChanged != null)
			{
				this.DataChanged(this, new System.EventArgs() );
			}
			
		}

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

		public void ResetFechas()
		{
			_fechaDesde = DateTime.Now.AddDays(-30);
			_fechaHasta = DateTime.Now;
			
			_fechaConvDesde = DateTime.Now.AddDays(-30);
			_fechaConvHasta = DateTime.Now;

			_fechaVtoDesde = DateTime.Now.AddDays(-30);
			_fechaVtoHasta = DateTime.Now;

			long  cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
			{
				// OJO NO RESTA BIEN
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
				_fechaConvDesde = _fechaDesde;
				_fechaVtoDesde = _fechaDesde;
			}
			
			_fechaDesdeDefault = _fechaDesde;
			_fechaHastaDefault = _fechaHasta;
			
			_numeroDesde = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Numero.Default");			
			_numeroHasta = _numeroDesde;
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaVtoDesde = fecha; }
            else { this._fechaVtoHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaVtoHasta < fecha)
                {
                    _fechaVtoHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaVtoDesde > fecha)
                {
                    _fechaVtoDesde = Util.GenerateFechaHasta(fecha, dias);
                    //this.fe
                }

            }//End ELSE

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	

	}
}
