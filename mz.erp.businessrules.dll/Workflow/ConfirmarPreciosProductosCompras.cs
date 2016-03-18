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
	/// Descripción breve de ConfirmarPreciosProductosCompras.
	/// </summary>
	public class ConfirmarPreciosProductosCompras: ITask, IPersistentTask
	{
		public ConfirmarPreciosProductosCompras()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas
		
			private FacturaDeCompraItems _factura = new FacturaDeCompraItems();
			private comprobantes.ItemsComprobantesCompra _itemsComprobantesDeCompra;

			private bool _allowEditEstados = false;
			private string _tiposDeArticulosAdicionales = string.Empty;
			private ArrayList _tiposDeArticulosAdicionalesList = new ArrayList();
			
		
		#endregion

		#region Variables publicas

		public bool AllowEditEstados
		{
			get{return _allowEditEstados;}
		}

		public string IdComprobanteFactura
		{
			get{return _factura.IdComprobanteFactura;}
		}


		public bool ExisteFactura
		{
			get{return _factura.ExisteFactura;}
		}

		public ArrayList Estados
		{
			get{return _factura.Estados;}
		}

		public ArrayList Items
		{
			get{return _factura.Items;}
		}

		public string IdProveedor
		{
			get{return _factura.IdProveedor;}
			set{_factura.IdProveedor = value;}
		}

		public DateTime FechaFactura
		{
			get{return _factura.FechaFactura;}
			set{ _factura.FechaFactura = value;}
		}

		public string NumeroFactura
		{
			get{return _factura.NumeroFactura;}
			set{_factura.NumeroFactura = value;}
		}

		public decimal ValorCotizacionFactura
		{
			get{return _factura.ValorCotizacionFactura;}
			set{_factura.ValorCotizacionFactura = value;}
		}

		public string IdFuenteDeCambioFactura
		{
			get{return _factura.IdFuenteDeCambioFactura;}
			set{_factura.IdFuenteDeCambioFactura = value;}
		}

		public string IdMonedaFactura
		{
			get{return _factura.IdMonedaFactura;}
			set{_factura.IdMonedaFactura = value;}
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
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

		private bool _previous = false;

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			_previous = true;
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
			/*
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.IngresarPrecioProducto)))	
			{
				IngresarPrecioProducto ing = (IngresarPrecioProducto) sender;
				LoadFromIngresarPrecioProducto( ing);
			}
			*/
		}

		private void LoadFromIngresarPrecioProducto(IngresarPrecioProducto ing)
		{
           
		}
		private ArrayList GetListaIdComprobantesOrigen(ComprobanteDeCompra comp)
		{
			ArrayList result = new ArrayList();
			foreach(ItemComprobanteCompra item in comp.Items)
			{
				if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
				{
					if(!result.Contains(item.IdComprobanteOrigen))
						result.Add(item.IdComprobanteOrigen);
				}
			}
			return result;
		}

		private void LoadFromComprobanteDeCompra(comprobantes.ComprobanteDeCompra comp)
		{
			ArrayList ListaIdComprobantesOrigen = GetListaIdComprobantesOrigen(comp);
			OrdenesDeComprasItems itemsOrdenesDeCompras = new OrdenesDeComprasItems();
			itemsOrdenesDeCompras.LoadItems(ListaIdComprobantesOrigen);
			foreach(ItemComprobanteCompra item in comp.Items)
			{
				item.OrdenCompraItem = itemsOrdenesDeCompras.GetItem(item.IdComprobanteOrigen, item.OrdinalOrigen);
			}
			_factura.LoadFromComprobanteDeCompra(comp);
			_itemsComprobantesDeCompra = comp.Items;
			_factura.LoadItemsFromItemsComprobanteDeCompra(_itemsComprobantesDeCompra, _tiposDeArticulosAdicionalesList);
			
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
			_errores.Clear();
			bool isvalid = ValidarEstados();
			return isvalid;
			
		}

		private bool ValidarEstados()
		{
			bool isvalid = true;
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarEstados");
			if(ok)
			{
				foreach( FacturaDeCompraItem item in this._factura.Items)
				{
					if(item.TieneDiferenciaPorPrecio || item.TieneDiferenciaPorCotizacion || item.TieneDiferenciaPorCantidad)
					{
						string text = item.TieneDiferenciaPorCantidad?"Tiene diferencia por Cantidad":item.TieneDiferenciaPorPrecio?"Tiene Diferencia de Precios":"Tiene Diferencia de Cotización";
						if(item.Estado.Equals("T") || item.Estado.Equals("P"))
						{
							isvalid = false;
							_errores.Add( new ItemDatasetError( "Estado Incorrecto","Estado Incorrecto",
								"El Producto " + item.Codigo + " " + text + ". Por ende no puede estar en Pendiente o Terminado. Seleccione el Estado correcto") );
						}
					}
				
				}
			}
			return isvalid;

		}


	
		public  void Init()
		{  	
			string Tarea = this.GetTaskName();
			string Proceso = this.GetProcessManagerParent().Process.ProcessName;
			_allowEditEstados = Variables.GetValueBool(Proceso, Tarea, "PermiteEditarEstados");
			_factura.EstadoItemsChanged +=new EventHandler(_factura_EstadoItemsChanged);
			_tiposDeArticulosAdicionales = Variables.GetValueString("Compras.Facturas.TiposDeArticulosAdicionales");
			_tiposDeArticulosAdicionalesList = mz.erp.systemframework.Util.Parse( _tiposDeArticulosAdicionales);
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
			data.Add(_factura.DataCabecera);
			data.Add(_factura.DataDetalle);
			return data;
		}

		public void Commit()
		{
			_factura.Commit();
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update(_factura.DataCabecera.Tables[0], IdTransaction);
			mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Update(_factura.DataDetalle.Tables[0], IdTransaction);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
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
					{
						foreach( DataSet dataset in data )
						{
							if (dataset.DataSetName.Equals("tpu_ComprobantesDataset"))
							{
								DataTable table = dataset.Tables["tpu_Comprobantes"];
								DataRow row = table.Rows[0];
								idComprobante = (string)row["IdComprobante"];
								IdTipoDeComprobante = (string)row["IdTipoDeComprobante"];
								if(_factura.DataCabecera.Tables.Count > 0)
								{
									if(_factura.DataCabecera.Tables[0].Rows.Count > 0)
									{
										_factura.DataCabecera.Tables[0].Rows[0]["IdComprobante"] = idComprobante;
										_factura.DataCabecera.Tables[0].Rows[0]["IdTipoDeComprobante"] = IdTipoDeComprobante;
										foreach(DataRow rowDet in _factura.DataDetalle.Tables[0].Rows)
										{
											rowDet["IdComprobante"] = idComprobante;
										}
									}
								}
							
							
							}
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

		public event EventHandler EstadoItemsChanged;

		private void _factura_EstadoItemsChanged(object sender, EventArgs e)
		{
			if(EstadoItemsChanged != null)
				EstadoItemsChanged(this, new EventArgs());
		}	
	}

	public class FacturaDeCompraItems
	{
		private ArrayList _items = new ArrayList();
		private ArrayList _estados = new ArrayList();
		
		private string _idComprobanteFactura = string.Empty;
		private string _idMonedaFactura = string.Empty;
		private string _idFuenteDeCambioFactura = string.Empty;
		private decimal _valorCotizacionFactura = 1;
		private string _idProveedor = string.Empty;
		private string _numeroFactura = "A--";
		private DateTime _fechaFactura = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _observaciones = string.Empty;
		private bool _existeFactura = false;
		private string _idComprobante = string.Empty;
		private Hashtable _transiciones = new Hashtable();

		//private string _estado = "P";
		private string _flushState = "ADD";

		

		private tpu_ComprobantesDeCompraConfirmacionDePreciosDataset _dataCabecera = new tpu_ComprobantesDeCompraConfirmacionDePreciosDataset();
		private tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset _dataDetalle = new tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset();
		private tpu_ComprobantesDeCompraDetDataset _dataComprobantesDeCompraDet = new tpu_ComprobantesDeCompraDetDataset();
		public tpu_ComprobantesDeCompraConfirmacionDePreciosDataset DataCabecera
		{
			get{return _dataCabecera;}
		}

		
		public tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset DataDetalle
		{
			get{return _dataDetalle;}
		}

		public void Commit()
		{
			CommitCabecera();
			CommitDetalle();
			
		}

		public string GetEstado()
		{
			string estado = "P";
			bool pendiente = false;
			foreach(FacturaDeCompraItem item in this._items)
			{
				if(!item.Estado.Equals("T"))
					pendiente = true;
			}
			if(!pendiente) estado = "T";
			return estado;
		}

		public void SetEstadoItemsSegunTransiciones()
		{
			foreach( FacturaDeCompraItem item in this._items)
			{
				if(_transiciones.ContainsKey(item.Estado))
				{
					item.Estado = Convert.ToString(_transiciones[item.Estado]);
				}
			}
		}

		public void SetTransicionesDeEstados(string transiciones)
		{
			string[] tras = transiciones.Split( ',');
			if (tras.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<tras.Length;i++)
				{
					string[] atupla = tras[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!_transiciones.ContainsKey(atupla[0]))
							_transiciones.Add( atupla[0],atupla[1]);
					}
				}
			}
		}
		


		private void CommitCabecera()
		{
			_dataCabecera.Clear();
			if(_flushState.Equals("ADD"))
			{
				tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row = _dataCabecera.tpu_ComprobantesDeCompraConfirmacionDePrecios.Newtpu_ComprobantesDeCompraConfirmacionDePreciosRow();
				mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.SetRowDefaultValues(row);
				row.Estado = this.GetEstado();
				row.IdAutorizacion = string.Empty;
				row.IdComprobanteFactura = this._idComprobanteFactura;
				row.IdFuenteDeCambioOriginal = this._idFuenteDeCambioFactura;
				row.IdMonedaOriginal = this._idMonedaFactura;
				row.IdProveedor = this._idProveedor;
				row.IdResponsable = Security.IdPersona;
				row.NumeroFactura = this._numeroFactura;
				row.Observaciones = this._observaciones;
				row.ValorCotizacionOriginal = this._valorCotizacionFactura;
				_dataCabecera.tpu_ComprobantesDeCompraConfirmacionDePrecios.Addtpu_ComprobantesDeCompraConfirmacionDePreciosRow(row);
			}
			else
			{
				tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow rowC = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetByPk(this._idComprobante);
				rowC.Estado = this.GetEstado();
				rowC.IdAutorizacion = string.Empty;
				rowC.IdComprobanteFactura = this._idComprobanteFactura;
				rowC.IdFuenteDeCambioOriginal = this._idFuenteDeCambioFactura;
				rowC.IdMonedaOriginal = this._idMonedaFactura;
				rowC.IdProveedor = this._idProveedor;
				rowC.IdResponsable = Security.IdPersona;
				rowC.NumeroFactura = this._numeroFactura;
				rowC.Observaciones = this._observaciones;
				rowC.ValorCotizacionOriginal = this._valorCotizacionFactura;
				_dataCabecera.Tables[0].ImportRow(rowC);
			}

		}

		private void CommitDetalle()
		{
			_dataDetalle.Clear();
			if(_flushState.Equals("ADD"))
			{

				foreach( FacturaDeCompraItem item in this._items)
				{
					tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row = _dataDetalle.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Newtpu_ComprobantesDeCompraDetConfirmacionDePreciosRow();
					mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.SetRowDefaultValues(row);
					row.CantidadOrdenDeCompra = item.CantidadOrdenDeCompra;
					row.CantidadFactura = item.CantidadFactura;
					row.CantidadReal = item.CantidadReal;
					row.IdComprobanteOrdenDeCompra = item.IdComprobanteOrdenDeCompra;
					row.IdFuenteDeCambio = item.IdFuenteDeCambioOrdenDeCompra;
					row.IdMoneda = item.IdMonedaOrdenDeCompra;
					row.IdMotivoDiferencia = item.IdMotivoDiferencia;
					row.IdProducto = item.IdProducto;
					row.Observaciones = item.Observaciones;
					row.OrdinalOrdenDeCompra = item.OrdinalOrdenDeCompra;
					row.Ordinal = item.Ordinal;
					row.PrecioDeCostoOrdenDeCompra = item.PrecioDeCostoOrdenDeCompra;
					row.PrecioDeCostoFactura = item.PrecioDeCostoFactura;
					row.PrecioDeCostoReal = item.PrecioDeCostoReal;
					row.ValorCotizacion = item.ValorCotizacionOrdenDeCompra;
					row.Estado = item.Estado;
					row.TieneDiferenciaPorCantidad = item.TieneDiferenciaPorCantidad;
					row.TieneDiferenciaPorPrecio = item.TieneDiferenciaPorPrecio;
					row.TieneDiferenciaPorCotizacion = item.TieneDiferenciaPorCotizacion;
					_dataDetalle.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Addtpu_ComprobantesDeCompraDetConfirmacionDePreciosRow(row);
				}
			}
			else
			{
				foreach( FacturaDeCompraItem item in this._items)
				{
					tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( _idComprobante, item.Ordinal );
					row.CantidadOrdenDeCompra = item.CantidadOrdenDeCompra;
					row.CantidadFactura = item.CantidadFactura;
					row.CantidadReal = item.CantidadReal;
					row.IdComprobanteOrdenDeCompra = item.IdComprobanteOrdenDeCompra;
					row.IdFuenteDeCambio = item.IdFuenteDeCambioOrdenDeCompra;
					row.IdMoneda = item.IdMonedaOrdenDeCompra;
					row.IdMotivoDiferencia = item.IdMotivoDiferencia;
					row.IdProducto = item.IdProducto;
					row.Observaciones = item.Observaciones;
					row.OrdinalOrdenDeCompra = item.OrdinalOrdenDeCompra;
					row.Ordinal = item.Ordinal;
					row.PrecioDeCostoOrdenDeCompra = item.PrecioDeCostoOrdenDeCompra;
					row.PrecioDeCostoFactura = item.PrecioDeCostoFactura;
					row.PrecioDeCostoReal = item.PrecioDeCostoReal;
					row.ValorCotizacion = item.ValorCotizacionOrdenDeCompra;
					row.Estado = item.Estado;
					row.TieneDiferenciaPorCantidad = item.TieneDiferenciaPorCantidad;
					row.TieneDiferenciaPorPrecio = item.TieneDiferenciaPorPrecio;
					row.TieneDiferenciaPorCotizacion = item.TieneDiferenciaPorCotizacion;
					_dataDetalle.Tables[0].ImportRow(row);
				}
			}
		}

		public FacturaDeCompraItems()
		{
			_idMonedaFactura = ComprobantesRules.Contabilidad_MonedaReferencia;
			_idFuenteDeCambioFactura = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
			EstadoConfirmacionDePrecios e1 = new EstadoConfirmacionDePrecios("P", "Pendiente");
			EstadoConfirmacionDePrecios e2 = new EstadoConfirmacionDePrecios("T", "Teminado");
			EstadoConfirmacionDePrecios e3 = new EstadoConfirmacionDePrecios("RPND", "Requiere PND");
			EstadoConfirmacionDePrecios e4 = new EstadoConfirmacionDePrecios("RPNC", "Requiere PNC");
			_estados.Add(e1);
			_estados.Add(e2);
			_estados.Add(e3);
			_estados.Add(e4);
		}

		private void Load(DataSet data)
		{
			if(data.Tables[0].Rows.Count == 1)
			{
				DataRow rowC = data.Tables[0].Rows[0];
				_existeFactura = true;
				_idComprobanteFactura = IdComprobanteFactura;
				_idFuenteDeCambioFactura = Convert.ToString(rowC["IdFuenteDeCambioOriginal"]);
				_idMonedaFactura = Convert.ToString(rowC["IdMonedaOriginal"]);
				_idProveedor = Convert.ToString(rowC["IdProveedor"]);
				_numeroFactura = Convert.ToString(rowC["NumeroFactura"]);
				_observaciones = Convert.ToString(rowC["Observaciones"]);
				_valorCotizacionFactura = Convert.ToDecimal(rowC["ValorCotizacionOriginal"]);
				_idComprobante = Convert.ToString(rowC["IdComprobante"]);
				
				
				DataSet dataD = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetList( _idComprobante, null, long.MinValue);
				foreach(DataRow rowD in dataD.Tables[0].Rows)
				{
				
					//DataRow rowD = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( _idComprobante, ror.OrdinalOrigen );
					FacturaDeCompraItem itemFA =new FacturaDeCompraItem();
					itemFA.CantidadFactura = Convert.ToDecimal(rowD["CantidadFactura"]);
					itemFA.CantidadReal = Convert.ToDecimal(rowD["CantidadReal"]);
					itemFA.CantidadOrdenDeCompra = Convert.ToDecimal(rowD["CantidadOrdenDeCompra"]);
					/*hay q recuperarlo de otra tabla*/
					//itemFA.FechaOrdenDeCompra = itemOC.FechaComprobanteOrigen;
					itemFA.IdFuenteDeCambioOrdenDeCompra = Convert.ToString(rowD["IdFuenteDeCambio"]);
					itemFA.IdComprobanteOrdenDeCompra =  Convert.ToString(rowD["IdComprobanteOrdenDeCompra"]);
					itemFA.IdMonedaOrdenDeCompra =  Convert.ToString(rowD["IdMoneda"]);
					itemFA.IdProducto =  Convert.ToString(rowD["IdProducto"]);
					/*hay q recuperarlo de otra tabla*/
					//itemFA.Codigo = item.Codigo;
					//itemFA.NumeroOrdenDeCompra = itemOC.NumeroComprobanteOrigen;
					itemFA.Ordinal = Convert.ToInt64(rowD["Ordinal"]);// Es el ordinal del CRMXC
					itemFA.OrdinalOrdenDeCompra = Convert.ToInt64(rowD["OrdinalOrdenDeCompra"]);
					itemFA.PrecioDeCostoFactura = Convert.ToDecimal(rowD["PrecioDeCostoFactura"]);
					itemFA.PrecioDeCostoReal = Convert.ToDecimal(rowD["PrecioDeCostoReal"]);
					itemFA.PrecioDeCostoOrdenDeCompra = Convert.ToDecimal(rowD["PrecioDeCostoOrdenDeCompra"]);;
					/*hay q recuperarlo de otra tabla*/
					//itemFA.Producto = item.Descripcion;
					itemFA.Estado = Convert.ToString(rowD["Estado"]);
					itemFA.ValorCotizacionFactura = _valorCotizacionFactura;
					itemFA.ValorCotizacionOrdenDeCompra = Convert.ToDecimal(rowD["ValorCotizacion"]);
					itemFA.TieneDiferenciaPorCantidad = Convert.ToBoolean(rowD["TieneDiferenciaPorCantidad"]);
					itemFA.TieneDiferenciaPorPrecio = Convert.ToBoolean(rowD["TieneDiferenciaPorPrecio"]);
					itemFA.TieneDiferenciaPorCotizacion = Convert.ToBoolean(rowD["TieneDiferenciaPorCotizacion"]);
					itemFA.EstadoChanged +=new EventHandler(itemFA_EstadoChanged);
					this._items.Add(itemFA);
					
					
				}
			}
		}

		public void LoadFromIdComprobante(string IdComprobante)
		{
			
			
			//string IdComprobanteDeCompra = relaciones.IdComprobante;
			this._flushState = "EDIT";
			DataSet data = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList( IdComprobante, null, null, null,null, null, null,null,null);
			Load(data);

		}
		public void LoadFromNumeroFactura(string NumeroFactura, string IdProveedor)
		{
			
			
			//string IdComprobanteDeCompra = relaciones.IdComprobante;
			this._flushState = "EDIT";
			DataSet data = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList( null, null, IdProveedor, null,null, null, NumeroFactura,null,null);
			Load(data);
		}


		public void LoadFromIdComprobanteFactura(string IdComprobanteFactura)
		{
			
			
			//string IdComprobanteDeCompra = relaciones.IdComprobante;
			this._flushState = "EDIT";
			DataSet data = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList( null, IdComprobanteFactura, null, null,null, null, null,null,null);
			Load(data);
		}
		private void LoadFromRelacionesComprobanteDeCompraOrigenDestino(RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			
			
			string IdComprobanteDeCompra = relaciones.IdComprobante;
			this._flushState = "EDIT";
			DataSet data = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList( null, IdComprobanteDeCompra, null, null,null, null, null,null,null);
			if(data.Tables[0].Rows.Count == 1)
			{
				DataRow rowC = data.Tables[0].Rows[0];
				_existeFactura = true;
				_idComprobanteFactura = IdComprobanteDeCompra;
				_idFuenteDeCambioFactura = Convert.ToString(rowC["IdFuenteDeCambioOriginal"]);
				_idMonedaFactura = Convert.ToString(rowC["IdMonedaOriginal"]);
				_idProveedor = Convert.ToString(rowC["IdProveedor"]);
				_numeroFactura = Convert.ToString(rowC["NumeroFactura"]);
				_observaciones = Convert.ToString(rowC["Observaciones"]);
				_valorCotizacionFactura = Convert.ToDecimal(rowC["ValorCotizacionOriginal"]);
				_idComprobante = Convert.ToString(rowC["IdComprobante"]);
				
				
				foreach(RelacionComprobanteDeCompraOrigenDestino ror in relaciones)
				{
				
					DataRow rowD = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( _idComprobante, ror.OrdinalOrigen );
					FacturaDeCompraItem itemFA =new FacturaDeCompraItem();
					itemFA.CantidadFactura = Convert.ToDecimal(rowD["CantidadFactura"]);
					itemFA.CantidadReal = Convert.ToDecimal(rowD["CantidadReal"]);
					itemFA.CantidadOrdenDeCompra = Convert.ToDecimal(rowD["CantidadOrdenDeCompra"]);
					/*hay q recuperarlo de otra tabla*/
					//itemFA.FechaOrdenDeCompra = itemOC.FechaComprobanteOrigen;
					itemFA.IdFuenteDeCambioOrdenDeCompra = Convert.ToString(rowD["IdFuenteDeCambio"]);
					itemFA.IdComprobanteOrdenDeCompra =  Convert.ToString(rowD["IdComprobanteOrdenDeCompra"]);
					itemFA.IdMonedaOrdenDeCompra =  Convert.ToString(rowD["IdMoneda"]);
					itemFA.IdProducto =  Convert.ToString(rowD["IdProducto"]);
					/*hay q recuperarlo de otra tabla*/
					//itemFA.Codigo = item.Codigo;
					//itemFA.NumeroOrdenDeCompra = itemOC.NumeroComprobanteOrigen;
					itemFA.Ordinal = Convert.ToInt64(rowD["Ordinal"]);// Es el ordinal del CRMXC
					itemFA.OrdinalOrdenDeCompra = Convert.ToInt64(rowD["OrdinalOrdenDeCompra"]);
					itemFA.PrecioDeCostoFactura = Convert.ToDecimal(rowD["PrecioDeCostoFactura"]);
					itemFA.PrecioDeCostoReal = Convert.ToDecimal(rowD["PrecioDeCostoReal"]);
					itemFA.PrecioDeCostoOrdenDeCompra = Convert.ToDecimal(rowD["PrecioDeCostoOrdenDeCompra"]);;
					/*hay q recuperarlo de otra tabla*/
					//itemFA.Producto = item.Descripcion;
					itemFA.ValorCotizacionOrdenDeCompra = Convert.ToDecimal(rowD["ValorCotizacion"]);
					itemFA.TieneDiferenciaPorCantidad = Convert.ToBoolean(rowD["TieneDiferenciaPorCantidad"]);
					itemFA.TieneDiferenciaPorPrecio = Convert.ToBoolean(rowD["TieneDiferenciaPorPrecio"]);
					itemFA.TieneDiferenciaPorCotizacion = Convert.ToBoolean(rowD["TieneDiferenciaPorCotizacion"]);
					itemFA.EstadoChanged +=new EventHandler(itemFA_EstadoChanged);
					this._items.Add(itemFA);
					
					
				}

			}
			
			

			
		}

		public void LoadItemsFromItemsComprobanteDeCompra(comprobantes.ItemsComprobantesCompra items, ArrayList TiposDeArticulosAdicionales)
		{
			this.Items.Clear();
			foreach(ItemComprobanteCompra item in items)
			{
				if(!TiposDeArticulosAdicionales.Contains(item.IdTipoProducto))
				{
					//if(item.MiProducto != null)
					//{
					//Producto prod = item.MiProducto;
					if(item.OrdenCompraItem != null)
					{
						OrdenDeCompraItem itemOC = item.OrdenCompraItem;
						FacturaDeCompraItem itemFA =new FacturaDeCompraItem();
						itemFA.CantidadFactura = item.Cantidad;
						itemFA.CantidadReal = item.Cantidad;
						itemFA.CantidadOrdenDeCompra = itemOC.CantidadOrigen;
						itemFA.Codigo = item.Codigo;
						itemFA.FechaOrdenDeCompra = itemOC.FechaComprobanteOrigen;
						itemFA.IdFuenteDeCambioOrdenDeCompra = itemOC.IdFuenteDeCambio;
						itemFA.IdComprobanteOrdenDeCompra = itemOC.IdComprobanteOrigen;
						itemFA.IdMonedaOrdenDeCompra = itemOC.IdMoneda;
						itemFA.IdProducto = item.IdProducto;
						itemFA.NumeroOrdenDeCompra = itemOC.NumeroComprobanteOrigen;
						itemFA.Ordinal = item.Ordinal;// Es el ordinal del CRMXC
						itemFA.OrdinalOrdenDeCompra = itemOC.OrdinalOrigen;
						itemFA.PrecioDeCostoFactura = itemOC.PrecioDeCosto;
						itemFA.PrecioDeCostoReal = itemOC.PrecioDeCosto;
						itemFA.PrecioDeCostoOrdenDeCompra = itemOC.PrecioDeCosto;
						itemFA.Producto = item.Descripcion;
						itemFA.ValorCotizacionOrdenDeCompra = itemOC.ValorCotizacion;
						itemFA.ValorCotizacionFactura = item.ValorCotizacionPrecioDeCosto;
						itemFA.SetEstados();
						itemFA.EstadoChanged +=new EventHandler(itemFA_EstadoChanged);
						this._items.Add(itemFA);
					}
				}
				//}

			}
		}

		public void LoadFromComprobanteDeCompra(comprobantes.ComprobanteDeCompra comp)
		{
			this._idMonedaFactura = comp.IdMonedaOrigen;
			this._idFuenteDeCambioFactura = comp.IdFuenteDeCambioProveedor;
			this._valorCotizacionFactura = comp.ValorCotizacionProveedor;
			this._numeroFactura = comp.Numero;
			this._fechaFactura = comp.FechaComprobante;
			this._idProveedor = comp.IdProveedor;
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

		public ArrayList Estados
		{
			get{return _estados;}
		}

		public bool ExisteFactura
		{
			get{return _existeFactura;}
		}

		public ArrayList Items
		{
			get{return _items;}
		}

		public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}

		public DateTime FechaFactura
		{
			get{return _fechaFactura;}
			set{_fechaFactura = value;}
		}

		

		public string NumeroFactura
		{
			get{return _numeroFactura;}
			set{_numeroFactura = value;}
		}

		

		public decimal ValorCotizacionFactura
		{
			get{return _valorCotizacionFactura;}
			set{_valorCotizacionFactura = value;}
		}

		public string IdFuenteDeCambioFactura
		{
			get{return _idFuenteDeCambioFactura;}
			set{_idFuenteDeCambioFactura = value;}
		}

		public string IdMonedaFactura
		{
			get{return _idMonedaFactura;}
			set{_idMonedaFactura = value;}
		}

		public string IdComprobanteFactura
		{
			get{return _idComprobanteFactura;}
			set{_idComprobanteFactura = value;}
		}

		public string IdComprobante
		{
			get{return _idComprobante;}
		}

		public event EventHandler EstadoItemsChanged;
		public event EventHandler EstadoChanged;

		private void itemFA_EstadoChanged(object sender, EventArgs e)
		{
			if(EstadoItemsChanged != null)
				EstadoItemsChanged(this, new EventArgs());
		}
	}

	public class FacturaDeCompraItem
	{
		#region Variables Privadas
		
		private string _idProducto = string.Empty;
		private string _producto = string.Empty;
		private string _codigo = string.Empty;
		private long _ordinalOrdenDeCompra = 0;
		private long _ordinal = 0;
		private decimal _cantidadOrdenDeCompra = 0;
		private decimal _cantidadFactura = 0;
		private decimal _cantidadReal = 0;
		private decimal _precioDeCostoFactura = 0;
		private decimal _precioDeCostoOrdenDeCompra = 0;
		private decimal _precioDeCostoReal = 0;
		private string _observaciones = string.Empty;
		private bool _confimado = false;
		private long _idMotivoDiferencia = 1;
		private string _idMonedaOrdenDeCompra = string.Empty;
		private string _idFuenteDeCambioOrdenDeCompra = string.Empty;
		private string _simboloMonedaOrdenDeCompra = string.Empty;
		private string _fuenteDeCambioOrdenDeCompra = string.Empty;
		private decimal _valorCotizacionOrdenDeCompra = 1;
		private decimal _valorCotizacionFactura = 1;
		private string _idComprobanteOrdenDeCompra = string.Empty;
		private string _numeroOrdenDeCompra = "A--";
		private DateTime _fechaOrdenDeCompra = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _estado = "P";
		private bool _tieneDiferenciaPorCantidad = false;
		private bool _tieneDiferenciaPorPrecio = false;
		private bool _tieneDiferenciaPorCotizacion = false;
	

		public event EventHandler EstadoChanged;

		public void SetEstados()
		{
			SetEstadoPrecio();
			SetEstadoCantidad();
			SetEstadoCotizacion();
		}
		
		private void SetEstado()
		{
			
			_estado = !_tieneDiferenciaPorPrecio && !_tieneDiferenciaPorCantidad && !_tieneDiferenciaPorCotizacion?"T":_estado.Equals("T")? "P":_estado;
			if(EstadoChanged != null)
				EstadoChanged(this, new EventArgs());
		}

		public  void SetEstadoCotizacion()
		{
			_tieneDiferenciaPorCotizacion =  _valorCotizacionFactura != _valorCotizacionOrdenDeCompra ;
			SetEstado();

		}

		public void SetEstadoCantidad()
		{
			_tieneDiferenciaPorCantidad = _cantidadFactura != _cantidadOrdenDeCompra;
			SetEstado();
		}

		public void SetEstadoPrecio()
		{
			/*Este metodo deberia comparar los precios entre si, pero se deberia tener en cuenta el coeficiente de
			 * diferencia condifgurado para el prodcuto. Dicha ocndiguracion puede ser general, puede ser por jerarquia,
			 * o puede ser a nivel de producto.
			 * */

			decimal PCOC = Math.Round(_precioDeCostoOrdenDeCompra,2);
			decimal PCF = Math.Round(_precioDeCostoFactura,2);
			decimal PCR = Math.Round(_precioDeCostoReal,2);
			_tieneDiferenciaPorPrecio = !(PCF == PCR);
			SetEstado();
		}

		#endregion

		#region Variables Publicas
		
		public bool TieneDiferenciaPorCotizacion
		{
			get{return _tieneDiferenciaPorCotizacion;}
			set
			{
				if(_tieneDiferenciaPorCotizacion != value)
				{
					_tieneDiferenciaPorCotizacion = value;
					SetEstado();
				}
			}
		}

		public bool TieneDiferenciaPorCantidad
		{
			get{return _tieneDiferenciaPorCantidad;}
			set
			{
				if(_tieneDiferenciaPorCantidad != value)
				{
					_tieneDiferenciaPorCantidad = value;
					SetEstado();
				}
			}
		}

		public bool TieneDiferenciaPorPrecio
		{
			get{return _tieneDiferenciaPorPrecio;}
			set
			{
				if(_tieneDiferenciaPorPrecio!= value)
				{
					_tieneDiferenciaPorPrecio = value;
					SetEstado();
				}
			}
		}

		

		public string Estado
		{
			get {return _estado;}
			set{_estado = value;}
		}

		public string NumeroOrdenDeCompra
		{
			get{return _numeroOrdenDeCompra;}
			set{_numeroOrdenDeCompra = value;}
		}
		public DateTime FechaOrdenDeCompra
		{
			get{return _fechaOrdenDeCompra;}
			set{_fechaOrdenDeCompra = value;}
		}

		public decimal ValorCotizacionOrdenDeCompra
		{
			get{return _valorCotizacionOrdenDeCompra;}
			set
			{
				if(_valorCotizacionOrdenDeCompra != value)
				{
					_valorCotizacionOrdenDeCompra = value;
					SetEstadoCotizacion();
				}
			}
		}

		public decimal ValorCotizacionFactura
		{
			get{return _valorCotizacionFactura;}
			set
			{
				if(_valorCotizacionFactura != value)
				{
					_valorCotizacionFactura = value;
					SetEstadoCotizacion();
				}
			}
		}


		public string IdFuenteDeCambioOrdenDeCompra
		{
			get{return _idFuenteDeCambioOrdenDeCompra;}
			set
			{
				_idFuenteDeCambioOrdenDeCompra = value;
				_fuenteDeCambioOrdenDeCompra = mz.erp.businessrules.tfi_FuentesDeCambio.GetDescripcion(_idFuenteDeCambioOrdenDeCompra);
			}
		}

		public string IdMonedaOrdenDeCompra
		{
			get{return _idMonedaOrdenDeCompra;}
			set
			{
				_idMonedaOrdenDeCompra = value;
				_simboloMonedaOrdenDeCompra = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(_idMonedaOrdenDeCompra);
			}
		}

		public string FuenteDeCambioOrdenDeCompra
		{
			get{return _fuenteDeCambioOrdenDeCompra;}
			
		}

		public string SimboloMonedaOrdenDeCompra
		{
			get{return _simboloMonedaOrdenDeCompra;}
		}

		public string IdComprobanteOrdenDeCompra
		{
			get{return _idComprobanteOrdenDeCompra;}
			set{_idComprobanteOrdenDeCompra = value;}
		}

		public decimal PrecioDeCostoReal
		{
			get{return _precioDeCostoReal;}
			set
			{
				if(_precioDeCostoReal != value)
				{
					_precioDeCostoReal = value;
					SetEstadoPrecio();
				}
			}
		}

		public decimal PrecioDeCostoFactura
		{
			get{return _precioDeCostoFactura;}
			set
			{
				if(_precioDeCostoFactura != value)
				{
					_precioDeCostoFactura = value;
					SetEstadoPrecio();
				}
			}
		}

		public decimal PrecioDeCostoOrdenDeCompra
		{
			get{return _precioDeCostoOrdenDeCompra;}
			set
			{
				if(_precioDeCostoOrdenDeCompra != value)
				{
					_precioDeCostoOrdenDeCompra = value;
					SetEstadoPrecio();
				}
			}
		}

		public long Ordinal
		{
			get{return _ordinal;}
			set{_ordinal = value;}
		}
			
		public long OrdinalOrdenDeCompra
		{
			get{return _ordinalOrdenDeCompra;}
			set{_ordinalOrdenDeCompra = value;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
			set{_idProducto = value;}
		}

		public string Producto
		{
			get{return _producto;}
			set{_producto = value;}
		}

		public string Codigo
		{
			get{return _codigo;}
			set{_codigo = value;}
		}

		public decimal CantidadReal
		{
			get{return _cantidadReal;}
			set
			{
				if(_cantidadReal != value)
				{
					_cantidadReal = value;
					SetEstadoCantidad();
				}
			}
		}

		
		public decimal CantidadFactura
		{
			get{return _cantidadFactura;}
			set
			{
				if(_cantidadFactura != value)
				{
					_cantidadFactura = value;
					SetEstadoCantidad();
				}
			}
		}

		public decimal CantidadOrdenDeCompra
		{
			get{return _cantidadOrdenDeCompra;}
			set{_cantidadOrdenDeCompra = value;}
		}

		public string Observaciones
		{
			get{return _observaciones;}
			set{_observaciones = value;}
		}

		public bool Confirmado
		{
			get{return _confimado;}
			set{_confimado = value;}
		}

		public long IdMotivoDiferencia
		{
			get{return _idMotivoDiferencia;}
			set{_idMotivoDiferencia = value;}
		}

		#endregion
	}

	public class EstadoConfirmacionDePrecios
	{
		private string _idEstado = string.Empty;
		private string _descripcion = string.Empty;

		public EstadoConfirmacionDePrecios(string IdEstado, string Descripcion)
		{
			_idEstado = IdEstado;
			_descripcion = Descripcion;
		}

		public string IdEstado
		{
			get{return _idEstado;}
			
		}

		public string Descripcion 
		{
			get{return _descripcion;}
			
		}
	}
}
