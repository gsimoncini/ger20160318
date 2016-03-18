using System;
using mz.erp.businessrules;
using System.Text;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmProductosSucursalesController.
	/// </summary>
	public class AbmProductosSucursalesController :ITaskController
	{
		
		#region Constructores

		public AbmProductosSucursalesController(AbmProductoSucursal brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas

			private AbmProductoSucursal _brClass;
			private string _layoutProductos = string.Empty;
			private string _layoutSucursales = string.Empty;
			private string _layoutProductosSucursales = string.Empty;



		#endregion

		#region Variables Publicas
			
		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get{return _brClass.TextoBotonSiguiente;}
		}

		public string TextoBotonAnterior
		{
			get{return _brClass.TextoBotonAnterior;}
		}

		public string LayoutProductos
		{
			get{return _layoutProductos;}
		}

		public string LayoutSucursales
		{
			get{return _layoutSucursales;}
		}

		public string LayoutProductosSucursales
		{
			get{return _layoutProductosSucursales;}
		}

		public ArrayList Productos
		{
			get{return _brClass.ProductosInstance;}
		}

		public AbmProductoSucursal.Sucursales Sucursales
		{
			get{return _brClass.SucursalesInstance;}
		}

		public AbmProductoSucursal.ProductosSucursales ProductosSucursales
		{
			get{return _brClass.ProductosSucursalesInstance;}
		}



		#endregion

		#region Eventos
		
			public event EventHandler ObjectHasChanged;
		
		#endregion

		#region Metodos Privados

		private void Init()
		{
			BuildLayoutProductos();
			BuildLayoutSucursales();
			BuildLaoutProductosSucursales();
			InitEventHandlers();
		}

		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
		}

		private void BuildLayoutProductos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",400, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetFooter() );
			_layoutProductos =  sb.ToString();	
		}
		private void BuildLayoutSucursales()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );	
			sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",300, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",200, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true ) );
			sb.Append( LayoutBuilder.GetFooter() );
			_layoutProductosSucursales =  sb.ToString();	
		}
		private void BuildLaoutProductosSucursales()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",300, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Direccion", "Direccion",100, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetFooter() );
			_layoutSucursales =  sb.ToString();	
		}

		private void Refresh(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}



		#endregion


		#region Metodos Publicos

		public void RemoveProductoSucursal(object SelIdProd, object SelIdSuc)
		{
			string IdProd = Convert.ToString(SelIdProd);
			long IdSuc = Convert.ToInt64(SelIdSuc);
			_brClass.RemoveProductoSucursal(IdProd, IdSuc);
		}

		public void AddProductoSucursal(object SelIdProd, object SelIdSuc)
		{
			string IdProd = Convert.ToString(SelIdProd);
			long IdSuc = Convert.ToInt64(SelIdSuc);
			_brClass.AddProductoSucursal(IdProd, IdSuc);
		}

		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return null;
		}

		public void Continue()
		{
			
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return false;
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public bool IsFirstTask()
		{
			
			return _processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return _processManager.IsNextState();
		}

		public bool IsBackState()
		{
			return _processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return false;
		}
		#endregion

	
	}
}
