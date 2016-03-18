using System;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

/// <summary>
/// Descripción breve de ItemComprobanteX.
/// </summary>
public class ItemComprobanteX: DataObject
{
	//El precio de Venta es el Neto es el precio una vez aplicados todos los descuentos
	//sobre este valor se deben aplicar los impuestos
	private decimal _precioDeVentaNeto;
	private string _idProducto;
	private decimal _cantidad;

	private object _comprobanteDeOrigen;
	private decimal _precioDeCostoNeto=0;
	private decimal _precioVentaBruto=0;

	private Impuestos _impuestos;

	private string _descripcionLarga;
	private string _descripcionCorta;
	private string _descripcion;
	private string _descripcionLargaOriginal;
	private string _descripcionCortaOriginal;
	private string _descripcionOriginal;
	
	private decimal _descuentosAplicadosImporte;
	private decimal _margenReal_Neto_Importe;	
	private decimal _margenMinimo_Neto_Importe;
	private decimal _representacionConElTotal;

	public delegate void ChangeItemProperty( EventArgsChange e);
	public event ChangeItemProperty OnChangeItemProperty;

	public ItemComprobanteX(object _comprobanteDeOrigen, string IdProducto)
	{
		tsh_ProductosExDataset data = mz.erp.businessrules.tsh_ProductosEx.GetByPk(IdProducto);
		if ( data.tsh_Productos.Rows.Count != 1 )
		{
			object ex = new System.Exception("Error al buscar producto");
		}
		_precioDeCostoNeto = _CostoFinal(data);
		_precioDeVentaBruto = _PrecioVentaBruto( data );
		_precioDeVentaNeto = _PrecioDeVentaNeto( data );
		_comprobanteDeOrigen = comprobanteDeOrigen;
		_impuestos = _ImpuestosProducto( data );
	}

	/// <summary>
	/// El precio de Venta Neto se forma en base al precio de lista menos todos los descuentos aplicados
	/// Es el precio al cual se le aplican los impuestos, el que se le cobra al cliente, la primera vez
	/// que se carga el precio de Venta Neto toma el valor del precio de venta bruto menos los descuentos
	/// que tiene definido por default el cliente para ese producto, luego el precio de venta neto puede ir
	/// siendo modificado (en realidad lo que se modifica es el porcentaje de descuento).
	/// El Precio de Venta Neto menos el precio de Costo Neto hacen el margen de ganancia.
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	private decimal _PrecioDeVentaNeto( mz.erp.commontypes.data.tsh_ProductosExDataset data )
	{
		_precioDeVentaNeto = _PrecioDeVentaBruto;
	}

	/// <summary>
	/// El precio de Venta bruto se obtiene de tomar el precio de venta base definido para el producto
	/// mas los recargos/bonificaciones definidos para esa sucursal. El precio de Venta bruto tambien
	/// es conocido como precio de lista, es el que se publica y sobre el cual luego se aplica
	/// la politica de descuentos para llegar al precio real: El precio de Venta Neto.
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	private decimal _PrecioVentaBruto( mz.erp.commontypes.data.tsh_ProductosExDataset data )
	{
		decimal _precioDeVentaBruto = 0;
		decimal _procBonificacionRecargoProdSuc = 0;
		
		if ( data.tsh_Productos.Rows.Count == 1 )
		{
			tsh_ProductosDataset.tsh_ProductosRow rowProducto;
			rowProducto = ( tsh_ProductosDataset.tsh_ProductosRow )data.tsh_Productos.Rows[ 0 ];
			_precioDeVentaBruto = rowProducto.PrecioDeVentaBruto;
		}
		if ( data.tsh_ProductosSucursales.Rows.Count == 1 )
		{
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowProductosSucursales;
			rowProductosSucursales = (tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow)data.tsh_ProductosSucursales.Rows[ 0 ];
			//_procBonificacionRecargoProdSuc_procBonificacionRecargoProdSuc = rowProductosSucursales
		}
		return 0;

	}

	/// <summary>
	/// Levanta la coleccion de impuestos definida para ese producto
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	private decimal _ImpuestosProducto( mz.erp.commontypes.data.tsh_ProductosExDataset data )
	{
		//Gustavo. Put your code here
		
		/*tsh_ImpuestosDataset.tsh_ImpuestosTable tableImpuestos;
		tableImpuestos = ( tsh_ImpuestosDataset.tsh_ImpuestosTable )data.tsh_Impuestos;
		foreach ( System.Data.DataRow row in tableImpuestos)
		{
			Impuesto im = new Impuesto();
			im.Nombre = row["Descripcion"];
			im.Valor =  row["Valor"];
			_impuestos.Add( im );
		}*/
	}

