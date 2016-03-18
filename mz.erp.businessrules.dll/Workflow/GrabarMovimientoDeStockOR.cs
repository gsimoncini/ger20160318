using System;
using System.Data;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de GrabarMovimientoDeStockOR.
	/// </summary>
	public class GrabarMovimientoDeStockOR: IPersistentTask, ITask
	{
		#region Constructores
		
		public GrabarMovimientoDeStockOR()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region Variables Privadas
		
			private DataSet _dataMovimientosDeStockOR = new st_OrdenReparacionMovimientosDeStockDataset();
			private long _idOrdenReparacion = 0;
			private long _idInstanciaOrdenReparacion = 0;
			private string _signoAjuste = string.Empty;
			private DataSet _dataRepuestosOrdenReparacion = new st_RepuestoOrdenReparacionDataset();
			private RepuestosOrdenreparacion _repuestos = new RepuestosOrdenreparacion();
			private ArrayList _itemOrdenReparacion = new ArrayList();
			private ItemsComprobantes _items = null;
			private string _idsEstadoDeStock = string.Empty;

		#endregion
	
		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataMovimientosDeStockOR);
			data.Add( (DataSet) this._dataRepuestosOrdenReparacion);
			return data;
		}

		public void Commit()
		{
			foreach(Repuesto rep in _repuestos)
			{
				DataSet data = mz.erp.businessrules.st_RepuestoOrdenReparacion.GetList(long.MinValue, _repuestos.IdInstanciaOrdenReparacion, rep.IdProducto);
				foreach(DataRow row in data.Tables[0].Rows)
				{
					decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
					decimal entregado = Convert.ToDecimal(row["Entregado"]);
					decimal reservado = Convert.ToDecimal(row["Reservado"]);
					decimal aEntregar = cantidad - entregado - reservado ;
					if(!this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST")) 
					{
						bool ok = false;
						if(rep.CantidadReservada > 0 && reservado > 0)
						{
							if(rep.CantidadReservada > reservado)
							{
								entregado = entregado + reservado;
								row["Entregado"] = entregado;
								rep.CantidadEntregada = rep.CantidadEntregada - reservado;
								row["Reservado"] = 0;
								rep.CantidadReservada = rep.CantidadReservada - reservado;

							}
							else 
							{
								entregado = entregado + rep.CantidadReservada;
								row["Entregado"] = entregado;
								rep.CantidadEntregada = rep.CantidadEntregada - rep.CantidadReservada;
								row["Reservado"] = reservado - rep.CantidadReservada ;
								rep.CantidadReservada = 0;
							}
							ok = true;
						}
						if(aEntregar > 0 && rep.CantidadEntregada > 0)
						{
							if(rep.CantidadEntregada > aEntregar)
							{
								row["Entregado"] = entregado + aEntregar;
								rep.CantidadEntregada = rep.CantidadEntregada - aEntregar;
							}
							else
							{
								row["Entregado"] = entregado + rep.CantidadEntregada;
								rep.CantidadEntregada = 0;
							}
							ok = true;
						}
						if(ok)
							this._dataRepuestosOrdenReparacion.Tables[0].ImportRow(row);
						if(rep.CantidadReservada == 0 && rep.CantidadEntregada == 0)
							break;
					}
					else 
					{ //Devuelvo la mercadería
						if(entregado > 0 && rep.CantidadEntregada > 0)
						{							
							if(entregado <=  rep.CantidadEntregada )
							{
								row["Entregado"] = 0 ;
								rep.CantidadEntregada = rep.CantidadEntregada  - entregado;
							}
							else
							{
								row["Entregado"] = entregado - rep.CantidadEntregada;
								rep.CantidadEntregada  = 0;
							}
                            
							this._dataRepuestosOrdenReparacion.Tables[0].ImportRow(row);
							
							
						}
					}
					
						
				}

			}
		}

		public void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.Update(_dataMovimientosDeStockOR.Tables["st_OrdenReparacionMovimientosdestock"], IdTransaction);
			mz.erp.dataaccess.st_RepuestoOrdenReparacion.Update(_dataRepuestosOrdenReparacion.Tables["st_RepuestoOrdenReparacion"],IdTransaction);
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			if(_processParent.Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST"))
			{
			}
			/*
			{
				foreach (System.Data.DataSet undata in _collectionTask )
				{
					if (undata.DataSetName.Equals("tlg_MovimientosDeStockDataset"))
					{
						
						foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
						{
							
						}
					}
				}
			}
			*/
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
			if(!_processParent.Process.ProcessName.Equals("ProcesoRepararPrevender")&& !_processParent.Process.ProcessName.Equals("ProcesoRepararPreprestar")
				&& !_processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPrevender") &&  !_processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPreprestar"))
			{
				foreach( TaskCollectionData _collectionTask in _processCollectionData)
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{

						if (undata.DataSetName.Equals("tlg_MovimientosDeStockDataset"))
						{
							foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
							{
								string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
								st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow rowMSOR = ((st_OrdenReparacionMovimientosDeStockDataset)this._dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Newst_OrdenReparacionMovimientosDeStockRow();
								rowMSOR.IdOrdenReparacion = _idOrdenReparacion;
								rowMSOR.IdMovimientoDeStock = idMovimientoDeStock;
								rowMSOR.IdInstanciaOrdenReparacion = _idInstanciaOrdenReparacion;
								rowMSOR.FechaCreacion = Sistema.DateTime.Now;
								rowMSOR.IdConexionCreacion = Security.IdConexion;
								rowMSOR.IdConexionUltimaModificacion = Security.IdConexion;
								rowMSOR.IdEmpresa = Security.IdEmpresa;
								rowMSOR.IdSucursal = Security.IdSucursal;
								((st_OrdenReparacionMovimientosDeStockDataset)_dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Addst_OrdenReparacionMovimientosDeStockRow(rowMSOR);


							}
						}
					}
				}
			}
			if(_processParent.Process.ProcessName.Equals("ProcesoRepararPrevender") ||  _processParent.Process.ProcessName.Equals("ProcesoRepararPreprestar")||
				_processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPrevender") ||  _processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPreprestar"))
			{
				foreach( TaskCollectionData _collectionTask in _processCollectionData)
				{
					if(_collectionTask.TaskName.Equals("Prevender") || _collectionTask.TaskName.Equals("Preprestar"))
					{
						foreach (System.Data.DataSet undata in _collectionTask )
						{

							if (undata.DataSetName.Equals("tsa_ComprobantesExDataset"))
							{
								ArrayList estados = mz.erp.systemframework.Util.Parse(_idsEstadoDeStock,",");
								foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
								{
								
									string IdProducto = Convert.ToString(row["IdProducto"]);
									string IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
									if(estados.Contains(IdEstadoDeStock))
									{
										decimal Cantidad = Math.Abs(Convert.ToDecimal(row["Cantidad"]));
										foreach(ItemOR item in _itemOrdenReparacion)
										{
											if(item.IdProducto.Equals(IdProducto) && item.Cantidad > 0 && item.Cantidad <= Cantidad)
											{
												_idOrdenReparacion = item.IdOR;
												_idInstanciaOrdenReparacion = item.IdInstanciaOR;
												Cantidad = Cantidad - item.Cantidad;
												item.Cantidad = 0;
												string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
												st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow rowMSOR = ((st_OrdenReparacionMovimientosDeStockDataset)this._dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Newst_OrdenReparacionMovimientosDeStockRow();
												rowMSOR.IdOrdenReparacion = _idOrdenReparacion;
												rowMSOR.IdMovimientoDeStock = idMovimientoDeStock;
												rowMSOR.IdInstanciaOrdenReparacion = _idInstanciaOrdenReparacion;
												rowMSOR.FechaCreacion = Sistema.DateTime.Now;
												rowMSOR.IdConexionCreacion = Security.IdConexion;
												rowMSOR.IdConexionUltimaModificacion = Security.IdConexion;
												rowMSOR.IdEmpresa = Security.IdEmpresa;
												rowMSOR.IdSucursal = Security.IdSucursal;
												((st_OrdenReparacionMovimientosDeStockDataset)_dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Addst_OrdenReparacionMovimientosDeStockRow(rowMSOR);
												if(Cantidad == 0) break;
										
											}
											else
											{
												if(item.IdProducto.Equals(IdProducto) && item.Cantidad > 0 && item.Cantidad > Cantidad)
												{
													_idOrdenReparacion = item.IdOR;
													_idInstanciaOrdenReparacion = item.IdInstanciaOR;
													item.Cantidad = item.Cantidad - Cantidad;
													string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
													st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow rowMSOR = ((st_OrdenReparacionMovimientosDeStockDataset)this._dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Newst_OrdenReparacionMovimientosDeStockRow();
													rowMSOR.IdOrdenReparacion = _idOrdenReparacion;
													rowMSOR.IdMovimientoDeStock = idMovimientoDeStock;
													rowMSOR.IdInstanciaOrdenReparacion = _idInstanciaOrdenReparacion;
													rowMSOR.FechaCreacion = Sistema.DateTime.Now;
													rowMSOR.IdConexionCreacion = Security.IdConexion;
													rowMSOR.IdConexionUltimaModificacion = Security.IdConexion;
													rowMSOR.IdEmpresa = Security.IdEmpresa;
													rowMSOR.IdSucursal = Security.IdSucursal;
													((st_OrdenReparacionMovimientosDeStockDataset)_dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Addst_OrdenReparacionMovimientosDeStockRow(rowMSOR);
													break;

												}
											}
										}
									}
								

								}
							}
						}
					}
				}
			}
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.GetHasSaved
			return false;
		}

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

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionReparacionAjustes)))
			{
				SeleccionReparacionAjustes sra = (SeleccionReparacionAjustes)sender;
				_idOrdenReparacion =Convert.ToInt64(sra.IdOrdenReparacion);
				_repuestos.IdOrdenReparacion = _idOrdenReparacion;
				
			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarInstanciaOrdenReparacion)))
			{
				SeleccionarInstanciaOrdenReparacion sior = (SeleccionarInstanciaOrdenReparacion)sender;
				_idInstanciaOrdenReparacion = sior.IdInstanciaOrdenReparacion;
				_repuestos.IdInstanciaOrdenReparacion = _idInstanciaOrdenReparacion;

			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStock)))
			{
				
					AjustarStock ajuste= (AjustarStock)sender;
					if(ajuste.GetTaskName().Equals("AjustarStockOrigen"))
					{
						LoadFromAjustarStock(ajuste);
					}
				
				
			}
			

			if (sender.GetType() == typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta ))
			{
				mz.erp.businessrules.comprobantes.ComprobanteDeVenta comp = (mz.erp.businessrules.comprobantes.ComprobanteDeVenta) sender;
				_items = comp.Items;
				_itemOrdenReparacion.Clear();
				foreach(ItemComprobante item in _items)
				{
					if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen.Equals("OR"))
					{
						ItemOR itemOR = new ItemOR();
						itemOR.IdOR = Convert.ToInt64(item.IdComprobanteOrigen);
						itemOR.IdInstanciaOR = item.IdInstanciaOR;
						itemOR.IdProducto = item.IdProducto;
						itemOR.Ordinal = item.OrdinalOrigen;
						itemOR.Cantidad = item.Cantidad;
						_itemOrdenReparacion.Add(itemOR);
					}
					
				}
				if(_processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPrevender") ||  _processParent.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPreprestar"))
				{
					foreach(ItemComprobante item in _items.ItemsNoVisibles)
					{
						if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen.Equals("OR"))
						{
							ItemOR itemOR = new ItemOR();
							itemOR.IdOR = Convert.ToInt64(item.IdComprobanteOrigen);
							itemOR.IdInstanciaOR = item.IdInstanciaOR;
							itemOR.IdProducto = item.IdProducto;
							itemOR.Ordinal = item.OrdinalOrigen;
							itemOR.Cantidad = item.Cantidad;
							_itemOrdenReparacion.Add(itemOR);
						}
					
					}
				}
			}
		}

		private void LoadFromAjustarStock(AjustarStock ajuste)
		{
			_signoAjuste = ajuste.Signo;
			_repuestos.Clear();
			foreach(ItemAjuste item	in ajuste.Items)
			{
				Repuesto rep = new Repuesto();
				rep.IdProducto = item.IdProducto;
				rep.CantidadEntregada = item.Cantidad;
				rep.CantidadReservada = item.CantidadReservada;
				_repuestos.Add(rep);
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			_idsEstadoDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaEstadosDeStock");
		}


		public bool IsValid()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.IsValid
			return false;
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
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.AllowShow
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
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.GetWarnings
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
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.Previous
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerBeforePreviousDependentTask
		}

		#endregion
	}

	public sealed class ItemOR
	{

		private long _idOR;
		private long _idInstanciaOR;
		private string _idProducto = string.Empty;
		private decimal _cantidad = 0;
		private long _ordinal ;

		public long IdOR
		{
			get{return _idOR;}
			set{_idOR = value;}
		}

		public long IdInstanciaOR
		{
			get{return _idInstanciaOR;}
			set{_idInstanciaOR = value;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
			set{_idProducto = value;}
		}

		public decimal Cantidad
		{
			get{return _cantidad;}
			set{_cantidad = value;}
		}

		public long Ordinal
		{
			get{return _ordinal;}
			set{_ordinal = value;}
		}

	}
	
	
}
