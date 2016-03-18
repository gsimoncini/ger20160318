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
	/// Descripción breve de CambiarContraseña.
	/// </summary>
	public class CambiarContraseña: ITask, IPersistentTask
	{
		public CambiarContraseña()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}		

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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init //User ID=sa;password=03461441874;Initial Catalog=Prueba;Data Source=sservidor
			//_claveBD = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64("User ID=sa;password=gosp;Initial Catalog=ErpPrincipal2183;Data Source=sservidor");			
			_claveBD = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64("User ID=sa;password=gosp;Initial Catalog=erpprincipalPrueba;Data Source=Sservidor");			

			_claveBD = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64( _row.Clave);
			
			//_claveBD=_row.Clave;
			_idUsuario = _row.IdUsuario;
			if (this._taskName.CompareTo("ReestablecerContrasenia")==0) 
			{
				_enabledSetPreviousPassword=false;
			}
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
			
			if ((_claveAnterior != _claveBD) && (_enabledSetPreviousPassword ))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña anterior","La contraseña anterior es inválida"));
			}			
			if (_claveNueva1 != _claveNueva2)
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña nueva","Error en la confirmación de la contraseña"));
			}

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
			_row = sy_Usuarios.GetByPk(this._idUsuario);	
			string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( this._claveNueva2 );
			_row.Clave = encriptada;
			_data.sy_Usuarios.ImportRow(_row);
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
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			sy_Usuarios.Update(_data, trx, _replication);			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		sy_UsuariosDataset _data = new sy_UsuariosDataset();
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

		private string _leyendaFormulario = "Modificación de contraseña";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
				}
				else 
				{
					return valor;
				}
			}
		}

		public bool PreguntarAlCancelar
		{
			get {
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		private sy_UsuariosDataset.sy_UsuariosRow _row = sy_Usuarios.GetByPk(Security.IdUsuario);	
		private sy_UsuariosDataset.sy_UsuariosDataTable _tableUsuarios = sy_Usuarios.GetList().sy_Usuarios;

		private string _claveBD = String.Empty;
		private string _claveAnterior = string.Empty;
		public string ClaveAnterior
		{
			get{return _claveAnterior;}
			set
			{
				if(_claveAnterior != value)
				{
					_claveAnterior = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _claveNueva1 = string.Empty;
		public string ClaveNueva1
		{
			get{return _claveNueva1;}
			set
			{
				if(_claveNueva1 != value)
				{
					_claveNueva1 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _claveNueva2 = string.Empty;
		public string ClaveNueva2
		{
			get{return _claveNueva2;}
			set
			{
				if(_claveNueva2 != value)
				{
					_claveNueva2 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private bool _enabledSetPreviousPassword = true;
		public bool EnabledSetPreviousPassword
		{
			get { return _enabledSetPreviousPassword ; }
		}
		private string _idUsuario;
		public string IdUsuario
		{
			set { _idUsuario = value; }
			get { return _idUsuario ; }
		}
		public System.Data.DataTable Usuarios
		{
			get { return _tableUsuarios; }
		}
		
		#endregion

	}
}


