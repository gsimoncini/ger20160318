using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;

namespace mz.erp.businessrules
{
	public class Ticket
	{
		ArrayList headerLines = new ArrayList();
		ArrayList subHeaderLines = new ArrayList();
		ArrayList items = new ArrayList();
		ArrayList totales = new ArrayList();
		ArrayList footerLines = new ArrayList();
		private Image headerImage = null;

		int count = 0;

		int maxChar = 35;
		int maxCharDescription = 28;

		int imageHeight = 0;

		float leftMargin = 0;
		float topMargin = 1;

		string fontName = "Lucida Console";
		decimal fontSize = (decimal)8.2;

		Font printFont = null;
		SolidBrush myBrush = new SolidBrush(Color.Black);

		Graphics gfx = null;

		string line = null; 

		string _proceso = null;
		string _tarea = null;

		private string _impresora = null;
		private decimal _tamañoLetra = decimal.MinValue;
		private string _fuente = null;
		private decimal _maximoCaracteres = decimal.MinValue;
		private decimal _maximoCaracteresDescripcion = decimal.MinValue;
		private bool _habilitaImpresion = false;

		public bool HabilitaImpresion
		{
			get{return _habilitaImpresion;}
		}


		public void Init(string Proceso, string Tarea)
		{
			_proceso = Proceso;
			_tarea = Tarea;
			_habilitaImpresion = Variables.GetValueBool(_proceso, _tarea, "NOFiscal.Activo");
			if(!_habilitaImpresion)
				_habilitaImpresion = Variables.GetValueBool("NOFiscal.Activo");
			if(_habilitaImpresion)
			{
				_impresora = Variables.GetValueString(_proceso, _tarea, "NOFiscal.Impresora");
				if(_impresora == null || _impresora.Equals(string.Empty))
					_impresora = Variables.GetValueString( "NOFiscal.Impresora");
				_fuente = Variables.GetValueString(_proceso, _tarea, "NOFiscal.Fuente.Nombre");
				if(_fuente == null || _fuente.Equals(string.Empty))
					_fuente = Variables.GetValueString( "NOFiscal.Fuente.Nombre");
				_tamañoLetra =  Variables.GetValueDecimal(_proceso, _tarea, "NOFiscal.Fuente.Tamaño");
				if(_tamañoLetra.Equals(decimal.MinValue))
					_tamañoLetra = Variables.GetValueDecimal("NOFiscal.Fuente.Tamaño");
				_maximoCaracteres =  Variables.GetValueDecimal(_proceso, _tarea, "NOFiscal.MaximoCaracteres");
				if(_maximoCaracteres.Equals(decimal.MinValue))
					_maximoCaracteres = Variables.GetValueDecimal("NOFiscal.MaximoCaracteres");
				_maximoCaracteresDescripcion =  Variables.GetValueDecimal(_proceso, _tarea, "NOFiscal.MaximoCaracteres");
				if(_maximoCaracteresDescripcion.Equals(decimal.MinValue))
					_maximoCaracteresDescripcion = Variables.GetValueDecimal("NOFiscal.MaximoCaracteresDescripcion");
				if(_fuente != null && _fuente != string.Empty)
					fontName = _fuente;
				if(_tamañoLetra != decimal.MinValue)
					fontSize = _tamañoLetra;
				if(_maximoCaracteres != decimal.MinValue)
					maxChar = Convert.ToInt32(_maximoCaracteres);
				if(_maximoCaracteresDescripcion != decimal.MinValue)
					maxCharDescription = Convert.ToInt32(_maximoCaracteresDescripcion);
			}
		}

		public Ticket()
		{
           
		}

		public Image HeaderImage
		{
			get { return headerImage; }
			set { if (headerImage != value) headerImage = value; }
		}

		public int MaxChar
		{
			get { return maxChar; }
			set { if (value != maxChar) maxChar = value; }
		}

		public int MaxCharDescription
		{
			get { return maxCharDescription; }
			set { if (value != maxCharDescription) maxCharDescription = value; }
		}

		public decimal FontSize
		{
			get { return fontSize; }
			set { if (value != fontSize) fontSize = value; }
		}

		public string FontName
		{
			get { return fontName; }
			set { if (value != fontName) fontName = value; }
		}

		public void AddHeaderLine(string line)
		{
			headerLines.Add(line);
		}

		public void AddSubHeaderLine(string line)
		{
			subHeaderLines.Add(line);
		}

