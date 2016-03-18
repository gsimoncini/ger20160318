using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultaCompras.
	/// </summary>
	public class ConsultaCompras : ITask
	{
		public ConsultaCompras()
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
			_validarFechas = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarFechas");
			long  cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			_permiteBuscarFechasAlmacenadas = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "PermiteBuscarFechasAlmacenadas");
			_habilitaFiltroStock = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "HabilitaFiltroStock", _habilitaFiltroStock);
			_habilitaFiltroFechas = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "HabilitaFiltroFechas", _habilitaFiltroFechas);
			_byFechas = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "FiltroFechasSeleccionado", _habilitaFiltroFechas);
            /* Silvina 20100909 - Tarea 669 */
            _byFechasDefault = _byFechas;
            /* Fin Silvina */
			if(_habilitaFiltroStock)
				ConfigureFiltroStock();
			_permiteModificarFechaHasta = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "PermiteModificarFechaHasta");
			_rangoFechasPermitido = Variables.GetValueLong(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "RangoFechasPermitido");
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
			_contenedoresVisibles = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(),"ContenedoresVisibles");
            //Cristian Tarea 0000010 20110223
            _listaDeposito = (DataTable) businessrules.tlg_Depositos.GetList(null,null,null, true).tlg_Depositos;
	     	 _listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList(null, null, null, true).tlg_Secciones;
             if (_listaSeccion != null && _listaSeccion.Rows.Count > 0)
                     _idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
             if (_listaDeposito != null && _listaDeposito.Rows.Count > 0)
                     _idDeposito = _listaDeposito.Rows[0]["IdDeposito"].ToString();          
            //Fin Cristian
		}

		private void ConfigureFiltroStock()
		{
			DataTable tableVisualizaciones = mz.erp.businessrules.tlg_VisualizacionDeStock.GetList().Tables[0]; 

			DataTable tableEstadosDeStock = mz.erp.businessrules.tlg_EstadosDeStock.GetList().Tables[0];
			string varVis = "Momentos." + this._taskName +"."+ this._processParent.Process.ProcessName +"."+ "ListaVisualizacionesDeStock";
			string varEstados = "Momentos." + this._taskName +"."+ this._processParent.Process.ProcessName +"."+ "ListaEstadosDeStock";
			tableEstadosDeStock = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName , this._taskName, "ListaEstadosDeStock","IdEstadoDeStock", tableEstadosDeStock);
			_estadosDeStock.Clear();
			foreach(DataRow row in tableEstadosDeStock.Rows)
			{
				EstadoDeStockView ev = new EstadoDeStockView();
				ev.IdEstadoDeStock = Convert.ToInt32(row["IdEstadoDeStock"]);
				ev.Descripcion = Convert.ToString(row["Descripcion"]);
				_estadosDeStock.Add(ev);

			}
			tableVisualizaciones = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName , this._taskName, "ListaVisualizacionesDeStock","IdVisualizacionDeStock", tableVisualizaciones);
			_visualizacionesDeStock.Clear();
			foreach(DataRow row in tableVisualizaciones.Rows)
			{
				VisualizacionDeStockView ev = new VisualizacionDeStockView();
				ev.IdVisualizacionDeStock = Convert.ToInt32(row["IdVisualizacionDeStock"]);
				ev.Descripcion = Convert.ToString(row["Descripcion"]);
				_visualizacionesDeStock.Add(ev);

			}
			DataTable tableVisualizacionesDet = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetListEx().Tables[0];
			tableVisualizacionesDet = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName , this._taskName, "ListaVisualizacionesDeStock","IdVisualizacionDeStock", tableVisualizacionesDet);
			_visualizacionesDeStockDet.Clear();
			foreach(DataRow row in tableVisualizacionesDet.Rows)
			{
				DetalleVisualizacionDeStockView ev = new DetalleVisualizacionDeStockView();
				ev.IdVisualizacionDeStock = Convert.ToInt32(row["IdVisualizacionDeStock"]);
				ev.EstadoDeStock = Convert.ToString(row["EstadoDeStock"]);
				ev.IdEstadoDeStock = Convert.ToInt32(row["IdEstadoDeStock"]);
				ev.Operacion = Convert.ToInt32(row["Operacion"]);
				_visualizacionesDeStockDet.Add(ev);

			}
		}

		public bool ValidarFechas()
		{
			if(!(_fechaDesde.Day.Equals(_fechaHasta.Day) && _fechaDesde.Month.Equals(_fechaHasta.Month)
				&& _fechaDesde.Year.Equals(_fechaHasta.Year)))
				return false;
			return true;

		}

		public bool RangoDeFechasValido()
		{
			if (_rangoFechasPermitido != long.MinValue)
			{
				DateTime fecha = _fechaDesde;
				fecha = fecha.AddDays(_rangoFechasPermitido);
				if (_fechaHasta > fecha)
					return false;
			}
			return true;
		}

		public ArrayList GetFechasAlmacenadas()
		{
			ArrayList result = new ArrayList();
			switch(this._processParent.Process.ProcessName)
			{		
				case "ProcesoConsultarValorizacionDeStock":
				{
					DataSet data = mz.erp.businessrules.tfi_ValorizacionStock.GetFechasEntre(this._fechaDesde, this._fechaHasta);
					foreach(DataRow row in data.Tables[0].Rows)
					{
						result.Add(Convert.ToDateTime(row["Fecha"]));
					}
				}
				break;
				default:break;
 			}
			return result;
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
		private string _codigo = string.Empty;
		private string _idProveedor = string.Empty;
		private string _codigoProveedor = string.Empty;
		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		private DateTime _fechaHasta = DateTime.Now;
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
		private bool _byFechas = false;
		private bool _resumido = false;

		private bool _validarFechas = false;
		private bool _permiteBuscarFechasAlmacenadas = false;
		private DateTime _fechaSeleccionada = DateTime.MinValue;
		private bool _byEstadoDeStock = true;
		private bool _habilitaFiltroStock = false;
		ArrayList _estadosDeStock = new ArrayList();
		ArrayList _visualizacionesDeStock = new ArrayList();
		ArrayList _visualizacionesDeStockDet = new ArrayList();
		ArrayList _selectedEstadosDeStock = new ArrayList();
		ArrayList _selectedVisualizacionesDeStock = new ArrayList();
		private bool _habilitaFiltroFechas = true;
		private bool _permiteModificarFechaHasta;
		private long _rangoFechasPermitido = long.MinValue;

        /* Silvina 20100630 - Tarea 669 */

        private ArrayList _jerarquiasCliente1 = new ArrayList();
        private ArrayList _jerarquiasCliente2 = new ArrayList();
        private ArrayList _jerarquiasCliente3 = new ArrayList();
        private ArrayList _jerarquiasCliente4 = new ArrayList();
        private ArrayList _jerarquiasCliente5 = new ArrayList();
        private ArrayList _jerarquiasCliente6 = new ArrayList();
        private ArrayList _jerarquiasCliente7 = new ArrayList();
        private ArrayList _jerarquiasCliente8 = new ArrayList();

        private bool _byJerarquiaCliente1 = false;
        private bool _byJerarquiaCliente2 = false;
        private bool _byJerarquiaCliente3 = false;
        private bool _byJerarquiaCliente4 = false;
        private bool _byJerarquiaCliente5 = false;
        private bool _byJerarquiaCliente6 = false;
        private bool _byJerarquiaCliente7 = false;
        private bool _byJerarquiaCliente8 = false;

        /* Fin Silvina */

        /* Silvina 20100909 - Tarea 669 */
        private bool _byFechasDefault = false;
        /* Fin Silvina */

        private bool _soloActivos = false; //Matias 20100719 - Tarea 88
        //Cristian Tarea 0000010 20110223
	    private ArrayList _filtroStock = new ArrayList();
        private string _idDeposito = string.Empty;
        private string _idSeccion = string.Empty;
        private DataTable _listaDeposito = (DataTable) businessrules.tlg_Depositos.GetList(null,null,null, true).tlg_Depositos;
		private DataTable _listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList(null, null, null, true).tlg_Secciones;
        //Fin Cristian
		#endregion

		#region Propiedades

		private string _contenedoresVisibles = string.Empty;
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}

		
		public ArrayList SelectedEstadosDeStock
		{
			set{ _selectedEstadosDeStock = value;}
		}


		public ArrayList SelectedVisualizacionesDeStock
		{
			set{_selectedVisualizacionesDeStock = value;}
		}


		public ArrayList EstadosDeStock
		{
			get{return _estadosDeStock;}
		}

		public ArrayList VisualizacionesDeStockDet
		{
			get{return _visualizacionesDeStockDet;}
		}


		public ArrayList VisualizacionesDeStock
		{
			get{return _visualizacionesDeStock;}
		}

		public bool HabilitaFiltroStock
		{
			get{return _habilitaFiltroStock;}
		}

		public bool HabilitaFiltroFechas
		{
			get{return _habilitaFiltroFechas;}
		}

		public bool PermiteModificarFechaHasta
		{
			get{return _permiteModificarFechaHasta;}
		}

		public bool ByEstadoDeStock
		{
			set{_byEstadoDeStock = value;}
			
		}

		public DateTime FechaSeleccionada
		{
			set{_fechaSeleccionada = value;}
		}



		public bool AllowShowBuscarFechasAlmacenadas
		{
			get{ return _permiteBuscarFechasAlmacenadas ;}
		}


		public bool MustValidarFechas
		{
			get{return _validarFechas;}
		}



		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
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

		

		public bool Resumido
		{
			get{return _resumido;}
			set
			{
				if(value != _resumido)
				{
					_resumido = value;
					/*if(ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}*/
				}
			}
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
					_codigo = string.Empty;
					_idProducto = string.Empty;
				}
			
			}
		}
        //Cristian Tarea 0000010 20110222
        public String IdSeccion
        {
            get { return _idSeccion; }
            set { _idSeccion = value; }
        }
        public String IdDeposito
        {
            get { return _idDeposito; }
            set { _idDeposito = value; }
        }
        public ArrayList FiltroStock        {
            get { return _filtroStock; }
            set { _filtroStock = value; }
        }
        public DataTable ListaDeposito
        {
            get
            {
                if (_listaDeposito.Rows.Count > 0)
                {
                    _idDeposito = _listaDeposito.Rows[0]["IdDeposito"].ToString();
                }
                else
                {
                    _idDeposito = string.Empty;
                }
                return _listaDeposito;
            }
        }

        public DataTable ListaSeccion
        {
            get
            {
                if (_listaSeccion.Rows.Count > 0)
                {
                    _idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
                }
                else
                {
                    _idSeccion = string.Empty;
                }
                return _listaSeccion;
            }
        }	
		//Fin Cristian
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

        /* Silvina 20100630 - Tarea 669 */

        public bool ByJerarquiaCliente1
        {
            get { return _byJerarquiaCliente1; }
            set { _byJerarquiaCliente1 = value; }
        }

        public bool ByJerarquiaCliente2
        {
            get { return _byJerarquiaCliente2; }
            set { _byJerarquiaCliente2 = value; }
        }

        public bool ByJerarquiaCliente3
        {
            get { return _byJerarquiaCliente3; }
            set { _byJerarquiaCliente3 = value; }
        }

        public bool ByJerarquiaCliente4
        {
            get { return _byJerarquiaCliente4; }
            set { _byJerarquiaCliente4 = value; }
        }

        public bool ByJerarquiaCliente5
        {
            get { return _byJerarquiaCliente5; }
            set { _byJerarquiaCliente5 = value; }
        }

        public bool ByJerarquiaCliente6
        {
            get { return _byJerarquiaCliente6; }
            set { _byJerarquiaCliente6 = value; }
        }

        public bool ByJerarquiaCliente7
        {
            get { return _byJerarquiaCliente7; }
            set { _byJerarquiaCliente7 = value; }
        }

        public bool ByJerarquiaCliente8
        {
            get { return _byJerarquiaCliente8; }
            set { _byJerarquiaCliente8 = value; }
        }

        public ArrayList JerarquiasCliente1
        {
            get { return _jerarquiasCliente1; }
            set { _jerarquiasCliente1 = value; }
        }

        public ArrayList JerarquiasCliente2
        {
            get { return _jerarquiasCliente2; }
            set { _jerarquiasCliente2 = value; }
        }
        public ArrayList JerarquiasCliente3
        {
            get { return _jerarquiasCliente3; }
            set { _jerarquiasCliente3 = value; }
        }

        public ArrayList JerarquiasCliente4
        {
            get { return _jerarquiasCliente4; }
            set { _jerarquiasCliente4 = value; }
        }

        public ArrayList JerarquiasCliente5
        {
            get { return _jerarquiasCliente5; }
            set { _jerarquiasCliente5 = value; }
        }

        public ArrayList JerarquiasCliente6
        {
            get { return _jerarquiasCliente6; }
            set { _jerarquiasCliente6 = value; }
        }

        public ArrayList JerarquiasCliente7
        {
            get { return _jerarquiasCliente7; }
            set { _jerarquiasCliente7 = value; }
        }

        public ArrayList JerarquiasCliente8
        {
            get { return _jerarquiasCliente8; }
            set { _jerarquiasCliente8 = value; }
        }

        /* Fin Silvina */

        /* Silvina 20100909 - Tarea 669 */
        public bool ByFechasDefault
        {
            get { return _byFechasDefault; }
            set { _byFechasDefault = value; }
        }
        /* Fin Silvina */

		/*public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}
*/
		public string CodigoProveedor
		{
			get{return _codigoProveedor;}
			set
			{
				_codigoProveedor = value;
				Proveedor proveedor = new Proveedor();
				proveedor.GetCuenta_CodigoProveedor(_codigoProveedor);
				_idProveedor = proveedor.IdProveedor;
			}
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

        //Matias 20100717 - Tarea 88
        public bool SoloActivos
        {
            get { return _soloActivos; }
            set { _soloActivos = value; }
        }
        //Fin Matias 20100717 - Tarea 88

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

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
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

            /* Silvina 20100630 - Tarea 669 */

            string jc1 = BuildJerarquia(_jerarquiasCliente1);
            string jc2 = BuildJerarquia(_jerarquiasCliente2);
            string jc3 = BuildJerarquia(_jerarquiasCliente3);
            string jc4 = BuildJerarquia(_jerarquiasCliente4);
            string jc5 = BuildJerarquia(_jerarquiasCliente5);
            string jc6 = BuildJerarquia(_jerarquiasCliente6);
            string jc7 = BuildJerarquia(_jerarquiasCliente7);
            string jc8 = BuildJerarquia(_jerarquiasCliente8);

            string[] jerarquiasCliente = new string[8] { _byJerarquiaCliente1 ? jc1 : string.Empty, _byJerarquiaCliente2 ? jc2 : string.Empty, _byJerarquiaCliente3 ? jc3 : string.Empty, _byJerarquiaCliente4 ? jc4 : string.Empty, _byJerarquiaCliente5 ? jc5 : string.Empty, _byJerarquiaCliente6 ? jc6 : string.Empty, _byJerarquiaCliente7 ? jc7 : string.Empty, _byJerarquiaCliente8 ? jc8 : string.Empty };

            jc1 = jerarquiasCliente[0];
            jc2 = jerarquiasCliente[1];
            jc3 = jerarquiasCliente[2];
            jc4 = jerarquiasCliente[3];
            jc5 = jerarquiasCliente[4];
            jc6 = jerarquiasCliente[5];
            jc7 = jerarquiasCliente[6];
            jc8 = jerarquiasCliente[7];

            /* Fin Silvina */

			DateTime FechaDesde = _byFechas ? this.FechaDesde : DateTime.MinValue;
			DateTime FechaHasta = _byFechas ? this.FechaHasta : DateTime.MinValue;
			switch (this._taskName)
			{
				case "ConsultaSeguimientos":
				{
					string IdEstadosDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaIdEstadosDeStock");					
                    _result = dataaccess.reportes.rep_ListadoSeguimientoDeArticulos.GetList(_idProducto, j1, j2, j3, j4, j5, j6, j7, j8, FechaDesde, FechaHasta, IdEstadosDeStock, _resumido);		
					decimal prog = 0;
					decimal cant = 0;
					foreach(DataRow row in _result.Rows)
					{
						cant = Convert.ToDecimal(row["Cantidad"]);
						prog = prog + cant;
						row["Progresion"] = prog;
					}
					
				}
					break;

					case "ProductosStockDebajoMinino":
				{
					
					_result = dataaccess.reportes.rep_ProductosDebajoStockMinimo.GetList(_idProducto, j1, j2, j3, j4, j5, j6, j7, j8);		
					
				}
					break;
					
				case "ConsultarProductosNumerosDeSerie":
				{
					string IdFuenteDeCambio = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
					string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
					_result = dataaccess.reportes.rep_ListadoProductosNumerosDeSerie.GetList(_idProducto, j1, j2, j3, j4,j5,j6, j7, j8, _fechaDesde, _fechaHasta);		
					
				}
					break;
				case "ConsultarComprasListaDePrecios":
				{
					string IdFuenteDeCambio = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
					string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
					_result = dataaccess.reportes.rep_ListadoComprasListaDePrecios.GetList(_idProducto, j1, j2, j3, j4,j5,j6, j7, j8, IdMoneda, IdMoneda, IdFuenteDeCambio);		
				}
					break;
				case "ValorizarStock":
				{
					string IdMonedaVisualizacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdMonedaVisualizacion");
					if(IdMonedaVisualizacion == null || IdMonedaVisualizacion.Equals(string.Empty))
						IdMonedaVisualizacion = ComprobantesRules.Contabilidad_MonedaReferencia;
					string IdFuenteDeCambioVisualizacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdFuenteDeCambioVisualizacion");
					if(IdFuenteDeCambioVisualizacion == null || IdFuenteDeCambioVisualizacion.Equals(string.Empty))
							IdFuenteDeCambioVisualizacion = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
					string IdMonedaReferencia = ComprobantesRules.Contabilidad_MonedaReferencia;
					//string IdEstadosDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaIdEstadosDeStock");
                    //Cristian Tarea 0000046 20110321
                    string idEstadosDeStock = string.Empty;
                    ArrayList es = new ArrayList();
                    foreach (EstadoDeStockView esv in _selectedEstadosDeStock)
                    {
                        es.Add(esv.IdEstadoDeStock);
                    }

                    idEstadosDeStock = mz.erp.systemframework.Util.PackString(es, ",");
                    _result = dataaccess.reportes.rep_ListadoStockValorizado.GetList(_idProducto, j1, j2, j3, j4, j5, j6, j7, j8, idEstadosDeStock, IdMonedaReferencia, IdMonedaVisualizacion, IdFuenteDeCambioVisualizacion);		
                    //Fin Cristian
				}
					break;
				case "ConsultarRentabilidadProductos":
				{
					string IdMonedaVisualizacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdMonedaVisualizacion");
					if(IdMonedaVisualizacion == null || IdMonedaVisualizacion.Equals(string.Empty))
						IdMonedaVisualizacion = ComprobantesRules.Contabilidad_MonedaReferencia;
					string IdFuenteDeCambioVisualizacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdFuenteDeCambioVisualizacion");
					if(IdFuenteDeCambioVisualizacion == null || IdFuenteDeCambioVisualizacion.Equals(string.Empty))
						IdFuenteDeCambioVisualizacion = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
					string IdMonedaReferencia = ComprobantesRules.Contabilidad_MonedaReferencia;
					string ListaTiposDeComprobantes = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaTiposDeComprobantes");
					_result = mz.erp.dataaccess.reportes.rep_ListadoDeVentasPorProducto.GetList( _idProducto, j1, j2, j3, j4,j5, j6, j7, j8, FechaDesde, FechaHasta, IdMonedaReferencia ,IdMonedaVisualizacion,IdFuenteDeCambioVisualizacion, ListaTiposDeComprobantes);
					
				}
					break;

				case "ConsultarRentabilidadEquiposUsuarios":  
				{
					bool VerTodosLosGrupos = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermiteVerTodosLosGrupos");
					long Grupo = VerTodosLosGrupos?long.MinValue:Security.Grupo;
					if(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoConsultarVentas"))
						_result = mz.erp.dataaccess.reportes.rep_ListadoDeRentabilidadPorGruposUsuarios.GetListGeneral(_fechaDesde, _fechaHasta, Grupo);
					else
                        /* Silvina 20100610 - Tarea 669 */
                        if (this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoConsultarVentasDueño"))
                            _result = mz.erp.dataaccess.reportes.rep_ListadoDeRentabilidadPorGruposUsuarios.GetListDueño(_fechaDesde, _fechaHasta, Grupo, j1, j2, j3, j4, j5, j6, j7, j8, jc1, jc2, jc3, jc4, jc5, jc6, jc7, jc8);
                        else
                        /* Fin Silvina */
							_result = mz.erp.dataaccess.reportes.rep_ListadoDeRentabilidadPorGruposUsuarios.GetList(_fechaDesde, _fechaHasta, Grupo);			
				}
					break;

				case "ConsultarRentabilidadEquiposUsuariosAnterior":  
				{

					bool VerTodosLosGrupos = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermiteVerTodosLosGrupos");
					long Grupo = VerTodosLosGrupos?long.MinValue:Security.Grupo;
					_result = mz.erp.dataaccess.reportes.rep_ListadoDeRentabilidadPorGruposUsuarios.GetListAnterior(_fechaDesde, _fechaHasta, Grupo);
					
				}
					break;
				case "ConsultarValorizacionDeStock":
				{
                    //Cristian Tarea 0000046 20110321
                   // if (!_fechaSeleccionada.Equals(DateTime.MinValue))
                   // {
                        string estados = string.Empty;
                        ArrayList es = new ArrayList();
                        foreach (EstadoDeStockView esv in _selectedEstadosDeStock)
                        {
                            es.Add(esv.IdEstadoDeStock);
                        }
                        if (es.Count > 0)
                        {
                            estados = mz.erp.systemframework.Util.PackString(es, ",");
                            _result = mz.erp.dataaccess.reportes.rep_ConsultarValorizacionDeStock.GetList(_idProducto,estados,
                                                                                                          j1,
                                                                                                          j2, j3, j4, j5,
                                                                                                          j6,
                                                                                                          j7, j8,
                                                                                                          _fechaSeleccionada);
                     //   }
                      //Fin Cristian
                    }
				}
				break;
				case "ConsultarStock":
				{
                    //Cristian Tarea 0000010 20110222
                    Object[] filtrosStock = FiltroStock.ToArray();
                    Boolean stockMayor = (Boolean)filtrosStock[2];
                    Boolean stockCero = (Boolean)filtrosStock[1];
                    Boolean stockMenor = (Boolean)filtrosStock[0];
                    //Fin Cristian
					if(_byEstadoDeStock)
					{
						string estados = string.Empty;
						ArrayList es = new ArrayList();
						foreach(EstadoDeStockView esv in _selectedEstadosDeStock)
						{
							es.Add(esv.IdEstadoDeStock);
						}
						if(es.Count > 0)
						{
							estados = mz.erp.systemframework.Util.PackString(es, ",");
                            //Matias 20100719 - Tarea 88
                            //_result = mz.erp.dataaccess.reportes.rep_ConsultarStock.GetListXEstadoDeStock(_idProducto, j1, j2, j3, j4,j5,j6, j7, j8, estados);
                             //Cristian Tarea 0000010 20110222
                            _result = mz.erp.dataaccess.reportes.rep_ConsultarStock.GetListXEstadoDeStock(_idProducto, j1, j2, j3, j4, j5, j6, j7, j8, estados, this.SoloActivos, stockMayor, stockCero, stockMenor, IdDeposito, IdSeccion);
                            //Fin Cristian
                            //Fin Matias 20100719 - Tarea 88
						}
					}
					else
					{
						string visualzaciones = string.Empty;
						ArrayList es = new ArrayList();
						foreach(VisualizacionDeStockView esv in _selectedVisualizacionesDeStock)
						{
							es.Add(esv.IdVisualizacionDeStock);
						}
						if(es.Count > 0)
						{
							visualzaciones = mz.erp.systemframework.Util.PackString(es, ",");
                            //Matias 20100719 - Tarea 88
                            //_result = mz.erp.dataaccess.reportes.rep_ConsultarStock.GetListXValorizacionDeStock(_idProducto, j1, j2, j3, j4,j5,j6, j7, j8, visualzaciones);
                           
                            //Cristian Tarea 0000010 20110222
                            _result = mz.erp.dataaccess.reportes.rep_ConsultarStock.GetListXValorizacionDeStock(_idProducto, j1, j2, j3, j4, j5, j6, j7, j8, visualzaciones, this.SoloActivos,stockMayor,stockCero,stockMenor,IdDeposito, IdSeccion);
                            //Fin Cristian
                            //Fin Matias 20100719 - Tarea 88
						}
					}
				}
					break;
				case "ConsultarListasDePreciosProveedores":
				{
					_result = dataaccess.reportes.rep_ListadoListaDePreciosProveedores.GetList(_idProducto, _idProveedor ,j1, j2, j3, j4,j5,j6, j7, j8);		
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
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong("Momentos." + this._taskName + "." + this._processParent.Process.ProcessName + ".RangoFechas.DiasAnteriores");
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

	}


	public class EstadoDeStockView
	{
		private int _idEstadoDeStock;
		private string _descripcion = string.Empty;

		public int IdEstadoDeStock
		{
			get{return _idEstadoDeStock;}
			set{_idEstadoDeStock = value;}

		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
				
		}

		public override string ToString()
		{
			return _descripcion;
		}
	}

	public class VisualizacionDeStockView
	{
		private int _idVisualizacionDeStock;
		private string _descripcion = string.Empty;

		public int IdVisualizacionDeStock
		{
			get{return _idVisualizacionDeStock;}
			set{_idVisualizacionDeStock = value;}

		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
				
		}

		
		public override string ToString()
		{
			return _descripcion;
		}
	}

	public class DetalleVisualizacionDeStockView
	{
		private int _idVisualizacionDeStock;
		private int _idEstadoDeStock;
		private string _estadoDeStock = string.Empty;
		private int _operacion ;

		public int Operacion
		{
			get{return _operacion;}
			set{_operacion = value;}

		}

		public int IdVisualizacionDeStock
		{
			get{return _idVisualizacionDeStock;}
			set{_idVisualizacionDeStock = value;}

		}

		public string EstadoDeStock
		{
			get{return _estadoDeStock;}
			set{_estadoDeStock = value;}
				
		}

		
		public int IdEstadoDeStock
		{
			get{return _idEstadoDeStock;}
			set{_idEstadoDeStock = value;}

		}


		
		public override string ToString()
		{
			if(_operacion == 1)
				return "+ " + _estadoDeStock;
			return "- " + _estadoDeStock;
		}	
	}
}
