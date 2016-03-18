using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarComprobantesController.
	/// </summary>
	public class ListarComprobantesDVController: ConsultasController, ITaskController
	{
		public ListarComprobantesDVController(mz.erp.businessrules.ListarComprobantes listarComprobantesDV)
		{
			this._listarComprobantesDV = listarComprobantesDV;
			Init();
		}
		

		#region Variables Privadas
			
		private mz.erp.businessrules.ListarComprobantes _listarComprobantesDV;
			
		#endregion

		#region Variables Publicas

		public event EventHandler OnTaskAfterExecute;


		public ArrayList ArrayComprobantes
		{
			get
			{
				return _listarComprobantesDV.ArrayListaComporbantes;
			}
			set
			{	
				_listarComprobantesDV.ArrayListaComporbantes = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _listarComprobantesDV.IdCuenta;
			}

		}

		public string CodigoCuenta
		{
			get
			{
				return _listarComprobantesDV.CodigoCuenta;
			}
			set
			{
				_listarComprobantesDV.CodigoCuenta = value;
			}
		}
		
		public string IdResponsable
		{
			get
			{
				return _listarComprobantesDV.IdResponsable;
			}
			set
			{		
				_listarComprobantesDV.IdResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _listarComprobantesDV.FechaDesde;
			}
			set
			{
				_listarComprobantesDV.FechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _listarComprobantesDV.FechaHasta;
			}
			set
			{
				_listarComprobantesDV.FechaHasta = value;
			}
		}

		public string TipoComprobante
		{
			get 
			{	
				return _listarComprobantesDV.TipoComprobante;
			}
			set
			{
				_listarComprobantesDV.TipoComprobante = value;
			}
		}

		public override string FamiliaComprobantes
		{
			get
			{
				return _listarComprobantesDV.FamiliaComprobantes;
			}
			set
			{
				_listarComprobantesDV.FamiliaComprobantes = value;
			}
		}



		#endregion

		#region Metodos Privados

		private void InitEvents()
		{		
			this._listarComprobantesDV.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
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
			string Tarea = this._listarComprobantesDV.GetTaskName();
			string Proceso = this._listarComprobantesDV.GetProcessManagerParent().Process.ProcessName;			
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			_filtros.Add( "Persona","Responsable de Emisión",true,null, "IdResponsable");
			_filtros.Add( "TipoDeComprobanteAgrupadoDV","Tipos de Comprobantes",true, null, "FamiliaComprobantes");
			_allowMultipleSelect = true;
            _allowPrintItem = true;
			_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
			_allowShowDetail = _listarComprobantesDV.AllowShowDetail;
			_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);		

			_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");

            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
            //Fin German 2010105 - Tarea 856
            /* Silvina 20110427 - Tarea 0000114 */
            _groups = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.ListaGruposDefault");
            _editGroups = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteGrupos");
            _totalGroups = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteTotalizarGrupos");
            _fieldsTotalGroups = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.ListaGruposTotalizar");
            _gridTotal = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteTotalizarGrilla");  
            /* Fin Silvina 20110427 - Tarea 0000114 */	

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
			string leyenda = Variables.GetValueString("Momentos."+_listarComprobantesDV.GetTaskName()+"."+ _listarComprobantesDV.ProcesoEnEjecucion+".LeyendaFormulario");
			if (leyenda.Equals(string.Empty))
			{
				leyenda = _listarComprobantesDV.GetTaskName();
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
			return _listarComprobantesDV.GetTaskName();
		}


		public override bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_listarComprobantesDV.GetTaskName());
		}

		public override bool IsLastTask()
		{
			return this._processManager.IsLastTask(_listarComprobantesDV.GetTaskName());
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
			return _listarComprobantesDV.AllowPrevious();
		}

		public void Previous()
		{
			_listarComprobantesDV.Previous();
		}

			
		public override bool AllowShow()
		{
			return true;
		}
		public override void Execute()
		{
			_listarComprobantesDV.Execute();
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
				
			System.Data.DataSet data = mz.erp.ui.controllers.ListarComprobantesWF.GetListDV( this.IdCuenta, this.FechaDesde, this.FechaHasta, this.IdResponsable, this.FamiliaComprobantes, verHTML);
			this._table = data.Tables[0];
			this._layoutData = mz.erp.ui.controllers.ListarComprobantesWF.GetLayout();
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _listarComprobantesDV.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

		#endregion
        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110721
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _listarComprobantesDV.updateFechas(fechaDesde, ordenInverso);
            if (!ordenInverso)
            {
                return this.FechaHasta;
            }
            else { return this.FechaDesde; }
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
	}
}
