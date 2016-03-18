using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmTiposMovimientosController.
	/// </summary>
	public class AbmTiposMovimientosController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmTiposMovimientos _brClass;
		public AbmTiposMovimientosController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AbmTiposMovimientosController(mz.erp.businessrules.AbmTiposMovimientos brClass)
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
		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		
		#endregion

		#region Variables Privadas							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
		private string _layoutTiposMovimientos = string.Empty;
		private string _layoutSubTiposMovimientos = string.Empty;

		#endregion

		#region Variables Privadas Datos
		public bool IsValid 
		{
			get {return _isValid;}
		}
		public string LayoutTiposMovimientos
		{
			get { return _layoutTiposMovimientos ; }
		}
		public string LayoutSubTiposMovimientos
		{
			get { return _layoutSubTiposMovimientos ; }
		}					

		/*		private string _claveAnterior = string.Empty;
				public string ClaveAnterior
				{
					get {return _brClass.ClaveAnterior;}
					set 
					{
						if (_claveAnterior!= value) 
						{
							_claveAnterior = value;
							_brClass.ClaveAnterior = value;
							if(ClaveAnteriorChanged != null)
								ClaveAnteriorChanged(this, new EventArgs());	
						}				
					}
				}

				private string _claveNueva1 = string.Empty;
				public string ClaveNueva1
				{
					get {return _brClass.ClaveNueva1;}
					set 
					{
						if (_claveNueva1!= value) 
						{
							_claveNueva1 = value;
							_brClass.ClaveNueva1 = value;
							if(ClaveNueva1Changed != null)
								ClaveNueva1Changed(this, new EventArgs());	
						}				
					}
				}

				private string _claveNueva2 = string.Empty;
				public string ClaveNueva2
				{
					get {return _brClass.ClaveNueva2;}
					set 
					{
						if (_claveNueva2!= value) 
						{
							_claveNueva2 = value;
							_brClass.ClaveNueva2 = value;
							if(ClaveNueva2Changed != null)
								ClaveNueva2Changed(this, new EventArgs());	
						}				
					}
				}*/

		#endregion

		#region Eventos y delegados			
		public event System.EventHandler TiposMovimientosHasChanged;		
		public event System.EventHandler TiposMovimientosNuevosHasChanged;
		#endregion
		
		#region Métodos  Públicos
		public void AddMovimiento(string DescripcionTipo, string KeyTipo, string DescripcionSubTipo, string KeySubTipo, bool EsIngreso, string Modo, bool Activo)
		{
			_brClass.AddMovimiento(DescripcionTipo, KeyTipo, DescripcionSubTipo, KeySubTipo, EsIngreso, Modo, Activo);
		}
		public void RemoveMovimiento(string KeyTipo, string KeySubTipo)
		{
			_brClass.RemoveMovimiento(KeyTipo, KeySubTipo);
		}
        //Cristian tarea 0000112
        public void RemoveModificacion(String keyTipo)
        {
            _brClass.RemoveModificacion(keyTipo);
        }
        //Fin cristian
		public void GetSubTipos(string KeyTipo)
		{
			//_brClass.GetSubTipos(KeyTipo);
		}
		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.tsy_TiposMovimientos( new string[] {"KeyTipo", "DescripcionTipo", "KeySubTipo", "DescripcionSubTipo"}).GetLayoutEx()); 
		}

		public bool TieneMovimientosAsociados( string Key, string Tipo)
		{
			return _brClass.TieneMovimientosAsociados(Key, Tipo);
		}

		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
			_layoutTiposMovimientos = this.GetLayoutTiposMovimienos();
			_layoutSubTiposMovimientos = this.GetLayoutSubTiposMovimienos();
		}
		
		private void InitEvents()
		{
			this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			//this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
			this._brClass.TiposMovimientosNuevosHasChanged+=new EventHandler(_brClass_TiposMovimientosNuevosHasChanged);
			this._brClass.TiposMovimientosHasChanged+=new EventHandler(_brClass_TiposMovimientosHasChanged);
			//this._brClass.SubTiposMovimientosHasChanged+=new EventHandler(_brClass_SubTiposMovimientosHasChanged);
			
			//this._brClass.TiposMovimientosNuevosHasChanged
			
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{		
		}

		private string GetLayoutTiposMovimienos( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
						
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoMovimiento", "IdTipoMovimiento", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250) );
			sb.Append( LayoutBuilder.GetRow( i++, "Tipo Movimiento", "Tipo de Movimiento", 70) );
            //CRistian Tarea 0000112 30110606
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50,Types.ColumnTypes.CheckBox) );
            //FIn cristian Tarea 0000112
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		private string GetLayoutSubTiposMovimienos( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
						
			sb.Append( LayoutBuilder.GetRow( i++, "IdSubTipoMovimiento", "IdSubTipoMovimiento", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250) );
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", true) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
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
			//CallRefresh();
		}
		public System.Data.DataTable TiposMovimientos 
		{
			get {return _brClass.TiposMovimientos;}
		}		

		public System.Data.DataSet TiposSubTipos 
		{
			get {return _brClass.TiposSubTipos;}
		}
		public System.Collections.ArrayList TiposMovimientosNuevos
		{
			get {return _brClass.TiposMovimientosNuevos;}
		}
		public string KeyValueTiposMovimientos
		{
			get { return "IdTipoMovimiento" ; }
		}
		public string KeyListTiposMovimientos
		{
			get { return "Descripcion" ; }
		}



		private void _brClass_TiposMovimientosNuevosHasChanged(object sender, EventArgs e)
		{
			if(TiposMovimientosNuevosHasChanged != null)
				TiposMovimientosNuevosHasChanged(this, new EventArgs());	
		}
		private void _brClass_TiposMovimientosHasChanged(object sender, EventArgs e)
		{
			if(TiposMovimientosHasChanged != null)
				TiposMovimientosHasChanged(this, new EventArgs());	
		}

		public bool PerteneceAPerfilSuperior
		{
			get { return _brClass.PerteneceAPerfilSuperior;}
		}
		
	}
}
