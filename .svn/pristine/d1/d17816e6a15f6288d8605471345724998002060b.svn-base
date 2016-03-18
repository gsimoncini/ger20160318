using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ComprobanteDePagoCompras.
	/// </summary>
	public class ComprobanteDePagoCompras
	{
		
		#region Constructores
		
		public ComprobanteDePagoCompras()
		{
		}

		#endregion

		#region Variables Protegidas
		
		private string _state = "NEW";
		private string _condicionDeCompra = string.Empty;
		private string _mascara = @"\X-####-########";
		private string _tipoComprobanteDestino;
		private string _tipoComprobanteOrigen;
		private short _signoCuentaCorriente;
		private string _idComprobanteOrigen;
		private string _idComprobanteDestino;
		private int _signo = 1;
		private System.DateTime _fechaComprobante;
		private string _numeroDestino = string.Empty;
		private string _observaciones = string.Empty;
		private string _numeroOrigen = String.Empty;
		private string _idInstanciaCaja = string.Empty;
		private decimal _total = 0;
		private string _idMonedaCierre = string.Empty;
		private string _idFuenteCambioCierre = string.Empty;
		private string _idCotizacionCierre = string.Empty;
		private string _idResponsable = string.Empty;
		private string _responsable = string.Empty;
		private string _codigoProveedor = string.Empty;
		private string _idProveedor = string.Empty;
		private Valores _valores = new Valores();
		private ArrayList _retenciones = new ArrayList();
		private mz.erp.businessrules.CuentaCorriente _cuentaCorriente = new mz.erp.businessrules.CuentaCorriente();

		private string _processName = string.Empty;
		private string _taskName = string.Empty;
        private ProcessManager _processParent;
		private bool _recalculaRetenciones = true;

		

		private string _tiposComprobantesAImputar = string.Empty;
		private DataTable _instanciasCajasAbiertas ;

		private bool _allowEditInstanciaDeCaja = false;

		private Proveedor _proveedor = new Proveedor(string.Empty);
		
		private string _idAutorizacion = string.Empty;

		tpu_ComprobantesDataset _dataComprobantes = new tpu_ComprobantesDataset();
		tfi_ValoresExDataset _dataValores = new tfi_ValoresExDataset(); 
		tpu_ComprobanteDetalleDePagosDataset _dataComprobanteDetallePagos = new tpu_ComprobanteDetalleDePagosDataset();
		tpu_ComprobanteDetalleDeudaDataset _dataComprobanteDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();
		tpu_ComprobanteDetalleDeudaDataset _dataComprobanteDetalleDeudaImputaciones = new tpu_ComprobanteDetalleDeudaDataset();
		tpu_AplicacionPagosDataset _dataAplicacionPagos = new tpu_AplicacionPagosDataset();
		tpu_ProveedoresDetallePagoImpuestoGananciasDataset _dataProveedoresDetallePagoImpuestoGanancias = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();
		tpu_RetencionesExDataset _dataRetenciones = new tpu_RetencionesExDataset(); 
		

		
		private string _estado = string.Empty;
		private int _mode;
		private bool _retieneIIBB = false;
		private bool _retieneIVA= false;
		private bool _retieneGanancias = false;
		private bool _calcularRetenciones = true;
		private decimal _importeAplicableRetencionGanancias = 0;
		private decimal _importeAplicableRetencionIIBB = 0;

		private decimal _alicuotaRetencionesIIBBServicios = 0;
		private decimal _alicuotaRetencionesIIBBCompras = 0;

		private Hashtable _comprobantes = new Hashtable();

        private string _idTDCompTesoreriaPagoContado = string.Empty;
		private string _idMonedaPagoContado = string.Empty;

        //Sabrina: Tarea 1120. 20110817
        private bool _allowEditImputaAutomaticamente = false;
        private bool _imputaAutomaticamente = false;
        //Fin Sabrina: Tarea 1120. 20110817

        //Sabrina: Tarea 1122. 20110818
        private SortOrder _sortOrder = SortOrder.EmisionAsc;
        //Fin Sabrina: Tarea 1122. 20110818

        #endregion

		#region Eventos

			public event EventHandler IdResponsableChanged;
			public event EventHandler TotalChanged;
			public event EventHandler PagoChanged;

		#endregion

		#region Propiedades

		public string IdComprobanteDestino
		{
			get{return _idComprobanteDestino;}
		}
		public bool IsValidProveedor
		{
			get 
			{
				if ((this._proveedor.IdProveedor== null) || (this._proveedor.IdProveedor == string.Empty))
					return false;
				else
					return true;
			}
		}
		public bool IsValidResponsable
		{
			get
			{
				if ((this._idResponsable == null) || (this._idResponsable == string.Empty))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}

		public bool IsValidInstanciaDeCaja
		{
			get
			{
				if ((this._idInstanciaCaja == null) || (this._idInstanciaCaja == string.Empty))
				{
					return false;
				}
				else
				{
					return true;
				}
				
				
			}
		}

		//German 20091120
		public bool IsValidCajaAbierta()
		{
			if ((this.IdInstanciaCaja != null) && (!this.IdInstanciaCaja.Equals(string.Empty)))
			{
				tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row = mz.erp.businessrules.tfi_InstanciasCaja.GetByPk(IdInstanciaCaja);
				if(row != null)
				{
					if(!row.IsCierreNull())
					{
						return false;
					}
				}
				else return false;
			}
			return true;
		}
		//Fin German 20091120

		public bool IsValidMontoConImputacion
		{
			get
			{
				return this._total >= (this._cuentaCorriente.TotalImputado - Convert.ToDecimal( 0.05));
			}
		}	

		public bool IsValidMonto
		{
			get
			{
				return this._total > 0;
			}
		}
	

		public bool IsValidRetencionesAplicadas
		{
			get
			{
				if (_calcularRetenciones)
				{
					bool aplicaRetGan = _retieneGanancias && _proveedor.AplicaRetencionGanancias;
					bool aplicaRetIIBB = _retieneIIBB && !_proveedor.ExcluyeRetencionIIBB;
					bool aplicaRetIVA = _retieneIVA && !_proveedor.ExcluyeRetencionIVA;
					return !((aplicaRetGan || aplicaRetIIBB || aplicaRetIVA) && _recalculaRetenciones);
				}
				return true;
			}
		}

		public bool IsValidImputaciones
		{
			get
			{
				foreach(ItemCuentaCorriente item in this._cuentaCorriente)
				{
					if(item.Pago != item.Saldo)
						return false;
				}
				return true;
			}
		}

		public string IdAutorizacion
		{
			get{return _idAutorizacion;}
			set{_idAutorizacion = value;}
		}

		public bool AllowEditInstanciaDeCaja
		{
			get{return _allowEditInstanciaDeCaja;}
			set{_allowEditInstanciaDeCaja = value;}
		}

		public string TipoComprobanteDestino
		{
			get{return _tipoComprobanteDestino;}
			set{_tipoComprobanteDestino = value;}
		}

		public decimal Total
		{
			get{return _total;}
		}

		public DateTime FechaComprobante
		{
			get{return _fechaComprobante;}
			set
			{
				if(_fechaComprobante != value)
				{
					_fechaComprobante = value;
					if(_proveedor != null)
					{
						_proveedor.GetRetencionesGanancias(_fechaComprobante.Year, _fechaComprobante.Month);
						BorrarRetencionesExistentes();
						_recalculaRetenciones = true;
					}
				}
			}
		}

		public string Numero
		{
			get{return _numeroDestino;}
			set{_numeroDestino = value;}
		}

		public string Mascara
		{
			get{return _mascara;}
		}

		public string Proveedor
		{
			get
			{
				if(_proveedor != null)
					return _proveedor.Nombre;
				return string.Empty;
			}
		}
			

		

		public  string IdResponsable
		{
			get{return _idResponsable;}
			set 
			{
				if(_idResponsable != value)
				{
					_idResponsable = value;
					GetInstanciaDeCaja();
					if(IdResponsableChanged != null)
						IdResponsableChanged(this, EventArgs.Empty);
				}

			}
		}

		public string IdProveedor
		{
			get{return _idProveedor;}
			set
			{
				if(_idProveedor != value)
				{
					_idProveedor = value;
					_proveedor.IdProveedor = _idProveedor;
					_codigoProveedor = mz.erp.businessrules.tpu_Proveedores.GetCodigoByPK(_idProveedor);
					_proveedor.GetRetencionesGanancias(this.FechaComprobante.Year, this.FechaComprobante.Month);
					_recalculaRetenciones = true;

				}
				if(this._cuentaCorriente != null)
				{
					this._cuentaCorriente.Clear();
					if(_idProveedor != null && _idProveedor != string.Empty)
					{
						
						this._cuentaCorriente.GetDetalleCuentaCorrienteComprasSaldoTemporal(_idProveedor, long.MinValue, _tiposComprobantesAImputar, true);
						GetComprobantes();
					}
					else
					{
						if(_codigoProveedor == null || _codigoProveedor == string.Empty)
						{
							/*Resetear la Cuenta Corriente*/
							this._cuentaCorriente.Clear();
							GetComprobantes();
						}
					}
					
				}
			}
		}

		public string CodigoProveedor
		{
			get
			{
				return _codigoProveedor;
			}
			set
			{
				if(_codigoProveedor != value)
				{
					_codigoProveedor = value;
					_idProveedor = mz.erp.businessrules.tpu_Proveedores.GetPKByCodigo(_codigoProveedor);
					_proveedor.IdProveedor = _idProveedor;
					_proveedor.GetRetencionesGanancias(this.FechaComprobante.Year, this.FechaComprobante.Month);
					_recalculaRetenciones = true;
				}
				if(this._cuentaCorriente != null)
				{
					this._cuentaCorriente.Clear();
					if(_idProveedor != null && _idProveedor != string.Empty)
					{
						this._cuentaCorriente.GetDetalleCuentaCorrienteComprasSaldoTemporal(_idProveedor, long.MinValue, _tiposComprobantesAImputar, true);
						GetComprobantes();
					}
					else
					{
						if(_codigoProveedor == null || _codigoProveedor == string.Empty)
						{
							/*Resetear la Cuenta Corriente*/
							this._cuentaCorriente.Clear();
							GetComprobantes();
						}
					}
					
				}
			}
		}
		public DataTable InstanciasCajasAbiertas
		{
			get{return _instanciasCajasAbiertas;}
		}

		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if(_observaciones != value)
				{
					_observaciones = value;					
				}
			}
		}

		public mz.erp.businessrules.CuentaCorriente CuentaCorriente
		{
			get{ return _cuentaCorriente;}
		}

		public ArrayList Valores
		{
			get{return _valores.MisValores;}
		}

		public decimal TotalImputado
		{
			get{return _cuentaCorriente.TotalImputado;}			
		}

		public string IdInstanciaCaja
		{
			get{return _idInstanciaCaja;}
			set{_idInstanciaCaja = value;}
		}

		public decimal Saldo
		{
			get
			{
				return Total - TotalImputado;
			}
		}

        //Sabrina: Tarea 1120. 20110817
        public bool AllowEditImputaAutomaticamente
        {
            get { return _allowEditImputaAutomaticamente; }

        }

        public bool ImputaAutomaticamente
        {
            get { return _imputaAutomaticamente; }
            set { _imputaAutomaticamente = value; }
        }
        //Fin Sabrina: Tarea 1120. 20110817

			




		#endregion

		#region Metodos Publicos


		public void GetComprobantes()
		{
			_comprobantes.Clear();
			ArrayList ItemCtaCteAEliminar = new ArrayList();
			foreach(ItemCuentaCorriente item in this._cuentaCorriente)
			{
				ComprobanteDeCompraCabecera cab = new ComprobanteDeCompraCabecera();
				cab.SetProcessManagerParent(_processParent);
				cab.Edit(item.IdComprobante);
				if(!_comprobantes.ContainsKey(item.IdComprobante) && item.Autorizada)
					_comprobantes.Add(item.IdComprobante, cab);
				if(!item.Autorizada)
				{
					ItemCtaCteAEliminar.Add(item);
				}

			}
			foreach(ItemCuentaCorriente item in ItemCtaCteAEliminar)
			{
				this._cuentaCorriente.Remove(item);
			}
		}


		public void Step(string IdComprobantePrevio)
		{
			tpu_ComprobantesDataset.tpu_ComprobantesRow rowC = mz.erp.businessrules.tpu_Comprobantes.GetByPk(IdComprobantePrevio);
			this._idProveedor = rowC.IdProveedor;
			this._total = rowC.Total;
			this._numeroDestino = rowC.Numero;
			this._numeroOrigen =  rowC.Numero;
			DataSet dataPago = mz.erp.businessrules.tpu_ComprobanteDetalleDePagos.GetList(null, null, IdComprobantePrevio,null, decimal.MinValue);
			foreach(DataRow rowP in dataPago.Tables[0].Rows)
			{
				string IdValor = Convert.ToString(rowP["IdValor"]);
				Valor valor = new Valor(IdValor, null, null);
				this.AddValor(valor);
			}
			if(_idProveedor != null && _idProveedor != string.Empty)
			{
				this._cuentaCorriente.GetDetalleCuentaCorrienteComprasSaldoTemporal(_idProveedor, long.MinValue, _tiposComprobantesAImputar, true);
				DataSet dataAplic = mz.erp.businessrules.tpu_AplicacionPagos.GetList(IdComprobantePrevio, short.MinValue, decimal.MinValue,null, null, short.MinValue);
				foreach(DataRow rowAplic in dataAplic.Tables[0].Rows)
				{
					string IdComprobanteDestino = Convert.ToString(rowAplic["IdComprobanteDestino"]);
					ItemCuentaCorriente item = this._cuentaCorriente.GetItemCuentaCorrienteByIdComprobante(IdComprobanteDestino);
					decimal pago = Convert.ToDecimal(rowAplic["Importe"]);
					item.Pago = pago;


				}
			}
			else
			{
				if(_codigoProveedor == null || _codigoProveedor == string.Empty)
				{
					/*Resetear la Cuenta Corriente*/
					this._cuentaCorriente.Clear();
				}
			}


		}

		public bool PertenceRetenciones(Valor valor)
		{
			return MAPStaticInfo.PertenceARetenciones(valor.IdTDCompTesoreria);
		}

		public bool HayRetenciones(string IdTipoDeRetencion)
		{
			
			foreach(Valor valor in this._valores.MisValores)
			{
				if(MAPStaticInfo.PertenceARetenciones(valor.IdTDCompTesoreria)
					&& valor.IdTipoDeRetencion.Equals(IdTipoDeRetencion))
				{
					return true;
				}
			}

			return false;
		}
		
		public bool ContainsValor(Valor valor)
		{
            /* Silvina 20100705 - Tarea 789 */
            if (valor.PerteneceACheque(valor.IdTDCompTesoreria))
            {
                foreach (Valor v in this.Valores)
                    if (v.IdValor == valor.IdValor)
                        return true;
                return false;
            }
            /* Fin Silvina */
			return this.Valores.Contains(valor);
		}


		public void AddValor(Valor valor)
		{
			this.Valores.Add(valor);
			this.Recalcular();
			valor.ValorChange += new Valor.ValorChangeEventHandler(Recalcular);
            
            //Sabrina: Tarea 1122. 20110818
            if (ImputaAutomaticamente)
            {
                ArrayList comprobantesAImputar = this.SortComprobantesAImputar();
                int i = 0;
                decimal restoValor = Math.Abs(valor.MontoCotizado);
                while (restoValor != 0 && i < comprobantesAImputar.Count)
                {
                    ItemCuentaCorriente icc = (ItemCuentaCorriente)comprobantesAImputar[i];
                    decimal restoAImputar = Math.Abs(icc.Saldo) - Math.Abs(icc.Pago);
                    if (restoAImputar != 0)
                    {
                        if (restoValor >= restoAImputar)
                        {
                            icc.Pago = Math.Abs(icc.Saldo);
                            restoValor = restoValor - restoAImputar;
                        }
                        else
                        {
                            icc.Pago = Math.Abs(restoValor);
                            restoValor = 0;
                        }
                    }
                    i++;
                }
            }
            //Fin Sabrina: Tarea 1119. 20110816
		}

		public void Init(string ProcessName, string TaskName, ProcessManager ProcessParent)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			_processParent = ProcessParent;
			_idMonedaCierre = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_idFuenteCambioCierre = Variables.GetValueString("Contabilidad.FuenteCambioReferencia");
			_idCotizacionCierre = Variables.GetValueString("Contabilidad.CotizacionReferencia");
			_fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
			_valores = new Valores();
			this._idResponsable = Security.IdPersona;
			tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(this._idResponsable);
			_responsable =  row.Nombre;	
			GetInstanciaDeCaja();
			_total = 0;
			_idComprobanteDestino = mz.erp.systemframework.Util.NewStringId();
			_cuentaCorriente = new mz.erp.businessrules.CuentaCorriente();
			_cuentaCorriente.PagoChanged +=new EventHandler(_cuentaCorriente_PagoChanged);
			_tipoComprobanteDestino = Variables.GetValueString( _processName, _taskName ,"Comprobantes.Default");
			_mascara = this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
			if(_mascara == null || _mascara == string.Empty)
				_mascara = @"\R-####-########";
			string NumeroDefault = Variables.GetValueString(_processName, _taskName, "MascaraNumero");
			if(NumeroDefault != null && !NumeroDefault.Equals(string.Empty))
				this._numeroDestino = NumeroDefault;
			_tiposComprobantesAImputar = Variables.GetValueString(_processName, _taskName, "ListaComprobantesAImputar");
			this._idComprobanteDestino = mz.erp.systemframework.Util.NewStringId();
			_estado = Variables.GetValueString(_processName, _taskName, "Estado");
			_mode = Convert.ToInt32(Variables.GetValueLong(_processName, _taskName, "ModoAfectaSaldo"));//0 o 1 o 2
			_retieneIIBB = Variables.GetValueBool("Contabilidad.RetencionesProveedores.RetieneIIBB");
			_retieneIVA = Variables.GetValueBool("Contabilidad.RetencionesProveedores.RetieneIVA");
			_retieneGanancias = Variables.GetValueBool("Contabilidad.RetencionesProveedores.RetieneGanancias");
			_importeAplicableRetencionGanancias = Variables.GetValueDecimal("Contabilidad.RetencionesProveedores.RetencionesGanancias.ImporteAplicable");
			_importeAplicableRetencionIIBB = Variables.GetValueDecimal("Contabilidad.RetencionesProveedores.RetencionesIIBB.ImporteAplicable");
			_alicuotaRetencionesIIBBServicios = Variables.GetValueDecimal("Contabilidad.RetencionesProveedores.RetencionesIIBB.AlicuotaServicios");
			_alicuotaRetencionesIIBBCompras = Variables.GetValueDecimal("Contabilidad.RetencionesProveedores.RetencionesIIBB.AlicuotaCompras");
			_calcularRetenciones = Variables.GetValueBool(_processName, _taskName, "CalcularRetenciones");

			_idTDCompTesoreriaPagoContado = Variables.GetValueString(_processName, _taskName, "IdTDCompTesoreriaPagoContado");
			_idMonedaPagoContado = Variables.GetValueString("Contabilidad.MonedaReferencia");

            //Sabrina: Tarea 1120. 20110817
            _allowEditImputaAutomaticamente = Variables.GetValueBool(_processName, _taskName, "Editar.ImputaAutomaticamente");
            _imputaAutomaticamente = Variables.GetValueBool(_processName, _taskName, "ImputaAutomaticamente.ValorDefault");
            //Fin Sabrina: Tarea 1120. 20110817

            //Sabrina: Tarea 1122. 20110818
            string ordenDeImputacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ImputacionesAutomaticas.OrdenDeImputacion");
            if (ordenDeImputacion.Equals("EmisionAsc"))
                _sortOrder = SortOrder.EmisionAsc;
            else if (ordenDeImputacion.Equals("EmisionDesc"))
                _sortOrder = SortOrder.EmisionDesc;
            else if (ordenDeImputacion.Equals("VencimientoAsc"))
                _sortOrder = SortOrder.VencimientoAsc;
            else if (ordenDeImputacion.Equals("VencimientoDesc"))
                _sortOrder = SortOrder.VencimientoDesc;
            //Fin Sabrina: Tarea 1122. 20110818
		
		}


		public void Commit()
		{
			this.CommitCabecera();
			this.CommitValores();
			this.CommitProveedorDetallePagoImpuestoGanancias();
			this.CommitCuentaCorriente();
			this.CommitRetenciones();
		}

		private static string UpdateNumeracionRetencion(DataRow rowValor, string TipoRetencion, string IdTransaction)
		{
			string numeracion = Variables.GetValueStringWithoutCache("Retenciones.Numeracion." + TipoRetencion,IdTransaction);
			string Numero = Convert.ToString(Convert.ToInt32(numeracion) + 1);
				rowValor["Numero"]= Numero;
			return "Retenciones.Numeracion." + TipoRetencion;
		}

		private static string UpdateNumero(tpu_ComprobantesDataset data, string IdTransaction)
		{
			foreach(System.Data.DataRow row1 in data.tpu_Comprobantes.Rows)
			{
				if (true) 
				{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"],IdTransaction);
					string Numero = mz.erp.systemframework.Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"],IdTransaction);
					return row.IdVariable;
				}
				
			}

			return null;
		}

		public void Flush(string IdTransaction, SentenciasReplicacion replicacion, bool ActualizaNumeracion)
		{
			
			string IdVariable = string.Empty;
			if (ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(_dataComprobantes,IdTransaction);
			}
			mz.erp.dataaccess.tpu_Comprobantes.Update(_dataComprobantes.tpu_Comprobantes, IdTransaction, replicacion);
			string Numero = Convert.ToString(_dataComprobantes.Tables["tpu_Comprobantes"].Rows[0]["Numero"]);
			dataaccess.sy_Variables.Update(IdVariable,Numero,IdTransaction);	
			DataRow row = _dataComprobantes.tpu_Comprobantes.Rows[0];
			this._idComprobanteDestino = Convert.ToString(row["IdComprobante"]);
			Hashtable hashRet = new Hashtable();
			foreach(DataRow rowValor in _dataValores.tfi_Valores.Rows)
			{
				string IdTipo = Convert.ToString(rowValor["IdTDCompTesoreria"]);
				string IdValorBD = Convert.ToString(rowValor["IdValor", System.Data.DataRowVersion.Current]);
				if(MAPStaticInfo.PertenceARetenciones(IdTipo))
				{
					DataRow rowDtosAuxiliares = _dataValores.tfi_ValoresDatosAuxiliares.FindByIdValor(IdValorBD);
					string TipoRetencion = Convert.ToString(rowDtosAuxiliares["TIPO_RETENCION_RET_"]);
					IdVariable = UpdateNumeracionRetencion(rowValor, TipoRetencion, IdTransaction);
					Numero = Convert.ToString(rowValor["Numero"]);
					hashRet.Add(TipoRetencion, Numero);
					dataaccess.sy_Variables.Update(IdVariable,Numero,IdTransaction);
				}
			}
			mz.erp.dataaccess.tfi_ValoresEx.Update(_dataValores, IdTransaction, replicacion);
			foreach(DataRow rowValor in _dataValores.tfi_Valores.Rows)
			{
				string IdValorBD = Convert.ToString(rowValor["IdValor", System.Data.DataRowVersion.Current]);
				string IdValorOriginal = Convert.ToString(rowValor["OldIdValor", System.Data.DataRowVersion.Current]);
				DataRow rowDP = _dataComprobanteDetallePagos.tpu_ComprobanteDetalleDePagos.FindByIdComprobanteIdValor(string.Empty, IdValorOriginal);
				if(rowDP == null)
				{
					rowDP = _dataComprobanteDetallePagos.tpu_ComprobanteDetalleDePagos.FindByIdComprobanteIdValor(string.Empty, IdValorBD);
				}
				rowDP["IdValor"] = IdValorBD;
				rowDP["IdComprobante"] = this._idComprobanteDestino;
				rowDP["IdTipoDeComprobante"] = this._tipoComprobanteDestino;
				rowDP["Numero"] = this._numeroDestino;
			}
			mz.erp.dataaccess.tpu_ComprobanteDetalleDePagos.Update( _dataComprobanteDetallePagos.tpu_ComprobanteDetalleDePagos, IdTransaction);
			foreach(DataRow rowDD in _dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Rows)
			{
				rowDD["IdComprobante"] = this._idComprobanteDestino;
				rowDD["Numero"] = Numero;
			}

			mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update(_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda, IdTransaction, replicacion);
			mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update(_dataComprobanteDetalleDeudaImputaciones.tpu_ComprobanteDetalleDeuda, IdTransaction, replicacion);
			
			foreach(DataRow rowAP in _dataAplicacionPagos.tpu_AplicacionPagos.Rows)
			{
				if(this._signo > 0)
					rowAP["IdComprobanteOrigen"] = this._idComprobanteDestino;
				else
					rowAP["IdComprobanteDestino"] = this._idComprobanteDestino;
				
			}
			mz.erp.dataaccess.tpu_AplicacionPagos.Update(_dataAplicacionPagos.tpu_AplicacionPagos, IdTransaction);
			if(_retieneGanancias)
			{
				if(_proveedor != null)
				{
					if(_proveedor.AplicaRetencionGanancias)
					{
						mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.Update(_dataProveedoresDetallePagoImpuestoGanancias.tpu_ProveedoresDetallePagoImpuestoGanancias, IdTransaction);
					}
				}
			}
			foreach(tpu_RetencionesExDataset.tpu_RetencionesRow rowRet in _dataRetenciones.tpu_Retenciones)
			{
				rowRet.IdComprobante = this._idComprobanteDestino;
				rowRet.NumeroRetencion = Convert.ToString(hashRet[rowRet.IdTipoDeRetencion]);
			}
			mz.erp.dataaccess.tpu_RetencionesEx.Update(_dataRetenciones, IdTransaction, replicacion);

		}

		public void CalcularRetenciones()
		{
			_recalculaRetenciones = false;
			BorrarRetencionesExistentes();
			CalcularRetencionesGanancias();
			CalcularRetencionesIVA();
			CalcularRetencionesIIBB();
			Recalcular();
		}

		public void Recalcular()
		{
			decimal total=0;
			foreach (Valor valor in this._valores.MisValores)
			{
				total = total + valor.MontoCotizado;
			}	
			this._total= total;
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
		}


		private void BorrarRetencionesExistentes()
		{
			ArrayList aux = new ArrayList();
			foreach(Valor valor in this._valores.MisValores)
			{
				//Poner Variables q indiquen los IdTDCompTesoreria q son Retenciones
				if(MAPStaticInfo.PertenceARetenciones(valor.IdTDCompTesoreria))
					aux.Add(valor);
			}
			foreach(Valor va in aux)
			{
				this._valores.MisValores.Remove(va);
			}
            this._retenciones.Clear();
		}


		/*
		 * Restricciones: 
		 *		No se permiten pagos parciales ni pagos a Cuentas
		 * 
		 * */

		private void CalcularRetencionesGanancias()
		{
			if(_retieneGanancias)
			{
				if(_proveedor != null)
				{
					if(_proveedor.AplicaRetencionGanancias)
					{
						int Año = this.FechaComprobante.Year;
						int Mes = this.FechaComprobante.Month;
						_proveedor.GetRetencionesGanancias(Año, Mes);
						decimal TotalPago = _proveedor.MontoPagos;
						decimal TotalPagoAnterior = _proveedor.MontoPagos;
						decimal MontoRetencion = 0;
						bool CreaRetencion = false;
						decimal ImporteRetencionServicios = 0;
						decimal ImporteRetencionCompraDeMercaderias = 0;		
						ArrayList retencionesDet = new ArrayList();
						long idRetencion = mz.erp.systemframework.Util.NewLongId();
						foreach(ItemCuentaCorriente item in this._cuentaCorriente)
						{
							//German 20091103
							if(item.Pago > 0 && item.Saldo == item.Importe && item.Saldo == item.Pago) //Es un pago total
							{

								ComprobanteDeCompraCabecera cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
								TotalPago = TotalPago + cab.Neto;
							}
							else
							{
								if(item.Pago > 0)
								{
									ComprobanteDeCompraCabecera cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
								
									decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
									decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
									decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
									decimal montoNeto = 0;
									decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
									if(alicuotaGral > 0)
										montoNeto =   item.Pago / (1 + alicuotaGral /100);
									else
										montoNeto =  item.Pago;
									TotalPago = TotalPago + montoNeto;
								}
								

							}
							/*
							if(item.Pago > 0 && item.Pago < item.Saldo)// Es un pago Parcial - Parche, hay q modificar
							{
								ComprobanteDeCompraCabecera cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
								
								decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
								decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
								decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
								decimal montoNeto = 0;
								decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
								if(alicuotaGral > 0)
									montoNeto =   item.Pago / (1 + alicuotaGral /100);
								else
									montoNeto =  item.Pago;
								TotalPago = TotalPago + montoNeto;
								

							}
							else // Es un pago Total
							{
								//German 20091103
								if(item.Pago > 0 && item.Saldo == item.Total)
								//Fin German 20091103
								{
									ComprobanteDeCompraCabecera cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
									TotalPago = TotalPago + cab.Neto;
								}
							}
							*/
							//Fin German 20091103
						}
						if(TotalPago > _importeAplicableRetencionGanancias)
						{
							CreaRetencion = true;
							MontoRetencion = ((TotalPago - _importeAplicableRetencionGanancias)* _proveedor.AlicuotaRetencionGanancias /100) - _proveedor.MontoRetenciones;
							//Ver de poner 2 propiedades en la clase proveedor, para guardar el nuevo MontoPago y el nuevo MontoRetentciones
                            //No sobrescribir lo q ya esta pq se pierden los valores originales. Crear 2 nuevas propiedades
							
						}
						_proveedor.SetRetencionesGanancias( TotalPago, MontoRetencion + _proveedor.MontoRetenciones);
                        //German 20120328 - Tarea 0000302 - Agrega && MontoRetencion > 0
                        if (CreaRetencion && MontoRetencion > 0)
                        //German 20120328 - Tarea 0000302
						{
							CrearRetencionValor(MontoRetencion, "G");
							decimal NetoRetencion = 0;
							if(TotalPagoAnterior < _importeAplicableRetencionGanancias)

								//German 20100430 - Tarea 743
								//NetoRetencion = TotalPago - TotalPagoAnterior - _importeAplicableRetencionGanancias;
								NetoRetencion = TotalPago - _importeAplicableRetencionGanancias;
								//Fin German 20100430 - Tarea 743

							else
								NetoRetencion = TotalPago - TotalPagoAnterior;
							CrearRetencion(idRetencion, "G", NetoRetencion, MontoRetencion, retencionesDet);
						}
						
					}
				}
			}
		}

		private void CalcularRetencionesIVA()
		{

		}

		/*
		 * Restricciones: 
		 *		No se permiten pagos parciales ni pagos a Cuentas
		 * 
		 * */
		private void CalcularRetencionesIIBB()
		{
			
			if(_retieneIIBB)
			{
				if(_proveedor != null)
				{
					if(!_proveedor.ExcluyeRetencionIIBB)
					{
						decimal Neto = 0;
						decimal NetoServicios = 0;
						decimal NetoCompras = 0;
						decimal ImporteRetencion = 0;
						bool CreaRetencion = false;
						decimal montoNetoRetencion = 0;
						ArrayList retencionesDet = new ArrayList();
						long idRetencion = mz.erp.systemframework.Util.NewLongId();
						foreach(ItemCuentaCorriente item in this._cuentaCorriente)
						{
							ComprobanteDeCompraCabecera cab;
							//German 20091103
							if(item.Pago > 0 && item.Saldo == item.Importe && item.Saldo == item.Pago) //Es un pago total
							{

								cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
								Neto = Neto + cab.Neto;
							}
							else
							{
								
								if(item.Pago > 0)
								{
									cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
									decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
									decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
									decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
									decimal montoNeto = 0;
									decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
									if(alicuotaGral > 0)
										Neto = Neto +(  item.Pago / (1 + alicuotaGral /100));
									else
										Neto = Neto +item.Pago;
								}
								
							}
							/*
							if(item.Pago > 0 && item.Pago <= item.Saldo )
							{
								
								cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
								decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
								decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
								decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
								decimal montoNeto = 0;
								decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
								if(alicuotaGral > 0)
									Neto = Neto +(  item.Pago / (1 + alicuotaGral /100));
								else
									Neto = Neto +item.Pago;
								
							}
							else
							{
								//German 20091103
								if(item.Pago > 0 && item.Saldo == item.Total) //Es un pago total
								//Fin German 20091103
								{

									cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
									Neto = Neto + cab.Neto;
								}
							}*/
							//German 20091103
						}
						/*
						ArrayList impComp = new ArrayList();
						impComp.Add("IVA1");
						impComp.Add("IVA2");
						ArrayList impServ = new ArrayList();
						impServ.Add("IVA3");
						decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVA();
						decimal AlicuotaIVACompras = cab.ConceptosGravados.GetAlicuotasImpuestosAplicadas(impComp);
						decimal AlicuotaIVAServicios = cab.ConceptosGravados.GetAlicuotasImpuestosAplicadas(impServ);
						decimal montoNeto = item.Pago / (1 + AlicuotaIVAs /100);
						decimal montoNetoServicio = item.Pago / (1 + AlicuotaIVAServicios /100);
						decimal montoNetoCompras = item.Pago / (1 + AlicuotaIVACompras /100);
						Neto = Neto + montoNeto;
						NetoServicios = NetoServicios + montoNetoServicio;
						NetoCompras = NetoCompras + montoNetoCompras;
						*/
						if(Neto >= _importeAplicableRetencionIIBB)
						{
							CreaRetencion = true;
							decimal ImporteRetencionServicios = 0;
							decimal ImporteRetencionCompraDeMercaderias = 0;
							decimal netoRet =0;
							foreach(ItemCuentaCorriente item in this._cuentaCorriente)
							{
								ComprobanteDeCompraCabecera cab;
								//German 20091103
								if(item.Pago > 0 && item.Saldo == item.Importe && item.Saldo == item.Pago) //Es un pago total
								{
									cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
									montoNetoRetencion = montoNetoRetencion + cab.NetoServicio +  (cab.NetoGravado > 0 ? cab.NetoGravado : cab.GastoGravado);
                                    /* Silvina 20110414 - Tarea 0000110 */
                                    if ((cab.NetoServicio == 0) && (cab.NetoGravado == 0) && (cab.GastoGravado == 0))
                                        montoNetoRetencion = montoNetoRetencion + cab.TotalUsuario;
                                    /* Fin Silvina 20110414 - Tarea 0000110 */
									//ImporteRetencionServicios = cab.NetoServicio * _alicuotaRetencionesIIBBServicios /100;
									ImporteRetencionServicios = cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100;
									//ImporteRetencionCompraDeMercaderias = cab.NetoGravado > 0 ? cab.NetoGravado *_alicuotaRetencionesIIBBCompras /100:cab.GastoGravado *_alicuotaRetencionesIIBBCompras /100 ;
									ImporteRetencionCompraDeMercaderias = cab.NetoGravado > 0 ? cab.NetoGravado *_proveedor.AlicuotaRetencionIIBBCompras/100:cab.GastoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100 ;

									ImporteRetencion = cab.NetoGravado > 0 ? (ImporteRetencion + (cab.NetoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100) +
										(cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100)) : (ImporteRetencion + (cab.GastoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100) +
										(cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100));
                                    
                                    /* Silvina 20110414 - Tarea 0000110*/
                                    if ((cab.NetoServicio == 0) && (cab.NetoGravado == 0) && (cab.GastoGravado == 0))
                                        ImporteRetencion = ImporteRetencion + (cab.TotalUsuario * _proveedor.AlicuotaRetencionIIBBCompras / 100);
                                    /* Fin Silvina 20110414 - Tarea 0000110*/

									if(ImporteRetencionServicios > 0)
									{
										//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", cab.NetoServicio, _alicuotaRetencionesIIBBServicios, ImporteRetencionServicios);
										ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", cab.NetoServicio, _proveedor.AlicuotaRetencionIIBBServicios, ImporteRetencionServicios);
										retencionesDet.Add(itemRetencion);
									}
									if(ImporteRetencionCompraDeMercaderias > 0)
									{
										decimal net = cab.NetoGravado > 0 ? cab.NetoGravado : cab.GastoGravado;
										ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", net, _proveedor.AlicuotaRetencionIIBBCompras, ImporteRetencionCompraDeMercaderias);
										retencionesDet.Add(itemRetencion);
									}
                                    /* Silvina 20110428 - Tarea 0000110*/
                                    //German 20120328 - Tarea 0000302 - Agrega && ImporteRetencion > 0
                                    if ((ImporteRetencionServicios == 0) && (ImporteRetencionCompraDeMercaderias == 0) && ImporteRetencion > 0)
                                    //German 20120328 - Tarea 0000302
                                    {
                                        ItemRetencion itemRetencion = new ItemRetencion(idRetencion, item.IdComprobante, "C", cab.TotalUsuario, _proveedor.AlicuotaRetencionIIBBCompras, ImporteRetencion);
                                        retencionesDet.Add(itemRetencion);
                                    }
                                    /* Fin Silvina 20110428 - Tarea 0000110*/
								}
								else
								{
									if(item.Pago > 0)
									{
										cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
										decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
										decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
										decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
										decimal montoNeto = 0;
										decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
										if(alicuotaGral > 0)
											netoRet =   item.Pago / (1 + alicuotaGral /100);
										else
											netoRet =  item.Pago;

										if(cab.NetoGravado > 0 || cab.GastoGravado > 0)
										{
											//ImporteRetencionCompraDeMercaderias = netoRet *_alicuotaRetencionesIIBBCompras /100;
											ImporteRetencionCompraDeMercaderias = netoRet *_proveedor.AlicuotaRetencionIIBBCompras /100;
											ImporteRetencion = ImporteRetencion + ImporteRetencionCompraDeMercaderias;
											montoNetoRetencion = montoNetoRetencion + netoRet;	
											//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", netoRet, _alicuotaRetencionesIIBBCompras, ImporteRetencionCompraDeMercaderias);
                                            //German 20120328 - Tarea 0000302
                                            if(ImporteRetencion > 0)
                                            {
											    ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", netoRet, _proveedor.AlicuotaRetencionIIBBCompras, ImporteRetencionCompraDeMercaderias);
                                                retencionesDet.Add(itemRetencion);
                                            }
                                            //German 20120328 - Tarea 0000302;
										}
										else
										{
											if(cab.NetoServicio > 0)
											{
												//ImporteRetencionServicios = cab.NetoServicio * _alicuotaRetencionesIIBBServicios /100;
												ImporteRetencionServicios = cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100;
												montoNetoRetencion = montoNetoRetencion + netoRet;											
												ImporteRetencion =  ImporteRetencion +  ImporteRetencionServicios;
												//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", netoRet, _alicuotaRetencionesIIBBServicios, ImporteRetencionServicios);
                                                //German 20120328 - Tarea 0000302
                                                if (ImporteRetencion > 0)
                                                {
                                                    ItemRetencion itemRetencion = new ItemRetencion(idRetencion, item.IdComprobante, "S", netoRet, _proveedor.AlicuotaRetencionIIBBServicios, ImporteRetencionServicios);
                                                    retencionesDet.Add(itemRetencion);
                                                }
                                                //German 20120328 - Tarea 0000302;

											}
                                            /* Silvina 20110414 - Tarea 0000110*/
                                            else
                                            {
                                                montoNetoRetencion = montoNetoRetencion + netoRet;
                                                ImporteRetencion = ImporteRetencion + netoRet * _proveedor.AlicuotaRetencionIIBBCompras / 100;
                                            }
                                            /* Fin Silvina 20110414 - Tarea 0000110*/
										}
									}
								}
								/*
								if(item.Pago > 0 && item.Pago < item.Saldo)
								{
									cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
									decimal AlicuotaIVAs = cab.ConceptosGravados.GetAlicuotaIVAMinima();
									decimal montoImpNOGravados = cab.ConceptosNOGravados.GetImpuestos();
									decimal alicuotaImpuestosNOGravados = montoImpNOGravados *100 / cab.Neto;
									decimal montoNeto = 0;
									decimal alicuotaGral = AlicuotaIVAs + alicuotaImpuestosNOGravados;
									if(alicuotaGral > 0)
										netoRet =   item.Pago / (1 + alicuotaGral /100);
									else
										netoRet =  item.Pago;

									if(cab.NetoGravado > 0 || cab.GastoGravado > 0)
									{
										//ImporteRetencionCompraDeMercaderias = netoRet *_alicuotaRetencionesIIBBCompras /100;
										ImporteRetencionCompraDeMercaderias = netoRet *_proveedor.AlicuotaRetencionIIBBCompras /100;
										ImporteRetencion = ImporteRetencionCompraDeMercaderias;
										montoNetoRetencion = montoNetoRetencion + netoRet;	
										//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", netoRet, _alicuotaRetencionesIIBBCompras, ImporteRetencionCompraDeMercaderias);
										ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", netoRet, _proveedor.AlicuotaRetencionIIBBCompras, ImporteRetencionCompraDeMercaderias);
										retencionesDet.Add(itemRetencion);
									}
									else
									{
										if(cab.NetoServicio > 0)
										{
											//ImporteRetencionServicios = cab.NetoServicio * _alicuotaRetencionesIIBBServicios /100;
											ImporteRetencionServicios = cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100;
											montoNetoRetencion = montoNetoRetencion + netoRet;											
											ImporteRetencion = ImporteRetencionServicios;
											//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", netoRet, _alicuotaRetencionesIIBBServicios, ImporteRetencionServicios);
											ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", netoRet, _proveedor.AlicuotaRetencionIIBBServicios, ImporteRetencionServicios);
											retencionesDet.Add(itemRetencion);

										}
									}
								}
								else
								{
									//German 20091103
									if(item.Pago > 0 && item.Saldo == item.Total) //Es un pago total
									//Fin German 20091103
									{
										cab = (ComprobanteDeCompraCabecera)_comprobantes[item.IdComprobante];
										montoNetoRetencion = montoNetoRetencion + cab.NetoServicio +  (cab.NetoGravado > 0 ? cab.NetoGravado : cab.GastoGravado);
										//ImporteRetencionServicios = cab.NetoServicio * _alicuotaRetencionesIIBBServicios /100;
										ImporteRetencionServicios = cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100;
										//ImporteRetencionCompraDeMercaderias = cab.NetoGravado > 0 ? cab.NetoGravado *_alicuotaRetencionesIIBBCompras /100:cab.GastoGravado *_alicuotaRetencionesIIBBCompras /100 ;
										ImporteRetencionCompraDeMercaderias = cab.NetoGravado > 0 ? cab.NetoGravado *_proveedor.AlicuotaRetencionIIBBCompras/100:cab.GastoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100 ;

										ImporteRetencion = cab.NetoGravado > 0 ? (ImporteRetencion + (cab.NetoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100) +
											(cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100)) : (ImporteRetencion + (cab.GastoGravado *_proveedor.AlicuotaRetencionIIBBCompras /100) +
											(cab.NetoServicio * _proveedor.AlicuotaRetencionIIBBServicios /100));
										if(ImporteRetencionServicios > 0)
										{
											//ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", cab.NetoServicio, _alicuotaRetencionesIIBBServicios, ImporteRetencionServicios);
											ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "S", cab.NetoServicio, _proveedor.AlicuotaRetencionIIBBServicios, ImporteRetencionServicios);
											retencionesDet.Add(itemRetencion);
										}
										if(ImporteRetencionCompraDeMercaderias > 0)
										{
											decimal net = cab.NetoGravado > 0 ? cab.NetoGravado : cab.GastoGravado;
											ItemRetencion itemRetencion= new ItemRetencion(idRetencion, item.IdComprobante, "C", net, _proveedor.AlicuotaRetencionIIBBCompras, ImporteRetencionCompraDeMercaderias);
											retencionesDet.Add(itemRetencion);
										}
									}
						


								}
								*/
								//Fin German 20091103
							}
						}
                        //German 20120328 - Tarea 0000302
						if(CreaRetencion && ImporteRetencion > 0)
                        //German 20120328 - Tarea 0000302
						{
							CrearRetencionValor(ImporteRetencion, "IB");
							CrearRetencion(idRetencion, "IB", montoNetoRetencion, ImporteRetencion, retencionesDet);
						}
					}
				}
				
				
			}
		}

		private void CrearRetencion(long IdRetencion, string IdTipoDeRetencion, decimal MontoNeto, decimal MontoRetencion, ArrayList Detalle)
		{
			Retencion ret = new Retencion(IdRetencion, IdTipoDeRetencion, MontoNeto, MontoRetencion, string.Empty, DateTime.Today, this._numeroDestino, this._idComprobanteDestino, this._idProveedor, Detalle);
			_retenciones.Add(ret);
		}

		private void CrearRetencionValor(decimal Monto, string IdTipoRetencion)
		{
			Valor valor = new Valor(null, "10", ComprobantesRules.Contabilidad_MonedaReferencia, Monto);
			valor.DatoAuxiliar.IdTipoDeRetencion = IdTipoRetencion;
			valor.DatoAuxiliar.FechaIngresoRetencion = mz.erp.businessrules.Sistema.DateTime.Now;
			valor.DatoAuxiliar.IdCuenta = this._proveedor.IdProveedor;
            this.AddValor(valor);


		}


		public void StepDesdeComprobanteDeCompraCabecera(IngresarComprobanteDeCompraCabecera ccc)
		{
			// Crea un pago tomando los datos desde comprobanteDeCompraCabecera.            
			// La factura q estoy ingresando es nueva con lo cuál no existen pagos asociados...! 

			// ---- 1) Datos Cabecera
			this._fechaComprobante = ccc.FechaComprobante;
			this._idProveedor = ccc.IdProveedor;
			this.IdResponsable = ccc.IdResponsable;
			this._numeroDestino = ccc.Numero;
			this._numeroOrigen = ccc.Numero;
			this._total = ccc.TotalUsuarioMonedaReferencia; //this.TotalMonedaReferencia;
			_proveedor.IdProveedor = ccc.IdProveedor;
			_observaciones = ccc.Observaciones;

			// ---- 2) Dato Valor
			Valor valor = new Valor(string.Empty, _idTDCompTesoreriaPagoContado, _idMonedaPagoContado, ccc.TotalUsuarioMonedaReferencia);
			this.AddValor(valor);
			
			// Cuenta Corriente del Proveedor
			if( _idProveedor!=null && !_idProveedor.Equals(string.Empty) )
			{
				// No existen pagos asociados a este comprobante ya q es nuevo!
				ItemCuentaCorriente icc = new ItemCuentaCorriente();
				icc.IdComprobante = _idComprobanteDestino;
				icc.Comprobante = string.Empty; //tsy_TiposDeComprobantes.Descripcion
				icc.IdTipoDeComprobante = _tipoComprobanteDestino;
				icc.Numero = _numeroDestino;
				icc.FechaEmision = _fechaComprobante;
				icc.FechaVencimiento = _fechaComprobante;
				icc.SignoCtaCte = _signoCuentaCorriente;
				icc.Pago = _total;
				icc.Importe = _total;
				icc.Saldo = 0;
				icc.Cuota = 1;
				icc.Signo = _signo;	
				icc.Autorizada = true;
				this._cuentaCorriente.Add(icc);
			}
			else
			{
				if(_codigoProveedor == null || _codigoProveedor == string.Empty)
				{
					/*Resetear la Cuenta Corriente*/
					this._cuentaCorriente.Clear();				
				}
			}
		}


		#endregion

		#region Metodos Privados


		
		private void CommitCuentaCorriente()
		{
			
			/*
			_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Clear();
			int signo = Convert.ToInt16(tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino).signo);
			tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow row = _dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Newtpu_ComprobanteDetalleDeudaRow();
			row.IdComprobante = this._idComprobanteDestino;
			row.IdTipoDeComprobante = this._tipoComprobanteDestino;
			row.Numero = this._numeroDestino;
			row.FechaEmision = this._fechaComprobante;
			row.FechaVencimiento = this._fechaComprobante;
			row.Cuota = 1;
			row.Importe = this._total * signo;// this._signo;
			row.Saldo = this.Saldo * signo;// this._signo;this._signo;
			row.SaldoTemporal = this.Saldo * signo;// this._signo;this._signo;
			row.IdMonedaCierre = this._idMonedaCierre;
			row.IdCotizacionCierre = this._idMonedaCierre;						
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;		
			_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Addtpu_ComprobanteDetalleDeudaRow(row);
			this._cuentaCorriente.CommitComprasAplicacionPago(this._idComprobanteDestino, 1, this._tipoComprobanteDestino, signo, this._total, _mode);
			_dataComprobanteDetalleDeudaImputaciones = _cuentaCorriente.DataComprobantesDetalleDeuda ;
			_dataAplicacionPagos = _cuentaCorriente.DataAplicacionPagos;

			 * 
			 * */
			_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Clear();
			int signo = Convert.ToInt16(tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino).signo);
			tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow row = _dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Newtpu_ComprobanteDetalleDeudaRow();
			row.IdComprobante = this._idComprobanteDestino;
			row.IdTipoDeComprobante = this._tipoComprobanteDestino;
			row.Numero = this._numeroDestino;
			row.FechaEmision = this._fechaComprobante;
			row.FechaVencimiento = this._fechaComprobante;
			row.Cuota = 1;
			row.Importe = this._total * signo;// this._signo;
			row.Saldo = this.Saldo * signo;// this._signo;this._signo;
			row.SaldoTemporal = this.Saldo * signo;// this._signo;this._signo;
			row.IdMonedaCierre = this._idMonedaCierre;
			row.IdCotizacionCierre = this._idMonedaCierre;						
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;		
			_dataComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.Addtpu_ComprobanteDetalleDeudaRow(row);

			this._cuentaCorriente.CommitComprasAplicacionPago(this._idComprobanteDestino, 1, this._tipoComprobanteDestino, signo, this._total, _mode);
			_dataComprobanteDetalleDeudaImputaciones = _cuentaCorriente.DataComprobantesDetalleDeuda ;
			_dataAplicacionPagos = _cuentaCorriente.DataAplicacionPagos;
			
		}


		
		private void CommitRetenciones()
		{
			foreach(Retencion retencion in this._retenciones)
			{
				tpu_RetencionesExDataset.tpu_RetencionesRow rowRet = _dataRetenciones.tpu_Retenciones.Newtpu_RetencionesRow();
				rowRet.IdRetencion = retencion.IdRetencion;
				rowRet.IdTipoDeRetencion = retencion.IdTipoDeRetencion;
				rowRet.MontoNeto = retencion.MontoNeto;
				rowRet.MontoRetencion = retencion.MontoRetencion;
				rowRet.NumeroRetencion = retencion.NumeroRetencion;
				rowRet.FechaRetencion = retencion.FechaRetencion;
				rowRet.NumeroRecibo = retencion.NumeroRecibo;
				rowRet.IdComprobante = retencion.IdComprobante;
				rowRet.IdProveedor = retencion.IdProveedor;
				rowRet.FechaCreacion = DateTime.Now;
				rowRet.IdConexionCreacion = Security.IdConexion;
				rowRet.IdConexionUltimaModificacion = Security.IdConexion;
				rowRet.IdReservado = 0;
				rowRet.IdSucursal = Security.IdSucursal;
				rowRet.IdEmpresa = Security.IdEmpresa;		
				_dataRetenciones.tpu_Retenciones.Addtpu_RetencionesRow(rowRet);
				foreach(ItemRetencion itemRet in retencion.Detalle)
				{
					tpu_RetencionesExDataset.tpu_RetencionesDetRow rowDet = _dataRetenciones.tpu_RetencionesDet.Newtpu_RetencionesDetRow();
					rowDet.IdRetencion = itemRet.IdRetencion;
					rowDet.IdComprobante = itemRet.IdComprobante;
					rowDet.IdConcepto = itemRet.IdConcepto;
					rowDet.MontoNeto = itemRet.MontoNeto;
					rowDet.MontoRetencion = itemRet.MontoRetencion;
					rowDet.AlicuotaAplicada = itemRet.AlicuotaAplicada;
					rowDet.FechaCreacion = DateTime.Now;
					rowDet.IdConexionCreacion = Security.IdConexion;
					rowDet.IdConexionUltimaModificacion = Security.IdConexion;
					rowDet.IdReservado = 0;
					rowDet.IdSucursal = Security.IdSucursal;
					rowDet.IdEmpresa = Security.IdEmpresa;		
					_dataRetenciones.tpu_RetencionesDet.Addtpu_RetencionesDetRow(rowDet);
				}

			}
		
		}

		private void CommitValores()
		{
			DataRow row = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino);
			int signo = 1;
			if(row != null)
				signo = Convert.ToInt32(row["Signo"]);
			/*Si cierran los signos*/
			this._valores.CommitCompras(this._idInstanciaCaja, signo);
			_dataValores = this._valores.DataValores;
			_dataComprobanteDetallePagos = this._valores.DataDetallePagosCompras;

		
		}

		private void CommitProveedorDetallePagoImpuestoGanancias()
		{
			if(_retieneGanancias)
			{
				if(_proveedor != null)
				{
					if(_proveedor.AplicaRetencionGanancias)
					{
						_proveedor.CommitDetallePagoImpuestoGanancias();
						_dataProveedoresDetallePagoImpuestoGanancias = this._proveedor.DataProveedoresDetallePagoImpuestoGanancias;
					}
				}
			}
		}

		private bool HayRetencionesGanancias()
		{
			foreach(Valor valor in this._valores.MisValores)
			{
				if(valor.IdTDCompTesoreria.Equals("10") && valor.IdTipoDeRetencion.Equals("G"))
					return true;
			}
			return false;
		}

		private void CommitCabecera()
		{
			_dataComprobantes.Clear();
			tpu_ComprobantesDataset.tpu_ComprobantesRow row = _dataComprobantes.tpu_Comprobantes.Newtpu_ComprobantesRow();
			row.Fecha = this._fechaComprobante;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdComprobante = this._idComprobanteDestino;
			row.IdProveedor = this._idProveedor;
			row.IdResponsable = this._idResponsable;
			row.IdTipoDeComprobante = this._tipoComprobanteDestino;
			row.Numero = this._numeroDestino;
			row.IdCotizacionCierre = this._idCotizacionCierre;
			row.Total = this._total;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdInstanciaCaja = this._idInstanciaCaja;
			row.IdMonedaCierre = this._idMonedaCierre;
			row.IdReservado = 0;
			row.Proveedor = this._proveedor.Nombre;
			row.Domicilio = this._proveedor.Domicilio;
			row.TipoDocumento = this._proveedor.TipoDocumento;
			row.Documento = this._proveedor.Documento;
			row.Observaciones = this._observaciones;
			row.Aux1 = string.Empty;
			row.Aux2 = string.Empty;
			row.Aux3 = string.Empty;
			row.Aux4 = 0;
			row.FechaDeRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.ValorCotizacionProveedor = 1;
			row.IdMonedaOrigen = this._idMonedaCierre;
			row.IdFuenteDeCambioProveedor = this._idFuenteCambioCierre;
			row.Estado = _estado;
			row.IdAutorizacion = _idAutorizacion;
			_dataComprobantes.tpu_Comprobantes.Addtpu_ComprobantesRow( row );


		}


		private void _cuentaCorriente_PagoChanged(object sender, EventArgs e)
		{	
			_recalculaRetenciones = true;
			if(PagoChanged != null)
				PagoChanged(this, new EventArgs());
		}

		private void GetInstanciaDeCaja()
		{
			
			_instanciasCajasAbiertas = new DataTable();
			string idCajaVariables = Variables.GetValueString(this._processName, this._taskName, "Cajas");
			ArrayList cajaAbiertas = new ArrayList();
			if(!idCajaVariables.Equals(string.Empty))
				cajaAbiertas = mz.erp.systemframework.Util.Parse(idCajaVariables, ",");
			
			if(this._idResponsable != null && this._idResponsable != string.Empty)
			{
				string idUsuarioResp = this._idResponsable;
				if(cajaAbiertas.Count == 0)
				{
					_idInstanciaCaja = null;
					_allowEditInstanciaDeCaja = false;
					
				}
				else
				{
					if(cajaAbiertas.Count == 1)
					{
						string idCaja = Convert.ToString(cajaAbiertas[0]);
						string idCajaTemporal = Variables.GetValueString("Cajas.CajaTemporalDefault");
						if(idCaja.Equals(idCajaTemporal))
						{
							try 
							{
								_idInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault( null, idCaja );
								idUsuarioResp = mz.erp.businessrules.tfi_InstanciasCaja.GetByPk(_idInstanciaCaja).IdResponsable;
							}
							catch
							{
								string Mensaje = "La caja temporal no se encuentra abierta";
								Exception e = new Exception(Mensaje);
							}						
						}
						else
						{
							_idInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault(  idUsuarioResp , idCaja );
						}
						_instanciasCajasAbiertas = mz.erp.businessrules.tfi_InstanciasCaja.GetList(idUsuarioResp, idCajaVariables).Tables[0];	 
						if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 0)
						{
							_idInstanciaCaja = null;
							_allowEditInstanciaDeCaja = false;
						
						}
						else
						{
							
						
						}
					
					}
					else
					{
					
						_instanciasCajasAbiertas = mz.erp.businessrules.tfi_InstanciasCaja.GetList(idUsuarioResp, idCajaVariables).Tables[0];
						if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 1)
						{
							_idInstanciaCaja = Convert.ToString(_instanciasCajasAbiertas.Rows[0]["IdInstanciaCaja"]);
							
						}
						else
							if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 0)
							{
								_idInstanciaCaja = null;
								_allowEditInstanciaDeCaja = false;
							}
							else
							{
								_allowEditInstanciaDeCaja = true;
							}
					}
				
										
				}
			}
			else
			{
				_idInstanciaCaja = null;
				_allowEditInstanciaDeCaja = false;
				
			}
		
			
		}

		public void UpdateComprobanteDestino(string idComprobante, string idTipoComprobante)
		{
			// Actualiza el IdComprobanteDestino para el caso de Pagar Factura Gastos al Contado.
			foreach(DataRow row in this._dataAplicacionPagos.Tables[0].Rows)
			{
				row["IdComprobanteDestino"] = idComprobante;
				row["IdTipoDeComprobanteDestino"] = idTipoComprobante;
			}
		}

        //Sabrina: Tarea 1122. 20110818
        private ArrayList SortComprobantesAImputar()
        {
            ArrayList result = new ArrayList();
            result.AddRange(this.CuentaCorriente);
            switch (_sortOrder)
            {
                case SortOrder.EmisionAsc:
                    {
                        result.Sort(ItemCuentaCorriente.SortByFechaEmisionInstance);
                    }
                    break;
                case SortOrder.EmisionDesc:
                    {
                        result.Sort(ItemCuentaCorriente.SortByFechaEmisionDescInstance);
                    }
                    break;
                case SortOrder.VencimientoAsc:
                    {
                        result.Sort(ItemCuentaCorriente.SortByFechaVencimientoInstance);
                    }
                    break;
                case SortOrder.VencimientoDesc:
                    {
                        result.Sort(ItemCuentaCorriente.SortByFechaVencimientoDescInstance);
                    }
                    break;
            }

            return result;
        }
        //Fin Sabrina: Tarea 1122. 20110818
        #endregion

        //Sabrina: Tarea 1122. 20110818
        public enum SortOrder
        {
            EmisionAsc,
            EmisionDesc,
            VencimientoAsc,
            VencimientoDesc
        };
        //Fin Sabrina: Tarea 1122. 20110818
	
	}
}
