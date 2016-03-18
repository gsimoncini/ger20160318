using System;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesConProductosPendientesDeNumeroDeSerieController.
	/// </summary>
	public class ComprobantesConProductosPendientesDeNumeroDeSerieController: ConsultasController, ITaskController
	{
		
		#region Constructores


		public ComprobantesConProductosPendientesDeNumeroDeSerieController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ComprobantesConProductosPendientesDeNumeroDeSerieController(SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie brClass)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_brClass = brClass;
			Init();
		}


		#endregion

		#region Variables Privadas

			private SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie _brClass;

		#endregion

		#region Metodos Privados
			
		private void Init()
		{
			InitializeData();
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;			
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			_allowMultipleSelect = _allowMultipleSelect = Variables.GetValueBool("Momentos."+ Tarea+"."+ _brClass.ProcesoEnEjecucion+".AllowMultipleSelect");
			_allowShowDetail = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes");
			_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName = Variables.GetValueString(Proceso, this._brClass.GetTaskName(), "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");			
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);

			_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");

            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
            //Fin German 2010105 - Tarea 856

			InitEvents();
		}

		private void InitEvents()
		{

		}

		private void InitializeData()
		{
			SetLeyendaFormulario();
			_layoutData = mz.erp.ui.controllers.ComprobantesConProductosPendientesDeNumeroDeSerie.GetLayout();
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString("Momentos."+_brClass.GetTaskName()+"."+ _brClass.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
			
		}

		#endregion

		#region Variables Publicas
	
		public override bool HasShowSeleccionItems
		{
			get
			{
				return _brClass.HasShowSeleccionItems;
			}
			set
			{	
				_brClass.HasShowSeleccionItems = value;
			}
		}

		public event EventHandler OnTaskAfterExecute;

		public override RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{		
			get
			{
				return this._brClass.RelacionesComprobanteOrigenDestino;
			}
			set
			{
				this._brClass.RelacionesComprobanteOrigenDestino = value;
			}
		}
			
		public override ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _brClass.ArrayIdComporbantesPendientes;
			}
			set
			{	
				_brClass.ArrayIdComporbantesPendientes = value;
			}
		}

			
	
		public DateTime FechaDesde
		{
			get
			{
				return _brClass.FechaDesde;
			}
			set
			{
				_brClass.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _brClass.FechaHasta;
			}
			set
			{
				_brClass.FechaHasta = value;
			}
		}


		

		#endregion

        #region Metodos Públicos
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 00000146 20110725
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _brClass.updateFechas(fechaDesde, ordenInverso);
            if (!ordenInverso)
            {
                return this.FechaHasta;
            }
            else { return this.FechaDesde; }
        }
        //Fin Cristian 0000146
        //Fin Cristian	
        #endregion

		#region Miembros de ITaskController

		private ProcessControllerManager _processManager;
		
		public override void RefreshData()
		{
			_table = _brClass.RefreshData();
		}


		public string GetWarnings()
		{
			// TODO: agregar la implementación ComprobantesConProductosPendientesDeNumeroDeSerieController.GetWarnings
			return null;
		}

		public void Continue()
		{
			
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public override void Execute()
		{
			_brClass.Execute();
		}

		public override bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public  bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public  override void Previous()
		{
			_brClass.Previous();
		}

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager ;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public override bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public override bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public override bool IsBackState()
		{
			return this._processManager.IsBackState();
		}

		public override bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		#endregion
	}
}
