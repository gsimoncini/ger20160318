using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmProveedoresController.
	/// </summary>
	public class AbmProveedoresController//: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmProveedores _brClass;
		public AbmProveedoresController()
		{			
			_brClass = new AbmProveedores();
			Init();
		}

		public AbmProveedoresController(string IdProveedor)
		{			
			_brClass = new AbmProveedores(IdProveedor);
			Init();
		}

		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		#endregion

		#region Propiedades	

		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}


		private DataTable _localidades = null;
		public DataTable Localidades
		{
			get{return _localidades;}
		}

		private DataTable _provincias = null;
		public DataTable Provincias
		{
			get{return _provincias;}
		}

		private DataTable _paises = null;
		public DataTable Paises
		{
			get{return _paises;}
		}



		public string KeyValuePaises
		{
			get { return "IdPais" ; }
		}		
		
		public string KeyListPaises
		{
			get { return "Nombre" ; }
		}

		public string KeyValueProvincias
		{
			get { return "IdProvincia" ; }
		}		
		
		public string KeyListProvincias
		{
			get { return "Nombre" ; }
		}

		public string KeyValueLocalidades
		{
			get { return "IdLocalidad" ; }
		}		
		
		public string KeyListLocalidades
		{
			get { return "Descripcion" ; }
		}

		public long IdPaisEdicion
		{
			get{return _brClass.IdPaisEdicion;}
			set{_brClass.IdPaisEdicion = value;}
		}
		public long IdProvinciaEdicion
		{
			get{return _brClass.IdProvinciaEdicion;}
			set{_brClass.IdProvinciaEdicion = value;}
		}


		public decimal AlicuotaRetencionIIBBCompras 
		{
			get{return _brClass.AlicuotaRetencionIIBBCompras;}
			set{_brClass.AlicuotaRetencionIIBBCompras = value;}
		}
	
		
		public decimal AlicuotaRetencionIIBBServicios
		{
			get{return _brClass.AlicuotaRetencionIIBBServicios;}
			set{_brClass.AlicuotaRetencionIIBBServicios = value;}
		}


		public string Codigo
		{
			get
			{
				return _brClass.Codigo;
			}
			set
			{
				_brClass.Codigo = value;
			}
		}
		
		public bool ExcluyeRetencionIIBB
		{
			get{return _brClass.ExcluyeRetencionIIBB;}
			set{_brClass.ExcluyeRetencionIIBB = value;}
		}

		public bool ExcluyeRetencionIVA
		{
			get{return _brClass.ExcluyeRetencionIVA;}
			set{_brClass.ExcluyeRetencionIVA = value;}
		}

		public long IdCondicionRetecionGanancias
		{
			get{return _brClass.IdCondicionRetecionGanancias;}
			set{_brClass.IdCondicionRetecionGanancias = value;}
		}

		public string EtiquetaCampoAuxiliar1
		{
			get
			{
				return this._etiquetaCampoAuxiliar1;
			}
		}
				
		public string EtiquetaCampoAuxiliar2
		{
			get
			{
				return this._etiquetaCampoAuxiliar2;
			}
		}

		public string EtiquetaCampoAuxiliar3
		{
			get
			{
				return this._etiquetaCampoAuxiliar3;
			}
		}

		public string EtiquetaCampoAuxiliar4
		{
			get
			{
				return this._etiquetaCampoAuxiliar4;
			}
		}

		public string EtiquetaCampoAuxiliar5
		{
			get
			{
				return this._etiquetaCampoAuxiliar5;
			}
		}

		public string CampoAuxiliar1
		{
			get
			{
				return _brClass.CampoAuxiliar1;
			}
			set
			{
				_brClass.CampoAuxiliar1 = value;
			}
		}
		
		public string CampoAuxiliar2
		{
			get
			{
				return _brClass.CampoAuxiliar2;
			}
			set
			{
				_brClass.CampoAuxiliar2 = value;
			}
		}

		public string CampoAuxiliar3
		{
			get
			{
				return _brClass.CampoAuxiliar3;
			}
			set
			{
				_brClass.CampoAuxiliar3 = value;
			}
		}
		
		public string CampoAuxiliar4
		{
			get
			{
				return _brClass.CampoAuxiliar4;
			}
			set
			{
				_brClass.CampoAuxiliar4 = value;
			}
		}
		
		public decimal CampoAuxiliar5
		{
			get
			{
				return _brClass.CampoAuxiliar5;
			}
			set
			{
				_brClass.CampoAuxiliar5 = value;
			}
		}

		public string IdProveedor
		{
			get { return _brClass.IdProveedor;}
			set {_brClass.IdProveedor = value;	}
		}		
		public string Nombre
		{
			get { return _brClass.Nombre;}
			set { _brClass.Nombre = value;	}
		}		
		public DataTable TiposDocumento 
		{
			get { return _brClass.TiposDocumentos;}			
		}
		public DataTable CategoriasIva 
		{
			get { return _brClass.CategoriasIva;}			
		}
		public DataTable TiposMovimientos
		{
			get {return _brClass.TiposMovimientos;}
		}
		public DataTable SubTiposMovimientos
		{
			get {return _brClass.SubTiposMovimientos;}
		}
		public DataTable CondicionesDeCompra
		{
			get {return _brClass.CondicionesDeCompra;}
		}
		public DataTable Estados
		{
			get {return _brClass.Estados;}
		}
		public string IdTitular
		{
			get { return _brClass.IdTitular;}
			set { _brClass.IdTitular = value;	}
		}		
		public string IdCategoriaIva
		{
			get { return _brClass.IdCategoriaIva;}
			set { _brClass.IdCategoriaIva = value;	}
		}		
		public string IdCategoriaIvaDefault
		{
			get { return _brClass.IdCategoriaIvaDefault;}			
		}
		public string IdTipoDocumento
		{
			get { return _brClass.IdTipoDocumento;}
			set { _brClass.IdTipoDocumento = value;	}
		}		
		public string Numero
		{
			get { return _brClass.Numero;}
			set { _brClass.Numero = value;	}
		}
		private string _domicilio = "";
		public string Domicilio
		{
			get { return _brClass.Domicilio;}
			set { _brClass.Domicilio = value;	}
		}
		private string _horarioComercial = "";
		public string HorarioComercial
		{
			get { return _brClass.HorarioComercial;}
			set { _brClass.HorarioComercial = value;	}
		}
		private string _observaciones = "";
		public string Observaciones
		{
			get { return _brClass.Observaciones;}
			set { _brClass.Observaciones = value;	}
		}
		private string _telefonos = "";
		public string Telefonos
		{
			get { return _brClass.Telefonos;}
			set { _brClass.Telefonos = value;	}
		}
		private string _email = "";
		public string Email
		{
			get { return _brClass.Email;}
			set { _brClass.Email = value;	}
		}
		private string _instantMessenger = "";
		public string InstantMessenger
		{
			get { return _brClass.InstantMessenger;}
			set { _brClass.InstantMessenger = value;	}
		}
		private string _web = "";
		public string Web
		{
			get { return _brClass.Web;}
			set { _brClass.Web = value;	}
		}
		private decimal _bonificacionGeneral;
		public decimal BonificacionGeneral
		{
			get { return _brClass.BonificacionGeneral;}
			set { _brClass.BonificacionGeneral = value;	}
		}		
		public string IdLocalidad
		{
			get { return _brClass.IdLocalidad;}
			set { _brClass.IdLocalidad = value;	}
		}		
		public string IdTipoDeMovimiento
		{
			get { return _brClass.IdTipoDeMovimiento;}
			set { _brClass.IdTipoDeMovimiento = value;	}
		}
		
		public string IdSubTipoDeMovimiento
		{
			get { return _brClass.IdSubTipoDeMovimiento;}
			set { _brClass.IdSubTipoDeMovimiento = value;	}
		}
		public bool ExcluyeRetenciones
		{
			get { return _brClass.ExcluyeRetenciones;}
			set { _brClass.ExcluyeRetenciones = value;	}
		}
		public bool Activo
		{
			get { return _brClass.Activo;}
			set { _brClass.Activo = value;	}
		}		
		public string IdCondicionDeCompra
		{
			get { return _brClass.IdCondicionDeCompra;}
			set { _brClass.IdCondicionDeCompra = value;	}
		}		
		public long DiasDemoraEntrega
		{
			get { return _brClass.DiasDemoraEntrega;}
			set { _brClass.DiasDemoraEntrega = value;	}
		}		
		public long IdEstado
		{
			get { return _brClass.IdEstado;}
			set { _brClass.IdEstado = value;	}
		}
		public long IdEstadoDefault
		{
			get { return _brClass.IdEstadoDefault;}			
		}
		/*		
	
	
	[IdEstado] [bigint] NULL ,*/

		/*public string TextoBotonAnterior
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
		*/
		public bool IsValid 
		{
			get {return _isValid;}
		}	
		
		public bool HasErrors
		{
			get { return _brClass.HasErrors; }			
		}
		
		public DataTable Errors
		{
			get {return _brClass.Errors;}
		}

		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
			set{_brClass.Jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
			set{_brClass.Jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
			set{_brClass.Jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
			set{_brClass.Jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
			set{_brClass.Jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
			set{_brClass.Jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
			set{_brClass.Jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
			set{_brClass.Jerarquia8 = value;}
		}

		private bool _buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Proveedores.BuscadorJerarquico.AllowMultipleSelect");
		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get {return _buscadorJerarquicoAllowMultipleSelect; }
		}		

		public AbmProveedores.ProveedoresJearaquias Jerarquias
		{
			get{return _brClass.Jerarquias;}
		}

		public string ResponsableIngreso
		{
			get{return _brClass.ResponsableIngreso;}
			set{_brClass.ResponsableIngreso=value;}
		}
		public string IdResponsableIngreso
		{
			get{return _brClass.IdResponsableIngreso;}
			set{_brClass.IdResponsableIngreso=value;}
		}
		public bool AllowEditResponsableIngreso
		{
			get{return _brClass.AllowEditResponsableIngreso;}
			set{_brClass.AllowEditResponsableIngreso=value;}
		}
		public bool AskForPasswordResponsableIngreso
		{
			get{return _brClass.AskForPasswordResponsableIngreso;}
			set{_brClass.AskForPasswordResponsableIngreso=value;}
		}
		public string UltimoResponsableClaveCorrecta
		{
			get{return _brClass.UltimoResponsableClaveCorrecta;}
			set{_brClass.UltimoResponsableClaveCorrecta=value;}
		}

		#endregion

		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		private string _etiquetaCampoAuxiliar3 = string.Empty;	
		private string _etiquetaCampoAuxiliar4 = string.Empty;	
		private string _etiquetaCampoAuxiliar5 = string.Empty;

		private long _idProvinciaEdicion = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
		private long _idPaisEdicion = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");

		private string _contenedoresVisibles = string.Empty;
		private string _contenedoresHabilitados = string.Empty;		
						
		#endregion
	
		#region Eventos y delegados	
		public event EventHandler TiposHasChanged;
		public event EventHandler IdTipoDeMovimientoChanged;	
		public event EventHandler IdSubTipoDeMovimientoChanged;	
		public event EventHandler IdCategoriaIvaChanged;	
		public event EventHandler IdEstadoChanged;			
		//public event EventHandler OnTaskAfterExecute;
		/*public event EventHandler ClaveAnteriorChanged;		
		public event EventHandler ClaveNueva1Changed;		
		public event EventHandler ClaveNueva2Changed;
		public event EventHandler IdUsuarioChanged;*/
		#endregion
		
		#region Métodos  Públicos

		public DataTable ProvinciasPais(long idPais)
		{
			return  businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
		}
		public DataTable LocalidadPcia(long idPcia)
		{
			return  businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idPcia).tsh_Localidades;
		}

		//Cristian 20101116 - Tarea 932
        public String CodigoPostalLocalidad(string idLocalidad )
        {
            /* Silvina 20110104 - Tarea 1017 */
            tsh_LocalidadesDataset.tsh_LocalidadesRow row = businessrules.tsh_Localidades.GetByPk(idLocalidad);
            if (row != null)
                return row.CodigoPostal;
            return string.Empty;
            /* Fin Silvina */
        }
		
        //Fin Tarea 932

		public void GetProveedor()
		{
			_brClass.GetProveedor();
			if(_brClass.IdProveedor != null && !_brClass.IdProveedor.Equals(string.Empty))
			{
				if(!_brClass.IdProvinciaEdicion.Equals(long.MinValue))
				{
					_localidades = businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(IdProvinciaEdicion).tsh_Localidades;
				}
			}
		}
		public void Execute()
		{
			_brClass.Execute();
		}
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
			this._etiquetaCampoAuxiliar1 = Variables.GetValueString("Proveedores.CampoAuxiliar1.Etiqueta");
			this._etiquetaCampoAuxiliar2 = Variables.GetValueString("Proveedores.CampoAuxiliar2.Etiqueta");
			this._etiquetaCampoAuxiliar3 = Variables.GetValueString("Proveedores.CampoAuxiliar3.Etiqueta");
			this._etiquetaCampoAuxiliar4 = Variables.GetValueString("Proveedores.CampoAuxiliar4.Etiqueta");
			this._etiquetaCampoAuxiliar5 = Variables.GetValueString("Proveedores.CampoAuxiliar5.Etiqueta");

			_paises = businessrules.tsh_Paises.GetList().tsh_Paises;
			_provincias = businessrules.tsh_Provincias.GetList().tsh_Provincias;

			_contenedoresVisibles = Variables.GetValueString("Momentos.ABMProveedores.ContenedoresVisibles");
			_contenedoresHabilitados = Variables.GetValueString("Momentos.ABMProveedores.ContenedoresHabilitados");
			
	
			
		}
		
		private void InitEvents()
		{
/*			this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			*/
			this._brClass.TiposHasChanged+=new EventHandler(_brClass_TiposHasChanged);
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{
			/*if (_claveAnterior != _brClass.ClaveAnterior) 
			{
				_claveAnterior = _brClass.ClaveAnterior;
				if (ClaveAnteriorChanged != null)
					ClaveAnteriorChanged(this, new EventArgs());
			}
			if (_claveNueva1 != _brClass.ClaveNueva1) 
			{
				_claveNueva1 = _brClass.ClaveNueva1;
				if (ClaveNueva1Changed != null)
					ClaveNueva1Changed(this, new EventArgs());
			}			
			if (_claveNueva2 != _brClass.ClaveNueva2) 
			{
				_claveNueva2 = _brClass.ClaveNueva2;
				if (ClaveNueva2Changed != null)
					ClaveNueva2Changed(this, new EventArgs());
			}			
			if (_idUsuario.CompareTo(_brClass.IdUsuario ) != 0)
			{
				_idUsuario = _brClass.IdUsuario;
				if (IdUsuarioChanged != null)
					IdUsuarioChanged(this, new EventArgs());
			}		*/
		}
		#endregion

		#region Miembros de ITaskController
/*
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
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
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
			*/
		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}
		#endregion

	/*	private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}

		public bool EnabledSetPreviuosPassword
		{
			get { return _brClass.EnabledSetPreviousPassword; }
		}
		private string _idUsuario = string.Empty;
		public object IdUsuario
		{
			get { return _brClass.IdUsuario ; }
			set 
			{ 
				if (_brClass.IdUsuario.CompareTo( value ) != 0)
				{
					_idUsuario = Convert.ToString(value);
					_brClass.IdUsuario = Convert.ToString(value) ; 
					if (this.IdUsuarioChanged != null)
						IdUsuarioChanged (this, new EventArgs());
				}
			}

		}
		public System.Data.DataTable Usuarios
		{
			get { return _brClass.Usuarios ; }
		}
		public string KeyValueUsuarios
		{
			get { return "IdUsuario" ; }
		}
		public string KeyListUsuarios
		{
			get { return "Nombre" ; }
		}*/

		private void _brClass_TiposHasChanged(object sender, EventArgs e)
		{
			if (this.TiposHasChanged != null)
				TiposHasChanged (this, new EventArgs());
		}
	}
}
