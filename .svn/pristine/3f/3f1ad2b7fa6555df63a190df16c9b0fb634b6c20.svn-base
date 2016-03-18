using System;
using System.Collections;

namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripción breve de SortedArray.
	/// </summary>
	public class SortedArray: System.Collections.ArrayList
	{
		public SortedArray()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public override int Add(object value)
		{
			string a = Convert.ToString( value );
			return this.Add( a );
		}

		public int Add(string value)
		{
			int i = base.Add(( object )value.ToUpper());
			base.Sort();
			return i;
		}

		/// <summary>
		/// Busca un String valor en una matriz y devuelve el indice de base 0. Si no se encuentra retorna -1
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public override int BinarySearch(object value)
		{
			return this.BinarySearch( Convert.ToString( value ));
			
		}
		/// <summary>
		/// This funciton is deprecated. Return -1
		/// </summary>
		/// <param name="value"></param>
		/// <param name="comparer"></param>
		/// <returns></returns>
		public override int BinarySearch(object value, System.Collections.IComparer comparer)
		{
			#if DEBUG
				
			#endif

			return (int) -1;
		}
		/// <summary>
		/// /// This funciton is deprecated. Return -1
		/// </summary>
		/// <param name="index"></param>
		/// <param name="count"></param>
		/// <param name="value"></param>
		/// <param name="comparer"></param>
		/// <returns></returns>
		public override int BinarySearch(int index,int count,object value, System.Collections.IComparer comparer)
		{
			#if DEBUG
				
			#endif
			return (int) -1;
		}
		/// <summary>
		/// Busca un String valor en una matriz y devuelve el indice de base 0. Si no se encuentra retorna -1
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public int BinarySearch(string value)
		{
			int i = base.BinarySearch( (object)value.ToUpper());
			return i;
		}
		
	}
}
