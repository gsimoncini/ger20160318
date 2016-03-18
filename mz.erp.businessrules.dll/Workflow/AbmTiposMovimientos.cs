using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmTiposMovimientos.
	/// </summary>	/// 
	public class AbmTiposMovimientos: ITask, IPersistentTask
	{
		public AbmTiposMovimientos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}		

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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init //User ID=sa;password=03461441874;Initial Catalog=Prueba;Data Source=sservidor
			_tiposMovimientos = tsy_TiposMovimientos.GetList().tsy_TiposMovimientos;							

			DataTable tipos = tsy_TiposMovimientos.GetList().tsy_TiposMovimientos.Copy();
			DataColumn columna=new DataColumn("Tipo Movimiento");
			columna.DataType =typeof (string); 
			tipos.Columns.Add(columna);
			foreach (System.Data.DataRow row in tipos.Rows){
			
				if (Convert.ToDouble(row["Signo"])==-1)
					row["Tipo Movimiento"]="Egreso";
				else 
					if (Convert.ToDouble(row["Signo"])==1) 
						row["Tipo Movimiento"]="Ingreso";

			}
			
			
			DataTable subtipos = tsy_SubTipoMovimiento.GetList().tsy_SubTipoMovimiento.Copy();
			_tiposSubTipos.Tables.Add(tipos);
			_tiposSubTipos.Tables.Add(subtipos);

			DataColumn columnA = _tiposSubTipos.Tables["tsy_TiposMovimientos"].Columns["IdTipoMovimiento"];
			DataColumn columnB = _tiposSubTipos.Tables["tsy_SubTipoMovimiento"].Columns["IdTipoMovimiento"];
			_tiposSubTipos.Relations.Add("TiposSubtipos", columnA, columnB);

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
			bool IsValid = true;
			_errores.Clear();
		
			/*if (_claveNueva1 != _claveNueva2)
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña nueva","Error en la confirmación de la contraseña"));
			}*/

			return IsValid;
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
			foreach(object mov in _tiposMovimientosNuevos)
			{
				MovimientoNuevo mn = (MovimientoNuevo) mov;
				switch(mn.Modo)
				{				
					case "NEW":
						//if (mn.Modo == "NEW")
					{
						#region NEW

						if (mn.KeyTipo == mn.KeySubTipo)
						{
							tsy_TiposMovimientosExDataset.tsy_TiposMovimientosRow row = _data.tsy_TiposMovimientos.Newtsy_TiposMovimientosRow();
							row.Descripcion = mn.DescripcionTipo;
							row.FechaCreacion = DateTime.Now;
							row.AfectaStock = false;
							row.Sistema = false;
							row.IdConexionCreacion = Security.IdConexion;
							row.IdTipoMovimiento = mn.KeyTipo;
							row.IdReservado = 0;
							row.IdEmpresa = Security.IdEmpresa;						
							row.signo = (Int16) (mn.EsIngreso ? 1 : -1);		
							row.Activo = mn.Activo;
							_data.tsy_TiposMovimientos.Addtsy_TiposMovimientosRow(row);
						}
						else 
						{						
							tsy_TiposMovimientosExDataset.tsy_TiposMovimientosRow rowT1 = _data.tsy_TiposMovimientos.FindByIdTipoMovimiento(mn.KeyTipo);
							if (rowT1 == null)
							{
								DataRow rowT = tsy_TiposMovimientos.GetByPk(mn.KeyTipo);
								rowT.AcceptChanges();
								_data.tsy_TiposMovimientos.ImportRow(rowT);
							}
							tsy_TiposMovimientosExDataset.tsy_SubTipoMovimientoRow row = _data.tsy_SubTipoMovimiento.Newtsy_SubTipoMovimientoRow();
							row.Descripcion = mn.DescripcionSubTipo;						
							row.IdTipoMovimiento = mn.KeyTipo;
							row.IdSubTipoMovimiento = mn.KeySubTipo;	
							row.Sistema = false;
							row.FechaCreacion = DateTime.Now;
							row.IdConexionCreacion = Security.IdConexion;
							row.IdReservado = 0;
							row.Activo = mn.Activo;
							_data.tsy_SubTipoMovimiento.Addtsy_SubTipoMovimientoRow(row);
						}
						break;

						#endregion
					}
						//else //"MODIF"
					case "MODIF":
					{
						#region MODIF

						if (mn.KeySubTipo == "")
						{
							DataRow rowT = tsy_TiposMovimientos.GetByPk(mn.KeyTipo);
							rowT["Descripcion"] = mn.DescripcionTipo;
							rowT["signo"] = (Int16) (mn.EsIngreso ? 1 : -1);
							rowT["Activo"] = mn.Activo;
							_data.tsy_TiposMovimientos.ImportRow(rowT);
						}
						else 
						{
							tsy_TiposMovimientosExDataset.tsy_TiposMovimientosRow rowT1 = _data.tsy_TiposMovimientos.FindByIdTipoMovimiento(mn.KeyTipo);
							if (rowT1 == null)
							{
								DataRow rowT = tsy_TiposMovimientos.GetByPk(mn.KeyTipo);
								rowT.AcceptChanges();
								_data.tsy_TiposMovimientos.ImportRow(rowT);
							}

							DataRow rowST = tsy_SubTipoMovimiento.GetByPk(mn.KeySubTipo, mn.KeyTipo);
							rowST["Descripcion"] = mn.DescripcionSubTipo;
							rowST["Activo"] = mn.Activo;
							_data.tsy_SubTipoMovimiento.ImportRow(rowST);
						}
						break;

						#endregion
					}
					case "ELIMINAR_SUBTIPO":
					{
						tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row = tsy_SubTipoMovimiento.GetByPk(mn.KeySubTipo,mn.KeyTipo);
						row.Delete();
						_data.tsy_SubTipoMovimiento.ImportRow(row);

						break;
					}
					case "ELIMINAR_TIPO":
					{
						tsy_TiposMovimientosDataset.tsy_TiposMovimientosRow rowTipo = tsy_TiposMovimientos.GetByPk(mn.KeyTipo);
						rowTipo.Delete();
						_data.tsy_TiposMovimientos.ImportRow(rowTipo);

						tsy_SubTipoMovimientoDataset data = tsy_SubTipoMovimiento.GetList(mn.KeyTipo);
						foreach (tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow rowSubTipo in data.tsy_SubTipoMovimiento.Rows)
						{
							rowSubTipo.Delete();
							_data.tsy_SubTipoMovimiento.ImportRow(rowSubTipo);
						}
						break;

					}
				}
			}
			/*_row = sy_Usuarios.GetByPk(this._idUsuario);	
			string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( this._claveNueva2 );
			_row.Clave = encriptada;
			_data.sy_Usuarios.ImportRow(_row);*/
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
			replication.NombreTabla = "dataaccess.sy_Usuarios";			
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
			dataaccess.tsy_TiposMovimientos.Update(_data.tsy_TiposMovimientos, trx, _replication);
			dataaccess.tsy_SubTipoMovimiento.Update(_data.tsy_SubTipoMovimiento, trx, _replication);

			
			//sy_Usuarios.Update(_data, trx, _replication);			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region Variables privadas
		private tsy_TiposMovimientosDataset.tsy_TiposMovimientosDataTable _tiposMovimientos;					
		private DataSet _tiposSubTipos = new DataSet();
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		
		tsy_TiposMovimientosExDataset _data = new tsy_TiposMovimientosExDataset();
		
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TiposMovimientosHasChanged;
		public event System.EventHandler SubTiposMovimientosHasChanged;
		public event System.EventHandler TiposMovimientosNuevosHasChanged;
		#endregion

		#region Métodos públicos
		public void AddMovimiento(string DescripcionTipo, string KeyTipo, string DescripcionSubTipo, string KeySubTipo, bool EsIngreso, string Modo, bool Activo)
		{		
			if (Modo == "NEW")
			{
				if (KeyTipo == "")
				{
					//Creacion de tipo de movimiento
					KeyTipo = systemframework.Util.NewStringId();
					KeySubTipo = KeyTipo;
					DataRow rowTP = _tiposMovimientos.NewRow();					
					rowTP["IdTipoMovimiento"] = KeyTipo;
					rowTP["Descripcion"] = DescripcionTipo;
					_tiposMovimientos.Rows.Add(rowTP);
					if(TiposMovimientosHasChanged != null)
						TiposMovimientosHasChanged(this, new EventArgs());
				}			
				else 
				{
					KeySubTipo = systemframework.Util.NewStringId();
				}
			}

			MovimientoNuevo mn = null;
			if (KeySubTipo == "")
			{
				foreach (MovimientoNuevo mov in _tiposMovimientosNuevos)
				{
					if (mov.KeyTipo.Equals(KeyTipo))
						mn = mov;
				}
			}
			else
			{
				foreach (MovimientoNuevo mov in _tiposMovimientosNuevos)
				{
					if (mov.KeySubTipo.Equals(KeySubTipo))
						mn = mov;
				}
			}
			if (mn != null)
			{
				mn.Activo = Activo;
				mn.DescripcionSubTipo = DescripcionSubTipo;
				mn.DescripcionTipo = DescripcionTipo;
				mn.Modo = Modo;
			}
			else
			{
				mn = new MovimientoNuevo(DescripcionTipo, KeyTipo, DescripcionSubTipo, KeySubTipo, EsIngreso, Modo, Activo);
				_tiposMovimientosNuevos.Add(mn);
			}

			if (KeySubTipo == "")
			{
				DataRow rowTipo = _tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Find(KeyTipo);
				_tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Remove(rowTipo);
				rowTipo["Descripcion"] = mn.DescripcionTipo;
				rowTipo["IdTipoMovimiento"] = mn.KeyTipo;				
				rowTipo["Activo"] = mn.Activo;
				if (mn.EsIngreso)
					rowTipo["Tipo Movimiento"]="Ingreso";
				else 
					rowTipo["Tipo Movimiento"]="Egreso";	
				

				_tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Add(rowTipo);
			}
			else
			{
				tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow rowSubTipo = null;
				foreach (tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row in _tiposSubTipos.Tables["tsy_SubTipoMovimiento"].Rows)
				{
					if ((row.IdTipoMovimiento == KeyTipo) && (row.IdSubTipoMovimiento == KeySubTipo))
					{
						rowSubTipo = row;
					}
				}
				if (rowSubTipo != null)
				{
					_tiposSubTipos.Tables["tsy_SubTipoMovimiento"].Rows.Remove(rowSubTipo);
					rowSubTipo["Descripcion"] = mn.DescripcionSubTipo;						
					rowSubTipo["IdTipoMovimiento"] = mn.KeyTipo;
					rowSubTipo["IdSubTipoMovimiento"] = mn.KeySubTipo;	
					rowSubTipo["Activo"] = mn.Activo;
					_tiposSubTipos.Tables["tsy_SubTipoMovimiento"].Rows.Add(rowSubTipo);
				}
			}

			if(TiposMovimientosNuevosHasChanged != null)
				TiposMovimientosNuevosHasChanged(this, new EventArgs());	
		}

        //Cristian Tarea 00000112
        public void RemoveModificacion(String keyTipo)
        {

            DataTable tipos = tsy_TiposMovimientos.GetList().tsy_TiposMovimientos.Copy();
            DataColumn columna = new DataColumn("Tipo Movimiento");
            columna.DataType = typeof(string);
            tipos.Columns.Add(columna);
            DataTable tiposmovimientos = this._tiposMovimientos;
//            foreach (MovimientoNuevo mov in this._tiposMovimientosNuevos)
//            {
                foreach (DataRow fila in tipos.Rows)
                {
                    //Console.WriteLine("KeyTipo: " + mov.KeyTipo);
                    Console.WriteLine("columna 0 :" + fila[0].ToString());
                    if (keyTipo == fila[0].ToString())
                    {
                        DataRow rowTipo = tipos.Rows.Find(keyTipo);
                        DataRow rowTipo2 = _tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Find(keyTipo);
               
                        String descripcion = (string) rowTipo["Descripcion"];
                        bool activo = (Boolean) rowTipo["Activo"];
                        //String tipoMov = string.Empty; //(string)rowTipo["Tipo Movimiento"];
                        _tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Remove(rowTipo2);
                        rowTipo2["Descripcion"] = descripcion;
                        rowTipo2["IdTipoMovimiento"] = keyTipo;
                        rowTipo2["Activo"] = activo;

				        if (Convert.ToDouble(rowTipo["Signo"])==-1)
					        rowTipo2["Tipo Movimiento"]="Egreso";
				        else 
					        if (Convert.ToDouble(rowTipo["Signo"])==1) 
						        rowTipo2["Tipo Movimiento"]="Ingreso";

                        _tiposSubTipos.Tables["tsy_TiposMovimientos"].Rows.Add(rowTipo2);

                    }
    //            }

           }
               
            if (TiposMovimientosNuevosHasChanged != null)
                TiposMovimientosNuevosHasChanged(this, new EventArgs());
        }
        //Fin Tarea 00000112

		public void RemoveMovimiento(string KeyTipo, string KeySubTipo)
		{			
			ArrayList borrados = new ArrayList();
			if (KeyTipo == KeySubTipo)
			{
				//Debe borrar tipo de movimiento y los subtipos agregados
				foreach( object objeto in _tiposMovimientosNuevos)
				{
					//Borra tipo
					MovimientoNuevo movimiento = (MovimientoNuevo) objeto;										
					if (movimiento.KeyTipo == KeyTipo)
						//_tiposMovimientosNuevos.Remove(objeto);
						borrados.Add(objeto);
				}
			}			
			else 
			{
				//Debe borrar solo el subtipo seleccionado
				foreach( object objeto in _tiposMovimientosNuevos)
				{
					MovimientoNuevo movimiento = (MovimientoNuevo) objeto;
					if (movimiento.KeyTipo == KeyTipo && movimiento.KeySubTipo == KeySubTipo)
						//_tiposMovimientosNuevos.Remove(objeto);
						borrados.Add(objeto);
				}
			}
			foreach (object objeto in borrados)
			{
				_tiposMovimientosNuevos.Remove(objeto);
			}
			if (borrados.Count > 0)
				if(TiposMovimientosNuevosHasChanged != null)
					TiposMovimientosNuevosHasChanged(this, new EventArgs());	

		}

		public bool TieneMovimientosAsociados( string Key, string Tipo)
		{
			if (Tipo == "TIPO")
			{
				tfi_MovimientosDeCajaDataset data = tfi_MovimientosDeCaja.GetByTipo(Key);
				return (data.tfi_MovimientosDeCaja.Rows.Count != 0);
			}
			else
			{// SUBTIPO
				tfi_MovimientosDeCajaDataset data = tfi_MovimientosDeCaja.GetBySubTipo(Key);
				return (data.tfi_MovimientosDeCaja.Rows.Count != 0);
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

		private string _leyendaFormulario = "Modificación de tipos de movimientos";
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
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {
				_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
				return _preguntarAlCancelar ;
			}
		}
		public System.Data.DataTable TiposMovimientos 
		{
			get {return _tiposMovimientos;}
		}

		public System.Data.DataSet TiposSubTipos 
		{
			get {return _tiposSubTipos;}
		}		
		private System.Collections.ArrayList _tiposMovimientosNuevos = new ArrayList();
		public System.Collections.ArrayList TiposMovimientosNuevos
		{
			get {return _tiposMovimientosNuevos;}
		}

		public bool PerteneceAPerfilSuperior
		{
			get 
			{
				return mz.erp.businessrules.Security.PerteneceAPerfilSuperior;
			}
		}
		
		#endregion	
	}

	
	public class MovimientoNuevo
	{
		public MovimientoNuevo()
		{
		}
		public MovimientoNuevo(string DescripcionTipo, string KeyTipo, string DescripcionSubTipo, string KeySubTipo, bool EsIngreso, string Modo, bool Activo)
		{		
			_descripcionTipo = DescripcionTipo;			
			_keyTipo = KeyTipo;
			_descripcionSubTipo = DescripcionSubTipo;
			_keySubTipo = KeySubTipo;
			_esIngreso = EsIngreso;										
			_modo = Modo;
			_activo = Activo;
		}
		private string _keyTipo;
		public string KeyTipo 
		{
			get {return _keyTipo;}
		}

		private string _descripcionTipo;
		public string DescripcionTipo 
		{
			set {_descripcionTipo = value;}
			get {return _descripcionTipo;}
		}
		private string _descripcionSubTipo;
		public string DescripcionSubTipo 
		{
			set {_descripcionSubTipo = value;}
			get {return _descripcionSubTipo;}
		}
		private string _keySubTipo;
		public string KeySubTipo 
		{
			get {return _keySubTipo;}
		}
		private bool _esIngreso;
		public bool EsIngreso 
		{
			get {return _esIngreso;}
		}
		private string _modo;
		public string Modo 
		{
			set {_modo = value;}
			get {return _modo;}
		}
		private bool _activo;
		public bool Activo
		{
			set {_activo = value;}
			get {return _activo;}
		}

	}
}


