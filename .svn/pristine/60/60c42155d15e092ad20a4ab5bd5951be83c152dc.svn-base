using System;
using System.Data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.commontypes;



namespace mz.erp.ui.controllers	
{
	/// <summary>
	/// Descripción breve de AjusteDeStock.
	/// </summary>
	public class EntregasController : ITaskController, IObserver	
	{
		#region Constructores
		public EntregasController( ComprobanteDeEntrega _comprobanteInstanciado )
		{
			this._brClass = _comprobanteInstanciado;
			Init();
		}
		public EntregasController( )
		{									
			this._brClass = new ComprobanteDeEntrega();
			Init();
		}	
		private void Init()
		{
			InitializeData();
			InitEvents();
		}
		#endregion

		#region Eventos y Delegados
		public event EventHandler OnTaskAfterExecute;
		public event EventHandler ComprobanteChanged;

		public event System.EventHandler IdComprobanteChanged;
		public event System.EventHandler FechaConvenidaChanged;
		public event System.EventHandler FechaVencimientoChanged;
		public event System.EventHandler ObservacionesChanged;
		public event System.EventHandler CampoAuxiliar1Changed;
		public event System.EventHandler CampoAuxiliar2Changed;
		public event System.EventHandler CampoAuxiliar3Changed;
		public event System.EventHandler CampoAuxiliar4Changed;
		public event System.EventHandler CampoAuxiliar5Changed;	
		


		private void InitEvents()
		{
			//this._brClass.ObjectHasChanged+= new EventHandler( this._brClass_OnRecalcularComprobante );			
			this._brClass.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
			this._brClass.OnRecalcularComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RecalcularComprobante(_brClass_OnRecalcularComprobante);
			this._brClass.OnRefrescarComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RefrescarComprobante(_brClass_OnRecalcularComprobante);
		}
		private void InitializeData()
		{
			string proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string tarea = this._brClass.GetTaskName();
			string leyenda = Variables.GetValueString(proceso, tarea, "LeyendaFormulario" );

			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
			_etiquetaCampoauxiliar1 = Variables.GetValueString(proceso, tarea, "CampoAuxiliar1.Etiqueta");
			_etiquetaCampoauxiliar2 = Variables.GetValueString(proceso, tarea, "CampoAuxiliar2.Etiqueta");
			_etiquetaCampoauxiliar3 = Variables.GetValueString(proceso, tarea, "CampoAuxiliar3.Etiqueta");
			_etiquetaCampoauxiliar4 = Variables.GetValueString(proceso, tarea, "CampoAuxiliar4.Etiqueta");
			_etiquetaCampoauxiliar5 = Variables.GetValueString(proceso, tarea, "CampoAuxiliar5.Etiqueta");
			

		}
		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void Listener(object Sender, System.EventArgs e)
		{
			if (IdComprobanteChanged != null) {IdComprobanteChanged( this, new System.EventArgs() );}
			if (FechaConvenidaChanged != null) {FechaConvenidaChanged( this, new System.EventArgs() );}
			if (FechaVencimientoChanged != null) {FechaVencimientoChanged( this, new System.EventArgs() );}
			if (ObservacionesChanged != null) {ObservacionesChanged( this, new System.EventArgs() );}
			if (CampoAuxiliar1Changed != null) {CampoAuxiliar1Changed( this, new System.EventArgs() );}
			if (CampoAuxiliar2Changed != null) {CampoAuxiliar2Changed( this, new System.EventArgs() );}
			if (CampoAuxiliar3Changed != null) {CampoAuxiliar3Changed( this, new System.EventArgs() );}
			if (CampoAuxiliar4Changed != null) {CampoAuxiliar4Changed( this, new System.EventArgs() );}
			if (CampoAuxiliar5Changed != null) {CampoAuxiliar5Changed( this, new System.EventArgs() );}
			if (ComprobanteChanged != null) {ComprobanteChanged( this, new System.EventArgs() );}
		}

