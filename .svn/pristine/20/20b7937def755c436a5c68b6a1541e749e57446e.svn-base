using System;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de TaskDynamicInfo.
	/// </summary>
	public class ControllerDynamicInfo : IComparable
	{
		
		#region Constructores
		public ControllerDynamicInfo()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		
		private Type _type;
		private int _order;
		private string _keyController;
		private object _controllerInstance;
		private string _keyTask;
		

		#endregion

		#region Variables Publicas
		
		public object ControllerInstance
		{
			get
			{
				return _controllerInstance;
			}
			set
			{
				_controllerInstance = value;
			}
		}

		public string KeyController
		{
			get
			{
				return _keyController;
			}
			set
			{
				_keyController = value;
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


		#endregion

		#region Implementacion IComparable

		public int CompareTo( object obj )
		{
			return this.Order.CompareTo( ( ( ControllerDynamicInfo )obj ).Order );
		}

		#endregion

		public bool Equals(object anotherControllerDynamicInfo)
		{
			ControllerDynamicInfo cdi = (ControllerDynamicInfo)anotherControllerDynamicInfo;
			return cdi.Equals(this.ControllerInstance);
		}


	}
}
