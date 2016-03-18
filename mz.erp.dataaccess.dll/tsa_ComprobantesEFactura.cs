//tsa_ComprobantesEFactura
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

    public class tsa_ComprobantesEFactura : IDisposable
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

        public tsa_ComprobantesEFactura()
        {
        }

        public static tsa_ComprobantesEFacturaDataset GetList()
        {
            tsa_ComprobantesEFacturaDataset data = new tsa_ComprobantesEFacturaDataset();

            return (tsa_ComprobantesEFacturaDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsa_ComprobantesEFactura");

                SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesEFactura_GetList", dbhelper.Connection.GetConnection());
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

        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow NewRow()
        {
            return (new tsa_ComprobantesEFacturaDataset()).tsa_ComprobantesEFactura.Newtsa_ComprobantesEFacturaRow();
        }

        public static tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow GetByPk(string IdComprobante)
        {
            tsa_ComprobantesEFacturaDataset data = new tsa_ComprobantesEFacturaDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesEFactura_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.BigInt));
            cmd.Parameters["@IdComprobante"].Value = IdComprobante;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsa_ComprobantesEFactura");

            adapter.Fill(data);

            if (data.tsa_ComprobantesEFactura.Rows.Count == 1)
            {
                return (tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow)data.tsa_ComprobantesEFactura.Rows[0];
            }

            return null;
        }

        public static void Update(tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable)row.Table).Addtsa_ComprobantesEFacturaRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsa_ComprobantesEFacturaDataset dataSet)
        {
            Update(dataSet.tsa_ComprobantesEFactura);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable)dataTable, trx);
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
            Update((tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable)dataTable, trx);
        }

        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
            if (Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
                Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
        }

        public static void Update(DataTable dataTable, String idTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(idTransaction);
            Update(dataTable, trx);
        }

        public static void Update(DataTable dataTable, String IdTransaction, SentenciasReplicacion replicacion)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            Update(dataTable, trx, replicacion);
        }
        //tsa_ComprobantesEFacturaDataset.tsa_ComprobantesEFacturaDataTable
        public static void Update(DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_ComprobantesEFactura", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "CAE", "CAE" ),
																											 new System.Data.Common.DataColumnMapping( "FechaVencimientoCAE", "FechaVencimientoCAE" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "Motivo", "Motivo" ),
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

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsa_ComprobantesEFactura_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@CAE", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CAE", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaVencimientoCAE", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVencimientoCAE", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Motivo", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Motivo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsa_ComprobantesEFactura_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null));
            //sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_ComprobantesEFactura_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@CAE", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CAE", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaVencimientoCAE", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaVencimientoCAE", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Motivo", SqlDbType.VarChar, 500, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Motivo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdGenerado", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "RowIdGenerado", DataRowVersion.Current, null));

            #region Replicacion

            _replicacion = replicacion;
            adapter.RowUpdating += new SqlRowUpdatingEventHandler(adapter_RowUpdating);
            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            #endregion

            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            
            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;

            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }

        private static void adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
        {
        }

        //public static DataTable GetListEx()
        //{
        //    DataTable data = new DataTable();
        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        adapter.TableMappings.Add("Table", "tsa_ComprobantesEFactura");

        //        SqlCommand cmd = new SqlCommand("Pr_tsa_ComprobantesEFactura_GetListEx", dbhelper.Connection.GetConnection());
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

