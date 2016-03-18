using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmPerfil.
	/// </summary>
	public class AbmPerfilController: ITaskController
	{
		#region Constructores
		public AbmPerfilController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public AbmPerfilController(AbmPerfil brClass)
		{
			_brClass=brClass;
			Init();
		}
		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

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

		
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}
		
		#endregion

		#region Variables Privadas
		private AbmPerfil _brClass;
		private ProcessControllerManager _processManager;
		private string _leyendaFormulario = string.Empty;
		
		#endregion

		#region Metodos Privadas
		private void Init()
		{
			SetLeyendaFormulario();
		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}
		#endregion
		
		#region Metodos Publicos
		public string LeyendaFormulario()
		{
			return this._leyendaFormulario;
		}
		public void AddIdPerfilesACopiar(string idPerfil)
		{
			_brClass.AddIdPerfilesACopiar(idPerfil);
		}
		#endregion

		#region Propiedades
		// -------------------------- CmbPerfiles
		public string KeyValuePerfil
		{
			get { return "IdPerfil" ; }
		}
		public string KeyListPerfil
		{
			get { return "Descripcion" ; }
		}
		// --------------------------
		public Perfil Perfil
		{
			get{return _brClass.Perfil;}
		}
		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}
		public bool EditMode
		{
			get{return _brClass.EditMode;}
		}
		public ArrayList PerfilesVisibles
		{
			get{return _brClass.PerfilesVisibles;}
		}
		public DataTable DataTablePerfilesVisibles
		{
			get{return _brClass.DataTablePerfilesVisibles;}
		}
		public ArrayList IdPerfilesACopiar
		{
			get{return _brClass.IdPerfilesACopiar;}
			set{_brClass.IdPerfilesACopiar=value;}
		}
		// ----------- Prop de la la variable _brClass._perfil
		public string IdPerfil
		{
			get{return _brClass.IdPerfil;}
			set{_brClass.IdPerfil=value;}
		}
		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set{_brClass.Descripcion=value;}
		}
		public bool Activo
		{
			get{return _brClass.Activo;}
			set{_brClass.Activo=value;}
		}
		// ----------- 
		public bool PreguntarAlCancelar
		{
			get	{return _brClass.PreguntarAlCancelar;}
		}
		#endregion		
		
	}
}
