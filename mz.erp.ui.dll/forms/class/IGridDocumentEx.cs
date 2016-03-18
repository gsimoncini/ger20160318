using System;
using System.Data;

namespace mz.erp.ui.forms.classes
{
	public interface IGridDocumentEx
	{
		string GetLayout();
		string GetLayout(string[] fieldsArray);
		DataTable GetList();
		void Update( object dataTable );
	}
}
