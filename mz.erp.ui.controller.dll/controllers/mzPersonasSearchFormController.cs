using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzPersonasSearchFormController.
	/// </summary>
	public class mzPersonasSearchFormController: ITaskController
	{

		#region Constructores

		public mzPersonasSearchFormController()
		{
			_brClass = new mzPersonasSearchForm();
			_leyendaFormulario = "Búsqueda de Personas";			
			Init();
		}

		public mzPersonasSearchFormController(mzPersonasSearchForm brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private mzPersonasSearchForm _brClass;
		private string _leyendaFormulario = string.Empty;
		private string _idPersonaSeleccionada = string.Empty;
		#endregion

		#region Propiedades

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public string Nombre
		{
			get { return _brClass.Nombre;}
			set { _brClass.Nombre = value;}
		}

		public string Telefonos
		{
			get { return _brClass.Telefonos;}
			set { _brClass.Telefonos = value;}
		}

		public string Email
		{
			get { return _brClass.Email;}
			set { _brClass.Email = value;}
		}

		public bool Activo
		{
			get { return _brClass.Activo;}
			set { _brClass.Activo = value;}
		}

		public bool ByActivo
		{
			get { return _brClass.ByActivo;}
			set { _brClass.ByActivo = value;}
		}

		public string IdPersonaSeleccionada
		{
			get {return _idPersonaSeleccionada;}
			set {_idPersonaSeleccionada = value;}
		}
		#endregion

		#region Eventos
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}



		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
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
			_brClass.Execute();
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
			SetLeyendaFormulario();
		}

		
		private void InitEventHandlers()
		{
		}

		private void SetLeyendaFormulario()
		{
			if(_leyendaFormulario.Equals(string.Empty))
			{
				string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
				if (leyenda.Equals(string.Empty))
				{
					leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
				}
				if (leyenda.Equals(string.Empty))
				{
					leyenda = this._brClass.GetTaskName();
				}
				this._leyendaFormulario = leyenda;
			}
		}

		#endregion

		#region Métodos Públicos

		public DataView SearchNow()
		{
			return _brClass.SearchNow();
		}

		#endregion

	}
}
