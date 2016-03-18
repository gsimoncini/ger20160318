using System;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripci�n breve de CancelacionComprobante.
	/// </summary>
	public abstract  class CancelacionComprobante: DataObject
	{
		private string _idComprobante;
		

		public CancelacionComprobante()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}

		public CancelacionComprobante(string IdComprobante)
		{
			
			_idComprobante = IdComprobante;
	

		}

		public string IdComprobante
		{
			get{return _idComprobante;}
			set{_idComprobante = value;}

		}
	}
}
