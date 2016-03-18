using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmMotivoOrdenReparacion.
	/// </summary>
	public class AbmMotivoOrdenReparacion: Agrupamientos, ITask, IPersistentTask
	{
		#region Constructores
		public AbmMotivoOrdenReparacion()
		{
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
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{	
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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

		public override bool IsValid()
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

		public override void Commit() 
		{
			foreach(MotivoOrdenReparacion mot in _motivosOrdenReparacionNuevos)
			{
				if (mot.Modo == "NEW")
				{
					tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row = _data.tsy_MotivoOrdenReparacion.Newtsy_MotivoOrdenReparacionRow();
					row.Descripcion = mot.Descripcion;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdMotivo = mot.IdMotivo;
					if(mot.IdMotivoPadre != long.MinValue)
					{
						row.IdMotivoPadre = mot.IdMotivoPadre;
						row.EsVerdadero = mot.EsMotivoVerdadero;
					}
					_data.tsy_MotivoOrdenReparacion.Addtsy_MotivoOrdenReparacionRow(row);
			
				}				
				else //MODIF
				{
					tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row = tsy_MotivoOrdenReparacion.GetByPk(mot.IdMotivo);
					row.Descripcion = mot.Descripcion;
					if(mot.IdMotivoPadre != long.MinValue)
					{
						row.IdMotivoPadre = mot.IdMotivoPadre;
						row.EsVerdadero = mot.EsMotivoVerdadero;
					}
					_data.tsy_MotivoOrdenReparacion.ImportRow(row);
				}
			}
			
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public override mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
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
			replication.NombreTabla = "dataaccess.tsy_MotivoOrdenReparacion";			
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

		public override TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			data.Add(_data);
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		public override void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			dataaccess.tsy_MotivoOrdenReparacion.Update(_data.tsy_MotivoOrdenReparacion, trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private tsy_MotivoOrdenReparacionDataset _data = new tsy_MotivoOrdenReparacionDataset();
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler MotivosOrdenReparacionNuevosHasChanged;
		#endregion

		#region Métodos públicos
		public void AddMotivo(string Descripcion, string KeyMotivo, string KeyMotivoPadre, string DescripcionMotivoPadre, bool EsMotivoVerdadero, string Modo)
		{		
			long IdMotivoPadre = long.MinValue;
			if(KeyMotivoPadre != "RAIZ")
				IdMotivoPadre = Convert.ToInt64(KeyMotivoPadre);
			if (Modo == "NEW")
			{
				//Creacion de motivos orden reparacion
				long IdMotivo = systemframework.Util.NewLongId();
				MotivoOrdenReparacion mor = new MotivoOrdenReparacion(Descripcion, IdMotivo, IdMotivoPadre, DescripcionMotivoPadre, EsMotivoVerdadero, Modo);
				_motivosOrdenReparacionNuevos.Add(mor);
			}
			else
				this.agregarMotivoOrdenReparacion(Descripcion, Convert.ToInt64(KeyMotivo), IdMotivoPadre, DescripcionMotivoPadre, EsMotivoVerdadero, Modo);
			if(MotivosOrdenReparacionNuevosHasChanged != null)
				MotivosOrdenReparacionNuevosHasChanged(this, new EventArgs());	
		}

		#endregion

		#region Propiedades
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior()
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

		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente()
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

		private string _leyendaFormulario = "Modificación de tipos de observaciones";
		public string LeyendaFormulario()
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
		
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		private ArrayList _motivosOrdenReparacionNuevos = new ArrayList();
		public ArrayList MotivosOrdenReparacionNuevos
		{
			get{return _motivosOrdenReparacionNuevos;}
		}


		#endregion	

		#region Metodos de Agrupamientos

		public override void DeleteAgrupamientos(string Hierarchy)
		{
		}


		public override Node getChildsNode(string key)
		{
			System.Data.DataTable table;
			string descriptionH = String.Empty;
			string keyH = String.Empty;
			bool esVerdadero = false;
			Node header = null;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				table = mz.erp.businessrules.tsy_MotivoOrdenReparacion.GetListPadres().Tables[0];
				header = new Node(key, "Motivos Orden Reparación");
			}
			else
			{
				table = mz.erp.businessrules.tsy_MotivoOrdenReparacion.GetListHijos(Convert.ToInt64(key)).tsy_MotivoOrdenReparacion;
				header = new Node(key, key);
			}

			foreach (System.Data.DataRow rowH in table.Rows) 
			{
				descriptionH = rowH["Descripcion"].ToString();
				keyH = rowH["IdMotivo"].ToString();
				if(rowH["EsVerdadero"] != null && rowH["EsVerdadero"] != System.DBNull.Value)
				{
					esVerdadero = (bool) rowH["EsVerdadero"];
					if(esVerdadero)
						descriptionH = descriptionH + " (Por Si)";
					else
						descriptionH = descriptionH + " (Por No)";
				}
				Node child = new Node(keyH, descriptionH);
				header.AddChild(child);
			}

			return header;
		}

		public override ArrayList GetFields()
		{
			return new ArrayList();
		}

		public override void GetJerarquia(string key)
		{
		}

		public  override string  GetUIClass()
		{
			return "mz.erp.ui.controllers.tsy_MotivoOrdenReparacion";
		}

		public override string GetUIClassAgrupamientos()
		{
			return "mz.erp.ui.controllers.tsa_AgrupCuentasObservaciones";
		}


		public override void InitializeData()
		{
		}

		public override void ProcesarElementos(ArrayList rows)
		{
		}

		public override void RelacionarJerarquiaElementos()
		{

		}

		public override DataTable SearchAgrupamientos(object target)
		{
			return null;
		}

		#endregion

		#region Métodos Privados
		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_errores.Clear();
			foreach(MotivoOrdenReparacion mot in _motivosOrdenReparacionNuevos)
			{
				string descripcion= mot.Descripcion.Trim();				
				if (descripcion.Equals(string.Empty))
				{
					_errores.Add( new ItemDatasetError( "Motivos Orden Reparación","Descripcion","El campo descripción no puede estar vacío") );
				}
				//Valida la existencia del nuevo tipo en la bd.
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "ValidarMotivo";
				bool  validarExisteMotivo=Variables.GetValueBool(variable);
				//Si es un alta no tiene q haber otro con esa descripcion
				if (validarExisteMotivo && mot.Modo =="NEW")
				{
					tsy_MotivoOrdenReparacionDataset DataSetMotivos;
					if(mot.IdMotivoPadre.Equals(long.MinValue))
                        DataSetMotivos = tsy_MotivoOrdenReparacion.GetListPadres();
					else
						DataSetMotivos = tsy_MotivoOrdenReparacion.GetListHijos(mot.IdMotivoPadre);

					if (DataSetMotivos.Tables[0].Rows.Count>0 )
					{
						foreach (tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow _row in  DataSetMotivos.Tables[0].Rows)
							if ((string)_row["Descripcion"]== descripcion)
							{
								_errores.Add( new ItemDatasetError( "Motivos Orden Reparación","Descripcion","Ya existe otro motivo con ese nombre") );	
							}
				
					}
				} 
				if (validarExisteMotivo && mot.Modo !="NEW")
				{
					tsy_MotivoOrdenReparacionDataset DataSetMotivos;
					if(mot.IdMotivoPadre.Equals(long.MinValue))
						DataSetMotivos = tsy_MotivoOrdenReparacion.GetListPadres();
					else
						DataSetMotivos = tsy_MotivoOrdenReparacion.GetListHijos(mot.IdMotivoPadre);

					if (DataSetMotivos.Tables[0].Rows.Count>0 )
					{
						foreach (tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow _row in  DataSetMotivos.Tables[0].Rows)
							if ((long)_row["IdMotivo"]!= mot.IdMotivo && (string)_row["Descripcion"]==mot.Descripcion)
							{
								_errores.Add( new ItemDatasetError( "Cuentas Observaciones Tipos","Descripcion","Ya existe otro tipo con ese nombre") );	
							}
				
					}
				}
			}

		}

		private void agregarMotivoOrdenReparacion(string Descripcion, long IdMotivo, long IdMotivoPadre, string DescripcionMotivoPadre, bool EsMotivoVerdadero, string Modo)
		{
			int i = 0;
			bool exist = false;
			MotivoOrdenReparacion m = null;
			while(!exist & i < _motivosOrdenReparacionNuevos.Count)
			{
				m = (MotivoOrdenReparacion)_motivosOrdenReparacionNuevos[i];
				if(m.IdMotivo.Equals(IdMotivo))
					exist = true;
				else
					i++;
			}
			if(exist)
			{
				m.Descripcion = Descripcion;
				m.EsMotivoVerdadero = EsMotivoVerdadero;
			}
			else			
				_motivosOrdenReparacionNuevos.Add(new MotivoOrdenReparacion(Descripcion, IdMotivo, IdMotivoPadre, DescripcionMotivoPadre, EsMotivoVerdadero, Modo));
		}

		#endregion

	}

	public class MotivoOrdenReparacion
	{
		#region Constructores
		public MotivoOrdenReparacion()
		{
		}
		public MotivoOrdenReparacion(string Descripcion, long IdMotivo, long IdMotivoPadre, string DescripcionMotivoPadre, bool EsMotivoVerdadero, string Modo)
		{		
			_descripcion = Descripcion;			
			_idMotivo = IdMotivo;
			_idMotivoPadre = IdMotivoPadre;
			_descripcionMotivoPadre = DescripcionMotivoPadre;	
			_esMotivoVerdadero = EsMotivoVerdadero;
			_modo = Modo;
		}
		#endregion

		#region Propiedades
		private long _idMotivo;
		public long IdMotivo 
		{
			get {return _idMotivo;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}
		private long _idMotivoPadre;
		public long IdMotivoPadre 
		{
			get {return _idMotivoPadre;}
		}
		private string _descripcionMotivoPadre;
		public string DescripcionMotivoPadre 
		{
			get {return _descripcionMotivoPadre;}
		}
		private bool _esMotivoVerdadero;
		public bool EsMotivoVerdadero 
		{
			get {return _esMotivoVerdadero;}
			set {_esMotivoVerdadero = value;}
		}
		private string _modo;
		public string Modo 
		{
			get {return _modo;}
		}

		#endregion

	}

}
