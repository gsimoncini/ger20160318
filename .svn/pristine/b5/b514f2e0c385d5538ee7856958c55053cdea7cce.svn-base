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

    class tsy_AfipTiposDeDocumentos : IDisposable
    {
        #region Custom Members

        #endregion

        public tsy_AfipTiposDeDocumentos()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsy_AfipTiposDeDocumentos
        /// </summary>
        public static tsy_AfipTiposDeDocumentosDataset GetList()
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.GetList();
        }

        public static DataRow GetByIdTipoDeDocumento(string IdTipoDeDocumento)
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.GetByIdTipoDeDocumento(IdTipoDeDocumento);
        }

        /// <summary>
        /// Crea un tsy_AfipTiposDeDocumentosRow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsy_AfipTiposDeDocumentos que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow GetByPk(string Codigo)
        {
            tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row = mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.GetByPk(Codigo);
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
        /// Obtiene un registro de la tabla tsy_AfipTiposDeDocumentos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow GetByPk(object Codigo)
        {
            return GetByPk((string)Codigo);
        }

        /// <summary>
        /// Establece los valores por defecto de tsy_AfipTiposDeDocumentosRow.
        /// </summary>
        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow SetRowDefaultValues(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row)
        {
            row.Codigo = string.Empty;
            row.Descripcion = string.Empty;

            return row;
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeDocumentosRow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeDocumentosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow)row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeDocumentosRow a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeDocumentosDataset a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeDocumentosDataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsy_AfipTiposDeDocumentos.Rows.Count > 0, "La tabla dataSet.tsy_AfipTiposDeDocumentosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable a la base de datos.
        /// </summary>
        public static void Update(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_AfipTiposDeDocumentos.Update(dataTable);
        }

        /// <summary>
        /// Valida un tsy_AfipTiposDeDocumentosRow.
        /// </summary>
        public static bool RowIsValid(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row)
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