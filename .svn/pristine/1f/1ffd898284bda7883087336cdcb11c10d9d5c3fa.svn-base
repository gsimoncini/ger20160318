using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarFacturasImpagasController.
	/// </summary>
	public class ConsultarFacturasImpagasController: ITaskController
	{
		#region Constructores
		public ConsultarFacturasImpagasController(ConsultarFacturasImpagas brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarFacturasImpagas _brClass;
		private string _leyendaFormulario;
		#endregion
	
		#region Propiedades

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		public string CodigoCuenta
		{			
			get { return _brClass.CodigoCuenta ; }
			set { _brClass.CodigoCuenta = value; }
		}
		
		public DateTime FechaDesde
		{
			get{return _brClass.FechaDesde;}
			set{_brClass.FechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		}

		public bool PorFechaEmision
		{
			get{return _brClass.PorFechaEmision ;}
			set{_brClass.PorFechaEmision = value;}
		}

		public bool PorFechaVencimiento
		{
			get{return _brClass.PorFechaVencimiento ;}
			set{_brClass.PorFechaVencimiento = value;}
		}

		public int Periodos
		{
			get{return _brClass.Periodos ;}
			set{_brClass.Periodos = value;}
		}

		public bool PeriodosEnDias
		{
			get{return _brClass.PeriodosEnDias ;}
			set{_brClass.PeriodosEnDias = value;}
		}
		
		public bool PeriodosEnSemanas
		{
			get{return _brClass.PeriodosEnSemanas ;}
			set{_brClass.PeriodosEnSemanas = value;}
		}
		
		public bool PeriodosEnMeses
		{
			get{return _brClass.PeriodosEnMeses ;}
			set{_brClass.PeriodosEnMeses = value;}
		}
		
		public bool MostrarElResto
		{
			get{return _brClass.MostrarElResto ;}
			set{_brClass.MostrarElResto = value;}
		}
		
		public bool PeriodosPorFechaEmision
		{
			get{return _brClass.PeriodosPorFechaEmision ;}
			set{_brClass.PeriodosPorFechaEmision = value;}
		}

		public bool PeriodosPorFechaVencimiento
		{
			get{return _brClass.PeriodosPorFechaVencimiento ;}
			set{_brClass.PeriodosPorFechaVencimiento = value;}
		}
		#endregion

		#region Eventos
		public event EventHandler DataChanged;
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

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
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
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}
		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{
			SetLeyendaFormulario();
		}

		
		private void InitEventHandlers()
		{
			_brClass.DataChanged +=new EventHandler(RefreshData);
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}
		#endregion

		#region Métodos Públicos
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            this._brClass.updateFechas(fechaDesde);
        }
        //Fin Cristian
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		#endregion
	}
}
