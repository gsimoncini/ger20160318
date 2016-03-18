using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;


/// <summary>
/// Clase que contiene definiciones básicas para los comprobantes de venta.
/// </summary>
public abstract class Comprobante : DataObject
{
	#region Constructotres

		public Comprobante()
		{
			
		}

	#endregion

	#region Eventos

		public event EventHandler TotalChanged;
		public event EventHandler IdResponsableChanged;
		public virtual event EventHandler ComprobanteChanged;

	#endregion

	#region Variables Privadas

	private bool _allowEdit = true;
	private bool _temporalNumeration = true;
	
	
	#endregion

	#region Variables Protegidas
		
		protected string _state;
		protected mz.erp.businessrules.comprobantes.CondicionDeVenta _condicionDeVenta;
		protected string _mascara = @"\X-9999-99999999";
		protected string _tipoComprobanteDestino;
		protected string _tipoComprobanteOrigen;
		protected RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino = new RelacionesComprobanteOrigenDestino( );
		protected string _claseComprobante;
		protected short _signoCuentaCorriente;
		protected string _idComprobanteOrigen;
		protected string _idComprobante;
		protected int _signo = 1;
		protected System.DateTime _fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
		protected string _numero = string.Empty;
		protected string _observaciones = string.Empty;
		protected string _numeroOrigen = String.Empty;
		protected string _idInstanciaCaja;
		protected decimal _total;
		protected string _idMonedaCierre;
		protected string _IdResponsable = string.Empty;
		protected string _idCuenta;
		protected string _codigoCuenta;		
		protected decimal _saldo;
		protected decimal _recargoFinancieroPorCondicionDeVenta = 0;
		protected decimal _recargoFinancieroPorFormaDePago = 0;

	#endregion

	#region Variables Publicas
			
		public tsa_ComprobantesExDataset DatasetComprobante;
		public VariablesAuxiliares VariablesComprobante;
	
	#endregion

	#region Propiedades

		public bool AllowEdit
		{
			set	{_allowEdit = value;}
			get	{return _allowEdit; }
		}

		
		public bool TemporalNumeration
		{
			set{_temporalNumeration = value;}
			get{return _temporalNumeration; }
		}
		public mz.erp.businessrules.comprobantes.CondicionDeVenta CondicionDeVenta
		{
			get{return _condicionDeVenta;}
			set
			{	
				_condicionDeVenta = value;
				if (TotalChanged != null)
					TotalChanged(this,new EventArgs());	

			}
		}

		public short SignoCuentaCorriente
		{
			get	{return _signoCuentaCorriente;}
		}

		public virtual decimal Saldo
		{
			get{return _saldo;}
			set{_saldo  = value;}
		}
		public string IdComprobante
		{
			get {return _idComprobante;}
			set {_idComprobante = value;}
		}

		public string IdComprobanteOrigen
		{
			get {return _idComprobanteOrigen;}
			set {_idComprobanteOrigen = value;}
		}

		public string IdComprobanteDestino
		{
			get {return _idComprobante;}	
		}

		public virtual string IdCuenta
		{
			get {return _idCuenta;}
			set {_idCuenta = value;}
		}

		public virtual string CodigoCuenta
		{
			get {return _codigoCuenta;}
			set	{_codigoCuenta = value;}
		}

		public string IdInstanciaCaja
		{
			get {return _idInstanciaCaja;}
			set 
			{
				if(_idInstanciaCaja != value)
					_idInstanciaCaja = value;
			}
		}

		public virtual decimal Total
		{
			get {return _total;}
			set 
			{
				_total = value;
				if (TotalChanged != null)
					TotalChanged(this,new EventArgs());	
			}
		}

		public string IdMonedaCierre
		{
			get {return _idMonedaCierre;}
			set {_idMonedaCierre = value;}
		}

		public virtual string IdResponsable
		{
			get{return _IdResponsable;}
			set 
			{
				if(_IdResponsable != value)
				{
					_IdResponsable = value;
					if(IdResponsableChanged != null)
						IdResponsableChanged(this, EventArgs.Empty);
				}

			}
		}


		public string Numero
		{
			get{return _numero;}
			set{_numero = value;}
		}

		public string NumeroOrigen
		{
			get{return _numeroOrigen;}
			set{_numeroOrigen = value;}
		}

		public virtual string Mascara
		{
			set	{_mascara = value; }
			get {return _mascara ; }
		}

		public virtual string TipoComprobanteOrigen
		{
			set {_tipoComprobanteOrigen = value; }
			get {return _tipoComprobanteOrigen ; }
		}

		public virtual string TipoComprobanteDestino
		{
			set 
			{	_tipoComprobanteDestino = value; 
				this.SetDirty(true);
			}
			get { return _tipoComprobanteDestino ; }
		}

		public System.DateTime FechaComprobante
		{
			set 
			{	
				_fechaComprobante = mz.erp.systemframework.Util.AddTime(value, mz.erp.businessrules.Sistema.DateTime.Now);
			}   
			get {return _fechaComprobante;}
		}

		public ArrayList VariablesDeUsuario
		{
			get 
			{
				if(this.VariablesComprobante != null)
					return this.VariablesComprobante.VariablesDeUsuario;
				else 
					return new ArrayList();
			}
		}
		public ArrayList VariablesDeSistema
		{
			get 
			{
				if(this.VariablesComprobante != null)
					return this.VariablesComprobante.VariablesDeSistema;
				else 
					return new ArrayList();
			}
		}
		public int Signo
		{
			get{return _signo;}
			set{_signo = value;}
		}
		public virtual decimal RecargoFinancieroPorCondicionDeVenta
		{
			get	{return _recargoFinancieroPorCondicionDeVenta;}
			set	{_recargoFinancieroPorCondicionDeVenta = value;}
		}

		public virtual decimal RecargoFinancieroPorFormaDePago
		{
			get	{return _recargoFinancieroPorFormaDePago;}
			set	{_recargoFinancieroPorFormaDePago = value;}
		}




	#endregion

	#region Metodos 

		protected virtual void Init()
		{
			//_uiController.OnTaskAfterExecute += new EventHandler(this.OnFinaliza);		
			//_uiController.OnModelChanged += new EventHandler(this.OnChangeEstadoFiscal);
		}
		
		public virtual void SetDirty(bool value)
		{

		}

	#endregion
	
	
	
	
	


	

	

	
	
}
