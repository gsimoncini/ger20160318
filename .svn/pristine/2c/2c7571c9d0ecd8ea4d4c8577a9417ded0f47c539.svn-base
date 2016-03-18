using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeMoviemientosDeStock.
	/// </summary>
	public class rep_ListadoDeMoviemientosDeStock
	{
		public rep_ListadoDeMoviemientosDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

         //Cristian 0000010 20110224
        public static System.Data.DataSet GetList(DateTime FechaDesde, DateTime FechaHasta, string Persona, string Producto, string TipoDeAjuste, string Deposito, string Seccion, long IdEmpresa, long IdSucursal)
		{
			return  mz.erp.dataaccess.reportes.rep_ListadoDeMovimientosDeStock.GetList( FechaDesde, FechaHasta, Persona, Producto, TipoDeAjuste, Deposito, Seccion, IdEmpresa, IdSucursal );
		}
        //Fin Cristian	

	}
}
