using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmCotizacionMoneda
	/// </summary>
	public class AbmCotizacionMoneda: ITask, IPersistentTask
	{
		public AbmCotizacionMoneda()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		//public event System.EventHandler OnCloseFiscal;

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
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init
			_monedas = (DataTable) tfi_Monedas.GetList().tfi_Monedas;
			_fuentesDeCambio = (DataTable) tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			_cotizacionAnterior = _cotizacion;		
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
            /* Silvina 20110315 - Tarea 0000070 */
            _validaMonedaDestino = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "ValidaMonedaDestino", _validaMonedaDestino);
            /* Fin Silvina */
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
			IsValid = IsValidForStartProcess();
			_errores.Clear();

			long IdProceso = this._processParent.Process.IdProcess;
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			DataSet data = businessrules.twf_ProcesosTareasValidaciones.GetValidaciones(IdProceso, IdTarea); //Sobrecarga para workflow
			if (data != null)
			{
				foreach (DataRow row in data.Tables[0].Rows) 
				{
					string Condicion = Convert.ToString(row["Validacion"]);				
					string Titulo = Convert.ToString(row["Titulo"]);
					string Mensaje = Convert.ToString(row["Mensaje"]);

					if (Evaluator.EvaluateToBool(Condicion, this, false)) //Pasa false si la compilación da como resultado un error
					{
						IsValid = false;
						_errores.Add( new ItemDatasetError( Titulo,"Valor",Mensaje));

					}				
					//Titulo Mensaje TipoMensaje Botones
				}
			}
            /* Silvina 20110315 - Tarea 0000070 */
            string monedaRef = Variables.GetValueString("Contabilidad.MonedaReferencia");
            if (_validaMonedaDestino && (!IdMonedaDestino.Equals(monedaRef)))
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError("Valor", "Moneda Destino", "La Moneda Destino es distinta a la de referencia."));
            }
            if (IdMonedaDestino.Equals(IdMonedaOrigen))
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError("Valor", "Monedas", "La Moneda Origen es igual a la Moneda Destino."));
            }	
            /* Fin Silvina */

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
			return "Este Proceso provoca que se actualicen los precios de aquellos productos que contengan esta cotización. Desea Continuar?";			
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

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{			
			tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row = null;
			row = _data.tfi_CotizacionesMonedas.Newtfi_CotizacionesMonedasRow();
			row.IdCotizacionMoneda = systemframework.Util.NewStringId();
			row.IdMonedaOrigen = _idMonedaOrigen;
			row.IdMonedaDestino = _idMonedaDestino;
			row.FechaDeCambioInicio = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaDeCambioFin = DateTime.MinValue;
			row.IdFuenteDeCambio = _idFuenteDeCambio;
			row.Valor = _cotizacion;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = 1;
			row.IdReservado = 0;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			_data.tfi_CotizacionesMonedas.Addtfi_CotizacionesMonedasRow(row);
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
			replication.NombreTabla = "dataaccess.tfi_CotizacionesMonedas";			
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
			//array.Add( (DataSet) this.DatasetComprobante);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			data.Add( this._data);
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

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			dataaccess.tfi_CotizacionesMonedas.InsertWithValidation((DataTable) _data.tfi_CotizacionesMonedas, trx, _replication);			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private tfi_CotizacionesMonedasDataset _data = new tfi_CotizacionesMonedasDataset();

        /* Silvina 20110315 - Tarea 0000070 */
        private bool _validaMonedaDestino = true;
        /* Fin Silvina */

		#endregion

		#region Propiedades
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
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
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
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


		private DataTable _monedas = null;
		public DataTable Monedas
		{
			get
			{
				return _monedas;
			}
		}

		private DataTable _fuentesDeCambio = null;
		public DataTable FuentesDeCambio
		{
			get
			{
				return _fuentesDeCambio;
			}
		}		

		private string _idMonedaOrigen = Variables.GetValueString("Contabilidad.MonedaExtranjeraReferencia");
		public string IdMonedaOrigen
		{
			get {return _idMonedaOrigen;}
			set {_idMonedaOrigen = value;}
		}

		private string _idMonedaDestino = Variables.GetValueString("Contabilidad.MonedaReferencia");		
		public string IdMonedaDestino
		{
			get {return _idMonedaDestino;}
			set {_idMonedaDestino = value;}
		}

		private string _idFuenteDeCambio = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
		
		public string IdFuenteDeCambio
		{
			get {return _idFuenteDeCambio;}
			set {_idFuenteDeCambio = value;}
		}

		private decimal _cotizacion = tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto();
		public decimal Cotizacion
		{
			get {return _cotizacion;}
			set {_cotizacion = value;}
		}

		private decimal _cotizacionAnterior = 0;
		public decimal CotizacionAnterior 
		{
			get {return _cotizacionAnterior;}
		}


		#endregion


		private void ListenerChangesInterfaceFiscal( object sender, System.EventArgs e )
		{
			//_mensaje = _iFiscal.Mensaje;
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

	}
}


