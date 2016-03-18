using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultaVentas.
	/// </summary>
	public class ConsultaVentas : ITask
	{
		public ConsultaVentas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
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

			ArrayList arrFiltros = systemframework.Util.Parse(_listaFiltros);
			_allowSearchByNumero = arrFiltros.Contains("Numero");

			long  cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			_fechaDesdeDefault = _fechaDesde;
			_fechaHastaDefault = _fechaHasta;
			_numeroDesde = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Numero.Default");			
			_numeroHasta = _numeroDesde;

			_allowGeneralSearch = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowGeneralSearch");
            /* Silvina 20110704 - Tarea 0000136 */
            _imprimeTicket = Variables.GetValueBool("TicketDeCambio.Habilitar") && Variables.GetValueBool("TicketDeCambio.Reimprimir");
            string p = Variables.GetValueString("Fiscal.Puerto");
            if (!p.Equals(string.Empty))
                _puerto = byte.Parse(p);
            string v = Variables.GetValueString("Fiscal.Velocidad");
            if (!v.Equals(string.Empty))
                _velocidad = int.Parse(v);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //German 20120127 - Tarea 0000265
            _familiasTicketDeCambio = Variables.GetValueString("TicketDeCambio.Reimprimir.Familias");
            //Fin German 20120127 - Tarea 0000265
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
			/*bool PermiteFiltroGeneral = false;
			if (_idCuenta == "" && _fechaDesde != _fechaHasta)
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Consulta","Error en filtros","La fecha desde no puede ser distinta a la fecha hasta"));
			}*/

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

        //German 20120127 - Tarea 0000265

        private string _familiasTicketDeCambio = string.Empty;
        //Fin German 20120127 - Tarea 0000265

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

	
		public string CodigoProducto
		{
			get{return _codigoProducto;}
			set
			{
				//if(value !=  null && !value.Equals(string.Empty))
				//{
					if(_codigoProducto != value)
					{
						_codigoProducto = value;
						if (value.Equals(string.Empty))
                            _idProducto = string.Empty;
						else
							_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigoProducto);
					}
				//}			
			}
		}

		public string CodigoCuenta
		{
			get{return _codigoCuenta;}
			set
			{				 
				//if(value !=  null && !value.Equals(string.Empty))
				//{
					if(_codigoCuenta != value)
					{
						_codigoCuenta = value;
						_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);						
					}
				//}
			}
		}

		public string ResponsableEmision
		{
			get{return _responsableEmision;}
			set
			{				 
				//if(value !=  null && !value.Equals(string.Empty))
				//{
					if(_responsableEmision != value)
					{
						_responsableEmision = value;						
					}
				//}
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

		private string _listaFamiliaDeComprobantes = Variables.GetValueString("Comprobantes.FamiliasDeComprobantes");
		private string _listaFamiliaDeComprobantesDV = Variables.GetValueString("Comprobantes.FamiliasDeComprobantesDV");
		private string _familiaDefault = "";

		public string ListaFamiliaDeComprobantes 
		{
			get {return _listaFamiliaDeComprobantes;}
		}
		public string ListaFamiliaDeComprobantesDV
		{
			get {return _listaFamiliaDeComprobantesDV;}
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
/*
		public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}
*/
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
			j9 = jerarquias[8];
			j10 = jerarquias[9];
			j11 = jerarquias[10];
			j12 = jerarquias[11];
			j13 = jerarquias[12];
			j14 = jerarquias[13];
			j15 = jerarquias[14];
			j16 = jerarquias[15];

			DateTime FechaDesde = _byFechas ? this.FechaDesde : DateTime.MinValue;
			DateTime FechaHasta = _byFechas ? this.FechaHasta : DateTime.MinValue;
			_numeroDesde = _allowSearchByNumero ? _numeroDesde : string.Empty;
			_numeroHasta = _allowSearchByNumero ? _numeroHasta : string.Empty;
			
			string TiposDeComprobantes = "";

			if (_familiaComprobantes !="")
				if (TiposDeComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes");
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+_familiaComprobantes);



			if (_allowSearchByNumero == false || _filterByNumero == false)
			{
				_numeroDesde = "";
				_numeroHasta = "";
			}

			switch (this._taskName)
			{
				case "ConsultarDetalleComprobantes":
				{
					// Aca debo formatear jers para pasar el correcto parametro...
					
					string je1 = BuildJerarquia(_jerarquias1);
					string je2 = BuildJerarquia(_jerarquias2);
					string je3 = BuildJerarquia(_jerarquias3);
					string je4 = BuildJerarquia(_jerarquias4);
					string je5 = BuildJerarquia(_jerarquias5);
					string je6 = BuildJerarquia(_jerarquias6);
					string je7 = BuildJerarquia(_jerarquias7);
					string je8 = BuildJerarquia(_jerarquias8);
					string je9 = BuildJerarquia(_jerarquias9);
					string je10 = BuildJerarquia(_jerarquias10);
					string je11 = BuildJerarquia(_jerarquias11);
					string je12 = BuildJerarquia(_jerarquias12);
					string je13 = BuildJerarquia(_jerarquias13);
					string je14 = BuildJerarquia(_jerarquias14);
					string je15 = BuildJerarquia(_jerarquias15);
					string je16 = BuildJerarquia(_jerarquias16);
		
					/*
					string[] jerstr = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
					for(int i = 0; i<8;i++)
					{
						if(aux[i])
						{
							jerstr[i] = jerarquias[i];
						}
					}
					*/

					je1 = jerarquias[0];
					je2 = jerarquias[1];
					je3 = jerarquias[2];
					je4 = jerarquias[3];
					je5 = jerarquias[4];
					je6 = jerarquias[5];
					je7 = jerarquias[6];
					je8 = jerarquias[7];
					je9 = jerarquias[8];
					je10 = jerarquias[9];
					je11 = jerarquias[10];
					je12 = jerarquias[11];
					je13 = jerarquias[12];
					je14 = jerarquias[13];
					je15 = jerarquias[14];
					je16 = jerarquias[15];

					_result = mz.erp.businessrules.reportes.tsa_ReporteDetalleComprobantesDeVenta.GetList( _idCuenta, FechaDesde, FechaHasta, _responsableEmision, TiposDeComprobantes,_idProducto, je1, je2, je3, je4, je5, je6, je7, je8, je9, je10, je11, je12, je13, je14, je15, je16, _numeroDesde, _numeroHasta).Tables[0];
					break;
				}

				case "ConsultarComprobantesVenta":
				{
					bool VerHTML = false;
                    
                    /* Silvina 20120420 - Tarea 0000294 */
                    string je1 = BuildJerarquia(_jerarquias1);
                    string je2 = BuildJerarquia(_jerarquias2);
                    string je3 = BuildJerarquia(_jerarquias3);
                    string je4 = BuildJerarquia(_jerarquias4);
                    string je5 = BuildJerarquia(_jerarquias5);
                    string je6 = BuildJerarquia(_jerarquias6);
                    string je7 = BuildJerarquia(_jerarquias7);
                    string je8 = BuildJerarquia(_jerarquias8);
                    /* Fin Silvina 20120420 - Tarea 0000294 */

					string je9 = BuildJerarquia(_jerarquias9);
					string je10 = BuildJerarquia(_jerarquias10);
					string je11 = BuildJerarquia(_jerarquias11);
					string je12 = BuildJerarquia(_jerarquias12);
					string je13 = BuildJerarquia(_jerarquias13);
					string je14 = BuildJerarquia(_jerarquias14);
					string je15 = BuildJerarquia(_jerarquias15);
					string je16 = BuildJerarquia(_jerarquias16);

                    /* Silvina 20120420 - Tarea 0000294 */
                    je1 = jerarquias[0];
                    je2 = jerarquias[1];
                    je3 = jerarquias[2];
                    je4 = jerarquias[3];
                    je5 = jerarquias[4];
                    je6 = jerarquias[5];
                    je7 = jerarquias[6];
                    je8 = jerarquias[7];
                    /* Fin Silvina 20120420 - Tarea 0000294 */
					je9 = jerarquias[8];
					je10 = jerarquias[9];
					je11 = jerarquias[10];
					je12 = jerarquias[11];
					je13 = jerarquias[12];
					je14 = jerarquias[13];
					je15 = jerarquias[14];
					je16 = jerarquias[15];

					switch(this.GetProcessManagerParent().Process.ProcessName)
					{
						case "ProcesoConsultarVentasPorMedioDePago":
						{
							string ListaRecibos = Variables.GetValueString("Consultas.VentasPorMedioDePago.ListaRecibos");
							string ListaDevolucionesPagos = Variables.GetValueString("Consultas.VentasPorMedioDePago.ListaDevolucionesPagos");
							string ListaRecibosAlContado = Variables.GetValueString("Consultas.VentasPorMedioDePago.ListaRecibosAlContado");
							string ListaFacturasYNotasDeCreditos = Variables.GetValueString("Consultas.VentasPorMedioDePago.ListaFacturasYNotasDeCreditos");

							_result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetVentasPorMedioDePago(FechaDesde, FechaHasta, ListaRecibos, ListaRecibosAlContado, ListaFacturasYNotasDeCreditos, ListaDevolucionesPagos).Tables[0];
						}
						break;
						case "ProcesoConsultarVentasDVPorMedioDePago":
						{
							string ListaRecibos = Variables.GetValueString("Consultas.VentasDVPorMedioDePago.ListaRecibos");
							string ListaDevolucionesPagos = Variables.GetValueString("Consultas.VentasDVPorMedioDePago.ListaDevolucionesPagos");
							string ListaRecibosAlContado = Variables.GetValueString("Consultas.VentasDVPorMedioDePago.ListaRecibosAlContado");
							string ListaFacturasYNotasDeCreditos = Variables.GetValueString("Consultas.VentasDVPorMedioDePago.ListaFacturasYNotasDeCreditos");

							_result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetVentasPorMedioDePago(FechaDesde, FechaHasta, ListaRecibos, ListaRecibosAlContado, ListaFacturasYNotasDeCreditos, ListaDevolucionesPagos).Tables[0];
						}
						break;
						case "ProcesoConsultarVentasConsolidadasPorMedioDePago":
						{
							string ListaRecibos = Variables.GetValueString("Consultas.VentasConsolidadasPorMedioDePago.ListaRecibos");
							string ListaDevolucionesPagos = Variables.GetValueString("Consultas.VentasConsolidadasPorMedioDePago.ListaDevolucionesPagos");
							string ListaRecibosAlContado = Variables.GetValueString("Consultas.VentasConsolidadasPorMedioDePago.ListaRecibosAlContado");
							string ListaFacturasYNotasDeCreditos = Variables.GetValueString("Consultas.VentasConsolidadasPorMedioDePago.ListaFacturasYNotasDeCreditos");

							_result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetVentasPorMedioDePago(FechaDesde, FechaHasta, ListaRecibos, ListaRecibosAlContado, ListaFacturasYNotasDeCreditos,ListaDevolucionesPagos).Tables[0];
						}
						break;
                        /* Silvina 20120420 - Tarea 0000294 */
                        case "ProcesoConsultarComisiones":
						{
                            string jp = string.Empty;
                            if (!string.IsNullOrEmpty(je1))
                                jp = je1;
                            else
                                if (!string.IsNullOrEmpty(je2))
                                    jp = je2;
                                else
                                    if (!string.IsNullOrEmpty(je3))
                                        jp = je3;
                                    else
                                        if (!string.IsNullOrEmpty(je4))
                                            jp = je4;
                                        else
                                            if (!string.IsNullOrEmpty(je5))
                                                jp = je5;
                                            else
                                                if (!string.IsNullOrEmpty(je6))
                                                    jp = je6;
                                                else
                                                    if (!string.IsNullOrEmpty(je7))
                                                        jp = je7;
                                                    else
                                                        if (!string.IsNullOrEmpty(je8))
                                                            jp = je8;                                                      

                            _result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetListComisiones(_idCuenta, FechaDesde, FechaHasta, ResponsableEmision, TiposDeComprobantes, jp, je9, je10, je11, je12, je13, je14, je15, je16).Tables[0];
                        }
						break;
                        case "ProcesoConsultarVentasPorVendedor":
                        {
                            _result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetListVentasPorVendedor(_idCuenta, FechaDesde, FechaHasta, ResponsableEmision, TiposDeComprobantes, je1, je2, je3, je4, je5, je6, je7, je8, je9, je10, je11, je12, je13, je14, je15, je16).Tables[0];
                        }
                        break;
                        case "ProcesoConsultarCobranzas":
                        {                                                                          
                            _result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetListCobranzas(_idCuenta, FechaDesde, FechaHasta, ResponsableEmision, TiposDeComprobantes, je9, je10, je11, je12, je13, je14, je15, je16).Tables[0];
                        }
                        break;
                        /* Fin Silvina 20120420 - Tarea 0000294 */
						default :_result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetList( _idCuenta, FechaDesde, FechaHasta, _responsableEmision, TiposDeComprobantes,VerHTML, je9, je10, je11, je12, je13, je14, je15, je16).Tables[0];
						break;
					}
					break;
				}

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

		public void ResetFilters()
		{
			_fechaDesde = DateTime.Now.AddDays(-30);
			_fechaHasta = DateTime.Now;
			
			long  cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			
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

        /* Silvina 20110704 - Tarea 0000136 */

        private DataTable ticket;
        private byte _puerto;
        private int _velocidad;
        private bool _imprimeTicket = false;

        public bool VisualizaBotonImprimirTicketDeCambio(string IdTipoDeComprobante)
        {
            if (_imprimeTicket)
            {
                string familia = tsy_TiposDeComprobantes.GetByPk(IdTipoDeComprobante).Familia;
                //German 20120127 - Tarea 0000265
                ArrayList familias = mz.erp.systemframework.Util.Parse(_familiasTicketDeCambio);
                return familias.Contains(familia);
                //Fin German 20120127 - Tarea 0000265
            }
            return false;
        }

        public bool ImprimirTicketDeCambio(string IdComprobante)
        {
            ticket = tsa_Comprobantes.ReimprimeTicketDeCambio(IdComprobante);
            if (ticket.Rows.Count > 0)
            {
                ArrayList items = new ArrayList();
                ParaisoFiscal.ItemFiscal it = new ParaisoFiscal.ItemFiscal();
                foreach (DataRow row in ticket.Rows)
                {
                    it.Cantidad = Convert.ToDecimal(row["Cantidad"]);
                    it.Descripcion = row["Descripcion"].ToString();
                    it.TextoFiscal = row["TextoFiscal"].ToString(); ;
                    items.Add(it);
                }
                ParaisoFiscal.FiscalMZ fiscal = new ParaisoFiscal.FiscalMZ();
                string nro = ticket.Rows[0]["Numero"].ToString();
                string familia = ticket.Rows[0]["Familia"].ToString();
                fiscal.CompClase = Convert.ToChar(nro.Substring(0, 1));
                fiscal.CompPuntoDeVenta = nro.Substring(2, 4);
                fiscal.CompNumeroD = nro.Substring(7);
                string descAdic = Variables.GetValueString("TicketDeCambio." + familia + ".DescripcionAdicional", string.Empty);
                if (descAdic.Equals(string.Empty))
                    descAdic = Variables.GetValueString("TicketDeCambio.DescripcionAdicional");
                fiscal.DescripcionAdicionalTicketDeCambio = descAdic;
                fiscal.ReimprimirTicketDeCambio(items, _puerto, _velocidad);
                return true;
            }
            return false;
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

	}
}
