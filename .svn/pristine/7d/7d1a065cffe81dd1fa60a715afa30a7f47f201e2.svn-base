using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfigurarPreciosController.
	/// </summary>
	public class ConfigurarPreciosController: ITaskController
	{
		#region Contructores

		public ConfigurarPreciosController(ConfigurarPrecios brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private ConfigurarPrecios _brClass;
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
		
		public bool UsaLPProveedores
		{
			get {return _brClass.UsaLPProveedores;}
			set {_brClass.UsaLPProveedores = value;}
		}

		public ArrayList ConfiguracionesLPProveedores
		{
			get 
			{
				return _brClass.ConfiguracionesLPProveedores;
			}
		}

		public ArrayList ConfiguracionesLPProveedoresSeleccionadas
		{
			get 
			{
				return _brClass.ConfiguracionesLPProveedoresSeleccionadas;
			}
			set 
			{
				_brClass.ConfiguracionesLPProveedoresSeleccionadas = value;
			}

		}

		public bool TransladaCambioPcioDeCostoAPcioDeVtaFinal
		{
			get {return _brClass.TransladaCambioPcioDeCostoAPcioDeVtaFinal;}
			set {_brClass.TransladaCambioPcioDeCostoAPcioDeVtaFinal = value;}
		}

		public bool PcioVtaAfectaMac
		{
			get {return _brClass.PcioVtaAfectaMac;}
			set {_brClass.PcioVtaAfectaMac = value;}
		}

		public bool UsaCostosIndirectos
		{
			get {return _brClass.UsaCostosIndirectos;}
			set {_brClass.UsaCostosIndirectos = value;}
		}
		
		public ArrayList ConfiguracionesCostosIndirectos
		{
			get 
			{
				return _brClass.ConfiguracionesCostosIndirectos;
			}
		}

		public ArrayList ConfiguracionesCostosIndirectosSeleccionadas
		{
			get 
			{
				return _brClass.ConfiguracionesCostosIndirectosSeleccionadas;
			}
			set 
			{
				_brClass.ConfiguracionesCostosIndirectosSeleccionadas = value;
			}

		}

		public bool UsaPcioDeCostoReposicion
		{
			get {return _brClass.UsaPcioDeCostoReposicion;}
			set {_brClass.UsaPcioDeCostoReposicion = value;}
		}
		
		public ArrayList ConfiguracionesPcioDeCostoReposicion
		{
			get 
			{
				return _brClass.ConfiguracionesPcioDeCostoReposicion;
			}
		}

		public ArrayList ConfiguracionesPcioDeCostoReposicionSeleccionadas
		{
			get 
			{
				return _brClass.ConfiguracionesPcioDeCostoReposicionSeleccionadas;
			}
			set 
			{
				_brClass.ConfiguracionesPcioDeCostoReposicionSeleccionadas = value;
			}

		}

		public ArrayList ConfiguracionesPPP
		{
			get 
			{
				return _brClass.ConfiguracionesPPP;
			}
		}

		public ArrayList ConfiguracionesPPPSeleccionadas
		{
			get 
			{
				return _brClass.ConfiguracionesPPPSeleccionadas;
			}
			set 
			{
				_brClass.ConfiguracionesPPPSeleccionadas = value;
			}

		}

		public ArrayList ConfiguracionesValidaciones
		{
			get 
			{
				return _brClass.ConfiguracionesValidaciones;
			}
		}

		public ArrayList ConfiguracionesValidacionesSeleccionadas
		{
			get 
			{
				return _brClass.ConfiguracionesValidacionesSeleccionadas;
			}
			set 
			{
				_brClass.ConfiguracionesValidacionesSeleccionadas = value;
			}

		}
		#endregion

		#region Eventos y delegados		
		#endregion

		#region Métodos  Públicos 
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
