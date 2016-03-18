using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ProcessCollectionData.
	/// </summary>
	public class ProcessCollectionData:CollectionBase, IEnumerator
	{
		public ProcessCollectionData()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			nIndex = -1;
		}
		private long _processId;
		public long ProcessId
		{
			get { return _processId; }
			set { _processId = value ; }
		}

		#region Miembros de IEnumerator
		private int nIndex;
		public void Reset()
		{
			nIndex = -1;
		}

		public object Current
		{
			get
			{
				if ((nIndex < 0) || (nIndex == this.List.Count ))
					throw new IndexOutOfRangeException();
				return (TaskCollectionData)this.List[nIndex];
			}
		}

		public bool MoveNext()
		{
			nIndex ++;
			return (nIndex < this.List.Count);
		}
		public virtual void Add( TaskCollectionData _taskCollectionData )
		{
			List.Add( _taskCollectionData );
		}
		#endregion

	}

}
