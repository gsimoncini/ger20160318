using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de tsa_ReporteDetalleComprobanteDeVenta.
	/// </summary>
	public class tsa_ReporteDetalleComprobanteDeVenta
	{
		public tsa_ReporteDetalleComprobanteDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string TiposDeComprobantes)
		{
			
			if (TiposDeComprobantes !="")
				if (TiposDeComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes");
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+TiposDeComprobantes);
			
			
			if ((IdCuenta != "") && (IdCuenta !=null)) IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(IdCuenta);
			return mz.erp.businessrules.reportes.tsa_ReporteDetalleComprobantesDeVenta.GetList( IdCuenta, FechaDesde, FechaHasta, IdResponsable, TiposDeComprobantes);
			
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
			
		
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",125) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.",50 ) );
			if ( fl.Contains( "CodigoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoProducto", "Cod. Prod",50) );
			if ( fl.Contains( "Producto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",200 ) );
			
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}
