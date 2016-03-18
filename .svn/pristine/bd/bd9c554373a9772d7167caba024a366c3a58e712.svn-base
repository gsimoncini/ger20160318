using System;
using System.Data;
using System.Text;
using System.Collections;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class CuentaCorrienteGeneralController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.CuentaCorrienteGeneral _brClass;
		public CuentaCorrienteGeneralController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public CuentaCorrienteGeneralController(mz.erp.businessrules.CuentaCorrienteGeneral brClass)
		{
			_brClass = brClass;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		#endregion

		#region Variables Públicas

		public event EventHandler OnTaskAfterExecute;
		public event System.EventHandler ObjectHasChanged;
			
		#endregion

		#region Variables Públicas Datos

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

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}

		public string SubProcess
		{
			get{return _brClass.SubProcess;}
		}



		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}
		public string LeyendaFormulario
		{
			get 
			{
				return _brClass.LeyendaFormulario;
			}
		}
		
		public string TextoSolapaJerarquias
		{
			get 
			{
				return _brClass.TextoSolapaJerarquias;
			}
		}

		public string KeyHierarchicalSearchControl
		{
			get 
			{
				return _brClass.KeyHierarchicalSearchControl;
			}
		}
		
		public System.Data.DataTable TablaResultado
		{			
			get 
			{
				return _brClass.TablaResultado;
			}					
			set 
			{
				_brClass.TablaResultado = value;
			}
		}

		
		public DateTime FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		}
		
		/*public string NombreColumnaMarca
		{
			get 
			{
				return _brClass.NombreColumnaMarca;
			}			
		}*/

		#endregion

		#region Variables Privadas
		private string[] _fieldList;						
		private bool _isValid = true;
		private bool _allowShow = true;		
						
		#endregion

		#region Variables Privadas Datos
		public bool IsValid 
		{
			get {return _isValid;}
		}


		#endregion

		#region Eventos y delegados		
		#endregion
		
		#region Métodos  Públicos
		public string GetProcessName()
		{
			return _brClass.GetProcessName();
		}
		/*public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",90, Types.ColumnTypes.Text, Types.EditType.NoEdit) );			
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",500, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Saldo", "Saldo",100, Types.Aligment.Far, Types.FormatDisplay.Money, Types.EditType.NoEdit));
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 120, true) );

				string columna = _brClass.NombreColumnaMarca;
				bool activar = _brClass.ActivarColumnaMarca;
				if ( fl.Contains( columna ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, columna, columna,75, !activar, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
					
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}*/
		
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			//this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{

		}
		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

		private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

	}
}
