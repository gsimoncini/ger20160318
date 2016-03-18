using System;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConfigurarPrecios.
	/// </summary>
	public class ConfigurarPrecios: ITask, IPersistentTask
	{
		#region Constructores

		public ConfigurarPrecios()
		{
			SetCombosData();
		}
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;	
		private Regla reglaUsaListaDePreciosProveedores;
		private Regla reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal;
		private Regla reglaPrecioDeVentaAfectaMac;
		private Regla reglaUsaCostosIndirectos;
		private Regla reglaUsaPrecioDeCostoReposicion;
		private Regla reglaCalculaPPP;
		private Regla reglaValidacionesPrecios;
		private sy_ConfiguracionesReglasDataset _dataConfiguracionesReglas = new sy_ConfiguracionesReglasDataset();
		private sy_VariablesDataset _data = new sy_VariablesDataset();
		private sy_VariablesUsuariosDataset _dataUsuarios = new sy_VariablesUsuariosDataset();
		private sy_VariablesPerfilesDataset _dataPerfiles = new sy_VariablesPerfilesDataset();
		private sy_VariablesPuestosDataset _dataPuestos = new sy_VariablesPuestosDataset();
		#endregion

		#region Eventos y delegados		
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

		public bool PreguntarAlCancelar
		{
			get 
			{		
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar;
			}
		}

		bool _usaLPProveedores = false;
		public bool UsaLPProveedores
		{
			get {return _usaLPProveedores;}
			set {_usaLPProveedores = value;}
		}

		ArrayList _configuracionesLPProveedores = new ArrayList();
		public ArrayList ConfiguracionesLPProveedores
		{
			get 
			{
				return _configuracionesLPProveedores;
			}
		}

		ArrayList _configuracionesLPProveedoresSeleccionadas = new ArrayList();
		public ArrayList ConfiguracionesLPProveedoresSeleccionadas
		{
			get {return _configuracionesLPProveedoresSeleccionadas;	}
			set { _configuracionesLPProveedoresSeleccionadas = value;}
		}
		
		bool _transladaCambioPcioDeCostoAPcioDeVtaFinal = true;
		public bool TransladaCambioPcioDeCostoAPcioDeVtaFinal
		{
			get {return _transladaCambioPcioDeCostoAPcioDeVtaFinal;}
			set {_transladaCambioPcioDeCostoAPcioDeVtaFinal = value;}
		}

		bool _pcioVtaAfectaMac = true;
		public bool PcioVtaAfectaMac
		{
			get {return _pcioVtaAfectaMac;}
			set {_pcioVtaAfectaMac = value;}
		}

		bool _usaCostosIndirectos = true;
		public bool UsaCostosIndirectos
		{
			get {return _usaCostosIndirectos;}
			set {_usaCostosIndirectos = value;}
		}

		ArrayList _configuracionesCostosIndirectos = new ArrayList();
		public ArrayList ConfiguracionesCostosIndirectos
		{
			get 
			{
				return _configuracionesCostosIndirectos;
			}
		}

		ArrayList _configuracionesCostosIndirectosSeleccionadas = new ArrayList();
		public ArrayList ConfiguracionesCostosIndirectosSeleccionadas
		{
			get {return _configuracionesCostosIndirectosSeleccionadas;	}
			set { _configuracionesCostosIndirectosSeleccionadas = value;}
		}

		bool _usaPcioDeCostoReposicion = true;
		public bool UsaPcioDeCostoReposicion
		{
			get {return _usaPcioDeCostoReposicion;}
			set {_usaPcioDeCostoReposicion = value;}
		}

		ArrayList _configuracionesPcioDeCostoReposicion = new ArrayList();
		public ArrayList ConfiguracionesPcioDeCostoReposicion
		{
			get 
			{
				return _configuracionesPcioDeCostoReposicion;
			}
		}

		ArrayList _configuracionesPcioDeCostoReposicionSeleccionadas = new ArrayList();
		public ArrayList ConfiguracionesPcioDeCostoReposicionSeleccionadas
		{
			get {return _configuracionesPcioDeCostoReposicionSeleccionadas;	}
			set { _configuracionesPcioDeCostoReposicionSeleccionadas = value;}
		}


		ArrayList _configuracionesPPP = new ArrayList();
		public ArrayList ConfiguracionesPPP
		{
			get 
			{
				return _configuracionesPPP;
			}
		}

		ArrayList _configuracionesPPPSeleccionadas = new ArrayList();
		public ArrayList ConfiguracionesPPPSeleccionadas
		{
			get {return _configuracionesPPPSeleccionadas;	}
			set { _configuracionesPPPSeleccionadas = value;}
		}

		ArrayList _configuracionesValidaciones = new ArrayList();
		public ArrayList ConfiguracionesValidaciones
		{
			get 
			{
				return _configuracionesValidaciones;
			}
		}

		ArrayList __configuracionesValidacionesSeleccionadas = new ArrayList();
		public ArrayList ConfiguracionesValidacionesSeleccionadas
		{
			get {return __configuracionesValidacionesSeleccionadas;	}
			set { __configuracionesValidacionesSeleccionadas = value;}
		}
		#endregion

		#region Métodos públicos


		#endregion

		#region Métodos privados

		private void SetCombosData()
		{
		}

		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_errores.Clear();
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

		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{	
			string IdRegla = "UsaListaDePreciosProveedores";
			reglaUsaListaDePreciosProveedores = Regla.GetInstance().GetRegla(IdRegla);
			if(((ConfiguracionRegla)reglaUsaListaDePreciosProveedores.Configuraciones[IdRegla]).Valor.Equals(string.Empty))
				_usaLPProveedores = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaListaDePreciosProveedores.Configuraciones[IdRegla]).ValorDefault);
			else
                _usaLPProveedores = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaListaDePreciosProveedores.Configuraciones[IdRegla]).Valor);
			_configuracionesLPProveedores = new ArrayList();
			foreach(ConfiguracionRegla conf in reglaUsaListaDePreciosProveedores.Configuraciones.Values)
			{
				if(!conf.IdConfiguracion.Equals(IdRegla))
					_configuracionesLPProveedores.Add(conf);
			}

			IdRegla = "ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto";
			reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal = Regla.GetInstance().GetRegla(IdRegla);
			if(((ConfiguracionRegla)reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.Configuraciones[IdRegla]).Valor.Equals(string.Empty))
				_transladaCambioPcioDeCostoAPcioDeVtaFinal = Convert.ToBoolean(((ConfiguracionRegla)reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.Configuraciones[IdRegla]).ValorDefault);
			else
				_transladaCambioPcioDeCostoAPcioDeVtaFinal = Convert.ToBoolean(((ConfiguracionRegla)reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.Configuraciones[IdRegla]).Valor);

			IdRegla = "PrecioDeVentaAfectaMac";
			reglaPrecioDeVentaAfectaMac = Regla.GetInstance().GetRegla(IdRegla);
			if(((ConfiguracionRegla)reglaPrecioDeVentaAfectaMac.Configuraciones[IdRegla]).Valor.Equals(string.Empty))
				_pcioVtaAfectaMac = Convert.ToBoolean(((ConfiguracionRegla)reglaPrecioDeVentaAfectaMac.Configuraciones[IdRegla]).ValorDefault);
			else
				_pcioVtaAfectaMac = Convert.ToBoolean(((ConfiguracionRegla)reglaPrecioDeVentaAfectaMac.Configuraciones[IdRegla]).Valor);

			IdRegla = "UsaCostosIndirectos";
			reglaUsaCostosIndirectos = Regla.GetInstance().GetRegla(IdRegla);
			if(((ConfiguracionRegla)reglaUsaCostosIndirectos.Configuraciones[IdRegla]).Valor.Equals(string.Empty))
				_usaCostosIndirectos = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaCostosIndirectos.Configuraciones[IdRegla]).ValorDefault);
			else
				_usaCostosIndirectos = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaCostosIndirectos.Configuraciones[IdRegla]).Valor);
			_configuracionesCostosIndirectos = new ArrayList();
			foreach(ConfiguracionRegla conf in reglaUsaCostosIndirectos.Configuraciones.Values)
			{
				if(!conf.IdConfiguracion.Equals(IdRegla))
					_configuracionesCostosIndirectos.Add(conf);
			}

			IdRegla = "UsaPrecioDeCostoReposicion";
			reglaUsaPrecioDeCostoReposicion = Regla.GetInstance().GetRegla(IdRegla);
			if(((ConfiguracionRegla)reglaUsaPrecioDeCostoReposicion.Configuraciones[IdRegla]).Valor.Equals(string.Empty))
				_usaPcioDeCostoReposicion = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaPrecioDeCostoReposicion.Configuraciones[IdRegla]).ValorDefault);
			else
				_usaPcioDeCostoReposicion = Convert.ToBoolean(((ConfiguracionRegla)reglaUsaPrecioDeCostoReposicion.Configuraciones[IdRegla]).Valor);
			_configuracionesPcioDeCostoReposicion = new ArrayList();
			foreach(ConfiguracionRegla conf in reglaUsaPrecioDeCostoReposicion.Configuraciones.Values)
			{
				if(!conf.IdConfiguracion.Equals(IdRegla))
					_configuracionesPcioDeCostoReposicion.Add(conf);
			}

			IdRegla = "CalculaPPP";
			reglaCalculaPPP = Regla.GetInstance().GetRegla(IdRegla);
			_configuracionesPPP.AddRange(reglaCalculaPPP.Configuraciones.Values);

			IdRegla = "ValidacionesPrecios";
			reglaValidacionesPrecios = Regla.GetInstance().GetRegla(IdRegla);
			_configuracionesValidaciones.AddRange(reglaValidacionesPrecios.Configuraciones.Values);
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
			ConfiguracionRegla usaLPProv = (ConfiguracionRegla)reglaUsaListaDePreciosProveedores.Configuraciones[reglaUsaListaDePreciosProveedores.IdRegla];
			usaLPProv.Valor = _usaLPProveedores.ToString();
			foreach(ConfiguracionRegla confLPProv in reglaUsaListaDePreciosProveedores.Configuraciones.Values)
			{
                if(!confLPProv.IdConfiguracion.Equals(reglaUsaListaDePreciosProveedores.IdRegla))
                    confLPProv.Valor = ConfiguracionesLPProveedoresSeleccionadas.Contains(confLPProv).ToString();
			}
			reglaUsaListaDePreciosProveedores.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);

			ConfiguracionRegla transladaCambio = (ConfiguracionRegla)reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.Configuraciones[reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.IdRegla];
			transladaCambio.Valor = _transladaCambioPcioDeCostoAPcioDeVtaFinal.ToString();
			reglaTransladaCambioPcioDeCostoAPcioDeVtaFinal.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);
			
			ConfiguracionRegla pcioVtaAfectaMac = (ConfiguracionRegla)reglaPrecioDeVentaAfectaMac.Configuraciones[reglaPrecioDeVentaAfectaMac.IdRegla];
			pcioVtaAfectaMac.Valor = _pcioVtaAfectaMac.ToString();
			reglaPrecioDeVentaAfectaMac.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);

			ConfiguracionRegla usaCtosIndir = (ConfiguracionRegla)reglaUsaCostosIndirectos.Configuraciones[reglaUsaCostosIndirectos.IdRegla];
			usaCtosIndir.Valor = _usaCostosIndirectos.ToString();
			foreach(ConfiguracionRegla confCtosInd in reglaUsaCostosIndirectos.Configuraciones.Values)
			{
				if(!confCtosInd.IdConfiguracion.Equals(reglaUsaCostosIndirectos.IdRegla))
					confCtosInd.Valor = ConfiguracionesCostosIndirectosSeleccionadas.Contains(confCtosInd).ToString();
			}
			reglaUsaCostosIndirectos.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);

			ConfiguracionRegla usaPcioCtoRep = (ConfiguracionRegla)reglaUsaPrecioDeCostoReposicion.Configuraciones[reglaUsaPrecioDeCostoReposicion.IdRegla];
			usaPcioCtoRep.Valor = _usaPcioDeCostoReposicion.ToString();
			foreach(ConfiguracionRegla confPcioCtoR in reglaUsaPrecioDeCostoReposicion.Configuraciones.Values)
			{
				if(!confPcioCtoR.IdConfiguracion.Equals(reglaUsaPrecioDeCostoReposicion.IdRegla))
					confPcioCtoR.Valor = ConfiguracionesPcioDeCostoReposicionSeleccionadas.Contains(confPcioCtoR).ToString();
			}
			reglaUsaPrecioDeCostoReposicion.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);

			foreach(ConfiguracionRegla confPPP in reglaCalculaPPP.Configuraciones.Values)
			{
				confPPP.Valor = ConfiguracionesPPPSeleccionadas.Contains(confPPP).ToString();
			}
			reglaCalculaPPP.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);

			foreach(ConfiguracionRegla confval in reglaValidacionesPrecios.Configuraciones.Values)
			{
				confval.Valor = ConfiguracionesValidacionesSeleccionadas.Contains(confval).ToString();
			}
			reglaValidacionesPrecios.Commit(_dataConfiguracionesReglas, _data, _dataUsuarios, _dataPerfiles, _dataPuestos);
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

			dataaccess.sy_ConfiguracionesReglas.Update(_dataConfiguracionesReglas.sy_ConfiguracionesReglas, trx);
			
			dataaccess.sy_Variables.Update(_data.sy_Variables, trx);

			dataaccess.sy_VariablesUsuarios.Update(_dataUsuarios.sy_VariablesUsuarios, trx);

			dataaccess.sy_VariablesPerfiles.Update(_dataPerfiles.sy_VariablesPerfiles, trx);

			dataaccess.sy_VariablesPuestos.Update(_dataPuestos.sy_VariablesPuestos, trx);


			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion	}
	
	}
}
