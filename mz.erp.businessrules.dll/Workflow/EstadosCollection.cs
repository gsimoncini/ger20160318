using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Clase collectionBase que se puede utilizar para definir varios estados, 
	/// en su list se almacena la lista de Estados (que maneja solamente idItem y descripcion).
	/// Por ej: el GenerateFormaDeEntrega() almacena dos formas de entrega , "enviar", "retirar" (dos estados)
	/// de esta forma se pueden implementar otros GenerateXXX , con otros estados por default almacenados
	/// </summary>
	public class EstadosCollection: CollectionBase
	{
		public EstadosCollection()
		{
		}
		

		public void Add(Estado est)
		{
			List.Add(est);
			
		}
		public virtual string GetValue( string id )
		{
			foreach( Estado est in List )
			{
				if (est.IdItem.Equals(id))
					return est.Descripcion;
			}
			return string.Empty;
		}
		public virtual bool Contains(string Id)
		{
			foreach( Estado est in List )
			{
				if (est.IdItem.Equals(Id))
					return true;
			}
			return false;
		}

		public virtual string KeyOfValue( string value )
		{
		
			foreach( Estado est in List )
			{
				if (est.Descripcion.Equals(value))
					return est.IdItem;
			}
			return null;
		}
		public virtual bool ContainsValue(string value)
		{
			foreach( Estado est in List )
			{
				if (est.Descripcion.Equals(value))
					return true;
			}
			return false;
		}
		public ArrayList GetIdValues( string[] descripciones )
		{
			ArrayList a = new ArrayList();
			for (int i=0;i<descripciones.Length;i++)
			{
				string index = this.KeyOfValue( descripciones[i] );
				if (index != null)
				{
					a.Add( index );
				}
			}
			return a;
		}

		public EstadosCollection GenerateFormaDeEntrega()
		{
			
			List.Clear();
			string FormasDeEntrega = Variables.GetValueString("Productos.Entregas.FormasDeEntregas");
			ArrayList FormasDeEntregaList = mz.erp.systemframework.Util.Parse(FormasDeEntrega, ",");
			int i = 0;
			foreach(string fde in FormasDeEntregaList)
			{
				i++;
				Estado estado = new Estado();
				estado.IdItem = Convert.ToString(i);
				estado.Descripcion = fde;
				List.Add(estado);

			}
			return this;
		}

		public EstadosCollection GenerateEstadoFlete()
		{
			Estado a = new Estado();
			Estado b = new Estado();
			a.Descripcion = "Pendiente";
			b.Descripcion = "Liquidado";
			a.IdItem = "1";
			b.IdItem = "2";
			List.Add(a);
			List.Add(b);
			return this;
		}
		
	}

	
	public class Estado
	{
		public Estado()
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
