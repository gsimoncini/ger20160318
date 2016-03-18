using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using ParaisoFiscal;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de FiscalCierre.
	/// </summary>
	public class FiscalCierre: ITask, IPersistentTask
	{
		public FiscalCierre()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public event System.EventHandler OnCloseFiscal;

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

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
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				string asdf = "";
				//ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				//LoadDataFromComprobanteDeVenta( _comprobante );
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			if (!(_impresionExitosa))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Impresora Fiscal","Cierre","Ha ocurrido un error al intentar imprimir el cierre"));
			}
			return IsValid;
		}
		public bool AllowShow() 
		{
			return _allowShow;
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
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
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


			if (_allowShow) 
			{
				this.PrinterFiscal();
				this.IsValid();
			}						

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion
		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{				
			if(_allowSave)
			{
				tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row = businessrules.tsa_CierresFiscales.NewRow();
			
				ReporteFiscal reporte = _iFiscal.ReporteFiscal;			
				Console.WriteLine(reporte.NroReporte);				
				row.Fecha = reporte.Fecha;
				row.Sucursal = reporte.Sucursal;			
				row.Tipo = _tipo.ToString();
				row.Numero = reporte.NroReporte;
				row.Comprobantes_Neto = reporte.MontoVentas - reporte.MontoIVA - reporte.MontoIVANi - reporte.MontoPercep;
				row.Comprobantes_IVA = reporte.MontoIVA;			
				row.Comprobantes_II = reporte.MontoII;
				row.Comprobantes_NoGravados = reporte.MontoIVANi;
				row.Comprobantes_Percepciones = reporte.MontoPercep;
				row.Comprobantes_Emitidos = Convert.ToInt32(reporte.NroEmitidosDF);
				row.Comprobantes_Cancelados = Convert.ToInt32(reporte.NroCanceladosDF);
				row.NC_Neto = reporte.MontoNC - reporte.MontoIVANC - reporte.MontoIVANiNC;
				row.NC_IVA = reporte.MontoIVANC;			
				row.NC_II = reporte.MontoIINC;			
				row.NC_NoGravados = reporte.MontoIVANi;
				row.NC_Percepciones = reporte.MontoPercepNC;
				row.NC_Emitidos = 0;
				row.NC_Cancelados = 0;
				row.UltimoComprobanteA = Convert.ToInt32(reporte.UltA);
				row.UltimoComprobanteB = Convert.ToInt32(reporte.UltB);
				row.UltimaNCA = Convert.ToInt32(reporte.UltNCA);
				row.UltimaNCB = Convert.ToInt32(reporte.UltNCB);
				row.UltimoRemito = Convert.ToInt32(reporte.UltRemito);
				row.Remitos_Emitidos = 0;
				row.DocumentosNF_Emitidos = Convert.ToInt32(reporte.NroEmitidosDNF);
				row.DocumentosNFH_Emitidos = Convert.ToInt32(reporte.NroEmitidosDNFH);
				row.IdResponsable = Security.IdPersona;;
				row.Observacion	= "";
				_data.tsa_CierresFiscales.LoadDataRow( ((DataRow) row).ItemArray, false);
			}
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_CierresFiscales";	
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();			
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			if (_allowSave) 
			{
				_replication = GenerateReplication();
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				businessrules.tsa_CierresFiscales.Update(_data, trx, _replication);			
			}

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region Variables privadas
		private string _taskName = string.Empty;
		private bool _impresionExitosa = false;
		private char _tipo;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		private tsa_CierresFiscalesDataset _data = new tsa_CierresFiscalesDataset();
		private InterfaceFiscal _iFiscal;
		private bool _allowShow = Variables.GetValueBool("Fiscal.Activo");	
		private bool _allowSave = false;
	
		#endregion		

		private void PrinterFiscal()
		{
			_iFiscal = new InterfaceFiscal(this._processParent, this._taskName);
			_iFiscal.OnChangeEstadoFiscal += new EventHandler(this.ListenerChangesInterfaceFiscal);

			switch (_taskName)
			{
				case "EmitirCierreX": _tipo = 'X';					
					break;
				case "EmitirCierreZ": _tipo = 'Z';					
					break;
			}	

			
			_impresionExitosa = _iFiscal.Cierre(_tipo);			
			
			if (_impresionExitosa) 
			{
				ReporteFiscal reporte = _iFiscal.ReporteFiscal;			
				Console.WriteLine(reporte.NroReporte);			
				_allowSave = true;				
			}			
		}

		private string _mensaje = "";
		public string Mensaje 
		{
			get {return _mensaje;	}
		}
		
		private bool _cierreAutomatico = true;//Variables.GetValueBool("Fiscal.CierreAutomatico");		
		public bool CierreAutomatico
		{
			get {return _cierreAutomatico;}			
		}

        /* Silvina 20111025 - Tarea 0000221 */
        public bool EFacturaHabilitada
        {
            get { return false; }
        }

        private bool _eFacturaGenerar = false;
        public bool EFacturaGenerar
        {
            set { _eFacturaGenerar = value; }
            get { return false; }
        }
        /* Fin Silvina 20111025 - Tarea 0000221 */

		private void ListenerChangesInterfaceFiscal( object sender, System.EventArgs e )
		{
			_mensaje = _iFiscal.Mensaje;
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

	}
}


