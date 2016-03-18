using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripci�n breve de mzMaskTipoNumeroDoc.
	/// </summary>
	public class mzMaskTipoNumeroDoc : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit1;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdTipoDoc;
		/// <summary> 
		/// Variable del dise�ador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public mzMaskTipoNumeroDoc( Type documentSearchObject)
		{
			// Llamada necesaria para el Dise�ador de formularios Windows.Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicializaci�n despu�s de llamar a InitializeComponent
			_documentSearchObject = documentSearchObject;
			

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

		#region Custom Members
		private Type _documentSearchObject;
		public Type DocumentSearchObject
		{
			get { return _documentSearchObject; }
			set { _documentSearchObject = value; }
		}


		#endregion
		#region C�digo generado por el Dise�ador de componentes
		/// <summary> 
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar 
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			this.mzCmbSrchEdTipoDoc = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraMaskedEdit1 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.SuspendLayout();
			// 
			// mzCmbSrchEdTipoDoc
			// 
			this.mzCmbSrchEdTipoDoc.DataValue = "";
			this.mzCmbSrchEdTipoDoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbSrchEdTipoDoc.Location = new System.Drawing.Point(7, 1);
			this.mzCmbSrchEdTipoDoc.Name = "mzCmbSrchEdTipoDoc";
			this.mzCmbSrchEdTipoDoc.SearchObject = null;
			this.mzCmbSrchEdTipoDoc.Size = new System.Drawing.Size(312, 22);
			this.mzCmbSrchEdTipoDoc.TabIndex = 0;
			// 
			// ultraMaskedEdit1
			// 
			this.ultraMaskedEdit1.Location = new System.Drawing.Point(325, 1);
			this.ultraMaskedEdit1.Name = "ultraMaskedEdit1";
			this.ultraMaskedEdit1.TabIndex = 1;
			this.ultraMaskedEdit1.Text = "ultraMaskedEdit1";
			// 
			// mzMaskTipoNumeroDoc
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.ultraMaskedEdit1);
			this.Controls.Add(this.mzCmbSrchEdTipoDoc);
			this.Name = "mzMaskTipoNumeroDoc";
			this.Size = new System.Drawing.Size(432, 24);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
