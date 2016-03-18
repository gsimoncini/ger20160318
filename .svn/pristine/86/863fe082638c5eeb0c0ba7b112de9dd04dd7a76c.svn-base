using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;
using System.Data;
using System.Text;
using System.Reflection;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesPendientesController.
	/// </summary>
	public class ComprobantesPendientesController: ConsultasController, ITaskController
	{
		public ComprobantesPendientesController(mz.erp.businessrules.ComprobantesPendientes comprobantesPendientes)
		{
						
			this._comprobantesPendientes = comprobantesPendientes;
			Init();
		}

		public override void GenerateRelacionOrigenDestino(string IdComprobante)
		{
			ArrayList param = new ArrayList();
			param.Add(IdComprobante);
			this.RelacionesComprobantesOrigenDestino = new RelacionesComprobanteOrigenDestino(param, this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName, this._comprobantesPendientes.GetTaskName(), this._comprobantesPendientes.GetProcessManagerParent().Process.MainTask.KeyTask);					
			this.HasShowSeleccionItems = false;
			this.Execute();	
			
		}

		public override void SetSelectedItems(ArrayList selectedItems)
		{
			this._comprobantesPendientes.SelectedItems = selectedItems;
		}


		#region Variables Privadas
			
			private mz.erp.businessrules.ComprobantesPendientes _comprobantesPendientes;
			
			

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

		public override RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{		
			get
			{
				return this._comprobantesPendientes.RelacionesComprobanteOrigenDestino;
			}
			set
			{
				this._comprobantesPendientes.RelacionesComprobanteOrigenDestino = value;
			}
		}
			
		public override ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _comprobantesPendientes.ArrayIdComprobantesPendientes;
			}
			set
			{	
				_comprobantesPendientes.ArrayIdComprobantesPendientes = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _comprobantesPendientes.IdCuenta;
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

		
		public string CodigoCuenta
		{
			get
			{
				return _comprobantesPendientes.CodigoCuenta;
			}
			set
			{
				_comprobantesPendientes.CodigoCuenta = value;
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

        /* Silvina 20111212 - Tarea 0000232 */

        public DateTime FechaVencimientoDesde
		{
			get
			{
				return _comprobantesPendientes.FechaVencimientoDesde;
			}
			set
			{
				_comprobantesPendientes.FechaVencimientoDesde = value;
			}
		}

        public DateTime FechaVencimientoHasta
		{
			get
			{
				return _comprobantesPendientes.FechaVencimientoHasta;
			}
			set
			{
				_comprobantesPendientes.FechaVencimientoHasta = value;
			}
		}
 
        /* Fin Silvina 20111212 - Tarea 0000232 */

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
			ConfigureFilters();
			_allowMultipleSelect = _allowMultipleSelect = Variables.GetValueBool("Momentos."+Tarea+"."+ _comprobantesPendientes.ProcesoEnEjecucion+".AllowMultipleSelect");
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



		private void ConfigureFilters()
		{
			_filtros = new mz.erp.commontypes.ReportFilterArray();
			switch(this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
			{
				case"ProcesoPrepararConfirmarPreparar":
					_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
					_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
				break;
                /* Silvina 20111212 - Tarea 0000232 */
                case "ProcesoAnularPrevenderReserva":
                    _filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
					_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
					_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
                    _filtros.Add( "Fecha","Desde Fecha Venc. Reserva",true,null,"FechaVencimientoDesde");
                    _filtros.Add( "Fecha", "Hasta Fecha Venc. Reserva", true, null, "FechaVencimientoHasta");
					_filtros.Add( "Responsable","Responsable de Emisión", true, null, "IdResponsable");						
					_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,null, "FamiliaComprobantes");
                break;
                /* FinSilvina 20111212 - Tarea 0000232 */
				default:
					
					_filtros.Add( "Cuenta","Cuenta",true,null,"CodigoCuenta");
					_filtros.Add( "Fecha","Desde Fecha",true,null,"FechaDesde");
					_filtros.Add( "Fecha","Hasta Fecha",true,null, "FechaHasta");
					_filtros.Add( "Responsable","Responsable de Emisión", true, null, "IdResponsable");						
					_filtros.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,null, "FamiliaComprobantes");
				break;
			}
		
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
			string tiposComprobantesOrigen = mz.erp.systemframework.Util.PackString(this._comprobantesPendientes.TiposDeComprobantesOrigen,",");
			string tiposComprobantesDestino = mz.erp.systemframework.Util.PackString(this._comprobantesPendientes.TiposDeComprobantesDestino,",");
			bool verHTML = false;
			if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
				verHTML = true;
			System.Data.DataSet data;
			
			switch(this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoPrepararDiferidoPreparar": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoEntregarDV": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoPrepararDiferidoVenderManual": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoRemitirVenderManual": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoRemitirVender": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoRemitirPreprestar": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoRemitirPrestar": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoRemitirPrevender": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularRemitir": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularPreRemitirHudson": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoPreRemitirRemitirHudson": this._layoutData = this.GetLayoutEntregas();break;


				case "ProcesoRemitirConfirmarRemitir": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularPreparar": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularPrepararDiferido": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularPrepararDiferidoDV": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularEntregar": this._layoutData = this.GetLayoutEntregas();break;
				case "ProcesoAnularEntregarDV": this._layoutData = this.GetLayoutEntregas();break;
			
				//case "ProcesoEntregasConsultaEntregaDeposito": this._layoutData = this.GetLayoutEntregas();break;
				//case "ProcesoEntregasConsultaOrdenesDeEnvio": this._layoutData = this.GetLayoutEntregas();break;
				//case "ProcesoEntregasConsultaConfMercEnviada": this._layoutData = this.GetLayoutEntregas();break;
                case "ProcesoAnularPrevenderReserva": this._layoutData = this.GetLayoutReservas(); break;
				default:this._layoutData = this.GetLayout();break;
			}
			if(_comprobantesPendientes.RequiereBuscarPendientes)
			{
				switch(this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoPrepararDiferidoPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoEntregarDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPrepararDiferidoVenderManual": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirVenderManual": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirConfirmarRemitir": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirVender": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPreprestar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPrestar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPrevender": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularRemitir": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPrepararDiferido": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPrepararDiferidoDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPreRemitirHudson": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPreRemitirRemitirHudson": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;

                    /* Silvina 20100603 - Tarea 645 */
					//case "ProcesoAnularEntregar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					//case "ProcesoAnularEntregarDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
                    /* Fin Silvina */
					case "ProcesoRemitirCotizar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
			
						//case "ProcesoEntregasConsultaEntregaDeposito": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
						//case "ProcesoEntregasConsultaOrdenesDeEnvio": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPrepararConfirmarPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListPendientesNumeroDeSerie(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
                    /* Silvina 20111212 - Tarea 0000232 */
                    case "ProcesoAnularPrevenderReserva": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListPendientesReservas(this.IdCuenta, this.FechaDesde, this.FechaHasta, FechaVencimientoDesde, FechaVencimientoHasta, this.IdResponsable, tiposComprobantesOrigen, tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML); break;
                    /* Fin Silvina 20111212 - Tarea 0000232 */
					default: data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetList(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
				}
			}
			else
			{
				switch(this._comprobantesPendientes.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoPrepararDiferidoPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoEntregarDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPrepararDiferidoVenderManual": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirVenderManual": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirVender": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirConfirmarRemitir": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPreprestar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPrestar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoRemitirPrevender": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularRemitir": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPreRemitirHudson": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPrepararDiferido": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularPrepararDiferidoDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPreRemitirRemitirHudson": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;

					case "ProcesoAnularEntregar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoAnularEntregarDV": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListExEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
			
			
						//case "ProcesoEntregasConsultaEntregaDeposito": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
						//case "ProcesoEntregasConsultaOrdenesDeEnvio": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEntregas(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					case "ProcesoPrepararConfirmarPreparar": data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListPendientesNumeroDeSerie(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
					default: data = mz.erp.ui.controllers.ComprobantesPendientesWF.GetListEx(this.IdCuenta,this.FechaDesde,this.FechaHasta,this.IdResponsable,tiposComprobantesOrigen,tiposComprobantesDestino, this._comprobantesPendientes.TiposDeComprobanteDestinoExcluidos, verHTML);break;
				}
			}
			this._table = data.Tables[0];
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

		public  string GetLayout()
		{
			ArrayList fl = new ArrayList();
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			if(true)
			{
				sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",150 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
				sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",100 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );				
				sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100, Types.Aligment.Far, Types.FormatDisplay.Money ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",100 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
				sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
				sb.Append( LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes",true ) );
				sb.Append( LayoutBuilder.GetRow(i++, "TextoHTML", "TextoHTML",true ) );

			}
			else
			{
				sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",250 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
				sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",100 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
				sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
				sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
				sb.Append( LayoutBuilder.GetRow(i++, "TextoHTML", "TextoHTML",true ) );
			}
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}

		public  string GetLayoutEntregas()
		{
			ArrayList fl = new ArrayList();
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
			sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "F. Vencimiento",125 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Domicilio",200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			sb.Append( LayoutBuilder.GetRow(i++, "TextoHTML", "TextoHTML",true ) );
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}

        /* Silvina 20111212 - Tarea 0000232 */
        public string GetLayoutReservas()
        {
            ArrayList fl = new ArrayList();
            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(LayoutBuilder.GetHeader());
            sb.Append(LayoutBuilder.GetRow(i++, "IdComprobante", "IdComprobante", true));
            sb.Append(LayoutBuilder.GetRow(i++, "Descripcion", "Comprobante", 150));
            sb.Append(LayoutBuilder.GetRow(i++, "Numero", "Número", 125));
            sb.Append(LayoutBuilder.GetRow(i++, "Fecha", "Fecha", 125));
            sb.Append(LayoutBuilder.GetRow(i++, "FechaVencimientoReserva", "F.Venc.Reserva", 125));
            sb.Append(LayoutBuilder.GetRow(i++, "Codigo", "Código", 100));
            sb.Append(LayoutBuilder.GetRow(i++, "Nombre", "Cliente", 200));
            sb.Append(LayoutBuilder.GetRow(i++, "Total", "Total", 100, Types.Aligment.Far, Types.FormatDisplay.Money));
            sb.Append(LayoutBuilder.GetRow(i++, "Moneda", "Moneda", 100));
            sb.Append(LayoutBuilder.GetRow(i++, "Responsable", "Resp.Emisión", 150));
            sb.Append(LayoutBuilder.GetRow(i++, "Empresa", "Empresa", true));
            sb.Append(LayoutBuilder.GetRow(i++, "Sucursal", "Sucursal", true));
            sb.Append(LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante", true));
            sb.Append(LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes", true));
            sb.Append(LayoutBuilder.GetRow(i++, "TextoHTML", "TextoHTML", true));

            sb.Append(LayoutBuilder.GetFooter());

            return sb.ToString();
        }
        /* Fin Silvina 20111212 - Tarea 0000232 */

        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110721
        public override DateTime updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._comprobantesPendientes.updateFechas(fechaDesde, ordenInverso);
            if (!ordenInverso)
            {
                return this.FechaHasta;
            }
            else { return this.FechaDesde; }
        }
        //Fin cristian Tarea 0000146
        //Fin Cristian	
		#endregion
	}
}
