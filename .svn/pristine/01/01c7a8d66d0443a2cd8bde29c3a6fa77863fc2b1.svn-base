using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AnularComprobanteDeEntrega.
	/// </summary>
	public class AnularComprobanteDeEntrega: ITask, IPersistentTask
	{


		public AnularComprobanteDeEntrega()
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
			if (sender.GetType() == typeof(mz.erp.businessrules.ComprobantesPendientes))
			{
				ComprobantesPendientes comprobantes = (ComprobantesPendientes)sender;
				_idComprobantesAAnular = comprobantes.ArrayIdComprobantesPendientes;
			}
		}

		private void LoadFromObtenerComprobantesAsociados(ObtenerComprobantesAsociados oca)
		{
			switch(this._processManager.Process.ProcessName)
			{
				case	"ProcesoAnularPrevender": 
					if(oca.ListaIdComprobantesHaciaAdelante.Count > 0)	
						//_idComprobanteAAnular = Convert.ToString(oca.ListaIdComprobantesHaciaAdelante[0]); 
						_idComprobantesAAnular = oca.ListaIdComprobantesHaciaAdelante;
					break;
				case	"ProcesoPrevenderPrevender": 
					
					if(oca.ListaIdComprobantesHaciaAdelante.Count > 0)	
						//_idComprobanteAAnular = Convert.ToString(oca.ListaIdComprobantesHaciaAdelante[0]); break;
						_idComprobantesAAnular = oca.ListaIdComprobantesHaciaAdelante; break;
				case	"ProcesoEntregar":
				{
					Hashtable aux = oca.TableComprobantesHaciaAtrasAdelante;
					foreach(string IdTipoDeComp in aux.Keys)
					{
						if(_tableComprobantesAnulacion.ContainsKey(IdTipoDeComp))
						{
							//_idComprobanteAAnular = Convert.ToString(aux[IdTipoDeComp]); 
							_idComprobantesAAnular.Clear();
							_idComprobantesAAnular.Add(Convert.ToString(aux[IdTipoDeComp]));
							break;
						}
					}
					
				}	
					break;

				default: _idComprobantesAAnular.Clear();break;

			}
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

		private tsa_ComprobantesExDataset _dataComprobante;
		//string _idComprobanteAAnular = "";
		ArrayList _idComprobantesAAnular = new ArrayList();

		public void Commit()
		{
			_dataComprobante = new tsa_ComprobantesExDataset();			

			foreach(string _idComprobanteAAnular in _idComprobantesAAnular)
			{
				if(_idComprobanteAAnular != null && _idComprobanteAAnular != string.Empty )
				{

					tsa_ComprobantesDataset.tsa_ComprobantesRow rowAux = businessrules.tsa_Comprobantes.GetByPk(_idComprobanteAAnular);						
					if(rowAux != null)
					{
				
						string IdTipoDeComprobante = rowAux.IdTipoDeComprobante;
						if(_tableComprobantesAnulacion.ContainsKey(IdTipoDeComprobante))
						{
							string IdTipoDeComprobanteAnula = Convert.ToString(_tableComprobantesAnulacion[IdTipoDeComprobante]);
							tsa_ComprobantesDataset.tsa_ComprobantesRow rowC = mz.erp.businessrules.tsa_Comprobantes.GetByPk(_idComprobanteAAnular);			
							rowC.IdTipoDeComprobante = IdTipoDeComprobanteAnula;
							_dataComprobante.tsa_Comprobantes.ImportRow((DataRow) rowC);
							tsa_ComprobantesDetDataset  dataCD = mz.erp.businessrules.tsa_ComprobantesDet.GetByPk(_idComprobanteAAnular);
							foreach (DataRow row in dataCD.tsa_ComprobantesDet.Rows)
							{
								if (row != null) 
								{
									row["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
									_dataComprobante.tsa_ComprobantesDet.ImportRow(row);
								}
							}


							tsa_ComprobanteDetalleImpuestosDataset dataCDI = mz.erp.businessrules.tsa_ComprobanteDetalleImpuestos.GetList(_idComprobanteAAnular);
							foreach (DataRow row in dataCDI.tsa_ComprobanteDetalleImpuestos.Rows)
							{
								if (row != null) 
								{
									row["IdTipoDeComprobante"] = IdTipoDeComprobanteAnula;
									_dataComprobante.tsa_ComprobanteDetalleImpuestos.ImportRow(row);
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
			mz.erp.businessrules.tsa_ComprobantesEx.UpdateTipoDeComprobanteDeVenta(_dataComprobante, IdTransaction);	
			
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
						if (dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
						{
							DataTable table = dataset.Tables["tsa_Comprobantes"];
							DataRow row = table.Rows[0];
							idComprobante = (string)row["IdComprobante"];
							string pavada;
							
						}
					}
					System.Console.WriteLine( idComprobante );				 
				}				
			}*/
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación ActualizacionPreciosPorCambioCotizacion.GetHasSaved
			return false;
		}

		#endregion
	}
}
