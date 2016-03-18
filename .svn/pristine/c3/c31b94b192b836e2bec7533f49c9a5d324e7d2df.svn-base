namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsy_Conceptos : IDisposable, IGridDocument
	{
		public tsy_Conceptos()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdConcepto""><Caption>IdConcepto</Caption><DataMember>IdConcepto</DataMember><Key>IdConcepto</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdTipoConcepto""><Caption>IdTipoConcepto</Caption><DataMember>IdTipoConcepto</DataMember><Key>IdTipoConcepto</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Valor""><Caption>Valor</Caption><DataMember>Valor</DataMember><Key>Valor</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>4</Position></Column4>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsy_Conceptos.GetList().tsy_Conceptos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_Conceptos.Update( ( tsy_ConceptosDataset.tsy_ConceptosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

