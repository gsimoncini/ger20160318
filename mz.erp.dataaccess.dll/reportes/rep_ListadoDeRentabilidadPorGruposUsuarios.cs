using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeRentabilidadPorGruposUsuarios.
	/// </summary>
	public class rep_ListadoDeRentabilidadPorGruposUsuarios
	{
		public rep_ListadoDeRentabilidadPorGruposUsuarios()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataTable GetListGeneral(DateTime FechaDesde, DateTime FechaHasta, long Grupo )
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_ConsultarVentas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);										
			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
			if (FechaDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0, 0, 0, 0);
				cmd.Parameters[ "@FechaDesde"].Value = d;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
			if (FechaHasta.Equals(DateTime.MinValue)) 
				cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
			else
			{
				DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
				cmd.Parameters[ "@FechaHasta"].Value = h;
			}

			cmd.Parameters.Add( new SqlParameter( "@Grupo", SqlDbType.BigInt ));
			if (Grupo.Equals(long.MinValue)) 
				cmd.Parameters[ "@Grupo"].Value = System.DBNull.Value;
			else
			{
				
				cmd.Parameters[ "@Grupo"].Value = Grupo;
			}

				
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tsa_RentabilidadPorGruposUsuarios" );				
			adapter.SelectCommand = cmd;
				
			adapter.Fill( data);
				
			return data.Tables[0];
			

			
		}

        /* Silvina 20100611 - Tarea 669 */
        public static DataTable GetListDueño(DateTime FechaDesde, DateTime FechaHasta, long Grupo, string Jerarquia1, string Jerarquia2, string Jerarquia3, string Jerarquia4, string Jerarquia5, string Jerarquia6, string Jerarquia7, string Jerarquia8, string JerarquiaCliente1, string JerarquiaCliente2, string JerarquiaCliente3, string JerarquiaCliente4, string JerarquiaCliente5, string JerarquiaCliente6, string JerarquiaCliente7, string JerarquiaCliente8)
        {
            System.Data.DataSet data = new System.Data.DataSet();

            SqlCommand cmd = new SqlCommand("Pr_tsa_ConsultarVentasDueño", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
            cmd.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime));
            if (FechaDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
            else
            {
                DateTime d = new DateTime(FechaDesde.Year, FechaDesde.Month, FechaDesde.Day, 0, 0, 0, 0);
                cmd.Parameters["@FechaDesde"].Value = d;
            }

            cmd.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime));
            if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
            else
            {
                DateTime h = new DateTime(FechaHasta.Year, FechaHasta.Month, FechaHasta.Day, 23, 59, 0, 0);
                cmd.Parameters["@FechaHasta"].Value = h;
            }

            cmd.Parameters.Add(new SqlParameter("@Grupo", SqlDbType.BigInt));
            if (Grupo.Equals(long.MinValue)) cmd.Parameters["@Grupo"].Value = System.DBNull.Value;
            else
            {

                cmd.Parameters["@Grupo"].Value = Grupo;
            }

            cmd.Parameters.Add(new SqlParameter("@Jerarquia1", SqlDbType.VarChar));
            if (Jerarquia1 == "") cmd.Parameters["@Jerarquia1"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia1"].Value = Jerarquia1;

            cmd.Parameters.Add(new SqlParameter("@Jerarquia2", SqlDbType.VarChar));
            if (Jerarquia2 == "") cmd.Parameters["@Jerarquia2"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia2"].Value = Jerarquia2;


            cmd.Parameters.Add(new SqlParameter("@Jerarquia3", SqlDbType.VarChar));
            if (Jerarquia3 == "") cmd.Parameters["@Jerarquia3"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia3"].Value = Jerarquia3;

            cmd.Parameters.Add(new SqlParameter("@Jerarquia4", SqlDbType.VarChar));
            if (Jerarquia4 == "") cmd.Parameters["@Jerarquia4"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia4"].Value = Jerarquia4;

            cmd.Parameters.Add(new SqlParameter("@Jerarquia5", SqlDbType.VarChar));
            if (Jerarquia5 == "") cmd.Parameters["@Jerarquia5"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia5"].Value = Jerarquia5;


            cmd.Parameters.Add(new SqlParameter("@Jerarquia6", SqlDbType.VarChar));
            if (Jerarquia6 == "") cmd.Parameters["@Jerarquia6"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia6"].Value = Jerarquia6;


            cmd.Parameters.Add(new SqlParameter("@Jerarquia7", SqlDbType.VarChar));
            if (Jerarquia7 == "") cmd.Parameters["@Jerarquia7"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia7"].Value = Jerarquia7;


            cmd.Parameters.Add(new SqlParameter("@Jerarquia8", SqlDbType.VarChar));
            if (Jerarquia8 == "") cmd.Parameters["@Jerarquia8"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@Jerarquia8"].Value = Jerarquia8;

            /* Silvina 20100630 - Tarea 669 */

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente1", SqlDbType.VarChar));
            if (JerarquiaCliente1 == "") cmd.Parameters["@JerarquiaCliente1"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente1"].Value = JerarquiaCliente1;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente2", SqlDbType.VarChar));
            if (JerarquiaCliente1 == "") cmd.Parameters["@JerarquiaCliente2"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente2"].Value = JerarquiaCliente2;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente3", SqlDbType.VarChar));
            if (JerarquiaCliente3 == "") cmd.Parameters["@JerarquiaCliente3"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente3"].Value = JerarquiaCliente3;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente4", SqlDbType.VarChar));
            if (JerarquiaCliente4 == "") cmd.Parameters["@JerarquiaCliente4"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente4"].Value = JerarquiaCliente4;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente5", SqlDbType.VarChar));
            if (JerarquiaCliente5 == "") cmd.Parameters["@JerarquiaCliente5"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente5"].Value = JerarquiaCliente5;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente6", SqlDbType.VarChar));
            if (JerarquiaCliente6 == "") cmd.Parameters["@JerarquiaCliente6"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente6"].Value = JerarquiaCliente6;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente7", SqlDbType.VarChar));
            if (JerarquiaCliente7 == "") cmd.Parameters["@JerarquiaCliente7"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente7"].Value = JerarquiaCliente7;

            cmd.Parameters.Add(new SqlParameter("@JerarquiaCliente8", SqlDbType.VarChar));
            if (JerarquiaCliente8 == "") cmd.Parameters["@JerarquiaCliente8"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@JerarquiaCliente8"].Value = JerarquiaCliente8;

            /* Fin Silvina */

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Pr_tsa_ConsultarVentasDueño");
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data.Tables[0];
        }

		public static System.Data.DataTable GetList(DateTime FechaDesde, DateTime FechaHasta, long Grupo )
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
				SqlCommand cmd = new SqlCommand( "Pr_tsa_RentabilidadPorGruposUsuarios", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);										
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

			cmd.Parameters.Add( new SqlParameter( "@Grupo", SqlDbType.BigInt ));
			if (Grupo.Equals(long.MinValue)) cmd.Parameters[ "@Grupo"].Value = System.DBNull.Value;
			else
			{
				
				cmd.Parameters[ "@Grupo"].Value = Grupo;
			}

				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_RentabilidadPorGruposUsuarios" );				
				adapter.SelectCommand = cmd;
				
				adapter.Fill( data);
				
				return data.Tables[0];
			

			
		}


		public static System.Data.DataTable GetListAnterior(DateTime FechaDesde, DateTime FechaHasta, long Grupo )
		{
			System.Data.DataSet data = new System.Data.DataSet();
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_RentabilidadPorGruposUsuariosAnterior", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);										
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

			cmd.Parameters.Add( new SqlParameter( "@Grupo", SqlDbType.BigInt ));
			if (Grupo.Equals(long.MinValue)) cmd.Parameters[ "@Grupo"].Value = System.DBNull.Value;
			else
			{
				
				cmd.Parameters[ "@Grupo"].Value = Grupo;
			}

				
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tsa_RentabilidadPorGruposUsuarios" );				
			adapter.SelectCommand = cmd;
				
			adapter.Fill( data);
				
			return data.Tables[0];
			

			
		}
	}
}
