using System;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.commontypes;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de CuentaCorriente.
	/// </summary>
	public class DetalleCuentaCorriente
	{
		public DetalleCuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

	
		public DetalleCuentaCorriente(DataRow row)
		{
			if(!row.IsNull("IdComprobante"))
				_idComprobante= Convert.ToString(row["IdComprobante"]);
			if(!row.IsNull("Descripcion"))
			{
				_comprobante = Convert.ToString(row["Descripcion"]);
				_tipoDeComprobante = Convert.ToString(row["Descripcion"]);
			}
			if(!row.IsNull("IdTipoDeComprobante"))
				_idTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
			if(!row.IsNull("Signo"))
				_signo = Convert.ToInt32(row["Signo"]);
			if(!row.IsNull("Numero"))
				_numero = Convert.ToString(row["Numero"]);
			if(!row.IsNull("FechaVencimiento"))
				_fechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
			if(!row.IsNull("FechaEmision"))
				_fechaEmision = Convert.ToDateTime(row["FechaEmision"]);
			if(!row.IsNull("Cuota"))
				_cuota = Convert.ToInt16(row["Cuota"]);
			if(!row.IsNull("ImporteCuota"))
				_importe = Convert.ToDecimal(row["ImporteCuota"]);
			if(!row.IsNull("Saldo"))
				_saldo = Convert.ToDecimal(row["Saldo"]);
			if(!row.IsNull("MontoTotal"))
				_total = Convert.ToDecimal(row["MontoTotal"]);
			if(!row.IsNull("Debe"))
				_debe = Convert.ToDecimal(row["Debe"]);
			if(!row.IsNull("Haber"))
				_haber = Convert.ToDecimal(row["Haber"]);
			if(!row.IsNull("SaldoAcumulado"))
				_saldoAcumulado = Convert.ToDecimal(row["SaldoAcumulado"]);
			if(!row.IsNull("TextoHTML"))
				_textoHTML = Convert.ToString(row["textoHTML"]);
			
			_totalPago = Math.Abs(_importe - _saldo);
			/*_pago = Math.Abs(_importe - _saldo);*/
			_pago = 0;
			
			

		}

		public DetalleCuentaCorriente(businessrules.ItemCuentaCorriente item)
		{
			_idComprobante= item.IdComprobante;
			_comprobante = item.Comprobante;
			_tipoDeComprobante = item.Comprobante;
			_idTipoDeComprobante =item.IdTipoDeComprobante;
			_signo = item.Signo;
			_numero = item.Numero;
			_fechaVencimiento = item.FechaVencimiento;
			_fechaEmision = item.FechaEmision;
			_cuota =item.Cuota;
			_importe = item.Importe;
			_saldo = item.Saldo;
			_total = item.Total; 
			_debe = item.Debe;
			_haber = item.Haber;
			_saldoAcumulado = item.SaldoAcumulado;
			//_textoHTML = Convert.ToString(row["textoHTML"]);
			_totalPago = item.TotalPago;
			//_totalPago = Math.Abs(_importe - _saldo);
			_pago = item.Pago;
			
			

		}


		private string _idComprobante = string.Empty;
		private string _comprobante = string.Empty;
		private string _numero = string.Empty;
		private DateTime _fechaEmision = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		//Total del comprobante
		private decimal _total = 0;
		private int _signo = 0;
		private int _cuota = 1;
		//Importe de la cuota
		private decimal _importe = 0;
		//Saldo Actual de la cuota (importe - pago)
		private decimal _saldo = 0;
		private decimal _debe = 0;
		private decimal _haber =  0;
		private decimal _saldoAcumulado = 0;
		private decimal _saldoAcumuladoSoloPendientes = 0;
		
		private decimal _totalPago = 0;
		private decimal _pago = 0;


		private string _idTipoDeComprobante = string.Empty;
		private string _tipoDeComprobante = string.Empty;
		private string _textoHTML= string.Empty;

		private DateTime _fechaPago = mz.erp.businessrules.Sistema.DateTime.Now; 

		private tsa_AplicacionPagosDataset _dataAplicacionDePagos = new tsa_AplicacionPagosDataset();
		private tsa_ComprobanteDetalleDeudaDataset _dataDetalleDeuda = new tsa_ComprobanteDetalleDeudaDataset();

	   
		public event EventHandler  PagoChanged;



		#region Propiedades

		public decimal ImporteSinSigno
		{
			get
			{
				return _signo * _importe;
			}
		}

		public decimal  SaldoSinSigno
		{
			get
			{
				return _signo * _saldo;
			}
		}
		public decimal SaldoAcumuladoSinSigno
		{
			get
			{
				return Math.Abs(_saldoAcumulado);
			}
		}

		public decimal SaldoAcumuladoSoloPendientesSinSigno
		{
			get
			{
				return Math.Abs(_saldoAcumuladoSoloPendientes);
			}
		}
		

		public tsa_AplicacionPagosDataset DataAplicacionDePagos
		{
			get
			{
				return _dataAplicacionDePagos;
			}

		}
		
		public tsa_ComprobanteDetalleDeudaDataset DataDetalleDeuda
		{
			get
			{
				return _dataDetalleDeuda;
			}

		}


		public string IdComprobante
		{	
			get {return _idComprobante;}
			set {_idComprobante = value;}


		}

		public string IdTipoDeComprobante
		{
			get{return _idTipoDeComprobante;}
			set{_idTipoDeComprobante = value;}

		}

		public string Comprobante
		{
			get {return _comprobante;}
			set {_comprobante = value;}
		}

		public string Numero
		{
			get {return _numero;}
			set {_numero = value;}
		}

		public DateTime FechaEmision
		{
			get{return _fechaEmision;}
			set {_fechaEmision = value;}

		}

		public DateTime FechaVencimiento
		{
			get {return _fechaVencimiento;}
			set {_fechaVencimiento = value;}

		}
		
		public DateTime FechaPago
		{
			get {return _fechaPago;}
			set {_fechaPago = value;}

		}

		public decimal Total
		{
			get {return _total;}
			set {_total = value;}

		}

		public int Signo
		{
			get{return _signo;}
			set
			{
				_signo = value;
				if (_signo == -1)
				{
					this._debe = this.Importe * this.Signo;
					this._haber = 0;

				}
				else
				{
					this._haber= this.Importe * this.Signo;
					this._debe = 0;
				}

			}
		}

		public decimal Importe 
		{
			get{return _importe;}
			set {_importe = value;}

		}
	
		public decimal Saldo
		{
			get{return _saldo;}
			set{_saldo = value;}

		}
		
		public decimal Debe
		{
			get {return _debe;}
			


		}

		public decimal Haber
		{
			get {return _haber;}
			

		}

		public string TextoHTML
		{
			get {return _textoHTML;}
		}

		public int Cuota 
		{

			get {return _cuota;}
			set {_cuota = value;}

		}

		public decimal SaldoAcumulado
		{	
			get {return _saldoAcumulado;}
			set {_saldoAcumulado = value;}

		}

		
		public decimal SaldoAcumuladoSoloPendientes
		{	
			get {return _saldoAcumuladoSoloPendientes;}
			set {_saldoAcumuladoSoloPendientes = value;}

		}
		public void SetPago(decimal pago)
		{
			if (_pago != pago)
			{
					
				_pago = pago;
				_totalPago = _totalPago + _pago;
				if (PagoChanged != null)
					PagoChanged(this, new EventArgs());
			}
		}

		public decimal TotalPago
		{
			get
			{
				return _totalPago;
			}
		}

		public decimal Pago
		{
			get{return _pago;}
			set
			{
				
				if (value > (_saldo*_signo) ) _pago = 0;
				else
				if (_pago != value)
				{
					
					_pago = value;
					_totalPago = _totalPago + _pago;
					if (PagoChanged != null)
						PagoChanged(this, new EventArgs());
				}
			}

		}

		public string TipoDeComprobante
		{
			get
			{
				return _tipoDeComprobante;
			}
			set
			{
				_tipoDeComprobante = value;
			}
		}

        //Sabrina: Tarea 1119. 20110816
        public static IComparer SortByFechaEmisionAscInstance
        {
            get
            {
                return (IComparer)new SortByFechaEmisionAscClass();
            }
        }

        public static IComparer SortByFechaEmisionDescInstance
        {
            get
            {
                return (IComparer)new SortByFechaEmisionDescClass();
            }
        }

        public static IComparer SortByFechaVencimientoAscInstance
        {
            get
            {
                return (IComparer)new SortByFechaVencimientoAscClass();
            }
        }

        public static IComparer SortByFechaVencimientoDescInstance
        {
            get
            {
                return (IComparer)new SortByFechaVencimientoDescClass();
            }
        }
        //Fin Sabrina: Tarea 1119. 20110816

        #endregion

		public void ExtractDatosMinimos(DataRow row)
		{
			if(!row.IsNull("IdComprobante"))
				_idComprobante= Convert.ToString(row["IdComprobante"]);
			if(!row.IsNull("Comprobante"))
			{
				_comprobante = Convert.ToString(row["Comprobante"]);
				_tipoDeComprobante = Convert.ToString(row["Comprobante"]);
			}
			if(!row.IsNull("IdTipoDeComprobante"))
				_idTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
			if(!row.IsNull("Signo"))
				_signo = Convert.ToInt32(row["Signo"]);
			if(!row.IsNull("Numero"))
				_numero = Convert.ToString(row["Numero"]);
			if(!row.IsNull("FechaVencimiento"))
				_fechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
			if(!row.IsNull("FechaEmision"))
				_fechaEmision = Convert.ToDateTime(row["FechaEmision"]);
			if(!row.IsNull("Cuota"))
				_cuota = Convert.ToInt16(row["Cuota"]);
			if(!row.IsNull("ImporteCuota"))
				_importe = Convert.ToDecimal(row["ImporteCuota"]);
			if(!row.IsNull("Saldo"))
				_saldo = Convert.ToDecimal(row["Saldo"]);
			if(!row.IsNull("MontoTotal"))
				_total = Convert.ToDecimal(row["MontoTotal"]);
			_totalPago = Math.Abs(_importe - _saldo);
			/*_pago = Math.Abs(_importe - _saldo);*/
			_pago = 0;
			
			
		}
		

		public ArrayList GetAsociaciones(CuentaCorriente cc, string ProcessName)
		{	
			ArrayList resul = new ArrayList();
			tsa_AplicacionPagosDataset data = new tsa_AplicacionPagosDataset();
			CuentaCorriente ccClone = Factory.GetCuentaCorriente(cc.IdCuenta,DateTime.MinValue, DateTime.MaxValue, null);
			ArrayList dccs = ccClone.GetDetalleCuentaCorriente(ProcessName);
			//Es un comprobante origen en la tabla tsa_AplicacionesDePago (Factura, Nota de Debito, etc...)
			if(this.Signo == -1)
			{
				data = mz.erp.businessrules.tsa_AplicacionPagos.GetList(this.IdComprobante,Convert.ToInt16(this.Cuota),decimal.MinValue,null,null,short.MinValue);
				//Busco lo s recibos asociados a la factura

				foreach( DetalleCuentaCorriente dcc in dccs)
				{
					
					foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in data.tsa_AplicacionPagos.Rows)
					{

						//Los recibos estan en la columna IdComprobanteDestino en la tabla tsa_AplicacionPagos
						if (dcc.IdComprobante.Equals(Convert.ToString( row["IdComprobanteDestino"])) && (dcc.Cuota ==((short)row["CuotaDestino"])))
						{
							DetalleCuentaCorriente dccClone = (DetalleCuentaCorriente)dcc.MemberwiseClone();
							//truco para engañar al setter de Pago
							decimal saldo = dccClone.Saldo;
							dccClone.Saldo = row.Importe *  dccClone.Signo;
							dccClone.Pago = row.Importe;
							dccClone.Saldo = saldo;
							dccClone.FechaPago = row.FechaCreacion;
							resul.Add(dccClone);
						}
					}

			
				}
			}
			
			
			
				//Es un comprobante destino en la tabla tsa_AplicacionesDePago (Recibos, Notas de Creditos, etc...) 
			
			else
			{
			
				data = mz.erp.businessrules.tsa_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,this.IdTipoDeComprobante,this.IdComprobante,Convert.ToInt16(this.Cuota));
				//Busco las facturas asociadas al recibo
				//Las facturas estan en la columna IdComprobanteOrigen en la tabla tsa_AplicacionPagos
				foreach( DetalleCuentaCorriente dcc in dccs)
				{
						
					foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in data.tsa_AplicacionPagos.Rows)
					{

						if (dcc.IdComprobante.Equals((string)row["IdComprobanteOrigen"]) && (dcc.Cuota == ((short)row["CuotaOrigen"])))
						{
							DetalleCuentaCorriente dccClone = (DetalleCuentaCorriente)dcc.MemberwiseClone();
							//truco para engañar al setter de Pago
							decimal saldo = dccClone.Saldo;
							dccClone.Saldo = row.Importe *  dccClone.Signo;
							dccClone.Pago = row.Importe;
							dccClone.Saldo = saldo;
							dccClone.FechaPago = row.FechaCreacion;
					
							resul.Add(dccClone);
						}
					}	
				}
			}
			return resul;
			


		}
		//Elimina las asociaciones que hay con este comprobante en la tabla tsa_AplicacionPagos
		//Actualiza la el detalle de la Cuenta Corriente (tabla tsa_ComporbantesDetalleDeuda)
		public bool Desimputar()
		{
			_dataAplicacionDePagos = new tsa_AplicacionPagosDataset();
			_dataDetalleDeuda = new tsa_ComprobanteDetalleDeudaDataset();
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
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle =mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
							//tener emn cuenta el signo del saldo
							rowDetalle.Saldo = rowDetalle.Saldo + (-1)*row.Importe; 
							
							_dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle);
						}
						catch(Exception e){
								tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet;
								rowDet = _dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
								if 	(rowDet != null)
									rowDet.Saldo = rowDet.Saldo + (-1)*row.Importe ;
						}
						row.Delete();
						
					
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle1 =mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
				//Semultiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
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
					catch(Exception e){
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet;
						rowDet = _dataDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
						rowDet.Saldo = rowDet.Saldo + 1*row.Importe;
					}
					row.Delete();
						
					
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle2 =mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(this.IdComprobante,(short)this.Cuota);
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

		public void flushDesimputar()
		{
			mz.erp.dataaccess.tsa_CuentaCorriente.Update(_dataAplicacionDePagos,_dataDetalleDeuda);
		}

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

        //Sabrina: Tarea 1119. 20110816
        public class SortByFechaEmisionAscClass : IComparer
        {
            #region Miembros de IComparer

            public int Compare(object x, object y)
            {
                DetalleCuentaCorriente detalle1 = (DetalleCuentaCorriente)x;
                DetalleCuentaCorriente detalle2 = (DetalleCuentaCorriente)y;
                return detalle1.FechaEmision.CompareTo(detalle2.FechaEmision);
            }

            #endregion

        }

        public class SortByFechaEmisionDescClass : IComparer
        {
            #region Miembros de IComparer

            public int Compare(object x, object y)
            {
                DetalleCuentaCorriente detalle1 = (DetalleCuentaCorriente)x;
                DetalleCuentaCorriente detalle2 = (DetalleCuentaCorriente)y;
                return detalle2.FechaEmision.CompareTo(detalle1.FechaEmision);
            }

            #endregion

        }

        public class SortByFechaVencimientoAscClass : IComparer
        {
            #region Miembros de IComparer

            public int Compare(object x, object y)
            {
                DetalleCuentaCorriente detalle1 = (DetalleCuentaCorriente)x;
                DetalleCuentaCorriente detalle2 = (DetalleCuentaCorriente)y;
                return detalle1.FechaVencimiento.CompareTo(detalle2.FechaVencimiento);
            }

            #endregion

        }

        public class SortByFechaVencimientoDescClass : IComparer
        {
            #region Miembros de IComparer

            public int Compare(object x, object y)
            {
                DetalleCuentaCorriente detalle1 = (DetalleCuentaCorriente)x;
                DetalleCuentaCorriente detalle2 = (DetalleCuentaCorriente)y;
                return detalle2.FechaVencimiento.CompareTo(detalle1.FechaVencimiento);
            }

            #endregion

        }
        //Fin Sabrina: Tarea 1119. 20110816

		}


	public class DetalleCuentaCorrienteView
	{


		#region Constructor
		
		public DetalleCuentaCorrienteView(DetalleCuentaCorriente dcc, decimal SaldoAnterior, decimal SaldoPostrior, bool SoloPendientes, string nombre, DateTime desde, DateTime hasta)
		{
			_comprobante = dcc.Comprobante;
			_cuota = dcc.Cuota;
			_debe = dcc.Debe;
			_fechaEmision = dcc.FechaEmision;
			_fechaVencimiento = dcc.FechaVencimiento;
			_haber = dcc.Haber;
			_idTipoDeComprobante = dcc.IdTipoDeComprobante;
			_importe = dcc.Importe;
			_numero = dcc.Numero;
			_pago = dcc.Pago;
			_saldo = dcc.Saldo;

			if(SoloPendientes)
				_saldoAcumulado = dcc.SaldoAcumuladoSoloPendientes;
			else
				_saldoAcumulado = dcc.SaldoAcumulado;
			_signo = dcc.Signo;
			_total = dcc.Total;
			_saldoAnterior = SaldoAnterior;
			_saldoPosterior = SaldoPostrior;
			_nombreClienteFilter = nombre;
			_fechaDesdeFilter = desde;
			_fechaHastaFilter = hasta;
		}

		public DetalleCuentaCorrienteView(ItemCuentaCorriente dcc, decimal SaldoAnterior, decimal SaldoPosterior, bool SoloPendientes, string nombre, DateTime desde, DateTime hasta)
		{
			_comprobante = dcc.Comprobante;

			_cuota = dcc.Cuota;			
			_debe = dcc.Debe;
			_fechaEmision = dcc.FechaEmision;
			_fechaVencimiento = dcc.FechaVencimiento;
			_haber = dcc.Haber;
			_idTipoDeComprobante = dcc.IdTipoDeComprobante;
			_importe = dcc.Importe;
			_numero = dcc.Numero;
			_pago = 0;//dcc.Pago;
			_saldo = dcc.Saldo;

			/*if(SoloPendientes)
				_saldoAcumulado = dcc.SaldoAcumuladoSoloPendientes;
			else*/
				_saldoAcumulado = dcc.SaldoAcumulado;
			_signo = Convert.ToInt32(dcc.SignoCtaCte);
			_total = dcc.Importe;
			_saldoAnterior = SaldoAnterior;
			_saldoPosterior = SaldoPosterior;
			_nombreClienteFilter = nombre;
			_fechaDesdeFilter = desde;
			_fechaHastaFilter = hasta;
            /* Silvina 20110718 - Tarea 0000164 */
            _observaciones = dcc.Observaciones;
            /* Fin Silvina 20110718 - Tarea 0000164 */
		}

		public DetalleCuentaCorrienteView(ItemCuentaCorriente dcc)
		{
			_comprobante = dcc.Comprobante;

			_cuota = dcc.Cuota;			
			_debe = dcc.Debe;
			_fechaEmision = dcc.FechaEmision;
			_fechaVencimiento = dcc.FechaVencimiento;
			_haber = dcc.Haber;
			_importe = dcc.Importe;
			_numero = dcc.Numero;
			_pago = 0;
			_saldo = dcc.Saldo;

			_saldoAcumulado = dcc.SaldoAcumulado;
			_signo = Convert.ToInt32(dcc.SignoCtaCte);
			_total = dcc.Importe;
            /* Silvina 20110718 - Tarea 0000164 */
            _observaciones = dcc.Observaciones;
            /* Fin Silvina 20110718 - Tarea 0000164 */

		}
		#endregion


		#region Variables privadas

		private string _comprobante = string.Empty;
		private string _numero = string.Empty;
		private DateTime _fechaEmision = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		private decimal _total = 0;
		private int _signo = 0;
		private int _cuota = 1;
		private decimal _importe = 0;
		private decimal _saldo = 0;
		private decimal _debe = 0;
		private decimal _haber =  0;
		private decimal _saldoAcumulado = 0;
		private decimal _pago = 0;
		private string _idTipoDeComprobante = string.Empty;
		private decimal _saldoAnterior = 0;
		private decimal _saldoPosterior = 0;
		private string _nombreClienteFilter = string.Empty;
		private DateTime _fechaDesdeFilter = DateTime.Now;
		private DateTime _fechaHastaFilter = DateTime.Now;

        /* Silvina 20110718 - Tarea 0000164 */
        private string _observaciones = string.Empty;
        /* Fin Silvina 20110718 - Tarea 0000164 */
		
		#endregion


		#region Variables publicas

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public string Nombre
		{
			get{return _nombreClienteFilter;}
		}
		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public DateTime Desde
		{
			get{return _fechaDesdeFilter;}
		}
		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public DateTime Hasta
		{
			get{return _fechaHastaFilter;}
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal SaldoAnterior
		{
			get{return _saldoAnterior;}
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal SaldoPosterior
		{
			get{return _saldoPosterior;}
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public int cuota
		{
			get{return _cuota;}
		
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public string IdTipoDeComprobante
		{
			get {return _idTipoDeComprobante;}
			
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public string Comprobante
		{
			get {return _comprobante;}
			
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public string Descripcion
		{
			get {return _comprobante;}
			
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public string Numero
		{
			get {return _numero;}
			
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public DateTime FechaEmision
		{
			get{return _fechaEmision;}
			

		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public DateTime FechaVencimiento
		{
			get {return _fechaVencimiento;}
			

		}
		
		
		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal MontoTotal
		{
			get {return _total;}
			

		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public int Signo
		{
			get{return _signo;}
			
		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal ImporteCuota 
		{
			get{return _importe;}
			

		}
	
		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal Saldo
		{
			get{return _saldo;}
			

		}

		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal SaldoAcumulado
		{
			get{return _saldoAcumulado;}
			

		}
		
		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal Debe
		{
			get {return _debe;}
			
			


		}


		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal Haber
		{
			get {return _haber;}
			
		}


		[DataTableConversionAttribute(DataTableConversion = true, KeyField = false, 
			 AllowDbNull = false)]
		public decimal Pago
		{
			get{return _pago;}
			
		}

        /* Silvina 20110718 - Tarea 0000164 */
        [DataTableConversionAttribute(DataTableConversion = true, KeyField = false,
            AllowDbNull = false)]
        public string Observaciones
        {
            get { return _observaciones; }

        }
        /* Fin Silvina 20110718 - Tarea 0000164 */

		#endregion
	}

}
