using System;
using System.Windows.Forms;
using System.Reflection;

namespace mz.erp.ui.controllers
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
        //Cristian Tarea  0000032 20110401
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
