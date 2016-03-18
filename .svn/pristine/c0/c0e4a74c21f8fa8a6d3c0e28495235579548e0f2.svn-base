namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class ProductosSucursales : IDisposable, IGridDocument
	{
		public ProductosSucursales()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdSucursal""><Caption>IdSucursal</Caption><DataMember>IdSucursal</DataMember><Key>IdSucursal</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Activo""><Caption>Activo</Caption><DataMember>Activo</DataMember><Key>Activo</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Rentabilidad""><Caption>Rentabilidad</Caption><DataMember>Rentabilidad</DataMember><Key>Rentabilidad</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""StockMinimo""><Caption>StockMinimo</Caption><DataMember>StockMinimo</DataMember><Key>StockMinimo</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""StockMaximo""><Caption>StockMaximo</Caption><DataMember>StockMaximo</DataMember><Key>StockMaximo</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""StockVisible""><Caption>StockVisible</Caption><DataMember>StockVisible</DataMember><Key>StockVisible</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""Costo""><Caption>Costo</Caption><DataMember>Costo</DataMember><Key>Costo</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""PrecioVenta""><Caption>PrecioVenta</Caption><DataMember>PrecioVenta</DataMember><Key>PrecioVenta</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>9</Position></Column9>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.ProductosSucursales.GetList().ProductosSucursales;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.ProductosSucursales.Update( ( ProductosSucursalesDataset.ProductosSucursalesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

