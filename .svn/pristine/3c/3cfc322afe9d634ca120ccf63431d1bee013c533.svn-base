using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de PagarServiciosGastosComptras.
	/// </summary>
	public class PagarServiciosGastosCompras: ITask, IPersistentTask
	{
		
		#region Constructores
		
		public PagarServiciosGastosCompras()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region Variables Privadas

		
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private string _observaciones = string.Empty;
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idInstanciaCaja = string.Empty;
		private Valores _valores = new Valores();
		private ArrayList _comprobantes = new ArrayList();
		private string _idResponsable = string.Empty;
		private string _idTDCompTesoreriaDefault = string.Empty;
			

		private DataTable _filtroCajas = new DataTable();
		private DataTable _usuarios = new DataTable();

		private Hashtable _tablaFormasDePagosComprobantesTesoreria = new Hashtable();

		private string _idAutorizacion = string.Empty;



		#endregion

		#region Propiedades

		public int CantidadComprobantesSeleccionados
		{
			get
			{
				int total = 0;
				foreach(ItemComprobanteDeCompraView item in this._comprobantes)
				{
					if( item.Selected )
						total++;
				}
				return total;
			}
		}


		public string IdTDCompTesoreriaDefault 
		{
			get{return _idTDCompTesoreriaDefault;}			
		}

		public decimal TotalSaldoComprobantesSeleccionados
		{
			get
			{
				decimal total = 0;
				foreach(ItemComprobanteDeCompraView item in this._comprobantes)
				{
					if(item.Selected)
						total = total + item.Saldo;
				}
				return total;
			}
		}


		public ArrayList Comprobantes
		{
			get{return _comprobantes;}
		}

		public decimal Total
		{
			get
			{
				decimal _total  = 0;
				foreach(Valor valor in this._valores.MisValores)
				{
					_total = _total + valor.MontoCotizado;

				}
				return _total;
			}
		}

		public string IdResponsable 
		{
			get{return _idResponsable;}
			set{_idResponsable = value;}
		}

		public string Observaciones
		{
			set{_observaciones = value;}
			get{return _observaciones;}
		}

		public string IdInstanciaCaja
		{
			get { return _idInstanciaCaja; }
			set {_idInstanciaCaja = value ;}
		}

		public DateTime Fecha
		{
			get {return _fecha ; }
			set 
			{
				DateTime actual = mz.erp.businessrules.Sistema.DateTime.Now;
				_fecha = new DateTime(value.Year, value.Month,value.Day, actual.Hour, actual.Minute, actual.Second, actual.Millisecond);
			}
		}

		public ArrayList Valores
		{
			get { return _valores.MisValores ; }
		}

		public DataTable Usuarios
		{
			get{return _usuarios;}
		}

		public DataTable Cajas
		{
			get{return _filtroCajas;}
		}
	
		public string LeyendaFormulario
		{
			get
			{
				string _nombreProceso = _processParent.Process.ProcessName;
				string _nombreTarea = ((ITask)this).GetTaskName();
				string _leyenda = Variables.GetValueString(_nombreProceso, _nombreTarea, "LeyendaFormulario");
				if (_leyenda ==null || _leyenda == "")
					return _nombreProceso+" "+_nombreTarea;
				return _leyenda;
			}
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}
		
	
		public bool HabilitarContraseña 
		{
			get{	return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "HabilitarContraseña", false);}
			
		}
		
		public bool AllowEditCaja
		{
			get { 	return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditCaja", true); }
		}
		
		
		public bool AllowEditFecha
		{
			get { return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditFecha", true); }
		}
		public bool AllowEditObservaciones
		{
			get{return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Editar.Observaciones", true);} 
		}

		public bool AllowAddValores
		{
			get{return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Editar.AllowAddValores", true);}
		}

		public bool AllowDeleteValores
		{
			get{return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Editar.AllowDeleteValores", true);}
		}

		public bool AllowSearchValores
		{
			get{return Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Editar.AllowSearchValores", true);}
		}

		
		private bool _allowEditResponsable =false;
		public bool AllowEditResponsable 
		{
			get{return _allowEditResponsable ;}
			set {_allowEditResponsable=value;}
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


	
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public virtual bool AllowPrevious()
		{
			return true;
		}
		public  void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes)
				&& this._processParent.Process.ProcessName.Equals("ProcesoPagarServiciosGastosCompras")
				)
			{
				SeleccionarComprobantesDeCompraPendientes sccp = (SeleccionarComprobantesDeCompraPendientes) sender;
				LoadDataFromSeleccionarComprobantesDeCompraPendientes(sccp);

			}
			if (sender.GetType() == typeof( mz.erp.businessrules.SolicitarAutorizacion ))
			{
				SolicitarAutorizacion solicitar = (SolicitarAutorizacion) sender;
				_idAutorizacion = solicitar.IdAutorizacion;
				
			}
		}

		private void LoadDataFromSeleccionarComprobantesDeCompraPendientes(SeleccionarComprobantesDeCompraPendientes sender)
		{
			DataView result = new DataView( sender.Result);
			_comprobantes.Clear();
			result.RowFilter = "Marca = true";
			foreach(DataRowView row in result)
			{
				ItemComprobanteDeCompraView item = new ItemComprobanteDeCompraView(_tablaFormasDePagosComprobantesTesoreria);
				item.IdComprobante = Convert.ToString(row["IdComprobante"]);
				item.IdProveedor = Convert.ToString(row["IdProveedor"]);
				item.Proveedor = Convert.ToString(row["Nombre"]);
				item.Total = Convert.ToDecimal(row["Total"]);
				item.Fecha = Convert.ToDateTime(row["Fecha"]);
				item.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
				item.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				item.Comprobante = Convert.ToString(row["Comprobante"]);
				item.Numero = Convert.ToString(row["Numero"]);
				item.Saldo = Convert.ToDecimal(row["Saldo"]);
				item.IdCuentaImputacion = Convert.ToString(row["IdTipoMovimiento"]);
				item.IdSubcuentaImputacion = Convert.ToString(row["IdSubTipoMovimiento"]);
				item.CuentaImputacion = Convert.ToString(row["TipoMovimiento"]);
				item.SubcuentaImputacion = Convert.ToString(row["SubTipoMovimiento"]);
				item.Signo = Convert.ToInt16(row["Signo"]);
				item.SelectedChanged +=new EventHandler(item_SelectedChanged);
				_comprobantes.Add(item);
				
			}
		}
		


		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}
		

		public  bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		public virtual bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			if (_idInstanciaCaja != null && _idInstanciaCaja != string.Empty)
			{

				if(true)// Variable q indica si se realiza la validacion
				{
					Hashtable table = new Hashtable();
					foreach ( Valor valor in this._valores.MisValores )  
					{	
						if(valor.Agrupado)
						{
							string key = valor.IdTDCompTesoreria + '-' + valor.IdMoneda +'-' + valor.Comprobante + '-' + valor.Moneda;
							if(!table.ContainsKey(key)) table.Add(key, 0);
							decimal monto  = Convert.ToDecimal(table[key]);
							monto = monto + valor.Monto;
							table[key] = monto;

						}
					}
					foreach(string key in table.Keys)
					{
						string[] partes = key.Split( new char[]{'-'});
						string IdTDcomp = partes[0];
						string IdM = partes[1];
						string Comp = partes[2];
						string Mon = partes[3];
						decimal total = Convert.ToDecimal(table[key]);
						//decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobanteAnterior( dvm.IdTDCompTesoreria, dvm.IdMoneda , tfi_InstanciasCaja.GetByPk(IdCaja).IdCaja);
						decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobante( IdTDcomp, IdM , _idInstanciaCaja);
						if (totalPorTDComp < total) //dvm.MontoCotizado)
						{
							_errores.Add( new ItemDatasetError( this.GetProcessManagerParent().Process.ProcessName,"Valor","El importe ingresado en "+ Comp + " "+ Mon + " supera el saldo disponible." +
								"El Monto actual en la caja es de " + totalPorTDComp));
							IsValid = false;
						}
					}
							
						
				}

			}
			
			return IsValid;
		}

		public  void Init()
		{
			_filtroCajas = tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0];
			if (_filtroCajas.Rows.Count > 0)
			{
				_idInstanciaCaja = Convert.ToString(_filtroCajas.Rows[0]["IdInstanciaCaja"]);
			}
			_usuarios = sy_Usuarios.GetList().sy_Usuarios;
			_idResponsable = Security.IdPersona;
			_idTDCompTesoreriaDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ComprobanteTesoreria.Default");
			string ListaEfectivo = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Efectivo.ListaComprobanteTesoreria");
			string ListaChequesPropios = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ChequesPropios.ListaComprobanteTesoreria");
			string ListaChequesTerceros = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ChequesTerceros.ListaComprobanteTesoreria");
			string ListaTransferenciasBancarias = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "TransferenciasBancarias.ListaComprobanteTesoreria");
			CargarTableFDPComprobantesTesoreria (mz.erp.systemframework.Util.Parse(ListaEfectivo, ","), "Efectivo");
			CargarTableFDPComprobantesTesoreria( mz.erp.systemframework.Util.Parse(ListaChequesPropios, ","), "ChequesPropios");
			CargarTableFDPComprobantesTesoreria( mz.erp.systemframework.Util.Parse(ListaChequesTerceros, ","), "ChequesTerceros");
			CargarTableFDPComprobantesTesoreria( mz.erp.systemframework.Util.Parse(ListaTransferenciasBancarias, ","), "TransferenciasBancarias");
		}

		private void CargarTableFDPComprobantesTesoreria(ArrayList ListaCompTesoreria, string FDP)
		{
			foreach(string idCompTesoreria in ListaCompTesoreria)
			{
				if(idCompTesoreria != null && idCompTesoreria != string.Empty)
				{
					if(!_tablaFormasDePagosComprobantesTesoreria.Contains(idCompTesoreria))
					{
						_tablaFormasDePagosComprobantesTesoreria.Add(idCompTesoreria, FDP);
					}
				}
			}
		}
		public  bool AllowShow()
		{			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public  ItemsDatasetErrors GetErrors()
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

		#region Metodos Publicos

		public void Seleccionar(bool selected)
		{	
			foreach(ItemComprobanteDeCompraView item in _comprobantes)
			{
				item.SelectedChanged -=new EventHandler(item_SelectedChanged);
				item.Selected = selected;
				item.SelectedChanged +=new EventHandler(item_SelectedChanged);
			}
			if(ComprobantesSelectedChanged != null)
				ComprobantesSelectedChanged(this, EventArgs.Empty);

		}

		public bool HayComprobantesSinSaldo()
		{
			foreach(ItemComprobanteDeCompraView item in _comprobantes)
			{
				if(item.Selected && item.Saldo <= 0) return true; 
			}
			return false;
		}

		public bool HayComprobantesSeleccionados()
		{
			foreach(ItemComprobanteDeCompraView item in _comprobantes)
			{
				if(item.Selected) return true;
			}
			return false;
			

		}

		public void BorrarValor(Valor selected)
		{
			foreach(ItemComprobanteDeCompraView item in this._comprobantes)
			{
				item.RemoveValor(selected);
			}
		}

		
		public void AddValor(Valor valor)
		{
			bool ok = false;
			foreach(ItemComprobanteDeCompraView item in this._comprobantes)
			{
				if(item.Selected)
				{
					if(this.CantidadComprobantesSeleccionados == 1)
					{
						if(!( Math.Round(item.Saldo,2) < Math.Round(valor.MontoCotizado,2)))
						{
							ok = true;
							item.AddValor(valor, valor.MontoCotizado );
						}
					}
					else
						if(this.CantidadComprobantesSeleccionados > 1 && valor.Agrupado)
						{
							ok = true;
							item.AddValor(valor, item.Saldo);
						}
				}
			}
			if(ok)
				_valores.Add(valor);
		}

		public ArrayList GetValores(object selected)
		{
			return ((ItemComprobanteDeCompraView)selected).Valores;
		}

		public bool Contains(Valor valor)
		{
			foreach(Valor item in this._valores.MisValores)
			{
				if(item.State.ToUpper().Equals("EDIT") && item.IdValor.Equals(valor.IdValor))
					return true;
			}
			return false;
		}

		public ArrayList GetComprobantes(Valor valor)
		{
			ArrayList result = new ArrayList();
			foreach(ItemComprobanteDeCompraView item in this._comprobantes)
			{
				if(item.Valores.Contains(valor))
				{
					result.Add(item);
				}	
			}
			return result;
		}


		#endregion

		#region Eventos
		
			public event EventHandler ComprobantesSelectedChanged;
			
		#endregion

		#region Metodos Privados

		private void item_SelectedChanged(object sender, EventArgs e)
		{
			if(ComprobantesSelectedChanged != null)
				ComprobantesSelectedChanged(this, EventArgs.Empty);
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		private tpu_ComprobanteDetalleDeValoresDataset _dataComprobantesValores = new tpu_ComprobanteDetalleDeValoresDataset();
		private tpu_ComprobanteDetalleDeudaDataset _dataComprobanteDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();
		private tpu_ComprobantesPagoDataset _dataCabecera = new tpu_ComprobantesPagoDataset();
		private tfi_ValoresExDataset _dataValores = new tfi_ValoresExDataset();



		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataCabecera);
			data.Add( (DataSet) this._dataComprobantesValores);
			data.Add( (DataSet) this._dataComprobanteDetalleDeuda);
			data.Add( (DataSet) this._dataValores);
			return data;
		}

		private void CommitCabecera()
		{
			
			
			tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoRow rowC = _dataCabecera.tpu_ComprobantesPago.Newtpu_ComprobantesPagoRow();
			mz.erp.businessrules.tpu_ComprobantesPago.SetRowDefaultValues(rowC);
			rowC.IdAutorizacion = _idAutorizacion;
			rowC.IdResponsable = this._idResponsable;
			rowC.IdInstanciaCaja = this._idInstanciaCaja;
			_dataCabecera.tpu_ComprobantesPago.Addtpu_ComprobantesPagoRow(rowC);
			foreach(ItemComprobanteDeCompraView item in this._comprobantes)
			{
				foreach(RealcionItemComprobanteDeCompraValor rel in item.RealcionesItemComprobanteDeCompraValor)
				{
					tpu_ComprobanteDetalleDeValoresDataset.tpu_ComprobanteDetalleDeValoresRow row = _dataComprobantesValores.tpu_ComprobanteDetalleDeValores.Newtpu_ComprobanteDetalleDeValoresRow();
					mz.erp.businessrules.tpu_ComprobanteDetalleDeValores.SetRowDefaultValues(row);
					row.IdComprobante = item.IdComprobante; 
					row.IdValor = rel.MiValor.IdValor; 
					row.IdTipoDeComprobante = item.IdTipoDeComprobante;
					row.Numero = item.Numero;
					row.Monto = rel.MontoAbonado;
					row.IdMoneda = ComprobantesRules.Contabilidad_MonedaReferencia;
					row.IdCotizaicon = ComprobantesRules.Contabilidad_CotizacionReferencia;
					row.MontoSinRecargos = rel.MontoAbonado;
					row.IdResponsable = this._idResponsable;
					row.IdInstanciaCaja = this._idInstanciaCaja;
					row.IdAutorizacion = _idAutorizacion;
					_dataComprobantesValores.tpu_ComprobanteDetalleDeValores.Addtpu_ComprobanteDetalleDeValoresRow(row);
				}
				DataRow rowCompDD = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk( item.IdComprobante, 1);
				rowCompDD["Saldo"] = item.Saldo * item.Signo;
				_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowCompDD);
			}
		}

		private void CommitValores()
		{

			/* * *
			 * Ver tema del signo, si debe depender del tipo de operacion q se esta haciendo
			 * * */
			int signo = -1;
			this._valores.CommitPagosServiciosGastos(this._idInstanciaCaja, signo);
			_dataValores = this._valores.DataValores;
		}

		public void Commit()
		{
			this.CommitCabecera();
			this.CommitValores();
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion replicacion = GetSentenceReplication();
			mz.erp.dataaccess.tfi_ValoresEx.Update(_dataValores, IdTransaction, replicacion);
			foreach(DataRow rowValor in _dataValores.tfi_Valores.Rows)
			{
				string IdValorViejo = Convert.ToString(rowValor["OldIdValor"]);
				string IdValorNuevo = Convert.ToString(rowValor["IdValor"]);
				foreach(DataRow rowCV in _dataComprobantesValores.tpu_ComprobanteDetalleDeValores.Rows)
				{
					string IdValor = Convert.ToString(rowCV["IdValor"]);
					if(IdValor.Equals(IdValorViejo))
					{
						rowCV["IdValor"] = IdValorNuevo;
					}

				}
			}
			mz.erp.dataaccess.tpu_ComprobantesPago.Update(_dataCabecera.tpu_ComprobantesPago, IdTransaction);
			string IdComprobantePago = Convert.ToString(_dataCabecera.tpu_ComprobantesPago.Rows[0]["IdComprobantePago"]);
			foreach(DataRow rowd in _dataComprobantesValores.tpu_ComprobanteDetalleDeValores.Rows)
			{
				rowd["IdComprobantePago"] = IdComprobantePago;
			}
			mz.erp.dataaccess.tpu_ComprobanteDetalleDeValores.Update(_dataComprobantesValores.tpu_ComprobanteDetalleDeValores, IdTransaction, replicacion);
			mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update(_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda, IdTransaction, replicacion);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public SentenciasReplicacion GetSentenceReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_comprobantesDetalleDeValores";			
			return replication;
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion
	}

	public sealed class RealcionItemComprobanteDeCompraValor
	{
		private decimal _montoAbonado = 0;
		
		private Valor _valor = new Valor();

		public RealcionItemComprobanteDeCompraValor(decimal pago, Valor valor)
		{
			_montoAbonado = pago;
			//_montoAbonadoMonedaOrigen = pago/valor.ValorCotizacion;
			_valor = valor;
		}

		public decimal MontoAbonado
		{
			get{return _montoAbonado;}
		}

		
		public Valor MiValor
		{
			get{return _valor;}
		}

	}

	public sealed class ItemComprobanteDeCompraView
	{
		private string _idComprobante = string.Empty;
		private string _comprobante = string.Empty;
		private string _numero = string.Empty;
		private string _idTipoDeComprobante = string.Empty;
		private decimal _total = 0;
		private decimal _saldo = 0;
		private string _idCuentaImputacion = string.Empty;
		private string _idSubcuentaImputacion = string.Empty;
		private string _cuentaImputacion = string.Empty;
		private string _subcuentaImputacion = string.Empty;
		private string _idProveedor = string.Empty;
		private string _proveedor = string.Empty;
		private decimal _pagoEfectivo = 0;
		private decimal _pagoChequePropio = 0;
		private decimal _pagoChequeTercero = 0;
		private decimal _pagoTransferenciaBancaria = 0;
		private DateTime _fecha = DateTime.Now;
		private DateTime _fechaVencimiento = DateTime.Now;
		private bool _selected = false;
		private ArrayList _valoresAsociados = new ArrayList();
		private short _signo = 0;

		private Hashtable _tablaFormasDePagosComprobantesTesoreria = new Hashtable();


		public ArrayList RealcionesItemComprobanteDeCompraValor
		{
			get{return _valoresAsociados;}
		}


		public ArrayList Valores
		{
			get
			{
				ArrayList result = new ArrayList();
				foreach(RealcionItemComprobanteDeCompraValor rel in this._valoresAsociados)
				{
					result.Add(rel.MiValor);
				}
				return result;
			}
		}

		public ItemComprobanteDeCompraView(Hashtable table)
		{
			_tablaFormasDePagosComprobantesTesoreria = table;
		}

		public short Signo
		{
			get{return _signo;}
			set{_signo = value;}
		}

		public event EventHandler SelectedChanged;

		public void RemoveValor(Valor valor)
		{
			RealcionItemComprobanteDeCompraValor aBorrar = null;
			foreach(RealcionItemComprobanteDeCompraValor rel in this._valoresAsociados)
			{
				if(rel.MiValor.Equals(valor))
				{
					aBorrar = rel;
					break;
				}
			}
			if(aBorrar != null)
			{
				this._saldo = this._saldo + aBorrar.MontoAbonado;
				this.QuitarPago(aBorrar.MiValor, aBorrar.MontoAbonado);
				this._valoresAsociados.Remove(aBorrar);
			}
		}
		
		public void AddValor(Valor valor, decimal pago)
		{
			RealcionItemComprobanteDeCompraValor rel = new RealcionItemComprobanteDeCompraValor(pago, valor);
			this._saldo = this._saldo - pago;
			AplicarPago(valor, pago);
			this._valoresAsociados.Add(rel);
		}

		private void QuitarPago(Valor valor, decimal pago)
		{
			if(_tablaFormasDePagosComprobantesTesoreria.ContainsKey(valor.IdTDCompTesoreria))
			{
				string property = Convert.ToString(_tablaFormasDePagosComprobantesTesoreria[valor.IdTDCompTesoreria]);
				switch (property) 
				{
					case "Efectivo" : PagoEfectivo = PagoEfectivo - pago;break;
					case "ChequesTerceros" : PagoChequeTercero = PagoChequeTercero - pago;break;
					case "ChequesPropios" : PagoChequePropio = PagoChequePropio - pago;break;
					case "TransferenciasBancarias" : PagoTransferenciaBancaria = PagoTransferenciaBancaria - pago;break;
				}

			}
		}


		private void AplicarPago(Valor valor, decimal pago)
		{
			if(_tablaFormasDePagosComprobantesTesoreria.ContainsKey(valor.IdTDCompTesoreria))
			{
				string property = Convert.ToString(_tablaFormasDePagosComprobantesTesoreria[valor.IdTDCompTesoreria]);
				switch (property) 
				{
					case "Efectivo" : PagoEfectivo = PagoEfectivo + pago; break;
					case "ChequesTerceros" : PagoChequeTercero = PagoChequeTercero + pago;break;
					case "ChequesPropios" : PagoChequePropio = PagoChequePropio + pago;break;
					case "TransferenciasBancarias" : PagoTransferenciaBancaria = PagoTransferenciaBancaria + pago;break;
				}

			}
		}




		

		public bool Selected
		{
			get{return _selected;}
			set
			{
				if(_selected != value)
				{
					_selected = value;
					if(SelectedChanged != null)
						SelectedChanged(this, new EventArgs());
				}
			}
		}

		public DateTime Fecha
		{
			get{return _fecha;}
			set{_fecha = value;}
		}

		public DateTime FechaVencimiento
		{
			get{return _fechaVencimiento;}
			set{_fechaVencimiento = value;}
		}

		public decimal PagoTransferenciaBancaria
		{
			get{return _pagoTransferenciaBancaria;}
			set{_pagoTransferenciaBancaria = value;}
		}

		public decimal PagoChequeTercero
		{
			get{return _pagoChequeTercero;}
			set{_pagoChequeTercero = value;}
		}

		public decimal PagoChequePropio
		{
			get{return _pagoChequePropio;}
			set{_pagoChequePropio = value;}
		}

		public decimal PagoEfectivo
		{
			get{return _pagoEfectivo;}
			set{_pagoEfectivo = value;}
		}

		public decimal Total
		{
			get{return _total;}
			set{_total = value;}
		}

		public decimal Saldo
		{
			get{return _saldo;}
			set{_saldo = value;}
		}

		public string Proveedor
		{
			get{return _proveedor;}
			set{_proveedor = value;}
		}

		public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}

		public string SubcuentaImputacion
		{
			get{return _subcuentaImputacion;}
			set{_subcuentaImputacion = value;}
		}

		public string CuentaImputacion
		{
			get{return _cuentaImputacion;}
			set{_cuentaImputacion = value;}
		}
			

		public string IdSubcuentaImputacion
		{
			get{return _idSubcuentaImputacion;}
			set{_idSubcuentaImputacion = value;}
		}

		public string IdCuentaImputacion
		{
			get{return _idCuentaImputacion;}
			set{_idCuentaImputacion = value;}
		}
			
		public string IdTipoDeComprobante
		{
			get{return _idTipoDeComprobante;}
			set{_idTipoDeComprobante = value;}
		}
	
		public string Numero
		{
			get{return _numero;}
			set{_numero = value;}
		}

		public string Comprobante
		{
			get{return _comprobante;}
			set{_comprobante = value;}
		}

		public string IdComprobante
		{
			get{return _idComprobante;}
			set{_idComprobante = value;}
		}

		

		

	}
}
