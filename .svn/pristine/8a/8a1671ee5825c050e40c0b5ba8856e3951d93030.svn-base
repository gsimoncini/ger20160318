namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class FuenteDeCambio : IDisposable, IGridDocument
	{
		public FuenteDeCambio()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdFuenteDeCamibo""><Caption>IdFuenteDeCamibo</Caption><DataMember>IdFuenteDeCamibo</DataMember><Key>IdFuenteDeCamibo</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdMoneda""><Caption>IdMoneda</Caption><DataMember>IdMoneda</DataMember><Key>IdMoneda</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""VigenciaDesde""><Caption>VigenciaDesde</Caption><DataMember>VigenciaDesde</DataMember><Key>VigenciaDesde</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""ViganciaHasta""><Caption>ViganciaHasta</Caption><DataMember>ViganciaHasta</DataMember><Key>ViganciaHasta</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""CotizacionExterna""><Caption>CotizacionExterna</Caption><DataMember>CotizacionExterna</DataMember><Key>CotizacionExterna</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>5</Position></Column5>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.FuenteDeCambio.GetList().FuenteDeCambio;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.FuenteDeCambio.Update( ( FuenteDeCambioDataset.FuenteDeCambioDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

