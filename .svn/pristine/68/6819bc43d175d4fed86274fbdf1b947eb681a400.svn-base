using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TaskDynamicInfo.
	/// </summary>
	public class TaskDynamicInfo : IComparable
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
		private object _taskInstance;
		private int _orderBR;
		private int _orderDA;
		private int _orderUI;

		#endregion

		#region Variables Publicas

		public static IComparer SortByOrderUIInstance
		{
			get
			{
				return (IComparer)new SortByOrderUIClass(); 
			}
		}

		public static IComparer SortByOrderBRInstance
		{
			get
			{
				return (IComparer)new SortByOrderBRClass(); 
			}
		}

		public static IComparer SortByOrderDAInstance
		{
			get
			{
				return (IComparer)new SortByOrderDAClass(); 
			}
		}
		
		public object TaskInstance
		{
			get
			{
				return _taskInstance;
			}
			set
			{
				_taskInstance = value;
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
				if(!value.Equals(_idTask))
				{
					_idTask = value;
					_keyTask = mz.erp.businessrules.twf_Tareas.GetByPk(_idTask).Descripcion;
					
				}
			}

		}

		public string KeyTask
		{
			get
			{
				return _keyTask;
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


		public int OrderBR
		{
			get
			{
				return _orderBR;
			}
			set
			{
				_orderBR = value;
			}

		}

		public int OrderDA
		{
			get
			{
				return _orderDA;
			}
			set
			{
				_orderDA = value;
			}
		}

		public int OrderUI
		{
			get
			{
				return _orderUI;
			}

			set
			{
				_orderUI = value;
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

	public class SortByOrderBRClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			TaskDynamicInfo task1 = (TaskDynamicInfo)x;
			TaskDynamicInfo task2 = (TaskDynamicInfo)y;
			return task1.OrderBR.CompareTo(task2.OrderBR);
		}

		#endregion

	}
	public class SortByOrderDAClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			
			TaskDynamicInfo task1 = (TaskDynamicInfo)x;
			TaskDynamicInfo task2 = (TaskDynamicInfo)y;
			return task1.OrderDA.CompareTo(task2.OrderDA);
		}

		#endregion

	}
	public class SortByOrderUIClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			
			TaskDynamicInfo task1 = (TaskDynamicInfo)x;
			TaskDynamicInfo task2 = (TaskDynamicInfo)y;
			return task1.OrderUI.CompareTo(task2.OrderUI);
		}

		#endregion

	}


}
