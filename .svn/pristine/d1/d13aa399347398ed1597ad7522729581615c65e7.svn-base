using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TaskCollectionData.
	/// </summary>
	public class TaskCollectionData: CollectionBase, IEnumerator
	{
		public TaskCollectionData( )
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			nIndex = -1;
		}
		public virtual void Add( DataSet aTaskDataset )
		{
			List.Add( aTaskDataset );
		}
		private string _taskName = string.Empty;
		public string TaskName
		{
			set { _taskName = value ; }
			get { return _taskName ; }
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
				if (nIndex < 0 || nIndex == List.Count)
					throw new IndexOutOfRangeException();
				return (DataSet)this.List[nIndex];
			}
		}

		public bool MoveNext()
		{
			nIndex ++;
			return (nIndex < this.List.Count);
		}

		#endregion
	}
}
