using System;
using System.Data;
//Sabrina: Tarea 1068. 20110317
using mz.erp.commontypes.data;
//Fin Sabrina: Tarea 1068. 20110317
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripci�n breve de ActualizacionPreciosPorCambioCotizacion.
	/// </summary>
	public class ActualizacionPreciosPorCambioCotizacion: ITask, IPersistentTask
	{
		public ActualizacionPreciosPorCambioCotizacion()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}
		#region Miembros de ITask

		private ProcessManager _processManager;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.ListenerAfterExecuteDependentTask
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.Init
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.IsValid
			return true;
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.AllowShow
			return false;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetErrors
			return _errores;
		}

		public string GetWarnings()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetWarnings
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetProcessManagerParent
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}

		public string GetTaskName()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetTaskName
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
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.AllowPrevious
			return false;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Miembros de IPersistentTask

		private string _idCotizacion = string.Empty;

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( new DataSet());
			return data;
		}

		public void Commit()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.Commit
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			mz.erp.businessrules.tsh_Productos.UpdatePrecios(IdTransaction, _idCotizacion);
            //Sabrina: Tarea 1068. 20110317
            tsh_ProductosDataset.tsh_ProductosDataTable tableProdEnCombos = tsh_Productos.GetProductosEnCombo(IdTransaction).tsh_Productos;
            foreach (tsh_ProductosDataset.tsh_ProductosRow rowP in tableProdEnCombos.Rows)
            {
                tsh_CombosDet.ActualizarPreciosProductosCombo(IdTransaction, rowP.IdProducto, rowP.PrecioDeCostoRef, rowP.PrecioDeVentaBruto, rowP.IdMonedaCierrePrecioDeCostoRef, rowP.IdMonedaCierrePrecioDeVentaBruto, rowP.IdCotizacionCierrePrecioDeCostoRef, rowP.IdCotizacionCierrePrecioDeVentaBruto);
            }
            //Fin Sabrina: Tarea 1068. 20110317

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				if (_collectionTask.TaskName.Equals("ABMCotizacionMoneda"))  
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{
						if (undata.DataSetName.Equals("tfi_CotizacionesMonedasDataset"))
						{
							_idCotizacion = Convert.ToString(undata.Tables["tfi_CotizacionesMonedas"].Rows[0]["IdCotizacionMoneda"]);
						}
					}
				}
			}
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementaci�n ActualizacionPreciosPorCambioCotizacion.GetHasSaved
			return false;
		}

		#endregion
	}
}
