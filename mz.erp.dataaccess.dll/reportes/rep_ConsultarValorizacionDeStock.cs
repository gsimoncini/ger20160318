using System;
using System.Data;
using System.Data.SqlClient;
namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ConsultarValorizacionDeStock.
	/// </summary>
	public class rep_ConsultarValorizacionDeStock
	{
		public rep_ConsultarValorizacionDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
        //Cristian Tarea 0000046 20110321
		public static DataTable GetList(string IdProducto,string estados, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, DateTime Fecha)
		{
			return mz.erp.dataaccess.tfi_ValorizacionStock.GetListEx(Fecha,estados, null, null, null, null).Tables[0];
		}
        //fin Cristian
		
	}
}
