using System;
using System.Data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers
{
	public class mzCuentasObservacionesSearchFormController: ITaskController
	{
		public mzCuentasObservacionesSearchFormController()
		{						
			//Init();
		}
		
		public mzCuentasObservacionesSearchFormController(mzCuentasObservacionesSearchForm brClass)
		{
			_brClass = brClass;	
			Init();
		}
		
		//#region Propiedades públicas
		//#region Propiedades de búsqueda

		private DataTable _usuarios = null;
		public System.Data.DataTable Usuarios
		{
			get {return _usuarios;}
		}

		private DataTable _estados = null;
		public System.Data.DataTable Estados 
		{
			get {return _estados;}
		}

		private DataTable _tipos = null;
		public System.Data.DataTable Tipos
		{
			get {return _tipos;}
		}

		private DataTable _subTipos = new DataTable();
		public System.Data.DataTable SubTipos
		{
			get { 
                return _subTipos;
            }
		}

		private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
		public DateTime FechaDesde 
		{
			get { return _fechaDesde;}
			set { 
				_fechaDesde = value;
			}
		}

		private DateTime _fechaHasta = DateTime.Now;
		public DateTime FechaHasta
		{
			get { return _fechaHasta;}
			set 
			{ 
				_fechaHasta = value;
			}
		}	
		
			
		private string _idTipo = String.Empty;
		public string IdTipo
		{
			get { return _idTipo;}
			set 
			{ 
				_idTipo = value;
				GetSubTipos();
				if(TiposHasChanged != null)
					TiposHasChanged(this,new EventArgs());
			}
		}

		private string _idTipoDefault = String.Empty;
		public string IdTipoDefault
		{
			get { return _idTipoDefault;}
			set 
			{ 
				_idTipoDefault = value;
			}
		}		

		private string _idSubTipo = String.Empty;
		public string IdSubTipo
		{
			get { return _idSubTipo;}
			set { _idSubTipo = value;}
		}
		private string _idEstado = String.Empty;
		public string IdEstado
		{
			get { return _idEstado;}
			set { _idEstado = value;}
		}
		//private string _idUsuario = String.Empty;
		//Para q por defecto este seleccionado el usuario actual,se hace porq el control usa binding
		private string _idUsuario=Security.IdUsuario;
		public string IdUsuario
		{
			get { return _idUsuario;}
			set { _idUsuario = value;}
		}
		private int _cantidadSubTipos = 0;
		public int CantidadSubTipos
		{
			get { return _cantidadSubTipos;}
			set { _cantidadSubTipos = value;}
		}

		private bool _byFechas = false;
		public bool ByFechas
		{
			get{return _byFechas;}
			set{_byFechas = value;}
		}

		private bool _byCuenta = true;
		public bool ByCuenta
		{
			get{return _byCuenta;}
			set{_byCuenta = value;}
		}

		private string _origen = "ESPECIFICO";
		public string Origen 
		{
			get {return _origen;}
			set {_origen = value;}
		}

		
		public string IdCuentaObservacion 
		{
			get 
			{
				return _brClass.IdCuentaObservacion;
			}
			set  
			{
				_brClass.IdCuentaObservacion = value;
			}
		}

		public string IdProveedorObservacion 
		{
			get 
			{
				return _brClass.IdProveedorObservacion;
			}
			set  
			{
				_brClass.IdProveedorObservacion = value;
			}
		}

		public bool PermiteObservacionesOtrosUser 
		{
			get 
			{
				if(_brClass != null)
					return _brClass.PermiteObservacionesOtrosUser;
				return true;
			}
			
		}

		private bool _verAvisosPendientes = false;
		public bool VerAvisosPendientes
		{
			set { _verAvisosPendientes = value ; }
			get { return _verAvisosPendientes;} 
		}

		private string _proceso = "ProcesoConsultarCuentasObservaciones";
		public string Proceso
		{		
			get { return _proceso;} 
		}
		private string _tarea = "ConsultarCuentasObservaciones";
		public string Tarea
		{		
			get { return _tarea;} 
		}		
		//#endregion

		#region Propiedades de controles
		
		private System.Data.DataView _dataSearch = new DataView();
		public System.Data.DataView DataSearch
		{
			get { return _dataSearch ; }
		}
		public string KeyValueEstados
		{
			get { return "IdCuentaObservacionEstado" ; }
		}
		public string KeyListEstados
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueTipos
		{
			get { return "IdCuentaObservacionTipo" ; }
		}
		public string KeyListTipos
		{
			get { return "Descripcion" ; }
		}
		public string KeyValueEstadosProveedores
		{
			get { return "IdProveedorObservacionEstado" ; }
		}
		public string KeyValueTiposProveedores
		{
			get { return "IdProveedorObservacionTipo" ; }
		}
		public string KeyValueUsuarios
		{
			get { return "IdUsuario" ; }
		}				
		public string KeyListUsuarios
		{
			get { return "Nombre" ; }
		}

		#endregion

		//#region Propiedades de cuenta
		private string _idCuenta = string.Empty;
		public string IdCuenta
		{
			get { return _idCuenta; }
			set {//_idCuenta = value; 
				if (value != _idCuenta)
				{					
					_idCuenta = value;

					if (this.IdCuentaChanged != null)
						IdCuentaChanged (this, new EventArgs());
				}
			}
		}
		private string _codigoCuenta = String.Empty;
		public string CodigoCuenta
		{			
			get { return _codigoCuenta ; }
			set 
			{ 	
				if (value != _codigoCuenta)
				{					
					_codigoCuenta = value;
					if (this.CodigoCuentaChanged != null)
						CodigoCuentaChanged (this, new EventArgs());
				}	

			}
		}
		private string _nombre = String.Empty;
		public string Nombre
		{
			get { return _nombre; }			
		}		
		//#endregion				
		//#endregion

		private string _idProveedor = String.Empty;
		public string IdProveedor
		{			
			get { return _idProveedor ; }
			set { //_idProveedor = value; 
				if (value != _idProveedor)
				{					
					_idProveedor = value;

					if (this.IdProveedorChanged != null)
						IdProveedorChanged (this, new EventArgs());
				}
			}
		}

		private string _codigoProveedor = String.Empty;
		public string CodigoProveedor
		{			
			get { return _codigoProveedor ; }
			set 
			{ 
				if (value != _codigoProveedor)
				{					
					_codigoProveedor = value;
                    /* Silvina 20100923 - Tarea 843 */
					/*if (this.CodigoProveedorChanged != null)
						CodigoProveedorChanged (this, new EventArgs());*/
                    /* Fin Silvina */
				}				
			}
		}
		private string _tipo = String.Empty;
		public string Tipo
		{			
			get { return _tipo ; }
			set {_tipo = value;}
		}

		#region Variables privadas
		decimal _cantDiasDesde = 60; //Variables.GetValueDecimal(".RangoFechas.DiasAnteriores")			
		decimal _cantDiasHasta = 0; //Variables.GetValueDecimal(".RangoFechas.DiasPosteriores");					
		
		private businessrules.mzCuentasObservacionesSearchForm _brClass;
		#endregion
		
		#region Métodos públicos
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._proceso, this._tarea, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

            

        }
        //Fin Cristian 0000146
        //Fin Cristian
		
        public void BuscarAhora()
		{				  
			if (ByFechas)
			{
				_fechaDesde = systemframework.Util.GetStartDay(_fechaDesde);
				_fechaHasta = systemframework.Util.GetEndDay(_fechaHasta);	
			}
			else
			{
				_fechaDesde = DateTime.MinValue;
				_fechaHasta = DateTime.MinValue;
			}
			if (this._origen == "GENERAL" )
			{
				if (ByCuenta) 
				{
					if(_tipo.Equals("CUENTA"))
					{
						if (_codigoCuenta != String.Empty) 
						{
							businessrules.Cuenta cuenta = new mz.erp.businessrules.Cuenta();
							cuenta.GetCuenta_CodigoCuenta(_codigoCuenta);
							_idCuenta = cuenta.IdCuenta;
						}		
					}
					else
					{
						if (_codigoProveedor != String.Empty) 
						{
							businessrules.Proveedor prov = new mz.erp.businessrules.Proveedor();
							prov.GetCuenta_CodigoProveedor(_codigoProveedor);
							_idProveedor = prov.IdProveedor;

						}		
					}
				}
				else 
				{
					if(_tipo.Equals("CUENTA"))
						_idCuenta = String.Empty;
					else if(_tipo.Equals("PROVEEDOR"))
						_idProveedor = String.Empty;
				}
			}
			else 
			{
				//this._origen es "GENERAL". IdCuenta ya vino desde el constructor. 
			}
			
			string IdResponsable = String.Empty;
			if (_idUsuario != String.Empty)
					IdResponsable = sy_Usuarios.GetByPk(_idUsuario).IdPersona;
			
			DataTable tabla = null;
			if(_tipo.Equals("CUENTA"))
				tabla = mz.erp.businessrules.tsa_CuentasObservaciones.GetListEx(_idCuenta, _fechaDesde, _fechaHasta, _idTipo, _idSubTipo, _idEstado, IdResponsable);
			else
                tabla = mz.erp.businessrules.tpu_ProveedoresObservaciones.GetListEx(_idProveedor, _fechaDesde, _fechaHasta, _idTipo, _idSubTipo, _idEstado, IdResponsable);
			string rowFilter;
			if (_verAvisosPendientes)
				rowFilter = String.Format("FechaAviso <= '{0}' AND FechaVencimiento >= '{0}'",DateTime.Now);				
			else
				rowFilter = "";

			DataView view = new DataView(tabla, rowFilter,"",System.Data.DataViewRowState.OriginalRows);
			_dataSearch = view;

			if (DataSearchChanged != null)
			{
				DataSearchChanged( this, new System.EventArgs() );
			}
		}		
		
		public void VerDetalle( System.Data.DataRowView _dataRowSelected )
		{
			CallRefresh();
		}		
		public void GetCuenta() 
		{
			businessrules.Cuenta cuenta = new mz.erp.businessrules.Cuenta(_idCuenta);
			_nombre = cuenta.Nombre;
		}
		public string GetLayout(bool ConCliente) 
		{
			if (ConCliente) 
			{
				return (new mz.erp.ui.controllers.tsa_CuentasObservaciones( new string[] {"IdCuentaObservacion", "Nombre", "Titulo", "Observacion", "Fecha", "Usuario", "Estado", "Tipo", "SubTipo", "FechaVencimiento", "FechaAviso"}).GetLayoutEx()); 
			}
			else
			{
				return (new mz.erp.ui.controllers.tsa_CuentasObservaciones( new string[] {"IdCuentaObservacion", "Titulo", "Observacion", "Fecha", "Usuario", "Estado", "Tipo", "SubTipo", "FechaVencimiento", "FechaAviso"}).GetLayoutEx()); 
			}			
		}

		public string GetLayoutProveedores(bool ConProveedor) 
		{
			if (ConProveedor) 
			{
				return (new mz.erp.ui.controllers.tpu_PorveedoresObservaciones( new string[] {"IdProveedorObservacion", "Nombre", "Titulo", "Observacion", "Fecha", "Usuario", "Estado", "Tipo", "SubTipo", "FechaVencimiento", "FechaAviso"}).GetLayoutEx()); 
			}
			else
			{
				return (new mz.erp.ui.controllers.tpu_PorveedoresObservaciones( new string[] {"IdProveedorObservacion", "Titulo", "Observacion", "Fecha", "Usuario", "Estado", "Tipo", "SubTipo", "FechaVencimiento", "FechaAviso"}).GetLayoutEx()); 
			}			
		}
		#endregion
		#region Métodos privados
		
		private void CallRefresh()
		{
		}
		private void GetSubTipos()
		{		
			if(_tipo.Equals("CUENTA"))
			{
				_subTipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetListSubTiposPerfil(_idTipo, "Ver").tsa_CuentasObservacionesTipos;												
				if (_subTipos.Rows.Count >= 1)			
				{
					DataRow row = _subTipos.NewRow();					
					row["IdCuentaObservacionTipo"] = String.Empty;
                    /* Silvina 20110608 - Tarea 0000065 */
					row["Descripcion"] = "Todos";                    
                    row["Activo"] = true;
                    /* Fin Silvina 20110608 - Tarea 0000065 */
					_subTipos.Rows.Add(row);				
				}
				_cantidadSubTipos = _subTipos.Rows.Count;

				if (_cantidadSubTipos == 1)
				{
					_idSubTipo = Convert.ToString(_subTipos.Rows[0]["IdCuentaObservacionTipo"]);
				}
				else 
				{
					_idSubTipo = string.Empty;		
				}
			}
			else if(_tipo.Equals("PROVEEDOR"))
			{
				_subTipos = tpu_ProveedoresObservacionesTipos.GetListSubTiposPerfil(_idTipo, "Ver").tpu_ProveedoresObservacionesTipos;			
				if (_subTipos.Rows.Count == 1)
				{
					DataRow row = _subTipos.NewRow();					
					row["IdProveedorObservacionTipo"] = String.Empty;
                    /* Silvina 20110608 - Tarea 0000065 */
                    row["Descripcion"] = "Todos";
                    row["Activo"] = true;
                    /* Fin Silvina 20110608 - Tarea 0000065 */
					_subTipos.Rows.Add(row);				
				}
				_cantidadSubTipos = _subTipos.Rows.Count;

				if (_cantidadSubTipos == 1)
				{
					_idSubTipo = Convert.ToString(_subTipos.Rows[0]["IdProveedorObservacionTipo"]);
				}
				else 
				{
					_idSubTipo = string.Empty;		
				}

			}

		}
		public void Init() 
		{
			string Proceso = "";
			string Tarea = "";
			if (_brClass != null)
			{
				Proceso = _brClass.GetProcessName();
				Tarea = _brClass.GetTaskName();
				if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
					_tipo = "CUENTA";
				else
					_tipo = "PROVEEDOR";

			}
			else
			{
				Proceso = _proceso;
				Tarea = _tarea;
			}			
			if(_tipo.Equals("CUENTA"))
			{
				_tipos = mz.erp.businessrules.tsa_CuentasObservacionesTipos.GetListTiposPerfil("Ver").tsa_CuentasObservacionesTipos;
				DataRow row = _tipos.NewRow();
				row["IdCuentaObservacionTipo"] = String.Empty;
				row["Descripcion"] = String.Empty;
				_tipos.Rows.Add(row);			

				_estados = mz.erp.businessrules.tsa_CuentasObservacionesEstados.GetList().tsa_CuentasObservacionesEstados;		
				_estados = VariablesListComparer.FilterDataTable(Proceso, Tarea, "ListaCuentasObservacionesEstados", "IdCuentaObservacionEstado", _estados);

				DataRow rowE = _estados.NewRow();					
				rowE["IdCuentaObservacionEstado"] = String.Empty;
				rowE["Descripcion"] = String.Empty;
				_estados.Rows.Add(rowE);

				string valor = Variables.GetValueString("CuentasObservaciones.Busquedas.TipoDefault");						
				foreach (DataRow rowTipos in _tipos.Rows) 
				{
					if (Convert.ToString(rowTipos["IdCuentaObservacionTipo"]) == valor)
						_idTipoDefault = valor;
				}

			}
			else if(_tipo.Equals("PROVEEDOR"))
			{
				_tipos = tpu_ProveedoresObservacionesTipos.GetListTiposPerfil("Add").tpu_ProveedoresObservacionesTipos;
				DataRow row = _tipos.NewRow();
				row["IdProveedorObservacionTipo"] = String.Empty;
				row["Descripcion"] = String.Empty;
				_tipos.Rows.Add(row);			

				_estados = mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.GetList().tpu_ProveedoresObservacionesEstados;		
				_estados = businessrules.VariablesListComparer.FilterDataTable(Proceso, Tarea, "ListaProveedoresObservacionesEstados", "IdProveedorObservacionEstado", _estados);
				DataRow rowE = _estados.NewRow();					
				rowE["IdProveedorObservacionEstado"] = String.Empty;
				rowE["Descripcion"] = String.Empty;
				_estados.Rows.Add(rowE);

				string valor = Variables.GetValueString("ProveedoresObservaciones.Busquedas.TipoDefault");						
				foreach (DataRow rowTipos in _tipos.Rows) 
				{
					if (Convert.ToString(rowTipos["IdProveedorObservacionTipo"]) == valor)
						_idTipoDefault = valor;
				}

			}

			_usuarios = sy_Usuarios.GetList().sy_Usuarios;			
			DataRow rowU = _usuarios.NewRow();					
			rowU["IdUsuario"] = String.Empty;
			rowU["Nombre"] = String.Empty;
			rowU["Clave"] = ".";
			rowU["IdConexionCreacion"] = 1;
			rowU["FechaCreacion"] = DateTime.Now;
			rowU["IntentosPermitidosConexion"] = 0;
			rowU["vencimientoclave"] = DateTime.Now;
			rowU["cantidadConexionesFallida"] = 0;
			_usuarios.Rows.Add(rowU);
			_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays((-1)* Convert.ToDouble(_cantDiasDesde)); 						
			_fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(Convert.ToDouble(_cantDiasHasta));			

		}	
		#endregion

		#region Eventos
		public event EventHandler DataSearchChanged;	
		public event EventHandler CodigoCuentaChanged;
		public event EventHandler IdTipoChanged;
		public event EventHandler IdSubTipoChanged;
		public event EventHandler IdEstadoChanged;
		public event EventHandler IdUsuarioChanged;
		public event EventHandler FechaDesdeChanged;
		public event EventHandler FechaHastaChanged;
		public event EventHandler TiposHasChanged;		
		public event EventHandler ByFechasChanged;
		public event EventHandler ByCuentaChanged;
		public event EventHandler VerAvisosPendientesChanged;
		public event EventHandler CodigoProveedorChanged;	
		public event EventHandler IdCuentaChanged;
		public event EventHandler IdProveedorChanged;

		#endregion
		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());			
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());			
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

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();			
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();			
		}



		public ITask GetTask()
		{
			return _brClass;			
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();			
		}		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();			
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();			
		}
		public void Continue()
		{
			_brClass.Execute();
		}
		public event EventHandler OnTaskAfterExecute;

		#endregion
	}
}
