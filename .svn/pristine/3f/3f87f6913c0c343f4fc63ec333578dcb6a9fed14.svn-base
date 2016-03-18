using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ModificarProductosMasivoController.
	/// </summary>
	public class ModificarProductosMasivoController: ITaskController, IObservable, IObserver	
	{

		#region Constructores

		public ModificarProductosMasivoController(ModificarProductosMasivo brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas

		private ModificarProductosMasivo _brClass;
		private string _leyendaFormulario;
		private string _layoutDetalle = string.Empty;
		private bool _allowSeleccionMultiple = false;
		private bool _allowRemoveItems = false;
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		private string _etiquetaCampoAuxiliar3 = string.Empty;	
		private string _etiquetaCampoAuxiliar4 = string.Empty;	
		private string _etiquetaCampoAuxiliar5 = string.Empty;
		private string _etiquetaCampoAuxiliar6 = string.Empty;

		#endregion

		#region Propiedades

		public string State
		{
			set{_brClass.State = value;}
		}

		public string IdProveedorDefault
		{
			get{return _brClass.IdProveedorDefault;}
			set{_brClass.IdProveedorDefault = value;}
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
		
		public string CampoAuxiliar4
		{
			get{return _brClass.CampoAuxiliar4;}
			set
			{
				_brClass.CampoAuxiliar4 = value;
			}
		}
		
		public string CampoAuxiliar5
		{
			get{return _brClass.CampoAuxiliar5;}
			set
			{
				_brClass.CampoAuxiliar5 = value;
			}
		}

		public string CampoAuxiliar6
		{
			get{return _brClass.CampoAuxiliar6;}
			set
			{
				_brClass.CampoAuxiliar6 = value;
			}
		}

		public ArrayList JerarquiasCampoAuxiliar6
		{
			get{return _brClass.JerarquiasCampoAuxiliar6;}
		}

		public ArrayList ProductosJerarquiasCampoAuxiliar6
		{
			get
			{
				return _brClass.ProductosJerarquiasCampoAuxiliar6;
			}
		}

		
		public bool ObligaCodigoBarra
		{
			get{return _brClass.ObligaCodigoBarra;}
			set
			{
				_brClass.ObligaCodigoBarra = value;
			}
		}

		public bool ObligaNumeroSerie
		{
			get{return _brClass.ObligaNumeroSerie;}
			set
			{
				_brClass.ObligaNumeroSerie = value;
			}
		}

		public bool PercibeIngresosBrutos
		{
			get{return _brClass.PercibeIngresosBrutos;}
			set
			{
				_brClass.PercibeIngresosBrutos = value;
			}
		}

        /* Silvina 20110630 - Tarea 0000136 */
        public bool PermiteCambio
        {
            get { return _brClass.PermiteCambio; }
            set
            {
                _brClass.PermiteCambio = value;
            }
        }
         /* Fin Silvina 20110630 - Tarea 0000136 */

        //German 20120208 - Tarea 0000276

        public string IdBonificacion
        {
            get { return _brClass.IdBonificacion; }
            set
            {
                _brClass.IdBonificacion = value;
            }
        }
		
        //German 20120208 - Tarea 0000276

		public bool Activo
		{
			get{return _brClass.Activo;}
			set
			{
				_brClass.Activo = value;
			}
		}
		
		public ArrayList Items
		{
			get{return this._brClass.Items;}
		}

		public bool AllowRemoveItems
		{
			get{return _allowRemoveItems;}
		}

		public bool AllowSeleccionMultiple
		{
			get{return _allowSeleccionMultiple;}
			
		}

		public string LayoutProductos
		{
			get{return _layoutDetalle;}
		}

		public object SelectedItem
		{
			set{_brClass.SelectedItem = value;}
		}

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

		public bool EnableBuscadorProducto
		{
			get
			{
                return true;
			}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
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


		public string EtiquetaCampoAuxiliar1
		{
			get{return this._etiquetaCampoAuxiliar1;}
		}

		public string EtiquetaCampoAuxiliar2
		{
			get{return this._etiquetaCampoAuxiliar2;}
		}
		public string EtiquetaCampoAuxiliar3
		{
			get{return this._etiquetaCampoAuxiliar3;}
		}
		public string EtiquetaCampoAuxiliar4
		{
			get{return this._etiquetaCampoAuxiliar4;}
		}
		public string EtiquetaCampoAuxiliar5
		{
			get{return this._etiquetaCampoAuxiliar5;}
		}
		public string EtiquetaCampoAuxiliar6
		{
			get{return this._etiquetaCampoAuxiliar6;}
		}

		public bool  HabilitaCampoAuxiliar1
		{
			get{return this._habilitaCampoAuxiliar1;}
		}
		public bool  HabilitaCampoAuxiliar2
		{
			get{return this._habilitaCampoAuxiliar2;}
		}
		public bool  HabilitaCampoAuxiliar3
		{
			get{return this._habilitaCampoAuxiliar3;}
		}
		public bool  HabilitaCampoAuxiliar4
		{
			get{return this._habilitaCampoAuxiliar4;}
		}
		public bool  HabilitaCampoAuxiliar5
		{
			get{return this._habilitaCampoAuxiliar5;}
		}
		public bool  HabilitaCampoAuxiliar6
		{
			get{return this._habilitaCampoAuxiliar6;}
		}


		#endregion

		#region Eventos
		public event EventHandler ProductosCollectionChanged;
		public event EventHandler ObjectHasChanged;

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

		private void _brClass_ProductosCollectionChanged(object sender, EventArgs e)
		{
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		}

		private void Init()
		{
			_allowRemoveItems = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowRemoveItems");
    		_allowSeleccionMultiple = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowMultipleSelect", _allowSeleccionMultiple);
			InitEventHandlers();
			InitData();
		}

		private void InitData()
		{
			SetLeyendaFormulario();
			SetLayoutDetalle();
			SetEtiquetaCamposAuxiliares();
		}

		
		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
			_brClass.ProductosCollectionChanged += new EventHandler(_brClass_ProductosCollectionChanged);
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

		private bool _habilitaCampoAuxiliar1 = false;
		private bool _habilitaCampoAuxiliar2 = false;
		private bool _habilitaCampoAuxiliar3 = false;
		private bool _habilitaCampoAuxiliar4 = false;
		private bool _habilitaCampoAuxiliar5 = false;
		private bool _habilitaCampoAuxiliar6 = false;
		private void SetEtiquetaCamposAuxiliares()
		{
			this._etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			this._habilitaCampoAuxiliar1 = !this._etiquetaCampoAuxiliar1.Equals(string.Empty);
			this._etiquetaCampoAuxiliar1 = this._etiquetaCampoAuxiliar1.Equals(string.Empty)?"CampoAuxiliar1":this._etiquetaCampoAuxiliar1;
			this._etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			this._habilitaCampoAuxiliar2 = !this._etiquetaCampoAuxiliar2.Equals(string.Empty);
			this._etiquetaCampoAuxiliar2 = this._etiquetaCampoAuxiliar2.Equals(string.Empty)?"CampoAuxiliar2":this._etiquetaCampoAuxiliar2;
			this._etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			this._habilitaCampoAuxiliar3 = !this._etiquetaCampoAuxiliar3.Equals(string.Empty);
			this._etiquetaCampoAuxiliar3 = this._etiquetaCampoAuxiliar3.Equals(string.Empty)?"CampoAuxiliar3":this._etiquetaCampoAuxiliar3;
			this._etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			this._habilitaCampoAuxiliar4 = !this._etiquetaCampoAuxiliar4.Equals(string.Empty);
			this._etiquetaCampoAuxiliar4 = this._etiquetaCampoAuxiliar4.Equals(string.Empty)?"CampoAuxiliar4":this._etiquetaCampoAuxiliar4;
			this._etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			this._habilitaCampoAuxiliar5 = !this._etiquetaCampoAuxiliar5.Equals(string.Empty);
			this._etiquetaCampoAuxiliar5 = this._etiquetaCampoAuxiliar5.Equals(string.Empty)?"CampoAuxiliar5":this._etiquetaCampoAuxiliar5;
			this._etiquetaCampoAuxiliar6 = Variables.GetValueString("Productos.CampoAuxiliar6.Etiqueta");
			this._habilitaCampoAuxiliar6 = !this._etiquetaCampoAuxiliar6.Equals(string.Empty);
			this._etiquetaCampoAuxiliar6 = this._etiquetaCampoAuxiliar6.Equals(string.Empty)?"CampoAuxiliar6":this._etiquetaCampoAuxiliar6;

		}

		private void Refresh(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
	
		}
		

		private void SetLayoutDetalle()
		{
			ArrayList _buildedarray = new ArrayList();
			_buildedarray.Add("Codigo");
			_buildedarray.Add("Descripcion");
			if(_allowSeleccionMultiple) _buildedarray.Add("Selected");
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;			
			_layoutDetalle = mz.erp.ui.controllers.ComprobantesDeCompra.GetLayoutDetalle( _campos );

		}


		#endregion



		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItem( (ArrayList)valores);
			}

		}

		private void ProcessItem( ArrayList lista )
		{
			_brClass.AddRange(lista);		
		}


		#endregion

		#region Metodos Publicos

		public void Seleccionar(bool seleccionar)
		{
			_brClass.Seleccionar(seleccionar);
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());

		}

		public bool EstaSeleccionado()
		{
			return _brClass.Selected;
		}



		#endregion

	}
}
