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

    public class tsy_AfipTiposDeImpuestosTributo : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeImpuestosTributo()
        {
        }

        public static tsy_AfipTiposDeImpuestosTributoDataset GetList()
        {
            tsy_AfipTiposDeImpuestosTributoDataset data = new tsy_AfipTiposDeImpuestosTributoDataset();

            return (tsy_AfipTiposDeImpuestosTributoDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributo");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static DataRow GetByImpuesto(string Impuesto)
        {
            tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable data = new tsy_AfipTiposDeImpuestosTributoDataset().tsy_AfipTiposDeImpuestosTributo;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributo");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_SearchByImpuesto", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar));
            cmd.Parameters["@Impuesto"].Value = Impuesto;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            if (data.Rows.Count > 0)
                return data.Rows[0];

            return null;
        }

        public static tsy_AfipTiposDeImpuestosTributoDataset GetList(string Codigo, string Descripcion)
        {
            tsy_AfipTiposDeImpuestosTributoDataset data = new tsy_AfipTiposDeImpuestosTributoDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributo");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            cmd.Parameters["@Descripcion"].Value = Descripcion;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow NewRow()
        {
            return (new tsy_AfipTiposDeImpuestosTributoDataset()).tsy_AfipTiposDeImpuestosTributo.Newtsy_AfipTiposDeImpuestosTributoRow();
        }

        public static tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow GetByPk(string Codigo)
        {
            tsy_AfipTiposDeImpuestosTributoDataset data = new tsy_AfipTiposDeImpuestosTributoDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeImpuestosTributo");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeImpuestosTributo.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow)data.tsy_AfipTiposDeImpuestosTributo.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable)row.Table).Addtsy_AfipTiposDeImpuestosTributoRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeImpuestosTributo);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable)dataTable, trx);
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
            Update((tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeImpuestosTributoDataset.tsy_AfipTiposDeImpuestosTributoDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeImpuestosTributo", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Descripcion", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeImpuestosTributo_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Descripcion", DataRowVersion.Current, null));

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

