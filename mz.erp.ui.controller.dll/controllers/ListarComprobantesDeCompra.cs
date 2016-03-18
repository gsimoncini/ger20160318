using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.systemframework;
namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarComprobantesDeCompra.
	/// </summary>
	public class ListarComprobantesDeCompraController: ConsultasController, ITaskController
	{
		public ListarComprobantesDeCompraController(mz.erp.businessrules.ListarComprobantesDeCompra listarComprobantes)
		{
			this._listarComprobantes = listarComprobantes;
			Init();
		}
		
		#region Variables Privadas
			
		private mz.erp.businessrules.ListarComprobantesDeCompra _listarComprobantes;
	
			
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


		
		public string NumeroDeSerie
		{
			get{return _listarComprobantes.NumeroDeSerie;}
			set{_listarComprobantes.NumeroDeSerie = value;}
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
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
			_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
			_filtros.Add( "NumeroDeSerie","Numero de Serie",true,string.Empty, "NumeroDeSerie");
			_allowMultipleSelect = true;
			_allowPrintItem = true;
			_allowFastSearch = true;
			_allowShowDetail = _listarComprobantes.AllowShowDetail;
			_groups = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.Grupos");
			_editGroups = Variables.GetValueBool(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.PermiteGruposPersonalizados");
			_totalGroups = Variables.GetValueBool(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.TotalGrupos");
			_fieldsTotalGroups = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.CamposTotalGrupo");
			_fieldsTotalGrid = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.CamposTotalGrilla");
			_gridTotal = Variables.GetValueBool(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "Grilla.TotalGrilla");
			_idComprobanteFieldName = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "NombreCampoIdComprobante");
			_idTipoDeComprobanteFieldName =Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "NombreCampoIdTipoDeComprobante");;
			_showDetailBy = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "MetodoVisualizacionDetalle");

			_allowExportarAExcel = Variables.GetValueBool(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "GrillaResultado.PermiteExportarAExcel");

            //German 2010105 - Tarea 856
            _orderBy = Variables.GetValueString(this._listarComprobantes.GetProcessManagerParent().Process.ProcessName, this._listarComprobantes.GetTaskName(), "GrillaResultado.OrdenarPor");
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
				
			System.Data.DataSet data = mz.erp.ui.controllers.ComprobantesDeCompraPorNumeroDeSerie.GetList(  this.FechaDesde, this.FechaHasta,this.NumeroDeSerie);
			this._table = data.Tables[0];
			this._layoutData = mz.erp.ui.controllers.ComprobantesDeCompraPorNumeroDeSerie.GetLayout();
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
        //Cristian Tsrea 00000146 20110721
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _listarComprobantes.updateFechas(fechaDesde, ordenInverso);
            if (!ordenInverso)
            {
                return this.FechaHasta;
            }
            else { return this.FechaDesde; }
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
		#endregion
	}
}
