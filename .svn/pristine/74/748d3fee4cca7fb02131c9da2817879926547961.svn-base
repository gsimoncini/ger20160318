using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
    //Cristian Tarea 0000067 20110329
    public class  rep_ListadoCitiVentas
    {

        public rep_ListadoCitiVentas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


        public static DataTable GetList(DateTime FechaDesde, DateTime FechaHasta)
        {
             try{  
               DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();
                // adapter.TableMappings.Add("Table", "tsa_Comprobantes");

                SqlCommand cmd = new SqlCommand("Pr_tsa_Comprobantes_ExportarCitiVentas", dbhelper.Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@dDesde", SqlDbType.DateTime));
                if (FechaDesde.Equals(DateTime.MinValue))
                    cmd.Parameters["@dDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(FechaDesde.Year, FechaDesde.Month, FechaDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@dDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@dHasta", SqlDbType.DateTime));
                if (FechaHasta.Equals(DateTime.MinValue))
                    cmd.Parameters["@dHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(FechaHasta.Year, FechaHasta.Month, FechaHasta.Day, 23, 59, 0, 0);
                    cmd.Parameters["@dHasta"].Value = h;
                }

                cmd.CommandTimeout = 60;

                adapter.SelectCommand = cmd;
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

   }

    //Fin Cristian
}
