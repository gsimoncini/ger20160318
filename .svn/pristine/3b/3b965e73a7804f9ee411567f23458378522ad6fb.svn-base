using System;
using mz.erp.commontypes.data;
using System.Data;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmEntidades.
	/// </summary>
	public class AbmEntidades:ITask,IPersistentTask
	{
		private string _estado;

		private tfi_EntidadesDataset _dataEntidades = new tfi_EntidadesDataset();
		private tfi_AgrupTDCompTesoreriaDataset _dataTDCompTesoreria = new tfi_AgrupTDCompTesoreriaDataset();
		private tfi_TDCompTesoreria_EntidadesDataset _dataTDCompTesoreria_Entidades = new tfi_TDCompTesoreria_EntidadesDataset();
		private tui_ConfiguracionFamiliaFDPEntidadesDataset _dataFamiliaFDP_Entidades = new tui_ConfiguracionFamiliaFDPEntidadesDataset();
		private DataTable _listaComprobantesTesoreriaBDConJerarquia1 = new DataTable();
		private DataTable _listaComprobantesTesoreriaBDConJerarquia = new DataTable();
		private Hashtable _nivelUno=new Hashtable();
		private Hashtable _familiasPorClaveLarga=new Hashtable();

		private ProcessManager _processParent;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;


		public AbmEntidades()
		{
			_estado= "NEW";
		}

		public AbmEntidades(string Codigo)
		{

			if (Codigo == null)
			{
				//creacion de todos los objetos de las clases relacionadas
				_estado= "NEW";
			}
			else 
			{
				//levantar todos los ojetos de este id
				this.GetEntidad(Codigo);
				_estado ="MODIFY";			
			}
		}

		#region Propiedades

		private string _idEntidad = string.Empty;		
		public string IdEntidad
		{
			get { return _idEntidad; }
			set
			{		
				_idEntidad = value;
			}
		}

		private string _codigo = String.Empty;
		public string Codigo
		{
			get	{return _codigo;}
			set
			{
				_codigo = value;
			}
		}

		private string _descripcion = string.Empty;
		public string Descripcion
		{
			get	{return _descripcion;}
			set
			{
				_descripcion = value;
			}
		}

		private string _familia = string.Empty;
		public string Familia
		{
			get{return _familia;}
			set 
			{
				_familia = value;
			}
		}

		private bool _activo = true;
		public bool Activo
		{
			get{return _activo;}
			set 
			{
				_activo = value;
			}
		}

		private string _jerarquia = string.Empty;
		public string Jerarquia
		{
			get{return _jerarquia;}
			set
			{
				if(_jerarquia != value)
				{	_jerarquia=value;
					if(_jerarquia!=string.Empty && _jerarquia!=null)
					{
						//Cargo los de nivel 1 en el segundo combo
						_listaComprobantesTesoreriaBDConJerarquia1=(DataTable)_nivelUno[_jerarquia];			
					}		
				}
			}
		}

		private string _jerarquia1 = string.Empty;
		public string Jerarquia1
		{
			get{return _jerarquia1;}
			set
			{
				if(_jerarquia1 != value)
				{
					_jerarquia1=value;									

				}
			}
		}

		private string _idNomenclatura = string.Empty;
		public string IdNomenclatura
		{
			get{return _idNomenclatura;}
			set 
			{
				_idNomenclatura = value;
			}
		}

		public Hashtable FamiliasPorClaveLarga
		{
			get{return _familiasPorClaveLarga;}
		}

		public bool TieneHijos
		{
			get{return _listaComprobantesTesoreriaBDConJerarquia1.Rows.Count>0;}
		}

		public DataTable ListaSegundoNivel
		{
			get{return _listaComprobantesTesoreriaBDConJerarquia1;}
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

		private string _leyendaFormulario = "Entidades";	
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(_processParent.Process.ProcessName, _taskName,"LeyendaFormulario");
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
		
		#endregion
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

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
			//_entidad = new Entidad(null);

			_listaComprobantesTesoreriaBDConJerarquia=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListTodosByNivel(0);
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				_familiasPorClaveLarga[fila["Jerarquia"]]=fila["ClaveLarga"];
				//_agrupadosFamilia[fila["Jerarquia"]]=fila["Agrupado"];
				//Talvez necesite las de nivel uno tambien
				//_claveCortas[fila["Jerarquia"]]=fila["ClaveCorta"];
				
			}
			this.BuscarNivelUno();

			string proceso = _processParent.Process.ProcessName;

			_contenedoresHabilitados= Variables.GetValueString(proceso, _taskName,"ContenedoresHabilitados");		
			_contenedoresVisibles = Variables.GetValueString(proceso, _taskName,"ContenedoresVisibles");
			_preguntarAlCancelar = Variables.GetValueBool(proceso, _taskName,"PreguntarAlCancelar");
		}


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
			return true;
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

		private void ValidarDatos()
		{
			_errores.Clear();
			string Cod=Codigo.Trim();			
			if (Cod.CompareTo(string.Empty) == 0)
			{
				_errores.Add( new ItemDatasetError("Entidad","Codigo","El campo no puede estar vacío"));
			}
			else
			{
				tfi_EntidadesDataset data = mz.erp.dataaccess.tfi_Entidades.GetList(Codigo,null);
				if (data.tfi_Entidades.Count != 0)
				{
					string Id = data.tfi_Entidades.Rows[0]["IdEntidad"].ToString();
					if (Id != _idEntidad)
						{_errores.Add(new ItemDatasetError ("Entidad","Codigo","El código ya existe"));}
					else 
					{
						Cod = data.tfi_Entidades.Rows[0]["Codigo"].ToString();
						if (Cod != _codigo)
							{_errores.Add(new ItemDatasetError ("Entidad","Codigo","El código ya existe"));}
						else {Codigo = Cod;}
					}
				}
			}
			Descripcion=Descripcion.Trim();			
			if (Descripcion.CompareTo(string.Empty) == 0)
			{
				_errores.Add( new ItemDatasetError( "Entidad","Descripcion","El campo no puede estar vacío") );
			}
		}

		public void BuscarNivelUno()
		{
			DataTable result=new DataTable();
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				result=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListTodosByNivelAndPadre(1,Convert.ToString(fila["Jerarquia"]));
				//Carga todos los tfi_tdComprobantes q son 'hijos' de los de nivel 1
				foreach (DataRow row in result.Rows)
				{
					DataTable table=new DataTable();
					table=mz.erp.businessrules.tfi_TDCompTesoreria.GetListByJerarquia(Convert.ToString(row["Jerarquia"]));
				}
				_nivelUno[fila["Jerarquia"]]=result;
				
			}
		}

		public void seleccionarFamilia()
		{
			//Esto es para q tenga algo por default
			this.Jerarquia=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia.Rows[0]["jerarquia"]);
		}

		public void SeleccionarFamiliaDeNivel2()
		{
			//Esto es para q tenga algo por default
			Jerarquia1=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia1.Rows[0]["jerarquia"]);
		}

		public void ActualizarJerarquiaUno()
		{
			Jerarquia1=string.Empty;
		}

		public DataTable GetTableFamiliasTDCompTesoreria()
		{
					
			DataTable _tableFamiliasTDCompTesoreria = new DataTable();
			_tableFamiliasTDCompTesoreria.Columns.Add("Jerarquia");
			_tableFamiliasTDCompTesoreria.Columns.Add("Descripcion");
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				DataRow row0 = _tableFamiliasTDCompTesoreria.NewRow();
				row0["Jerarquia"] = fila["Jerarquia"];
				row0["Descripcion"] = fila["Descripcion"];
				_tableFamiliasTDCompTesoreria.Rows.Add(row0);}
			return _tableFamiliasTDCompTesoreria;
		}

		public void GetEntidad(string Codigo) 
		{
			tfi_EntidadesDataset.tfi_EntidadesRow rowEntidad = tfi_Entidades.GetByCodigo(Codigo);

			if (rowEntidad !=null)
			{
				IdEntidad = rowEntidad.IdEntidad;
				Descripcion = rowEntidad.Descripcion;		
				Activo = rowEntidad.ActivoPorDefault;
				IdNomenclatura = rowEntidad.IdNomenclatura;
			
			
				tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow rowJerarquiaAgrup = tfi_JerarquiaAgrupTDCompTesoreria.GetByPk(IdNomenclatura);

				if ((rowJerarquiaAgrup.IdPadre==string.Empty) && (rowJerarquiaAgrup.IdPadre != null))
				{
					Jerarquia = rowJerarquiaAgrup.Jerarquia;
				}
				else
				{
					Jerarquia = rowJerarquiaAgrup.IdPadre;
					Jerarquia1 = rowJerarquiaAgrup.Jerarquia;
				}

				tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow rowFamiliaFDP_Entidades= mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.GetByIdEntidad(IdEntidad);

				if (rowFamiliaFDP_Entidades !=null)
				{
					Familia = rowFamiliaFDP_Entidades.Familia;
				}
			}
			if (IdEntidad != string.Empty) {
				_estado = "MODIFY";}

		}

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = _taskName;
			data.Add(this._dataEntidades);
			data.Add(this._dataTDCompTesoreria);
			data.Add(this._dataTDCompTesoreria_Entidades);
			data.Add(this._dataFamiliaFDP_Entidades);
			return data;
		}


		public void Commit()
		{
			if (_estado == "NEW")
			{
				#region NEW

				tfi_EntidadesDataset.tfi_EntidadesRow rowEntidad = _dataEntidades.tfi_Entidades.Newtfi_EntidadesRow();
			
				mz.erp.businessrules.tfi_Entidades.SetRowDefaultValues(rowEntidad);
				
				rowEntidad.Descripcion = this._descripcion;
				rowEntidad.Codigo = this._codigo;
				rowEntidad.ActivoPorDefault = this._activo;

				if ((_jerarquia1!=null)&&(_jerarquia1!=string.Empty))
					{_dataTDCompTesoreria = tfi_AgrupTDCompTesoreria.GetList(null,Jerarquia1);
					tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow rowJerarquiaAgrup = mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetByJerarquia(Jerarquia,Jerarquia1);
					rowEntidad.IdNomenclatura = rowJerarquiaAgrup.IdNomenclatura;

				}
				else
					{_dataTDCompTesoreria = tfi_AgrupTDCompTesoreria.GetList(null,Jerarquia);
					tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow rowJerarquiaAgrup = mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetByJerarquia(null,Jerarquia);
					rowEntidad.IdNomenclatura = rowJerarquiaAgrup.IdNomenclatura;
				}

				_dataEntidades.tfi_Entidades.Rows.Add(rowEntidad);

				foreach (tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow rowTDComp in _dataTDCompTesoreria.tfi_AgrupTDCompTesoreria.Rows)
				{
					string idTDComp = rowTDComp["IdTDCompTesoreria"].ToString();
					tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow rowTDComp_Entidades = _dataTDCompTesoreria_Entidades.tfi_TDCompTesoreria_Entidades.Newtfi_TDCompTesoreria_EntidadesRow();
					mz.erp.businessrules.tfi_TDCompTesoreria_Entidades.SetRowDefaultValues(rowTDComp_Entidades);
					rowTDComp_Entidades.TDCompTesoreria = idTDComp;
					rowTDComp_Entidades.Activo = this._activo;
					_dataTDCompTesoreria_Entidades.tfi_TDCompTesoreria_Entidades.Rows.Add(rowTDComp_Entidades);
				}

				tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow rowFamiliaFDP_Entidades= _dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades.Newtui_ConfiguracionFamiliaFDPEntidadesRow();
				mz.erp.businessrules.tui_ConfiguracionFamiliaFDPEntidades.SetRowDefaultValues(rowFamiliaFDP_Entidades);
				rowFamiliaFDP_Entidades.Familia = this._familia;
				rowFamiliaFDP_Entidades.Activo = this._activo;

				_dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades.Rows.Add(rowFamiliaFDP_Entidades);

				#endregion 
                			
			}
			else 
			{  //estado = "MODIFY"

				#region MODIFY

				tfi_EntidadesDataset.tfi_EntidadesRow rowEntidad = mz.erp.dataaccess.tfi_Entidades.GetByPk(_idEntidad);
		
				rowEntidad.Descripcion = this._descripcion;
				rowEntidad.Codigo = this._codigo;
				rowEntidad.ActivoPorDefault = this._activo;
				
				_dataEntidades.tfi_Entidades.ImportRow(rowEntidad);

				_dataTDCompTesoreria_Entidades = tfi_TDCompTesoreria_Entidades.GetByIdEntidad(_idEntidad);
				foreach (tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow rowTDComp_Entidades in _dataTDCompTesoreria_Entidades.tfi_TDCompTesoreria_Entidades.Rows)
				{
					rowTDComp_Entidades.Activo = this._activo;
				}
				
				tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow rowFamiliaFDP_Entidades= mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.GetByIdEntidad(_idEntidad);
				rowFamiliaFDP_Entidades.Activo = this._activo;

				_dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades.ImportRow(rowFamiliaFDP_Entidades);

				#endregion

			}

			
		}

		public void Flush(string IdTransaction)
		{/*
			if (_state != BRTypes.ABMState.Consulta)
			{
				mz.erp.businessrules.tsh_Productos.Update( _rowProductos, IdTransaction, new SentenciasReplicacion() );
				_sentencia = GenerateReplication();
				PutErrorOnDataSet(_rowProductos);
			}*/

			mz.erp.dataaccess.tfi_Entidades.Update(_dataEntidades.tfi_Entidades,IdTransaction);

			if (_dataEntidades.tfi_Entidades.Rows[0].RowState != System.Data.DataRowState.Deleted)
			{
				this._idEntidad = _dataEntidades.tfi_Entidades.Rows[0]["IdEntidad"].ToString();
			}

			foreach(tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow rowTDComp in _dataTDCompTesoreria_Entidades.tfi_TDCompTesoreria_Entidades.Rows)
			{
				if (rowTDComp.RowState != System.Data.DataRowState.Deleted)
				{
					rowTDComp["IdEntidad"] = this._idEntidad;}
			}

			mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.Update(_dataTDCompTesoreria_Entidades.tfi_TDCompTesoreria_Entidades, IdTransaction);

			if (_dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades.Rows[0].RowState != System.Data.DataRowState.Deleted)
			{
				_dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades.Rows[0]["IdEntidad"] = this._idEntidad;
			}

			mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.Update(_dataFamiliaFDP_Entidades.tui_ConfiguracionFamiliaFDPEntidades, IdTransaction);

		}

		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			replication.Destino = null;
			replication.VersionBD = null;
			//replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
		}

		public void PutErrorOnDataSet(System.Data.DataRow row)
		{/*
			_errors.Clear();
			if (_rowProductos.HasErrors)
			{
				System.Data.DataColumn[] columnasConError = row.GetColumnsInError();
				for(int i=0;columnasConError.Length<i;i++)
				{
					ItemDatasetError error = new ItemDatasetError( ((System.Data.DataColumn)columnasConError[i]).Table.TableName,  ((System.Data.DataColumn)columnasConError[i]).ColumnName, row.GetColumnError( columnasConError[i] ) );
					_errors.Add( error );
				}
			}*/
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _sentencia;
			
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion
	}
}
