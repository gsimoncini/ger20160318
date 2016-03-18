using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	public class FrmAbmSucursales : mz.erp.ui.forms.FrmAMB
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneCargoFijoProductos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacionRecargoProductos;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtDireccion;
		private mz.erp.ui.controls.mzComboEditor mzComboEditor1;
		private System.ComponentModel.IContainer components = null;

		public FrmAbmSucursales()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneBonificacionRecargoProductos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.uneCargoFijoProductos = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.mzComboEditor1 = new mz.erp.ui.controls.mzComboEditor();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionRecargoProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCargoFijoProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditor1)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 101;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Parámetros Especiales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDireccion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 103);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneBonificacionRecargoProductos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneCargoFijoProductos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 211);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(871, 101);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// uneBonificacionRecargoProductos
			// 
			this.uneBonificacionRecargoProductos.Location = new System.Drawing.Point(139, 43);
			this.uneBonificacionRecargoProductos.MaskInput = "nnn,nn";
			this.uneBonificacionRecargoProductos.MaxValue = 100;
			this.uneBonificacionRecargoProductos.MinValue = -100;
			this.uneBonificacionRecargoProductos.Name = "uneBonificacionRecargoProductos";
			this.uneBonificacionRecargoProductos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonificacionRecargoProductos.Size = new System.Drawing.Size(100, 21);
			this.uneBonificacionRecargoProductos.TabIndex = 45;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(28, 48);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(101, 39);
			this.ultraLabel4.TabIndex = 44;
			this.ultraLabel4.Text = "Bonificación o Recargo Aplicado a Productos";
			// 
			// uneCargoFijoProductos
			// 
			this.uneCargoFijoProductos.Location = new System.Drawing.Point(140, 6);
			this.uneCargoFijoProductos.Name = "uneCargoFijoProductos";
			this.uneCargoFijoProductos.Size = new System.Drawing.Size(100, 21);
			this.uneCargoFijoProductos.TabIndex = 43;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(28, 8);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(105, 32);
			this.ultraLabel3.TabIndex = 42;
			this.ultraLabel3.Text = "Cargo Fijo Aplicado a Productos";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(32, 9);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel5.TabIndex = 37;
			this.ultraLabel5.Text = "Nombre";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(144, 8);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
			this.txtDescripcion.TabIndex = 36;
			this.txtDescripcion.Text = "txtDescripcion";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(32, 33);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel1.TabIndex = 39;
			this.ultraLabel1.Text = "Dirección";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(144, 32);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(272, 20);
			this.txtDireccion.TabIndex = 38;
			this.txtDireccion.Text = "txtDireccion";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(32, 59);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel2.TabIndex = 41;
			this.ultraLabel2.Text = "Localidad";
			// 
			// mzComboEditor1
			// 
			this.mzComboEditor1.DataSource = null;
			this.mzComboEditor1.DisplayMember = "";
			this.mzComboEditor1.DisplayMemberCaption = "";
			this.mzComboEditor1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditor1.Location = new System.Drawing.Point(144, 56);
			this.mzComboEditor1.MaxItemsDisplay = 7;
			this.mzComboEditor1.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditor1.Name = "mzComboEditor1";
			this.mzComboEditor1.SorterMember = "";
			this.mzComboEditor1.TabIndex = 42;
			this.mzComboEditor1.ValueMember = "";
			this.mzComboEditor1.ValueMemberCaption = "";
			// 
			// FrmAbmSucursales
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Name = "FrmAbmSucursales";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionRecargoProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCargoFijoProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditor1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.sy_Sucursales().GetType();
			base.Init();
		}

		protected override void InitializeMembers()
		{
			txtDescripcion.MaxLength = 50;
			//txtIdResponsable.MaxLength = 20;
			txtDireccion.MaxLength = 100;
			mzComboEditor1.FillFromDataSource( businessrules.tsh_Localidades.GetList().tsh_Localidades, "IdLocalidad", "Descripcion", 8, "ID", "Descripcion", "Descripcion" );
		}

		protected override void FillControls()
		{
			if (_row != null)
			{
				txtDescripcion.Text = ( string )_row["Descripcion"];
				//txtIdResponsable.Text = ( string )_row["IdResponsable"];
				txtDireccion.Text = ( string )_row["Direccion"];
				//mzComboSearchLocalidad.DataValue = ( string )_row["IdLocalidad"];
				uneCargoFijoProductos.Value = ( decimal )_row["CargoFijoProductos"];
				uneBonificacionRecargoProductos.Value = ( decimal )_row["BonificacionRecargoProductos"];
			}
		}

		protected override void DumpControls()
		{
			_row["Descripcion"] = txtDescripcion.Text;
			//_row["IdResponsable"] = txtIdResponsable.Text;
			_row["Direccion"] = txtDireccion.Text;
			_row["IdLocalidad"] = mzComboEditor1.Value;
			_row["CargoFijoProductos"] = uneCargoFijoProductos.Value;
			_row["BonificacionRecargoProductos"] = uneBonificacionRecargoProductos.Value;
		}
	
		#endregion		
				
	}
}

