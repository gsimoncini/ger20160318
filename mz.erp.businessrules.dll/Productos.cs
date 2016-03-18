using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Data.SqlClient;


namespace mz.erp.businessrules
{
    /// <summary>
    /// Descripción breve de Productos realiza todos los calculos acerca de la determinación del precio, el stock, la mercaderia
    /// visible / invisible y toda la lógica referente a la relación del producto con la sucursal.
    /// </summary>
    public class Productos
    {
        #region Region Dinamica
        private string _idProveedor = string.Empty;
        private string _tipoDePrecioDeCosto = string.Empty;
        private string _idProducto = string.Empty;
        private long _idSucursal = 0;
        private long _idEmpresa = Security.IdEmpresa;
        private bool _listaDePreciosHabilitadas = false;
        private string _idListaDePrecios = string.Empty;
        private string _idListaDePreciosDefault = tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
        private tsh_ProductosDataset.tsh_ProductosRow rowProducto;
        private sy_SucursalesDataset.sy_SucursalesRow rowSucursal;
        private tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowProductoAuxiliar;
        private tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowProductoSucursal;
        private tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowListaDePrecios;
        private tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowProveedoresProductos;
        //Sabrina: Tarea 1071. 20110322
        private tsh_CombosDetDataset.tsh_CombosDetRow rowComboDet;
        private tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowComboDetListaDePrecios;
        //Sabrina: Tarea 1071. 20110322
        /* Silvina 20111104 - Tarea 0000222 */
        private tsh_AgrupProductosDataset dataProductoJerarquia;
        /* Fin Silvina 20111104 - Tarea 0000222 */
        private string _idConversion;
        private string _idUnidadMedida;
        private string _nombreCampoAuxiliar1 = Variables.GetValue("Productos.CampoAuxiliar1.Etiqueta").ToString();
        private string _nombreCampoAuxiliar2 = Variables.GetValue("Productos.CampoAuxiliar2.Etiqueta").ToString();
        private string _nombreCampoAuxiliar3 = Variables.GetValue("Productos.CampoAuxiliar3.Etiqueta").ToString();
        private string _nombreCampoAuxiliar4 = Variables.GetValue("Productos.CampoAuxiliar4.Etiqueta").ToString();
        private string _nombreCampoAuxiliar5 = Variables.GetValue("Productos.CampoAuxiliar5.Etiqueta").ToString();
        private decimal _coeficientecotizacion = 0;
        private decimal _coeficientecotizacionPrecioDeCosto = 0;

        private string _idBonificacion = string.Empty;

        private string _idCotizacionPrecioDeCostoRef = string.Empty;
        private string _idMonedaPrecioDeCostoRef = string.Empty;
        private string _simboloMonedaPrecioDeCostoRef = string.Empty;
        private string _idFuenteDeCambioPrecioDeCostoRef = string.Empty;
        private decimal _valorCotizacionPrecioDeCostoRef = 1;

        private ArrayList _codigosSecundarios = new ArrayList();


        public ArrayList CodigosSecundarios
        {
            get
            {
                return _codigosSecundarios;
            }
        }

        public string IdCotizacionPrecioDeCostoRef
        {
            get { return _idCotizacionPrecioDeCostoRef; }
        }

        public string IdMonedaPrecioDeCostoRef
        {
            get { return _idMonedaPrecioDeCostoRef; }
        }

        public string SimboloMonedaPrecioDeCostoRef
        {
            get { return _simboloMonedaPrecioDeCostoRef; }
        }

        public string IdFuenteDeCambioPrecioDeCostoRef
        {
            get { return _idFuenteDeCambioPrecioDeCostoRef; }
        }

        public decimal ValorCotizacionPrecioDeCostoRef
        {
            get { return _valorCotizacionPrecioDeCostoRef; }
        }

        public string IdBonificacion
        {
            get
            {
                if (rowProducto != null)
                    return rowProducto.IdBonificacion;
                else return string.Empty;
            }
        }

        public string IdUnidadMedida
        {
            get
            {
                return _idUnidadMedida;
            }
        }
        public string IdConversion
        {
            get
            {
                return _idConversion;
            }
        }


        public string IdProducto
        {
            get
            {
                if (rowProducto != null)
                {
                    return _idProducto;
                }
                else
                {
                    return null;
                }
            }
        }
        public string Codigo
        {
            get
            {
                if (rowProducto != null) { return rowProducto.Codigo; }
                else { return null; }
            }
        }

        public string DescripcionDetallada
        {
            get
            {
                string aux = null;
                aux = Descripcion;
                aux = aux + " " + CampoAuxiliar1;
                aux = aux + " " + CampoAuxiliar2;
                aux = aux + " " + CampoAuxiliar3;
                return aux;
            }
        }

        public string Descripcion
        {
            get
            {
                if (rowProducto != null)
                {

                    return rowProducto.Descripcion;
                }
                else { return null; }
            }
        }

        public string CampoAuxiliar1
        {
            get
            {
                if (rowProducto != null) { return rowProducto.CampoAuxiliar1; }
                else { return null; }
            }
        }
        public string CampoAuxiliar2
        {
            get
            {
                if (rowProducto != null) { return rowProducto.CampoAuxiliar2; }
                else { return null; }
            }
        }
        public string CampoAuxiliar3
        {
            get
            {
                if (rowProducto != null) { return rowProducto.CampoAuxiliar3; }
                else { return null; }
            }
        }
        public string CampoAuxiliar4
        {
            get
            {
                if (rowProducto != null) { return rowProducto.CampoAuxiliar4; }
                else { return null; }
            }
        }


        public string CampoAuxiliar5
        {
            get
            {
                if (rowProducto != null) { return rowProducto.CampoAuxiliar5; }
                else { return null; }
            }
        }

        public string NombreCampoAuxiliar1
        {
            get { return _nombreCampoAuxiliar1; }
            set { _nombreCampoAuxiliar1 = value; }
        }

        public string NombreCampoAuxiliar2
        {
            get { return _nombreCampoAuxiliar2; }
            set { _nombreCampoAuxiliar2 = value; }
        }

        public string NombreCampoAuxiliar3
        {
            get { return _nombreCampoAuxiliar3; }
            set { _nombreCampoAuxiliar3 = value; }
        }

        public string NombreCampoAuxiliar4
        {
            get { return _nombreCampoAuxiliar4; }
            set { _nombreCampoAuxiliar4 = value; }
        }

        public string NombreCampoAuxiliar5
        {
            get { return _nombreCampoAuxiliar5; }
            set { _nombreCampoAuxiliar5 = value; }
        }

