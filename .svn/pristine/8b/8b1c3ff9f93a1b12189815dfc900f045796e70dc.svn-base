using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.commontypes;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionarComprobantesDeCompraPendientes.
	/// </summary>
	public class SeleccionarComprobantesDeCompraPendientes : ITask
	{
		#region Constructores
		public SeleccionarComprobantesDeCompraPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

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
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			long dias = Variables.GetValueLong("Momentos." +  this._taskName + "." +_processManager.Process.ProcessName+ ".RangoFechas.DiasAnteriores");
			this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
			if(!dias.Equals(long.MinValue))
				this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-dias);
			this._fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
			//string responsable = Variables.GetValueString("Momentos."+_idPrimaryTask+".ResponsableEmision");
			string responsable = Variables.GetValueString(_processManager.Process.ProcessName, this._taskName, "ResponsableEmision");
			
			if ((responsable != null) && !(responsable.Equals(string.Empty)))
			{
				if (responsable.Equals("Todos"))
					this._responsableEmision = null ;
				else 
				{
					if (responsable.Equals("Usuario"))
						this._responsableEmision = Security.IdPersona;
					else
						this._responsableEmision = responsable; 					
				}
			}
			else
			{
				this._responsableEmision = string.Empty;
			}
			
			this._idProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
			ArrayList ListaTiposDeComprobantesOrigen = this.GetTiposDeComprobantesOrigen();
			ArrayList ListaTiposDeComprobantesDestino = this.GetTiposDeComprobantesDestinos();
			this._familiaComprobantes = this.ObtenerFamiliaComprobante(ListaTiposDeComprobantesOrigen);
			_tiposDeComprobantesOrigen = Variables.GetValueString("Momentos."+_taskName+"."+ _processManager.Process.ProcessName+".TiposComprobantesOrigen");
			if (_tiposDeComprobantesOrigen == "")
			{
				_tiposDeComprobantesOrigen = mz.erp.systemframework.Util.PackString(ListaTiposDeComprobantesOrigen,",");
			}
			_tiposDeComprobantesDestino = Variables.GetValueString("Momentos."+_taskName+"."+ _processManager.Process.ProcessName +".TiposComprobantesDestino");
			if (_tiposDeComprobantesDestino  == "")
			{
				_tiposDeComprobantesDestino = mz.erp.systemframework.Util.PackString(ListaTiposDeComprobantesDestino,",");
			}
			_tiposDeComprobanteDestinoExcluidos = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "TiposDeComprobantesExcluidos");
			_allowShowDetail = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "VisualizaDetalleComprobantes");
			_showDetailBy = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "MetodoVisualizacionDetalle");			
			_listaFamiliaDeComprobantes = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "FamiliasDeComprobantesDeCompra");			
			if(_listaFamiliaDeComprobantes == null || _listaFamiliaDeComprobantes == string.Empty)	
				_listaFamiliaDeComprobantes = Variables.GetValueString("Comprobantes.FamiliasDeComprobantesDeCompra");
			this._familiaComprobantesDefault =  Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "FamiliasDeComprobantesDeCompras.Default");
			
            _porFechaEmision = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "Filtros.PorFechaEmision", _porFechaEmision);
			_porFechaVencimiento = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "Filtros.PorFechaVencimiento", _porFechaVencimiento);
			_porFechaRecepcionMercaderia = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "Filtros.PorFechaRecepcionMercaderia", _porFechaRecepcionMercaderia);
            //Cristian 20100917 Tarea 836
            _filtroFechaPorDefault = Variables.GetValueString("ComprobantesDeCompras.FiltroFechaValorPorDefault");
            //Fin Cristian 20100917 Tarea 836
 
            _idTipoMovimiento = "-1";
			
			_tipos = mz.erp.businessrules.tsy_TiposMovimientos.GetList().Tables[0];
			_subTipos = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList().Tables[0];
			_habilitaFiltroTipoMovimiento = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "Filtros.PorCuentasImputacion", _habilitaFiltroTipoMovimiento);

			_allowMultipleSelect = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "AllowMultipleSelect");
			_habilitaFamiliasComprobantes = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "HabilitaTiposDeComprobantes");

			_allowValidateSeleccionProveedor = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "Validar.PermiteUnicoProveedor");
			_filtroEstados = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "Estados");
			PreguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar");
			PreguntarAlGuardar = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "PreguntarAlGuardar", false);
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
			bool IsValid = true;
			_errores.Clear();
			if(!IsValidSeleccionProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Proveedor","Proveedor","No puede seleccionar comprobantes de distintos proveedores"));
			}
			return IsValid;
		}

		private bool IsValidSeleccionProveedor()
		{
			ArrayList aux = new ArrayList();
			if(_allowValidateSeleccionProveedor)
			{
				foreach(string IdComprobante in this._arrayComprobantesPendientes)
				{
					foreach(DataRow row in this.Result.Rows)
					{
						if(IdComprobante.Equals(Convert.ToString(row["IdComprobante"])))
						{
							string Proveedor = Convert.ToString(row["Proveedor"]);
							if(aux.Count > 0 && !aux.Contains(Proveedor))
								return false;
							else 
								aux.Add(Proveedor);
						}
					}
				}
			}
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

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processManager;	
		private bool _porFechaEmision = true;
		private bool _porFechaVencimiento = false;
		private bool _porFechaRecepcionMercaderia = false;

        //Cristian 20100917 - Tarea 836
        private string _filtroFechaPorDefault = string.Empty;
        private bool _porFechaRegitracion = false;
        //Fin Cristian 20100917 - Tarea 836


		private DataTable _tipos;
		private DataTable _subTipos;

		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;
		private string _tiposDeComprobantesOrigen = string.Empty;
		private string _tiposDeComprobantesDestino = string.Empty;
		private string _tiposDeComprobanteDestinoExcluidos = string.Empty;
		private bool _allowShowDetail = false;
		private string _showDetailBy = string.Empty;
		private string _familiaComprobantesDefault = string.Empty;

		private bool _porTipoMovimiento = false;
		private bool _habilitaFiltroTipoMovimiento = true;


		private string _idTipoMovimiento = string.Empty;
		private string _idSubTipoMovimiento = string.Empty;

		private bool _allowMultipleSelect = false;
		private bool _allowValidateSeleccionProveedor = false;
		private string _filtroEstados = string.Empty;
			
		private string _idProducto = string.Empty;
		private string _codigoProducto = string.Empty;

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


		#endregion

		#region Propiedades

		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}

		public string IdTipoMovimiento
		{
			get{return _idTipoMovimiento;}
			set
			{
				if(value != null && value != string.Empty)
				{
					if(_idTipoMovimiento != value)
					{
						_idTipoMovimiento = value;
						SetSubCuentasImputacion();						
					}
				}

			}
		}
		private void SetSubCuentasImputacion()
		{
			/*
			_subTipos = new DataView(table, "IdTipoMovimiento = " + _idTipoMovimiento , null, System.Data.DataViewRowState.CurrentRows);
			if (_subTipos.Rows.Count == 1)
			{
				_idSubTipoMovimiento = Convert.ToString(_subTipos.Rows[0]["IdSubTipoMovimiento"]);							
			}
			else
				_idSubTipoMovimiento = string.Empty;
			*/
			if(IdCuentaImputacionChanged != null)
				IdCuentaImputacionChanged(this, new EventArgs());
		}

		public string IdSubTipoMovimiento
		{
			get{return _idSubTipoMovimiento;}
			set{_idSubTipoMovimiento = value;}
		}


		public System.Data.DataTable Tipos
		{
			get {return _tipos;}
		}

		public System.Data.DataTable SubTipos
		{
			get {return _subTipos;}
		}

		public bool PorTipoMovimiento
		{
			get{return _porTipoMovimiento ;}
			set{_porTipoMovimiento = value;}
		}

		public bool HabilitaFiltroTipoMovimiento
		{
			get{return _habilitaFiltroTipoMovimiento;}
		}


		public bool PorFechaEmision
		{
			get{return _porFechaEmision ;}
			set{_porFechaEmision = value;}
		}

		public bool PorFechaVencimiento
		{
			get{return _porFechaVencimiento ;}
			set{_porFechaVencimiento = value;}
		}

		public bool PorFechaRecepcionMercaderia
		{
			get{return _porFechaRecepcionMercaderia ;}
			set{_porFechaRecepcionMercaderia = value;}
		}


        //Cristian 20100917 Tarea 836
        public bool PorFechaRegistracion
        {
            get { return _porFechaRegitracion; }
            set { _porFechaRegitracion = value; }
        }

        public string FiltroFechaPorDefault
        {
            get { return _filtroFechaPorDefault; }
            set { _filtroFechaPorDefault = value; }
        }
        //Fin Cristian 20100917 Tarea 836

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonAnterior");
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
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonSiguiente");
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
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
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

		private bool _preguntarAlGuardar = false;
		public bool PreguntarAlGuardar
		{
			get {return _preguntarAlGuardar;}
			set {_preguntarAlGuardar=value;}
		}

		private DataTable _result = new DataTable();	
		public DataTable Result
		{
			get{return _result;}
		}

		private string _responsableEmision = String.Empty;
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
			
		private string _familiaComprobantes = String.Empty;
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


		private string _listaFamiliaDeComprobantes = string.Empty;
		
		


		//private string _listaFamiliaDeComprobantes = Variables.GetValueString("Comprobantes.FamiliasDeComprobantes");
		
		

		public string ListaFamiliaDeComprobantes 
		{
			get {return _listaFamiliaDeComprobantes;}
		}

		





		public string FamiliaDefault 
		{
			get 
			{

				return _familiaComprobantesDefault.Trim();
			}
		}

		
		private bool _habilitaFamiliasComprobantes = false;
		public bool HabilitaFamiliasComprobantes 
		{
			get 
			{
				return _habilitaFamiliasComprobantes;				

			}
		}
		

		private string _idProveedor = "";
		/*public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}*/

		private string _codigoProveedor = "";
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

		private DateTime _fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set{_fechaDesde = value;}
		}

		private DateTime _fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
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


		private ArrayList _arrayComprobantesPendientes;
		public ArrayList ArrayComprobantesPendientes
		{
			set
			{
				this._arrayComprobantesPendientes = value;
			}
			get
			{
				return _arrayComprobantesPendientes;
			}			
		}


		private bool _visualizaDetalle = false;
		public bool HasShowSeleccionItems
		{
			get{return _visualizaDetalle;}
			set{ _visualizaDetalle = value; }
		}

		private RelacionesComprobanteDeCompraOrigenDestino _relacionesComprobanteOrigenDestino;
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


		#endregion

		#region Eventos

		public event EventHandler IdCuentaImputacionChanged;

		#endregion

		#region Metodos Privados

		private string ObtenerFamiliaComprobante(ArrayList comprobantesorigen)
		{
			
			if(_familiaComprobantesDefault != null && _familiaComprobantesDefault != string.Empty)
				return _familiaComprobantesDefault;
			string family = string.Empty;
			if (comprobantesorigen.Count != 0)
			{
				sy_VariablesDataset  data = mz.erp.businessrules.sy_Variables.GetList("Comprobantes.TiposDeComprobantes.");
				System.Data.DataTable table = data.Tables[0];

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
			string relacionComprobantesPrevios =  Variables.GetValueString(this._processManager.Process.ProcessName,this.GetProcessManagerParent().Process.MainTask.KeyTask, "RelacionComprobantesPrevios");
			string[] arelacionComprobantesPrevios = relacionComprobantesPrevios.Split( ',');
			if (arelacionComprobantesPrevios.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
				{
					string[] atupla = arelacionComprobantesPrevios[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!hash.ContainsKey(atupla[0]))
							hash.Add( atupla[0],atupla[1]);
					}
				}
				foreach (string tipo in aComprobantesDeLaTarea)
				{
					if (hash.ContainsKey( tipo ))
					{
						if(!result.Contains(tipo))
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

		#region Metodos Publicos

		public void RefreshData()
		{
			string TiposDeComprobantes = "";
			
			DateTime DesdeEmision = _porFechaEmision? _fechaDesde: DateTime.MinValue;
			DateTime HastaEmision = _porFechaEmision? _fechaHasta: DateTime.MinValue;
			DateTime DesdeVencimiento = _porFechaVencimiento ? _fechaDesde : DateTime.MinValue;
			DateTime HastaVencimiento = _porFechaVencimiento ? _fechaHasta : DateTime.MinValue;
			DateTime DesdeRecepcion = _porFechaRecepcionMercaderia ? _fechaDesde : DateTime.MinValue;
			DateTime HastaRecepcion = _porFechaRecepcionMercaderia ? _fechaHasta : DateTime.MinValue;

            //Cristian 20100917 - Tarea 836
            DateTime DesdeRegistracion = _porFechaRegitracion ? _fechaDesde : DateTime.MinValue;
            DateTime HastaRegistracion = _porFechaRegitracion ? _fechaHasta : DateTime.MinValue;
            //Fin Cristian 20100917 - Tarea 836

			switch (this._processManager.Process.ProcessName)
			{
				case"ProcesoPagarServiciosGastosCompras":
				{
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
					
					string IdCuentaImputacion = _porTipoMovimiento ? _idTipoMovimiento : string.Empty;
					string IdSubCuentaImputacion = _porTipoMovimiento ? _idSubTipoMovimiento : string.Empty;
                    //Cristian Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompraPendientesPago( _tiposDeComprobantesOrigen,_idProveedor, DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, DesdeRegistracion, HastaRegistracion, _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, IdCuentaImputacion, IdSubCuentaImputacion);
					//Fin Tarea 836
                    DataTable table = data.Tables[0];
					table = AddColumn.AddColumnToTable(table, "Marca", false);
					_result = table;
					break;

				}
				case "ProcesoPredevolverCompras":
				{    //Cristian Tarea 836
					_result = mz.erp.businessrules.reportes.rep_ConsultarComprobantesDeCompra.GetList(TiposDeComprobantes, _idProveedor, _fechaDesde, _fechaHasta, DesdeRegistracion, HastaRegistracion, _responsableEmision, 1, 1, _tiposDeComprobanteDestinoExcluidos).Tables[0];
                     //Fin Tarea 836 
					break;
				}
				case "ProcesoAnularComprobanteDeCompraCabecera":
				{
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
                    //Cristian Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompraPendientes( _tiposDeComprobantesOrigen,_idProveedor, _fechaDesde, _fechaHasta, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _tiposDeComprobanteDestinoExcluidos);
                    //Fin tarea 836
					_result = data.Tables[0];
					break;
				}

				case "ProcesoConsultarComprobantesDeComprasCabecera":
				{
					if (_familiaComprobantes !="")
						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeComprasCabecera.TiposDeComprobantes");
						else
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
					if(_idTipoMovimiento != null && _idTipoMovimiento.Equals("-1")) _idTipoMovimiento = null;
                    //Cristian Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompraCabecera( TiposDeComprobantes,_idProveedor,DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _idTipoMovimiento, _idSubTipoMovimiento);
					//Fin Tarea 836
                    _result = data.Tables[0];
					break;
				}

					
				case "ProcesoConsultarComprobantesDeCompras" :
				{
					if (_familiaComprobantes !="")
						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes");
						else
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
                    //Cristian 20100917 - Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompra( TiposDeComprobantes,_idProveedor,DesdeEmision, HastaEmision, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _filtroEstados);
                    //Fin Cristian Tarea 836
					_result = data.Tables[0];
					break;
				}

				case "ProcesoCompletarFacturaCompras" :
				{
					if (_familiaComprobantes !="")
						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeComprasCabecera.TiposDeComprobantes");
						else
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
					if(_idTipoMovimiento != null && _idTipoMovimiento.Equals("-1")) _idTipoMovimiento = null;
                    //Cristian Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompraCabeceraPendienteItems( TiposDeComprobantes,_idProveedor,DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _idTipoMovimiento, _idSubTipoMovimiento);
					//Fin Tarea 836
                    _result = data.Tables[0];
					break;
				}

				case "ProcesoPrePagarPagarCompras" :
				{
					if (_familiaComprobantes !="")
						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes");
						else
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
                    //Cristian 20100917 tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesDeCompra( TiposDeComprobantes,_idProveedor,DesdeEmision, HastaEmision, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _filtroEstados);
					//Fin Cristian Tarea 836
                    _result = data.Tables[0];
					break;
				}

				case "ProcesoEditarPreOrdenDeCompra":
				{
                    //Cristian 20100920 Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarPreOrdenesDeCompraEditables( _idProveedor, _fechaDesde, _fechaHasta, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa);
					//Fin Tarea 836
                    _result = data.Tables[0];
					break;
				}

				case "ProcesoConsultarDetalleComprobantesDeCompras":
				{
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

					if (_familiaComprobantes !="")
						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
						{
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes");
							TiposDeComprobantes = TiposDeComprobantes + "," + Variables.GetValueString("ComprobantesDeComprasCabecera.TiposDeComprobantes");
						}
						else
							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
                    //Cristian Tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarDetalleComprobantesDeCompra( TiposDeComprobantes,_idProveedor,DesdeEmision, HastaEmision, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion , _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _filtroEstados,_idProducto, j1, j2, j3, j4, j5, j6, j7, j8);
					//Fin Tarea 836
                    _result = data.Tables[0];
					break;
				}

				case "ProcesoEditarComprobanteServicios":
				{
					// ---- Matias - 20090706
					// Comentado para que tenga en cuenta los comprobantes definidos en _tiposDeComprobantesOrigen
					// Tarea 197 - Customizacion.
//					if (_familiaComprobantes !="")
//						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
//
//							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes");
//						else
//							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					
                    //Cristian 20100917 Tarea 836
                    System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobanteDeCompraCabeceraEditables( _tiposDeComprobantesOrigen, _idProveedor, DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, DesdeRecepcion, HastaRecepcion,DesdeRegistracion, HastaRegistracion ,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa);
					//Fin Cristian Tarea 836
                    
                    _result = data.Tables[0];
					break;
				}
				//Sabrina: Tarea 62
				case "ProcesoEditarComprobantesFacturasCompras":
				{
//					if (_familiaComprobantes !="")
//						if (_familiaComprobantes == Constantes.TodosLosComprobantes)
//
//							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes");
//						else
//							TiposDeComprobantes = Variables.GetValueString("ComprobantesDeCompras.TiposDeComprobantes."+_familiaComprobantes);
					//Cristian 20100920 Tarea 836
                    System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarComprobanteDeCompraCabeceraEditables( _tiposDeComprobantesOrigen, _idProveedor, DesdeEmision, HastaEmision, DesdeVencimiento, HastaVencimiento, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa);
                    //Fin Tarea 836
					_result = data.Tables[0];
					break;
					// ---- Fin Matias - 20090706
				}
				case "ProcesoPredebitarCompras":
				{
					_result = mz.erp.businessrules.reportes.rep_ConsultarComprobantesDeCompra.GetListComprobantesPendientesDePreNotaDeDebito(TiposDeComprobantes, _idProveedor, _fechaDesde, _fechaHasta, DesdeRegistracion, HastaRegistracion, _responsableEmision, 1, 1, _tiposDeComprobanteDestinoExcluidos).Tables[0];
					break;
				}
				default: /*Se usa para simular a la tarea ComprobantesDeCompraPendientes*/
				{
					bool verHTML = false;
					if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
						verHTML = true;
                    //Cristian 20100920 tarea 836
					System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesDeComprasPendientes( _tiposDeComprobantesOrigen,_tiposDeComprobantesDestino,_idProveedor, DesdeEmision, HastaEmision, DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion,  _responsableEmision, Security.IdSucursal, Security.IdEmpresa, verHTML, _tiposDeComprobanteDestinoExcluidos);
					//Fin Cristian Tarea 836
                    _result = data.Tables[0];
				}break;
			}

			if (this.DataChanged != null)
			{
				this.DataChanged(this, new System.EventArgs() );
			}

		}

        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110719
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong("Momentos." + this._taskName + "." + _processManager.Process.ProcessName + ".RangoFechas.DiasAnteriores");
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
               else{
                       if (this.FechaDesde > fecha)
                       {
                           _fechaDesde = Util.GenerateFechaHasta(fecha, dias); 
                       }
                       
                   }//End ELSE
          
        }

        //Fin Cristian 20110719
        //Fin Cristian
		public void ResetFilters()
		{
			this.Init();			
		}

		#endregion

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

	}
}
