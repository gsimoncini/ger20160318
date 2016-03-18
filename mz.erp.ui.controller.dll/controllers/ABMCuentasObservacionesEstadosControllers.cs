using System;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de CuentasObservacionesEstadosControllers.
	/// </summary>
	public class ABMCuentasObservacionesEstadosControllers:ITaskController
	{
		public ABMCuentasObservacionesEstadosControllers()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public ABMCuentasObservacionesEstadosControllers(ABMCuentasObservacionesEstados brClass)
		{
			_brClass = brClass;	
			//Init();
		}

		#region Variables Privadas
			
		private ABMCuentasObservacionesEstados _brClass;
		private ProcessControllerManager _processManager;
		
		#endregion
		private string _descripcion=string.Empty;
		private string _idCuentaObservacionEstado=string.Empty;
		private bool _activo=true;
		

		public string Descripcion
		{
			get
			{
				return _brClass.Descripcion;
			}
			set
			{
				_brClass.Descripcion = value;
			}
		}
		
		public string IdCuentaObservacionEstado
		{
			get
			{
				return _brClass.IdCuentaObservacionEstado;
			}
			set
			{
				_brClass.IdCuentaObservacionEstado = value;
			}
		}
		
		public string IdProveedorObservacionEstado
		{
			get
			{
				return _brClass.IdProveedorObservacionEstado;
			}
			set
			{
				_brClass.IdProveedorObservacionEstado = value;
			}
		}
		public bool Activo
		{
			get
			{
				return _brClass.Activo;
			}
			set
			{
				_brClass.Activo= value;
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
		public string Leyenda
		{
			get 
			{
				return _brClass.Leyenda;
			}
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}
		#region Propiedades
			
	
		
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

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
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
		
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}
		public void Continue()
		{

		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		#endregion
		public string ContenedoresVisibles(){
			//Si es un alta se tiene q ver solo la parte de ingreso de datos, sino la busqueda tambien
			if (_brClass.modo()=="new"){
				return "DatosGenerales";
			}
			else return "";
		}
		//Cuando busco actualiza los controles de la interface
		public void UpdateElementos(ArrayList rows)
		{
			this._brClass.UpdateElementos(rows);
		}

	}
}
