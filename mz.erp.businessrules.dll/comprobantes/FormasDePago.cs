using System;
using System.Collections;


public class FormasDePago	: CollectionBase
{

	public void Add(Cheque cheque)
	{
		List.Add(cheque);
	}

	public void Add(Tarjeta tarjeta)
	{
		List.Add(tarjeta);
	}

	public void Add(Moneda moneda)
	{
		List.Add(moneda);
	}

}// END CLASS DEFINITION FormasDePago
