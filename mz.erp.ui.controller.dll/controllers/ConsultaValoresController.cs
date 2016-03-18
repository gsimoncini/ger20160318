using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultaValoresController.
	/// </summary>
	public class ConsultaValoresController: ITaskController, IObservable	
	{
		public ConsultaValoresController(ConsultaValores BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		public ConsultaValoresController(string ProcessName, string TaskName, string IdInstanciaCaja)
		{
			_brClass = new ConsultaValores(ProcessName, TaskName, IdInstanciaCaja);
			Init();
		}


		#region Variables Privadas
		
		private ConsultaValores _brClass;
		private string _taskName = string.Empty;
		private string _processName = string.Empty;		
		private ProcessControllerManager _processManager;
		private string _layoutFiltroCajas = string.Empty;
		

		#endregion

		#region Propiedades Publicas
		public string LayoutFiltroCajas
		{
			get { return _layoutFiltroCajas ; }
		}

		public string KeyFamilia
		{
			get{return _brClass.KeyFamilia;}
			set
			{
				_brClass.KeyFamilia = value;
				if(KeyFamiliaChanged != null)
					KeyFamiliaChanged(this, new EventArgs());
			}
		}

		public string Jerarquia
		{
			get{return _brClass.Jerarquia;}
			set
			{
				_brClass.Jerarquia = value;
				if(JerarquiaChanged != null)
					JerarquiaChanged(this, new EventArgs());
			}
		}
		public bool HabilitaBusquedaTipoRetencion
		{
			get{return _brClass.HabilitaBusquedaTipoRetencion;}
			set{_brClass.HabilitaBusquedaTipoRetencion = value;}
		}

		public bool HabilitaBusquedaFechaComprobanteRetencion
		{
			get{return _brClass.HabilitaBusquedaFechaComprobanteRetencion;}
			set{_brClass.HabilitaBusquedaFechaComprobanteRetencion = value;}
		}


		public bool HabilitaBusquedaFechaIngresoRetencion
		{
			get{return _brClass.HabilitaBusquedaFechaIngresoRetencion;}
			set{_brClass.HabilitaBusquedaFechaIngresoRetencion = value;}
		}



		public bool PermiteSeleccionarIdInstanciaCaja
		{
			get{return _brClass.PermiteSeleccionarIdInstanciaCaja;}
		}


		public bool HabilitaBusquedaEntidad
		{
			get{return _brClass.HabilitaBusquedaEntidad;}
			set{_brClass.HabilitaBusquedaEntidad = value;}
		}

		public bool HabilitaBusquedaMontoHasta
		{
			get{return _brClass.HabilitaBusquedaMontoHasta;}
			set{_brClass.HabilitaBusquedaMontoHasta = value;}
		}

		public bool HabilitaBusquedaMontoDesde
		{
			get{return _brClass.HabilitaBusquedaMontoDesde;}
			set{_brClass.HabilitaBusquedaMontoDesde = value;}
		}


		public bool HabilitaBusquedaFechaIngresoBanco
		{
			get{return _brClass.HabilitaBusquedaFechaIngresoBanco;}
			set{ _brClass.HabilitaBusquedaFechaIngresoBanco = value;}
		}

		public bool HabilitaBusquedaFechaRecepcion
		{
			get{return _brClass.HabilitaBusquedaFechaRecepcion;}
			set{_brClass.HabilitaBusquedaFechaRecepcion = value;}
		}

		public bool HabilitaBusquedaFechaPago
		{
			get{return _brClass.HabilitaBusquedaFechaPago;}
			set{_brClass.HabilitaBusquedaFechaPago = value;}
		}

		public bool HabilitaBusquedaFechaAutorizacion
		{
			get{return _brClass.HabilitaBusquedaFechaAutorizacion;}
			set{_brClass.HabilitaBusquedaFechaAutorizacion = value;}
		}


		public bool HabilitaBusquedaFechaAcreditacion
		{
			get{return _brClass.HabilitaBusquedaFechaAcreditacion;}
			set{_brClass.HabilitaBusquedaFechaAcreditacion = value;}
		}


		public bool HabilitaBusquedaCantidadCuotas
		{
			get{return _brClass.HabilitaBusquedaCantidadCuotas;}
			set{_brClass.HabilitaBusquedaCantidadCuotas = value;}
		}



		public bool HabilitaBusquedaFechaVencimiento
		{
			get{return _brClass.HabilitaBusquedaFechaVencimiento;}
			set{_brClass.HabilitaBusquedaFechaVencimiento = value;}
		}


		public bool HabilitaBusquedaFechaEmision
		{
			get{return _brClass.HabilitaBusquedaFechaEmision;}
			set{_brClass.HabilitaBusquedaFechaEmision = value;}
		}



		

		public string IdMonedaReferencia
		{
			get{return _brClass.IdMonedaReferencia;}
		}

		
		
		public string IdMoneda
		{
			get{return _brClass.IdMoneda;}
			set{_brClass.IdMoneda = value;}
		}
		public string Numero
		{
			get	{return _brClass.Numero;	}
			set	{_brClass.Numero = value;	}
		}

		public string IdEntidad
		{
			get	{return _brClass.IdEntidad;}
			set {_brClass.IdEntidad = value;}
		}
		
		public decimal MontoDesde
		{
			get{return _brClass.MontoDesde;}
			set{_brClass.MontoDesde = value;}
		}

		public decimal Montohasta
		{
			get{return _brClass.MontoHasta;}
			set{_brClass.MontoHasta = value;}
		}
		
		public string IdTDCompTesoreria
		{
			get{return _brClass.IdTDCompTesoreria;}
			set
			{
				if (value != null && value != _brClass.IdTDCompTesoreria)
				{
					_brClass.IdTDCompTesoreria = value;
					if(IdTDCompTesoreriaChanged != null)
						IdTDCompTesoreriaChanged(this, new EventArgs());
				}
			}
		}

		public DateTime FechaEmsionDesde
		{
			get	{	return _brClass.FechaEmisionDesde;	}
			set {	_brClass.FechaEmisionDesde = value;	}
		}

		public DateTime FechaEmsionHasta
		{
			get	{	return _brClass.FechaEmisionHasta;	}
			set {	_brClass.FechaEmisionHasta = value;	}
		}

		public DateTime FechaVencimientoDesde
		{
			get	{return _brClass.FechaVencimientoDesde;}
			set	{_brClass.FechaVencimientoDesde = value;	}
		}

		public DateTime FechaVencimientoHasta
		{
			get	{return _brClass.FechaVencimientoHasta;}
			set	{_brClass.FechaVencimientoHasta = value;	}
		}

		public string IdCajas
		{
			get{return _brClass.IdCajas;}
			set{_brClass.IdCajas = value;}
		}

		public  System.Data.DataTable ListaInstaciasCaja
		{
			get{return _brClass.ListaInstaciasCaja;}
		}

		/*public System.Data.DataTable ListaComprobantesTesoreria
		{
			get{return _brClass.ListaComprobantesTesoreriaFiltrada;}
		}*/
		
		public DataTable ListaComprobantesTesoreria
		{
			get {return _brClass.ListaComprobantesTesoreria;}
		}
		public System.Data.DataTable ListaEntidades
		{
			get{return _brClass.ListaEntidades;}
		}

		public string CodigoAutorizacion
		{
			set { _brClass.CodigoAutorizacion = value;}
			get { return _brClass.CodigoAutorizacion;}
		}

		public string Cupon
		{
			set { _brClass.Cupon = value;}
			get { return _brClass.Cupon;}
		}
		public DateTime FechaDeAcreditacion
		{
			set { _brClass.FechaDeAcreditacion = value;}
			get { return _brClass.FechaDeAcreditacion;}
		}
		public DateTime FechaDeAutorizacion
		{
			set { _brClass.FechaDeAutorizacion = value;}
			get { return _brClass.FechaDeAutorizacion;}
		}
		public string Lote
		{
			set { _brClass.Lote = value;}
			get { return _brClass.Lote;}
		}
		public short CantidadCuotas
		{
			set { _brClass.CantidadCuotas = value;}
			get { return _brClass.CantidadCuotas;}
		}
		
		public string CuentaBancaria
		{
			set { _brClass.CuentaBancaria = value;}
			get { return _brClass.CuentaBancaria;}
		}
		public string Librador
		{
			set { _brClass.Librador = value;}
			get { return _brClass.Librador;}
		}

		public string IdCuenta
		{
			set { _brClass.IdCuenta= value;}
			get { return _brClass.IdCuenta;}
		}

		public string Sucursal
		{
			set { _brClass.Sucursal = value;}
			get { return _brClass.Sucursal;}
		}
		public object FechaDePago
		{
			set
			{ 
				if((value == null || value == System.DBNull.Value )&& !_brClass.FechaDePago.Equals(DateTime.MinValue)) 
					_brClass.FechaDePago = DateTime.MinValue;
				else _brClass.FechaDePago = Convert.ToDateTime(value);
			}
			get
			{ 
				if(_brClass.FechaDePago.Equals(DateTime.MinValue))
					return null;
				return _brClass.FechaDePago;
			}
		}
		public DateTime FechaDeRecepcion
		{
			set { _brClass.FechaDeRecepcion = value;}
			get { return _brClass.FechaDeRecepcion;}
		}

		public string IdTipoDeRetencion
		{
			get{ return _brClass.IdTipoDeRetencion; }
			set{ _brClass.IdTipoDeRetencion = value; }
		}

		public DateTime FechaComprobanteRetencion
		{
			set { _brClass.FechaComprobanteRetencion = value;}
			get { return _brClass.FechaComprobanteRetencion;}
		}
		public DateTime FechaIngresoRetencion
		{
			set { _brClass.FechaIngresoRetencion = value;}
			get { return _brClass.FechaIngresoRetencion;}
		}
		
		public string NroBoleta
		{
			set {_brClass.NroBoleta = value;}
			get {return _brClass.NroBoleta;}
		}
		public string CodigoDiez
		{
			set{ _brClass.CodigoDiez = value;}
			get{ return _brClass.CodigoDiez ;}
		}
		public object FechaIngresoBanco
		{
			set
			{ 
				if((value == null || value == System.DBNull.Value )&& !_brClass.FechaIngresoBanco.Equals(DateTime.MinValue)) 
					_brClass.FechaIngresoBanco = DateTime.MinValue;
				else _brClass.FechaIngresoBanco = Convert.ToDateTime(value);
			}
			get
			{ 
				if(_brClass.FechaIngresoBanco.Equals(DateTime.MinValue))
					return null;
				return _brClass.FechaIngresoBanco;
			}
		}

		public bool PerteneceDatosPrincipales(string columna)
		{
			return columna.IndexOf('_') == -1;
			
		}

		public bool VisualizaColumna(string columna)
		{
			string clave = _brClass.GetClaveCorta(_brClass.IdTDCompTesoreria);
			if(!clave.Equals(string.Empty))
			{
				if(columna.IndexOf(clave)!= -1)
					return true;
			}
			else
			{
				string[] claves = _brClass.KeyFamilia.Split(new char[]{','});
				foreach(string claveAux in claves)
				{
					if(!claveAux.Equals(string.Empty))
					{
						if(columna.IndexOf(claveAux)!= -1)
							return true;
					}
				}
			}
			return false;
		}

		private string _errorMessage = string.Empty;
		public bool IsValid()
		{
			bool ok = true;
			_errorMessage = string.Empty;
			//Pone un lugar para ""
			if (_brClass.PermiteSoloUnaCaja){
				ArrayList cajas=mz.erp.systemframework.Util.Parse(_brClass.IdCajas,",");
				if (cajas.Count>2){
				
					ok = false;
					_errorMessage = "No puede seleccionar mas de una caja.";
				}
					
			}
			
			if(_brClass.IdCajas == null || _brClass.IdCajas.Equals(string.Empty))
			{
				ok = false;
				_errorMessage = "Debe seleccionar una caja.";

			}
			if((_brClass.IdTDCompTesoreria == null || _brClass.IdTDCompTesoreria.Equals(string.Empty)) &&
				(_brClass.KeyFamilia == null || _brClass.KeyFamilia.Equals(string.Empty)))
			{
				ok = false;
				_errorMessage = _errorMessage + " Debe seleccionar un comprobante de tesoreria o una familia de comprobantes";

			}
			return ok;
			
		}

		public string ErrorMessage
		{
			get{return _errorMessage;}
			
		}

		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}		

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		
		#endregion

		#region Eventos
			
			public event EventHandler IdTDCompTesoreriaChanged;
			public event EventHandler KeyFamiliaChanged;
			public event EventHandler JerarquiaChanged;
			public event EventHandler ModelChanged;

		#endregion

		#region Metodos Privadas
		
		private void Init()
		{
			_brClass.ModelChanged +=new EventHandler(_brClass_ModelChanged);
			_brClass.KeyFamiliaChanged+=new EventHandler(_brClass_KeyFamiliaChanged);
			this._layoutFiltroCajas = this.GetLayoutFiltros();
		}
		public ArrayList FiltroCajas
		{
			get { return _brClass.FiltroCajas ; }
			set { _brClass.FiltroCajas = value ; }
		}

		private string GetLayoutFiltros( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sel", "Sel",  20, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250,  Types.ColumnTypes.Text, Types.EditType.NoEdit ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		#endregion

		#region Metodos Publicos

		public void TildarNingunoCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas )
				items.Sel = false;
		}
		public void TildarTodosCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas)
				items.Sel = true;
		}
		public void Refresh(){
		
		_brClass.Refresh();
		}
		public void Reset()
		{
			_brClass.Reset();
		}

		public bool IsWorkflow()
		{
			return this.GetProcessManager() != null;
		}

		
		public bool PerteneceACheque()
		{
			return _brClass.PerteneceACheque();
		}

	/*	public bool PerteneceATerceros(string idFormaDePago)
		{
			return _brClass.PerteneceATerceros(idFormaDePago);
		}*/


		public bool PerteneceATarjeta()
		{
			return _brClass.PerteneceATarjeta();
		}

		public bool PerteneceARetenciones ( )
		{
			return _brClass.PertenceARetenciones();
		}

		public bool ChequeDiferido(string idFormaDePago)
		{
			return _brClass.ChequeDiferido(idFormaDePago);
		}

		public DataView Search()
		{
			return _brClass.Search();
		}

		public DataTable GetTableFamiliasTDCompTesoreria()
		{
			return _brClass.GetTableFamiliasTDCompTesoreria();
		}
		public void SeleccionarFamilia()
		{
			 _brClass.SeleccionarFamilia();
		}

        //Cristian Tsrea 0000050 20110314
        //Cristian Tsrea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, String tipoFecha, bool ordenInverso)
        {
            _brClass.updateFechas(fechaDesde,tipoFecha, ordenInverso);

        }
        //Fin Cristian 20110725
        //Fin Cristian
		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			if(this._processManager != null)
				return this._processManager.ProcessFlushed;
			return false;
		}

		public  bool IsNextState()
		{	
			if(this._processManager != null)
				return this._processManager.IsNextState();	
			return false;
		}

		public  bool IsBackState()
		{	if(this._processManager != null)
				return this._processManager.IsBackState();
			return false;
		}
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _brClass.GetProcessName();
		}

		public bool IsFirstTask()
		{
			if(this._processManager != null)
				return this._processManager.IsFirstTask(_brClass.GetTaskName());
			return false;
		}

	
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}
		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}


		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}

		#endregion

		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			foreach(IObserver observer in _observers)
			{
				observer.UpdateObject(this, _brClass.GetValores());
			}
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}


		#endregion

		private void _brClass_ModelChanged(object sender, EventArgs e)
		{
			if(ModelChanged != null)
				ModelChanged(this, new EventArgs());
		}

		private void _brClass_KeyFamiliaChanged(object sender, EventArgs e)
		{
			if(KeyFamiliaChanged != null)
				KeyFamiliaChanged(this, new EventArgs());
		}
	}

	


}
