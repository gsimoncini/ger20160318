using System;
using System.Data;

namespace mz.erp.ui.controllers
{
	public interface IGridDocument
	{
		string GetLayout();

		DataTable GetList();

		void Update( object dataTable );

		
	}
}
