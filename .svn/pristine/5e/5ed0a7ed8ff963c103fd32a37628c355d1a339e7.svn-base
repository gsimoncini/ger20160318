using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using System.ComponentModel;
/// <summary>
/// Clase Items Comprobantes. Contiene una coleccion de items. Esta coleccion es contenida por un
/// comprobante de venta
/// </summary>
public class ItemsComprobantes	: CollectionBase, ITypedList



{
	/*Modificado para tener encuenta Visibles y no Visibles*/
	public long Ordinal
	{
		get
		{
			/*
			if(List.Count == 0)
				return 0;
			else
				//return ((ItemComprobante)List[List.Count - 1]).Ordinal + 1;
			*/
			return this.GetOrdinal();
		}

	}


	public System.ComponentModel.PropertyDescriptorCollection GetItemProperties ( System.ComponentModel.PropertyDescriptor[] listAccessors )
	{
		if(listAccessors == null)
		{
			return System.ComponentModel.TypeDescriptor.GetProperties(typeof(ItemComprobante));
		}
		else
			for(int i =0; i< listAccessors.Length; i++)

				if(listAccessors[i].Name == "Impuestos")
					return System.ComponentModel.TypeDescriptor.GetProperties(typeof(Impuestos));
		return null;
	}




	public  System.String GetListName ( System.ComponentModel.PropertyDescriptor[] listAccessors )
	{
		return "";
	}

		
	public Hashtable GetORAsociadas()
	{
		Hashtable _ordenReparacionInstancias = new Hashtable();
		foreach(ItemComprobante item in this.List)
		{
			if(item.Codigo != "9999999")
			{
				//German 20090915
				//if(item.IdOrdenReparacion != long.MinValue && item.IdOrdenReparacion > 0 && item.IdInstanciaOrdenReparacion != long.MinValue && item.IdInstanciaOrdenReparacion > 0)
				if(item.IdOrdenReparacion != long.MinValue && item.IdOrdenReparacion > 0)
				//Fin German 20090915
				{
					if(!_ordenReparacionInstancias.ContainsKey(item.IdOrdenReparacion))
					{
						_ordenReparacionInstancias.Add(item.IdOrdenReparacion, new ArrayList());
					}
					if(item.IdInstanciaOrdenReparacion != long.MinValue && item.IdInstanciaOrdenReparacion > 0)
					{
						ArrayList instancias = (ArrayList)_ordenReparacionInstancias[item.IdOrdenReparacion];
						if(!instancias.Contains(item.IdInstanciaOrdenReparacion))
							instancias.Add(item.IdInstanciaOrdenReparacion);
					}
				}
			}
		}
		foreach(ItemComprobante item in this.ItemsNoVisibles)
		{
			if(item.Codigo != "9999999")
			{
				//German 20090915
				//if(item.IdOrdenReparacion != long.MinValue && item.IdOrdenReparacion > 0 && item.IdInstanciaOrdenReparacion != long.MinValue && item.IdInstanciaOrdenReparacion > 0)
				if(item.IdOrdenReparacion != long.MinValue && item.IdOrdenReparacion > 0)
				//Fin German 20090915
				{
					if(!_ordenReparacionInstancias.ContainsKey(item.IdOrdenReparacion))
					{
						_ordenReparacionInstancias.Add(item.IdOrdenReparacion, new ArrayList());
					}
					if(item.IdInstanciaOrdenReparacion != long.MinValue && item.IdInstanciaOrdenReparacion > 0)
					{
						ArrayList instancias = (ArrayList)_ordenReparacionInstancias[item.IdOrdenReparacion];
						if(!instancias.Contains(item.IdInstanciaOrdenReparacion))
							instancias.Add(item.IdInstanciaOrdenReparacion);
					}
				}
			}
		}
		return _ordenReparacionInstancias;
	}

	
	
	
	
	public delegate void RecalcularItems( object sender, System.EventArgs e );
	/// <summary>
	/// Se dispara cada vez que se ha modificado algun atributo que puede afectar a otras
	/// variables de cálculo del comprobante.
	/// </summary>
	public event RecalcularItems OnRecalcItems;

	public delegate void RefrescarItems( object sender, System.EventArgs e );
	public event RefrescarItems OnRefreshItems;

	private ComprobanteDeVenta _comprobanteDeVenta;
	/// <summary>
	/// El comprobante de Venta que lo contiene
	/// </summary>
	public ComprobanteDeVenta ComprobanteDeVenta
	{
		get { return _comprobanteDeVenta; }
		set { _comprobanteDeVenta = value; }
	}

