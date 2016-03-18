using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarControlCajas.
	/// </summary>
	public class ConsultarControlCajas: ITask, IPersistentTask
	{
		#region Constructores
		public ConsultarControlCajas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private bool _permiteCajaOtrosUsuarios=false;
		private bool _permiteConsultarHistorico = true;
		private ArrayList _idAuditoriasConsulta = new ArrayList();
		private ArrayList _idAuditoriasAuditadasSupervisor = new ArrayList();
		private ArrayList _idAuditoriasAuditadasGerente = new ArrayList();
		private tfi_AuditoriaControlCajasDataset _data = new tfi_AuditoriaControlCajasDataset();
		#endregion

		#region Eventos
		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;
		#endregion

		#region Variables Públicas

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		public bool PermiteConsultarHistorico
		{
			get { return _permiteConsultarHistorico; }
			set 
			{ 
				_permiteConsultarHistorico = value ;
			}
		}

		private bool _checkSoloAbiertas = true;
		public bool CheckSoloAbiertas
		{
			get { return _checkSoloAbiertas; }
			set 
			{ 
				_checkSoloAbiertas = value ;
			}
		}

		private bool _checkSoloCerradas = false;
		public bool CheckSoloCerradas
		{
			get { return _checkSoloCerradas; }
			set 
			{ 
				_checkSoloCerradas = value ;
			}
		}

		private bool _checkTodas = false;
		public bool CheckTodas
		{
			get { return _checkTodas; }
			set 
			{ 
				_checkTodas = value ;
			}
		}
		
		private ArrayList _filtroCajas;
		public ArrayList FiltroCajas
		{
			get { return _filtroCajas ; }
			set { _filtroCajas = value ; }
		}
	
		private DateTime _fechaApertura = mz.erp.systemframework.Util.GetStartDay(mz.erp.businessrules.Sistema.DateTime.Now);
		public DateTime FechaApertura
		{
			get {return _fechaApertura; }
			set 
			{
				_fechaApertura = mz.erp.systemframework.Util.GetStartDay(value);
				if (FechaAperturaChanged!=null)
				{
					FechaAperturaChanged(this, new System.EventArgs() );
				}
			}
		}

		private DateTime _fechaCierre = mz.erp.systemframework.Util.GetEndDay(mz.erp.businessrules.Sistema.DateTime.Now);
		public DateTime FechaCierre
		{
			get {return _fechaCierre ; }
			set 
			{
				_fechaCierre = mz.erp.systemframework.Util.GetEndDay(value) ; 
				if (FechaCierreChanged!= null)
				{
					FechaCierreChanged( this, new System.EventArgs() );
				}
			}
		}

		private string _idCajas = string.Empty;
		public string IdCajas
		{
			get { return _idCajas ;}
		}

		private DataTable _result = new DataTable();
		public DataTable Result
		{
			get{return _result;}
		}

		private bool _habilitaAuditadoSupervisor = false;
		public bool HabilitaAuditadoSupervisor
		{
			get{return _habilitaAuditadoSupervisor;}
		}

		private bool _habilitaAuditadoGerente = false;
		public bool HabilitaAuditadoGerente
		{
			get{return _habilitaAuditadoGerente;}
		}
		#endregion

		#region Métodos Privados

		private void build_Parameters()
		{

			_filtroCajas = build_ArrayCajas( loadCajasAConsultar() );
		}
	
		
		private ArrayList loadCajasAConsultar()
		{
			return mz.erp.businessrules.tfi_InstanciasCaja.GetListParaConsultaValores(Security.IdPersona,_permiteCajaOtrosUsuarios);
		}

		private ArrayList build_ArrayCajas(ArrayList _rango)
		{
			ArrayList _arrayCajas = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetListHashTable();
			foreach( string _idCaja in _rango )
			{
				if (_hash.ContainsKey( Convert.ToString( _idCaja ) ))
				{
					_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), true) );
				}
			}
			return _arrayCajas;
		}

		#endregion
		
		#region Métodos Públicos
		public void RefreshData()
		{
			_idCajas = string.Empty;
			
			#region refresh filtro cajas
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroCajas )
			{
				if (items.Sel)
				{
					_idCajas+= items.Id +',';
				}
			}
			if (_idCajas.Equals(string.Empty))
			{
				_idCajas = null;
			}
			#endregion

			if (_checkSoloAbiertas)
				_result = tfi_AuditoriaControlCajasEx.GetAuditoriaCajasAbiertas(_idCajas).Tables[0];
			else 
			{
				if (_checkSoloCerradas)
					_result = tfi_AuditoriaControlCajasEx.GetAuditoriaCajasCerradas(_idCajas, _fechaApertura, _fechaCierre).Tables[0];
				else // esta tildado que llame a todas
					_result = tfi_AuditoriaControlCajasEx.GetAuditoriaCajasAbiertasYCerradas(_idCajas, _fechaApertura, _fechaCierre).Tables[0];
			}

			DataColumn columnaTiempo =new DataColumn("TiempoEnHorario");
            columnaTiempo.DataType =typeof (TimeSpan); 
			_result.Columns.Add(columnaTiempo);
			foreach(DataRow row in _result.Rows)
			{
				long tiempoEnSegundos = Convert.ToInt64(row["Tiempo"]);
				TimeSpan tiempo = TimeSpan.FromSeconds(Convert.ToDouble(tiempoEnSegundos));
				row["TiempoEnHorario"] = tiempo;
			}

			/*if (this.ObjectHasChanged != null)
			{
				this.ObjectHasChanged(this, new System.EventArgs() );
			}*/
		}

        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaApertura = fecha; }
            else { this._fechaCierre = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaCierre < fecha)
                {
                    _fechaCierre = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaApertura > fecha)
                {
                    _fechaApertura = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

        }
        //Fin Cristian 20110725
        //Fin Cristian	
		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;			
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{			
			
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{			
			_processParent.GetParameters(this, _taskName);
			_permiteCajaOtrosUsuarios = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "PermiteCajaOtrosUsuarios","ConsultaValores.PermiteCajaOtrosUsuarios");
			_permiteConsultarHistorico = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "PermiteConsultarHistorico",_permiteConsultarHistorico);
			this.build_Parameters();
			_habilitaAuditadoSupervisor = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "HabilitaAuditadoSupervisor",_habilitaAuditadoSupervisor);
			_habilitaAuditadoGerente = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "HabilitaAuditadoGerente",_habilitaAuditadoGerente);
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
			_errores.Clear();
			bool isvalid = true;
			if(_habilitaAuditadoSupervisor || _habilitaAuditadoGerente)
			{
				_idAuditoriasConsulta = new ArrayList();
				_idAuditoriasAuditadasSupervisor = new ArrayList();
				_idAuditoriasAuditadasGerente = new ArrayList();

				Hashtable audiroriasAuditadasSupervisor = new Hashtable();
				Hashtable audiroriasAuditadasGerente = new Hashtable();
				foreach(DataRow row in _result.Rows)
				{
					long IdAuditoria = (long)row["IdAuditoria"];
					bool AuditadoSupervisor = (bool)row["AuditadoSupervisor"];
					bool AuditadoGerente = (bool)row["AuditadoGerente"];
					if(!audiroriasAuditadasSupervisor.ContainsKey(IdAuditoria))
						audiroriasAuditadasSupervisor.Add(IdAuditoria, new ArrayList());
					ArrayList auditadosS = (ArrayList)audiroriasAuditadasSupervisor[IdAuditoria];
					auditadosS.Add(AuditadoSupervisor);

					if(!audiroriasAuditadasGerente.ContainsKey(IdAuditoria))
						audiroriasAuditadasGerente.Add(IdAuditoria, new ArrayList());
					ArrayList auditadosG = (ArrayList)audiroriasAuditadasGerente[IdAuditoria];
					auditadosG.Add(AuditadoGerente);

					if(!_idAuditoriasConsulta.Contains(IdAuditoria))
						_idAuditoriasConsulta.Add(IdAuditoria);
				}
				foreach(long IdAuditoria in audiroriasAuditadasSupervisor.Keys)
				{
					ArrayList auditadosS = (ArrayList)audiroriasAuditadasSupervisor[IdAuditoria];
					bool okSupervisor = true;
					bool valor = (bool)auditadosS[0];
					int i = 1;
					while(okSupervisor && i < auditadosS.Count)
					{
						okSupervisor = valor == (bool)auditadosS[i];
						i++;
					}
					if(!okSupervisor)
						_errores.Add( new ItemDatasetError( "Auditoria Supervisor","Auditado Supervisor","Debe auditar todos los campos de la auditoria " + IdAuditoria + " o ninguno de ellos" ));
					else if(valor)
						_idAuditoriasAuditadasSupervisor.Add(IdAuditoria);                   
				}

				foreach(long IdAuditoria in audiroriasAuditadasGerente.Keys)
				{
					ArrayList auditadosG = (ArrayList)audiroriasAuditadasGerente[IdAuditoria];
					bool okGerente = true;
					bool valor = (bool)auditadosG[0];
					int i = 1;
					while(okGerente && i < auditadosG.Count)
					{
						okGerente = valor == (bool)auditadosG[i];
						i++;
					}
					if(!okGerente)
						_errores.Add( new ItemDatasetError( "Auditoria Gerente","Auditado Gerente","Debe auditar todos los campos de la auditoria " + IdAuditoria + " o ninguno de ellos" ));
					else if(valor)
						_idAuditoriasAuditadasGerente.Add(IdAuditoria);                   
				}
			}
			return _errores.Count == 0;
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
			return string.Empty;
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
			return this._taskName;
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

			if(ObjectHasChanged != null)
				ObjectHasChanged(this,new EventArgs());

		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{
			foreach(long IdAuditoria in _idAuditoriasConsulta)
			{
				tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row = tfi_AuditoriaControlCajas.GetByPk(IdAuditoria);
				row.AuditadoSupervisor = _idAuditoriasAuditadasSupervisor.Contains(IdAuditoria);
				row.AuditadoGerente = _idAuditoriasAuditadasGerente.Contains(IdAuditoria);
				_data.tfi_AuditoriaControlCajas.ImportRow(row);
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
			replication.NombreTabla = "dataaccess.tsa_CuentasObservacionesTipos";			
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
			//data.Add(_data);
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

			dataaccess.tfi_AuditoriaControlCajas.Update(_data.tfi_AuditoriaControlCajas, trx, _replication);

				
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
			
		}
		
		#endregion

	}
}

