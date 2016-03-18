using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarProductosConPreciosModificadosController.
	/// </summary>
	public class ConsultarProductosConPreciosModificadosController: IObserver,ITaskController
	{
		#region Constructores
		public ConsultarProductosConPreciosModificadosController(ConsultarProductosConPreciosModificados brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarProductosConPreciosModificados _brClass;
		
		#endregion

		#region Propiedades

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

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		private DataTable _listaDePrecios = null;
		public System.Data.DataTable ListaDePrecios
		{
			get {return _listaDePrecios;}
		}
		public string KeyValueListaDePrecios
		{
			get { return "IdListaDePrecio" ; }
		}				
		public string KeyListListaDePrecios
		{
			get { return "Descripcion" ; }
		}

		private bool _listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios"); 
		public bool ListaDePreciosHabilitadas
		{
			get{return _listaDePreciosHabilitadas;}
		}

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}

		public string IdListaDePrecios
		{
			get { return _brClass.IdListaDePrecios; }
			set {_brClass.IdListaDePrecios = value;}
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

		public string Codigo
		{
			get
			{
				return _brClass.CodigoProducto;
			}
			set
			{
				_brClass.CodigoProducto = value;
			}
		}

		public bool PorUltimaFechaModifPcioCosto
		{
			get{return _brClass.PorUltimaFechaModifPcioCosto;}
			set{_brClass.PorUltimaFechaModifPcioCosto = value;}
		}	

		public bool PorUltimaFechaModifPcioVta
		{
			get{return _brClass.PorUltimaFechaModifPcioVta;}
			set{_brClass.PorUltimaFechaModifPcioVta = value;}
		}	
		
		public DateTime FechaUltimaModifPcioCostoDesde
		{
			get{return _brClass.FechaUltimaModifPcioCostoDesde;}
			set{_brClass.FechaUltimaModifPcioCostoDesde = value;}
		}	

		public DateTime FechaUltimaModifPcioCostoHasta
		{
			get{return _brClass.FechaUltimaModifPcioCostoHasta;}
			set{_brClass.FechaUltimaModifPcioCostoHasta = value;}
		}	

		public DateTime FechaUltimaModifPcioVtaDesde
		{
			get{return _brClass.FechaUltimaModifPcioVtaDesde;}
			set{_brClass.FechaUltimaModifPcioVtaDesde = value;}
		}	

		public DateTime FechaUltimaModifPcioVtaHasta
		{
			get{return _brClass.FechaUltimaModifPcioVtaHasta;}
			set{_brClass.FechaUltimaModifPcioVtaHasta = value;}
		}	
		#endregion

		#region Eventos y delegados		
		public event EventHandler DataChanged;
		public event EventHandler OnModelChanged;
		#endregion

		#region Métodos  Públicos 
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, string tipoFecha, bool ordenInverso)
        {
            this._brClass.updateFechas(fechaDesde, tipoFecha, ordenInverso);

        }
        //Fin Cristian 20110725
        //Fin Cristian
		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{			
			_listaDePrecios = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
		}

		private void InitEventHandlers()
		{
		}

		private void RefreshData(object sender, EventArgs e)
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;	
				if (lista.Count == 0) this.Codigo = "00000000";
				else 
				{
					foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
					{					
						this.Codigo = item.Codigo;	
					}
					if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
				}
			}
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
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion


	}
}
