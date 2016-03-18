namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_GruposVariables : IDisposable, IGridDocument
	{
		public sy_GruposVariables()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdGrupo""><Caption>IdGrupo</Caption><DataMember>IdGrupo</DataMember><Key>IdGrupo</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdVariable""><Caption>IdVariable</Caption><DataMember>IdVariable</DataMember><Key>IdVariable</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>6</Position></Column6>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_GruposVariables.GetList().sy_GruposVariables;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_GruposVariables.Update( ( sy_GruposVariablesDataset.sy_GruposVariablesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

