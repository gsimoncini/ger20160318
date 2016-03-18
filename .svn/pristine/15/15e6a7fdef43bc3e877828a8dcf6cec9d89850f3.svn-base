using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class AbmCuentasObservacionesController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmCuentasObservaciones _brClass;
		public AbmCuentasObservacionesController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AbmCuentasObservacionesController(mz.erp.businessrules.AbmCuentasObservaciones brClass)
		{
			_brClass = brClass;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		#endregion

		#region Variables Públicas

		public event EventHandler OnTaskAfterExecute;
			
		#endregion

		#region Propiedades Públicas Datos
		//Variables de configuracion de la vista

		public bool PermiteEditarTipo 
		{
			get 
			{	
				return _brClass.PermiteEditarTipo;
			}
		}
		public bool PermiteEditarFecha 
		{
			get 
			{	
				return _brClass.PermiteEditarFecha;
			}
		}
		public bool HabilitarContraseña 
		{
			get 
			{	
				return _brClass.HabilitarContraseña;
			}
		}
		
		
		public bool PermiteEditarResponsable
		{
			get 
			{	
				return _brClass.PermiteEditarResponsable;
			}
		}
	
		public bool PermiteEditarSubTipo 
		{
			get 
			{				
				return _brClass.PermiteEditarSubTipo;
			}
		}
		public bool PermiteEditarEstado 
		{
			get 
			{	return _brClass.PermiteEditarEstado;
			}
		}
		
		public bool PermiteEditarTitulo 
		{
			get 
			{	return _brClass.PermiteEditarTitulo;
			}
		}
		
		public bool PermiteEditarFechaAviso
		{
			get 
			{
				return _brClass.PermiteEditarFechaAviso;
			}
		}
	
		public bool PermiteEditarFechaVencimiento
		{
			get 
			{				
			return _brClass.PermiteEditarFechaVencimiento;
			}
		}
		
		public bool PermiteEditarCuenta
		{
			get 
			{				
			return _brClass.PermiteEditarCuenta;
			}
		}
		
		public bool PermiteEditarObservaciones
		{
			get 
			{				
				return _brClass.PermiteEditarObservaciones;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}
		public string LeyendaFormulario
		{
			get 
			{
				return _brClass.LeyendaFormulario;
			}
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}
		private string _codigoCuenta = String.Empty;
		public string CodigoCuenta
		{			
			get { return _brClass.CodigoCuenta ; }
			set 
			{ 
				if (value != null && _brClass.CodigoCuenta.CompareTo( value ) != 0)
				{
					_codigoCuenta = Convert.ToString(value);
					_brClass.CodigoCuenta = Convert.ToString(value) ; 
					if (this.CodigoCuentaChanged != null)
						CodigoCuentaChanged (this, new EventArgs());
				}
				/*else if(value == null && _codigoCuenta != string.Empty)
				{
					_codigoCuenta = string.Empty;
					_brClass.CodigoCuenta = string.Empty; 
				}*/
			}
		}

		private string _idProveedor = String.Empty;
		public string IdProveedor
		{			
			get { return _brClass.IdProveedor ; }
			set 
			{ 
				if (value != null && _brClass.IdProveedor.CompareTo( value ) != 0)
				{
					_idProveedor = Convert.ToString(value);
					_brClass.IdProveedor = Convert.ToString(value) ; 
					if (this.IdProveedorChanged != null)
						IdProveedorChanged (this, new EventArgs());
				}
			}
		}

        /* Silvina 20100920 - Tarea 839 */

        public string CodigoProveedor
        {
            get { return _brClass.CodigoProveedor; }
            set { _brClass.CodigoProveedor = value;}
        }

        /* Fin Silvina */

		public bool IsValid 
		{
			get {return _isValid;}
		}

		private string _idEstado = string.Empty;
		public object IdEstado
		{
			get { return _brClass.IdEstado ; }
			set 
			{ 
				if (value != null && _brClass.IdEstado.CompareTo( value ) != 0)
				{
					_idEstado = Convert.ToString(value);
					_brClass.IdEstado = Convert.ToString(value) ; 
					if (this.IdEstadoChanged != null)
						IdEstadoChanged (this, new EventArgs());
				}
				else if(value == null && _idEstado != string.Empty)
				{
					_idEstado = string.Empty;
					_brClass.IdEstado = string.Empty; 
				}
			}
		}
		private string _idEstadoProveedor = string.Empty;
		public object IdEstadoProveedor
		{
			get { return _brClass.IdEstadoProveedor ; }
			set 
			{ 
				if (value != null && _brClass.IdEstadoProveedor.CompareTo( value ) != 0)
				{
					_idEstadoProveedor = Convert.ToString(value);
					_brClass.IdEstadoProveedor = Convert.ToString(value) ; 
					if (this.IdEstadoProveedorChanged != null)
						IdEstadoProveedorChanged (this, new EventArgs());
				}
				else if(value == null && _idEstadoProveedor != string.Empty)
				{
					_idEstadoProveedor = string.Empty;
					_brClass.IdEstadoProveedor = string.Empty; 
				}
			}
		}
		private string _idTipo = string.Empty;
		public object IdTipo
		{
			get { return _brClass.IdTipo ; }
			set 
			{ 
				if (value != null && _brClass.IdTipo.CompareTo( value ) != 0)
				{
					_idTipo = Convert.ToString(value);
					_brClass.IdTipo = Convert.ToString(value) ; 					
					if (this.IdTipoChanged != null)
						IdTipoChanged (this, new EventArgs());
				}
				else if(value == null && _idTipo != string.Empty)
				{
					_idTipo = string.Empty;
					_brClass.IdTipo = string.Empty; 
				}
			}
		}		

		private string _idTipoProveedor = string.Empty;
		public object IdTipoProveedor
		{
			get { return _brClass.IdTipoProveedor ; }
			set 
			{ 
				if (value != null && _brClass.IdTipoProveedor.CompareTo( value ) != 0)
				{
					_idTipoProveedor = Convert.ToString(value);
					_brClass.IdTipoProveedor = Convert.ToString(value) ; 					
					if (this.IdTipoProveedorChanged != null)
						IdTipoProveedorChanged (this, new EventArgs());
				}
				else if(value == null && _idTipoProveedor != string.Empty)
				{
					_idTipoProveedor = string.Empty;
					_brClass.IdTipoProveedor = string.Empty; 
				}
			}
		}		
		
		private string _idSubTipo = string.Empty;
		public object IdSubTipo
		{
			get { return _brClass.IdSubTipo ; }
			set 
			{ 
				if (value != null && _brClass.IdSubTipo.CompareTo( value ) != 0)
				{
					_idSubTipo = Convert.ToString(value);
					_brClass.IdSubTipo = Convert.ToString(value) ; 
					if (this.IdSubTipoChanged != null)
						IdSubTipoChanged (this, new EventArgs());
				}
				else if(value == null && _idSubTipo != string.Empty)
				{
					_idSubTipo = string.Empty;
					_brClass.IdSubTipo = string.Empty; 
				}
			}
		}	

		private string _idSubTipoProveedor = string.Empty;
		public object IdSubTipoProveedor
		{
			get { return _brClass.IdSubTipoProveedor ; }
			set 
			{ 
				if (value != null && _brClass.IdSubTipoProveedor.CompareTo( value ) != 0)
				{
					_idSubTipoProveedor = Convert.ToString(value);
					_brClass.IdSubTipoProveedor = Convert.ToString(value) ; 
					if (this.IdSubTipoProveedorChanged != null)
						IdSubTipoProveedorChanged (this, new EventArgs());
				}
				else if(value == null && _idSubTipoProveedor != string.Empty)
				{
					_idSubTipoProveedor = string.Empty;
					_brClass.IdSubTipoProveedor = string.Empty; 
				}
			}
		}	
		
		private string _idUsuario = string.Empty;
		public object IdUsuario
		{
			get { return _brClass.IdUsuario ; }
			set 
			{ 
				if (value != null && _brClass.IdUsuario.CompareTo( value ) != 0)
				{
					_idUsuario = Convert.ToString(value);
					_brClass.IdUsuario = Convert.ToString(value) ; 
					if (this.IdUsuarioChanged != null)
						IdUsuarioChanged (this, new EventArgs());
				}
				else if(value == null && _idUsuario != string.Empty)
				{
					_idUsuario = string.Empty;
					_brClass.IdUsuario = string.Empty; 
				}
			}
		}	
		public DateTime Fecha
		{
			set { _brClass.Fecha = value ; }
			get { return _brClass.Fecha;} 
		}
		public DateTime FechaAviso
		{
			set { _brClass.FechaAviso = value ; }
			get { return _brClass.FechaAviso;} 
		}
		public DateTime FechaVencimiento
		{
			set { _brClass.FechaVencimiento = value ; }
			get { return _brClass.FechaVencimiento;} 
		}


		public int CantidadSubTipos 
		{
			get 
			{
				return _brClass.CantidadSubTipos;
			}
		}

		public string Titulo
		{
			get { return _brClass.Titulo ; }
			set { _brClass.Titulo = value;}			
		}		
		public string Observaciones
		{
			get { return _brClass.Observaciones ; }
			set { _brClass.Observaciones = value;}			
		}

		public bool HerramientaFormatoVisible 
		{
			get 
			{
				return _brClass.HerramientaFormatoVisible;
			}
		}
		
		public System.Data.DataTable Estados 
		{
			get {return _brClass.Estados;}
		}

		public System.Data.DataTable EstadosProveedores 
		{
			get {return _brClass.EstadosProveedores;}
		}
		
		public System.Data.DataTable Tipos
		{
			get {return _brClass.Tipos;}
		}

		public System.Data.DataTable TiposProveedores 
		{
			get {return _brClass.TiposProveedores;}
		}
		//private DataTable _usuarios = null;
		public System.Data.DataTable Usuarios
		{
			get {return _brClass.Usuarios;}
		}

		public System.Data.DataTable SubTiposProveedores 
		{
			get {return _brClass.SubTiposProveedores ;}
		}		

		public System.Data.DataTable SubTipos
		{
			get {return _brClass.SubTipos;}
		}		

		public string KeyValueEstados
		{
			get { return "IdCuentaObservacionEstado" ; }
		}
		public string KeyListEstados
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueTipos
		{
			get { return "IdCuentaObservacionTipo" ; }
		}
		public string KeyListTipos
		{
			get { return "Descripcion" ; }
		}

		public string KeyValueEstadosProveedores
		{
			get { return "IdProveedorObservacionEstado" ; }
		}
		public string KeyListEstadosProveedores
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueTiposProveedores
		{
			get { return "IdProveedorObservacionTipo" ; }
		}
		public string KeyListTiposProveedores
		{
			get { return "Descripcion" ; }
		}

		public string KeyValueUsuarios
		{
			get { return "IdPersona" ; }
		}				
		public string KeyListUsuarios
		{
			get { return "Nombre" ; }
		}
		public string IdCuentaObservacion 
		{
			get 
			{
				return _brClass.IdCuentaObservacion;
			}
			set  
			{
				_brClass.IdCuentaObservacion = value;
			}
		}		
		#endregion
	
		private string _ultimoResponsableClaveCorrecta = "";
		public string UltimoResponsableClaveCorrecta
		{
			get 
			{
				return _ultimoResponsableClaveCorrecta;
			}
			set 
			{
				_ultimoResponsableClaveCorrecta = value;
			}		
		}	
		public void ClearResponsableDeEmision() 
		{						
			_brClass.IdUsuario = ""; 
			this.IdUsuario="";
		}
		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
						
		#endregion

		#region Variables Privadas Datos

		#endregion

		#region Eventos y delegados
			
		public event EventHandler TiposHasChanged;	
		public event EventHandler ObjectHasChanged;	
		public event EventHandler CodigoCuentaChanged;		
		public event EventHandler IdEstadoChanged;
		public event EventHandler IdTipoChanged;
		public event EventHandler IdSubTipoChanged;		
		public event EventHandler IdUsuarioChanged;		
		public event EventHandler FechaChanged;
		public event EventHandler FechaAvisoChanged;
		public event EventHandler FechaVencimientoChanged;	
		public event EventHandler IdProveedorChanged;		
		public event EventHandler IdEstadoProveedorChanged;
		public event EventHandler IdTipoProveedorChanged;
		public event EventHandler IdSubTipoProveedorChanged;		
		
		
		
		#endregion
		
		#region Métodos  Públicos		
		public void GetSubTipos(string padre)
		{
			_brClass.GetSubTipos(padre);					
		}
		public void GetObservacion() 
		{
			_brClass.GetObservacion();
		}
		
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			//this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			this._brClass.TiposHasChanged +=new EventHandler(_brClass_TiposHasChanged);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());

			/*if (CuentaChanged != null )
			{
				CuentaChanged( this, new System.EventArgs() );
			}*/			
			if (this._codigoCuenta.CompareTo(_brClass.CodigoCuenta) != 0)
			{
				_codigoCuenta = _brClass.CodigoCuenta;
				if (CodigoCuentaChanged != null)
					CodigoCuentaChanged(this, new EventArgs());
			}

			if (this._idProveedor.CompareTo(_brClass.IdProveedor) != 0)
			{
				_idProveedor = _brClass.IdProveedor;
				if (IdProveedorChanged != null)
					IdProveedorChanged(this, new EventArgs());
			}

			if (_idEstado.CompareTo(_brClass.IdEstado ) != 0)
			{
				_idEstado = _brClass.IdEstado;
				if (IdEstadoChanged != null)
					IdEstadoChanged(this, new EventArgs());
			}
			if (_idEstadoProveedor.CompareTo(_brClass.IdEstadoProveedor ) != 0)
			{
				_idEstado = _brClass.IdEstadoProveedor;
				if (IdEstadoProveedorChanged != null)
					IdEstadoProveedorChanged(this, new EventArgs());
			}
			if (_idTipo.CompareTo(_brClass.IdTipo ) != 0)
			{
				_idTipo = _brClass.IdTipo;
				if (IdTipoChanged != null)
					IdTipoChanged(this, new EventArgs());
			}

			if (_idTipoProveedor.CompareTo(_brClass.IdTipoProveedor ) != 0)
			{
				_idTipoProveedor = _brClass.IdTipoProveedor;
				if (IdTipoProveedorChanged != null)
					IdTipoProveedorChanged(this, new EventArgs());
			}
			
			if (_idSubTipo.CompareTo(_brClass.IdSubTipo ) != 0)
			{
				_idSubTipo = _brClass.IdSubTipo;
				if (IdSubTipoChanged != null)
					IdSubTipoChanged(this, new EventArgs());
			}	
			if (_idSubTipoProveedor.CompareTo(_brClass.IdSubTipoProveedor ) != 0)
			{
				_idSubTipoProveedor = _brClass.IdSubTipoProveedor;
				if (IdSubTipoProveedorChanged != null)
					IdSubTipoProveedorChanged(this, new EventArgs());
			}	
			if (_idUsuario.CompareTo(_brClass.IdUsuario ) != 0)
			{
				_idUsuario = _brClass.IdUsuario;
				if (IdUsuario != null)
					IdUsuarioChanged(this, new EventArgs());
			}	
		}
		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
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
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}
		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
		}
		public ItemsDatasetErrors GetErrors()
		{			
			return _brClass.GetErrors();				
		}
		public string GetWarnings()
		{
			return null;
		}
		public void RefreshData()
		{
			
		}
		public void Execute() 
		{													
			this._brClass.Execute();
		}
		public bool AllowShow()
		{
			return _allowShow;
		}
		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

		private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			/*if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());*/
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}

		private void _brClass_TiposHasChanged(object sender, EventArgs e)
		{
			if(TiposHasChanged != null)
				TiposHasChanged(this, new EventArgs());
		}
	}
}
