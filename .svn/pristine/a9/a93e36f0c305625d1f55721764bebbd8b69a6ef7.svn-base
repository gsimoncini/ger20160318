using System;
using System.Windows.Forms;
using System.Collections;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ControlManager.
	/// </summary>
	public class ControlManager
	{
		public ControlManager()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void OrganizeFilters(System.Windows.Forms.Control.ControlCollection controles, string ListaFiltros)
		{
			foreach (Control control in controles)
			{
				control.Visible = false;
			}			
			
			int LocationY = 5;
			int separacion = 22;
			
			ArrayList arrFiltros = systemframework.Util.Parse(ListaFiltros);
			foreach (string filtro in arrFiltros)
			{
				foreach (System.Windows.Forms.Control control in controles)
				{
					if (control.Tag.Equals(filtro))
					{
						control.Visible = true;
						control.Location = new System.Drawing.Point(control.Location.X, LocationY);						
					}
				}
				LocationY = LocationY + separacion;
			}
			_height = LocationY;
		}
		#region Propiedades
		private int _height;
		public int Height 
		{
			get 
			{
				return _height;
			}
		}

		#endregion
	}	
}
