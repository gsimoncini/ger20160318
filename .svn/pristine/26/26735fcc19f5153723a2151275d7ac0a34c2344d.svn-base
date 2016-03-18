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

	public class tsh_ProductosSucursales : IDisposable, IGridDocument
	{
		public tsh_ProductosSucursales()
		{
		}

		public tsh_ProductosSucursales( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
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
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "Producto",200 ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",200 ) );
			if ( fl.Contains( "IncrementoDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IncrementoDeCosto", "IncrementoDeCosto",true ) );
			if ( fl.Contains( "MAC" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC",true ) );
			if ( fl.Contains( "PrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "PrecioDeVentaNeto",true ) );
			if ( fl.Contains( "MaxDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuento", "MaxDescuento",true ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "PrecioDeVentaBruto",true ) );
			if ( fl.Contains( "StockReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockReservado", "StockReservado",true ) );
			if ( fl.Contains( "StockConfirmado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockConfirmado", "StockConfirmado",true ) );
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "StockDisponible",true ) );
			if ( fl.Contains( "StockFisico" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockFisico", "StockFisico",true ) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",true ) );
			if ( fl.Contains( "StockMaximo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMaximo", "StockMaximo",true ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",100 ) );
			if ( fl.Contains( "Bloqueado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bloqueado", "Bloqueado",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_ProductosSucursales.GetList().tsh_ProductosSucursales;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_ProductosSucursales.Update( ( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesDataTable )dataTable );
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

		[ SearchMember( "tsh_ProductosSucursales" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "StockReservado" ) ] decimal StockReservado, 
			[ SearchParameterInfo( "StockConfirmado" ) ] decimal StockConfirmado, 
			[ SearchParameterInfo( "StockDisponible" ) ] decimal StockDisponible, 
			[ SearchParameterInfo( "StockFisico" ) ] decimal StockFisico, 
			[ SearchParameterInfo( "StockMinimo" ) ] decimal StockMinimo, 
			[ SearchParameterInfo( "StockMaximo" ) ] decimal StockMaximo, 
			[ SearchParameterInfo( "Activo" ) ] bool Activo, 
			[ SearchParameterInfo( "Bloqueado" ) ] bool Bloqueado
			)
		{
			tsh_ProductosSucursalesDataset data = null; //mz.erp.businessrules.tsh_ProductosSucursales.GetList( IdProducto, IdSucursal, StockReservado, StockConfirmado, StockDisponible, StockFisico, StockMinimo, StockMaximo, Activo, Bloqueado );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
	
		public string GetLayoutSucursales()
		{

			bool StockMinimoVisible = true;

			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			//if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "Producto",200 ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Sucursal",150,Types.EditType.NoEdit ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",150,Types.EditType.NoEdit ) );
			if ( fl.Contains( "IsAvailable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IsAvailable", "Disponible",100,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			if ( fl.Contains( "IncrementoDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IncrementoDeCosto", "IncrementoDeCosto",true ) );
			if ( fl.Contains( "MAC" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC",true ) );
			if ( fl.Contains( "PrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "PrecioDeVentaNeto",true ) );
			if ( fl.Contains( "MaxDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuento", "MaxDescuento",true ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "PrecioDeVentaBruto",true ) );
			if ( fl.Contains( "StockReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockReservado", "StockReservado",true ) );
			if ( fl.Contains( "StockConfirmado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockConfirmado", "StockConfirmado",true ) );
			//if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "StockDisponible",true ) );			
			//if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "StockDisponible",75,Types.Aligment.Far,Types.FormatDisplay.Integer,Types.EditType.NoEdit ) );
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "StockDisponible",90,Types.EditType.NoEdit ) );
			if ( fl.Contains( "StockFisico" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockFisico", "StockFisico",true ) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",75,Types.Aligment.Far,Types.FormatDisplay.Integer,Types.EditType.Custom ) );
			if ( fl.Contains( "StockMaximo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMaximo", "StockMaximo",75,Types.Aligment.Far,Types.FormatDisplay.Integer,Types.EditType.Custom ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true ) );
			if ( fl.Contains( "Bloqueado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bloqueado", "Bloqueado",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}		
	}
}

