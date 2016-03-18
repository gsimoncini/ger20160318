using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarRetencionesProveedores.
	/// </summary>
	public class ConsultarRetencionesProveedores : ITask
	{
		#region Constructores

		public ConsultarRetencionesProveedores()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}




		public void Init()
		{			
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			_tiposDeRetenciones = mz.erp.businessrules.tsy_TiposDeRetenciones.GetList().Tables[0];
			_allowShowDetail = Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "VisualizaDetalleComprobantes");
			_showDetailBy = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "MetodoVisualizacionDetalle");			

			_allowGeneralSearch = Variables.GetValueBool(processManager.Process.ProcessName, this._taskName, "AllowGeneralSearch");

			_fechaFacturaDesde = DateTime.Now.AddDays(-365);
			_fechaFacturaHasta = DateTime.Now.AddDays(365);

			_fechaReciboDesde = DateTime.Now.AddDays(-365);
			_fechaReciboHasta = DateTime.Now.AddDays(365);

			_fechaRetencionDesde = DateTime.Now.AddDays(-365);
			_fechaRetencionHasta = DateTime.Now.AddDays(365);

			_filterByFechaRetencion = _allowGeneralSearch;
			_filterByFechaRecibo = _allowGeneralSearch;
			_filterByFechaFactura = _allowGeneralSearch;

		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			return IsValid;
		}

		public bool AllowShow() 
		{
			return true;
		}
		
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public string GetWarnings()
		{		
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}

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
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region Variables privadas
		private DataTable _tiposDeRetenciones;
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processManager;	

		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;

		private bool _allowShowDetail = false;
		private string _showDetailBy = string.Empty;

		#endregion

		#region Propiedades

		private DataTable _result = new DataTable();	
		public DataTable Result
		{
			get{return _result;}
		}

		private string _numeroRetencion = String.Empty;
		public string NumeroRetencion
		{
			get{return _numeroRetencion;}
			set
			{				 
				if(_numeroRetencion != value)
				{
					_numeroRetencion = value;						
				}
			}
		}

		private DateTime _fechaRetencionDesde;
		public DateTime FechaRetencionDesde
		{
			get{return _fechaRetencionDesde;}
			set
			{				 
				if(_fechaRetencionDesde != value)
				{
					_fechaRetencionDesde = value;						
				}
			}
		}

		private DateTime _fechaRetencionHasta;
		public DateTime FechaRetencionHasta
		{
			get{return _fechaRetencionHasta;}
			set
			{				 
				if(_fechaRetencionHasta != value)
				{
					_fechaRetencionHasta = value;						
				}
			}
		}

		private string _idTipoDeRetencion = String.Empty;
		public string IdTipoDeRetencion
		{
			get{return _idTipoDeRetencion;}
			set
			{				 
				if(_idTipoDeRetencion != value)
				{
					_idTipoDeRetencion = value;						
				}
			}
		}

		private string _numeroRecibo = String.Empty;
		public string NumeroRecibo
		{
			get{return _numeroRecibo;}
			set
			{				 
				if(_numeroRecibo != value)
				{
					_numeroRecibo = value;						
				}
			}
		}
		
		private DateTime _fechaReciboDesde;
		public DateTime FechaReciboDesde
		{
			get{return _fechaReciboDesde;}
			set
			{				 
				if(_fechaReciboDesde != value)
				{
					_fechaReciboDesde = value;						
				}
			}
		}
		
		private DateTime _fechaReciboHasta;
		public DateTime FechaReciboHasta
		{
			get{return _fechaReciboHasta;}
			set
			{				 
				if(_fechaReciboHasta != value)
				{
					_fechaReciboHasta = value;						
				}
			}
		}

		private string _numeroFactura = String.Empty;
		public string NumeroFactura
		{
			get{return _numeroFactura;}
			set
			{				 
				if(_numeroFactura != value)
				{
					_numeroFactura = value;						
				}
			}
		}
		
		private DateTime _fechaFacturaDesde;
		public DateTime FechaFacturaDesde
		{
			get{return _fechaFacturaDesde;}
			set
			{				 
				if(_fechaFacturaDesde != value)
				{
					_fechaFacturaDesde = value;						
				}
			}
		}		

		private DateTime _fechaFacturaHasta;
		public DateTime FechaFacturaHasta
		{
			get{return _fechaFacturaHasta;}
			set
			{				 
				if(_fechaFacturaHasta != value)
				{
					_fechaFacturaHasta = value;						
				}
			}
		}
		
		public System.Data.DataTable TiposDeRetenciones
		{
			get {return _tiposDeRetenciones;}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonAnterior");
				if (valor == String.Empty)
				{
					 
					valor = Variables.GetValueString("Sistema.Interfaz.TextoBotonAnterior");				
				}
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(),"TextoBotonSiguiente");
				if (valor == String.Empty)
				{
					
					valor = Variables.GetValueString("Sistema.Interfaz.TextoBotonSiguiente");				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _leyendaFormulario = string.Empty;
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
				if (valor == String.Empty) 
				{
					return this._taskName;
				}
				else 
				{
					return valor;
				}
			}
		}
		
		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

		//------------- matias 15/09/08
		private bool _allowGeneralSearch = false;
		public bool AllowGeneralSearch 
		{
			get{return _allowGeneralSearch;}
		}

		private bool _filterByFechaRetencion = false;
		public bool FilterByFechaRetencion
		{
			get{return _filterByFechaRetencion;}
			set{_filterByFechaRetencion = value;}
		}

		private bool _filterByFechaRecibo = false;
		public bool FilterByFechaRecibo
		{
			get{return _filterByFechaRecibo;}
			set{_filterByFechaRecibo = value;}
		}
		
		private bool _filterByFechaFactura = false;
		public bool FilterByFechaFactura
		{
			get{return _filterByFechaFactura;}
			set{_filterByFechaFactura = value;}
		}
		//-------------

		#endregion

		#region Eventos

		#endregion

		#region Metodos Privados

		#endregion

		#region Metodos Publicos
        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000050 20110725
        public void updateFechas(DateTime fecha,string tipoFecha, bool ordenInverso )
        {
            long dias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");

            switch (tipoFecha)
            {
                 case "RECIBO":   if (!ordenInverso)
                                        { this._fechaReciboDesde = fecha; }
                                        else { this._fechaReciboHasta = fecha; };

                                        if (!ordenInverso)
                                        {
                                            if (this.FechaReciboHasta < fecha)
                                            {
                                                _fechaReciboHasta = Util.GenerateFechaHasta(fecha, dias);
                                            }
                                        }
                                        else
                                        {
                                            if (this.FechaReciboDesde > fecha)
                                            {
                                                _fechaReciboDesde = Util.GenerateFechaHasta(fecha, dias);
                                            }

                                        }//End ELSE

                                       break;
                 case "FACTURA":   if (!ordenInverso)
                                       { this._fechaFacturaDesde = fecha; }
                                       else { this._fechaFacturaHasta = fecha; };

                                       if (!ordenInverso)
                                       {
                                           if (this.FechaFacturaHasta < fecha)
                                           {
                                               _fechaFacturaHasta = Util.GenerateFechaHasta(fecha, dias);
                                           }
                                       }
                                       else
                                       {
                                           if (this.FechaFacturaDesde > fecha)
                                           {
                                               _fechaFacturaDesde = Util.GenerateFechaHasta(fecha, dias);
                                           }

                                       }//End ELSE

                                       break;


                default :
                                       if (!ordenInverso)
                                       { this._fechaRetencionDesde = fecha; }
                                       else { this._fechaRetencionHasta = fecha; };

                                       if (!ordenInverso)
                                       {
                                           if (this.FechaRetencionHasta < fecha)
                                           {
                                               _fechaRetencionHasta = Util.GenerateFechaHasta(fecha, dias);
                                           }
                                       }
                                       else
                                       {
                                           if (this.FechaRetencionDesde > fecha)
                                           {
                                               _fechaRetencionDesde = Util.GenerateFechaHasta(fecha, dias);
                                           }

                                       }//End ELSE

                                       break;
            }
            

        }
        //Fin cristian 20110725
        //Fin Cristian
		public void RefreshData()
		{

			//matias 15/09/08
			DateTime FechaRetencionDesde = _filterByFechaRetencion ? this.FechaRetencionDesde : DateTime.MinValue;
			DateTime FechaRetencionHasta = _filterByFechaRetencion ? this.FechaRetencionHasta : DateTime.MinValue;
			DateTime FechaReciboDesde = _filterByFechaRecibo ? this.FechaReciboDesde : DateTime.MinValue;
			DateTime FechaReciboHasta = _filterByFechaRecibo ? this.FechaReciboHasta : DateTime.MinValue;
			DateTime FechaFacturaDesde = _filterByFechaFactura ? this.FechaFacturaDesde : DateTime.MinValue;
			DateTime FechaFacturaHasta = _filterByFechaFactura ? this.FechaFacturaHasta : DateTime.MinValue;
			//--

            bool verHTML = false;
			if(this._allowShowDetail && this._showDetailBy.Equals("AUTOMATICO"))
				verHTML = true;
			System.Data.DataSet data = mz.erp.businessrules.reportes.ReportsFactory.ListarRetencionesProveedores( _numeroRetencion, FechaRetencionDesde, FechaRetencionHasta, _idTipoDeRetencion, _numeroRecibo, FechaReciboDesde, FechaReciboHasta, _numeroFactura,  FechaFacturaDesde, FechaFacturaHasta, Security.IdSucursal, Security.IdEmpresa, verHTML);
			_result = data.Tables[0];
		}

		#endregion


	}
}
