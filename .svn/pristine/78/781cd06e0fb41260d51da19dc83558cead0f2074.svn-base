using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ImpresionComprobanteDeVentaController.
	/// </summary>	
	public class ImpresionComprobanteDeVentaController: ITaskController
	{
		FiscalComprobantes _prepararDatos;		

		#region Contructores
		public ImpresionComprobanteDeVentaController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			this._prepararDatos = new FiscalComprobantes();
			Init();
		}

		private void Init()
		{
			//InitializeData();
			//InitEvents();
		}
		#endregion

			
		#region Variables Públicas

			public event EventHandler OnTaskAfterExecute;
			public event EventHandler OnModelChanged;		
			
		#endregion

		
		#region Métodos  Públicos
		#endregion

		#region Métodos  Privados
		
		/*private void InitEvents()
		{
			this._conceptoAdicional.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
			this._conceptoAdicional.ObjectHasChanged +=new EventHandler(_conceptoAdicional_ObjectHasChanged);
		}*/

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		
		/*private void InitializeData()
		{
			SetLayoutProductos();
			SetLeyendaFormulario();
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

			_layoutItems  = mz.erp.ui.controller.SeleccionarEstadoItems.GetLayoutProductos(_campos);			
		}*/


		/*private void _conceptoAdicional_ObjectHasChanged(object sender, EventArgs e)
		{
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}*/


		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
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
			return _prepararDatos.GetTaskName();
		}


			public ItemsDatasetErrors GetErrors()
			{
				// TODO: agregar la implementación ImpresionComprobanteDeVentaController.GetErrors
				return _prepararDatos.GetErrors();
			}
		    public string GetWarnings()
		    {
			    // TODO: agregar la implementación ImpresionComprobanteDeVentaController.GetErrors
			    return null;
		    }
		public void Continue()
		{
		}


			public void Execute()
			{
				this._prepararDatos.Execute();
			}

			public ITask GetTask()
			{
				return (ITask)this._prepararDatos;
			}
		#endregion			

		#region Miembros de ITaskController

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
			return this._processManager.IsFirstTask(_prepararDatos.GetTaskName());
		}

		public bool AllowPrevious()
		{
			return _prepararDatos.AllowPrevious();
		}

		public void Previous()
		{
			_prepararDatos.Previous();
		}


		public bool AllowShow()
		{
			// TODO: agregar la implementación ImpresionComprobanteDeVentaController.AllowShow
			return false;
		}

		#endregion
	}
}
