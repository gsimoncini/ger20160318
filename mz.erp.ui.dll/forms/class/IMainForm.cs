using System;

namespace mz.erp.ui.forms.classes
{
	public interface IMainForm
	{
		void SetProgressBar( int value );
		void SetProgressBarTop( int value );
		void SetMessage( string _message);
		void CerrarSesion();
	}
}
