using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ControlarCajasController.
	/// </summary>
	public class ControlarCajasController: ITaskController
	{

		#region Constructores
		public ControlarCajasController(ControlarCajas brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ControlarCajas _brClass;
		private string _leyendaFormulario;
		#endregion
	
		#region Propiedades

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
			set{_leyendaFormulario = value;}
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

		public bool AllowEditCaja()
		{
			return _brClass.AllowEditCaja;
		}

		public string IdCaja
		{
			get { return _brClass.IdCaja; }
			set {_brClass.IdCaja = value ;}
		}

		public DataTable InstanciasDeCaja()
		{
			return	_brClass.FiltroCajas;
		}

		private DataTable _tDCompTesorerias = null;
		public System.Data.DataTable TDCompTesorerias
		{
			get {return _tDCompTesorerias;}
		}

		public string KeyValueTDCompTesoreria
		{
			get { return "IdControlDeCajasFamiliasComprobanteTesoreria" ; }
		}				
		public string KeyListTDCompTesoreria
		{
			get { return "Descripcion" ; }
		}

		private DataTable _tiposBilletes = null;
		public System.Data.DataTable TiposBilletes
		{
			get {return _tiposBilletes;}
		}

		public string KeyValueTipoBillete
		{
			get { return "IdTipoBillete" ; }
		}				
		public string KeyListTipoBillete
		{
			get { return "Descripcion" ; }
		}

		private DataTable _monedas = null;
		public System.Data.DataTable Monedas
		{
			get {return _monedas;}
		}

		public string KeyValueMoneda
		{
			get { return "IdMoneda" ; }
		}				
		public string KeyListMoneda
		{
			get { return "Descripcion" ; }
		}
		
		public string IdControlDeCajasFamiliasComprobanteTesoreria
		{
			get { return _brClass.IdControlDeCajasFamiliasComprobanteTesoreria; }
			set {_brClass.IdControlDeCajasFamiliasComprobanteTesoreria = value ;}
		}

		public string TDCompTesoreria
		{
			get { return _brClass.TDCompTesoreria; }
			set {_brClass.TDCompTesoreria = value ;}
		}

		public long IdTipoBillete
		{
			get { return _brClass.IdTipoBillete; }
			set {_brClass.IdTipoBillete = value ;}
		}

		public string TipoBillete
		{
			get { return _brClass.TipoBillete; }
			set {_brClass.TipoBillete = value ;}
		}

		public decimal ValorBillete
		{
			get { return _brClass.ValorBillete; }
		}

		public string IdMoneda
		{
			get { return _brClass.IdMoneda; }
			set {_brClass.IdMoneda = value ;}
		}
		
		public string Moneda
		{
			get { return _brClass.Moneda; }
			set {_brClass.Moneda = value ;}
		}

		public long CantidadInformada
		{
			get { return _brClass.CantidadInformada; }
			set {_brClass.CantidadInformada = value ;}
		}

		public decimal MontoInformado
		{
			get { return _brClass.MontoInformado; }
			set {_brClass.MontoInformado = value ;}
		}

		public ArrayList AuditoriaControlCajasDetView
		{
			get {return _brClass.AuditoriaControlCajasDetView;}
		}

		#endregion

		#region Eventos
		public event System.EventHandler AuditoriaControlCajasDetViewHasChanged;
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
			SetCombosData();
		}

		
		private void InitEventHandlers()
		{
			_brClass.AuditoriaControlCajasDetViewHasChanged+=new EventHandler(_brClass_AuditoriaControlCajasDetViewHasChanged);
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = mz.erp.businessrules.Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = mz.erp.businessrules.Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		private void SetCombosData()
		{
			_tDCompTesorerias = businessrules.tfi_ControlDeCajasFamiliasComprobanteTesoreria.GetList().tfi_ControlDeCajasFamiliasComprobanteTesoreria;
			_tiposBilletes = businessrules.tsy_TiposBilletes.GetListByActivo(true).tsy_TiposBilletes;
			_monedas = businessrules.tfi_Monedas.GetList().tfi_Monedas;
			Hashtable valoresBilletes = new Hashtable();
			foreach(DataRow row in _tiposBilletes.Rows)
			{
				long idTipoBillete = (long)row["IdTipoBillete"];
				decimal valorBillete = (decimal)row["Valor"];
				valoresBilletes.Add(idTipoBillete, valorBillete);
			}
			_brClass.ValoresBilletes = valoresBilletes;
		}

		#endregion

		#region Métodos Públicos

		public bool HabilitaTipoBillete()
		{
			return _brClass.HabilitaTipoBillete();
		}

		public void AgregarItemAuditoria()
		{
			_brClass.AgregarItemAuditoria();
		}

		public void EliminarItemAuditoria(AuditoriaControlCajasDetView item)
		{
			_brClass.EliminarItemAuditoria(item);
		}
		#endregion

		private void _brClass_AuditoriaControlCajasDetViewHasChanged(object sender, EventArgs e)
		{
			if(AuditoriaControlCajasDetViewHasChanged != null)
				AuditoriaControlCajasDetViewHasChanged(this, new EventArgs());	
		}

	}
}
