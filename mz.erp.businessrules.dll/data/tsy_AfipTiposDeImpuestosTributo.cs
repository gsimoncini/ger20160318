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

    class tsy_AfipTiposDeImpuestosTributo : IDisposable
    {
        #region Custom Members

        #endregion

        public tsy_AfipTiposDeImpuestosTributo()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsy_AfipTiposDeImpuestosTributo
        /// </summary>
        public static tsy_AfipTiposDeImpuestosTributoDataset GetList()
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.GetList();
        }

        public static DataRow GetByImpuesto(string Impuesto)
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.GetByImpuesto(Impuesto);
        }

        /// <summary>
        /// Crea un tsy_AfipTiposDeImpuestosTributoRow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsy_AfipTiposDeImpuestosTributo que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow GetByPk(string Codigo)
        {
            tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row = mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.GetByPk(Codigo);
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
        /// Obtiene un registro de la tabla tsy_AfipTiposDeImpuestosTributo que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow GetByPk(object Codigo)
        {
            return GetByPk((string)Codigo);
        }

        /// <summary>
        /// Establece los valores por defecto de tsy_AfipTiposDeImpuestosTributoRow.
        /// </summary>
        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow SetRowDefaultValues(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row)
        {
            row.Codigo = string.Empty;
            row.Descripcion = string.Empty;

            return row;
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosTributoRow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosTributoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow)row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosTributoRow a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosTributoDataset a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsy_AfipTiposDeImpuestosTributo.Rows.Count > 0, "La tabla dataSet.tsy_AfipTiposDeImpuestosTributoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeImpuestosTributo.Update(dataTable);
        }

        /// <summary>
        /// Valida un tsy_AfipTiposDeImpuestosTributoRow.
        /// </summary>
        public static bool RowIsValid(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row)
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