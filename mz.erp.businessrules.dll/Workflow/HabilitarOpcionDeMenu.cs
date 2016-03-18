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
	public class HabilitarOpcionDeMenu: ITask, IPersistentTask
	{
		public HabilitarOpcionDeMenu()
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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init
			//_claveBD = _row.Clave;
			sy_PerfilesDataset data = sy_Perfiles.GetList();
			foreach(DataRow row in data.sy_Perfiles.Rows) 
			{
				Perfil perfil = new Perfil();				
				perfil.IdPerfil = Convert.ToString(row["IdPerfil"]);
				perfil.Nombre = Convert.ToString(row["Descripcion"]);
				this.AddPerfil(perfil);
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
			
			/*if (_claveAnterior != _claveBD)
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña anterior","La contraseña anterior es inválida"));
			}			
			if (_claveNueva1 != _claveNueva2)
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña nueva","Error en la confirmación de la contraseña"));
			}*/

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
			//_row.Clave = _claveNueva1;
			//_data.sy_Usuarios.ImportRow(_row);
			_perfilesEntreComas = String.Empty;
			foreach(Perfil perfil in _perfiles) 
			{
				if (_perfilesEntreComas == String.Empty) 
				{_perfilesEntreComas = _perfilesEntreComas;}
				else 
				{_perfilesEntreComas = _perfilesEntreComas + ',' + perfil.IdPerfil;}				
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
			replication.NombreTabla = "dataaccess.sy_Recursos";			
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

			//_replication = GenerateReplication();
			//SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			//sy_Usuarios.Update(_data, trx, _replication);			
			businessrules.OpcionDeMenu.Update(_opcionPadre, _opcion, _titulo, _perfilesEntreComas);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region Variables privadas
		private string _perfilesEntreComas = string.Empty;
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


		/*private sy_UsuariosDataset.sy_UsuariosRow _row = sy_Usuarios.GetByPk(Security.IdUsuario);	
		private string _claveBD = String.Empty;*/
		private string _opcionPadre = string.Empty;
		public string OpcionPadre
		{
			get{return _opcionPadre;}
			set
			{
				if(_opcionPadre != value)
				{
					_opcionPadre = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _opcion = string.Empty;
		public string Opcion
		{
			get{return _opcion;}
			set
			{
				if(_opcion != value)
				{
					_opcion = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _titulo = string.Empty;
		public string Titulo
		{
			get{return _titulo;}
			set
			{
				if(_titulo != value)
				{
					_titulo = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private Perfiles _perfiles = new Perfiles();
		public ArrayList Perfiles
		{
			get {return (ArrayList) _perfiles;}
			set {_perfiles = (Perfiles) value;}
		}
		#endregion

		#region Métodos privados
		public void AddPerfil(Perfil perfil) 
		{
			this._perfiles.Add(perfil);
		}

		#endregion
	}

	public class Perfiles: ArrayList
	{
		public Perfiles()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}	
		/*public void Add(object sender)
		{
			this.Add(sender);
			//base.List.Add( sender );
		}*/
	}

	public class Perfil
	{
		public Perfil()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}	

		private string _idPerfil;
		public string IdPerfil
		{
			get{return _idPerfil;}
			set{_idPerfil = value;}
		}
		private string _nombre;
		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}
		private bool _activo = false;
		public bool Activo
		{
			get{return _activo;}
			set{_activo = value;}
		}
		private string _descripcion;
		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}
		private bool _tildado;
		public bool Tildado
		{
			get{return _tildado;}
			set{_tildado = value;}
		}
	}
}


