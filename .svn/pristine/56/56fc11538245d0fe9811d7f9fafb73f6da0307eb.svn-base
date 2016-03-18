using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarVariablesController.
	/// </summary>
	public class ConsultarVariablesController: ITaskController
	{
		#region Constructores
		public ConsultarVariablesController(ConsultarVariables brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarVariables _brClass;
		private string _leyendaFormulario;
		private DataTable _todasLasTareas = null;
		#endregion
	
		#region Propiedades

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		public System.Data.DataTable DataTableResult
		{
			get { return _brClass.Result; }
		}

		public string IdVariable
		{
			get{return _brClass.IdVariable;}
			set{_brClass.IdVariable = value;}
		} 

		public long IdProceso
		{
			get{return _brClass.IdProceso;}
			set
			{
				if(_brClass.IdProceso != value)
				{
					_brClass.IdProceso = value;
                    _tareas = businessrules.twf_Procesos.GetListTareas(value).twf_Tareas;
				}
			}
		} 

		public string ProcesoSeleccionado
		{
			get{return _brClass.ProcesoSeleccionado;}
			set{_brClass.ProcesoSeleccionado = value;}
		} 

		public bool ByProceso
		{
			get{return _brClass.ByProceso;}
			set{_brClass.ByProceso = value;}
		}

		public long IdTarea
		{
			get{return _brClass.IdTarea;}
			set{_brClass.IdTarea = value;}
		} 

		public string TareaSeleccionada
		{
			get{return _brClass.TareaSeleccionada;}
			set{_brClass.TareaSeleccionada = value;}
		} 

		public bool ByTarea
		{
			get{return _brClass.ByTarea;}
			set{_brClass.ByTarea = value;}
		}

		public string ContextoDeBusqueda
		{
			get{return _brClass.ContextoDeBusqueda;}
			set{_brClass.ContextoDeBusqueda = value;}
		} 

		private DataTable _procesos = null;
		public System.Data.DataTable Procesos
		{
			get {return _procesos;}
		}

		public string KeyValueProcesos
		{
			get { return "IdProceso" ; }
		}				
		public string KeyListProcesos
		{
			get { return "Descripcion" ; }
		}

		private DataTable _tareas = null;
		public System.Data.DataTable Tareas
		{
			get {return _tareas;}
		}

		public string KeyValueTareas
		{
			get { return "IdTarea" ; }
		}				
		public string KeyListTareas
		{
			get { return "Descripcion" ; }
		}
		
		public string ContextosDeBusqueda
		{			
			get { return _brClass.ContextosDeBusqueda; }			
		}	

		public string ContextosDeBusquedaDefault
		{			
			get { return _brClass.ContextosDeBusquedaDefault; }			
		}	
		
		public System.Data.DataRowView VariableSeleccionada
		{
			get{return _brClass.VariableSeleccionada;}
			set{_brClass.VariableSeleccionada = value;}
		} 

		public string IdVariableSeleccionada
		{
			get{return _brClass.IdVariableSeleccionada;}
			set{_brClass.IdVariableSeleccionada = value;}
		} 

		public bool SeleccionGeneral
		{
			get{return _brClass.SeleccionGeneral;}
			set{_brClass.SeleccionGeneral = value;}
		} 

		Hashtable _parametros = null;
		public Hashtable Parametros 
		{
			get {return _parametros;}
		}

		#endregion

		#region Eventos
        public event EventHandler DataChanged;
		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}
		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{
			SetLeyendaFormulario();
			SetCombosData();
		}

		
		private void InitEventHandlers()
		{
			_brClass.DataChanged +=new EventHandler(RefreshData);
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		private void SetCombosData()
		{
			_procesos = businessrules.twf_Procesos.GetList().twf_Procesos;
			_todasLasTareas = businessrules.twf_Tareas.GetList().twf_Tareas;
			_tareas = _todasLasTareas;
		}

		#endregion

		#region Métodos Públicos

		public void SearchNow()
		{
			_brClass.SearchNow();
		}

		public void ResetTareas()
		{
			_tareas = _todasLasTareas;
		}

		public void GetParameters() 
		{
			string idVariable = string.Empty;
			if(SeleccionGeneral)
			{
				idVariable = IdVariableSeleccionada;
				_parametros = ProcessParameters.ConvertToHash("ABMVariables", "IdVariable", idVariable);
				ArrayList variablesSeleccionadas = new ArrayList();
				foreach(DataRow row in DataTableResult.Rows)
				{
					if(idVariable.Equals((string)row["IdVariable"]))
					{
						Variable var = new Variable(row);
						variablesSeleccionadas.Add(var);
					}

				}
				Hashtable valores = (Hashtable)_parametros["ABMVariables"];
				valores.Add("VariablesSeleccionadas", variablesSeleccionadas);
				valores.Add("ModificacionSimple", false);
				valores.Add("SearchObjectListener", _brClass);
			}
			else
			{
				idVariable = (string)VariableSeleccionada["IdVariable"];
				_parametros = ProcessParameters.ConvertToHash("ABMVariables", "IdVariable", idVariable);
				ArrayList variablesSeleccionadas = new ArrayList();
				Variable var = new Variable(VariableSeleccionada);
				variablesSeleccionadas.Add(var);
				Hashtable valores = (Hashtable)_parametros["ABMVariables"];
				valores.Add("VariablesSeleccionadas", variablesSeleccionadas);
				valores.Add("ModificacionSimple", true);
				valores.Add("SearchObjectListener", _brClass);
			
			}
		}

		
		public void GetParametersAlta(bool CopiarDatos) 
		{
			if(CopiarDatos)
			{
				string idVariable = string.Empty;
				string descripcion = string.Empty;
				string valor = string.Empty;
				string tipo = string.Empty;
				if(SeleccionGeneral)
				{
					idVariable = IdVariableSeleccionada;
					_parametros = ProcessParameters.ConvertToHash("ABMVariables", "IdVariableAlta", idVariable);
					Hashtable valores = (Hashtable)_parametros["ABMVariables"];
					valores.Add("SearchObjectListener", _brClass);
				}
				else
				{
					idVariable = (string)VariableSeleccionada["IdVariable"];
					descripcion = (string)VariableSeleccionada["Descripcion"];
					valor = (string)VariableSeleccionada["ValorDefault"];
					tipo = (string)VariableSeleccionada["Tipo"];
					_parametros = ProcessParameters.ConvertToHash("ABMVariables", "IdVariableAlta", idVariable);
					Hashtable valores = (Hashtable)_parametros["ABMVariables"];
					valores.Add("DescripcionAlta", descripcion);
					valores.Add("ValorAlta", valor);
					valores.Add("TipoAlta", tipo);
					valores.Add("SearchObjectListener", _brClass);
			
				}
			}
			else
			{
				_parametros = ProcessParameters.ConvertToHash("ABMVariables", "SearchObjectListener", _brClass);
			}
		}

		public void DeleteVariableSeleccionada()
		{
			_brClass.DeleteVariableSeleccionada();
		}
		#endregion

		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

	}
}
