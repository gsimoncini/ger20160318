using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;



namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ImputarPagoCuentaCorriente.
	/// </summary>
	public class ImputarPagoCuentaCorriente
	{
		
		#region Contructores
		public ImputarPagoCuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ImputarPagoCuentaCorriente(string Origen, string IdCuenta)
		{
			_origen = Origen;
			_idCuenta = IdCuenta;
		}

		public ImputarPagoCuentaCorriente(string Origen, string IdCuenta, CuentaCorriente CtaCte)
		{
			_origen = Origen;
			_idCuenta = IdCuenta;
			_ctaCte = CtaCte;
		}
		#endregion
        
		#region Variables Privadas
		private string _origen = string.Empty;
		private string _idCuenta = string.Empty;
//		private ItemCuentaCorriente _itemCuentaCorriente;
		private CuentaCorriente _ctaCte;
		
		private tsa_ComprobantesDataset _dataTsa_Comprobantes;
		private tpu_ComprobantesDataset _dataTpu_Comprobantes;

		private tsa_AplicacionPagosDataset _tsa_AplicacionPagosDataSet = new tsa_AplicacionPagosDataset();
		private tpu_AplicacionPagosDataset _tpu_AplicacionPagosDataSet = new tpu_AplicacionPagosDataset();
		
		private tsa_ComprobanteDetalleDeudaDataset _tsa_ComprobanteDetalleDeudaDataSet = new tsa_ComprobanteDetalleDeudaDataset();
		private tpu_ComprobanteDetalleDeudaDataset _tpu_ComprobanteDetalleDeudaDataSet = new tpu_ComprobanteDetalleDeudaDataset();

		#endregion

		#region Metodos Publicos		
		public string GetType()
		{
			if (_origen.Equals("CLIENTES"))
				return "mz.erp.ui.forms.classes.tsa_Cuentas";
			else
				return "mz.erp.ui.forms.classes.tpu_Proveedores";
		}		

		public string GetTypeClass()
		{
			if (_origen.Equals("CLIENTES"))
				return "mz.erp.ui.forms.classes.tsa_CuentaCorriente()";
			else
				return "mz.erp.ui.forms.classes.tpu_Proveedores()";
		}
		
		public string GetByPk()
		{
			if (_origen.Equals("CLIENTES"))
				return mz.erp.businessrules.tsa_Cuentas.GetByPk(_idCuenta).Codigo;
			else
				return mz.erp.businessrules.tpu_Proveedores.GetByPk(_idCuenta).IdProveedor;
		}

		public mz.erp.businessrules.comprobantes.CuentaCorriente GetCuentaCorriente(string IdCuenta, DateTime desde, DateTime hasta, string orderBy)
		{
			mz.erp.businessrules.comprobantes.CuentaCorriente ctaCte = new mz.erp.businessrules.comprobantes.CuentaCorriente();
			ctaCte.IdCuenta= IdCuenta;
			ctaCte.FechaDesde= desde;
			ctaCte.FechaHasta= hasta;
			ctaCte.SaldoAnterior = 0;
			ctaCte.Detalle = new ArrayList();
			ctaCte.SaldoPosterior=0;
			ctaCte.TotalImputado = 0;
			ctaCte.OrderBy = orderBy;
			if ( this._origen.Equals("CLIENTES") )
                ctaCte.Cuenta = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta).Nombre;
			else 
				ctaCte.Cuenta = mz.erp.businessrules.tpu_Proveedores.GetByPk(IdCuenta).Nombre;
			return ctaCte;
		}
		#endregion
				
		#region Miembros de IPersistentTask?
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		
		public void Commit()
		{
			if ( this._origen.Equals("CLIENTES") )
			{
				bool masNegativos = _ctaCte.CantPagosNegativos >= _ctaCte.CantPagosPositivos;
				ArrayList negativos = _ctaCte.GetDetallePagos(-1);
				ArrayList positivos = _ctaCte.GetDetallePagos(1);
				ItemCuentaCorriente iccSingle = null;
				if(masNegativos)
				{	
					#region Inserta Comporbantes con Signo Negativo
					iccSingle = (ItemCuentaCorriente) positivos[0];
					
					#region para q sirve?
					// Para que sirve????
					/*if ( this._origen.Equals("CLIENTES") )				
					{
						tsa_ComprobantesDataset.tsa_ComprobantesRow rowComp = mz.erp.dataaccess.tsa_Comprobantes.GetByPk(iccSingle.IdComprobante);
						if (rowComp == null)
							rowComp = mz.erp.businessrules.tsa_Comprobantes.GetByPk(iccSingle.IdComprobante);
						_dataTsa_Comprobantes.tsa_Comprobantes.ImportRow(rowComp);					
					}
					else
					{
						tpu_ComprobantesDataset.tpu_ComprobantesRow rowComp = mz.erp.dataaccess.tpu_Comprobantes.GetByPk(iccSingle.IdComprobante);
						if (rowComp == null)
							rowComp = mz.erp.businessrules.tpu_Comprobantes.GetByPk(iccSingle.IdComprobante);
						_dataTpu_Comprobantes.tpu_Comprobantes.ImportRow(rowComp);	
					}
					// ----------------
					*/
					#endregion

					// iccSingle --> Recibos...
					// icc --> Fact, Prefacturas.... 
					foreach(ItemCuentaCorriente icc in negativos )
					{
						tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row = _tsa_AplicacionPagosDataSet.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
						row.IdComprobanteOrigen = icc.IdComprobante; 
						row.CuotaOrigen = (short) icc.Cuota; 
						row.IdComprobanteDestino = iccSingle.IdComprobante; 
						row.IdTipoComprobanteOrigen = icc.IdTipoDeComprobante;
						row.Importe = icc.Pago;
						row.IdTipoDeComprobanteDestino = iccSingle.IdTipoDeComprobante;
						row.CuotaDestino = 1;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.IdReservado = 0;
						row.RowId = Guid.Empty;	
						_tsa_AplicacionPagosDataSet.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);
						
						#region borrar! si funciona lo de abajo
						/*
						//tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda = mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(dcc.IdComprobante, Convert.ToInt16(dcc.Cuota));
						
						if (  rowDeuda == null)
							rowDeuda = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));

						int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk(Convert.ToString(rowDeuda.IdTipoDeComprobante)).signo);
						rowDeuda.Saldo = (decimal) rowDeuda.Saldo * signo;
						rowDeuda.Saldo = (decimal) rowDeuda.Saldo - icc.Pago;
						rowDeuda.Saldo = (decimal) rowDeuda.Saldo * signo;

                        _tsa_ComprobanteDetalleDeuda.tsa_ComprobantesDetalleDeuda.ImportRow(rowDeuda);
						*/
						#endregion

						try
						{
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda = _tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda["IdTipoDeComprobante"]).signo);
							rowDeuda["saldo"] = (decimal) rowDeuda["saldo"] * signo;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] - icc.Pago;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] * signo;

						}
						catch(Exception e) 
						{
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							if( rowDeuda2 != null )
							{
								int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda2["IdTipoDeComprobante"]).signo);
								rowDeuda2["saldo"] = (decimal )rowDeuda2["saldo"] * signo;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] - icc.Pago;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] * signo;
								_tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.ImportRow(rowDeuda2);
							}
						}
						
						//System.Data.DataRow rowComprobanteImputado = data.tsa_Comprobantes.FindByIdComprobante(dcc.IdComprobante);
						//if (rowComprobanteImputado == null)
						//	rowComprobanteImputado = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dcc.IdComprobante);
						//data.tsa_Comprobantes.ImportRow(rowComprobanteImputado);	
					}

					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeudaSingle = mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));
					if (  rowDeudaSingle == null)
						rowDeudaSingle = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));

					int signoSingle = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk(Convert.ToString(rowDeudaSingle.IdTipoDeComprobante)).signo);
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo - iccSingle.Pago;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					_tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.ImportRow(rowDeudaSingle);

					#endregion
				}
				else
				{
					#region Inserta Comporbantes con Signo Positivos
					iccSingle = (ItemCuentaCorriente) negativos[0];
					
					// icc --> Recibos, Notas de creditos, RET
					foreach(ItemCuentaCorriente icc in positivos )
					{
						tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row = _tsa_AplicacionPagosDataSet.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
						row.IdComprobanteOrigen = iccSingle.IdComprobante; 
						row.CuotaOrigen = 1;//(short) icc.Cuota; 
						row.IdComprobanteDestino = icc.IdComprobante; 
						row.IdTipoComprobanteOrigen = iccSingle.IdTipoDeComprobante;
						row.Importe = icc.Pago;
						row.IdTipoDeComprobanteDestino = icc.IdTipoDeComprobante;
						row.CuotaDestino = (short)icc.Cuota;//1;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.IdReservado = 0;
						row.RowId = Guid.Empty;	
						_tsa_AplicacionPagosDataSet.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);
						
						try
						{
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda = _tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda["IdTipoDeComprobante"]).signo);
							rowDeuda["saldo"] = (decimal )rowDeuda["saldo"] * signo;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] - icc.Pago;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] * signo;

						}
						catch(Exception e) 
						{
							tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeuda2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							if( rowDeuda2 != null )
							{
								int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda2["IdTipoDeComprobante"]).signo);
								rowDeuda2["saldo"] = (decimal )rowDeuda2["saldo"] * signo;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] - icc.Pago;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] * signo;
								_tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.ImportRow(rowDeuda2);
							}
						}
					}

					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow rowDeudaSingle = mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));
					if (  rowDeudaSingle == null)
						rowDeudaSingle = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));

					int signoSingle = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk(Convert.ToString(rowDeudaSingle.IdTipoDeComprobante)).signo);
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo - iccSingle.Pago;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					_tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda.ImportRow(rowDeudaSingle);

					#endregion

				}
				
			}
			else // "PROVEEDORES"
			{
				bool masNegativos = _ctaCte.CantPagosNegativos >= _ctaCte.CantPagosPositivos;
				ArrayList negativos = _ctaCte.GetDetallePagos(-1);
				ArrayList positivos = _ctaCte.GetDetallePagos(1);
				ItemCuentaCorriente iccSingle = null;
				if(masNegativos)
				{	
					#region Inserta Comporbantes con Signo Negativo
					iccSingle = (ItemCuentaCorriente) positivos[0];
					
					// icc Negativos --> Pagos y notas de ??
					foreach(ItemCuentaCorriente icc in negativos )
					{
						// iccSingle --> FACT de Proveedores
						tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row = _tpu_AplicacionPagosDataSet.tpu_AplicacionPagos.Newtpu_AplicacionPagosRow();
						row.IdComprobanteOrigen = icc.IdComprobante; 
						row.CuotaOrigen = 1; //(short) icc.Cuota; 
						row.IdComprobanteDestino = iccSingle.IdComprobante; 
						row.IdTipoComprobanteOrigen = icc.IdTipoDeComprobante;
						row.Importe = icc.Pago;
						row.IdTipoDeComprobanteDestino = iccSingle.IdTipoDeComprobante;
						row.CuotaDestino = (short) icc.Cuota;;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.IdReservado = 0;
						row.RowId = Guid.Empty;	
						_tpu_AplicacionPagosDataSet.tpu_AplicacionPagos.Addtpu_AplicacionPagosRow(row);
						
						try
						{
							tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeuda = _tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda["IdTipoDeComprobante"]).signo);
							rowDeuda["saldo"] = (decimal) rowDeuda["saldo"] * signo;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] - icc.Pago;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] * signo;
							rowDeuda["SaldoTemporal"] = (decimal) rowDeuda["SaldoTemporal"] * signo;
							rowDeuda["SaldoTemporal"] = (decimal) rowDeuda["SaldoTemporal"] - icc.Pago;
							rowDeuda["SaldoTemporal"] = (decimal) rowDeuda["SaldoTemporal"] * signo;

						}
						catch(Exception e) 
						{
							tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeuda2 = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							if( rowDeuda2 != null )
							{
								int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda2["IdTipoDeComprobante"]).signo);
								rowDeuda2["saldo"] = (decimal )rowDeuda2["saldo"] * signo;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] - icc.Pago;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] * signo;
								rowDeuda2["SaldoTemporal"] = (decimal) rowDeuda2["SaldoTemporal"] * signo;
								rowDeuda2["SaldoTemporal"] = (decimal) rowDeuda2["SaldoTemporal"] - icc.Pago;
								rowDeuda2["SaldoTemporal"] = (decimal) rowDeuda2["SaldoTemporal"] * signo;
								_tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.ImportRow(rowDeuda2);
							}
						}
					}

					tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeudaSingle = mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));
					if (  rowDeudaSingle == null)
						rowDeudaSingle = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));

					int signoSingle = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk(Convert.ToString(rowDeudaSingle.IdTipoDeComprobante)).signo);
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo - iccSingle.Pago;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal * signoSingle;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal - iccSingle.Pago;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal * signoSingle;

					_tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.ImportRow(rowDeudaSingle);

					#endregion
				}
				else
				{
					#region Inserta Comporbantes con Signo Positivos
					iccSingle = (ItemCuentaCorriente) negativos[0];
					
					// icc --> FACT de Proveedores; Notas de ??
					foreach(ItemCuentaCorriente icc in positivos )
					{
						// iccSingle --> Pagos a Proveedores
						tpu_AplicacionPagosDataset.tpu_AplicacionPagosRow row = _tpu_AplicacionPagosDataSet.tpu_AplicacionPagos.Newtpu_AplicacionPagosRow();
						row.IdComprobanteOrigen = iccSingle.IdComprobante; 
						row.CuotaOrigen = 1;
						row.IdComprobanteDestino = icc.IdComprobante; 
						row.IdTipoComprobanteOrigen = iccSingle.IdTipoDeComprobante;
						row.Importe = icc.Pago;
						row.IdTipoDeComprobanteDestino = icc.IdTipoDeComprobante;
						row.CuotaDestino = (short)icc.Cuota;
						row.IdEmpresa = Security.IdEmpresa;
						row.IdSucursal = Security.IdSucursal;
						row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
						row.IdConexionCreacion = Security.IdConexion;
						row.IdConexionUltimaModificacion = Security.IdConexion;
						row.IdReservado = 0;
						row.RowId = Guid.Empty;	
						_tpu_AplicacionPagosDataSet.tpu_AplicacionPagos.Addtpu_AplicacionPagosRow(row);
						
						try
						{
							tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeuda = _tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda["IdTipoDeComprobante"]).signo);
							rowDeuda["saldo"] = (decimal )rowDeuda["saldo"] * signo;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] - icc.Pago;
							rowDeuda["Saldo"] = (decimal) rowDeuda["Saldo"] * signo;
							rowDeuda["saldoTemporal"] = (decimal )rowDeuda["saldoTemporal"] * signo;
							rowDeuda["saldoTemporal"] = (decimal) rowDeuda["saldoTemporal"] - icc.Pago;
							rowDeuda["saldoTemporal"] = (decimal) rowDeuda["saldoTemporal"] * signo;
						}
						catch(Exception e) 
						{
							tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeuda2 = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(icc.IdComprobante, Convert.ToInt16(icc.Cuota));
							if( rowDeuda2 != null )
							{
								int signo = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) rowDeuda2["IdTipoDeComprobante"]).signo);
								rowDeuda2["saldo"] = (decimal )rowDeuda2["saldo"] * signo;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] - icc.Pago;
								rowDeuda2["Saldo"] = (decimal) rowDeuda2["Saldo"] * signo;
								rowDeuda2["saldoTemporal"] = (decimal )rowDeuda2["saldoTemporal"] * signo;
								rowDeuda2["saldoTemporal"] = (decimal) rowDeuda2["saldoTemporal"] - icc.Pago;
								rowDeuda2["saldoTemporal"] = (decimal) rowDeuda2["saldoTemporal"] * signo;
								_tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.ImportRow(rowDeuda2);
							}
						}
					}

					tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow rowDeudaSingle = mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));
					if (  rowDeudaSingle == null)
						rowDeudaSingle = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetByPk(iccSingle.IdComprobante, Convert.ToInt16(iccSingle.Cuota));

					int signoSingle = Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk(Convert.ToString(rowDeudaSingle.IdTipoDeComprobante)).signo);
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo - iccSingle.Pago;
					rowDeudaSingle.Saldo = (decimal) rowDeudaSingle.Saldo * signoSingle;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal * signoSingle;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal - iccSingle.Pago;
					rowDeudaSingle.SaldoTemporal = (decimal) rowDeudaSingle.SaldoTemporal * signoSingle;
					_tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda.ImportRow(rowDeudaSingle);

					#endregion
				}				
			}
		}

		public bool Flush()
		{
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			
			try
			{
				this.Flush(IdTransaction);
				dataaccess.PoolTransaction.Commit(IdTransaction);
				return true;
			}
			catch(Exception e)
			{
				dataaccess.PoolTransaction.RollBack(IdTransaction);
				return  false;

			}

		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			
			_replication = GenerateReplication();

			if ( this._origen.Equals("CLIENTES") )
			{
				mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( _tsa_ComprobanteDetalleDeudaDataSet.tsa_ComprobanteDetalleDeuda, IdTransaction );
				mz.erp.dataaccess.tsa_AplicacionPagos.Update( _tsa_AplicacionPagosDataSet.tsa_AplicacionPagos, IdTransaction );
			}
			else
			{
				mz.erp.dataaccess.tpu_ComprobanteDetalleDeuda.Update( _tpu_ComprobanteDetalleDeudaDataSet.tpu_ComprobanteDetalleDeuda, IdTransaction );
				mz.erp.dataaccess.tpu_AplicacionPagos.Update( _tpu_AplicacionPagosDataSet.tpu_AplicacionPagos, IdTransaction );
			}

			/*
			if(AllowSave() || _precomprobantesDePago.Count > 0 )
			{
				string IdVariable;
				tsa_ComprobantesExDataset dataEx = this.DatasetComprobante ;
				if (this.ActualizaNumeracion) 
				{
					IdVariable = UpdateNumero(dataEx, IdTransaction);
				}
				else 
				{
					IdVariable = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
				}
				_replication = GenerateReplication();
				BuildExtraDataSets();
				mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDePago(dataEx, IdVariable,_numero,  _replication, IdTransaction,_desimpuatcionDetalleDeudaDataSets,_desimputacionAplicacionPagoDataSets,_cancelacionesDePagoDataSets);

			}*/
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this, new EventArgs());
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
			replication.NombreTabla = "dataaccess.tpu_Comprobantes";
			return replication;
		}

		
		#endregion

		#region Propiedades
		public string IdCuenta
		{
			get { return _idCuenta; }
		}

		public tsa_AplicacionPagosDataset Tsa_AplicacionPagosDataSet 
		{
			get {return _tsa_AplicacionPagosDataSet;}
		}

		public tsa_ComprobanteDetalleDeudaDataset  Tsa_ComprobanteDetalleDeudaDataset
		{
			get {return _tsa_ComprobanteDetalleDeudaDataSet;}
		}

		public tpu_AplicacionPagosDataset  Tpu_AplicacionPagosDataSet 
		{
			get {return _tpu_AplicacionPagosDataSet;}
		}
		
		public tpu_ComprobanteDetalleDeudaDataset  Tpu_ComprobanteDetalleDeudaDataset
		{
			get {return _tpu_ComprobanteDetalleDeudaDataSet;}
		}

		public string Origen
		{
			get {return _origen;}
		}
		#endregion


	}
}

