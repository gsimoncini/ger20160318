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
	/// Descripción breve de tlg_VizualizacionDeStock.
	/// </summary>
	public class tlg_VisualizacionDeStock: IDisposable
	{
		public tlg_VisualizacionDeStock()
		{
		}

		public tlg_VisualizacionDeStock( string[] fieldList )
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
		
			if ( fl.Contains( "KeyVisualizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeyVisualizacion", "KeyVisualizacion", true) );
			if ( fl.Contains( "NombreVisualizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NombreVisualizacion", "Nombre Visualización",170 ) );
			if ( fl.Contains( "KeyEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeyEstado", "KeyEstado", true) );
			if ( fl.Contains( "DescripcionEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEstado", "Estado de Stock", 170) );
			if ( fl.Contains( "Operacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Operacion", "Op", 50) );
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
