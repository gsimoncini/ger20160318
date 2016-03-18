using System;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules.Comprobantes_de_Compra;
using mz.erp.systemframework;

namespace mz.erp.businessrules.Comprobantes_de_Compra
{
	/// <summary>
	/// Descripción breve de ItemComprobanteCompra.
	/// </summary>
	public class ItemComprobanteCompra
	{
		public ItemComprobanteCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Clases Auxiliares
		public class ItemCompra
		{
			public ItemCompra()
			{
			}
			private string _descripcionCorta = string.Empty;
			private string _descripcionLarga = string.Empty;
			private string _descripcion= string.Empty;
			//private decimal _bonificacionRecargoProducto = 0;
			//private decimal _bonificacionRecargoFinanciero = 0;
			//private decimal _bonificacionRecargoCuenta = 0 ;
			private string _idProducto = string.Empty;
			private long _ordinalOrigen = 0;
			private long _ordinalDestino = 0;
			private string _idComprobanteOrigen = string.Empty;
			private string _idTipoComprobanteOrigen = string.Empty;
			private string _idComprobanteDestino = string.Empty;
			private string _idTipoComprobanteDestino = string.Empty;
			private decimal _cantidad = 0;
			private string _idMomentoDeStock = string.Empty;
			//private decimal _precioNeto = 0;
			//private decimal _precioBruto = 0;
			private decimal _precioCosto = 0;
			//private decimal _bonificacionaplicada = 0;
			private string _codigo;


			public string Codigo
			{
				get{return _codigo;}
				set{_codigo = value;}
			}

			public string DescripcionCorta
			{
				get 
				{
					if (_descripcionCorta != string.Empty)
					{
						return _descripcionCorta;
					}
					else
					{
						return _descripcion; 
					}
				}
				set { _descripcionCorta = value; }
			}
		
			public string DescripcionLarga
			{
				get 
				{ 
					if (_descripcionLarga != String.Empty )
					{
						return _descripcionLarga;
					}
					else
					{
						return _descripcion;
					}
				}
				set { _descripcionLarga = value; }
			}
		
			public string Descripcion
			{
				get { return _descripcion; }
				set { _descripcion = value; }
			}

		/*	public decimal BonificacionRecargoProducto
			{
				get { return _bonificacionRecargoProducto ; }
				set { _bonificacionRecargoProducto = value ; }
			}
		
			public decimal BonificacionRecargoFinanciero
			{
				get { return _bonificacionRecargoFinanciero ; }
				set { _bonificacionRecargoFinanciero = value ; }
			}
		
			public decimal BonficacionRecargoCuenta
			{
				get { return _bonificacionRecargoCuenta ; }
				set { _bonificacionRecargoCuenta = value ; }
			}*/
		
			public string IdProducto 
			{
				get { return _idProducto ;}
				set { _idProducto = value ; }
			}
		
			public long OrdinalOrigen
			{
				get { return _ordinalOrigen ; }
				set { _ordinalOrigen = value; }
			}
		
			public long OrdinalDestino
			{
				get { return _ordinalDestino ; }
				set { _ordinalDestino = value ; }
			}
		
			public string IdComprobanteOrigen
			{
				get { return _idComprobanteOrigen ; }
				set { _idComprobanteOrigen = value ; }
			}
		
			public string IdComprobanteDestino
			{
				get { return _idComprobanteDestino ; }
				set { _idComprobanteDestino = value ; }
			}
		
			public string IdTipoComprobanteOrigen
			{
				get { return _idTipoComprobanteOrigen; }
				set { _idTipoComprobanteOrigen = value ; }
			}
			public string IdTipoComprobanteDestino
			{
				get { return _idTipoComprobanteDestino; }
				set { _idTipoComprobanteDestino = value ;}
			}

			public decimal Cantidad
			{
				get { return _cantidad ; }
				set { _cantidad = value ; }
			}

			public string IdMomentoDeStock
			{
				get { return _idMomentoDeStock; }
				set { _idMomentoDeStock = value ;}
			}
		
			/*public decimal PrecioNeto
			{
				get { return _precioNeto; }
				set { _precioNeto = value ;}
			}*/
		
