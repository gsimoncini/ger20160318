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

    public class tsy_AfipTiposDeImpuestosIVARelacionados : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeImpuestosIVARelacionados()
        {
        }

        public static tsy_AfipTiposDeImpuestosIVARelacionadosDataset GetList()
        {
            tsy_AfipTiposDeImpuestosIVARelacionadosDataset data = new tsy_AfipTiposDeImpuestosIVARelacionadosDataset();

            return (tsy_AfipTiposDeImpuestosIVARelacionadosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosIVARelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeImpuestosIVARelacionadosDataset GetList(string Codigo, string Impuesto)
        {
            tsy_AfipTiposDeImpuestosIVARelacionadosDataset data = new tsy_AfipTiposDeImpuestosIVARelacionadosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosIVARelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar));
            cmd.Parameters["@Impuesto"].Value = Impuesto;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosRow NewRow()
        {
            return (new tsy_AfipTiposDeImpuestosIVARelacionadosDataset()).tsy_AfipTiposDeImpuestosIVARelacionados.Newtsy_AfipTiposDeImpuestosIVARelacionadosRow();
        }

        public static tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosRow GetByPk(string Codigo, string Impuesto)
        {
            tsy_AfipTiposDeImpuestosIVARelacionadosDataset data = new tsy_AfipTiposDeImpuestosIVARelacionadosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar));
            cmd.Parameters["@Impuesto"].Value = Impuesto;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosIVARelacionados");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeImpuestosIVARelacionados.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosRow)data.tsy_AfipTiposDeImpuestosIVARelacionados.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosDataTable)row.Table).Addtsy_AfipTiposDeImpuestosIVARelacionadosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeImpuestosIVARelacionadosDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeImpuestosIVARelacionados);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosDataTable)dataTable, trx);
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
            Update((tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeImpuestosIVARelacionadosDataset.tsy_AfipTiposDeImpuestosIVARelacionadosDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeImpuestosIVARelacionados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Impuesto", "Impuesto" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Impuesto", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosIVARelacionados_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Impuesto", DataRowVersion.Current, null));

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





