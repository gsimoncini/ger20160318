using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
//using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmCostosIndirectos.
	/// </summary>
	public class AbmCostosIndirectos : ITask, IPersistentTask
	{
		public AbmCostosIndirectos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas
		private tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow _coeficienteCostoIndirectoRow = null;
		private tsh_CoeficientesCostosIndirectosDataset _data = new tsh_CoeficientesCostosIndirectosDataset();		
		private DataTable _costosIndirectosDataTable = new DataTable();
		#endregion

		#region Metodos Privados
		private void ValidarDatos()
		{	
			_errores.Clear();
		}

		#endregion

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;
		
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{

		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual void Init()
		{
			// TODO: agregar inicializacion
			_monedas = (DataTable) tfi_Monedas.GetList().tfi_Monedas;
			_fuentesDeCambio = (DataTable) tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			_costosIndirectosDataTable = mz.erp.businessrules.tsh_CoeficientesCostosIndirectos.GetListEx().Tables[0];
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			// -matias
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			// -------
			return true;
		}

		public virtual bool IsValid()
		{
			_errores.Clear();
			
			foreach( DataRow row in _costosIndirectosDataTable.Rows )
			{
				string descripcion = Convert.ToString(row["Descripcion"]);
				bool tipo = Convert.ToBoolean(row["Tipo"]);
				string idMoneda = Convert.ToString(row["IdMoneda"]); //str
				string idFuenteDeCambio = Convert.ToString(row["IdFuenteDeCambio"]); //str
				string idMonedaRef = Variables.GetValueString("Contabilidad.MonedaReferencia");
				string idFuenteDeCambioRef = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
				if ( (tipo) && (idMoneda == idMonedaRef) && (idFuenteDeCambio != idFuenteDeCambioRef) )
				{
					_errores.Add( new ItemDatasetError( "Costos Indirectos", descripcion,"Fuente de Cambio inválida para la Moneda seleccionada.") );
				}
				if ( (tipo) && ((idMoneda.Equals(string.Empty)) | (idFuenteDeCambio.Equals(string.Empty))) )
				{
					_errores.Add( new ItemDatasetError( "Costos Indirectos", descripcion,"Moneda y/o Fuente de Cambio inválida.") );
				}
			}

			if ( _errores.Count > 0 )
				return false;
			else 
				return true;
		}

		public virtual bool AllowShow() 
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

		public virtual string GetWarnings()
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
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public virtual void Previous()
		{
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{			
			foreach( DataRow row in _costosIndirectosDataTable.Rows )
			{
				tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow rowCCI = dataaccess.tsh_CoeficientesCostosIndirectos.GetByPk( Convert.ToString(row["IdCoeficienteCostoIndirecto"]) );
                rowCCI.Descripcion = Convert.ToString(row["Descripcion"]);
				rowCCI.Valor = Convert.ToDecimal(row["Valor"]); //long
				rowCCI.Tipo =  Convert.ToBoolean(row["Tipo"]); //bit
				rowCCI.IdMoneda = Convert.ToString(row["IdMoneda"]); //str
				rowCCI.IdFuenteDeCambio = Convert.ToString(row["IdFuenteDeCambio"]); //str
				/*if ( rowCCI.Tipo )
				{
					rowCCI.IdMoneda = Convert.ToString(row["IdMoneda"]); //str
					rowCCI.IdFuenteDeCambio = Convert.ToString(row["IdFuenteDeCambio"]); //str
				}
				else
				{
					rowCCI.IdMoneda = string.Empty;
					rowCCI.IdFuenteDeCambio = string.Empty;
				}*/
				rowCCI.Activo = Convert.ToBoolean(row["Activo"]); //bit
				_data.tsh_CoeficientesCostosIndirectos.ImportRow(rowCCI);
			}
			CostosIndirectosLoader.Reset();
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

			dataaccess.tsh_CoeficientesCostosIndirectos.Update(_data.tsh_CoeficientesCostosIndirectos, trx);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		

		#region Propiedades

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

		/*private DataTable _tipo = null;
		public DataTable Tipo
		{
			get
			{
				return _tipo;
			}
		}*/

		private string _idCoeficienteCostoIndirecto = null;
		public string IdCoeficienteCostoIndirecto
		{
			get{return _idCoeficienteCostoIndirecto;}
			set{
				if ( value != null )
				{
					//this._coeficienteCostoIndirectoRow = mz.erp.businessrules.tsh_CoeficientesCostosIndirectos.GetByPk( value );
				}
			}
		}

		private string _descripcion = null;
		public string Descripcion
		{
			get{return this._coeficienteCostoIndirectoRow.Descripcion;}
			set{_descripcion = value;}
		}
		
		private bool _tipo = false;
		public bool Tipo
		{
			get{return _tipo;}
			set{_tipo = value;}
		}
		
		private bool _porcentaje = false;
		public bool Porcentaje
		{
			get{return _porcentaje;}
			set{_porcentaje = value;}
		}

		public bool Moneda
		{
			get{return !_porcentaje;}
			set{_porcentaje = !value;}
		}

		private decimal _valor;
		public decimal Valor
		{
			get{return _valor;}
			set{_valor = value;}
		}

		private string _idMoneda = Variables.GetValueString("Contabilidad.MonedaExtranjeraReferencia");
		public string IdMoneda
		{
			get {return _idMoneda;}
			set {_idMoneda = value;}
		}

		private string _idFuenteDeCambio = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
		public string IdFuenteDeCambio
		{
			get {return _idFuenteDeCambio;}
			set {_idFuenteDeCambio = value;}
		}

		private long _orden = 0;
		public long Orden
		{
			get {return _orden;}
			set {_orden = value;}
		}

		private bool _activo = false;
		public bool Activo
		{
			get{return _activo;}
			set{_activo = value;}
		}
		
		public DataTable CostosIndirectosDataTable
		{
			get{return _costosIndirectosDataTable;}
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

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		#endregion

	}
}
