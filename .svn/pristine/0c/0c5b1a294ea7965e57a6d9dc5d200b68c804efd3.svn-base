using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CambiarContraseña.
	/// </summary>
	public class AbmCuentasObservaciones: ITask, IPersistentTask
	{
		public AbmCuentasObservaciones()
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
		public void FormHasClosed() 
		{
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
			
			if (sender.GetType() == typeof(mz.erp.businessrules.mzCuentasObservacionesSearchForm) )
			{
				mzCuentasObservacionesSearchForm objeto = (mzCuentasObservacionesSearchForm)sender;
				string Proceso = this._processParent.Process.ProcessName;
				if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
				{
					_idCuentaObservacion = objeto.IdCuentaObservacion;
					_row = businessrules.tsa_CuentasObservaciones.GetByPk(_idCuentaObservacion);
					_idUsuario=Convert.ToString(_row["IdResponsable"]);
				}
				else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
				{
					_idProveedorObservacion = objeto.IdProveedorObservacion;
					_rowProveedor = businessrules.tpu_ProveedoresObservaciones.GetByPk(_idProveedorObservacion);
					_idUsuario=Convert.ToString(_rowProveedor["IdResponsable"]);
                    /* Silvina 20100923 - Tarea 843 */
                    _codigoProveedor = tpu_Proveedores.GetByPk(_rowProveedor.IdProveedor).Codigo;
                    /* Fin Silvina */
				}
			}
			
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init() 
		{
			string Proceso = this._processParent.Process.ProcessName;
			string Tarea = this.GetTaskName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				_tipos = tsa_CuentasObservacionesTipos.GetListTiposPerfil("Add").tsa_CuentasObservacionesTipos;
				_estados = tsa_CuentasObservacionesEstados.GetList().tsa_CuentasObservacionesEstados;		
				_estados = businessrules.VariablesListComparer.FilterDataTable(Proceso, Tarea, "ListaCuentasObservacionesEstados", "IdCuentaObservacionEstado", _estados);
				DataRow rowE = _estados.NewRow();					
				rowE["IdCuentaObservacionEstado"] = String.Empty;
				rowE["Descripcion"] = String.Empty;
				_estados.Rows.Add(rowE);

			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				_tiposProveedores = tpu_ProveedoresObservacionesTipos.GetListTiposPerfil("Add").tpu_ProveedoresObservacionesTipos;
				_estadosProveedores = tpu_ProveedoresObservacionesEstados.GetList().tpu_ProveedoresObservacionesEstados;		
				_estadosProveedores = businessrules.VariablesListComparer.FilterDataTable(Proceso, Tarea, "ListaProveedoresObservacionesEstados", "IdProveedorObservacionEstado", _estadosProveedores);
				DataRow rowE = _estadosProveedores.NewRow();					
				rowE["IdProveedorObservacionEstado"] = String.Empty;
				rowE["Descripcion"] = String.Empty;
				_estadosProveedores.Rows.Add(rowE);
			}
			/*DataRow row = _tipos.NewRow();
			row["IdCuentaObservacionTipo"] = String.Empty;
			row["Descripcion"] = String.Empty;
			_tipos.Rows.Add(row);			*/			

			_usuarios = sy_Usuarios.GetList().sy_Usuarios;
			//IdPersona del usuario Logueado
			_idUsuario = Security.IdPersona;
			_processParent.GetParameters(this, _taskName);		
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());

			//Variables de configuracion			
			this.HabilitarContraseña = Variables.GetValueBool(Proceso, Tarea, "HabilitarContraseña");			
			this.PermiteEditarTipo = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarTipo");			
			this.PermiteEditarFecha = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarFecha");		
			this.PermiteEditarResponsable = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarResponsable");			
			this.PermiteEditarSubTipo = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarSubTipo");			
			this.PermiteEditarEstado = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarEstado");			
			this.PermiteEditarTitulo = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarTitulo");			
			this.PermiteEditarFechaAviso = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarFechaAviso");			
			this.PermiteEditarFechaVencimiento = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarFechaVencimiento");			
			this.PermiteEditarCuenta = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarCuenta");			
			this.PermiteEditarObservaciones = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarObservaciones");
			/*variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
			this.TextoBotonAnterior= Variables.GetValueString(variable);		
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			this.TextoBotonSiguiente= Variables.GetValueString(variable);	
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
			this.LeyendaFormulario= Variables.GetValueString(variable);		*/
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
		
		}		

		public bool IsValidForStartProcess()
		{
			_errores.Clear();						
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return true;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();			
	
			System.Console.WriteLine(_idTipo);
			System.Console.WriteLine(_idSubTipo);			
			System.Console.WriteLine(_idEstado);
			System.Console.WriteLine(_titulo);
			System.Console.WriteLine(_observaciones);
			string Proceso = this._processParent.Process.ProcessName;
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				if (_codigoCuenta == String.Empty) 
				{
					IsValid = false;
					_errores.Add( new ItemDatasetError( "Cuenta","Cuenta","La cuenta no puede ser vacía"));
				}

			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				if (_idProveedor == String.Empty) 
				{
					IsValid = false;
					_errores.Add( new ItemDatasetError( "Proveedor","Proveedor","El proveedor no puede ser vacío"));
				}
			}
			if (_titulo == String.Empty) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Título","Título","El título no puede ser vacío"));
			}
			if (_observaciones == String.Empty) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Observaciones","Observaciones","Las observaciones no puede ser vacías"));
			}
			if (_idUsuario == String.Empty) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Responsable","Responsable","El responsable no puede ser vacio"));
			}
			if (_fechaAviso > _fechaVencimiento) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "FechaAviso","Fecha de aviso","La fecha de aviso no puede ser posterior a la fecha de vencimiento."));
			}
			return IsValid;
		}
		public bool AllowShow() 
		{
			return true;
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
			string Proceso = this._processParent.Process.ProcessName;
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				if (_idCuentaObservacion == String.Empty)
				{
					_row = businessrules.tsa_CuentasObservaciones.NewRow();				
					_row = businessrules.tsa_CuentasObservaciones.SetRowDefaultValues(_row);				
				}

				_row.Fecha = _fecha;
				_row.FechaAviso = _fechaAviso;
				_row.FechaVencimiento = _fechaVencimiento;
				_row.IdCuenta = businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);
				_row.Observacion = _observaciones;
				_row.IdCuentaObservacionEstado = _idEstado;
				_row.IdCuentaObservacionSubTipo = _idSubTipo;
				_row.IdCuentaObservacionTipo = _idTipo;			
				_row.Titulo = _titulo;
				_row.IdResponsable=_idUsuario;
			
		
				if (_idCuentaObservacion == String.Empty)
				{
					_data.tsa_CuentasObservaciones.LoadDataRow( ((DataRow) _row).ItemArray, false);
				}
				else 
				{
					_data.tsa_CuentasObservaciones.ImportRow(_row);
				}
				//businessrules.tsa_CuentasObservaciones.Update(_row);			

			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				if (_idProveedorObservacion == String.Empty)
				{
					_rowProveedor = businessrules.tpu_ProveedoresObservaciones.NewRow();				
					_rowProveedor = businessrules.tpu_ProveedoresObservaciones.SetRowDefaultValues(_rowProveedor);				
				}

				_rowProveedor.Fecha = _fecha;
				_rowProveedor.FechaAviso = _fechaAviso;
				_rowProveedor.FechaVencimiento = _fechaVencimiento;
				_rowProveedor.IdProveedor = _idProveedor;
				_rowProveedor.Observacion = _observaciones;
				_rowProveedor.IdProveedorObservacionEstado = _idEstadoProveedor;
				_rowProveedor.IdProveedorObservacionSubTipo = _idSubTipoProveedor;
				_rowProveedor.IdProveedorObservacionTipo = _idTipoProveedor;			
				_rowProveedor.Titulo = _titulo;
				_rowProveedor.IdResponsable=_idUsuario;
			
		
				if (_idProveedorObservacion == String.Empty)
				{
					_dataProveedores.tpu_ProveedoresObservaciones.LoadDataRow( ((DataRow) _rowProveedor).ItemArray, false);
				}
				else 
				{
					_dataProveedores.tpu_ProveedoresObservaciones.ImportRow(_rowProveedor);
				}

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
			replication.NombreTabla = "dataaccess.tsa_CuentasObservaciones";			
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
			string Proceso = this._processParent.Process.ProcessName;
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
				businessrules.tsa_CuentasObservaciones.Update(_data, trx, _replication);			
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
				businessrules.tpu_ProveedoresObservaciones.Update(_dataProveedores, trx, _replication);			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow _row = null;
		private tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow _rowProveedor = null;
		private ProcessManager _processParent;		
		private tsa_CuentasObservacionesDataset _data = new tsa_CuentasObservacionesDataset();		
		private tpu_ProveedoresObservacionesDataset _dataProveedores = new tpu_ProveedoresObservacionesDataset();		
		#endregion

		#region Propiedades Públicas
		/*private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get{return _textoBotonAnterior;}
			set	{_textoBotonAnterior = value ;}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get{return _textoBotonSiguiente;}
			set	{_textoBotonSiguiente = value ;}
			
		}
		*/
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." +this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
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
		/*private string _leyendaFormulario = "Observaciones de cuenta";
		public string LeyendaFormulario
		{
			get{return _leyendaFormulario;}
			set	{_leyendaFormulario = value ;}
		}*/
		private string _leyendaFormulario = "Observaciones de cuenta";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() +"."+ this._processParent.Process.ProcessName+ "." + "LeyendaFormulario";
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

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		private string _codigoCuenta = String.Empty;
		public string CodigoCuenta
		{
			get{return _codigoCuenta;}
			set	
			{
				if (_codigoCuenta != value) 
				{
					_codigoCuenta = value ;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());	
				}
			}
		}		

		private string _idProveedor = String.Empty;
		public string IdProveedor
		{
			get{return _idProveedor;}
			set	
			{
				if (_idProveedor != value) 
				{
					_idProveedor = value ;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());	
				}
			}
		}

        /* Silvina 20100920 - Tarea 839 */

        private string _codigoProveedor = String.Empty;
        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
            set {
                _codigoProveedor = value;
                businessrules.Proveedor proveedor = new businessrules.Proveedor();
                proveedor.GetCuenta_CodigoProveedor(value);
                _idProveedor = proveedor.IdProveedor;
            }
        }

        /* Fin Silvina */
		
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime Fecha
		{
			get{return _fecha;}
			set	{_fecha = value ;}
		}		

		private DateTime _fechaAviso = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaAviso
		{
			get{return _fechaAviso;}

			set	{_fechaAviso = value ;}
		}		

		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaVencimiento
		{
			get{return _fechaVencimiento;}
			set	{_fechaVencimiento = value ;}
		}		

		//Variables de configuracion de la vista

	
		private bool _habilitarContraseña =false;
		public bool HabilitarContraseña 
		{
			get{return _habilitarContraseña ;}
			set {_habilitarContraseña=value;}
		}
		private bool _permiteEditarTipo =false;
		public bool PermiteEditarTipo 
		{
			get{return _permiteEditarTipo ;}
			set {_permiteEditarTipo=value;}
		}
		private bool _permiteEditarFecha =false;
		public bool PermiteEditarFecha 
		{
			get{return _permiteEditarFecha ;}
			set {_permiteEditarFecha=value;}
		
		}
		private bool _permiteEditarResponsable =false;
		public bool PermiteEditarResponsable 
		{
			get{return _permiteEditarResponsable ;}
			set {_permiteEditarResponsable=value;}
		}
		private bool _permiteEditarSubTipo =false;
		public bool PermiteEditarSubTipo 
		{
			get{return _permiteEditarSubTipo ;}
			set {_permiteEditarSubTipo=value;}
		}

		private bool _permiteEditarEstado =false;
		public bool PermiteEditarEstado 
		{
			get{return _permiteEditarEstado ;}
			set {_permiteEditarEstado=value;}
		}
		private bool _permiteEditarTitulo =false;
		public bool PermiteEditarTitulo 
		{
			get{return _permiteEditarTitulo ;}
			set {_permiteEditarTitulo=value;}
			
		}
		private bool _permiteEditarFechaAviso =false;
		public bool PermiteEditarFechaAviso
		{
			get{return _permiteEditarFechaAviso ;}
			set {_permiteEditarFechaAviso=value;}
					
		}
		private bool _permiteEditarFechaVencimiento =false;
		public bool PermiteEditarFechaVencimiento
		{
			get{return _permiteEditarFechaVencimiento ;}
			set {_permiteEditarFechaVencimiento=value;}
			
		}
		private bool _permiteEditarCuenta =false;
		public bool PermiteEditarCuenta
		{
			get{return _permiteEditarCuenta ;}
			set {_permiteEditarCuenta=value;}
		
		}
		private bool _permiteEditarObservaciones =true;
		public bool PermiteEditarObservaciones
		{
			get{return _permiteEditarObservaciones ;}
			set {_permiteEditarObservaciones=value;}
			
		}
		private DataTable _estados;
		private DataTable _estadosProveedores;
		private tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable _tipos;
		private tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable _subTipos;
		private sy_UsuariosDataset.sy_UsuariosDataTable  _usuarios;
		private tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable _tiposProveedores;
		private tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable _subTiposProveedores;

		private string _idEstado = string.Empty;
		public string IdEstado
		{
			get{return _idEstado;}
			set
			{
				if(_idEstado != value)
				{
					_idEstado = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _idEstadoProveedor = string.Empty;
		public string IdEstadoProveedor
		{
			get{return _idEstadoProveedor;}
			set
			{
				if(_idEstadoProveedor != value)
				{
					_idEstadoProveedor = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}
		private string _idUsuario;
		public string IdUsuario
		{
			get{return _idUsuario;}
			set
			{
				if(_idUsuario != value)
				{
					_idUsuario = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}
		private string _idTipo = string.Empty;
		public string IdTipo
		{
			get{return _idTipo;}
			set
			{
				if(_idTipo != value)
				{
					_idTipo = value;
					GetSubTipos(_idTipo);
					if(TiposHasChanged != null)
						TiposHasChanged(this,new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _idTipoProveedor = string.Empty;
		public string IdTipoProveedor
		{
			get{return _idTipoProveedor;}
			set
			{
				if(_idTipoProveedor != value)
				{
					_idTipoProveedor = value;
					GetSubTipos(_idTipoProveedor);
					if(TiposHasChanged != null)
						TiposHasChanged(this,new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}
		
		private string _idSubTipo = string.Empty;
		public string IdSubTipo
		{
			get{return _idSubTipo;}
			set
			{
				if(_idSubTipo != value)
				{
					_idSubTipo = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}

		private string _idSubTipoProveedor = string.Empty;
		public string IdSubTipoProveedor
		{
			get{return _idSubTipoProveedor;}
			set
			{
				if(_idSubTipoProveedor != value)
				{
					_idSubTipoProveedor = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
			}
		}
		private string _titulo = string.Empty;
		public string Titulo
		{
			get{return _titulo;}
			set { _titulo = value; }
		}

		private string _observaciones = string.Empty;
		public string Observaciones
		{
			get{return _observaciones;}
			set { _observaciones = value; }
		}


		//private bool _herramientaFormatoVisible = false;
		public bool HerramientaFormatoVisible 
		{
			get 
			{				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "HerramientaFormatoVisible";
				return Variables.GetValueBool(variable);
			}
		}

		public System.Data.DataTable Estados 
		{
			get {return _estados;}
		}

		public System.Data.DataTable EstadosProveedores 
		{
			get {return _estadosProveedores;}
		}

		public System.Data.DataTable Tipos
		{
			get {return _tipos;}
		}

		public System.Data.DataTable TiposProveedores
		{
			get {return _tiposProveedores;}
		}

		public System.Data.DataTable SubTipos
		{
			get {return _subTipos;}
		}
		
		public System.Data.DataTable SubTiposProveedores 
		{
			get {return _subTiposProveedores;}
		}

		public System.Data.DataTable Usuarios
		{
			get {return _usuarios;}
		}
		public int CantidadSubTipos 
		{
			get 
			{
				string Proceso = this._processParent.Process.ProcessName;
				if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
					return _subTipos.Rows.Count; 
				else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
					return _subTiposProveedores.Rows.Count; 
				else
					return 0;
			}
		}	

		private string _idCuentaObservacion = "";
		public string IdCuentaObservacion 
		{
			get 
			{
				return _idCuentaObservacion;
			}
			set  
			{
				_idCuentaObservacion = value;
			}
		}
		private string _idProveedorObservacion = "";
		public string IdProveedorObservacion 
		{
			get 
			{
				return _idProveedorObservacion;
			}
			set  
			{
				_idProveedorObservacion = value;
			}
		}

		#endregion

		#region Métodos públicos
		public void GetSubTipos(string padre)
		{
			string Proceso = this._processParent.Process.ProcessName;
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				_subTipos = tsa_CuentasObservacionesTipos.GetListSubTiposPerfil(padre, "Add").tsa_CuentasObservacionesTipos;			
				if (_subTipos.Rows.Count == 1)
				{
					_idSubTipo = Convert.ToString(_subTipos.Rows[0]["IdCuentaObservacionTipo"]);
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
				if (_subTipos.Rows.Count >= 1)
				{
					DataRow row = _subTipos.NewRow();					
					row["IdCuentaObservacionTipo"] = String.Empty;
					row["Descripcion"] = String.Empty;
					_subTipos.Rows.Add(row);
				}
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				_subTiposProveedores = tpu_ProveedoresObservacionesTipos.GetListSubTiposPerfil(padre, "Add").tpu_ProveedoresObservacionesTipos;			
				if (_subTiposProveedores.Rows.Count == 1)
				{
					_idSubTipoProveedor = Convert.ToString(_subTiposProveedores.Rows[0]["IdProveedorObservacionTipo"]);
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
				}
				if (_subTiposProveedores.Rows.Count >= 1)
				{
					DataRow row = _subTiposProveedores.NewRow();					
					row["IdProveedorObservacionTipo"] = String.Empty;
					row["Descripcion"] = String.Empty;
					_subTiposProveedores.Rows.Add(row);
				}

			}
		}

		public void GetObservacion()
		{
			string Proceso = this._processParent.Process.ProcessName;
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				if (_idCuentaObservacion != String.Empty)
				{
					_row = businessrules.tsa_CuentasObservaciones.GetByPk(_idCuentaObservacion);
					_codigoCuenta = businessrules.tsa_Cuentas.GetByPk(_row.IdCuenta).Codigo;
					_titulo = _row.Titulo;
					_observaciones = _row.Observacion;
					_fecha = _row.Fecha;
					_fechaAviso = _row.FechaAviso;
					_fechaVencimiento = _row.FechaVencimiento;				
					_idTipo = _row.IdCuentaObservacionTipo;
					_idSubTipo = _row.IdCuentaObservacionSubTipo;
					_idEstado = _row.IdCuentaObservacionEstado;		
					this.GetSubTipos(_idTipo);
				}
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				if (_idProveedorObservacion != String.Empty)
				{
					_rowProveedor = businessrules.tpu_ProveedoresObservaciones.GetByPk(_idProveedorObservacion);
					_idProveedor = _rowProveedor.IdProveedor;
					_titulo = _rowProveedor.Titulo;
					_observaciones = _rowProveedor.Observacion;
					_fecha = _rowProveedor.Fecha;
					_fechaAviso = _rowProveedor.FechaAviso;
					_fechaVencimiento = _rowProveedor.FechaVencimiento;				
					_idTipoProveedor = _rowProveedor.IdProveedorObservacionTipo;
					_idSubTipoProveedor = _rowProveedor.IdProveedorObservacionSubTipo;
					_idEstadoProveedor = _rowProveedor.IdProveedorObservacionEstado;		
					this.GetSubTipos(_idTipoProveedor);
				}
			}
	}

		#endregion
		#region Métodos privados		
		private void GetSubTipos()
		{
			string Proceso = this._processParent.Process.ProcessName;
            if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))			
			{
				_subTipos = tsa_CuentasObservacionesTipos.GetListSubTiposPerfil(_idTipo, "Add").tsa_CuentasObservacionesTipos;			
				if (_subTipos.Rows.Count == 1)
				{
					_idSubTipo = Convert.ToString(_subTipos.Rows[0]["IdCuentaObservacionTipo"]);
				}
				else _idSubTipo = string.Empty;		
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				_subTiposProveedores = tpu_ProveedoresObservacionesTipos.GetListSubTiposPerfil(_idTipoProveedor, "Add").tpu_ProveedoresObservacionesTipos;			
				if (_subTiposProveedores.Rows.Count == 1)
				{
					_idSubTipoProveedor = Convert.ToString(_subTiposProveedores.Rows[0]["IdProveedorObservacionTipo"]);
				}
				else _idSubTipoProveedor = string.Empty;		
			}

		}

		#endregion

		public event EventHandler TiposHasChanged;
	}
}


