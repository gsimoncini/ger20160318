using System;
using mz.erp.businessrules.comprobantes;
using System.Data;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ImprimirReporteComprobanteDeVenta.
	/// </summary>
	public class ImprimirReporteComprobanteDeVenta:ImprimirReporteDeComprobante, IDependentPersistentTask,ITask
	{
		public ImprimirReporteComprobanteDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Miembros de IDependentPersistentTask



		public override void ListenerAfterExecuteDependentTask(object sender)
		{

            //Sabrina: Tarea 901. 20101001
            string NombreTareaSender = ((ITask)sender).GetTaskName();
            //Fin Sabrina: Tarea 901. 20101001

            if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeVenta comprobante = (ComprobanteDeVenta)sender;
                    this.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
                }
                //Fin Sabrina: Tarea 901. 20101001
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeAjusteCuentaCorriente )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeAjusteCuentaCorriente comprobante = (ComprobanteDeAjusteCuentaCorriente)sender;
                    this.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
                }
                //Fin Sabrina: Tarea 901. 20101001
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeEntrega )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeEntrega comprobante = (ComprobanteDeEntrega)sender;
                    this.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
                }
                //Fin Sabrina: Tarea 901. 20101001
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.FiscalComprobantes ))) 
			{
				FiscalComprobantes comprobante = (FiscalComprobantes) sender;
				ImpresionFiscalExitosa = comprobante.ImpresionFiscalExitosa;
				SoportaComprobanteFiscal = comprobante.SoportaComprobanteFiscal;				
			}
		 }


		public void ListenerAfterFlush(object sender)
		{

            //Sabrina: Tarea 901. 20101001
            string NombreTareaSender = ((ITask)sender).GetTaskName();
            //Fin Sabrina: Tarea 901. 20101001

            if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeVenta comprobante = (ComprobanteDeVenta)sender;
                    LoadDataFromComprobanteDeVenta(comprobante);
                }
                //Fin Sabrina: Tarea 901. 20101001
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeAjusteCuentaCorriente )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeAjusteCuentaCorriente comprobante = (ComprobanteDeAjusteCuentaCorriente)sender;
                    LoadDataFromComprobanteDeAjusteCuentaCorriente(comprobante);
                }
                //Fin Sabrina: Tarea 901. 20101001
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeEntrega )))
			{
                //Sabrina: Tarea 901. 20101001
                if (TareaAsociada.Equals(string.Empty) || (!TareaAsociada.Equals(string.Empty) && TareaAsociada.Equals(NombreTareaSender)))
                {
                    ComprobanteDeEntrega comprobante = (ComprobanteDeEntrega)sender;
                    LoadDataFromComprobanteDeEntrega(comprobante);
                }
                //Fin Sabrina: Tarea 901. 20101001
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

		private void LoadDataFromComprobanteDeAjusteCuentaCorriente(ComprobanteDeAjusteCuentaCorriente comprobante)
		{			
			TaskCollectionData data = comprobante.GetData();
			foreach(DataSet dataset in data)
			{
				if(dataset.DataSetName.Equals("tsa_CompbrobantesDataset"))
				{
					DataTable table = dataset.Tables["tsa_Comprobantes"];
					DataRow row = table.Rows[0];
					this.IdComprobante = Convert.ToString(row["IdComprobante"]);
					

				}
			}

		}

		

		private void LoadDataFromComprobanteDeVenta(ComprobanteDeVenta comprobante)
		{			
			TaskCollectionData data = comprobante.GetData();
			foreach(DataSet dataset in data)
			{
				if(dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
				{
					DataTable table = dataset.Tables["tsa_Comprobantes"];
					DataRow row = table.Rows[0];
					this.IdComprobante = Convert.ToString(row["IdComprobante"]);
					AddVariablesAuxiliares(comprobante.VariablesDeUsuario);

				}
			}

		}

		private void LoadDataFromComprobanteDeEntrega(ComprobanteDeEntrega comprobante)
		{			
			TaskCollectionData data = comprobante.GetData();
			foreach(DataSet dataset in data)
			{
				if(dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
				{
					DataTable table = dataset.Tables["tsa_Comprobantes"];
					DataRow row = table.Rows[0];
					this.IdComprobante = Convert.ToString(row["IdComprobante"]);
					AddVariablesAuxiliares(comprobante.VariablesDeSistema);

				}
			}

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

		private bool _allowShow = true;
		private bool _allowImpresoraPorTipoDeComprobante = false;
		private Hashtable _impresorasPorTipoDeComprobante = new Hashtable();

        //German 20100713 - Tarea 793
        private bool _allowBandejaPorTipoDeComprobante = false;
        private Hashtable _bandejasPorTipoDeComprobante = new Hashtable();
        //Fin German 20100713 - Tarea 793

		public void Init()
		{
			base.Init();
			_allowShow = Variables.GetValueBool(this._process.Process.ProcessName, this._taskName, "VisualizaVentana", _allowShow);
			_allowImpresoraPorTipoDeComprobante = Variables.GetValueBool(this._process.Process.ProcessName, this._taskName, "UsaImpresoraPersonalizadaPorTipoDeComprobante");
			string ImpresorasPorTipoDeComprobante = Variables.GetValueString(this._process.Process.ProcessName, this._taskName, "ImpresorasPorTipoDeComprobante");
			ArrayList ImpresorasPorTipoDeComprobanteLista = mz.erp.systemframework.Util.Parse(ImpresorasPorTipoDeComprobante, ";");
			foreach(string cadena in ImpresorasPorTipoDeComprobanteLista)
			{
				string[] partes = cadena.Split(new char[]{'|'});
				if(partes.Length == 2)
					if(!_impresorasPorTipoDeComprobante.ContainsKey(partes[0]))
						_impresorasPorTipoDeComprobante.Add(partes[0], partes[1]);

			}

            //German 20100713 - Tarea 793
            _allowBandejaPorTipoDeComprobante = Variables.GetValueBool(this._process.Process.ProcessName, this._taskName, "UsaBandejaPersonalizadaPorTipoDeComprobante");
            string BandejasPorTipoDeComprobante = Variables.GetValueString(this._process.Process.ProcessName, this._taskName, "BandejasPorTipoDeComprobante");
            ArrayList BandejasPorTipoDeComprobanteLista = mz.erp.systemframework.Util.Parse(BandejasPorTipoDeComprobante, ";");
            foreach (string cadena in BandejasPorTipoDeComprobanteLista)
            {
                string[] partes = cadena.Split(new char[] { '|' });
                if (partes.Length == 2)
                    if (!_bandejasPorTipoDeComprobante.ContainsKey(partes[0]))
                        _bandejasPorTipoDeComprobante.Add(partes[0], partes[1]);

            }
            //Fin German 20100713 - Tarea 793
            //Sabrina: Tarea 901. 20101001
            _tareaAsociada = Variables.GetValueString(this._process.Process.ProcessName, this._taskName, "Tarea");
            //Fin Sabrina: Tarea 901. 20101001

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
			return _allowShow;
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
		
		public bool AllowImpresoraPorTipoDeComprobante
		{
			get{return _allowImpresoraPorTipoDeComprobante;}
		}

		public string ImpresoraPorTipoDeComprobante
		{
			get
			{
				if(_allowImpresoraPorTipoDeComprobante)
					if(_impresorasPorTipoDeComprobante.ContainsKey(this.IdTipoDeComprobante))
						return Convert.ToString(_impresorasPorTipoDeComprobante[this.IdTipoDeComprobante]);
				return null;
			}
		}


        //German 20100713 - Tarea 793
        public bool AllowBandejaPorTipoDeComprobante
        {
            get { return _allowBandejaPorTipoDeComprobante; }
        }

        public string BandejaPorTipoDeComprobante
        {
            get
            {
                if (_allowBandejaPorTipoDeComprobante)
                    if (_bandejasPorTipoDeComprobante.ContainsKey(this.IdTipoDeComprobante))
                        return Convert.ToString(_bandejasPorTipoDeComprobante[this.IdTipoDeComprobante]);
                return null;
            }
        }
        //Fin German 20100713 - Tarea 793

        //Sabrina: Tarea 901. 20101001
        private string _tareaAsociada = string.Empty;
        public string TareaAsociada
        {
            get
            {
                return _tareaAsociada;
            }
        }
        //Fin Sabrina: Tarea 901. 20101001

	}


}
