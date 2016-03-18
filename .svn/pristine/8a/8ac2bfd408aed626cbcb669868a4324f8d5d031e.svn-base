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

    public class tsy_AfipTiposDeDocumentosRelacionados : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeDocumentosRelacionados()
        {
        }

        public static tsy_AfipTiposDeDocumentosRelacionadosDataset GetList()
        {
            tsy_AfipTiposDeDocumentosRelacionadosDataset data = new tsy_AfipTiposDeDocumentosRelacionadosDataset();

            return (tsy_AfipTiposDeDocumentosRelacionadosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentosRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeDocumentosRelacionadosDataset GetList(string Codigo, string IdTipoDeDocumento)
        {
            tsy_AfipTiposDeDocumentosRelacionadosDataset data = new tsy_AfipTiposDeDocumentosRelacionadosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentosRelacionados");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@IdTipoDeDocumento", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeDocumento"].Value = IdTipoDeDocumento;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosRow NewRow()
        {
            return (new tsy_AfipTiposDeDocumentosRelacionadosDataset()).tsy_AfipTiposDeDocumentosRelacionados.Newtsy_AfipTiposDeDocumentosRelacionadosRow();
        }

        public static tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosRow GetByPk(string Codigo, string IdTipoDeDocumento)
        {
            tsy_AfipTiposDeDocumentosRelacionadosDataset data = new tsy_AfipTiposDeDocumentosRelacionadosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDeDocumento", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeDocumento"].Value = IdTipoDeDocumento;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentosRelacionados");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeDocumentosRelacionados.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosRow)data.tsy_AfipTiposDeDocumentosRelacionados.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosDataTable)row.Table).Addtsy_AfipTiposDeDocumentosRelacionadosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeDocumentosRelacionadosDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeDocumentosRelacionados);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosDataTable)dataTable, trx);
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
            Update((tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeDocumentosRelacionadosDataset.tsy_AfipTiposDeDocumentosRelacionadosDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeDocumentosRelacionados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeDocumento", "IdTipoDeDocumento" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdTipoDeDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoDeDocumento", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeDocumentosRelacionados_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdTipoDeDocumento", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoDeDocumento", DataRowVersion.Current, null));

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


