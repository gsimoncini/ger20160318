using System;
using System.Text;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmGastosBancariosController.
	/// </summary>
	public class AbmGastosBancariosController: IObservable
	{

		public AbmGastosBancariosController(AbmGastosBancarios brClass)
		{
			_brClass = brClass;
		}

		public AbmGastosBancariosController()
		{
			_brClass = new AbmGastosBancarios();
		}

		public AbmGastosBancariosController(string Proceso, string Estado)
		{
			_brClass = new AbmGastosBancarios();
			_brClass.Init(Proceso);
			_brClass.Estado = Estado;
		}

		private AbmGastosBancarios _brClass;



		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			foreach(IObserver observer in _observers)
			{
				Movimiento.Editado = true;
				observer.UpdateObject(this, Movimiento);
			}
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}

		#endregion

		private string _idProceso = string.Empty;
		public string Proceso
		{
			set {_idProceso = value;}
			get {return _idProceso;}
		}

		#region Propiedades

		public string IdBanco
		{
			set {_brClass.IdBanco = value;}
			get {return _brClass.IdBanco;}
		}

		public string IdBancoSucursal
		{
			set {_brClass.IdBancoSucursal = value;}
			get {return _brClass.IdBancoSucursal;}
		}

		public string IdCuentaBancaria
		{
			set {_brClass.IdCuentaBancaria = value;}
			get {return _brClass.IdCuentaBancaria;}
		}

		public string IdMoneda
		{
			set {_brClass.IdMoneda = value;}
			get {return _brClass.IdMoneda;}
		}

		public DateTime FechaImputacion 
		{
			set {_brClass.FechaImputacion = value;}
			get {return _brClass.FechaImputacion;}
		}

		public decimal Monto 
		{
			set {_brClass.Monto = value;}
			get {return _brClass.Monto;}
		}

		public string IdResponsable
		{
			set {_brClass.IdResponsable = value;}
			get {return _brClass.IdResponsable;}
		}

		public TiposMovimientosBancarios TiposMovimientos
		{
			get {return _brClass.TiposMovimientos;}
		}

		#endregion

		private MovimientoBancarioView _movimiento = new MovimientoBancarioView();
		public MovimientoBancarioView Movimiento
		{
			set {_movimiento = value;}
			get {return _movimiento;}
		}

		public string LeyendaFormulario
		{
			get {return _brClass.LeyendaFormulario;}
		}

		public bool HabilitarResponsable
		{
			get {return _brClass.HabilitarResponsable;}
		}

		public bool HabilitarBanco
		{
			get {return _brClass.HabilitarBanco;}
		}

		public bool HabilitarSucursal
		{
			get {return _brClass.HabilitarSucursal;}
		}

		public bool HabilitarCuenta
		{
			get {return _brClass.HabilitarCuenta;}
		}

		public bool HabilitarMoneda
		{
			get {return _brClass.HabilitarMoneda;}
		}

		public bool HabilitarFechaImputacion
		{
			get {return _brClass.HabilitarFechaImputacion;}
		}

		public bool HabilitarObservaciones
		{
			get {return _brClass.HabilitarObservaciones;}
		}			

		public bool HabilitarMonto
		{
			get {return _brClass.HabilitarMonto;}
		}	

		public bool HabilitarTiposMovimientos
		{
			get {return _brClass.HabilitarTiposMovimientos;}
		}	

		#region Combos

		// -------------------- Combo Bancos
		public DataTable Bancos
		{
			get{return _brClass.Bancos;}
		}

	
		public string KeyValueBanco
		{
			get { return "IdBanco" ; }
		}		
		
		public string KeyListBanco
		{
			get { return "Nombre" ; }
		}

		// -------------------- Combo BancoSucursal
		public DataTable BancoSucursal
		{
			get{return _brClass.BancoSucursal;}
		}

		public string KeyValueBancoSucursal
		{
			get { return "IdBancoSucursal" ; }
		}		
		
		public string KeyListBancoSucursal
		{
			get { return "LocalidadYDireccion" ; }
		}

		// -------------------- Combo CuentaBancaria

		public DataTable CuentasBancarias
		{
			get {return _brClass.CuentasBancarias;}
		}

		public string KeyValueCuenta
		{
			get { return "IdCuenta" ; }
		}		
		
		public string KeyListCuenta
		{
			get { return "NroCuenta" ; }
		}

		// -------------------- Combo Monedas
		public DataTable Monedas
		{
			get{return _brClass.Monedas;}
		}

		public string KeyValueMoneda
		{
			get { return "IdMoneda" ; }
		}		
		
		public string KeyListMoneda
		{
			get { return "Descripcion" ; }
		}

		#endregion

	}
}
