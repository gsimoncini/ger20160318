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

    public class tsh_ProductosListasDePreciosCategoriasCuentas : IDisposable
    {

        #region Custom Members

        public static DataSet GetListEx()
        {
            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_ProductosListasDePreciosCategoriasCuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_GetListEx", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static string GetListaDePrecios(string JerarquiaCuentas, string JerarquiaProductos)
        {
            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_ProductosListasDePreciosCategoriasCuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_GetListaDePrecios", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCuentas", SqlDbType.VarChar));
            cmd.Parameters["@JerarquiaCuentas"].Value = JerarquiaCuentas;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaProductos", SqlDbType.VarChar));
            cmd.Parameters["@JerarquiaProductos"].Value = JerarquiaProductos;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            if (data.Tables[0].Rows.Count > 0)
            {
                return (data.Tables[0].Rows[0]["IdListaDePrecio"].ToString());
            }

            return null;
        }

        #endregion

        public tsh_ProductosListasDePreciosCategoriasCuentas()
        {
        }

        public static tsh_ProductosListasDePreciosCategoriasCuentasDataset GetList()
        {
            tsh_ProductosListasDePreciosCategoriasCuentasDataset data = new tsh_ProductosListasDePreciosCategoriasCuentasDataset();

            return (tsh_ProductosListasDePreciosCategoriasCuentasDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_ProductosListasDePreciosCategoriasCuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_ProductosListasDePreciosCategoriasCuentasDataset GetList(string IdNomenclaturaCuenta, string IdNomenclaturaProducto, string IdListaDePrecio)
        {
            tsh_ProductosListasDePreciosCategoriasCuentasDataset data = new tsh_ProductosListasDePreciosCategoriasCuentasDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_ProductosListasDePreciosCategoriasCuentas");

            SqlCommand cmd = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdNomenclaturaCuenta", SqlDbType.VarChar));
            cmd.Parameters["@IdNomenclaturaCuenta"].Value = IdNomenclaturaCuenta;

            cmd.Parameters.Add(new SqlParameter("@IdNomenclaturaProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdNomenclaturaProducto"].Value = IdNomenclaturaProducto;

            cmd.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar));
            cmd.Parameters["@IdListaDePrecio"].Value = IdListaDePrecio;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow NewRow()
        {
            return (new tsh_ProductosListasDePreciosCategoriasCuentasDataset()).tsh_ProductosListasDePreciosCategoriasCuentas.Newtsh_ProductosListasDePreciosCategoriasCuentasRow();
        }

        public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow GetByPk(string IdNomenclaturaCuenta, string IdNomenclaturaProducto)
        {
            tsh_ProductosListasDePreciosCategoriasCuentasDataset data = new tsh_ProductosListasDePreciosCategoriasCuentasDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdNomenclaturaCuenta", SqlDbType.VarChar));
            cmd.Parameters["@IdNomenclaturaCuenta"].Value = IdNomenclaturaCuenta;

            cmd.Parameters.Add(new SqlParameter("@IdNomenclaturaProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdNomenclaturaProducto"].Value = IdNomenclaturaProducto;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_ProductosListasDePreciosCategoriasCuentas");

            adapter.Fill(data);

            if (data.tsh_ProductosListasDePreciosCategoriasCuentas.Rows.Count == 1)
            {
                return (tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow)data.tsh_ProductosListasDePreciosCategoriasCuentas.Rows[0];
            }

            return null;
        }

        public static void Update(tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable)row.Table).Addtsh_ProductosListasDePreciosCategoriasCuentasRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsh_ProductosListasDePreciosCategoriasCuentasDataset dataSet)
        {
            Update(dataSet.tsh_ProductosListasDePreciosCategoriasCuentas);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable)dataTable, trx);
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
            Update((tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable)dataTable, trx);
        }

        public static void Update(System.Data.DataTable dataTable, string IdTransaction)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            Update(dataTable, trx);
        }

        public static void Update(tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsh_ProductosListasDePreciosCategoriasCuentas", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdNomenclaturaCuenta", "IdNomenclaturaCuenta" ),
							new System.Data.Common.DataColumnMapping( "IdNomenclaturaProducto", "IdNomenclaturaProducto" ),
							new System.Data.Common.DataColumnMapping( "IdListaDePrecio", "IdListaDePrecio" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdNomenclaturaCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaCuenta", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdNomenclaturaProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaProducto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdNomenclaturaCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaCuenta", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdNomenclaturaProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaProducto", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdNomenclaturaCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaCuenta", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdNomenclaturaProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaProducto", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProductosListasDePreciosCategoriasCuentas_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdNomenclaturaCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaCuenta", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdNomenclaturaProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdNomenclaturaProducto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));

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