		private void _brClass_OnRecalcularComprobante(object sender, EventArgs e)
		{
			if(ComprobanteChanged != null)
				ComprobanteChanged(sender, e);
		}





		#endregion

		#region Variables Privadas
		private ComprobanteDeEntrega _brClass; 
		private DateTime _fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;


		private string _etiquetaCampoauxiliar1 = "";
		private string _etiquetaCampoauxiliar2 = "";
		private string _etiquetaCampoauxiliar3 = "";
		private string _etiquetaCampoauxiliar4 = "";
		private string _etiquetaCampoauxiliar5 = "";
		private string _leyendaFormulario = "Comprobante";

		private DataRow _row;

		private DataTable _tiposDeComprobantes = businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,Variables.GetValueString("Momentos.Vender.Comprobantes")).tsy_TiposDeComprobantes;
		private string _tiposDeComprobantesValueMember = "IdTipoDeComprobante";
		private string _tiposDeComprobantesDisplayMember = "Descripcion";
		private string _tiposDeComprobantesValueMemberCaption = "Id";
		private string _tiposDeComprobantesDisplayMemberCaption = "Tipos de Comprobantes";
		private string _tiposDeComprobantesSortedMember = "Descripcion";
		
		private System.Collections.Hashtable _listatiposDeComprobantes = businessrules.tsy_TiposDeComprobantes.GetListHashTable();		
	
		private DataTable _responsable = businessrules.data.UsuariosPersonas.GetList();
		private string _responsableValueMember = "IdPersona";
		private string _responsableDisplayMember = "Nombre";
		private string _responsableValueMemberCaption = "ID";
		private string _responsableDisplayMemberCaption = "Nombre";
		private string _responsableSortedMember = "Nombre";
		private string _productosLayoutData = Variables.GetValueBool("Comprobantes.Objetos.DefinicionActiva")? mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleProductos( new string[] { "Codigo","DescripcionLarga", "Cantidad","UnidadDestino","CantidadUnidadOrigen","UnidadOrigen","PrecioDeVentaBruto","BonificacionPorcentual","SubTotalConImpuestos","PrecioConImpuestos"} ):mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutDetalleProductos( new string[] { "Codigo", "DescripcionLarga", "Cantidad","UnidadDestino","CantidadUnidadOrigen","UnidadOrigen","PrecioDeVentaBruto","PrecioConImpuestos"} );
		private string _productosDomiciliosAsociadosLayoutData = new mz.erp.ui.controllers.tcs_Domicilios( new string[]{ "Checked","DomicilioTexto","IdDomicilio","TipoDomicilio"} ).GetLayout();

		#endregion

		#region Variables Publicas Interfaz


		public bool AllowAddItems
		{
			get
			{
				return _brClass.AllowAddItems;
			}
		}
	
		public bool AllowDeleteItems
		{
			get
			{
				return _brClass.AllowDeleteItems;
			}
		}

		public bool AllowEditItems
		{
			get
			{
				return this._brClass.AllowEditItems;
			}
		}
		public bool AllowEditTipoDeComprobante
		{
			get
			{
				return this._brClass.AllowEditTipoDeComprobante;
			}
		}
		public bool AllowEditResponsableEmision
		{
			get
			{
				return this._brClass.AllowEditResponsableEmision;
			}
		}
		public bool AllowEditCuenta
		{
			get
			{
				return this._brClass.AllowEditCuenta;
			}
		}

		public bool AllowEditNumeration
		{
			get
			{
				return this._brClass.AllowEditNumeration;
			}
		}

		public string ProductosLayoutData
		{
			get
			{
				return _productosLayoutData;
			}
		}
		public string DomiciliosAsociadosLayoutData
		{
			get 
			{
				return this._productosDomiciliosAsociadosLayoutData;
			}
		}

		public DataTable TiposDeComprobantes
		{
			get
			{
				return _tiposDeComprobantes;
			}
		}
		
