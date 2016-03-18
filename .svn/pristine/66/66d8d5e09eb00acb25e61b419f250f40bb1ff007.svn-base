using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfigurarMenuesController.
	/// </summary>
	public class ConfigurarMenuesController: ITaskController
	{
		#region Contructores
		public ConfigurarMenuesController()
		{			
		}

		public ConfigurarMenuesController(mz.erp.businessrules.ConfigurarMenues brClass)
		{
			_brClass = brClass;
			_model = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas							
		private bool _allowShow = true;		
		private mz.erp.businessrules.ConfigurarMenues _brClass;
		private mz.erp.businessrules.ConfigurarMenues _model;
		private Node _currentNode;
		private string _currentKey;
		private string _currentProcess = string.Empty;
		private string _currentDescription;
		private string _parentKey;
		private string _parentDescription;
		private bool _habilitado;		

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

		public bool PerfilSuperior
		{
			get 
			{
				return _brClass.PerfilSuperior;
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

		public ArrayList BarrasDeHerramientas
		{
			get 
			{
				return _brClass.BarrasDeHerramientas;
			}
		}

		public ArrayList BarrasDeHerramientasNuevas
		{
			get 
			{
				return _brClass.BarrasDeHerramientasNuevas;
			}
		}

		public string BarraHerramientaSeleccionada
		{
			get 
			{
				return _brClass.BarraHerramientaSeleccionada;
			}

			set 
			{
				_brClass.BarraHerramientaSeleccionada = value;
			}
		}

		public long IdBarraDeHerramientaSeleccionada
		{
			get 
			{
				return _brClass.IdBarraDeHerramientaSeleccionada;
			}
		}

		public string CurrentKey
		{
			get{return _currentKey;}
			set
			{
				_currentKey = value;
				if (!_currentKey.StartsWith("Separator_"))
					_brClass.RecuperarProceso(Convert.ToInt16(value));
			}
		}

		/*public string Id
		{
			get {return _brClass.Id;}
			set 
			{
				_brClass.Id = value;
			}
		}

		public long IdHerramientaPadre
		{
			get {return _brClass.IdHerramientaPadre;}
			set 
			{
				_brClass.IdHerramientaPadre = value;
			}
		}

		public string HerramientaPadre
		{
			get {return _brClass.HerramientaPadre;}
			set 
			{
				_brClass.HerramientaPadre = value;
			}
		}*/

		public long CurrentIdProcess
		{
			get {return _brClass.CurrentIdProcess;}
			set 
			{
				_brClass.CurrentIdProcess = value;
			}
		}

		public string CurrentDescriptionProcess
		{
			get {return _brClass.CurrentDescriptionProcess;}
			set 
			{
				_brClass.CurrentDescriptionProcess = value;
			}
		}

		public string CurrentDescription 
		{
			get{return _currentDescription;}
			set
			{
				_currentDescription = value;
			}
		}
		
		public string ParentKey
		{
			get{return _parentKey;}
			set
			{
				_parentKey = value;
			}
		}

		public string ParentDescription
		{
			get{return _parentDescription;}
			set
			{
				_parentDescription = value;
			}
		}

		public bool Habilitado 
		{
			get
			{
				return _habilitado;
			}
			set
			{
				_habilitado = value;
			}
		}
		public System.Collections.ArrayList HerramientasExModificadas
		{
			get {return _brClass.HerramientasExModificadas();}
		}

		public HerramientaEx HerramientaModificada
		{
			get {return _brClass.HerramientaModificada();}
		}

		private string _defaultVisible = "No Visible";
		public string DefaultVisible
		{
			get {return _defaultVisible;}
		}

		#endregion

		#region Eventos y delegados
		public event System.EventHandler HerramientasExModificadasHasChanged;
		#endregion
		
		#region Métodos  Públicos
		/*public string GetBarraHerramienta(long IdBarraHerramienta)
		{
			return _brClass.GetBarraHerramienta(IdBarraHerramienta);
		}*/

		public void UpdateTree(string key)
		{
			_currentNode = _model.getChildsNode(key);
		}

		public Node UpdateNode(long IdHerramienta, long IdRecurso)
		{
			return _model.getNode(IdHerramienta, IdRecurso);
		}

		public bool HasNext()
		{
			if(_currentNode != null)
				return _currentNode.HasNext();
			else return false;
		}

		public ArrayList Next()
		{
			Node node = _currentNode.Next();
			ArrayList result = new ArrayList();
			result.Add(node.Key);
			result.Add(node.Description);
			return result;
		}

		public HerramientaEx GetHerramienta(string IdHerramienta, long IdTipoRecurso)
		{
			return _brClass.GetHerramienta(IdHerramienta, IdTipoRecurso);
		}

		public HerramientaEx GetSeparador(string IdRecurso)
		{
			return _brClass.GetSeparador(IdRecurso);
		}

		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.sy_HerramientasEx( new string[] {"Modo", "IdBarraHerramienta", "IdHerramienta", "IdHerramientaPadre", "Id", "ShortCut", "Imagen", "Habilitado", "Orden", "IdRecurso", "Descripcion", "IdTipoRecurso", "Perfiles"}).GetLayoutEx()); 
		}

		public void AddHerramientaModificada(string Titulo, string IdHerramienta, string Imagen, string ShortCut, bool Habilitado, ArrayList PerfilesSeleccionados, string IdHerramientaPadre, string Modo, bool modificaOtrasHerramientasConIgualRecurso)
		{
			_brClass.AddHerramientaModificada(Titulo, IdHerramienta, Imagen, ShortCut, Habilitado, PerfilesSeleccionados, IdHerramientaPadre, Modo, modificaOtrasHerramientasConIgualRecurso);
		}

        /* Silvina 20110805 - Tarea 0000184 */ 
		public bool AddSubmenu(string Titulo, string Imagen, string ShortCut, bool Habilitado, string IdHerramientaPadre, string Id)
        {
			return _brClass.AddSubmenu(Titulo, Imagen, ShortCut, Habilitado, IdHerramientaPadre, Id);
		}
        /* Fin Silvina 20110805 - Tarea 0000184 */ 

		public void AddBarra(string IdHerramienta, string Barra)
		{
			_brClass.AddBarra(IdHerramienta,Barra);
		}

		public void RemoveBarra(string IdHerramienta, string Barra)
		{
			_brClass.RemoveBarra(IdHerramienta,Barra);
		}

		public void AddPerfilHerramienta(string IdHerramienta, businessrules.PerfilView Perfil)
		{
			_brClass.AddPerfilHerramienta(IdHerramienta, Perfil);
		}

		public void RemovePerfilHerramienta(string IdHerramienta, businessrules.PerfilView Perfil)
		{
			_brClass.RemovePerfilHerramienta(IdHerramienta, Perfil);
		}

		public void AddSeparador(string IdHerramienta)
		{
			_brClass.AddSeparador(IdHerramienta);
		}

		public void RemoveSeparador(string IdHerramienta)
		{
			_brClass.RemoveSeparador(IdHerramienta);
		}

		public void AddSeparador(businessrules.HerramientaEx Herramienta)
		{
			_brClass.AddSeparador(Herramienta);
		}
		
		public bool ModificarOrdenBajar(string IdHerramienta)
		{
			return _brClass.ModificarOrdenBajar(IdHerramienta);
		}

		public bool ModificarOrdenSubir(string IdHerramienta)
		{
			return _brClass.ModificarOrdenSubir(IdHerramienta);
		}

		public ArrayList GetHerramientasRecurso(long IdRecurso)
		{
			return _brClass.GetHerramientasRecurso(IdRecurso);
		}

		public HerramientaEx GetHerramientaModificada(long IdHerramienta)
		{
			return _brClass.GetHerramientaModificada(IdHerramienta);
		}
		public bool SoloCambioDescripcion(HerramientaEx Herramienta)
		{
			return _brClass.SoloCambioDescripcion(Herramienta);
		}

		public bool SoloCambioOrden(HerramientaEx Herramienta)
		{
			return _brClass.SoloCambioOrden(Herramienta);
		}

		public HerramientaEx GetHerramientaModificadaConOrden(short Orden, long IdHerramientaPadre)
		{
			return _brClass.GetHerramientaModificadaConOrden(Orden, IdHerramientaPadre);
		}

		#endregion



		#region Métodos  Privados

		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			this._brClass.HerramientasExModificadasHasChanged+=new EventHandler(_brClass_HerramientasExModificadasHasChanged);
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

		private void _brClass_HerramientasExModificadasHasChanged(object sender, EventArgs e)
		{
			if(HerramientasExModificadasHasChanged != null)
				HerramientasExModificadasHasChanged(this, new EventArgs());	
		}



	}
}
