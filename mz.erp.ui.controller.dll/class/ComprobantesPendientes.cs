using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;



namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de Reporte_ComprobantesDeVenta.
	/// </summary>
	public class ComprobantesPendientes
	{
		public ComprobantesPendientes()
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
					TiposDeComprobantes = null;
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+TiposDeComprobantes);

			if ((IdCuenta != "") && (IdCuenta !=null)) IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(IdCuenta);
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientes( TiposDeComprobantes,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa);
			
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
			
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100 ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",80 ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emision",150 ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			if ( fl.Contains( "Pendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes",true ) );
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}
