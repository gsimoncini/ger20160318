using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeAjustesDeStock.
	/// </summary>
	public class rep_ListadoDeAjustesDeStock
	{
		public rep_ListadoDeAjustesDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Persona, string Producto, string TipoDeAjuste, long IdEmpresa, long IdSucursal )
		{	
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_AjustesDeStock", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0, 0, 0, 0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}
				
				cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ));
				if (Producto != null && Producto.Equals(String.Empty)) cmd.Parameters["@Codigo"].Value = System.DBNull.Value;
				else
				{
					cmd.Parameters[ "@Codigo"].Value = Producto; 
				}

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeAjuste", SqlDbType.VarChar));
				if (TipoDeAjuste != null && TipoDeAjuste.Equals(String.Empty)) 	cmd.Parameters[ "@IdTipoDeAjuste"].Value = System.DBNull.Value; 
				else 
				{
					cmd.Parameters[ "@IdTipoDeAjuste"].Value = TipoDeAjuste; 
				}

				cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ));
				if (Persona != null && Persona.Equals(String.Empty)) cmd.Parameters[ "@IdUsuario"].Value = System.DBNull.Value; 
				else 
				{
					cmd.Parameters[ "@IdUsuario"].Value = Persona; 
				}
				
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "RP_tsh_ReporteActualizacionPrecios" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch( SqlException e )
			{
				System.Diagnostics.Debug.WriteLine( e.ToString() );
			}
			catch( Exception e )
			{
				System.Diagnostics.Debug.WriteLine( e.ToString() );
				return null;
			}
			return null;
		}

	}
}
