using System;
using System.Windows.Forms;

namespace mz.erp.ui.utility
{
	public class Environment
	{
		public Environment()
		{
		}

		private static Form _mainForm;
		public static Form MainForm
		{
			get
			{
				return _mainForm;
			}
			set
			{
				_mainForm = value;
			}
		}

		
	}
}
