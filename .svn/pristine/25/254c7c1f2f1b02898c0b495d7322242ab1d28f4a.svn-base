using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;


[StructLayout( LayoutKind.Sequential)]
public struct DOCINFO
{
	[MarshalAs(UnmanagedType.LPWStr)]public string pDocName;
	[MarshalAs(UnmanagedType.LPWStr)]public string pOutputFile;
	[MarshalAs(UnmanagedType.LPWStr)]public string pDataType;
}
namespace mz.erp.io
{
	/// <summary>
	/// Descripción breve de PrintDirect.
	/// </summary>
	public class PrintDirect : IDisposable
	{
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

		string _tipoImpresora = "";
		public string TipoImpresora
		{
			get 
			{return _tipoImpresora;}
			set 
			{_tipoImpresora = value;}
		}	

		// Track whether Dispose has been called.
		private bool disposed = false;

		System.IntPtr lhPrinter;
		DOCINFOA di;
		string PrinterName = "";

		public PrintDirect(string PrinterName)
		{
			if( PrinterName != null && PrinterName != "" )
				this.PrinterName = PrinterName;

			lhPrinter=new System.IntPtr();
			di = new DOCINFOA();

			di.pDocName="MINI-MI Document";
			di.pDataType="RAW";

			PrintDirect.OpenPrinter(this.PrinterName, out lhPrinter,0);
			if( lhPrinter == System.IntPtr.Zero )
				throw new Exception("Error en la impresora " + this.PrinterName); //not open/found
			PrintDirect.StartDocPrinter(lhPrinter, 1, di);
			PrintDirect.StartPagePrinter(lhPrinter);
		}//constructor

		// Implement Idisposable.
		// Do not make this method virtual.
		// A derived class should not be able to override this method.
		public void Dispose()
		{
			Dispose(true);
			// Take yourself off of the Finalization queue 
			// to prevent finalization code for this object
			// from executing a second time.
			GC.SuppressFinalize(this);
		}


		protected virtual void Dispose(bool disposing)
		{
			try
			{
				// Check to see if Dispose has already been called.
				if(!this.disposed)
				{
					// If disposing equals true, dispose all managed 
					// and unmanaged resources.
					if(disposing)
					{
						PrintDirect.ClosePrinter(lhPrinter);
					}
				}
			}
			catch (Exception ex)
			{//do nothing
				ex.ToString();
			}
			disposed = true;         
		}

		public void PrintDocument( ArrayList Lineas )
		{
			try
			{
				IntPtr pBytes;
				Int32 dwCount;				
				
				Lineas = AddEjects(Lineas);				

				for (int i = 0; i < _copias; i++) 
				{										
					// How many characters are in the string?
					foreach( string line in Lineas )
					{
						string lineToPrint = line + "\r\n";

						dwCount = lineToPrint.Length;
						// Assume that the printer is expecting ANSI text, and then convert
						// the string to ANSI text.
						pBytes = Marshal.StringToCoTaskMemAnsi(lineToPrint);
						// Send the converted ANSI string to the printer.						
						
						SendBytesToPrinter(this.PrinterName, pBytes, dwCount);
						Marshal.FreeCoTaskMem(pBytes);
					}//foreach					
				}//for
				PrintDirect.EndPagePrinter(lhPrinter);				
				PrintDirect.EndDocPrinter(lhPrinter);
			}
			catch( Exception ex )
			{
				throw ex;
			}	
		}//PrintDocument

		private ArrayList AddEjects(ArrayList Lineas) 
		{
			string EJECT = GetEject(_tipoImpresora);
			ArrayList LineasArr = new ArrayList();
			int renglones = 0;
			foreach( string line in Lineas ) 
			{
				LineasArr.Add(line);								
				renglones++;
				if (renglones >= _renglonesPorHoja)
				{
					renglones = 0;
					LineasArr.Add(EJECT);							
				}
			}			
			if (LineasArr[LineasArr.Count-1].ToString() != EJECT) 
			{
				LineasArr.Add(EJECT);
			}
			return LineasArr;
		}

		private string GetEject(string TipoImpresora) 
		{
			string eject = "";
			switch (TipoImpresora) 
			{
				case "Matricial":					
					eject = "\f";
					break;
				case "Laser":
					break;
				case "Tinta":
					break;
			}
			return eject;
		}

		// SendBytesToPrinter()
		// When the function is given a printer name and an unmanaged array
		// of bytes, the function sends those bytes to the print queue.
		// Returns true on success, false on failure.
		private static bool SendBytesToPrinter( string szPrinterName, IntPtr pBytes, Int32 dwCount)
		{
			Int32    dwError = 0, dwWritten = 0;
			IntPtr    hPrinter = new IntPtr(0);
			DOCINFOA    di = new DOCINFOA();
			bool    bSuccess = false; // Assume failure unless you specifically succeed.

			di.pDocName = "My C#.NET RAW Document";
			di.pDataType = "RAW";

			// Open the printer.
			if( OpenPrinter( szPrinterName, out hPrinter, 0 ) )
			{
				// Start a document.
				if( StartDocPrinter(hPrinter, 1, di) )
				{
					// Start a page.
					if( StartPagePrinter(hPrinter) )
					{
						// Write your bytes.
						bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
						EndPagePrinter(hPrinter);
					}
					EndDocPrinter(hPrinter);
				}
				ClosePrinter(hPrinter);
			}
			// If you did not succeed, GetLastError may give more information
			// about why not.
			if( bSuccess == false )
			{				
				dwError = Marshal.GetLastWin32Error();
			}
			return bSuccess;
		}



		// Structure and API declarions:
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
			public class DOCINFOA
		{
			[MarshalAs(UnmanagedType.LPStr)] public string pDocName;
			[MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
			[MarshalAs(UnmanagedType.LPStr)] public string pDataType;
		}
		[DllImport("winspool.Drv", EntryPoint="OpenPrinterA", SetLastError=true, CharSet=CharSet.Ansi, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, long pd);

		[DllImport("winspool.Drv", EntryPoint="ClosePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool ClosePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint="StartDocPrinterA", SetLastError=true, CharSet=CharSet.Ansi, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool StartDocPrinter( IntPtr hPrinter, Int32 level,  [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

		[DllImport("winspool.Drv", EntryPoint="EndDocPrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool EndDocPrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint="StartPagePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool StartPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint="EndPagePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool EndPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint="WritePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten );

	}//class PrintDirect
}

