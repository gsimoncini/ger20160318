using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.systemframework;
using System.Data;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarComprobantesController.
	/// </summary>
	public class ListarComprobantesController: ConsultasController, ITaskController
	{
		public ListarComprobantesController(mz.erp.businessrules.ListarComprobantes listarComprobantes)
		{
			this._listarComprobantes = listarComprobantes;
			Init();
		}
		
        #region Variables Privadas
			
		private mz.erp.businessrules.ListarComprobantes _listarComprobantes;
	
			
		#endregion

		#region Variables Publicas

		public bool GridTotal
		{
			get{return _gridTotal;}
		}

		public string FieldsTotalGrid
		{
			get{return _fieldsTotalGrid;}
		}

		public string Groups
		{
			get{return _groups;}
		}

		public string FieldsTotalGroups
		{
			get{return _fieldsTotalGroups;}
		}

		public bool EditGroups
		{
			get{return _editGroups;}
		}

		public bool TotalGroups
		{
			get{return _totalGroups;}
		}


		public event EventHandler OnTaskAfterExecute;


		public ArrayList ArrayComprobantes
		{
			get
			{
				return _listarComprobantes.ArrayListaComporbantes;
			}
			set
			{	
				_listarComprobantes.ArrayListaComporbantes = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _listarComprobantes.IdCuenta;
			}

		}

		public bool SoloPendientes
		{
			get{return _listarComprobantes.SoloPendientes;}
			set{_listarComprobantes.SoloPendientes = value;}
		}

		public string CodigoCuenta
		{
			get
			{
				return _listarComprobantes.CodigoCuenta;
			}
			set
			{
				_listarComprobantes.CodigoCuenta = value;
			}
		}
		
		public string IdResponsable
		{
			get
			{
				return _listarComprobantes.IdResponsable;
			}
			set
			{		
				_listarComprobantes.IdResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _listarComprobantes.FechaDesde;
			}
			set
			{
				_listarComprobantes.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _listarComprobantes.FechaHasta;
			}
			set
			{
				_listarComprobantes.FechaHasta = value;
			}
		}

		public string TipoComprobante
		{
			get 
			{	
				return _listarComprobantes.TipoComprobante;
			}
			set
			{
				_listarComprobantes.TipoComprobante = value;
			}
		}

		public override string FamiliaComprobantes
		{
			get
			{
				return _listarComprobantes.FamiliaComprobantes;
			}
			set
			{
				 _listarComprobantes.FamiliaComprobantes = value;
			}
		}



		#endregion

		#region Metodos Privados

		private void InitEvents()
		{		
			this._listarComprobantes.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
		}

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		
		/// <summary>
		/// En particular agrega los filtros , despues es como el resto de los init del Workflow
		/// </summary>
		private void Init()
		{
			InitializeData();
			string Tarea = this._listarComprobantes.GetTaskName();
			string Proceso = this._listarComprobantes.GetProcessManagerParent().Process.ProcessName;			

			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			_filtros.Add( "Persona","Responsable de Emisión",true,null, "IdResponsable");
			if(!this._listarComprobantes.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoEntregasConsultarArticulosPendienteDePreparacion"))
				_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,null, "FamiliaComprobantes");						
			if(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoEntregasConsultarArticulosPendienteDePreparacion"))
				_filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");						
			
				
			_allowMultipleSelect = true;
			_allowFastSearch = true;
			_allowShowDetail = _listarComprobantes.AllowShowDetail;
			_groups = Variables.GetValueString(Proceso, Tarea, "Grilla.Grupos");
			_editGroups = Variables.GetValueBool(Proceso, Tarea, "Grilla.PermiteGruposPersonalizados");
			_totalGroups = Variables.GetValueBool(Proceso, Tarea, "Grilla.TotalGrupos");
			_fieldsTotalGroups = Variables.GetValueString(Proceso, Tarea, "Grilla.CamposTotalGrupo");
			_fieldsTotalGrid = Variables.GetValueString(Proceso, Tarea, "Grilla.CamposTotalGrilla");
			_gridTotal = Variables.GetValueBool(Proceso, Tarea, "Grilla.TotalGrilla");
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);
			_allowPrintItem = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir",_visualizaBotonImprimir);
	
			_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");

            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
            //Fin German 2010105 - Tarea 856


			InitEvents();
		}

		/// <summary>
		/// Metodo necesario para inicializar los datos
		/// </summary>
		/// <example> Inicializa el valor de la leyenda del formulario </example>
		private void InitializeData()
		{
			SetLeyendaFormulario();
			
		}

		/// <summary>
		/// Setea el valor de la variable leyenda (que muestra en la ventana la accion que se esta ejecutando)
		/// </summary>
		/// <remarks> En este caso en particular, toma la información de una variable de configuración. </remarks>
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString("Momentos."+_listarComprobantes.GetTaskName()+"."+ _listarComprobantes.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _listarComprobantes.GetTaskName();
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

		public string GetTaskName()
		{
			return _listarComprobantes.GetTaskName();
		}


		public override bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_listarComprobantes.GetTaskName());
		}

		public override bool IsLastTask()
		{
			return this._processManager.IsLastTask(_listarComprobantes.GetTaskName());
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
			return _listarComprobantes.AllowPrevious();
		}

		public void Previous()
		{
			_listarComprobantes.Previous();
		}

			
		public override bool AllowShow()
		{
			return true;
		}
		public override void Execute()
		{
			_listarComprobantes.Execute();
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
			bool verHTML = false;
			if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
				verHTML = true;
			System.Data.DataSet data ;
			switch(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoEntregasConsultarArticulosPendienteDePreparacion":
				{
					string TiposDeComprobanteOrigen = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "ListaTiposDeComprobantesOrigen");
					string TiposDeComprobanteExcluidos = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "TiposDeComprobantesExcluidos");
					data = mz.erp.businessrules.reportes.rep_ListadoDeArticulosPendienteDePreparacion.GetList(TiposDeComprobanteOrigen, TiposDeComprobanteExcluidos,this.IdCuenta, this.FechaDesde, this.FechaHasta, this.IdResponsable, Security.IdEmpresa, Security.IdSucursal, verHTML, this.SoloPendientes, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,null,null,null,null,null,null,null,null);

					
				}
				break;
				default:data = mz.erp.ui.controllers.ListarComprobantesWF.GetList( this.IdCuenta, this.FechaDesde, this.FechaHasta, this.IdResponsable, this.FamiliaComprobantes, verHTML); break;
			}
			this._table = data.Tables[0];
			this._listarComprobantes.Result = this._table;
			switch(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoEntregasConsultarArticulosPendienteDePreparacion":
				{
					this._layoutData = this.GetLayoutProcesoEntregasConsultarArticulosPendienteDePreparacion();
				}
				break;
				default:this._layoutData = mz.erp.ui.controllers.ListarComprobantesWF.GetLayout(); break;
			}
			
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _listarComprobantes.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110719
        public void updateFechas(DateTime fechaDesde, bool ordenInverso )
        {
              _listarComprobantes.updateFechas(fechaDesde, ordenInverso);
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
		private string[] _fieldList=null;
		private string GetLayoutProcesoEntregasConsultarArticulosPendienteDePreparacion()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Cod.",50 ) );
			if ( fl.Contains( "Producto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",200 ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado",75 ) );
			if ( fl.Contains( "Pendiente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Pendiente", "Pendiente",50 ) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.",50 ) );
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock.",50 ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "F. Vencimiento",125 ) );
			if ( fl.Contains( "FechaCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCorta", "Fecha Corta",75 ) );
			if ( fl.Contains( "FechaVencimientoCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimientoCorta", "F. Venc. Corta",75 ) );
			if ( fl.Contains( "Mes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mes", "Mes",30 ) );
			if ( fl.Contains( "MesVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MesVencimiento", "Mes Venc.",50 ) );
			if ( fl.Contains( "Dia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Dia", "Día",30 ) );
			if ( fl.Contains( "DiaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DiaVencimiento", "Día Venc.",50 ) );
			if ( fl.Contains( "Ao" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ao", "Año",30 ) );
			if ( fl.Contains( "AoVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "AoVencimiento", "Año Venc.",50 ) );
			
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
		
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public override bool MustImprimir()
		{
			switch(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoConsultaOtrosComprobantes": return true; break;
				default: return false;
			}
		}



		#endregion
	}
}
