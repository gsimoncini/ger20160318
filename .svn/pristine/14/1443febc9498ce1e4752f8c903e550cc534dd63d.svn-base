using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;



namespace mz.erp.ui.controllers
{

	#region clase auxiliar Movimiento
		
	
	#endregion
	/// <summary>
	/// Descripción breve de ConsutlasCaja.
	/// </summary>
	public class ConsultasCajaTDCompTesoreriaController: ITaskController
	{


		#region Custom members
		mz.erp.businessrules.ConsultasDeCaja _brClass;

		public object SelectedItem
		{
			set{_brClass.SelectedItem = value;}
			get{return _brClass.SelectedItem;}
		}
		

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskAfterExecute;
	
		public event System.EventHandler SoloAbiertasChanged;
		
		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;
		
		public ConsultasCajaTDCompTesoreriaController()
		{
			_brClass = new mz.erp.businessrules.ConsultasDeCaja();
			Init();
		}

		public ConsultasCajaTDCompTesoreriaController( mz.erp.businessrules.ConsultasDeCaja brClass )
		{
			_brClass = brClass;
			Init();
		}
		private void Init()
		{
			this._layoutFiltroCajas = this.GetLayoutFiltros();
			this._layoutFiltroTipos = this.GetLayoutFiltros();
			this._layoutFiltroUsuarios = this.GetLayoutFiltros();
			this._layoutFiltroResultado = this.GetLayoutResultado();
			
			this._brClass.ObjectHasChanged += new System.EventHandler( this.ListenerObjectHasChanged );
			
			this._brClass.SoloAbiertasChanged += new System.EventHandler( this.ListenerSoloAbiertasChanged );
			
			this._brClass.FechaAperturaChanged+= new System.EventHandler( this.ListenerFechaAperturaChanged );
			this._brClass.FechaCierreChanged+= new System.EventHandler( this.ListenerFechaCierreChanged );
			
		}
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
		
		private void ListenerSoloAbiertasChanged( object sender, System.EventArgs e)
		{
			if (this.SoloAbiertasChanged!=null)
			{
				SoloAbiertasChanged( this, e );
			}
		}
		


		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}


		public DataSet Data
		{
			get {return _brClass.Data; }
		}

		public void Execute() 
		{
			_brClass.Execute();
		}
		public void Previous()
		{
			_brClass.Previous();
		}
		public void RefreshData()
		{
			_brClass.RefreshData();
			_layoutFiltroResultado = this.GetLayoutResultado();
		}
		
		public bool AllowShow()
		{
			return true;
		}
		#endregion

		
		
		#region CABECERA, GRUPOS Y FILTROS DE LA GRILLA (FORMATOS PARA TODAS LAS CONSULTAS)

		public bool ObligaSeleccionItem()
		{
			switch (this._brClass.GetTaskName())
			{
				case "ConsultarMovimientosDeCaja": //pantalla de ajuste
					return true;
					break;
				case "ConsultarPosicionDeCajaDetallado": //pantalla para editar valores datos auxiliares
					return true;
					break;
			}
			return false;
		}

