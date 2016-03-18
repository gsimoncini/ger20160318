using System;
using System.Windows.Forms;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripci�n breve de IFormDetail.
	/// </summary>
	public interface IFormDetail
	{
		void SetController(IDetailController uiController);
		DialogResult ShowModal();

	}
}
