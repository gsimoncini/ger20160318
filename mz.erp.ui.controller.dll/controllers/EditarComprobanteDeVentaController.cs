using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de EditarComprobanteDeVentaController.
	/// </summary>
	public class EditarComprobanteDeVentaController: ITaskController, IObserver, IObservable
	{
		public EditarComprobanteDeVentaController(EditarComprobanteDeVenta brClass)
		{		
			_brClass = brClass;
			Init();
		}


		#region Variables privadas
			
			private EditarComprobanteDeVenta _brClass;
			private ProcessControllerManager _processManager;


			private string _layoutVariables = string.Empty;
			private string _leyendaFormulario = string.Empty;
			private string _textoBotonSiguiente = "Siguiente";
			private string _textoBotonAnterior = "Anterior";

			private bool _allowEditObservaciones = true;
			private bool _allowEditTipoDeComprobante = true;
			private bool _allowEditVariablesAuxiliares = true;
			private bool _allowEditCuenta = true;
			private bool _allowEditFecha = true;
			private bool _allowEditResponsableEmision = true;
			private bool _allowEditCondicionDeVenta = true;
			private bool _allowEditNumeration = false;

			private bool _habiltaOrden = false;

			private System.Collections.Hashtable _listatiposDeComprobantes = businessrules.tsy_TiposDeComprobantes.GetListHashTable();

		#endregion

		#region Variables Publicas Interface

		public string NombreDeComprobante
		{
			get 
			{ 
				return _listatiposDeComprobantes[ _brClass.IdTipoDeComprobante].ToString() ;
			}
		}

		public string Caption 
		{
			get	{return "Emision de " + this.NombreDeComprobante;}
		}


		
		public DataTable TableCondicionesDeVenta
		{
			get{return _brClass.TableCondicionesDeVenta;}
		}


		
		public bool HabilitaOrden
		{
			get{return _habiltaOrden;}
		}


		public string LayoutVariables
		{
			get{return _layoutVariables;}
		}

		public bool AllowEditObservaciones
		{
			get	{return this._allowEditObservaciones;}
		}

		public bool AllowEditTipoDeComprobante
		{
			get	{return this._allowEditTipoDeComprobante;}
		}
		public bool AllowEditResponsableEmision
		{
			get	{return this._allowEditResponsableEmision;}
		}
	
		public bool AllowEditCuenta
		{
			get	{return this._allowEditCuenta;}
		}
		public bool AllowEditVariablesAuxiliares
		{
			get	{return this._allowEditVariablesAuxiliares;}
		}
		public bool AllowEditCondicionDeVenta
		{
			get{return this._allowEditCondicionDeVenta;}
		}

		public bool AllowEditFecha
		{
			get{return this._allowEditFecha;}
		}

		public bool AllowEditNumeration
		{
			get	{return this._allowEditNumeration;}
		}

		public string LeyendaFormulario
		{
			get {return this._leyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonAnterior
		{
			get 
			{		
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this._brClass.GetTaskName() + "." + this._brClass.GetProcessManagerParent().Process.ProcessName + "." + "TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonAnterior";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
				}
				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{				
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this._brClass.GetTaskName() + "." + this._brClass.GetProcessManagerParent().Process.ProcessName + "." + "TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonSiguiente";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
				}
			
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}			
				
			}
		}




		#endregion 

		#region Variables Publicas Datos

		public ICollection VariablesDeUsuario
		{
			get	{	return this._brClass.VariablesDeUsuario;	}
		}


		public string Mascara
		{
			get { return _brClass.Mascara;}
		}


			
		public DateTime FechaEmision
		{
			get{return _brClass.FechaEmision;}
			set{_brClass.FechaEmision = value;}
		}

		public string IdResponsable
		{
			get{return _brClass.IdResponsable;}
			set{_brClass.IdResponsable = value;}
		}

		public string IdCondicionDeVenta
		{
			get{return _brClass.IdCondicionDeVenta;}
			set{_brClass.IdCondicionDeVenta = value;}
		}

		public string Observaciones
		{
			get{return _brClass.Observaciones;}
			set{_brClass.Observaciones = value;}
		}

		public string IdCuenta
		{
			get{return _brClass.IdCuenta;}
			set{_brClass.IdCuenta = value;}
		}

		public string CodigoCuenta
		{
			set 
			{ 
				_brClass.CodigoCuenta = value ; 
			}
			get { return _brClass.CodigoCuenta;} 
		}

				
		public string Numero
		{
			get{return _brClass.Numero;}
			set{_brClass.Numero = value;}
		}
		
		public string IdTipoDeComprobante
		{
			get{return _brClass.IdTipoDeComprobante;}
			set{_brClass.IdTipoDeComprobante = value;}
		}

		public string IdComprobante
		{
			get{return _brClass.IdComprobante;}
			set{_brClass.IdComprobante = value;}
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

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
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
			SetLayoutVariables();
			SetLeyendaFormulario();
			SetEditableProperties();
			_habiltaOrden = Variables.GetValueBool("Comprobantes.CondicionesDeVentas.HabilitaOrden");
		}

		private void SetEditableProperties()
		{
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			_allowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TComp");
			_allowEditObservaciones = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Observaciones");
			_allowEditCuenta = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.Cuenta");
			_allowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Fecha");
			_allowEditCondicionDeVenta = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.CondVenta");
			_allowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.REmision");
			_allowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Numeracion");
			_allowEditVariablesAuxiliares = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.VariablesAuxiliares", _allowEditVariablesAuxiliares);
		}	
			
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName,this._brClass.GetTaskName(),"LeyendaFormulario");			
			if (leyenda.Equals(string.Empty))
			{
				leyenda= this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}


		private void SetLayoutVariables()
		{
			_layoutVariables = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutVariables( );

		}
		#endregion 

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			
		}

		#endregion

		#region Miembros de IObservable

		private ArrayList _objectListener = new ArrayList();
		public void AddObjectListener( IObserver _object )
		{
			_objectListener.Add( _object );
		}
		public void ProcessObjectsObserver()
		{
			
		}

		#endregion
	}
}
