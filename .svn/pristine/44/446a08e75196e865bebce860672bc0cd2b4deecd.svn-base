// Modelo estático
using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.data;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;
using System.Text;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// </summary>
	public class ComprobanteDeCompra: Comprobante, ITask, IPersistentTask
	{
		public ComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}		


		#region Eventos
				
		public event EventHandler TipoDeComprobanteDestinoChanged;
		public event EventHandler IdMonedaOrigenChanged;
		public event EventHandler FechaRecepcionMercaderiaChanged;
		public event EventHandler DiasDemoraEntregaChanged;
		public event EventHandler CondicionDeCompraChanged;
		public event EventHandler AddItemsChanged;
		//German 20090407
		public event EventHandler ItemsChanged;
		//Fin German 20090407

		#endregion

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
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionItemsDeCompraPendientes ))
			{
				SeleccionItemsDeCompraPendientes itemsPendientes = (SeleccionItemsDeCompraPendientes)sender;
				if(!itemsPendientes.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoEditarPreOrdenDeCompra"))
				{
					if(itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino!= null && itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino.Count > 0)
					{
						Step( ((SeleccionItemsDeCompraPendientes)sender).RelacionesComprobanteDeCompraOrigenDestino);
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}	
			if (sender.GetType() == typeof( mz.erp.businessrules.IngresarPrecioProducto ))
			{
                IngresarPrecioProducto task = (IngresarPrecioProducto)sender;
                //German 20110309 - Tarea 0000038
                if ((task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                   && this.GetTaskName().Equals("ConfirmarIngresoMercaderia")) || (!task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))
                  
                   )
                {
                   
                    UpdateFromIngresarPrecioProducto(task);
                }
                //Fin German 20110309 - Tarea 0000038
			}
			if (sender.GetType() == typeof( mz.erp.businessrules.StockNDias))
			{
				StockNDias task = (StockNDias)sender;
				UpdateFromStockNDias(task);
			}
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes ))
			{
				SeleccionarComprobantesDeCompraPendientes task = (SeleccionarComprobantesDeCompraPendientes)sender;
				if(task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoEditarPreOrdenDeCompra"))
				{
					if(task.ArrayComprobantesPendientes != null && task.ArrayComprobantesPendientes.Count > 0)
					{
						Edit( (string)task.ArrayComprobantesPendientes[0]);
						InitEventHandlers();
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}

            //German 20110309 - Tarea 0000038
            if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra))
            {
                ComprobanteDeCompra task = (ComprobanteDeCompra)sender;
                if (task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                    && task.GetTaskName().Equals("IngresarMercaderia")
                    && this.GetTaskName().Equals("ConfirmarIngresoMercaderia")
                    )
                {
                    GetRelacionesComprobantesOrigenDestino(task);
                    if (this._relacionesComprobantesDeCompraOrigenDestino!= null && _relacionesComprobantesDeCompraOrigenDestino.Count > 0)
                    {
                            Step(_relacionesComprobantesDeCompraOrigenDestino);
                    }
                    /*
                    if (ObjectHasChanged != null)
                            ObjectHasChanged(this, new EventArgs());
                    */
                    
                }
            }

            if (sender.GetType() == typeof(mz.erp.businessrules.IngresarComprobanteDeCompraCabecera))
            {
                IngresarComprobanteDeCompraCabecera task = (IngresarComprobanteDeCompraCabecera)sender;
                if (task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                   && this.GetTaskName().Equals("ConfirmarIngresoMercaderia"))
                {
                    this._numero = task.Numero;                    
                }
            }
            //Fin German 20110309 - Tarea 0000038
		}

        //German 20110309 - Tarea 0000038
        private void GetRelacionesComprobantesOrigenDestino(ComprobanteDeCompra compPrevio)
        {
            _relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino(compPrevio);
        }
        //Fin German 20110309 - Tarea 0000038
		private void UpdatePreciosFromProveedor(ArrayList items)
		{
			if(this.ProcessName().Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
			{
				if(this._proveedor.IsValid)
				{
					int i = 0;
					Cotizacion cot = new Cotizacion();
					foreach(Item item in items)
					{
						decimal precioProveedor = 0;
						tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP =tpu_ProveedoresProductos.GetByPk(this._proveedor.IdProveedor, item.IdProducto);
						if(rowPP != null)
						{
							if(_usaListaDePreciosProveedor)
							{
								precioProveedor = rowPP.PrecioDeCostoFinal;
								cot.IdMonedaOrigen = rowPP.IdMonedaProveedor;
								cot.Valor = rowPP.ValorCotizacionProveedor;
								cot.IdFuenteDeCambio = rowPP.IdFuenteDeCambioProveedor;

							}
							else
							{
								precioProveedor = rowPP.PrecioDeCostoUltimaCompra;
								cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(rowPP.IdCotizacionPrecioDeCosto);
							}
						}
						item.PrecioCostoBase = precioProveedor;
						item.SimboloMonedaPrecioCostoBase = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(cot.IdMonedaOrigen);
						item.ValorCotizacionPrecioCostoBase = cot.Valor;
						item.SimboloMonedaPrecioCosto = this.SimboloMonedaOrigen;
						item.ValorCotizacionPrecioCosto = this.ValorCotizacionProveedor;
						item.PrecioCosto = (item.PrecioCostoBase * item.ValorCotizacionPrecioCostoBase) / item.ValorCotizacionPrecioCosto;
						
						/*
						DataRow row = _tableResultStockNDias.Rows[i];
						row["PrecioDeCosto"] = precioProveedor;
						row["Proveedor"] = _proveedor.Nombre;
						i++;
						*/
					}
				}
				else
				{
					foreach(Item it in items)
					{
						//item.SimboloMonedaPrecioCostoBase = row["SimboloPrecioDeCosto"].ToString();
						//item.ValorCotizacionPrecioCostoBase = Convert.ToDecimal(row["ValorCotizacionPrecioDeCosto"]);
						//item.PrecioCostoBase = it.PrecioCosto;
						it.SimboloMonedaPrecioCosto = this.SimboloMonedaOrigen;
						it.ValorCotizacionPrecioCosto = this.ValorCotizacionProveedor;
						it.PrecioCosto = (it.PrecioCostoBase * it.ValorCotizacionPrecioCostoBase) / it.ValorCotizacionPrecioCosto;
					}
				}
			}
			else
			{
				foreach(Item it in items)
				{
					//item.SimboloMonedaPrecioCostoBase = row["SimboloPrecioDeCosto"].ToString();
					//item.ValorCotizacionPrecioCostoBase = Convert.ToDecimal(row["ValorCotizacionPrecioDeCosto"]);
					//item.PrecioCostoBase = it.PrecioCosto;
					it.SimboloMonedaPrecioCosto = this.SimboloMonedaOrigen;
					it.ValorCotizacionPrecioCosto = this.ValorCotizacionProveedor;
					it.PrecioCosto = (it.PrecioCostoBase * it.ValorCotizacionPrecioCostoBase) / it.ValorCotizacionPrecioCosto;
				}
			}
		}

		private void UpdatePreciosFromProveedor()
		{
			if(this.ProcessName().Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
			{
				if(this._proveedor.IsValid)
				{
					int i = 0;
					Cotizacion cot = new Cotizacion();
					foreach(ItemComprobanteCompra item in _items)
					{
						decimal precioProveedor = 0;
						tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP =tpu_ProveedoresProductos.GetByPk(this._proveedor.IdProveedor, item.IdProducto);
						if(rowPP != null)
						{
							if(_usaListaDePreciosProveedor)
							{
								precioProveedor = rowPP.PrecioDeCostoFinal;
								cot.IdMonedaOrigen = rowPP.IdMonedaProveedor;
								cot.Valor = rowPP.ValorCotizacionProveedor;
								cot.IdFuenteDeCambio = rowPP.IdFuenteDeCambioProveedor;

							}
							else
							{
								precioProveedor = rowPP.PrecioDeCostoUltimaCompra;
								cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(rowPP.IdCotizacionPrecioDeCosto);
							}
						}
						item.PrecioDeCostoBase = precioProveedor;
						item.SimboloPrecioDeCostoBase = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(cot.IdMonedaOrigen);
						item.ValorCotizacionPrecioDeCostoBase = cot.Valor;
						item.PrecioDeCosto = (item.PrecioDeCostoBase * item.ValorCotizacionPrecioDeCostoBase) / item.ValorCotizacionPrecioDeCosto;
						
						/*
						DataRow row = _tableResultStockNDias.Rows[i];
						row["PrecioDeCosto"] = precioProveedor;
						row["Proveedor"] = _proveedor.Nombre;
						i++;
						*/
					}
				}
			}

			
		}

		public void UpdateFromStockNDias(StockNDias task)
		{
			string idMoneda = task.GetIdMonedaPrecioDeCosto();
			string idFuenteDeCambio = task.GetIdFuenteDeCambioPrecioDeCosto();
			decimal valorCot = task.GetValorCotizacionPrecioDeCosto();
			if(!idMoneda.Equals(string.Empty) && !idFuenteDeCambio.Equals(string.Empty) && valorCot != 0)
			{
				this.IdMonedaOrigen = idMoneda;
				this.IdFuenteDeCambioProveedor = idFuenteDeCambio;
				this.ValorCotizacionProveedor = valorCot;
			}
			string idProv = task.GetIdProveedor();
			if(!idProv.Equals(string.Empty))
				_proveedor = new Proveedor(idProv);
            _tableResultStockNDias = task.Result.Copy();
			_usaListaDePreciosProveedor = task.PrecioDeListaProveedor;
			int i = 0;
			_items.Clear();
			ArrayList rowsABorrar = new ArrayList();
			//German 20090413
			bool SeleccionPorCantidad = task.SeleccionPorCantidad;
			foreach(DataRow row in _tableResultStockNDias.Rows)
			{
				if(SeleccionPorCantidad)
				{
					if(/*(bool)row["Ordenar"]*/ Convert.ToDecimal(row["CantidadAComprar"]) > 0)
					{
						Item item = new Item();					
						item.IdProducto = row["IdProducto"].ToString();
						item.Descripcion = (string)row["Descripcion"];
						item.Codigo = row["Codigo"].ToString();					
						if(row.IsNull("CantidadAComprar"))
							item.Cantidad = 0;
						else
							item.Cantidad = Convert.ToDecimal(row["CantidadAComprar"]);
						item.SimboloMonedaPrecioCostoBase = row["SimboloPrecioDeCosto"].ToString();
						if(row.IsNull("ValorCotizacionPrecioDeCosto"))
							item.ValorCotizacionPrecioCostoBase = 1;
						else
							item.ValorCotizacionPrecioCostoBase = Convert.ToDecimal(row["ValorCotizacionPrecioDeCosto"]);
						if(row.IsNull("PrecioDeCosto"))
							item.PrecioCostoBase = 0;
						else
							item.PrecioCostoBase = Convert.ToDecimal(row["PrecioDeCosto"]);
						item.IdComprobanteOrigen = _idComprobante;
						item.OrdinalDestino = i;
						item.SimboloMonedaPrecioCosto = this.SimboloMonedaOrigen;
						item.ValorCotizacionPrecioCosto = this.ValorCotizacionProveedor;
						item.PrecioCosto = (item.PrecioCostoBase * item.ValorCotizacionPrecioCostoBase) / item.ValorCotizacionPrecioCosto;
						//German 20090421
						item.CampoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
						//Fin German 20090421
						ItemComprobanteCompra itemCC = new ItemComprobanteCompra("STEP", item, _items);
						_items.Add(itemCC);
						i++;
					}
					else
						rowsABorrar.Add(row);
				}
				else
				{
					if(Convert.ToBoolean(row["Ordenar"]))
					{
						Item item = new Item();					
						item.IdProducto = row["IdProducto"].ToString();
						item.Descripcion = (string)row["Descripcion"];
						item.Codigo = row["Codigo"].ToString();					
						if(row.IsNull("CantidadAComprar"))
							item.Cantidad = 0;
						else
							item.Cantidad = Convert.ToDecimal(row["CantidadAComprar"]);
						item.SimboloMonedaPrecioCostoBase = row["SimboloPrecioDeCosto"].ToString();
						if(row.IsNull("ValorCotizacionPrecioDeCosto"))
							item.ValorCotizacionPrecioCostoBase = 1;
						else
							item.ValorCotizacionPrecioCostoBase = Convert.ToDecimal(row["ValorCotizacionPrecioDeCosto"]);
						if(row.IsNull("PrecioDeCosto"))
							item.PrecioCostoBase = 0;
						else
							item.PrecioCostoBase = Convert.ToDecimal(row["PrecioDeCosto"]);
						item.IdComprobanteOrigen = _idComprobante;
						item.OrdinalDestino = i;
						item.SimboloMonedaPrecioCosto = this.SimboloMonedaOrigen;
						item.ValorCotizacionPrecioCosto = this.ValorCotizacionProveedor;
						item.PrecioCosto = (item.PrecioCostoBase * item.ValorCotizacionPrecioCostoBase) / item.ValorCotizacionPrecioCosto;
						//German 20090421
						item.CampoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
						//Fin German 20090421
						ItemComprobanteCompra itemCC = new ItemComprobanteCompra("STEP", item, _items);
						_items.Add(itemCC);
						i++;
					}
					else
						rowsABorrar.Add(row);
				}
			}
			//Fin German 20090413
			
			foreach(DataRow row in rowsABorrar)
			{
				_tableResultStockNDias.Rows.Remove(row);		
			}
			
		}

		public void UpdateDataFromProveedor(Proveedor proveedor)
		{
			this._proveedor = proveedor;
			UpdateFromProveedor();

		}

		public void UpdateFromIngresarPrecioProducto(IngresarPrecioProducto task)
		{
			
			this._idMonedaCierre = Variables.GetValueString("Contabilidad.MonedaReferencia");
			this._idMonedaOrigen = task.IdMonedaProveedor;
			this._simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this._idMonedaOrigen);
			this._idCotizacionCierre = task.IdCotizacionFuenteDeCambioComprador;
			this._idFuenteDeCambioProveedor = task.IdFuenteDeCambioProveedor;
			this._valorCotizacionProveedor = task.ValorCotizacionFuenteDeCambioProveedor;
			GetConversion();
			updatePrecios();

            //German 20110310 - Tarea 0000038
            if (task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))
            {
                foreach (Producto prod in task.Productos)
                {
                    ArrayList items = this.Items.GetByIdProducto(prod.IdProducto);
                    foreach (ItemComprobanteCompra item in items)
                    {
                        item.PrecioDeCosto = prod.PrecioDeCostoMonedaProveedor;
                        item.PrecioCompraOriginal = item.PrecioDeCosto;
                        item.CantidadCompraOriginal = item.Cantidad;
                    }
                }

            }
            else
            {
                foreach (ItemComprobanteCompra item in this.Items)
                {
                    item.PrecioDeCosto = item.MiProducto.PrecioDeCostoMonedaProveedor;
                    item.PrecioCompraOriginal = item.PrecioDeCosto;
                    item.CantidadCompraOriginal = item.Cantidad;

                }
            }
            //Fin German 20110310 - Tarea 0000038
		}

		private void UpdateFromProveedor()
		{
			string Proceso = this._processParent.Process.ProcessName;
			if(this._proveedor.IsValid && _categoriaImpositivaProveedorAfectaTipoDeComprobanteDestino)
			{
				string IdCategoriaIVA = this._proveedor.IdCategoriaIva;
				DataRowCollection rows = mz.erp.businessrules.tsy_TiposDeComprobantesCategoriaIva.GetList(_listaTiposDeComprobantesValidos, IdCategoriaIVA, true).Tables[0].Rows;
				DataRow row = null;
				if(rows.Count > 0)
					row = rows[0];
				if(row != null)
				{
					this.TipoComprobanteDestino = Convert.ToString(row["IdTipoDeComprobante"]);
				}
				else
					this.TipoComprobanteDestino = Variables.GetValueString(Proceso, this._momento, "Comprobantes.Default");
				
			}
			else
			{
				this.TipoComprobanteDestino = Variables.GetValueString(Proceso, this._momento, "Comprobantes.Default");
			}
            if (this._proveedor.IsValid)
                /* Silvina 20110526 - Tarea 0000048 */
                if (_actualizaCondicionDeCompra)
                    _condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(_proveedor.IdCondicionDeCompra);
                else
                    _condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(_condicionDeCompraDefault);
            /* Fin Silvina 20110526 - Tarea 0000048 */
            else
                _condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(string.Empty);
			if(CondicionDeCompraChanged != null)
				CondicionDeCompraChanged(this, new EventArgs());

		}

		public void StepEdit(RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			
			this._isStep = false;
			this._isEdit = true;
			this._isEditItems = false;
			this._idComprobante = relaciones.IdComprobante;
			this._idComprobanteOrigen = relaciones.Get(0).IdComprobante;
			this._proveedor = new Proveedor(relaciones.IdProveedor);
			//this.UpdateFromProveedor();
			this._tipoComprobanteDestino = relaciones.IdTipoDeComprobante;
			this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
			if(!(relaciones.IdCondicionDeCompra == null || relaciones.IdCondicionDeCompra.Equals(string.Empty)))
				this._condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(relaciones.IdCondicionDeCompra);
			this._fechaComprobante = relaciones.FechaComprobante;
			this._fechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			this._items = new ItemsComprobantesCompra("STEP", this, relaciones);
			this._items.ObjectHasChanged += new EventHandler(_items_ObjectHasChanged);
			this._campoAuxiliar1 = relaciones.CampoAuxiliar1;
			if(_trasladaNumero)
				this._numero = relaciones.Get(0).Numero; //PENDIENTE HASTA Q SE CORRIJA EL TEMA DEL NUMERO DE LOS COMPROBANTES DE COMPRA
			this._idMonedaCierre = relaciones.IdMonedaDestino;
			this._idMonedaOrigen = relaciones.IdMonedaOrigen;
			this._observaciones = relaciones.Observaciones;
			this._simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this._idMonedaOrigen);
			this._cotizacionCierre = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioReferencia);
			this._idCotizacionCierre = this._cotizacionCierre.IdCotizacion;
			this._cotizacionProveedor = Factory.GetCotizacion(string.Empty, this._idMonedaOrigen, this.IdMonedaCierre, relaciones.ValorCotizacionProveedor, relaciones.IdFuenteDeCambioProveedor); 
			this._valorCotizacionProveedor = relaciones.ValorCotizacionProveedor;
			this._idFuenteDeCambioProveedor = relaciones.IdFuenteDeCambioProveedor;
			this._fechaRecepcionMercaderia = relaciones.FechaRecepcionMercaderia;
			this._fechaRecepcionMercaderiaAnterior = relaciones.FechaRecepcionMercaderia;
			this._idComprobanteAnterior = relaciones.IdComprobante;
			DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
			System.TimeSpan result = _fechaRecepcionMercaderia.Subtract(aux);
			if(result.Days >= 0)
				_diasDemoraEntrega = result.Days;
			else _diasDemoraEntrega = 0;
			
			

			
		
		}
		


		public void Step(RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			
			this._isStep = true;
			this._isEdit = false;
			this._isEditItems = false;
			this._idComprobante = mz.erp.systemframework.Util.NewStringId();
			this._idComprobanteOrigen = relaciones.Get(0).IdComprobante;
			this._proveedor = new Proveedor(relaciones.IdProveedor);
			this.UpdateFromProveedor();
			if(!(relaciones.IdCondicionDeCompra == null || relaciones.IdCondicionDeCompra.Equals(string.Empty)))
				this._condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(relaciones.IdCondicionDeCompra);
			this._fechaComprobante = relaciones.FechaComprobante;
			this._fechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			this._items = new ItemsComprobantesCompra("STEP", this, relaciones);
			this._items.ObjectHasChanged += new EventHandler(_items_ObjectHasChanged);
			//German 20090326
			this._campoAuxiliar1 = relaciones.CampoAuxiliar1;
			this._campoAuxiliar2 = relaciones.CampoAuxiliar2;
			this._campoAuxiliar3 = relaciones.CampoAuxiliar3;
			this._campoAuxiliar4 = relaciones.CampoAuxiliar4;
			this._campoAuxiliar5 = relaciones.CampoAuxiliar5;

			if(_trasladaNumero)
				this._numero = relaciones.Get(0).Numero; //PENDIENTE HASTA Q SE CORRIJA EL TEMA DEL NUMERO DE LOS COMPROBANTES DE COMPRA
			this._idMonedaCierre = relaciones.IdMonedaDestino;
			this._idMonedaOrigen = relaciones.IdMonedaOrigen;
			this._observaciones = relaciones.Observaciones;
			this._simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this._idMonedaOrigen);
			this._cotizacionCierre = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioReferencia);
			this._idCotizacionCierre = this._cotizacionCierre.IdCotizacion;
			this._cotizacionProveedor = Factory.GetCotizacion(string.Empty, this._idMonedaOrigen, this.IdMonedaCierre, relaciones.ValorCotizacionProveedor, relaciones.IdFuenteDeCambioProveedor); 
			this._valorCotizacionProveedor = relaciones.ValorCotizacionProveedor;
			this._idFuenteDeCambioProveedor = relaciones.IdFuenteDeCambioProveedor;
			this._fechaRecepcionMercaderia = relaciones.FechaRecepcionMercaderia;
			this._fechaRecepcionMercaderiaAnterior = relaciones.FechaRecepcionMercaderia;
			this._idComprobanteAnterior = relaciones.IdComprobante;
			DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
			System.TimeSpan result = _fechaRecepcionMercaderia.Subtract(aux);
			if(result.Days >= 0)
				_diasDemoraEntrega = result.Days;
			else _diasDemoraEntrega = 0;
			
			

			
		
		}
		

		public void Edit(string IdComprobante)
		{
			this._idFuenteDeCambioReferencia = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
			this._idMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			this._idMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
			this._isStep = false;
			this._isEdit = true;
			this._isEditItems = true;
			this._idComprobante = IdComprobante;
			tpu_ComprobantesDataset.tpu_ComprobantesRow rowComp = tpu_Comprobantes.GetByPk(IdComprobante);
			this._proveedor = new Proveedor(rowComp.IdProveedor);
			this.UpdateFromProveedor();
			this._numero = rowComp.Numero;
			this._idResponsable = rowComp.IdResponsable; 
			this._fechaComprobante = rowComp.Fecha;
			this._fechaComprobanteOriginal = this._fechaComprobante;
			this._fechaRegistracion = rowComp.FechaDeRegistracion;
			this._campoAuxiliar1 = rowComp.Aux1;
			this._idMonedaCierre = rowComp.IdMonedaCierre;
			this._idMonedaOrigen = rowComp.IdMonedaOrigen;
			this._observaciones = rowComp.Observaciones;
			this._simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this._idMonedaOrigen);
			this._cotizacionCierre = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioReferencia);
			this._idCotizacionCierre = this._cotizacionCierre.IdCotizacion;
			this._cotizacionProveedor = Factory.GetCotizacion(string.Empty, this._idMonedaOrigen, this.IdMonedaCierre, rowComp.ValorCotizacionProveedor, rowComp.IdFuenteDeCambioProveedor); 
			this._valorCotizacionProveedor = rowComp.ValorCotizacionProveedor;
			this._idFuenteDeCambioProveedor = rowComp.IdFuenteDeCambioProveedor;
			this._fechaRecepcionMercaderia = rowComp.FechaRecepcionMercaderia;
			this._fechaRecepcionMercaderiaAnterior = rowComp.FechaRecepcionMercaderia;
			this._idComprobanteAnterior = rowComp.IdComprobante;
			DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
			System.TimeSpan result = _fechaRecepcionMercaderia.Subtract(aux);
			if(result.Days >= 0)
				_diasDemoraEntrega = result.Days;
			else _diasDemoraEntrega = 0;
			if(!(rowComp.IdCondicionDeCompra == null || rowComp.IdCondicionDeCompra.Equals(string.Empty)))
				this._condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(rowComp.IdCondicionDeCompra);
			this._items = new ItemsComprobantesCompra("EDIT", this, IdComprobante);
			_trasladaNumero = true;
			//_tipoComprobanteDestino = rowComp.IdTipoDeComprobante;
			
		
		}
		

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{				
			InitData();
			InitEventHandlers();
			SetEditablesProperty();
								
		}

		private void SetEditablesProperty()
		{
			string cMomento = this.Momento;
			string Proceso = this._processParent.Process.ProcessName;
			AllowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( this.Momento,Proceso, "Emision.Editar.TComp");
			AllowEditProveedor = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso, "Emision.Editar.Proveedor");
			AllowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Editar.Fecha");
			AllowEditFechaRegistracion = ComprobantesRules.Momentos_Parametros_Bool( this.Momento,Proceso, "Emision.Editar.FechaRegistracion");
			AllowEditItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento,Proceso, "Emision.Editar.Items");
			AllowDeleteItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso, "Emision.Delete.Items", _allowDeleteItems);
			AllowAddItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso, "Emision.Add.Items", _allowAddItems);
			AllowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Editar.REmision");
			AllowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Editar.Numeracion");
			ActualizaNumeracion = ! ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Editar.Numeracion");
			AllowToValidateNumeracion = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Validar.Numeracion");
			AllowToValidateCampoAuxiliar1 = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, Proceso,"Emision.Validar.CampoAuxiliar1");
			_allowEditMonedaOrigen = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.MonedaOrigen");
			_allowEditFuenteDeCambio = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.FuenteDeCambio");
			_allowEditValorCotizacion = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.ValorCotizacion");
			_categoriaImpositivaProveedorAfectaTipoDeComprobanteDestino = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.TipoComprobanteDependeProveedor", _categoriaImpositivaProveedorAfectaTipoDeComprobanteDestino);
			_allowEditDiasDemoraEntrega = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.DiasDemoraEntrega");
			_allowEditFechaRecepcionMercaderia = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.FechaRecepcionMercaderia");
			_allowEditCondicionDeCompra = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Editar.CondicionDeCompra", _allowEditCondicionDeCompra);
			_allowValidateCondicionDeCompra = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Validar.CondicionDeCompra", _allowValidateCondicionDeCompra);
			//German 20090422
			_allowValidateItems = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, this._processParent.Process.ProcessName, "Emision.Validar.Items");
			//Fin German 20090422
			_allowToValidateItemsConMonto0 = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "Emision.Validar.ItemsConMonto0");
			_allowToShowWarningItemsConMonto0 = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "Emision.Validar.ItemsConMonto0.MostrarWarning");
            /* Silvina 20100531 - Tarea 646 */
            _seleccionaUltimo = Variables.GetValueBool("ComprobantesDeCompra.Emision.Editar.SeleccionaUltimoProducto");
            if (!_seleccionaUltimo)
                _seleccionaUltimo = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "Emision.Editar.SeleccionaUltimoProducto", _seleccionaUltimo);
            /* Fin Silvina */
            //German 20110310 - Tarea 00000038
            _allowShow = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "VisualizaVentana", _allowShow);
            //Fin German 20110310 - Tarea 00000038
            /* Silvina 20110526 - Tarea 0000048 */
            _actualizaCondicionDeCompra = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "ActualizaCondicionDeCompra", _actualizaCondicionDeCompra);
            _condicionDeCompraDefault = Variables.GetValueStringDefault(_processParent.Process.ProcessName, _taskName, "CondicionDeCompraDefault", _condicionDeCompraDefault);
            /* Fin Silvina 20110526 - Tarea 0000048 */
		}

		private void InitEventHandlers()
		{
			this._items.ObjectHasChanged += new EventHandler(_items_ObjectHasChanged);
			this.Items.ItemsChanged+=new EventHandler(Items_ItemsChanged);
		}



		private void InitData()
		{
			this._momento = this._taskName; 
			this._idComprobante = mz.erp.systemframework.Util.NewStringId();
			string IdProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
			this._listaTiposDeComprobantesValidos = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Comprobantes");
			this._proveedor = new Proveedor(IdProveedor);
			this.UpdateFromProveedor();			
			this._tableTiposDeComprobantesValidos = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,_listaTiposDeComprobantesValidos).tsy_TiposDeComprobantes;
			_mascaraNumeroDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "MascaraNumero");
			if(_mascaraNumeroDefault != null && !_mascaraNumeroDefault.Equals(string.Empty))
				this._numero = _mascaraNumeroDefault;
			this._idResponsable = Security.IdPersona;
			this._fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
			this._fechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			this._nombreCampo1 = Variables.GetValueString("ComprobantesDeCompra.CampoAuxiliar1");
			this._nombreCampo2 = Variables.GetValueString("ComprobantesDeCompra.CampoAuxiliar2");
			this._nombreCampo3 = Variables.GetValueString("ComprobantesDeCompra.CampoAuxiliar3");
			this._nombreCampo4 = Variables.GetValueString("ComprobantesDeCompra.CampoAuxiliar4");
			this._items = new ItemsComprobantesCompra("NEW",this);
			this._idFuenteDeCambioReferencia = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
			this._idFuenteDeCambioProveedor = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
			this._idMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			this._idMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
			this._simboloMonedaCierre = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this.IdMonedaCierre);
			this._simboloMonedaOrigen = this._simboloMonedaCierre;
			this._cotizacionCierre = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(this._idCotizacionCierre);
			this._cotizacionProveedor = Factory.GetCotizacion(string.Empty, this._idMonedaOrigen, this.IdMonedaCierre, this._valorCotizacionProveedor , this._idFuenteDeCambioProveedor); 
			this._idCotizacionCierre = _cotizacionCierre.IdCotizacion;
			this._valorCotizacionProveedor = this._cotizacionProveedor.Valor;
			this._tableMonedas = mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas;
			this._tableFuentesDeCambio = mz.erp.businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			this._campoAuxiliar1 = "A-0000-00000000";
			_idDeposito = ComprobantesRules.TareaProceso_GetDeposito(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Deposito" );
			_idSeccion =  ComprobantesRules.TareaProceso_GetSeccion(this._processParent.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Seccion" );
			_claveTablaAGuardar = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ClaveTabla");
			switch (_claveTablaAGuardar)
			{
					//OCRMX, OCFA, POCOC, FANC, RMXNC
				case "OCRMX" : _dataRelaciones = new tpu_OrdenesDeComprasRemitosDataset();break;
			}
			_trasladaNumero = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Step.TrasladaNumero");

			// Matias. para decidir si actualiza o cierra la parte de ProductosPedidosPendientes...
			this.AccionActualiza = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "actualizaFechaProximaRecepcionMercaderia");
			this.AccionCancela = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "cancelaFechaProximaRecepcionMercaderia");

			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PreguntarAlCancelar");
			
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
			if (!IsValidResponsable())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Responsable","IdResponsable","El responsable de emisión no puede ser nulo"));
			}
			if (!IsValidProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Proveedor","IdProveedor","Debe seleccionar el Proveedor"));
			}
			if (!IsValidNumeration())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Debe Ingresar el numero del comprobante"));
			}
			if (!IsValidNumerationForProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Ya existe el numero de comprobante para el Proveedor seleccionado"));
			}

			if (!IsValidNumeroFacturaForProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Ya existe el numero Factura para el Proveedor seleccionado"));
			}
			if (!IsValidItems())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Items","Items","No ha seleccionado ningun item"));
			}
			if (!IsValidCotizacion())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Cotizacion","Cotizacion","El Valor de la Cotizacion no es Valido"));
			}
			if (!IsValidItems())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Items","Items","No ha seleccionado ningun item"));
			}
			if(!IsValidCondicionDeCompra())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Condición de Compra","Condición de Compra","Debe selccionar una Condición de Compra"));
			}
			// ---- Matias - 200907407 - Custom tarea 215.
			if(!IsValidItemsConMonto0())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Items",this.Items.ItemsConMonto0 ));
			}

			// ---- Matias.
			
			return IsValid;
		}

		public bool IsValidCondicionDeCompra()
		{
			if(_allowValidateCondicionDeCompra)
			{
				if(IdCondicionDeCompra == null || IdCondicionDeCompra == string.Empty)
					return false;
			}
			return true;
		}

		public bool AllowToValidateItemsConMonto0
		{
			set{_allowToValidateItemsConMonto0 = value;}
			get{return _allowToValidateItemsConMonto0;}
		}

		public bool AllowToShowWarningItemsConMonto0
		{
			get{return _allowToShowWarningItemsConMonto0;}
			set{_allowToShowWarningItemsConMonto0 = value;}
		}
		
		public bool IsValidItemsConMonto0()
		{
			if (this.AllowToValidateItemsConMonto0)
			{
				return !this.Items.ExistenItemsConMonto0;
			}
			return true;
		}
		
		private bool IsValidCotizacion()
		{
			string IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			if(IdMonedaReferencia.Equals(this._idMonedaOrigen))
				return this._valorCotizacionProveedor == 1;
			return true;
		}
		

		private bool IsValidResponsable()
		{
			return this._idResponsable != null && !this._idResponsable.Equals(string.Empty);
		}

		private bool IsValidProveedor()
		{
			return this._proveedor != null && this.Proveedor.IdProveedor != null && !this.Proveedor.IdProveedor.Equals(string.Empty);
		}

		private bool IsValidItems()
		{
			return this._items != null && this._items.Count > 0;
		}

		private bool IsValidNumeration()
		{
			if (this.AllowToValidateNumeracion)
			{ 
				if ( (Numero.EndsWith("-") || (Numero == string.Empty) || _numero.Equals(_mascaraNumeroDefault))/* && (_campoAuxiliar1.EndsWith("-") || _campoAuxiliar1 == string.Empty)*/) 
				{
					return false;
				}
			}
			return true;
		}

		private bool IsValidNumeroFacturaForProveedor()
		{
			if (this.AllowToValidateCampoAuxiliar1)
			{ 
				if(!(_campoAuxiliar1.EndsWith("-") || _campoAuxiliar1 == string.Empty || _campoAuxiliar1.Equals("A-0000-00000000")) && IsValidProveedor())
				{
					return !ExistsNumeroFactura(this._campoAuxiliar1, this._tipoComprobanteDestino, this.Proveedor.IdProveedor);
				}
				else return false;
			}
			else return true;
		}

		private bool IsValidNumerationForProveedor()
		{
			if (this.AllowToValidateNumeracion)
			{ 
				if(!(_numero.EndsWith("-") || _numero == string.Empty || _numero.Equals(_mascaraNumeroDefault)) && IsValidProveedor())
				{
					return !ExistsNumeration(this._numero, this._tipoComprobanteDestino, this.Proveedor.IdProveedor);
				}
				else return false;
			}
			else return true;
		}

		public DataTable GetPagos()
		{
			return mz.erp.dataaccess.tpu_AplicacionPagos.GetList(string.Empty, short.MinValue, decimal.MinValue, string.Empty, _idComprobante, short.MinValue).Tables[0];
			
		}

		private  bool ExistsNumeroFactura(string numero, string tipoDeComprobante, string idProveedor)
		{
			return mz.erp.businessrules.tpu_Comprobantes.ExistsNumeroFactura(numero, tipoDeComprobante, IdProveedor);
		}

		private  bool ExistsNumeration(string numero, string tipoDeComprobante, string idProveedor)
		{
			return mz.erp.businessrules.tpu_Comprobantes.ExistsNumeration(numero, tipoDeComprobante, IdProveedor);
		}


		public bool AllowShow() 
		{
            //German 20110310 - Tarea 00000038
			return _allowShow;
            //Fin German 20110310 - Tarea 00000038
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
			StringBuilder result = new StringBuilder();				
			if(_allowToShowWarningItemsConMonto0)
			{
				if (this.Items.ExistenItemsConMonto0)
				{
					result.Append(this.Items.ItemsConMonto0);
					result.Append(System.Environment.NewLine);
				}
			}
			if (result.Length>0)
				return result.ToString();
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

				/*
				tpu_ComprobantesDataset.tpu_ComprobantesRow row = _dataComprobantes.tpu_Comprobantes.Newtpu_ComprobantesRow();
				row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdComprobante = this.IdComprobante;
				row.IdProveedor = this.IdProveedor;
				row.IdResponsable = this.IdResponsable;
				row.IdTipoDeComprobante = this.TipoComprobanteDestino;
				row.Numero =this._numero;
				row.IdCotizacionCierre = this._idCotizacionCierre;
				row.Total = this.TotalMonedaReferencia;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdEmpresa = Security.IdEmpresa;
				row.IdSucursal = Security.IdSucursal;
				row.IdInstanciaCaja = string.Empty;
				row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
				row.IdReservado = 0;
				row.Proveedor = this._proveedor.Nombre;
				row.Domicilio = this._proveedor.Domicilio;
				row.TipoDocumento = this._proveedor.TipoDocumento;
				row.Documento = this._proveedor.Documento;
				row.Observaciones = this._observaciones;
				row.Aux1 = this._campoAuxiliar1;
				row.Aux2 = this._campoAuxiliar2;
				row.Aux3 = this._campoAuxiliar3;
				row.Aux4 = this._campoAuxiliar4;
				row.FechaDeRegistracion = this._fechaRegistracion;
				row.ValorCotizacionProveedor = this._valorCotizacionProveedor;
				row.IdMonedaOrigen = this._idMonedaOrigen;
				row.IdFuenteDeCambioProveedor = this._idFuenteDeCambioProveedor;
				this.Numero = row.Numero;	
				row.FechaRecepcionMercaderia = _fechaRecepcionMercaderia;
				row.IdCondicionDeCompra = IdCondicionDeCompra;
			
				_dataComprobantes.tpu_Comprobantes.Addtpu_ComprobantesRow( row );
				this._items.Commit();
				this.CommitStock();			
				*/
				if(IsEdit)
				{
					tpu_ComprobantesDataset.tpu_ComprobantesRow rowComp = tpu_Comprobantes.GetByPk(this.IdComprobante);
				
					/*
					DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
					DateTime fc = this.FechaComprobante;
					DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour,now.Minute, now.Second);
					*/
					rowComp.Fecha = this.FechaComprobante;
					rowComp.IdProveedor = this.IdProveedor;
					rowComp.IdResponsable = this.IdResponsable;
					rowComp.Numero =this._numero;
					//rowComp.IdCotizacionCierre = this._idCotizacionCierre;
					rowComp.Total = this.TotalMonedaReferencia;
					//rowComp.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
					rowComp.Proveedor = this._proveedor.Nombre;
					rowComp.Domicilio = this._proveedor.Domicilio;
					rowComp.TipoDocumento = this._proveedor.TipoDocumento;
					rowComp.Documento = this._proveedor.Documento;
					rowComp.Observaciones = this._observaciones;
					rowComp.Aux1 = this._campoAuxiliar1;
					rowComp.Aux2 = this._campoAuxiliar2;
					rowComp.Aux3 = this._campoAuxiliar3;
					rowComp.Aux4 = this._campoAuxiliar4;
					rowComp.FechaDeRegistracion = this._fechaRegistracion;
					rowComp.ValorCotizacionProveedor = this._valorCotizacionProveedor;
					rowComp.IdMonedaOrigen = this._idMonedaOrigen;
					rowComp.IdFuenteDeCambioProveedor = this._idFuenteDeCambioProveedor;
					//this.Numero = row.Numero;	
					rowComp.FechaRecepcionMercaderia = _fechaRecepcionMercaderia;
					rowComp.IdCondicionDeCompra = IdCondicionDeCompra;

					_dataComprobantes.tpu_Comprobantes.ImportRow( rowComp );

					this._items.Commit(_isEditItems);
				}
				else
				{
					tpu_ComprobantesDataset.tpu_ComprobantesRow row = _dataComprobantes.tpu_Comprobantes.Newtpu_ComprobantesRow();
                    //German 20100913 - Tarea 829
                    //row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
                    row.Fecha = this.FechaComprobante;
                    //German 20100913 - Tarea 829
                    row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdComprobante = this.IdComprobante;
					row.IdProveedor = this.IdProveedor;
					row.IdResponsable = this.IdResponsable;
					row.IdTipoDeComprobante = this.TipoComprobanteDestino;
					row.Numero =this._numero;
					row.IdCotizacionCierre = this._idCotizacionCierre;
					row.Total = this.TotalMonedaReferencia;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.IdInstanciaCaja = string.Empty;
					row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
					row.IdReservado = 0;
					row.Proveedor = this._proveedor.Nombre;
					row.Domicilio = this._proveedor.Domicilio;
					row.TipoDocumento = this._proveedor.TipoDocumento;
					row.Documento = this._proveedor.Documento;
					row.Observaciones = this._observaciones;
					row.Aux1 = this._campoAuxiliar1;
					row.Aux2 = this._campoAuxiliar2;
					row.Aux3 = this._campoAuxiliar3;
					row.Aux4 = this._campoAuxiliar4;
					row.FechaDeRegistracion = this._fechaRegistracion;
					row.ValorCotizacionProveedor = this._valorCotizacionProveedor;
					row.IdMonedaOrigen = this._idMonedaOrigen;
					row.IdFuenteDeCambioProveedor = this._idFuenteDeCambioProveedor;
					this.Numero = row.Numero;	
					row.FechaRecepcionMercaderia = _fechaRecepcionMercaderia;
					row.IdCondicionDeCompra = IdCondicionDeCompra;
			
					_dataComprobantes.tpu_Comprobantes.Addtpu_ComprobantesRow( row );
				
					this._items.Commit(_isEditItems);
					this.CommitStock();							
				}

		}



		private void CommitStock()
		{			
			mz.erp.businessrules.GenerarMovimientosDeStock _movimientos = new GenerarMovimientosDeStock( _idDeposito, _idSeccion );
			long IdTarea = Workflow.GetIdTakByName(this._taskName);
			long IdProceso = Workflow.GetIdProcessByName(this.ProcessName());
			foreach (mz.erp.businessrules.comprobantes.ItemComprobanteCompra _item in this.Items)
			{
				long IdTransicion = Stock.GetTransicion( _item.IdTipoComprobanteOrigen, this.TipoComprobanteDestino, IdTarea, IdProceso);
				_movimientos.Add( IdTransicion, _item.IdProducto, _item.Cantidad );
			}
			
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = Stock.GetDataTableStock( _movimientos );
			this.DataMovimientosStock.tlg_MovimientosDeStock.Rows.Clear();
			foreach (System.Data.DataRow _row in _table )
			{
				this.DataMovimientosStock.tlg_MovimientosDeStock.Rows.Add( _row.ItemArray );
			}
			

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
			replication.NombreTabla = "dataaccess.tpu_Comprobantes";
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{
            //German 20110315 - Tarea 0000038
            if (this._processParent.Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))
            {
                if (this.GetTaskName().Equals("ConfirmarIngresoMercaderia"))
                {
                    foreach (TaskCollectionData data in _processCollectionData)
                    {
                        foreach (DataSet dataset in data)
                        {
                            string idComprobante = string.Empty;
                            string tipoDeComprobante = string.Empty;
                            if (dataset.DataSetName.Equals("tpu_ComprobantesDataset"))
                            {
                                DataTable table = dataset.Tables["tpu_Comprobantes"];
                                DataRow row = table.Rows[0];
                                tipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
                                if (tipoDeComprobante.Equals("CRMX"))
                                {
                                    idComprobante = (string)row["IdComprobante"];
                                    foreach (DataRow rowROD in this._dataRelacionesOrigenDestino.tpu_ComprobantesRelacionOrigenDestino.Rows)
                                    {
                                        rowROD["IdComprobanteOrigen"] = idComprobante;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Fin German 20110315 - Tarea 0000038

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			array.Add( (DataSet) this._dataComprobantes);
			array.Add( (DataSet) this._dataComprobantesDet);
			array.Add( (DataSet) this._dataMovimientosStock);
			array.Add( (DataSet) this._dataRelacionesOrigenDestino);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataComprobantes);
			data.Add( (DataSet) this._dataComprobantesDet);
			data.Add( (DataSet) this._dataMovimientosStock);
			data.Add( (DataSet) this._dataRelacionesOrigenDestino);
			data.Add( (DataSet) this._dataRelaciones);
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
			string IdVariable;
			if (ActualizaNumeracion && !_trasladaNumero) 
			{
				IdVariable = UpdateNumero(_dataComprobantes,IdTransaction);
			}
			else 
			{
				IdVariable = _dataComprobantes.tpu_Comprobantes.Rows[0]["Numero"].ToString();
			} 
			mz.erp.dataaccess.tpu_ComprobantesEx.Update(_dataComprobantes,_dataComprobantesDet,_dataMovimientosStock,_dataRelacionesOrigenDestino,
				IdVariable, _replication,IdTransaction, _dataRelaciones, _claveTablaAGuardar);
			_idComprobante = Convert.ToString(_dataComprobantes.tpu_Comprobantes.Rows[0]["IdComprobante"]);
			_numero = Convert.ToString(_dataComprobantes.tpu_Comprobantes.Rows[0]["Numero"]);
			
            // Matias
			foreach(DataRow row in _dataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.Rows)
			{
				if(!row.RowState.Equals(System.Data.DataRowState.Deleted))
				{
					if (row["IdComprobante"] == "nuevoValor")				
					{
						row["IdComprobante"] = _idComprobante;
					}
				}
			} 

			foreach(DataRow row in _dataProductosAuxiliares.tsh_ProductosAuxiliares.Rows)
			{
				if (row["IdComprobanteProximaRecepcionMercaderia"] == "nuevoValor")				
				{
					row["IdComprobanteProximaRecepcionMercaderia"] = _idComprobante;
				}
			} 

			mz.erp.dataaccess.tsh_ProductosPedidosPendientes.Update( _dataProductosPedidosPendientes.tsh_ProductosPedidosPendientes, IdTransaction );
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update( _dataProductosAuxiliares.tsh_ProductosAuxiliares, IdTransaction );
			// -- fin Matias

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		private static string UpdateNumero(tpu_ComprobantesDataset data, string IdTransaction)
		{
			foreach(System.Data.DataRow row1 in data.tpu_Comprobantes.Rows)
			{
				if (true) 
				{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"],IdTransaction);
					string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"],IdTransaction);

					return row.IdVariable;
				}
				
			}

			return null;
		}
	
		
		#endregion

		#region Variables privadas ITASK
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;


		
		#endregion
		
		#region Propiedades ITASK
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
		private string _textoCampoAuxiliar1 = "Campo Auxiliar 1";
		public string TextoCampoAuxiliar1
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar1." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar1;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar2 = "Campo Auxiliar 2";
		public string TextoCampoAuxiliar2
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar2." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar2;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar3 = "Campo Auxiliar 3";
		public string TextoCampoAuxiliar3
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar3." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar3;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar4 = "Campo Auxiliar 4";
		public string TextoCampoAuxiliar4
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar4." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar4;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _mascaraCampoAuxiliar1 = "\\A-####-########";
		public string MascaraCampoAuxiliar1
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar1." + "Mascara";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _mascaraCampoAuxiliar1;
				}
				else 
				{
					return valor;
				}
			}
		}

		

		#endregion

		#region Variables Privadas ComprobanteDeCompra

		private ItemComprobanteCompra _selectedItem;
		private DateTime _fechaRegistracion;
		private Proveedor _proveedor;
		private string _observaciones = string.Empty;
		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private decimal _campoAuxiliar4 = 0;
		private string _campoAuxiliar5 = string.Empty;
		private string _nombreCampo1 = string.Empty;
		private string _nombreCampo2 = string.Empty;
		private string _nombreCampo3 = string.Empty;
		private string _nombreCampo4 = string.Empty;
		private string _idResponsable = string.Empty;
		private string _momento = string.Empty;
		private ItemsComprobantesCompra _items;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		private bool _isStep = false;
		private bool _isEdit = false;
		private bool _isEditItems = false;
		private string _mascaraNumeroDefault= string.Empty;
		private string _idMonedaOrigen = string.Empty;
		private string _simboloMonedaOrigen = string.Empty;
		private string _simboloMonedaCierre = string.Empty;
		private string _idCotizacionCierre = string.Empty;
		private string _idFuenteDeCambioProveedor = string.Empty;
		private string _idFuenteDeCambioReferencia = string.Empty;
		private Cotizacion _cotizacionCierre = null;
		private Cotizacion _cotizacionProveedor = null;
		private decimal _valorCotizacionProveedor = 1;
	
		private bool _allowEditTipoDeComprobante = true;
		private bool _allowEditProveedor = true;
		private bool _allowEditFecha = true;
		private bool _allowEditFechaRegistracion = false;
		private bool _allowEditResponsableEmision = true;
		private bool _allowEditItems = true;
		private bool _allowEditNumeration = false;
		private bool _actualizaNumeracion = true;
		private bool _allowToValidateNumeracion = false;
		private bool _allowToValidateCampoAuxiliar1 = false;
		private bool _allowEditMonedaOrigen = false;
		private bool _allowEditValorCotizacion = false;
		private bool _allowEditFuenteDeCambio = false;
		private bool _allowDeleteItems = true;
		private bool _allowAddItems = true;
		private bool _allowEditCondicionDeCompra = true;
		private bool _allowValidateCondicionDeCompra = true;

		//German 20090422
		private bool _allowValidateItems = false;
		//Fin German 20090422
		private bool _allowToValidateItemsConMonto0 = false;
		private bool _allowToShowWarningItemsConMonto0 = false;

		private DataTable _tableMonedas;
		private DataTable _tableFuentesDeCambio;
		private DataTable _tableTiposDeComprobantesValidos;		
		private string  _listaTiposDeComprobantesValidos;

		private tpu_ComprobantesDataset _dataComprobantes = new tpu_ComprobantesDataset();
		private tpu_ComprobantesDetDataset _dataComprobantesDet = new tpu_ComprobantesDetDataset();
		private tlg_MovimientosDeStockDataset _dataMovimientosStock = new tlg_MovimientosDeStockDataset();
		private tpu_ComprobantesRelacionOrigenDestinoDataset _dataRelacionesOrigenDestino = new tpu_ComprobantesRelacionOrigenDestinoDataset();
		private DataSet _dataRelaciones = new DataSet();	
		private tsh_ProductosPedidosPendientesDataset _dataProductosPedidosPendientes = new tsh_ProductosPedidosPendientesDataset();
		private tsh_ProductosAuxiliaresDataset _dataProductosAuxiliares = new tsh_ProductosAuxiliaresDataset();

		private DataTable _tableResultStockNDias;
		private bool _usaListaDePreciosProveedor = false;
		
		private DateTime _fechaComprobanteOriginal;
		
        /* Silvina 20110526 - Tarea 0000048 */
        private bool _actualizaCondicionDeCompra = true;
        private string _condicionDeCompraDefault = "7";
        /* Fin Silvina 20110526 - Tarea 0000048 */

		/**
		Los valores posibles de esta propiedad son: OCRMX, OCFA, POCOC, FANC, RMXNC
		Si es OCRMX, se guarda en tpu_OrdenesDeComprasRemitos
		Si es OCFA, se guarda en tpu_OrdenesDeComprasFacturas
		Si es POCOC, se guarda en tpu_PreOrdenesDeComprasOrdenesDeCompras
		Si es FANC, se guarda en tpu_FacturasDevoluciones
		Si es RMXNC, se guarda en tpu_RemitosDevoluciones
		 */
		private string _claveTablaAGuardar = string.Empty; 

		//German 20090422
		public bool AllowValidateItems
		{
			get
			{
				return _allowValidateItems;
			}
		}
		//Fin German 20090422


		
		private bool _trasladaNumero = true;
		private CondicionDeCompra _condicionDeCompra = new CondicionDeCompra();

		private Hashtable _productoCantidadHashTable = new Hashtable();
		public Hashtable ProductoCantidadHashTable
		{
			get{return _productoCantidadHashTable;}
		}

		private Hashtable _productoCantidadTestearHashTable = new Hashtable();
		public Hashtable ProductoCantidadTestearHashTable
		{
			get{return _productoCantidadTestearHashTable;}
		}
		
		private bool _accionActualiza = false;
		public bool AccionActualiza
		{
			get{return _accionActualiza;}
			set{_accionActualiza = value;}
		}
		
		private bool _accionCancela = false;
		public bool AccionCancela
		{
			get{return _accionCancela;}
			set{_accionCancela = value;}
		}
	
		public bool TrasladaNumero
		{
			get{return _trasladaNumero;}
			set{_trasladaNumero = value;}
		}

        //German 20110309 - Tarea 0000038
        private RelacionesComprobanteDeCompraOrigenDestino _relacionesComprobantesDeCompraOrigenDestino;
        private bool _allowShow = true;
        //Fin German 20110309 - Tarea 0000038

		#endregion

		#region Propiedades ComprobanteDeCompra


        //German 20110309 - Tarea 0000038
        public RelacionesComprobanteDeCompraOrigenDestino RelacionesComprobanteDeCompraOrigenDestino
        {
            get
            {
                return _relacionesComprobantesDeCompraOrigenDestino;
            }
        }
        //Fin German 20110309 - Tarea 0000038
		public long DiasVencimientoPago
		{
			get{return _condicionDeCompra.DiasVencimiento;}
		}

		public string IdCondicionDeCompra
		{
			get
			{
				return _condicionDeCompra.IdCondicionDeCompra;
			}
			set
			{
				if(_condicionDeCompra.IdCondicionDeCompra != value)
				{
					_condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(value);
				}
			}
		}

		public string ClaveTabla
		{
			get{return _claveTablaAGuardar;}
		}

		public DataSet DataRelaciones
		{
			get{return _dataRelaciones;}
		}

		public DataTable TableResultStockNDias
		{
			get{return _tableResultStockNDias;}
		}

		public tsh_ProductosPedidosPendientesDataset  DataProductosPedidosPendientes
		{
			get{return _dataProductosPedidosPendientes;}
		}

		public tsh_ProductosAuxiliaresDataset DataProductosAuxiliares
		{
			get{return _dataProductosAuxiliares;}
		}
			
		public override string TipoComprobanteDestino
		{
			set 
			{
				if(_tipoComprobanteDestino != value)
				{
					if(value != null && value != string.Empty)
					{
						_tipoComprobanteDestino = value; 
						this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
						this.SetDirty(true);
						if(TipoDeComprobanteDestinoChanged != null)
							TipoDeComprobanteDestinoChanged(this, new EventArgs());
					}
				}
			}
			get { return _tipoComprobanteDestino ; }
		}


		

		public string SimboloMonedaOrigen 
		{
			get
			{
				return _simboloMonedaOrigen;
			}
			set
			{
				_simboloMonedaOrigen = value;
			}
		}

		public string SimboloMonedaCierre
		{
			get
			{
				return _simboloMonedaCierre;
			}
		}

		public Cotizacion CotizacionProveedor
		{
			get{return _cotizacionProveedor;}
		}

		public string IdDeposito
		{
			get{return _idDeposito;}
		}

		public string IdSeccion
		{
			get{return _idSeccion;}
		}

		public bool AllowEditValorCotizacion
		{
			get{return _allowEditValorCotizacion;}
		}



		public bool AllowEditMonedaOrigen
		{
			get{return _allowEditMonedaOrigen;}
		}

		public bool AllowEditFuenteDeCambio
		{
			get{return _allowEditFuenteDeCambio;}
		}

		public decimal ValorCotizacion 
		{
			get
			{
				if(_cotizacionCierre != null)
				{
					return _cotizacionCierre.Valor;
				}
				return 1;
			}
		}
		public DataTable TableMonedas
		{
			get{return _tableMonedas;}
		}

		public DataTable TableFuentesDeCambio
		{
			get{return _tableFuentesDeCambio;}
		}

		public decimal ValorCotizacionProveedor
		{
			get
			{
				return _valorCotizacionProveedor;
			}
			set
			{
				_valorCotizacionProveedor = value;
				if(_cotizacionProveedor != null)
					_cotizacionProveedor.Valor = value;
				updatePrecios();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}

		public string IdMonedaOrigen 
		{
			get{return this._idMonedaOrigen;}
			set
			{
				if(value == null) value = string.Empty;
				if(_idMonedaOrigen != value)
				{
					
					_idMonedaOrigen = value;
					this._simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(this.IdMonedaOrigen);
					GetConversion();
					updatePrecios();
					if(IdMonedaOrigenChanged != null)
						IdMonedaOrigenChanged(this, new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}


		public string IdFuenteDeCambioProveedor
		{
			get{return _idFuenteDeCambioProveedor;	}
			set
			{
				if(value != _idFuenteDeCambioProveedor)
				{
					_idFuenteDeCambioProveedor = value;
					GetConversion();
					updatePrecios();
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

			}
		
		}
		
		public bool IsStep
		{
			get{return _isStep;}
		}
		
		public bool IsEdit
		{
			get{return _isEdit;}
		}


		public DateTime FechaEmision
		{
			get{return _fechaComprobante;}
			set
			{
				if(_fechaComprobante != value)
				{
					_fechaComprobante = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
					System.TimeSpan result = _fechaRecepcionMercaderia.Subtract(aux);
					if(result.Days >= 0)
						_diasDemoraEntrega = result.Days;
					else _diasDemoraEntrega = 0;
					if(DiasDemoraEntregaChanged != null)
						DiasDemoraEntregaChanged(this, new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}

		public bool FechaEmisionModificada
		{
			get{return !_fechaComprobante.Equals(_fechaComprobanteOriginal);}
		}

		public string IdCotizacionCierre
		{
			get
			{
				if(_cotizacionCierre != null)
					return _cotizacionCierre.IdCotizacion;
				return string.Empty;
			}
		}
		
		public object SelectedItem
		{
			get{return _selectedItem;}
			set{_selectedItem = ((ItemComprobanteCompra)value);}
		}

		public decimal TotalMonedaReferencia
		{
			get
			{
				return this._items.TotalMonedaReferencia;
			}
		}

		public decimal TotalReal
		{
			get
			{
				return this._items.TotalReal;
			}
		}

		public decimal NetoOriginal
		{
			get
			{
				return _items.NetoOriginal;
			}
		}

		public decimal Neto 
		{
			get
			{
				return _items.Neto;

			}
		}

		public DataTable TableTiposDeComprobantesValidos
		{
			get
			{
				return _tableTiposDeComprobantesValidos;
			}
		}

		public bool AllowEditTipoDeComprobante
		{
			set { _allowEditTipoDeComprobante = value; }
			get { return _allowEditTipoDeComprobante; }
		}


		public bool AllowEditProveedor
		{
			set { _allowEditProveedor = value; }
			get { return _allowEditProveedor; }
		}


		public bool AllowEditFecha
		{
			set { _allowEditFecha = value; }
			get { return _allowEditFecha; }
		}

		public bool AllowEditFechaRegistracion
		{
			set { _allowEditFechaRegistracion = value; }
			get { return _allowEditFechaRegistracion; }
		}


		public bool AllowToValidateCampoAuxiliar1
		{
			set{_allowToValidateCampoAuxiliar1 = value;}
			get{return _allowToValidateCampoAuxiliar1 ;}
		}
	
		public bool AllowToValidateNumeracion
		{
			set{_allowToValidateNumeracion = value;}
			get{return _allowToValidateNumeracion ;}
		}

		public bool AllowEditResponsableEmision
		{
			set { _allowEditResponsableEmision = value; }
			get { return _allowEditResponsableEmision; }
		}
		public bool AllowEditItems
		{
			set { _allowEditItems = value; }
			get { return _allowEditItems; }
		}

		public bool AllowEditCondicionDeCompra
		{
			get{return _allowEditCondicionDeCompra;}
		}


		public bool AllowDeleteItems
		{
			set { _allowDeleteItems = value; }
			get { return _allowDeleteItems; }
		}
		public bool AllowAddItems
		{
			set { _allowAddItems = value; }
			get { return _allowAddItems; }
		}	
		
		public bool ActualizaNumeracion 
		{
			set { _actualizaNumeracion = value;}
			get { return _actualizaNumeracion; }
		}

		public bool AllowEditNumeration
		{
			set { _allowEditNumeration = value;}
			get { return _allowEditNumeration; }
		}

		private bool _allowEditDiasDemoraEntrega = false;
		public bool AllowEditDiasDemoraEntrega
		{
			get{return _allowEditDiasDemoraEntrega;}
		}

		private bool _allowEditFechaRecepcionMercaderia = false;
		public bool AllowEditFechaRecepcionMercaderia
		{
			get{return _allowEditFechaRecepcionMercaderia;}
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
		}

        /* Silvina 20100531 - Tarea 646 */
        private bool _seleccionaUltimo = false;
        public bool SeleccionaUltimo
        {
            get { return _seleccionaUltimo; }
        }
        /* Fin Silvina */

		public tpu_ComprobantesDataset DataComprobantes
		{
			get{return _dataComprobantes;}
		}

		public tpu_ComprobantesDetDataset DataComprobantesDet
		{
			get{return _dataComprobantesDet;}
		}

		public tlg_MovimientosDeStockDataset DataMovimientosStock
		{
			get{return _dataMovimientosStock;}
		}

		public tpu_ComprobantesRelacionOrigenDestinoDataset DataRelacionesOrigenDestino
		{
			get{return _dataRelacionesOrigenDestino;}
		}

		public string Momento
		{
			get {return _momento;}
		}
		public Proveedor Proveedor
		{
			get{return _proveedor;}
		}

		public string IdResponsable
		{
			get{return _idResponsable;}
			set
			{
				if(_idResponsable != value)
				{
					_idResponsable = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

			}
		}

		public string IdProveedor
		{
			get
			{
				if(_proveedor != null)
					return _proveedor.IdProveedor;
				else return string.Empty;
			}
			set
			{
				if(_proveedor != null)
				{
					if(_proveedor.IdProveedor != value)
					{
						_proveedor.IdProveedor = value;
						UpdateFromProveedor();
						UpdatePreciosFromProveedor();
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}

			}
		}
		public string CodigoProveedor
		{
			get
			{
				if(_proveedor != null)
					return _proveedor.Codigo;
				else return string.Empty;
			}
		}

		public DateTime FechaRegistracion
		{
			get{return _fechaRegistracion;}
			set
			{
				if(_fechaRegistracion != value)
				{
					_fechaRegistracion = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		public string Observaciones
		{
			get{return _observaciones;}
			set
			{
				if(_observaciones!= value)
				{
					_observaciones = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		public string CampoAuxiliar1
		{
			get{return _campoAuxiliar1;}
			set
			{
				if(_campoAuxiliar1 != value)
				{
					_campoAuxiliar1 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					

				}
			}
		}

		public string CampoAuxiliar2
		{
			get{return _campoAuxiliar2;}
			set
			{
				if(_campoAuxiliar2 != value)
				{
					_campoAuxiliar2 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}

		public string CampoAuxiliar3
		{
			get{return _campoAuxiliar3;}
			set
			{
				if(_campoAuxiliar3 != value)
				{
					_campoAuxiliar3 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					

				}
			}
		}

		public decimal CampoAuxiliar4
		{
			get{return _campoAuxiliar4;}
			set
			{
				if(_campoAuxiliar4 != value)
				{
					_campoAuxiliar4 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}

//		Matias
		public string CampoAuxiliar5
		{
			get{return _campoAuxiliar5;}
			set
			{
				if(_campoAuxiliar5 != value)
				{
					_campoAuxiliar5 = value;
//					if(ObjectHasChanged != null)
//						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}

		public string Numero
		{
			get{return _numero;}
			set
			{
				if(_numero != value)
				{
					_numero = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
		
			}

		}

		public string NombreCampo1
		{
			get{return _nombreCampo1;}
		}

		public string NombreCampo2
		{
			get{return _nombreCampo2;}
		}

		public string NombreCampo3
		{
			get{return _nombreCampo3;}
		}

		public string NombreCampo4
		{
			get{return _nombreCampo4;}
		}

		public string _prodAuxIdComprobanteProximaRecepcionMercaderiaOriginal = string.Empty;
		public string ProdAuxIdComprobanteProximaRecepcionMercaderiaOriginal
		{
			get { return this._prodAuxIdComprobanteProximaRecepcionMercaderiaOriginal; }
			set { this._prodAuxIdComprobanteProximaRecepcionMercaderiaOriginal = value; }
		}

		public ItemsComprobantesCompra Items
		{
			get { return this._items; }
			set { this._items = value; }
		}


		private bool _categoriaImpositivaProveedorAfectaTipoDeComprobanteDestino = false;
		public bool CategoriaImpositivaProveedorAfectaTipoDeComprobanteDestino
		{
			set { _categoriaImpositivaProveedorAfectaTipoDeComprobanteDestino = value;}
		}

		private DateTime _fechaRecepcionMercaderia = mz.erp.businessrules.Sistema.DateTime.Now;
		
		// ---- Matias - 20090903 (Para modificar bug en PPP)
		private DateTime _fechaRecepcionMercaderiaAnterior = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idComprobanteAnterior = string.Empty;
		// ---- FinMatias

		private int _diasDemoraEntrega = 0;		
		public int DiasDemoraEntrega
		{
			get{return _diasDemoraEntrega;}
			set
			{
				if(_diasDemoraEntrega != value && value >= 0)
				{
					_diasDemoraEntrega = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
					_fechaRecepcionMercaderia = aux.AddDays(_diasDemoraEntrega);
					if(DiasDemoraEntregaChanged != null)
						DiasDemoraEntregaChanged(this, new EventArgs());
				}
			}
		}

		public  DateTime FechaRecepcionMercaderia
		{
			get{return _fechaRecepcionMercaderia;}
			set
			{
				if(_fechaRecepcionMercaderia != value)
				{
					_fechaRecepcionMercaderia = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_fechaComprobante);
					System.TimeSpan result = _fechaRecepcionMercaderia.Subtract(aux);
					if(result.Days >= 0)
						_diasDemoraEntrega = result.Days;
					else _diasDemoraEntrega = 0;
					if(FechaRecepcionMercaderiaChanged != null)
						FechaRecepcionMercaderiaChanged(this, new EventArgs());

				}
			}
		}
		
		public  DateTime FechaRecepcionMercaderiaAnterior
		{
			get{return _fechaRecepcionMercaderiaAnterior;}
			set{_fechaRecepcionMercaderia = value;}
		}
		public string IdComprobanteAnterior
		{
			get{return _idComprobanteAnterior;}
			set{_idComprobanteAnterior = value;}
		}

        /* Silvina 20110526 - Tarea 0000048 */

        private bool ActualizaCondicionDeCompra
        {
            get { return _actualizaCondicionDeCompra; }
            set { _actualizaCondicionDeCompra = value; }
        }

        private string CondicionDeCompraDefault
        {
            get { return _condicionDeCompraDefault; }
            set { _condicionDeCompraDefault = value; }
        }

        /* Fin Silvina 20110526 - Tarea 0000048 */
			
		#endregion

		/*Este metodo se llama cuando se actualizan las siguientes propiedades: 
		 * 
		 * IdMonedaOrigen, IdFuenteDeCambioProveedor y ValorCotizacionProveedor
		 */ 

		public void RemoveItem(ItemComprobanteCompra item)
		{
			this._items.RemoveItem(item, true);
		}

		public void AddItems(ArrayList items)
		{
			this.UpdatePreciosFromProveedor(items);
			this._items.AddRange(items, true);
			if(AddItemsChanged != null)
				AddItemsChanged(this, new EventArgs());
		}
		 
		private void updatePrecios()
		{
			/*
			Cotizacion cotiz = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioProveedor);
			if(cotiz == null)
				cotiz = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioReferencia);
			this._valorCotizacionProveedor = cotiz.Valor;
			foreach(ItemComprobanteCompra item in _items)
			{
				item.SimboloPrecioReal = this.SimboloMonedaOrigen;
				item.ValorCotizacionPrecioReal = this.ValorCotizacionProveedor;
				item.PrecioReal = (item.PrecioDeCosto * item.ValorCotizacionPrecioDeCosto) / item.ValorCotizacionPrecioReal;
			}
			*/
			_items.SetCotizacion(this._valorCotizacionProveedor, this._idMonedaOrigen, this._simboloMonedaOrigen, this._idFuenteDeCambioProveedor);
			
		}
		private void GetConversion()
		{
			
			_cotizacionCierre = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMonedaOrigen, this._idMonedaCierre, this._idFuenteDeCambioReferencia);
			_idCotizacionCierre = _cotizacionCierre.IdCotizacion;
			_cotizacionProveedor.IdFuenteDeCambio = this._idFuenteDeCambioProveedor;
			_cotizacionProveedor.IdMonedaOrigen = this._idMonedaOrigen;
			_cotizacionProveedor.Valor = this._valorCotizacionProveedor;
			
		}

	
		private void _items_ObjectHasChanged(object sender, EventArgs e)
		{
			Refresh();
		}

		private void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}
		public string ProcessName()
		{
			return this._processParent.Process.ProcessName;
		}

		public void SetItems(ItemsComprobantesCompra items)
		{			
			RelacionesComprobanteDeCompraOrigenDestino rels = new RelacionesComprobanteDeCompraOrigenDestino();
			foreach(ItemComprobanteCompra icc in items)
			{
				RelacionComprobanteDeCompraOrigenDestino rel;
//				rel = new RelacionComprobanteDeCompraOrigenDestino(_idComprobante, icc.IdTipoComprobanteOrigen, _campoAuxiliar1,
//						icc.Ordinal, icc.Cantidad,icc.Cantidad, icc.IdProducto, icc.DescripcionLarga, icc.PrecioDeCosto,
//						Security.IdSucursal, Security.IdEmpresa, icc.Codigo, icc.CodigoSecundario, this._fechaComprobante, this._fechaRecepcionMercaderia, false, false);
				rel = new RelacionComprobanteDeCompraOrigenDestino(_idComprobante, icc.IdTipoComprobanteOrigen, _campoAuxiliar1,
						icc.Ordinal, icc.Cantidad,icc.Cantidad, icc.IdProducto, icc.DescripcionLarga, icc.PrecioDeCosto,
						Security.IdSucursal, Security.IdEmpresa, icc.Codigo, icc.CodigoSecundario, this._fechaComprobante, this._fechaRecepcionMercaderia, false, false, 
						icc.CampoAuxiliar1, icc.CampoAuxiliar2, icc.CampoAuxiliar3, icc.CampoAuxiliar4, icc.CampoAuxiliar5, string.Empty, string.Empty, string.Empty, DateTime.MinValue, DateTime.MinValue );
				rel.MiProducto = icc.MiProducto;
				rels.Add(rel);
			}
			ItemsComprobantesCompra ItemsCC = new ItemsComprobantesCompra("STEP", this, rels);
			_items = ItemsCC;
						
		}

		public string FillNumberWithZeros(string txt)
		{
			string separator = 	Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) (	Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) (	Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		//German 20090407
		private void Items_ItemsChanged(object sender, EventArgs e)
		{
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());
		}
		//Fin German 20090407


	}

	#region Clases Internas
		
	public class Proveedor
	{
		#region Constructor
			
		public Proveedor(string IdProveedor)
		{
			Init(IdProveedor);
		}


		#endregion

		#region Variables Privadas
		private string _idProveedor = string.Empty;
		private string _codigo = string.Empty;
		private string _proveedor = string.Empty;
		private string _domiclio = string.Empty;
		private string _tipoDocumento = string.Empty;
		private string _documento = string.Empty;
		private string _idCategoriaIva = string.Empty;
		private string _idCuentaImputacion = string.Empty;
		private string _idSubcuentaImputacion = string.Empty;
		private bool _isValid = false;

		private CondicionDeCompra _condicionDeCompra = new CondicionDeCompra();

		private long _idCondicionRetencionGanancias = -1;
		private string _condicionRetencionGanancias = string.Empty;
		private decimal _alicuotaRetencionGanancias = 0;
		private bool _aplicaRetencionGanancias = false;
		private bool _excluyeRetencionIIBB = false;
		private bool _excluyeRetencionIVA = false;

		private int _mesRetencion = 0;
		private int _añoRetencion = 0;
		private decimal _montoPagos = 0;
		private decimal _montoRetenciones = 0;
		private long _idConceptoImpuestoGanacias = -1;
		private bool _isFirstRetecionGanancias = false;

		private decimal _nuevoMontoPagos = 0;
		private decimal _nuevoMontoRetenciones = 0;

		private decimal _alicuotaRetencionIIBBServicios = 0;
		private decimal _alicuotaRetencionIIBBCompras = 0;

		tpu_ProveedoresDetallePagoImpuestoGananciasDataset _dataProveedoresDetallePagoImpuestoGanancias = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();


		public tpu_ProveedoresDetallePagoImpuestoGananciasDataset DataProveedoresDetallePagoImpuestoGanancias 
		{
			get{return _dataProveedoresDetallePagoImpuestoGanancias;}
		}

		tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow _row;

		public void CommitDetallePagoImpuestoGanancias()
		{
			
			if(_isFirstRetecionGanancias)
			{
				_row = _dataProveedoresDetallePagoImpuestoGanancias.tpu_ProveedoresDetallePagoImpuestoGanancias.Newtpu_ProveedoresDetallePagoImpuestoGananciasRow();
				mz.erp.businessrules.tpu_ProveedoresDetallePagoImpuestoGanancias.SetRowDefaultValues(_row);
				_row.IdDetallePago = 0; 
				_row.Mes = _mesRetencion;
				_row.Anio = _añoRetencion;
				_row.TotalPago = _nuevoMontoPagos;
				_row.TotalRetenciones = _nuevoMontoRetenciones;
				_row.IdConceptoImpuestoGanancias = 2;
				_row.IdProveedor = _idProveedor;
				_dataProveedoresDetallePagoImpuestoGanancias.tpu_ProveedoresDetallePagoImpuestoGanancias.Addtpu_ProveedoresDetallePagoImpuestoGananciasRow(_row);

			}
			else
			{
				if(_row != null)
				{
					_row.TotalPago = _nuevoMontoPagos;
					_row.TotalRetenciones = _nuevoMontoRetenciones;
					_dataProveedoresDetallePagoImpuestoGanancias.tpu_ProveedoresDetallePagoImpuestoGanancias.ImportRow(_row);
				}
			}
		}

		public void GetRetencionesGanancias(int Año, int Mes)
		{
			if(_idProveedor != null && _idProveedor != string.Empty)
			{
				_mesRetencion = Mes;
				_añoRetencion = Año;
				_row = mz.erp.businessrules.tpu_ProveedoresDetallePagoImpuestoGanancias.GetByPeriodo(_idProveedor,Año, Mes);
				if(_row == null)
				{
					_isFirstRetecionGanancias = true;
				}
				else
				{
					_montoPagos = _row.TotalPago;
					_montoRetenciones = _row.TotalRetenciones;
					_idConceptoImpuestoGanacias = _row.IdConceptoImpuestoGanancias;
					_isFirstRetecionGanancias = false;
				}
			}
			else _row = null;
		}

		public void SetRetencionesGanancias(decimal MontoPagos, decimal MontoRetenciones)
		{
			_nuevoMontoPagos = MontoPagos;
			_nuevoMontoRetenciones = MontoRetenciones;
		}


		public decimal AlicuotaRetencionIIBBServicios
		{
			get{return _alicuotaRetencionIIBBServicios;}
		}


		public decimal AlicuotaRetencionIIBBCompras
		{
			get{return _alicuotaRetencionIIBBCompras;}
		}

		public decimal MontoPagos
		{
			get{return _montoPagos;}
		}

		public decimal MontoRetenciones
		{
			get{return _montoRetenciones;}
		}



		public long IdCondicionRetencionGanancias
		{
			get{return _idCondicionRetencionGanancias;}
		}

		public string CondicionRetencionGanancias
		{
			get{return _condicionRetencionGanancias;}
		}

		public decimal AlicuotaRetencionGanancias
		{
			get{return _alicuotaRetencionGanancias;}
		}

		public bool AplicaRetencionGanancias
		{
			get{return _aplicaRetencionGanancias;}
		}

		public bool ExcluyeRetencionIIBB
		{
			get{return _excluyeRetencionIIBB;}
		}

		public bool ExcluyeRetencionIVA
		{
			get{return _excluyeRetencionIVA;}
		}




		#endregion

		#region Propiedades

		public decimal Recargo
		{
			get{return _condicionDeCompra.Recargo;}
		}

		public long DiasVencimiento
		{
			get{return _condicionDeCompra.DiasVencimiento;}
		}

		public long Orden
		{
			get{return _condicionDeCompra.Orden;}
		}


		public string Descripcion
		{
			get{return _condicionDeCompra.Descripcion;}
		}

		public string IdCondicionDeCompra
		{
			get{return _condicionDeCompra.IdCondicionDeCompra;}
		}

		
				
		public string IdProveedor
		{
			get{return _idProveedor;}
			set
			{
				Init(value);
			}
		}

		public bool IsValid
		{
			get{return _isValid;}
		}


		public string IdSubcuentaImputacion
		{
			get{return _idSubcuentaImputacion;}
		}

		public string IdCuentaImputacion
		{
			get{return _idCuentaImputacion;}
		}

		public string IdCategoriaIva
		{
			get{return _idCategoriaIva;}
		}



		public string Nombre
		{
			get{return _proveedor;}
		}

		public string Domicilio
		{
			get{return _domiclio;}
		}
		
		public string Codigo
		{
			get{return _codigo;}
		}

		public string TipoDocumento
		{
			get{return _tipoDocumento;}
		}

		public string Documento
		{
			get{return _documento;}
		}



		#endregion

		#region Metodos
		
		public void Init(string IdProveedor)
		{
			if(!IdProveedor.Equals(_idProveedor))
			{
				tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.businessrules.tpu_Proveedores.GetByPk(IdProveedor);
				if(row != null)
				{
					_idProveedor = row.IdProveedor;
					_codigo = row.Codigo;
					_proveedor = row.Nombre;
					_domiclio = row.Domicilio;
					_tipoDocumento = row.idTipoDocumento;
					_documento = row.Numero;
					_idCategoriaIva = row.IdCategoriaIva;
					_idCuentaImputacion = row.IdTipoMovimiento;
					_idSubcuentaImputacion = row.IdSubTipoMovimiento;
					_isValid = true;
					_condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(row.IdCondicionDeCompra);
					_excluyeRetencionIIBB = row.ExcluyeRetencionIIBB;
					_excluyeRetencionIVA = row.ExcluyeRetencionIVA;
					_idCondicionRetencionGanancias = row.CondicionImpuestoGanancias;
					_alicuotaRetencionIIBBCompras = row.AlicuotaRetencionIIBBCompras;
					_alicuotaRetencionIIBBServicios= row.AlicuotaRetencionIIBBServicios;
					DataRow rowC = mz.erp.businessrules.tpu_ProveedoresCondicionesImpuestoGanancias.GetByPk(_idCondicionRetencionGanancias);
					if(rowC != null)
					{
						_condicionRetencionGanancias = Convert.ToString(rowC["Descripcion"]);
						_alicuotaRetencionGanancias = Convert.ToDecimal(rowC["Alicuota"]);
						_aplicaRetencionGanancias = Convert.ToBoolean(rowC["AplicaImpuesto"]);
					}
					else
					{
						_idCondicionRetencionGanancias = -1;
						_condicionRetencionGanancias = string.Empty;
						_alicuotaRetencionGanancias = 0;
						_aplicaRetencionGanancias = false;
					}
					
				}
				else
				{
					_isValid = false;
					_idProveedor = string.Empty;
					_codigo = string.Empty;
					_proveedor = string.Empty;
					_domiclio = string.Empty;
					_tipoDocumento = string.Empty;
					_documento = string.Empty;
					_idCategoriaIva = string.Empty;
					_idCuentaImputacion = string.Empty;
					_idSubcuentaImputacion = string.Empty;
					_condicionDeCompra = CondicionesDeComprasFactory.GetCondicionDeCompraInstance(string.Empty);
					_idCondicionRetencionGanancias = -1;
					_condicionRetencionGanancias = string.Empty;
					_alicuotaRetencionGanancias = 0;
					_aplicaRetencionGanancias = false;
					_alicuotaRetencionIIBBCompras = 0;
					_alicuotaRetencionIIBBServicios = 0;


				}
				
			}
		}

		#endregion

	}

	//German 20080407
	public class ItemsComprobantesCompra:CollectionBase, System.ComponentModel.ITypedList
	//Fin German 20080407
	{
		#region Constructores
		public ItemsComprobantesCompra(string action ,ComprobanteDeCompra parent)
		{
			this._parent = parent;
			Init(action, null, null);
		}

		public ItemsComprobantesCompra(string action, ComprobanteDeCompra parent, RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			this._parent = parent;
			Init(action, relaciones, null);

		}

		public ItemsComprobantesCompra(string action, ComprobanteDeCompra parent, string IdComprobante )
		{
			this._parent = parent;
			Init(action, null, IdComprobante);

		}
		#endregion

		#region Eventos
			
			public event EventHandler ObjectHasChanged;
			public event EventHandler NetoItemsOriginalChanged;
			//German 20090407
			public event EventHandler ItemsChanged;
			//Fin German 20090407
		
			
		#endregion

		#region inicializadores


		
		private void Init( string action, RelacionesComprobanteDeCompraOrigenDestino relaciones, string IdComprobante)
		{
			switch (action.ToUpper())
			{
				case "NEW":
					break;
				case "EDIT":
					FillEditData(IdComprobante);
					break;
				case "STEP":
					FillStepData( relaciones );
					break;
			}

		}
		private void FillEditData( string IdComprobante)
		{			
			long idSucursal = Security.IdSucursal;
			long idEmpresa = Security.IdEmpresa;
			tpu_ComprobantesDetDataset detComprobantes = tpu_ComprobantesDet.GetList(IdComprobante);
			foreach(tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow rowDet in detComprobantes.tpu_ComprobantesDet.Rows)
			{	
				if (idSucursal != rowDet.IdSucursal)
				{
					idSucursal = rowDet.IdSucursal;
					idEmpresa = rowDet.IdEmpresa;
				}
				
				Productos miProducto = new mz.erp.businessrules.Productos( rowDet.IdProducto, rowDet.IdSucursal, rowDet.IdEmpresa );
	
				mz.erp.businessrules.comprobantes.Item item = new Item();
				
				item.IdProducto = rowDet.IdProducto;
				item.Codigo = miProducto.Codigo;
				item.CantidadOrigen = rowDet.Cantidad;
				item.Cantidad = rowDet.Cantidad;
					

				item.OrdinalOrigen = long.MinValue;
				item.IdComprobanteOrigen = null;
				item.IdTipoComprobanteOrigen = null;
				
				item.OrdinalDestino = rowDet.Ordinal;
				
				item.Descripcion = miProducto.Descripcion;
				item.DescripcionCorta = miProducto.DescripcionCorta;
				item.DescripcionLarga = miProducto.DescripcionLarga;

				item.CampoAuxiliar1 = miProducto.CampoAuxiliar1;
				item.CampoAuxiliar2 = miProducto.CampoAuxiliar2;
				item.CampoAuxiliar3 = miProducto.CampoAuxiliar3;
				item.CampoAuxiliar4 = miProducto.CampoAuxiliar4;
				item.CampoAuxiliar5 = miProducto.CampoAuxiliar5;					
				item.PrecioCostoBase = rowDet.PrecioDeCostoMonedaOrigen;
				item.PrecioCosto = rowDet.PrecioDeCostoMonedaOrigen;

				item.ValorCotizacionPrecioCosto = _parent.ValorCotizacionProveedor;
				item.ValorCotizacionPrecioCostoBase = _parent.ValorCotizacionProveedor;
				item.SimboloMonedaPrecioCosto = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(_parent.IdMonedaOrigen);
				item.SimboloMonedaPrecioCostoBase = item.SimboloMonedaPrecioCosto;
                
				ItemComprobanteCompra miItemComprobante = new ItemComprobanteCompra("EDIT",item, this );					
				//Sabri TODO ver de donde saco el producto
				//miItemComprobante.MiProducto = relacion.MiProducto;
				this.Add(miItemComprobante);
				
			}
			
		}


		private void FillStepData( RelacionesComprobanteDeCompraOrigenDestino relaciones )
		{
			long idSucursal = Security.IdSucursal;
			long idEmpresa = Security.IdEmpresa;
			foreach(RelacionComprobanteDeCompraOrigenDestino relacion in relaciones)
			{	
				if (idSucursal != relacion.IdSucursal)
				{
					idSucursal = relacion.IdSucursal;
					idEmpresa = relacion.IdEmpresa;
				}
				
				if (relacion.CantidadDestino > 0)
				{
					//System.Data.DataRow row = (System.Data.DataRow)mz.erp.businessrules.tpu_ComprobantesDet.GetByPk( relacion.IdComprobante, relacion.OrdinalOrigen );
					//Comentado 11/1/2008 Oscar y German. El precio de costo ya está pasando en el constructor

					Productos miProducto = new mz.erp.businessrules.Productos( relacion.IdProducto, relacion.IdSucursal, relacion.IdEmpresa );
				
					mz.erp.businessrules.comprobantes.Item item = new Item();
					item.IdProducto = relacion.IdProducto;
					item.Codigo = miProducto.Codigo;
					item.CantidadOrigen = relacion.CantidadOrigen;
					item.Cantidad = relacion.CantidadDestino;
					item.IdTipoProducto = miProducto.IdTipoProducto;

					item.OrdinalOrigen =relacion.OrdinalOrigen;
					item.IdComprobanteOrigen = relacion.IdComprobante;
					item.IdTipoComprobanteOrigen = relacion.IdTipoDeComprobante;
				
					item.OrdinalDestino = this.Count;
				
					item.Descripcion = miProducto.Descripcion;
					item.DescripcionCorta = miProducto.DescripcionCorta;
					item.DescripcionLarga = miProducto.DescripcionLarga;

					item.CampoAuxiliar1 = miProducto.CampoAuxiliar1;
					item.CampoAuxiliar2 = miProducto.CampoAuxiliar2;
					item.CampoAuxiliar3 = miProducto.CampoAuxiliar3;
					item.CampoAuxiliar4 = miProducto.CampoAuxiliar4;
					item.CampoAuxiliar5 = miProducto.CampoAuxiliar5;					
					//item.PrecioCosto = (decimal)row["PrecioDeCosto"];	
					item.PrecioCostoBase = relacion.PrecioDeCosto;
					item.PrecioCosto = relacion.PrecioDeCosto;
					item.ValorCotizacionPrecioCosto = relaciones.ValorCotizacionProveedor;
					item.ValorCotizacionPrecioCostoBase = relaciones.ValorCotizacionProveedor;
					item.SimboloMonedaPrecioCosto = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(relaciones.IdMonedaOrigen);
					item.SimboloMonedaPrecioCostoBase = item.SimboloMonedaPrecioCosto;
					item.OrigenMultiple = relacion.OrigenMultiple;

					item.Origenes = new ArrayList( relacion.Origenes);

					//item.Origenes = relacion.Origenes;

					item.ObligaCodigoBarra = miProducto.ObligaCodigoBarra;
					item.CodigoSecundario = miProducto.CodigoSecundario;


					/*Poner Variable por Proceso Tarea para ver si acumula los items y q politica de precios elegir
									 * Por ahora se aplica la politica menor precio de Orden De Compra
									 * */
					if(_parent.ProcessName().Equals("ProcesoOrdenDeCompraIngresarMercaderia") )
					{
						if(!this.Contains(item.IdProducto))
						{
							item.OrigenMultiple = true;
							ItemComprobanteCompra miItemComprobante = new ItemComprobanteCompra("STEP",item, this );					
							RelacionComprobanteDeCompraOrigen origen = new RelacionComprobanteDeCompraOrigen(miItemComprobante.IdComprobanteOrigen,miItemComprobante.OrdinalOrigen, miItemComprobante.CantidadOrigen, miItemComprobante.Cantidad, miItemComprobante.PrecioDeCosto);
							miItemComprobante.AddOrigen(origen);
							miItemComprobante.MiProducto = relacion.MiProducto;
							// matias 09/10/08
							miItemComprobante.CantidadPendiente = relacion.CantidadPendiente;
							// --
							this.Add(miItemComprobante);
						}
						else
						{
							ItemComprobanteCompra miItemComprobante = (ItemComprobanteCompra)this.GetByIdProducto(item.IdProducto)[0]	;			
							RelacionComprobanteDeCompraOrigen origen = new RelacionComprobanteDeCompraOrigen(item.IdComprobanteOrigen,item.OrdinalOrigen, item.CantidadOrigen, item.Cantidad, item.PrecioCosto);
							miItemComprobante.AddOrigen(origen);
							miItemComprobante.Cantidad = miItemComprobante.Cantidad  + origen.CantidadOrigenPendiente;
							// matias 09/10/08
							miItemComprobante.CantidadPendiente = relacion.CantidadPendiente;
							// --
							if(origen.PrecioDeCostoOrigen <= miItemComprobante.PrecioDeCosto)
								miItemComprobante.PrecioDeCosto = origen.PrecioDeCostoOrigen;

						}
					}
					else
					{
						ItemComprobanteCompra miItemComprobante = new ItemComprobanteCompra("STEP",item, this );					
						miItemComprobante.MiProducto = relacion.MiProducto;
						// matias 09/10/08
						miItemComprobante.CantidadPendiente = relacion.CantidadPendiente;
						// --
						this.Add(miItemComprobante);
					}
				
					
				}
			}
			
		}

		

		#endregion

		#region Variables Privadas

		private ComprobanteDeCompra _parent;

		#endregion

		#region Propiedades

		public System.Collections.IList List
		{
			get{return base.List;}
		}

		public void SetCotizacion(decimal ValorCotizacionProveedor, string IdMonedaOrigen, 
			string SimboloMonedaOrigen,string IdFuenteDeCambioProveedor)
		{
			foreach(ItemComprobanteCompra item in this.List)
			{
				if(!item.Estado.Equals("DEL"))
				{
					item.IdMonedaPrecioDeCosto = IdMonedaOrigen;
					item.SimboloPrecioDeCosto = SimboloMonedaOrigen;
					item.IdFuenteDeCambioPrecioDeCosto = IdFuenteDeCambioProveedor;
					item.ValorCotizacionPrecioDeCosto = ValorCotizacionProveedor;
					if(!item.Estado.Equals("NEW"))
						item.Estado = "MODIF";

				}
			}

		}

		
		public ComprobanteDeCompra Parent
		{
			get{return _parent;}
			set{_parent = value;}
		}

		
		public decimal TotalMonedaReferencia
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.TotalMonedaReferencia;
				}
				return total;
			}
		}
		
		public decimal Total
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.Total;
				}
				return total;
			}
		}

		public decimal TotalReal
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.TotalReal;
				}
				return total;
			}
		}

		public long Ordinal
		{
			get
			{
				if(List.Count == 0)
					return 0;
				else
					return ((ItemComprobanteCompra)List[List.Count - 1]).Ordinal + 1;
			}

		}

		public decimal NetoOriginal
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.PrecioCompraOriginal * item.CantidadCompraOriginal;
				}
				return total;
			}
		}

		public decimal Neto 
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.PrecioDeCosto * item.Cantidad;
				}
				return total;
			}
		}

		public decimal NetoMonedaReferencia 
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteCompra item in this.List)
				{	
					total += item.PrecioDeCostoMonedaReferencia * item.Cantidad;
				}
				return total;
			}
		}

		private string _itemsConMonto0 = string.Empty;
		public bool ExistenItemsConMonto0
		{
			get
			{
				bool ok = false;
				_itemsConMonto0 = string.Empty;
				foreach (ItemComprobanteCompra item in List)
				{
					if (item.PrecioDeCosto==0)
					{
						ok=true;
						_itemsConMonto0 = _itemsConMonto0 + "El item "+ item.Codigo +" posee Monto = 0. ";
					}			
				}
				return ok;
			}
		}

		public string ItemsConMonto0
		{
			set{_itemsConMonto0 = value;}
			get{return _itemsConMonto0;}
		}

		#endregion

		#region Override Metodos de CollectionBase

		
		public void Add(Item item)
		{
			this.Add(new ItemComprobanteCompra(item, this), true);
			

		}
		public void Add(ItemComprobanteCompra item, bool _objectHasChanged)
		{
			List.Add(item);
			item.CantidadCompraOriginalChanged +=new EventHandler(NetoItemsOriginalChangedManager);
			item.PrecioCompraOriginalChanged +=new EventHandler(NetoItemsOriginalChangedManager);
			//German 20090407
			item.CantidadChanged += new EventHandler(CantidadChanged);
			item.PrecioDeCostoChanged +=new EventHandler(PrecioDeCostoChanged);
			//Fin German 20090407
			if(_objectHasChanged)
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());

		}

		public void AddRange(ArrayList items, bool mustFireEvent)
		{
			foreach(Item item in items)
			{
				this.Add(new ItemComprobanteCompra(item, this), false);
			}
			if(items.Count > 0 && mustFireEvent)
			{
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}

		}
		public void RemoveItem(ItemComprobanteCompra item, bool mustFireEvent)
		{
			if(!item.Estado.Equals("NEW"))
				item.Estado = "DEL";
			if(mustFireEvent)
			{
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}

		}
		
		public virtual void Add( ItemComprobanteCompra item )
		{
			this.Add ( item, true );
		}

		public virtual	int IndexOf(ItemComprobanteCompra item)
		{
			int index = 0;
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (!it.IdProducto.Equals(item.IdProducto))
					index++;
			}
			return index;

		}

		public  bool Contains( ItemComprobanteCompra item )
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.IdProducto.Equals(item.IdProducto))
					return true;
			}
			return false;
		}

		public  bool Contains( string IdProducto)
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.IdProducto.Equals(IdProducto))
					return true;
			}
			return false;
		}

		public bool Contains(ItemComprobante item)
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.IdProducto.Equals(item.IdProducto))
					return true;
			}
			return false;

		}

		public bool Contains(string codigo, long ordinal)
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.Codigo.Equals(codigo) && it.Ordinal.Equals(ordinal))
					return true;
			}
			return false;

		}

		public virtual void Add( ComprobanteDeCompra sender, ItemComprobanteCompra item )
		{
			this.Parent = sender;
			this.Add(item);
		}
		
		public virtual void Remove( object item )
		{
			List.Remove( item );
		}

		public virtual void Remove( ItemComprobanteCompra item )
		{
			Remove( (object)item );
		}


		#endregion

		#region Metodos

		
		//German 20090407
		private void CantidadChanged(object sender, EventArgs e)
		{
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());
		}
		private void PrecioDeCostoChanged(object sender, EventArgs e)
		{
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());
		}
		//Fin German 20090407

		private void NetoItemsOriginalChangedManager(object sender, EventArgs e)
		{
			if(NetoItemsOriginalChanged != null)
				NetoItemsOriginalChanged(this, new EventArgs());
		}

		public void Commit(bool IsEdit)
		{
			foreach (ItemComprobanteCompra item in List)
			{
				item.Commit(IsEdit);
			}
		}

		public ArrayList GetByIdProducto(string IdProducto)
		{
			ArrayList result = new ArrayList();
			foreach(ItemComprobanteCompra item in this.List)
			{
				if(item.IdProducto.Equals(IdProducto))
					result.Add(item);
			}
			return result;
		}


		

		#endregion

		//German 20080407
		#region Miembros de ITypedList

		public System.ComponentModel.PropertyDescriptorCollection GetItemProperties ( System.ComponentModel.PropertyDescriptor[] listAccessors )
		{
			if(listAccessors == null)
			{
				return System.ComponentModel.TypeDescriptor.GetProperties(typeof(ItemComprobanteCompra));
			}
			return null;
		}

		public  System.String GetListName ( System.ComponentModel.PropertyDescriptor[] listAccessors )
		{
			return "";
		}
		//Fin German 20080407
		#endregion

	
	}

	public class ItemComprobanteCompra

	{
		
		/* Un objeto de esta clase representa un item de un comprobante de compra.
		 * La propiedad PrecioDeCosto se almacena en la moneda origen de comprobante, y se mapea con la columna
		 * PrecioDeCostoMonedaOrigen de la tabla tpu_comprobantesDet
		 * La propiedad PrecioDeCostoReferencia se almacena en la moneda de referencia del sistema y se mapea con la columna
		 * PrecioDeCosto de la tabla tpu_comprobantesDet (por compatibilidad con lo q estaba echo ya de compras)
		 * La propiedad PrecioDeCostoBase se almacena en la moneda en la que este el precio de costo al tomarlo d
		 * de un determinado origen. Es la base a partir del cual se obtiene el precio de costo en la moneda origen.
		 *  
		 * */
		
		#region Constructores
		
		public ItemComprobanteCompra()
		{
		}

		public ItemComprobanteCompra(Item item, ItemsComprobantesCompra items)
		{
			this.IdProducto = item.IdProducto;
			this._descripcion = item.Descripcion;
			this._descripcionOriginal = item.Descripcion;
			this._descripcionCorta = item.DescripcionCorta;
			this._descripcionLarga = item.DescripcionLarga;
			this._descripcionLargaOriginal = item.DescripcionLarga;
			this._codigo = item.Codigo;
			this._cantidad = Math.Abs(item.Cantidad) ;
			this._precioDeCosto = item.PrecioCosto;
			this._idComprobanteOrigen = null;
			this._ordinalOrigen = long.MinValue;
			this._idTipoComprobanteOrigen = null;
			this.ItemsComprobantes = items;
			this._ordinal = this.ItemsComprobantes.Ordinal;
			this._campoAuxiliar1 = item.CampoAuxiliar1;
			this._campoAuxiliar2 = item.CampoAuxiliar2;
			this._campoAuxiliar3 = item.CampoAuxiliar3;
			this._campoAuxiliar4 = item.CampoAuxiliar4;
			this._campoAuxiliar5 = item.CampoAuxiliar5;		

			this._simboloPrecioDeCosto = item.SimboloMonedaPrecioCosto;
			this._valorCotizacionPrecioDeCosto = item.ValorCotizacionPrecioCosto;
			this._simboloPrecioDeCostoBase = item.SimboloMonedaPrecioCostoBase;
			this._precioDeCostoBase = item.PrecioCostoBase;
			this._valorCotizacionPrecioDeCostoBase = item.ValorCotizacionPrecioCostoBase;
			this._precioDeCostoMonedaReferencia = _precioDeCosto * _valorCotizacionPrecioDeCosto;
			this._estado = "NEW";

			//this._impuestos = new Impuestos("NEW", this );
		}

		public ItemComprobanteCompra(string action, mz.erp.businessrules.comprobantes.Item item, ItemsComprobantesCompra items)


		{	
			this.ItemsComprobantes = items;
			Init(action, item);
		}

		#endregion
		
		#region Inicializadores
		private void Init( string action, mz.erp.businessrules.comprobantes.Item item )
		{
			switch (action.ToUpper())
			{
				case "NEW":
					FillLoadData( action, item );
					break;
				case "EDIT":
					FillLoadData( action, item );
					break;
				case "STEP":
					FillLoadData( action, item );
			
					break;
			}

		}
		
		private void FillLoadData( string action, mz.erp.businessrules.comprobantes.Item item )
		{
			switch (action.ToUpper())
			{
				case "NEW":
				{
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._cantidad = Math.Abs(item.Cantidad) * this.ItemsComprobantes.Parent.Signo;
					this._precioDeCosto = item.PrecioCosto;

					this._idComprobanteOrigen = null;
					this._ordinalOrigen = long.MinValue;
					this._idTipoComprobanteOrigen = null;
					this._ordinal = this.ItemsComprobantes.Ordinal;
					this._codigo = item.Codigo;
					this._codigoSecundario = item.CodigoSecundario;
					this._campoAuxiliar1 = item.CampoAuxiliar1;
					this._campoAuxiliar2 = item.CampoAuxiliar2;
					this._campoAuxiliar3 = item.CampoAuxiliar3;
					this._campoAuxiliar4 = item.CampoAuxiliar4;
					this._campoAuxiliar5 = item.CampoAuxiliar5;		
					this._idTipoProducto = item.IdTipoProducto;
					this._estado = "NEW";
					break;
				}
				case "EDIT":
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._cantidad = item.Cantidad;
					this._precioDeCosto = item.PrecioCosto;;
					this._idComprobanteOrigen = item.IdComprobanteOrigen;
					this._ordinalOrigen = item.OrdinalOrigen;
					this._ordinal = item.OrdinalDestino;
					this._idTipoComprobanteOrigen = item.IdTipoComprobanteOrigen;
					this._codigo = item.Codigo;
					this._codigoSecundario = item.CodigoSecundario;

					this._campoAuxiliar1 = item.CampoAuxiliar1;
					this._campoAuxiliar2 = item.CampoAuxiliar2;
					this._campoAuxiliar3 = item.CampoAuxiliar3;
					this._campoAuxiliar4 = item.CampoAuxiliar4;
					this._campoAuxiliar5 = item.CampoAuxiliar5;		
					this._simboloPrecioDeCosto = item.SimboloMonedaPrecioCosto;
					this._valorCotizacionPrecioDeCosto = item.ValorCotizacionPrecioCosto;
					this._simboloPrecioDeCostoBase = item.SimboloMonedaPrecioCostoBase;
					this._precioDeCostoBase = item.PrecioCostoBase;
					this._valorCotizacionPrecioDeCostoBase = item.ValorCotizacionPrecioCostoBase;
					this._precioDeCostoMonedaReferencia = this._precioDeCosto * this._valorCotizacionPrecioDeCosto;
					this._origenMultiple  = item.OrigenMultiple;
					this._origenes = item.Origenes;
					this._estado = "";
					break;
				case "STEP":
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._cantidad = item.Cantidad;
					this._cantidadOrigen = item.CantidadOrigen;
					this._precioDeCosto = item.PrecioCosto;
					this._idComprobanteOrigen = item.IdComprobanteOrigen;
					this._ordinalOrigen = item.OrdinalOrigen;
					this._ordinal = item.OrdinalDestino;
					this._idTipoComprobanteOrigen = item.IdTipoComprobanteOrigen;
					this._codigo = item.Codigo;
					this._codigoSecundario = item.CodigoSecundario;
					this._campoAuxiliar1 = item.CampoAuxiliar1;
					this._campoAuxiliar2 = item.CampoAuxiliar2;
					this._campoAuxiliar3 = item.CampoAuxiliar3;
					this._campoAuxiliar4 = item.CampoAuxiliar4;
					this._campoAuxiliar5 = item.CampoAuxiliar5;		
					this._simboloPrecioDeCosto = item.SimboloMonedaPrecioCosto;
					this._valorCotizacionPrecioDeCosto = item.ValorCotizacionPrecioCosto;
					this._simboloPrecioDeCostoBase = item.SimboloMonedaPrecioCostoBase;
					this._precioDeCostoBase = item.PrecioCostoBase;
					this._valorCotizacionPrecioDeCostoBase = item.ValorCotizacionPrecioCostoBase;
					this._precioDeCostoMonedaReferencia = this._precioDeCosto * this._valorCotizacionPrecioDeCosto;
					this._origenMultiple  = item.OrigenMultiple;
					this._origenes = item.Origenes;
					this._idTipoProducto = item.IdTipoProducto;
					this._estado = "";
					this._obligaCodigoBarra = item.ObligaCodigoBarra;
					break;
			}

		}
	



		#endregion

		#region Eventos

			public event EventHandler CantidadCompraOriginalChanged;
			public event EventHandler PrecioCompraOriginalChanged;
			//German 20090407
			public event EventHandler CantidadChanged;
			public event EventHandler PrecioDeCostoChanged;
			//Fin German 20090407

		#endregion

		#region Variables Privadas		
		
		private string _estado = string.Empty;
		private Producto _producto = null;
		private string _idProducto = string.Empty;
		private decimal _cantidad = 0;
		private decimal _cantidadOrigen = 0;
		private long _ordinal = 0;
		private long _ordinalOrigen = 0;
		private decimal _precioDeCosto = 0;
		private decimal _precioDeCostoBase = 0;
		private decimal _precioDeCostoMonedaReferencia=0;
		private string _idComprobanteOrigen = string.Empty;
		private string _idTipoComprobanteOrigen = string.Empty;
		private Impuestos _impuestos;
		private ItemsComprobantesCompra _itemsComprobantes;
		private string _descripcionLargaOriginal = string.Empty;
		private string _descripcionOriginal = string.Empty;
		private string _descripcionLarga = string.Empty;
		private string _descripcionCorta = string.Empty;
		private string _descripcion = string.Empty;
		private string _codigo = string.Empty;
		private string _codigoSecundario = string.Empty;
		private string _visualizacionStock = string.Empty;
		private string _estadoStock = string.Empty;
		private decimal _cantStock = 0;
		private decimal _cantStockPropio = 0;

		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private string _campoAuxiliar4 = string.Empty;
		private string _campoAuxiliar5 = string.Empty;

		private bool _allowEdit = true;

		private string _simboloPrecioDeCosto = string.Empty;
		private string _idMonedaPrecioDeCosto = string.Empty;
		private string _idCotizacionPrecioDeCosto = string.Empty;
		private string _idFuenteDeCambioPrecioDeCosto = string.Empty;
		private decimal _valorCotizacionPrecioDeCosto = 1;

		private string _simboloPrecioDeCostoBase = string.Empty;
		private string _idMonedaPrecioDeCostoBase = string.Empty;
		private string _idCotizacionPrecioDeCostoBase = string.Empty;
		private string _idFuenteDeCambioPrecioDeCostoBase = string.Empty;
		private decimal _valorCotizacionPrecioDeCostoBase = 1;

		private string _simboloPrecioReal = string.Empty;
		private decimal _precioReal = 0;
		private decimal _valorCotizacionPrecioReal = 1;
		private decimal _cantidadPendiente = 0;

		private OrdenDeCompraItem _ordenCompraItem;

		private bool _origenMultiple = false;
		private ArrayList _origenes = new ArrayList();

		private string _idTipoProducto = string.Empty;
		
        private bool _obligaCodigoBarra = false;


		#endregion

		#region Variables Publicas

		
		public bool ObligaCodigoBarra
		{
			get{return _obligaCodigoBarra;}
		}

		public string IdTipoProducto
		{
			get{return _idTipoProducto;}
		}


		public string Estado 
		{
			get{return _estado;}
			set{_estado = value;}
		}


		public OrdenDeCompraItem OrdenCompraItem
		{
			get{return _ordenCompraItem;}
			set{_ordenCompraItem = value;}
		}

		public string IdComprobanteOrigen
		{
			get{return _idComprobanteOrigen;}
		}

		public decimal CantidadOrigen
		{
			get{return _cantidadOrigen;}
		}

		public long OrdinalOrigen
		{
			get{return _ordinalOrigen;}
		}

		public Producto MiProducto
		{
			get{return _producto;}
			set{_producto = value;}
		}

		public string SimboloPrecioDeCostoBase
		{
			get{return _simboloPrecioDeCostoBase;}
			set{_simboloPrecioDeCostoBase = value;}
		}

		public decimal ValorCotizacionPrecioDeCostoBase
		{
			get{return _valorCotizacionPrecioDeCostoBase;}
			set
			{
				if(_valorCotizacionPrecioDeCostoBase != value)
				{
					_valorCotizacionPrecioDeCostoBase = value;
					_precioDeCosto = (_precioDeCostoBase * _valorCotizacionPrecioDeCostoBase)/_valorCotizacionPrecioDeCosto;
					_precioDeCostoMonedaReferencia = _precioDeCosto * _valorCotizacionPrecioDeCosto;
				}
			}
		}

		public string IdCotizacionPrecioDeCostoBse
		{
			get{return _idCotizacionPrecioDeCostoBase;}
			set{_idCotizacionPrecioDeCostoBase = value;}
		}

		public string IdFuenteDeCambioPrecioDeCostoBase
		{
			get{return _idFuenteDeCambioPrecioDeCostoBase;}
			set{_idFuenteDeCambioPrecioDeCostoBase = value;}
					
		}

		public string IdMonedaPrecioDeCostoBase
		{
			get{return _idMonedaPrecioDeCostoBase;}
			set{_idMonedaPrecioDeCostoBase = value;}
		}

		public string SimboloPrecioDeCosto
		{
			get{return _simboloPrecioDeCosto;}
			set{_simboloPrecioDeCosto = value;}
		}

		public decimal ValorCotizacionPrecioDeCosto
		{
			get{return _valorCotizacionPrecioDeCosto;}
			set
			{
				if(_valorCotizacionPrecioDeCosto != value && value > 0)
				{
					_precioDeCosto = _precioDeCosto * _valorCotizacionPrecioDeCosto / value;
					_valorCotizacionPrecioDeCosto = value;
					_precioDeCostoMonedaReferencia = _precioDeCosto * _valorCotizacionPrecioDeCosto;
					_precioDeCostoBase = (_precioDeCosto * _valorCotizacionPrecioDeCosto) / _valorCotizacionPrecioDeCostoBase;
				}
			}
		}

		public string IdCotizacionPrecioDeCosto
		{
			get{return _idCotizacionPrecioDeCosto;}
			set{_idCotizacionPrecioDeCosto = value;}
		}

		public string IdFuenteDeCambioPrecioDeCosto
		{
			get{return _idFuenteDeCambioPrecioDeCosto;}
			set{_idFuenteDeCambioPrecioDeCosto = value;}
					
		}

		public string IdMonedaPrecioDeCosto
		{
			get{return _idMonedaPrecioDeCosto;}
			set{_idMonedaPrecioDeCosto = value;}
		}

		public decimal CantidadPendiente
		{
			get{return _cantidadPendiente;}
			set{_cantidadPendiente = value;}
		}


		/*

		public string SimboloPrecioReal
		{
			get{return _simboloPrecioReal;}
			set{_simboloPrecioReal = value;}
		}

		public decimal PrecioReal
		{
			get{return _precioReal;}
			set{_precioReal = value;}
		}

		public decimal ValorCotizacionPrecioReal
		{
			get{return _valorCotizacionPrecioReal;}
			set{_valorCotizacionPrecioReal = value;}
		}

		*/

		public bool AllowEdit
		{
			get{return _allowEdit;}
			set{_allowEdit = value;}
		}


		public string CampoAuxiliar1
		{
			set {_campoAuxiliar1 = value;}
			get {return _campoAuxiliar1 ;}
		}
		public string CampoAuxiliar2
		{
			set {_campoAuxiliar2 = value;}
			get {return _campoAuxiliar2 ;}
		}
		public string CampoAuxiliar3
		{
			set {_campoAuxiliar3 = value;}
			get {return _campoAuxiliar3 ;}
		}
		public string CampoAuxiliar4
		{
			set {_campoAuxiliar4 = value;}
			get {return _campoAuxiliar4 ;}
		}
		public string CampoAuxiliar5
		{
			set {_campoAuxiliar5 = value;}
			get {return _campoAuxiliar5 ;}
		}
		
		public ItemsComprobantesCompra ItemsComprobantes
		{
			get { return _itemsComprobantes; }
			set {_itemsComprobantes = value;}
		}

		public decimal PrecioDeCostoBase
		{
			get{return _precioDeCostoBase;}
			set
			{
				if(_precioDeCostoBase != value)
				{
					_precioDeCostoBase = value;
					_precioDeCosto = (_precioDeCostoBase * _valorCotizacionPrecioDeCostoBase)/ _valorCotizacionPrecioDeCosto;
					_precioDeCostoMonedaReferencia = _precioDeCosto * _valorCotizacionPrecioDeCosto;
				}
			}
		}

		public decimal PrecioDeCosto
		{
			get{return _precioDeCosto;}
			set
			{
				if(_precioDeCosto!= value && !this._estado.Equals("DEL"))
				{
					_precioDeCosto = value;
					_precioDeCostoMonedaReferencia = _precioDeCosto * _valorCotizacionPrecioDeCosto;
					_precioDeCostoBase = (_precioDeCosto * _valorCotizacionPrecioDeCosto) / _valorCotizacionPrecioDeCostoBase;
					if(!this._estado.Equals("NEW"))
						this._estado = "MODIF";
					//German 20090407
					if(PrecioDeCostoChanged != null)
						PrecioDeCostoChanged(this, new EventArgs());
					//Fin German 20090407
				}
			}

		}

		public decimal PrecioDeCostoMonedaReferencia
		{
			get{return _precioDeCostoMonedaReferencia;}
			set
			{
				if(_precioDeCostoMonedaReferencia != value)
				{
					_precioDeCostoMonedaReferencia = value;
					_precioDeCosto = _precioDeCostoMonedaReferencia / _valorCotizacionPrecioDeCosto;
					_precioDeCostoBase = (_precioDeCosto * _valorCotizacionPrecioDeCosto) / _valorCotizacionPrecioDeCostoBase;
				}
			}

		}

		public string Descripcion
		{
			set 
			{
				if (ComprobantesRules.Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion)
				{

					if (value != _descripcion)
					{
						_descripcion = value;
						
					}
				}
			}
			get {return _descripcion ;}
		}

		public string DescripcionLarga
		{
			set 
			{
				if (true)
				{
					if (value != _descripcionLarga)
					{
						_descripcionLarga = value;
					}
				}
				
			}
			get{return _descripcionLarga ;}
		}

		public decimal TotalMonedaReferencia
		{
			get
			{
				return _cantidad * _precioDeCostoMonedaReferencia;
			}
		}

		public decimal Total
		{
			get
			{
				return _cantidad * _precioDeCosto;
			}
		}
		
		public decimal TotalReal
		{
			get
			{
				return _cantidad * _precioReal;
			}
		}

		public decimal Cantidad
		{
			set 
			{
				if (value != _cantidad && !this._estado.Equals("DEL"))
				{
					_cantidad = Math.Abs(value) * this.ItemsComprobantes.Parent.Signo;
					if(!this._estado.Equals("NEW"))
                        this._estado = "MODIF";
					//German 20090407
					if(CantidadChanged != null)
						CantidadChanged(this, new EventArgs());
					//Fin German 20090407
					
				}
				
			}
			get {return _cantidad;}
		}
		public string IdTipoComprobanteOrigen
		{
			get { return _idTipoComprobanteOrigen ; }
		}
		/// <summary>
		/// Precio del item
		/// Indica el precio Neto una vez aplicado todos las bonificaciones y recargos directos e indirecto. 
		/// Excluido impuestos
		/// </summary>
		/*	public decimal Precio
			{
				set
				{
					if (true)/*(Variables.GetValueBool("Comprobante.Seguridad.Productos.PermiteDescuentos"))
					{
						if (_precio != value)
						{
							_precio = value;
							//_isPrecioChanged = true;
							//this.IsDirty=true;
							//if (OnRecalcItem != null)
							//{
							//	OnRecalcItem( this, new System.EventArgs() );
							//}
						
						}
					}
				}
				get
				{
					return _precio;
				}
			}

			/// <summary>
			/// Precio Neto + Impuestos Directos e Indirectos aplicados al item.
			/// </summary>
			public decimal PrecioConImpuestos
			{
				get
				{
					return _precio + FuncionesImpuestos.ObtenerValor( this._impuestos );
				}
			}

			/// <summary>
			/// Precio Neto + Impuestos Directos aplicados al item
			/// </summary>
			public decimal PrecioConImpuestosDirectos
			{
				get
				{
					return _precio + FuncionesImpuestos.ObtenerValorAplicado( this._impuestos, Constantes.ImpuestosAplicadosAProductos ) ;
				}
			}

			/// <summary>
			/// Retorna coleccion de impuestos directos aplicados al item.
			/// </summary>
			public Impuestos ImpuestosDirectos 
			{
				get
				{
					return FuncionesImpuestos.ObtenerColeccionImpuestos( this._impuestos, Constantes.ImpuestosAplicadosAProductos );
				}
			}

			/// <summary>
			/// Retorna la coleccion de impuestos indirectos aplicados al item.
			/// </summary>
			public Impuestos ImpuestosIndirectos
			{
				get
				{
					return FuncionesImpuestos.ObtenerColeccionImpuestosNoAplicados( this._impuestos, Constantes.ImpuestosAplicadosAProductos );
				}
			}
			/// <summary>
			/// Cantidad * Precio
			/// </summary>
			public decimal SubTotalNeto
			{
				get 
				{
					return _cantidad * _precio;
				}
			}
			/// <summary>
			/// Cantidad * Precio Con Impuestos Directos
			/// </summary>
			public decimal SubTotalConImpuestosDirectos
			{
				get
				{
					return _cantidad * PrecioConImpuestosDirectos;
				}
			}
			/// <summary>
			/// Cantidad * Precio Con Impuestos Directos e Indirectos
			/// </summary>
			public decimal SubTotalConImpuestos
			{
				get
				{
					return _cantidad * PrecioConImpuestos;
				}
			}
		
		*/
		/// <summary>
		/// Identificador unico del producto. Relacion con IdProducto de la tabla Productos
		/// </summary>
		/// 
		
		public string IdProducto
		{
			get { return _idProducto; }
			set {_idProducto = value ;}
		}

		/// <summary>
		/// Retorna el porcentaje de bonificacion que aplica la cuenta
		/// </summary>
		/*	public decimal BonificacionRecargoCuenta
			{
				get
				{
					return this._itemsComprobantes.ComprobanteDeVenta.Cuenta.BonificacionCuenta;
				}
			}*/

		/// <summary>
		/// Retorna el importe de la bonificacion que se aplica en forma directa al producto
		/// </summary>
		/*	public decimal BonificacionRecargoProducto
			{
				set
				{
					//this.IsDirty= true;
					_bonificacionRecargoProducto = value;
					//AplicarBonificaciones();
				}
				get
				{
					return _bonificacionRecargoProducto;
				}
			}
			/// <summary>
			/// Retorna el porcentaje de la bonificacion que se aplica en forma directa al producto
			/// </summary>
			public decimal BonificacionRecargoProductoPorcentual
			{
				set
				{
					//this.IsDirty = true;
					BonificacionRecargoProducto = (_precioDeVentaBruto*value /100);
				}
				get
				{
					if (_precioDeVentaBruto != 0)
					{
						return Convert.ToDecimal(_bonificacionRecargoProducto * 100 / _precioDeVentaBruto);
					}
					else
					{
						return 0;
					}

				}
			}

			/// <summary>
			/// Retorna el porcentaj de la bonificacion que se aplica por las condiciones financieras del pago del comprobante
			/// </summary>
			public decimal BonificacionRecargoFinanciero
			{
				get
				{
					return _bonificacionRecargoFinanciero;
				}
			}

			/// <summary>
			/// Determina la bonificacion porcentual final aplicada según el procedimiento de <see cref="AplicarBonificaciones"/>
			/// </summary>
			public decimal BonificacionPorcentual
			{
				get
				{
					return _bonificacion;
				}
			}
			/// <summary>
			/// Determina la bonificacion monetaria final aplicada según el procedimiento de <see cref="AplicarBonificaciones"/>
			/// </summary>
			public decimal BonificacionMonetaria
			{
				get
				{
					return Convert.ToDecimal(_precioDeVentaBruto * _bonificacion / 100);
				}
			}

			/// <summary>
			/// Precio de Venta bruto. Tambien conocido como precio de lista.
			/// No incluye impuestos ni recargos ni bonificaciones.
			/// Es el precio inicial de un producto sin que se le aplique ningun tipo de cargo o bonificacion por todo concepto.
			/// </summary>
			public decimal PrecioDeVentaBruto
			{
				get
				{
					return _precioDeVentaBruto;
				}
				set
				{
					_precioDeVentaBruto = value;
					//_isPrecioChanged = true;
	//				AplicarBonificaciones();
					//this.IsDirty=true;
					//if (OnRecalcItem != null)
					//{
					//	OnRecalcItem( this, new System.EventArgs() );
					//}
						

				}
			}
			*/
		/// <summary>
		/// Retorna el Codigo del Producto. Clave Unica de identificación para el usuario. 
		/// El Id del Producto es interno de la base de datos. La clave unica es la codificacion
		/// que utiliza el cliente para visualizar los productos.
		/// </summary>
		public string Codigo
		{
			get {return _codigo;}
		}

		public string CodigoSecundario
		{
			get {return _codigoSecundario;}
		}
		/// <summary>
		/// Posicion con respecto a la coleccion de items
		/// </summary>
		public long Ordinal
		{
			get{return _ordinal;}
			set{_ordinal = value;}
		}

		public string VisualizacionStock
		{
			get{return _visualizacionStock;}
			set{_visualizacionStock = value;}
		}

		public string EstadoStock
		{		
			get{return _estadoStock;}
			set{_estadoStock = value;}
		}

		public decimal  CantStock
		{
			get{return _cantStock;}
			set{_cantStock = value;}
		}

		public decimal  CantStockPropio
		{
			get{return _cantStockPropio;}
			set{_cantStockPropio = value;}
		}

		public Impuestos Impuestos
		{
			get{return _impuestos;}
		}

		private decimal _cantidadCompraOriginal = 0;
		public decimal CantidadCompraOriginal 
		{
			get { return _cantidadCompraOriginal;}
			set 
			{
				if(_cantidadCompraOriginal != value)
				{
					_cantidadCompraOriginal = value; 
					if(CantidadCompraOriginalChanged != null)
						CantidadCompraOriginalChanged(this, new EventArgs());
				}
				
			}
		}
		private decimal _precioCompraOriginal = 0;
		public decimal PrecioCompraOriginal 
		{
			get {return _precioCompraOriginal;	}
			set 
			{
				if(_precioCompraOriginal != value)
				{
					_precioCompraOriginal = value; 
					if(PrecioCompraOriginalChanged != null)
						PrecioCompraOriginalChanged(this, new EventArgs());
				}
			}
		}
		


		#endregion

		#region Metodos 

		public void AddOrigen(RelacionComprobanteDeCompraOrigen origen)
		{
			this._origenes.Add(origen);
			
		}
			
		public void Commit(bool isEdit)
		{
			this.CommitDetalle( this.ItemsComprobantes.Parent.DataComprobantesDet, isEdit);
			//this.CommitMovimientosDeStock(this.ItemsComprobantes.Parent.DataMovimientosStock);
			this.CommitRelacionOrigenDestino(this.ItemsComprobantes.Parent.DataRelacionesOrigenDestino, isEdit);
			switch (this.ItemsComprobantes.Parent.ClaveTabla)
			{
					//OCRMX, OCFA, POCOC, FANC, RMXNC
				case "OCRMX" : CommitOrdenesDeComprasRemitos((tpu_OrdenesDeComprasRemitosDataset)this.ItemsComprobantes.Parent.DataRelaciones);break;
			}
			//Matias - tarea 29 - 20081007
			this.ActualizarProductosPendientes();
			//--
		}

		public int _prodAuxCantOriginal = 0;
		public int ProdAuxCantOriginal
		{
			get { return _prodAuxCantOriginal; }
			set { this._prodAuxCantOriginal = value; }
		}

		private void ActualizarProductosPendientes()
		{
			// Recupero el IdComprobanteProximaRecepcionMercaderia de Productos Auxiliares				
			if ( this.ItemsComprobantes.Parent.ProdAuxIdComprobanteProximaRecepcionMercaderiaOriginal.Equals(String.Empty) )
			{
				tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowAux = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto);
				if (rowAux == null)
					rowAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.IdProducto);
				if (rowAux != null)
					this.ItemsComprobantes.Parent.ProdAuxIdComprobanteProximaRecepcionMercaderiaOriginal = rowAux.IdComprobanteProximaRecepcionMercaderia;
			}           	
			if ( !this._estado.Equals("DEL") )
			{			
				// De acuerdo al tipo de variable, ingreso(o actualizo) o cierro(y actualizo)
				if (this.ItemsComprobantes.Parent.AccionActualiza) 
				{
					// Intenta recuperar el Producto de PPP --> en caso de edicion de POCP
					string idComprobante = "nuevoValor";
					tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPPPexistente = dataaccess.tsh_ProductosPedidosPendientes.GetByIdComprobanteIdProductoOrdinal(this.ItemsComprobantes.Parent.IdComprobante, this._idProducto, this.Ordinal, false);
					if (rowPPPexistente == null)
					{
						// 1º Crea una nueva fila en tsh_ProductosPedidosPendientes
						tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowNueva = this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.Newtsh_ProductosPedidosPendientesRow();
						mz.erp.businessrules.tsh_ProductosPedidosPendientes.SetRowDefaultValues(rowNueva);
					
						rowNueva.IdComprobante = idComprobante; // Poner le valor real en ComprobanteDeCompra.Flush
						rowNueva.IdConexionCreacion = Security.IdConexion;
						rowNueva.IdEmpresa = Security.IdEmpresa;
						rowNueva.IdSucursal = Security.IdSucursal;
						rowNueva.IdConexionUltimaModificacion = Security.IdConexion;
						rowNueva.IdProducto = this.IdProducto;
						rowNueva.IdProveedor = this.ItemsComprobantes.Parent.IdProveedor;
						rowNueva.Cantidad = this.Cantidad;
						rowNueva.FechaRecepcion = this.ItemsComprobantes.Parent.FechaRecepcionMercaderia;
						rowNueva.Ordinal = this.Ordinal;
						if (rowNueva.FechaCierre.Equals(DateTime.MinValue))
							rowNueva.SetFechaCierreNull();
					
						this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.Addtsh_ProductosPedidosPendientesRow( rowNueva );
					}						
					else
					{
						// El producto esta PPP. (en Edicion)
						idComprobante = rowPPPexistente.IdComprobante;
						rowPPPexistente.IdProveedor = this.ItemsComprobantes.Parent.IdProveedor;
						rowPPPexistente.Cantidad = this.Cantidad;
						rowPPPexistente.FechaRecepcion = this.ItemsComprobantes.Parent.FechaRecepcionMercaderia;
											
						this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPPPexistente );
					}
					
					// 2º Actualizo, si existe, la tabla tsh_ProductosAuxiliares, sino agrego una nueva fila.
					tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowAux = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto);
					if (rowAux == null)
						rowAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.IdProducto);
					
					if (rowAux != null)
					{
						// Agrega IdProducto en el hashTable para tener la cantidad de los Productos
						if ( this.ItemsComprobantes.Parent.ProductoCantidadHashTable.ContainsKey(this.IdProducto) )
						{
							Decimal valor = (Decimal)this.ItemsComprobantes.Parent.ProductoCantidadHashTable[this.IdProducto] + this.Cantidad;
							this.ItemsComprobantes.Parent.ProductoCantidadHashTable.Remove(this.IdProducto);
							this.ItemsComprobantes.Parent.ProductoCantidadHashTable.Add(this.IdProducto, valor);
						}
						else 
							this.ItemsComprobantes.Parent.ProductoCantidadHashTable.Add(this.IdProducto, this.Cantidad);
						
						/* aca va el metodo que limpia las Date NULL */
						mz.erp.systemframework.Util.ReplaceNullDateWithDBNull(rowAux,"FechaRecepcion");

						if ( this.ItemsComprobantes.Parent.ProcessName().Equals("ProcesoEditarPreOrdenDeCompra") )
						{
							if ( this.ItemsComprobantes.Parent.IdComprobanteAnterior.Equals( rowAux.IdComprobanteProximaRecepcionMercaderia) )
							{
								System.Data.SqlTypes.SqlDateTime datetime = System.Data.SqlTypes.SqlDateTime.MinValue;
								rowAux.FechaRecepcion = this.ItemsComprobantes.Parent.FechaRecepcionMercaderia;
								rowAux.Cantidad = (Decimal)this.ItemsComprobantes.Parent.ProductoCantidadHashTable[this.IdProducto];
								rowAux.IdProveedor = this.ItemsComprobantes.Parent.IdProveedor;
								if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
									this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowAux );
							}
						}

						if ( (this.ItemsComprobantes.Parent.FechaRecepcionMercaderia <= rowAux.FechaRecepcion) | (rowAux.FechaRecepcion.Equals(DateTime.MinValue) ) )
						{
							// (FechaMenorIgual o FechaVacia) 
							System.Data.SqlTypes.SqlDateTime datetime = System.Data.SqlTypes.SqlDateTime.MinValue;
							rowAux.FechaRecepcion = this.ItemsComprobantes.Parent.FechaRecepcionMercaderia;
							rowAux.Cantidad = (Decimal)this.ItemsComprobantes.Parent.ProductoCantidadHashTable[this.IdProducto]; //rowNueva.Cantidad;
							rowAux.IdComprobanteProximaRecepcionMercaderia = idComprobante; // Poner le valor real en ComprobanteDeCompra.Flush
							rowAux.IdProveedor = this.ItemsComprobantes.Parent.IdProveedor;
							if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
								this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowAux );
						}
						else
						{
							if ( (rowPPPexistente != null) && (rowPPPexistente.FechaRecepcion > rowAux.FechaRecepcion) )
							{
								// Editando una POCP... con fecha mayor a la que figura en tsh_ProductosAuxiliares --> busco (si E) la nueva fecha de ingreso menor.								
								this.ProximaEntradaDeProductoPendiente(this.IdProducto, idComprobante);
							}
						}
					}
					else 
					{
						// No existe el producto en tsh_ProductosAuxiliares; raro pero podría pasar...
						tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow newAuxRow = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();
						mz.erp.businessrules.tsh_ProductosAuxiliares.SetRowDefaultValues( newAuxRow );
						// Inicializa las campos con los valores pertinentes.
						newAuxRow.IdProducto = this.IdProducto;
						newAuxRow.FechaRecepcion = this.ItemsComprobantes.Parent.FechaRecepcionMercaderia;
						newAuxRow.Cantidad = this.Cantidad;
						newAuxRow.IdComprobanteProximaRecepcionMercaderia = idComprobante; // Poner le valor real en ComprobanteDeCompra.Flush
						newAuxRow.IdProveedor = this.ItemsComprobantes.Parent.IdProveedor;
	                    
						this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.Addtsh_ProductosAuxiliaresRow( newAuxRow );
					}
				}
				
				if (this.ItemsComprobantes.Parent.AccionCancela)
				{
					// Acciones q cierran una Pre/Orden de Compra; Pueden ser Remitos, Anulacion de Pre/Ord de Compra, Edicion de Compra --> Configurado por variable!
					// 1º Recupero todos los productos de tsh_ProductosPendientes (Un Remito puede tener mas de un producto en un item...)
					if ( this._origenes.Count > 0 )
					{	
						foreach(RelacionComprobanteDeCompraOrigen rel in this._origenes)
						{					
							tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPend = this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderiaAnterior, rel.OrdinalOrigen );
							if ( rowPend == null )
							{					
								rowPend = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetByPk( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderiaAnterior, rel.OrdinalOrigen );
							}
							if ( rowPend != null )
							{
								if ( this._origenes.Count != 1)
									rowPend.Cantidad -= rel.CantidadOrigen;
								else
									rowPend.Cantidad -= this._cantidad;

								if( rowPend.Cantidad == 0 )
								{
									// Cantidad cerrada para ese Item --> piso FechaCierre y Cerrado.
									rowPend.FechaCierre = mz.erp.businessrules.Sistema.DateTime.Now;
									rowPend.Cerrado = true;
								}	
								if ( this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal(rowPend.IdComprobante, rowPend.IdProducto, rowPend.FechaRecepcion, rowPend.Ordinal) == null )
									this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPend );
							}
						}
					}
					else 
					{	// this._origenes = 0
						tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPend = this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderia, this.OrdinalOrigen );
						if ( rowPend == null )
						{					
							rowPend = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetByPk( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderia, this.OrdinalOrigen );
						}
						if ( rowPend != null )
						{
							rowPend.Cantidad -= this.Cantidad;
							if( rowPend.Cantidad == 0 )
							{
								// Cantidad cerrada para ese Item --> piso FechaCierre y Cerrado.
								rowPend.FechaCierre = mz.erp.businessrules.Sistema.DateTime.Now;
								rowPend.Cerrado = true;
							}	
							if ( this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal(rowPend.IdComprobante, rowPend.IdProducto, rowPend.FechaRecepcion, rowPend.Ordinal) == null )
								this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPend );
						}
					}
					// Dentro de AccionCancela...
					if ( !this.ItemsComprobantes.Parent.AccionActualiza )
						// No actualizó arriba ==> puede ser un Remito o una Anulacion, con lo cual debo buscar la proxima entrada de mercaderia.
						if ( this.ItemsComprobantes.Parent.ProdAuxIdComprobanteProximaRecepcionMercaderiaOriginal == this.ItemsComprobantes.Parent.IdComprobanteOrigen )
						{
							// Si no hay mas cantidad por recibir para ese Producto... lo cierra en tsh_ProductosAuxiliares
							tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowProdAux = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto);
							if ( rowProdAux == null )
							{
								rowProdAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.IdProducto);
							}
							rowProdAux.Cantidad -= this.Cantidad;                        
							if(rowProdAux.Cantidad == 0)
							{	
								// Actualiza tsh_ProductosAuxiliares
								rowProdAux.SetFechaRecepcionNull();
								rowProdAux.IdComprobanteProximaRecepcionMercaderia = "";
								rowProdAux.IdProveedor = "";

								if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
									this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowProdAux );
									
								// Deberia buscar, si existe, la nueva entrada de mercaderia... y actualizar los datos en tsh_ProcdutosAuxiliares
								this.ProximaEntradaDeProductoPendiente(this.IdProducto, this.ItemsComprobantes.Parent.IdComprobanteOrigen);	                        						
							}							
							else // ---- Matias - 20090903
							{
								if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
									this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowProdAux );
							}
							// ---- FinMatias.
						}				
				}
			}	
			else
			{ // Producto Borrado de una PreOrden...
				// Estado == "DEL"
				if(this.ItemsComprobantes.Parent.AccionActualiza)
				{
					if ( this._origenes.Count > 0 )
					{	
						// this._origenes > 0 (Confirmando de mas de un Comprobante)
						foreach(RelacionComprobanteDeCompraOrigen rel in this._origenes)
						{		
							tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPend = this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderia, rel.OrdinalOrigen );
							if ( rowPend == null )
							{					
								rowPend = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetByPk( this.ItemsComprobantes.Parent.IdComprobanteOrigen, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderia, rel.OrdinalOrigen );
								if ( rowPend != null )
								{
									rowPend.Delete();
									this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPend );
								}
							}
						
							else 
								rowPend.Delete();
						
						}
					}
					else 
					{	
						// this._origenes = 0 (Viene de un solo Comprobante)
						tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPend = this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal( this.ItemsComprobantes.Parent.IdComprobante, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderiaAnterior, this.Ordinal );
						if ( rowPend == null )
						{
							rowPend = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetByPk( this.ItemsComprobantes.Parent.IdComprobante/*...Origen*/, this.IdProducto, this.ItemsComprobantes.Parent.FechaRecepcionMercaderia, this.Ordinal );
							if ( rowPend != null )
							{
								rowPend.Delete();
								this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPend );
							}
						}
						else 
							rowPend.Delete();
						/*
						if ( rowPend != null )
						{
							// Borra el item de tsh_ProductosAuxiliares
							rowPend.Delete();
							if ( this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.FindByIdComprobanteIdProductoFechaRecepcionOrdinal(rowPend.IdComprobante, rowPend.IdProducto, rowPend.FechaRecepcion, rowPend.Ordinal) == null )
								this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.ImportRow( rowPend );
					
						}*/
				
					}

					// Actualizo tsh_ProductosAuxiliares --> prox recep de mercaderia.
					// Si no hay mas cantidad por recibir para ese Producto... lo cierra en tsh_ProductosAuxiliares
					tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowProdAux = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto);
					if ( rowProdAux == null )
					{
						rowProdAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.IdProducto);
					}
					rowProdAux.Cantidad -= this.Cantidad;                        
					if(rowProdAux.Cantidad == 0)
					{	
						rowProdAux.SetFechaRecepcionNull();
						rowProdAux.IdComprobanteProximaRecepcionMercaderia = "";
						rowProdAux.IdProveedor = "";
                    
						if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
							this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowProdAux );
					
						// Deberia buscar, si existe, la nueva entrada de mercaderia... y actualizar los datos en tsh_ProcdutosAuxiliares
						this.ProximaEntradaDeProductoPendiente(this.IdProducto, this.ItemsComprobantes.Parent.IdComprobante/*Origen*/);					
					}	
				}
			}
		}

		private void ProximaEntradaDeProductoPendiente(string IdProducto, string IdComprobante)
		{
			// 1º Recupero el/los productos de tsh_ProductosPendientes que no fueron cerrados y <> del Comprob actual
			tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowAux = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto);
			if (rowAux == null)
				rowAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.IdProducto);
				
			DataSet dataSetPpp = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetListGroup( false, IdProducto, IdComprobante /*this.ItemsComprobantes.Parent.IdComprobanteOrigen*/ );
			if (dataSetPpp.Tables[0].Rows.Count > 0)
			{				
				if (rowAux != null)
				{	// tomo la primer fila del DataSet ( 1º fecha mas cercana + cantMax )
					rowAux.FechaRecepcion = (System.DateTime) dataSetPpp.Tables[0].Rows[0]["FechaRecepcion"];
					rowAux.Cantidad = (System.Decimal) dataSetPpp.Tables[0].Rows[0]["CantidadTotal"];
					rowAux.IdComprobanteProximaRecepcionMercaderia = (System.String) dataSetPpp.Tables[0].Rows[0]["IdComprobante"];
					rowAux.IdProveedor = (System.String) dataSetPpp.Tables[0].Rows[0]["IdProveedor"];			

					if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
						this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowAux );
				}
				else 
				{	// no existe el producto en tsh_ProductosAuxiliares; raro pero podría pasar...
					tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow newAuxRow = this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();
					mz.erp.businessrules.tsh_ProductosAuxiliares.SetRowDefaultValues( newAuxRow );
					// carga las campos con los valores pertinentes.
					newAuxRow.IdProducto = this.IdProducto;
					newAuxRow.FechaRecepcion = (System.DateTime) dataSetPpp.Tables[0].Rows[0]["FechaRecepcion"];
					newAuxRow.Cantidad = (System.Decimal) dataSetPpp.Tables[0].Rows[0]["CantidadTotal"];
					newAuxRow.IdComprobanteProximaRecepcionMercaderia = (System.String)dataSetPpp.Tables[0].Rows[0]["IdComprobante"];
					newAuxRow.IdProveedor = (System.String)dataSetPpp.Tables[0].Rows[0]["IdProveedor"];

					this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.Addtsh_ProductosAuxiliaresRow( newAuxRow );
				}

				foreach ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow rowPPP in  this.ItemsComprobantes.Parent.DataProductosPedidosPendientes.tsh_ProductosPedidosPendientes.Rows )
				{
					if ( (!rowPPP.RowState.Equals(System.Data.DataRowState.Deleted)) &&(  rowPPP.FechaRecepcion <= rowAux.FechaRecepcion ) && ( !rowPPP.Cerrado ) )
					{
						rowAux.FechaRecepcion = rowPPP.FechaRecepcion;
						rowAux.Cantidad = rowPPP.Cantidad;
						rowAux.IdComprobanteProximaRecepcionMercaderia = rowPPP.IdComprobante;
						rowAux.IdProveedor = rowPPP.IdProveedor;			

						if ( this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(this.IdProducto) == null )
							this.ItemsComprobantes.Parent.DataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow( rowAux );
					}
				}
			}
			
		}


		private void CommitOrdenesDeComprasRemitos(tpu_OrdenesDeComprasRemitosDataset data)
		{
			if(!_origenMultiple)
			{
				tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row = data.tpu_OrdenesDeComprasRemitos.Newtpu_OrdenesDeComprasRemitosRow();
				mz.erp.businessrules.tpu_OrdenesDeComprasRemitos.SetRowDefaultValues(row);
				row.IdComprobanteOrigen = this._idComprobanteOrigen;
				row.IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobante;
				row.OrdinalOrigen = this._ordinalOrigen;
				row.OrdinalDestino = this._ordinal;
				row.CantidadOrigen = this._cantidadOrigen;
				row.CantidadDestino = this._cantidad;
				data.tpu_OrdenesDeComprasRemitos.Addtpu_OrdenesDeComprasRemitosRow(row);
				
			}
			else
			{
				foreach(RelacionComprobanteDeCompraOrigen rel in this._origenes)
				{
					tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row = data.tpu_OrdenesDeComprasRemitos.Newtpu_OrdenesDeComprasRemitosRow();
					mz.erp.businessrules.tpu_OrdenesDeComprasRemitos.SetRowDefaultValues(row);
					row.IdComprobanteOrigen = rel.IdComprobanteOrigen;
					row.IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobante;
					row.OrdinalOrigen = rel.OrdinalOrigen;
					row.OrdinalDestino = this._ordinal;
					row.CantidadOrigen = rel.CantidadOrigen;
					row.CantidadDestino = this._cantidad;
					data.tpu_OrdenesDeComprasRemitos.Addtpu_OrdenesDeComprasRemitosRow(row);
				}
			}

		}
		public void CommitDetalle(tpu_ComprobantesDetDataset data, bool IsEdit)
		{
			if(IsEdit && !this._estado.Equals("NEW"))
			{
				if(this._estado.Equals("DEL"))
				{
					tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow rowDet = tpu_ComprobantesDet.GetByPk(this.ItemsComprobantes.Parent.IdComprobante, this.Ordinal);
					rowDet.Delete();
					data.tpu_ComprobantesDet.ImportRow(rowDet);
				}
				else if(this._estado.Equals("MODIF"))
				{
					tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow rowDet = tpu_ComprobantesDet.GetByPk(this.ItemsComprobantes.Parent.IdComprobante, this.Ordinal);
					rowDet.Cantidad = this._cantidad;
					rowDet.PrecioDeCosto = this._precioDeCostoMonedaReferencia;
					rowDet.PrecioDeCostoMonedaOrigen = this._precioDeCosto;
					rowDet.PrecioDeCostoNetoMonedaOrigen = this._precioDeCosto;

					rowDet.IdCotizacionCierre = this.ItemsComprobantes.Parent.IdCotizacionCierre;
					rowDet.IdMonedaCierre = this.ItemsComprobantes.Parent.IdMonedaCierre;
					rowDet.IdMonedaOrigen = this.ItemsComprobantes.Parent.IdMonedaOrigen;
					rowDet.ValorCotizacionProveedor = this.ItemsComprobantes.Parent.ValorCotizacionProveedor;

					data.tpu_ComprobantesDet.ImportRow(rowDet);
				}
			}
			else
			{
				tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row = data.tpu_ComprobantesDet.Newtpu_ComprobantesDetRow();
				row.IdComprobante = this.ItemsComprobantes.Parent.IdComprobante;
				row.Ordinal = this._ordinal;
				row.Cantidad = this._cantidad;
				row.IdProducto = this._idProducto;
				row.PrecioDeCosto = this._precioDeCostoMonedaReferencia;
				row.PrecioDeCostoMonedaOrigen = this._precioDeCosto;
				row.PrecioDeCostoNetoMonedaOrigen = this._precioDeCosto;
				row.Bonificacion1MonedaOrigen = 0;
				row.Bonificacion2MonedaOrigen = 0;
				row.Bonificacion3MonedaOrigen = 0;
				row.Bonificacion4MonedaOrigen = 0;
				row.Bonificacion5MonedaOrigen = 0;
				row.PorcentajeBonificacion1 = 0;
				row.PorcentajeBonificacion2 = 0;
				row.PorcentajeBonificacion3 = 0;
				row.PorcentajeBonificacion4 = 0;
				row.PorcentajeBonificacion5 = 0;

				row.ImpuestosDirectos = 0; //this.ImpuestosDirectos.Total;
				row.ImpuestosIndirectos = 0 ;//this.ImpuestosIndirectos.Total;

				row.IdCotizacionCierre = this.ItemsComprobantes.Parent.IdCotizacionCierre;
				row.IdMonedaCierre = this.ItemsComprobantes.Parent.IdMonedaCierre;
				row.IdMonedaOrigen = this.ItemsComprobantes.Parent.IdMonedaOrigen;
				row.ValorCotizacionProveedor = this.ItemsComprobantes.Parent.ValorCotizacionProveedor;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;

				row.IdConexionCreacion = Security.IdConexion;
				row.IdEmpresa = Security.IdEmpresa;
				row.IdSucursal = Security.IdSucursal;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				data.tpu_ComprobantesDet.Addtpu_ComprobantesDetRow( row );
			}	
		}
        
		/*private void CommitMovimientosDeStock(tlg_MovimientosDeStockDataset data)
			{
				//Movimiento de Stock			
				if(!this.ItemsComprobantes.Parent.Momento.Equals("PREPEDIR"))
				{
					string IdDeposito = ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.Parent.Momento, "Deposito");
					string IdSeccion =  ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.Parent.Momento, "Seccion");

					string IdEstadoStockOrigen = string.Empty;
					string IdEstadoStockDestino = string.Empty;
					long idMomentoDeStock = tlg_TiposComprobantesOrigenDestino.GetMomento( this._idTipoComprobanteOrigen, this.ItemsComprobantes.Parent.TipoComprobanteDestino);
					Stock.GetEstados( idMomentoDeStock, ref IdEstadoStockOrigen, ref IdEstadoStockDestino );

					if ((IdDeposito != string.Empty) && (IdSeccion != string.Empty) )
					{
						mz.erp.businessrules.tpu_ComprobantesEx.SetMovimientosDeStock( data, Security.IdSucursal, Security.IdEmpresa, IdDeposito, IdSeccion, null,IdEstadoStockOrigen,IdEstadoStockDestino, null,this._idProducto, this._cantidad );
					}
				}
				
			}*/


			private void CommitRelacionOrigenDestino(tpu_ComprobantesRelacionOrigenDestinoDataset data, bool IsEdit)
			{
					
				if(IsEdit && !this._estado.Equals("NEW"))
				{
					if(this._estado.Equals("MODIF"))
					{
						string IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobanteDestino;
						long IdOrdinalDestino = this._ordinal;
						tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow rowRelOD = mz.erp.businessrules.tpu_ComprobantesEx.GetRelacionOrigenDestinoPreOrdenDeCompra(IdComprobanteDestino, IdOrdinalDestino);
						if(rowRelOD != null)
						{
							rowRelOD.Cantidad = this._cantidad;
							data.tpu_ComprobantesRelacionOrigenDestino.ImportRow(rowRelOD);
						}

					}
					else if(this._estado.Equals("DEL"))
					{
						string IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobanteDestino;
						long IdOrdinalDestino = this._ordinal;
						tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow rowRelOD = mz.erp.businessrules.tpu_ComprobantesEx.GetRelacionOrigenDestinoPreOrdenDeCompra(IdComprobanteDestino, IdOrdinalDestino);
						if(rowRelOD != null)
						{
							rowRelOD.Delete();
							data.tpu_ComprobantesRelacionOrigenDestino.ImportRow(rowRelOD);
						}
				}

				}
				else
				{
					long IdRelacionOrigenDestino = Convert.ToInt64(mz.erp.systemframework.Util.NewStringId());//mz.erp.systemframework.Util.NewLongId() + mz.erp.systemframework.Util.NewLongId() + this._ordinal;
					string IdComprobanteOrigen = this._idComprobanteOrigen;
					string IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobanteDestino;
					long IdOrdinalOrigen;
					long IdOrdinalDestino = this._ordinal;
					bool CierraCircuito;
					decimal Cantidad = this._cantidad;
					if(!_origenMultiple)
					{
						IdOrdinalOrigen = this._ordinalOrigen;
						CierraCircuito = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.CierraCircuito(  this.ItemsComprobantes.Parent.TipoComprobanteDestino );
						if (IdComprobanteOrigen != IdComprobanteDestino) 
						{
							mz.erp.businessrules.tpu_ComprobantesEx.SetRelacionOrigenDestino(data, IdRelacionOrigenDestino, IdComprobanteOrigen, IdComprobanteDestino, IdOrdinalOrigen, IdOrdinalDestino, Cantidad, CierraCircuito);
						}
					}
					else
					{
				
						foreach(RelacionComprobanteDeCompraOrigen rel in this._origenes)
						{
							IdRelacionOrigenDestino = Convert.ToInt64(mz.erp.systemframework.Util.NewStringId());
							IdOrdinalOrigen = rel.OrdinalOrigen;
							IdComprobanteOrigen = rel.IdComprobanteOrigen;
							Cantidad = rel.CantidadOrigenPendiente;
							CierraCircuito = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.CierraCircuito(  this.ItemsComprobantes.Parent.TipoComprobanteDestino );
							if (IdComprobanteOrigen != IdComprobanteDestino) 
							{
								mz.erp.businessrules.tpu_ComprobantesEx.SetRelacionOrigenDestino(data, IdRelacionOrigenDestino, IdComprobanteOrigen, IdComprobanteDestino, IdOrdinalOrigen, IdOrdinalDestino, Cantidad, CierraCircuito);
							}
						}
				
					}
				}
	}

		

		#endregion


	}

	public class RelacionesComprobanteDeCompraOrigenDestino:System.Collections.CollectionBase
	{
		
		private bool _trasladaOrdinales = false;
		public bool TrasladaOrdinales
		{
			get{return _trasladaOrdinales;}
		}
		#region Construtores
			public RelacionesComprobanteDeCompraOrigenDestino()
			{
			}


		private bool _loadFromFactura = false;

		public void LoadForCompletarFacturaCompras(ArrayList IdComprobantes, string ProcessName, string TaskName, string MainTaskName)
		{
			/*Se pasa todo pesificado, por defecto las Notas de creditos y las notas de debitos se manejan en pesos*/
				
			_processName = ProcessName;
			_taskName = TaskName;
			_mainTaskName = MainTaskName;
			_transicionesDeEstados = Variables.GetValueString(_processName, _mainTaskName, "TransicionesDeEstados");
			_trasladaOrdinales = Variables.GetValueBool(_processName, _mainTaskName, "Step.TrasladaOrdinales");
			_loadFromFactura = Variables.GetValueBool("Compras.PreNotasDeCreditos.OrigenFactura");//Determina si se parte la factura o de la confirmacion de remitos
			ArrayList lista = new ArrayList(IdComprobantes);			
			for (int i = 0; i < lista.Count; i++) 
			{
				string IdComprobante = lista[i].ToString();
				tpu_ComprobantesDataset.tpu_ComprobantesRow CompOrigen = tpu_Comprobantes.GetByPk(IdComprobante);				

				//Datos comunes a todos los items de un mismo comprobante
				string IdTipoDeComprobante = CompOrigen.IdTipoDeComprobante;
				string Numero = CompOrigen.Numero;
				/*Si el origen es uno solo se queda con el numero de dicho comprobante*/
				if(lista.Count == 1) 
				{
					this._numero = Numero;
					this._idComprobante = IdComprobante;
					this._idTipoDeComprobante = IdTipoDeComprobante;
					this._multiplesOrigenes = false;

				}
				else this._multiplesOrigenes = true;
				_campoAuxiliar1 = CompOrigen.Aux1;
				//German 20090326
				_campoAuxiliar2 = CompOrigen.Aux2;
				_campoAuxiliar3 = CompOrigen.Aux3;
				_campoAuxiliar4 = CompOrigen.Aux4;
				//Fin German 20090326
				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;
				string Codigo = string.Empty;
				string CodigoSecundario = string.Empty;
				long IdSucursal = Security.IdSucursal;
				long IdEmpresa = Security.IdEmpresa;
				DateTime Fecha = CompOrigen.Fecha;
				Decimal PrecioDeCosto = 0;
				this._idProveedor = CompOrigen.IdProveedor;
				this._idResponsable = CompOrigen.IdResponsable;
				this._idMonedaDestino = ComprobantesRules.Contabilidad_MonedaReferencia;
				this._idFuenteDeCambio = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
				this._idCotizacion = ComprobantesRules.Contabilidad_CotizacionReferencia;
				this._valorCotizacion = 1;
				this._fechaComprobante = CompOrigen.Fecha;
				this._idFuenteDeCambioProveedor = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
				this._idMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
				this._valorCotizacionProveedor = 1;
				this._observaciones = CompOrigen.Observaciones;
				this._conceptosGravados = new ItemsConcepto();
				this._conceptosNoGravados = new ItemsConcepto();
				this._fechaRecepcionMercaderia = CompOrigen.FechaRecepcionMercaderia;
				this._idCondicionDeCompra = CompOrigen.IdCondicionDeCompra;

				tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow CompOrigenCab = businessrules.tpu_ComprobantesDeCompra.GetByPk(IdComprobante);					
				if (CompOrigenCab != null)
				{
					this._idCuentaImputacion = CompOrigenCab.IdTipoMovimiento;
					this._idSubCuentaImputacion = CompOrigenCab.IdSubtipoMovimiento;
					this._cai = CompOrigenCab.CAI;
					this._leyenda = CompOrigenCab.Leyenda;					
					this._mesDeImputacion = Convert.ToString(CompOrigenCab.MesImputacion) + "/" + Convert.ToString(CompOrigenCab.AñoImputacion);
					this._mesDeDevengamiento = Convert.ToString(CompOrigenCab.MesDevengamiento) + "/" + Convert.ToString(CompOrigenCab.AñoDevengamiento);
					this._isValidFechaVencimiento = true;
					this._fechaVencimiento = CompOrigenCab.FechaVencimiento;
					this._fechaProximoVencimiento = CompOrigenCab.FechaProximoVencimiento;
					this._netoBruto = CompOrigenCab.NetoBruto;
					this._descuentos = CompOrigenCab.Descuento;
					this._neto = CompOrigenCab.SubtotalNeto;
					this._totalGeneral = CompOrigenCab.TotalGeneral;
					this._impuestos = this._totalGeneral - this._neto;
					this._descuentoGeneral = CompOrigenCab.DescuentoGeneral;
					this._total = CompOrigenCab.Total;
						
					DataSet comprobantesImpuestos = businessrules.tpu_ComprobantesImpuestos.GetListEx(IdComprobante);
					foreach (DataRow row in comprobantesImpuestos.Tables[0].Rows)
					{				
						ItemConcepto ic = new ItemConcepto();
						ic.IdConcepto = Convert.ToString(row["IdNeto"]);
						ic.Concepto = Convert.ToString(row["DescripcionNeto"]);
						ic.IdImpuesto = Convert.ToString(row["IdImpuesto"]);
						ic.Impuesto = Convert.ToString(row["DescripcionImpuesto"]);
						ic.MontoNeto = Convert.ToDecimal(row["ValorNeto"]);
						ic.MontoImpuesto = Convert.ToDecimal(row["ValorImpuesto"]);
						ic.PorcentajeImpuesto = Convert.ToDecimal(row["PorcentajeAplicado"]);
						ic.Familia = Convert.ToString(row["Familia"]);
						ic.FamiliaImp = Convert.ToString(row["FamiliaImp"]);
						ic.ValorCotizacion = Convert.ToDecimal(row["ValorCotizacionProveedor"]);					

						if (Convert.ToBoolean(row["EsGravado"]))
							this._conceptosGravados.Add(ic);
						else
							this._conceptosNoGravados.Add(ic);
					}
				}
				if(!_multiplesOrigenes)
				{
					_factura = new FacturaDeCompraItems();
					_factura.SetTransicionesDeEstados(_transicionesDeEstados);
					_factura.LoadFromNumeroFactura(_numero, _idProveedor);
					Hashtable transiciones = new Hashtable();
					string[] tras = _transicionesDeEstados.Split( ',');
					if (tras.Length > 0)
					{
						Hashtable hash = new Hashtable();
						for(int j=0;j<tras.Length;j++)
						{
							string[] atupla = tras[j].Split(':');
							if (atupla.Length == 2)
							{
								if(!transiciones.ContainsKey(atupla[0]))
									transiciones.Add( atupla[0],atupla[1]);
							}
						}
					}
					foreach(FacturaDeCompraItem item in _factura.Items)
					{						
						string codigo = string.Empty;
						string codigoSecundario = string.Empty;
						string _productoCampoAuxiliar1 = string.Empty;
						string _productoCampoAuxiliar2 = string.Empty;
						string _productoCampoAuxiliar3 = string.Empty;
						string _productoCampoAuxiliar4 = string.Empty;
						string _productoCampoAuxiliar5 = string.Empty;
						string _productoCampoAuxiliar6 = string.Empty;
						string _productoObservaciones = string.Empty;
						string _productoCodigoProveedor = string.Empty;
						DateTime _productoFechaUltModifPrecioCosto = mz.erp.businessrules.Sistema.DateTime.Now; 
						DateTime _productoFechaUltModifPrecioVenta = mz.erp.businessrules.Sistema.DateTime.Now; 
						
						DataRow rowP  = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
						if(rowP != null)
						{
							Codigo = Convert.ToString(rowP["Codigo"]);
							CodigoSecundario = Convert.ToString(rowP["CodigoSecundario"]);
							Descripcion = Convert.ToString(rowP["Descripcion"]);
							
							// ---- Matias - Tarea 204 - 20090721
							_productoCampoAuxiliar1 = Convert.ToString(rowP["CampoAuxiliar1"]);
							_productoCampoAuxiliar2 = Convert.ToString(rowP["CampoAuxiliar2"]);
							_productoCampoAuxiliar3 = Convert.ToString(rowP["CampoAuxiliar3"]);
							_productoCampoAuxiliar4 = Convert.ToString(rowP["CampoAuxiliar4"]);
							_productoCampoAuxiliar5 = Convert.ToString(rowP["CampoAuxiliar5"]);
							_productoCampoAuxiliar6 = Convert.ToString(rowP["CampoAuxiliar6"]);
							_productoCodigoProveedor = Convert.ToString(rowP["CodigoProveedor"]);
							_productoObservaciones = Convert.ToString(rowP["Observaciones"]);
							if ( rowP.IsNull("FechaUltimaModificacionPrecioDeCosto") )
								_productoFechaUltModifPrecioCosto = DateTime.MinValue;
							else
								_productoFechaUltModifPrecioCosto = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeCosto"]);
											
							if ( rowP.IsNull("FechaUltimaModificacionPrecioDeVenta") )
								_productoFechaUltModifPrecioVenta = DateTime.MinValue;
							else
								_productoFechaUltModifPrecioVenta = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeVenta"]);
							// ---- FinMatias
											
						}
						RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, 0/*Pendiente*/, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, Codigo, CodigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, false /*permiteCantidadMayorCantidadPendiente*/, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta );
						this.Add(rel);

						/*
						if(transiciones.ContainsKey(item.Estado))
						{
							if(item.TieneDiferenciaPorCantidad)
							{
								decimal nuevaCantidad = item.CantidadFactura - item.CantidadOrdenDeCompra;					
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, item.PrecioDeCostoFactura * item.ValorCotizacionFactura, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false);
								this.Add(rel);

							}
							if(item.TieneDiferenciaPorCotizacion)
							{
								decimal nuevaCantidad = 0;
								if(item.TieneDiferenciaPorCantidad) nuevaCantidad = item.CantidadOrdenDeCompra;
								else nuevaCantidad = item.CantidadFactura;
								decimal valorCot = item.ValorCotizacionFactura - item.ValorCotizacionOrdenDeCompra;
								decimal nuevoPrecio = 0;
								if(item.TieneDiferenciaPorPrecio)nuevoPrecio =  item.PrecioDeCostoFactura - item.PrecioDeCostoReal;
								else nuevoPrecio = item.PrecioDeCostoFactura;
								nuevoPrecio = nuevoPrecio * valorCot;
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, nuevoPrecio, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false);
								this.Add(rel);

							}
							if(item.TieneDiferenciaPorPrecio && ! item.TieneDiferenciaPorCotizacion)
							{
								decimal nuevaCantidad = 0;
								if(item.TieneDiferenciaPorCantidad) nuevaCantidad = item.CantidadOrdenDeCompra;
								else nuevaCantidad = item.CantidadFactura;
								decimal nuevoPrecio = 0;
								if(item.TieneDiferenciaPorPrecio)nuevoPrecio =  item.PrecioDeCostoFactura - item.PrecioDeCostoReal;
								else nuevoPrecio = item.PrecioDeCostoFactura;
								nuevoPrecio = nuevoPrecio * item.ValorCotizacionFactura;
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, nuevoPrecio, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false);
								this.Add(rel);
							}
						}
						*/
					}
					
					/*Pasa Todo a T*/
					//_factura.SetEstadoItemsSegunTransiciones();
				}
					
					
				
				
							
			}
			

		}

		

		public void LoadForComprobantesDeCompraConfirmacionDePrecios(ArrayList IdComprobantes, string ProcessName, string TaskName, string MainTaskName)
		{
			/*Se pasa todo pesificado, por defecto las Notas de creditos y las notas de debitos se manejan en pesos*/
				
			_processName = ProcessName;
			_taskName = TaskName;
			_mainTaskName = MainTaskName;
			_transicionesDeEstados = Variables.GetValueString(_processName, _mainTaskName, "TransicionesDeEstados");
			_trasladaOrdinales = Variables.GetValueBool(_processName, _mainTaskName, "Step.TrasladaOrdinales");
			_loadFromFactura = Variables.GetValueBool("Compras.PreNotasDeCreditos.OrigenFactura");//Determina si se parte la factura o de la confirmacion de remitos
			ArrayList lista = new ArrayList(IdComprobantes);			
			for (int i = 0; i < lista.Count; i++) 
			{
				string IdComprobante = lista[i].ToString();
				tpu_ComprobantesDataset.tpu_ComprobantesRow CompOrigen = tpu_Comprobantes.GetByPk(IdComprobante);				

				//Datos comunes a todos los items de un mismo comprobante
				string IdTipoDeComprobante = CompOrigen.IdTipoDeComprobante;
				string Numero = CompOrigen.Numero;
				/*Si el origen es uno solo se queda con el numero de dicho comprobante*/
				if(lista.Count == 1) 
				{
					this._numero = Numero;
					this._idComprobante = IdComprobante;
					this._idTipoDeComprobante = IdTipoDeComprobante;
					this._multiplesOrigenes = false;

				}
				else this._multiplesOrigenes = true;
				_campoAuxiliar1 = CompOrigen.Aux1;
				//German 20090326
				_campoAuxiliar2 = CompOrigen.Aux2;
				_campoAuxiliar3 = CompOrigen.Aux3;
				_campoAuxiliar4 = CompOrigen.Aux4;
				//Fin German 20090326
				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;
				long IdSucursal = Security.IdSucursal;
				long IdEmpresa = Security.IdEmpresa;
				DateTime Fecha = CompOrigen.Fecha;
				Decimal PrecioDeCosto = 0;
				this._idProveedor = CompOrigen.IdProveedor;
				this._idResponsable = CompOrigen.IdResponsable;
				this._idMonedaDestino = ComprobantesRules.Contabilidad_MonedaReferencia;
				this._idFuenteDeCambio = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
				this._idCotizacion = ComprobantesRules.Contabilidad_CotizacionReferencia;
				this._valorCotizacion = 1;
				this._fechaComprobante = CompOrigen.Fecha;
				this._idFuenteDeCambioProveedor = ComprobantesRules.Contabilidad_FuenteDeCambioReferencia;
				this._idMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
				this._valorCotizacionProveedor = 1;
				this._observaciones = CompOrigen.Observaciones;
				this._conceptosGravados = new ItemsConcepto();
				this._conceptosNoGravados = new ItemsConcepto();
				this._fechaRecepcionMercaderia = CompOrigen.FechaRecepcionMercaderia;
				this._idCondicionDeCompra = CompOrigen.IdCondicionDeCompra;

				tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow CompOrigenCab = businessrules.tpu_ComprobantesDeCompra.GetByPk(IdComprobante);					
				if (CompOrigenCab != null)
				{
					this._idCuentaImputacion = CompOrigenCab.IdTipoMovimiento;
					this._idSubCuentaImputacion = CompOrigenCab.IdSubtipoMovimiento;
					this._cai = CompOrigenCab.CAI;
					this._leyenda = CompOrigenCab.Leyenda;					
					this._mesDeImputacion = Convert.ToString(CompOrigenCab.MesImputacion) + "/" + Convert.ToString(CompOrigenCab.AñoImputacion);
					this._mesDeDevengamiento = Convert.ToString(CompOrigenCab.MesDevengamiento) + "/" + Convert.ToString(CompOrigenCab.AñoDevengamiento);
					this._isValidFechaVencimiento = true;
					this._fechaVencimiento = CompOrigenCab.FechaVencimiento;
					this._fechaProximoVencimiento = CompOrigenCab.FechaProximoVencimiento;
					this._netoBruto = CompOrigenCab.NetoBruto;
					this._descuentos = CompOrigenCab.Descuento;
					this._neto = CompOrigenCab.SubtotalNeto;
					this._totalGeneral = CompOrigenCab.TotalGeneral;
					this._impuestos = this._totalGeneral - this._neto;
					this._descuentoGeneral = CompOrigenCab.DescuentoGeneral;
					this._total = CompOrigenCab.Total;
						
					DataSet comprobantesImpuestos = businessrules.tpu_ComprobantesImpuestos.GetListEx(IdComprobante);
					foreach (DataRow row in comprobantesImpuestos.Tables[0].Rows)
					{				
						ItemConcepto ic = new ItemConcepto();
						ic.IdConcepto = Convert.ToString(row["IdNeto"]);
						ic.Concepto = Convert.ToString(row["DescripcionNeto"]);
						ic.IdImpuesto = Convert.ToString(row["IdImpuesto"]);
						ic.Impuesto = Convert.ToString(row["DescripcionImpuesto"]);
						ic.MontoNeto = Convert.ToDecimal(row["ValorNeto"]);
						ic.MontoImpuesto = Convert.ToDecimal(row["ValorImpuesto"]);
						ic.PorcentajeImpuesto = Convert.ToDecimal(row["PorcentajeAplicado"]);
						ic.Familia = Convert.ToString(row["Familia"]);
						ic.FamiliaImp = Convert.ToString(row["FamiliaImp"]);
						ic.ValorCotizacion = Convert.ToDecimal(row["ValorCotizacionProveedor"]);					

						if (Convert.ToBoolean(row["EsGravado"]))
							this._conceptosGravados.Add(ic);
						else
							this._conceptosNoGravados.Add(ic);
					}
				}
				if(!_multiplesOrigenes)
				{
					_factura = new FacturaDeCompraItems();
					_factura.SetTransicionesDeEstados(_transicionesDeEstados);
					if(_loadFromFactura)
						_factura.LoadFromIdComprobanteFactura(IdComprobante);
					else
						_factura.LoadFromIdComprobante(IdComprobante);
					Hashtable transiciones = new Hashtable();
					string[] tras = _transicionesDeEstados.Split( ',');
					if (tras.Length > 0)
					{
						Hashtable hash = new Hashtable();
						for(int j=0;j<tras.Length;j++)
						{
							string[] atupla = tras[j].Split(':');
							if (atupla.Length == 2)
							{
								if(!transiciones.ContainsKey(atupla[0]))
									transiciones.Add( atupla[0],atupla[1]);
							}
						}
					}
					foreach(FacturaDeCompraItem item in _factura.Items)
					{
						// ---- Matias - Tarea 204 - 20090721
						string _productoCodigo = string.Empty;
						string _productoCodigoSecundario = string.Empty;
						string _productoDescripcion = string.Empty;
						string _productoCampoAuxiliar1 = string.Empty;
						string _productoCampoAuxiliar2 = string.Empty;
						string _productoCampoAuxiliar3 = string.Empty;
						string _productoCampoAuxiliar4 = string.Empty;
						string _productoCampoAuxiliar5 = string.Empty;
						string _productoCampoAuxiliar6 = string.Empty;
						string _productoObservaciones = string.Empty;
						string _productoCodigoProveedor = string.Empty;
						DateTime _productoFechaUltModifPrecioCosto = mz.erp.businessrules.Sistema.DateTime.Now; 
						DateTime _productoFechaUltModifPrecioVenta = mz.erp.businessrules.Sistema.DateTime.Now; 
						if(item.IdProducto != null && !item.IdProducto.Equals(string.Empty))
						{
							DataRow rowP  = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
							if(rowP != null)
							{
								_productoCodigo = Convert.ToString(rowP["Codigo"]);
								_productoCodigoSecundario = Convert.ToString(rowP["CodigoSecundario"]);
								_productoDescripcion = Convert.ToString(rowP["Descripcion"]);
								_productoCampoAuxiliar1 = Convert.ToString(rowP["CampoAuxiliar1"]);
								_productoCampoAuxiliar2 = Convert.ToString(rowP["CampoAuxiliar2"]);
								_productoCampoAuxiliar3 = Convert.ToString(rowP["CampoAuxiliar3"]);
								_productoCampoAuxiliar4 = Convert.ToString(rowP["CampoAuxiliar4"]);
								_productoCampoAuxiliar5 = Convert.ToString(rowP["CampoAuxiliar5"]);
								_productoCampoAuxiliar6 = Convert.ToString(rowP["CampoAuxiliar6"]);
								_productoCodigoProveedor = Convert.ToString(rowP["CodigoProveedor"]);
								_productoObservaciones = Convert.ToString(rowP["Observaciones"]);
								if ( rowP.IsNull("FechaUltimaModificacionPrecioDeCosto") )
									_productoFechaUltModifPrecioCosto = DateTime.MinValue;
								else
									_productoFechaUltModifPrecioCosto = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeCosto"]);
											
								if ( rowP.IsNull("FechaUltimaModificacionPrecioDeVenta") )
									_productoFechaUltModifPrecioVenta = DateTime.MinValue;
								else
									_productoFechaUltModifPrecioVenta = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeVenta"]);
							}
						}
						// ---- FinMatias

						if(transiciones.ContainsKey(item.Estado))
						{
							if(item.TieneDiferenciaPorCantidad)
							{
								decimal nuevaCantidad = item.CantidadFactura - item.CantidadOrdenDeCompra;					
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, item.PrecioDeCostoFactura * item.ValorCotizacionFactura, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta);
								this.Add(rel);

 							}
							if(item.TieneDiferenciaPorCotizacion)
							{
								decimal nuevaCantidad = 0;
								if(item.TieneDiferenciaPorCantidad) nuevaCantidad = item.CantidadOrdenDeCompra;
								else nuevaCantidad = item.CantidadFactura;
								decimal valorCot = item.ValorCotizacionFactura - item.ValorCotizacionOrdenDeCompra;
								decimal nuevoPrecio = 0;
								if(item.TieneDiferenciaPorPrecio)nuevoPrecio =  item.PrecioDeCostoFactura - item.PrecioDeCostoReal;
								else nuevoPrecio = item.PrecioDeCostoFactura;
								nuevoPrecio = nuevoPrecio * valorCot;
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, nuevoPrecio, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta);
								this.Add(rel);

							}
							if(item.TieneDiferenciaPorPrecio && ! item.TieneDiferenciaPorCotizacion)
							{
								decimal nuevaCantidad = 0;
								if(item.TieneDiferenciaPorCantidad) nuevaCantidad = item.CantidadOrdenDeCompra;
								else nuevaCantidad = item.CantidadFactura;
								decimal nuevoPrecio = 0;
								if(item.TieneDiferenciaPorPrecio)nuevoPrecio =  item.PrecioDeCostoFactura - item.PrecioDeCostoReal;
								else nuevoPrecio = item.PrecioDeCostoFactura;
								nuevoPrecio = nuevoPrecio * item.ValorCotizacionFactura;
								RelacionComprobanteDeCompraOrigenDestino rel = new RelacionComprobanteDeCompraOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero,item.Ordinal, item.CantidadFactura, nuevaCantidad, item.IdProducto, item.Producto, nuevoPrecio, Security.IdSucursal, Security.IdEmpresa, item.Codigo, string.Empty, _factura.FechaFactura, _factura.FechaFactura, false, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta);
								this.Add(rel);
							}
						}
						
					}//for
					
					/*Pasa Todo a T*/
					_factura.SetEstadoItemsSegunTransiciones();
				}
					
					
				
				
							
			}
			

		}

		
		
		public RelacionesComprobanteDeCompraOrigenDestino(ArrayList IdComprobantes, string ProcessName, string TaskName, string MainTaskName)
			{			
				
				_processName = ProcessName;
				_taskName = TaskName;
				_mainTaskName = MainTaskName;
				bool permiteCantidadMayorCantidadPendiente = Variables.GetValueBool(_processName, _mainTaskName, "PermiteCantidadMayorACantidadPendiente");
				string IdTipoDeComprobanteGral = String.Empty;
				string TiposComprobantesDestinoExcluidos = Variables.GetValueString(_processName, _taskName, "TiposDeComprobantesExcluidos");

				ArrayList lista = new ArrayList(IdComprobantes);			
				for (int i = 0; i < lista.Count; i++) 
				{
					string IdComprobante = lista[i].ToString();
					tpu_ComprobantesDataset.tpu_ComprobantesRow CompOrigen = tpu_Comprobantes.GetByPk(IdComprobante);				

					//Datos comunes a todos los items de un mismo comprobante
					string IdTipoDeComprobante = CompOrigen.IdTipoDeComprobante;
					string Numero = CompOrigen.Numero;
					/*Si el origen es uno solo se queda con el numero de dicho comprobante*/
					if(lista.Count == 1) 
					{
						this._numero = Numero;
						this._idComprobante = IdComprobante;
						this._idTipoDeComprobante = IdTipoDeComprobante;
						this._multiplesOrigenes = false;

					}
					else this._multiplesOrigenes = true;
					_campoAuxiliar1 = CompOrigen.Aux1;
					//German 20090326
					_campoAuxiliar2 = CompOrigen.Aux2;
					_campoAuxiliar3 = CompOrigen.Aux3;
					_campoAuxiliar4 = CompOrigen.Aux4;
					//Fin German 20090326
					long OrdinalOrigen = -1;
					decimal CantidadOrigen = 0;
					string IdProducto = String.Empty;
					string Descripcion = String.Empty;
					long IdSucursal = Security.IdSucursal;
					long IdEmpresa = Security.IdEmpresa;
					DateTime Fecha = CompOrigen.Fecha;
					Decimal PrecioDeCosto = 0;
					this._idProveedor = CompOrigen.IdProveedor;
					this._idResponsable = CompOrigen.IdResponsable;
					this._idMonedaDestino = CompOrigen.IdMonedaCierre;
					this._idFuenteDeCambio = CompOrigen.IdFuenteDeCambioProveedor;
					this._idCotizacion = CompOrigen.IdCotizacionCierre;
					this._valorCotizacion = CompOrigen.ValorCotizacionProveedor;
					this._fechaComprobante = CompOrigen.Fecha;
					this._idFuenteDeCambioProveedor = CompOrigen.IdFuenteDeCambioProveedor;
					this._idMonedaOrigen = CompOrigen.IdMonedaOrigen;
					this._valorCotizacionProveedor = CompOrigen.ValorCotizacionProveedor;
					this._observaciones = CompOrigen.Observaciones;
					this._conceptosGravados = new ItemsConcepto();
					this._conceptosNoGravados = new ItemsConcepto();
					this._fechaRecepcionMercaderia = CompOrigen.FechaRecepcionMercaderia;
					this._idCondicionDeCompra = CompOrigen.IdCondicionDeCompra;

					tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow CompOrigenCab = businessrules.tpu_ComprobantesDeCompra.GetByPk(IdComprobante);					
					if (CompOrigenCab != null)
					{
						this._idCuentaImputacion = CompOrigenCab.IdTipoMovimiento;
						this._idSubCuentaImputacion = CompOrigenCab.IdSubtipoMovimiento;
						this._cai = CompOrigenCab.CAI;
						this._leyenda = CompOrigenCab.Leyenda;					
						this._mesDeImputacion = Convert.ToString(CompOrigenCab.MesImputacion) + "/" + Convert.ToString(CompOrigenCab.AñoImputacion);
						this._mesDeDevengamiento = Convert.ToString(CompOrigenCab.MesDevengamiento) + "/" + Convert.ToString(CompOrigenCab.AñoDevengamiento);
						this._isValidFechaVencimiento = true;
						this._fechaVencimiento = CompOrigenCab.FechaVencimiento;
						this._fechaProximoVencimiento = CompOrigenCab.FechaProximoVencimiento;
						this._netoBruto = CompOrigenCab.NetoBruto;
						this._descuentos = CompOrigenCab.Descuento;
						this._neto = CompOrigenCab.SubtotalNeto;
						this._totalGeneral = CompOrigenCab.TotalGeneral;
						this._impuestos = this._totalGeneral - this._neto;
						this._descuentoGeneral = CompOrigenCab.DescuentoGeneral;
						this._total = CompOrigenCab.Total;
						
						DataSet comprobantesImpuestos = businessrules.tpu_ComprobantesImpuestos.GetListEx(IdComprobante);
						foreach (DataRow row in comprobantesImpuestos.Tables[0].Rows)
						{				
							ItemConcepto ic = new ItemConcepto();
							ic.IdConcepto = Convert.ToString(row["IdNeto"]);
							ic.Concepto = Convert.ToString(row["DescripcionNeto"]);
							ic.IdImpuesto = Convert.ToString(row["IdImpuesto"]);
							ic.Impuesto = Convert.ToString(row["DescripcionImpuesto"]);
							ic.MontoNeto = Convert.ToDecimal(row["ValorNeto"]);
							ic.MontoImpuesto = Convert.ToDecimal(row["ValorImpuesto"]);
							ic.PorcentajeImpuesto = Convert.ToDecimal(row["PorcentajeAplicado"]);
							ic.Familia = Convert.ToString(row["Familia"]);
							ic.FamiliaImp = Convert.ToString(row["FamiliaImp"]);
							ic.ValorCotizacion = Convert.ToDecimal(row["ValorCotizacionProveedor"]);					

							if (Convert.ToBoolean(row["EsGravado"]))
								this._conceptosGravados.Add(ic);
							else
								this._conceptosNoGravados.Add(ic);
						}					
					}
					if (IdTipoDeComprobanteGral == String.Empty) 
					{
						IdTipoDeComprobanteGral = IdTipoDeComprobante;
					}

					//Si el tipo de Comprobante actual es distinto al tipo de comprobante del primer comprobante no hace nada (por ahora)
					if (IdTipoDeComprobante == IdTipoDeComprobanteGral) 
					{
						//Para cada IdComprobante tengo que obtener los ítems
						//Datos del item del comprobante				
						tpu_ComprobantesDetDataset Items = businessrules.tpu_ComprobantesDet.GetByPk(IdComprobante);

						foreach (tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row in Items.tpu_ComprobantesDet )
						{
							
							if(ProcessName.Equals("ProcesoComprarIngresarCabeceraCompras") ||ProcessName.Equals("ProcesoComprarIngresarCabeceraCompras"))
							{
								OrdinalOrigen = row.Ordinal;
								CantidadOrigen = row.Cantidad; 
								SortedList aux = Workflow.GetComprobantesAsociadosList(Workflow.GetIdTakByName(_mainTaskName));
								ArrayList aux1 = new ArrayList(aux.Keys);
								string TiposComprobantesDestino = systemframework.Util.PackString(aux1, ",");
								/*
								System.Data.DataRow rowPend = businessrules.tpu_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, OrdinalOrigen);
								decimal Pendiente = CantidadOrigen;
								*/
								System.Data.DataRow rowPend = null;
								System.Data.DataRow rowConfirmacionPreciosDet = null;
								decimal Pendiente = CantidadOrigen;

								rowConfirmacionPreciosDet = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk(IdComprobante, OrdinalOrigen);
								if(rowConfirmacionPreciosDet != null)
									Pendiente = Convert.ToDecimal(rowConfirmacionPreciosDet["CantidadFactura"]);
								else
								{
									rowPend = businessrules.tpu_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, OrdinalOrigen);
									Pendiente = Convert.ToDecimal(rowPend["Cantidad"]);
								}

								if(Pendiente  > 0)
								{
									/*Toma como precio de costo, el precio de la fatura. Dado se a va a pasar la 
										 * factura a partir de la confirmacion del remito.
										 * Ver de poner una variable q indique el tipo de comprobante y asi sacar "CRMXC"
										 * Ademas, tener en cuenta q no siempre se guarda en tpu_ComprobantesDeCompraDetConfirmacionDePrecios,
										 * depende de la confirguracion del cliente
										 * */
									//if(IdTipoDeComprobante.Equals("CRMXC"))
									if(_processName.Equals("ProcesoConfirmarIngresoMercaderia"))
									{
										DataRow rowCP = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( IdComprobante, OrdinalOrigen );
										if(rowCP != null)
											PrecioDeCosto = Convert.ToDecimal(rowCP["PrecioDeCostoFactura"]);
										else 
											PrecioDeCosto = row.PrecioDeCostoMonedaOrigen;
									}
									else
									{
										/*En la moneda Origen de comprobante*/
										PrecioDeCosto = row.PrecioDeCostoMonedaOrigen;
									}
									IdSucursal = row.IdSucursal;
									IdEmpresa = row.IdEmpresa;

									IdProducto = row.IdProducto;
									string codigo = string.Empty;
									string codigoSecundario = string.Empty;
									string _productoCampoAuxiliar1 = string.Empty;
									string _productoCampoAuxiliar2 = string.Empty;
									string _productoCampoAuxiliar3 = string.Empty;
									string _productoCampoAuxiliar4 = string.Empty;
									string _productoCampoAuxiliar5 = string.Empty;
									string _productoCampoAuxiliar6 = string.Empty;
									string _productoObservaciones = string.Empty;
									string _productoCodigoProveedor = string.Empty;
									DateTime _productoFechaUltModifPrecioCosto = mz.erp.businessrules.Sistema.DateTime.Now; 
									DateTime _productoFechaUltModifPrecioVenta = mz.erp.businessrules.Sistema.DateTime.Now; 
									if(IdProducto != null && !IdProducto.Equals(string.Empty))
									{
										DataRow rowP  = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
										if(rowP != null)
										{
											codigo = Convert.ToString(rowP["Codigo"]);
											codigoSecundario = Convert.ToString(rowP["CodigoSecundario"]);
											Descripcion = Convert.ToString(rowP["Descripcion"]);

											// ---- Matias - Tarea 204 - 20090721
											_productoCampoAuxiliar1 = Convert.ToString(rowP["CampoAuxiliar1"]);
											_productoCampoAuxiliar2 = Convert.ToString(rowP["CampoAuxiliar2"]);
											_productoCampoAuxiliar3 = Convert.ToString(rowP["CampoAuxiliar3"]);
											_productoCampoAuxiliar4 = Convert.ToString(rowP["CampoAuxiliar4"]);
											_productoCampoAuxiliar5 = Convert.ToString(rowP["CampoAuxiliar5"]);
											_productoCampoAuxiliar6 = Convert.ToString(rowP["CampoAuxiliar6"]);
											_productoCodigoProveedor = Convert.ToString(rowP["CodigoProveedor"]);
											_productoObservaciones = Convert.ToString(rowP["Observaciones"]);
											if ( rowP.IsNull("FechaUltimaModificacionPrecioDeCosto") )
												_productoFechaUltModifPrecioCosto = DateTime.MinValue;
											else
												_productoFechaUltModifPrecioCosto = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeCosto"]);
											
											if ( rowP.IsNull("FechaUltimaModificacionPrecioDeVenta") )
												_productoFechaUltModifPrecioVenta = DateTime.MinValue;
											else
												_productoFechaUltModifPrecioVenta = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeVenta"]);
											// ---- FinMatias
											
										}
									}
									//RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen,Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, permiteCantidadMayorCantidadPendiente, false);
									RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen,Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, permiteCantidadMayorCantidadPendiente, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta );
									this.Add(ItemOrigen);
									
								}
								

							}	
							else
							{
								OrdinalOrigen = row.Ordinal;
								CantidadOrigen = row.Cantidad; 
								SortedList aux = Workflow.GetComprobantesAsociadosList(Workflow.GetIdTakByName(_mainTaskName));
								ArrayList aux1 = new ArrayList(aux.Keys);
								string TiposComprobantesDestino = systemframework.Util.PackString(aux1, ",");
	
								System.Data.DataRow rowPend = businessrules.tpu_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, OrdinalOrigen);
								
	
								decimal Pendiente = CantidadOrigen;
								if (rowPend != null)
								{
									Pendiente = Convert.ToDecimal(rowPend["Cantidad"]);
									if(Pendiente  > 0)
									{
										/*Toma como precio de costo, el precio de la fatura. Dado se a va a pasar la 
											 * factura a partir de la confirmacion del remito.
											 * Ver de poner una variable q indique el tipo de comprobante y asi sacar "CRMXC"
											 * Ademas, tener en cuenta q no siempre se guarda en tpu_ComprobantesDeCompraDetConfirmacionDePrecios,
											 * depende de la confirguracion del cliente
											 * */
										//if(IdTipoDeComprobante.Equals("CRMXC"))
										if(_processName.Equals("ProcesoConfirmarIngresoMercaderia"))
										{
											DataRow rowCP = mz.erp.businessrules.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( IdComprobante, OrdinalOrigen );
											if(rowCP != null)
												PrecioDeCosto = Convert.ToDecimal(rowCP["PrecioDeCostoFactura"]);
											else 
												PrecioDeCosto = row.PrecioDeCostoMonedaOrigen;
										}
										else
										{
											/*En la moneda Origen de comprobante*/
											PrecioDeCosto = row.PrecioDeCostoMonedaOrigen;
										}
										IdSucursal = row.IdSucursal;
										IdEmpresa = row.IdEmpresa;

										IdProducto = row.IdProducto;
										string codigo = string.Empty;
										string codigoSecundario = string.Empty;
										string _productoCampoAuxiliar1 = string.Empty;
										string _productoCampoAuxiliar2 = string.Empty;
										string _productoCampoAuxiliar3 = string.Empty;
										string _productoCampoAuxiliar4 = string.Empty;
										string _productoCampoAuxiliar5 = string.Empty;
										string _productoCampoAuxiliar6 = string.Empty;
										string _productoObservaciones = string.Empty;
										string _productoCodigoProveedor = string.Empty;
										DateTime _productoFechaUltModifPrecioCosto = mz.erp.businessrules.Sistema.DateTime.Now; 
										DateTime _productoFechaUltModifPrecioVenta = mz.erp.businessrules.Sistema.DateTime.Now; 
										if(IdProducto != null && !IdProducto.Equals(string.Empty))
										{
											DataRow rowP  = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
											if(rowP != null)
											{
												codigo = Convert.ToString(rowP["Codigo"]);
												codigoSecundario = Convert.ToString(rowP["CodigoSecundario"]);
												Descripcion = Convert.ToString(rowP["Descripcion"]);

												// ---- Matias - Tarea 204 - 20090721
												_productoCampoAuxiliar1 = Convert.ToString(rowP["CampoAuxiliar1"]);
												_productoCampoAuxiliar2 = Convert.ToString(rowP["CampoAuxiliar2"]);
												_productoCampoAuxiliar3 = Convert.ToString(rowP["CampoAuxiliar3"]);
												_productoCampoAuxiliar4 = Convert.ToString(rowP["CampoAuxiliar4"]);
												_productoCampoAuxiliar5 = Convert.ToString(rowP["CampoAuxiliar5"]);
												_productoCampoAuxiliar6 = Convert.ToString(rowP["CampoAuxiliar6"]);
												_productoCodigoProveedor = Convert.ToString(rowP["CodigoProveedor"]);
												_productoObservaciones = Convert.ToString(rowP["Observaciones"]);
											
												if ( rowP.IsNull("FechaUltimaModificacionPrecioDeCosto") )
													_productoFechaUltModifPrecioCosto = DateTime.MinValue;
												else
													_productoFechaUltModifPrecioCosto = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeCosto"]);
											
												if ( rowP.IsNull("FechaUltimaModificacionPrecioDeVenta") )
													_productoFechaUltModifPrecioVenta = DateTime.MinValue;
												else
													_productoFechaUltModifPrecioVenta = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeVenta"]);
												// ---- FinMatias
											
											}
										}
										//RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen,Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, permiteCantidadMayorCantidadPendiente, false);
										RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen,Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, permiteCantidadMayorCantidadPendiente, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta );
										this.Add(ItemOrigen);
									
									}
								}
								

							
							}
						}
					}				
				}
			
				//
				// TODO: agregar aquí la lógica del constructor
				//
			}


        //German 20110309 - Tarea 0000038
        public RelacionesComprobanteDeCompraOrigenDestino(ComprobanteDeCompra CompOrigen)
        {

            
                //Datos comunes a todos los items de un mismo comprobante
                this._numero = CompOrigen.Numero;
                this._idComprobante = IdComprobante;
                this._idTipoDeComprobante = CompOrigen.TipoComprobanteDestino;
                this._multiplesOrigenes = false;

                _campoAuxiliar1 = CompOrigen.CampoAuxiliar1;
                //German 20090326
                _campoAuxiliar2 = CompOrigen.CampoAuxiliar2;
                _campoAuxiliar3 = CompOrigen.CampoAuxiliar3;
                _campoAuxiliar4 = CompOrigen.CampoAuxiliar4;
                //Fin German 20090326
                long OrdinalOrigen = -1;
                decimal CantidadOrigen = 0;
                string IdProducto = String.Empty;
                string Descripcion = String.Empty;
                long IdSucursal = Security.IdSucursal;
                long IdEmpresa = Security.IdEmpresa;
                DateTime Fecha = CompOrigen.FechaComprobante;
                Decimal PrecioDeCosto = 0;
                this._idProveedor = CompOrigen.IdProveedor;
                this._idResponsable = CompOrigen.IdResponsable;
                this._idMonedaDestino = CompOrigen.IdMonedaCierre;
                this._idFuenteDeCambio = CompOrigen.IdFuenteDeCambioProveedor;
                this._idCotizacion = CompOrigen.IdCotizacionCierre;
                this._valorCotizacion = CompOrigen.ValorCotizacionProveedor;
                this._fechaComprobante = CompOrigen.FechaComprobante;
                this._idFuenteDeCambioProveedor = CompOrigen.IdFuenteDeCambioProveedor;
                this._idMonedaOrigen = CompOrigen.IdMonedaOrigen;
                this._valorCotizacionProveedor = CompOrigen.ValorCotizacionProveedor;
                this._observaciones = CompOrigen.Observaciones;
                this._conceptosGravados = new ItemsConcepto();
                this._conceptosNoGravados = new ItemsConcepto();
                this._fechaRecepcionMercaderia = CompOrigen.FechaRecepcionMercaderia;
                this._idCondicionDeCompra = CompOrigen.IdCondicionDeCompra;
                
                foreach (ItemComprobanteCompra item in CompOrigen.Items)
                {
                        
                    OrdinalOrigen = item.Ordinal;
                    CantidadOrigen = item.Cantidad;
                    decimal Pendiente = CantidadOrigen;
                    if (Pendiente > 0)
                    {
                        PrecioDeCosto = item.PrecioDeCosto;
                        IdSucursal = IdSucursal;
                        IdEmpresa = IdEmpresa;
                        IdProducto = item.IdProducto;
                        string codigo = string.Empty;
                        string codigoSecundario = string.Empty;
                        string _productoCampoAuxiliar1 = string.Empty;
                        string _productoCampoAuxiliar2 = string.Empty;
                        string _productoCampoAuxiliar3 = string.Empty;
                        string _productoCampoAuxiliar4 = string.Empty;
                        string _productoCampoAuxiliar5 = string.Empty;
                        string _productoCampoAuxiliar6 = string.Empty;
                        string _productoObservaciones = string.Empty;
                        string _productoCodigoProveedor = string.Empty;
                        DateTime _productoFechaUltModifPrecioCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                        DateTime _productoFechaUltModifPrecioVenta = mz.erp.businessrules.Sistema.DateTime.Now;
                        if (IdProducto != null && !IdProducto.Equals(string.Empty))
                        {
                            DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
                            if (rowP != null)
                            {
                                codigo = Convert.ToString(rowP["Codigo"]);
                                codigoSecundario = Convert.ToString(rowP["CodigoSecundario"]);
                                Descripcion = Convert.ToString(rowP["Descripcion"]);

                                // ---- Matias - Tarea 204 - 20090721
                                _productoCampoAuxiliar1 = Convert.ToString(rowP["CampoAuxiliar1"]);
                                _productoCampoAuxiliar2 = Convert.ToString(rowP["CampoAuxiliar2"]);
                                _productoCampoAuxiliar3 = Convert.ToString(rowP["CampoAuxiliar3"]);
                                _productoCampoAuxiliar4 = Convert.ToString(rowP["CampoAuxiliar4"]);
                                _productoCampoAuxiliar5 = Convert.ToString(rowP["CampoAuxiliar5"]);
                                _productoCampoAuxiliar6 = Convert.ToString(rowP["CampoAuxiliar6"]);
                                _productoCodigoProveedor = Convert.ToString(rowP["CodigoProveedor"]);
                                _productoObservaciones = Convert.ToString(rowP["Observaciones"]);

                                if (rowP.IsNull("FechaUltimaModificacionPrecioDeCosto"))
                                    _productoFechaUltModifPrecioCosto = DateTime.MinValue;
                                else
                                    _productoFechaUltModifPrecioCosto = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeCosto"]);

                                if (rowP.IsNull("FechaUltimaModificacionPrecioDeVenta"))
                                    _productoFechaUltModifPrecioVenta = DateTime.MinValue;
                                else
                                    _productoFechaUltModifPrecioVenta = Convert.ToDateTime(rowP["FechaUltimaModificacionPrecioDeVenta"]);
                                // ---- FinMatias

                            }
                        }
                        //RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen,Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, permiteCantidadMayorCantidadPendiente, false);
                        RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, Pendiente, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa, codigo, codigoSecundario, _fechaComprobante, _fechaRecepcionMercaderia, false, false, _productoCampoAuxiliar1, _productoCampoAuxiliar2, _productoCampoAuxiliar3, _productoCampoAuxiliar4, _productoCampoAuxiliar5, _productoCampoAuxiliar6, _productoCodigoProveedor, _productoObservaciones, _productoFechaUltModifPrecioCosto, _productoFechaUltModifPrecioVenta);
                        this.Add(ItemOrigen);

                    }
                }

        }
        //Fin German 20110309 - Tarea 0000038
		#endregion

		#region Metodos Override CollectionBase
		
			public virtual void Add( RelacionComprobanteDeCompraOrigenDestino rcod )
			{				
				List.Add ( rcod );			
			}
			
			public RelacionComprobanteDeCompraOrigenDestino Get(int index)
			{
				return (RelacionComprobanteDeCompraOrigenDestino) List[index];
			}

			public RelacionComprobanteDeCompraOrigenDestino GetByIdProducto(string IdProducto)
			{
				foreach(RelacionComprobanteDeCompraOrigenDestino ror in this.List)
				{
					if(ror.IdProducto.Equals(IdProducto))
						return ror;
				}
				return null;
			}


		#endregion

		#region Metodos
		/// <summary>
		/// Devuelve los comprobantes destino habilitados una vez que chequeo por cada comprobante y ordinal del detalle cuales son los comprobante destino
		/// que podrian efectuados y a su vez del resultado obtenido cuales de aquellos no estan en infracción por generar un ciclo dentro del workflow de comprobantes.
		/// Por cada comprobante sugerido chequeo que no existan exclusiones por circuitos
		/// Cada vez que itere devuelvo una nueva lista con los valores resultados, si a la lista se le
		/// van excluyendo progresivamente los comprobantes que contienen algunas vueltas de ciclo
		/// esta función puede llegar a dar como resultado que ningun comprobante sugerido está habilitado
		/// para completar el ciclo de los comprobantes origenes seleccionados.
		/// </summary>
		/// <returns></returns>
			public ArrayList ComprobantesDestinoPermitidos()
			{
				
				Hashtable lista = new Hashtable();
				foreach( RelacionComprobanteDeCompraOrigenDestino detalle in this.List )
				{
					ArrayList array = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.GetTipoComprobanteDestino( detalle.IdTipoDeComprobante );
					for (int i=0;i<array.Count;i++)
					{
						if (!lista.Contains( array[i] ))
						{
							lista.Add( array[i], true );
						}
					
					}
				}
				ArrayList arrayresultado = new ArrayList();
				Hashtable tablaNueva = new Hashtable();
				foreach( RelacionComprobanteDeCompraOrigenDestino detalle in this.List )
				{
					foreach(object key in lista.Keys)
					{
						if ((bool)lista[key])
						{
							string comprobantesugerido = Convert.ToString(key);
							bool puedohacer = true; //funcionGerman.QuieroHacer( comprobantesugerido, idcomprobante, Ordinal )
							if(!(tablaNueva.Contains(key)))
								tablaNueva.Add(key,puedohacer);
						}
					}

				}
				foreach( object key in tablaNueva.Keys )
				{
					if ((bool)tablaNueva[key])
					{
						arrayresultado.Add( (string)key );
					}
				}
				return arrayresultado;
			}

		public ArrayList Sort(string key)
		{
			ArrayList aux = new ArrayList(this.List);
			switch (key)
			{
				case "FR": aux.Sort(new FechaRecepcionComparer());break;
			}
			return aux;
		}

		#endregion

		#region Variables Privadas

			private string _idComprobante = string.Empty;
			private string _idTipoDeComprobante = string.Empty;
			private string _idResponsable = string.Empty;
			private string _idProveedor = string.Empty;
			private string _idMonedaOrigen = string.Empty;
			private string _idMonedaDestino = string.Empty;
			private string _idCotizacion = string.Empty;
			private decimal _valorCotizacion = 1;
			private string _idFuenteDeCambio = string.Empty;
			private string _idFuenteDeCambioProveedor = string.Empty;
			private DateTime _fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
			private string _campoAuxiliar1 = string.Empty;
			private decimal _valorCotizacionProveedor = 1;
			private string _processName = string.Empty;
			private string _taskName = string.Empty;
			private string _mainTaskName = string.Empty;
			private string _numero = string.Empty;
			private bool _multiplesOrigenes = false;
			private FacturaDeCompraItems _factura;
			private string _transicionesDeEstados = string.Empty;
			private string _idCondicionDeCompra = string.Empty;

			private string _campoAuxiliar2 = string.Empty;
			private string _campoAuxiliar3 = string.Empty;
			private decimal _campoAuxiliar4 = 0;
			private string _campoAuxiliar5 = string.Empty;

		#endregion

		#region Propiedades

		public string IdTipoDeComprobante
		{
			get{return _idTipoDeComprobante;}
		}

				public string IdCondicionDeCompra
				{
					get{return _idCondicionDeCompra;}
				}

		public FacturaDeCompraItems Factura
		{
			get{return _factura;}
		}

		public bool MultiplesOrigenes
		{
			get{return _multiplesOrigenes;}
		}

		public string IdComprobante 
		{
			get{return _idComprobante;}
		}


		public string Numero 
		{
			get{return _numero;}
		}

		public decimal ValorCotizacionProveedor
		{
			get{return _valorCotizacionProveedor;}
		}

		

		public string CampoAuxiliar1
		{
			get{return _campoAuxiliar1;}
		}


		//German 20090326

		public string CampoAuxiliar2
		{
			get{return _campoAuxiliar2;}
		}
		public string CampoAuxiliar3
		{
			get{return _campoAuxiliar3;}
		}
		public decimal CampoAuxiliar4
		{
			get{return _campoAuxiliar4;}
		}
		public string CampoAuxiliar5
		{
			get{return _campoAuxiliar5;}
		}

		//Fin German 20090326

		public string IdMonedaOrigen
		{
			get{return _idMonedaOrigen;}
		}
		public string IdMonedaDestino
		{
			get{return _idMonedaDestino;}
		}

		public string IdCotizacion
		{
			get{return _idCotizacion;}
		}

		public decimal ValorCotizacion
		{
			get{return _valorCotizacion;}
		}

		public DateTime FechaComprobante
		{
			get{return _fechaComprobante;}
		}

		public string IdFuenteDeCambio
		{
			get{return _idFuenteDeCambio;}
		}

		public string IdFuenteDeCambioProveedor
		{
			get{return _idFuenteDeCambioProveedor;}
		}
		
		public string IdResponsable
		{
			//set{_idResponsable = value;	}
			get{return _idResponsable;}
		}
		public string IdProveedor
		{
			//set{_idProveedor = value;}
			get{return _idProveedor;}
		}

		private string _idCuentaImputacion = string.Empty;
		public string IdCuentaImputacion 
		{
			get{return _idCuentaImputacion;}			
			//set {_idCuentaImputacion = value;}
		}

		private string _idSubCuentaImputacion = string.Empty;
		public string IdSubCuentaImputacion
		{
			get{return _idSubCuentaImputacion;}			
			//set {_idSubCuentaImputacion = value;}
		}

		private string _cai = string.Empty;
		public string CAI
		{
			get{return _cai;}			
			//set {_cai = value;}
		}

		private string _leyenda = string.Empty;
		public string Leyenda
		{
			get{return _leyenda;}			
			//set {_leyenda = value;}
		}

		private string _observaciones = string.Empty;
		public string Observaciones
		{
			get{return _observaciones;}
			//set{_observaciones = value;}
		}

		private string _mesDeImputacion = string.Empty;
		public string MesDeImputacion
		{
			get{return _mesDeImputacion;}
			//set{_mesDeImputacion = value;}
		}

		private string _mesDeDevengamiento = string.Empty;
		public string MesDeDevengamiento
		{
			get{return _mesDeDevengamiento;}
		}
		
		private DateTime _fechaRecepcionMercaderia = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaRecepcionMercaderia
		{
			get{return _fechaRecepcionMercaderia;}
			//set{_fechaRecepcionMercaderia = value;}
		}
		private bool _isValidFechaVencimiento = false;
		public bool IsValidFecheVencimiento 
		{
			get{return _isValidFechaVencimiento;}
		}
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaVencimiento
		{
			get{return _fechaVencimiento;}
			//set{_fechaVencimiento = value;}
		}
		private DateTime _fechaProximoVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaProximoVencimiento
		{
			get{return _fechaProximoVencimiento;}
			//set{_fechaProximoVencimiento = value;}
		}		
				
		private decimal _netoBruto = 0;
		public decimal NetoBruto
		{
			get{return _netoBruto;}
			//set{_netoBruto = value;}			
		}

		private decimal _descuentos = 0;
		public decimal Descuentos 
		{
			get{return _descuentos;}
			//set{_descuentos = value;}			
		}
		private decimal _neto = 0;
		public decimal Neto 
		{
			get{return _neto;}
			//set{_neto = value;}
		}	

		private decimal _impuestos = 0;
		public decimal Impuestos
		{
			get{return _impuestos;}
		}

		private decimal _total = 0;
		public decimal Total
		{
			get{return _total;}			
			set{_total = value;}
		}	
	
		private decimal _descuentoGeneral = 0;
		public decimal DescuentoGeneral 
		{
			get{return _descuentoGeneral;}	
			//set {_descuentoGeneral = value;}
		}	
		
		private decimal _totalGeneral = 0;
		public decimal TotalGeneral 
		{
			get{return _totalGeneral;}			
			//set{_totalGeneral = value;}
		}	

		private ItemsConcepto _conceptosGravados;
		public ItemsConcepto ConceptosGravados
		{
			get{return _conceptosGravados;}			
		}		
		private ItemsConcepto _conceptosNoGravados;
		public ItemsConcepto ConceptosNoGravados
		{
			get{return _conceptosNoGravados;}			
		}
		#endregion

	}

	public class FechaRecepcionComparer: IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			RelacionComprobanteDeCompraOrigenDestino xx = (RelacionComprobanteDeCompraOrigenDestino) x;
			RelacionComprobanteDeCompraOrigenDestino yy = (RelacionComprobanteDeCompraOrigenDestino) y;
			return xx.FechaRecepcionMercaderia.CompareTo(yy.FechaRecepcionMercaderia);
		}

		#endregion

	}


	public class RelacionComprobanteDeCompraOrigenDestino
	{
		
		#region Variables Privadas

		private long _ordinalOrigen;
		private decimal _cantidadOrigen;
		private decimal _cantidadDestino;
		private string _idProducto = string.Empty;
		private string _descripcion = string.Empty;
		private decimal _precioDeCosto; //Esta en la moneda Origen del comprobante
		private string _idComprobante = string.Empty;
		private string _idTipoDeComprobante = string.Empty;
		private string _numero = string.Empty;
		private long _idSucursal=0;
		private long _idEmpresa = 0;
		private string _codigo = string.Empty;
		private string _codigoSecundario = string.Empty;
		private decimal _cantidadPendiente;
		private DateTime _fechaRecepcionMercaderia = DateTime.Now;
		private DateTime _fechaEmision = DateTime.Now;
		private Producto _producto;

		private bool _permiteCantidadMayorACantidadPendiente = false;

		private bool _origenMultiple = false;
		private ArrayList _origenes = new ArrayList();

		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private string _campoAuxiliar4 = string.Empty;
		private string _campoAuxiliar5 = string.Empty;
		private string _campoAuxiliar6 = string.Empty;
		private string _codigoProveedor = string.Empty;
		private string _observaciones = string.Empty;
		private DateTime _fechaUltModifPrecioCosto;
		private DateTime _fechaUltModifPrecioVenta;

		#endregion

		#region Propiedades	

		public bool OrigenMultiple
		{
			get{return _origenMultiple;}
			
		}

		public ArrayList Origenes
		{
			get{return _origenes;}
			
		}


		public DateTime FechaEmision
		{
			get{return _fechaEmision;}
			//set{_fechaEmision = value;}
		}

		public DateTime FechaRecepcionMercaderia
		{
			get{return _fechaRecepcionMercaderia;}
			//set{_fechaRecepcionMercaderia = value;}
		}

		public Producto MiProducto
		{
			get{return _producto;}
			set{_producto = value;}
		}

		public decimal CantidadPendiente
		{
			get{return _cantidadPendiente;}
			set{ _cantidadPendiente = value;}
		}
		
		public string Codigo
		{
			get{return _codigo;}
		}

		public string CodigoSecundario
		{
			get{return _codigoSecundario;}
		}
		

		
		public long OrdinalOrigen 
		{
			get{return _ordinalOrigen;}
		}
		
		public decimal CantidadOrigen 
		{
			get {return _cantidadOrigen;}
		}
		
		public decimal CantidadDestino
		{
			get {return _cantidadDestino;}
			set 
			{
				if (value <= _cantidadOrigen || _permiteCantidadMayorACantidadPendiente)
				{
					_cantidadDestino = value;
				}
				else 
				{
					_cantidadDestino = 0;
				}
			}
		}

		
		public string IdProducto 
		{
			get {return _idProducto;}
		}
		
		public string Descripcion 
		{
			get {return _descripcion;}
		}
		
		public decimal PrecioDeCosto 
		{
			get{return _precioDeCosto;}
			set{_precioDeCosto = value;}
		}

		public string IdComprobante
		{
			get {return _idComprobante;}
		}

		
		public string IdTipoDeComprobante
		{
			get {return _idTipoDeComprobante;}
		}

		
		public string Numero
		{
			get	{return _numero;}
		}
		
		public long IdSucursal
		{
			get	{return _idSucursal;}
		}
		
		public long IdEmpresa
		{
			get{return _idEmpresa;}
		}

		// ---- Matias - Tarea 204 - 20090721
		public string CampoAuxiliar1
		{
			get	{return _campoAuxiliar1;}
		}
		public string CampoAuxiliar2
		{
			get	{return _campoAuxiliar2;}
		}
		public string CampoAuxiliar3
		{
			get	{return _campoAuxiliar3;}
		}
		public string CampoAuxiliar4
		{
			get	{return _campoAuxiliar4;}
		}
		public string CampoAuxiliar5
		{
			get	{return _campoAuxiliar5;}
		}
		public string CampoAuxiliar6
		{
			get	{return _campoAuxiliar6;}
		}
		public string CodigoProveedor
		{
			get	{return _codigoProveedor;}
		}
		public string Observaciones
		{
			get	{return _observaciones;}
		}
		public DateTime FechaUltimaModificacionPrecioCosto
		{
			get	{return _fechaUltModifPrecioCosto;}
		}
		public DateTime FechaUltimaModificacionPrecioVenta
		{
			get	{return _fechaUltModifPrecioVenta;}
		}
		// ---- FinMatias

		#endregion

		#region Constructores

		public RelacionComprobanteDeCompraOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, long OrdinalOrigen, decimal CantidadOrigen,decimal CantidadDestino, string IdProducto, string Descripcion, decimal PrecioDeCosto, long IdSucursal, long IdEmpresa, string Codigo, string CodigoSecundario, DateTime FechaComprobante, DateTime FechaRecepcionMercaderia, bool PermiteCantidadMayorACantidadPendiente, bool OrigenAcumulado)
		{
			_codigo = Codigo;
			_codigoSecundario = CodigoSecundario;
			_idComprobante = IdComprobante;
			_idTipoDeComprobante = IdTipoDeComprobante;
			_numero = Numero;			
			_ordinalOrigen = OrdinalOrigen;
			_cantidadOrigen = CantidadOrigen;
			_cantidadDestino = CantidadDestino;
			_cantidadPendiente = CantidadDestino;
			_idProducto = IdProducto;
			_descripcion = Descripcion;
			_precioDeCosto = PrecioDeCosto;
			_idSucursal = IdSucursal;
			_idEmpresa = IdEmpresa;			
			_fechaEmision = FechaComprobante;
			_fechaRecepcionMercaderia = FechaRecepcionMercaderia;
			_permiteCantidadMayorACantidadPendiente = PermiteCantidadMayorACantidadPendiente;
			_origenMultiple = OrigenAcumulado;
		
		}

		// ---- Matias
		public RelacionComprobanteDeCompraOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, long OrdinalOrigen, decimal CantidadOrigen,decimal CantidadDestino, string IdProducto, string Descripcion, decimal PrecioDeCosto, long IdSucursal, long IdEmpresa, string Codigo, string CodigoSecundario, DateTime FechaComprobante, DateTime FechaRecepcionMercaderia, bool PermiteCantidadMayorACantidadPendiente, bool OrigenAcumulado, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string CampoAuxiliar6, string CodigoProveedor, string Observaciones, DateTime FechaUltModifPrecioCosto, DateTime FechaUltModifPrecioVenta )
		{
			_codigo = Codigo;
			_codigoSecundario = CodigoSecundario;
			_idComprobante = IdComprobante;
			_idTipoDeComprobante = IdTipoDeComprobante;
			_numero = Numero;			
			_ordinalOrigen = OrdinalOrigen;
			_cantidadOrigen = CantidadOrigen;
			_cantidadDestino = CantidadDestino;
			_cantidadPendiente = CantidadDestino;
			_idProducto = IdProducto;
			_descripcion = Descripcion;
			_precioDeCosto = PrecioDeCosto;
			_idSucursal = IdSucursal;
			_idEmpresa = IdEmpresa;			
			_fechaEmision = FechaComprobante;
			_fechaRecepcionMercaderia = FechaRecepcionMercaderia;
			_permiteCantidadMayorACantidadPendiente = PermiteCantidadMayorACantidadPendiente;
			_origenMultiple = OrigenAcumulado;
			_campoAuxiliar1 = CampoAuxiliar1;
			_campoAuxiliar2 = CampoAuxiliar2;
			_campoAuxiliar3 = CampoAuxiliar3;
			_campoAuxiliar4 = CampoAuxiliar4;
			_campoAuxiliar5 = CampoAuxiliar5;
			_campoAuxiliar6 = CampoAuxiliar6;
			_codigoProveedor = CodigoProveedor;
			_observaciones = Observaciones;
			_fechaUltModifPrecioCosto = FechaUltModifPrecioCosto;
			_fechaUltModifPrecioVenta = FechaUltModifPrecioVenta;
		}

		/*
		private void AddOrigen(RelacionComprobanteDeCompraOrigen origen)
		{
			this._origenes.Add(origen);
			
		}
		*/

		#endregion

	}

	public class RelacionComprobanteDeCompraOrigen
	{	
	
		private string _idComprobanteOrigen = string.Empty;
		private long _ordinalOrigen;
		private decimal _cantidadOrigen;
		private decimal _precioDeCostoOrigen; 
		private decimal _cantidadOrigenPendiente;

		public RelacionComprobanteDeCompraOrigen(string IdComprobanteOrigen,  long Ordinal , decimal Cantidad, decimal CantidadPendiente, decimal PrecioDeCosto)
		{
			_ordinalOrigen = Ordinal;
			_cantidadOrigen = Cantidad;
			_cantidadOrigenPendiente = CantidadPendiente;
			_precioDeCostoOrigen = PrecioDeCosto;
			_idComprobanteOrigen = IdComprobanteOrigen;
		}

		public long OrdinalOrigen
		{
			get{return _ordinalOrigen;}
		}
		public decimal CantidadOrigenPendiente
		{
			get{return _cantidadOrigenPendiente;}
		}

		public decimal CantidadOrigen
		{
			get{return _cantidadOrigen;}
		}

		public decimal PrecioDeCostoOrigen
		{
			get{return _precioDeCostoOrigen;}
		}

		public string IdComprobanteOrigen
		{
			get{return _idComprobanteOrigen;}
		}


		
		
	}



	public class CondicionDeCompra
	{
		private string _idCondicionDeCompra = string.Empty;
		private string _descripcion = string.Empty;
		private long _orden = 0;
		private long _diasVencimiento = 0;
		private decimal _recargo = 0;

		public CondicionDeCompra()
		{
		}

		public CondicionDeCompra(tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row)
		{
			_idCondicionDeCompra = row.IdCondicionDeCompra;
			_orden = row.Orden;
			_descripcion = row.Descripcion;
			_diasVencimiento = row.DiasVencimiento;
			_recargo = row.Recargo;
		}

		public CondicionDeCompra(string IdCondicionDeCompra, string Descripcion, long Orden, long DiasVencimiento, decimal Recargo)
		{
			_idCondicionDeCompra = IdCondicionDeCompra;
			_descripcion = Descripcion;
			_recargo = Recargo;
			_orden = Orden;
			_diasVencimiento = DiasVencimiento;
		}

		public decimal Recargo
		{
			get{return _recargo;}
		}

		public long DiasVencimiento
		{
			get{return _diasVencimiento;}
		}

		public long Orden
		{
			get{return _orden;}
		}


		public string Descripcion
		{
			get{return _descripcion;}
		}

		public string IdCondicionDeCompra
		{
			get{return _idCondicionDeCompra;}
			//set{ _idCondicionDeCompra = value;}
		}

		
	}

	public class CondicionesDeComprasFactory
	{
		private static  tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable _table;

		public static CondicionDeCompra GetCondicionDeCompraInstance(string IdCondicionDeCompra)
		{
			if(_table == null)
				_table = mz.erp.businessrules.tpu_CondicionesDeCompras.GetList().tpu_CondicionesDeCompras;
			if(IdCondicionDeCompra == null || IdCondicionDeCompra == string.Empty)
				return new CondicionDeCompra();
			tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row = _table.FindByIdCondicionDeCompra(IdCondicionDeCompra);
			return new CondicionDeCompra(row);

		}

        /* Silvina 20110426 - Tarea 0000017 */
        public static void Clear()
        {
            _table = null;
        }
        /* Fin Silvina 20110426 - Tarea 0000017 */
	}


	#endregion
	
}





