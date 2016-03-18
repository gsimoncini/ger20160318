using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;
using System.Text;





namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ReparacionesAjustesController.
	/// </summary>
	public class ReparacionesAjustesController:ConsultasController, ITaskController
	{
		#region constructores
		public ReparacionesAjustesController()
		{
		}
		
		public ReparacionesAjustesController(mz.erp.businessrules.SeleccionReparacionAjustes reparacionesAjustes)
		{
			_reparacionesAjustes = reparacionesAjustes;
			Init();
			
		}
		#endregion

		#region Variables Privadas
	
		private SeleccionReparacionAjustes _reparacionesAjustes;

		#endregion


		#region Metodos Privados

		private void Init()
		{
			InitializeData();
			string Tarea = this._reparacionesAjustes.GetTaskName();
			string Proceso = this._reparacionesAjustes.GetProcessManagerParent().Process.ProcessName;			
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "IdOrdenReparacion","Nro Orden de Reparación",true,null,"IdOrdenReparacion");
			_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");			
			_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,null, "FamiliaComprobantes");
			_filtros.Add("EstadosOrdenReparacion", "Estado", true, null, "IdEstado",_reparacionesAjustes.TableEstadosFiltrados);
			_allowMultipleSelect = Variables.GetValueBool("Momentos."+Tarea+"."+ _reparacionesAjustes.ProcesoEnEjecucion+".AllowMultipleSelect");;
			_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
			_allowShowDetail = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes");
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);

			_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");

            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
            //Fin German 2010105 - Tarea 856

	
			InitDataBindings();
			InitEvents();
		}

		private void InitDataBindings()
		{
			
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
			string leyenda = Variables.GetValueString("Momentos."+_reparacionesAjustes.GetTaskName()+"."+ _reparacionesAjustes.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _reparacionesAjustes.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
			
		}

		#endregion	
        #region Metodos Públicos
        //Cristian Tsrea 0000050 20110310
        //Cristian tarea 0000146 20110721
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._reparacionesAjustes.updateFechas(fechaDesde, ordenInverso);
            if (!ordenInverso)
            {
                return this.FechaHasta;
            }
            else { return this.FechaDesde; }
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
        #endregion

		#region Miembros de ITaskController
	

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
			return this._processManager.IsFirstTask(_reparacionesAjustes.GetTaskName());
		}

		public string GetTaskName()
		{
			return _reparacionesAjustes.GetTaskName();
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
			return _reparacionesAjustes.AllowPrevious();
		}

		public void Previous()
		{
			_reparacionesAjustes.Previous();
		}

			
		public override bool AllowShow()
		{
			return true;
		}
		public override void Execute()
		{
			_reparacionesAjustes.Execute();
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
			this._table = _reparacionesAjustes.RefreshData();
			this._layoutData = this.GetLayout();
		}
		
		private string[] _fieldList=null;
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdOrdenReparacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdOrdenReparacion", "Orden Nro",75 ) );
			if ( fl.Contains( "CodigoEstadoOrdenReparacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoEstadoOrdenReparacion" , "Estado",75 ) );
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta",true ) );
			if ( fl.Contains( "Cuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuenta", "Cuenta",125) );
			//if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100,Types.Aligment.Far, Types.FormatDisplay.Money  ) );
			if ( fl.Contains( "FechaComprometida" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaComprometida", "Fecha Comprometida",125 ) );
			if ( fl.Contains( "IdUsuarioAlta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUsuarioAlta", "Responsable Alta",100 ) );
			if ( fl.Contains( "DescripcionEquipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEquipo", "Equipo",200 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha",125 ) );
			if ( fl.Contains( "Telefono" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono",100 ) );
			if ( fl.Contains( "Domicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",100 ) );
			if ( fl.Contains( "IdTipoDocumento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDocumento", "Tipo Doc.",100 ) );
			if ( fl.Contains( "Documento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Documento", "Documento",100 ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	

		public ItemsDatasetErrors GetErrors()
		{
			return _reparacionesAjustes.GetErrors();
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
		
		public event EventHandler OnTaskAfterExecute;
		
		
		public string IdOrdenReparacion
		{
			get
			{
				return _reparacionesAjustes.IdOrdenReparacion;

			}
			set
			{
				_reparacionesAjustes.IdOrdenReparacion = value;
			}
		}
		
		public override bool HasShowSeleccionItems
		{
			get
			{
				return _reparacionesAjustes.HasShowSeleccionItems;
			}
			set
			{	
				_reparacionesAjustes.HasShowSeleccionItems = value;
			}
		}

		public override RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{		
			get
			{
				return this._reparacionesAjustes.RelacionesComprobanteOrigenDestino;
			}
			set
			{
				this._reparacionesAjustes.RelacionesComprobanteOrigenDestino = value;
			}
		}
			
		public override ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _reparacionesAjustes.ArrayIdComporbantesPendientes;
			}
			set
			{	
				_reparacionesAjustes.ArrayIdComporbantesPendientes = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _reparacionesAjustes.IdCuenta;
			}

		}

		public string IdProveedor
		{
			get
			{
				return _reparacionesAjustes.IdProveedor;
			}
			set
			{
				_reparacionesAjustes.IdProveedor = value;
			}

		}
		
		public string CodigoCuenta
		{
			get
			{
				return _reparacionesAjustes.CodigoCuenta;
			}
			set
			{
				_reparacionesAjustes.CodigoCuenta = value;
			}
		}
	
		public string IdResponsable
		{
			get
			{
				return _reparacionesAjustes.IdResponsable;
			}
			set
			{		
				_reparacionesAjustes.IdResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _reparacionesAjustes.FechaDesde;
			}
			set
			{
				_reparacionesAjustes.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _reparacionesAjustes.FechaHasta;
			}
			set
			{
				_reparacionesAjustes.FechaHasta = value;
			}
		}

		public override string FamiliaComprobantes
		{
			get
			{
				return _reparacionesAjustes.FamiliaComprobantes;
			}
			set
			{
				_reparacionesAjustes.FamiliaComprobantes = value;
			}
		}

		public string IdEstado
		{
			get
			{
				return _reparacionesAjustes.IdEstado;
			}
			set
			{
				_reparacionesAjustes.IdEstado = value;
			}
		}

		#endregion
	}
}
