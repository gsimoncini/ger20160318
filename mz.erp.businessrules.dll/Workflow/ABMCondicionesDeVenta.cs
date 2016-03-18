using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ABMCondicionesDeVenta.
	/// </summary>
	public class ABMCondicionesDeVenta:ITask,IPersistentTask{

		private tsa_CondicionesDeVentasDataset _dataCondVenta = new mz.erp.commontypes.data.tsa_CondicionesDeVentasDataset();
		private tsa_CondicionesDeVentaDetDataset _dataCondVentaDet = new mz.erp.commontypes.data.tsa_CondicionesDeVentaDetDataset();
		private tfi_TDCompTesoreria_CondicionesDeVentaDataset _dataTDCompTesoreria_CondVenta = new tfi_TDCompTesoreria_CondicionesDeVentaDataset();
		private Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset _dataTiposDeCompTDCompTesoreriaCondVentas = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();
		private tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset _dataCuentasTDCompTesoreriaCondVentas = new tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset();

		private string _idCondicionDeVenta;

		private ProcessManager _processParent;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;

		private CondicionDeVenta _condicionDeVenta;

		public ABMCondicionesDeVenta()
		{

		}

		#region Propiedades

		public string IdCondicionDeVenta
		{
			get {return _condicionDeVenta.IdCondicionDeVenta;}
			set 
			{
				_condicionDeVenta.IdCondicionDeVenta = value;
			}
		}

		public string Descripcion
		{
			get {return _condicionDeVenta.Descripcion;}
			set 
			{
				_condicionDeVenta.Descripcion = value;
			}
		}

		public Decimal Recargo
		{
			get {return _condicionDeVenta.Recargo;}
			set 
			{
				_condicionDeVenta.Recargo = value;
			}
		}

		public int Cuotas
		{
			get {return _condicionDeVenta.Cuotas;}
			set 
			{
				_condicionDeVenta.Cuotas = value;
			}
		}

		public short DiasDeVencimiento
		{
			get {return _condicionDeVenta.DiasDeVencimiento;}
			set 
			{
				_condicionDeVenta.DiasDeVencimiento = value;
			}
		}

		/*public string MetodoDeAsignacion
		{
			get {return _condicionDeVenta.MetodoDeAsignacion;}
			set 
			{
				_condicionDeVenta.MetodoDeAsignacion = value;
			}
		}*/

		public string MetodoDeAsignacionTipoDeComprobante
		{
			get {return _condicionDeVenta.MetodoDeAsignacionTipoDeComprobante;}
			set 
			{
				_condicionDeVenta.MetodoDeAsignacionTipoDeComprobante = value;
			}
		}

		public string MetodoDeAsignacionCuenta
		{
			get{return _condicionDeVenta.MetodoDeAsignacionCuenta;}
			set 
			{
				_condicionDeVenta.MetodoDeAsignacionCuenta = value;
			}
		}

		public string MetodoComparacion
		{
			get {return _condicionDeVenta.MetodoComparacion;}
			set 
			{
				_condicionDeVenta.MetodoComparacion = value;
			}
		}

		public bool Activo
		{
			get {return _condicionDeVenta.Activo;}
			set 
			{
				_condicionDeVenta.Activo = value;
			}
		}

		public TiposDeComprobantes ListaTiposDeComprobantesSeleccionados
		{ 
			get {return _condicionDeVenta.ListaTiposDeComprobantesSeleccionados;}
			set {
				_condicionDeVenta.ListaTiposDeComprobantesSeleccionados = value;
			}
		}

		public TiposDeComprobantes TiposDeComprobantes
		{ 
			get {return _condicionDeVenta.TiposDeComprobantes;}
			set 
			{
				_condicionDeVenta.TiposDeComprobantes = value;
			}
		}

		public FormasDePagos FormasDePago
		{ 
			get {return _condicionDeVenta.FormasDePago;}
			set {
				_condicionDeVenta.FormasDePago = value;
			}
		}

		public FormasDePagos ListaFormasDePagoSeleccionadas
		{ 
			get {return _condicionDeVenta.ListaFormasDePagoSeleccionadas;}
			set 
			{
				_condicionDeVenta.ListaFormasDePagoSeleccionadas = value;
			}
		}

		public Cuentas ListaCuentas
		{ 
			get {return _condicionDeVenta.ListaCuentas;}
			set 
			{
				_condicionDeVenta.ListaCuentas = value;
			}
		}

		public ArrayList ListaCuentasSeleccionadasABorrar
		{ 
			get {return _condicionDeVenta.ListaCuentasSeleccionadasABorrar;}
			set 
			{
				_condicionDeVenta.ListaCuentasSeleccionadasABorrar = value;
			}
		}

		private bool _todosLosComprobantes;
		public bool TodosLosComprobantes
		{
			get {return _todosLosComprobantes;}
			set
			{
				_todosLosComprobantes = value;
			}
		}

		private bool _permiteMetodoComparacion;
		public bool PermiteMetodoComparacion
		{
			get {return _permiteMetodoComparacion;}
			set 
			{
				_permiteMetodoComparacion = value;
			}
		}

		private bool _permiteMetodoAsignacionCuentas;
		public bool PermiteMetodoAsignacionCuentas
		{
			get {return _permiteMetodoAsignacionCuentas;}
			set 
			{
				_permiteMetodoAsignacionCuentas = value;
			}
		}		

		private string _contenedoresVisibles = string.Empty;
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}

		private string _contenedoresHabilitados = string.Empty;	
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}

 		private string _leyendaFormulario = "Condiciones de Venta";	
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(_processParent.Process.ProcessName, _taskName,"LeyendaFormulario");
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
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get 
			{
				return _preguntarAlCancelar ;
				
			}
			set 
			{
				_preguntarAlCancelar =value;
				
			}
		}
		
		#endregion


		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

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
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{

		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{
			string proceso = _processParent.Process.ProcessName;

			_condicionDeVenta = new CondicionDeVenta(null,proceso);
			TiposDeComprobantes = mz.erp.businessrules.tsy_TiposDeComprobantes.GetTiposDeComprobanteRequiereCondicionDeVenta();
			FormasDePago = mz.erp.businessrules.tfi_TDCompTesoreria.GetFormasDePago();
			
			_contenedoresHabilitados= Variables.GetValueString(proceso, _taskName,"ContenedoresHabilitados");		
			_contenedoresVisibles = Variables.GetValueString(proceso, _taskName,"ContenedoresVisibles");
	
			TodosLosComprobantes = Variables.GetValueBool(proceso, _taskName, "TodosLosComprobantes");
			MetodoDeAsignacionTipoDeComprobante = Variables.GetValueString(proceso, _taskName, "MetodoAsignacionComprobante");
			MetodoDeAsignacionCuenta = Variables.GetValueString(proceso, _taskName, "MetodoAsignacionCuenta");
			PermiteMetodoComparacion = Variables.GetValueBool(proceso, _taskName, "PermiteMetodoComparacion");
			MetodoComparacion = Variables.GetValueString(proceso, _taskName, "MetodoComparacion");
			PermiteMetodoAsignacionCuentas = Variables.GetValueBool(proceso, _taskName, "PermiteMetodoAsignacionCuenta");			
			PreguntarAlCancelar = Variables.GetValueBool(proceso, _taskName, "PreguntarAlCancelar");			
		}


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
			return true;
		}

		public bool IsValid()
		{
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
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

		private void ValidarDatos()
		{
			_errores.Clear();
			Descripcion=Descripcion.Trim();			
			if (Descripcion.CompareTo(string.Empty) == 0)
			{
				_errores.Add( new ItemDatasetError( "Condicion de Venta","Descripcion","El campo no puede estar vacío") );
			}

			/*tfi_TDCompTesoreria_CondicionesDeVentaDataset data = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,null,IdCondicionDeVenta);
			tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaDataTable tabla = data.tfi_TDCompTesoreria_CondicionesDeVenta;

			if (tabla.Rows.Count == 1) 
			{
				string fp = tabla.Rows[0]["IdTDCompTesoreria"].ToString();
				if ((ListaFormasDePagoSeleccionadas.Count != 0)&&((fp == "NULL") || (fp == string.Empty)))
				{
					_errores.Add(new ItemDatasetError("Condicion de Venta","Formas de Pago","No se debe seleccionar ninguna forma de pago"));
				}
			}*/

			if (DiasDeVencimiento < 0)
			{
				_errores.Add(new ItemDatasetError("Condicion de Venta","Dias de vencimiento","El campo no puede ser menor a 0"));
			}
			else 
			{
				if (DiasDeVencimiento == 0)
				{// al menos una forma de pago y no tiene una forma de pago asociada en null
					if (ListaFormasDePagoSeleccionadas.Count == 0)
					{
						_errores.Add(new ItemDatasetError("Condicion de Venta","Formas de Pago","Debe seleccionar por lo menos una forma de pago"));
					}					
				}
				else 
				{//ninguna forma de pago
					if (ListaFormasDePagoSeleccionadas.Count != 0)
					{
						_errores.Add(new ItemDatasetError("Condicion de Venta","Formas de Pago","No se debe seleccionar ninguna forma de pago"));
					}			
				}
			}
		}

		public bool ClienteRepetido(string CodigoCuenta)
		{
			return _condicionDeVenta.ClienteRepetido(CodigoCuenta);
		}

		public void UpdateCuentas(string CodigoCuenta)
		{
			_condicionDeVenta.UpdateCuentas(CodigoCuenta);
		}
/*
		public void EliminarCuentasSeleccionadas()
		{
			_condicionDeVenta.EliminarCuentasSeleccionadas();
		}*/
		/*
		public void Borrar(ArrayList ListaCuentas)
		{
			_condicionDeVenta.Borrar(ListaCuentas);
		}*/
		/*
		public void UpdateCuentasCondicionDeVenta(string IdCondicionDeVenta)
		{
			_condicionDeVenta.UpdateCuentasCondicionDeVenta(IdCondicionDeVenta);
		}*/

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = _taskName;
			data.Add(this._dataCondVenta);
			data.Add(this._dataCondVentaDet);
			data.Add(this._dataTDCompTesoreria_CondVenta);
			data.Add(this._dataTiposDeCompTDCompTesoreriaCondVentas);
			data.Add(this._dataCuentasTDCompTesoreriaCondVentas);
			return data;
		}


		public void Commit()
		{
			_condicionDeVenta.Commit();
			_dataCondVenta = _condicionDeVenta.DataCondicionDeVenta;
			_dataCondVentaDet = _condicionDeVenta.DataCondicionDeVentaDet;
			_dataTDCompTesoreria_CondVenta = _condicionDeVenta.DataTDComp_Tesoreria_CondDeVenta;
			_dataTiposDeCompTDCompTesoreriaCondVentas = _condicionDeVenta.DataTiposDeComp_Tesoreria_CondVenta;
			_dataCuentasTDCompTesoreriaCondVentas = _condicionDeVenta.DataCuenta_TDComp_Tesoreria;
			
		}

		public void Flush(string IdTransaction)
		{/*
			if (_state != BRTypes.ABMState.Consulta)
			{
				mz.erp.businessrules.tsh_Productos.Update( _rowProductos, IdTransaction, new SentenciasReplicacion() );
				_sentencia = GenerateReplication();
				PutErrorOnDataSet(_rowProductos);
			}*/

			mz.erp.dataaccess.tsa_CondicionesDeVentas.Update(_dataCondVenta.tsa_CondicionesDeVentas, IdTransaction);
			if (_dataCondVenta.tsa_CondicionesDeVentas.Rows[0].RowState != System.Data.DataRowState.Deleted)
			{
				this._idCondicionDeVenta = _dataCondVenta.tsa_CondicionesDeVentas.Rows[0]["IdCondicionDeVenta"].ToString();
			}

			_dataCondVentaDet.tsa_CondicionesDeVentaDet.Rows[0]["IdCondicionDeVentaDet"] = this._idCondicionDeVenta;
			mz.erp.dataaccess.tsa_CondicionesDeVentaDet.Update(_dataCondVentaDet.tsa_CondicionesDeVentaDet, IdTransaction);

			foreach(tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row in _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
			{
				if (row.RowState != System.Data.DataRowState.Deleted){
					row["IdCondicionDeVenta"] = this._idCondicionDeVenta;}
			}

			mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.Update(_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta, IdTransaction);	
			
			foreach(Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTiposDeComprobantes in _dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
			{
				if (rowTiposDeComprobantes.RowState != System.Data.DataRowState.Deleted){
					rowTiposDeComprobantes["IdCondicionDeVenta"] = this._idCondicionDeVenta;}
			}
			mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Update(_dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria, IdTransaction);
			
			foreach(tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow  rowCuentas in _dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Rows)
			{
				if (rowCuentas.RowState != System.Data.DataRowState.Deleted){
					rowCuentas["IdCondicionDeVenta"] = this._idCondicionDeVenta;}
			}
			mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Update(_dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria, IdTransaction);
		}

		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			replication.Destino = null;
			replication.VersionBD = null;
			//replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
		}

		public void PutErrorOnDataSet(System.Data.DataRow row)
		{/*
			_errors.Clear();
			if (_rowProductos.HasErrors)
			{
				System.Data.DataColumn[] columnasConError = row.GetColumnsInError();
				for(int i=0;columnasConError.Length<i;i++)
				{
					ItemDatasetError error = new ItemDatasetError( ((System.Data.DataColumn)columnasConError[i]).Table.TableName,  ((System.Data.DataColumn)columnasConError[i]).ColumnName, row.GetColumnError( columnasConError[i] ) );
					_errors.Add( error );
				}
			}*/
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _sentencia;
			
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion

	}
}
