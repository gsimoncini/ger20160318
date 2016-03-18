using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data.SqlClient;
using mz.erp.dataaccess;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CuentasObservacionesEstados.
	/// </summary>
	public class ABMCuentasObservacionesEstados: ITask, IPersistentTask
	{
		public ABMCuentasObservacionesEstados()
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
		//poner como variables los datos q se necesitan en la interface
		#region Propiedades
		//Variables de la interface
		private string _descripcion=string.Empty;
		private string _idCuentaObservacionEstado=string.Empty;
		private bool _activo=true;
		private string _idProveedorObservacionEstado=string.Empty;
		//Variables de bd q necesita la vista para configurarse, por ejemplo
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Abm Cuentas Observaciones Estados";
		private bool _preguntarAlCancelar = false;
		private bool _validarExisteEstado=false;
		//Operacion q se ejecuta
		private string _operacion=string.Empty;
	
		private mz.erp.commontypes.data.tsa_CuentasObservacionesEstadosDataset _data = new mz.erp.commontypes.data.tsa_CuentasObservacionesEstadosDataset();

		public mz.erp.commontypes.data.tsa_CuentasObservacionesEstadosDataset data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}

		private mz.erp.commontypes.data.tpu_ProveedoresObservacionesEstadosDataset _dataProveedores = new mz.erp.commontypes.data.tpu_ProveedoresObservacionesEstadosDataset();

		public mz.erp.commontypes.data.tpu_ProveedoresObservacionesEstadosDataset DataProveedores
		{
			get
			{
				return _dataProveedores;
			}
			set
			{
				_dataProveedores = value;
			}
		}

		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				_descripcion = value;
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
		public string IdCuentaObservacionEstado
		{
			get
			{
				return _idCuentaObservacionEstado;
			}
			set
			{
				_idCuentaObservacionEstado = value;
			}
		}
		
		public string IdProveedorObservacionEstado
		{
			get
			{
				return _idProveedorObservacionEstado;
			}
			set
			{
				_idProveedorObservacionEstado = value;
			}
		}

		public bool Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				_activo= value;
			}
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
			{ return _leyenda;
				
			}
			set 
			{
				 _leyenda=value;
				
			}
		}
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		public bool ValidarExisteEstado
		{
			get
			{
				return _validarExisteEstado;
			}
			set
			{
				_validarExisteEstado = value;
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
		{  //Para ver si es el alta o la modificacion
			string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Operacion";
			Operacion = Variables.GetValueString(variable);
			
			//Es para ver si valida existencia del nuevo estado en la bd.
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.Estado";
			ValidarExisteEstado=Variables.GetValueBool(variable);

			//Leyenda del formulario
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Leyenda";
			Leyenda = Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
			this.TextoBotonAnterior= Variables.GetValueString(variable);		
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			this.TextoBotonSiguiente= Variables.GetValueString(variable);	
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
		//Variable mia
		
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
			if(this._processParent.Process.ProcessName.Equals("ProcesoAltaCuentaObservacionesEstados") || this._processParent.Process.ProcessName.Equals("ProcesoModificarCuentaObservacionesEstados"))
			{
				//Tengo q ver si es un alta o esta editando
				if (this.modo()=="new")
				{
					//Es un alta de estado
					tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row = _data.tsa_CuentasObservacionesEstados.Newtsa_CuentasObservacionesEstadosRow();
					_row = tsa_CuentasObservacionesEstados.SetRowDefaultValues( _row);
					_row["descripcion"] = this._descripcion;
					_row["activo"] = this._activo;
					_data.Tables[0].Rows.Add(_row);	
				}
				else 
				{
			
					tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row=tsa_CuentasObservacionesEstados.GetByPk(_idCuentaObservacionEstado);
					_row["descripcion"] = this._descripcion;
					_row["activo"] = this._activo;
					//Ojo q el estado de la row tenga estado added.() row estate
					_data.Tables[0].ImportRow(_row);	
				
				}
			} 
			else if(this._processParent.Process.ProcessName.Equals("ProcesoAltaProveedorObservacionesEstados")  || this._processParent.Process.ProcessName.Equals("ProcesoModificarProveedorObservacionesEstados"))
			{
				if (this.modo()=="new")
				{
					//Es un alta de estado
					tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosRow _row = _dataProveedores.tpu_ProveedoresObservacionesEstados.Newtpu_ProveedoresObservacionesEstadosRow();
					_row = tpu_ProveedoresObservacionesEstados.SetRowDefaultValues( _row);
					_row["descripcion"] = this._descripcion;
					_row["activo"] = this._activo;
					_dataProveedores.Tables[0].Rows.Add(_row);	
				}
				else 
				{
			
					tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosRow _row=tpu_ProveedoresObservacionesEstados.GetByPk(_idProveedorObservacionEstado);
					_row["descripcion"] = this._descripcion;
					_row["activo"] = this._activo;
					//Ojo q el estado de la row tenga estado added.() row estate
					_dataProveedores.Tables[0].ImportRow(_row);	
				
				}
			}
			
		}
	
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			//tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row=(tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow )_data.Tables[0].Rows[0];
			if(this._processParent.Process.ProcessName.Equals("ProcesoAltaCuentaObservacionesEstados"))
                dataaccess.tsa_CuentasObservacionesEstados.Update( (tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable) _data.Tables[0],trx);
			else
				dataaccess.tpu_ProveedoresObservacionesEstados.Update( (tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosDataTable) _dataProveedores.Tables[0],trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region metodos privados
		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_descripcion=_descripcion.Trim();
			_errores.Clear();
			if(this._processParent.Process.ProcessName.Equals("ProcesoAltaCuentaObservacionesEstados"))
			{
				if (_descripcion.CompareTo(string.Empty) == 0)
				{
					_errores.Add( new ItemDatasetError( "Cuentas Observaciones Estados","Descripcion","El campo no puede estar vacío") );
				}
		
				//Si es un alta no tiene q haber otro con esa descripcion
				if (_validarExisteEstado && this.modo()=="new")
				{
					tsa_CuentasObservacionesEstadosDataset DataSetEstado = mz.erp.businessrules.tsa_CuentasObservacionesEstados.GetList( "", _descripcion,false);
					if (DataSetEstado.Tables[0].Rows.Count>0 )
					{
						foreach (tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row in  DataSetEstado.Tables[0].Rows)
							if ((string)_row["Descripcion"]==_descripcion)
							{
								_errores.Add( new ItemDatasetError( "Cuentas Observaciones Estados","Descripcion","Ya existe otro estado con ese nombre") );	
							}
				
					}
				}
				if (ValidarExisteEstado && this.modo()!="new")
				{
					tsa_CuentasObservacionesEstadosDataset DataSetEstado = mz.erp.businessrules.tsa_CuentasObservacionesEstados.GetList( "", _descripcion,false);
					if (DataSetEstado.Tables[0].Rows.Count>0)
						//Tengo q hacer a mano la validacion porq el GetList usa el like
					{
						foreach (tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row in  DataSetEstado.Tables[0].Rows)
							if ((string)_row["IdCuentaObservacionEstado"]!=_idCuentaObservacionEstado && (string)_row["Descripcion"]==_descripcion)
							{
								_errores.Add( new ItemDatasetError( "Cuentas Observaciones Estados","Descripcion","Ya existe otro estado con ese nombre") );	
							}
				
					}
				}
			}
			else if(this._processParent.Process.ProcessName.Equals("ProcesoAltaProveedorObservacionesEstados"))
			{
				if (_descripcion.CompareTo(string.Empty) == 0)
				{
					_errores.Add( new ItemDatasetError( "Proveedores Observaciones Estados","Descripcion","El campo no puede estar vacío") );
				}
		
				//Si es un alta no tiene q haber otro con esa descripcion
				if (_validarExisteEstado && this.modo()=="new")
				{
					tpu_ProveedoresObservacionesEstadosDataset DataSetEstado = mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.GetList( string.Empty, _descripcion,false);
					if (DataSetEstado.Tables[0].Rows.Count>0 )
					{
						foreach (tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosRow _row in  DataSetEstado.Tables[0].Rows)
							if ((string)_row["Descripcion"]==_descripcion)
							{
								_errores.Add( new ItemDatasetError( "Proveedores Observaciones Estados","Descripcion","Ya existe otro estado con ese nombre") );	
							}
				
					}
				}
				if (ValidarExisteEstado && this.modo()!="new")
				{
					tpu_ProveedoresObservacionesEstadosDataset DataSetEstado = mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.GetList( "", _descripcion,false);
					if (DataSetEstado.Tables[0].Rows.Count>0)
						//Tengo q hacer a mano la validacion porq el GetList usa el like
					{
						foreach (tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosRow _row in  DataSetEstado.Tables[0].Rows)
							if ((string)_row["IdProveedorObservacionEstado"]!=_idProveedorObservacionEstado && (string)_row["Descripcion"]==_descripcion)
							{
								_errores.Add( new ItemDatasetError( "Proveedores Observaciones Estados","Descripcion","Ya existe otro estado con ese nombre") );	
							}
				
					}
				}
			}
		}
		private void ValidarExisteDatosPrecargados(){
		
		}
		#endregion
		#region metodos publicos
		public string modo()
		{
			
			return this.Operacion;
		}
      //Actualiza los datos cuando se selecciono un estado en la busqueda
		public  void UpdateElementos(ArrayList rows)
		{
			ProcesarElementos(rows);
			Refresh();
			
		}
		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		public  void ProcesarElementos(ArrayList rows)
		{
			System.Data.DataRow row=(System.Data.DataRow)rows[0];
			_activo=Convert.ToBoolean(row["Activo"]);
			_descripcion=Convert.ToString(row["descripcion"]);
			if(this._processParent.Process.ProcessName.Equals("ProcesoModificarCuentaObservacionesEstados"))
                _idCuentaObservacionEstado=Convert.ToString(row["idCuentaObservacionEstado"]);
			else if(this._processParent.Process.ProcessName.Equals("ProcesoModificarCuentaObservacionesEstados"))
				_idProveedorObservacionEstado=Convert.ToString(row["idProveedorObservacionEstado"]);
		}

		#endregion
	}
}
