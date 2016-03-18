using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarTareasRealizadasOrdenReparacionController.
	/// </summary>
	public class ListarTareasRealizadasOrdenReparacionController: ITaskController
	{
		#region Contructores
		public ListarTareasRealizadasOrdenReparacionController()
		{
		}

		public ListarTareasRealizadasOrdenReparacionController(ListarTareasRealizadasOrdenReparacion brClass)
		{
			_brClass = brClass;
			Init();
		}
		
		#endregion

		#region Variables Privadas 
		private ListarTareasRealizadasOrdenReparacion _brClass;
		private bool _allowShow = true;		
		#endregion

		#region Propiedades

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

		
		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public bool ListaServiciosOrdenReparacionHabilitada
		{
			get 
			{
				return _brClass.ListaServiciosOrdenReparacionHabilitada;
			}
		}

		public ArrayList Servicios
		{
			get {return _brClass.Servicios;}
		}

		public ArrayList Result
		{
			get { return _brClass.Result; }
		}

		public System.Data.DataTable ResultAsTable
		{
			get { return _brClass.ResultAsTable; }
		}

		public long IdOrdenReparacion
		{
			get{return _brClass.IdOrdenReparacion;}
			set{_brClass.IdOrdenReparacion = value;}
		}

		public ArrayList IdServiciosSelecionados
		{
			get{return _brClass.IdServiciosSelecionados;}
			set{_brClass.IdServiciosSelecionados = value;}
		}

		public decimal Total
		{
			get{return _brClass.Total;}
			set{_brClass.Total = value;}
		}

		public decimal TotalTecnico
		{
			get{return _brClass.TotalTecnico;}
			set{_brClass.TotalTecnico = value;}
		}

		public string NumeroRemito
		{
			get{return _brClass.NumeroRemito;}
			set{_brClass.NumeroRemito = value;}
		}

		public decimal TiempoDeEspera
		{
			get{return _brClass.TiempoDeEspera;}
			set{_brClass.TiempoDeEspera = value;}
		}
		
		public ArrayList MotivosHijos
		{
			get 
			{
				return _brClass.MotivosHijos;
			}
		}


		public ArrayList MotivosPadres
		{
			get 
			{
				return _brClass.MotivosPadres;
			}
		}

		public ArrayList ObservacionesOrdenReparacion
		{
			get 
			{
				return _brClass.ObservacionesOrdenReparacion;
			}
		}

		public EstadisticaOrdenReparacionMotivoOrdenReparacion EstadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado
		{
			get{return _brClass.EstadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado;}
			set
			{
				_brClass.EstadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado = value;
				if(MotivoPadreChanged != null)
					MotivoPadreChanged(this, new EventArgs());

			}
		}

		public EstadisticaOrdenReparacionMotivoOrdenReparacion EstadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado
		{
			get{return _brClass.EstadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado;}
			set
			{
				_brClass.EstadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado = value;
				if(MotivoTareaPadreChanged != null)
					MotivoTareaPadreChanged(this, new EventArgs());

			}
		}

		public ArrayList MotivosTareaHijos
		{
			get 
			{
				return _brClass.MotivosTareaHijos;
			}
		}


		public ArrayList MotivosTareaPadres
		{
			get 
			{
				return _brClass.MotivosTareaPadres;
			}
		}

		public EstadisticaOrdenReparacionDet TareaSeleccionada
		{
			get{return _brClass.TareaSeleccionada;}
			set{_brClass.TareaSeleccionada = value;	}
		}

		public bool ValidaCompletarDatosOrdenSTD
		{
			get{return _brClass.ValidaCompletarDatosOrdenSTD;}
		}

		public EstadisticaOrdenReparacion EstadisticaOrdenReparacionSeleccionada
		{
			get{return _brClass.EstadisticaOrdenReparacionSeleccionada;}
		}

		public bool PermiteModificarOrdenReparacion
		{
			get{return _brClass.PermiteModificarOrdenReparacion;}
		}

		#endregion

		#region Eventos y delegados		
		public event EventHandler DataChanged;
		public event EventHandler MotivoPadreChanged;
		public event EventHandler IdServiciosSelecionadosChanged;
		public event EventHandler MotivoTareaPadreChanged;
		#endregion

		#region Métodos  Públicos
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		public void ModifyMotivo(int index)
		{
			_brClass.ModifyMotivo(index);
		}

		public void ModifyMotivoHijo(int index, bool seleccionado)
		{
			_brClass.ModifyMotivoHijo(index, seleccionado);
		}

		public void ModifyMotivoTarea(int index)
		{
			_brClass.ModifyMotivoTarea(index);
		}

		public void ModifyMotivoTareaHijo(int index, bool seleccionado)
		{
			_brClass.ModifyMotivoTareaHijo(index, seleccionado);
		}

		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.tsy_MotivoOrdenReparacion( new string[] {"IdMotivo", "IdMotivoPadre", "Descripcion", "EsVerdadero", "EsFalso"}).GetLayoutEx()); 
		}

		public string GetLayoutObservaciones() 
		{			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdComentarioOrdenReparacion", "IdComentarioOrdenReparacion", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdOrdenReparacion", "IdOrdenReparacion", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha", 100, Types.Aligment.Center, Types.FormatDisplay.DateTime) );
			sb.Append( LayoutBuilder.GetRow( i++, "Usuario", "Usuario", 200) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 8000) );
            
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		public void SaveChanges()
		{
			_brClass.SaveChanges();
		}

		#endregion

		#region Métodos Privados
		
		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			_brClass.IdServiciosSelecionadosChanged += new EventHandler(_brClass_IdServiciosSelecionadosChanged);

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

		private void _brClass_IdServiciosSelecionadosChanged(object sender, EventArgs e)
		{
				if(IdServiciosSelecionadosChanged != null)
                    IdServiciosSelecionadosChanged(this, new EventArgs());
		}

	}
}
