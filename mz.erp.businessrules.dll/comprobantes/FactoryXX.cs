using System;
using mz.erp.commontypes.data;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Factory.
	/// </summary>
	public class Factory
	{
		public Factory()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region FormaDePago
		public static FormaDePago GetFormaDePago(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosRow row, string descComp)
		{

			FormaDePago fdp = new FormaDePago();
			fdp.HasDetail=false;
			fdp.Cuotas=row.Cuotas;
			fdp.Recargo=row.Recargo;
			fdp.DescripcionEntidad= row.Entidad;
			fdp.DescripcionMoneda= row.Moneda;
			fdp.Detalle=null;
			fdp.DescripcionComprobante=descComp;
			fdp.SetIdEntidad(row.IdEntidad);
			fdp.SetIdMoneda(row.IdMoneda);
			fdp.SetIdTDCompTesoreria(row.IdTDCompTesoreria);
			fdp.SetIdFormaDePago(row.IdFormaDePago);

			return fdp;

		}
		public static FormaDePago GetFormaDePagoMaster(FormaDePago row)
		{

			FormaDePago fdp = new FormaDePago();
			fdp.HasDetail=true;
			fdp.Detalle=new FormasDePagos();
			fdp.DescripcionComprobante=row.DescripcionComprobante;
			fdp.SetIdTDCompTesoreria(row.GetIdTDCompTesoreria());
			fdp.Agrupado=row.Agrupado;
			row.Agrupado= false;
			fdp.Detalle=new FormasDePagos();
			fdp.Detalle.Add(row);
			

			return fdp;

		}

		public static FormaDePago GetFormaDePagoMaster(FormaDePago row, string descMoneda)
		{

			FormaDePago fdp = new FormaDePago();
			fdp= GetFormaDePagoMaster(row);
			fdp.DescripcionMoneda= descMoneda;
			

			return fdp;

		}

		public static FormaDePago GetFormaDePagoMaster(string IdComp,string descComp, string IdMoneda,string IdFormaDePago)
		{

			FormaDePago fdp = new FormaDePago();
			fdp.HasDetail=false;
			fdp.DescripcionComprobante=descComp;
			fdp.SetIdTDCompTesoreria(IdComp);
			fdp.Agrupado=IdMoneda != "";
			fdp.SetIdMoneda(IdMoneda);
			fdp.SetIdFormaDePago(IdFormaDePago);
			return fdp;

		}

		public static FormaDePago GetFormaDePago(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosRow row, string descComp, bool agrupado)
		{

			FormaDePago fdp=Factory.GetFormaDePago(row,descComp);
			fdp.Agrupado=agrupado;
			return fdp;

		}











		public static FormaDePago GetFormaDePago(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosGeneralesRow row, string descComp)
		{

			FormaDePago fdp = new FormaDePago();
			fdp.HasDetail=false;
			fdp.Recargo=row.Recargo;
			fdp.DescripcionMoneda= row.Descripcion;
			fdp.Detalle=null;
			fdp.DescripcionComprobante=descComp;
			fdp.SetIdMoneda(row.IdMoneda);
			fdp.SetIdTDCompTesoreria(row.IdTDCompTesoreria);
			fdp.SetIdFormaDePago(row.IdFormaDePago);

			return fdp;

		}

		public static FormaDePago GetFormaDePago(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosGeneralesRow row, string descComp, bool agrupado)
		{

			FormaDePago fdp=Factory.GetFormaDePago(row,descComp);
			fdp.Agrupado=agrupado;
			return fdp;

		}
		#endregion

		#region Valor
		public static Valor GetValor(string IdValor,string IdTDCompTesoreria, string comprobante, string IdMoneda, string Moneda,
			string IdEntidad, string Entidad,string Numero, DateTime Fecha, DateTime FechaVencimiento,
			decimal Valor, ArrayList cotizaciones)
		{
			Valor valor = new Valor(cotizaciones);
			valor.SetIdValor(IdValor);
			valor.Comprobante= comprobante;
			valor.SetValor( Valor);
			valor.SetIdMoneda(IdMoneda);
			valor.SetIdTDCompTesoreria(IdTDCompTesoreria);
			valor.Moneda= Moneda;
			valor.Numero= Numero;
			valor.Fecha= Fecha;
			valor.FechaVencimiento = FechaVencimiento;
			valor.SetIdEntidad(IdEntidad);
			valor.Entidad= Entidad;
			foreach(Cotizacion cot in cotizaciones )
			{
				if(cot.IdMonedaOrigen.Equals(valor.IdMoneda))
					valor.IdCotizacion=cot.IdCotizacion;

			}
			

			return valor;
		}

		public static Valor GetValor(string Comprobante,string Numero,string Entidad,DateTime Fecha, DateTime FechaVencimiento,
			decimal Valor, string Moneda, string IdCotizacionMoneda)
		{

			Valor valor = new Valor();
			
			valor.Comprobante= Comprobante;
			valor.SetValor( Valor);
			valor.SetIdMoneda(Moneda);
			valor.SetIdTDCompTesoreria(Comprobante);
			valor.Moneda= Moneda;
			valor.Numero= Numero;
			valor.Fecha= Fecha;
			valor.FechaVencimiento = FechaVencimiento;
			valor.SetIdCotizacion(IdCotizacionMoneda);
			valor.Entidad= Entidad;
			return valor;

		}

		public static Valor GetValor(System.Data.DataRow row , ArrayList cotizaciones)
		{
			string IdValor = (string)row["IdValor"]; 
			string IdTDCompTesoreria = (string)row["IdTDCompTesoreria"];
			string Numero = (string)row["Numero"];
			string IdEntidad = (string)row["IdEntidad"];
			DateTime Fecha = (DateTime)row["Fecha"];
			DateTime FechaDeVencimiento = (DateTime)row["FechaVencimiento"];
			decimal valor = (decimal )row["Valor" ];
			string IdMoneda = (string)row["IdMoneda"];
			string IdCotizacionMoneda =(string) row["IdCotizacionMoneda"];
			Valor v = Factory.GetValor(IdTDCompTesoreria,Numero, IdEntidad,Fecha, FechaDeVencimiento,valor, IdMoneda,IdCotizacionMoneda);
			v.IdValor = IdValor;
			v.Cotizaciones = cotizaciones;

			return v;

		}
		

		#endregion

		#region Cotizacion
			
		public static Cotizacion GetCotizacion (string IdCotizacion, string IdMonedaOrigen, string IdMonedaDestino , decimal Valor)
		{
			Cotizacion cot = new Cotizacion();
			cot.IdCotizacion= IdCotizacion;
			cot.IdMonedaOrigen= IdMonedaOrigen;
			cot.IdMonedaDestino= IdMonedaDestino;
			cot.Valor= Valor;
			return cot;
		}
		#endregion

		#region MovimientoDeCaja
		public static MovimientoDeCaja GetMovimiento(string IdMonedaCierre)
		{
			MovimientoDeCaja mdc = new MovimientoDeCaja();
			mdc.Valores = new System.Collections.ArrayList();
			mdc.IdMonedaCierre= IdMonedaCierre;
			return mdc;
		}

		
		#endregion

		#region CuentaCorriente
		public static CuentaCorriente GetCuentaCorriente()
		{
			CuentaCorriente ctaCte = new CuentaCorriente();
			
			ctaCte.FechaDesde= DateTime.Now;
			ctaCte.FechaHasta= DateTime.Now;
			ctaCte.SaldoAnterior = 0;
			ctaCte.Detalle = new ArrayList();
			ctaCte.SaldoPosterior=0;
			ctaCte.TotalImputado = 0;			

			return ctaCte;
		}

		public static CuentaCorriente GetCuentaCorriente(string IdCuenta)
		{
			CuentaCorriente ctaCte = new CuentaCorriente();
			ctaCte.FechaDesde= DateTime.Now;
			ctaCte.FechaHasta= DateTime.Now;
			ctaCte.IdCuenta= IdCuenta;
			ctaCte.SaldoAnterior = 0;
			ctaCte.Detalle = new ArrayList();
			ctaCte.SaldoPosterior=0;
			ctaCte.TotalImputado = 0;
			ctaCte.Cuenta = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta).Nombre;
			return ctaCte;
		}

		public static CuentaCorriente GetCuentaCorriente(string IdCuenta, DateTime desde, DateTime hasta)
		{
			CuentaCorriente ctaCte = new CuentaCorriente();
			ctaCte.IdCuenta= IdCuenta;
			ctaCte.FechaDesde= desde;
			ctaCte.FechaHasta= hasta;
			ctaCte.SaldoAnterior = 0;
			ctaCte.Detalle = new ArrayList();
			ctaCte.SaldoPosterior=0;
			ctaCte.TotalImputado = 0;
			ctaCte.Cuenta = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta).Nombre;
			return ctaCte;
		}
		#endregion

		#region DetalleCuentaCorriente
		public static DetalleCuentaCorriente GetDetalleCuentaCorriente(string IdComprobante,string Comprobante,
			string Numero, DateTime FechaVencimiento,DateTime FechaEmision, 
			int Cuota, decimal Importe, decimal Saldo, decimal Total,int signo, string IdTipoDeComprobante)
		{
			DetalleCuentaCorriente dcc = new DetalleCuentaCorriente();
			dcc.IdComprobante = IdComprobante;
			dcc.Comprobante = Comprobante;
			dcc.Numero  = Numero;
			dcc.FechaVencimiento = FechaVencimiento;
			dcc.FechaEmision = FechaEmision;
			dcc.Cuota = Cuota;
			dcc.Importe = Importe;
			dcc.Saldo = Saldo;
			dcc.Total= Total;
			dcc.Signo = signo;
			dcc.IdTipoDeComprobante = IdTipoDeComprobante;

			return dcc;


		}

		public static DetalleCuentaCorriente GetDetalleCuentaCorriente (ComprobanteDeVenta comprobante)
		{
			
			string IdComprobante= comprobante.IdComprobante;
			string  Comprobante= comprobante.IdComprobante;
			string Numero = comprobante.Numero;
			DateTime FechaVencimiento = comprobante.FechaComprobante;
			DateTime FechaEmision = comprobante.FechaComprobante;
			short Cuota = 1;
			decimal Importe = comprobante.Total;
			decimal Saldo = comprobante.Total * comprobante.SignoCuentaCorriente;
			decimal Total = comprobante.Total;
			int signo = comprobante.SignoCuentaCorriente;
			string IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
			DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(IdComprobante, Comprobante, Numero,
				FechaVencimiento,FechaEmision, Cuota, Importe, Saldo, Total, signo, IdTipoDeComprobante);
			
			
			return dcc;
		}

		public static DetalleCuentaCorriente GetDetalleCuentaCorriente (ComprobanteDePago comprobante)
		{
			
			string IdComprobante= comprobante.IdComprobante;
			string  Comprobante= comprobante.IdComprobante;
			string Numero = comprobante.Numero;
			DateTime FechaVencimiento = comprobante.FechaComprobante;
			DateTime FechaEmision = comprobante.FechaComprobante;
			short Cuota = 1;
			decimal Importe = comprobante.Total;
			decimal Saldo = comprobante.Saldo;
			decimal Total = comprobante.Total;
			int signo = comprobante.SignoCuentaCorriente;
			string IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
			DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(IdComprobante, Comprobante, Numero,
				FechaVencimiento,FechaEmision, Cuota, Importe, Saldo, Total, signo, IdTipoDeComprobante);
			
			
			return dcc;
		}


		public static  DetalleCuentaCorriente GetDetalleCuentaCorriente(System.Data.DataRow row)
		{


			string IdComprobante= (string) row["IdComprobante"];
			string  Comprobante;
			if(row.Table.Columns.Contains("Comprobante"))
				Comprobante= (string) row["Comprobante"];
			else
				Comprobante= (string) row["IdComprobante"];
			string Numero = (string ) row["Numero"];
			DateTime FechaVencimiento = (DateTime) row["FechaVencimiento"];
			DateTime FechaEmision = (DateTime) row["FechaEmision"];
			short Cuota = (short) row["Cuota"];
			decimal Importe = (decimal) row["Importe"];
			decimal Saldo = (decimal) row["Saldo"];
			decimal Total = (decimal) row["Importe"];
			
			string IdTipoDeComprobante = (string) row["IdTipoDeComprobante"];

			int signo =Convert.ToInt32(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(IdTipoDeComprobante).signo);
			DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(IdComprobante, Comprobante, Numero,
				FechaVencimiento,FechaEmision, Cuota, Importe, Saldo, Total, signo, IdTipoDeComprobante);
			
			
			return dcc;
		}


		public static ComprobanteDePago GetComprobanteDePago()
		{
			ComprobanteDePago cdp = new ComprobanteDePago();
			string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			cdp.IdMonedaCierre = IdMoneda;
			cdp.FechaComprobante = DateTime.Now;
			
			cdp.CondicionDeVenta=new CondicionDeVenta("NEW",cdp, Variables.GetValueString("Comprobantes.FormaDePago.Contado"));
			cdp.DatasetComprobante  = new tsa_ComprobantesExDataset();
			cdp.Valores = Factory.GetValores(cdp.DatasetComprobante);
			cdp.CompDetalleDePagos= Factory.GetComprobantesDetalleDePagos(cdp);
			cdp.Saldo = 0;
			cdp.TotalPago = 0;
			cdp.AplicacionesDePagos = Factory.getAplicacionesDePagos(cdp);
			cdp.IdComprobante = mz.erp.systemframework.Util.NewStringId();
			
			return cdp;

		}

		#endregion

		#region ComprobanteDePago
		//Esta sobrecarga recibe como parametro el IdComprobante del comprobante
		//que esta imputado o no con un comprobante de pago
		//Esta sobrecarga debe recuperar primero el comprobante de pago 

		public static ComprobanteDePago GetComprobanteDePago(string IdComprobanteDeVenta, string IdCondicionDeVenta)
		{
			
			ComprobanteDePago cdp;
			
			CuentaCorriente ctacte = Factory.GetCuentaCorriente();			
			string IdComprobanteDePago = "";
			tsa_ComprobanteValoresVarAuxDataset.tsa_ComprobanteValoresVarAuxRow rowVarAux = mz.erp.businessrules.tsa_ComprobanteValoresVarAux.GetByPk(IdComprobanteDeVenta,"11");			
			if (rowVarAux != null) 			
			{IdComprobanteDePago = rowVarAux.Valor;}
				 //mz.erp.businessrules.tsa_ComprobanteValoresVarAux.GetByPk(IdComprobanteDeVenta,"11").Valor;	}
			//se chequea que exista un comprobante de pago asociado, puesto que puede que no se haya generado comprobante de pago
			//No se generan comprobantes de pagos si no se han ingresado valores

			if(IdComprobanteDePago != null && !IdComprobanteDePago.Equals(string.Empty))
			{
				System.Data.DataRow rowComprobanteDePago = mz.erp.businessrules.tsa_Comprobantes.GetByPk(IdComprobanteDePago); 
			
			
				System.Data.DataRow rowDetalleDeudaComprobanteDePago = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetByPk(IdComprobanteDePago,1);
				System.Data.DataSet dataDetalleDeudaComprobanteDeVenta = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetList(IdComprobanteDeVenta,null,null);
			
				if(ComprobantesRules.Comprobantes_CondicionDeVenta_Permite_Imputar(IdCondicionDeVenta))
				{
			
					
					
					//DetalleCuentaCorriente dccComprobanteDePago = Factory.GetDetalleCuentaCorriente(rowDetalleDeudaComprobanteDePago);
					//DetalleCuentaCorriente dccComprobanteDeVenta = Factory.GetDetalleCuentaCorriente(rowDetalleDeudaComprobanteDeVenta);
					//ctacte.Detalle.Add(dccComprobanteDePago);
					//ctacte.Detalle.Add(dccComprobanteDeVenta);
			
					foreach(System.Data.DataRow rowDetalleDeudaComprobanteDeVenta in dataDetalleDeudaComprobanteDeVenta.Tables[0].Rows)
					{	
						DetalleCuentaCorriente dccComprobanteDeVenta = Factory.GetDetalleCuentaCorriente(rowDetalleDeudaComprobanteDeVenta);
						ctacte.Detalle.Add(dccComprobanteDeVenta);

					}
			

					decimal total = (decimal) rowComprobanteDePago["Total"];
					decimal pago = total - (decimal) rowDetalleDeudaComprobanteDePago["Saldo"];
					cdp=  Factory.GetComprobanteDePago(IdComprobanteDePago,total,pago,ctacte,IdCondicionDeVenta);
					
				
				}
				else 
				{
					//decimal total = (decimal) rowComprobanteDePago["Total"];
					//decimal pago = total - (decimal) rowDetalleDeudaComprobanteDePago["Saldo"];
					cdp = Factory.GetComprobanteDePago(IdComprobanteDePago,0,0,ctacte,IdCondicionDeVenta);
					cdp.Total =(decimal) rowComprobanteDePago["Total"];
					cdp.Saldo = (decimal) rowDetalleDeudaComprobanteDePago["Saldo"];
					cdp.TotalPago = cdp.Total - cdp.Saldo;


				}
				cdp.Anular = true;
				cdp.TipoComprobanteDestino = (string)rowComprobanteDePago["IdTipoDeComprobante"];
			}
			else cdp = Factory.GetComprobanteDePago();

			return cdp;
			
			
		}


		public static ComprobanteDePago GetComprobanteDePago(string IdComprobante,decimal total, decimal Pago, CuentaCorriente ctaCte, string IdCondicionDeVenta)
		{
			ComprobanteDePago cdp = new ComprobanteDePago();
			cdp.IdComprobante = IdComprobante;
			cdp.FechaComprobante = DateTime.Now;
			cdp.DatasetComprobante  = new tsa_ComprobantesExDataset();
			cdp.AplicacionesDePagos = Factory.getAplicacionesDePagos(cdp);
			cdp.CondicionDeVenta=new CondicionDeVenta("NEW",cdp,IdCondicionDeVenta);
			cdp.Total = total;
			cdp.TotalPago = Pago;
			cdp.CuentaCorriente = ctaCte;

			cdp.CompDetalleDePagos= Factory.GetComprobantesDetalleDePagos(cdp);

			string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			cdp.IdMonedaCierre = IdMoneda;

			cdp.Valores = Factory.GetValores(cdp,cdp.DatasetComprobante);

			return cdp;

		}

		

		public static ComprobanteDePago GetComprobanteDePago(string IdComprobante,decimal total, decimal Pago, CuentaCorriente ctaCte )
		{
			ComprobanteDePago cdp = new ComprobanteDePago();
			cdp.IdComprobante = IdComprobante;
			cdp.FechaComprobante = DateTime.Now;
			cdp.DatasetComprobante  = new tsa_ComprobantesExDataset();
			cdp.AplicacionesDePagos = Factory.getAplicacionesDePagos(cdp);
			cdp.CondicionDeVenta=new CondicionDeVenta("NEW",cdp, Variables.GetValueString("Comprobantes.FormaDePago.Contado"));
			cdp.Total = total;
			cdp.TotalPago = Pago;
			cdp.CuentaCorriente = ctaCte;
			cdp.Valores = Factory.GetValores(cdp.DatasetComprobante);

			return cdp;


		}

		#endregion

		#region DetalleComprobantesDePago
		public static ComprobantesDetalleDePagos GetComprobantesDetalleDePagos(ComprobanteDePago parent)
		{
			ComprobantesDetalleDePagos cddp = new ComprobantesDetalleDePagos();
			cddp.Parent = parent;
			return cddp;
			
		}
		#endregion
		
		#region Valores
		public static Valores GetValores(System.Data.DataSet  parentDataset)
		{
			Valores valores = new Valores();
			valores.DataValoresEx = new tfi_ValoresExDataset();
			valores.MisValores = new ArrayList();
			valores.ParentDataSet= parentDataset;
			return valores;


		}


		public static Valores GetValores(ComprobanteDePago cdp, System.Data.DataSet  parentDataset)
		{
			Valores valores = GetValores(parentDataset);
			cdp.Valores = valores;
			ArrayList _cotizaciones = new ArrayList();
			_cotizaciones= new ArrayList();
			mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones( _cotizaciones,cdp.IdMonedaCierre);
			
			//Recupero los valores asociados al comporbante de Pago cdp
			System.Data.DataSet dataPagos = mz.erp.businessrules.tsa_ComprobanteDetalleDePagos.GetList(null,null,cdp.IdComprobante,null,decimal.MinValue);
			foreach(System.Data.DataRow row in dataPagos.Tables[0].Rows)
			{
				string IdValor = (string) row["IdValor"];
				System.Data.DataRow rowValor = mz.erp.businessrules.tfi_Valores.GetByPk(IdValor);
				Valor valor = Factory.GetValor(rowValor, _cotizaciones);
				decimal montoSinRecargo =0;
				if (!row.IsNull("MontoSinRecargos"))
				{
					montoSinRecargo = Convert.ToDecimal(row["MontoSinRecargos"]);
				}
				valor.SetValorSinRecargos(montoSinRecargo);
				tfi_ValoresExDataset dataValoresEx = mz.erp.businessrules.data.tfi_ValoresEx.GetByPk(valor.IdValor);
				valores.DataValoresEx.Merge(dataValoresEx);
				cdp.RefreshValores(valores.DataValoresEx,valor);

			}

			return valores;
			
			

		}
		#endregion

		#region AplicacionesDePagos
		public static AplicacionesDePagos getAplicacionesDePagos (ComprobanteDePago parent)
		{
			AplicacionesDePagos adp = new AplicacionesDePagos();
			adp.Parent = parent;
			return adp;


		}
		#endregion

		#region Herramienta
		public static Herramienta GetHerramienta(int IdHerramientaPadre, string Id, bool Habilitado,string ShortCut)
		{
			Herramienta h= new Herramienta();
			h.BarraHerraminetas = new ArrayList();
			h.Habilitado = Habilitado;
			h.Id = Id;
			h.IdHerramientaPadre = IdHerramientaPadre;
			h.Perfiles = new ArrayList();
			h.Recursos = new ArrayList();
			h.ShortCut = ShortCut;
			return h;
			
		}
		#endregion

		#region Recurso

		public static Recurso GetRecurso(int IdRecurso, string data)
		{
			Recurso r = new Recurso();
			r.IdTipoDeRecurso = IdRecurso;
			r.Dato = data;
			return r;

		}


