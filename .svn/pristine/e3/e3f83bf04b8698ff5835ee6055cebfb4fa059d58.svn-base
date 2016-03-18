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

    public class tpu_ProveedoresProductosAuxiliares : IDisposable
    {

        #region Custom Members
        //Sabrina: Tarea 1110. 20110805
        private static SentenciasReplicacion _replication;
        //Fin Sabrina: Tarea 1110. 20110805
        #endregion

        public tpu_ProveedoresProductosAuxiliares()
        {
        }

        public static tpu_ProveedoresProductosAuxiliaresDataset GetList()
        {
            tpu_ProveedoresProductosAuxiliaresDataset data = new tpu_ProveedoresProductosAuxiliaresDataset();

            return (tpu_ProveedoresProductosAuxiliaresDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tpu_ProveedoresProductosAuxiliares");

            SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tpu_ProveedoresProductosAuxiliaresDataset GetList(string IdProveedor, string IdProducto, string CodigoProductoProveedor, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal)
        {
            tpu_ProveedoresProductosAuxiliaresDataset data = new tpu_ProveedoresProductosAuxiliaresDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tpu_ProveedoresProductosAuxiliares");

            SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar));
            cmd.Parameters["@IdProveedor"].Value = IdProveedor;
            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;
            cmd.Parameters.Add(new SqlParameter("@CodigoProductoProveedor", SqlDbType.VarChar));
            cmd.Parameters["@CodigoProductoProveedor"].Value = CodigoProductoProveedor;
            cmd.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime));
            cmd.Parameters["@FechaCreacion"].Value = FechaCreacion;
            cmd.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt));
            if (IdConexionCreacion == long.MinValue)
            {
                cmd.Parameters["@IdConexionCreacion"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdConexionCreacion"].Value = IdConexionCreacion;
            }
            cmd.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp));
            cmd.Parameters["@UltimaModificacion"].Value = UltimaModificacion;
            cmd.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt));
            if (IdConexionUltimaModificacion == long.MinValue)
            {
                cmd.Parameters["@IdConexionUltimaModificacion"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdConexionUltimaModificacion"].Value = IdConexionUltimaModificacion;
            }
            cmd.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt));
            if (IdReservado == long.MinValue)
            {
                cmd.Parameters["@IdReservado"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdReservado"].Value = IdReservado;
            }
            cmd.Parameters.Add(new SqlParameter("@RowId", SqlDbType.UniqueIdentifier));
            cmd.Parameters["@RowId"].Value = RowId;
            cmd.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt));
            if (IdEmpresa == long.MinValue)
            {
                cmd.Parameters["@IdEmpresa"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdEmpresa"].Value = IdEmpresa;
            }
            cmd.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt));
            if (IdSucursal == long.MinValue)
            {
                cmd.Parameters["@IdSucursal"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdSucursal"].Value = IdSucursal;
            }
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow NewRow()
        {
            return (new tpu_ProveedoresProductosAuxiliaresDataset()).tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
        }

        public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow GetByPk(string IdProveedor, string IdProducto)
        {
            tpu_ProveedoresProductosAuxiliaresDataset data = new tpu_ProveedoresProductosAuxiliaresDataset();

            SqlCommand cmd = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar));
            cmd.Parameters["@IdProveedor"].Value = IdProveedor;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tpu_ProveedoresProductosAuxiliares");

            adapter.Fill(data);

            if (data.tpu_ProveedoresProductosAuxiliares.Rows.Count == 1)
            {
                return (tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow)data.tpu_ProveedoresProductosAuxiliares.Rows[0];
            }

            return null;
        }

        public static void Update(tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresDataTable)row.Table).Addtpu_ProveedoresProductosAuxiliaresRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tpu_ProveedoresProductosAuxiliaresDataset dataSet)
        {
            Update(dataSet.tpu_ProveedoresProductosAuxiliares);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresDataTable)dataTable, trx);
                trx.Commit();
            }
            catch
            {
                trx.Rollback();
            }
            finally
            {
                cnx.Close();
            }
        }

        //Sabrina: Incidencia 0000204. 20110901
        public static void Update(DataTable dataTable, string IdTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            Update(dataTable, trx);
        }
        //Fin Sabrina: Incidencia 0000204. 20110901

        //Sabrina: Tarea 1110. 20110805
        public static void Update(DataTable dataTable, SqlTransaction trx)
        {
            SentenciasReplicacion replicacion = new SentenciasReplicacion();
            Update(dataTable, trx, replicacion);
        }
        //Fin Sabrina: Tarea 1110. 20110805

        //Sabrina: Tarea 1110. 20110805
        public static void Update(DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
        //Fin Sabrina: Tarea 1110. 20110805
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tpu_ProveedoresProductosAuxiliares", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
							new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
							new System.Data.Common.DataColumnMapping( "CodigoProductoProveedor", "CodigoProductoProveedor" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@CodigoProductoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoProductoProveedor", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ProveedoresProductosAuxiliares_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedor", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@CodigoProductoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodigoProductoProveedor", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));

            //Sabrina: Tarea 1110. 20110805
            #region Replicacion

            _replication = replicacion;
            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            #endregion
            //Fin Sabrina: Tarea 1110. 20110805
            
            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;
            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }

        //Sabrina: Tarea 1110. 20110805
        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            try
            {

                StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
                if (_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
                    _replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Fin Sabrina: Tarea 1110. 20110805

    }
}

