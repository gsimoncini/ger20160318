using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarProductosConPreciosModificados.
	/// </summary>
	public class ConsultarProductosConPreciosModificados: ITask
	{
		#region Constructores
		public ConsultarProductosConPreciosModificados()
		{
		}
		#endregion

		#region Variables Privadas

		private DataTable _result = new DataTable();	

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

		private string _idProducto = string.Empty;
		private string _codigoProducto = string.Empty;

		#endregion

		#region Eventos y delegados		
		public event System.EventHandler DataChanged;
		#endregion

		#region Propiedades		
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = mz.erp.businessrules.Variables.GetValueString(variable);				
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

		private string _leyendaFormulario = "Consultar Listas de Precios";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = mz.erp.businessrules.Variables.GetValueString(variable);
				
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		public DataTable Result
		{
			get{return _result;}
		}

		private bool _allowMultipleSelect = false;
		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}

		private string _idListaDePrecios = string.Empty;
		public string IdListaDePrecios
		{
			get { return _idListaDePrecios; }
			set { _idListaDePrecios = value; }
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

		public string CodigoProducto
		{
			get{return _codigoProducto;}
			set
			{
				if(_codigoProducto != value)
				{
					_codigoProducto = value;
					if (_codigoProducto.Equals(string.Empty))
						_idProducto=string.Empty;
					else
						_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigoProducto);
				}
			}
		}

		private bool _porUltimaFechaModifPcioCosto = false;
		public bool PorUltimaFechaModifPcioCosto
		{
			get{return _porUltimaFechaModifPcioCosto;}
			set
			{
				_porUltimaFechaModifPcioCosto = value;
				if(!_porUltimaFechaModifPcioCosto)
				{
					_fechaUltimaModifPcioCostoDesde = DateTime.MinValue;
					_fechaUltimaModifPcioCostoHasta = DateTime.MinValue;
				}
				else
				{
					_fechaUltimaModifPcioCostoDesde = DateTime.Now;
					_fechaUltimaModifPcioCostoHasta = DateTime.Now;
				}
			}
		}

		private bool _porUltimaFechaModifPcioVta = false;
		public bool PorUltimaFechaModifPcioVta
		{
			get{return _porUltimaFechaModifPcioVta;}
			set
			{
				_porUltimaFechaModifPcioVta = value;
				if(!_porUltimaFechaModifPcioVta)
				{
					_fechaUltimaModifPcioVtaDesde = DateTime.MinValue;
					_fechaUltimaModifPcioVtaHasta = DateTime.MinValue;
				}
				else
				{
					_fechaUltimaModifPcioVtaDesde = DateTime.Now;
					_fechaUltimaModifPcioVtaHasta = DateTime.Now;
				}
			}
		}

		private DateTime _fechaUltimaModifPcioCostoDesde = DateTime.Now;
		public DateTime FechaUltimaModifPcioCostoDesde
		{
			get{return _fechaUltimaModifPcioCostoDesde;}
			set{_fechaUltimaModifPcioCostoDesde = value;}
		}

		private DateTime _fechaUltimaModifPcioCostoHasta = DateTime.Now;
		public DateTime FechaUltimaModifPcioCostoHasta
		{
			get{return _fechaUltimaModifPcioCostoHasta;}
			set{_fechaUltimaModifPcioCostoHasta = value;}
		}

		private DateTime _fechaUltimaModifPcioVtaDesde = DateTime.Now;
		public DateTime FechaUltimaModifPcioVtaDesde
		{
			get{return _fechaUltimaModifPcioVtaDesde;}
			set{_fechaUltimaModifPcioVtaDesde = value;}
		}

		private DateTime _fechaUltimaModifPcioVtaHasta = DateTime.Now;
		public DateTime FechaUltimaModifPcioVtaHasta
		{
			get{return _fechaUltimaModifPcioVtaHasta;}
			set{_fechaUltimaModifPcioVtaHasta = value;}
		}
		#endregion

		#region Métodos Públicos

        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, string tipoFecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(_processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");

            switch (tipoFecha)
            {
                case "COSTO": if (!ordenInverso)
                                { this._fechaUltimaModifPcioCostoDesde = fecha; }
                                else { this._fechaUltimaModifPcioCostoHasta = fecha; };

                                if (!ordenInverso)
                                {
                                    if (this.FechaUltimaModifPcioCostoHasta < fecha)
                                    {
                                        _fechaUltimaModifPcioCostoHasta = Util.GenerateFechaHasta(fecha, dias);
                                    }
                                }
                                else
                                {
                                    if (this.FechaUltimaModifPcioCostoDesde > fecha)
                                    {
                                        _fechaUltimaModifPcioCostoDesde = Util.GenerateFechaHasta(fecha, dias);
                                    }

                                }//End ELSE
                    break;

                default:
                                if (!ordenInverso)
                                { this._fechaUltimaModifPcioVtaDesde = fecha; }
                                else { this._fechaUltimaModifPcioVtaHasta = fecha; };

                                if (!ordenInverso)
                                {
                                    if (this.FechaUltimaModifPcioVtaHasta < fecha)
                                    {
                                        _fechaUltimaModifPcioVtaHasta = Util.GenerateFechaHasta(fecha, dias);
                                    }
                                }
                                else
                                {
                                    if (this.FechaUltimaModifPcioVtaDesde > fecha)
                                    {
                                        _fechaUltimaModifPcioVtaDesde = Util.GenerateFechaHasta(fecha, dias);
                                    }

                                }//End ELSE
                    break;
            }

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian
		public void RefreshData()
		{			
			
			/*Esto depende de cada Tarea - Big Case*/
			string j1 = BuildJerarquia(_jerarquias1);
			string j2 = BuildJerarquia(_jerarquias2);
			string j3 = BuildJerarquia(_jerarquias3);
			string j4 = BuildJerarquia(_jerarquias4);
			string j5 = BuildJerarquia(_jerarquias5);
			string j6 = BuildJerarquia(_jerarquias6);
			string j7 = BuildJerarquia(_jerarquias7);
			string j8 = BuildJerarquia(_jerarquias8);

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			j1 = jerarquias[0];	
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];

			_fechaUltimaModifPcioCostoDesde = _fechaUltimaModifPcioCostoDesde.Equals(DateTime.MinValue)? _fechaUltimaModifPcioCostoDesde:mz.erp.systemframework.Util.GetStartDay(_fechaUltimaModifPcioCostoDesde);
			_fechaUltimaModifPcioCostoHasta = _fechaUltimaModifPcioCostoHasta.Equals(DateTime.MinValue)? _fechaUltimaModifPcioCostoHasta:mz.erp.systemframework.Util.GetEndDay(_fechaUltimaModifPcioCostoHasta);

			_fechaUltimaModifPcioVtaHasta = _fechaUltimaModifPcioVtaHasta.Equals(DateTime.MinValue)? _fechaUltimaModifPcioVtaHasta: mz.erp.systemframework.Util.GetEndDay(_fechaUltimaModifPcioVtaHasta);
			_fechaUltimaModifPcioVtaDesde = _fechaUltimaModifPcioVtaHasta.Equals(DateTime.MinValue)? _fechaUltimaModifPcioVtaDesde: mz.erp.systemframework.Util.GetStartDay(_fechaUltimaModifPcioVtaDesde);

			_result = tsh_ProductosEx.SearchProductosConPreciosModificados(_porUltimaFechaModifPcioCosto, _fechaUltimaModifPcioCostoDesde, _fechaUltimaModifPcioCostoHasta, _porUltimaFechaModifPcioVta, _fechaUltimaModifPcioVtaDesde, _fechaUltimaModifPcioVtaHasta, _idListaDePrecios, _idProducto, j1, j2, j3, j4, j5, j6, j7, j8);

			
		}

		#endregion

		#region Métodos Privados
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
		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;			
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			_allowMultipleSelect = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowMultipleSelect");	
			_idListaDePrecios = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;			
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
			_errores.Clear();
			bool isvalid = true;
			return isvalid;
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
			return string.Empty;
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
			return this._taskName;
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

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion


	}
}
