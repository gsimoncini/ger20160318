using System;
using System.Windows.Forms;
using mz.erp.businessrules;

namespace mz.erp	
{
	/// <summary>
	/// Descripción breve de ControlVersion.
	/// 
	/// </summary>
	public class ControlVersion
	{
		public ControlVersion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static bool IsValidVersion()
		{
			string version = Application.ProductVersion;
			string bdVersion = mz.erp.businessrules.Sistema.CurrentBDVersion;
			string appVersion = mz.erp.businessrules.Sistema.CurrentBDAppVersion;
			if (version.EndsWith( bdVersion ) && version.StartsWith(appVersion))
			{
				return true;
			}
			else
			{
				return false;
			}
			

		}

	}
}
