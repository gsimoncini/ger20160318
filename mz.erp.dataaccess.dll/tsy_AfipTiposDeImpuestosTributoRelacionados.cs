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

    public class tsy_AfipTiposDeImpuestosTributoRelacionados : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeImpuestosTributoRelacionados()
        {
        }

        public static tsy_AfipTiposDeImpuestosTributoRelacionadosDataset GetList()
        {
            tsy_AfipTiposDeImpuestosTributoRelacionadosDataset data = new tsy_AfipTiposDeImpuestosTributoRelacionadosDataset();

            return (tsy_AfipTiposDeImpuestosTributoRelacionadosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributoRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeImpuestosTributoRelacionadosDataset GetList(string Codigo, string Impuesto)
        {
            tsy_AfipTiposDeImpuestosTributoRelacionadosDataset data = new tsy_AfipTiposDeImpuestosTributoRelacionadosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributoRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar));
            cmd.Parameters["@Impuesto"].Value = Impuesto;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosRow NewRow()
        {
            return (new tsy_AfipTiposDeImpuestosTributoRelacionadosDataset()).tsy_AfipTiposDeImpuestosTributoRelacionados.Newtsy_AfipTiposDeImpuestosTributoRelacionadosRow();
        }

        public static tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosRow GetByPk(string Codigo, string Impuesto)
        {
            tsy_AfipTiposDeImpuestosTributoRelacionadosDataset data = new tsy_AfipTiposDeImpuestosTributoRelacionadosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar));
            cmd.Parameters["@Impuesto"].Value = Impuesto;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributoRelacionados");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeImpuestosTributoRelacionados.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosRow)data.tsy_AfipTiposDeImpuestosTributoRelacionados.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosDataTable)row.Table).Addtsy_AfipTiposDeImpuestosTributoRelacionadosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeImpuestosTributoRelacionadosDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeImpuestosTributoRelacionados);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosDataTable)dataTable, trx);
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
            Update((tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeImpuestosTributoRelacionadosDataset.tsy_AfipTiposDeImpuestosTributoRelacionadosDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeImpuestosTributoRelacionados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Impuesto", "Impuesto" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Impuesto", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributoRelacionados_Insert", trx.Connection);
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




