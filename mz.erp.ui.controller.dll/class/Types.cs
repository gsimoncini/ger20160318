using System;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripci�n breve de Types.
	/// </summary>
	public  class Types
	{
		public Types()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}
		public enum Aligment
		{
			Near,
			Center,
			Far
		}
		public enum FormatDisplay
		{
			Money,
			Percent,
			Default,
			DateTime,
			DateTimeShort,
			Integer,
			LongMoney
		}

		public enum ColumnTypes
		{
			CheckBox,
			Text, 
			Image,
			ImageAndText
		}

		//Agregar mas
		public enum EditType
		{
			NoEdit,
			CheckBox,
			CalendarCombo,
			CalendarDropDown,
			Combo,
			TextBox,
			Custom
		}
	}
}