		public string TiposDeComprobantesValueMemberCaption
		{
			get
			{
				return _tiposDeComprobantesValueMemberCaption;
			}
		}
		public string TiposDeComprobantesDisplayMemberCaption
		{
			get
			{
				return _tiposDeComprobantesDisplayMemberCaption;
			}
		}

		public string TiposDeComprobantesSortedMember
		{
			get
			{
				return _tiposDeComprobantesSortedMember;
			}
		}

		public string TiposDeComprobantesValueMember
		{
			get
			{
				return _tiposDeComprobantesValueMember;
			}
		}
		public string TiposDeComprobantesDisplayValue
		{
			get
			{
				return _tiposDeComprobantesDisplayMember;
			}
		}

		/*Responsabes*/
		public string ResponsableValueMemberCaption
		{
			get
			{
				return _responsableValueMemberCaption;
			}
		}
		public string ResponsableDisplayMemberCaption
		{
			get
			{
				return _responsableDisplayMemberCaption;
			}
		}
		public string ResponsableSortedMember
		{
			get
			{
				return _responsableSortedMember;
			}
		}

		public DataTable Responsable
		{
			get
			{
				return _responsable;
			}
		}
		public string ResponsableValueMember
		{
			get
			{
				return _responsableValueMember;
			}
		}
		public string ResponsableDisplayValue
		{
			get
			{
				return _responsableDisplayMember;
			}
		}

		public string EtiquetaCampoAuxiliar1
		{
			get { return _etiquetaCampoauxiliar1; }			
		}
		public string EtiquetaCampoAuxiliar2
		{
			get { return _etiquetaCampoauxiliar2; }
		}
		public string EtiquetaCampoAuxiliar3
		{
			get { return _etiquetaCampoauxiliar3; }			
		}
		public string EtiquetaCampoAuxiliar4
		{
			get { return _etiquetaCampoauxiliar4; }
		}
		public string EtiquetaCampoAuxiliar5
		{
			get { return _etiquetaCampoauxiliar5; }
		}


