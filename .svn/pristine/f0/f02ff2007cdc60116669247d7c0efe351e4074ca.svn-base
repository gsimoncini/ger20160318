using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Node.
	/// </summary>
	public class Node
	{
		
		#region Constructores

		public Node(string key, string description)
		{
			_key = key;
			_description = description;
			_childs = new NodesCollection();
		}

		#endregion

		#region Variables Privadas
			private string _key = string.Empty;
			private string _description = string.Empty;
			private NodesCollection _childs;
			private int index = -1;
			private int count = 0;
			
			
		#endregion


		#region Propiedades

		public string Key
		{
			get
			{
				return _key;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
		}

		#endregion

		#region Metodos Publicos
			
		public void AddChild(Node node)
		{
			this._childs.Add(node);
		}

		public void AddChildBeforeLast(Node node)
		{
			this._childs.AddBeforeLast(node);
		}


		public bool HasNext()
		{
			return this._childs.Count > count;
		}

		public Node Next()
		{
			index ++;
			count ++;
			return (Node)this._childs.Get(index);
		}

		#endregion
	}





public class NodesCollection: CollectionBase
{
	
		
	public void Add(Node node)
	{
		this.List.Add(node);
	}

	public void AddBeforeLast(Node node)
	{
		this.List.Insert(this.List.Count - 1, node);
	}

	public NodesCollection()
	{

	}

	public Node Get(int index)
	{
		return (Node)this.List[index];
	}

	
	


}

}
