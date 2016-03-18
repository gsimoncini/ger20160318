using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Data.SqlClient;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de FiscalCierre.
	/// </summary>
	public class Autorizar: ITask, IPersistentTask
	{
		public Autorizar()
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
			/*if (!(_isValid))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Autorizaciones","","Ha ocurrido un error al intentar imprimir el cierre"));
			}*/
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
			tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = tsh_Autorizaciones.GetByPk(_idAutorizacion);
			if (_autorizado) 
			{
				row.Estado = "A";
			}
			else 
			{
				row.Estado = "R";
			}
			row.Observaciones = _observaciones;
			row.IdResponsableDeAutorizacion = Security.IdPersona;
			_data.tsh_Autorizaciones.ImportRow(row);
			//_isValid = true;			
		}

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
			replication.NombreTabla = "dataaccess.tsa_CuentasCondicionesDeVenta";			
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
			dataaccess.tsh_Autorizaciones.Update((DataTable)_data.tsh_Autorizaciones, trx, _replication);			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		#endregion
		
		#region Variables privadas
		private string _taskName = string.Empty;
		private bool _isValid = false;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private tsh_AutorizacionesDataset _data = new tsh_AutorizacionesDataset();
		private ProcessManager _processParent;
	
		private bool _autorizado = false;
		public bool Autorizado
		{
			set 
			{
				_autorizado = value;
			}
		}
		private DataTable _solicitudes = null;
		public DataTable Solicitudes 
		{
			get 
			{
				return _solicitudes;
			}
		}
		private string _observaciones = String.Empty;
		public string Observaciones 
		{
			/*get 
			{
				return _observaciones;
			}*/
			set 
			{
				_observaciones = value;
			}
		}

		private string _idAutorizacion = String.Empty;
		public string IdAutorizacion 
		{
			/*get 
			{
				return _idAutorizacion;
			}*/
			set 
			{
				_idAutorizacion = value;
			}
		}


		#endregion

		/*public CuentaCondicionesDeVenta GetCondicionesDeVenta(string CodigoCuenta) 
		{
			string IdCuenta = tsa_Cuentas.GetPkByUk(CodigoCuenta);
			_idCuenta = IdCuenta;

			CuentaCondicionesDeVenta condiciones = new CuentaCondicionesDeVenta();
			tsa_CondicionesDeVentasDataset Datacv = tsa_CondicionesDeVentas.GetList();
			
			foreach( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow Rowcv in Datacv.tsa_CondicionesDeVentas.Rows)
			{
				CuentaCondicionDeVenta condicion = new CuentaCondicionDeVenta();
				condicion.Descripcion = Rowcv.Descripcion;				
				condicion.IdCondicionDeVenta = Rowcv.IdCondicionDeVenta;
				condicion.Valor = businessrules.tsa_CuentasCondicionesDeVenta.GetActivo(IdCuenta, Rowcv.IdCondicionDeVenta);				
				condiciones.AddProductoImpuesto(condicion);								
			}			
			return condiciones;
		}*/


		public void GetSolicitudes()
		{
			ArrayList Motivos = new ArrayList();	
			string variable = string.Empty;
			bool permitePerfil = false;
			/*
			//Obtengo el motivo para CONDICIÓN DE VENTA si alguno de los perfiles lo habilita al usuario
			string variable = "Seguridad.Autorizaciones.PermiteCondicionDeVenta";
			bool permitePerfil = Security.AllowFunction(variable);
			if (permitePerfil)
			{
				variable = "Seguridad.Autorizaciones.TextoMotivo.CondicionDeVenta";
				Motivos.Add(Variables.GetValueString(variable));

			}

			//Obtengo el motivo para LIMITE DE CREDITO si alguno de los perfiles lo habilita al usuario
			variable = "Seguridad.Autorizaciones.PermiteCuentaCorriente";
			permitePerfil = Security.AllowFunction(variable);
			if (permitePerfil) 
			{
				variable = "Seguridad.Autorizaciones.TextoMotivo.CuentaCorriente";
				Motivos.Add(Variables.GetValueString(variable));
			}

			//Obtengo el motivo para DESCUENTO si alguno de los perfiles lo habilita al usuario
			variable = "Seguridad.Autorizaciones.PermiteDescuento";
			permitePerfil = Security.AllowFunction(variable);
			if (permitePerfil) 
			{
				variable = "Seguridad.Autorizaciones.TextoMotivo.Descuento";
				Motivos.Add(Variables.GetValueString(variable));
			}			

			//Obtengo el motivo para DESCUENTO si alguno de los perfiles lo habilita al usuario
			variable = "Seguridad.Autorizaciones.PermiteTipoComprobante";
			permitePerfil = Security.AllowFunction(variable);
			if (permitePerfil) 
			{
				variable = "Seguridad.Autorizaciones.TextoMotivo.TiposDeComprobante";
				Motivos.Add(Variables.GetValueString(variable));
			}
			*/
			DataSet data = mz.erp.businessrules.sy_Variables.GetList("Seguridad.Autorizaciones.Permite");
			foreach(DataRow row in data.Tables[0].Rows)
			{
				variable = Convert.ToString(row["IdVariable"]);
				permitePerfil = Security.AllowFunction(variable);
				if (permitePerfil) 
				{
					variable = "Seguridad.Autorizaciones.TextoMotivo." + variable.Replace("Seguridad.Autorizaciones.Permite","") ;
					Motivos.Add(Variables.GetValueString(variable));
				}
			}

			string Motivo = systemframework.Util.PackString(Motivos);
			_solicitudes = businessrules.tsh_Autorizaciones.GetSolicitudes(Motivo);
		}

		public string GetDatos(string IdAutorizacion) 
		{					
			foreach (DataRow row in _solicitudes.Rows) 
			{
				if (row["IdAutorizacion"].ToString() == IdAutorizacion) 
				{
					return (row["Datos"].ToString());					
				}
			}
			return String.Empty;
		}

		public string GetObservaciones(string IdAutorizacion) 
		{					
			foreach (DataRow row in _solicitudes.Rows) 
			{
				if (row["IdAutorizacion"].ToString() == IdAutorizacion) 
				{
					return (row["Observaciones"].ToString());					
				}
			}
			return String.Empty;
		}

	}
}


