using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ImprimirTicket.
	/// </summary>
	public class ImprimirTicket: ITask, IDependentPersistentTask
	{
		public ImprimirTicket()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

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




		public void Init()
		{
			_ticket.Init(_processManager.Process.ProcessName, _taskName);
			_tareaAsociada = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "TareaAsociada");
			_leyendaPie = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "LeyendaPiePagina");
			_leyendaCabecera = Variables.GetValueString(_processManager.Process.ProcessName, _taskName, "LeyendaCebeceraPagina");
		}


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			return IsValid;
		}

		public bool AllowShow() 
		{
			return true;
		}
		
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public string GetWarnings()
		{		
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			if(this.IsValid())
				Imprimir();
			

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion
		
		#region Variables privadas
		
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processManager;	

		Ticket _ticket = new Ticket(); 
		ComprobanteDeVenta _compVenta;
		ComprobanteDePago _compPago;
		ComprobanteDeEntrega _compEntrega;
		ComprobanteDeCompra _compCompra;
		AjustarStock _ajustarStock;

        

		private string _tareaAsociada = string.Empty;
		private string _source = string.Empty;

		private string _leyendaPie = string.Empty;
		private string _leyendaCabecera = string.Empty;
		

		#endregion

		#region Miembros de IDependentPersistentTask

		public void ListenerAfterFlush(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
				&& _tareaAsociada.ToUpper().Equals(((ITask)sender).GetTaskName().ToUpper())
				)
			{
				_compVenta = (ComprobanteDeVenta) sender;
				_source = "COMPROBANTEDEVENTA";
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago))
				&& _tareaAsociada.ToUpper().Equals(((ITask)sender).GetTaskName().ToUpper())
				)
			{
				_compPago = (ComprobanteDePago) sender;
				_source = "COMPROBANTEDEPAGO";
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeEntrega))
				&& _tareaAsociada.ToUpper().Equals(((ITask)sender).GetTaskName().ToUpper())
				)
			{
				_compEntrega = (ComprobanteDeEntrega) sender;
				_source = "COMPROBANTEDEENTREGA";
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra))
				&& _tareaAsociada.ToUpper().Equals(((ITask)sender).GetTaskName().ToUpper())
				)
			{
				_compCompra = (ComprobanteDeCompra) sender;
				_source = "COMPROBANTEDECOMPRA";
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStock))
				&& _tareaAsociada.ToUpper().Equals(((ITask)sender).GetTaskName().ToUpper())
				)
			{
				_ajustarStock = (AjustarStock) sender;
				_source = "AJUSTEDESTOCK";
			}
		}

		public void ListenerBeforeFlush(object sender)
		{
			
		}

		#endregion

		#region Metodos Privados

		private void Imprimir()
		{
			

			string NombreEmpresa = Variables.GetValueString("Sistema.NombreEmpresa");
			string DireccionEmpresa = Variables.GetValueString("Sistema.DireccionEmpresa");
			string TelefonosEmpresa = Variables.GetValueString("Sistema.TelefonosEmpresa");
			string CUITEmpresa = Variables.GetValueString("Sistema.CUITEmpresa");
			string IngresosBrutosEmpresa = Variables.GetValueString("Sistema.IngresosBrutosEmpresa");
			string CategoriaDeIvaEmpresa = Variables.GetValueString("Sistema.CategoriaDeIvaEmpresa");

			#region Comprobante de Venta

			if(_ticket.HabilitaImpresion && _source.Equals("COMPROBANTEDEVENTA"))
			{

	
				if(_leyendaCabecera != null && _leyendaCabecera != string.Empty)
					_ticket.AddHeaderLine(_leyendaCabecera); 

				_ticket.AddHeaderLine("C.U.I.T. " + CUITEmpresa ); 
				_ticket.AddHeaderLine(NombreEmpresa.ToUpper() ); 
				_ticket.AddHeaderLine(DireccionEmpresa.ToUpper()); 
				_ticket.AddHeaderLine("INGRESOS BRUTOS " + IngresosBrutosEmpresa); 
				_ticket.AddHeaderLine(CategoriaDeIvaEmpresa.ToUpper() ); 


				_ticket.AddHeaderLine("MUCHAS GRACIAS POR SU COMPRA !!!!"); 
				_ticket.AddHeaderLine(_compVenta.Cuenta.Nombre); 
				_ticket.AddHeaderLine("FECHA: " + _compVenta.FechaComprobante.ToShortDateString() + " " + _compVenta.FechaComprobante.ToShortTimeString()); 
				_ticket.AddHeaderLine("TICKET NRO: " + _compVenta.Numero); 

				decimal cantArticulos = 0;
				foreach(ItemComprobante item in _compVenta.Items)
				{
					string descripcion = item.DescripcionCorta;
					string codSecundario = item.CodigoSecundario;
					string ali = "";
					foreach(Impuesto imp in item.ImpuestosDirectos)
					{
						ali = ali + "(" + Convert.ToString(Decimal.Round(imp.Alicuota,2)) + ")";
						break;
					}
					string art = Convert.ToString(Decimal.Round(item.Cantidad,3))+ " " /*+ codSecundario + " "*/ + descripcion /*+ " " + ali*/;
					_ticket.AddItem(Convert.ToString(Decimal.Round(item.Cantidad,3)), art, Convert.ToString(Decimal.Round(item.SubTotalConImpuestosDirectos,2)) ); 
					cantArticulos = cantArticulos + Decimal.Round(item.Cantidad,3);

				}
			
				_ticket.AddTotal("TOTAL", Convert.ToString(_compVenta.Total) ); 
				_ticket.AddTotal("", "" ); //Ponemos un total en blanco que sirve de espacio 
				_ticket.AddTotal("tarj/cupones",  Convert.ToString(_compVenta.Total) ); 
				_ticket.AddTotal("CAMBIO", "0.00" ); 
				
				//El metodo AddFooterLine funciona igual que la cabecera 
				_ticket.AddFooterLine("Articulos:" + Convert.ToString(cantArticulos) ); 
				_ticket.AddFooterLine("Nombre: " + _compVenta.Responsable ); 

				if(_leyendaPie != null && _leyendaPie != string.Empty)
					_ticket.AddFooterLine(_leyendaPie); 
				
				//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
				//parametro de tipo string que debe de ser el nombre de la impresora. 
				_ticket.PrintTicket(); 

			}
			#endregion

			#region Comprobante de Entrega

			if(_ticket.HabilitaImpresion && _source.Equals("COMPROBANTEDEENTREGA"))
			{

				if(_leyendaCabecera != null && _leyendaCabecera != string.Empty)
					_ticket.AddHeaderLine(_leyendaCabecera); 
	
				_ticket.AddHeaderLine("C.U.I.T. " + CUITEmpresa ); 
				_ticket.AddHeaderLine(NombreEmpresa.ToUpper() ); 
				_ticket.AddHeaderLine(DireccionEmpresa.ToUpper()); 
				_ticket.AddHeaderLine("INGRESOS BRUTOS " + IngresosBrutosEmpresa); 
				_ticket.AddHeaderLine(CategoriaDeIvaEmpresa.ToUpper() ); 


				//_ticket.AddHeaderLine("MUCHAS GRACIAS POR SU COMPRA !!!!"); 
				_ticket.AddHeaderLine(_compEntrega.Cuenta.Nombre); 
				_ticket.AddHeaderLine("Fecha: " + _compEntrega.FechaComprobante.ToShortDateString() + " " + _compEntrega.FechaComprobante.ToShortTimeString()); 
				_ticket.AddHeaderLine("E: " + _compEntrega.Numero); 
				_ticket.AddFooterLine("Resp. " + _compEntrega.Responsable ); 

				decimal cantArticulos = 0;
				foreach(ItemComprobante item in _compEntrega.Items)
				{
					string descripcion = item.DescripcionCorta;
					/*
					string codSecundario = item.CodigoSecundario;
					string ali = "";
					foreach(Impuesto imp in item.ImpuestosDirectos)
					{
						ali = ali + "(" + Convert.ToString(Decimal.Round(imp.Alicuota,2)) + ")";
						break;
					}
					*/
					string art = Convert.ToString(Decimal.Round(item.Cantidad,2))+ " " /*+ codSecundario + " "*/ + descripcion /*+ " " + ali*/;
					_ticket.AddItem(Convert.ToString(Decimal.Round(item.Cantidad,2)), art, string.Empty/*Convert.ToString(Decimal.Round(item.SubTotalConImpuestosDirectos,2))*/ ); 
					cantArticulos = cantArticulos + Decimal.Round(item.Cantidad,2);

				}
			
				//_ticket.AddTotal("TOTAL", Convert.ToString(_compVenta.Total) ); 
				//_ticket.AddTotal("", "" ); //Ponemos un total en blanco que sirve de espacio 
				/*
				_ticket.AddTotal("tarj/cupones",  Convert.ToString(_compVenta.Total) ); 
				_ticket.AddTotal("CAMBIO", "0.00" ); 
				*/
				
				//El metodo AddFooterLine funciona igual que la cabecera 
				_ticket.AddFooterLine("Articulos:" + Convert.ToString(cantArticulos) ); 

				if(_leyendaPie != null && _leyendaPie != string.Empty)
					_ticket.AddFooterLine(_leyendaPie); 
			
				
				//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
				//parametro de tipo string que debe de ser el nombre de la impresora. 
				_ticket.PrintTicket(); 

			}
			#endregion

			#region Comprobante de Compra

			if(_ticket.HabilitaImpresion && _source.Equals("COMPROBANTEDECOMPRA"))
			{

				if(_leyendaCabecera != null && _leyendaCabecera != string.Empty)
					_ticket.AddHeaderLine(_leyendaCabecera); 
	
				_ticket.AddHeaderLine("C.U.I.T. " + CUITEmpresa ); 
				_ticket.AddHeaderLine(NombreEmpresa.ToUpper() ); 
				_ticket.AddHeaderLine(DireccionEmpresa.ToUpper()); 
				_ticket.AddHeaderLine("INGRESOS BRUTOS " + IngresosBrutosEmpresa); 
				_ticket.AddHeaderLine(CategoriaDeIvaEmpresa.ToUpper() ); 


				//_ticket.AddHeaderLine("MUCHAS GRACIAS POR SU COMPRA !!!!"); 
				_ticket.AddHeaderLine(_compCompra.Proveedor.Nombre); 
				_ticket.AddHeaderLine("Fecha: " + _compCompra.FechaComprobante.ToShortDateString() + " " + _compCompra.FechaComprobante.ToShortTimeString()); 
				_ticket.AddHeaderLine("I: " + _compCompra.Numero);
				
				string responsable = string.Empty;
				DataRow row = mz.erp.businessrules.tsh_Personas.GetByPk(_compCompra.IdResponsable);
				if(row != null)
					responsable = Convert.ToString(row["Nombre"]);

				_ticket.AddFooterLine("Resp. " + responsable ); 

				decimal cantArticulos = 0;
				foreach(ItemComprobanteCompra item in _compCompra.Items)
				{
					string descripcion = item.Descripcion;
					/*
					string codSecundario = item.CodigoSecundario;
					string ali = "";
					foreach(Impuesto imp in item.ImpuestosDirectos)
					{
						ali = ali + "(" + Convert.ToString(Decimal.Round(imp.Alicuota,2)) + ")";
						break;
					}
					*/
					string art = Convert.ToString(Decimal.Round(item.Cantidad,3))+ " " /*+ codSecundario + " "*/ + descripcion /*+ " " + ali*/;
					_ticket.AddItem(Convert.ToString(Decimal.Round(item.Cantidad,3)), art, string.Empty /*Convert.ToString(Decimal.Round(item.PrecioDeCosto,2)) */); 
					cantArticulos = cantArticulos + Decimal.Round(item.Cantidad,3);

				}
			
				//_ticket.AddTotal("TOTAL", Convert.ToString(_compVenta.Total) ); 
				//_ticket.AddTotal("", "" ); //Ponemos un total en blanco que sirve de espacio 
				/*
				_ticket.AddTotal("tarj/cupones",  Convert.ToString(_compVenta.Total) ); 
				_ticket.AddTotal("CAMBIO", "0.00" ); 
				*/
				
				//El metodo AddFooterLine funciona igual que la cabecera 
				_ticket.AddFooterLine("Articulos:" + Convert.ToString(cantArticulos) ); 

				if(_leyendaPie != null && _leyendaPie != string.Empty)
					_ticket.AddFooterLine(_leyendaPie); 
			
				
				//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
				//parametro de tipo string que debe de ser el nombre de la impresora. 
				_ticket.PrintTicket(); 

			}
			#endregion

			#region Ajuste de Stock

			if(_ticket.HabilitaImpresion && _source.Equals("AJUSTEDESTOCK"))
			{

				//_ticket.MaxChar = 40;
				//_ticket.MaxCharDescription = _ticket.MaxChar;
				if(_leyendaCabecera != null && _leyendaCabecera != string.Empty)
					_ticket.AddHeaderLine(_leyendaCabecera); 


				_ticket.AddHeaderLine("C.U.I.T. " + CUITEmpresa ); 
				_ticket.AddHeaderLine(NombreEmpresa.ToUpper() ); 
				_ticket.AddHeaderLine(DireccionEmpresa.ToUpper()); 
				_ticket.AddHeaderLine("INGRESOS BRUTOS " + IngresosBrutosEmpresa); 
				_ticket.AddHeaderLine(CategoriaDeIvaEmpresa.ToUpper() ); 


				//_ticket.AddHeaderLine("MUCHAS GRACIAS POR SU COMPRA !!!!"); 
				//_ticket.AddHeaderLine(_compCompra.Proveedor.Nombre); 
				DateTime  fecha = mz.erp.businessrules.Sistema.DateTime.Now;
				_ticket.AddHeaderLine("Fecha: " + fecha.ToShortDateString() + " " + fecha.ToShortTimeString()); 
				if(_ajustarStock.Signo.Equals("+"))
                    _ticket.AddHeaderLine("Ajuste de Ingreso");
				else _ticket.AddHeaderLine("Ajuste de Egreso");
				
				string responsable = string.Empty;
				DataRow row = mz.erp.businessrules.tsh_Personas.GetByPk(Security.IdPersona);
				if(row != null)
					responsable = Convert.ToString(row["Nombre"]);

				_ticket.AddFooterLine("Resp. " + responsable ); 

				decimal cantArticulos = 0;
				foreach(ItemAjuste item in _ajustarStock.Items)
				{
					string descripcion = item.Descripcion;
					/*
					string codSecundario = item.CodigoSecundario;
					string ali = "";
					foreach(Impuesto imp in item.ImpuestosDirectos)
					{
						ali = ali + "(" + Convert.ToString(Decimal.Round(imp.Alicuota,2)) + ")";
						break;
					}
					*/
					string art = Convert.ToString(Decimal.Round(item.Cantidad,3))+ " " /*+ codSecundario + " "*/ + descripcion /*+ " " + ali*/;
					_ticket.AddItem(Convert.ToString(Decimal.Round(item.Cantidad,3)), art, string.Empty /*Convert.ToString(Decimal.Round(item.PrecioDeCosto,2)) */); 
					cantArticulos = cantArticulos + Decimal.Round(item.Cantidad,3);

				}
			
				//_ticket.AddTotal("TOTAL", Convert.ToString(_compVenta.Total) ); 
				//_ticket.AddTotal("", "" ); //Ponemos un total en blanco que sirve de espacio 
				/*
				_ticket.AddTotal("tarj/cupones",  Convert.ToString(_compVenta.Total) ); 
				_ticket.AddTotal("CAMBIO", "0.00" ); 
				*/
				
				//El metodo AddFooterLine funciona igual que la cabecera 
				_ticket.AddFooterLine("Articulos:" + Convert.ToString(cantArticulos) ); 

				if(_leyendaPie != null && _leyendaPie != string.Empty)
					_ticket.AddFooterLine(_leyendaPie); 
			
				
				//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
				//parametro de tipo string que debe de ser el nombre de la impresora. 
				_ticket.PrintTicket(); 

			}
			#endregion
		}


		#endregion
	}
}
