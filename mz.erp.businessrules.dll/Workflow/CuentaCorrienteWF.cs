using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CuentaCorrienteWF.
	/// </summary>
	public class CuentaCorrienteWF
	{
		#region Variables privadas
		private DataSet _data;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private bool _ordenDebeHaber = false;
		private string _listaComprobantesFacturas = "";
		private string _listaComprobantesNotasDeCredito = "";
		private string _listaComprobantesRecibos = "";
		private long _tipoCtaCte = long.MinValue;		

		private tsa_AplicacionPagosDataset _data_tsa_AplicacionPagos = new tsa_AplicacionPagosDataset();
		private tsa_ComprobanteDetalleDeudaDataset _data_tsa_ComprobanteDetalleDeuda = new tsa_ComprobanteDetalleDeudaDataset();

		private tpu_AplicacionPagosDataset _data_tpu_AplicacionPagos = new tpu_AplicacionPagosDataset();
		private tpu_ComprobanteDetalleDeudaDataset _data_tpu_ComprobanteDetalleDeuda = new tpu_ComprobanteDetalleDeudaDataset();


      



		#endregion
		public CuentaCorrienteWF()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			//Init();
		}
		#region Propiedades

		/*private string _entidad = null;
		public string Entidad
		{
			get {return _entidad ;}
			set 
			{				
				_entidad = value;				
			}
		}*/

		/*private string _idAnterior = null;		
		private string _id = null;		
		public string Id
		{
			get {return _id ;}
			set 
			{
				_idAnterior = _id;
				_id = value;				
			}
		}*/

		private string _nombreEntidad = string.Empty;

		public string NombreEntidad
		{
			get{return _nombreEntidad;}
		}

		private string _codigoAnterior = null;
		private string _codigo = null;
		public string Codigo 
		{
			get 
			{
				return _codigo;
			}
			set  
			{
				if (_codigo != value)
				{
					_codigoAnterior = _codigo;								
					_codigo = value;
					if(_codigo != null && _codigo != string.Empty)
					{
						switch(_processName)
						{
							case "ProcesoCuentaCorrienteCliente":
							{									
								Cuenta cuenta = new Cuenta();
								cuenta.GetCuenta_CodigoCuenta(_codigo);
								_nombreEntidad = cuenta.Nombre;
								break;
							}
							case "ProcesoCuentaCorrienteClienteDV":
							{									
								Cuenta cuenta = new Cuenta();
								cuenta.GetCuenta_CodigoCuenta(_codigo);
								_nombreEntidad = cuenta.Nombre;
								break;
							}
							case "ProcesoCuentaCorrienteClienteConsolidada":
							{									
								Cuenta cuenta = new Cuenta();
								cuenta.GetCuenta_CodigoCuenta(_codigo);
								_nombreEntidad = cuenta.Nombre;
								break;
							}
							case "ProcesoCuentaCorrienteProveedor":
							{															
								Proveedor prov = new Proveedor();
								prov.GetCuenta_CodigoProveedor(_codigo);
								_nombreEntidad = prov.Nombre;
								break;
							}
							case "ProcesoCuentaCorrienteProveedorDV":
							{															
								Proveedor prov = new Proveedor();
								prov.GetCuenta_CodigoProveedor(_codigo);
								_nombreEntidad = prov.Nombre;
								break;
							}
							case "ProcesoCuentaCorrienteProveedoresConsolidada":
							{															
								Proveedor prov = new Proveedor();
								prov.GetCuenta_CodigoProveedor(_codigo);
								_nombreEntidad = prov.Nombre;
								break;
							}

						}	
					}
				}
			}
		}
		private DateTime _fechaDesdeAnterior;
		private DateTime _fechaDesde;
		public DateTime FechaDesde
		{
			get {return _fechaDesde;}
			set 
			{
				_fechaDesdeAnterior = _fechaDesde;
				_fechaDesde = value;
			}
		}
		private DateTime _fechaHastaAnterior;
		private DateTime _fechaHasta;
		public DateTime FechaHasta
		{
			get {return _fechaHasta;}
			set 
			{
				_fechaHastaAnterior = _fechaHasta;
				_fechaHasta = value;
			}
		}
		private bool _soloPendientes = false;
		public bool SoloPendientes
		{
			get {return _soloPendientes ;}
			set {_soloPendientes = value;}
		}

        //German 20120416 - Tarea 0000247
        private bool _soloAcopios = false;
        public bool SoloAcopios
        {
            get { return _soloAcopios; }
            set { _soloAcopios = value; }
        }
        //German 20120416 - Tarea 0000247
		private string _comprobantes = null;
		public string Comprobantes
		{
			get {return _comprobantes ;}
			set {_comprobantes = value;}
		}
		private string _orderBy = null;
		public string OrderBy
		{
			get {return _orderBy ;}
			set {_orderBy = value;}
		}
		private string _filterByAnterior = null;
		private string _filterBy = null;
		public string FilterBy
		{
			get {return _filterBy ;}
			set 
			{
				_filterByAnterior = _filterBy;
				_filterBy = value;
			}
			
		}
		private bool _getDataFromDB;
		public bool GetDataFromDB
		{
			get {return _getDataFromDB; }
			set {_getDataFromDB = value; }
		}
		private ArrayList _result = new ArrayList();
		public ArrayList Result
		{
			get { return _result ; }
		}

        //German 20120222 -  Tarea 0000247
        private decimal _saldoRemitosSinFacturar;
        public decimal SaldoRemitosSinFacturar
        {
            get { return _saldoRemitosSinFacturar; }
        }
        private decimal _saldoAcopios;
        public decimal SaldoAcopios
        {
            get { return _saldoAcopios; }
        }

        
        private bool _actualizaPrecios = false;
        public bool ActualizaPrecios
        {
            get { return _actualizaPrecios; }

        }
        private bool _visualizaSaldoRemitos = false;
        public bool VisualizaSaldoRemitos
        {
            get { return _visualizaSaldoRemitos; }

        }
        private bool _visualizaSaldoAcopios = false;

        public bool VisualizaSaldoAcopios
        {
            get { return _visualizaSaldoAcopios; }

        }
        //Fin German 20120222 -  Tarea 0000247
        private string _listaComprobantesAcopios;

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

		private string _processName;
		public string ProcessName
		{
			get {return _processName;}
			set {_processName = value;}
		}
		private string _taskName;
		public string TaskName
		{
			get {return _taskName;}
			set {_taskName = value;}
		}			

		private string _filtroFechaDefault = "";
		public string FiltroFechaDefault
		{
			get {return _filtroFechaDefault;}
		}
		private string _filtroComprobantesDefault = "";
		public string FiltroComprobantesDefault
		{
			get {return _filtroComprobantesDefault;}
		}	
		private string _ordenacionDefault = "";
		public string OrdenacionDefault
		{
			get {return _ordenacionDefault;}
		}	
			
		private string _colorPositivo = "";
		public string ColorPositivo
		{
			get {return _colorPositivo;}
		}	
		private string _colorNegativo = "";
		public string ColorNegativo
		{
			get {return _colorNegativo;}
		}	

		/*private string _textoBotonAnterior = "Anterior";
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
*/
		private string _leyendaFormulario = "Cuenta corriente";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + _processName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
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

		string _idCuenta;
		public string IdCuenta
		{
			get {return _idCuenta;}
		}

		public CuentaCorriente CuentaCorriente
		{
			get {return cc;}
		}
		
		#endregion

		businessrules.CuentaCorriente cc = new CuentaCorriente();
		
		public bool DesimputarCliente(ItemCuentaCorriente icc)		
		{
			_data_tsa_AplicacionPagos.Clear();
			_data_tsa_ComprobanteDetalleDeuda.Clear();
			
			decimal pago = 0;
			if(icc.Signo == 1)
			{
				// Es un recibo o una nota de credito, por ende hay que buscarlo por el campo IdComporbanteDestino
				// en la tabla tsa_AplicacionPagos
				_data_tsa_AplicacionPagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,icc.IdTipoDeComprobante,icc.IdComprobante,Convert.ToInt16(icc.Cuota));
				foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in _data_tsa_AplicacionPagos.tsa_AplicacionPagos.Rows)
				{
					bool getByPk = false;
					string IdComprobante = (string) row["IdComprobanteOrigen"];
					short cuota = (short) row["CuotaOrigen"];
					pago = pago + row.Importe;
					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet = _data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
					if (rowDet == null)
					{
						rowDet = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						getByPk = true;						
					}
					if (rowDet != null)
					{
						// tener emn cuenta el signo del saldo.
						rowDet.Saldo = rowDet.Saldo + (-1)*row.Importe;
						if ( getByPk )
							_data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDet);
						row.Delete();
					}
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle1 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante,(short)icc.Cuota);
				//Se multiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
				if(rowDetalle1 != null)
				{
					rowDetalle1.Saldo = rowDetalle1.Saldo + 1*pago; 
					_data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle1);
				}
			}
			else
			{
				// Es una factura o una nota de debito, por ende hay que buscarlo por el campo IdComporbanteOrigen
				// en la tabla tsa_AplicacionPagos			
				_data_tsa_AplicacionPagos = mz.erp.businessrules.tsa_AplicacionPagos.GetList(icc.IdComprobante,Convert.ToInt16(icc.Cuota),decimal.MinValue,null,null,short.MinValue);
				foreach(tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row in _data_tsa_AplicacionPagos.tsa_AplicacionPagos.Rows)
				{
					bool getByPk = false;
					string IdComprobante = (string) row["IdComprobanteDestino"];
					short cuota = (short) row["CuotaDestino"];		
					pago = pago + row.Importe;
					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDet = _data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
					if (rowDet == null)
					{
						rowDet = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						getByPk = true;
					}
					if (rowDet != null)
					{
						// tener en cuenta el signo del saldo.
						rowDet.Saldo = rowDet.Saldo + (+1)*row.Importe;
                        if (getByPk)
							_data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDet);
						row.Delete();
					}
				}
				tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDetalle2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante,(short)icc.Cuota);
				// Tener en cuenta el signo. Se multiplica por -1 pues this.Signo = -1 y pues el signo de saldo 
				// es negativo; Consolidacion de signos.
				if(rowDetalle2 != null)
				{
					rowDetalle2.Saldo = rowDetalle2.Saldo + (-1)*pago; 
					_data_tsa_ComprobanteDetalleDeuda.tsa_ComprobanteDetalleDeuda.ImportRow(rowDetalle2);
				}
			}
			// Chequeo que se haya eliminado alguna imputación
			return (pago > 0);
		}
		
		public bool DesimputarProveedor(ItemCuentaCorriente icc)		
		{
			_data_tpu_AplicacionPagos.Clear();
			_data_tpu_ComprobanteDetalleDeuda.Clear();
			
			decimal pago = 0;
			if(icc.Signo == 1)
			{
				// Es un factura de Proveedores o una (nota de ?? (credito o debito) )
				// por ende hay que buscarlo por el campo IdComporbanteDestino en la tabla tpu_AplicacionPagos
				_data_tpu_AplicacionPagos = mz.erp.businessrules.tpu_AplicacionPagos.GetList(null,short.MinValue,decimal.MinValue,icc.IdTipoDeComprobante,icc.IdComprobante,Convert.ToInt16(icc.Cuota));
				foreach(tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row in _data_tpu_AplicacionPagos.tpu_AplicacionPagos.Rows)
				{
					bool getByPk = false;
					string IdComprobante = (string) row["IdComprobanteOrigen"];
					short cuota = (short) row["CuotaOrigen"];
					pago = pago + row.Importe;
					tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDet = _data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
					if (rowDet == null)
					{
						rowDet = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						getByPk = true;
					}
					if (rowDet != null)
					{
						// tener en cuenta el signo del saldo.
						rowDet.Saldo = rowDet.Saldo + (-1)*row.Importe;
						rowDet.SaldoTemporal = rowDet.SaldoTemporal + (-1)*row.Importe;
						if (getByPk)
							_data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDet);
						row.Delete();
					}
				}
				tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle1 = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante,(short)icc.Cuota);
				//Se multiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
				if(rowDetalle1 != null)
				{
					rowDetalle1.Saldo = rowDetalle1.Saldo + 1*pago; 
					rowDetalle1.SaldoTemporal = rowDetalle1.SaldoTemporal + 1*pago; 
					_data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle1);
				}
			}
			else
			{
				// Es un pago a Proveedores (o una nota de ?? debito?)
				// Por ende hay que buscarlo por el campo IdComporbanteOrigen en la tabla tpu_AplicacionPagos.
				_data_tpu_AplicacionPagos = mz.erp.businessrules.tpu_AplicacionPagos.GetList(icc.IdComprobante,Convert.ToInt16(icc.Cuota),decimal.MinValue,null,null,short.MinValue);
				foreach(tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row in _data_tpu_AplicacionPagos.tpu_AplicacionPagos.Rows)
				{
					bool getByPk = false;
					string IdComprobante = (string) row["IdComprobanteDestino"];
					short cuota = (short) row["CuotaDestino"];
					pago = pago + row.Importe;
					tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDet = _data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(IdComprobante,cuota);
					if (rowDet == null)
					{
						rowDet = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(IdComprobante,cuota);
						getByPk = true;
					}
					if (rowDet != null)
					{
						// tener en cuenta el signo del saldo.
						rowDet.Saldo = rowDet.Saldo + (+1)*row.Importe;
						rowDet.SaldoTemporal = rowDet.SaldoTemporal + (+1)*row.Importe;
						if (getByPk)
							_data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDet);
						row.Delete();
					}
				}
				tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDetalle2 = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante,(short)icc.Cuota);
				// Se multiplica por 1 pues signo de saldo es positivo. Solo para consolidar los signos
				if(rowDetalle2 != null)
				{
					rowDetalle2.Saldo = rowDetalle2.Saldo + (-1)*pago; 
					rowDetalle2.SaldoTemporal = rowDetalle2.SaldoTemporal + (-1)*pago; 
					_data_tpu_ComprobanteDetalleDeuda.tpu_ComprobanteDetalleDeuda.ImportRow(rowDetalle2);
				}
			}
			// Chequeo que se haya eliminado alguna imputación
			return (pago > 0);
		}

		public void FlushDesimputarCliente(ItemCuentaCorriente icc)		
		{
            mz.erp.dataaccess.tsa_CuentaCorriente.Update(_data_tsa_AplicacionPagos, _data_tsa_ComprobanteDetalleDeuda);
		}
		
		public void FlushDesimputarProveedor(ItemCuentaCorriente icc)		
		{
            //mz.erp.dataaccess.tpu_CuentaCorriente.Update(_data_tpu_AplicacionPagos, _data_tpu_ComprobanteDetalleDeuda);
			mz.erp.dataaccess.tpu_AplicacionPagos.Update(_data_tpu_AplicacionPagos);
			mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update(_data_tpu_ComprobanteDetalleDeuda);
		}


		public void BuscarAhora()
		{			
			
			cc.OrdenDebeHaber = _ordenDebeHaber;			
			string Id = "";
			string Comprobantes = "";
			switch(_comprobantes)
			{
				case "Todos":
				{			
					Comprobantes = "Todos";
					break;
				}
				case "FA":
				{
					Comprobantes = _listaComprobantesFacturas;					
					break;
				}
				case "NC":
				{
					Comprobantes = _listaComprobantesNotasDeCredito;
					break;
				}
				case "RE":
				{
					Comprobantes = _listaComprobantesRecibos;
					break;
				}
			}	

			DateTime d = new DateTime(_fechaDesde.Year,_fechaDesde.Month,_fechaDesde.Day,0, 0, 0, 0);	
			DateTime h = new DateTime(_fechaHasta.Year,_fechaHasta.Month,_fechaHasta.Day,23,59,59, 0);
			_fechaDesde = d;
			_fechaHasta = h;

			if (_getDataFromDB || FilterChanged())										
			{					
				cc.Clear();
				//Va buscar el detalle de la cuenta corriente a la base
				DateTime FechaEmisionDesde = DateTime.MinValue;
				DateTime FechaEmisionHasta = DateTime.MinValue;
				DateTime FechaVencimientoDesde = DateTime.MinValue;
				DateTime FechaVencimientoHasta = DateTime.MinValue;	

				
				if (_filterBy == "FechaEmision")
				{					
					FechaEmisionDesde = _fechaDesde;
					FechaEmisionHasta = _fechaHasta;	
				}
				else
				{					
					FechaVencimientoDesde = _fechaDesde;
					FechaVencimientoHasta = _fechaHasta;
				}

				switch(_processName)
				{
					case "ProcesoCuentaCorrienteCliente":
					{									
						Cuenta cuenta = new Cuenta();
						cuenta.GetCuenta_CodigoCuenta(_codigo );
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, _tipoCtaCte);						
						_idCuenta = cuenta.IdCuenta;
						cc.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, _tipoCtaCte);
                                
                        //German 20120228 -  Tarea 0000247
                        if(_visualizaSaldoRemitos)
                            cc.GetRemitosSinFacturar(cuenta.IdCuenta, _actualizaPrecios);
                        if(_visualizaSaldoAcopios)
                            cc.GetAcopiosPendientes(cuenta.IdCuenta, _tipoCtaCte);
                        //Fin German 20120228 -  Tarea 0000247

						break;
					}
					case "ProcesoCuentaCorrienteClienteDV":
					{									
						Cuenta cuenta = new Cuenta();
						cuenta.GetCuenta_CodigoCuenta(_codigo);
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, _tipoCtaCte);						
						_idCuenta = cuenta.IdCuenta;
                        cc.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, _tipoCtaCte);

                        //German 20120228 -  Tarea 0000247
                        if (_visualizaSaldoRemitos)
                            cc.GetRemitosSinFacturar(cuenta.IdCuenta, _actualizaPrecios);
                        if (_visualizaSaldoAcopios)
                            cc.GetAcopiosPendientes(cuenta.IdCuenta, _tipoCtaCte);
                        //Fin German 20120228 -  Tarea 0000247


						break;
					}
					case "ProcesoCuentaCorrienteClienteConsolidada":
					{									
						Cuenta cuenta = new Cuenta();
						cuenta.GetCuenta_CodigoCuenta(_codigo);
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, _tipoCtaCte);						
						_idCuenta = cuenta.IdCuenta;
                        cc.GetDetalleCuentaCorrienteVentas(cuenta.IdCuenta, long.MinValue);

                        //German 20120228 -  Tarea 0000247
                        if (_visualizaSaldoRemitos)
                            cc.GetRemitosSinFacturar(cuenta.IdCuenta, _actualizaPrecios);
                        if (_visualizaSaldoAcopios)
                            cc.GetAcopiosPendientes(cuenta.IdCuenta, _tipoCtaCte);
                        //Fin German 20120228 -  Tarea 0000247


						break;
					}
					case "ProcesoCuentaCorrienteProveedor":
					{
						Proveedor proveedor = new Proveedor();
						proveedor.GetCuenta_CodigoProveedor(_codigo);						
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteCompras(_codigo, _tipoCtaCte);						
						//if(_codigo != null && !_codigo.Equals(string.Empty))
						_idCuenta = proveedor.IdProveedor;
						cc.GetDetalleCuentaCorrienteCompras(proveedor.IdProveedor, _tipoCtaCte);
						break;
					}
					case "ProcesoCuentaCorrienteProveedorDV":
					{
						Proveedor proveedor = new Proveedor();
						proveedor.GetCuenta_CodigoProveedor(_codigo);						
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteCompras(_codigo, _tipoCtaCte);						
						//if(_codigo != null && !_codigo.Equals(string.Empty))
						_idCuenta = proveedor.IdProveedor;
						cc.GetDetalleCuentaCorrienteCompras(proveedor.IdProveedor, _tipoCtaCte);
						break;
					}
					case "ProcesoCuentaCorrienteProveedoresConsolidada":
					{
						Proveedor proveedor = new Proveedor();
						proveedor.GetCuenta_CodigoProveedor(_codigo);						
						//_data = businessrules.tsa_CuentaCorriente.GetDetalleCuentaCorrienteCompras(_codigo, _tipoCtaCte);						
						//if(_codigo != null && !_codigo.Equals(string.Empty))
						_idCuenta = proveedor.IdProveedor;
						cc.GetDetalleCuentaCorrienteCompras(proveedor.IdProveedor, long.MinValue);
						break;
					}

				}	
				_codigoAnterior = _codigo;


				 
			}
				/*
			else
				cc.Clear();
				*/
			
			/*
			foreach(DataRow row in _data.Tables[0].Rows)
			{
				businessrules.ItemCuentaCorriente icc = new ItemCuentaCorriente();
				icc.IdComprobante = Convert.ToString(row["IdComprobante"]);
				icc.Comprobante = Convert.ToString(row["Comprobante"]);
				icc.IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				icc.Numero = Convert.ToString(row["Numero"]);
				icc.FechaEmision = Convert.ToDateTime(row["FechaEmision"]);
				icc.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);				
				icc.SignoCtaCte = Convert.ToInt64(row["SignoCtaCte"]);				
				icc.Importe = Convert.ToDecimal(row["ImporteCuota"]);
				icc.Saldo = Convert.ToDecimal(row["Saldo"]);
				icc.Cuota = Convert.ToString(row["Cuota"]);				
				cc.Add(icc);				
			}
			*/
			cc.OrderBy = _orderBy;			
			cc.SetOrder();			
			cc.SetAcumulados();
            //German 20120416 -  Tarea 0000247
			_result = cc.Result(_filterBy, _fechaDesde, _fechaHasta, _soloPendientes, Comprobantes, _soloAcopios, _listaComprobantesAcopios);
            //Fin German 20120416 -  Tarea 0000247
			_saldoAnterior = cc.SaldoAnterior;
			_saldoPosterior = cc.SaldoPosterior;
            //German 20120222 -  Tarea 0000247
            _saldoRemitosSinFacturar = cc.SaldoRemitosSinFacturar;
            _saldoAcopios = cc.SaldoAcopios;
                 
            //Fin German 20120222 -  Tarea 0000247
			
			if (DataSearchChanged != null)
			{
				DataSearchChanged( this, new System.EventArgs() );
			}
		}

		private bool FilterChanged()
		{			
			bool result = _codigo != _codigoAnterior ||
					_fechaDesde != _fechaDesdeAnterior || 
					_fechaHasta != _fechaHastaAnterior;				
					//_filterBy != _filterByAnterior;
			return result;
		}