        public string DescripcionLarga
        {
            get
            {
                if (rowProducto != null)
                {
                    if ((rowProducto.DescripcionLarga == string.Empty) || (rowProducto.DescripcionLarga == null))
                    {
                        return rowProducto.Descripcion;
                    }
                    else
                    {
                        return rowProducto.DescripcionLarga;
                    }
                }
                else
                {
                    return null;
                }

            }
        }
        public string DescripcionCorta
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.DescripcionCorta;
                }
                else
                {
                    return null;
                }
            }
        }

        public long ContadorOrigen
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Contador;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool TieneCodigoSecundarioSegmentado
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.TieneCodigoSecundarioSegmentado;
                }
                else
                {
                    return false;
                }
            }
        }

        public long ContadorDestino
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Contador;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCostoDirecto
        {

            get
            {
                if (rowProducto != null)
                {
                    if (_tipoDePrecioDeCosto.Equals(string.Empty) || _tipoDePrecioDeCosto.Equals("Precio de Costo"))
                        return rowProducto.PrecioDeCostoDirecto;
                    else if (_tipoDePrecioDeCosto.Equals("Precio de Lista Proveedor"))
                    {
                        if (rowProveedoresProductos != null)
                            return rowProveedoresProductos.PrecioDeCostoFinal;
                        else
                            return 0;
                    }
                    else if (_tipoDePrecioDeCosto.Equals("Ultima Compra Proveedor"))
                    {
                        if (rowProveedoresProductos != null)
                            return rowProveedoresProductos.PrecioDeCostoUltimaCompra;
                        else
                            return 0;
                    }
                    else
                        return rowProducto.PrecioDeCostoDirecto;
                }
                return 0;
            }
        }

        public decimal PrecioDeCostoDirectoMonedaReferencia
        {

            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoDirecto * _coeficientecotizacionPrecioDeCosto;
                }
                return 0;
            }
        }

        public decimal PrecioDeVentaBruto
        {
            //Sabrina: Tarea 1071. 20110322
            get
            {
                if (rowComboDet != null)
                {
                    decimal _precioDeVentaBruto = 0;
                    if (!_listaDePreciosHabilitadas)
                        _precioDeVentaBruto = rowComboDet.PrecioDeVentaBruto;
                    else
                        _precioDeVentaBruto = rowComboDetListaDePrecios.PrecioDeVentaBruto;
                    _precioDeVentaBruto = _precioDeVentaBruto * _coeficientecotizacion;
                    decimal _incrementoProducto = _precioDeVentaBruto * (rowSucursal.BonificacionRecargoProductos / 100);
                    decimal _precioDeVentaBrutoSucursal = _precioDeVentaBruto + _incrementoProducto;
                    return _precioDeVentaBrutoSucursal;
                }
                else if (rowProducto != null)
                {
                    decimal _precioDeVentaBruto = 0;
                    if (!_listaDePreciosHabilitadas)
                        _precioDeVentaBruto = rowProducto.PrecioDeVentaBruto;
                    else
                        _precioDeVentaBruto = rowListaDePrecios.PrecioDeVentaBruto;
                    _precioDeVentaBruto = _precioDeVentaBruto * _coeficientecotizacion;
                    decimal _incrementoProducto = _precioDeVentaBruto * (rowSucursal.BonificacionRecargoProductos / 100);
                    decimal _precioDeVentaBrutoSucursal = _precioDeVentaBruto + _incrementoProducto;
                    return _precioDeVentaBrutoSucursal;
                }
                else
                {
                    return 0;
                }
            }
            //Fin Sabrina: Tarea 1071. 20110322
        }

        public decimal PrecioDeCostoMonedaReferencia
        {
            get
            {
                if (rowProducto != null)
                {
                    decimal _precioDeCostoProducto = rowProducto.PrecioDeCostoRef;
                    _precioDeCostoProducto = _coeficientecotizacionPrecioDeCosto * _precioDeCostoProducto;
                    decimal _cargoFijoProducto = rowSucursal.CargoFijoProductos;
                    decimal _incrementoDeCosto = rowProductoSucursal.IncrementoDeCosto;
                    decimal _montoDeIncremento = _precioDeCostoProducto * _incrementoDeCosto / 100;
                    return (_precioDeCostoProducto + _montoDeIncremento + (_cargoFijoProducto * _coeficientecotizacionPrecioDeCosto));
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCosto
        {
            get
            {
                if (rowProducto != null)
                {
                    decimal _precioDeCostoProducto = rowProducto.PrecioDeCostoRef;
                    //_precioDeCostoProducto = _coeficientecotizacionPrecioDeCosto * _precioDeCostoProducto;
                    decimal _cargoFijoProducto = rowSucursal.CargoFijoProductos;
                    decimal _incrementoDeCosto = rowProductoSucursal.IncrementoDeCosto;
                    decimal _montoDeIncremento = _precioDeCostoProducto * _incrementoDeCosto / 100;
                    return (_precioDeCostoProducto + _montoDeIncremento + _cargoFijoProducto);
                }
                else
                {
                    return 0;
                }
            }
        }

        public string IdTipoProducto
        {
            get
            {
                if (rowProducto != null)
                    return rowProducto.IdTipoProducto;
                return string.Empty;
            }
        }

        private string _codigoSecundarioSegmentado = string.Empty;
        public string CodigoSecundarioSegmentado
        {
            get { return _codigoSecundarioSegmentado; }
            set { _codigoSecundarioSegmentado = value; }
        }

        public string CodigoSecundario
        {
            get
            {

                return rowProducto.CodigoSecundario;
            }
        }

        public string CodigoProveedor
        {
            get
            {

                return rowProducto.CodigoProveedor;
            }
        }

        public decimal MAC
        {
            get
            {
                if (false /*rowProductoSucursal.MAC != 0*/)
                {
                    return rowProductoSucursal.MAC;
                }
                else
                {
                    return rowProducto.MAC;
                }


            }

        }
        public decimal PrecioDeVentaNeto
        {
            get
            {
                if (rowProductoSucursal != null)
                {
                    decimal _precioDeCosto = PrecioDeCostoMonedaReferencia; //El precio de costo ya esta en la moneda convertida
                    //Si el margen especifico para la sucursal no está definido obtengo el precio a partir del precio margen
                    //definido en la central para el producto
                    decimal _precioDeVentaNeto = 0;
                    if (false /*rowProductoSucursal.MAC != 0*/)
                    {
                        _precioDeVentaNeto = (_precioDeCosto * rowProductoSucursal.MAC / 100) + _precioDeCosto;
                    }
                    else
                    {
                        _precioDeVentaNeto = (_precioDeCosto * rowProducto.MAC / 100) + _precioDeCosto;
                    }

                    return _precioDeVentaNeto;
                }
                else
                {
                    return 0;
                }
            }
        }
        public decimal MaximoDescuento
        {
            get
            {
                // TODO ver si lo modifico para lista de precios.
                return (PrecioDeVentaBruto - PrecioDeVentaNeto);
            }
        }
        public decimal PorcentajeMaximoDescuento
        {
            get
            {
                if (!_listaDePreciosHabilitadas)
                    return Convert.ToDecimal(rowProducto["MaxDescuentoPorcentual"]);
                else
                    return rowListaDePrecios.MaxDescuentoPorcentual;
            }
        }

        public decimal MaximoDescuentoConImpuestos
        {
            get
            {
                return (PrecioBrutoConImpuestos - PrecioNetoConImpuestos);
            }
        }

        //private decimal _impuestosNetos = 0; 
        //private decimal _impuestosBrutos = 0;                  
        public decimal PrecioNetoConImpuestos
        {
            get
            {
                //return PrecioDeVentaNeto+_impuestosNetos; 
                return Convert.ToDecimal(rowProductoSucursal.PrecioFinalEstimado * _coeficientecotizacion);
            }
        }
        public decimal PrecioBrutoConImpuestos
        {
            //Sabrina: Tarea 1071. 20110322
            get
            {
                if (rowComboDet != null)
                {
                    decimal precioDeVentaBruto = 0;
                    if (!_listaDePreciosHabilitadas)
                    {
                        precioDeVentaBruto = rowComboDet.PrecioDeVentaBruto;
                    }
                    else
                        precioDeVentaBruto = rowComboDetListaDePrecios.PrecioDeVentaBruto;
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                    decimal impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, precioDeVentaBruto);
                    return precioDeVentaBruto + impuestosBrutos;
                }
                else
                {
                    if (!_listaDePreciosHabilitadas)
                        return Convert.ToDecimal(rowProductoSucursal.PrecioFinalEstimado * _coeficientecotizacion);
                    else
                        return rowListaDePrecios.PrecioDeVentaBrutoConImpuesto * _coeficientecotizacion;
                }
            }
            //Fin Sabrina: Tarea 1071. 20110322
        }

        public decimal Stock
        {

            get
            {
                if (rowProducto != null)
                    if (rowProductoSucursal != null)
                        return rowProductoSucursal.StockDisponible;

                return 0;
            }

        }

        public bool PercibeIB
        {
            get
            {
                return Convert.ToBoolean(rowProducto["PercibeIB"]);
            }
        }

        public bool ObligaCodigoBarra
        {
            get
            {
                return rowProducto.ObligaCodigoBarra;
            }
        }

        public bool ObligaNumeroDeSerie
        {
            get
            {
                return rowProducto.ObligaNumeroSerie;
            }
        }


        public string IdListaDePrecios
        {
            get
            {
                if (rowListaDePrecios != null)
                {
                    return _idListaDePrecios;
                }
                else
                {
                    return null;
                }
            }
        }

        public decimal CoeficienteListaDePrecios
        {
            get
            {
                //Sabrina: Tarea 1071. 20110322
                if (rowComboDetListaDePrecios != null)
                {
                    return rowComboDetListaDePrecios.Coeficiente;
                }
                else if (rowListaDePrecios != null)
                {
                    return rowListaDePrecios.Coeficiente;
                }
                else
                {
                    return 0;
                }
                //Fin Sabrina: Tarea 1071. 20110322
            }
        }


        public string ModoDeAplicacionListaDePrecios
        {
            get
            {
                //Sabrina: Tarea 1071. 20110322
                if (rowComboDetListaDePrecios != null)
                {
                    return rowComboDetListaDePrecios.ModoDeAplicacion;
                }
                else if (rowListaDePrecios != null)
                {
                    return rowListaDePrecios.ModoDeAplicacion;
                }
                else
                {
                    return null;
                }
                //Fin Sabrina: Tarea 1071. 20110322
            }
        }

        public string IdListaDePreciosDefault
        {
            get
            {
                return _idListaDePreciosDefault;
            }
        }

        public decimal CoeficienteCotizacion
        {
            get { return _coeficientecotizacion; }
        }

        public decimal Coeficiente1
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente2
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente2;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente3
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente3;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente4
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente4;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente5
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente5;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente6
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente6;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente7
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente7;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente8
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente8;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente9
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente9;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Coeficiente10
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.Coeficiente10;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCostoDirectoDB
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoDirecto;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCostoIndirectoDB
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoIndirecto;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCostoRefDB
        {
            get
            {
                //Sabrina: Tarea 1071. 20110322
                if (rowComboDet != null)
                {
                    return rowComboDet.PrecioDeCostoRef;
                }
                else if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoRef;
                }
                else
                {
                    return 0;
                }
                //Fin Sabrina: Tarea 1071. 20110322
            }
        }

        public decimal PrecioDeCostoReposicion
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoReposicion;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeCostoPromedioPonderado
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeCostoPromedioPonderado;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeVentaMercadoBolsa
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeVentaMercadoBolsa;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeVentaMercadoCadena
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeVentaMercadoCadena;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal PrecioDeVentaMercadoCompetenciaDirecta
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.PrecioDeVentaMercadoCompetenciaDirecta;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool UsaPrecioDeCostoReposicion
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.UsaPrecioDeCostoReposicion;
                }
                else
                {
                    return false;
                }
            }
        }

        public string IdCotizacionCierrePrecioDeCostoRef
        {
            get
            {
                //Sabrina: Tarea 1071. 20110322
                if (rowComboDet != null)
                {
                    return rowComboDet.IdCotizacionCierrePrecioDeCostoRef;
                }
                else if (rowProducto != null)
                {
                    return rowProducto.IdCotizacionCierrePrecioDeCostoRef;
                }
                else
                {
                    return string.Empty;
                }
                //Sabrina: Tarea 1071. 20110322
            }
        }

        //Sabrina: Tarea 1069. 20110322
        public bool EsCombo
        {
            get
            {
                if (rowProducto != null)
                {
                    return rowProducto.EsCombo;
                }
                else
                {
                    return false;
                }
            }
        }
        //Fin Sabrina: Tarea 1069. 20110322

        /* Silvina 20110704 - Tarea 0000136 */
        public bool PermiteCambio
        {
            get
            {
                if (rowProductoAuxiliar != null)
                {
                    return rowProductoAuxiliar.PermiteCambio;
                }
                else
                {
                    return true;
                }
            }
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

        //Sabrina: Tarea 1071. 20110322
        public decimal PrecioDeVentaBrutoOriginalProductoCombo
        {
            get
            {
                if (rowComboDet != null)
                {
                    decimal precioDeVentaBrutoOriginal = 0;
                    if (!_listaDePreciosHabilitadas)
                        precioDeVentaBrutoOriginal = rowComboDet.PrecioDeVentaBrutoOriginal;
                    else
                        precioDeVentaBrutoOriginal = rowComboDetListaDePrecios.PrecioDeVentaBrutoOriginal;
                    precioDeVentaBrutoOriginal = precioDeVentaBrutoOriginal * _coeficientecotizacion;
                    decimal _incrementoProducto = precioDeVentaBrutoOriginal * (rowSucursal.BonificacionRecargoProductos / 100);
                    decimal _precioDeVentaBrutoSucursal = precioDeVentaBrutoOriginal + _incrementoProducto;
                    return _precioDeVentaBrutoSucursal;
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal DescuentoProcentualProductoCombo
        {
            get
            {
                if (rowComboDet != null)
                {
                    if (!_listaDePreciosHabilitadas)
                        return rowComboDet.DescuentoComboPorcentual;
                    else
                        return rowComboDetListaDePrecios.DescuentoComboPorcentual;
                }
                else
                {
                    return 0;
                }
            }
        }
        //Fin Sabrina: Tarea 1071. 20110322

        /* Silvina 20111104 - Tarea 0000222 */
        private string _jerarquiaCategorias = string.Empty;
        string _jerarquiaProductos = Variables.GetValueString("Productos.Categorias.JerarquiaAsociada");
        string _campoAuxiliar6Productos = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada");

        public string JerarquiaCategorias
        {
            get
            {
                return _jerarquiaCategorias;
            }
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */

        //Sabrina: Tarea 1080. 20110326
        public Productos(string clave, string IdProducto, string IdListaDePrecios, string IdListaDePreciosDefault, bool ListasDePreciosHabilitadas, bool MultiplesCodigosSecundarios)
            : this(clave, IdProducto, IdListaDePrecios, IdListaDePreciosDefault, ListasDePreciosHabilitadas, MultiplesCodigosSecundarios, true)
        {
        }

        public Productos(string clave, string IdProducto, string IdListaDePrecios, string IdListaDePreciosDefault, bool ListasDePreciosHabilitadas, bool MultiplesCodigosSecundarios, bool PermiteProductosCombo)
        //Fin Sabrina: Tarea 1080. 20110326
        {
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            _listaDePreciosHabilitadas = ListasDePreciosHabilitadas;
            _idListaDePrecios = IdListaDePrecios;
            _idListaDePreciosDefault = IdListaDePreciosDefault;
            if (clave.ToUpper() == "CODIGO")
            {
                //Sabrina: Tarea 1080. 20110326
                _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(IdProducto, true, PermiteProductosCombo);
                //Fin Sabrina: Tarea 1080. 20110326
                if (_idProducto != string.Empty)
                    InitalizeMembers();
            }
            else
            {
                if (clave.ToUpper() == "CODIGOSECUNDARIO")
                {
                    if (!MultiplesCodigosSecundarios)
                        //Sabrina: Tarea 1080. 20110326
                        _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigoSecundario(IdProducto, true, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
                    else
                        //Sabrina: Tarea 1080. 20110326
                        _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByMultipleCodigoSecundario(IdProducto, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
                    if (_idProducto != string.Empty)
                        InitalizeMembers();
                }
                else
                {

                    if (clave.ToUpper() == "CODIGOPROVEEDOR")
                    {
                        //Sabrina: Tarea 1080. 20110326
                        _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigoProveedor(IdProducto, true, PermiteProductosCombo);
                        //Fin Sabrina: Tarea 1080. 20110326
                        if (_idProducto != string.Empty)
                            InitalizeMembers();
                    }
                    else
                    {
                        _idProducto = IdProducto;
                        InitalizeMembers();
                    }
                }
            }
        }

        //Sabrina: Tarea 1080. 20110326
        public Productos(string clave, string IdProducto, string IdListaDePrecios, string IdListaDePreciosDefault, bool ListasDePreciosHabilitadas, bool MultiplesCodigosSecundarios, string IdProveedor, string TipoDePrecioDeCosto, bool PermiteProductosCombo)
        //Fin Sabrina: Tarea 1080. 20110326
        {
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            _listaDePreciosHabilitadas = ListasDePreciosHabilitadas;
            _idListaDePrecios = IdListaDePrecios;
            _idListaDePreciosDefault = IdListaDePreciosDefault;
            _idProveedor = IdProveedor;
            _tipoDePrecioDeCosto = TipoDePrecioDeCosto;
            if (clave.ToUpper() == "CODIGO")
            {
                //Sabrina: Tarea 1080. 20110326
                _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(IdProducto, true, PermiteProductosCombo);
                //Fin Sabrina: Tarea 1080. 20110326
                if (_idProducto != string.Empty)
                    InitalizeMembers();
            }
            else
            {
                if (clave.ToUpper() == "CODIGOSECUNDARIO")
                {
                    if (!MultiplesCodigosSecundarios)
                        //Sabrina: Tarea 1080. 20110326
                        _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigoSecundario(IdProducto, true, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
                    else
                        //Sabrina: Tarea 1080. 20110326
                        _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByMultipleCodigoSecundario(IdProducto, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
                    if (_idProducto != string.Empty)
                        InitalizeMembers();
                }
                else
                {
                    _idProducto = IdProducto;
                    InitalizeMembers();
                }
            }
        }

        public Productos(string clave, string IdProducto, long IdSucursal, long IdEmpresa)
        {
            _idSucursal = IdSucursal;
            _idEmpresa = IdEmpresa;
            if (clave.ToUpper() == "CODIGO")
            {
                _idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(IdProducto);
            }
            if (_idProducto != string.Empty)
                InitalizeMembers();
        }
        public Productos(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            _idSucursal = IdSucursal;
            _idEmpresa = IdEmpresa;
            _idProducto = IdProducto;
            if (_idProducto != string.Empty)
                InitalizeMembers();
        }
        public Productos(string IdProducto)
        {
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            _idProducto = IdProducto;
            if (_idProducto != string.Empty)
                InitalizeMembers();
        }

        //Sabrina: Tarea 1071. 20110322
        public Productos(tsh_CombosDetDataset.tsh_CombosDetRow RowComboDet, string IdListaDePrecios, string IdListaDePreciosDefault, bool ListasDePreciosHabilitadas)
        {
            rowComboDet = RowComboDet;
            _listaDePreciosHabilitadas = ListasDePreciosHabilitadas;
            _idListaDePrecios = IdListaDePrecios;
            _idListaDePreciosDefault = IdListaDePreciosDefault;
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            _idProducto = rowComboDet.IdProductoReferencia;
            if (_idProducto != string.Empty)
                InitalizeMembersComboDet();

        }

        private void InitalizeMembersComboDet()
        {
            this.InitalizeMembers();

            rowComboDetListaDePrecios = tsh_CombosDetListasDePrecios.GetByPk(rowComboDet.IdProducto, rowComboDet.Ordinal, _idListaDePrecios);
            if (rowComboDetListaDePrecios == null)
            {
                rowComboDetListaDePrecios = tsh_CombosDetListasDePrecios.GetByPk(_idProducto, rowComboDet.Ordinal, _idListaDePreciosDefault);
                _idListaDePrecios = _idListaDePreciosDefault;
            }

            _idCotizacionPrecioDeCostoRef = rowComboDet.IdCotizacionCierrePrecioDeCostoRef;
            _idMonedaPrecioDeCostoRef = rowComboDet.IdMonedaCierrePrecioDeCostoRef;
            _simboloMonedaPrecioDeCostoRef = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(_idMonedaPrecioDeCostoRef);
            CotizacionWrapper cot = new CotizacionWrapper(_idCotizacionPrecioDeCostoRef);
            if (cot.IsValid)
            {
                _idFuenteDeCambioPrecioDeCostoRef = cot.IdFuenteDeCambio;
                _valorCotizacionPrecioDeCostoRef = cot.Valor;
            }

            Cotizacion cotizacion = null;
            if (rowComboDet.IdCotizacionCierrePrecioDeVentaBruto != null && !rowComboDet.IdCotizacionCierrePrecioDeVentaBruto.Equals(string.Empty))
            {
                cotizacion = tfi_CotizacionesMonedas.GetCotizacion(rowComboDet.IdCotizacionCierrePrecioDeVentaBruto);
            }
            if (cotizacion != null)
                _coeficientecotizacion = cotizacion.Valor;
            else _coeficientecotizacion = 1;
            /*Cotizacion para el precio de Costo*/
            if (rowComboDet.IdCotizacionCierrePrecioDeCostoRef != null && !rowComboDet.IdCotizacionCierrePrecioDeCostoRef.Equals(string.Empty))
            {
                cotizacion = tfi_CotizacionesMonedas.GetCotizacion(rowComboDet.IdCotizacionCierrePrecioDeCostoRef);
            }
            if (cotizacion != null)
                _coeficientecotizacionPrecioDeCosto = cotizacion.Valor;
            else _coeficientecotizacionPrecioDeCosto = 1;

        }

        //Fin Sabrina: Tarea 1071. 20110322

        private void InitalizeMembers()
        {
            if (_idProducto != string.Empty && _idProducto != null)
            {
                rowProducto = tsh_Productos.GetByPk(_idProducto);
                rowSucursal = sy_Sucursales.GetByPk(_idSucursal, _idEmpresa);
                rowProductoSucursal = mz.erp.dataaccess.tsh_ProductosSucursales.GetByPk(_idProducto, _idSucursal, _idEmpresa);
                rowProductoAuxiliar = mz.erp.dataaccess.tsh_ProductosAuxiliares.GetByPk(IdProducto);
                rowListaDePrecios = tsh_ProductosListasDePrecios.GetByPk(_idProducto, _idListaDePrecios);

                if ((_tipoDePrecioDeCosto.Equals("Precio de Lista Proveedor") || _tipoDePrecioDeCosto.Equals("Ultima Compra Proveedor")) && _idProveedor != null && !_idProveedor.Equals(string.Empty))
                {
                    rowProveedoresProductos = mz.erp.dataaccess.tpu_ProveedoresProductos.GetByPk(_idProveedor, _idProducto);
                }
                if (rowProducto != null)
                {
                    _idCotizacionPrecioDeCostoRef = rowProducto.IdCotizacionCierrePrecioDeCostoRef;
                    _idMonedaPrecioDeCostoRef = rowProducto.IdMonedaCierrePrecioDeCostoRef;
                    _simboloMonedaPrecioDeCostoRef = mz.erp.businessrules.tfi_Monedas.GetSimboloMoneda(_idMonedaPrecioDeCostoRef);
                    CotizacionWrapper cot = new CotizacionWrapper(_idCotizacionPrecioDeCostoRef);
                    if (cot.IsValid)
                    {
                        _idFuenteDeCambioPrecioDeCostoRef = cot.IdFuenteDeCambio;
                        _valorCotizacionPrecioDeCostoRef = cot.Valor;
                    }
                }

                if (rowListaDePrecios == null)
                {
                    rowListaDePrecios = tsh_ProductosListasDePrecios.GetByPk(_idProducto, _idListaDePreciosDefault);
                    _idListaDePrecios = _idListaDePreciosDefault;
                }
                if (rowProducto != null)
                {
                    _idUnidadMedida = rowProducto.IdUnidad;
                    _idConversion = rowProducto.IdConversion;
                    Cotizacion cotizacion = null;
                    if (rowProducto.IdCotizacionCierrePrecioDeVentaBruto != null && !rowProducto.IdCotizacionCierrePrecioDeVentaBruto.Equals(string.Empty))
                    {
                        cotizacion = tfi_CotizacionesMonedas.GetCotizacion(rowProducto.IdCotizacionCierrePrecioDeVentaBruto);
                        //Cotizacion cotizacion = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(rowProducto.IdMonedaCierrePrecioDeVentaBruto,Variables.GetValueString("Contabilidad.MonedaReferencia"));
                    }
                    if (cotizacion != null)
                        _coeficientecotizacion = cotizacion.Valor;
                    else _coeficientecotizacion = 1;
                    /*Cotizacion para el precio de Costo*/
                    if (rowProducto.IdCotizacionCierrePrecioDeCostoRef != null && !rowProducto.IdCotizacionCierrePrecioDeCostoRef.Equals(string.Empty))
                    {
                        cotizacion = tfi_CotizacionesMonedas.GetCotizacion(rowProducto.IdCotizacionCierrePrecioDeCostoRef);
                        //Cotizacion cotizacion = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(rowProducto.IdMonedaCierrePrecioDeVentaBruto,Variables.GetValueString("Contabilidad.MonedaReferencia"));
                    }
                    if (cotizacion != null)
                        _coeficientecotizacionPrecioDeCosto = cotizacion.Valor;
                    else _coeficientecotizacionPrecioDeCosto = 1;
                }
                if (rowProducto == null || rowSucursal == null || rowProductoSucursal == null)
                {
                }
                else
                {
                    //System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, _idProducto );                 
                    //_impuestosNetos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas.Values, this.PrecioDeVentaNeto );
                    //_impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas.Values, this.PrecioDeVentaBruto );
                }
                if (this.CodigoSecundario != null && this.CodigoSecundario != string.Empty)
                    _codigosSecundarios.Add(this.CodigoSecundario);
                if (rowProductoAuxiliar != null)
                {
                    if (rowProductoAuxiliar.CodigoSecundario1 != null && rowProductoAuxiliar.CodigoSecundario1 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario1);
                    if (rowProductoAuxiliar.CodigoSecundario2 != null && rowProductoAuxiliar.CodigoSecundario2 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario2);
                    if (rowProductoAuxiliar.CodigoSecundario3 != null && rowProductoAuxiliar.CodigoSecundario3 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario3);
                    if (rowProductoAuxiliar.CodigoSecundario4 != null && rowProductoAuxiliar.CodigoSecundario4 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario4);
                    if (rowProductoAuxiliar.CodigoSecundario5 != null && rowProductoAuxiliar.CodigoSecundario5 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario5);
                    if (rowProductoAuxiliar.CodigoSecundario6 != null && rowProductoAuxiliar.CodigoSecundario6 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario6);
                    if (rowProductoAuxiliar.CodigoSecundario7 != null && rowProductoAuxiliar.CodigoSecundario7 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario7);
                    if (rowProductoAuxiliar.CodigoSecundario8 != null && rowProductoAuxiliar.CodigoSecundario8 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario8);
                    if (rowProductoAuxiliar.CodigoSecundario9 != null && rowProductoAuxiliar.CodigoSecundario9 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario9);
                    if (rowProductoAuxiliar.CodigoSecundario10 != null && rowProductoAuxiliar.CodigoSecundario10 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario10);
                    if (rowProductoAuxiliar.CodigoSecundario11 != null && rowProductoAuxiliar.CodigoSecundario11 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario11);
                    if (rowProductoAuxiliar.CodigoSecundario12 != null && rowProductoAuxiliar.CodigoSecundario12 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario12);
                    if (rowProductoAuxiliar.CodigoSecundario13 != null && rowProductoAuxiliar.CodigoSecundario13 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario13);
                    if (rowProductoAuxiliar.CodigoSecundario14 != null && rowProductoAuxiliar.CodigoSecundario14 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario14);
                    if (rowProductoAuxiliar.CodigoSecundario15 != null && rowProductoAuxiliar.CodigoSecundario15 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario15);
                    if (rowProductoAuxiliar.CodigoSecundario16 != null && rowProductoAuxiliar.CodigoSecundario16 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario16);
                    if (rowProductoAuxiliar.CodigoSecundario17 != null && rowProductoAuxiliar.CodigoSecundario17 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario17);
                    if (rowProductoAuxiliar.CodigoSecundario18 != null && rowProductoAuxiliar.CodigoSecundario18 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario18);
                    if (rowProductoAuxiliar.CodigoSecundario19 != null && rowProductoAuxiliar.CodigoSecundario19 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario19);
                    if (rowProductoAuxiliar.CodigoSecundario20 != null && rowProductoAuxiliar.CodigoSecundario20 != string.Empty)
                        _codigosSecundarios.Add(rowProductoAuxiliar.CodigoSecundario20);
                }
                /* Silvina 20111104 - Tarea 0000222 */
                if (_jerarquiaProductos.Equals(_campoAuxiliar6Productos))
                {
                    /* Silvina 20111226 - Tarea 0000241 */
                    string _separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
                    if (string.IsNullOrEmpty(_separador))
                        _separador = ",";
                    ArrayList jer = new ArrayList();
                    ArrayList CampoAuxiliar6BDList = mz.erp.systemframework.Util.Parse(rowProducto.CampoAuxiliar6, _separador);
                    /* Fin Silvina 20111226 - Tarea 0000241 */
                    foreach (string aux in CampoAuxiliar6BDList)
                    {
                        if (aux != null && aux != string.Empty)
                        {
                            DataRow row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetPkByDescripcion(aux);
                            if (row != null)
                                jer.Add(row["Jerarquia"].ToString());
                        }
                    }
                    _jerarquiaCategorias = systemframework.Util.PackString(jer);
                }
                else
                {
                    dataProductoJerarquia = tsh_AgrupProductos.GetList(_idProducto, string.Empty);
                    _jerarquiaCategorias = string.Empty;
                    foreach (tsh_AgrupProductosDataset.tsh_AgrupProductosRow row in dataProductoJerarquia.tsh_AgrupProductos.Rows)
                    {
                        if (row["Jerarquia"].ToString().Contains(_jerarquiaProductos))
                            _jerarquiaCategorias = row["Jerarquia"].ToString();
                    }
                }
                /* Fin Silvina 20111104 - Tarea 0000222 */
            }

        }

        #endregion

        # region Region Estatica
        public Productos()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        public static decimal ObtenerPrecioDeVentaBruto(string IdProducto, long IdSucursal)
        {
            return ObtenerPrecioDeVentaBruto(IdProducto, IdSucursal, Security.IdEmpresa);
        }

        public static decimal ObtenerPrecioDeVentaBruto(string IdProducto)
        {
            return ObtenerPrecioDeVentaBruto(IdProducto, Security.IdSucursal, Security.IdEmpresa);
        }

        private static tsh_ProductosDataset.tsh_ProductosRow GetProducto(string IdProducto)
        {
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = tsh_Productos.GetByPk(IdProducto);
            if (rowProducto == null)
            {
                /*System.Exception e = new Exception( "El producto no existe ");
                throw e;*/
                return null;
            }
            else
            {
                return rowProducto;
            }

        }
        private static sy_SucursalesDataset.sy_SucursalesRow GetSucursal(long IdSucursal, long IdEmpresa)
        {
            sy_SucursalesDataset.sy_SucursalesRow rowSucursal = sy_Sucursales.GetByPk(IdSucursal, IdEmpresa);
            if (rowSucursal == null)
            {
                System.Exception e = new Exception("La sucursal no existe ");
                throw e;
            }
            else
            {
                return rowSucursal;
            }


        }
        public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow GetProductoSucursal(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowSucursales = mz.erp.dataaccess.tsh_ProductosSucursales.GetByPk(IdProducto, IdSucursal, IdEmpresa);
            if (rowSucursales == null)
            {
                System.Exception e = new Exception("El producto no esta definido para la sucursal");
                throw e;
            }
            else
            {
                return rowSucursales;
            }
        }

        public static System.Data.DataSet GetStockDataset(string IdProducto)
        {
            string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();
            string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();
            return GetStockSucursal(IdProducto, IdVisualizacionDeStock, IdEstadoDeStock);
        }

        public static System.Data.DataSet GetStockSucursal(string IdProducto, string IdVisualizacionDeStock, string IdEstadoDeStock)
        {
            return businessrules.tlg_Stock.GetStockSucursales(IdProducto, IdVisualizacionDeStock, IdEstadoDeStock);
        }

        public static decimal ObtenerPrecioDeVentaBrutoMoendaPrecioDeVentaBruto(decimal PrecioDeVentaBruto, string IdMonedaCierrePrecioDeVentaBruto, long IdSucursal, long IdEmpresa)
        {
            sy_SucursalesDataset.sy_SucursalesRow _rowSucursal = GetSucursal(IdSucursal, IdEmpresa);
            /*
            string _idMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia");
            Cotizacion cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion( IdMonedaCierrePrecioDeVentaBruto, _idMonedaReferencia) ;
            decimal _cotizacion = 1;
            if(cotizacion != null)
                _cotizacion = cotizacion.Valor;
            PrecioDeVentaBruto = PrecioDeVentaBruto * _cotizacion;
            */
            decimal _incrementoProducto = PrecioDeVentaBruto * (_rowSucursal.BonificacionRecargoProductos / 100);
            decimal _precioDeVentaBrutoSucursal = PrecioDeVentaBruto + _incrementoProducto;

            return _precioDeVentaBrutoSucursal;

        }

        public static decimal ObtenerPrecioDeVentaBruto(decimal PrecioDeVentaBruto, string IdMonedaCierrePrecioDeVentaBruto, long IdSucursal, long IdEmpresa)
        {
            sy_SucursalesDataset.sy_SucursalesRow _rowSucursal = GetSucursal(IdSucursal, IdEmpresa);
            string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            Cotizacion cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(IdMonedaCierrePrecioDeVentaBruto, _idMonedaReferencia);
            decimal _cotizacion = 1;
            if (cotizacion != null)
                _cotizacion = cotizacion.Valor;
            PrecioDeVentaBruto = PrecioDeVentaBruto * _cotizacion;

            decimal _incrementoProducto = PrecioDeVentaBruto * (_rowSucursal.BonificacionRecargoProductos / 100);
            decimal _precioDeVentaBrutoSucursal = PrecioDeVentaBruto + _incrementoProducto;

            return _precioDeVentaBrutoSucursal;

        }

        public static decimal ObtenerPrecioDeVentaBruto(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            sy_SucursalesDataset.sy_SucursalesRow _rowSucursal = GetSucursal(IdSucursal, IdEmpresa);
            tsh_ProductosDataset.tsh_ProductosRow _rowProducto = GetProducto(IdProducto);
            string _idMonedaCierrePrecioDeVentaBruto = string.Empty;
            decimal _precioDeVentaBruto = 0;
            if (_rowProducto != null)
            {
                _idMonedaCierrePrecioDeVentaBruto = _rowProducto.IdMonedaCierrePrecioDeVentaBruto;
                _precioDeVentaBruto = _rowProducto.PrecioDeVentaBruto;
            }
            string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            Cotizacion cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(_idMonedaCierrePrecioDeVentaBruto, _idMonedaReferencia);

            decimal _cotizacion = 1;
            if (cotizacion != null)
                _cotizacion = cotizacion.Valor;
            _precioDeVentaBruto = _precioDeVentaBruto * _cotizacion;

            decimal _incrementoProducto = _precioDeVentaBruto * (_rowSucursal.BonificacionRecargoProductos / 100);
            decimal _precioDeVentaBrutoSucursal = _precioDeVentaBruto + _incrementoProducto;

            return _precioDeVentaBrutoSucursal;

        }
        public static decimal ObtenerCosto(string IdProducto)
        {
            return ObtenerCosto(IdProducto, Security.IdSucursal, Security.IdEmpresa);
        }
        public static decimal ObtenerCosto(string IdProducto, long IdSucursal)
        {
            return ObtenerCosto(IdProducto, IdSucursal, Security.IdEmpresa);
        }
        public static decimal ObtenerCosto(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowProductoSucursal = GetProductoSucursal(IdProducto, IdSucursal, IdEmpresa);
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = GetProducto(IdProducto);
            sy_SucursalesDataset.sy_SucursalesRow rowSucursal = GetSucursal(IdSucursal, IdEmpresa);

            decimal precioDeCostoProducto = rowProducto.PrecioDeCostoRef;

            string idMonedaCierrePrecioDeCostoRef = string.Empty;
            if (rowProducto != null)
            {
                idMonedaCierrePrecioDeCostoRef = rowProducto.IdMonedaCierrePrecioDeCostoRef;
            }
            string idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            Cotizacion cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(idMonedaCierrePrecioDeCostoRef, idMonedaReferencia);
            decimal _cotizacion = 1;
            if (cotizacion != null)
                _cotizacion = cotizacion.Valor;
            precioDeCostoProducto = precioDeCostoProducto * _cotizacion;
            decimal cargoFijoProducto = rowSucursal.CargoFijoProductos;
            decimal incrementoDeCosto = rowProductoSucursal.IncrementoDeCosto;
            decimal montoDeIncremento = precioDeCostoProducto * incrementoDeCosto / 100;
            return (precioDeCostoProducto + montoDeIncremento + cargoFijoProducto);
        }

        public static decimal ObtenerPrecioDeVentaNeto(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowProductoSucursal = GetProductoSucursal(IdProducto, IdSucursal, IdEmpresa);
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = GetProducto(IdProducto);
            decimal precioDeCosto = ObtenerCosto(IdProducto, IdSucursal, IdEmpresa);

            //Si el margen especifico para la sucursal no está definido obtengo el precio a partir del precio margen
            //definido en la central para el producto
            decimal precioDeVentaNeto = 0;
            if (false/*rowProductoSucursal.MAC != 0*/)
            {
                precioDeVentaNeto = (precioDeCosto * rowProductoSucursal.MAC / 100) + precioDeCosto;
            }
            else
            {
                precioDeVentaNeto = (precioDeCosto * rowProducto.MAC / 100) + precioDeCosto;
            }

            return precioDeVentaNeto;
        }
        public static decimal ObtenerMaximoDescuento(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            decimal precioDeVentaBruto = ObtenerPrecioDeVentaBruto(IdProducto, IdSucursal, IdEmpresa);
            decimal precioDeVentaNeto = ObtenerPrecioDeVentaNeto(IdProducto, IdSucursal, IdEmpresa);
            return (precioDeVentaBruto - precioDeVentaNeto);
        }

        public static string ObtenerDescripcion(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = GetProducto(IdProducto);
            return rowProducto.Descripcion;
        }

        public static string ObtenerDescripcionLarga(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = GetProducto(IdProducto);
            return rowProducto.DescripcionLarga;
        }
        public static string ObtenerDescripcionCorta(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            tsh_ProductosDataset.tsh_ProductosRow rowProducto = GetProducto(IdProducto);
            return rowProducto.DescripcionCorta;
        }

        public static decimal ObtenerPrecioBrutoConImpuestos(string IdProducto, long IdSucursal, long IdEmpresa)
        {
            decimal _precioDeVentaBruto = ObtenerPrecioDeVentaBruto(IdProducto, IdSucursal, IdEmpresa);
            System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, IdProducto);
            decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, ObtenerPrecioDeVentaBruto(IdProducto, IdSucursal));
            return _precioDeVentaBruto + _impuestosBrutos;
        }


        public static decimal ObtenerPrecioBrutoConImpuestos(decimal PrecioDeVentaBruto, string IdMonedaPrecioDeVentaBruto, long IdSucursal, long IdEmpresa, ArrayList ImpuestosAAplicar)
        {
            decimal _precioDeVentaBruto = ObtenerPrecioDeVentaBruto(PrecioDeVentaBruto, IdMonedaPrecioDeVentaBruto, IdSucursal, IdEmpresa);
            System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(ImpuestosAAplicar);
            decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeVentaBruto);
            return _precioDeVentaBruto + _impuestosBrutos;
        }


        public static decimal ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(decimal PrecioDeVentaBruto, string IdMonedaPrecioDeVentaBruto, long IdSucursal, long IdEmpresa, ArrayList ImpuestosAAplicar)
        {
            decimal _precioDeVentaBruto = ObtenerPrecioDeVentaBrutoMoendaPrecioDeVentaBruto(PrecioDeVentaBruto, IdMonedaPrecioDeVentaBruto, IdSucursal, IdEmpresa);
            System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(ImpuestosAAplicar);
            decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeVentaBruto);
            return _precioDeVentaBruto + _impuestosBrutos;
        }



        #endregion

    }
    public sealed class Producto
    {

        #region Variables privadas

        string _idProducto = string.Empty;
        string _idProveedor = string.Empty;
        string _codigoProducto = string.Empty;
        string _descripcion = string.Empty;
        string _descripcionCorta = string.Empty;
        string _descripcionLarga = string.Empty;

        private string _simboloMonedaOrigen = string.Empty;
        private string _simboloMonedaDescuentoMaximo = string.Empty;
        private string _simboloMonedaPrecioDeVentaNeto = string.Empty;
        private string _simboloMonedaPrecioDeLista = string.Empty;

        private string _idMonedaPrecioDeVentaNeto = string.Empty;
        private string _idMonedaPrecioDeCosto = string.Empty;
        private string _idMonedaReferencia = string.Empty;

        private string _campoAuxiliar1 = string.Empty;
        private string _campoAuxiliar2 = string.Empty;
        private string _campoAuxiliar3 = string.Empty;
        private string _campoAuxiliar4 = string.Empty;
        private string _campoAuxiliar5 = string.Empty;
        private string _observaciones = string.Empty;

        decimal _stock = 0;
        decimal _precioDeCosto = 0;
        decimal _precioDeCostoEnBD = 0;
        decimal _MAC = 0;
        decimal _precioDeVentaNeto = 0;
        decimal _porcentajeMaximoDescuento = 0;
        decimal _maximoDescuento = 0;
        decimal _precioDeLista = 0;
        decimal _precioDeListaEnBD = 0;
        decimal _precioDeListaConImpuestos = 0;
        DateTime _fechaUltimaModificacionPrecioDeCosto;
        DateTime _fechaUltimaModificacionPrecioDeVenta;


        decimal _cantidad = 0;
        decimal _precioDeCostoAnterior = 0;
        decimal _precioDeCostoAnteriorMonedaProducto = 0;
        decimal _precioDeCostoMonedaProducto = 0;
        private decimal _precioCostoMonedaProveedor = 0;
        private decimal _precioCostoMonedaReferencia = 0;
        private decimal _precioCostoPromedioPonderado = 0;
        //Sabrina: tarea 56
        private decimal _precioDeCostoReposicion = 0;
        private decimal _precioDeCostoReposicionAnterior = 0;
        private bool _usaPrecioDeCostoReposicion = false;
        private decimal _precioCostoPromedioPonderadoEnBD = 0;
        private decimal _precioDeCostoDirecto = 0;


        /*
        private decimal _coeficiente1 = 0;
        private decimal _coeficiente2 = 0;
        private decimal _coeficiente3 = 0;
        private decimal _coeficiente4 = 0;
        private decimal _coeficiente5 = 0;
        private decimal _coeficiente6 = 0;
        private decimal _coeficiente7 = 0;
        private decimal _coeficiente8 = 0;
        private decimal _coeficiente9 = 0;
        private decimal _coeficiente10 = 0;
        */

        //private decimal _precioDeCostoConvertidoMonedaPrecioDeVentaNeto = 0;
        private ArrayList _impuestos = new ArrayList();
        private long _idEmpresa = 0;
        private long _idSucursal = 0;
        private SucursalProducto _sucursalProducto;
        private string _taskName = string.Empty;
        private bool _coeficientesPorVariable = false;
        //Sabrina: tarea 56
        //private decimal  _costosIndirectos = 0;
        private decimal _precioDeCostoIndirecto = 0;
        //private decimal _costoIndirecto1 = 0;
        //private decimal _costoIndirecto2 = 0;




        /*Es la cotizacion q viene en la factura del proveedor*/
        private Cotizacion _cotizacionProveedor;


        private CotizacionWrapper _cotizacionProductoPrecioDeCosto;
        private CotizacionWrapper _cotizacionProductoPrecioDeVenta;

        private bool _calculaPPP = true;

        private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;


        /*Esta propiedad se ha creado en esta clase por cuestiones de tiempo.
         * Esta propiedad es para la UI asociada a esta clase, entonces la solucion ideal seria crear una clase 
         * en controller q sea un wrapper de esta clase. Esta clase wrapper deberia poseer todas las propiedades
         * que son relevantes para la parte grafica de esta clase.
         * 
         * */
        private bool _selected = false;


        private string _codigoSecundario = string.Empty;



        private ListaDePrecios _listaDePrecios;

        private ListaDePreciosProveedores _listaDePreciosProveedores;

        private string _idProveedorDefault = string.Empty;

        private string _idProveedorDefaultAnterior = "null";

        private bool _precioDeVentaAfectaMac = false;

        OrdenDeCompraItem _ordenDeCompraItem = null;

        private decimal _coeficientePVNaPVB = 0;

        private CostosIndirectos _coeficientesIndirectos;

        //Sabrina Tarea 77
        private string _estado = string.Empty;
        private string _codigoProveedor = string.Empty;

        private bool _activo = true;

        private ProductosJerarquias _jerarquias;

        //Sabrina: Tarea 1061. 20110310
        private bool _esCombo = false;
        private ArrayList _detalleCombo;
        //Fin Sabrina: Tarea 1061. 20110310
        #endregion

        #region Constructores

        /*German 20090325*/
        public Producto(bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            /*Fin German 20090325*/
            _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            /*
            _coeficiente1 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente1");
            _coeficiente2 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente2");
            _coeficiente3 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente3");
            _coeficiente4 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente4");
            _coeficiente5 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente5");
            */
            _idMonedaPrecioDeCosto = _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
            _idMonedaPrecioDeVentaNeto = _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");


            /*DEPRECATED a partir de la version 1.6.13*/
            //_calculaPPP = Variables.GetValueBool("Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);


            _coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
            //Sabrina 20100706 - Tarea 790
            _listaDePrecios = new ListaDePrecios(this, "NEW", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
            //Fin Sabrina 20100706 - Tarea 790
            _listaDePreciosProveedores = new ListaDePreciosProveedores(this.IdProducto);
            _coeficientesIndirectos = new CostosIndirectos(this.IdProducto, "NEW");

        }

        /*German 20090325*/
        public Producto(bool CargaBasica, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            /*Fin German 20090325*/


            //_cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            //_cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            //_idMonedaPrecioDeCosto = _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
            //_idMonedaPrecioDeVentaNeto = _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");


            /*No va mas a partir de la version 1.6.13*/
            //_calculaPPP = Variables.GetValueBool("Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);



            _coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
        }


        private void CargarDatosAuxiliares()
        {
            // Este metodo esta deprecated.
            // Ahora los coeficientes se levantan desde la Clase CostosIndirectos.

            /*if(_coeficientesPorVariable)
            {
                _coeficiente1 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente1");
                _coeficiente2 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente2");
                _coeficiente3 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente3");
                _coeficiente4 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente4");
                _coeficiente5 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente5");
            }
            else
            {
                tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(_idProducto);
                if(row != null)
                {
                    _coeficiente1 = Convert.ToDecimal(row["Coeficiente1"]);
                    _coeficiente2 = Convert.ToDecimal(row["Coeficiente2"]);
                    _coeficiente3 = Convert.ToDecimal(row["Coeficiente3"]);
                    _coeficiente4 = Convert.ToDecimal(row["Coeficiente4"]);
                    _coeficiente5 = Convert.ToDecimal(row["Coeficiente5"]);
                }
            }*/
        }

        private void CargarCoeficientesIndirectos()
        {
            this.CoeficientesIndirectos = new CostosIndirectos(this.IdProducto, "EDIT");
            if (this.CoeficientesIndirectos.Count == 0)
                this.CoeficientesIndirectos = new CostosIndirectos(this.IdProducto, "NEW");
        }


        public void CargarDatosPrincipales(DataRow row)
        {
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            _taskName = string.Empty;
            _cantidad = 1;
            _idProducto = Convert.ToString(row["IdProducto"]);
            _codigoProducto = Convert.ToString(row["Codigo"]);
            _codigoSecundario = Convert.ToString(row["CodigoSecundario"]);
            _descripcion = Convert.ToString(row["Descripcion"]);
            _descripcionCorta = Convert.ToString(row["DescripcionCorta"]);
            _descripcionLarga = Convert.ToString(row["DescripcionLarga"]);
            _MAC = Convert.ToDecimal(row["MAC"]);
            _precioDeCosto = Convert.ToDecimal(row["PrecioDeCostoRef"]);
            _precioDeCostoEnBD = Convert.ToDecimal(row["PrecioDeCostoRef"]);
            _precioDeCostoAnterior = Convert.ToDecimal(row["PrecioDeCostoDirecto"]);
            //Sabrina: tarea 56
            _precioDeCostoReposicion = Convert.ToDecimal(row["PrecioDeCostoReposicion"]);
            _precioDeCostoReposicionAnterior = _precioDeCostoReposicion;
            _precioCostoPromedioPonderado = Convert.ToDecimal(row["PrecioDeCostoPromedioPonderado"]);
            _usaPrecioDeCostoReposicion = Convert.ToBoolean(row["UsaPrecioDeCostoReposicion"]);
            _precioCostoPromedioPonderadoEnBD = Convert.ToDecimal(row["PrecioDeCostoPromedioPonderado"]);
            _precioDeCostoDirecto = Convert.ToDecimal(row["PrecioDeCostoDirecto"]);
            //_precioCostoPromedioPonderado = Convert.ToDecimal(row["PrecioDeCostoDirecto"]);
            _precioDeVentaNeto = Convert.ToDecimal(row["PrecioDeVentaNeto"]);
            _porcentajeMaximoDescuento = Convert.ToDecimal(row["MaxDescuentoPorcentual"]);
            _maximoDescuento = Convert.ToDecimal(row["MaxDescuento"]);
            //Sabrina: tarea 56
            //_costosIndirectos = Convert.ToDecimal(row["PrecioDeCostoIndirecto"]);
            _precioDeCostoIndirecto = Convert.ToDecimal(row["PrecioDeCostoIndirecto"]);
            //INICIO: Campos q usa mucho el usuario, cuando quiere poner algo del producto q no esta contemplado
            _campoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
            _campoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
            _campoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
            _campoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
            _campoAuxiliar5 = Convert.ToString(row["CampoAuxiliar5"]);
            _observaciones = Convert.ToString(row["Observaciones"]);
            //FIN 
            _precioDeLista = Convert.ToDecimal(row["PrecioDeVentaBruto"]);
            _precioDeListaEnBD = Convert.ToDecimal(row["PrecioDeVentaBruto"]);
            _idMonedaPrecioDeVentaNeto = Convert.ToString(row["IdMonedaCierrePrecioDeVentaNeto"]);
            _idMonedaPrecioDeCosto = Convert.ToString(row["IdMonedaCierrePrecioDeCostoRef"]);
            _simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeCosto).Simbolo;
            _simboloMonedaPrecioDeVentaNeto = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeVentaNeto).Simbolo;
            _simboloMonedaPrecioDeLista = _simboloMonedaPrecioDeVentaNeto;
            _simboloMonedaDescuentoMaximo = _simboloMonedaPrecioDeVentaNeto;
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            if (Convert.ToString(row["IdCotizacionCierrePrecioDeCostoRef"]) != null)
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Convert.ToString(row["IdCotizacionCierrePrecioDeCostoRef"]));
            if (Convert.ToString(row["IdCotizacionCierrePrecioDeVentaNeto"]) != null)
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Convert.ToString(row["IdCotizacionCierrePrecioDeVentaNeto"]));
            if (Convert.ToString(row["IdProveedorDefault"]) != null)
                _idProveedorDefault = Convert.ToString(row["IdProveedorDefault"]);
            _activo = Convert.ToBoolean(row["Activo"]);
            //Sabrina: Tarea 1061. 20110310
            _esCombo = Convert.ToBoolean(row["EsCombo"]);
            //Fin Sabrina: Tarea 1061. 20110310
            CargarCoeficientesIndirectos();


        }

        //German 20090522
        private void CargarProveedor()
        {
            if (_listaDePreciosProveedores.Items.Count > 0)
            {
                ListaDePreciosProveedoresItem item = _listaDePreciosProveedores.getListaDePreciosProveedoresItem(IdProveedor);
                //German 20090521
                //Se corrige para que en aquellos clientes que no usan lista de precio de proveedoresy que no usan OC, el sistema tome como valor de la compra el Precio de Costo Directo
                //En realidad deberia tomar el precio de reposicion pero primero se deb modificar la pantalla de comprobante de compra para que en el combo aparezca Precio de Costo Reposicion
                //en lugar de Precio de Costo, de forma que se congruente. El problema es que al tomar el precio de costo directo puedo estar tomando el precio de costo PP para la compra si elñ producto tiene 
                //que usa precio de costo promedio ponderado para formar el precio de costo directo.
                //_precioDeCostoMonedaProducto = _usaPrecioDeListaProveedor? item.PrecioDeCostoFinal * item.ValorCotizacionProveedor /_cotizacionProductoPrecioDeCosto.Valor :item.PrecioDeCostoUltimaCompra;
                _precioDeCostoMonedaProducto = _usaPrecioDeListaProveedor ? item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / _cotizacionProductoPrecioDeCosto.Valor : this.PrecioDeCostoDirecto;
                //Fin German 20090521
            }
            else
                _precioDeCostoMonedaProducto = this.PrecioDeCostoDirecto;

            _precioDeCostoAnteriorMonedaProducto = _precioDeCostoMonedaProducto;
            if ((_cotizacionProductoPrecioDeCosto.IdMonedaOrigen != _cotizacionProveedor.IdMonedaOrigen)
                || (_cotizacionProductoPrecioDeCosto.IdMonedaOrigen == _cotizacionProveedor.IdMonedaOrigen && _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio != _cotizacionProveedor.IdFuenteDeCambio))
                PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProveedor.Valor;
            else PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto;

        }
        //Fin German 20090522

        /*
        private void CargarProveedor(tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP )
        {
            if(rowPP != null)
            {
                _precioDeCostoMonedaProducto = _usaPrecioDeListaProveedor?rowPP.PrecioDeCostoFinal:rowPP.PrecioDeCostoUltimaCompra;
                _precioDeCostoAnteriorMonedaProducto =  _precioDeCostoMonedaProducto;
                if((_cotizacionProductoPrecioDeCosto.IdMonedaOrigen != _cotizacionProveedor.IdMonedaOrigen)
                    || (_cotizacionProductoPrecioDeCosto.IdMonedaOrigen == _cotizacionProveedor.IdMonedaOrigen && _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio != _cotizacionProveedor.IdFuenteDeCambio)) 
                    PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProveedor.Valor;
                else PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto;
            }
        }
        */


        //Sabrina 20100615 - Tarea 764
        public void CargarListasDePrecios(string Estado)
        {
            //Sabrina 20100706 - Tarea 790
            _listaDePrecios = new ListaDePrecios(this, Estado, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
            //Fin Sabrina 20100706 - Tarea 790
        }
        //Fin Sabrina 20100615 - Tarea 764

        private void CargarStock(string IdVisualizacionDeStock)
        {
            if (IdVisualizacionDeStock != null && !IdVisualizacionDeStock.Equals(string.Empty))
            {
                VisualizacionDeStock vs = new VisualizacionDeStock(IdVisualizacionDeStock);
                _stock = vs.CalcularStock(this._idProducto);
            }
            else _stock = 0;
            if (_stock < 0) _stock = 0;


        }

        private void CargarDatosPrincipales(tsh_ProductosDataset.tsh_ProductosRow row, decimal Cantidad, string TaskName)
        {
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            _taskName = TaskName;
            _cantidad = Cantidad;
            _idProducto = row.IdProducto;
            _codigoProducto = row.Codigo;
            _codigoSecundario = row.CodigoSecundario;
            _descripcion = row.Descripcion;
            _descripcionCorta = row.DescripcionCorta;
            _descripcionLarga = row.DescripcionLarga;
            _MAC = row.MAC;
            _precioDeCosto = row.PrecioDeCostoRef;
            _precioDeCostoEnBD = row.PrecioDeCostoRef;
            _precioDeCostoAnterior = row.PrecioDeCostoDirecto;
            //Sabrina: tarea 56
            _precioDeCostoReposicion = row.PrecioDeCostoReposicion;
            _precioDeCostoReposicionAnterior = _precioDeCostoReposicion;
            _precioCostoPromedioPonderado = row.PrecioDeCostoPromedioPonderado;
            _usaPrecioDeCostoReposicion = row.UsaPrecioDeCostoReposicion;
            _precioCostoPromedioPonderadoEnBD = row.PrecioDeCostoPromedioPonderado;
            _precioDeCostoDirecto = row.PrecioDeCostoDirecto;
            //_precioCostoPromedioPonderado = row.PrecioDeCostoDirecto;
            _precioDeVentaNeto = row.PrecioDeVentaNeto;
            _porcentajeMaximoDescuento = row.MaxDescuentoPorcentual;
            _maximoDescuento = row.MaxDescuento;
            //Sabrina: tarea 56
            //_costosIndirectos = row.PrecioDeCostoIndirecto;
            _precioDeCostoIndirecto = row.PrecioDeCostoIndirecto;
            //INICIO: Campos q usa mucho el usuario, cuando quiere poner algo del producto q no esta contemplado
            _campoAuxiliar1 = row.CampoAuxiliar1;
            _campoAuxiliar2 = row.CampoAuxiliar2;
            _campoAuxiliar3 = row.CampoAuxiliar3;
            _campoAuxiliar4 = row.CampoAuxiliar4;
            _campoAuxiliar5 = row.CampoAuxiliar5;
            _observaciones = row.Observaciones;
            //FIN 
            _precioDeLista = row.PrecioDeVentaBruto;
            _precioDeListaEnBD = row.PrecioDeVentaBruto;
            _idMonedaPrecioDeVentaNeto = row.IdMonedaCierrePrecioDeVentaNeto;
            _idMonedaPrecioDeCosto = row.IdMonedaCierrePrecioDeCostoRef;
            _simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeCosto).Simbolo;
            _simboloMonedaPrecioDeVentaNeto = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeVentaNeto).Simbolo;
            _simboloMonedaPrecioDeLista = _simboloMonedaPrecioDeVentaNeto;
            _simboloMonedaDescuentoMaximo = _simboloMonedaPrecioDeVentaNeto;
            _idSucursal = Security.IdSucursal;
            _idEmpresa = Security.IdEmpresa;
            if (row.IdCotizacionCierrePrecioDeCostoRef != null)
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeCostoRef);
            if (row.IdCotizacionCierrePrecioDeVentaNeto != null)
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeVentaNeto);
            if (row.IdProveedorDefault != null)
                _idProveedorDefault = row.IdProveedorDefault;
            _activo = row.Activo;
            //Sabrina: Tarea 1061. 20110310
            _esCombo = row.EsCombo;
            //Fin Sabrina: Tarea 1061. 20110310
        }


        /*German 20090325*/
        public Producto(string IdProducto, string IdVisualizacionDeStock, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
            : this(CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;

            /*Fin German 20090325*/
            tsh_ProductosDataset.tsh_ProductosRow row = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
            if (row != null)
            {
                CargarDatosPrincipales(row, 1, string.Empty);
                CargarDatosAuxiliares();
                // Matias - Tarea 26 (20081031)
                CargarCoeficientesIndirectos();
                // ------
                GenerateImpuestosProductos();
                GenerateSucursalesImpuestos();
                CargarStock(IdVisualizacionDeStock);
                //Sabrina 20100706 - Tarea 790
                _listaDePrecios = new ListaDePrecios(this, "EDIT", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                //Fin Sabrina 20100706 - Tarea 790
                _listaDePreciosProveedores = new ListaDePreciosProveedores(this.IdProducto);

            }


        }




        //Sabrina Tarea 77
        public Producto(string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string IdVisualizacionDeStock, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, bool UsaPrecioDeCostoReposicion)
            : this(CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            _usaPrecioDeCostoReposicion = UsaPrecioDeCostoReposicion;

            _codigoProducto = Codigo;
            _codigoSecundario = CodigoSecundario;
            _codigoProveedor = CodigoProveedor;
            _descripcion = Descripcion;
            _estado = "NEW";
            _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));

            _idMonedaPrecioDeCosto = _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
            _idMonedaPrecioDeVentaNeto = _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            _coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
            //Sabrina 20100706 - Tarea 790
            _listaDePrecios = new ListaDePrecios(this, "NEW", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
            //Fin Sabrina 20100706 - Tarea 790
            _listaDePreciosProveedores = new ListaDePreciosProveedores(this.IdProducto);
            _coeficientesIndirectos = new CostosIndirectos(this.IdProducto, "NEW");
        }

        public Producto(string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string IdVisualizacionDeStock, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, bool UsaPrecioDeCostoReposicion)
            : this(CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            _usaPrecioDeCostoReposicion = UsaPrecioDeCostoReposicion;

            _codigoProducto = Codigo;
            _codigoSecundario = CodigoSecundario;
            _codigoProveedor = CodigoProveedor;
            _descripcion = Descripcion;
            _campoAuxiliar1 = CampoAuxiliar1;
            _campoAuxiliar2 = CampoAuxiliar2;
            _campoAuxiliar3 = CampoAuxiliar3;
            _campoAuxiliar4 = CampoAuxiliar4;
            _campoAuxiliar5 = CampoAuxiliar5;
            _estado = "NEW";
            _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));

            _idMonedaPrecioDeCosto = _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
            _idMonedaPrecioDeVentaNeto = _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
            _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            _coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
            //Sabrina 20100706 - Tarea 790
            _listaDePrecios = new ListaDePrecios(this, "NEW", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
            //Fin Sabrina 20100706 - Tarea 790
            _coeficientesIndirectos = new CostosIndirectos(this.IdProducto, "NEW");
        }

        /*
        =======

		
                //Sabrina Tarea 77
                public Producto(string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string IdVisualizacionDeStock, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, bool UsaPrecioDeCostoReposicion):this(CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    _calculaPPP = CalculaPPP;
                    _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
                    _usaPrecioDeCostoReposicion = UsaPrecioDeCostoReposicion;

                    _codigoProducto = Codigo;
                    _codigoSecundario = CodigoSecundario;
                    _codigoProveedor = CodigoProveedor;
                    _descripcion = Descripcion;
                    _estado = "NEW";
                    _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
                    _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));

                    _idMonedaPrecioDeCosto = _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
                    _idMonedaPrecioDeVentaNeto = _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
                    _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
                    _coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
                    _listaDePrecios = new ListaDePrecios(this, "NEW");
                    _listaDePreciosProveedores = new ListaDePreciosProveedores(this.IdProducto);
                    _coeficientesIndirectos = new CostosIndirectos(this.IdProducto, "NEW");
                }


        */

        private bool _usaPrecioDeListaProveedor = false;

        /*German 20090325*/
        public Producto(string IdProducto, string IdVisualizacionDeStock, decimal Cantidad, string IdProveedor, string taskName, Cotizacion cotizacionProveedor, bool UsaPrecioListaProveedor, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
            : this(CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            /*Fin German 20090325*/
            tsh_ProductosDataset.tsh_ProductosRow row = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
            if (row != null)
            {
                CargarDatosPrincipales(row, Cantidad, taskName);
                CargarDatosAuxiliares();
                // Matias - Tarea 26 (20081031)
                CargarCoeficientesIndirectos();
                // ------
                GenerateImpuestosProductos();
                GenerateSucursalesImpuestos();
                CargarStock(IdVisualizacionDeStock);
                //Sabrina 20100706 - Tarea 790
                _listaDePrecios = new ListaDePrecios(this, "EDIT", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                //Fin Sabrina 20100706 - Tarea 790
                _idProveedor = IdProveedor;
                _cotizacionProveedor = cotizacionProveedor;
                _usaPrecioDeListaProveedor = UsaPrecioListaProveedor;
                tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = mz.erp.businessrules.tpu_ProveedoresProductos.GetByPk(this._idProveedor, this._idProducto);
                _listaDePreciosProveedores = new ListaDePreciosProveedores(rowPP);
                CargarProveedor();

            }
        }

        /*German 20090325*/
        public Producto(string IdProducto, string IdVisualizacionDeStock, decimal Cantidad, string IdProveedor, string taskName, Cotizacion cotizacionProveedor, bool UsaPrecioListaProveedor, OrdenDeCompraItem item, bool CalculaPPP, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
            : this(IdProducto, IdVisualizacionDeStock, Cantidad, IdProveedor, taskName, cotizacionProveedor, UsaPrecioListaProveedor, CalculaPPP, TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _calculaPPP = CalculaPPP;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            /*Fin German 20090325*/
            _ordenDeCompraItem = item;
            if (_ordenDeCompraItem != null)
            {
                _precioDeCostoMonedaProducto = _ordenDeCompraItem.PrecioDeCosto * _ordenDeCompraItem.ValorCotizacion / _cotizacionProductoPrecioDeCosto.Valor;
                _precioDeCostoAnteriorMonedaProducto = _precioDeCostoMonedaProducto;
                if ((_cotizacionProductoPrecioDeCosto.IdMonedaOrigen != _cotizacionProveedor.IdMonedaOrigen)
                    || (_cotizacionProductoPrecioDeCosto.IdMonedaOrigen == _cotizacionProveedor.IdMonedaOrigen && _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio != _cotizacionProveedor.IdFuenteDeCambio))
                    PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProveedor.Valor;
                else PrecioDeCostoMonedaProveedor = _precioDeCostoMonedaProducto;
            }
        }

        #endregion

        #region Propiedades

        public decimal SubtotalPrecioDeCostoBonificacion1Aplicada
        {
            get
            {
                return _cantidad * PrecioDeCostoBonificacion1Aplicada;
            }
        }

        public decimal SubtotalPrecioDeCostoBonificacion2Aplicada
        {
            get
            {
                return _cantidad * PrecioDeCostoBonificacion2Aplicada;
            }
        }

        public decimal SubtotalPrecioDeCostoBonificacion3Aplicada
        {
            get
            {
                return _cantidad * PrecioDeCostoBonificacion3Aplicada;
            }
        }

        public decimal SubtotalPrecioDeCostoBonificacion4Aplicada
        {
            get
            {
                return _cantidad * PrecioDeCostoBonificacion4Aplicada;
            }
        }

        public decimal SubtotalPrecioDeCostoBonificacion5Aplicada
        {
            get
            {
                return _cantidad * PrecioDeCostoBonificacion5Aplicada;
            }
        }


        public decimal PrecioDeCostoBonificacion1Aplicada
        {
            get
            {
                if (this._listaDePreciosProveedores != null)
                {
                    if (this._listaDePreciosProveedores.Items.Count == 1)
                    {
                        ListaDePreciosProveedoresItem item = (ListaDePreciosProveedoresItem)this._listaDePreciosProveedores.Items[0];
                        return item.PrecioDeCostoBonificacion1Aplicada;
                    }
                }
                return 0;
            }
        }

        public decimal PrecioDeCostoBonificacion2Aplicada
        {
            get
            {
                if (this._listaDePreciosProveedores != null)
                {
                    if (this._listaDePreciosProveedores.Items.Count == 1)
                    {
                        ListaDePreciosProveedoresItem item = (ListaDePreciosProveedoresItem)this._listaDePreciosProveedores.Items[0];
                        return item.PrecioDeCostoBonificacion2Aplicada;
                    }
                }
                return 0;
            }
        }

        public decimal PrecioDeCostoBonificacion3Aplicada
        {
            get
            {
                if (this._listaDePreciosProveedores != null)
                {
                    if (this._listaDePreciosProveedores.Items.Count == 1)
                    {
                        ListaDePreciosProveedoresItem item = (ListaDePreciosProveedoresItem)this._listaDePreciosProveedores.Items[0];
                        return item.PrecioDeCostoBonificacion3Aplicada;
                    }
                }
                return 0;
            }
        }


        public decimal PrecioDeCostoBonificacion4Aplicada
        {
            get
            {
                if (this._listaDePreciosProveedores != null)
                {
                    if (this._listaDePreciosProveedores.Items.Count == 1)
                    {
                        ListaDePreciosProveedoresItem item = (ListaDePreciosProveedoresItem)this._listaDePreciosProveedores.Items[0];
                        return item.PrecioDeCostoBonificacion4Aplicada;
                    }
                }
                return 0;
            }
        }



        public decimal PrecioDeCostoBonificacion5Aplicada
        {
            get
            {
                if (this._listaDePreciosProveedores != null)
                {
                    if (this._listaDePreciosProveedores.Items.Count == 1)
                    {
                        ListaDePreciosProveedoresItem item = (ListaDePreciosProveedoresItem)this._listaDePreciosProveedores.Items[0];
                        return item.PrecioDeCostoBonificacion5Aplicada;
                    }
                }
                return 0;
            }
        }







        /*German 20090325*/
        public bool CalculaPPP
        {
            get { return _calculaPPP; }
            set { _calculaPPP = value; }
        }
        /*Fin German 20090325*/

        //Sabrina 20100706 - Tarea 790
        public bool PrecioDeVentaAfectaMac
        {
            get { return _precioDeVentaAfectaMac; }
            set
            {
                _precioDeVentaAfectaMac = value;
                ListaDePrecios.PrecioDeVentaAfectaMac = value;
            }
        }
        //Fin Sabrina 20100706 - Tarea 790


        public string CodigoSecundario
        {
            get { return _codigoSecundario; }
            set { _codigoSecundario = value; }
        }

        public string CampoAuxiliar1
        {
            get { return _campoAuxiliar1; }
            set { _campoAuxiliar1 = value; }
        }

        public string CampoAuxiliar2
        {
            get { return _campoAuxiliar2; }
            set { _campoAuxiliar2 = value; }
        }

        public string CampoAuxiliar3
        {
            get { return _campoAuxiliar3; }
            set { _campoAuxiliar3 = value; }
        }

        public string CampoAuxiliar4
        {
            get { return _campoAuxiliar4; }
            set { _campoAuxiliar4 = value; }
        }

        public string CampoAuxiliar5
        {
            get { return _campoAuxiliar5; }
            set { _campoAuxiliar5 = value; }
        }

        public string Observaciones
        {
            get { return _observaciones; }
        }

        public bool Selected
        {
            get { return _selected; }
            set
            {
                if (_selected != value)
                    _selected = value;
            }
        }

        public string IdProveedor
        {
            get { return _idProveedor; }
        }

        public string IdCotizacionMonedaPrecioDeVentaNeto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                    return _cotizacionProductoPrecioDeVenta.IdCotizacion;
                return string.Empty;
            }
        }

        public string IdCotizacionMonedaPrecioDeCosto
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                    return _cotizacionProductoPrecioDeCosto.IdCotizacion;
                return string.Empty;
            }
        }

        public decimal ValorCotizacionPrecioDeCosto
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


        public decimal ValorCotizacionPrecioDeVenta
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

        public string IdMonedaPrecioDeCosto
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
                        _idMonedaPrecioDeCosto = value;
                        if (value != null && value != string.Empty)
                            _simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeCosto).Simbolo;
                    }
                }
            }
        }

        public string IdMonedaPrecioDeVentaNeto
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
                        _idMonedaPrecioDeVentaNeto = value;
                        if (value != null && value != string.Empty)
                        {
                            _simboloMonedaDescuentoMaximo = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaPrecioDeVentaNeto).Simbolo;
                            _simboloMonedaPrecioDeLista = _simboloMonedaDescuentoMaximo;
                            _simboloMonedaPrecioDeVentaNeto = _simboloMonedaDescuentoMaximo;
                        }

                    }
                }
            }
        }


        public Cotizacion CotizacionProveedor
        {
            get { return _cotizacionProveedor; }

            set { _cotizacionProveedor = value; }

        }



        // Recupera los Coeficientes en PORCENTAJES.
        public decimal Coeficiente1
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(1, this.PrecioDeCostoDirecto); }
            //set{_coeficiente1 = value;}
        }

        public decimal Coeficiente2
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(2, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente3
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(3, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente4
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(4, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente5
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(5, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente6
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(6, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente7
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(7, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente8
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(8, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente9
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(9, this.PrecioDeCostoDirecto); }
        }

        public decimal Coeficiente10
        {
            get { return CoeficientesIndirectos.GetCoeficientePorc(10, this.PrecioDeCostoDirecto); }
        }

        #region CostoIndirectoN (N=1..10) - Matias 20100722 - Tarea 78 - BORRAR!!
        //Matias 20100722 - Tarea 78
        // Costos Indirectos : 1..10
        /*
        public decimal CostoIndirecto1
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(1, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    //Matias 20100722 - Tarea 78
                    //if(_precioCostoPromedioPonderado != 0)
                    //{
                        //this.CoeficientesIndirectos.setCoeficienteValor(1, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); //Sabrina: tarea 56
                        this.CoeficientesIndirectos.SetCoeficienteValor(1, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    //}
                    //Fin Matias 20100722 - Tarea 78
                }
            }
        }

        public decimal CostoIndirecto2
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(2, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(2, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(2, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto3
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(3, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(3, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(3, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto4
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(4, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(4, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(4, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto5
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(5, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if(value != this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if(value != this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(5, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(5, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto6
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(6, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if(value != this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if(value != this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(6, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(6, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto7
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(7, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(7, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(7, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto8
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(8, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(8, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(8, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto9
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(9, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if(_precioCostoPromedioPonderado != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(9, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(9, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }

        public decimal CostoIndirecto10
        {
            //Sabrina: tarea 56
            //get{return this.CoeficientesIndirectos.getCoeficienteValor(10, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
            get{return this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                //Sabrina: tarea 56
                //if( value != this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto) )
                if( value != this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto) )
                {
                    if( this.PrecioDeCostoDirecto != 0)
                    {
                        //Sabrina: tarea 56
                        //this.CoeficientesIndirectos.setCoeficienteValor(10, value, this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto);
                        this.CoeficientesIndirectos.SetCoeficienteValor(10, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                    }
                }
            }
        }
        */
        //Fin Matias 20100722 - Tarea 78
        #endregion

        #region CostoIndirectoN (N=1..10) - Matias 20100722 - Tarea 78
        //Matias 20100722 - Tarea 78
        // Es el mismo codigo pero limpio, sin codigo comentado.
        // Incluye mejoras realizadas por Sabrina - Tarea 56.
        public decimal CostoIndirecto1
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(1, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto2
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(2, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto3
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(3, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto4
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(4, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto5
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(5, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto6
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(6, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto7
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(7, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto8
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(8, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto9
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(9, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirecto10
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                {
                    this.CoeficientesIndirectos.SetCoeficienteValor(10, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                    RecalcularPrecioDeCosto();
                }
            }
        }
        //Fin Matias 20100722 - Tarea 78
        #endregion

        //Sabrina: tarea 56
        /*public decimal CostoIndirectoTotal
        {
            get{return this.CoeficientesIndirectos.getCoeficienteValorTotal( this.PrecioDeCostoPromedioPonderado, this._cotizacionProductoPrecioDeCosto); }
        }*/

        private void RecalcularPrecioDeCosto()
        {
            PrecioDeCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;
        }

        public decimal PrecioDeCostoIndirecto
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteValorTotal(this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
        }

        public decimal PrecioDeCostoDirecto
        {
            get { return _precioDeCostoDirecto; }

            set
            {
                _precioDeCostoDirecto = value;
                RecalcularPrecioDeCosto();
                //PrecioDeCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;
            }

        }

        public decimal PrecioDeCostoReposicionAnterior
        {
            get { return _precioDeCostoReposicionAnterior; }
        }

        public decimal PrecioDeCostoReposicion
        {
            get { return _precioDeCostoReposicion; }
            set
            {
                _precioDeCostoReposicion = value;
                if (_usaPrecioDeCostoReposicion)
                    PrecioDeCostoDirecto = _precioDeCostoReposicion;
            }
        }

        public decimal PrecioCostoPromedioPonderadoAnterior
        {
            get { return _precioCostoPromedioPonderadoEnBD; }
        }

        public decimal PrecioDeCostoPromedioPonderado
        {
            get { return _precioCostoPromedioPonderado; }
            set
            {
                _precioCostoPromedioPonderado = value;
                if (!_usaPrecioDeCostoReposicion)
                    PrecioDeCostoDirecto = _precioCostoPromedioPonderado;
            }
        }

        public bool UsaPrecioDeCostoReposicion
        {
            get { return _usaPrecioDeCostoReposicion; }
            set
            {
                _usaPrecioDeCostoReposicion = value;
                if (_usaPrecioDeCostoReposicion)
                    PrecioDeCostoDirecto = _precioDeCostoReposicion;
                else
                    PrecioDeCostoDirecto = _precioCostoPromedioPonderado;
            }
        }

        public decimal CostoIndirectoPorc1
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(1); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(1))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(1, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc2
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(2); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(2))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(2, value);
                    RecalcularPrecioDeCosto();
                }

            }
        }

        public decimal CostoIndirectoPorc3
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(3); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(3))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(3, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc4
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(4); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(4))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(4, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc5
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(5); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(5))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(5, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc6
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(6); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(6))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(6, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc7
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(7); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(7))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(7, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc8
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(8); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(8))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(8, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc9
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(9); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(9))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(9, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public decimal CostoIndirectoPorc10
        {
            get { return this.CoeficientesIndirectos.GetCoeficientePorc(10); }
            set
            {
                if (value != this.CoeficientesIndirectos.GetCoeficientePorc(10))
                {
                    this.CoeficientesIndirectos.SetCoeficientePorc(10, value);
                    RecalcularPrecioDeCosto();
                }
            }
        }

        public string CostoIndirectoDescrip1
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(1); }
        }
        public string CostoIndirectoDescrip2
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(2); }
        }
        public string CostoIndirectoDescrip3
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(3); }
        }
        public string CostoIndirectoDescrip4
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(4); }
        }
        public string CostoIndirectoDescrip5
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(5); }
        }
        public string CostoIndirectoDescrip6
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(6); }
        }
        public string CostoIndirectoDescrip7
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(7); }
        }
        public string CostoIndirectoDescrip8
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(8); }
        }
        public string CostoIndirectoDescrip9
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(9); }
        }
        public string CostoIndirectoDescrip10
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteDescripcion(10); }
        }

        // ----------------- CostoIndirectoActivo 1..10
        public bool CostoIndirectoActivo1
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(1); }
        }
        public bool CostoIndirectoActivo2
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(2); }
        }
        public bool CostoIndirectoActivo3
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(3); }
        }
        public bool CostoIndirectoActivo4
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(4); }
        }
        public bool CostoIndirectoActivo5
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(5); }
        }
        public bool CostoIndirectoActivo6
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(6); }
        }
        public bool CostoIndirectoActivo7
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(7); }
        }
        public bool CostoIndirectoActivo8
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(8); }
        }
        public bool CostoIndirectoActivo9
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(9); }
        }
        public bool CostoIndirectoActivo10
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteActivo(10); }
        }

        // ----------------- CostoIndirectoTipo 1..10
        public bool CostoIndirectoTipo1
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(1); }
        }
        public bool CostoIndirectoTipo2
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(2); }
        }
        public bool CostoIndirectoTipo3
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(3); }
        }
        public bool CostoIndirectoTipo4
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(4); }
        }
        public bool CostoIndirectoTipo5
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(5); }
        }
        public bool CostoIndirectoTipo6
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(6); }
        }
        public bool CostoIndirectoTipo7
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(7); }
        }
        public bool CostoIndirectoTipo8
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(8); }
        }
        public bool CostoIndirectoTipo9
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(9); }
        }
        public bool CostoIndirectoTipo10
        {
            get { return this.CoeficientesIndirectos.GetCoeficienteTipo(10); }
        }
        // ------------------------

        //Sabrina: tarea 56
        /*public decimal CostosIndirectos
        {
            get{return _costosIndirectos ;}
        }*/

        public decimal CostosIndirectos
        {
            get { return _precioDeCostoIndirecto; }
        }

        public decimal PrecioDeCostoMonedaProducto
        {
            get { return _precioDeCostoMonedaProducto; }
            set
            {
                if (value != _precioDeCostoMonedaProducto)
                {
                    _precioDeCostoMonedaProducto = value;
                    if ((_cantidad + _stock) != 0)
                    {
                        //Sabrina: tarea 56
                        /*if(_calculaPPP)
                            _precioCostoPromedioPonderado = ((_precioDeCostoMonedaProducto * _cantidad) + (_precioDeCostoAnterior * _stock))/(_cantidad + _stock);
                        else _precioCostoPromedioPonderado = _precioDeCostoMonedaProducto;
                        //_costosIndirectos   = (_precioCostoPromedioPonderado * (_coeficiente1 + _coeficiente2 + _coeficiente3 + _coeficiente4 + _coeficiente5) / 100);
                        PrecioDeCosto = _precioCostoPromedioPonderado + CostoIndirectoTotal; //_costosIndirectos;
                        */
                        if (_calculaPPP)
                            PrecioDeCostoPromedioPonderado = ((_precioDeCostoMonedaProducto * _cantidad) + (_precioCostoPromedioPonderadoEnBD * _stock)) / (_cantidad + _stock);
                        else PrecioDeCostoPromedioPonderado = _precioCostoPromedioPonderadoEnBD;
                        PrecioDeCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;

                    }

                }
            }
        }

        public decimal PrecioDeCostoAnteriorMonedaProducto
        {
            get { return _precioDeCostoAnteriorMonedaProducto; }
        }

        public string SimboloMonedaDescuentoMaximo
        {
            get { return _simboloMonedaDescuentoMaximo; }
            set { _simboloMonedaDescuentoMaximo = value; }
        }

        public string SimboloMonedaPrecioDeLista
        {
            get { return _simboloMonedaPrecioDeLista; }
            set { _simboloMonedaPrecioDeLista = value; }
        }

        public string SimboloMonedaPrecioDeVentaNeto
        {
            get { return _simboloMonedaPrecioDeVentaNeto; }
            set { _simboloMonedaPrecioDeVentaNeto = value; }
        }

        public string SimboloMonedaOrigen
        {
            get { return _simboloMonedaOrigen; }
            set { _simboloMonedaOrigen = value; }
        }

        public long IdSucursal
        {
            get { return _idSucursal; }
        }

        public long IdEmpresa
        {
            get { return _idEmpresa; }
        }
        public string IdFuenteDeCambioProductoPrecioDeCosto
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                    return _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio;
                return string.Empty;
            }
            set
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                {
                    if (value != _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio)
                    {
                        _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio = value;
                    }
                }
            }
        }

        public string IdFuenteDeCambioProductoPrecioDeVenta
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                    return _cotizacionProductoPrecioDeVenta.IdFuenteDeCambio;
                return string.Empty;
            }
            set
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    if (value != _cotizacionProductoPrecioDeVenta.IdFuenteDeCambio)
                    {
                        _cotizacionProductoPrecioDeVenta.IdFuenteDeCambio = value;
                    }
                }
            }
        }

        public decimal PrecioDeCostoMonedaProveedor
        {
            get { return _precioCostoMonedaProveedor; }
            set
            {
                if (value != _precioCostoMonedaProveedor)
                {
                    _precioCostoMonedaProveedor = value;
                    SetConversionProveedor();
                    SetConversionProducto();
                    GeneratePrecioDeCosto();

                }

            }
        }

        public OrdenDeCompraItem OrdenDeCompraItem
        {
            get { return _ordenDeCompraItem; }
        }

        //Sabrina: tarea 56
        /*public decimal PrecioDeCostoPromedioPonderado
        {
            get{return _precioCostoPromedioPonderado;}
            set{_precioCostoPromedioPonderado = value;}
        }*/

        public decimal PrecioCostoMonedaReferencia
        {
            get { return _precioCostoMonedaReferencia; }
        }

        public decimal PrecioDeCostoAnterior
        {
            get { return _precioDeCostoAnterior; }
        }

        public decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public decimal Stock
        {
            get { return _stock; }
        }

        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string Codigo
        {
            get { return _codigoProducto; }
            set { _codigoProducto = value; }
        }

        public decimal PrecioLista
        {
            get
            {

                return _precioDeLista;//(_precioDeCosto + (_precioDeCosto* (_MAC+IB+SH) /100)) + _maximoDescuento;
            }
            set
            {

                if (/*value != 0*/true)
                {
                    _precioDeLista = value;
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                        {
                            _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                            _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        }
                        else
                            _MAC = 0;
                    }
                }
            }
        }//Se agrega para que el precio de venta incluya el impacto de Ingresos brutos y de seguridad e higuiene
        decimal IB = 0;
        decimal SH = 0;

        public decimal PrecioDeCosto
        {
            get { return _precioDeCosto; }
            set
            {
                decimal PVentaNetoAnterior = PrecioDeVentaNeto;
                _precioDeCosto = value;
                if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    //Sabrina 20100719 - Tarea 796
                    //if(_precioDeVentaAfectaMac && PVentaNetoAnterior != 0)
                    if (PVentaNetoAnterior != 0)
                    //Fin Sabrina 20100719 - Tarea 796
                    {
                        _coeficientePVNaPVB = (_precioDeLista - PVentaNetoAnterior) * 100 / PVentaNetoAnterior;
                        _precioDeLista = PrecioDeVentaNeto + (PrecioDeVentaNeto * _coeficientePVNaPVB / 100);
                        _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                    }
                    //German 20120810 - Tarea 0000370
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                            _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        else
                            _MAC = 0;
                    }
                    //Fin German 20120810 - Tarea 0000370
                }
                else
                {
                    //German 20090715
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                            _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        else
                            _MAC = 0;
                    }
                    else //Afecta el descuento
                    {
                        _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                        if (_precioDeLista != 0)
                            _porcentajeMaximoDescuento = _maximoDescuento * 100 / _precioDeLista;
                        else
                            _porcentajeMaximoDescuento = 100;
                    }
                    //Fin German 20090715
                    /*
                    if(_precioDeVentaAfectaMac)
                    {
                        _MAC = ((((_precioDeLista - _maximoDescuento) - ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    }
                    else //Afecta el descuento
                    {
                        if(_precioDeLista != 0)
                        {
                            _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                            _porcentajeMaximoDescuento =  _maximoDescuento*100/_precioDeLista;
                        }
                    }
                    */

                }

            }
        }

        public decimal PrecioDeVentaNetoMonedaPrecioDeCosto
        {
            get { return _precioDeCosto + (_precioDeCosto * (_MAC + IB + SH) / 100); }
        }

        public decimal PrecioDeVentaNeto
        {
            get
            {

                return (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + ((_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) * (_MAC + IB + SH) / 100);
            }
            set { _precioDeVentaNeto = value; }

        }

        public decimal MAC
        {
            get
            {
                /*
                if(_precioDeVentaAfectaMac)
                {
					
                    if(_precioDeCosto != 0)
                        return ((((_precioDeLista - _maximoDescuento) - ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    else
                        return 0;
					
                }
                else
                */
                return _MAC;
            }
            set
            {
                decimal PVentaNetoAnterior = PrecioDeVentaNeto;
                _MAC = value;
                if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    //Sabrina 20100719 - Tarea 796
                    //if(_precioDeVentaAfectaMac)
                    if (PVentaNetoAnterior != 0)
                    //Fin Sabrina 20100719 - Tarea 796
                    {
                        _coeficientePVNaPVB = (_precioDeLista - PVentaNetoAnterior) * 100 / PVentaNetoAnterior;
                        _precioDeLista = PrecioDeVentaNeto + (PrecioDeVentaNeto * _coeficientePVNaPVB / 100);
                        _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                    }
                }
                else
                {
                    //German 20090715
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                            _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        else
                            _MAC = 0;
                    }
                    else //Afecta el descuento
                    {
                        _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                        if (_precioDeLista != 0)
                            _porcentajeMaximoDescuento = _maximoDescuento * 100 / _precioDeLista;
                        else
                            _porcentajeMaximoDescuento = 100;
                    }
                    //Fin German 20090715
                    /*
                    if(_precioDeVentaAfectaMac) 
                    {
                        _MAC = ((((_precioDeLista - _maximoDescuento) - ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    }
                    else //Afecta el descuento
                    {
                        _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                        _porcentajeMaximoDescuento =  _maximoDescuento*100/_precioDeLista;
                    }
                    */
                }

            }

        }



        public decimal MaximoDescuento
        {
            get
            {
                if (_precioDeVentaAfectaMac)
                    return _maximoDescuento;
                else
                {
                    if (_precioDeLista != 0)
                        return (_precioDeLista - PrecioDeVentaNeto);
                    return 0;
                }
            }
            set { _maximoDescuento = value; }

        }

        public decimal PorcentajeMaximoDescuento
        {
            get
            {
                if (_precioDeVentaAfectaMac)
                    return _porcentajeMaximoDescuento;
                else
                {
                    if (_precioDeLista != 0)
                        return MaximoDescuento * 100 / _precioDeLista;
                    return 0;
                }
            }
            set
            {
                _porcentajeMaximoDescuento = value;
                if (_precioDeLista != 0)
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                        {
                            _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                            _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        }
                        else
                            _MAC = 0;

                        decimal PListaAnterior = _precioDeLista;
                        if (PrecioDeVentaNeto != 0)
                            _coeficientePVNaPVB = (PListaAnterior - PrecioDeVentaNeto) * 100 / PrecioDeVentaNeto;
                        else _coeficientePVNaPVB = 0;


                    }
                }
            }


        }

        public decimal PrecioDeListaConImpuestosMonedaReferencia
        {
            get
            {
                return PrecioDeListaConImpuestos * _cotizacionProductoPrecioDeVenta.Valor;
            }
            set
            {
                PrecioDeListaConImpuestos = value * (1 / _cotizacionProductoPrecioDeVenta.Valor);
            }
        }

        //German 20090806
        //Estos metodos solo deberian llamarse para productos nuevos
        public void SetPrecioDeListaConImpuestos(decimal precioDeVta, decimal Alicuota)
        {
            if (Alicuota == 0) PrecioLista = precioDeVta;
            PrecioLista = precioDeVta / (Convert.ToDecimal(1.00) + Alicuota / Convert.ToDecimal(100.00));
        }

        public decimal GetPrecioDeListaConImpuestos(decimal Alicuota)
        {
            if (Alicuota == 0) return _precioDeLista;
            return _precioDeLista * (Convert.ToDecimal(1.00) + Alicuota / Convert.ToDecimal(100.00));
        }
        //Fin German 20090806


        public decimal PrecioDeListaConImpuestos
        {
            get
            {
                decimal _precioDeVentaBruto = this._precioDeLista;
                System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeLista);
                _precioDeListaConImpuestos = _precioDeLista + _impuestosBrutos;
                return _precioDeListaConImpuestos;
            }
            set
            {

                if (/*value != 0*/ true)
                {
                    _precioDeListaConImpuestos = value;
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                    PrecioLista = FuncionesImpuestos.CalcularInversa(formulas, value);

                }

            }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public decimal StockDisponible
        {
            get { return _stock; }
        }

        public ListaDePrecios ListaDePrecios
        {
            get { return _listaDePrecios; }
            //Sabrina: Tarea 834. 20101004
            set
            {
                _listaDePrecios = value;
            }
            //Fin Sabrina: Tarea 834. 20101004
        }

        public ListaDePreciosProveedores ListaDePreciosProveedores
        {
            get { return _listaDePreciosProveedores; }
        }

        public string IdProveedorDefault
        {
            get { return _idProveedorDefault; }
            set
            {
                _idProveedorDefaultAnterior = _idProveedorDefault;
                _idProveedorDefault = value;
            }
        }

        public string IdProveedorDefaultAnterior
        {
            get { return _idProveedorDefaultAnterior; }
            set
            {
                _idProveedorDefaultAnterior = value;
            }
        }

        public decimal PrecioDeCostoEnBD
        {
            get { return _precioDeCostoEnBD; }
        }

        public decimal PrecioDeListaEnBD
        {
            get { return _precioDeListaEnBD; }
        }

        public CostosIndirectos CoeficientesIndirectos
        {
            get { return _coeficientesIndirectos; }
            set { _coeficientesIndirectos = value; }
        }

        public decimal PrecioListaProveedor
        {
            get
            {
                if (_listaDePreciosProveedores != null)
                    if (_listaDePreciosProveedores.Items.Count == 1)
                    {
                        return ((ListaDePreciosProveedoresItem)_listaDePreciosProveedores.Items[0]).PrecioDeCosto;
                    }
                return 0;
            }

        }


        //Sabrina Tarea 77
        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
            }
        }
        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
            set { _codigoProveedor = value; }
        }

        public bool Activo
        {
            get { return _activo; }
        }

        public ProductosJerarquias Jerarquias
        {
            get { return _jerarquias; }
            set { _jerarquias = value; }
        }

        //Sabrina: Tarea 1061. 20110310
        public bool EsCombo
        {
            get { return _esCombo; }
            set { _esCombo = value; }
        }
        //Fin Sabrina: Tarea 1061. 20110310

        #endregion

        #region Metodos Privados

        private DataSet getPreciosDeCostoAnterior()
        {

            long idTask = Workflow.GetIdTakByName(this._taskName);
            ArrayList tiposdecomprobanteslist = new ArrayList(mz.erp.businessrules.Workflow.GetComprobantesAsociadosList(idTask).Keys);
            string tiposDeComprobantes = mz.erp.systemframework.Util.ConvertToString(tiposdecomprobanteslist);
            return mz.erp.businessrules.tsh_Productos.getPreciosDeCostoAnterior(this._idProducto, tiposDeComprobantes);
        }

        private void GenerateSucursalesImpuestos()
        {
            _sucursalProducto = new SucursalProducto();
            _sucursalProducto.Init(_idSucursal, _idEmpresa, this);

        }

        private void GenerateImpuestosProductos()
        {
            //DataSet data = mz.erp.businessrules.tsy_ImpuestosProductos.GetList(this._idProducto);
            DataSet data = mz.erp.businessrules.tsy_ImpuestosProductos.GetListByIdProducto(this._idProducto);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                string IdImpuesto = Convert.ToString(row["IdImpuesto"]);
                DataRow rowImpuesto = mz.erp.businessrules.tsy_ImpuestosEx.GetByPk(IdImpuesto);
                ImpuestoProducto pi = new ImpuestoProducto();
                pi.IdImpuesto = rowImpuesto["IdImpuesto"].ToString();
                pi.Descripcion = rowImpuesto["Descripcion"].ToString();
                pi.Formula = rowImpuesto["FormulaDeCalculo"].ToString();
                pi.Activo = true;
                this._impuestos.Add(pi);

            }

        }

        private void SetConversionProducto()
        {
            if (_cotizacionProductoPrecioDeCosto != null && _cotizacionProveedor != null)
            {
                if (_cotizacionProductoPrecioDeCosto.Valor != 0)
                {
                    if (!_cotizacionProductoPrecioDeCosto.IdMonedaOrigen.Equals(_cotizacionProveedor.IdMonedaOrigen) || !_cotizacionProductoPrecioDeCosto.IdFuenteDeCambio.Equals(_cotizacionProveedor.IdFuenteDeCambio))
                        _precioDeCostoMonedaProducto = _precioCostoMonedaReferencia / _cotizacionProductoPrecioDeCosto.Valor;
                    else
                        _precioDeCostoMonedaProducto = _precioCostoMonedaProveedor;


                }
            }
        }

        private void SetConversionProveedor()
        {
            if (_cotizacionProveedor != null)
            {
                _precioCostoMonedaReferencia = _precioCostoMonedaProveedor * _cotizacionProveedor.Valor;
            }
        }

        private void GeneratePrecioDeCosto()
        {
            bool cond1 = true;//_precioCostoMonedaProveedor > 0;
            bool cond2 = true;
            if (cond1 && cond2)
            {
                if ((_cantidad + _stock) != 0)
                {
                    //Sabrina: tarea 56
                    /*if(_calculaPPP)
                        _precioCostoPromedioPonderado = ((_precioDeCostoMonedaProducto * _cantidad) + (_precioDeCostoAnterior * _stock))/(_cantidad + _stock);
                    else _precioCostoPromedioPonderado = _precioDeCostoMonedaProducto;
                    //_costosIndirectos   = (_precioCostoPromedioPonderado * (_coeficiente1 + _coeficiente2 + _coeficiente3 + _coeficiente4 + _coeficiente5) / 100);
                    PrecioDeCosto = _precioCostoPromedioPonderado + CostoIndirectoTotal; //_costosIndirectos;
                    */
                    if (_calculaPPP)
                        PrecioDeCostoPromedioPonderado = ((_precioDeCostoMonedaProducto * _cantidad) + (_precioCostoPromedioPonderadoEnBD * _stock)) / (_cantidad + _stock);
                    else PrecioDeCostoPromedioPonderado = _precioCostoPromedioPonderadoEnBD;
                    PrecioDeCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;

                }
            }

        }
        #endregion

        #region Metodos Publicos
        //Sabrina: tarea 75
        private decimal _precioDeVentaNetoAnterior = 0;
        public void RecalcularAplicaSobrePrecioDeCosto(decimal nuevoPrecioDeCostoDirecto, ModificarPreciosMasivo.Afecta af)
        {
            _precioDeVentaNetoAnterior = PrecioDeVentaNeto;
            _precioDeCostoDirecto = nuevoPrecioDeCostoDirecto;
            _precioDeCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;
            _precioDeCostoReposicion = _precioDeCostoDirecto;
            //Sabrina: Tarea 834. 20101004
            /*if(af.Equals(ModificarPreciosMasivo.Afecta.NoAfecta) && this._precioDeVentaAfectaMac)
                _MAC = ((((_precioDeLista - _maximoDescuento) - ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
            else if((af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido) || af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido))&& this._precioDeVentaAfectaMac)
            {
                if(PrecioLista >= PrecioDeVentaNeto)
                    _MAC = ((((_precioDeLista - _maximoDescuento) - ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
            }*/

            if (af.Equals(ModificarPreciosMasivo.Afecta.NoAfecta) || ((af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido) || af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido)) && PrecioLista >= PrecioDeVentaNeto))
            {
                if (_precioDeVentaAfectaMac)
                {
                    if (_precioDeCosto != 0)
                        _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    else
                        _MAC = 0;
                }
                else //Afecta el descuento
                {
                    _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                    if (_precioDeLista != 0)
                        _porcentajeMaximoDescuento = _maximoDescuento * 100 / _precioDeLista;
                    else
                        _porcentajeMaximoDescuento = 100;
                }

            }
            //Fin Sabrina: Tarea 834. 20101004


        }

        public void RecalcularAplicaSobrePrecioDeVentaNeto(decimal nuevoMac, ModificarPreciosMasivo.Afecta af)
        {
            _precioDeVentaNetoAnterior = PrecioDeVentaNeto;
            _MAC = nuevoMac;
            //Sabrina: Tarea 863. 20101109
            /*if(af.Equals(ModificarPreciosMasivo.Afecta.NoAfecta) || ((af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido) || af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido)) && PrecioLista  >= PrecioDeVentaNeto))
            {
                _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                _porcentajeMaximoDescuento =  _maximoDescuento*100/_precioDeLista;
            }*/
            if (af.Equals(ModificarPreciosMasivo.Afecta.NoAfecta) || ((af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido) || af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido)) && PrecioLista >= PrecioDeVentaNeto))
            {
                if (_precioDeVentaAfectaMac)
                {
                    if (_precioDeCosto != 0)
                        _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    else
                        _MAC = 0;
                }
                else //Afecta el descuento
                {
                    _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                    if (_precioDeLista != 0)
                        _porcentajeMaximoDescuento = _maximoDescuento * 100 / _precioDeLista;
                    else
                        _porcentajeMaximoDescuento = 100;
                }

            }
            //Fin Sabrina: Tarea 863. 20101109
        }

        public void RecalcularAplicaSobrePrecioDeVentaBruto(decimal nuevoPrecioDeLista)
        {
            _precioDeLista = nuevoPrecioDeLista;
            if (_precioDeVentaAfectaMac)
            {
                if (_precioDeCosto != 0)
                {
                    _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                    _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                }
                else
                    _MAC = 0;
            }
            else
            {
                _maximoDescuento = _precioDeLista - PrecioDeVentaNeto;
                _porcentajeMaximoDescuento = _maximoDescuento * 100 / _precioDeLista;
            }
        }


        public void RecalcularAplicaSobrePrecioDeVentaBrutoConImpuestos(decimal nuevoPrecioDeListaConImpuestos)
        {
            _precioDeListaConImpuestos = nuevoPrecioDeListaConImpuestos;
            System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
            decimal nuevoPrecioDeLista = FuncionesImpuestos.CalcularInversa(formulas, nuevoPrecioDeListaConImpuestos);
            this.RecalcularAplicaSobrePrecioDeVentaBruto(nuevoPrecioDeLista);
        }


        public void RecalcularAplicaSobreMaximoDescuentoPorcentual(ModificarPreciosMasivo.Afecta af, decimal nuevoPorcentajeMaximoDescuento)
        {
            if (af.Equals(ModificarPreciosMasivo.Afecta.MAC))
            {
                if (_precioDeCosto != 0)
                {
                    _porcentajeMaximoDescuento = nuevoPorcentajeMaximoDescuento;
                    _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
                    _MAC = ((((_precioDeLista - _maximoDescuento) - (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / (_precioDeCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                }
                else
                    _MAC = 0;
            }
            else if (af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeLista))
            {
                _porcentajeMaximoDescuento = nuevoPorcentajeMaximoDescuento;
                _precioDeLista = PrecioDeVentaNeto / (1 - (_porcentajeMaximoDescuento / 100));
                _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
            }

        }

        public void CalcularPreciosAfectados(ModificarPreciosMasivo.Afecta af)
        {
            switch (af)
            {
                case ModificarPreciosMasivo.Afecta.PrecioDeLista:
                    {
                        this.TransladarIncremento();
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugerido:
                    {
                        this.IgualarANuevoPVS();
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido:
                    {
                        if (PrecioLista < PrecioDeVentaNeto)
                            this.IgualarANuevoPVS();
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido:
                    {
                        if (PrecioLista < PrecioDeVentaNeto)
                            this.TransladarIncremento();
                    }
                    break;
                default: break;
            }
        }

        public void TransladarIncremento()
        {
            if (_precioDeVentaNetoAnterior != 0)
            {
                decimal dif = _precioDeLista - _precioDeVentaNetoAnterior;
                decimal coef = (dif * 100 / _precioDeVentaNetoAnterior);
                _precioDeLista = PrecioDeVentaNeto + PrecioDeVentaNeto * coef / 100;
                _maximoDescuento = _porcentajeMaximoDescuento * _precioDeLista / 100;
            }
        }

        public void IgualarANuevoPVS()
        {
            _precioDeLista = PrecioDeVentaNeto;
            _porcentajeMaximoDescuento = 0;
            _maximoDescuento = 0;
        }

        //Sabrina: tarea 56

        public void ActualizarPrecioDeCostoReposicionConPrecioDeCostoListaProveedor()
        {
            //PrecioDeCostoReposicion = (PrecioDeCostoMonedaProveedor * _cotizacionProveedor.Valor) / ValorCotizacionPrecioDeCosto;

            ListaDePreciosProveedoresItem item = this._listaDePreciosProveedores.getListaDePreciosProveedoresItem(this._idProveedorDefault);
            PrecioDeCostoReposicion = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / ValorCotizacionPrecioDeCosto;

        }




        public void ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
        {
            PrecioDeCostoReposicion = (PrecioDeCostoMonedaProveedor * _cotizacionProveedor.Valor) / ValorCotizacionPrecioDeCosto;
        }

        public void DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
        {
            PrecioDeCostoReposicion = PrecioDeCostoReposicionAnterior;
        }

        public void ActivarCostoIndirecto(long idCosto, bool valor)
        {
            CoeficientesIndirectos.ActivarCostoIndirecto(idCosto, valor);
            RecalcularPrecioDeCosto();
        }

        public bool CoeficienteCreadoyActivo(long indice)
        {
            return CoeficientesIndirectos.CoeficienteCreadoyActivo(indice);
        }

        #endregion


        public Producto ShallowClone()
        {
            //Sabrina: Tarea 834. 20101004
            //return (Producto)this.MemberwiseClone();
            Producto prod = (Producto)this.MemberwiseClone();
            prod.ListaDePrecios = this.ListaDePrecios.ShallowClone();
            return prod;
            //Fin Sabrina: Tarea 834. 20101004
        }







    }

    public class ListaDePreciosProveedores
    {
        #region Variables privadas
        private ArrayList _items = new ArrayList();
        #endregion

        #region Constructores

        public ListaDePreciosProveedores(string IdProducto)
        {
            if (!IdProducto.Equals(string.Empty))
            {
                //tpu_ProveedoresProductosDataset dataPP = tpu_ProveedoresProductos.GetList(IdProducto);
                tpu_ProveedoresProductosDataset dataPP = tpu_ProveedoresProductos.GetListByIdProducto(IdProducto);
                foreach (tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP in dataPP.tpu_ProveedoresProductos.Rows)
                {
                    ListaDePreciosProveedoresItem lpi = new ListaDePreciosProveedoresItem(rowPP);
                    tsh_ProductosDataset.tsh_ProductosRow producto = tsh_Productos.GetByPk(IdProducto);
                    lpi.EsProveedorPorDefault = lpi.IdProveedor.Equals(producto.IdProveedorDefault);
                    _items.Add(lpi);
                }
            }
        }

        public ListaDePreciosProveedores(tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP)
        {
            if (rowPP != null)
            {
                ListaDePreciosProveedoresItem lpi = new ListaDePreciosProveedoresItem(rowPP);
                tsh_ProductosDataset.tsh_ProductosRow producto = tsh_Productos.GetByPk(rowPP.IdProducto);
                lpi.EsProveedorPorDefault = lpi.IdProveedor.Equals(producto.IdProveedorDefault);
                _items.Add(lpi);
            }
        }
        #endregion

        #region Propiedades
        public ArrayList Items
        {
            get { return _items; }
            set { _items = value; }
        }
        #endregion

        #region Métodos Públicos
        public ListaDePreciosProveedoresItem getListaDePreciosProveedoresItem(string IdProveedor)
        {
            bool existe = false;
            int i = 0;
            while (!existe && i < _items.Count)
            {
                ListaDePreciosProveedoresItem it = (ListaDePreciosProveedoresItem)_items[i];
                if (it.IdProveedor.Equals(IdProveedor))
                    existe = true;
                else
                    i++;
            }
            if (existe)
                return (ListaDePreciosProveedoresItem)_items[i];
            else
                return null;
        }

        public void AddItem(ListaDePreciosProveedoresItem Item)
        {
            _items.Add(Item);
        }

        public void RemoveItem(ListaDePreciosProveedoresItem Item)
        {
            _items.Remove(Item);
        }
        #endregion

        #region Métodos Privados

        #endregion
    }

    public class ListaDePreciosProveedoresItem
    {
        #region Variables privadas
        private string _idProveedor = string.Empty;
        private string _codigoProveedor = string.Empty;
        private string _nombreProveedor = string.Empty;
        private string _idProducto = string.Empty;
        private decimal _precioDeCosto = 0;
        private string _idMonedaPrecioDeCosto = string.Empty;
        private string _idCotizacionPrecioDeCosto = string.Empty;
        private string _idFuenteDeCambio = string.Empty;
        private string _campoAuxiliar1 = string.Empty;
        private string _campoAuxiliar2 = string.Empty;
        private string _campoAuxiliar3 = string.Empty;
        private string _campoAuxiliar4 = string.Empty;
        private decimal _campoAuxiliar5 = 0;
        private bool _actualizaPrecioDeCostoReposicion = false;
        private bool _bonificacionAcumulativa = true;
        private decimal _bonificacion1 = 0;
        private decimal _bonificacion2 = 0;
        private decimal _bonificacion3 = 0;
        private decimal _bonificacion4 = 0;
        private decimal _bonificacion5 = 0;
        private string _observaciones = string.Empty;
        private decimal _porcentajeBonificacion1 = 0;
        private decimal _porcentajeBonificacion2 = 0;
        private decimal _porcentajeBonificacion3 = 0;
        private decimal _porcentajeBonificacion4 = 0;
        private decimal _porcentajeBonificacion5 = 0;
        private decimal _precioDeCostoUltimaCompra = 0;
        private DateTime _fechaUltimaModificacionPrecioDeCosto;
        private DateTime _fechaUltimaModificacionPrecioDeCostoUltimaCompra;
        private decimal _precioDeCostoFinal = 0;
        private string _idCotizacionProveedor = string.Empty;
        private string _idFuenteDeCambioProveedor = string.Empty;
        private string _idMonedaProveedor = string.Empty;
        private decimal _valorCotizacionProveedor = 1;
        private CotizacionWrapper _cotizacionPrecioDeCosto;
        private string _estado = string.Empty;
        //Sabrina: Tarea 1110. 20110805
        private string _codigoProductoProveedor = string.Empty;
        //Fin Sabrina: Tarea 1110. 20110805
        #endregion

        #region Constructores
        //Sabrina: Tarea 1110. 20110805
        public ListaDePreciosProveedoresItem(string IdProducto, string IdProveedor, string IdMonedaPrecioDeCosto, string IdFuenteDeCambio, string IdCotizacionPrecioDeCosto, string IdCotizacionProveedor, string IdFuenteDeCambioProveedor, string IdMonedaProveedor, bool BonificacionAcumulativa, string CodigoProductoProveedor)
            : this(IdProducto, IdProveedor, IdMonedaPrecioDeCosto, IdFuenteDeCambio, IdCotizacionPrecioDeCosto, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, BonificacionAcumulativa)
        {
            _codigoProductoProveedor = CodigoProductoProveedor;
        }
        //Fin Sabrina: Tarea 1110. 20110805

        public ListaDePreciosProveedoresItem(string IdProducto, string IdProveedor, string IdMonedaPrecioDeCosto, string IdFuenteDeCambio, string IdCotizacionPrecioDeCosto, string IdCotizacionProveedor, string IdFuenteDeCambioProveedor, string IdMonedaProveedor, bool BonificacionAcumulativa)
        {
            _idProducto = IdProducto;
            _idProveedor = IdProveedor;
            tpu_ProveedoresDataset.tpu_ProveedoresRow rowP = tpu_Proveedores.GetByPk(IdProveedor);
            _codigoProveedor = rowP.Codigo;
            _nombreProveedor = rowP.Nombre;
            _precioDeCosto = 0;
            _idMonedaPrecioDeCosto = IdMonedaPrecioDeCosto;
            _idFuenteDeCambio = IdFuenteDeCambio;
            _idCotizacionPrecioDeCosto = IdCotizacionPrecioDeCosto;
            _idCotizacionProveedor = IdCotizacionProveedor;
            _idFuenteDeCambioProveedor = IdFuenteDeCambioProveedor;
            _idMonedaProveedor = IdMonedaProveedor;
            _cotizacionPrecioDeCosto = new CotizacionWrapper(_idCotizacionProveedor);
            _valorCotizacionProveedor = _cotizacionPrecioDeCosto.Valor;
            _simbololMonedaPrecioDeCosto = tfi_Monedas.GetByPk(_idMonedaProveedor).Simbolo;
            _bonificacionAcumulativa = BonificacionAcumulativa;
            _estado = "NEW";
        }


        public ListaDePreciosProveedoresItem(tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row)
        {
            _idProveedor = row.IdProveedor;
            _idProducto = row.IdProducto;
            tpu_ProveedoresDataset.tpu_ProveedoresRow rowP = tpu_Proveedores.GetByPk(_idProveedor);
            _codigoProveedor = rowP.Codigo;
            _nombreProveedor = rowP.Nombre;
            _precioDeCosto = row.PrecioDeCosto;
            _idMonedaPrecioDeCosto = row.IdMonedaPrecioDeCosto;
            _idFuenteDeCambio = row.IdFuenteDeCambio;
            _idCotizacionPrecioDeCosto = row.IdCotizacionPrecioDeCosto;
            _campoAuxiliar1 = row.IsCampoAuxiliar1Null() ? string.Empty : row.CampoAuxiliar1;
            _campoAuxiliar2 = row.IsCampoAuxiliar2Null() ? string.Empty : row.CampoAuxiliar2;
            _campoAuxiliar3 = row.IsCampoAuxiliar3Null() ? string.Empty : row.CampoAuxiliar3;
            _campoAuxiliar4 = row.IsCampoAuxiliar4Null() ? string.Empty : row.CampoAuxiliar4;
            _campoAuxiliar5 = row.IsCampoAuxiliar5Null() ? 0 : row.CampoAuxiliar5;
            _bonificacionAcumulativa = row.BonificacionAcumulativa;
            _bonificacion1 = row.Bonificacion1;
            _bonificacion2 = row.Bonificacion2;
            _bonificacion3 = row.Bonificacion3;
            _bonificacion4 = row.Bonificacion4;
            _bonificacion5 = row.Bonificacion5;
            _observaciones = row.IsObservacionesNull() ? string.Empty : row.Observaciones;
            _porcentajeBonificacion1 = row.PorcentajeBonificacion1;
            _porcentajeBonificacion2 = row.PorcentajeBonificacion2;
            _porcentajeBonificacion3 = row.PorcentajeBonificacion3;
            _porcentajeBonificacion4 = row.PorcentajeBonificacion4;
            _porcentajeBonificacion5 = row.PorcentajeBonificacion5;
            _precioDeCostoFinal = row.PrecioDeCostoFinal;
            _precioDeCostoUltimaCompra = row.PrecioDeCostoUltimaCompra;
            _idCotizacionProveedor = row.IdCotizacionProveedor;
            _idFuenteDeCambioProveedor = row.IdFuenteDeCambioProveedor;
            _idMonedaProveedor = row.IdMonedaProveedor;
            _valorCotizacionProveedor = row.ValorCotizacionProveedor;
            _cotizacionPrecioDeCosto = new CotizacionWrapper(_idCotizacionProveedor);
            _simbololMonedaPrecioDeCosto = tfi_Monedas.GetByPk(_idMonedaProveedor).Simbolo;
            _estado = "";
            //Sabrina: Tarea 1110. 20110805
            tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = tpu_ProveedoresProductosAuxiliares.GetByPk(_idProveedor, _idProducto);
            _codigoProductoProveedor = rowPPA.CodigoProductoProveedor;
            //Fin Sabrina: Tarea 1110. 20110805
        }

        #endregion

        #region Propiedades

        public string IdProveedor
        {
            get { return _idProveedor; }
        }


        public string IdProducto
        {
            get { return _idProducto; }
        }


        public decimal PrecioDeCosto
        {
            get { return _precioDeCosto; }
            set
            {
                if (_precioDeCosto != value)
                {
                    _precioDeCosto = value;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";

                }
            }
        }


        private string _simbololMonedaPrecioDeCosto = string.Empty;
        public string SimbololMonedaPrecioDeCosto
        {
            get
            {
                return _simbololMonedaPrecioDeCosto;
            }
        }


        public decimal ValorCotizacionProveedor
        {
            get
            { /*
				if(_cotizacionPrecioDeCosto != null)
                    return _cotizacionPrecioDeCosto.Valor;
				else
					return 0;
				*/
                return _valorCotizacionProveedor;
            }
            set
            {
                _valorCotizacionProveedor = value;
                if (!_estado.Equals("NEW"))
                    _estado = "MODIF";
                //Sabrina: tarea 56
                if (PrecioDeCostoFinalChanged != null)
                    PrecioDeCostoFinalChanged(this, new EventArgs());

            }
        }
        public string IdMonedaPrecioDeCosto
        {
            get { return _idMonedaPrecioDeCosto; }
        }

        public string IdMonedaProveedor
        {
            get { return _idMonedaProveedor; }
            set
            {
                if (_cotizacionPrecioDeCosto != null)
                {
                    if (value != _cotizacionPrecioDeCosto.IdMonedaOrigen)
                    {
                        _cotizacionPrecioDeCosto.IdMonedaOrigen = value;
                        _idMonedaProveedor = value;
                        _simbololMonedaPrecioDeCosto = tfi_Monedas.GetByPk(_idMonedaProveedor).Simbolo;
                        _idCotizacionProveedor = _cotizacionPrecioDeCosto.IdCotizacion;
                        //Sabrina: tarea 56
                        _valorCotizacionProveedor = _cotizacionPrecioDeCosto.Valor;
                        if (!_estado.Equals("NEW"))
                            _estado = "MODIF";
                        //Sabrina: tarea 56
                        if (PrecioDeCostoFinalChanged != null)
                            PrecioDeCostoFinalChanged(this, new EventArgs());
                    }
                }

            }
        }


        public string IdCotizacionPrecioDeCosto
        {
            get { return _idCotizacionPrecioDeCosto; }
        }

        public string IdCotizacionProveedor
        {
            get { return _idCotizacionProveedor; }
        }


        public string IdFuenteDeCambio
        {
            get { return _idFuenteDeCambio; }
        }

        public string IdFuenteDeCambioProveedor
        {
            get { return _idFuenteDeCambioProveedor; }
            set
            {
                if (_cotizacionPrecioDeCosto != null)
                {
                    if (value != _cotizacionPrecioDeCosto.IdFuenteDeCambio)
                    {
                        _cotizacionPrecioDeCosto.IdFuenteDeCambio = value;
                        _idFuenteDeCambioProveedor = value;
                        _idCotizacionProveedor = _cotizacionPrecioDeCosto.IdCotizacion;
                        _idMonedaProveedor = _cotizacionPrecioDeCosto.IdMonedaOrigen;
                        _simbololMonedaPrecioDeCosto = tfi_Monedas.GetByPk(_idMonedaProveedor).Simbolo;
                        //Sabrina: tarea 56
                        _valorCotizacionProveedor = _cotizacionPrecioDeCosto.Valor;
                        if (!_estado.Equals("NEW"))
                            _estado = "MODIF";
                        //Sabrina: tarea 56
                        if (PrecioDeCostoFinalChanged != null)
                            PrecioDeCostoFinalChanged(this, new EventArgs());
                    }
                }

            }
        }


        public string CampoAuxiliar1
        {
            get { return _campoAuxiliar1; }
        }


        public string CampoAuxiliar2
        {
            get { return _campoAuxiliar2; }
        }


        public string CampoAuxiliar3
        {
            get { return _campoAuxiliar3; }
        }


        public string CampoAuxiliar4
        {
            get { return _campoAuxiliar4; }
        }


        public decimal CampoAuxiliar5
        {
            get { return _campoAuxiliar5; }
        }

        public bool ActualizaPrecioDeCostoReposicion
        {
            get { return _actualizaPrecioDeCostoReposicion; }
            set
            {
                if (_actualizaPrecioDeCostoReposicion != value)
                {
                    _actualizaPrecioDeCostoReposicion = value;
                }
            }
        }

        public bool BonificacionAcumulativa
        {
            get { return _bonificacionAcumulativa; }
            set
            {
                if (_bonificacionAcumulativa != value)
                {
                    _bonificacionAcumulativa = value;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal PrecioDeCostoBonificacion1Aplicada
        {
            get
            {
                if (_bonificacionAcumulativa)
                {
                    return _precioDeCosto + _bonificacion1;
                }
                else
                {
                    return _precioDeCosto + _bonificacion1;
                }
            }
        }

        public decimal PrecioDeCostoBonificacion2Aplicada
        {
            get
            {
                if (_bonificacionAcumulativa)
                {
                    return _precioDeCosto + _bonificacion1 + _bonificacion2;
                }
                else
                {
                    return _precioDeCosto + _bonificacion2;
                }
            }
        }

        public decimal PrecioDeCostoBonificacion3Aplicada
        {
            get
            {
                if (_bonificacionAcumulativa)
                {
                    return _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3;
                }
                else
                {
                    return _precioDeCosto + _bonificacion3;
                }
            }
        }

        public decimal PrecioDeCostoBonificacion4Aplicada
        {
            get
            {
                if (_bonificacionAcumulativa)
                {
                    return _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4;
                }
                else
                {
                    return _precioDeCosto + _bonificacion4;
                }
            }
        }

        public decimal PrecioDeCostoBonificacion5Aplicada
        {
            get
            {
                if (_bonificacionAcumulativa)
                {
                    return _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                }
                else
                {
                    return _precioDeCosto + _bonificacion5;
                }
            }
        }


        public decimal Bonificacion1
        {
            get { return _bonificacion1; }
            set
            {
                if (_bonificacion1 != value)
                {
                    _bonificacion1 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (_precioDeCosto != 0)
                        _porcentajeBonificacion1 = (value * 100) / _precioDeCosto;
                    else
                        _porcentajeBonificacion1 = 0;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion2
        {
            get { return _bonificacion2; }
            set
            {
                if (_bonificacion2 != value)
                {
                    _bonificacion2 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal Bonificacion3
        {
            get { return _bonificacion3; }
            set
            {
                if (_bonificacion3 != value)
                {
                    _bonificacion3 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion4
        {
            get { return _bonificacion4; }
            set
            {
                if (_bonificacion4 != value)
                {
                    _bonificacion4 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion5
        {
            get { return _bonificacion5; }
            set
            {
                if (_bonificacion5 != value)
                {
                    _bonificacion5 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public string Observaciones
        {
            get { return _observaciones; }
        }

        public decimal PorcentajeBonificacion1
        {
            get { return _porcentajeBonificacion1; }
            set
            {
                if (_porcentajeBonificacion1 != value)
                {
                    _porcentajeBonificacion1 = value;
                    _bonificacion1 = (_porcentajeBonificacion1 * _precioDeCosto) / 100;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion2
        {
            get { return _porcentajeBonificacion2; }
            set
            {
                if (_porcentajeBonificacion2 != value)
                {
                    _porcentajeBonificacion2 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion3
        {
            get { return _porcentajeBonificacion3; }
            set
            {
                if (_porcentajeBonificacion3 != value)
                {
                    _porcentajeBonificacion3 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion4
        {
            get { return _porcentajeBonificacion4; }
            set
            {
                if (_porcentajeBonificacion4 != value)
                {
                    _porcentajeBonificacion4 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion5
        {
            get { return _porcentajeBonificacion5; }
            set
            {
                if (_porcentajeBonificacion5 != value)
                {
                    _porcentajeBonificacion5 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal PrecioDeCostoUltimaCompra
        {
            get { return _precioDeCostoUltimaCompra; }
        }


        public void SetPrecioDeCostoFinal(decimal valor)
        {
            if (_precioDeCostoFinal != valor)
            {
                _precioDeCostoFinal = valor;
                if (!_estado.Equals("NEW"))
                    _estado = "MODIF";
            }

        }


        public decimal PrecioDeCostoFinal
        {
            get { return _precioDeCostoFinal; }
            set
            {
                if (_precioDeCostoFinal != value)
                {
                    _precioDeCostoFinal = value;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                    //Sabrina: tarea 56
                    if (PrecioDeCostoFinalChanged != null)
                        PrecioDeCostoFinalChanged(this, new EventArgs());
                }
            }
        }

        public string Estado
        {
            get { return _estado; }
        }

        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
        }

        public string NombreProveedor
        {
            get { return _nombreProveedor; }
        }

        public string SimbololMonedaBonificacion1
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        public string SimbololMonedaBonificacion2
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        public string SimbololMonedaBonificacion3
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        public string SimbololMonedaBonificacion4
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        public string SimbololMonedaBonificacion5
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        public string SimbololMonedaPrecioDeCostoFinal
        {
            get { return _simbololMonedaPrecioDeCosto; }
        }

        private bool _esProveedorPorDefault;
        public bool EsProveedorPorDefault
        {
            get { return _esProveedorPorDefault; }
            set
            {
                _esProveedorPorDefault = value;
            }
        }

        //Sabrina: Tarea 1110. 20110805
        public string CodigoProductoProveedor
        {
            get { return _codigoProductoProveedor; }
            set
            {
                if (_codigoProductoProveedor != value)
                {
                    _codigoProductoProveedor = value;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }
        //Fin Sabrina: Tarea 1110. 20110805
        #endregion

        #region Métodos Públicos
        public bool isNew()
        {
            return _estado.Equals("NEW");
        }
        #endregion

        #region Métodos Privados
        private void recalcularBonificaciones()
        {
            _bonificacion1 = (_precioDeCosto * _porcentajeBonificacion1) / 100;
            _bonificacion2 = (_precioDeCosto * _porcentajeBonificacion2) / 100;
            _bonificacion3 = (_precioDeCosto * _porcentajeBonificacion3) / 100;
            _bonificacion4 = (_precioDeCosto * _porcentajeBonificacion4) / 100;
            _bonificacion5 = (_precioDeCosto * _porcentajeBonificacion5) / 100;
        }

        #endregion

        #region Eventos

        public event EventHandler PrecioDeCostoFinalChanged;

        #endregion

    }


    public class ListaDePrecios
    {
        #region Variables privadas
        private ArrayList _items = new ArrayList();
        private tsh_ProductosListasDePreciosDataset _dataProductosListaDePrecios = new tsh_ProductosListasDePreciosDataset();
        private tsh_ProductosListasDePreciosAplicadasDataset _dataProductosListasDePreciosAplicadas = new tsh_ProductosListasDePreciosAplicadasDataset();

        //Sabrina 20100706 - Tarea 790
        private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;
        private bool _precioDeVentaAfectaMac = false;
        //Fin Sabrina 20100706 - Tarea 790
        #endregion

        #region Constructores
        //Sabrina: Tarea 834. 20101004
        public ListaDePrecios()
        {
        }
        //Fin Sabrina: Tarea 834. 20101004

        //Sabrina 20100705 - Tarea 790
        public ListaDePrecios(tsh_ProductosEx.ControladorProductos producto, string estado, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            if (estado.Equals("NEW"))
                initializeItemsForNew(producto);
            else
                initializeItemsForEdit(producto);

        }
        //Fin Sabrina 20100705 - Tarea 790

        //Sabrina 20100705 - Tarea 790
        public ListaDePrecios(Producto producto, string estado, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            /*if(estado.Equals("NEW"))
                initializeItemsForNew(producto);
            else
                initializeItemsForEdit(producto);*/

            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
            if (estado.Equals("EDIT"))
                initializeItemsForEdit(producto);
            else
                initializeItemsForNew(producto, estado);
        }
        //FIN Sabrina 20100705 - Tarea 790
        #endregion

        #region Propiedades
        public ArrayList Items
        {
            get { return _items; }
            set { _items = value; }
        }

        //Sabrina 20100706 - Tarea 790
        public bool PrecioDeVentaAfectaMac
        {
            get { return _precioDeVentaAfectaMac; }
            set
            {
                _precioDeVentaAfectaMac = value;
                foreach (ListaDePreciosItem item in _items)
                {
                    item.PrecioDeVentaAfectaMac = value;
                }
            }
        }
        //Fin Sabrina 20100706 - Tarea 790
        #endregion

        #region Métodos Públicos


        //German 20101125 - Tarea 924 
        public void UpdatePrecios(decimal ValorCotizacionPrecioDeCosto, decimal ValorCotizacionPrecioDeVenta, decimal PreciDeCosto, decimal MAC, decimal PrecioDeVentaNeto)
        {
            foreach (ListaDePreciosItem item in _items)
            {
                item.ValorCotizacionPrecioDeCosto = ValorCotizacionPrecioDeCosto;
                item.ValorCotizacionPrecioDeVenta = ValorCotizacionPrecioDeVenta;
                item.PrecioDeCosto = PreciDeCosto;
                item.Mac = MAC;
                item.PrecioDeVentaNeto = PrecioDeVentaNeto;
                if (item.Estado.Equals(""))
                    item.Estado = "MODIF_PLP";
            }
        }

        //Fin German 20101125 - Tarea 924
        public void UpdatePrecios(decimal PreciDeCosto, decimal MAC, decimal PrecioDeVentaNeto)
        {
            foreach (ListaDePreciosItem item in _items)
            {
                item.PrecioDeCosto = PreciDeCosto;
                item.Mac = MAC;
                item.PrecioDeVentaNeto = PrecioDeVentaNeto;
                if (item.Estado.Equals(""))
                    item.Estado = "MODIF_PLP";
            }
        }

        //Sabrina: Tarea 834. 20101004
        public void UpdatePrecios(decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, decimal PrecioLista, ModificarPreciosMasivo.Afecta af)
        {
            bool noTrasladaAPVB = af.Equals(ModificarPreciosMasivo.Afecta.NoAfecta) || ((af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido) || af.Equals(ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido)) && PrecioLista >= PrecioDeVentaNeto);
            foreach (ListaDePreciosItem item in _items)
            {
                decimal PVentaNetoAnterior = PrecioDeVentaNeto;
                item.SetPrecioDeCosto(PrecioDeCosto);
                item.SetMac(MAC);
                item.PrecioDeVentaNeto = PrecioDeVentaNeto;
                if (noTrasladaAPVB)
                    item.CalcularPreciosAfectadosNoTraslada();
                else
                    item.CalcularPreciosAfectadosTraslada(af, PVentaNetoAnterior, PrecioLista, PrecioDeVentaNeto);
                if (item.Estado.Equals(""))
                    item.Estado = "MODIF_PLP";
            }
        }

        public ListaDePrecios ShallowClone()
        {
            ListaDePrecios aux = new ListaDePrecios();
            foreach (ListaDePreciosItem item in _items)
            {
                ListaDePreciosItem clone = item.ShallowClone();
                aux.Items.Add(clone);
            }
            return aux;
        }
        //Fin Sabrina: Tarea 834. 20101004

        public void UpdateCoeficiente(ListaDePreciosItem Item, decimal CoeficienteItem)
        {
            if (Item.ModoDeAplicacion.Equals("G")) //USA LA LISTA DE PRECIOS GENERAL
            {
                Item.ModoDeAplicacion = "P";
                if (Item.Estado.Equals("DEL"))
                    Item.Estado = "MODIF_ALL";
                else if (!Item.Estado.Equals("NEW") && !Item.Estado.Equals("NEW_MULTIPLE"))
                    Item.Estado = "NEW_PLPA_MODIF_PLP";
            }
            else // USA LA LISTA DE PRECIOS DE PRODUCTOS
            {
                if (!Item.Estado.Equals("NEW") && !Item.Estado.Equals("NEW_PLPA_MODIF_PLP") && !Item.Estado.Equals("NEW_MULTIPLE"))
                    Item.Estado = "MODIF_ALL";
            }
            Item.CoeficienteProducto = CoeficienteItem;
        }

        public void UpdateCoeficiente(string IdProducto, string IdListaDePrecios, decimal CoeficienteItem)
        {
            ListaDePreciosItem Item = GetItem(IdProducto, IdListaDePrecios);
            if (Item.ModoDeAplicacion.Equals("G")) //USA LA LISTA DE PRECIOS GENERAL
            {
                Item.ModoDeAplicacion = "P";
                if (Item.Estado.Equals("DEL"))
                    Item.Estado = "MODIF_ALL";
                else if (!Item.Estado.Equals("NEW") && !Item.Estado.Equals("NEW_MULTIPLE"))
                    Item.Estado = "NEW_PLPA_MODIF_PLP";
            }
            else // USA LA LISTA DE PRECIOS DE PRODUCTOS
            {
                if (!Item.Estado.Equals("NEW") && !Item.Estado.Equals("NEW_PLPA_MODIF_PLP") && !Item.Estado.Equals("NEW_MULTIPLE"))
                    Item.Estado = "MODIF_ALL";
            }
            Item.CoeficienteProducto = CoeficienteItem;
        }

        public void UpdateCoeficienteToGral(ListaDePreciosItem Item)
        {
            if (Item.ModoDeAplicacion.Equals("P"))
            {
                Item.ModoDeAplicacion = "G";
                Item.CoeficienteProducto = Item.CoeficienteGral;
                if (!Item.Estado.Equals("NEW") && !Item.Estado.Equals("NEW_MULTIPLE"))
                {
                    if (!Item.Estado.Equals("NEW_PLPA_MODIF_PLP"))
                        Item.Estado = "DEL";
                    else
                        Item.Estado = "";
                }
            }
        }


        public void UpdateValorCotizacionPrecioDeVenta(decimal valorCotizacionPrecioDeVenta)
        {
            foreach (ListaDePreciosItem item in _items)
            {
                item.ValorCotizacionPrecioDeVenta = valorCotizacionPrecioDeVenta;
            }
        }

        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
        {
            foreach (ListaDePreciosItem item in _items)
            {
                data = item.Commit(data);
            }

            return data;

        }

        //German 20101123 - Tarea 923
        public void ImpuestosChanged()
        {
            foreach (ListaDePreciosItem item in _items)
            {
                item.ImpuestosChanged();
            }

        }
        //Fin German 20101123 - Tarea 923

        //Sabrina 20100615 - Tarea 764
        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data, ListaDePreciosItem item)
        {
            data = item.Commit(data);
            return data;

        }
        //Fin Sabrina 20100615 - Tarea 764


        //Para Workflow
        public void Commit(ListaDePreciosItem item)
        {
            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
            bool existRowPLP = rowPLP != null;
            if (!existRowPLP)
            {
                rowPLP = _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
                rowPLP.IdProducto = item.IdProducto;
                rowPLP.IdListaDePrecio = item.IdListaDePrecios;
                rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                rowPLP.Coeficiente = item.CoeficienteProducto;
                rowPLP.MaxDescuento = item.MaxDescuento;
                rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                rowPLP.FechaCreacion = DateTime.Now;
                rowPLP.IdConexionCreacion = Security.IdConexion;
                rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
                rowPLP.IdReservado = 0;
                rowPLP.RowId = Guid.Empty;
                rowPLP.IdEmpresa = Security.IdEmpresa;
                rowPLP.IdSucursal = Security.IdSucursal;
                _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);
            }
            else
            {
                rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                rowPLP.Coeficiente = item.CoeficienteProducto;
                rowPLP.MaxDescuento = item.MaxDescuento;
                rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                    rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
            }

            tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(item.IdProducto, item.IdListaDePrecios);
            bool existRowPLPA = rowPLPA != null;
            if (!existRowPLPA)
            {
                rowPLPA = _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                rowPLPA.IdProducto = item.IdProducto;
                rowPLPA.IdListaDePrecio = item.IdListaDePrecios;
                rowPLPA.Coeficiente = item.CoeficienteProducto;
                rowPLPA.FechaCreacion = DateTime.Now;
                rowPLPA.IdConexionCreacion = Security.IdConexion;
                rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                rowPLPA.IdReservado = 0;
                rowPLPA.RowId = Guid.Empty;
                rowPLPA.IdEmpresa = Security.IdEmpresa;
                rowPLPA.IdSucursal = Security.IdSucursal;
                _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);
            }
            else
            {
                rowPLPA.Coeficiente = item.CoeficienteProducto;
                _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);
            }

        }

        public void CommitWithCachedRow(ListaDePreciosItem item)
        {
            if (item.RowProdListaDePrecio != null)
            {
                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = item.RowProdListaDePrecio;
                rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                rowPLP.Coeficiente = item.CoeficienteProducto;
                rowPLP.MaxDescuento = item.MaxDescuento;
                rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                    rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
            }
            if (item.RowProdListaDePrecioAplicada != null)
            {
                tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = item.RowProdListaDePrecioAplicada;
                rowPLPA.Coeficiente = item.CoeficienteProducto;
                _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);
            }
        }


        public void Commit()
        {
            foreach (ListaDePreciosItem item in _items)
            {
                switch (item.Estado)
                {
                    case "NEW": //Nuevo lista de precios para el producto
                        {
                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
                            rowPLP.IdProducto = item.IdProducto;
                            rowPLP.IdListaDePrecio = item.IdListaDePrecios;
                            rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                            rowPLP.Coeficiente = item.CoeficienteProducto;
                            rowPLP.MaxDescuento = item.MaxDescuento;
                            rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                            rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                            rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                            rowPLP.FechaCreacion = DateTime.Now;
                            rowPLP.IdConexionCreacion = Security.IdConexion;
                            rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
                            rowPLP.IdReservado = 0;
                            rowPLP.RowId = Guid.Empty;
                            rowPLP.IdEmpresa = Security.IdEmpresa;
                            rowPLP.IdSucursal = Security.IdSucursal;
                            _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);

                            if (item.ModoDeAplicacion.Equals("P")) // Agrego en la tabla tsh_ProductosListasDePreciosAplicadas
                            {
                                tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                                rowPLPA.IdProducto = item.IdProducto;
                                rowPLPA.IdListaDePrecio = item.IdListaDePrecios;
                                rowPLPA.Coeficiente = item.CoeficienteProducto;
                                rowPLPA.FechaCreacion = DateTime.Now;
                                rowPLPA.IdConexionCreacion = Security.IdConexion;
                                rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPLPA.IdReservado = 0;
                                rowPLPA.RowId = Guid.Empty;
                                rowPLPA.IdEmpresa = Security.IdEmpresa;
                                rowPLPA.IdSucursal = Security.IdSucursal;
                                _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);
                            }
                            break;

                        }
                    case "MODIF_PLP": //Modificacion de Lista de precios producto 
                        {
                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                            rowPLP.Coeficiente = item.CoeficienteProducto;
                            rowPLP.MaxDescuento = item.MaxDescuento;
                            rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                            if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                                rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                            rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                            rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                            _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                            break;
                        }
                    case "NEW_PLPA_MODIF_PLP": //Modificacion de Lista de precios producto y adicion de lista de precios de productos aplicada
                        {
                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                            rowPLP.Coeficiente = item.CoeficienteProducto;
                            rowPLP.MaxDescuento = item.MaxDescuento;
                            rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                            if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                                rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                            rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                            rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                            _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                            tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                            rowPLPA.IdProducto = item.IdProducto;
                            rowPLPA.IdListaDePrecio = item.IdListaDePrecios;
                            rowPLPA.Coeficiente = item.CoeficienteProducto;
                            rowPLPA.FechaCreacion = DateTime.Now;
                            rowPLPA.IdConexionCreacion = Security.IdConexion;
                            rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                            rowPLPA.IdReservado = 0;
                            rowPLPA.RowId = Guid.Empty;
                            rowPLPA.IdEmpresa = Security.IdEmpresa;
                            rowPLPA.IdSucursal = Security.IdSucursal;
                            _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);

                            break;
                        }
                    case "MODIF_ALL": //Modificacion de Lista de precios producto y lista de precios producto aplicada
                        {
                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                            rowPLP.Coeficiente = item.CoeficienteProducto;
                            rowPLP.MaxDescuento = item.MaxDescuento;
                            rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                            if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                                rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                            rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                            rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                            _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                            tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLPA.Coeficiente = item.CoeficienteProducto;
                            _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);
                            break;
                        }

                    case "DEL": //Borrado de lista de precios de producto aplicado y modificacion de lista de precios de producto
                        {
                            tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLPA.Delete();
                            _dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);

                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
                            rowPLP.ModoDeAplicacion = item.ModoDeAplicacion;
                            rowPLP.Coeficiente = item.CoeficienteProducto;
                            rowPLP.MaxDescuento = item.MaxDescuento;
                            rowPLP.MaxDescuentoPorcentual = item.PorcentajeMaximoDescuento;
                            if (rowPLP.PrecioDeVentaBruto != item.PrecioDeVentaBruto)
                                rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                            rowPLP.PrecioDeVentaBruto = item.PrecioDeVentaBruto;
                            rowPLP.PrecioDeVentaBrutoConImpuesto = item.PrecioDeVentaBrutoConImpuestos;
                            _dataProductosListaDePrecios.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                            break;
                        }
                    default:
                        break;
                }
            }

        }

        public void Flush(string IdTransaction)
        {
            SentenciasReplicacion _replicacion = GenerateReplicaction();
            SqlTransaction trx = mz.erp.dataaccess.PoolTransaction.GetTransactionById(IdTransaction);
            mz.erp.dataaccess.tsh_ProductosListasDePrecios.Update(this._dataProductosListaDePrecios.tsh_ProductosListasDePrecios, trx, _replicacion);
            mz.erp.dataaccess.tsh_ProductosListasDePreciosAplicadas.Update(this._dataProductosListasDePreciosAplicadas.tsh_ProductosListasDePreciosAplicadas, trx, _replicacion);
        }


        //German 20111107 - Tarea 0000224

        public void setItemsGeneracionMasiva(ArrayList items, string IdProducto, tsh_ProductosEx.ControladorProductos p)
        {
            _items = new ArrayList();
            foreach (ListaDePreciosItem item in items)
            {
                //Sabrina 20100706 - Tarea 790
                ListaDePreciosItem itemNew = new ListaDePreciosItem(IdProducto, item.IdListaDePrecios, item.Descripcion, item.Codigo, item.ModoDeAplicacion, item.CoeficienteGral, item.CoeficienteProducto, item.PrecioDeCosto, item.Mac, item.PrecioDeVentaNeto, item.ValorCotizacionPrecioDeVenta, item.Estado, item.IsDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, item.ValorCotizacionPrecioDeCosto, p);
                //Fin Sabrina 20100706 - Tarea 790
                _items.Add(itemNew);
            }
        }

        //Fin German 20111107 - Tarea 0000224

        public void setItems(ArrayList items, string IdProducto)
        {
            _items = new ArrayList();
            foreach (ListaDePreciosItem item in items)
            {
                //Sabrina 20100706 - Tarea 790
                ListaDePreciosItem itemNew = new ListaDePreciosItem(IdProducto, item.IdListaDePrecios, item.Descripcion, item.Codigo, item.ModoDeAplicacion, item.CoeficienteGral, item.CoeficienteProducto, item.PrecioDeCosto, item.Mac, item.PrecioDeVentaNeto, item.ValorCotizacionPrecioDeVenta, item.Estado, item.IsDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, item.ValorCotizacionPrecioDeCosto);
                //Fin Sabrina 20100706 - Tarea 790
                _items.Add(itemNew);
            }
        }

        public ListaDePreciosItem GetItem(string IdProducto, string IdListaDePrecios)
        {
            ListaDePreciosItem item = null;
            int i = 0;
            while (item == null && i < _items.Count)
            {
                ListaDePreciosItem it = (ListaDePreciosItem)_items[i];
                if (it.IdProducto.Equals(IdProducto) && it.IdListaDePrecios.Equals(IdListaDePrecios))
                    item = it;
                i++;
            }
            return item;
        }

        public ListaDePreciosItem GetDefaultItem()
        {
            ListaDePreciosItem item = null;
            int i = 0;
            while (item == null && i < _items.Count)
            {
                ListaDePreciosItem it = (ListaDePreciosItem)_items[i];
                if (it.IsDefault)
                    item = it;
                i++;
            }
            return item;
        }
        #endregion

        #region Métodos Privados
        private void initializeItemsForNew(tsh_ProductosEx.ControladorProductos producto)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                //Sabrina 20100706 - Tarea 790
                ListaDePreciosItem lpi = new ListaDePreciosItem(producto.Idproducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "G", row.Coeficiente, row.Coeficiente, producto.PrecioCosto, producto.Margen, producto.PrecioNeto, "NEW", producto, row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                //Fin Sabrina 20100706 - Tarea 790
                _items.Add(lpi);
            }

        }

        private void initializeItemsForEdit(tsh_ProductosEx.ControladorProductos producto)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(producto.Idproducto, row.IdListaDePrecio);
                if (rowPLP != null)
                {
                    //Sabrina 20100706 - Tarea 790
                    ListaDePreciosItem lpi = new ListaDePreciosItem(rowPLP.IdProducto, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, rowPLP.ModoDeAplicacion, row.Coeficiente, rowPLP.Coeficiente, producto.PrecioCosto, producto.Margen, producto.PrecioNeto, rowPLP.MaxDescuento, rowPLP.MaxDescuentoPorcentual, rowPLP.PrecioDeVentaBruto, rowPLP.PrecioDeVentaBrutoConImpuesto, "", producto, row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                    //Fin Sabrina 20100706 - Tarea 790
                    _items.Add(lpi);
                }
                else
                {
                    tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowLPPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(producto.Idproducto, row.IdListaDePrecio);
                    if (rowLPPA != null)
                    {
                        //Sabrina 20100706 - Tarea 790
                        ListaDePreciosItem lpi = new ListaDePreciosItem(producto.Idproducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "P", row.Coeficiente, rowLPPA.Coeficiente, producto.PrecioCosto, producto.Margen, producto.PrecioNeto, "NEW", producto, row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                        //Fin Sabrina 20100706 - Tarea 790
                        _items.Add(lpi);
                    }
                    else
                    {
                        //TODO AGREGAR PARA QUE BUSQUE EN LA TABLA tsh_JerarquiasListasDePreciosAplicadas y si no esta por el else esto
                        //Sabrina 20100706 - Tarea 790
                        ListaDePreciosItem lpi = new ListaDePreciosItem(producto.Idproducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "G", row.Coeficiente, row.Coeficiente, producto.PrecioCosto, producto.Margen, producto.PrecioNeto, "NEW", producto, row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                        //Fin Sabrina 20100706 - Tarea 790
                        _items.Add(lpi);
                    }
                }
            }

        }

        private void initializeItemsForEdit(Producto producto)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(producto.IdProducto, row.IdListaDePrecio);
                if (rowPLP != null)
                {
                    //Sabrina 20100706 - Tarea 790
                    ListaDePreciosItem lpi = new ListaDePreciosItem(rowPLP.IdProducto, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, rowPLP.ModoDeAplicacion, row.Coeficiente, rowPLP.Coeficiente, producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, rowPLP.MaxDescuento, rowPLP.MaxDescuentoPorcentual, rowPLP.PrecioDeVentaBruto, rowPLP.PrecioDeVentaBrutoConImpuesto, producto.ValorCotizacionPrecioDeVenta, "", row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, producto.ValorCotizacionPrecioDeCosto);
                    //Fin Sabrina 20100706 - Tarea 790
                    lpi.RowProdListaDePrecio = rowPLP;
                    _items.Add(lpi);
                }
                else
                {
                    tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowLPPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(producto.IdProducto, row.IdListaDePrecio);
                    if (rowLPPA != null)
                    {
                        //Sabrina 20100706 - Tarea 790
                        ListaDePreciosItem lpi = new ListaDePreciosItem(producto.IdProducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "P", row.Coeficiente, rowLPPA.Coeficiente, producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.ValorCotizacionPrecioDeVenta, "NEW", row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, producto.ValorCotizacionPrecioDeCosto);
                        //Fin Sabrina 20100706 - Tarea 790
                        lpi.RowProdListaDePrecioAplicada = rowLPPA;
                        _items.Add(lpi);
                    }
                    else
                    {
                        //TODO AGREGAR PARA QUE BUSQUE EN LA TABLA tsh_JerarquiasListasDePreciosAplicadas y si no esta por el else esto
                        //Sabrina 20100706 - Tarea 790
                        ListaDePreciosItem lpi = new ListaDePreciosItem(producto.IdProducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "G", row.Coeficiente, row.Coeficiente, producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.ValorCotizacionPrecioDeVenta, "NEW", row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, producto.ValorCotizacionPrecioDeCosto);
                        //Fin Sabrina 20100706 - Tarea 790
                        _items.Add(lpi);
                    }
                }
            }

        }

        //Sabrina 20100705 - Tarea 790
        private void initializeItemsForNew(Producto producto, string estado)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                //Sabrina 20100706 - Tarea 790
                ListaDePreciosItem lpi = new ListaDePreciosItem(producto.IdProducto, row.IdListaDePrecio, row.Descripcion, row.Codigo, "G", row.Coeficiente, row.Coeficiente, producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.ValorCotizacionPrecioDeVenta, estado, row.isDefault, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, producto.ValorCotizacionPrecioDeCosto);
                //Fin Sabrina 20100706 - Tarea 790
                _items.Add(lpi);
            }

        }
        //Fin Sabrina 20100705 - Tarea 790

        private static SentenciasReplicacion GenerateReplicaction()
        {
            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            return replication;

        }

        #endregion
    }


    public class ListaDePreciosItem
    {
        #region Variables privadas
        private string _idProducto = string.Empty;
        private string _idListaDePrecios = string.Empty;
        private string _descripcion = string.Empty;
        private string _codigo = string.Empty;
        private decimal _coeficienteGral = 0;
        private decimal _coeficienteProducto = 0;
        private decimal _coeficienteProductoMonedaReferencia = 0;
        private string _modoDeAplicacion = string.Empty;
        private decimal _precioDeCosto = 0;
        private decimal _mac = 0;
        private decimal _precioDeVentaNeto = 0;
        private decimal _maxDescuento = 0;
        private decimal _porcentajeMaximoDescuento = 0;
        private decimal _precioDeVentaBruto = 0;
        private decimal _precioDeVentaBrutoConImpuestos = 0;
        private decimal _valorCotizacionPrecioDeVenta = 1;
        private string _estado = string.Empty;
        private bool _isDefault = false;

        private tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow _rowProdListaDePrecioAplicada;
        private tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow _rowProdListaDePrecio;



        private tsh_ProductosEx.ControladorProductos _producto;

        //Sabrina 20100706 - Tarea 790
        private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;
        private bool _precioDeVentaAfectaMac = false;
        private decimal _valorCotizacionPrecioDeCosto = 1;
        decimal IB = 0;
        decimal SH = 0;
        //Fin Sabrina 20100706 - Tarea 790

        #endregion

        #region Constructores
        //Sabrina 20100706 - Tarea 790
        
        public ListaDePreciosItem(string IdProducto, string IdListaDePrecio, string Descripcion, string Codigo, string ModoDeAplicacion, decimal CoeficienteGral, decimal CoeficienteProducto, decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, string Estado, tsh_ProductosEx.ControladorProductos Producto, bool IsDefault, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _idProducto = IdProducto;
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficienteGral = CoeficienteGral;
            _coeficienteProducto = CoeficienteProducto;
            _precioDeCosto = PrecioDeCosto;
            _mac = MAC;
            _precioDeVentaNeto = PrecioDeVentaNeto;
            _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            _precioDeVentaBruto = PrecioDeVentaNeto + ((PrecioDeVentaNeto * CoeficienteProducto) / 100);
            _precioDeVentaBrutoConImpuestos = Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioDeVentaBruto, Producto.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, Producto.ObtenerImpuestosAAplicar());
            _valorCotizacionPrecioDeVenta = Producto.ValorCotizacionPrecioDeVenta;
            _valorCotizacionPrecioDeCosto = Producto.ValorCotizacionPrecioDeCosto;
            if (_precioDeVentaBruto != 0)
            {
                _maxDescuento = _precioDeVentaBruto - _precioDeVentaNeto;
                _porcentajeMaximoDescuento = (_precioDeVentaBruto - _precioDeVentaNeto) * 100 / _precioDeVentaBruto; ;
            }
            _estado = Estado;
            _producto = Producto;
            _isDefault = IsDefault;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
        }
         
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        public ListaDePreciosItem(string IdProducto, string IdListaDePrecio, string Descripcion, string Codigo, string ModoDeAplicacion, decimal CoeficienteGral, decimal CoeficienteProducto, decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, decimal MaxDescuento, decimal MaxDescuentoPorcentual, decimal PrecioDeVentaBruto, decimal PrecioDeVentaBrutoConImpuesto, string Estado, tsh_ProductosEx.ControladorProductos Producto, bool IsDefault, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
        {
            _idProducto = IdProducto;
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficienteGral = CoeficienteGral;
            _coeficienteProducto = CoeficienteProducto;
            _precioDeCosto = PrecioDeCosto;
            _mac = MAC;
            _precioDeVentaNeto = PrecioDeVentaNeto;
            _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            _precioDeVentaBruto = PrecioDeVentaBruto;
            _precioDeVentaBrutoConImpuestos = PrecioDeVentaBrutoConImpuesto;
            _valorCotizacionPrecioDeVenta = Producto.ValorCotizacionPrecioDeVenta;
            _valorCotizacionPrecioDeCosto = Producto.ValorCotizacionPrecioDeCosto;
            _maxDescuento = MaxDescuento;
            _porcentajeMaximoDescuento = MaxDescuentoPorcentual;
            _estado = Estado;
            _producto = Producto;
            _isDefault = IsDefault;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        //German 20111107 - Tarea 0000224
        public ListaDePreciosItem(string IdProducto, string IdListaDePrecio, string Descripcion, string Codigo, string ModoDeAplicacion, decimal CoeficienteGral, decimal CoeficienteProducto, decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, decimal ValorCotizacionPrecioDeVenta, string Estado, bool IsDefault, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, decimal ValorCotizacionPrecioDeCosto, tsh_ProductosEx.ControladorProductos Producto)
        {
            _idProducto = IdProducto;
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficienteGral = CoeficienteGral;
            _coeficienteProducto = CoeficienteProducto;
            _precioDeCosto = PrecioDeCosto;
            _mac = MAC;
            _precioDeVentaNeto = PrecioDeVentaNeto;
            _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            _precioDeVentaBruto = PrecioDeVentaNeto + ((PrecioDeVentaNeto * CoeficienteProducto) / 100);
            //German 20111107 - Tarea 0000224
            _producto = Producto;
            //System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
            //decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeVentaBruto);
            //_precioDeVentaBrutoConImpuestos = _precioDeVentaBruto + _impuestosBrutos;
            _precioDeVentaBrutoConImpuestos = Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioDeVentaBruto, Producto.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, Producto.ObtenerImpuestosAAplicar());
            //Fin German 20111107 - Tarea 0000224
             
            
            _valorCotizacionPrecioDeVenta = ValorCotizacionPrecioDeVenta;
            _valorCotizacionPrecioDeCosto = ValorCotizacionPrecioDeCosto;
            if (_precioDeVentaBruto != 0)
            {
                _maxDescuento = _precioDeVentaBruto - _precioDeVentaNeto;
                _porcentajeMaximoDescuento = (_precioDeVentaBruto - _precioDeVentaNeto) * 100 / _precioDeVentaBruto; ;
            }
            _estado = Estado;
            _isDefault = IsDefault;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
        }


        public ListaDePreciosItem(string IdProducto, string IdListaDePrecio, string Descripcion, string Codigo, string ModoDeAplicacion, decimal CoeficienteGral, decimal CoeficienteProducto, decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, decimal ValorCotizacionPrecioDeVenta, string Estado, bool IsDefault, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, decimal ValorCotizacionPrecioDeCosto)
        {
            _idProducto = IdProducto;
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficienteGral = CoeficienteGral;
            _coeficienteProducto = CoeficienteProducto;
            _precioDeCosto = PrecioDeCosto;
            _mac = MAC;
            _precioDeVentaNeto = PrecioDeVentaNeto;
            _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            _precioDeVentaBruto = PrecioDeVentaNeto + ((PrecioDeVentaNeto * CoeficienteProducto) / 100);
            System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
            decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeVentaBruto);
            _precioDeVentaBrutoConImpuestos = _precioDeVentaBruto + _impuestosBrutos;
            
            


            _valorCotizacionPrecioDeVenta = ValorCotizacionPrecioDeVenta;
            _valorCotizacionPrecioDeCosto = ValorCotizacionPrecioDeCosto;
            if (_precioDeVentaBruto != 0)
            {
                _maxDescuento = _precioDeVentaBruto - _precioDeVentaNeto;
                _porcentajeMaximoDescuento = (_precioDeVentaBruto - _precioDeVentaNeto) * 100 / _precioDeVentaBruto; ;
            }
            _estado = Estado;
            _isDefault = IsDefault;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
        }


        //Fin German 20111107 - Tarea 0000224
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        public ListaDePreciosItem(string IdProducto, string IdListaDePrecio, string Descripcion, string Codigo, string ModoDeAplicacion, decimal CoeficienteGral, decimal CoeficienteProducto, decimal PrecioDeCosto, decimal MAC, decimal PrecioDeVentaNeto, decimal MaxDescuento, decimal MaxDescuentoPorcentual, decimal PrecioDeVentaBruto, decimal PrecioDeVentaBrutoConImpuesto, decimal ValorCotizacionPrecioDeVenta, string Estado, bool IsDefault, bool TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, decimal ValorCotizacionPrecioDeCosto)
        {
            _idProducto = IdProducto;
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
            _codigo = Codigo;
            _modoDeAplicacion = ModoDeAplicacion;
            _coeficienteGral = CoeficienteGral;
            _coeficienteProducto = CoeficienteProducto;
            _precioDeCosto = PrecioDeCosto;
            _mac = MAC;
            _precioDeVentaNeto = PrecioDeVentaNeto;
            _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            _precioDeVentaBruto = PrecioDeVentaBruto;
            _precioDeVentaBrutoConImpuestos = PrecioDeVentaBrutoConImpuesto;
            _valorCotizacionPrecioDeVenta = ValorCotizacionPrecioDeVenta;
            _valorCotizacionPrecioDeCosto = ValorCotizacionPrecioDeCosto;
            _maxDescuento = MaxDescuento;
            _porcentajeMaximoDescuento = MaxDescuentoPorcentual;
            _estado = Estado;
            _isDefault = IsDefault;
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = TrasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista;
        }
        //Fin Sabrina 20100706 - Tarea 790

        #endregion

        #region Propiedades

        public tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow RowProdListaDePrecioAplicada
        {
            set { _rowProdListaDePrecioAplicada = value; }
            get { return _rowProdListaDePrecioAplicada; }
        }

        public tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow RowProdListaDePrecio
        {
            set { _rowProdListaDePrecio = value; }
            get { return _rowProdListaDePrecio; }
        }
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public string IdListaDePrecios
        {
            get { return _idListaDePrecios; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
        }
        public string Codigo
        {
            get { return _codigo; }
        }
        public decimal CoeficienteGral
        {
            get { return _coeficienteGral; }
        }
        public decimal CoeficienteProducto
        {
            get { return _coeficienteProducto; }
            set
            {
                _coeficienteProducto = value;
                _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
                PrecioDeVentaBruto = _precioDeVentaNeto + ((_precioDeVentaNeto * _coeficienteProducto) / 100);
            }
        }
        public decimal CoeficienteProductoMonedaReferencia
        {
            get { return _coeficienteProductoMonedaReferencia; }
            set
            {
                _coeficienteProductoMonedaReferencia = value;
                decimal newCoeficienteProducto = 0;
                if (_precioDeVentaNeto != 0)
                    newCoeficienteProducto = (_coeficienteProductoMonedaReferencia * 100) / _precioDeVentaNeto;
                if (_coeficienteProducto != newCoeficienteProducto)
                    CoeficienteProducto = newCoeficienteProducto;

            }
        }
        public string ModoDeAplicacion
        {
            get { return _modoDeAplicacion; }
            set { _modoDeAplicacion = value; }
        }

        //Sabrina 20100706 - Tarea 790
        /*public decimal PrecioDeCosto
        {
            get{return _precioDeCosto;}
            set
            {
                _precioDeCosto = value;
            }
        }*/

        public decimal PrecioDeCosto
        {
            get { return _precioDeCosto; }
            set
            {
                decimal PVentaNetoAnterior = PrecioDeVentaNeto;
                _precioDeCosto = value;
                _coeficienteProductoMonedaReferencia = (PrecioDeVentaNeto * _coeficienteProducto) / 100;
                if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    if (_precioDeVentaAfectaMac && PVentaNetoAnterior != 0)
                    {
                        _precioDeVentaBruto = PrecioDeVentaNeto + _coeficienteProductoMonedaReferencia;
                        _maxDescuento = _porcentajeMaximoDescuento * _precioDeVentaBruto / 100;
                        //German 20120810 - Tarea 0000370
                        if (_precioDeCosto != 0)
                            _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                        else
                            _mac = 0;
                        //Fin German 20120810 - Tarea 0000370
                    }
                    //Sabrina 20100719 - Tarea 796
                    else
                    {
                        _precioDeVentaBruto = PrecioDeVentaNeto + _coeficienteProductoMonedaReferencia;
                        _maxDescuento = _coeficienteProductoMonedaReferencia;
                        if (_precioDeVentaBruto != 0)
                            _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
                    }
                    //Fin Sabrina 20100719 - Tarea 796
                }
                else
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                            _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                        else
                            _mac = 0;
                    }
                    else //Afecta el descuento
                    {
                        _maxDescuento = _precioDeVentaBruto - PrecioDeVentaNeto;
                        if (_precioDeVentaBruto != 0)
                            _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
                        else
                            _porcentajeMaximoDescuento = 100;
                        //Sabrina 20100719 - Tarea 796
                        _coeficienteProductoMonedaReferencia = _precioDeVentaBruto - PrecioDeVentaNeto;
                        //Sabrina 20100806 - Tarea 810
                        if (PrecioDeVentaNeto != 0)
                            _coeficienteProducto = (_coeficienteProductoMonedaReferencia * 100) / PrecioDeVentaNeto;
                        else
                            _coeficienteProducto = 0;
                        //Fin Sabrina 20100806 - Tarea 810
                        //Fin Sabrina 20100719 - Tarea 796
                    }
                }

            }
        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal Mac
        {
            get{return _mac;}
            set{_mac = value;}
        }*/

        public decimal Mac
        {
            get
            {
                return _mac;
            }
            set
            {
                decimal PVentaNetoAnterior = PrecioDeVentaNeto;
                _mac = value;
                _coeficienteProductoMonedaReferencia = (PrecioDeVentaNeto * _coeficienteProducto) / 100;
                if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        _precioDeVentaBruto = PrecioDeVentaNeto + _coeficienteProductoMonedaReferencia;
                        _maxDescuento = _porcentajeMaximoDescuento * _precioDeVentaBruto / 100;
                    }
                    //Sabrina 20100719 - Tarea 796
                    else
                    {
                        _precioDeVentaBruto = PrecioDeVentaNeto + _coeficienteProductoMonedaReferencia;
                        _maxDescuento = _coeficienteProductoMonedaReferencia;
                        if (_precioDeVentaBruto != 0)
                            _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
                    }
                    //Fin Sabrina 20100719 - Tarea 796
                }
                else
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                            _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                        else
                            _mac = 0;
                    }
                    else //Afecta el descuento
                    {
                        _maxDescuento = _precioDeVentaBruto - PrecioDeVentaNeto;
                        if (_precioDeVentaBruto != 0)
                            _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
                        else
                            _porcentajeMaximoDescuento = 100;
                        //Sabrina 20100719 - Tarea 796
                        _coeficienteProductoMonedaReferencia = _precioDeVentaBruto - PrecioDeVentaNeto;
                        //Sabrina 20100806 - Tarea 810
                        if (PrecioDeVentaNeto != 0)
                            _coeficienteProducto = (_coeficienteProductoMonedaReferencia * 100) / PrecioDeVentaNeto;
                        else
                            _coeficienteProducto = 0;
                        //Fin Sabrina 20100806 - Tarea 810
                        //Fin Sabrina 20100719 - Tarea 796
                    }
                }

            }

        }

        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal PrecioDeVentaNeto
        {
            get{return _precioDeVentaNeto;}
            set
            {
                _precioDeVentaNeto = value;
                _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
                PrecioDeVentaBruto = _precioDeVentaNeto + ((_precioDeVentaNeto * _coeficienteProducto) / 100);
            }
        }*/

        public decimal PrecioDeVentaNeto
        {
            get
            {

                return (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta) + ((_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta) * (_mac + IB + SH) / 100);
            }
            set
            {
                _precioDeVentaNeto = value;
                _coeficienteProductoMonedaReferencia = (_precioDeVentaNeto * _coeficienteProducto) / 100;
            }
        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal MaxDescuento
        {
            get{return _maxDescuento;}
            set{_maxDescuento = value;}
        }*/
        public decimal MaxDescuento
        {
            get
            {
                if (_precioDeVentaAfectaMac)
                    return _maxDescuento;
                else
                {
                    if (_precioDeVentaBruto != 0)
                        return (_precioDeVentaBruto - PrecioDeVentaNeto);
                    return 0;
                }
            }
            set { _maxDescuento = value; }

        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal PorcentajeMaximoDescuento
        {
            get{return _porcentajeMaximoDescuento;}
            set{_porcentajeMaximoDescuento = value;}
        }*/
        public decimal PorcentajeMaximoDescuento
        {
            get
            {
                if (_precioDeVentaAfectaMac)
                    return _porcentajeMaximoDescuento;
                else
                {
                    if (_precioDeVentaBruto != 0)
                        return MaxDescuento * 100 / _precioDeVentaBruto;
                    return 0;
                }
            }
            set
            {
                _porcentajeMaximoDescuento = value;
                if (_precioDeVentaBruto != 0)
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        if (_precioDeCosto != 0)
                        {
                            _maxDescuento = _porcentajeMaximoDescuento * _precioDeVentaBruto / 100;
                            _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                        }
                        else
                            _mac = 0;

                    }
                }
            }


        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal PrecioDeVentaBruto
        {
            get{return _precioDeVentaBruto;}
            set
            {
                _precioDeVentaBruto = value;
                if(_producto != null)
                    PrecioDeVentaBrutoConImpuestos = Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioDeVentaBruto,_producto.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, _producto.ObtenerImpuestosAAplicar());
                else
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, _idProducto );                 
                    decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas, _precioDeVentaBruto);
                    PrecioDeVentaBrutoConImpuestos = _precioDeVentaBruto +_impuestosBrutos; 

                }

                if (_precioDeVentaBruto != 0)
                {						
                    PorcentajeMaximoDescuento = ((_precioDeVentaBruto - _precioDeVentaNeto)*100)/_precioDeVentaBruto;
                    MaxDescuento =(_precioDeVentaBruto - _precioDeVentaNeto);
                }
            }
        }*/

        public decimal PrecioDeVentaBruto
        {
            get
            {

                return _precioDeVentaBruto; ;
            }
            set
            {

                _precioDeVentaBruto = value;
                if (_precioDeVentaAfectaMac)
                {
                    if (_precioDeCosto != 0)
                    {
                        _maxDescuento = _porcentajeMaximoDescuento * _precioDeVentaBruto / 100;
                        _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                    }
                    else
                        _mac = 0;
                }
            }
        }
        //Fin Sabrina 20100706 - Tarea 790

        //Sabrina 20100706 - Tarea 790
        /*public decimal PrecioDeVentaBrutoConImpuestos
        {
            get{return _precioDeVentaBrutoConImpuestos;}
            set{_precioDeVentaBrutoConImpuestos = value;}
        }*/
        public decimal PrecioDeVentaBrutoConImpuestos
        {
            get
            {
                if (_producto != null)
                    _precioDeVentaBrutoConImpuestos = Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioDeVentaBruto, _producto.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, _producto.ObtenerImpuestosAAplicar());
                else
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                    decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, _precioDeVentaBruto);
                    _precioDeVentaBrutoConImpuestos = _precioDeVentaBruto + _impuestosBrutos;

                }
                return _precioDeVentaBrutoConImpuestos;
            }
            //German 20101025 - Tarea 880
            set
            {
                _precioDeVentaBrutoConImpuestos = value;
                if (_producto != null)
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(_producto.ObtenerImpuestosAAplicar());
                    PrecioDeVentaBruto = FuncionesImpuestos.CalcularInversa(formulas, value);

                }
                else
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                    PrecioDeVentaBruto = FuncionesImpuestos.CalcularInversa(formulas, value);
                }
            }
            //Fin German 20101025 - Tarea 880
        }
        //Fin Sabrina 20100706 - Tarea 790

        public decimal PrecioDeVentaBrutoConImpuestosMonedaReferencia
        {
            get
            {
                return PrecioDeVentaBrutoConImpuestos * _valorCotizacionPrecioDeVenta;
            }
            set
            {
                PrecioDeVentaBrutoConImpuestos = value * (1 / _valorCotizacionPrecioDeVenta);
            }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public decimal ValorCotizacionPrecioDeVenta
        {
            get { return _valorCotizacionPrecioDeVenta; }
            set { _valorCotizacionPrecioDeVenta = value; }
        }

        public tsh_ProductosEx.ControladorProductos Producto
        {
            get { return _producto; }
        }

        public bool IsDefault
        {
            get { return _isDefault; }
        }

        //Sabrina 20100706 - Tarea 790
        public bool PrecioDeVentaAfectaMac
        {
            get { return _precioDeVentaAfectaMac; }
            set
            {
                _precioDeVentaAfectaMac = value;
            }
        }

        public decimal ValorCotizacionPrecioDeCosto
        {
            get { return _valorCotizacionPrecioDeCosto; }
            set { _valorCotizacionPrecioDeCosto = value; }
        }
        //Fin Sabrina 20100706 - Tarea 790
        #endregion

        #region Métodos Públicos

        //German 20101123 - Tarea 923
        public void ImpuestosChanged()
        {
            if (this._estado.Equals(""))
            {
                this._estado = "MODIF_ALL";

            }

        }
        //Fin German 20101123 - Tarea 923

        //Sabrina: Tarea 834. 20101004
        public void SetPrecioDeCosto(decimal PrecioDeCosto)
        {
            _precioDeCosto = PrecioDeCosto;
        }

        public void SetMac(decimal MAC)
        {
            _mac = MAC;
        }

        //German 20101025 - Tarea 880

        public void CalcularPrecioDeVentaConImpuestos()
        {
            if (_producto != null)
                _precioDeVentaBrutoConImpuestos = Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioDeVentaBruto, _producto.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, _producto.ObtenerImpuestosAAplicar());
        }

        //Fin German 20101025 - Tarea 880

        public void CalcularPreciosAfectadosNoTraslada()
        {
            _coeficienteProductoMonedaReferencia = (PrecioDeVentaNeto * _coeficienteProducto) / 100;
            if (_precioDeVentaAfectaMac)
            {
                if (_precioDeCosto != 0)
                    _mac = ((((_precioDeVentaBruto - _maxDescuento) - (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) * 100) / (_precioDeCosto * ValorCotizacionPrecioDeCosto / ValorCotizacionPrecioDeVenta)) - IB - SH;
                else
                    _mac = 0;
            }
            else //Afecta el descuento
            {
                _maxDescuento = _precioDeVentaBruto - PrecioDeVentaNeto;
                if (_precioDeVentaBruto != 0)
                    _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
                else
                    _porcentajeMaximoDescuento = 100;
                _coeficienteProductoMonedaReferencia = _precioDeVentaBruto - PrecioDeVentaNeto;
                if (PrecioDeVentaNeto != 0)
                    _coeficienteProducto = (_coeficienteProductoMonedaReferencia * 100) / PrecioDeVentaNeto;
                else
                    _coeficienteProducto = 0;
            }
        }

        public void CalcularPreciosAfectadosTraslada(ModificarPreciosMasivo.Afecta af, decimal PVentaNetoAnterior, decimal PrecioLista, decimal PrecioDeVentaNeto)
        {
            switch (af)
            {
                case ModificarPreciosMasivo.Afecta.PrecioDeLista:
                    {
                        this.TransladarIncremento(PVentaNetoAnterior);
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugerido:
                    {
                        this.IgualarANuevoPVS();
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido:
                    {
                        if (PrecioLista < PrecioDeVentaNeto)
                            this.IgualarANuevoPVS();
                    }
                    break;
                case ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido:
                    {
                        if (PrecioLista < PrecioDeVentaNeto)
                            this.TransladarIncremento(PVentaNetoAnterior);
                    }
                    break;
                default: break;
            }

        }

        public void TransladarIncremento(decimal PVentaNetoAnterior)
        {
            _precioDeVentaBruto = PrecioDeVentaNeto + _coeficienteProductoMonedaReferencia;
            if (_precioDeVentaAfectaMac && PVentaNetoAnterior != 0)
            {
                _maxDescuento = _porcentajeMaximoDescuento * _precioDeVentaBruto / 100;
            }
            else
            {
                _maxDescuento = _coeficienteProductoMonedaReferencia;
                if (_precioDeVentaBruto != 0)
                    _porcentajeMaximoDescuento = _maxDescuento * 100 / _precioDeVentaBruto;
            }
        }

        public void IgualarANuevoPVS()
        {
            _precioDeVentaBruto = PrecioDeVentaNeto;
            _porcentajeMaximoDescuento = 0;
            _maxDescuento = 0;
        }

        public ListaDePreciosItem ShallowClone()
        {
            return (ListaDePreciosItem)this.MemberwiseClone();
        }
        //Fin Sabrina: Tarea 834. 20101004

        public decimal GetCoeficienteFromCoeficienteMonedaRef(decimal CoeficienteProductoMonedaReferencia)
        {
            decimal newCoeficienteProducto = 0;
            if (_precioDeVentaNeto != 0)
                newCoeficienteProducto = (CoeficienteProductoMonedaReferencia * 100) / _precioDeVentaNeto;
            return newCoeficienteProducto;
        }

        public decimal GetCoeficienteFromPrecioVentaBruto(decimal PrecioVentaBruto)
        {
            decimal newCoeficienteProducto = 0;
            if (_precioDeVentaNeto != 0)
                newCoeficienteProducto = ((PrecioVentaBruto - _precioDeVentaNeto) * 100) / _precioDeVentaNeto;
            return newCoeficienteProducto;
        }


        //German 20101025 - tarea 880
        public decimal GetCoeficienteFromPrecioVentaBrutoConImp(decimal PrecioVentaBrutoConImpuestos)
        {
            decimal newCoeficienteProducto = 0;
            decimal precioVentaBruto = 0;
            if (_precioDeVentaNeto != 0)
            {
                if (_producto != null)
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(_producto.ObtenerImpuestosAAplicar());
                    precioVentaBruto = FuncionesImpuestos.CalcularInversa(formulas, PrecioVentaBrutoConImpuestos);
                }
                else
                {
                    System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, _idProducto);
                    precioVentaBruto = FuncionesImpuestos.CalcularInversa(formulas, PrecioVentaBrutoConImpuestos);
                }
                newCoeficienteProducto = GetCoeficienteFromPrecioVentaBruto(precioVentaBruto);
            }
            return newCoeficienteProducto;
        }
        //Fin German 20101025 - tarea 880

        public decimal GetCoeficienteFromPrecioVentaBrutoConImpMonedaRef(decimal PrecioVentaBrutoConImpuestosMonedaRef)
        {
            decimal newCoeficienteProducto = 0;
            if (_precioDeVentaNeto != 0)
            {
                decimal precioDeVtaBrutoConImp = PrecioVentaBrutoConImpuestosMonedaRef / _valorCotizacionPrecioDeVenta;
                newCoeficienteProducto = GetCoeficienteFromPrecioVentaBrutoConImp(precioDeVtaBrutoConImp);
            }
            return newCoeficienteProducto;
        }

        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
        {
            switch (_estado)
            {
                case "NEW": //Nuevo lista de precios para el producto
                    {
                        tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowPLP = data.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
                        rowPLP.IdProducto = this.IdProducto;
                        rowPLP.IdListaDePrecio = this.IdListaDePrecios;
                        rowPLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowPLP.Coeficiente = this.CoeficienteProducto;
                        rowPLP.MaxDescuento = this.MaxDescuento;
                        rowPLP.MaxDescuentoPorcentual = this.PorcentajeMaximoDescuento;
                        rowPLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowPLP.PrecioDeVentaBrutoConImpuesto = this.PrecioDeVentaBrutoConImpuestos;
                        rowPLP.FechaCreacion = DateTime.Now;
                        rowPLP.IdConexionCreacion = Security.IdConexion;
                        rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
                        rowPLP.IdReservado = 0;
                        rowPLP.RowId = Guid.Empty;
                        rowPLP.IdEmpresa = Security.IdEmpresa;
                        rowPLP.IdSucursal = Security.IdSucursal;
                        data.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);

                        if (this.ModoDeAplicacion.Equals("P")) // Agrego en la tabla tsh_ProductosListasDePreciosAplicadas
                        {
                            tsh_ProductosExDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = data.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                            rowPLPA.IdProducto = this.IdProducto;
                            rowPLPA.IdListaDePrecio = this.IdListaDePrecios;
                            rowPLPA.Coeficiente = this.CoeficienteProducto;
                            rowPLPA.FechaCreacion = DateTime.Now;
                            rowPLPA.IdConexionCreacion = Security.IdConexion;
                            rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                            rowPLPA.IdReservado = 0;
                            rowPLPA.RowId = Guid.Empty;
                            rowPLPA.IdEmpresa = Security.IdEmpresa;
                            rowPLPA.IdSucursal = Security.IdSucursal;
                            data.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);
                        }
                        break;

                    }
                case "MODIF_PLP": //Modificacion de Lista de precios producto 
                    {
                        tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        rowPLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowPLP.Coeficiente = this.CoeficienteProducto;
                        rowPLP.MaxDescuento = this.MaxDescuento;
                        rowPLP.MaxDescuentoPorcentual = this.PorcentajeMaximoDescuento;
                        if (rowPLP.PrecioDeVentaBruto != this.PrecioDeVentaBruto)
                            rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowPLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowPLP.PrecioDeVentaBrutoConImpuesto = this.PrecioDeVentaBrutoConImpuestos;
                        data.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                        break;
                    }
                case "NEW_PLPA_MODIF_PLP": //Modificacion de Lista de precios producto y adicion de lista de precios de productos aplicada
                    {
                        tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        rowPLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowPLP.Coeficiente = this.CoeficienteProducto;
                        rowPLP.MaxDescuento = this.MaxDescuento;
                        rowPLP.MaxDescuentoPorcentual = this.PorcentajeMaximoDescuento;
                        if (rowPLP.PrecioDeVentaBruto != this.PrecioDeVentaBruto)
                            rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowPLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowPLP.PrecioDeVentaBrutoConImpuesto = this.PrecioDeVentaBrutoConImpuestos;
                        data.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                        tsh_ProductosExDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = data.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                        rowPLPA.IdProducto = this.IdProducto;
                        rowPLPA.IdListaDePrecio = this.IdListaDePrecios;
                        rowPLPA.Coeficiente = this.CoeficienteProducto;
                        rowPLPA.FechaCreacion = DateTime.Now;
                        rowPLPA.IdConexionCreacion = Security.IdConexion;
                        rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                        rowPLPA.IdReservado = 0;
                        rowPLPA.RowId = Guid.Empty;
                        rowPLPA.IdEmpresa = Security.IdEmpresa;
                        rowPLPA.IdSucursal = Security.IdSucursal;
                        data.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);

                        break;
                    }
                case "MODIF_ALL": //Modificacion de Lista de precios producto y lista de precios producto aplicada
                    {
                        tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        rowPLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowPLP.Coeficiente = this.CoeficienteProducto;
                        rowPLP.MaxDescuento = this.MaxDescuento;
                        rowPLP.MaxDescuentoPorcentual = this.PorcentajeMaximoDescuento;
                        if (rowPLP.PrecioDeVentaBruto != this.PrecioDeVentaBruto)
                            rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowPLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowPLP.PrecioDeVentaBrutoConImpuesto = this.PrecioDeVentaBrutoConImpuestos;
                        data.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                        tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        if (rowPLPA == null)
                        {
                            tsh_ProductosExDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA2 = data.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                            rowPLPA2.IdProducto = this.IdProducto;
                            rowPLPA2.IdListaDePrecio = this.IdListaDePrecios;
                            rowPLPA2.Coeficiente = this.CoeficienteProducto;
                            rowPLPA2.FechaCreacion = DateTime.Now;
                            rowPLPA2.IdConexionCreacion = Security.IdConexion;
                            rowPLPA2.IdConexionUltimaModificacion = Security.IdConexion;
                            rowPLPA2.IdReservado = 0;
                            rowPLPA2.RowId = Guid.Empty;
                            rowPLPA2.IdEmpresa = Security.IdEmpresa;
                            rowPLPA2.IdSucursal = Security.IdSucursal;
                            data.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA2);
                        }
                        else
                        {
                            rowPLPA.Coeficiente = this.CoeficienteProducto;
                            data.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);
                        }
                        break;
                    }

                case "DEL": //Borrado de lista de precios de producto aplicado y modificacion de lista de precios de producto
                    {
                        tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        rowPLPA.Delete();
                        data.tsh_ProductosListasDePreciosAplicadas.ImportRow(rowPLPA);

                        tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(this.IdProducto, this.IdListaDePrecios);
                        rowPLP.ModoDeAplicacion = this.ModoDeAplicacion;
                        rowPLP.Coeficiente = this.CoeficienteProducto;
                        rowPLP.MaxDescuento = this.MaxDescuento;
                        rowPLP.MaxDescuentoPorcentual = this.PorcentajeMaximoDescuento;
                        if (rowPLP.PrecioDeVentaBruto != this.PrecioDeVentaBruto)
                            rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                        rowPLP.PrecioDeVentaBruto = this.PrecioDeVentaBruto;
                        rowPLP.PrecioDeVentaBrutoConImpuesto = this.PrecioDeVentaBrutoConImpuestos;
                        data.tsh_ProductosListasDePrecios.ImportRow(rowPLP);

                        break;
                    }
                default:
                    break;

            }
            return data;

        }

        #endregion

        #region Métodos Privados
        #endregion
    }


    public class CostosIndirectos : CollectionBase
    {
        #region Variables Privadas
        // : (IList) List
        private string _idProducto = string.Empty;
        private string _state = string.Empty;
        private tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow _rowPca = null;
        private tsh_ProductosCoeficientesAplicadosDataset _dataPca = new tsh_ProductosCoeficientesAplicadosDataset();
        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow RowPca
        {
            get { return _rowPca; }
            set { _rowPca = value; }
        }

        public tsh_ProductosCoeficientesAplicadosDataset DataPca
        {
            get { return _dataPca; }
            set { _dataPca = value; }
        }

        #endregion

        #region Constructores
        public CostosIndirectos(string IdProducto, string estado)
        {
            //tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow _rowPca = tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow();
            this.IdProducto = IdProducto;
            if (estado.Equals("NEW"))
                InitializeItemsForNew(IdProducto);
            else
                InitializeItemsForEdit(IdProducto);
        }
        #endregion

        #region Metodos Privados
        private void InitializeItemsForNew(string IdProducto)
        {
            this._state = "NEW";
            this.RowPca = _dataPca.tsh_ProductosCoeficientesAplicados.Newtsh_ProductosCoeficientesAplicadosRow();
            mz.erp.businessrules.tsh_ProductosCoeficientesAplicados.SetRowDefaultValues(RowPca);
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
            {
                CostosIndirectosItem cii = new CostosIndirectosItem(this, row);
                List.Add(cii);
            }

        }

        private void InitializeItemsForEdit(string IdProducto)
        {

            this.RowPca = tsh_ProductosCoeficientesAplicados.GetByPk(IdProducto);
            if (RowPca != null)
            {
                this._state = "EDIT";
                foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
                {
                    CostosIndirectosItem cii = new CostosIndirectosItem(this, row, RowPca);
                    List.Add(cii);
                }
            }
        }

        private static SentenciasReplicacion GenerateReplicaction()
        {
            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            return replication;
        }

        #endregion

        #region Metodos Publicos
        public decimal GetCoeficienteValor(long indice, decimal precio, CotizacionWrapper cotizacionPpc)
        {
            string _IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
            // obtengo el valor del coeficiente desde el producto
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (item.Tipo) && (item.Activo)) // item.Tipo == true --> Moneda; false --> porcentaje
                {
                    Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(item.IdMoneda, _IdMonedaReferencia, item.IdFuenteDeCambio);
                    return item.Valor * cot.Valor / cotizacionPpc.Valor;
                }
                else if ((item.Orden == indice) && (!item.Tipo) && (item.Activo))
                {
                    Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(item.IdMoneda, _IdMonedaReferencia, item.IdFuenteDeCambio);
                    return precio * item.Valor / 100;
                }
                else if ((item.Orden == indice) && (!item.Activo))
                    return 0;
            }
            // obtengo el valor del coeficiente desde la tabla de definicion de coeficientes
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
            {
                if ((row.Orden == indice) && (row.Tipo) && (row.Activo)) // item.Tipo == true --> Moneda; false --> porcentaje
                {
                    Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(row.IdMoneda, _IdMonedaReferencia, row.IdFuenteDeCambio);
                    return row.Valor * cot.Valor / cotizacionPpc.Valor;
                }
                else if ((row.Orden == indice) && (!row.Tipo) && (row.Activo))
                    return precio * row.Valor / 100;
            }
            return 0;
        }

        //Matias 20100722 - Tarea 78
        public void SetCoeficienteValor(long indice, decimal nuevoValor, decimal precioDeCostoDirecto, CotizacionWrapper cotizacionPpc)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (item.Tipo) && (item.Activo))
                {
                    // Costo Indirecto de Tipo Moneda, seteo de monto directo.
                    // lo guarda en la moneda del costoIndirecto
                    string _IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
                    Cotizacion cotItem = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(item.IdMoneda, _IdMonedaReferencia, item.IdFuenteDeCambio);
                    item.Valor = nuevoValor * cotizacionPpc.Valor / cotItem.Valor;

                }
                else if ((item.Orden == indice) && (!item.Tipo) && (item.Activo))
                {
                    // Costo Indirecto de Tipo Porcentaje, se calculo el monto en base al porcentaje ingresado.
                    if (precioDeCostoDirecto != 0) //Matias 20100722 - Tarea 78
                        // Calcular el % en base al monto ingresado.
                        item.Valor = nuevoValor * 100 / precioDeCostoDirecto;
                }
            }
        }
        //Fin Matias 20100722 - Tarea 78

        public decimal GetCoeficientePorc(int indice)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (!item.Tipo) && (item.Activo)) // item.Tipo = porcentaje
                {
                    return item.Valor;
                }
                else if ((item.Orden == indice) && (!item.Tipo) && (!item.Activo))
                {
                    return 0;
                }

            }
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
            {
                if ((row.Orden == indice) && (!row.Tipo) && (row.Activo))
                    return row.Valor;
            }
            return 0;
        }

        public decimal GetCoeficientePorc(int indice, decimal pcpp) // Usado para guardar en tsh_ProductosAuxiliares
        {


            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (!item.Tipo) && (item.Activo)) // item.Tipo = porcentaje
                {
                    return item.Valor;
                }
                else if ((item.Orden == indice) && (item.Tipo) && (item.Activo)) // item.Tipo = Moneda
                {
                    if (pcpp != 0)
                        return item.Valor * 100 / pcpp;
                    else return 0;
                }
                else if ((item.Orden == indice) && (!item.Tipo) && (!item.Activo))
                {
                    return 0;
                }
            }
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
            {
                if ((row.Orden == indice) && (!row.Tipo) && (row.Activo))
                {
                    return row.Valor;
                }
                else if ((row.Orden == indice) && (row.Tipo) && (row.Activo))
                {
                    if (pcpp != 0)
                        return row.Valor * 100 / pcpp;
                    else return 0;
                }
            }
            return 0;
        }

        public void SetCoeficientePorc(int indice, decimal nuevoValor)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (!item.Tipo) && (item.Activo))
                {
                    item.Valor = nuevoValor;
                    break;
                }
                /*else if ( (item.Orden == indice) && (item.Tipo) && (item.Activo) )
                {
                    Recalcular el costo; activar el dataBinding para el $
                    item.Valor = nuevoValor;
                }*/
            }
        }

        public decimal GetCoeficienteValorTotal(decimal precio, CotizacionWrapper cotizacionPpc)
        {
            decimal total = 0;
            foreach (CostosIndirectosItem item in List)
            {
                total += this.GetCoeficienteValor(item.Orden, precio, cotizacionPpc);
            }
            return total;
        }

        public string GetCoeficienteDescripcion(long indice)
        {
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
            {
                if (row.Orden == indice)
                    return row.Descripcion;
            }
            return "";
        }

        public bool GetCoeficienteActivo(long indice)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if (item.Orden == indice)
                    return item.Activo;
            }
            return false;
        }

        public void ActivarCostoIndirecto(long indice, bool valor)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice))
                {
                    item.Activo = valor;
                    break;
                }
            }
        }

        public bool GetCoeficienteTipo(long indice)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if (item.Orden == indice)
                    return item.Tipo;
            }
            return false;
        }

        public bool CoeficienteCreadoyActivo(long indice)
        {
            foreach (CostosIndirectosItem item in List)
            {
                if ((item.Orden == indice) && (item.ActivoPorDefinicion))
                    return true;
                else if ((item.Orden == indice) && (!item.ActivoPorDefinicion))
                    return false;
            }
            return false;
        }


        public void Commit()
        {
            foreach (CostosIndirectosItem item in List)
            {
                item.Commit(item.Orden, RowPca);
            }
            if (_state == "EDIT")
                DataPca.tsh_ProductosCoeficientesAplicados.ImportRow(RowPca);
            else
            {
                RowPca.IdProducto = this.IdProducto;
                DataPca.tsh_ProductosCoeficientesAplicados.Addtsh_ProductosCoeficientesAplicadosRow(RowPca);
            }
        }

        public void Flush(string IdTransaction)
        {
            SentenciasReplicacion _replicacion = GenerateReplicaction();
            SqlTransaction trx = mz.erp.dataaccess.PoolTransaction.GetTransactionById(IdTransaction);
            mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.Update(this.DataPca.tsh_ProductosCoeficientesAplicados, trx/*, _replicacion*/);
        }

        #endregion

    }


    public class CostosIndirectosItem
    {
        #region Variables privadas
        private CostosIndirectos _parent = null;
        private string _descripcion = string.Empty;
        private string _idCoeficienteCostoIndirecto = string.Empty;
        private decimal _valor = 0;
        private bool _tipo;
        private string _idMoneda = string.Empty;
        private string _idFuenteDeCambio = string.Empty;
        private long _orden = 0;
        private bool _activo = false;
        private bool _activoPorDeficion = false;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string IdCoeficienteCostoIndirecto
        {
            get { return _idCoeficienteCostoIndirecto; }
            set { _idCoeficienteCostoIndirecto = value; }
        }

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public bool Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string IdMoneda
        {
            get { return _idMoneda; }
            set { _idMoneda = value; }
        }

        public string IdFuenteDeCambio
        {
            get { return _idFuenteDeCambio; }
            set { _idFuenteDeCambio = value; }
        }

        public long Orden
        {
            get { return _orden; }
            set { _orden = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set
            {
                _activo = value;
                if (_activo)
                {
                    this.IdCoeficienteCostoIndirecto = CostosIndirectosLoader.GetIdCoeficienteCostoIndirecto(Orden);
                    if (this.Valor == 0)
                    {
                        this.Valor = CostosIndirectosLoader.GetValor(IdCoeficienteCostoIndirecto);
                    }
                }
                else
                {
                    this.IdCoeficienteCostoIndirecto = string.Empty;
                    this.Valor = 0;
                }
            }
        }

        public bool ActivoPorDefinicion
        {
            get { return _activoPorDeficion; }
            set
            {
                _activoPorDeficion = value;
            }
        }


        #endregion

        #region Metodos Publicos

        // NEW
        public CostosIndirectosItem(CostosIndirectos parent, tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow rowCci)
        {
            this._parent = parent;
            if (rowCci != null)
            {
                Descripcion = rowCci.Descripcion;
                Tipo = rowCci.Tipo;
                IdMoneda = rowCci.IdMoneda;
                IdFuenteDeCambio = rowCci.IdFuenteDeCambio;
                Orden = rowCci.Orden;
                ActivoPorDefinicion = rowCci.Activo;
                IdCoeficienteCostoIndirecto = rowCci.IdCoeficienteCostoIndirecto;
                Valor = rowCci.Valor;
                Activo = false;
            }

        }

        // EDIT
        public CostosIndirectosItem(CostosIndirectos parent, tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow rowCci, tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow rowPca)
        {
            this._parent = parent;
            if (rowCci != null)
            {
                Descripcion = rowCci.Descripcion;
                Tipo = rowCci.Tipo;
                IdMoneda = rowCci.IdMoneda;
                IdFuenteDeCambio = rowCci.IdFuenteDeCambio;
                Orden = rowCci.Orden;
                Activo = false;
                ActivoPorDefinicion = rowCci.Activo;
                switch (Orden)
                {
                    case 1:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto1;
                        Valor = rowPca.Valor1;
                        if ((rowPca.IdCoeficienteCostoIndirecto1 != null) && (!rowPca.IdCoeficienteCostoIndirecto1.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 2:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto2;
                        Valor = rowPca.Valor2;
                        if ((rowPca.IdCoeficienteCostoIndirecto2 != null) && (!rowPca.IdCoeficienteCostoIndirecto2.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 3:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto3;
                        Valor = rowPca.Valor3;
                        if ((rowPca.IdCoeficienteCostoIndirecto3 != null) && (!rowPca.IdCoeficienteCostoIndirecto3.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 4:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto4;
                        Valor = rowPca.Valor4;
                        if ((rowPca.IdCoeficienteCostoIndirecto4 != null) && (!rowPca.IdCoeficienteCostoIndirecto4.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 5:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto5;
                        Valor = rowPca.Valor5;
                        if ((rowPca.IdCoeficienteCostoIndirecto5 != null) && (!rowPca.IdCoeficienteCostoIndirecto5.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 6:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto6;
                        Valor = rowPca.Valor6;
                        if ((rowPca.IdCoeficienteCostoIndirecto6 != null) && (!rowPca.IdCoeficienteCostoIndirecto6.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 7:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto7;
                        Valor = rowPca.Valor7;
                        if ((rowPca.IdCoeficienteCostoIndirecto7 != null) && (!rowPca.IdCoeficienteCostoIndirecto7.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 8:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto8;
                        Valor = rowPca.Valor8;
                        if ((rowPca.IdCoeficienteCostoIndirecto8 != null) && (!rowPca.IdCoeficienteCostoIndirecto8.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 9:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto9;
                        Valor = rowPca.Valor9;
                        if ((rowPca.IdCoeficienteCostoIndirecto9 != null) && (!rowPca.IdCoeficienteCostoIndirecto9.Equals(string.Empty)))
                            Activo = true;
                        break;
                    case 10:
                        IdCoeficienteCostoIndirecto = rowPca.IdCoeficienteCostoIndirecto10;
                        Valor = rowPca.Valor10;
                        if ((rowPca.IdCoeficienteCostoIndirecto10 != null) && (!rowPca.IdCoeficienteCostoIndirecto10.Equals(string.Empty)))
                            Activo = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Activar()
        {
            this.Activo = true;
        }

        public void Desactivar()
        {
            this.Activo = false;
        }

        public void Commit(long orden, tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow rowPca)
        {
            switch (orden)
            {
                case 1:
                    rowPca.IdCoeficienteCostoIndirecto1 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor1 = this.Valor;
                    break;
                case 2:
                    rowPca.IdCoeficienteCostoIndirecto2 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor2 = this.Valor;
                    break;
                case 3:
                    rowPca.IdCoeficienteCostoIndirecto3 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor3 = this.Valor;
                    break;
                case 4:
                    rowPca.IdCoeficienteCostoIndirecto4 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor4 = this.Valor;
                    break;
                case 5:
                    rowPca.IdCoeficienteCostoIndirecto5 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor5 = this.Valor;
                    break;
                case 6:
                    rowPca.IdCoeficienteCostoIndirecto6 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor6 = this.Valor;
                    break;
                case 7:
                    rowPca.IdCoeficienteCostoIndirecto7 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor7 = this.Valor;
                    break;
                case 8:
                    rowPca.IdCoeficienteCostoIndirecto8 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor8 = this.Valor;
                    break;
                case 9:
                    rowPca.IdCoeficienteCostoIndirecto9 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor9 = this.Valor;
                    break;
                case 10:
                    rowPca.IdCoeficienteCostoIndirecto10 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor10 = this.Valor;
                    break;
                default:
                    break;
            }
            //dataPca.tsh_ProductosCoeficientesAplicados.ImportRow(rowPca);
        }


        public void Commit(long orden, tsh_ProductosExDataset.tsh_ProductosCoeficientesAplicadosRow rowPca)
        {
            switch (orden)
            {
                case 1:
                    rowPca.IdCoeficienteCostoIndirecto1 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor1 = this.Valor;
                    break;
                case 2:
                    rowPca.IdCoeficienteCostoIndirecto2 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor2 = this.Valor;
                    break;
                case 3:
                    rowPca.IdCoeficienteCostoIndirecto3 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor3 = this.Valor;
                    break;
                case 4:
                    rowPca.IdCoeficienteCostoIndirecto4 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor4 = this.Valor;
                    break;
                case 5:
                    rowPca.IdCoeficienteCostoIndirecto5 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor5 = this.Valor;
                    break;
                case 6:
                    rowPca.IdCoeficienteCostoIndirecto6 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor6 = this.Valor;
                    break;
                case 7:
                    rowPca.IdCoeficienteCostoIndirecto7 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor7 = this.Valor;
                    break;
                case 8:
                    rowPca.IdCoeficienteCostoIndirecto8 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor8 = this.Valor;
                    break;
                case 9:
                    rowPca.IdCoeficienteCostoIndirecto9 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor9 = this.Valor;
                    break;
                case 10:
                    rowPca.IdCoeficienteCostoIndirecto10 = this.IdCoeficienteCostoIndirecto;
                    rowPca.Valor10 = this.Valor;
                    break;
                default:
                    break;
            }
            //dataPca.tsh_ProductosCoeficientesAplicados.ImportRow(rowPca);
        }

        #endregion


    }

    public class CostosIndirectosLoader
    {
        /// <summary>
        /// Clase estatica que carga la definicion de la tabla tsh_CoeficientesCostosIndirectos
        /// Emula un Singleton para reducir los accesos a la Base, accede solo una vez.
        /// </summary>
        /// 
        public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable _dataCoeficientesTable = null;
        public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable Load()
        {
            if (_dataCoeficientesTable == null)
            {
                _dataCoeficientesTable = mz.erp.businessrules.tsh_CoeficientesCostosIndirectos.GetList().tsh_CoeficientesCostosIndirectos;
            }
            return _dataCoeficientesTable;
        }

        # region Metodos publicos
        public static void Reset()
        {
            _dataCoeficientesTable = null;
        }

        public static string GetIdCoeficienteCostoIndirecto(long orden)
        {
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in _dataCoeficientesTable.Rows)
            {
                if (row.Orden == orden)
                    return row.IdCoeficienteCostoIndirecto;
            }
            return string.Empty;
        }

        public static decimal GetValor(string idCoeficiente)
        {
            foreach (tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in _dataCoeficientesTable.Rows)
            {
                if (row.IdCoeficienteCostoIndirecto == idCoeficiente)
                    return row.Valor;
            }
            return 0;
        }


        #endregion

    }

    public class ProductosJerarquias
    {
        #region Variables privadas
        private string _idProducto = string.Empty;
        private bool _activo = true;
        #endregion

        #region Constructores
        public ProductosJerarquias()
        {
        }

        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private string _idNomenclatura1a = string.Empty;
        public string IdNomenclatura1a
        {
            get { return _idNomenclatura1a; }
            set { _idNomenclatura1a = value; }
        }

        private string _idNomenclatura1b = string.Empty;
        public string IdNomenclatura1b
        {
            get { return _idNomenclatura1b; }
            set { _idNomenclatura1b = value; }
        }

        private string _idNomenclatura2a = string.Empty;
        public string IdNomenclatura2a
        {
            get { return _idNomenclatura2a; }
            set { _idNomenclatura2a = value; }
        }

        private string _idNomenclatura2b = string.Empty;
        public string IdNomenclatura2b
        {
            get { return _idNomenclatura2b; }
            set { _idNomenclatura2b = value; }
        }

        private string _idNomenclatura3a = string.Empty;
        public string IdNomenclatura3a
        {
            get { return _idNomenclatura3a; }
            set { _idNomenclatura3a = value; }
        }

        private string _idNomenclatura3b = string.Empty;
        public string IdNomenclatura3b
        {
            get { return _idNomenclatura3b; }
            set { _idNomenclatura3b = value; }
        }

        private string _idNomenclatura4a = string.Empty;
        public string IdNomenclatura4a
        {
            get { return _idNomenclatura4a; }
            set { _idNomenclatura4a = value; }
        }

        private string _idNomenclatura4b = string.Empty;
        public string IdNomenclatura4b
        {
            get { return _idNomenclatura4b; }
            set { _idNomenclatura4b = value; }
        }

        private string _idNomenclatura5a = string.Empty;
        public string IdNomenclatura5a
        {
            get { return _idNomenclatura5a; }
            set { _idNomenclatura5a = value; }
        }

        private string _idNomenclatura5b = string.Empty;
        public string IdNomenclatura5b
        {
            get { return _idNomenclatura5b; }
            set { _idNomenclatura5b = value; }
        }

        private string _idNomenclatura6a = string.Empty;
        public string IdNomenclatura6a
        {
            get { return _idNomenclatura6a; }
            set { _idNomenclatura6a = value; }
        }

        private string _idNomenclatura6b = string.Empty;
        public string IdNomenclatura6b
        {
            get { return _idNomenclatura6b; }
            set { _idNomenclatura6b = value; }
        }

        private string _idNomenclatura7a = string.Empty;
        public string IdNomenclatura7a
        {
            get { return _idNomenclatura7a; }
            set { _idNomenclatura7a = value; }
        }

        private string _idNomenclatura7b = string.Empty;
        public string IdNomenclatura7b
        {
            get { return _idNomenclatura7b; }
            set { _idNomenclatura7b = value; }
        }

        private string _idNomenclatura8a = string.Empty;
        public string IdNomenclatura8a
        {
            get { return _idNomenclatura8a; }
            set { _idNomenclatura8a = value; }
        }

        private string _idNomenclatura8b = string.Empty;
        public string IdNomenclatura8b
        {
            get { return _idNomenclatura8b; }
            set { _idNomenclatura8b = value; }
        }
        #endregion

        #region Métodos Públicos
        /*public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
		{
			//TODO

			return data;

		}*/

        #endregion

        #region Métodos Privados

        #endregion
    }
}


