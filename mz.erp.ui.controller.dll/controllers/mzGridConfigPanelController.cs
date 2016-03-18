using System;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzGridConfigPanelController.
	/// </summary>
	public class mzGridConfigPanelController
	{

		#region Variables privadas
		
		private string _processName;
		private string _taskName;
		private string _gridName;
		
		#endregion

		#region propiedades

		public string ProcessName
		{
			set{_processName = value;}
			get{ return _processName;}
		}
		public string TaskName
		{
			set{_taskName = value;}
			get{ return _taskName;}
		}

		public string GridName
		{
			set { _gridName = value;}
			get { return _gridName;}
		}

		public string Path
		{
			get
			{
                string name = mz.erp.businessrules.Security.IdUsuario + "_" + _taskName+ "_" + _processName +"_" + _gridName + ".XML";
			 	string path = string.Format(mz.erp.systemframework.Util.ResourcePath() + "\\resources\\GridConfig\\" + name );
				return path;
			}
		}
		#endregion

		public mzGridConfigPanelController()
		{
		
		}
	}
}
