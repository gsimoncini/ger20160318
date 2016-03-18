using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SoporteModificarComprobantes.
	/// </summary>
	public class SoporteModificarComprobantes: ITask, IPersistentTask
	{
		
		#region Constructores
		public SoporteModificarComprobantes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public SoporteModificarComprobantes(string processName, string taskName)
		{
			this._processName=processName;
			this._taskName=taskName;
			Init();
		}
		#endregion

		#region Variables Privadas
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;
		
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Siguiente";

		private DataTable _tiposComprobanteActual = new tsy_TiposDeComprobantesDataset().tsy_TiposDeComprobantes;
		private DataTable _tiposComprobanteNuevo = new tsy_TiposDeComprobantesDataset().tsy_TiposDeComprobantes;
		private DataTable _resultado = new DataTable();
		private string _nroComprobante = string.Empty;
		private string _idComprobante = string.Empty;
		private string _idTipoComprobanteActual = string.Empty;
		private string _idTipoComprobanteNuevo = string.Empty;
        //Cristian Tarea 0000064 20110317
        private string _nroComprobanteNuevo = string.Empty;
        //Fin Cristian
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		private void Step()
		{
			
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public  void Init()
		{
			string tiposCompOrigen = Variables.GetValueString(this._processName, this._taskName, "TiposComprobantesOrigen");
			string tiposCompDestino = Variables.GetValueString(this._processName, this._taskName, "TiposComprobantesDestino");
			_tiposComprobanteActual = tsy_TiposDeComprobantes.GetList(string.Empty, string.Empty, true, int.MinValue, tiposCompOrigen).tsy_TiposDeComprobantes;
			_tiposComprobanteNuevo = tsy_TiposDeComprobantes.GetList(string.Empty, string.Empty, true, int.MinValue, tiposCompDestino).tsy_TiposDeComprobantes;
			
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

		public  bool IsValid()
		{
			ValidarDatos();
			return (_errores.Count > 0);
		}

		public  bool AllowShow() 
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

		public  string GetWarnings()
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
			_processName = _processParent.Process.ProcessName;
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

		public bool AllowPrevious()
		{
			return true;
		}

		public  void Previous()
		{
			
		}

		public  void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public  void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}


		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			return data;;
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public bool GetHasSaved()
		{
			return false;
		}
	
		public void Commit()
		{
			DataRow row = _resultado.Rows[0];
			if (row!=null)
				_idComprobante = Convert.ToString(row["IdComprobante"]);
		}

		public void Flush(string IdTransaction)
		{
			switch(this._processName)
			{
				case "ProcesoSoporteModificarComprobantesVentas":
					tsa_Comprobantes.UpdateIdTipoDeComprobante(IdTransaction, this._idComprobante, this._idTipoComprobanteNuevo);
					break;
				case "ProcesoSoporteModificarComprobantesCompras":
					tpu_Comprobantes.UpdateIdTipoDeComprobante(IdTransaction, this._idComprobante, this._idTipoComprobanteNuevo);
					break;
                //Cristian Tarea 0000064 20110317
                case "ProcesoSoporteModificarComprobantesPagoGeneral":
                    tsa_Comprobantes.UpdateNroDeComprobante(IdTransaction, this._idComprobante, this._nroComprobanteNuevo);
                    break;
                //fin Cristian
				default:
					break;
			}	
		}
		
		public void InitializeData()
		{
		
		}
		
		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		
		//		public abstract TaskCollectionData GetData()
		//		{
		//			TaskCollectionData data = new TaskCollectionData();
		//			data.TaskName = this._taskName;
		//			data.Add(_data);
		//			return data;
		//		}
		
//		public void Refresh()
//		{
//			if(ObjectHasChanged != null)
//				ObjectHasChanged(this, new EventArgs());
//		}


		#endregion

		#region Propiedades
		public string IdTipoComprobanteActual
		{
			get{return _idTipoComprobanteActual;}
			set{_idTipoComprobanteActual=value;}
		}
		public string IdTipoComprobanteNuevo
		{
			get{return _idTipoComprobanteNuevo;}
			set{_idTipoComprobanteNuevo=value;}
		}
		public string NroComprobante
		{
			get{return this._nroComprobante;}
			set{this._nroComprobante=value;}
		}
        //Cristian Tarea 0000064 20110317
        public string NroComprobanteNuevo
        {
            get { return this._nroComprobanteNuevo; }
            set { this._nroComprobanteNuevo = value; }
        }
        //Fin Cristian
		public DataTable TiposComprobanteActual
		{
			get{return _tiposComprobanteActual;}
		}
		public DataTable TiposComprobanteNuevo
		{
			get{return _tiposComprobanteNuevo;}
		}

		#endregion

		#region Metodos Publicos

		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		public DataTable Search()
		{
			switch(this._processName)
			{
				case "ProcesoSoporteModificarComprobantesVentas":
					_resultado = tsa_Comprobantes.GetListByNroYTipoComprobante(this._nroComprobante, this._idTipoComprobanteActual);
					break;
				case "ProcesoSoporteModificarComprobantesCompras":
					_resultado = tpu_Comprobantes.GetListByNroYTipoComprobante(this._nroComprobante, this._idTipoComprobanteActual);
					break;
                    //Cristian Tarea 0000064 20110317
                case "ProcesoSoporteModificarComprobantesPagoGeneral":
                    _resultado = tsa_Comprobantes.GetListByNroYTipoComprobante(this._nroComprobante, this._idTipoComprobanteActual);
                    break;
                    //Fin Cristian
				default:
					break;
			}		
			return _resultado;
		}


		#endregion

		#region Metodos Privados
		private void ValidarDatos()
		{
			_errores.Clear();
            //Cristian Tarea 0000064 20110317 
			if (this.NroComprobante.Equals("--"))
				_errores.Add( new ItemDatasetError( "Soporte","Número de Comprobante","No ingresó el número de comprobante") );
            if (this.IdTipoComprobanteActual.Equals(string.Empty))
                _errores.Add(new ItemDatasetError("Soporte", "Tipo de Comprobante Actual", "No seleccionó el tipo de comprobante actual"));
         
            switch (this._processName)
            {
                case "ProcesoSoporteModificarComprobantesPagoGeneral":
                    if (this._nroComprobanteNuevo.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Soporte", "Nro nuevo de comprobante ", "No seleccionó el nuevo número de comprobante"));
                    break;
                case "ProcesoSoporteModificarComprobantesVentas":
                    if (this.IdTipoComprobanteNuevo.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Soporte", "Tipo de Comprobante Nuevo ", "No seleccionó el nuevo tipo de comprobante"));
                    break;
            }
            //Fin Cristian

			switch(_resultado.Rows.Count)
			{
				case 0:
					_errores.Add( new ItemDatasetError( "Soporte","Comprobante","No ha buscado ninguún comprobante") );
					break;
				case 1:
					DataRow row = _resultado.Rows[0];
					string nroComp = Convert.ToString(row["Numero"]);
					if ( !nroComp.Equals(this._nroComprobante.ToUpper()) )
						_errores.Add( new ItemDatasetError( "Soporte","NroComprobante","El número de Comprobante ingresado no coincide con el de la grilla") );
					break;
				default:
					_errores.Add( new ItemDatasetError( "Soporte","NroComprobante","La operación no puede realizarse; el número de Comprobante ingresado esta repetido.") );
					break;
			}			
		}
		

		#endregion

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}
	}
}
