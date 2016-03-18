using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using System.Windows.Forms;


namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de mz.erp.ui.forms.classes.Errores.
	/// </summary>
	public class Errores: IDisposable
	{
		public Errores()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static string GetLayoutErrores()
		{
			return GetLayoutErrores( null );
		}
		public static string GetLayoutErrores( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Tabla" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tabla", "Tabla", 150 ) );
			if ( fl.Contains( "Campo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Campo", "Campo", 150 ) );
			if ( fl.Contains( "Mensaje" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Mensaje", "Mensaje",300,5 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public void Dispose()
		{
		}

		public static void MessageFileNotFound() 
		{
			MessageBox.Show( "No se ha encontrado el archivo indicado!" );
		}

	}
		
	

	


}
