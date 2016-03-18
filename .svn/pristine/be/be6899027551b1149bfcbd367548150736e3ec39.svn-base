namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_DescuentosPorCuentasExt : IDisposable, IGridDocument
	{
		public tsa_DescuentosPorCuentasExt()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdDescuentosPorCuentas""><Caption>IdDescuentosPorCuentas</Caption><DataMember>IdDescuentosPorCuentas</DataMember><Key>IdDescuentosPorCuentas</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""BonificacionRecargo""><Caption>BonificacionRecargo</Caption><DataMember>BonificacionRecargo</DataMember><Key>BonificacionRecargo</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""CargoFijo""><Caption>CargoFijo</Caption><DataMember>CargoFijo</DataMember><Key>CargoFijo</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""UnidadesMinimo""><Caption>UnidadesMinimo</Caption><DataMember>UnidadesMinimo</DataMember><Key>UnidadesMinimo</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>12</Position></Column12>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_DescuentosPorCuentasExt.GetList().tsa_DescuentosPorCuentasExt;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_DescuentosPorCuentasExt.Update( ( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

