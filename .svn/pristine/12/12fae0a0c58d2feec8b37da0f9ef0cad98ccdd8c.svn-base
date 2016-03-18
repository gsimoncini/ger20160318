using System;
using System.Collections;

using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Clase auxiliar para traspaso de datos entre la clase generadora de comprobantes de entrega y la clase de entregas
	/// </summary>
	public class ColeccionDatosComprobantesEntrega: System.Collections.ArrayList, System.Collections.IEnumerator
	{
		public ColeccionDatosComprobantesEntrega()
		{
			nIndex = -1;
		}
		public void Add( mz.erp.businessrules.EstadoItem item )
		{
			base.Add( item );
		}
		private string _taskName = string.Empty;
		private string _estado = string.Empty;
		private string _idestado = string.Empty;
		private System.DateTime _fechaEntrega = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idResponsable = string.Empty;
		private string _codigoCuenta = string.Empty;
		private string _infoCliente = string.Empty;
		private System.DateTime _fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
		private System.DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;		
		private string _idTipoComprobanteOrigen = string.Empty;
		private string _idComprobanteOrigen = string.Empty;
		private int nIndex;

		public string IdEstado
		{
			set { _idestado = value ;}
			get { return _idestado ; }
		}
		public string Estado
		{
			set { _estado = value ;}
			get { return _estado ; }
		}
		public string InfoCliente
		{
			set { _infoCliente = value ;}
			get { return _infoCliente ; }
		}
		public System.DateTime FechaEntrega
		{
			set { _fechaEntrega = value ; }
			get { return _fechaEntrega ; }
		}
		public System.DateTime FechaConvenida 
		{
			set { _fechaConvenida = value ; }
			get { return _fechaConvenida ;}
		}
		public System.DateTime FechaVencimiento
		{
			set { _fechaVencimiento = value ; }
			get { return _fechaVencimiento ; }
		}
		
		public string IdResponsable
		{
			set { _idResponsable = value ;}
			get { return _idResponsable ; }
		}
		public string CodigoCuenta
		{
			set { _codigoCuenta = value ;}
			get { return _codigoCuenta ; }
		}
		public string TaskName
		{
			set { _taskName = value ; }
			get { return _taskName ; }
		}
				
		#region Miembros de IEnumerator

		public void Reset()
		{
			nIndex = -1;
		}

		public object Current
		{
			get
			{
				if (nIndex < 0 || nIndex == base.Count)
					throw new IndexOutOfRangeException();
				return (mz.erp.businessrules.EstadoItem )base[nIndex];
			}
		}

		public bool MoveNext()
		{
			nIndex ++;
			return (nIndex < base.Count);
		}
		#endregion

	}
	
	public class ConjuntoColeccionesEntregas: System.Collections.ArrayList
	{
		public ConjuntoColeccionesEntregas()
		{
		}
		public void Add( ColeccionDatosComprobantesEntrega _unaColeccion )
		{
			base.Add( _unaColeccion );
		}
		
		public bool Contains( string _estado, System.DateTime _fechaentrega )
		{
			bool lret = false;
			foreach ( ColeccionDatosComprobantesEntrega _unaColeccion in this )
			{
				if (_unaColeccion.Estado.Equals( _estado ) && _unaColeccion.FechaEntrega.Equals( _fechaentrega ))
				lret = true;
			}
			return lret;
		}
        //German 20120523 - tarea 0000338
        public int IndexOf(string _estado, System.DateTime _fechaentrega)
        {
            int n = -1;
            bool ok = false;
            foreach (ColeccionDatosComprobantesEntrega _unaColeccion in this)
            {
                n++;
                if (_unaColeccion.IdEstado.Equals(_estado) && _unaColeccion.FechaEntrega.Date.Equals(_fechaentrega.Date))
                {
                    //ok = true;					
                    return n;
                }

            }
            //if(ok)return n;
            //else return -1;
            return -1;
        }
        //Fin German 20120523 - tarea 0000338

	}
	
	/// <summary>
	/// Descripción breve de GenerarComprobantesEntregas.
	/// </summary>
	public class GenerarComprobantesEntregas: GenerateCollectionCommonTasks
	{
		
		public override event System.EventHandler ObjectHasChanged;

		public override event System.EventHandler OnTaskBeforeExecute;

		public override event System.EventHandler OnTaskAfterExecute;

		public override event System.EventHandler OnTaskAfterFlush;

		public override event System.EventHandler OnTaskBeforeFlush;


		public override  event System.EventHandler OnTaskBeforePrevious;
		public override event System.EventHandler OnTaskAfterPrevious;

		public GenerarComprobantesEntregas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		public override void ListenerAfterExecuteDependentTask( object sender )
		{
			ITask taskInstance = (ITask) sender;
			if (sender.GetType().Equals( typeof(mz.erp.businessrules.SeleccionEstadoDeItem)))
			{
				ArrayList estadoDeItems = ((SeleccionEstadoDeItem)sender).ArrayItems;
				LoadDataFromClassSeleccionEstadoDeItem( estadoDeItems );
			}
			if (sender.GetType().Equals( typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta )))
			{
				ComprobanteDeVenta comprobante = (ComprobanteDeVenta)sender;
				string _sourceTask = comprobante.GetTaskName();
				if (_sourceTask.Equals( "Vender") || _sourceTask.Equals("Prevender")|| 
					_sourceTask.Equals("VenderManual") || _sourceTask.Equals("Prestar")
					|| _sourceTask.Equals("Preprestar") || _sourceTask.Equals("Pedir"))
				{
					LoadDataFromClassComprobanteDeVenta( comprobante );
				}
			}

		}

		private string _observaciones = string.Empty;
		public string Observaciones
		{
			get{return _observaciones;}
		}

		private void LoadDataFromClassComprobanteDeVenta( ComprobanteDeVenta comprobante )
		{
			this._idResponsable = comprobante.IdResponsable;
			this._codigoCuenta = comprobante.CodigoCuenta;
			this._fechaConvenida = comprobante.FechaComprobante;
			this._fechaVencimiento = comprobante.FechaComprobante;			
			this._infoCliente = comprobante.InfoCliente;
			this._observaciones = comprobante.Observaciones;

		}

		private ConjuntoColeccionesEntregas _conjunto = new ConjuntoColeccionesEntregas();
		private string _idResponsable = string.Empty;
		private string _codigoCuenta = string.Empty;
		private System.DateTime _fechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
		private System.DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _infoCliente = string.Empty;
		
		public void LoadDataFromClassSeleccionEstadoDeItem(ArrayList estadodeItems)
		{
			this.Clear();
			System.Collections.Hashtable tupla = new Hashtable();
			EstadosCollection estadosEntrega = new EstadosCollection().GenerateFormaDeEntrega();
			foreach (Estado _estado in estadosEntrega)
			{
				string _tarea = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+_estado.Descripcion+".TareaAsociada" );
				if (!_tarea.Equals(string.Empty))
				{
					tupla.Add( _estado.IdItem , _tarea );
				}
			}
			
			foreach (EstadoItem unestadoItem in estadodeItems)
			{
				
				int index = _conjunto.IndexOf( unestadoItem.IdEstado, unestadoItem.FechaDeEntrega );
				string _nombreestado = estadosEntrega.GetValue( unestadoItem.IdEstado );
				string _subtaskName = string.Empty;
				if (tupla.ContainsKey( unestadoItem.IdEstado ))
				{
					_subtaskName= (string)tupla[ unestadoItem.IdEstado ];
				}
				if(_subtaskName != null && _subtaskName != string.Empty)
				{
					if (index != -1)
					{
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).Add( unestadoItem );
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).FechaEntrega = unestadoItem.FechaDeEntrega;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).IdEstado = unestadoItem.IdEstado;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).Estado = _nombreestado;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).TaskName = _subtaskName;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).IdResponsable = this._idResponsable;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).CodigoCuenta = this._codigoCuenta;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).InfoCliente = this._infoCliente;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).FechaConvenida = this._fechaConvenida;
						((ColeccionDatosComprobantesEntrega)_conjunto[index]).FechaVencimiento = this._fechaVencimiento;
					}
					else
					{
						ColeccionDatosComprobantesEntrega _nuevogrupo = new ColeccionDatosComprobantesEntrega();
						_nuevogrupo.Add( unestadoItem );
						_nuevogrupo.FechaEntrega = unestadoItem.FechaDeEntrega;
						_nuevogrupo.IdEstado = unestadoItem.IdEstado;
						_nuevogrupo.Estado = _nombreestado;
						_nuevogrupo.TaskName = _subtaskName;
						_nuevogrupo.IdResponsable = this._idResponsable;
						_nuevogrupo.CodigoCuenta = this._codigoCuenta;
						_nuevogrupo.InfoCliente = this._infoCliente;
						_nuevogrupo.FechaConvenida = this._fechaConvenida;
						_nuevogrupo.FechaVencimiento = this._fechaVencimiento;
						_conjunto.Add( _nuevogrupo );
					}
				}
			}
			
			foreach (ColeccionDatosComprobantesEntrega _datostarea in _conjunto )
			{
				
				mz.erp.businessrules.comprobantes.ComprobanteDeEntrega _compEntrega = new mz.erp.businessrules.comprobantes.ComprobanteDeEntrega();
				_compEntrega.SetTaskName( _datostarea.TaskName );
				_compEntrega.SetProcessManagerParent( this.GetProcessManagerParent() );
				_compEntrega.Init();
				_compEntrega.OnTaskAfterExecute += new System.EventHandler(this.ListenerAfterExecuteSubTask);
				_compEntrega.OnTaskAfterFlush += new System.EventHandler(this.ListenerAfterFlushSubTask);
				
				this.AddTask( _compEntrega );
			}
			base.SpreadingListenerAfterExecuteDependentTask( this );
		}
		public ColeccionDatosComprobantesEntrega GetConjuntoColeccionEntregasByTaskName( string taskName )
		{
			foreach ( ColeccionDatosComprobantesEntrega _unaColeccion in this._conjunto )
			{
				if (_unaColeccion.TaskName.Equals( taskName ))
				{
					_conjunto.Remove(_unaColeccion);
					return _unaColeccion;
				}
			}
			return null;
		}
		public void ListenerAfterExecuteSubTask(object sender, System.EventArgs e) 
		{
			if (this.OnTaskAfterExecute !=  null)
			{
				 this.OnTaskAfterExecute(this, new System.EventArgs());
			}
		}
		public void ListenerAfterFlushSubTask(object sender, System.EventArgs e) 
		{
			if (this.OnTaskAfterFlush !=  null)
			{
				this.OnTaskAfterFlush(this, new System.EventArgs());
			}
		}

		public override void Execute()
		{
			if (OnTaskBeforeExecute != null)
			{
				OnTaskBeforeExecute( this, new System.EventArgs());
			}
			if (OnTaskAfterExecute != null)
			{
				OnTaskAfterExecute( this, new System.EventArgs() );
			}
	
		}

		public override void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}



		
	}

}