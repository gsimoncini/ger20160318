using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de PagoCuentaCorrienteController.
	/// </summary>
	public class ComprobantesDePagoController:ISearchObjectListener,ITaskController, IObserver	
	{
		
		#region Constructores
		
		public ComprobantesDePagoController()
		{
			_comprobanteDePago = new ComprobanteDePago();
			Init();
		}

		public ComprobantesDePagoController(ComprobanteDePago comprobante)
		{
			_comprobanteDePago = comprobante;
			Init();
		}
		#endregion

		#region Variables Privadas
				
			private ComprobanteDePago _comprobanteDePago;
			private string _leyendaFormulario = string.Empty;
			private string _layoutDataCompAImputar = new mz.erp.ui.controllers.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota", "FechaEmision","FechaVencimiento","Numero", "SaldoSinSigno","Signo","ImporteSinSigno","Pago"});
			private System.Data.DataTable _tableComprobantesDePago;
			private ArrayList _cotizaciones = new ArrayList();
			private string _layoutValores = new mz.erp.ui.controllers.tfi_ValoresEx().GetLayoutValores();
			private string _observaciones = "";
			private string _numero = "";
			private string _idResponsable = string.Empty;
			private bool _uiClosed = false;		
			private string _ultimoResponsableClaveCorrecta = "";
			
			

		#endregion

		#region Variables y Propiedades Publicas

		public bool AllowSearchValores
		{
			get{return _comprobanteDePago.AllowSearchValores;}
		}

		public bool AskForPasswordResponsableEmision
		{
			get { return this._comprobanteDePago.AskForPasswordResponsableEmision; }			
		}

		public string UltimoResponsableClaveCorrecta
		{
			get 
			{
				return _ultimoResponsableClaveCorrecta;
			}
			set 
			{
				_ultimoResponsableClaveCorrecta = value;
			}		
		}	

		public string Mascara
		{
			get{return _comprobanteDePago.Mascara;}
		}

		public decimal Saldo
		{
			get
			{
				return _comprobanteDePago.Saldo;
			}
		}
		public DateTime FechaComprobante
		{
			get{ return _comprobanteDePago.FechaComprobante;}
			set{_comprobanteDePago.FechaComprobante = value;}
		}
		
		public ArrayList Valores
		{
			get
			{
				return _comprobanteDePago.Valores.MisValores;
			}
			set
			{
				_comprobanteDePago.Valores.MisValores = value;
			}
			
		}

		public decimal Total 
		{
			get
			{
				return _comprobanteDePago.Total;
			}
			set
			{
				_comprobanteDePago.Total = value;
			}
		}

		public string LayoutValores
		{
			get
			{
				return _layoutValores;
			}
		}
		
		public string LayoutDataCompAImputar
		{
			get
			{	
				return _layoutDataCompAImputar;
			}
		}

		public DataTable  InstanciasCajasAbiertas
		{

			get{return _comprobanteDePago.InstanciasCajasAbiertas;}
		}

		public string IdInstanciaDeCaja
		{
			get
			{
				return _comprobanteDePago.IdInstanciaCaja;
			}
			set
			{
				_comprobanteDePago.IdInstanciaCaja = value;
			}
		}

		public DataTable TiposDeComprobantesDePago
		{
			get
			{
				return _tableComprobantesDePago;
			}
		}

		public string IdCuenta 
		{
			get
			{
				return _comprobanteDePago.IdCuenta;
			}
			set
			{
				_comprobanteDePago.IdCuenta = value;
			}
		}

		public string CodigoCuenta
		{
			get
			{
				return _comprobanteDePago.CodigoCuenta;
			}
			set
			{
				_comprobanteDePago.CodigoCuenta = value;
			}
		}

		public decimal TotalImputado
		{
			get
			{
				return _comprobanteDePago.CuentaCorriente.TotalImputado;
			}
			set
			{
				_comprobanteDePago.CuentaCorriente.TotalImputado = value;
			}
		}

        //German 20120125 - Tarea 0000256
        public decimal SaldoAImputar
        {
            get
            {
                return _comprobanteDePago.CuentaCorriente.SaldoAImputar;
            }

        }
        //Fin German 20120125 - Tarea 0000256

		public ArrayList DetalleCuentaCorriente
		{
			get
			{
				return _comprobanteDePago.CuentaCorriente.Detalle;
			}
			set
			{
				_comprobanteDePago.CuentaCorriente.Detalle = value;
			}
		}
			
		public ArrayList DataValoresEx
		{
			get 
			{
				return _comprobanteDePago.Valores.MisValores;
			}
		}

		public string IdResponsable
		{
			get
			{	
				return _idResponsable;
			}
			set
			{
				    if(_idResponsable!= value)
				{
					_idResponsable = value;
					if(IdResponsableChanged != null)
						IdResponsableChanged(this, new EventArgs());
				}
			}
		}

		public string TipoDeComprobante
		{
			get
			{
				return _comprobanteDePago.TipoComprobanteDestino;
			}
			set
			{
				_comprobanteDePago.TipoComprobanteDestino = value;
			}
		}

		public string Observaciones
		{
			set 
			{ 
				if(value != this._comprobanteDePago.Observaciones)
				{
					_observaciones = value ; 
					this._comprobanteDePago.Observaciones = value;
					if(ObservacionesChanged != null)
					{
						ObservacionesChanged(this, new EventArgs());
					}					
				}
			}
			get { return _comprobanteDePago.Observaciones; }
		}

		public string Numero
		{
			set 
			{ 
				if(value != this._comprobanteDePago.Numero)
				{
					_numero = value ; 
					this._comprobanteDePago.Numero = value;
					if(NumeroChanged != null)
					{
						NumeroChanged(this, new EventArgs());
					}					
				}
			}
			get { return _comprobanteDePago.Numero; }
		}

		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario ; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _comprobanteDePago.PreguntarAlCancelar;}
		}

		public bool AllowEditInstanciaDeCaja
		{
			get{return _comprobanteDePago.AllowEditInstanciaDeCaja;}
		}


		public bool AllowEditValores
		{
			get
			{
				return this._comprobanteDePago.AllowEditValores;
			}
		}

		public bool AllowEditTipoDeComprobante
		{
			
			get
			{ 
				return this._comprobanteDePago.AllowEditTipoDeComprobante;
			}
		}



		public bool AllowEditCuenta
		{
			get
			{ 
				return this._comprobanteDePago.AllowEditCuenta;
			}
		}

		public bool AllowEditFecha
		{
		
			get 
			{
				return this._comprobanteDePago.AllowEditFecha;
			}
		}

		public bool AllowEditResponsableEmision
		{
			
			get
			{ 
				return this._comprobanteDePago.AllowEditResponsableEmision;
			}
		}

		public bool AllowEditFormasDePago
		{
			
			get
			{ 
				return this._comprobanteDePago.AllowEditFormasDePago;
			}
		}

		

		public bool AllowEditNumeration
		{
			
			get
			{ 
				return this._comprobanteDePago.AllowEditNumeration;
			}
		}

		public bool AllowEditImputacion 
		{		
			get
			{		
				return this._comprobanteDePago.AllowEditImputacion;
			}

		}
		
		public string TextoBotonSiguiente
		{
			get { return _comprobanteDePago.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _comprobanteDePago.TextoBotonAnterior; }
		}

        //Sabrina: Tarea 1117. 20110816
        public bool AllowEditImputaAutomaticamente
        {
            get { return _comprobanteDePago.AllowEditImputaAutomaticamente; }
        }

        public bool ImputaAutomaticamente
        {
            get { return _comprobanteDePago.ImputaAutomaticamente; }
            set { _comprobanteDePago.ImputaAutomaticamente = value; }
        }
        //Fin Sabrina: Tarea 1117. 20110816

		#endregion

		#region Eventos y Delegados
			
			public event EventHandler ValoresChanged;
			public event EventHandler TotalChanged;
			public event EventHandler IdInstanciaDeCajaChanged;
			public event EventHandler IdCuentaChanged;
			public event EventHandler CodigoCuentaChanged;
            //German 20120125 - Tarea 0000256
            public event EventHandler SaldoAImputarChanged;
            //Fin German 20120125 - Tarea 0000256
			public event EventHandler TotalImputadoChanged;
			public event EventHandler DetalleCuentaCorrienteChanged;
			public event EventHandler DataValoresExChanged;
			public event EventHandler IdResponsableChanged;
			public event EventHandler ObservacionesChanged;
			public event EventHandler NumeroChanged;		
			public event EventHandler TipoDeComprobanteChanged;
			public event EventHandler OnTaskAfterExecute;
			public event EventHandler OnTaskBeforExecute;
			public event EventHandler ResponsableDeEmisionChanged;
			public event EventHandler SaldoChanged;

			//public event EventHandler OnControllerChanged;

			public event EventHandler ComprobanteHasChanged;
            //German 20120510 - Tarea 0000323
            public event EventHandler NumeroSugeridoChanged;
            //Fin German 20120510 - Tarea 0000323



		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			
			if (this.ComprobanteHasChanged != null)
				this.ComprobanteHasChanged(null, new System.EventArgs() );
				
			
		}
	
		#endregion

		#region Metodos Privados
				
		private void Init()
		{
			InitializeData();
			InitEventHandlers();		
		}

		private void InitializeData()
		{
			if(_comprobanteDePago.IdInstanciaCaja == null || _comprobanteDePago.IdInstanciaCaja.Equals(string.Empty))
				_comprobanteDePago.IdInstanciaCaja = mz.erp.businessrules.tfi_Cajas.GetInstanciaAbiertaDeCaja(Security.IdPersona,Variables.GetValueString("Cajas.Default"));
			_tableComprobantesDePago = businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,null).tsy_TiposDeComprobantes;
			string comprobantesDePago = Variables.GetValueString("Comprobantes.ComprobantesDePago");
			_tableComprobantesDePago = this.FilterComprobantes(comprobantesDePago,_tableComprobantesDePago );	
			_numero = _comprobanteDePago.Numero;

			//mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones( _cotizaciones,_comprobanteDePago.IdMonedaCierre);
			SetLeyendaFormulario();
		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._comprobanteDePago.GetProcessManagerParent().Process.ProcessName, this._comprobanteDePago.GetTaskName(), "LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._comprobanteDePago.GetTaskName();
			}
			this._leyendaFormulario = leyenda;

		}
		private void InitEventHandlers()
		{
			BindingController.Bind(this,"IdResponsable", _comprobanteDePago,"IdResponsable");
			
			_comprobanteDePago.ObjectHasChanged +=new EventHandler(_comprobanteDePago_ObjectHasChanged);
			_comprobanteDePago.OnTaskAfterExecute +=new EventHandler(_comprobanteDePago_OnTaskAfterExecute);
             //German 20120125 - Tarea 0000256
            _comprobanteDePago.SaldoAImputarChanged += new EventHandler(_comprobanteDePago_SaldoAImputarChanged);
            //Fin German 20120125 - Tarea 0000256
            //German 20120510 - Tarea 0000323
            _comprobanteDePago.NumeroSugeridoChanged += new EventHandler(_comprobanteDePago_NumeroSugeridoChanged);
            //Fin German 20120510 - Tarea 0000323

		}
        //German 20120510 - Tarea 0000323
        void _comprobanteDePago_NumeroSugeridoChanged(object sender, EventArgs e)
        {
            if (NumeroSugeridoChanged != null)
                NumeroSugeridoChanged(this, EventArgs.Empty);
        }
        //Fin German 20120510 - Tarea 0000323
        //German 20120125 - Tarea 0000256
        void _comprobanteDePago_SaldoAImputarChanged(object sender, EventArgs e)
        {
            if (SaldoAImputarChanged != null)
                SaldoAImputarChanged(this, EventArgs.Empty);
        }
        //German 20120125 - Tarea 0000256

		private void _comprobanteDePago_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}

		private System.Data.DataTable FilterComprobantes(string comprobantesCuentaCorriente,System.Data.DataTable tableParam )
		{
			System.Data.DataTable table = new System.Data.DataTable();
			table.Columns.Add("IdTipoDeComprobante");
			table.Columns.Add("Descripcion");
			ArrayList aux = mz.erp.systemframework.Util.Parse(comprobantesCuentaCorriente,",");
			foreach(System.Data.DataRow row in tableParam.Rows)
			{
				if(aux.Contains(row["IdTipoDeComprobante"]))
					table.ImportRow(row);
				
			}

			return table;
		}

		public void Close()
		{
			_uiClosed = true;
		}
		public void Recalcular() 
		{
			_comprobanteDePago.Recalcular();
		}

		private void CallRefresh()
		{
			if(!_uiClosed)
			{
				if(ValoresChanged != null)
					ValoresChanged(this, new EventArgs());
				if(TotalChanged != null)
					TotalChanged(this, new EventArgs());
				if(IdInstanciaDeCajaChanged != null)
					IdInstanciaDeCajaChanged(this, new EventArgs());
				if(IdCuentaChanged != null)
					IdCuentaChanged(this, new EventArgs());
				if(CodigoCuentaChanged != null)
					CodigoCuentaChanged(this, new EventArgs());
				if(TotalImputadoChanged != null)
					TotalImputadoChanged(this, new EventArgs());
                //German 20120125 - Tarea 0000256
                if (SaldoAImputarChanged != null)
                    SaldoAImputarChanged(this, EventArgs.Empty);
                //Fin German 20120125 - Tarea 0000256
        
				if(DetalleCuentaCorrienteChanged != null)
					DetalleCuentaCorrienteChanged(this, new EventArgs());
				if(DataValoresExChanged != null)
					DataValoresExChanged(this, new EventArgs());
				if(IdResponsableChanged != null)
					IdResponsableChanged(this, new EventArgs());
				if(TipoDeComprobanteChanged != null)
					TipoDeComprobanteChanged(this, new EventArgs());
				if(SaldoChanged != null)
					SaldoChanged(this, new EventArgs());
				if(ComprobanteHasChanged != null)
					ComprobanteHasChanged(this, new EventArgs());
			}

		}

		#endregion

		#region Metodos Publicos
		
	
		public decimal GetMontoValores()
		{
			return this.TotalImputado - this.Total;
		}

		public void ClearResponsableDeEmision() 
		{						
			_comprobanteDePago.IdResponsable = ""; 
			if(ResponsableDeEmisionChanged != null)
				ResponsableDeEmisionChanged(this , new EventArgs());
		}
		
		/*
		public void GetCuentaCorriente()
		{

			
				
			
		}

		*/

		public void RefreshValores(System.Data.DataSet data, Valor valor)
		{
			_comprobanteDePago.RefreshValores(data, valor);
		}

		/* public void UpdatePago(object selectedRow)
		{
			DetalleCuentaCorriente dcc = (DetalleCuentaCorriente) selectedRow;
			dcc.Pago = dcc.Saldo*dcc.Signo;
		}*/

		public void UpdatePago(object selectedRow)
		{
			_comprobanteDePago.UpdatePago(selectedRow);
		}

		public string NombreClientePaso
		{
			set 
			{
				_comprobanteDePago.NombreCliente = value;
			}
			get 
			{
				return _comprobanteDePago.NombreCliente;
			}
		}

		public string Cuenta
		{
			set 
			{ 
				if ( _comprobanteDePago.AllowEditCuenta )
				{
					_comprobanteDePago.CodigoCuenta = value ; 
				}
			}
			get { return _comprobanteDePago.CodigoCuenta;} 
		}

		/*public bool DatosCuentaChanged
		{
			set{_comprobanteDePago.DatosCuentaChanged = value;}
		}*/

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación PagoCuentaCorrienteController.processEventChange
		}

		#endregion

		#region Miembros de ITaskController

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

		public string GetTaskName()
		{
			return _comprobanteDePago.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_comprobanteDePago.GetTaskName());
		}
		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		
		public bool AllowPrevious()
		{
			return _comprobanteDePago.AllowPrevious();
		}

		public void Previous()
		{
			_comprobanteDePago.Previous();
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación PagoCuentaCorrienteController.GetErrors
			return _comprobanteDePago.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}


		public void Execute()
		{
			_comprobanteDePago.Execute();
		}
		public bool AllowShow()
		{
			//return false;
			return this._comprobanteDePago.AllowShow();
		}

		#endregion

		private void _comprobanteDePago_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		public ValoresController GetValoresController()
		{
			bool _agrupado = true; 
			string tdcomp = _comprobanteDePago.TDCompTesoreriaDefault();
			string moneda = _comprobanteDePago.MonedaDefault();
			ValoresController valorescontroller = new ValoresController(tdcomp, moneda, _agrupado, null, this);
			//seteo valores por defecto para la ventana de valores
			valorescontroller.AllowEditTDCompTesoreria = true;			
			valorescontroller.IdTDCompTesoreriaReadOnly = false;		
			valorescontroller.AllowEditMoneda = true;					
			valorescontroller.IdMonedaOrigenReadOnly = false;			
			
			return valorescontroller;
		}

		public string TaskName()
		{
			return _comprobanteDePago.GetTaskName();
		}

		public bool AllowPrintItem()
		{
			return true;
		}

		public string FillNumberWithZeros(string txt)
		{
			return _comprobanteDePago.FillNumberWithZeros(txt);
		}

		public bool RenombraClienteDePaso
		{
			get{return _comprobanteDePago.RenombraClienteDePaso;}
		}

		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  Variables.GetValueBool(this._comprobanteDePago.GetProcessManagerParent().Process.ProcessName, this._comprobanteDePago.GetTaskName(), "Cuenta.HabilitaBotonCtaCte", true);
			}				
		}
	
		#region Miembros de IObserver

		public void UpdateObject(object observable, object valores)
		{
			if(valores.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.Valor)))
			{
				Valor valor = (Valor) valores;
				if ( valor.DatoAuxiliar.IdTipoDeRetencion != string.Empty )
				{
					string tipoRet = tsy_TiposDeRetenciones.GetByPk(valor.DatoAuxiliar.IdTipoDeRetencion).Descripcion;
					valor.Comprobante = valor.Comprobante + " ("+ tipoRet + ")";
				}
				if(!_comprobanteDePago.Contains(valor))
				{
					_comprobanteDePago.AddValor( valor );
				}
			}
			ListenerObjectHasChanged(this._comprobanteDePago, null);
			if(valores.GetType().Equals(typeof(System.Collections.ArrayList)))
			{
				ArrayList result = (ArrayList) valores;
				foreach(Valor valor in result)
				{
					if(!_comprobanteDePago.Contains(valor))
					{
						_comprobanteDePago.AddValor( valor );
					}
				}
				ListenerObjectHasChanged(this._comprobanteDePago, null);
			}
		}

		#endregion
	}
}
