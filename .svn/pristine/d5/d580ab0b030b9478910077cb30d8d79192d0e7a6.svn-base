using System;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeguimientoDeArticulos.
	/// </summary>
	public class SeguimientoDeArticulos: ITask
	{
		public SeguimientoDeArticulos()
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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init
			/*_monedas = (DataTable) tfi_Monedas.GetList().tfi_Monedas;
			_fuentesDeCambio = (DataTable) tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			_cotizacionAnterior = _cotizacion;			*/
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
			_errores.Clear();

			/*if (_cotizacion == 0) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Cotizacion de Moneda","Valor","El valor de la cotización no puede ser cero"));
			}
			if (this._cotizacion == this._cotizacionAnterior) 
			{ 
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Cotizacion de Moneda","Valor","El valor ingresado es igual al anterior"));
			}			*/
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
		#endregion

		#region Propiedades
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = String.Empty;
				/*string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);				
				*/
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
				string variable = String.Empty;
				/*string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);*/

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
		private string _leyendaFormulario = "Seguimiento de artículos";
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

		private DataTable _result = new DataTable();
		public DataTable Result
		{
			get{return _result;}
		}

		private string _idProducto;

		private string _codigo = string.Empty;
		public string Codigo
		{
			get{return _codigo;}
			set
			{
				if(value !=  null && !value.Equals(string.Empty))
				{
					if(_codigo != value)
					{
						_codigo = value;
						_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigo);
					}
				}
			
			}
		}
		#endregion


		public void RefreshData()
		{						
			string IdJerarquia = String.Empty;
			string IdJerarquia1 = String.Empty;
			string IdJerarquia2 = String.Empty;
			string IdJerarquia3 = String.Empty;
			string IdJerarquia4 = String.Empty;
			DateTime FechaDesde = System.DateTime.MinValue;
			DateTime FechaHasta = System.DateTime.MinValue;
			string IdEstadosDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaIdEstadosDeStock");
			bool _resumido = false;
			//_result = dataaccess.reportes.rep_ListadoSeguimientoDeArticulos.GetList(_idProducto, IdJerarquia, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, FechaDesde, FechaHasta, IdEstadosDeStock, _resumido);
			
			if (this.ObjectHasChanged != null)
			{
				this.ObjectHasChanged(this, new System.EventArgs() );
			}
			
		}
		/*private void ListenerChangesInterfaceFiscal( object sender, System.EventArgs e )
		{
			//_mensaje = _iFiscal.Mensaje;
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}*/

	}
}
