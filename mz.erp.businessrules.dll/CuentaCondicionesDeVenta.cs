using System;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{

	/// <summary>
	/// Descripción breve de CuentasCondicionesDeVenta.
	/// </summary>
	public class CuentaCondicionesDeVenta: CollectionBase
	{		
		public CuentaCondicionesDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void Add(object sender)
		{
			base.List.Add( sender );
		}

		public void AddProductoImpuesto(CuentaCondicionDeVenta ccv) 
		{
			this.Add(ccv);
		}
	}

	public class CuentaCondicionDeVenta 
	{
		private bool _valor = false;
		public bool Valor 
		{
			get 
			{
				return _valor;
			}
			set 
			{
				_valor = value;
			}
		}
		private string _descripcion = String.Empty;
		public string Descripcion 
		{
			get 
			{
				return _descripcion;
			}
			set 
			{
				_descripcion = value;
			}
		}
		private string _idCondicionDeVenta = String.Empty;
		public string IdCondicionDeVenta
		{
			get 
			{
				return _idCondicionDeVenta;
			}
			set 
			{
				_idCondicionDeVenta = value;
			}
		}

		private Cuenta _cuenta = null;
		public Cuenta Cuenta
		{
			get 
			{
				return _cuenta;
			}
			set 
			{
				_cuenta = value;
			}
		}

	}
}
