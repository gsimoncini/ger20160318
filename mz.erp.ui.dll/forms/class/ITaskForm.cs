using System;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripci�n breve de ITaskForm.
	/// </summary>
	public interface ITaskForm
	{
		void ShowForm();
		void CloseForm();
		void Execute();
		void Previous();
		void KeyDownPrevious();
		void KeyDownNext();
	}
}
