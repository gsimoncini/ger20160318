using System;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.commontypes.data;



namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Clase auxiliar de Comprobantes de Venta
	/// Condicion de venta establece la forma en que se abonará el comprobante de venta.
	/// Genera la estrucutra para enviar a la base de datos y que utiliza el modulo de
	/// cuentas corrientes.
	/// </summary>
	/// <example>
	/// Condición de Venta CONTADO
	///		Esta condición de venta se caracteriza porque la factura se debe abonar en una
	///		sola cuota y la fecha de vencimiento es inmediata a la de la emisión de la misma
	///	Condición de Venta CUENTA CORRIENTE n DIAS
	///		Establece que la fecha de vencimiento no podria exceder los N dias de la fecha
	///		utilizada como base
	///	Condición de Venta CREDITO PERSONAL n Cuotas
	///		Podriamos definir esta condición de venta para indicar que el comprobante se abona
	///		en N cuotas consecutivas a partir de una determinada fecha y que para cada cuota
	///		se debe abonar P donde P es un porcentaje de representacion con respecto al comprobante.
	/// </example>
	public class CondicionDeVenta: CollectionBase
	{
		
		#region Eventos y Delegados
			public event EventHandler IdCondicionDeVentaChanged;
		#endregion

		#region Variables Privadas
		private Comprobante Comprobante;
		private string _idCondicionDeVenta = "";
		private string _descripcion = "";
		private decimal _recargo = 0;
		private bool _esCuentaCorriente = false;
		#endregion

		#region Variables Publicas
		/// <summary>
		/// Devuelve el código de la condición de venta.
		/// </summary>
		/// 
		public bool EsCuentaCorriente
		{
			get
			{
				return _esCuentaCorriente;
			}
		}

		public string IdCondicionDeVenta
		{
			get
			{
				return _idCondicionDeVenta;
			}
			set			
			{
				if(value != _idCondicionDeVenta)
				{
					if ((value != null) && (value != string.Empty))
					{
						_idCondicionDeVenta = value;
						FillNewData(_idCondicionDeVenta);
						if (this.Comprobante.VariablesComprobante != null)
						{
							VariableAuxiliar aux = this.Comprobante.VariablesComprobante.Search(ComprobantesRules.Comprobantes_Variables_IdCondicionDeVenta);
							if(aux != null) 
							{
								aux.Valor = value;
							}
						}
						if(IdCondicionDeVentaChanged != null)
							IdCondicionDeVentaChanged(this, new EventArgs());
					}
				}
			}
		}

		/// <summary>
		/// Devuelve la descripción de la condición de venta.
		/// </summary>
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set 
			{
				_descripcion = value;
			}
		}

		public decimal Recargo
		{
			get
			{
				return _recargo;
			}
		}


		/// <summary>
		/// Devuelve el detalle de la condición de venta. Indicando las cuotas en que se debe
		/// abonar el comprobante y el porcentaje que representa cada cuota con respecto al total
		/// La estrucutra de la colección es CUOTA, FECHAVENCIMIENTO, IMPORTE
		/// </summary>
		public System.Collections.ICollection DetalleCondicionDeVenta
		{
			get
			{
				return (System.Collections.ICollection)this.List;
			}
		}

        //German 20101119 - Tarea 943
        public System.Collections.IList DetalleCondicionDeVentaList
        {
            get
            {
                return this.List;
            }
        }
        //Fin German 20101119 - Tarea 943

		#endregion

		#region Constructores y Destructores
		/// <summary> Constructor. Utilizado internamente por comprobantes de venta. </summary>
		/// <param name="parent"> La instancia del comprobante de venta que lo contiene </param>
		/// <param name="idCondicion">Un codigo de condición de venta. Relacion con la tabla tsa_CondicionesDeVenta</param>
		
		public CondicionDeVenta(string action, Comprobante parent, string idCondicion)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Comprobante = parent;
			Init(action, idCondicion);
		}

		public CondicionDeVenta(string action, ComprobanteDeVenta parent)
		{
			Comprobante = parent;
			Init(action, null);
		}
		

		#endregion

		#region Inicializadores y Carga
		#endregion

		#region Funciones y Metodos Publicos
		public void Refresh()
		{
			FillNewData( this.IdCondicionDeVenta );
		}
		/// <summary>
		/// Fuerza la escritura de los datos en memoria al dataset del comprobante para poder ser enviados a almacenar en el RDBM
		/// </summary>
		/// El parametro process es necesario solo cuando se debe actualizar la tabla tsa_Cuentas pq el comprobante afecta la cta cte.. Si no necesita hacerlo el parametro puede ser null.
		public void Commit(Process process)
		{
			if (DetalleCondicionDeVenta.Count > 0)
			{
				tsa_ComprobantesExDataset comprobante = this.Comprobante.DatasetComprobante;
				string IdComprobante = this.Comprobante.IdComprobante;
				string IdTipoComprobante = this.Comprobante.TipoComprobanteDestino;
				string Numero = this.Comprobante.Numero;
				int signo = (int)tsy_TiposDeComprobantes.GetByPk(IdTipoComprobante).signo;
				decimal importe = 0;

				foreach (DetalleCuotas dc in this.DetalleCondicionDeVenta)
				{
					tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDeudaRow row = comprobante.tsa_ComprobanteDetalleDeuda.Newtsa_ComprobanteDetalleDeudaRow();
					row.IdComprobante = IdComprobante;
					row.IdTipoDeComprobante = IdTipoComprobante;
					row.Numero= Numero;
					row.FechaEmision= mz.erp.systemframework.Util.AddTime(this.Comprobante.FechaComprobante, mz.erp.businessrules.Sistema.DateTime.Now);
					row.Cuota= Convert.ToInt16(dc.GetIdCuota());
					row.FechaVencimiento= dc.GetFechaVencimiento();
					row.Importe= dc.GetMonto()*signo;
					row.Saldo= dc.GetMonto()* signo;
					row.IdMonedaCierre= Variables.GetValueString("Contabilidad.MonedaReferencia");
					row.IdCotizacionCierre= Variables.GetValueString("Contabilidad.CotizacionReferencia");
					row.IdSucursal = Security.IdSucursal;
					row.IdEmpresa = Security.IdEmpresa;
					comprobante.tsa_ComprobanteDetalleDeuda.Rows.Add(row);
					importe = importe + row.Importe;
					
				}
				string IdCuenta = this.Comprobante.IdCuenta;
				GuardarSaldoCuentaCorriente.GetInstance().CommitSaldoCuentaCorriente(process, IdCuenta, importe, IdTipoComprobante);
			}

		}


		public void Update(CuentaCorriente ctaCte)
		{
			
			ComprobanteDePago cdp =(ComprobanteDePago) this.Comprobante;
			bool aplicacionDePago = false;
			tsa_ComprobantesExDataset data = cdp.DatasetComprobante;
			foreach (DetalleCuentaCorriente dcc in ctaCte.Detalle)
			{
				
				if( dcc.Pago > 0)

				{
					//Pues es un comprobante de Pago que tiene Pago > 0
					//Esto implica que estamos ante una Aplicacion de Pago de un comprobante de pago
					//en la Cuenta Corriente
					if (dcc.Signo == 1) aplicacionDePago = true;
					//Si dcc.Signo == 1 significa que es un recibo que ya esta en la cuenta corriente y que a su
					//vez tiene pago >0, osea que estamos ante una situacion de Aplicacion de Pago
					string IdComprobate = dcc.IdComprobante;
					short Cuota = (short)dcc.Cuota;
					/*
					if(cdp.ComprobanteDeVenta != null)
					{
						System.Data.DataRow row = cdp.ComprobanteDeVenta.DatasetComprobante.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobate, Cuota);
						int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row["IdTipoDeComprobante"]).signo);
						row["saldo"] = (decimal )row["saldo"] * signo;
						row["Saldo"] =(decimal) row["Saldo"] - dcc.Pago;
						row["Saldo"] = (decimal) row["Saldo"] * signo;
						//data.tsa_ComprobanteDetalleDeuda.ImportRow(row);
						//data.tsa_ComprobanteDetalleDeuda.LoadDataRow(row.ItemArray,true);

						
					}

					else
					{
					*/
						try
						{
							System.Data.DataRow row = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobate, Cuota);
							int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row["IdTipoDeComprobante"]).signo);
							row["saldo"] = (decimal )row["saldo"] * signo;
							row["Saldo"] =(decimal) row["Saldo"] - dcc.Pago;
							row["Saldo"] = (decimal) row["Saldo"] * signo;

						}
						catch(Exception e) 
						{
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobate, Cuota);
							if(row != null)
							{
								int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row["IdTipoDeComprobante"]).signo);
								row["saldo"] = (decimal )row["saldo"] * signo;
								row["Saldo"] =(decimal) row["Saldo"] - dcc.Pago;
								row["Saldo"] = (decimal) row["Saldo"] * signo;
							}
						
							//	pues si es un recibo ya fue agregado en la tabla de Comprobantes
							// Para cualquier otro comprobante que tenga signo == -1 y que tenga Pago > 0 hay que agreagrlo a la tabla 
							// tsa_Comprobantes para que no de error de Foreing Key cuando intenetmos guardar los registros
							// en tsa_ComprobanteDetalleDeuda
							/*	if (signo == -1)
								{
									System.Data.DataRow rowComprobanteCabecera = mz.erp.businessrules.tsa_Comprobantes.GetByPk((string ) row["IdComprobante"]);
									data.tsa_Comprobantes.ImportRow((System.Data.DataRow)rowComprobanteCabecera);
								}*/
							data.tsa_ComprobanteDetalleDeuda.ImportRow((System.Data.DataRow)row);
						
						}
					//}

				}


			}
			//En este caso el recibo, se esta creando, por ende no esta en la cuenta corriente, osea que
			//hay que actualizar el detalle de deuda de este recibo que ya fue creado
			if (!aplicacionDePago)
			{
				System.Data.DataRow row = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(cdp.IdComprobante, 1);
				int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row["IdTipoDeComprobante"]).signo);
				
				row["Saldo"] =cdp.Saldo*cdp.Signo;


			}
		}


		
		#endregion

		#region Funciones y Metodos Privados
		private void Init(string action, string idCondicionDeVenta)
		{
			switch (action.ToUpper())
			{
				case "NEW":
					FillNewData(idCondicionDeVenta);
					break;
				case "EDIT":
					FillEditData();
					break;
			}

		}

		/// <summary>
		/// Determina como se deben componer las cuotas según el monto total del comprobante
		/// </summary>
		/// <param name="idCondicionDeVenta"></param>
		private void FillNewData(string idCondicionDeVenta)
		{
			
				

				if (idCondicionDeVenta != null && idCondicionDeVenta != String.Empty) 
				{				
					tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row = tsa_CondicionesDeVentas.GetByPk( idCondicionDeVenta );
					if(row != null)
					{
						_descripcion = row.Descripcion;
						this._idCondicionDeVenta = idCondicionDeVenta;
						tsa_CondicionesDeVentaDetDataset data = mz.erp.dataaccess.tsa_CondicionesDeVentaDet.GetListByIdCondicionDeVenta( this._idCondicionDeVenta );
						tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetDataTable table = data.tsa_CondicionesDeVentaDet;
						System.DateTime fechaActual = mz.erp.businessrules.Sistema.DateTime.Now;
						DateTime fechaAux = this.Comprobante.FechaComprobante;
						System.DateTime fecha = new DateTime(fechaAux.Year, fechaAux.Month, fechaAux.Day, fechaActual.Hour, fechaActual.Minute, fechaActual.Second);
						_recargo = row.Recargo;
						this.Comprobante.RecargoFinancieroPorCondicionDeVenta = _recargo;
						this._esCuentaCorriente = false;
						decimal monto = this.Comprobante.Total;
						List.Clear();	
						foreach (tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow rowDet in table.Rows)
						{
							DetalleCuotas dt = new DetalleCuotas();
							dt.SetIdCuota( rowDet.Cuota);
							dt.SetFechaVencimiento( fecha.AddDays(rowDet.DiasVencimiento));
							dt.SetMonto(  (monto * rowDet.Porcentual  / 100) );
							dt.SetPorcentaje( rowDet.Porcentual );
							if(rowDet.DiasVencimiento > 0 && !this._esCuentaCorriente)
								this._esCuentaCorriente = true;
                            //German 20101119 - Tarea 943
                            dt.DiasVencimiento = rowDet.DiasVencimiento;
                            //Fin German 20101119 - Tarea 943
							Add(dt);

							//				return tsa_CondicionesDeVentaDet.GetListByIdCondicionDeVenta( _idCondicionDeVenta, this.comprobante.FechaComprobante, this.comprobante.Total );
						}
					} else _idCondicionDeVenta = string.Empty;
				}else _idCondicionDeVenta = string.Empty;
			

		}
		
		private void FillEditData()
		{
			VariableAuxiliar var =(VariableAuxiliar)this.Comprobante.VariablesComprobante.Search( ComprobantesRules.Comprobantes_Variables_IdCondicionDeVenta );
			if (var != null) 
			{
				this._idCondicionDeVenta = var.Valor;
				this._descripcion = var.Descripcion;
				this._esCuentaCorriente = false;
			}
				
			tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDeudaDataTable table = this.Comprobante.DatasetComprobante.tsa_ComprobanteDetalleDeuda;
			System.DateTime fecha = this.Comprobante.FechaComprobante;
			decimal monto = this.Comprobante.Total;
			foreach (tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDeudaRow row in table.Rows)
			{
				DetalleCuotas dt = new DetalleCuotas();
				dt.SetIdCuota( row.Cuota );
				dt.SetFechaVencimiento( row.FechaVencimiento );
				dt.SetMonto( row.Importe );
				System.Data.DataRow rowCDDet = mz.erp.businessrules.tsa_CondicionesDeVentaDet.GetByPK(this._idCondicionDeVenta, row.Cuota);
				if(rowCDDet != null)
				{
					short diasVenc = Convert.ToInt16(rowCDDet["DiasVencimiento"]);
					if(diasVenc > 0 && !this._esCuentaCorriente)
						this._esCuentaCorriente = true;
                    //German 20101119 - Tarea 943
                    dt.DiasVencimiento = diasVenc;
                    //Fin German 20101119 - Tarea 943
				}

				Add(dt);
			}
		}

		private void Add(DetalleCuotas dt)
		{
			List.Add( dt );
		}
		
		/// <summary>
		/// Si la fecha de vencimiento es HOY, entonces compara lo entregado con el porcentaje de cancelación
		/// ya efectuado para devolver cuanto debe cancelar sí o sí
		/// </summary>
		/// <returns></returns>
		public decimal GetObligatoryPayment()
		{
			decimal obligatoryPayment= 0;
			foreach (DetalleCuotas dt in this.List)
			{
				
				if (mz.erp.systemframework.Util.CompareDates( dt.FechaVencimiento, mz.erp.businessrules.Sistema.DateTime.Now))
				{
					obligatoryPayment+= dt.Monto;
				}
			}
			return decimal.Round(obligatoryPayment,2);
		}

		//Se asume que las condiciones de ventas solo tienen una cuota
		public decimal GetObligatoryPayment(decimal Monto)
		{
			decimal obligatoryPayment= 0;
			foreach (DetalleCuotas dt in this.List)
			{
				
				if (mz.erp.systemframework.Util.CompareDates( dt.FechaVencimiento, mz.erp.businessrules.Sistema.DateTime.Now))
				{
					obligatoryPayment+= Monto;
				}
			}
			return decimal.Round(obligatoryPayment,2);
		}


		#endregion
	
		
	}
}
