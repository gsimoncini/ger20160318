//Matias - 20110905 - Tarea 0000131
namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;

    class tsy_AfipTiposDeImpuestosIVA : IDisposable
    {
        #region Custom Members

        #endregion

        public tsy_AfipTiposDeImpuestosIVA()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsy_AfipTiposDeImpuestosIVA
        /// </summary>
        public static tsy_AfipTiposDeImpuestosIVADataset GetList()
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.GetList();
        }

        public static DataRow GetByImpuesto(string Impuesto)
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.GetByImpuesto(Impuesto);
        }

        /// <summary>
        /// Crea un tsy_AfipTiposDeImpuestosIVARow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsy_AfipTiposDeImpuestosIVA que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow GetByPk(string Codigo)
        {
            tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow row = mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.GetByPk(Codigo);
            foreach (DataColumn dc in row.Table.Columns)
            {
                if (row[dc] == System.DBNull.Value)
                {
                    row[dc] = Util.DefaultValue(dc.DataType);
                }
            }
            return row;

        }

        /// <summary>
        /// Obtiene un registro de la tabla tsy_AfipTiposDeImpuestosIVA que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow GetByPk(object Codigo)
        {
            return GetByPk((string)Codigo);
        }

        /// <summary>
        /// Establece los valores por defecto de tsy_AfipTiposDeImpuestosIVARow.
        /// </summary>
        public static tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow SetRowDefaultValues(tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow row)
        {
            row.Codigo = string.Empty;
            row.Descripcion = string.Empty;

            return row;
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosIVARow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosIVARow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow)row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosIVARow a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosIVADataset a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosIVADataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsy_AfipTiposDeImpuestosIVA.Rows.Count > 0, "La tabla dataSet.tsy_AfipTiposDeImpuestosIVADataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVADataTable a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVADataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosIVA.Update(dataTable);
        }

        /// <summary>
        /// Valida un tsy_AfipTiposDeImpuestosIVARow.
        /// </summary>
        public static bool RowIsValid(tsy_AfipTiposDeImpuestosIVADataset.tsy_AfipTiposDeImpuestosIVARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;
            string mensaje;


            if (!CodigoIsValid(row.Codigo, out mensaje))
            {
                row.SetColumnError("Codigo", mensaje);
                isValid = false;

            }

            if (!DescripcionIsValid(row.Descripcion, out mensaje))
            {
                row.SetColumnError("Descripcion", mensaje);
                isValid = false;

            }

            return isValid;
        }

        /// <summary>
        /// Valida el campo IdCategoriaIva.
        /// </summary>
        public static bool CodigoIsValid(string Codigo, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdCategoriaIva. Metodo Sobrecargado
        /// </summary>
        public static bool CodigoIsValid(string Codigo)
        {
            string mensaje;
            return CodigoIsValid(Codigo, out mensaje);
        }

        /// <summary>
        /// Valida el campo Descripcion.
        /// </summary>
        public static bool DescripcionIsValid(string Descripcion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo Descripcion. Metodo Sobrecargado
        /// </summary>
        public static bool DescripcionIsValid(string Descripcion)
        {
            string mensaje;
            return DescripcionIsValid(Descripcion, out mensaje);
        }

        public void Dispose()
        {
        }
    }
}
//FinMatias - 20110905 - Tarea 0000131