		/*	public decimal PrecioBruto
			{
				get { return _precioBruto ; }
				set { _precioBruto = value ;} 
			}*/
			public decimal PrecioCosto
			{
				get { return _precioCosto ; }
				set { _precioCosto = value ; }
			}
		/*	public decimal BonificacionAplicada
			{
				set { _bonificacionaplicada = value ; }
				get { return _bonificacionaplicada ; }
			}*/
		}
		#endregion

		#region Variables Privadas		
		//private decimal _precio = 0;
		private string _idProducto;
		private decimal _cantidad;
		private long _ordinal = 0;
		private long _ordinalOrigen = 0;

	
		private decimal _precioDeCosto=0;
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



		//Para la visualizacion de Stock

		private string _visualizacionStock;
		private string _estadoStock;
		private decimal _cantStock;
		private decimal _cantStockPropio;

		#endregion

		#region Variables Publicas
		/// <summary>
		/// La coleccion de items que lo contiene.
		/// </summary>
		public ItemsComprobantesCompra ItemsComprobantes
		{
			get { return _itemsComprobantes; }
			set {_itemsComprobantes = value;}
		}

		/// <summary>
		/// Descripcion del item. 
		/// Permite modificarla segun lo indicado en la variable
		/// Comprobante.Seguridad.Productos.PermiteModificarDescripcion
		/// </summary>
		/// 


