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
	/// Descripción breve de sy_ConfigurarVariables.
	/// </summary>
	public class sy_ConfigurarVariables: IDisposable
	{
		public sy_ConfigurarVariables()
		{
		}

		public sy_ConfigurarVariables( string[] fieldList )
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
		
			if ( fl.Contains( "IdVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariable", "Variable", 200) );
			if ( fl.Contains( "DescripcionDatoNuevo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionDatoNuevo", "Dato", 200) );
			if ( fl.Contains( "IdHabilitado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHabilitado", "IdHabilitado",true ) );
			if ( fl.Contains( "IdHabilitadoL" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHabilitadoL", "IdHabilitadoL",true ) );
			if ( fl.Contains( "IdHabilitadoLAux" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHabilitadoLAux", "IdHabilitadoLAux",true ) );
			if ( fl.Contains( "DescripcionHabilitado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionHabilitado", "Habilitado", 150) );
			if ( fl.Contains( "TipoHabilitado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoHabilitado", "TipoHabilitado",true ) );

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
