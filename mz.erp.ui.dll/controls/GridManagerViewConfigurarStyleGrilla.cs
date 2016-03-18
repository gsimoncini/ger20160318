using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using System.Xml; 
using System.Xml.Serialization;


namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de GridManagerViewConfigurarStyleGrilla.
	/// </summary>
	public class GridManagerViewConfigurarStyleGrilla : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.Misc.UltraButton btnConfGrilla;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public GridManagerViewConfigurarStyleGrilla()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    			
		}

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
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

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnConfGrilla = new Infragistics.Win.Misc.UltraButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnConfGrilla
			// 
			this.btnConfGrilla.Location = new System.Drawing.Point(0, 0);
			this.btnConfGrilla.Name = "btnConfGrilla";
			this.btnConfGrilla.Size = new System.Drawing.Size(96, 24);
			this.btnConfGrilla.TabIndex = 118;
			this.btnConfGrilla.Text = "Configurar grilla";
			// 
			// GridManagerViewConfigurarStyleGrilla
			// 
			this.Controls.Add(this.btnConfGrilla);
			this.Name = "GridManagerViewConfigurarStyleGrilla";
			this.Size = new System.Drawing.Size(96, 24);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables privadas
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		private ArrayList _columnas;
		private Janus.Windows.GridEX.GridEX _grilla;
		private string _processName;
		private string _taskName;
		private ArrayList _configuracionDet = new ArrayList();
		private string _formulario;
		private string _tituloFormularioPadre;
		#endregion

		#region Métodos públicos	
		public void Configure(IGridManager manager, GridVariablesLoader loader, ArrayList Columns, Janus.Windows.GridEX.GridEX Grilla, string ProcessName, string TaskName, string Formulario, string TituloFormularioPadre) 
		{
			_loader = loader;
			_manager = manager;
			_columnas = Columns;
			_grilla = Grilla;
			_processName = ProcessName;
			_taskName = TaskName;
			if(Formulario == null)
				_formulario = string.Empty;			
			else
                _formulario = Formulario;
			_tituloFormularioPadre = TituloFormularioPadre;
			btnConfGrilla.Click +=new EventHandler(btnConfGrilla_Click);
			this.ObtenerConfiguracionGrilla();
			_grilla.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(_grilla_FormattingRow);
		}

		private void _grilla_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
			Janus.Windows.GridEX.GridEXRow row = e.Row;
			if(row.RowType == Janus.Windows.GridEX.RowType.Record)
			{
				foreach(ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet conf in _configuracionDet)
				{	
					string key = conf.Columna.Name;
					string cond = conf.Condicion;
					Janus.Windows.GridEX.GridEXCell cell1 = row.Cells[key];
					Janus.Windows.GridEX.GridEXColumn col2 = (Janus.Windows.GridEX.GridEXColumn)conf.Valor;
					Janus.Windows.GridEX.GridEXCell cell2 = row.Cells[col2.Key];
					object valorCol1 = cell1.Value;
					object valorCol2 = cell2.Value;
					bool satisfaceCondicion = false;
					string type = conf.Columna.Type;
					switch (cond )
					{				
						case ">" :
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D > val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I > val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT > val2DT;		
									break;
							}																
							break;
						}
						case "<" :
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D < val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I < val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT < val2DT;		
									break;
							}																
							break;
						}
						case "=" :
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D == val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I == val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT == val2DT;		
									break;
								case "STRING" :
									string val1S = (string)valorCol1;
									string val2S = (string)valorCol2;
									satisfaceCondicion = val1S == val2S;		
									break;
								case "BOOL" :
									bool val1B = (bool)valorCol1;
									bool val2B = (bool)valorCol2;
									satisfaceCondicion = val1B == val2B;		
									break;
							}																
							break;
						}
						case ">=":
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D >= val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I >= val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT >= val2DT;		
									break;
							}																
							break;
						}
						case "<=":
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D <= val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I <= val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT <= val2DT;		
									break;
							}																
							break;
						}
						case "!=":
						{
							switch (type )
							{	
								case "DECIMAL" :
									decimal val1D = (decimal)valorCol1;
									decimal val2D = (decimal)valorCol2;
									satisfaceCondicion = val1D != val2D;		
									break;
								case "INT" :
									int val1I = (int)valorCol1;
									int val2I = (int)valorCol2;
									satisfaceCondicion = val1I != val2I;		
									break;
								case "DATETIME" :
									DateTime val1DT = (DateTime)valorCol1;
									DateTime val2DT = (DateTime)valorCol2;
									satisfaceCondicion = val1DT != val2DT;		
									break;
								case "STRING" :
									string val1S = (string)valorCol1;
									string val2S = (string)valorCol2;
									satisfaceCondicion = val1S != val2S;		
									break;
								case "BOOL" :
									bool val1B = (bool)valorCol1;
									bool val2B = (bool)valorCol2;
									satisfaceCondicion = val1B != val2B;		
									break;
							}																
							break;
						}
						case "like":
						{
							switch (type )
							{	
								case "STRING" :
									string val1D = (string)valorCol1;
									string val2D = (string)valorCol2;
									satisfaceCondicion = val1D.IndexOf(val2D) != -1;		
									break;
							}																
							break;
						}
					}							
					if(satisfaceCondicion)
					{     
						Janus.Windows.GridEX.GridEXFormatStyle fs = conf.Estilo.ToFormatStyle();
						row.RowStyle = fs;
					}

				}
			}
		}


		#endregion

		#region Metodos Privados

		private void btnConfGrilla_Click(object sender, EventArgs e)
		{		
			FrmConfiguracionStyleGrilla frm = new FrmConfiguracionStyleGrilla(_columnas, _grilla, _processName, _taskName, _formulario, _tituloFormularioPadre);
			frm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
			frm.ConfiguracionGrillaHasChanged +=new EventHandler(frm_ConfiguracionGrillaHasChanged); 
			frm.Show();
		}

		private void frm_ConfiguracionGrillaHasChanged(object sender, EventArgs e)
		{			
			ObtenerConfiguracionGrilla();
			_grilla.Refresh();
		}

		private void ObtenerConfiguracionGrilla()
		{
			_configuracionDet.Clear();
			_grilla.RootTable.FormatConditions.Clear();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(_processName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(_taskName);
			long idConfAplicada = tui_ConfiguracionGrillaEstiloAplicadoEx.GetIdConfiguracionAplicada(Security.IdUsuario, Security.IdPerfil, IdProceso, IdTarea, _grilla.Name, _formulario);
			if(idConfAplicada != long.MinValue)
			{
				bool existe = ObtenerConfiguracionGrillaUsuarios(IdProceso, IdTarea, Security.IdUsuario, idConfAplicada);
				if(!existe)
				{
					existe = ObtenerConfiguracionGrillaPerfiles(IdProceso, IdTarea, Security.IdPerfil, idConfAplicada);
					if(!existe)
						ObtenerConfiguracionGrillaGeneral(IdProceso, IdTarea, idConfAplicada);
				}
			}
		}

		private void ObtenerConfiguracionGrillaGeneral(long IdProceso, long IdTarea, long IdConfiguracion)
		{
			//long IdConfiguracion = long.MinValue;
			//tui_ConfiguracionGrillaEstiloAplicadoDataset dataEA = tui_ConfiguracionGrillaEstiloAplicado.GetList(IdProceso, IdTarea, _grilla.Name, _formulario, long.MinValue);
			//foreach(tui_ConfiguracionGrillaEstiloAplicadoDataset.tui_ConfiguracionGrillaEstiloAplicadoRow row in dataEA.tui_ConfiguracionGrillaEstiloAplicado.Rows)
			//{
				//IdConfiguracion = row.IdConfiguracion;
				tui_ConfiguracionGrillaEstilosCondicionalesDetDataset dataCondDet = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList(IdConfiguracion);
				foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow rowDet in dataCondDet.tui_ConfiguracionGrillaEstilosCondicionalesDet.Rows)
				{
					string ColumnaKey = rowDet.Columna;
					string Condicion = rowDet.Condicion.ToString();
					long IdCondicion = rowDet.IdCondicion;
					Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloGeneral(IdConfiguracion, IdCondicion);
					if(rowDet["ValorColumna"] == System.DBNull.Value || rowDet.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
					{						
						Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();				
						switch (Condicion )
						{				
							case ">" :
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;					
								break;
							case "<" :
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThan;					
								break;
							case "=" :
								condOp = Janus.Windows.GridEX.ConditionOperator.Equal;					
								break;
							case ">=":
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo;
								break;
							case "<=":
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThanOrEqualTo;
								break;
							case "!=":
								condOp = Janus.Windows.GridEX.ConditionOperator.NotEqual;
								break;
							case "like":
								condOp = Janus.Windows.GridEX.ConditionOperator.Contains;
								break;
						}								
						string Valor = rowDet.Valor;
						Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( _grilla.RootTable.Columns[ ColumnaKey ], condOp, Valor);
						cnd.FormatStyle = fs;
						_grilla.RootTable.FormatConditions.Add( cnd );

					}
					else //El valor de comparacion es una colomna
					{
						string ColumnaValorKey = rowDet.ValorColumna;
						Janus.Windows.GridEX.GridEXColumn realColumn = _grilla.RootTable.Columns[ ColumnaKey ];
						ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, GridManagerView.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
						Janus.Windows.GridEX.GridEXColumn valorC = _grilla.RootTable.Columns[ ColumnaValorKey ];
						ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
						ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet detConf = new ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, valorC, mfs, string.Empty);
						_configuracionDet.Add(detConf);
					}
				}

			//}
			if(IdConfiguracion != long.MinValue)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowC = tui_ConfiguracionGrillaEstilosCondicionales.GetByPk(IdConfiguracion);				
				string nombreConf = rowC.Nombre;
				toolTip1.SetToolTip(btnConfGrilla, nombreConf);
			}

		}

		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloGeneral(long IdConfiguracion, long IdCondicion)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) _grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset dataCondDetEstAp = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetList(IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont xmlFont = (mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}


		private bool ObtenerConfiguracionGrillaUsuarios(long IdProceso, long IdTarea, string IdUsuario, long IdConfiguracion)
		{			
			//long IdConfiguracion = long.MinValue;
			bool existeConfiguracion = false;
			//tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset dataEA = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList(IdUsuario, IdProceso, IdTarea, _grilla.Name, _formulario, long.MinValue);
			//foreach(tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row in dataEA.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows)
			//{
				//existeConfiguracion = true;
				//IdConfiguracion = row.IdConfiguracion;
				tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset dataCondDet = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetList(IdUsuario, IdConfiguracion);
				foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowDet in dataCondDet.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows)
				{
					existeConfiguracion = true;
					string ColumnaKey = rowDet.Columna;
					string Condicion = rowDet.Condicion.ToString();
					long IdCondicion = rowDet.IdCondicion;
					Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloUsuario(IdConfiguracion, IdCondicion, IdUsuario);
					if(rowDet["ValorColumna"] == System.DBNull.Value || rowDet.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
					{						
						Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();				
						switch (Condicion )
						{				
							case ">" :
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;					
								break;
							case "<" :
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThan;					
								break;
							case "=" :
								condOp = Janus.Windows.GridEX.ConditionOperator.Equal;					
								break;
							case ">=":
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo;
								break;
							case "<=":
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThanOrEqualTo;
								break;
							case "!=":
								condOp = Janus.Windows.GridEX.ConditionOperator.NotEqual;
								break;
							case "like":
								condOp = Janus.Windows.GridEX.ConditionOperator.Contains;
								break;
						}								
						string Valor = rowDet.Valor;
						Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( _grilla.RootTable.Columns[ ColumnaKey ], condOp, Valor);
						cnd.FormatStyle = fs;
						_grilla.RootTable.FormatConditions.Add( cnd );

					}
					else //El valor de comparacion es una colomna
					{
						string ColumnaValorKey = rowDet.ValorColumna;
						Janus.Windows.GridEX.GridEXColumn realColumn = _grilla.RootTable.Columns[ ColumnaKey ];
						ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, GridManagerView.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
						Janus.Windows.GridEX.GridEXColumn valorC = _grilla.RootTable.Columns[ ColumnaValorKey ];
						ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
						ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet detConf = new ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, valorC, mfs, string.Empty);
						_configuracionDet.Add(detConf);
					}
				}

			//}
			if(existeConfiguracion)
			{
                tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowC = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByPk(IdUsuario, IdConfiguracion);				
                string nombreConf = rowC.Nombre;
				toolTip1.SetToolTip(btnConfGrilla, nombreConf);
			}
			return existeConfiguracion;
		}

		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloUsuario(long IdConfiguracion, long IdCondicion, string IdUsuario)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) _grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset dataCondDetEstAp = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList(IdUsuario, IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont xmlFont = (mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}


		private bool ObtenerConfiguracionGrillaPerfiles(long IdProceso, long IdTarea, long IdPerfil, long IdConfiguracion)
		{
			bool existeConfiguracion = false;
			//long IdConfiguracion = long.MinValue;
			//tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset dataEA = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList(IdPerfil, IdProceso, IdTarea, _grilla.Name, _formulario, long.MinValue);
			//foreach(tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row in dataEA.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows)
			//{
				//existeConfiguracion = true;
				//IdConfiguracion = row.IdConfiguracion;
				tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset dataCondDet = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetList(IdPerfil, IdConfiguracion);
				foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowDet in dataCondDet.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Rows)
				{
					existeConfiguracion = true;
					string ColumnaKey = rowDet.Columna;
					string Condicion = rowDet.Condicion.ToString();
					long IdCondicion = rowDet.IdCondicion;
					Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloPerfil(IdConfiguracion, IdCondicion, IdPerfil);
					if(rowDet["ValorColumna"] == System.DBNull.Value || rowDet.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
					{						
						Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();				
						switch (Condicion )
						{				
							case ">" :
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;					
								break;
							case "<" :
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThan;					
								break;
							case "=" :
								condOp = Janus.Windows.GridEX.ConditionOperator.Equal;					
								break;
							case ">=":
								condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo;
								break;
							case "<=":
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThanOrEqualTo;
								break;
							case "!=":
								condOp = Janus.Windows.GridEX.ConditionOperator.NotEqual;
								break;
							case "like":
								condOp = Janus.Windows.GridEX.ConditionOperator.Contains;
								break;
						}								
						string Valor = rowDet.Valor;
						Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( _grilla.RootTable.Columns[ ColumnaKey ], condOp, Valor);
						cnd.FormatStyle = fs;
						_grilla.RootTable.FormatConditions.Add( cnd );

					}
					else //El valor de comparacion es una colomna
					{
						string ColumnaValorKey = rowDet.ValorColumna;
						Janus.Windows.GridEX.GridEXColumn realColumn = _grilla.RootTable.Columns[ ColumnaKey ];
						ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, GridManagerView.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
						Janus.Windows.GridEX.GridEXColumn valorC = _grilla.RootTable.Columns[ ColumnaValorKey ];
						ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
						ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet detConf = new ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, valorC, mfs, string.Empty);
						_configuracionDet.Add(detConf);
					}
				}

			//}
			if(existeConfiguracion)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowC = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetByPk(IdPerfil, IdConfiguracion);				
				string nombreConf = rowC.Nombre;
				toolTip1.SetToolTip(btnConfGrilla, nombreConf);
			}
			return existeConfiguracion;
		}

		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloPerfil(long IdConfiguracion, long IdCondicion, long IdPerfil)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) _grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset dataCondDetEstAp = businessrules.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetList(IdPerfil, IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont xmlFont = (mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}

		#endregion

	}
}
