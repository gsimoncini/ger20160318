using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;
using System.Data.SqlClient;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de VisualizacionDeStock.
	/// </summary>
	public class AbmVisualizacionDeStock: Agrupamientos, ITask, IPersistentTask, IContext
	{
		#region Constructores
		public AbmVisualizacionDeStock()
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
			foreach(object obj in _visualizacionesNuevas)
			{
				VisualizacionNueva vn = (VisualizacionNueva) obj;
				switch(vn.Modo)
				{
					case "NEW": //Nueva visualizacion
					{
						tlg_VisualizacionDeStockEx.tlg_VisualizacionDeStockRow row = _data.tlg_VisualizacionDeStock.Newtlg_VisualizacionDeStockRow();
						row.Descripcion = vn.NombreVisualizacion;
						row.FechaCreacion = DateTime.Now;
						row.Activo = vn.Activo;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdVisualizacionDeStock = vn.KeyVisualizacion;
						row.IdReservado = 0;
						row.IdEmpresa = Security.IdEmpresa;			
						row.IdSucursal = Security.IdSucursal;
						_data.tlg_VisualizacionDeStock.Addtlg_VisualizacionDeStockRow(row);
						break;

					}
					case "MODIF": //Modificacion de visualizacion
					{
						DataRow row = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(vn.KeyVisualizacion);
						row["Descripcion"] = vn.NombreVisualizacion;
						row["Activo"] = vn.Activo;
						_data.tlg_VisualizacionDeStock.ImportRow(row);
						break;
					}
					case "ADD": //Adicion de estado a visualizacion
					{
						tlg_VisualizacionDeStockEx.tlg_VisualizacionDeStockDetRow row = _data.tlg_VisualizacionDeStockDet.Newtlg_VisualizacionDeStockDetRow();
						row.IdVisualizacionDeStock = vn.KeyVisualizacion;
						int pos = vn.KeyEstado.IndexOf("_") + 1;
						string keyEstado = vn.KeyEstado.Substring(pos);
						row.IdEstadoDeStock = keyEstado;
						if(vn.Operacion.Equals("+"))
                            row.Operacion = 1;
						else
							row.Operacion = -1;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdReservado = 0;
						row.IdEmpresa = Security.IdEmpresa;			
						row.IdSucursal = Security.IdSucursal;
						DataRow rowV = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(vn.KeyVisualizacion);
						if(rowV != null)
                            _data.tlg_VisualizacionDeStock.ImportRow(rowV);
						_data.tlg_VisualizacionDeStockDet.Addtlg_VisualizacionDeStockDetRow(row);
						break;
					}
					case "MODIFOP": //Modificacion de operacion de estado
					{
						int pos = vn.KeyEstado.IndexOf("_") + 1;
						string keyEstado = vn.KeyEstado.Substring(pos);
						DataRow row = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetByPk(vn.KeyVisualizacion, keyEstado);
						if(vn.Operacion.Equals("+"))
							row["Operacion"] = 1;
						else
							row["Operacion"] = -1;
						if(_data.tlg_VisualizacionDeStock.FindByIdVisualizacionDeStock(vn.KeyVisualizacion) == null)
						{
							DataRow rowV = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(vn.KeyVisualizacion);
							if(rowV != null)
								_data.tlg_VisualizacionDeStock.ImportRow(rowV);
						}
						_data.tlg_VisualizacionDeStockDet.ImportRow(row);
						break;
					}
					case "DEL": //Borrado de estado de visualizacion
					{
						int pos = vn.KeyEstado.IndexOf("_") + 1;
						string keyEstado = vn.KeyEstado.Substring(pos);
						DataRow row = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetByPk(vn.KeyVisualizacion, keyEstado);
						row.Delete();
						_data.tlg_VisualizacionDeStockDet.ImportRow(row);
						break;
					}
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
			dataaccess.tlg_VisualizacionDeStock.Update(_data.tlg_VisualizacionDeStock, trx);
			dataaccess.tlg_VisualizacionDeStockDet.Update(_data.tlg_VisualizacionDeStockDet, trx);

			/*Para la configuracion de variables*/
			int i = 0;
			foreach(tlg_VisualizacionDeStockEx.tlg_VisualizacionDeStockRow row in _data.tlg_VisualizacionDeStock.Rows)
			{
				VisualizacionNueva vn = (VisualizacionNueva) _visualizacionesNuevas[i];
				if( vn.Modo.Equals("NEW"))
				{
					string IdVisualizacion = (string)row["IdVisualizacionDeStock"];
					_variablesValores.Add(vn.NombreVisualizacion, IdVisualizacion);

				}
				i++;
			}


			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Miembros de IContext

		public ArrayList getDatosNuevos()
		{
			return _visualizacionesNuevasCofigVariables;
		}
		public ArrayList getContext()
		{
			ArrayList context = new ArrayList();
			context.Add("Momentos.IngresarPrecioProducto.VisualizacionDeStock");
			context.Add("Stock.VisualizacionDeStock.Default");
			return context;
		}

		public bool isValorLista()
		{
			return false;
		}

		public string getValorVariableParaUsuario(string idVariable, string descripcionDatoNuevo, string idUsuario)
		{
			return getValorVariable(descripcionDatoNuevo);
		}

		public string getValorVariableParaPerfil(string idVariable, string descripcionDatoNuevo, long idPerfil)
		{
			return getValorVariable(descripcionDatoNuevo);
		}

		public string getValorVariableParaPuesto(string idVariable, string descripcionDatoNuevo, long idEmpresa, long idSucursal, long idPuesto)
		{
			return getValorVariable(descripcionDatoNuevo);
		}
		
		public string getValorVariableParaEmpresa(string idVariable, string descripcionDatoNuevo, long idEmpresa)
		{
			return getValorVariable(descripcionDatoNuevo);
		}
		
		public string getValorVariableParaSucursal(string idVariable, string descripcionDatoNuevo, long idEmpresa, long idSucursal)
		{
			return getValorVariable(descripcionDatoNuevo);
		}
		
		private string getValorVariable(string descripcionDatoNuevo)
		{
			return (string)_variablesValores[descripcionDatoNuevo];
		}

		public bool huboCambios()
		{
			return _visualizacionesNuevasCofigVariables.Count > 0;
		}

		public bool isConfiguracionValida(string idVariable, string descripcionDatoNuevo)
		{
			return true;
		}

		#endregion
	
		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private tlg_VisualizacionDeStockEx _data = new tlg_VisualizacionDeStockEx();		
		private Hashtable _variablesValores = new Hashtable();
		#endregion

		#region Eventos y delegados	
		public event System.EventHandler VisualizacionesNuevasHasChanged;
		#endregion

		#region Métodos públicos		
		
		public void AddVisualizacion(string NombreVisualizacion, string KeyVisualizacion, string KeyEstado, string DescripcionEstado, string Operacion, bool Activo, string Modo)
		{		
			switch ( Modo )
			{	
				case "NEW"://Nueva Visualizacion
				{
					KeyVisualizacion = systemframework.Util.NewStringId();
					_visualizacionModificada = new VisualizacionNueva(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
					_visualizacionesNuevas.Add(_visualizacionModificada);
					_visualizacionesNuevasCofigVariables.Add(_visualizacionModificada);
					break;
				}
				case "MODIF"://Modificacion de Visualizacion
				{
					this.agregarVisualizacion(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
					break;	
				}
				case "ADD": //Agregar estado
				{
					KeyEstado = KeyVisualizacion + "_" + KeyEstado;
					this.modificarEstadoVisualizacion(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
					break;	
				}
				default://Eliminar/Modificar estado
				{
					this.modificarEstadoVisualizacion(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
					break;	
				}

			}
			if(VisualizacionesNuevasHasChanged != null)
                VisualizacionesNuevasHasChanged(this, new EventArgs());	
		}
		public Node getNode(string keyVisualizacion, string keyEstado)
		{
			Node node = null;
			if(keyEstado.Equals(string.Empty)) //es una visualizacion
			{
				mz.erp.commontypes.data.tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow row = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(keyVisualizacion);
				string description = row["Descripcion"].ToString();
				bool activo = (bool) row["Activo"];
				if(activo)
					description = description + " (Activo)";
				else
					description = description + " (Desactivo)";
				node = new Node(keyVisualizacion, description);
			}
			else //es un estado
			{
				int pos = keyEstado.IndexOf("_") + 1;
				string keyE = keyEstado.Substring(pos);
				mz.erp.commontypes.data.tlg_EstadosDeStockDataset.tlg_EstadosDeStockRow rowE = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(keyE);
				string description = rowE["Descripcion"].ToString();
				mz.erp.commontypes.data.tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow rowD = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetByPk(keyVisualizacion, keyE);
				string operacion = rowD["Operacion"].ToString();
				if(operacion.Equals("1"))
					description = description + " (+)";
				else
					description = description + " (-)";
				node = new Node(keyEstado, description);
			}
			return node;
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

		private string _leyendaFormulario = "Modificación de tipos de observaciones";
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

		public bool PreguntarAlCancelar
		{
			get {
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

		private System.Collections.ArrayList _visualizacionesNuevas = new ArrayList();
		public System.Collections.ArrayList VisualizacionesNuevas
		{
			get {return _visualizacionesNuevas;}
		}

		private VisualizacionNueva _visualizacionModificada = null;
		public VisualizacionNueva VisualizacionModificada
		{
			get {return _visualizacionModificada;}
		}

		private ArrayList _visualizacionesNuevasCofigVariables = new ArrayList();
		public System.Collections.ArrayList VisualizacionesNuevasConfigVariables
		{
			get {return _visualizacionesNuevasCofigVariables;}
		}

		#endregion

		#region Metodos de Agrupamientos

		public override void DeleteAgrupamientos(string Hierarchy)
		{
		}


		public override Node getChildsNode(string key)
		{
			System.Data.DataTable table;
			string descriptionH = string.Empty;
			string keyH = string.Empty;
			bool activo = false;
			string operacion = string.Empty;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				table = mz.erp.businessrules.tlg_VisualizacionDeStock.GetList().tlg_VisualizacionDeStock;
				header = new Node(key, "Visualizaciones de Stock");
				foreach (System.Data.DataRow rowH in table.Rows) 
				{
					descriptionH = rowH["Descripcion"].ToString();
					keyH = rowH["IdVisualizacionDeStock"].ToString();
					activo = (bool) rowH["Activo"];
					if(activo)
						descriptionH = descriptionH + " (Activo)";
					else
						descriptionH = descriptionH + " (Desactivo)";
					Node child = new Node(keyH, descriptionH);
					header.AddChild(child);
				}
			}
			else
			{
				table = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetListEx(key).Tables[0];
				header = new Node(key, key);
				foreach (System.Data.DataRow rowH in table.Rows) 
				{
					descriptionH = rowH["EstadoDeStock"].ToString();
					keyH = key + "_" + rowH["IdEstadoDeStock"].ToString();
					operacion = rowH["Operacion"].ToString();
					if(operacion.Equals("1"))
						descriptionH = descriptionH + " (+)";
					else
						descriptionH = descriptionH + " (-)";
					Node child = new Node(keyH, descriptionH);
					header.AddChild(child);
				}
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
			return "mz.erp.ui.controllers.tsa_CuentasObservaciones";
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
			foreach(object obj in _visualizacionesNuevas)
			{
				VisualizacionNueva vis = (VisualizacionNueva) obj;

				string nombre= vis.NombreVisualizacion.Trim();				
				if (nombre.Equals(string.Empty))
				{
					_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","El campo nombre visualización no puede estar vacío") );
				}

				//Valida la existencia de la nueva visualizacion en la bd.
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Validar.Visualizacion";
				bool  validarExisteVisualizacion = Variables.GetValueBool(variable);

				//Si es un alta no tiene q haber otra con ese nombre
				if (validarExisteVisualizacion && vis.Modo =="NEW")
				{
					tlg_VisualizacionDeStockDataset DataSetVisualizaciones = mz.erp.businessrules.tlg_VisualizacionDeStock.GetList();

					if (DataSetVisualizaciones.Tables[0].Rows.Count>0 )
					{
						foreach (tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow _row in  DataSetVisualizaciones.Tables[0].Rows)
							if ((string)_row["Descripcion"]== nombre)
							{
								_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","Ya existe otra visualización con ese nombre") );	
							}
				
					}
				} 
				if (validarExisteVisualizacion && vis.Modo =="MODIF")
				{
					tlg_VisualizacionDeStockDataset DataSetVisualizaciones = mz.erp.businessrules.tlg_VisualizacionDeStock.GetList();

					if (DataSetVisualizaciones.Tables[0].Rows.Count>0 )
					{
						foreach (tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow _row in  DataSetVisualizaciones.Tables[0].Rows)
							if ((string)_row["IdVisualizacionDeStock"]!= vis.KeyVisualizacion && (string)_row["Descripcion"]==vis.NombreVisualizacion)
							{
								_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","Ya existe otra visualización con ese nombre") );	
							}
				
					}
				}

				if (vis.Modo =="ADD")
				{
					string descripcionE= vis.DescripcionEstado.Trim();				
					if (descripcionE.Equals(string.Empty))
					{
						_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","No se seleccionó el estado a agregar") );
					}
					//Me fijo que exista la visualizacion en la bd o que la este creando ahora
					if(!this.existeNuevaVisualizacion(vis.KeyVisualizacion, _visualizacionesNuevas.IndexOf(vis))) // si no se creo ahora me fijo si esta en la BD
					{
						tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow row = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(vis.KeyVisualizacion);
						if(row == null)
							_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","La visualización debe ser creada antes de agregarle un estado") );	
						else //Existe la visualizacion
						{
							int pos = vis.KeyEstado.IndexOf("_") + 1;
							string keyEstado = vis.KeyEstado.Substring(pos);
							tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow rowD = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetByPk(vis.KeyVisualizacion, keyEstado);
							if(rowD != null)
								_errores.Add( new ItemDatasetError( "Visualizaciones de Stock","Descripcion","El estado ya existe en esa visualización") );	

						}

					}

				}

			}
		}

		private bool existeNuevaVisualizacion(string KeyVisualizacion, int index)
		{
			bool exist = false;
			int i = 0;
			while(!exist && i < index)
			{
				VisualizacionNueva v = (VisualizacionNueva)_visualizacionesNuevas[i];
				if(v.KeyVisualizacion.Equals(KeyVisualizacion))
					exist = true;
				else
                    i++;
			}
			return exist;
		}

		private void agregarVisualizacion(string NombreVisualizacion, string KeyVisualizacion, string KeyEstado, string DescripcionEstado, string Operacion, bool Activo, string Modo)
		{
			int i = 0;
			bool exist = false;
			VisualizacionNueva v = null;
			while(!exist & i < _visualizacionesNuevas.Count)
			{
				v = (VisualizacionNueva)_visualizacionesNuevas[i];
				if(v.KeyVisualizacion.Equals(KeyVisualizacion) & v.KeyEstado.Equals(KeyEstado))
					exist = true;
				else
					i++;
			}
			if(exist)
			{
				v.NombreVisualizacion = NombreVisualizacion;
				v.Activo = Activo;
				_visualizacionModificada = v;
			}
			else
			{
				_visualizacionModificada = new VisualizacionNueva(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
				_visualizacionesNuevas.Add(_visualizacionModificada);
			}
				
		}

		private void modificarEstadoVisualizacion(string NombreVisualizacion, string KeyVisualizacion, string KeyEstado, string DescripcionEstado, string Operacion, bool Activo, string Modo)
		{
			int i = 0;
			bool exist = false;
			VisualizacionNueva v = null;
			while(!exist & i < _visualizacionesNuevas.Count)
			{
				v = (VisualizacionNueva)_visualizacionesNuevas[i];
				if(v.KeyVisualizacion.Equals(KeyVisualizacion) & v.KeyEstado.Equals(KeyEstado))
					exist = true;
				else
					i++;
			}
			if(exist)
			{
				if(v.Modo.Equals("ADD") & Modo.Equals("DEL"))
				{ 
					v.Modo = Modo;
					_visualizacionesNuevas.Remove(v);
				}
				else if(v.Modo.Equals("ADD") & Modo.Equals("MODIFOP"))
					v.Operacion = Operacion;
				else if(v.Modo.Equals("DEL") & Modo.Equals("ADD"))
				{
					if(v.Operacion.Equals(Operacion))
					{
						_visualizacionesNuevas.Remove(v);
						v.Modo = "NOTHING";
					}
					else
					{
						v.Operacion = Operacion;
						v.Modo = "MODIFOP";
					}					
				}
				else if(v.Modo.Equals("MODIFOP") & Modo.Equals("DEL"))
					v.Modo = Modo;
				else if(v.Modo.Equals("MODIFOP") & Modo.Equals("MODIFOP"))
					v.Operacion = Operacion;
				_visualizacionModificada = v;
			}
			else
			{
				_visualizacionModificada = new VisualizacionNueva(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
				_visualizacionesNuevas.Add(_visualizacionModificada);
			}
		}
		
		#endregion

	}

	public class VisualizacionNueva: IDatoNuevo
	{
		#region Constructores
		public VisualizacionNueva()
		{
		}
		public VisualizacionNueva(string NombreVisualizacion, string KeyVisualizacion, string KeyEstado, string DescripcionEstado, string Operacion, bool Activo, string Modo)
		{		
			_nombreVisualizacion = NombreVisualizacion;			
			_keyVisualizacion = KeyVisualizacion;
			_keyEstado = KeyEstado;
			_descripcionEstado = DescripcionEstado;
			_operacion = Operacion;
			_activo = Activo;
			_modo = Modo;
		}
		#endregion

		#region Propiedades
		private string _keyVisualizacion;
		public string KeyVisualizacion 
		{
			get {return _keyVisualizacion;}
		}

		private string _nombreVisualizacion;
		public string NombreVisualizacion 
		{
			get {return _nombreVisualizacion;}
			set {_nombreVisualizacion = value;}
		}

		private string _keyEstado;
		public string KeyEstado 
		{
			get {return _keyEstado;}
		}

		private string _descripcionEstado;
		public string DescripcionEstado 
		{
			get {return _descripcionEstado;}
		}

		private string _operacion;
		public string Operacion 
		{
			get {return _operacion;}
			set {_operacion = value;}
		}

		private bool _activo;
		public bool Activo 
		{
			get {return _activo;}
			set {_activo = value;}
		}
		private string _modo;
		public string Modo 
		{
			get {return _modo;}
			set {_modo = value;}
		}
		#endregion

		#region Miembros de IDatoNuevo
		
		public string getDescripcionDatoNuevo()
		{
			return _nombreVisualizacion;
		}
		#endregion
		public override String ToString()
		{
			string str = _nombreVisualizacion;
			return str;
		}


	}

}
