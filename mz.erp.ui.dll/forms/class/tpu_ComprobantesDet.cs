using System;

namespace mz.erp.ui.forms.classes
{
	
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_ComprobantesDet : IDisposable, IGridDocument
	{
		public tpu_ComprobantesDet()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_ComprobantesDet.GetList().tpu_ComprobantesDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_ComprobantesDet.Update( ( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

