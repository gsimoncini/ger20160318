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

    public class st_TipoEquipoFalla : IDisposable
    {

        #region Custom Members

        public static st_TipoEquipoFallaDataset GetByIdFalla(long IdFalla)
        {
            st_TipoEquipoFallaDataset data = new st_TipoEquipoFallaDataset();

            SqlCommand cmd = new SqlCommand("Pr_st_TipoEquipoFalla_GetByIdFalla", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdFalla", SqlDbType.BigInt));
            cmd.Parameters["@IdFalla"].Value = IdFalla;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "st_TipoEquipoFalla");

            adapter.Fill(data);

            return data;
        }

        #endregion

        public st_TipoEquipoFalla()
        {
        }

        public static st_TipoEquipoFallaDataset GetList()
        {
            st_TipoEquipoFallaDataset data = new st_TipoEquipoFallaDataset();

            return (st_TipoEquipoFallaDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "st_TipoEquipoFalla");

            SqlCommand cmd = new SqlCommand("Pr_st_TipoEquipoFalla_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static st_TipoEquipoFallaDataset GetList(long IdTipoEquipoFalla, long IdTipoEquipo, long IdFalla, decimal ImporteMinimo, decimal ImportePresupuesto, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId)
        {
            st_TipoEquipoFallaDataset data = new st_TipoEquipoFallaDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "st_TipoEquipoFalla");

            SqlCommand cmd = new SqlCommand("Pr_st_TipoEquipoFalla_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoEquipoFalla", SqlDbType.BigInt));
            if (IdTipoEquipoFalla == long.MinValue)
            {
                cmd.Parameters["@IdTipoEquipoFalla"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdTipoEquipoFalla"].Value = IdTipoEquipoFalla;
            }
            cmd.Parameters.Add(new SqlParameter("@IdTipoEquipo", SqlDbType.BigInt));
            if (IdTipoEquipo == long.MinValue)
            {
                cmd.Parameters["@IdTipoEquipo"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdTipoEquipo"].Value = IdTipoEquipo;
            }
            cmd.Parameters.Add(new SqlParameter("@IdFalla", SqlDbType.BigInt));
            if (IdFalla == long.MinValue)
            {
                cmd.Parameters["@IdFalla"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdFalla"].Value = IdFalla;
            }
            cmd.Parameters.Add(new SqlParameter("@ImporteMinimo", SqlDbType.Decimal));
            cmd.Parameters["@ImporteMinimo"].Value = ImporteMinimo;
            cmd.Parameters.Add(new SqlParameter("@ImportePresupuesto", SqlDbType.Decimal));
            cmd.Parameters["@ImportePresupuesto"].Value = ImportePresupuesto;
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

        public static st_TipoEquipoFallaDataset.st_TipoEquipoFallaRow NewRow()
        {
            return (new st_TipoEquipoFallaDataset())._st_TipoEquipoFalla.Newst_TipoEquipoFallaRow();
        }

        public static st_TipoEquipoFallaDataset.st_TipoEquipoFallaRow GetByPk(long IdTipoEquipoFalla)
        {
            st_TipoEquipoFallaDataset data = new st_TipoEquipoFallaDataset();
            
            SqlCommand cmd = new SqlCommand("Pr_st_TipoEquipoFalla_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoEquipoFalla", SqlDbType.BigInt));
            cmd.Parameters["@IdTipoEquipoFalla"].Value = IdTipoEquipoFalla;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "st_TipoEquipoFalla");

            adapter.Fill(data);

            if (data._st_TipoEquipoFalla.Rows.Count == 1)
            {
                return (st_TipoEquipoFallaDataset.st_TipoEquipoFallaRow)data._st_TipoEquipoFalla.Rows[0];
            }

            return null;
        }

        public static void Update(st_TipoEquipoFallaDataset.st_TipoEquipoFallaRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((st_TipoEquipoFallaDataset.st_TipoEquipoFallaDataTable)row.Table).Addst_TipoEquipoFallaRow(row);
            }

            Update(row.Table);
        }

        public static void Update(st_TipoEquipoFallaDataset dataSet)
        {
            Update(dataSet._st_TipoEquipoFalla);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((st_TipoEquipoFallaDataset.st_TipoEquipoFallaDataTable)dataTable, trx);
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
            Update((st_TipoEquipoFallaDataset.st_TipoEquipoFallaDataTable)dataTable, trx);
        }


        public static void Update(st_TipoEquipoFallaDataset.st_TipoEquipoFallaDataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "st_TipoEquipoFalla", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdTipoEquipoFalla", "IdTipoEquipoFalla" ),
							new System.Data.Common.DataColumnMapping( "IdTipoEquipo", "IdTipoEquipo" ),
							new System.Data.Common.DataColumnMapping( "IdFalla", "IdFalla" ),
							new System.Data.Common.DataColumnMapping( "ImporteMinimo", "ImporteMinimo" ),
							new System.Data.Common.DataColumnMapping( "ImportePresupuesto", "ImportePresupuesto" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_st_TipoEquipoFalla_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdTipoEquipoFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipoFalla", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdTipoEquipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdFalla", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@ImporteMinimo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ImporteMinimo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@ImportePresupuesto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ImportePresupuesto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdTipoEquipoFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipoFalla", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_st_TipoEquipoFalla_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdTipoEquipoFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipoFalla", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_TipoEquipoFalla_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdTipoEquipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdFalla", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@ImporteMinimo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ImporteMinimo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@ImportePresupuesto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ImportePresupuesto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdTipoEquipoFalla", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoEquipoFalla", DataRowVersion.Current, null));

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

