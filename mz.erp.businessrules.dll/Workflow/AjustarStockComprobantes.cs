using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AjustarStockComprobantes.
	/// </summary>
	public class AjustarStockComprobantes: ITask, IPersistentTask
	{
		public AjustarStockComprobantes()
		{
		}

		#region Propiedades
	
		public Hashtable OrdenReparacionInstancias
		{
			get{return _ordenReparacionInstancias;}
		}

		public string EstadosDeStockNumerosDeSeries
		{
			get{return _estadosDeStockNumerosDeSeries;}
		}


		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;
	
		private bool _execute = false;
		private string _tiposDeComprobantes = string.Empty;
		private string _transicionesDeStock = string.Empty;
		private string _idAjusteDeStockOrigen = string.Empty;
		private string _idAjusteDeStockDestino = string.Empty;
		private Hashtable _transicionesPorComprobante = new Hashtable();
		private long _transicionActual = 0;
		//private ArrayList _idComprobanteORList = new ArrayList();
		private Hashtable _MovimientosPorOR = new Hashtable();
		private Hashtable _DataTableMovimientosPorOR = new Hashtable();
		private Hashtable _ordenReparacionInstancias = new Hashtable();
		private Hashtable _comprobantesOR = new Hashtable();
		private Hashtable _comprobanteDetalleOR = new Hashtable();
		private bool _soloEquiposNuevos = false;
		private bool _actualizaOR = false;
		/*
		private string _idComprobanteOR = string.Em6pty;
		private long _idInstanciaOrdenReparacion = 0;
		*/
		//private RepuestosOrdenreparacion _repuestos = new RepuestosOrdenreparacion();

		private Hashtable _repuestosOR = new Hashtable();

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private ComprobanteDeVenta _compVenta = null;
		private tlg_MovimientosDeStockDataset _data = new tlg_MovimientosDeStockDataset(); 
		private st_OrdenReparacionMovimientosDeStockDataset _dataMovimientosDeStockOR = new st_OrdenReparacionMovimientosDeStockDataset();
		//private tsa_ComprobantesOrdenReparacionDataset _dataComprobanteOR = new tsa_ComprobantesOrdenReparacionDataset();
		private st_OrdenReparacionDataset _dataOR = new st_OrdenReparacionDataset();
		//private tsa_ComprobanteDetalleOrdenReparacionDataset _dataComprobanteDetalleOR = new tsa_ComprobanteDetalleOrdenReparacionDataset();

		private string _estadosDeStockNumerosDeSeries = string.Empty;


		public void ListenerTaskDependentChanged(object sender)
		{
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta ))
			{
				_compVenta = (ComprobanteDeVenta)sender;
				ArrayList aux = new ArrayList();
				aux = mz.erp.systemframework.Util.Parse(_tiposDeComprobantes, ",");
				bool ok = false;
				_MovimientosPorOR.Clear();
				_DataTableMovimientosPorOR.Clear();
				_ordenReparacionInstancias.Clear();
				_comprobantesOR.Clear();
				_comprobanteDetalleOR.Clear();
				//_idComprobanteORList.Clear();
				_dataOR = new st_OrdenReparacionDataset();
				ok = aux.Contains(_compVenta.TipoComprobanteDestino);
				if(ok)
				{

					/*Cambiar esta linea por una q acceda a la por tsa_comprobantesdetauxiliares*/
					/*Version Anterior - German*/
					/*
					System.Data.DataSet data = Workflow.GetCaminoComprobantesBottonUp(_compVenta.IdComprobanteOrigen,string.Empty);
					if(data.Tables[0].Rows.Count > 0)
					{
							
						foreach(System.Data.DataRow row in data.Tables[0].Rows)
						{
							if(Convert.ToString(row["IdTipoDeComprobante"]).Equals("OR"))
							{
								long IdComprobanteOR = Convert.ToInt64(row["IdComprobante"]);
								long IdInstanciaOrdenReparacion = 0;
								DataRow rowOR = mz.erp.businessrules.st_OrdenReparacion.GetByPk(Convert.ToString(IdComprobanteOR));
								if(rowOR == null)
									this._execute = false;
								else
								{
									if(_soloEquiposNuevos)
										this._execute = Convert.ToBoolean(rowOR["EsEquipoNuevo"]);
									else this._execute = true;
								}
								if(this._execute)
								{
									
									if(_actualizaOR)
									{
										string EstadoOREN = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName ,"EstadoOrdenDeReparacion.EquipoNuevo");
										string EstadoOR = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName ,"EstadoOrdenDeReparacion.Default");
					
										if(Convert.ToBoolean(rowOR["EsEquipoNuevo"]))
										{
											if(EstadoOREN != null && EstadoOREN != string.Empty)
												rowOR["IdEstadoOrdenReparacion"] = EstadoOREN;
										}
										else
											if(EstadoOR != null && EstadoOR != string.Empty)
												rowOR["IdEstadoOrdenReparacion"] = EstadoOR;
										rowOR["NumeroFactura"] = System.DBNull.Value;
										rowOR["FechaFactura"]= System.DBNull.Value;
										rowOR["FechaPrefactura"]= System.DBNull.Value;
										_dataOR.st_OrdenReparacion.ImportRow(rowOR);
									}
									DataSet dataAux = mz.erp.businessrules.st_InstanciaOrdenReparacion.GetList(Convert.ToInt64(IdComprobanteOR));
									foreach(DataRow rowAux in dataAux.Tables[0].Rows)
									{
										IdInstanciaOrdenReparacion = Convert.ToInt64(rowAux["IdInstanciaOrdenReparacion"]);
										if(!_ordenReparacionInstancias.ContainsKey(IdComprobanteOR))
											_ordenReparacionInstancias.Add(IdComprobanteOR, new ArrayList());
										ArrayList instancias = (ArrayList)_ordenReparacionInstancias[IdComprobanteOR];
										instancias.Add(IdInstanciaOrdenReparacion);
									}
									if(this._execute)
									{
										tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = mz.erp.businessrules.tsa_ComprobantesOrdenReparacion.GetList(string.Empty, Convert.ToInt64(IdComprobanteOR));
										if(dataComprobanteOR.Tables[0].Rows.Count != 1)
											this._execute = false;
										if(this._execute)
										{
											tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = mz.erp.businessrules.tsa_ComprobanteDetalleOrdenReparacion.GetList(string.Empty,Convert.ToInt64( IdComprobanteOR), long.MinValue);										
											_comprobantesOR.Add(Convert.ToInt64(IdComprobanteOR), dataComprobanteOR);
											_comprobanteDetalleOR.Add(Convert.ToInt64(IdComprobanteOR), dataComprobanteDetalleOR);
										}


									}
									
								}
								
							}	
							
						}
					}
					*/
					
					_ordenReparacionInstancias = _compVenta.GetORAsociadas();
					if(_ordenReparacionInstancias.Count > 0)
					{
							
						foreach(long IdComprobanteOR in _ordenReparacionInstancias.Keys)
						{
								DataRow rowOR = mz.erp.businessrules.st_OrdenReparacion.GetByPk(Convert.ToString(IdComprobanteOR));
								if(rowOR == null)
									this._execute = false;
								else
								{
									if(_soloEquiposNuevos)
										this._execute = Convert.ToBoolean(rowOR["EsEquipoNuevo"]);
									else this._execute = true;
								}
								if(this._execute)
								{
									
									if(_actualizaOR)
									{
										string EstadoOREN = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName ,"EstadoOrdenDeReparacion.EquipoNuevo");
										string EstadoOR = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName ,"EstadoOrdenDeReparacion.Default");
					
										if(Convert.ToBoolean(rowOR["EsEquipoNuevo"]))
										{
											if(EstadoOREN != null && EstadoOREN != string.Empty)
												rowOR["IdEstadoOrdenReparacion"] = EstadoOREN;
										}
										else
											if(EstadoOR != null && EstadoOR != string.Empty)
											rowOR["IdEstadoOrdenReparacion"] = EstadoOR;
										rowOR["NumeroFactura"] = System.DBNull.Value;
										rowOR["FechaFactura"]= System.DBNull.Value;
										rowOR["FechaPrefactura"]= System.DBNull.Value;
                                        rowOR["IdComprobantePrefactura"] = System.DBNull.Value;
                                        rowOR["IdComprobanteFactura"] = System.DBNull.Value;
										_dataOR.st_OrdenReparacion.ImportRow(rowOR);
									}
									if(this._execute)
									{
										//tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = mz.erp.businessrules.tsa_ComprobantesOrdenReparacion.GetList(string.Empty, Convert.ToInt64(IdComprobanteOR));
										tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = mz.erp.businessrules.tsa_ComprobantesOrdenReparacion.GetListByIdOrdenReparacion(Convert.ToInt64(IdComprobanteOR));
										if(dataComprobanteOR.Tables[0].Rows.Count != 1)
											this._execute = false;
										if(this._execute)
										{
											//tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = mz.erp.businessrules.tsa_ComprobanteDetalleOrdenReparacion.GetList(null, Convert.ToInt64( IdComprobanteOR), long.MinValue);										
											tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = mz.erp.businessrules.tsa_ComprobanteDetalleOrdenReparacion.GetListByIdOrdenReparacion(Convert.ToInt64( IdComprobanteOR));										
											_comprobantesOR.Add(Convert.ToInt64(IdComprobanteOR), dataComprobanteOR);
											_comprobanteDetalleOR.Add(Convert.ToInt64(IdComprobanteOR), dataComprobanteDetalleOR);
										}


									}
									
								}
								
							
							
						}
					}
				}
						
				if(_transicionesPorComprobante.Contains(_compVenta.TipoComprobanteDestino))
				{
					this._transicionActual = Convert.ToInt64(_transicionesPorComprobante[_compVenta.TipoComprobanteDestino]);
				}
				else this._execute = false;
				if(this._execute)
				{
					GetRepuestos();
				}

			}
		}

		private void GetRepuestos()
		{
			
		
			_repuestosOR.Clear();
			
			
			foreach(long IdOrdenreparacion  in _ordenReparacionInstancias.Keys)
			{
				ArrayList instancias = (ArrayList)_ordenReparacionInstancias[IdOrdenreparacion];
				foreach(long IdIsntanciaOrdenReparacion in instancias)
				{
					
					RepuestosOrdenreparacion repuestos = new RepuestosOrdenreparacion(false);
					repuestos.IdOrdenReparacion = IdOrdenreparacion;
					repuestos.IdInstanciaOrdenReparacion = IdIsntanciaOrdenReparacion;
					
					/*Anterior - German */
					//DataSet dataRepuestos = mz.erp.businessrules.st_RepuestoOrdenReparacion.GetList(long.MinValue,repuestos.IdInstanciaOrdenReparacion, null);
					DataSet dataRepuestos = mz.erp.businessrules.st_RepuestoOrdenReparacion.GetListByIdInstanciaOrdenReparacion(repuestos.IdInstanciaOrdenReparacion);
					
					foreach(DataRow row in dataRepuestos.Tables[0].Rows)
					{
						Repuesto rep = new Repuesto();
						rep.IdProducto = Convert.ToString(row["IdProducto"]);
						rep.CantidadEntregada = Convert.ToDecimal(row["Entregado"]);
						rep.CantidadPedida = Convert.ToDecimal(row["Cantidad"]);
						rep.CantidadReservada = Convert.ToDecimal(row["Reservado"]);
						rep.IdRepuestoOrdenReparacion = Convert.ToInt64(row["IdRepuestoOrdenReparacion"]);
						if (rep.IdProducto != String.Empty) 
						{
							repuestos.Add(rep);
						}				
					}
					_repuestosOR.Add(repuestos.IdInstanciaOrdenReparacion,repuestos);
				}
				
				
			}
			
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{
			_tiposDeComprobantes = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ComprobantesAsociados");
			_soloEquiposNuevos = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AjustaSoloPorEquiposNuevos");
			_actualizaOR = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ActualizaOR");
			_transicionesDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "TransicionDeStockPorComprobante");
			_estadosDeStockNumerosDeSeries = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "EstadosDeStockNumerosDeSeries");
			_idAjusteDeStockOrigen = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdTipoDeAjusteOrigen");
			_idAjusteDeStockDestino = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdTipoDeAjusteDestino");
			string[] transPorComp = _transicionesDeStock.Split( ',');
			if (transPorComp.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<transPorComp.Length;i++)
				{
					string[] atupla = transPorComp[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!_transicionesPorComprobante.ContainsKey(atupla[0]))
							_transicionesPorComprobante.Add( atupla[0],atupla[1]);
					}
				}
			}
				
		}

		public bool IsValid()
		{
			
			return true;
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
			return false;
		}

		public void Previous()
		{
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
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
			data.Add( (DataSet) this._dataMovimientosDeStockOR);
			return data;
		}

		public void Commit()
		{
			/*Anterior - German*/
			/*
			if(_execute)
			{
				string _idDeposito = ComprobantesRules.TareaProceso_GetDeposito(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Deposito" );
				string _idSeccion =  ComprobantesRules.TareaProceso_GetSeccion(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Seccion" );
				long IdOR = 0;
				foreach(long IdOrdenreparacion  in _ordenReparacionInstancias.Keys)
				{
					ArrayList instancias = (ArrayList)_ordenReparacionInstancias[IdOrdenreparacion];
					foreach(long IdIsntanciaOrdenreparacion in instancias)
					{
						mz.erp.businessrules.GenerarMovimientosDeStock _movimientos = new GenerarMovimientosDeStock( _idDeposito, _idSeccion );
						string aux = Convert.ToString(IdOrdenreparacion) +":"+Convert.ToString(IdIsntanciaOrdenreparacion);
						_MovimientosPorOR.Add(aux, _movimientos);				
					}
				}
				string prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
				string prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
				ArrayList compPrevios = mz.erp.systemframework.Util.Parse(prefacturas, ",");
				compPrevios.AddRange(mz.erp.systemframework.Util.Parse(prefacturasDV, ","));
				
				foreach (ItemComprobante _item in _compVenta.Items.ItemsNoVisibles)
				{
					
					DataSet dataOR = Workflow.GetCaminoComprobantesOrdinalBottonUp(_item.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteOrigen, _item.OrdinalOrigen, "OR");
					IdOR = GetORAsociada(dataOR);
					long IdInsOR = GetInstanciaORAsociada(_item, IdOR);
					if(!IdInsOR.Equals(long.MinValue))
					{
						string aux = Convert.ToString(IdOR) +":"+Convert.ToString(IdInsOR);
						if(!IdOR.Equals(long.MinValue) && _comprobantesOR.Contains(IdOR))
						{
							if(_item.AfectaStock && !EstaReservado(_item, IdOR,IdInsOR))
							{
								if(_MovimientosPorOR.Contains(aux))
								{
									GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
									_movimientos.Add( _transicionActual, _item.IdProducto, _item.Cantidad );
								}
						
							}
							else
							{
								if(_item.AfectaStock && EstaReservado(_item, IdOR, IdInsOR))
								{
									if(_MovimientosPorOR.Contains(aux))
									{
							
										GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
										_movimientos.Add( Convert.ToInt64(2), _item.IdProducto, _item.Cantidad );
									}
								}
							}
							EliminarRepuesto(_item, IdOR, IdInsOR);
							
						}
					}


				
				}

				foreach (ItemComprobante _item in _compVenta.Items)
				{
					
					if(! _item.IdTipoProducto.Equals("E") && ! _item.IdTipoProducto.Equals("S"))
					{
						DataSet dataOR = Workflow.GetCaminoComprobantesOrdinalBottonUp(_item.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteOrigen, _item.OrdinalOrigen, "OR");
						IdOR = GetORAsociada(dataOR);
						long IdInsOR = GetInstanciaORAsociada(_item, IdOR);
						if(!IdInsOR.Equals(long.MinValue))
						{
							string aux = Convert.ToString(IdOR) +":"+Convert.ToString(IdInsOR);
							if(!IdOR.Equals(long.MinValue) && _comprobantesOR.Contains(IdOR))
							{
								if(_item.AfectaStock && !EstaReservado(_item, IdOR, IdInsOR))
								{
									if(_MovimientosPorOR.Contains(aux))
									{
										GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
										_movimientos.Add( _transicionActual, _item.IdProducto, _item.Cantidad );
									}
						
								}
								else
								{
									if(_item.AfectaStock && EstaReservado(_item, IdOR, IdInsOR))
									{
									
										if(_MovimientosPorOR.Contains(aux))
										{
											GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
											_movimientos.Add( Convert.ToInt64(2), _item.IdProducto, _item.Cantidad );
										}
									}
								}
								EliminarRepuesto(_item, IdOR, IdInsOR);
							
							}
						}
					}
				
				}


				foreach(string IdORIdInsOR in _MovimientosPorOR.Keys)
				{
					GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[IdORIdInsOR];
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = Stock.GetDataTableStock( _movimientos );
					_DataTableMovimientosPorOR.Add(IdORIdInsOR, _table);
				}

					
				foreach(long IdOrdenRep in _comprobantesOR.Keys)
				{
					tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = (tsa_ComprobantesOrdenReparacionDataset)_comprobantesOR[IdOrdenRep];
					dataComprobanteOR.Tables[0].Rows[0].Delete();
				}

				foreach(long IdOrdenRep in _comprobanteDetalleOR.Keys)
				{
                    tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = (tsa_ComprobanteDetalleOrdenReparacionDataset)_comprobanteDetalleOR[IdOrdenRep]	;
					foreach(DataRow rowCompDetOR in dataComprobanteDetalleOR.Tables[0].Rows)
					{
						rowCompDetOR.Delete();
					}
				}

				
			}
			*/

			if(_execute)
			{
				string _idDeposito = ComprobantesRules.TareaProceso_GetDeposito(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Deposito" );
				string _idSeccion =  ComprobantesRules.TareaProceso_GetSeccion(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Seccion" );
				long IdOR = 0;
				foreach(long IdOrdenreparacion  in _ordenReparacionInstancias.Keys)
				{
					ArrayList instancias = (ArrayList)_ordenReparacionInstancias[IdOrdenreparacion];
					foreach(long IdIsntanciaOrdenreparacion in instancias)
					{
						mz.erp.businessrules.GenerarMovimientosDeStock _movimientos = new GenerarMovimientosDeStock(_idDeposito, _idSeccion );
						string aux = Convert.ToString(IdOrdenreparacion) +":"+Convert.ToString(IdIsntanciaOrdenreparacion);
						_MovimientosPorOR.Add(aux, _movimientos);				
					}
				}
				string prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
				string prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
				ArrayList compPrevios = mz.erp.systemframework.Util.Parse(prefacturas, ",");
				compPrevios.AddRange(mz.erp.systemframework.Util.Parse(prefacturasDV, ","));
				
				foreach (ItemComprobante _item in _compVenta.Items.ItemsNoVisibles)
				{
					
					//DataSet dataOR = Workflow.GetCaminoComprobantesOrdinalBottonUp(_item.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteOrigen, _item.OrdinalOrigen, "OR");
					IdOR = _item.IdOrdenReparacion; //GetORAsociada(dataOR);
					long IdInsOR = _item.IdInstanciaOrdenReparacion;
					if(/*!IdInsOR.Equals(long.MinValue)*/ IdOR > 0 && IdInsOR > 0)
					{
						string aux = Convert.ToString(IdOR) +":"+Convert.ToString(IdInsOR);
						if(!IdOR.Equals(long.MinValue) && _comprobantesOR.Contains(IdOR))
						{
							if(_item.AfectaStock && !EstaReservado(_item, IdOR,IdInsOR))
							{
								if(_MovimientosPorOR.Contains(aux))
								{
									GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
									_movimientos.Add( _transicionActual, _item.IdProducto, _item.Cantidad, _idAjusteDeStockOrigen, _idAjusteDeStockDestino );
								}
						
							}
							else
							{
								if(_item.AfectaStock && EstaReservado(_item, IdOR, IdInsOR))
								{
									if(_MovimientosPorOR.Contains(aux))
									{
							
										GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
										_movimientos.Add( Convert.ToInt64(2), _item.IdProducto, _item.Cantidad, _idAjusteDeStockOrigen, _idAjusteDeStockDestino );
									}
								}
							}
							EliminarRepuesto(_item, IdOR, IdInsOR);
							
						}
					}


				
				}

				foreach (ItemComprobante _item in _compVenta.Items)
				{
					
					if(! _item.IdTipoProducto.Equals("E") && ! _item.IdTipoProducto.Equals("S"))
					{
						//DataSet dataOR = Workflow.GetCaminoComprobantesOrdinalBottonUp(_item.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteOrigen, _item.OrdinalOrigen, "OR");
						IdOR = _item.IdOrdenReparacion; //GetORAsociada(dataOR);
						long IdInsOR = _item.IdInstanciaOrdenReparacion;
						if(/*!IdInsOR.Equals(long.MinValue)*/ IdOR > 0 && IdInsOR > 0)
						{
							string aux = Convert.ToString(IdOR) +":"+Convert.ToString(IdInsOR);
							if(!IdOR.Equals(long.MinValue) && _comprobantesOR.Contains(IdOR))
							{
								if(_item.AfectaStock && !EstaReservado(_item, IdOR, IdInsOR))
								{
									if(_MovimientosPorOR.Contains(aux))
									{
										GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
										_movimientos.Add( _transicionActual, _item.IdProducto, _item.Cantidad, _idAjusteDeStockOrigen, _idAjusteDeStockDestino);
									}
						
								}
								else
								{
									if(_item.AfectaStock && EstaReservado(_item, IdOR, IdInsOR))
									{
									
										if(_MovimientosPorOR.Contains(aux))
										{
											GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[aux];
											_movimientos.Add( Convert.ToInt64(2), _item.IdProducto, _item.Cantidad, _idAjusteDeStockOrigen, _idAjusteDeStockDestino );
										}
									}
								}
								EliminarRepuesto(_item, IdOR, IdInsOR);
							
							}
						}
					}
				
				}


				foreach(string IdORIdInsOR in _MovimientosPorOR.Keys)
				{
					GenerarMovimientosDeStock _movimientos = (GenerarMovimientosDeStock)_MovimientosPorOR[IdORIdInsOR];
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = Stock.GetDataTableStock( _movimientos );
					_DataTableMovimientosPorOR.Add(IdORIdInsOR, _table);
				}

					
				foreach(long IdOrdenRep in _comprobantesOR.Keys)
				{
					tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = (tsa_ComprobantesOrdenReparacionDataset)_comprobantesOR[IdOrdenRep];
					dataComprobanteOR.Tables[0].Rows[0].Delete();
				}

				foreach(long IdOrdenRep in _comprobanteDetalleOR.Keys)
				{
					tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = (tsa_ComprobanteDetalleOrdenReparacionDataset)_comprobanteDetalleOR[IdOrdenRep]	;
					foreach(DataRow rowCompDetOR in dataComprobanteDetalleOR.Tables[0].Rows)
					{
						rowCompDetOR.Delete();
					}
				}

				
			}
			
		}

		private long GetORAsociada(DataSet data)
		{
			
			string prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
			string prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
			ArrayList compPrevios = mz.erp.systemframework.Util.Parse(prefacturas, ",");
			compPrevios.AddRange(mz.erp.systemframework.Util.Parse(prefacturasDV, ","));
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				if(IdTipoDeComprobante !=null && compPrevios.Contains(IdTipoDeComprobante))
				{
					string IdComprobante = Convert.ToString(row["IdComprobante"]);
					long Ordinal = Convert.ToInt64(row["Ordinal"]);
					DataSet dataAux = mz.erp.businessrules.st_OrdenReparacion.GetByComprobanteAsociado(IdComprobante, Ordinal);
					if(dataAux.Tables[0].Rows.Count == 1)
						return Convert.ToInt64(dataAux.Tables[0].Rows[0]["IdOrdenReparacion"]);

				}
			}	
			return long.MinValue;
		}

		
		private long GetInstanciaORAsociada(ItemComprobante item, long IdOrdenReparacion)
		{
			foreach(RepuestosOrdenreparacion repuestos in _repuestosOR.Values)
			{
				foreach(Repuesto rep in repuestos)
				{
					if(rep.IdProducto.Equals(item.IdProducto) && repuestos.IdOrdenReparacion.Equals(IdOrdenReparacion)
						&& item.CantidadUnidadOrigen.Equals(rep.CantidadEntregada + rep.CantidadReservada))
						return repuestos.IdInstanciaOrdenReparacion;
				}
			}
			return long.MinValue;
		}

		private void EliminarRepuesto(ItemComprobante item, long IdOrdenReparacion, long IdInstanciaOR)
		{
			RepuestosOrdenreparacion repuestos = (RepuestosOrdenreparacion)_repuestosOR[IdInstanciaOR];
			Repuesto aux = null;
			foreach(Repuesto rep in repuestos)
			{
				if(rep.IdProducto.Equals(item.IdProducto) && repuestos.IdOrdenReparacion.Equals(IdOrdenReparacion)
					&& item.CantidadUnidadOrigen.Equals(rep.CantidadEntregada + rep.CantidadReservada))
				{
					aux = rep;
					break;
				}
			}
			if(aux != null)
				repuestos.Remove(aux);
		}


		private bool EstaReservado(ItemComprobante item, long IdOrdenReparacion, long IdInstanciaOR)
		{
			RepuestosOrdenreparacion repuestos = (RepuestosOrdenreparacion)_repuestosOR[IdInstanciaOR];
			foreach(Repuesto rep in repuestos)
			{
				if(rep.IdProducto.Equals(item.IdProducto) && repuestos.IdOrdenReparacion.Equals(IdOrdenReparacion)
					&& item.CantidadUnidadOrigen.Equals(rep.CantidadEntregada + rep.CantidadReservada))
					return rep.CantidadReservada > 0;
			}
			return false;
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			
			if(_execute)
			{
				foreach(string IdORIdInsOR in _MovimientosPorOR.Keys)
				{
					string[] partes = IdORIdInsOR.Split( ':');
					long IdOR = Convert.ToInt64(partes[0]);
					long IdInstanciaOR = Convert.ToInt64(partes[1]);
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = (mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable)_DataTableMovimientosPorOR[IdORIdInsOR];
					this._data.tlg_MovimientosDeStock.Rows.Clear();
					foreach (System.Data.DataRow _row in _table.Rows )
					{
						this._data.tlg_MovimientosDeStock.Rows.Add( _row.ItemArray );

					}
					mz.erp.dataaccess.tlg_MovimientosDeStock.Update( _data.Tables[ "tlg_MovimientosDeStock"] , IdTransaction, this.GetSentenceReplication() );
					foreach( System.Data.DataRow _row in _data.Tables["tlg_MovimientosDeStock"].Rows )
					{
						string idMovimientoDeStock = Convert.ToString(_row["IdMovimientoDeStock"]);
						st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow rowMSOR = ((st_OrdenReparacionMovimientosDeStockDataset)this._dataMovimientosDeStockOR).st_OrdenReparacionMovimientosDeStock.Newst_OrdenReparacionMovimientosDeStockRow();
						rowMSOR.IdOrdenReparacion =IdOR;
						rowMSOR.IdMovimientoDeStock = idMovimientoDeStock;
						rowMSOR.IdInstanciaOrdenReparacion = IdInstanciaOR;
						rowMSOR.FechaCreacion = Sistema.DateTime.Now;
						rowMSOR.IdConexionCreacion = Security.IdConexion;
						rowMSOR.IdConexionUltimaModificacion = Security.IdConexion;
						rowMSOR.IdEmpresa = Security.IdEmpresa;
						rowMSOR.IdSucursal = Security.IdSucursal;
						_dataMovimientosDeStockOR.st_OrdenReparacionMovimientosDeStock.Addst_OrdenReparacionMovimientosDeStockRow(rowMSOR);
					}
					mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.Update( _dataMovimientosDeStockOR.Tables["st_OrdenReparacionMovimientosDeStock"], IdTransaction );
				}
			
				foreach(long IdOrdenRep in _comprobantesOR.Keys)
				{
					tsa_ComprobantesOrdenReparacionDataset dataComprobanteOR = (tsa_ComprobantesOrdenReparacionDataset)_comprobantesOR[IdOrdenRep];
					mz.erp.dataaccess.tsa_ComprobantesOrdenReparacion.Update(	dataComprobanteOR.Tables["tsa_ComprobantesOrdenReparacion"], IdTransaction);
				}

				foreach(long IdOrdenRep in _comprobanteDetalleOR.Keys)
				{
					tsa_ComprobanteDetalleOrdenReparacionDataset dataComprobanteDetalleOR = (tsa_ComprobanteDetalleOrdenReparacionDataset)_comprobanteDetalleOR[IdOrdenRep]	;
					mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.Update(dataComprobanteDetalleOR.Tables["tsa_ComprobanteDetalleOrdenReparacion"], IdTransaction);
				}
			
			
				mz.erp.dataaccess.st_OrdenReparacion.Update(_dataOR.st_OrdenReparacion, IdTransaction);

			}
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
			
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
						
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tlg_Stock";
			return replication;
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion
	}
}
