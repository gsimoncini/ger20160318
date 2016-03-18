using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarListasDePrecios.
	/// </summary>
	public class ConsultarListasDePrecios: ITask
	{
		#region Constructores
		public ConsultarListasDePrecios()
		{
		}
		#endregion

		#region Variables Privadas
		private string _idProducto = string.Empty;
		private string _codigoProducto = string.Empty;
		private bool _soloProductosActivos = false;
		private bool _allowMultipleSelect = false;

		private ArrayList _jerarquias1 = new ArrayList();
		private ArrayList _jerarquias2 = new ArrayList();
		private ArrayList _jerarquias3 = new ArrayList();
		private ArrayList _jerarquias4 = new ArrayList();
		private ArrayList _jerarquias5 = new ArrayList();
		private ArrayList _jerarquias6 = new ArrayList();
		private ArrayList _jerarquias7 = new ArrayList();
		private ArrayList _jerarquias8 = new ArrayList();

		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byJerarquia6 = false;
		private bool _byJerarquia7 = false;
		private bool _byJerarquia8 = false;

		private DataTable _result = new DataTable();	

		private bool _monedaListaDePreciosPesos = true;
		private bool _monedaListaDePreciosDolares = false;
		private string _idMonedaReferencia = mz.erp.businessrules.Variables.GetValueString("Contabilidad.MonedaReferencia");
		private string _fuenteDeCambioReferencia = mz.erp.businessrules.Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");

		private bool _allowGridConfiguration = false;

        /* Silvina 20101112 - Tarea 935 */
        string _orden = string.Empty;
        /* Fin Silvina */

		#endregion

		#region Eventos y delegados		
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
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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

		private string _leyendaFormulario = "Consultar Listas de Precios";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				
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
				return _preguntarAlCancelar ;
			}
		}

		public string CodigoProducto
		{
			get{return _codigoProducto;}
			set
			{
				if(value!=null && !value.Equals(string.Empty) && _codigoProducto!=value)
				{
					if(_codigoProducto != value)
					{
						_codigoProducto = value;
						_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigoProducto);
					}
				}
				else
				{
					if (value.Equals(string.Empty))
					{
						_codigoProducto = string.Empty;
						_idProducto = string.Empty;
					}
				}
			}
		}

		public bool SoloProductosActivos
		{
			get{return _soloProductosActivos;}
			set
			{
				if(_soloProductosActivos != value)
				{
					_soloProductosActivos = value;
				}
			}
		}


		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}

		ArrayList _listasDePrecios = new ArrayList();
		public ArrayList ListasDePrecios
		{
			get 
			{
				return _listasDePrecios;
			}
		}

		ArrayList _listasDePreciosSeleccionadas = new ArrayList();
		public ArrayList ListasDePreciosSeleccionadas
		{
			set 
			{
				_listasDePreciosSeleccionadas = value;
			}
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

		public DataTable Result
		{
			get{return _result;}
		}

		public bool MonedaListaDePreciosPesos
		{
			get{return _monedaListaDePreciosPesos;}
			set
			{
				if(_monedaListaDePreciosPesos != value)
				{
					_monedaListaDePreciosPesos = value;
				}
			}
		}

		public bool MonedaListaDePreciosDolares
		{
			get{return _monedaListaDePreciosDolares;}
			set
			{
				if(_monedaListaDePreciosDolares != value)
				{
					_monedaListaDePreciosDolares = value;
				}
			}
		}

		public bool AllowGridConfiguration
		{
			get{return _allowGridConfiguration;}
		}

        /* Silvina 20101112 - Tarea 935 */
        public string Orden
        {
            get { return _orden;}
        }
        /* Fin Silvina */

		#endregion

		#region Métodos Públicos
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

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			
			/*
			string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
			for(int i = 0; i<8;i++)
			{
				if(aux[i])
				{
					/**
					for(int j = 0; j<8; j++)
					{
						if(jers[j] == string.Empty)
						{
							jers[j] = jerarquias[i];
							break;
						}
					}
				}
			}*/

			j1 = jerarquias[0];	
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];


			ArrayList myLp = new ArrayList();
			for(int i = 0; i<10;i++)
				myLp.Insert(i, string.Empty);

			int k = 0;
			foreach(ListaDePrecioView lpv in _listasDePreciosSeleccionadas)
			{
				myLp.Insert(k, lpv.IdListaDePrecio);
				k++;
			}
			string lp1 = (string)myLp[0];
			string lp2 = (string)myLp[1];
			string lp3 = (string)myLp[2];
			string lp4 = (string)myLp[3];
			string lp5 = (string)myLp[4];
			string lp6 = (string)myLp[5];
			string lp7 = (string)myLp[6];
			string lp8 = (string)myLp[7];
			string lp9 = (string)myLp[8];
			string lp10 = (string)myLp[9];

			
            string IdMonedaVisualizacion = "";
			if(_monedaListaDePreciosPesos)
			{
				commontypes.data.tfi_MonedasDataset.tfi_MonedasDataTable dataTable = (tfi_MonedasDataset.tfi_MonedasDataTable)dataaccess.tfi_Monedas.GetList("Pesos").Tables[0];
				IdMonedaVisualizacion =((commontypes.data.tfi_MonedasDataset.tfi_MonedasRow) dataTable.Rows[0]).IdMoneda;
			}
			else
			{
				commontypes.data.tfi_MonedasDataset.tfi_MonedasDataTable dataTable = (tfi_MonedasDataset.tfi_MonedasDataTable)dataaccess.tfi_Monedas.GetList("Dólares").Tables[0];
				IdMonedaVisualizacion =((tfi_MonedasDataset.tfi_MonedasRow) dataTable.Rows[0]).IdMoneda;

			}
				

			/* Silvina 20101112 - Tarea 935 */
            _result = dataaccess.reportes.rep_ListadoComprasListaDePrecios.GetList(_idProducto, _soloProductosActivos, j1, j2, j3, j4, j5, j6, j7, j8, lp1, lp2, lp3, lp4, lp5, lp6, lp7, lp8, lp9, lp10, _idMonedaReferencia, IdMonedaVisualizacion, _fuenteDeCambioReferencia,_orden);
            /* Fin Silvina */
			if (this.DataChanged != null)
			{
				this.DataChanged(this, new System.EventArgs() );
			}
			
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
			_allowMultipleSelect = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowMultipleSelect");	
			DataTable listaDePreciosTable = businessrules.tsh_ListasDePrecios.GetList(true).tsh_ListasDePrecios;
			listaDePreciosTable = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName, _taskName, "ListasDePrecios", "IdListaDePrecio", listaDePreciosTable);
			foreach (System.Data.DataRow row in listaDePreciosTable.Rows)
			{
				string idLP = row["IdListaDePrecio"].ToString();
				string descripcion = row["Descripcion"].ToString();
				ListaDePrecioView lp = new ListaDePrecioView(idLP, descripcion);
				_listasDePrecios.Add(lp);

			}

			_allowGridConfiguration = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowGridConfiguration");	
            /* Silvina 20101112 - Tarea 934 */
            _orden = Variables.GetValueStringDefault(this._processParent.Process.ProcessName, this._taskName, "Orden", string.Empty);	
            /* Fin Silvina */
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

		public class ListaDePrecioView
		{
			public ListaDePrecioView(string IdListaDePrecio, string Descripcion)
			{
				_idListaDePrecio = IdListaDePrecio;
				_descripcion = Descripcion;
			}

			private string _idListaDePrecio;
			public string IdListaDePrecio 
			{
				get {return _idListaDePrecio;}
			}

			private string _descripcion;
			public string Descripcion 
			{
				get {return _descripcion;}
			}

			public override System.String ToString()
			{
				return _descripcion;
			}
		}
	
	}
}
