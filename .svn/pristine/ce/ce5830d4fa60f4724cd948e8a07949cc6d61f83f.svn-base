using System;
using System.Data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;

using System.Collections;
using mz.erp.commontypes;
namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FormasDePagoController.
	/// </summary>
	public class FormasDePagoController:ITaskController, IObserver
	{
		public FormasDePagoController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public FormasDePagoController(RecargosFormasDePago recargos)
		{
			_recargos = recargos;
			Init();
		}

		public void Init()
		{
			InitializeData();
			InitEventHandlers();
		}

		private void InitializeData()
		{
			SetCaption(_recargos);
		}
		
		private void InitEventHandlers()
		{		
			_recargos.ObjectHasChanged +=new EventHandler(_recargos_ObjectHasChanged);
			_recargos.OnTaskAfterExecute +=new EventHandler(_recargos_OnTaskAfterExecute);
		}


		#region Variables Privadas
		
		private RecargosFormasDePago _recargos;
		private FormaDePago _currentFormaDePago;
		private string _layoutFormasDePagos = new mz.erp.ui.controllers.tfi_FormasDePagoEx().GetLayout();
		private string _layoutRecargos = new mz.erp.ui.controllers.tfi_Recargos().GetLayout();
		private string _caption = "Seleccione la/s Formas de Pagos";		


		#endregion

		#region Variables Publicas

		public decimal Saldo
		{
			get{return _recargos.Saldo;}
		}

		public bool Modified 
		{
			set
			{
				_recargos.SetModified();
			}
		}
	
		public FormaDePago CurrentFormaDePago
		{
			set
			{
				_currentFormaDePago = value;
			}
		}

		public FormasDePagos FormasDePagos
		{
			get
			{
				//_recargos.FormasDePagos;//.Sort();
				return _recargos.FormasDePagos;
			
			}
		}

		public string LeyendaFormulario
		{
			get
			{
				return "Seleccion de las Formas de Pagos";
			}
		}

		public RecargosFormaDePago RecargosFormaDepago
		{
			get
			{
				return this._recargos.Recargos;
			}
		}

		public decimal TotalAAbonar
		{
			get
			{
				return this._recargos.TotalAAbonar;
			}
		}

		public decimal TotalPorcentajeRecargo
		{
			get
			{
				return this._recargos.Recargos.TotalPorcentajeRecargo;
			}
		}

		public decimal TotalImporteAbonado
		{
			get
			{
				return this._recargos.Recargos.TotalImporteAbonado;
			}
		}

		public decimal Total
		{
			get
			{
				return this._recargos.Recargos.Total;
			}
		}

		public decimal TotalImporteRecargo
		{
			get
			{
				return this._recargos.Recargos.TotalImporteRecargo;
			}

		}
		
		public decimal TotalComprobanteDeVentaSinRecargos
		{
			get
			{
				return this._recargos.TotalComprobanteDeVentaSinRecargos;
			}
		}

		public decimal TotalComprobanteDeVenta
		{
			get
			{
				return this._recargos.TotalComprobanteDeVenta;
			}
		}

		#endregion

		#region Propiedades UI
				
		public string LayoutFormasDePagos
		{
			get
			{
				return _layoutFormasDePagos;
			}

		}

		public string LayoutRecargos
		{
			get
			{
				return _layoutRecargos;
			}
		}

		public string Caption
		{
			get
			{
				return _caption;
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{
				return _recargos.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _recargos.TextoBotonAnterior;					
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _recargos.PreguntarAlCancelar;}
		}
			
		#endregion

		#region Eventos
			public event EventHandler OnTaskAfterExecute;
			public event EventHandler OnModelChanged;		
		#endregion

		#region Metodos Publicos
			
		public void AddFormaDePago(object fdp)
		{
			FormaDePago formaDePago = (FormaDePago) fdp;
			if(!formaDePago.IdTDComprobante.Equals(string.Empty))
				_recargos.AddRecargo(formaDePago);
		}

		public bool IsEditable(object selectedItem, string property)
		{
			if(!_recargos.CreaIdValoresNuevos)
			{
				RecargoFormaDePago recFormaDePago = (RecargoFormaDePago)selectedItem;
				Valor valor = recFormaDePago.FormaDePago.Valor;
				bool isStep = valor.IsStep;
				bool agrupado = valor.Agrupado;
				return agrupado || !isStep;
			}
			return true;
		}

		public bool IsRemovable(object selectedItem)
		{
			/*
			if(!_recargos.CreaIdValoresNuevos)
			{
				FormaDePago formaDePago = (FormaDePago)selectedItem;
				Valor valor = formaDePago.Valor;
				bool isStep = valor.IsStep;
				bool agrupado = valor.Agrupado;
				return agrupado || !isStep;
			}
			*/
			return true;
		}

		#endregion

		#region Metodos Privados
		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public string GetTaskName()
		{
			return _recargos.GetTaskName();
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
			return this._processManager.IsFirstTask(_recargos.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_recargos.GetTaskName());
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
			return _recargos.AllowPrevious();
		}

		public void Previous()
		{
			_recargos.Previous();
		}


		public ItemsDatasetErrors GetErrors()
		{
			return _recargos.GetErrors();
		}
		public string GetWarnings()
		{
			return _recargos.GetWarnings();
		}
		public void Continue()
		{
			_recargos.Continue();
		}

		public void Execute()
		{
			_recargos.Execute();
		}

		public bool AllowShow()
		{
			return _recargos.AllowShow();
		}

		#endregion

		private void _recargos_ObjectHasChanged(object sender, EventArgs e)
		{
			RecargosFormasDePago recargo = (RecargosFormasDePago)sender;
			SetCaption(recargo);
			if(OnModelChanged != null)
					OnModelChanged(this, new EventArgs());	
		}

		private void SetCaption(RecargosFormasDePago recargo)
		{
			_caption = "Seleccione la/s Formas de Pagos";
			string cap = " para la Cond. de Venta ";
			cap = cap  +  ((recargo.CondicionDeVenta.Equals(string.Empty))? string.Empty : recargo.CondicionDeVenta);
            //German 20100427 - Tarea 741
            if (ComprobantesRules.Momentos_MuestraRecargoCodicionDeVentaEnTituloPantallaSeleccionarFormaDePago(recargo.GetProcessManagerParent().Process.ProcessName, recargo.GetTaskName()))
            {
                string rec = string.Empty;
                if (!recargo.RecargoCondicionDeVenta.Equals(0)) rec = Convert.ToString(recargo.RecargoCondicionDeVenta);
                if (!rec.Equals(string.Empty))
                    cap = cap + " Recargo: " + rec + "%";
                _caption = _caption + cap;
            }
            //Fin German 20100427 - Tarea 741
            
			_caption = _caption  +  cap;
		}

		private void _recargos_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute!= null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public void Refresh()
		{
			_recargos.Refresh();
		}
		#region Miembros de IObserver

		public void UpdateObject(object observable, object valores)
		{
			Valor valor = (Valor) valores;
			if(_currentFormaDePago != null)
			{
				/*
				_currentFormaDePago.Valor = valor;
				if(valor.State.ToUpper().Equals("NEW"))
				{
					this.AddFormaDePago(_currentFormaDePago);
				}
				*/
				if(_currentFormaDePago.Valor == null)
				{
					_currentFormaDePago.Valor = valor;
					this.AddFormaDePago(_currentFormaDePago);
				}
				this.Modified = true;
			}
			
		}

		public ValoresController GetValoresController(string IdTDCompTesoreria,string IdMoneda,bool Agrupado,decimal ValorDefault,decimal PorcentajeRecargo,string IdValor, ITaskController taskController)
		{
			Valor valor = _currentFormaDePago.Valor;
			ValoresController valorescontroller = new ValoresController(IdTDCompTesoreria,IdMoneda,Agrupado,ValorDefault,PorcentajeRecargo,IdValor, this, this._recargos.IdCuenta);
			valorescontroller.ReglasDeValidacionAuxiliares = _recargos.ReglasDeValidacion;
			return valorescontroller;
		}

		public ValoresController GetValoresController()
		{
			Valor valor = _currentFormaDePago.Valor;
			ValoresController valorescontroller = new ValoresController(valor, _currentFormaDePago.Recargo, this);
			valorescontroller.ReglasDeValidacionAuxiliares = _recargos.ReglasDeValidacion;
			return valorescontroller;
		}

		#endregion

		public string TaskName
		{
			get {
					return _recargos.GetTaskName();
				}
				
		}
	}
}
