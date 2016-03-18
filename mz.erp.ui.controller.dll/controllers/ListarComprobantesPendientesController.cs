using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.systemframework;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// ListarComprobantesPendientesController: subclase de ConsultasController, que implementa la interfaz ITaskController
	/// </summary>
	public class ListarComprobantesPendientesController: ConsultasController, ITaskController
	{
		public ListarComprobantesPendientesController(mz.erp.businessrules.ListarComprobantesPendientes listarComprobantesPendientes)
		{
						
			this._listarComprobantesPendientes = listarComprobantesPendientes;
			Init();
		}

		#region Variables Privadas
			
			private mz.erp.businessrules.ListarComprobantesPendientes _listarComprobantesPendientes;
			
		#endregion

		#region Variables Publicas

			public event EventHandler OnTaskAfterExecute;

		public string ListaTiposDeComprobantesExcluidos
		{
			get
			{
				return _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos;
			}
		}


			public ArrayList ArrayComprobantesPendientes
			{
				get
				{
					return _listarComprobantesPendientes.ArrayListaComporbantesPendientes;
				}
				set
				{	
					_listarComprobantesPendientes.ArrayListaComporbantesPendientes = value;
				}
			}

			public string IdCuenta
			{
				get
				{
					return _listarComprobantesPendientes.IdCuenta;
				}

			}

			public string IdProveedor
			{
				get
				{
					return _listarComprobantesPendientes.IdProveedor;
				}
				set
				{
					_listarComprobantesPendientes.IdProveedor = value;
				}

			}
			
			public string CodigoCuenta
			{
				get
				{
					return _listarComprobantesPendientes.CodigoCuenta;
				}
				set
				{
					_listarComprobantesPendientes.CodigoCuenta = value;
				}
			}
		
			public string IdResponsable
			{
				get
				{
					return _listarComprobantesPendientes.IdResponsable;
				}
				set
				{		
					_listarComprobantesPendientes.IdResponsable = value;
				}
			}
			public DateTime FechaDesde
			{
				get
				{
					return _listarComprobantesPendientes.FechaDesde;
				}
				set
				{
					_listarComprobantesPendientes.FechaDesde = value;
				}
			}

		public bool SoloPendientes
		{
			get{return _listarComprobantesPendientes.SoloPendientes;}
			set{_listarComprobantesPendientes.SoloPendientes = value;}
		}

			public DateTime FechaHasta
			{
				get
				{
					return _listarComprobantesPendientes.FechaHasta;
				}
				set
				{
					_listarComprobantesPendientes.FechaHasta = value;
				}
			}

			
		#endregion

		#region Metodos Privados

			private void InitEvents()
			{		
				this._listarComprobantesPendientes.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
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
				string Tarea = this._listarComprobantesPendientes.GetTaskName();
				string Proceso = this._listarComprobantesPendientes.GetProcessManagerParent().Process.ProcessName;							

				_filtros = new mz.erp.commontypes.ReportFilterArray();
				_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
				_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
				_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
				_filtros.Add( "Persona","Responsable de Emisión",true,null, "IdResponsable");
				switch(this._listarComprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoEntregasConsultaOrdenesPendientes": _filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");break;
					case "ProcesoEntregasConsultaOrdPrepControladas": _filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");break;
					//case "ProcesoEntregasConsultaEntregaDeposito": _filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");break;
					case "ProcesoEntregasConsultaOrdenesDeEnvio": _filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");break;
					case "ProcesoEntregasConsultaConfMercEnviada": _filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");break;
					case "ProcesoConsultaOrdenesPreparadasPendientesEntrega":_filtros.Add("CheckBox","Pendientes",true,true, "SoloPendientes");	 break;
					default:break;
				}
				
			
				_allowMultipleSelect = true;
				_allowFastSearch = Variables.GetValueBool(Proceso, Tarea, "AllowFastSearch", true);
				this._allowShowDetail = Variables.GetValueBool(Proceso, Tarea,"VisualizaDetalleComprobantes");
				_idComprobanteFieldName = Variables.GetValueString(Proceso, Tarea, "NombreCampoIdComprobante");
				_idTipoDeComprobanteFieldName =Variables.GetValueString(Proceso, Tarea, "NombreCampoIdTipoDeComprobante");;
				_showDetailBy = Variables.GetValueString(Proceso, Tarea, "MetodoVisualizacionDetalle");
				_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);	
				InitEvents();
				_groups = Variables.GetValueString(Proceso, Tarea, "Grilla.Grupos");
				_editGroups = Variables.GetValueBool(Proceso, Tarea, "Grilla.PermiteGruposPersonalizados");
				_totalGroups = Variables.GetValueBool(Proceso, Tarea, "Grilla.TotalGrupos");
				_fieldsTotalGroups = Variables.GetValueString(Proceso, Tarea, "Grilla.CamposTotalGrupo");
				_fieldsTotalGrid = Variables.GetValueString(Proceso, Tarea, "Grilla.CamposTotalGrilla");
				_gridTotal = Variables.GetValueBool(Proceso, Tarea, "Grilla.TotalGrilla");

				_allowExportarAExcel = Variables.GetValueBool(Proceso, Tarea, "GrillaResultado.PermiteExportarAExcel");

                //German 2010105 - Tarea 856
                _orderBy = Variables.GetValueString(Proceso, Tarea, "GrillaResultado.OrdenarPor");
                //Fin German 2010105 - Tarea 856

		
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
				string leyenda = Variables.GetValueString("Momentos."+_listarComprobantesPendientes.GetTaskName()+"."+ _listarComprobantesPendientes.ProcesoEnEjecucion+".LeyendaFormulario");
				if (leyenda.Equals(string.Empty))
				{
					leyenda = _listarComprobantesPendientes.GetTaskName();
				}
				this._leyendaFormulario = leyenda;
				
			}


		#endregion

		#region Metodos Publicos

		public override  bool IsFlushedState()
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
			return _listarComprobantesPendientes.GetTaskName();
		}


		public override bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_listarComprobantesPendientes.GetTaskName());
		}

		public override bool IsLastTask()
		{
			return this._processManager.IsLastTask(_listarComprobantesPendientes.GetTaskName());
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

		public  bool AllowPrevious()
		{
			return _listarComprobantesPendientes.AllowPrevious();
		}

		public void Previous()
		{
			_listarComprobantesPendientes.Previous();
		}

			
			public override bool AllowShow()
			{
				return true;
			}
			public override void Execute()
			{
				_listarComprobantesPendientes.Execute();
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
				string tiposComprobantesOrigen = mz.erp.systemframework.Util.PackString(this._listarComprobantesPendientes.TiposDeComprobantesOrigen,",");
				string comprobante = _listarComprobantesPendientes.ObtenerComprobante();
				bool verHTML = false;
				if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
					verHTML = true;
				switch(this._listarComprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoEntregasConsultaOrdenesPendientes": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					case "ProcesoEntregasConsultaOrdPrepControladas": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					//case "ProcesoEntregasConsultaEntregaDeposito": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					case "ProcesoEntregasConsultaOrdenesDeEnvio": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					case "ProcesoEntregasConsultaConfMercEnviada": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					case "ProcesoConsultaOrdenesPreparadasPendientesEntrega": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					case "ProcesoConsultarAbonosPendientes": this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayoutEntregas();break;
					default:this._layoutData = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetLayout();break;
				}
				System.Data.DataSet data;
				
				switch(this._listarComprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoEntregasConsultaOrdenesPendientes": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					case "ProcesoEntregasConsultaOrdPrepControladas": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					//case "ProcesoEntregasConsultaEntregaDeposito": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes);break;
					case "ProcesoEntregasConsultaOrdenesDeEnvio": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					case "ProcesoEntregasConsultaConfMercEnviada": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					case "ProcesoConsultaOrdenesPreparadasPendientesEntrega": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					case "ProcesoConsultarAbonosPendientes": data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, this.SoloPendientes, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);break;
					
					default: data = mz.erp.ui.controllers.ListarComprobantesPendientesWF.GetList(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen, comprobante, verHTML, _listarComprobantesPendientes.ListaTiposDeComprobantesExcluidos);break;
				}
				this._table = data.Tables[0];
				this._listarComprobantesPendientes.Result = this._table;
				
			}
			public ItemsDatasetErrors GetErrors()
			{
				return _listarComprobantesPendientes.GetErrors();
			}
			public string GetWarnings()
			{
				return null;
			}

		public void Continue()
		{
		}

        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000050 20110721
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._listarComprobantesPendientes.updateFechas(fechaDesde,ordenInverso);
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


