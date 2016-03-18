using System;
using mz.erp.businessrules; 
using mz.erp.businessrules.comprobantes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SeleccionarEstadoItems.
	/// </summary>
	 
	public class SeleccionarEstadoItemsController: ITaskController
	{
		
		#region constructores
			public SeleccionarEstadoItemsController()
			{
				this._seleccionEstadoItems = new mz.erp.businessrules.SeleccionEstadoDeItem();
				InitEvents();
			}
		
			public SeleccionarEstadoItemsController(SeleccionEstadoDeItem seleccionEstadoItems)
			{
				this._seleccionEstadoItems = seleccionEstadoItems;
				InitEvents();
			}
			
		#endregion
		
			
		#region Variables Privadas
		
		private string _layout = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleProductos(new string[] {"IdProducto", "Codigo", "Descripcion", "DescripcionLarga","Cantidad","FormaDeEntrega", "Fecha"});
		private SeleccionEstadoDeItem _seleccionEstadoItems;
		
		#endregion


		#region Variables Publicas
		
		public event EventHandler OnTaskAfterExecute;
		public event EventHandler OnModelChanged;
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
		
		#endregion


		#region Miembros de ITaskController

		public ITask GetTask()
		{
			
			return (ITask)this._seleccionEstadoItems;
		}

		public void Execute()
		{
			this._seleccionEstadoItems.Execute();
		}

		#endregion


		private void _seleccionEstadoItems_ObjectHasChanged(object sender, EventArgs e)
		{
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}

		
		public ItemsDatasetErrors GetErrors()
		{
			return _seleccionEstadoItems.GetErrors();
		}
	}
}
