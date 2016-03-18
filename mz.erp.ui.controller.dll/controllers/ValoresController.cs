using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.businessrules;
/* Silvina 20110222 - Tarea 0000012 */
using System.Data;
/* Fin Silvina */

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ValoresController.
	/// </summary>
	public class ValoresController: IObservable, ITaskController, IObservableController
	{
		public event EventHandler ObjectHasChanged;
		public event EventHandler IdTDCompTesoreriaChanged;	//se usa por el binding controller
		public event EventHandler ModelChanged;
		public event EventHandler OnTaskAfterExecute;
		public event EventHandler KeyValueProveedoresChanged;
		public event EventHandler IdEstadoChanged;

		
		#region Variables Privadas
			
			private Valor _valor;
			private string _idComprobanteTesoreria = string.Empty;
			private string _idMoneda = string.Empty;
			private decimal _valorDefault = 0;
        	private string  _idValor = string.Empty;
			private string _action = string.Empty;
			private bool _agrupado = false;
			private decimal _porcenatjeRecargo = 0;
			private bool _allowEditTDCompTesoreria = false;
			private bool _idTDCompTesoreriaReadOnly = false;
			private bool _allowEditMoneda = false;
			private bool _idMonedaOrigenReadOnly = false;
			private bool _valorDefaultReadOnly = false;
			private string _taskName = string.Empty;
			private string _processName = string.Empty;

			private ITaskController _taskController;
			
			private string _layoutVariablesAuxiliares = new mz.erp.ui.controllers.tfi_ValoresEx().GetLayoutVariablesAuxiliares();


			private bool _allowEditImporte = true;

            /* Silvina 20110222 - Tarea 0000012 */
            private bool _cambioTDComp = false;
            /* Fin Silvina */
			
		#endregion

		#region Constructores
		
		#region Workflow
		
		public ValoresController(Valor valor)
		{
			_valor = valor;//_model
			//_valor.State  = "EDIT";
			_valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(_valor_ValorChange);
			_valor.PrepareEdit();
			_taskName = valor.GetTaskName();
			
		}
		
		#endregion

		#region Obserber

		public ValoresController(Valor valor, decimal recargo, decimal monto, ITaskController taskController)
		{
			_porcenatjeRecargo = recargo;
			_idComprobanteTesoreria = valor.IdTDCompTesoreria;
			_idMoneda = valor.IdMoneda;
			_agrupado = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(_idComprobanteTesoreria).Agrupado;
			_idMonedaOrigenReadOnly = true;
			_idTDCompTesoreriaReadOnly = true;
			_idValor = valor.IdValor;
			_valor = valor;
			_valor.MontoSinRecargos = monto;
			//_valor.State  = "EDIT";
			_valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(_valor_ValorChange);
			_valor.PrepareEdit();
			_taskName = taskController.GetTaskName();
			_processName = taskController.GetProcessManager().GetProcessName();
			_valor.TaskName = _taskName;
			_valor.ProcessName = _processName;
		}
		

		
		
		public ValoresController(Valor valor, decimal recargo, ITaskController taskController)
		{
			_porcenatjeRecargo = recargo;
			_idComprobanteTesoreria = valor.IdTDCompTesoreria;
			_idMoneda = valor.IdMoneda;
			_agrupado = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(_idComprobanteTesoreria).Agrupado;
			_idMonedaOrigenReadOnly = true;
			_idTDCompTesoreriaReadOnly = true;
			_idValor = valor.IdValor;
			_valor = valor;
			//_valor.State  = "EDIT";
			_valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(_valor_ValorChange);
			_valor.PrepareEdit();
			_taskName = taskController.GetTaskName();
			_processName = taskController.GetProcessManager().GetProcessName();
			_valor.TaskName = _taskName;
			_valor.ProcessName = _processName;
		}
		


		public ValoresController(string IdComprobanteTesoreria, string IdMoneda, bool Agrupado, string IdValor, ITaskController taskController)
		{
			
			_taskName = taskController.GetTaskName();
			_processName = taskController.GetProcessManager().GetProcessName();
			_idComprobanteTesoreria = IdComprobanteTesoreria;
			_idMoneda = IdMoneda;
			_agrupado = Agrupado;
			_idMonedaOrigenReadOnly = true;
			_idTDCompTesoreriaReadOnly = true;
			_idValor = IdValor;
			Init();
			_valor.TaskName = _taskName;
			_valor.ProcessName = _processName;
		}


		public ValoresController(string IdComprobanteTesoreria, string IdMoneda, bool Agrupado, decimal ValorDefault, decimal porcentajeRecargo,  string IdValor, ITaskController taskController, string IdCliente)
        {
			_taskName = taskController.GetTaskName(); 
			_processName = taskController.GetProcessManager().GetProcessName();
			_idComprobanteTesoreria = IdComprobanteTesoreria;
			_idMoneda = IdMoneda;
			_valorDefault = System.Math.Abs(ValorDefault);
			_agrupado = Agrupado;
			_idMonedaOrigenReadOnly = true;
			_idTDCompTesoreriaReadOnly = true;

			_porcenatjeRecargo = porcentajeRecargo;
			_idValor = IdValor;
			Init();
			_valor.TaskName = _taskName;
			_valor.ProcessName = _processName;
			_valor.DatoAuxiliar.IdCuenta = IdCliente;
			if (IdCliente!= null && IdCliente != string.Empty)
			{
				_valor.DatoAuxiliar.Librador= mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCliente).Nombre;
			}
			else _valor.DatoAuxiliar.Librador = string.Empty;
		}
		#endregion

		#endregion

		#region Inicializacion

		private void Init()
		{
			_valor = new Valor(_idValor, _idComprobanteTesoreria,_idMoneda, _valorDefault);
			_valor.PrepareEdit();
			_valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(_valor_ValorChange);
			_valor.ObjectHasChanged +=new EventHandler(_valor_ObjectHasChanged);
		}

		#endregion

		#region Propiedades Publicas

		public bool AllowEditImportes
		{
			get{return _allowEditImporte;}
			set{_allowEditImporte = value;}
		}
		private object _keyValueProveedores = string.Empty;
		public object KeyValueProveedores
		{ 
			get {return _valor.IdProveedor;}
			set 
			{
				if (_keyValueProveedores!= value) 
				{
					_keyValueProveedores = value;
					_valor.IdProveedor = Convert.ToString(value);
					if(KeyValueProveedoresChanged != null)
						KeyValueProveedoresChanged(this, new EventArgs());	
				}				
			}		
		}
		public bool Cruzado
		{
			set {_valor.Cruzado = value;}
			get { return _valor.Cruzado;}
		}
		public bool Sellado
		{
			set { _valor.Sellado = value;}
			get { return _valor.Sellado;}
		}
		public System.Data.DataTable EstadosCheques
		{
			get {return _valor.EstadosCheques;}
		}
		public String NoIndica
		{
			get{return _valor.NoIndica;}
		}
		public String EnCarteraSinRetirar
		{
			get{ return _valor.EnCarteraSinRetirar;}
		}

		public String EnCartera
		{
			 get{ return _valor.EnCartera;}
		}

		public String IdEstado
		{
		get{ return _valor.IdEstado;}
		set{_valor.IdEstado=value;}
		}
		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
			}
		}
		public bool AllowEditImporte()
		{
			return _valor.AllowEditImporte() && _allowEditImporte;
		}

		public bool IncluyeRecargo
		{
			get{return _valor.IncluyeRecargos;}
			set{_valor.IncluyeRecargos = value;}
		}

		public string LayoutVariablesAuxiliares
		{
			get{return _layoutVariablesAuxiliares;}
		}
		public string IdMoneda
		{
			get{return _valor.IdMoneda;}
			set{_valor.IdMoneda = value;}
		}

		public string IdMonedaReferencia
		{
			get{return _valor.IdMonedaReferencia ;}
		}

		public string Numero
		{
			get	{return _valor.Numero;	}
			set	{_valor.Numero = value;	}
		}

		public string IdEntidad
		{
			get	{return _valor.IdEntidad;}
			set {_valor.IdEntidad = value;}
		}
		public string IdBanco
		{
			get	{return _valor.IdBanco;}
			set {_valor.IdBanco = value;}
		}
		public bool GetAgrupado()
		{
			return mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(IdTDCompTesoreria).Agrupado;
		}

		public decimal Monto
		{
			get
			{
				return _valor.Monto;
			}
            set
            {
                _valor.Monto = value;
                /* Silvina 20110901 - Tarea 0000206 */
                _valor.MontoCotizadoConRecargos = value + (value * _porcenatjeRecargo / 100);
                /* Fin Silvina 20110901 - Tarea 0000206 */
            }
		}

		/*public string IdCuenta
		{
			get
			{
				return _valor.IdCuenta;
			}
			set
			{
				_valor.IdCuenta = value;
			}
		}
		*/
		public decimal MontoCotizadoConRecargos
		{
            /* Silvina 20110901 - Tarea 0000206 */
            set {
                _valor.MontoCotizadoConRecargos = value;
                _valor.MontoCotizado = value / (_porcenatjeRecargo / 100 + 1);
            }
			get{//return MontoCotizado + (MontoCotizado * _porcenatjeRecargo /100);                
                if (_valor.MontoCotizadoConRecargos == 0)
                    _valor.MontoCotizadoConRecargos = _valor.MontoCotizado + (_valor.MontoCotizado * _porcenatjeRecargo / 100);
                return _valor.MontoCotizadoConRecargos;
            }
            /* Fin Silvina 20110901 - Tarea 0000206 */
		}
		
		public decimal MontoCotizado
		{
			get	{return _valor.MontoCotizado;	}
			set	{_valor.MontoCotizado = value;
                /* Silvina 20110901 - Tarea 0000206 */
                 _valor.MontoCotizadoConRecargos = value + (value * _porcenatjeRecargo / 100);
                /* Fin Silvina 20110901 - Tarea 0000206 */
            }
		}
		public string Empresa
		{
			get{return _valor.Empresa();}
		}
		public string IdTDCompTesoreria
		{
			get	
			{
				return _valor.IdTDCompTesoreria;
			}
			set
			{
				if (value != null && value != _valor.IdTDCompTesoreria)
				{
                    /* Silvina 20110222 - Tarea 0000012 */
                    _cambioTDComp = true;
                    /* Fin Silvina */
					_valor.IdTDCompTesoreria = value;
					if(IdTDCompTesoreriaChanged != null)
						IdTDCompTesoreriaChanged(this, new EventArgs());
				}
                /* Silvina 20110222 - Tarea 0000012 */
                else
                    _cambioTDComp = false;
                /* Fin Silvina */
			}
		}

		public DateTime Fecha
		{
			get	{	return _valor.Fecha;	}
			set {	_valor.Fecha = value;	}
		}

		public DateTime FechaVencimiento
		{
			get	{return _valor.FechaVencimiento;}
			set	{_valor.FechaVencimiento = value;	}
		}

		public DatoAuxiliar DatoAuxiliar
		{
			get{return _valor.DatoAuxiliar;}
		}

		public System.Data.DataTable ListaEntidades
		{
			get{return _valor.ListaEntidades;}
		}
		
		public  System.Data.DataTable Bancos
		{
			get{return _valor.Bancos;}
		}

		public string KeyValueBanco
		{
			get { return "IdBanco" ; }
		}		
		
		public string KeyListBanco
		{
			get { return "Nombre" ; }
		}
		public  System.Data.DataTable CuentasBancarias
		{
			get{return _valor.CuentasBancarias;}
		}

		public string KeyValueCuenta
		{
			get { return "NroCuenta" ; }
		}		
		
		public string KeyListCuenta
		{
			get { return "NroCuenta" ; }
		}

		#region visualizacion ventana
		
		public bool AllowShowIncluyeRecargo
		{
			get{return _valor.AllowShowIncluyeRecargos;}
			set{_valor.AllowShowIncluyeRecargos = value;}
		}

		public bool AllowEditIncluyeRecargo()
		{
			return _valor.AllowEditIncluyeRecargos();
		}
		public bool AllowEditTDCompTesoreria
		{
			set{ _allowEditTDCompTesoreria = value;}
			get{ return _allowEditTDCompTesoreria ;}
		}

		public bool IdTDCompTesoreriaReadOnly
		{
			set{ _idTDCompTesoreriaReadOnly = value;}
			get{ return _idTDCompTesoreriaReadOnly ;}
		}
		public bool AllowEditMoneda
		{
			set{ _allowEditMoneda = value;}
			get{ return _allowEditMoneda ;}
		}
		public bool IdMonedaOrigenReadOnly
		{
			set{ _idMonedaOrigenReadOnly = value;}
			get{ return _idMonedaOrigenReadOnly ;}
		}

		#endregion

		#endregion

		#region acceso a variables de DatoAuxiliar
		
		public string CodigoAutorizacion
		{
			set { DatoAuxiliar.CodigoAutorizacion = value;}
			get { return DatoAuxiliar.CodigoAutorizacion;}
		}

		public string Cupon
		{
			set { DatoAuxiliar.Cupon = value;}
			get { return DatoAuxiliar.Cupon;}
		}
		public DateTime FechaDeAcreditacion
		{
			set { DatoAuxiliar.FechaDeAcreditacion = value;}
			get { return DatoAuxiliar.FechaDeAcreditacion;}
		}
		public DateTime FechaDeAutorizacion
		{
			set { DatoAuxiliar.FechaDeAutorizacion = value;}
			get { return DatoAuxiliar.FechaDeAutorizacion;}
		}
		public string Lote
		{
			set { DatoAuxiliar.Lote = value;}
			get { return DatoAuxiliar.Lote;}
		}
		public short CantidadCuotas
		{
			set { DatoAuxiliar.CantidadCuotas = value;}
			get { return DatoAuxiliar.CantidadCuotas;}
		}
		public string CantidadCuotasDefault()
		{
			string cant = Variables.GetValueString("Valores." + MAPStaticInfo.GetFDP(this.IdTDCompTesoreria) + ".CantidadCuotas");
			if (cant != string.Empty && cant != null)
				return cant;
			else return "NODEFAULT";
		}
		public string CuentaBancaria
		{
			set { DatoAuxiliar.CuentaBancaria = value;}
			get { return DatoAuxiliar.CuentaBancaria;}
		}
		public string Librador
		{
			set { DatoAuxiliar.Librador = value;}
			get { return DatoAuxiliar.Librador;}
		}
		public string Destinatario
		{
			set { DatoAuxiliar.Destinatario = value;}
			get { return DatoAuxiliar.Destinatario;}
		}

		
		public string IdCuenta
		{
			set { DatoAuxiliar.IdCuenta= value;}
			get { return DatoAuxiliar.IdCuenta;}
		}

		public string Sucursal
		{
			set { DatoAuxiliar.Sucursal = value;}
			get { return DatoAuxiliar.Sucursal;}
		}
		public object FechaDePago
		{
			set
			{ 
				if((value == null || value == System.DBNull.Value )&& !DatoAuxiliar.FechaDePago.Equals(DateTime.MinValue)) 
					DatoAuxiliar.FechaDePago = DateTime.MinValue;
				else DatoAuxiliar.FechaDePago = Convert.ToDateTime(value);
			}
				get
			{ 
				if(DatoAuxiliar.FechaDePago.Equals(DateTime.MinValue))
					return null;
				return DatoAuxiliar.FechaDePago;
			}
		}
		public DateTime FechaDeRecepcion
		{
			set { DatoAuxiliar.FechaDeRecepcion = value;}
			get { return DatoAuxiliar.FechaDeRecepcion;}
		}

		public string IdTipoDeRetencion
		{
			get{ return DatoAuxiliar.IdTipoDeRetencion; }
			set{ DatoAuxiliar.IdTipoDeRetencion = value; }
		}

		public DateTime FechaComprobanteRetencion
		{
			set { DatoAuxiliar.FechaComprobanteRetencion = value;}
			get { return DatoAuxiliar.FechaComprobanteRetencion;}
		}
		public DateTime FechaIngresoRetencion
		{
			set { DatoAuxiliar.FechaIngresoRetencion = value;}
			get { return DatoAuxiliar.FechaIngresoRetencion;}
		}
		public bool FechaDeRecepcionReadOnly
		{
			get { 
				return Variables.GetValueBool("Valores.FechaDeRetencion.ReadOnly", true);
			}
		}
		public string NroBoleta
		{
			set {DatoAuxiliar.NroBoleta = value;}
			get {return DatoAuxiliar.NroBoleta;}
		}
		public string CodigoDiez
		{
			set{ DatoAuxiliar.CodigoDiez = value;}
			get{ return DatoAuxiliar.CodigoDiez ;}
		}
		public object FechaIngresoBanco
		{
			set
			{ 
				if((value == null || value == System.DBNull.Value )&& !DatoAuxiliar.FechaIngresoBanco.Equals(DateTime.MinValue)) 
					DatoAuxiliar.FechaIngresoBanco = DateTime.MinValue;
				else DatoAuxiliar.FechaIngresoBanco = Convert.ToDateTime(value);
			}
			get
			{ 
				if(DatoAuxiliar.FechaIngresoBanco.Equals(DateTime.MinValue))
						return null;
				return DatoAuxiliar.FechaIngresoBanco;
			}
		}
	
		#endregion

		#region Metodos Privados
		
		private void _valor_ValorChange()
		{
			
			if(ModelChanged != null)
				ModelChanged(this, new EventArgs());
		}

		private void _valor_ObjectHasChanged(object sender, EventArgs e)
		{
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged(this, new EventArgs());
			}
		}

		#endregion

		#region Metodos Publicos
		
		public void CancelEdit()
		{
			_valor.FinalizeEdit(true);
		}
		public void AcceptEdit()
		{
			_valor.FinalizeEdit(false);
		}

		public Hashtable ReglasDeValidacionAuxiliares
		{
			set { _valor.ReglasDeValidacionAuxiliares = value ; }
		}
		public Hashtable ReglasDeValidacionDatos
		{
			set { _valor.ReglasDeValidacionDatos = value ; }
		}

		public bool HasErrors()
		{
			/*
			if(_taskController != null)
			{
				if (_taskController.GetType() == typeof(mz.erp.ui.controllers.MovimientoAjusteCajaController) )
				{
					MovimientoAjusteCajaController movCajaController = (MovimientoAjusteCajaController) _taskController;
					return !_valor.completoDatos( movCajaController.TaskName(), ((ITaskController)_taskController).GetProcessManager().GetProcessName());
				}
				if (_taskController.GetType() == typeof(mz.erp.ui.controllers.FormasDePagoController))
				{
					FormasDePagoController fdpController = (FormasDePagoController) _taskController;
					return !_valor.completoDatos(fdpController.TaskName, ((ITaskController)_taskController).GetProcessManager().GetProcessName());
				}
				else return !_valor.completoDatos(this._processName, this._taskName);//_valor.IdTDCompTesoreria);
			}
			else return !_valor.completoDatos(this._processName, this._taskName);//_valor.IdTDCompTesoreria);
			*/

			return !_valor.IsValid();
		}

		public bool VisiblePanelDatosSecundarios()
		{
			return !GetAgrupado();
		}

		public bool VisiblePanelDatosAuxiliares()
		{
			return _valor.HasVariablesAuxiliares();
		}

		public bool PerteneceACheque(string idFormaDePago)
		{
			return _valor.PerteneceACheque(idFormaDePago);
		}

		public bool PerteneceATerceros(string idFormaDePago)
		{
			return _valor.PerteneceATerceros(idFormaDePago);
		}
		public bool PerteneceAPropio(string idFormaDePago)
		{
			return _valor.PerteneceAPropio(idFormaDePago);
		}


		public bool PerteneceATarjeta(string idFormaDePago)
		{
			return _valor.PerteneceATarjeta(idFormaDePago);
		}

		public bool PerteneceARetenciones ( string idFormaDePago)
		{
			return _valor.PertenceARetenciones(idFormaDePago);
		}

		public bool ChequeDiferido(string idFormaDePago)
		{
			return _valor.ChequeDiferido(idFormaDePago);
		}

	

		#endregion

		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			foreach(IObserver observer in _observers)
			{
                /* Silvina 20110222 - Tarea 0000012 */
                if (observer.GetType().Equals(typeof(mz.erp.ui.controllers.ComprobantesDePagoController)))
                    _valor.MontoCotizado = MontoCotizadoConRecargos;
                /* Fin Silvina */
				observer.UpdateObject(this, this._valor);
			}
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}


		#endregion


		public string CamposVisibles()
		{
			string comp = MAPStaticInfo.GetFDP( this.IdTDCompTesoreria );
			return Variables.GetValueString( "Momentos.ValorDatoAuxiliar."+comp+".CamposVisibles");
		}

		public string CamposNoEditables()
		{
			return Variables.GetValueString(_processName, _taskName , MAPStaticInfo.GetFDP(IdTDCompTesoreria)+".CamposNoEditables");
		}
		

		public System.Data.DataTable ListaTDCompTesoreria()
		{
			
			string TiposDeComp = Variables.GetValueString(_processName, _taskName , "ListaDeTDCompTesoreria");
			if ( TiposDeComp == null || TiposDeComp.Equals(string.Empty) )
				return businessrules.tfi_TDCompTesoreria.GetList().Tables[0];
			else 
				return businessrules.tfi_TDCompTesoreria.GetList(TiposDeComp).Tables[0];
				
		}
		
        /* Silvina 20110222 - Tarea 0000012 */
        public void SetPorcentaje()
        {
            if (_cambioTDComp && !(_taskController.GetType().Equals(typeof(mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController))))
            {
                DataTable table = mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.GetList(IdTDCompTesoreria, IdMoneda).tfi_TDCompTesoreriasMonedasRecargos;
                if (table.Rows.Count == 1)
                {
                    _porcenatjeRecargo = Convert.ToDecimal(table.Rows[0]["Recargo"]);
                }
                _cambioTDComp = false;
            }
        }
        /* Fin Silvina */
	
		#region Miembros de ITaskController


		private ProcessControllerManager _processManager;

		public string GetTaskName()
		{
			return _valor.GetTaskName();
		}

		public string GetWarnings()
		{
			return null;
		}

		public void Continue()
		{
		}

		public ItemsDatasetErrors GetErrors()
		{	
			return _valor.GetErrors();
		}	
		public void Execute()
		{
			_valor.Execute();
		}

		public bool AllowShow()
		{
			return _valor.AllowShow();
		}
		public bool AllowPrevious()
		{
			return _valor.AllowPrevious();
		}

		public void Previous()
		{
			_valor.Previous();
		}
		
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
			_processName = _processManager.GetProcessName();
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_valor.GetTaskName());
		}
		
		public bool IsNextState()
		{
			return this._processManager.IsNextState();
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

	
		#endregion

		#region Miembros de IObservableController

		public void AddTaskController(ITaskController controller)
		{
			_taskController = controller;
			_taskName = controller.GetTaskName();
			_processName = controller.GetProcessManager().GetProcessName();
			if(_valor != null)
			{
				_valor.TaskName = _taskName;
				_valor.ProcessName = _processName;
			}
		
		}

		#endregion
	}
}
