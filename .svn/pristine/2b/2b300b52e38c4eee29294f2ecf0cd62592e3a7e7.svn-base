namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsh_MovimientosStockDet : IDisposable, IGridDocument
	{
		public tsh_MovimientosStockDet()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdMovimientoStock""><Caption>IdMovimientoStock</Caption><DataMember>IdMovimientoStock</DataMember><Key>IdMovimientoStock</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Renglon""><Caption>Renglon</Caption><DataMember>Renglon</DataMember><Key>Renglon</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Cantidad""><Caption>Cantidad</Caption><DataMember>Cantidad</DataMember><Key>Cantidad</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdDeposito""><Caption>IdDeposito</Caption><DataMember>IdDeposito</DataMember><Key>IdDeposito</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdSeccion""><Caption>IdSeccion</Caption><DataMember>IdSeccion</DataMember><Key>IdSeccion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""NumeroSerie""><Caption>NumeroSerie</Caption><DataMember>NumeroSerie</DataMember><Key>NumeroSerie</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdLote""><Caption>IdLote</Caption><DataMember>IdLote</DataMember><Key>IdLote</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>15</Position></Column15>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_MovimientosStockDet.GetList().tsh_MovimientosStockDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_MovimientosStockDet.Update( ( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