	public virtual void RemoveAt(int index)
	{
		base.RemoveAt(index);
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}

	
	}

	public void OnRecalcularItems()
	{
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}

	public ItemsComprobantes( string action, ComprobanteDeVenta comprobanteDeVenta, RelacionesComprobanteOrigenDestino relaciones)
	{
		_comprobanteDeVenta = comprobanteDeVenta;
		Init(action, relaciones);
	}
	/// <summary>
	/// Constructor. Crea una nueva instancia de la coleccion de items
	/// </summary>
	/// <param name="comprobanteDeVenta">
	/// El comprobante de venta que lo contiene
	/// </param>
	public ItemsComprobantes( string action, ComprobanteDeVenta comprobanteDeVenta )
	{
		_comprobanteDeVenta = comprobanteDeVenta;
		Init(action,null);
	}

	private void Init( string action, RelacionesComprobanteOrigenDestino relaciones)
	{
		switch (action.ToUpper())
		{
			case "NEW":
				break;
			case "EDIT":
				FillEditData();
				break;
			case "STEP":
				FillStepData( relaciones );
				break;
		}
		

	}
	/// <summary>
	/// Agrega una instancia de item a la coleccion de items.
	/// </summary>
	/// <param name="item">
	/// Item de la clase <see cref="ItemComprobante"/>
	/// </param>
	/// 
	

	public virtual void OnRemoveComplete(int index, object item)
	{
		base.OnRemoveComplete(index, item);
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
		

	}

	public virtual void OnRemove(int index, object item)
	{
		base.OnRemove(index, item);
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}

	private void FillEditData()
	{	
		//tsa_ComprobantesDetDataset data =  (tsa_ComprobantesDetDataset)mz.erp.businessrules.tsa_ComprobantesDet.GetList( this._comprobanteDeVenta.IdComprobante,DateTime.MinValue,null,null, long.MinValue);
		tsa_ComprobantesDetDataset data =  (tsa_ComprobantesDetDataset)mz.erp.businessrules.tsa_ComprobantesDet.GetByPk( this._comprobanteDeVenta.IdComprobante);
		System.Data.DataTable table = data.Tables[0];
				
		foreach(System.Data.DataRow row in table.Rows)
		{	
			Productos miProducto = new mz.erp.businessrules.Productos(  (string) row["IdProducto"] );
			
			Item item = new Item(miProducto);
			item.IdProducto = miProducto.IdProducto;
			item.Cantidad = (decimal)row["Cantidad"];
			item.PrecioNeto = (decimal)row["PrecioNeto"];
			item.PrecioBruto = (decimal)row["PrecioBruto"];
			item.Descripcion = miProducto.Descripcion;
			item.DescripcionCorta = miProducto.DescripcionCorta;
			item.DescripcionLarga = miProducto.DescripcionLarga;
			item.BonificacionRecargoProducto = (decimal)row["BonificacionRecargoProducto"];
			item.PrecioCostoMonedaReferencia = (decimal)row["PrecioDeCosto"];
			item.BonificacionAplicada = (decimal)row["DescuentosAplicados"];
			item.BonificacionRecargoFinanciero = (decimal)row["BonificacionRecargoFinanciero"];
			item.OrdinalDestino = (long)row["Ordinal"];
			
			/*Nuevo medidas German*/
			item.SetConversion(this._comprobanteDeVenta.Momento);
			item.IdListaDePrecios = (string)row["IdListaDePrecio"];
			item.CoeficienteListaDePrecios = (decimal)row["CoeficienteListaDePrecio"];
			item.ModoDeAplicacionListaDePrecios = (string)row["ModoDeAplicacion"];



			ItemComprobante miItemComprobante = new ItemComprobante("EDIT", this, item );
			//if (miItemComprobante.Visible)
			this.Add(miItemComprobante);
			
			//Hasta Aca
			//this.Add(new ItemComprobante("EDIT",this, row));
		}
	}
    //German 20120307 - Tarea 0000290
    public bool ContainsCached(string IdProducto)
    {
        foreach (ItemComprobante it in this._itemsCached)
        {
            if (it.IdProducto.Equals(IdProducto))
                return true;
        }
        return false;
    }


    public ArrayList GetByIdProductoCached(string IdProducto)
    {
        ArrayList result = new ArrayList();
        foreach (ItemComprobante item in this._itemsCached)
        {
            if (item.IdProducto.Equals(IdProducto))
                result.Add(item);
        }
        return result;
    }



    //Fin German 20120307 - Tarea 0000290

	private void FillStepData( RelacionesComprobanteOrigenDestino relaciones )
	{
		this.ClearCache();
		bool PermitePendienteCero = Variables.GetValueBool(_comprobanteDeVenta.ProcessName(), _comprobanteDeVenta.TaskName(), "PermitePendienteCero");
		string IdListaDePrecioDefault = Variables.GetValueString(_comprobanteDeVenta.ProcessName(), _comprobanteDeVenta.TaskName(), "ListaDePreciosDefault");
		string listaComodines = Variables.GetValueString(_comprobanteDeVenta.ProcessName(), _comprobanteDeVenta.TaskName(), "Emision.Editar.Items.ListaItemComodin");
		bool permiteComodin = Variables.GetValueBool(_comprobanteDeVenta.ProcessName(), _comprobanteDeVenta.TaskName(), "Emision.Editar.Items.HabilitaItemComodin");
		foreach(RelacionComprobanteOrigenDestino relacion in relaciones)
		{

           
            if (relacion.CantidadDestino > 0 || PermitePendienteCero)
			{
				System.Data.DataRow row = (System.Data.DataRow)mz.erp.businessrules.tsa_ComprobantesDet.GetByPk( relacion.IdComprobante, relacion.OrdinalOrigen );
				decimal precioDeCosto = 0;
				decimal bonificacionAplicada = 0;
				decimal bonificacionRecargoFinanciero = 0;
				decimal bonificacionRecargoProducto = 0;
				decimal precioBruto = 0;
				decimal porcentajeDescuento = 0;
                //Sabrina: Tarea 1075. 20110323
                string idCombo = string.Empty;
                string combo = string.Empty;
                //Fin Sabrina: Tarea 1075. 20110323
				
				if (row != null)
				{
					precioDeCosto = (decimal)row["PrecioDeCosto"];
					bonificacionAplicada = (decimal)row["DescuentosAplicados"];
					bonificacionRecargoFinanciero = (decimal)row["BonificacionRecargoFinanciero"];
					bonificacionRecargoProducto = (decimal)row["BonificacionRecargoProducto"];
					precioBruto = (decimal)row["PrecioBruto"];
					_porcentajeRecargoFinanciero = bonificacionRecargoFinanciero;	
					porcentajeDescuento = (decimal)row["PorcentajeDescuentoFijoAplicado"];
                    //Sabrina: Tarea 1075. 20110323
                    idCombo = (string)row["IdCombo"];
                    combo = (string)row["Combo"];
                    //Fin Sabrina: Tarea 1075. 20110323
				}

                //German 20120224 -  Tarea 0000247
                Productos miProducto = null;
                if (!this.ComprobanteDeVenta.ListasDePrecios)
                    miProducto = new mz.erp.businessrules.Productos(relacion.IdProducto);
                else
                {

                    miProducto = new mz.erp.businessrules.Productos("IdProducto", relacion.IdProducto, relacion.IdListaDePrecios, tsh_ListasDePrecios.GetDefault().IdListaDePrecio, this.ComprobanteDeVenta.ListasDePrecios, false);
                }
                //Fin German 20120224 -  Tarea 0000247
				
				Item item = new Item(miProducto);
				
				item.PrecioCostoMonedaReferencia = precioDeCosto;
				
				item.BonificacionRecargoFinanciero = bonificacionRecargoFinanciero ;
				
				item.BonificacionRecargoProducto = bonificacionRecargoProducto ;
				
				// matias
				if (row != null) item.PrecioFinalOriginal = (decimal)row["PrecioFinalOriginal"];
				
				if(!relaciones.ActualizaPrecio) //Para ver si deja el precio fijado del comprobante previo
					item.PrecioBruto = precioBruto;
                //Sabrina: Tarea 1075. 20110323
				else //si es comodin o item de un combo no actualiza el producto con precio nuevo; le pongo el precio del comprob anterior
                    //German 20120524 - Tarea 0000340
                    //if ((permiteComodin) & (EsComodin(listaComodines, miProducto.Codigo)) && !idCombo.Equals(string.Empty))
                    if ((permiteComodin) & (EsComodin(listaComodines, miProducto.Codigo)) /*&& !idCombo.Equals(string.Empty)*/)
                        //Fin German 20120524 - Tarea 0000340
						item.PrecioBruto = precioBruto;
                //Fin Sabrina: Tarea 1075. 20110323
                    					
				if(precioBruto != 0 )
					item.BonificacionAplicada = Decimal.Round( bonificacionAplicada * 100 / precioBruto,4);
				else item.BonificacionAplicada = 0;

				item.IdProducto = relacion.IdProducto;
				item.Cantidad = relacion.CantidadDestino;
				item.PrecioNeto = relacion.PrecioNetoActual;

				item.OrdinalOrigen =relacion.OrdinalOrigen;
				item.IdComprobanteOrigen = relacion.IdComprobante;
				item.IdTipoComprobanteOrigen = relacion.IdTipoDeComprobante;
				
				item.OrdinalDestino = this.Count;

				item.IdListaDePrecios = relacion.IdListaDePrecios;
				item.CoeficienteListaDePrecios = relacion.CoeficienteListaDePrecios;
				item.ModoDeAplicacionListaDePrecios = relacion.ModoDeAplicacionListaDePrecios;
				if(!IdListaDePrecioDefault.Equals(string.Empty))
					item.IdListaDePreciosDefault = IdListaDePrecioDefault;
				
				string descripcion = string.Empty;
				descripcion = mz.erp.businessrules.tsa_ComprobanteDetalleDescripcionAdicional.GetDescripcionAdicional( relacion.IdComprobante,relacion.OrdinalOrigen );
				if (descripcion.Equals( string.Empty ))
				{
					item.Descripcion = miProducto.Descripcion;
					item.DescripcionCorta = miProducto.DescripcionCorta;
					item.DescripcionLarga = miProducto.DescripcionLarga;
					item.DescripcionDetallada = miProducto.DescripcionDetallada;
					item.CampoAuxiliar1 = miProducto.CampoAuxiliar1;
					item.CampoAuxiliar2 = miProducto.CampoAuxiliar2;
					item.CampoAuxiliar3 = miProducto.CampoAuxiliar3;
					item.CampoAuxiliar4 = miProducto.CampoAuxiliar4;
					item.CampoAuxiliar5 = miProducto.CampoAuxiliar5;					
				}
				else
				{
					item.Descripcion = descripcion;
					item.DescripcionCorta = descripcion;
					item.DescripcionLarga = descripcion;
					item.DescripcionDetallada = descripcion;
					item.TieneDescripcionDetallada = true;
				}
				/*Nuevo German*/
				if(relacion.IdTipoDeComprobante.Equals("OR"))
				{
					item.IdTipoProducto = relacion.IdTipoProducto;
					if(!item.IdTipoProducto.Equals("S") && !item.IdTipoProducto.Equals("E"))
					{
						string aux = Variables.GetValueString("Comprobantes.OrdenReparacion.Repuestos.Descripcion");
						string prefix = string.Format(aux,new object[]{item.IdComprobanteOrigen}) + " ";
						item.Descripcion =prefix  + relacion.Descripcion;
						item.DescripcionCorta = prefix  + relacion.Descripcion;
						item.DescripcionLarga = prefix  + relacion.Descripcion;
						item.DescripcionDetallada = prefix  +  relacion.Descripcion;
						
					}
					else
					{
						item.Descripcion = relacion.Descripcion;
						item.DescripcionCorta = relacion.Descripcion;
						item.DescripcionLarga = relacion.Descripcion;
						item.DescripcionDetallada = relacion.Descripcion;
					}
						
					item.TieneDescripcionDetallada = true;
					if(miProducto != null)
						item.PrecioCostoMonedaReferencia = miProducto.PrecioDeCostoMonedaReferencia;
					else item.PrecioCostoMonedaReferencia = 0;
					item.PrecioBruto = relacion.Precio;
					item.PrecioNeto = relacion.Precio;
					item.IdInstanciaOR = relacion.IdInstanciaOR;
					

				}
				
				item.AfectaStock = relacion.AfectaStock;
				item.AllowEdit = relacion.AllowEdit;
				item.CierraCircuito = relacion.CierraCircuito;
				item.Entregar = relacion.Entregar;
				item.Visible = relacion.Visible;
				item.IdTipoProducto = relacion.IdTipoProducto;
				item.PercibeIB = relacion.PercibeIB;
				item.SetConversion(this._comprobanteDeVenta.Momento);
				item.ContadorOrigen = relacion.ContadorOrigen;
				item.ContadorDestino = relacion.ContadorDestino;
				item.IdResponsableOrigen=relacion.IdResponsableOrigen;
				item.Equipo=relacion.Equipo;


                 //German 20120307 - Tarea 0000290

                ItemComprobante miItemComprobante = null;
                if (this._comprobanteDeVenta.ProcessName().Equals("ProcesoRemitirVender") || this._comprobanteDeVenta.ProcessName().Equals("ProcesoRemitirPrestar") || this._comprobanteDeVenta.ProcessName().Equals("ProcesoRemitirVenderManual"))
                {
                    if (!this.ContainsCached(relacion.IdProducto))
                    {
                        item.OrigenMultiple = true;
                        miItemComprobante = new ItemComprobante("STEP", this, item);
                        RelacionComprobanteOrigen origen = new RelacionComprobanteOrigen(miItemComprobante.IdComprobanteOrigen, miItemComprobante.OrdinalOrigen, relacion.CantidadOrigen, relacion.CantidadPendiente, miItemComprobante.Cantidad, miItemComprobante.Precio);
                        miItemComprobante.AddOrigen(origen);
                        this.AddInCache(miItemComprobante);
                        //Falta la politica de precios
                    }
                    else
                    {
                        miItemComprobante = (ItemComprobante)this.GetByIdProductoCached(item.IdProducto)[0];
                        RelacionComprobanteOrigen origen = new RelacionComprobanteOrigen(item.IdComprobanteOrigen, item.OrdinalOrigen, relacion.CantidadOrigen, relacion.CantidadPendiente, relacion.CantidadDestino, item.PrecioCosto);
                        miItemComprobante.AddOrigen(origen);
                        miItemComprobante.CantidadUnidadOrigen = miItemComprobante.Cantidad + relacion.CantidadDestino;

                        //Falta la politica de precios
                        if (!relaciones.ActualizaPrecio)
                        {
                            decimal nuevoPrecio = (item.PrecioBruto * item.Cantidad + miItemComprobante.PrecioDeVentaBruto * miItemComprobante.CantidadUnidadOrigen) / (item.Cantidad + miItemComprobante.CantidadUnidadOrigen);
                            miItemComprobante.PrecioDeVentaBruto = nuevoPrecio;
                        }
                    }
                }
                else
                {
                    miItemComprobante = new ItemComprobante("STEP", this, item);
                    this.AddInCache(miItemComprobante);
                }

                //Fin German 20120307 - Tarea 0000290
				//if (miItemComprobante.Visible)


				/*Modificacion 08/09/2007*/

				miItemComprobante.IdInstanciaOrdenReparacion = relacion.IdInstanciaOrdenReparacion;
				miItemComprobante.IdOrdenReparacion = relacion.IdOrdenReparacion;
				miItemComprobante.IdRepuestoOrdenReparacion = relacion.IdRepuestoOrdenReparacion;
				miItemComprobante.IdTareaRealizada = relacion.IdTareaRealizada;
				miItemComprobante.IdComprobantesPredecesores = relacion.IdComprobantesPredecesores + "," + relacion.IdComprobante;
				miItemComprobante.IdComprobantesSucesores = relacion.IdComprobantesSucesores;
				miItemComprobante.IdTiposComprobantesPredecesores = relacion.IdTiposComprobantesPredecesores + "," + relacion.IdTipoDeComprobante;
				miItemComprobante.IdTiposComprobantesSucesores = relacion.IdTiposComprobantesSucesores;
				miItemComprobante.OrdinalesPredecesores = relacion.OrdinalesPredecesores + "," + relacion.OrdinalOrigen;
				miItemComprobante.OrdinalesSucesores = relacion.OrdinalesSucesores;


                //German 20110905 - Tarea 0000208
                //miItemComprobante.PorcentajeDescuentoSinRecalculo(porcentajeDescuento); 
                miItemComprobante.PorcentajeDescuento = porcentajeDescuento;
                //Fin German 20110905 - Tarea 0000208
                
                //Sabrina: Tarea 1075. 20110323
                miItemComprobante.IdCombo = idCombo;
                miItemComprobante.Combo = combo;
                //Fin Sabrina: Tarea 1075. 20110323

                //German 20120307 - Tarea 0000290
                //if (!this.ContainsCached(relacion.IdProducto))
				//this.AddInCache(miItemComprobante);

                //Fin German 20120307 - Tarea 0000290

                //German 20120302 -  Tarea 0000284 - Se saco del for pq agrega el ITem seña por cada item que este en la prefactura por reserva
                
                /* Silvina 20111212 - Tarea 0000232 */
                //if (_comprobanteDeVenta.ProcessName().Equals("ProcesoPrevenderVenderReserva") && _comprobanteDeVenta.GetTaskName().Equals("Vender"))
                //{                    
                //    string idCompFac = tsa_ComprobantesReservasRelacion.GetByPk(relacion.IdComprobante).IdComprobanteFactura;
                //    tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow rowS = tsa_ComprobantesDet.GetByPk(idCompFac, 0);
                //    if (rowS != null)
                //    {
                //        Productos prodSeña = new mz.erp.businessrules.Productos(rowS.IdProducto);
                //        Item it = new Item(prodSeña);
                //        it.SetConversion(_comprobanteDeVenta.Momento);
                //        ItemComprobante itc = new ItemComprobante("NEW", this, it);
                //        itc.PrecioConImpuestos = rowS.PrecioFinal * -1;
                //        itc.CantidadUnidadOrigen = rowS.Cantidad ;
                //        this.AddInCache(itc);
                //    }
                //}
                /* Fin Silvina 20111212 - Tarea 0000232 */
                //Fin German 20120302 -  Tarea 0000284
                
			}
            
		}
        //German 20120302 -  Tarea 0000284
        string IdComprob = string.Empty;
        foreach (RelacionComprobanteOrigenDestino relacion in relaciones)
        {
            IdComprob = relacion.IdComprobante;
            break;//Me quedo con el primero, se hace esta negrada porque la coleccion relaciones no se puede acceder por [0]
        }

        if (_comprobanteDeVenta.ProcessName().Equals("ProcesoPrevenderVenderReserva") && _comprobanteDeVenta.GetTaskName().Equals("Vender"))
        {
            string idCompFac = tsa_ComprobantesReservasRelacion.GetByPk(IdComprob).IdComprobanteFactura;
            tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow rowS = tsa_ComprobantesDet.GetByPk(idCompFac, 0);
            if (rowS != null)
            {

                Productos prodSeña = null;

                if (!this.ComprobanteDeVenta.ListasDePrecios)
                    prodSeña = new mz.erp.businessrules.Productos(rowS.IdProducto);
                else
                {

                    prodSeña = new mz.erp.businessrules.Productos("IdProducto", rowS.IdProducto, tsh_ListasDePrecios.GetDefault().IdListaDePrecio, tsh_ListasDePrecios.GetDefault().IdListaDePrecio, this.ComprobanteDeVenta.ListasDePrecios, false);
                }
                
                
                
                Item it = new Item(prodSeña);
                it.SetConversion(_comprobanteDeVenta.Momento);
                ItemComprobante itc = new ItemComprobante("NEW", this, it);
                itc.PrecioConImpuestos = rowS.PrecioFinal * -1;
                itc.CantidadUnidadOrigen = rowS.Cantidad;
                this.AddInCache(itc);
            }
        }
        //Fin German 20120302 -  Tarea 0000284
		this.FlushCache();

	}

	private decimal _porcentajeRecargoFinanciero = 0;
	public ArrayList _itemsCached = new ArrayList();
	
	#region Seccion Items No Visibles

	private ArrayList _itemsNoVisibles = new ArrayList();
	public ArrayList ItemsNoVisibles
	{
		get{return _itemsNoVisibles;}
	}

	private bool ContainsNoVisible(ItemComprobante item)
	{
		foreach(ItemComprobante itemAux in this._itemsNoVisibles)
		{
			if(item.IdProducto.Equals(itemAux.IdProducto))
			{
				return true;
			}
		}
		return false;
	}

	private ItemComprobante GetItemNoVisible(string IdProducto)
	{
		foreach(ItemComprobante item in this._itemsNoVisibles)
		{
			if(item.IdProducto.Equals(IdProducto))
			{
				return item;
			}
		}
		return null;
	}

	#endregion

	public virtual void ClearCache()
	{
		this._itemsCached.Clear();
	}
	public virtual void AddInCache( ItemComprobante item)
	{
		this._itemsCached.Add( item );
	}
	public virtual void FlushCache()
	{
		foreach( ItemComprobante item in _itemsCached )
		{
			AddItem( item );
		}
		this.IsDirty = true;
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}

	public ItemComprobante Get(string IdProducto)
	{	
		foreach(ItemComprobante item in List)
		{
			if(item.IdProducto.Equals(IdProducto))
				return item;
		}
		return null;
	}
	
	/*Modificado para Filtrar Los No Visibles en otra Coleccion*/
	private void AddItem( ItemComprobante item )
	{
		
		
		if((this.Contains(item)) && false)
		{
			ItemComprobante itemCargado = this.Get(item.IdProducto);
			decimal valorOrigen = itemCargado.CantidadUnidadOrigen + item.CantidadUnidadOrigen;
			itemCargado.CantidadUnidadOrigen = valorOrigen;
		}
		else
			if((this.ContainsNoVisible(item)) && false)
			{
				ItemComprobante itemCargado = this.GetItemNoVisible(item.IdProducto);
				decimal valorOrigen = itemCargado.CantidadUnidadOrigen + item.CantidadUnidadOrigen;
				itemCargado.CantidadUnidadOrigen = valorOrigen;
			}
				else
				{
					if(item.Visible)
					{
						item.Ordinal = this.GetOrdinal();
						List.Add ( item );
						this.RefrescarBonificaciones();
					}
					else
					{
						item.Ordinal = this.GetOrdinal();
						this._itemsNoVisibles.Add(item);
							
					}
				}
			
		this._isDirtyItems = true;
		item.OnRecalcItem+= new ItemComprobante.RecalcularItem( this.EscuchoRecalculo );
		item.OnRefreshItem+= new ItemComprobante.RefrescarItem( this.EscuchoRefresco );
	}

	private long GetOrdinal()
	{
		long OrdinalVisibles = 0;
		long OrdinalNoVisibles = 0;
		if (this.Count > 0)
		{
			OrdinalVisibles = ((ItemComprobante)( List[ List.Count-1]  )).Ordinal+1;
		}
		if (this._itemsNoVisibles.Count > 0)
		{
			OrdinalNoVisibles = ((ItemComprobante)( _itemsNoVisibles[ _itemsNoVisibles.Count-1]  )).Ordinal+1;
		}
		return OrdinalVisibles>OrdinalNoVisibles?OrdinalVisibles:OrdinalNoVisibles;

	}

	public virtual void Add( ItemComprobante item )
	{
		AddItem( item );
		this.IsDirty = true;
		this.RefrescarBonificaciones();
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}

	private bool Contains( ItemComprobante item )
	{
		foreach (ItemComprobante it in this.List)
		{
			if (it.IdProducto == item.IdProducto)
				return true;
		}
		return false;
	}
	
	/// <summary>
	/// Agrega una nueva instancia del item a la coleccion de items.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="item"></param>
	public virtual void Add( ComprobanteDeVenta sender, ItemComprobante item )
	{
		this._comprobanteDeVenta = sender;
		this.AddItem( item );
		
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}
	/// <summary>
	/// Elimina un item de la coleccion
	/// </summary>
	/// <param name="item"></param>
	public virtual void Remove( object item )
	{
		List.Remove( item );
		this._isDirtyItems = true;
		this.IsDirty = true;
		this.RefrescarBonificaciones();
		if (OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}



	/// <summary>
	/// Sobrecargado. Elimina un item de la coleccion
	/// </summary>
	/// <param name="item"></param>
	public virtual void Remove( ItemComprobante item )
	{
		Remove( (object)item );
		this._isDirtyItems = true;
		this.IsDirty = true;
		this.RefrescarBonificaciones();
		if (OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}
	/// <summary>
	/// Fuerza un refresco de los impuestos de cada una de las items de la coleccion
	/// </summary>
	public void RefrescarImpuestos()
	{
		foreach( ItemComprobante item in List )
		{
			item.RefrescarImpuestos();
			
		}
		if(List.Count > 0)
		{
			if (OnRecalcItems != null)
			{
				OnRecalcItems( this, new System.EventArgs() );
			}
		}
	}
	/// <summary>
	/// Fuerza el refrezco de las bonificaciones aplicadas en cada uno de los items de la coleccion
	/// </summary>
	public void RefrescarBonificaciones()
	{
		foreach (ItemComprobante item in List)
		{
			item.AplicarBonificaciones();
		}
		if(List.Count > 0)
		{
			if (OnRecalcItems != null)
			{
				OnRecalcItems( this, new System.EventArgs() );
			}
		}
	}
	private void EscuchoRecalculo( object sender, System.EventArgs e )
	{
		if ( OnRecalcItems != null )
		{
			this.OnRecalcItems( this, new System.EventArgs() );
		}
	}
	private void EscuchoRefresco( object sender, System.EventArgs e )
	{
		if ( OnRefreshItems != null )
		{
			this.OnRefreshItems( this, new System.EventArgs() );
		}
	}

	/// <summary>
	/// Fuerza la escritura en el dataset de comprobante de venta de cada uno de los items de la coleccion
	/// </summary>
	public void Commit()
	{
		foreach (ItemComprobante item in List)
		{
			item.Commit();
		}
		foreach(ItemComprobante item in _itemsNoVisibles)
		{
			item.Commit();
		}
	}


	private string _itemsConMonto0 = string.Empty;
	public bool ExistenItemsConMonto0
	{
		get
		{
			bool ok = false;
			_itemsConMonto0 = string.Empty;
			foreach (ItemComprobante item in List)
			{
				if (item.PrecioConImpuestos==0)
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

	public System.Data.DataTable ResumenDeImpuestos
	{
		get
		{
			System.Collections.Hashtable resumen = new Hashtable();
			foreach (ItemComprobante item in List)
			{
				foreach (Impuesto imp in item.ImpuestosDirectos)
				{
					if (!resumen.ContainsKey( imp.Key ))
					{ 
						ArrayList aux = new ArrayList();
						aux.Add(imp.SubTotalImpuesto);
						aux.Add(imp.DescripcionCorta);
                        //Matias 20110825 - Tarea 0000131
                        aux.Add(imp.Alicuota);
                        //FinMatias 20110825 - Tarea 0000131
						resumen.Add( imp.Key, aux );
					}
					else
					{
						ArrayList aux = (ArrayList) resumen[imp.Key];
						aux[0] = Convert.ToDecimal(aux[0]) + imp.SubTotalImpuesto;
						
					}
				}
				foreach (Impuesto imp in item.ImpuestosIndirectos)
				{
					if (!resumen.ContainsKey( imp.Key ))
					{
						ArrayList aux = new ArrayList();
						aux.Add(imp.SubTotalImpuesto);
						aux.Add(imp.DescripcionCorta);
                        //Matias 20110825 - Tarea 0000131
                        aux.Add(imp.Alicuota);
                        //FinMatias 20110825 - Tarea 0000131
						resumen.Add( imp.Key, aux );
					}
					else
					{
						ArrayList aux = (ArrayList) resumen[imp.Key];
						aux[0] = Convert.ToDecimal(aux[0]) + imp.SubTotalImpuesto;
					}
				}
			}
			System.Data.DataTable data = new System.Data.DataTable();
			data.Columns.Add("DescripcionCorta");
			data.Columns.Add("Valor");			
			data.Columns.Add("Key");
            //Matias 20110825 - Tarea 0000131
            data.Columns.Add("Alicuota");
            //FinMatias 20110825 - Tarea 0000131
			foreach (object key in resumen.Keys)
			{
				ArrayList aux = (ArrayList)resumen[key];
                data.Rows.Add(new object[] { Convert.ToString(aux[1]), Convert.ToDecimal(aux[0]), Convert.ToString(key) /*//Matias 20110825 - Tarea 0000131*/, Convert.ToDecimal(aux[2])/*//Matias 20110825 - Tarea 0000131*/ });
			}
			return data;

		}
	}
	public decimal TotalImpuestos
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= (item.ImpuestosDirectos.Total + item.ImpuestosIndirectos.Total) * item.Cantidad;
			}
			return decimal.Round( subtotal,2);
		}
	}
    //Matias 20110823 - Tarea 0000131
    public decimal GetTotalImpuesto(ArrayList NombresImpuestos)
    {
        decimal subtotal = 0;
        foreach (ItemComprobante item in List)
        {
            subtotal += item.GetTotalImpuesto(NombresImpuestos);
        }
        return decimal.Round(subtotal, 2);        
    }
    public decimal GetAlicuotaImpuesto(string tipoImpuesto)
    {
        decimal alicuota = 0;
        foreach (ItemComprobante item in List)
        {
            alicuota = item.GetAlicuota(tipoImpuesto);
            if (alicuota > 0)
                return alicuota;
        }
        return 0;
    }
    public decimal GetBaseImponible(string impuestos)
    {
        decimal baseImponible = 0;
        foreach (ItemComprobante item in List)
        {
            baseImponible += item.GetBaseImponible(impuestos);
        }
        return baseImponible; 
    }
    //FinMatias 20110823 - Tarea 0000131
	public decimal TotalImpuestosSinRecargos
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				
				decimal d=0;
				/*
				foreach (string _keyImpuesto in item.ColeccionImpuestos.Keys)
				{
					if (_keyImpuesto.CompareTo("IVA")==0)
					{
						d= item.PrecioDeVentaBruto * Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva")/100;
					}
					else
					{
						if (_keyImpuesto.CompareTo("IVADIF")==0)
						{
							decimal alicuota = Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva");
							alicuota = alicuota /2;
							d= item.PrecioDeVentaBruto * alicuota  / 100;
						}
					}
				}
				*/
				//d = FuncionesImpuestos.Calcular(item.ColeccionImpuestos, item.PrecioDeVentaBruto);
				d = item.Impuestos.TotalBruto;
				subtotal+= d * item.Cantidad;
				
				
			}
			return subtotal;
			//return decimal.Round( subtotal,2);
			
		}
	}
	public decimal TotalConImpuestosSinRecargos
	{
		get
		{
			decimal subtotal = this.TotalBruto+this.TotalImpuestosSinRecargos;
			return subtotal;
		}
	}
	public decimal TotalBruto
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= (item.PrecioDeVentaBruto * item.Cantidad);
			}
			return subtotal;
			//return decimal.Round(subtotal,2);
		}
	}
	public decimal TotalDescuentos
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= (item.BonificacionMonetaria * item.Cantidad);
			}
			return decimal.Round(subtotal,2);
		}
	}

	public decimal TotalRecargosFinancieros
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= (item.SubTotalRecargosFinancieros );
			}
			return decimal.Round(subtotal,2);
		}
	}

	public decimal TotalBonificacionesRecargosCuenta
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= item.ImporteUnitarioSinImpBonificacionRecargoCuenta * item.Cantidad;
			}
			return subtotal;
		}
	}
	public decimal TotalBonificacionesRecargosProducto
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= item.ImporteUnitarioSinImpBonificacionRecargoProducto * item.Cantidad;
			}
			return subtotal;
		}
	}
	public decimal TotalBonificacionesRecargosFinancieros
	{
		get
		{
			decimal subtotal = 0;
			foreach (ItemComprobante item in List)
			{
				subtotal+= item.ImporteUnitarioSinImpBonificacionRecargoFinanciero * item.Cantidad;
			}
			return subtotal;
		}
	}

	public bool EsComodin(string lista, string idProducto)
	{
		ArrayList aux = mz.erp.systemframework.Util.Parse(lista, ",");
		if(aux.Count > 0)
			foreach(string str in aux)
				if (str.Equals(idProducto)) return true;
		return false;
	}

	private bool _isDirtyItems = true;
	public bool IsDirtyItems
	{
		set 
		{
		_isDirtyItems = true;
		}
		get
		{
			return _isDirtyItems;
		}
	}

	public bool IsDirty
	{
		set
		{
			foreach (ItemComprobante item in List)
			{
				item.IsDirty = true;
			}
		}
		get
		{
			if (List.Count > 0)
			{
				return ((ItemComprobante)List[0]).IsDirty;
			}
			return false;
		}
	}

	public decimal PorcentajeRecargosFinancieros
	{
		get
		{
			if (List.Count > 0)
			{
				return _porcentajeRecargoFinanciero;//((ItemComprobante)List[0]).BonificacionRecargoFinanciero;
			}
			else return 0;
		}
	}


	/*
	
	public delegate void ChangeItemsCollection( EventArgs e);
	public event ChangeItemsCollection ItemsDelComprobanteHanCambiado;

	public virtual void Add(ItemComprobante item, decimal discount)
	{
	}
	public virtual void Add(ItemComprobante item)
	{
		if ( ItemsDelComprobanteHanCambiado != null)
		{
			_CompararConSusPares( item );
			EventArgs e = new EventArgs();
			ItemsDelComprobanteHanCambiado( e );
		}
	}

	private decimal _FindOrAdd( ItemComprobante item )
	{
		decimal cantidad = 0;
		foreach (ItemComprobante ic in List)
		{
			if (ic.IdProducto == item.IdProducto)
			{
				ic.Cantidad = ic.Cantidad + item.Cantidad;
				return ic.Cantidad;
			}
		}
		List.Add(item);
		return item.Cantidad;
	}

	private void _FindAndDecrement( string IdProducto , decimal cant_Prod)
	{
		ItemComprobante ic =_findItem(IdProducto);		
		ic.Cantidad= ic.Cantidad - cant_Prod;
	}



private ItemComprobante _findItem ( string idProducto)
{
	foreach (ItemComprobante ic in List)
		{
			if (ic.IdProducto == idProducto)
				return ic;
		}
	return null;
}
	/// <summary>
	/// La cantidad del articulo que voy a comparar contra el grupo puede ser menor, igual o mayor. Si es menor
	/// no existe la posiblidad de que forme un agrupamiento, si es mayor puede darse el caso de que pueda conformar
	/// uno o varios grupos, por ejemplo si el grupo lo compone con 12 items, al ingresar 30, compongo 2 grupos y 4 de saldo
	/// Esta funcion devuelve la cantidad de multiplos de grupos que pueden formarse con la cantidad comparada
	/// </summary>
	/// <param name="grupo"></param>
	/// <param name="IdProducto"></param>
	/// <param name="cantidad"></param>
private void _AgruparProducto( tsh_GruposProductosDataset grupo, ItemComprobante nuevoitem, string IdPadre )
{
	
/*	
	/*System.Collections.ArrayList datosGrupo = new System.Collections.ArrayList();
	decimal cant_Prod = 0;
	foreach (System.Data.DataRow row in grupo.tsh_GruposProductos)
	{
		//Recupera la cantidad que se requiere para ese IdProducto en el grupo
		if ( (string)row["IdProducto"] == nuevoitem.IdProducto )
		{
			cant_Prod = (decimal) row["Cantidad"];

		}
//		mz.erp.businessrules.comprobantes.VistaProducto vp= new mz.erp.businessrules.comprobantes.VistaProducto();
		vp.IdProducto = (string)row["IdProducto"];
		vp.Cantidad=(decimal)row["Cantidad"];
		datosGrupo.Add(vp);
	}*/
	/*
		//Actuliza la cantidad de IdProducto en la coleccion List
		decimal cant_Actual =_FindOrAdd(nuevoitem);

		//Compara con la cantidad del Producto que se esta por facturar y que viene por parametro  
		if (cant_Prod <= cant_Actual)
		{

			//Compara que haya al menos la cantidad de productos que se requieren para el grupo

		
			if ( datosGrupo.Count - 1 > List.Count - 1  ) //datosGrupo.Keys.Count-1 > List.Count-1)
			{
				System.Collections.IEnumerator i = datosGrupo.GetEnumerator();
			
			
				bool ok= true;
			
			
				while ( i.MoveNext() && ok)
				{
					VistaProducto vp=(VistaProducto)i.Current;
					decimal cant= vp.Cantidad;
					ItemComprobante item = _findItem(vp.IdProducto);
					if (item.Cantidad < cant)
					{
						ok = false;
					}
				}
				//Si esta en true esta todo bien
				if (ok) 
				{

					foreach( VistaProducto vp in datosGrupo)
				
					{
						_FindAndDecrement(vp.IdProducto,vp.Cantidad);
					}
				}
				ItemComprobante itemGrupo = new ItemComprobante( IdPadre );
				Add( itemGrupo );
			}		
		}

		}
		private void _CompararConSusPares( ItemComprobante nuevoItem )
		{
			bool debeAgruparItems = mz.erp.businessrules.Variables.GetValueBool("Comprobantes.AgruparItems");
			if (debeAgruparItems)
			{
				System.Collections.ArrayList padres = mz.erp.businessrules.tsh_GruposProductos.BuscarPadresNoDuplicados( nuevoItem.IdProducto );
				tsh_GruposProductosDataset grupo;

				//Si viene con algo significa que al menos en algun grupo de articulos esta incluido
				if (padres.Count > 0)
				{
					for (int i=0;i<=padres.Count-1;i++)
					{
						grupo = mz.erp.businessrules.tsh_GruposProductos.GetList( null, (string)padres[i] );
						_AgruparProducto( grupo, nuevoItem, (string)padres[i] );
					}
				}
				else
				{
					List.Add( nuevoItem );
				}
			}
		
		}
	*/

}
