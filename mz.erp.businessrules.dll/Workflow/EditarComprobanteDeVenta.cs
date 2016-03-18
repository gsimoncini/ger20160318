using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de EditarComprobanteDeVenta.
	/// </summary>
	public class EditarComprobanteDeVenta: ITask, IPersistentTask
	{
		#region Constructores
		
		
		public EditarComprobanteDeVenta()
		{
		}
		
		#endregion

		#region Variables Privadas

			private string _idComprobante = string.Empty;
			private string _idTipoDeComprobante = string.Empty;
			private string _numero = string.Empty;
			private string _numeroOriginal = string.Empty;
			private string _mascara = "#-####-########";
			private string _idCuenta = string.Empty;
			private businessrules.Cuenta _cuenta = new Cuenta();
			private string _codigoCuenta = string.Empty;
			private DateTime _fechaEmision = mz.erp.businessrules.Sistema.DateTime.Now;
			private string _observaciones = string.Empty;
			private string _idCondicionDeVenta = string.Empty;
			private string _idResponsable = string.Empty;




			private VariablesAuxiliares _variablesComprobante;

			protected string _taskName = string.Empty;		
			protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			protected ProcessManager _processParent;

			private DataTable _tableCondicionesDeVenta = new DataTable();


			private DataSet _dataComprobante = new tsa_ComprobantesDataset();
			private DataSet _dataVariablesAuxiliares = new tsa_ComprobanteValoresVarAuxDataset();
			private DataRow _rowComprobante = null;

		
			private mz.erp.commontypes.SentenciasReplicacion _replication = new mz.erp.commontypes.SentenciasReplicacion();
			




		
		#endregion
	
		#region variables Publicas

		

		

		
		public DataTable TableCondicionesDeVenta
		{
			get{return _tableCondicionesDeVenta;}
		}

		public ArrayList VariablesDeUsuario
		{
			get {return this._variablesComprobante.VariablesDeUsuario;}
		}

		public string Mascara 
		{
			get{return _mascara;}
		}

		
		public DateTime FechaEmision
		{
			get{return _fechaEmision;}
			set{_fechaEmision = value;}
		}

		public string IdResponsable
		{
			get{return _idResponsable;}
			set{_idResponsable = value;}
		}

		public string IdCondicionDeVenta
		{
			get{return _idCondicionDeVenta;}
			set{_idCondicionDeVenta = value;}
		}

		public string Observaciones
		{
			get{return _observaciones;}
			set{_observaciones = value;}
		}

		public string IdCuenta
		{
			get
			{
				return _cuenta.IdCuenta;
			}
			set
			{
				if(value != null && value != string.Empty)
				{
					if(!_cuenta.IdCuenta.Equals(value))
						_cuenta.GetCuenta_IdCuenta(value);
				}
				else
					_cuenta = new Cuenta();
			}
		}

		public string CodigoCuenta
		{
			get
			{
				return _cuenta.Codigo;
			}
			set
			{
				if(value != null && value != string.Empty)
				{
					if(!_cuenta.Codigo.Equals(value))
						_cuenta.GetCuenta_CodigoCuenta(value);
				}
				else
					_cuenta = new Cuenta();
			}
		}

				
		public string Numero
		{
			get{return _numero;}
			set{_numero = value;}
		}
		
		public string IdTipoDeComprobante
		{
			get{return _idTipoDeComprobante;}
			set{_idTipoDeComprobante = value;}
		}

		public string IdComprobante
		{
			get{return _idComprobante;}
			set{_idComprobante = value;}
		}


			

		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.ComprobantesPendientes ))
			{
				ComprobantesPendientes comprobantesPendientes = (ComprobantesPendientes)sender;
				ArrayList rel = comprobantesPendientes.ArrayIdComprobantesPendientes;
				LoadFromRelacionesComprobanteOrigenDestino(rel);
			}
		}

		private void LoadFromRelacionesComprobanteOrigenDestino(ArrayList rel)
		{
			string IdComprobante = Convert.ToString(rel[0]);
			_dataComprobante = new tsa_ComprobantesDataset();
			mz.erp.dataaccess.tsa_Comprobantes.GetByPk( _dataComprobante, IdComprobante);
			_rowComprobante = _dataComprobante.Tables[0].Rows[0];
			_idTipoDeComprobante = Convert.ToString(_rowComprobante["IdTipoDeComprobante"]);
			DataRow rowTipoComprobante = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(IdTipoDeComprobante);
			_mascara = Convert.ToString(rowTipoComprobante["Mascara"]);
			_numero = Convert.ToString(_rowComprobante["Numero"]);
			_numeroOriginal = Convert.ToString(_rowComprobante["Numero"]);
			_idResponsable = Convert.ToString(_rowComprobante["IdResponsable"]);
            string IdCuenta = Convert.ToString(_rowComprobante["IdCuenta"]);
			this._cuenta.GetCuenta_IdCuenta(IdCuenta);
			_idCondicionDeVenta = Convert.ToString(_rowComprobante["IdCondicionDeVenta"]);
			_observaciones = Convert.ToString(_rowComprobante["Observaciones"]);
			_fechaEmision = Convert.ToDateTime(_rowComprobante["Fecha"]);
			_variablesComprobante = new VariablesAuxiliares(IdComprobante, IdTipoDeComprobante);
			_tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(_idCuenta,_idTipoDeComprobante,_processParent.Process.ProcessName,GetTaskName(),IdResponsable);
			

		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public  void Init()
		{
			_tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetList(null, null).Tables[0];
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

		public  bool IsValid()
		{
			_errores.Clear();
			bool isvalid = true;
			if ((this._cuenta.IdCuenta == null) || (this._cuenta.IdCuenta == string.Empty))
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Cuenta","IdCuenta","El cliente/la cuenta no puede ser nulo"));
			}
			if ((this._idResponsable == null) || (this._idResponsable == string.Empty))
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Responsable","IdResponsable","El responsable de emisión no puede ser nulo"));
			}
			if (!(this.IsValidNumeration()))
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Numeración","La numeración del comprobante no es válida"));
			}
			if ((this.ExistsNumeration()))
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Numeración","El número del comprobante ya existe"));
			}
			return isvalid;	
		}

		private bool IsValidNumeration()
		{
			if ( _numero.EndsWith("-") || (_numero == string.Empty) || (_numero.Length!=15) ) 
			{
				return false;
			}
			return true;
		}

		private bool ExistsNumeration()
		{
			if( _numero != _numeroOriginal)
				return mz.erp.businessrules.tsa_Comprobantes.ExistsNumeration(this._numero, this._idTipoDeComprobante);
			return false;
			
		}


		public  bool AllowShow() 
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

		public  string GetWarnings()
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

		public  void Previous()
		{
			
		}

		public  void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public  void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}
		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( this._dataComprobante );
			return data;
		}

		public void Commit()
		{
			
			string idTipoDomicilio = ComprobantesRules.Momentos_Cuenta_Domicilio_Default(this._taskName);
			Domicilio dom = this._cuenta.GetDomicilio(idTipoDomicilio);
			
			
			_rowComprobante["IdTipoDeComprobante"] = _idTipoDeComprobante;
			_rowComprobante["Numero"] = _numero ;
			_rowComprobante["IdResponsable"] = _idResponsable;
			_rowComprobante["IdCuenta"] = this._cuenta.IdCuenta;
			_rowComprobante["IdCondicionDeVenta"] = _idCondicionDeVenta;
			_rowComprobante["Fecha"] = _fechaEmision;
			_rowComprobante["Observaciones"] = _observaciones ;
			_rowComprobante["Cliente"] = this._cuenta.Nombre;
			if(dom != null)
			{
				_rowComprobante["Domicilio"] = dom.DomicilioTexto;
			}
			else
			{
				_rowComprobante["Domicilio"] = this._cuenta.Domicilio;
			}
			_rowComprobante["TipoDocumento"] = this._cuenta.TipoDocumento;
			_rowComprobante["Documento"] = this._cuenta.Documento;
			_rowComprobante["Aux1"] = this._cuenta.CampoAuxiliar1;
			_rowComprobante["Aux2"] = this._cuenta.CampoAuxiliar2;
			_rowComprobante["Aux2"] = this._cuenta.CampoAuxiliar3;
			
			_dataVariablesAuxiliares =  _variablesComprobante.CommitEdit(_idComprobante);
			
			
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_replication = GenerateSentenciaReplicacion();
			mz.erp.dataaccess.tsa_Comprobantes.Update( _dataComprobante.Tables["tsa_Comprobantes"], IdTransaction, _replication);	
			mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.Update( _dataVariablesAuxiliares.Tables["tsa_ComprobanteValoresVarAux"], IdTransaction, _replication);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación EditarComprobanteDeVenta.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación EditarComprobanteDeVenta.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}

		private SentenciasReplicacion GenerateSentenciaReplicacion()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Comprobantes";
			return replication;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación EditarComprobanteDeVenta.GetHasSaved
			return false;
		}

		#endregion
	}
}
