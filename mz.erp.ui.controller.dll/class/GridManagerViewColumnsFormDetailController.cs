using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de GridManagerViewColumnsFormDetailController.
	/// </summary>
	public class GridManagerViewColumnsFormDetailController: IDetailController
	{
		public GridManagerViewColumnsFormDetailController()
		{
			
		}

		private object _gridLayoutProperties = null;
		#region Miembros de IDetailController

		public void SetObject(object obj)
		{	
			_gridLayoutProperties = obj;
			
		}

		public string GetLayout()
		{
			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "ColumnName", "Columna", true));
			sb.Append( LayoutBuilder.GetRow( i++, "ColumnCaption", "Texto Columna", 100 ,Types.EditType.TextBox));
			sb.Append( LayoutBuilder.GetRow( i++, "Visible", "Visible", 75 ,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		public object RefreshData()
		{
			
			return _gridLayoutProperties;
		}

		public string GetCaption()
		{
			
			return "Seleccione las columnas Visibles";
		}

		#endregion
	}
}
