using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarComprobantesWF.
	/// </summary>
	public class ListarComprobantesWF
	{
		public ListarComprobantesWF()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string TiposDeComprobantes)
		{
			if (TiposDeComprobantes !="")
				if (TiposDeComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes");
				else
				TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+TiposDeComprobantes);
			return mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetList( IdCuenta, FechaDesde, FechaHasta, IdResponsable, TiposDeComprobantes, false, null, null, null, null, null, null, null, null);
		}


		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string TiposDeComprobantes, bool VerHTML)
		{
			if (TiposDeComprobantes !="")
				if (TiposDeComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes");
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+TiposDeComprobantes);
			return mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetList( IdCuenta, FechaDesde, FechaHasta, IdResponsable, TiposDeComprobantes, VerHTML, null, null, null, null, null, null, null, null);
		}


	
		public static System.Data.DataSet GetListDV( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string TiposDeComprobantes, bool VerHTML)
		{
			if (TiposDeComprobantes !="")
				if (TiposDeComprobantes == Constantes.TodosLosComprobantes)
					TiposDeComprobantes = Variables.GetValueString("ComprobantesAlt.TiposDeComprobantes");
				else
					TiposDeComprobantes = Variables.GetValueString("Comprobantes.TiposDeComprobantes."+TiposDeComprobantes);
			return mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetList( IdCuenta, FechaDesde, FechaHasta, IdResponsable, TiposDeComprobantes, VerHTML, null, null, null, null, null, null, null, null);
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
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",80 ) );
			//if ( fl.Contains( "ResponsableOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ResponsableOrigen", "Resp. Comp. Anterior",150 ) );
	
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			if ( fl.Contains( "CondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CondicionDeVenta", "Condic. de venta", false) );
            //Cristian Tarea 862
            if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",150 ) ); /* Responsable de Emision */
            //Fin Tarea 862
            //if ( fl.Contains( "Pendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes",true ) );
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}
