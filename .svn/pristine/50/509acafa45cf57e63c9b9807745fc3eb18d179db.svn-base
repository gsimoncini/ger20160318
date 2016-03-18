// Se comento codigo duplicado (en teoria). Se dejo lo que estaba en el CVS

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
	/// Descripción breve de ConsultarVariables.
	/// </summary>
	public class ConsultarVariables: ITask, IPersistentTask
	{

		#region Constructores
		public ConsultarVariables()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private DataTable _result = new DataTable();
		private sy_VariablesDataset _dataGenericas = new sy_VariablesDataset();
		private sy_VariablesUsuariosDataset _dataUsuarios = new sy_VariablesUsuariosDataset();
		private sy_VariablesPerfilesDataset _dataPerfiles = new sy_VariablesPerfilesDataset();
		private sy_VariablesPuestosDataset _dataPuestos = new sy_VariablesPuestosDataset();
		private ArrayList _variablesBorradas = new ArrayList();
		#endregion

		#region Eventos
		public event System.EventHandler DataChanged;
		#endregion

		#region Variables Públicas

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

		public DataTable Result
		{
			get{return _result;}
		}

		private string _idVariable = string.Empty;
		public string IdVariable
		{
			get { return _idVariable;}
			set { _idVariable = value;}
		}

		private long _idProceso;
		public long IdProceso
		{
			get { return _idProceso;}
			set { _idProceso = value;}
		}

		private string _procesoSeleccionado = string.Empty;
		public string ProcesoSeleccionado
		{
			get { return _procesoSeleccionado;}
			set { _procesoSeleccionado = value;}
		}

		private bool _byProceso = false;
		public bool ByProceso
		{
			get{return _byProceso;}
			set{_byProceso = value;}
		}

		private long _idTarea;
		public long IdTarea
		{
			get { return _idTarea;}
			set { _idTarea = value;}
		}

		private string _tareaSeleccionada = string.Empty;
		public string TareaSeleccionada
		{
			get { return _tareaSeleccionada;}
			set { _tareaSeleccionada = value;}
		}

		private bool _byTarea = false;
		public bool ByTarea
		{
			get{return _byTarea;}
			set{_byTarea = value;}
		}

		private string _contextoDeBusqueda = string.Empty;
		public string ContextoDeBusqueda
		{
			get { return _contextoDeBusqueda;}
			set { _contextoDeBusqueda = value;}
		}

		private string _contextosDeBusqueda = "Todos,Genérico,Perfil,Usuario,Puesto";
		public string ContextosDeBusqueda 
		{
			get {return _contextosDeBusqueda;}
		}

		private string _contextosDeBusquedaDefault = "Todos";
		public string ContextosDeBusquedaDefault 
		{
			get {return _contextosDeBusquedaDefault;}
		}

		private System.Data.DataRowView _variableSeleccionada;
		public System.Data.DataRowView VariableSeleccionada
		{
			get{return _variableSeleccionada;}
			set{_variableSeleccionada = value;}
		} 

		private string _idVariableSeleccionada;
		public string IdVariableSeleccionada
		{
			get{return _idVariableSeleccionada;}
			set{_idVariableSeleccionada = value;}
		} 

		private bool _seleccionGeneral;
		public bool SeleccionGeneral
		{
			get{return _seleccionGeneral;}
			set{_seleccionGeneral = value;}
		} 
		
		#endregion

		#region Métodos Privados
		#endregion

		#region Métodos Públicos

		public void SearchNow()
		{
			if(ContextoDeBusqueda == null || ContextoDeBusqueda.Equals(string.Empty))
				ContextoDeBusqueda = ContextosDeBusquedaDefault;
			string _variable =string.Empty;
			if(_byTarea && !string.Empty.Equals(_tareaSeleccionada) && _byProceso && !string.Empty.Equals(_procesoSeleccionado))
			{ //Se busca por tarea/proceso
				_variable = "%." + _tareaSeleccionada + "." + _procesoSeleccionado + ".";
			}
			else if(_byTarea && !string.Empty.Equals(_tareaSeleccionada))
			{ //Se busca por tarea
				_variable = "%." + _tareaSeleccionada + ".";
			}
			else if(_byProceso && !string.Empty.Equals(_procesoSeleccionado))
			{ //Se busca por proceso
				_variable = "%." + _procesoSeleccionado+ ".";
			}
			_variable = _variable + _idVariable + "%";
			switch(ContextoDeBusqueda)
			{
				case "Todos":
				{
					_result = mz.erp.businessrules.sy_VariablesEx.GetListByCola(_variable);			
					break;
				}
				case "Genérico":
				{
					_result = mz.erp.businessrules.sy_Variables.GetListByCola(_variable).sy_Variables;			
					break;
				}
				case "Perfil":
				{
					_result = mz.erp.businessrules.sy_VariablesPerfiles.GetListByColaCompleto(_variable);			
					break;
				}
				case "Usuario":
				{
					_result = mz.erp.businessrules.sy_VariablesUsuarios.GetListByColaCompleto(_variable);			
					break;
				}
				case "Puesto":
				{
					_result = mz.erp.businessrules.sy_VariablesPuestos.GetListByColaCompleto(_variable);			
					break;
				}
				default:
				{
					break;
				}
			}
			_result.AcceptChanges();

		}

		public void DeleteVariableSeleccionada()
		{
			Variable var = new Variable(VariableSeleccionada);
			var.Estado = "DEL";
			_variablesBorradas.Add(var);
		}

		public void RefreshData()
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
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
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			_contextosDeBusqueda = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, _taskName, "ContextosDeBusqueda");			
			if(_contextosDeBusqueda == null || _contextosDeBusqueda == string.Empty)	
				_contextosDeBusqueda = Variables.GetValueString("Variables.ContextosDeBusqueda", _contextoDeBusqueda);


			_contextosDeBusquedaDefault = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, _taskName, "ContextosDeBusqueda.Default");			
			if(_contextosDeBusquedaDefault == null || _contextosDeBusquedaDefault == string.Empty)	
				_contextosDeBusquedaDefault = Variables.GetValueString("Variables.ContextosDeBusqueda.Default", _contextosDeBusquedaDefault);

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
			foreach(DataRow row in _result.Rows)
			{
				if(row.RowState.Equals(DataRowState.Modified))
				{//Es una modificacion
					string idVariable = (string)row["IdVariable"];
					string idTipoVariable = (string)row["Tipo"];
					string valor = string.Empty;
					if(row["ValorDefault"] != System.DBNull.Value)
                        valor = (string)row["ValorDefault"];
					string usuario = (string)row["Usuario"];
					string perfil = (string)row["Perfil"];
					string puesto = (string)row["Puesto"];
					if(!usuario.Equals(string.Empty)) //Es una variable de sy_VariablesUsuarios
					{
						string idUsuario = (string)row["IdUsuario"];
						sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU = sy_VariablesUsuarios.GetByPk(idVariable, idUsuario);
						if(rowU != null)
						{
							rowU.Valor = valor;
							_dataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
						}
					}
					else if(!perfil.Equals(string.Empty))//Es una variable de sy_VariablesPerfiles
					{
						long idPerfil = Convert.ToInt64(row["IdPerfil"]);
						sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP = sy_VariablesPerfiles.GetByPk(idVariable, idPerfil);
						if(rowP != null)
						{
							rowP.Valor = valor;
							_dataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
						}
					}
					else if(!puesto.Equals(string.Empty))//Es una variable de sy_VariablesPuestos
					{
						long idPuesto = Convert.ToInt64(row["IdPuesto"]);
						sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowPU = sy_VariablesPuestos.GetByPk(idVariable, Security.IdEmpresa, Security.IdSucursal, idPuesto);
						if(rowPU != null)
						{
							rowPU.Valor = valor;
							_dataPuestos.sy_VariablesPuestos.ImportRow(rowPU);
						}
					}
					else //Es una variable de sy_Variables
					{
						sy_VariablesDataset.sy_VariablesRow rowG =  sy_Variables.GetByPk(idVariable);
						if(rowG != null)
						{
							rowG.ValorDefault = valor;
							rowG.IdTipoVariable = idTipoVariable;
							_dataGenericas.sy_Variables.ImportRow(rowG);

						}
					}

				}
			}

			//Borro las variables eliminadas
			foreach(Variable var in _variablesBorradas)
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
			replication.NombreTabla = "dataaccess.sy_Variables";			
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
//
//using System;
//using System.Data;
//using mz.erp.businessrules.comprobantes;
//using mz.erp.commontypes.data;
//using System.Collections;
//using mz.erp.commontypes;
//using System.Data.SqlClient;
//using mz.erp.dataaccess;
//
//namespace mz.erp.businessrules
//{
//	/// <summary>
//	/// Descripción breve de ConsultarVariables.
//	/// </summary>
//	public class ConsultarVariables: ITask, IPersistentTask
//	{
//
//		#region Constructores
//		public ConsultarVariables()
//		{
//			//
//			// TODO: agregar aquí la lógica del constructor
//			//
//		}
//		#endregion
//
//		#region Variables Privadas
//		private DataTable _result = new DataTable();
//		private sy_VariablesDataset _dataGenericas = new sy_VariablesDataset();
//		private sy_VariablesUsuariosDataset _dataUsuarios = new sy_VariablesUsuariosDataset();
//		private sy_VariablesPerfilesDataset _dataPerfiles = new sy_VariablesPerfilesDataset();
//		private sy_VariablesPuestosDataset _dataPuestos = new sy_VariablesPuestosDataset();
//		private ArrayList _variablesBorradas = new ArrayList();
//		#endregion
//
//		#region Eventos
//		public event System.EventHandler DataChanged;
//		#endregion
//
//		#region Variables Públicas
//
//		private string _textoBotonAnterior = "Anterior";
//		public string TextoBotonAnterior
//		{
//			get 
//			{
//				string valor = String.Empty;
//				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
//				valor = Variables.GetValueString(variable);
//				if (valor == String.Empty)
//				{
//					variable = "Sistema.Interfaz.TextoBotonAnterior";
//					valor = Variables.GetValueString(variable);				
//				}									
//				
//				if (valor == String.Empty) 
//				{
//					return _textoBotonAnterior;
//				}
//				else 
//				{
//					return valor;
//				}							
//			}
//		}
//		private string _textoBotonSiguiente = "Siguiente";
//		public string TextoBotonSiguiente
//		{
//			get 
//			{		
//				string valor = String.Empty;				
//				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
//				valor = Variables.GetValueString(variable);
//				if (valor == String.Empty)
//				{
//					variable = "Sistema.Interfaz.TextoBotonSiguiente";
//					valor = Variables.GetValueString(variable);				
//				}									
//				
//				if (valor == String.Empty) 
//				{
//					return _textoBotonSiguiente;
//				}
//				else 
//				{
//					return valor;
//				}
//			}
//		}
//
//		public DataTable Result
//		{
//			get{return _result;}
//		}
//
//		private string _idVariable = string.Empty;
//		public string IdVariable
//		{
//			get { return _idVariable;}
//			set { _idVariable = value;}
//		}
//
//		private long _idProceso;
//		public long IdProceso
//		{
//			get { return _idProceso;}
//			set { _idProceso = value;}
//		}
//
//		private string _procesoSeleccionado = string.Empty;
//		public string ProcesoSeleccionado
//		{
//			get { return _procesoSeleccionado;}
//			set { _procesoSeleccionado = value;}
//		}
//
//		private bool _byProceso = false;
//		public bool ByProceso
//		{
//			get{return _byProceso;}
//			set{_byProceso = value;}
//		}
//
//		private long _idTarea;
//		public long IdTarea
//		{
//			get { return _idTarea;}
//			set { _idTarea = value;}
//		}
//
//		private string _tareaSeleccionada = string.Empty;
//		public string TareaSeleccionada
//		{
//			get { return _tareaSeleccionada;}
//			set { _tareaSeleccionada = value;}
//		}
//
//		private bool _byTarea = false;
//		public bool ByTarea
//		{
//			get{return _byTarea;}
//			set{_byTarea = value;}
//		}
//
//		private string _contextoDeBusqueda = string.Empty;
//		public string ContextoDeBusqueda
//		{
//			get { return _contextoDeBusqueda;}
//			set { _contextoDeBusqueda = value;}
//		}
//
//		private string _contextosDeBusqueda = "Todos,Genérico,Perfil,Usuario,Puesto";
//		public string ContextosDeBusqueda 
//		{
//			get {return _contextosDeBusqueda;}
//		}
//
//		private string _contextosDeBusquedaDefault = "Todos";
//		public string ContextosDeBusquedaDefault 
//		{
//			get {return _contextosDeBusquedaDefault;}
//		}
//
//		private System.Data.DataRowView _variableSeleccionada;
//		public System.Data.DataRowView VariableSeleccionada
//		{
//			get{return _variableSeleccionada;}
//			set{_variableSeleccionada = value;}
//		} 
//
//		private string _idVariableSeleccionada;
//		public string IdVariableSeleccionada
//		{
//			get{return _idVariableSeleccionada;}
//			set{_idVariableSeleccionada = value;}
//		} 
//
//		private bool _seleccionGeneral;
//		public bool SeleccionGeneral
//		{
//			get{return _seleccionGeneral;}
//			set{_seleccionGeneral = value;}
//		} 
//		
//		#endregion
//
//		#region Métodos Privados
//		#endregion
//
//		#region Métodos Públicos
//
//		public void SearchNow()
//		{
//			if(ContextoDeBusqueda == null || ContextoDeBusqueda.Equals(string.Empty))
//				ContextoDeBusqueda = ContextosDeBusquedaDefault;
//			string _variable =string.Empty;
//			if(_byTarea && !string.Empty.Equals(_tareaSeleccionada) && _byProceso && !string.Empty.Equals(_procesoSeleccionado))
//			{ //Se busca por tarea/proceso
//				_variable = "%." + _tareaSeleccionada + "." + _procesoSeleccionado + ".";
//			}
//			else if(_byTarea && !string.Empty.Equals(_tareaSeleccionada))
//			{ //Se busca por tarea
//				_variable = "%." + _tareaSeleccionada + ".";
//			}
//			else if(_byProceso && !string.Empty.Equals(_procesoSeleccionado))
//			{ //Se busca por proceso
//				_variable = "%." + _procesoSeleccionado+ ".";
//			}
//			_variable = _variable + _idVariable + "%";
//			switch(ContextoDeBusqueda)
//			{
//				case "Todos":
//				{
//					_result = mz.erp.businessrules.sy_VariablesEx.GetListByCola(_variable);			
//					break;
//				}
//				case "Genérico":
//				{
//					_result = mz.erp.businessrules.sy_Variables.GetListByCola(_variable).sy_Variables;			
//					break;
//				}
//				case "Perfil":
//				{
//					_result = mz.erp.businessrules.sy_VariablesPerfiles.GetListByColaCompleto(_variable);			
//					break;
//				}
//				case "Usuario":
//				{
//					_result = mz.erp.businessrules.sy_VariablesUsuarios.GetListByColaCompleto(_variable);			
//					break;
//				}
//				case "Puesto":
//				{
//					_result = mz.erp.businessrules.sy_VariablesPuestos.GetListByColaCompleto(_variable);			
//					break;
//				}
//				default:
//				{
//					break;
//				}
//			}
//			_result.AcceptChanges();
//
//		}
//
//		public void DeleteVariableSeleccionada()
//		{
//			Variable var = new Variable(VariableSeleccionada);
//			var.Estado = "DEL";
//			_variablesBorradas.Add(var);
//		}
//
//		public void RefreshData()
//		{
//			if(DataChanged != null)
//				DataChanged(this, new EventArgs());
//		}
//
//		#endregion
//
//		#region Miembros de ITask
//
//		private string _taskName = string.Empty;			
//		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
//		private ProcessManager _processParent;
//
//		public event System.EventHandler ObjectHasChanged;
//
//		public event System.EventHandler OnTaskBeforeExecute;
//
//		public event System.EventHandler OnTaskAfterExecute;
//
//		public event System.EventHandler OnTaskBeforePrevious;
//
//		public event System.EventHandler OnTaskAfterPrevious;
//
//		public void ListenerTaskDependentChanged(object sender)
//		{
//			
//		}
//
//		public void ListenerAfterExecuteDependentTask(object sender)
//		{
//		}
//
//		public void ListenerBeforeExecuteDependentTask(object sender)
//		{
//			
//		}
//
//		public void Init()
//		{
//			_contextosDeBusqueda = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, _taskName, "ContextosDeBusqueda");			
//			if(_contextosDeBusqueda == null || _contextosDeBusqueda == string.Empty)	
//				_contextosDeBusqueda = Variables.GetValueString("Variables.ContextosDeBusqueda", _contextoDeBusqueda);
//
//
//			_contextosDeBusquedaDefault = Variables.GetValueString(this.GetProcessManagerParent().Process.ProcessName, _taskName, "ContextosDeBusqueda.Default");			
//			if(_contextosDeBusquedaDefault == null || _contextosDeBusquedaDefault == string.Empty)	
//				_contextosDeBusquedaDefault = Variables.GetValueString("Variables.ContextosDeBusqueda.Default", _contextosDeBusquedaDefault);
//
//		}
//
//		public bool IsValidForStartProcess()
//		{
//			_errores.Clear();
//			WorkflowValidator validator = new WorkflowValidator();
//			long IdTarea = Workflow.GetIdTakByName(_taskName);
//			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
//			_errores.AddAll(validator.GetErrors());
//			return IsValid;
//		}
//		
//		public bool IsValid()
//		{			
//			_errores.Clear();
//			bool isvalid = true;
//			return isvalid;
//		}
//
//
//		public bool AllowShow()
//		{
//			return true;
//		}
//		public void FormHasClosed() 
//		{
//		}
//		public ItemsDatasetErrors GetErrors()
//		{
//			return _errores;
//		}
//
//		public string GetWarnings()
//		{
//			return string.Empty;
//		}
//
//		public ProcessManager GetProcessManagerParent()
//		{
//			return _processParent;
//		}
//
//		public void SetProcessManagerParent(ProcessManager processManager)
//		{
//			_processParent = processManager;
//		}
//
//		public string GetTaskName()
//		{
//			return this._taskName;
//		}
//
//		public void SetTaskName(string taskName)
//		{
//			_taskName = taskName;
//		}
//
//		public void Execute()
//		{
//			if(OnTaskBeforeExecute != null)
//				OnTaskBeforeExecute(this, new EventArgs());			
//
//			this.IsValid();
//
//			if(OnTaskAfterExecute != null)
//				OnTaskAfterExecute(this, new EventArgs());
//		}
//
//		public bool AllowPrevious()
//		{
//			return true;
//		}
//
//		public void Previous()
//		{
//			if(OnTaskBeforePrevious != null)
//				OnTaskBeforePrevious(this, new EventArgs());
//			if(OnTaskAfterPrevious != null)
//				OnTaskAfterPrevious(this, new EventArgs());
//		}
//
//		public void ListenerAfterPreviousDependentTask(object sender)
//		{
//			
//		}
//
//		public void ListenerBeforePreviousDependentTask(object sender)
//		{
//			
//		}
//
//		#endregion
//
//		#region Miembros de IPersistentTask
//		public event System.EventHandler OnTaskBeforeFlush;
//		public event System.EventHandler OnTaskAfterFlush;
//
//		public void Commit() 
//		{
//			foreach(DataRow row in _result.Rows)
//			{
//				if(row.RowState.Equals(DataRowState.Modified))
//				{//Es una modificacion
//					string idVariable = (string)row["IdVariable"];
//					string idTipoVariable = (string)row["Tipo"];
//					string valor = (string)row["ValorDefault"];
//					string usuario = (string)row["Usuario"];
//					string perfil = (string)row["Perfil"];
//					string puesto = (string)row["Puesto"];
//					if(!usuario.Equals(string.Empty)) //Es una variable de sy_VariablesUsuarios
//					{
//						string idUsuario = (string)row["IdUsuario"];
//						sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU = sy_VariablesUsuarios.GetByPk(idVariable, idUsuario);
//						if(rowU != null)
//						{
//							rowU.Valor = valor;
//							_dataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
//						}
//					}
//					else if(!perfil.Equals(string.Empty))//Es una variable de sy_VariablesPerfiles
//					{
//						long idPerfil = Convert.ToInt64(row["IdPerfil"]);
//						sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP = sy_VariablesPerfiles.GetByPk(idVariable, idPerfil);
//						if(rowP != null)
//						{
//							rowP.Valor = valor;
//							_dataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
//						}
//					}
//					else if(!puesto.Equals(string.Empty))//Es una variable de sy_VariablesPuestos
//					{
//						long idPuesto = Convert.ToInt64(row["IdPuesto"]);
//						sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowPU = sy_VariablesPuestos.GetByPk(idVariable, Security.IdEmpresa, Security.IdSucursal, idPuesto);
//						if(rowPU != null)
//						{
//							rowPU.Valor = valor;
//							_dataPuestos.sy_VariablesPuestos.ImportRow(rowPU);
//						}
//					}
//					else //Es una variable de sy_Variables
//					{
//						sy_VariablesDataset.sy_VariablesRow rowG =  sy_Variables.GetByPk(idVariable);
//						if(rowG != null)
//						{
//							rowG.ValorDefault = valor;
//							rowG.IdTipoVariable = idTipoVariable;
//							_dataGenericas.sy_Variables.ImportRow(rowG);
//
//						}
//					}
//
//				}
//			}
//
//			//Borro las variables eliminadas
//			foreach(Variable var in _variablesBorradas)
//			{
//				var.Commit(_dataGenericas, _dataUsuarios, _dataPerfiles, _dataPuestos);
//			}
//
//		}
//
//		private mz.erp.commontypes.SentenciasReplicacion _replication;
//		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
//		{
//			return _replication;
//		}
//
//		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
//		{
//			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
//			replication.IdConexion = Security.IdConexion;
//			replication.SucGeneradora = Security.IdSucursal;
//			//Para todas las sucursales
//			replication.Destino = null;
//			replication.VersionBD = null;
//			replication.NombreTabla = "dataaccess.sy_Variables";			
//			return replication;
//		}
//
//		private bool _hasSaved = false;
//		public bool GetHasSaved()
//		{
//			return _hasSaved;
//		}
//			 
//		public void PutExtraData( ProcessCollectionData _processCollectionData )
//		{
//
//		}
//
//		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
//		{
//			
//		}
//
//		public ArrayList GetDataList()
//		{
//			ArrayList array = new ArrayList();			
//			return array;
//		}
//
//		public TaskCollectionData GetData()
//		{
//			TaskCollectionData data = new TaskCollectionData();
//			data.TaskName = this.GetTaskName();			
//			//data.Add(_data);
//			return data;
//		}
//
//		/// <summary>
//		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
//		/// en el RDBM.
//		/// </summary>
//		public void Flush(string IdTransaction)
//		{
//			if(OnTaskBeforeFlush != null)
//				OnTaskBeforeFlush(this, new EventArgs());
//
//
//			_replication = GenerateReplication();
//			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
//
//			dataaccess.sy_Variables.Update(_dataGenericas.sy_Variables, trx);
//
//			dataaccess.sy_VariablesUsuarios.Update(_dataUsuarios.sy_VariablesUsuarios, trx);
//
//			dataaccess.sy_VariablesPerfiles.Update(_dataPerfiles.sy_VariablesPerfiles, trx);
//
//			dataaccess.sy_VariablesPuestos.Update(_dataPuestos.sy_VariablesPuestos, trx);
//				
//			if(OnTaskAfterFlush != null)
//				OnTaskAfterFlush(this,new EventArgs());
//		}
//		
//		#endregion
//
//
//
//	}
//}
//
