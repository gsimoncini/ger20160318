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

    public class tsy_AfipTiposDeComprobantesRelacionados : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeComprobantesRelacionados()
        {
        }

        public static tsy_AfipTiposDeComprobantesRelacionadosDataset GetList()
        {
            tsy_AfipTiposDeComprobantesRelacionadosDataset data = new tsy_AfipTiposDeComprobantesRelacionadosDataset();

            return (tsy_AfipTiposDeComprobantesRelacionadosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeComprobantesRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeComprobantesRelacionadosDataset GetList(string Codigo, string IdTipoDeComprobante)
        {
            tsy_AfipTiposDeComprobantesRelacionadosDataset data = new tsy_AfipTiposDeComprobantesRelacionadosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeComprobantesRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@IdTipoDeComprobante", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeComprobante"].Value = IdTipoDeComprobante;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosRow NewRow()
        {
            return (new tsy_AfipTiposDeComprobantesRelacionadosDataset()).tsy_AfipTiposDeComprobantesRelacionados.Newtsy_AfipTiposDeComprobantesRelacionadosRow();
        }

        public static tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosRow GetByPk(string Codigo, string IdTipoDeComprobante)
        {
            tsy_AfipTiposDeComprobantesRelacionadosDataset data = new tsy_AfipTiposDeComprobantesRelacionadosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDeComprobante", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeComprobante"].Value = IdTipoDeComprobante;            

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeComprobantesRelacionados");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeComprobantesRelacionados.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosRow)data.tsy_AfipTiposDeComprobantesRelacionados.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosDataTable)row.Table).Addtsy_AfipTiposDeComprobantesRelacionadosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeComprobantesRelacionadosDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeComprobantesRelacionados);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosDataTable)dataTable, trx);
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

        public static void Update(DataTable dataTable, SqlTransaction trx)
        {
            Update((tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeComprobantesRelacionadosDataset.tsy_AfipTiposDeComprobantesRelacionadosDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeComprobantesRelacionados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoDeComprobante", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeComprobantesRelacionados_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoDeComprobante", DataRowVersion.Current, null));

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

