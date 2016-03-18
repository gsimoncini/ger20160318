using System;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobanteDeAjusteCuentaCorrienteController.
	/// </summary>
	public class ComprobanteDeAjusteCuentaCorrienteController: ITaskController, IObserver
	{
		#region Constructores
		
		public ComprobanteDeAjusteCuentaCorrienteController(ComprobanteDeAjusteCuentaCorriente brClass)
		{
			_brClass = brClass;
			Init();
		}
		

		#endregion

		#region Variables Privadas
			
			private ComprobanteDeAjusteCuentaCorriente _brClass;
			private string _leyendaFormulario = string.Empty;
			
			private string _observaciones = string.Empty;
			private decimal _total = 0;
			private string _mascara = string.Empty;
			private object _keyValueTiposDeComprobantes = string.Empty;
			private object _responsableDeEmision = string.Empty;
			private string _numeroComprobante = string.Empty;
			private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			private string _codigoCuenta = string.Empty;
			private System.Collections.Hashtable _listatiposDeComprobantes =  businessrules.tsy_TiposDeComprobantes.GetListHashTable();		

			private string _textoBotonAnterior = "Anterior";
			private string _textoBotonSiguiente = "Siguiente";

			private DataTable _dataUsuarios = businessrules.data.UsuariosPersonas.GetList();

		#endregion	

		#region Propiedades


		public string Observaciones
		{
			get{return this._observaciones;}
			set 
			{
				if (_observaciones!= value) 
				{
					_observaciones = value;
					_brClass.Observaciones = value;
				}				
			}
		}

		public DataTable ResponsableDataTable
		{
			get
			{
				return _dataUsuarios;

			}
		}

		public DataTable TableTiposDeComprobantes
		{
			get{return _brClass.TableTiposDeComprobantes;}
		}

		public string Mascara
		{
			get{return _mascara;}
		}

		public string TextoBotonSiguiente
		{
			get 
			{
				return this._textoBotonSiguiente;
			}
		}
		public string TextoBotonAnterior
		{
			get 
			{
				return this._textoBotonAnterior;					
			}
		}

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public bool AllowEditTipoDeComprobante
		{
			get
			{
				return this._brClass.AllowEditTipoDeComprobante;
			}
		}
		public bool AllowEditResponsableEmision
		{
			get
			{
				return this._brClass.AllowEditResponsableEmision;
			}
		}
		public bool AllowEditCuenta
		{
			get
			{
				return this._brClass.AllowEditCuenta;
			}
		}

		public bool AllowEditNumeration
		{
			get
			{
				return this._brClass.AllowEditNumeration;
			}
		}

		public bool AllowEditFecha
		{
			get
			{
				return this._brClass.AllowEditFecha;
			}
		}

	
		public decimal Total
		{
			get
			{
				return _total;
			}
			set 
			{
				if (_total!= value) 
				{
					_total = value;
					_brClass.Total = value;
				}				
			}
		}

		public string NombreDeComprobante
		{
			get { return _listatiposDeComprobantes[ _brClass.TipoComprobanteDestino].ToString() ;}
		}

		
		public object KeyValueTiposDeComprobantes
		{
			get {return _keyValueTiposDeComprobantes;}
			set 
			{
				if (_keyValueTiposDeComprobantes!= value) 
				{
					_keyValueTiposDeComprobantes = value;
					_brClass.TipoComprobanteDestino = Convert.ToString(value);
				}				
			}
		}

		public string CodigoCuenta 
		{
			get {return _codigoCuenta;}
			set 
			{
				if (_codigoCuenta!= value) 
				{
					_codigoCuenta = value;
					_brClass.CodigoCuenta = Convert.ToString(value);
				}				
			}
		}

		public string ResponsableValueMember
		{
			get
			{
				return "IdPersona";
			}
		}

		public string ResponsableDisplayMember
		{
			get
			{
				return "Nombre";
			}
		}

		public string TiposDeComprobantesValueMember
		{
			get 
			{
				return "IdTipoDeComprobante";
			}
		}

		public string TiposDeComprobantesDisplayMember
		{
			get 
			{
				return "Descripcion";
			}
		}

	
		public object ResponsableDeEmision
		{
			get {return _responsableDeEmision;}
			set 
			{
				if (_responsableDeEmision!= value) 
				{
					_responsableDeEmision = value;
					_brClass.IdResponsable = Convert.ToString(value);
				}				
			}
		}

	
		public string NumeroComprobante 
		{
			get {return _numeroComprobante;	}
			set 
			{
				if(_numeroComprobante != value)
				{
					_numeroComprobante = value;
					_brClass.Numero = value;
				}
			}
		}

		
		public DateTime Fecha
		{
			get 
			{
				return _fecha;	
			}
			set 
			{
				if(_fecha != value)
				{
					_fecha = value;
					_brClass.FechaComprobante = value;
				}
			}
		}
		



		#endregion

		#region Metodos Publicos
        
		public string FillNumberWithZeros(string txt)
		{
			return _brClass.FillNumberWithZeros(txt);
		}

		#endregion

		#region Metodos Privados

        //German 20120223 -  Tarea 0000247
        public void FillData()
        {
            this._responsableDeEmision = _brClass.IdResponsable;
            this._keyValueTiposDeComprobantes = _brClass.TipoComprobanteDestino;
            this._fecha = _brClass.FechaComprobante;
            this._total = _brClass.Total;
            this._numeroComprobante = _brClass.Numero;
            this._mascara = _brClass.Mascara;
            this._codigoCuenta = _brClass.CodigoCuenta;
        }
        //Fin German 20120223 -  Tarea 0000247



        public void Init()
		{
			InitializeData();
			InitEventHandlers();
		}

		private void InitializeData()
		{
			
			this._responsableDeEmision = _brClass.IdResponsable;
			this._keyValueTiposDeComprobantes = _brClass.TipoComprobanteDestino;
			this._fecha = _brClass.FechaComprobante;
			this._total = _brClass.Total;
			this._numeroComprobante = _brClass.Numero;
			this._mascara = _brClass.Mascara;
			this._codigoCuenta = _brClass.CodigoCuenta;
			SetTextoBotones();
			SetLeyendaFormulario();
			

		}

		private void SetTextoBotones()
		{
			string valor = String.Empty;
			valor = Variables.GetValueString(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "TextoBotonAnterior");
			if (valor != null && valor != String.Empty) 
			{
				_textoBotonAnterior = valor;
			}
			valor = Variables.GetValueString(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "TextoBotonSiguiente");
			if (valor != null && valor != String.Empty) 
			{
				_textoBotonSiguiente = valor;
			}
		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName() +".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged+=new EventHandler(ListenerObjectHasChanged);
			
		}
		public void CallRefresh()
		{
			if (_responsableDeEmision != (_brClass.IdResponsable)) 
			{								
				_responsableDeEmision = _brClass.IdResponsable;
				if (ResponsableDeEmisionChanged != null) 
				{
					ResponsableDeEmisionChanged(this, new EventArgs());	
				}
			}
			if (_keyValueTiposDeComprobantes != (_brClass.TipoComprobanteDestino)) 
			{
				_keyValueTiposDeComprobantes = _brClass.TipoComprobanteDestino;
				if (KeyValueTiposDeComprobantesChanged != null) 
				{
					KeyValueTiposDeComprobantesChanged(this, new EventArgs());	
				}
			}
			if (!_numeroComprobante.Equals(_brClass.Numero))
			{	
				_numeroComprobante = _brClass.Numero;
				if (NumeroComprobanteChanged != null) 
				{
					NumeroComprobanteChanged(this, new EventArgs());	
				}
			}
			if (!_fecha.Equals(_brClass.FechaComprobante)) 
			{										
				_fecha = _brClass.FechaComprobante;
				if (FechaChanged != null) 
				{
					FechaChanged(this, new EventArgs());	
				}
			}
			if (!_total.Equals(_brClass.Total)) 
			{
				_total = _brClass.Total;
				if (TotalChanged!= null) 
				{
					TotalChanged(this, new EventArgs());	
				}
			}
			if (!_codigoCuenta.Equals(_brClass.CodigoCuenta)) 
			{
				_codigoCuenta = _brClass.CodigoCuenta;
				if (CodigoCuentaChanged!= null) 
				{
					CodigoCuentaChanged(this, new EventArgs());	
				}
			}
			if (!_observaciones.Equals(_brClass.Observaciones)) 
			{
				_observaciones = _brClass.Observaciones;
				if (ObservacionesChanged!= null) 
				{
					ObservacionesChanged(this, new EventArgs());	
				}
			}
		}

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			CallRefresh();
		}
		

		#endregion

		#region Eventos y Delegados
		
		
		public event EventHandler KeyValueTiposDeComprobantesChanged;		
		public event EventHandler NumeroComprobanteChanged;
		public event EventHandler ResponsableDeEmisionChanged;
		public event EventHandler FechaChanged;
		public event EventHandler TotalChanged;
		public event EventHandler MascaraChanged;
		public event EventHandler CodigoCuentaChanged;
		public event EventHandler ObservacionesChanged;
		
		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
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


		public ITask GetTask()
		{
			// TODO: agregar la implementación ComprobantesDeVentaController.GetTask
			return null;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return true;
		}
		
		public event EventHandler OnTaskBeforeExecute;
		public void ListenerAfterExecute( object sender, System.EventArgs e)
		{
			
		}
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			
		}
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			
		}

		#endregion
	}
}
