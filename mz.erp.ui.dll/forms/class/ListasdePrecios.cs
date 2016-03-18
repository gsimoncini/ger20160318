namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class ListasdePrecios : IDisposable, IGridDocument
	{
		public ListasdePrecios()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdListadePrecio""><Caption>IdListadePrecio</Caption><DataMember>IdListadePrecio</DataMember><Key>IdListadePrecio</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Codigo""><Caption>Codigo</Caption><DataMember>Codigo</DataMember><Key>Codigo</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""VigenciaDesde""><Caption>VigenciaDesde</Caption><DataMember>VigenciaDesde</DataMember><Key>VigenciaDesde</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""VigenciaHasta""><Caption>VigenciaHasta</Caption><DataMember>VigenciaHasta</DataMember><Key>VigenciaHasta</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>6</Position></Column6>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.ListasdePrecios.GetList().ListasdePrecios;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.ListasdePrecios.Update( ( ListasdePreciosDataset.ListasdePreciosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

