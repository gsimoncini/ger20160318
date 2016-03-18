using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de MovimientosCaja.
	/// </summary>
	public class MovimientosCaja: IPersistentTask, ITask
	{
		#region clase auxiliar ItemsFiltros
		public class ItemsFiltros
		{
			public ItemsFiltros( string id, string name, bool select)
			{
				this._id = id;
				this._name = name;
				this._select = select;
			}
			private string _id = string.Empty;
			private string _name = string.Empty;
			private bool _select = true;
			public string Id
			{
				get { return _id ; }
				set { _id = value ; }
			}
			public string Descripcion
			{
				get { return _name;}
				set { _name = value ;}
			}
			public bool Sel
			{
				get { return _select ; }
				set { _select = value ; }
			}
		}

		#endregion
		#region clase auxiliar DetalleValorMovimiento
	
		public class DetalleValorMovimiento 
		{
			private Valor _valor;

			private string _idMovimientoDeCaja = string.Empty;
			
			public Valor Valor 
			{
				get {return _valor;}
				set {_valor = value;}
			}
			
			
			public int Signo
			{
				get{return _valor.Signo;}
				set{_valor.Signo = value;}
			}
			
			public string IdInstanciaCaja
			{
				get{return _valor.IdInstanciaCaja;}
				set{_valor.IdInstanciaCaja = value;}
			}

			public string IdValor
			{
				get {return _valor.IdValor;}
				set {_valor.IdValor = value;}
			}
			
			public string EstadoCheque
			{
				get{return _valor.IdEstado;}
				set{ _valor.IdEstado=value;}
			
			}
			public string IdTDCompTesoreria
			{
				get {return _valor.IdTDCompTesoreria;}
				set {_valor.IdTDCompTesoreria = value;}
			}
			
			public string Descripcion
			{
				get {return this.Descripcion;}
				set {this.Descripcion= value;}
			}
			
			public string Numero
			{
				get {return _valor.Numero;}
				set {_valor.Numero = value;}
			}
			
			public string Entidad
			{
				get {return _valor.Entidad;}
				set {_valor.Entidad = value;}
			}
			public DateTime FechaVencimiento
			{
				get {return _valor.FechaVencimiento;}
				set {_valor.FechaVencimiento = value;}
			}
			public DateTime Fecha
			{
				get {return _valor.Fecha;}
				set {_valor.Fecha = value;}
			}
			public decimal ValorOrigen
			{
				get {return this.ValorOrigen;}
				set {this.ValorOrigen = value;}
			}
			public decimal ValorDestino
			{
				get {return this.ValorDestino;}
				set {this.ValorDestino = value;}
			}
			
			public string Moneda
			{
				get {return _valor.Moneda;}
				set {_valor.Moneda = value;}
			}
			
			public string IdMoneda
			{
				get {return _valor.IdMoneda;}
				set {_valor.IdMoneda = value;}
			}
			
			public string IdCotizacionMoneda
			{
				get {return _valor.IdCotizacion;}
				set {_valor.IdCotizacion = value;}
			}

			public decimal Monto
			{
				get {return _valor.Monto;}
				set {_valor.Monto = value;}
			}
			public decimal MontoCotizado
			{
				get { return _valor.MontoCotizado;}
				set {_valor.MontoCotizado = value;}
			}

			public string Comprobante
			{
				get {return _valor.Comprobante;}
				set {_valor.Comprobante = value;}
			}

			public bool Agrupado
			{
				get{return _valor.Agrupado;}
				
			}

			public DetalleValorMovimiento ShallowClone()
			{
				return (DetalleValorMovimiento)this.MemberwiseClone();
			}

			public DatoAuxiliar DatoAuxiliar;

			public DetalleValorMovimiento()
			{
				_valor = new Valor();
			}

			public void BuildDatosAuxiliares()
			{
				if(this._valor != null)
					this._valor.LoadDatosAuxiliares();
			}
		}

		

		#endregion		
		#region calse auxiliar  DetallesValoresMovimientos
		public class DetallesValoresMovimientos: ArrayList, IEnumerator
		{
			public int Add(DetalleValorMovimiento item) 
			{
				return base.Add(item);
			}
			public override int Add(Object item) 
			{
				return base.Add((DetalleValorMovimiento) item);
			}
			public int IndexOf(string IdValor)
			{
				this.Reset();
				foreach (DetalleValorMovimiento item in this) 
				{
					this.MoveNext();					
					//if (item.IdValor.CompareTo(IdValor) != 0) 
					if (item.IdValor.Equals(IdValor))
					{
						return  _index;
					}
				}
				return -1;
			}			
			#region miembros de IEnumerable
			private int _index = -1;
			public void Reset() 
			{
				_index = -1;
			}
			public object Current 
			{
				get {return base[_index];}
			}
			public bool MoveNext() 
			{
				_index ++;
				return _index < this.Count;
			}
			#endregion
		}
			
		#endregion
		#region clase auxiliar ValoresVariablesAuxiliares
		/*public class ValoresVariablesAuxiliares: ArrayList 
		{
			public ValoresVariablesAuxiliares() 
			{
			}
			public int Add( string IdValor, string DescripcionVariable, string Valor)
			{
				return base.Add(new object[] {IdValor, DescripcionVariable, Valor});				
			}

		}
		*/
		#endregion

		#region Custom Members
	

		#region contructores
		public MovimientosCaja()
		{
				
		}
		#endregion

		#region variables
		//datos de la cabecera del comprobante
		private string _idMovimientoOrignal = string.Empty;
		private string _numero = string.Empty;
		private string _observaciones = string.Empty;
		private string _idCaja = string.Empty;
		private string _idTipo = string.Empty;
		private string _idSubTipo = string.Empty;
		private string _idComp = string.Empty;
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idValor = string.Empty;
		//private string _total = string.Empty;
		private decimal _uneTotal = 0;

		//datos del detalle
			
			
		private string _valorMoneda = string.Empty;
		private string _valorTDCompTesoreria = string.Empty;
		private decimal _valorTotal= 0;
		//datos de configuracion 
		private DataTable _filtroCajas = new DataTable();
		private DataTable _filtroTiposMovimientos = new DataTable();
		private ArrayList _valores = new ArrayList();
		
		private decimal _importeTotalMovimiento = 0;
			
		//datos para el commit
		private tfi_MovimientosDeCajaDataset dataMovimiento = new tfi_MovimientosDeCajaDataset();
		private tfi_MovimientoBancarioDataset dataMovimientoBancario=new tfi_MovimientoBancarioDataset();
		private tfi_MovimientosDeCajaAjustesDataset dataAjuste = new tfi_MovimientosDeCajaAjustesDataset();
		private tfi_PagosMovimientosCajasDataset dataPagosMovimientos = new tfi_PagosMovimientosCajasDataset();
		private tfi_ValoresExDataset dataValores = new tfi_ValoresExDataset();

		private tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow _rowMovEdic;

		DetallesValoresMovimientos  dValoresMovimientos = new DetallesValoresMovimientos(); 


		private bool _allowToValidateMovimientoYaAjustado = false;
		private bool _allowToValidateMovimientoEgreso = true;
		private string _generanMovimiento=string.Empty;


		private bool _allowAddValores = true;
		private bool _allowEditValores = true;
		private bool _allowDeleteValores = true;
		private bool _allowSearchValores = false;
			
		private DetalleValorMovimiento _detalleValorAgrupadoOrigen = null;

		private string _metodoDeComparacion = string.Empty;
		private string _tiposMovimientos = string.Empty;
		private string _subTiposMovimientos = string.Empty;

		#endregion
			
		#region Propiedades


		public DetalleValorMovimiento DetalleValorAgrupadoOrigen
		{
			get{return _detalleValorAgrupadoOrigen;}
			set{_detalleValorAgrupadoOrigen = value;}
		}
		public string Numero
		{
			set{_numero = value;}
			get{return _numero;}
		}
		public string Observaciones
		{
			set{_observaciones = value;}
			get{return _observaciones;}
		}

		private string GeneranMovimiento
		{
			get{return _generanMovimiento;}
			set{_generanMovimiento=value;}
		}
		/*public string Total
		{
			set{_total =value;}
			get{return _total;}
		}*/
		public string IdTipo
		{
			get { return _idTipo ; }
			set { _idTipo = value; }
		}
		public string IdSubTipo
		{
			get { return _idSubTipo ; }
			set { _idSubTipo = value; }
		}
		public string IdComp
		{
			get { return _idComp ; }
			set { _idComp = value; }
		}
		public string IdCaja
		{
			get { return _idCaja; }
			set {_idCaja = value ;}
		}
		public DateTime Fecha
		{
			get {return _fecha ; }
			set 
			{
				DateTime actual = mz.erp.businessrules.Sistema.DateTime.Now;
				_fecha = new DateTime(value.Year, value.Month,value.Day, actual.Hour, actual.Minute, actual.Second, actual.Millisecond);
			}
		}
		public DataTable FiltroCajas
		{
			get { return _filtroCajas ; }
			set { _filtroCajas = value ; }
		}
		public DataTable FiltroTiposMovimientos
		{
			get { return _filtroTiposMovimientos ; }
			set { _filtroTiposMovimientos = value ; }
		}
			
		public ArrayList Valores
		{
			get { return _valores ; }
			set { _valores = value; }
		}
		public string ValorMoneda
		{
			get { return _valorMoneda; }
			set { _valorMoneda = value ; }
		}
		public string ValorTDCompTesoreria
		{
			get { return _valorTDCompTesoreria; }
			set { _valorTDCompTesoreria = value ; }
		}
		public decimal ValorTotal
		{
			get { return _valorTotal; }
			set { _valorTotal = value ; }
		}
		public decimal UneTotal
		{
			get { return _uneTotal; }
			set { _uneTotal = value ; }
		}
		public string IdMovimientoOriginal
		{
			get { return _idMovimientoOrignal; }
			set { _idMovimientoOrignal = value ; }
		}
		public string IdValor
		{
			get { return _idValor; }
			set {_idValor = value ;}
		}
		public DetallesValoresMovimientos DValoresMovimientos
		{
			get{return dValoresMovimientos;}
		}

		public void ValorDeleted()
		{
			RecalcularImporteTotalMovimiento();
		}

		public bool Contains(Valor valor)
		{
			foreach(DetalleValorMovimiento dvm in this.DValoresMovimientos)
			{
				if(dvm.Valor.State.ToUpper().Equals("EDIT") && dvm.Valor.IdValor.Equals(valor.IdValor))
					return true;
			}
			return false;
		}
			
		
		public void AddValor(Valor valor)
		{
			DetalleValorMovimiento dvm = new DetalleValorMovimiento();
			dvm.Valor = valor;
			valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(RecalcularImporteTotalMovimiento);
			dvm.Comprobante = Convert.ToString(mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(dvm.IdTDCompTesoreria)["Descripcion"]);
			if (dvm.Valor.IdEntidad != null && dvm.Valor.IdEntidad != "" )
				dvm.Entidad = Convert.ToString(mz.erp.businessrules.tfi_Entidades.GetByPk(dvm.Valor.IdEntidad)["Descripcion"]);
			dValoresMovimientos.Add( dvm );
			RecalcularImporteTotalMovimiento();
		}

		public string LeyendaFormulario
		{
			get
			{
				string _nombreProceso = _process.Process.ProcessName;
				string _nombreTarea = ((ITask)this).GetTaskName();
				string _leyenda = Variables.GetValueString("Momentos."+_nombreTarea+"."+_nombreProceso+".LeyendaFormulario");
				if (_leyenda ==null || _leyenda == "")
					return _nombreProceso+" "+_nombreTarea;
				return _leyenda;
			}
		}

		
		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_process.Process.ProcessName,_task,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		public string MetodoDeComparacion
		{
			get{return _metodoDeComparacion;}
			set{_metodoDeComparacion=value;}
		}

		public string TiposMovimientos
		{
			get{return _tiposMovimientos;}
			set{_tiposMovimientos=value;}
		}
		
		public string SubTiposMovimientos
		{
			get{return _subTiposMovimientos;}
			set{_subTiposMovimientos=value;}
		}
		

		#endregion

		#region allow
			
			
		public bool AllowEditCaja
		{
			get 
			{ 
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return _filtroCajas.Rows.Count > 1;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoDepositarCuentaCorriente"))
					return false;
				else return (this._filtroCajas.Rows.Count > 0) ; 
			}
		}
		public bool AllowEditTipoDeMovimiento
		{
			get 
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return true;
				if(this._process.Process.ProcessName.Equals("ProcesoDepositarCuentaCorriente"))
					return true;
				else return (this._filtroTiposMovimientos.Rows.Count > 1);
			}
		}
		public bool AllowEditSubTipoDeMovimiento
		{
			get 
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false; 
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				else return true;
			}
		}
		public bool AllowEditFecha
		{
			get { return Variables.GetValueBool(this._process.Process.ProcessName, this._task, "AllowEditFecha"); }
		}
		public bool AllowEditObservaciones
		{
			get 
			{ 

				return Variables.GetValueBool(this._process.Process.ProcessName, this._task, "Editar.Observaciones"); 
				/*
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return true;
				else return true; 
				*/
			} 
		}
		public bool LayoutEditTypeValores
		{
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return true;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false; 
				else return true; 
			}
		}

		public bool AllowEditValores
		{
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return _allowEditValores;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoDepositarCuentaCorriente"))
					return false;
				else return true; 
			}
		}
		public bool AllowEditUneTotal
		{
			get
			{
				return false;
			}
		}	
		public bool AllowEditNumero
		{
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return true;
				else return true; 
			}
		}
		public bool AllowEditTipoComprobante
		{
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
					return false;
				if (this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
					return true;
				else return true; 
			}
		}

		public bool AllowAddValores
		{
			get
			{
				bool ok = true;
				if(this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					ok = _detalleValorAgrupadoOrigen != null && IdValidForAddValoresAgrupados();
				return _allowAddValores && ok;
			}
		}

		private bool IdValidForAddValoresAgrupados()
		{
			decimal monto = Math.Round(this.TotalValoresAgrupadoOrigen(),2);
			decimal aux = Math.Round(this.ValoresAjustados(),2);
			/*
			foreach(DetalleValorMovimiento dvm in dValoresMovimientos)
			{
				if((dvm.IdTDCompTesoreria != null && dvm.IdTDCompTesoreria.Equals(_detalleValorAgrupadoOrigen.IdTDCompTesoreria))
					&& (dvm.IdMoneda != null && dvm.IdMoneda.Equals(_detalleValorAgrupadoOrigen.IdMoneda)))
					aux = aux + dvm.Monto;
			}
			*/
			return aux < monto;
		}	

		public bool AllowDeleteValores
		{
			get{return _allowDeleteValores;}
		}

		public bool AllowSearchValores
		{
			get{return _allowSearchValores;}
		}

		public bool AllowAddValoresAgrupados
		{
			get
			{
				return !this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaEgreso");
			}
		}


		#region edicion de ventana de valores
		public bool ValorAllowEditIdTDCompTesoreria
		{	
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				else return true; 
			}
		}
		public bool ValorIdTDCompTesoreriaReadOnly
		{	
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return true;
				else return false; 
			}
		}
		public bool ValorAllowEditIdMoneda
		{	
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return false;
				else return true; 
			}
		}
		public bool ValorIdMonedaReadOnly
		{	
			get
			{
				if (this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
					return true;
				else return false; 
			}
		}

		#endregion


		#endregion

		#region build
			
		
		/// <summary>
		/// Genera los tipos de movimientos que esten definidos en el subconjunto rango.
		/// Si el conjunto viene vacio obtiene todos aquellos movimientos segun el signo definido para la tarea
		/// </summary>
		/// <param name="_rango"></param>
		/// <returns></returns>
		/*private ArrayList build_ArrayTipos(string[] _rango)
		{
			ArrayList _arrayTipos = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetTiposDeMovimientos( null,_signo);
			if (_rango.Length>0)
			{
				for(int i=0;i<_rango.Length;i++)
				{
					if (_hash.ContainsKey( Convert.ToString( _rango[i] ) ))
					{
						_arrayTipos.Add( new ItemsFiltros(Convert.ToString(_rango[i]), Convert.ToString(_hash[_rango[i]]), true ) );
					}
				}
			}
			else
			{
				foreach(string _key in _hash.Keys)
				{
					_arrayTipos.Add( new ItemsFiltros(Convert.ToString(_key), Convert.ToString(_hash[_key]), true ) );
				}
			}
			return _arrayTipos;
		}

		private ArrayList build_ArrayCajas(ArrayList _rango)
		{
			ArrayList _arrayCajas = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetListHashTable();
			foreach( string _idCaja in _rango )
			{
				if (_hash.ContainsKey( Convert.ToString( _idCaja ) ))
				{
					_arrayCajas.Add( new ItemsFiltros(_idCaja, Convert.ToString(_hash[_idCaja]), true) );
				}
			}
			return _arrayCajas;
		}

*/
		#endregion

		#region signo
		private System.Int16 _signo = System.Int16.MinValue;					
		private void DeterminarSigno()
		{
			switch ( this._task )
			{
				case "RegistrarMovimientosDeIngreso":
				{
					_signo = 1;
					break;
				}
				case "RegistrarMovimientosDeEgreso":
				{
					_signo = -1;
					break;
				}
				default:
				{
					_signo = System.Int16.MinValue;
					break;
				}
			}
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso"))
			{
				_signo = 1;
			}
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaEgreso"))
			{
				_signo = -1;
			}
		}
		private void ObtenerSignoMovimiento()
		{
			tsy_TiposMovimientosDataset.tsy_TiposMovimientosRow _row = tsy_TiposMovimientos.GetByPk(_idTipo);	
			_signo = Convert.ToInt16(_row["signo"]) ;
		}
		#endregion


		#endregion


		private mz.erp.commontypes.SentenciasReplicacion _replication = new mz.erp.commontypes.SentenciasReplicacion();
		

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		private ArrayList _Arraydata = new ArrayList();
		private TaskCollectionData _taskCollectionData = new TaskCollectionData();
		
		
		
		public ArrayList GetDataList()
		{
			return _Arraydata;
		}
		
		public TaskCollectionData GetData()
		{	
			return _taskCollectionData;
		}



		#region metodos privados para cargar datos en las ROWS
			private void CargarDatosMovimiento(tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMov)
			{
				rowMov.IdInstanciaCaja = this._idCaja;
				rowMov.IdTipoDeMovimiento = this._idTipo;			
				rowMov.IdSubTipoMovimiento = this._idSubTipo;			
				rowMov.TipoComprobante = this._idComp;
				rowMov.Numero = this._numero;
				rowMov.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
				rowMov.IdResponsable = this.IdUsuario;		
				rowMov.IdAceptacion = null;
				rowMov.Observaciones = this._observaciones;	
				rowMov.Fecha = this._fecha;
			}

			private void CargarDatosPago(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowPago, string IdValor)
			{
				rowPago.IdValor = IdValor;
				rowPago.IdInstanciaCaja = this.IdCaja; 
				rowPago.IdTipoDeMovimiento = this.IdTipo; 
				rowPago.Numero = this._numero;
			}
		#endregion


		public void Commit()
		{
			#region MOVIMIENTO DE AJUSTE
			if(this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
			{	
				if(dValoresMovimientos.Count > 0)
				{
					BeforeCommit();
								
					//cargo los datos del movimiento de ajuste							
					tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMovAjuste = dataMovimiento.tfi_MovimientosDeCaja.Newtfi_MovimientosDeCajaRow();
					rowMovAjuste = tfi_MovimientosDeCaja.SetRowDefaultValues(rowMovAjuste);
					CargarDatosMovimiento(rowMovAjuste);							
					
					decimal Total = 0;
					int Signo = ObtenerSignoDeAjuste(); 
					
					//cargo los pagos para poder relacionar con los valores
					foreach ( DetalleValorMovimiento item in dValoresMovimientos)
					{
						item.Valor.Signo = Signo;
						if(item.Agrupado)
						{
							item.Valor.IdInstanciaCaja = this._idCaja;
							item.Valor.Commit(dataValores);
						}
						else 
						{
							if(this._signo == -1)
							{
								item.Valor.IdInstanciaCaja = string.Empty;
								item.Valor.Signo = 0;
							}
							if(this._signo == 1)
								item.Valor.IdInstanciaCaja = this._idCaja;
							item.Valor.Update(dataValores);
						}
						tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP = dataPagosMovimientos.tfi_PagosMovimientosCajas.Newtfi_PagosMovimientosCajasRow();
						rowP = tfi_PagosMovimientosCajas.SetRowDefaultValues(rowP);				
						CargarDatosPago(rowP, item.IdValor);
						dataPagosMovimientos.tfi_PagosMovimientosCajas.Addtfi_PagosMovimientosCajasRow(rowP);

						Total = Total + item.Monto;
					}	
					
					#region cargo el ajuste en la tabla tfi_movimientodDeCajaAjustes
					
					tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow rowAjuste = dataAjuste.tfi_MovimientosDeCajaAjustes.Newtfi_MovimientosDeCajaAjustesRow();
					rowAjuste = tfi_MovimientosDeCajaAjustes.SetRowDefaultValues(rowAjuste);
					rowAjuste.IdMovimientoDeCaja = this.IdMovimientoOriginal;
					rowAjuste.IdMovimientoDeCajaAjuste = "1";//este id despues se tapa con otro
					dataAjuste.tfi_MovimientosDeCajaAjustes.Addtfi_MovimientosDeCajaAjustesRow(rowAjuste);
					
					#endregion
				
					rowMovAjuste.Total =  Signo * Total;
					rowMovAjuste.IdCotizacionCierre = null;
					
					dataMovimiento.tfi_MovimientosDeCaja.Addtfi_MovimientosDeCajaRow(rowMovAjuste);

				}
			}
			#endregion

			#region MODIFICACIONES "EDICION" DE MOVIMIENTOS
			if(this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
			{	
				_rowMovEdic = tfi_MovimientosDeCaja.GetByPk(_idMovimientoOrignal);
				_rowMovEdic["IdTipoDeMovimiento"] = this._idTipo;
				_rowMovEdic["IdSubTipoMovimiento"] = this._idSubTipo;
				_rowMovEdic["TipoComprobante"] = this._idComp;
				_rowMovEdic["Numero"] = this._numero;
				_rowMovEdic["Observaciones"] = this._observaciones;
				_rowMovEdic["IdResponsable"]=this.IdUsuario;
				dataMovimiento.tfi_MovimientosDeCaja.ImportRow(_rowMovEdic);
				//actualizo los valores de los ajustes realizados sobre el ajuste q se edito
				tfi_MovimientosDeCajaAjustesDataset dataMovCascada = tfi_MovimientosDeCajaAjustes.GetList(_idMovimientoOrignal, null);
				foreach(tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row in dataMovCascada.tfi_MovimientosDeCajaAjustes.Rows)
				{
					//obtengo el movimiento correspondiente al ajuste en la tabla de movimientos
					tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMov =  tfi_MovimientosDeCaja.GetByPk(Convert.ToString(row["IdMovimientoDeCajaAjuste"]));
					rowMov["IdTipoDeMovimiento"] = this._idTipo;
					rowMov["IdSubTipoMovimiento"] = this._idSubTipo;
					rowMov["TipoComprobante"] = this._idComp;
					rowMov["Numero"] = this._numero;
					rowMov["Observaciones"] = "AJUSTE " + this._observaciones;
					dataMovimiento.tfi_MovimientosDeCaja.ImportRow(rowMov);
				}


				tfi_PagosMovimientosCajasDataset dataPagos = tfi_PagosMovimientosCajas.GetList(_idMovimientoOrignal,null);
				foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row in dataPagos.tfi_PagosMovimientosCajas.Rows)
				{
					row["IdTipoDeMovimiento"] = this._idTipo;
					dataPagosMovimientos.tfi_PagosMovimientosCajas.ImportRow(row);
				}
				
			}
			#endregion

			#region MOVIMIENTO DE EGRESO / INGRESO
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaEgreso") ||this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso")||this._process.Process.ProcessName.Equals("ProcesoDepositarCuentaCorriente"))
			{
				if(dValoresMovimientos.Count > 0)
				{
					//cargo los datos del movimiento nuevo
					tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMov = dataMovimiento.tfi_MovimientosDeCaja.Newtfi_MovimientosDeCajaRow();
					rowMov = tfi_MovimientosDeCaja.SetRowDefaultValues(rowMov);
					CargarDatosMovimiento(rowMov);							
					
					decimal Total = 0;
									
					//cargo los pagos para poder relacionar con los valores
					foreach ( DetalleValorMovimiento item in dValoresMovimientos)
					{
						

						item.Valor.Signo = this._signo;
						item.Valor.IdInstanciaCaja = this._idCaja;
						if(item.Agrupado)
						{
							item.Valor.Commit(dataValores);
						}
						else 
						{
							
							if(item.Valor.State.ToUpper().Equals("NEW"))
							{
								item.Valor.Commit(dataValores);
							}
							else
							{
								if((item.Valor.SignoDB + this._signo) == 0)
								{
									item.Valor.IdInstanciaCaja = string.Empty;
									item.Valor.Signo = 0;
								}
								
								else
								//Es un cheque en cartera y el signo del movimiento es un egreso
								if(item.Valor.IdEstado.Equals(item.Valor.EnCartera)&& this._signo==-1)
								{
									item.Valor.IdInstanciaCaja = string.Empty;
									item.Valor.Signo = 0;
								}
							{
							}
								item.Valor.Update(dataValores);


							}
							#region Movimiento Bancario
							/*
							if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso"))
							{
								ArrayList _movimiento=Util.Parse(this.GeneranMovimiento,',');						
								string idcomptesoreria=item.Valor.IdTDCompTesoreria;
								string idValor=item.Valor.IdValor;
								string nroCheque=item.Valor.Numero;
								decimal total=item.Valor.Monto;
								
								tfi_CuentaBancariaDataset cuenta=tfi_CuentaBancaria.GetList(string.Empty,string.Empty,string.Empty,item.Valor.DatoAuxiliar.CuentaBancaria,string.Empty);
								string idCuentaBancaria=Convert.ToString(cuenta.Tables[0].Rows[0]["IdCuenta"]);
								
								//Si el comprobante de tesoreria genera movimiento bancario en el ingreso a caja
								if(_movimiento.Contains(idcomptesoreria))
								{
									tfi_TDCompTesoreria_TipoMovimientoDataset result=tfi_TDCompTesoreria_TipoMovimiento.GetList(string.Empty,idcomptesoreria);
									//Por cada movimiento asociado al comprobante de tesoreria genero el movimiento
									foreach (tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow tipo in result.Tables[0].Rows)
									{								
										string tipoMovimiento=tipo.IdTipoMovimiento;
										MovimientoBancario mov=new MovimientoBancario(string.Empty,tipoMovimiento,idCuentaBancaria, idValor, nroCheque,total, DateTime.Now,DateTime.MinValue);
										mov.Data=this.dataMovimientoBancario;
										mov.Commit();
										dataMovimientoBancario=mov.Data;
									}
								}
							}
							*/
							
						#endregion
							/*
							if(this._signo == -1)
							{
								item.Valor.IdInstanciaCaja = string.Empty;
								item.Valor.Update(dataValores);
							}
							else
								if(this._signo == 1)
								{
								
									item.Valor.IdInstanciaCaja = this._idCaja;
									item.Valor.Commit(dataValores);
								}
							*/
							
						}
						
						tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP = dataPagosMovimientos.tfi_PagosMovimientosCajas.Newtfi_PagosMovimientosCajasRow();
						rowP = tfi_PagosMovimientosCajas.SetRowDefaultValues(rowP);				
						CargarDatosPago(rowP, item.IdValor);
						dataPagosMovimientos.tfi_PagosMovimientosCajas.Addtfi_PagosMovimientosCajasRow(rowP);

						Total = Total + item.Monto;
					}	
					
					rowMov.Total =  this._signo * Total;
					rowMov.IdCotizacionCierre = null;
					dataMovimiento.tfi_MovimientosDeCaja.Addtfi_MovimientosDeCajaRow(rowMov);
				}
			}
			#endregion

		}


		

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			
				#region MOVIMIENTO DE AJUSTE
				if(this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
				{
					if (this.dataMovimiento.tfi_MovimientosDeCaja.Count != 0)
					{
						tfi_ValoresEx.Update(dataValores , IdTransaction, _replication);
						_replication = GenerateReplication();
						//guardo el movimiento nuevo
						tfi_MovimientosDeCaja.Update(dataMovimiento, IdTransaction, _replication);					
					
						string _IdMovimiento= Convert.ToString(dataMovimiento.tfi_MovimientosDeCaja.Rows[0]["IdMovimiento"]);
										
						int pos = 0;//para saber de q row de valores leer el id
						foreach (DataRow row in dataPagosMovimientos.tfi_PagosMovimientosCajas.Rows) 
						{	
							//guardo en los pagos, el id del movimiento correspondiente
							row["IdMovimiento"] = _IdMovimiento;
							row["IdValor"] = Convert.ToString(dataValores.Tables[0].Rows[pos]["IdValor"]);
							pos++;
						}
						foreach (DataRow row2 in dataAjuste.tfi_MovimientosDeCajaAjustes.Rows)
						{
							//guardo en la columna que referencia al ajuste q ajusta un movimiento, el ajuste q acabo de crear
							row2["IdMovimientoDeCajaAjuste"] = _IdMovimiento;
						}
						mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(dataPagosMovimientos.Tables[0], IdTransaction, _replication);			
						mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.Update(dataAjuste.Tables[0], IdTransaction, _replication);
					}
				}
				#endregion
		
				#region MODIFICACIONES "EDICION" DE MOVIMIENTOS
		
				if(this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
				{
					GenerateReplication();
					mz.erp.dataaccess.tfi_MovimientosDeCaja.Update(dataMovimiento.Tables[0], IdTransaction, _replication);
					mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.Update(dataAjuste.Tables[0], IdTransaction, _replication);

					mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(dataPagosMovimientos.tfi_PagosMovimientosCajas, IdTransaction, _replication);			

				}
			
				#endregion
			
				#region MOVIMIENTO DE EGRESO / INGRESO
				if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaEgreso") ||this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso")||this._process.Process.ProcessName.Equals("ProcesoDepositarCuentaCorriente"))
				{
					if (this.dataMovimiento.tfi_MovimientosDeCaja.Count != 0)
					{
						tfi_ValoresEx.Update(dataValores , IdTransaction , _replication);
						_replication = GenerateReplication();
						//guardo el movimiento nuevo
						tfi_MovimientosDeCaja.Update(dataMovimiento, IdTransaction, _replication);					
						string _IdMovimiento= Convert.ToString(dataMovimiento.tfi_MovimientosDeCaja.Rows[0]["IdMovimiento"]);
						int pos = 0;//para saber de q row de valores leer el id
						foreach (DataRow row in dataPagosMovimientos.tfi_PagosMovimientosCajas.Rows) 
						{	
							//guardo en los pagos, el id del movimiento correspondiente
							row["IdMovimiento"] = _IdMovimiento;
							row["IdValor"] = Convert.ToString(dataValores.Tables[0].Rows[pos]["IdValor"]);
							pos++;
						}					
						mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(dataPagosMovimientos.Tables[0], IdTransaction, _replication);
					}
				}
			//Si es un ingreso y el comprobante tesoreria del valor genera movimiento bancario=> hacemos el movimiento bancario
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso")){
				foreach (tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow movBanc in dataMovimientoBancario.Tables[0].Rows){
					int pos=0;bool ok=false;
					while (pos<dataValores.Tables[0].Rows.Count && !ok)
					{
						string valorViejo=Convert.ToString(dataValores.Tables[0].Rows[pos]["OldIdValor"]);
						if (valorViejo.Equals(movBanc.IdValor))
						{	ok=true;
							movBanc.IdValor=Convert.ToString(dataValores.Tables[0].Rows[pos]["IdValor"]);
						}
						pos++;
					}
					}
				mz.erp.dataaccess.tfi_MovimientoBancario.Update(dataMovimientoBancario.Tables[0],IdTransaction);
			}
				#endregion
			
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		private void BeforeCommit() 
		{
			//Recorre los valores a tranferrir
			string IdValorNuevo;
			foreach (DetalleValorMovimiento valorATransferir in this.Valores)
			{
				if (valorATransferir.IdValor == null || valorATransferir.IdValor == String.Empty) 
				{
					tfi_ValoresDataset data = new tfi_ValoresDataset();
					tfi_ValoresDataset.tfi_ValoresRow row = data.tfi_Valores.Newtfi_ValoresRow();
					row = tfi_Valores.SetRowDefaultValues(row);
					row.IdTDCompTesoreria = valorATransferir.IdTDCompTesoreria;
					row.Valor = valorATransferir.ValorDestino;
					row.IdMoneda = valorATransferir.IdMoneda;
					row.IdCotizacionMoneda = valorATransferir.IdCotizacionMoneda;
					data.tfi_Valores.Addtfi_ValoresRow(row);
					tfi_Valores.Update(data);
					IdValorNuevo = Convert.ToString(data.tfi_Valores.Rows[0]["IdValor"]);
					valorATransferir.IdValor = IdValorNuevo;
				}			
			}					
		}


		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			
			_replication.IdConexion = Security.IdConexion;
			_replication.SucGeneradora = Security.IdSucursal;
			_replication.Destino = null;
			_replication.VersionBD = null;
			_replication.NombreTabla = "dataaccess.tfi_movimientosdecaja";
			return _replication;
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación MovimientosCaja.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación MovimientosCaja.GetHasSaved
			return false;
		}

		#endregion

		#region Miembros de ITask

		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _process;
		private string _task;

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler IdCajaChanged;
		public event System.EventHandler IdUsuarioHasChanged;
		public event System.EventHandler OnTaskAfterPrevious;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskBeforeExecute;

		

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación MovimientosCaja.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			ITask tareaprevia = (ITask)sender;
			if (tareaprevia.GetTaskName().CompareTo("DepositarCheques") ==0 ){
					DepositoBancario consulta = (DepositoBancario)sender;
					//dValoresMovimientos
				Movimiento mov=new Movimiento();
				//Por cada valor seleccionado en la grilla genera el detalle movimiento de caja
				dValoresMovimientos.Clear(); //para q cuando haga anterior y siguiente la coleccion no tenga datos
				_signo = -1;
				_fecha = mz.erp.businessrules.Sistema.DateTime.Now;
				decimal suma = 0;
				foreach(DataRowView resul in consulta.Data)
				{
					string IdValor = Convert.ToString(resul["IdValor"]);
					_idCaja= Convert.ToString(resul["IdInstanciaCaja"]);
					mov.IdInstanciaCaja=_idCaja;
					tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(IdValor);
					DetalleValorMovimiento vm = new DetalleValorMovimiento();
					vm.IdValor = Convert.ToString(rowValores["IdValor"]);
					vm.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
					vm.Comprobante = Convert.ToString((tfi_TDCompTesoreria.GetByPk(vm.IdTDCompTesoreria))["Descripcion"]);
					vm.Numero = Convert.ToString(rowValores["Numero"]);
					vm.EstadoCheque=Convert.ToString(rowValores["IdEstadoCheque"]);
					string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
					if (_idEntidad != "")
						vm.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
					vm.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
					vm.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
					vm.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
					vm.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
					vm.Monto = Convert.ToDecimal(rowValores["Valor"]);
					dValoresMovimientos.Add(vm);
					suma = suma + vm.MontoCotizado;
				}
				//_uneTotal = suma;
				

			}
			if (tareaprevia.GetTaskName().CompareTo("ConsultarMovimientosDeCaja") ==0 )
			{
				ConsultasDeCaja consulta = (ConsultasDeCaja)sender;
				
				#region PROCESO AJUSTAR MOVIMIETNO CAJA
				if(this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
				{
					Movimiento mov = consulta.GetMovimientoDeCajaFromSelectedRow();
					_idValor = mov.IdValor;
					_idMovimientoOrignal = mov.IdMovimientoOriginal;
					_numero = mov.Numero;
					_idTipo = mov.IdTipoDeMovimiento;
					_signo = ObtenerSignoDeAjuste();
					_fecha = mz.erp.businessrules.Sistema.DateTime.Now;
					if (_signo == 1)
						_observaciones = "AJUSTE (" + mov.Observaciones + " )";		
					else 
						_observaciones = "AJUSTE (" + mov.Observaciones + " )";		
					_idSubTipo = mov.IdSubTipoMovimiento;
					_idCaja = mov.IdInstanciaCaja;
					_idComp = mov.TipoComprobante;
					_valorMoneda = mov.ValorMoneda; 
					_valorTDCompTesoreria = mov.ValorTDCompTesoreria;
					_valorTotal = mov.ValorTotal; //es el valor del movimiento que se quiere ajustar
					_uneTotal = 0;
					dValoresMovimientos.Clear();
                    tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(_idValor);
					tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow rowCompTesoreria = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(Convert.ToString(rowValores["IdTDCompTesoreria"]));
                    bool agrupado = Convert.ToBoolean(rowCompTesoreria["Agrupado"]);
					if(!agrupado)
					{
						DetalleValorMovimiento vm = new DetalleValorMovimiento();
						vm.IdValor = Convert.ToString(rowValores["IdValor"]);
						vm.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
						vm.Comprobante = Convert.ToString(rowCompTesoreria["Descripcion"]);
						vm.Numero = Convert.ToString(rowValores["Numero"]);
						string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
						if (_idEntidad != "")
							vm.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
						vm.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
						vm.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
						vm.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
						vm.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
						vm.EstadoCheque=Convert.ToString(rowValores["IdEstadoCheque"]);
						vm.Monto = Convert.ToDecimal(rowValores["Valor"]);
						vm.BuildDatosAuxiliares();
						dValoresMovimientos.Add(vm);
						_uneTotal = vm.MontoCotizado;
						_allowAddValores = false;
						_allowEditValores = false;
						_allowDeleteValores = false;
					}
					else
					{
						_detalleValorAgrupadoOrigen = new DetalleValorMovimiento();
						_detalleValorAgrupadoOrigen.IdValor = Convert.ToString(rowValores["IdValor"]);
						_detalleValorAgrupadoOrigen.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
						_detalleValorAgrupadoOrigen.Comprobante = Convert.ToString(rowCompTesoreria["Descripcion"]);
						_detalleValorAgrupadoOrigen.Numero = Convert.ToString(rowValores["Numero"]);
						string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
						if (_idEntidad != "")
							_detalleValorAgrupadoOrigen.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
						_detalleValorAgrupadoOrigen.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
						_detalleValorAgrupadoOrigen.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
						_detalleValorAgrupadoOrigen.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
						_detalleValorAgrupadoOrigen.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
						_detalleValorAgrupadoOrigen.Monto = Convert.ToDecimal(rowValores["Valor"]);
						_allowAddValores = true;
						_allowEditValores = true;
						_allowDeleteValores = true;
						
					}
					
					if (this.ObjectHasChanged != null)
					{
						this.ObjectHasChanged(null,new System.EventArgs());
					}		
				}
				#endregion
	
				#region PROCESO EDITAR MOVIMIENTO CAJA
				if(this._process.Process.ProcessName.Equals("ProcesoEditarMovimientoCaja"))
				{
					Movimiento mov = consulta.GetMovimientoDeCaja();
					_idValor = mov.IdValor;
					_idMovimientoOrignal = mov.IdMovimientoOriginal;
					_fecha = Convert.ToDateTime(mov.Fecha);
					_numero = Convert.ToString(mov.Numero);
					_idTipo = mov.IdTipoDeMovimiento;
					ObtenerSignoMovimiento(); //en la var _signo deje el valor de signo que se corresponde con el tipo de movimiento
					//German 20091029
                    build_DataTableTiposMovimientos();
					//Fin German 20091029
					_observaciones = mov.Observaciones;		
					_idSubTipo = mov.IdSubTipoMovimiento;
					_idCaja = mov.IdInstanciaCaja;
					_idComp = mov.TipoComprobante;
					_numero = mov.Numero;
					_allowAddValores = false;
					_allowEditValores = false;
					_allowDeleteValores = false;
				
										
					//la relacion con los id valores la saco de tfi_PagosMovimientosCajas
					//en la tabla de tfiValores tengo el monto de cada valor y cada valor propiamente dicho
					decimal suma = 0;
					dValoresMovimientos.Clear(); //para q cuando haga anterior y siguiente la coleccion no tenga datos
					tfi_PagosMovimientosCajasDataset dataPagosList = tfi_PagosMovimientosCajas.GetList(_idMovimientoOrignal, null);
					foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row in dataPagosList.tfi_PagosMovimientosCajas.Rows)
					{
						tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(Convert.ToString(row["IdValor"]));
						DetalleValorMovimiento vm = new DetalleValorMovimiento();
						vm.IdValor = Convert.ToString(rowValores["IdValor"]);
						vm.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
						vm.Comprobante = Convert.ToString((tfi_TDCompTesoreria.GetByPk(vm.IdTDCompTesoreria))["Descripcion"]);
						vm.Numero = Convert.ToString(rowValores["Numero"]);
						string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
						if (_idEntidad != "")
							vm.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
						vm.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
						vm.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
						vm.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
						vm.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
						vm.EstadoCheque=Convert.ToString(rowValores["IdEstadoCheque"]);
						vm.Monto = Convert.ToDecimal(rowValores["Valor"]);
						dValoresMovimientos.Add(vm);
						suma = suma + vm.MontoCotizado;
					}
					_uneTotal = suma;
				}	
				#endregion	
			}


		}
	
		private decimal GetDesdeComprobanteDetallePago(string idMovOriginal)
		{
			decimal suma = 0;
			tsa_ComprobanteDetalleDePagosDataset dataPagosList = tsa_ComprobanteDetalleDePagos.GetList(null, null, idMovOriginal, null, decimal.MinValue);
			foreach(tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row in dataPagosList.tsa_ComprobanteDetalleDePagos.Rows)
			{
				tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(Convert.ToString(row["IdValor"]));
				DetalleValorMovimiento vm = new DetalleValorMovimiento();
				vm.IdValor = Convert.ToString(rowValores["IdValor"]);
				vm.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
				vm.Comprobante = Convert.ToString((tfi_TDCompTesoreria.GetByPk(vm.IdTDCompTesoreria))["Descripcion"]);
				vm.Numero = Convert.ToString(rowValores["Numero"]);
				string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
				if (_idEntidad != "")
					vm.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
				vm.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
				vm.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
				vm.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
				vm.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
				vm.Monto = Convert.ToDecimal(rowValores["Valor"]);
				dValoresMovimientos.Add(vm);
				suma = suma + vm.MontoCotizado;
			}
			return suma;
		}

		private decimal GetDesdePagosMovimientosCajas(string idMovOriginal)
		{
			decimal suma = 0;
			tfi_PagosMovimientosCajasDataset dataPagosList = tfi_PagosMovimientosCajas.GetList(idMovOriginal, null);
			foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row in dataPagosList.tfi_PagosMovimientosCajas.Rows)
			{
				tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(Convert.ToString(row["IdValor"]));
				
				DetalleValorMovimiento vm = new DetalleValorMovimiento();
				vm.IdValor = Convert.ToString(rowValores["IdValor"]);
				vm.IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
				vm.Comprobante = Convert.ToString((tfi_TDCompTesoreria.GetByPk(vm.IdTDCompTesoreria))["Descripcion"]);
				vm.Numero = Convert.ToString(rowValores["Numero"]);
				string _idEntidad =  Convert.ToString(rowValores["IdEntidad"]);
				if (_idEntidad != "")
					vm.Entidad = Convert.ToString((tfi_Entidades.GetByPk(_idEntidad))["Descripcion"]);
				vm.Fecha = Convert.ToDateTime(rowValores["Fecha"]);
				vm.FechaVencimiento = Convert.ToDateTime(rowValores["FechaVencimiento"]);
				vm.IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
				vm.IdCotizacionMoneda = Convert.ToString(rowValores["IdCotizacionMoneda"]);
				vm.Monto = Convert.ToDecimal(rowValores["Valor"]);
				dValoresMovimientos.Add(vm);
				suma = suma + vm.MontoCotizado;
			}
			return suma;
		}



		private short ObtenerSignoDeAjuste()
		{
			short aux = 0 ;
			mz.erp.commontypes.data.tsy_TiposMovimientosDataset data = tsy_TiposMovimientos.GetList(_idTipo, null);
			foreach (System.Data.DataRow _row in data.tsy_TiposMovimientos.Rows)
			{
				if (Convert.ToString(_row["Signo"]) == "-1")
					return 1;
				else return -1;
			}
			return aux;
		}

		private string ObtenerCaption(string value)
		{
			if (value != "")
			{
				switch (value)
				{
					case "Fact.A":
						return "Fact. A";
						break;
					case "Fact.B":
						return "Fact. B";
						break;
					case "Fact.C":
						return "Fact. C";
						break;
					case "Ticket.A":
						return "Ticket A";
						break;
					case "Ticket":
						return "Ticket";
						break;
					case "Recibo":
						return "Recibo";
						break;
					case "No":
						return "No/I";
						break;
					default: return "No";
						break;
				}
			}	
			else return "No";
		}

		private string ObtenerValue(string comp)
		{
			if (comp != "")
			{
				switch (comp)
				{
					case "Fact. A":
						return "Fact.A";
						break;
					case "Fact. B":
						return "Fact.B";
						break;
					case "Fact. C":
						return "Fact.C";
						break;
					case "Ticket A":
						return "Ticket.A";
						break;
					case "Ticket":
						return "Ticket";
						break;
					case "Recibo":
						return "Recibo";
						break;
					case "No/I":
						return "No";
						break;
					default: return "No";
						break;
				}
			}	
			else return "No";
		}

		
		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación MovimientosCaja.ListenerBeforeExecuteDependentTask
		}

	
		public void Init()
		{
			DeterminarSigno();
			//_filtroTiposMovimientos = (DataTable) tsy_TiposMovimientos.GetListPorSigno(Convert.ToString(_signo)).tsy_TiposMovimientos;
			this.build_DataTableTiposMovimientos();
			if (_filtroTiposMovimientos.Rows.Count > 0)
			{
				IdTipo = Convert.ToString(_filtroTiposMovimientos.Rows[0]["IdtipoMovimiento"]);
			}
			
			_filtroCajas = tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0];
			if (_filtroCajas.Rows.Count > 0)
			{
				IdCaja = Convert.ToString(_filtroCajas.Rows[0]["IdCaja"]);
			}
			_idComp = "No";
			_valorTDCompTesoreria = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+this._process.Process.ProcessName+".TDCompTesoreriaDefault");
			_valorMoneda = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+this._process.Process.ProcessName+".MonedaOrigenDefault");
			_allowToValidateMovimientoYaAjustado = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(), "ValidarMovimientosYaAjustados");
			_allowToValidateMovimientoEgreso = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(), "ValidarMovimientosDeEgreso", _allowToValidateMovimientoEgreso);
			//Variable para ver q comprobantes de tesoria genera movimiento
			_generanMovimiento = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+this._process.Process.ProcessName+".ListaComprobantesGeneranMovimiento");
			_allowSearchValores = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(), "PermiteBuscarValores");
			//GERMAN: deberian aparecer solo los usuarios q tengan instancias de caja asociadas.
			_usuarios=sy_Usuarios.GetList().sy_Usuarios;
			_idUsuario=Security.IdPersona;

			string variable=string.Empty;
			variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "HabilitarContraseña";
			this.HabilitarContraseña=Variables.GetValueBool(variable);	
			//this.HabilitarContraseña=true;
			variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "PermiteEditarResponsable";
			this.PermiteEditarResponsable= Variables.GetValueBool(variable);
			//this.PermiteEditarResponsable=true;

			

		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(this._task);
			bool IsValid = validator.IsValidForStartProcess(this._process.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		public System.Data.DataTable Usuarios
		{
			get {return _usuarios;}
		}
		private string _idUsuario;
		public string IdUsuario
		{
			get{return _idUsuario;}
			set
			{
				if(_idUsuario != value)
				{	
					_idUsuario = value;
					this.FiltroCajas = tfi_InstanciasCaja.GetList(_idUsuario).Tables[0];
					if (_filtroCajas.Rows.Count > 0)
						{
						IdCaja = Convert.ToString(_filtroCajas.Rows[0]["IdCaja"]);
						}
					else IdCaja=string.Empty;
						
					if(IdCajaChanged!=null)
						IdCajaChanged(this, new EventArgs());
					if(IdUsuarioHasChanged!= null)
						IdUsuarioHasChanged(this, new EventArgs());					
				}
			}
		}
		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();			

			#region MOVIMIENTO DE AJUSTE (desde consulta de caja)		
			if(this._process.Process.ProcessName.Equals("ProcesoAjustarMovimientoCaja"))
			{
                bool permiteAjustesSoloPorElTotal = Variables.GetValueBool(this._process.Process.ProcessName, this._task, "ValorDefaultReadOnly");				
				
				if(_allowToValidateMovimientoYaAjustado && permiteAjustesSoloPorElTotal)
				{
					if(mz.erp.businessrules.tfi_MovimientosDeCajaAjustes.GetList(_idMovimientoOrignal, null).Tables[0].Rows.Count > 0)
					{
						_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Movimiento Ajustado","El valor que intenta ajustar ya ha sido ajustado previamente"));
						IsValid = false;
					}
				}
				
				ObtenerSignoDeAjuste();
				if ( _signo == 1) // es un ajuste sobre un egreso, por eso es el signo contrario!
				{
					/*
					decimal totalAcumulado = 0;
					foreach (DetalleValorMovimiento valorATransferir in this.DValoresMovimientos)
						totalAcumulado = totalAcumulado + valorATransferir.Monto;
					if (System.Math.Abs(ValorTotal) < totalAcumulado) //quiere hacer un contrasiento por mas valor q el asiento original
					{
						_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor","El importe ingresado es mayor al del movimiento original."));
						IsValid = false;
					}
					*/
					if(_detalleValorAgrupadoOrigen != null)
					{
						decimal totalValoresAgrupadoOrigen = System.Math.Abs(this.TotalValoresAgrupadoOrigen());
						decimal totalValoresAgrupadoAjustados = System.Math.Abs(this.ValoresAjustados());
						decimal totalSinAjustar = totalValoresAgrupadoOrigen - totalValoresAgrupadoAjustados;
						decimal totalAjustadoActual = Math.Round(System.Math.Abs(this.ValoresAjustadosActual()),2);	
						decimal totalAjustado =  Math.Round(totalValoresAgrupadoAjustados,2) - totalAjustadoActual;
						
						if(totalSinAjustar < 0)
						{
							_errores.Add( new ItemDatasetError(this._process.Process.ProcessName,"Valor",
								"El importe ingresado es incorrecto. El movimiento original en " + _detalleValorAgrupadoOrigen.Comprobante 
								+ " " + _detalleValorAgrupadoOrigen.Moneda + " es de " + Convert.ToString(Math.Round(totalValoresAgrupadoOrigen,2)) 
								+ ". Los ajustes del movimiento original en " +  _detalleValorAgrupadoOrigen.Comprobante 
								+ " " + _detalleValorAgrupadoOrigen.Moneda + " suman " + Convert.ToString(totalAjustado) + ". El ajuste actual es de "
								+ Convert.ToString(totalAjustadoActual)+  ". Por lo tanto, el total ajustado supera al movimiento original en "
								+ _detalleValorAgrupadoOrigen.Comprobante + " " + _detalleValorAgrupadoOrigen.Moneda));
							IsValid = false;
						}
					}
					if(_detalleValorAgrupadoOrigen == null)
					{
							
						bool ok = true;
						tfi_MovimientosDeCajaAjustesDataset ajustes = tfi_MovimientosDeCajaAjustes.GetList(_idMovimientoOrignal, null);
						foreach(tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row in ajustes.tfi_MovimientosDeCajaAjustes.Rows )
						{
							string idAjuste = Convert.ToString(row["IdMovimientoDeCajaAjuste"]);
							tfi_PagosMovimientosCajasDataset pagos = tfi_PagosMovimientosCajas.GetList(idAjuste, null);
							foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP in pagos.tfi_PagosMovimientosCajas.Rows)
							{
								string idV = Convert.ToString(rowP["IdValor"]);
								DetalleValorMovimiento dvm = (DetalleValorMovimiento)dValoresMovimientos[0];
								if(dvm.IdValor.Equals(idV))
									ok = false;	
									
								

							}
						}
					
						if(!ok)
						{
							_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor ajustado","El valor asociado al movimiento que desea ajustar ya fue ajustado"));
							IsValid = false;
						}
					}
				}
				if ( _signo == -1) // es un ajuste sobre un ingreso, por eso es el signo contrario!
				{
					decimal totalAcumulado = 0;
					foreach (DetalleValorMovimiento valorATransferir in this.DValoresMovimientos)
					{
						totalAcumulado = totalAcumulado + valorATransferir.Monto;
						System.Data.DataTable tabla = tfi_InstanciasCaja.GetTotalInstanciaPorTDCompTesoreria(valorATransferir.IdTDCompTesoreria, IdCaja);
						decimal totalPorTDComp =0;
						if (tabla.Rows.Count > 0 )
							totalPorTDComp = Convert.ToDecimal(tfi_InstanciasCaja.GetTotalInstanciaPorTDCompTesoreria(valorATransferir.IdTDCompTesoreria, IdCaja).Rows[0]["Neto"]);
						if ( totalPorTDComp < valorATransferir.Monto)
						{
							_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor","El importe ingresado supera el saldo disponible."));
							IsValid = false;
						}
					}
					if(_detalleValorAgrupadoOrigen == null)
					{
							
						bool ok = true;
						tfi_MovimientosDeCajaAjustesDataset ajustes = tfi_MovimientosDeCajaAjustes.GetList(_idMovimientoOrignal, null);
						foreach(tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row in ajustes.tfi_MovimientosDeCajaAjustes.Rows )
						{
							string idAjuste = Convert.ToString(row["IdMovimientoDeCajaAjuste"]);
							tfi_PagosMovimientosCajasDataset pagos = tfi_PagosMovimientosCajas.GetList(idAjuste, null);
							foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP in pagos.tfi_PagosMovimientosCajas.Rows)
							{
								string idV = Convert.ToString(rowP["IdValor"]);
								DetalleValorMovimiento dvm = (DetalleValorMovimiento)dValoresMovimientos[0];
								if(dvm.IdValor.Equals(idV))
									ok = false;	
									
								

							}
						}
						if(!ok)
						{
							_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor ajustado","El valor asociado al movimiento que desea ajustar ya fue ajustado"));
							IsValid = false;
						}
					}
					/* Esta validacion tiene como objetivo no permitir ajustar un movimiento
					 * por mas del monto del movimiento. Sup un movimiento que tiene asociado 2 valores
					 * efectivos pesos, por 100 y 150 respectivamente. Luego un ajuste por pesos no deberia ser mayor
					 * a 250 pesos
					 * */
					if(_detalleValorAgrupadoOrigen != null)
					{
						decimal totalValoresAgrupadoOrigen = System.Math.Abs(this.TotalValoresAgrupadoOrigen());
						decimal totalValoresAgrupadoAjustados = System.Math.Abs(this.ValoresAjustados());
						decimal totalSinAjustar = totalValoresAgrupadoOrigen - totalValoresAgrupadoAjustados;
						decimal totalAjustadoActual = Math.Round(System.Math.Abs(this.ValoresAjustadosActual()),2);	
						decimal totalAjustado =  Math.Round(totalValoresAgrupadoAjustados,2) - totalAjustadoActual;
						
						if(totalSinAjustar < 0)
						{
							_errores.Add( new ItemDatasetError(this._process.Process.ProcessName,"Valor",
							"El importe ingresado es incorrecto. El movimiento original en " + _detalleValorAgrupadoOrigen.Comprobante 
								+ " " + _detalleValorAgrupadoOrigen.Moneda + " es de " + Convert.ToString(Math.Round(totalValoresAgrupadoOrigen,2)) 
								+ ". Los ajustes del movimiento original en " +  _detalleValorAgrupadoOrigen.Comprobante 
								+ " " + _detalleValorAgrupadoOrigen.Moneda + " suman " + Convert.ToString(totalAjustado) + ". El ajuste actual es de "
								+ Convert.ToString(totalAjustadoActual)+  ". Por lo tanto, el total ajustado supera al movimiento original en "
								+ _detalleValorAgrupadoOrigen.Comprobante + " " + _detalleValorAgrupadoOrigen.Moneda));
							IsValid = false;
						}
					}
				}
				if (DValoresMovimientos.Count == 0) 
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valores","No hay valores seleccionados para realizar el ajuste."));
				}
				
				if (IdCaja == null || IdCaja == string.Empty)
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Caja","No hay caja seleccionada"));
						
				}
			}
			#endregion

			#region MOVIMIENTO DE EGRESO
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaEgreso"))
			{
				if (IdCaja != null && IdCaja != string.Empty)
				{

					if(_allowToValidateMovimientoEgreso)
					{
						Hashtable table = new Hashtable();
						foreach ( DetalleValorMovimiento dvm in this.DValoresMovimientos )  
						{	
							if(dvm.Agrupado)
							{
								string key = dvm.IdTDCompTesoreria + '-' + dvm.IdMoneda +'-' + dvm.Comprobante + '-' + dvm.Moneda;
								if(!table.ContainsKey(key)) table.Add(key, 0);
								decimal valor = Convert.ToDecimal(table[key]);
								valor = valor + dvm.Monto;
								table[key] = valor;

							}
						}
						foreach(string key in table.Keys)
						{
							string[] partes = key.Split( new char[]{'-'});
							string IdTDcomp = partes[0];
							string IdM = partes[1];
							string Comp = partes[2];
							string Mon = partes[3];
							decimal total = Convert.ToDecimal(table[key]);
							//decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobanteAnterior( dvm.IdTDCompTesoreria, dvm.IdMoneda , tfi_InstanciasCaja.GetByPk(IdCaja).IdCaja);
							decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobante( IdTDcomp, IdM , IdCaja);
							if (totalPorTDComp < total) //dvm.MontoCotizado)
							{
								_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor","El importe ingresado en "+ Comp + " "+ Mon + " supera el saldo disponible." +
									"El Monto actual en la caja es de " + totalPorTDComp));
								IsValid = false;
							}
						}
							
						
					}
					foreach ( DetalleValorMovimiento dvm in this.DValoresMovimientos )  
					{	
						if (!dvm.Agrupado && ((dvm.IdInstanciaCaja != IdCaja && dvm.Valor.State.ToUpper().Equals("EDIT"))|| dvm.Valor.State.ToUpper().Equals("NEW")))
						{
							string message = "El valor " + dvm.Comprobante + " Nro " + dvm.Numero + " No pertenece a la caja de la cual se desea hacer el egreso. Debe transferirlo.";
							_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor",message));	
							IsValid = false;	
						}
					}
					foreach ( DetalleValorMovimiento dvm in this.DValoresMovimientos )  
					{	
						if (!dvm.Agrupado &&  dvm.Valor.State.ToUpper().Equals("EDIT") && dvm.Valor.Signo.Equals(-1))
						{
							string message = "El valor " + dvm.Comprobante + " Nro " + dvm.Numero + " tiene signo negativo. No puede usarse en un egreso";
							_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor",message));	
							IsValid = false;	
						}
					}

				}
				else 
				{
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor","No se ha seleccionado ninguna caja."));
					IsValid = false;
				}
				
				if (DValoresMovimientos.Count == 0) 
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valores","No se indicaron valores para realizar el egreso."));
				}
				if (! tfi_InstanciasCaja.InstanciaDeCajaAbierta(_idCaja))
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valores","No se puede realizar el egreso con la caja cerrada."));
				}

			}
			#endregion

			#region MOVIMIENTO DE INGRESO
			if(this._process.Process.ProcessName.Equals("ProcesoMovimientoCajaIngreso"))
			{
				if(IdCaja == null || IdCaja == string.Empty) 
				{
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valor","No se ha seleccionado ninguna caja."));
					IsValid = false;
				}
				if (DValoresMovimientos.Count == 0) 
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valores","No se indicaron valores para realizar el ingreso."));
				}
				if (! tfi_InstanciasCaja.InstanciaDeCajaAbierta(_idCaja))
				{
					IsValid = false;	
					_errores.Add( new ItemDatasetError( this._process.Process.ProcessName,"Valores","No se puede realizar el ingreso con la caja cerrada."));
				}
				
			}
			#endregion
			if (_idUsuario == String.Empty) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Responsable","Responsable","El responsable no puede ser vacio"));
			}
			return IsValid;
		}
		public bool AllowShow()
		{
			return true;
		}		
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()	
		{
			return _errores;
		}
		
		private bool MustMostrarWarnings()
		{
			return Variables.GetValueBool(this._process.Process.ProcessName, this._task,"MuestraWarning");
		}

		public void Continue()
		{
			_process.MostroWarnings = true;
			OnTaskAfterExecute(this, new EventArgs());
		}
		

		public string GetWarnings()
		{			
			if(MustMostrarWarnings())
			{
				if( this._importeTotalMovimiento == 0)
					return "El importe del Movimiento es 0. Desea efectuar el Movimiento de todas formas?";
			}
			return null;
		}
		public ProcessManager GetProcessManagerParent()
		{
			return _process;
		}
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_process= processManager;
		}
		public string GetTaskName()
		{
			return _task;
		}
		public string GetProcessName()
		{
			return _process.Process.ProcessName;
		}
		public void SetTaskName(string taskName)
		{
			_task=taskName;
		}
		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		public bool AllowPrevious()
		{
			return true;
		}
		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			_detalleValorAgrupadoOrigen = null;
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}
		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación MovimientosCaja.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación MovimientosCaja.ListenerBeforePreviousDependentTask
		}

		#endregion
		private sy_UsuariosDataset.sy_UsuariosDataTable  _usuarios;
		private string _textoBotonAnterior = "Anterior";

		private bool _habilitarContraseña =false;
		public bool HabilitarContraseña 
		{
			get{return _habilitarContraseña ;}
			set {_habilitarContraseña=value;}
		}

		private bool _permiteEditarResponsable =false;
		public bool PermiteEditarResponsable 
		{
			get{return _permiteEditarResponsable ;}
			set {_permiteEditarResponsable=value;}
		}
		public string TextoBotonAnterior
		{
			get 
			{				
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "TextoBotonAnterior";
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._process.Process.ProcessName + "." + "TextoBotonSiguiente";
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




		public mz.erp.commontypes.data.tsy_TiposMovimientosDataset ListaTiposMovimientos()
		{
			string nombreProceso = this._process.Process.ProcessName;
			if(nombreProceso.Equals("ProcesoAjustarMovimientoCaja") || nombreProceso.Equals("ProcesoModificarValor"))
			{
				return mz.erp.businessrules.tsy_TiposMovimientos.GetList(_idTipo, null);
			}
			if(nombreProceso.Equals("ProcesoEditarMovimientoCaja") 
				|| nombreProceso.Equals("ProcesoMovimientoCajaIngreso") 
				|| nombreProceso.Equals("ProcesoMovimientoCajaEgreso")||nombreProceso.Equals("ProcesoDepositarCuentaCorriente"))
			{
				return mz.erp.businessrules.tsy_TiposMovimientos.GetListPorSigno(Convert.ToString(_signo));
			}
			return null;			
		}

//		public erp.commontypes.data.tsy_SubTipoMovimientoDataset ListaSubTipoMovimientos(string idTipo)
//		{
//			tsy_SubTipoMovimientoDataset data = tsy_SubTipoMovimiento.GetList(idTipo);
//			if (data.tsy_SubTipoMovimiento.Rows.Count != 0)
//			{
//                IdSubTipo = data.tsy_SubTipoMovimiento.Rows[0]["IdSubTipoMovimiento"].ToString();
//			}
//			else
//			{
//				IdSubTipo = string.Empty;
//			}
//			return data;
//			//return mz.erp.businessrules.tsy_SubTipoMovimiento.GetList(idTipo);
//		}

		public DataTable ListaSubTipoMovimientos(string idTipo)
		{
			DataTable data = tsy_SubTipoMovimiento.GetList(idTipo).tsy_SubTipoMovimiento;
			if (data.Rows.Count != 0)
			{
				data =  VariablesListComparer.FilterDataTable(this._process.Process.ProcessName, this.GetTaskName(), "SubTipoMovimiento", "IdSubTipoMovimiento", data);
				//German 20091029
				//Si no esxiste el subtipo actual en el dataset nuevo, elijo como seleccionado al primero
				if(!ExistsSubTipo(data))
					IdSubTipo = data.Rows[0]["IdSubTipoMovimiento"].ToString();
				//Fin German 20091029
			}
			else
			{
				IdSubTipo = string.Empty;
			}
			return data;
		}

		//German 20091029
		private bool ExistsSubTipo(DataTable data)
		{

			foreach(DataRow row in data.Rows)
			{
				if(Convert.ToString(row["IdSubTipoMovimiento"]).Equals(_idSubTipo))
					return true;
			}
			return false;
		}
		//Fin German 20091029


	
		public  decimal ValoresAjustados()
		{
			decimal aux = 0 ;
			if(_detalleValorAgrupadoOrigen != null)
			{
				if(_detalleValorAgrupadoOrigen.Agrupado)
				{
					tfi_MovimientosDeCajaAjustesDataset ajustes = tfi_MovimientosDeCajaAjustes.GetList(_idMovimientoOrignal, null);
					foreach(tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row in ajustes.tfi_MovimientosDeCajaAjustes.Rows )
					{
						string idAjuste = Convert.ToString(row["IdMovimientoDeCajaAjuste"]);
						tfi_PagosMovimientosCajasDataset pagos = tfi_PagosMovimientosCajas.GetList(idAjuste, null);
						foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP in pagos.tfi_PagosMovimientosCajas.Rows)
						{
							string idValor = Convert.ToString(rowP["IdValor"]);
							DataRow rowValor = tfi_Valores.GetByPk(idValor);
							decimal valor = Convert.ToDecimal(rowValor["Valor"]);
							string IdTDCompTesoreria = Convert.ToString(rowValor["IdTDCompTesoreria"]);
							string IdMoneda = Convert.ToString(rowValor["IdMoneda"]);
							if((IdTDCompTesoreria != null && IdTDCompTesoreria.Equals(_detalleValorAgrupadoOrigen.IdTDCompTesoreria))
								&& (IdMoneda != null && IdMoneda.Equals(_detalleValorAgrupadoOrigen.IdMoneda)))
									aux = aux + valor;
						}
					}
					aux = aux + ValoresAjustadosActual();
					
				}
			}
			return aux;
		}

		private decimal ValoresAjustadosActual()
		{
			decimal aux = 0;
			if(_detalleValorAgrupadoOrigen != null)
			{
				foreach(DetalleValorMovimiento dvm in dValoresMovimientos)
				{
					if((dvm.IdTDCompTesoreria != null && dvm.IdTDCompTesoreria.Equals(_detalleValorAgrupadoOrigen.IdTDCompTesoreria))
						&& (dvm.IdMoneda != null && dvm.IdMoneda.Equals(_detalleValorAgrupadoOrigen.IdMoneda)))
						aux = aux + dvm.Monto;
				}
			}
			return aux;
		}

		private void RecalcularImporteTotalMovimiento()
		{
			_importeTotalMovimiento = 0;
			foreach(DetalleValorMovimiento dValor in this.DValoresMovimientos)
			{
				_importeTotalMovimiento = _importeTotalMovimiento + dValor.Valor.MontoCotizado;

			}
		}

		public decimal TotalValoresAgrupadoOrigen()
		{
			decimal result = 0;
			if(_detalleValorAgrupadoOrigen != null)
			{
				tfi_PagosMovimientosCajasDataset dataPagosList = tfi_PagosMovimientosCajas.GetList(_idMovimientoOrignal, null);
				foreach(tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row in dataPagosList.tfi_PagosMovimientosCajas.Rows)
				{
					tfi_ValoresDataset.tfi_ValoresRow rowValores = tfi_Valores.GetByPk(Convert.ToString(row["IdValor"]));
					DetalleValorMovimiento vm = new DetalleValorMovimiento();
					string IdTDCompTesoreria = Convert.ToString(rowValores["IdTDCompTesoreria"]);
					string IdMoneda = Convert.ToString(rowValores["IdMoneda"]);
					decimal Monto = Convert.ToDecimal(rowValores["Valor"]);
					if(IdTDCompTesoreria.Equals(_detalleValorAgrupadoOrigen.IdTDCompTesoreria)
						&& IdMoneda.Equals(_detalleValorAgrupadoOrigen.IdMoneda))
							result = result + Monto;
				}
			}
			return result;
		}

		private void build_DataTableTiposMovimientos()
		{			
			DataTable tableTM = (DataTable) tsy_TiposMovimientos.GetListPorSigno(Convert.ToString(_signo)).tsy_TiposMovimientos;
			_filtroTiposMovimientos =  VariablesListComparer.FilterDataTable(this._process.Process.ProcessName, this.GetTaskName(), "TipoMovimiento", "IdTipoMovimiento", tableTM);
		}


	}
}
