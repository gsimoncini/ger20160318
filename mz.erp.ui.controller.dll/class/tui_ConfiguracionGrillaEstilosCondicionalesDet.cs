using System;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de tui_ConfiguracionGrillaEstilosCondicionalesDet.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosCondicionalesDet: IDisposable
	{
		public tui_ConfiguracionGrillaEstilosCondicionalesDet()
		{
		}

		public tui_ConfiguracionGrillaEstilosCondicionalesDet( string[] fieldList )
		{
			_fieldList = fieldList;
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
		
			if ( fl.Contains( "Columna" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Columna", "Columna", 100) );
			if ( fl.Contains( "Condicion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Condicion", "Condición", 50) );
			if ( fl.Contains( "ValorString" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorString", "Valor",100 ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado",50) );

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
