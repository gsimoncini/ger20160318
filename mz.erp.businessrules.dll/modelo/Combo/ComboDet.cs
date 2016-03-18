using System;
using System.Collections.Generic;
using System.Text;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules.modelo.Combo
{
  
    public class ComboDet
    {
        #region Variables privadas
        private string _idProducto = string.Empty;
        private long _ordinal = 0;
        private string _idProductoReferencia = string.Empty;
        private decimal _cantidad = 0;
        private decimal _descuentoCombo = 0;
        private decimal _descuentoComboPorcentual = 0;
        //Es el precio de venta bruto del producto que puede coincidir o no con el del producto fuera del combo.
        private decimal _precioDeVentaBrutoOriginal = 0;
        //Es el precio de venta bruto del producto con el descuento combo aplicado.
        private decimal _precioDeVentaBruto = 0;
        private decimal _precioDeCostoRef = 0;
        private long _idEmpresa = 0;
        private long _idSucursal = 0;
        private string _simboloMonedaPrecioDeCostoRef = string.Empty;
        private string _simboloMonedaPrecioDeVentaBruto = string.Empty;
        private ListaDePreciosComboDet _listaDePreciosComboDet;
        private string _estado = string.Empty;
        private string _codigo = string.Empty;
        private string _descripcion = string.Empty; 
        private string _idListaDePreciosReferencia = string.Empty;
        private tsh_ProductosDataset.tsh_ProductosRow _rowProducto;
        private CotizacionWrapper _cotizacionProductoPrecioDeCosto;
        private CotizacionWrapper _cotizacionProductoPrecioDeVenta;
        #endregion

        #region Constructores
        public ComboDet()
		{
        }
        public ComboDet(tsh_CombosDetDataset.tsh_CombosDetRow row)
		{
            _idProducto = row.IdProducto;
            _ordinal = row.Ordinal;
            _idProductoReferencia = row.IdProductoReferencia;
            _cantidad = row.Cantidad;
            _descuentoCombo = row.DescuentoCombo;
            _descuentoComboPorcentual = row.DescuentoComboPorcentual;
            _precioDeVentaBrutoOriginal = row.PrecioDeVentaBrutoOriginal;
            _precioDeVentaBruto = row.PrecioDeVentaBruto;
            _precioDeCostoRef = row.PrecioDeCostoRef;
            _idEmpresa = row.IdEmpresa;
            _idSucursal = row.IdSucursal;
            _rowProducto = tsh_Productos.GetByPk(_idProductoReferencia);
            _codigo = _rowProducto.Codigo;
            _descripcion = _rowProducto.Descripcion;
            _estado = string.Empty;
            _simboloMonedaPrecioDeCostoRef = mz.erp.businessrules.tfi_Monedas.GetByPk(row.IdMonedaCierrePrecioDeCostoRef).Simbolo;
            _simboloMonedaPrecioDeVentaBruto = mz.erp.businessrules.tfi_Monedas.GetByPk(row.IdMonedaCierrePrecioDeVentaBruto).Simbolo;
            if (row.IdCotizacionCierrePrecioDeCostoRef != null)
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeCostoRef);
            if (row.IdCotizacionCierrePrecioDeVentaBruto != null)
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeVentaBruto);
            _listaDePreciosComboDet = new ListaDePreciosComboDet(this, _estado);
        }

        public ComboDet(string IdProducto, long Ordinal, string IdProductoReferencia, decimal Cantidad, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal PrecioDeVentaBrutoOriginal, decimal PrecioDeCostoRef)
        {
            _idProducto = IdProducto;
            _ordinal = Ordinal;
            _idProductoReferencia = IdProductoReferencia;
            _cantidad = Cantidad;
            _descuentoCombo = DescuentoCombo;
            _descuentoComboPorcentual = DescuentoComboPorcentual;
            _precioDeVentaBrutoOriginal = PrecioDeVentaBrutoOriginal;
            _precioDeVentaBruto = PrecioDeVentaBrutoOriginal - DescuentoCombo;
            _precioDeCostoRef = PrecioDeCostoRef;
            _idEmpresa = Security.IdEmpresa;
            _idSucursal = Security.IdSucursal;
            _rowProducto = tsh_Productos.GetByPk(_idProductoReferencia);
            _codigo = _rowProducto.Codigo;
            _descripcion = _rowProducto.Descripcion;
            _estado = "NEW";
            _simboloMonedaPrecioDeCostoRef = mz.erp.businessrules.tfi_Monedas.GetByPk(_rowProducto.IdMonedaCierrePrecioDeCostoRef).Simbolo;
            _simboloMonedaPrecioDeVentaBruto = mz.erp.businessrules.tfi_Monedas.GetByPk(_rowProducto.IdMonedaCierrePrecioDeVentaBruto).Simbolo;
            if (IdCotizacionCierrePrecioDeCostoRef != null)
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(_rowProducto.IdCotizacionCierrePrecioDeCostoRef);
            if (IdCotizacionCierrePrecioDeVentaBruto != null)
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(_rowProducto.IdCotizacionCierrePrecioDeVentaBruto);
            _listaDePreciosComboDet = new ListaDePreciosComboDet(this, _estado);
        }      
       
        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
            //set { _idProducto = value; }
        }

        public long Ordinal
        {
            get { return _ordinal; }
        }

        public string IdProductoReferencia
        {
            get { return _idProductoReferencia; }
        }
        
        public decimal Cantidad
        {
            get { return _cantidad; }
            set 
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    if (this._estado.Equals(string.Empty))
                        this._estado = "MODIF";
                }
            }
        }

        public decimal DescuentoCombo
        {
            get { return _descuentoCombo; }
        }

        public decimal DescuentoComboProcentual
        {
            get { return _descuentoComboPorcentual; }
            set
            {
                if (_descuentoComboPorcentual != value)
                {
                    _descuentoComboPorcentual = value;
                    _descuentoCombo = (_precioDeVentaBrutoOriginal * _descuentoComboPorcentual) / 100;
                    PrecioDeVentaBruto = _precioDeVentaBrutoOriginal - _descuentoCombo;
                    this.ListaDePreciosComboDet.UpdateDescuentoPorcentual(this.IdProducto, this.Ordinal,_idListaDePreciosReferencia,_descuentoComboPorcentual);
                    if (this._estado.Equals(string.Empty))
                        this._estado = "MODIF";
                }
            }
        }

        public decimal PrecioDeVentaBrutoOriginal
        {
            get { return _precioDeVentaBrutoOriginal; }
        }

        public decimal PrecioDeVentaBruto
        {
            get { return _precioDeVentaBruto; }
            set 
            { 
                _precioDeVentaBruto = value;
                if (this._estado.Equals(string.Empty))
                    this._estado = "MODIF";
            }
        }

        public decimal PrecioDeCostoRef
        {
            get { return _precioDeCostoRef; }
        }

        public long IdEmpresa
        {
            get { return _idEmpresa; }
        }

        public long IdSucursal
        {
            get { return _idSucursal; }
        }

        public string IdMonedaCierrePrecioDeCostoRef
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                {
                    return _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
                }
                return string.Empty;
            }
            set
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                {
                    if (value != _cotizacionProductoPrecioDeCosto.IdMonedaOrigen)
                    {
                        _cotizacionProductoPrecioDeCosto.IdMonedaOrigen = value;
                        if (value != null && value != string.Empty)
                            _simboloMonedaPrecioDeCostoRef = mz.erp.businessrules.tfi_Monedas.GetByPk(value).Simbolo;
                    }
                }
            }
        }

        public string IdMonedaCierrePrecioDeVentaBruto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    return _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
                }
                return string.Empty;
            }
            set
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    if (value != _cotizacionProductoPrecioDeVenta.IdMonedaOrigen)
                    {
                        _cotizacionProductoPrecioDeVenta.IdMonedaOrigen = value;
                        if (value != null && value != string.Empty)
                        {
                            _simboloMonedaPrecioDeVentaBruto = mz.erp.businessrules.tfi_Monedas.GetByPk(value).Simbolo;
                        }

                    }
                }
            }
        }

        public string SimboloMonedaPrecioDeCostoRef
        {
            get { return _simboloMonedaPrecioDeCostoRef; }
        }

        public string SimboloMonedaPrecioDeVentaBruto
        {
            get { return _simboloMonedaPrecioDeVentaBruto; }
        }

        public string IdCotizacionCierrePrecioDeCostoRef
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                    return _cotizacionProductoPrecioDeCosto.IdCotizacion;
                return string.Empty;
            }
        }

        public string IdCotizacionCierrePrecioDeVentaBruto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                    return _cotizacionProductoPrecioDeVenta.IdCotizacion;
                return string.Empty;
            }
        }

        public decimal ValorCotizacionPrecioDeCostoRef
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                {
                    return _cotizacionProductoPrecioDeCosto.Valor;
                }
                return 1;
            }
        }


        public decimal ValorCotizacionPrecioDeVentaBruto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    return _cotizacionProductoPrecioDeVenta.Valor;
                }
                return 1;
            }
        }

        public ListaDePreciosComboDet ListaDePreciosComboDet
        {
            get { return _listaDePreciosComboDet; }
            /*set
            {
                _listaDePreciosComboDet = value;
            }*/
        }

        public string Codigo
        {
            get { return _codigo; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public string IdListaDePreciosReferencia
        {
            get { return _idListaDePreciosReferencia; }
            set 
            {
                if (_idListaDePreciosReferencia != value)
                {
                    _idListaDePreciosReferencia = value;
                    ListaDePreciosComboDetItem item = ListaDePreciosComboDet.GetItem(this.IdProducto, this.Ordinal, _idListaDePreciosReferencia);
                    _precioDeVentaBrutoOriginal = item.PrecioDeVentaBrutoOriginal;
                    _descuentoCombo = item.DescuentoCombo;
                    _descuentoComboPorcentual = item.DescuentoComboProcentual;
                    _precioDeVentaBruto = item.PrecioDeVentaBruto;
                }
            }
        }

        public tsh_ProductosDataset.tsh_ProductosRow RowProducto
        {
            get { return _rowProducto; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        #endregion

        #region Metodos Privados
        #endregion

        #region Metodos Publicos
        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
        {
            switch (_estado)
            {
                case "NEW": //Nuevo producto para el combo
                    {
                        tsh_ProductosExDataset.tsh_CombosDetRow rowCD = data.tsh_CombosDet.Newtsh_CombosDetRow();
                        rowCD.IdProducto = this.IdProducto;
                        rowCD.Ordinal = this.Ordinal;
                        rowCD.IdProductoReferencia = this.IdProductoReferencia;
                        rowCD.Cantidad = this.Cantidad;
                        //Estos campos los tomo de la LP default ya que pudieron haberse modificado si el usuario selecciono ver por otra LP.
                        rowCD.DescuentoCombo = this.ListaDePreciosComboDet.GetDefaultItem().DescuentoCombo;
                        rowCD.DescuentoComboPorcentual = this.ListaDePreciosComboDet.GetDefaultItem().DescuentoComboProcentual;
                        rowCD.PrecioDeVentaBrutoOriginal = this.ListaDePreciosComboDet.GetDefaultItem().PrecioDeVentaBrutoOriginal;
                        rowCD.PrecioDeVentaBruto = this.ListaDePreciosComboDet.GetDefaultItem().PrecioDeVentaBruto;
                        rowCD.PrecioDeCostoRef = this.PrecioDeCostoRef;
                        rowCD.FechaCreacion = DateTime.Now;
                        rowCD.IdConexionCreacion = Security.IdConexion;
                        rowCD.IdConexionUltimaModificacion = Security.IdConexion;
                        rowCD.IdReservado = 0;
                        rowCD.RowId = Guid.Empty;
                        rowCD.IdEmpresa = Security.IdEmpresa;
                        rowCD.IdSucursal = Security.IdSucursal;
                        rowCD.IdMonedaCierrePrecioDeCostoRef = this.IdMonedaCierrePrecioDeCostoRef;
                        rowCD.IdMonedaCierrePrecioDeVentaBruto = this.IdMonedaCierrePrecioDeVentaBruto;
                        rowCD.IdCotizacionCierrePrecioDeCostoRef = this.IdCotizacionCierrePrecioDeCostoRef;
                        rowCD.IdCotizacionCierrePrecioDeVentaBruto = this.IdCotizacionCierrePrecioDeVentaBruto;
                        data.tsh_CombosDet.Addtsh_CombosDetRow(rowCD);

                        break;

                    }
                case "MODIF": //Modificacion del producto de un combo
                    {
                        tsh_CombosDetDataset.tsh_CombosDetRow rowCD = tsh_CombosDet.GetByPk(this.IdProducto, this.Ordinal);
                        rowCD.Cantidad = this.Cantidad;
                        //Estos campos los tomo de la LP default ya que pudieron haberse modificado si el usuario selecciono ver por otra LP.
                        rowCD.DescuentoCombo = this.ListaDePreciosComboDet.GetDefaultItem().DescuentoCombo;
                        rowCD.DescuentoComboPorcentual = this.ListaDePreciosComboDet.GetDefaultItem().DescuentoComboProcentual;
                        if (rowCD.PrecioDeVentaBruto != this.ListaDePreciosComboDet.GetDefaultItem().PrecioDeVentaBruto)
                            rowCD.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowCD.PrecioDeVentaBruto = this.ListaDePreciosComboDet.GetDefaultItem().PrecioDeVentaBruto;
                        data.tsh_CombosDet.ImportRow(rowCD);
                        break;
                    }

                case "DEL": //Borrado de producto de un combo
                    {
                        tsh_CombosDetDataset.tsh_CombosDetRow rowCD = tsh_CombosDet.GetByPk(this.IdProducto, this.Ordinal);
                        rowCD.Delete();
                        data.tsh_CombosDet.ImportRow(rowCD);
                        break;
                    }
                default:
                    break;

            }
            data = this.ListaDePreciosComboDet.Commit(data);
            return data;

        }

        public void UpdateDescuentoPorcentual(string IdListaDePrecio, decimal DescuentoComboProcentual)
        {
            this.ListaDePreciosComboDet.UpdateDescuentoPorcentual(this.IdProducto, this.Ordinal, IdListaDePrecio, DescuentoComboProcentual);
        }

        public void UpdateDescuentoPorcentual(decimal DescuentoComboProcentual)
        {
            this.ListaDePreciosComboDet.UpdateDescuentoPorcentual(DescuentoComboProcentual);
        }
        #endregion
    }


}
