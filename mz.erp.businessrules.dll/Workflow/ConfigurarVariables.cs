using System;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConfigurarVariables.
	/// </summary>
	public class ConfigurarVariables: ITask, IPersistentTask
	{
		#region Constructores
		public ConfigurarVariables()
		{
			SetCombosData();
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
			if(_prvTsk == null || sender.GetType().GetInterface("mz.erp.businessrules.IContext") != null)
			{
				_prvTsk = (IContext) sender;
				if(!_prvTsk.huboCambios())
					this.Execute();
				else
				{					
					_variables = _prvTsk.getContext();
					_datosNuevos = _prvTsk.getDatosNuevos();
				}
			}

		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{	
			_preguntarAlCancelar = mz.erp.businessrules.Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
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
			foreach(ConfiguracionNueva cn in _configuracionesNuevas)
			{
				switch(cn.TipoHabilitado)
				{
					case "Usuario":
					{
						ArrayList keys = new ArrayList();
						keys.Add(cn.IdVariable);
						keys.Add(cn.IdHabilitado);
						sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU1 = (sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow)_dataUsuarios.sy_VariablesUsuarios.Rows.Find(keys.ToArray());
						if(rowU1 == null)
						{
							sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU = mz.erp.businessrules.sy_VariablesUsuarios.GetByPk(cn.IdVariable, cn.IdHabilitado);
							if(rowU == null)
							{
								rowU = _dataUsuarios.sy_VariablesUsuarios.Newsy_VariablesUsuariosRow();
								rowU.IdVariable = cn.IdVariable;
								rowU.IdUsuario = cn.IdHabilitado;
								rowU.Valor = "@" +cn.DescripcionDatoNuevo;
								rowU.FechaCreacion = DateTime.Now;
								rowU.IdConexionCreacion = Security.IdConexion;
								_dataUsuarios.sy_VariablesUsuarios.Addsy_VariablesUsuariosRow(rowU);
							}
							else
							{
								rowU.Valor = rowU.Valor + "@" +cn.DescripcionDatoNuevo;
								_dataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
							}
						}else
							rowU1.Valor = rowU1.Valor + "@" +cn.DescripcionDatoNuevo;
						break;
					}
					case "Perfil":
					{
						ArrayList keys = new ArrayList();
						keys.Add(cn.IdVariable);
						keys.Add(cn.IdHabilitadoL);
						sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP1 = (sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow )_dataPerfiles.sy_VariablesPerfiles.Rows.Find(keys.ToArray());
						if(rowP1 == null)
						{
							sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(cn.IdVariable, cn.IdHabilitadoL);
							if(rowP == null)
							{
								rowP = _dataPerfiles.sy_VariablesPerfiles.Newsy_VariablesPerfilesRow();
								rowP.IdVariable = cn.IdVariable;
								rowP.IdPerfil = cn.IdHabilitadoL;
								rowP.Valor = "@" +cn.DescripcionDatoNuevo;
								rowP.FechaCreacion = DateTime.Now;
								rowP.IdConexionCreacion = Security.IdConexion;
								_dataPerfiles.sy_VariablesPerfiles.Addsy_VariablesPerfilesRow(rowP);
							}
							else
							{
								rowP.Valor = rowP.Valor + "@" +cn.DescripcionDatoNuevo;
								_dataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
							}
						}
						else
							rowP1.Valor = rowP1.Valor + "@" +cn.DescripcionDatoNuevo;

						break;
					}
					case "Puesto":
					{
						ArrayList keys = new ArrayList();
						keys.Add(cn.IdVariable);
						keys.Add(Security.IdEmpresa);
						keys.Add(Security.IdSucursal);
						keys.Add(cn.IdHabilitadoL);
						sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowP1 = (sy_VariablesPuestosDataset.sy_VariablesPuestosRow )_dataPuestos.sy_VariablesPuestos.Rows.Find(keys.ToArray());
						if(rowP1 == null)
						{
							sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowP = mz.erp.businessrules.sy_VariablesPuestos.GetByPk(cn.IdVariable, Security.IdEmpresa, Security.IdSucursal, cn.IdHabilitadoL);
							if(rowP == null)
							{
								rowP = _dataPuestos.sy_VariablesPuestos.Newsy_VariablesPuestosRow();
								rowP.IdVariable = cn.IdVariable;
								rowP.IdPuesto = cn.IdHabilitadoL;
								rowP.IdEmpresa = Security.IdEmpresa;
								rowP.IdSucursal = Security.IdSucursal;
								rowP.Valor = "@" +cn.DescripcionDatoNuevo;
								rowP.FechaCreacion = DateTime.Now;
								rowP.IdConexionCreacion = Security.IdConexion;
								_dataPuestos.sy_VariablesPuestos.Addsy_VariablesPuestosRow(rowP);
							}
							else
							{
								rowP.Valor = rowP.Valor + "@" +cn.DescripcionDatoNuevo;
								_dataPuestos.sy_VariablesPuestos.ImportRow(rowP);
							}
						}else
							rowP1.Valor = rowP1.Valor + "@" +cn.DescripcionDatoNuevo;
						break;
					}
					case "Empresa":
					{
						ArrayList keys = new ArrayList();
						keys.Add(cn.IdVariable);
						keys.Add(cn.IdHabilitadoL);
						sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow rowE1 = (sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow)_dataEmpresas.sy_VariablesEmpresas.Rows.Find(keys.ToArray());
						if(rowE1 == null)
						{
							sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow rowE = mz.erp.businessrules.sy_VariablesEmpresas.GetByPk(cn.IdVariable, cn.IdHabilitadoL);
							if(rowE == null)
							{
								rowE = _dataEmpresas.sy_VariablesEmpresas.Newsy_VariablesEmpresasRow();
								rowE.IdVariable = cn.IdVariable;
								rowE.IdEmpresa = cn.IdHabilitadoL;
								rowE.Valor = "@" +cn.DescripcionDatoNuevo;
								rowE.FechaCreacion = DateTime.Now;
								rowE.IdConexionCreacion = Security.IdConexion;
								_dataEmpresas.sy_VariablesEmpresas.Addsy_VariablesEmpresasRow(rowE);
							}
							else
							{
								rowE.Valor = rowE.Valor + "@" +cn.DescripcionDatoNuevo;
								_dataEmpresas.sy_VariablesEmpresas.ImportRow(rowE);
							}
						}else
							rowE1.Valor = rowE1.Valor + "@" +cn.DescripcionDatoNuevo;
						break;
					}
					case "Sucursal":
					{
						ArrayList keys = new ArrayList();
						keys.Add(cn.IdVariable);
						keys.Add(cn.IdHabilitadoLAux);
						keys.Add(cn.IdHabilitadoL);
						sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow rowS1 = (sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow)_dataSucursales.sy_VariablesSucursales.Rows.Find(keys.ToArray());
						if(rowS1 == null)
						{
							sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow rowS = mz.erp.businessrules.sy_VariablesSucursales.GetByPk(cn.IdVariable, cn.IdHabilitadoLAux, cn.IdHabilitadoL);
							if(rowS == null)
							{
								rowS = _dataSucursales.sy_VariablesSucursales.Newsy_VariablesSucursalesRow();
								rowS.IdVariable = cn.IdVariable;
								rowS.IdEmpresa = cn.IdHabilitadoLAux;
								rowS.IdSucursal = cn.IdHabilitadoL;
								rowS.Valor =  "@" +cn.DescripcionDatoNuevo;
								rowS.FechaCreacion = DateTime.Now;
								rowS.IdConecxionCreacion = Security.IdConexion;
								_dataSucursales.sy_VariablesSucursales.Addsy_VariablesSucursalesRow(rowS);
							}
							else
							{
								rowS.Valor = rowS.Valor +  "@" +cn.DescripcionDatoNuevo;
								_dataSucursales.sy_VariablesSucursales.ImportRow(rowS);
							}
						}else
							rowS1.Valor = rowS1.Valor +  "@" +cn.DescripcionDatoNuevo;
						break;
					}
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

			if(_variablesSeleccionadas.Count > 0)
			{
				foreach(sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU in _dataUsuarios.sy_VariablesUsuarios.Rows)
				{
					string descDatoNuevo = rowU.Valor;
					char[] c = {'@'};
					string[] descs = descDatoNuevo.Split(c);
					int pos = descDatoNuevo.IndexOf("@");
					string idVariable = rowU.IdVariable;
					if(pos == 0)
						rowU.Valor = string.Empty;
					else
						rowU.Valor = rowU.Valor.Substring(0, pos);
					for(int i=1; i < descs.Length; i++)
					{
						descDatoNuevo = descs[i];
						if(_prvTsk.isValorLista())
						{
							if(!rowU.Valor.Equals(string.Empty))
								rowU.Valor = rowU.Valor + ",";
							rowU.Valor = rowU.Valor +_prvTsk.getValorVariableParaUsuario(idVariable, descDatoNuevo, rowU.IdUsuario);
						}
						else
							rowU.Valor = _prvTsk.getValorVariableParaUsuario(idVariable, descDatoNuevo, rowU.IdUsuario);
					}
				}
				if(_usuariosSeleccionados.Count > 0)
					dataaccess.sy_VariablesUsuarios.Update(_dataUsuarios.sy_VariablesUsuarios, trx);

				foreach(sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP in _dataPerfiles.sy_VariablesPerfiles.Rows)
				{
					string descDatoNuevo = rowP.Valor;
					char[] c = {'@'};
					string[] descs = descDatoNuevo.Split(c);
					int pos = descDatoNuevo.IndexOf("@");
					if(pos == 0)
						rowP.Valor = string.Empty;
					else
						rowP.Valor = rowP.Valor.Substring(0, pos);
					string idVariable = rowP.IdVariable;
					for(int i=1; i < descs.Length; i++)
					{
				       descDatoNuevo = descs[i];
						if(_prvTsk.isValorLista())
						{
							if(!rowP.Valor.Equals(string.Empty))
								rowP.Valor = rowP.Valor + ",";
							rowP.Valor = rowP.Valor +_prvTsk.getValorVariableParaPerfil(idVariable, descDatoNuevo, rowP.IdPerfil);
						}
						else
							rowP.Valor = _prvTsk.getValorVariableParaPerfil(idVariable, descDatoNuevo, rowP.IdPerfil);
					}

				}
				if(_perfilesSeleccionados.Count > 0)
					dataaccess.sy_VariablesPerfiles.Update(_dataPerfiles.sy_VariablesPerfiles, trx);

				foreach(sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowP in _dataPuestos.sy_VariablesPuestos.Rows)
				{
					string descDatoNuevo = rowP.Valor;
					char[] c = {'@'};
					string[] descs = descDatoNuevo.Split(c);
					int pos = descDatoNuevo.IndexOf("@");
					if(pos == 0)
						rowP.Valor = string.Empty;
					else
						rowP.Valor = rowP.Valor.Substring(0, pos);
					string idVariable = rowP.IdVariable;
					for(int i=1; i < descs.Length; i++)
					{
						descDatoNuevo = descs[i];
						if(_prvTsk.isValorLista())
						{
							if(!rowP.Valor.Equals(string.Empty))
								rowP.Valor = rowP.Valor + ",";
							rowP.Valor = rowP.Valor +_prvTsk.getValorVariableParaPuesto(idVariable, descDatoNuevo, rowP.IdEmpresa, rowP.IdSucursal, rowP.IdPuesto);
						}
						else
							rowP.Valor = _prvTsk.getValorVariableParaPuesto(idVariable, descDatoNuevo, rowP.IdEmpresa, rowP.IdSucursal, rowP.IdPuesto);
					}
				}
				if(_puestosSeleccionados.Count > 0)
					dataaccess.sy_VariablesPuestos.Update(_dataPuestos.sy_VariablesPuestos, trx);

				foreach(sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow rowE in _dataEmpresas.sy_VariablesEmpresas.Rows)
				{
					string descDatoNuevo = rowE.Valor;
					char[] c = {'@'};
					string[] descs = descDatoNuevo.Split(c);
					int pos = descDatoNuevo.IndexOf("@");
					if(pos == 0)
						rowE.Valor = string.Empty;
					else
						rowE.Valor = rowE.Valor.Substring(0, pos);
					string idVariable = rowE.IdVariable;
					for(int i=1; i < descs.Length; i++)
					{
						descDatoNuevo = descs[i];
						if(_prvTsk.isValorLista())
						{
							if(!rowE.Valor.Equals(string.Empty))
								rowE.Valor = rowE.Valor + ",";
							rowE.Valor = rowE.Valor +_prvTsk.getValorVariableParaEmpresa(idVariable, descDatoNuevo, rowE.IdEmpresa);
						}
						else
							rowE.Valor = _prvTsk.getValorVariableParaEmpresa(idVariable, descDatoNuevo, rowE.IdEmpresa);
					}
				}
				if(_empresasSeleccionadas.Count > 0)
					dataaccess.sy_VariablesEmpresas.Update(_dataEmpresas.sy_VariablesEmpresas, trx);

				foreach(sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow rowS in _dataSucursales.sy_VariablesSucursales.Rows)
				{
					string descDatoNuevo = rowS.Valor;
					char[] c = {'@'};
					string[] descs = descDatoNuevo.Split(c);
					int pos = descDatoNuevo.IndexOf("@");
					if(pos == 0)
						rowS.Valor = string.Empty;
					else
						rowS.Valor = rowS.Valor.Substring(0, pos);
					string idVariable = rowS.IdVariable;
					for(int i=1; i < descs.Length; i++)
					{
						descDatoNuevo = descs[i];
						if(_prvTsk.isValorLista())
						{
							if(!rowS.Valor.Equals(string.Empty))
								rowS.Valor = rowS.Valor + ",";
							rowS.Valor = rowS.Valor +_prvTsk.getValorVariableParaSucursal(idVariable, descDatoNuevo, rowS.IdEmpresa, rowS.IdSucursal);
						}
						else
							rowS.Valor = _prvTsk.getValorVariableParaSucursal(idVariable, descDatoNuevo, rowS.IdEmpresa, rowS.IdSucursal);
					}
				}
				if(_sucursalesSeleccionadas.Count > 0)
					dataaccess.sy_VariablesSucursales.Update(_dataSucursales.sy_VariablesSucursales, trx);

			}

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;	
		private sy_VariablesUsuariosDataset _dataUsuarios = new sy_VariablesUsuariosDataset();
		private sy_VariablesPerfilesDataset _dataPerfiles = new sy_VariablesPerfilesDataset();
		private sy_VariablesPuestosDataset _dataPuestos = new sy_VariablesPuestosDataset();
		private sy_VariablesEmpresasDataset _dataEmpresas = new sy_VariablesEmpresasDataset();
		private sy_VariablesSucursalesDataset _dataSucursales = new sy_VariablesSucursalesDataset();
		private IContext _prvTsk = null;
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler ConfiguracionesNuevasHasChanged;
		#endregion

		#region Métodos públicos

		public void AddConfiguracion(string IdVariable, string DescripcionDatoNuevo, string IdHabilitado, long IdHabilitadoL, long IdHabilitadoLAux, string DescripcionHabilitado, string TipoHabilitado)
		{
			if(_prvTsk.isConfiguracionValida(IdVariable, DescripcionDatoNuevo))
			{
				ConfiguracionNueva cn = new ConfiguracionNueva(IdVariable, DescripcionDatoNuevo, IdHabilitado, IdHabilitadoL, IdHabilitadoLAux, DescripcionHabilitado, TipoHabilitado);
				_configuracionesNuevas.Add(cn);
				if(ConfiguracionesNuevasHasChanged != null)
					ConfiguracionesNuevasHasChanged(this, new EventArgs());	
			}
		}

		#endregion

		#region Propiedades		
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

		private string _leyendaFormulario = "Modificación de tipos de observaciones";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				
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

		ArrayList _datosNuevos = new ArrayList();
		public ArrayList DatosNuevos
		{
			get 
			{
				return _datosNuevos;
			}
		}

		ArrayList _datosNuevosSeleccionados = new ArrayList();
		public ArrayList DatosNuevosSeleccionados
		{
			set 
			{
				_datosNuevosSeleccionados = value;
			}
		}

		ArrayList _variables = new ArrayList();
		public ArrayList Variables
		{
			get 
			{
				return _variables;
			}
		}

		ArrayList _variablesSeleccionadas = new ArrayList();
		public ArrayList VariablesSeleccionadas
		{
			set 
			{
				_variablesSeleccionadas = value;
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
		
		ArrayList _empresas = new ArrayList();
		public ArrayList Empresas
		{
			get 
			{
				return _empresas;
			}
		}

		ArrayList _empresasSeleccionadas = new ArrayList();
		public ArrayList EmpresasSeleccionadas
		{
			set 
			{
				_empresasSeleccionadas = value;
			}
		}

		ArrayList _sucursales = new ArrayList();
		public ArrayList Sucursales
		{
			get 
			{
				return _sucursales;
			}
		}

		ArrayList _sucursalesSeleccionadas = new ArrayList();
		public ArrayList SucursalesSeleccionadas
		{
			set 
			{
				_sucursalesSeleccionadas = value;
			}
		}

		private ArrayList _configuracionesNuevas = new ArrayList();
		public ArrayList ConfiguracionesNuevas
		{
			get {return _configuracionesNuevas;}
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

			DataTable empresasDT = sy_Empresas.GetList().sy_Empresas;
			foreach (System.Data.DataRow row in empresasDT.Rows)
			{
				long id = (long)row["IdEmpresa"];
				string descripcion = row["Descripcion"].ToString();
				EmpresaView empresa = new EmpresaView(id, descripcion);
				_empresas.Add(empresa);
			}

			DataTable sucursalesDT = sy_Sucursales.GetList().sy_Sucursales;
			foreach (System.Data.DataRow row in sucursalesDT.Rows)
			{
				long idS = (long)row["IdSucursal"];
				long idE = (long)row["IdEmpresa"];
				string descripcion = row["Descripcion"].ToString();
				SucursalView sucursal = new SucursalView(idS, idE, descripcion);
				_sucursales .Add(sucursal);
			}

		}

		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_errores.Clear();
		}

		#endregion

	}

	public class UsuarioView
	{
		public UsuarioView(string IdUsuario, string Nombre)
		{
			_idUsuario = IdUsuario;
			_nombre = Nombre;
		}

		private string _idUsuario;
		public string IdUsuario 
		{
			get {return _idUsuario;}
		}

		private string _nombre;
		public string Nombre 
		{
			get {return _nombre;}
		}

		public override System.String ToString()
		{
			return _nombre;
		}

		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdUsuario.Equals(((UsuarioView)obj).IdUsuario);
		}
	}

	
	public class PerfilView
	{
		public PerfilView(long IdPerfil, string Descripcion)
		{
			_idPerfil = IdPerfil;
			_descripcion = Descripcion;
		}

		private long _idPerfil;
		public long IdPerfil 
		{
			get {return _idPerfil;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}

		public override System.String ToString()
		{
			return _descripcion;
		}

		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdPerfil.Equals(((PerfilView)obj).IdPerfil);
		}

	}

	
	public class PuestoView
	{
		public PuestoView(long IdPuesto, string Descripcion)
		{
			_idPuesto = IdPuesto;
			_descripcion = Descripcion;
		}

		private long _idPuesto;
		public long IdPuesto 
		{
			get {return _idPuesto;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
		}

		public override System.String ToString()
		{
			return _descripcion;
		}

		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdPuesto.Equals(((PuestoView)obj).IdPuesto);
		}

	}


	public class EmpresaView
	{
		public EmpresaView(long IdEmpresa, string Descripcion)
		{
			_idEmpresa = IdEmpresa;
			_descripcion = Descripcion;
		}

		private long _idEmpresa;
		public long IdEmpresa 
		{
			get {return _idEmpresa;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
		}

		public override System.String ToString()
		{
			return _descripcion;
		}
	}


	public class SucursalView
	{
		public SucursalView(long IdSucursal, long IdEmpresa, string Descripcion)
		{
			_idSucursal = IdSucursal;
			_idEmpresa = IdEmpresa;
			_descripcion = Descripcion;
		}

		private long _idSucursal;
		public long IdSucursal 
		{
			get {return _idSucursal;}
		}

		private long _idEmpresa;
		public long IdEmpresa 
		{
			get {return _idEmpresa;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
		}

		public override System.String ToString()
		{
			return _descripcion;
		}
	}

	public class ConfiguracionNueva
	{
		public ConfiguracionNueva()
		{
		}
		public ConfiguracionNueva(string IdVariable, string DescripcionDatoNuevo, string IdHabilitado, long IdHabilitadoL, long IdHabilitadoLAux, string DescripcionHabilitado, string TipoHabilitado)
		{		
			_idVariable = IdVariable;		
			_descripcionDatoNuevo = DescripcionDatoNuevo;
			_idHabilitado = IdHabilitado;
			_idHabilitadoL = IdHabilitadoL;
			_idHabilitadoLAux = IdHabilitadoLAux;
			_descripcionHabilitado = DescripcionHabilitado;
			_tipoHabilitado = TipoHabilitado;
		}
		private string _idVariable;
		public string IdVariable 
		{
			get {return _idVariable;}
		}

		private string _descripcionDatoNuevo;
		public string DescripcionDatoNuevo 
		{
			get {return _descripcionDatoNuevo;}
		}

		private string _idHabilitado;
		public string IdHabilitado 
		{
			get {return _idHabilitado;}
		}

		private long _idHabilitadoL;
		public long IdHabilitadoL 
		{
			get {return _idHabilitadoL;}
		}

		private long _idHabilitadoLAux;
		public long IdHabilitadoLAux 
		{
			get {return _idHabilitadoLAux;}
		}
		private string _descripcionHabilitado;
		public string DescripcionHabilitado 
		{
			get {return _descripcionHabilitado;}
		}

		private string _tipoHabilitado;
		public string TipoHabilitado 
		{
			get {return _tipoHabilitado;}
		}
	}
}
