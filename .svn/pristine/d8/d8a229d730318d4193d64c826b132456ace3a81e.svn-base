using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Cuentas.
	/// </summary>
	public class Cuentas:System.Collections.ArrayList
	{
		public Cuentas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public Cuenta GetByIdCuenta(string IdCuenta)
		{
			foreach(Cuenta cuenta in this)
			{
				if(cuenta.IdCuenta.Equals(IdCuenta))
				{
					return cuenta;
				}
			}
			return null;
		}

		public Cuentas GetByMetodoAsignacion(string MetodoAsignacion)
		{
			Cuentas cuentas = new Cuentas();
			foreach(Cuenta cuenta in this)
			{
				if(cuenta.MetodoDeAsignacion.Equals(MetodoAsignacion))
				{
					cuentas.Add(cuenta);
				}
			}
			return cuentas;
		}

		public Cuenta Get(int index)
		{
			return (Cuenta) this[index];
		}

		public void AddRange(ICollection colection)
		{
			foreach(Cuenta cuenta in colection)
			{
				this.Add(cuenta);			
			}
		}
		/*
		public void Agregar(Cuenta Cta)
		{
			bool encontre = false;
			foreach(Cuenta cuenta in this)
			{
				if (cuenta.IdCuenta == Cta.IdCuenta)
				{
					encontre = true;
				}		
			}
			if (!encontre)
			{
				this.Add(Cta);
			}
		}*/
/*
		public void Borrar(string IdCuenta)
		{
			foreach(Cuenta cuenta in this)
			{
				if(cuenta.IdCuenta.Equals(IdCuenta))
				{
					cuenta.Agregado = !cuenta.Agregado;
				}
			}
		}*/


		public void SortByOrden()
		{
			this.Sort(new SortByOrderCuentas());
		}
	}

	public class SortByOrderCuentas : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			Cuenta cuenta1 = (Cuenta)x;
			Cuenta cuenta2 = (Cuenta)y;
			return cuenta1.CompareTo(cuenta2);
		}

		#endregion
	}
	
}
