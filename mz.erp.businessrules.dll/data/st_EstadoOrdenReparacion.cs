using System;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de st_EstadoOrdenReparacion.
	/// </summary>
	public class st_EstadoOrdenReparacion
	{
		public st_EstadoOrdenReparacion()
		{
			
		}

		public static DataRow GetByPk(string IdEstado)
		{
			return mz.erp.dataaccess.st_EstadoOrdenReparacion.GetByPk(IdEstado);
		}

		public static DataSet GetList(string IdEstados)
		{
			return mz.erp.dataaccess.st_EstadoOrdenReparacion.GetList(IdEstados);
		}

		public static DataSet GetList()
		{
			return mz.erp.dataaccess.st_EstadoOrdenReparacion.GetList();
		}

	}
}
