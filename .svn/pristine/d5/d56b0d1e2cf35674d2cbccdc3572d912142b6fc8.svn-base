using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultaValores.
	/// </summary>   
	public class ConsultaValores: ITask
	{
		public ConsultaValores()
		{
			
		}

		public ConsultaValores(string ProcessName, string TaskName, string IdInstanciaCaja)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			//Aca deberia buscar q caja es esa instancia, debe ser cuando viene de otro lado :)
			_idCajas=mz.erp.businessrules.tfi_InstanciasCaja.GetCajaByPkIdInstanciaCaja( IdInstanciaCaja);
			//_idCajas = IdInstanciaCaja;
			_permiteSeleccionarIdInstanciaCaja = false;
			
			Init();
		}

		#region Variables Privadas ITask

			
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		private string _processName = string.Empty;
		private string _taskName = string.Empty;

		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler ModelChanged;
		public event System.EventHandler KeyFamiliaChanged;
		

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
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			System.Console.WriteLine("Te cache");
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
				System.Console.WriteLine("Aca ta");
		}

		private bool _allowEmptySelection = false;
		private bool _allowMultipleSelection = false;

		private DataSet _tdcompTesoreriaFamilias = new DataSet();
		public void Init()
		{
			_idTDCompTesoreria = Variables.GetValueString(this._processName, this._taskName, "ComprobanteTesoreriaDefault");
			if(_idTDCompTesoreria.Equals(string.Empty))
			{
				_idTDCompTesoreria = Variables.GetValueString("Valores.Buscador.ComprobanteTesoreriaDefault");
			}
			GetListaEntidades();
			/*_listaComprobantesTesoreriaBD = mz.erp.businessrules.tfi_TDCompTesoreria.GetListEx().Tables[0];
			_listaComprobantesTesoreriaBD = VariablesListComparer.FilterDataTable(_processName,
													_taskName, "ListaComprobantesTesoreria", 
													"IdTDCompTesoreria", _listaComprobantesTesoreriaBD);*/
			_listaInstaciasCaja = mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0];
			_idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_allowEmptySelection = Variables.GetValueBool(this._processName, this._taskName, "PermiteSeleccionVacia", _allowEmptySelection);
			_permiteCajaOtrosUsuarios=Variables.GetValueBool(this._processName, this._taskName, "PermiteCajaOtrosUsuarios","ConsultaValores.PermiteCajaOtrosUsuarios");
			_permiteSoloUnaCaja=Variables.GetValueBool(this._processName, this._taskName, "PermiteSoloUnaCaja");
			_allowMultipleSelection = Variables.GetValueBool(this._processName, this._taskName, "PermiteSeleccionMultiple", _allowMultipleSelection);
			//Se usa para procesos q necesitan buscar valores con un estado particular,ej: para depositar se buscan cheques en cartera
			IdEstadoCheque=Variables.GetValueString(this._processName, this._taskName, "EstadoDelValor");
			/*_listaComprobantesTesoreriaFiltrada = new DataTable();
			_listaComprobantesTesoreriaFiltrada.Columns.Add("IDTDCompTesoreria");
			_listaComprobantesTesoreriaFiltrada.Columns.Add("Descripcion");*/
			//FiltrarTDCompTesoreria();
			_filtroCajas = build_ArrayCajas( loadCajasAConsultar() );
			//Si es el proceso deposito deberia solo traer cheques de tercero y cheques de clientes
			string _comprobantesBusqueda=Variables.GetValueString(this._processName, this._taskName, "ListaComprobantesTesoreriaAMostrar");
			if (!_comprobantesBusqueda.Equals(string.Empty))
				_listaComprobantesTesoreriaBDConJerarquia=CrearListaJerarquiasPorComprobanteTesoreria(_comprobantesBusqueda);
			else 
				_listaComprobantesTesoreriaBDConJerarquia=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListByNivel(0);
				
			this.BuscarComprobanteTesoreria(_comprobantesBusqueda);
			this.BuscarClavesHijas();
			//Cargo las claves largas para saber si es un cheque,tarjeta o retencion
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows){
				_familiasPorClaveLarga[fila["Jerarquia"]]=fila["ClaveLarga"];
				
			}

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

		public string GetProcessName()
		{
			return _processName;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			if(!_allowEmptySelection)
			{
				if(this.GetValores().Count == 0 )
				{
					_errores.Add( new ItemDatasetError( this._processName,"No se han Seleccionado Valores","Debe seleccionar el Valor que desea modificar"));
					IsValid = false;
				}
			}
			if(!_allowMultipleSelection)
			{
				if(this.GetValores().Count > 1 )
				{
					_errores.Add( new ItemDatasetError( this._processName,"No se permite seleccionar mas de un valor","Debe seleccionar el Valor que desea modificar"));
					IsValid = false;
				}
			}

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
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
			_processName = processManager.Process.ProcessName;
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
			//Carga la informacion q necesita la siguiente tarea, solo la usa el deposito
			this.GetValoresADepositar();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region variables privadas 

		/*Datos Primarios*/
		private string _idValor = string.Empty;
		private string _idMoneda = string.Empty;
		private decimal _valorDesde = 0;
		private decimal _valorHasta = 0;
		private string _idTDCompTesoreria= string.Empty;
		private DateTime _fechaEmisionDesde = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaEmisionHasta = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimientoDesde = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimientoHasta = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idEntidad= string.Empty;
		private string _numero= string.Empty;
		private DatoAuxiliar _datoAuxiliar = new DatoAuxiliar();
		private string _idCajas = string.Empty;
		private string _idMonedaReferencia = string.Empty;
		private string _keyFamilia = string.Empty;
		private string _jerarquia = string.Empty;
		//Solo se configura para el proceso deposito q busca cheques bajo un estado particular
		private string _idEstadoCheque=string.Empty;
		private ArrayList _filtroCajas;
		private Hashtable _comprobantes=new Hashtable();
		private Hashtable _clavesCortasHijas=new Hashtable();
		private Hashtable _familiasPorClaveLarga=new Hashtable();
		//Hastable auxiliar
		private Hashtable _auxiliar=new Hashtable();

		
		/*Variables asociadas a los campos por los que se busca*/

		private bool _habilitaBusquedaMontoDesde = false;
		private bool _habilitaBusquedaMontoHasta = false;
		private bool _habilitaBusquedaFechaEmision = false;
		private bool _habilitaBusquedaFechaVencimiento = false;
		private bool _habilitaBusquedaCantidadCuotas = false;
		private bool _habilitaBusquedaFechaAcreditacion = false;
		private bool _habilitaBusquedaFechaAutorizacion = false;
		private bool _habilitaBusquedaFechaPago = false;
		private bool _habilitaBusquedaFechaRecepcion = false;
		private bool _habilitaBusquedaFechaIngresoBanco = false;
		private bool _habilitaBusquedaEntidad = false;
		private bool _habilitaBusquedaFechaIngresoRetencion = false;
		private bool _habilitaBusquedaFechaComprobanteRetencion = false;
		private bool _habilitaBusquedaTipoRetencion = false;
		private bool _permiteCajaOtrosUsuarios=false;
		private bool _permiteSoloUnaCaja=false;
		

		/*Variables asociadas a que propiedades se pueden cambiar */
		private bool _permiteSeleccionarIdInstanciaCaja = true;
			
		
		
		
		private DataTable _listaEntidades = new DataTable();
		private DataTable _listaComprobantesTesoreriaBD = new DataTable();
		private DataTable _listaComprobantesTesoreriaBDConJerarquia = new DataTable();
		private DataTable _listaComprobantesTesoreriaFiltrada = new DataTable();
		private DataTable _listaInstaciasCaja = new DataTable();
		private DataTable _listaComprobantesTesoreria= new DataTable();
		//Para el deposito bancario
		private DataView  _valoresDepositar=new DataView();
		#endregion 

		#region Propiedades
		
		public DataView  ValoresDepositar
		{
			get{return _valoresDepositar;}
			set{_valoresDepositar=value;}	
		
		}
		public string IdEstadoCheque{
			get{return _idEstadoCheque;}
			set{_idEstadoCheque=value;}		
		}
		public ArrayList FiltroCajas
		{
			get { return _filtroCajas ; }
			set { _filtroCajas = value ; }
		}
	/*	private void FiltrarTDCompTesoreria()
		{
			_listaComprobantesTesoreriaFiltrada.Clear();
			if(_keyFamilia.Equals(string.Empty))
			{

				foreach(DataRow row in _listaComprobantesTesoreriaBD.Rows)
				{
					string IDTDComp = Convert.ToString(row["IDTDCompTesoreria"]);
					string Desc = Convert.ToString(row["Descripcion"]);
					DataRow rowK = _listaComprobantesTesoreriaFiltrada.NewRow();
					rowK["IDTDCompTesoreria"] = IDTDComp;
					rowK["Descripcion"] = Desc;
					_listaComprobantesTesoreriaFiltrada.Rows.Add(rowK);
				}
			}
			else
			{
				string[] keys = _keyFamilia.Split(new char[]{','});
				foreach(DataRow row in _listaComprobantesTesoreriaBD.Rows)
				{
					string claveCorta = Convert.ToString(row["ClaveCorta"]);
					string IDTDComp = Convert.ToString(row["IDTDCompTesoreria"]);
					string Desc = Convert.ToString(row["Descripcion"]);
					foreach(string key in keys)
					{
						if(claveCorta.IndexOf(key) !=  -1)
						{
							DataRow rowK = _listaComprobantesTesoreriaFiltrada.NewRow();
							rowK["IDTDCompTesoreria"] = IDTDComp;
							rowK["Descripcion"] = Desc;
							_listaComprobantesTesoreriaFiltrada.Rows.Add(rowK);
							break;
						}

					}

				}
			}
			DataRow rowK1 = _listaComprobantesTesoreriaFiltrada.NewRow();
			rowK1["IDTDCompTesoreria"] = string.Empty;
			rowK1["Descripcion"] = string.Empty;
			_listaComprobantesTesoreriaFiltrada.Rows.Add(rowK1);
		}*/

		
	public string KeyFamilia
		{
			get{return _keyFamilia;}
			set
			{
				if(_keyFamilia != value)
				{
					_idTDCompTesoreria = string.Empty;
					_idEntidad = string.Empty;
					_keyFamilia = value;
					/*FiltrarTDCompTesoreria();*/
					GetListaEntidades();
					if(KeyFamiliaChanged!=null)
						KeyFamiliaChanged(this, new EventArgs());
					if(ModelChanged != null)
						ModelChanged(this, new EventArgs());
					

				}
			}
		}
		public string Jerarquia
		{
			get{return _jerarquia;}
			set
			{
				if(_jerarquia != value)
				{//Tengo q buscar las formas de pagos para esa flia
					_jerarquia=value;
					if(_jerarquia!=string.Empty && _jerarquia!=null)
					{
						_listaComprobantesTesoreria=(DataTable)_comprobantes[_jerarquia];
						KeyFamilia=Convert.ToString(_clavesCortasHijas[_jerarquia]);
					
					}
					else _keyFamilia=string.Empty;
					_idTDCompTesoreria = string.Empty;
					_idEntidad = string.Empty;
					
					/*_keyFamilia = value;
					FiltrarTDCompTesoreria();*/
					GetListaEntidades();
					if(ModelChanged != null)
						ModelChanged(this, new EventArgs());
					

				}
			}
		}
		public bool HabilitaBusquedaTipoRetencion
		{
			get{return _habilitaBusquedaTipoRetencion;}
			set{_habilitaBusquedaTipoRetencion = value;}
		}

		
		public bool HabilitaBusquedaFechaComprobanteRetencion
		{
			get{return _habilitaBusquedaFechaComprobanteRetencion;}
			set{_habilitaBusquedaFechaComprobanteRetencion = value;}
		}


		public bool HabilitaBusquedaFechaIngresoRetencion
		{
			get{return _habilitaBusquedaFechaIngresoRetencion;}
			set{_habilitaBusquedaFechaIngresoRetencion = value;}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				valor = Variables.GetValueString(this._processName, this._taskName,"TextoBotonAnterior");
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
				valor = Variables.GetValueString(this._processName, this._taskName,"TextoBotonSiguiente");
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

		public bool PreguntarAlCancelar
		{
			get 
			{
                /* Silvina 20100831 - Tarea 822 */
				//bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
                bool _preguntarAlCancelar = Variables.GetValueBool(_processName, _taskName, "PreguntarAlCancelar", false);
                /* Fin Silvina */
				return _preguntarAlCancelar ;}
		}

		public bool PermiteSeleccionarIdInstanciaCaja
		{
			get{return _permiteSeleccionarIdInstanciaCaja;}
		}

		public bool HabilitaBusquedaEntidad
		{
			get{return _habilitaBusquedaEntidad;}
			set{_habilitaBusquedaEntidad = value;}
		}


		public bool PermiteCajaOtrosUsuarios
		{
			get{return _permiteCajaOtrosUsuarios;}
			set{_permiteCajaOtrosUsuarios = value;}
		}

		public bool PermiteSoloUnaCaja
		{
			get{return _permiteSoloUnaCaja;}
			set{_permiteSoloUnaCaja = value;}
		
		}
		public bool HabilitaBusquedaMontoHasta
		{
			get{return _habilitaBusquedaMontoHasta;}
			set{_habilitaBusquedaMontoHasta = value;}
		}

		public bool HabilitaBusquedaMontoDesde
		{
			get{return _habilitaBusquedaMontoDesde;}
			set{_habilitaBusquedaMontoDesde = value;}
		}

		public bool HabilitaBusquedaFechaIngresoBanco
		{
			get{return _habilitaBusquedaFechaIngresoBanco;}
			set{_habilitaBusquedaFechaIngresoBanco = value;}
		}

		public bool HabilitaBusquedaFechaRecepcion
		{
			get{return _habilitaBusquedaFechaRecepcion;}
			set{_habilitaBusquedaFechaRecepcion = value;}
		}

		public bool HabilitaBusquedaFechaPago
		{
			get{return _habilitaBusquedaFechaPago;}
			set{_habilitaBusquedaFechaPago = value;}
		}

		public bool HabilitaBusquedaFechaAutorizacion
		{
			get{return _habilitaBusquedaFechaAutorizacion;}
			set{_habilitaBusquedaFechaAutorizacion = value;}
		}


		public bool HabilitaBusquedaFechaAcreditacion
		{
			get{return _habilitaBusquedaFechaAcreditacion;}
			set{_habilitaBusquedaFechaAcreditacion = value;}
		}


		public bool HabilitaBusquedaCantidadCuotas
		{
			get{return _habilitaBusquedaCantidadCuotas;}
			set{_habilitaBusquedaCantidadCuotas = value;}
		}



		public bool HabilitaBusquedaFechaVencimiento
		{
			get{return _habilitaBusquedaFechaVencimiento;}
			set{_habilitaBusquedaFechaVencimiento = value;}
		}


		public bool HabilitaBusquedaFechaEmision
		{
			get{return _habilitaBusquedaFechaEmision;}
			set{_habilitaBusquedaFechaEmision = value;}
		}



		

		public string IdMonedaReferencia
		{
			get{return _idMonedaReferencia;}
		}

	
		public DataTable ListaInstaciasCaja
		{
			get{return _listaInstaciasCaja;}
		}

		public DataTable ListaEntidades
		{
			get{return _listaEntidades;}
		}

		public DataTable ListaComprobantesTesoreriaFiltrada
		{
			get{return _listaComprobantesTesoreriaFiltrada;}
		}

		public DataTable ListaComprobantesTesoreria
		{
			get{return _listaComprobantesTesoreria;}
		}
		
		//En realidad maneja idCaja
		public string IdCajas
		{
			get{return _idCajas;}
			set{_idCajas = value;}
		}
		/*
		 * */
		public decimal  MontoDesde
		{
			get{return _valorDesde;}
			set{_valorDesde = value;}
		}

		public decimal  MontoHasta
		{
			get{return _valorHasta;}
			set{_valorHasta = value;}
		}
		
		public string  IdEntidad
		{
			get	{	return _idEntidad;	}
			set	{_idEntidad = value;}	
		}

		public string  Numero
		{
			get	{	return _numero;		}
			set	{	_numero = value;	}
		}
	
		public DateTime FechaEmisionDesde
		{
			get	{	return _fechaEmisionDesde;	}
			set	{_fechaEmisionDesde = value;}

		}
		public DateTime FechaEmisionHasta
		{
			get	{	return _fechaEmisionHasta;	}
			set	{_fechaEmisionHasta = value;}

		}

		public DateTime FechaVencimientoDesde
		{
			get	{return _fechaVencimientoDesde;	}
			set	{_fechaVencimientoDesde = value;}
		}


		public DateTime FechaVencimientoHasta
		{
			get	{return _fechaVencimientoHasta;	}
			set	{_fechaVencimientoHasta = value;}
		}

		public string  IdMoneda
		{
			get{return _idMoneda;}
			set{_idMoneda = value;}
		}

		public string IdTDCompTesoreria
		{
			set 
			{
				if (_idTDCompTesoreria  != value)
				{
					_idTDCompTesoreria = value;
					if (value != null && value != "")
					{
						GetListaEntidades();
						_idEntidad = string.Empty;
					}
					if ( ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}					
				}	
			}	
			get {return _idTDCompTesoreria; }
		}

		
		public string CodigoAutorizacion
		{
			set { _datoAuxiliar.CodigoAutorizacion = value;}
			get { return _datoAuxiliar.CodigoAutorizacion;}
		}

		public string Cupon
		{
			set { _datoAuxiliar.Cupon = value;}
			get { return _datoAuxiliar.Cupon;}
		}
		public DateTime FechaDeAcreditacion
		{
			set { _datoAuxiliar.FechaDeAcreditacion = value;}
			get { return _datoAuxiliar.FechaDeAcreditacion;}
		}
		public DateTime FechaDeAutorizacion
		{
			set { _datoAuxiliar.FechaDeAutorizacion = value;}
			get { return _datoAuxiliar.FechaDeAutorizacion;}
		}
		public string Lote
		{
			set { _datoAuxiliar.Lote = value;}
			get { return _datoAuxiliar.Lote;}
		}
		public short CantidadCuotas
		{
			set { _datoAuxiliar.CantidadCuotas = value;}
			get { return _datoAuxiliar.CantidadCuotas;}
		}
		public string CuentaBancaria
		{
			set { _datoAuxiliar.CuentaBancaria = value;}
			get { return _datoAuxiliar.CuentaBancaria;}
		}
		public string Librador
		{
			set { _datoAuxiliar.Librador = value;}
			get { return _datoAuxiliar.Librador;}
		}
		public string Sucursal
		{
			set { _datoAuxiliar.Sucursal = value;}
			get { return _datoAuxiliar.Sucursal;}
		}
		public DateTime FechaDePago
		{
			set { _datoAuxiliar.FechaDePago = value;}
			get { return _datoAuxiliar.FechaDePago;}
		}
		public DateTime FechaDeRecepcion
		{
			set { _datoAuxiliar.FechaDeRecepcion = value;}
			get { return _datoAuxiliar.FechaDeRecepcion;}
		}

		public string IdCuenta
		{
			get	{ return _datoAuxiliar.IdCuenta;}
			set	{_datoAuxiliar.IdCuenta= value;	}
		}

		public string NroBoleta
		{
			set {_datoAuxiliar.NroBoleta = value;}
			get {return _datoAuxiliar.NroBoleta;}
		}

		public string CodigoDiez
		{
			set {_datoAuxiliar.CodigoDiez= value;}
			get {return _datoAuxiliar.CodigoDiez;}
		}

		public DateTime FechaIngresoBanco
		{
			set {_datoAuxiliar.FechaIngresoBanco= value;}
			get {return _datoAuxiliar.FechaIngresoBanco;}
		}

		public string IdTipoDeRetencion
		{
			get{ return _datoAuxiliar.IdTipoDeRetencion; }
			set{ _datoAuxiliar.IdTipoDeRetencion = value; }
		}

		public DateTime FechaComprobanteRetencion
		{
			set { _datoAuxiliar.FechaComprobanteRetencion = value;}
			get { return _datoAuxiliar.FechaComprobanteRetencion;}
		}
		public DateTime FechaIngresoRetencion
		{
			set { _datoAuxiliar.FechaIngresoRetencion = value;}
			get { return _datoAuxiliar.FechaIngresoRetencion;}
		}


		

		#endregion

		#region Metodos Privados
		//Dependiendo del valor de _permiteCajaOtrosUsuarios, trae o no todas las cajas
		private ArrayList loadCajasAConsultar()
		{
			return mz.erp.businessrules.tfi_InstanciasCaja.GetListParaConsultaValores(Security.IdPersona,_permiteCajaOtrosUsuarios);
		}
		private void GetListaEntidades()
		{
			string IdTdComp = !_idTDCompTesoreria.Equals(string.Empty)?_idTDCompTesoreria:ObtenerComprobantesParaEntidades();
			_listaEntidades = businessrules.tfi_TDCompTesoreria_Entidades.GetListEx(IdTdComp, true).Tables[0];
			
		}
		public void SeleccionarFamilia()
		{
			
			//this.Jerarquia=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia.Rows[0]["jerarquia"]);
			_listaComprobantesTesoreria.Columns.Add("IdTDcompTesoreria");
			_listaComprobantesTesoreria.Columns.Add("Descripcion");
			System.Data.DataRow row = _listaComprobantesTesoreria.NewRow();
			row["IdTDcompTesoreria"] = -1;
			row["Descripcion"] = "<Ninguno>";
			_listaComprobantesTesoreria.Rows.Add(row);
		}

		private void BuscarComprobanteTesoreria(string ListaComprobantesTesoreria ){
			if(ListaComprobantesTesoreria.Equals(string.Empty)){
				foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
				{
					_comprobantes[fila["Jerarquia"]]=mz.erp.businessrules.tfi_TDCompTesoreria.GetListByJerarquia(Convert.ToString(fila["Jerarquia"]));
				}
				}
			else{
				//Si hay una lista de comprobantes de tesoreria solo deberian de quedar esos :S
					DataTable com=new DataTable();
					
					foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
					{
						DataTable result=new DataTable();
						result.Columns.Add("idTdCompTesoreria");
						result.Columns.Add("Descripcion");
						ArrayList comprobantesParaJerarquia=(ArrayList)_auxiliar[fila["Jerarquia"]];
						com=mz.erp.businessrules.tfi_TDCompTesoreria.GetListByJerarquia(Convert.ToString(fila["Jerarquia"]));
						foreach (DataRow f in com.Rows){
							if (comprobantesParaJerarquia.Contains( Convert.ToString(f["idTdCompTesoreria"])))
							{
								System.Data.DataRow row=result.NewRow();
								row["idTdCompTesoreria"]= Convert.ToString(f["idTdCompTesoreria"]);
								row["Descripcion"]= Convert.ToString(f["Descripcion"]);
								result.Rows.Add(row);
							}

						}
						_comprobantes[fila["Jerarquia"]]=result;
						
					}
				
			}
		}

		private void BuscarClavesHijas(){
			DataTable result=new DataTable();
			
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{	//ArrayList keys=new ArrayList();
				string keys=string.Empty;
				result=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListByNivelAndPadre(1,Convert.ToString(fila["Jerarquia"]));
				if(result.Rows.Count!=0){
					foreach (DataRow r in result.Rows){
						keys= keys+Convert.ToString(r["ClaveCorta"])+',';
					}
				  }
				 //TC,TD,Retenciones no tienen hijos entonces van sus keys
				 else
					keys= keys + Convert.ToString(fila["ClaveCorta"]);
			_clavesCortasHijas[fila["Jerarquia"]]=keys;
			}
			
		}

//A partir de los comprobantes de tesoreria crea las jerarquias correspondientes
		private DataTable CrearListaJerarquiasPorComprobanteTesoreria(string ListaComprobantesTesoreria){
			//System.Data.DataTable jerarquias=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListByNivel(0);
			ArrayList aux=systemframework.Util.Parse(ListaComprobantesTesoreria, ",");
			Hashtable jerarquiasReales=new Hashtable();
			foreach (string comprobante in aux){
			//Busco las jerarquias a las q pertenece cada uno, para solo dejar las jerarquias de las q hay comprobantes de tesoreria
				mz.erp.commontypes.data.tfi_AgrupTDCompTesoreriaDataset data= tfi_AgrupTDCompTesoreria.GetList(comprobante,string.Empty);
				string jerarquia=Convert.ToString(data.Tables[0].Rows[0]["Jerarquia"]);
				string jerarquiaNueva=jerarquia.Substring(0,20);
				if (!jerarquiasReales.ContainsKey(jerarquiaNueva))
					jerarquiasReales[jerarquiaNueva]=new ArrayList();
			ArrayList datos=(ArrayList)jerarquiasReales[jerarquiaNueva];
			datos.Add(comprobante);
			jerarquiasReales[jerarquiaNueva]=datos;
			}
			//Creo la tabla con las jerarquias q quedaron
			System.Data.DataTable result= new DataTable();
			result.Columns.Add("Jerarquia");
			result.Columns.Add("Descripcion");
			result.Columns.Add("ClaveCorta");
			result.Columns.Add("ClaveLarga");
			foreach (string j in jerarquiasReales.Keys){
				System.Data.DataRow row = result.NewRow();
				mz.erp.commontypes.data.tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow fila=tfi_JerarquiaAgrupTDCompTesoreria.GetByPk(j);
				row["Jerarquia"] = Convert.ToString(fila["IdNomenclatura"]);
				row["Descripcion"] = Convert.ToString(fila["descripcion"]);
				row["ClaveCorta"] = Convert.ToString(fila["ClaveCorta"]);
				row["ClaveLarga"] = Convert.ToString(fila["ClaveLarga"]);
				result.Rows.Add(row);}
			_auxiliar=jerarquiasReales;
			return result;
		
		}
		private ArrayList build_ArrayCajas(ArrayList _rango)
		{
			ArrayList _arrayCajas = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetListHashTable();
			foreach( string _idCaja in _rango )
			{	//Si va directamente a consulta de valores
				if (_idCajas.Equals(string.Empty))
				{
					if (_hash.ContainsKey( Convert.ToString( _idCaja ) ))
					{	
						//_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), true) );
						_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), false) );
									
					}
				}
				else
				{//Viene de otro formulario, ejemplo devolucion de pago antes se bindeaba por idInstanciaCaja y no tenia q hacer esto :S
					if (_hash.ContainsKey( Convert.ToString( _idCaja ) ))
					{	if(_idCaja.Equals(_idCajas))
							_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), true) );
						//else
							//_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), false) );
					}
				}
			}
			return _arrayCajas;

		}


		#endregion

		#region Metodos Publicos

		/*public DataTable ListaComprobantesTesoreria()
		{
			return _listaComprobantesTesoreria;
					
		}*/
		public void Reset()
		{
			_idTDCompTesoreria = string.Empty;
			_keyFamilia = string.Empty;
			result.Clear();
		}

		public void Refresh(){
		string _idCajas=string.Empty;
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroCajas )
			{
				if (items.Sel)
				{
					_idCajas+= items.Id +',';
				}
			}
			this.IdCajas=_idCajas;
		}
	/*	public bool PerteneceFamiliaACheque(string familia)
		{
			return MAPStaticInfo.PerteneceFamiliaACheque(familia);
		}
		
		public bool PerteneceFamiliaATarjeta(string familia)
		{
			return MAPStaticInfo.PerteneceFamiliaATarjeta(familia);
		}

		public bool PertenceFamiliaARetenciones(string familia)
		{
			return MAPStaticInfo.PertenceFamiliaARetenciones(familia);
		}
		public bool PerteneceATerceros(string idFormaDePago)
		{
			return MAPStaticInfo.PerteneceATerceros(idFormaDePago);
		}
*/

		public bool PerteneceACheque()
		{
		 if (!Jerarquia.Equals(string.Empty) && Jerarquia!=null )
			return (_familiasPorClaveLarga[Jerarquia].Equals("Cheques"));
		return false;
		}
		
		

		public bool PerteneceATarjeta()
		{ if (!Jerarquia.Equals(string.Empty) && Jerarquia!=null )
			return (_familiasPorClaveLarga[Jerarquia].Equals("Tarjetas"));
		 return false;
			/*if(!_idTDCompTesoreria.Equals(string.Empty))
				return MAPStaticInfo.PerteneceATarjeta(_idTDCompTesoreria);
			else
			{
				return MAPStaticInfo.PerteneceFamiliaATarjeta(_keyFamilia);
			}*/
		}

		public bool PertenceARetenciones()
		{
			 if (!Jerarquia.Equals(string.Empty) && Jerarquia!=null )
				return (_familiasPorClaveLarga[Jerarquia].Equals("Retenciones"));
			return false;
			/*if(!_idTDCompTesoreria.Equals(string.Empty))
				return MAPStaticInfo.PertenceARetenciones(_idTDCompTesoreria);
			else
			{
				return MAPStaticInfo.PertenceFamiliaARetenciones(_keyFamilia);
			}*/
		}

		public bool ChequeDiferido(string idFormaDePago)
		{
			return MAPStaticInfo.ChequeDiferido(idFormaDePago);
		}

		public string GetClaveCorta(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.GetBDFDP(IdTDCompTesoreria);
		}

		public DataTable GetTableFamiliasTDCompTesoreria()
		{
			//return MAPStaticInfo.GetTableFamiliasTDCompTesoreria();
			
			DataTable _tableFamiliasTDCompTesoreria = new DataTable();
			_tableFamiliasTDCompTesoreria.Columns.Add("Jerarquia");
			_tableFamiliasTDCompTesoreria.Columns.Add("Description");
			//DataRow rowt = _tableFamiliasTDCompTesoreria.NewRow();
			//rowt["Jerarquia"] = -1;
			//rowt["Description"] ="";
			//_tableFamiliasTDCompTesoreria.Rows.Add(rowt);
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows){
				DataRow row0 = _tableFamiliasTDCompTesoreria.NewRow();
				row0["Jerarquia"] = fila["Jerarquia"];
				row0["Description"] = fila["Descripcion"];
				_tableFamiliasTDCompTesoreria.Rows.Add(row0);}
			return _tableFamiliasTDCompTesoreria;
		}

		DataTable result = new DataTable();

		public DataTable Result 
		{
			get{return result;}
		}


		/*private string ObtenerCompTesoreriasFamilia()
		{
			string result = string.Empty;
			foreach(DataRow row in _listaComprobantesTesoreriaFiltrada.Rows)
			{
				string IdTDComp = Convert.ToString(row["IdTDCompTesoreria"]);
				result = result + IdTDComp + ",";

			}
			return result;
			
			
		}*/
		private string ObtenerComprobantesParaEntidades()
		{
			string result = string.Empty;
			foreach(DataRow row in _listaComprobantesTesoreria.Rows)
			{
				string IdTDComp = Convert.ToString(row["IdTDCompTesoreria"]);
				if(IdTDComp.Equals(this.IdTDCompTesoreria))	
						result = result + IdTDComp + ",";

			}
			return result;
			
			
			
		}

		public DataView Search()
		{
			
			
			
			/*Parametros generlaes*/
			string IdTDCompTesoreria = _idTDCompTesoreria;
			string IdCajas = _idCajas;
			string Numero = _numero;
			string IdEntidad = _habilitaBusquedaEntidad?_idEntidad:string.Empty;
			DateTime FechaEmisionDesde = _habilitaBusquedaFechaEmision?_fechaEmisionDesde:DateTime.MinValue;
			DateTime FechaEmisionHasta = _habilitaBusquedaFechaEmision?_fechaEmisionHasta:DateTime.MinValue;
			DateTime FechaVencimientoDesde = _habilitaBusquedaFechaVencimiento?_fechaVencimientoDesde:DateTime.MinValue;
			DateTime FechaVencimientoHasta = _habilitaBusquedaFechaVencimiento?_fechaVencimientoHasta:DateTime.MinValue;
			decimal MontoDesde = _habilitaBusquedaMontoDesde? _valorDesde:decimal.MinValue;
			decimal MontoHasta = _habilitaBusquedaMontoHasta? _valorHasta:decimal.MinValue;
			string IdMoneda = _habilitaBusquedaMontoHasta? _idMoneda:string.Empty;
			if(PerteneceACheque())
			{
				string Jerar= !_idTDCompTesoreria.Equals(string.Empty)?string.Empty:_jerarquia;
				//	string IdTdComp = !_idTDCompTesoreria.Equals(string.Empty)?_idTDCompTesoreria:ObtenerCompTesoreriasFamilia();
				DateTime FechaRecepcionDesde = _habilitaBusquedaFechaRecepcion? mz.erp.systemframework.Util.GetStartDay(_datoAuxiliar.FechaDeRecepcion):DateTime.MinValue;
				DateTime FechaRecepcionHasta = _habilitaBusquedaFechaRecepcion?mz.erp.systemframework.Util.GetEndDay(_datoAuxiliar.FechaDeRecepcion):DateTime.MinValue;
				DateTime FechaPagoDesde = _habilitaBusquedaFechaPago? mz.erp.systemframework.Util.GetStartDay(_datoAuxiliar.FechaDePago):DateTime.MinValue;
				DateTime FechaPagoHasta = _habilitaBusquedaFechaPago? mz.erp.systemframework.Util.GetEndDay(_datoAuxiliar.FechaDePago):DateTime.MinValue;
				DateTime FechaIngresoBancoDesde = _habilitaBusquedaFechaIngresoBanco? mz.erp.systemframework.Util.GetStartDay(_datoAuxiliar.FechaIngresoBanco):DateTime.MinValue;
				DateTime FechaIngresoBancoHasta = _habilitaBusquedaFechaIngresoBanco? mz.erp.systemframework.Util.GetEndDay(_datoAuxiliar.FechaIngresoBanco):DateTime.MinValue;
				string NroBoleta = _datoAuxiliar.NroBoleta;
				string CuentaBancaria = _datoAuxiliar.CuentaBancaria;
				string Librador = _datoAuxiliar.Librador;
				string Sucursal = _datoAuxiliar.Sucursal;
				result = mz.erp.dataaccess.tfi_Valores.SearchCheques(Jerar,_idTDCompTesoreria, IdCajas, Numero,
					IdEntidad, FechaEmisionDesde, FechaEmisionHasta, FechaVencimientoDesde, FechaVencimientoHasta,
					MontoDesde, MontoHasta, IdMoneda ,FechaRecepcionDesde, FechaRecepcionHasta, FechaPagoDesde, FechaPagoHasta,
					FechaIngresoBancoDesde, FechaIngresoBancoHasta, NroBoleta, CuentaBancaria, Librador, Sucursal,IdEstadoCheque);
	
			}
			if(PerteneceATarjeta())
			{

				string Jerar= !_idTDCompTesoreria.Equals(string.Empty)?string.Empty:_jerarquia;
				DateTime FechaDeAcreditacionDesde = _habilitaBusquedaFechaAcreditacion? mz.erp.systemframework.Util.GetStartDay(_datoAuxiliar.FechaDeAcreditacion):DateTime.MinValue;
				DateTime FechaDeAcreditacionHasta = _habilitaBusquedaFechaAcreditacion? mz.erp.systemframework.Util.GetEndDay(_datoAuxiliar.FechaDeAcreditacion):DateTime.MinValue;;
				DateTime FechaDeAutorizacionDesde = _habilitaBusquedaFechaAutorizacion? mz.erp.systemframework.Util.GetStartDay(_datoAuxiliar.FechaDeAutorizacion):DateTime.MinValue;
				DateTime FechaDeAutorizacionHasta = _habilitaBusquedaFechaAutorizacion? mz.erp.systemframework.Util.GetEndDay(_datoAuxiliar.FechaDeAutorizacion):DateTime.MinValue;

				string CodigoAutorizacion = _datoAuxiliar.CodigoAutorizacion;
				string Cupon = _datoAuxiliar.Cupon;
				string Lote= _datoAuxiliar.Lote;
				short CantidadCuotas = _habilitaBusquedaCantidadCuotas?_datoAuxiliar.CantidadCuotas:short.MinValue;
				string CodigoDiez = _datoAuxiliar.CodigoDiez;
				result = mz.erp.dataaccess.tfi_Valores.SearchTarjetas(Jerar,_idTDCompTesoreria,IdCajas, Numero,
					IdEntidad, FechaEmisionDesde, FechaEmisionHasta, FechaVencimientoDesde, FechaVencimientoHasta,
					MontoDesde, MontoHasta, IdMoneda,FechaDeAcreditacionDesde, FechaDeAcreditacionHasta, FechaDeAutorizacionDesde,
					FechaDeAutorizacionHasta, CodigoAutorizacion, Cupon, Lote, CodigoDiez, CantidadCuotas);
				
			}
			if(PertenceARetenciones())
			{
				string Jerar= !_idTDCompTesoreria.Equals(string.Empty)?string.Empty:_jerarquia;
				//string IdTdComp = !_idTDCompTesoreria.Equals(string.Empty)?_idTDCompTesoreria:ObtenerCompTesoreriasFamilia();
				string TipoRetencion = _habilitaBusquedaTipoRetencion?_datoAuxiliar.IdTipoDeRetencion:string.Empty;
				DateTime FechaIngresoRetencionDesde = _habilitaBusquedaFechaIngresoRetencion?_datoAuxiliar.FechaIngresoRetencion:DateTime.MinValue;
				DateTime FechaIngresoRetencionHasta = _habilitaBusquedaFechaIngresoRetencion?_datoAuxiliar.FechaIngresoRetencion:DateTime.MinValue;
				DateTime FechaRetencionDesde = _habilitaBusquedaFechaComprobanteRetencion?_datoAuxiliar.FechaComprobanteRetencion:DateTime.MinValue;
				DateTime FechaRetencionHasta = _habilitaBusquedaFechaComprobanteRetencion?_datoAuxiliar.FechaComprobanteRetencion:DateTime.MinValue;
				
				
				result = mz.erp.dataaccess.tfi_Valores.SearchRetenciones(Jerar,_idTDCompTesoreria, IdCajas, Numero,
					IdEntidad, FechaEmisionDesde, FechaEmisionHasta, FechaVencimientoDesde, FechaVencimientoHasta,
					MontoDesde, MontoHasta, IdMoneda , FechaIngresoRetencionDesde, FechaIngresoRetencionHasta,
					FechaRetencionDesde, FechaRetencionHasta, TipoRetencion);
				
				
				
							
			}
			if(!result.Columns.Contains("Seleccion"))
				result = commontypes.AddColumn.AddColumnToTable(result, "Seleccion", false);
			return result.DefaultView;
		}

		public ArrayList GetValores()
		{
			ArrayList aux = new ArrayList();
			if (result.Rows.Count>0)
			{
		
				DataView resultView = new DataView(result,"Seleccion = true", null,System.Data.DataViewRowState.CurrentRows);
				foreach(DataRowView row in resultView)
				{
					string IdValor = Convert.ToString(row["IdValor"]);
					Valor valor = new Valor(IdValor, null, null);
					aux.Add(valor);
				}
			}

			return aux;
		}

		public void GetValoresADepositar()
		{
			//Retorna todas las filas seleccionadas de la grilla, result es el datasource de la grilla
			if (result.Rows.Count>0){
				DataView resultView = new DataView(result,"Seleccion = true", null,System.Data.DataViewRowState.CurrentRows);
				this.ValoresDepositar=resultView;}
		}
        
        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110725
        public void updateFechas(DateTime fecha, string tipoFecha,bool ordenInverso)
        {
            //German 20120727 - Tarea 363
            long dias = 0;
            if (this._processParent != null)
                dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            //Fin German 20120727 - Tarea 363
            switch (tipoFecha)
            {
                case "EMISION": if (!ordenInverso)
                                { this._fechaEmisionDesde = fecha; }
                                else { this._fechaEmisionHasta = fecha; };

                                if (!ordenInverso)
                                {
                                    if (this.FechaEmisionHasta < fecha)
                                    {
                                        _fechaEmisionHasta = Util.GenerateFechaHasta(fecha, dias);
                                    }
                                }
                                else
                                {
                                    if (this.FechaEmisionDesde > fecha)
                                    {
                                        _fechaEmisionDesde = Util.GenerateFechaHasta(fecha, dias);
                                    }

                                }//End ELSE  
                                break;
                case "VENCIMIENTO":
                               if (!ordenInverso)
                                { this._fechaVencimientoDesde = fecha; }
                                else { this._fechaVencimientoHasta = fecha; };

                                if (!ordenInverso)
                                {
                                    if (this.FechaVencimientoHasta < fecha)
                                    {
                                        _fechaVencimientoHasta = Util.GenerateFechaHasta(fecha, dias);
                                    }
                                }
                                else
                                {
                                    if (this.FechaVencimientoDesde > fecha)
                                    {
                                        _fechaVencimientoDesde = Util.GenerateFechaHasta(fecha, dias);
                                    }

                                }//End ELSE  
                                break;
 
            }

        }
        //Fin Cristian 20110725
        //Fin Cristian	
		#endregion
/*//Para agregar un registro mas q me olvide :S
 * System.Data.DataRow row = table.NewRow();
			row["IdTDcompTesoreria"] = -1;
			row["Descripcion"] = "<Ninguno>";
			table.Rows.Add(row);*/
	}
}
