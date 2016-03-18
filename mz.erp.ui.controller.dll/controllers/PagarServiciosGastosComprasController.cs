using System;
using System.Data;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de PagarServiciosGastosComprasController.
	/// </summary>
	public class PagarServiciosGastosComprasController: ITaskController, IObserver
	{
		public PagarServiciosGastosComprasController(PagarServiciosGastosCompras BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		#region Metodos Privados

		private void Init()
		{
			_brClass.ComprobantesSelectedChanged +=new EventHandler(_brClass_ComprobantesSelectedChanged);
		}

		#endregion
	
		#region Variables Privadas

			private mz.erp.businessrules.PagarServiciosGastosCompras _brClass;
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

		#region Eventos

			public event EventHandler IdResponsableChanged;
			public event EventHandler IdInstanciaCajaChanged;
			public event EventHandler OnControllerChanged;
			public event EventHandler ComprobantesSelectedChanged;

		#endregion

		#region Propiedades

		public int CantidadComprobantesSeleccionados
		{
			get{return _brClass.CantidadComprobantesSeleccionados;}
		}

		public decimal TotalSaldoComprobantesSeleccionados
		{
			get{return _brClass.TotalSaldoComprobantesSeleccionados;}
		}

		public ArrayList Comprobantes
		{
			get{return _brClass.Comprobantes;}
		}

		public ArrayList Valores
		{
			get{return _brClass.Valores;}
		}

		public decimal Total
		{
			get{return _brClass.Total;}
		}

		public string IdResponsable
		{
			get{return _brClass.IdResponsable;}
			set{_brClass.IdResponsable = value;}
		}

		public DateTime Fecha
		{
			get{return _brClass.Fecha;}
			set{_brClass.Fecha = value;}
		}

		public string IdInstanciaCaja
		{
			get{return _brClass.IdInstanciaCaja;}
			set{_brClass.IdInstanciaCaja = value;}
		}

		public DataTable Usuarios
		{
			get{return _brClass.Usuarios;}
		}

		public DataTable Cajas
		{
			get{return _brClass.Cajas;}
		}
	

		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get {return _brClass.TextoBotonSiguiente;}
		}

		public string TextoBotonAnterior
		{
			get{return _brClass.TextoBotonAnterior;}
		}

		public bool AllowAddValores
		{
			get{return _brClass.AllowAddValores;}
		}

		public bool AllowDeleteValores
		{
			get{return _brClass.AllowDeleteValores;}
		}

		public bool AllowSearchValores
		{
			get{return _brClass.AllowSearchValores;}
		}

		public bool AllowEditFecha
		{
			get{return _brClass.AllowEditFecha;}
		}

		public bool AllowEditCaja
		{
			get{return _brClass.AllowEditCaja;}
		}

		public bool AllowEditResponsable
		{
			get{return _brClass.AllowEditResponsable;}
		}

		public bool HabilitarContraseña 
		{
			get{return _brClass.HabilitarContraseña;}
		}

		private string _ultimoResponsableClaveCorrecta = "";
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
		

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if(valores.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.Valor)))
			{
				Valor valor = (Valor) valores;
				if(!_brClass.Contains(valor))
				{
					_brClass.AddValor( valor );
				}
				ListenerObjectHasChanged(this._brClass, null);
			}
			if(valores.GetType().Equals(typeof(System.Collections.ArrayList)))
			{
				ArrayList result = (ArrayList) valores;
				foreach(Valor valor in result)
				{
					if(!_brClass.Contains(valor))
					{
						_brClass.AddValor( valor );
					}
				}
				ListenerObjectHasChanged(this._brClass, null);
			}
		}


		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			if (this.OnControllerChanged != null)
				this.OnControllerChanged(null, new System.EventArgs() );
			
		}

		public ValoresController GetValoresController(decimal Importe)
		{
			bool _agrupado = true; 
			string tdcomp = _brClass.IdTDCompTesoreriaDefault;
			string moneda = ComprobantesRules.Contabilidad_MonedaReferencia;
			ValoresController valorescontroller = new ValoresController(tdcomp, moneda, _agrupado, Importe,0,null, this, string.Empty);
			//seteo valores por defecto para la ventana de valores
			valorescontroller.AllowEditTDCompTesoreria = true;			
			valorescontroller.IdTDCompTesoreriaReadOnly = false;		
			valorescontroller.AllowEditMoneda = true;					
			valorescontroller.IdMonedaOrigenReadOnly = false;			
			valorescontroller.AllowEditImportes = _brClass.CantidadComprobantesSeleccionados <= 1;
			return valorescontroller;
		}


		#endregion

		#region Metodos Publicos

		public ArrayList GetValores(object selected)
		{
			return _brClass.GetValores(selected);
		}
		
		public bool HayComprobantesSinSaldo()
		{
			return _brClass.HayComprobantesSinSaldo();
		}

		public bool HayComprobantesSeleccionados()
		{
			return _brClass.HayComprobantesSeleccionados();
		}

		public void BorrarValor(object selected)
		{
			_brClass.BorrarValor((Valor)selected);
		}

		public void Seleccionar(bool selected)
		{
			_brClass.Seleccionar(selected);
		}

		#endregion

		private void _brClass_ComprobantesSelectedChanged(object sender, EventArgs e)
		{
			if(this.ComprobantesSelectedChanged != null)
				ComprobantesSelectedChanged(this, EventArgs.Empty);
		}
	}
}
