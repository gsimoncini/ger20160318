using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Collections;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AnularComprobanteDeEntrega.
	/// </summary>
	public class AnularComprobanteDeCompra: ITask, IPersistentTask
	{

		public AnularComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
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


		private string _idComprobante = string.Empty;
		private string _idTipoDeComprobante = string.Empty;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.ListenerTaskDependentChanged
		}

		System.Collections.ArrayList array;
		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof(mz.erp.businessrules.ObtenerComprobantesAsociados))
			{
				ObtenerComprobantesAsociados comprobantes = (ObtenerComprobantesAsociados)sender;
				LoadFromObtenerComprobantesAsociados(comprobantes);
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes))
			{
				SeleccionarComprobantesDeCompraPendientes comprobantes = (SeleccionarComprobantesDeCompraPendientes)sender;
				_idComprobantesAAnular = comprobantes.ArrayComprobantesPendientes;
			}
		}

		private void LoadFromObtenerComprobantesAsociados(ObtenerComprobantesAsociados oca)
		{
			
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.ListenerBeforeExecuteDependentTask
		}

		private Hashtable _tableComprobantesAnulacion = new Hashtable();

		public void Init()
		{
			string result = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "ListaComprobantesAnulacion");
			string[] tuplas = result.Split( ',');
			if (tuplas.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<tuplas.Length;i++)
				{
					string[] atupla = tuplas[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!_tableComprobantesAnulacion.ContainsKey(atupla[0]))
							_tableComprobantesAnulacion.Add(atupla[0], atupla[1]);
						
					}
				}
			}
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
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.IsValid
			return true;
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.AllowShow
			return false;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetErrors
			return _errores;
		}

		public string GetWarnings()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetWarnings
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetProcessManagerParent
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}

		public string GetTaskName()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetTaskName
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
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.AllowPrevious
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
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Miembros de IPersistentTask

		//private string _idCotizacion = string.Empty;

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( new DataSet());
			return data;
		}

		private tpu_ComprobantesDataset _dataComprobante;
		private tpu_ComprobantesDeCompraDataset _dataComprobanteDeCompra;
		private tpu_ComprobantesDetDataset _dataComprobantesDet;
		private tpu_ComprobantesDeCompraDetDataset _dataComprobanteDeCompraDet;
		private tpu_ComprobanteDetalleDeudaDataset _dataComprobanteDetalleDeuda;
		private tpu_ComprobanteDetalleDePagosDataset _dataComprobantesDetalleDePagos;

		//string _idComprobanteAAnular = "";
		ArrayList _idComprobantesAAnular = new ArrayList();

		public void Commit()
		{
			_dataComprobante = new tpu_ComprobantesDataset();			
			_dataComprobanteDeCompra = new tpu_ComprobantesDeCompraDataset();
			_dataComprobanteDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();
			_dataComprobantesDet = new tpu_ComprobantesDetDataset();
			_dataComprobantesDetalleDePagos = new tpu_ComprobanteDetalleDePagosDataset();

			foreach(string _idComprobanteAAnular in _idComprobantesAAnular)
			{
				if(_idComprobanteAAnular != null && _idComprobanteAAnular != string.Empty )
				{

					tpu_ComprobantesDataset.tpu_ComprobantesRow rowAux = businessrules.tpu_Comprobantes.GetByPk(_idComprobanteAAnular);						
					if(rowAux != null)
					{
				
						string IdTipoDeComprobante = rowAux.IdTipoDeComprobante;
						if(_tableComprobantesAnulacion.ContainsKey(IdTipoDeComprobante))
						{
							string IdTipoDeComprobanteAnula = Convert.ToString(_tableComprobantesAnulacion[IdTipoDeComprobante]);
							
							/*tpu_Comprobantes*/
							tpu_ComprobantesDataset.tpu_ComprobantesRow rowC = mz.erp.businessrules.tpu_Comprobantes.GetByPk(_idComprobanteAAnular);	
		                    rowC.IdTipoDeComprobante = IdTipoDeComprobanteAnula;
							_dataComprobante.tpu_Comprobantes.ImportRow((DataRow) rowC);

							/*tpu_ComprobantesDeCompra*/
							tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow rowCC = mz.erp.businessrules.tpu_ComprobantesDeCompra.GetByPk(_idComprobanteAAnular);
							if(rowCC != null)
							{
								rowCC["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
								_dataComprobanteDeCompra.tpu_ComprobantesDeCompra.ImportRow(rowCC);
							}

							/*tpu_ComprobantesDet*/
//							tpu_ComprobantesDetDataset  dataCD = mz.erp.businessrules.tpu_ComprobantesDet.GetByPk(_idComprobanteAAnular);
//							foreach (DataRow row in dataCD.tpu_ComprobantesDet.Rows)
//							{
//								if (row != null) 
//								{
//									row["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
//									_dataComprobantesDet.tpu_ComprobantesDet.ImportRow(row);
//								}
//							}

							
							
							/*tpu_ComprobanteDetalleDePagos*/
							tpu_ComprobanteDetalleDePagosDataset dataCDP = mz.erp.businessrules.tpu_ComprobanteDetalleDePagos.GetList( null, null, _idComprobanteAAnular, null, decimal.MinValue);
							foreach(DataRow row in dataCDP.tpu_ComprobanteDetalleDePagos.Rows)
							{
								if (row != null) 
								{
									row["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
									_dataComprobantesDetalleDePagos.tpu_ComprobanteDetalleDePagos.ImportRow(row);
								}
							}


							/*tpu_ComprobanteDetalleDeuda*/
							//tpu_ComprobanteDetalleDeudaDataset dataCDD = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetList(_idComprobanteAAnular, null, null);
							DataSet dataCDD = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetList(_idComprobanteAAnular, null, null);
                            foreach(DataRow row in dataCDD.Tables[0].Rows) //foreach(DataRow row in dataCDD.tpu_ComprobanteDetalleDeuda.Rows)
							{
								if (row != null) 
								{
									row["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
									_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(row);
								}
							}



						}
					}
				}
			}
			
		}		

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			mz.erp.dataaccess.tpu_Comprobantes.Update(_dataComprobante.tpu_Comprobantes, IdTransaction, _replication);
			mz.erp.dataaccess.tpu_ComprobantesDeCompra.Update(_dataComprobanteDeCompra.tpu_ComprobantesDeCompra, IdTransaction);
			mz.erp.dataaccess.tpu_ComprobantesDet.Update(_dataComprobantesDet.tpu_ComprobantesDet, IdTransaction, _replication);
			mz.erp.dataaccess.tpu_ComprobanteDetalleDePagos.Update(_dataComprobantesDetalleDePagos.tpu_ComprobanteDetalleDePagos, IdTransaction);
			mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update(_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda, IdTransaction, _replication);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{

			/*foreach( TaskCollectionData data in _processCollectionData )
			{
				if (data.TaskName.Equals("Vender") || data.TaskName.Equals("VenderManual") || data.TaskName.Equals("Prestar") || data.TaskName.Equals("Prevender"))
				{
					string idComprobante=string.Empty;
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tpu_ComprobantesExDataset"))
						{
							DataTable table = dataset.Tables["tpu_Comprobantes"];
							DataRow row = table.Rows[0];
							idComprobante = (string)row["IdComprobante"];
							string pavada;
							
						}
					}
					System.Console.WriteLine( idComprobante );				 
				}				
			}*/
		}
		private mz.erp.commontypes.SentenciasReplicacion _replication;


		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdEmpresa;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_Comprobantes";
			_replication = replication;
			return replication;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetHasSaved
			return false;
		}

		#endregion
	}
}
