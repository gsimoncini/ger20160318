using System;

namespace mz.replication.configuration
{
	/// <summary>
	/// Elemento para operaciones de sincronización de datos.
	/// </summary>
	public class JobItem : IComparable
	{
		private DateTime _dateTime;
		
		private Guid _rowId;
		private string _body;
		private string _error;

		public JobItem()
		{
		}

		public DateTime DateTime
		{
			get{ return _dateTime; }
			set{ _dateTime = value; }
		}


		public Guid RowId
		{
			get{ return _rowId; }
			set{ _rowId = value; }
		}

		public string Body
		{
			get{ return _body; }
			set{ _body = value; }
		}

		public string Error
		{
			get{ return _error; }
			set{ _error = value; }
		}

		#region Miembros de IComparable

		public int CompareTo( object obj )
		{
			return this.DateTime.CompareTo( ( ( JobItem )obj ).DateTime );
		}

		#endregion
	}
}
