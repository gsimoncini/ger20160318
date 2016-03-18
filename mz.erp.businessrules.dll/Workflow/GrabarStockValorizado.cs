using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de GrabarStockValorizado.
	/// </summary>
	public class GrabarStockValorizado:ITask, IPersistentTask
	{
		public GrabarStockValorizado()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		#region Variables Privadas

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;	
		private tfi_ValorizacionStockDataset _data = new mz.erp.commontypes.data.tfi_ValorizacionStockDataset();
		private DataTable _table = new DataTable();

		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación GrabarStockValorizado.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultaCompras)))	
			{
				ConsultaCompras con = (ConsultaCompras) sender;
				_table = con.Result;
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarStockValorizado.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación GrabarStockValorizado.Init
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			return IsValid;
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

		public bool AllowShow()
		{
			// TODO: agregar la implementación GrabarStockValorizado.AllowShow
			return false;
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


		public bool AllowPrevious()
		{
			
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarStockValorizado.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarStockValorizado.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._data);
			return data;
		}

		public void Commit()
		{
			DateTime fecha = DateTime.Now;
			foreach(DataRow row in _table.Rows)
			{
				tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow rowVal = _data.tfi_ValorizacionStock.Newtfi_ValorizacionStockRow();
				rowVal.IdValorizacionStock = mz.erp.systemframework.Util.NewStringId(); 
				rowVal.Fecha = fecha;
				rowVal.IdProducto = Convert.ToString(row["IdProducto"]);
				rowVal.IdDeposito = Convert.ToString(row["IdDeposito"]);
				rowVal.IdSeccion = Convert.ToString(row["IdSeccion"]);
				rowVal.IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
				rowVal.Cantidad = Convert.ToDecimal(row["Cantidad"]);
				rowVal.Costo = Convert.ToDecimal(row["PrecioDeCostoMonedaVisualizacion"]);
				rowVal.FechaCreacion = DateTime.Now;
				rowVal.IdConexionCreacion = Security.IdConexion;
				//rowVal.UltimaModificacion = null;
				rowVal.IdConexionUltimaModificacion = Security.IdConexion;
				rowVal.IdReservado = 0;
				rowVal.RowId = Guid.Empty;
				rowVal.IdSucursal = Security.IdSucursal;
				rowVal.IdEmpresa = Security.IdEmpresa;
				_data.tfi_ValorizacionStock.Addtfi_ValorizacionStockRow(rowVal);
			}
		}

		public void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.tfi_ValorizacionStock.Update(_data.tfi_ValorizacionStock, IdTransaction);
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación GrabarStockValorizado.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación GrabarStockValorizado.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tfi_ValorizacionStock";
			return replication;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación GrabarStockValorizado.GetHasSaved
			return false;
		}

		#endregion
	}
}
