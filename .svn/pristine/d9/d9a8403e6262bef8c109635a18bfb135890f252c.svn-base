//Matias 20110422 - Tarea 0000061
namespace mz.erp.dataaccess
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    using mz.erp.dbhelper;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;

    public class tpu_ProveedoresPadronesARBA : IDisposable
    {

        #region Custom Members

        //Nuevo para replicacion
        private static SentenciasReplicacion _replicacion;
        public static SentenciasReplicacion Replicacion
        {
            get { return _replicacion; }
            set { _replicacion = value; }
        }

        #endregion

        public tpu_ProveedoresPadronesARBA()
        {
        }

        public static tpu_ProveedoresPadronesARBADataset GetList()
        {
            tpu_ProveedoresPadronesARBADataset data = new tpu_ProveedoresPadronesARBADataset();

            return (tpu_ProveedoresPadronesARBADataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tpu_ProveedoresPadronesARBA");

                SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_GetList", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;

                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow NewRow()
        {
            return (new tpu_ProveedoresPadronesARBADataset()).tpu_ProveedoresPadronesARBA.Newtpu_ProveedoresPadronesARBARow();
        }

        public static tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow GetByPk(Int64 IdProveedorPadronARBA)
        {
            tpu_ProveedoresPadronesARBADataset data = new tpu_ProveedoresPadronesARBADataset();

            SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProveedorPadronARBA", SqlDbType.BigInt));
            cmd.Parameters["@IdProveedorPadronARBA"].Value = IdProveedorPadronARBA;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tpu_ProveedoresPadronesARBA");

            adapter.Fill(data);

            if (data.tpu_ProveedoresPadronesARBA.Rows.Count == 1)
            {
                return (tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow)data.tpu_ProveedoresPadronesARBA.Rows[0];
            }

            return null;
        }

        public static void Update(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBARow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable)row.Table).Addtpu_ProveedoresPadronesARBARow(row);
            }

            Update(row.Table);
        }

        public static void Update(tpu_ProveedoresPadronesARBADataset dataSet)
        {
            Update(dataSet.tpu_ProveedoresPadronesARBA);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable)dataTable, trx);
                Replicacion.Update();
                mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
                trx.Commit();
            }
            catch (Exception e)
            {
                trx.Rollback();
            }
            finally
            {
                cnx.Close();
            }
        }

        public static void Update(DataTable dataTable, SqlTransaction trx)
        {
            Update((tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable)dataTable, trx);
        }

        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
            if (Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
                Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
        }

        public static void Update(tpu_ProveedoresPadronesARBADataset.tpu_ProveedoresPadronesARBADataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ProveedoresPadronesARBA", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProveedorPadronARBA", "IdProveedorPadronARBA" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "IdPadron", "IdPadron" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "FechaPublicacion", "FechaPublicacion" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "FechaVigenciaDesde", "FechaVigenciaDesde" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "FechaVigenciaHasta", "FechaVigenciaHasta" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "CUIT", "CUIT" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "TipoContrInsc", "TipoContrInsc" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "MarcaAltaBajaSujeto", "MarcaAltaBajaSujeto" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "MarcaCambioAlicuota", "MarcaCambioAlicuota" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "AlicuotaPercepcion", "AlicuotaPercepcion" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "AlicuotaRetencion", "AlicuotaRetencion" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "NroGrupoPercepcion", "NroGrupoPercepcion" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "NroGrupoRetencion", "NroGrupoRetencion" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "RowId", "RowId" )																											 
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProveedorPadronARBA", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorPadronARBA", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaPublicacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaPublicacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaVigenciaDesde", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVigenciaDesde", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaVigenciaHasta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVigenciaHasta", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@CUIT", SqlDbType.VarChar, 11, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CUIT", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TipoContrInsc", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TipoContrInsc", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@MarcaAltaBajaSujeto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MarcaAltaBajaSujeto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@MarcaCambioAlicuota", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MarcaCambioAlicuota", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@AlicuotaPercepcion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AlicuotaPercepcion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@AlicuotaRetencion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AlicuotaRetencion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@NroGrupoPercepcion", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NroGrupoPercepcion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@NroGrupoRetencion", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NroGrupoRetencion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProveedorPadronARBA", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorPadronARBA", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProveedorPadronARBA", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorPadronARBA", DataRowVersion.Original, null));
            //sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProveedorPadronARBA", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorPadronARBA", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaPublicacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaPublicacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaVigenciaDesde", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVigenciaDesde", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaVigenciaHasta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVigenciaHasta", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@CUIT", SqlDbType.VarChar, 11, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CUIT", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@TipoContrInsc", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TipoContrInsc", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@MarcaAltaBajaSujeto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MarcaAltaBajaSujeto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@MarcaCambioAlicuota", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MarcaCambioAlicuota", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@AlicuotaPercepcion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AlicuotaPercepcion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@AlicuotaRetencion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AlicuotaRetencion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@NroGrupoPercepcion", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NroGrupoPercepcion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@NroGrupoRetencion", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NroGrupoRetencion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdGenerado", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "RowIdGenerado", DataRowVersion.Current, null));


            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);


            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;

            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }

        //public static DataTable GetListEx()
        //{
        //    DataTable data = new DataTable();
        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        adapter.TableMappings.Add("Table", "tpu_ProveedoresPadronesARBA");

        //        SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresPadronesARBA_GetListEx", dbhelper.Connection.GetConnection());
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        adapter.SelectCommand = cmd;

        //        adapter.Fill(data);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    return data;
        //}


    }
}
