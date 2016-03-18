using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarMovimientosDeCajas.
	/// </summary>
	public class ConsultarMovimientosDeCajas: ITask
	{
		

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion


		#region Miembros de ITask


		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual void Init()
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

		public virtual bool IsValid()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool AllowShow() 
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

		public virtual string GetWarnings()
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
			_taskName = taskName;
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

		public virtual void Previous()
		{

			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region CUSTOM MEMBERS
	
		#region CONSTRUCTOR
	
		public ConsultarMovimientosDeCajas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region VARIABLES PRIVADAS
		

		private object _selectedItem;
		private Movimiento _movimiento = new Movimiento();

		private DateTime _fechaApertura = mz.erp.systemframework.Util.GetStartDay(mz.erp.businessrules.Sistema.DateTime.Now);
		private DateTime _fechaCierre = mz.erp.systemframework.Util.GetEndDay(mz.erp.businessrules.Sistema.DateTime.Now);
		private bool _porFechas = true;
		private ArrayList _filtroTipos;
		private ArrayList _filtroTDCompTesoreria;
		private ArrayList _filtroCajas;
		private DataSet _data = null;
		private string _idCajas = string.Empty;
		private string _idTipos = string.Empty;
		private string _idTDCompTesoreria = string.Empty;
		private string _idTiposDeMovimientosDefault = string.Empty;
		private bool _allowIdTiposDeMovimientosSistema = false;

		#endregion
		
		#region ACCESO A VARIABLES
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
		public bool PorFechas
		{
			get { return _porFechas; }
			set { _porFechas = value;}
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
		
		#endregion

		#region EVENTOS

		public event System.EventHandler FechaAperturaChanged;
		public event System.EventHandler FechaCierreChanged;


		#endregion
		
		#region BUILD ARRAY ...
		private ArrayList build_ArrayTipos(string[] _rango)
		{
			ArrayList _arrayTipos = new ArrayList();
			Hashtable _hash = tfi_Cajas.GetTiposDeMovimientosDeCaja(_idTiposDeMovimientosDefault,System.Int16.MinValue, _allowIdTiposDeMovimientosSistema);
			for(int i=0;i<_rango.Length;i++)
			{
				if (_hash.ContainsKey( Convert.ToString( _rango[i] ) ))
				{
					_arrayTipos.Add( new ItemsFiltros(Convert.ToString(_rango[i]), Convert.ToString(_hash[_rango[i]]), true, ObtenerSigno(_rango[i]) )  );
				}
			}
			return _arrayTipos;
		}


		
	

		private ArrayList build_ArrayTDCompTesoreria( )
		{
			ArrayList _arrayTDCompTesoreria = new ArrayList();
			mz.erp.commontypes.data.tfi_TDCompTesoreriaDataset _tableTDCompTesoreria = mz.erp.businessrules.tfi_TDCompTesoreria.GetList();
			foreach( System.Data.DataRow _row in _tableTDCompTesoreria.tfi_TDCompTesoreria.Rows )
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
        //Fin Cristian Tarea 0000146
        //Fin Cristian
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
			_idTiposDeMovimientosDefault = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName, "ListaTiposDeMovimientos");
			_allowIdTiposDeMovimientosSistema = Variables.GetValueBool(this._processParent.Process.ProcessName,this._taskName, "PermiteTiposDeMovimientosDelSistema");
			mz.erp.commontypes.data.tsy_TiposMovimientosDataset _tiposMov = mz.erp.businessrules.tsy_TiposMovimientos.GetList();
			string _tiposDeMovimientos = String.Empty;
			for (int i=0 ; i < _tiposMov.tsy_TiposMovimientos.Rows.Count; i++)
			{
				_tiposDeMovimientos = _tiposDeMovimientos + ','+ Convert.ToString(_tiposMov.tsy_TiposMovimientos[i]["IdTipoMovimiento"]);	
			}
			_filtroCajas = build_ArrayCajas( loadCajasAConsultar() );
			_filtroTipos = build_ArrayTipos( _tiposDeMovimientos.Split(',') );
			_filtroTDCompTesoreria = build_ArrayTDCompTesoreria();
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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


		public string GetFormText()
		{
			return Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "NombreSolapa");
		}

		public void RefreshData()
		{
			_idCajas = string.Empty;
			_idTipos = string.Empty;
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
			
			#region refresh filtro fechas y min bloqueo

			if(_porFechas)
			{
				string dias = Variables.GetValueString(_processParent.Process.ProcessName, _taskName, "DiasDeBloqueo"); 
				if ( dias != string.Empty && dias != "" )
				{
					if ( _fechaApertura.AddDays(Convert.ToDouble(dias)) < System.DateTime.Now) //la diferencia de dias entre hoy y la de apertura consultada es mayor a difDias?
						FechaApertura = System.DateTime.Now.AddDays(-Convert.ToDouble(dias));
				}
				this._data = this.ProcessReport( _idCajas,_fechaApertura,_fechaCierre, _idTipos,_idTDCompTesoreria );
			}
			else
			
				this._data = this.ProcessReport( _idCajas,System.DateTime.MinValue,System.DateTime.MinValue, _idTipos,_idTDCompTesoreria );
			
			#endregion

			if (this.ObjectHasChanged != null)
			{
				this.ObjectHasChanged(this, new System.EventArgs() );
			}
		}
	
		private System.Data.DataSet ProcessReport(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdTipo, string IdTDCompTesoreria)
		{
			switch (this._taskName)
			{
				case "ConsultarGastos":
				{
					return mz.erp.businessrules.reportes.ReportsFactory.ConsultaDeGastos( IdCaja,fechaApertura, fechaCierre, IdTipo );
					break;
				}
				default:
				{
					return new System.Data.DataSet();
				}
			}
			return null;
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
	
	}
}
