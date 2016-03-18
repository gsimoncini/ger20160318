using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;



namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesPendientesConsolaEntregas.
	/// </summary>
	public class ComprobantesPendientesConsolaEntregas: ITaskController
	{
		mz.erp.businessrules.ComprobantesPendientesConsolaEntregas _brClass;
		public ComprobantesPendientesConsolaEntregas(mz.erp.businessrules.ComprobantesPendientesConsolaEntregas brClass)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_brClass= brClass;
			_brClass.ObjectHasChanged+= new System.EventHandler( this.ListenerObjectHasChanged );
			_brClass.IdComprobanteEntregaChanged+=new EventHandler(this.ListenerIdComprobanteEntregaChanged);
			_brClass.IdComprobantePrevioChanged+=new EventHandler(this.ListenerIdComprobantePrevioChanged);
			Init();
		}
        //German 20120413 - Tarea 0000247
        public string CodigoCuenta
        {
            get { return _brClass.CodigoCuenta; }
            set { _brClass.CodigoCuenta = value; }
        }
        //Fin German 20120413 - Tarea 0000247
		#region Miembros de ITaskController
		private string _layoutGridPreComprobantes;
		private string _layoutGridComprobantesEntrega;
		private string _layoutDetallePreComprobantes;
		private string _layoutDetalleComprobantesEntrega;

		private bool _allowMultipleSelect = false;
		private bool _allowEditFechas = false;
		private string _contenedoresVisibles = string.Empty;


		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}

		public bool AllowEditarFechas
		{
			get{return _allowEditFechas;}
		}
		public bool AllowMultipleSelect
		{
			get
			{
				return _allowMultipleSelect;
			}
			set
			{
				_allowMultipleSelect= true;
			}
		}

		public bool VerHTML
		{
			get{return _brClass.VerHTML;}
		}

		public string MetodoVisualizacionHTML
		{
			get{return _brClass.MetodoVisualizacionHTML;}
		}
		public string LayoutGridPreComprobantes
		{
			get { return _layoutGridPreComprobantes; }
		}
		public string LayoutGridComprobantesEntrega
		{
			get { return _layoutGridComprobantesEntrega; }
		}
		public string LayoutDetallePreComprobantes
		{
			get { return _layoutDetallePreComprobantes; }
		}
		public string LayoutDetalleComprobantesEntrega
		{
			get { return _layoutDetalleComprobantesEntrega; }
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
		}
		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		ProcessControllerManager _processControllerParent;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processControllerParent = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processControllerParent;
		}

		public  bool IsFlushedState()
		{
			return this.GetProcessManager().ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this.GetProcessManager().IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this.GetProcessManager().IsBackState();
		}

		public  bool IsFirstTask()
		{
			return this.GetProcessManager().IsFirstTask(_brClass.GetTaskName());
		}

		public  bool IsLastTask()
		{
			return this.GetProcessManager().IsLastTask(_brClass.GetTaskName());
		}

		public event System.EventHandler OnControllerChanged;
		public event System.EventHandler IdComprobantePrevioChanged;
		public event System.EventHandler IdComprobanteEntregaChanged;
		public event System.EventHandler FechaDesdeChanged;
		public event System.EventHandler FechaHastaChanged;

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			if (this.OnControllerChanged != null)
				this.OnControllerChanged(this,new System.EventArgs() );
		}

		private void ListenerIdComprobantePrevioChanged(object sender, System.EventArgs e)
		{
			if (this.IdComprobantePrevioChanged != null)
				this.IdComprobantePrevioChanged(this,new System.EventArgs() );
		}

		private void ListenerIdComprobanteEntregaChanged(object sender, System.EventArgs e)
		{
			if (this.IdComprobanteEntregaChanged != null)
				this.IdComprobanteEntregaChanged(this,new System.EventArgs() );
		}


		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}
		public string GetProcessName()
		{
			return _processControllerParent.GetProcessName();
		}


		public DateTime FechaDesde
		{
			get { return _brClass.FechaDesde; }
			set { _brClass.FechaDesde = value ;}
		}
		public DateTime FechaHasta
		{
			get { return _brClass.FechaHasta ; }
			set { _brClass.FechaHasta = value ;}
		}
		public string KeyComprobantesPrevios
		{
			get { return "IdComprobante" ; }
		}
		public string KeyComprobantesEntrega
		{
			get { return "IdComprobante" ; }
		}
		public object KeyValueComprobantesPrevios
		{
			set { _brClass.IdComprobantePrevio = Convert.ToString(value) ; }
		}
		public object KeyValueComprobanteEntrega
		{
			set { _brClass.IdComprobanteEntrega = Convert.ToString(value) ; }
		}
		public DataTable ComprobantesPrevios
		{
			get { return _brClass.DataComprobantesPrevios ;}
		}
		public DataTable ComprobantesEntrega
		{
			get { return _brClass.DataOrdenesPendientes ; }
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get { return _textoBotonSiguiente ; }
		}
		private string _textoBotonPrevio = "Anterior";
		public string TextoBotonPrevio
		{
			get { return _textoBotonPrevio ; }
		}
		private string _leyendaFormulario = "Comprobantes pendientes de entrega";
		
		public string LeyendaFormulario 
		{
			get {return _leyendaFormulario;}
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
		}

		private void Init()
		{
			this._layoutGridPreComprobantes=Build_LayoutComprobantes();
			this._layoutGridComprobantesEntrega=Build_LayoutComprobantes();
			if (_brClass.TextoBotonPrevio.CompareTo( string.Empty ) != 0)
			{
				this._textoBotonPrevio = _brClass.TextoBotonPrevio;
			}
			if (_brClass.TextoBotonSiguiente.CompareTo( string.Empty) != 0)
			{
				this._textoBotonSiguiente = _brClass.TextoBotonSiguiente;
			}
			_leyendaFormulario = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario");
			if(_leyendaFormulario.Equals(string.Empty))
				_leyendaFormulario = "Comprobantes pendientes de entrega";
			_preguntarAlCancelar = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PreguntarAlCancelar");
			_allowMultipleSelect = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "AllowMultipleSelect");
			_contenedoresVisibles = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "HabilitaContenedores");
			_allowEditFechas = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "PermiteEditarFechas");

		}
		private string Build_LayoutComprobantes()
		{
			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "T. Comp",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",100 ) );
			if(_brClass.PorFechaDeVencimiento)
				sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "F. Venc.",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "F. Emisión",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "TextoHTML",8000 , true) );
			
			

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
		}

		public string GetWarnings()
		{
			return 	null;
		}
		public void Continue()
		{
		}

        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _brClass.updateFechas(fechaDesde, ordenInverso);

        }
        //Fin Cristian
		#endregion
	}
}
