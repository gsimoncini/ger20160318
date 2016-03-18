using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de EstadoFormaDeEntrega.
	/// </summary>
	public class Estado: CollectionBase
	{
		public Estado()
		{
		}
		
		public void Add(EstadoFormaDeEntrega x)
		{
			List.Add(x);
		}
		
		public Estado Generate()
		{
			EstadoFormaDeEntrega  a = new EstadoFormaDeEntrega();
			EstadoFormaDeEntrega  b = new EstadoFormaDeEntrega();
			EstadoFormaDeEntrega  c = new EstadoFormaDeEntrega();
			EstadoFormaDeEntrega  d = new EstadoFormaDeEntrega();
			a.Descripcion = "Enviar";
			b.Descripcion = "Retirar";
			c.Descripcion = "xxxx";
			d.Descripcion = "yyyy";
			a.IdItem = "1";
			b.IdItem = "2";
			c.IdItem = "3";
			d.IdItem = "4";
			List.Add(a);
			List.Add(b);
			List.Add(c);
			List.Add(d);
			return this;
		}


	}

	public class EstadoFormaDeEntrega
	{
		public EstadoFormaDeEntrega()
		{
		}

		string _descripcion = string.Empty;
		string _idItem = string.Empty;

		public string Descripcion
		{
			set { _descripcion = value;}
			get { return _descripcion;}
		}
		public string IdItem
		{
			set { _idItem = value;}
			get { return _idItem;}
		}
		
	}
}
