using System;
using System.Collections;
using mz.erp.businessrules;
using System.Data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de CuentaCorriente.
	/// </summary>
	public class CuentaCorriente
	{
		
		
		#region Constructores
		public CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables privadas

		private string _idCuenta = string.Empty;
		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
		private decimal _saldoAnterior;
		private ArrayList _detalle;
		private decimal _saldoPosterior;

		private decimal _totalImputado=0;

               //German 20120125 - Tarea 0000256
            private decimal _saldoAImputar=0;
               //Fin German 20120125 - Tarea 0000256
        
		private string _cuenta;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		

		private decimal _totalPagoComprobantesSignoNegativo = 0;
		private decimal _totalPagoComprobantesSignoPositivo = 0;

		private string _orderBy = string.Empty;
	

		#endregion
		
		#region Eventos
		
		public event EventHandler TotalImputadoChanged;
        //German 20120125 - Tarea 0000256
        public event EventHandler SaldoAImputarChanged;
        //Fin German 20120125 - Tarea 0000256
		public event EventHandler TotalPagoComprobantesSignoPositivoChanged;
		public event EventHandler TotalPagoComprobantesSignoNegativoChanged;
		#endregion

		#region Propiedades Publicas


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

		public string OrderBy
		{
			get {return _orderBy;}
			set {_orderBy = value;}
		}
		public string IdCuenta
		{
			get {return _idCuenta;}
			set {_idCuenta = value;}
		}

		public string Cuenta
		{
			get {return _cuenta;}
			set {_cuenta = value;}
		}

		public DateTime FechaDesde
		{
			get {return _fechaDesde;}
			set {_fechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set {_fechaHasta = value;}
		}

		public decimal SaldoAnteriorSinSigno
		{
			get
			{
				return Math.Abs(_saldoAnterior);
			}
		}

		public decimal SaldoPosteriorSinSigno
		{
			get
			{
				return Math.Abs(_saldoPosterior);
			}
		}

		public decimal SaldoAnterior
		{
			get{return _saldoAnterior;}
			set{_saldoAnterior = value;}

		}

		public decimal SaldoPosterior
		{
			get{return _saldoPosterior;}
			set{_saldoPosterior = value;}

		}

		public ArrayList Detalle
		{
			get {return _detalle;}
			set {_detalle = value;}

		}

		public decimal TotalImputado
		{
			get { return _totalImputado;}
			set 
					{
				if(_totalImputado != value)
				{
					_totalImputado= value;
					if(TotalImputadoChanged != null)
						TotalImputadoChanged(this, new EventArgs());
				}
					
				}
			}



        //German 20120125 - Tarea 0000256

        public decimal SaldoAImputar
        {
            get {

                decimal saldo = 0;
                foreach (DetalleCuentaCorriente dcc in this.Detalle)
                {
                    saldo += Math.Abs(dcc.Saldo) - Math.Abs(dcc.Pago);
                }
                return saldo;
            
            }
			/*
            get 
			{
				if(_saldoAImputar != value)
				{
					_saldoAImputar= value;
					if(SaldoAImputarChanged != null)
						SaldoAImputarChanged(this, new EventArgs());
				
					
				}
			}
             * */
            
        }


        //Fin German 20120125 - Tarea 0000256


        public bool HasErrors
		{
			get
			{
				if (_errores.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public ItemsDatasetErrors Errores
		{
			get
			{
				return _errores;
			}
		}


		public int CantPagosNegativos
		{
			get
			{
				int cant = 0;
				foreach(DetalleCuentaCorriente det in this._detalle)
				{
					if(det.Signo == -1 && det.Pago != 0)
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
				foreach(DetalleCuentaCorriente det in this._detalle)
				{
					if(det.Signo == 1 && det.Pago != 0)
						cant++;
					
				}
				return cant;
			}


		}
		

		#endregion

		#region Metodos Publicos
		
		public decimal GetSaldoAnterior(string process)
		{	
			System.Data.DataSet data = tsa_CuentaCorriente.GetSaldoAnterior(this.IdCuenta, this.FechaDesde, this.Comprobantes(process));
			_saldoAnterior = Convert.ToDecimal(data.Tables[0].Rows[0]["Importe"].ToString());
			return _saldoAnterior;
		}
		
		public decimal GetSaldoPosterior(string process)
		{
			System.Data.DataSet data = tsa_CuentaCorriente.GetSaldoPosterior(this.IdCuenta, this.FechaHasta,this.Comprobantes(process));
			_saldoPosterior = Convert.ToDecimal(data.Tables[0].Rows[0]["Importe"].ToString());
			return _saldoPosterior;
		}

		
		public ArrayList GetDetalleCuentaCorriente(string process)
		{
			bool visualizaDetalle = Variables.GetValueBool("Momentos." + process + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + process + ".MetodoVisualizacionDetalle");
			bool VerHTML = false;
			if(visualizaDetalle && metodoVisualizacion.Equals("AUTOMATICO"))
				VerHTML = true;
			return GetDetalleCuentaCorriente(this.IdCuenta, this.FechaDesde, this.FechaHasta, this.OrderBy, this.Comprobantes(process), VerHTML);
		}
		
		public ArrayList GetDetalleCuentaCorriente(string IdCuenta, DateTime fechaDesde, DateTime fechaHasta, string OrderBy, string comprobantes, bool verHTML)
		{
			System.Data.DataSet data = tsa_CuentaCorriente.GetDetalleCuentaCorriente(IdCuenta, fechaDesde, fechaHasta, OrderBy, comprobantes, verHTML);
			System.Data.DataTable tabla = data.Tables[0];
			this.Detalle = new ArrayList();
			
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorriente(row);
				this.Detalle.Add(dcc);
			}
			return this.Detalle;
		}

		public CuentaCorriente ShallowClone()
		{
			return (CuentaCorriente)this.MemberwiseClone();
		}

		public void GetDetalleCuentaCorrienteSoloPendientes(string process)
		{		

			bool visualizaDetalle = Variables.GetValueBool("Momentos." + process + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + process + ".MetodoVisualizacionDetalle");
			bool VerHTML = false;
			if(visualizaDetalle && metodoVisualizacion.Equals("AUTOMATICO"))
				VerHTML = true;
			
			System.Data.DataSet data = tsa_CuentaCorriente.GetDetalleCuentaCorriente(this.IdCuenta, this.FechaDesde, this.FechaHasta, this.OrderBy, this.Comprobantes(process), VerHTML);
			System.Data.DataTable tabla = data.Tables[0];
			//System.Data.DataView view = new System.Data.DataView(tabla,"Saldo >0",null,System.Data.DataViewRowState.OriginalRows);
			//tabla = view.Table;
			decimal saldoAnteriorSoloPendientes = this.SaldoAnterior;
			this.Detalle = new ArrayList();
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				if(Convert.ToInt32(row["Saldo"]) != 0)
				{
					DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorriente(row);
					saldoAnteriorSoloPendientes= saldoAnteriorSoloPendientes - dcc.Saldo;
				
					dcc.SaldoAcumuladoSoloPendientes = saldoAnteriorSoloPendientes;
					this.Detalle.Add(dcc);
				}
			}
		}

		/*public void GetDetalleCuentaCorrienteGeneral(string process)
		{		
			System.Data.DataSet data = tsa_CuentaCorriente.GetDetalleCuentaCorrienteGeneral(this.FechaHasta, "FAA");			
			System.Data.DataTable tabla = data.Tables[0];
			this.Detalle = new ArrayList();
			
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorriente(row);
				this.Detalle.Add(dcc);
			}			
		}*/

		public void Add(DetalleCuentaCorriente detalleCtaCte)
		{
			detalleCtaCte.PagoChanged += new EventHandler(RecalcularTotalPago);
			this.Detalle.Add(detalleCtaCte);
		}

		

		//Este metodo se llama desde FrmAplicacionDePagos
		public void GetDetalleComprobantesAImputar(string process)
		{
			System.Data.DataSet data = tsa_CuentaCorriente.GetDetalleCuentaCorriente(this.IdCuenta, this.FechaDesde, this.FechaHasta, this.OrderBy, this.Comprobantes(process), false);
			if(data.Tables.Count > 0)
			{
				System.Data.DataTable tabla = data.Tables[0];
				
				string VarCompImputar = Variables.GetValueString(process,"Imputar","Comprobantes"); 
				ArrayList comprobantesImputar = mz.erp.systemframework.Util.Parse(VarCompImputar,",");
				string VarCompDeAnulacion = Variables.GetValueString(process,"Anular","ComprobantesDeAnulacion"); 
				ArrayList comprobantesDeAnulacion = mz.erp.systemframework.Util.Parse(VarCompDeAnulacion ,",");
				
				foreach(System.Data.DataRow row in tabla.Rows)
				{
					//Es una factura, prefactura, Nota de Debito y tienen saldo >0, osea que se pueden imputar
					if (((Convert.ToInt32(row["signo"])) == -1) && ((Convert.ToDecimal(row["Saldo"])) < 0) && !(comprobantesDeAnulacion.Contains( Convert.ToString(row["IdTipoDeComprobante"]))) && (comprobantesImputar.Contains( Convert.ToString(row["IdTipoDeComprobante"]))) )
					{
						DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorriente(row);
						dcc.PagoChanged += new EventHandler(RecalcularTotalPago);
						this.Detalle.Add(dcc);
					}
						//Es un recibo o nota de credito y tienen saldo > 0, osea que se pueden utilizar para aplicarlos
					else if(((Convert.ToInt32(row["signo"])) == 1) && ((Convert.ToDecimal(row["Saldo"]))> 0) && !(comprobantesDeAnulacion.Contains(Convert.ToString(row["IdTipoDeComprobante"]))) && (comprobantesImputar.Contains(Convert.ToString( row["IdTipoDeComprobante"]))))
					{
						DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorriente(row);
						dcc.PagoChanged += new EventHandler(RecalcularTotalPago);
						this.Detalle.Add(dcc);
					}
				}
			}

		}
		
		public void GetDetalleComprobantesAImputar(ArrayList comprobantesAImputar)
		{
			foreach(ItemCuentaCorriente item in comprobantesAImputar)
			{
				DetalleCuentaCorriente dcc = new DetalleCuentaCorriente(item);
                this.Detalle.Add(dcc);
			}		

		}

	
		/*Este metodo se llama desde el ComprobanteDePago*/
		public void GetDetalleComprobantesAImputar(string ProcessName, string TaskName)
		{
			string VarCompImputar = Variables.GetValueString(ProcessName, TaskName, "Imputar.Comprobantes");
			if(VarCompImputar != string.Empty)
			{
				System.Data.DataSet data = tsa_CuentaCorriente.GetDetalleCuentaCorriente(this.IdCuenta, this.FechaDesde, this.FechaHasta, VarCompImputar);
				if(data.Tables.Count > 0)
				{
					System.Data.DataTable tabla = data.Tables[0];
					//System.Data.DataView view = new System.Data.DataView(tabla,"signo = 1 And Saldo >0",null,System.Data.DataViewRowState.OriginalRows);
					//System.Data.DataTable tablaFiltrada = view.Table;

				
					ArrayList comprobantesImputar = mz.erp.systemframework.Util.Parse(VarCompImputar,",");
					
					string VarCompDeAnulacion = Variables.GetValueString(ProcessName,"Anular","ComprobantesDeAnulacion"); 
					ArrayList comprobantesDeAnulacion = mz.erp.systemframework.Util.Parse(VarCompDeAnulacion ,",");
				
					foreach(System.Data.DataRow row in tabla.Rows)
					{
						//Es una factura, prefactura, Nota de Debito y tienen saldo >0, osea que se pueden imputar
						if (((Convert.ToInt32(row["signo"])) == -1) && ((Convert.ToDecimal(row["Saldo"])) < 0) && !(comprobantesDeAnulacion.Contains( Convert.ToString(row["IdTipoDeComprobante"]))) && (comprobantesImputar.Contains( Convert.ToString(row["IdTipoDeComprobante"]))) )
						{
							DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorrienteDatosMinimos(row);
							dcc.PagoChanged += new EventHandler(RecalcularTotalPago);
							this.Detalle.Add(dcc);
						}
							//Es un recibo o nota de credito y tienen saldo > 0, osea que se pueden utilizar para aplicarlos
						else if(((Convert.ToInt32(row["signo"])) == 1) && ((Convert.ToDecimal(row["Saldo"]))> 0) && !(comprobantesDeAnulacion.Contains(Convert.ToString(row["IdTipoDeComprobante"]))) && (comprobantesImputar.Contains(Convert.ToString( row["IdTipoDeComprobante"]))))
						{
							DetalleCuentaCorriente dcc = this.GetDetalleCuentaCorrienteDatosMinimos(row);
							dcc.PagoChanged += new EventHandler(RecalcularTotalPago);
							this.Detalle.Add(dcc);
						}
					}
				}
			}

		}

		

		public bool IsValidCuenta
		{
			get 
			{
				if ((this.IdCuenta== null) || (this.IdCuenta == string.Empty))
					return false;
				else
					return true;
			}
		}
		
		public bool IsValid()
		{
			bool isvalid = true;
			_errores.Clear();
			if(!IsValidDetalleCuentaCorriente())
			{
				ItemDatasetError error = new ItemDatasetError("Cuenta Corriente","Imputaciones","No se puede imputar varios comprobantes al mismo tiempo");
				_errores.Add( error );
				isvalid = false;
			}
			return isvalid;
		}

		public ArrayList GetDetallePagos(int signo)
		{
			ArrayList result = new ArrayList();
			foreach(DetalleCuentaCorriente det in this._detalle)
			{
				if(det.Signo == signo && det.Pago != 0)
					result.Add(det);
			}
			return result;
		}


		public bool IsValidDetalleCuentaCorriente()
		{
			int cant = 0;
			int cantAux = 0 ;
			foreach(DetalleCuentaCorriente det in this._detalle)
			{
				if(det.Signo == -1 && det.Pago != 0)
					cant++;
				else
					if(det.Signo == 1 && det.Pago != 0)
					cantAux ++;
			}
			return (cant < 2 || cantAux < 2);
		}


		public void UpdatePago(DetalleCuentaCorriente Item)
		{
			Item.Pago = Math.Abs(Item.Saldo);				
		}

		#endregion

		#region Metodos Privados

		
		private DetalleCuentaCorriente GetDetalleCuentaCorriente(System.Data.DataRow row)
		{
			DetalleCuentaCorriente dcc = new DetalleCuentaCorriente(row);			
			return dcc;
		}

		private DetalleCuentaCorriente GetDetalleCuentaCorrienteDatosMinimos(System.Data.DataRow row)
		{
			DetalleCuentaCorriente dcc = new DetalleCuentaCorriente();			
			dcc.ExtractDatosMinimos(row);
			return dcc;
		}
		
		


		public void RecalcularTotalPago(object sender, EventArgs args)
		{
			this.RecalcularTotalPago();
		}

        //German 20120125 - Tarea 0000256
		public void RecalcularTotalPago()
		{
			this.TotalImputado=0;
            //this.SaldoAImputar= 0;
            //decimal saldo = 0;
			this._totalPagoComprobantesSignoNegativo = 0;
			this._totalPagoComprobantesSignoPositivo = 0;

            foreach (DetalleCuentaCorriente dcc in this.Detalle)
            {
                if (dcc.Signo == -1)
                {
                    this.TotalImputado = this.TotalImputado + dcc.Pago;
                    this.TotalPagoComprobantesSignoNegativo = this._totalPagoComprobantesSignoNegativo + dcc.Pago;
                }
                else
                    this.TotalPagoComprobantesSignoPositivo = this._totalPagoComprobantesSignoPositivo + dcc.Pago;
                //saldo += Math.Abs(dcc.Saldo);
            }
            //this.SaldoAImputar = saldo;
			
		}
        //German 20120125 - Tarea 0000256

		private string Comprobantes(string process)
		{
			string comprobanes = Variables.GetValueString("Momentos."+ process+ ".Comprobantes");
			return comprobanes;
		}
		
		#endregion
        
	}
}
