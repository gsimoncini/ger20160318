using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SeleccionarEstadoItems.
	/// </summary>
	 
	public class SeleccionarEstadoItemsController: ITaskController
	{
		
		#region Constructores
		
			public SeleccionarEstadoItemsController()
			{
				this._seleccionEstadoItems = new mz.erp.businessrules.SeleccionEstadoDeItem();
			
				Init();
			}
				
			public SeleccionarEstadoItemsController(SeleccionEstadoDeItem seleccionEstadoItems)
			{
				this._seleccionEstadoItems = seleccionEstadoItems;

				Init();
			}

			private void Init()
			{
				InitializeData();
				InitEvents();
			}
		
			
		#endregion
				
		#region Variables Privadas
		
			private string _layout = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleProductos(new string[] {"IdProducto", "Codigo", "Descripcion", "DescripcionLarga","Cantidad","FormaDeEntrega", "Fecha"});
			private string _layoutItems = string.Empty;
			private SeleccionEstadoDeItem _seleccionEstadoItems;
			private string _leyendaFormulario = "Seleccionar Estado Items";
			private string _captionColumnaFechaDeEntrega = "Fecha de Entrega";
			private string _captionColumnaIdEstado = "Forma de Entrega";
			
		public string CaptionColumnaIdEstado
		{
			get 
			{ 
				return _captionColumnaIdEstado;
			}
		}


		public string CaptionColumnaFechaDeEntrega
		{
			get 
			{ 
				return _captionColumnaFechaDeEntrega;
			}
		}

		public string LayoutItems
		{
			get 
			{ 
				return _layoutItems;
			}
		}

		public string Layout
		{
			get
			{
				return _layout;
			}
		}

		public bool HasShow 
		{
			get
			{
				return this._seleccionEstadoItems.HasShow;
			}
		}

		public string LeyendaFormulario
		{
			get 
			{
				return this._leyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _seleccionEstadoItems.PreguntarAlCancelar;}
		}

		public string EstadoItemDefault 
		{
			get
			{
				return this._seleccionEstadoItems.EstadoItemDefault;
			}
		}

			
		#endregion

		#region Variables Publicas
			
			public event EventHandler OnTaskAfterExecute;
			public event EventHandler OnModelChanged;
			
		
		#endregion

		#region Variables publicas Datos

			public System.Collections.ArrayList Items
			{
				get { return (ArrayList)_seleccionEstadoItems.ArrayItems;}
			}
			public bool PreSetData
			{
				get { return this._seleccionEstadoItems.PreSetData ; }
			}
		
		#endregion
		
		#region Metodos Privados

			private void InitEvents()
			{
				this._seleccionEstadoItems.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
				this._seleccionEstadoItems.ObjectHasChanged +=new EventHandler(_seleccionEstadoItems_ObjectHasChanged);
			}

			private void AfterTaskExecute(object sender , EventArgs e)
			{
				if(OnTaskAfterExecute != null)
					OnTaskAfterExecute(this, new EventArgs());
			}
		
			private void InitializeData()
			{
				SetLayoutProductos();
				SetLeyendaFormulario();

			}
			
			private void SetLeyendaFormulario()
			{
				string leyenda = Variables.GetValueString(this._seleccionEstadoItems.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
				if (leyenda.Equals(string.Empty))
				{
					leyenda= this._seleccionEstadoItems.GetTaskName();
				}
				this._leyendaFormulario = leyenda;
			}
			private void SetLayoutProductos()
			{
				ArrayList _buildedarray = new ArrayList();
				_buildedarray.Add("IdProducto");
				_buildedarray.Add("Codigo");
				_buildedarray.Add("Descripcion");
				_buildedarray.Add("DescripcionLarga");
				_buildedarray.Add("Cantidad");
				_buildedarray.Add("IdEstado");
				_buildedarray.Add("FechaDeEntrega");

				if (_seleccionEstadoItems.MostrarDatosAuxiliares)
				{
					_buildedarray.Add("CampoAuxiliar1");
					_buildedarray.Add("CampoAuxiliar2");
					_buildedarray.Add("CampoAuxiliar3");
					_buildedarray.Add("CampoAuxiliar4");
					_buildedarray.Add("CampoAuxiliar5");
					_buildedarray.Add("CampoAuxiliar6");
					_buildedarray.Add("Observaciones");
				}
				
				string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;

				_layoutItems  = mz.erp.ui.controllers.SeleccionarEstadoItems.GetLayoutProductos(_campos);
				_captionColumnaFechaDeEntrega = Variables.GetValueString(this._seleccionEstadoItems.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "CaptionColumna.FechaDeEntrega");
				_captionColumnaIdEstado = Variables.GetValueString(this._seleccionEstadoItems.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "CaptionColumna.IdEstado");
			}


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

		public string GetTaskName()
		{
			return _seleccionEstadoItems.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_seleccionEstadoItems.GetTaskName());
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
			return _seleccionEstadoItems.AllowPrevious();
		}

		public void Previous()
		{
			_seleccionEstadoItems.Previous();
		}


			public ITask GetTask()
			{
				
				return (ITask)this._seleccionEstadoItems;
			}

			public void Execute()
			{
				this._seleccionEstadoItems.Execute();
			}

			public ItemsDatasetErrors GetErrors()
			{
				return _seleccionEstadoItems.GetErrors();
			}
			public string GetWarnings()
			{
				return null;
			}
		public void Continue()
		{
		}

			public bool AllowShow()
			{
				return _seleccionEstadoItems.AllowShow();
			}

		#endregion


		private void _seleccionEstadoItems_ObjectHasChanged(object sender, EventArgs e)
		{
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}

		public void AsignarEstadoAItems( string estado)
		{
			this._seleccionEstadoItems.AsignarEstadoAItems(estado);
		}


		
		


	}
}
