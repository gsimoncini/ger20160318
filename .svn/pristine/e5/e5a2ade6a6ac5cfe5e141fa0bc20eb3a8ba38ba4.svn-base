using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de IngresarComprobanteDePagoComprasController.
	/// </summary>
	public class IngresarComprobanteDePagoComprasController: ITaskController, ISearchObjectListener, IObserver
	{
		
		#region Constructores

		public IngresarComprobanteDePagoComprasController(IngresarComprobanteDePagoCompras BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		#endregion

		#region Propiedades

		public decimal Saldo
		{
			get{return _brClass.Saldo;}
		}


		public ArrayList Valores
		{
			get{return _brClass.Valores;}
		}

		
		public string Observaciones
		{
			get{return _brClass.Observaciones;}
			set{_brClass.Observaciones = value;}
		}

		public string Numero
		{
			get{ return _brClass.Numero; }
			set{ _brClass.Numero = value; }
		}

		public string IdResponsable
		{
			get{return _brClass.IdResponsable;}
			set{_brClass.IdResponsable = value;}
		}

		public string TipoDeComprobante
		{
			get{return _brClass.TipoComprobanteDestino;}
			set{_brClass.TipoComprobanteDestino = value;}
		}


		
		

		public decimal Total 
		{
			get{return _brClass.Total;}
		}

		
		public string Mascara
		{
			get{return _brClass.Mascara;}
		}

		public DateTime FechaComprobante
		{
			get{return _brClass.FechaComprobante;}
			set{_brClass.FechaComprobante = value;}
		}

		public string IdInstanciaCaja
		{
			get{return _brClass.IdInstanciaCaja;}
			set{_brClass.IdInstanciaCaja = value;}
		}

		public string IdProveedor
		{
			get{return _brClass.IdProveedor;}
		}
	
		public string CodigoProveedor
		{
			get{return _brClass.CodigoProveedor;}
			set{_brClass.CodigoProveedor = value;}
		}

		public string NombreProveedor
		{
			get{return _brClass.NombreProveedor;}
		}

		public decimal TotalImputado
		{
			get{return _brClass.TotalImputado;}
		}

		public mz.erp.businessrules.CuentaCorriente CuentaCorriente
		{
			get{return _brClass.CuentaCorriente;}
			
		}

		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario ; }
		}

		public bool PreguntarAlCancelar
		{
			get	{return _brClass.PreguntarAlCancelar;}
		}

		public string UltimoResponsableClaveCorrecta
		{
			get{return _ultimoResponsableClaveCorrecta;}
			set{_ultimoResponsableClaveCorrecta = value;}		
		}	

		public bool AskForPasswordResponsableEmision
		{
			get { return this._brClass.AskForPasswordResponsableEmision; }			
		}

		public bool AllowSearchValores
		{
			get{return _brClass.AllowSearchValores;}
		}

		public bool AllowEditInstanciaDeCaja
		{
			get{return _brClass.AllowEditInstanciaDeCaja;}
		}


		public bool AllowEditValores
		{
			get{return this._brClass.AllowEditValores;}
		}

		public bool AllowEditTipoDeComprobante
		{
			get{ return this._brClass.AllowEditTipoDeComprobante;}
		}

		public bool AllowEditProveedor
		{
			get{return this._brClass.AllowEditProveedor;	}
		}

		public bool AllowEditFecha
		{		
			get{return this._brClass.AllowEditFecha;}
		}

		public bool AllowEditResponsableEmision
		{
			get{ return this._brClass.AllowEditResponsableEmision;}
		}

		public bool AllowEditNumeration
		{
			get{ return this._brClass.AllowEditNumeration;}
		}

		public bool AllowEditImputacion 
		{		
			get{return this._brClass.AllowEditImputacion;}

		}
		
		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public DataTable TiposDeComprobantesDePago
		{
			get{return _brClass.TiposDeComprobantesDePago;}
		}

		public DataTable  InstanciasCajasAbiertas
		{

			get{return _brClass.InstanciasCajasAbiertas;}
		}

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}

        //Sabrina: Tarea 1120. 20110817
        public bool AllowEditImputaAutomaticamente
        {
            get { return _brClass.AllowEditImputaAutomaticamente; }
        }

        public bool ImputaAutomaticamente
        {
            get { return _brClass.ImputaAutomaticamente; }
            set { _brClass.ImputaAutomaticamente = value; }
        }
        //Fin Sabrina: Tarea 1120. 20110817

        #endregion
		
		#region Variables Privadas

			private IngresarComprobanteDePagoCompras _brClass;
			private ProcessControllerManager _processManager;
			private string _leyendaFormulario = string.Empty;
			private string _ultimoResponsableClaveCorrecta = string.Empty;

		#endregion

		#region Eventos

			public event EventHandler ResponsableDeEmisionChanged;
			public event EventHandler IdResponsableChanged;
			public event EventHandler NumeroChanged;	
			public event EventHandler TotalChanged;	
			public event EventHandler SaldoChanged;
			public event EventHandler TotalImputadoChanged;	
			public event EventHandler ComprobanteHasChanged;

		#endregion

		#region Metodos Privados

		private void _brClass_TotalImputadoChanged(object sender, EventArgs e)
		{
			if(TotalImputadoChanged != null)
				TotalImputadoChanged(this, new EventArgs());
			if(SaldoChanged != null)
				SaldoChanged(this, new EventArgs());
		}

		private void Init()
		{
			_brClass.TotalImputadoChanged +=new EventHandler(_brClass_TotalImputadoChanged);
			_brClass.TotalChanged +=new EventHandler(_brClass_TotalChanged);
			SetLeyendaFormulario();
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);

		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;

		}

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			
			if (this.ComprobanteHasChanged != null)
				this.ComprobanteHasChanged(sender, new System.EventArgs() );
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
			if(SaldoChanged != null)
				SaldoChanged(this, new EventArgs());

				
			
		}
		

		#endregion
		
		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		
		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación IngresarComprobanteDePagoComprasController.processEventChange
		}

		#endregion

		#region Metodos Publicos

		public void CalcularRetenciones()
		{
			_brClass.CalcularRetenciones();
		}

		public void Recalcular() 
		{
			_brClass.Recalcular();
		}


		public void ClearResponsableDeEmision() 
		{						
			_brClass.IdResponsable = string.Empty; 
			if(ResponsableDeEmisionChanged != null)
				ResponsableDeEmisionChanged(this , new EventArgs());
		}

		public void UpdatePago(object selectedRow)
		{
			_brClass.UpdatePago(selectedRow);
		}

		public ValoresController GetValoresController()
		{
			bool _agrupado = true; 
			string tdcomp = "4";
			string moneda = "1";
			ValoresController valorescontroller = new ValoresController(tdcomp, moneda, _agrupado, null, this);
			//seteo valores por defecto para la ventana de valores
			valorescontroller.AllowEditTDCompTesoreria = true;			
			valorescontroller.IdTDCompTesoreriaReadOnly = false;		
			valorescontroller.AllowEditMoneda = true;					
			valorescontroller.IdMonedaOrigenReadOnly = false;			
			return valorescontroller;
		}

		public bool IsEditable(object selectedItem, string property)
		{
			return true;
		}

		public bool IsRemovable(object selectedItem)
		{
			return _brClass.IsRemovable(selectedItem);
		}

		public ValoresController GetValoresController(Valor valor)
		{
			ValoresController valorescontroller = new ValoresController(valor, 0,valor.Monto, this);
			//valorescontroller.ReglasDeValidacionAuxiliares = _recargos.ReglasDeValidacion;
			return valorescontroller;
		}

		public string FillNumberWithZeros(string txt)
		{
			return _brClass.FillNumberWithZeros(txt);
		}


		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			
			if(valores.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.Valor)))
			{
				Valor valor = (Valor) valores;
				if ( valor.DatoAuxiliar.IdTipoDeRetencion != string.Empty )
				{
					string tipoRet = tsy_TiposDeRetenciones.GetByPk(valor.DatoAuxiliar.IdTipoDeRetencion).Descripcion;
					valor.Comprobante = valor.Comprobante + " ("+ tipoRet + ")";
				}
				if(!_brClass.ContainsValor(valor))
				{
					_brClass.AddValor( valor );
				}
			}
			ListenerObjectHasChanged(this, null);
			
			if(valores.GetType().Equals(typeof(System.Collections.ArrayList)))
			{
				ArrayList result = (ArrayList) valores;
				foreach(Valor valor in result)
				{
					if(!_brClass.ContainsValor(valor))
					{
						_brClass.AddValor( valor );
					}
				}
				ListenerObjectHasChanged(this, null);
			}
			
		}

		#endregion

		private void _brClass_TotalChanged(object sender, EventArgs e)
		{
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
			if(SaldoChanged != null)
				SaldoChanged(this, new EventArgs());
		}
	}
}
