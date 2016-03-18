using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	public class FrmAbmBonificacionesEx : System.Windows.Forms.Form,ITaskForm

	{
		Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
		Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
		private System.Windows.Forms.Label label1;
		/*private System.Windows.Forms.RichTextBox rtbDescripcion;*/
		/*private Janus.Windows.GridEX.GridEX gridEX1;*/
		private System.Windows.Forms.Label label2;
		/*private mz.erp.ui.controls.mzComboEditor mzCETiposBonificacion;*/
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected System.Windows.Forms.ToolBarButton tbFirst;
		protected System.Windows.Forms.ToolBarButton tbPrev;
		protected System.Windows.Forms.ToolBarButton tbNext;
		protected System.Windows.Forms.ToolBarButton tbLast;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		protected System.Windows.Forms.ToolBarButton tbActualizar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		protected System.Windows.Forms.ToolBarButton tbGuardar;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected System.Windows.Forms.ToolBarButton tbDelete;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private Janus.Windows.GridEX.GridEX gridEx1;
		private mz.erp.ui.controls.mzComboEditor mzCETiposBonificacion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textCodigo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor maximo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor minimo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor valor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.Misc.UltraButton utbAgregar;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.TextBox rtbDescripcion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.mzComboEditor mzTipoBonifEdicion;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private mz.erp.ui.controls.mzComboEditor mzComboCodigo;
		private Infragistics.Win.Misc.UltraButton botonActualizar;
		private Infragistics.Win.Misc.UltraButton botonEliminar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		private Infragistics.Win.Misc.UltraButton botonEditar;
		private System.Windows.Forms.Label label13;
		private AbmBonificacionesController _uiController;

		public FrmAbmBonificacionesEx()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			_uiController = new AbmBonificacionesController();
			Build_UI();
			
		}
		public FrmAbmBonificacionesEx(AbmBonificacionesController controller)
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = controller;
			
			
		}

		#region Miembros de ITaskForm

		public void Execute()
		{
			//DumpControls()
			//pasa al controler el valor del text box
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}


		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();

			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}
		}
		public void CloseForm()
		{			
			Close();
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		#endregion
		
		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelLeyenda = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzComboCodigo = new mz.erp.ui.controls.mzComboEditor();
            this.label12 = new System.Windows.Forms.Label();
            this.mzTipoBonifEdicion = new mz.erp.ui.controls.mzComboEditor();
            this.label11 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.botonEditar = new Infragistics.Win.Misc.UltraButton();
            this.botonEliminar = new Infragistics.Win.Misc.UltraButton();
            this.rtbDescripcion = new System.Windows.Forms.TextBox();
            this.utbAgregar = new Infragistics.Win.Misc.UltraButton();
            this.valor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.minimo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.maximo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mzCETiposBonificacion = new mz.erp.ui.controls.mzComboEditor();
            this.gridEx1 = new Janus.Windows.GridEX.GridEX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botonActualizar = new Infragistics.Win.Misc.UltraButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbPrev = new System.Windows.Forms.ToolBarButton();
            this.tbNext = new System.Windows.Forms.ToolBarButton();
            this.tbGuardar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.tbActualizar = new System.Windows.Forms.ToolBarButton();
            this.tbFirst = new System.Windows.Forms.ToolBarButton();
            this.tbLast = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.tbStep3 = new System.Windows.Forms.ToolBarButton();
            this.tbDelete = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzTipoBonifEdicion)).BeginInit();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETiposBonificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelLeyenda);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 47);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(1133, 40);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            // 
            // labelLeyenda
            // 
            this.labelLeyenda.BackColor = System.Drawing.Color.Transparent;
            this.labelLeyenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyenda.Location = new System.Drawing.Point(0, 0);
            this.labelLeyenda.Name = "labelLeyenda";
            this.labelLeyenda.Size = new System.Drawing.Size(1133, 40);
            this.labelLeyenda.TabIndex = 1;
            this.labelLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboCodigo);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label12);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzTipoBonifEdicion);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label11);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 144);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1133, 32);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // mzComboCodigo
            // 
            this.mzComboCodigo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboCodigo.DisplayMember = "";
            this.mzComboCodigo.DisplayMemberCaption = "";
            this.mzComboCodigo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            valueListItem1.DataValue = "C";
            valueListItem1.DisplayText = "Cuenta";
            valueListItem2.DataValue = "P";
            valueListItem2.DisplayText = "Producto";
            this.mzComboCodigo.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.mzComboCodigo.Location = new System.Drawing.Point(632, 8);
            this.mzComboCodigo.MaxItemsDisplay = 50;
            this.mzComboCodigo.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboCodigo.Name = "mzComboCodigo";
            this.mzComboCodigo.Size = new System.Drawing.Size(176, 21);
            this.mzComboCodigo.SorterMember = "";
            this.mzComboCodigo.TabIndex = 101;
            this.mzComboCodigo.ValueMember = "";
            this.mzComboCodigo.ValueMemberCaption = "";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(504, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 23);
            this.label12.TabIndex = 118;
            this.label12.Text = "Código bonificación";
            // 
            // mzTipoBonifEdicion
            // 
            this.mzTipoBonifEdicion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzTipoBonifEdicion.DisplayMember = "";
            this.mzTipoBonifEdicion.DisplayMemberCaption = "";
            this.mzTipoBonifEdicion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            valueListItem3.DataValue = "C";
            valueListItem3.DisplayText = "Cuenta";
            valueListItem4.DataValue = "P";
            valueListItem4.DisplayText = "Producto";
            this.mzTipoBonifEdicion.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4});
            this.mzTipoBonifEdicion.Location = new System.Drawing.Point(200, 8);
            this.mzTipoBonifEdicion.MaxItemsDisplay = 50;
            this.mzTipoBonifEdicion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzTipoBonifEdicion.Name = "mzTipoBonifEdicion";
            this.mzTipoBonifEdicion.Size = new System.Drawing.Size(160, 21);
            this.mzTipoBonifEdicion.SorterMember = "";
            this.mzTipoBonifEdicion.TabIndex = 100;
            this.mzTipoBonifEdicion.ValueMember = "";
            this.mzTipoBonifEdicion.ValueMemberCaption = "";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(88, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 116;
            this.label11.Text = "Tipo de bonificación";
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.botonEditar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.botonEliminar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.rtbDescripcion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.utbAgregar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.valor);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.minimo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.maximo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.textCodigo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETiposBonificacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridEx1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label10);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label9);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.botonActualizar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label13);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 233);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(1133, 339);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            this.ultraExplorerBarContainerControl1.TabStop = true;
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(565, 46);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(64, 23);
            this.botonEditar.TabIndex = 124;
            this.botonEditar.Text = "&Editar";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(631, 46);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(64, 23);
            this.botonEliminar.TabIndex = 112;
            this.botonEliminar.Text = "&Eliminar";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(80, 80);
            this.rtbDescripcion.Multiline = true;
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(280, 80);
            this.rtbDescripcion.TabIndex = 105;
            // 
            // utbAgregar
            // 
            this.utbAgregar.Location = new System.Drawing.Point(703, 46);
            this.utbAgregar.Name = "utbAgregar";
            this.utbAgregar.Size = new System.Drawing.Size(64, 23);
            this.utbAgregar.TabIndex = 110;
            this.utbAgregar.Text = "&Agregar";
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(732, 19);
            this.valor.MaskInput = "{LOC}-nnnnnnnn.nn";
            this.valor.MinValue = -2147483647D;
            this.valor.Name = "valor";
            this.valor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.valor.Size = new System.Drawing.Size(80, 21);
            this.valor.TabIndex = 109;
            this.valor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // minimo
            // 
            this.minimo.Location = new System.Drawing.Point(458, 19);
            this.minimo.MinValue = 0;
            this.minimo.Name = "minimo";
            this.minimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.minimo.Size = new System.Drawing.Size(132, 21);
            this.minimo.TabIndex = 107;
            this.minimo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // maximo
            // 
            this.maximo.Location = new System.Drawing.Point(596, 19);
            this.maximo.MinValue = 0;
            this.maximo.Name = "maximo";
            this.maximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.maximo.Size = new System.Drawing.Size(129, 21);
            this.maximo.TabIndex = 108;
            this.maximo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(200, 40);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(160, 20);
            this.textCodigo.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(80, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 116;
            this.label7.Text = "Código";
            // 
            // mzCETiposBonificacion
            // 
            this.mzCETiposBonificacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCETiposBonificacion.DisplayMember = "";
            this.mzCETiposBonificacion.DisplayMemberCaption = "";
            this.mzCETiposBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            valueListItem5.DataValue = "C";
            valueListItem5.DisplayText = "Cuenta";
            valueListItem6.DataValue = "P";
            valueListItem6.DisplayText = "Producto";
            this.mzCETiposBonificacion.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem5,
            valueListItem6});
            this.mzCETiposBonificacion.Location = new System.Drawing.Point(200, 8);
            this.mzCETiposBonificacion.MaxItemsDisplay = 50;
            this.mzCETiposBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETiposBonificacion.Name = "mzCETiposBonificacion";
            this.mzCETiposBonificacion.Size = new System.Drawing.Size(160, 21);
            this.mzCETiposBonificacion.SorterMember = "";
            this.mzCETiposBonificacion.TabIndex = 103;
            this.mzCETiposBonificacion.ValueMember = "";
            this.mzCETiposBonificacion.ValueMemberCaption = "";
            // 
            // gridEx1
            // 
            this.gridEx1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEx1.AlternatingColors = true;
            this.gridEx1.AutoEdit = true;
            this.gridEx1.AutomaticSort = false;
            this.gridEx1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEx1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEx1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEx1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridEx1.GroupByBoxVisible = false;
            this.gridEx1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEx1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEx1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridEx1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridEx1.Location = new System.Drawing.Point(458, 96);
            this.gridEx1.Name = "gridEx1";
            this.gridEx1.RecordNavigatorText = "Registro:|de";
            this.gridEx1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEx1.ShowEmptyFields = false;
            this.gridEx1.Size = new System.Drawing.Size(354, 220);
            this.gridEx1.TabIndex = 106;
            this.gridEx1.UpdateOnLeave = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(80, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(80, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de bonificación";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(455, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 92;
            this.label6.Text = "Valores";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(596, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 123;
            this.label10.Text = "Máximo";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(458, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 122;
            this.label9.Text = "Mínimo";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(731, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 121;
            this.label8.Text = "Valor";
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(703, 70);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(64, 23);
            this.botonActualizar.TabIndex = 111;
            this.botonActualizar.Text = "&Aceptar";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(366, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 48);
            this.label13.TabIndex = 125;
            this.label13.Text = "Si el máximo es 0, se tomará sin máximo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tipo de Bonificación";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Detalle";
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbPrev,
            this.tbNext,
            this.tbGuardar,
            this.toolBarButton5,
            this.tbActualizar,
            this.tbFirst,
            this.tbLast,
            this.toolBarButton7,
            this.tbStep3,
            this.tbDelete});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(1182, 28);
            this.toolBarStandar.TabIndex = 17;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbPrev
            // 
            this.tbPrev.Enabled = false;
            this.tbPrev.ImageIndex = 9;
            this.tbPrev.Name = "tbPrev";
            this.tbPrev.Text = "Anterior";
            // 
            // tbNext
            // 
            this.tbNext.ImageIndex = 4;
            this.tbNext.Name = "tbNext";
            this.tbNext.Text = "Guardar";
            // 
            // tbGuardar
            // 
            this.tbGuardar.ImageIndex = 7;
            this.tbGuardar.Name = "tbGuardar";
            this.tbGuardar.Text = "&Cancelar";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton5.Visible = false;
            // 
            // tbActualizar
            // 
            this.tbActualizar.ImageIndex = 5;
            this.tbActualizar.Name = "tbActualizar";
            this.tbActualizar.Visible = false;
            // 
            // tbFirst
            // 
            this.tbFirst.Name = "tbFirst";
            // 
            // tbLast
            // 
            this.tbLast.Name = "tbLast";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton7.Visible = false;
            // 
            // tbStep3
            // 
            this.tbStep3.Name = "tbStep3";
            this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbStep3.Visible = false;
            // 
            // tbDelete
            // 
            this.tbDelete.ImageIndex = 7;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Text = "Borrar";
            this.tbDelete.Visible = false;
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup1.Key = "Leyenda";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 40;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Key = "DatosGenerales";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 32;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos Generales";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup3.Key = "DatosBonificacion";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 339;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Datos Bonificación";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(1182, 613);
            this.ultraExplorerBar1.TabIndex = 18;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // FrmAbmBonificacionesEx
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1182, 641);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmAbmBonificacionesEx";
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzTipoBonifEdicion)).EndInit();
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETiposBonificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		#region metodos privados
		protected void Build_UI()
		{	//Configura los controlles, visibilidad, etc, etc
			ConfigureInterface();	
			//Ejemplo le carga datos a un combo
			//InitializeData();
			
			//Asociar eventos a la interface
			//Cuando hace click en la  barra de arriba, ejemplo guardar...
			InitEventHandlers();
			
			//Realizar binding entre la interface y el controlador
			//implementacion no lleva
			//InitDataBindings();		
			//Para propiedades estaticas, datos q no dependen ni modifican a nadie.
			//carga la info q viene del controller
			//FillControls();
		}
		#endregion
		protected void InitEventHandlers()
		{
			_uiController.BonificacionesDetalleChanged+=new EventHandler(_uiController_BonificacionesDetalleChanged);
			_uiController.DescripcionChanged+=new EventHandler(_uiController_DescripcionChanged);
			_uiController.CodigoChanged+=new EventHandler(_uiController_CodigoChanged);
			_uiController.TipoBonificacionChanged+=new EventHandler(_uiController_TipoBonificacionChanged);
			_uiController.ObjectHasChanged+=new EventHandler(_uiController_ObjectHasChanged);
			_uiController.MaximoChanged+=new EventHandler(_uiController_MaximoChanged);
			_uiController.MinimoChanged+=new EventHandler(_uiController_MinimoChanged);
			_uiController.ValorChanged+=new EventHandler(_uiController_ValorChanged);
			//Es el aceptar
			this.botonActualizar.Click+=new EventHandler(botonActualizar_Click);
			this.botonEliminar.Click+=new EventHandler(botonEliminar_Click);
			this.botonEditar.Click+=new EventHandler(botonEditar_Click);
			this.gridEx1.SelectionChanged+=new EventHandler(gridEx1_SelectionChanged);
			this.mzTipoBonifEdicion.ValueChanged+=new EventHandler(mzTipoBonifEdicion_ValueChanged);
			this.mzComboCodigo.ValueChanged+=new EventHandler(mzComboCodigo_ValueChanged);
			this.utbAgregar.Click+=new EventHandler(utbAgregar_Click);
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

		protected  void ConfigureInterface()
		{
			this.tbNext.Text=_uiController.TextoBotonSiguiente;
			this.botonActualizar.Enabled=false;
			this.labelLeyenda.Text=_uiController.Leyenda;
			this.Text=_uiController.Leyenda;
			ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles(), ",");
			foreach(string grupo in cont)
			{ 
				if (grupo != string.Empty)
				{
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
						if (this.ultraExplorerBar1.Groups[grupo].Container != null)
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = false;
					
				}
			}
			rtbDescripcion.MaxLength = 200;
			this.gridEx1.LayoutData= _uiController.GetLayout();
			BindingController.Bind(this.textCodigo,"Text", _uiController, "Codigo");
			BindingController.Bind(this.rtbDescripcion,"Text", _uiController, "Descripcion");
			BindingController.Bind(mzCETiposBonificacion,"Value", _uiController, "TipoBonificacion");
			BindingController.Bind(mzTipoBonifEdicion,"Value", _uiController, "TipoBonificacionEdicion");
			BindingController.Bind(mzComboCodigo,"Value", _uiController, "CodigoEdicion");
			this.maximo.DataBindings.Add("Value",_uiController,"Maximo");
			this.minimo.DataBindings.Add("Value",_uiController,"Minimo");
			this.valor.DataBindings.Add("Value",_uiController,"Valor");
			this.gridEx1.SetDataBinding(_uiController.BonificacionesDetalle, null );
            //German 20120208 - Tarea 0000276
			mzCETiposBonificacion.Value="P";
            //Fin German 20120208 - Tarea 0000276
			mzComboCodigo.Enabled=false;
			//mzTipoBonifEdicion.Value="C";
			KeyPreview = true;
						
		}

		#region CustomMembers

		/*protected override void Init()
			{
				_businessRulesType = new mz.erp.businessrules.data.tsa_BonificacionesEx().GetType();
				base.Init();
			}		*/

		
		/*	protected override void FillControls()
					{	
						
						if (_data != null)
						{
							try
							{	
								mz.erp.commontypes.data.tsa_BonificacionesExDataset data=(mz.erp.commontypes.data.tsa_BonificacionesExDataset) _data;
								System.Data.DataTable tableBonificaciones=data.Tables["tsa_Bonificaciones"];
								System.Data.DataRow row = tableBonificaciones.Rows[0];
								rtbDescripcion.Text= (string)row["Descripcion"];
								if((string)row ["IdTipoBonificacion"] != string.Empty)
									mzCETiposBonificacion.Value =(string)row ["IdTipoBonificacion"];

							
							}
							catch(Exception e){;}
							
			
						
							
						}
					}
					
		protected override void DumpControls()
		{	
						
						
			if (_data != null)
			{
				mz.erp.commontypes.data.tsa_BonificacionesExDataset data=(mz.erp.commontypes.data.tsa_BonificacionesExDataset) _data;
				System.Data.DataTable table=data.Tables["tsa_Bonificaciones"];
				System.Data.DataRow row = table.Rows[0];
				row ["descripcion"] = rtbDescripcion.Text;
				if (mzCETiposBonificacion.Value != null)
				row ["IdTipoBonificacion"]=(string)mzCETiposBonificacion.Value;
				
				gridEX1.UpdateData();
			}	
		}*/
		

		#endregion		
								
			
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


		private void _uiController_BonificacionesDetalleChanged(object sender, EventArgs e)
		{
			
			//this.gridEx1.SetDataBinding(_uiController.BonificacionesDetalle, null );
		}

		private void _uiController_DescripcionChanged(object sender, EventArgs e)
		{
			this.rtbDescripcion.Text=_uiController.Descripcion;
				
		}

		private void _uiController_CodigoChanged(object sender, EventArgs e)
		{
			this.textCodigo.Text=_uiController.Codigo;
		}

		private void _uiController_TipoBonificacionChanged(object sender, EventArgs e)
		{
			this.mzCETiposBonificacion.Value=_uiController.TipoBonificacion;
		}


		
		private void utbAgregar_Click(object sender, EventArgs e)
		{			  
			_uiController.NuevoDetalle();
			this.botonActualizar.Enabled=true;
			
			
		}
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{ 
				case 2://Cancelar
					this.ResetearDatos();
					break;
				case 1://Guardar	
					_uiController.Execute();
					break;
			}						
		}

		private void mzTipoBonifEdicion_ValueChanged(object sender, EventArgs e)
		{
			mzComboCodigo.Enabled=true;
			//Buscar todos los codigos de bonificacion para ese tipo de bonificacion y setearle los codigos como text y value
			mzComboCodigo.FillFromDataSource(_uiController.Codigos,"Codigo","Codigo" ,100,"Codigo");
			//Borro todos los bindeos
			this.ultraExplorerBar1.Groups["DatosBonificacion"].Container.Enabled = false;
			this.ResetearDatos();
			BindingController.Clear(this.textCodigo,"Text", _uiController, "Codigo");
			BindingController.Clear(this.rtbDescripcion,"Text", _uiController, "Descripcion");
			BindingController.Clear(mzCETiposBonificacion,"Value", _uiController, "TipoBonificacion");
		}

		private void mzComboCodigo_ValueChanged(object sender, EventArgs e)
		{

			// traer la bonificacion, habilitar el container de abajo y cargar los datos
			_uiController.SeleccionarBonificacion();
			BindingController.Bind(this.textCodigo,"Text", _uiController, "Codigo");
			BindingController.Bind(this.rtbDescripcion,"Text", _uiController, "Descripcion");
			BindingController.Bind(mzCETiposBonificacion,"Value", _uiController, "TipoBonificacion");
			this.ultraExplorerBar1.Groups["DatosBonificacion"].Container.Enabled = true;
			this.gridEx1.SetDataBinding(null, null );
			this.gridEx1.SetDataBinding(_uiController.BonificacionesDetalle, null );
		
		}

		private void _uiController_ObjectHasChanged(object sender, EventArgs e)
		{
			//Actualizo los tres text box de arriba con los datos del selected item
			if (_uiController.Maximo!=Decimal.MaxValue)
				this.maximo.Value=_uiController.Maximo;
			else 
				this.maximo.Value=0;
			this.minimo.Value=_uiController.Minimo;
			this.valor.Value=_uiController.Valor;
		}

		private void gridEx1_SelectionChanged(object sender, EventArgs e)
		{
			if(gridEx1.SelectedItems.Count > 0)
			{
				object selectedItem = gridEx1.SelectedItems[0].GetRow().DataRow;
				//_selectedIndex = gridEx1.Row;
				_uiController.SelectedItem = (businessrules.comprobantes.BonificacionItem)selectedItem;
			}
			
		}

		private void _uiController_MaximoChanged(object sender, EventArgs e)
		{
			this.maximo.Value=_uiController.Maximo;
		}

		private void _uiController_MinimoChanged(object sender, EventArgs e)
		{
			this.minimo.Value=_uiController.Minimo;
		}

		private void _uiController_ValorChanged(object sender, EventArgs e)
		{
			this.valor.Value=_uiController.Valor;
		}

		//Boton Aceptar
		private void botonActualizar_Click(object sender, EventArgs e)
		{
			

			//Capturar lo q viene y q no haga nada de esto si no se agrego el detalle porq esta overlapeado
			if(_uiController.ItemValido()){
				//_uiController.AgregarDetalleActual();
				this.gridEx1.SelectionChanged-=new EventHandler(gridEx1_SelectionChanged);
				this.gridEx1.SetDataBinding(null, null );
				this.gridEx1.SetDataBinding(_uiController.BonificacionesDetalle, null );
				this.gridEx1.SelectionChanged+=new EventHandler(gridEx1_SelectionChanged);
                this.botonActualizar.Enabled=false;
				}			
			else
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_uiController.GetErrors());
				_form.ShowDialog();
			}
		}

		private void botonEliminar_Click(object sender, EventArgs e)
		{
			this.botonActualizar.Enabled=false;
			if(gridEx1.SelectedItems.Count > 0)
			{
				object selectedItem = gridEx1.SelectedItems[0].GetRow().DataRow;
				CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.BonificacionesDetalle];
				int pos = cm.Position;
				if(pos >= 0)
				{
					cm.RemoveAt(pos);
					cm.Refresh();
					
				}		
			}
					
		}
		private void ResetearDatos(){
		_uiController.ResetearBonificacion();
		this.gridEx1.SetDataBinding(null, null );
		this.minimo.Value=0;
		this.maximo.Value=0;
		this.valor.Value=0;
		}

		private void botonEditar_Click(object sender, EventArgs e)
		{
			this.botonActualizar.Enabled=false;
			if(gridEx1.SelectedItems.Count > 0)
			{
				gridEx1.Refetch();
			}
		}
	}
}

