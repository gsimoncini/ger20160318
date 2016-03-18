using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmProductosController.
	/// </summary>
	public class AbmProductosController: ITaskController
	{
		mz.erp.businessrules.AbmProductos _brClass;
		public event EventHandler OnTaskAfterExecute;
		public AbmProductosController(mz.erp.businessrules.AbmProductos model)
		{
			_brClass = model;
			model.ObjectHasChanged+= new System.EventHandler( this.ListenerModelChanges );
		}

		#region propiedades de Seguridad
		public bool AllowShowCodigo
		{
			get{return AbmProductosSecurity.GetInstance().AllowShowCodigo;}
		}

		public bool AllowEditCodigo
		{
			get{return AbmProductosSecurity.GetInstance().AllowEditCodigo;}
		}
			
	    		
		#endregion
		#region Miembros de ITaskController

		public string GetWarnings()
		{
			// TODO: agregar la implementación AbmProductosController.GetWarnings
			return null;
		}

		public void Continue()
		{
			// TODO: agregar la implementación AbmProductosController.Continue
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementación AbmProductosController.AllowShow
			return true;
		}

		public bool AllowPrevious()
		{
			// TODO: agregar la implementación AbmProductosController.AllowPrevious
			return false;
		}

		public void Previous()
		{
			_brClass.Previous();
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

		public bool IsFirstTask()
		{
			// TODO: agregar la implementación AbmProductosController.IsFirstTask
			return false;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public bool IsNextState()
		{
			// TODO: agregar la implementación AbmProductosController.IsNextState
			return false;
		}

		public bool IsBackState()
		{
			// TODO: agregar la implementación AbmProductosController.IsBackState
			return false;
		}

		public bool IsFlushedState()
		{
			// TODO: agregar la implementación AbmProductosController.IsFlushedState
			return false;
		}

		#endregion
		#region custom members
		public event System.EventHandler CodigoChanged;
		public event System.EventHandler CodigoSecundarioChanged;
		public event System.EventHandler DescripcionChanged;
		public event System.EventHandler DescripcionCortaChanged;
		public event System.EventHandler DescripcionLargaChanged;
		public event System.EventHandler ObservacionesChanged;
		public event System.EventHandler ActivoChanged;
		public event System.EventHandler ObligaCodigoBarrasChanged;
		public event System.EventHandler ObligaNumeroDeSerieChanged;
		public event System.EventHandler IdTipoDeProductoChanged;
		
		
		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}
		public bool PreguntarAlCancelar
		{
			get{return _brClass.PreguntarAlCancelar;}
		}
		public string Codigo
		{
			get { return _brClass.Codigo ; }
			set { _brClass.Codigo = value ; }
		}
		public string CodigoSecundario
		{
			get { return _brClass.CodigoSecundario ;}
			set { _brClass.CodigoSecundario = value ; }
		}
		public string Descripcion
		{
			get { return _brClass.Descripcion; }
			set { _brClass.Descripcion = value ;}
		}
		public string DescripcionCorta
		{
			get { return _brClass.DescripcionCorta; }
			set { _brClass.DescripcionCorta= value ;}
		}
		
		public string DescripcionLarga
		{
			get { return _brClass.DescripcionLarga ; }
			set { _brClass.DescripcionLarga= value ; }
		}
		public bool Activo
		{
			get { return _brClass.Activo; }
			set { _brClass.Activo= value ; }
		}
		
		public object IdTipoDeProducto
		{
			get { return (object)_brClass.IdTipoDeProducto;}
			set { _brClass.IdTipoDeProducto= Convert.ToString(value) ;}
		}
		public bool ObligaCodigoBarras
		{
			get { return _brClass.ObligaCodigoBarras; }
			set { _brClass.ObligaCodigoBarras= value ; }
		}
		
		public bool ObligaNumeroDeSerie
		{
			get { return _brClass.ObligaNumeroDeSerie; }
			set { _brClass.ObligaNumeroDeSerie=value; }
		}
		
		public string Observaciones
		{
			get { return _brClass.Observaciones; }
			set { _brClass.Observaciones =  value ; }
		}
		
		public event System.EventHandler OnControllerHasChanged;
		private void ListenerModelChanges( object sender, System.EventArgs e )
		{
			if (OnControllerHasChanged != null)
			{
				this.OnControllerHasChanged( null, new System.EventArgs() );
			}
			if (CodigoChanged != null)
			{
				CodigoChanged(null, new System.EventArgs() );
			}
			if (CodigoSecundarioChanged !=null)
			{
				CodigoSecundarioChanged(null, new System.EventArgs() );
			}
			if (DescripcionChanged !=null)
			{
				DescripcionChanged(null, new System.EventArgs() );
			}
			if (DescripcionCortaChanged !=null)
			{
				DescripcionCortaChanged(null, new System.EventArgs() );
			}
			if (DescripcionLargaChanged !=null)
			{
				DescripcionLargaChanged(null, new System.EventArgs() );
			}
			if (ObservacionesChanged !=null)
			{
				ObservacionesChanged(null, new System.EventArgs() );
			}
			if (ActivoChanged !=null)
			{
				ActivoChanged(null, new System.EventArgs() );
			}
			if (ObligaCodigoBarrasChanged !=null)
			{
				ObligaCodigoBarrasChanged(null, new System.EventArgs() );
			}
			if (ObligaNumeroDeSerieChanged !=null)
			{
				ObligaNumeroDeSerieChanged(null, new System.EventArgs() );
			}
			if (IdTipoDeProductoChanged !=null)
			{
				IdTipoDeProductoChanged(null, new System.EventArgs() );
			}
		}
		public DataTable TiposDeProductos
		{
			get { return _brClass.TiposDeProductos ; }
		}
		private string _layoutTiposDeProductos = new mz.erp.ui.controllers.tsy_TipoProducto( new string[]{ "IdTipoProducto","Descripcion"}).GetLayout();
		public string LayoutTiposDeProductos
		{
			get {  return _layoutTiposDeProductos; }
		}
		public string KeyListTiposDeProductos
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueTiposDeProductos
		{
			get { return "IdTipoProducto"; }
		}
		
		#endregion
	}
}
