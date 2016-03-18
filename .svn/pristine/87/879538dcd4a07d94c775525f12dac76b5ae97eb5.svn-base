namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_Funcionalidades : IDisposable, IGridDocument
	{
		public sy_Funcionalidades()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdFuncionalidad""><Caption>IdFuncionalidad</Caption><DataMember>IdFuncionalidad</DataMember><Key>IdFuncionalidad</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Comentario""><Caption>Comentario</Caption><DataMember>Comentario</DataMember><Key>Comentario</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdConexion""><Caption>IdConexion</Caption><DataMember>IdConexion</DataMember><Key>IdConexion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""Activa""><Caption>Activa</Caption><DataMember>Activa</DataMember><Key>Activa</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>9</Position></Column9>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Funcionalidades.GetList().sy_Funcionalidades;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Funcionalidades.Update( ( sy_FuncionalidadesDataset.sy_FuncionalidadesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

