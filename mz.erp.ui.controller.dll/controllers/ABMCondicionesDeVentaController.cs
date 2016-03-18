using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMCondicionesDeVentaController.
	/// </summary>
	public class ABMCondicionesDeVentaController:ITaskController
	{

		#region Contructores

		public ABMCondicionesDeVentaController(ABMCondicionesDeVenta model)
		{
			_brClass = model;
			//model.ObjectHasChanged+= new System.EventHandler(this.ListenerModelChanges );
			Init();
		}

		private void Init()
		{
		}
		
		#endregion

		#region Propiedades

		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}
		public string ContenedoresHabilitados
		{
			get{return _brClass.ContenedoresHabilitados;}
		}

		public string IdCondicionDeVenta
		{
			get{return _brClass.IdCondicionDeVenta;}
			set 
			{
				_brClass.IdCondicionDeVenta = value;
			}
		}
		
		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set 
			{
				_brClass.Descripcion = value;
			}
		}

		public Decimal Recargo
		{
			get{return _brClass.Recargo;}
			set 
			{
				_brClass.Recargo = value;
			}
		}

		public short DiasDeVencimiento
		{
			get{return _brClass.DiasDeVencimiento;}
			set 
			{
				_brClass.DiasDeVencimiento = value;
			}
		}

		/*public string MetodoDeAsignacion
		{
			get{return _brClass.MetodoDeAsignacion;}
			set 
			{
				_brClass.MetodoDeAsignacion = value;
			}
		}*/

		public string MetodoDeAsignacionTipoDeComprobante
		{
			get{return _brClass.MetodoDeAsignacionTipoDeComprobante;}
			set 
			{
				_brClass.MetodoDeAsignacionTipoDeComprobante = value;
			}
		}

		public string MetodoDeAsignacionCuenta
		{
			get{return _brClass.MetodoDeAsignacionCuenta;}
			set 
			{
				_brClass.MetodoDeAsignacionCuenta = value;
			}
		}

		public string MetodoComparacion
		{
			get{return _brClass.MetodoComparacion;}
			set
			{
				_brClass.MetodoComparacion = value;
			}
		}

		public bool TodosLosComprobantes
		{
			get{return _brClass.TodosLosComprobantes;}
			set 
			{
				_brClass.TodosLosComprobantes = value;
			}
		}

		public bool Activo
		{
			get{return _brClass.Activo;}
			set 
			{
				_brClass.Activo = value;
			}
		}

		public TiposDeComprobantes ListaTiposDeComprobantesSeleccionados
		{
			get{return _brClass.ListaTiposDeComprobantesSeleccionados;}
			set 
			{
				_brClass.ListaTiposDeComprobantesSeleccionados = value;
			}
		}

		public TiposDeComprobantes TiposDeComprobantes
		{
			get{return _brClass.TiposDeComprobantes;}
			set 
			{
				_brClass.TiposDeComprobantes = value;
			}
		}

		public FormasDePagos ListaFormasDePagoSeleccionadas
		{
			get{return _brClass.ListaFormasDePagoSeleccionadas;}
			set 
			{
				_brClass.ListaFormasDePagoSeleccionadas = value;
			}
		}

		public FormasDePagos FormasDePago
		{
			get{return _brClass.FormasDePago;}
			set 
			{
				_brClass.FormasDePago = value;
			}
		}

		public ArrayList ListaCuentasSeleccionadasABorrar
		{
			get{return _brClass.ListaCuentasSeleccionadasABorrar;}
			set 
			{
				_brClass.ListaCuentasSeleccionadasABorrar = value;
			}
		}

		public Cuentas ListaCuentas
		{
			get{return _brClass.ListaCuentas;}
			set 
			{
				_brClass.ListaCuentas = value;
			}
		}

		public bool PermiteMetodoComparacion
		{
			get{return _brClass.PermiteMetodoComparacion;}
			set 
			{
				_brClass.PermiteMetodoComparacion = value;
			}
		}

		public bool PermiteMetodoAsignacionCuentas
		{
			get{return _brClass.PermiteMetodoAsignacionCuentas;}
			set 
			{
				_brClass.PermiteMetodoAsignacionCuentas = value;
			}
		}

		#endregion

		#region Variables Privadas

		private ABMCondicionesDeVenta _brClass;
		//private bool _todosLosComprobantes;
		//private string _metodoAsignacion = string.Empty;
		//private string _metodoComparacion = string.Empty;
		//private string _metodoAsignacionComprobantes = string.Empty;
		//private string _metodoAsignacionCuentas = string.Empty;

		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return null;
		}

		public void Continue()
		{
			
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return false;
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}

		public bool IsFirstTask()
		{
			
			return _processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return _processManager.IsNextState();
		}

		public bool IsBackState()
		{
			return _processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return false;
		}
		#endregion

		#region custom members
		
		public event System.EventHandler OnControllerHasChanged;

		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get{return _brClass.PreguntarAlCancelar;}
		}

		#endregion

		public bool ClienteRepetido(string CodigoCuenta)
		{
			return _brClass.ClienteRepetido(CodigoCuenta);
		}


		public void UpdateCuentas(string CodigoCuenta)
		{
			_brClass.UpdateCuentas(CodigoCuenta);
		}

		public void UpdateCuentasCondicionDeVenta(string IdCondicionDeVenta)
		{
			_brClass.ListaCuentas = mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetCuentas(IdCondicionDeVenta);
		}

		/*
		public void Borrar(ArrayList ListaCuentas)
		{
			_brClass.Borrar(ListaCuentas);
		}*/

		public void SetFlagsFormasDePago(int indice)
		{

		}

		public void EliminarCuentasSeleccionadas()
		{
			//_brClass.EliminarCuentasSeleccionadas();
		}

		public string GetLayoutCuentas()
		{
			
			ArrayList fl = new ArrayList();
			int i = 0;
			string _fieldList = null;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",90 ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",300 ) );
			if ( fl.Contains( "Domicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",true ) );
			if ( fl.Contains( "HorarioComercial" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "HorarioComercial", "HorarioComercial",true ) );
			if ( fl.Contains( "TipoDocumento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoDocumento", "Tipo Doc.",50) );
			if ( fl.Contains( "Documento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Documento", "Doc.", 75 ) );
			if ( fl.Contains( "CategoriaImpositiva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CategoriaImpositiva", "Cat. IVA",75 ) );
			if ( fl.Contains( "Telefono" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono",true ) );
			//if ( fl.Contains( "IdTitular" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTitular", "IdTitular",true ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones",100 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
	}
}
