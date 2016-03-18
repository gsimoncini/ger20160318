//Matias 20110421 - Tarea 0000061
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

    public class tsh_PadronesARBA : IDisposable
    {

        #region Custom Members

        //Nuevo para replicacion
        private static SentenciasReplicacion _replicacion;
        public static SentenciasReplicacion Replicacion
        {
            get { return _replicacion; }
            set { _replicacion = value; }
        }

        #endregion

        public tsh_PadronesARBA()
        {
        }

        public static tsh_PadronesARBADataset GetList()
        {
            tsh_PadronesARBADataset data = new tsh_PadronesARBADataset();

            return (tsh_PadronesARBADataset)GetList(data);
        }

        public static DataSet GetList(DataSet data)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsh_PadronesARBA");

                SqlCommand cmd = new SqlCommand("Pr_tsh_PadronesARBA_GetList", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;

                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetFechaPublicacionDeUltimaActualizacion()
        {
            tsh_PadronesARBADataset data = new tsh_PadronesARBADataset();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsh_PadronesARBA");

                SqlCommand cmd = new SqlCommand("Pr_tsh_PadronARBA_GetFechaPublicacionDeUltimaActualizacion", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;

                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (data.tsh_PadronesARBA.Rows.Count == 1)
            {
                return (tsh_PadronesARBADataset.tsh_PadronesARBARow)data.tsh_PadronesARBA.Rows[0];
            }

            return null;
        }

        public static tsh_PadronesARBADataset.tsh_PadronesARBARow NewRow()
        {
            return (new tsh_PadronesARBADataset()).tsh_PadronesARBA.Newtsh_PadronesARBARow();
        }

        public static tsh_PadronesARBADataset.tsh_PadronesARBARow GetByPk(Int64 IdPadron)
        {
            tsh_PadronesARBADataset data = new tsh_PadronesARBADataset();

            SqlCommand cmd = new SqlCommand("Pr_tsh_PadronesARBA_GetByPk", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt));
            cmd.Parameters["@IdPadron"].Value = IdPadron;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_PadronesARBA");

            adapter.Fill(data);

            if (data.tsh_PadronesARBA.Rows.Count == 1)
            {
                return (tsh_PadronesARBADataset.tsh_PadronesARBARow)data.tsh_PadronesARBA.Rows[0];
            }

            return null;
        }

        public static void UpdateAlicuotasDesdePadron(string filePath, SqlTransaction trx)
        {
            // Aca se invoca al SP que carga el padron y luego actualiza Clientes y Proveedores.
            SqlCommand cmd = new SqlCommand("Pr_tsh_PadronesARBA_UpdateAlicuotas", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = trx.Connection;
            cmd.Transaction = trx;
            cmd.CommandTimeout = 600;

            cmd.Parameters.Add(new SqlParameter("@FilePath", SqlDbType.VarChar));
            cmd.Parameters["@FilePath"].Value = filePath;

            cmd.ExecuteNonQuery();
        }

        public static void Update(tsh_PadronesARBADataset.tsh_PadronesARBARow row)
        {
            if (row.RowState == DataRowState.Detached)
            {
                ((tsh_PadronesARBADataset.tsh_PadronesARBADataTable)row.Table).Addtsh_PadronesARBARow(row);
            }

            Update(row.Table);
        }

        public static void Update(tsh_PadronesARBADataset dataSet)
        {
            Update(dataSet.tsh_PadronesARBA);
        }

        public static void Update(DataTable dataTable)
        {
            SqlConnection cnx = dbhelper.Connection.GetConnection(); ;
            cnx.Open();

            SqlTransaction trx = cnx.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                Update((tsh_PadronesARBADataset.tsh_PadronesARBADataTable)dataTable, trx);
                Replicacion.Update();
                mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
                trx.Commit();
            }
            catch (Exception e)
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
            Update((tsh_PadronesARBADataset.tsh_PadronesARBADataTable)dataTable, trx);
        }

        public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
            if (Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
                Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
        }

        public static void Update(tsh_PadronesARBADataset.tsh_PadronesARBADataTable dataTable, SqlTransaction trx)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.TableMappings.AddRange(
                new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_PadronesARBA", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdPadron", "IdPadron" ),
																											 new System.Data.Common.DataColumnMapping( "FechaPublicacion", "FechaPublicacion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
                                                                                                             new System.Data.Common.DataColumnMapping( "RowId", "RowId" )																											 
																										 }
															  )
														  }
                );

            SqlCommand sqlCommandUpdate = new SqlCommand("Pr_tsh_PadronesARBA_Update", trx.Connection);
            sqlCommandUpdate.Transaction = trx;
            sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@FechaPublicacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaPublicacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "UltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionUltimaModificacion", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@OldIdPadron", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Original, null));

            SqlCommand sqlCommandDelete = new SqlCommand("Pr_tsh_PadronesARBA_Delete", trx.Connection);
            sqlCommandDelete.Transaction = trx;
            sqlCommandDelete.CommandType = CommandType.StoredProcedure;
            sqlCommandDelete.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Original, null));
            //sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );

            SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_PadronesARBA_Insert", trx.Connection);
            sqlCommandInsert.Transaction = trx;
            sqlCommandInsert.CommandType = CommandType.StoredProcedure;
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdPadron", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPadron", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaPublicacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaPublicacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConexionCreacion", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdReservado", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Current, null));
            sqlCommandInsert.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSucursal", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdGenerado", DataRowVersion.Current, null));
            //sqlCommandInsert.Parameters.Add(new SqlParameter("@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ((System.Byte)(0)), ((System.Byte)(0)), "RowIdGenerado", DataRowVersion.Current, null));


            adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);


            adapter.UpdateCommand = sqlCommandUpdate;
            adapter.DeleteCommand = sqlCommandDelete;
            adapter.InsertCommand = sqlCommandInsert;

            adapter.Update(dataTable);
        }

        public void Dispose()
        {
        }

        //public static DataTable GetListEx()
        //{
        //    DataTable data = new DataTable();
        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        adapter.TableMappings.Add("Table", "tsh_PadronesARBA");

        //        SqlCommand cmd = new SqlCommand("Pr_tsh_PadronesARBA_GetListEx", dbhelper.Connection.GetConnection());
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        adapter.SelectCommand = cmd;

        //        adapter.Fill(data);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    return data;
        //}


    }
}