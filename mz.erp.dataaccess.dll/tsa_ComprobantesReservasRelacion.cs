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

    public class tsa_ComprobantesReservasRelacion : IDisposable
    {

        #region Custom Members

        #endregion

        public tsa_ComprobantesReservasRelacion()
        {
        }

        public static tsa_ComprobantesReservasRelacionDataset GetList()
        {
            tsa_ComprobantesReservasRelacionDataset data = new tsa_ComprobantesReservasRelacionDataset();

            return (tsa_ComprobantesReservasRelacionDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsa_ComprobantesReservasRelacion");

            SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsa_ComprobantesReservasRelacionDataset GetList(string IdComprobantePrefacturaReserva, string IdComprobanteFactura, string IdComprobanteFacturaPrefacturaReserva, string Estado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId)
        {
            tsa_ComprobantesReservasRelacionDataset data = new tsa_ComprobantesReservasRelacionDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsa_ComprobantesReservasRelacion");

            SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdComprobantePrefacturaReserva", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobantePrefacturaReserva"].Value = IdComprobantePrefacturaReserva;
            cmd.Parameters.Add(new SqlParameter("@IdComprobanteFactura", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobanteFactura"].Value = IdComprobanteFactura;
            cmd.Parameters.Add(new SqlParameter("@IdComprobanteFacturaPrefacturaReserva", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobanteFacturaPrefacturaReserva"].Value = IdComprobanteFacturaPrefacturaReserva;
            cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            cmd.Parameters["@Estado"].Value = Estado;
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
            cmd.Parameters.Add(new SqlParameter("@RowId", SqlDbType.UniqueIdentifier));
            cmd.Parameters["@RowId"].Value = RowId;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow NewRow()
        {
            return (new tsa_ComprobantesReservasRelacionDataset()).tsa_ComprobantesReservasRelacion.Newtsa_ComprobantesReservasRelacionRow();
        }

        public static tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow GetByPk(string IdComprobantePrefacturaReserva)
        {
            tsa_ComprobantesReservasRelacionDataset data = new tsa_ComprobantesReservasRelacionDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdComprobantePrefacturaReserva", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobantePrefacturaReserva"].Value = IdComprobantePrefacturaReserva;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_ComprobantesReservasRelacion");

            adapter.Fill(data);

            if (data.tsa_ComprobantesReservasRelacion.Rows.Count == 1)
            {
                return (tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow)data.tsa_ComprobantesReservasRelacion.Rows[0];
            }

            return null;
        }

        public static void Update(tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionDataTable)row.Table).Addtsa_ComprobantesReservasRelacionRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsa_ComprobantesReservasRelacionDataset dataSet)
        {
            Update(dataSet.tsa_ComprobantesReservasRelacion);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionDataTable)dataTable, trx);
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



        public static void Update(DataTable dataTable, string IdTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            Update(dataTable, trx);
        }

        public static void Update(DataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsa_ComprobantesReservasRelacion", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdComprobantePrefacturaReserva", "IdComprobantePrefacturaReserva" ),
							new System.Data.Common.DataColumnMapping( "IdComprobanteFactura", "IdComprobanteFactura" ),
							new System.Data.Common.DataColumnMapping( "IdComprobanteFacturaPrefacturaReserva", "IdComprobanteFacturaPrefacturaReserva" ),
							new System.Data.Common.DataColumnMapping( "Estado", "Estado" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobantePrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePrefacturaReserva", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobanteFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteFactura", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobanteFacturaPrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteFacturaPrefacturaReserva", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Estado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdComprobantePrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePrefacturaReserva", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdComprobantePrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePrefacturaReserva", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_ComprobantesReservasRelacion_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdComprobantePrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePrefacturaReserva", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdComprobanteFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteFactura", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdComprobanteFacturaPrefacturaReserva", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteFacturaPrefacturaReserva", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Estado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));

            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;
            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }


    }
}

