using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CuentaCorriente.
	/// </summary>
	public class CuentaCorriente: ArrayList
	{
		public CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//		
		}

		public event EventHandler PagoChanged;
		public event EventHandler TotalPagoComprobantesSignoPositivoChanged;
		public event EventHandler TotalPagoComprobantesSignoNegativoChanged;
		private tpu_AplicacionPagosDataset _dataAplicacionPagos = new tpu_AplicacionPagosDataset();
		private tpu_ComprobanteDetalleDeudaDataset _dataComprobantesDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();

		public tpu_ComprobanteDetalleDeudaDataset DataComprobantesDetalleDeuda
		{
			get{return _dataComprobantesDetalleDeuda;}
		}
 
		public  tpu_AplicacionPagosDataset DataAplicacionPagos
		{
			get{return _dataAplicacionPagos;}
		}
	
		private bool _ordenDebeHaber = true;
		/// <summary>
		/// Esta propiedad en true colocará los comprobantes con signoCtaCte positivo en el debe y las negativo en el haber. Si
		/// está en false hará lo contrario
		/// </summary>
		public bool OrdenDebeHaber
		{
			get	{return _ordenDebeHaber; }
			set {_ordenDebeHaber = value; }
		}
		private string _orderBy;
		public string OrderBy
		{
			get {return _orderBy; }
			set {_orderBy = value; }
		}
		private decimal _saldoAnterior;
		public decimal SaldoAnterior
		{
			get {return _saldoAnterior; }			
		}
		private decimal _saldoPosterior;
		public decimal SaldoPosterior
		{
			get {return _saldoPosterior; }			
		}
		public decimal TotalImputado
		{
			get
			{
				decimal result = 0;
				foreach(ItemCuentaCorriente item in this)
				{
					result = result + item.Pago;
				}
				return result;
			}
		}

		private ArrayList _comprobantesAImputar = new ArrayList();
		public ArrayList ComprobantesAImputar
		{
			get {return _comprobantesAImputar; }			
		}

		private decimal _totalPagoComprobantesSignoPositivo = 0;
		public decimal TotalPagoComprobantesSignoPositivo
		{
			get
			{
				return _totalPagoComprobantesSignoPositivo;
			}

			set
			{
				_totalPagoComprobantesSignoPositivo = value;
				if( TotalPagoComprobantesSignoPositivoChanged != null)
					TotalPagoComprobantesSignoPositivoChanged(this, new EventArgs());
			}
		}

		private decimal _totalPagoComprobantesSignoNegativo = 0;
		public decimal TotalPagoComprobantesSignoNegativo
		{
			get
			{
				return _totalPagoComprobantesSignoNegativo;
			}
			set
			{
				_totalPagoComprobantesSignoNegativo = value;
				if( TotalPagoComprobantesSignoNegativoChanged != null)
					TotalPagoComprobantesSignoNegativoChanged(this, new EventArgs());
			}

		}

		public int CantPagosNegativos
		{
			get
			{
				int cant = 0;
				foreach(ItemCuentaCorriente icc in this.ComprobantesAImputar)
				{
					if (icc.Signo == -1 && icc.Pago != 0)
						cant++;					
				}
				return cant;
			}
		}

		public int CantPagosPositivos
		{
			get
			{
				int cant = 0;
				foreach(ItemCuentaCorriente icc in this.ComprobantesAImputar)
				{
					if (icc.Signo == 1 && icc.Pago != 0)
						cant++;					
				}
				return cant;
			}
		}

		
		public ArrayList GetDetallePagos(int signo)
		{
			ArrayList result = new ArrayList();
			foreach(ItemCuentaCorriente icc in this.ComprobantesAImputar)
			{
				if(icc.Signo == signo && icc.Pago != 0)
					result.Add(icc);
			}
			return result;
		}

		/*Los comprobantes de signo positivo van a la columna Origen y los negativos a la destino
		 * Al reves de lo que sucede en ventas
		 * Si MOde = 0 afecta solo el saldo temporal
		 * Si MOde = 1 afecta el saldo temporal y el saldo
		 * Si MOde = 2 afecta solo el saldo 
		 * */





		public void CommitComprasAplicacionPago(string IdComprobante, short Cuota, string IdTipoDeComprobante, int Signo, decimal Total , int Mode)
		{
			
			_dataAplicacionPagos.Clear();
			_dataComprobantesDetalleDeuda.Clear();
			foreach(ItemCuentaCorriente item in this)
			{
				if(item.Pago > 0)
				{
					tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row = _dataAplicacionPagos.tpu_AplicacionPagos.Newtpu_AplicacionPagosRow();
				
					/*
					row.IdComprobanteOrigen = Signo > 0 ? IdComprobante : item.IdComprobante; 
					row.CuotaOrigen = Signo > 0 ? Cuota : item.Cuota; 
					row.IdTipoComprobanteOrigen = Signo > 0 ? IdTipoDeComprobante : item.IdTipoDeComprobante;

					row.IdComprobanteDestino = Signo < 0 ? IdComprobante : item.IdComprobante;
					row.IdTipoDeComprobanteDestino = Signo < 0 ? IdTipoDeComprobante : item.IdTipoDeComprobante ;
					row.CuotaDestino = Signo < 0 ? Cuota : item.Cuota;
					*/

					row.IdComprobanteOrigen = Signo < 0 ? IdComprobante : item.IdComprobante; 
					row.CuotaOrigen = Signo < 0 ? Cuota : item.Cuota; 
					row.IdTipoComprobanteOrigen = Signo < 0 ? IdTipoDeComprobante : item.IdTipoDeComprobante;

					row.IdComprobanteDestino = Signo > 0 ? IdComprobante : item.IdComprobante;
					row.IdTipoDeComprobanteDestino = Signo > 0 ? IdTipoDeComprobante : item.IdTipoDeComprobante ;
					row.CuotaDestino = Signo > 0 ? Cuota : item.Cuota;				
				
					row.Importe = item.Pago;				
			
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.RowId = Guid.Empty;

					_dataAplicacionPagos.tpu_AplicacionPagos.Addtpu_AplicacionPagosRow( row );


					tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDD = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(item.IdComprobante, item.Cuota);
					if(rowDD != null)
					{
						decimal SaldoBD = rowDD.Saldo;
						decimal SaldoTemporalBD = rowDD.SaldoTemporal;
						decimal SaldoBDSinSigno = SaldoBD * item.Signo;
						decimal SaldoTemporalBDSinSigno = SaldoTemporalBD * item.Signo;
						decimal SaldoNuevoSinSigno = SaldoBDSinSigno - item.Pago;
						decimal SaldoTemporalNuevoSinSigno = SaldoTemporalBDSinSigno - item.Pago;
						decimal SaldoNuevo = SaldoNuevoSinSigno * item.Signo;
						decimal SaldoTemporalNuevo = SaldoTemporalNuevoSinSigno * item.Signo;
						switch(Mode)
						{
							case 0: 
							{
								rowDD.SaldoTemporal = SaldoTemporalNuevo;
								break;
							}
							case 1:
							{
								rowDD.SaldoTemporal = SaldoTemporalNuevo;
								rowDD.Saldo = SaldoNuevo;
								break;
							}
							case 2:
							{
								rowDD.Saldo = SaldoNuevo;
								break;
							}
						}
				
						_dataComprobantesDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDD);
					}

				}
			}

		}	
		


		public void GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte)
		{
			DataSet data = businessrules.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte, null, false, false);	
			BuildDetalleCuentaCorriente(data);
		}

		/*
		public void GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte, string TiposDeComprobantesValidos)
		{
			DataSet data = businessrules.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte, TiposDeComprobantesValidos, false, false);						
			BuildDetalleCuentaCorriente(data);
		}

		public void GetDetalleCuentaCorrienteCompras(string IdProveedor, long TipoCtaCte, string TiposDeComprobantesValidos, bool SoloPendientes)
		{
			DataSet data = businessrules.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte, TiposDeComprobantesValidos, SoloPendientes, false);						
			BuildDetalleCuentaCorriente(data);
		}
		*/
		public void GetDetalleCuentaCorrienteComprasSaldoTemporal(string IdProveedor, long TipoCtaCte, string TiposDeComprobantesValidos, bool SoloPendientesSaldoTemporal)
		{
			DataSet data = businessrules.tpu_CuentaCorriente.GetDetalleCuentaCorrienteCompras(IdProveedor, TipoCtaCte, TiposDeComprobantesValidos, false,SoloPendientesSaldoTemporal);						
			foreach(DataRow row in data.Tables[0].Rows)
			{
				ItemCuentaCorriente icc = new ItemCuentaCorriente();
				icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
				icc.Comprobante = Convert.ToString(row["Comprobante"]);
				icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				icc.Numero = Convert.ToString(row["Numero"]);
				icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
				icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);				
				icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);				
				icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
				icc.Saldo = Convert.ToDecimal(row["SaldoTemporal"]);
				icc.Cuota = Convert.ToInt16(row["Cuota"]);				
				icc.Signo = Convert.ToInt32(row["Signo"]);	
				icc.Autorizada = Convert.ToBoolean(row["Autorizada"]);
				this.Add(icc);				
			}
		}

		public void GetDetalleCuentaCorrienteVentas(string IdCuenta, long TipoCtaCte)
		{
			DataSet data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteVentas(IdCuenta, TipoCtaCte);
			BuildDetalleCuentaCorriente(data);


            
		}

        
        //German 20120222 -  Tarea 0000247

        public void GetRemitosSinFacturar(string IdCuenta, bool ActualizaPrecios)
        {
           

            if (true) //Variable para ver si se muestran los remitos sin facturar
            {

                //Recuperar los remitos sin facturar
                DataSet dataRemitosSinFacturar = businessrules.tsa_CuentaCorriente.GetRemitosSinFacturar(IdCuenta, long.MinValue, ActualizaPrecios);
                //Armar la cta cte con remitos sin facturar
                BuildCuentaCorrienteRemitosSinFacturar(dataRemitosSinFacturar);
            }


        }

        public void GetAcopiosPendientes(string IdCuenta, long TipoCtaCte)
        {


            if (true) //Variable para ver si se muestran los remitos sin facturar
            {
                DataSet dataAcopiosPendientes = businessrules.tsa_CuentaCorriente.GetAcopiosPendientes(IdCuenta, TipoCtaCte);
                BuildCuentaCorrienteAcopiosPendientes(dataAcopiosPendientes);
            }

        }

        private ArrayList _remitosSinFacturar = new ArrayList();
        private decimal _saldoRemitosSinFacturar = 0;

        public decimal SaldoRemitosSinFacturar
        {
            get { return _saldoRemitosSinFacturar; }
        }

        private ArrayList _acopiosPendientes = new ArrayList();
        private decimal _saldoAcopios = 0;

        public decimal SaldoAcopios
        {
            get { return _saldoAcopios; }
        }

        private void BuildCuentaCorrienteRemitosSinFacturar(DataSet data)
        {
            _remitosSinFacturar.Clear();
            _saldoRemitosSinFacturar = 0;
            foreach (DataRow row in data.Tables[0].Rows)
            {
                ItemCuentaCorriente icc = new ItemCuentaCorriente();
                icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
                icc.Comprobante = Convert.ToString(row["Comprobante"]);
                icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
                icc.Numero = Convert.ToString(row["Numero"]);
                icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
                icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
                icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);
                icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
                icc.Saldo = Convert.ToDecimal(row["Saldo"]);
                icc.Cuota = Convert.ToInt16(row["Cuota"]);
                icc.Signo = Convert.ToInt32(row["Signo"]);
                icc.Total = Convert.ToDecimal(row["MontoTotal"]);
                icc.Observaciones = Convert.ToString(row["Observaciones"]);
                _saldoRemitosSinFacturar = _saldoRemitosSinFacturar + icc.Saldo;
                _remitosSinFacturar.Add(icc);
            }
        }


        private void BuildCuentaCorrienteAcopiosPendientes(DataSet data)
        {
            _acopiosPendientes.Clear();
            _saldoAcopios = 0;
            foreach (DataRow row in data.Tables[0].Rows)
            {
                ItemCuentaCorriente icc = new ItemCuentaCorriente();
                icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
                icc.Comprobante = Convert.ToString(row["Comprobante"]);
                icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
                icc.Numero = Convert.ToString(row["Numero"]);
                icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
                icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
                icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);
                icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
                icc.Saldo = Convert.ToDecimal(row["Saldo"]);
                icc.Cuota = Convert.ToInt16(row["Cuota"]);
                icc.Signo = Convert.ToInt32(row["Signo"]);
                icc.Total = Convert.ToDecimal(row["MontoTotal"]);
                icc.Observaciones = Convert.ToString(row["Observaciones"]);
                _saldoAcopios = _saldoAcopios + (icc.Saldo * -1);
                _acopiosPendientes.Add(icc);
            }
        }
        //German 20120222 -  Tarea 0000247

		private void BuildDetalleCuentaCorriente(DataSet data)
		{
			foreach(DataRow row in data.Tables[0].Rows)
			{
				ItemCuentaCorriente icc = new ItemCuentaCorriente();
				icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
				icc.Comprobante = Convert.ToString(row["Comprobante"]);
				icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				icc.Numero = Convert.ToString(row["Numero"]);
				icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
				icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);				
				icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);				
				icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
				icc.Saldo = Convert.ToDecimal(row["Saldo"]);
				icc.Cuota = Convert.ToInt16(row["Cuota"]);				
				icc.Signo = Convert.ToInt32(row["Signo"]);	
				icc.Total = Convert.ToDecimal(row["MontoTotal"]);
                /* Silvina 20110718 - Tarea 0000164 */
                icc.Observaciones = Convert.ToString(row["Observaciones"]);
                /* Fin Silvina 20110718 - Tarea 0000164 */
				this.Add(icc);				
			}
		}
		private void SetDebeHaber(ItemCuentaCorriente icc)
		{
			if (_ordenDebeHaber)
			{
				if (icc.SignoCtaCte == 1)				
				{
					icc.Debe = icc.Importe;
					icc.Haber = 0;
				}
				else
				{
					icc.Debe = 0;
					icc.Haber = icc.Importe;
				}
			}
			else
			{
				if (icc.SignoCtaCte == 1)				
				{
					icc.Debe = 0;
					icc.Haber = icc.Importe;
				}
				else
				{
					icc.Debe = icc.Importe;
					icc.Haber = 0;					
				}
			}
		}
		public int Add(ItemCuentaCorriente icc)
		{
			SetDebeHaber(icc);
			icc.PagoChanged +=new EventHandler(icc_PagoChanged);
			return base.Add (icc);
		}

		public ItemCuentaCorriente GetItemCuentaCorrienteByIdComprobante(string IdComprobante)
		{
			foreach(ItemCuentaCorriente item in this)
			{
				if(item.IdComprobante.Equals(IdComprobante))
					return item;
			}
			return null;
		}

		public void SetOrder()
		{
			switch(_orderBy)
			{
				case "FechaEmision":
				{
					this.Sort(ItemCuentaCorriente.SortByFechaEmisionInstance);
					break;
				}
				case "FechaVencimiento":
				{
					this.Sort(ItemCuentaCorriente.SortByFechaVencimientoInstance);
					break;
				}
			}		
		}
		public void SetAcumulados()
		{			
			_saldoAnterior = 0;				
			decimal saldoAcumulado = 0;
			foreach (ItemCuentaCorriente icc in this)
			{
				decimal importe;
				if (_ordenDebeHaber)
					importe = icc.Importe * icc.SignoCtaCte;
				else
					importe = icc.Importe * icc.SignoCtaCte * -1;

				saldoAcumulado = saldoAcumulado + importe;				
				icc.SaldoAcumulado = saldoAcumulado;				
			}
			_saldoPosterior = saldoAcumulado;
		}

        //German 20120531 -  Tarea 0000247
        public ArrayList Result(string FilterBy, DateTime FechaDesde, DateTime FechaHasta, bool SoloPendientes, string Comprobantes, bool SoloAcopios, string ComprobantesAcopios)
        //Fin German 20120531 -  Tarea 0000247
		{
			bool EncontroPrimerVisible = false;
			ArrayList ListaComprobantes = mz.erp.systemframework.Util.Parse(Comprobantes,",");
			ArrayList data = new ArrayList();	
			decimal saldoAcumulado = 0;
            //German 20120531 -  Tarea 0000247
            ArrayList ListaComprobantesAcopios = mz.erp.systemframework.Util.Parse(ComprobantesAcopios, ",");
            //Fin German 20120531 -  Tarea 0000247
			foreach (ItemCuentaCorriente icc in this)
			{
				bool incluir = false;
				bool incluirFechas = false;
				switch(FilterBy)
				{
					case "FechaEmision":
					{									
						if (icc.FechaEmision >= FechaDesde && icc.FechaEmision <= FechaHasta)
						{
							incluir = true;
							incluirFechas = true;
						}
						break;
					}
					case "FechaVencimiento":
					{
						if (icc.FechaVencimiento >= FechaDesde && icc.FechaVencimiento <= FechaHasta)
						{
							incluir = true;
							incluirFechas = true;
						}
						break;
					}					
				}	
				if (SoloPendientes && icc.Saldo == 0)
					incluir = incluir && false;
                

				if (Comprobantes == "Todos")
					incluir = incluir && true;
				else
					if (!ListaComprobantes.Contains(icc.IdTipoDeComprobante))
						incluir = incluir && false;
                //German 20120416 -  Tarea 0000247

                if (SoloAcopios && !ListaComprobantesAcopios.Contains(icc.IdTipoDeComprobante))
                {
                    incluir = incluir && false;
                }
                //German 20120416 -  Tarea 0000247
				//German 20091020
				/*
				if (incluir)
					data.Add(icc);
				*/
				
				if (incluir)
				{
					//Si esta fitrado por Solo Pendientes o por Solo Facturas, Solo Recibos o Solo Notas de Creditos
					if(
						(
						(SoloPendientes && icc.Saldo != 0) || 
						(Comprobantes != "Todos" && ListaComprobantes.Contains(icc.IdTipoDeComprobante))
                        //German 20120416 -  Tarea 0000247
                        || (SoloAcopios && ListaComprobantesAcopios.Contains(icc.IdTipoDeComprobante))
                        //German 20120416 -  Tarea 0000247
						)
						&& incluirFechas
						)
					{
						decimal importe;
						if (_ordenDebeHaber)
							importe = icc.Saldo * icc.SignoCtaCte;
						else
							importe = icc.Saldo * icc.SignoCtaCte * -1;

						saldoAcumulado = saldoAcumulado + importe;				
						icc.SaldoAcumulado = saldoAcumulado;		
					}

					data.Add(icc);
				}
				//Fin German 20091020
					
				if (EncontroPrimerVisible == false)
				{
					//Al recorrer todos los items de ctacte busca el último item no incluido antes de que se incluya el primer item.
					//para con este conformar el saldo anterior
					if (incluirFechas)
						EncontroPrimerVisible = true;
					else
						_saldoAnterior = icc.SaldoAcumulado;
				}
			}
			return data;
		}

		public void UpdatePago(ItemCuentaCorriente Item)
		{
			Item.Pago = Item.Saldo;	
		}

		private void icc_PagoChanged(object sender, EventArgs e)
		{
			if(PagoChanged != null)
				PagoChanged(this, new EventArgs());
		}

		public void GetDetalleComprobantesAImputar(string process)
		{
			_comprobantesAImputar = new ArrayList();
			string VarCompImputar = Variables.GetValueString(process,"Imputar","Comprobantes"); 
			ArrayList comprobantesImputar = mz.erp.systemframework.Util.Parse(VarCompImputar,",");
			string VarCompDeAnulacion = Variables.GetValueString(process,"Anular","ComprobantesDeAnulacion"); 
			ArrayList comprobantesDeAnulacion = mz.erp.systemframework.Util.Parse(VarCompDeAnulacion ,",");

			foreach (ItemCuentaCorriente icc in this)
			{					
				//Es una factura, prefactura, Nota de Debito y tienen saldo >0, osea que se pueden imputar
				if (icc.Signo == -1 && ((icc.Saldo * icc.Signo) < 0) && !(comprobantesDeAnulacion.Contains( icc.IdTipoDeComprobante)) && (comprobantesImputar.Contains( icc.IdTipoDeComprobante)) )
				{
					ItemCuentaCorriente iccAI = new ItemCuentaCorriente();
					iccAI.IdComprobante = icc.IdComprobante;
					iccAI.Comprobante = icc.Comprobante;
					iccAI.IdTipoDeComprobante = icc.IdTipoDeComprobante;
					iccAI.Numero = icc.Numero;
					iccAI.FechaEmision = icc.FechaEmision;
					iccAI.FechaVencimiento = icc.FechaVencimiento;				
					iccAI.SignoCtaCte = icc.SignoCtaCte;				
					iccAI.Importe = icc.Importe;
					iccAI.Saldo = icc.Saldo;
					iccAI.Cuota = icc.Cuota;				
					iccAI.Signo = icc.Signo;	
					iccAI.TotalPago = Math.Abs(iccAI.Importe - iccAI.Saldo);
					iccAI.PagoChanged += new EventHandler(RecalcularTotalPago);
					this._comprobantesAImputar.Add(iccAI);				
				}
					//Es un recibo o nota de credito y tienen saldo > 0, osea que se pueden utilizar para aplicarlos
				else if(icc.Signo == 1 && ((icc.Saldo * icc.Signo)  > 0) && !(comprobantesDeAnulacion.Contains( icc.IdTipoDeComprobante)) && (comprobantesImputar.Contains( icc.IdTipoDeComprobante)) )
				{
					ItemCuentaCorriente iccAI = new ItemCuentaCorriente();
					iccAI.IdComprobante = icc.IdComprobante;
					iccAI.Comprobante = icc.Comprobante;
					iccAI.IdTipoDeComprobante = icc.IdTipoDeComprobante;
					iccAI.Numero = icc.Numero;
					iccAI.FechaEmision = icc.FechaEmision;
					iccAI.FechaVencimiento = icc.FechaVencimiento;				
					iccAI.SignoCtaCte = icc.SignoCtaCte;				
					iccAI.Importe = icc.Importe;
					iccAI.Saldo = icc.Saldo;
					iccAI.Cuota = icc.Cuota;				
					iccAI.Signo = icc.Signo;	
					iccAI.TotalPago = Math.Abs(iccAI.Importe - iccAI.Saldo);
					iccAI.PagoChanged += new EventHandler(RecalcularTotalPago);
					this._comprobantesAImputar.Add(iccAI);				
				}
			}

		}
		

		public void RecalcularTotalPago(object sender, EventArgs args)
		{
			this.RecalcularTotalPago();
		}

		public void RecalcularTotalPago()
		{
			//this.TotalImputado=0;
			this._totalPagoComprobantesSignoNegativo = 0;
			this._totalPagoComprobantesSignoPositivo = 0;
			foreach(ItemCuentaCorriente icc in this._comprobantesAImputar)
				if(icc.Signo ==-1)
				{
					//this.TotalImputado= this.TotalImputado + icc.Pago;
					this.TotalPagoComprobantesSignoNegativo = this._totalPagoComprobantesSignoNegativo + icc.Pago;
				}
				else
					this.TotalPagoComprobantesSignoPositivo = this._totalPagoComprobantesSignoPositivo + icc.Pago;	
			
		}

        


	}

	public class SortByFechaEmisionClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			
			ItemCuentaCorriente item1 = (ItemCuentaCorriente)x;
			ItemCuentaCorriente item2 = (ItemCuentaCorriente)y;
			return item1.FechaEmision.CompareTo(item2.FechaEmision);
		}

		#endregion
	}
	public class SortByFechaVencimientoClass : IComparer
	{
		#region Miembros de IComparer

		public int Compare(object x, object y)
		{
			
			ItemCuentaCorriente item1 = (ItemCuentaCorriente)x;
			ItemCuentaCorriente item2 = (ItemCuentaCorriente)y;
			return item1.FechaVencimiento.CompareTo(item2.FechaVencimiento);
		}

		#endregion
	}

    //Sabrina: Tarea 1122. 20110818
    public class SortByFechaEmisionDescClass : IComparer
    {
        #region Miembros de IComparer

        public int Compare(object x, object y)
        {
            ItemCuentaCorriente item1 = (ItemCuentaCorriente)x;
            ItemCuentaCorriente item2 = (ItemCuentaCorriente)y;
            return item2.FechaEmision.CompareTo(item1.FechaEmision);
        }

        #endregion

    }

    public class SortByFechaVencimientoDescClass : IComparer
    {
        #region Miembros de IComparer

        public int Compare(object x, object y)
        {
            ItemCuentaCorriente item1 = (ItemCuentaCorriente)x;
            ItemCuentaCorriente item2 = (ItemCuentaCorriente)y;
            return item2.FechaVencimiento.CompareTo(item1.FechaVencimiento);
        }

        #endregion

    }
    //Fin Sabrina: Tarea 1122. 20110818
    
    public class ItemCuentaCorriente : IComparable
	{
		#region Constructores
		public ItemCuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Eventos
		public event EventHandler PagoChanged;
		#endregion

		#region Propiedades
		private string _idComprobante;
		public string IdComprobante
		{
			get {return _idComprobante; }
			set {_idComprobante = value; }
		}
		private string _comprobante;
		public string Comprobante
		{
			get {return _comprobante; }
			set {_comprobante = value; }
		}
		private string _idTipoDeComprobante;
		public string IdTipoDeComprobante
		{
			get {return _idTipoDeComprobante; }
			set {_idTipoDeComprobante = value; }
		}
		private string _numero;
		public string Numero
		{
			get {return _numero; }
			set {_numero = value; }
		}
		private DateTime _fechaEmision;
		public DateTime FechaEmision
		{
			get {return _fechaEmision; }
			set {_fechaEmision = value; }
		}
		private DateTime _fechaVencimiento;
		public DateTime FechaVencimiento
		{
			get {return _fechaVencimiento; }
			set {_fechaVencimiento = value; }
		}			
		private decimal _debe;
		public decimal Debe
		{
			get {return _debe; }
			set {_debe = value; }
		}							
		private decimal _haber;
		public decimal Haber
		{
			get {return _haber; }
			set {_haber = value; }
		}		
		private long _signoCtaCte;
		public long SignoCtaCte
		{
			get {return _signoCtaCte; }
			set {_signoCtaCte = value; }
		}	
		private decimal _importe;
		public decimal Importe
		{
			get {return _importe; }
			set {_importe = value; }
		}
		private decimal _saldo;
		public decimal Saldo
		{
			get {return _saldo; }
			set {_saldo = value; }
		}						
		private decimal _saldoAcumulado;
		public decimal SaldoAcumulado
		{
			get {return _saldoAcumulado; }
			set {_saldoAcumulado = value; }
		}
		private short _cuota;
		public short Cuota
		{
			get {return _cuota; }
			set {_cuota = value; }
		}

		private decimal _totalPago = 0;
		public decimal TotalPago
		{
			get
			{
				return _totalPago;
			}
			set
			{
				_totalPago = value;
			}
		}

		private decimal _pago = 0;
		public decimal Pago
		{
			get{return _pago;}
			set
			{
				if(_pago != value)
				{
					_pago = value;
					_totalPago = _totalPago + _pago;
					if(PagoChanged != null)
						PagoChanged(this, new EventArgs());
				}
			}
		}

		private int _signo = 0;
		public int Signo
		{
			get{return _signo;}
			set{_signo = value;}
		}

		private bool _autorizada;
		public bool Autorizada
		{
			get{return _autorizada;}
			set{_autorizada = value;}
		}

		private decimal _total;
		public decimal Total
		{
			get {return _total; }
			set {_total = value; }
		}						

		private bool _leyoImputacionesDeBD = false;
		public bool LeyoImputacionesDeBD
		{
			get{return _leyoImputacionesDeBD;}
			set{_leyoImputacionesDeBD = value;}
		}

		private ArrayList _imputaciones = new ArrayList();
		public ArrayList Imputaciones
		{
			get{return _imputaciones;}
			set{_imputaciones = value;}
		}

		public static IComparer SortByFechaEmisionInstance
		{
			get
			{
				return (IComparer)new SortByFechaEmisionClass(); 
			}
		}

		public static IComparer SortByFechaVencimientoInstance
		{
			get
			{
				return (IComparer)new SortByFechaVencimientoClass(); 
			}
		}

        //Sabrina: Tarea 1122. 20110818
        public static IComparer SortByFechaEmisionDescInstance
        {
            get
            {
                return (IComparer)new SortByFechaEmisionDescClass();
            }
        }

        public static IComparer SortByFechaVencimientoDescInstance
        {
            get
            {
                return (IComparer)new SortByFechaVencimientoDescClass();
            }
        }
        //Fin Sabrina: Tarea 1122. 20110818

		private string _tipoDeComprobante = string.Empty;
		public string TipoDeComprobante
		{
			get
			{
				return _tipoDeComprobante;
			}
		}

		private tsa_AplicacionPagosDataset _dataAplicacionDePagos = new tsa_AplicacionPagosDataset();
		public tsa_AplicacionPagosDataset dataAplicacionPagos
		{
			get { return _dataAplicacionDePagos; }
		}

		private tsa_ComprobanteDetalleDeudaDataset _dataDetalleDeuda  = new tsa_ComprobanteDetalleDeudaDataset();
		public tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda
		{
			get { return _dataDetalleDeuda; }
		}

        /* Silvina 20110718 - Tarea 0000164 */
        private string _observaciones = string.Empty;
        public string Observaciones
        {
            set { _observaciones = value; }
            get { return _observaciones; }
        }
        /* Fin Silvina 20110718 - Tarea 0000164 */

		#endregion

		#region Métodos Públicos
		public bool EstaAnulado(string process)
		{ 
			tsa_AplicacionPagosDataset dataAplicacionDePagos = new tsa_AplicacionPagosDataset();
			//Es un recibo o una nota de credito, por ende hay que buscarlo por el campo IdComporbanteDestino
			// en la tabla tsa_AplicacionPagos
			string VarCompDeAnulacion = Variables.GetValueString(process, "Anular", "ComprobantesDeAnulacion");
			ArrayList comprobantesDeAnulacion = mz.erp.systemframework.Util.Parse(VarCompDeAnulacion ,",");
			//ArrayList comprobantesDeAnulacion = mz.erp.systemframework.Util.Parse(Constantes.ComprobantesDeAnulacion,",");

			if(this.Signo == 1)
			{
				dataAplicacionDePagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,this.IdTipoDeComprobante,this.IdComprobante,Convert.ToInt16(this.Cuota));
				if(dataAplicacionDePagos.tsa_AplicacionPagos.Rows.Count ==1)
				{
					System.Data.DataRow row = dataAplicacionDePagos.tsa_AplicacionPagos.Rows[0];
					string IdTipoDeComprobante = (string)row["IdTipoComprobanteOrigen"];
					return comprobantesDeAnulacion.Contains(IdTipoDeComprobante);
					

				}
				else return false;


			
			}
				//Es una factura o una nota de debito, por ende hay que buscarlo por el campo IdComporbanteOrigen
				// en la tabla tsa_AplicacionPagos
			
			else
			{
				dataAplicacionDePagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(this.IdComprobante,Convert.ToInt16(this.Cuota),decimal.MinValue,null,null,short.MinValue);
				if(dataAplicacionDePagos.tsa_AplicacionPagos.Rows.Count ==1)
				{
					System.Data.DataRow row = dataAplicacionDePagos.tsa_AplicacionPagos.Rows[0];
					string IdTipoDeComprobante = (string)row["IdTipoDeComprobanteDestino"];
					return comprobantesDeAnulacion.Contains(IdTipoDeComprobante);
					

				}
				else return false;
		
			}
		}


		public ArrayList GetImputaciones()
		{
			if(!LeyoImputacionesDeBD)
			{
				DataSet data = businessrules.tsa_CuentaCorriente.GetImputacionesDetalleCuentaCorrienteVentas(this.IdTipoDeComprobante, this.IdComprobante, this.Cuota, this.Signo);
				BuildDetalleImputacionesCuentaCorriente(data);
				LeyoImputacionesDeBD = true;
			}
			return Imputaciones;
		}

		public ArrayList GetImputacionesCliente()
		{
			if(!LeyoImputacionesDeBD)
			{
				DataSet data = businessrules.tsa_CuentaCorriente.GetImputacionesDetalleCuentaCorrienteVentas(this.IdTipoDeComprobante, this.IdComprobante, this.Cuota, this.Signo);
				BuildDetalleImputacionesCuentaCorriente(data);
				LeyoImputacionesDeBD = true;
			}
			return Imputaciones;
		}

		public ArrayList GetImputacionesProveedor()
		{
			if(!LeyoImputacionesDeBD)
			{
				DataSet data = businessrules.tpu_CuentaCorriente.GetImputacionesDetalleCuentaCorrienteCompras(this.IdTipoDeComprobante, this.IdComprobante, this.Cuota, this.Signo);
				BuildDetalleImputacionesCuentaCorriente(data);
				LeyoImputacionesDeBD = true;
			}
			return Imputaciones;
		}

		public bool DesimputarCliente()
		{			
			decimal pago = 0;
			//Es un recibo o una nota de credito, por ende hay que buscarlo por el campo IdComporbanteDestino
			// en la tabla tsa_AplicacionPagos
			if(this.Signo == 1)
			{
				_dataAplicacionDePagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,this.IdTipoDeComprobante,this.IdComprobante,Convert.ToInt16(this.Cuota));
				foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in _dataAplicacionDePagos.tsa_AplicacionPagos.Rows)
				{
					string IdComprobante = (string) row["IdComprobanteOrigen"];
					short cuota = (short) row["CuotaOrigen"];
					pago = pago + row.Importe;
					try
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						//tener en cuenta el signo del saldo
						rowDetalle.Saldo = rowDetalle.Saldo + (-1)*row.Importe; 
							
						_dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle);
					}
					catch(Exception e)
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet = _dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
						if 	(rowDet != null)
							rowDet.Saldo = rowDet.Saldo + (-1)*row.Importe ;
					}
					row.Delete();
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle1 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
				//Se multiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
				if(rowDetalle1 != null)
				{
					rowDetalle1.Saldo = rowDetalle1.Saldo + 1*pago; 
					_dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle1);
				}

			
			}
				//Es una factura o una nota de debito, por ende hay que buscarlo por el campo IdComporbanteOrigen
				// en la tabla tsa_AplicacionPagos
			
			else
			{
				_dataAplicacionDePagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(this.IdComprobante,Convert.ToInt16(this.Cuota),decimal.MinValue,null,null,short.MinValue);
				foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in _dataAplicacionDePagos.tsa_AplicacionPagos.Rows)
				{
					string IdComprobante = (string) row["IdComprobanteDestino"];
					short cuota = (short) row["CuotaDestino"];
		
					pago = pago + row.Importe;
					try
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle =mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						//tener en cuenta el signo del saldo
						rowDetalle.Saldo = rowDetalle.Saldo + 1*row.Importe; 
						_dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle);
					}
					catch(Exception e)
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet = _dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
						rowDet.Saldo = rowDet.Saldo + 1*row.Importe;
					}
					row.Delete();
						
					
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
				//Tener en cuenta el signo. Se multiplica por -1 pues this.Signo = -1 y pues el signo de saldo es negativo
				//Consolidacion de signos
				if(rowDetalle2 != null)
				{
					rowDetalle2.Saldo = rowDetalle2.Saldo + (-1)*pago; 
					_dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle2);
				}
			
			}
			//Chequeo que se haya echo alguna desimputacion
			return (pago > 0);
		}


		/*public bool DesimputarProveedor()
		{
			_dataAplicacionDePagos = new tpu_AplicacionPagosDataset();
			_dataDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();
			decimal pago = 0;
			//Es un recibo o una nota de credito, por ende hay que buscarlo por el campo IdComporbanteDestino
			// en la tabla tpu_AplicacionPagos
			if(this.Signo == 1)
			{
				_dataAplicacionDePagos = mz.erp.businessrules.tpu_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,this.IdTipoDeComprobante,this.IdComprobante,Convert.ToInt16(this.Cuota));
				foreach(tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row in _dataAplicacionDePagos.tpu_AplicacionPagos.Rows)
				{
					string IdComprobante = (string) row["IdComprobanteOrigen"];
					short cuota = (short) row["CuotaOrigen"];
					pago = pago + row.Importe;
					try
					{
						tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle =mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						//tener emn cuenta el signo del saldo
						rowDetalle.Saldo = rowDetalle.Saldo + (-1)*row.Importe; 
							
						_dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle);
					}
					catch(Exception e)
					{
						tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDet;
						rowDet = _dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
						if 	(rowDet != null)
							rowDet.Saldo = rowDet.Saldo + (-1)*row.Importe ;
					}
					row.Delete();
						
					
				}
				tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle1 =mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
				//Semultiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
				if(rowDetalle1 != null)
				{
					rowDetalle1.Saldo = rowDetalle1.Saldo + 1*pago; 
					_dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle1);
				}

			
			}
				//Es una factura o una nota de debito, por ende hay que buscarlo por el campo IdComporbanteOrigen
				// en la tabla tpu_AplicacionPagos
			
			else
			{
				_dataAplicacionDePagos = mz.erp.businessrules.tpu_AplicacionPagos.GetList(this.IdComprobante,Convert.ToInt16(this.Cuota),decimal.MinValue,null,null,short.MinValue);
				foreach(tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row in _dataAplicacionDePagos.tpu_AplicacionPagos.Rows)
				{
					string IdComprobante = (string) row["IdComprobanteDestino"];
					short cuota = (short) row["CuotaDestino"];
		
					pago = pago + row.Importe;
					try
					{
						tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle =mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						//tener en cuenta el signo del saldo
						rowDetalle.Saldo = rowDetalle.Saldo + 1*row.Importe; 
						_dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle);
					}
					catch(Exception e)
					{
						tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDet;
						rowDet = _dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
						rowDet.Saldo = rowDet.Saldo + 1*row.Importe;
					}
					row.Delete();
						
					
				}
				tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle2 =mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
				//Tener en cuenta el signo. Se multiplica por -1 pues this.Signo = -1 y pues el signo de saldo es negativo
				//Consolidacion de signos
				if(rowDetalle2 != null)
				{
					rowDetalle2.Saldo = rowDetalle2.Saldo + (-1)*pago; 
					_dataDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle2);
				}
			
			
			
			}
			//Chequeo que se haya echo alguna desimputacion
			return (pago > 0);
		}
*/

		public void flushDesimputarCliente()
		{
			//mz.erp.dataaccess.tsa_CuentaCorriente.Update(_dataAplicacionDePagos,_dataDetalleDeuda);
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update(_dataDetalleDeuda);
			mz.erp.dataaccess.tsa_AplicacionPagos.Update(_dataAplicacionDePagos);
		}


		#endregion

		#region Métodos Privados
		private void BuildDetalleImputacionesCuentaCorriente(DataSet data)
		{
			foreach(DataRow row in data.Tables[0].Rows)
			{
				ItemCuentaCorriente icc = new ItemCuentaCorriente();
				icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
				icc.Comprobante = Convert.ToString(row["Comprobante"]);
				icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				icc.Numero = Convert.ToString(row["Numero"]);
				icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
				icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);				
				icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);				
				icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
				icc.Saldo = Convert.ToDecimal(row["Saldo"]);
				icc.Cuota = Convert.ToInt16(row["Cuota"]);				
				icc.Signo = Convert.ToInt32(row["Signo"]);	
				icc.Pago = Convert.ToDecimal(row["Importe"]);
				this.Imputaciones.Add(icc);				
			}
		}

		#endregion

		#region Implementacion IComparable

		public int CompareTo( object obj )
		{
			return this.FechaEmision.CompareTo( ( ( ItemCuentaCorriente )obj ).FechaEmision );
		}
		#endregion
	}

	public class Imputacion/*: IComparable*/
	{

		#region Constructores
		public Imputacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables privadas
		string _idTipoComprobanteOrigen;
		string _idComprobanteOrigen;
		short _cuotaOrigen;
		decimal _importe;
		string _idTipoComprobanteDestino;
		string _idComprobanteDestino;
		short _cuotaDestino;
		#endregion

		#region Propiedades
		public string IdTipoComprobanteOrigen
		{
			get {return _idTipoComprobanteOrigen; }
		}

		public string IdComprobanteOrigen
		{
			get {return _idComprobanteOrigen; }
		}

		public short CuotaOrigen
		{
			get {return _cuotaOrigen; }
			set {_cuotaOrigen = value; }
		}

		public decimal Importe
		{
			get {return _importe; }
			set {_importe = value; }
		}

		public string IdTipoComprobanteDestino
		{
			get {return _idTipoComprobanteDestino; }
		}

		public string IdComprobanteDestino
		{
			get {return _idComprobanteDestino; }
		}

		public short CuotaDestino
		{
			get {return _cuotaDestino; }
			set {_cuotaDestino = value; }
		}
		#endregion

	}

}
