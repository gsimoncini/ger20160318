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
	/// Descripción breve de ConsultarRetencionesProveedoresController.
	/// </summary>
	/// 	
	public class ConsultarRetencionesProveedoresController : ITaskController
	{
		#region Constructores
		public ConsultarRetencionesProveedoresController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ConsultarRetencionesProveedoresController(ConsultarRetencionesProveedores brClass)
		{
			_brClass = brClass;	
			Init();
		}
		#endregion

		#region Metodos Privados
		private void Init()
		{
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			_visualizaDetalle = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleRetenciones", _visualizaDetalle);
			_metodoVisualizacion = Variables.GetValueString(Proceso, Tarea,"MetodoVisualizacionDetalle");
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);

     	}

    	#endregion

		#region Propiedades

		private bool _visualizaBotonImprimir = false;
		public bool VisualizaBotonImprimir
		{
			get 
			{				
				return _visualizaBotonImprimir;
			}
		}


		public string MetodoVisualizacion
		{
			get{ return _metodoVisualizacion;}
		}

		public bool VisualizaDetalle
		{
			get{return _visualizaDetalle;}
		}

		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		public string NumeroRetencion
		{
			get{return _brClass.NumeroRetencion;}
			set{_brClass.NumeroRetencion = value;}
		}

		public DateTime FechaRetencionDesde
		{
			get{return _brClass.FechaRetencionDesde;}
			set{_brClass.FechaRetencionDesde = value;}
		}

		public DateTime FechaRetencionHasta
		{
			get{return _brClass.FechaRetencionHasta;}
			set{_brClass.FechaRetencionHasta = value;}
		}

		public string IdTipoDeRetencion
		{
			get{return _brClass.IdTipoDeRetencion;}
			set{_brClass.IdTipoDeRetencion = value;}
		}

		public string NumeroRecibo
		{
			get{return _brClass.NumeroRecibo;}
			set{_brClass.NumeroRecibo = value;}
		}

		public DateTime FechaReciboDesde
		{
			get{return _brClass.FechaReciboDesde;}
			set{_brClass.FechaReciboDesde = value;}
		}

		public DateTime FechaReciboHasta
		{
			get{return _brClass.FechaReciboHasta;}
			set{_brClass.FechaReciboHasta = value;}
		}

		public string NumeroFactura
		{
			get{return _brClass.NumeroFactura;}
			set{_brClass.NumeroFactura = value;}
		}
		
		public DateTime FechaFacturaDesde
		{
			get{return _brClass.FechaFacturaDesde;}
			set{_brClass.FechaFacturaDesde = value;}
		}
		
		public DateTime FechaFacturaHasta
		{
			get{return _brClass.FechaFacturaHasta;}
			set{_brClass.FechaFacturaHasta = value;}
		}

		public System.Data.DataTable TiposDeRetenciones
		{
			get {return _brClass.TiposDeRetenciones;}
		}

		public string KeyValueTiposDeRetenciones
		{
			get { return "IdTipoDeRetencion" ; }
		}

		public string KeyListTiposDeRetenciones
		{
			get { return "Descripcion" ; }
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
	
		//matias 15/09/08
		public bool AllowGeneralSearch 
		{
			get{return _brClass.AllowGeneralSearch;}
		}

		public bool FilterByFechaRetencion
		{
			get{return _brClass.FilterByFechaRetencion;}
			set{_brClass.FilterByFechaRetencion = value;}
		}

		public bool FilterByFechaRecibo
		{
			get{return _brClass.FilterByFechaRecibo;}
			set{_brClass.FilterByFechaRecibo = value;}
		}

		public bool FilterByFechaFactura
		{
			get{return _brClass.FilterByFechaFactura;}
			set{_brClass.FilterByFechaFactura = value;}
		}
		//---------

		#endregion

		#region Eventos
		public event EventHandler DataChanged;
		#endregion

		#region Variables Privadas						

		private ConsultarRetencionesProveedores _brClass;	
		private bool _visualizaDetalle = false;
		private string _metodoVisualizacion = string.Empty;

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
        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, string tipoFecha, bool ordenInverso)
        {
            this._brClass.updateFechas(fechaDesde, tipoFecha, ordenInverso);

        }
        //Fin Cristian 20110725
        //Fin Cristian
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}
		#endregion

	}


}
