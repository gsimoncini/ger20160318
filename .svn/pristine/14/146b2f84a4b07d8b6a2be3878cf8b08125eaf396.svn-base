using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.ui;
using mz.erp.commontypes;
using System.Reflection;
using mz.erp.ui.forms.classes;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de GridDocument.
	/// </summary>
	/// 

	public class GridDocument : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbFirstRecord;
		private System.Windows.Forms.ToolBarButton tbPreviousRecord;
		private System.Windows.Forms.ToolBarButton tbNextRecord;
		private System.Windows.Forms.ToolBarButton tbLastRecord;
		private Janus.Windows.GridEX.GridEX gridStandar;
		private IGridDocument _source;
		private Type _type;
		private System.Windows.Forms.ToolBarButton tbSep1;
		private System.Windows.Forms.ToolBarButton tbUpdate;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSep2;
		private bool _isDirty;
		ArrayList _parameters = new ArrayList();
        /* Silvina 20110504 - Tarea 0000123 */
        string _baseDefault = string.Empty;
        bool _permiteEditar = false;
        /* Fin Silvina 20110504 - Tarea 0000123 */

		public GridDocument()
		{
			InitializeComponent();
		}

		public GridDocument( IGridDocument gridDocument )
		{
			InitializeComponent();
			_source = gridDocument;
			_type = gridDocument.GetType();
            /* Silvina 20110504 - Tarea 0000123 */
            if (_type.Name.Equals("sy_Empresas"))
            {
                _baseDefault = Variables.GetValueString("Sistema.BasesDeDatos.Default");
                _permiteEditar = Variables.GetValueBool("Sistema.BasesDeDatos.PermiteEditar");
                this.gridStandar.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(gridStandar_EditingCell);
            }
             /* Fin Silvina 20110504 - Tarea 0000123 */
			LoadParameters();
			//this.gridStandar.GetNewRow +=new Janus.Windows.GridEX.GetNewRowEventHandler(gridStandar_GetNewRow);
			this.gridStandar.AddingRecord+=new CancelEventHandler(gridStandar_AddingRecord);
			this.gridStandar.LayoutData = _source.GetLayout();
			
			RefreshData();
		}

        /* Silvina 20110504 - Tarea 0000123 */
        void gridStandar_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
        {
            string col = e.Column.Key;
            if (!_permiteEditar && (col.Equals("BaseDeDatos")))
                e.Cancel = true;
        }
        /* Fin Silvina 20110504 - Tarea 0000123 */

		private void gridStandar_GetNewRow(object sender, Janus.Windows.GridEX.GetNewRowEventArgs e)
		{
			DataRow row = (DataRow) e.NewRow;
			if(row.Table != null)
			{
				DataTable table = row.Table;
				if(table.Columns.Contains("FechaCreacion"))
				{
					row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;

				}
				if(table.Columns.Contains("IdConexionCreacion"))
				{
					row["IdConexionCreacion"] = Security.IdConexion;
				}
				if(table.Columns.Contains("IdConexionUltimaModificacion"))
				{
					row["IdConexionUltimaModificacion"] = Security.IdConexion;
				}
				if(table.Columns.Contains("RowId"))
				{
					row["RowId"] = Guid.Empty;
				}

                
			}
		}

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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GridDocument));
			this.gridStandar = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirstRecord = new System.Windows.Forms.ToolBarButton();
			this.tbPreviousRecord = new System.Windows.Forms.ToolBarButton();
			this.tbNextRecord = new System.Windows.Forms.ToolBarButton();
			this.tbLastRecord = new System.Windows.Forms.ToolBarButton();
			this.tbSep2 = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep1 = new System.Windows.Forms.ToolBarButton();
			this.tbUpdate = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).BeginInit();
			this.SuspendLayout();
			// 
			// gridStandar
			// 
			this.gridStandar.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridStandar.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridStandar.AlternatingColors = true;
			this.gridStandar.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStandar.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridStandar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStandar.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStandar.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridStandar.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridStandar.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridStandar.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridStandar.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridStandar.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridStandar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridStandar.Location = new System.Drawing.Point(0, 0);
			this.gridStandar.Name = "gridStandar";
			this.gridStandar.RecordNavigator = true;
			this.gridStandar.RecordNavigatorText = "Registro:|de";
			this.gridStandar.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridStandar.Size = new System.Drawing.Size(696, 470);
			this.gridStandar.TabIndex = 0;
			this.gridStandar.RecordsDeleted += new System.EventHandler(this.gridStandar_OnChange);
			this.gridStandar.RecordAdded += new System.EventHandler(this.gridStandar_OnChange);
			this.gridStandar.RecordUpdated += new System.EventHandler(this.gridStandar_OnChange);
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirstRecord,
																							  this.tbPreviousRecord,
																							  this.tbNextRecord,
																							  this.tbLastRecord,
																							  this.tbSep2,
																							  this.tbRefresh,
																							  this.tbSep1,
																							  this.tbUpdate});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(696, 28);
			this.toolBarStandar.TabIndex = 1;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// tbSep2
			// 
			this.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbRefresh
			// 
			this.tbRefresh.ImageIndex = 5;
			// 
			// tbSep1
			// 
			this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbUpdate
			// 
			this.tbUpdate.ImageIndex = 4;
			this.tbUpdate.Text = "Guardar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// GridDocument
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(696, 470);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.gridStandar);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "GridDocument";
			this.Text = "GridDocument";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.GridDocument_Closing);
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
		private string _name="";
		protected System.Data.DataRow _row;

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					gridStandar.MoveFirst();
					break;

				case 1:
					gridStandar.MovePrevious();
					break;

				case 2:
					gridStandar.MoveNext();
					break;

				case 3:
					gridStandar.MoveLast();
					break;

				case 5:
					RefreshData();
					break;
				case 7:
					SaveChanges();
					break;
			}
		}

		private void RefreshData()
		{
			this.gridStandar.DataSource = _source.GetList();
			ApplyParameters();
			_isDirty = false;
		}

		private void ApplyParameters()
		{
			foreach(ArrayList parameter in _parameters)
			{
				
				string ColumnName = (string)parameter[0];
				Type ClassName = (Type)parameter[1];
				string IdFieldName = (string)parameter[2];
				string DescrptionFieldName = (string)parameter[3];
				MethodBase method = (MethodBase) parameter[4];
				Janus.Windows.GridEX.GridEXColumnCollection col = gridStandar.CurrentTable.Columns;
				col[ColumnName].HasValueList =true;
				col[ColumnName].EditType= Janus.Windows.GridEX.EditType.Combo;
				object instance = Activator.CreateInstance( ClassName, true );

				DataTable resultValue =(DataTable) method.Invoke( instance, new object []{} );
				col[ColumnName].ValueList.PopulateValueList((System.Collections.IEnumerable)resultValue,IdFieldName,DescrptionFieldName);

                /* Silvina 20110504 - Tarea 0000123 */
                if (ColumnName.Equals("BaseDeDatos"))
                    col[ColumnName].DefaultValue = _baseDefault;
                /* Fin Silvina 20110504 - Tarea 0000123 */
			}

		}

		public string Caption

		{
			set 
			{
				_name = value;
				base.Text = value;
			}
			get
			{
				return this._name;
			}
		}

		private void SaveChanges()
		{			
			_source.Update( ( DataTable )gridStandar.DataSource );
			
			DataTable dt = ( DataTable )gridStandar.DataSource;
			if ( dt.HasErrors )
			{
				Evaluate();
				MessageBox.Show( "Se han producido mz.erp.ui.forms.classes.Errores en el guardado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			else
			{
				_isDirty = false;
			}
		}

		protected void Evaluate()
		{			
			DataTable datatable = new DataTable();
			datatable = (( DataTable )gridStandar.DataSource);

			if (datatable.HasErrors)			
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(datatable);
				_form.Show();
				ArrayList aux = new ArrayList();
				foreach(DataRow row in datatable.Rows)
				{
					//Se pasan a una coleccion auxiliar y se hace el RejectChanges desde la coleccion, pq si se hace desde la tabla da error al recorrer la tabla pq la misma cambia por el rejectchanges
					if(row.HasErrors)
					{
						aux.Add(row);
					}
				}
				foreach(DataRow row in aux)
				{
					row.ClearErrors();
					row.RejectChanges();
				}
				//_row.RejectChanges();
			}
			else
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				Close();
			}
		}

		private void GridDocument_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ( _isDirty )
			{
				DialogResult dr = MessageBox.Show( "¿Desea guardar los cambios?", "Consulta!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
				if ( dr == DialogResult.Yes )
				{
					SaveChanges();
				}
				else if ( dr == DialogResult.Cancel )
				{
					e.Cancel = true;
				}
			}
		}

		private void gridStandar_OnChange(object sender, System.EventArgs e)
		{
			_isDirty = true;
		}

		private void LoadParameters()
		{
		/*	foreach( Attribute am in _type.GetCustomAttributes( false ) )
			{
				if ( am is ValueListGridAttributes)
				{*/
					ValueListGridAttributes[] MyAttribute =
						(ValueListGridAttributes[]) Attribute.GetCustomAttributes(_type, typeof (ValueListGridAttributes));
				
					for(int i = 0 ; i < MyAttribute.Length ; i++)
					{
						
						ArrayList parameter = new ArrayList(); 
						ValueListGridAttributes vlga = (ValueListGridAttributes) MyAttribute[i];
						parameter.Add(vlga.ColumnName);
						parameter.Add(vlga.SearchClass);
						parameter.Add(vlga.IdFieldName);
						parameter.Add(vlga.DescriptionFieldName);
						
						MethodBase method = null;
						foreach( MethodBase mb in vlga.SearchClass.GetMethods() )
						{
							foreach( Attribute attMethod in mb.GetCustomAttributes( false ) )
							{
								if ( attMethod  is ValueListGridMember)
									
									method = mb;
								
						
							}
	
						}
						parameter.Add(method);
						_parameters.Add(parameter);
					}
				//}
			//}
		}



		#endregion

		private void gridStandar_AddingRecord(object sender, CancelEventArgs e)
		{
			//Sabrina 20100618 - Tarea 787
			DataTable table = ( DataTable )gridStandar.DataSource;
			DataColumn[] clave = table.PrimaryKey;
			ArrayList nombresColumnasClaves = new ArrayList();
			for(int i = 0; i < clave.Length; i++)
			{
				DataColumn c = (DataColumn)clave[i];
				nombresColumnasClaves.Add(c.ColumnName);
			}
			//Fin Sabrina 20100618 - Tarea 787

			Janus.Windows.GridEX.GridEXSelectedItem col = gridStandar.SelectedItems[0];
			Janus.Windows.GridEX.GridEXRow row = col.GetRow();
			if(row.Table != null)
			{
				foreach(Janus.Windows.GridEX.GridEXColumn columns in row.Table.Columns)
				{
					//Sabrina 20100618 - Tarea 787
					foreach(string nombreColumna in nombresColumnasClaves)
					{
						if(row.Cells[nombreColumna].Value == System.DBNull.Value)
						{
							if(table.Columns[nombreColumna].DataType.Equals(System.Type.GetType("System.String")))
								row.Cells[nombreColumna].Value = systemframework.Util.NewStringId();
							if(table.Columns[nombreColumna].DataType.Equals(System.Type.GetType("System.Guid")))
								row.Cells[nombreColumna].Value = Guid.Empty;
						}
					}
					if(columns.Key.Equals("Activo") && row.Cells["Activo"].Value == System.DBNull.Value)
					{
						row.Cells["Activo"].Value = false;
					}
					if(columns.Key.Equals("IdEmpresa") && row.Cells["IdEmpresa"].Value == System.DBNull.Value)
					{
						row.Cells["IdEmpresa"].Value = Security.IdEmpresa;
					}
					if(columns.Key.Equals("IdSucursal") && row.Cells["IdSucursal"].Value == System.DBNull.Value)
					{
						row.Cells["IdSucursal"].Value = Security.IdSucursal;
					}
					if(columns.Key.Equals("isDefault") && row.Cells["isDefault"].Value == System.DBNull.Value)
					{
						row.Cells["isDefault"].Value = false;
					}
					//Fin Sabrina 20100618 - Tarea 787
					if(columns.Key.Equals("FechaCreacion"))
					{
						row.Cells["FechaCreacion"].Value = mz.erp.businessrules.Sistema.DateTime.Now;
					}
					if(columns.Key.Equals("IdConexionCreacion"))
					{
						row.Cells["IdConexionCreacion"].Value = Security.IdConexion;
					}
					if(columns.Key.Equals("IdConexionUltimaModificacion"))
					{
						row.Cells["IdConexionUltimaModificacion"].Value = Security.IdConexion;
					}
					if(columns.Key.Equals("IdReservado"))
					{
						row.Cells["IdReservado"].Value = 0;
					}
					if(columns.Key.Equals("RowId"))
					{
						row.Cells["RowId"].Value = Guid.Empty;
					}
                    /* Silvina 20110504 - Tarea 0000123 */
                    if (columns.Key.Equals("BaseDeDatos"))
                    {
                        row.Cells["BaseDeDatos"].Value = _baseDefault;
                    }
                    /* Fin Silvina 20110504 - Tarea 0000123 */
                    //German 20110602 - Tarea 0000149
                    if (columns.Key.Equals("FechaInicio"))
                    {
                        row.Cells["FechaInicio"].Value = mz.erp.businessrules.Sistema.DateTime.Now;
                    }
                    //Fin German 20110602 - Tarea 0000149
				}
			}
		}
	}
}
