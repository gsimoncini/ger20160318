using System;
using System.Collections;

namespace mz.erp.ui.controllers
{
	public class Parameters
	{
		private ArrayList _parameters;
		private int index = 0;
		private bool _orderUIAvailable = false;

		public Parameters()
		{
			_parameters = new ArrayList();
		}
			
		public ArrayList Sort()
		{
			if(_orderUIAvailable)
			{
				ArrayList aux = new ArrayList();
				aux.AddRange(_parameters);
				aux.Sort(new SortByOrder());
				return aux;
			}
			else return _parameters;
		}

		public int Add( Parameter parameter )
		{
			parameter.Index = index++;

			_parameters.Add( parameter );

			return index;
		}

		public bool OrderUIAvailable
		{
			set
			{
				_orderUIAvailable = value;
			}
		}
		public int Count
		{
			get
			{
				return _parameters.Count;
			}
		}

		public Parameter this[ int index ]
		{
			get
			{
				return ( Parameter )_parameters[ index ];
			}
		}

		public Parameter AlternativePrimaryKey
		{
			get
			{
				foreach( Parameter p in _parameters )
				{
					if ( p.IsAlternativePrimaryKey )
					{
						return p;
					}
				}
				return null;
			}
		}

		public Parameter Metodo
		{
			get
			{
				foreach( Parameter p in _parameters )
				{
					return p;
				}
				return null;
			}
		}


		public Parameter Search
		{
			get
			{
				foreach( Parameter p in _parameters )
				{
					if ( p.IsSearch)
					{
						return p;
					}
				}
				return null;
			}
		}


		public Parameter Description
		{
			get
			{
				foreach( Parameter p in _parameters )
				{
					if ( p.IsDescription )
					{
						return p;
					}
				}
				return null;
			}
		}

		public object[] InvokeParameters
		{
			get
			{
				object[] invokeParameters = new object[ _parameters.Count ];
				for( int i = 0; i < _parameters.Count; i++ )
				{
					invokeParameters[ i ] = ( ( Parameter )_parameters[ i ] ).Value;
				}

				return invokeParameters;
			}
		}
	}

	public class SortByOrder : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			Parameter param1 = (Parameter)x;
			Parameter param2 = (Parameter)y;
			return param1.OrderUI.CompareTo(param2.OrderUI);
		}

		#endregion

	}
}
