using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using mz.erp.ui.controls.forms;

namespace mz.erp.ui.controls
{
	public class mzComboEditor : Infragistics.Win.UltraWinEditors.UltraComboEditor
	{
		private System.ComponentModel.Container components = null;
		private string _moreItemsDisplayText = "(Ver mas elementos...)";
		private string _moreItemsID = "abe97a2e-5d21-4f14-b4ca-03962ff47554";
		private DataTable _dataSource;
		private int _maxItemsDisplay = 200;
		private string _displayMember = string.Empty;
		private string _displayMemberCaption = string.Empty;
		private string _valueMember = string.Empty;
		private string _valueMemberCaption = string.Empty;
		private string _sorterMember = string.Empty;
		private string _filterMember = string.Empty;
		private bool _initializing = false;

		

		public mzComboEditor()
		{
			InitializeComponent();

		}

		#region Dispose
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Código generado por el Diseñador de componentes
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			this.DropDownStyle = DropDownStyle.DropDownList;
		}
		#endregion

		public void SetValue( object setValue )
		{
			int index = IndexOf( setValue );
			if ( index == -1 )
			{
				
				DataView dv = new DataView( _dataSource, string.Format( "{0} = '{1}'", _valueMember, setValue ), _sorterMember, DataViewRowState.OriginalRows );
				if ( dv.Count == 1 )
				{
					ValueListItem item = new ValueListItem();
					item.DataValue = dv[ 0 ][ _valueMember ];
					item.DisplayText = dv[ 0 ][ _displayMember ].ToString();
					
					Items.Insert( 0, item );
					SelectedIndex = 0;
					
				}
				else
				{
					throw new Exception( "El valor que ha intentado asignar corresponde a varias filas del conjunto de datos." );
				}
			}
			else
			{
				SelectedIndex = index;
			}

		}

		protected override void OnValueChanged( object sender, EventArgs args )
		{
			if(SelectedItem != null)
			{
				if ( SelectedItem.DataValue is string && ( string )SelectedItem.DataValue == _moreItemsID )
				{
					mzComboEditorSearch f = new mzComboEditorSearch( DisplayMember, DisplayMemberCaption, ValueMember, ValueMemberCaption, DataSource );
					if ( f.ShowDialog() == DialogResult.OK )
					{
						int index = IndexOf( f.SelectedValue() );
						if ( index == -1 )
						{
							ValueListItem item = new ValueListItem();
							item.DataValue = f.SelectedValue();
							item.DisplayText = f.SelectedText();
							item.Appearance.FontData.Bold = DefaultableBoolean.True;

							Items.Insert( 0, item );
							SelectedIndex = 0;
							
						}
						else
						{
							SelectedIndex = index;
						}
					}
				}
				else
				{
					base.OnValueChanged( sender, args );
				}
			}
		}

		public void FillFromDataSource( DataTable dataSource, string valueMember, string displayMember, int maxItemsDisplay, string valueMemberCaption, string displayMemberCaption, string sorterMember )
		{
			FillFromDataSource( dataSource, valueMember, displayMember, maxItemsDisplay, sorterMember );
			ValueMemberCaption = valueMemberCaption;
			DisplayMemberCaption = displayMemberCaption; 
		}

		public void FillFromDataSource( DataTable dataSource, string valueMember, string displayMember, int maxItemsDisplay, string valueMemberCaption, string displayMemberCaption, string sorterMember , string filterMember)
		{
			_filterMember = filterMember;
			FillFromDataSource( dataSource, valueMember, displayMember, maxItemsDisplay, valueMemberCaption,displayMemberCaption, sorterMember );
		}

		public void FillFromDataSource( DataTable dataSource, string valueMember, string displayMember, int maxItemsDisplay, string sorterMember )
		{
			if ( _initializing ) return;

			_initializing = true;

			DataSource = dataSource;
			ValueMember = valueMember;
			DisplayMember = displayMember;
			MaxItemsDisplay = maxItemsDisplay;
			SorterMember = sorterMember;

			_initializing = false;
			
			FillFromDataSource();
		}

		private int IndexOf( object item )
		{
			for( int i = 0; i<= Items.Count - 1; i++ )
			{
				if ( Items[ i ].DataValue.Equals( item ) )
				{
					return i;
				}
			}

			return -1;
		}

		private void FillFromDataSource()
		{
			this.AutoComplete = true;
			if ( _dataSource != null && _displayMember != string.Empty && _valueMember != string.Empty )
			{
				Items.Clear();

				DataView dv = new DataView( _dataSource, _filterMember, _sorterMember, DataViewRowState.CurrentRows );

				int count = dv.Count;
				if(count <= _maxItemsDisplay)
					count = _maxItemsDisplay ;
				foreach( DataRowView dr in dv )
				{
					if ( Items.Count < count - 1 )
					{
						Items.Add( dr[ _valueMember ], dr[ _displayMember ].ToString() );
					}
					else
					{
						ValueListItem item = Items.Add( _moreItemsID, _moreItemsDisplayText );
						item.Appearance.FontData.Bold = DefaultableBoolean.True;
					
						return;
					}
				}
			}
		}

		public int MaxItemsDisplay
		{
			get
			{
				return _maxItemsDisplay;
			}
			set
			{
				_maxItemsDisplay = value;
				FillFromDataSource();
			}
		}

		public string MoreItemsDisplayText
		{
			get
			{
				return _moreItemsDisplayText;
			}
			set
			{
				_moreItemsDisplayText = value;
				FillFromDataSource();
			}
		}

		public DataTable DataSource
		{
			get
			{
				return _dataSource;
			}
			set
			{
				_dataSource = value;
				FillFromDataSource();
			}
		}

		public string DisplayMember
		{
			get
			{
				return _displayMember;
			}
			set
			{
				_displayMember = value;
				if ( _displayMemberCaption == string.Empty )
				{
					_displayMemberCaption = _displayMember;
				}
				FillFromDataSource();
			}
		}



		public string ValueMember
		{
			get
			{
				return _valueMember;
			}
			set
			{
				_valueMember = value;
				if ( _valueMemberCaption == string.Empty )
				{
					_valueMemberCaption = _valueMember;
				}
				FillFromDataSource();
			}

		}

		public string DisplayMemberCaption
		{
			get
			{
				return _displayMemberCaption;
			}
			set
			{
				_displayMemberCaption = value;
			}
		}

		public string ValueMemberCaption
		{
			get
			{
				return _valueMemberCaption;
			}
			set
			{
				_valueMemberCaption = value;
			}
		}

		public string SorterMember
		{
			get
			{
				return _sorterMember;
			}
			set
			{
				_sorterMember = value;
				FillFromDataSource();
				
			}
		}
	}
}
