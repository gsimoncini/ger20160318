using System;

namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripci�n breve de HTML.
	/// </summary>
	public class HTML
	{
		public HTML()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}
		public static string Bold(string texto)
		{
			return String.Format("<b>{0}</b>", texto);
		}
	}
}