		public decimal PrecioDecosto
		{
			get{return _precioDeCosto;}
			//set{_precioDeCosto = value;}
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
						//if (OnRefreshItem != null)
						//{
						//	OnRefreshItem( this, new System.EventArgs() );
						//}
					}
				}
			}
			get
			{
				return _descripcion ;
			}
		}

		/// <summary>
		/// Descirpcion larga del producto
		/// Permite modificarla segun lo indicado en la variable
		/// Comprobante.Seguridad.Productos.PermiteModificarDescripcion
		/// </summary>
		public string DescripcionLarga
		{
			set 
			{
				if (true) //ComprobantesRules.Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion)
				{
					if (value != _descripcionLarga)
					{
						_descripcionLarga = value;
						//if (OnRefreshItem != null)
						//{
						//	OnRefreshItem( this, new System.EventArgs() );
						//}
					}
				}
				
			}
			get
			{
				return _descripcionLarga ;
			}
		}
		/// <summary>
		/// Descirpcion larga del producto
		/// Permite modificarla segun lo indicado en 
		/// ComprobantesRules.GetMaxItemValue
		/// </summary>
		public decimal Cantidad
		{
			set 
			{
				//if (_cantidad <= ComprobantesRules.GetMaxItemValue())
				//{
					if (value != _cantidad)
					{
						_cantidad = Math.Abs(value) * this.ItemsComprobantes.Parent.Signo;
						//this.IsDirty=true;
						//AplicarBonificaciones();
						//if (OnRecalcItem != null)
						//{
						//	OnRecalcItem( this, new System.EventArgs() );
						//}
						//if(CantidadChanged != null)
						//	CantidadChanged(this, new EventArgs());
					}
				//}
			}
			get 
			{
				return _cantidad;
			}
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
			get
			{
				return _codigo;
			}
		}
		/// <summary>
		/// Posicion con respecto a la coleccion de items
		/// </summary>
		public long Ordinal
		{
			get
			{
				return _ordinal;
			}
			set
			{
				_ordinal = value;
			}
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
		#endregion

		#region Constructores
		
		#region Constructor que solo sirve para pedidos
		public ItemComprobanteCompra(ItemComprobante item, ItemsComprobantesCompra items)
		{
			
			
			Productos miProducto = new mz.erp.businessrules.Productos( "CODIGO", item.Codigo);
			ItemCompra itemCompra = new mz.erp.businessrules.Comprobantes_de_Compra.ItemComprobanteCompra.ItemCompra();
			itemCompra.IdProducto = miProducto.IdProducto;
			itemCompra.Cantidad = 0;
			
			itemCompra.Descripcion =  miProducto.Descripcion;
			
			itemCompra.PrecioCosto = miProducto.PrecioDeCosto;

			itemCompra.Codigo = miProducto.Codigo;
			
			
			this.IdProducto = item.IdProducto;
			this.ItemsComprobantes = items;
			this._descripcion = item.Descripcion;
			this._descripcionOriginal = item.Descripcion;
			this._descripcionCorta = itemCompra.DescripcionCorta;
			this._descripcionLarga = item.DescripcionLarga;
			this._descripcionLargaOriginal = item.DescripcionLarga;
			this._codigo = itemCompra.Codigo;

					
			this._cantidad = Math.Abs(item.Cantidad) ;

			
			this._precioDeCosto = itemCompra.PrecioCosto;
					
			this._idComprobanteOrigen = null;
			this._ordinalOrigen = long.MinValue;
			this._idTipoComprobanteOrigen = null;
			this._ordinal = this.ItemsComprobantes.Count;

			//this._impuestos = new Impuestos("NEW", this );

		}




		public ItemComprobanteCompra(System.Data.DataRow row, ItemsComprobantesCompra items)
		{
				
				Productos miProducto = new mz.erp.businessrules.Productos(  (string) row["IdProducto"] );
				ItemCompra item = new ItemCompra();
				item.IdProducto = miProducto.IdProducto;
				item.Cantidad = (decimal)row["Cantidad"];
				//item.PrecioNeto = (decimal)row["PrecioNeto"];
				//item.PrecioBruto = (decimal)row["PrecioBruto"];
				item.Descripcion = miProducto.Descripcion;
				item.DescripcionCorta = miProducto.DescripcionCorta;
				item.DescripcionLarga = miProducto.DescripcionLarga;
				//item.BonificacionRecargoProducto = (decimal)row["BonificacionRecargoProducto"];
				item.PrecioCosto = (decimal)row["PrecioDeCosto"];
				//item.BonificacionAplicada = (decimal)row["DescuentosAplicados"];
				//item.BonificacionRecargoFinanciero = (decimal)row["BonificacionRecargoFinanciero"];
				item.OrdinalDestino = (long)row["Ordinal"];
				item.Codigo = miProducto.Codigo;

				this.IdProducto = item.IdProducto;
				this._codigo = item.Codigo;
				this.ItemsComprobantes = items;
				this._descripcion = item.Descripcion;
				this._descripcionOriginal = item.Descripcion;
				this._descripcionCorta = item.DescripcionCorta;
				this._descripcionLarga = item.DescripcionLarga;
				this._descripcionLargaOriginal = item.DescripcionLarga;

				//this._bonificacion = item.BonificacionRecargoProducto;
				//this._bonificacionRecargoProducto = item.BonificacionRecargoProducto;
				//this._bonificacionRecargoFinanciero = 0;
					
				this._cantidad = Math.Abs(item.Cantidad) ;

				//this._precio = item.PrecioNeto;
				//this._precioDeVentaBruto = item.PrecioBruto;
				this._precioDeCosto = item.PrecioCosto;
					
				this._idComprobanteOrigen = null;
				this._ordinalOrigen = long.MinValue;
				this._idTipoComprobanteOrigen = null;
				this._ordinal = this.ItemsComprobantes.Count;

				
				
			}
		#endregion



		public ItemComprobanteCompra(string action, ItemCompra item, ItemsComprobantesCompra items)

		{
			this.ItemsComprobantes = items;
			Init(action, item);
		}

		#endregion

		#region Inicializadores
		private void Init( string action, ItemCompra item )
		{
			switch (action.ToUpper())
			{
				case "NEW":
					FillLoadData( action, item );
					//FillStaticData( );
					break;
				case "EDIT":
					FillLoadData( action, item );
					//FillStaticData( );
					break;
				case "STEP":
					FillLoadData( action, item );
					//FillStaticData( );
					break;
			}

		}
		
		private void FillLoadData( string action, ItemCompra item )
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
					this._ordinal = this.ItemsComprobantes.Count;
					this._codigo = item.Codigo;
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
					this._ordinalOrigen = long.MinValue;
					this._ordinal = item.OrdinalDestino;
					this._codigo = item.Codigo;
					break;
				case "STEP":
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._cantidad = item.Cantidad;
					this._precioDeCosto = item.PrecioCosto;
					this._idComprobanteOrigen = item.IdComprobanteOrigen;
					this._ordinalOrigen = item.OrdinalOrigen;
					this._ordinal = item.OrdinalDestino;
					this._idTipoComprobanteOrigen = item.IdTipoComprobanteOrigen;
					this._codigo = item.Codigo;
					break;
			}

		}
			
		
	

		#endregion

		#region Commit

		public void Commit()
		{

			tpu_ComprobantesExDataset data = this.ItemsComprobantes.Parent.DatasetComprobante;
			tpu_ComprobantesExDataset.tpu_ComprobantesDetRow row = data.tpu_ComprobantesDet.Newtpu_ComprobantesDetRow();
			row.IdComprobante = this.ItemsComprobantes.Parent.IdComprobante;
			row.Ordinal = this._ordinal;
			row.Cantidad = this._cantidad;
			row.IdProducto = this._idProducto;
			row.PrecioDeCosto = this._precioDeCosto;
			row.ImpuestosDirectos = 0; //this.ImpuestosDirectos.Total;
			row.ImpuestosIndirectos = 0 ;//this.ImpuestosIndirectos.Total;
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.FechaCreacion = System.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			data.tpu_ComprobantesDet.Addtpu_ComprobantesDetRow( row );
			//Commit de los movimientos de Stock
			data = (tpu_ComprobantesExDataset)this.CommitMovimientosDeStock(data);
			// Commit de las relaciones origen destino			
			data = (tpu_ComprobantesExDataset)this.CommitRelacionOrigenDestino(data);
			
		}


		private tpu_ComprobantesExDataset CommitMovimientosDeStock(tpu_ComprobantesExDataset data)
		{
			//Movimiento de Stock			
			if(!this.ItemsComprobantes.Parent.Momento.Equals("PREPEDIR"))
			{
				string IdDeposito = ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.Parent.Momento, "Deposito");
				string IdSeccion =  ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.Parent.Momento, "Seccion");

				string IdEstadoStockOrigen = string.Empty;
				string IdEstadoStockDestino = string.Empty;
				long idMomentoDeStock = tlg_TiposComprobantesOrigenDestino.GetMomento( this._idTipoComprobanteOrigen, this.ItemsComprobantes.Parent.TipoComprobanteDestino);
				//Stock.GetEstados( idMomentoDeStock, ref IdEstadoStockOrigen, ref IdEstadoStockDestino );

				if ((IdDeposito != string.Empty) && (IdSeccion != string.Empty) )
				{
					data = mz.erp.businessrules.tpu_ComprobantesEx.SetMovimientosDeStock( data, Security.IdSucursal, Security.IdEmpresa, IdDeposito, IdSeccion, null,IdEstadoStockOrigen,IdEstadoStockDestino, null,this._idProducto, this._cantidad );
				}
			}
			return data;
		}


		private tpu_ComprobantesExDataset CommitRelacionOrigenDestino(tpu_ComprobantesExDataset data)
		{
			if(!this.ItemsComprobantes.Parent.Momento.Equals("PREPEDIR"))
			{
				string IdComprobanteOrigen = this._idComprobanteOrigen;
				string IdComprobanteDestino = this.ItemsComprobantes.Parent.IdComprobanteDestino;
				long IdOrdinalOrigen = this._ordinalOrigen;
				long IdOrdinalDestino = this._ordinal;
				bool CierraCircuito = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.CierraCircuito(  this.ItemsComprobantes.Parent.TipoComprobanteDestino );
			
				decimal Cantidad = this._cantidad;			
				if (IdComprobanteOrigen != IdComprobanteDestino) 
				{
					data = mz.erp.businessrules.tpu_ComprobantesEx.SetRelacionOrigenDestino(data, IdComprobanteOrigen, IdComprobanteDestino, IdOrdinalOrigen, IdOrdinalDestino, Cantidad, CierraCircuito);
				}
			}
			return data;
		}

	

		#endregion



	}


}
