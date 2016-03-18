/* Silvina 20111104 - Tarea 0000222 */
using System;
using System.Collections.Generic;
using System.Text;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
    public class ProductosCategoriasCuentas
    {

        private string _idListaDePrecios = string.Empty;
        private string _listaDePrecios = string.Empty;
        private string _idNomenclaturaCuenta = string.Empty;
        private string _categoriaCuenta = string.Empty;
        private string _idNomenclaturaProducto = string.Empty;
        private string _categoriaProducto = string.Empty;
        private string _estado = string.Empty;

        public string IdListaDePrecios
        {
            get { return _idListaDePrecios; }
            set { _idListaDePrecios = value; }
        }

        public string ListaDePrecios
        {
            get { return _listaDePrecios; }
            set { _listaDePrecios = value; }
        }

        public string IdNomenclaturaCuenta
        {
            get { return _idNomenclaturaCuenta; }
            set { _idNomenclaturaCuenta = value; }
        }

        public string CategoriaCuenta
        {
            get { return _categoriaCuenta; }
            set { _categoriaCuenta = value; }
        }

        public string IdNomenclaturaProducto
        {
            get { return _idNomenclaturaProducto; }
            set { _idNomenclaturaProducto = value; }
        }

        public string CategoriaProducto
        {
            get { return _categoriaProducto; }
            set { _categoriaProducto = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public tsh_ProductosListasDePreciosCategoriasCuentasDataset Commit(tsh_ProductosListasDePreciosCategoriasCuentasDataset data)
        {
            switch (_estado)
            {
                case "NEW":
                    {
                        tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow rowPC = data.tsh_ProductosListasDePreciosCategoriasCuentas.Newtsh_ProductosListasDePreciosCategoriasCuentasRow();
                        tsh_ProductosListasDePreciosCategoriasCuentas.SetRowDefaultValues(rowPC);

                        rowPC.IdNomenclaturaCuenta = _idNomenclaturaCuenta;
                        rowPC.IdNomenclaturaProducto = _idNomenclaturaProducto;
                        rowPC.IdListaDePrecio = _idListaDePrecios;

                        data.tsh_ProductosListasDePreciosCategoriasCuentas.Rows.Add(rowPC);
                        break;
                    }
                case "DEL":
                    {
                        tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow rowPC = data.tsh_ProductosListasDePreciosCategoriasCuentas.FindByIdNomenclaturaCuentaIdNomenclaturaProducto(_idNomenclaturaCuenta, _idNomenclaturaProducto);
                        if (rowPC == null)
                        {
                            rowPC = mz.erp.businessrules.tsh_ProductosListasDePreciosCategoriasCuentas.GetByPk(_idNomenclaturaCuenta, _idNomenclaturaProducto);
                            rowPC.Delete();
                            data.tsh_ProductosListasDePreciosCategoriasCuentas.ImportRow(rowPC);
                        }
                        else
                            rowPC.Delete();
                        break;
                    }
                default:
                    break;
            }
            return data;

        }
    }
}
