namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsh_Documentos : IDisposable, IGridDocument
	{
		public tsh_Documentos()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdDocumento""><Caption>IdDocumento</Caption><DataMember>IdDocumento</DataMember><Key>IdDocumento</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdTipoDocumento""><Caption>IdTipoDocumento</Caption><DataMember>IdTipoDocumento</DataMember><Key>IdTipoDocumento</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdClaseDocumento""><Caption>IdClaseDocumento</Caption><DataMember>IdClaseDocumento</DataMember><Key>IdClaseDocumento</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""Tamanio""><Caption>Tamanio</Caption><DataMember>Tamanio</DataMember><Key>Tamanio</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""Documento""><Caption>Documento</Caption><DataMember>Documento</DataMember><Key>Documento</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>13</Position></Column13>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Documentos.GetList().tsh_Documentos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_Documentos.Update( ( tsh_DocumentosDataset.tsh_DocumentosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

