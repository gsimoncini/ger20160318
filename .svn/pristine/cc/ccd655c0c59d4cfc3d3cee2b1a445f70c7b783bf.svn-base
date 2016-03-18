using System;
using System.Data;
using System.Collections;
using System.Threading;
using mz.erp.commontypes.data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ComprobantesPendientesConsolaEntregas.
	/// </summary>
	public class ComprobantesPendientesConsolaEntregas: ITask
	{
		sealed class DetalleItemsComprobante
		{
			public DetalleItemsComprobante()
			{
			}
			private string _numero = string.Empty;
			private System.DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			private bool _origen = false;
            
			public string Numero
			{
				get { return _numero; }
				set { _numero = value;}
			}
			public DateTime Fecha
			{
				get { return _fecha; }
				set { _fecha = value ; }
			}
			public bool Origen
			{
				get { return _origen; }
				set { _origen = value ;}
			}

		}

		public ComprobantesPendientesConsolaEntregas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

        }
        //Fin Cristian	


        //German 20120413 - Tarea 0000247
        private string _idCuenta = string.Empty;
        private string _codigoCuenta = String.Empty;

        public string CodigoCuenta
        {
            get { return _codigoCuenta; }
            set
            {
                if (_codigoCuenta != value)
                {
                    _codigoCuenta = value;
                    _idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);
                }

            }
        }
        //Fin German 20120413 - Tarea 0000247


		#region Miembros de ITask

		public string GetWarnings()
		{
			return null;			
		}


		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler IdComprobantePrevioChanged;

		public event System.EventHandler IdComprobanteEntregaChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.ListenerAfterExecuteDependentTask
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.ListenerBeforeExecuteDependentTask
		}
		string _tiposComprobantesPreviosOrigen;
		string _tiposComprobantesPreviosDestino;
		string _tiposComprobantesPendientesOrigen;
		string _tiposComprobantesPendientesDestino;
		string _tiposDeComprobantesPreviosExcluidos = string.Empty;
		string _tiposDeComprobantesExcluidos = string.Empty;

		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
		private DataTable _dataComprobantesPrevios;
		private string _cpIdComprobante = string.Empty;
		private string _opIdComprobante = string.Empty;
		private bool _verHTML = true;
		private string _metodoVisualizacionHTML = string.Empty;
		private bool _porFechaVencimiento = false;
		private bool _requiereBuscarPendientes = true;


		public bool PorFechaDeVencimiento
		{
			get{return _porFechaVencimiento;}
		}

		public string MetodoVisualizacionHTML
		{
			get{return _metodoVisualizacionHTML;}
		}

		public bool VerHTML
		{
			get{return _verHTML;}
		}
		public DataTable DataComprobantesPrevios
		{
			get { return _dataComprobantesPrevios; }
		}
		public DataTable DataOrdenesPendientes
		{
			get { return _dataOrdenesPendientes; }
		}
		private DataTable _dataOrdenesPendientes;
		private System.Threading.Timer _timer;
		public ArrayList ComprobantesSeleccionados
		{
			get 
			{ 
				ArrayList array = new ArrayList();
		  		if ((this._opIdComprobante.CompareTo(string.Empty) != 0) && (this._opIdComprobante != null))
				{
					array.Add( this._opIdComprobante );
				}
				return array;		
			}

		}
		
		public DateTime FechaDesde
		{
			get { return _fechaDesde ; }
			set { _fechaDesde = mz.erp.systemframework.Util.GetStartDay(value ); }
		}
		public DateTime FechaHasta
		{
			get { return _fechaHasta; }
			set { _fechaHasta = mz.erp.systemframework.Util.GetEndDay( value ) ;}
		}

		public bool RequiereBuscarPendientes	
		{
			get{return _requiereBuscarPendientes;}
		}

		public void Init()
		{
			string _comprobantesPrevios = Variables.GetValueString("Momentos."+this.GetTaskName()+".ComprobantesPrevios.ProcesoTarea");
			string[] tupla = _comprobantesPrevios.Split( '.');
			string _nombreTareaComprobantesPrevios = string.Empty;
			string _nombreProcesoComprobantesPrevios = string.Empty;
			
			string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "VisualizaDetalleComprobantes";
			this._verHTML = Variables.GetValueBool(variable);
			this._metodoVisualizacionHTML = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName,"MetodoVisualizacionDetalle");
            long cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            
            //Cristian Tarea 0000051 20110411
            _fechaDesde = Sistema.GetValueFilterDate(this._processParent.Process.ProcessName, this._taskName, "FechaDesde");
            if (_fechaDesde == System.DateTime.MinValue)
            {
                this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-7);
            }
            else
            {
                if (!cantDias.Equals(long.MinValue))
                    _fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
            }
            //Fin Cristian 20110411

            //this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-7);


			
			this._fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
			cantDias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasPosteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(cantDias);
			
			if (tupla.Length == 2)
			{
				_nombreTareaComprobantesPrevios = tupla[1];
				_nombreProcesoComprobantesPrevios = tupla[0];
			}

			_tiposComprobantesPreviosOrigen = mz.erp.systemframework.Util.ConvertToString( GetTiposDeComprobantesOrigen( _nombreTareaComprobantesPrevios, _nombreProcesoComprobantesPrevios ) );
			_tiposComprobantesPreviosDestino =   mz.erp.systemframework.Util.ConvertToString( GetTiposDeComprobantesDestinos( _nombreTareaComprobantesPrevios ));
			_tiposComprobantesPendientesOrigen =  mz.erp.systemframework.Util.ConvertToString( GetTiposDeComprobantesOrigen( this._processParent.Process.MainTask.KeyTask, this._processParent.Process.ProcessName ));
			_tiposComprobantesPendientesDestino =  mz.erp.systemframework.Util.ConvertToString( GetTiposDeComprobantesDestinos( this._processParent.Process.MainTask.KeyTask ));
			_tiposDeComprobantesPreviosExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName,"ComprobantesPrevios.TiposDeComprobantesExcluidos");
			_tiposDeComprobantesExcluidos = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "TiposDeComprobantesExcluidos");
			_porFechaVencimiento = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PorFechaDeVencimiento");
			_requiereBuscarPendientes = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "RequiereBuscarPendientes", _requiereBuscarPendientes);

		
			
			//_timer = new System.Threading.Timer( new TimerCallback( this.ForceRefresh),null,System.TimeSpan.FromMinutes(10), System.TimeSpan.FromSeconds(3) );
		}

		private void ForceRefresh(object stateinfo)
		{
			RefreshData();
		}
		public string IdComprobantePrevio
		{
			set 
				{ 
					this._cpIdComprobante = value;
					if (this.IdComprobantePrevioChanged != null)
					{
						this.IdComprobantePrevioChanged(this,null);
					}
				}
		}
		public string IdComprobanteEntrega
		{
			set 
			{
				this._opIdComprobante = value;
				if (this.IdComprobanteEntregaChanged != null)
				{
					this.IdComprobanteEntregaChanged(this, null);
				}
			}
		}
		public void RefreshData()
		{
			
			bool verHTMLParameter = false;
			if(_verHTML && _metodoVisualizacionHTML.Equals("AUTOMATICO"))
				verHTMLParameter = true;
			System.Data.DataSet _data;
            
            
			if(_requiereBuscarPendientes)
			{
				if(_porFechaVencimiento)
                    
					_data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesEntregasWF( this._tiposComprobantesPreviosOrigen , this._tiposComprobantesPreviosDestino, null,_fechaDesde, _fechaHasta,  null, Security.IdSucursal, Security.IdEmpresa,_tiposDeComprobantesPreviosExcluidos , verHTMLParameter );
 
				else
 
					_data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesWF( this._tiposComprobantesPreviosOrigen , this._tiposComprobantesPreviosDestino, null,_fechaDesde, _fechaHasta,  null, Security.IdSucursal, Security.IdEmpresa,_tiposDeComprobantesPreviosExcluidos , verHTMLParameter );
                    
			}
			else
			{
				if(_porFechaVencimiento)

					_data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesEntregasWF( this._tiposComprobantesPreviosOrigen , this._tiposComprobantesPreviosDestino, null,_fechaDesde, _fechaHasta,  null, Security.IdSucursal, Security.IdEmpresa,_tiposDeComprobantesPreviosExcluidos , verHTMLParameter );

				else

					_data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesWF( this._tiposComprobantesPreviosOrigen , this._tiposComprobantesPreviosDestino, null,_fechaDesde, _fechaHasta,  null, Security.IdSucursal, Security.IdEmpresa,_tiposDeComprobantesPreviosExcluidos , verHTMLParameter );

			}

			if(_data != null)
			{
				if (_data.Tables.Count>0)
				{
					_dataComprobantesPrevios = _data.Tables[0];
				}
				if(_requiereBuscarPendientes)
				{
					if(_porFechaVencimiento)
                        //German 20120413 - Tarea 0000247
						_data =	mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesEntregasWF( this._tiposComprobantesPendientesOrigen  , this._tiposComprobantesPendientesDestino, _idCuenta, _fechaDesde, _fechaHasta,  null, Security.IdSucursal, Security.IdEmpresa, _tiposDeComprobantesExcluidos, verHTMLParameter);
                    //German 20120413 - Tarea 0000247
					else
                        //German 20120413 - Tarea 0000247
                        _data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesWF(this._tiposComprobantesPendientesOrigen, this._tiposComprobantesPendientesDestino, _idCuenta, _fechaDesde, _fechaHasta, null, Security.IdSucursal, Security.IdEmpresa, _tiposDeComprobantesExcluidos, verHTMLParameter);
                    //German 20120413 - Tarea 0000247
				}
				else
				{
					if(_porFechaVencimiento)
                        //German 20120413 - Tarea 0000247
                        _data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesEntregasWF(this._tiposComprobantesPendientesOrigen, this._tiposComprobantesPendientesDestino, _idCuenta, _fechaDesde, _fechaHasta, null, Security.IdSucursal, Security.IdEmpresa, _tiposDeComprobantesPreviosExcluidos, verHTMLParameter);
                    //German 20120413 - Tarea 0000247
					else
                        //German 20120413 - Tarea 0000247
                        _data = mz.erp.businessrules.reportes.ReportsFactory.ComprobantesWF(this._tiposComprobantesPendientesOrigen, this._tiposComprobantesPendientesDestino, _idCuenta, _fechaDesde, _fechaHasta, null, Security.IdSucursal, Security.IdEmpresa, _tiposDeComprobantesPreviosExcluidos, verHTMLParameter);
                    //German 20120413 - Tarea 0000247
				}
				if (_data.Tables.Count>0)
				{
					_dataOrdenesPendientes =  _data.Tables[0];
				}
				if (this.ObjectHasChanged != null)
				{
					this.ObjectHasChanged(this,null);
				}
			}

		}

		

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}


		public bool IsValid()
		{
			bool IsValid = true;
			_errors.Clear();
			if(_opIdComprobante == null || _opIdComprobante.Equals(string.Empty))
			{
				IsValid = false;
				_errors.Add( new ItemDatasetError( "Comprobante de Entrega","Comprobante de Entrega","Debe seleccionar un Comprobante de Entrega"));
			}
			return IsValid;
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.AllowShow
			return false;
		}
		
		public void FormHasClosed() 
		{
		}
		ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		public ItemsDatasetErrors GetErrors()
		{
			return _errors;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}
		private ProcessManager _processParent;
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent=processManager;
		}
		private string _taskName = string.Empty;
		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if (this.OnTaskBeforeExecute != null)
				this.OnTaskBeforeExecute( this, null );
			this.IsValid();
			if (this.OnTaskAfterExecute != null)
				this.OnTaskAfterExecute( this, null );
			
		}

		public bool AllowPrevious()
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.Previous
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación ComprobantesPendientesConsolaEntregas.ListenerBeforePreviousDependentTask
		}

		/// <summary>
		/// Devuelve una lista de los comprobantes previos definidos.
		/// La tabla de Tareas-Tipos De Comprboantes define todos los id de los tipos de comprobantes para la tarea determinada
		/// En caso de que para una tarea exista más un tipo de comprobante definido, se consulta en la variable
		/// Momentos.xx.RelacionComprobantesPrevios para filtrar solamente aquellos que estan definidos para el proceso.
		/// </summary>
		/// <returns></returns>
		private ArrayList GetTiposDeComprobantesOrigen(string taskNameToEvaluate, string processNameToEvaluate)
		{
			ArrayList aComprobantesDeLaTarea = new ArrayList();
			
			System.Data.DataSet dataPreviousTasks = Workflow.GetPreviousTasksOfProcess(Workflow.GetIdTakByName(taskNameToEvaluate),Workflow.GetIdProcessByName(processNameToEvaluate));
			if(dataPreviousTasks.Tables.Count > 0)
			{
				if(dataPreviousTasks.Tables[0].Rows.Count > 0)
				{	
					foreach(System.Data.DataRow row in dataPreviousTasks.Tables[0].Rows)
					{
						long idPreviousTask =  Convert.ToInt32(row[0]);
						System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(idPreviousTask);
						foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
						{
							string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
							aComprobantesDeLaTarea.Add(IdTipoComprobante);
						}
					}
				}
			}

			ArrayList result = new ArrayList();
	
			string relacionComprobantesPrevios = Variables.GetValueString( processNameToEvaluate, taskNameToEvaluate, "RelacionComprobantesPrevios" );
			string[] arelacionComprobantesPrevios = relacionComprobantesPrevios.Split( ',');
			if (arelacionComprobantesPrevios.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
				{
					string[] atupla = arelacionComprobantesPrevios[i].Split(':');
					if (atupla.Length == 2)
					{
						hash.Add( atupla[0],atupla[1]);
					}
				}
				foreach (string tipo in aComprobantesDeLaTarea)
				{
					if (hash.ContainsKey( tipo ))
					{
						result.Add( tipo );
					}
				}
				return result;
			}
			else
			{
				return result;
			}
			
			
		}

		private ArrayList GetTiposDeComprobantesDestinos(string taskNameToEvaluate)
		{
			ArrayList result = new ArrayList();
			System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(Workflow.GetIdTakByName(taskNameToEvaluate));
			foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
			{
				string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
				result.Add(IdTipoComprobante);


			}
			return result;
		}
		public string TextoBotonPrevio
		{
			get 
			{
				return Variables.GetValueString("Momentos."+this._taskName+"."+this._processParent.Process.ProcessName+".TextoBotonPrevio");
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return Variables.GetValueString("Momentos."+this._taskName+"."+this._processParent.Process.ProcessName+".TextoBotonSiguiente");
			}
		}
		#endregion
	}
}
