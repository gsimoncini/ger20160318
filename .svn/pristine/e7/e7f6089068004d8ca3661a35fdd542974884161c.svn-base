using System;
using System.Text;
using System.Collections;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmTipoDeComprobanteController.
	/// </summary>
	public class AbmTipoDeComprobanteController:ITaskController
	{
		public AbmTipoDeComprobanteController()
		{
			_brClass = new AbmTipoDeComprobante();
			Init();
		}

		public AbmTipoDeComprobanteController(AbmTipoDeComprobante model)
		{
			_brClass = model;
			Init();
		}

		private void Init()
		{
		}

		#region Variables Privadas

		private AbmTipoDeComprobante _brClass;
		private ProcessControllerManager _processManager;


		#endregion

		#region Propiedades

		/*public string IdTipoAjusteStock
		{
			get{return _brClass.IdTipoAjusteStock;}
			set 
			{
				_brClass.IdTipoAjusteStock = value;
			}
		}

		public string IdEstadoDeStock
		{
			get{return _brClass.IdEstadoDeStock;}
			set 
			{
				_brClass.IdEstadoDeStock = value;
			}
		}

		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set 
			{
				_brClass.Descripcion = value;
			}
		}

		public short Operacion
		{
			get {return _brClass.Operacion;}
			set
			{
				_brClass.Operacion = value;
			}
		}

		public bool Sistema
		{
			get{return _brClass.Sistema;}
			set 
			{
				_brClass.Sistema = value;
			}
		}

		public bool Activo
		{
			get{return _brClass.Activo;}
			set 
			{
				_brClass.Activo = value;
			}
		}*/

		public ArrayList TiposDeComprobantes
		{
			set
			{
				_brClass.TiposDeComprobantes = value;
			}
			get 
			{
				return _brClass.TiposDeComprobantes;
			}
		}

		public TipoDeComprobante TipoDeComprobanteSeleccionado
		{
			get{return _brClass.TipoDeComprobanteSeleccionado;}
			set 
			{
				_brClass.TipoDeComprobanteSeleccionado = value;
			}
		}

		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}
		public string ContenedoresHabilitados
		{
			get{return _brClass.ContenedoresHabilitados;}
		}

		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
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

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
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

		public string GetLayoutTiposDeComprobantes()
		{
			
			ArrayList fl = new ArrayList();
			int i = 0;
			string _fieldList = null;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdTipoComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoComprobante", "IdTipoComprobante") );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion") );
			if ( fl.Contains( "Mascara" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mascara", "Mascara" ) );
			if ( fl.Contains( "Signo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Signo", "Signo") );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo") );
			if ( fl.Contains( "RequiereCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RequiereCondicionDeVenta", "RequiereCondicionDeVenta" ) );
			if ( fl.Contains( "Familia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Familia", "Familia" ) );
			if ( fl.Contains( "SignoCuentaCorriente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SignoCuentaCorriente", "Signo Cta Cte" ) );
			if ( fl.Contains( "TipoCuentaCorriente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoCuentaCorriente", "Tipo Cta Cte" ) );
			if ( fl.Contains( "Agregado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Agregado", "Agregado",true) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
	}
}
