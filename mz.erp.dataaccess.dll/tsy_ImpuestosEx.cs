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

	public class tsy_ImpuestosEx : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetList()
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_Impuestos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_Impuestos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;
			DataSet data = new DataSet();
			adapter.Fill( data );
         
			return data;
		}		
		#endregion
		
		public tsy_ImpuestosEx()
		{
		}


		public static tsy_ImpuestosExDataset.tsy_ImpuestosExRow GetByPk( string IdImpuesto )
		{
			tsy_ImpuestosExDataset data = new tsy_ImpuestosExDataset();
			SqlDataAdapter adapter = new SqlDataAdapter();

			adapter.TableMappings.Add( "Table", "tsy_ImpuestosEx" );
			SqlCommand cmd = new SqlCommand( "Pr_tsy_Impuestos_GetByPk", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			if (data.tsy_ImpuestosEx.Rows.Count > 0)
			{
				return (tsy_ImpuestosExDataset.tsy_ImpuestosExRow)data.tsy_ImpuestosEx.Rows[0];
			}
			return null;
		}

		public static DataSet GetList( DataSet data, string IdProducto, string IdCuenta, string IdTipoDeComprobante )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosEx" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_Impuestos_GetListBy", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}	
		
		public static tsy_ImpuestosExDataset GetList( string IdProducto, string IdCuenta, string IdTipoDeComprobante )
		{
			tsy_ImpuestosExDataset data = new tsy_ImpuestosExDataset();
			return GetList( data, IdProducto, IdCuenta, IdTipoDeComprobante ); 
		}


		public static tsy_ImpuestosExDataset GetList( tsy_ImpuestosExDataset  data, string IdProducto, string IdCuenta, string IdTipoDeComprobante )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosEx" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_Impuestos_GetListBy", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		
		public void Dispose()
		{
		}

		
	}
}

