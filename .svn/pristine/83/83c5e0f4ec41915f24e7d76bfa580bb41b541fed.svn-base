using System;
using mz.erp.ui.controllers;
using System.Collections;
using System.Text;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.controls;
using mz.erp.businessrules;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de GridManagerJanus.
	/// </summary>
	public class GridManagerJanus: IGridManager
	{
		public GridManagerJanus(Janus.Windows.GridEX.GridEX grilla)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_grilla = grilla;
		}
		private ArrayList _agrupamiento=new ArrayList();
		private Janus.Windows.GridEX.GridEX _grilla;

		#region Miembros de IGridManager
		
		public void ConfigureGrid(string ProcessName, string TaskName, GridVariablesLoader loader)
		{				
			/*Lo primero q debe hacer este metodo es crear el Layout*/
			string layout = this.GetLayout(_grilla.Name, ProcessName, TaskName);
			_grilla.LayoutData = layout;
			ConfigureGrid_Cont(loader);
		}
		public void ConfigureGrid(string ProcessName, string TaskName, GridVariablesLoader loader, string Formulario)
		{				
			string LayoutVacio = "<GridEXLayoutData> <HeaderFormatStyle><FontBold>True</FontBold><PredefinedStyle>HeaderFormatStyle</PredefinedStyle><TextAlignment>Center</TextAlignment>\r\n    </HeaderFormatStyle> <RootTable><Columns Collection=\"true\"></Columns><GroupCondition ID=\"\" /></RootTable></GridEXLayoutData>";
			/*Lo primero q debe hacer este metodo es crear el Layout*/
			string layout = this.GetLayout(_grilla.Name, ProcessName, TaskName);
			if (layout == "") 
			{	
				layout = this.GetLayout(_grilla.Name, null, null, Formulario);			
				if (layout == "")
					layout = LayoutVacio;	
				else
					_grilla.LayoutData = layout;
			}		
			else
				_grilla.LayoutData = layout;
			ConfigureGrid_Cont(loader);						
		}
		private void ConfigureGrid_Cont(GridVariablesLoader loader)
		{
			if(loader.AllowEdit)
				_grilla.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			else
				_grilla.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			_grilla.AutomaticSort = false;
			_grilla.GroupByBoxVisible = loader.AllowGroup;
			if (this._grilla.RootTable != null)
				this._grilla.RootTable.Groups.Clear();
			//Deberia ver si ya no tiene grupos el sr, sino tiene cargo los default
			//ArrayList lista = mz.erp.systemframework.Util.Parse(loader.DefaultGroups,",");
			//ArrayList lista=mz.erp.systemframework.Util.Parse("Numero",",");
			ArrayList lista=new ArrayList();
			if( this.Agrupamiento.Count==0)
				lista= mz.erp.systemframework.Util.Parse(loader.DefaultGroups,",");
			else lista=Agrupamiento;
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{
					this._grilla.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this._grilla.RootTable.Columns[str]));
				}
			}
			lista = mz.erp.systemframework.Util.Parse(loader.TotalGroups,",");
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{													
					this._grilla.RootTable.Columns[str].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;			
					this._grilla.RootTable.Columns[str].TotalFormatMode = Janus.Windows.GridEX.FormatMode.UseStringFormat;
					this._grilla.RootTable.Columns[str].TotalFormatString = "{0:#0.00}";					
				}
			}
			lista = mz.erp.systemframework.Util.Parse(loader.TotalGroupsCount,",");
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{													
					this._grilla.RootTable.Columns[str].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Count;			
				}
			}

			if (loader.AllowTotalGroup)
				this._grilla.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
			else
				this._grilla.GroupTotals = Janus.Windows.GridEX.GroupTotals.Never;

			try 
			{
				this._grilla.CollapseGroups();
			}
			catch{}
				
			if(loader.AllowTotalGrid)
			{
				this._grilla.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
				
				
			}
			if (loader.AllowFilter)
				this._grilla.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			else 
				this._grilla.FilterMode = Janus.Windows.GridEX.FilterMode.None;
			_grilla.AutomaticSort = loader.AllowOrder;
            //Cristian tarea 869
            _grilla.RecordNavigator = loader.AllowVisualizationCantRows; //Matias 20101021 - Tarea 898 - INDIRECTA - comentado por Matias para que compile el ERP (falta subir, a Cristian, la clase GridVariablesLoader con el nuevo metodo)
            //Fin tarea 869
		}

		public void SetValue(string ColumnName, object Value, string Condition)
		{
			//Queda pendiente la implementación del uso del parámetro Condition
			if (ExistsColumn(ColumnName) )
			{
				foreach (Janus.Windows.GridEX.GridEXRow row in _grilla.GetRows() )
				{									
					row.BeginEdit();
					row.Cells[ColumnName].Value = Value;
					row.EndEdit();				
				}						
			}
			_grilla.Refresh();

		}
		public void InvertValue(string ColumnName)
		{			
			if (ExistsColumn(ColumnName) )
			{
				foreach (Janus.Windows.GridEX.GridEXRow row in _grilla.GetRows() )
				{				
					row.BeginEdit();
					row.Cells[ColumnName].Value = ! Convert.ToBoolean(row.Cells[ColumnName].Value);
					row.EndEdit();				
				}
			}
		}


		public bool ExistsColumn(string ColumnName) 
		{			
			bool result = false;
			if (_grilla.CurrentTable != null && _grilla.CurrentTable.Columns.Count > 0)  
			{
				foreach (Janus.Windows.GridEX.GridEXColumn column in _grilla.CurrentTable.Columns)
				{
					if (column.Key == ColumnName)
						result = true;
				}
			}
			
			return result;
		}



		public ArrayList GetLayoutProperties(string ExcludedColumns)
		{
			ArrayList result =  new ArrayList();
            //German 20100923 - Tarea 842
            ExcludedColumns = ExcludedColumns + ",CodigoNumericoInterno";
            //Fin German 20100923 - Tarea 842
			ArrayList excludedColumnsArrayList = mz.erp.systemframework.Util.Parse(ExcludedColumns, ",");
			if(_grilla.RootTable != null)
			{
				foreach(Janus.Windows.GridEX.GridEXColumn col in _grilla.RootTable.Columns)
				{

					if(!excludedColumnsArrayList.Contains(col.Key))
					{
						GridLayoutPropertiesJanus aux = new GridLayoutPropertiesJanus();
						aux.ColumnName = col.Key;
						aux.ColumnCaption = col.Caption;
						aux.Visible = col.Visible;
						aux.Alignment = PropertiesTypesJanus.GetInstance().GetAligmentMappingGridExJanusToCommon(col.TextAlignment);
						aux.EditType = PropertiesTypesJanus.GetInstance().GetEditTypeMappingGridExJanusToCommon(col.EditType);
						aux.Format = col.FormatString;
						aux.MaxLines = col.MaxLines;
						aux.Order = col.Position;
						aux.Type = PropertiesTypesJanus.GetInstance().GetColumnTypeMappingGridExJanusToCommon(col.ColumnType);
						aux.Width = col.Width;
						aux.WordWrap = col.WordWrap;
						
						PropertiesColumn c = new PropertiesColumn();
						c.ColumnName = aux.ColumnName;
						c.ColumnCaption = aux.ColumnCaption;				
						c.Order = aux.Order;
						//Mio Vivi
						Janus.Windows.GridEX.GridEXGroup geg=col.Group;
						//Si se uso para agrupar entonces le pongo el lugar dentro del agrupamiento
						if (geg !=null)
							c.OrderGroup= geg.Index;
						c.Alignment = PropertiesTypesJanus.GetInstance().GetAligmentMappingCommonToSave(aux.Alignment);
						c.Format = aux.Format;
						c.Type = PropertiesTypesJanus.GetInstance().GetColumnTypeMappingCommonToSave(aux.Type);
						c.EditType = PropertiesTypesJanus.GetInstance().GetEditTypeMappingCommonToSave(aux.EditType);
						c.MaxLines = aux.MaxLines;
						c.Width = aux.Width;
						c.WordWrap = aux.WordWrap;
						c.Visible = aux.Visible;
						result.Add(c);
					}
				}
			}
			return result;
		}
	
		public void SetLayoutProperties(ArrayList GridLayoutProperties)
		{
			if(_grilla.RootTable != null)
			{
				foreach(PropertiesColumn aux in GridLayoutProperties)
				{
					Janus.Windows.GridEX.GridEXColumn col = _grilla.RootTable.Columns[aux.ColumnName];
					col.Caption = aux.ColumnCaption ;
					col.Visible = aux.Visible ;
					col.TextAlignment = PropertiesTypesJanus.GetInstance().GetAligmentMappingCommonToGridExJanus(aux.Alignment);
					col.EditType = PropertiesTypesJanus.GetInstance().GetEditTypeMappingCommonToGridExJanus(aux.EditType);
					col.FormatString = aux.Format;
					col.MaxLines = aux.MaxLines;
					col.Position = aux.Order;
					//Mio Vivi
					//Janus.Windows.GridEX.GridEXGroup geg = new Janus.Windows.GridEX.GridEXGroup(
					//col.Group=aux. ;
					col.ColumnType = PropertiesTypesJanus.GetInstance().GetColumnTypeMappingCommonToGridExJanus(aux.Type);
					col.Width = Convert.ToInt32(aux.Width);
					col.WordWrap = aux.WordWrap;
				}
			}

		}

		public void SaveLayoutProperties(ArrayList GridLayoutProperties, string ProcessName, string TaskName, string ExcludedColumns)
		{
			LayoutBuilderJanus.SaveLayout(GridLayoutProperties, ProcessName, TaskName,_grilla.Name);
		}

        //Matias 20101005 - Tarea 898
        // Usado por el boton "Guardar configuracion" del GridManagerView.
        public bool SaveLayoutProperties(ArrayList GridLayoutProperties, string ProcessName, string TaskName, string ExcludedColumns, bool SavePerfil, bool SaveUser, bool ExportSQL, string PathFile)
        {
            return LayoutBuilderJanus.SaveLayout(GridLayoutProperties, ProcessName, TaskName, _grilla.Name, SavePerfil, SaveUser, ExportSQL, PathFile);
        }
        //FinMatias 20101005 - Tarea 898

		#endregion
		#region Variables Publicas
		public ArrayList Agrupamiento
		{
			get{return _agrupamiento;}
			set{_agrupamiento = value;}
		}
		#region Metodos Privados
		#endregion
		private string GetLayout(string GridName, string ProcessName, string TaskName)
		{
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			mz.erp.ui.controllers.GridConfigurationLoader loader = new mz.erp.ui.controllers.GridConfigurationLoader();
            Hashtable columnsProperties = loader.LoadConfiguration(GridName, IdProceso, IdTarea);
			columnsProperties = Reordenar(columnsProperties);
			if (columnsProperties.Count == 0)
			{				
				return "";
			}
			else
				//Armar la lista con las columnas q tengaN ORDENAGRUPAMIENTO
				this.ObtenerAgrupamiento(columnsProperties);
				return LayoutBuilderJanus.GetLayout(columnsProperties);
		}


		//Devuelve el agrupamiento de las columnas
		private void ObtenerAgrupamiento(Hashtable PropertiesColumns)
		{
			ArrayList propiedad=new ArrayList();
			foreach(string columnName in PropertiesColumns.Keys)
			{
				Hashtable properties = (Hashtable) PropertiesColumns[columnName];
				string ordenAgrupamiento= Convert.ToString(properties["OrdenAgrupamiento"]);
				if ((ordenAgrupamiento!=null)&&(ordenAgrupamiento!=""))
				{
					int orden=(Convert.ToInt32 (ordenAgrupamiento));
					if (orden!= -1)
					{
						PropiedadAgrupamiento p=new PropiedadAgrupamiento(columnName,orden);
						propiedad.Add(p);
						//this.Agrupamiento.Insert(orden, columnName);

					}
				}
			}
		propiedad.Sort();
		foreach(PropiedadAgrupamiento p in propiedad){
			this.Agrupamiento.Add(p.Nombre);
		}

		}
		private string GetLayout(string GridName, string ProcessName, string TaskName, string Formulario)
		{
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if (IdTarea == 0)
					IdTarea = long.MinValue;
			mz.erp.ui.controllers.GridConfigurationLoader loader = new mz.erp.ui.controllers.GridConfigurationLoader();
			Hashtable columnsProperties = loader.LoadConfiguration(GridName, IdProceso, IdTarea, Formulario);
			columnsProperties = Reordenar(columnsProperties);
			if (columnsProperties.Count == 0)
				return "";
			else
				//Armar la lista con las columnas q tengaN ORDENAGRUPAMIENTO
				this.ObtenerAgrupamiento(columnsProperties);
				return LayoutBuilderJanus.GetLayout(columnsProperties);

			
		}


		private Hashtable Reordenar(Hashtable columnsProperties)
		{			
			ClassComparer cc = new ClassComparer();			
			foreach(string columnName in columnsProperties.Keys)
			{
				Hashtable properties = (Hashtable) columnsProperties[columnName];				
				cc.Add(columnName, Convert.ToInt64(properties["Orden"]));							
			}					
			cc.SetOrder();			
			/*
			int orden = 0;
			foreach(ItemComparer ic in cc)
			{
				Hashtable Properties = (Hashtable)columnsProperties[ic.Value];
				if(Properties.ContainsKey("Orden"))
				{
					Properties["Orden"] = cc.
					orden++;
				}					
			}*/
			cc.Reset();			
			while ( cc.MoveNext() )
			{	
				ItemComparer ic = (ItemComparer) cc.Current;
				Hashtable Properties = (Hashtable)columnsProperties[ic.Value];
				if(Properties.ContainsKey("Orden"))
				{
					Properties["Orden"] = cc.Index;
				}	
			}
			return columnsProperties;
		}
		#endregion

        //Matias 20100727 - Tarea 21
        public Janus.Windows.GridEX.GridEX Grilla
        {
            get { return _grilla; }
        }
        //Fin Matias
	}


	public class LayoutBuilderJanus
	{
		public static string GetLayout(Hashtable PropertiesColumns)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );	
			
			foreach(string columnName in PropertiesColumns.Keys)
			{
				Hashtable properties = (Hashtable) PropertiesColumns[columnName];
				sb.Append(string.Format(
                    //Matias 20101025 - Tarea 898 - Elimine el TAG <CellStyle> y </CellStyle>. Setean la propiedad Col.CellStyle.TextAligment; es mejor setear Col.TextAligment.
                    //@"<Column{0} ID=""{1}""><Key>{1}</Key><DataMember>{1}</DataMember><Caption>{2}</Caption><Position>{0}</Position><Visible>{6}</Visible><Width>{7}</Width><ColumnType>{3}</ColumnType><EditType>{4}</EditType><FormatString>{5}</FormatString><MaxLines>{9}</MaxLines><WordWrap>{8}</WordWrap><CellStyle><TextAlignment>{10}</TextAlignment></CellStyle></Column{0}>",
                    @"<Column{0} ID=""{1}""><Key>{1}</Key><DataMember>{1}</DataMember><Caption>{2}</Caption><Position>{0}</Position><Visible>{6}</Visible><Width>{7}</Width><ColumnType>{3}</ColumnType><EditType>{4}</EditType><FormatString>{5}</FormatString><MaxLines>{9}</MaxLines><WordWrap>{8}</WordWrap><TextAlignment>{10}</TextAlignment></Column{0}>",
                    //FinMatias 20101025 - Tarea 898
					new object[] 
					{
						GetValue(properties, "Orden"),
						columnName,
						GetValue(properties, "Titulo"),
						GetValue(properties, "TipoColumna"),
						GetValue(properties, "TipoEdicion"),
						GetValue(properties, "Formato"),
						GetValue(properties, "Visible"),
						GetValue(properties, "Ancho"),
						GetValue(properties, "Multilinea"),
						GetValue(properties, "CantidadMaximaLineas"),
						GetValue(properties, "Alineacion")
						
						
					})); 
			}
			sb.Append( LayoutBuilder.GetFooter() );
			string aux = sb.ToString();
			return aux;
		}


		private static string GetValue(Hashtable Properties,  string Property)
		{
			switch(Property)
			{
				case "Orden": return Convert.ToString(Properties[Property]);
					break;
				case "OrdenAgrupamiento": return Convert.ToString(Properties[Property]);
					break;

				case "Nombre": return Convert.ToString(Properties[Property]);
					break;
				case "Titulo":return Convert.ToString(Properties[Property]);
					break;
				case "TipoColumna": 
				{		
					string tipoDeColumna = string.Empty;
					if(Properties.ContainsKey(Property))tipoDeColumna = Convert.ToString(Properties[Property]);
					switch(tipoDeColumna)
					{
						case "CasillaDeVerificacion": return Convert.ToString(PropertiesTypesJanus.ColumnTypes.CheckBox);
							break;
						case "CuadroDeTexto": return Convert.ToString(PropertiesTypesJanus.ColumnTypes.Text);
							break;
						case "Imagen": return Convert.ToString(PropertiesTypesJanus.ColumnTypes.Image);
							break;
						case "ImagenYTexto": return Convert.ToString(PropertiesTypesJanus.ColumnTypes.ImageAndText);
							break;
						default: return Convert.ToString(PropertiesTypesJanus.ColumnTypes.Text);
					}
				}
					break;
				case "TipoEdicion":
				{		
					string tipoDeEdicion = string.Empty;
					if(Properties.ContainsKey(Property))tipoDeEdicion = Convert.ToString(Properties[Property]);
					switch(tipoDeEdicion)
					{
						case "CasillaDeVerificacion": return Convert.ToString(PropertiesTypesJanus.EditType.CheckBox);
							break;
						case "CuadroDeTexto": return Convert.ToString(PropertiesTypesJanus.EditType.TextBox);
							break;
						case "NoEditable": return Convert.ToString(PropertiesTypesJanus.EditType.NoEdit);
							break;
						case "CalendarioCombo": return Convert.ToString(PropertiesTypesJanus.EditType.CalendarCombo);
							break;
						case "CalendarioDropDown": return Convert.ToString(PropertiesTypesJanus.EditType.CalendarDropDown);
							break;
						case "ComboBox": return Convert.ToString(PropertiesTypesJanus.EditType.Combo);
							break;
						case "Personalizado": return Convert.ToString(PropertiesTypesJanus.EditType.Custom);
							break;
						default: return Convert.ToString(PropertiesTypesJanus.EditType.TextBox);
					}
				}
					break;
				case "Formato":
				{		
					string formato = string.Empty;
					if(Properties.ContainsKey(Property))formato = Convert.ToString(Properties[Property]);
					switch(formato)
					{
						case "Moneda": return "c";						
							break;
						case "Porcentaje": return "p";
							break;
						case "Fecha": return "d";
							break;
						case "Fecha corta": return "dd/MM/yyyy";
							break;
						case "Entero": return "0";
							break;
						case "Decimal": return "0.00";
							break;
						case "Decimal+-0": return "#,##0.00;#,##0.00;0.00";
                        //Matias 20101025 - Tarea 898
                            break;
                        case "Default": return "f";
                            break;
                        //FinMatias
                        default: return string.Empty;
					}
				}
					break;
				case "Visible": return Convert.ToString(Properties[Property]);
					break;
				case "Ancho": 
				{
					decimal ancho = 100;
					if(Properties.ContainsKey(Property))ancho = Convert.ToDecimal(Properties[Property]);
					return Convert.ToString(ancho);
				}
					break;
				case "Multilinea": 
				{
					bool multilinea = false;
					if(Properties.ContainsKey(Property))multilinea = Convert.ToBoolean(Properties[Property]);
					return Convert.ToString(multilinea);
				}
					break;
				case "CantidadMaximaLineas": 
				{
					int cantMaxLineas = 4;
					if(Properties.ContainsKey(Property))cantMaxLineas = Convert.ToInt32(Properties[Property]);
					return Convert.ToString(cantMaxLineas);
				}
					break;
				case "Alineacion":
				{		
					string Alineacion = string.Empty;
					if(Properties.ContainsKey(Property))Alineacion = Convert.ToString(Properties[Property]);
					switch(Alineacion)
					{
						case "Izquierda": return Convert.ToString(PropertiesTypesJanus.Aligment.Near);
							break;
						case "Derecha": return Convert.ToString(PropertiesTypesJanus.Aligment.Far);
							break;
						case "Centrada": return Convert.ToString(PropertiesTypesJanus.Aligment.Center);
							break;
						default: return Convert.ToString(PropertiesTypesJanus.Aligment.Near);
					}
				}
				case "TipoEdicionFiltro":
					string tipoDeEdicionFiltro = string.Empty;
					if(Properties.ContainsKey(Property))tipoDeEdicionFiltro = Convert.ToString(Properties[Property]);
				switch(tipoDeEdicionFiltro)
				{
						
					case "CuadroDeTexto": return Convert.ToString(PropertiesTypesJanus.FilterEditType.TextBox);
						break;
					case "NoEditable": return Convert.ToString(PropertiesTypesJanus.FilterEditType.NoEdit);
						break;
					case "DropDownList": return Convert.ToString(PropertiesTypesJanus.FilterEditType.DropDownList);
						break;
					case "ComboBox": return Convert.ToString(PropertiesTypesJanus.FilterEditType.Combo);
						break;
					case "IgualTipoEdicion": return Convert.ToString(PropertiesTypesJanus.FilterEditType.SameAsEditType);
						break;
					default: return Convert.ToString(PropertiesTypesJanus.FilterEditType.TextBox);
				}
					break;
				default: return string.Empty;
			}
		}
		
		private static string GetHeader()
		{
			return @"<GridEXLayoutData> <HeaderFormatStyle><FontBold>True</FontBold><PredefinedStyle>HeaderFormatStyle</PredefinedStyle><TextAlignment>Center</TextAlignment></HeaderFormatStyle> <RootTable><Columns Collection=""true"">";
		}

		private static string GetFooter()
		{
			return @"</Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>";
		}

		public static void SaveLayout(ArrayList GridLayoutProperties, string ProcessName, string TaskName, string GridName)
		{			
			PropertiesColumnsCollection _columnsProperties = new PropertiesColumnsCollection();
			foreach(PropertiesColumn g in GridLayoutProperties )
			{
				/*
				PropertiesColumn c = new PropertiesColumn();
				c.ColumnName = g.ColumnName;
				c.ColumnCaption = g.ColumnCaption;				
				c.Order = g.Order;
				c.Alignment = PropertiesTypesJanus.GetInstance().GetAligmentMappingCommonToSave(g.Alignment);
				c.Format = g.Format;
				c.Type = PropertiesTypesJanus.GetInstance().GetColumnTypeMappingCommonToSave(g.Type);
				c.EditType = PropertiesTypesJanus.GetInstance().GetEditTypeMappingCommonToSave(g.EditType);
				c.MaxLines = g.MaxLines;
				c.Width = g.Width;
				c.WordWrap = g.WordWrap;
				c.Visible = g.Visible
				*/
				_columnsProperties.AddItem(g);
			}
			_columnsProperties.SaveToUser(ProcessName, TaskName, GridName);

			
		}

        //Matias 20101005 - Tarea 898
        // Utilizado por el boton "Guardar Configuracion" de la GridManagerView.
        // Solo tendrán acceso a esta opción los usuarios de perfiles superiores (Admin, Implementadores y a definir).
        public static bool SaveLayout(ArrayList GridLayoutProperties, string ProcessName, string TaskName, string GridName, bool SavePerfil, bool SaveUser, bool ExportSQL, string PathFile)
        {
            PropertiesColumnsCollection _columnsProperties = new PropertiesColumnsCollection();
            foreach (PropertiesColumn g in GridLayoutProperties)
                _columnsProperties.AddItem(g);

            bool resulA = true;
            bool resulB = true;
            bool resulC = true;
            resulA = _columnsProperties.SaveToDefaultGrid(ProcessName, TaskName, GridName, ExportSQL, PathFile);
            if (SavePerfil)
                resulB = _columnsProperties.SaveToPerfil(ProcessName, TaskName, GridName, ExportSQL, PathFile);
            if (SaveUser)
                resulC = _columnsProperties.SaveToUser(ProcessName, TaskName, GridName, ExportSQL, PathFile);

            return (resulA && resulB && resulC); // False es posible SII hubo un error al momento de exportar los datos!
        }

        //FinMatias 20101005 - Tarea 898

	}

	public  class PropertiesTypesJanus
	{
		private static PropertiesTypesJanus _instance = null;
		private PropertiesTypesJanus()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static PropertiesTypesJanus GetInstance()
		{
			if(_instance != null)
				return _instance;
			else
			{
				_instance = new PropertiesTypesJanus();
				_instance.Initialize();
				return _instance;
			}
		}

		private void Initialize()
		{
			InitializeMappingAligment();
			InitializeMappingColumnTypes();
			InitializeMappingEditType();
		}

	

		private void InitializeMappingAligment()
		{
			_aligmentJanusMapping.Add(PropertiesTypesJanus.Aligment.Center, Janus.Windows.GridEX.TextAlignment.Center);
			_aligmentJanusMapping.Add(PropertiesTypesJanus.Aligment.Far, Janus.Windows.GridEX.TextAlignment.Far);
			_aligmentJanusMapping.Add(PropertiesTypesJanus.Aligment.Near, Janus.Windows.GridEX.TextAlignment.Near);
			_aligmentJanusMapping.Add(Janus.Windows.GridEX.TextAlignment.Center, PropertiesTypesJanus.Aligment.Center);
			_aligmentJanusMapping.Add(Janus.Windows.GridEX.TextAlignment.Far, PropertiesTypesJanus.Aligment.Far);
			_aligmentJanusMapping.Add(Janus.Windows.GridEX.TextAlignment.Near, PropertiesTypesJanus.Aligment.Near);

			_aligmentMapping.Add(PropertiesTypesJanus.Aligment.Center, "Centrada");
			_aligmentMapping.Add(PropertiesTypesJanus.Aligment.Far, "Derecha");
			_aligmentMapping.Add(PropertiesTypesJanus.Aligment.Near, "Izquierda");
			_aligmentMapping.Add( "Centrada", PropertiesTypesJanus.Aligment.Center);
			_aligmentMapping.Add( "Derecha", PropertiesTypesJanus.Aligment.Far);
			_aligmentMapping.Add( "Izquierda",PropertiesTypesJanus.Aligment.Near);


			_aligmentCommonToGridEXMapping.Add("Centrada", Janus.Windows.GridEX.TextAlignment.Center);
			_aligmentCommonToGridEXMapping.Add("Derecha", Janus.Windows.GridEX.TextAlignment.Far);
			_aligmentCommonToGridEXMapping.Add("Izquierda", Janus.Windows.GridEX.TextAlignment.Near);
			_aligmentCommonToGridEXMapping.Add(Janus.Windows.GridEX.TextAlignment.Center, "Centrada");
			_aligmentCommonToGridEXMapping.Add(Janus.Windows.GridEX.TextAlignment.Far, "Derecha");
			_aligmentCommonToGridEXMapping.Add(Janus.Windows.GridEX.TextAlignment.Near, "Izquierda");


		}


			
	
		private void InitializeMappingEditType()
		{
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.CalendarCombo, Janus.Windows.GridEX.EditType.CalendarCombo);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.CalendarDropDown, Janus.Windows.GridEX.EditType.CalendarDropDown);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.CheckBox, Janus.Windows.GridEX.EditType.CheckBox);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.Combo, Janus.Windows.GridEX.EditType.Combo);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.Custom, Janus.Windows.GridEX.EditType.Custom);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.NoEdit, Janus.Windows.GridEX.EditType.NoEdit);
			_editTypeJanusMapping.Add(PropertiesTypesJanus.EditType.TextBox, Janus.Windows.GridEX.EditType.TextBox);

			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.CalendarCombo, PropertiesTypesJanus.EditType.CalendarCombo);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.CalendarDropDown, PropertiesTypesJanus.EditType.CalendarDropDown);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.CheckBox, PropertiesTypesJanus.EditType.CheckBox);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.Combo, PropertiesTypesJanus.EditType.Combo);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.Custom, PropertiesTypesJanus.EditType.Custom);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.NoEdit, PropertiesTypesJanus.EditType.NoEdit);
			_editTypeJanusMapping.Add(Janus.Windows.GridEX.EditType.TextBox, PropertiesTypesJanus.EditType.TextBox);


			_editTypeMapping.Add(PropertiesTypesJanus.EditType.CalendarCombo, "CalendarioCombo");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.CalendarDropDown, "CalendarioDropDown");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.CheckBox, "CasillaDeVerificacion");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.Combo, "ComboBox");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.Custom, "Personalizado");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.NoEdit, "NoEditable");
			_editTypeMapping.Add(PropertiesTypesJanus.EditType.TextBox, "CuadroDeTexto");

			_editTypeMapping.Add("CalendarioCombo", PropertiesTypesJanus.EditType.CalendarCombo);
			_editTypeMapping.Add("CalendarioDropDown", PropertiesTypesJanus.EditType.CalendarDropDown);
			_editTypeMapping.Add("CasillaDeVerificacion", PropertiesTypesJanus.EditType.CheckBox);
			_editTypeMapping.Add("ComboBox", PropertiesTypesJanus.EditType.Combo);
			_editTypeMapping.Add("Personalizado", PropertiesTypesJanus.EditType.Custom);
			_editTypeMapping.Add("NoEditable", PropertiesTypesJanus.EditType.NoEdit);
			_editTypeMapping.Add("CuadroDeTexto", PropertiesTypesJanus.EditType.TextBox);


			_editTypeCommonToGridEXMapping.Add("CalendarioCombo", Janus.Windows.GridEX.EditType.CalendarCombo);
			_editTypeCommonToGridEXMapping.Add("CalendarioDropDown", Janus.Windows.GridEX.EditType.CalendarDropDown);
			_editTypeCommonToGridEXMapping.Add("CasillaDeVerificacion", Janus.Windows.GridEX.EditType.CheckBox);
			_editTypeCommonToGridEXMapping.Add("ComboBox", Janus.Windows.GridEX.EditType.Combo);
			_editTypeCommonToGridEXMapping.Add("Personalizado", Janus.Windows.GridEX.EditType.Custom);
			_editTypeCommonToGridEXMapping.Add("NoEditable", Janus.Windows.GridEX.EditType.NoEdit);
			_editTypeCommonToGridEXMapping.Add("CuadroDeTexto", Janus.Windows.GridEX.EditType.TextBox);

			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.CalendarCombo, "CalendarioCombo");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.CalendarDropDown, "CalendarioDropDown");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.CheckBox, "CasillaDeVerificacion");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.Combo, "ComboBox");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.Custom, "Personalizado");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.NoEdit, "NoEditable");
			_editTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.EditType.TextBox, "CuadroDeTexto");


		}

		
			
			

		private void InitializeMappingColumnTypes()
		{
			_columnTypeJanusMapping.Add(PropertiesTypesJanus.ColumnTypes.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox);
			_columnTypeJanusMapping.Add(PropertiesTypesJanus.ColumnTypes.Image, Janus.Windows.GridEX.ColumnType.Image);
			_columnTypeJanusMapping.Add(PropertiesTypesJanus.ColumnTypes.ImageAndText, Janus.Windows.GridEX.ColumnType.ImageAndText);
			_columnTypeJanusMapping.Add(PropertiesTypesJanus.ColumnTypes.Text, Janus.Windows.GridEX.ColumnType.Text);

			_columnTypeJanusMapping.Add(Janus.Windows.GridEX.ColumnType.CheckBox, PropertiesTypesJanus.ColumnTypes.CheckBox);
			_columnTypeJanusMapping.Add(Janus.Windows.GridEX.ColumnType.Image, PropertiesTypesJanus.ColumnTypes.Image);
			_columnTypeJanusMapping.Add(Janus.Windows.GridEX.ColumnType.ImageAndText, PropertiesTypesJanus.ColumnTypes.ImageAndText);
			_columnTypeJanusMapping.Add(Janus.Windows.GridEX.ColumnType.Text, PropertiesTypesJanus.ColumnTypes.Text);


			_columnTypeMapping.Add(PropertiesTypesJanus.ColumnTypes.CheckBox,"CasillaDeVerificacion");
			_columnTypeMapping.Add(PropertiesTypesJanus.ColumnTypes.Image,"Imagen");
			_columnTypeMapping.Add(PropertiesTypesJanus.ColumnTypes.ImageAndText,"ImagenYTexto");
			_columnTypeMapping.Add(PropertiesTypesJanus.ColumnTypes.Text,"CuadroDeTexto");


			_columnTypeMapping.Add("CasillaDeVerificacion", PropertiesTypesJanus.ColumnTypes.CheckBox);
			_columnTypeMapping.Add("Imagen", PropertiesTypesJanus.ColumnTypes.Image);
			_columnTypeMapping.Add("ImagenYTexto", PropertiesTypesJanus.ColumnTypes.ImageAndText);
			_columnTypeMapping.Add("CuadroDeTexto", PropertiesTypesJanus.ColumnTypes.Text);


			_columnTypeCommonToGridEXMapping.Add("CasillaDeVerificacion", Janus.Windows.GridEX.ColumnType.CheckBox);
			_columnTypeCommonToGridEXMapping.Add("Imagen", Janus.Windows.GridEX.ColumnType.Image);
			_columnTypeCommonToGridEXMapping.Add("ImagenYTexto", Janus.Windows.GridEX.ColumnType.ImageAndText);
			_columnTypeCommonToGridEXMapping.Add("CuadroDeTexto", Janus.Windows.GridEX.ColumnType.Text);

			_columnTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.ColumnType.CheckBox, "CasillaDeVerificacion");
			_columnTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.ColumnType.Image, "Imagen");
			_columnTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.ColumnType.ImageAndText, "ImagenYTexto");
			_columnTypeCommonToGridEXMapping.Add(Janus.Windows.GridEX.ColumnType.Text, "CuadroDeTexto");

		}


		private void InitializeMappingFilterEditType()
		{
			
			_filterEditTypeJanusMapping.Add(PropertiesTypesJanus.FilterEditType.DropDownList, Janus.Windows.GridEX.FilterEditType.DropDownList);
			_filterEditTypeJanusMapping.Add(PropertiesTypesJanus.FilterEditType.SameAsEditType, Janus.Windows.GridEX.FilterEditType.SameAsEditType);
			_filterEditTypeJanusMapping.Add(PropertiesTypesJanus.FilterEditType.Combo, Janus.Windows.GridEX.FilterEditType.Combo);
			_filterEditTypeJanusMapping.Add(PropertiesTypesJanus.FilterEditType.NoEdit, Janus.Windows.GridEX.FilterEditType.NoEdit);
			_filterEditTypeJanusMapping.Add(PropertiesTypesJanus.FilterEditType.TextBox, Janus.Windows.GridEX.FilterEditType.TextBox);

			_filterEditTypeJanusMapping.Add( Janus.Windows.GridEX.FilterEditType.DropDownList, PropertiesTypesJanus.FilterEditType.DropDownList);
			_filterEditTypeJanusMapping.Add( Janus.Windows.GridEX.FilterEditType.SameAsEditType ,PropertiesTypesJanus.FilterEditType.SameAsEditType);
			_filterEditTypeJanusMapping.Add( Janus.Windows.GridEX.FilterEditType.Combo, PropertiesTypesJanus.FilterEditType.Combo);
			_filterEditTypeJanusMapping.Add( Janus.Windows.GridEX.FilterEditType.NoEdit, PropertiesTypesJanus.FilterEditType.NoEdit);
			_filterEditTypeJanusMapping.Add( Janus.Windows.GridEX.FilterEditType.TextBox, PropertiesTypesJanus.FilterEditType.TextBox);

			_filterEditTypeMapping.Add(PropertiesTypesJanus.FilterEditType.DropDownList, "ListaDesplegable");
			_filterEditTypeMapping.Add(PropertiesTypesJanus.FilterEditType.SameAsEditType, "IgualTipoEdicion");
			_filterEditTypeMapping.Add(PropertiesTypesJanus.FilterEditType.Combo, "ComboBox");
			_filterEditTypeMapping.Add(PropertiesTypesJanus.FilterEditType.NoEdit, "NoEditable");
			_filterEditTypeMapping.Add(PropertiesTypesJanus.FilterEditType.TextBox, "CuadroDeTexto");

			_filterEditTypeMapping.Add( "ListaDesplegable", PropertiesTypesJanus.FilterEditType.DropDownList);
			_filterEditTypeMapping.Add( "IgualTipoEdicion", PropertiesTypesJanus.FilterEditType.SameAsEditType);
			_filterEditTypeMapping.Add( "ComboBox", PropertiesTypesJanus.FilterEditType.Combo);
			_filterEditTypeMapping.Add( "NoEditable", PropertiesTypesJanus.FilterEditType.NoEdit);
			_filterEditTypeMapping.Add( "CuadroDeTexto", PropertiesTypesJanus.FilterEditType.TextBox);

			_filterEditTypeCommonToGridEXMapping.Add("ListaDesplegable", Janus.Windows.GridEX.FilterEditType.DropDownList);
			_filterEditTypeCommonToGridEXMapping.Add("IgualTipoEdicion", Janus.Windows.GridEX.FilterEditType.SameAsEditType);
			_filterEditTypeCommonToGridEXMapping.Add("ComboBox", Janus.Windows.GridEX.FilterEditType.Combo);
			_filterEditTypeCommonToGridEXMapping.Add("NoEditable", Janus.Windows.GridEX.FilterEditType.NoEdit);
			_filterEditTypeCommonToGridEXMapping.Add("CuadroDeTexto", Janus.Windows.GridEX.FilterEditType.TextBox);

			_filterEditTypeCommonToGridEXMapping.Add( Janus.Windows.GridEX.FilterEditType.DropDownList, "ListaDesplegable");
			_filterEditTypeCommonToGridEXMapping.Add( Janus.Windows.GridEX.FilterEditType.SameAsEditType ,"IgualTipoEdicion");
			_filterEditTypeCommonToGridEXMapping.Add( Janus.Windows.GridEX.FilterEditType.Combo, "ComboBox");
			_filterEditTypeCommonToGridEXMapping.Add( Janus.Windows.GridEX.FilterEditType.NoEdit, "NoEditable");
			_filterEditTypeCommonToGridEXMapping.Add( Janus.Windows.GridEX.FilterEditType.TextBox, "CuadroDeTexto");


		}




		public string GetAligmentMappingCommonToSave(PropertiesTypesJanus.Aligment al)
		{
			if(_aligmentMapping.ContainsKey(al))
				return Convert.ToString(_aligmentMapping[al]);
			else
				return string.Empty;
		}

		public string GetColumnTypeMappingCommonToSave(PropertiesTypesJanus.ColumnTypes al)
		{
			if(_columnTypeMapping.ContainsKey(al))
				return Convert.ToString(_columnTypeMapping[al]);
			else
				return string.Empty;
		}

		public string GetEditTypeMappingCommonToSave(PropertiesTypesJanus.EditType al)
		{
			if(_editTypeMapping.ContainsKey(al))
				return Convert.ToString(_editTypeMapping[al]);
			else
				return string.Empty;
		}

		public string GetFilterEditTypeMappingCommonToSave(PropertiesTypesJanus.FilterEditType al)
		{
			if(_filterEditTypeMapping.ContainsKey(al))
				return Convert.ToString(_filterEditTypeMapping[al]);
			else
				return string.Empty;
		}


		public Janus.Windows.GridEX.TextAlignment GetAligmentMappingCommonToGridExJanus(string al)
		{
			if(_aligmentCommonToGridEXMapping.ContainsKey(al))
				return (Janus.Windows.GridEX.TextAlignment)_aligmentCommonToGridEXMapping[al];
			else
				return Janus.Windows.GridEX.TextAlignment.Near;
		}


		public Janus.Windows.GridEX.ColumnType GetColumnTypeMappingCommonToGridExJanus(string al)
		{
			if(_columnTypeCommonToGridEXMapping.ContainsKey(al))
				return (Janus.Windows.GridEX.ColumnType)_columnTypeCommonToGridEXMapping[al];
			else
				return Janus.Windows.GridEX.ColumnType.Text;
		}

		public Janus.Windows.GridEX.EditType GetEditTypeMappingCommonToGridExJanus(string al)
		{
			if(_editTypeCommonToGridEXMapping.ContainsKey(al))
				return (Janus.Windows.GridEX.EditType)_editTypeCommonToGridEXMapping[al];
			else
				return Janus.Windows.GridEX.EditType.TextBox;
		}


		public Janus.Windows.GridEX.FilterEditType GetFilterEditTypeMappingCommonToGridExJanus(string al)
		{
			if(_filterEditTypeCommonToGridEXMapping.ContainsKey(al))
				return (Janus.Windows.GridEX.FilterEditType)_filterEditTypeCommonToGridEXMapping[al];
			else
				return Janus.Windows.GridEX.FilterEditType.TextBox;
		}

		public PropertiesTypesJanus.Aligment GetAligmentMappingGridExJanusToCommon(Janus.Windows.GridEX.TextAlignment al)
		{
			if(_aligmentJanusMapping.ContainsKey(al))
				return (PropertiesTypesJanus.Aligment)_aligmentJanusMapping[al];
			else
				return PropertiesTypesJanus.Aligment.Near;
		}

		public  PropertiesTypesJanus.ColumnTypes  GetColumnTypeMappingGridExJanusToCommon(Janus.Windows.GridEX.ColumnType al)
		{
			if(_columnTypeJanusMapping.ContainsKey(al))
				return (PropertiesTypesJanus.ColumnTypes )_columnTypeJanusMapping[al];
			else
				return PropertiesTypesJanus.ColumnTypes .Text;
		}

		public  PropertiesTypesJanus.EditType GetEditTypeMappingGridExJanusToCommon(Janus.Windows.GridEX.EditType  al)
		{
			if(_editTypeJanusMapping.ContainsKey(al))
				return (PropertiesTypesJanus.EditType)_editTypeJanusMapping[al];
			else
				return PropertiesTypesJanus.EditType.TextBox;
		}
		

		public  PropertiesTypesJanus.FilterEditType GetFilterEditTypeMappingGridExJanusToCommon(Janus.Windows.GridEX.FilterEditType  al)
		{
			if(_filterEditTypeJanusMapping.ContainsKey(al))
				return (PropertiesTypesJanus.FilterEditType)_filterEditTypeJanusMapping[al];
			else
				return PropertiesTypesJanus.FilterEditType.TextBox;
		}
		
		

		
		private static Hashtable  _aligmentJanusMapping = new Hashtable();
		private static Hashtable  _editTypeJanusMapping = new Hashtable();
		private static Hashtable  _columnTypeJanusMapping = new Hashtable();
		private static Hashtable  _aligmentMapping = new Hashtable();
		private static Hashtable  _editTypeMapping = new Hashtable();
		private static Hashtable  _columnTypeMapping = new Hashtable();
		private static Hashtable _filterEditTypeMapping = new Hashtable();
		private static Hashtable _filterEditTypeJanusMapping = new Hashtable();
		private static Hashtable _aligmentCommonToGridEXMapping = new Hashtable();
		private static Hashtable _columnTypeCommonToGridEXMapping = new Hashtable();
		private static Hashtable _editTypeCommonToGridEXMapping = new Hashtable();
		private static Hashtable _filterEditTypeCommonToGridEXMapping = new Hashtable();

		

		public enum Aligment
		{
			Near,/*Se mapea con Izquierda*/
			Center /*Se mapea con Centrada*/,
			Far /*Se mapea con derecha*/
		}
		

		public enum ColumnTypes
		{
			CheckBox /*Se mapea con CasillaDeVerificacion*/,
			Text/*Se mapea con CuadroDeTexto*/, 
			Image/*Se mapea con Imagen*/,
			ImageAndText/*Se mapea con ImagenYTexto*/
		}

		//Agregar mas
		public enum EditType
		{
			NoEdit /*Se mapea con NoEditable*/,
			CheckBox /*Se mapea con CasillaDeVerificacion*/,
			CalendarCombo/*Se mapea con CalendarioCombo*/,
			CalendarDropDown /*Se Mapea con CalendarioDropDown*/,
			Combo /*Se mapea con ComboBox*/,
			TextBox/*Se mapea con CuadroDeTexto*/,
			Custom /*Se mapea con Personalizado*/
		}

		public enum FilterEditType
		{
			Combo/*Se mapea con ComboBox*/,
			DropDownList/*Se mapea con ListaDesplegable*/,
			NoEdit/*Se mapea con NoEditable*/,
			TextBox/*Se mapea con CuadroDeTexto*/,
			SameAsEditType/*Se mapea con IgualTipoEdicion*/
		}
	}

	public class GridLayoutPropertiesJanus
	{
		#region Constructores
		
		public GridLayoutPropertiesJanus()
		{
		}

		#endregion

		#region Variables Privadas
		
		private string _columnName = string.Empty;
		private string _columnCaption = string.Empty;
		private bool _visible = true;
		private decimal _width = 100;
		private PropertiesTypesJanus.Aligment _alignment = PropertiesTypesJanus.Aligment.Near;
		private PropertiesTypesJanus.EditType _editType = PropertiesTypesJanus.EditType.TextBox;		
		private string _format = string.Empty;
		private bool _wordwrap = false;
		private int _maxLines = 1;
		private int _order = 0;
		private PropertiesTypesJanus.ColumnTypes _type = PropertiesTypesJanus.ColumnTypes.Text;
		private PropertiesTypesJanus.FilterEditType _filterEditType = PropertiesTypesJanus.FilterEditType.TextBox;
	
		#endregion

		#region Variables Publicas

		public string ColumnName
		{
			get{return _columnName;}
			set{_columnName = value;}
		}

		
		public string ColumnCaption
		{
			get{return _columnCaption;}
			set{_columnCaption = value;}
		}

		public bool Visible
		{
			get{return _visible;}
			set{_visible = value;}


		}
		
		public PropertiesTypesJanus.FilterEditType FilterEditType
		{
			get{return _filterEditType;}
			set{_filterEditType = value;}
		}

		public PropertiesTypesJanus.ColumnTypes Type
		{
			get{return _type;}
			set{_type = value;}
		}

		public int Order 
		{
			get{return _order;}
			set{_order = value;}
		}
		
		public int MaxLines 
		{
			get{return _maxLines;}
			set{_maxLines = value;}
		}

		
		public bool WordWrap
		{
			get{return _wordwrap;}
			set{_wordwrap = value;}
		}

		public string Format 
		{
			get{return _format;}
			set{_format = value;}
		}	
		public PropertiesTypesJanus.EditType EditType 
		{
			get{return _editType;}
			set{_editType = value;}
		}		
		public PropertiesTypesJanus.Aligment Alignment 
		{
			get{return _alignment;}
			set{_alignment = value;}
		}	

		public decimal Width
		{
			get{return _width;}
			set{_width = value;}
		}	

		
			
		


		#endregion


	}

	public class PropiedadAgrupamiento:IComparable{

		#region Constructores
		
		public PropiedadAgrupamiento()
		{
		}
		public PropiedadAgrupamiento(string nombre, int valor)
		{
			this._nombre=nombre;
			this._valor=valor;
		}
		#endregion
		#region Variables Privadas
		
		private string _nombre = string.Empty;
		private int _valor = -1;
		#endregion
		
		#region Variables Publicas
		
		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}
		public int Valor
		{
			get{return _valor;}
			set{_valor = value;}
		}

		#endregion

		public int CompareTo(object obj) 
		{
			if(obj is PropiedadAgrupamiento) 
			{
				PropiedadAgrupamiento prop = (PropiedadAgrupamiento) obj;

				return _valor.CompareTo(prop._valor);
			}
        
			throw new ArgumentException("object is not a PropiedadAgrupamiento");    
		}

	}
}
