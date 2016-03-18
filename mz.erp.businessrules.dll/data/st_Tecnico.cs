using System;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de st_Tecnico.
	/// </summary>
	public class st_Tecnico
	{
		#region Custom Members
		public static st_TecnicoDataset GetList(string Habilitado)
		{
			return mz.erp.dataaccess.st_Tecnico.GetList(Habilitado);
		}
	
		#endregion

		public st_Tecnico()
		{
		}

		public static st_TecnicoDataset GetList()
		{
			return mz.erp.dataaccess.st_Tecnico.GetList();
		}

	}
}
