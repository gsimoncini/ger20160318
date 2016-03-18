using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using System.Data.SqlClient;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ABMChequeras.
	/// </summary>
	public class ABMChequeras: ITask, IPersistentTask
	{
		public ABMChequeras()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables Privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		#endregion
		#region propiedades
		//Variables de bd q necesita la vista para configurarse, por ejemplo
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Abm Chequeras";
		private bool _preguntarAlCancelar = false;
		private string _operacion=string.Empty;
		private string _mascaraNroChequera="nnnnnnnn";
		private string _mascaraUltimoCheque="nnnnnnnn";
		private string _mascaraPrimerCheque="nnnnnnnn";
		
		//Variables pa comportamiento
		private string _idBanco=string.Empty;
		private string _idCuenta=string.Empty;
		private string _idBancoBusqueda=string.Empty;
		private string _idCuentaBusqueda=string.Empty;
		private string _idChequera=string.Empty;
		private long _chequera= long.MinValue;
		private long _primerCheque= long.MinValue;
		private long _ultimoCheque=long.MinValue;
		private DateTime _fechaCierre=new DateTime();
		private mz.erp.commontypes.data.tfi_ChequeraDataset _data=new mz.erp.commontypes.data.tfi_ChequeraDataset(); 
																
		private DataTable _bancos=new DataTable();
		private DataTable _cuentasBancarias=new DataTable();
		private DataTable _chequeras=new DataTable();
		public long Chequera
		{
			get{return _chequera;}
			set{_chequera=value;}
		}
		public long PrimerCheque
		{
			get{return _primerCheque;}
			set{_primerCheque=value;}
		}
		public long UltimoCheque
		{
			get{return _ultimoCheque;}
			set{_ultimoCheque=value;}
		}
		public DataTable Chequeras
		{
			get{return _chequeras;}
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
		//busqueda
		public string IdBancoBusqueda
		{
			get 
			{
				return _idBancoBusqueda;
			}
			set
			{
				_idBancoBusqueda=value;
				_cuentasBancarias=tfi_CuentaBancaria.GetListPorBanco(_idBancoBusqueda);
				//Ir a buscar las cuentas de ese banco
			
			}
		}
		public DateTime FechaCierre
		{
			set {_fechaCierre=value;}
			get{return _fechaCierre;}
		}
		
		public string IdCuentaBusqueda
		{
			get 
			{
				return _idCuentaBusqueda;
			}
			set
			{	
				_idCuentaBusqueda=value;
				 tfi_ChequeraDataset data =tfi_Chequera.GetListAbierta(this.IdBancoBusqueda, this.IdCuentaBusqueda);
				_chequeras=data.Tables[0];
						
			}
		}
		public string IdChequera
		{
			get 
			{
				return _idChequera;
			}
			set
			{
				_idChequera=value;
						
			}
		}

		//Variables de configuracion de 
		public string MascaraPrimerCheque
		{
			get 
			{
				return _mascaraPrimerCheque;
			}
			set{_mascaraPrimerCheque=value;}
		}
		public string MascaraUltimoCheque
		{
			get 
			{
				return _mascaraUltimoCheque;
			}
			set{_mascaraUltimoCheque=value;}
		}
		public string MascaraNroChequera
		{
			get 
			{
				return _mascaraNroChequera;
			}
			set{_mascaraNroChequera=value;}
		}
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
		public string Operacion
		{
			get
			{
				return _operacion;
			}
			set
			{
				_operacion = value;
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
		public bool PreguntarAlCancelar
		{
			get
			{
				return _preguntarAlCancelar;
			}
			set 
			{
				_preguntarAlCancelar=value;
				
			}
		}
		#endregion

		#region metodos privados
		private void ValidarDatos()
		{//Operacion modificar e idChequera=string empty=>error
			_errores.Clear();
			//Errores para el alta
			if (this.Operacion.Equals("new"))
			{
				if (this._idBanco.Equals(string.Empty))
					_errores.Add( new ItemDatasetError( "Chequera","Banco","No ha seleccionado el banco para la chequera") );
				if (this._idCuenta.Equals(string.Empty))
					_errores.Add( new ItemDatasetError( "Chequera","Cuenta","No ha seleccionado la cuenta para la chequera") );
				if (this._chequera.Equals(long.MinValue))
					_errores.Add( new ItemDatasetError( "Chequera","Nro Chequera","Ingrese un número de identificación para la chequera") );
				if (this._primerCheque.Equals(long.MinValue))
					_errores.Add( new ItemDatasetError( "Chequera","Nro Primer Cheque","Ingrese el número del primer cheque") );
				if (this._ultimoCheque.Equals(long.MinValue))
					_errores.Add( new ItemDatasetError( "Chequera","Nro Ultimo Cheque","Ingrese el número del último cheque") );
				if (this._ultimoCheque<this._primerCheque)
					_errores.Add( new ItemDatasetError( "Chequera","Números de Cheques","El último número de cheque no puede ser menor que el primero") );
				//Busco por numero idCuenta, idBanco todas las chequeras y verifico q no haya ninguna con ese codigo o con esos numeros de cheques
				tfi_ChequeraDataset data =tfi_Chequera.GetList(string.Empty, this.IdBanco, this.IdCuenta, long.MinValue, string.Empty, string.Empty,DateTime.MinValue,DateTime.MinValue);
				if (data.Tables[0].Rows.Count!=0)
					foreach(tfi_ChequeraDataset.tfi_ChequeraRow row in  data.Tables[0].Rows)
					{
						long comienzaEn=Convert.ToInt64(row["Comienzo"]);
						long finalizaEn=Convert.ToInt64(row["Final"]);
						if (this.PrimerCheque==comienzaEn && this.UltimoCheque==finalizaEn)
							_errores.Add( new ItemDatasetError( "Chequera","Números de Cheques","Ya se ha ingresado una chequera con esos números de cheque") );
						if (comienzaEn<this.PrimerCheque && this.PrimerCheque<finalizaEn)
							_errores.Add( new ItemDatasetError( "Chequera","Números de Cheques","Ya se ha ingresado una chequera con ese primer cheque") );
						if (comienzaEn<this.UltimoCheque && this.UltimoCheque<finalizaEn)
							_errores.Add( new ItemDatasetError( "Chequera","Números de Cheques","Ya se ha ingresado una chequera con ese último cheque") );

					}
			}
			else {if (this.IdChequera.Equals(string.Empty))
					  _errores.Add( new ItemDatasetError( "Chequera","Selección","Debe Seleccionar una chequera para efectuar el cierre") );
				  
				  
				  
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

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			
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



		// Levanta la inicializacion de la tarea
		public  void Init()
		{  	
			string variable  = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Leyenda";
			Leyenda = Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
			this.TextoBotonAnterior= Variables.GetValueString(variable);		
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			this.TextoBotonSiguiente= Variables.GetValueString(variable);	
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Operacion";
			Operacion =Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "MascaraNroChequera";
			this.MascaraNroChequera= Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "MascaraUltimoCheque";
			this.MascaraUltimoCheque= Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "MascaraPrimerCheque";
			this.MascaraPrimerCheque= Variables.GetValueString(variable);
			_bancos=tfi_Banco.GetListEnTabla();
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "PreguntarAlCancelar";
			PreguntarAlCancelar = Variables.GetValueBool(variable);
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
		{	//Alta de chequera
			if (this.IdChequera.Equals(string.Empty))
			{
				tfi_ChequeraDataset.tfi_ChequeraRow _row=_data.tfi_Chequera.Newtfi_ChequeraRow();
				_row=tfi_Chequera.SetRowDefaultValues(_row);
				_row["IdBanco"]=this.IdBanco;
				_row["IdCuenta"]=this.IdCuenta;
				_row["CodigoChequera"]=Convert.ToString(this.Chequera);
				_row["Comienzo"]=Convert.ToString(this.PrimerCheque);
				_row["Final"]=Convert.ToString(this.UltimoCheque);
				_data.Tables[0].Rows.Add(_row);	
			}
			//Cierre de Chequera
			else{

			tfi_ChequeraDataset.tfi_ChequeraRow row=tfi_Chequera.GetByPk(this.IdChequera);
			row["FechaCierre"]=this.FechaCierre;
			_data.Tables[0].ImportRow(row);	
				
			}
					
			
		}
	
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			businessrules.tfi_Chequera.Update( (tfi_ChequeraDataset.tfi_ChequeraDataTable) _data.Tables[0],trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region metodos publicos
		public string ContenedoresVisibles()
		{
			if (this.Operacion.Equals("new"))
				return "DatosGenerales";
			else 
				return "Datoschequera";
		}

		public void CargarDatos(){
				this._idBanco=this.IdBancoBusqueda;
				this._idCuenta=this.IdCuentaBusqueda;
				tfi_ChequeraDataset.tfi_ChequeraRow row =tfi_Chequera.GetByPk(this.IdChequera);
				this.PrimerCheque=Convert.ToInt64(row["Comienzo"]);
				this.UltimoCheque=Convert.ToInt64(row["Final"]);
				this.Chequera=Convert.ToInt64(row["CodigoChequera"]);
				
		
		}
		#endregion
	}
}
