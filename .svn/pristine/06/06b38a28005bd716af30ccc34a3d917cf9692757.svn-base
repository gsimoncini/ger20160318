namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_Lotes : IDisposable, IGridDocument
	{
		public tpu_Lotes()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdLote""><Caption>IdLote</Caption><DataMember>IdLote</DataMember><Key>IdLote</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Codigo""><Caption>Codigo</Caption><DataMember>Codigo</DataMember><Key>Codigo</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""FechaIngreso""><Caption>FechaIngreso</Caption><DataMember>FechaIngreso</DataMember><Key>FechaIngreso</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""FechaLiquidacion""><Caption>FechaLiquidacion</Caption><DataMember>FechaLiquidacion</DataMember><Key>FechaLiquidacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""FechaVencimiento""><Caption>FechaVencimiento</Caption><DataMember>FechaVencimiento</DataMember><Key>FechaVencimiento</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""Cantidad""><Caption>Cantidad</Caption><DataMember>Cantidad</DataMember><Key>Cantidad</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>14</Position></Column14>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_Lotes.GetList().tpu_Lotes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_Lotes.Update( ( tpu_LotesDataset.tpu_LotesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

