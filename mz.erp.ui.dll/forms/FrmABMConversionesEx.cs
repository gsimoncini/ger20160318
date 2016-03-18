using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


using mz.erp.businessrules;


using mz.erp.commontypes.data;

namespace mz.erp.ui.forms
{
	public class FrmABMConversionesEx : mz.erp.ui.forms.FrmABMEx
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.ComponentModel.IContainer components = null;
		private Janus.Windows.GridEX.GridEX gridDetalleConversion;

		private string _idConversion;

		public FrmABMConversionesEx()
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


		#region Custom Members
		
		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tsh_ConversionesEx().GetType();
			base.Init();
		}		


		protected override void InitializeMembers()
		{

			gridDetalleConversion.AddingRecord +=new CancelEventHandler(gridDetalleConversion_AddingRecord);
			gridDetalleConversion.GroupByBoxVisible = false;
			gridDetalleConversion.RecordNavigator = false;
		}

		protected override void FillControls()
		{	
						
			if (_data != null)
			{
				try
				{	
					tsh_ConversionesExDataset data  = (tsh_ConversionesExDataset) _data;
					System.Data.DataRow row = data.tsh_Conversiones.Rows[0];
					_idConversion = (string)row["IdConversion"];
					txtNombre.Text = (string)row["Nombre"];
					txtDescripcion.Text = (string)row["Descripcion"];


					gridDetalleConversion.LayoutData = new mz.erp.ui.forms.classes.tsh_DetalleConversiones().GetLayout();
					gridDetalleConversion.SetDataBinding(data.tsh_DetalleConversiones,null);
					Janus.Windows.GridEX.GridEXColumnCollection col = gridDetalleConversion.CurrentTable.Columns;
					col["IdUnidadOrigen"].HasValueList =true;
					col["IdUnidadOrigen"].EditType= Janus.Windows.GridEX.EditType.Combo;
					col["IdUnidadOrigen"].ValueList.PopulateValueList(mz.erp.businessrules.tsh_Unidades.GetList().tsh_Unidades,"IdUnidad","Nombre");
					col["IdUnidadDestino"].HasValueList= true;
					col["IdUnidadDestino"].EditType= Janus.Windows.GridEX.EditType.Combo;
					col["IdUnidadDestino"].ValueList.PopulateValueList(mz.erp.businessrules.tsh_Unidades.GetList().tsh_Unidades,"IdUnidad","Nombre");
					//col["IsDefault"].EditType = Janus.Windows.GridEX.EditType.CheckBox;
					
							
				}
				catch(Exception e)
				{Console.WriteLine(e.Message);}
							
			
						
							
			}
		}
					
		protected override void DumpControls()
		{	
						
						
			if (_data != null)
			{
				tsh_ConversionesExDataset data  = (tsh_ConversionesExDataset) _data;
				System.Data.DataRow row = data.tsh_Conversiones.Rows[0];
				row["Nombre"] = txtNombre.Text ;
				row["Descripcion"] = txtDescripcion.Text;

				gridDetalleConversion.UpdateData();
			}	
		}


		#endregion

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gridDetalleConversion = new Janus.Windows.GridEX.GridEX();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleConversion)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridDetalleConversion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 223);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 24);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Descripcion:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(104, 0);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(304, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.Text = "";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(104, 20);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(304, 20);
			this.txtDescripcion.TabIndex = 3;
			this.txtDescripcion.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "Detalle:";
			// 
			// gridDetalleConversion
			// 
			this.gridDetalleConversion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridDetalleConversion.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridDetalleConversion.AlternatingColors = true;
			this.gridDetalleConversion.BorderStyle = Janus.Windows.GridEX.BorderStyle.Sunken;
			this.gridDetalleConversion.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridDetalleConversion.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridDetalleConversion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridDetalleConversion.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridDetalleConversion.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridDetalleConversion.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridDetalleConversion.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridDetalleConversion.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridDetalleConversion.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridDetalleConversion.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridDetalleConversion.Location = new System.Drawing.Point(104, 40);
			this.gridDetalleConversion.Name = "gridDetalleConversion";
			this.gridDetalleConversion.RecordNavigator = true;
			this.gridDetalleConversion.RecordNavigatorText = "Registro:|de";
			this.gridDetalleConversion.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridDetalleConversion.Size = new System.Drawing.Size(600, 184);
			this.gridDetalleConversion.TabIndex = 5;
			// 
			// FrmABMConversionesEx
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Name = "FrmABMConversionesEx";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleConversion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		private void gridDetalleConversion_AddingRecord(object sender, CancelEventArgs e)
		{
				

				Janus.Windows.GridEX.GridEXSelectedItem col = this.gridDetalleConversion.SelectedItems[0];
				Janus.Windows.GridEX.GridEXRow row = col.GetRow();
				row.Cells["IdConversion"].Value = _idConversion;
				row.Cells["Ordinal"].Value = gridDetalleConversion.RecordCount;

				row.Cells["FechaCreacion"].Value = mz.erp.businessrules.Sistema.DateTime.Now;
				row.Cells["IdConexionCreacion"].Value = Security.IdConexion;
				row.Cells["IdConexionUltimaModificacion"].Value = Security.IdConexion;
				row.Cells["IdReservado"].Value = 0;
				row.Cells["RowId"].Value = Guid.Empty;
				row.Cells["IdEmpresa"].Value = Security.IdEmpresa;
				row.Cells["IdSucursal"].Value = Security.IdSucursal;
				if(row.Cells["IdSucursal"].Value == null)
					row.Cells["IdSucursal"].Value = false;
				
				
		}


	}
}

