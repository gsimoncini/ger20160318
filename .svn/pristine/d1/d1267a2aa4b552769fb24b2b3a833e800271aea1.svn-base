using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tfi_FormasDePagoEx.
	/// </summary>
	public class tfi_FormasDePagoEx
	{
		public tfi_FormasDePagoEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		
		public static System.Data.DataRowCollection GetFormasDePagosGenerales (tfi_FormasDePagoExDataset data1 )
		{

			
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetFormasDePagosGenerales" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_GetFormasDePagosGenerales", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return  data.Tables[0].Rows;
			
		}

		public static System.Data.DataRowCollection  GetComprobantesTesoreria(tfi_FormasDePagoExDataset data)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetComprobantesTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_GetComprobantesTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return  data.Pr_tfi_GetComprobantesTesoreria.Rows;

		}

		public static System.Data.DataRowCollection  GetComprobantesTesoreria(tfi_FormasDePagoExDataset data, string IdCondicionDeVenta)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetComprobantesTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_GetComprobantesTesoreria_ByIdCondicionDeVenta", dbhelper.Connection.GetConnection() );
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return  data.Pr_tfi_GetComprobantesTesoreria.Rows;

		}

		public static System.Data.DataRowCollection GetComprobantesTesoreria(tfi_FormasDePagoExDataset data, string IdCondicionDeVenta, string IdCuenta, string IdTipoDeComprobante)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetComprobantesTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_GetListBy", dbhelper.Connection.GetConnection() );
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if(IdTipoDeComprobante == null || IdTipoDeComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if(IdCuenta == null || IdCuenta.Equals(string.Empty))
				cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return  data.Pr_tfi_GetComprobantesTesoreria.Rows;
		}


		public static System.Data.DataRowCollection GetFormasDePagosEspecificas (tfi_FormasDePagoExDataset data)
		{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tfi_GetFormasDePagos" );
			
				SqlCommand cmd = new SqlCommand( "Pr_tfi_GetFormasDePagos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				adapter.SelectCommand = cmd;

				adapter.Fill( data );
         
				return data.Tables["Pr_tfi_GetFormasDePagos"].Rows;


		}


	}
}
