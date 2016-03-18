using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Excel;
//using Microsoft.Office.Core;
using System.Runtime.InteropServices; // For COMException
using System.Reflection; // For Missing.Value and BindingFlags
using System.Diagnostics; // to ensure EXCEL process is really killed
using mz.erp.businessrules;

namespace mz.erp.ui.forms.classes
{
    #region ExportToExcel CLASS
    /// This class processes the DataView that it is provided and
    /// Exports this DataView to an Excel document.
    public class ExportToExcel
    {

        #region InstanceFields
        //Instance Fields
        public delegate void ProgressHandler(object sender, ProgressEventArgs e);
        public event ProgressHandler prg;
        private DataView dv;
        private Style styleRows;
		private Style styleRowsMoneda;
		private Style styleRowsInteger;
		private Style styleRowsDecimal;
        private Style styleRowsFecha;
        private Style styleColumnHeadings;
        private Excel.Application EXL;
        private Workbook workbook;
        private Sheets sheets;
        private Worksheet worksheet;
        private string[,] myTemplateValues;
        private int position;
		private ArrayList _columnsProperties = new ArrayList();
        #endregion
        
        #region Constructor
        //Constructs a new export2Excel object. The user must
        //call the createExcelDocument method once a valid export2Excel
        //object has been instantiated
        public ExportToExcel()
        {

        }
        #endregion


		public bool IsOpen(string filename)
		{
			System.IO.FileStream fs;
			try
			{
				if (System.IO.File.Exists(filename))
				{
					fs = System.IO.File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None);
					fs.Close();
				}else //el archivo aún no existe con lo cual no puede estar abierto.
					return false;
			}
			catch (Exception exp)
			{
				return true;
			}
			return false;
		}


		public void Export(System.Data.DataView source, string fileName,string sheetName, ArrayList columnsProperties)

