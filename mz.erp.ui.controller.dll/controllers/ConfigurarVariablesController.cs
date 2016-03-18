using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfigurarVariablesController.
	/// </summary>
	public class ConfigurarVariablesController: ITaskController
	{
		#region Contructores
		public ConfigurarVariablesController(ConfigurarVariables brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private ConfigurarVariables _brClass;
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
			get {return _brClass.PreguntarAlCancelar;}
		}

		public ArrayList DatosNuevos
		{
			get 
			{
				return _brClass.DatosNuevos;
			}
		}

		public ArrayList DatosNuevosSeleccionados
		{
			set 
			{
				_brClass.DatosNuevosSeleccionados = value;
			}
		}

		public ArrayList Variables
		{
			get 
			{
				return _brClass.Variables;
			}
		}

		public ArrayList VariablesSeleccionadas
		{
			set 
			{
				_brClass.VariablesSeleccionadas = value;
			}
		}

		public ArrayList Usuarios
		{
			get 
			{
				return _brClass.Usuarios;
			}
		}

		public ArrayList UsuariosSeleccionados
		{
			set 
			{
				_brClass.UsuariosSeleccionados = value;
			}
		}

		public ArrayList Perfiles
		{
			get 
			{
				return _brClass.Perfiles;
			}
		}
		
		public ArrayList PerfilesSeleccionados
		{
			set 
			{
				_brClass.PerfilesSeleccionados = value;
			}
		}

		public ArrayList Puestos
		{
			get 
			{
				return _brClass.Puestos;
			}
		}
		
		public ArrayList PuestosSeleccionados
		{
			set 
			{
				_brClass.PuestosSeleccionados = value;
			}
		}

		public ArrayList Empresas
		{
			get 
			{
				return _brClass.Empresas;
			}
		}
		
		public ArrayList EmpresasSeleccionadas
		{
			set 
			{
				_brClass.EmpresasSeleccionadas = value;
			}
		}

		public ArrayList Sucursales
		{
			get 
			{
				return _brClass.Sucursales;
			}
		}
		
		public ArrayList SucursalesSeleccionadas
		{
			set 
			{
				_brClass.SucursalesSeleccionadas = value;
			}
		}

		public ArrayList ConfiguracionesNuevas
		{
			get {return _brClass.ConfiguracionesNuevas;}
		}
		
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler ConfiguracionesNuevasHasChanged;
		#endregion

		#region Métodos  Públicos 
		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.sy_ConfigurarVariables( new string[] {"IdVariable", "DescripcionDatoNuevo", "IdHabilitado", "IdHabilitadoL", "IdHabilitadoLAux", "DescripcionHabilitado", "TipoHabilitado"}).GetLayoutEx()); 
		}

		public void AddConfiguracion(string IdVariable, string DescripcionDatoNuevo, string IdHabilitado, long IdHabilitadoL, long IdHabilitadoLAux, string DescripcionHabilitado, string TipoHabilitado)
		{
			_brClass.AddConfiguracion(IdVariable, DescripcionDatoNuevo, IdHabilitado, IdHabilitadoL, IdHabilitadoLAux, DescripcionHabilitado, TipoHabilitado);
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
		}

		private void InitEventHandlers()
		{
			this._brClass.ConfiguracionesNuevasHasChanged+=new EventHandler(_brClass_ConfiguracionesNuevasHasChanged);
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

		private void _brClass_ConfiguracionesNuevasHasChanged(object sender, EventArgs e)
		{
			if(ConfiguracionesNuevasHasChanged != null)
				ConfiguracionesNuevasHasChanged(this, new EventArgs());	
		}
	}
}
