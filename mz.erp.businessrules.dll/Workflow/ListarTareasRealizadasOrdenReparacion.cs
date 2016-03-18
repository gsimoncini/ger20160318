using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data.SqlClient;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ListarTareasRealizadasOrdenReparacion.
	/// </summary>
	public class ListarTareasRealizadasOrdenReparacion: ITask, IPersistentTask
	{
		#region Constructores
		public ListarTareasRealizadasOrdenReparacion()
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
			st_FallaDataset.st_FallaDataTable serviciosEnBD = st_Falla.GetList().st_Falla;
			foreach(st_FallaDataset.st_FallaRow rowServ in serviciosEnBD.Rows)
			{
				ArrayList tareas = new ArrayList();
				long IdFalla = rowServ.IdFalla;
				string Descripcion = rowServ.Descripcion;
				int DuracionDias = rowServ.DuracionDias;
				decimal Costo = rowServ.Costo;
				decimal CostoMaximo = rowServ.CostoMaximo;
				decimal CostoPresupuesto = rowServ.CostoPresupuesto;
				st_ServicioTareasDataset.st_ServicioTareasDataTable tableST = st_ServicioTareas.GetList(IdFalla).st_ServicioTareas;
				Servicio servicio = new Servicio(IdFalla, Descripcion, DuracionDias, Costo, CostoMaximo, CostoPresupuesto, tareas, string.Empty);
				_servicios.Add(servicio);
			}
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
			if(_estadisticaOrdenReparacionSeleccionada != null)
			{
				st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow rowEstOR = mz.erp.businessrules.st_EstadisticaOrdenReparacion.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion);
				if(rowEstOR == null) // No existe la orden en st_EstadisticaOrdenReparacion
				{
					rowEstOR = _dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.Newst_EstadisticaOrdenReparacionRow();
					rowEstOR.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
					rowEstOR.Cerrado = _estadisticaOrdenReparacionSeleccionada.Cerrado;
					if(_estadisticaOrdenReparacionSeleccionada.FechaCierre.Equals(DateTime.MinValue))
                        rowEstOR["FechaCierre"] = System.DBNull.Value;
					else
						rowEstOR.FechaCierre = _estadisticaOrdenReparacionSeleccionada.FechaCierre;
					if(_estadisticaOrdenReparacionSeleccionada.NumeroRemito.Equals(string.Empty))
						rowEstOR["NumeroRemito"] = System.DBNull.Value;
					else
						rowEstOR.NumeroRemito = _estadisticaOrdenReparacionSeleccionada.NumeroRemito;
					if(_estadisticaOrdenReparacionSeleccionada.TiempoDeEspera.Equals(Decimal.MinValue))
						rowEstOR["TiempoDeEspera"] = System.DBNull.Value;
					else
						rowEstOR.TiempoDeEspera = _estadisticaOrdenReparacionSeleccionada.TiempoDeEspera;
					rowEstOR.FechaCreacion = DateTime.Now;
					rowEstOR.IdConexionCreacion = Security.IdConexion;
					_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.Addst_EstadisticaOrdenReparacionRow(rowEstOR);

				}
				else
				{
					rowEstOR.Cerrado = _estadisticaOrdenReparacionSeleccionada.Cerrado;
					if(_estadisticaOrdenReparacionSeleccionada.FechaCierre.Equals(DateTime.MinValue))
						rowEstOR["FechaCierre"] = System.DBNull.Value;
					else
						rowEstOR.FechaCierre = _estadisticaOrdenReparacionSeleccionada.FechaCierre;
					if(_estadisticaOrdenReparacionSeleccionada.NumeroRemito.Equals(string.Empty))
						rowEstOR["NumeroRemito"] = System.DBNull.Value;
					else
						rowEstOR.NumeroRemito = _estadisticaOrdenReparacionSeleccionada.NumeroRemito;
					if(_estadisticaOrdenReparacionSeleccionada.TiempoDeEspera.Equals(Decimal.MinValue))
						rowEstOR["TiempoDeEspera"] = System.DBNull.Value;
					else
						rowEstOR.TiempoDeEspera = _estadisticaOrdenReparacionSeleccionada.TiempoDeEspera;
					_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.ImportRow(rowEstOR);
				}				

				
				foreach(EstadisticaOrdenReparacionDet estORDet in _estadisticaOrdenReparacionSeleccionada.TareasRealizadas)
				{					
					st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow rowEstORDet = mz.erp.businessrules.st_EstadisticaOrdenReparacionDet.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, estORDet.IdInstanciaOrdenReparacion, estORDet.IdTarea);
					if(rowEstORDet == null) // No existe la instancia en st_EstadisticaOrdenReparacionDet
					{
						rowEstORDet = _dataEstadisticaOrdenReparacionDet.st_EstadisticaOrdenReparacionDet.Newst_EstadisticaOrdenReparacionDetRow();
						rowEstORDet.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
						rowEstORDet.IdInstaciaOrdenReparacion = estORDet.IdInstanciaOrdenReparacion;
						rowEstORDet.Cantidad = estORDet.TiempoTecnico;
						rowEstORDet.IdTarea = estORDet.IdTarea;
						rowEstORDet.Complejidad = estORDet.Complejidad;
						rowEstORDet.ValorTecnico = estORDet.ValorTecnico;
						rowEstORDet.ValorTecnicoProvisorio = estORDet.ValorTecnicoProvisorio;
						rowEstORDet.ValorCliente = estORDet.ValorCliente;
						rowEstORDet.Subtotal = estORDet.ValorTarea;
						rowEstORDet.FechaCreacion = DateTime.Now;
						rowEstORDet.IdConexionCreacion = Security.IdConexion;
						_dataEstadisticaOrdenReparacionDet.st_EstadisticaOrdenReparacionDet.Addst_EstadisticaOrdenReparacionDetRow(rowEstORDet);

					}
					else
					{
						rowEstORDet.Complejidad = estORDet.Complejidad;
						rowEstORDet.Cantidad = estORDet.TiempoTecnico;
						rowEstORDet.ValorTecnico = estORDet.ValorTecnico;
						rowEstORDet.ValorTecnicoProvisorio = estORDet.ValorTecnicoProvisorio;
						rowEstORDet.ValorCliente = estORDet.ValorCliente;
						rowEstORDet.Subtotal = estORDet.ValorTarea;
						_dataEstadisticaOrdenReparacionDet.st_EstadisticaOrdenReparacionDet.ImportRow(rowEstORDet);
					}			

					foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estTMotivo in estORDet.Motivos)
					{
						switch(estTMotivo.Estado)
						{
							case "NEW": //Nuevo motivo tarea
							{
								st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowTMotivo = _dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow();
								rowTMotivo.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
								rowTMotivo.IdInstanciaOrdenReparacion = estORDet.IdInstanciaOrdenReparacion;
								rowTMotivo.IdTarea = estORDet.IdTarea;
								rowTMotivo.IdMotivo = estTMotivo.IdMotivo;
								rowTMotivo.EsVerdadero = estTMotivo.EsVerdadero;
								rowTMotivo.FechaCreacion = DateTime.Now;
								rowTMotivo.IdConexionCreacion = Security.IdConexion;
								_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow(rowTMotivo);
								break;

							}
							case "MODIF": //Modificacion de motivo tarea
							{
								st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowTMotivo = st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, estORDet.IdInstanciaOrdenReparacion,  estORDet.IdTarea, estTMotivo.IdMotivo);
								if(rowTMotivo.EsVerdadero != estTMotivo.EsVerdadero)
								{
									foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estTMotivoHijo in estTMotivo.MotivosHijos)
									{
										if(estTMotivo.EsVerdadero != estTMotivoHijo.EsMotivoVerdadero && estTMotivoHijo.Estado.Equals("EXISTE"))
											estTMotivoHijo.Estado = "DEL";									
									}
								}
								rowTMotivo.EsVerdadero = estTMotivo.EsVerdadero;
								_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.ImportRow(rowTMotivo);
								break;
							}
						}
						foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estTMotivoHijo in estTMotivo.MotivosHijos)
						{
							switch(estTMotivoHijo.Estado)
							{
								case "NEW": //Nuevo motivo tarea hijo seleccionado
								{
									st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowTMotivoH = _dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow();
									rowTMotivoH.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
									rowTMotivoH.IdInstanciaOrdenReparacion = estORDet.IdInstanciaOrdenReparacion;
									rowTMotivoH.IdTarea = estORDet.IdTarea;
									rowTMotivoH.IdMotivo = estTMotivoHijo.IdMotivo;
									rowTMotivoH.FechaCreacion = DateTime.Now;
									rowTMotivoH.IdConexionCreacion = Security.IdConexion;
									_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow(rowTMotivoH);
									break;

								}
								case "DEL": //Borrado de motivo tarea hijo por no estar mas seleccionado
								{									
									st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowTMotivoH = st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, estORDet.IdInstanciaOrdenReparacion,  estORDet.IdTarea, estTMotivoHijo.IdMotivo);
									rowTMotivoH.Delete();
									_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.ImportRow(rowTMotivoH);
									break;											
								}
							}
						}

					}

				}

				foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estORMotivo in _estadisticaOrdenReparacionSeleccionada.Motivos)
				{
					switch(estORMotivo.Estado)
					{
						case "NEW": //Nuevo motivo  
						{
							st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowORMotivo = _dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow();
							rowORMotivo.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
							rowORMotivo.IdMotivo = estORMotivo.IdMotivo;
                            rowORMotivo.EsVerdadero = estORMotivo.EsVerdadero;
							rowORMotivo.FechaCreacion = DateTime.Now;
							rowORMotivo.IdConexionCreacion = Security.IdConexion;
							_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow(rowORMotivo);
							break;

						}
						case "MODIF": //Modificacion de motivo
						{
							st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowORMotivo = st_EstadisticaOrdenReparacionMotivoOrdenReparacion.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, estORMotivo.IdMotivo);
							if(rowORMotivo.EsVerdadero != estORMotivo.EsVerdadero)
							{
								foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estORMotivoHijo in estORMotivo.MotivosHijos)
								{
									if(estORMotivo.EsVerdadero != estORMotivoHijo.EsMotivoVerdadero && estORMotivoHijo.Estado.Equals("EXISTE"))
                                        estORMotivoHijo.Estado = "DEL";									
								}
							}
							rowORMotivo.EsVerdadero = estORMotivo.EsVerdadero;
							_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.ImportRow(rowORMotivo);
							break;
						}
					}
					foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion estORMotivoHijo in estORMotivo.MotivosHijos)
					{
						switch(estORMotivoHijo.Estado)
						{
							case "NEW": //Nuevo motivo hijo seleccionado
							{
								st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowORMotivoH = _dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow();
								rowORMotivoH.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
								rowORMotivoH.IdMotivo = estORMotivoHijo.IdMotivo;
								rowORMotivoH.FechaCreacion = DateTime.Now;
								rowORMotivoH.IdConexionCreacion = Security.IdConexion;
								_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow(rowORMotivoH);
								break;

							}
							case "DEL": //Borrado de motivo hijo por no estar mas seleccionado
							{
								st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowORMotivoH = st_EstadisticaOrdenReparacionMotivoOrdenReparacion.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, estORMotivoHijo.IdMotivo);
								rowORMotivoH.Delete();
								_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.ImportRow(rowORMotivoH);
								break;											
							}
						}
					}

				}
				// Agrego en st_EstadisticaOrdenReparacionModificacionTecnico
				long IdTecnico = st_EstadisticaOrdenReparacionModificacionTecnico.GetIdTecnicoByIdPersona(Security.IdPersona);
				if(!IdTecnico.Equals(long.MinValue))//Si es un Tecnico
				{
					st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow rowEORModifTecnico = st_EstadisticaOrdenReparacionModificacionTecnico.GetByPk(_estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion, IdTecnico);
					if(rowEORModifTecnico == null)// No existe la orden en st_EstadisticaOrdenReparacionModificacionTecnico
					{
						rowEORModifTecnico = _dataEstadisticaOrdenReparacionModificacionTecnico.st_EstadisticaOrdenReparacionModificacionTecnico.Newst_EstadisticaOrdenReparacionModificacionTecnicoRow();
						rowEORModifTecnico.IdOrdenReparacion = _estadisticaOrdenReparacionSeleccionada.IdOrdenReparacion;
						rowEORModifTecnico.IdTecnico = IdTecnico;
						rowEORModifTecnico.FechaUltimaModificacion = DateTime.Now.Date;
						rowEORModifTecnico.FechaCreacion = DateTime.Now;
						rowEORModifTecnico.IdConexionCreacion = Security.IdConexion;
						_dataEstadisticaOrdenReparacionModificacionTecnico.st_EstadisticaOrdenReparacionModificacionTecnico.Addst_EstadisticaOrdenReparacionModificacionTecnicoRow(rowEORModifTecnico);
					}
					else
					{
						rowEORModifTecnico.FechaUltimaModificacion = DateTime.Now;
						_dataEstadisticaOrdenReparacionModificacionTecnico.st_EstadisticaOrdenReparacionModificacionTecnico.ImportRow(rowEORModifTecnico);
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

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			data.Add(_dataEstadisticaOrdenReparacion);
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
			dataaccess.st_EstadisticaOrdenReparacion.Update(_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion, trx);
			dataaccess.st_EstadisticaOrdenReparacionDet.Update(_dataEstadisticaOrdenReparacionDet.st_EstadisticaOrdenReparacionDet, trx);
			dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Update(_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion, trx);
			dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.Update(_dataEstadisticaOrdenReparacionModificacionTecnico.st_EstadisticaOrdenReparacionModificacionTecnico, trx);
			dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Update(_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet, trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private st_EstadisticaOrdenReparacionDataset _dataEstadisticaOrdenReparacion = new st_EstadisticaOrdenReparacionDataset();
		private st_EstadisticaOrdenReparacionDetDataset _dataEstadisticaOrdenReparacionDet = new st_EstadisticaOrdenReparacionDetDataset();
		private st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset _dataEstadisticaOrdenReparacionMotivoOrdenReparacion = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset();
		private st_EstadisticaOrdenReparacionModificacionTecnicoDataset _dataEstadisticaOrdenReparacionModificacionTecnico = new st_EstadisticaOrdenReparacionModificacionTecnicoDataset();
		private st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset _dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset();
		#endregion

		#region Eventos y Delegados
		public event EventHandler IdServiciosSelecionadosChanged;
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

		private string _leyendaFormulario = "Configuración de Menues";
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
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

		private bool _listaServiciosOrdenReparacionHabilitada = false;
		public bool ListaServiciosOrdenReparacionHabilitada
		{
			get 
			{		
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "ListaServicios.Habilitada";
				_listaServiciosOrdenReparacionHabilitada = Variables.GetValueBool(variable);
				return _listaServiciosOrdenReparacionHabilitada;
			}
		}

		private ArrayList _servicios = new ArrayList();
		public ArrayList Servicios
		{
			get {return _servicios;}
		}

		public ArrayList Result
		{
			get
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
                    return _estadisticaOrdenReparacionSeleccionada.TareasRealizadas;
				else
					return new ArrayList();
			}
		}

		private DataTable _resultAsTable = new DataTable();
		public DataTable ResultAsTable
		{
			get
			{
					return _resultAsTable;
			}
		}

		private long _idOrdenReparacion;
		public long IdOrdenReparacion
		{
			get{return _idOrdenReparacion;}
			set
			{				 
				if(_idOrdenReparacion != value)
				{
					_idOrdenReparacion = value;	
					_idServiciosSeleccionados = this.GetServiciosOrdenReparacion(_idOrdenReparacion);
					if(IdServiciosSelecionadosChanged != null)
						IdServiciosSelecionadosChanged(this, new EventArgs());
				}
			}
		}

		private ArrayList _idServiciosSeleccionados = new ArrayList();
		public ArrayList IdServiciosSelecionados
		{
			get{return _idServiciosSeleccionados;}
			set{_idServiciosSeleccionados = value;}
		}

		private decimal _total = 0;
		public decimal Total
		{
			get{return _total;}
			set
			{				 
				if(_total != value)
				{
					_total = value;						
				}
			}
		}

		private decimal _totalTecnico = 0;
		public decimal TotalTecnico
		{
			get{return _totalTecnico;}
			set
			{				 
				if(_totalTecnico != value)
				{
					_totalTecnico = value;						
				}
			}
		}

		private bool _validaCompletarDatosOrdenSTD = false;
		public bool ValidaCompletarDatosOrdenSTD
		{
			get{return _validaCompletarDatosOrdenSTD;}
			set
			{				 
				if(_validaCompletarDatosOrdenSTD != value)
				{
					_validaCompletarDatosOrdenSTD = value;						
				}
			}
		}

		private EstadisticaOrdenReparacion _estadisticaOrdenReparacionSeleccionada = null;
		public EstadisticaOrdenReparacion EstadisticaOrdenReparacionSeleccionada
		{
			get{return _estadisticaOrdenReparacionSeleccionada;}
			set
			{				 
				_estadisticaOrdenReparacionSeleccionada = value;						
				
			}
		}

		public ArrayList MotivosHijos
		{
			get
			{
				if(_estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado != null)
				{ 
					ArrayList motivosH = new ArrayList();
					foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion motH in _estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado.MotivosHijos)
					{
						if(_estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado.EsVerdadero && motH.EsMotivoVerdadero)
							motivosH.Add(motH);
						else if(_estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado.EsFalso && !motH.EsMotivoVerdadero)
							motivosH.Add(motH);
					}
					return motivosH;
				}
				else
					return new ArrayList();
			}
		}

		public ArrayList MotivosPadres
		{
			get
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					return _estadisticaOrdenReparacionSeleccionada.Motivos;
				else
					return new ArrayList();
			}
		}

		public ArrayList ObservacionesOrdenReparacion
		{
			get
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					return _estadisticaOrdenReparacionSeleccionada.Observaciones;
				else
					return new ArrayList();
			}
		}

		private EstadisticaOrdenReparacionMotivoOrdenReparacion _estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado = null;
		public EstadisticaOrdenReparacionMotivoOrdenReparacion EstadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado
		{
			get{return _estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado;}
			set
			{				 
				_estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado = value;						
				
			}
		}

		public string NumeroRemito
		{
			get
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					return _estadisticaOrdenReparacionSeleccionada.NumeroRemito;
				else
					return string.Empty;
			}

			set
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					_estadisticaOrdenReparacionSeleccionada.NumeroRemito = value;
			}
		}

		public decimal TiempoDeEspera
		{
			get
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					return _estadisticaOrdenReparacionSeleccionada.TiempoDeEspera;
				else
					return decimal.MinValue;
			}

			set
			{
				if(_estadisticaOrdenReparacionSeleccionada != null)
					_estadisticaOrdenReparacionSeleccionada.TiempoDeEspera = value;
			}
		}

		private EstadisticaOrdenReparacionDet _tareaSeleccionada = null;
		public EstadisticaOrdenReparacionDet TareaSeleccionada
		{
			get{return _tareaSeleccionada;}
			set
			{		
				EstadisticaOrdenReparacionDet tareaS = (EstadisticaOrdenReparacionDet)value;
				int index = _estadisticaOrdenReparacionSeleccionada.TareasRealizadas.IndexOf(tareaS);
				_tareaSeleccionada = (EstadisticaOrdenReparacionDet)_estadisticaOrdenReparacionSeleccionada.TareasRealizadas[index];						
				
			}
		}

		private EstadisticaOrdenReparacionMotivoOrdenReparacion _estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado = null;
		public EstadisticaOrdenReparacionMotivoOrdenReparacion EstadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado
		{
			get{return _estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado;}
			set
			{				 
				_estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado = value;						
				
			}
		}


		public ArrayList MotivosTareaHijos
		{
			get
			{
				if(_tareaSeleccionada != null && _estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado != null)
				{ 
					ArrayList motivosH = new ArrayList();
					foreach(EstadisticaOrdenReparacionMotivoOrdenReparacion motH in _estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado.MotivosHijos)
					{
						if(_estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado.EsVerdadero && motH.EsMotivoVerdadero)
							motivosH.Add(motH);
						else if(_estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado.EsFalso && !motH.EsMotivoVerdadero)
							motivosH.Add(motH);
					}
					return motivosH;
				}
				else
					return new ArrayList();
			}
		}

		public ArrayList MotivosTareaPadres
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.Motivos;
				else
					return new ArrayList();
			}
		}


		public bool PermiteModificarOrdenReparacion
		{
			get
			{
				return _estadisticaOrdenReparacionSeleccionada != null && (!_estadisticaOrdenReparacionSeleccionada.Cerrado || (_estadisticaOrdenReparacionSeleccionada.Cerrado && _estadisticaOrdenReparacionSeleccionada.FechaCierre > _estadisticaOrdenReparacionSeleccionada.FechaUltimaModificacionTecnico));
			}
		}

		#endregion

		#region Métodos públicos
		public void RefreshData()
		{
			DataTable motivosPadresTable = mz.erp.businessrules.tsy_MotivoOrdenReparacion.GetListPadres().Tables[0];
			ArrayList motivos = new ArrayList();
			foreach (System.Data.DataRow row in motivosPadresTable.Rows)
			{
				string estadoPadre = string.Empty;
				long IdMotivo = Convert.ToInt64(row["IdMotivo"]);
				string Descripcion = row["Descripcion"].ToString();
				bool esVerdadero = false;
				bool esFalso = false;
				st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowMotivo = st_EstadisticaOrdenReparacionMotivoOrdenReparacion.GetByPk(_idOrdenReparacion, IdMotivo);
				if(rowMotivo != null)
				{
					esVerdadero = rowMotivo.EsVerdadero;
					esFalso = !esVerdadero;
					estadoPadre = "EXISTE"; 
				}
				ArrayList motivosHijos = new ArrayList();
				DataTable motivosHijosTable = mz.erp.businessrules.tsy_MotivoOrdenReparacion.GetListHijos(IdMotivo).Tables[0];
				foreach (System.Data.DataRow rowH in motivosHijosTable.Rows)
				{
					long IdMotivoH = Convert.ToInt64(rowH["IdMotivo"]);
					string DescripcionH = rowH["Descripcion"].ToString();
					bool esVerdaderoMotivoH = Convert.ToBoolean(rowH["EsVerdadero"]);
					st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow rowMotivoH = st_EstadisticaOrdenReparacionMotivoOrdenReparacion.GetByPk(_idOrdenReparacion, IdMotivoH);
					EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH;
					if(rowMotivoH != null)
						motivoH = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivoH, IdMotivo, esVerdaderoMotivoH, DescripcionH, false, false, new ArrayList(), "EXISTE");
					else
						motivoH = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivoH, IdMotivo, esVerdaderoMotivoH, DescripcionH, false, false,  new ArrayList(), string.Empty);
					motivosHijos.Add(motivoH);
				}
				EstadisticaOrdenReparacionMotivoOrdenReparacion motivo = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivo, long.MinValue, false, Descripcion, esVerdadero, esFalso, motivosHijos, estadoPadre);
				motivos.Add(motivo);

			}			

		    ArrayList tareasRealizadas = new ArrayList();
			string IdPersonaLogueada = Security.IdPersona;
			if(Security.IdPerfil.Equals(Convert.ToInt64(14))) //Si es supervisor
				IdPersonaLogueada = string.Empty;
			System.Data.DataSet data = mz.erp.businessrules.st_OrdenReparacion.ListarTareasRealizadas( _idOrdenReparacion, IdPersonaLogueada);
			DataTable table = data.Tables[0];
			_total = 0;
			_totalTecnico = 0;
 
			DataColumn col = new DataColumn("Lugar", typeof(string) );									
			table.Columns.Add(col);
			/** Para los estilos de la grilla*/
			DataColumn col1 = new DataColumn("BackColorRojo", typeof(int) );
			table.Columns.Add(col1);
			DataColumn col2 = new DataColumn("ForeColorVerde", typeof(int) );	
			table.Columns.Add(col2);
			DataColumn col3 = new DataColumn("BackColorRojoForeColorVerde", typeof(int) );	
			table.Columns.Add(col3);

			bool Cerrado = false;
			DateTime FechaCierre = DateTime.MinValue;
			string NumeroRemito = string.Empty;
			decimal TiempoDeEspera = 0;
			st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow RowEOR = st_EstadisticaOrdenReparacion.GetByPk(_idOrdenReparacion);
			if(RowEOR != null)
			{
				Cerrado = RowEOR.Cerrado;
				if(RowEOR["FechaCierre"] != System.DBNull.Value)
                    FechaCierre = RowEOR.FechaCierre;
				if(RowEOR["NumeroRemito"] != System.DBNull.Value)
					NumeroRemito = RowEOR.NumeroRemito;
				if(RowEOR["TiempoDeEspera"] != System.DBNull.Value)
					TiempoDeEspera = RowEOR.TiempoDeEspera;
			}


			foreach(DataRow row in table.Rows)
			{                                                         
				long IdInstanciaOrdenReparacion = Convert.ToInt64(row["IdInstanciaOrdenReparacion"]);
				long IdTarea = Convert.ToInt64(row["IdTarea"]);
				string Cliente = Convert.ToString(row["Cliente"]);
				string Tarea = Convert.ToString(row["Tarea"]);				
				decimal TiempoTecnico = 0;
				if(row["TiempoTecnico"] != null && row["TiempoTecnico"] != System.DBNull.Value)
					TiempoTecnico = Convert.ToDecimal(row["TiempoTecnico"]);
				decimal TiempoTarea = 0;
				if(row["TiempoTarea"] != null && row["TiempoTarea"] != System.DBNull.Value)
					TiempoTarea = Convert.ToDecimal(row["TiempoTarea"]);
				string Complejidad = Convert.ToString(row["Complejidad"]);
				decimal ValorTecnico = 0;
				if(row["ValorTecnico"] != null && row["ValorTecnico"] != System.DBNull.Value)
					ValorTecnico = Convert.ToDecimal(row["ValorTecnico"]);
				decimal ValorTecnicoProvisorio = 0;
				if(row["ValorTecnicoProvisorio"] != null && row["ValorTecnicoProvisorio"] != System.DBNull.Value)
					ValorTecnicoProvisorio = Convert.ToDecimal(row["ValorTecnicoProvisorio"]);
				decimal ValorCliente = 0;
				if(row["ValorCliente"] != null && row["ValorCliente"] != System.DBNull.Value)
					ValorCliente = Convert.ToDecimal(row["ValorCliente"]);
				decimal ValorTarea = 0;
				if(row["ValorTarea"] != null && row["ValorTarea"] != System.DBNull.Value)
					ValorTarea = Convert.ToDecimal(row["ValorTarea"]);
				string Tecnico = Convert.ToString(row["Tecnico"]);
				string Servicio = Convert.ToString(row["Servicio"]);
				string EstadoOrdenReparacion = Convert.ToString(row["EstadoOrdenReparacion"]);
				string IdPersona = Convert.ToString(row["IdPersona"]);

				string Lugar = string.Empty;
				if(row["Origen"] != null && row["Origen"] != System.DBNull.Value)
				{
					short Origen = Convert.ToInt16(row["Origen"]);
					if(Origen == 1)
						Lugar = "LP - ";
					else
						Lugar = "Hudson - ";
				}
				if(row["TipoServicio"] != null && row["TipoServicio"] != System.DBNull.Value)
				{
					short TipoServicio = Convert.ToInt16(row["TipoServicio"]);
					if(TipoServicio == 1)
						Lugar = Lugar + "ST";
					else 
					{
						Lugar = Lugar + "Dom";
						_validaCompletarDatosOrdenSTD = true;
					}
				}
				_total = 0;
				if(row["Total"] != null && row["Total"] != System.DBNull.Value)
					_total = Decimal.Round(Convert.ToDecimal(row["Total"]),2);
				if(IdPersona.Equals(Security.IdPersona))
                    _totalTecnico = _totalTecnico + (ValorTecnicoProvisorio * TiempoTecnico);
				row["Lugar"] = Lugar;

				st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow rowEORDet = st_EstadisticaOrdenReparacionDet.GetByPk(_idOrdenReparacion, IdInstanciaOrdenReparacion, IdTarea);
				if(rowEORDet != null)
				{
					TiempoTecnico = rowEORDet.Cantidad;
					ValorTecnico = rowEORDet.ValorTecnico;
					ValorTecnicoProvisorio = rowEORDet.ValorTecnicoProvisorio;
					ValorCliente = rowEORDet.ValorCliente;
					ValorTarea = rowEORDet.Subtotal;
				}

				ArrayList motivosTarea = new ArrayList();
				foreach (System.Data.DataRow rowMT in motivosPadresTable.Rows)
				{
					string estadoPadre = string.Empty;
					long IdMotivo = Convert.ToInt64(rowMT["IdMotivo"]);
					string Descripcion = rowMT["Descripcion"].ToString();
					bool esVerdadero = false;
					bool esFalso = false;
					st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowMotivoTarea = st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetByPk(_idOrdenReparacion, IdInstanciaOrdenReparacion, IdTarea, IdMotivo);
					if(rowMotivoTarea != null)
					{
						esVerdadero = rowMotivoTarea.EsVerdadero;
						esFalso = !esVerdadero;
						estadoPadre = "EXISTE"; 
					}					
					ArrayList motivosHijosTarea = new ArrayList();
					DataTable motivosTareasHijosTable = mz.erp.businessrules.tsy_MotivoOrdenReparacion.GetListHijos(IdMotivo).Tables[0];
					foreach (System.Data.DataRow rowH in motivosTareasHijosTable.Rows)
					{
						long IdMotivoH = Convert.ToInt64(rowH["IdMotivo"]);
						string DescripcionH = rowH["Descripcion"].ToString();
						bool esVerdaderoMotivoH = Convert.ToBoolean(rowH["EsVerdadero"]);
						st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow rowMotivoTareaH = st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetByPk(_idOrdenReparacion, IdInstanciaOrdenReparacion, IdTarea, IdMotivoH);
						EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH;
						if(rowMotivoTareaH != null)
							motivoH = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivoH, IdMotivo, esVerdaderoMotivoH, DescripcionH, false, false, new ArrayList(), "EXISTE");
						else
							motivoH = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivoH, IdMotivo, esVerdaderoMotivoH, DescripcionH, false, false,  new ArrayList(), string.Empty);
						motivosHijosTarea.Add(motivoH);
					}
					EstadisticaOrdenReparacionMotivoOrdenReparacion motivoTarea = new EstadisticaOrdenReparacionMotivoOrdenReparacion(IdMotivo, long.MinValue, false, Descripcion, esVerdadero, esFalso, motivosHijosTarea, estadoPadre);
					motivosTarea.Add(motivoTarea);

				}			
				TiempoTecnico = Decimal.Round(TiempoTecnico,2);
				TiempoTarea = Decimal.Round(TiempoTarea,2);
				ValorTecnico = Decimal.Round(ValorTecnico,2);
				ValorTecnicoProvisorio = Decimal.Round(ValorTecnicoProvisorio,2);
				ValorCliente = Decimal.Round(ValorCliente,2);
				ValorTarea = Decimal.Round(ValorTarea,2);


				EstadisticaOrdenReparacionDet tareaRealizada = new EstadisticaOrdenReparacionDet(_idOrdenReparacion, IdInstanciaOrdenReparacion, Cliente, Tarea, Lugar, TiempoTecnico, TiempoTarea, IdTarea, Complejidad, ValorTecnico, ValorTecnicoProvisorio, ValorCliente, ValorTarea, Tecnico, Servicio, EstadoOrdenReparacion, IdPersona, motivosTarea);

				long idServ = long.MinValue;
				if(row["IdFalla"] != null && row["IdFalla"] != System.DBNull.Value)
					idServ = Convert.ToInt64(row["IdFalla"]);
				if(!IdPersonaLogueada.Equals(string.Empty))
				{
					if(!IdServiciosSelecionados.Contains(idServ) && IdPersona != Security.IdPersona)
					{
						tareaRealizada.BackColorRojoForeColorVerde = Convert.ToInt32(1);
						row["BackColorRojoForeColorVerde"] = Convert.ToInt32(1);
						row["ForeColorVerde"] = Convert.ToInt32(0);
						row["BackColorRojo"] = Convert.ToInt32(0);

					}
					else if(!IdServiciosSelecionados.Contains(idServ) && IdPersona == Security.IdPersona)
					{
						tareaRealizada.BackColorRojo = Convert.ToInt32(1);
						row["BackColorRojoForeColorVerde"] = Convert.ToInt32(0);
						row["ForeColorVerde"] = Convert.ToInt32(0);
						row["BackColorRojo"] = Convert.ToInt32(1);

					}
					else if(IdServiciosSelecionados.Contains(idServ) && IdPersona != Security.IdPersona)
					{
						tareaRealizada.ForeColorVerde = Convert.ToInt32(1);
						row["BackColorRojoForeColorVerde"] = Convert.ToInt32(0);
						row["ForeColorVerde"] = Convert.ToInt32(1);
						row["BackColorRojo"] = Convert.ToInt32(0);

					} 
					else
					{
						row["BackColorRojoForeColorVerde"] = Convert.ToInt32(0);
						row["ForeColorVerde"] = Convert.ToInt32(0);
						row["BackColorRojo"] = Convert.ToInt32(0);
					}
				}
				else //Es supervisor
				{
					if(!IdServiciosSelecionados.Contains(idServ))
					{
						tareaRealizada.BackColorRojo = Convert.ToInt32(1);
						row["BackColorRojoForeColorVerde"] = Convert.ToInt32(0);
						row["ForeColorVerde"] = Convert.ToInt32(0);
						row["BackColorRojo"] = Convert.ToInt32(1);

					}
				}
				tareasRealizadas.Add(tareaRealizada);

			}
			_resultAsTable = table;
			ArrayList observaciones = new ArrayList();
			System.Data.DataSet dataObserv = mz.erp.businessrules.st_OrdenReparacion.GetComentarios( _idOrdenReparacion);
			DataTable tableObserv = dataObserv.Tables[0];

			foreach(DataRow rowO in tableObserv.Rows)
			{                                                         
				long IdComentarioOrdenReparacion = Convert.ToInt64(rowO["IdComentarioOrdenReparacion"]);
				long IdOrdenReparacion = Convert.ToInt64(rowO["IdOrdenReparacion"]);
				DateTime Fecha = Convert.ToDateTime(rowO["FechaCreacion"]);
				string Usuario = Convert.ToString(rowO["Usuario"]);				
				string Descripcion = Convert.ToString(rowO["Descripcion"]);			
				ComentarioOrdenReparacion observ = new ComentarioOrdenReparacion(IdComentarioOrdenReparacion, IdOrdenReparacion, Fecha, Usuario, Descripcion);
				observaciones.Add(observ);
			}

			if(table.Rows.Count > 0)
			{
				DateTime FechaUltimaModificacionTecnicoLogueado = DateTime.MinValue;
				long IdTecnico = st_EstadisticaOrdenReparacionModificacionTecnico.GetIdTecnicoByIdPersona(Security.IdPersona);
				if(!IdTecnico.Equals(long.MinValue))//Si es un Tecnico
				{
					st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow rowEORModifTecnico = st_EstadisticaOrdenReparacionModificacionTecnico.GetByPk(_idOrdenReparacion, IdTecnico);
					if(rowEORModifTecnico != null)// Existe la orden en st_EstadisticaOrdenReparacionModificacionTecnico
						FechaUltimaModificacionTecnicoLogueado = Convert.ToDateTime(rowEORModifTecnico.FechaUltimaModificacion);
				}
				_estadisticaOrdenReparacionSeleccionada = new EstadisticaOrdenReparacion(_idOrdenReparacion, Cerrado, NumeroRemito,  TiempoDeEspera, FechaCierre, tareasRealizadas, motivos, observaciones, FechaUltimaModificacionTecnicoLogueado);
			}
			else
				_estadisticaOrdenReparacionSeleccionada = null;

			_totalTecnico = Decimal.Round(_totalTecnico,2);

		}


		public void ModifyMotivo(int index)
		{
			if(_estadisticaOrdenReparacionSeleccionada != null)
			{
				EstadisticaOrdenReparacionMotivoOrdenReparacion mot = (EstadisticaOrdenReparacionMotivoOrdenReparacion)_estadisticaOrdenReparacionSeleccionada.Motivos[index];
				if(mot.Estado.Equals("EXISTE"))
					mot.Estado = "MODIF";
				else if(mot.Estado.Equals(string.Empty))
					mot.Estado = "NEW";

			}
		}


		public void ModifyMotivoHijo(int index, bool seleccionado)
		{
			if(_estadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado != null)
			{
				EstadisticaOrdenReparacionMotivoOrdenReparacion mot = (EstadisticaOrdenReparacionMotivoOrdenReparacion)this.MotivosHijos[index];
				if(mot.Estado.Equals("EXISTE") && !seleccionado)
					mot.Estado = "DEL";
				else if(mot.Estado.Equals(string.Empty) && seleccionado)
					mot.Estado = "NEW";
				else if(mot.Estado.Equals("DEL") && seleccionado)
					mot.Estado = "EXISTE";
				else if(mot.Estado.Equals("NEW") && !seleccionado)
					mot.Estado = string.Empty;
				mot.EsVerdadero = seleccionado;

			}
		}

		public void ModifyMotivoTarea(int index)
		{
			if(_tareaSeleccionada != null)
			{
				EstadisticaOrdenReparacionMotivoOrdenReparacion mot = (EstadisticaOrdenReparacionMotivoOrdenReparacion)_tareaSeleccionada.Motivos[index];
				if(mot.Estado.Equals("EXISTE"))
					mot.Estado = "MODIF";
				else if(mot.Estado.Equals(string.Empty))
					mot.Estado = "NEW";

			}
		}

		public void ModifyMotivoTareaHijo(int index, bool seleccionado)
		{
			if(_estadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado != null)
			{
				EstadisticaOrdenReparacionMotivoOrdenReparacion mot = (EstadisticaOrdenReparacionMotivoOrdenReparacion)this.MotivosTareaHijos[index];
				if(mot.Estado.Equals("EXISTE") && !seleccionado)
					mot.Estado = "DEL";
				else if(mot.Estado.Equals(string.Empty) && seleccionado)
					mot.Estado = "NEW";
				else if(mot.Estado.Equals("DEL") && seleccionado)
					mot.Estado = "EXISTE";
				else if(mot.Estado.Equals("NEW") && !seleccionado)
					mot.Estado = string.Empty;
				mot.EsVerdadero = seleccionado;

			}
		}

		public void SaveChanges()
		{
            _dataEstadisticaOrdenReparacion = new st_EstadisticaOrdenReparacionDataset();
		    _dataEstadisticaOrdenReparacionDet = new st_EstadisticaOrdenReparacionDetDataset();
		    _dataEstadisticaOrdenReparacionMotivoOrdenReparacion = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset();
		    _dataEstadisticaOrdenReparacionModificacionTecnico = new st_EstadisticaOrdenReparacionModificacionTecnicoDataset();
			_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset();
			this.Commit();
			dataaccess.st_EstadisticaOrdenReparacion.Update(_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion);
			dataaccess.st_EstadisticaOrdenReparacionDet.Update(_dataEstadisticaOrdenReparacionDet.st_EstadisticaOrdenReparacionDet);
			dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Update(_dataEstadisticaOrdenReparacionMotivoOrdenReparacion.st_EstadisticaOrdenReparacionMotivoOrdenReparacion);
			dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.Update(_dataEstadisticaOrdenReparacionModificacionTecnico.st_EstadisticaOrdenReparacionModificacionTecnico);
			dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Update(_dataEstadisticaOrdenReparacionMotivoOrdenReparacionDet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet);
			this.RefreshData();

		}


		#endregion

		#region Métodos Privados
		private void ValidarDatos()
		{
			_errores.Clear();
			if(_estadisticaOrdenReparacionSeleccionada != null && ValidaCompletarDatosOrdenSTD)
			{
				if(NumeroRemito.Equals(string.Empty))
                    _errores.Add( new ItemDatasetError( "Estadística Orden Reparación","Número de Remito","El campo Nro. de Remnito no puede estar vacío pues es una orden STD") );
				if(TiempoDeEspera.Equals(decimal.MinValue))
					_errores.Add( new ItemDatasetError( "Estadística Orden Reparación","Tiempo de Espera","El campo Tiempo de Espera no puede estar vacío pues es una orden STD") );
			}
		}

		private ArrayList GetServiciosOrdenReparacion(long IdOrdenReparacion)
		{
			ArrayList serviciosOR = new ArrayList();
			System.Data.DataSet dataServ = st_OrdenReparacion.GetFallas(IdOrdenReparacion);
			DataTable tableServ = dataServ.Tables[0];

			foreach(DataRow rowS in tableServ.Rows)
			{                                                         
				long IdFalla = Convert.ToInt64(rowS["IdFalla"]);
				serviciosOR.Add(IdFalla);
			}
			return serviciosOR;
		}

		#endregion

	}
	
	public class EstadisticaOrdenReparacion
	{
		public EstadisticaOrdenReparacion(long IdOrdenReparacion, bool Cerrado, string NumeroRemito, decimal TiempoDeEspera ,DateTime FechaCierre, ArrayList TareasRealizadas, ArrayList Motivos, ArrayList Observaciones, DateTime FechaUltimaModificacionTecnico)
		{
			_idOrdenReparacion = IdOrdenReparacion;
			_cerrado = Cerrado;
			_fechaCierre = FechaCierre;
			_numeroRemito = NumeroRemito;
			_tiempoDeEspera = TiempoDeEspera;
			_tareasRealizadas = TareasRealizadas;
			_motivos = Motivos;
			_observaciones = Observaciones;
			_fechaUltimaModificacionTecnico = FechaUltimaModificacionTecnico;
		}

		private long _idOrdenReparacion;
		public long IdOrdenReparacion 
		{
			get {return _idOrdenReparacion;}
		}

		private bool _cerrado;
		public bool Cerrado 
		{
			get {return _cerrado;}
		}

		private DateTime _fechaCierre;
		public DateTime FechaCierre 
		{
			get {return _fechaCierre;}
		}

		private string _numeroRemito;
		public string NumeroRemito 
		{
			get {return _numeroRemito;}
			set {_numeroRemito = value;}
		}

		private decimal _tiempoDeEspera;
		public decimal TiempoDeEspera 
		{
			get {return _tiempoDeEspera;}
			set {_tiempoDeEspera = value;}
		}

		private ArrayList _tareasRealizadas;
		public ArrayList TareasRealizadas 
		{
			get {return _tareasRealizadas;}
		}

		private ArrayList _motivos;
		public ArrayList Motivos 
		{
			get {return _motivos;}
		}

		private ArrayList _observaciones;
		public ArrayList Observaciones 
		{
			get {return _observaciones;}
		}

		private DateTime _fechaUltimaModificacionTecnico;
		public DateTime FechaUltimaModificacionTecnico 
		{
			get {return _fechaUltimaModificacionTecnico;}
			set {_fechaUltimaModificacionTecnico = value;}
		}

	}


	public class EstadisticaOrdenReparacionDet
	{
		public EstadisticaOrdenReparacionDet(long IdOrdenReparacion, long IdInstanciaOrdenReparacion, string Cliente, string Tarea, string Lugar, decimal TiempoTecnico, decimal TiempoTarea, long IdTarea, string Complejidad, decimal ValorTecnico, decimal ValorTecnicoProvisorio, decimal ValorCliente, decimal ValorTarea, string Tecnico, string Servicio, string EstadoOrdenReparacion, string IdPersona, ArrayList Motivos)
		{
			_idOrdenReparacion = IdOrdenReparacion;
			_idInstanciaOrdenReparacion = IdInstanciaOrdenReparacion;
			_cliente = Cliente;
			_tarea = Tarea;
			_lugar = Lugar;
			_tiempoTecnico = TiempoTecnico;
			_tiempoTarea = TiempoTarea;
			_idTarea = IdTarea;
			_complejidad = Complejidad;
			_valorTecnico = ValorTecnico;
			_valorTecnicoProvisorio = ValorTecnicoProvisorio;
			_valorCliente = ValorCliente;
			_valorTarea = ValorTarea;
			_tecnico = Tecnico;
			_servicio = Servicio;
			_estadoOrdenReparacion = EstadoOrdenReparacion;
			_idPersona = IdPersona;
			_motivos = Motivos;
			_backColorRojoForeColorVerde = 0;
			_foreColorVerde = 0;
			_backColorRojo = 0;
		}

		private long _idOrdenReparacion;
		public long IdOrdenReparacion 
		{
			get {return _idOrdenReparacion;}
		}

		private long _idInstanciaOrdenReparacion;
		public long IdInstanciaOrdenReparacion 
		{
			get {return _idInstanciaOrdenReparacion;}
		}

		private string _cliente;
		public string Cliente 
		{
			get {return _cliente;}
		}

		private string _tarea;
		public string Tarea 
		{
			get {return _tarea;}
		}

		private string _lugar;
		public string Lugar 
		{
			get {return _lugar;}
		}

		private decimal _tiempoTecnico;
		public decimal TiempoTecnico 
		{
			get {return _tiempoTecnico;}
		}

		private decimal _tiempoTarea;
		public decimal TiempoTarea 
		{
			get {return _tiempoTarea;}
		}

		private long _idTarea;
		public long IdTarea 
		{
			get {return _idTarea;}
		}

		private string _complejidad;
		public string Complejidad 
		{
			get {return _complejidad;}
		}

		private decimal _valorTecnico;
		public decimal ValorTecnico 
		{
			get {return _valorTecnico;}
		}

		private decimal _valorTecnicoProvisorio;
		public decimal ValorTecnicoProvisorio 
		{
			get {return _valorTecnicoProvisorio;}
		}

		private decimal _valorCliente;
		public decimal ValorCliente 
		{
			get {return _valorCliente;}
		}

		// Equivale a subtotal de la tabla
		private decimal _valorTarea;
		public decimal ValorTarea 
		{
			get {return _valorTarea;}
		}

		private string _tecnico;
		public string Tecnico 
		{
			get {return _tecnico;}
		}

		private string _servicio;
		public string Servicio 
		{
			get {return _servicio;}
		}

		private string _estadoOrdenReparacion;
		public string EstadoOrdenReparacion 
		{
			get {return _estadoOrdenReparacion;}
		}

		private string _idPersona;
		public string IdPersona 
		{
			get {return _idPersona;}
		}

		private ArrayList _motivos;
		public ArrayList Motivos 
		{
			get {return _motivos;}
		}
		
		private int _backColorRojoForeColorVerde;
		public int BackColorRojoForeColorVerde 
		{
			get {return _backColorRojoForeColorVerde;}
			set {_backColorRojoForeColorVerde = value;}
		}

		private int _foreColorVerde;
		public int ForeColorVerde 
		{
			get {return _foreColorVerde;}
			set {_foreColorVerde = value;}
		}
	
		private int _backColorRojo;
		public int BackColorRojo 
		{
			get {return _backColorRojo;}
			set {_backColorRojo = value;}
		}

		public override Boolean Equals ( Object obj )
		{
			return this.IdOrdenReparacion.Equals(((EstadisticaOrdenReparacionDet)obj).IdOrdenReparacion) && this.IdInstanciaOrdenReparacion.Equals(((EstadisticaOrdenReparacionDet)obj).IdInstanciaOrdenReparacion) && this.IdTarea.Equals(((EstadisticaOrdenReparacionDet)obj).IdTarea);
		}

	}


	public class EstadisticaOrdenReparacionMotivoOrdenReparacion
	{
		public EstadisticaOrdenReparacionMotivoOrdenReparacion(long IdMotivo, long IdMotivoPadre, bool EsMotivoVerdadero, string Descripcion, bool EsVerdadero, bool EsFalso, ArrayList MotivosHijos, string Estado)
		{
			_idMotivo = IdMotivo;
			_idMotivoPadre = IdMotivoPadre;
			_esVerdadero = EsVerdadero;
			_esFalso = EsFalso;
			_descripcion = Descripcion;
			_esMotivoVerdadero = EsMotivoVerdadero;
			_motivosHijos = MotivosHijos;
			_estado = Estado;
		}

		private long _idMotivo;
		public long IdMotivo 
		{
			get {return _idMotivo;}
		}

		private long _idMotivoPadre;
		public long IdMotivoPadre 
		{
			get {return _idMotivoPadre;}
		}

		private bool _esVerdadero;
		public bool EsVerdadero 
		{
			get {return _esVerdadero;}
			set 
			{
				_esVerdadero = value;
				_esFalso = !value;
			}
		}

		private bool _esFalso;
		public bool EsFalso 
		{
			get {return _esFalso;}
			set 
			{
				_esFalso = value;
				_esVerdadero = !value;
			}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
		}
		private bool _esMotivoVerdadero;
		public bool EsMotivoVerdadero 
		{
			get {return _esMotivoVerdadero;}
		}

		private ArrayList _motivosHijos;
		public ArrayList MotivosHijos 
		{
			get {return _motivosHijos;}
		}

		/*
		 *  Los estados posibles son: 
		 * - "": Indica que existe en la tabla tsy_MotivoOrdenReparacion pero no en 
		 *       st_EstadisticaOrdenReparacionMotivoOrdenReparacion para esta orden.
		 * - EXISTE: Indica que existe en la tabla 
		 *           st_EstadisticaOrdenReparacionMotivoOrdenReparacion para esta orden.
		 * - NEW: Indica que se debe agregar en la tabla 
		 *        st_EstadisticaOrdenReparacionMotivoOrdenReparacion para esta orden.
		 * - MODIF: Indica que se debe modificar en la tabla 
		 *        st_EstadisticaOrdenReparacionMotivoOrdenReparacion para esta orden.
		 * - DEL: Indica que se debe eliminar de la tabla 
		 *        st_EstadisticaOrdenReparacionMotivoOrdenReparacion para esta orden.
		 * 
		 * */
		private string _estado;
		public string Estado 
		{
			get {return _estado;}
			set {_estado = value;}
		}

		public override System.String ToString()
		{
			return _descripcion;
		}


	}


	public class ComentarioOrdenReparacion
	{
		public ComentarioOrdenReparacion(long IdComentarioOrdenReparacion, long IdOrdenReparacion, DateTime FechaCreacion, string Usuario, string Descripcion)
		{
			_idComentarioOrdenReparacion = IdComentarioOrdenReparacion;
			_idOrdenReparacion = IdOrdenReparacion;
			_fechaCreacion = FechaCreacion;
			_usuario = Usuario;
			_descripcion = Descripcion;
		}

		private long _idComentarioOrdenReparacion;
		public long IdComentarioOrdenReparacion 
		{
			get {return _idComentarioOrdenReparacion;}
		}

		private long _idOrdenReparacion;
		public long IdOrdenReparacion 
		{
			get {return _idOrdenReparacion;}
		}

		private DateTime _fechaCreacion;
		public DateTime FechaCreacion 
		{
			get {return _fechaCreacion;}
		}

		private DateTime _fechaCierre;
		public DateTime FechaCierre 
		{
			get {return _fechaCierre;}
		}

		private string _usuario;
		public string Usuario 
		{
			get {return _usuario;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
		}
	}



}
