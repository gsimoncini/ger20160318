using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripci�n breve de TipoDeComprobanteCondicionDeVenta.
	/// </summary>
	public class TiposDeComprobantes:System.Collections.ArrayList
	{
		public TiposDeComprobantes()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}

		public TipoDeComprobante GetByTDComp(string IdTDComp)
		{
			foreach(TipoDeComprobante tdc in this)
			{
				if(tdc.IdTipoComprobante.Equals(IdTDComp))
				{
					tdc.Agregado = true;
					tdc.SourceBD = true;
					return tdc;
				}
			}
			return null;
		}

		public TipoDeComprobante Get(int index)
		{
			return (TipoDeComprobante) this[index];
		}

		public void AddRange(ICollection colection)
		{
			foreach(TipoDeComprobante tdc in colection)
			{
				this.Add(tdc);			
			}
		}

		public void SortByOrden()
		{
			this.Sort(new SortByOrderTiposDeComprobantes());
		}
	}

	public class SortByOrderTiposDeComprobantes : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			TipoDeComprobante tdc1 = (TipoDeComprobante)x;
			TipoDeComprobante tdc2 = (TipoDeComprobante)y;
			return tdc1.CompareTo(tdc2);
		}

		#endregion
	}
}
