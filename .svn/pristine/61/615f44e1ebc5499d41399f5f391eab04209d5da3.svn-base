using System;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoStockValorizado.
	/// </summary>
	public class rep_ListadoStockValorizado
	{
		public rep_ListadoStockValorizado()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static DataTable GetList(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdEstadosDeStock,  string IdMonedaReferencia ,string IdMonedaVisualizacion, string IdFuenteDeCambioVisualizacion)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_ValorizacionDeStock", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;
				
				cmd.Parameters.Add( new SqlParameter( "@IdEstadosDeStock", SqlDbType.VarChar ) );
				if (IdEstadosDeStock =="") cmd.Parameters[ "@IdEstadosDeStock" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdEstadosDeStock" ].Value = IdEstadosDeStock;

				cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar ));
				if (IdMonedaReferencia == null || IdMonedaReferencia.Equals(String.Empty)) 
					cmd.Parameters[ "@IdMonedaReferencia"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@IdMonedaReferencia"].Value = IdMonedaReferencia;

				cmd.Parameters.Add( new SqlParameter( "@idMonedaVisualizacion", SqlDbType.VarChar ));
				if (IdMonedaVisualizacion == null || IdMonedaVisualizacion.Equals(String.Empty)) 
					cmd.Parameters[ "@idMonedaVisualizacion"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@idMonedaVisualizacion"].Value = IdMonedaVisualizacion;
				
				cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambioVisualizacion", SqlDbType.VarChar ));
				if (IdFuenteDeCambioVisualizacion == null || IdFuenteDeCambioVisualizacion.Equals(String.Empty)) 
					cmd.Parameters[ "@IdFuenteDeCambioVisualizacion"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@IdFuenteDeCambioVisualizacion"].Value = IdFuenteDeCambioVisualizacion;	
		
		
				


				
				
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data.Tables[0];
			}
			catch(Exception e){;return null;}

		}
	}
}
