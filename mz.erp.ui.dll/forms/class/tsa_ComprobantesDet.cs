namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_ComprobantesDet : IDisposable, IGridDocument
	{
		public tsa_ComprobantesDet()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdComprobante""><Caption>IdComprobante</Caption><DataMember>IdComprobante</DataMember><Key>IdComprobante</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Fecha""><Caption>Fecha</Caption><DataMember>Fecha</DataMember><Key>Fecha</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Tipo""><Caption>Tipo</Caption><DataMember>Tipo</DataMember><Key>Tipo</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Numero""><Caption>Numero</Caption><DataMember>Numero</DataMember><Key>Numero</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdRenglon""><Caption>IdRenglon</Caption><DataMember>IdRenglon</DataMember><Key>IdRenglon</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""PrecioCostoNeto""><Caption>PrecioCostoNeto</Caption><DataMember>PrecioCostoNeto</DataMember><Key>PrecioCostoNeto</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""PrecioCostoFinal""><Caption>PrecioCostoFinal</Caption><DataMember>PrecioCostoFinal</DataMember><Key>PrecioCostoFinal</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""Rentabilidad""><Caption>Rentabilidad</Caption><DataMember>Rentabilidad</DataMember><Key>Rentabilidad</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""PrecioVentaNeto""><Caption>PrecioVentaNeto</Caption><DataMember>PrecioVentaNeto</DataMember><Key>PrecioVentaNeto</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""PrecioVentaFinal""><Caption>PrecioVentaFinal</Caption><DataMember>PrecioVentaFinal</DataMember><Key>PrecioVentaFinal</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""BaseImponible""><Caption>BaseImponible</Caption><DataMember>BaseImponible</DataMember><Key>BaseImponible</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""Bonificacion""><Caption>Bonificacion</Caption><DataMember>Bonificacion</DataMember><Key>Bonificacion</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""AlicuotaIva""><Caption>AlicuotaIva</Caption><DataMember>AlicuotaIva</DataMember><Key>AlicuotaIva</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""Cantidad""><Caption>Cantidad</Caption><DataMember>Cantidad</DataMember><Key>Cantidad</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>15</Position></Column15>";
			returnValue += @"<Column16 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>16</Position></Column16>";
			returnValue += @"<Column17 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>17</Position></Column17>";
			returnValue += @"<Column18 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>18</Position></Column18>";
			returnValue += @"<Column19 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>19</Position></Column19>";
			returnValue += @"<Column20 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>20</Position></Column20>";
			returnValue += @"<Column21 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>21</Position></Column21>";
			returnValue += @"<Column22 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>22</Position></Column22>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_ComprobantesDet.GetList().tsa_ComprobantesDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_ComprobantesDet.Update( ( tsa_ComprobantesDetDataset.tsa_ComprobantesDetDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

