using System;
using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfirmarPreciosProductosComprasController.
	/// </summary>
	public class ConfirmarPreciosProductosComprasController: ITaskController
	{
		
		#region Constructores

		public ConfirmarPreciosProductosComprasController(ConfirmarPreciosProductosCompras BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		#endregion	

		#region Varables Privadas

		private ConfirmarPreciosProductosCompras _brClass;
		private ProcessControllerManager _processManager;
		private string _leyendaFormulario = string.Empty;

		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			if(this._processManager != null)
				return this._processManager.ProcessFlushed;
			return false;
		}

		public  bool IsNextState()
		{	
			if(this._processManager != null)
				return this._processManager.IsNextState();	
			return false;
		}

		public  bool IsBackState()
		{
				if(this._processManager != null)
				return this._processManager.IsBackState();
			return false;
		}
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		

		public bool IsFirstTask()
		{
			if(this._processManager != null)
				return this._processManager.IsFirstTask(_brClass.GetTaskName());
			return false;
		}

	
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
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}


		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}

		#endregion

		#region Variables Publicas UI

		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
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
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}
	
		#endregion

		#region Variables Publicas

		public bool AllowEditEstados
		{
			get{return _brClass.AllowEditEstados;}
		}

		public ArrayList Estados
		{
			get{return _brClass.Estados;}
		}

		public bool ExisteFactura
		{
			get{return _brClass.ExisteFactura;}
		}

		public ArrayList Items
		{
			get{return _brClass.Items;}
		}

		public string IdProveedor
		{
			get{return _brClass.IdProveedor;}
			set{_brClass.IdProveedor = value;}
		}

		public DateTime FechaFactura
		{
			get{return _brClass.FechaFactura;}
			set{ _brClass.FechaFactura = value;}
		}

		public string NumeroFactura
		{
			get{return _brClass.NumeroFactura;}
			set{_brClass.NumeroFactura = value;}
		}
	

		public decimal ValorCotizacionFactura
		{
			get{return _brClass.ValorCotizacionFactura;}
			set{_brClass.ValorCotizacionFactura = value;}
		}

		public string IdFuenteDeCambioFactura
		{
			get{return _brClass.IdFuenteDeCambioFactura;}
			set{_brClass.IdFuenteDeCambioFactura = value;}
		}

		public string IdMonedaFactura
		{
			get{return _brClass.IdMonedaFactura;}
			set{_brClass.IdMonedaFactura = value;}
		}



		

		#endregion

		#region Metodos Privados

		private void Init()
		{
			_brClass.EstadoItemsChanged +=new System.EventHandler(_brClass_EstadoItemsChanged);
			SetLeyendaFormulario();
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( this._brClass.GetProcessManagerParent().Process.ProcessName , this._brClass.GetTaskName(),"LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}


		#endregion

		#region Eventos

			public event EventHandler EstadoItemsChanged;

		#endregion

		private void _brClass_EstadoItemsChanged(object sender, System.EventArgs e)
		{
			if(EstadoItemsChanged != null)
				EstadoItemsChanged(this, new EventArgs());
		}
	}
}