		public void AddItem(string cantidad,string item, string price)
		{
			OrderItem newItem = new OrderItem('?');
			items.Add(newItem.GenerateItem(cantidad,item, price));
		}

		public void AddTotal(string name,string price)
		{
			OrderTotal newTotal = new OrderTotal('?');
			totales.Add(newTotal.GenerateTotal(name, price));
		}

		public void AddFooterLine(string line)
		{
			footerLines.Add(line);
		}   

		private string AlignRightText(int lenght)
		{
			string espacios = "";
			int spaces = maxChar - lenght;
			for (int x = 0; x < spaces; x++)
				espacios += " ";
			return espacios;
		}

		private string DottedLine()
		{
			string dotted = "";
			for (int x = 0; x < maxChar; x++)
				dotted += "=";
			return dotted;
		}

		public bool PrinterExists(string impresora)
		{
			foreach (String strPrinter in PrinterSettings.InstalledPrinters)
			{
				if (impresora == strPrinter)
					return true;
			}
			return false;
		}

		public void PrintTicket()
		{
			printFont = new Font(fontName, (float)fontSize, FontStyle.Regular);
			PrintDocument pr = new PrintDocument();
			String pkInstalledPrinters;
			for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
			{
				pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
				Console.WriteLine(pkInstalledPrinters);
			}

			pr.PrinterSettings.PrinterName = _impresora;
			pr.PrintPage += new PrintPageEventHandler(pr_PrintPage);
			pr.Print();
		}

		private void pr_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.PageUnit = GraphicsUnit.Millimeter;
			gfx = e.Graphics;

			DrawImage();
			DrawHeader();
			DrawSubHeader();
			DrawItems();
			DrawTotales();
			DrawFooter();

			if (headerImage != null)
			{
				HeaderImage.Dispose();
				headerImage.Dispose();
			}
		}

		private float YPosition()
		{
			//float fontHeight = printFont.GetHeight(gfx);
			//float yPos = topMargin + (count * fontHeight + imageHeight + 5);
			float fontHeight = printFont.GetHeight(gfx);
			count = count + 3;
			float yPos = topMargin + count;
			return yPos;
		}

		private void DrawImage()
		{
			if (headerImage != null)
			{
				try
				{
					gfx.DrawImage(headerImage, new Point((int)leftMargin, (int)YPosition()));
					double height = ((double)headerImage.Height / 58) * 15;
					imageHeight = (int)Math.Round(height) + 3;
				}
				catch (Exception)
				{
				}
			}
		}

		private void DrawHeader()
		{
			int y = 1;
			foreach(string header in headerLines)
			{
				if (header.Length > maxChar)
				{
					int currentChar = 0;
					int headerLenght = header.Length;

					while (headerLenght > maxChar)
					{
						line = header.Substring(currentChar, maxChar);

						gfx.DrawString(line, printFont, myBrush, leftMargin,YPosition(), new StringFormat());

						count++;
						currentChar += maxChar;
						headerLenght -= maxChar;
					}
					line = header;
					gfx.DrawString(line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin,YPosition(), new StringFormat());
					count++;
				}
				else
				{
					line = header;
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					y = y +10;

					count++;
				}
			}
			DrawEspacio();
		}   

