using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using System.Data.SqlClient;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ControlarCajas.
	/// </summary>
	public class ControlarCajas: ITask, IPersistentTask
	{
		#region Constructores
		public ControlarCajas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private AuditoriaControlCajas _auditoria;
		private string _idTDCompTesoreriaHabilitaTipoBillete = string.Empty;
		private ArrayList _idTDCompTesoreriaHabilitanTipoBillete = new ArrayList();
		private ArrayList _auditoriaControlCajasDetNoEncontrados = new ArrayList();
		private decimal _cantCorrecciones = 0;
		private decimal _cantCorreccionesPosibles;
		private tfi_AuditoriaControlCajasExDataset _data = new tfi_AuditoriaControlCajasExDataset();
		private decimal _diferenciaPermitidaMontoEfectivo = 0;
		#endregion

		#region Eventos
		public event System.EventHandler AuditoriaControlCajasDetViewHasChanged;
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
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

		public bool AllowEditCaja
		{
			get 
			{ 
				return _filtroCajas.Rows.Count > 1;
			}
		}
		
		private DataTable _filtroCajas = new DataTable();
		public DataTable FiltroCajas
		{
			get { return _filtroCajas ; }
			set { _filtroCajas = value ; }
		}

		private string _idCaja = string.Empty;
		public string IdCaja
		{
			get { return _idCaja; }
			set 
			{
				_idCaja = value ;
				if(_auditoria != null)
                    _auditoria.IdInstanciaCaja = _idCaja;
			}
		}

		private string _idControlDeCajasFamiliasComprobanteTesoreria = string.Empty;
		public string IdControlDeCajasFamiliasComprobanteTesoreria
		{
			get { return _idControlDeCajasFamiliasComprobanteTesoreria; }
			set {_idControlDeCajasFamiliasComprobanteTesoreria = value ;}
		}

		private string _tDCompTesoreria = string.Empty;
		public string TDCompTesoreria
		{
			get { return _tDCompTesoreria; }
			set {_tDCompTesoreria = value;}
		}

		private long _idTipoBillete;
		public long IdTipoBillete
		{
			get { return _idTipoBillete; }
			set 
			{
				_idTipoBillete = value;
				_valorBillete = (decimal)_valoresBilletes[IdTipoBillete];
			}
		}

		private string _tipoBillete = string.Empty;
		public string TipoBillete
		{
			get { return _tipoBillete; }
			set {_tipoBillete = value;}
		}

		private string _idMoneda = string.Empty;
		public string IdMoneda
		{
			get { return _idMoneda; }
			set {_idMoneda = value ;}
		}

		private string _moneda = string.Empty;
		public string Moneda
		{
			get { return _moneda; }
			set {_moneda = value ;}
		}

		private long _cantidadInformada = 0;
		public long CantidadInformada
		{
			get { return _cantidadInformada; }
			set {_cantidadInformada = value ;}
		}
		
		private decimal _montoInformado = 0;
		public decimal MontoInformado
		{
			get { return _montoInformado; }
			set {_montoInformado = value ;}
		}
		
		private ArrayList _auditoriaControlCajasDetView = new ArrayList();
		public ArrayList AuditoriaControlCajasDetView
		{
			get {return _auditoriaControlCajasDetView;}
		}

		private Hashtable _valoresBilletes = new Hashtable();
		public Hashtable ValoresBilletes
		{
			get {return _valoresBilletes;}
			set {_valoresBilletes = value;}
		}

		private decimal _valorBillete;
		public decimal ValorBillete
		{
			get { return _valorBillete; }
		}

		#endregion

		#region Métodos Privados
		private void SetCombosData()
		{
			_filtroCajas = tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0];
			if (_filtroCajas.Rows.Count > 0)
			{
				IdCaja = Convert.ToString(_filtroCajas.Rows[0]["IdInstanciaCaja"]);
			}
		}
        #endregion
		
		#region Métodos Públicos
		
		public bool HabilitaTipoBillete()
		{
			return _idTDCompTesoreriaHabilitanTipoBillete.Contains(_idControlDeCajasFamiliasComprobanteTesoreria);
		}


		public void AgregarItemAuditoria()
		{			
			if(HabilitaTipoBillete())
				_auditoria.AgregarItemAuditoria(IdControlDeCajasFamiliasComprobanteTesoreria, TDCompTesoreria, IdMoneda, Moneda, CantidadInformada, _valorBillete, IdTipoBillete, TipoBillete);
			else
				_auditoria.AgregarItemAuditoria(IdControlDeCajasFamiliasComprobanteTesoreria, TDCompTesoreria, IdMoneda, Moneda, CantidadInformada, MontoInformado);
			if(AuditoriaControlCajasDetViewHasChanged != null)
				AuditoriaControlCajasDetViewHasChanged(this, new EventArgs());	

		}

		public void EliminarItemAuditoria(AuditoriaControlCajasDetView item)
		{			
			if(item.UsaDetalleBilletes)
                _auditoria.EliminarItemAuditoria(item.AuditoriaControlCajasDet, item.AuditoriaControlCajasDetalleBilletes);
			else
				_auditoria.EliminarItemAuditoria(item.AuditoriaControlCajasDet);
			_auditoriaControlCajasDetView.Remove(item);
			if(AuditoriaControlCajasDetViewHasChanged != null)
				AuditoriaControlCajasDetViewHasChanged(this, new EventArgs());	

		}
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
			SetCombosData();
			_auditoria = new AuditoriaControlCajas(Security.IdPersona);
			_idTDCompTesoreriaHabilitaTipoBillete = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "IdTDCompTesoreriaHabilitaTipoBillete");
			_idTDCompTesoreriaHabilitanTipoBillete = mz.erp.systemframework.Util.Parse(_idTDCompTesoreriaHabilitaTipoBillete, ",");
			_auditoria.AuditoriaControlCajasDetAdded+=new mz.erp.businessrules.AuditoriaControlCajas.AuditoriaControlCajasDetEventHandler(_auditoria_AuditoriaControlCajasDetAdded);
			_auditoria.AuditoriaControlCajasDetalleBilletesAdded+=new mz.erp.businessrules.AuditoriaControlCajas.AuditoriaControlCajasDetEventHandler(_auditoria_AuditoriaControlCajasDetalleBilletesAdded);
			_auditoria.AuditoriaControlCajasDetalleBilletesModified+=new mz.erp.businessrules.AuditoriaControlCajas.AuditoriaControlCajasDetEventHandler(_auditoria_AuditoriaControlCajasDetalleBilletesModified);
			_cantCorreccionesPosibles = Variables.GetValueDecimal(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "CantidadMaximaDeDiferenciasPermitida");
			//Lo multiplico por dos pq llama dos veces al GetWarnings()
			_cantCorreccionesPosibles = _cantCorreccionesPosibles * 2;
			_diferenciaPermitidaMontoEfectivo = Variables.GetValueDecimal(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "DiferenciaPermitidaMontoEfectivo");
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
			return isvalid;
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
			string res = string.Empty;
			ArrayList idsEncontrados = new ArrayList();
			tfi_ValoresControlCajaDataset dataValoresCaja = tfi_Valores.GetValoresCaja(IdCaja);
			foreach(AuditoriaControlCajasDet det in _auditoria.Detalle)
			{
				tfi_ValoresControlCajaDataset.tfi_ValoresControlCajaRow row = dataValoresCaja.tfi_ValoresControlCaja.FindByIdControlDeCajasFamiliasComprobanteTesoreriaIdMoneda(det.IdControlDeCajasFamiliasComprobanteTesoreria, det.IdMoneda);
				if(row == null)
				{
					det.CantidadSistema = 0;
					det.MontoSistema = 0;
				}
				else
				{
					det.CantidadSistema = row.CantidadSistema;
					det.MontoSistema = row.MontoSistema;
				}
				det.DiferenciaMonto = Math.Abs(det.MontoSistema - det.MontoInformado);
				if(det.Detalle.Count == 0) //Si no es por efectivo
				{
					det.DiferenciaCantidad = Math.Abs(det.CantidadSistema - det.CantidadInformada);
					det.CodigoCalidadMonto = det.DiferenciaMonto != 0;
				}
				else //Si es efectivo no importa la cantidad en la comparacion y hay una diferencia permitida definida por la variable DiferenciaPermitidaMontoEfectivo
				{
					det.DiferenciaCantidad = 0;
					det.CodigoCalidadMonto = det.DiferenciaMonto > _diferenciaPermitidaMontoEfectivo;
				}
				det.CodigoCalidadCantidad = det.DiferenciaCantidad != 0;
				if(det.CodigoCalidadMonto || det.CodigoCalidadCantidad)
				{
					res = res + "Hubo diferencias de ";
					if(det.CodigoCalidadCantidad)
                        res = res + "cantidad ";
                    if(det.CodigoCalidadMonto)
						res = res + "monto ";
					res = res + "para el comprobante " + det.TDCompTesoreria + " con la moneda " + det.Moneda + " \n";
				}
				idsEncontrados.Add(det.IdControlDeCajasFamiliasComprobanteTesoreria + " - " + det.IdMoneda);
			}

			//Me fijo si alguna fila del sistema no fue agregada por el usuario
			_auditoriaControlCajasDetNoEncontrados = new ArrayList();
			int ordinal = _auditoria.Detalle.Count + 1;
			foreach(tfi_ValoresControlCajaDataset.tfi_ValoresControlCajaRow row in dataValoresCaja.tfi_ValoresControlCaja.Rows)
			{
				string id = row.IdControlDeCajasFamiliasComprobanteTesoreria + " - " + row.IdMoneda;
				if(!idsEncontrados.Contains(id))
				{
					tfi_MonedasDataset.tfi_MonedasRow rowM = tfi_Monedas.GetByPk(row.IdMoneda);
					tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow rowTD = tfi_ControlDeCajasFamiliasComprobanteTesoreria.GetByPk(row.IdControlDeCajasFamiliasComprobanteTesoreria);
					res = res + "No se han informado datos para el comprobante " + rowTD.Descripcion  + " con la moneda " + rowM.Descripcion + " existentes en el sistema \n";
					AuditoriaControlCajasDet det = new AuditoriaControlCajasDet(ordinal, row.IdControlDeCajasFamiliasComprobanteTesoreria, rowTD.Descripcion, row.IdMoneda, rowM.Descripcion);
					det.CantidadSistema = row.CantidadSistema;
					det.MontoSistema = row.MontoSistema;
					det.DiferenciaCantidad = Math.Abs(det.CantidadSistema - det.CantidadInformada);
					det.DiferenciaMonto = Math.Abs(det.MontoSistema - det.MontoInformado);
					det.CodigoCalidadCantidad = det.DiferenciaCantidad != 0;
					det.CodigoCalidadMonto = det.DiferenciaMonto != 0;
					_auditoriaControlCajasDetNoEncontrados.Add(det);
					ordinal++;
				}
			}
			if(!res.Equals(string.Empty)) 
			{
				res = res + " Desea continuar sin corregir los datos??";
				_cantCorrecciones++;

			}
			if(_cantCorrecciones > _cantCorreccionesPosibles)
				return string.Empty;
			else
                return res;
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
			_data = new tfi_AuditoriaControlCajasExDataset();
			_auditoria.IdInstanciaCaja = IdCaja;
			_auditoria.Detalle.AddRange(_auditoriaControlCajasDetNoEncontrados);
			_auditoria.Commit(_data);
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

			tfi_AuditoriaControlCajasEx.Update(_data, _replication);

				
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
			
		}
		
		#endregion

		private void _auditoria_AuditoriaControlCajasDetAdded(object sender, AuditoriaControlCajasDetEventArgs e)
		{
			AuditoriaControlCajasDetView det = new AuditoriaControlCajasDetView(e.AuditoriaControlCajasDet);
			_auditoriaControlCajasDetView.Add(det);
			
		}

		private void _auditoria_AuditoriaControlCajasDetalleBilletesAdded(object sender, AuditoriaControlCajasDetEventArgs e)
		{
			AuditoriaControlCajasDetView det = new AuditoriaControlCajasDetView(e.AuditoriaControlCajasDet, e.AuditoriaControlCajasDetalleBilletes);
			_auditoriaControlCajasDetView.Add(det);
		}

		private void _auditoria_AuditoriaControlCajasDetalleBilletesModified(object sender, AuditoriaControlCajasDetEventArgs e)
		{
			AuditoriaControlCajasDetView det = new AuditoriaControlCajasDetView(e.AuditoriaControlCajasDet, e.AuditoriaControlCajasDetalleBilletes);
			int index = _auditoriaControlCajasDetView.IndexOf(det);
			AuditoriaControlCajasDetView d = (AuditoriaControlCajasDetView)_auditoriaControlCajasDetView[index];
			d.CantidadInformada = e.AuditoriaControlCajasDetalleBilletes.CantidadInformada;
		}
	}
}
