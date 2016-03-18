using System;
using System.Collections;
using System.Drawing.Printing;
using System.Windows.Forms;
using mz.erp.businessrules;



namespace mz.erp.io
{
	/// <summary>
	/// Descripción breve de Class1.
	/// </summary>
	public class PrinterController
	{		
		private string _tipoImpresora = "";
		private string _impresora = "";
		public string Impresora
		{
			get 
			{return _impresora;}
			set 
			{
				if (value.Trim() != "") 
				{
					_impresora = value;
				}			
			}
		}	
	
		private int _copias = 1;
		public int Copias 
		{
			get {return _copias;}
			set {_copias = value;}
		}		
		private int _renglonesPorHoja = 80;
		public int RenglonesPorHoja
		{
			get {return _renglonesPorHoja;}
			set {_renglonesPorHoja = value;}
		}


		public PrinterController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Init();
		}

		public PrinterController(string TipoImpresora)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_tipoImpresora = TipoImpresora;
			Init();
		}


		public void Print(ArrayList lineas) 
		{					
			PrintDirect impre = new PrintDirect(_impresora);
			impre.Copias = _copias;
			impre.TipoImpresora = _tipoImpresora;
			impre.RenglonesPorHoja = _renglonesPorHoja;
			impre.PrintDocument(lineas);
		}

		private void Init() 
		{
			PageSetupDialog _psd = new PageSetupDialog();
			_psd.PageSettings = new System.Drawing.Printing.PageSettings();
			_psd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
			string _impresoraPredet = _psd.PrinterSettings.PrinterName;
			string _impresoraVar = Variables.GetValueString("IO.Impresoras." + _tipoImpresora);
			_impresora = _impresoraVar == "" ? _impresoraPredet : _impresoraVar;
		}

	}
}
