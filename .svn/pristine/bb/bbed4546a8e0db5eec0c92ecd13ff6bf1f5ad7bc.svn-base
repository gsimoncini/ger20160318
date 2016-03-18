using System;
using System.Data;
using System.Text;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompraCabeceraController.
	/// </summary>
	public class IngresarComprobanteDeCompraCabeceraController: ITaskController, mz.erp.commontypes.IObserver
	{
		public IngresarComprobanteDeCompraCabeceraController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_brClass = new businessrules.IngresarComprobanteDeCompraCabecera();
			Init();
		}
		public IngresarComprobanteDeCompraCabeceraController(businessrules.IngresarComprobanteDeCompraCabecera brClass)
		{
			_brClass = brClass;
			Init();
		}
		private void Init()
		{
			InitializeData();
			InitEventHandlers();
		}
		private void InitializeData()
		{			
			SetLeyendaFormulario();
			SetLayoutConceptos();
			_tableImpuestosAsociadosNetosGravados.Clear();
			_tableImpuestosAsociadosNetosNOGravados.Clear();	
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);

		}
		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged+=new EventHandler(ListenerObjectHasChanged);
			_brClass.FechaVencimientoChanged +=new EventHandler(_brClass_FechaVencimientoChanged);
			_brClass.DiasVencimientoChanged +=new EventHandler(_brClass_DiasVencimientoChanged);
			_brClass.IdCuentaImputacionChanged +=new EventHandler(_brClass_IdCuentaImputacionChanged);
			_brClass.IdCuentaImputacionProveedorChanged +=new EventHandler(_brClass_IdCuentaImputacionProveedorChanged);
			_brClass.IdSubCuentaImputacionProveedorChanged += new EventHandler(_brClass_IdSubCuentaImputacionProveedorChanged);	
			_brClass.NetoChanged +=new EventHandler(_brClass_NetoChanged);
			_brClass.TotalChanged +=new EventHandler(_brClass_TotalChanged);
			_brClass.TipoDeComprobanteDestinoChanged +=new EventHandler(_brClass_TipoDeComprobanteDestinoChanged);
			_brClass.IdMonedaOrigenChanged +=new EventHandler(_brClass_IdMonedaOrigenChanged);
			_brClass.TotalUsuarioChanged +=new EventHandler(_brClass_TotalUsuarioChanged);
			_brClass.NetoItemsOriginalChanged +=new EventHandler(_brClass_NetoItemsOriginalChanged);
			_brClass.CondicionDeCompraChanged +=new EventHandler(_brClass_CondicionDeCompraChanged);
			_brClass.NetosCollectionChanged += new EventHandler(_brClass_NetosCollectionChanged);
            //German 20120510 - Tarea 0000320
            _brClass.ProximaFechaVencimientoChanged += new EventHandler(_brClass_ProximaFechaVencimientoChanged);
            //Fin German 20120510 - Tarea 0000320
	
			
		}
        //German 20120510 - Tarea 0000320
        void _brClass_ProximaFechaVencimientoChanged(object sender, EventArgs e)
        {
            if(ProximaFechaVencimientoChanged != null)
                ProximaFechaVencimientoChanged(this, EventArgs.Empty);
        }
        //Fin German 20120510 - Tarea 0000320
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			/*if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName() +".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}*/
			this._leyendaFormulario = leyenda;
		}
		private void SetLayoutConceptos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
            sb.Append(LayoutBuilder.GetRow(i++, "IdConcepto", "IdConcepto", 75, true));
            sb.Append(LayoutBuilder.GetRow(i++, "IdImpuesto", "IdImpuesto", 50, true));			
			sb.Append( LayoutBuilder.GetRow( i++, "Concepto", "Concepto",150, Types.EditType.NoEdit) );
			sb.Append( LayoutBuilder.GetRow( i++, "Impuesto", "Impuesto",150, Types.EditType.NoEdit) );
            //German 20101025 Tarea 879
            //sb.Append(LayoutBuilder.GetRow(i++, "MontoNeto", "Neto", 75, Types.EditType.NoEdit));
            sb.Append(LayoutBuilder.GetRow(i++, "MontoNeto", "Neto", 75, Types.EditType.TextBox));
            //Fin German 20101025 Tarea 879
			sb.Append( LayoutBuilder.GetRow( i++, "PorcentajeImpuesto", "%",75, Types.EditType.NoEdit) );
            //Cristian 20101025 Tarea 879
			sb.Append( LayoutBuilder.GetRow( i++, "MontoImpuesto", "valor Imp.",75, Types.EditType.TextBox) );
            //Fin Tarea 879
			sb.Append( LayoutBuilder.GetFooter() );
		
			_layoutConceptos =  sb.ToString();		
		}
		#region Eventos y delegados
		public event EventHandler ItemsChanged;
		public event EventHandler KeyValueProveedoresChanged;		
		public event EventHandler KeyValueTiposDeComprobantesChanged;		
		/*public event EventHandler NumeroComprobanteChanged;
		public event EventHandler ResponsableDeEmisionChanged;
		public event EventHandler FechaChanged;
		public event EventHandler FechaRegistracionChanged;
		public event EventHandler ObservacionesChanged;
		public event EventHandler TotalChanged;
		public event EventHandler ValorCotizacionChanged;
		public event EventHandler IdMonedaOrigenChanged;
		public event EventHandler IdFuenteDeCambioProveedorChanged;
		public event EventHandler ValorCotizacionProveedorChanged;*/
		public event EventHandler DiasVencimientoChanged;
		public event EventHandler FechaVencimientoChanged;
        //German 20120510 - Tarea 0000320
            public event EventHandler ProximaFechaVencimientoChanged;
        //Fin German 20120510 - Tarea 0000320
	
		public event EventHandler IdCuentaImputacionChanged;
		public event EventHandler IdSubCuentaImputacionChanged;
		public event EventHandler CuentaImputacionChanged;
		public event EventHandler CuentaImputacionProveedorChanged;
		public event EventHandler SubCuentaImputacionProveedorChanged;

		public event EventHandler IdNetoGravadoChanged;
		public event EventHandler IdNetoNOGravadoChanged;
		public event EventHandler IdImpuestoAsociadoNetoGravadoChanged;
		public event EventHandler IdImpuestoAsociadoNetoNOGravadoChanged;
		public event EventHandler NetosGravadosCollectionChanged;
		public event EventHandler NetosCollectionChanged;
		public event EventHandler NetosNOGravadosCollectionChanged;
		public event EventHandler CalculoNOGravadoChanged;
		public event EventHandler CalculoGravadoChanged;
		public event EventHandler NetoGravadoAplicadoChanged;
		public event EventHandler NetoNOGravadoAplicadoChanged;
        //German 2011104 - Tarea 914
		public event EventHandler NetoChangedAux;
        //Fin German 2011104 - Tarea 914
		public event EventHandler TotalChanged;
		public event EventHandler TipoDeComprobanteDestinoChanged;
		public event EventHandler ConceptoRepetidoError;
		public event EventHandler NetoAcumuladoInvalidoError;
		public event EventHandler SimboloMonedaOrigenChanged;
		public event EventHandler TotalUsuarioMonedaReferenciaChanged;
		public event EventHandler ImpuestosChanged;
		public event EventHandler ValorImpuestoAplicadoNetoGravadoChanged;
		public event EventHandler ValorImpuestoAplicadoNetoNOGravadoChanged;
		public event EventHandler NetoItemsOriginalChanged;
		public event EventHandler IdCondicionDeCompraChanged;

		#endregion

		#region Variables Privadas

			private businessrules.IngresarComprobanteDeCompraCabecera _brClass;
			private ProcessControllerManager _processManager;
			
		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
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

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		
		public ProcessControllerManager GetProcessManager()
		{
			
			return _processManager;
		}

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
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		#endregion
		#region Metodos Publicos

		public void RemoveItem (businessrules.comprobantes.ItemComprobanteCompra item)
		{
			_brClass.RemoveItem(item);
		}


		public bool IsEditable( object selectedItem, string Propiedad)
		{
			if(!_brClass.AllowEditItems) return false;
			/*
			string colaVariable = string.Empty;
			ItemComprobanteCompra item = (ItemComprobanteCompra) selectedItem;
			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._brClass.GetTaskName();
			bool habilitaComodines = Variables.GetValueBool(nombreProceso, nombreTarea, "Emision.Editar.Items.HabilitaItemComodin");
			string comodines = Variables.GetValueString(nombreProceso, nombreTarea, "Emision.Editar.Items.ListaItemComodin");
			ArrayList aux = systemframework.Util.Parse(comodines,",");
			if(habilitaComodines && aux.Contains(item.Codigo))
				colaVariable = "Emision.Editar.ItemComodin." + Propiedad;
			else
				colaVariable = "Emision.Editar." + Propiedad;
			bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
			return item.AllowEdit && result; //&& (!habiltaComodines || (habiltaComodines && aux.Contains(item.Codigo)));
			*/
			ItemComprobanteCompra item = (ItemComprobanteCompra) selectedItem;

			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._brClass.GetTaskName();
			string colaVariable = string.Empty;

			if(Propiedad.Equals("Cantidad"))
				if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
				{
					colaVariable = "Emision.Editar.Step." + Propiedad;
					bool result1 = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
					return result1;
				}

			colaVariable = "Emision.Editar." + Propiedad;
			bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
			return item.AllowEdit && result; //&& (!habiltaComodines || (habiltaComodines && aux.Contains(item.Codigo)));
			
		}


		public bool IsRemovable( object selectedItem)
		{
			ItemComprobanteCompra item = (ItemComprobanteCompra) selectedItem;
			if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
			{
				string nombreProceso = this._processManager.GetProcessName();
				string nombreTarea = this._brClass.GetTaskName();
				string colaVariable = string.Empty;
				colaVariable = "Emision.Step.Delete.Items";
				bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
				return result;
			}
			return item.AllowEdit;
		}
        //Cristian Tarea 879
        //German 20101111 - Tarea 933
        public void updateNetoAplicado(String idConcepto, string IdImpuesto, decimal valorImpuetsoModificado)
        {
            this._brClass.updateNetoAplicable(idConcepto, IdImpuesto, valorImpuetsoModificado);
        }
        //Fin German 20101111 - Tarea 933
        //Fin Tarea 879
        //German Tarea 879
        //German 20101111 - Tarea 933
        public void updateImpuesto(String idConcepto, String IdImpuesto, decimal valorNetoModificado)
        {
            this._brClass.updateImpuesto(idConcepto,IdImpuesto,  valorNetoModificado);
        }
        //Fin German 20101111 - Tarea 933
        //Fin Tarea 879
	
		
		public void AddNetoGravado(string IdNetoGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			try
			{
				_brClass.AddNetoGravado(IdNetoGravado, DescripcionNeto ,IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
				if(NetosGravadosCollectionChanged != null)
					NetosGravadosCollectionChanged(this, new EventArgs());
			}
			catch(ConceptoRepetidoException cre)
			{
				if(ConceptoRepetidoError != null)
					ConceptoRepetidoError(this, new EventArgs());
			}
			catch(NetoAcumuladoInvalidoException naie)
			{
				if(NetoAcumuladoInvalidoError != null)
					NetoAcumuladoInvalidoError(this, new EventArgs());
			}
		}
		public void AddNetoNOGravado(string IdNetoGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			try
			{
				_brClass.AddNetoNOGravado(IdNetoGravado, DescripcionNeto ,IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
				if(NetosNOGravadosCollectionChanged != null)
					NetosNOGravadosCollectionChanged(this, new EventArgs());
			}
			catch(ConceptoRepetidoException cre)
			{
				//throw cre;
			}
			catch(NetoAcumuladoInvalidoException naie)
			{
				//throw naie;
			}
		}
		public void RefreshTotal()
		{
			_brClass.RefreshTotal();
		}
	
		public string FillNumberWithZeros(string txt)
		{
			return _brClass.FillNumberWithZeros(txt);
		}

		#endregion
		#region Variables Publicas Interfaz
		public bool AllowEditObservaciones
		{
			get
			{
				return _brClass.AllowEditObservaciones;
			}
		}

		public bool AllowEditNetoItemsReal
		{
			get
			{
				return _brClass.AllowEditNetoItemsReal;
			}
		}

		public bool AllowEditNetoItems
		{
			get
			{
				return _brClass.AllowEditNetoItems;
			}
		}

		public bool AllowEditTotal
		{
			get
			{
				return _brClass.AllowEditTotal;
			}
		}

		public bool AllowEditPorcentajeDescuentoGeneral
		{
			get
			{
				return _brClass.AllowEditPorcentajeDescuentoGeneral;
			}
		}

		public bool AllowEditDescuentoGeneral
		{
			get
			{
				return _brClass.AllowEditDescuentoGeneral;
			}
		}

		public bool AllowEditTotalGeneral
		{
			get
			{
				return _brClass.AllowEditTotalGeneral;
			}
		}

		public bool AllowEditTotalConceptoNOGravado
		{
			get
			{
			return _brClass.AllowEditTotalConceptoNOGravado;
			}
		}

		public bool AllowEditValorImpuestoAplicadoConceptoNOGravado
		{
			get
			{
				return _brClass.AllowEditValorImpuestoAplicadoConceptoNOGravado;
			}
		}

		public bool AllowEditPorcentajeImpuestoAplicadoConceptoNOGravado
		{
			get
			{
				return _brClass.AllowEditPorcentajeImpuestoAplicadoConceptoNOGravado;
			}
		}

		public bool AllowEditTipoConceptoNoGravado
		{
			get
			{
				return _brClass.AllowEditTipoConceptoNoGravado;
			}
		}
		
		public bool AllowEditImpuestoAplicadoConceptoNOGravado
		{
			get
			{
				return _brClass.AllowEditImpuestoAplicadoConceptoNOGravado;
			}
		}

		public bool AllowEditConceptoNoGravadoAplicado
		{
			get
			{
				return _brClass.AllowEditConceptoNoGravadoAplicado;
			}
		}

		public bool AllowEditConceptosNoGravados
		{
			get
			{
				return _brClass.AllowEditConceptosNoGravados;
			}
		}

		public bool AllowEditNetosGravados
		{
			get
			{
				return _brClass.AllowEditNetosGravados;
			}
		}

		public bool AllowEditTotalNetoGravado
		{
			get
			{
				return _brClass.AllowEditTotalNetoGravado;
			}
		}

		public bool AllowEditValorImpuestoAplicadoNetoGravado
		{
			get
			{
				return _brClass.AllowEditValorImpuestoAplicadoNetoGravado;
			}
		}

		public bool AllowEditPorcentajeImpuestoAplicadoNetoGravado
		{
			get
			{
				return _brClass.AllowEditPorcentajeImpuestoAplicadoNetoGravado;
			}
		}

		public bool AllowEditNetoGravadoAplicado
		{
			get
			{
				return _brClass.AllowEditNetoGravadoAplicado;
			}
		}

		public bool AllowEditImpuestoAplicadoNetoGravado
		{
			get
			{
				return _brClass.AllowEditImpuestoAplicadoNetoGravado;
			}
		}

		public bool AllowEditTipoDeNetoGravados
		{
			get
			{
				return _brClass.AllowEditTipoDeNetoGravados;
			}
		}

		public bool AllowEditTotalDesdeImpuestos
		{
			get
			{
				return _brClass.AllowEditTotalDesdeImpuestos;
			}
		}

		public bool AllowEditTotalUsuarioMonedaReferencia
		{
			get
			{
				return _brClass.AllowEditTotalUsuarioMonedaReferencia;
			}
		}

		public bool AllowEditTotalUsuario
		{
			get
			{
				return _brClass.AllowEditTotalUsuario;
			}
		}

		public bool AllowEditImpuestos
		{
			get
			{
				return _brClass.AllowEditImpuestos;
			}
		}


		public bool AllowEditCondicionDeCompra
		{
			get
			{
				return _brClass.AllowEditCondicionDeCompra;
			}
		}

		public bool AllowEditFecha
		{
			get
			{
				return _brClass.AllowEditFecha;
			}
		}

		public bool AllowEditFechaRegistracion
		{
			get
			{
				return _brClass.AllowEditFechaRegistracion;
			}
		}

		public bool AllowEditSubcuentaImputacion
		{
			get
			{
				return _brClass.AllowEditSubcuentaImputacion;
			}
		}

		public bool AllowEditCuentaImputacion
		{
			get
			{
				return _brClass.AllowEditCuentaImputacion;
			}
		}

		public bool AllowEditItems
		{
			get
			{
				return _brClass.AllowEditItems;
			}
		}

		public bool AllowDeleteItems
		{
			get
			{
				return _brClass.AllowDeleteItems;
			}
		}
		
		public bool AllowAddItems
		{
			get
			{
				return _brClass.AllowAddItems;
			}
		}

		public bool AllowEditLeyenda
		{
			get{return _brClass.AllowEditLeyenda;}
		}
		

		
		public bool AllowEditMesImputacion
		{
			get{return _brClass.AllowEditMesImputacion;}
		}

		public bool AllowEditMesDevengamiento
		{
			get{return _brClass.AllowEditMesDevengamiento;}
		}		
		
		public bool AllowEditFechaVencimiento
		{
			get{return _brClass.AllowEditFechaVencimiento;}
		}
		
		public bool AllowEditDiasVencimiento
		{
			get{return _brClass.AllowEditDiasVencimiento;}
		}

		
		public bool AllowEditProximaFechaVencimiento
		{
			get{return _brClass.AllowEditProximaFechaVencimiento;}
		}

		
		public bool AllowEditCAI
		{
			get{return _brClass.AllowEditCAI;}
		}

		
		
		

		public bool AllowEditNetoBruto
		{
			get{return _brClass.AllowEditNetoBruto;}
		}
		

		public bool AllowEditNeto
		{
			get{return _brClass.AllowEditNeto;}
		}
		
		public bool AllowEditDescuentos
		{
			get{return _brClass.AllowEditDescuentos;}
		}
		
		public bool AllowEditPorcentajeDescuentos
		{
			get{return _brClass.AllowEditPorcentajeDescuentos;}
		}





		private string _layoutConceptos = string.Empty;
		public string LayoutConceptos
		{
			get{return _layoutConceptos;}
		}

		private string _leyendaFormulario = string.Empty;
		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}

		public bool AllowEditProveedor
		{
			get
			{
				return this._brClass.AllowEditProveedor;
			}
		}
		public bool AllowEditTipoDeComprobante
		{
			get
			{
				return this._brClass.AllowEditTipoDeComprobante;
			}
		}
		public bool AllowEditNumeration
		{
			get
			{
				return this._brClass.AllowEditNumeration;
			}
		}
		public string TextoBotonAnterior
		{
			get 
			{
				return this._brClass.TextoBotonAnterior;					
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return this._brClass.TextoBotonSiguiente;
			}
		}
		public bool AllowEditResponsableEmision
		{
			get
			{
				return this._brClass.AllowEditResponsableEmision;
			}
		}
		public bool AllowEditMonedaOrigen
		{
			get{return _brClass.AllowEditMonedaOrigen;}
		}
		public bool AllowEditFuenteDeCambio
		{
			get{return _brClass.AllowEditFuenteDeCambio;}
		}
		#endregion
		#region Propiedades

		private string _idCondicionDeCompra = string.Empty;
		public string IdCondicionDeCompra
		{
			get{return _brClass.IdCondicionDeCompra;}
			set
			{
				_idCondicionDeCompra = value;
				_brClass.IdCondicionDeCompra = value;
			}
		}

		public decimal NetoItemsOriginal
		{
			get
			{
				return _brClass.NetoItemsOriginal;
			}
		}

		public decimal NetoItems 
		{
			get
			{
				return _brClass.NetoItems;

			}
		}


		
		public string SimboloMonedaOrigen
		{
			get
			{
				return _brClass.SimboloMonedaOrigen;	
			}
			set
			{
				_brClass.SimboloMonedaOrigen = value;
			}
		}

		public string SimboloMonedaCierre
		{
			get
			{
				return _brClass.SimboloMonedaCierre;	
			}
		}
		

		
		public string TaskName
		{
			get 
			{
				return _brClass.GetTaskName();
			}					
		}

		private object _responsableDeEmision = string.Empty;
		public object ResponsableDeEmision
		{
			get {return _brClass.IdResponsable;}
			set 
			{
				if (_responsableDeEmision!= value) 
				{
					_responsableDeEmision = value;
					_brClass.IdResponsable = Convert.ToString(value);
					/*
					if(ResponsableDeEmisionChanged != null)
						ResponsableDeEmisionChanged(this, new EventArgs());	
					*/
				}				
			}
		}
		private object _keyValueTiposDeComprobantes = string.Empty;
		public object KeyValueTiposDeComprobantes
		{
			get {return _brClass.TipoComprobanteDestino;}
			set 
			{
				if (_keyValueTiposDeComprobantes!= value) 
				{
					_keyValueTiposDeComprobantes = value;
					_brClass.TipoComprobanteDestino = Convert.ToString(value);
					/*
					if(KeyValueTiposDeComprobantesChanged != null)
						KeyValueTiposDeComprobantesChanged(this, new EventArgs());	
					*/
					if(NetosCollectionChanged != null)
						NetosCollectionChanged(this, new EventArgs());
				}				
			}
		}
		private string _keyValueProveedores = string.Empty;
		public string KeyValueProveedores
		{
			get {return _brClass.CodigoProveedor;}
			set 
			{
				if (_keyValueProveedores!= value) 
				{
					_keyValueProveedores = value;
					_brClass.CodigoProveedor = Convert.ToString(value);
					/*if(KeyValueProveedoresChanged != null)
						KeyValueProveedoresChanged(this, new EventArgs());	*/
				}				
			}		
		}			

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}


		private string _numeroComprobante = "";
		public string NumeroComprobante 
		{
			get {return _brClass.Numero;	}
			set 
			{
				if(_numeroComprobante != value)
				{
					_numeroComprobante = value;
					_brClass.Numero = value;
				}
			}
		}
		//private string _mascara = string.Empty;
		public string Mascara
		{
			get
			{
				return _brClass.Mascara;
			}
		}
		public string MascaraCampoAuxiliar1
		{
			get
			{
				return _brClass.MascaraCampoAuxiliar1;
			}
		}

		public  int DiasVencimiento
		{
			get{return _brClass.DiasVencimiento;}
			set{_brClass.DiasVencimiento = value;}
		}

		public  DateTime FechaVencimiento
		{
			get{return _brClass.FechaVencimiento;}
			set{_brClass.FechaVencimiento = value;}
		}

		
	
		private string _idMonedaOrigen = string.Empty;
		public string IdMonedaOrigen
		{
			get
			{
				return _brClass.IdMonedaOrigen;
			}
			set
			{
				if(_idMonedaOrigen != value)
				{
					_idMonedaOrigen = value;
					_brClass.IdMonedaOrigen = value;

				}
			}
		}
		private string _idFuenteDeCambioProveedor = string.Empty;
		public string IdFuenteDeCambioProveedor
		{
			get
			{
				return _brClass.IdFuenteDeCambioProveedor;
			}
			set
			{
				if(_idFuenteDeCambioProveedor != value)
				{
					_idFuenteDeCambioProveedor = value;
					_brClass.IdFuenteDeCambioProveedor = value;
				}
			}
		}
		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
			}
		}
		public DataTable TiposDeComprobantesSearchObject 
		{
			get 
			{
				return _brClass.TableTiposDeComprobantesValidos;
			}
		}
		public string TiposDeComprobantesValueMember
		{
			get 
			{
				return "IdTipoDeComprobante";
			}
		}

		public string TiposDeComprobantesDisplayMember
		{
			get 
			{
				return "Descripcion";
			}
		}

		public string KeyValueTiposMovimientos
		{
			get { return "IdTipoMovimiento" ; }
		}
		public string KeyValueSubTiposMovimientos
		{
			get { return "IdSubTipoMovimiento" ; }
		}
		public string KeyListTiposMovimientos
		{
			get { return "Descripcion" ; }
		}

		public DataTable ResponsableDataTable
		{
			get
			{
				return businessrules.data.UsuariosPersonas.GetList();
			}
		}
		private string _layoutDetalle = string.Empty;
		public string LayoutDetalle 
		{
			get 
			{
				return _layoutDetalle;
			}
		}

		public string ResponsableValueMember
		{
			get
			{
				return "IdPersona";
			}
		}

		public string ResponsableDisplayMember
		{
			get
			{
				return "Nombre";
			}
		}
		public DataTable TableMonedas
		{
			get{return _brClass.TableMonedas;}	
		}
		public DataTable TableFuentesDeCambio
		{
			get{return _brClass.TableFuentesDeCambio;}
		}		
		public DataTable TableCuentasDeImputacion
		{
			get{return _brClass.TableCuentasDeImputacion;}
		}

		public DataTable TableSubcuentasDeImputacion
		{
			get{return _brClass.TableSubcuentasDeImputacion;}
		}
		private DateTime _fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaComprobante
		{
			get 
			{
				return _brClass.FechaComprobante;					
			}
			set 
			{
				if(_fechaComprobante != value)
				{
					_fechaComprobante = value;
					_brClass.FechaComprobante = value; 
				}
			}
		}
		private DateTime _fechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaRegistracion
		{
			get 
			{
				return _brClass.FechaRegistracion;					
			}
			set 
			{
				if(_fechaRegistracion != value)
				{
					_fechaRegistracion = value;
					_brClass.FechaRegistracion = value; 
				}
			}
		}	
		
		private decimal _valorCotizacionProveedor = 0;
		public decimal ValorCotizacionProveedor
		{
			get 
			{
				return _brClass.ValorCotizacionProveedor;					
			}
			set 
			{
				if(_valorCotizacionProveedor != value)
				{
					_valorCotizacionProveedor = value;
					_brClass.ValorCotizacionProveedor = value; 
				}
			}
		}
		
		public DataTable TableNetosNOGravados
		{
			get{return _brClass.TableNetosNOGravados;}
		}
		
		public ItemsConcepto ConceptosGravados
		{
			get{return this._brClass.ConceptosGravados;}
		}
		
		public ItemsConcepto ConceptosNOGravados
		{
			get{return this._brClass.ConceptosNOGravados;}
		}

		public string TipoComprobanteDestino
		{
			get{return this._brClass.TipoComprobanteDestino;}
		}
		
		private string _idImpuestoAsociadoNetoGravado = string.Empty;
		public string IdImpuestoAsociadoNetoGravado
		{
			get{return _idImpuestoAsociadoNetoGravado;}
			set
			{
				if(_idImpuestoAsociadoNetoGravado != value)
				{
					_idImpuestoAsociadoNetoGravado = value;
					if(value != null && value != string.Empty)
					{
						DataRow row = ObtenerInfoImpuestoSeleccionado(value, _tableImpuestosAsociadosNetosGravados);
						if(row != null)
						{
							_porcentajeImpuestoAsociadoNetoGravado = Convert.ToDecimal(row["Alicuota1"]);
						}
						else _porcentajeImpuestoAsociadoNetoGravado = 0;
						
					}
					else _porcentajeImpuestoAsociadoNetoGravado = 0;
					RecalcularGravado();
					if(CalculoGravadoChanged != null)
						CalculoGravadoChanged(this, new EventArgs());
				}
			}
		}

		private decimal _netoGravadoAplicado = 0;
		public double NetoGravadoAplicado
		{
			get{return Convert.ToDouble(_netoGravadoAplicado);}
			set
			{
				if(Convert.ToDouble(_netoGravadoAplicado) != value)
				{
					_netoGravadoAplicado = Convert.ToDecimal(value);
					RecalcularGravado();
					if(CalculoGravadoChanged != null)
						CalculoGravadoChanged(this, new EventArgs());


				}
			}
		}

		private decimal _netoNOGravadoAplicado = 0;
		public double NetoNOGravadoAplicado
		{
			get{return Convert.ToDouble(_netoNOGravadoAplicado);}
			set
			{
				if(Convert.ToDouble(_netoNOGravadoAplicado) != value)
				{
					_netoNOGravadoAplicado = Convert.ToDecimal(value);
					RecalcularNOGravado();
					if(CalculoNOGravadoChanged != null)
						CalculoNOGravadoChanged(this, new EventArgs());


				}
			}
		}


		private decimal _valorImpuestoAplicadoNetoNOGravado = 0;
		public decimal ValorImpuestoAplicadoNetoNOGravado
		{
			get{return _valorImpuestoAplicadoNetoNOGravado;}
			set
			{
				if(_valorImpuestoAplicadoNetoNOGravado != value)
				{
					_valorImpuestoAplicadoNetoNOGravado = value;
					RecalcularNOGravadoDesdeValorImpuesto();
					if(CalculoNOGravadoChanged != null)
						CalculoNOGravadoChanged(this, new EventArgs());
				}
			}
		}

		private decimal _valorImpuestoAplicadoNetoGravado = 0;
		public decimal ValorImpuestoAplicadoNetoGravado
		{
			get{return _valorImpuestoAplicadoNetoGravado;}
			set
			{
				if(_valorImpuestoAplicadoNetoGravado != value)
				{
					_valorImpuestoAplicadoNetoGravado = value;
					RecalcularGravadoDesdeValorImpuesto();
					if(CalculoGravadoChanged != null)
						CalculoGravadoChanged(this, new EventArgs());
				}
			}
		}

		private decimal _totalNOGravado = 0;
		public decimal TotalNOGravado
		{
			get{return _totalNOGravado;}
			set{_totalNOGravado = value;}
		}

		private decimal _totalGravado = 0;
		public decimal TotalGravado
		{
			get{return _totalGravado;}
			set{_totalGravado = value;}
		}

		private void RecalcularGravadoDesdeValorImpuesto()
		{
			_porcentajeImpuestoAsociadoNetoGravado = _netoGravadoAplicado>0?_valorImpuestoAplicadoNetoGravado*100/_netoGravadoAplicado:0;
			_totalGravado = _valorImpuestoAplicadoNetoGravado + _netoGravadoAplicado;
		}
		private void RecalcularNOGravadoDesdeValorImpuesto()
		{
			_porcentajeImpuestoAsociadoNetoNOGravado = _netoNOGravadoAplicado>0?_valorImpuestoAplicadoNetoNOGravado*100/_netoNOGravadoAplicado:0;
			_totalNOGravado = _valorImpuestoAplicadoNetoNOGravado + _netoNOGravadoAplicado;
		}
		private void RecalcularNOGravado()
		{
			_valorImpuestoAplicadoNetoNOGravado = _netoNOGravadoAplicado * _porcentajeImpuestoAsociadoNetoNOGravado /100;
			_totalNOGravado = _valorImpuestoAplicadoNetoNOGravado + _netoNOGravadoAplicado;
		}

		private void RecalcularGravado()
		{
			_valorImpuestoAplicadoNetoGravado = _netoGravadoAplicado * _porcentajeImpuestoAsociadoNetoGravado /100;
			_totalGravado = _valorImpuestoAplicadoNetoGravado + _netoGravadoAplicado;
		}


		private decimal _porcentajeImpuestoAsociadoNetoGravado = 0;
		public decimal PorcentajeImpuestoAsociadoNetoGravado
		{
			get{return _porcentajeImpuestoAsociadoNetoGravado;}
			set
			{
				if(_porcentajeImpuestoAsociadoNetoGravado != value)
				{
					_porcentajeImpuestoAsociadoNetoGravado = value;
					RecalcularGravado();
					if(CalculoGravadoChanged != null)
						CalculoGravadoChanged(this, new EventArgs());

				}
			}
		}

		private decimal _porcentajeImpuestoAsociadoNetoNOGravado = 0;
		public decimal PorcentajeImpuestoAsociadoNetoNOGravado
		{
			get{return _porcentajeImpuestoAsociadoNetoNOGravado;}
			set
			{
				if(_porcentajeImpuestoAsociadoNetoNOGravado != value)
				{
					_porcentajeImpuestoAsociadoNetoNOGravado = value;
					RecalcularNOGravado();
					if(CalculoNOGravadoChanged != null)
						CalculoNOGravadoChanged(this, new EventArgs());

				}
			}
		}
		
		private DataRow ObtenerInfoImpuestoSeleccionado(string IdImpuesto, DataTable table)
		{
			foreach(DataRow row in table.Rows)
			{
				string id = Convert.ToString(row["IdImpuesto"]);
				if(IdImpuesto.Equals(id))
				{
					return row;
				}
			}
			return null;
		}

		private string _idImpuestoAsociadoNetoNOGravado = string.Empty;
		public string IdImpuestoAsociadoNetoNOGravado
		{
			get{return _idImpuestoAsociadoNetoNOGravado;}
			set
			{
				if(_idImpuestoAsociadoNetoNOGravado != value)
				{
					
					_idImpuestoAsociadoNetoNOGravado = value;
					if(value != null && value != string.Empty)
					{
						DataRow row = ObtenerInfoImpuestoSeleccionado(value, _tableImpuestosAsociadosNetosNOGravados);
						if(row != null)
						{
							_porcentajeImpuestoAsociadoNetoNOGravado = Convert.ToDecimal(row["Alicuota1"]);
						}	
						else _porcentajeImpuestoAsociadoNetoNOGravado = 0;
					}
					
				}
				else _porcentajeImpuestoAsociadoNetoNOGravado = 0;
				RecalcularNOGravado();
				if(CalculoNOGravadoChanged != null)
					CalculoNOGravadoChanged(this, new EventArgs());
			}
		}
		
		private long _idNetoGravado = 0;
		public long IdNetoGravado
		{
			get{return _idNetoGravado;}
			set
			{
				if(_idNetoGravado != value)
				{
					_idNetoGravado = value;
					_tableImpuestosAsociadosNetosGravados = mz.erp.businessrules.tpu_NetosImpuestos.GetListEx(long.MinValue, _idNetoGravado, null, this._brClass.TipoComprobanteDestino, true).Tables[0];
					if (_tableImpuestosAsociadosNetosGravados.Rows.Count == 1)
					{
						_idImpuestoAsociadoNetoGravado = Convert.ToString(_tableImpuestosAsociadosNetosGravados.Rows[0]["IdImpuesto"]);							
						if(_idImpuestoAsociadoNetoGravado != null && _idImpuestoAsociadoNetoGravado != string.Empty)
						{
							DataRow row = ObtenerInfoImpuestoSeleccionado(_idImpuestoAsociadoNetoGravado, _tableImpuestosAsociadosNetosGravados);
							if(row != null)
							{
								_porcentajeImpuestoAsociadoNetoGravado = Convert.ToDecimal(row["Alicuota1"]);
							}
							else _porcentajeImpuestoAsociadoNetoGravado = 0;
						
						}
						else _porcentajeImpuestoAsociadoNetoGravado = 0;
						RecalcularGravado();
					}
					else
						_idImpuestoAsociadoNetoGravado = string.Empty;
					if(IdNetoGravadoChanged != null)
						IdNetoGravadoChanged(this, new EventArgs());
				}
			}
		}

		private long _idNetoNOGravado = 0;		
		public long IdNetoNOGravado
		{
			get{return _idNetoNOGravado;}
			set
			{
				if(_idNetoNOGravado != value)
				{
					_idNetoNOGravado = value;
					_tableImpuestosAsociadosNetosNOGravados = mz.erp.businessrules.tpu_NetosImpuestos.GetListEx(long.MinValue, _idNetoNOGravado, null, this._brClass.TipoComprobanteDestino, true).Tables[0];
					if (_tableImpuestosAsociadosNetosNOGravados.Rows.Count == 1)
					{
						_idImpuestoAsociadoNetoNOGravado = Convert.ToString(_tableImpuestosAsociadosNetosNOGravados.Rows[0]["IdImpuesto"]);							
						if(_idImpuestoAsociadoNetoNOGravado != null && _idImpuestoAsociadoNetoNOGravado != string.Empty)
						{
							DataRow row = ObtenerInfoImpuestoSeleccionado(_idImpuestoAsociadoNetoNOGravado, _tableImpuestosAsociadosNetosNOGravados);
							if(row != null)
							{
								_porcentajeImpuestoAsociadoNetoNOGravado = Convert.ToDecimal(row["Alicuota1"]);
							}
							else _porcentajeImpuestoAsociadoNetoNOGravado = 0;
						
						}
						else _porcentajeImpuestoAsociadoNetoNOGravado = 0;
						RecalcularNOGravado();
					}
					else
						_idImpuestoAsociadoNetoNOGravado = string.Empty;
					if(IdNetoNOGravadoChanged != null)
						IdNetoNOGravadoChanged(this, new EventArgs());
				}
			}
		}

		private DataTable _tableImpuestosAsociadosNetosGravados = (new tsy_ImpuestosDataset()).Tables[0];
		public DataTable TableImpuestosAsociadosNetosGravados
		{
			get{return _tableImpuestosAsociadosNetosGravados;}
		}

		private DataTable _tableImpuestosAsociadosNetosNOGravados = (new tsy_ImpuestosDataset()).Tables[0];
		public DataTable TableImpuestosAsociadosNetosNOGravados
		{
			get{return _tableImpuestosAsociadosNetosNOGravados;}
		}


		public DataTable TableNetosGravados
		{
			get{return _brClass.TableNetosGravados;}
		}

		public  string IdCuentaImputacion 
		{
			get{return _brClass.IdCuentaImputacion;}
			set{ _brClass.IdCuentaImputacion = value;}
		}


		public string IdSubCuentaImputacion
		{
			get{return  _brClass.IdSubCuentaImputacion;}
			set{ _brClass.IdSubCuentaImputacion = value;}
		}

		public string CAI
		{
			get{return _brClass.CAI;}
			set{_brClass.CAI = value;}
		}
		public string Leyenda
		{
			get{return _brClass.Leyenda;}
			set{_brClass.Leyenda = value;}
		}
		public string Observaciones
		{
			get{return _brClass.Observaciones;}
			set{_brClass.Observaciones = value;}
		}
		
		public DateTime ProximaFechaVencimiento
		{
			get{return _brClass.ProximaFechaVencimiento;}
			set{_brClass.ProximaFechaVencimiento = value;}
		}

		public  string MesDeImputacion
		{
			get{return _brClass.MesDeImputacion;}
			set{_brClass.MesDeImputacion = value;}
		}

		public  string MesDeDevengamiento
		{
			get{return _brClass.MesDeDevengamiento;}
			set{_brClass.MesDeDevengamiento = value;}
		}

		public  decimal NetoBruto
		{
			get{return _brClass.NetoBruto;}
			set{_brClass.NetoBruto = value;}
		}


		public  decimal Descuentos 
		{
			get{return _brClass.Descuentos;}
			set{ _brClass.Descuentos = value;}
		}

		public  decimal PorcentajeDescuentos 
		{
			get{return _brClass.PorcentajeDescuentos;}
			set{ _brClass.PorcentajeDescuentos = value;}
		}

		public decimal Neto 
		{
			get{return _brClass.Neto;}
			set{ _brClass.Neto = value;}
		}

		public decimal Total 
		{
			get{return _brClass.Total;}			
		}
		
		public decimal DescuentoGeneral 
		{
			get{return _brClass.DescuentoGeneral;}
			set{ _brClass.DescuentoGeneral = value;}
		}		

		public decimal PorcentajeDescuentoGeneral 
		{
			get{return _brClass.PorcentajeDescuentoGeneral;}	
			set{ _brClass.PorcentajeDescuentoGeneral = value;}
		}	
		
		public decimal TotalGeneral
		{
			get{return _brClass.TotalGeneral;}			
		}
		
		public decimal Impuestos
		{
			get{return _brClass.Impuestos;}
			set{ _brClass.Impuestos = value;}
		}
		
		public decimal TotalUsuario
		{
			get{return _brClass.TotalUsuario;}
			set{ _brClass.TotalUsuario = value;}
		}

		public decimal TotalUsuarioMonedaReferencia
		{
			get
			{
				return _brClass.TotalUsuarioMonedaReferencia;
			}
		}

		public ItemsComprobantesCompra Items
		{
			get	{return this._brClass.Items;}
			set	{this._brClass.Items = value;}
		}

		
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItemComprobante( (ArrayList)valores);
			}
		}
		private void ProcessItemComprobante( ArrayList lista )
		{
			_brClass.AddItems(lista);
		}



		#endregion


		private void _brClass_FechaVencimientoChanged(object sender, EventArgs e)
		{
			if(FechaVencimientoChanged != null)
				FechaVencimientoChanged(this, new EventArgs());
		}

			
	
		private void _brClass_DiasVencimientoChanged(object sender, EventArgs e)
		{
			if(DiasVencimientoChanged != null)
				DiasVencimientoChanged(this, new EventArgs());
		}
		

		private void _brClass_IdCuentaImputacionChanged(object sender, EventArgs e)
		{
			if(CuentaImputacionChanged != null)
				CuentaImputacionChanged(this, new EventArgs());
		}
		private void _brClass_IdCuentaImputacionProveedorChanged(object sender, EventArgs e)
		{
			
			if(CuentaImputacionProveedorChanged != null)
				CuentaImputacionProveedorChanged(this, new EventArgs());
			
		}

		private void _brClass_IdSubCuentaImputacionProveedorChanged(object sender, EventArgs e)
		{
			if(SubCuentaImputacionProveedorChanged != null)
				SubCuentaImputacionProveedorChanged(this, new EventArgs());
		}


		private void _brClass_NetoChanged(object sender, EventArgs e)
		{
            //German 2011104 - Tarea 914
			if(NetoChangedAux != null)
				NetoChangedAux(this, new EventArgs());
            //Fin German 2011104 - Tarea 914
		}
		private void _brClass_TotalChanged(object sender, EventArgs e)
		{
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
		}


		private void _brClass_TipoDeComprobanteDestinoChanged(object sender, EventArgs e)
		{			
			if(TipoDeComprobanteDestinoChanged != null)
				TipoDeComprobanteDestinoChanged(this, new EventArgs());
		}

		private void _brClass_IdMonedaOrigenChanged(object sender, EventArgs e)
		{
			if(SimboloMonedaOrigenChanged != null)
				SimboloMonedaOrigenChanged(this, new EventArgs());
		}

		private void _brClass_TotalUsuarioChanged(object sender, EventArgs e)
		{
			if(ImpuestosChanged != null)
				ImpuestosChanged(this, new EventArgs());
			if(TotalUsuarioMonedaReferenciaChanged != null)
				TotalUsuarioMonedaReferenciaChanged(this, new EventArgs());
		}

		private void _brClass_NetoItemsOriginalChanged(object sender, EventArgs e)
		{
			if(NetoItemsOriginalChanged != null)
				NetoItemsOriginalChanged(this, new EventArgs());
		}

		private void _brClass_CondicionDeCompraChanged(object sender, EventArgs e)
		{
			if(IdCondicionDeCompraChanged != null)
				IdCondicionDeCompraChanged(this, new EventArgs());
		}

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			CallRefresh();
		}

		private void CallRefresh()
		{
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());
     	}

		private void _brClass_NetosCollectionChanged(object sender, EventArgs e)
		{
			if(NetosCollectionChanged != null)
				NetosCollectionChanged(this, new EventArgs());
		}

		

	}
}
