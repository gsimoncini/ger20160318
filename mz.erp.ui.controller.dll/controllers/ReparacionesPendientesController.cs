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
	/// Descripción breve de ReparacionesPendientesController.
	/// </summary>
	public class ReparacionesPendientesController: ConsultasController, ITaskController
	{
		#region Contructores
		public ReparacionesPendientesController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		public ReparacionesPendientesController(mz.erp.businessrules.SeleccionReparacionesPendientes reparacionesPendientes)
		{
			_reparacionesPendientas = reparacionesPendientes;
			Init();
			
		}

		#endregion


		#region Variables Privadas
	
		private SeleccionReparacionesPendientes _reparacionesPendientas;

		#endregion


		#region Metodos Privados

		private void Init()
		{
			InitializeData();
			string Tarea = this._reparacionesPendientas.GetTaskName();
			string Proceso = this._reparacionesPendientas.GetProcessManagerParent().Process.ProcessName;			
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "IdOrdenReparacion","Nro Orden de Reparación",true,null,"IdOrdenReparacion");
			_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			//_filtros.Add( "Responsable","Responsable de Emisión", true, null, "IdResponsable");						
			_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,null, "FamiliaComprobantes");
			_filtros.Add("EstadosOrdenReparacion", "Estado", true, null, "IdEstado",_reparacionesPendientas.TableEstadosFiltrados);
			_allowMultipleSelect = Variables.GetValueBool("Momentos."+Tarea+"."+ _reparacionesPendientas.ProcesoEnEjecucion+".AllowMultipleSelect");
			_allowShowDetail = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes");
			_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
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
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString("Momentos."+_reparacionesPendientas.GetTaskName()+"."+ _reparacionesPendientas.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _reparacionesPendientas.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
			
		}

		#endregion


		

		#region Miembros de ITaskController


		public string GetTaskName()
		{
			return _reparacionesPendientas.GetTaskName();
		}

		

		public override bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public override bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public override bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_reparacionesPendientas.GetTaskName());
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
			return _reparacionesPendientas.AllowPrevious();
		}

		public void Previous()
		{
			_reparacionesPendientas.Previous();
		}

			
		public override bool AllowShow()
		{
			return true;
		}
		public override void Execute()
		{
			_reparacionesPendientas.Execute();
		}

		private object[] GetParameters()
		{
			ArrayList parameters = new ArrayList();
			int i = 0;
			foreach(ReportFilterItem item in this._filtros)
			{
				parameters.Add(this.GetType().GetProperty(item.PropertyBinding).GetValue(this,null));
				
			}
			return parameters.ToArray();
		}

		public override void RefreshData() 
		{
			this._table = _reparacionesPendientas.RefreshData();
			SetLayout();
		}

		private void SetLayout()
		{
			ArrayList fields = new ArrayList();
			fields.Add("IdOrdenReparacion");
			fields.Add("CodigoEstadoOrdenReparacion");
			fields.Add("Cuenta");
			fields.Add("FechaComprometida");
			fields.Add("IdUsuarioAlta");
			fields.Add("DescripcionEquipo");
			fields.Add("Telefono");
			fields.Add("Domicilio");
			fields.Add("IdTipoDocumento");
			fields.Add("Documento");
			if(this._processManager.GetProcessName().Equals("ProcesoRepararPrevender") || this._processManager.GetProcessName().Equals("ProcesoRepararPreprestar")) 
				fields.Add("Total");
			this._layoutData = mz.erp.ui.controllers.ReparacionesPendientes.GetLayout(fields);
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _reparacionesPendientas.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

		#endregion


		#region Variables Publicas

		public string IdOrdenReparacion
		{
			get
			{
				return _reparacionesPendientas.IdOrdenReparacion;

			}
			set
			{
				_reparacionesPendientas.IdOrdenReparacion = value;
			}
		}


		public override bool HasShowSeleccionItems
		{
			get
			{
				return _reparacionesPendientas.HasShowSeleccionItems;
			}
			set
			{	
				_reparacionesPendientas.HasShowSeleccionItems = value;
			}
		}

		public event EventHandler OnTaskAfterExecute;
		public event EventHandler IdEstadoChanged;

		public override RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{		
			get
			{
				return this._reparacionesPendientas.RelacionesComprobanteOrigenDestino;
			}
			set
			{
				this._reparacionesPendientas.RelacionesComprobanteOrigenDestino = value;
			}
		}
			
		public override ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _reparacionesPendientas.ArrayIdComporbantesPendientes;
			}
			set
			{	
				_reparacionesPendientas.ArrayIdComporbantesPendientes = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _reparacionesPendientas.IdCuenta;
			}

		}

		public string IdProveedor
		{
			get
			{
				return _reparacionesPendientas.IdProveedor;
			}
			set
			{
				_reparacionesPendientas.IdProveedor = value;
			}

		}

		
		public string CodigoCuenta
		{
			get
			{
				return _reparacionesPendientas.CodigoCuenta;
			}
			set
			{
				_reparacionesPendientas.CodigoCuenta = value;
			}
		}
	
		public string IdResponsable
		{
			get
			{
				return _reparacionesPendientas.IdResponsable;
			}
			set
			{		
				_reparacionesPendientas.IdResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _reparacionesPendientas.FechaDesde;
			}
			set
			{
				_reparacionesPendientas.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _reparacionesPendientas.FechaHasta;
			}
			set
			{
				_reparacionesPendientas.FechaHasta = value;
			}
		}

		public override string FamiliaComprobantes
		{
			get
			{
				return _reparacionesPendientas.FamiliaComprobantes;
			}
			set
			{
				_reparacionesPendientas.FamiliaComprobantes = value;
			}
		}

		public string IdEstado
		{
			get
			{
				return _reparacionesPendientas.IdEstado;
			}
			set
			{
				_reparacionesPendientas.IdEstado = value;
			}
		}

		
		#endregion

	}
	
}
