using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmProductosPreciosController.
	/// </summary>
	public class AbmProductosPreciosController: ITaskController
	{
		private mz.erp.businessrules.AbmProductosPrecios _brClass;
		public AbmProductosPreciosController(AbmProductosPrecios model)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_brClass = model;
		}

		#region Eventos

			public event EventHandler OnControllerHasChanged;

		#endregion
		#region Miembros de ITaskController

		public string GetWarnings()
		{
			// TODO: agregar la implementación AbmProductosPreciosController.GetWarnings
			return null;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public void Continue()
		{
			// TODO: agregar la implementación AbmProductosPreciosController.Continue
		}

		public ItemsDatasetErrors GetErrors()
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

		private ProcessControllerManager _parentProcessController;
		public void SetProcessManager(mz.erp.ui.controllers.ProcessControllerManager processManager)
		{
			_parentProcessController = processManager;
		}

		public mz.erp.ui.controllers.ProcessControllerManager GetProcessManager()
		{
			return _parentProcessController;
		}

		public bool IsFirstTask()
		{
			return false;
		}

		public bool IsNextState()
		{
			return false;
		}

		public bool IsBackState()
		{
			// TODO: agregar la implementación AbmProductosPreciosController.IsBackState
			return false;
		}

		public bool IsFlushedState()
		{
			// TODO: agregar la implementación AbmProductosPreciosController.IsFlushedState
			return false;
		}

		#endregion
		#region custom members
		
		public decimal ValorCotizacionPrecioDeCostoRef
		{
			get{ return _brClass.ValorCotizacionPrecioDeCostoRef;}
		}
		
		public decimal ValorCotizacionPrecioDeVentaNeto
		{
			get{ return _brClass.ValorCotizacionPrecioDeVentaNeto;}
		}

		public string IdFuenteDeCambioPrecioDeCostoRef
		{
			get{ return _brClass.IdMonedaCierrePrecioDeCostoRef;}
			set{_brClass.IdFuenteDeCambioPrecioDeCostoRef = value;}
		}

		public string IdFuenteDeCambioPrecioDeVentaNeto
		{
			get{ return _brClass.IdMonedaCierrePrecioDeVentaNeto;}
			set{_brClass.IdFuenteDeCambioPrecioDeVentaNeto = value;}
		}

		public string IdCotizacionPrecioDeCostoRef
		{
			get { return _brClass.IdCotizacionCierrePrecioDeCostoRef ; }
			
		}
		public string IdCotizacionCierrePreciodeVentaNeto
		{
			get { return _brClass.IdCotizacionCierrePrecioDeVentaNeto; }
			
		}
		public string IdCotizacionCierrePreciodeVentaBruto
		{
			get { return _brClass.IdCotizacionCierrePrecioDeVentaBruto ; }
			
		}

		public string IdMonedaCierreMaximoDescuento
		{
			get { return _brClass.IdMonedaCierrePrecioDeVentaNeto; }
			set { _brClass.IdMonedaCierrePrecioDeVentaNeto = value ;}
		}
		
		public string IdMonedaCierrePrecioDeCostoRef
		{
			get { return _brClass.IdMonedaCierrePrecioDeCostoRef; }
			set { _brClass.IdMonedaCierrePrecioDeCostoRef = value ;}
		}
		public string IdMonedaCierrePrecioDeVentaBruto
		{
			get { return _brClass.IdMonedaCierrePrecioDeVentaBruto ; }
			
		}
		public string IdMonedaCierrePrecioDeVentaNeto
		{
			get { return _brClass.IdMonedaCierrePrecioDeVentaNeto ; }
			set { _brClass.IdMonedaCierrePrecioDeVentaNeto = value;}
		}
		public decimal MAC
		{
			get { return _brClass.MAC ; }
			set { _brClass.MAC = value ; }
		}
		public decimal MaximoDescuento
		{
			get { return _brClass.MaximoDescuento ; }
			
		}
		public decimal MaximoDescuentoPorcentual
		{
			get { return _brClass.MaximoDescuentoPorcentual ; }
			
		}
		public decimal PrecioDeCostoRef
		{
			get { return _brClass.PrecioDeCostoRef ; }
			set { _brClass.PrecioDeCostoRef = value ; }
		}
		public decimal PrecioDeVentaBruto
		{
			get { return _brClass.PrecioDeVentaBruto ; }
			set { _brClass.PrecioDeVentaBruto = value ; }
		}
		public decimal PrecioDeVentaNeto
		{
			get { return _brClass.PrecioDeVentaNeto ; }
			
		}
		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		
		#endregion
	}
}
