namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_Comprobante : IDisposable, IGridDocument
	{
		public tsa_Comprobante()
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
			returnValue += @"<Column4 ID=""IdCuenta""><Caption>IdCuenta</Caption><DataMember>IdCuenta</DataMember><Key>IdCuenta</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdCondicionDeVenta""><Caption>IdCondicionDeVenta</Caption><DataMember>IdCondicionDeVenta</DataMember><Key>IdCondicionDeVenta</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""BaseImponible""><Caption>BaseImponible</Caption><DataMember>BaseImponible</DataMember><Key>BaseImponible</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""Exento""><Caption>Exento</Caption><DataMember>Exento</DataMember><Key>Exento</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IvaInscripto""><Caption>IvaInscripto</Caption><DataMember>IvaInscripto</DataMember><Key>IvaInscripto</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""RetencionIB""><Caption>RetencionIB</Caption><DataMember>RetencionIB</DataMember><Key>RetencionIB</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""RetencionIva""><Caption>RetencionIva</Caption><DataMember>RetencionIva</DataMember><Key>RetencionIva</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""RetencionGanancia""><Caption>RetencionGanancia</Caption><DataMember>RetencionGanancia</DataMember><Key>RetencionGanancia</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""BonificacionRecargo""><Caption>BonificacionRecargo</Caption><DataMember>BonificacionRecargo</DataMember><Key>BonificacionRecargo</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""Total""><Caption>Total</Caption><DataMember>Total</DataMember><Key>Total</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""FechaVencimiento""><Caption>FechaVencimiento</Caption><DataMember>FechaVencimiento</DataMember><Key>FechaVencimiento</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""IdVendedor""><Caption>IdVendedor</Caption><DataMember>IdVendedor</DataMember><Key>IdVendedor</Key><Position>15</Position></Column15>";
			returnValue += @"<Column16 ID=""PeriodoFiscal""><Caption>PeriodoFiscal</Caption><DataMember>PeriodoFiscal</DataMember><Key>PeriodoFiscal</Key><Position>16</Position></Column16>";
			returnValue += @"<Column17 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>17</Position></Column17>";
			returnValue += @"<Column18 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>18</Position></Column18>";
			returnValue += @"<Column19 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>19</Position></Column19>";
			returnValue += @"<Column20 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>20</Position></Column20>";
			returnValue += @"<Column21 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>21</Position></Column21>";
			returnValue += @"<Column22 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>22</Position></Column22>";
			returnValue += @"<Column23 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>23</Position></Column23>";
			returnValue += @"<Column24 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>24</Position></Column24>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_Comprobante.GetList().tsa_Comprobante;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Comprobante.Update( ( tsa_ComprobanteDataset.tsa_ComprobanteDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

