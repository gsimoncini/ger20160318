using System;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesDeCompraPendientes.
	/// </summary>
	public class ComprobantesDeCompraPendientesController: ConsultasController, ITaskController
	{
		public ComprobantesDeCompraPendientesController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ComprobantesDeCompraPendientesController(mz.erp.businessrules.ComprobantesDeCompraPendientes comprobantesPendientes)
		{
						
			this._comprobantesPendientes = comprobantesPendientes;
			Init();
		}

		/*
		public override void GenerateRelacionOrigenDestino(string IdComprobante)
		{
			ArrayList param = new ArrayList();
			param.Add(IdComprobante);
			this.RelacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino(param);					
			this.HasShowSeleccionItems = false;
			this.Execute();	
			
		}
		*/
		#region Variables Privadas
			
		private mz.erp.businessrules.ComprobantesDeCompraPendientes _comprobantesPendientes;
			

		#endregion

		#region Variables Publicas


		public override bool HasShowSeleccionItems
		{
			get
			{
				return _comprobantesPendientes.HasShowSeleccionItems;
			}
			set
			{	
				_comprobantesPendientes.HasShowSeleccionItems = value;
			}
		}

		public event EventHandler OnTaskAfterExecute;

		public  RelacionesComprobanteDeCompraOrigenDestino RelacionesComprobantesDeCompraOrigenDestino
		{		
			get
			{
				return this._comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino;
			}
			set
			{
				this._comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino = value;
			}
		}
			
		public override ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _comprobantesPendientes.ArrayIdComporbantesPendientes;
			}
			set
			{	
				_comprobantesPendientes.ArrayIdComporbantesPendientes = value;
			}
		}

		

		public string IdProveedor
		{
			get
			{
				return _comprobantesPendientes.IdProveedor;
			}
			set
			{
				_comprobantesPendientes.IdProveedor = value;
			}

		}

		
		
	
		public string IdResponsable
		{
			get
			{
				return _comprobantesPendientes.IdResponsable;
			}
			set
			{		
				_comprobantesPendientes.IdResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _comprobantesPendientes.FechaDesde;
			}
			set
			{
				_comprobantesPendientes.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _comprobantesPendientes.FechaHasta;
			}
			set
			{
				_comprobantesPendientes.FechaHasta = value;
			}
		}

		public override string FamiliaComprobantes
		{
			get
			{
				return _comprobantesPendientes.FamiliaComprobantes;
			}
			set
			{
				_comprobantesPendientes.FamiliaComprobantes = value;
			}
		}
		public override string TextoBotonSiguiente
		{
			get 
			{				
				return _comprobantesPendientes.TextoBotonSiguiente;
			}
		}

		public override string TextoBotonAnterior
		{
			get 
			{
				return _comprobantesPendientes.TextoBotonAnterior;
			}
		}

		
		#endregion

		#region Metodos Privados

		private void InitEvents()
		{		
			this._comprobantesPendientes.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
		}

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

			
		private void Init()
		{
			InitializeData();
			string Tarea = this._comprobantesPendientes.GetTaskName();
			string Proceso = this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName;			
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "Proveedor","Proveedor",true,null,"Idproveedor");
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			//_filtros.Add( "Persona","Responsable de Emisión",true,null, "IdResponsable");
			_filtros.Add( "Responsable","Responsable de Emisión", true, null, "IdResponsable");						
			_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,null, "FamiliaComprobantes");
			_allowMultipleSelect = _allowMultipleSelect = Variables.GetValueBool("Momentos."+Tarea+"."+ _comprobantesPendientes.ProcesoEnEjecucion+".AllowMultipleSelect");
			_allowShowDetail = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes");
			_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");			
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);
			_tiposComprobantesDestinoExcluidos = Variables.GetValueString(Proceso, Tarea, "TiposDeComprobantesExcluidos");

			_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");
            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
            //Fin German 2010105 - Tarea 856


			InitEvents();
		}

		private void InitializeData()
		{
			SetLeyendaFormulario();
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString("Momentos."+_comprobantesPendientes.GetTaskName()+"."+ _comprobantesPendientes.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _comprobantesPendientes.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
			
		}
		#endregion

		#region Metodos Publicos

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
			return this._processManager.IsFirstTask(_comprobantesPendientes.GetTaskName());
		}

		public string GetTaskName()
		{
			return _comprobantesPendientes.GetTaskName();
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
			return _comprobantesPendientes.AllowPrevious();
		}

		public void Previous()
		{
			_comprobantesPendientes.Previous();
		}

			
		public override bool AllowShow()
		{
			return true;
		}
		public override void Execute()
		{
			_comprobantesPendientes.Execute();
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
			//string tiposComprobantesOrigen = mz.erp.systemframework.Util.PackString(this._comprobantesPendientes.TiposDeComprobantesOrigen,",");
			string tiposComprobantesOrigen = Variables.GetValueString("Momentos."+_comprobantesPendientes.GetTaskName()+"."+ _comprobantesPendientes.ProcesoEnEjecucion+".TiposComprobantesOrigen");
			if (tiposComprobantesOrigen == "")
			{
				tiposComprobantesOrigen = mz.erp.systemframework.Util.PackString(this._comprobantesPendientes.TiposDeComprobantesOrigen,",");
			}
			string tiposComprobantesDestino = Variables.GetValueString("Momentos."+_comprobantesPendientes.GetTaskName()+"."+ _comprobantesPendientes.ProcesoEnEjecucion+".TiposComprobantesDestino");
			if (tiposComprobantesDestino  == "")
			{
				tiposComprobantesDestino = mz.erp.systemframework.Util.PackString(this._comprobantesPendientes.TiposDeComprobantesDestino,",");
			}
			bool verHTML = false;
			if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
				verHTML = true;
				
			System.Data.DataSet data = mz.erp.ui.controllers.ComprobantesDeCompraPendientes.GetList(this.IdProveedor,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino,verHTML,_tiposComprobantesDestinoExcluidos);
			this._table = data.Tables[0];
			this._layoutData = mz.erp.ui.controllers.ComprobantesDeCompraPendientes.GetLayout();
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _comprobantesPendientes.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

		#endregion
	}
}
