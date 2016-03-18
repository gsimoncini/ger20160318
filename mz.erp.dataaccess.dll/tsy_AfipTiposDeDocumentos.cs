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

    public class tsy_AfipTiposDeDocumentos : IDisposable
    {

        #region Custom Members

        #endregion

        public tsy_AfipTiposDeDocumentos()
        {
        }

        public static tsy_AfipTiposDeDocumentosDataset GetList()
        {
            tsy_AfipTiposDeDocumentosDataset data = new tsy_AfipTiposDeDocumentosDataset();

            return (tsy_AfipTiposDeDocumentosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentos");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static DataRow GetByIdTipoDeDocumento(string IdTipoDeDocumento)
        {
            tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable data = new tsy_AfipTiposDeDocumentosDataset().tsy_AfipTiposDeDocumentos;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentos");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_SearchByIdTipoDeDocumento", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDeDocumento", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeDocumento"].Value = IdTipoDeDocumento;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            if (data.Rows.Count > 0)
                return data.Rows[0];

            return null;
        }

        public static tsy_AfipTiposDeDocumentosDataset GetList(string Codigo, string Descripcion)
        {
            tsy_AfipTiposDeDocumentosDataset data = new tsy_AfipTiposDeDocumentosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentos");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            cmd.Parameters["@Descripcion"].Value = Descripcion;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow NewRow()
        {
            return (new tsy_AfipTiposDeDocumentosDataset()).tsy_AfipTiposDeDocumentos.Newtsy_AfipTiposDeDocumentosRow();
        }

        public static tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow GetByPk(string Codigo)
        {
            tsy_AfipTiposDeDocumentosDataset data = new tsy_AfipTiposDeDocumentosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cmd.Parameters["@Codigo"].Value = Codigo;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeDocumentos");

            adapter.Fill(data);

            if (data.tsy_AfipTiposDeDocumentos.Rows.Count == 1)
            {
                return (tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow)data.tsy_AfipTiposDeDocumentos.Rows[0];
            }

            return null;
        }

        public static void Update(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable)row.Table).Addtsy_AfipTiposDeDocumentosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsy_AfipTiposDeDocumentosDataset dataSet)
        {
            Update(dataSet.tsy_AfipTiposDeDocumentos);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable)dataTable, trx);
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
            Update((tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable)dataTable, trx);
        }


        public static void Update(tsy_AfipTiposDeDocumentosDataset.tsy_AfipTiposDeDocumentosDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeDocumentos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" )
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Descripcion", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Codigo", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeDocumentos_Insert", trx.Connection);
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