	/// <summary>
	/// El costo final del articulo se refiere al costo definido por el articulo mas los recargos sobre el costo
	/// que se aplican en la sucursal mas los recargos sobre el costo que se aplican especificamente sobre ese producto
	/// sobre esa sucursal. El Precio de Venta Neto menos el precio de Costo Neto hacen el margen de ganancia.
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	private decimal _CostoNeto( mz.erp.commontypes.data.tsh_ProductosExDataset data )
	{
		decimal _precioDeCostoRefProducto = 0;
		decimal _incrementoDeCostoSucursal = 0;
		decimal _cargoFijoProductosSucursal = 0;
		decimal _costoNeto = 0;
		
		if ( data.tsh_Productos.Rows.Count == 1 )
		{
			tsh_ProductosDataset.tsh_ProductosRow rowProducto;
			rowProducto = ( tsh_ProductosDataset.tsh_ProductosRow )data.tsh_Productos.Rows[ 0 ];
			_precioDeCostoRefProducto = rowProducto.PrecioDeCostoRef;
		}
		

		if ( data.tsh_ProductosSucursales.Rows.Count == 1 )
		{
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowProductosSucursales;
			rowProductosSucursales = (tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow)data.tsh_ProductosSucursales.Rows[ 0 ];
			_incrementoDeCostoSucursal = rowProductosSucursales.IncrementoDeCosto;
		}

		if ( data.sy_Sucursales.Rows.Count == 1)
		{
			sy_SucursalesDataset.sy_SucursalesRow rowSucursal;
			rowSucursal = (sy_SucursalesDataset.sy_SucursalesRow)data.sy_Sucursales.Rows[ 0 ];
			_cargoFijoProductosSucursal = rowSucursal.CargoFijoProductos;
		}
		_costoNeto+= _precioDeCostoRefProducto;
		_costoNeto+= _incrementoDeCostoSucursal;
		_costoNeto+= _cargoFijoProductosSucursal;

		return _costoNeto;

	}


	#region Descripciones
	public void SetDescripcion(string value)
	{
		Descripcion = value;
	}
	public string GetDescripcion()
	{
		return Descripcion;
	}
	public string Descripcion
	{
		set 
		{
			_descripcion = value;
		}
		get
		{
			return _descripcion ;
		}
	}
	public bool IsChangeDescripcion()
	{
		return _descripcion.Equals( _descripcionOriginal );
	}
	#endregion
	#region Cantidad
	public decimal Cantidad
	{
		set 
		{
			if (value < ComprobantesRules.GetMaxItemValue())
			{
				if (OnChangeItemProperty != null) 
				{
					_cantidad = value;

					EventArgsChange e = new EventArgsChange();
					e.PropertyName="Cantidad";
					e.NewValue = value;
					e.OldValue = _cantidad;
					//Disparo el evento de notificación del cambio
					OnChangeItemProperty( e );
				}
			}
			else
			{
				System.ArgumentOutOfRangeException e = new System.ArgumentOutOfRangeException("Cantidad",value,"Valor fuera de rango");
				throw ( e );
			}
		}
		get 
		{
			return _cantidad;
		}
	}
	#endregion
	#region PrecioDeVentaNeto
	/// <summary>
	/// Al modificar el precio -una vez chequeado que esta dentro del rango permitido-, se calcula cuanto
	/// seria en nivel de descuento que esa modificación representa, con ese porcentual se modifica la propiedad
	/// descuentosporcentual que dispara el evento de notificacion
	/// </summary>
	public decimal PrecioDeVentaNeto
	{
		set
		{
			//Si el precio que me esta ingresando no es menor al maximo nivel de descuento que se puede hacer
			if ( ( value - _precioDeCosto ) <= _MargenMinimo_Neto_Importe) 
			{
				DescuentoImporte = _precioVentaBruto - value;
				_precioDeVentaNeto = value;
			}
		}
		get
		{
			return _precioDeVentaNeto;
		}
	}
	#endregion
	#region DescuentosImporte
	/// <summary>
	/// El importe de descuento... lalala
	/// </summary>
	public decimal DescuentoImporte
	{
		set 
		{
			if (( (_precioVentaBruto-value) -_precioDeCostoNeto) < _margenMinimo_Neto_Importe )
			{
				if (OnChangeItemProperty != null) 
				{
					EventArgsChange e = new EventArgsChange();
					e.PropertyName="Precio";
					e.OldValue = _precioDeVentaNeto;

					_descuentosAplicadosImporte = value;
					_precioDeVentaNeto = _precioVentaBruto-_descuentosAplicadosImporte;
					_margenReal_Neto_Importe = ((_precioVentaBruto-_descuentosAplicadosImporte) - _precioDeCostoNeto);

					//Disparo el evento de notificación del cambio
					e.NewValue = _precioDeVentaNeto;					
					OnChangeItemProperty( e );
				}
			}
		}
		get
		{
			return _descuentosAplicadosImporte;
		}
	}
	#endregion
	#region PrecioDeVentaNetoConImpuestos
	public decimal PrecioDeVentaNetoConImpuestos
	{
		//Gustavo. Put you code here
		//MagicClass.CalcularImpuestos( _comprobanteDeOrigen, _precioDeVentaNeto, _impuestos);
	}

	#endregion
	#region SubTotales
	public decimal SubTotalNeto
	{
		get 
		{
			return _cantidad * _precioDeVentaNeto;
		}
	}
	public decimal SubTotalConImpuestos
	{
		get
		{
			return _cantidad * _precioDeVentaNetoConImpuestos;
		}
	}

	#endregion
}

