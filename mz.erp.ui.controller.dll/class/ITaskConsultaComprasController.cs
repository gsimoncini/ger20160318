using System;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ITaskConsultaComprasController.
	/// </summary>
	public interface ITaskConsultaComprasController: ITaskController
	{
		ReportFilterArray GetFiltro();
		void RefreshData();
		System.Data.DataTable GetResult();		
		string GetLayout();
		ArrayList GetJerarquias();	
		Type GetProductos();
		event System.EventHandler ObjectHasChanged;

	}
}
