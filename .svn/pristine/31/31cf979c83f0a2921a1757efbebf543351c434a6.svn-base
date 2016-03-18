using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using System.IO; //Matias 20101021 - Tarea 898


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConfigurarLayoutGrillas.
	/// </summary>
	public class ConfigurarLayoutGrillas: ITask, IPersistentTask
	{
		public ConfigurarLayoutGrillas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas	
			
		private DataTable _spTable;			
		private PropertiesColumn _selectedItem;			
		private string _gridName = string.Empty;
		private DataTable _procesos;
		private DataTable _tareas;			
		private DataTable _perfiles;			
			

		private string _state = string.Empty;
			
		#endregion

		public event System.EventHandler ColumnsHasChanged;
		public event System.EventHandler SelectedItemChanged;
		public event System.EventHandler ProcesoHasChanged;
		public event System.EventHandler TareaHasChanged;
	
		#region Propiedades

		private string _idProceso= string.Empty;
		public string IdProceso
		{
			get{return _idProceso;}
			set
			{
				if(_idProceso != value)
				{
					_idProceso = value;
					GetTareas();
					if(ProcesoHasChanged != null)
						ProcesoHasChanged(this,new EventArgs());
					if(TareaHasChanged != null)
						TareaHasChanged(this, new EventArgs());				
				}
			}
		}
		private string _idTarea = string.Empty;
		public string IdTarea
		{
			get{return _idTarea;}
			set
			{
				if(_idTarea != value)
				{
					_idTarea = value;
					if(TareaHasChanged != null)
						TareaHasChanged(this, new EventArgs());					
				}
			}
		}

		private long _idPerfil = -1;
		public long IdPerfil 
		{
			get 
			{
				return _idPerfil;
			}
			set 
			{
				_idPerfil = value;
			}
		}
		public System.Data.DataTable Procesos
		{
			get {return _procesos;}
		}

		public System.Data.DataTable Tareas
		{
			get {return _tareas;}
		}
		public System.Data.DataTable Perfiles
		{
			get {return _perfiles;}
		}
		

		public object SelectedItem
		{
			set
			{
				string selectedCol = Convert.ToString(value);
				object aux = this.GetColumnProperties(selectedCol);
				if(aux != null)
				{
					_selectedItem = (PropertiesColumn)aux;
					if(SelectedItemChanged != null)
						SelectedItemChanged(this, new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());

				}
			}
			get{return _selectedItem;}
		}

		public DataTable SPTable
		{
			get{return _spTable;}
		}
		private ArrayList _columns = new ArrayList();
		public ArrayList Columns 
		{
			get 
			{
				return _columns;
			}			
		}
		private int _setIndex = 0;
		public int SetIndex 
		{
			get 
			{
				return _setIndex;
			}
		}

		private bool _merge = false;
		public bool Merge
		{
			get{return _merge;}
			set{_merge = value;}
		}

		private PropertiesColumnsCollection _columnsProperties = new PropertiesColumnsCollection();
		public PropertiesColumnsCollection ColumnsProperties 
		{ 
			get 
			{
				return _columnsProperties;
			}
		}


		
		public string GridName 
		{
			get 
			{
				return _gridName;
			}			
			set 
			{
				_gridName = value;
			}
		}

		private bool _visibleDefault = true;
		public bool VisibleDefault 
		{
			get 
			{
				return _visibleDefault;
			}			
			set 
			{
				_visibleDefault = value;
			}
		}

		#endregion

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion

		#region Miembros de ITask

		
		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual void Init()
		{			
			_spTable = mz.erp.businessrules.Sistema.GetStoredProceduresList();
			_procesos = twf_Procesos.GetList2().Tables[0];
			_perfiles = sy_Perfiles.GetList().sy_Perfiles;
			DataRow row = _perfiles.NewRow();					
			row["IdPerfil"] = -1;
			row["Descripcion"] = "Ninguno";
			row["FechaCreacion"] = System.DateTime.Now;
			row["IdConexionCreacion"] = 1;
			_perfiles.Rows.Add(row);
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool IsValid()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool AllowShow() 
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

		public virtual string GetWarnings()
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

		public bool AllowPrevious()
		{
			return true;
		}

		public virtual void Previous()
		{
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Metodos Publicos


		public ArrayList SearchColumnsProperties()
		{
			this._state = "EDIT";
			Hashtable result = new Hashtable();
			DataSet data = new DataSet();
			
			if(!_idPerfil.Equals(-1))
			{
				data = mz.erp.businessrules.tui_ConfiguracionGrillasPerfiles.GetList( _idPerfil, Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, null, null, null);
				foreach(DataRow row in data.Tables[0].Rows)
				{
					string ColumnName = Convert.ToString(row["Campo"]);
					string Property = Convert.ToString(row["Propiedad"]);
					object Value = row["Valor"];
					if(!result.ContainsKey(ColumnName))
					{
						result.Add(ColumnName, new Hashtable());
						
					}
					Hashtable Properties = (Hashtable)result[ColumnName];
					if(!Properties.ContainsKey(Property))
						Properties.Add(Property, Value);

				}
			}
			data = mz.erp.businessrules.tui_ConfiguracionGrillas.GetList(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, null, null, null);
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string ColumnName = Convert.ToString(row["Campo"]);
				string Property = Convert.ToString(row["Propiedad"]);
				object Value = row["ValorDefault"];
				if(!result.ContainsKey(ColumnName))
				{
					result.Add(ColumnName, new Hashtable());
					
				}
				Hashtable Properties = (Hashtable)result[ColumnName];
				if(!Properties.ContainsKey(Property))
					Properties.Add(Property, Value);

			}
			if(_merge)
			{
				_columns.Clear();
				foreach(string columnName in result.Keys)
				{
					Hashtable properties = (Hashtable) result[columnName];
					PropertiesColumn c = _columnsProperties.Get(columnName);
					if(c != null)
					{
						c.ColumnName = columnName;
						c.ColumnCaption = Convert.ToString(properties["Titulo"]);				
						c.Order = Convert.ToInt32(properties["Orden"]);
						c.Alignment = Convert.ToString(properties["Alineacion"]);
						c.Format = Convert.ToString(properties["Formato"]);
						c.Type = Convert.ToString(properties["TipoColumna"]);
						c.EditType = Convert.ToString(properties["TipoEdicion"]);
						c.MaxLines = Convert.ToInt32(properties["CantidadMaximaLineas"]);
						c.Width = Convert.ToDecimal(properties["Ancho"]);
						c.WordWrap = Convert.ToBoolean(properties["Multilinea"]);
						c.Visible = Convert.ToBoolean(properties["Visible"]);
						//Agregue yo
						c.OrderGroup= Convert.ToInt32(properties["OrdenAgrupamiento"]);
						_columns.Add(columnName);
					}
				}
			}
			else
			{
				_columns.Clear();
				_columnsProperties.Clear();
				foreach(string columnName in result.Keys)
				{
					Hashtable properties = (Hashtable) result[columnName];
					PropertiesColumn c = new PropertiesColumn();
					if(c!= null)
					{
						c.ColumnName = columnName;
						c.ColumnCaption = Convert.ToString(properties["Titulo"]);				
						c.Order = Convert.ToInt32(properties["Orden"]);
						c.Alignment = Convert.ToString(properties["Alineacion"]);
						c.Format = Convert.ToString(properties["Formato"]);
						c.Type = Convert.ToString(properties["TipoColumna"]);
						c.EditType = Convert.ToString(properties["TipoEdicion"]);
						c.MaxLines = Convert.ToInt32(properties["CantidadMaximaLineas"]);
						c.Width = Convert.ToDecimal(properties["Ancho"]);
						c.WordWrap = Convert.ToBoolean(properties["Multilinea"]);
						c.Visible = Convert.ToBoolean(properties["Visible"]);
						//Agregue yo
						//German 20090903
						if(properties.ContainsKey("OrdenAgrupamiento"))
							c.OrderGroup= Convert.ToInt32(properties["OrdenAgrupamiento"]);
						else
							c.OrderGroup= -1;	
						//German 20090903
						_columns.Add(columnName);
						_columnsProperties.AddItem(c);
					}
				}

			}
			_columnsProperties.Sort();
			return _columns;
		}
		
		public ArrayList GetSPParameters(string SPName)
		{
			ArrayList result = new ArrayList();
			DataTable table =  mz.erp.businessrules.Sistema.GetStoredProcedureColumnsList(SPName);
			foreach(DataRow row in table.Rows)
			{
				string colName = Convert.ToString(row["column_name"]);
				if(!colName.ToUpper().Equals("@RETURN_VALUE"))
					result.Add(colName);
			}
			return result;
		}		
		public ArrayList GetSPColumns (string SQL) 
		{
			this._state = "NEW";
			ArrayList result = new ArrayList();
			DataTable table =  mz.erp.businessrules.Sistema.ExecuteSQLStatement(SQL);			
			_columnsProperties.Clear();
			//int orden = 0;
			foreach(DataColumn column in table.Columns)
			{
				result.Add(column.ColumnName);
				PropertiesColumn c = new PropertiesColumn();
				c.Visible = _visibleDefault;				
				c.ColumnName = column.ColumnName;
				c.ColumnCaption = column.ColumnName;				
				c.Order = _columnsProperties.Count;
				c.Alignment = "Izquierda";
				c.Format = "Default";
				c.Type = "CuadroDeTexto";
				c.EditType = "CuadroDeTexto";
				_columnsProperties.AddItem(c);

			}			
			_columns = result;
			return result;
		}		 
		public void Arriba (int index)
		{
			if (_columns != null)
			{
				if (index > 0)
				{
					object cambio = _columns[index];
					_setIndex = index - 1;
					_columns[index] = _columns[_setIndex];
					_columns[_setIndex] = cambio;										

					_columnsProperties.Enroque(index, _setIndex);
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				if(ColumnsHasChanged != null)
					ColumnsHasChanged(this, new EventArgs());			
			}
		}
		public void Abajo (int index)
		{			
			if (_columns != null)
			{
				if (index + 1 < _columns.Count)
				{
					object cambio = _columns[index];
					_setIndex = index + 1;
					_columns[index] = _columns[_setIndex];
					_columns[_setIndex] = cambio;

					_columnsProperties.Enroque(index, _setIndex);
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				if(ColumnsHasChanged != null)
					ColumnsHasChanged(this, new EventArgs());
			}
		}


		public PropertiesColumn GetColumnProperties(string colName)
		{
			return _columnsProperties.Get(colName);
		}

		public void GetTareas()
		{
			_tareas = twf_ProcesosTareas.GetList(_idProceso);
			//_idTarea = tsa_CuentasObservacionesTipos.GetListSubTiposPerfil(padre, "Add").tsa_CuentasObservacionesTipos;			
			if (_tareas.Rows.Count == 1)
			{
				_idTarea = Convert.ToString(_tareas.Rows[0]["IdTarea"]);
				if(TareaHasChanged != null)
					TareaHasChanged(this, new EventArgs());				
			}
			/*if (_subTipos.Rows.Count >= 1)
			{
				DataRow row = _subTipos.NewRow();					
				row["IdCuentaObservacionTipo"] = String.Empty;
				row["Descripcion"] = String.Empty;
				_subTipos.Rows.Add(row);
			}*/
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;


		private tui_ConfiguracionGrillasDataset _dataConfiguracionGrillas = new tui_ConfiguracionGrillasDataset();
		private tui_ConfiguracionGrillasPerfilesDataset _dataConfiguracionGrillasPerfiles = new tui_ConfiguracionGrillasPerfilesDataset();

		public TaskCollectionData GetData()
		{
			
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataConfiguracionGrillas);
			data.Add( (DataSet) this._dataConfiguracionGrillasPerfiles);
			return data;
		}

		public void Commit()
		{

			_dataConfiguracionGrillas = new tui_ConfiguracionGrillasDataset();
			/*
			#region NEW
			if(this._state.Equals("NEW"))
			{
				if(_idPerfil.Equals(-1))
				{

					foreach(PropertiesColumn pc in this._columnsProperties)
					{
						#region Titulo
						tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Titulo"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = pc.ColumnCaption;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Orden
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Orden"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = Convert.ToString(pc.Order);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Visible
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Visible"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = Convert.ToString(pc.Visible);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Ancho
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Ancho"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = Convert.ToString(pc.Width);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Alineacion
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Alineacion"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = pc.Alignment;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Formato
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Formato"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = pc.Format;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region TipoColumna
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "TipoColumna"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = pc.Type;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region TipoEdicion
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "TipoEdicion"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = pc.EditType;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region Multilinea
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Multilinea"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = Convert.ToString(pc.WordWrap);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
						#region CantidadMaximaLineas
						row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "CantidadMaximaLineas"; 
						row.Descripcion = string.Empty;
						row.ValorDefault = Convert.ToString(pc.MaxLines);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
						#endregion
					}

				}
				else
				{
					foreach(PropertiesColumn pc in this._columnsProperties)
					{
						#region Titulo
						tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Titulo"; 
						row.Valor = pc.ColumnCaption;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Orden
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Orden"; 
						row.Valor = Convert.ToString(pc.Order);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Visible
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Visible"; 
						row.Valor = Convert.ToString(pc.Visible);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Ancho
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Ancho"; 
						row.Valor = Convert.ToString(pc.Width);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Alineacion
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Alineacion"; 
						row.Valor = pc.Alignment;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Formato
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Formato"; 
						row.Valor = pc.Format;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region TipoColumna
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdPerfil = _idPerfil;
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "TipoColumna"; 
						row.Valor = pc.Type;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region TipoEdicion
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "TipoEdicion"; 
						row.Valor = pc.EditType;
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region Multilinea
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "Multilinea"; 
						row.Valor = Convert.ToString(pc.WordWrap);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
						#region CantidadMaximaLineas
						row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
						row.IdPerfil = _idPerfil;
						row.IdProceso = Convert.ToInt64(_idProceso); 
						row.IdTarea = Convert.ToInt64(_idTarea); 
						row.Grilla = _gridName; 
						row.Campo = pc.ColumnName; 
						row.Propiedad = "CantidadMaximaLineas"; 
						row.Valor = Convert.ToString(pc.MaxLines);
						row.Activo = true;
						row.Comentario = string.Empty;
						row.FechaCreacion = DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						//row.UltimaModificacion = null;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.RowId = Guid.Empty;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
						#endregion
					}
				}
			}
			#endregion
			*/
			#region EDIT
			//else
			//{
				//if(this._state.Equals("EDIT"))
				//{
					if(_idPerfil.Equals(Convert.ToInt64(-1)))
					{
						_dataConfiguracionGrillas = mz.erp.businessrules.tui_ConfiguracionGrillas.GetList(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, null, null, null);
						foreach(PropertiesColumn pc in this._columnsProperties)
						{
							#region Titulo
							tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Titulo");
							if(row != null)
								row.ValorDefault = pc.ColumnCaption;
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Titulo"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = pc.ColumnCaption;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Orden
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Orden");
							if(row != null)
								row.ValorDefault = Convert.ToString(pc.Order);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Orden"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.Order);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region OrdenAgrupamiento
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "OrdenAgrupamiento");
							if(row != null)
								row.ValorDefault = Convert.ToString(pc.OrderGroup);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "OrdenAgrupamiento"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.OrderGroup);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Visible
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Visible");
							if(row != null)
								row.ValorDefault = Convert.ToString(pc.Visible);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Visible"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.Visible);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Ancho
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Ancho");
							if(row != null)
								row.ValorDefault = Convert.ToString(pc.Width);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Ancho"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.Width);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Alineacion
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Alineacion");
							if(row != null)
								row.ValorDefault =pc.Alignment;
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Alineacion"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = pc.Alignment;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Formato
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Formato");
							if(row != null)
								row.ValorDefault =pc.Format;
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Formato"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = pc.Format;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region TipoColumna
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "TipoColumna");
							if(row != null)
								row.ValorDefault =pc.Type;
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "TipoColumna"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = pc.Type;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region TipoEdicion
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "TipoEdicion");
							if(row != null)
								row.ValorDefault =pc.EditType;
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "TipoEdicion"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = pc.EditType;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region Multilinea
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Multilinea");
							if(row != null)
								row.ValorDefault =Convert.ToString(pc.WordWrap);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Multilinea"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.WordWrap);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
							#region CantidadMaximaLineas
							row =  _dataConfiguracionGrillas.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "CantidadMaximaLineas");
							if(row != null)
								row.ValorDefault =Convert.ToString(pc.MaxLines);
							else
							{
								row = _dataConfiguracionGrillas.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "CantidadMaximaLineas"; 
								row.Descripcion = string.Empty;
								row.ValorDefault = Convert.ToString(pc.MaxLines);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillas.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
							}
							#endregion
						}
					}
					else
					{
						_dataConfiguracionGrillasPerfiles = mz.erp.businessrules.tui_ConfiguracionGrillasPerfiles.GetList(_idPerfil, Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, null, null, null);
						foreach(PropertiesColumn pc in this._columnsProperties)
						{
							#region Titulo
							tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Titulo");
							if(row != null)
								row.Valor = pc.ColumnCaption;
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Titulo"; 
								row.Valor = pc.ColumnCaption;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Orden
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Orden");
							if(row != null)
								row.Valor = Convert.ToString(pc.Order);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Orden"; 
								row.Valor = Convert.ToString(pc.Order);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region OrdenAgrupamiento
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "OrdenAgrupamiento");
							if(row != null)
								row.Valor = Convert.ToString(pc.OrderGroup);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Orden"; 
								row.Valor = Convert.ToString(pc.OrderGroup);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Visible
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Visible");
							if(row != null)
								row.Valor = Convert.ToString(pc.Visible);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Visible"; 
								row.Valor = Convert.ToString(pc.Visible);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Ancho
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Ancho");
							if(row != null)
								row.Valor = Convert.ToString(pc.Width);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Ancho"; 
								row.Valor = Convert.ToString(pc.Width);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Alineacion
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Alineacion");
							if(row != null)
								row.Valor = pc.Alignment;
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Alineacion"; 
								row.Valor = pc.Alignment;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Formato
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Formato");
							if(row != null)
								row.Valor = pc.Format;
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Formato"; 
								row.Valor = pc.Format;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region TipoColumna
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "TipoColumna");
							if(row != null)
								row.Valor = pc.Type;
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "TipoColumna"; 
								row.Valor = pc.Type;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region TipoEdicion
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "TipoEdicion");
							if(row != null)
								row.Valor = pc.EditType;
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "TipoEdicion"; 
								row.Valor = pc.EditType;
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region Multilinea
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "Multilinea");
							if(row != null)
								row.Valor = Convert.ToString(pc.WordWrap);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea);
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "Multilinea"; 
								row.Valor = Convert.ToString(pc.WordWrap);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
							#region CantidadMaximaLineas
							row =  _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(_idPerfil,Convert.ToInt64(_idProceso),Convert.ToInt64(_idTarea), _gridName, pc.ColumnName, "CantidadMaximaLineas");
							if(row != null)
								row.Valor = Convert.ToString(pc.MaxLines);
							else
							{
								row = _dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
								row.IdProceso = Convert.ToInt64(_idProceso); 
								row.IdTarea = Convert.ToInt64(_idTarea); 
								row.IdPerfil = _idPerfil;
								row.Grilla = _gridName; 
								row.Campo = pc.ColumnName; 
								row.Propiedad = "CantidadMaximaLineas"; 
								row.Valor  = Convert.ToString(pc.MaxLines);
								row.Activo = true;
								row.Comentario = string.Empty;
								row.FechaCreacion = DateTime.Now;
								row.IdConexionCreacion = Security.IdConexion;
								//row.UltimaModificacion = null;
								row.IdConexionUltimaModificacion = Security.IdConexion;
								row.RowId = Guid.Empty;
								row.IdEmpresa = Security.IdEmpresa;
								row.IdSucursal = Security.IdSucursal;
								_dataConfiguracionGrillasPerfiles.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
							}
							#endregion
						}

					//}
				//}
			}

			#endregion
			
		}

		public void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.tui_ConfiguracionGrillas.Update(this._dataConfiguracionGrillas.Tables["tui_ConfiguracionGrillas"], IdTransaction);
			mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.Update(this._dataConfiguracionGrillasPerfiles.Tables["tui_ConfiguracionGrillasPerfiles"], IdTransaction);
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return null;
		}

		public bool GetHasSaved()
		{
			
			return false;
		}

		#endregion
	}

	public  class PropertiesColumnsCollection : ArrayList
	{
		public void AddItem (PropertiesColumn item)
		{
			this.Add(item);
			
		}

		public PropertiesColumn Get(string columnName)
		{
			foreach(PropertiesColumn item in this)
			{
				if(item.ColumnName.Equals(columnName))
					return item;				
			}
			
			return null;
		}

		public void SortItems()
		{
			this.Sort();
		}

		public void Enroque(int Pos1, int Pos2)
		{
			PropertiesColumn item1 = (PropertiesColumn) this[Pos1];
			PropertiesColumn item2 = (PropertiesColumn) this[Pos2];
			int orden = item1.Order;
			item1.Order = item2.Order;
			item2.Order = orden;
			this.Sort();
		}
	
		public void SaveToUser(string ProcessName, string TaskName, string GridName)
		{
			
			CommitUser(ProcessName, TaskName, GridName, Security.IdUsuario);
			Flush();
			
		}

		private void Flush()
		{
			mz.erp.dataaccess.tui_ConfiguracionGrillasUsuarios.Update(_data.tui_ConfiguracionGrillasUsuarios);
		}


		private tui_ConfiguracionGrillasUsuariosDataset _data = new tui_ConfiguracionGrillasUsuariosDataset();
//Agregar el nuevo valor a la row
		private void CommitUser(string ProcessName, string TaskName, string GridName, string IdUsuario)
		{
			long IdProceso = Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = Workflow.GetIdTakByName(TaskName);
			_data = mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList(IdUsuario, IdProceso,IdTarea, GridName, null, null, null);
			foreach(PropertiesColumn pc in this)
			{
				#region Titulo
				tui_ConfiguracionGrillasUsuariosDataset.tui_ConfiguracionGrillasUsuariosRow row =  _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Titulo");
				if(row != null)
					row.Valor = pc.ColumnCaption;
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Titulo"; 
					row.Valor = pc.ColumnCaption;
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Orden
				row =  row =  _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Orden");
				if(row != null)
					row.Valor = Convert.ToString(pc.Order);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Orden"; 
					row.Valor = Convert.ToString(pc.Order);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region OrdenAgrupamiento
				row =  row =  _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "OrdenAgrupamiento");
				if(row != null)
					row.Valor = Convert.ToString(pc.OrderGroup);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "OrdenAgrupamiento"; 
					row.Valor = Convert.ToString(pc.OrderGroup);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Visible
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Visible");
				if(row != null)
					row.Valor = Convert.ToString(pc.Visible);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Visible"; 
					row.Valor = Convert.ToString(pc.Visible);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Ancho
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Ancho");
				if(row != null)
					row.Valor = Convert.ToString(pc.Width);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Ancho"; 
					row.Valor = Convert.ToString(pc.Width);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Alineacion
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Alineacion");
				if(row != null)
					row.Valor = pc.Alignment;
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Alineacion"; 
					row.Valor = pc.Alignment;
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Formato
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Formato");
				if(row != null)
                    //German 20120817 - Tarea 0000372
                    row.Valor = pc.CastFormatToDBFormat;
                     //Fin German 20120817 - Tarea 0000372
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Formato";
                    //German 20120817 - Tarea 0000372
					row.Valor = pc.CastFormatToDBFormat;
                    //Fin German 20120817 - Tarea 0000372
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region TipoColumna
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "TipoColumna");
				if(row != null)
					row.Valor = pc.Type;
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "TipoColumna"; 
					row.Valor = pc.Type;
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region TipoEdicion
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "TipoEdicion");
				if(row != null)
					row.Valor = pc.EditType;
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "TipoEdicion"; 
					row.Valor = pc.EditType;
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region Multilinea
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "Multilinea");
				if(row != null)
					row.Valor = Convert.ToString(pc.WordWrap);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "Multilinea"; 
					row.Valor = Convert.ToString(pc.WordWrap);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
				#region CantidadMaximaLineas
				row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso,IdTarea, GridName, pc.ColumnName, "CantidadMaximaLineas");
				if(row != null)
					row.Valor = Convert.ToString(pc.MaxLines);
				else
				{
					row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
					row.IdProceso = IdProceso;
					row.IdTarea = IdTarea;
					row.IdUsuario = IdUsuario;
					row.Grilla = GridName; 
					row.Campo = pc.ColumnName; 
					row.Propiedad = "CantidadMaximaLineas"; 
					row.Valor  = Convert.ToString(pc.MaxLines);
					row.Activo = true;
					row.Comentario = string.Empty;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
				}
				#endregion
			}

		}

        #region Matias 20101005 - Tarea 898
        //Matias 20101005 - Tarea 898
        // Guarda la configuracion en tui_ConfiguracionGrillas
        public bool SaveToDefaultGrid(string ProcessName, string TaskName, string GridName, bool ExportSQL, string PathFile)
        {
            CommitDefaultGrid(ProcessName, TaskName, GridName);
            return FlushDefaultGrid(ExportSQL, PathFile);
        }
        // Guarda la configuracion en tui_ConfiguracionGrillasPerfiles
        public bool SaveToPerfil(string ProcessName, string TaskName, string GridName, bool ExportSQL, string PathFile)
        {
            CommitPerfil(ProcessName, TaskName, GridName);
            return FlushPerfiles(ExportSQL, PathFile);
        }
        // Guarda la configuracion en tui_ConfiguracionGrillasUsuarios
        public bool SaveToUser(string ProcessName, string TaskName, string GridName, bool ExportSQL, string PathFile)
        {
            CommitUser(ProcessName, TaskName, GridName);
            return FlushUsuarios(ExportSQL, PathFile); //Flush();
        }
        private void CommitUser(string ProcessName, string TaskName, string GridName)
        {
            string IdUsuario = Security.IdUsuario;
            long IdProceso = Workflow.GetIdProcessByName(ProcessName);
            long IdTarea = Workflow.GetIdTakByName(TaskName);
            _data = mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList(IdUsuario, IdProceso, IdTarea, GridName, null, null, null);
            foreach (PropertiesColumn pc in this)
            {
                #region Titulo
                tui_ConfiguracionGrillasUsuariosDataset.tui_ConfiguracionGrillasUsuariosRow row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Titulo");
                if (row != null)
                    row.Valor = pc.ColumnCaption;
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Titulo";
                    row.Valor = pc.ColumnCaption;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Orden
                row = row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Orden");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Order);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Orden";
                    row.Valor = Convert.ToString(pc.Order);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region OrdenAgrupamiento
                row = row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "OrdenAgrupamiento");
                if (row != null)
                    row.Valor = Convert.ToString(pc.OrderGroup);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "OrdenAgrupamiento";
                    row.Valor = Convert.ToString(pc.OrderGroup);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Visible
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Visible");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Visible);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Visible";
                    row.Valor = Convert.ToString(pc.Visible);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Ancho
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Ancho");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Width);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Ancho";
                    row.Valor = Convert.ToString(pc.Width);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Alineacion
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Alineacion");
                if (row != null)
                    row.Valor = pc.Alignment;
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Alineacion";
                    row.Valor = pc.Alignment;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Formato
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Formato");
                if (row != null)
                    row.Valor = pc.CastFormatToDBFormat;
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Formato";
                    row.Valor = pc.CastFormatToDBFormat;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region TipoColumna
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "TipoColumna");
                if (row != null)
                    row.Valor = pc.Type;
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoColumna";
                    row.Valor = pc.Type;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region TipoEdicion
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "TipoEdicion");
                if (row != null)
                    row.Valor = pc.EditType;
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoEdicion";
                    row.Valor = pc.EditType;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region Multilinea
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "Multilinea");
                if (row != null)
                    row.Valor = Convert.ToString(pc.WordWrap);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Multilinea";
                    row.Valor = Convert.ToString(pc.WordWrap);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
                #region CantidadMaximaLineas
                row = _data.tui_ConfiguracionGrillasUsuarios.FindByIdUsuarioIdProcesoIdTareaGrillaCampoPropiedad(IdUsuario, IdProceso, IdTarea, GridName, pc.ColumnName, "CantidadMaximaLineas");
                if (row != null)
                    row.Valor = Convert.ToString(pc.MaxLines);
                else
                {
                    row = _data.tui_ConfiguracionGrillasUsuarios.Newtui_ConfiguracionGrillasUsuariosRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdUsuario = IdUsuario;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "CantidadMaximaLineas";
                    row.Valor = Convert.ToString(pc.MaxLines);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _data.tui_ConfiguracionGrillasUsuarios.Addtui_ConfiguracionGrillasUsuariosRow(row);
                }
                #endregion
            }
        }
        
        private tui_ConfiguracionGrillasDataset _dataDefault = new tui_ConfiguracionGrillasDataset();
        // Agregar el nuevo valor a la row de tui_ConfiguracionGrillas
        private void CommitDefaultGrid(string ProcessName, string TaskName, string GridName)
        {
            long IdProceso = Workflow.GetIdProcessByName(ProcessName);
            long IdTarea = Workflow.GetIdTakByName(TaskName);
            _dataDefault = mz.erp.businessrules.tui_ConfiguracionGrillas.GetList(IdProceso, IdTarea, GridName, null, null, null);
            foreach (PropertiesColumn pc in this)
            {
                #region Titulo
                tui_ConfiguracionGrillasDataset.tui_ConfiguracionGrillasRow row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Titulo");
                if (row != null)
                    row.ValorDefault = pc.ColumnCaption;
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Titulo";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = pc.ColumnCaption;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Orden
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Orden");
                if (row != null)
                    row.ValorDefault = Convert.ToString(pc.Order);
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Orden";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.Order);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region OrdenAgrupamiento
                row = row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "OrdenAgrupamiento");
                if (row != null)
                    row.ValorDefault = Convert.ToString(pc.OrderGroup);
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "OrdenAgrupamiento";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.OrderGroup);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Visible
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Visible");
                if (row != null)
                    row.ValorDefault = Convert.ToString(pc.Visible);
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Visible";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.Visible);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Ancho
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Ancho");
                if (row != null)
                    row.ValorDefault = Convert.ToString(pc.Width);
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Ancho";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.Width);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Alineacion
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Alineacion");
                if (row != null)
                    row.ValorDefault = pc.Alignment;
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Alineacion";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = pc.Alignment;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Formato
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Formato");
                if (row != null)
                    row.ValorDefault = pc.CastFormatToDBFormat; //pc.Format;
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Formato";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = pc.CastFormatToDBFormat; //pc.Format;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region TipoColumna
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "TipoColumna");
                if (row != null)
                    row.ValorDefault = pc.Type;
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoColumna";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = pc.Type;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region TipoEdicion
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "TipoEdicion");
                if (row != null)
                    row.ValorDefault = pc.EditType;
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoEdicion";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = pc.EditType;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region Multilinea
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "Multilinea");
                if (row != null)
                    row.ValorDefault = Convert.ToString(pc.WordWrap);
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Multilinea";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.WordWrap);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
                #region CantidadMaximaLineas
                row = _dataDefault.tui_ConfiguracionGrillas.FindByIdProcesoIdTareaGrillaCampoPropiedad(IdProceso, IdTarea, GridName, pc.ColumnName, "CantidadMaximaLineas");
                if (row != null)
                {
                    //row.Grilla = GridName;
                    //row.Campo = pc.ColumnName;
                    row.ValorDefault = Convert.ToString(pc.MaxLines);
                    //row.Activo = true;
                    //row.Comentario = string.Empty;
                }
                else
                {
                    row = _dataDefault.tui_ConfiguracionGrillas.Newtui_ConfiguracionGrillasRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "CantidadMaximaLineas";
                    row.Descripcion = string.Empty;
                    row.ValorDefault = Convert.ToString(pc.MaxLines);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataDefault.tui_ConfiguracionGrillas.Addtui_ConfiguracionGrillasRow(row);
                }
                #endregion
            }
        }

        private tui_ConfiguracionGrillasPerfilesDataset _dataPerfil = new tui_ConfiguracionGrillasPerfilesDataset();
        // Agregar el nuevo valor a la row de tui_ConfiguracionGrillasPerfiles
        private void CommitPerfil(string ProcessName, string TaskName, string GridName)
        {
            long IdProceso = Workflow.GetIdProcessByName(ProcessName);
            long IdTarea = Workflow.GetIdTakByName(TaskName);
            long IdPerfil = Security.IdPerfil;
            _dataPerfil = mz.erp.businessrules.tui_ConfiguracionGrillasPerfiles.GetList(IdPerfil, IdProceso, IdTarea, GridName, null, null, null);
            foreach (PropertiesColumn pc in this)
            {
                #region Titulo
                tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Titulo");
                if (row != null)
                    row.Valor = pc.ColumnCaption;
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Titulo";
                    row.Valor = pc.ColumnCaption;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Orden
                row = row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Orden");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Order);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Orden";
                    row.Valor = Convert.ToString(pc.Order);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region OrdenAgrupamiento
                row = row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "OrdenAgrupamiento");
                if (row != null)
                    row.Valor = Convert.ToString(pc.OrderGroup);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "OrdenAgrupamiento";
                    row.Valor = Convert.ToString(pc.OrderGroup);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Visible
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Visible");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Visible);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Visible";
                    row.Valor = Convert.ToString(pc.Visible);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Ancho
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Ancho");
                if (row != null)
                    row.Valor = Convert.ToString(pc.Width);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Ancho";
                    row.Valor = Convert.ToString(pc.Width);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Alineacion
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Alineacion");
                if (row != null)
                    row.Valor = pc.Alignment;
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Alineacion";
                    row.Valor = pc.Alignment;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Formato
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Formato");
                if (row != null)
                    row.Valor = pc.CastFormatToDBFormat; //pc.Format;
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Formato";
                    row.Valor = pc.CastFormatToDBFormat; //pc.Format;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region TipoColumna
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "TipoColumna");
                if (row != null)
                    row.Valor = pc.Type;
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoColumna";
                    row.Valor = pc.Type;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region TipoEdicion
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "TipoEdicion");
                if (row != null)
                    row.Valor = pc.EditType;
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "TipoEdicion";
                    row.Valor = pc.EditType;
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region Multilinea
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "Multilinea");
                if (row != null)
                    row.Valor = Convert.ToString(pc.WordWrap);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "Multilinea";
                    row.Valor = Convert.ToString(pc.WordWrap);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
                #region CantidadMaximaLineas
                row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.FindByIdPerfilIdProcesoIdTareaGrillaCampoPropiedad(IdPerfil, IdProceso, IdTarea, GridName, pc.ColumnName, "CantidadMaximaLineas");
                if (row != null)
                    row.Valor = Convert.ToString(pc.MaxLines);
                else
                {
                    row = _dataPerfil.tui_ConfiguracionGrillasPerfiles.Newtui_ConfiguracionGrillasPerfilesRow();
                    row.IdProceso = IdProceso;
                    row.IdTarea = IdTarea;
                    row.IdPerfil = IdPerfil;
                    row.Grilla = GridName;
                    row.Campo = pc.ColumnName;
                    row.Propiedad = "CantidadMaximaLineas";
                    row.Valor = Convert.ToString(pc.MaxLines);
                    row.Activo = true;
                    row.Comentario = string.Empty;
                    row.FechaCreacion = DateTime.Now;
                    row.IdConexionCreacion = Security.IdConexion;
                    //row.UltimaModificacion = null;
                    row.IdConexionUltimaModificacion = Security.IdConexion;
                    row.RowId = Guid.Empty;
                    row.IdEmpresa = Security.IdEmpresa;
                    row.IdSucursal = Security.IdSucursal;
                    _dataPerfil.tui_ConfiguracionGrillasPerfiles.Addtui_ConfiguracionGrillasPerfilesRow(row);
                }
                #endregion
            }

        }

        private bool FlushDefaultGrid(bool ExportToSQL, string PathFile)
        {
            if (ExportToSQL)
                _replication = GenerateReplication("dataaccess.tui_ConfiguracionGrillas");

            //mz.erp.dataaccess.tui_ConfiguracionGrillas.Update(_dataDefault.tui_ConfiguracionGrillas);
            mz.erp.dataaccess.tui_ConfiguracionGrillas.Update(_dataDefault.tui_ConfiguracionGrillas, _replication);

            // AfterFlush()            
            if ((ExportToSQL) && (PathFile != null) && (!PathFile.Equals(string.Empty)))
                return this.Export(PathFile);
            return true;
        }

        private bool FlushPerfiles(bool ExportToSQL, string PathFile)
        {
            if (ExportToSQL)
                _replication = GenerateReplication("dataaccess.tui_ConfiguracionGrillasPerfiles");

            mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.Update(_dataPerfil.tui_ConfiguracionGrillasPerfiles, _replication);

            // AfterFlush()            
            if ((ExportToSQL) && (PathFile != null) && (!PathFile.Equals(string.Empty)))
                return this.Export(PathFile);
            return true;
        }

        private bool FlushUsuarios(bool ExportToSQL, string PathFile)
        {
            if (ExportToSQL)
                _replication = GenerateReplication("dataaccess.tui_ConfiguracionGrillasUsuarios");

            mz.erp.dataaccess.tui_ConfiguracionGrillasUsuarios.Update(_data.tui_ConfiguracionGrillasUsuarios, _replication);

            // AfterFlush()            
            if ((ExportToSQL) && (PathFile != null) && (!PathFile.Equals(string.Empty)))
                return this.Export(PathFile);
            return true;
        }

        private bool Export(string PathFile)
        {
            System.Text.StringBuilder _sentencia = _replication.Sentence;
            if (_sentencia != null)
            {
                // Armar el archivo
                FileInfo file = new FileInfo(PathFile);
                System.IO.FileStream fs;
                try
                {
                    //if (System.IO.File.Exists(PathFile))
                    //{
                    //    fs = System.IO.File.Open(PathFile, FileMode.Open, FileAccess.Read, FileShare.None);
                    //    fs.Close();
                    //}
                    StreamWriter debugWriter = new StreamWriter(file.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite), System.Text.Encoding.Unicode);
                    //Reemplaza TODOS los ";" por ";" + nuevaLinea.
                    _sentencia.Replace(";", ";" + Environment.NewLine);
                    debugWriter.WriteLine(_sentencia.ToString());
                    debugWriter.Flush();
                }
                catch (Exception exp)
                {
                    return false;
                }
            }
            return true;
        }

        private mz.erp.commontypes.SentenciasReplicacion _replication;
        public /*override*/ mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
        {
            return _replication;
        }

        private mz.erp.commontypes.SentenciasReplicacion GenerateReplication(string NombreTabla)
        {
            mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = NombreTabla;
            return replication;
        }


        //FinMatias 20101005 - Tarea 898
        #endregion

	}

	public  class PropertiesColumn:IComparer, IComparable
	{

		private string _name = string.Empty;
		private string _caption = string.Empty;
		private bool _visible = true;
		private decimal _width = 100;
		private string _alignment = string.Empty;
		private string _editType = string.Empty;		
		private string _format = string.Empty;
		private bool _wordwrap = false;
		private int _maxLines = 1;
		private int _order = 0;
		private string _type = string.Empty;
		//Define si esa columna esta dentro del agrupamiento realizado, y en q orden
		private int _orderGroup = -1;



		public string Type
		{
			get{return _type;}
			set{_type = value;}
		}

		public int Order 
		{
			get{return _order;}
			set{_order = value;}
		}
		public int OrderGroup 
		 {
			 get{return _orderGroup;}
			 set{_orderGroup = value;}
		 }
		
		public int MaxLines 
		{
			get{return _maxLines;}
			set{_maxLines = value;}
		}

		
		public bool WordWrap
		{
			get{return _wordwrap;}
			set{_wordwrap = value;}
		}

		public string Format 
		{
			get{return _format;}
			set{_format = value;}
		}	
		public string EditType 
		{
			get{return _editType;}
			set{_editType = value;}
		}		
		public string Alignment 
		{
			get{return _alignment;}
			set{_alignment = value;}
		}	

		public decimal Width
		{
			get{return _width;}
			set{_width = value;}
		}	

		public string ColumnName
		{
			get{return _name;}
			set{_name = value;}
		}
			
		public string ColumnCaption 
		{
			get{return _caption;}
			set{_caption = value;}
		}

		public bool Visible 
		{
			get{return _visible;}
			set{_visible = value;}
		}
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			PropertiesColumn item1 = (PropertiesColumn)x;
			PropertiesColumn item2 = (PropertiesColumn)y;
			return item1.Order.CompareTo(item2.Order);
		}

		#endregion

		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			PropertiesColumn item1 = (PropertiesColumn)obj;
			return this.Order.CompareTo(item1.Order);
		}

		#endregion

        #region Matias 20101025 - Tarea 898
        //Matias 20101025 - Tarea 898
        public string CastFormatToDBFormat
        {
            get
            {
                switch (Format)
                {
                    case "c": return "Moneda";
                        break;
                    case "p": return "Porcentaje";
                        break;
                    case "d": return "Fecha";
                        break;
                    case "dd/MM/yyyy": return "Fecha corta";
                        break;
                    case "0": return "Entero";
                        break;
                    case "0.00": return "Decimal";
                        break;
                    case "#,##0.00;#,##0.00;0.00": return "Decimal+-0";
                        break;
                    case "f": return "Default";
                        break;
                    default: return "Default";
                }
            }
        }
        //FinMatias 20101025 - Tarea 898
        #endregion
	}
}

