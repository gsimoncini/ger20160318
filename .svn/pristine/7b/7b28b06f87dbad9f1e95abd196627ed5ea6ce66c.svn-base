using System;


public class ItemsComprobantesDeVenta: ItemsComprobantes
{
	public ItemsComprobantesDeVenta()
	{
	}

	public decimal Total()
	{
		decimal total = 0;
		foreach (ItemComprobanteDeVenta ic in List)
		{
			total+= ic.SubTotalPrecio();
		}
		return (total);
	}

	public decimal TotalConImpuestos()
	{
		decimal total = 0;
		foreach (ItemComprobanteDeVenta ic in List)
		{
			total+= ic.SubTotalPrecioConImpuestos();
		}
		return (total);
	}


}

