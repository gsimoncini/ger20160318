using System;
using mz.erp.businessrules;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmDomiciliosController.
	/// </summary>
	public class AbmDomiciliosController: ITaskController
	{
	    #region Contructores

		public AbmDomiciliosController()
		{
			_brClass = new AbmDomicilios();
			Init();
		}

		public AbmDomiciliosController(AbmDomicilios brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private AbmDomicilios _brClass;
		private bool _allowShow = true;	
		#endregion

		#region Variables Públicas
		#endregion

		#region Propiedades
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

		public DomicilioCuenta Domicilio
		{
			get{return _brClass.Domicilio;}
			set{_brClass.Domicilio = value;}
		}

		private DataTable _tiposDomicilios = null;
		public DataTable TiposDomicilios
		{
			get{return _tiposDomicilios;}
		}

		public string KeyValueTiposDomicilios
		{
			get { return "IdTipoDomicilio" ; }
		}		
		
		public string KeyListTiposDomicilios
		{
			get { return "Descripcion" ; }
		}

		private DataTable _usuariosPersonas = null;
		public DataTable UsuariosPersonas
		{
			get{return _usuariosPersonas;}
		}

		public string KeyValueUsuariosPersonas
		{
			get { return "IdPersona" ; }
		}		
		
		public string KeyListUsuariosPersonas
		{
			get { return "Nombre" ; }
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

		private DataTable _provincias = null;
		public DataTable Provincias
		{
			get{return _provincias;}
		}

		public string KeyValueProvincias
		{
			get { return "IdProvincia" ; }
		}		
		
		public string KeyListProvincias
		{
			get { return "Nombre" ; }
		}

		private DataTable _localidades = null;
		public DataTable Localidades
		{
			get{return _localidades;}
		}

		public string KeyValueLocalidades
		{
			get { return "IdLocalidad" ; }
		}		
		
		public string KeyListLocalidades
		{
			get { return "Descripcion" ; }
		}
		
		#endregion

		#region Eventos y delegados 
		#endregion

		#region Métodos  Públicos 
		public DataTable ProvinciasPais(long idPais)
		{
			return  businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
		}

		public DataTable LocalidadesProvincia(long idProvincia)
		{
			return  businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idProvincia).tsh_Localidades;
		}

		#endregion

		#region Métodos Privados

		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{
			SetCombosData();
		}
		private void SetCombosData()
		{
			_tiposDomicilios = mz.erp.businessrules.tcs_TiposDomicilios.GetList().tcs_TiposDomicilios;
			_usuariosPersonas = businessrules.data.UsuariosPersonas.GetList();
			_paises = businessrules.tsh_Paises.GetList().tsh_Paises;
			_provincias = businessrules.tsh_Provincias.GetList().tsh_Provincias;
			_localidades = businessrules.tsh_Localidades.GetList().tsh_Localidades;
		}

		private void InitEventHandlers()
		{
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
			
		#endregion
	}
}
