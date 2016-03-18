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
	/// Descripción breve de AbmTarea.
	/// </summary>
	public class AbmTarea: ITask, IPersistentTask
	{
		#region Constructores

		public AbmTarea()
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
			_listaComplejidades = Variables.GetValueString(_processParent.Process.ProcessName, _taskName, "Complejidad");			
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
			data.Add(_dataTareas);
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
		private st_TareaDataset _dataTareas = new st_TareaDataset();
		//Sabrina 20100623 - Tarea 786
		private st_ListaDePreciosTareaDataset _dataListaDePreciosTarea = new st_ListaDePreciosTareaDataset();
		//Fin Sabrina 20100623 - Tarea 786
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TareaSeleccionadaHasChanged;
		public event System.EventHandler TareasHasChanged;
		#endregion

		#region Métodos públicos
		public DataTable TareasEnBD() 
		{
			_tareas = new Hashtable();
			st_TareaDataset.st_TareaDataTable tareasEnBD = st_Tarea.GetList().st_Tarea;
			foreach(st_TareaDataset.st_TareaRow rowTarea in tareasEnBD.Rows)
			{
				long IdTarea = rowTarea.IdTarea;
				string Codigo = rowTarea.Codigo;
				string Descripcion = rowTarea.Descripcion;
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
				Tarea tarea = new Tarea(IdTarea, Codigo, Descripcion, IdProducto, Complejidad, Duracion, ValorTecnico, ValorCliente, ValorTecnicoProvisorio, string.Empty);
				_tareas.Add(IdTarea, tarea);
			}
			return tareasEnBD;
		}


		public void AddTarea()
		{
			long IdTarea = systemframework.Util.NewLongId();
			Tarea tarea = new Tarea(IdTarea, string.Empty, string.Empty, string.Empty, string.Empty, 0, 0, 0, 0, "NEW");
			_tareas.Add(IdTarea, tarea);
			TareaSeleccionada = tarea;
		}

		public void ModificarTarea()
		{
			if(_tareaSeleccionada != null )
				_tareaSeleccionada.Estado = "MODIF";
		}

		public bool ExisteNombreTarea()
		{
			bool existeNombre = false;
			if(_tareaSeleccionada != null)
			{
				int i = 0;
				ArrayList tareas = new ArrayList();
				tareas.AddRange(_tareas.Values);
				while(!existeNombre && i < tareas.Count)
				{
					Tarea tarea = (Tarea)tareas[i];
					existeNombre = !tarea.IdTarea.Equals(_tareaSeleccionada.IdTarea) && tarea.Descripcion.Equals(_tareaSeleccionada.Descripcion);
					i++;
				}

			}
			return existeNombre;
		}

		public void SaveChanges()
		{
			_dataTareas = new st_TareaDataset();
			if(_tareaSeleccionada != null)
			{
				//Sabrina 20100623 - Tarea 786
				bool existeListaDePreciosTarea = true;
				//Fin Sabrina 20100623 - Tarea 786
				st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow rowLPT = null;
				if (_tareaSeleccionada.Estado == "NEW")
				{
					st_TareaDataset.st_TareaRow rowT = _dataTareas.st_Tarea.Newst_TareaRow();
					rowT.IdTarea = _tareaSeleccionada.IdTarea;
					rowT.Codigo = _tareaSeleccionada.Codigo;
					rowT.Descripcion = _tareaSeleccionada.Descripcion;
					rowT.IdProducto = _tareaSeleccionada.IdProducto;
					rowT.Complejidad = _tareaSeleccionada.Complejidad;
					rowT.Duracion = _tareaSeleccionada.Duracion;
					rowT.ValorTecnico = _tareaSeleccionada.ValorTecnico;
					//Sabrina 20100623 - Tarea 786
					//rowT.ValorCliente = _tareaSeleccionada.ValorCliente;
					//Fin Sabrina 20100623 - Tarea 786
					rowT.ValorTecnicoProvisorio = _tareaSeleccionada.ValorTecnicoProvisorio;
					rowT.FechaCreacion = DateTime.Now;
					rowT.IdConexionCreacion = Security.IdConexion;
					_dataTareas.st_Tarea.Addst_TareaRow(rowT);

					//Sabrina 20100623 - Tarea 786
					//Guardo en st_ListaDePreciosTarea
					rowLPT = _dataListaDePreciosTarea.st_ListaDePreciosTarea.Newst_ListaDePreciosTareaRow();
					rowLPT.IdListaDePreciosTarea = systemframework.Util.NewLongId();
					rowLPT.IdTarea = _tareaSeleccionada.IdTarea;
					rowLPT.FechaInicio = DateTime.Now;
					rowLPT.FechaFin = DateTime.Now;
					rowLPT.Precio = _tareaSeleccionada.ValorCliente;
					rowLPT.FechaCreacion = DateTime.Now;
					rowLPT.IdConexionCreacion = Security.IdConexion;
					_dataListaDePreciosTarea.st_ListaDePreciosTarea.Addst_ListaDePreciosTareaRow(rowLPT);
					existeListaDePreciosTarea = false;
					//Fin Sabrina 20100623 - Tarea 786

			
				}				
				else if (_tareaSeleccionada.Estado == "MODIF")
				{
					
					st_TareaDataset.st_TareaRow rowT = st_Tarea.GetByPk(_tareaSeleccionada.IdTarea);
					rowT.Codigo = _tareaSeleccionada.Codigo;
					rowT.Descripcion = _tareaSeleccionada.Descripcion;
					rowT.IdProducto = _tareaSeleccionada.IdProducto;
					rowT.Complejidad = _tareaSeleccionada.Complejidad;
					rowT.Duracion = _tareaSeleccionada.Duracion;
					rowT.ValorTecnico = _tareaSeleccionada.ValorTecnico;
					//Sabrina 20100623 - Tarea 786
					//rowT.ValorCliente = _tareaSeleccionada.ValorCliente;
					//Fin Sabrina 20100623 - Tarea 786
					rowT.ValorTecnicoProvisorio = _tareaSeleccionada.ValorTecnicoProvisorio;
					_dataTareas.st_Tarea.ImportRow(rowT);
				
					//Sabrina 20100623 - Tarea 786
					//Guardo en st_ListaDePreciosTarea
					rowLPT = st_ListaDePreciosTarea.GetByIdTarea(_tareaSeleccionada.IdTarea);
					if(rowLPT == null)
					{
						rowLPT = _dataListaDePreciosTarea.st_ListaDePreciosTarea.Newst_ListaDePreciosTareaRow();
						rowLPT.IdListaDePreciosTarea = systemframework.Util.NewLongId();
						rowLPT.IdTarea = _tareaSeleccionada.IdTarea;
						rowLPT.FechaInicio = DateTime.Now;
						rowLPT.FechaFin = DateTime.Now;
						rowLPT.Precio = _tareaSeleccionada.ValorCliente;
						rowLPT.FechaCreacion = DateTime.Now;
						rowLPT.IdConexionCreacion = Security.IdConexion;
						_dataListaDePreciosTarea.st_ListaDePreciosTarea.Addst_ListaDePreciosTareaRow(rowLPT);
						existeListaDePreciosTarea = false;
					}
					else
					{
                        //German 20100804 - tarea 807
                        if (_dataListaDePreciosTarea.st_ListaDePreciosTarea.FindByIdListaDePreciosTarea(rowLPT.IdListaDePreciosTarea)
                            != null)
                        {
                            rowLPT = _dataListaDePreciosTarea.st_ListaDePreciosTarea.FindByIdListaDePreciosTarea(rowLPT.IdListaDePreciosTarea);
                            rowLPT.Precio = _tareaSeleccionada.ValorCliente;

                        }
                        else
                        {
                            rowLPT.Precio = _tareaSeleccionada.ValorCliente;
                            _dataListaDePreciosTarea.st_ListaDePreciosTarea.ImportRow(rowLPT);
                        }
                        //Fin German 20100804 - tarea 807
					}
					//Fin Sabrina 20100623 - Tarea 786
				}
				dataaccess.st_Tarea.Update(_dataTareas.st_Tarea);
				//Sabrina 20100623 - Tarea 786
				if(_dataTareas.st_Tarea.Rows.Count > 0)
				{
					_tareaSeleccionada.IdTarea  = ((st_TareaDataset.st_TareaRow)_dataTareas.st_Tarea.Rows[0]).IdTarea;
					if (!existeListaDePreciosTarea)
						rowLPT.IdTarea = _tareaSeleccionada.IdTarea;
					dataaccess.st_ListaDePreciosTarea.Update(_dataListaDePreciosTarea.st_ListaDePreciosTarea);
				}
				//Fin Sabrina 20100623 - Tarea 786
				if(TareasHasChanged != null)
					TareasHasChanged(this, new EventArgs());	
				TareaSeleccionada = (Tarea)_tareas[_tareaSeleccionada.IdTarea];
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
		private Hashtable _tareas = new Hashtable();
		public Hashtable Tareas
		{
			get{return _tareas;}
			set{_tareas = value;}
		}

		private Tarea _tareaSeleccionada = null;
		public Tarea TareaSeleccionada
		{
			get{return _tareaSeleccionada;}
			set
			{
				_tareaSeleccionada = value;
				if(TareaSeleccionadaHasChanged != null)
					TareaSeleccionadaHasChanged(this, new EventArgs());	
			}
		}

		public long IdTareaSeleccionada
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.IdTarea;
				else
					return long.MinValue;
			}
			set
			{
				TareaSeleccionada = (Tarea)_tareas[value];
			}
		}

		public string Descripcion
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.Descripcion;
				else
					return string.Empty;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.Descripcion.Equals(value))
				{
					_tareaSeleccionada.Descripcion = value;
				}
			}
		}


		public string Codigo
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.Codigo;
				else
					return string.Empty;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.Codigo.Equals(value))
				{
					_tareaSeleccionada.Codigo = value;
				}
			}
		}
		
		public string IdProducto
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.IdProducto;
				else
					return string.Empty;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.IdProducto.Equals(value))
				{
					_tareaSeleccionada.IdProducto = value;
				}
			}
		}
		
		public string Complejidad
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.Complejidad;
				else
					return string.Empty;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.Complejidad.Equals(value))
				{
					_tareaSeleccionada.Complejidad = value;
				}
			}
		}
		
		public decimal Duracion
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.Duracion;
				else
					return decimal.MinValue;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.Duracion.Equals(value))
				{
					_tareaSeleccionada.Duracion = value;
				}
			}
		}
		

		public decimal ValorTecnico
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.ValorTecnico;
				else
					return 0;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.ValorTecnico.Equals(value))
				{
					_tareaSeleccionada.ValorTecnico = value;
				}
			}
		}
		
		public decimal ValorCliente
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.ValorCliente;
				else
					return 0;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.ValorCliente.Equals(value))
				{
					_tareaSeleccionada.ValorCliente = value;
				}
			}
		}
		
		public decimal ValorTecnicoProvisorio
		{
			get
			{
				if(_tareaSeleccionada != null)
					return _tareaSeleccionada.ValorTecnicoProvisorio;
				else
					return 0;
			}
			set
			{
				if(_tareaSeleccionada != null && !_tareaSeleccionada.ValorTecnicoProvisorio.Equals(value))
				{
					_tareaSeleccionada.ValorTecnicoProvisorio = value;
				}
			}
		}

		private string _listaComplejidades = string.Empty;
		public string ListaComplejidades 
		{
			get {return _listaComplejidades;}
		}
		
		#endregion	


		#region Métodos Privados
		//Valida datos antes de guardar la informacion
		private void ValidarDatos()
		{
			_errores.Clear();
		}

		#endregion

	}

	public class Tarea
	{
		#region Constructores

		public Tarea(long IdTarea, string Codigo, string Descripcion, string IdProducto, string Complejidad, decimal Duracion, decimal ValorTecnico, decimal ValorCliente, decimal ValorTecnicoProvisorio, string Estado)
		{		
			_idTarea = IdTarea;
			_codigo = Codigo;
			_descripcion = Descripcion;	
			_idProducto = IdProducto;
			_complejidad = Complejidad;
			_duracion = Duracion;
			_valorTecnico = ValorTecnico;
			_valorCliente = ValorCliente;
			_valorTecnicoProvisorio = ValorTecnicoProvisorio;
			_estado = Estado;
		}
		
		public Tarea(long IdTarea, string Codigo, string Descripcion, string IdProducto, string Complejidad, decimal Duracion, decimal ValorTecnico, decimal ValorCliente, decimal ValorTecnicoProvisorio, decimal PrecioTareaServicio, decimal Peso, string Estado)
		{		
			_idTarea = IdTarea;
			_codigo = Codigo;
			_descripcion = Descripcion;	
			_idProducto = IdProducto;
			_complejidad = Complejidad;
			_duracion = Duracion;
			_valorTecnico = ValorTecnico;
			_valorCliente = ValorCliente;
			_valorTecnicoProvisorio = ValorTecnicoProvisorio;
			_precioTareaServicio = PrecioTareaServicio;
			_peso = Peso;
			_estado = Estado;
		}
		#endregion

		#region Propiedades
		private long _idTarea;
		public long IdTarea 
		{
			get {return _idTarea;}
			set {_idTarea = value;}
		}

		private string _codigo;
		public string Codigo 
		{
			get {return _codigo;}
			set {_codigo = value;}
		}

		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
			set{_descripcion = value;}
		}

		private string _idProducto;
		public string IdProducto 
		{
			get {return _idProducto;}
			set{_idProducto = value;}
		}

		private string _complejidad;
		public string Complejidad 
		{
			get {return _complejidad;}
			set{_complejidad = value;}
		}

		private decimal _duracion;
		public decimal Duracion 
		{
			get {return _duracion;}
			set{_duracion = value;}
		}
		
		private decimal _valorTecnico;
		public decimal ValorTecnico 
		{
			get {return _valorTecnico;}
			set{_valorTecnico = value;}
		}

		private decimal _valorCliente;
		public decimal ValorCliente 
		{
			get {return _valorCliente;}
			set{_valorCliente = value;}
		}
		
		private decimal _valorTecnicoProvisorio;
		public decimal ValorTecnicoProvisorio 
		{
			get {return _valorTecnicoProvisorio;}
			set{_valorTecnicoProvisorio = value;}
		}
		
		private decimal _precioTareaServicio = 0;
		public decimal PrecioTareaServicio 
		{
			get {return _precioTareaServicio;}
			set{_precioTareaServicio = value;}
		}

		private decimal _peso = 0;
		public decimal Peso 
		{
			get {return _peso;}
			set{_peso = value;}
		}
		
		private string _estado;
		public string Estado 
		{
			get {return _estado;}
			set {_estado = value;}
		}

		#endregion

		public override String ToString()
		{
			string str = _descripcion;
			return str;
		}
 
		public override Boolean Equals ( Object obj )
		{
			return this.IdTarea.Equals(((Tarea)obj).IdTarea);
		}
	}


}
