using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de GrabarItemsComprobanteDeCompra.
	/// </summary>
	public class GrabarItemsComprobanteDeCompra
	{
		public GrabarItemsComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas

			private string _idComprobanteFactura = string.Empty;
			private string _idProveedor = string.Empty;
			private string _numeroFactura = string.Empty;
			private bool _existeFactura = false;
			private decimal _valorCotizacionFactura = 1;
			
			private tpu_ComprobantesDetDataset _dataDetComprobantePrevio = new tpu_ComprobantesDetDataset();
			private tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset _dataConfirmacionDet = new tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset();

			private tpu_ComprobantesDetDataset _dataComprobantesDet = new tpu_ComprobantesDetDataset();

		
		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public virtual bool AllowPrevious()
		{
			return true;
		}
		public  void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))	
			{
				comprobantes.ComprobanteDeCompra comprobante = (comprobantes.ComprobanteDeCompra) sender;
				LoadFromComprobanteDeCompra( comprobante);
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConfirmarPreciosProductosCompras)))	
			{
				ConfirmarPreciosProductosCompras ing = (ConfirmarPreciosProductosCompras) sender;
				LoadFromConfirmarPreciosProductosCompras( ing);
			}
		}

		private void LoadFromConfirmarPreciosProductosCompras(ConfirmarPreciosProductosCompras ing)
		{
			_numeroFactura = ing.NumeroFactura;
			_idProveedor = ing.IdProveedor;
			_idComprobanteFactura = ing.IdComprobanteFactura;
			_existeFactura = ing.ExisteFactura;
			_valorCotizacionFactura = ing.ValorCotizacionFactura;

		}

		private void LoadFromComprobanteDeCompra(comprobantes.ComprobanteDeCompra comp)
		{
			
			
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}
		

		public  bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		public virtual bool IsValid()
		{
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}



	
		public  void Init()
		{  	
			string Tarea = this.GetTaskName();
			string Proceso = this.GetProcessManagerParent().Process.ProcessName;
			
		}
		public  bool AllowShow()
		{			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public  ItemsDatasetErrors GetErrors()
		{
			
			return _errores;
		}

		public  string GetWarnings()
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
			data.TaskName = this.GetTaskName();
			
			return data;
		}

		public void Commit()
		{
			if(!_existeFactura)// Vuelvo a chaquear antes de guardar si existe la factura para eviitar problemas de concurrencia
			{
				DataSet data = mz.erp.businessrules.tpu_ComprobantesDeCompra.GetList( string.Empty, 
					string.Empty , _numeroFactura , DateTime.MinValue, _idProveedor, 
					string.Empty, DateTime.MinValue, string.Empty,string.Empty, DateTime.MinValue,
					long.MinValue, long.MinValue, string.Empty , string.Empty);
				if(data.Tables[0].Rows.Count  == 1)
				{
					DataRow row = data.Tables[0].Rows[0];
					_idComprobanteFactura = Convert.ToString("IdComprobante");
					_existeFactura = true;
				}
			}
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			FlushItems(IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		private void FlushItems(string IdTransaction)
		{
			
			if(_existeFactura)
			{
				//Caso1: los items ya existen, NO hay q modificarlos
				//Caso2: Faltan los items

				_dataComprobantesDet.Clear();
				foreach(DataRow rowD in _dataConfirmacionDet.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Rows)
				{
					DataRow row = _dataDetComprobantePrevio.tpu_ComprobantesDet.FindByIdComprobanteOrdinal(_idComprobanteFactura, Convert.ToInt64(rowD["Ordinal"]));
					if(row != null)
					{
						
						tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow rowDet = _dataComprobantesDet.tpu_ComprobantesDet.Newtpu_ComprobantesDetRow();
						rowDet.ItemArray = row.ItemArray;
						rowDet["IdComprobante"] = _idComprobanteFactura;
						rowDet["PrecioDeCostoMonedaOrigen"] = rowD["PrecioDeCostoOriginal"];
						rowDet["PrecioDeCosto"] = Convert.ToDecimal(rowD["PrecioDeCostoOriginal"]) * _valorCotizacionFactura;
						_dataComprobantesDet.tpu_ComprobantesDet.Addtpu_ComprobantesDetRow(rowDet);
					}
					
				}
				mz.erp.dataaccess.tpu_ComprobantesDet.Update( _dataComprobantesDet.tpu_ComprobantesDet, IdTransaction, _replication);
				/*
				foreach( FacturaDeCompraItem item in this._items)
				{
					tpu_ComprobantesDeCompraDetDataset.tpu_ComprobantesDeCompraDetRow row = _dataComprobantesDeCompraDet.tpu_ComprobantesDeCompraDet.Newtpu_ComprobantesDeCompraDetRow();
					row.IdComprobante = this._idComprobanteFactura;
					row.Ordinal = item.Ordinal;
					row.Cantidad = item.CantidadFactura;
					row.Precio = item.PrecioDeCostoFactura;
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.IdSucursal = Security.IdSucursal;
					row.IdEmpresa = Security.IdEmpresa;		
					_dataComprobantesDeCompraDet.tpu_ComprobantesDeCompraDet.Addtpu_ComprobantesDeCompraDetRow(row);			
				
				}
				*/
			}
		}

		

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación ConfirmarPreciosProductosCompras.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
		
			foreach( TaskCollectionData data in _processCollectionData )
			{
				if (data.TaskName.Equals("ConfirmarIngresoMercaderia"))
				{
					string idComprobante = string.Empty;
					string IdTipoDeComprobante = string.Empty;
				
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tpu_ComprobantesDetDataset"))
						{
							_dataDetComprobantePrevio = (tpu_ComprobantesDetDataset) dataset;
													
						}
					}
				}
				if (data.TaskName.Equals("ConfirmarPreciosProductosCompras"))
				{
					string idComprobante = string.Empty;
					string IdTipoDeComprobante = string.Empty;
				
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset"))
						{
							_dataConfirmacionDet = (tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset) dataset;
													
						}
					}
				}
				
			}
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
			// TODO: agregar la implementación ConfirmarPreciosProductosCompras.GetHasSaved
			return false;
		}

		#endregion



	}
}
