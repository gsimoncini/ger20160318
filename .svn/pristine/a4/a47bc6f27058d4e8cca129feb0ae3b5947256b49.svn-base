//Matias 20110421 - Tarea 0000061
namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;
    using System.Data.SqlClient;

    public class tsh_PadronesARBA : IDisposable
    {

        //#region Custom Members

        //public static DataTable GetNomenclaturas()
        //{
        //    return mz.erp.dataaccess.tsh_PadronesARBA.GetNomenclaturas().Tables[0];
        //}

        //public static string GetByPk(string IdPadron)
        //{
        //    return mz.erp.dataaccess.tsh_PadronesARBA.GetByPk(IdPadron);
        //}

        //public static tsh_PadronesARBADataset GetListByJerarquia(string Jerarquia)
        //{
        //    return mz.erp.dataaccess.tsh_PadronesARBA.GetListByJerarquia(Jerarquia);
        //}

        //public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetPkByDescripcion(string Descripcion)
        //{
        //    return mz.erp.dataaccess.tsh_PadronesARBA.GetPkByDescripcion(Descripcion);
        //}

        //public static string GetIdPadronByDescripcion(string Descripcion)
        //{
        //    return mz.erp.dataaccess.tsh_PadronesARBA.GetIdPadronByDescripcion(Descripcion);
        //}
        //public static string GetJerarquiaByIdPadron(string IdPadron)
        //{
        //    return dataaccess.tsh_PadronesARBA.GetJerarquiaByIdPadron(IdPadron);
        //}
        //#endregion

        public tsh_PadronesARBA()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tsh_PadronesARBA
        /// </summary>

        public static tsh_PadronesARBADataset GetList()
        {
            return mz.erp.dataaccess.tsh_PadronesARBA.GetList();
        }

        public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetFechaPublicacionDeUltimaActualizacion()
        {
            return mz.erp.dataaccess.tsh_PadronesARBA.GetFechaPublicacionDeUltimaActualizacion();
        }

        /// <summary>
        /// Crea un tsh_PadronesARBARow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tsh_PadronesARBADataset.tsh_PadronesARBARow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tsh_PadronesARBA.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsh_PadronesARBA que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetByPk(Int64 IdPadron)
        {
            tsh_PadronesARBADataset.tsh_PadronesARBARow row = mz.erp.dataaccess.tsh_PadronesARBA.GetByPk(IdPadron);
            if (row != null)
            {
                foreach (DataColumn dc in row.Table.Columns)
                {
                    if (!dc.Caption.Equals("RowID"))
                        if (row[dc] == System.DBNull.Value)
                        {
                            row[dc] = Util.DefaultValue(dc.DataType);
                        }
                }
            }
            return row;
        }

        /// <summary>
        /// Obtiene un registro de la tabla tsh_PadronesARBA que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetByPk(object IdPadron)
        {
            return GetByPk((Int64)IdPadron);
        }

        #region delete
        [atMethodDeleteRow]
        public static void Delete(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValidDelete(row))
            {
                row.Delete();
                Update(row);
            }

        }

        public static bool RowIsValidDelete(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;

            //tsh_AgrupProductosDataset.tsh_AgrupProductosDataTable table = tsh_AgrupProductos.GetList(string.Empty, row.IdPadron /*row.Jerarquia*/).tsh_AgrupProductos;

            //if (table.Rows.Count > 0)
            //{
            //    row.SetColumnError("Jerarquia", "No se ha podido eliminar el item porque existen tablas relacionadas.");
            //    isValid = false;

            //}

            return isValid;
        }

        #endregion

        /// <summary>
        /// Establece los valores por defecto de tsh_PadronesARBARow.
        /// </summary>
        public static tsh_PadronesARBADataset.tsh_PadronesARBARow SetRowDefaultValues(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            row.IdPadron = Int64.MinValue; //Util.NewStringId();
            row.FechaPublicacion = mz.erp.businessrules.Sistema.DateTime.Now;
            row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
            row.IdConexionCreacion = Security.IdConexion;
            //row.UltimaModificacion = null;
            row.IdConexionUltimaModificacion = Security.IdConexion;
            row.IdReservado = 0;
            row.RowId = Guid.Empty;
            row.IdEmpresa = Security.IdEmpresa;
            row.IdSucursal = Security.IdSucursal;

            return row;
        }

        public static DataRow SetRowDefaultValues(DataRow row)
        {
            row["IdPadron"] = Int64.MinValue; //Util.NewStringId();
            row["FechaPublicacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
            row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
            row["IdConexionCreacion"] = Security.IdConexion;
            //row.UltimaModificacion = null;
            row["IdConexionUltimaModificacion"] = Security.IdConexion;
            row["IdReservado"] = 0;
            row["RowId"] = Guid.Empty;
            row["IdEmpresa"] = Security.IdEmpresa;
            row["IdSucursal"] = Security.IdSucursal;

            return row;
        }
        /// <summary>
        /// Envia los cambios del tsh_PadronesARBARow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tsh_PadronesARBARow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tsh_PadronesARBADataset.tsh_PadronesARBARow)row);
        }

        public static void UpdateAlicuotasDesdePadron(string filePath, string idTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(idTransaction);
            mz.erp.dataaccess.tsh_PadronesARBA.UpdateAlicuotasDesdePadron(filePath, trx);
        }

        /// <summary>
        /// Envia los cambios del tsh_PadronesARBARow a la base de datos.
        /// </summary>
        public static void Update(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);



            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tsh_PadronesARBA";
            mz.erp.dataaccess.tsh_PadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tsh_PadronesARBA.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tsh_PadronesARBADataset a la base de datos.
        /// </summary>
        public static void Update(tsh_PadronesARBADataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tsh_PadronesARBA.Rows.Count > 0, "La tabla dataSet.tsh_PadronesARBADataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tsh_PadronesARBA";
            mz.erp.dataaccess.tsh_PadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tsh_PadronesARBA.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tsh_PadronesARBADataset.tsh_PadronesARBADataTable a la base de datos.
        /// </summary>
        public static void Update(tsh_PadronesARBADataset.tsh_PadronesARBADataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tsh_PadronesARBA";
            mz.erp.dataaccess.tsh_PadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tsh_PadronesARBA.Update(dataTable);
        }

        public static void Update(DataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tsh_PadronesARBA";
            mz.erp.dataaccess.tsh_PadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tsh_PadronesARBA.Update(dataTable);
        }

        /// <summary>
        /// Valida un tsh_PadronesARBARow.
        /// </summary>
        public static bool RowIsValid(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;
            string mensaje;


            if (!IdPadronIsValid(row.IdPadron, out mensaje))
            {
                row.SetColumnError("IdPadron", mensaje);
                isValid = false;

            }

            if (!FechaPublicacionIsValid(row.FechaPublicacion, out mensaje))
            {
                row.SetColumnError("FechaPublicacion", mensaje);
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

            /*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
            { 
                row.SetColumnError( "UltimaModificacion" , mensaje);
                isValid=false;
			
            }*/

            if (!IdConexionUltimaModificacionIsValid(row.IdConexionUltimaModificacion, out mensaje))
            {
                row.SetColumnError("IdConexionUltimaModificacion", mensaje);
                isValid = false;

            }

            if (!IdReservadoIsValid(row.IdReservado, out mensaje))
            {
                row.SetColumnError("IdReservado", mensaje);
                isValid = false;

            }

            if (!RowIdIsValid(row.RowId, out mensaje))
            {
                row.SetColumnError("RowId", mensaje);
                isValid = false;

            }

            if (!IdEmpresaIsValid(row.IdEmpresa, out mensaje))
            {
                row.SetColumnError("IdEmpresa", mensaje);
                isValid = false;

            }

            if (!IdSucursalIsValid(row.IdSucursal, out mensaje))
            {
                row.SetColumnError("IdSucursal", mensaje);
                isValid = false;

            }
            ;

            return isValid;
        }

        /// <summary>
        /// Valida el campo IdPadron.
        /// </summary>
        public static bool IdPadronIsValid(Int64 IdPadron, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdPadron. Metodo Sobrecargado
        /// </summary>
        public static bool IdPadronIsValid(Int64 IdPadron)
        {
            string mensaje;
            return IdPadronIsValid(IdPadron, out mensaje);
        }

        /// <summary>
        /// Valida el campo FechaPublicacion.
        /// </summary>
        public static bool FechaPublicacionIsValid(DateTime FechaPublicacion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo FechaPublicacion. Metodo Sobrecargado
        /// </summary>
        public static bool FechaPublicacionIsValid(DateTime Descripcion)
        {
            string mensaje;
            return FechaPublicacionIsValid(Descripcion, out mensaje);
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
        /// Valida el campo IdReservado.
        /// </summary>
        public static bool IdReservadoIsValid(long IdReservado, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdReservado. Metodo Sobrecargado
        /// </summary>
        public static bool IdReservadoIsValid(long IdReservado)
        {
            string mensaje;
            return IdReservadoIsValid(IdReservado, out mensaje);
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

        /// <summary>
        /// Valida el campo IdEmpresa.
        /// </summary>
        public static bool IdEmpresaIsValid(long IdEmpresa, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdEmpresa. Metodo Sobrecargado
        /// </summary>
        public static bool IdEmpresaIsValid(long IdEmpresa)
        {
            string mensaje;
            return IdEmpresaIsValid(IdEmpresa, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdSucursal.
        /// </summary>
        public static bool IdSucursalIsValid(long IdSucursal, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdSucursal. Metodo Sobrecargado
        /// </summary>
        public static bool IdSucursalIsValid(long IdSucursal)
        {
            string mensaje;
            return IdSucursalIsValid(IdSucursal, out mensaje);
        }


        public void Dispose()
        {
        }

    }
}

