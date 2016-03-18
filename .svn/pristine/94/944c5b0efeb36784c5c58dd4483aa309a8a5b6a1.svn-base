using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de tsa_CuentasObservacionesTipos.
	/// </summary>
	public class tsa_CuentasObservacionesTipos: IDisposable
	{
		public tsa_CuentasObservacionesTipos()
		{
		}

		public tsa_CuentasObservacionesTipos( string[] fieldList )
		{
			_fieldList = fieldList;

		}

		[ atOrderBy ]
		public static string DefaultOrderBy
		{
			get
			{
				return "Nombre asc";
			}
		}

		[ atMethodLayoutData ]
		public string GetLayoutEx()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
		
			if ( fl.Contains( "KeyTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeyTipo", "KeyTipo", true) );
			if ( fl.Contains( "DescripcionTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionTipo", "Tipo de observación",170 ) );
			if ( fl.Contains( "KeyTipoPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeyTipoPadre", "KeyTipoPadre", true) );
			if ( fl.Contains( "DescripcionTipoPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionTipoPadre", "Tipo de observación padre", 170) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50, Types.ColumnTypes.CheckBox) );
			if ( fl.Contains( "Modo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Modo", "Acción", 50) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		public void Dispose()
		{
		}
	}
}
