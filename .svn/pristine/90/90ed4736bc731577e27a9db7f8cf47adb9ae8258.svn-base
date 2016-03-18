namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_OrdenesCompraDet : IDisposable, IGridDocument
	{
		public tpu_OrdenesCompraDet()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdOrdenCompra""><Caption>IdOrdenCompra</Caption><DataMember>IdOrdenCompra</DataMember><Key>IdOrdenCompra</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Renglon""><Caption>Renglon</Caption><DataMember>Renglon</DataMember><Key>Renglon</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdProducto""><Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Cantidad""><Caption>Cantidad</Caption><DataMember>Cantidad</DataMember><Key>Cantidad</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""Entregado""><Caption>Entregado</Caption><DataMember>Entregado</DataMember><Key>Entregado</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""PCostoNeto""><Caption>PCostoNeto</Caption><DataMember>PCostoNeto</DataMember><Key>PCostoNeto</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""PCostoNetoFinal""><Caption>PCostoNetoFinal</Caption><DataMember>PCostoNetoFinal</DataMember><Key>PCostoNetoFinal</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""Alicuota""><Caption>Alicuota</Caption><DataMember>Alicuota</DataMember><Key>Alicuota</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdMoneda""><Caption>IdMoneda</Caption><DataMember>IdMoneda</DataMember><Key>IdMoneda</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdFuenteDeCambio""><Caption>IdFuenteDeCambio</Caption><DataMember>IdFuenteDeCambio</DataMember><Key>IdFuenteDeCambio</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""VarMaximaPrecio""><Caption>VarMaximaPrecio</Caption><DataMember>VarMaximaPrecio</DataMember><Key>VarMaximaPrecio</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""VarMinimaPedido""><Caption>VarMinimaPedido</Caption><DataMember>VarMinimaPedido</DataMember><Key>VarMinimaPedido</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""VarMaximaPedido""><Caption>VarMaximaPedido</Caption><DataMember>VarMaximaPedido</DataMember><Key>VarMaximaPedido</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""Observaciones""><Caption>Observaciones</Caption><DataMember>Observaciones</DataMember><Key>Observaciones</Key><Position>14</Position></Column14>";
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
			return mz.erp.businessrules.tpu_OrdenesCompraDet.GetList().tpu_OrdenesCompraDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_OrdenesCompraDet.Update( ( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

