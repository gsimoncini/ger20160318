using System;
using System.Collections.Generic;
using System.Text;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.modelo.Combo
{
    public class ListaDePreciosComboDetItem
    {
        #region Variables privadas
        private string _idProducto = string.Empty;
        private long _ordinal = 0;
        private string _idListaDePrecio = string.Empty;
		private string _modoDeAplicacion = string.Empty;
   		private decimal _coeficiente = 0;
        //Es el precio de venta bruto del producto en la LP con el descuento combo aplicado.
		private decimal _precioDeVentaBruto = 0;
        private decimal _descuentoCombo = 0;
        private decimal _descuentoComboPorcentual = 0;
        //Es el precio de venta bruto del producto en la LP que puede coincidir o no con el de la LP del producto fuera del combo.
        private decimal _precioDeVentaBrutoOriginal = 0;
        private string _descripcion = string.Empty;
        private string _codigo = string.Empty;
        private bool _isDefault = false;
        private string _estado = string.Empty;
        private decimal _valorCotizacionPrecioDeCostoRef = 1;
        private decimal _valorCotizacionPrecioDeVentaBruto = 1;

        #endregion

        #region Constructores
        public ListaDePreciosComboDetItem(string IdProducto, long Ordinal, string IdListaDePrecio, string Descripcion, string Codigo, bool IsDefault, string ModoDeAplicacion, decimal Coeficiente, decimal PrecioDeVentaBrutoOriginal, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal ValorCotizacionPrecioDeCostoRef, decimal ValorCotizacionPrecioDeVentaBruto, string Estado)
        {
            _idProducto = IdProducto;
            _ordinal = Ordinal;
            _idListaDePrecio = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _isDefault = IsDefault;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficiente = Coeficiente;
            _precioDeVentaBrutoOriginal = PrecioDeVentaBrutoOriginal;
            _descuentoCombo = DescuentoCombo;
            _descuentoComboPorcentual = DescuentoComboPorcentual;
            _precioDeVentaBruto = _precioDeVentaBrutoOriginal - _descuentoCombo;
            _valorCotizacionPrecioDeCostoRef = ValorCotizacionPrecioDeCostoRef;
            _valorCotizacionPrecioDeVentaBruto = ValorCotizacionPrecioDeVentaBruto;
            _estado = Estado;
        }

        public ListaDePreciosComboDetItem(string IdProducto, long Ordinal, string IdListaDePrecio, string Descripcion, string Codigo, bool IsDefault, string ModoDeAplicacion, decimal Coeficiente, decimal PrecioDeVentaBrutoOriginal, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal PrecioDeVentaBruto, decimal ValorCotizacionPrecioDeCostoRef, decimal ValorCotizacionPrecioDeVentaBruto, string Estado)
        {
            _idProducto = IdProducto;
            _ordinal = Ordinal;
            _idListaDePrecio = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _isDefault = IsDefault;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficiente = Coeficiente;
            _precioDeVentaBrutoOriginal = PrecioDeVentaBrutoOriginal;
            _descuentoCombo = DescuentoCombo;
            _descuentoComboPorcentual = DescuentoComboPorcentual;
            _precioDeVentaBruto = PrecioDeVentaBruto;
            _valorCotizacionPrecioDeCostoRef = ValorCotizacionPrecioDeCostoRef;
            _valorCotizacionPrecioDeVentaBruto = ValorCotizacionPrecioDeVentaBruto;
            _estado = Estado;
        }
        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
        }

        public long Ordinal
        {
            get { return _ordinal; }
        }

        public string IdListaDePrecio
        {
            get { return _idListaDePrecio; }
        }

        public string ModoDeAplicacion
        {
            get { return _modoDeAplicacion; }
            set { _modoDeAplicacion = value; }
        }

        public decimal Coeficiente
        {
            get { return _coeficiente; }
            set { _coeficiente = value; }
        }

        public decimal PrecioDeVentaBruto
        {
            get { return _precioDeVentaBruto; }
            set { _precioDeVentaBruto = value; }
        }

        public decimal DescuentoCombo
        {
            get { return _descuentoCombo; }
            set { _descuentoCombo = value; }
        }

        public decimal DescuentoComboProcentual
        {
            get { return _descuentoComboPorcentual; }
            set 
            { 
                _descuentoComboPorcentual = value;
                _descuentoCombo = (_precioDeVentaBrutoOriginal * _descuentoComboPorcentual) / 100;
                PrecioDeVentaBruto = _precioDeVentaBrutoOriginal - _descuentoCombo;
            }
        }

        public decimal PrecioDeVentaBrutoOriginal
        {
            get { return _precioDeVentaBrutoOriginal; }
            set { _precioDeVentaBrutoOriginal = value; }
        }

        public bool IsDefault
        {
            get { return _isDefault; }
        }
        
        public string Estado
		{
			get{return _estado;}
            set{_estado = value;}
		}

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public decimal ValorCotizacionPrecioDeCostoRef
        {
            get { return _valorCotizacionPrecioDeCostoRef; }
            set { _valorCotizacionPrecioDeCostoRef = value; }
        }

        public decimal ValorCotizacionPrecioDeVentaBruto
        {
            get { return _valorCotizacionPrecioDeVentaBruto; }
            set { _valorCotizacionPrecioDeVentaBruto = value; }
        }
        #endregion

        #region Metodos Privados


        #endregion

        #region Metodos Publicos
        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
        {
            switch (_estado)
            {
                case "NEW": //Nuevo lista de precios para el producto del combo
                    {
                        tsh_ProductosExDataset.tsh_CombosDetListasDePreciosRow rowCDLP = data.tsh_CombosDetListasDePrecios.Newtsh_CombosDetListasDePreciosRow();
                        rowCDLP.IdProducto = this.IdProducto;
                        rowCDLP.Ordinal = this.Ordinal;
                        rowCDLP.IdListaDePrecio = this.IdListaDePrecio;
                        rowCDLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowCDLP.Coeficiente = this.Coeficiente;
                        rowCDLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowCDLP.DescuentoCombo = this.DescuentoCombo;
                        rowCDLP.DescuentoComboPorcentual = this.DescuentoComboProcentual;
                        rowCDLP.PrecioDeVentaBrutoOriginal = this.PrecioDeVentaBrutoOriginal;
                        rowCDLP.FechaCreacion = DateTime.Now;
                        rowCDLP.IdConexionCreacion = Security.IdConexion;
                        rowCDLP.IdConexionUltimaModificacion = Security.IdConexion;
                        rowCDLP.IdReservado = 0;
                        rowCDLP.RowId = Guid.Empty;
                        rowCDLP.IdEmpresa = Security.IdEmpresa;
                        rowCDLP.IdSucursal = Security.IdSucursal;
                        data.tsh_CombosDetListasDePrecios.Addtsh_CombosDetListasDePreciosRow(rowCDLP);
                        break;

                    }
                case "MODIF": //Modificacion de Lista de precios del producto del combo
                    {
                        tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowCDLP = tsh_CombosDetListasDePrecios.GetByPk(this.IdProducto, this.Ordinal, this.IdListaDePrecio);
                        if (rowCDLP.PrecioDeVentaBruto != this.PrecioDeVentaBruto)
                            rowCDLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowCDLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowCDLP.DescuentoCombo = this.DescuentoCombo;
                        rowCDLP.DescuentoComboPorcentual = this.DescuentoComboProcentual;
                        data.tsh_CombosDetListasDePrecios.ImportRow(rowCDLP);
                        break;
                    }
                case "DEL": //Borrado de lista de precios del producto del combo
                    {
                        tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowCDLP = tsh_CombosDetListasDePrecios.GetByPk(this.IdProducto, this.Ordinal, this.IdListaDePrecio);
                        rowCDLP.Delete();
                        data.tsh_CombosDetListasDePrecios.ImportRow(rowCDLP);
                        break;
                    }
                default:
                    break;

            }

            return data;
        }
        #endregion
    }
}
