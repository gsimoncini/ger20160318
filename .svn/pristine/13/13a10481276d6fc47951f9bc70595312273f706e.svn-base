using System;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de GridVariablesLoader.
	/// </summary>
	public class GridVariablesLoader
	{
		#region Variables privadas
		private string _processName;
		private string _taskName;
		#endregion

		#region Propiedades 


		private bool _allowExportExcel = false;
		public bool AllowExportExcel
		{
			get
			{
				return _allowExportExcel;
			}
		}

        //Cristian Tarea 869
        private bool _allowVisualizationCantRows = false;
        public bool AllowVisualizationCantRows
   		{
			get
		    {
				return _allowVisualizationCantRows;
			}
		}
        //Fin Cristian

		private bool _allowSortByMergeAgregateColumn = false;
		public bool AllowSortByMergeAgregateColumn 
		{
			get 
			{
				return _allowSortByMergeAgregateColumn;
			}			
		}

		private bool _allowFilter = false;
		public bool AllowFilter 
		{
			get 
			{
				return _allowFilter;
			}			
		}
		private bool _allowGroup = false;
		public bool AllowGroup
		{
			get 
			{
				return _allowGroup;
			}			
		}
		private string _defaultGroups = "";
		public string DefaultGroups
		{
			get 
			{
				return _defaultGroups;
			}			
		}
		private string _totalGroups = "";
		public string TotalGroups
		{
			get 
			{
				return _totalGroups;
			}			
		}
		private string _totalGroupsCount = "";
		public string TotalGroupsCount
		{
			get 
			{
				return _totalGroupsCount;
			}			
		}
		private bool _allowTotalGroup = false;
		public bool AllowTotalGroup
		{
			get 
			{
				return _allowTotalGroup;
			}			
		}
		private bool _allowTotalGrid = false;
		public bool AllowTotalGrid
		{
			get 
			{
				return _allowTotalGrid;
			}			
		}
		private bool _allowOrder = false;
		public bool AllowOrder
		{
			get 
			{
				return _allowOrder;
			}			
		}
		private bool _allowGroupCollapse = false;
		public bool AllowGroupCollapse
		{
			get 
			{
				return _allowGroupCollapse;
			}			
		}		
		private bool _allowSaveLayout = false;
		public bool AllowSaveLayout
		{
			get 
			{
				return _allowSaveLayout;
			}			
		}
		private bool _allowMarkRow = false;
		public bool AllowMarkRow
		{
			get 
			{
				return _allowMarkRow;
			}			
		}
		private string _nameMarkRow;
		public string NameMarkRow
		{
			get 
			{
				return _nameMarkRow;
			}			
		}
		private bool _allowDefineVisibleColumns = false;
		public bool AllowDefineVisibleColumns
		{
			get 
			{
				return _allowDefineVisibleColumns;
			}			
		}
		
		private bool _allowEdit = false;
		public bool AllowEdit
		{
			get{return _allowEdit;}
		}
		
		private bool _allowGridConfiguration = false;
		public bool AllowGridConfiguration
		{
			get{return _allowGridConfiguration;}
		}

        //Matias 20101005 - Tarea 898
        private bool _allowSaveConfig = false;
        public bool AllowSaveConfig
        {
            get
            {
                return _allowSaveConfig;
            }
        }
        //FinMatias 20101005 - Tarea 898
		#endregion

		public GridVariablesLoader(string ProcessName, string TaskName, bool LevantaVariablesPorGrillaName, string GrillaName)
		{
			_processName = ProcessName;
			_taskName = TaskName;
            //Matias 20101005 - Tarea 898
            //if (LevantaVariablesPorGrillaName)
            //    InitByGrillaName(GrillaName);
            //else
            //    InitByGrillaResultado();
            //German 20101022 - Tarea 903
            /*
            if (Security.PerteneceAPerfilSuperior)
                InitByGrillaParaPerfilSuperior();
            else
            {
            */
            if (LevantaVariablesPorGrillaName)
                InitByGrillaName(GrillaName);
            else
                InitByGrillaResultado();
            if (Security.PerteneceAPerfilSuperior)
                _allowSaveConfig = true;
            //}
            //FinMatias 20101005 - Tarea 898
            //Fin German 20101022 - Tarea 903
		}

		#region Métodos privados
		private void InitByGrillaResultado() 
		{
			_allowFilter = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteFiltro");
			_allowGroup = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteGrupos");
			_defaultGroups = Variables.GetValueString(_processName, _taskName, "GrillaResultado.ListaGruposDefault");
			_totalGroups = Variables.GetValueString(_processName, _taskName, "GrillaResultado.ListaGruposTotalizar");
			_totalGroupsCount = Variables.GetValueString("Momentos."+_taskName+ "." + _processName + ".GrillaResultado." + "ListaGruposCount");
			_allowTotalGroup = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteTotalizarGrupos");
			_allowTotalGrid = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteTotalizarGrilla");		
			_allowOrder = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteOrdenar");		
			_allowGroupCollapse = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteGruposColapsados");		
			_allowSaveLayout = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteGuardarLayout");
            //Cristian Tarea 869
            _allowVisualizationCantRows = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.VisualizarCantidadFilas");
            //Cristian
            _allowMarkRow = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteColumnaMarca");		
            _nameMarkRow = Variables.GetValueString("Momentos."+_taskName+ "." + _processName + ".GrillaResultado." + "NombreColumnaMarca");		
			_allowDefineVisibleColumns = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.HabilitaDefinirColumnasVisibles");				 
			_allowEdit = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteEditar");
			_allowExportExcel = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteExportarAExcel");
			//Muestra el control q permite ordenar por columnas totalizadoras
			_allowSortByMergeAgregateColumn= Variables.GetValueBool(_processName, _taskName, "GrillaResultado.PermiteOrdenarPorTotales");
			_allowGridConfiguration = Variables.GetValueBool(_processName, _taskName, "AllowGridConfiguration");
            _allowSaveConfig = false; //Matias 20101005 - Tarea 898
		}


		private void InitByGrillaName(string GrillaName) 
		{
			// Levanta las variables para una grilla determinada; esto brinda la posibilidad de tener diferentes 
			// configuraciones, para diferentes grillas, dentro de un mismo formulario.
			_allowFilter = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteFiltro");
			_allowGroup = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteGrupos");
			_defaultGroups = Variables.GetValueString(_processName, _taskName, GrillaName + ".ListaGruposDefault");
			_totalGroups = Variables.GetValueString(_processName, _taskName, GrillaName + ".ListaGruposTotalizar");
			_totalGroupsCount = Variables.GetValueString("Momentos."+_taskName+ "." + _processName + GrillaName + ".ListaGruposCount");
			_allowTotalGroup = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteTotalizarGrupos");
			_allowTotalGrid = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteTotalizarGrilla");		
			_allowOrder = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteOrdenar");		
			_allowGroupCollapse = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteGruposColapsados");		
			_allowSaveLayout = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteGuardarLayout");		
			_allowMarkRow = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteColumnaMarca");		
			_nameMarkRow = Variables.GetValueString("Momentos."+_taskName+ "." + _processName + GrillaName +  ".NombreColumnaMarca");		
			_allowDefineVisibleColumns = Variables.GetValueBool(_processName, _taskName, GrillaName + ".HabilitaDefinirColumnasVisibles");				 
            //Cristian Tarea 869
            _allowVisualizationCantRows = Variables.GetValueBool(_processName, _taskName, GrillaName + ".VisualizarCantidadFilas");
            //Cristian
            _allowEdit = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteEditar");
			_allowExportExcel = Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteExportarAExcel");
			//Muestra el control q permite ordenar por columnas totalizadoras
			_allowSortByMergeAgregateColumn= Variables.GetValueBool(_processName, _taskName, GrillaName + ".PermiteOrdenarPorTotales");
			_allowGridConfiguration = Variables.GetValueBool(_processName, _taskName, "AllowGridConfiguration");
            _allowSaveConfig = false; //Matias 20101005 - Tarea 898
		}

        //Matias 20101005 - Tarea 898
        private void InitByGrillaParaPerfilSuperior()
        {
            // Levanta TODAS las variables en true.
            // para perfiles superiores --> funcionalidad total!
            _allowFilter = true;
            _allowGroup = true;
            _defaultGroups = Variables.GetValueString(_processName, _taskName, "GrillaResultado.ListaGruposDefault");
            _totalGroups = Variables.GetValueString(_processName, _taskName, "GrillaResultado.ListaGruposTotalizar");
            _totalGroupsCount = Variables.GetValueString("Momentos." + _taskName + "." + _processName + ".GrillaResultado." + "ListaGruposCount");
            _allowTotalGroup = true;
            _allowTotalGrid = true;
            _allowOrder = true;
            _allowGroupCollapse = true;
            _allowSaveLayout = true;
            _allowMarkRow = true;
            _nameMarkRow = Variables.GetValueString("Momentos." + _taskName + "." + _processName + ".GrillaResultado." + "NombreColumnaMarca");
            _allowDefineVisibleColumns = true;
            _allowEdit = true;
            _allowExportExcel = true;
            //Muestra el control q permite ordenar por columnas totalizadoras
            _allowSortByMergeAgregateColumn = true;
            _allowGridConfiguration = true;
            _allowSaveConfig = true;
        }
        //FinMatias 20101005 - Tarea 898

		#endregion

	}
}