#endregion

		#region Conversion
		public static Conversion GetConversion(string IdConversion, string IdUnidadDestino, string momento)
		{
			
				System.Data.DataRow rowConversion = null;
				if(IdConversion != null)
					rowConversion = mz.erp.businessrules.tsh_Conversiones.GetByPk(IdConversion);
				if(rowConversion != null)
				{
					System.Data.DataSet dataDetalle = mz.erp.businessrules.tsh_DetalleConversiones.GetList(IdConversion,null,null);
					Conversion conversion = new Conversion();	
					conversion.Nombre = (string) rowConversion["Nombre"];
					conversion.Descripcion = (string) rowConversion["Descripcion"];
					
					int count = 0;
					foreach(System.Data.DataRow rowItem in dataDetalle.Tables[0].Rows)
					{
						
						System.Data.DataRow row;
						ConversionItem conversionItem = new ConversionItem();
						conversionItem.IdUnidadOrigen = (string) rowItem["IdUnidadOrigen"];
						row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItem.IdUnidadOrigen);
						conversionItem.UnidadOrigen = (string) row["Nombre"];

						conversionItem.IdUnidadDestino = (string) rowItem["IdUnidadDestino"];
						row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItem.IdUnidadDestino);
						conversionItem.UnidadDestino = (string) row["Nombre"];
						
						conversionItem.Ordinal = (int) rowItem["Ordinal"];
						conversionItem.Formula = Convert.ToString(rowItem["FormulaConversion"]);
						conversionItem.ValorConversion = (decimal) rowItem["ValorConversion"];
						
						
						conversion.Items.Add(conversionItem);
						count++;
							
					}
					
					/*Aca la llamada a la propiedad de Conversion*******************/
						
						ArrayList medidasOrigen = new ArrayList();
						medidasOrigen.Add("1");

					/*Cambiar*******************************************************/	

					ArrayList conversionItemsList = new ArrayList();
					foreach(string IdUnidadOrigen in medidasOrigen)
					{		
						ConversionItems cvs =  conversion.Items.Filter(IdUnidadOrigen, IdUnidadDestino);
						if(cvs.Count > 0)
							conversionItemsList.Add(cvs);
					}
					if(conversionItemsList.Count > 0)
					{
						/*	Por ahora tomo el primero, tal vez mas adelante hay criterios de selecccion	*/
						conversion.Items = (ConversionItems)conversionItemsList[0];
						return conversion;
					}
					else
					{
						
						Conversion conversionDefault = new Conversion();	
						conversionDefault.Nombre = "Conversion Default";
						conversionDefault.Descripcion = "Conversion Default";
						//Agrego la conversion por defecto, la de su propia unidad de medida
						ConversionItem conversionItemDefault = new ConversionItem();
						System.Data.DataRow row;
						if(IdUnidadDestino == null)
						{
							//Harcodeado cambiar por unidad por defecto tomado de una variable del sistema
							conversionItemDefault.IdUnidadOrigen = "4";
							conversionItemDefault.IdUnidadDestino = "4";
						}
						else
						{
							conversionItemDefault.IdUnidadOrigen = IdUnidadDestino;
							conversionItemDefault.IdUnidadDestino = IdUnidadDestino;
						}
						row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItemDefault.IdUnidadOrigen);
						conversionItemDefault.UnidadOrigen = (string) row["Nombre"];
						row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItemDefault.IdUnidadDestino);
						conversionItemDefault.UnidadDestino = (string) row["Nombre"];
						conversionItemDefault.Ordinal = 0;
						//conversionItemDefault.Formula = " = ";
						conversionItemDefault.ValorConversion = 1;
						conversionDefault.Items.Add(conversionItemDefault);
						return conversionDefault;
					}


					

					


			}

			else
			{
				Conversion conversionDefault = new Conversion();	
				conversionDefault.Nombre = "Conversion Default";
				conversionDefault.Descripcion = "Conversion Default";
				//Agrego la conversion por defecto, la de su propia unidad de medida
				ConversionItem conversionItemDefault = new ConversionItem();
				if(IdUnidadDestino == null || IdUnidadDestino.Equals(string.Empty))
				{
					//Harcodeado cambiar por unidad por defecto tomado de una variable del sistema
					conversionItemDefault.IdUnidadOrigen = "4";
					conversionItemDefault.IdUnidadDestino = "4";
				}
				else
				{
					conversionItemDefault.IdUnidadOrigen = IdUnidadDestino;
					conversionItemDefault.IdUnidadDestino = IdUnidadDestino;
				}
				System.Data.DataRow row;
				row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItemDefault.IdUnidadOrigen);
				conversionItemDefault.UnidadOrigen = (string) row["Nombre"];
				row = mz.erp.businessrules.tsh_Unidades.GetByPk(conversionItemDefault.IdUnidadDestino);
				conversionItemDefault.UnidadDestino = (string) row["Nombre"];
				conversionItemDefault.Ordinal = 0;
				conversionItemDefault.Formula = " = ";
				conversionItemDefault.ValorConversion = 1;
				conversionDefault.Items.Add(conversionItemDefault);
				return conversionDefault;
			}

		return null;
			


			
			
				
		}

		#endregion

     }
}
