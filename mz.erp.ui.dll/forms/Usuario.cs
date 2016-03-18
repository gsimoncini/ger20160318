using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes.data;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	public class Usuario : System.Windows.Forms.Form
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private Infragistics.Win.Misc.UltraLabel ultraLabel11;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private Infragistics.Win.Misc.UltraLabel ultraLabel14;
		private Infragistics.Win.Misc.UltraLabel ultraLabel15;
		private Infragistics.Win.Misc.UltraLabel ultraLabel16;
		private Infragistics.Win.Misc.UltraLabel ultraLabel17;
		private Infragistics.Win.Misc.UltraLabel ultraLabel18;
		private Infragistics.Win.Misc.UltraLabel ultraLabel19;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor2;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel20;
		private Infragistics.Win.Misc.UltraLabel ultraLabel21;
		private Infragistics.Win.Misc.UltraLabel ultraLabel22;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbFirstRecord;
		private System.Windows.Forms.ToolBarButton tbPreviousRecord;
		private System.Windows.Forms.ToolBarButton tbNextRecord;
		private System.Windows.Forms.ToolBarButton tbLastRecord;
		private System.Windows.Forms.ToolBarButton tbSep1;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSep2;
		private System.Windows.Forms.ToolBarButton tbSave;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor2;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor4;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor5;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor3;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.ComponentModel.IContainer components;
		private sy_UsuariosDataset.sy_UsuariosRow _row;
		private Infragistics.Win.Misc.UltraLabel labelIdUsuario;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor textNombre;
		private bool _isNew = true;

		public Usuario()
		{
			InitializeComponent();

			_row = businessrules.sy_Usuarios.NewRow();
			_isNew = true;
			

			FillControls();
		}

		public Usuario( string IdUsuario )
		{
			InitializeComponent();
			
			_row = businessrules.sy_Usuarios.GetByPk( IdUsuario );
			_isNew = false;

			FillControls();
		}

		private void FillControls()
		{
			if ( _isNew )
			{
				labelIdUsuario.Text = "[Nuevo]";
				//textNombre.Text = _row.Nombre;

			}

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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Usuario));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.textNombre = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.ultraCheckEditor1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraComboEditor1 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraDateTimeEditor3 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraCheckEditor2 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraLabel19 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraCheckEditor3 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraLabel18 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.labelIdUsuario = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraCheckEditor4 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel16 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraNumericEditor2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraTextEditor3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraCheckEditor5 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraLabel22 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel21 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel20 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirstRecord = new System.Windows.Forms.ToolBarButton();
			this.tbPreviousRecord = new System.Windows.Forms.ToolBarButton();
			this.tbNextRecord = new System.Windows.Forms.ToolBarButton();
			this.tbLastRecord = new System.Windows.Forms.ToolBarButton();
			this.tbSep1 = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep2 = new System.Windows.Forms.ToolBarButton();
			this.tbSave = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textNombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.textNombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraDateTimeEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraCheckEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel8);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel11);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel14);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraComboEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraDateTimeEditor3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraNumericEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraCheckEditor2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel19);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel12);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraCheckEditor3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel18);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel13);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelIdUsuario);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(551, 239);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel3.TabIndex = 2;
			this.ultraLabel3.Text = "Nombre completo:";
			// 
			// textNombre
			// 
			this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textNombre.Location = new System.Drawing.Point(128, 24);
			this.textNombre.MaxLength = 50;
			this.textNombre.Multiline = true;
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(417, 44);
			this.textNombre.TabIndex = 0;
			// 
			// ultraDateTimeEditor1
			// 
			this.ultraDateTimeEditor1.DateTime = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			this.ultraDateTimeEditor1.Location = new System.Drawing.Point(128, 72);
			this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
			this.ultraDateTimeEditor1.Size = new System.Drawing.Size(128, 22);
			this.ultraDateTimeEditor1.TabIndex = 1;
			this.ultraDateTimeEditor1.Value = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			// 
			// ultraCheckEditor1
			// 
			this.ultraCheckEditor1.BackColor = System.Drawing.Color.Transparent;
			this.ultraCheckEditor1.Location = new System.Drawing.Point(128, 96);
			this.ultraCheckEditor1.Name = "ultraCheckEditor1";
			this.ultraCheckEditor1.Size = new System.Drawing.Size(24, 20);
			this.ultraCheckEditor1.TabIndex = 2;
			// 
			// ultraLabel8
			// 
			this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel8.ImageTransparentColor = System.Drawing.Color.Empty;
			this.ultraLabel8.Location = new System.Drawing.Point(0, 72);
			this.ultraLabel8.Name = "ultraLabel8";
			this.ultraLabel8.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel8.TabIndex = 8;
			this.ultraLabel8.Text = "Expiración:";
			// 
			// ultraLabel11
			// 
			this.ultraLabel11.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel11.Location = new System.Drawing.Point(0, 96);
			this.ultraLabel11.Name = "ultraLabel11";
			this.ultraLabel11.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel11.TabIndex = 11;
			this.ultraLabel11.Text = "Bloqueado:";
			// 
			// ultraLabel14
			// 
			this.ultraLabel14.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel14.Location = new System.Drawing.Point(0, 168);
			this.ultraLabel14.Name = "ultraLabel14";
			this.ultraLabel14.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel14.TabIndex = 14;
			this.ultraLabel14.Text = "Administrador:";
			// 
			// ultraComboEditor1
			// 
			this.ultraComboEditor1.Location = new System.Drawing.Point(128, 192);
			this.ultraComboEditor1.Name = "ultraComboEditor1";
			this.ultraComboEditor1.Size = new System.Drawing.Size(168, 22);
			this.ultraComboEditor1.TabIndex = 6;
			// 
			// ultraDateTimeEditor3
			// 
			this.ultraDateTimeEditor3.DateTime = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			this.ultraDateTimeEditor3.Location = new System.Drawing.Point(128, 144);
			this.ultraDateTimeEditor3.Name = "ultraDateTimeEditor3";
			this.ultraDateTimeEditor3.Size = new System.Drawing.Size(168, 22);
			this.ultraDateTimeEditor3.TabIndex = 4;
			this.ultraDateTimeEditor3.Value = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			// 
			// ultraNumericEditor1
			// 
			this.ultraNumericEditor1.Location = new System.Drawing.Point(128, 120);
			this.ultraNumericEditor1.Name = "ultraNumericEditor1";
			this.ultraNumericEditor1.Size = new System.Drawing.Size(168, 22);
			this.ultraNumericEditor1.TabIndex = 3;
			// 
			// ultraCheckEditor2
			// 
			this.ultraCheckEditor2.BackColor = System.Drawing.Color.Transparent;
			this.ultraCheckEditor2.Location = new System.Drawing.Point(128, 168);
			this.ultraCheckEditor2.Name = "ultraCheckEditor2";
			this.ultraCheckEditor2.Size = new System.Drawing.Size(16, 20);
			this.ultraCheckEditor2.TabIndex = 5;
			// 
			// ultraLabel19
			// 
			this.ultraLabel19.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel19.Location = new System.Drawing.Point(0, 216);
			this.ultraLabel19.Name = "ultraLabel19";
			this.ultraLabel19.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel19.TabIndex = 19;
			this.ultraLabel19.Text = "Activo:";
			// 
			// ultraLabel12
			// 
			this.ultraLabel12.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel12.Location = new System.Drawing.Point(0, 120);
			this.ultraLabel12.Name = "ultraLabel12";
			this.ultraLabel12.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel12.TabIndex = 12;
			this.ultraLabel12.Text = "Intentos de conexión:";
			// 
			// ultraCheckEditor3
			// 
			this.ultraCheckEditor3.BackColor = System.Drawing.Color.Transparent;
			this.ultraCheckEditor3.Location = new System.Drawing.Point(128, 216);
			this.ultraCheckEditor3.Name = "ultraCheckEditor3";
			this.ultraCheckEditor3.Size = new System.Drawing.Size(16, 20);
			this.ultraCheckEditor3.TabIndex = 7;
			// 
			// ultraLabel18
			// 
			this.ultraLabel18.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel18.Location = new System.Drawing.Point(0, 192);
			this.ultraLabel18.Name = "ultraLabel18";
			this.ultraLabel18.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel18.TabIndex = 18;
			this.ultraLabel18.Text = "Perfil utilizado:";
			// 
			// ultraLabel13
			// 
			this.ultraLabel13.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel13.Location = new System.Drawing.Point(0, 144);
			this.ultraLabel13.Name = "ultraLabel13";
			this.ultraLabel13.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel13.TabIndex = 13;
			this.ultraLabel13.Text = "Hablitación:";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel1.TabIndex = 0;
			this.ultraLabel1.Text = "ID:";
			// 
			// labelIdUsuario
			// 
			this.labelIdUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labelIdUsuario.Location = new System.Drawing.Point(128, 0);
			this.labelIdUsuario.Name = "labelIdUsuario";
			this.labelIdUsuario.Size = new System.Drawing.Size(168, 22);
			this.labelIdUsuario.TabIndex = 1;
			this.labelIdUsuario.Text = "ID:";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraCheckEditor4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraDateTimeEditor2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel10);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel16);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraNumericEditor2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTextEditor3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel15);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTextEditor2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel9);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraCheckEditor5);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 89);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(264, 143);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// ultraCheckEditor4
			// 
			this.ultraCheckEditor4.BackColor = System.Drawing.Color.Transparent;
			this.ultraCheckEditor4.Location = new System.Drawing.Point(96, 112);
			this.ultraCheckEditor4.Name = "ultraCheckEditor4";
			this.ultraCheckEditor4.Size = new System.Drawing.Size(24, 16);
			this.ultraCheckEditor4.TabIndex = 5;
			// 
			// ultraDateTimeEditor2
			// 
			this.ultraDateTimeEditor2.DateTime = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			this.ultraDateTimeEditor2.Location = new System.Drawing.Point(96, 48);
			this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
			this.ultraDateTimeEditor2.Size = new System.Drawing.Size(136, 22);
			this.ultraDateTimeEditor2.TabIndex = 2;
			this.ultraDateTimeEditor2.Value = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
			// 
			// ultraLabel10
			// 
			this.ultraLabel10.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel10.Location = new System.Drawing.Point(0, 48);
			this.ultraLabel10.Name = "ultraLabel10";
			this.ultraLabel10.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel10.TabIndex = 10;
			this.ultraLabel10.Text = "Vencimiento:";
			// 
			// ultraLabel16
			// 
			this.ultraLabel16.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel16.Location = new System.Drawing.Point(0, 72);
			this.ultraLabel16.Name = "ultraLabel16";
			this.ultraLabel16.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel16.TabIndex = 16;
			this.ultraLabel16.Text = "Permitir cambio:";
			// 
			// ultraNumericEditor2
			// 
			this.ultraNumericEditor2.Location = new System.Drawing.Point(96, 88);
			this.ultraNumericEditor2.Name = "ultraNumericEditor2";
			this.ultraNumericEditor2.Size = new System.Drawing.Size(136, 22);
			this.ultraNumericEditor2.TabIndex = 4;
			// 
			// ultraTextEditor3
			// 
			this.ultraTextEditor3.Location = new System.Drawing.Point(96, 24);
			this.ultraTextEditor3.MaxLength = 50;
			this.ultraTextEditor3.Name = "ultraTextEditor3";
			this.ultraTextEditor3.PasswordChar = '*';
			this.ultraTextEditor3.Size = new System.Drawing.Size(136, 22);
			this.ultraTextEditor3.TabIndex = 1;
			// 
			// ultraLabel15
			// 
			this.ultraLabel15.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel15.Location = new System.Drawing.Point(0, 112);
			this.ultraLabel15.Name = "ultraLabel15";
			this.ultraLabel15.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel15.TabIndex = 15;
			this.ultraLabel15.Text = "Nunca caduca:";
			// 
			// ultraTextEditor2
			// 
			this.ultraTextEditor2.Location = new System.Drawing.Point(96, 0);
			this.ultraTextEditor2.MaxLength = 50;
			this.ultraTextEditor2.Name = "ultraTextEditor2";
			this.ultraTextEditor2.PasswordChar = '*';
			this.ultraTextEditor2.Size = new System.Drawing.Size(136, 22);
			this.ultraTextEditor2.TabIndex = 0;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel4.TabIndex = 4;
			this.ultraLabel4.Text = "Clave:";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel5.TabIndex = 5;
			this.ultraLabel5.Text = "Repetir:";
			// 
			// ultraLabel9
			// 
			this.ultraLabel9.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel9.Location = new System.Drawing.Point(0, 96);
			this.ultraLabel9.Name = "ultraLabel9";
			this.ultraLabel9.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel9.TabIndex = 9;
			this.ultraLabel9.Text = "Días de validez:";
			// 
			// ultraCheckEditor5
			// 
			this.ultraCheckEditor5.BackColor = System.Drawing.Color.Transparent;
			this.ultraCheckEditor5.Location = new System.Drawing.Point(96, 72);
			this.ultraCheckEditor5.Name = "ultraCheckEditor5";
			this.ultraCheckEditor5.Size = new System.Drawing.Size(24, 16);
			this.ultraCheckEditor5.TabIndex = 3;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel22);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel21);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel20);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel17);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel7);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(316, 89);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(263, 63);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// ultraLabel22
			// 
			this.ultraLabel22.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel22.Location = new System.Drawing.Point(128, 48);
			this.ultraLabel22.Name = "ultraLabel22";
			this.ultraLabel22.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel22.TabIndex = 20;
			this.ultraLabel22.Text = "Raúl Gómez";
			// 
			// ultraLabel21
			// 
			this.ultraLabel21.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel21.Location = new System.Drawing.Point(128, 24);
			this.ultraLabel21.Name = "ultraLabel21";
			this.ultraLabel21.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel21.TabIndex = 19;
			this.ultraLabel21.Text = "4";
			// 
			// ultraLabel20
			// 
			this.ultraLabel20.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel20.Location = new System.Drawing.Point(128, 0);
			this.ultraLabel20.Name = "ultraLabel20";
			this.ultraLabel20.Size = new System.Drawing.Size(120, 22);
			this.ultraLabel20.TabIndex = 18;
			this.ultraLabel20.Text = "21/8/2004";
			// 
			// ultraLabel17
			// 
			this.ultraLabel17.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel17.Location = new System.Drawing.Point(0, 48);
			this.ultraLabel17.Name = "ultraLabel17";
			this.ultraLabel17.Size = new System.Drawing.Size(112, 22);
			this.ultraLabel17.TabIndex = 17;
			this.ultraLabel17.Text = "Última modificación:";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(104, 22);
			this.ultraLabel6.TabIndex = 6;
			this.ultraLabel6.Text = "Conexiones fallidas:";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(104, 22);
			this.ultraLabel7.TabIndex = 7;
			this.ultraLabel7.Text = "Última conexión:";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirstRecord,
																							  this.tbPreviousRecord,
																							  this.tbNextRecord,
																							  this.tbLastRecord,
																							  this.tbSep1,
																							  this.tbRefresh,
																							  this.tbSep2,
																							  this.tbSave});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(616, 28);
			this.toolBarStandar.TabIndex = 32;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbFirstRecord
			// 
			this.tbFirstRecord.ImageIndex = 0;
			// 
			// tbPreviousRecord
			// 
			this.tbPreviousRecord.ImageIndex = 1;
			// 
			// tbNextRecord
			// 
			this.tbNextRecord.ImageIndex = 2;
			// 
			// tbLastRecord
			// 
			this.tbLastRecord.ImageIndex = 3;
			// 
			// tbSep1
			// 
			this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbRefresh
			// 
			this.tbRefresh.ImageIndex = 5;
			// 
			// tbSep2
			// 
			this.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbSave
			// 
			this.tbSave.ImageIndex = 4;
			this.tbSave.Text = "Guardar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ultraExplorerBar1.ColumnCount = 2;
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			ultraExplorerBarGroup1.ColumnsSpanned = 2;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Expanded = false;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 239;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "General";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 143;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Clave";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 63;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Información";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(8, 32);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(600, 592);
			this.ultraExplorerBar1.TabIndex = 33;
			// 
			// Usuario
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(616, 630);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Usuario";
			this.Text = "Usuario";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textNombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	}
}
