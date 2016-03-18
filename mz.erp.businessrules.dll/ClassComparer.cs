using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CuentaCorriente.
	/// </summary>
	public class ClassComparer: ArrayList, IEnumerator
	{
		public ClassComparer()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//		
		}	
		
		public int Add(object value, long order)
		{
			ItemComparer cc = new ItemComparer();
			cc.Order = order;
			cc.Value = value;
			return base.Add(cc);			
		}
		
		public int Add(ItemComparer ic)
		{			
			return base.Add (ic);
		}

		public int Index
		{
			get {return _index;}
		}
		
		#region miembros de IEnumerator
		private int _index = -1;
		public void Reset() 
		{
			_index = -1;
		}
		public object Current 
		{			
			get {return base[_index];}
		}
		public bool MoveNext() 
		{
			_index ++;
			return _index < this.Count;
		}
		#endregion

		public void SetOrder()
		{
/*			switch(_orderBy)
			{
				case "FechaEmision":
				{
					this.Sort(ItemCuentaCorriente.SortByFechaEmisionInstance);
					break;
				}
				case "FechaVencimiento":
				{
					this.Sort(ItemCuentaCorriente.SortByFechaVencimientoInstance);
					break;
				}
			}		*/
			this.Sort(ItemComparer.SortByOrderInstance);
		}	
	}

	internal class SortByOrderClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{			
			ItemComparer item1 = (ItemComparer)x;
			ItemComparer item2 = (ItemComparer)y;
			return item1.Order.CompareTo(item2.Order);
		}

		#endregion
	}

	public class ItemComparer: IComparable
	{
		public ItemComparer()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		private long _order;
		public long Order
		{
			get {return _order; }
			set {_order = value; }
		}		
		private object _value;
		public object Value
		{
			get {return _value; }
			set {_value = value; }
		}

		public static IComparer SortByOrderInstance
		{
			get
			{
				return (IComparer)new SortByOrderClass(); 
			}
		}

		#region Implementacion IComparable

		public int CompareTo( object obj )
		{
			return this.Order.CompareTo( ( ( ItemComparer )obj ).Order );
		}
		#endregion
	}
}
