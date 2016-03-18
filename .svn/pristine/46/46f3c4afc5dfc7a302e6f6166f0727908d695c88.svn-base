//Matias 20110422 - Tarea 0000061
namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;

    public class tpu_ProveedoresPadronesARBA : IDisposable
    {

        //#region Custom Members

        //#endregion

        public tpu_ProveedoresPadronesARBA()
        {
        }

        /// <summary>
        /// Obtiene la lista completa de la tabla tpu_ProveedoresPadronesARBA
        /// </summary>

        public static tpu_ProveedoresPadronesARBADataset GetList()
        {
            return mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.GetList();
        }

        /// <summary>
        /// Crea un tpu_ProveedoresPadronesARBARow que luego puede ser persistido en la base de datos.
        /// </summary>
        [atMethodNewRow]
        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow NewRow()
        {
            return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.NewRow());
        }

        /// <summary>
        /// Obtiene un registro de la tabla tpu_ProveedoresPadronesARBA que luego puede ser persistido en la base de datos.
        /// </summary>
        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow GetByPk(Int64 IdProveedorPadronARBA)
        {
            tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row = mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.GetByPk(IdProveedorPadronARBA);
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
        /// Obtiene un registro de la tabla tpu_ProveedoresPadronesARBA que luego puede ser persistido en la base de datos. Metodo Sobrecargado
        /// </summary>
        [atMethodGetByPkRow]
        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow GetByPk(object IdProveedorPadronARBA)
        {
            return GetByPk((Int64)IdProveedorPadronARBA);
        }

        #region delete
        [atMethodDeleteRow]
        public static void Delete(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValidDelete(row))
            {
                row.Delete();
                Update(row);
            }

        }

        public static bool RowIsValidDelete(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;

            //tsh_AgrupProductosDataset.tsh_AgrupProductosDataTable table = tsh_AgrupProductos.GetList(string.Empty, row.IdProveedorPadronARBA /*row.Jerarquia*/).tsh_AgrupProductos;

            //if (table.Rows.Count > 0)
            //{
            //    row.SetColumnError("Jerarquia", "No se ha podido eliminar el item porque existen tablas relacionadas.");
            //    isValid = false;

            //}

            return isValid;
        }

        #endregion

        /// <summary>
        /// Establece los valores por defecto de tpu_ProveedoresPadronesARBARow.
        /// </summary>
        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow SetRowDefaultValues(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            row.IdProveedorPadronARBA = Int64.MinValue; //Util.NewStringId();
            row.IdProveedor = string.Empty;
            row.IdPadron = Int64.MinValue;
            row.FechaPublicacion = mz.erp.businessrules.Sistema.DateTime.Now;
            row.FechaVigenciaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
            row.FechaVigenciaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
            row.CUIT = string.Empty;
            row.TipoContrInsc = string.Empty;
            row.MarcaAltaBajaSujeto = string.Empty;
            row.MarcaCambioAlicuota = string.Empty;
            row.AlicuotaPercepcion = 0;
            row.AlicuotaRetencion = 0;
            row.NroGrupoPercepcion = string.Empty;
            row.NroGrupoRetencion = string.Empty;
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
            row["IdProveedorPadronARBA"] = Int64.MinValue; //Util.NewStringId();
            row["IdProveedor"] = string.Empty;
            row["IdPadron"] = Int64.MinValue; //string.Empty;
            row["FechaPublicacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
            row["FechaVigenciaDesde"] = mz.erp.businessrules.Sistema.DateTime.Now;
            row["FechaVigenciaHasta"] = mz.erp.businessrules.Sistema.DateTime.Now;
            row["CUIT"] = string.Empty;
            row["TipoContrInsc"] = string.Empty;
            row["MarcaAltaBajaSujeto"] = string.Empty;
            row["MarcaCambioAlicuota"] = string.Empty;
            row["AlicuotaPercepcion"] = 0;
            row["AlicuotaRetencion"] = 0;
            row["NroGrupoPercepcion"] = string.Empty;
            row["NroGrupoRetencion"] = string.Empty;
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
        /// Envia los cambios del tpu_ProveedoresPadronesARBARow a la base de datos realizando una validacin previa.
        /// </summary>
        [atMethodSaveRowWithValidation]
        public static void UpdateWithValidation(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            if (RowIsValid(row))
            {
                Update(row);
            }
        }

        /// <summary>
        /// Envia los cambios del tpu_ProveedoresPadronesARBARow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
        /// </summary>
        public static void UpdateWithValidation(System.Data.DataRow row)
        {
            UpdateWithValidation((tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow)row);
        }

        /// <summary>
        /// Envia los cambios del tpu_ProveedoresPadronesARBARow a la base de datos.
        /// </summary>
        public static void Update(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tpu_ProveedoresPadronesARBA";
            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Update(row);
        }

        /// <summary>
        /// Envia los cambios del tpu_ProveedoresPadronesARBADataset a la base de datos.
        /// </summary>
        public static void Update(tpu_ProveedoresPadronesARBADataset dataSet)
        {
            ApplicationAssert.Check(dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataSet.tpu_ProveedoresPadronesARBA.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresPadronesARBADataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tpu_ProveedoresPadronesARBA";
            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Update(dataSet);
        }

        /// <summary>
        /// Envia los cambios del tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable a la base de datos.
        /// </summary>
        public static void Update(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable dataTable)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tpu_ProveedoresPadronesARBA";
            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Update(dataTable);
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
            replication.NombreTabla = "dataaccess.tpu_ProveedoresPadronesARBA";
            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Replicacion = replication;

            mz.erp.dataaccess.tpu_ProveedoresPadronesARBA.Update(dataTable);
        }

        /// <summary>
        /// Valida un tpu_ProveedoresPadronesARBARow.
        /// </summary>
        public static bool RowIsValid(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            ApplicationAssert.Check(row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber);
            bool isValid = true;
            string mensaje;


            if (!IdProveedorPadronARBAIsValid(row.IdProveedorPadronARBA, out mensaje))
            {
                row.SetColumnError("IdProveedorPadronARBA", mensaje);
                isValid = false;

            }

            if (!IdProveedorIsValid(row.IdProveedor, out mensaje))
            {
                row.SetColumnError("IdProveedor", mensaje);
                isValid = false;

            }

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

            if (!FechaVigenciaDesdeIsValid(row.FechaVigenciaDesde, out mensaje))
            {
                row.SetColumnError("FechaVigenciaDesde", mensaje);
                isValid = false;

            }

            if (!FechaVigenciaHastaIsValid(row.FechaVigenciaHasta, out mensaje))
            {
                row.SetColumnError("FechaVigenciaHasta", mensaje);
                isValid = false;

            }

            if (!CUITIsValid(row.CUIT, out mensaje))
            {
                row.SetColumnError("CUIT", mensaje);
                isValid = false;

            }

            if (!TipoContrInscIsValid(row.TipoContrInsc, out mensaje))
            {
                row.SetColumnError("TipoContrInsc", mensaje);
                isValid = false;

            }

            if (!MarcaAltaBajaSujetoIsValid(row.MarcaAltaBajaSujeto, out mensaje))
            {
                row.SetColumnError("MarcaAltaBajaSujeto", mensaje);
                isValid = false;

            }

            if (!MarcaCambioAlicuotaIsValid(row.MarcaCambioAlicuota, out mensaje))
            {
                row.SetColumnError("MarcaCambioAlicuota", mensaje);
                isValid = false;

            }

            if (!AlicuotaPercepcionIsValid(row.AlicuotaPercepcion, out mensaje))
            {
                row.SetColumnError("AlicuotaPercepcion", mensaje);
                isValid = false;

            }

            if (!AlicuotaRetencionIsValid(row.AlicuotaRetencion, out mensaje))
            {
                row.SetColumnError("AlicuotaRetencion", mensaje);
                isValid = false;

            }

            if (!NroGrupoPercepcionIsValid(row.NroGrupoPercepcion, out mensaje))
            {
                row.SetColumnError("NroGrupoPercepcion", mensaje);
                isValid = false;

            }

            if (!NroGrupoRetencionIsValid(row.NroGrupoRetencion, out mensaje))
            {
                row.SetColumnError("NroGrupoRetencion", mensaje);
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
        /// Valida el campo IdProveedorPadronARBA.
        /// </summary>
        public static bool IdProveedorPadronARBAIsValid(Int64 IdProveedorPadronARBA, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdProveedorPadronARBA. Metodo Sobrecargado
        /// </summary>
        public static bool IdProveedorPadronARBAIsValid(Int64 IdProveedorPadronARBA)
        {
            string mensaje;
            return IdProveedorPadronARBAIsValid(IdProveedorPadronARBA, out mensaje);
        }

        /// <summary>
        /// Valida el campo IdProveedor.
        /// </summary>
        public static bool IdProveedorIsValid(string IdProveedor, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdProveedor. Metodo Sobrecargado
        /// </summary>
        public static bool IdProveedorIsValid(string IdProveedor)
        {
            string mensaje;
            return IdProveedorIsValid(IdProveedor, out mensaje);
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
        /// Valida el campo FechaVigenciaDesde.
        /// </summary>
        public static bool FechaVigenciaDesdeIsValid(DateTime FechaVigenciaDesde, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo FechaVigenciaDesde. Metodo Sobrecargado
        /// </summary>
        public static bool FechaVigenciaDesdeIsValid(DateTime Descripcion)
        {
            string mensaje;
            return FechaVigenciaDesdeIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo FechaVigenciaHasta.
        /// </summary>
        public static bool FechaVigenciaHastaIsValid(DateTime FechaVigenciaHasta, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo FechaVigenciaHasta. Metodo Sobrecargado
        /// </summary>
        public static bool FechaVigenciaHastaIsValid(DateTime Descripcion)
        {
            string mensaje;
            return FechaVigenciaHastaIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo CUIT.
        /// </summary>
        public static bool CUITIsValid(string CUIT, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo CUIT. Metodo Sobrecargado
        /// </summary>
        public static bool CUITIsValid(string Descripcion)
        {
            string mensaje;
            return CUITIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo TipoContrInsc.
        /// </summary>
        public static bool TipoContrInscIsValid(string TipoContrInsc, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo TipoContrInsc. Metodo Sobrecargado
        /// </summary>
        public static bool TipoContrInscIsValid(string Descripcion)
        {
            string mensaje;
            return TipoContrInscIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo MarcaAltaBajaSujeto.
        /// </summary>
        public static bool MarcaAltaBajaSujetoIsValid(string MarcaAltaBajaSujeto, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo MarcaAltaBajaSujeto. Metodo Sobrecargado
        /// </summary>
        public static bool MarcaAltaBajaSujetoIsValid(string Descripcion)
        {
            string mensaje;
            return MarcaAltaBajaSujetoIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo MarcaCambioAlicuota.
        /// </summary>
        public static bool MarcaCambioAlicuotaIsValid(string MarcaCambioAlicuota, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo MarcaCambioAlicuota. Metodo Sobrecargado
        /// </summary>
        public static bool MarcaCambioAlicuotaIsValid(string Descripcion)
        {
            string mensaje;
            return MarcaCambioAlicuotaIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo AlicuotaPercepcion.
        /// </summary>
        public static bool AlicuotaPercepcionIsValid(decimal AlicuotaPercepcion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo AlicuotaPercepcion. Metodo Sobrecargado
        /// </summary>
        public static bool AlicuotaPercepcionIsValid(decimal Descripcion)
        {
            string mensaje;
            return AlicuotaPercepcionIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo AlicuotaRetencion.
        /// </summary>
        public static bool AlicuotaRetencionIsValid(decimal AlicuotaRetencion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo AlicuotaRetencion. Metodo Sobrecargado
        /// </summary>
        public static bool AlicuotaRetencionIsValid(decimal Descripcion)
        {
            string mensaje;
            return AlicuotaRetencionIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo NroGrupoPercepcion.
        /// </summary>
        public static bool NroGrupoPercepcionIsValid(string NroGrupoPercepcion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo NroGrupoPercepcion. Metodo Sobrecargado
        /// </summary>
        public static bool NroGrupoPercepcionIsValid(string Descripcion)
        {
            string mensaje;
            return NroGrupoPercepcionIsValid(Descripcion, out mensaje);
        }

        /// <summary>
        /// Valida el campo NroGrupoRetencion.
        /// </summary>
        public static bool NroGrupoRetencionIsValid(string NroGrupoRetencion, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo NroGrupoRetencion. Metodo Sobrecargado
        /// </summary>
        public static bool NroGrupoRetencionIsValid(string Descripcion)
        {
            string mensaje;
            return NroGrupoRetencionIsValid(Descripcion, out mensaje);
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

