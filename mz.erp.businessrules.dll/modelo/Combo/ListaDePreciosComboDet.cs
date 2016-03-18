using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.modelo.Combo
{
    public class ListaDePreciosComboDet
    {
        #region Variables privadas
        private ArrayList _items = new ArrayList();
        #endregion

        #region Constructores
        public ListaDePreciosComboDet(ComboDet ComboDet, string Estado)
		{
            if (Estado.Equals("NEW"))
                initializeItemsForNew(ComboDet, Estado);
            else
                initializeItemsForEdit(ComboDet);
        }
        #endregion

        #region Propiedades
        public ArrayList Items
        {
            get { return _items; }
            set { _items = value; }
        }

        #endregion

        #region Metodos Privados
        private void initializeItemsForNew(ComboDet ComboDet, string estado)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(ComboDet.IdProductoReferencia, row.IdListaDePrecio);
                if (rowPLP != null)
                {
                    ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, rowPLP.ModoDeAplicacion, rowPLP.Coeficiente, rowPLP.PrecioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, estado);
                    _items.Add(lpcdi);
                }
                else
                {
                    tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowLPPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(ComboDet.IdProductoReferencia, row.IdListaDePrecio);
                    if (rowLPPA != null)
                    {
                        decimal precioDeVentaBruto = ComboDet.RowProducto.PrecioDeVentaNeto + ((ComboDet.RowProducto.PrecioDeVentaNeto * rowLPPA.Coeficiente) / 100);
                        ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, "P", rowLPPA.Coeficiente, precioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, estado);
                        _items.Add(lpcdi);
                    }
                    else
                    {
                        decimal precioDeVentaBruto = ComboDet.RowProducto.PrecioDeVentaNeto + ((ComboDet.RowProducto.PrecioDeVentaNeto * row.Coeficiente) / 100);
                        ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, row.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, "G", row.Coeficiente, precioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, estado);
                        _items.Add(lpcdi);
                    }
                }
            }
        }

        private void initializeItemsForEdit(ComboDet ComboDet)
        {
            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow row in tsh_ListasDePrecios.GetList().tsh_ListasDePrecios.Rows)
            {
                tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowCDLP = tsh_CombosDetListasDePrecios.GetByPk(ComboDet.IdProducto, ComboDet.Ordinal, row.IdListaDePrecio);
                if (rowCDLP != null)
                {
                    ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, row.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, rowCDLP.ModoDeAplicacion, rowCDLP.Coeficiente, rowCDLP.PrecioDeVentaBrutoOriginal, rowCDLP.DescuentoCombo, rowCDLP.DescuentoComboPorcentual, rowCDLP.PrecioDeVentaBruto, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, string.Empty);
                    _items.Add(lpcdi);
                }
                else
                {
                    tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(ComboDet.IdProductoReferencia, row.IdListaDePrecio);
                    if (rowPLP != null)
                    {
                        ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, rowPLP.ModoDeAplicacion, rowPLP.Coeficiente, rowPLP.PrecioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, "NEW");
                        _items.Add(lpcdi);
                    }

                    else
                    {
                        tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow rowLPPA = tsh_ProductosListasDePreciosAplicadas.GetByPk(ComboDet.IdProductoReferencia, row.IdListaDePrecio);
                        if (rowLPPA != null)
                        {
                            decimal precioDeVentaBruto = ComboDet.RowProducto.PrecioDeVentaNeto + ((ComboDet.RowProducto.PrecioDeVentaNeto * rowLPPA.Coeficiente) / 100);
                            ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, rowPLP.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, "P", rowLPPA.Coeficiente, precioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, "NEW");
                            _items.Add(lpcdi);
                        }
                        else
                        {
                            decimal precioDeVentaBruto = ComboDet.RowProducto.PrecioDeVentaNeto + ((ComboDet.RowProducto.PrecioDeVentaNeto * row.Coeficiente) / 100);
                            ListaDePreciosComboDetItem lpcdi = new ListaDePreciosComboDetItem(ComboDet.IdProducto, ComboDet.Ordinal, row.IdListaDePrecio, row.Descripcion, row.Codigo, row.isDefault, "G", row.Coeficiente, precioDeVentaBruto, 0, 0, ComboDet.ValorCotizacionPrecioDeCostoRef, ComboDet.ValorCotizacionPrecioDeVentaBruto, "NEW");
                            _items.Add(lpcdi);
                        }
                    }
                }
            }

        }
        #endregion

        #region Metodos Publicos
        public ListaDePreciosComboDetItem GetItem(string IdProducto, long Ordinal, string IdListaDePrecio)
        {
            ListaDePreciosComboDetItem item = null;
            int i = 0;
            while (item == null && i < _items.Count)
            {
                ListaDePreciosComboDetItem it = (ListaDePreciosComboDetItem)_items[i];
                if (it.IdProducto.Equals(IdProducto) && it.Ordinal == Ordinal && it.IdListaDePrecio.Equals(IdListaDePrecio))
                    item = it;
                i++;
            }
            return item;
        }

        public ListaDePreciosComboDetItem GetDefaultItem()
        {
            ListaDePreciosComboDetItem item = null;
            int i = 0;
            while (item == null && i < _items.Count)
            {
                ListaDePreciosComboDetItem it = (ListaDePreciosComboDetItem)_items[i];
                if (it.IsDefault)
                    item = it;
                i++;
            }
            return item;
        }

        public void UpdateDescuentoPorcentual(string IdProducto, long Ordinal, string IdListaDePrecio, decimal DescuentoComboProcentual)
        {
            ListaDePreciosComboDetItem item = this.GetItem(IdProducto, Ordinal, IdListaDePrecio);
            item.DescuentoComboProcentual = DescuentoComboProcentual;
            if (item.Estado.Equals(""))
                item.Estado = "MODIF";
        }

        public void UpdateDescuentoPorcentual(decimal DescuentoComboProcentual)
        {
            foreach (ListaDePreciosComboDetItem item in _items)
            {
                item.DescuentoComboProcentual = DescuentoComboProcentual;
                if (item.Estado.Equals(""))
                    item.Estado = "MODIF";
            }
        }

        public tsh_ProductosExDataset Commit(tsh_ProductosExDataset data)
        {
            foreach (ListaDePreciosComboDetItem item in _items)
            {
                data = item.Commit(data);
            }

            return data;

        }
        #endregion
    }
}
