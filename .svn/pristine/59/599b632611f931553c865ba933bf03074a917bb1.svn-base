using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfigurarLayoutGrillasController.
	/// </summary>
	public class ConfigurarLayoutGrillasController: ITaskController
	{
		public ConfigurarLayoutGrillasController(ConfigurarLayoutGrillas BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		private ConfigurarLayoutGrillas _brClass = null;
		private string _layoutSPTable = string.Empty;
		private string _layoutColumnsProperties = string.Empty;		


		#region Eventos y delegados
		public event System.EventHandler ColumnsHasChanged;
		public event System.EventHandler SelectedItemChanged;
		public event System.EventHandler ObjectHasChanged;
		
		public event System.EventHandler ColumnOrdenChanged;
		public event System.EventHandler ColumnCaptionChanged;
		public event System.EventHandler ColumnWidthChanged;
		public event System.EventHandler ColumnAlignmentChanged;
		public event System.EventHandler ColumnEditTypeChanged;
		public event System.EventHandler ColumnTypeChanged;
		public event System.EventHandler ColumnFormatChanged;
		public event System.EventHandler ColumnWordWrapChanged;
		public event System.EventHandler ColumnMaxLinesChanged;
		public event System.EventHandler ColumnVisibleChanged;

		public event EventHandler IdProcesoChanged;
		public event EventHandler IdTareaChanged;	
		public event EventHandler IdPerfilChanged;	
		public event EventHandler ProcesoHasChanged;

		#endregion


		#region Variables públicas		
		#endregion

		#region Propiedades


		/*public string IdProceso 
		{
			get 
			{
				return _brClass.IdProceso;
			}
			set 
			{
				_brClass.IdProceso = value;
			}			
		}*/

		/*public string IdTarea 
		{
			get 
			{
				return _brClass.IdTarea;
			}
			set 
			{
				_brClass.IdTarea = value;
			}
		}*/

		public string GridName 
		{
			get 
			{
				return _brClass.GridName;
			}
			set 
			{
				_brClass.GridName = value;
			}
		}


		public bool ColumnVisible
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Visible;
				else return true;
			}
			set
			{
				if(_brClass.SelectedItem != null)
					((PropertiesColumn)_brClass.SelectedItem).Visible =  value;
			}
		}
		
		
		public int ColumnOrder
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Order;
				else return 0;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).Order =  value;
				}
			}
		}
		public string ColumnCaption
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).ColumnCaption;
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).ColumnCaption =  value;
				}
			}
		}

		public string ColumnWidth
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Width.ToString();
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					try 
					{
						((PropertiesColumn)_brClass.SelectedItem).Width =  Convert.ToDecimal(value);
					}
					catch
					{
						((PropertiesColumn)_brClass.SelectedItem).Width =  0;
					}					
				}
			}
		}
		
		public string ColumnAlignment
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Alignment;
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).Alignment =  value;
				}
			}
		}
		public string ColumnFormat
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Format;
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).Format =  value;
				}
			}
		}
		public string ColumnType
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).Type;
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).Type =  value;
				}
			}
		}
		public string ColumnEditType
		{
			get
			{
				if(_brClass.SelectedItem != null)
					return ((PropertiesColumn)_brClass.SelectedItem).EditType;
				else return string.Empty;
			}
			set
			{
				if(_brClass.SelectedItem != null)
				{
					((PropertiesColumn)_brClass.SelectedItem).EditType =  value;
				}
			}
		}

		public PropertiesColumnsCollection ColumnsProperties 
		{ 
			get 
			{
				return _brClass.ColumnsProperties;
			}
		}
		
		public object SelectedItem
		{
			set{_brClass.SelectedItem = value;}
		}

		

		public DataTable SPTable
		{
			get{return _brClass.SPTable;}
		}

		public string LayoutSPTable
		{
			get{return _layoutSPTable;}
		}
		public string LayoutColumnsProperties
		{
			get{return _layoutColumnsProperties;}
		}
		

		public ArrayList Columns 
		{
			get 
			{
				return _brClass.Columns;
			}			
		}
		public int SetIndex 
		{
			get 
			{
				return _brClass.SetIndex;
			}
		}

		private string _idProceso = string.Empty;
		public object IdProceso
		{
			get { return _brClass.IdProceso ; }
			set		
			{ 
				if (value != null) //&& _brClass.IdProceso.CompareTo( value ) != 0)
				{
					_idProceso = Convert.ToString(value);
					_brClass.IdProceso = Convert.ToString(value) ; 					
					if (this.IdProcesoChanged != null)
						IdProcesoChanged (this, new EventArgs());
				}
				else if(value == null && _idProceso != string.Empty)
				{
					_idProceso = string.Empty;
					_brClass.IdProceso = string.Empty; 
				}
			}
		}		
		private string _idTarea = string.Empty;
		public object IdTarea
		{
			get { return _brClass.IdTarea ; }
			set 
			{ 
				if (value != null  && !_brClass.IdTarea.Equals( value ))
				{
					_idTarea = Convert.ToString(value);
					_brClass.IdTarea = Convert.ToString(value) ; 
					if (this.IdTareaChanged != null)
						IdTareaChanged (this, new EventArgs());
				}
				else if(value == null && _idTarea != string.Empty)
				{
					_idTarea = string.Empty;
					_brClass.IdTarea = string.Empty; 
				}
			}
		}
		private long _idPerfil = long.MinValue;
		public long IdPerfil
		{
			get 
			{
				return _brClass.IdPerfil;
			}
			set 
			{
				/*if (value != null)
					_brClass.IdPerfil = value;				*/
				if (value != -1) //&& _brClass.IdProceso.CompareTo( value ) != 0)
				{					
					_idPerfil = value;
					_brClass.IdPerfil = value; 					
					if (this.IdPerfilChanged != null)
						IdPerfilChanged (this, new EventArgs());
				}
				else if(value.Equals(-1))
				{
					_idPerfil = -1;
					_brClass.IdPerfil = -1; 
				}
					
			}
		}

		public System.Data.DataTable Procesos
		{
			get {return _brClass.Procesos;}
		}
		public System.Data.DataTable Tareas
		{
			get {return _brClass.Tareas;}
		}
		public System.Data.DataTable Perfiles
		{
			get {return _brClass.Perfiles;}
		}		
		public string KeyValueProcesos
		{
			get { return "IdProceso" ; }
		}
		public string KeyListProcesos
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueTareas
		{
			get { return "IdTarea" ; }
		}
		public string KeyListTareas
		{
			get { return "DescripcionTarea" ; }
		}
		public string KeyValuePerfiles
		{
			get { return "IdPerfil" ; }
		}
		public string KeyListPerfiles
		{
			get { return "Descripcion" ; }
		}	
		
		public bool Merge
		{
			get{return _brClass.Merge;}
			set{_brClass.Merge = value;}
		}

		private bool _visibleDefault = true;
		public bool VisibleDefault 
		{
			get 
			{
				return _brClass.VisibleDefault;
			}			
			set 
			{
				_brClass.VisibleDefault = value;
			}
		}
		#endregion

		#region Metodos Privados
			
		private void Init()
		{
			_layoutSPTable = this.GetLayoutSPTable();
			_layoutColumnsProperties = this.GetLayoutColumnsProperties();
			InitEvents();
		}

		private void InitEvents()
		{
			this._brClass.ColumnsHasChanged+=new EventHandler(_brClass_ColumnsHasChanged);	
			this._brClass.SelectedItemChanged +=new EventHandler(_brClass_SelectedItemChanged);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);

			this._brClass.ProcesoHasChanged +=new EventHandler(_brClass_ProcesoHasChanged);
			this._brClass.TareaHasChanged+=new EventHandler(_brClass_TareaHasChanged);
		}


		private void _brClass_ColumnsHasChanged(object sender, EventArgs e)
		{
			if (this.ColumnsHasChanged != null)
			{
				ColumnsHasChanged( this, new System.EventArgs() );
			}
		}

		private string GetLayoutSPTable()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "name", "SP",300) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();
		}
		private string GetLayoutColumnsProperties()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "order", "Order",40) );
			//sb.Append( LayoutBuilder.GetRow( i++, "visible", "Visible",40) );
			sb.Append( LayoutBuilder.GetRow( i++, "visible", "Visible",40,false, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
			//LayoutBuilder.GetRow( i++, columna, columna,75, true, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox
			sb.Append( LayoutBuilder.GetRow( i++, "ColumnName", "Name",150) );			
			sb.Append( LayoutBuilder.GetRow( i++, "ColumnCaption", "Caption",150) );			
			sb.Append( LayoutBuilder.GetRow( i++, "width", "Width",40) );
			sb.Append( LayoutBuilder.GetRow( i++, "alignment", "Alignment",120) );
			sb.Append( LayoutBuilder.GetRow( i++, "format", "Format",120) );			
			sb.Append( LayoutBuilder.GetRow( i++, "type", "Type",120) );
			sb.Append( LayoutBuilder.GetRow( i++, "editType", "EditType",120) );


			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();
		}
		
		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}
		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}


		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}


		#endregion


		
		#region Metodos Publicos


		public ArrayList SearchColumnsProperties()
		{
			return _brClass.SearchColumnsProperties();

		}

		public ArrayList GetSPParameters(string SPName)
		{
			return _brClass.GetSPParameters(SPName);
		}
		public ArrayList GetSPColumns(string SPName)
		{
			return _brClass.GetSPColumns(SPName);
		}			 
		public void Arriba (int index)
		{
			_brClass.Arriba(index);
		}
		public void Abajo (int index)
		{
			_brClass.Abajo(index);
		}


		#endregion

		private void _brClass_SelectedItemChanged(object sender, EventArgs e)
		{
			if(SelectedItemChanged != null)
			{
				SelectedItemChanged(this, new EventArgs());
			}
			if(ColumnCaptionChanged != null)
			{
				ColumnCaptionChanged(this, new EventArgs());
			}
			if(ColumnVisibleChanged != null)
			{
				ColumnVisibleChanged(this, new EventArgs());
			}
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
		}
		private void _brClass_ProcesoHasChanged(object sender, EventArgs e)
		{
			if(ProcesoHasChanged != null)
				ProcesoHasChanged(this, new EventArgs());
		}
		private void _brClass_TareaHasChanged(object sender, EventArgs e)
		{
			_idTarea = _brClass.IdTarea;
			if(ProcesoHasChanged != null)
				ProcesoHasChanged(this, new EventArgs());
		}
	}
}

