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

    public class tsh_CombosDetListasDePrecios : IDisposable
    {

        #region Custom Members
        private static SentenciasReplicacion _replication;

        public static tsh_CombosDetListasDePreciosDataset GetByIdProductoOrdinal(string IdProducto, long Ordinal)
        {
            tsh_CombosDetListasDePreciosDataset data = new tsh_CombosDetListasDePreciosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDetListasDePrecios");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_SearchByIdProductoOrdinal", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;
            cmd.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt));
            if (Ordinal == long.MinValue)
            {
                cmd.Parameters["@Ordinal"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Ordinal"].Value = Ordinal;
            }
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }
        #endregion

        public tsh_CombosDetListasDePrecios()
        {
        }

        public static tsh_CombosDetListasDePreciosDataset GetList()
        {
            tsh_CombosDetListasDePreciosDataset data = new tsh_CombosDetListasDePreciosDataset();

            return (tsh_CombosDetListasDePreciosDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDetListasDePrecios");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_CombosDetListasDePreciosDataset GetList(string IdProducto, long Ordinal, string IdListaDePrecio, string ModoDeAplicacion, decimal Coeficiente, decimal PrecioDeVentaBruto, DateTime FechaUltimaModificacionPrecioDeVenta, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal PrecioDeVentaBrutoOriginal, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal)
        {
            tsh_CombosDetListasDePreciosDataset data = new tsh_CombosDetListasDePreciosDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDetListasDePrecios");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_Search", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;
            cmd.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt));
            if (Ordinal == long.MinValue)
            {
                cmd.Parameters["@Ordinal"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Ordinal"].Value = Ordinal;
            }
            cmd.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar));
            cmd.Parameters["@IdListaDePrecio"].Value = IdListaDePrecio;
            cmd.Parameters.Add(new SqlParameter("@ModoDeAplicacion", SqlDbType.VarChar));
            cmd.Parameters["@ModoDeAplicacion"].Value = ModoDeAplicacion;
            cmd.Parameters.Add(new SqlParameter("@Coeficiente", SqlDbType.Decimal));
            cmd.Parameters["@Coeficiente"].Value = Coeficiente;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeVentaBruto"].Value = PrecioDeVentaBruto;
            cmd.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime));
            cmd.Parameters["@FechaUltimaModificacionPrecioDeVenta"].Value = FechaUltimaModificacionPrecioDeVenta;
            cmd.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal));
            cmd.Parameters["@DescuentoCombo"].Value = DescuentoCombo;
            cmd.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal));
            cmd.Parameters["@DescuentoComboPorcentual"].Value = DescuentoComboPorcentual;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeVentaBrutoOriginal"].Value = PrecioDeVentaBrutoOriginal;
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
            cmd.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt));
            if (IdReservado == long.MinValue)
            {
                cmd.Parameters["@IdReservado"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdReservado"].Value = IdReservado;
            }
            cmd.Parameters.Add(new SqlParameter("@RowId", SqlDbType.UniqueIdentifier));
            cmd.Parameters["@RowId"].Value = RowId;
            cmd.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt));
            if (IdEmpresa == long.MinValue)
            {
                cmd.Parameters["@IdEmpresa"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdEmpresa"].Value = IdEmpresa;
            }
            cmd.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt));
            if (IdSucursal == long.MinValue)
            {
                cmd.Parameters["@IdSucursal"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdSucursal"].Value = IdSucursal;
            }
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow NewRow()
        {
            return (new tsh_CombosDetListasDePreciosDataset()).tsh_CombosDetListasDePrecios.Newtsh_CombosDetListasDePreciosRow();
        }

        public static tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow GetByPk(string IdProducto, long Ordinal, string IdListaDePrecio)
        {
            tsh_CombosDetListasDePreciosDataset data = new tsh_CombosDetListasDePreciosDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;

            cmd.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt));
            cmd.Parameters["@Ordinal"].Value = Ordinal;

            cmd.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar));
            cmd.Parameters["@IdListaDePrecio"].Value = IdListaDePrecio;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_CombosDetListasDePrecios");

            adapter.Fill(data);

            if (data.tsh_CombosDetListasDePrecios.Rows.Count == 1)
            {
                return (tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow)data.tsh_CombosDetListasDePrecios.Rows[0];
            }

            return null;
        }

        public static void Update(tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosDataTable)row.Table).Addtsh_CombosDetListasDePreciosRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsh_CombosDetListasDePreciosDataset dataSet)
        {
            Update(dataSet.tsh_CombosDetListasDePrecios);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosDataTable)dataTable, trx);
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
            SentenciasReplicacion replicacion = new SentenciasReplicacion();
            Update(dataTable, trx, replicacion);
        }


        public static void Update(DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsh_CombosDetListasDePrecios", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
							new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" ),
							new System.Data.Common.DataColumnMapping( "IdListaDePrecio", "IdListaDePrecio" ),
							new System.Data.Common.DataColumnMapping( "ModoDeAplicacion", "ModoDeAplicacion" ),
							new System.Data.Common.DataColumnMapping( "Coeficiente", "Coeficiente" ),
							new System.Data.Common.DataColumnMapping( "PrecioDeVentaBruto", "PrecioDeVentaBruto" ),
							new System.Data.Common.DataColumnMapping( "FechaUltimaModificacionPrecioDeVenta", "FechaUltimaModificacionPrecioDeVenta" ),
							new System.Data.Common.DataColumnMapping( "DescuentoCombo", "DescuentoCombo" ),
							new System.Data.Common.DataColumnMapping( "DescuentoComboPorcentual", "DescuentoComboPorcentual" ),
							new System.Data.Common.DataColumnMapping( "PrecioDeVentaBrutoOriginal", "PrecioDeVentaBrutoOriginal" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@ModoDeAplicacion", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ModoDeAplicacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Coeficiente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoCombo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoComboPorcentual", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBrutoOriginal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_CombosDetListasDePrecios_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@ModoDeAplicacion", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ModoDeAplicacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Coeficiente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coeficiente", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoCombo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoComboPorcentual", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBrutoOriginal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));

            #region Replicacion

            _replication = replicacion;
            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            #endregion

            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;
            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }

        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            try
            {

                StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
                if (_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
                    _replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}

