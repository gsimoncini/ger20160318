using System;

using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.transactionmanager;
using mz.erp.businessrules.comprobantes;
using mz.erp.systemframework;
using System.Collections;
using System.Data;
using mz.erp.businessrules;



namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Clase comprobantes de Entregas. Patron decorador de ComprobantesDeVenta
	/// Implementa interfases ITask, IPersistentTask
	/// Permite la lectura de datos desde las clases
	/// ComprobantesPendientes: Toma el Id del comprobante y carga la información en la clase
	/// SeleccionItemsPendientes: Toma los items del detalle expuesto en la clase y carga la información en la clase
	/// ComprobanteDeVenta: Obtiene la información referente al cliente e información extra para determinar su comportamiento, lo almacena hasta que otra clase indique como debe generarse el comprobante
	/// GenerarComprobantesEntregas: Clase que genera un array de comprobantes de entrega y que contiene en la cabecera información del cliente y fecha del comprobante
	/// SeleccionEstadoDeItem: Permite generar el comprobante de entrega desde una clase que determine el estado (forma de entrega) para el conjunto de items.
	/// </summary>	
	public class ComprobanteDeEntrega : Comprobante, ITask, IPersistentTask	
	{
		#region Variables Privadas
		//private String _idComprobante;
		private DateTime _fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		private String _observaciones = "";
		private String _campoAuxiliar1 = "";
		private String _campoAuxiliar2 = "";
		private String _campoAuxiliar3 = "";
		private String _campoAuxiliar4 = "";
		private String _campoAuxiliar5 = "";		
		private bool _allowOtrosDomicilios = false;
		private bool _guardaPrecioItems = false;
		private bool _grabaNumeroComprobanteVentaAsociado = false;
		private string _tareaOrigenPrecioItems = string.Empty;
		private string _warning = string.Empty;
		private Hashtable _mapOrdinales = new Hashtable();
		
		private tlg_ComprobantesDataset.tlg_ComprobantesRow _row;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private DataSet _data;
		private TaskCollectionData _arrData = new TaskCollectionData();
		private ComprobanteDeVenta _comprobanteDeVenta = new ComprobanteDeVenta();

		private bool _seDebeEjecutar = true;
		
		//German 20100118 SP6 647
		private string _idTipoDomicilioEntregas = string.Empty;
		//Fin German 20100118 SP6 647

        /* Silvina 20120413 - Tarea 0000275 */
        private bool _muestraFormulario = true;
        /* Fin Silvina 20120413 - Tarea 0000275 */

		#endregion

		#region Eventos y Delegados
		
		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event ComprobanteDeVenta.RecalcularComprobante OnRecalcularComprobante;
		public event ComprobanteDeVenta.RefrescarComprobante OnRefrescarComprobante;

		#endregion

		#region Variables Públicas
		public  override string IdResponsable
		{
			get
			{
				return this._comprobanteDeVenta.IdResponsable;
			}
			set
			{
				this._comprobanteDeVenta.IdResponsable = value;				
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
		}

		public string Responsable
		{
			get
			{
				return this._comprobanteDeVenta.Responsable;
			}
			set
			{
				this._comprobanteDeVenta.Responsable = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
		}

		public string Numero
		{
			get{return _comprobanteDeVenta.Numero;}
			set{_comprobanteDeVenta.Numero = value;}
		}
		
		public string Mascara
		{
			get 
			{
				//return _mascara;
				return _comprobanteDeVenta.Mascara;
			}
		}

        /* Silvina 20100531 - Tarea 646 */
        public bool SeleccionaUltimo
        {
            get {
                bool seleccionaUltimo = Variables.GetValueBool("ComprobantesDeEntregas.Emision.Editar.SeleccionaUltimoProducto");
                if (!seleccionaUltimo)
                    seleccionaUltimo = Variables.GetValueBool(_processParent.Process.ProcessName, this._taskName, "Emision.Editar.SeleccionaUltimoProducto", false);
                return seleccionaUltimo;
            }
        }
        /* Fin Silvina */
		/// <summary>
		/// Define si debe permitir actualizar la numeración
		/// </summary>
		/*public bool ActualizaNumeracion 
		{
			set { _actualizaNumeracion = value;}

			get { return _actualizaNumeracion; }
		}*/
		//private bool _actualizaNumeracion = true;

		public string IdComprobante
		{
			set 
			{
				_comprobanteDeVenta.IdComprobante = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get 
			{
				return _comprobanteDeVenta.IdComprobante;
			}
		}


		/*public ArrayList ComprobantesAsociados
		{
			get 
			{
				return this._comprobanteDeVenta.ComprobantesAsociados;
			}
			set 
			{
				this._comprobanteDeVenta.ComprobantesAsociados;
			}
		}*/

		public string IdDeposito
		{
			get
			{
				return _comprobanteDeVenta.IdDeposito;
			}
		}

		public string IdSeccion
		{
			get
			{
				return _comprobanteDeVenta.IdSeccion;
			}
		}

		public ArrayList VariablesDeUsuario
		{
			get  
			{
				return _comprobanteDeVenta.VariablesDeUsuario;
			}
		}

		public string IdCuenta
		{
			get
			{
				return this._comprobanteDeVenta.Cuenta.IdCuenta;				
			}
			set
			{
				this._comprobanteDeVenta.Cuenta.IdCuenta = value;
                /* Silvina 20120413 - Tarea 0000275 */
                SeleccionarDomicilio();
                /* Fin Silvina 20120413 - Tarea 0000275 */
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
		}

		public Cuenta Cuenta 
		{
			get 
			{
				return this._comprobanteDeVenta.Cuenta;
			}
			set 
			{
				this._comprobanteDeVenta.Cuenta = value;
			}
		}

		public CondicionDeVenta CondicionDeVenta
		{
			get 
			{
				return this._comprobanteDeVenta.CondicionDeVenta;
			}
			set 
			{
				this._comprobanteDeVenta.CondicionDeVenta = value;
			}
		}



		//private string _codigoCuenta = string.Empty;
		public string CodigoCuenta
		{
			get
			{
				return this._comprobanteDeVenta.Cuenta.Codigo;
			}
			set
			{
				Hashtable auxDomicilios = new Hashtable();
				bool ok = false;
				if(_comprobanteDeVenta.Cuenta.Codigo == value)
				{
					ok = true;
					foreach(Domicilio dom in this.DomiciliosAsociados)
					{
						auxDomicilios.Add(dom.IdDomicilio, dom.Checked);
					}
				}
				if(ok)
				{
					foreach(Domicilio dom in this.DomiciliosAsociados)
					{
						if(auxDomicilios.ContainsKey(dom.IdDomicilio))
							dom.Checked = Convert.ToBoolean(auxDomicilios[dom.IdDomicilio]);
					}
				}
				this._comprobanteDeVenta.Cuenta.Codigo = value;
                /* Silvina 20120413 - Tarea 0000275 */
                SeleccionarDomicilio();
                /* Fin Silvina 20120413 - Tarea 0000275 */
				
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
		}
		public string InfoCliente
		{
			get
			{
				return this._comprobanteDeVenta.InfoCliente;
			}
			set
			{
				this._comprobanteDeVenta.InfoCliente = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
		}

		public ArrayList DomiciliosAsociados
		{
			get 
			{ 
				return this._comprobanteDeVenta.Cuenta.DomiciliosAsociado; 
			}
			//German 20100118 SP6 647
			//set { _comprobanteDeVenta.Cuenta.DomiciliosAsociado = value ; }
			//Fin German 20100118 SP6 647
		}
		public DateTime FechaConvenida 
		{
			set 
			{
				_fechaConvenida = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _fechaConvenida;}
		}
	
		public DateTime FechaVencimiento 
		{
			set 
			{
				_fechaVencimiento = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _fechaVencimiento;}
		}		
	
		
		public string Observaciones 
		{
			set 
			{
				_observaciones = value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _observaciones;}
		}
		public string CampoAuxiliar1 
		{
			set 
			{
				_campoAuxiliar1= value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _campoAuxiliar1;}
		}
		public string CampoAuxiliar2 
		{
			set 
			{
				_campoAuxiliar2= value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _campoAuxiliar2;}
		}
		public string CampoAuxiliar3 
		{
			set 
			{
				_campoAuxiliar3= value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _campoAuxiliar3;}
		}
		public string CampoAuxiliar4 
		{
			set 
			{
				_campoAuxiliar4= value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _campoAuxiliar4;}
		}
		public string CampoAuxiliar5 
		{
			set 
			{
				_campoAuxiliar5= value;
				//if (ObjectHasChanged != null) ObjectHasChanged(this, new System.EventArgs());
			}
			get {return _campoAuxiliar5;}
		}
		
		public bool AllowOtrosDomicilios 
		{			
			get 
			{
				return _allowOtrosDomicilios;
			}
		}
		

		public DataSet Data 
		{
			get 
			{
				return _data;
			}
		}
		
		public ItemsDatasetErrors Errores
		{
			get 
			{
				return _errores;
			}
		}
		
		public ItemsComprobantes Items
		{
			get
			{
				return  this._comprobanteDeVenta.Items;
				
			}
			set
			{
				this._comprobanteDeVenta.Items = value;
			}
		}
		
		private string _listaTiposDeComprobantesSugiereNumeracion = String.Empty;
		private string _mascara	= @"\X-####-########";
		private string _numero = string.Empty;

		public string TipoComprobanteDestino
		{
			get
			{
				return this._comprobanteDeVenta.TipoComprobanteDestino;
			}
			set
			{		
				this._comprobanteDeVenta.TipoComprobanteDestino = value;								
			}
		}
		public string TipoComprobanteOrigen
		{
			get
			{
				return this._comprobanteDeVenta.TipoComprobanteOrigen;
			}
			set
			{
				this._comprobanteDeVenta.TipoComprobanteOrigen = value;
			}

		}
		public string IdTipoComprobanteDestino
		{
			get
			{
				return this._comprobanteDeVenta.IdComprobanteDestino;
			}
	
		}

		public string IdTipoComprobanteOrigen
		{
			get
			{
				return this._comprobanteDeVenta.IdComprobanteOrigen;
			}
	
		}

		public bool AllowAddItems
		{
			get
			{
				return _comprobanteDeVenta.AllowAddItems;
			}
		}

		public bool AllowDeleteItems
		{
			get
			{
				return _comprobanteDeVenta.AllowDeleteItems;
			}
		}

		public bool AllowEditCuenta
		{
			get
			{
				return this._comprobanteDeVenta.AllowEditCuenta;
			}
		}

		public bool AllowEditResponsableEmision
		{
			get
			{
                return this._comprobanteDeVenta.AllowEditResponsableEmision;
			}
		}
		public bool AllowEditTipoDeComprobante
		{
			get
			{
				return this._comprobanteDeVenta.AllowEditResponsableEmision;

			}

		}
		public bool AllowEditItems
		{
			get
			{
				return this._comprobanteDeVenta.AllowEditItems;

			}
		}

		public bool AllowEditNumeration
		{
			get
			{
				return this._comprobanteDeVenta.AllowEditNumeration;
			}
		}

		public RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{
			set
			{
				this._comprobanteDeVenta.RelacionesComprobantesOrigenDestino = value;
			}
			get
			{
				return this._comprobanteDeVenta.RelacionesComprobantesOrigenDestino;
			}
		}
		public System.DateTime FechaComprobante
		{
			get { return _comprobanteDeVenta.FechaComprobante ; }
			set { _comprobanteDeVenta.FechaComprobante = value ; }
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;
				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}			
				
			}
		}
		//German 20100118 SP6 647
		public string IdTipoDomicilioEntregas
		{
			get{return _idTipoDomicilioEntregas;}
		}
		//Fin German 20100118 SP6 647
		#endregion

		#region Constructores y Destructores
		public ComprobanteDeEntrega()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			this._comprobanteDeVenta.ObjectHasChanged+= new System.EventHandler( this.ComprobanteDeEntrega_OnRecalcularComprobante );		
		}
		#endregion

		#region Funciones y Metodos Privados
			
		private void Step()
		{
			this.IdComprobanteOrigen = this.RelacionesComprobantesOrigenDestino.Get(0).IdComprobante;
			tlg_ComprobantesDataset.tlg_ComprobantesRow row = mz.erp.businessrules.tlg_Comprobantes.GetByPk(this.IdComprobanteOrigen);
			//German 20120213 -  Tarea 0000247
            if (row != null)
            {
                this._campoAuxiliar1 = row.CampoAuxiliar1;
                this._campoAuxiliar2 = row.CampoAuxiliar2;
                this._campoAuxiliar3 = row.CampoAuxiliar3;
                this._campoAuxiliar4 = row.CampoAuxiliar4;
                this._campoAuxiliar5 = row.CampoAuxiliar5;
                this._fechaConvenida = row.FechaConvenida;
                this._fechaVencimiento = row.FechaVencimiento;
                this._observaciones = row.Observaciones;
                this._comprobanteDeVenta.Step(this.RelacionesComprobantesOrigenDestino);
            }
            else
            {
                this._comprobanteDeVenta.Step(this.RelacionesComprobantesOrigenDestino);
                this._campoAuxiliar1 = string.Empty;
                this._campoAuxiliar2 = string.Empty;
                this._campoAuxiliar3 = string.Empty;
                this._campoAuxiliar4 = string.Empty;
                this._campoAuxiliar5 = string.Empty;
                this._fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
                this._fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
                this._observaciones = this._comprobanteDeVenta.Observaciones;
            }

            //German 20120213 -  Tarea 0000247

			string comprobanteOrigen = this.RelacionesComprobantesOrigenDestino.Get(0).IdTipoDeComprobante;
			string relacioncomprobantesPrevios = Variables.GetValueString( this._processParent.Process.ProcessName, this.GetTaskName(),"RelacionComprobantesPrevios");
			string[] arrayComprobantesPrevios = relacioncomprobantesPrevios.Split( ',' );
			SortedList sl = new SortedList();
			for (int i=0;i<arrayComprobantesPrevios.Length;i++)
			{
				string tupla = arrayComprobantesPrevios[i];
				string[] arrayTupla = tupla.Split(':');
				if (arrayTupla.Length == 2)
				{
					sl.Add( arrayTupla[0],arrayTupla[1]);
				}
			}
			if (sl.ContainsKey( comprobanteOrigen ))
			{
				string tipoComprobanteDestino = (string)sl[ comprobanteOrigen ];
				this.TipoComprobanteDestino = tipoComprobanteDestino;
			}	 
			
		}
		
		private void ComprobanteDeEntrega_OnRecalcularComprobante(object sender, EventArgs e)
		{
			if(OnRecalcularComprobante != null)
				OnRecalcularComprobante(sender, e);
			if(OnRefrescarComprobante != null)
				OnRefrescarComprobante(sender, e);
			
		}

		private void LoadDataFromClassComprobanteDeVenta( ComprobanteDeVenta comprobante )
		{
			this.IdResponsable = comprobante.IdResponsable;
			this.CodigoCuenta = comprobante.CodigoCuenta;
			this.FechaConvenida = comprobante.FechaComprobante;
			this.FechaVencimiento = comprobante.FechaComprobante;


		}

	
		private void LoadDataFromClassGenerarComprobantesEntregas( GenerarComprobantesEntregas _colecciondatos )
		{
			
			_guardaPrecioItems = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "GrabaPrecioItems");
			_grabaNumeroComprobanteVentaAsociado = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "GrabaNumeroComprobanteVentaAsociado");
			_tareaOrigenPrecioItems = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "TareaOrigenPrecioItems");
			_mapOrdinales.Clear();
			ColeccionDatosComprobantesEntrega _coleccion = _colecciondatos.GetConjuntoColeccionEntregasByTaskName( this.GetTaskName()) ;
			if (_coleccion != null)
			{
				this.IdResponsable = _coleccion.IdResponsable;
				this.CodigoCuenta = _coleccion.CodigoCuenta;
				this.FechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
				this.FechaConvenida = _coleccion.FechaEntrega;
				this.FechaVencimiento = _coleccion.FechaEntrega;	
				this.InfoCliente = _coleccion.InfoCliente;
				this.Observaciones = _colecciondatos.Observaciones;
				mz.erp.businessrules.comprobantes.RelacionesComprobanteOrigenDestino relaciones = new RelacionesComprobanteOrigenDestino( this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask);
				foreach (EstadoItem _unestadoItem in _coleccion )
				{
					string IdComprobante = _unestadoItem.IdComprobanteOrigen;
					string IdTipoDeComprobante = _unestadoItem.IdTipoDeComprobanteOrigen;
					string Numero = string.Empty;
					long Ordinal = _unestadoItem.Ordinal;
					decimal CantidadOrigen = _unestadoItem.Cantidad;
					decimal CantidadDestino = _unestadoItem.Cantidad;
					string IdProducto = _unestadoItem.IdProducto;
					string Descripcion = _unestadoItem.Descripcion;
					decimal Precio = 0;
					string IdCondicionDeVenta = string.Empty;
					decimal PrecioNetoActual = 0;
                    //German 20120302 -  Tarea 0000247
					RelacionComprobanteOrigenDestino rcod = new RelacionComprobanteOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero, Ordinal, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, 
                                            Precio, this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask, _unestadoItem.Item.IdListaDePrecios, 
                            _unestadoItem.Item.CoeficienteListaDePrecios, _unestadoItem.Item.ModoDeAplicacionListaDePrecios, mz.erp.businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio);
                    //Fin German 20120302 -  Tarea 0000247
					rcod.Visible = _unestadoItem.Visible;
					relaciones.Add( rcod );
				}
                this.RelacionesComprobantesOrigenDestino = relaciones;
				foreach (EstadoItem _unestadoItem in _coleccion )
				{
					if(_unestadoItem.TieneDescripcionDetallada)
					{
						foreach(ItemComprobante item in this.Items)
						{
							if(item.OrdinalOrigen.Equals(_unestadoItem.Ordinal))
							{
								item.Descripcion = _unestadoItem.Descripcion;
								item.DescripcionCorta = _unestadoItem.Descripcion;
								item.DescripcionLarga = _unestadoItem.DescripcionLarga;
								item.DescripcionDetallada = _unestadoItem.DescripcionLarga;
								item.TieneDescripcionPersonalizada = true;
							}
						}
						foreach(ItemComprobante item in this.Items.ItemsNoVisibles)
						{
							if(item.OrdinalOrigen.Equals(_unestadoItem.Ordinal))
							{
								item.Descripcion = _unestadoItem.Descripcion;
								item.DescripcionCorta = _unestadoItem.Descripcion;
								item.DescripcionLarga = _unestadoItem.DescripcionLarga;
								item.DescripcionDetallada = _unestadoItem.DescripcionLarga;
								item.TieneDescripcionPersonalizada = true;
							}
						}
					}
				}

				foreach(ItemComprobante item in this.Items)
				{
					_mapOrdinales.Add(item.Ordinal, item.OrdinalOrigen);
				}
				foreach(ItemComprobante item in this.Items.ItemsNoVisibles)
				{
					_mapOrdinales.Add(item.Ordinal, item.OrdinalOrigen);
				}
				long idTask = Workflow.GetIdTakByName( this.GetTaskName());
				SortedList sl = Workflow.GetComprobantesAsociadosList( idTask );
				if (sl.Count == 1)
				{
					this.TipoComprobanteDestino = (string)sl.GetKey(0);
				}
				else
				{
					if(_tipoDeComprobanteSugeridoSegunCuenta)
					{
						if(this.Cuenta != null)
						{
							this.TipoComprobanteDestino = Cuenta.ComprobanteDeEntregaSugerido(this._processParent.Process.ProcessName, this._taskName, _coleccion.Estado);
							if (TipoComprobanteDestino == null || this.TipoComprobanteDestino.Equals(string.Empty)) 
							{
								string idTipoComprobante = Variables.GetValueString( this._processParent.Process.ProcessName,this.GetTaskName(),_coleccion.Estado+".Comprobante" );
								if (idTipoComprobante.Equals(string.Empty))
								{
									ArrayList aux  = mz.erp.systemframework.Util.Parse(Variables.GetValueString( this._processParent.Process.ProcessName,this.GetTaskName(),"Comprobantes" ),",");
									if(aux.Count > 0)
										this.TipoComprobanteDestino = (string)aux[0];
									else
										this.TipoComprobanteDestino = (string)sl.GetKey(0);
								}
								else
								{
									this.TipoComprobanteDestino = idTipoComprobante;
								}
							}
						}
					}
					else
					{
						string idTipoComprobante = Variables.GetValueString( this._processParent.Process.ProcessName,this.GetTaskName(),_coleccion.Estado+".Comprobante" );
						if (idTipoComprobante.Equals(string.Empty))
						{
							ArrayList aux  = mz.erp.systemframework.Util.Parse(Variables.GetValueString( this._processParent.Process.ProcessName,this.GetTaskName(),"Comprobantes" ),",");
							if(aux.Count > 0)
								this.TipoComprobanteDestino = (string)aux[0];
							else
								this.TipoComprobanteDestino = (string)sl.GetKey(0);
						}
						else
						{
							this.TipoComprobanteDestino = idTipoComprobante;
						}
					}
					
				}
			}


		}

 		private void LoadDataFromClassSeleccionEstadoDeItem( ArrayList estadodeItems )
		{
			mz.erp.businessrules.comprobantes.RelacionesComprobanteOrigenDestino relaciones = new RelacionesComprobanteOrigenDestino(this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask);
			string[] estados = ComprobantesRules.Momentos_ComprobantesDeEntrega_Tareas_EstadosPrevios( this.GetTaskName() );
			EstadosCollection estadosentrega = new EstadosCollection().GenerateFormaDeEntrega();
			ArrayList idestados = estadosentrega.GetIdValues( estados );

			foreach ( mz.erp.businessrules.EstadoItem unestadoItem in estadodeItems )
			{
				if (ContieneEstadoDeItem( unestadoItem.IdEstado, idestados ))
				{
					string IdComprobante = unestadoItem.IdComprobanteOrigen;
					string IdTipoDeComprobante = unestadoItem.IdTipoDeComprobanteOrigen;
					string Numero = string.Empty;
					long Ordinal = unestadoItem.Ordinal;
					decimal CantidadOrigen = unestadoItem.Cantidad;
					decimal CantidadDestino = unestadoItem.Cantidad;
					string IdProducto = unestadoItem.IdProducto;
					string Descripcion = unestadoItem.Descripcion;
					decimal Precio = 0;
					string IdCondicionDeVenta = string.Empty;
					decimal PrecioNetoActual = 0;

                    //German 20120302 -  Tarea 0000247
					RelacionComprobanteOrigenDestino rcod = new RelacionComprobanteOrigenDestino( IdComprobante, IdTipoDeComprobante, Numero, Ordinal, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, 
                        Precio, this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask,unestadoItem.Item.IdListaDePrecios, 
                            unestadoItem.Item.CoeficienteListaDePrecios, unestadoItem.Item.ModoDeAplicacionListaDePrecios, mz.erp.businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio);
                    //Fin German 20120302 -  Tarea 0000247
					rcod.Visible = unestadoItem.Visible;
					relaciones.Add( rcod );
				}
			}
			this.RelacionesComprobantesOrigenDestino = relaciones;
			long idTask = Workflow.GetIdTakByName( this.GetTaskName());
			SortedList sl = Workflow.GetComprobantesAsociadosList( idTask );
			if (sl.Count > 0)
			{
				this.TipoComprobanteDestino = (string)sl.GetKey(0);
			}
			
		}

		private bool ContieneEstadoDeItem( string idestado, ArrayList listadeestados )
		{
			foreach( string estado in listadeestados)
			{
				if (estado.Equals( idestado )) return true;
			}
			return false;

		}

		private void LoadDataFromClassCapturarDatosPreviosComprobantes( CapturarDatosPreviosComprobantes _comprobantesPrevios )
		{
			string comprobantesprevios = Variables.GetValueString( "Momentos."+this.GetTaskName()+".RelacionComprobantesPrevios");
			string[] arraytuplas = comprobantesprevios.Split( ',' );
			System.Collections.Hashtable tuplas = new Hashtable();
			for (int i = 0; i<arraytuplas.Length; i++)
			{
				string[] item = arraytuplas[i].Split(':');
				if (item.Length == 2)
				{
					tuplas.Add( item[0],item[1] );
				}
			}
			
			foreach ( CapturarDatosPreviosComprobantes.ComprobantesConDatosPrevios.ComprobanteConDatosPrevios codp in _comprobantesPrevios.DatosPrevios )
			{
				if (tuplas.ContainsKey( codp.IdTipoDeComprobante ))
				{
					CargarDatosAlmacenados( codp.IdComprobante, (string)tuplas[ codp.IdTipoDeComprobante ]  );
				}
			}

		}
		private void CargarDatosAlmacenados( string idComprobante, string idTipoDeComprobanteDestino )
		{
			string IdListaDePreciosDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaDePreciosDefault");	
			if(IdListaDePreciosDefault.Equals(string.Empty))
				IdListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;

			tlg_ComprobantesDataset.tlg_ComprobantesRow row = mz.erp.businessrules.tlg_Comprobantes.GetByPk( idComprobante );
			if (row != null)
			{
				this._campoAuxiliar1 = row.CampoAuxiliar1;
				this._campoAuxiliar2 = row.CampoAuxiliar2;
				this._campoAuxiliar3 = row.CampoAuxiliar3;
				this._campoAuxiliar4 = row.CampoAuxiliar4;
				this._campoAuxiliar5 = row.CampoAuxiliar5;
				this._fechaConvenida = row.FechaConvenida;
				this._fechaVencimiento = row.FechaVencimiento;
				this._observaciones = row.Observaciones;
				tsa_ComprobantesDataset.tsa_ComprobantesRow rowComprobante = mz.erp.businessrules.tsa_Comprobantes.GetByPk( idComprobante );
				if (rowComprobante != null)
				{
					this.FechaComprobante = rowComprobante.Fecha;
					this.TipoComprobanteDestino = idTipoDeComprobanteDestino;
					this.IdCuenta = rowComprobante.IdCuenta;
					mz.erp.businessrules.comprobantes.RelacionesComprobanteOrigenDestino relaciones = new RelacionesComprobanteOrigenDestino( this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask);
					//tsa_ComprobantesDetDataset.tsa_ComprobantesDetDataTable table = mz.erp.businessrules.tsa_ComprobantesDet.GetList( idComprobante , System.DateTime.MinValue, null, null, long.MinValue ).tsa_ComprobantesDet;
					tsa_ComprobantesDetDataset.tsa_ComprobantesDetDataTable table = mz.erp.businessrules.tsa_ComprobantesDet.GetByPk(idComprobante).tsa_ComprobantesDet;
					foreach (tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow rowDet in table.Rows)
					{
						string IdComprobante = rowDet.IdComprobante;
						string IdTipoDeComprobante = rowComprobante.IdTipoDeComprobante;
						string Numero = string.Empty;
						long Ordinal = rowDet.Ordinal;
						decimal CantidadOrigen = rowDet.Cantidad;
						decimal CantidadDestino = rowDet.Cantidad;
						string IdProducto = rowDet.IdProducto;
						Productos miProducto = new Productos( IdProducto );
						string Descripcion = miProducto.Descripcion;
						decimal Precio = 0;
						string IdCondicionDeVenta = string.Empty;
						decimal PrecioNetoActual = 0;
						string IdListaDePrecio = rowDet.IdListaDePrecio;
						decimal CoeficienteListaDePrecio = rowDet.CoeficienteListaDePrecio;
						string ModoDeAplicacion= rowDet.ModoDeAplicacion;

						mz.erp.businessrules.comprobantes.RelacionComprobanteOrigenDestino relacion = new RelacionComprobanteOrigenDestino( IdComprobante,IdTipoDeComprobante,Numero,Ordinal,CantidadOrigen,CantidadDestino,IdProducto,Descripcion,Precio,IdCondicionDeVenta,PrecioNetoActual, this._processParent.Process.ProcessName, this._taskName, this._processParent.Process.MainTask.KeyTask, IdListaDePrecio, CoeficienteListaDePrecio, ModoDeAplicacion, IdListaDePreciosDefault);
						relaciones.Add( relacion );
					}
					this.RelacionesComprobantesOrigenDestino = relaciones;
				}
			}			

			
		}

        /* Silvina 20120413 - Tarea 0000275 */

        private void SeleccionarDomicilio()
        {
            if (!_muestraFormulario)
            {
                ArrayList domAux = new ArrayList();
                foreach (mz.erp.businessrules.Domicilio dom in this.DomiciliosAsociados)
                {
                    if (dom.IdTipoDomicilio.Trim().Equals(IdTipoDomicilioEntregas))
                    {
                        domAux.Add(dom);
                    }
                }
                string domDef = Cuenta.IdDomicilioDefault;
                if (domAux.Count >= 1)
                {
                    mz.erp.businessrules.Domicilio dom = (mz.erp.businessrules.Domicilio)domAux[0];
                    foreach (mz.erp.businessrules.Domicilio domE in domAux)
                    {
                        if (domDef == domE.IdDomicilio)
                            dom = domE;
                    }                    
                    dom.Checked = true;
                    foreach (mz.erp.businessrules.Domicilio dom1 in this.DomiciliosAsociados)
                    {
                        if (dom != dom1)
                            dom1.Checked = false;
                    }
                }
                else
                {                    
                    foreach (mz.erp.businessrules.Domicilio dom1 in this.DomiciliosAsociados)
                    {
                        if (domDef != dom1.IdDomicilio)
                            dom1.Checked = false;
                        else
                            dom1.Checked = true;
                    }
                }
            }
        }

        /* Fin Silvina 20120413 - Tarea 0000275 */

		#endregion

		#region Funciones y Métodos Publicos

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		
		public bool MyIsValid()
		{			
			bool isValid = true;
			if (this.FechaVencimiento < this.FechaConvenida)
			{
				isValid = false;
				_errores.Add( new ItemDatasetError("Entregas", "FechaVencimiento", "La fecha de vencimiento no puede ser anterior a la fecha convenida"));
			}
		
			string mensaje = ValidarDomiciliosAsociados();
			if (!mensaje.Equals( string.Empty ))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError("Entregas", "Domicilio de Entrega", mensaje  ));
			}			

			return isValid;
		}
		private string ValidarDomiciliosAsociados()
		{

			int countChecked = 0;
			string mensaje = string.Empty;
			_warning = string.Empty;
			foreach( Domicilio _domicilio in this.DomiciliosAsociados )
			{
				if (_domicilio.Checked)
					countChecked++;
			}
			if (countChecked == 0)
			{
				if (ComprobantesRules.ValidarDomicilioEntregasSinSeleccion( this.GetTaskName()))
					mensaje = "Debe seleccionar un domicilio";
				else
					if (ComprobantesRules.AdvertirDomicilioEntregasSinSeleccion( this.GetTaskName()))
						_warning = "No hay ningún domicilio seleccionado para realizar la entrega. ¿Desea continuar de todas formas?";
			}
			else
			{
				if (countChecked > 1 && ComprobantesRules.ValidarDomicilioEntregasMultipleSeleccion( this.GetTaskName()))
				{
					mensaje = "Debe seleccionar un solo domicilio";
				}
			}
			return mensaje;
		}
		

		public void MyCommit() 
		{
			_row = businessrules.tlg_Comprobantes.NewRow();
			_row.IdComprobante = this.IdComprobante;
			_row.FechaConvenida = this.FechaConvenida;
			_row.FechaVencimiento = this.FechaVencimiento;
			_row.Observaciones = this.Observaciones;			
			_row.CampoAuxiliar1 = this.CampoAuxiliar1;
			_row.CampoAuxiliar2 = this.CampoAuxiliar2;
			_row.CampoAuxiliar3 = this.CampoAuxiliar3;
			_row.CampoAuxiliar4 = this.CampoAuxiliar4;
			_row.CampoAuxiliar5 = this.CampoAuxiliar5;
			tlg_ComprobantesDataset data = new tlg_ComprobantesDataset();
			foreach( Domicilio _domicilio in this.DomiciliosAsociados )
			{
				if (_domicilio.Checked)
				{
					_row.IdDomicilio = _domicilio.IdDomicilio;
					break;
				}
			}
			data.tlg_Comprobantes.LoadDataRow(_row.ItemArray,false);
			_data = (DataSet) data;
		}

		public string ComprobantesDeOrigenRelacionados
		{
			get 
			{
				return Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas");
			}
		}

		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}


		
		#region implementacion ITask

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		public string GetWarnings()
		{			
			return _warning;
		}
		
		public ProcessManager GetProcessManagerParent()
		{
			return this._processParent;
		}

		public void ListenerTaskDependentChanged(object sender)
		{
							   

		}

		public void ListenerAfterExecuteDependentTask( object sender )
		{
			
			ITask taskInstance = (ITask) sender;
			
			
			if(ComprobanteDeEntregaRules.IsValidRule((typeof(mz.erp.businessrules.ComprobantesPendientes)),taskInstance))
			{
				ComprobantesPendientes comprobantesPendientes = (ComprobantesPendientes)sender;
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					this.RelacionesComprobantesOrigenDestino = comprobantesPendientes.RelacionesComprobanteOrigenDestino;
					this.Step();
					this.ComprobanteDeEntrega_OnRecalcularComprobante(this, new EventArgs());
				}
			}
			if(ComprobanteDeEntregaRules.IsValidRule((typeof(mz.erp.businessrules.SeleccionItemsPendientes)),taskInstance))
			{
				SeleccionItemsPendientes itemsPendientes = (SeleccionItemsPendientes)sender;
				//if(this.RelacionesComprobantesOrigenDestino == null )
				//{
					if(itemsPendientes.RelacionesComprobanteOrigenDestino != null && itemsPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
					{
						
						Util.InitTimer();
                        this.RelacionesComprobantesOrigenDestino = itemsPendientes.RelacionesComprobanteOrigenDestino;
						//this.SetRelacionesComprobantesOrigenDestino(itemsPendientes.RelacionesComprobanteOrigenDestino);
						this.Step();
						string mil = Util.GetMilliseconds();
						this.ComprobanteDeEntrega_OnRecalcularComprobante(this, new EventArgs());
					}
				//}
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta )))
			{
				ComprobanteDeVenta comprobante = (ComprobanteDeVenta)sender;
				string _sourceTask = comprobante.GetTaskName();
				if (_sourceTask.Equals( "Vender") || _sourceTask.Equals("Prevender") || _sourceTask.Equals( "VenderManual") || _sourceTask.Equals( "Prestar") || _sourceTask.Equals("Preprestar"))
				{
					/*German*/
					//LoadDataFromClassComprobanteDeVenta( comprobante );
				}
			}
			if ((sender.GetType().Equals( typeof( mz.erp.businessrules.GenerarComprobantesEntregas ) )) && (this.GetTaskName().CompareTo( "PredefinirEntregar") != 0) && (this.GetTaskName().CompareTo( "Entregar" ) != 0))
			{
				GenerarComprobantesEntregas _colecciontareas = (GenerarComprobantesEntregas)sender;
                /* Silvina 20120413 - Tarea 0000275 */
                _muestraFormulario = false;
                /* Fin Silvina 20120413 - Tarea 0000275 */
				LoadDataFromClassGenerarComprobantesEntregas( _colecciontareas );
				//this.Execute();
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.SeleccionEstadoDeItem )))
			{
				SeleccionEstadoDeItem _seleccion = (SeleccionEstadoDeItem)sender;
				LoadDataFromClassSeleccionEstadoDeItem( _seleccion.ArrayItems );
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.CapturarDatosPreviosComprobantes )))
			{
				LoadDataFromClassCapturarDatosPreviosComprobantes( (CapturarDatosPreviosComprobantes) sender );
			}
			if(sender.GetType() == typeof(mz.erp.businessrules.FiscalComprobantes))
			{
				FiscalComprobantes impresion = (FiscalComprobantes) sender;
				this._comprobanteDeVenta.Numero = impresion.Numero;
				this._comprobanteDeVenta.ActualizaNumeracion = impresion.ActualizaNumeracion;
			}
			if(sender.GetType() == typeof(mz.erp.businessrules.ObtenerComprobantesAsociados))
			{
				if(_processParent.Process.ProcessName.Equals("ProcesoVenderDevolver")
					|| _processParent.Process.ProcessName.Equals("ProcesoPrestarDevolver")
					|| _processParent.Process.ProcessName.Equals("ProcesoVenderDevolverManual")
					|| _processParent.Process.ProcessName.Equals("ProcesoVenderDevolverBienDeUso")
					)
				{
					
					ObtenerComprobantesAsociados comp = (ObtenerComprobantesAsociados) sender;
					if(comp.RelacionesComprobantes.Count > 0)
					{
						_seDebeEjecutar = true;
						this.RelacionesComprobantesOrigenDestino = comp.RelacionesComprobantes;
						this.Step();
						this.ComprobanteDeEntrega_OnRecalcularComprobante(this, new EventArgs());
					}
					else _seDebeEjecutar = false;
				}
			}	

		}

		private void SetRelacionesComprobantesOrigenDestino(RelacionesComprobanteOrigenDestino crod)
		{
			this._comprobanteDeVenta.SetRelacionesComprobantesOrigenDestino(crod);
		}
		public void ListenerBeforeExecuteDependentTask( object sender ){}

		public bool IsValid() 
		{
			_errores.Clear();
			bool isValid = true;
			if(_seDebeEjecutar)
			{
				if (this.AllowSave())
				{
					isValid = _comprobanteDeVenta.IsValid();
					if (! isValid) 
					{
						this._errores = _comprobanteDeVenta.Errores;
					}
					else 
					{
						isValid = MyIsValid();
					}
				}
				else 
				{
					_errores.Add( new ItemDatasetError( "Comprobante","Items","Debe seleccionar al menos un item"));
					isValid = false;
				}
			}
			return isValid;
		}
		private bool _tipoDeComprobanteSugeridoSegunCuenta = false;
        //German 20120605 - Tarea 0000347
        private bool _debeActualizarNumeroCompartido = false;
        private string _idVariableNumeroCompartido = null;
        //Fin German 20120605 - Tarea 0000347

		public void Init() 
		{
			_idComprobante = mz.erp.systemframework.Util.NewStringId() ;
			_fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
			_fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			_observaciones = string.Empty;
			_campoAuxiliar1 = string.Empty;
			_campoAuxiliar2 = string.Empty;
			_campoAuxiliar3 = string.Empty;
			_campoAuxiliar4 = string.Empty;
			_campoAuxiliar5 = string.Empty;
			_arrData = new TaskCollectionData();
			_guardaPrecioItems = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "GrabaPrecioItems");
			_tipoDeComprobanteSugeridoSegunCuenta = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "TipoComprobanteSugeridoSegunCuenta", _tipoDeComprobanteSugeridoSegunCuenta);
			_tareaOrigenPrecioItems = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "TareaOrigenPrecioItems");
			_listaTiposDeComprobantesSugiereNumeracion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumero.ListaTiposDeComprobantes");
			_allowOtrosDomicilios = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermitirOtrosDomicilios");			
			_comprobanteDeVenta.Init();
			_comprobanteDeVenta.OnRecalcularComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RecalcularComprobante(ComprobanteDeEntrega_OnRecalcularComprobante);
			_comprobanteDeVenta.OnRefrescarComprobante +=new mz.erp.businessrules.comprobantes.ComprobanteDeVenta.RefrescarComprobante(ComprobanteDeEntrega_OnRecalcularComprobante);
			

			this._mascara = tsy_TiposDeComprobantes.Mascara(_comprobanteDeVenta.TipoComprobanteDestino);
			if(this._mascara != null )
			{
				this._numero = this._mascara;
				if(this.SugiereNumeracion())
				{
					if(_comprobanteDeVenta.TipoComprobanteDestino != null && _comprobanteDeVenta.TipoComprobanteDestino != string.Empty)
					{
                        //German 20120605 - Tarea 0000347
                        string _listaTiposDeComprobantesSugiereNumeracionCompartida = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumero.ListaTiposDeComprobantesCompartenNumeracion");
                        ArrayList aux = new ArrayList();
                        if(_listaTiposDeComprobantesSugiereNumeracionCompartida != null && _listaTiposDeComprobantesSugiereNumeracionCompartida!= string.Empty)
                            aux = mz.erp.systemframework.Util.Parse(_listaTiposDeComprobantesSugiereNumeracionCompartida, ",");
                        if (aux.Contains(this.TipoComprobanteDestino)) //Si comparte la numercion con otro tipo de comprobante, es para cuando son distintos tipos de comprobantes para el sistema que comparten el mismo preimpreso.
                        {
                            string _tipoDeComprobanteComparteNumero = Variables.GetValueStringWithoutCache("Comprobantes.NumeracionCompartida." + _comprobanteDeVenta.TipoComprobanteDestino + ".ComparteCon");
                            if (_tipoDeComprobanteComparteNumero != null && _tipoDeComprobanteComparteNumero != string.Empty)
                            {
                                string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + _tipoDeComprobanteComparteNumero);
                                _debeActualizarNumeroCompartido = true;
                                _idVariableNumeroCompartido = "Comprobantes.Numeracion." + _tipoDeComprobanteComparteNumero;
                                if (numeracion != string.Empty)
                                    this._numero = Util.StcZero(numeracion, 8);
                            }
                        }
                        else
                        {
                            string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + _comprobanteDeVenta.TipoComprobanteDestino);
                            if (numeracion != string.Empty)
                                this._numero = Util.StcZero(numeracion, 8);
                        }
                        //Fin German 20120605 - Tarea 0000347
					}

					
				}					
			}
			//German 20100118 SP6 647
			_idTipoDomicilioEntregas = Variables.GetValueString("Cuentas.Domicilios.IdTipoDomicilioEntregas");
			//Fin German 20100118 SP6 647
		}
		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		private string _taskName = null;
		
		public string GetTaskName()
		{
			return _taskName;
		}
		public void SetTaskName(string taskName )
		{
			_taskName = taskName;
			this._comprobanteDeVenta.SetTaskName(taskName);
		}
		ProcessManager _processParent = null;
		public void SetProcessManagerParent( ProcessManager process )
		{
			_processParent = process;
			this._comprobanteDeVenta.SetProcessManagerParent(process);
		}
		#endregion
		#region Metodos Privados
		private bool SugiereNumeracion()
		{
			ArrayList aux = mz.erp.systemframework.Util.Parse(_listaTiposDeComprobantesSugiereNumeracion, ",");
			return aux.Contains(this.TipoComprobanteDestino);
		}
		#endregion


		#endregion

		#region Implementacion IPersistentTask

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			array.Add((DataSet)this.DatasetComprobante );
			array.Add((DataSet)this.Data);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData _taskCollection = new TaskCollectionData();
			_taskCollection.TaskName = this.GetTaskName();
			if(_seDebeEjecutar)
			{
				_taskCollection.Add( this._comprobanteDeVenta.DatasetComprobante );
				_taskCollection.Add( this.Data );
			}
			return _taskCollection;
		}

		public void Commit() 
		{
			if(_seDebeEjecutar)
			{
				this._comprobanteDeVenta.Observaciones = this._observaciones;
				this._comprobanteDeVenta.Commit();
				this.MyCommit();
				this._arrData.Add( (DataSet)this._comprobanteDeVenta.DatasetComprobante );
				this._arrData.Add( (DataSet)this.Data );
				this._arrData.TaskName = this.GetTaskName();
			}
		}
		
		/// <summary>
		/// Toma los datos almacenados hasta el momento en el proceso y utiliza los que necesita según la tarea que este realizando
		/// </summary>
		/// <param name="_processCollectionData"></param>
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{
			foreach( TaskCollectionData data in _processCollectionData )
			{
				 if (data.TaskName.Equals("Vender") || data.TaskName.Equals("VenderManual") || 
					 data.TaskName.Equals("Prestar") || data.TaskName.Equals("Prevender") ||
					 data.TaskName.Equals("Preprestar"))
				{
					string idComprobante = string.Empty;
					string numero = string.Empty;
					string tipoDeComprobante = string.Empty;
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
						{
							DataTable table = dataset.Tables["tsa_Comprobantes"];
							DataRow row = table.Rows[0];
							idComprobante = (string)row["IdComprobante"];
							numero = Convert.ToString(row["Numero"]);
							tipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
							
							foreach( DataRow row2 in this._comprobanteDeVenta.DatasetComprobante.tsa_ComprobantesRelacionOrigenDestino.Rows)
							{
								row2["IdComprobanteOrigen"] = idComprobante;
							}
							
									
							/*Graba en tsa_comprobantedet*/
							table = this._comprobanteDeVenta.DatasetComprobante.Tables["tsa_ComprobantesDet"];
							//string IdComprobante = Convert.ToString(this._comprobanteDeVenta.DatasetComprobante.tsa_Comprobantes.Rows[0]["IdComprobante"]);
							decimal Total = 0;
							decimal Cantidad = 1;
							foreach(DataRow rowDetEntrega in table.Rows)
							{
								
								if(_guardaPrecioItems)
								{
									if( data.TaskName.Equals(_tareaOrigenPrecioItems))
									{
								
										long ordinal = Convert.ToInt64(rowDetEntrega["Ordinal"]);
										long ordinalOrigen  = Convert.ToInt64(_mapOrdinales[ordinal]);
										DataRow rowD = dataset.Tables["tsa_ComprobantesDet"].Rows.Find(new object[]{idComprobante, ordinalOrigen});
										rowDetEntrega["PrecioBruto"] = rowD["PrecioBruto"] ;
										rowDetEntrega["PrecioNeto"] = rowD["PrecioNeto"] ;
										rowDetEntrega["DescuentosAplicados"] = rowD["DescuentosAplicados"] ;
										rowDetEntrega["BonificacionRecargoFinanciero"] = rowD["BonificacionRecargoFinanciero"] ;
										rowDetEntrega["BonificacionRecargoCuenta"] = rowD["BonificacionRecargoCuenta"] ;
										rowDetEntrega["BonificacionRecargoProducto"] = rowD["BonificacionRecargoProducto"] ;
										rowDetEntrega["PrecioFinal"] = rowD["PrecioFinal"] ;
										rowDetEntrega["PrecioDeCosto"] = rowD["PrecioDeCosto"] ;
										rowDetEntrega["ImpuestosDirectos"] = rowD["ImpuestosDirectos"] ;
										rowDetEntrega["ImpuestosIndirectos"] = rowD["ImpuestosIndirectos"] ;
										Cantidad = Convert.ToDecimal(rowDetEntrega["Cantidad"]); 
										Total = Total + (Convert.ToDecimal(rowD["PrecioFinal"])* Cantidad) ;
									}
								}
								if(_grabaNumeroComprobanteVentaAsociado)
								{
									rowDetEntrega["Numero"] = numero;
								}
								
							}
							if(_guardaPrecioItems)
							{
								if( data.TaskName.Equals(_tareaOrigenPrecioItems))
								{
										
									/*Graba en tsa_comprobantedetalleimpuestos*/
									table = this._comprobanteDeVenta.DatasetComprobante.Tables["tsa_ComprobanteDetalleImpuestos"];
									//string IdComprobante = Convert.ToString(this._comprobanteDeVenta.DatasetComprobante.tsa_Comprobantes.Rows[0]["IdComprobante"]);
									foreach(DataRow rowDetImpuesto in table.Rows)
									{
										
										long ordinal = Convert.ToInt64(rowDetImpuesto["Ordinal"]);
										string IdImpuesto = Convert.ToString(rowDetImpuesto["IdImpuesto"]);
										long ordinalOrigen  = Convert.ToInt64(_mapOrdinales[ordinal]);
										DataRow rowD = dataset.Tables["tsa_ComprobanteDetalleImpuestos"].Rows.Find(new object[]{idComprobante, ordinalOrigen, IdImpuesto});
										rowDetImpuesto["Valor"] = rowD["Valor"] ;
				
									}
								}
							}
							/*Graba en tsa_comprobantes*/
							table = this._comprobanteDeVenta.DatasetComprobante.Tables["tsa_comprobantes"];
							//string IdComprobante = Convert.ToString(this._comprobanteDeVenta.DatasetComprobante.tsa_Comprobantes.Rows[0]["IdComprobante"]);
							DataRow rowC = dataset.Tables["tsa_Comprobantes"].Rows.Find(new object[]{idComprobante});
							if(_guardaPrecioItems)
							{
								if( data.TaskName.Equals(_tareaOrigenPrecioItems))
								{
									table.Rows[0]["Total"] = Total;
								}
							}
							if(_grabaNumeroComprobanteVentaAsociado)
							{
								table.Rows[0]["Numero"] = numero;
							}
				
								
							table = this._comprobanteDeVenta.DatasetComprobante.Tables["tsa_ComprobantesDetAuxiliares"];
							//string IdComprobante = Convert.ToString(this._comprobanteDeVenta.DatasetComprobante.tsa_Comprobantes.Rows[0]["IdComprobante"]);
							foreach(DataRow rowDetAuxiliares in table.Rows)
							{
								long ordinal = Convert.ToInt64(rowDetAuxiliares["Ordinal"]);
								long ordinalOrigen  = Convert.ToInt64(_mapOrdinales[ordinal]);
								DataRow rowD = dataset.Tables["tsa_ComprobantesDetAuxiliares"].Rows.Find(new object[]{idComprobante, ordinalOrigen});
								rowDetAuxiliares["IdOrdenReparacion"] = rowD["IdOrdenReparacion"] ;
								rowDetAuxiliares["IdInstanciaOrdenReparacion"] = rowD["IdInstanciaOrdenReparacion"] ;
								rowDetAuxiliares["IdRepuestoOrdenReparacion"] = rowD["IdRepuestoOrdenReparacion"] ;
								rowDetAuxiliares["IdTareaRealizada"] = rowD["IdTareaRealizada"] ;
								rowDetAuxiliares["IdComprobantesSucesores"] = rowD["IdComprobantesSucesores"] ;
								rowDetAuxiliares["IdComprobantesPredecesores"] = rowD["IdComprobantesPredecesores"] + "," + idComprobante;
								rowDetAuxiliares["IdTiposComprobantesPredecesores"] = rowD["IdTiposComprobantesPredecesores"] + "," + tipoDeComprobante;
								rowDetAuxiliares["IdTiposComprobantesSucesores"] = rowD["IdTiposComprobantesSucesores"] ;
								rowDetAuxiliares["OrdinalesPredecesores"] = rowD["OrdinalesPredecesores"] + "," + Convert.ToString(ordinalOrigen);

							}
						}
					}
					 
				 
				}
			
			}
		}

      

       

		public void Flush( string idTransaction ) 
		{
			if(_seDebeEjecutar)
			{
				if (this.AllowSave())
				{
				
					if(OnTaskBeforeFlush != null)
						OnTaskBeforeFlush(this, new EventArgs());

					if(_grabaNumeroComprobanteVentaAsociado) this._comprobanteDeVenta.ActualizaNumeracion = false;
					_comprobanteDeVenta.Flush( idTransaction );
					PutDataFromComprobantesDeVenta(this._comprobanteDeVenta.DatasetComprobante );
					dataaccess.tlg_Comprobantes.Update(this.Data.Tables["tlg_Comprobantes"], _replication, idTransaction);
                    //German 20120605 - Tarea 0000347
                    if(_debeActualizarNumeroCompartido)
                        mz.erp.dataaccess.sy_Variables.Update(_idVariableNumeroCompartido, this.Numero, idTransaction);
                    //Fin German 20120605 - Tarea 0000347
					_replication = GenerateReplication();
					_replication.Sentence.Append( _comprobanteDeVenta.GetSentenceReplication().Sentence );
					if(OnTaskAfterFlush != null)
						OnTaskAfterFlush(this, new EventArgs());

				}
			}
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication = new mz.erp.commontypes.SentenciasReplicacion();
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}	
		
		private mz.erp.commontypes.SentenciasReplicacion  GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tlg_Comprobantes";
			return replication;
			
		}

		private void PutDataFromComprobantesDeVenta(tsa_ComprobantesExDataset _comprobanteDeVenta ) 
		{			
			tlg_ComprobantesDataset data = (tlg_ComprobantesDataset)this._data;
			((tlg_ComprobantesDataset) data).tlg_Comprobantes.Rows[0]["IdComprobante"] = _comprobanteDeVenta.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"];
			this.IdComprobante = Convert.ToString(_comprobanteDeVenta.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"]);
			this._data = data; 
		}

		
		private mz.erp.commontypes.SentenciasReplicacion  GenerateReplicaction()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tlg_Comprobantes";
			return replication;
		}


		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}


		public bool AllowEdit()
		{
			bool _should_edit = false;
			if (IsValid())
			{
				_should_edit = ComprobantesRules.Momentos_Visualizar( this.GetTaskName() );
			}
			else
			{
				_should_edit = true;
			}
			return _should_edit;
		}
		public bool AllowShow()
		{
			//return ComprobantesRules.Momentos_Visualizar( this.GetTaskName() ); 
			return ComprobantesRules.Momentos_Visualizar(this._processParent.Process.ProcessName, this._taskName);

		}
		public void FormHasClosed() 
		{
		}
		private bool AllowSave()
		{
			if (this.Items.Count == 0) 
			{ 
				return false; 
			}
			else 
			{
				return true; 
			}
		}

		#endregion

	}

	public class ComprobanteDeEntregaRules
	{
		private static System.Collections.SortedList _rules = new SortedList();

		public static bool IsValidRule(Type classTypeSourceEvent, ITask task)
		{
			
			string processName = task.GetProcessManagerParent().Process.ProcessName;
			if(_rules.Count == 0)
			{
				GenerateRules();
			}
			bool ruleValid = task.GetType().Equals(classTypeSourceEvent);
			if(_rules.Contains(classTypeSourceEvent.FullName))
			{
				string procesos = (string)_rules[classTypeSourceEvent.FullName];
				ArrayList procesosArray = mz.erp.systemframework.Util.Parse(procesos, ",");
				return procesosArray.Contains(processName) && ruleValid;
			}
			else return true && ruleValid;
		}

		private static void GenerateRules()
		{
            //German 20120213 -  Tarea 0000247
            _rules.Add((typeof(mz.erp.businessrules.ComprobantesPendientes)).FullName, "ProcesoPredefinirEntregarEntregar,ProcesoPrepararDiferidoPreparar,ProcesoPrepararConfirmarPreparar,ProcesoEntregar,ProcesoRemitir,ProcesoRemitirConfirmarRemitir,ProcesoPrevenderVender,ProcesoPrestar,ProcesoVender,ProcesoPrevenderVenderBienDeUso,ProcesoPrepararDiferidoEnviar,ProcesoAnularPreparar,ProcesoAnularPrepararDiferido,ProcesoEntregarDV,ProcesoAnularPrepararDiferidoDV,ProcesoEntregarManual,ProcesoAnularPreRemitirHudson,ProcesoPreRemitirRemitirHudson,ProcesoEntregarAcopio,ProcesoEntregarAcopioDV");
            _rules.Add((typeof(mz.erp.businessrules.SeleccionItemsPendientes)).FullName, "ProcesoPredefinirEntregarEntregar,ProcesoPrepararDiferidoPreparar,ProcesoPrepararConfirmarPreparar,ProcesoEntregar,ProcesoRemitir,ProcesoPrevenderVender,ProcesoPrestar,ProcesoVender,ProcesoAnularRemitir,ProcesoPrevenderVenderBienDeUso,ProcesoPrepararDiferidoEnviar,ProcesoAnularPreparar,ProcesoAnularPrepararDiferido,ProcesoEntregarDV,ProcesoAnularPrepararDiferidoDV,ProcesoEntregarManual,ProcesoAnularPreRemitirHudson,ProcesoPreRemitirRemitirHudson,ProcesoEntregarAcopio,ProcesoEntregarAcopioDV");
            //Fin German 20120213 -  Tarea 0000247
		}


	}
}
