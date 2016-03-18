using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesController.
	/// </summary>
	public class ComprobantesDeVentaController: ISearchObjectListener, ITaskController, IObserver, IObservable
	{
		#region Constructores
		public ComprobantesDeVentaController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_comprobanteDeVenta = new mz.erp.businessrules.comprobantes.ComprobanteDeVenta();
			Init();
		}
		public ComprobantesDeVentaController( ComprobanteDeVenta _comprobante )
		{
			_comprobanteDeVenta = _comprobante;
			Init();
		}
		private void Init()
		{
			InitializeData();
			InitEventHandlers();
		}
		public void ChequearCliente()  
		{
			ProcessObjectsObserver();
		}
		#endregion

		#region Variables Privadas
		private ComprobanteDeVenta _comprobanteDeVenta;
		private string _leyendaFormulario = string.Empty;
		//private string _responsableDeEmision = string.Empty;
		//private string _responsableDeEmisionAnt = string.Empty;
		private string _tipoDeComprobante = string.Empty;
		
		private System.DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _numeroComprobante = "";
		private string _observaciones = "";
		
		private System.Collections.Hashtable _listatiposDeComprobantes = businessrules.tsy_TiposDeComprobantes.GetListHashTable();
		private string _layoutItems = string.Empty;
		private string _layoutImpuestos = string.Empty;
		private string _layoutVariables = string.Empty;
		private string _layoutCondicionesDeVenta = string.Empty;
		private bool _editable = true;

		#endregion

		#region Variables Publicas Interfaz

		public DataTable TableCondicionesDeVenta
		{
			get{return _comprobanteDeVenta.TableCondicionesDeVenta;}
		}

		public string Caption 
		{
			get	{return "Emision de " + this.NombreDeComprobante;}
		}

		public string LayoutVariables
		{
			get{return _layoutVariables;}
		}

		public string LayoutCondicionesDeVenta
		{
			get{return _layoutCondicionesDeVenta;}
		}

		public string LayoutImpuestos
		{
			get{return _layoutImpuestos;}
		}

		public string LayoutItems
		{
			get { return _layoutItems;}
		}

		public bool EnabledButtonAgregarProductos
		{
			get 
			{
				return  Variables.GetValueBool(this._comprobanteDeVenta.GetProcessManagerParent().Process.ProcessName, this._comprobanteDeVenta.GetTaskName(), "Emision.Editar.HabilitaBotonAgregar")
				&& this.AllowAddItems;
			}				
		}

		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  Variables.GetValueBool(this._comprobanteDeVenta.GetProcessManagerParent().Process.ProcessName, this._comprobanteDeVenta.GetTaskName(), "Cuenta.HabilitaBotonCtaCte", true);
			}				
		}

		public bool AllowEditItems
		{
			get{return this._comprobanteDeVenta.AllowEditItems;	}			
		}
		public bool AllowDeleteItems
		{
			get{return this._comprobanteDeVenta.AllowDeleteItems;	}			
		}
		public bool AllowAddItems
		{
			get{return this._comprobanteDeVenta.AllowAddItems;	}			
		}

		public bool AllowEditTipoDeComprobante
		{
			get	{return this._comprobanteDeVenta.AllowEditTipoDeComprobante;}
		}
		public bool AllowEditResponsableEmision
		{
			get	{return this._comprobanteDeVenta.AllowEditResponsableEmision;}
		}		
		public bool AskForPasswordResponsableEmision
		{
			get { return this._comprobanteDeVenta.AskForPasswordResponsableEmision; }			
		}
		public bool AllowEditCuenta
		{
			get	{return this._comprobanteDeVenta.AllowEditCuenta;}
		}
		public bool AllowEditVariablesAuxiliares
		{
			get	{return this._comprobanteDeVenta.AllowEditVariablesAuxiliares;}
		}

		public bool AllowEditFormasDePago
		{
			get{return this._comprobanteDeVenta.AllowEditFormasDePago;}
		}

		public bool AllowEditCondicionDeVenta
		{
			get{return this._comprobanteDeVenta.AllowEditCondicionDeVenta;}
		}

		public bool AllowEditFecha
		{
			get{return this._comprobanteDeVenta.AllowEditFecha;}
		}

		public bool AllowEditNumeration
		{
			get	{return this._comprobanteDeVenta.AllowEditNumeration;}
		}

		public bool TemporalNumeration
		{
			get{return this._comprobanteDeVenta.TemporalNumeration;}
		}

		public string LeyendaFormulario
		{
			get {return this._leyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _comprobanteDeVenta.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get {return this._comprobanteDeVenta.TextoBotonSiguiente;}
		}

		public string TextoBotonAnterior
		{
			get {return this._comprobanteDeVenta.TextoBotonAnterior;}
		}

        /* Silvina 20100531 - Tarea 646 */
        public bool SeleccionaUltimo
        {
            get { return _comprobanteDeVenta.SeleccionaUltimo; }
        }
        /* Fin Silvina */

        /* Silvina 20110316 - Tarea 0000039 */
        public bool VisualizaSaldo
        {
            get { return _comprobanteDeVenta.VisualizaSaldo; }
        }
        /* Fin Silvina */

        /* Silvina 20111212 - Tarea 0000232 */
        public bool VisualizaFechaReserva
        {
            get { return _comprobanteDeVenta.VisualizaFechaReserva; }
        }

        public DateTime FechaReserva
        {
            set
            {
                if (value != this._comprobanteDeVenta.FechaReserva)
                {
                    _comprobanteDeVenta.FechaReserva = value;
                    if (FechaReservaChanged != null)
                        FechaReservaChanged(this, new EventArgs());
                }
            }
            get { return _comprobanteDeVenta.FechaReserva; }
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */

		#endregion

		#region Metodos Publicos

		public bool AllowEditInOtherWindow(string column)
		{
			return column.Equals("Descripcion") || column.Equals("DescripcionLarga") 
				|| column.Equals("DescripcionCorta") || column.Equals("DescripcionDetallada");
				//|| column.Equals("PrecioDeVentaBruto") || column.Equals("PrecioConImpuestos");
		}

		public Type GetTypeOfColumn(object sender, string column)
		{
			return sender.GetType().GetProperty(column).PropertyType;
		}

		public string GetDescription(string column)
		{
			switch (column)
			{
				case "PrecioDeVentaBruto": return "Precio de Lista Sin Impuestos";
				case "PrecioConImpuestos": return "Precio Final Con Impuestos";
				case "PrecioConImpuestosDirectos": return "Precio Final Con Impuestos Directos";
				default : return "Descripción";
			}
			return string.Empty;
		}

		public bool AllowEnterKey(string column)
		{ 
			return column.Equals("Descricpion") || column.Equals("DescricpionLarga") 
					|| column.Equals("DescricpionCorta") || column.Equals("DescricpionDetallada");
		}
		
		public bool IsEditable( object selectedItem, string Propiedad)
		{
			if(Propiedad.Equals("IdListaDePrecios") && !_listaDePreciosHabilitadas)
				return false;
			ItemComprobante item = (ItemComprobante) selectedItem;


			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._comprobanteDeVenta.GetTaskName();
			string colaVariable = string.Empty;

			bool habilitaComodines = Variables.GetValueBool(nombreProceso, nombreTarea, "Emision.Editar.Items.HabilitaItemComodin");
			string comodines = Variables.GetValueString(nombreProceso, nombreTarea, "Emision.Editar.Items.ListaItemComodin");
			ArrayList aux = systemframework.Util.Parse(comodines,",");
			
			
			if(Propiedad.Equals("CantidadUnidadOrigen"))
				if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
					if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen != string.Empty && !item.IdTipoComprobanteOrigen.Equals("OR"))
					{
						if(habilitaComodines && aux.Contains(item.Codigo))
							colaVariable = "Emision.Editar.Step.ItemComodin." + Propiedad;
						else
							colaVariable = "Emision.Editar.Step." + Propiedad;
						bool result1 = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
						return item.AllowEdit && result1;
					}

            //Sabrina: Tarea 1072. 20110323
            if (Propiedad.Equals("PorcentajeDescuento"))
            {
                if (item.IdCombo != null && !item.IdCombo.Equals(string.Empty)) //Es parte de combo
                    Propiedad = "PorcentajeDescuentoCombo";
            }
            //Fin Sabrina: Tarea 1072. 20110323			

			if(habilitaComodines && aux.Contains(item.Codigo))
				colaVariable = "Emision.Editar.ItemComodin." + Propiedad;
			else
				colaVariable = "Emision.Editar." + Propiedad;
			bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
			return item.AllowEdit && result; //&& (!habiltaComodines || (habiltaComodines && aux.Contains(item.Codigo)));
			
			
		}

		public bool IsRemovable( object selectedItem)
		{
			ItemComprobante item = (ItemComprobante) selectedItem;

			if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
				if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen != string.Empty && !item.IdTipoComprobanteOrigen.Equals("OR"))
				{
					string nombreProceso = this._processManager.GetProcessName();
					string nombreTarea = this._comprobanteDeVenta.GetTaskName();
					string colaVariable = string.Empty;

					bool habilitaComodines = Variables.GetValueBool(nombreProceso, nombreTarea, "Emision.Editar.Items.HabilitaItemComodin");
					string comodines = Variables.GetValueString(nombreProceso, nombreTarea, "Emision.Editar.Items.ListaItemComodin");
					ArrayList aux = systemframework.Util.Parse(comodines,",");
			
			
					if(habilitaComodines && aux.Contains(item.Codigo))
						colaVariable = "Emision.Step.Delete.ItemComodin";
					else
						colaVariable = "Emision.Step.Delete.Items";
					bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
					return result;
				}

			return item.AllowEdit;
		}

		#endregion
		
		#region Variables Publicas Datos

		public bool ProductosControlFocused
		{
			get{return _comprobanteDeVenta.ProductosControlFocused;}
		}

		public bool MustRecalcular
		{
			set{_comprobanteDeVenta.MustRecalcular = value;}
		}

		public bool Editable 
		{
			get	{	return _editable;}
		}
		public DataTable ResumenDeImpuestos
		{
			get	
			{					
				DataTable table = this._comprobanteDeVenta.ResumenDeImpuestos;
				foreach(DataRow row in table.Rows)
				{
					row["Valor"] = Math.Round(Convert.ToDecimal(row["Valor"]),2);
				}
				return table;
			}
		}

		public ICollection DetalleCondicionDeVenta
		{
			get	{	return this._comprobanteDeVenta.CondicionDeVenta.DetalleCondicionDeVenta;	}
		}

		public ICollection VariablesDeUsuario
		{
			get	{	return this._comprobanteDeVenta.VariablesDeUsuario;	}
		}


		public string Mascara
		{
			get { return _comprobanteDeVenta.Mascara;}
		}
		
		public string ResponsableDeEmision
		{
			set	
			{ 
				if(value != _comprobanteDeVenta.IdResponsable && value != null &&!value.Equals(string.Empty))
				{
					if ( _comprobanteDeVenta.AllowEditResponsableEmision)
					{						
						_comprobanteDeVenta.IdResponsable  = value ; 
						if(ResponsableDeEmisionChanged != null)
							ResponsableDeEmisionChanged(this , new EventArgs());
					}
				}
			}
			get { return _comprobanteDeVenta.IdResponsable; }
		}
		private string _ultimoResponsableClaveCorrecta = "";
		public string UltimoResponsableClaveCorrecta
		{
			get 
			{
				return _ultimoResponsableClaveCorrecta;
			}
			set 
			{
				_ultimoResponsableClaveCorrecta = value;
			}		
		}		
		public string TipoDeComprobante
		{
			set 
			{
				if ( _comprobanteDeVenta.AllowEditTipoDeComprobante )
				{
					_tipoDeComprobante = value ;
				} 
			}
			get { return _comprobanteDeVenta.TipoComprobanteDestino ; }
		}

		public bool RenombraClienteDePaso
		{
			get{return _comprobanteDeVenta.RenombraClienteDePaso;}
		}
		
		public string Cuenta
		{
			set 
			{ 
				if ( _comprobanteDeVenta.AllowEditCuenta )
				{
					_comprobanteDeVenta.CodigoCuenta = value ; 
				}
			}
			get { return _comprobanteDeVenta.CodigoCuenta;} 
		}

		public string IdListaDePreciosDefault
		{
			set {_comprobanteDeVenta.IdListaDePreciosDefault = value;}
			get { return _comprobanteDeVenta.IdListaDePreciosDefault;} 
		}
		
		public string NombreClientePaso
		{
			set 
			{
				_comprobanteDeVenta.InfoCliente = value;
			}
			get 
			{
				return _comprobanteDeVenta.InfoCliente;
			}
		}
		
		public string CondicionDeVenta
		{
			set 
			{ 
				if(_comprobanteDeVenta.CondicionDeVenta != null && value != null)
					if(_comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta != value)
						if (_comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta != null)
						{
							_comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta = value ; 
							if(CondicionDeVentaChanged != null)
							{
								CondicionDeVentaChanged(this, new EventArgs());
							}
						}
			}
			get 
			{
				if(_comprobanteDeVenta.CondicionDeVenta != null)
				{
					if (_comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta != null)
					{
						return _comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta;
					}
					else return string.Empty;
				}
				else
					return string.Empty;
			}
		}
		
		public DateTime Fecha
		{
			set 
			{
				
				if(value != this._comprobanteDeVenta.FechaComprobante)
				{
					if ( _comprobanteDeVenta.AllowEditFecha )
					{
						_fecha = value ;
						_comprobanteDeVenta.FechaComprobante = value;
						if(FechaChanged != null)
							FechaChanged(this, new EventArgs());
					}
				}
			}
			get { return _comprobanteDeVenta.FechaComprobante ; }
		}
		
		public string NumeroComprobante
		{
			set 
			{ 
				if(value != this._comprobanteDeVenta.Numero)
				{
					if ( _comprobanteDeVenta.AllowEditNumeration )
					{
						_numeroComprobante = value ; 
						this._comprobanteDeVenta.Numero = value;
						if(NumeroComprobanteChanged != null)
						{
							NumeroComprobanteChanged(this, new EventArgs());
						}
					}
				}
			}
			get { return _comprobanteDeVenta.Numero; }
		}

		public string Observaciones
		{
			set 
			{ 
				if(value != this._comprobanteDeVenta.Observaciones)
				{
					_observaciones = value ; 
					this._comprobanteDeVenta.Observaciones = value;
					if(ObservacionesChanged != null)
					{
						ObservacionesChanged(this, new EventArgs());
					}					
				}
			}
			get { return _comprobanteDeVenta.Observaciones; }
		}
		
		public ICollection DataItems
		{
			get { return (ICollection)_comprobanteDeVenta.Items ; }
		}

		public decimal TotalNeto
		{
			get { return this._comprobanteDeVenta.TotalNeto ; }
		}
		
		public decimal TotalConImpuestos
		{
			get { return this._comprobanteDeVenta.TotalConImpuestos ; }
		}
		public decimal TotalImpuestos
		{
			get { return this._comprobanteDeVenta.TotalImpuestos; }
		}
		public decimal TotalBruto
		{
			get { return this._comprobanteDeVenta.TotalBruto ; }
		}
		
		public decimal TotalDescuentos
		{
			get { return this._comprobanteDeVenta.TotalDescuentos * (-1) ; }
		}

		public decimal Total
		{
			get { return this._comprobanteDeVenta.Total ; }
		}

		public decimal TotalRecargosFinancieros
		{
			get { return this._comprobanteDeVenta.TotalRecargosFinancieros ; }
		}

		public decimal ImporteCancelado 
		{
			get { return this._comprobanteDeVenta.ImporteCancelado ; }
		}

		public string NombreDeComprobante
		{
			get 
			{ 
				return _listatiposDeComprobantes[ _comprobanteDeVenta.TipoComprobanteDestino].ToString() ;
			}
		}

		private bool _listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios"); 
		public bool ListaDePreciosHabilitadas
		{
			get{return _listaDePreciosHabilitadas;}
		}

		private tsh_ListasDePreciosDataset.tsh_ListasDePreciosDataTable _listaDePrecios = null;
		public tsh_ListasDePreciosDataset.tsh_ListasDePreciosDataTable ListaDePrecios
		{
			get {return _listaDePrecios;}
		}

		public string KeyValueListaDePrecios
		{
			get { return "IdListaDePrecio" ; }
		}				
		public string KeyListListaDePrecios
		{
			get { return "Descripcion" ; }
		}

		private string _idListaDePreciosDefault = string.Empty;
		/*public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
		}*/

		#endregion

		#region Eventos y Delegados
		public event System.EventHandler NombreDeComprobanteChanged;
		public event System.EventHandler ResponsableDeEmisionChanged;
		public event System.EventHandler TipoDeComprobanteChanged;
		public event System.EventHandler CuentaChanged;
		public event System.EventHandler CondicionDeVentaChanged;
		public event System.EventHandler FechaChanged;
		public event System.EventHandler NumeroComprobanteChanged;
		public event System.EventHandler DataItemsChanged;
		public event System.EventHandler VariablesDeUsuariosChanged;
		public event System.EventHandler ResumenDeImpuestosChanged;
		public event System.EventHandler DetalleCondicionDeVentaChanged;

		public event System.EventHandler TotalNetoChanged;
		public event System.EventHandler TotalConImpuestosChanged;
		public event System.EventHandler TotalImpuestosChanged;
		public event System.EventHandler TotalBrutoChanged;
		public event System.EventHandler TotalDescuentosChanged;
		public event System.EventHandler TotalChanged;
		public event System.EventHandler TotalRecargosFinancierosChanged;
		public event System.EventHandler ImporteCanceladoChanged;
		public event System.EventHandler MascaraChanged;
		public event System.EventHandler ObservacionesChanged;

		public event System.EventHandler AddItemsChanged;

		public event EventHandler TableCondicionesDeVentaChanged;

		public event EventHandler OnTaskAfterExecute;

		public event EventHandler ComprobanteHasChanged;

        /* Silvina 20111212 - Tarea 0000232 */
        public event System.EventHandler FechaReservaChanged;
        /* Fin Silvina 20111212 - Tarea 0000232 */

		private void CallRefresh()
		{
			
			if (CondicionDeVentaChanged != null)
			{
				CondicionDeVentaChanged( this, new System.EventArgs() );
			}
			/*
			if (MascaraChanged != null)
			{
				MascaraChanged( this, new System.EventArgs());
			}
			*/
			if (MascaraChanged != null)
			{
				MascaraChanged( this, new System.EventArgs());
			}
			if (NumeroComprobanteChanged != null)
			{
				NumeroComprobanteChanged( this, new System.EventArgs() );
			}
			if (TipoDeComprobanteChanged != null )
			{
				TipoDeComprobanteChanged( this, new System.EventArgs() );
			}
			/*
			if (ResponsableDeEmisionChanged != null)
			{
				ResponsableDeEmisionChanged( this, new System.EventArgs() );
			}
			ººººººº*/
			if (CuentaChanged != null )
			{
				CuentaChanged( this, new System.EventArgs() );
			}
			
			if (FechaChanged != null)
			{
				FechaChanged( this, new System.EventArgs() );
			}
			
			if (DataItemsChanged != null)
			{
				DataItemsChanged( this, new System.EventArgs() );
			}
			if (TotalNetoChanged != null)
			{
				TotalNetoChanged( this, new System.EventArgs() );
			}
			if (TotalConImpuestosChanged != null)
			{
				TotalConImpuestosChanged( this, new System.EventArgs() );
			}
			if (TotalImpuestosChanged != null)
			{
				TotalImpuestosChanged( this, new System.EventArgs() );
			}
			if (TotalBrutoChanged != null)
			{
				TotalBrutoChanged( this, new System.EventArgs() );
			}
			if (TotalDescuentosChanged != null)
			{
				TotalDescuentosChanged( this, new System.EventArgs() );
			}
			if (TotalChanged != null)
			{
				TotalChanged( this, new System.EventArgs() );
			}
			if (TotalRecargosFinancierosChanged != null )
			{
				TotalRecargosFinancierosChanged( this, new System.EventArgs() );
			}
			if (ImporteCanceladoChanged != null)
			{
				ImporteCanceladoChanged( this, new System.EventArgs() );
			}
			if (NombreDeComprobanteChanged != null)
			{
				NombreDeComprobanteChanged( this, new System.EventArgs() );
			}
			
			if (DataItemsChanged != null)
			{
				DataItemsChanged( this, new System.EventArgs());
			}
			if(ComprobanteHasChanged != null)

				ComprobanteHasChanged(this, new EventArgs());

            /* Silvina 20111212 - Tarea 0000232 */
            if (FechaReservaChanged != null)
            {
                FechaReservaChanged(this, new System.EventArgs());
            }
            /* Fin Silvina 20111212 - Tarea 0000232 */
		
		}
		private void InitEventHandlers()
		{
			_comprobanteDeVenta.ObjectHasChanged+= new EventHandler( this.ListenerObjectHasChanged );
			_comprobanteDeVenta.OnTaskAfterExecute+= new EventHandler( this.ListenerAfterExecute );
			_comprobanteDeVenta.TableCondicionesDeVentaChanged +=new EventHandler(_comprobanteDeVenta_TableCondicionesDeVentaChanged);
			_comprobanteDeVenta.CondicionesDeVentaChanged +=new EventHandler(_comprobanteDeVenta_CondicionesDeVentaChanged);
			//_comprobanteDeVenta.IdResponsableChanged+=new EventHandler(_comprobanteDeVenta_IdResponsableChanged);
			//_comprobanteDeVenta.NumeroComprobanteChanged +=new EventHandler(_comprobanteDeVenta_NumeroComprobanteChanged);
			
		}
		private void RefreshData()
		{
			
		}
		
		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			CallRefresh();
		}
		
		public void processEventChange(object sender, EventArgs e)
		{
			if ((sender.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItemComprobante( (ArrayList)sender);
			}
		}
		
		private void ProcessItemComprobante( ArrayList lista )
		{
			_comprobanteDeVenta.Items.ClearCache();
			foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
			{
                //Sabrina: Tarea 1071. 20110322
                if (item.EsCombo)
                {
                    tsh_CombosDetDataset.tsh_CombosDetDataTable tableProductosCombo = tsh_CombosDet.GetByIdProducto(item.IdProducto).tsh_CombosDet;
                    for (int i = 0; i < item.Cantidad; i++)
                    {
                        foreach (tsh_CombosDetDataset.tsh_CombosDetRow rowPC in tableProductosCombo.Rows)
                        {
                            Productos productoC = new Productos(rowPC, item.IdListaDePrecios, item.IdListaDePreciosDefault, this.ListaDePreciosHabilitadas);
                            Item itemPC = new Item(productoC);
                            itemPC.SetConversion(string.Empty);
                            itemPC.Conversion.Items.Get(0).ValorSinConvertir = rowPC.Cantidad;
                            itemPC.PorcentajeDescuento = productoC.DescuentoProcentualProductoCombo;
                            mz.erp.businessrules.comprobantes.ItemComprobante itemComprobantePC = new ItemComprobante("NEW", _comprobanteDeVenta.Items, itemPC);
                            itemComprobantePC.IdCombo = item.IdProducto;
                            itemComprobantePC.Combo = item.Descripcion;
                            _comprobanteDeVenta.Items.AddInCache(itemComprobantePC);
                        }
                    }

                }
                else
                {
                    mz.erp.businessrules.comprobantes.ItemComprobante _miItemComprobante = new ItemComprobante("NEW", _comprobanteDeVenta.Items, item);
                    _comprobanteDeVenta.Items.AddInCache(_miItemComprobante);
                }
                //Fin Sabrina: Tarea 1071. 20110322
			}
			_comprobanteDeVenta.Items.FlushCache();
			if(AddItemsChanged != null)
				AddItemsChanged(this, new EventArgs());

		}

		public void OnRecalcularItems()
		{
			this._comprobanteDeVenta.RecalcularItems();
			//this._comprobanteDeVenta.Items.OnRecalcularItems();
		}

		public void ClearResponsableDeEmision() 
		{						
			_comprobanteDeVenta.IdResponsable = ""; 
			if(ResponsableDeEmisionChanged != null)
				ResponsableDeEmisionChanged(this , new EventArgs());
		}

		public ItemComprobante ConvertToItem(object item)
		{
			return (ItemComprobante)item;
		}

		/// <summary>
		/// Esta propiedad no deberia ser publica. No deberia ser usada nunca. Al que intente usarla se le estirpara 
		/// de a uno por uno, los dedos de la mano derecha, y de la izquierda para aquel q sea zurdo.
		/// Esta variable solo esta pq no se ha hecho el controlador pa el formulario FrmABMComprobantesProductos.
		/// </summary>
		public ComprobanteDeVenta Comprobante
		{
			get {  return _comprobanteDeVenta ;}
		}

		private bool _habiltaOrden = false;
		public bool HabilitaOrden
		{
			get{return _habiltaOrden;}
		}

		private void InitializeData()
		{
			SetLayoutProductos();
			SetLayoutImpuestos();
			SetLayoutVariables();
			SetLayoutCondicionesDeVenta();
			SetLeyendaFormulario();
			SetEditable();
			_habiltaOrden = Variables.GetValueBool("Comprobantes.CondicionesDeVentas.HabilitaOrden");
			SetCombosData();
		}

		private void SetEditable()
		{	//si el proceso actual es "procesoPrevenderVender" retorna false, sino true.
			this._editable = (this._comprobanteDeVenta.IsEditable());	
		}
		
		private void SetLayoutCondicionesDeVenta()
		{
			ArrayList _buildedarray = new ArrayList();
			_buildedarray.Add("IdCuota");
			_buildedarray.Add("FechaVencimiento");
			_buildedarray.Add("Monto");
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;
			_layoutCondicionesDeVenta = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleCondicionDeVenta( _campos );
		}

		private void SetLayoutVariables()
		{
			_layoutVariables = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutVariables( );
		}

		private void SetLayoutImpuestos()
		{
			ArrayList _buildedarray = new ArrayList();
			_buildedarray.Add("DescripcionCorta");
			_buildedarray.Add("Valor");
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;
			_layoutImpuestos = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutResumenImpuestos( _campos );
		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._comprobanteDeVenta.GetProcessManagerParent().Process.ProcessName,this._comprobanteDeVenta.GetTaskName(),"LeyendaFormulario");			
			if (leyenda.Equals(string.Empty))
			{
				leyenda= this._comprobanteDeVenta.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}
		private void SetLayoutProductos()
		{
			if (Variables.GetValueBool("Comprobantes.Objetos.DefinicionActiva"))
			{
				ArrayList _buildedarray = new ArrayList();
				_buildedarray.Add("Codigo");
				_buildedarray.Add("DescripcionLarga");
				//_buildedarray.Add("Cantidad");
				//_buildedarray.Add("UnidadDestino");
				_buildedarray.Add("CantidadUnidadOrigen");
				//_buildedarray.Add("UnidadOrigen");
				_buildedarray.Add("BonificacionPorcentual");
				_buildedarray.Add("PrecioDeVentaBruto");
				_buildedarray.Add("PrecioConImpuestos");
				_buildedarray.Add("SubTotalConImpuestos");
				_buildedarray.Add("PrecioConImpuestosDirectos");
				string _camposExtra = Variables.GetValueString("Sistema.Interfaz.ComprobantesDeVenta.LayoutProductos.CamposAdicionales");
				string[] _camposExtras = _camposExtra.Split( ',' );
				for(int i=0;i<_camposExtras.Length;i++)
				{
					_buildedarray.Add( _camposExtras[i] );
				}

				string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;

				_layoutItems  = ComprobantesDeVenta.GetLayoutDetalleProductos( _campos );
			}
			else
			{
				ArrayList _buildedarray = new ArrayList();
				_buildedarray.Add("Codigo");
				_buildedarray.Add("DescripcionDetallada");
				_buildedarray.Add("Cantidad");
				_buildedarray.Add("UnidadDestino");
				_buildedarray.Add("CantidadUnidadOrigen");
				_buildedarray.Add("UnidadOrigen");
				_buildedarray.Add("PrecioConImpuestos");
				_buildedarray.Add("PrecioConImpuestosDirectos");
				_buildedarray.Add("SubTotalConImpuestos");
				string _camposExtra = Variables.GetValueString("Sistema.Interfaz.ComprobantesDeVenta.LayoutProductos.CamposAdicionales");
				string[] _camposExtras = _camposExtra.Split( ',' );
				for(int i=0;i<_camposExtras.Length;i++)
				{
					_buildedarray.Add( _camposExtras[i] );
				}
					
				string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;
				_layoutItems = ComprobantesDeVenta.GetLayoutDetalleProductos( _campos );
				
			}
		}

		private void SetCombosData()
		{
			tsh_ListasDePreciosDataset.tsh_ListasDePreciosDataTable listaDePreciosTable = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
			_listaDePrecios =(tsh_ListasDePreciosDataset.tsh_ListasDePreciosDataTable) VariablesListComparer.FilterDataTable(this._comprobanteDeVenta.GetProcessManagerParent().Process.ProcessName, this._comprobanteDeVenta.GetTaskName(), "ListasDePrecios", KeyValueListaDePrecios, listaDePreciosTable);
			
			_idListaDePreciosDefault = Variables.GetValueString(this._comprobanteDeVenta.GetProcessManagerParent().Process.ProcessName, this._comprobanteDeVenta.GetTaskName(), "ListaDePreciosDefault");	
			if(_idListaDePreciosDefault.Equals(string.Empty))
				_idListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
		}


		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public string GetTaskName()
		{
			return _comprobanteDeVenta.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_comprobanteDeVenta.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_comprobanteDeVenta.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool AllowPrevious()
		{
			return _comprobanteDeVenta.AllowPrevious();
		}

		public void Previous()
		{
			_comprobanteDeVenta.Previous();
		}


		public ITask GetTask()
		{
			// TODO: agregar la implementación ComprobantesDeVentaController.GetTask
			return null;
		}

		public void Execute()
		{
			// TODO: agregar la implementación ComprobantesDeVentaController.Execute
			_comprobanteDeVenta.Execute();
		}

		public bool AllowShow()
		{
			return this._processManager.AllowShow(_comprobanteDeVenta.GetTaskName());
		}
		
		public event EventHandler OnTaskBeforExecute;
		public void ListenerAfterExecute( object sender, System.EventArgs e)
		{
			if (OnTaskAfterExecute != null)
			{
				OnTaskAfterExecute( this, new System.EventArgs() );
			}
		}
		public ItemsDatasetErrors GetErrors()
		{
			return 	_comprobanteDeVenta.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_comprobanteDeVenta.GetWarnings();
		}
		public void Continue()
		{
			_comprobanteDeVenta.Execute();
		}

									   
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
	        if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{   // Entra por lanzamiento de mzProductosControl (valores es un Producto)
				ProcessItemComprobante( (ArrayList)valores);
                /* Silvina 20111104 - Tarea 0000222 */
                //German 20120514 - Tarea 0000325
                //if (_comprobanteDeVenta.UsaCategorias)
                //    _comprobanteDeVenta.ActualizarCategorias();
                //Fin German 20120514 - Tarea 0000325
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			if ((valores.GetType()) == typeof(System.String))
			{
				if (_comprobanteDeVenta.InfoCliente != Convert.ToString(valores)) 
				{
					_comprobanteDeVenta.InfoCliente =  Convert.ToString(valores);				
				}		
				if ( this._comprobanteDeVenta.ListasDePrecios )
				{
					_comprobanteDeVenta.IdListaDePreciosDefault = ((mz.erp.ui.controllers.mzCuentasControlController) sender).IdListaDePreciosDefault;
					this.ProcessObjectsObserverListaPrecios();
					//Sabrina 20100615 - Tarea 765
					this.ProcessObjectsObserverCuenta();
					//Fin Sabrina 20100615 - Tarea 765
				}
			}
		}
		#endregion

		#region IObservable
		private ArrayList _objectListener = new ArrayList();
		public void AddObjectListener( IObserver _object )
		{
			_objectListener.Add( _object );
		}
		public void ProcessObjectsObserver()
		{
			System.EventArgs e = new System.EventArgs();
			foreach ( IObserver _object in _objectListener )
			{
				_object.UpdateObject( this, _comprobanteDeVenta.InfoCliente);	
			}
		}
		
		public void ProcessObjectsObserverListaPrecios()
		{
			foreach ( IObserver _object in _objectListener )
			{
				if (_object.GetType() == Type.GetType("mz.erp.ui.controllers.mzProductosControlController") )				
				{
					_object.UpdateObject( this, _comprobanteDeVenta.IdListaDePreciosDefault);
                    /* Silvina 20101022 - Tarea 887 */
                    if (_comprobanteDeVenta.ActualizaLP)
                    /* Fin Silvina */
					    _comprobanteDeVenta.ActualizarListaDePreciosItemsCargadados();
                    /* Silvina 20111104 - Tarea 0000222 */
                   //German 20120514 - Tarea 0000325
                   if (_comprobanteDeVenta.UsaCategorias && _comprobanteDeVenta.ActualizaLPPorCategoria)
                   //Fin German 20120514 - Tarea 0000325

                        _comprobanteDeVenta.ActualizarCategorias();
                    /* Fin Silvina 20111104 - Tarea 0000222 */
				}				
			}
		}
		
		//Sabrina 20100615 - Tarea 765
		public void ProcessObjectsObserverCuenta()
		{
			foreach ( IObserver _object in _objectListener )
			{
				if (_object.GetType() == Type.GetType("mz.erp.ui.controllers.mzProductosControlController") )				
				{
					_object.UpdateObject( this, _comprobanteDeVenta.Cuenta.IdListaDePreciosDefault);
                    /* Silvina 20101022 - Tarea 887 */
                    if (_comprobanteDeVenta.ActualizaLP)
                        /* Fin Silvina */
                        _comprobanteDeVenta.ActualizarListaDePreciosItemsCargadados();
                    /* Silvina 20111104 - Tarea 0000222 */
                    //German 20120514 - Tarea 0000325
                    if (_comprobanteDeVenta.UsaCategorias && _comprobanteDeVenta.ActualizaLPPorCategoria)
                        //Fin German 20120514 - Tarea 0000325

                        _comprobanteDeVenta.ActualizarCategorias();
                    /* Fin Silvina 20111104 - Tarea 0000222 */
				}				
			}
		}
		//Fin Sabrina 20100615 - Tarea 765
		
		#endregion

		private void _comprobanteDeVenta_TableCondicionesDeVentaChanged(object sender, EventArgs e)
		{
			if(TableCondicionesDeVentaChanged != null)
			{
				TableCondicionesDeVentaChanged(this, new EventArgs());
			}
		}

		
		/*
		private void _comprobanteDeVenta_NumeroComprobanteChanged(object sender, EventArgs e)
		{
			if (NumeroComprobanteChanged != null)
				NumeroComprobanteChanged(this,new System.EventArgs());
		}
		*/
		
		private void _comprobanteDeVenta_CondicionesDeVentaChanged(object sender, EventArgs e)
		{
			if(CondicionDeVentaChanged != null)
				CondicionDeVentaChanged(this, new EventArgs());
		}


		public string FillNumberWithZeros(string txt)
		{
			return _comprobanteDeVenta.FillNumberWithZeros(txt);
		}
	
	}
}
