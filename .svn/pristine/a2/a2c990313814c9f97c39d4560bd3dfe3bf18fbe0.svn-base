using System;
using mz.erp.businessrules;
using System.Data;
using System.Collections;
using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarMovimientosDeCajasController.
	/// </summary>
	public class ConsultarMovimientosDeCajasController:ITaskController
	{
		public ConsultarMovimientosDeCajasController(ConsultarMovimientosDeCajas BrClass)
		{
			_brClass = BrClass;
			Init();
			
		}


		private ConsultarMovimientosDeCajas _brClass;
		private ProcessControllerManager _processManager;
		bool _allowGroup = false;
		private ArrayList _fieldsGroupTotal = new ArrayList();
		private ArrayList _groups = new ArrayList();
		private bool _allowTotalGroupRow = false;
		private bool _allowFilters = false;
		private bool _allowEdit = false;
		private ArrayList _fieldsTotalGrid = new ArrayList(); 
		private bool _allowGridTotal = false;

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{
			return this._processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public string GetTaskName()
		{
			
			return _brClass.GetTaskName();
		}

		#endregion

		#region Custom members
		

		public object SelectedItem
		{
			set{_brClass.SelectedItem = value;}
			get{return _brClass.SelectedItem;}
		}
		

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskAfterExecute;
	
		public event System.EventHandler PorFechasChanged;
		
		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;
		
		

	
		private void Init()
		{
			
			_allowGroup = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.PermiteAgrupar");				
			_fieldsGroupTotal = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.ListaGruposTotalizados"),",");
			_groups = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.ListaGruposDefault"),",");
			_allowTotalGroupRow = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.PermiteTotalizarGrupos");				
			_allowFilters = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.PermiteFiltros");	
			_allowEdit  = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"GrillaResultado.PermiteEditar");	

			_fieldsTotalGrid = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "GrillaResultado.CamposTotalGrilla"),",");
			_allowGridTotal = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "GrillaResultado.PermiteTotalGrilla");

			this._layoutFiltroCajas = this.GetLayoutFiltros();
			this._layoutFiltroTipos = this.GetLayoutFiltros();
			//this._layoutFiltroResultado = this.GetLayoutResultado();
			this._brClass.ObjectHasChanged += new System.EventHandler( this.ListenerObjectHasChanged );
			this._brClass.FechaAperturaChanged+= new System.EventHandler( this.ListenerFechaAperturaChanged );
			this._brClass.FechaCierreChanged+= new System.EventHandler( this.ListenerFechaCierreChanged );
			
		}
		private void ListenerFechaAperturaChanged( object sender, System.EventArgs e)
		{
			if (this.FechaAperturaChanged!=null)
			{
				FechaAperturaChanged(this,e);
			}
		}
		private void ListenerFechaCierreChanged( object sender, System.EventArgs e)
		{
			if (this.FechaCierreChanged!=null)
			{
				FechaCierreChanged(this,e);
			}
		}
		
		
		


		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}
		public DataSet Data
		{
			get {return _brClass.Data; }
		}

		
		public void RefreshData()
		{
			_brClass.RefreshData();
			//_layoutFiltroResultado = this.GetLayoutResultado();
		}
		
		
		#endregion

		
		#region CABECERA, GRUPOS Y FILTROS DE LA GRILLA (FORMATOS PARA TODAS LAS CONSULTAS)


		public bool AllowEdit
		{
			get{return _allowEdit;}
		}


		public bool AllowFilters
		{
			get{return _allowFilters;}
		}

		public bool AllowTotalGroupRow
		{
			get{return _allowTotalGroupRow;}
		}

		public ArrayList Groups
		{
			get{return _groups;}
		}
		
		public bool AllowGroups
		{
			get
			{
				return _allowGroup ;
			}
		}

		public ArrayList FieldsGroupTotal
		{
			get
			{
				return _fieldsGroupTotal;
			}
		}

		public ArrayList FieldsTotalGrid
		{
			get{return _fieldsTotalGrid;}
		}

		public bool AllowGridTotal
		{
			get{return _allowGridTotal;}
		}

		

		public string LeyendaFormulario()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			string _leyenda = _leyenda = Variables.GetValueString(_nombreProceso,_nombreTarea ,"LeyendaFormulario");
			if (_leyenda =="" || _leyenda.Equals(string.Empty) || _leyenda == null)
				_leyenda = _nombreProceso + " " + _nombreTarea;
			return _leyenda;
			
		}

		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}

		/*private string GetLayoutResultado()
		{
			switch (this._brClass.GetTaskName())
			{
				case "ConsultarGastos":
					return LayoutConsultaDeGastos();
				break;
				default:
					return null;
			}
			return null;
		}*/

		


		#endregion

		#region Tildar
		public void TildarEgresos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = items.Auxiliar.Equals("-1"); //en auxiliar se guarda el signo 
		}
		public void TildarIngresos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = items.Auxiliar.Equals("1"); //en auxiliar se guarda el signo 
		}

		public void TildarTodos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = true;
		}
		
		public void TildarNinguno()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = false;
		}
		public void TildarNingunoCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas )
				items.Sel = false;
		}
		public void TildarTodosCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas)
				items.Sel = true;
		}

		#endregion

		#region Filtros


		
		public ArrayList FiltroTDCompTesoreria
		{
			get { return _brClass.FiltroTDCompTesoreria ; }
			set { _brClass.FiltroTDCompTesoreria = value ; }
		}
		public ArrayList FiltroCajas
		{
			get { return _brClass.FiltroCajas ; }
			set { _brClass.FiltroCajas = value ; }
		}
		
		public ArrayList FiltroTipos
		{
			get { return _brClass.FiltroTipos ; }
			set { _brClass.FiltroTipos = value ; }
		}
		
		public bool PorFechas
		{
			get { return _brClass.PorFechas ; }
			set { _brClass.PorFechas = value ; }
		}
		
		
		






		public DateTime FechaApertura
		{
			get { return _brClass.FechaApertura ; }
			set 
			{
				_brClass.FechaApertura = value ;
			}
		}
		public DateTime FechaCierre
		{
			get { return _brClass.FechaCierre ; }
			set 
			{
				_brClass.FechaCierre = value ; 
			}
		}

		private string _layoutFiltroResultado = string.Empty;
		private string _layoutFiltroCajas = string.Empty;
		
		private string _layoutFiltroTipos = string.Empty;
		public string LayoutFiltroCajas
		{
			get { return _layoutFiltroCajas ; }
		}
		
		public string LayoutFiltroTipos
		{
			get { return _layoutFiltroTipos ; }
		}
		public string LayoutFiltroResultado
		{
			get { return _layoutFiltroResultado; }
		}

		
		public bool DetallesVisibles()
		{
			//todo esto se podria pasar a variables de configuracion.
			string _nombreTarea = this._brClass.GetTaskName();
			switch (_nombreTarea)
			{
				case "ConsultarPosicionDeCajaDetallado":
				{
					return true;
				}
			}
			return false;
		}
	
		
		
		#endregion

		#region Layout Filtros
		private string GetLayoutFiltros( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sel", "Sel",  20, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250,  Types.ColumnTypes.Text, Types.EditType.NoEdit ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		/*private string LayoutConsultaDeGastos()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMovimiento", "IdMovimiento", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdValor","IdValor", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Caja", "Caja", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Cuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Subtipo", "SubCuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
			sb.Append( LayoutBuilder.GetRow( i++, "TipoComprobante", "Comprobante", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Medio", "Medio de Pago", 100 ) );			
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", 60 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Apertura","F.Apertura Caja", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cierre","F.Cierre Caja", 60 ) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();
		}*/

		
		
		

		#endregion

		public string GetProcessName()
		{
			return _brClass.GetProcessManagerParent().Process.ProcessName;
		}

		public string GetFormText()
		{
			return _brClass.GetFormText();
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tatea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, bool ordeninverso)
        {
            this._brClass.updateFechas(fechaDesde, ordeninverso);

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian
	}
}
