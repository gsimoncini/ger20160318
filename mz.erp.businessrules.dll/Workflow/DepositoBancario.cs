using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using System.Data.SqlClient;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de DepositoBancario.
	/// </summary>
	public class DepositoBancario: ITask, IPersistentTask
	{
		public DepositoBancario()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables Privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private tfi_MovimientoBancarioDataset dataMovimientoBancario=new tfi_MovimientoBancarioDataset();
		private tfi_ValoresDataset dataValores=new tfi_ValoresDataset();
		private tfi_ValoresDatosAuxiliaresDataset dataValoresDatosAuxiliares=new tfi_ValoresDatosAuxiliaresDataset();
		#endregion
		#region propiedades
		private DataView _data=new DataView();
		private DataTable _cuentasBancarias=new DataTable();
		private DataTable _bancos=new DataTable();
		private string _idBanco=string.Empty;
		private string _idCuenta=string.Empty;
		private string _fechaDeposito=string.Empty;
		private long _nroBoleta=long.MinValue;
		private string _idEstadoCheque=Variables.GetValueString("Valores.Estado.Depositado");
		//Variables de bd q necesita la vista para configurarse, por ejemplo
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Depositar Cheques";
		public string TextoBotonAnterior
		{
			get 
			{
				return _textoBotonAnterior;
				
			}
			set
			{
				_textoBotonAnterior=value;
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{		
				return _textoBotonSiguiente;
				
			}
			set
			{
				_textoBotonSiguiente=value;
			}
		}
		public string Leyenda
		{
			get 
			{
				return _leyenda;
				
			}
			set 
			{
				_leyenda=value;
				
			}
		}
		public DataView Data
		{
			get 
			{
				return _data;
				
			}
			set 
			{
				_data=value;
				
			}
		}
		
		public string FechaDeposito
		{
		
			get{return _fechaDeposito;}
			set{_fechaDeposito=value;}
		
		}
		public long NroBoleta
		{
			get{return _nroBoleta;}
			set{_nroBoleta=value;}
		}
		public DataTable Bancos
		{
			get{return _bancos;}
		}
		public DataTable CuentasBancarias
		{
			get{return _cuentasBancarias;}
		}
		public string IdBanco
		{
			get 
			{
				return _idBanco;
			}
			set
			{
				_idBanco=value;
				_cuentasBancarias=tfi_CuentaBancaria.GetListPorBanco(_idBanco);
				//Ir a buscar las cuentas de ese banco
			
			}
		}
		public string IdCuenta
		{
			get 
			{
				return _idCuenta;
			}
			set
			{
				_idCuenta=value;
						
			}
		}
		#endregion
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public virtual bool AllowPrevious()
		{
			return true;
		}
		public  void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}
//Escucho las tareas de las q dependo
		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			ITask tareaprevia = (ITask)sender;
			if (tareaprevia.GetTaskName().CompareTo("ConsultarValores") ==0 )
			{
				ConsultaValores consulta = (ConsultaValores)sender;
				//Seteo el dataview para la grilla con la variable ValoresDepositar de consultaValores
				this.Data=consulta.ValoresDepositar;}
			
			System.Console.WriteLine("Hello world");
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}
		//Siempre mismo codigo
		public  bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		public virtual bool IsValid()
		{
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}

		public string GetProcessName()
		{
			return this._processParent.Process.ProcessName;
		}



		// Levanta la inicializacion de la tarea
		public  void Init()
		{  	
			string variable  = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Leyenda";
			Leyenda = Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
			this.TextoBotonAnterior= Variables.GetValueString(variable);		
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			this.TextoBotonSiguiente= Variables.GetValueString(variable);	
			
			_bancos=tfi_Banco.GetListEnTabla();
		}
		public  bool AllowShow()
		{			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public  ItemsDatasetErrors GetErrors()
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

		//Siempre labura asi el execute
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
			replication.NombreTabla = "dataaccess.sy_Usuarios";			
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
		
		public void Commit()
		{	
			//Por cada valor en la grilla tengo q actualizar el estado a depositado y generar un movimiento bancario con esos datos
			
			ArrayList valoresADepositar=this.GetValoresADepositar();
			foreach (string valor in valoresADepositar)
			{
				//Actualizo el valor con estado depositado
				tfi_ValoresDataset.tfi_ValoresRow _row=tfi_Valores.GetByPk(valor);
				#region nuevo movimiento para el valor
				//Genero un movimiento por cada valor, a depositar
				string idcomptesoreria=_row.IdTDCompTesoreria;
				string idValor=_row.IdValor;
				string nroCheque=_row.Numero;
				decimal total=_row.Valor;
				string idCuentaBancaria=this.IdCuenta;
				DateTime fechaImputacion=Convert.ToDateTime(this.FechaDeposito);
				tfi_TDCompTesoreria_TipoMovimientoDataset result=tfi_TDCompTesoreria_TipoMovimiento.GetList(string.Empty,idcomptesoreria);
				//Por cada movimiento asociado al comprobante de tesoreria genero el movimiento
				foreach (tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow tipo in result.Tables[0].Rows)
				{								
					string tipoMovimiento=tipo.IdTipoMovimiento;
					MovimientoBancario mov=new MovimientoBancario(string.Empty,tipoMovimiento,idCuentaBancaria, idValor, nroCheque,total, fechaImputacion,DateTime.MinValue);
					mov.Data=this.dataMovimientoBancario;
					mov.Commit();
					dataMovimientoBancario=mov.Data;
				
				}
				#endregion
				//Valor esta depositado
				_row.IdEstadoCheque=_idEstadoCheque;
				dataValores.Tables[0].ImportRow(_row);
				//Cargo la boleta de deposito en valoresDatosAuxiliares
				tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow _rowAuxiliares=tfi_ValoresDatosAuxiliares.GetByPk(valor);
				//Valor esta depositado
				_rowAuxiliares.NROBOLETA_CHE_T_C_DT_D_=Convert.ToString(this.NroBoleta);
				dataValoresDatosAuxiliares.Tables[0].ImportRow(_rowAuxiliares);
			
			
			}
					
			
		}
	
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();

			mz.erp.dataaccess.tfi_MovimientoBancario.Update(dataMovimientoBancario.Tables[0],IdTransaction);
			mz.erp.dataaccess.tfi_Valores.Update(dataValores.Tables[0],IdTransaction,_replication);
			mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update(dataValoresDatosAuxiliares.Tables[0],IdTransaction,_replication);
			/*businessrules.tfi_Chequera.Update( (tfi_ChequeraDataset.tfi_ChequeraDataTable) _data.Tables[0]);*/
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region metodos privados
		private void ValidarDatos()
		{
			_errores.Clear();		
			if (this._idBanco.Equals(string.Empty))
					_errores.Add( new ItemDatasetError( "Depósito","Banco","No ha seleccionado el banco para el depósito") );
			if (this._idCuenta.Equals(string.Empty))
					_errores.Add( new ItemDatasetError( "Depósito","Cuenta","No ha seleccionado la cuenta para el depósito") );
			if(this._fechaDeposito.Equals(string.Empty))
				_errores.Add( new ItemDatasetError( "Depósito","Fecha Depósito","Ingrese la fecha de depósito") );
			if(this.NroBoleta.Equals(long.MinValue))
					_errores.Add( new ItemDatasetError( "Depósito","NroBoleta","Ingrese el número de boleta del depósito") );
			}
		#endregion
		public ArrayList GetValoresADepositar()
		{
			ArrayList aux = new ArrayList();
			
			foreach(DataRowView row in this.Data)
			{
				string IdValor = Convert.ToString(row["IdValor"]);
				aux.Add(IdValor);
			}
			

			return aux;
		}
	}
}
