//tsa_ComprobantesEFactura
namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;

    class tsa_ComprobantesEFactura : IDisposable
    {
        #region Custom Members

        #endregion

        public tsa_ComprobantesEFactura()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsa_ComprobantesEFactura
        /// </summary>
        public static tsa_ComprobantesEFacturaDataset GetList()
        {
            return mz.erp.dataaccess.tsa_ComprobantesEFactura.GetList();
        }

        /// <summary>
        /// Crea un tsa_ComprobantesEFacturaRow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobantesEFactura.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsa_ComprobantesEFactura que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow GetByPk(string IdComrpobante)
        {
            tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row = mz.erp.dataaccess.tsa_ComprobantesEFactura.GetByPk(IdComrpobante);
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
        /// Obtiene un registro de la tabla tsa_ComprobantesEFactura que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow GetByPk(object IdComrpobante)
        {
            return GetByPk((string)IdComrpobante);
        }

        /// <summary>
        /// Establece los valores por defecto de tsa_ComprobantesEFacturaRow.
        /// </summary>
        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow SetRowDefaultValues(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row)
        {
            row.IdComprobante = string.Empty;
            row.CAE = string.Empty;
            row.FechaVencimientoCAE = DateTime.MinValue;
            row.Motivo = string.Empty;
            row.FechaCreacion = DateTime.Now;
            row.IdConexionCreacion = Security.IdConexion;
            row.UltimaModificacion = null;
            row.IdConexionUltimaModificacion = Security.IdConexion;
            row.IdReservado = 0;
            //row.RowId = null;
            row.IdEmpresa = 0;
            row.IdSucursal = 0;

            return row;
        }

        public static DataRow SetRowDefaultValues(DataRow row)
        {
            row["IdComprobante"] = string.Empty;
            row["CAE"] = string.Empty;
            row["FechaVencimientoCAE"] = DateTime.MinValue;
            row["Motivo"] = string.Empty;
            row["FechaCreacion"] = DateTime.Now;
            row["IdConexionCreacion"] = Security.IdConexion;
            row["UltimaModificacion"] = null;
            row["IdConexionUltimaModificacion"] = Security.IdConexion;
            row["IdReservado"] = 0;
            //row["RowId"] = null;
            row["IdEmpresa"] = 0;
            row["IdSucursal"] = 0;
            return row;
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaRow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow)row);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaRow a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesEFactura.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaDataset a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesEFacturaDataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsa_ComprobantesEFactura.Rows.Count > 0, "La tabla dataSet.tsa_ComprobantesEFacturaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesEFactura.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesEFactura.Update(dataTable);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable a la base de datos.
        /// </summary>
        public static void Update(DataTable dataTable, String idTransaction)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesEFactura.Update(dataTable, idTransaction);
        }

        /// <summary>
        /// Valida un tsa_ComprobantesEFacturaRow.
        /// </summary>
        public static bool RowIsValid(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;
            string mensaje;


            if (!IdComrpobanteIsValid(row.IdComprobante, out mensaje))
            {
                row.SetColumnError("IdComrpobante", mensaje);
                isValid = false;

            }

            //if (!DescripcionIsValid(row.Descripcion, out mensaje))
            //{
            //    row.SetColumnError("Descripcion", mensaje);
            //    isValid = false;

            //}

            return isValid;
        }

        /// <summary>
        /// Valida el campo IdCategoriaIva.
        /// </summary>
        public static bool IdComrpobanteIsValid(string IdComrpobante, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdCategoriaIva. Metodo Sobrecargado
        /// </summary>
        public static bool IdComrpobanteIsValid(string IdComrpobante)
        {
            string mensaje;
            return IdComrpobanteIsValid(IdComrpobante, out mensaje);
        }

        /// <summary>
        /// Valida el campo Descripcion.
        /// </summary>
        //public static bool DescripcionIsValid(string Descripcion, out string mensaje)
        //{
        //    //Agregar cdigo de validacin
        //    mensaje = "";
        //    return true;
        //}

        /// <summary>
        /// Valida el campo Descripcion. Metodo Sobrecargado
        /// </summary>
        //public static bool DescripcionIsValid(string Descripcion)
        //{
        //    string mensaje;
        //    return DescripcionIsValid(Descripcion, out mensaje);
        //}

        public void Dispose()
        {
        }
    }
}
