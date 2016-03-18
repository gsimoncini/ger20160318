using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.dataaccess;



namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de FiscalCierre.
	/// </summary>
	public class AbmCuentasCondicionesDeVenta: ITask, IPersistentTask
	{
		public AbmCuentasCondicionesDeVenta()
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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			/*if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				LoadDataFromComprobanteDeVenta( _comprobante );
			}*/
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init

			//_cuentaCondicionesDeVenta.
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
			
			if (!(true))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Impresora Fiscal","Cierre","Ha ocurrido un error al intentar imprimir el cierre"));
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

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{
			
			CollectionBase aux = this._cuentaCondicionesDeVenta;
			foreach (CuentaCondicionDeVenta condicion in aux) 
			{
				bool Activo = condicion.Valor;
				string IdCondicionDeVenta = condicion.IdCondicionDeVenta;
				tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow cv = tsa_CondicionesDeVentas.GetByPk(IdCondicionDeVenta);
                //El Metodo de Asignacion se fija en I porque solo se levantan las CV que son por Inclusion para las Cuentas
                string MetodoDeAsignacion = "I";
				string operacion = String.Empty;
				if (Activo) 
				{
					if (MetodoDeAsignacion == "E") 
					{
						operacion = "baja";
						
					}
					else 
					{
						operacion = "alta";
					}
				}
				else 
				{
					if (MetodoDeAsignacion == "E") 
					{
						operacion = "alta";
					}
					else 
					{
						operacion = "baja";
					}
				}
                //ojooooo falta terminar
                //Commit2(operacion, _idCuenta, IdCondicionDeVenta, IdTDCompTesoreria);				
            }
        }

        //ojoooo falta terminar
        /*private void Commit2(string operacion, string IdCuenta, string IdCondicionDeVenta, string IdTDCompTesoreria) 
        {
            tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row = null;
            if (operacion.ToUpper() == "ALTA") 
            {
                row = tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetByPk(IdCuenta,  IdCondicionDeVenta , IdTDCompTesoreria);
                if (row == null) 
                {		
					
                    row = _data.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();						
                    row.IdCuenta = IdCuenta;
                    row.IdCondicionDeVenta = IdCondicionDeVenta;
                    row.idTDCompTesoreria = IdTDCompTesoreria;
                    _data.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row);
                    //_data.tsa_CuentasCondicionesDeVenta.ImportRow((DataRow) row);
                }
            }
            else
            {
                row = tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetByPk(IdCuenta,  IdCondicionDeVenta , IdTDCompTesoreria );
                if (row != null) 
                {					
                    row.Delete();
                    _data.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.ImportRow(row);						
                }
            }						
        }
*/
		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria";			
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			//array.Add( (DataSet) this.DatasetComprobante);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			//data.Add( this.DatasetComprobante );
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
            //			ojooooo falta terminar
            //dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Update((DataTable) _data.tsa_CuentasCondicionesDeVenta_TDCompTesoreria, trx, _replication );
            if (OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		
		#region Variables privadas
		private string _taskName = string.Empty;
		private string _idCuenta = string.Empty;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private CuentaCondicionesDeVenta _cuentaCondicionesDeVenta = new CuentaCondicionesDeVenta();		
		tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset _data = new tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset();		

		public CuentaCondicionesDeVenta CuentaCondicionesDeVenta
		{
			set 
			{
				_cuentaCondicionesDeVenta = value;
			}
		}
	
		#endregion

		public CuentaCondicionesDeVenta GetCondicionesDeVenta(string CodigoCuenta) 
		{
			string IdCuenta = tsa_Cuentas.GetPkByUk(CodigoCuenta);
			_idCuenta = IdCuenta;

			CuentaCondicionesDeVenta condiciones = new CuentaCondicionesDeVenta();
            tsa_CondicionesDeVentasDataset Datacv = tsa_CondicionesDeVentas.GetList();

            foreach (tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow Rowcv in Datacv.tsa_CondicionesDeVentas.Rows)
            {
                /* Silvina 20100602 - Tarea 777 */
                Cuentas ctas = tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetCuentas(Rowcv.IdCondicionDeVenta);
                if ((ctas.Count != 0) && ((Cuenta)ctas[0]).MetodoDeAsignacion.ToUpper().Equals("I"))
                {
                /* Fin Silvina */
                    CuentaCondicionDeVenta condicion = new CuentaCondicionDeVenta();
                    condicion.Descripcion = Rowcv.Descripcion;
                    condicion.IdCondicionDeVenta = Rowcv.IdCondicionDeVenta;
                    condicion.Valor = businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetActivo(IdCuenta, Rowcv.IdCondicionDeVenta, null);
                    condiciones.AddProductoImpuesto(condicion);
                }
            }
			return condiciones;
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

	}
}


