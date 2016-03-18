using System;
using System.Windows.Forms;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de KeyDownManager.
	/// </summary>
	public class KeyDownManager
	{
		private Form _formulario;

		public KeyDownManager(Form Formulario)
		{        
			_formulario = Formulario; 
			_formulario.KeyDown += new KeyEventHandler(KeyDown);
		}

		private void KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Modifiers == System.Windows.Forms.Keys.Alt)
			{
				if(e.KeyCode == System.Windows.Forms.Keys.S)
				{
					((ITaskForm)_formulario).KeyDownNext();
				}
				if(e.KeyCode == System.Windows.Forms.Keys.A)
				{
					((ITaskForm)_formulario).KeyDownPrevious();
				}
			}	
		}

	}
}
