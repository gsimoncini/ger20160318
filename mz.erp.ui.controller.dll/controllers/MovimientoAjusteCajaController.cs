using System;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de MovimientoAjusteCaja.
	/// </summary>
	public class MovimientoAjusteCajaController: ITaskController, IObserver
	{
		#region Constructores

		public MovimientoAjusteCajaController( MovimientosCaja movimientoCaja)
		{
			_model = movimientoCaja;
			Init();	
		}
		#endregion

		#region Variables
		
		private MovimientosCaja _model;
		private string _leyendaFormulario = string.Empty;
		private string _layoutResult= new tfi_ValoresEx().GetLayoutValores();	
		
		
		#endregion

		#region Acceso a variables 
	
		public string LeyendaFormulario
		{
			get { return _model.LeyendaFormulario ; }
		}
		public bool PreguntarAlCancelar
		{
			get {return _model.PreguntarAlCancelar;}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _model.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _model.TextoBotonAnterior;
			}
		}
		/*public string NombreSolapa
		{
			get { return _model.NombreSolapa ; }
		}*/
		public string Numero
		{
			set{_model.Numero = value;}
			get{return _model.Numero;}
		}
		public string Observaciones
		{
			set{_model.Observaciones = value;}
			get{return _model.Observaciones;}
		}
		public string IdTipo
		{
			get { return _model.IdTipo ; }
			set { _model.IdTipo = value; }
		}
		public string IdCaja
		{
			get { return _model.IdCaja; }
			set {_model.IdCaja = value ;}
		}
		public DateTime Fecha
		{
			get {return _model.Fecha ; }
			set {_model.Fecha = value ; }
		}
		public string IdSubTipo
		{
			get { return _model.IdSubTipo ; }
			set { _model.IdSubTipo = value; }
		}
		public string IdComp
		{
			get { return _model.IdComp ; }
			set { _model.IdComp = value; }
		}
		public string ValorMoneda
		{
			get{return _model.ValorMoneda;}
			set{ _model.ValorMoneda = value;}
		}
		public decimal ValorTotal
		{
			get{return _model.ValorTotal;}
			set{ _model.ValorTotal = value;}
		}
		public string ValorTDCompTesoreria
		{
			get{return _model.ValorTDCompTesoreria;}
			set{ _model.ValorTDCompTesoreria = value;}
		}

		public decimal UneTotal
		{
			get { return _model.UneTotal ; }
			set { _model.UneTotal = value; }
		}

		public string LayoutResult
		{
			get {return _layoutResult;}
		}
		public mz.erp.businessrules.MovimientosCaja.DetallesValoresMovimientos Valores
		{
			get {return _model.DValoresMovimientos;}
		}
		public string IdMovimientoOriginal
		{
			get{return _model.IdMovimientoOriginal;}
			set{ _model.IdMovimientoOriginal = value;}
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
		public void ClearResponsableDeEmision() 
		{						
			_model.IdUsuario = ""; 
			this.IdUsuario="";
			
		}
		public DataTable Usuarios
		{
			get {return _model.Usuarios;}
		}
		public string KeyValueUsuarios
		{
			get { return "IdPersona" ; }
		}				
		public string KeyListUsuarios
		{
			get { return "Nombre" ; }
		}
		private string _idUsuario = string.Empty;
		public object IdUsuario
		{
			get { return _model.IdUsuario ; }
			set 
			{ 
				if (value != null && _model.IdUsuario.CompareTo( value ) != 0)
				{
					_idUsuario = Convert.ToString(value);
					_model.IdUsuario = Convert.ToString(value) ; 
					if (this.IdUsuarioChanged != null)
						IdUsuarioChanged (this, new EventArgs());
				}
				else if(value == null && _idUsuario != string.Empty)
				{
					_idUsuario = string.Empty;
					_model.IdUsuario = string.Empty; 

				}
			}
		}	

		public bool HabilitarContraseña 
		{
			get 
			{	
				return _model.HabilitarContraseña;
			}
		}
		
		
		public bool PermiteEditarResponsable
		{
			get 
			{	
				return _model.PermiteEditarResponsable;
			}
		}
		public DataTable InstanciasDeCaja(){
			return	_model.FiltroCajas;
		}

		public DataTable FiltroTiposMovimientos
		{
			get { return _model.FiltroTiposMovimientos; }
			set { _model.FiltroTiposMovimientos = value ; }
		}
		#endregion

		#region allow
		public bool AllowEditUneTotal()
		{
			return _model.AllowEditUneTotal;
		}
		public bool AllowEditNumero()
		{
			return _model.AllowEditNumero;
		}
		public bool AllowEditCaja()
		{
			return _model.AllowEditCaja;
		}
		public bool AllowEditObservaciones()
		{
			return _model.AllowEditObservaciones;
		}
		public bool AllowEditTipoDeMovimiento()
		{
			return _model.AllowEditTipoDeMovimiento;
		}
		public bool AllowEditsubTipoDeMovimiento()
		{
			return _model.AllowEditSubTipoDeMovimiento;
		}
		public bool AllowEditFecha()
		{
			return _model.AllowEditFecha;
		}
		public bool AllowEditValores()
		{
			return _model.AllowEditValores;
		}
		public bool AllowEditTipoComprobante()
		{
			return _model.AllowEditTipoComprobante;
		}		
		public bool AllowMenuContextualGrilla()
		{
			if (this.GetProcessName().Equals("ProcesoModificarValor"))
				return true;
			else return false;
		}
		public bool LayoutEditTypeValores()
		{
			return _model.LayoutEditTypeValores;
		}

		public bool AllowAddValores
		{
			get{return _model.AllowAddValores;}
		}

		public bool AllowDeleteValores
		{
			get{return _model.AllowDeleteValores;}
		}

		public bool AllowSearchValores
		{
			get{return _model.AllowSearchValores;}
		}
		

		#endregion

		#region Metodos Privados

		private void Init()
		{
			InitEventHandlers();		
		}


		private void InitEventHandlers()
		{
			_model.IdUsuarioHasChanged+=new EventHandler(_model_IdUsuarioHasChanged);
			_model.IdCajaChanged+=new EventHandler(_model_IdCajaChanged);
			_model.ObjectHasChanged+= new System.EventHandler( this.ListenerObjectHasChanged );
		}	


		#endregion

		#region Miembros de ITaskController

		private ProcessControllerManager _processManager;

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
			return this._processManager.IsFirstTask(_model.GetTaskName());
		}

		public string GetTaskName()
		{
			return _model.GetTaskName();
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
			return _model.AllowPrevious();
		}

		public void Previous()
		{
			_model.Previous();
		}
		
		public ItemsDatasetErrors GetErrors()
		{
			return _model.GetErrors();
		}
		public string GetWarnings()
		{
			return _model.GetWarnings();
		}
		public void Continue()
		{
			_model.Continue();
		}

		public void Execute()
		{
			_model.Execute();
		}

		public bool AllowShow()
		{
			return _model.AllowShow();
		}
		#endregion

		#region Eventos
		
		public event EventHandler ModelHasChanged;
		public event EventHandler OnControllerChanged;
		public event EventHandler OnTaskAfterExecute;
		public event EventHandler IdUsuarioChanged;	
		public event EventHandler IdCajaChanged;
		
		private void _model_ObjectHasChanged(object sender, EventArgs e)
		{
			if (ModelHasChanged != null)
				ModelHasChanged(this._model, new EventArgs());

		}
		
		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			if (this.OnControllerChanged != null)
				this.OnControllerChanged(null, new System.EventArgs() );
			
		}

		#endregion

		#region Miembros de IObserver

		public void ValorDeleted()
		{
			_model.ValorDeleted();
		}

		public void UpdateObject(object observable, object valores)
		{
			//Valor valor = (Valor) observable;
			if(valores.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.Valor)))
			{
				Valor valor = (Valor) valores;
				if(!_model.Contains(valor))
				{
					_model.AddValor( valor );
				}
				ListenerObjectHasChanged(this._model, null);
			}
			if(valores.GetType().Equals(typeof(System.Collections.ArrayList)))
			{
				ArrayList result = (ArrayList) valores;
				foreach(Valor valor in result)
				{
					if(!_model.Contains(valor))
					{
						_model.AddValor( valor );
					}
				}
				ListenerObjectHasChanged(this._model, null);
			}

		}

		public ValoresController GetValoresController()
		{
			bool _agrupado = false;
			tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow rowTdcomp = (tfi_TDCompTesoreria.GetByPk(ValorTDCompTesoreria));
			if (rowTdcomp != null )
			{
				_agrupado = rowTdcomp.Agrupado; 
			}
			decimal _total = 0;
			if(_agrupado)
			{
				decimal totalValoresAgrupadoOrigen = System.Math.Abs(this.TotalValoresAgrupadoOrigen());
				decimal totalValoresAgrupadoAjustados = System.Math.Abs(this.ValoresAjustados());
				decimal totalSinAjustar = totalValoresAgrupadoOrigen - totalValoresAgrupadoAjustados;
				decimal totalValor = System.Math.Abs(ValorTotal);
				if(totalSinAjustar > 0)
				{
					if(totalValor > totalSinAjustar)
						_total = totalSinAjustar;
					else
						_total = totalValor;
				}
				if(_model.DetalleValorAgrupadoOrigen != null)
				{
					string IdCotizacion = _model.DetalleValorAgrupadoOrigen.IdCotizacionMoneda;
					Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
					_total = _total * cot.Valor;
				}
			}
			
			ValoresController valorescontroller = new ValoresController(ValorTDCompTesoreria, ValorMoneda, _agrupado, _total, 0, null, this, string.Empty);
			//seteo valores por defecto para la ventana de valores
			valorescontroller.AllowEditTDCompTesoreria = _model.ValorAllowEditIdTDCompTesoreria;
			valorescontroller.IdTDCompTesoreriaReadOnly = _model.ValorIdTDCompTesoreriaReadOnly;
			valorescontroller.AllowEditMoneda = _model.ValorAllowEditIdMoneda; 
			valorescontroller.IdMonedaOrigenReadOnly = _model.ValorIdMonedaReadOnly;
			
			return valorescontroller;
		
		}

		private decimal TotalValoresAgrupadoOrigen()
		{
			return _model.TotalValoresAgrupadoOrigen();
		}

		private decimal ValoresAjustados()
		{
			return _model.ValoresAjustados();
		}
		#endregion



		public string GetFormText()
		{
			return Variables.GetValueString(GetProcessName(), TaskName(), "NombreSolapa");
		}

		public mz.erp.commontypes.data.tsy_TiposMovimientosDataset ListaTiposMovimientos()
		{
			return _model.ListaTiposMovimientos();
		}
		
		public DataTable ListaSubTipoMovimientos(string idTipo)
		{
			return _model.ListaSubTipoMovimientos(idTipo);
		}

		public string TaskName()
		{
			return _model.GetTaskName();
		}
		private string GetProcessName()
		{
			return _model.GetProcessName();
		}

		private void _model_IdUsuarioHasChanged(object sender, EventArgs e)
		{
			if (this._idUsuario!=_model.IdUsuario)
				IdUsuarioChanged (this, new EventArgs());
		}

		private void _model_IdCajaChanged(object sender, EventArgs e)
		{
					IdCajaChanged (this, new EventArgs());

		}
	}
}
