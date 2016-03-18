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

    public class tsy_AfipTiposDeComprobantes : IDisposable
    {
        	
		#region Custom Members
		
		#endregion
		
		public tsy_AfipTiposDeComprobantes()
		{
		}

		public static tsy_AfipTiposDeComprobantesDataset GetList()
		{
			tsy_AfipTiposDeComprobantesDataset data = new tsy_AfipTiposDeComprobantesDataset();

			return ( tsy_AfipTiposDeComprobantesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_AfipTiposDeComprobantes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_AfipTiposDeComprobantes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

        public static DataRow GetByIdTipoDeComprobante(string IdTipoDeComprobante)
        {
            tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable data = new tsy_AfipTiposDeComprobantesDataset().tsy_AfipTiposDeComprobantes;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "tsy_AfipTiposDeComprobantes");

            SqlCommand cmd = new SqlCommand("Pr_tsy_AfipTiposDeComprobantes_SearchByIdTipoDeComprobante", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IdTipoDeComprobante", SqlDbType.VarChar));
            cmd.Parameters["@IdTipoDeComprobante"].Value = IdTipoDeComprobante;
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            if (data.Rows.Count > 0)
                return data.Rows[0];
            
            return null;
        }

		public static tsy_AfipTiposDeComprobantesDataset GetList( string Codigo, string Descripcion )
		{
			tsy_AfipTiposDeComprobantesDataset data = new tsy_AfipTiposDeComprobantesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_AfipTiposDeComprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_AfipTiposDeComprobantes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow NewRow()
		{
			return ( new tsy_AfipTiposDeComprobantesDataset() ).tsy_AfipTiposDeComprobantes.Newtsy_AfipTiposDeComprobantesRow();
		}
	
		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow GetByPk( string Codigo )
		{
			tsy_AfipTiposDeComprobantesDataset data = new tsy_AfipTiposDeComprobantesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsy_AfipTiposDeComprobantes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsy_AfipTiposDeComprobantes" );

			adapter.Fill( data );

			if ( data.tsy_AfipTiposDeComprobantes.Rows.Count == 1 )
			{
				return ( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow )data.tsy_AfipTiposDeComprobantes.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable )row.Table ).Addtsy_AfipTiposDeComprobantesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsy_AfipTiposDeComprobantesDataset dataSet )
		{
			Update( dataSet.tsy_AfipTiposDeComprobantes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable )dataTable, trx );
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

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable )dataTable, trx );
		}
				

		public static void Update( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_AfipTiposDeComprobantes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsy_AfipTiposDeComprobantes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
						
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsy_AfipTiposDeComprobantes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_AfipTiposDeComprobantes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			
			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		
	}
}

