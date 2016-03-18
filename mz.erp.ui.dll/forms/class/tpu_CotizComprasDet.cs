namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_CotizComprasDet : IDisposable, IGridDocument
	{
		public tpu_CotizComprasDet()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdCotizCompra""><Caption>IdCotizCompra</Caption><DataMember>IdCotizCompra</DataMember><Key>IdCotizCompra</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Renglon""><Caption>Renglon</Caption><DataMember>Renglon</DataMember><Key>Renglon</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""Cantidad1""><Caption>Cantidad1</Caption><DataMember>Cantidad1</DataMember><Key>Cantidad1</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""PrecioFinal1""><Caption>PrecioFinal1</Caption><DataMember>PrecioFinal1</DataMember><Key>PrecioFinal1</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""Cantidad2""><Caption>Cantidad2</Caption><DataMember>Cantidad2</DataMember><Key>Cantidad2</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""PrecioFinal2""><Caption>PrecioFinal2</Caption><DataMember>PrecioFinal2</DataMember><Key>PrecioFinal2</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""Cantidad3""><Caption>Cantidad3</Caption><DataMember>Cantidad3</DataMember><Key>Cantidad3</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""PrecioFinal3""><Caption>PrecioFinal3</Caption><DataMember>PrecioFinal3</DataMember><Key>PrecioFinal3</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdMoneda""><Caption>IdMoneda</Caption><DataMember>IdMoneda</DataMember><Key>IdMoneda</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdFuenteDeCambio""><Caption>IdFuenteDeCambio</Caption><DataMember>IdFuenteDeCambio</DataMember><Key>IdFuenteDeCambio</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""Observaciones""><Caption>Observaciones</Caption><DataMember>Observaciones</DataMember><Key>Observaciones</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>15</Position></Column15>";
			returnValue += @"<Column16 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>16</Position></Column16>";
			returnValue += @"<Column17 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>17</Position></Column17>";
			returnValue += @"<Column18 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>18</Position></Column18>";
			returnValue += @"<Column19 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>19</Position></Column19>";
			returnValue += @"<Column20 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>20</Position></Column20>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_CotizComprasDet.GetList().tpu_CotizComprasDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_CotizComprasDet.Update( ( tpu_CotizComprasDetDataset.tpu_CotizComprasDetDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