		public string NombreDeComprobante
		{
			get 
			{ 				
				if (this._brClass.TipoComprobanteDestino != null) 
				{					
					return _listatiposDeComprobantes[ this._brClass.TipoComprobanteDestino].ToString() ;

				}
				else
				{
					return "No Definido";
				}
			}
		}
		public string NombreTarea
		{
			get
			{
				return this._brClass.GetTaskName();
			}
		}
		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario ; }
		}		
		public string Caption 
		{
			get	{return "Emisión de " + this.NombreDeComprobante;}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}

		public bool AllowOtrosDomicilios 
		{
			get 
			{
				return _brClass.AllowOtrosDomicilios;
			}
		}
		
		public string Mascara
		{
			get 
			{
				return _brClass.Mascara;
			}
		}

        /* Silvina 20100531 - Tarea 646 */
        public bool SeleccionaUltimo
        {
            get { return _brClass.SeleccionaUltimo; }
        }
        /* Fin Silvina */


		#endregion

		#region Variables Publicas Datos
		public string Numero
		{
			get
			{
				return this._brClass.Numero;
			}
			set
			{
				this._brClass.Numero = value;
			}
		}

		public string TipoComprobanteDestino
		{
			get
			{
				return _brClass.TipoComprobanteDestino;
			}
			set
			{
				
				_brClass.TipoComprobanteDestino = value;

				
			}
		}
		public ItemsComprobantes Items
		{
			get
			{
				return _brClass.Items;
			}
			set
			{
				_brClass.Items = value;
			}
		}

		public string CodigoCuenta
		{
			get
			{
				return this._brClass.CodigoCuenta;
			}
			set
			{
				this._brClass.CodigoCuenta = value;
			}
		}

		public string IdCuenta
		{
			get
			{
				return _brClass.IdCuenta;
			}
			set
			{	
				_brClass.IdCuenta = value;
			}
		}
		public ArrayList DomiciliosAsociados
		{
			get { return _brClass.DomiciliosAsociados ; }
		}
		public string IdResponsable 
		{
			get
			{	
				return _brClass.IdResponsable;
			}
			set
			{
				_brClass.IdResponsable = value;
			}
		}
		public DateTime FechaConvenida
		{
			get { return _brClass.FechaConvenida; }
			set { _brClass.FechaConvenida = value ; }
		}
		public DateTime FechaVencimiento
		{
			get { return _brClass.FechaVencimiento; }
			set { _brClass.FechaVencimiento = value ; }
		}
		public string CampoAuxiliar1
		{
			get { return _brClass.CampoAuxiliar1; }
			set { _brClass.CampoAuxiliar1 = value ; }
		}
		public string CampoAuxiliar2
		{
			get { return _brClass.CampoAuxiliar2; }
			set { _brClass.CampoAuxiliar2 = value ; }
		}
		public string CampoAuxiliar3
		{
			get { return _brClass.CampoAuxiliar3; }
			set { _brClass.CampoAuxiliar3 = value ; }
		}
		public string CampoAuxiliar4
		{
			get { return _brClass.CampoAuxiliar4; }
			set { _brClass.CampoAuxiliar4 = value ; }
		}
		public string CampoAuxiliar5
		{
			get { return _brClass.CampoAuxiliar5; }
			set { _brClass.CampoAuxiliar5 = value ; }
		}
		public string Observaciones
		{
			get { return _brClass.Observaciones; }
			set 
			{ 
				_brClass.Observaciones = value ; 
			}
		}

		public DataRow Row 
		{
			get {return _row;}
		}		
		
	

		#endregion

		#region Metodos Publicos


		//German 20100118 SP6 647
		public void FiltrarYSeleccionarDomicilioEntregas()
		{
			FiltrarYSeleccionarDomicilio(_brClass.IdTipoDomicilioEntregas);
		}

		public void FiltrarYSeleccionarDomicilio()
		{
			FiltrarYSeleccionarDomicilio(null);
		}

		public void FiltrarYSeleccionarDomicilio(string IdTipoDomicilio)
		{
			ArrayList domAux = new ArrayList();
			bool haySeleccionado = false;
			foreach(mz.erp.businessrules.Domicilio dom in this._brClass.DomiciliosAsociados)
			{
				if(IdTipoDomicilio == null || dom.IdTipoDomicilio.Trim().Equals(IdTipoDomicilio))
				{
					domAux.Add(dom);
				}
			}
			if(domAux.Count ==1)
			{
				mz.erp.businessrules.Domicilio dom = (mz.erp.businessrules.Domicilio)domAux[0];
				dom.Checked = true;
				foreach(mz.erp.businessrules.Domicilio dom1 in this._brClass.DomiciliosAsociados)
				{
					if(dom != dom1)
						dom1.Checked = false;
				}
			}
			

		}
		//Fin German 20100118 SP6 647

		public Type GetTypeOfColumn(object sender, string column)
		{
			return sender.GetType().GetProperty(column).PropertyType;
		}


		public bool AllowEditInOtherWindow(string column)
		{
			return column.Equals("Descripcion") || column.Equals("DescripcionLarga") 
				|| column.Equals("DescripcionCorta") || column.Equals("DescripcionDetallada");
			//|| column.Equals("PrecioDeVentaBruto") || column.Equals("PrecioConImpuestos");
		}

		public string GetDescription(string column)
		{
			switch (column)
			{
				case "PrecioDeVentaBruto": return "Precio de Lista Sin Impuestos";
				case "PrecioConImpuestos": return "Precio Final Com Impuestos";
				default : return "Descripción";
			}
			return string.Empty;
		}



		public bool IsEditable( object selectedItem, string Propiedad)
		{
			
			ItemComprobante item = (ItemComprobante) selectedItem;
			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._brClass.GetTaskName();

			string colaVariable = string.Empty;
			bool habilitaComodines = Variables.GetValueBool(nombreProceso, nombreTarea, "Emision.Editar.Items.HabilitaItemComodin");
			string comodines = Variables.GetValueString(nombreProceso, nombreTarea, "Emision.Editar.Items.ListaItemComodin");
			ArrayList aux = systemframework.Util.Parse(comodines,",");
			

			if(Propiedad.Equals("CantidadUnidadOrigen"))
				if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
					if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen != string.Empty && !item.IdTipoComprobanteOrigen.Equals("OR"))
					{
						if(habilitaComodines && aux.Contains(item.Codigo))
							colaVariable = "Emision.Editar.Step.ItemComodin." + Propiedad;
						else
							colaVariable = "Emision.Editar.Step." + Propiedad;
						bool result1 = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
						return item.AllowEdit && result1;
					}

			if(habilitaComodines && aux.Contains(item.Codigo))
				colaVariable = "Emision.Editar.ItemComodin." + Propiedad;
			else
				colaVariable = "Emision.Editar." + Propiedad;
			bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
			return item.AllowEdit && result; //&& (!habiltaComodines || (habiltaComodines && aux.Contains(item.Codigo)));
			
			
		}

		public bool IsRemovable( object selectedItem)
		{
			ItemComprobante item = (ItemComprobante) selectedItem;

			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._brClass.GetTaskName();
			string colaVariable = string.Empty;

			if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
				if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen != string.Empty && !item.IdTipoComprobanteOrigen.Equals("OR"))
				{
					bool habilitaComodines = Variables.GetValueBool(nombreProceso, nombreTarea, "Emision.Editar.Items.HabilitaItemComodin");
					string comodines = Variables.GetValueString(nombreProceso, nombreTarea, "Emision.Editar.Items.ListaItemComodin");
					ArrayList aux = systemframework.Util.Parse(comodines,",");
			
			
					if(habilitaComodines && aux.Contains(item.Codigo))
						colaVariable = "Emision.Step.Delete.ItemComodin";
					else
						colaVariable = "Emision.Step.Delete.Items";
					return Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
					
				}

			return item.AllowEdit;
		}




		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
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

		public void Guardar() 
		{						
			_row = businessrules.tlg_Comprobantes.NewRow();
			tlg_Comprobantes.UpdateWithValidation(_row);
		}

		
		public void AddItem(object sender)
		{
			Item item = (Item) sender;
			ItemComprobante itemComprobante = new ItemComprobante( "NEW", this.Items, item );
			this.Items.Add( itemComprobante );
			
		}

		public void AddItems(object sender)
		{
			this._brClass.OnRecalcularComprobante -=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RecalcularComprobante(_brClass_OnRecalcularComprobante);
			this._brClass.OnRefrescarComprobante -=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RefrescarComprobante(_brClass_OnRecalcularComprobante);
			ArrayList items = (ArrayList)sender;
			this.Items.ClearCache();
			foreach(Item item in items)
			{
				ItemComprobante itemComprobante = new ItemComprobante( "NEW",this.Items, item );
				this.Items.AddInCache( itemComprobante );
			}
			this.Items.FlushCache();
			this._brClass.OnRecalcularComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RecalcularComprobante(_brClass_OnRecalcularComprobante);
			this._brClass.OnRefrescarComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RefrescarComprobante(_brClass_OnRecalcularComprobante);
			_brClass_OnRecalcularComprobante(this, new EventArgs());
		}

		
		public string FillNumberWithZeros(string txt)
		{
			return this._brClass.FillNumberWithZeros(txt);
		}


		#endregion
		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
					AddItems(valores);
			}
			if ((valores.GetType()) == typeof(System.String))
			{
				if (_brClass.InfoCliente != Convert.ToString(valores)) 
				{
					_brClass.InfoCliente =  Convert.ToString(valores);				
				}				
			}
			
		}
		#endregion









		
		




	
		#region Miembros de ITaskController

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public void RefreshData()
		{
			Listener( this, new System.EventArgs());
		}

		public void Execute()
		{
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return this._brClass.AllowShow();
		}

		
		#endregion
	}
}
