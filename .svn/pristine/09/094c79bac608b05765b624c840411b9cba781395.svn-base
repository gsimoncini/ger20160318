using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ReparacionesPendientes.
	/// </summary>
	public class ReparacionesPendientes
	{
		public ReparacionesPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private static string[] _fieldList=null;
	
		public static string GetLayout(ArrayList fl)
		{
		
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			
			if ( fl.Contains( "IdOrdenReparacion" ) ) sb.Append( LayoutBuilder.GetRow( i++, "IdOrdenReparacion", "Orden Nro",65 ) );
			if ( fl.Contains( "CodigoEstadoOrdenReparacion" ) ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoEstadoOrdenReparacion", "Estado",50 ) );			
			if ( fl.Contains( "IdCuenta" )  ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta",true ) );
			if ( fl.Contains( "Cuenta" ) ) sb.Append( LayoutBuilder.GetRow( i++, "Cuenta", "Cuenta",125) );
			if ( fl.Contains( "Total" )) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",50,Types.Aligment.Far, Types.FormatDisplay.Money  ) );
			if ( fl.Contains( "FechaComprometida" ) ) sb.Append( LayoutBuilder.GetRow( i++, "FechaComprometida", "Fecha Comprometida",125 ) );
			if ( fl.Contains( "IdUsuarioAlta" ) ) sb.Append( LayoutBuilder.GetRow( i++, "IdUsuarioAlta", "Responsable Alta",100 ) );
			if ( fl.Contains( "DescripcionEquipo" ) ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEquipo", "Equipo",200 ) );
			if ( fl.Contains( "FechaCreacion" ) ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha",125 ) );
			if ( fl.Contains( "Telefono" )  ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono",100 ) );
			if ( fl.Contains( "Domicilio" ) ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",100 ) );
			if ( fl.Contains( "IdTipoDocumento" ) ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDocumento", "Tipo Doc.",100 ) );
			if ( fl.Contains( "Documento" ) ) sb.Append( LayoutBuilder.GetRow( i++, "Documento", "Documento",100 ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}
