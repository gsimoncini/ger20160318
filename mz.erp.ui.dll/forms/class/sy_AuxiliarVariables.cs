namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_AuxiliarVariables : IDisposable, IGridDocument
	{
		public sy_AuxiliarVariables()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdVariable""><Caption>IdVariable</Caption><DataMember>IdVariable</DataMember><Key>IdVariable</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Comentario""><Caption>Comentario</Caption><DataMember>Comentario</DataMember><Key>Comentario</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Valor""><Caption>Valor</Caption><DataMember>Valor</DataMember><Key>Valor</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>8</Position></Column8>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_AuxiliarVariables.GetList().sy_AuxiliarVariables;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_AuxiliarVariables.Update( ( sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

