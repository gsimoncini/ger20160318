namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_Conexion : IDisposable, IGridDocument
	{
		public sy_Conexion()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdConexion""><Caption>IdConexion</Caption><DataMember>IdConexion</DataMember><Key>IdConexion</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdUsuario""><Caption>IdUsuario</Caption><DataMember>IdUsuario</DataMember><Key>IdUsuario</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdPerfil""><Caption>IdPerfil</Caption><DataMember>IdPerfil</DataMember><Key>IdPerfil</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdPuesto""><Caption>IdPuesto</Caption><DataMember>IdPuesto</DataMember><Key>IdPuesto</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""FechaInicio""><Caption>FechaInicio</Caption><DataMember>FechaInicio</DataMember><Key>FechaInicio</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""FechaFinal""><Caption>FechaFinal</Caption><DataMember>FechaFinal</DataMember><Key>FechaFinal</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IntentosFallidosConexion""><Caption>IntentosFallidosConexion</Caption><DataMember>IntentosFallidosConexion</DataMember><Key>IntentosFallidosConexion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>12</Position></Column12>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Conexion.GetList().sy_Conexion;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Conexion.Update( ( sy_ConexionDataset.sy_ConexionDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

