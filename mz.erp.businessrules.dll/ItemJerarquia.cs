
using System;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ItemJerarquia.
	/// </summary>
	public class ItemJerarquia
	{
		public ItemJerarquia(string Key)
		{
			_key = Key;
		}

		private string _key = string.Empty;
		private string _nodeKey = string.Empty;
		private string _nodeKeyPath = string.Empty;
		private string _nodeDescription = string.Empty;
		private string _jerarquia = string.Empty;
		


		public string NodeDescription
		{
			get{return _nodeDescription;}
			
		}

		public string Jerarquia
		{
			get{return _jerarquia;}
			
		}

		

		public string  NodeKeyPath 
		{
			get { return _nodeKeyPath; }
			set { _nodeKeyPath = value; }
		}

		public string  NodeKey
		{
			get { return _nodeKey; }
			set 
			{
				_nodeKey = value;
				DataRow row = null;
				switch (_key.ToUpper())
				{
					case "PRODUCTOS": 
					{
						row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_nodeKey);
					}
					break;
					case "CUENTAS": 
					{
						row = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(_nodeKey);
					}
						break;
					case "PROVEEDORES": 
					{
						row = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(_nodeKey);
					}
						break;
				}
				
				if(row != null)
				{
					_nodeDescription = Convert.ToString(row["Descripcion"]);
					_jerarquia = Convert.ToString(row["Jerarquia"]);
				}
			}
		}



		

					   
	}
}
