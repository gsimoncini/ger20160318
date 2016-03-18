using System;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMComprobantesCategoriaIvaController.
	/// </summary>
	public class ABMComprobantesCategoriaIvaController:ITaskController
	{
		public ABMComprobantesCategoriaIvaController()
		{
			
		}


		public ABMComprobantesCategoriaIvaController(ABMComprobantesCategoriaIva brClass)
		{
			_brClass = brClass;
			Init();
		}

	

		#region variables privadas
		ABMComprobantesCategoriaIva _brClass= new ABMComprobantesCategoriaIva();
		private bool _isValid = true;
		private bool _allowShow = true;
		private ArrayList _asociados=new ArrayList();
		private ArrayList _noAsociados=new ArrayList();
		private ArrayList _todos;
		
		
		#endregion
		#region propiedades
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
		public ArrayList Seleccionados
		{
			get 
			{
				return _asociados;
			}
		}
		
		public ArrayList NoSeleccionados
		{
			get 
			{
				return _noAsociados;
			}
		}

		

		public System.Data.DataTable CategoriasIva
		{
			get 
			{
				return _brClass.CategoriasIva;
			}
		}
		public ArrayList TodasCategoriasIva
		{
			get 
			{
				return _brClass.TodasCategoriasIva;
			}
		}
		public ArrayList Modificaciones 
		{
			get
			{
				return _brClass.Modificaciones;		
			}
		}
		
		private string _idCategoriaIva=string.Empty;
		public string IdCategoriaIva
		{
			get { return _brClass.IdCategoriaIva; }
			set 
			{ 
				if (value != null && _brClass.IdCategoriaIva.CompareTo( value ) != 0)
				{
					_idCategoriaIva = Convert.ToString(value);
					_brClass.IdCategoriaIva = Convert.ToString(value) ; 
					if (this.IdCategoriaIvaChanged != null)
							IdCategoriaIvaChanged (this, new EventArgs());				

					}
				else if(value == null && _idCategoriaIva != string.Empty)
				{
					_idCategoriaIva = string.Empty;
					_brClass.IdCategoriaIva = string.Empty; 
				}
			}
			
		}
		#endregion
		#region metodos publicos
		
		public ArrayList ComprobantesAsociados(){
			 _todos= _brClass.Asociados(this.IdCategoriaIva);
			return _todos;
		}
		public void AsociarNuevosComprobantes(ArrayList comprobantesSeleccionados,ArrayList comprobantesDeseleccionados)
		{
			//Podria mandarle mis comprobantes actuales de aca con lo q tomo del form agarro los objetos correspondientes
			_brClass.AsociarNuevosComprobantes( comprobantesSeleccionados, comprobantesDeseleccionados);
		}
		public void EliminarDeGrilla(String idTipoCategoria,String idTipoComprobante){
			this._brClass.EliminarDeGrilla(idTipoCategoria,idTipoComprobante);
		}
		
		public bool Activo(Object o)
		{
			EstadoObjeto eo=(EstadoObjeto)o;
			return eo.Activo;
		}
		
		public bool TipoComprobanteBorrado(Object o)
		{
			EstadoObjeto eo=(EstadoObjeto)o;
			return eo.EsDeseleccionado();
		}
		
		public bool TipoComprobanteAgregado(Object o)
		{
			EstadoObjeto eo=(EstadoObjeto)o;
			return eo.EsSeleccionado();
		}
		#endregion
		public event EventHandler IdCategoriaIvaChanged;
		public event EventHandler ModificacionesHasChanged;
		public event EventHandler ObjectHasChanged;	
		
		private void InitEvents()
		{
			//this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
		
			this._brClass.ModificacionesHasChanged+=new EventHandler(_brClass_ModificacionesHasChanged);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
		}
		
		private void Init()
		{
			//InitializeData();
			InitEvents();
			 _todos= _brClass.Asociados(this.IdCategoriaIva);
		}

		private void CallRefresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());

			
			if (_idCategoriaIva.CompareTo(_brClass.IdCategoriaIva ) != 0)
			{
				_idCategoriaIva = _brClass.IdCategoriaIva;
				if (IdCategoriaIva != null)
					IdCategoriaIvaChanged(this, new EventArgs());
			}	
		}
	

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
					

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}
		private void _brClass_ModificacionesHasChanged(object sender, EventArgs e)
		{
			if(ModificacionesHasChanged!=null){
				ModificacionesHasChanged(this, new EventArgs());
			}
		}

		#endregion

	
	}
}
	