/*
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
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}
*/
		public void Init()
		{			
			_taskName = "CuentaCorriente";

			//decimal cantDiasDesde = Convert.ToDecimal(Variables.GetValueString(_processName, _taskName, "DiasAnteriores"));
			decimal cantDiasDesde = (! Variables.GetValueDecimal(_processName, _taskName, "DiasAnteriores").Equals(Decimal.MinValue)) ? (Variables.GetValueDecimal(_processName, _taskName, "DiasAnteriores")) : 0;
			//decimal cantDiasHasta = Convert.ToDecimal(Variables.GetValueString(_processName, _taskName, "DiasPosteriores"));
			decimal cantDiasHasta = (! Variables.GetValueDecimal(_processName, _taskName, "DiasPosteriores").Equals(Decimal.MinValue)) ? (Variables.GetValueDecimal(_processName, _taskName, "DiasPosteriores")) : 0;
			
			_soloPendientes = Variables.GetValueBool(_processName, _taskName, "SoloPendientes");
			_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays((-1)* Convert.ToDouble(cantDiasDesde)); 
			_fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(Convert.ToDouble(cantDiasHasta));

			_ordenDebeHaber = Variables.GetValueBool(_processName, _taskName, "OrdenDebeHaber");
			_filtroFechaDefault = Variables.GetValueString(_processName, _taskName, "FiltroFechaDefault");
			_filtroComprobantesDefault = Variables.GetValueString(_processName, _taskName, "FiltroComprobantesDefault");
			_ordenacionDefault = Variables.GetValueString(_processName, _taskName, "OrdenacionDefault");

			_colorPositivo = Variables.GetValueString(_processName , _taskName, "Color.Positivo");
			_colorNegativo = Variables.GetValueString(_processName , _taskName, "Color.Negativo");						

			_listaComprobantesFacturas = Variables.GetValueString(_processName , _taskName, "ListaTiposDeComprobantes.Facturas");
			_listaComprobantesNotasDeCredito = Variables.GetValueString(_processName , _taskName, "ListaTiposDeComprobantes.NotasDeCredito");
			_listaComprobantesRecibos = Variables.GetValueString(_processName , _taskName, "ListaTiposDeComprobantes.Recibos");

			_tipoCtaCte = Variables.GetValueLong(_processName, _taskName, "TipoCtaCte");



            //German 20120228 -  Tarea 0000247
            _actualizaPrecios = Variables.GetValueBool("CuentaCorriente.SaldoRemitosSinFacturar.ActualizaPrecios"); ;
            _visualizaSaldoRemitos = Variables.GetValueBool("CuentaCorriente.MuestraSaldoRemitos"); 
            _visualizaSaldoAcopios = Variables.GetValueBool("CuentaCorriente.MuestraSaldoAcopios");
            _listaComprobantesAcopios = Variables.GetValueString(_processName, _taskName, "ListaTiposDeComprobantes.Acopios");
            //Fin German 20120228 -  Tarea 0000247


		}
/*
		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}*/

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			/*if (_id == "")
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Selección de proveedor","Debe seleccionar un proveedor."));
			}*/

			return IsValid;
		}
		/*public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}
*/
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

/*		public string GetWarnings()
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
*/
		public string GetTaskName()
		{
			return _taskName;
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(_processName , _taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE  
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
/*
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
*/
		#region Eventos
		public event EventHandler DataSearchChanged;	
		#endregion


	}
}
