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
	/// Descripción breve de AbmServicio.
	/// </summary>
	public class AbmServicio: ITask, IPersistentTask
	{
		#region Constructores

		public AbmServicio()
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
			st_TareaDataset.st_TareaDataTable tareas = st_Tarea.GetList().st_Tarea;
			foreach(st_TareaDataset.st_TareaRow rowTarea in tareas.Rows)
			{
				long IdTarea = rowTarea.IdTarea;
				string Codigo = rowTarea.Codigo;
				string DescripcionTarea = rowTarea.Descripcion;
				string IdProducto = string.Empty;
				if(rowTarea["IdProducto"] != System.DBNull.Value)
					IdProducto = rowTarea.IdProducto;
				string Complejidad = rowTarea.Complejidad;
				decimal Duracion = rowTarea.Duracion;
				decimal ValorTecnico = rowTarea.ValorTecnico;
				//Sabrina 20100623 - Tarea 786
				//decimal ValorCliente = rowTarea.ValorCliente;
				decimal ValorCliente = 0;
				st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow rowLPT = st_ListaDePreciosTarea.GetByIdTarea(IdTarea);
				if(rowLPT != null)
					ValorCliente = rowLPT.Precio;
				//Fin Sabrina 20100623 - Tarea 786
				decimal ValorTecnicoProvisorio = 0;
				if(rowTarea["ValorTecnicoProvisorio"] != System.DBNull.Value)
                    ValorTecnicoProvisorio = rowTarea.ValorTecnicoProvisorio;
				Tarea tarea = new Tarea(IdTarea, Codigo, DescripcionTarea, IdProducto, Complejidad, Duracion, ValorTecnico, ValorCliente, ValorTecnicoProvisorio, string.Empty);
				_tareasEnBD.Add(tarea);
			}
			_contenedoresVisibles = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ContenedoresVisibles");
			_contenedoresHabilitados = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ContenedoresHabilitados");
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
			data.Add(_dataFallas);
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
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private st_FallaDataset _dataFallas = new st_FallaDataset();
		private st_ServicioTareasDataset _dataServicioTareas = new st_ServicioTareasDataset();
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TareasHasChanged;
		public event System.EventHandler ServiciosHasChanged;
		public event System.EventHandler TareasServicioHasChanged;
		#endregion

		#region Métodos públicos

		public DataTable ServiciosEnBD() 
		{
			_servicios = new Hashtable();
			st_FallaDataset.st_FallaDataTable	serviciosEnBD = st_Falla.GetList().st_Falla;
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
				foreach(st_ServicioTareasDataset.st_ServicioTareasRow rowST in tableST.Rows)
				{
					long IdTarea = rowST.IdTarea;
					st_TareaDataset.st_TareaRow rowTarea = st_Tarea.GetByPk(IdTarea);
					string Codigo = rowTarea.Codigo;
					string DescripcionTarea = rowTarea.Descripcion;
					string IdProducto = rowTarea.IdProducto;
					string Complejidad = rowTarea.Complejidad;
					decimal Duracion = rowTarea.Duracion;
					decimal ValorTecnico = rowTarea.ValorTecnico;
					//Sabrina 20100623 - Tarea 786
					//decimal ValorCliente = rowTarea.ValorCliente;
					decimal ValorCliente = 0;
					st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow rowLPT = st_ListaDePreciosTarea.GetByIdTarea(IdTarea);
					if(rowLPT != null)
						ValorCliente = rowLPT.Precio;
					//Fin Sabrina 20100623 - Tarea 786

					decimal ValorTecnicoProvisorio = rowTarea.ValorTecnicoProvisorio;
					decimal PrecioTareaServicio = 0;
					if(rowST["PrecioTarea"] != System.DBNull.Value)
						PrecioTareaServicio = rowST.PrecioTarea;
					decimal Peso = 0;
					if(rowST["Peso"] != System.DBNull.Value)
						Peso = rowST.Peso;					
					Tarea tarea = new Tarea(IdTarea, Codigo, DescripcionTarea, IdProducto, Complejidad, Duracion, ValorTecnico, ValorCliente, ValorTecnicoProvisorio, PrecioTareaServicio, Peso, string.Empty);
					tareas.Add(tarea);
				}
				Servicio servicio = new Servicio(IdFalla, Descripcion, DuracionDias, Costo, CostoMaximo, CostoPresupuesto, tareas, string.Empty);
				_servicios.Add(IdFalla, servicio);
			}
			return serviciosEnBD;
		}


		public void AddServicio()
		{
			long IdServicio = systemframework.Util.NewLongId();
			Servicio serv = new Servicio(IdServicio, string.Empty, 0, 0, 0, 0, new ArrayList(), "NEW");
			_servicios.Add(IdServicio, serv);
			ServicioSeleccionado = serv;
		}

		public void ModificarServicio()
		{
			if(_servicioSeleccionado != null )
				_servicioSeleccionado.Estado = "MODIF";
		}

		public void ModificarServicioTarea(Tarea tarea, bool seleccionada)
		{
			if(_servicioSeleccionado != null )
			{
				int index = _servicioSeleccionado.Tareas.IndexOf(tarea);
				if(index == -1 && seleccionada) //Agrego la tarea al servicio
				{
					_servicioSeleccionado.Costo = _servicioSeleccionado.Costo + tarea.ValorCliente;
					decimal peso = 0;
					if(_servicioSeleccionado.Costo != 0)
                        peso = tarea.ValorCliente/_servicioSeleccionado.Costo;
					Tarea tareaServicio = new Tarea(tarea.IdTarea, tarea.Codigo, tarea.Descripcion, tarea.IdProducto, tarea.Complejidad, tarea.Duracion, tarea.ValorTecnico, tarea.ValorCliente, tarea.ValorTecnicoProvisorio, tarea.ValorCliente, peso, "ADDED");
					_servicioSeleccionado.Tareas.Add(tareaServicio);
					ActualizarPesoTareasServicio();
				}
				else if(index != -1)
				{
					Tarea tareaServicio = (Tarea)_servicioSeleccionado.Tareas[index];
					if(tareaServicio.Estado.Equals("ADDED") && !seleccionada)
					{
						_servicioSeleccionado.Tareas.Remove(tareaServicio);
						_servicioSeleccionado.Costo = _servicioSeleccionado.Costo - tareaServicio.PrecioTareaServicio;
					}
					else if((tareaServicio.Estado.Equals(string.Empty) || tareaServicio.Estado.Equals("MODIF")) && !seleccionada)
					{
						tareaServicio.Estado = "DELETED";
						_servicioSeleccionado.Costo = _servicioSeleccionado.Costo - tareaServicio.PrecioTareaServicio;
					}
					else if(tareaServicio.Estado.Equals("DELETED") && seleccionada)
					{
						tareaServicio.Estado = string.Empty;
						_servicioSeleccionado.Costo = _servicioSeleccionado.Costo + tareaServicio.PrecioTareaServicio;
					}
					ActualizarPesoTareasServicio();
				}
				if(TareasHasChanged != null)
					TareasHasChanged(this, new EventArgs());
			}
		}

		public bool ExisteNombreServicio()
		{
			bool existeNombre = false;
			if(_servicioSeleccionado != null)
			{
				int i = 0;
				ArrayList servicios = new ArrayList();
				servicios.AddRange(_servicios.Values);
				while(!existeNombre && i < servicios.Count)
				{
					Servicio servicio = (Servicio)servicios[i];
					existeNombre = !servicio.IdFalla.Equals(_servicioSeleccionado.IdFalla) && servicio.Descripcion.Equals(_servicioSeleccionado.Descripcion);
					i++;
				}

			}
			return existeNombre;
		}

        // German 20100826 - tarea 818    
        public bool ExisteAlMenosUnaTarea()
        {
            return _servicioSeleccionado.Tareas.Count > 0;
        }

        public bool TotalServicioIgualTotalTareas()
        {
            decimal PrecioServicio = _servicioSeleccionado.Costo;
            decimal TotalTareas = 0;
            foreach (Tarea t in _servicioSeleccionado.Tareas)
            {
                TotalTareas = TotalTareas + t.PrecioTareaServicio;
            }
            return Math.Abs((Math.Round(PrecioServicio, 2)- (Math.Round(TotalTareas, 2)))) <=  Convert.ToDecimal(0.05) ;
        }
        

        //Fin German 20100826 - tarea 818   

		public void SaveChanges()
		{
            _dataFallas = new st_FallaDataset();
		    _dataServicioTareas = new st_ServicioTareasDataset();
			if(_servicioSeleccionado != null)
			{
				if (_servicioSeleccionado.Estado == "NEW")
				{
					st_FallaDataset.st_FallaRow rowF = _dataFallas.st_Falla.Newst_FallaRow();
					rowF.IdFalla = _servicioSeleccionado.IdFalla;
					rowF.Descripcion = _servicioSeleccionado.Descripcion;
					rowF.DuracionDias = _servicioSeleccionado.DuracionDias;
					rowF.Costo = _servicioSeleccionado.Costo;
					rowF.CostoMaximo = _servicioSeleccionado.CostoMaximo;
					rowF.CostoPresupuesto = _servicioSeleccionado.CostoPresupuesto;
					rowF.FechaCreacion = DateTime.Now;
					rowF.IdConexionCreacion = Security.IdConexion;
					_dataFallas.st_Falla.Addst_FallaRow(rowF);
			
				}				
				else if (_servicioSeleccionado.Estado == "MODIF")
				{
					
					st_FallaDataset.st_FallaRow rowF = st_Falla.GetByPk(_servicioSeleccionado.IdFalla);
					rowF.Descripcion = _servicioSeleccionado.Descripcion;
					rowF.DuracionDias = _servicioSeleccionado.DuracionDias;
					rowF.Costo = _servicioSeleccionado.Costo;
					rowF.CostoMaximo = _servicioSeleccionado.CostoMaximo;
					rowF.CostoPresupuesto = _servicioSeleccionado.CostoPresupuesto;
					_dataFallas.st_Falla.ImportRow(rowF);

                    //German 20100826 - tarea 817   
                    
                    st_TipoEquipoFallaDataset dataTipoEquipoFalla = mz.erp.dataaccess.st_TipoEquipoFalla.GetByIdFalla(_servicioSeleccionado.IdFalla);
                    foreach (st_TipoEquipoFallaDataset.st_TipoEquipoFallaRow rowTEF in dataTipoEquipoFalla._st_TipoEquipoFalla.Rows)
                    {
                        rowTEF.ImporteMinimo = _servicioSeleccionado.Costo;
                        rowTEF.ImportePresupuesto = _servicioSeleccionado.Costo;
                    }
                    dataaccess.st_TipoEquipoFalla.Update(dataTipoEquipoFalla);

                    //Fin German 20100826 - tarea 817   
				}
                dataaccess.st_Falla.Update(_dataFallas.st_Falla);
				if(_dataFallas.st_Falla.Rows.Count > 0)
                    _servicioSeleccionado.IdFalla  = ((st_FallaDataset.st_FallaRow)_dataFallas.st_Falla.Rows[0]).IdFalla;
				foreach(Tarea tareaS in _servicioSeleccionado.Tareas)
				{
					if(tareaS.Estado.Equals("ADDED"))
					{
						st_ServicioTareasDataset.st_ServicioTareasRow rowST = _dataServicioTareas.st_ServicioTareas.Newst_ServicioTareasRow();
						rowST.IdServicio = _servicioSeleccionado.IdFalla;
						rowST.IdTarea = tareaS.IdTarea;
						rowST.PrecioTarea = tareaS.PrecioTareaServicio;
						rowST.Peso = tareaS.Peso;
						rowST.FechaCreacion = DateTime.Now;
						rowST.IdConexionCreacion = Security.IdConexion;
						_dataServicioTareas.st_ServicioTareas.Addst_ServicioTareasRow(rowST);

					}
					else if(tareaS.Estado.Equals("DELETED"))
					{
						st_ServicioTareasDataset.st_ServicioTareasRow rowST = st_ServicioTareas.GetByPk(_servicioSeleccionado.IdFalla, tareaS.IdTarea);
						rowST.Delete();
						_dataServicioTareas.st_ServicioTareas.ImportRow(rowST);

					}
					else if(tareaS.Estado.Equals("MODIF"))
					{
						st_ServicioTareasDataset.st_ServicioTareasRow rowST = st_ServicioTareas.GetByPk(_servicioSeleccionado.IdFalla, tareaS.IdTarea);
						rowST.PrecioTarea = tareaS.PrecioTareaServicio;
						rowST.Peso = tareaS.Peso;
						_dataServicioTareas.st_ServicioTareas.ImportRow(rowST);

					}
				}				
				dataaccess.st_ServicioTareas.Update(_dataServicioTareas.st_ServicioTareas);
				if(ServiciosHasChanged != null)
					ServiciosHasChanged(this, new EventArgs());	
				ServicioSeleccionado = (Servicio)_servicios[_servicioSeleccionado.IdFalla];
			}
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

		private string _contenedoresVisibles = string.Empty;
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}

		private string _contenedoresHabilitados = string.Empty;		
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}
		
		private Hashtable _servicios = new Hashtable();
		public Hashtable Servicios
		{
			get{return _servicios;}
			set{_servicios = value;}
		}


		private Servicio _servicioSeleccionado = null;
		public Servicio ServicioSeleccionado
		{
			get{return _servicioSeleccionado;}
			set
			{
				_servicioSeleccionado = value;
				if(TareasHasChanged != null)
					TareasHasChanged(this, new EventArgs());	
			}
		}

		public long IdServicioSeleccionado
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.IdFalla;
				else
					return long.MinValue;
			}
			set
			{
				ServicioSeleccionado = (Servicio)_servicios[value];
			}
		}

		private ArrayList _tareasEnBD = new ArrayList();
		public ArrayList TareasEnBD
		{
			get {return _tareasEnBD;}
		}

		public string NombreServicio
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.Descripcion;
				else
					return string.Empty;
			}
			set
			{
				if(_servicioSeleccionado != null && !_servicioSeleccionado.Descripcion.Equals(value))
				{
					_servicioSeleccionado.Descripcion = value;
				}
			}
		}

		public int DuracionDiasServicio
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.DuracionDias;
				else
					return 0;
			}
			set
			{
				if(_servicioSeleccionado != null && !_servicioSeleccionado.DuracionDias.Equals(value))
				{
					_servicioSeleccionado.DuracionDias = value;
				}
			}
		}

		public decimal CostoServicio
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.Costo;
				else
					return 0;
			}
			set
			{
				if(_servicioSeleccionado != null && !_servicioSeleccionado.Costo.Equals(value))
				{
					_servicioSeleccionado.Costo = value;
					ActualizarPrecioTareasServicio();
				}
			}
		}

		public decimal CostoMaximoServicio
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.CostoMaximo;
				else
					return 0;
			}
			set
			{
				if(_servicioSeleccionado != null && !_servicioSeleccionado.CostoMaximo.Equals(value))
				{
					_servicioSeleccionado.CostoMaximo = value;
				}
			}
		}
		
		public decimal CostoPresupuestoServicio
		{
			get
			{
				if(_servicioSeleccionado != null)
					return _servicioSeleccionado.CostoPresupuesto;
				else
					return 0;
			}
			set
			{
				if(_servicioSeleccionado != null && !_servicioSeleccionado.CostoPresupuesto.Equals(value))
				{
					_servicioSeleccionado.CostoPresupuesto = value;
				}
			}
		}
		
		public ArrayList TareasServicioSeleccionado
		{
			get 
			{
				if(_servicioSeleccionado != null)
				{
					ArrayList tareas = new ArrayList();
					foreach(Tarea tarea in _servicioSeleccionado.Tareas)
					{
						if(!tarea.Estado.Equals("DELETED"))
							tareas.Add(tarea);
					}
					return tareas;

				}
				else
					return new ArrayList();

			}
		}

		#endregion	

		#region Métodos Privados
		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_errores.Clear();
		}

		private void ActualizarPrecioTareasServicio()
		{
			foreach(Tarea tareaS in TareasServicioSeleccionado)
			{
                //German 20100827 - Tarea 820
				tareaS.PrecioTareaServicio = Math.Round(_servicioSeleccionado.Costo * tareaS.Peso,2);
                //Fin German 20100827 - Tarea 820
				if(!tareaS.Estado.Equals("ADDED"))
					tareaS.Estado = "MODIF";
			}
				if(TareasServicioHasChanged != null)
					TareasServicioHasChanged(this, new EventArgs());
		}

		private void ActualizarPesoTareasServicio()
		{
			foreach(Tarea tareaS in TareasServicioSeleccionado)
			{
				decimal peso = 0;
				if(_servicioSeleccionado.Costo != 0)
					peso = tareaS.PrecioTareaServicio/_servicioSeleccionado.Costo;
                //German 20100827 - Tarea 820
                tareaS.Peso = Math.Round(peso,2);
                //Fin German 20100827 - Tarea 820
				if(!tareaS.Estado.Equals("ADDED"))
					tareaS.Estado = "MODIF";
			}
			if(TareasServicioHasChanged != null)
				TareasServicioHasChanged(this, new EventArgs());
		}

		#endregion

	}

	public class Servicio //Se corresponde con la tabla st_Falla
	{
		#region Constructores
		public Servicio(long IdFalla, string Descripcion, int DuracionDias, decimal Costo, decimal CostoMaximo, decimal CostoPresupuesto, ArrayList Tareas, string Estado)
		{		
			_idFalla = IdFalla;
			_descripcion = Descripcion;
			_duracionDias = DuracionDias;
			_costo = Costo;
			_costoMaximo = CostoMaximo;
			_costoPresupuesto = CostoPresupuesto;
			_tareas = Tareas;
			_estado = Estado;
		}
		#endregion

		#region Propiedades
		private long _idFalla;
		public long IdFalla 
		{
			get {return _idFalla;}
			set {_idFalla = value;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}

		private int _duracionDias = 0;
		public int DuracionDias 
		{
			get {return _duracionDias;}
			set{_duracionDias = value;}
		}

		private decimal _costo = 0;
		public decimal Costo 
		{
			get {return _costo;}
			set{_costo = value;}
		}

		private decimal _costoMaximo = 0;
		public decimal CostoMaximo 
		{
			get {return _costoMaximo;}
			set{_costoMaximo = value;}
		}
		
		private decimal _costoPresupuesto = 0;
		public decimal CostoPresupuesto 
		{
			get {return _costoPresupuesto;}
			set{_costoPresupuesto = value;}
		}
		
		private ArrayList _tareas;
		public ArrayList Tareas 
		{
			get {return _tareas;}
		}

		private string _estado;
		public string Estado 
		{
			get {return _estado;}
			set {_estado = value;}
		}

		#endregion

		#region Metodos Publicos
		public void AddTarea(Tarea tarea)
		{
			_tareas.Add(tarea);
		}
		#endregion

		public override String ToString()
		{
			string str = _descripcion;
			return str;
		}


	}


}
