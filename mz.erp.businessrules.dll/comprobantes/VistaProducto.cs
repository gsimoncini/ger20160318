using System;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Deprecated
	/// </summary>
	public class VistaProducto
	{
		private string _idProducto;
		private decimal _cantidad;
		public VistaProducto()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region IdProducto
		public void SetIdProducto(string value)
		{
			IdProducto = value;
		}
		public string GetIdProducto()
		{
			return IdProducto;
		}
		public string IdProducto
		{
			set 
			{
				_idProducto = value;
			}
			get
			{
				return _idProducto ;
			}
		}
		#endregion 

		#region Cantidad
		public void SetCantidad(decimal value)
		{
			Cantidad = value;
		}
		public decimal GetCantidad()
		{
			return Cantidad;
		}
		public decimal Cantidad
		{
			set 
			{
				_cantidad = value;
			}
			get
			{
				return _cantidad ;
			}
		}
		#endregion
	}
}
