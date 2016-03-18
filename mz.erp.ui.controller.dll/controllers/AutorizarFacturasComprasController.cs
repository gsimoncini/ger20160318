using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AutorizarFacturasComprasController.
	/// </summary>
	public class AutorizarFacturasComprasController: ITaskController,IObserver
	{
		public AutorizarFacturasComprasController(AutorizarFacturasCompras brClass)
		{
			_brClass = brClass;	
			Init();
		}

		#region Metodos Privados
		private void Init()
		{
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			_allowChangeFamiliaComprobantes = Variables.GetValueBool(Proceso, Tarea, "PermiteModificarFamiliaComprobantes", _allowChangeFamiliaComprobantes);			
			_brClass.IdCuentaImputacionChanged +=new EventHandler(_brClass_IdCuentaImputacionChanged);
			_contenedoresVisibles = Variables.GetValueString(Proceso, Tarea, "ContenedoresVisibles");
			_contenedoresHabilitados = Variables.GetValueString(Proceso, Tarea, "ContenedoresHabilitados");
			_visualizaDetalle = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes", _visualizaDetalle);
			_metodoVisualizacion = Variables.GetValueString(Proceso, Tarea,"MetodoVisualizacionDetalle");
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(Proceso, Tarea, "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);
			

		}
		/**
				private void ListenerRefreshData( object sender, EventArgs e)
				{
					if(DataChanged != null)
						DataChanged(this, new EventArgs());
				}

				private void ListenerObjectHasChanged( object sender, EventArgs e )
				{
					if (this.ObjectHasChanged != null)
					{
						ObjectHasChanged( this, new System.EventArgs() );
					}
				}
		*/
		private void _brClass_IdCuentaImputacionChanged(object sender, EventArgs e)
		{
			if(CuentaImputacionChanged != null)
				CuentaImputacionChanged(this, new EventArgs());
		}

		

		#endregion
		#region Propiedades

		private string _contenedoresVisibles = string.Empty;
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}
		private string _contenedoresHabilitados = string.Empty;						
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}

		
		public bool PorTipoMovimiento
		{
			get{return _brClass.PorTipoMovimiento ;}
			set{_brClass.PorTipoMovimiento = value;}
		}

		public bool HabilitaFiltroTipoMovimiento
		{
			get{return _brClass.HabilitaFiltroTipoMovimiento;}
		}



		public string IdTipoMovimiento
		{
			get{return _brClass.IdTipoMovimiento;}
			set{_brClass.IdTipoMovimiento = value;}
		}

		public string IdSubTipoMovimiento
		{
			get{return _brClass.IdSubTipoMovimiento;}
			set{_brClass.IdSubTipoMovimiento = value;}
		}

		public string Filter
		{
			get
			{
				return "IdTipoMovimiento = " + _brClass.IdTipoMovimiento ;
			}
		}


		public System.Data.DataTable Tipos
		{
			get {return _brClass.Tipos;}
		}

		public System.Data.DataTable SubTipos
		{
			get {return _brClass.SubTipos;}
		}		
		
		public string KeyValueTipos
		{
			get { return "IdTipoMovimiento" ; }
		}

		public string KeyValueSubTipos
		{
			get { return "IdSubTipoMovimiento" ; }
		}


		public string KeyListTipos
		{
			get { return "Descripcion" ; }
		}


		public string ResponsableEmision
		{			
			get { return _brClass.ResponsableEmision ; }
			set { _brClass.ResponsableEmision = value; }
		}	
		public string FamiliaComprobantes
		{			
			get { return _brClass.FamiliaComprobantes ; }
			set { _brClass.FamiliaComprobantes = value; }
		}
		
		public bool AllowChangeFamiliaComprobantes
		{
			get
			{
				return _allowChangeFamiliaComprobantes;
			}
		}
		
		
		private bool _visualizaDetalle = false;
		public bool VisualizaDetalle
		{
			get{return _visualizaDetalle;}
		}

		public string FamiliaDefault 
		{
			get {return _brClass.FamiliaDefault;}
		}
		
		public bool HabilitaFamiliasComprobantes 
		{
			get { return _brClass.HabilitaFamiliasComprobantes;}
		}

		public string ListaFamiliaDeComprobantes
		{			
			get { return _brClass.ListaFamiliaDeComprobantes ; }			
		}	

		
		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}
		private bool _visualizaBotonImprimir = false;
		public bool VisualizaBotonImprimir
		{
			get 
			{				
				return _visualizaBotonImprimir;
			}
		}
		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
		}
		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}		

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}

		public string CodigoProveedor
		{
			get{return _brClass.CodigoProveedor;}
			set{_brClass.CodigoProveedor = value;}
		}

		public DateTime FechaDesde
		{
			get{return _brClass.FechaDesde;}
			set{_brClass.FechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		}
		
		public string Codigo
		{
			get
			{
				return _brClass.CodigoProducto;
			}
			set
			{
				_brClass.CodigoProducto = value;
			}
		}
		
		public ArrayList ArrayComprobantesPendientes
		{
			set
			{
				this._brClass.ArrayComprobantesPendientes = value;
			}
			get
			{
				return _brClass.ArrayComprobantesPendientes;
			}			
		}

		public bool HasShowSeleccionItems
		{
			get{return _brClass.HasShowSeleccionItems;}
			set{_brClass.HasShowSeleccionItems = value;}
		}

		public bool PorFechaEmision
		{
			get{return _brClass.PorFechaEmision ;}
			set{_brClass.PorFechaEmision = value;}
		}

		public bool PorFechaVencimiento
		{
			get{return _brClass.PorFechaVencimiento ;}
			set{_brClass.PorFechaVencimiento = value;}
		}

		public bool PorFechaRecepcionMercaderia
		{
			get{return _brClass.PorFechaRecepcionMercaderia ;}
			set{_brClass.PorFechaRecepcionMercaderia = value;}
		}
		
		
		public string MetodoVisualizacion
		{
			get{ return _metodoVisualizacion;}
		}
		
		#endregion
		#region Eventos
		
		public event EventHandler ObjectHasChanged;
		public event EventHandler DataChanged;
		//public event EventHandler ByFechasChanged;
		//public event EventHandler ResumidoChanged;		
		//public event EventHandler CodigoCuentaChanged;		
		public event EventHandler ResponsableEmisionChanged;		
		public event EventHandler FamiliaComprobantesChanged;
		public event EventHandler CuentaImputacionChanged;
		public event EventHandler OnModelChanged;
		
		
		#endregion
		#region Variables Privadas						

		private AutorizarFacturasCompras _brClass;		
		private bool _allowChangeFamiliaComprobantes = false;
		
		private string _metodoVisualizacion = string.Empty;

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;	
				
				if (lista.Count == 0) this.Codigo = "00000000";
				else 
				{
					foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
					{					
						this.Codigo = item.Codigo;	
					}
					if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
				}
			}
		}

		#endregion

		#region Miembros de ITaskController
		public event EventHandler OnTaskAfterExecute;
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
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
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

		#region Metodos Publicos
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}
		public void ResetFilters()
		{
			// Filtro ppal
			_brClass.ResetFilters();            
		}

		#endregion
	}
}
