using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.businessrules.reportes;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeValorizacionDeStock.
	/// </summary>
	public class rep_ListadoDeValorizacionDeStock
	{
		public rep_ListadoDeValorizacionDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta , string Producto, string Deposito, string Seccion, string EstadoDeStock)
		{			
			return mz.erp.businessrules.reportes.rep_ListadoDeValorizacionDeStock.GetList(FechaDesde, FechaHasta, Producto, Deposito, Seccion, EstadoDeStock, Security.IdEmpresa, Security.IdSucursal);
		}

		
		private static string[] _fieldList=null;
		
		[ atMethodLayoutData ]
		public static string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			//estos son los campos q se van a  mostrar en la grilla
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",false) );
			if ( fl.Contains( "Seccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Seccion", "Sección",false) );
			if ( fl.Contains( "Deposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Deposito", "Depósito",false) );
			if ( fl.Contains( "EstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "EstadoDeStock", "Estado de Stock",false) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",false) );
			if ( fl.Contains( "Costo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Costo", "Costo",false) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();	
		}

	}
}
