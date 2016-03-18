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
	/// Descripción breve de ABMVariables.
	/// </summary>
	public class ABMVariables: ITask, IPersistentTask
	{
		#region Constructores
		public ABMVariables()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private string _estado = "ALTA";
		private sy_VariablesDataset _dataGenericas = new sy_VariablesDataset();
		private sy_VariablesUsuariosDataset _dataUsuarios = new sy_VariablesUsuariosDataset();
		private sy_VariablesPerfilesDataset _dataPerfiles = new sy_VariablesPerfilesDataset();
		private sy_VariablesPuestosDataset _dataPuestos = new sy_VariablesPuestosDataset();
		#endregion

		#region Eventos
		public event System.EventHandler VariablesHasChanged;
		#endregion

		#region Variables Públicas

		private object _searchObjectListener;
		public object SearchObjectListener
		{
			get {return _searchObjectListener;}
			set {_searchObjectListener = value;}

		}

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
		
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {
				_preguntarAlCancelar = mz.erp.businessrules.Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
				return _preguntarAlCancelar ;
			}
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

		private string _idVariable = string.Empty;
		public string IdVariable 
		{
			get{return _idVariable;}
			set
			{
				_idVariable = value;
			}
		}

		private string _idVariableOriginal = string.Empty;
		public string IdVariableOriginal 
		{
			get{return _idVariableOriginal;}
		}

		private string _idVariableAlta = string.Empty;
		public string IdVariableAlta 
		{
			get{return _idVariableAlta;}
			set
			{
				_idVariableAlta = value;
			}
		}

		private string _descripcionAlta = string.Empty;
		public string DescripcionAlta 
		{
			get{return _descripcionAlta;}
			set
			{
				_descripcionAlta = value;
			}
		}
		
		private string _valorAlta = string.Empty;
		public string ValorAlta 
		{
			get{return _valorAlta;}
			set
			{
				_valorAlta = value;
			}
		}
		
		private string _tipoAlta = string.Empty;
		public string TipoAlta 
		{
			get{return _tipoAlta;}
			set
			{
				_tipoAlta = value;
			}
		}
		
		ArrayList _usuarios = new ArrayList();
		public ArrayList Usuarios
		{
			get 
			{
				return _usuarios;
			}
		}

		ArrayList _usuariosSeleccionados = new ArrayList();
		public ArrayList UsuariosSeleccionados
		{
			set 
			{
				_usuariosSeleccionados = value;
			}
		}

		ArrayList _perfiles = new ArrayList();
		public ArrayList Perfiles
		{
			get 
			{
				return _perfiles;
			}
		}

		ArrayList _perfilesSeleccionados = new ArrayList();
		public ArrayList PerfilesSeleccionados
		{
			set 
			{
				_perfilesSeleccionados = value;
			}
		}

		ArrayList _puestos = new ArrayList();
		public ArrayList Puestos
		{
			get 
			{
				return _puestos;
			}
		}

		ArrayList _puestosSeleccionados = new ArrayList();
		public ArrayList PuestosSeleccionados
		{
			set 
			{
				_puestosSeleccionados = value;
			}
		}

		private ArrayList _variables = new ArrayList();
		public ArrayList Variables
		{
			get {return _variables;}
		}

		public string Estado 
		{
			get{return _estado;}
		}

		private ArrayList _variablesSeleccionadas = new ArrayList();
		public ArrayList VariablesSeleccionadas
		{
			get {return _variablesSeleccionadas;}
			set 
			{
				_variablesSeleccionadas = value;
			}
		}

		private bool _modificacionSimple = false;
		public bool ModificacionSimple
		{
			get {return _modificacionSimple;}
			set 
			{
				_modificacionSimple = value;
			}
		}
		#endregion

		#region Métodos Privados
		private void SetCombosData()
		{
			DataTable usuariosDT = sy_Usuarios.GetList().sy_Usuarios;
			foreach (System.Data.DataRow row in usuariosDT.Rows)
			{
				string id = row["IdUsuario"].ToString();
				string nombre = row["Nombre"].ToString();
				UsuarioView us = new UsuarioView(id, nombre);
				_usuarios.Add(us);

			}

			DataTable perfilesDT = sy_Perfiles.GetList().sy_Perfiles;
			foreach (System.Data.DataRow row in perfilesDT.Rows)
			{
				long id = (long)row["IdPerfil"];
				string descripcion = row["Descripcion"].ToString();
				PerfilView perfil = new PerfilView(id, descripcion);
				_perfiles.Add(perfil);
			}

			DataTable puestosDT = sy_Puestos.GetList().sy_Puestos;
			foreach (System.Data.DataRow row in puestosDT.Rows)
			{
				long id = (long)row["IdPuesto"];
				string descripcion = row["Descripcion"].ToString();
				PuestoView puesto = new PuestoView(id, descripcion);
				_puestos.Add(puesto);
			}


		}

		
		private Variable getVariable(ArrayList variables, string IdVariable, string IdUsuario, long IdPerfil, long IdPuesto, string TipoVariable)
		{
			Variable var = null;
			int i = 0;
			while(var == null && i < variables.Count)
			{
				Variable v = (Variable)variables[i];
				if(v.IdVariableOriginal.Equals(IdVariable) && v.TipoVariable.Equals(TipoVariable))
				{
					switch(TipoVariable)
					{
						case "GENERICA":
						{
							var = v;
							break;
						}
						case "USUARIO":
						{
							if(v.IdUsuario.Equals(IdUsuario))
                                var = v;
							break;
						}
						case "PERFIL":
						{
							if(v.IdPerfil.Equals(IdPerfil))
								var = v;
							break;
						}
						case "PUESTO":
						{
							if(v.IdPuesto.Equals(IdPuesto))
								var = v;
							break;
						}
					}
				}
				i++;
			}
			return var;
		}

		private string GetValorDefault(string Tipo)
		{
			string valorDefault = string.Empty;
			switch(Tipo.ToUpper())
			{
				case "SYSTEM.STRING":
				{
					valorDefault = string.Empty;
					break;
				}
				case "SYSTEM.BOOLEAN":
				{
					valorDefault = "false";
					break;
				}
				case "SYSTEM.DECIMAL":
				{
					valorDefault = "0";
					break;
				}
				case "SYSTEM.INTEGER":
				{
					valorDefault = "0";
					break;
				}
				case "SYSTEM.INT32":
				{
					valorDefault = "0";
					break;
				}
				case "SYSTEM.INT":
				{
					valorDefault = "0";
					break;
				}
				case "SYSTEM.LONG":
				{
					valorDefault = "0";
					break;
				}
			}
			return valorDefault;
		}
		#endregion

		#region Métodos Públicos

		public void AddVariable(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string Estado, string TipoVariable)
		{
			Variable var = getVariable(_variables, IdVariableOriginal, IdUsuario, IdPerfil, IdPuesto, TipoVariable);
			if(Valor.Equals(string.Empty) && !Tipo.Equals(string.Empty))
			{
				Valor = this.GetValorDefault(Tipo);
			}
			if(var == null)
			{
				var = new Variable(IdVariableOriginal, IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, Estado, TipoVariable);
				_variables.Add(var);
			}
			else
			{
				var.IdVariable = IdVariable;
				var.Descripcion = Descripcion;
				var.IdTipoVariable = Tipo;			
				var.Valor = Valor;
			}
			if(VariablesHasChanged != null)
				VariablesHasChanged(this, new EventArgs());	
		}

		public void AddVariableModif(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string TipoVariable)
		{
			Variable var = getVariable(_variablesSeleccionadas, IdVariableOriginal, IdUsuario, IdPerfil, IdPuesto, TipoVariable);
			if(var == null) //Es un alta
			{
				this.AddVariable(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, "NEW", TipoVariable);
			}
			else //ES una modificacion
			{
				if(Valor.Equals(string.Empty)) //si no ingreso valor
				{
					if(var.Valor.Equals(string.Empty) && !Tipo.Equals(string.Empty))
					{ //si el valor de la variable es nulo le asigno un valor por default de acuerdo a su tipo
						Valor = this.GetValorDefault(Tipo);
					}
					else if(!var.Valor.Equals(string.Empty) && !Tipo.ToUpper().Equals("SYSTEM.STRING"))
					{ //si el valor de la variable no es nulo le dejo el valor q tenia
						Valor = var.Valor;
					}
				}

				this.AddVariable(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, "MODIF", TipoVariable);
			}
		}

		public void AddVariableDeleted(string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string TipoVariable)
		{
			Variable var = getVariable(_variablesSeleccionadas, IdVariableOriginal, IdUsuario, IdPerfil, IdPuesto, TipoVariable);
			if(var != null) //Si existe en la BD
				this.AddVariable(IdVariable, Descripcion, Tipo, Valor, IdUsuario, IdPerfil, IdPuesto, Usuario, Perfil, Puesto, "DEL", TipoVariable);
		}

		public bool EsAlta()
		{
			return Estado.Equals("ALTA");
		}
		
		public string GetValorVariable(string IdVariableOriginal, string IdUsuario, long IdPerfil, long IdPuesto, string TipoVariable)
		{
			string valor = string.Empty;
			Variable var = getVariable(_variablesSeleccionadas, IdVariableOriginal, IdUsuario, IdPerfil, IdPuesto, TipoVariable);
			if(var != null)
				valor = var.Valor;
			return valor;
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
			if (_searchObjectListener != null && _searchObjectListener.GetType() == typeof(mz.erp.businessrules.ConsultarVariables) )
			{
				ConsultarVariables objeto = (ConsultarVariables)_searchObjectListener;
				objeto.RefreshData();
			}
			
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
			if(!IdVariable.Equals(string.Empty))
			{
				_estado = "MODIF";
				_idVariableOriginal = IdVariable;
			}
			SetCombosData();
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
			int i = 0;
			while(isvalid && i < _variables.Count)
			{
				Variable var = (Variable) _variables[i];
				if(var.IdTipoVariable.Equals(string.Empty))
				{
					_errores.Add( new ItemDatasetError( "Tipo","Tipo","Debe ingresar el tipo de la variable"));
					isvalid = false;
				}
				if(var.Valor.Equals(string.Empty) && !var.IdTipoVariable.ToUpper().Equals("SYSTEM.STRING"))
				{
					_errores.Add( new ItemDatasetError( "Valor","Valor","El valor de la variable no puede ser nulo"));
					isvalid = false;
				}
				i++;
			}

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
			return string.Empty;
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
			foreach(Variable var in _variables)
			{
				var.Commit(_dataGenericas, _dataUsuarios, _dataPerfiles, _dataPuestos);
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

			dataaccess.sy_Variables.Update(_dataGenericas.sy_Variables, trx);

			dataaccess.sy_VariablesUsuarios.Update(_dataUsuarios.sy_VariablesUsuarios, trx);

			dataaccess.sy_VariablesPerfiles.Update(_dataPerfiles.sy_VariablesPerfiles, trx);

			dataaccess.sy_VariablesPuestos.Update(_dataPuestos.sy_VariablesPuestos, trx);
				
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
			
		}
		
		#endregion
	}
}