		private void DrawSubHeader()
		{
			foreach (string subHeader in subHeaderLines)
			{
				if (subHeader.Length > maxChar)
				{
					int currentChar = 0;
					int subHeaderLenght = subHeader.Length;

					while (subHeaderLenght > maxChar)
					{
						line = subHeader;
						gfx.DrawString(line.Substring(currentChar, maxChar), printFont, myBrush, leftMargin,YPosition(), new StringFormat());

						count++;
						currentChar += maxChar;
						subHeaderLenght -= maxChar;
					}
					line = subHeader;
					gfx.DrawString(line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else
				{
					line = subHeader;

					gfx.DrawString(line, printFont, myBrush, leftMargin,YPosition(), new StringFormat());

					count++;

					line = DottedLine();

					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

					count++;
				}
			}
			DrawEspacio();
		}

		private void DrawItems()
		{
			OrderItem ordIt = new OrderItem('?');

		//	gfx.DrawString("CANT  DESCRIPCION           IMPORTE", printFont, myBrush, leftMargin, YPosition(), new StringFormat());

		//	count++;
		//	DrawEspacio();

			foreach (string item in items)
			{
				//line = ordIt.GetItemCantidad(item);

				//gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

				line = ordIt.GetItemPrice(item);
				line = AlignRightText(line.Length) + line;

				float fontHeight = printFont.GetHeight(gfx);
				float cant = count + 3;
				float yPos = topMargin + cant;
				gfx.DrawString(line, printFont, myBrush, leftMargin, yPos, new StringFormat());

				string name = ordIt.GetItemName(item);

				leftMargin = 0;
				if (name.Length > maxCharDescription)
				{
					int currentChar = 0;
					int itemLenght = name.Length;

					while (itemLenght > maxCharDescription)
					{
						line = ordIt.GetItemName(item);
						//gfx.DrawString("      " + line.Substring(currentChar, maxCharDescription), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
						gfx.DrawString( line.Substring(currentChar, maxCharDescription), printFont, myBrush, leftMargin, YPosition(), new StringFormat());

						count++;
						currentChar += maxCharDescription;
						itemLenght -= maxCharDescription;
					}

					line = ordIt.GetItemName(item);
					//gfx.DrawString("      " + line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					gfx.DrawString(line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else
				{
					//gfx.DrawString("      " + ordIt.GetItemName(item), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					gfx.DrawString(ordIt.GetItemName(item), printFont, myBrush, leftMargin, YPosition(), new StringFormat());

					count++;
				}
			}

			leftMargin = 0;
		//	DrawEspacio();
		//	line = DottedLine();

		//	gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

			count++;
			DrawEspacio();
		}

		private void DrawTotales()
		{
			OrderTotal ordTot = new OrderTotal('?');

			foreach (string total in totales)
			{
				line =ordTot.GetTotalCantidad(total);
				line = AlignRightText(line.Length) + line;

				float fontHeight = printFont.GetHeight(gfx);
				float cant = count + 3;
				float yPos = topMargin + cant;
				gfx.DrawString(line, printFont, myBrush, leftMargin, yPos, new StringFormat());
				leftMargin = 0;

				line = "      "+ordTot.GetTotalName(total);
				gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
				count++;
			}
			leftMargin = 0;
			//DrawEspacio();
			DrawEspacio();
		}

		private void DrawFooter()
		{
			foreach (string footer in footerLines)
			{
				if (footer.Length > maxChar)
				{
					int currentChar = 0;
					int footerLenght = footer.Length;

					while (footerLenght > maxChar)
					{
						line = footer;
						gfx.DrawString(line.Substring(currentChar, maxChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());

						count++;
						currentChar += maxChar;
						footerLenght -= maxChar;
					}
					line = footer;
					gfx.DrawString(line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else
				{
					line = footer;
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

					count++;
				}
			}
			leftMargin = 0;
			DrawEspacio();
			DrawEspacio();
			DrawEspacio();
			//DrawEspacio();
			//DrawEspacio();
			//DrawEspacio();
			//line = "\x1B" + "i";// "\x1E" + "\x43" + "\x31";
			//line = "\x1D" + "V";
			//line = Convert.ToChar(27) + "i" ;//+ Convert.ToChar(13); 
			//CHR$(&H1D);"V";CHR$(66);CHR$(0); CHR$(&H1B); CHR$(&H70); CHR$(&H0); CHR$(60); CHR$(120);
			gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
		}

		private void DrawEspacio()
		{
			line = "";

			gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

			count++;
		}
	}

	public class OrderItem
	{
		char[] delimitador = new char[] { '?' };

		public OrderItem(char delimit)
		{
			delimitador = new char[] {delimit };
		}

		public string GetItemCantidad(string orderItem)
		{
			string [] delimitado = orderItem.Split(delimitador);
			return delimitado[0];
		}

		public string GetItemName(string orderItem)
		{
			string [] delimitado = orderItem.Split(delimitador);
			return delimitado[1];
		}

		public string GetItemPrice(string orderItem)
		{
			string[] delimitado = orderItem.Split(delimitador);
			return delimitado[2];
		}

		public string GenerateItem(string cantidad, string itemName, string price)
		{
			return cantidad + delimitador[0] + itemName + delimitador[0] + price;
		}
	}

	public class OrderTotal
	{
		char[] delimitador = new char[] { '?' };

		public OrderTotal(char delimit)
		{
			delimitador = new char[] { delimit };
		}

		public string GetTotalName(string totalItem)
		{
			string[] delimitado = totalItem.Split(delimitador);
			return delimitado[0];
		}

		public string GetTotalCantidad(string totalItem)
		{
			string[] delimitado = totalItem.Split(delimitador);
			return delimitado[1];
		}

		public string GenerateTotal(string totalName, string price)
		{
			return totalName + delimitador[0] + price;
		}
	}
}
