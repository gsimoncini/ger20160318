using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripci�n breve de Recurso.
	/// </summary>
	public class Recurso
	{
		public Recurso()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}
		private int _idTipoDeRecurso;
		private string _dato;

		public int IdTipoDeRecurso
		{
			get{return _idTipoDeRecurso;}
			set{_idTipoDeRecurso = value;}

		}

		public string Dato
		{	
			get{return _dato;}
			set{_dato = value;}
		}
	}
}
