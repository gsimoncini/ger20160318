using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarControlCajasController.
	/// </summary>
	public class ConsultarControlCajasController: ITaskController
	{
		#region Constructores
		public ConsultarControlCajasController(ConsultarControlCajas brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarControlCajas _brClass;
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

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		public bool PermiteConsultarHistorico
		{
			get { return _brClass.PermiteConsultarHistorico ; }
			set { _brClass.PermiteConsultarHistorico = value ; }
		}

		public bool CheckSoloAbiertas
		{
			get { return _brClass.CheckSoloAbiertas ; }
			set { _brClass.CheckSoloAbiertas = value ; }
		}

		public bool CheckSoloCerradas
		{
			get { return _brClass.CheckSoloCerradas ; }
			set { _brClass.CheckSoloCerradas = value ; }
		}

		public bool CheckTodas
		{
			get { return _brClass.CheckTodas ; }
			set { _brClass.CheckTodas = value ; }
		}
		
		public bool AllowFechas
		{
			get
			{
				return (!CheckSoloAbiertas);
			}
		}
		
		public DateTime FechaApertura
		{
			get { return _brClass.FechaApertura ; }
			set 
			{
				_brClass.FechaApertura = value ;
			}
		}
		public DateTime FechaCierre
		{
			get { return _brClass.FechaCierre ; }
			set 
			{
				_brClass.FechaCierre = value ; 
			}
		}
		
		private string _layoutFiltroCajas = string.Empty;
		public string LayoutFiltroCajas
		{
			get { return _layoutFiltroCajas ; }
		}
		
		public ArrayList FiltroCajas
		{
			get { return _brClass.FiltroCajas ; }
			set { _brClass.FiltroCajas = value ; }
		}
	
		public DataTable Result
		{
			get {return _brClass.Result; }
		}

		public bool HabilitaAuditadoSupervisor
		{
			get {return _brClass.HabilitaAuditadoSupervisor; }
		}

		public bool HabilitaAuditadoGerente
		{
			get {return _brClass.HabilitaAuditadoGerente; }
		}

		#endregion

		#region Eventos
		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;
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
			this._layoutFiltroCajas = this.GetLayoutFiltros();
		}	

		private void InitData()
		{
			SetLeyendaFormulario();
		}

		
		private void InitEventHandlers()
		{
			this._brClass.FechaAperturaChanged+= new System.EventHandler( this.ListenerFechaAperturaChanged );
			this._brClass.FechaCierreChanged+= new System.EventHandler( this.ListenerFechaCierreChanged );
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


		#endregion

		#region Métodos Públicos
		public void TildarNingunoCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas )
				items.Sel = false;
		}
		public void TildarTodosCaja()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroCajas)
				items.Sel = true;
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _brClass.updateFechas(fechaDesde, ordenInverso);

        }
        //Fin Cristian Tarea 0000146 20110725
        //Fin Cristian

		#endregion
	
		#region Layout Filtros
		private string GetLayoutFiltros( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sel", "Sel",  20, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250,  Types.ColumnTypes.Text, Types.EditType.NoEdit ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		

		#endregion
	
		private void ListenerFechaAperturaChanged( object sender, System.EventArgs e)
		{
			if (this.FechaAperturaChanged!=null)
			{
				FechaAperturaChanged(this,e);
			}
		}
		private void ListenerFechaCierreChanged( object sender, System.EventArgs e)
		{
			if (this.FechaCierreChanged!=null)
			{
				FechaCierreChanged(this,e);
			}
		}
	}
}
