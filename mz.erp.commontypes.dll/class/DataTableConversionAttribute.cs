
using System; 


namespace mz.erp.commontypes
{
   
	[AttributeUsage(AttributeTargets.Property)]
	public class DataTableConversionAttribute : Attribute
	{
		private bool _dataTableConversion;
		private bool _allowDbNull;
		private bool _keyField; 
		public DataTableConversionAttribute() { } 
		public bool DataTableConversion
		{
			get { return _dataTableConversion; }
			set { _dataTableConversion = value; }
		} 
		public bool AllowDbNull
		{
			get { return _allowDbNull; }
			set { _allowDbNull = value; }
		} 
		public bool KeyField
		{
			get { return _keyField; }
			set { _keyField = value; }
		}
	}
}