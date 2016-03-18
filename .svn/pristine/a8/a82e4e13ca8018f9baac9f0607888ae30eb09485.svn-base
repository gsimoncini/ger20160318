using System;
using System.Windows.Forms;
using System.Reflection;

namespace mz.erp.ui.controls
{
	public class Parameter
	{
		public Parameter()
		{
		}

		public Parameter( string name, ParameterInfo info )
		{
			Name = name;
			Caption = name;
			Info = info;
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

		private string _name;
		public string Name
		{
			get{ return _name; }
			set{ _name = value; }
		}

		private string _caption;
		public string Caption
		{
			get{ return _caption; }
			set{ _caption = value; }
		}

		private int _maxLenght = 0;
		public int MaxLenght
		{
			get{ return _maxLenght; }
			set{ _maxLenght = value; }
		}

		private ParameterInfo _info;
		public ParameterInfo Info
		{
			get{ return _info; }
			set{ _info = value; }
		}

		private bool _isAlternativePrimaryKey = false;
		public bool IsAlternativePrimaryKey
		{
			get{ return _isAlternativePrimaryKey; }
			set{ _isAlternativePrimaryKey = value; }
		}

		private bool _isSearch = true;
		public bool IsSearch
		{
			get{ return _isSearch; }
			set{ _isSearch = value; }
		}

		private bool _isDescription = false;
		public bool IsDescription
		{
			get{ return _isDescription; }
			set{ _isDescription = value; }
		}

		private string _metodo = "";
		public string Metodo
		{
			get{ return _metodo; }
			set{ _metodo = value; }
		}


		private string _text;
		public string Text
		{
			get{ return _text; }
			set{ _text = value; }
		}

		private object _value;
		public object Value
		{
			get{ return _value;	}
			set{ _value = value; }
		}

		private int _index = 0;
		public int Index
		{
			get{ return _index; }
			set{ _index = value; }
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

		private Control _inputControl;
		public Control InputControl
		{
			get
			{
				return _inputControl;
			}
			set
			{
				_inputControl = value;
			}
		}
	}
}
