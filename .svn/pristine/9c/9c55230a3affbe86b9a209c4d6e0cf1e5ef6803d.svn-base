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
	/// Descripción breve de tsy_MotivoOrdenReparacion.
	/// </summary>
	public class tsy_MotivoOrdenReparacion: IDisposable
	{
		public tsy_MotivoOrdenReparacion()
		{
		}

		public tsy_MotivoOrdenReparacion( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		[ atOrderBy ]
		public static string DefaultOrderBy
		{
			get
			{
				return "IdMotivo asc";
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



			if ( fl.Contains( "IdMotivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMotivo", "IdMotivo", true) );
			if ( fl.Contains( "IdMotivoPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMotivoPadre", "IdMotivoPadre", true) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Motivo", 300) );
			if ( fl.Contains( "DescripcionMotivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Motivo", 170) );
			if ( fl.Contains( "DescripcionMotivoPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMotivoPadre", "Motivo Padre", 170) );
			if ( fl.Contains( "EsVerdadero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "EsVerdadero", "Si",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			if ( fl.Contains( "EsFalso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "EsFalso", "No",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			if ( fl.Contains( "EsMotivoVerdadero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "EsMotivoVerdadero", "Por Si",50,Types.ColumnTypes.CheckBox) );
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
