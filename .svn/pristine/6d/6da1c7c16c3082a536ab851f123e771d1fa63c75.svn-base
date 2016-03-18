
using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmTipoDeComprobante.
	/// </summary>
	public class AbmTipoDeComprobante:ITask,IPersistentTask
	{
		public AbmTipoDeComprobante()
		{

		}

		#region Variables Privadas

		private ProcessManager _processParent;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;

		private string _contenedoresVisibles = string.Empty;
		private string _contenedoresHabilitados = string.Empty;	
		private string _leyendaFormulario = "Tipos de Comprobantes";	
		//private string _perfilesSuperiores = string.Empty;
		//private string _perfil = string.Empty;
		private bool _perteneceAPerfilSuperior = false;

		//private TipoDeComprobante _tipoDeComprobante = new TipoDeComprobante();
		private TipoDeComprobante _tipoDeComprobanteSeleccionado;
		private ArrayList _tiposDeComprobantes;

		private tsy_TiposDeComprobantesDataset _dataTiposComprobantes = new mz.erp.commontypes.data.tsy_TiposDeComprobantesDataset();

		#endregion

		#region Propiedades

		/*public string IdTipoAjusteStock
		{
			get{return _tipoAjusteStock.IdTipoAjusteStock;}
			set 
			{
				_tipoAjusteStock.IdTipoAjusteStock = value;
			}
		}

		public string IdEstadoDeStock
		{
			get{return _tipoAjusteStock.IdEstadoDeStock;}
			set 
			{
				_tipoAjusteStock.IdEstadoDeStock = value;
			}
		}

		public string Descripcion
		{
			get{return _tipoAjusteStock.Descripcion;}
			set 
			{
				_tipoAjusteStock.Descripcion = value;
			}
		}

		public short Operacion
		{
			get {return _tipoAjusteStock.Operacion;}
			set
			{
				_tipoAjusteStock.Operacion = value;
			}
		}

		public bool Sistema
		{
			get{return _tipoAjusteStock.Sistema;}
			set 
			{
				_tipoAjusteStock.Sistema = value;
			}
		}

		public bool Activo
		{
			get{return _tipoAjusteStock.Activo;}
			set 
			{
				_tipoAjusteStock.Activo = value;
			}
		}*/

		public ArrayList TiposDeComprobantes
		{
			set
			{
				_tiposDeComprobantes = value;
			}
			get 
			{
				return _tiposDeComprobantes;
			}
		}

		public TipoDeComprobante TipoDeComprobanteSeleccionado
		{
			get{return _tipoDeComprobanteSeleccionado;}
			set 
			{
				_tipoDeComprobanteSeleccionado = value;
			}
		}

		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}

		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}

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

			string proceso = _processParent.Process.ProcessName;

			_contenedoresHabilitados= Variables.GetValueString(proceso, _taskName,"ContenedoresHabilitados");		
			_contenedoresVisibles = Variables.GetValueString(proceso, _taskName,"ContenedoresVisibles");

			_tiposDeComprobantes = tsy_TiposDeComprobantes.GetTiposDeComprobantes();
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = _taskName;
			data.Add(this._dataTiposComprobantes);
			return data;
		}


		public void Commit()
		{
			foreach (TipoDeComprobante comp in TiposDeComprobantes)
			{
				if (comp.Agregado)
				{
					tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = tsy_TiposDeComprobantes.GetByPk(comp.IdTipoComprobante);
					row.Descripcion = comp.Descripcion;
					row.Activo = comp.Activo;
					//row.AfectaCuentaCorriente = comp.AfectaCuentaCorriente;
					row.Familia = comp.Familia;
					row.Mascara = comp.Mascara;
					row.RequiereCondicionDeVenta = comp.RequiereCondicionDeVenta;
					row.signo = comp.Signo;
					row.SignoCtaCte = comp.SignoCuentaCorriente;
					row.TipoCtaCte = comp.TipoCuentaCorriente;

					_dataTiposComprobantes.tsy_TiposDeComprobantes.ImportRow(row);
				}
			}
		}

		public void Flush(string IdTransaction)
		{
			/*if (_state != BRTypes.ABMState.Consulta)
			{
				mz.erp.businessrules.tsh_Productos.Update( _rowProductos, IdTransaction, new SentenciasReplicacion() );
				_sentencia = GenerateReplication();
				PutErrorOnDataSet(_rowProductos);
			}*/

			mz.erp.dataaccess.tsy_TiposDeComprobantes.Update(_dataTiposComprobantes.tsy_TiposDeComprobantes, IdTransaction);
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

		private void ValidarDatos()
		{
			_errores.Clear();

			foreach (TipoDeComprobante comp in TiposDeComprobantes)
			{
				if (comp.Agregado)
				{
					tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = tsy_TiposDeComprobantes.GetByDescripcion(comp.Descripcion);
					if (row != null)
					{
						string id = row.IdTipoDeComprobante;
						if (!id.Equals(comp.IdTipoComprobante))
							_errores.Add( new ItemDatasetError( "Tipo de Comprobante","Descripcion","Descripción existente") );
					}
					if (comp.Descripcion.Equals(string.Empty))
					{
						_errores.Add( new ItemDatasetError( "Tipo de Comprobante","Descripcion","El campo no puede estar vacío") );
					}
				}
			}
		}
	}
}

