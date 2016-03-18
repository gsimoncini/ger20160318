using System;

namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripción breve de HTML.
	/// </summary>
	public class HTML
	{
		public HTML()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static string Bold(string texto)
		{
			return String.Format("<b>{0}</b>", texto);
		}
	}
}
