using System;
using System.Data;
using System.Collections;

namespace mz.erp.transactionManager
{
	/// <summary>
	/// Descripción breve de TaskDynamicInfo.
	/// </summary>
	public class TaskDynamicInfo: IComparable
	{
		
		#region Constructores
		public TaskDynamicInfo()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		private long _idTask;
		private Type _type;
		private int _order;
		private string _keyTask;
		private ArrayList _data;
		#endregion

		#region Variables Publicas
		
		public ArrayList Data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}

		public long IdTask
		{
			get
			{
				return _idTask;
			}
			set
			{
				_idTask = value;
							
			}

		}

		public string KeyTask
		{
			get
			{
				return _keyTask;
			}
			set
			{
				_keyTask = value;
			}

		}

		public Type Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}

		public int Order
		{
			get
			{
				return _order;
			}
			set
			{
				_order = value;
			}
		}


		#endregion

		#region Implementacion IComparable

		public int CompareTo( object obj )
		{
			return this.Order.CompareTo( ( ( TaskDynamicInfo )obj ).Order );
		}

		#endregion

	}
}
