using System;
using System.Data;
using System.Collections;
using mz.erp.systemframework;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Aceptacion.
	/// </summary>
	public class Aceptacion: ITask, IPersistentTask
	{
		public Aceptacion()
		{
		}


		#region Variables privadas
			
		private string _usuario1 = string.Empty;
		private string _usuario2 = string.Empty;
		private string _clave1 = string.Empty;
		private string _clave2 = string.Empty;
		private string _comentario = string.Empty;
		private string _mensaje = string.Empty;

		private ProcessManager _processManager;
		private string _taskName;
		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;

		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
	
		private mz.erp.commontypes.data.tsh_AceptacionDataset _dataAceptacion = new mz.erp.commontypes.data.tsh_AceptacionDataset();

		private bool _visible = true;

		//private bool _hasShowSeleccionItems = false;	

		#endregion

		#region Variables Publicas

		public string Usuario1 
		{
			get { return _usuario1;}
			set {_usuario1 = value;}
		}
		public string Usuario2
		{
			get { return _usuario2;}
			set {_usuario2 = value;}
		}
		public string Clave1 
		{
			get { return _clave1;}
			set {_clave1 = value;}
		}
		public string Clave2
		{
			get { return _clave2;}
			set {_clave2 = value;}
		}
		public string Comentario
		{
			get { return _comentario;}
			set {_comentario = value;}
		}
		public string Mensaje
		{
			get { return _mensaje;}
			set {_mensaje = value;}
		}
		
		public string ProcesoEnEjecucion
		{
			get { return this.GetProcessManagerParent().Process.ProcessName; }
		}

		#endregion

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
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return false;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender ){}
		public void ListenerTaskDependentChanged(object sender)	{}
		public void ListenerAfterExecuteDependentTask( object sender )
		{
			#region Transferencia entre Cajas
			if (sender.GetType() == typeof( mz.erp.businessrules.TransferirValores))
			{
				TransferirValores transferencia= (TransferirValores)sender;
				if(this._processManager.Process.ProcessName.Equals("ProcesoTransferirValoresCaja"))
				{
					
					if(Security.CajasNivelControlAlto || Security.CajasNivelControlMedio)
					{
						//seteo los valores iniciales de la ventana
						string cajaOrigen = tfi_Cajas.GetByPk(tfi_InstanciasCaja.GetByPk(transferencia.KeyValueCajaOrigen).IdCaja).Descripcion;
						string cajaDestino= tfi_Cajas.GetByPk(tfi_InstanciasCaja.GetByPk(transferencia.KeyValueCajaDestino).IdCaja).Descripcion;
						this._usuario1= transferencia.ResponsableCajaOrigen;
						this._usuario2= transferencia.ResponsableCajaDestino;
						this._mensaje = 
							"Se confirmará una TRANSFERENCIA ENTRE CAJAS; desde '"+ 
							cajaOrigen +"' a cargo de '"+ this.Usuario1 + "' a '" +
							cajaDestino +"' a cargo de '"+ this._usuario2+"'.";
						_visible = true;
					}
					else
						_visible = false;
				}
			}
			#endregion
            /* Silvina 20100604 - Tarea 453 */
            _clave1 = string.Empty;
            _clave2 = string.Empty;
            /* Fin Silvina */
		}

		public void ListenerBeforeExecuteDependentTask( object sender ){}

		public void Init()
		{
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			this._idTask = Workflow.GetIdTakByName(this._taskName);			
		}

		public string BuscarClave( string persona )
		{
			//como busca por like, obtengo todas las personas que contiene ese nombre
			System.Data.DataSet dataPersonas = mz.erp.dataaccess.sy_Usuarios.UsuariosPersonasGetList(null, null, persona); 
			//me quedo en rowSeleccionada con la row que tiene el mismo nombre de usuario que el de pantalla
			foreach (System.Data.DataRow row in dataPersonas.Tables["sy_UsuariosPersonas"].Rows)
			{
				if (row["Persona"].ToString()==(persona))
				{
					string claveBD = Convert.ToString(row["Clave"]);
					return (new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(claveBD));
				}
			}
			return null;
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
			if(_visible)
			{
				if (this._clave1 != BuscarClave(this._usuario1))
				{
					IsValid = false;
					_errores.Add( new ItemDatasetError( this._processManager.Process.ProcessName,"Valor","La clave de usuario NO es correcta."));
				}
				if (this._clave2 != BuscarClave(this._usuario2))
				{
					IsValid = false;
					_errores.Add( new ItemDatasetError( this._processManager.Process.ProcessName,"Valor","La clave de usuario NO es correcta."));
				}
			}
			return IsValid;
		}
		public bool AllowShow() 
		{
			return _visible;
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

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( _dataAceptacion);
			return data;
		}

		public void Commit()
		{
			if(_visible)
			{
				tsh_AceptacionDataset.tsh_AceptacionRow rowAceptacion = _dataAceptacion.tsh_Aceptacion.Newtsh_AceptacionRow();
				rowAceptacion = tsh_Aceptacion.SetRowDefaultValues(rowAceptacion);
				rowAceptacion.Usuario1 = BuscarIdUsuario(this._usuario1);
				rowAceptacion.Usuario2 = BuscarIdUsuario(this._usuario2);
				rowAceptacion.IdTipoAceptacion = Variables.GetValueString("Momentos."+this._taskName+"."+this._processManager.Process.ProcessName+".IdtipoAceptacion.Default");
				rowAceptacion.MensajeAceptacion = this._mensaje;
				rowAceptacion.Comentario = this._comentario;
			
				_dataAceptacion.tsh_Aceptacion.Addtsh_AceptacionRow(rowAceptacion);
			}
		}

		public string BuscarIdUsuario( string persona )
		{
			//como busca por like, obtengo todas las personas que contiene ese nombre
			System.Data.DataSet dataPersonas = mz.erp.dataaccess.sy_Usuarios.UsuariosPersonasGetList(null, null, persona); 
			//me quedo en rowSeleccionada con la row que tiene el mismo nombre de usuario que el de pantalla
			foreach (System.Data.DataRow row in dataPersonas.Tables["sy_UsuariosPersonas"].Rows)
			{
				if (row["Persona"].ToString()==(persona))
				{
					return (Convert.ToString(row["IdUsuario"]));
				}
			}
			return null;
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			if(_visible)
				mz.erp.businessrules.tsh_Aceptacion.Update(_dataAceptacion, IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación Aceptacion.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación Aceptacion.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación Aceptacion.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación Aceptacion.GetHasSaved
			return false;
		}

		#endregion

		public bool PreguntarAlCancelar
		{
			get {
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}
	}
}
