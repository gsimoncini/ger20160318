using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;
namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMChequerasControllers.
	/// </summary>
	public class ABMChequerasControllers:ITaskController
	{
		public ABMChequerasControllers()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public ABMChequerasControllers(ABMChequeras brClass)
		{
			_brClass = brClass;	
			//Init();
		}
		#region eventos
		public event EventHandler ChequeraChanged;
		public event EventHandler PrimerChequeChanged;
		public event EventHandler UltimoChequeChanged;
		#endregion
		#region propiedades
		public long Chequera
		{
			get{return _brClass.Chequera;}
			set{_brClass.Chequera=value;}
		}
		public long PrimerCheque
		{
			get{return _brClass.PrimerCheque;}
			set{_brClass.PrimerCheque=value;}
		}
		public long UltimoCheque
		{
			get{return _brClass.UltimoCheque;}
			set{_brClass.UltimoCheque=value;}
		}
		public string IdBanco
		{
			get 
			{
				return _brClass.IdBanco;
			}
			set{
					_brClass.IdBanco=value;
			
			}
		}
		public string IdCuenta
		{
			get 
			{
				return _brClass.IdCuenta;
			}
			set
			{
				_brClass.IdCuenta=value;
			
			}
		}
		//Busqueda
		public string IdBancoBusqueda
		{
			get 
			{
				return _brClass.IdBancoBusqueda;
			}
			set
			{
				_brClass.IdBancoBusqueda=value;
			
			}
		}
		public string IdCuentaBusqueda
		{
			get 
			{
				return _brClass.IdCuentaBusqueda;
			}
			set
			{
				_brClass.IdCuentaBusqueda=value;
			
			}
		}

		public string IdChequera
		{
			get 
			{
				return _brClass.IdChequera;
			}
			set
			{
				_brClass.IdChequera=value;
						
			}
		}
		//Variables de Configuracion de la vista
		public string MascaraPrimerCheque
		{
			get 
			{
				return _brClass.MascaraPrimerCheque;
			}
		}
		public string MascaraUltimoCheque
		{
			get 
			{
				return _brClass.MascaraUltimoCheque;
			}
		}
		public string MascaraNroChequera
		{
			get 
			{
				return _brClass.MascaraNroChequera;
			}
		}
		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}
		public string Leyenda
		{
			get 
			{
				return _brClass.Leyenda;
			}
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}
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
		public DataTable CuentasBancarias
		{
			get{return _brClass.CuentasBancarias;}
		}

		public string KeyValueCuenta
		{
			get { return "IdCuenta" ; }
		}		
		
		public string KeyListCuenta
		{
			get { return "NroCuenta" ; }
		}

		//Busqueda
		public DataTable Chequeras
		{
			get{return _brClass.Chequeras;}
		}

		public string KeyValueCheque
		{
			get { return "IdChequera" ; }
		}		
		
		public string KeyListCheque
		{
			get { return "Comienzo" ; }
		}
		public DateTime FechaCierre
		{
			set {_brClass.FechaCierre=value;}
		}
		#endregion
		#region Variables Privadas
			
		private ABMChequeras _brClass;
		private ProcessControllerManager _processManager;
		
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

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}		
		
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
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}
		
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}
		public void Continue()
		{

		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		#endregion
		#region metodos publicos
		public string ContenedoresVisibles(){
			return _brClass.ContenedoresVisibles();
		}
		public void CargarDatos()
		{
			_brClass.CargarDatos();
		}
		#endregion
	}
}
