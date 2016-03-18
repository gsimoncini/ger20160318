using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de ReportParameterControlType.
	/// </summary>
	public class ReportParameterControlType
	{
		public ReportParameterControlType()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private string _controlType;
		private string _searchObject;
		private string _primaryKey;
		private string _description;
		private string _range;
		private string _labelText;
		private string _uiType;



		public string UIType
		{	
			get{return _uiType;}
			set{_uiType = value;}

		}
		public string LabelText
		{
			get{return _labelText;}
			set{_labelText = value;}

		}
		
		public string ControlType
		{
			get{return _controlType;}
			set{_controlType = value;}
		}

		public string SearchObject
		{
			get{return _searchObject;}
			set{_searchObject = value;}
		}

		public string PrimaryKey
		{
			get{return _primaryKey;}
			set{_primaryKey = value;}
		}

		public string Description
		{
			get{return _description;}
			set{_description = value;}
		}
		public string Range
		{
			set{_description = value;}
			get{ return _description;}
		}


	}
}
