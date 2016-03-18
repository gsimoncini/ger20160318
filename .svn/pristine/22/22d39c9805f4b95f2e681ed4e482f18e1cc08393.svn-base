namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class Sucursales : IDisposable, IGridDocument
	{
		public Sucursales()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdSucursal""><Caption>IdSucursal</Caption><DataMember>IdSucursal</DataMember><Key>IdSucursal</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdResponsable""><Caption>IdResponsable</Caption><DataMember>IdResponsable</DataMember><Key>IdResponsable</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Direccion""><Caption>Direccion</Caption><DataMember>Direccion</DataMember><Key>Direccion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdLocalidad""><Caption>IdLocalidad</Caption><DataMember>IdLocalidad</DataMember><Key>IdLocalidad</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""CargoFijoProductos""><Caption>CargoFijoProductos</Caption><DataMember>CargoFijoProductos</DataMember><Key>CargoFijoProductos</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""BonificacionRecargoProductos""><Caption>BonificacionRecargoProductos</Caption><DataMember>BonificacionRecargoProductos</DataMember><Key>BonificacionRecargoProductos</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>7</Position></Column7>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.Sucursales.GetList().Sucursales;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.Sucursales.Update( ( SucursalesDataset.SucursalesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

