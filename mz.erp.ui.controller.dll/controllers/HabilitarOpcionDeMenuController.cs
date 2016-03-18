using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class HabilitarOpcionDeMenuController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.HabilitarOpcionDeMenu _brClass;
		public HabilitarOpcionDeMenuController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public HabilitarOpcionDeMenuController(mz.erp.businessrules.HabilitarOpcionDeMenu brClass)
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

		#region Variables Públicas Datos

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
		
		#endregion
		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
						
		#endregion

		#region Variables Privadas Datos
		public bool IsValid 
		{
			get {return _isValid;}
		}

		private string _opcionPadre = string.Empty;
		public string OpcionPadre
		{
			get {return _brClass.OpcionPadre;}
			set 
			{
				if (_opcionPadre!= value) 
				{
					_opcionPadre = value;
					_brClass.OpcionPadre = value;
					if(OpcionPadreChanged != null)
						OpcionPadreChanged(this, new EventArgs());	
				}				
			}
		}

		private string _opcion = string.Empty;
		public string Opcion
		{
			get {return _brClass.Opcion;}
			set 
			{
				if (_opcion!= value) 
				{
					_opcion = value;
					_brClass.Opcion = value;
					if(OpcionChanged != null)
						OpcionChanged(this, new EventArgs());	
				}				
			}
		}

		private string _titulo = string.Empty;
		public string Titulo
		{
			get {return _brClass.Titulo;}
			set 
			{
				if (_titulo!= value) 
				{
					_titulo = value;
					_brClass.Titulo = value;
					if(TituloChanged != null)
						TituloChanged(this, new EventArgs());	
				}				
			}
		}

		private ArrayList _perfiles = null;
		public ArrayList Perfiles
		{
			get {return _brClass.Perfiles;}
			set 
			{
				if (_perfiles!= value) 
				{
					_perfiles = value;
					_brClass.Perfiles = value;
					if(PerfilesChanged != null)
						PerfilesChanged(this, new EventArgs());	
				}				
			}
		}

		private string _layoutPerfiles = string.Empty;
		public string LayoutPerfiles 
		{
			get {return _layoutPerfiles;}
		}

		#endregion

		#region Eventos y delegados
			
		public event EventHandler OpcionPadreChanged;		
		public event EventHandler OpcionChanged;		
		public event EventHandler TituloChanged;
		public event EventHandler PerfilesChanged;
		#endregion
		
		#region Métodos  Públicos
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
			this._layoutPerfiles = Build_LayoutPerfiles();
		}
		
		private void InitEvents()
		{
			this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{
			if (_opcionPadre != _brClass.OpcionPadre) 
			{
				_opcionPadre = _brClass.OpcionPadre;
				if (OpcionPadreChanged != null)
					OpcionPadreChanged(this, new EventArgs());
			}
			if (_opcion != _brClass.Opcion) 
			{
				_opcion = _brClass.Opcion;
				if (OpcionChanged != null)
					OpcionChanged(this, new EventArgs());
			}			
			if (_titulo != _brClass.Titulo) 
			{
				_titulo = _brClass.Titulo;
				if (TituloChanged != null)
					TituloChanged(this, new EventArgs());
			}			
			if (_perfiles != _brClass.Perfiles) 
			{
				_perfiles = _brClass.Perfiles;
				if (PerfilesChanged != null)
					PerfilesChanged(this, new EventArgs());
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

		private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}
		private string Build_LayoutPerfiles()
		{			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			sb.Append( LayoutBuilder.GetRow( i++, "IdPerfil", "IdPerfil",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",100, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
		}

	}
}
