namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_AgrupamientosCuentas : IDisposable, IGridDocument
	{
		public tsa_AgrupamientosCuentas()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdCuenta""><Caption>IdCuenta</Caption><DataMember>IdCuenta</DataMember><Key>IdCuenta</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdAgrupamiento""><Caption>IdAgrupamiento</Caption><DataMember>IdAgrupamiento</DataMember><Key>IdAgrupamiento</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>8</Position></Column8>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_AgrupamientosCuentas.GetList().tsa_AgrupamientosCuentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_AgrupamientosCuentas.Update( ( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

