using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripci�n breve de GridManagerLayout.
	/// </summary>
	public class GridManagerLayout : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Variable del dise�ador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridManagerLayout()
		{
			// Llamada necesaria para el Dise�ador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    

			// TODO: agregar cualquier inicializaci�n despu�s de llamar a InitializeComponent

		}

		/// <summary> 
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
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

		#region C�digo generado por el Dise�ador de componentes
		/// <summary> 
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar 
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
