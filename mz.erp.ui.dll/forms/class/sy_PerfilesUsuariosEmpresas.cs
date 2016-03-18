namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_PerfilesUsuariosEmpresas : IDisposable, IGridDocument
	{
		public sy_PerfilesUsuariosEmpresas()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdUsuario""><Caption>IdUsuario</Caption><DataMember>IdUsuario</DataMember><Key>IdUsuario</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdPerfil""><Caption>IdPerfil</Caption><DataMember>IdPerfil</DataMember><Key>IdPerfil</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""ConexionDefault""><Caption>ConexionDefault</Caption><DataMember>ConexionDefault</DataMember><Key>ConexionDefault</Key><Position>3</Position></Column3>";
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
			return mz.erp.businessrules.sy_PerfilesUsuariosEmpresas.GetList().sy_PerfilesUsuariosEmpresas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_PerfilesUsuariosEmpresas.Update( ( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

