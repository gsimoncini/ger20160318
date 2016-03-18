using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoEstadoCajas.
	/// </summary>
	public class rep_ListadoEstadoCajas
	{
		public rep_ListadoEstadoCajas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( )
		{			
			return mz.erp.businessrules.tfi_Cajas.rep_ListadoEstadoCajas();
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
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado",false) );
			if ( fl.Contains( "Caja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Caja", "Caja", 300, mz.erp.ui.controllers.Types.Aligment.Near) );
			if ( fl.Contains( "Usuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Usuario", "Usuario / Ultimo usuario",300, mz.erp.ui.controllers.Types.Aligment.Near) );
			if ( fl.Contains( "Apertura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Apertura", "Apertura",false) );
			if ( fl.Contains( "Cierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cierre", "Cierre",false) );
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja",true) );
			if ( fl.Contains( "IdCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCaja", "IdCaja",true) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable",true) );

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();	
		}

	}
}
