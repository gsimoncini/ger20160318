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
	/// Descripción breve de TiposObservacionesCuentas.
	/// </summary>
	public class TiposObservacionesCuentas : Agrupamientos, ITiposObservaciones
	{
		#region Constructores
		public TiposObservacionesCuentas()
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
			_tablePerfiles = sy_Perfiles.GetList().sy_Perfiles;
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
			foreach(object obs in _tiposObservacionesNuevas)
			{
				TipoObservacionNueva on = (TipoObservacionNueva) obs;
				if (on.Modo == "NEW")
				{
					tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row = _data.tsa_CuentasObservacionesTipos.Newtsa_CuentasObservacionesTiposRow();
					row.Descripcion = on.DescripcionTipo;
					row.FechaCreacion = DateTime.Now;
					row.Activo = true;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdCuentaObservacionTipo = on.KeyTipo;
					if(on.KeyTipoPadre != "RAIZ")
                        row.IdCuentaObservacionTipoPadre = on.KeyTipoPadre;
					row.IdReservado = 0;
					row.IdEmpresa = Security.IdEmpresa;			
					row.IdSucursal = Security.IdSucursal;
					_data.tsa_CuentasObservacionesTipos.Addtsa_CuentasObservacionesTiposRow(row);

					string idVariable1 = string.Empty;
					string idVariable2 = string.Empty;
					long idPerfil = Security.IdPerfil;

					if(on.KeyTipoPadre != "RAIZ" & !_modificaPerfilesSubTipos)
					{
						idVariable1 = "Cuentas.Observaciones.Add.SubTipos";
						idVariable2 = "Cuentas.Observaciones.Ver.SubTipos";							
						foreach(sy_PerfilesDataset.sy_PerfilesRow rowP in _tablePerfiles.Rows)
						{
							this.agregarVariable(idVariable1, rowP.IdPerfil);
							this.agregarVariable(idVariable2, rowP.IdPerfil);
						}
						_modificaPerfilesSubTipos = true;
					} 
					else if(on.KeyTipoPadre.Equals("RAIZ") & ! _modificaPerfilesTipos)
					{
						idVariable1 = "Cuentas.Observaciones.Add.Tipos";
						idVariable2 = "Cuentas.Observaciones.Ver.Tipos";
						foreach(sy_PerfilesDataset.sy_PerfilesRow rowP in _tablePerfiles.Rows)
						{
							this.agregarVariable(idVariable1, rowP.IdPerfil);
							this.agregarVariable(idVariable2, rowP.IdPerfil);
						}
						_modificaPerfilesTipos = true;
					}
					
				}				
				else //MODIF
				{
					DataRow rowT = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetByPk(on.KeyTipo);
                    rowT["Descripcion"] = on.DescripcionTipo;
     				rowT["Activo"] = on.Activo;
					if(on.KeyTipoPadre == "RAIZ")
                        rowT["IdCuentaObservacionTipoPadre"] = System.DBNull.Value;
					_data.tsa_CuentasObservacionesTipos.ImportRow(rowT);
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
			dataaccess.tsa_CuentasObservacionesTipos.Update(_data.tsa_CuentasObservacionesTipos, trx);
			bool modificaPerfiles = false;
			if( this._processParent.Process.ProcessName.Equals("ProcesoAbmTiposObservacionesCuentas")) 
			{//Si es la configuracion rapida agrego en los nuevos tipos de observaciones para q las vean todos los perfiles existentes en el sistema
				//Si es personalizada (ProcesoAbmTiposObservacionesCuentasPersonalizado) se le mustra la interfaz para configurar estas variables.
				if(_modificaPerfilesSubTipos)
				{
					int i = 0;
					foreach(tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row in _data.tsa_CuentasObservacionesTipos.Rows)
					{
						TipoObservacionNueva on = (TipoObservacionNueva)_tiposObservacionesNuevas[i];
						if( on.Modo.Equals("NEW") && !row.IsIdCuentaObservacionTipoPadreNull())
						{
							string IdCuentaObservacionTipo = (string)row["IdCuentaObservacionTipo"];
							foreach(sy_PerfilesDataset.sy_PerfilesRow rowP in _tablePerfiles.Rows)
							{
								long IdPerf = rowP.IdPerfil;
								int index1 = this.getIndexOf("Cuentas.Observaciones.Add.SubTipos", IdPerf);
								if(existeVariable("Cuentas.Observaciones.Add.SubTipos", IdPerf))
								{
									string valorSA = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"];
									if(!valorSA.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + ",";
								}
								else if(!((string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"]).Equals(string.Empty))
								{
									string valorSA = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"];
									if(!valorSA.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + ",";
								}
								_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + IdCuentaObservacionTipo;
								
								int index2 = this.getIndexOf("Cuentas.Observaciones.Ver.SubTipos", IdPerf);
								if(existeVariable("Cuentas.Observaciones.Ver.SubTipos", IdPerf))
								{
									string valorSV = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"];
									if(!valorSV.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] + ",";
								}
								else if(!((string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"]).Equals(string.Empty))
								{
									string valorSV = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"];
									if(!valorSV.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + ",";
								}
								_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] + IdCuentaObservacionTipo;
							}

						}
						i++;
					}
					modificaPerfiles = true;
				}
				//_variablesValores.Add(on.DescripcionTipo, IdCuentaObservacionTipo);

				if(_modificaPerfilesTipos)
				{
					int i = 0;
					foreach(tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row in _data.tsa_CuentasObservacionesTipos.Rows)
					{
						TipoObservacionNueva on = (TipoObservacionNueva)_tiposObservacionesNuevas[i];
						if(on.Modo.Equals("NEW") && row.IsIdCuentaObservacionTipoPadreNull())
						{
							string IdCuentaObservacionTipo = (string)row["IdCuentaObservacionTipo"];
							foreach(sy_PerfilesDataset.sy_PerfilesRow rowP in _tablePerfiles.Rows)
							{
								long IdPerf = rowP.IdPerfil;
								int index1 = this.getIndexOf("Cuentas.Observaciones.Add.Tipos", IdPerf);
								if(existeVariable("Cuentas.Observaciones.Add.Tipos", IdPerf))
								{
									string valorTA = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"];
									if(!valorTA.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + ",";
								}
								else if(!((string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"]).Equals(string.Empty))
								{
									string valorTA = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"];
									if(!valorTA.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + ",";
								}
								_dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index1]["Valor"] + IdCuentaObservacionTipo;

								int index2 = this.getIndexOf("Cuentas.Observaciones.Ver.Tipos", IdPerf);
								if(existeVariable("Cuentas.Observaciones.Ver.Tipos", IdPerf))
								{
									string valorTV = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"];
									if(!valorTV.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] + ",";
								}
								else if(!((string)_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"]).Equals(string.Empty))
								{
									string valorTV = (string)_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"];
									if(!valorTV.Equals(string.Empty))
										_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] + ",";
								}

								_dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] = _dataPeriles.sy_VariablesPerfiles.Rows[index2]["Valor"] + IdCuentaObservacionTipo;
							}
							//_variablesValores.Add(on.DescripcionTipo, IdCuentaObservacionTipo);
						}
						i++;
					}
					modificaPerfiles = true;
				}
				if(modificaPerfiles)
					dataaccess.sy_VariablesPerfiles.Update(_dataPeriles.sy_VariablesPerfiles, trx);
			}
			else //SI se va a mostrar la pantalla de configuracion de variables
			{
				int i = 0;
				foreach(tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row in _data.tsa_CuentasObservacionesTipos.Rows)
				{
					TipoObservacionNueva on = (TipoObservacionNueva)_tiposObservacionesNuevas[i];
					if(on.Modo.Equals("NEW"))
					{
						string IdCuentaObservacionTipo = (string)row["IdCuentaObservacionTipo"];
						_variablesValores.Add(on.DescripcionTipo, IdCuentaObservacionTipo);
					}
					i++;
				}
			}

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Miembros de IContext

		public ArrayList getDatosNuevos()
		{
			return _tiposObservacionesNuevasCofigVariables;
		}
		public ArrayList getContext()
		{
			ArrayList context = new ArrayList();
			context.Add("Cuentas.Observaciones.Add.SubTipos");
			context.Add("Cuentas.Observaciones.Ver.SubTipos");
			context.Add("Cuentas.Observaciones.Add.Tipos");
			context.Add("Cuentas.Observaciones.Ver.Tipos");
			return context;
		}

		public bool isValorLista()
		{
			return true;
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
			return _tiposObservacionesNuevasCofigVariables.Count > 0;
		}

		public bool isConfiguracionValida(string idVariable, string descripcionDatoNuevo)
		{
			TipoObservacionNueva on = this.getTipoObservacionNueva(descripcionDatoNuevo);
			if(idVariable.IndexOf("SubTipos") < 0 && on.KeyTipoPadre.Equals("RAIZ"))
				return true;
			else if(idVariable.IndexOf("SubTipos") > 0 && !on.KeyTipoPadre.Equals("RAIZ"))
				return true;
			else
				return false;
		}

		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private tsa_CuentasObservacionesTiposDataset _data = new tsa_CuentasObservacionesTiposDataset();
		private sy_VariablesPerfilesDataset _dataPeriles = new sy_VariablesPerfilesDataset();
		private bool _modificaPerfilesTipos = false;
		private bool _modificaPerfilesSubTipos = false;
		private Hashtable _variablesValores = new Hashtable();
		private sy_PerfilesDataset.sy_PerfilesDataTable _tablePerfiles;
		#endregion

		#region Eventos y delegados		
		#endregion

		#region Métodos públicos

		#endregion

		#region Propiedades

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
			bool activo = false;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				table = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetListTipos().Tables[0];
				header = new Node(key, "Tipos de Observaciones");
			}
			else
			{
				table = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetListSubTipos(key).tsa_CuentasObservacionesTipos;
				header = new Node(key, key);
			}

			foreach (System.Data.DataRow rowH in table.Rows) 
			{
				descriptionH = rowH["Descripcion"].ToString();
				keyH = rowH["IdCuentaObservacionTipo"].ToString();
				activo = (bool) rowH["Activo"];
				if(activo)
					descriptionH = descriptionH + " (Activo)";
				else
                    descriptionH = descriptionH + " (Desactivo)";
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
			foreach(object obs in _tiposObservacionesNuevas)
			{
				TipoObservacionNueva on = (TipoObservacionNueva) obs;

				string descripcion= on.DescripcionTipo.Trim();				
				if (descripcion.Equals(string.Empty))
				{
					_errores.Add( new ItemDatasetError( "Cuentas Observaciones Tipos","Descripcion","El campo descripción no puede estar vacío") );
				}
				//Valida la existencia del nuevo tipo en la bd.
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "ValidarTipo";
				bool  validarExisteTipo=Variables.GetValueBool(variable);
				//Si es un alta no tiene q haber otro con esa descripcion
				if (validarExisteTipo && on.Modo =="NEW")
				{
					tsa_CuentasObservacionesTiposDataset DataSetTipos;
					if(on.KeyTipoPadre == "RAIZ")
                        DataSetTipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetList("", false);
					else
						DataSetTipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetList(on.KeyTipoPadre, false);

					if (DataSetTipos.Tables[0].Rows.Count>0 )
					{
						foreach (tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow _row in  DataSetTipos.Tables[0].Rows)
							if ((string)_row["Descripcion"]== descripcion)
							{
								_errores.Add( new ItemDatasetError( "Cuentas Observaciones Tipos","Descripcion","Ya existe otro tipo con ese nombre") );	
							}
				
					}
				} 
				if (validarExisteTipo && on.Modo !="NEW")
				{
					tsa_CuentasObservacionesTiposDataset DataSetTipos;
					if(on.KeyTipoPadre == "RAIZ")
						DataSetTipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetList("", false);
					else
						DataSetTipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetList(on.KeyTipoPadre, false);
					if (DataSetTipos.Tables[0].Rows.Count>0)
					{
						foreach (tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow _row in  DataSetTipos.Tables[0].Rows)
							if ((string)_row["IdCuentaObservacionTipo"]!= on.KeyTipo && (string)_row["Descripcion"]==on.DescripcionTipo)
							{
								_errores.Add( new ItemDatasetError( "Cuentas Observaciones Tipos","Descripcion","Ya existe otro tipo con ese nombre") );	
							}
				
					}
				}
			}
		}

		private void agregarTipoOservacion(string DescripcionTipo, string KeyTipo, string KeyTipoPadre, string DescripcionTipoPadre, bool Activo, string Modo)
		{
			int i = 0;
			bool exist = false;
			TipoObservacionNueva o = null;
			while(!exist & i < _tiposObservacionesNuevas.Count)
			{
				o = (TipoObservacionNueva)_tiposObservacionesNuevas[i];
				if(o.KeyTipo.Equals(KeyTipo))
					exist = true;
				else
					i++;
			}
			if(exist)
			{
				o.DescripcionTipo = DescripcionTipo;
				o.Activo = Activo;
			}
			else			
				_tiposObservacionesNuevas.Add(new TipoObservacionNueva(DescripcionTipo, KeyTipo, KeyTipoPadre, DescripcionTipoPadre, Activo, Modo));
		}

		private bool agregarVariable(string idVariable, long idPerfil)
		{
			bool existeVariable = false;
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowV = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(idVariable, idPerfil);
			if(rowV == null)
			{
				rowV = _dataPeriles.sy_VariablesPerfiles.Newsy_VariablesPerfilesRow();
				rowV.IdVariable = idVariable;
				rowV.IdPerfil = idPerfil;					
				rowV.Valor = string.Empty;
				rowV.FechaCreacion = DateTime.Now;
				rowV.IdConexionCreacion = Security.IdConexion;
				_dataPeriles.sy_VariablesPerfiles.Addsy_VariablesPerfilesRow(rowV);
			}
			else
			{
				existeVariable = true;
				_dataPeriles.sy_VariablesPerfiles.ImportRow(rowV);
			}
			return existeVariable;
		}

		private bool existeVariable(string idVariable, long idPerfil)
		{
			bool existeVariable = false;
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowV = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(idVariable, idPerfil);
			return (rowV != null);
		}
		
		private int getIndexOf(string idVariable, long idPerfil)
		{
			int index = -1;
			int i = 0;
			while(index < 0 && _dataPeriles.sy_VariablesPerfiles.Rows.Count > i)
			{
				string idV = (string)_dataPeriles.sy_VariablesPerfiles.Rows[i]["IdVariable"];
				long idP = (long)_dataPeriles.sy_VariablesPerfiles.Rows[i]["IdPerfil"];
				if(idV.Equals(idVariable) && idP.Equals(idPerfil))
					index = i;
				else 
					i++;
			}	
			return index;
		}
		private TipoObservacionNueva getTipoObservacionNueva(string DescripcionTipo)
		{
			TipoObservacionNueva on = null;
			int i = 0;
			bool exist = false;
			TipoObservacionNueva o = null;
			while(!exist && i < _tiposObservacionesNuevasCofigVariables.Count)
			{
				on = (TipoObservacionNueva)_tiposObservacionesNuevasCofigVariables[i];
				if(on.DescripcionTipo.Equals(DescripcionTipo))
					exist = true;
				else
					i++;
			}
			return on;
		}
		#endregion

		#region Miembros de ITiposObservaciones
		public event System.EventHandler TiposObservacionesNuevasHasChanged;

		public void AddMovimiento(string DescripcionTipo, string KeyTipo, string KeyTipoPadre, string DescripcionTipoPadre, bool Activo, string Modo)
		{		
			if (Modo == "NEW")
			{
				//Creacion de tipo de observaciones
				KeyTipo = systemframework.Util.NewStringId();
				TipoObservacionNueva on = new TipoObservacionNueva(DescripcionTipo, KeyTipo, KeyTipoPadre, DescripcionTipoPadre, Activo, Modo);
				_tiposObservacionesNuevas.Add(on);
				_tiposObservacionesNuevasCofigVariables.Add(on);
			}
			else
				this.agregarTipoOservacion(DescripcionTipo, KeyTipo, KeyTipoPadre, DescripcionTipoPadre, Activo, Modo);
			if(TiposObservacionesNuevasHasChanged != null)
				TiposObservacionesNuevasHasChanged(this, new EventArgs());	
		}
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
		public bool PreguntarAlCancelar()
		{
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
			return _preguntarAlCancelar;
		}

		private System.Collections.ArrayList _tiposObservacionesNuevas = new ArrayList();
		public System.Collections.ArrayList TiposObservacionesNuevas()
		{
			return _tiposObservacionesNuevas;
		}
		
		private System.Collections.ArrayList _tiposObservacionesNuevasCofigVariables = new ArrayList();
		public System.Collections.ArrayList TiposObservacionesNuevasConfigVariables()
		{
			return _tiposObservacionesNuevasCofigVariables;
		}

		#endregion

	}

	public class TipoObservacionNueva: IDatoNuevo
	{
		#region Constructores
		public TipoObservacionNueva()
		{
		}
		public TipoObservacionNueva(string DescripcionTipo, string KeyTipo, string KeyTipoPadre, string DescripcionTipoPadre, bool Activo, string Modo)
		{		
			_descripcionTipo = DescripcionTipo;			
			_keyTipo = KeyTipo;
            _keyTipoPadre = KeyTipoPadre;
			_descripcionTipoPadre = DescripcionTipoPadre;	
			_activo = Activo;
			_modo = Modo;
		}
		#endregion

		#region Propiedades
		private string _keyTipo;
		public string KeyTipo 
		{
			get {return _keyTipo;}
		}

		private string _descripcionTipo;
		public string DescripcionTipo 
		{
			get {return _descripcionTipo;}
			set {_descripcionTipo = value;}
		}
		private string _keyTipoPadre;
		public string KeyTipoPadre 
		{
			get {return _keyTipoPadre;}
		}
		private string _descripcionTipoPadre;
		public string DescripcionTipoPadre 
		{
			get {return _descripcionTipoPadre;}
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
		}

		#endregion

		#region Miembros de IDatoNuevo
		
		public string getDescripcionDatoNuevo()
		{
			return _descripcionTipo;
		}
		#endregion
		public override String ToString()
		{
			string str = _descripcionTipo;
			if(_keyTipoPadre != "RAIZ")
				str = str + " (Subtipo)";
			else
				str = str + " (Tipo)";
			return str;
		}

	}
}



