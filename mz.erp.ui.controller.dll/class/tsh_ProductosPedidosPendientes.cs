namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tsh_ProductosPedidosPendientes : IDisposable
	{
		public tsh_ProductosPedidosPendientes()
		{
		}

		public tsh_ProductosPedidosPendientes( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		

		[ atMethodLayoutData ]
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "FechaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCierre", "Fecha Cierre", true ) );
			if ( fl.Contains( "Cerrado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cerrado", "Cerrado", true ) );
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante", true ) );
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto", true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Proveedor", 120 ) );
			if ( fl.Contains( "FechaRecepcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaRecepcion", "Fecha Recepcion", 80, Types.Aligment.Far, Types.FormatDisplay.DateTimeShort ) );

			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad", 80 ) );
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal", true ) );
	
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo Comprobante", 100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero Comprobante", 120) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_ProductosPedidosPendientes.GetList().tsh_ProductosPedidosPendientes;

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

