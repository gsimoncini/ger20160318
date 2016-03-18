using System;
using System.Collections;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConceptosAdicionalesController.
	/// </summary>
	public class ConceptosAdicionalesController : ITaskController
	{
		#region Contructores
		
			public ConceptosAdicionalesController()
			{
				this._conceptoAdicional = new mz.erp.businessrules.ConceptosAdicionales();
				Init();
			}
			
			public ConceptosAdicionalesController(mz.erp.businessrules.ConceptosAdicionales conceptoAdicional)
			{
				this._conceptoAdicional = conceptoAdicional;
				Init();
			}

			private void Init()
			{
				InitializeData();
				InitEvents();
			}


		#endregion

		#region Variables Públicas

			public event EventHandler OnTaskAfterExecute;
			public event EventHandler OnModelChanged;		
			
		#endregion

		#region Variables Públicas Datos

			public ArrayList Items
			{
				get { return (ArrayList)_conceptoAdicional.ArrayItems;}  
			}


			public bool AllowShow()
			{
				return this._conceptoAdicional.AllowShow();
			}
			public string LeyendaFormulario
			{
				get { return _leyendaFormulario ; }
			}
		
			public bool PreguntarAlCancelar
			{
				get {return _conceptoAdicional.PreguntarAlCancelar;}
			}
		
		#endregion

		#region Variables Privadas
			
			private string _layout = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleProductos(new string[] {"IdProducto", "Codigo", "Descripcion", "DescripcionLarga","Cantidad","IdEstado", "Fecha"});
			private string _layoutItems = string.Empty;
			private ConceptosAdicionales _conceptoAdicional;
			private string _idPersona = string.Empty;
			private string _idTransporte = string.Empty;
			private string _descripcion = string.Empty;
			private decimal _monto = 0;
			private string _leyendaFormulario = string.Empty;
						
		#endregion

		#region Variables Privadas Datos
		
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
					return this._conceptoAdicional.HasShow;
				}
			}
			
			public string IdPersona
			{
				get
				{	
					return _idPersona;
				}
				set
				{
					if(_idPersona!= value)
					{
						_idPersona = value;
						if(IdPersonaChanged != null)
							IdPersonaChanged(this, new EventArgs());
					}
				}
			}
			public string IdTransporte
			{
				get
				{	
					return _idTransporte;
				}
				set
				{
					if(_idTransporte!= value)
					{
						_idTransporte = value;
						if(IdTransporteChanged != null)
							IdTransporteChanged(this, new EventArgs());
					}
				}
			}
		public string Descripcion
		{
			get
			{	
				return _descripcion;
			}
			set
			{
				if(_descripcion!= value)
				{
					_descripcion = value;
					if(DescripcionChanged != null)
						DescripcionChanged(this, new EventArgs());
				}
			}
		}
		public decimal Monto
		{
			get
			{	
				return _monto;
			}
			set
			{
				_monto = value;
			}
		}

		
		#endregion

		#region Eventos y delegados
			public event EventHandler IdPersonaChanged;
			public event EventHandler IdTransporteChanged;
			public event EventHandler DescripcionChanged;

		#endregion
		
		#region Métodos  Públicos
		#endregion

		#region Métodos  Privados
		
		private void InitEvents()
		{
			this._conceptoAdicional.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
			this._conceptoAdicional.ObjectHasChanged +=new EventHandler(_conceptoAdicional_ObjectHasChanged);
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
			this.IdTransporte = this._conceptoAdicional.IdTransporte;

		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos."+this._conceptoAdicional.GetTaskName()+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda= this._conceptoAdicional.GetTaskName();
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
				
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;

			_layoutItems  = mz.erp.ui.controllers.SeleccionarEstadoItems.GetLayoutProductos(_campos);
			
		}



		private void _conceptoAdicional_ObjectHasChanged(object sender, EventArgs e)
		{
			ConceptosAdicionales concepto = (ConceptosAdicionales) sender;
			this.IdPersona = concepto.IdPersona;
			this.IdTransporte = concepto.IdTransporte;
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
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
			return _conceptoAdicional.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_conceptoAdicional.GetTaskName());
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
			return _conceptoAdicional.AllowPrevious();
		}

		public void Previous()
		{
			_conceptoAdicional.Previous();
		}


			public ItemsDatasetErrors GetErrors()
			{
				// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
				return _conceptoAdicional.GetErrors();
			}
		    public string GetWarnings()
		    {
			   // TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			   return null;
		    }
		public void Continue()
		{
		}

			public void Execute()
			{
				// TODO: agregar la implementación ConceptosAdicionalesController.Execute
				this._conceptoAdicional.Descripcion = this.Descripcion;
				this._conceptoAdicional.IdPersona= this.IdPersona;
				this._conceptoAdicional.IdTransporte = this.IdTransporte;
				if(this.Items.Count > 0)
					this._conceptoAdicional.Monto = (this.Monto)/this.Items.Count;  //divido el monto por la cantidad de items para q al sumarlo me de el total del flete.
				this._conceptoAdicional.Execute();
			}

			public ITask GetTask()
			{
				return (ITask)this._conceptoAdicional;
			}

			
		#endregion
	

	}
}
