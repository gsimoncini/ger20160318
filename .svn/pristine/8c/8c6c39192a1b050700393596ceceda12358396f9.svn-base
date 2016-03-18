using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmPerfil.
	/// </summary>
	public class AbmPerfil: ITask, IPersistentTask
	{
		
		#region Constructores

		public AbmPerfil()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public AbmPerfil(string processName, string taskName)
		{
			this._processName=processName;
			this._taskName=taskName;
			Init();
		}
		#endregion

		#region Variables Privadas
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;
		
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Siguiente";

		private string _state = string.Empty;
		private bool _activo = false; // 0=muestra todos los perfiles; 1=muestra solo perfiles activos.
		private string _contenedoresVisibles = string.Empty;	
		private string _idPerfilAdministrador = string.Empty;
		private ArrayList _perfilesExcluidos = new ArrayList();
		private ArrayList _perfilesSuperiores = new ArrayList();
		private ArrayList _perfiles = new ArrayList();
		private ArrayList _perfilesVisibles = new ArrayList();
		private DataTable _dataPerfiles = new DataTable();
		private DataTable _dataVariablesPerfiles = new sy_VariablesPerfilesDataset().sy_VariablesPerfiles;
		private DataTable _dataPerfilesHerramientas = new sy_PerfilesHerramientasDataset().sy_PerfilesHerramientas;
		private ArrayList _idPerfilesACopiar = new ArrayList();
		private Perfil _perfil = new Perfil();
		
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
			
		}

		private void Step()
		{
			
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public  void Init()
		{
			switch(this._processName)
			{
				case "ProcesoIngresarPerfil":
					this._state="new";
					break;
				case "ProcesoEditarPerfil":
					this._state="edit";
					break;
				case "ProcesoEliminarPerfil":
					this._state="delete";
					break;
				default:
					this._state="invalid";
					break;
			}
			this._activo = Variables.GetValueBool(this._processName, this._taskName, "MostrarPerfilesActivos");
			this._contenedoresVisibles = Variables.GetValueString(this._processName, this._taskName, "ContenedoresVisibles");
			this._idPerfilAdministrador = Variables.GetValueString("Sistema.Administrador.IdPerfil");			
			this.PerfilesSuperiores = Security.PerfilesSuperioresList;
			string strPerfilesExcluidos = Variables.GetValueString(this._processName, this._taskName, "PerfilesExcluidos");
			this.PerfilesExcluidos = systemframework.Util.Parse(strPerfilesExcluidos, ",");
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
			
			_dataPerfiles = mz.erp.dataaccess.sy_Perfiles.GetList(this._activo).Tables[0];
			foreach(DataRow rowPerfil in _dataPerfiles.Rows)
			{
				this.Perfiles.Add(Convert.ToString(rowPerfil["IdPerfil"]));			

				Perfil perfil = new Perfil();
				perfil.Descripcion = Convert.ToString(rowPerfil["Descripcion"]);
				perfil.IdPerfil = Convert.ToString(rowPerfil["idPerfil"]);
				perfil.Tildado = false;		
						
				if ( (!this.PerfilesExcluidos.Contains(perfil.IdPerfil)) && (!this.PerfilesSuperiores.Contains(perfil.IdPerfil)) )
				{
					// No se excluye ni es superior.
					this.PerfilesVisibles.Add(perfil);
				}
				else
				{
					if ( (this.PerfilesSuperiores.Contains(perfil.IdPerfil)) && (this.PerfilesSuperiores.Contains(Convert.ToString(Security.IdPerfil))) && (!this.PerfilesExcluidos.Contains(perfil.IdPerfil)) )
						// Es un perfil superior que no se excluye y el usuario en sesion posee un perfil superior.
						this.PerfilesVisibles.Add(perfil);
				}
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

		public  bool IsValid()
		{
			ValidarDatos();
			return (_errores.Count > 0);
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
			_processName = _processParent.Process.ProcessName;
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


		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			return data;;
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public bool GetHasSaved()
		{
			return false;
		}
	
		public void Commit()
		{
			switch(this._state)
			{
				case "new":
					// Nuevo Perfil.
					_dataPerfiles.Clear();
					DataRow rowPerfil = _dataPerfiles.NewRow();
					sy_Perfiles.SetRowDefaultValues(rowPerfil);
					rowPerfil["IdPerfil"] = this.Perfil.IdPerfil;
					rowPerfil["Descripcion"] = this.Perfil.Descripcion;
					rowPerfil["Activo"] = this.Perfil.Activo;
					_dataPerfiles.Rows.Add(rowPerfil);

					// Nuevo Perfil en sy_variablesHerramientas.
					_dataVariablesPerfiles.Clear();
					foreach(string idPerfil in this.IdPerfilesACopiar)
					{
						DataTable dataVarPerfil = mz.erp.dataaccess.sy_VariablesPerfiles.GetList(string.Empty, Convert.ToUInt32(idPerfil)).Tables[0];
						foreach(DataRow rowVarPerfil in dataVarPerfil.Rows)						
						{	
							string rowIdVariable = Convert.ToString(rowVarPerfil["IdVariable"]);
							DataRow [] rowsValor = _dataVariablesPerfiles.Select("IdVariable = '" + rowIdVariable + "'");
							if( (rowsValor!=null) && (rowsValor.Length==0) )
							{
								// No existe la variable, ent la agrego
								DataRow newRow = _dataVariablesPerfiles.NewRow();
								sy_VariablesPerfiles.SetRowDefaultValues(newRow);
								newRow["IdVariable"] = rowVarPerfil["IdVariable"];
								newRow["IdPerfil"] = this.Perfil.IdPerfil;
								newRow["Valor"] = rowVarPerfil["Valor"];
								_dataVariablesPerfiles.Rows.Add(newRow);
							}
						}
					}
					break;

				case"edit":
					// Edicion de Perfil.
					_dataPerfiles.Clear();
					DataRow rowPerfilEdit = mz.erp.dataaccess.sy_Perfiles.GetByPk( Convert.ToInt32(this.Perfil.IdPerfil) );
					if (rowPerfilEdit!=null)
					{
						rowPerfilEdit["Descripcion"] = this.Perfil.Descripcion;
						rowPerfilEdit["Activo"] = this.Perfil.Activo;
						_dataPerfiles.ImportRow(rowPerfilEdit);
					}
					break;

				case"delete":
					// --------------------- Eliminar un Perfil.
					// Elimino PerfilHerramientas
					_dataPerfilesHerramientas.Clear();
					DataTable dataPerfilesHtasDelete = mz.erp.dataaccess.sy_PerfilesHerramientas.GetList(Convert.ToUInt32(this.Perfil.IdPerfil), long.MinValue, false).Tables[0];
					foreach(DataRow rowHtas in dataPerfilesHtasDelete.Rows)
					{
						rowHtas.Delete();
						_dataPerfilesHerramientas.ImportRow(rowHtas);						
					}

					// Elimino las varPerfil
					_dataVariablesPerfiles.Clear();
					DataTable dataVarPerfilDelete = mz.erp.dataaccess.sy_VariablesPerfiles.GetList(string.Empty, Convert.ToUInt32(this.Perfil.IdPerfil)).Tables[0];
					foreach(DataRow row in dataVarPerfilDelete.Rows)
					{
						row.Delete();
						_dataVariablesPerfiles.ImportRow(row);						
					}

					// Elimino el Perfil
					_dataPerfiles.Clear();
					DataRow rowPerfilDelete = mz.erp.dataaccess.sy_Perfiles.GetByPk( Convert.ToInt32(this.Perfil.IdPerfil) );
					rowPerfilDelete.Delete();
					_dataPerfiles.ImportRow(rowPerfilDelete);
					break;
				default:
					break;
			}
		}

		public void Flush(string IdTransaction)
		{
			if (this.State.Equals("new")||this.State.Equals("edit"))
			{
				mz.erp.dataaccess.sy_Perfiles.Update(_dataPerfiles, IdTransaction);
				mz.erp.dataaccess.sy_VariablesPerfiles.Update(_dataVariablesPerfiles, IdTransaction);				
				string strPerfilesACopiar = systemframework.Util.PackString(this.IdPerfilesACopiar, ",");
				sy_Herramientas.IncluirHerramientasDe(IdTransaction, this.Perfil.IdPerfil, strPerfilesACopiar);			
			}
			else
			{
				if (this.State.Equals("delete"))
				{
					mz.erp.dataaccess.sy_VariablesPerfiles.Update(_dataVariablesPerfiles, IdTransaction);				
					mz.erp.dataaccess.sy_PerfilesHerramientas.Update(_dataPerfilesHerramientas, IdTransaction);
					mz.erp.dataaccess.sy_Perfiles.Update(_dataPerfiles, IdTransaction);					
				}
			}
		}
		
		public void InitializeData()
		{
		
		}
		
		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		
		//		public abstract TaskCollectionData GetData()
		//		{
		//			TaskCollectionData data = new TaskCollectionData();
		//			data.TaskName = this._taskName;
		//			data.Add(_data);
		//			return data;
		//		}
		
		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}


		#endregion

		#region Propiedades
		public string ContenedoresVisibles
		{
			get{return this._contenedoresVisibles;}
		}
		public bool EditMode
		{
			get{return this._state.Equals("edit");}
		}
		public Perfil Perfil
		{
			get{return this._perfil;}
			set{this._perfil=value;}
		}
		public ArrayList Perfiles
		{
			get{return this._perfiles;}
			set{this._perfiles=value;}
		}
		public ArrayList PerfilesSuperiores
		{
			get{return this._perfilesSuperiores;}
			set{this._perfilesSuperiores=value;}
		}
		public ArrayList PerfilesExcluidos
		{
			get{return this._perfilesExcluidos;}
			set{this._perfilesExcluidos=value;}
		}
		public ArrayList PerfilesVisibles
		{
			get{return this._perfilesVisibles;}
		}
		public DataTable DataTablePerfilesVisibles
		{
			get
			{
				DataTable data = new sy_PerfilesDataset().sy_Perfiles;
				foreach(Perfil unPerfil in this.PerfilesVisibles)				
				{
					DataRow aRow = data.NewRow();
					sy_Perfiles.SetRowDefaultValues(aRow);
					aRow["IdPerfil"] = unPerfil.IdPerfil;
					aRow["Descripcion"] = unPerfil.Descripcion;
					data.Rows.Add(aRow);					
				}
                return data;                				
			}
		}		
		public ArrayList IdPerfilesACopiar
		{
			get{return this._idPerfilesACopiar;}
			set{this._idPerfilesACopiar=value;}
		}
		public string State
		{
			get{return this._state;}
		}
		public string IdPerfil
		{
			get{return this.Perfil.IdPerfil;}
			set
			{
				this.Perfil.IdPerfil=value;
				if (this.State.Equals("edit"))
				{
					sy_PerfilesDataset.sy_PerfilesRow rowPerfil = mz.erp.dataaccess.sy_Perfiles.GetByPk( Convert.ToUInt32(value) );
					this.Descripcion=rowPerfil.Descripcion;
					this.Activo=rowPerfil.Activo;
				}
			}
		}
		public string Descripcion
		{
			get{return this.Perfil.Descripcion;}
			set{this.Perfil.Descripcion=value;}
		}
		public bool Activo
		{
			get{return this.Perfil.Activo;}
			set{this.Perfil.Activo=value;}
		}
		
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		#endregion

		#region Metodos Publicos
		public void AddIdPerfilesACopiar(string idPerfil)
		{
			this.IdPerfilesACopiar.Add(idPerfil);
		}

		#endregion

		#region Metodos Privados
		private void ValidarDatos()
		{
			_errores.Clear();
			switch(this.State)
			{
				case "new":
					if (this.Perfil.IdPerfil.Equals(string.Empty))
						_errores.Add( new ItemDatasetError( "Perfil","Nro Perfil","No ha ingresado el nro del nuevo perfil") );
					else
					{
						// Validar que no existe el nuevo nro de perfil
						foreach(string idPerfil in this.Perfiles)
							if (idPerfil.Equals(this.Perfil.IdPerfil))
								_errores.Add( new ItemDatasetError( "Perfil","Nro Perfil","El nro de perfil ingresado ya existe") );
					}
					if (this.Perfil.Descripcion.Equals(string.Empty))
						_errores.Add( new ItemDatasetError( "Perfil","Descripcion","No ha ingresado la descripcion del nuevo perfil") );
					if (this.IdPerfilesACopiar.Count==0)
						_errores.Add( new ItemDatasetError( "Perfil","Perfiles a copiar","No ha seleccionado ningún perfil") );
					break;
				
				case "edit":
					if (this.Perfil.Descripcion.Equals(string.Empty))
						_errores.Add( new ItemDatasetError( "Perfil","Descripcion","No ha ingresado la descripcion del nuevo perfil") );				  
					//German 20090804
					if (!this.Perfil.Activo && ValidarUsuarioTienePerfil())
						_errores.Add( new ItemDatasetError( "Perfil","Eliminar","No es posible eliminar el perfil seleccionado debido a que existen usuarios con dicho perfil") );
					/*
					if (ValidarUsuarioTienePerfil())
						_errores.Add( new ItemDatasetError( "Perfil","Eliminar","No es posible eliminar el perfil seleccionado debido a que existen usuarios con dicho perfil") );
					*/
					//Fin German 20090804
					break;

				case "delete":
					if (this.Perfil.IdPerfil.Equals(string.Empty))
						_errores.Add( new ItemDatasetError( "Perfil","Nro Perfil","No ha ingresado el nro del nuevo perfil") );
					else
					{
						if (ValidarUsuarioTienePerfil())
							_errores.Add( new ItemDatasetError( "Perfil","Eliminar","No es posible eliminar el perfil seleccionado debido a que existen usuarios con dicho perfil") );
					}
					break;

				default:
					_errores.Add( new ItemDatasetError( "Perfil","Error de Proceso","Error de configuracion") );
					break;
					
			}			
			
		}
		private bool ValidarUsuarioTienePerfil()
		{
			sy_PerfilesUsuariosEmpresasDataset data = mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.GetList(string.Empty, Convert.ToUInt32(this.Perfil.IdPerfil), long.MinValue); //.sy_PerfilesUsuariosEmpresasDataTable
			if (data.sy_PerfilesUsuariosEmpresas.Rows.Count>0)
				return true;
			return false;
		}

		#endregion
	}
}
