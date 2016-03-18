using System;
using mz.erp.businessrules.comprobantes;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ImprimirReporteComprobanteDeCompra.
	/// </summary>
	public class ImprimirReporteComprobanteDeCompra:ImprimirReporteDeComprobante, IDependentPersistentTask,ITask
	{
		public ImprimirReporteComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Miembros de IDependentPersistentTask



		public override void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeCompra )))
			{
				ComprobanteDeCompra comprobante = (ComprobanteDeCompra)sender;
				this.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.IngresarComprobanteDeCompraCabecera )))
			{
				IngresarComprobanteDeCompraCabecera comprobante = (IngresarComprobanteDeCompraCabecera)sender;
				this.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
			}
			
		}


		public void ListenerAfterFlush(object sender)
		{
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeCompra )))
			{
				ComprobanteDeCompra comprobante = (ComprobanteDeCompra)sender;
				LoadDataFromComprobanteDeCompra(comprobante);
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.IngresarComprobanteDeCompraCabecera)))
			{
				IngresarComprobanteDeCompraCabecera comprobante = (IngresarComprobanteDeCompraCabecera)sender;
				LoadDataFromIngresarComprobanteDeCompraCabecera(comprobante);
			}
			/*if (sender.GetType().Equals( typeof( mz.erp.businessrules.PrepararDatosImpresionComprobantes ))) 
			{
				PrepararDatosImpresionComprobantes comprobante = (PrepararDatosImpresionComprobantes) sender;
				_impresionFiscalExitosa = comprobante.ImpresionFiscalExitosa;
				_soportaComprobanteFiscal = comprobante.SoportaComprobanteFiscal;
			}*/
		}

		public void ListenerBeforeFlush(object sender)
		{
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.ListenerBeforeFlush
		}

		#endregion

		private void LoadDataFromComprobanteDeCompra(ComprobanteDeCompra comprobante)
		{			
			TaskCollectionData data = comprobante.GetData();
			foreach(DataSet dataset in data)
			{
				if(dataset.DataSetName.Equals("tpu_ComprobantesDataset"))
				{
					DataTable table = dataset.Tables["tpu_Comprobantes"];
					DataRow row = table.Rows[0];
					this.IdComprobante = Convert.ToString(row["IdComprobante"]);
					//AddVariablesAuxiliares(comprobante.VariablesDeUsuario);

				}
			}

		}

		private void LoadDataFromIngresarComprobanteDeCompraCabecera(IngresarComprobanteDeCompraCabecera comprobante)
		{			
			TaskCollectionData data = comprobante.GetData();
			foreach(DataSet dataset in data)
			{
				if(dataset.DataSetName.Equals("tpu_ComprobantesDataset"))
				{
					DataTable table = dataset.Tables["tpu_Comprobantes"];
					DataRow row = table.Rows[0];
					this.IdComprobante = Convert.ToString(row["IdComprobante"]);
					//AddVariablesAuxiliares(comprobante.VariablesDeUsuario);

				}
			}

		}

		protected DataTable GenerateDataSource(string IdComprobante, string family)
		{
			return mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForComprobantesComprasReport(IdComprobante, family);
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
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.ListenerTaskDependentChanged
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			base.Init();
		}

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._process.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.IsValid
			return true;
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.AllowShow
			return true;
		}
		public void FormHasClosed() 
		{
		}
		private ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ImprimirReporteComprobanteDeVenta.GetErrors
			return _errors;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _process;
		}
		private ProcessManager _process;
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_process = processManager;
		}
		private string _taskName;
		public string GetTaskName()
		{
			
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName= taskName;
		}

		public void Execute()
		{
			if (this.OnTaskBeforeExecute!= null)
				OnTaskBeforeExecute(this,new System.EventArgs());
			if (this.OnTaskAfterExecute!= null)
				OnTaskAfterExecute(this,new System.EventArgs());
		}

		#endregion

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "TextoBotonAnterior";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonAnterior";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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
				string valor = string.Empty;
				try 
				{					
					string variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonSiguiente";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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
	}


}
