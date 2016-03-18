namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
		using mz.erp.ui.controllers;


	/// <summary>
	/// Descripción breve de tfi_MovimientosDeCaja.
	/// </summary>
	public class tfi_MovimientosDeCajaEx :IDisposable, IGridDocument
	{
		public tfi_MovimientosDeCajaEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public DataTable GetList()
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void Update( object dataTable )
		{
			
		}

		public string GetLayout()
		{
			return string.Empty;
		}


		public string  GetLayoutComprobantesTesoreria()
		{


			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 200 ) );
			if ( fl.Contains( "Agrupado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Agrupado", "Agrupado" ,true) );
			
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
	}
}