		{

			this._columnsProperties = columnsProperties;
			System.IO.StreamWriter excelDoc;
			excelDoc = new System.IO.StreamWriter(fileName);
			const string startExcelXML = "<xml version>\r\n<Workbook " + 
					  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" + 
					  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " + 
					  "xmlns:x=\"urn:schemas-    microsoft-com:office:" + 
					  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" + 
					  "office:spreadsheet\">\r\n <Styles>\r\n " + 
					  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " + 
					  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" + 
					  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" + 
					  "\r\n <Protection/>\r\n </Style>\r\n " + 
					  "<Style ss:ID=\"BoldColumn\">\r\n <Font " + 
					  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " + 
					  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" + 
					  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " + 
					  "ss:ID=\"Decimal\">\r\n <NumberFormat " + 
					  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " + 
					  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " + 
					  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " + 
					  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " + 
					  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " + 
					  "</Styles>\r\n ";
			const string endExcelXML = "</Workbook>";

			int rowCount = 0;
			int sheetCount = 1;
			/*
															   <xml version>
															   <Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"
															   xmlns:o="urn:schemas-microsoft-com:office:office"
															   xmlns:x="urn:schemas-microsoft-com:office:excel"
															   xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet">
															   <Styles>
															   <Style ss:ID="Default" ss:Name="Normal">
																 <Alignment ss:Vertical="Bottom"/>
																 <Borders/>
																 <Font/>
																 <Interior/>
																 <NumberFormat/>
																 <Protection/>
															   </Style>
															   <Style ss:ID="BoldColumn">
																 <Font x:Family="Swiss" ss:Bold="1"/>
															   </Style>
															   <Style ss:ID="StringLiteral">
																 <NumberFormat ss:Format="@"/>
															   </Style>
															   <Style ss:ID="Decimal">
																 <NumberFormat ss:Format="0.0000"/>
															   </Style>
															   <Style ss:ID="Integer">
																 <NumberFormat ss:Format="0"/>
															   </Style>
															   <Style ss:ID="DateLiteral">
																 <NumberFormat ss:Format="mm/dd/yyyy;@"/>
															   </Style>
															   </Styles>
															   <Worksheet ss:Name="Sheet1">
															   </Worksheet>
															   </Workbook>
															   */
			excelDoc.Write(startExcelXML);
			excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
			excelDoc.Write("<Table>");
			excelDoc.Write("<Row>");
			ArrayList aux = new ArrayList();
			foreach(PropertiesColumn pc in this._columnsProperties)
			{
				if(pc.Visible)
				{
					aux.Add(pc);
					excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
					excelDoc.Write(pc.ColumnCaption);
					excelDoc.Write("</Data></Cell>");
					
				}
			}
			excelDoc.Write("</Row>");
			foreach(DataRowView x in source)
			{
				rowCount++;
				//if the number of rows is > 64000 create a new page to continue output
				if(rowCount==64000) 
				{
					rowCount = 0;
					sheetCount++;
					excelDoc.Write("</Table>");
					excelDoc.Write(" </Worksheet>");
					excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
					excelDoc.Write("<Table>");
				}
				excelDoc.Write("<Row>"); //ID=" + rowCount + "
				foreach(PropertiesColumn pc in aux)
				{
					if (source.Table.Columns.Contains(pc.ColumnName))
					{
						System.Type rowType = x.Row[pc.ColumnName].GetType();
						switch(rowType.ToString())
						{
							case "System.String":
								string XMLstring = x.Row[pc.ColumnName].ToString();
								XMLstring = XMLstring.Trim();
								XMLstring = XMLstring.Replace("&","");
								XMLstring = XMLstring.Replace(">",")");
								XMLstring = XMLstring.Replace("<","(");
								excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
									"<Data ss:Type=\"String\">");
								excelDoc.Write(XMLstring);
								excelDoc.Write("</Data></Cell>");
								break;
							case "System.DateTime":
								//Excel has a specific Date Format of YYYY-MM-DD followed by  
								//the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
								//The Following Code puts the date stored in XMLDate 
								//to the format above
								DateTime XMLDate = (DateTime)x.Row[pc.ColumnName];
								string XMLDatetoString = ""; //Excel Converted Date
								XMLDatetoString = XMLDate.Year.ToString() +
									"-" +(XMLDate.Month < 10 ? "0" + XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
									"-" +(XMLDate.Day < 10 ? "0" + XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
									"T" +(XMLDate.Hour < 10 ? "0" + XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
									":" +(XMLDate.Minute < 10 ? "0" + XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +":" +
									(XMLDate.Second < 10 ? "0" + XMLDate.Second.ToString() : XMLDate.Second.ToString()) + ".000";
								excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" + "<Data ss:Type=\"DateTime\">");
								excelDoc.Write(XMLDatetoString);
								excelDoc.Write("</Data></Cell>");
								break;
							case "System.Boolean":
								excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
									"<Data ss:Type=\"String\">");
								excelDoc.Write(x.Row[pc.ColumnName].ToString());
								excelDoc.Write("</Data></Cell>");
								break;
							case "System.Int16":
							case "System.Int32":
							case "System.Int64":
							case "System.Byte":
								excelDoc.Write("<Cell ss:StyleID=\"Integer\">" + 
									"<Data ss:Type=\"Number\">");
								excelDoc.Write(x.Row[pc.ColumnName].ToString());
								excelDoc.Write("</Data></Cell>");
								break;
							case "System.Decimal":
							case "System.Double":
								excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" + 
									"<Data ss:Type=\"Number\">");
								excelDoc.Write(x.Row[pc.ColumnName].ToString());
								excelDoc.Write("</Data></Cell>");
								break;
							case "System.DBNull":
								excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
									"<Data ss:Type=\"String\">");
								excelDoc.Write("");
								excelDoc.Write("</Data></Cell>");
								break;
							default:
								throw(new Exception(rowType.ToString() + " not handled."));
						}
					}
					else
					{
						excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
							"<Data ss:Type=\"String\">");
						excelDoc.Write("");
						excelDoc.Write("</Data></Cell>");
					}
				}
				excelDoc.Write("</Row>");
			}
			excelDoc.Write("</Table>");
			excelDoc.Write(" </Worksheet>");
			excelDoc.Write(endExcelXML);
			excelDoc.Close();
			
			Excel.ApplicationClass EXL = new Excel.ApplicationClass();
			workbook = EXL.Workbooks.Open(fileName,
				0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
				true, false, 0, true, false, false);
			EXL.Visible = true; 
			Worksheet worksheet = (Worksheet)EXL.ActiveSheet; 
			worksheet.Activate();
			
		}
	

        #region EXCEL : ExportToExcel
        //Exports a DataView to Excel. The following steps are carried out
        //in order to export the DataView to Excel
        //Create Excel Objects
        //Create Column & Row Workbook Cell Rendering Styles
        //Fill Worksheet With DataView
        //Add Auto Shapes To Excel Worksheet
        //Select All Used Cells
        //Create Headers/Footers
        //Set Status Finished
        //Save workbook & Tidy up all objects
        //@param dv : DataView to use
        //@param path : The path to save/open the EXCEL file to/from
        //@param sheetName : The target sheet within the EXCEL file
        
		public void Export1(DataView dv,string path, string sheetName, ArrayList columnsProperties)
        {

            try
            {
                //Assign Instance Fields
                this.dv = dv;
				this._columnsProperties = columnsProperties;
                #region NEW EXCEL DOCUMENT : Create Excel Objects

                //create new EXCEL application
                EXL = new Excel.ApplicationClass();
                //index to hold location of the requested sheetName in the workbook sheets
                //collection
                int indexOfsheetName;

                #region FILE EXISTS
                //Does the file exist for the given path
                if (File.Exists(path))
                {

                    //Yes file exists, so open the file
                    workbook = EXL.Workbooks.Open(path,
                        0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                        true, false, 0, true, false, false);

                    //get the workbook sheets collection
                    sheets = workbook.Sheets;

                    //set the location of the requested sheetName to -1, need to find where
                    //it is. It may not actually exist
                    indexOfsheetName = -1;

                    //loop through the sheets collection
                    for (int i = 1; i <= sheets.Count; i++)
                    {
                        //get the current worksheet at index (i)
                        worksheet = (Worksheet)sheets.get_Item(i);

                        //is the current worksheet the sheetName that was requested
                        if (worksheet.Name.ToString().Equals(sheetName))
                        {
                            //yes it is, so store its index
                            indexOfsheetName = i;

                            //Select all cells, and clear the contents
                            Excel.Range myAllRange = worksheet.Cells;
                            myAllRange.Select();
                            myAllRange.CurrentRegion.Select();
                            myAllRange.ClearContents();
                        }
                    }

                    //At this point it is known that the sheetName that was requested
                    //does not exist within the found file, so create a new sheet within the
                    //sheets collection
                    if (indexOfsheetName == -1)
                    {
                        //Create a new sheet for the requested sheet
                        Worksheet sh = (Worksheet)workbook.Sheets.Add(
                            Type.Missing, (Worksheet)sheets.get_Item(sheets.Count),
                            Type.Missing, Type.Missing);
                        //Change its name to that requested
                        sh.Name = sheetName;
                    }
                }
                #endregion

                #region FILE DOESNT EXIST
                //No the file DOES NOT exist, so create a new file
                else
                {
                    //Add a new workbook to the file
                    workbook = EXL.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    //get the workbook sheets collection
                    sheets = workbook.Sheets;
                    //get the new sheet
                    worksheet = (Worksheet)sheets.get_Item(1);
                    //Change its name to that requested
                    worksheet.Name = sheetName;
                }
                #endregion

                #region get correct worksheet index for requested sheetName

                //get the workbook sheets collection
                sheets = workbook.Sheets;

                //set the location of the requested sheetName to -1, need to find where
                //it is. It will definately exist now as it has just been added
                indexOfsheetName = -1;

                //loop through the sheets collection
                for (int i = 1; i <= sheets.Count; i++)
                {
                    //get the current worksheet at index (i)
                    worksheet = (Worksheet)sheets.get_Item(i);



                    //is the current worksheet the sheetName that was requested
                    if (worksheet.Name.ToString().Equals(sheetName))
                    {
                        //yes it is, so store its index
                        indexOfsheetName = i;
                    }
                }

                //set the worksheet that the DataView should write to, to the known index of the
                //requested sheet
                worksheet = (Worksheet)sheets.get_Item(indexOfsheetName);
                #endregion

                #endregion

                // Set styles 1st
                SetUpStyles();
                //Fill EXCEL worksheet with DataView values
                fillWorksheet_WithDataView();
                //Add the autoshapes to EXCEL
                AddAutoShapesToExcel();
                //Select all used cells within current worksheet
                SelectAllUsedCells();
				/*
                try
                {
                    workbook.Close(true, path, Type.Missing);
                    EXL.UserControl = false;
                    EXL.Quit();
                    EXL = null;
                    //kill the EXCEL process as a safety measure
                    killExcel();
                    // Show that processing is finished
                    ProgressEventArgs pe = new ProgressEventArgs(100);
                    OnProgressChange(pe);
                    MessageBox.Show("Finished adding dataview to Excel", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (COMException cex)
                {
                    MessageBox.Show("User closed Excel manually, so we don't have to do that");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
				*/
				EXL.Visible = true; 
				worksheet = (Worksheet)EXL.ActiveSheet; 
				worksheet.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        #endregion
        
        #region EXCEL : UseTemplate
        //Exports a DataView to Excel. The following steps are carried out
        //in order to export the DataView to Excel
        //Create Excel Objects And Open Template File
        //Select All Used Cells
        //Create Headers/Footers
        //Set Status Finished
        //Save workbook & Tidy up all objects
        //@param path : The path to save/open the EXCEL file to/from
        public void UseTemplate(string path, string templatePath, string[,] myTemplateValues)
        {
            try
            {
                this.myTemplateValues = myTemplateValues;
                //create new EXCEL application
                EXL = new Excel.ApplicationClass();
                //Yes file exists, so open the file
                workbook = EXL.Workbooks.Open(templatePath,
                    0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                    true, false, 0, true, false, false);
                //get the workbook sheets collection
                sheets = workbook.Sheets;
                //get the new sheet
                worksheet = (Worksheet)sheets.get_Item(1);
                //Change its name to that requested
                worksheet.Name = "ATemplate";
                //Fills the Excel Template File Selected With A 2D Test Array
                fillTemplate_WithTestValues();
                //Select all used cells within current worksheet
                SelectAllUsedCells();

                try
                {
                    workbook.Close(true, path, Type.Missing);
                    EXL.UserControl = false;
                    EXL.Quit();
                    EXL = null;
                    //kill the EXCEL process as a safety measure
                    killExcel();
                    // Show that processing is finished
                    ProgressEventArgs pe = new ProgressEventArgs(100);
                    OnProgressChange(pe);
                    MessageBox.Show("Finished adding test values to Template", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (COMException)
                {
                    Console.WriteLine("User closed Excel manually, so we don't have to do that");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        #endregion

        #region STEP 1 : Create Column & Row Workbook Cell Rendering Styles
        //Creates 2 Custom styles for the workbook These styles are
        //  styleColumnHeadings
        //  styleRows
        //These 2 styles are used when filling the individual Excel cells with the
        //DataView values. If the current cell relates to a DataView column heading
        //then the style styleColumnHeadings will be used to render the current cell.
        //If the current cell relates to a DataView row then the style styleRows will
        //be used to render the current cell.
        private void SetUpStyles()
        {

            // Style styleColumnHeadings
            try
            {
                styleColumnHeadings = workbook.Styles["styleColumnHeadings"];
            }
            // Style doesn't exist yet.
            catch
            {
                styleColumnHeadings = workbook.Styles.Add("styleColumnHeadings", Type.Missing);
                styleColumnHeadings.Font.Name = "Arial";
                styleColumnHeadings.Font.Size = 14;
                styleColumnHeadings.Font.Color = (255 << 16) | (255 << 8) | 255;
                styleColumnHeadings.Interior.Color = (0 << 16) | (0 << 8) | 0;
                styleColumnHeadings.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            }

			/*
			"Moneda"	
			"Porcentaje"
			"Fecha"
			"Entero"
			"Decimal"
			*/
            // Style styleRows
			try
			{

				styleRowsMoneda = workbook.Styles["styleRowsMoneda"];
			}
				// Style doesn't exist yet.
			catch
			{
				styleRowsMoneda = workbook.Styles.Add("styleRowsMoneda", Type.Missing);
				styleRowsMoneda.Font.Name = "Arial";
				styleRowsMoneda.Font.Size = 10;
				styleRowsMoneda.Font.Color = (0 << 16) | (0 << 8) | 0;
				styleRowsMoneda.Interior.Color = (192 << 16) | (192 << 8) | 192;
				styleRowsMoneda.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
				styleRowsMoneda.NumberFormat = "mm/dd/AAAA";
			}
			try
			{

				styleRowsFecha = workbook.Styles["styleRowsFecha"];
			}
				// Style doesn't exist yet.
			catch
			{
				styleRowsFecha = workbook.Styles.Add("styleRowsFecha", Type.Missing);
				styleRowsFecha.Font.Name = "Arial";
				styleRowsFecha.Font.Size = 10;
				styleRowsFecha.Font.Color = (0 << 16) | (0 << 8) | 0;
				styleRowsFecha.Interior.Color = (192 << 16) | (192 << 8) | 192;
				styleRowsFecha.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
				styleRowsFecha.NumberFormat = "mm/dd/AAAA";
			}
            try
            {

                styleRows = workbook.Styles["styleRows"];
            }
            // Style doesn't exist yet.
            catch
            {
                styleRows = workbook.Styles.Add("styleRows", Type.Missing);
                styleRows.Font.Name = "Arial";
                styleRows.Font.Size = 10;
                styleRows.Font.Color = (0 << 16) | (0 << 8) | 0;
                styleRows.Interior.Color = (192 << 16) | (192 << 8) | 192;
                styleRows.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            }
        }
        #endregion

        #region STEP 2 : Fill Worksheet With DataView
        //Fills an Excel worksheet with the values contained in the DataView
        //parameter
        private void fillWorksheet_WithDataView()
        {
            position = 0;
            //Add DataView Columns To Worksheet
            int row = 1;
            int col = 1;
            // Loop thought the columns

			this._columnsProperties.Sort();
			ArrayList aux = new ArrayList();
			foreach(PropertiesColumn pc in this._columnsProperties)
            {
				if(pc.Visible)
				{
					aux.Add(pc);
					fillExcelCell(worksheet, row, col++, pc.ColumnCaption, styleColumnHeadings.Name);
				}
            }
			
            //Add DataView Rows To Worksheet
            row = 2;
            col = 1;
			
            for (int i = 0; i < dv.Table.Rows.Count; i++)
            {

                foreach(PropertiesColumn pc in aux)
                {
					string style = string.Empty;
					switch(dv.Table.Columns[pc.ColumnName].DataType.ToString())
					{
						case "System.DateTime": style = styleRowsFecha.Name;break;
						default: style = styleRows.Name; break;

					}
					fillExcelCell(worksheet, row, col++, dv[i][pc.ColumnName].ToString(),style);
					
                }
                col = 1;
                row++;


            }
        }
        #endregion

		public bool ColumnaVisible(string ColumnName)
		{
			bool ok = true;
			foreach(PropertiesColumn pc in this._columnsProperties)
            {
				if(pc.ColumnName.Equals(ColumnName))
					return pc.Visible;
			}
			return ok;
		}

        #region STEP 3 : Fill Individual Cell and Render Using Predefined Style
        //Formats the current cell based on the Style setting parameter name
        //provided here
        //@param worksheet : The worksheet
        //@param row : Current row
        //@param col : Current Column
        //@param Value : The value for the cell
        //@param StyleName : The style name to use
        private void fillExcelCell(Worksheet worksheet, int row, int col, Object Value, string StyleName)
        {
            Range rng = (Range)worksheet.Cells[row, col];
            rng.Select();
            rng.Value2 = Value.ToString();
            rng.Style = StyleName;
            rng.Columns.EntireColumn.AutoFit();
          //  rng.Borders.Weight = XlBorderWeight.xlThin;
            rng.Borders.LineStyle = XlLineStyle.xlContinuous;
            //rng.Borders.ColorIndex = XlColorIndex.xlColorIndexAutomatic;
			
			
        }
        #endregion

        #region STEP 4 : Add Auto Shapes To Excel Worksheet
        //Add some WordArt objecs to the Excel worksheet
        private void AddAutoShapesToExcel()
        {
			/*	
            //Method fields
            float txtSize = 80;
            float Left = 100.0F;
            float Top = 100.0F;
            //Have 2 objects
            int[] numShapes = new int[2];
            Excel.Shape[] myShapes = new Excel.Shape[numShapes.Length];

            try
            {
                //loop through the object count
                for (int i = 0; i < numShapes.Length; i++)
                {

                    //Add the object to Excel
                    myShapes[i] = worksheet.Shapes.AddTextEffect(MsoPresetTextEffect.msoTextEffect1, "DRAFT", "Arial Black",
                        txtSize, MsoTriState.msoFalse, MsoTriState.msoFalse, (Left * (i * 3)), Top);

                    //Manipulate the object settings
                    myShapes[i].Rotation = 45F;
                    myShapes[i].Fill.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                    myShapes[i].Fill.Transparency = 0F;
                    myShapes[i].Line.Weight = 1.75F;
                    myShapes[i].Line.DashStyle = MsoLineDashStyle.msoLineSolid;
                    myShapes[i].Line.Transparency = 0F;
                    myShapes[i].Line.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;
                    myShapes[i].Line.ForeColor.RGB = (0 << 16) | (0 << 8) | 0;
                    myShapes[i].Line.BackColor.RGB = (255 << 16) | (255 << 8) | 255;
                }
            }
            catch (Exception ex)
            {
            }
			*/
        }
        #endregion

        #region STEP 5 : Select All Used Cells
        //Selects all used cells for the Excel worksheet
        private void SelectAllUsedCells()
        {

            Excel.Range myAllRange = worksheet.Cells;
            myAllRange.Select();
            myAllRange.CurrentRegion.Select();

        }
        #endregion

        #region STEP 6 : Fill Template With Test Values
        //Fills the Excel Template File Selected With A 2D Test Array parameter
        private void fillTemplate_WithTestValues()
        {
			//Initilaise the correct Start Row/Column to match the Template
			int StartRow = 3;
			int StartCol = 2;

			position=0;

			// Display the array elements within the Output window, make sure its correct before
			for (int i=0; i <= myTemplateValues.GetUpperBound(0); i++) 
			{
				//loop through array and put into EXCEL template
				for (int j = 0 ; j <= myTemplateValues.GetUpperBound(1) ; j++)
				{
					//update position in progress bar
					position = (100 / myTemplateValues.Length) * i;
                    ProgressEventArgs pe = new ProgressEventArgs(position);
                    OnProgressChange(pe);

					//put into EXCEL template
					Range rng = (Range)worksheet.Cells[StartRow,StartCol++];
					rng.Select();
					rng.Value2 = myTemplateValues[i,j].ToString();
					rng.Rows.EntireRow.AutoFit();
				}
				//New row, so column needs to be reset
				StartCol=2;
				StartRow++;
			}
		}

        #endregion

        #region Kill EXCEL
        //As a safety check go through all processes and make
        //doubly sure excel is shutdown. Working with COM
        //have sometimes noticed that the EXL.Quit() call
        //does always do the job
        private void killExcel()
        {
            try
            {
                System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();
                foreach (System.Diagnostics.Process p in ps)
                {
                    if (p.ProcessName.ToLower().Equals("excel"))
                    {
                        p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }
        #endregion

        #region Events
        /// Raises the OnProgressChange event for the parent form. 
        public virtual void OnProgressChange(ProgressEventArgs e)
        {
            if (prg != null)
            {
                // Invokes the delegates. 
                prg(this, e);
            }
        }
        #endregion
    }
    #endregion
    #region ProgressEventArgs CLASS
    /// Provides the ProgressEventArgs 
    public class ProgressEventArgs : EventArgs
    {
        #region Instance Fields
        //Instance fields
        private int prgValue = 0;
        #endregion

        #region Public Constructor
        /// Constructs a new ProgressEventArgs object using the parameters provided
        /// @param prgValue : new progress value
        public ProgressEventArgs(int prgValue)
        {
            this.prgValue = prgValue;
        }
        #endregion

        #region Public Methods/Properties

        /// Returns the progress value
        public int ProgressValue
        {
            get { return prgValue; }
        }
        #endregion

    }
    #endregion

}
