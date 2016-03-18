using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;
using System.Data;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMEntidadesController.
	/// </summary>
	public class ABMEntidadesController:ITaskController
	{
		#region Contructores

		public ABMEntidadesController(AbmEntidades model)
		{
			_brClass = model;
			model.ObjectHasChanged+= new System.EventHandler( this.ListenerModelChanges );
			Init();
		}

		private void Init()
		{
		}

		#endregion

		#region Propiedades

		public string IdEntidad
		{
			get{return _brClass.IdEntidad;}
			set 
			{
				_brClass.IdEntidad = value;
			}
		}
		
		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set 
			{
				_brClass.Descripcion = value;
			}
		}

		public string Codigo
		{
			get{return _brClass.Codigo;}
			set 
			{
				_brClass.Codigo = value;
			}
		}
		
		/*
		public string IdNomenclatura
		{
			get{return _brClass.IdNomenclatura;}
			set 
			{
				_brClass.IdNomenclatura = value;
			}
		}*/

		public string Familia
		{
			get{return _brClass.Familia;}
			set 
			{
				_brClass.Familia = value;
			}
		}

		public bool Activo
		{
			get{return _brClass.Activo;}
			set 
			{
				_brClass.Activo = value;
			}
		}

		//private string _jerarquia = string.Empty;
		public string Jerarquia
		{
			get{
				return _brClass.Jerarquia;}
			set
			{
				_brClass.Jerarquia = value;
			}
		}

		public string Jerarquia1
		{
			get{
				return _brClass.Jerarquia1;}
			set
			{
				_brClass.Jerarquia1 = value;
			}
		}

		private Hashtable _familiasPorClaveLarga=new Hashtable();
		public Hashtable FamiliasPorClaveLarga
		{
			get{return _brClass.FamiliasPorClaveLarga;}
		}

		public bool TieneHijos
		{
			get{return _brClass.TieneHijos;}
		}

		public DataTable ListaSegundoNivel
		{
			get{return _brClass.ListaSegundoNivel;}
		}

		#endregion


		#region Variables Privadas

		private AbmEntidades _brClass;

		#endregion

		#region Eventos
			
		public event System.EventHandler OnControllerHasChanged;
		public event EventHandler JerarquiaChanged;
		public event EventHandler Jerarquia1Changed;

		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return null;
		}

		public void Continue()
		{
			
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return false;
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}

		public bool IsFirstTask()
		{
			
			return _processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return _processManager.IsNextState();
		}

		public bool IsBackState()
		{
			return _processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return false;
		}
		#endregion

		#region custom members
		
		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}
		public bool PreguntarAlCancelar
		{
			get{return _brClass.PreguntarAlCancelar;}
		}
		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}
		public string ContenedoresHabilitados
		{
			get{return _brClass.ContenedoresHabilitados;}
		}

		private void ListenerModelChanges( object sender, System.EventArgs e )
		{
			if (OnControllerHasChanged != null)
			{
				OnControllerHasChanged( null, new System.EventArgs() );
			}
			if (JerarquiaChanged != null)
			{
				JerarquiaChanged(null, new System.EventArgs() );
			}
			if (Jerarquia1Changed != null)
			{
				Jerarquia1Changed(null, new System.EventArgs() );
			}
		}

		#endregion

		public void seleccionarFamilia()
		{
			//Esto es para q tenga algo por default
			_brClass.seleccionarFamilia();
		}

		public void SeleccionarFamiliaDeNivel2()
		{
			//Esto es para q tenga algo por default
			_brClass.SeleccionarFamiliaDeNivel2();
		}

		public void ActualizarJerarquiaUno()
		{
			_brClass.ActualizarJerarquiaUno();
		}

		public DataTable GetTableFamiliasTDCompTesoreria()
		{
			return _brClass.GetTableFamiliasTDCompTesoreria();
		}

		public void BuscarNivelUno()
		{
			_brClass.BuscarNivelUno();
		}

		public void GetEntidad(string Codigo) 
		{
			_brClass.GetEntidad(Codigo);
		}

	}
}
