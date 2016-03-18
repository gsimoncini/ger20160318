using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;

using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SeguimientoDeArticulos.
	/// </summary>
	public class SeguimientoDeArticulos:  ITaskConsultaComprasController
	{
		#region Contructores
		private mz.erp.businessrules.SeguimientoDeArticulos _seguimiento;
		public SeguimientoDeArticulos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public SeguimientoDeArticulos(mz.erp.businessrules.SeguimientoDeArticulos seguimiento)
		{
			_seguimiento = seguimiento;
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
/*
 		private void Init()
		{
			this._layoutFiltroResultado = this.GetLayoutResultado();
			
			
		}

		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

 * */
		#endregion
		#region Variables Públicas
		//public event EventHandler OnTaskAfterExecute;			
		public event System.EventHandler ObjectHasChanged;
		#endregion
		#region Propiedades
		public string LeyendaFormulario
		{
			get { return _seguimiento.LeyendaFormulario ; }
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _seguimiento.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _seguimiento.TextoBotonAnterior;
			}
		}		

		public string Codigo
		{
			get
			{
				return _seguimiento.Codigo;
			}
			set
			{
				_seguimiento.Codigo = value;
			}
		}

		

		#endregion
		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
						
		#endregion
		#region Variables Privadas Datos		

		public bool IsValid 
		{
			get {return _isValid;}
		}

		/*private string _monedaValueMember = "IdMoneda";
		public string MonedaValueMember 
		{
			get {return _monedaValueMember;}
		}

		private string _monedaDisplayMember = "Descripcion";
		public string MonedaDisplayMember 
		{
			get {return _monedaDisplayMember;}
		}

		private string _monedaSortedMember = "Descripcion";
		public string MonedaSortedMember 
		{
			get {return _monedaSortedMember;}			
		}
 		
		private string _fuenteDeCambioValueMember = "IdFuenteDeCambio";
		public string FuenteDeCambioValueMember 
		{
			get {return _fuenteDeCambioValueMember;}
		}

		private string _fuenteDeCambioDisplayMember = "Descripcion";
		public string FuenteDeCambioDisplayMember 
		{
			get {return _fuenteDeCambioDisplayMember;}
		}


		private string _fuenteDeCambioSortedMember = "Descripcion";
		public string FuenteDeCambioSortedMember 
		{
			get {return _fuenteDeCambioSortedMember;}			
		} 
 
		public DataTable Monedas
		{
			get
			{
				return _abm.Monedas;
			}
		}
		public DataTable FuentesDeCambio
		{
			get
			{
				return _abm.FuentesDeCambio;
			}
		}		

		public string IdMonedaOrigen
		{
			get {return _abm.IdMonedaOrigen;}
			set 
			{
				if (_abm.IdMonedaOrigen!= value) 
				{
					_abm.IdMonedaOrigen = value;
					if(IdMonedaOrigenChanged != null)
						IdMonedaOrigenChanged(this, new EventArgs());	
				}				
			}		
		}

		public string IdMonedaDestino
		{
			get {return _abm.IdMonedaDestino;}
			set 
			{
				if (_abm.IdMonedaDestino!= value) 
				{
					_abm.IdMonedaDestino = value;
					if(IdMonedaDestinoChanged != null)
						IdMonedaDestinoChanged(this, new EventArgs());	
				}				
			}
		}

		public string IdFuenteDeCambio
		{
			get {return _abm.IdFuenteDeCambio;}
			set 
			{
				if (_abm.IdFuenteDeCambio!= value) 
				{
					_abm.IdFuenteDeCambio = value;
					if(IdFuenteDeCambioChanged != null)
						IdFuenteDeCambioChanged(this, new EventArgs());	
				}				
			}
		}

		
		public decimal Cotizacion
		{
			get {return _abm.Cotizacion;}
			set {_abm.Cotizacion = value;}
		}
		*/
		#endregion
		#region Eventos y delegados
			
		/*public event EventHandler IdMonedaOrigenChanged;		
		public event EventHandler IdMonedaDestinoChanged;		
		public event EventHandler IdFuenteDeCambioChanged;		*/
		#endregion
		#region Métodos  Públicos			

		#endregion
		#region Métodos  Privados

		private void InitializeData()
		{
			//_allowShow = _cierre.AllowShow();
		}
		
		private void InitEvents()
		{
			this._seguimiento.ObjectHasChanged +=new EventHandler(this.ListenerObjectHasChanged);						
		}

		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}
		private void Listener(object Sender, System.EventArgs e)
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
			return this._processManager.IsFirstTask(_seguimiento.GetTaskName());
		}

		public string GetTaskName()
		{
			return _seguimiento.GetTaskName();
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
			return _seguimiento.AllowPrevious();
		}

		public void Previous()
		{
			_seguimiento.Previous();
		}
		public void Continue()
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _seguimiento.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			//Listener( this, new System.EventArgs());
			_seguimiento.RefreshData();			
		}

		public void Execute() 
		{													
			this._seguimiento.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._seguimiento;
		}
			
		#endregion

		#region Miembros de ITaskConsultaComprasController
		public ReportFilterArray GetFiltro() 
		{
			ReportFilterArray filtros = new ReportFilterArray();
			return filtros;
		}

		public System.Data.DataTable GetResult()
		{			
			return _seguimiento.Result;
		}

		public Type GetProductos()
		{
			return typeof(mz.erp.ui.controllers.tsh_Productos);
		}


		public string GetLayout() 
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad", 50, Types.Aligment.Far, Types.FormatDisplay.Integer));
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 120, Types.Aligment.Near, Types.FormatDisplay.DateTime));
			sb.Append( LayoutBuilder.GetRow( i++, "Movimiento", "Movimiento", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo de comprobante", 120 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nómero", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cliente", "Cliente", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Progresion", "Progresión", 80, Types.Aligment.Far, Types.FormatDisplay.Integer));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();					
		}

		public ArrayList GetJerarquias()
		{
			ArrayList jerarquias = new ArrayList();
			return jerarquias;
		}

		#endregion		

	}
}
