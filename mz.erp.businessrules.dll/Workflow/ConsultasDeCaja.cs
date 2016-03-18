using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	#region class auxiliar ItemsFiltros
	public class ItemsFiltros
	{
		public ItemsFiltros( string id, string name, bool select, string auxiliar)
		{
			this._id = id;
			this._name = name;
			this._select = select;
			this._auxiliar = auxiliar;
		}

		public ItemsFiltros( string id, string name, bool select)
		{
			this._id = id;
			this._name = name;
			this._select = select;
			this._auxiliar= string.Empty;
		}

		private string _id = string.Empty;
		private string _name = string.Empty;
		private bool _select = true;
		private string _auxiliar = string.Empty;

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
		public string Auxiliar
		{
			get { return _auxiliar;}
			set { _auxiliar = value ;}
		}
	}

	#endregion

	#region class auxiliar Movimiento
	public class Movimiento
	{
		public Movimiento()
		{
				
		}
		#region variables
		
		string _idMovimientoOriginal = string.Empty;
		string _idTipoDeMovimiento = string.Empty;
		string _idSubTipoMovimiento = string.Empty; 
		string _numero = string.Empty;
		string _total = string.Empty;
		string _idInstanciaCaja = string.Empty;
		string _idMonedaCierre= string.Empty;
		string _observaciones = string.Empty;
		string _valorMoneda = string.Empty;
		string _valorTDCompTesoreria = string.Empty;
		string _TipoComprobante = string.Empty;
		string _tabla= string.Empty;
		string _idValor = string.Empty;

		decimal _valorTotal = 0;
		DateTime _fecha = DateTime.MinValue;


		#endregion 
				
		#region acceso a Variables
				
		public string Tabla
		{
			set{ _tabla = value;}
			get{ return _tabla;}
		}
		public string TipoComprobante
		{
			set{ _TipoComprobante= value; }
			get{ return  _TipoComprobante; }
		}
		public 	string IdTipoDeMovimiento
		{
			set{ _idTipoDeMovimiento = value; }
			get{ return  _idTipoDeMovimiento; }
		}
					
		public string IdSubTipoMovimiento 
		{
			set{ _idSubTipoMovimiento = value; }
			get{ return  _idSubTipoMovimiento; }
		}
				
		public string Numero 
		{
			set{ _numero = value; }
			get{ return _numero; }
		}
		public string Total 
		{
			set{ _total = value; }
			get{ return _total; }
		}
		public string IdInstanciaCaja 
		{
			set{ _idInstanciaCaja = value; }
			get{ return _idInstanciaCaja; }
		}
		public string IdMonedaCierre 
		{
			set{ _idMonedaCierre = value; }
			get{ return _idMonedaCierre; }
		}
		public string Observaciones 
		{
			set{ _observaciones = value; }
			get{ return _observaciones; }
		}
		public string ValorMoneda
		{
			set{ _valorMoneda = value;}
			get{ return _valorMoneda;}
		}
		public string ValorTDCompTesoreria
		{
			set{ _valorTDCompTesoreria =  value;}
			get{ return _valorTDCompTesoreria;}
		}
		public decimal ValorTotal 
		{
			set{ _valorTotal =  value;}
			get{ return _valorTotal;}
		}
		public string IdMovimientoOriginal
		{
			set{ _idMovimientoOriginal =  value;}
			get{ return _idMovimientoOriginal;}
		}
		public DateTime Fecha
		{
			set{ _fecha =  value;}
			get{ return _fecha;}
		}
		public string IdValor 
		{
			set {_idValor = value;}
			get {return _idValor;}
		}



		#endregion

	}
	#endregion
	
	
	public class ConsultasDeCaja: ITask	
	{
		
		#region CUSTOM MEMBERS
	
		#region CONSTRUCTOR
		public ConsultasDeCaja()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region VARIABLES PRIVADAS
		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private string _taskName = string.Empty;
		private ProcessManager _processParent;
		private object _selectedItem;
		private object _selectedRow;
		private Movimiento _movimiento = new Movimiento();

		private DateTime _fechaApertura = mz.erp.systemframework.Util.GetStartDay(mz.erp.businessrules.Sistema.DateTime.Now);
		private DateTime _fechaCierre = mz.erp.systemframework.Util.GetEndDay(mz.erp.businessrules.Sistema.DateTime.Now);
		private bool _checkSoloAbiertas = true;
		private bool _checkSoloCerradas = false;
		private bool _checkFechaMovimientos = false;
		private bool _checkUltimaCaja = false;


		private ArrayList _filtroUsuarios;
		private ArrayList _filtroTipos;
		private ArrayList _filtroTDCompTesoreria;
		private ArrayList _filtroCajas;

		private DataSet _data = null;
	
		private string _idUsuarios = string.Empty;
		private string _idCajas = string.Empty;
		private string _idTipos = string.Empty;
		private string _idTDCompTesoreria = string.Empty;
		private bool _filtroFechaMovimiento = false;

		

		#endregion
		
		#region ACCESO A VARIABLES

		public object SelectedRow
		{
			get{return _selectedRow;}
			set{_selectedRow = value;}
		}
		public object SelectedItem
		{
			set{ _selectedItem  = value;}
			get{ return _selectedItem ;}
		}
		public Movimiento Movimiento
		{	
			set{ _movimiento  = value;}
			get{ return _movimiento ;}
		}
		public DataSet Data
		{
			get { return _data; }
		}
		public ArrayList FiltroCajas
		{
			get { return _filtroCajas ; }
			set { _filtroCajas = value ; }
		}
		public ArrayList FiltroUsuarios
		{
			get { return _filtroUsuarios ; }
			set { _filtroUsuarios = value ; }
		}
		public ArrayList FiltroTipos
		{
			get { return _filtroTipos ;}
			set { _filtroTipos = value ; }
		}
		public ArrayList FiltroTDCompTesoreria
		{
			get { return _filtroTDCompTesoreria;}
			set { _filtroTDCompTesoreria = value; }
		}

		public bool CheckUltimaCaja
		{
			get{return _checkUltimaCaja;}
			set{_checkUltimaCaja = value;}
		}

		public bool CheckSoloAbiertas
		{
			get { return _checkSoloAbiertas; }
			set 
			{ 
				_checkSoloAbiertas = value ;
				if (SoloAbiertasChanged != null)
				{
					SoloAbiertasChanged( this, new System.EventArgs() );
				}
			}
		}
		public bool CheckSoloCerradas
		{
			get { return _checkSoloCerradas; }
			set 
			{ 
				_checkSoloCerradas = value ;
				if (SoloCerradasChanged != null)
				{
					SoloCerradasChanged( this, new System.EventArgs() );
				}
			}
		}
		public bool CheckFechaMovimientos
		{
			get { return _checkFechaMovimientos; }
			set 
			{ 
				_checkFechaMovimientos = value ;
				if (FechaMovimientosChanged != null)
				{
					FechaMovimientosChanged( this, new System.EventArgs() );
				}
			}
		}
		public DateTime FechaApertura
		{
			get {return _fechaApertura; }
			set 
			{
				_fechaApertura = mz.erp.systemframework.Util.GetStartDay(value);
				if (FechaAperturaChanged!=null)
				{
					FechaAperturaChanged(this, new System.EventArgs() );
				}
			}
		}
		public DateTime FechaCierre
		{
			get {return _fechaCierre ; }
			set 
			{
				_fechaCierre = mz.erp.systemframework.Util.GetEndDay(value) ; 
				if (FechaCierreChanged!= null)
				{
					FechaCierreChanged( this, new System.EventArgs() );
				}
			}
		}
		public string IdCajas
		{
			get { return _idCajas ;}
		}
		public string IdUsuarios
		{
			get { return _idUsuarios ; }
		}

		public string IdMonedaReferencia
		{
			get { return Variables.GetValueString( "Contabilidad.MonedaReferencia"); }
		}
		public string ReporteFiltroCajas
		{
			get { return  _idCajas ; }
		}
		public string ReporteFiltroTipos
		{
			get { return _idTipos; }
		}
		public string ReporteFiltroUsuarios
		{
			get { return _idUsuarios; }
		}
		public bool FiltroFechaMovimiento
		{
			get{return _filtroFechaMovimiento;}
		}
		#endregion

		#region EVENTOS

		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;
		public event System.EventHandler SoloAbiertasChanged;
		public event System.EventHandler SoloCerradasChanged;
		public event System.EventHandler FechaMovimientosChanged;

		#endregion
		
		#region BUILD ARRAY ...
		private ArrayList build_ArrayTipos(string[] _rango)
		{
			ArrayList _arrayTipos = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetTiposDeMovimientos(null,System.Int16.MinValue);
			for(int i=0;i<_rango.Length;i++)
			{
				if (_hash.ContainsKey( Convert.ToString( _rango[i] ) ))
				{
					_arrayTipos.Add( new ItemsFiltros(Convert.ToString(_rango[i]), Convert.ToString(_hash[_rango[i]]), true, ObtenerSigno(_rango[i]) )  );
				}
			}
			return _arrayTipos;
		}


		private ArrayList build_ArrayUsuarios(ArrayList _rango)
		{
			ArrayList _arrayUsuarios = new ArrayList();
			Hashtable _hash = mz.erp.businessrules.data.UsuariosPersonas.GetPersonasHashTable();
			foreach( string idTipo in _rango )
			{
				if (_hash.ContainsKey( Convert.ToString( idTipo ) ))
				{
					mz.erp.businessrules.data.UsuariosPersonas up = (mz.erp.businessrules.data.UsuariosPersonas )_hash[idTipo];
					_arrayUsuarios.Add( new ItemsFiltros(up.IdPersona, up.Nombre, true ));
				}
			}
			return _arrayUsuarios;
		}
	

		private ArrayList build_ArrayTDCompTesoreria( )
		{
			ArrayList _arrayTDCompTesoreria = new ArrayList();
			mz.erp.commontypes.data.tfi_TDCompTesoreriaDataset _tableTDCompTesoreria = mz.erp.businessrules.tfi_TDCompTesoreria.GetList();
			DataTable table =  VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName, this._taskName, "ListaComprobanteTesoreria", "IdTDCompTesoreria",_tableTDCompTesoreria.tfi_TDCompTesoreria);
			foreach( System.Data.DataRow _row in table.Rows )
			{
				_arrayTDCompTesoreria.Add( new ItemsFiltros( Convert.ToString(_row["IdTDCompTesoreria"]), Convert.ToString(_row["Descripcion"]), false ));
			}
			return _arrayTDCompTesoreria;
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
		

		#endregion

		#region METODOS PUBLICOS
		//este metodo se usa por el reporteador!!
		public string EstadoCajas
		{
			get
			{
				if (CheckSoloAbiertas)
					return "Abiertas";
				else 
					if (CheckSoloCerradas)
					return "Cerradas";
				else 
					return "Todas";
			}
		}
		#endregion

		#region METODOS PRIVADOS
		private ArrayList loadCajasAConsultar()
		{
			ArrayList result = new ArrayList();
			string _idCajas = Variables.GetValueString( "Cajas.Seguridad.Consultar.Cajas" );
			string[] _cajas = _idCajas.Split( ',' );
			ArrayList _arrayCajasVisibles = new ArrayList( _cajas );
			ArrayList _arrayCajasAbiertas = mz.erp.businessrules.tfi_ResponsablesCajas.GetCajas( Security.IdUsuario);
			result.AddRange(_arrayCajasAbiertas);
			/* ojoo con esto, puede agregar cajas q no estan permitidas para el usuario*/
			foreach(string IdCaja in _arrayCajasVisibles)
			{
				if(!result.Contains(IdCaja))
				{
					result.Add(IdCaja);
				}
			}
			return result;
		}

		
		private void build_Parameters()
		{
			string _tiposDeComprobantes = Variables.GetValueString( "Cajas.Comprobantes.TiposDeComprobantes");
			mz.erp.commontypes.data.tsy_TiposMovimientosDataset _tiposMov = mz.erp.businessrules.tsy_TiposMovimientos.GetList();
			
			string _tiposDeMovimientos = String.Empty;
			for (int i=0 ; i < _tiposMov.tsy_TiposMovimientos.Rows.Count; i++)
			{
				_tiposDeMovimientos = _tiposDeMovimientos + ','+ Convert.ToString(_tiposMov.tsy_TiposMovimientos[i]["IdTipoMovimiento"]);	
			}
						
			string _idTipos = _tiposDeComprobantes;
			if (!(_tiposDeMovimientos.Equals(string.Empty))) 
			{ 
				_idTipos = _idTipos + ','+_tiposDeMovimientos; 
			}
			
			string _idUsuarios = Variables.GetValueString( "Cajas.Seguridad.Consultar.Usuarios" );
			string[] _usuarios = _idUsuarios.Split(',');
			ArrayList _arrayUsuarios = new ArrayList( _usuarios );
			_arrayUsuarios.Add( Security.IdUsuario );

			_filtroCajas = build_ArrayCajas( loadCajasAConsultar() );
			_filtroUsuarios = build_ArrayUsuarios( _arrayUsuarios );
			_filtroTipos = build_ArrayTipos( _idTipos.Split(',') );
			_filtroTDCompTesoreria = build_ArrayTDCompTesoreria();
			if(this._processParent.Process.ProcessName.Equals("ProcesoConsultarValoresCajas"))
			{
				_checkSoloAbiertas = false;
				_checkUltimaCaja = true;
			}

			_filtroFechaMovimiento = Variables.GetValueBool( this._processParent.Process.ProcessName, this._taskName, "filtroFechaMovimiento" );

		}
	
		
		private string ObtenerSigno (string idTipo)
		{
			string signo = string.Empty;
			
			mz.erp.commontypes.data.tsy_TiposMovimientosDataset.tsy_TiposMovimientosRow  row = tsy_TiposMovimientos.GetByPk(idTipo);
			if (row != null)
			{
				signo  = Convert.ToString(row.signo);
			}
			else 
			{
				mz.erp.commontypes.data.tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row2 = tsy_TiposDeComprobantes.GetByPk(idTipo);
				if (row2 != null)
					signo  = Convert.ToString(row2.signo);			
			}
			return signo;
		}

		#endregion
				
		#endregion

		#region Miembros de ITask

		

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

	
		
		public void ListenerTaskDependentChanged(object sender)
		{
			
			// TODO: agregar la implementación ConsultasDeCaja.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		
			}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}
		
		public void Init()
		{
			build_Parameters();	
		}


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			
			bool IsValid = true;
			_errores.Clear();	
			return false;
		}

	

		public bool AllowShow()
		{
			// TODO: agregar la implementación ConsultasDeCaja.AllowShow
			return false;
		}
		
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}
		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName=taskName;
		}

		public void Execute()
		{
			if (OnTaskBeforeExecute!= null)
				OnTaskBeforeExecute(this,new System.EventArgs() );
			if (OnTaskAfterExecute!= null)
				OnTaskAfterExecute(this,new System.EventArgs() );
		}
		public Movimiento GetMovimientoDeCaja()
		{	
			Movimiento result = new Movimiento();
			if (this.Data.Tables.Count > 0)
			{
				foreach(System.Data.DataRow _row in this.Data.Tables[0].Rows)
				{
					//string valor1 = Convert.ToString(_row["IdMovimiento"]);
					string valor1 = Convert.ToString(_row["IdValor"]);
					string valor2 = Convert.ToString( this.SelectedItem );

					if (valor1.CompareTo(valor2) == 0) 
					{
						result.IdValor = Convert.ToString(_row["IdValor"]);
						result.IdMovimientoOriginal = Convert.ToString( _row["IdMovimiento"] );
						result.Numero = Convert.ToString( _row["Numero"] );
						result.Observaciones = Convert.ToString( _row["Observaciones"]);
						result.IdInstanciaCaja = Convert.ToString( _row["IdInstanciaCaja"]);
						result.IdTipoDeMovimiento = Convert.ToString( _row["IdTipo"]);
						result.IdSubTipoMovimiento = Convert.ToString( _row["IdSubTipo"]);
						result.ValorMoneda = Convert.ToString(_row["IdMoneda"]);
						result.ValorTDCompTesoreria = Convert.ToString( _row["idTDCompTesoreria"]);
						result.ValorTotal = Convert.ToDecimal(_row["Importe"]);
						result.Fecha = Convert.ToDateTime(_row["Fecha"]);
						result.TipoComprobante = Convert.ToString(_row["Tipo"]); ///es recibo, ticket, fact.A
						result.Tabla = Convert.ToString(_row["Tabla"]);
					}
				}
			}
			return result; 
		}

		public Movimiento GetMovimientoDeCajaFromSelectedRow()
		{	
			Movimiento result = new Movimiento();
			if(this.SelectedItem != null)
			{
				DataRowView _row = (DataRowView)this.SelectedRow;
				result.IdValor = Convert.ToString(_row["IdValor"]);
				result.IdMovimientoOriginal = Convert.ToString( _row["IdMovimiento"] );
				result.Numero = Convert.ToString( _row["Numero"] );
				result.Observaciones = Convert.ToString( _row["Observaciones"]);
				result.IdInstanciaCaja = Convert.ToString( _row["IdInstanciaCaja"]);
				result.IdTipoDeMovimiento = Convert.ToString( _row["IdTipo"]);
				result.IdSubTipoMovimiento = Convert.ToString( _row["IdSubTipo"]);
				result.ValorMoneda = Convert.ToString(_row["IdMoneda"]);
				result.ValorTDCompTesoreria = Convert.ToString( _row["idTDCompTesoreria"]);
				result.ValorTotal = Convert.ToDecimal(_row["Importe"]);
				result.Fecha = Convert.ToDateTime(_row["Fecha"]);
				result.TipoComprobante = Convert.ToString(_row["Tipo"]); ///es recibo, ticket, fact.A
				result.Tabla = Convert.ToString(_row["Tabla"]);
			}
			return result; 
		}

		public bool AllowPrevious(){return false;}
		public void Previous(){;}
		public void ListenerAfterPreviousDependentTask( object sender ){;}
		public void ListenerBeforePreviousDependentTask( object sender ){;}

		#endregion

		public string GetFormText()
		{
			return Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "NombreSolapa");
		}

		public void RefreshData()
		{
			_idCajas = string.Empty;
			_idTipos = string.Empty;
			_idUsuarios = string.Empty;
			_idTDCompTesoreria = string.Empty;
			
			#region refresh filtro tipos de comprobantes
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroTDCompTesoreria )
			{
				if (items.Sel)
				{
					_idTDCompTesoreria+= items.Id +',';
				}
			}
			if (_idTDCompTesoreria.Equals(string.Empty))
			{
				_idTDCompTesoreria = null;
			}
			#endregion
			#region refresh filtro cajas
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroCajas )
			{
				if (items.Sel)
				{
					_idCajas+= items.Id +',';
				}
			}
			if (_idCajas.Equals(string.Empty))
			{
				_idCajas = null;
			}
			#endregion
			#region refresh filtro tipos 
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroTipos )
			{
				if (items.Sel)
				{
					_idTipos+= items.Id + ',';
				}
			}
			if (_idTipos.Equals(string.Empty))
			{
				_idTipos = null;
			}
			#endregion
			#region refresh filtro usuarios
			foreach( mz.erp.businessrules.ItemsFiltros items in this._filtroUsuarios )
			{
				if (items.Sel)
				{
					_idUsuarios+= items.Id+ ',' ;
				}
			}
			if (_idUsuarios.Equals( string.Empty ))
			{
				_idUsuarios = null;
			}
			#endregion
			#region refresh filtro fechas y min bloqueo

			string dias = Variables.GetValueString(_processParent.Process.ProcessName, _taskName, "DiasDeBloqueo"); 
			if ( dias != string.Empty && dias != "" )
			{
				if ( _fechaApertura.AddDays(Convert.ToDouble(dias)) < System.DateTime.Now) //la diferencia de dias entre hoy y la de apertura consultada es mayor a difDias?
					FechaApertura = System.DateTime.Now.AddDays(-Convert.ToDouble(dias));
			}
			if (_checkSoloAbiertas)
				this._data = this.ProcessReport( _idCajas,System.DateTime.MinValue,System.DateTime.MinValue, _idUsuarios,_idTipos,_idTDCompTesoreria , "Abiertas");
			else 
			{
				if (_checkSoloCerradas)
					this._data = this.ProcessReport( _idCajas,_fechaApertura,_fechaCierre, _idUsuarios,_idTipos,_idTDCompTesoreria, "Cerradas" );
				else 
				{
					if (_checkFechaMovimientos)
					{
                        this._data = this.ProcessReport( _idCajas, _fechaApertura, _fechaCierre, _idUsuarios, _idTipos, _idTDCompTesoreria, "FechaMovimiento" );
					}
					else // esta tildado que llame a todas
						this._data = this.ProcessReport( _idCajas,_fechaApertura,_fechaCierre, _idUsuarios,_idTipos,_idTDCompTesoreria, "Todas" );
				}
			}
			#endregion

			if (this.ObjectHasChanged != null)
			{
				this.ObjectHasChanged(this, new System.EventArgs() );
			}
		}

		public void ReiniciarFiltros()
		{
			this.build_Parameters();
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaApertura = fecha; }
            else { this._fechaCierre = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaCierre < fecha)
                {
                    _fechaCierre = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaApertura > fecha)
                {
                    _fechaApertura = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE  
        }
        //Fin Cristian 20110725
        //Fin Cristian
		private System.Data.DataSet ProcessReport(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string IdTDCompTesoreria, string EstadoCajas)
		{
			switch (this._taskName)
			{
				case "ConsultarPosicionCajaAnterior":
				{
					return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeCajaAnterior( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					break;
				}
				case "ConsultarPosicionCaja":
				{
					return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeCaja( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					break;
				}
				case "ConsultasCobranzasYPagos":
				{
					switch( EstadoCajas )
					{
						case "Abiertas":
						{
							return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagosAbiertas( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
							break;
						}
						case "Cerradas":
						{
							return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagosCerradas( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
							break;
						}
						case "Todas":
						{
							return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagosTodas( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
							break;
						}
						case "FechaMovimiento":
						{
							return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagosFechaMovimiento( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
							break;
						}
					}
					break;
				}
				case "ConsultasCobranzasYPagosAnterior": //Consulta Anterior
				 {
					 return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagos( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					 break;					
				 }
				case "ConsultarPosicionDeCajaDetallado":
				{
					return ProcessReportCajaDetallada( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, IdTDCompTesoreria, EstadoCajas );
					//return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeCaja( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					break;
				}

				case "ConsultarPosicionDeCajaDetalladoAnterior":
				{
					return ProcessReportCajaDetallada( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, IdTDCompTesoreria, EstadoCajas );
					//return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeCaja( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					break;
				}
				case "ConsultarValoresCajas":
				{
					if(IdCaja != null && !IdCaja.Equals(string.Empty))
					{
						DataTable table = mz.erp.dataaccess.tfi_Cajas.GetUltimaInstancia(IdCaja).Tables[0];
						DataSet data = null;
						foreach(DataRow row in table.Rows)
						{
							string IdInstanciaCaja = Convert.ToString(row["IdInstanciaCaja"]);
							if(data == null)
								data = mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeValoresCajas( IdTDCompTesoreria, IdInstanciaCaja);
							else data.Merge(mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeValoresCajas( IdTDCompTesoreria, IdInstanciaCaja));
						}
						return data;
					} // ---- Matias - 20090629
					else return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeValoresCajas( IdTDCompTesoreria, string.Empty);
					//else return new System.Data.DataSet();
					break;
				}
				case "ConsultarValoresCajasAnterior":
				{
					if(IdCaja != null && !IdCaja.Equals(string.Empty))
					{
						DataTable table = mz.erp.dataaccess.tfi_Cajas.GetUltimaInstancia(IdCaja).Tables[0];
						DataSet data = null;
						foreach(DataRow row in table.Rows)
						{
							string IdInstanciaCaja = Convert.ToString(row["IdInstanciaCaja"]);
							if(data == null)
								data = mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeValoresCajasAnterior( IdTDCompTesoreria, IdInstanciaCaja);
							else data.Merge(mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeValoresCajasAnterior( IdTDCompTesoreria, IdInstanciaCaja));
						}
						return data;
					}
					else return new System.Data.DataSet();
					break;
				}
				case "ConsultarMovimientosDeCaja":
				{
					if( _processParent.Process.ProcessName.Equals("ProcesoModificarValor"))
						return mz.erp.businessrules.reportes.ReportsFactory.ConsultaCobranzasYPagos( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					else
						return mz.erp.businessrules.reportes.ReportsFactory.ConsultaMovimientosDeCaja( IdCaja,fechaApertura, fechaCierre, IdResponsable,IdTipo, EstadoCajas );
					break;
				}
				default:
				{
					return new System.Data.DataSet();
				}
			}
			return null;
		}


		private System.Data.DataSet ProcessReportCajaDetallada(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string IdTDCompTesoreria, string EstadoCajas)
		{
			System.Data.DataSet _dataDetalle = new DataSet();
								
			string IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			string IdEntidades = null;
				
			if(this._taskName.Equals("ConsultarPosicionDeCajaDetallado"))
				_dataDetalle = mz.erp.businessrules.reportes.ReportsFactory.ConsultaPosicionDeCajaDetallado( IdMonedaReferencia, IdEntidades, IdTDCompTesoreria, fechaApertura, fechaCierre, IdResponsable, "Abierta",IdCaja, EstadoCajas);
			if(this._taskName.Equals("ConsultarPosicionDeCajaDetalladoAnterior"))
				_dataDetalle = mz.erp.businessrules.reportes.ReportsFactory.ConsultaPosicionDeCajaDetalladoAnterior( IdMonedaReferencia, IdEntidades, IdTDCompTesoreria, fechaApertura, fechaCierre, IdResponsable, "Abierta",IdCaja, EstadoCajas);
			
			return _dataDetalle;
		}

	
	
	}
}
