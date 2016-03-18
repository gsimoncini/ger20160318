using System;

namespace mz.erp.businessrules.data
{
	/// <summary>
	/// Descripción breve de tfi_GetValorCotizacionEx.
	/// </summary>
	public class tfi_GetValorCotizacionEx
	{
		public tfi_GetValorCotizacionEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static decimal GetValorCotizacion(string IdMonedaOrigen, string IdMonedaDestino)
		{
			decimal valor = mz.erp.dataaccess.tfi_GetValorCotizacionEx.GetValorCotizacion(IdMonedaOrigen, IdMonedaDestino);
			if (valor == 0)
			{
				valor =mz.erp.dataaccess.tfi_GetValorCotizacionEx.GetValorCotizacion(IdMonedaDestino , IdMonedaOrigen );
				if (valor == 0 ) return 1;
				else return 1/valor;
									
			}
			return valor;
		}

	}
}
