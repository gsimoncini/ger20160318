namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_HerramientasRecursosIdiomas : IDisposable, IGridDocument
	{
		public sy_HerramientasRecursosIdiomas()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdHerramienta""><Caption>IdHerramienta</Caption><DataMember>IdHerramienta</DataMember><Key>IdHerramienta</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdRecurso""><Caption>IdRecurso</Caption><DataMember>IdRecurso</DataMember><Key>IdRecurso</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdIdioma""><Caption>IdIdioma</Caption><DataMember>IdIdioma</DataMember><Key>IdIdioma</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>7</Position></Column7>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_HerramientasRecursosIdiomas.GetList().sy_HerramientasRecursosIdiomas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_HerramientasRecursosIdiomas.Update( ( sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

