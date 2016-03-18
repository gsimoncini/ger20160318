using System;
using System.Collections;

namespace mz.erp.ui.controls
{
	public class LayoutBuilder
	{
		public LayoutBuilder()
		{
		
		}

		public static string GetRow( int position, string fieldName, string caption )
		{
			return string.Format( @"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Position>{0}</Position></Column{0}>", position, fieldName, caption );
		}

		public static string GetRow( int position, string fieldName, string caption, int width )
		{
			return string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position></Column{0}>",new object[] {position, fieldName, caption, width}); 
		}

		public static string GetRow( int position, string fieldName, string caption, bool hidden )
		{
			return string.Format( @"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Position>{0}</Position><Visible>{3}</Visible></Column{0}>", position, fieldName, caption, !hidden );
		}

		public static string GetRow( int position, string fieldName, string caption, int width, bool hidden )
		{
			return string.Format( @"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Position>{0}</Position><Width>{3}</Width><Visible>{4}</Visible></Column{0}>", position, fieldName, caption, width, !hidden);
		}
		
		public static string GetRow( int position, string fieldName, string caption, int width, Types.Aligment aligment,Types.FormatDisplay format )		
		{
			return GetRow( position, fieldName, caption, width, aligment,format, null );
		}
		public static string GetRow( int position, string fieldName, string caption, int width, Types.Aligment aligment,Types.FormatDisplay format, string literalstring )
		{
			switch (format)
			{
				case Types.FormatDisplay.LongMoney :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>c</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Money :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>0.00</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Percent:
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>p</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Integer:
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>0</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 
					break;
				}
		
				default :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 
					break;
				}
			}
		}

		public static string GetRow( int position, string fieldName, string caption, int width , Types.ColumnTypes ct)
		{
			return string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><ColumnType>{4}</ColumnType><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position></Column{0}>",new object[] {position, fieldName, caption, width,ct.ToString()}); 
		}

		public static string GetRow( int position, string fieldName, string caption, int width , Types.EditType et)
		{
			return string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><EditType>{4}</EditType><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position></Column{0}>",new object[] {position, fieldName, caption, width,et.ToString()}); 
		}

		public static string GetRow( int position, string fieldName, string caption, int width, bool hidden, Types.ColumnTypes ct, Types.EditType et)
		{
			return string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><EditType>{4}</EditType><ColumnType>{5}</ColumnType><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><Visible>{6}</Visible></Column{0}>",new object[] {position, fieldName, caption, width,ct.ToString(),et.ToString(),!hidden}); 
		}

		public static string GetRow( int position, string fieldName, string caption, int width , Types.ColumnTypes ct, Types.EditType et)
		{
			return string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><ColumnType>{4}</ColumnType><EditType>{5}</EditType><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position></Column{0}>",new object[] {position, fieldName, caption, width,ct.ToString(),et.ToString()}); 
		}

		public static string GetRow( int position, string fieldName, string caption, int width, Types.Aligment aligment)		{								
			return
			string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString()}); 					
		}	
		
		public static string GetRow( int position, string fieldName, string caption, int width, Types.Aligment aligment,Types.FormatDisplay format ,Types.EditType et)
		{
			switch (format)
			{
				case Types.FormatDisplay.LongMoney :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><EditType>{5}</EditType><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>c</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Money :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><EditType>{5}</EditType><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment>
						</CellStyle><FormatString>0.00</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Percent:
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment><EditType>{5}</EditType>
						</CellStyle><FormatString>p</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
				case Types.FormatDisplay.Integer:
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position>
						<CellStyle>
						<TextAlignment>{4}</TextAlignment><EditType>{5}</EditType></CellStyle><FormatString>0</FormatString></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
				case Types.FormatDisplay.DateTime:
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><TextAlignment>{4}</TextAlignment><EditType>{5}</EditType><FormatString>d</FormatString></Column{0}>",
						new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
				default :
				{
					return
						string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position><CellStyle>
						<TextAlignment>{4}</TextAlignment><EditType>{5}</EditType>
						</CellStyle></Column{0}>",new object[] {position, fieldName, caption, width,aligment.ToString(),et.ToString()}); 
					break;
				}
			}
		}

		public static string GetRowWordWrap( int position, string fieldName, string caption, int width, int lines )
		{
			return string.Format( @"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Position>{0}</Position><Width>{3}</Width><MaxLines>{4}</MaxLines><WordWrap>True</WordWrap><Visible>True</Visible></Column{0}>", position, fieldName, caption, width, lines );
		}
		public static string GetHeader()
		{
			return @"<GridEXLayoutData> <HeaderFormatStyle><FontBold>True</FontBold><PredefinedStyle>HeaderFormatStyle</PredefinedStyle><TextAlignment>Center</TextAlignment>
    </HeaderFormatStyle> <RootTable><Columns Collection=""true"">";
		}

		public static string GetFooter()
		{
			return @"</Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>";
		}


		public static string GetRowWordWrap( int position, string fieldName, string caption, int width, int lines, Types.EditType et )
		{
			return string.Format( @"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><Key>{1}</Key><Position>{0}</Position><Width>{3}</Width><EditType>{5}</EditType><MaxLines>{4}</MaxLines><WordWrap>True</WordWrap><Visible>True</Visible></Column{0}>", position, fieldName, caption, width, lines,et.ToString() );
		}

		public static string GetRowCombo( int position, string fieldName, string caption, int width, bool hasValueList)
		{
			return
				string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><EditType>Combo</EditType><HasValueList>{4}</HasValueList><Key>{1}</Key><Width>{3}</Width><Position>{0}</Position>
				</Column{0}>",new object[] {position, fieldName, caption, width, hasValueList.ToString()}); 
		}

		public static string GetRowCombo2( int position, string fieldName, string caption, int width, bool hasValueList, CollectionBase items)
		{
			return
				string.Format(@"<Column{0} ID=""{1}""><Caption>{2}</Caption><DataMember>{1}</DataMember><EditType>Combo</EditType><HasValueList>{4}</HasValueList>
				<ValueList><PopulateValueList>{5}</PopulateValueList></ValueList>
				<Key>{1}</Key><Width>{3}</Width><Position>{0}</Position>
				</Column{0}>",new object[] {position, fieldName, caption, width, hasValueList.ToString()}); 
		}


	}
}





