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
	/// Descripción breve de ABMLocalidades.
	/// </summary>
	public class ABMLocalidades:ITask,IPersistentTask
	{
		public ABMLocalidades()
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
		private DataTable _paises;
		//Variables de bd q necesita la vista para configurarse, por ejemplo
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Abm Cuentas Observaciones Estados";
		private bool _preguntarAlCancelar = false;
		//Valida mismo codigo postal en una pcia
		private bool _validarCodigoPostalProvincia=false;
		//Valida mismo codigo postal o nombre en una pcia
		private bool _validarNombrePais=false;
		//Valida mismo codigo postal en pais
		private bool _validarCodigoPostalPais=false;
		//Valida mismo nombre localidad en provincia
		private bool _validarNombreProvincia=false;
		//Operacion q se ejecuta
		private string _operacion=string.Empty;
		private long _idPais=long.MinValue;
		private long _idProvincia=long.MinValue;
		private string _idLocalidad=string.Empty;
		private string _codigoPostal = string.Empty;
		private string _nombreLocalidad = string.Empty;
		private long _idProvinciaAnterior=long.MinValue;
		//private long _idPaisEdicion=long.MinValue;
		private long _idPaisDB=long.MinValue;
		private long _idProvinciaDB=long.MinValue;
		private string _nombreLocalidadDB = string.Empty;
		private string _codigoPostalDB = string.Empty;
				
		private mz.erp.commontypes.data.tsh_LocalidadesDataset _data = new mz.erp.commontypes.data.tsh_LocalidadesDataset();

		public mz.erp.commontypes.data.tsh_LocalidadesDataset data
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
		private mz.erp.commontypes.data.tsh_ProvinciasLocalidadesDataset _dataPL = new mz.erp.commontypes.data.tsh_ProvinciasLocalidadesDataset();
	
		public mz.erp.commontypes.data.tsh_ProvinciasLocalidadesDataset dataPL
		{
			get
			{
				return _dataPL;
			}
			set
			{
				_dataPL = value;
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
		
		public bool ValidarCodigoPostalProvincia
		{
			get
			{
				return _validarCodigoPostalProvincia;
			}
			set
			{
				_validarCodigoPostalProvincia = value;
			}
		}
		public bool ValidarNombrePais
		{
			get
			{
				return _validarNombrePais;
			}
			set
			{
				_validarNombrePais = value;
			}
		}
		public bool ValidarCodigoPostalPais
		{
			get
			{
				return _validarCodigoPostalPais;
			}
			set
			{
				_validarCodigoPostalPais = value;
			}
		}
		public bool ValidarNombreProvincia
		{
			get
			{
				return _validarNombreProvincia;
			}
			set
			{
				_validarNombreProvincia = value;
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
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		public long IdProvincia
		{
			get{return _idProvincia;}
			set{_idProvincia = value;}
		}
		
		/*public long IdPaisEdicion
		{
			get{return _idPaisEdicion;}
			set{_idPaisEdicion = value;}
		}*/
		public long IdProvinciaAnterior
		{
			get{return _idProvinciaAnterior;}
			set{_idProvinciaAnterior = value;}
		}
		
		public long IdPais
		{
			get{return _idPais;}
			set{_idPais = value;}
		}
		public string IdLocalidad
		{
			get{return _idLocalidad;}
			set{_idLocalidad = value;}
		}

		public string CodigoPostal
		{
			get{return _codigoPostal;}
			set{_codigoPostal=value;}
		
		}
		public string NombreLocalidad
		{
			get{return _nombreLocalidad;}
			set{ _nombreLocalidad=value;}
		}
		public long IdPaisDB
		{
			get{return _idPaisDB;}
			set{_idPaisDB=value;}
		}
		public long IdProvinciaDB
		{
			get{return _idProvinciaDB;}
			set{_idProvinciaDB=value;}
		}
		public string NombreLocalidadDB
		{
			get{return _nombreLocalidadDB;}
			set{ _nombreLocalidadDB=value;}
		}
		public string CodigoPostalDB
		{
			get{return _codigoPostalDB;}
			set{_codigoPostalDB=value;}
		
		}
		private bool HayCambios // return true --> Valida; return false --> NO Valida.
		{
			get
			{	
				if ( this.Operacion.Equals("modificar") )
				{
					if (!this.IdPaisDB.Equals(this.IdPais))
						return true;
				
					if (!this.IdProvinciaDB.Equals(this.IdProvincia))
						return true;

					if (!this.NombreLocalidadDB.Equals(this.NombreLocalidad))
						return true;

					if (!this.CodigoPostalDB.Equals(this.CodigoPostal))
						return true;
					
					return false;
				}
				return true;
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
			
			//Es para ver si valida existencia d
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.CodigoPostalProvincia";
			_validarCodigoPostalProvincia=Variables.GetValueBool(variable);
			
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.NombrePais";
			_validarNombrePais=Variables.GetValueBool(variable);

			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.CodigoPostalPais";
			_validarCodigoPostalPais=Variables.GetValueBool(variable);

			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.NombreProvincia";
			_validarNombreProvincia=Variables.GetValueBool(variable);

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
			//Tengo q ver si es un alta o esta editando
			if (this.Operacion=="new")
			{
				//Es un alta de estado
				tsh_LocalidadesDataset.tsh_LocalidadesRow _row = _data.tsh_Localidades.Newtsh_LocalidadesRow();
				_row = tsh_Localidades.SetRowDefaultValues( _row);
				_row.Descripcion = this.NombreLocalidad;
				_row.CodigoPostal = this.CodigoPostal;
				_data.Tables[0].Rows.Add(_row);	
				//Agrega la row al otro dataset
				tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow _rowpl=_dataPL.tsh_ProvinciasLocalidades.Newtsh_ProvinciasLocalidadesRow();
				_rowpl=tsh_ProvinciasLocalidades.SetRowDefaultValues(_rowpl);
				_rowpl.IdProvincia = IdProvincia;
				_dataPL.Tables[0].Rows.Add(_rowpl);	
			}
			else 
			{
				tsh_LocalidadesDataset.tsh_LocalidadesRow _row = tsh_Localidades.GetByPk(this.IdLocalidad);
				_row.Descripcion = this.NombreLocalidad;
				_row.CodigoPostal = this.CodigoPostal;
				data.Tables[0].ImportRow(_row);
				//Agrega la row al dataset de provincia localidades
				tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow _rowpl=tsh_ProvinciasLocalidades.GetByPk(this.IdProvinciaAnterior,this.IdLocalidad);
				_rowpl.IdProvincia = IdProvincia;
				_dataPL.Tables[0].ImportRow(_rowpl);	
				/*tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row=tsa_CuentasObservacionesEstados.GetByPk(_idCuentaObservacionEstado);
				_row["descripcion"] = this._descripcion;
				_row["activo"] = this._activo;
				//Ojo q el estado de la row tenga estado added.() row estate
				_data.Tables[0].ImportRow(_row);*/	
				
			}
					
			
		}
		
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

				_replication = GenerateReplication();
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				dataaccess.tsh_Localidades.Replicacion = _replication;
				dataaccess.tsh_Localidades.Update( (tsh_LocalidadesDataset.tsh_LocalidadesDataTable) _data.Tables[0],trx);
			
				tsh_LocalidadesDataset.tsh_LocalidadesRow _rowLoc = (tsh_LocalidadesDataset.tsh_LocalidadesRow)_data.Tables[0].Rows[0];
				tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow _rowpl=(tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow)_dataPL.Tables[0].Rows[0];
				//No hace falta el add ni el import
				_rowpl.IdLocalidad = Convert.ToString(_rowLoc["IdLocalidad"]);
				dataaccess.tsh_ProvinciasLocalidades.Replicacion = _replication;
				dataaccess.tsh_ProvinciasLocalidades.Update( (tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable) _dataPL.Tables[0],trx);
			
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Metodos Publicos
		public void Localidad(string idLocalidad)
		{
			tsh_LocalidadesDataset.tsh_LocalidadesRow _row =tsh_Localidades.GetByPk(idLocalidad);
			if (_row!=null)
			{
				this.CodigoPostal=Convert.ToString(_row["CodigoPostal"]);
				this.NombreLocalidad=Convert.ToString(_row["Descripcion"]);
			}		
		}
		public bool ValidarDatosLocalidad(string Localidad)
		{
        	if ( this.Operacion.Equals("modificar") && Localidad.Equals(this.NombreLocalidad) )			
			{
				return true;				
			}
			else
			{
				if (!Localidad.Equals(string.Empty))
				{
					DataSet DataSetLoc = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(string.Empty, long.MinValue, long.MinValue, string.Empty, Localidad);
					if (DataSetLoc.Tables[0].Rows.Count>0 )
						return false;
				}
				return true;
			}
		}
		public bool ValidarDatosCP(string CP)
		{
			if ( this.Operacion.Equals("modificar") && CP.Equals(this.CodigoPostal) )			
			{
				return true;				
			}
			else
			{
				if (!CP.Equals(string.Empty))
				{
					DataSet DataSetLoc = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(string.Empty, long.MinValue, long.MinValue, CP, string.Empty);
					if (DataSetLoc.Tables[0].Rows.Count>0 )
						return false;
				}
				return true;
			}
		}

		#endregion

		private void ValidarDatos()
		{
			_errores.Clear();

			CodigoPostal=CodigoPostal.Trim();
			if (CodigoPostal.Equals(string.Empty))
			{
				_errores.Add( new ItemDatasetError( "Localidad","Codigo Postal","El campo no puede estar vacío") );
			}
			
			NombreLocalidad=NombreLocalidad.Trim();
			if (NombreLocalidad.Equals(string.Empty))
			{
				_errores.Add( new ItemDatasetError( "Localidad","Nombre Localidad","El campo no puede estar vacío") );
			}
		
			if (this.HayCambios)
			{
				// Pudo haberse modificado el Pais, Pcia, Localidad o CP.
				// Valida CP
				if (_validarCodigoPostalPais)
				{
					DataSet DataSetLoc = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(/*IdLocalidad*/ string.Empty, long.MinValue, IdPais, CodigoPostal, string.Empty);
					if ( this.Operacion.Equals("modificar") && this.CodigoPostalDB.Equals(this.CodigoPostal) )
					{
						if (DataSetLoc.Tables[0].Rows.Count>1 ) // Al menos existe 1 reg, el actual a modificar!
							_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en el pais con ese código postal") );	
					}
					else
					{
						if (DataSetLoc.Tables[0].Rows.Count>0 )
							_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en el pais con ese código postal") );	
					}
				}
				else
				{
					if (_validarCodigoPostalProvincia)
					{
						DataSet DataSetLoc1 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(/*IdLocalidad*/ string.Empty, IdProvincia, long.MinValue, CodigoPostal, string.Empty);
						if ( this.Operacion.Equals("modificar") && this.CodigoPostalDB.Equals(this.CodigoPostal) )
						{
							if (DataSetLoc1.Tables[0].Rows.Count>1 )
								_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en la provincia con ese código postal") );	
						}
						else
						{
							if (DataSetLoc1.Tables[0].Rows.Count>0 )
								_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en la provincia con ese código postal") );	
						}
					}
				}
			
				// Valida Localidad
				if (_validarNombrePais)
				{
					DataSet DataSetLoc2 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(/*IdLocalidad*/ string.Empty, long.MinValue, IdPais, string.Empty, NombreLocalidad);
					if ( this.Operacion.Equals("modificar") && this.NombreLocalidadDB.Equals(this.NombreLocalidad) )
					{
						if (DataSetLoc2.Tables[0].Rows.Count>1 )
							_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en el pais con ese nombre") );		
					}					
					else
					{
						if (DataSetLoc2.Tables[0].Rows.Count>0 )
							_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en el pais con ese nombre") );		
					}
				}
				else
				{
					if (_validarNombreProvincia)
					{
						DataSet DataSetLoc3 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(/*IdLocalidad*/ string.Empty, IdProvincia, long.MinValue, string.Empty, NombreLocalidad);
						if ( this.Operacion.Equals("modificar") && this.NombreLocalidadDB.Equals(this.NombreLocalidad) )
						{
							if (DataSetLoc3.Tables[0].Rows.Count>1 )
								_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en la provincia con ese nombre") );		
						}
						else
						{
							if (DataSetLoc3.Tables[0].Rows.Count>0 )
								_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en la provincia con ese nombre") );		
						}
					}
				}
			}
			#region Validacion anterior - deprecated
			/*//Si es un alta no tiene q haber otra localidad con ese codigo postal.			
			if (_validarCodigoPostalPais)
			{
				DataSet DataSetLoc = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(IdLocalidad, long.MinValue,IdPais, CodigoPostal, string.Empty);
				if (DataSetLoc.Tables[0].Rows.Count>0 )
				{
					_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en el pais con ese código postal") );	
							
				}
				if (_validarCodigoPostalProvincia)
				{
					DataSet DataSetLoc1 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(IdLocalidad, IdProvincia, long.MinValue,CodigoPostal, string.Empty);
					if (DataSetLoc1.Tables[0].Rows.Count>0 )
					{
						_errores.Add( new ItemDatasetError( "Localidades","Código Postal","Ya existe otra localidad en la provincia con ese código postal") );	
							
					}
				}
				if (_validarNombrePais)
				{
					DataSet DataSetLoc2 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(IdLocalidad,long.MinValue,IdPais,string.Empty, NombreLocalidad);
					if (DataSetLoc2.Tables[0].Rows.Count>0 )
					{
						_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en el pais con ese nombre") );		
							
					}
				}
				if (_validarNombreProvincia)
				{
					DataSet DataSetLoc3 = mz.erp.businessrules.tsh_Localidades.ValidarExistenciaLocalidad(IdLocalidad,IdProvincia,long.MinValue,string.Empty, NombreLocalidad);
					if (DataSetLoc3.Tables[0].Rows.Count>0 )
					{
						_errores.Add( new ItemDatasetError( "Localidades","Nombre","Ya existe otra localidad en la provincia con ese nombre") );		
							
					}
				}
			
		
			}*/
			#endregion
		}

		
		
	}
}
