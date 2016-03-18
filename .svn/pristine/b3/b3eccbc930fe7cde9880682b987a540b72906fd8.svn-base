using System;
using System.Collections;
namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de FormasDePagos.
	/// </summary>
	public class FormasDePagos:System.Collections.ArrayList
	{
		public FormasDePagos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public FormaDePago GetByTDCompMoneda(string IdTDCompTesoreria, string IdMoneda)
		{
			foreach(FormaDePago f in this)
			{
				if(f.IdTDComprobante.Equals(IdTDCompTesoreria) && f.IdMoneda.Equals(IdMoneda))
				{
					return f;
				}
			}
			return null;
		}

		public FormaDePago GetByTDCompTesoreria(string IdTDCompTesoreria)
		{
			foreach(FormaDePago f in this)
			{
				if(f.IdFormaDePago.Equals(IdTDCompTesoreria))
				{
					f.Agregada = true;
					f.SourceBD = true;
					return f;
				}
			}
			return null;
		}

		public FormaDePago Get(int index)
		{
			return (FormaDePago) this[index];
		}

		public void AddRange(ICollection colection)
		{
			foreach(FormaDePago f in colection)
			{
				this.Add(f);			
			}
		}

		public void SortByOrden()
		{
			this.Sort(new SortByOrder());
		}
	}

	public class SortByOrder : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			FormaDePago fdp1 = (FormaDePago)x;
			FormaDePago fdp2 = (FormaDePago)y;
			return fdp1.Orden.CompareTo(fdp2.Orden);
		}

		#endregion

	}
}
