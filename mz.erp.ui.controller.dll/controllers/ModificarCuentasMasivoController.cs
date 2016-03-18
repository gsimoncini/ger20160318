using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ModificarCuentasMasivoController.
	/// </summary>
	public class ModificarCuentasMasivoController: ITaskController, IObserver
	{

		#region Constructores
		public ModificarCuentasMasivoController(ModificarCuentasMasivo brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ModificarCuentasMasivo _brClass;
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

		public string EtiquetaCampoAuxiliar1
		{
			get{return _brClass.EtiquetaCampoAuxiliar1;}
		}

		public string EtiquetaCampoAuxiliar2
		{
			get{return _brClass.EtiquetaCampoAuxiliar2;}
		}

		public string EtiquetaCampoAuxiliar3
		{
			get{return _brClass.EtiquetaCampoAuxiliar3;}
		}

		public ArrayList Items
		{
			get{return this._brClass.Items;}
		}
		
		public bool AllowRemoveItems
		{
			get{return this._brClass.AllowRemoveItems;}
		}

		public bool AllowSeleccionMultiple
		{
			get{return this._brClass.AllowSeleccionMultiple;}
		}

		public bool SeleccionMultiple
		{
			get{return _brClass.SeleccionMultiple;}
			set
			{
				_brClass.SeleccionMultiple = value;
				Seleccionar(false);				
			}
		}
		
		public object SelectedItem
		{
			set{_brClass.SelectedItem = value;}
		}
		
		public bool AllowEditLimiteDeCredito
		{
			get{return _brClass.AllowEditLimiteDeCredito;}
		}

		public bool AllowEditDiasLimiteDeCredito
		{
			get{return _brClass.AllowEditDiasLimiteDeCredito;}
		}

		public bool AllowEditObservaciones
		{
			get{return _brClass.AllowEditObservaciones;}
		}
		public bool AllowEditCampoAuxiliar1
		{
			get{return _brClass.AllowEditCampoAuxiliar1;}
		}

		public bool AllowEditCampoAuxiliar2
		{
			get{return _brClass.AllowEditCampoAuxiliar2;}
		}

		public bool AllowEditCampoAuxiliar3
		{
			get{return _brClass.AllowEditCampoAuxiliar3;}
		}

		public bool AllowEditListaDePrecios
		{
			get{return _brClass.AllowEditListaDePrecios;}
		}

		public bool AllowEditActivo
		{
			get{return _brClass.AllowEditActivo;}
		}

		public bool ReemplazaObservaciones
		{
			get{return _brClass.ReemplazaObservaciones;}
			set{_brClass.ReemplazaObservaciones = value;}
		}

		public bool ReemplazaCampoAuxiliar1
		{
			get{return _brClass.ReemplazaCampoAuxiliar1;}
			set{_brClass.ReemplazaCampoAuxiliar1 = value;}
		}

		public bool ReemplazaCampoAuxiliar2
		{
			get{return _brClass.ReemplazaCampoAuxiliar2;}
			set{_brClass.ReemplazaCampoAuxiliar2 = value;}
		}

		public bool ReemplazaCampoAuxiliar3
		{
			get{return _brClass.ReemplazaCampoAuxiliar3;}
			set{_brClass.ReemplazaCampoAuxiliar3 = value;}
		}
		
		public decimal LimiteDeCredito
		{
			get{return _brClass.LimiteDeCredito;}
			set
			{
				_brClass.LimiteDeCredito = value;
			}
		}

		public decimal DiasLimiteDeCredito
		{
			get{return _brClass.DiasLimiteDeCredito;}
			set
			{
				_brClass.DiasLimiteDeCredito = value;
			}
		}

		public string Observaciones
		{
			get{return _brClass.Observaciones;}
			set
			{
				_brClass.Observaciones = value;
			}
		}

		public string CampoAuxiliar1
		{
			get{return _brClass.CampoAuxiliar1;}
			set
			{
				_brClass.CampoAuxiliar1 = value;
			}
		}

		public string CampoAuxiliar2
		{
			get{return _brClass.CampoAuxiliar2;}
			set
			{
				_brClass.CampoAuxiliar2 = value;
			}
		}
		
		public string CampoAuxiliar3
		{
			get{return _brClass.CampoAuxiliar3;}
			set
			{
				_brClass.CampoAuxiliar3 = value;
			}
		}

		public string IdListaDePreciosDefault
		{
			get{return _brClass.IdListaDePreciosDefault;}
			set
			{
				_brClass.IdListaDePreciosDefault = value;
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
		
		public bool PorCuenta
		{
			set{_brClass.PorCuenta = value;}
		}

		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}

		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}

		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}

		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}

		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}

		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}

		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		public ArrayList Jerarquias1
		{
			get{return _brClass.Jerarquias1;}
			set{_brClass.Jerarquias1 = value;}
		}

		public ArrayList Jerarquias2
		{
			get{return _brClass.Jerarquias2;}
			set{_brClass.Jerarquias2 = value;}
		}
		public ArrayList Jerarquias3
		{
			get{return _brClass.Jerarquias3;}
			set{_brClass.Jerarquias3 = value;}
		}

		public ArrayList Jerarquias4
		{
			get{return _brClass.Jerarquias4;}
			set{_brClass.Jerarquias4 = value;}
		}

		public ArrayList Jerarquias5
		{
			get{return _brClass.Jerarquias5;}
			set{_brClass.Jerarquias5 = value;}
		}

		public ArrayList Jerarquias6
		{
			get{return _brClass.Jerarquias6;}
			set{_brClass.Jerarquias6 = value;}
		}

		public ArrayList Jerarquias7
		{
			get{return _brClass.Jerarquias7;}
			set{_brClass.Jerarquias7 = value;}
		}

		public ArrayList Jerarquias8
		{
			get{return _brClass.Jerarquias8;}
			set{_brClass.Jerarquias8 = value;}
		}	
		
		public bool ModificaLimiteDeCredito
		{
			get{return _brClass.ModificaLimiteDeCredito;}
			set
			{
				_brClass.ModificaLimiteDeCredito = value;
			}
		}

		public bool ModificaDiasLimiteDeCredito
		{
			get{return _brClass.ModificaDiasLimiteDeCredito;}
			set
			{
				_brClass.ModificaDiasLimiteDeCredito = value;
			}
		}

		public bool ModificaObservaciones
		{
			get{return _brClass.ModificaObservaciones;}
			set
			{
				_brClass.ModificaObservaciones = value;
			}
		}
		public bool ModificaCampoAuxiliar1
		{
			get{return _brClass.ModificaCampoAuxiliar1;}
			set
			{
				_brClass.ModificaCampoAuxiliar1 = value;
			}
		}

		public bool ModificaCampoAuxiliar2
		{
			get{return _brClass.ModificaCampoAuxiliar2;}
			set
			{
				_brClass.ModificaCampoAuxiliar2 = value;
			}
		}

		public bool ModificaCampoAuxiliar3
		{
			get{return _brClass.ModificaCampoAuxiliar3;}
			set
			{
				_brClass.ModificaCampoAuxiliar3 = value;
			}
		}

		public bool ModificaListaDePrecios
		{
			get{return _brClass.ModificaListaDePrecios;}
			set
			{
				_brClass.ModificaListaDePrecios = value;
			}
		}

		public bool ModificaActivo
		{
			get{return _brClass.ModificaActivo;}
			set
			{
				_brClass.ModificaActivo = value;
			}
		}

		#endregion

		#region Eventos
		public event EventHandler ObjectHasChanged;
		public event EventHandler CuentasCollectionChanged;
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

		#region Metodos Privados

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
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
			_brClass.CuentasCollectionChanged += new EventHandler(_brClass_CuentasCollectionChanged);
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

		#endregion

		
		#region Metodos Publicos

		public void Seleccionar(bool seleccionar)
		{
			_brClass.Seleccionar(seleccionar);
			if(CuentasCollectionChanged != null)
				CuentasCollectionChanged(this, new EventArgs());

		}

		public void AddRange(ArrayList rows)
		{
			this._brClass.AddRange(rows);
		}
		
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((sender.GetType()) == typeof(mz.erp.ui.controllers.mzCuentasControlController))
			{	
				ProcessItem( Convert.ToString(((mz.erp.ui.controllers.mzCuentasControlController) sender).IdCuenta));
			}
		}

		private void ProcessItem( string IdCuenta )
		{
			_brClass.AddCuenta(IdCuenta);		
		}


		#endregion

		#region Manejadores de Eventos
		
		private void Refresh(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
	
		}
		
		private void _brClass_CuentasCollectionChanged(object sender, EventArgs e)
		{
			if(CuentasCollectionChanged != null)
				CuentasCollectionChanged(this, new EventArgs());
		}

		#endregion

	}
}