		public string LeyendaFormulario()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			string _leyenda = _leyenda = Variables.GetValueString("Momentos."+_nombreTarea +"."+_nombreProceso+".LeyendaFormulario");
			if (_leyenda =="" || _leyenda.Equals(string.Empty) || _leyenda == null)
				_leyenda = _nombreProceso + " " + _nombreTarea;
			return _leyenda;
			/*	
				"ConsultarCajaDetallada": ??
			*/
		}

		public string IdentificadorSelectedItem()
		{
			switch (this._brClass.GetTaskName())
			{
				case "ConsultasCobranzasYPagos":
					return "IdMovimiento";
					break;
				case "ConsultarMovimientosDeCaja":
					//return "IdMovimiento";
					return "IdValor";
					break;
				case "ConsultarPosicionDeCajaDetallado":
					return "IdValor";
					break;
			}
			return string.Empty;
		}


		private string GetLayoutResultado()
		{
			switch (this._brClass.GetTaskName())
			{
				case "ConsultarPosicionCaja":
					return LayoutConsultaDeCaja();
					break;
				case "ConsultasCobranzasYPagos":
					return LayoutConsultaCobranzasYPagos();
					break;
					//case "ConsultarCajaDetallada":
					//	return LayoutConsultaDeCajaDetallada();
					//	break;
				case "ConsultarMovimientosDeCaja":
					return LayoutConsultaMovimientosDeCaja();
					break;
				case "ConsultarPosicionDeCajaDetallado":
					return LayoutConsultarPosicionDeCajaDetallado();
					break;
				case "ConsultarValoresCajas":
					return LayoutConsultarPosicionDeCajaDetallado();
					break;
				
				default:
					return null;
			}
			return null;
		}

		public bool GetGruposEditables()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			bool _aux = Variables.GetValueBool("Momentos."+_nombreTarea +"."+_nombreProceso+".GruposGrillaEditables");
			return _aux;
		}

		public ArrayList GetGruposResultado()
		{			
			ArrayList array = new ArrayList();
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this.GetProcessManager().GetProcessName();				
			string valor = Variables.GetValueString(Proceso, Tarea, "ListaGruposDefault");
			if (valor != "")
				array = systemframework.Util.Parse(valor,",");			
			/*ArrayList array = new ArrayList();
			switch (this._brClass.GetTaskName())
			{
				case "ConsultasCobranzasYPagos":
				{
					array.Add("Caja");
					array.Add("Descripcion");
					array.Add("Subtipo");
					array.Add("Moneda");
					break;
				}
				case "ConsultarMovimientosDeCaja":
				{
					array.Add("Descripcion");
					array.Add("SubTipo");
					array.Add("Moneda");
					break;
				}
				case "ConsultarPosicionDeCajaDetallado":
				{
					array.Add("Descripcion");
					break;
				}
			}*/
			return array;
		}

		public bool AllowFiltrosGrilla()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			bool _aux = Variables.GetValueBool("Momentos."+_nombreTarea +"."+_nombreProceso+".AllowFiltrosGrilla");
			return _aux;
		}
	
		public string GetFilaTotalGroup()
		{	//retorna el nombre de la columna q se desea sumar
			switch (this._brClass.GetTaskName())
			{
				case "ConsultasCobranzasYPagos": //pantalla de ajuste
					return "Importe";
			}
			return "";
		}


		#endregion

		#region Tildar
		public void TildarEgresos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = items.Auxiliar.Equals("-1"); //en auxiliar se guarda el signo 
		}
		public void TildarIngresos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = items.Auxiliar.Equals("1"); //en auxiliar se guarda el signo 
		}

		public void TildarTodos()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = true;
		}
		
		public void TildarNinguno()
		{
			foreach( mz.erp.businessrules.ItemsFiltros items in this.FiltroTipos )
				items.Sel = false;
		}
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

		#endregion

		#region Filtros


		public bool EnabledSoloAbiertas()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			switch (_nombreTarea)
			{
				case "ConsultarMovimientosDeCaja":
				{
					if (_nombreProceso.Equals("ProcesoAjustarMovimientoCaja"))
						return false;
					else 
						return true;
					break;		
				}
			}
			return true;
		}
		
		public ArrayList FiltroTDCompTesoreria
		{
			get { return _brClass.FiltroTDCompTesoreria ; }
			set { _brClass.FiltroTDCompTesoreria = value ; }
		}
		public ArrayList FiltroCajas
		{
			get { return _brClass.FiltroCajas ; }
			set { _brClass.FiltroCajas = value ; }
		}
		public ArrayList FiltroUsuarios
		{
			get { return _brClass.FiltroUsuarios ; }
			set { _brClass.FiltroUsuarios = value; }
		}
		public ArrayList FiltroTipos
		{
			get { return _brClass.FiltroTipos ; }
			set { _brClass.FiltroTipos = value ; }
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

		private string _layoutFiltroResultado = string.Empty;
		private string _layoutFiltroCajas = string.Empty;
		private string _layoutFiltroUsuarios = string.Empty;
		private string _layoutFiltroTipos = string.Empty;
		public string LayoutFiltroCajas
		{
			get { return _layoutFiltroCajas ; }
		}
		public string LayoutFiltroUsuarios
		{
			get { return _layoutFiltroUsuarios; }
		}
		public string LayoutFiltroTipos
		{
			get { return _layoutFiltroTipos ; }
		}
		public string LayoutFiltroResultado
		{
			get { return _layoutFiltroResultado; }
		}

		public bool EsAjuste(string texto)
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			switch (_nombreTarea)
			{//esto es asquerosooooo, es temporal hasta arreglar las tabals de movimientos, donde se sabe cuando un movimientos es un ajuste y cuando no
				case "ConsultarMovimientosDeCaja":
				{
					if (_nombreProceso.Equals("ProcesoAjustarMovimientoCaja"))
						return (System.String.Compare(texto,0,"AJUSTE",0,6)==0);
					if (_nombreProceso.Equals("ProcesoEditarMovimientoCaja"))
						return (System.String.Compare(texto,0,"AJUSTE",0,6)==0);
					else return false;
					break;
				}
			}	
			return false;
		}
		public bool RevisarAjuste()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			switch (_nombreTarea)
			{
				case "ConsultarMovimientosDeCaja":
				{
					if (_nombreProceso.Equals("ProcesoAjustarMovimientoCaja"))
						return true;
					else return false;
				}
			}
			return false;
		}
		public bool DetallesVisibles()
		{
			//todo esto se podria pasar a variables de configuracion.
			string _nombreTarea = this._brClass.GetTaskName();
			switch (_nombreTarea)
			{
				case "ConsultarPosicionDeCajaDetallado":
				{
					return true;
				}
			}
			return false;
		}
	
		
		
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
		
		private string LayoutConsultaDeCajaDetallada()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money)  );
			sb.Append( LayoutBuilder.GetRow( i++, "MonedaReferencia", "Moneda", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money)  );

			sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento","F.Vencimiento", 80 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		private string LayoutConsultaCobranzasYPagos()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMovimiento", "IdMovimiento", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Caja", "Caja", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Cuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Subtipo", "SubCuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TipoComprobante", "Comprobante", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Medio", "Medio de Pago", 100 ) );			
			sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", 60 ) );
			
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 50) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cliente", "Cliente", 100 ) );


			sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 200 ) );
					
			sb.Append( LayoutBuilder.GetRow( i++, "Apertura","F.Apertura Caja", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cierre","F.Cierre Caja", 60 ) );

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		private string LayoutConsultaMovimientosDeCaja()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMovimiento", "IdMovimiento", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdValor","IdValor", true) );

			sb.Append( LayoutBuilder.GetRow( i++, "Caja", "Caja", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Cuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Subtipo", "SubCuenta", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Tipo", "Comprobante", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", 100 ) );

			sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Medio de Pago", 100 ) );			
			sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", 60 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Apertura","F.Apertura Caja", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cierre","F.Cierre Caja", 60 ) );
			

			
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();
		}

		private string LayoutConsultarPosicionDeCajaDetallado()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			#region informacion general del valor
			sb.Append( LayoutBuilder.GetRow( i++, "idcuenta", "IdCuenta", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "codigo", "Código", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cliente", "Cliente", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "idValor", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", false) );
			#region retenciones	
			sb.Append( LayoutBuilder.GetRow( i++, "Tipo Ret.", "Tipo Ret.", false) );
			#endregion 
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha Venc.", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
			#endregion
			#region tarjetas
			//sb.Append( LayoutBuilder.GetRow( i++, "MonedaReferencia", "Moneda Referencia", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo Autoriz.", "Código Autoriz.", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cupon", "Cupón", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha de Acredit.", "Fecha de Acredit.", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha Autoriz.", "Fecha Autoriz.", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Lote", "Lote", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cant. Cuotas", "Cant. Cuotas", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo 10", "Código 10", false) );
			#endregion
			#region cheques
			sb.Append( LayoutBuilder.GetRow( i++, "Cta. Bancaria", "Cta. Bancaria", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Librador", "Librador", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha Pago", "Fecha Pago", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha Recep.", "Fecha Recep.", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha Ing. Banco", "Fecha Ing. Banco", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nro Boleta", "Nro Boleta", false) );
			#endregion
			#region cajas , responsable y HTML
			//sb.Append( LayoutBuilder.GetRow( i++, "UltimaInstanciaDeCaja", "UltimaInstanciaDeCaja", true) );
			//sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Caja", "Caja", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado", false) );
			//sb.Append( LayoutBuilder.GetRow( i++, "IdPersona", "IdPersona", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre", false) );
			sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "TextoHTML", true) );
			#endregion
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();
		}
		
		private string LayoutConsultaDeCaja()
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "Instancia", "Caja", 400 ) );
			/*sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable", 150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TipoDeMovimiento", "Descripcion", 150 ) );*/
			sb.Append( LayoutBuilder.GetRow( i++, "ComprobanteMoneda", "Forma de Pago", 200 ) );
			//sb.Append( LayoutBuilder.GetRow( i++, "Total", "Importe", 80, Types.Aligment.Far, )  );
			sb.Append( LayoutBuilder.GetRow( i++, "Total", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		#endregion

		public string GetProcessName()
		{
			return _brClass.GetProcessManagerParent().Process.ProcessName;
		}

		public string GetFormText()
		{
			return _brClass.GetFormText();
		}

		
		
		#region Miembros de ITaskController

		ProcessControllerManager _process; 

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public bool AllowPrevious()
		{
			// TODO: agregar la implementación ConsultasCajaController.AllowPrevious
			return false;
		}

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_process = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _process;
			
		}

		public bool IsFirstTask()
		{
			// TODO: agregar la implementación ConsultasCajaController.IsFirstTask
			return true;
		}

		public bool IsNextState()
		{
			// TODO: agregar la implementación ConsultasCajaController.IsNextState
			return false;
		}

		public bool IsBackState()
		{
			// TODO: agregar la implementación ConsultasCajaController.IsBackState
			return false;
		}

		public bool IsFlushedState()
		{
			// TODO: agregar la implementación ConsultasCajaController.IsFlushedState
			return false;
		}

		#endregion

	}
}
