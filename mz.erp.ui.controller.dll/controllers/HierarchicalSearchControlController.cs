using System;
using mz.erp.businessrules;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de HierarchicalSearchControlController.
	/// </summary>
	public class HierarchicalSearchControlController
	{
		public HierarchicalSearchControlController(string key)
		{
			Init(key);
		}


		private void Init(string Key)
		{

			_key = Key;
			switch (_key.ToUpper())
			{
				case "PRODUCTOS":
				{
					_nodeKey1 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia1");
					_nodeKey2 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia2");
					_nodeKey3 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia3");
					_nodeKey4 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia4");
					_nodeKey5 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia5");
					_nodeKey6 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia6");
					_nodeKey7 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia7");
					_nodeKey8 = Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia8");
				}break;
				case "CUENTAS":
				{
					_nodeKey1 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia1");
					_nodeKey2 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia2");
					_nodeKey3 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia3");
					_nodeKey4 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia4");
					_nodeKey5 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia5");
					_nodeKey6 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia6");
					_nodeKey7 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia7");
					_nodeKey8 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia8");
				}break;
				case "PROVEEDORES":
				{
					_nodeKey1 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia1");
					_nodeKey2 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia2");
					_nodeKey3 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia3");
					_nodeKey4 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia4");
					_nodeKey5 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia5");
					_nodeKey6 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia6");
					_nodeKey7 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia7");
					_nodeKey8 = Variables.GetValueString("Proveedores.BusquedaJerarquica.Jerarquia8");
				}break;

			}
		}

		#region Propiedades


		private ArrayList _itemsJerarquias1 = new ArrayList();
		private ArrayList _itemsJerarquias2 = new ArrayList();
		private ArrayList _itemsJerarquias3 = new ArrayList();
		private ArrayList _itemsJerarquias4 = new ArrayList();
		private ArrayList _itemsJerarquias5 = new ArrayList();
		private ArrayList _itemsJerarquias6 = new ArrayList();
		private ArrayList _itemsJerarquias7 = new ArrayList();
		private ArrayList _itemsJerarquias8 = new ArrayList();

		public ArrayList ItemsJerarquia1
		{
			get{return _itemsJerarquias1;}
			set{_itemsJerarquias1 = value;}
		}

		public ArrayList ItemsJerarquia2
		{
			get{return _itemsJerarquias2;}
			set{_itemsJerarquias2 = value;}
		}

		public ArrayList ItemsJerarquia3
		{
			get{return _itemsJerarquias3;}
			set{_itemsJerarquias3 = value;}
		}

		public ArrayList ItemsJerarquia4
		{
			get{return _itemsJerarquias4;}
			set{_itemsJerarquias4 = value;}
		}

		public ArrayList ItemsJerarquia5
		{
			get{return _itemsJerarquias5;}
			set{_itemsJerarquias5 = value;}
		}

		public ArrayList ItemsJerarquia6
		{
			get{return _itemsJerarquias6;}
			set{_itemsJerarquias6 = value;}
		}
		public ArrayList ItemsJerarquia7
		{
			get{return _itemsJerarquias7;}
			set{_itemsJerarquias7 = value;}
		}
		public ArrayList ItemsJerarquia8
		{
			get{return _itemsJerarquias8;}
			set{_itemsJerarquias8 = value;}
		}

		public bool IsValidKey1
		{
			get{return _nodeKey1 != string.Empty;}
		}
		
		public bool IsValidKey2
		{
			get{return _nodeKey2 != string.Empty;}
		}
		
		public bool IsValidKey3
		{
			get{return _nodeKey3 != string.Empty;}
		}
		public bool IsValidKey4
		{
			get{return _nodeKey4 != string.Empty;}
		}
		public bool IsValidKey5
		{
			get{return _nodeKey5 != string.Empty;}
		}		
		public bool IsValidKey6
		{
			get{return _nodeKey6 != string.Empty;}
		}
		public bool IsValidKey7
		{
			get{return _nodeKey7 != string.Empty;}
		}
		public bool IsValidKey8
		{
			get{return _nodeKey8 != string.Empty;}
		}
		
		private string _nodeDescription1 = string.Empty;
		public string NodeDescription1
		{
			get{return _nodeDescription1;}
			set{_nodeDescription1 = value;}
		}
		private string _nodeDescription2 = string.Empty;
		public string NodeDescription2
		{
			get{return _nodeDescription2;}
			set{_nodeDescription2 = value;}
		}
		private string _nodeDescription3 = string.Empty;
		public string NodeDescription3
		{
			get{return _nodeDescription3;}
			set{_nodeDescription3 = value;}
		}
		private string _nodeDescription4 = string.Empty;
		public string NodeDescription4
		{
			get{return _nodeDescription4;}
			set{_nodeDescription4 = value;}
		}
		private string _nodeDescription5 = string.Empty;
		public string NodeDescription5
		{
			get{return _nodeDescription5;}
			set{_nodeDescription5 = value;}
		}
		private string _nodeDescription6 = string.Empty;
		public string NodeDescription6
		{
			get{return _nodeDescription6;}
			set{_nodeDescription6 = value;}
		}
		private string _nodeDescription7 = string.Empty;
		public string NodeDescription7
		{
			get{return _nodeDescription7;}
			set{_nodeDescription7 = value;}
		}		
		private string _nodeDescription8 = string.Empty;
		public string NodeDescription8
		{
			get{return _nodeDescription8;}
			set{_nodeDescription8 = value;}
		}
		private string _nodeKey1 = "";

		public string  NodeKey1 
		{
			get { return _nodeKey1; }
			set { _nodeKey1 = value; }
		}
		bool _nodeChecked1 = false;
		public bool NodeChecked1
		{
			get { return _nodeChecked1; }
			set { _nodeChecked1 = value; }
		}	
		private string _nodeKey2 = "";
		public string  NodeKey2 
		{
			get { return _nodeKey2; }
			set { _nodeKey2 = value; }
		}
		bool _nodeChecked2 = false;
		public bool NodeChecked2
		{
			get { return _nodeChecked2; }
			set { _nodeChecked2 = value; }
		}	
		private string _nodeKey3 = "";
		public string  NodeKey3
		{
			get { return _nodeKey3; }
			set { _nodeKey3 = value; }
		}
		bool _nodeChecked3 = false;
		public bool NodeChecked3
		{
			get { return _nodeChecked3; }
			set { _nodeChecked3 = value; }
		}	
		private string _nodeKey4 = "";
		public string  NodeKey4
		{
			get { return _nodeKey4; }
			set { _nodeKey4 = value; }
		}
		bool _nodeChecked4 = false;
		public bool NodeChecked4
		{
			get { return _nodeChecked4; }
			set { _nodeChecked4 = value; }
		}	
		private string _nodeKey5 = "";
		public string  NodeKey5
		{
			get { return _nodeKey5; }
			set { _nodeKey5 = value; }
		}
		bool _nodeChecked5 = false;
		public bool NodeChecked5
		{
			get { return _nodeChecked5; }
			set { _nodeChecked5 = value; }
		}	
		private string _nodeKey6 = "";
		public string  NodeKey6
		{
			get { return _nodeKey6; }
			set { _nodeKey6 = value; }
		}
		bool _nodeChecked6 = false;
		public bool NodeChecked6
		{
			get { return _nodeChecked6; }
			set { _nodeChecked6 = value; }
		}
		private string _nodeKey7 = "";
		public string  NodeKey7
		{
			get { return _nodeKey7; }
			set { _nodeKey7 = value; }
		}
		bool _nodeChecked7 = false;
		public bool NodeChecked7
		{
			get { return _nodeChecked7; }
			set { _nodeChecked7 = value; }
		}
		private string _nodeKey8 = "";
		public string  NodeKey8
		{
			get { return _nodeKey8; }
			set { _nodeKey8 = value; }
		}
		bool _nodeChecked8 = false;
		public bool NodeChecked8
		{
			get { return _nodeChecked8; }
			set { _nodeChecked8 = value; }
		}
	
		private string _nodeKey1Path = string.Empty;

		public string  NodeKey1Path 
		{
			get { return _nodeKey1Path; }
			set { _nodeKey1Path = value; }
		}

		private string _nodeKey2Path = string.Empty;

		public string  NodeKey2Path 
		{
			get { return _nodeKey2Path; }
			set { _nodeKey2Path = value; }
		}

		private string _nodeKey3Path = string.Empty;

		public string  NodeKey3Path 
		{
			get { return _nodeKey3Path; }
			set { _nodeKey3Path = value; }
		}

		private string _nodeKey4Path = string.Empty;

		public string  NodeKey4Path 
		{
			get { return _nodeKey4Path; }
			set { _nodeKey4Path = value; }
		}

		private string _nodeKey5Path = string.Empty;

		public string  NodeKey5Path 
		{
			get { return _nodeKey5Path; }
			set { _nodeKey5Path = value; }
		}

		private string _nodeKey6Path = string.Empty;

		public string  NodeKey6Path 
		{
			get { return _nodeKey6Path; }
			set { _nodeKey6Path = value; }
		}

		private string _nodeKey7Path = string.Empty;

		public string  NodeKey7Path 
		{
			get { return _nodeKey7Path; }
			set { _nodeKey7Path = value; }
		}

		private string _nodeKey8Path = string.Empty;

		public string  NodeKey8Path 
		{
			get { return _nodeKey8Path; }
			set { _nodeKey8Path = value; }
		}

		private string _key = string.Empty;

		#endregion
	}
}

