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
	/// Descripción breve de DepositoBancarioController.
	/// </summary>
	public class DepositoBancarioController:ITaskController
	{
		public DepositoBancarioController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public DepositoBancarioController(DepositoBancario brClass)
		{
			_brClass = brClass;	
			//Init();
		}
		#region Variables Privadas
			
		private DepositoBancario _brClass;
		private ProcessControllerManager _processManager;
		
		
		#endregion
		#region eventos
			public event EventHandler FechaDepositoChanged;
			public event EventHandler NroBoletaChanged;
		#endregion
		#region propiedades
		public DataView Data
		{
			get 
			{
				return _brClass.Data;
				
			}
			
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}		
		public string Leyenda
		{
			get 
			{
				return _brClass.Leyenda;
			}
		}	
	//Datos de la vista
		public string FechaDeposito{
		
			get{return _brClass.FechaDeposito;}
			set{_brClass.FechaDeposito=value;}
		
		}
		public long NroBoleta
		{
			get{return _brClass.NroBoleta;}
			set{_brClass.NroBoleta=value;}
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
		public string IdBanco
		{
			get 
			{
				return _brClass.IdBanco;
			}
			set
			{
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
			return _brClass.GetProcessName();
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
	}
}
