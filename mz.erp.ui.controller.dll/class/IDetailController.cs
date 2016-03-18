using System;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripci�n breve de IDetailController.
	/// </summary>
	public interface IDetailController
	{
		void SetObject(object obj);
		string GetLayout();
		object RefreshData();
		string GetCaption();
	}
}
