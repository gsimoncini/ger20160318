using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMVariablesController.
	/// </summary>
	public class ABMVariablesController: ITaskController
	{
		
		#region Constructores
		public ABMVariablesController(ABMVariables brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ABMVariables _brClass;
		private string _leyendaFormulario;
		#endregion
	
		#region Propiedades

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
			set{_leyendaFormulario = value;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		public string IdVariable 
		{
			get{return _brClass.IdVariable;}
			set{_brClass.IdVariable = value;}
		}

		public string IdVariableOriginal 
		{
			get{return _brClass.IdVariableOriginal;}
		}

		public string IdVariableAlta 
		{
			get{return _brClass.IdVariableAlta;}
			set{_brClass.IdVariableAlta = value;}
		}

		public string DescripcionAlta 
		{
			get{return _brClass.DescripcionAlta;}
			set{_brClass.DescripcionAlta = value;}
		}
		
		public string ValorAlta 
		{
			get{return _brClass.ValorAlta;}
			set{_brClass.ValorAlta = value;}
		}
		
		public string TipoAlta 
		{
			get{return _brClass.TipoAlta;}
			set{_brClass.TipoAlta = value;}
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
		
		public ArrayList Variables
		{
			get {return _brClass.Variables;}
		}
		
		public string Estado 
		{
			get{return _brClass.Estado;}
		}

		public ArrayList VariablesSeleccionadas
		{
			get {return _brClass.VariablesSeleccionadas;}
		}

		public bool ModificacionSimple
		{
			get {return _brClass.ModificacionSimple;}
		}

		#endregion

		#region Eventos
		public event System.EventHandler VariablesHasChanged;
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
			_brClass.VariablesHasChanged+=new EventHandler(_brClass_VariablesHasChanged);
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = mz.erp.businessrules.Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = mz.erp.businessrules.Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		#endregion

		#region Métodos Públicos

		public void AddVariable(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string Estado, string TipoVariable)
		{
			_brClass.AddVariable(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, Estado, TipoVariable);
		}

		public void AddVariableModif(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string TipoVariable)
		{
			_brClass.AddVariableModif(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, TipoVariable);
		}

		public void AddVariableDeleted(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string TipoVariable)
		{
			_brClass.AddVariableDeleted(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, TipoVariable);
		}

		public bool EsAlta()
		{
			return _brClass.EsAlta();
		}

		public string GetValorVariable(string IdVariableOriginal, string IdUsuario, long IdPerfil, long IdPuesto, string TipoVariable)
		{
			return _brClass.GetValorVariable(IdVariableOriginal, IdUsuario, IdPerfil, IdPuesto, TipoVariable);
		}
		#endregion

		private void _brClass_VariablesHasChanged(object sender, EventArgs e)
		{
			if(VariablesHasChanged != null)
				VariablesHasChanged(this, new EventArgs());	
		}


	}
}
