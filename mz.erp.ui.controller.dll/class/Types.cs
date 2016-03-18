using System;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de Types.
	/// </summary>
	public  class Types
	{
		public Types()
		{
			//
			// TODO: agregar aquí la lógica del constructor
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
