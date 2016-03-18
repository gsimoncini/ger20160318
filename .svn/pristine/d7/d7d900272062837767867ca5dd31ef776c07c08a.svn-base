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

    public class tsh_CombosDet : IDisposable
    {

        #region Custom Members
        private static SentenciasReplicacion _replication;

        public static tsh_CombosDetDataset GetByIdProducto(string IdProducto)
        {
            tsh_CombosDetDataset data = new tsh_CombosDetDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDet");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_SearchByIdProducto", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_CombosDetDataset GetByIdProductoReferencia(string IdProductoReferencia)
        {
            tsh_CombosDetDataset data = new tsh_CombosDetDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDet");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_SearchByIdProductoReferencia", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProductoReferencia", SqlDbType.VarChar));
            cmd.Parameters["@IdProductoReferencia"].Value = IdProductoReferencia;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static void ActualizarPreciosProductosCombo(string IdTransaction, string IdProductoReferencia, decimal PrecioDeCostoRef, decimal PrecioDeVentaBrutoOriginal, string IdMonedaCierrePrecioDeCostoRef, string IdMonedaCierrePrecioDeVentaBruto, string IdCotizacionCierrePrecioDeCostoRef, string IdCotizacionCierrePrecioDeVentaBruto)
        {
            SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            SqlCommand cmd = new SqlCommand("Pr_tsh_ComboDet_ActualizarPreciosProductosCombo", trx.Connection);
            cmd.Transaction = trx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdProductoReferencia", SqlDbType.VarChar));
            cmd.Parameters["@IdProductoReferencia"].Value = IdProductoReferencia;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeCostoRef", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeCostoRef"].Value = PrecioDeCostoRef;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeVentaBrutoOriginal"].Value = PrecioDeVentaBrutoOriginal;
            cmd.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeCostoRef", SqlDbType.VarChar));
            cmd.Parameters["@IdMonedaCierrePrecioDeCostoRef"].Value = IdMonedaCierrePrecioDeCostoRef;
            cmd.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeVentaBruto", SqlDbType.VarChar));
            cmd.Parameters["@IdMonedaCierrePrecioDeVentaBruto"].Value = IdMonedaCierrePrecioDeVentaBruto;
            cmd.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeCostoRef", SqlDbType.VarChar));
            cmd.Parameters["@IdCotizacionCierrePrecioDeCostoRef"].Value = IdCotizacionCierrePrecioDeCostoRef;
            cmd.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeVentaBruto", SqlDbType.VarChar));
            cmd.Parameters["@IdCotizacionCierrePrecioDeVentaBruto"].Value = IdCotizacionCierrePrecioDeVentaBruto;
            cmd.ExecuteNonQuery();
        }

        public static System.Data.DataSet SearchEx(string IdProducto)
        {
            System.Data.DataSet data = new System.Data.DataSet();

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_SearchEx", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            if (IdProducto == "")
            {
                cmd.Parameters["@IdProducto"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@IdProducto"].Value = IdProducto;
            }


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.TableMappings.Add("Table", "TableDetalleCombo");
            adapter.Fill(data);
            return data;
        }

        #endregion

        public tsh_CombosDet()
        {
        }

        public static tsh_CombosDetDataset GetList()
        {
            tsh_CombosDetDataset data = new tsh_CombosDetDataset();

            return (tsh_CombosDetDataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDet");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

        public static tsh_CombosDetDataset GetList(string IdProducto, long Ordinal, string IdProductoReferencia, decimal Cantidad, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal PrecioDeVentaBrutoOriginal, decimal PrecioDeVentaBruto, decimal PrecioDeCostoRef, DateTime FechaUltimaModificacionPrecioDeCosto, DateTime FechaUltimaModificacionPrecioDeVenta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal)
        {
            tsh_CombosDetDataset data = new tsh_CombosDetDataset();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsh_CombosDet");

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_Search", dbhelper.Connection.GetConnection());
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
            cmd.Parameters.Add(new SqlParameter("@IdProductoReferencia", SqlDbType.VarChar));
            cmd.Parameters["@IdProductoReferencia"].Value = IdProductoReferencia;
            cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Decimal));
            cmd.Parameters["@Cantidad"].Value = Cantidad;
            cmd.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal));
            cmd.Parameters["@DescuentoCombo"].Value = DescuentoCombo;
            cmd.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal));
            cmd.Parameters["@DescuentoComboPorcentual"].Value = DescuentoComboPorcentual;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeVentaBrutoOriginal"].Value = PrecioDeVentaBrutoOriginal;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeVentaBruto"].Value = PrecioDeVentaBruto;
            cmd.Parameters.Add(new SqlParameter("@PrecioDeCostoRef", SqlDbType.Decimal));
            cmd.Parameters["@PrecioDeCostoRef"].Value = PrecioDeCostoRef;
            cmd.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime));
            cmd.Parameters["@FechaUltimaModificacionPrecioDeCosto"].Value = FechaUltimaModificacionPrecioDeCosto;
            cmd.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime));
            cmd.Parameters["@FechaUltimaModificacionPrecioDeVenta"].Value = FechaUltimaModificacionPrecioDeVenta;
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

        public static tsh_CombosDetDataset.tsh_CombosDetRow NewRow()
        {
            return (new tsh_CombosDetDataset()).tsh_CombosDet.Newtsh_CombosDetRow();
        }

        public static tsh_CombosDetDataset.tsh_CombosDetRow GetByPk(string IdProducto, long Ordinal)
        {
            tsh_CombosDetDataset data = new tsh_CombosDetDataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_CombosDet_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar));
            cmd.Parameters["@IdProducto"].Value = IdProducto;

            cmd.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt));
            cmd.Parameters["@Ordinal"].Value = Ordinal;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_CombosDet");

            adapter.Fill(data);

            if (data.tsh_CombosDet.Rows.Count == 1)
            {
                return (tsh_CombosDetDataset.tsh_CombosDetRow)data.tsh_CombosDet.Rows[0];
            }

            return null;
        }

        public static void Update(tsh_CombosDetDataset.tsh_CombosDetRow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsh_CombosDetDataset.tsh_CombosDetDataTable)row.Table).Addtsh_CombosDetRow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsh_CombosDetDataset dataSet)
        {
            Update(dataSet.tsh_CombosDet);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsh_CombosDetDataset.tsh_CombosDetDataTable)dataTable, trx);
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


    public static void Update(DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsh_CombosDet", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
							new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" ),
							new System.Data.Common.DataColumnMapping( "IdProductoReferencia", "IdProductoReferencia" ),
							new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
							new System.Data.Common.DataColumnMapping( "DescuentoCombo", "DescuentoCombo" ),
							new System.Data.Common.DataColumnMapping( "DescuentoComboPorcentual", "DescuentoComboPorcentual" ),
							new System.Data.Common.DataColumnMapping( "PrecioDeVentaBrutoOriginal", "PrecioDeVentaBrutoOriginal" ),
							new System.Data.Common.DataColumnMapping( "PrecioDeVentaBruto", "PrecioDeVentaBruto" ),
							new System.Data.Common.DataColumnMapping( "PrecioDeCostoRef", "PrecioDeCostoRef" ),
							new System.Data.Common.DataColumnMapping( "FechaUltimaModificacionPrecioDeCosto", "FechaUltimaModificacionPrecioDeCosto" ),
							new System.Data.Common.DataColumnMapping( "FechaUltimaModificacionPrecioDeVenta", "FechaUltimaModificacionPrecioDeVenta" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
							new System.Data.Common.DataColumnMapping( "IdMonedaCierrePrecioDeCostoRef", "IdMonedaCierrePrecioDeCostoRef" ),
							new System.Data.Common.DataColumnMapping( "IdMonedaCierrePrecioDeVentaBruto", "IdMonedaCierrePrecioDeVentaBruto" ),
							new System.Data.Common.DataColumnMapping( "IdCotizacionCierrePrecioDeCostoRef", "IdCotizacionCierrePrecioDeCostoRef" ),
							new System.Data.Common.DataColumnMapping( "IdCotizacionCierrePrecioDeVentaBruto", "IdCotizacionCierrePrecioDeVentaBruto" )
						}
					)
				}
            );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsh_CombosDet_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdProductoReferencia", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProductoReferencia", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cantidad", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoCombo", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoComboPorcentual", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBrutoOriginal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeCostoRef", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMonedaCierrePrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeVentaBruto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMonedaCierrePrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeCostoRef", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCotizacionCierrePrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeVentaBruto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCotizacionCierrePrecioDeVentaBruto", DataRowVersion.Current, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsh_CombosDet_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null));
            sqlCommandDelete.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Original, null));

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_CombosDet_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdProductoReferencia", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProductoReferencia", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cantidad", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@DescuentoCombo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoCombo", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@DescuentoComboPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DescuentoComboPorcentual", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@PrecioDeVentaBrutoOriginal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBrutoOriginal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeCostoRef", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMonedaCierrePrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdMonedaCierrePrecioDeVentaBruto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMonedaCierrePrecioDeVentaBruto", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeCostoRef", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCotizacionCierrePrecioDeCostoRef", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdCotizacionCierrePrecioDeVentaBruto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCotizacionCierrePrecioDeVentaBruto", DataRowVersion.Current, null));

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

