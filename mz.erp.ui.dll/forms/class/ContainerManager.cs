using System;
using System.Collections;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ContainerManager.
	/// </summary>
	public class ContainerManager
	{
		public ContainerManager()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void UpdateSize(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl container, mz.erp.ui.controls.HierarchicalSearchControl jerarquiaControl)
		{
			container.ClientSize = new System.Drawing.Size(jerarquiaControl.Size.Width, jerarquiaControl.Top+jerarquiaControl.Size.Height);
		}

		public static void CollapseContainers(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar, string proceso, string tarea)
		{
			string contenedoresColapsados = mz.erp.businessrules.ContainerManager.CollapseContainers(proceso, tarea);
			if ( !contenedoresColapsados.Equals(string.Empty) )
			{
				//this.ProcessCollapseContainers(ultraExplorerBar, contenedoresColapsados);
				ArrayList conCollap = mz.erp.systemframework.Util.Parse(contenedoresColapsados, ",");
				foreach(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in ultraExplorerBar.Groups)
				{
					foreach(string unContenedor in conCollap)
					{
						if ( unContenedor.Equals(group.Key) )
							group.Expanded=false;					
					}
				}
			}
		}

		public static void CollapseContainers(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar, string variable)
		{
			string contenedoresColapsados = mz.erp.businessrules.ContainerManager.CollapseContainers(variable);
			if ( !contenedoresColapsados.Equals(string.Empty) )
			{
				//this.ProcessCollapseContainers(ultraExplorerBar, contenedoresColapsados);
				ArrayList conCollap = mz.erp.systemframework.Util.Parse(contenedoresColapsados, ",");
				foreach(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in ultraExplorerBar.Groups)
				{
					foreach(string unContenedor in conCollap)
					{
						if ( unContenedor.Equals(group.Key) )
							group.Expanded=false;					
					}
				}
			}
		}

		public static void ProcessCollapseContainers(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar, string contenedoresColapsados)
		{
			ArrayList conCollap = mz.erp.systemframework.Util.Parse(contenedoresColapsados, ",");
			foreach(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in ultraExplorerBar.Groups)
			{
				foreach(string unContenedor in conCollap)
				{
					if ( unContenedor.Equals(group.Key) )
						group.Expanded=false;					
				}
			}
		}

	}
}
