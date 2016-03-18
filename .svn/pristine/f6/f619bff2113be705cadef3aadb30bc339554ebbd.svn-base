namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;

    public class tsa_ComprobantesReservasRelacion : IDisposable
    {

        #region Custom Members

        #endregion

        public tsa_ComprobantesReservasRelacion()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsa_ComprobantesReservasRelacion
        /// </summary>
        public static tsa_ComprobantesReservasRelacionDataset GetList()
        {
            return mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.GetList();
        }

        /// <summary>
        /// Obtiene tabla tsa_ComprobantesReservasRelacion filtrada por las condiciones de bsqueda
        /// </summary>
        public static tsa_ComprobantesReservasRelacionDataset GetList(string IdComprobantePrefacturaReserva, string IdComprobanteFactura, string IdComprobanteFacturaPrefacturaReserva, string Estado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId)
        {
            return mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.GetList(IdComprobantePrefacturaReserva, IdComprobanteFactura, IdComprobanteFacturaPrefacturaReserva, Estado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId);
        }

        /// <summary>
        /// Crea un tsa_ComprobantesReservasRelacionRow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsa_ComprobantesReservasRelacion que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow GetByPk(string IdComprobantePrefacturaReserva)
        {
            tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row = mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.GetByPk(IdComprobantePrefacturaReserva);
            foreach (DataColumn dc in row.Table.Columns)
            {
                if (row[dc] == System.DBNull.Value)
                {
                    /* Silvina 20111212 - Tarea 0000232 */
                    if (dc.Caption != "RowId")
                    /* Fin Silvina 20111212 - Tarea 0000232 */
                        row[dc] = Util.DefaultValue(dc.DataType);
                }
            }
            return row;            
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsa_ComprobantesReservasRelacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow GetByPk(object IdComprobantePrefacturaReserva)
        {
            return GetByPk((string)IdComprobantePrefacturaReserva);
        }

        /// <summary>
        /// Establece los valores por defecto de tsa_ComprobantesReservasRelacionRow.
        /// </summary>
        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow SetRowDefaultValues(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row)
        {
            row.IdComprobantePrefacturaReserva = Util.NewStringId();
            row.IdComprobanteFactura = string.Empty;
            row.IdComprobanteFacturaPrefacturaReserva = string.Empty;
            row.Estado = string.Empty;
            row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
            row.IdConexionCreacion = Security.IdConexion;
            //row.UltimaModificacion = null;
            row.IdConexionUltimaModificacion = Security.IdConexion;
            row.RowId = Guid.Empty;

            return row;
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesReservasRelacionRow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesReservasRelacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow)row);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesReservasRelacionRow a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesReservasRelacionDataset a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesReservasRelacionDataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsa_ComprobantesReservasRelacion.Rows.Count > 0, "La tabla dataSet.tsa_ComprobantesReservasRelacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionDataTable a la base de datos.
        /// </summary>
        public static void Update(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionDataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.Update(dataTable);
        }

        /// <summary>
        /// Valida un tsa_ComprobantesReservasRelacionRow.
        /// </summary>
        public static bool RowIsValid(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;
            string mensaje;


            if (!IdComprobantePrefacturaReservaIsValid(row.IdComprobantePrefacturaReserva, out mensaje))
            {
                row.SetColumnError("IdComprobantePrefacturaReserva", mensaje);
                isValid = false;

            }

            if (!IdComprobanteFacturaIsValid(row.IdComprobanteFactura, out mensaje))
            {
                row.SetColumnError("IdComprobanteFactura", mensaje);
                isValid = false;

            }

            if (!IdComprobanteFacturaPrefacturaReservaIsValid(row.IdComprobanteFacturaPrefacturaReserva, out mensaje))
            {
                row.SetColumnError("IdComprobanteFacturaPrefacturaReserva", mensaje);
                isValid = false;

            }

            if (!EstadoIsValid(row.Estado, out mensaje))
            {
                row.SetColumnError("Estado", mensaje);
                isValid = false;

            }

            if (!FechaCreacionIsValid(row.FechaCreacion, out mensaje))
            {
                row.SetColumnError("FechaCreacion", mensaje);
                isValid = false;

            }

            if (!IdConexionCreacionIsValid(row.IdConexionCreacion, out mensaje))
            {
                row.SetColumnError("IdConexionCreacion", mensaje);
                isValid = false;

            }
            /*
            if (!UltimaModificacionIsValid(row.UltimaModificacion, out mensaje))
            {
                row.SetColumnError("UltimaModificacion", mensaje);
                isValid = false;

            }
             * */

            if (!IdConexionUltimaModificacionIsValid(row.IdConexionUltimaModificacion, out mensaje))
            {
                row.SetColumnError("IdConexionUltimaModificacion", mensaje);
                isValid = false;

            }

            if (!RowIdIsValid(row.RowId, out mensaje))
            {
                row.SetColumnError("RowId", mensaje);
                isValid = false;

            }
            ;

            return isValid;
        }

        /// <summary>
        /// Valida el campo IdComprobantePrefacturaReserva.
        /// </summary>
        public static bool IdComprobantePrefacturaReservaIsValid(string IdComprobantePrefacturaReserva, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdComprobantePrefacturaReserva. Metodo Sobrecargado
        /// </summary>
        public static bool IdComprobantePrefacturaReservaIsValid(string IdComprobantePrefacturaReserva)
        {
            string mensaje;
            return IdComprobantePrefacturaReservaIsValid(IdComprobantePrefacturaReserva, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdComprobanteFactura.
        /// </summary>
        public static bool IdComprobanteFacturaIsValid(string IdComprobanteFactura, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdComprobanteFactura. Metodo Sobrecargado
        /// </summary>
        public static bool IdComprobanteFacturaIsValid(string IdComprobanteFactura)
        {
            string mensaje;
            return IdComprobanteFacturaIsValid(IdComprobanteFactura, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdComprobanteFacturaPrefacturaReserva.
        /// </summary>
        public static bool IdComprobanteFacturaPrefacturaReservaIsValid(string IdComprobanteFacturaPrefacturaReserva, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdComprobanteFacturaPrefacturaReserva. Metodo Sobrecargado
        /// </summary>
        public static bool IdComprobanteFacturaPrefacturaReservaIsValid(string IdComprobanteFacturaPrefacturaReserva)
        {
            string mensaje;
            return IdComprobanteFacturaPrefacturaReservaIsValid(IdComprobanteFacturaPrefacturaReserva, out mensaje);
        }

        /// <summary>
        /// Valida el campo Estado.
        /// </summary>
        public static bool EstadoIsValid(string Estado, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo Estado. Metodo Sobrecargado
        /// </summary>
        public static bool EstadoIsValid(string Estado)
        {
            string mensaje;
            return EstadoIsValid(Estado, out mensaje);
        }

        /// <summary>
        /// Valida el campo FechaCreacion.
        /// </summary>
        public static bool FechaCreacionIsValid(DateTime FechaCreacion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo FechaCreacion. Metodo Sobrecargado
        /// </summary>
        public static bool FechaCreacionIsValid(DateTime FechaCreacion)
        {
            string mensaje;
            return FechaCreacionIsValid(FechaCreacion, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdConexionCreacion.
        /// </summary>
        public static bool IdConexionCreacionIsValid(long IdConexionCreacion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdConexionCreacion. Metodo Sobrecargado
        /// </summary>
        public static bool IdConexionCreacionIsValid(long IdConexionCreacion)
        {
            string mensaje;
            return IdConexionCreacionIsValid(IdConexionCreacion, out mensaje);
        }

        /// <summary>
        /// Valida el campo UltimaModificacion.
        /// </summary>
        public static bool UltimaModificacionIsValid(byte[] UltimaModificacion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo UltimaModificacion. Metodo Sobrecargado
        /// </summary>
        public static bool UltimaModificacionIsValid(byte[] UltimaModificacion)
        {
            string mensaje;
            return UltimaModificacionIsValid(UltimaModificacion, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdConexionUltimaModificacion.
        /// </summary>
        public static bool IdConexionUltimaModificacionIsValid(long IdConexionUltimaModificacion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
        /// </summary>
        public static bool IdConexionUltimaModificacionIsValid(long IdConexionUltimaModificacion)
        {
            string mensaje;
            return IdConexionUltimaModificacionIsValid(IdConexionUltimaModificacion, out mensaje);
        }

        /// <summary>
        /// Valida el campo RowId.
        /// </summary>
        public static bool RowIdIsValid(Guid RowId, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo RowId. Metodo Sobrecargado
        /// </summary>
        public static bool RowIdIsValid(Guid RowId)
        {
            string mensaje;
            return RowIdIsValid(RowId, out mensaje);
        }


        public void Dispose()
        {
        }

    }
}

