using System;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	[ AttributeUsage( AttributeTargets.Method ) ]
	public class SearchMember : Attribute
	{
		public SearchMember()
		{
		}

		public SearchMember( string dataSource )
		{
			DataSource = dataSource;

		}

		private string _dataSource = string.Empty;
		public string DataSource
		{
			get
			{
				return _dataSource;
			}
			set
			{
				_dataSource = value;
			}
		}

		private string _caption = string.Empty;
		public string Caption
		{
			get {return _caption;}
			set{_caption = value;}
		}

		private bool  _fastSearch = false;
		public bool FastSearch
		{
			get {return _fastSearch;}
			set{_fastSearch = value;}
		}

		private bool _orderUIAvailable = false;
		public bool OrderUIAvailable
		{
			get
			{
				return _orderUIAvailable;
			}
			set
			{
				_orderUIAvailable = value;
			}
		}
		private string _captionHint = string.Empty;
		public string CaptionHint
		{
			get {return _captionHint;}
			set{_captionHint = value;}
		}
		private string _hint = string.Empty;
		public string Hint
		{
			get {return _hint;}
			set{_hint = value;}
		}
		
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class SearchMemberWithDynamicParameters : Attribute
	{
		public SearchMemberWithDynamicParameters()
		{
		}

		public SearchMemberWithDynamicParameters( string dataSource )
		{
			DataSource = dataSource;

		}

		private string _dataSource = string.Empty;
		public string DataSource
		{
			get
			{
				return _dataSource;
			}
			set
			{
				_dataSource = value;
			}
		}

		private string _caption = string.Empty;
		public string Caption
		{
			get {return _caption;}
			set{_caption = value;}
		}

		private bool  _fastSearch = false;
		public bool FastSearch
		{
			get {return _fastSearch;}
			set{_fastSearch = value;}
		}

		private bool _orderUIAvailable = false;
		public bool OrderUIAvailable
		{
			get
			{
				return _orderUIAvailable;
			}
			set
			{
				_orderUIAvailable = value;
			}
		}
		private string _captionHint = string.Empty;
		public string CaptionHint
		{
			get {return _captionHint;}
			set{_captionHint = value;}
		}
		private string _hint = string.Empty;
		public string Hint
		{
			get {return _hint;}
			set{_hint = value;}
		}
		
	}

	/// <summary>
	/// Modificacion German
	/// Nuevo atributo que se va a usar las clases de el espacio de nonbre ui
	/// para buscar el metodo que no permite hacer busquedas por jararquias.
	/// Este atibuto es leido y procesado por el mzHierarchichalSearchPanel
	/// </summary>

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class HierarchicalSearchMember : Attribute
	{
		public HierarchicalSearchMember()
		{
		}

		public HierarchicalSearchMember( Type treeByDemandType )
		{
			_treeByDemandType = treeByDemandType;

		}
		//Esta propiedad represenat el tipo de aquella clase que tiene el atributo
		//TreeByDemandAttribute en uno de sus metodos
		private Type _treeByDemandType;
		public Type TreeByDemandType
		{
			get
			{
				return _treeByDemandType;
			}
			set
			{
				_treeByDemandType = value;
			}
		}
	}

	public enum SearchEditorType
	{
		Search,
		Standar
	}

	[AttributeUsage( AttributeTargets.Parameter ) ]
	public class SearchEditor : Attribute
	{
		public SearchEditor()
		{
		}

		public SearchEditor( SearchEditorType editorType, Type editorObject)
		{
			EditorType = editorType;
			EditorObject = editorObject;
		}


		private int _orderUI = 0;
		public int OrderUI
		{
			get
			{
				return _orderUI;
			}
			set
			{
				_orderUI = value;
			}
		}

		private SearchEditorType _editorType;
		public SearchEditorType EditorType
		{
			get
			{
				return _editorType;
			}
			set
			{
				_editorType = value;
			}
		}

		private Type _editorObject;
		public Type EditorObject
		{
			get
			{
				return _editorObject;
			}
			set
			{
				_editorObject = value;
			}
		}
	}


	[AttributeUsage( AttributeTargets.Parameter ) ]
	public class SearchParameterInfo : Attribute 
	{

		public SearchParameterInfo( string caption, int maxLength )
		{
			Caption = caption;
			MaxLenght = maxLength;
		}

		public SearchParameterInfo( string caption )
		{
			Caption = caption;
			MaxLenght = 0;
		}
        //Cristian Tarea 0000067 20110401
        private bool _middleSize = false;
        public bool MiddleSize
        {
            get
            {
                return _middleSize;
            }
            set
            {
                _middleSize = value;
            }
        }
        //Fin Cristian 20110401

        /* Silvina 201107228 - Tarea 0000136 */
        private bool _checked = true;
        public bool Checked
        {
            get { return _checked; }
            set { _checked = value; }
        }
        /* Silvina 20110728 - Tarea 0000136 */

		private int _orderUI = 0;
		public int OrderUI
		{
			get
			{
				return _orderUI;
			}
			set
			{
				_orderUI = value;
			}
		}

		private string _caption = string.Empty;
		public string Caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;
			}
		}


		private string _captionVariable = string.Empty;
		public string CaptionVariable
		{
			get
			{
				return _captionVariable;
			}
			set
			{
				_captionVariable = value;
			}
		}

		private int _maxLength = 0;
		public int MaxLenght
		{
			get
			{
				return _maxLength;
			}
			set
			{
				_maxLength = value;
			}
		}

		private bool _isAlternativePrimaryKey = false;
		public bool IsAlternativePrimaryKey
		{
			get
			{
				return _isAlternativePrimaryKey;
			}
			set
			{
				_isAlternativePrimaryKey = value;
			}
		}

		private bool _isSearch = true;
		public bool IsSearch
		{
			get
			{
				return _isSearch;
			}
			set
			{
				_isSearch = value;
			}
		}

		private string _metodo = "";
		public string Metodo
		{
			get
			{
				return _metodo;
			}
			set
			{
				_metodo = value;
			}
		}


		private bool _isDescription = false;
		public bool IsDescription
		{
			get
			{
				return _isDescription;
			}
			set
			{
				_isDescription = value;
			}
		}

		private Type _searchEditor;
		public Type SearchEditor
		{
			get
			{
				return _searchEditor;
			}
			set
			{
				_searchEditor = value;
			}
		}
	}
	
	[AttributeUsage( AttributeTargets.Method )]
	public class atMethodLayoutData: Attribute
	{
	}
	
	[AttributeUsage( AttributeTargets.Method )]
	public class atMethodReportRefreshData: Attribute
	{
	}


	[ AttributeUsage( AttributeTargets.Property) ]
	public class atAllowMultipleRows: Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Property) ]
	public class atHierarchicalSearch: Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Property) ]
	public class atOrderBy: Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Property) ]
	public class atFastSearch: Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Property) ]
	public class atFormatCondition: Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Property) ]
	public class DynamicParameterDefinition: Attribute
	{
	}


    //Matias 20100716 - Tarea 85
    [AttributeUsage(AttributeTargets.Property)]
    public class atOrdenarPor : Attribute
    {
    }
    //Fin Matias 20100716 - Tarea 85

}
