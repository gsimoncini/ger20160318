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
	/// Descripción breve de sy_HerramientasEx.
	/// </summary>
	public class sy_HerramientasEx: IDisposable
	{
		public sy_HerramientasEx()
		{
		}
		public sy_HerramientasEx( string[] fieldList )
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

			if ( fl.Contains( "Modo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Modo", "Acción", 50) );
			if ( fl.Contains( "IdBarraHerramienta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBarraHerramienta", "Barra", 50) );
			if ( fl.Contains( "IdHerramienta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHerramienta", "IdHerramienta", true) );
			if ( fl.Contains( "IdHerramientaPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHerramientaPadre", "IdHerramientaPadre") );
    		if ( fl.Contains( "Id" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true) );
			if ( fl.Contains( "ShortCut" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ShortCut", "ShortCut",100 ) );
			if ( fl.Contains( "Imagen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Imagen", "Imagen", 100) );
			if ( fl.Contains( "Habilitado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Habilitado", "Habilitado", 50, Types.ColumnTypes.CheckBox) );
			if ( fl.Contains( "Orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Orden", "Orden",50 ) );
			if ( fl.Contains( "IdRecurso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdRecurso", "IdRecurso", true) );
            /* Silvina 20110805 - Tarea 0000184 */
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",170 ) );
            /* Fin Silvina 20110805 - Tarea 0000184 */
			if ( fl.Contains( "IdTipoRecurso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoRecurso", "IdTipoRecurso", true) );
			if ( fl.Contains( "Perfiles" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Perfiles", "Perfiles", 1000) );

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
