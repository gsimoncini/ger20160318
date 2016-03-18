using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ComprobantesPendientes.
	/// </summary>
	public class ComprobantesPendientes : ITask
	{
		public ComprobantesPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables privadas
			
			private DateTime _fechaDesde;
			private DateTime _fechaHasta;
			private string _idCuenta = string.Empty;
			private string _codigoCuenta = string.Empty;
			private string _idResponsable = Security.IdPersona;
			private string _familiaComprobantes = string.Empty;
			private string _familiaComprobantesDefault = string.Empty;
			private string _idProveedor = string.Empty;

			private ArrayList _tiposDeComprobantesOrigen = new ArrayList();
			private ArrayList _tiposDeComprobantesDestino = new ArrayList();

			private string _tiposDeComprobanteDestinoExcluidos = string.Empty;
			
			private ArrayList _arrayIdComprobantesPendientes = new ArrayList();
			private RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;
			private ProcessManager _processManager;
			private string _taskName;
			private long _idTask;
			private string _primaryTaskName;
			private long _idPrimaryTask;
			private long _idProcess;
			private bool _hasShowSeleccionItems = false;
			private bool _requiereBuscarPendientes = true;

            /* Silvina 20111212 - Tarea 0000232 */
            private DateTime _fechaVencimientoDesde;
            private DateTime _fechaVencimientoHasta;
            /* Fin Silvina 20111212 - Tarea 0000232 */

		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();

		private ArrayList _selectedItems = new ArrayList();
			

		#endregion

		#region Variables Publicas

		public bool RequiereBuscarPendientes	
		{
			get{return _requiereBuscarPendientes;}
		}

		public ArrayList SelectedItems
		{
			set{_selectedItems = value;}
			get{return _selectedItems;}
		}

		public string TiposDeComprobanteDestinoExcluidos
		{
			get{return _tiposDeComprobanteDestinoExcluidos;}
		}

		public bool HasShowSeleccionItems
		{
			set
			{
				_hasShowSeleccionItems = value;
			}
			get
			{
				return _hasShowSeleccionItems;
			}
		}
		
		public RelacionesComprobanteOrigenDestino RelacionesComprobanteOrigenDestino
		{
			get
			{
				return _relacionesComprobanteOrigenDestino;
			}
			set
			{
				if(_relacionesComprobanteOrigenDestino != value)
				{
					_relacionesComprobanteOrigenDestino = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		public ArrayList TiposDeComprobantesDestino
		{
			get
			{
				return _tiposDeComprobantesDestino;
			}
		}
		public ArrayList TiposDeComprobantesOrigen
		{
			get
			{
				return _tiposDeComprobantesOrigen;
			}
		}

		

		public ArrayList ArrayIdComprobantesPendientes
		{
			get
			{
				return _arrayIdComprobantesPendientes;
			}
			set
			{
				if(value != _arrayIdComprobantesPendientes)
				{
					_arrayIdComprobantesPendientes = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

			}

		}

		public string IdProveedor 
		{
			get
			{
				return _idProveedor;
			}
			set
			{
				_idProveedor = value;
			}
		}
		
		public string CodigoCuenta
		{
			get
			{
				return _codigoCuenta;
			}
			set
			{
				if(value != _codigoCuenta)
				{
					_codigoCuenta = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);

				}
		}
		}
		
		public string IdCuenta
		{
			get
			{
				return _idCuenta;
			}
			
		}

		
		public string IdResponsable
		{
			get
			{
				return _idResponsable;
			}
			set
			{		
				_idResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _fechaDesde;
			}
			set
			{
				_fechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _fechaHasta;
			}
			set
			{
				_fechaHasta = value;
			}
		}

        /* Silvina 20111212 - Tarea 0000232 */

        public DateTime FechaVencimientoDesde
        {
            get
            {
                return _fechaVencimientoDesde;
            }
            set
            {
                _fechaVencimientoDesde = value;
            }
        }

        public DateTime FechaVencimientoHasta
        {
            get
            {
                return _fechaVencimientoHasta;
            }
            set
            {
                _fechaVencimientoHasta = value;
            }
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */
		public string FamiliaComprobantes
		{
			get
			{
				return _familiaComprobantes;
			}
			set
			{
				_familiaComprobantes = value;
			}
		}
		public string ProcesoEnEjecucion
		{
			get { return this.GetProcessManagerParent().Process.ProcessName; }
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
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
		public bool VerHTML 
		{
			get 
			{				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "VisualizaDetalleComprobantes";
				return Variables.GetValueBool(variable);				
			}			
		}

		#endregion

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
			this.AllowPrevious();
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
			// TODO: agregar la implementación ComprobantesPendientes.ListenerTaskDependentChanged
		}
		public void ListenerAfterExecuteDependentTask( object sender ){}
		public void ListenerBeforeExecuteDependentTask( object sender ){}

		public void Init()
		{
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-7);
			long  cantDias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			this._fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
			cantDias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasPosteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(cantDias);
			string responsable = Variables.GetValueString("Momentos."+_idPrimaryTask+".ResponsableEmision");
			
			if ((responsable != null) && !(responsable.Equals(string.Empty)))
			{
				if (responsable.Equals("Todos")) { this._idResponsable = null ; }
				else 
				{
					if (responsable.Equals("Usuario")) { this._idResponsable = Security.IdPersona ; }
					else { this._idResponsable = responsable; }
				}
			}
			else
			{
				this._idResponsable = string.Empty;
			}
			
			this._idProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
			this._idCuenta = Variables.GetValueString("Momentos." +_idPrimaryTask+ ".Cuenta.Default");
			_arrayIdComprobantesPendientes = new ArrayList();
			this._tiposDeComprobantesOrigen = this.GetTiposDeComprobantesOrigen();
			this._tiposDeComprobantesDestino = this.GetTiposDeComprobantesDestinos();
			this._familiaComprobantes = this.ObtenerFamiliaComprobante(this._tiposDeComprobantesOrigen);
			this._tiposDeComprobanteDestinoExcluidos = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "TiposDeComprobantesExcluidos");
			_requiereBuscarPendientes = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "RequiereBuscarPendientes", _requiereBuscarPendientes);
			
            /* Silvina 20111212 - Tarea 0000232 */
            _fechaVencimientoDesde = _fechaDesde;
            _fechaVencimientoHasta = _fechaHasta;
            /* Fin Silvina 20111212 - Tarea 0000232 */

		}


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			
			return IsValid;
		}


		public bool IsValid()
		{
			_errores.Clear();
			bool isValid = true;
			if(_processManager.Process.ProcessName.Equals("ProcesoPrevenderVender")
				|| _processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderManual")
				|| _processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestar"))
			{
				foreach(object obj in this.SelectedItems)
				{
					DataRow row = (DataRow) obj;
					string IdComprobante = Convert.ToString(row["IdComprobante"]);
					DataSet data = Workflow.GetCaminoComprobantesTopDown(IdComprobante, null);
					DataView view = data.DefaultViewManager.CreateDataView(data.Tables[0]);
					view.RowFilter = "IdComprobante <>" + IdComprobante;
					if(view.Count > 0)
					{
						foreach(DataRowView rowView in view )
						{
							
							string IdTipoDeComprobante = Convert.ToString(rowView["IdTipoDeComprobante"]);		
							if(this.TiposDeComprobantesOrigen.Contains(IdTipoDeComprobante))
							{
								isValid = false;
								_errores.Add( new ItemDatasetError( "Comprobante","Comprobante","El comprobante " + IdTipoDeComprobante + " ha cambiado. Actualice la consulta"));						
								return isValid;
							}
						}
						
					}
						
				}
				
			}
			/*Harcoding MZ - Hacer configurable*/
			/*
			if(_processManager.Process.ProcessName.Equals("ProcesoPrevenderPrevender")
				|| _processManager.Process.ProcessName.Equals("ProcesoPreprestarPreprestar")
				|| _processManager.Process.ProcessName.Equals("ProcesoAnularPreprestar")
				|| _processManager.Process.ProcessName.Equals("ProcesoAnularPrevender"))
			{
				if(this._tiposDeComprobanteDestinoExcluidos != null && this._tiposDeComprobanteDestinoExcluidos != string.Empty)
				{
					foreach(object obj in this.SelectedItems)
					{
						DataRow row = (DataRow) obj;
						string IdComprobante = Convert.ToString(row["IdComprobante"]);
						string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);	
						string Cuenta = Convert.ToString(row["Nombre"]);	
						string Responsable = Convert.ToString(row["Responsable"]);	
						decimal Total = Convert.ToDecimal(row["Total"]);	
						ArrayList ListaTiposDeComprobantesExcluyentes = mz.erp.systemframework.Util.Parse(this._tiposDeComprobanteDestinoExcluidos, ",");
						DataSet data = Workflow.GetCaminoComprobantesTopDown(IdComprobante, null);
						DataView view = data.DefaultViewManager.CreateDataView(data.Tables[0]);
						view.RowFilter = "IdComprobante <>" + IdComprobante;
						if(view.Count > 0)
						{
							foreach(DataRowView rowView in view )
							{
							
								int level = Convert.ToInt32(rowView["level"]);
								if(level != 1)
								{
									string TipoDeComprobante = Convert.ToString(rowView["IdTipoDeComprobante"]);		
									if(ListaTiposDeComprobantesExcluyentes.Contains(TipoDeComprobante))
									{
								
										isValid = false;
										_errores.Add( new ItemDatasetError( "Comprobante","Comprobante",
											"El Comprobante: " + 
											IdTipoDeComprobante + 
											" Cliente: " + Cuenta +
											" Total: " + Total.ToString() + 
											" Responsable: " + Responsable + 
											" ha cambiado. Actualice la consulta"));		
										return isValid;
									}
								}
							}
						}
						
										
						
						
					}
				}
				
			}*/
			return isValid;
			
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
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
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

        #region Metodos públicos

        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; }

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	

        #endregion

        #region Metodos Privados
        private string ObtenerFamiliaComprobante(ArrayList comprobantesorigen)
		{
			this._familiaComprobantesDefault =  Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "VisualizacionFamiliaDefault");
			if(_familiaComprobantesDefault != null && _familiaComprobantesDefault != string.Empty)
				return _familiaComprobantesDefault;
			string family = string.Empty;
			if (comprobantesorigen.Count != 0)
			{
				sy_VariablesDataset  data = mz.erp.businessrules.sy_Variables.GetList("Comprobantes.TiposDeComprobantes.");
				System.Data.DataTable table = data.Tables[0];

				string IdTipoComprobante = Convert.ToString(comprobantesorigen[0]);
				foreach(System.Data.DataRow row in table.Rows)
				{
					ArrayList ar = mz.erp.systemframework.Util.Parse((string)row["ValorDefault"],",");
					if (ar.Contains(IdTipoComprobante))
					{
						bool ok= true;
						foreach(string tipodecomprobante in comprobantesorigen)
						{
							ok = ok && ar.Contains(tipodecomprobante);
						}	
						if(ok)
						{
							string [] partes = ((string)row["IdVariable"]).Split('.');
							family  = partes[partes.Length-1];
						}
						

					}
				}
			}			
			return family;
		}
		/// <summary>
		/// Devuelve una lista de los comprobantes previos definidos.
		/// La tabla de Tareas-Tipos De Comprboantes define todos los id de los tipos de comprobantes para la tarea determinada
		/// En caso de que para una tarea exista más un tipo de comprobante definido, se consulta en la variable
		/// Momentos.xx.RelacionComprobantesPrevios para filtrar solamente aquellos que estan definidos para el proceso.
		/// </summary>
		/// <returns></returns>
		private ArrayList GetTiposDeComprobantesOrigen()
		{
			ArrayList aComprobantesDeLaTarea = new ArrayList();

			System.Data.DataSet dataPreviousTasks = Workflow.GetPreviousTasksOfProcess(this._idPrimaryTask,this._idProcess);
			if(dataPreviousTasks.Tables.Count > 0)
			{
				if(dataPreviousTasks.Tables[0].Rows.Count > 0)
				{	
					foreach(System.Data.DataRow row in dataPreviousTasks.Tables[0].Rows)
					{
						long idPreviousTask =  Convert.ToInt32(row[0]);
						System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(idPreviousTask);
						foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
						{
							string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
							aComprobantesDeLaTarea.Add(IdTipoComprobante);
						}
					}
				}
			}
			
			ArrayList result = new ArrayList();
			string relacionComprobantesPrevios =  Variables.GetValueString(this._processManager.Process.ProcessName,this.GetProcessManagerParent().Process.MainTask.KeyTask, "RelacionComprobantesPrevios");
			string[] arelacionComprobantesPrevios = relacionComprobantesPrevios.Split( ',');
			if (arelacionComprobantesPrevios.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
				{
					string[] atupla = arelacionComprobantesPrevios[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!hash.ContainsKey(atupla[0]))
							hash.Add( atupla[0],atupla[1]);
					}
				}
				foreach (string tipo in aComprobantesDeLaTarea)
				{
					if (hash.ContainsKey( tipo ))
					{
						if(!result.Contains(tipo))
							result.Add( tipo );
					}
				}
				return result;
			}
			else
			{
				return result;
			}
			
			
		}

		private ArrayList GetTiposDeComprobantesDestinos()
		{
			ArrayList result = new ArrayList();
			System.Data.DataSet dataTiposComprobantes = Workflow.GetComprobantesAsociados(this._idPrimaryTask);
			foreach(System.Data.DataRow rowT in dataTiposComprobantes.Tables[0].Rows)
			{
				string IdTipoComprobante = Convert.ToString(rowT["IdTipoDeComprobante"]);
				result.Add(IdTipoComprobante);


			}
			return result;
		}
		#endregion
	}
}
