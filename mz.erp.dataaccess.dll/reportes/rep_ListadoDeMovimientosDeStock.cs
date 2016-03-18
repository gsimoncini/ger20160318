using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeMovimientosDeStock.
	/// </summary>
	public class rep_ListadoDeMovimientosDeStock
	{
		public rep_ListadoDeMovimientosDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
        //Cristian Tarea 0000010 20110224
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Persona, string Producto, string TipoDeAjuste, string Deposito, string Seccion, long IdEmpresa, long IdSucursal )
		{//ST 		
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_MovimientosDeStock", dbhelper.Connection.GetConnection() );
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
				
				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				if (Producto != null && Producto.Equals(String.Empty)) 	cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value; 
				else 
				{
					cmd.Parameters[ "@IdProducto"].Value = Producto; 
				}				
				//Cristian Tarea 0000010 20110224
                cmd.Parameters.Add(new SqlParameter("@IdDeposito", SqlDbType.VarChar));
                if (Deposito != null && Deposito.Equals(String.Empty)) cmd.Parameters["@IdDeposito"].Value = System.DBNull.Value;
                else
                {
                    cmd.Parameters["@IdDeposito"].Value = Deposito;
                }

                cmd.Parameters.Add(new SqlParameter("@IdSeccion", SqlDbType.VarChar));
                if (Seccion != null && Seccion.Equals(String.Empty)) cmd.Parameters["@IdSeccion"].Value = System.DBNull.Value;
                else
                {
                    cmd.Parameters["@IdSeccion"].Value = Seccion;
                }
                //Fin Cristian
				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeAjuste", SqlDbType.VarChar));
				if (TipoDeAjuste != null && TipoDeAjuste.Equals(String.Empty)) 	cmd.Parameters[ "@IdTipoDeAjuste"].Value = System.DBNull.Value; 
				else 
				{
					cmd.Parameters[ "@IdTipoDeAjuste"].Value = TipoDeAjuste; 
				}
				
				cmd.Parameters.Add( new SqlParameter( "@Responsable", SqlDbType.VarChar ));
				if (Persona != null && Persona.Equals(String.Empty)) 	cmd.Parameters[ "@Responsable"].Value = System.DBNull.Value; 
				else 
				{
					cmd.Parameters[ "@Responsable"].Value = Persona; 
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
			catch(Exception e)
			{
				return null;}
			return null;
		}
        //Fin Cristian
	}
}
