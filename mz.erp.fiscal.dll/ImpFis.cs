using System;
using System.Windows.Forms;
using EPSON_Impresora_Fiscal;
using FiscalPrinterLib;


namespace FiscalMZ
{
	public class ImpFis	{
		
		private static HASARClass _hasarClass;
		
		public ImpFis()
		{
		}

		/*public static AxEPSON_Impresora_Fiscal.AxPrinterFiscal Epson
		{
			get
			{								
				return _formK.ImpFis2;
			}
		}*/

		public static HASARClass Hasar
		{
			get
			{
				if ( _hasarClass == null )
				{
					_hasarClass = new HASARClass();						
				}

				return _hasarClass;
			}
	}


	}
}
