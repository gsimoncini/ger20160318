using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMFormasDePagoController.
	/// </summary>
	public class ABMFormasDePagoController
	{
		#region Constructor
		public ABMFormasDePagoController(string State)
		{
			this._state = State;
			Init();
		}
		#endregion

		#region Métodos Privados

		private void Init()
		{
			_listaTiposDeComprobantes = mz.erp.businessrules.tsy_TiposDeComprobantes.GetTiposDeComprobanteRequiereCondicionDeVenta();
			_listaCondicionesDeVentas = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentas();
			_listaComprobantesTesoreriaBDConJerarquia=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListTodosByNivel(0);
			//Carga todos los comprobante de tesoreria hijos de cheques, tarjetas, retenciones, nivel 0 de la jerarquia
			this.BuscarComprobanteTesoreriaNivelCero();
			//Con cargar nivel 0 ya ta, sus hijos tienen la misma clave larga
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				_familiasPorClaveLarga[fila["Jerarquia"]]=fila["ClaveLarga"];
				_agrupadosFamilia[fila["Jerarquia"]]=fila["Agrupado"];
				//Talvez necesite las de nivel uno tambien
				_claveCortas[fila["Jerarquia"]]=fila["ClaveCorta"];
				
			}
			this.BuscarNivelUno();
		
			}
		private void BuscarComprobanteTesoreriaNivelCero(){
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				DataTable table=new DataTable();					
				table=mz.erp.businessrules.tfi_TDCompTesoreria.GetListByJerarquia(Convert.ToString(fila["Jerarquia"]));
				_comprobantesPorNivelCero[fila["Jerarquia"]]=table;
				
			}
		}

		private void BuscarNivelUno()
		{   DataTable result=new DataTable();
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				result=mz.erp.businessrules.tfi_JerarquiaAgrupTDCompTesoreria.GetListTodosByNivelAndPadre(1,Convert.ToString(fila["Jerarquia"]));
				//Carga todos los tfi_tdComprobantes q son 'hijos' de los de nivel 1
				foreach (DataRow row in result.Rows)
				{	DataTable table=new DataTable();
					_claveCortas[row["Jerarquia"]]=row["ClaveCorta"];
					table=mz.erp.businessrules.tfi_TDCompTesoreria.GetListByJerarquia(Convert.ToString(row["Jerarquia"]));
					_comprobantesPorNivelUno[row["Jerarquia"]]=table;
				}
				_nivelUno[fila["Jerarquia"]]=result;
				
			}
		}
		

		#endregion

		#region Eventos
			
		public event EventHandler MetodoAsigCuentaXEChanged;
		public event EventHandler MetodoAsigCuentaXIChanged;
		public event EventHandler MetodoAsigTipoCompXEChanged;
		public event EventHandler MetodoAsigTipoCompXIChanged;
		public event EventHandler MetodoComparacionXIChanged;
		public event EventHandler MetodoComparacionXEChanged;
		public event EventHandler RecargoChanged;
		public event EventHandler JerarquiaChanged;
		public event EventHandler Jerarquia1Changed;



		#endregion

		#region Variables Privadas


		private string _state = string.Empty;
		private ArrayList _listaCondicionesDeVentas = new ArrayList();
		private ArrayList _listaTiposDeComprobantes = new ArrayList();
		private DataTable _listaComprobantesTesoreriaBDConJerarquia = new DataTable();
		private DataTable _listaComprobantesTesoreriaBDConJerarquia1 = new DataTable();
		private ArrayList _listaCondicionesDeVentasSeleccionadas = new ArrayList();
		private ArrayList _listaTiposDeComprobantesSeleccionados = new ArrayList();
		private string _codigoCuenta = string.Empty;
		private ArrayList _listaCuentas = new ArrayList();
		private bool _metodoComparacionXE = true;
		private bool _metodoComparacionXI = false;
		private bool _metodoAsigTipoCompXE = false;
		private bool _metodoAsigTipoCompXI = true;
		private bool _metodoAsigCuentaXI = false;
		private bool _metodoAsigCuentaXE = true;
		private decimal _recargo = 0;
		private string _jerarquia = string.Empty;
		private string _jerarquia1 = string.Empty;
		private bool _agrupado=false;

		private string _jerarquiaEdicion=string.Empty;
		
		private tfi_TDCompTesoreria_CondicionesDeVentaDataset _dataTDCompTesoreriaCondVentas = new tfi_TDCompTesoreria_CondicionesDeVentaDataset();
		private tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset _dataCuentasTDCompTesoreriaCondVentas = new tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset();
		private Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset _dataTiposDeCompTDCompTesoreriaCondVentas = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();
		private tfi_TDCompTesoreriasMonedasRecargosDataset _dataTDCompTesoreriaMonedaRecargos = new tfi_TDCompTesoreriasMonedasRecargosDataset();
		//tfi_tdComptesoreria si no tiene segundo nivel (solo el primer combo)
		private Hashtable _comprobantesPorNivelCero=new Hashtable();
		//tfi_tdComprotesoreria selecciona el segundo combo(obligo a seleccionar uno si es q hay)
		private Hashtable _comprobantesPorNivelUno=new Hashtable();
		private Hashtable _familiasPorClaveLarga=new Hashtable();
		private Hashtable _claveCortas=new Hashtable();
		private Hashtable _nivelUno=new Hashtable();
		private Hashtable _agrupadosFamilia=new Hashtable();
		private string _idComprobanteDefault=String.Empty;
		

		#endregion

        #region Variables Publicas

		public decimal Recargo
		{
			get{return _recargo;}
			set{_recargo = value;}
		}

		public string IdComprobanteDefault
		{
			get{return _idComprobanteDefault;}
		}
		public tfi_TDCompTesoreriasMonedasRecargosDataset DataTDCT_M_R
		{
			get{return _dataTDCompTesoreriaMonedaRecargos;}
		}

		public Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset Data_TC_CV_TDCT
		{
			get{return _dataTiposDeCompTDCompTesoreriaCondVentas;}
		}
			

		public tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset Data_C_CV_TDCT
		{
			get{return _dataCuentasTDCompTesoreriaCondVentas;}
		}
		
		public tfi_TDCompTesoreria_CondicionesDeVentaDataset Data_TDCT_CV
		{
			get{return _dataTDCompTesoreriaCondVentas;}
		}
	
		public Hashtable FamiliasPorClaveLarga
		{
			get{return _familiasPorClaveLarga;}
		}
		public Hashtable ClavesCortas
		{
			get{return _claveCortas;}
		}
		public bool MetodoAsigCuentaXE
		{
			get{return _metodoAsigCuentaXE;}
			set{_metodoAsigCuentaXE = value;}
		}

		public bool Agrupado
		{
			get{return _agrupado;}
			set{_agrupado = value;}
		}
		public bool MetodoAsigCuentaXI
		{
			get{return _metodoAsigCuentaXI;}
			set{_metodoAsigCuentaXI = value;}
		}

		public bool MetodoAsigTipoCompXI
		{
			get{return _metodoAsigTipoCompXI;}
			set{_metodoAsigTipoCompXI = value;}
		}

		public bool MetodoAsigTipoCompXE
		{
			get{return _metodoAsigTipoCompXE;}
			set{_metodoAsigTipoCompXE = value;}
		}


		public bool MetodoComparacionXI
		{
			get{return _metodoComparacionXI;}
			set{_metodoComparacionXI = value;}
		}


		public bool MetodoComparacionXE
		{
			get{return _metodoComparacionXE;}
			set{_metodoComparacionXE = value;}
		}

		public string CodigoCuenta
		{
			get{return _codigoCuenta;}
			set{_codigoCuenta = value;}
        }

		public ArrayList ListaCondicionesDeVentas
		{
			get{return _listaCondicionesDeVentas;}
		}

		public ArrayList ListaTiposDeComprobantes
		{
			get{return _listaTiposDeComprobantes;}
		}

		public ArrayList ListaCondicionesDeVentasSeleccionadas
		{
			set{_listaCondicionesDeVentasSeleccionadas = value;}
		}

		public ArrayList ListaTiposDeComprobantesSeleccionados
		{
			get {return _listaTiposDeComprobantesSeleccionados;}
			set {_listaTiposDeComprobantesSeleccionados = value;}
		}
		

		public ArrayList ListaCuentas
		{
			get{return _listaCuentas;}
		}
		public DataTable ListaSegundoNivel
		{
			get{return _listaComprobantesTesoreriaBDConJerarquia1;}
		}

		public bool TieneHijos
		{
			get{return _listaComprobantesTesoreriaBDConJerarquia1.Rows.Count>0;}
		}
		public string Jerarquia
		{
			get{return _jerarquia;}
			set
			{
				if(_jerarquia != value)
				{//Tengo q buscar las formas de pagos para esa flia
					_jerarquia=value;
					if(_jerarquia!=string.Empty && _jerarquia!=null)
					{
						//Cargo los de nivel 1 en el segundo combo
						_listaComprobantesTesoreriaBDConJerarquia1=(DataTable)_nivelUno[_jerarquia];
						this.Agrupado=Convert.ToBoolean(_agrupadosFamilia[_jerarquia]);
					
					}
					
					if(JerarquiaChanged != null)
						JerarquiaChanged(this, new EventArgs());

				}
				}
		}
		public string Jerarquia1
		{
			get{return _jerarquia1;}
			set
			{
				if(_jerarquia1 != value)
				{//faltan todos los comp de tesoreria de esa jerarquia
					_jerarquia1=value;
									
					if(Jerarquia1Changed != null)
						Jerarquia1Changed(this, new EventArgs());

				}
			}
		}
	
		public string JerarquiaEdicion
		{
			get{return _jerarquiaEdicion;}
			set
			{
				if(_jerarquiaEdicion != value)
				{
					_jerarquiaEdicion=value;
									
				}
			}
		}
		#endregion

		#region Metodos Publicos
		public void seleccionarFamilia(){
			//Esto es para q tenga algo por default
			this.Jerarquia=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia.Rows[0]["jerarquia"]);
			this.Agrupado=Convert.ToBoolean(_agrupadosFamilia[Jerarquia]);

		}
		public void seleccionarFamiliaDeNivel2Edicion()
		{
			_jerarquia1=_jerarquiaEdicion;
		}
		public void seleccionarFamiliaDeNivel2()
		{
			//Esto es para q tenga algo por default
			this.Jerarquia1=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia1.Rows[0]["jerarquia"]);
		}
		public void seleccionarComprobante()
		{
			//Esto es para q tenga algo por default
			this.Jerarquia=Convert.ToString(_listaComprobantesTesoreriaBDConJerarquia.Rows[0]["jerarquia"]);
		}
		public DataTable GetTableFamiliasTDCompTesoreria()
		{
					
			DataTable _tableFamiliasTDCompTesoreria = new DataTable();
			_tableFamiliasTDCompTesoreria.Columns.Add("Jerarquia");
			_tableFamiliasTDCompTesoreria.Columns.Add("Descripcion");
			foreach (DataRow fila in _listaComprobantesTesoreriaBDConJerarquia.Rows)
			{
				DataRow row0 = _tableFamiliasTDCompTesoreria.NewRow();
				row0["Jerarquia"] = fila["Jerarquia"];
				row0["Descripcion"] = fila["Descripcion"];
				_tableFamiliasTDCompTesoreria.Rows.Add(row0);}
			return _tableFamiliasTDCompTesoreria;
		}

		public decimal GetRecargo(string IdTdcompTesoreria)
		{
			_dataTDCompTesoreriaMonedaRecargos.Clear();
			_dataTDCompTesoreriaMonedaRecargos = mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.GetList(IdTdcompTesoreria, string.Empty);
			if(_dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Rows.Count > 0)
			{
				this._recargo = Convert.ToDecimal(_dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Rows[0]["Recargo"]);
				return this._recargo;
			}
			return 0;

		}


		public void Commit()
		{
			if(this._state.ToUpper().Equals("NEW"))
			{
				
				_dataTDCompTesoreriaCondVentas = new tfi_TDCompTesoreria_CondicionesDeVentaDataset();
				_dataCuentasTDCompTesoreriaCondVentas = new tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset();
				_dataTiposDeCompTDCompTesoreriaCondVentas = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();
				foreach(CondicionDeVentaView cdv in this._listaCondicionesDeVentasSeleccionadas)
				{
					tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row_TDCT_CV = this._dataTDCompTesoreriaCondVentas.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();
					mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(row_TDCT_CV);
					row_TDCT_CV.idCondicionDeVenta = cdv.IdCondicionDeVenta;
					if(_metodoComparacionXE)
						row_TDCT_CV.MetodoDeComparacion = "E";
					else
						if(_metodoComparacionXI)
						row_TDCT_CV.MetodoDeComparacion = "I";
					this._dataTDCompTesoreriaCondVentas.tfi_TDCompTesoreria_CondicionesDeVenta.Addtfi_TDCompTesoreria_CondicionesDeVentaRow(row_TDCT_CV);
				
					foreach(TipoDeComprobante tcv in this.ListaTiposDeComprobantesSeleccionados)
					{
					
						Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
						mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
						row_TC_CV_TDCT.IdCondicionDeVenta = cdv.IdCondicionDeVenta;
						row_TC_CV_TDCT.IdTipoDeComprobante = tcv.IdTipoComprobante;
							if(_metodoAsigTipoCompXE)
								row_TC_CV_TDCT.MetodoDeAsignacion = "E";
							else
								if(_metodoAsigTipoCompXI)
								row_TC_CV_TDCT.MetodoDeAsignacion = "I";
						this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);

					}
					foreach(Cuenta c in this._listaCuentas)
					{
						tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
						mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
						row_C_CV_TDCT.IdCondicionDeVenta = cdv.IdCondicionDeVenta;
						row_C_CV_TDCT.IdCuenta = c.IdCuenta;
						if(_metodoAsigCuentaXE)
							row_C_CV_TDCT.MetodoDeAsignacion = "E";
						else
							if(_metodoAsigCuentaXI)
								row_C_CV_TDCT.MetodoDeAsignacion = "I";
						this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);

					}
									
				}
				tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row_TDCT_M_R = this._dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Newtfi_TDCompTesoreriasMonedasRecargosRow();
				mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.SetRowDefaultValues(row_TDCT_M_R);
				row_TDCT_M_R.Recargo = this._recargo;
				row_TDCT_M_R.IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
				this._dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Addtfi_TDCompTesoreriasMonedasRecargosRow(row_TDCT_M_R);
				

			}
			if(this._state.ToUpper().Equals("EDIT"))
			{
				tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row_TDCT_M_R;
				if(_dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Rows.Count > 0)
				{
					row_TDCT_M_R = (tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow)_dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Rows[0];
					row_TDCT_M_R.Recargo = this._recargo;
				}
				else 
				{
					row_TDCT_M_R = this._dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Newtfi_TDCompTesoreriasMonedasRecargosRow();
					mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.SetRowDefaultValues(row_TDCT_M_R);
					row_TDCT_M_R.Recargo = this._recargo;
					row_TDCT_M_R.IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
					this._dataTDCompTesoreriaMonedaRecargos.tfi_TDCompTesoreriasMonedasRecargos.Addtfi_TDCompTesoreriasMonedasRecargosRow(row_TDCT_M_R);
				}

				
			}	
				

		}


		public bool ClienteRepetido(string codigoCuenta)
		{

			foreach(Cuenta c in this._listaCuentas)
			{
				if(c.Codigo.Equals(_codigoCuenta))
					return true;
			}
			return false;
		}


		public void UpdateCuentas(string CodigoCuenta)
		{
			if(CodigoCuenta != null && CodigoCuenta != string.Empty)
			{
				Cuenta cuenta = new Cuenta();
				cuenta.GetCuenta_CodigoCuenta(CodigoCuenta);
				_listaCuentas.Add(cuenta);
			}
		}

		public string GetLayoutCuentas()
		{
			
			ArrayList fl = new ArrayList();
			int i = 0;
			string _fieldList = null;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",90 ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",300 ) );
			if ( fl.Contains( "Domicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",true ) );
			if ( fl.Contains( "HorarioComercial" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "HorarioComercial", "HorarioComercial",true ) );
			if ( fl.Contains( "TipoDocumento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoDocumento", "Tipo Doc.",50) );
			if ( fl.Contains( "Documento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Documento", "Doc.", 75 ) );
			if ( fl.Contains( "CategoriaImpositiva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CategoriaImpositiva", "Cat. IVA",75 ) );
			if ( fl.Contains( "Telefono" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono",true ) );
			if ( fl.Contains( "IdTitular" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTitular", "IdTitular",true ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones",100 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
	public System.Data.DataTable TDCompTesoreriaPorNivelUno()
	{	System.Data.DataTable result=(System.Data.DataTable)_comprobantesPorNivelUno[Jerarquia1];
		if(result.Rows.Count==0)
			//Sino tiene comprobantes de tesoreria para ese hijo trae los comp tesoreria de el padre
			 result=(System.Data.DataTable)_comprobantesPorNivelCero[Jerarquia];
		_idComprobanteDefault=Convert.ToString(result.Rows[0]["idTDCompTesoreria"]);
		return result;
			
	}
	public System.Data.DataTable TDCompTesoreriaPorNivelCero()
     {	
		System.Data.DataTable result=(System.Data.DataTable)_comprobantesPorNivelCero[Jerarquia];
		_idComprobanteDefault=Convert.ToString(result.Rows[0]["idTDCompTesoreria"]);
		return result;
			
			
	}

		public void ActualizarJerarquiaUno(){
			_jerarquia1=string.Empty;
		}
		public void CargarJerarquiasYClaves(string idTdCompTesoreria){
			tfi_AgrupTDCompTesoreriaDataset comprobante=	tfi_AgrupTDCompTesoreria.GetList(idTdCompTesoreria,null);
			//Esta jerarquia es la q va seleccionada en el primer o segundo combo
			_jerarquiaEdicion=Convert.ToString(comprobante.Tables[0].Rows[0]["Jerarquia"]);
			//Entonces es de primer nivel
			if (_jerarquiaEdicion.Length>20)
			{
				_jerarquia=_jerarquiaEdicion.Substring(0,20);
				_listaComprobantesTesoreriaBDConJerarquia1=(DataTable)_nivelUno[_jerarquia];
					
			}
			else{ _jerarquia=_jerarquiaEdicion;
			_listaComprobantesTesoreriaBDConJerarquia1=(DataTable)_nivelUno[_jerarquia];
			}
				
		}

		#endregion
	}
}
