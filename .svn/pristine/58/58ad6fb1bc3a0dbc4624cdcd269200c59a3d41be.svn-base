using System;
using System.Data;
using System.Collections;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de AplicacionesDePagos.
	/// Clase que representa la apicacion de un comprobante de Pago a uno o mas comprobantes, generalmente,
	/// Comprobantes de Ventas. Se encarga de cargar las estructuras necesarias para que luego se gurden an la BD
	/// 
	/// </summary>
	public class AplicacionesDePagos:DataObject
	{
		public AplicacionesDePagos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		private ComprobanteDePago _parent;


		public ComprobanteDePago Parent
		{
			get{return _parent;}
			set{_parent = value;}
		}
		/// <summary>
		///Fuerza la escritura de los datos en memoria al dataset del comprobante para poder ser enviados a almacenar en el RDBM
		/// </summary>
		/// 

		public void CommitWF()
		{
			ComprobanteDePago cdp = this.Parent;
			tsa_ComprobantesExDataset data = cdp.DatasetComprobante;
			CuentaCorriente cc = this._parent.CuentaCorriente;
			bool masNegativos = cc.CantPagosNegativos >= cc.CantPagosPositivos;
			ArrayList negativos = cc.GetDetallePagos(-1);
			ArrayList positivos = cc.GetDetallePagos(1);
			DetalleCuentaCorriente dccSingle = null;
			if(masNegativos)
			{	
				#region Inserta Comporbantes con Signo Negativo
				dccSingle = (DetalleCuentaCorriente) positivos[0];
				DataRow rowComp = data.tsa_Comprobantes.FindByIdComprobante(dccSingle.IdComprobante);
				if (rowComp == null)
					rowComp = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dccSingle.IdComprobante);
				data.tsa_Comprobantes.ImportRow(rowComp);	
				foreach(DetalleCuentaCorriente dcc in negativos )
				{
					tsa_ComprobantesExDataset.tsa_AplicacionPagosRow row = data.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
					
					row.IdComprobanteOrigen =dcc.IdComprobante; 
					row.CuotaOrigen =(short)dcc.Cuota; 
					row.IdComprobanteDestino = dccSingle.IdComprobante; 
					row.IdTipoComprobanteOrigen = dcc.IdTipoDeComprobante;
					row.Importe = dcc.Pago;
					row.IdTipoDeComprobanteDestino = dccSingle.IdTipoDeComprobante;
					row.CuotaDestino = 1;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.RowId = Guid.Empty;	
					System.Data.DataRow rowComprobanteImputado = data.tsa_Comprobantes.FindByIdComprobante(dcc.IdComprobante);
					if (rowComprobanteImputado == null)
						rowComprobanteImputado = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dcc.IdComprobante);
					data.tsa_Comprobantes.ImportRow(rowComprobanteImputado);	
					data.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);
					try
					{
						System.Data.DataRow row1 = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(dcc.IdComprobante, Convert.ToInt16(dcc.Cuota));
						int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row1["IdTipoDeComprobante"]).signo);
						row1["saldo"] = (decimal )row1["saldo"] * signo;
						row1["Saldo"] =(decimal) row1["Saldo"] - dcc.Pago;
						row1["Saldo"] = (decimal) row1["Saldo"] * signo;

					}
					catch(Exception e) 
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(dcc.IdComprobante, Convert.ToInt16(dcc.Cuota));
						if(row2 != null)
						{
							int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row2["IdTipoDeComprobante"]).signo);
							row2["saldo"] = (decimal )row2["saldo"] * signo;
							row2["Saldo"] =(decimal) row2["Saldo"] - dcc.Pago;
							row2["Saldo"] = (decimal) row2["Saldo"] * signo;
							data.tsa_ComprobanteDetalleDeuda.ImportRow((System.Data.DataRow)row2);
						}
					}
					

						
					
				}
				try
				{
					System.Data.DataRow row3 = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(dccSingle.IdComprobante, Convert.ToInt16(dccSingle.Cuota));
					int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row3["IdTipoDeComprobante"]).signo);
					row3["saldo"] = (decimal )row3["saldo"] * signo;
					row3["Saldo"] =(decimal) row3["Saldo"] - dccSingle.Pago;
					row3["Saldo"] = (decimal) row3["Saldo"] * signo;

				}
				catch(Exception e) 
				{
					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row4 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(dccSingle.IdComprobante, Convert.ToInt16(dccSingle.Cuota));
					if(row4 != null)
					{
						int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row4["IdTipoDeComprobante"]).signo);
						row4["saldo"] = (decimal )row4["saldo"] * signo;
						row4["Saldo"] =(decimal) row4["Saldo"] - dccSingle.Pago;
						row4["Saldo"] = (decimal) row4["Saldo"] * signo;
						data.tsa_ComprobanteDetalleDeuda.ImportRow((System.Data.DataRow)row4);
					}
				}
				#endregion
			}
	
	
			else
			{
				#region Inserta Comporbantes con Signo Positivos
				dccSingle = (DetalleCuentaCorriente) negativos[0];
				DataRow rowComp = data.tsa_Comprobantes.FindByIdComprobante(dccSingle.IdComprobante);
				if (rowComp == null)
					rowComp = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dccSingle.IdComprobante);
				data.tsa_Comprobantes.ImportRow(rowComp);	
				foreach(DetalleCuentaCorriente dcc in positivos )
				{
					tsa_ComprobantesExDataset.tsa_AplicacionPagosRow row = data.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
					
					row.IdComprobanteOrigen = dccSingle.IdComprobante; 
					row.CuotaOrigen = 1; 
					row.IdComprobanteDestino = dcc.IdComprobante; 
					row.IdTipoComprobanteOrigen = dccSingle.IdTipoDeComprobante;
					row.Importe = dcc.Pago;
					row.IdTipoDeComprobanteDestino = dcc.IdTipoDeComprobante;
					row.CuotaDestino = (short)dcc.Cuota;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.RowId = Guid.Empty;	
					System.Data.DataRow rowComprobanteImputado = data.tsa_Comprobantes.FindByIdComprobante(dcc.IdComprobante);
					if (rowComprobanteImputado == null)
						rowComprobanteImputado = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dcc.IdComprobante);
					data.tsa_Comprobantes.ImportRow(rowComprobanteImputado);	
					data.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);
					try
					{
						System.Data.DataRow row1 = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(dcc.IdComprobante, Convert.ToInt16(dcc.Cuota));
						int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row1["IdTipoDeComprobante"]).signo);
						row1["saldo"] = (decimal )row1["saldo"] * signo;
						row1["Saldo"] =(decimal) row1["Saldo"] - dcc.Pago;
						row1["Saldo"] = (decimal) row1["Saldo"] * signo;

					}
					catch(Exception e) 
					{
						tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row2 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(dcc.IdComprobante, Convert.ToInt16(dcc.Cuota));
						if(row2 != null)
						{
							int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row2["IdTipoDeComprobante"]).signo);
							row2["saldo"] = (decimal )row2["saldo"] * signo;
							row2["Saldo"] =(decimal) row2["Saldo"] - dcc.Pago;
							row2["Saldo"] = (decimal) row2["Saldo"] * signo;
							data.tsa_ComprobanteDetalleDeuda.ImportRow((System.Data.DataRow)row2);
						}
					}
					

						
					
				}
				try
				{
					System.Data.DataRow row3 = data.tsa_ComprobanteDetalleDeuda.FindByIdComprobanteCuota(dccSingle.IdComprobante, Convert.ToInt16(dccSingle.Cuota));
					int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row3["IdTipoDeComprobante"]).signo);
					row3["saldo"] = (decimal )row3["saldo"] * signo;
					row3["Saldo"] =(decimal) row3["Saldo"] - dccSingle.Pago;
					row3["Saldo"] = (decimal) row3["Saldo"] * signo;

				}
				catch(Exception e) 
				{
					tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row4 = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(dccSingle.IdComprobante, Convert.ToInt16(dccSingle.Cuota));
					if(row4 != null)
					{
						int signo =Convert.ToInt32( tsy_TiposDeComprobantes.GetByPk((string) row4["IdTipoDeComprobante"]).signo);
						row4["saldo"] = (decimal )row4["saldo"] * signo;
						row4["Saldo"] =(decimal) row4["Saldo"] - dccSingle.Pago;
						row4["Saldo"] = (decimal) row4["Saldo"] * signo;
						data.tsa_ComprobanteDetalleDeuda.ImportRow((System.Data.DataRow)row4);
					}
				}
			
				#endregion
			}
	

		}


		public override void Commit()
		{
			ComprobanteDePago cdp = this.Parent;
			tsa_ComprobantesExDataset data = cdp.DatasetComprobante;
			ArrayList detalles = cdp.CuentaCorriente.Detalle;
			System.Data.DataRow rowComprobante = null; 
			tsa_ComprobantesExDataset.tsa_ComprobantesDataTable TablaComprobantes = data.tsa_Comprobantes;
		    rowComprobante = data.tsa_Comprobantes.FindByIdComprobante(this.Parent.IdComprobante);
			if (rowComprobante == null)
			{
                rowComprobante = mz.erp.businessrules.tsa_Comprobantes.GetByPk(this.Parent.IdComprobante);		
				data.tsa_Comprobantes.ImportRow(rowComprobante);	

			}
			//Para cada item de la cuenta Corriente asociado al comprobante, toma aquellos comprobantes
			//imputados en el pago, es decir, aquellos que tienen signo = -1 (Comprobantes de Venta(Facturas, Notas de Debitos, ect...)
			//y que tienen la propiedad Pago > 0
			foreach(DetalleCuentaCorriente dcc in detalles )
			{
				if((dcc.Pago >0) && (dcc.Signo == -1))
				{
					tsa_ComprobantesExDataset.tsa_AplicacionPagosRow row = data.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
					this.SetRowValues(row, dcc, rowComprobante);
					
					//Se actualiza el el saldo del Comprobante de Pago, en base a los comprobantes imputados
					//Por eso se debe cumplir que dcc.Pago >0 y que dcc.Signo == -1
					
					
					//cdp.Saldo= cdp.Saldo - dcc.Pago;
					
					
					if(cdp.ComprobanteDeVenta != null)
					{
						System.Data.DataRow rowComprobanteImputado = cdp.ComprobanteDeVenta.DatasetComprobante.tsa_Comprobantes.FindByIdComprobante(dcc.IdComprobante);
						data.tsa_Comprobantes.LoadDataRow(rowComprobanteImputado.ItemArray,true);
					}
					else
					{
						System.Data.DataRow rowComprobanteImputado = data.tsa_Comprobantes.FindByIdComprobante(dcc.IdComprobante);
						if (rowComprobanteImputado == null)
						{
							rowComprobanteImputado = mz.erp.businessrules.tsa_Comprobantes.GetByPk(dcc.IdComprobante);
							data.tsa_Comprobantes.ImportRow(rowComprobanteImputado);	
						}
					}
					data.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);
				}
			}

		}


		public void SetRowValues(tsa_ComprobantesExDataset.tsa_AplicacionPagosRow row, DetalleCuentaCorriente dcc,
								System.Data.DataRow rowComprobante )
		{


			row.IdComprobanteOrigen =dcc.IdComprobante; 
			row.CuotaOrigen =(short)dcc.Cuota; 
			row.IdComprobanteDestino = (string)rowComprobante["IdComprobante"]; 
			row.IdTipoComprobanteOrigen = dcc.IdTipoDeComprobante;
			row.Importe = dcc.Pago;
			row.IdTipoDeComprobanteDestino = (string)rowComprobante["IdTipoDeComprobante"];
			//se deberia modificar
			row.CuotaDestino = 1;
			
			
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;


		}

		public tsa_ComprobantesExDataset AplicarPago(tsa_ComprobantesExDataset comprobanteDePago, string IdComprobanteOrigen, string IdTipoComprobanteOrigen, short CuotaComprobanteOrigen, decimal montoAImputar)
		{
			tsa_ComprobantesExDataset.tsa_ComprobantesRow rowComprobanteDePago = ( tsa_ComprobantesExDataset.tsa_ComprobantesRow )comprobanteDePago.tsa_Comprobantes.Rows[0];
			if (rowComprobanteDePago != null)
			{
				tsa_ComprobantesExDataset.tsa_AplicacionPagosRow row = comprobanteDePago.tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
				string IdComprobanteDePago = rowComprobanteDePago.IdComprobante;
				string IdTipoComprobanteDePago = rowComprobanteDePago.IdTipoDeComprobante;
			
				row.IdComprobanteOrigen = IdComprobanteOrigen; 
				row.CuotaOrigen = CuotaComprobanteOrigen; 
				row.IdTipoComprobanteOrigen = IdTipoComprobanteOrigen;

				row.IdComprobanteDestino = IdComprobanteDePago ; 
				row.IdTipoDeComprobanteDestino = IdTipoComprobanteDePago ;

				row.Importe = montoAImputar;
				
				//se deberia modificar
				row.CuotaDestino = 1;
			
				row.IdEmpresa = Security.IdEmpresa;
				row.IdSucursal = Security.IdSucursal;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 0;
				row.RowId = Guid.Empty;

				comprobanteDePago.tsa_AplicacionPagos.Addtsa_AplicacionPagosRow( row );
			}
			return comprobanteDePago;

		}

	}
}
