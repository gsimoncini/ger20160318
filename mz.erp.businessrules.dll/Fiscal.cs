using System;
using mz.erp.businessrules;
using ParaisoFiscal;
using mz.erp.fiscal.dll;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Fiscal.
	/// </summary>
	/// 
	

	public class Fiscal
	{		
		private ParaisoFiscal.FiscalMZ fiscal;
		private byte _codImpFis = 0;
		private byte _codCompTipo = 0; //factura
		private byte _codCliTipo = 0; //cons. final
		ComprobanteDeVenta _comprobante;

		public Fiscal()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_codImpFis = byte.Parse(Variables.GetValue("Fiscal.Codigo").ToString());		
			_codCompTipo = 1; //factura
			_codCliTipo = 5; //cons. final

			fiscal = new ParaisoFiscal.FiscalMZ();
			fiscal.OnChangeEstado += (new System.EventHandler(OnChangeEstado));			
		}
	
		public Fiscal(ComprobanteDeVenta Comprobante, string TipoComprobante)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_codImpFis = byte.Parse(Variables.GetValue("Fiscal.Codigo").ToString());
			_comprobante = Comprobante;
			
			switch (TipoComprobante)
			{
				case "FA": _codCompTipo = 1;
					break;
				case "ND": _codCompTipo = 2;
					break;
				case "NC": _codCompTipo = 3;
					break;
			}
			_codCliTipo = GetTipoCliente();

			fiscal = new ParaisoFiscal.FiscalMZ();
			fiscal.OnChangeEstado += (new System.EventHandler(OnChangeEstado));			
		}


		public void OnChangeEstado(object Sender, System.EventArgs e) 
		{					
			System.Windows.Forms.MessageBox.Show(fiscal.Mensaje);			 
		}

		public void CierreX() 
		{
			if ( fiscal.VerOpcImpFis(_codImpFis, _codCompTipo, _codCliTipo)) 
			{
				byte Puerto = byte.Parse(Variables.GetValue("Fiscal.Puerto").ToString());
				int Velocidad = int.Parse(Variables.GetValue("Fiscal.Velocidad").ToString());			
				if (fiscal.AbrirImpFis(Puerto, Velocidad))
				{
					ReporteFiscal rf = new ReporteFiscal();			
					//bool proceso = false;
					fiscal.Reporte('X',rf);
				}				
			}

			/*if (rdBttnReporteX.Checked)
			{
				if (fiscal.Reporte('X',rf)) {proceso = true;}
			}
			if (rdBttnReporteZ.Checked) 
			{
				if (fiscal.Reporte('Z',rf)) {proceso = true;};
			}*/

			/*listBox2.Items.Add(Fiscal.Mensaje);				
			if (proceso) 
			{
				listBox2.Items.Add("Nro. de reporte: " + rf.NroReporte);
				listBox2.Items.Add("Ult. comp. A: " + rf.UltA);
				listBox2.Items.Add("Ult. comp. B: " + rf.UltB);
				listBox2.Items.Add("Total ventas: " + rf.MontoVentas.ToString());
				listBox2.Items.Add("Total IVA: " + rf.MontoIVA.ToString());				
			}*/
		}
		public void CierreZ() 
		{
			if ( fiscal.VerOpcImpFis(_codImpFis, _codCompTipo, _codCliTipo)) 
			{
				byte Puerto = byte.Parse(Variables.GetValue("Fiscal.Puerto").ToString());
				int Velocidad = int.Parse(Variables.GetValue("Fiscal.Velocidad").ToString());			
				if (fiscal.AbrirImpFis(Puerto, Velocidad)) 
				{
					ReporteFiscal rf = new ReporteFiscal();			
					//bool proceso = false;
					fiscal.Reporte('Z',rf);
				}
			}
		}

		public void ImpresionFiscal() 
		{			
			//I N I C I O
			ConfiguracionImpresoraFiscal();

			// A P E R T U R A    D E     I M P R E S O R A     F I S C A L						
			AperturaImpresoraFiscal();			

			// A P E R T U R A    D E     C O M P R O B A N T E     F I S C A L		
			AperturaComprobanteFiscal();

			// I M P R E S I O N     D E     I T E M S
			ImpresionItems();

			// C E R R A R      C O M P R O B A N T E
			CierreComprobanteFiscal();			

			// C E R R A R      I M P R E S O R A      F I S C A L
			CierreImpresoraFiscal();


			//D E S C U E N T O       G E N E R A L
			/*char operacion = 'D';
			if (rdbttnDescuentoGral.Checked) {operacion = 'D';}
			if (rdbttnRecargoGral.Checked) {operacion = 'R';}			

			fiscal.GrabarDesctoGral(txtBxGralDesc.Text, Decimal.Parse(txtBxGralMonto.Text), operacion);*/

			//fiscal.CancelarComp();
			//fiscal.GrabarPago(txtBxFormaPago.Text, Decimal.Parse(txtBxPago.Text));
			//fiscal.CancelarComp();
			//fiscal.Percepcion("Percepcion", decimal.Parse(txtBxPercMonto.Text), decimal.Parse(txtBxPercIva.Text));


			// S U B T O T A L E S
/*
 			SubTotalFiscal st = new SubTotalFiscal();
			fiscal.Subtotal(st);			

			listBox2.Items.Add("Cantidad: " + st.Cantidad.ToString());	
			listBox2.Items.Add("Neto: " + st.Neto.ToString());						
			listBox2.Items.Add("IVA: " + st.Iva.ToString());
			listBox2.Items.Add("Total: " + st.Total.ToString());	
			listBox2.Items.Add("Pagado: " + st.Pagado.ToString());				
 * */
		}

		private void ConfiguracionImpresoraFiscal()
		{	
			if ( fiscal.VerOpcImpFis(_codImpFis, _codCompTipo, _codCliTipo)) 
			{
				System.Windows.Forms.MessageBox.Show(fiscal.Nombre);
			}
			else
			{
				//listBox1.Items.Add("Error de código de impresora fiscal");
				System.Windows.Forms.MessageBox.Show("Error de código de impresora fiscal");
				return;
			}			

			if (fiscal.SoportaCompTipo)
			{
				System.Windows.Forms.MessageBox.Show(fiscal.CompNombre);
			}
			else
			{
				{System.Windows.Forms.MessageBox.Show("No soporta tipo de comprobante");}
			}
			
			if (fiscal.SoportaCliente)
			{
				System.Windows.Forms.MessageBox.Show(fiscal.CliTipo);				
			}
			else
			{{System.Windows.Forms.MessageBox.Show("No soporta tipo de cliente");}}
		}

		private void AperturaImpresoraFiscal() 
		{
			byte Puerto = byte.Parse(Variables.GetValue("Fiscal.Puerto").ToString());
			int Velocidad = int.Parse(Variables.GetValue("Fiscal.Velocidad").ToString());			
			fiscal.AbrirImpFis(Puerto, Velocidad);
		}

		private void AperturaComprobanteFiscal() 
		{
			ClienteFiscal clifis = new ClienteFiscal(_codImpFis);			

			clifis.Nombre = _comprobante.Cuenta.Nombre;
			clifis.Direccion = _comprobante.Cuenta.Domicilio;
			clifis.CondIVA = _codCliTipo;
			clifis.DocNumero = _comprobante.Cuenta.Documento;
			clifis.DocTipo = GetTipoDocumento();
			fiscal.LinVar1 = "Vendedor: " + _comprobante.Responsable;
				//String.Empty;//txtBxEncabezado1.Text;
			fiscal.LinVar2 = String.Empty;//txtBxEncabezado2.Text;
			fiscal.LinVar3 = String.Empty;//txtBxEncabezado3.Text;
			fiscal.LinVar4 = String.Empty;//txtBxEncabezado4.Text;

			fiscal.NumAsoc1 = String.Empty;//txtBxNumAsoc1.Text;
			fiscal.NumAsoc2 = String.Empty;//txtBxNumAsoc2.Text;
			fiscal.NumAsoc3 = String.Empty;//txtBxNumAsoc3.Text;
			fiscal.NumAsoc4 = String.Empty;//txtBxNumAsoc4.Text;

			if (fiscal.AbrirComp(_codCompTipo, 0, clifis))
			{
				//listBox2.Items.Add("--------------------------------------------------");
				System.Windows.Forms.MessageBox.Show(fiscal.Mensaje + ' ' + fiscal.CompAbrev + ' ' + fiscal.CompClase.ToString() + ' ' + fiscal.CompNumeroD);
			}			
		}

		private void ImpresionItems()
		{
			/*
			 * 				
							decimal iva = 0;
							decimal cantidad = 0;
							string descripcion = String.Empty;
							decimal monto = 0;

				

			 * */
			ItemsComprobantes items = _comprobante.Items;

			foreach (ItemComprobante itemComp in items)
			{					
				ItemFiscal item = new ItemFiscal();
				item.TextoFiscal = String.Empty;//txtBxTextoFiscal.Text;
				
				item.Cantidad = itemComp.Cantidad;
				item.Descripcion = itemComp.DescripcionLarga;
				item.IVA = itemComp.GetPorcentajeImpuesto(Variables.GetValueString("Impuestos.IVA"));
				item.Monto = itemComp.Precio;			 

				Impuestos imp = itemComp.ImpuestosDirectos;
				item.ImpuestosInternos = 8;//imp.GetTotalImpuesto(Variables.GetValueString("Impuestos.II"));

				//cantidad = imp.GetTotalImpuesto(Variables.GetValueString("Impuestos.IB"));

				//if (rdbttnDescuento.Checked) {item.Diferencia = 'D';}
				//if (rdbttnRecargo.Checked) {item.Diferencia = 'R';}			
			
				item.MontoDif = 0;//Decimal.Parse(txtMontoDif.Text);
				item.DescripcionDif = String.Empty;//txtBxDescripcionDif.Text;								
				fiscal.GrabarItem(item);
			}
		}
		
		private void CierreComprobanteFiscal() 
		{
			fiscal.CerrarImpFis();	
		}
		private void CierreImpresoraFiscal() 
		{
			fiscal.CerrarComp();
		}
		private byte GetTipoCliente() 
		{
			byte TipoCliente = 0;
			
			if (_comprobante.Cuenta.CategoriaImpositiva == Variables.GetValueString("Comprobantes.CategoriaImpositiva.ConsumidorFinal")) 
			{
				TipoCliente = 5; //cons. final
			}
			else 
			{
				if (_comprobante.Cuenta.CategoriaImpositiva == Variables.GetValueString("Comprobantes.CategoriaImpositiva.ResponsableInscripto"))  
				{
					TipoCliente = 1; //responsable inscripto
				}
				else 
				{
					TipoCliente = 1; //responsable inscripto
				}
			}			
			return TipoCliente;
		}

		private byte GetTipoDocumento() 
		{			
			byte TipoDocumento = 0;
			if (_comprobante.Cuenta.TipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.DNI")) 
			{
				TipoDocumento = 4;
			}
			else 
			{
				if (_comprobante.Cuenta.TipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.CUIT"))  
				{
					TipoDocumento = 1;
				}
				else 
				{
					_codCliTipo = 0;
				}
			}			
			return TipoDocumento;
		}
	}
}
