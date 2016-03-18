using System;
using System.Reflection;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de ValueListGridAttributes.
	/// </summary>
	/// 
	[ AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class ValueListGridAttributes:Attribute
	{
		public ValueListGridAttributes(string Columna)
		{
			
		}
		
		public ValueListGridAttributes(string Columna, Type SearchClass, string IdFieldName, string DescrptionFieldName)
		{
			_columnName = Columna;
			_searchClass = SearchClass;
			_idFieldName = IdFieldName;
			_descriptionFieldName = DescrptionFieldName;
			
		}

		private string _columnName;
		public string ColumnName
		{
			get{return _columnName;}
			set {_columnName = value;}

		}
		private Type _searchClass;
		public Type SearchClass
		{
			get{return _searchClass;}
			set{_searchClass = value;}
		}

		private string _idFieldName;
		public string IdFieldName
		{
			get{return _idFieldName;}
			set{_idFieldName = value;}
		}

		private string _descriptionFieldName;
		public string DescriptionFieldName
		{
			get{return _descriptionFieldName;}
			set{_descriptionFieldName = value;}

		}


	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class ValueListGridMember:Attribute
	{
	}

}
