
using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CambiarContraseña.
	/// </summary>
	public class CuentaCorrienteGeneral: ITask
	{
		public CuentaCorrienteGeneral()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}		

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}



		public void Init()
		{
			string process = this._processParent.Process.ProcessName;
			_subProcess = process.Equals("ProcesoCuentaCorrienteGeneral")? "ProcesoCuentaCorrienteCliente":"ProcesoCuentaCorrienteClienteDV";
			_comprobantes = Variables.GetValueString("Momentos."+ process+ ".Comprobantes");
			_nombreColumnaMarca = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(),"GrillaResultado.NombreColumnaMarca");
			//_nombreColumnaMarca = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+ this._processParent.Process.ProcessName +".GrillaResultado.NombreColumnaMarca");
			//_activarColumnaMarca = Variables.GetValueBool("Momentos."+this.GetTaskName()+"."+ this._processParent.Process.ProcessName +".GrillaResultado.ActivarColumnaMarca");
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());

			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			int FilasSeleccionadas = 0;

			_errores.Clear();

			foreach(DataRow row in _tablaResultado.Rows)
			{					
				
				if(Convert.ToBoolean(row[_nombreColumnaMarca]) )
				{
					FilasSeleccionadas++;
				}			
			}
			if (FilasSeleccionadas == 0) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Selección de cuenta corriente","Falta seleccionar uno o más filas"));
			}							
			return IsValid;			
		}

		public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion


		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;	
		private string _subProcess = string.Empty;
		private bool _allowMultipleSelect = false;

		private ArrayList _jerarquias1 = new ArrayList();
		private ArrayList _jerarquias2 = new ArrayList();
		private ArrayList _jerarquias3 = new ArrayList();
		private ArrayList _jerarquias4 = new ArrayList();
		private ArrayList _jerarquias5 = new ArrayList();
		private ArrayList _jerarquias6 = new ArrayList();
		private ArrayList _jerarquias7 = new ArrayList();
		private ArrayList _jerarquias8 = new ArrayList();

		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byJerarquia6 = false;
		private bool _byJerarquia7 = false;
		private bool _byJerarquia8 = false;

		#endregion

		#region Propiedades

		public ArrayList  Jerarquias1
		{
			get{return _jerarquias1;}
			set{_jerarquias1 = value;}
		}
		public ArrayList  Jerarquias2
		{
			get{return _jerarquias2;}
			set{_jerarquias2 = value;}
		}

		public ArrayList  Jerarquias3
		{
			get{return _jerarquias3;}
			set{_jerarquias3 = value;}
		}

		public ArrayList  Jerarquias4
		{
			get{return _jerarquias4;}
			set{_jerarquias4 = value;}
		}

		public ArrayList  Jerarquias5
		{
			get{return _jerarquias5;}
			set{_jerarquias5 = value;}
		}

		public ArrayList  Jerarquias6
		{
			get{return _jerarquias6;}
			set{_jerarquias6 = value;}
		}

		public ArrayList  Jerarquias7
		{
			get{return _jerarquias7;}
			set{_jerarquias7 = value;}
		}

		public ArrayList  Jerarquias8
		{
			get{return _jerarquias8;}
			set{_jerarquias8 = value;}
		}

		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}
		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		public string SubProcess
		{
			get{return _subProcess;}
		}

		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}


		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _leyendaFormulario = "Cuenta corriente general";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _textoSolapaJerarquias = "Jerarquia Clientes";
		public string TextoSolapaJerarquias
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this._processParent.Process.ProcessName + "." + "TextoSolapaJerarquias";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoSolapaJerarquias;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _keyHierarchicalSearchControl = "CUENTAS";
		public string KeyHierarchicalSearchControl
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this._processParent.Process.ProcessName + "." + "KeyHierarchicalSearchControl";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _keyHierarchicalSearchControl;
				}
				else 
				{
					return valor;
				}
			}
		}
		
		private DataTable _tablaResultado = new DataTable();
		public DataTable TablaResultado
		{
			get 
			{
				return _tablaResultado;
			}					
			set 
			{
				_tablaResultado = value;
			}
		}

		private DateTime _fechaHasta = DateTime.Now;
		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
		}

		private string _comprobantes = "";
		public string Comprobantes 
		{
			get 
			{
				return _comprobantes;
			}
			set 
			{
				_comprobantes = value;
			}
		}		
		
		private string _nombreColumnaMarca = "";
		public string NombreColumnaMarca 
		{
			get 
			{
				return _nombreColumnaMarca;
			}			
		}
		
		/*private bool _activarColumnaMarca = false;
		public bool ActivarColumnaMarca 
		{
			get 
			{
				return _activarColumnaMarca;
			}			
		}*/
			

		
		#endregion

		#region Métodos públicos
		public void RefreshData()
		{
			string j1 = BuildJerarquia(_jerarquias1);
			string j2 = BuildJerarquia(_jerarquias2);
			string j3 = BuildJerarquia(_jerarquias3);
			string j4 = BuildJerarquia(_jerarquias4);
			string j5 = BuildJerarquia(_jerarquias5);
			string j6 = BuildJerarquia(_jerarquias6);
			string j7 = BuildJerarquia(_jerarquias7);
			string j8 = BuildJerarquia(_jerarquias8);

			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty};

			j1 = jerarquias[0];
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];

			string je1 = BuildJerarquia(_jerarquias1);
			string je2 = BuildJerarquia(_jerarquias2);
			string je3 = BuildJerarquia(_jerarquias3);
			string je4 = BuildJerarquia(_jerarquias4);
			string je5 = BuildJerarquia(_jerarquias5);
			string je6 = BuildJerarquia(_jerarquias6);
			string je7 = BuildJerarquia(_jerarquias7);
			string je8 = BuildJerarquia(_jerarquias8);

			je1 = jerarquias[0];
			je2 = jerarquias[1];
			je3 = jerarquias[2];
			je4 = jerarquias[3];
			je5 = jerarquias[4];
			je6 = jerarquias[5];
			je7 = jerarquias[6];
			je8 = jerarquias[7];

			switch(this._processParent.Process.ProcessName)
			{
				case "ProcesoCuentaCorrienteGeneral":
				{									
					_tablaResultado = mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
				case "ProcesoCuentaCorrienteGeneralDV":
				{									
					_tablaResultado = mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
				case "ProcesoCuentaCorrienteGeneralConsolidada":
				{									
					_tablaResultado = mz.erp.dataaccess.tsa_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
				case "ProcesoCuentaCorrienteGeneralProveedores":
				{									
					_tablaResultado = mz.erp.dataaccess.tpu_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
				case "ProcesoCuentaCorrienteGeneralProveedoresDV":
				{									
					_tablaResultado = mz.erp.dataaccess.tpu_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
				case "ProcesoCuentaCorrienteGeneralProveedoresConsolidada":
				{									
					_tablaResultado = mz.erp.dataaccess.tpu_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(_fechaHasta, _comprobantes, je1, je2, je3, je4, je5, je6, je7, je8).Tables[0];			
					break;
				}
			}

			_tablaResultado = commontypes.AddColumn.AddColumnToTable(_tablaResultado, _nombreColumnaMarca, true);

			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		private string BuildJerarquia(ArrayList je)
		{
				
			ArrayList narray = new ArrayList();
			foreach (object item in je) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				narray.Add(it.NodeKey);				
			}
			return mz.erp.systemframework.Util.PackString(narray);
		}

		public string GetProcessName()
		{
            // CtaCte de Clientes (Blanco y DV) o Proveedores (Blanco y DV)
			switch (_processParent.Process.ProcessName)
			{
				case "ProcesoCuentaCorrienteGeneralProveedores":
				{
					return "ProcesoCuentaCorrienteProveedor";
					break;
				}
				case "ProcesoCuentaCorrienteGeneral":
				{
					return "ProcesoCuentaCorrienteCliente";
					break;
				}
				case "ProcesoCuentaCorrienteGeneralDV":
				{
					return "ProcesoCuentaCorrienteClienteDV";
					break;
				}
				case "ProcesoCuentaCorrienteGeneralPROVEEDORES":
				{
					return "ProcesoCuentaCorrienteProveedor";
					break;
				}
				case "ProcesoCuentaCorrienteGeneralProveedoresDV":
				{
					return "ProcesoCuentaCorrienteProveedorDV"; // No implementado
					break;
				}
				case "ProcesoCuentaCorrienteGeneralConsolidada":
				{
					return "ProcesoCuentaCorrienteClienteConsolidada";
				}
				case "ProcesoCuentaCorrienteGeneralProveedoresConsolidada":
				{
					return "ProcesoCuentaCorrienteProveedoresConsolidada";
					break;
				}
			}
			return "";
		}

		#endregion
	}
}



