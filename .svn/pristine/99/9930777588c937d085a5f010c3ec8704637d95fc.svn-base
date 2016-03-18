using System;
	using System.Data;
using mz.erp.businessrules;
using System.Text;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de IngresarCodigoSecundarioController.
	/// </summary>
	public class IngresarCodigoSecundarioController: ITaskController
	{

		#region Constructores

		public IngresarCodigoSecundarioController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public IngresarCodigoSecundarioController(IngresarCodigoSecundario brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion
		#region Propiedades
        
		private bool _visualizaBuscadorPorJerarquias = true;
		public bool VisualizaBuscadorPorJerarquias
		{
			get { return _visualizaBuscadorPorJerarquias; }
		}

		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
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

		public ArrayList Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
			set{_brClass.Jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
			set{_brClass.Jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
			set{_brClass.Jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
			set{_brClass.Jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
			set{_brClass.Jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
			set{_brClass.Jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
			set{_brClass.Jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
			set{_brClass.Jerarquia8 = value;}
		}

		public ArrayList Productos
		{
			get{return _brClass.Productos;}
			set{_brClass.Productos = value;}
		}
		private string _layoutDetalle = string.Empty;
		public string LayoutProductos
		{
			get{return _layoutDetalle;}
		}
		private bool _allowMultipleSelect = false; 
		public bool AllowMultipleSelect 
		{
			get  
			{
				return _allowMultipleSelect;
			}			
		}

		#endregion
		#region Variables Privadas
		private IngresarCodigoSecundario _brClass;
		private string _descripcion = string.Empty;
		#endregion
		#region Eventos
		public event System.EventHandler ProductosCollectionChanged;		
		#endregion
		#region Métodos privados
		
		private void Init()
		{
			/*_allowEditPrecioDeCostoRef = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowEditPrecioDeCostoRef");
			_allowRemoveItems = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowRemoveItems");
			_configuracionBasica = Variables.GetValueBool("Productos.Precios.ConfiguracionBasica");*/
			_allowMultipleSelect = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowMultipleSelect");
            _visualizaBuscadorPorJerarquias = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"VisualizaBuscadorPorJerarquias", _visualizaBuscadorPorJerarquias);
			InitEventHandlers();
			InitData();
		}

		private void InitData()
		{
			SetLayoutDetalle();			
		}

		private void SetLayoutDetalle()
		{			
			/*ArrayList _buildedarray = new ArrayList();
			_buildedarray.Add("Codigo");
			_buildedarray.Add("Descripcion");			
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;			
			_layoutDetalle = this.GetLayoutDetalle( _campos );*/

			string[] _fieldList = null;
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",100) );
			
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",600, Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Codigo Secundario",150 ) );
			sb.Append( LayoutBuilder.GetFooter() );
			_layoutDetalle = sb.ToString();
		}

		private void InitEventHandlers()
		{			
/*			_brClass.ObjectHasChanged +=new EventHandler(Refresh);*/
			_brClass.ProductosCollectionChanged += new EventHandler(_brClass_ProductosCollectionChanged);
			
		}

		public void NodoActual()
		{
			_brClass.NodoActual();
		}

		#endregion
		#region Métodos públicos
		private void _brClass_ProductosCollectionChanged(object sender, EventArgs e)
		{
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
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

	}
}
