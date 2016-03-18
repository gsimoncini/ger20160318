using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using System.Xml.Serialization;
using System.Xml; 
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConfiguracionStyleGrilla.
	/// </summary>
	public class ConfiguracionStyleGrilla
	{
		#region Constructores
		public ConfiguracionStyleGrilla()
		{
			SetCombosData();
		}
		#endregion

		#region Variables Privadas
		tui_ConfiguracionGrillaEstilosAplicablesExDataset _data = new tui_ConfiguracionGrillaEstilosAplicablesExDataset();
		tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset _dataPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset();
		tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset _dataUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset();
		tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset _dataModificables = new tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset();
		tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset _dataModificablesUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset();
		tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset _dataModificablesPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset();
		tui_ConfiguracionGrillaEstiloAplicadoDataset _dataAplicado = new tui_ConfiguracionGrillaEstiloAplicadoDataset();
		tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset _dataPerfilesAplicado = new tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset();
		tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset _dataUsuariosAplicado = new tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset();
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler CondicionesHasChanged;
		public event System.EventHandler ConfiguracionGrillaHasChanged;
		public event System.EventHandler ConfiguracionesHasChanged;
		#endregion

		#region Propiedades		

		private string _leyendaFormulario = Variables.GetValueString("Grillas.EstilosCondicionales.PrefijoTitulo");
		public string LeyendaFormulario
		{
			get{return _leyendaFormulario + " " + _tituloFormularioPadre;}
		}

		ArrayList _columnas = new ArrayList();
		public ArrayList Columnas
		{
			get{return _columnas;}
			set{_columnas = value;}
		}

		ArrayList _columnasString;
		public ArrayList ColumnasString
		{
			get
			{
				if(_columnasString == null)
					_columnasString = GetColumnas(ColumnaView.StringType);
				return _columnasString;
			}
		}

		ArrayList _columnasInt;
		public ArrayList ColumnasInt
		{
			get
			{
				if(_columnasInt == null)
					_columnasInt = GetColumnas(ColumnaView.IntType);
				return _columnasInt;
			}
		}
		
		
		ArrayList _columnasDecimal;
		public ArrayList ColumnasDecimal
		{
			get
			{
				if(_columnasDecimal == null)
					_columnasDecimal = GetColumnas(ColumnaView.DecimalType);
				return _columnasDecimal;
			}
		}
		
		ArrayList _columnasBool;
		public ArrayList ColumnasBool
		{
			get
			{
				if(_columnasBool == null)
					_columnasBool = GetColumnas(ColumnaView.BoolType);
				return _columnasBool;
			}
		}

		ArrayList _columnasDateTime;
		public ArrayList ColumnasDateTime
		{
			get
			{
				if(_columnasDateTime == null)
					_columnasDateTime = GetColumnas(ColumnaView.DateTimeType);
				return _columnasDateTime;
			}
		}

		private string _condicion = string.Empty;
		public string Condicion
		{
			get {return _condicion;}
			set {_condicion = value;}
		}

		public ArrayList Configuraciones
		{
			get 
			{
				if(_configuracionSeleccionada != null)
					return _configuracionSeleccionada.Detalle;
				else
					return new ArrayList();

			}
		}

		public string NombreConfiguracion
		{
			get
			{
				if(_configuracionSeleccionada != null)
					return _configuracionSeleccionada.Nombre;
				else
					return string.Empty;
			}
			set
			{
				if(_configuracionSeleccionada != null && !_configuracionSeleccionada.Nombre.Equals(value))
				{
					_configuracionSeleccionada.Nombre = value;
				}
			}
		}

		private string _processName = string.Empty;
		public string ProcessName
		{
			get{return _processName;}
			set{_processName = value;}
		}

		private string _taskName = string.Empty;
		public string TaskName
		{
			get{return _taskName;}
			set{_taskName = value;}
		}
		
		private string _formulario = string.Empty;
		public string Formulario
		{
			get{return _formulario;}
			set{_formulario = value;}
		}

		private string _tituloFormularioPadre = string.Empty;
		public string TituloFormularioPadre
		{
			get{return _tituloFormularioPadre;}
			set{_tituloFormularioPadre = value;}
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}

		ArrayList _perfiles = new ArrayList();
		public ArrayList Perfiles
		{
			get 
			{
				return _perfiles;
			}
		}

		ArrayList _perfilesSeleccionados = new ArrayList();
		public ArrayList PerfilesSeleccionados
		{
			get{return _perfilesSeleccionados;}
			set 
			{
				_perfilesSeleccionados = value;
			}
		}

		ArrayList _perfilesAplicablesSeleccionados = new ArrayList();
		public ArrayList PerfilesAplicablesSeleccionados
		{
			get{return _perfilesAplicablesSeleccionados;}
			set 
			{
				_perfilesAplicablesSeleccionados = value;
			}
		}

		ArrayList _perfilesAplicablesModificablesSeleccionados = new ArrayList();
		public ArrayList PerfilesAplicablesModificablesSeleccionados
		{
			get{return _perfilesAplicablesModificablesSeleccionados;}
			set 
			{
				_perfilesAplicablesModificablesSeleccionados = value;
			}
		}

		ArrayList _usuarios = new ArrayList();
		public ArrayList Usuarios
		{
			get 
			{
				return _usuarios;
			}
		}

		ArrayList _usuariosSeleccionados = new ArrayList();
		public ArrayList UsuariosSeleccionados
		{
			get{return _usuariosSeleccionados;}
			set 
			{
				_usuariosSeleccionados = value;
			}
		}

		ArrayList _usuariosAplicablesSeleccionados = new ArrayList();
		public ArrayList UsuariosAplicablesSeleccionados
		{
			get{return _usuariosAplicablesSeleccionados;}
			set 
			{
				_usuariosAplicablesSeleccionados = value;
			}
		}

		ArrayList _usuariosAplicablesModificablesSeleccionados = new ArrayList();
		public ArrayList UsuariosAplicablesModificablesSeleccionados
		{
			get{return _usuariosAplicablesModificablesSeleccionados;}
			set 
			{
				_usuariosAplicablesModificablesSeleccionados = value;
			}
		}


		private bool _permiteModificarAplicacion = false;
		public bool PermiteModificarAplicacion
		{
			get{return _permiteModificarAplicacion;}
		}

		private bool _todos = false;	
		public bool Todos
		{
			get{return _todos;}
			set{_todos = value;}
		}

		private bool _porUsuario = false;	
		public bool PorUsuario
		{
			get{return _porUsuario;}
			set{_porUsuario = value;}
		}

		private bool _porPerfil = false;	
		public bool PorPerfil
		{
			get{return _porPerfil;}
			set{_porPerfil = value;}
		}

		private bool _todosAplicables = false;	
		public bool TodosAplicables
		{
			get{return _todosAplicables;}
			set{_todosAplicables = value;}
		}

		private bool _porUsuarioAplicables = false;	
		public bool PorUsuarioAplicables
		{
			get{return _porUsuarioAplicables;}
			set{_porUsuarioAplicables = value;}
		}

		private bool _porPerfilAplicables = false;	
		public bool PorPerfilAplicables
		{
			get{return _porPerfilAplicables;}
			set{_porPerfilAplicables = value;}
		}

		private bool _todosModificables = false;	
		public bool TodosModificables
		{
			get{return _todosModificables;}
			set{_todosModificables = value;}
		}

		private bool _porUsuarioModificables = false;	
		public bool PorUsuarioModificables
		{
			get{return _porUsuarioModificables;}
			set{_porUsuarioModificables = value;}
		}

		private bool _porPerfilModificables = false;	
		public bool PorPerfilModificables
		{
			get{return _porPerfilModificables;}
			set{_porPerfilModificables = value;}
		}

		private string _modoDeAplicacionDefault = "U";
		public string ModoDeAplicacionDefault
		{
			get{return _modoDeAplicacionDefault;}
		}

		private Hashtable _configuracionesAplicables = new Hashtable();
		public Hashtable ConfiguracionesAplicables
		{
			get{return _configuracionesAplicables;}
			set{_configuracionesAplicables = value;}
		}


		private ConfiguracionGrillaEstilosCondicionales _configuracionSeleccionada = null;
		public ConfiguracionGrillaEstilosCondicionales ConfiguracionSeleccionada
		{
			get{return _configuracionSeleccionada;}
			set
			{
				_configuracionSeleccionada = value;
				if(CondicionesHasChanged != null)
					CondicionesHasChanged(this, new EventArgs());	
			}
		}

		public long IdConfiguracionSeleccionada
		{
			get
			{
				if(_configuracionSeleccionada != null)
					return _configuracionSeleccionada.IdConfiguracion;
				else
					return long.MinValue;
			}
			set
			{
				/*if(_configuracionSeleccionada == null || _configuracionSeleccionada.IdConfiguracion != value)
				{*/
					ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[value];
				//}
			}
		}

		private long _idConfiguracionAplicada = long.MinValue;
		public long IdConfiguracionAplicada
		{
			get{return _idConfiguracionAplicada;}
			set{_idConfiguracionAplicada = value;}
		}

		private bool _permiteModificarAplicables = false;
		public bool PermiteModificarAplicables
		{
			get{return _permiteModificarAplicables;}
		}

		private string _modoAplicableDefault = "T";
		public string ModoAplicableDefault
		{
			get{return _modoAplicableDefault;}
		}

		private bool _permiteModificarAplicablesModificables = false;
		public bool PermiteModificarAplicablesModificables
		{
			get{return _permiteModificarAplicablesModificables;}
		}

		private string _modoAplicableModificableDefault = "U";
		public string ModoAplicableModificableDefault
		{
			get{return _modoAplicableModificableDefault;}
		}

		private string _cantidadMaximaConfiguracionPorUsuario = "10";
		public string CantidadMaximaConfiguracionPorUsuario
		{
			get{return _cantidadMaximaConfiguracionPorUsuario;}
		}

		private bool _permiteBorrarConfiguracionDeOtroUsuario = Variables.GetValueBool("Grillas.EstilosCondicionales.PermiteBorrarConfiguracionDeOtroUsuario");
		public bool PermiteBorrarConfiguracionDeOtroUsuario
		{
			get{return _permiteBorrarConfiguracionDeOtroUsuario;}
		}

		private bool _permiteBorradoEnCascada = Variables.GetValueBool("Grillas.EstilosCondicionales.BorradoEnCascada");
		public bool PermiteBorradoEnCascada
		{
			get{return _permiteBorradoEnCascada;}
		}

		private int _cantidadMaximaConfiguracionesVisiblesEnCombo = 7;
		public int CantidadMaximaConfiguracionesVisiblesEnCombo
		{
			get{return _cantidadMaximaConfiguracionesVisiblesEnCombo;}
		}

		#endregion

		#region Métodos Públicos

		public void InitVariables()
		{
			object valorCantidadMaximaConfiguracionesVisiblesEnCombo = null;
			string variableCantidadMaximaConfiguracionesVisiblesEnCombo = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.CantidadMaximaConfiguracionesVisiblesEnCombo";
			valorCantidadMaximaConfiguracionesVisiblesEnCombo = Variables.GetValue(variableCantidadMaximaConfiguracionesVisiblesEnCombo);
			if(valorCantidadMaximaConfiguracionesVisiblesEnCombo == null)
				valorCantidadMaximaConfiguracionesVisiblesEnCombo = Variables.GetValue("Grillas.EstilosCondicionales.CantidadMaximaConfiguracionesVisiblesEnCombo");
			if(valorCantidadMaximaConfiguracionesVisiblesEnCombo != null)
				_cantidadMaximaConfiguracionesVisiblesEnCombo = Convert.ToInt16(valorCantidadMaximaConfiguracionesVisiblesEnCombo);
			else
				_cantidadMaximaConfiguracionesVisiblesEnCombo = 7;

			object valorPermiteModificarAplicacion = null;
			string variablePermiteModificarAplicacion = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.PermiteModificarAplicacion";
			valorPermiteModificarAplicacion = Variables.GetValue(variablePermiteModificarAplicacion);
			if(valorPermiteModificarAplicacion == null)
				_permiteModificarAplicacion = Variables.GetValueBool("Grillas.EstilosCondicionales.PermiteModificarAplicacion");
			else
				_permiteModificarAplicacion = Convert.ToBoolean( valorPermiteModificarAplicacion );

			object valorModoDeAplicacionDefault = null;
			string variableModoDeAplicacionDefault = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.ModificarAplicacionDefault";
			valorModoDeAplicacionDefault = Variables.GetValue(variableModoDeAplicacionDefault);
			if(valorModoDeAplicacionDefault == null)
				valorModoDeAplicacionDefault = Variables.GetValue("Grillas.EstilosCondicionales.ModificarAplicacionDefault");
			if(valorModoDeAplicacionDefault != null)
				_modoDeAplicacionDefault = valorModoDeAplicacionDefault.ToString();
			else
				_modoDeAplicacionDefault = "U";

			object valorPermiteModificarAplicablesModificables = null;
			string variablePermiteModificarAplicablesModificables = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.PermiteModificarAplicablesModificables";
			valorPermiteModificarAplicablesModificables = Variables.GetValue(variablePermiteModificarAplicablesModificables);
			if(valorPermiteModificarAplicablesModificables == null)
				_permiteModificarAplicablesModificables = Variables.GetValueBool("Grillas.EstilosCondicionales.PermiteModificarAplicablesModificables");
			else
				_permiteModificarAplicablesModificables = Convert.ToBoolean( valorPermiteModificarAplicablesModificables );

			object valorModoAplicableModificableDefault = null;
			string variableModoAplicableModificableDefault = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.ModificarAplicablesModificablesDefault";
			valorModoAplicableModificableDefault = Variables.GetValue(variableModoAplicableModificableDefault);
			if(valorModoAplicableModificableDefault == null)
				valorModoAplicableModificableDefault = Variables.GetValue("Grillas.EstilosCondicionales.ModificarAplicablesModificablesDefault");
			if(valorModoAplicableModificableDefault != null)
				_modoAplicableModificableDefault = valorModoAplicableModificableDefault.ToString();
			else
				_modoAplicableModificableDefault = "U";

			object valorPermiteModificarAplicables = null;
			string variablePermiteModificarAplicables = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.PermiteModificarAplicables";
			valorPermiteModificarAplicables = Variables.GetValue(variablePermiteModificarAplicables);
			if(valorPermiteModificarAplicables == null)
				_permiteModificarAplicables = Variables.GetValueBool("Grillas.EstilosCondicionales.PermiteModificarAplicables");
			else
				_permiteModificarAplicables = Convert.ToBoolean( valorPermiteModificarAplicables );

			object valorModoAplicableDefault = null;
			string variableModoAplicableDefault = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.ModificarAplicablesDefault";
			valorModoAplicableDefault = Variables.GetValue(variableModoAplicableDefault);
			if(valorModoAplicableDefault == null)
				valorModoAplicableDefault = Variables.GetValue("Grillas.EstilosCondicionales.ModificarAplicablesDefault");
			if(valorModoAplicableDefault != null)
				_modoAplicableDefault = valorModoAplicableDefault.ToString();
			else
				_modoAplicableDefault = "T";

			object valorCantidadMaximaConfiguracionPorUsuario = null;
			string variableCantidadMaximaConfiguracionPorUsuario = "Momentos." + TaskName + "." + ProcessName + "." + "Grillas.EstilosCondicionales.CantidadMaximaConfiguracionPorUsuario";
			valorCantidadMaximaConfiguracionPorUsuario = Variables.GetValue(variableCantidadMaximaConfiguracionPorUsuario);
			if(valorCantidadMaximaConfiguracionPorUsuario == null)
				valorCantidadMaximaConfiguracionPorUsuario = Variables.GetValue("Grillas.EstilosCondicionales.CantidadMaximaConfiguracionPorUsuario");
			if(valorCantidadMaximaConfiguracionPorUsuario != null)
				_cantidadMaximaConfiguracionPorUsuario = valorCantidadMaximaConfiguracionPorUsuario.ToString();
			else
				_cantidadMaximaConfiguracionPorUsuario = "10";
		}

		public bool PuedeAplicarConfiguracionATodos(string NombreGrilla)
		{
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
            return this.ExisteConfiguracionEnAplicables(IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);			
		}

		public bool PuedeAplicarConfiguracionAPerfiles(string NombreGrilla)
		{
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			bool puede = this.ExisteConfiguracionEnAplicables(IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);
			if(!puede)
			{
				int i = 0;
				bool ok = true;
				while(ok && i < _perfilesSeleccionados.Count)
				{
					PerfilView pv = (PerfilView)_perfilesSeleccionados[i];
					ok = this.ExisteConfiguracionEnAplicablesPerfiles(pv.IdPerfil, IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);
					i++;
				}
				puede = ok;
			}
			return puede;			
		}

		public bool PuedeAplicarConfiguracionAUsuarios(string NombreGrilla)
		{
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			bool puede = this.ExisteConfiguracionEnAplicables(IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);
			if(!puede)
			{
				int i = 0;
				bool ok = true;
				while(ok && i < _usuariosSeleccionados.Count)
				{
					UsuarioView uv = (UsuarioView)_usuariosSeleccionados[i];
					ok = this.ExisteConfiguracionEnAplicablesUsuarios(uv.IdUsuario, IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);
					if(!ok)
					{
						sy_PerfilesUsuariosEmpresasDataset dataPerfilesUsuario = sy_PerfilesUsuariosEmpresas.GetList(uv.IdUsuario, Security.IdEmpresa);
						int j = 0;
						while(!ok && j < dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows.Count)
						{
							sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row = (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow)dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows[i];
							ok = this.ExisteConfiguracionEnAplicablesPerfiles(row.IdPerfil, IdProceso, IdTarea, NombreGrilla, _configuracionSeleccionada.IdConfiguracion);
							j++;
						}
					}
					i++;
				}
				puede = ok;
			}
			return puede;			
		}


		public void AddConfiguracionLikeSelected()
		{
			long IdConfiguracion = systemframework.Util.NewLongId();
			ConfiguracionGrillaEstilosCondicionales conf = new ConfiguracionGrillaEstilosCondicionales(IdConfiguracion, string.Empty, Security.IdUsuario, true, DateTime.Today, Security.IdEmpresa, Security.IdSucursal, "NEW");
			conf.Detalle.AddRange(_configuracionSeleccionada.Detalle);
			_configuracionesAplicables.Add(IdConfiguracion, conf);
			ConfiguracionSeleccionada = conf;

		}

		public bool PuedeBorrarConfiguracionAplicada()
		{
			bool estaAplicada = tui_ConfiguracionGrillaEstiloAplicadoEx.EstaAplicada(_configuracionSeleccionada.IdConfiguracion);
			if(estaAplicada)
				return PermiteBorradoEnCascada;
            else
				return true;			
		}

		public bool PuedeBorrarConfiguracion()
		{
			bool ok = _configuracionSeleccionada.IdUsuarioCreador.Equals(Security.IdUsuario);
			if(!ok)
				ok = PermiteBorrarConfiguracionDeOtroUsuario;
			return ok;
		}

		public bool PuedeModificarConfiguracion(string NombreGrilla)
		{
			bool ok = _configuracionSeleccionada.IdUsuarioCreador.Equals(Security.IdUsuario);
			if(!ok)
			{
				long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
				long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
				ok = tui_ConfiguracionGrillaEstilosAplicablesModificablesEx.ExisteModificable(IdProceso, IdTarea, NombreGrilla, Formulario, _configuracionSeleccionada.IdConfiguracion, Security.IdPerfil, Security.IdUsuario);
		    }
			return ok;
		}

		public bool PuedeAgregarConfiguracion()
		{
			if(CantidadMaximaConfiguracionPorUsuario.Equals("Infinito"))
				return true;
			else
			{
				int cantMax = Convert.ToInt16(CantidadMaximaConfiguracionPorUsuario);
				int cantCreadas = tui_ConfiguracionGrillaEstilosCondicionalesEx.GetCantidadConfiguracionesUsuario(Security.IdUsuario);
				return cantCreadas <= cantMax;
			}
		}
 
		public DataTable ConfiguracionesEnBD(Janus.Windows.GridEX.GridEX grilla)
		{
			_configuracionesAplicables = new Hashtable();
			long IdProceso = twf_Procesos.GetIdProcessByName(_processName);
			long IdTarea = twf_Tareas.GetIdTaskByName(_taskName);
			tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesDataTable confAplicables = tui_ConfiguracionGrillaEstilosAplicablesEx.GetList(IdProceso, IdTarea, grilla.Name, string.Empty, Security.IdPerfil, Security.IdUsuario).tui_ConfiguracionGrillaEstilosAplicables;
			tui_ConfiguracionGrillaEstilosCondicionalesDataset _configuracionesEnBD = new tui_ConfiguracionGrillaEstilosCondicionalesDataset();
			foreach(tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow row in confAplicables.Rows)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowBD = _configuracionesEnBD.tui_ConfiguracionGrillaEstilosCondicionales.Newtui_ConfiguracionGrillaEstilosCondicionalesRow();
				tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowECU = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByPk(Security.IdUsuario, row.IdConfiguracion);
				if(rowECU == null)
				{
					tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowECP = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetByPk(Security.IdPerfil, row.IdConfiguracion);
					if(rowECP == null)
					{
						tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowEC = tui_ConfiguracionGrillaEstilosCondicionales.GetByPk(row.IdConfiguracion);
						ConfiguracionGrillaEstilosCondicionales conf = new ConfiguracionGrillaEstilosCondicionales(rowEC.IdConfiguracion, rowEC.Nombre, rowEC.IdUsuarioCreador, rowEC.Activo, rowEC.FechaCreacion, rowEC.IdEmpresa, rowEC.IdSucursal, string.Empty);
						_configuracionesAplicables.Add(rowEC.IdConfiguracion, conf);
						rowBD.IdConfiguracion = rowEC.IdConfiguracion;
						rowBD.Nombre = rowEC.Nombre + "_" + rowEC.IdUsuarioCreador;
						rowBD.IdUsuarioCreador = rowEC.IdUsuarioCreador;
						rowBD.Activo = rowEC.Activo;
						tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetDataTable tableECD = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList(rowEC.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDet;
						foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow rowECD in tableECD.Rows)
						{
							string ColumnaKey = rowECD.Columna;
							string Condicion = rowECD.Condicion.ToString();
							long IdCondicion = rowECD.IdCondicion;
							object Valor = null;
							Janus.Windows.GridEX.GridEXColumn realColumn = grilla.RootTable.Columns[ ColumnaKey ];
							ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, this.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
							if(rowECD["ValorColumna"] == System.DBNull.Value || rowECD.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
								Valor = rowECD.Valor;
							else
							{
								string ColumnaValorKey = rowECD.ValorColumna;
								Valor = grilla.RootTable.Columns[ ColumnaValorKey ];

							}
							Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloGeneral(rowEC.IdConfiguracion, IdCondicion, grilla);
							ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
							ConfiguracionGrillaEstilosCondicionalesDet cond = new ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, Valor, mfs, string.Empty);
							conf.AddCondicion(cond);
						}
					}
					else
					{
						ConfiguracionGrillaEstilosCondicionales conf = new ConfiguracionGrillaEstilosCondicionales(rowECP.IdConfiguracion, rowECP.Nombre, rowECP.IdUsuarioCreador, rowECP.Activo, rowECP.FechaCreacion, rowECP.IdEmpresa, rowECP.IdSucursal, string.Empty);
						_configuracionesAplicables.Add(rowECP.IdConfiguracion, conf);
						rowBD.IdConfiguracion = rowECP.IdConfiguracion;
						rowBD.Nombre = rowECP.Nombre + "_" + rowECP.IdUsuarioCreador;;
						rowBD.IdUsuarioCreador = rowECP.IdUsuarioCreador;
						rowBD.Activo = rowECP.Activo;
						tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataTable tableECDP = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetList(rowECP.IdPerfil, rowECP.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles;
						foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowECDP in tableECDP.Rows)
						{
							string ColumnaKey = rowECDP.Columna;
							string Condicion = rowECDP.Condicion.ToString();
							long IdCondicion = rowECDP.IdCondicion;
							object Valor = null;
							Janus.Windows.GridEX.GridEXColumn realColumn = grilla.RootTable.Columns[ ColumnaKey ];
							ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, this.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
							if(rowECDP["ValorColumna"] == System.DBNull.Value || rowECDP.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
								Valor = rowECDP.Valor;
							else
							{
								string ColumnaValorKey = rowECDP.ValorColumna;
								Valor = grilla.RootTable.Columns[ ColumnaValorKey ];

							}
							Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloPerfil(rowECP.IdConfiguracion, IdCondicion, grilla, rowECP.IdPerfil);
							ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
							ConfiguracionGrillaEstilosCondicionalesDet cond = new ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, Valor, mfs, string.Empty);
							conf.AddCondicion(cond);
						}
					}
				}
				else
				{
					ConfiguracionGrillaEstilosCondicionales conf = new ConfiguracionGrillaEstilosCondicionales(rowECU.IdConfiguracion, rowECU.Nombre, rowECU.IdUsuarioCreador, rowECU.Activo, rowECU.FechaCreacion, rowECU.IdEmpresa, rowECU.IdSucursal, string.Empty);
					_configuracionesAplicables.Add(rowECU.IdConfiguracion, conf);
					rowBD.IdConfiguracion = rowECU.IdConfiguracion;
					rowBD.Nombre = rowECU.Nombre + "_" + rowECU.IdUsuarioCreador;;
					rowBD.IdUsuarioCreador = rowECU.IdUsuarioCreador;
					rowBD.Activo = rowECU.Activo;
					tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataTable tableECDU = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetList(rowECU.IdUsuario, rowECU.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios;
					foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowECDU in tableECDU.Rows)
					{
						string ColumnaKey = rowECDU.Columna;
						string Condicion = rowECDU.Condicion.ToString();
						long IdCondicion = rowECDU.IdCondicion;
						object Valor = null;
						Janus.Windows.GridEX.GridEXColumn realColumn = grilla.RootTable.Columns[ ColumnaKey ];
						ConfiguracionStyleGrilla.ColumnaView colView = new ConfiguracionStyleGrilla.ColumnaView(realColumn.Caption, this.getTypeFor(realColumn.FormatString, realColumn.ColumnType.ToString()), realColumn.Key, realColumn);
						if(rowECDU["ValorColumna"] == System.DBNull.Value || rowECDU.ValorColumna.Equals(string.Empty)) //El valor de comparacion no es una colomna
							Valor = rowECDU.Valor;
						else
						{
							string ColumnaValorKey = rowECDU.ValorColumna;
							Valor = grilla.RootTable.Columns[ ColumnaValorKey ];

						}
						Janus.Windows.GridEX.GridEXFormatStyle fs= getEstiloUsuario(rowECU.IdConfiguracion, IdCondicion, grilla, rowECDU.IdUsuario);
						ConfiguracionStyleGrilla.MyGridEXFormatStyle mfs = new ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
						ConfiguracionGrillaEstilosCondicionalesDet cond = new ConfiguracionGrillaEstilosCondicionalesDet(IdCondicion, colView, Condicion, Valor, mfs, string.Empty);
						conf.AddCondicion(cond);
					}
				}
				_configuracionesEnBD.tui_ConfiguracionGrillaEstilosCondicionales.Addtui_ConfiguracionGrillaEstilosCondicionalesRow(rowBD);
			}

			long idConfAplicada = tui_ConfiguracionGrillaEstiloAplicadoEx.GetIdConfiguracionAplicada(Security.IdUsuario, Security.IdPerfil, IdProceso, IdTarea, grilla.Name, string.Empty);
			if(idConfAplicada != long.MinValue)
			{
				IdConfiguracionSeleccionada = idConfAplicada;
				IdConfiguracionAplicada = idConfAplicada;
			}
			else
			{
				long IdConfiguracionNinguna = systemframework.Util.NewLongId();
				tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowBDN = _configuracionesEnBD.tui_ConfiguracionGrillaEstilosCondicionales.Newtui_ConfiguracionGrillaEstilosCondicionalesRow();
				rowBDN.IdConfiguracion = IdConfiguracionNinguna;
				rowBDN.Nombre = "Ninguna";
				rowBDN.IdUsuarioCreador = Security.IdUsuario;
				rowBDN.Activo = true;
				rowBDN.FechaCreacion = DateTime.Now;
				rowBDN.IdConexionCreacion = Security.IdConexion;
				rowBDN.IdReservado = 0;
				rowBDN.IdEmpresa = Security.IdEmpresa;			
				rowBDN.IdSucursal = Security.IdSucursal;
				_configuracionesEnBD.tui_ConfiguracionGrillaEstilosCondicionales.Addtui_ConfiguracionGrillaEstilosCondicionalesRow(rowBDN);
				ConfiguracionGrillaEstilosCondicionales config = new ConfiguracionGrillaEstilosCondicionales(rowBDN.IdConfiguracion, rowBDN.Nombre, rowBDN.IdUsuarioCreador, rowBDN.Activo, rowBDN.FechaCreacion, rowBDN.IdEmpresa, rowBDN.IdSucursal, string.Empty);
				_configuracionesAplicables.Add(rowBDN.IdConfiguracion, config);
				IdConfiguracionSeleccionada = rowBDN.IdConfiguracion;
			}
			return _configuracionesEnBD.tui_ConfiguracionGrillaEstilosCondicionales;
		}


		public int GetIndexUsuarioLogueado()
		{
			string idUsuario = Security.IdUsuario;
			int index = 0;
			bool ok = false;
			while(!ok && index < _usuarios.Count)
			{
				UsuarioView usuario = (UsuarioView)_usuarios[index];
				ok = usuario.IdUsuario.Equals(idUsuario);
				if(!ok)
                    index++;
			}
			if(ok)
				return index;
			else
				return -1;
		}

		public int GetIndexPerfilLogueado()
		{
			long idPerfil = Security.IdPerfil;
			int index = 0;
			bool ok = false;
			while(!ok && index < _perfiles.Count)
			{
				PerfilView perfil = (PerfilView)_perfiles[index];
				ok = perfil.IdPerfil.Equals(idPerfil);
				if(!ok)
                    index++;
			}
			if(ok)
				return index;
			else
				return -1;
		}

		public void AddCondicionAConfiguracion(ColumnaView Columna, string Condicion, object Valor, MyGridEXFormatStyle Estilo)
		{
			int index = getCondicionConfiguracionIndex(Columna, Condicion, Valor);
			ConfiguracionGrillaEstilosCondicionalesDet config = new ConfiguracionGrillaEstilosCondicionalesDet(systemframework.Util.NewLongId(), Columna, Condicion, Valor, Estilo, "NEW");
			if( index != -1)
			{
				_configuracionSeleccionada.Detalle.RemoveAt(index);
				config.Estado = "MODIF_NEW";
				_configuracionSeleccionada.Detalle.Insert(index, config);
			}
			else
				_configuracionSeleccionada.Detalle.Add(config);
			if(CondicionesHasChanged != null)
				CondicionesHasChanged(this, new EventArgs());	
		}

		public void ModifCondicionDeConfiguracion(ConfiguracionGrillaEstilosCondicionalesDet Condicion, ColumnaView Columna, string NuevaCondicion, object Valor, MyGridEXFormatStyle Estilo)
		{
			Condicion.Columna = Columna;
			Condicion.Condicion = NuevaCondicion;
			Condicion.Valor = Valor;
			Condicion.Estilo = Estilo;
			Condicion.EstilosAplicados = Estilo.Propiedades();
			Condicion.Estilos = Estilo.ToString();
			if(!Condicion.Estado.Equals("NEW"))
                Condicion.Estado = "MODIF";
			if(CondicionesHasChanged != null)
				CondicionesHasChanged(this, new EventArgs());	
		}

		public void AplicarConfiguracion(Janus.Windows.GridEX.GridEX Grilla)
		{
			if(_todos)
				this.AplicarATodos(Grilla);
			else if(_porUsuario)
				this.AplicarAUsuarios(Grilla);
			else
				this.AplicarAPerfiles(Grilla);
			if(ConfiguracionesHasChanged != null)
				ConfiguracionesHasChanged(this, new EventArgs());	
			ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[_configuracionSeleccionada.IdConfiguracion];
		}

		public void Save(Janus.Windows.GridEX.GridEX Grilla)
		{
			if(_todosAplicables)
				this.SaveParaTodos(Grilla);
			else if(_porUsuarioAplicables)
				this.SaveParaUsuarios(Grilla);
			else
				this.SaveParaPerfiles(Grilla);
			if(_configuracionSeleccionada.IdConfiguracion == IdConfiguracionAplicada)
			{
				if(ConfiguracionGrillaHasChanged != null)
					ConfiguracionGrillaHasChanged(this, new EventArgs());	
			}
			ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[_configuracionSeleccionada.IdConfiguracion];
	
		}

		public void RemoveCondicion(ConfiguracionGrillaEstilosCondicionalesDet condicion)
		{
			if(condicion.Estado.Equals("NEW"))
			{
				int index = getCondicionConfiguracionIndex(condicion.Columna, condicion.Condicion, condicion.Valor);
				_configuracionSeleccionada.Detalle.RemoveAt(index);
			}
			else
			{
				condicion.Estado = "DEL";
			}
			if(CondicionesHasChanged != null)
				CondicionesHasChanged(this, new EventArgs());	
		}
		public void AddConfiguracion()
		{
			long IdConfiguracion = systemframework.Util.NewLongId();
			ConfiguracionGrillaEstilosCondicionales conf = new ConfiguracionGrillaEstilosCondicionales(IdConfiguracion, string.Empty, Security.IdUsuario, true, DateTime.Today, Security.IdEmpresa, Security.IdSucursal, "NEW");
			_configuracionesAplicables.Add(IdConfiguracion, conf);
			ConfiguracionSeleccionada = conf;

		}

		public void ModificarConfiguracion()
		{
			if(_configuracionSeleccionada != null)
				_configuracionSeleccionada.Estado = "MODIF";
		}

		public void RemoveConfiguracion()
		{
			if(_configuracionSeleccionada != null)
			{				
				_dataAplicado = new tui_ConfiguracionGrillaEstiloAplicadoDataset();
				_dataUsuariosAplicado = new tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset();
				_dataPerfilesAplicado = new tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset();
				tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowECUEx = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByPk(Security.IdUsuario, _configuracionSeleccionada.IdConfiguracion);
				if(rowECUEx != null) //esta en usuarios
				{
					_dataUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset();
					tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset dataECU = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetList(string.Empty, _configuracionSeleccionada.IdConfiguracion, string.Empty, rowECUEx.IdUsuarioCreador, rowECUEx.IdEmpresa, rowECUEx.IdSucursal );
					foreach(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowECU in dataECU.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows)
					{
						tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataTable tableECDU = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetList(rowECU.IdUsuario, _configuracionSeleccionada.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios;
						foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowECDU in tableECDU.Rows)
						{
							long IdCondicion = rowECDU.IdCondicion;
							tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList(rowECU.IdUsuario, _configuracionSeleccionada.IdConfiguracion, IdCondicion);
							foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Rows)
							{
								rowDetEstA.Delete();
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.ImportRow(rowDetEstA);
							}
							rowECDU.Delete();
							_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.ImportRow(rowECDU);
						}
						tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset dataAplicables = tui_ConfiguracionGrillaEstilosAplicablesUsuarios.GetList(rowECU.IdUsuario, _configuracionSeleccionada.IdConfiguracion);
						foreach(tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow rowEstaAplic in dataAplicables.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.Rows)
						{
							//Borro de Aplicadas
							tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow rowAplicadaUsuarios = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetByPk(rowEstaAplic.IdUsuario, rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion);							
							if(rowAplicadaUsuarios != null)
							{								
								if(!ExisteConfiguracionEnAplicablesTodosPerfiles(rowAplicadaUsuarios.IdUsuario, rowAplicadaUsuarios.IdProceso, rowAplicadaUsuarios.IdTarea, rowAplicadaUsuarios.Grilla, rowAplicadaUsuarios.IdConfiguracion))
								{
									rowAplicadaUsuarios.Delete();
									_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.ImportRow(rowAplicadaUsuarios);
								}

							}
    						//FIN APLICADAS
							rowEstaAplic.Delete();
							_dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.ImportRow(rowEstaAplic);
						}
						rowECU.Delete();
						_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ImportRow(rowECU);
					}
					//Borro de MODIFICABLES
					this.RemoveModificables();					
					_replication = GenerateReplication();
					dataaccess.tui_ConfiguracionGrillaEstilosAplicablesUsuariosEx.Update(_dataUsuarios, _replication);
					dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update(_dataUsuariosAplicado);
					if(_configuracionSeleccionada.IdConfiguracion == IdConfiguracionAplicada)
					{
						if(ConfiguracionGrillaHasChanged != null)
							ConfiguracionGrillaHasChanged(this, new EventArgs());	
					}
					if(ConfiguracionesHasChanged != null)
						ConfiguracionesHasChanged(this, new EventArgs());	
					ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[_configuracionSeleccionada.IdConfiguracion];
				}
				else
				{
					tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowECPEx = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetByPk(Security.IdPerfil, _configuracionSeleccionada.IdConfiguracion);
					if(rowECPEx != null) //esta en perfiles
					{
						_dataPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset();
						tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset dataECP = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetList(long.MinValue, _configuracionSeleccionada.IdConfiguracion, string.Empty, rowECPEx.IdUsuarioCreador, rowECPEx.IdEmpresa, rowECPEx.IdSucursal );
						foreach(tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowECP in dataECP.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Rows)
						{
							tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataTable tableECDP = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetList(rowECP.IdPerfil, _configuracionSeleccionada.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles;
							foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowECDP in tableECDP.Rows)
							{
								long IdCondicion = rowECDP.IdCondicion;
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetList(rowECP.IdPerfil, _configuracionSeleccionada.IdConfiguracion, IdCondicion);
								foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Rows)
								{
									rowDetEstA.Delete();
									_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.ImportRow(rowDetEstA);
								}
								rowECDP.Delete();
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.ImportRow(rowECDP);
							}
							tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset dataAplicables = tui_ConfiguracionGrillaEstilosAplicablesPerfiles.GetList(rowECP.IdPerfil, _configuracionSeleccionada.IdConfiguracion);
							foreach(tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow rowEstaAplic in dataAplicables.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Rows)
							{
								//Borro de Aplicadas
								tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow rowAplicadaPerfiles = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetByPk(rowEstaAplic.IdPerfil, rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion);							
								if(rowAplicadaPerfiles != null)
								{								
									if(!ExisteConfiguracionEnAplicables(rowAplicadaPerfiles.IdProceso, rowAplicadaPerfiles.IdTarea, rowAplicadaPerfiles.Grilla, rowAplicadaPerfiles.IdConfiguracion))
									{
										rowAplicadaPerfiles.Delete();
										_dataPerfilesAplicado.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.ImportRow(rowAplicadaPerfiles);
									}

								}

								sy_PerfilesUsuariosEmpresasDataset dataPerfilesUsuario = sy_PerfilesUsuariosEmpresas.GetList(rowEstaAplic.IdPerfil, Security.IdEmpresa);
								foreach(sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow rowAplicadaUsuarios in dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows)
								{
									if(!ExisteConfiguracionEnAplicablesTodosUsuarios(rowAplicadaUsuarios.IdUsuario, rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion))
									{
										rowAplicadaUsuarios.Delete();
										_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.ImportRow(rowAplicadaUsuarios);
									}
								}

								//FIN APLICADAS
								rowEstaAplic.Delete();
								_dataPerfiles.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.ImportRow(rowEstaAplic);
							}
							rowECP.Delete();
							_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.ImportRow(rowECP);
						}
						//Borro de MODIFICABLES
						this.RemoveModificables();
						_replication = GenerateReplication();
						dataaccess.tui_ConfiguracionGrillaEstilosAplicablesPerfilesEx.Update(_dataPerfiles, _replication);
						dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update(_dataPerfilesAplicado);
						dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update(_dataUsuariosAplicado);
						if(_configuracionSeleccionada.IdConfiguracion == IdConfiguracionAplicada)
						{
							if(ConfiguracionGrillaHasChanged != null)
								ConfiguracionGrillaHasChanged(this, new EventArgs());	
						}
						if(ConfiguracionesHasChanged != null)
							ConfiguracionesHasChanged(this, new EventArgs());	
						ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[_configuracionSeleccionada.IdConfiguracion];
					}
					else 
					{
						tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowEC = tui_ConfiguracionGrillaEstilosCondicionales.GetByPk(_configuracionSeleccionada.IdConfiguracion);
						if(rowEC != null) //esta en todos
						{
							_data = new tui_ConfiguracionGrillaEstilosAplicablesExDataset();
							tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetDataTable tableECD = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList(_configuracionSeleccionada.IdConfiguracion).tui_ConfiguracionGrillaEstilosCondicionalesDet;
							foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow rowECD in tableECD.Rows)
							{
								long IdCondicion = rowECD.IdCondicion;
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetList(_configuracionSeleccionada.IdConfiguracion, IdCondicion);
								foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Rows)
								{
									rowDetEstA.Delete();
									_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.ImportRow(rowDetEstA);
								}
								rowECD.Delete();
								_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.ImportRow(rowECD);
							}
							tui_ConfiguracionGrillaEstilosAplicablesDataset dataAplicables = tui_ConfiguracionGrillaEstilosAplicables.GetList(_configuracionSeleccionada.IdConfiguracion);
							foreach(tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow rowEstaAplic in dataAplicables.tui_ConfiguracionGrillaEstilosAplicables.Rows)
							{
								//Borro de Aplicadas
								tui_ConfiguracionGrillaEstiloAplicadoDataset.tui_ConfiguracionGrillaEstiloAplicadoRow rowAplicada = tui_ConfiguracionGrillaEstiloAplicado.GetByPk(rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion);						
								if(rowAplicada != null)
								{
									rowAplicada.Delete();
									_dataAplicado.tui_ConfiguracionGrillaEstiloAplicado.ImportRow(rowAplicada);
								}
								tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset dataAplicadaPerfiles = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList(rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.Formulario, rowEstaAplic.IdConfiguracion);							
								foreach(tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow rowAplicadaPerfiles in dataAplicadaPerfiles.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows)
								{
									if(!ExisteConfiguracionEnAplicablesPerfiles(rowAplicadaPerfiles.IdPerfil, rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion))
									{
										sy_PerfilesUsuariosEmpresasDataset dataPerfilesUsuario = sy_PerfilesUsuariosEmpresas.GetList(rowAplicadaPerfiles.IdPerfil, Security.IdEmpresa);
										foreach(sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow rowAplicadaUsuarios in dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows)
										{
											if(!ExisteConfiguracionEnAplicablesUsuarios(rowAplicadaUsuarios.IdUsuario, rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.IdConfiguracion))
											{
												rowAplicadaUsuarios.Delete();
												_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.ImportRow(rowAplicadaUsuarios);
											}
										}
										rowAplicadaPerfiles.Delete();
										_dataPerfilesAplicado.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.ImportRow(rowAplicadaPerfiles);
									}
								}

								tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset dataAplicadaUsuarios = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList(rowEstaAplic.IdProceso, rowEstaAplic.IdTarea, rowEstaAplic.Grilla, rowEstaAplic.Formulario, rowEstaAplic.IdConfiguracion);							
								foreach(tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow rowAplicadaUsuarios in dataAplicadaUsuarios.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows)
								{
									if(!ExisteConfiguracionEnAplicablesPerfilesUsuarios(rowAplicadaUsuarios.IdUsuario, rowAplicadaUsuarios.IdProceso, rowAplicadaUsuarios.IdTarea, rowAplicadaUsuarios.Grilla, rowAplicadaUsuarios.IdConfiguracion))
									{
                                        rowAplicadaUsuarios.Delete();
										_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.ImportRow(rowAplicadaUsuarios);
									}
								}
								
								rowEstaAplic.Delete();
								_data.tui_ConfiguracionGrillaEstilosAplicables.ImportRow(rowEstaAplic);
							}
							rowEC.Delete();
							_data.tui_ConfiguracionGrillaEstilosCondicionales.ImportRow(rowEC);
							//Borro de MODIFICABLES
							this.RemoveModificables();
							_replication = GenerateReplication();
							dataaccess.tui_ConfiguracionGrillaEstilosAplicablesEx.Update(_data, _replication);
							dataaccess.tui_ConfiguracionGrillaEstiloAplicado.Update(_dataAplicado);
							dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update(_dataPerfilesAplicado);
							dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update(_dataUsuariosAplicado);
							if(_configuracionSeleccionada.IdConfiguracion == IdConfiguracionAplicada)
							{
								if(ConfiguracionGrillaHasChanged != null)
									ConfiguracionGrillaHasChanged(this, new EventArgs());	
							}
							if(ConfiguracionesHasChanged != null)
								ConfiguracionesHasChanged(this, new EventArgs());	
							ConfiguracionSeleccionada = (ConfiguracionGrillaEstilosCondicionales)_configuracionesAplicables[_configuracionSeleccionada.IdConfiguracion];
						}
					}
				}

			}
		}

		public string GetNombreCofiguracionSimilar()
		{
			string nombreConfiguracion = string.Empty;
			if(_configuracionSeleccionada != null)
			{
				int i = 0;
				ArrayList configuraciones = new ArrayList();
				configuraciones.AddRange(_configuracionesAplicables.Values);
				while(nombreConfiguracion.Equals(string.Empty) && i < configuraciones.Count)
				{
					ConfiguracionGrillaEstilosCondicionales conf = (ConfiguracionGrillaEstilosCondicionales)configuraciones[i];
					if(!conf.Nombre.Equals("Ninguna") && !conf.IdConfiguracion.Equals(_configuracionSeleccionada.IdConfiguracion) && this.TienenLasMismasCondiciones(conf, _configuracionSeleccionada))
						nombreConfiguracion = conf.Nombre;
					i++;
				}
			}
			return nombreConfiguracion;
		}

		public bool ExisteNombreConfiguracion()
		{
			bool existeNombre = false;
			if(_configuracionSeleccionada != null)
			{
				int i = 0;
				ArrayList configuraciones = new ArrayList();
				configuraciones.AddRange(_configuracionesAplicables.Values);
				while(!existeNombre && i < configuraciones.Count)
				{
					ConfiguracionGrillaEstilosCondicionales conf = (ConfiguracionGrillaEstilosCondicionales)configuraciones[i];
					existeNombre = !conf.Nombre.Equals("Ninguna") && !conf.IdConfiguracion.Equals(_configuracionSeleccionada.IdConfiguracion) && conf.Nombre.Equals(_configuracionSeleccionada.Nombre);
					i++;
				}

			}
			return existeNombre;
		}

		#endregion


		#region Métodos Privados

		private bool TienenLasMismasCondiciones(ConfiguracionGrillaEstilosCondicionales conf1, ConfiguracionGrillaEstilosCondicionales conf2)
		{			
			bool iguales = conf1.Detalle.Count == this.GetCantidadRealCondiciones(conf2);
			int i = 0;
			while(iguales && i <  conf1.Detalle.Count)
			{
				ConfiguracionGrillaEstilosCondicionalesDet cond1 = (ConfiguracionGrillaEstilosCondicionalesDet)conf1.Detalle[i];
				int j = 0;
				bool existeCond = false;
				while(!existeCond && j <  conf2.Detalle.Count)
				{
					ConfiguracionGrillaEstilosCondicionalesDet cond2 = (ConfiguracionGrillaEstilosCondicionalesDet)conf2.Detalle[j];
					existeCond = !cond2.Estado.Equals("DEL") && cond1.Columna.Name.Equals(cond2.Columna.Name) && cond1.Condicion.Equals(cond2.Condicion) && cond1.Valor.Equals(cond2.Valor) && cond1.Estilo.ToString().Equals(cond2.Estilo.ToString());
					j++;
				}
				iguales = existeCond;
				i++;
			}
			return iguales;
		}

		private int GetCantidadRealCondiciones(ConfiguracionGrillaEstilosCondicionales conf)
		{
			int cantCond = 0;
			foreach(ConfiguracionGrillaEstilosCondicionalesDet cond in conf.Detalle)
			{
				if(!cond.Estado.Equals("DEL"))
					cantCond++;
			}
			return cantCond;
		}
		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloGeneral(long IdConfiguracion, long IdCondicion, Janus.Windows.GridEX.GridEX grilla)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetList(IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(mz.erp.businessrules.ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							ConfiguracionStyleGrilla.XmlFont xmlFont = (ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}


		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloPerfil(long IdConfiguracion, long IdCondicion, Janus.Windows.GridEX.GridEX grilla, long IdPerfil)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetList(IdPerfil, IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							ConfiguracionStyleGrilla.XmlFont xmlFont = (ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}

		
		private Janus.Windows.GridEX.GridEXFormatStyle getEstiloUsuario(long IdConfiguracion, long IdCondicion, Janus.Windows.GridEX.GridEX grilla, string IdUsuario)
		{
			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) grilla.RowFormatStyle);
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset dataCondDetEstAp = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList(IdUsuario, IdConfiguracion, IdCondicion);
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowDetEstA in dataCondDetEstAp.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Rows)
			{
				string Propiedad = rowDetEstA.Propiedad;
				string val = rowDetEstA.Valor;
				switch (Propiedad)
				{				
					case "BackColor" :
						int argb = Convert.ToInt32(val);
						fs.BackColor = System.Drawing.Color.FromArgb(argb);					
						break;
					case "Font" : 
						if(!val.Equals(string.Empty))
						{
							XmlDocument doc = new XmlDocument();
							doc.LoadXml(val);
							XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
							XmlSerializer ser = new XmlSerializer(typeof(ConfiguracionStyleGrilla.XmlFont));
							object obj = ser.Deserialize(reader);
							ConfiguracionStyleGrilla.XmlFont xmlFont = (ConfiguracionStyleGrilla.XmlFont)obj;
							fs.Font = xmlFont.ToFont();				
						}
						break;
									
					case "FontBold" :
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontBold = fb;					
						break;
					}
					case "FontItalic":
					{
						Janus.Windows.GridEX.TriState fb = Janus.Windows.GridEX.TriState.Empty;
						switch (val)
						{
							case "Empty":
								fb = Janus.Windows.GridEX.TriState.Empty;
								break;
							case "False":
								fb = Janus.Windows.GridEX.TriState.False;
								break;
							case "True":
								fb = Janus.Windows.GridEX.TriState.True;
								break;

						}
						fs.FontItalic = fb;					
						break;
					}
					case "FontSize":
						fs.FontSize = (float)Convert.ToDecimal(val);
						break;
					case "ForeColor":
						int argb2 = Convert.ToInt32(val);
						fs.ForeColor = System.Drawing.Color.FromArgb(argb2);					
						break;
					case "TextAlignment":
					{
						Janus.Windows.GridEX.TextAlignment ta = Janus.Windows.GridEX.TextAlignment.Empty;
						switch (val)
						{
							case "Center":
								ta = Janus.Windows.GridEX.TextAlignment.Center;
								break;
							case "Empty":
								ta = Janus.Windows.GridEX.TextAlignment.Empty;
								break;
							case "Far":
								ta = Janus.Windows.GridEX.TextAlignment.Far;
								break;
							case "Near":
								ta = Janus.Windows.GridEX.TextAlignment.Near;
								break;
						}
						fs.TextAlignment = ta;					
						break;
					}
				}		
			}			
			return fs;
		}



		private string getTypeFor(string formatStyle, string columnType)
		{
			if(columnType.Equals("CheckBox"))
				return ConfiguracionStyleGrilla.ColumnaView.BoolType;	
			else
			{
				switch(formatStyle)
				{
					case "c": return ConfiguracionStyleGrilla.ColumnaView.DecimalType;						
						break;
					case "p": return ConfiguracionStyleGrilla.ColumnaView.DecimalType;
						break;
					case "d": return ConfiguracionStyleGrilla.ColumnaView.DateTimeType;
						break;
					case "dd/MM/yyyy": return ConfiguracionStyleGrilla.ColumnaView.DateTimeType;
						break;
					case "0": return ConfiguracionStyleGrilla.ColumnaView.IntType;
						break;
					case "0.00": return ConfiguracionStyleGrilla.ColumnaView.DecimalType;
						break;
					case "#,##0.00;#,##0.00;0.00": return ConfiguracionStyleGrilla.ColumnaView.DecimalType;
                    //Matias 20101025 - Tarea 898
                        break;
                    case "f": return ConfiguracionStyleGrilla.ColumnaView.StringType;
                        break;
                    //FinMatias
                    default: return ConfiguracionStyleGrilla.ColumnaView.StringType;
				}
			}	
		}


		private void SaveParaTodos(Janus.Windows.GridEX.GridEX Grilla)
		{
			_data = new tui_ConfiguracionGrillaEstilosAplicablesExDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if(IdProceso.Equals(long.MinValue))
			{
				IdProceso = 0;
				IdTarea = 0;
			}
			tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowECData = tui_ConfiguracionGrillaEstilosCondicionales.GetByName(_configuracionSeleccionada.Nombre);
			tui_ConfiguracionGrillaEstilosAplicablesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow rowEC = null;
			if(rowECData == null) // No existe configuracion con ese nombre
			{
				rowEC = _data.tui_ConfiguracionGrillaEstilosCondicionales.Newtui_ConfiguracionGrillaEstilosCondicionalesRow();
				rowEC.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
				rowEC.Nombre = _configuracionSeleccionada.Nombre;
				rowEC.IdUsuarioCreador = _configuracionSeleccionada.IdUsuarioCreador;
				rowEC.Activo = _configuracionSeleccionada.Activo;
				rowEC.FechaCreacion = _configuracionSeleccionada.Fecha;
				rowEC.IdConexionCreacion = Security.IdConexion;
				rowEC.IdReservado = 0;
				rowEC.IdEmpresa = _configuracionSeleccionada.IdEmpresa;			
				rowEC.IdSucursal = _configuracionSeleccionada.IdSucursal;
				_data.tui_ConfiguracionGrillaEstilosCondicionales.Addtui_ConfiguracionGrillaEstilosCondicionalesRow(rowEC);
			}
			else
			{
				_data.tui_ConfiguracionGrillaEstilosCondicionales.ImportRow(rowECData);
				rowEC = _data.tui_ConfiguracionGrillaEstilosCondicionales.FindByIdConfiguracion(rowECData.IdConfiguracion);
				rowEC.Nombre = _configuracionSeleccionada.Nombre;
			}       

			foreach(ConfiguracionGrillaEstilosCondicionalesDet conf in _configuracionSeleccionada.Detalle)
			{	
				tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow rowECDData = null;
				bool esColumna = false;
				long IdCondicion;
				if(conf.Valor.GetType().Name.Equals("GridEXColumn"))
				{
					rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetCondicion(rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
					esColumna = true;
					IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
				}
				else
				{
					rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetCondicion(rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
					IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
				}

				if(IdCondicion == long.MinValue)
					IdCondicion = systemframework.Util.NewLongId();

				tui_ConfiguracionGrillaEstilosAplicablesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow rowECD = null;
				if(rowECDData == null) //No existe la condicion para la configuracion 
				{
					if(conf.Estado.Equals("NEW") || conf.Estado.Equals(string.Empty))
					{
						rowECD = _data.tui_ConfiguracionGrillaEstilosCondicionalesDet.Newtui_ConfiguracionGrillaEstilosCondicionalesDetRow();
						rowECD.IdConfiguracion = rowEC.IdConfiguracion;
						rowECD.IdCondicion = conf.IdCondicion;
						rowECD.Columna = conf.Columna.Name;
						rowECD.Condicion = conf.Condicion;
						if(!esColumna)
							rowECD.Valor = conf.Valor.ToString();
						else
							rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
						rowECD.FechaCreacion = DateTime.Now;
						rowECD.IdConexionCreacion = Security.IdConexion;
						rowECD.IdReservado = 0;
						rowECD.IdEmpresa = Security.IdEmpresa;			
						rowECD.IdSucursal = Security.IdSucursal;
						_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.Addtui_ConfiguracionGrillaEstilosCondicionalesDetRow(rowECD);

						foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
						{
							tui_ConfiguracionGrillaEstilosAplicablesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowECDEA = _data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow();
							rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
							rowECDEA.IdCondicion = rowECD.IdCondicion;
							rowECDEA.Propiedad = est.Propiedad;
							switch (est.Propiedad)
							{				
								case "BackColor" :
									rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
									break;
								case "Font" :
									if(est.Valor != null)
									{
										System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
										XmlFont xmlFont= new XmlFont(font);
										XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
										System.Text.StringBuilder sb = new System.Text.StringBuilder();
										System.IO.StringWriter writer = new System.IO.StringWriter(sb);
										ser.Serialize(writer, xmlFont);
										rowECDEA.Valor = sb.ToString();
									}
									else
										rowECDEA.Valor = string.Empty;
									break;
								case "ForeColor":
									rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
									break;
								default:
									rowECDEA.Valor = est.Valor.ToString();
									break;
							}		

							rowECDEA.FechaCreacion = DateTime.Now;
							rowECDEA.IdConexionCreacion = Security.IdConexion;
							rowECDEA.IdReservado = 0;
							rowECDEA.IdEmpresa = Security.IdEmpresa;			
							rowECDEA.IdSucursal = Security.IdSucursal;
							_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow(rowECDEA);
						}
					}
					else if(conf.Estado.Equals("MODIF"))
					{
						rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetByPk(rowEC.IdConfiguracion, conf.IdCondicion);
						if(rowECDData == null)
						{
							rowECD = _data.tui_ConfiguracionGrillaEstilosCondicionalesDet.Newtui_ConfiguracionGrillaEstilosCondicionalesDetRow();
							rowECD.IdConfiguracion = rowEC.IdConfiguracion;
							rowECD.IdCondicion = conf.IdCondicion;
							rowECD.Columna = conf.Columna.Name;
							rowECD.Condicion = conf.Condicion;
							if(!esColumna)
								rowECD.Valor = conf.Valor.ToString();
							else
								rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
							rowECD.FechaCreacion = DateTime.Now;
							rowECD.IdConexionCreacion = Security.IdConexion;
							rowECD.IdReservado = 0;
							rowECD.IdEmpresa = Security.IdEmpresa;			
							rowECD.IdSucursal = Security.IdSucursal;
							_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.Addtui_ConfiguracionGrillaEstilosCondicionalesDetRow(rowECD);

							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosAplicablesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowECDEA = _data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow();
								rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
								rowECDEA.IdCondicion = rowECD.IdCondicion;
								rowECDEA.Propiedad = est.Propiedad;
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEA.Valor = sb.ToString();
										}
										else
											rowECDEA.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEA.Valor = est.Valor.ToString();
										break;
								}		

								rowECDEA.FechaCreacion = DateTime.Now;
								rowECDEA.IdConexionCreacion = Security.IdConexion;
								rowECDEA.IdReservado = 0;
								rowECDEA.IdEmpresa = Security.IdEmpresa;			
								rowECDEA.IdSucursal = Security.IdSucursal;
								_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow(rowECDEA);
							}
						}
						else
						{
							rowECDData.Columna = conf.Columna.Name;
							rowECDData.Condicion = conf.Condicion;
							if(!esColumna)
								rowECDData.Valor = conf.Valor.ToString();
							else
								rowECDData.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
							_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.ImportRow(rowECDData);
							rowECD = _data.tui_ConfiguracionGrillaEstilosCondicionalesDet.FindByIdConfiguracionIdCondicion(rowECDData.IdConfiguracion, rowECDData.IdCondicion);
							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetByPk(rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEAData.Valor = sb.ToString();
										}
										else
											rowECDEAData.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEAData.Valor = est.Valor.ToString();
										break;
								}		
								_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.ImportRow(rowECDEAData);
							}							
						}
						
					}
				}
				else
				{
					if(conf.Estado.Equals("MODIF_NEW") || conf.Estado.Equals("MODIF"))
					{
						_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.ImportRow(rowECDData);
						rowECD = _data.tui_ConfiguracionGrillaEstilosCondicionalesDet.FindByIdConfiguracionIdCondicion(rowECDData.IdConfiguracion, rowECDData.IdCondicion);
					
						foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
						{
							tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetByPk(rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
							switch (est.Propiedad)
							{				
								case "BackColor" :
									rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
									break;
								case "Font" :
									if(est.Valor != null)
									{
										System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
										XmlFont xmlFont= new XmlFont(font);
										XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
										System.Text.StringBuilder sb = new System.Text.StringBuilder();
										System.IO.StringWriter writer = new System.IO.StringWriter(sb);
										ser.Serialize(writer, xmlFont);
										rowECDEAData.Valor = sb.ToString();
									}
									else
										rowECDEAData.Valor = string.Empty;
									break;
								case "ForeColor":
									rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
									break;
								default:
									rowECDEAData.Valor = est.Valor.ToString();
									break;
							}		
							_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.ImportRow(rowECDEAData);
						}
					}
					else if(conf.Estado.Equals("DEL"))
					{
						foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
						{
							tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.GetByPk(rowEC.IdConfiguracion, rowECDData.IdCondicion, est.Propiedad);
							rowECDEAData.Delete();
							_data.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.ImportRow(rowECDEAData);
						}
						rowECDData.Delete();
						_data.tui_ConfiguracionGrillaEstilosCondicionalesDet.ImportRow(rowECDData);
					}

				}
			}

			tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow rowCGEA = tui_ConfiguracionGrillaEstilosAplicables.GetByPk(IdProceso, IdTarea, Grilla.Name, rowEC.IdConfiguracion);
			if(rowCGEA == null)
			{
				tui_ConfiguracionGrillaEstilosAplicablesExDataset.tui_ConfiguracionGrillaEstilosAplicablesRow rowEAB = _data.tui_ConfiguracionGrillaEstilosAplicables.FindByIdProcesoIdTareaGrillaIdConfiguracion(IdProceso, IdTarea, Grilla.Name, rowEC.IdConfiguracion);
				if(rowEAB == null)
				{
					rowEAB = _data.tui_ConfiguracionGrillaEstilosAplicables.Newtui_ConfiguracionGrillaEstilosAplicablesRow();
					rowEAB.IdProceso = IdProceso;
					rowEAB.IdTarea = IdTarea;
					rowEAB.Grilla = Grilla.Name;
					rowEAB.Formulario = Formulario;
					rowEAB.IdConfiguracion = rowEC.IdConfiguracion;
					rowEAB.FechaCreacion = DateTime.Now;
					rowEAB.IdConexionCreacion = Security.IdConexion;
					rowEAB.IdReservado = 0;
					rowEAB.IdEmpresa = Security.IdEmpresa;
					rowEAB.IdSucursal = Security.IdSucursal;
					_data.tui_ConfiguracionGrillaEstilosAplicables.Addtui_ConfiguracionGrillaEstilosAplicablesRow(rowEAB);
				}
			}
			_replication = GenerateReplication();
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesEx.Update(_data, _replication);
			//GUARDO EN MODIFICABLES
			this.SaveModificables(IdProceso, IdTarea, Formulario, Grilla.Name, _configuracionSeleccionada.IdConfiguracion);
			if(ConfiguracionesHasChanged != null)
				ConfiguracionesHasChanged(this, new EventArgs());	

		}

		private void SaveParaUsuarios(Janus.Windows.GridEX.GridEX Grilla)
		{
			_dataUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if(IdProceso.Equals(long.MinValue))
			{
				IdProceso = 0;
				IdTarea = 0;
			}
			foreach(UsuarioView usuario in _usuariosAplicablesSeleccionados)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowECData = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByName(_configuracionSeleccionada.Nombre, usuario.IdUsuario);
				tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowEC = null;
				if(rowECData == null) // No existe configuracion con ese nombre para ese usuario
				{
					rowEC = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow();
					rowEC.IdUsuario = usuario.IdUsuario;
					rowEC.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
					rowEC.Nombre = _configuracionSeleccionada.Nombre;
					rowEC.IdUsuarioCreador = _configuracionSeleccionada.IdUsuarioCreador;
					rowEC.Activo = _configuracionSeleccionada.Activo;
					rowEC.FechaCreacion = _configuracionSeleccionada.Fecha;
					rowEC.IdConexionCreacion = Security.IdConexion;
					rowEC.IdReservado = 0;
					rowEC.IdEmpresa = _configuracionSeleccionada.IdEmpresa;			
					rowEC.IdSucursal = _configuracionSeleccionada.IdSucursal;
					_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Addtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(rowEC);
				}
				else
				{
					_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ImportRow(rowECData);
					rowEC = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.FindByIdUsuarioIdConfiguracion(usuario.IdUsuario, rowECData.IdConfiguracion);
					rowEC.Nombre = _configuracionSeleccionada.Nombre;
				}       

				foreach(ConfiguracionGrillaEstilosCondicionalesDet conf in _configuracionSeleccionada.Detalle)
				{	
					tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowECDData = null;
					bool esColumna = false;
					long IdCondicion;
					if(conf.Valor.GetType().Name.Equals("GridEXColumn"))
					{
						rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetCondicion(usuario.IdUsuario, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
						esColumna = true;
						IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
					}
					else
					{
						rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetCondicion(usuario.IdUsuario, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
						IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
					}
					if(IdCondicion == long.MinValue)
						IdCondicion = systemframework.Util.NewLongId();
					tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowECD = null;
					if(rowECDData == null) //No existe la condicion para la configuracion para ese usuario
					{
						if(conf.Estado.Equals("NEW") || conf.Estado.Equals(string.Empty))
						{
							rowECD = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow();
							rowECD.IdUsuario = usuario.IdUsuario;
							rowECD.IdConfiguracion = rowEC.IdConfiguracion;
							rowECD.IdCondicion = IdCondicion;
							rowECD.Columna = conf.Columna.Name;
							rowECD.Condicion = conf.Condicion;
							if(!esColumna)
								rowECD.Valor = conf.Valor.ToString();
							else
								rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
							rowECD.FechaCreacion = DateTime.Now;
							rowECD.IdConexionCreacion = Security.IdConexion;
							rowECD.IdReservado = 0;
							rowECD.IdEmpresa = Security.IdEmpresa;			
							rowECD.IdSucursal = Security.IdSucursal;
							_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Addtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow(rowECD);

							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowECDEA = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow();
								rowECDEA.IdUsuario = usuario.IdUsuario;
								rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
								rowECDEA.IdCondicion = rowECD.IdCondicion;
								rowECDEA.Propiedad = est.Propiedad;
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEA.Valor = sb.ToString();
										}
										else
											rowECDEA.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEA.Valor = est.Valor.ToString();
										break;
								}		

								rowECDEA.FechaCreacion = DateTime.Now;
								rowECDEA.IdConexionCreacion = Security.IdConexion;
								rowECDEA.IdReservado = 0;
								rowECDEA.IdEmpresa = Security.IdEmpresa;			
								rowECDEA.IdSucursal = Security.IdSucursal;
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow(rowECDEA);
							}
						}
						else if(conf.Estado.Equals("MODIF"))
						{
							rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetByPk(usuario.IdUsuario, rowEC.IdConfiguracion, conf.IdCondicion);
							if(rowECData == null)
							{
								rowECD = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow();
								rowECD.IdUsuario = usuario.IdUsuario;
								rowECD.IdConfiguracion = rowEC.IdConfiguracion;
								rowECD.IdCondicion = IdCondicion;
								rowECD.Columna = conf.Columna.Name;
								rowECD.Condicion = conf.Condicion;
								if(!esColumna)
									rowECD.Valor = conf.Valor.ToString();
								else
									rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
								rowECD.FechaCreacion = DateTime.Now;
								rowECD.IdConexionCreacion = Security.IdConexion;
								rowECD.IdReservado = 0;
								rowECD.IdEmpresa = Security.IdEmpresa;			
								rowECD.IdSucursal = Security.IdSucursal;
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Addtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow(rowECD);

								foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
								{
									tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowECDEA = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow();
									rowECDEA.IdUsuario = usuario.IdUsuario;
									rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
									rowECDEA.IdCondicion = rowECD.IdCondicion;
									rowECDEA.Propiedad = est.Propiedad;
									switch (est.Propiedad)
									{				
										case "BackColor" :
											rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
											break;
										case "Font" :
											if(est.Valor != null)
											{
												System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
												XmlFont xmlFont= new XmlFont(font);
												XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
												System.Text.StringBuilder sb = new System.Text.StringBuilder();
												System.IO.StringWriter writer = new System.IO.StringWriter(sb);
												ser.Serialize(writer, xmlFont);
												rowECDEA.Valor = sb.ToString();
											}
											else
												rowECDEA.Valor = string.Empty;
											break;
										case "ForeColor":
											rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
											break;
										default:
											rowECDEA.Valor = est.Valor.ToString();
											break;
									}		

									rowECDEA.FechaCreacion = DateTime.Now;
									rowECDEA.IdConexionCreacion = Security.IdConexion;
									rowECDEA.IdReservado = 0;
									rowECDEA.IdEmpresa = Security.IdEmpresa;			
									rowECDEA.IdSucursal = Security.IdSucursal;
									_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow(rowECDEA);
								}
							}
							else
							{
								rowECDData.Columna = conf.Columna.Name;
								rowECDData.Condicion = conf.Condicion;
								if(!esColumna)
									rowECDData.Valor = conf.Valor.ToString();
								else
									rowECDData.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.ImportRow(rowECDData);
								rowECD = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.FindByIdUsuarioIdConfiguracionIdCondicion(usuario.IdUsuario, rowECDData.IdConfiguracion, rowECDData.IdCondicion);
					
								foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
								{
									tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetByPk(usuario.IdUsuario, rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
									switch (est.Propiedad)
									{				
										case "BackColor" :
											rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
											break;
										case "Font" :
											if(est.Valor != null)
											{
												System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
												XmlFont xmlFont= new XmlFont(font);
												XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
												System.Text.StringBuilder sb = new System.Text.StringBuilder();
												System.IO.StringWriter writer = new System.IO.StringWriter(sb);
												ser.Serialize(writer, xmlFont);
												rowECDEAData.Valor = sb.ToString();
											}
											else
												rowECDEAData.Valor = string.Empty;
											break;
										case "ForeColor":
											rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
											break;
										default:
											rowECDEAData.Valor = est.Valor.ToString();
											break;
									}		
									_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.ImportRow(rowECDEAData);
								}
							}
						}
					}
					else
					{
						if(conf.Estado.Equals("MODIF_NEW") || conf.Estado.Equals("MODIF"))
						{
							_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.ImportRow(rowECDData);
							rowECD = _dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.FindByIdUsuarioIdConfiguracionIdCondicion(usuario.IdUsuario, rowECDData.IdConfiguracion, rowECDData.IdCondicion);
					
							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetByPk(usuario.IdUsuario, rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEAData.Valor = sb.ToString();
										}
										else
											rowECDEAData.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEAData.Valor = est.Valor.ToString();
										break;
								}		
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.ImportRow(rowECDEAData);
							}
						}					
						else if(conf.Estado.Equals("DEL"))
						{
							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetByPk(usuario.IdUsuario, rowEC.IdConfiguracion, rowECDData.IdCondicion, est.Propiedad);
								rowECDEAData.Delete();
								_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.ImportRow(rowECDEAData);
							}
							rowECDData.Delete();
							_dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.ImportRow(rowECDData);
						}
					}
				}

				tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow rowCGEAU = tui_ConfiguracionGrillaEstilosAplicablesUsuarios.GetByPk(IdProceso, IdTarea, Grilla.Name, usuario.IdUsuario, rowEC.IdConfiguracion);
				if(rowCGEAU == null)
				{
					tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow rowEAB = _dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.FindByIdProcesoIdTareaGrillaIdUsuarioIdConfiguracion(IdProceso, IdTarea, Grilla.Name, usuario.IdUsuario, rowEC.IdConfiguracion);
					if(rowEAB == null)
					{
						rowEAB = _dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.Newtui_ConfiguracionGrillaEstilosAplicablesUsuariosRow();
						rowEAB.IdProceso = IdProceso;
						rowEAB.IdTarea = IdTarea;
						rowEAB.Grilla = Grilla.Name;
						rowEAB.IdUsuario = usuario.IdUsuario;
						rowEAB.Formulario = Formulario;
						rowEAB.IdConfiguracion = rowEC.IdConfiguracion;
						rowEAB.FechaCreacion = DateTime.Now;
						rowEAB.IdConexionCreacion = Security.IdConexion;
						rowEAB.IdReservado = 0;
						rowEAB.IdEmpresa = Security.IdEmpresa;
						rowEAB.IdSucursal = Security.IdSucursal;
						_dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.Addtui_ConfiguracionGrillaEstilosAplicablesUsuariosRow(rowEAB);
					}
				}

			}
			_replication = GenerateReplication();
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesUsuariosEx.Update(_dataUsuarios, _replication);
			//GUARDO EN MODIFICABLES
			this.SaveModificables(IdProceso, IdTarea, Formulario, Grilla.Name, _configuracionSeleccionada.IdConfiguracion);
			if(ConfiguracionesHasChanged != null)
				ConfiguracionesHasChanged(this, new EventArgs());	

		}





		private void SaveParaPerfiles(Janus.Windows.GridEX.GridEX Grilla)
		{
			_dataPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if(IdProceso.Equals(long.MinValue))
			{
				IdProceso = 0;
				IdTarea = 0;
			}
			foreach(PerfilView perfil in _perfilesAplicablesSeleccionados)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowECData = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetByName(_configuracionSeleccionada.Nombre, perfil.IdPerfil);
				tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowEC = null;
				if(rowECData == null) // No existe configuracion con ese nombre para ese perfil
				{
					rowEC = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Newtui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow();
					rowEC.IdPerfil = perfil.IdPerfil;
					rowEC.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
					rowEC.Nombre = _configuracionSeleccionada.Nombre;
					rowEC.IdUsuarioCreador = _configuracionSeleccionada.IdUsuarioCreador;
					rowEC.Activo = _configuracionSeleccionada.Activo;
					rowEC.FechaCreacion = _configuracionSeleccionada.Fecha;
					rowEC.IdConexionCreacion = Security.IdConexion;
					rowEC.IdReservado = 0;
					rowEC.IdEmpresa = _configuracionSeleccionada.IdEmpresa;			
					rowEC.IdSucursal = _configuracionSeleccionada.IdSucursal;
					_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Addtui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow(rowEC);
				}
				else
				{
					_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.ImportRow(rowECData);
					rowEC = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.FindByIdPerfilIdConfiguracion(perfil.IdPerfil, rowECData.IdConfiguracion);
					rowEC.Nombre = _configuracionSeleccionada.Nombre;
				}       

				foreach(ConfiguracionGrillaEstilosCondicionalesDet conf in _configuracionSeleccionada.Detalle)
				{	
					tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowECDData = null;
					bool esColumna = false;
					long IdCondicion;
					if(conf.Valor.GetType().Name.Equals("GridEXColumn"))
					{
						rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetCondicion(perfil.IdPerfil, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
						esColumna = true;
						IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, string.Empty, ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key);
					}
					else
					{
						rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetCondicion(perfil.IdPerfil, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
						IdCondicion = tui_ConfiguracionGrillaEstilosCondicionalesDetEx.GetIdCondicion(_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles, rowEC.IdConfiguracion, conf.Columna.Name, conf.Condicion, conf.Valor.ToString(), string.Empty);
					}
					if(IdCondicion == long.MinValue)
						IdCondicion = systemframework.Util.NewLongId();
					tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowECD = null;
					if(rowECDData == null) //No existe la condicion para la configuracion para ese perfil
					{
						if(conf.Estado.Equals("NEW") || conf.Estado.Equals(string.Empty))
						{
							rowECD = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Newtui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow();
							rowECD.IdPerfil = perfil.IdPerfil;
							rowECD.IdConfiguracion = rowEC.IdConfiguracion;
							rowECD.IdCondicion = IdCondicion;
							rowECD.Columna = conf.Columna.Name;
							rowECD.Condicion = conf.Condicion;
							if(!esColumna)
								rowECD.Valor = conf.Valor.ToString();
							else
								rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
							rowECD.FechaCreacion = DateTime.Now;
							rowECD.IdConexionCreacion = Security.IdConexion;
							rowECD.IdReservado = 0;
							rowECD.IdEmpresa = Security.IdEmpresa;			
							rowECD.IdSucursal = Security.IdSucursal;
							_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Addtui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow(rowECD);

							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowECDEA = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow();
								rowECDEA.IdPerfil = perfil.IdPerfil;
								rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
								rowECDEA.IdCondicion = rowECD.IdCondicion;
								rowECDEA.Propiedad = est.Propiedad;
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEA.Valor = sb.ToString();
										}
										else
											rowECDEA.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEA.Valor = est.Valor.ToString();
										break;
								}		

								rowECDEA.FechaCreacion = DateTime.Now;
								rowECDEA.IdConexionCreacion = Security.IdConexion;
								rowECDEA.IdReservado = 0;
								rowECDEA.IdEmpresa = Security.IdEmpresa;			
								rowECDEA.IdSucursal = Security.IdSucursal;
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow(rowECDEA);
							}
						}
						else if(conf.Estado.Equals("MODIF"))
						{
							rowECDData = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetByPk(perfil.IdPerfil, rowEC.IdConfiguracion, conf.IdCondicion);
							if(rowECDData == null)
							{
								rowECD = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Newtui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow();
								rowECD.IdPerfil = perfil.IdPerfil;
								rowECD.IdConfiguracion = rowEC.IdConfiguracion;
								rowECD.IdCondicion = IdCondicion;
								rowECD.Columna = conf.Columna.Name;
								rowECD.Condicion = conf.Condicion;
								if(!esColumna)
									rowECD.Valor = conf.Valor.ToString();
								else
									rowECD.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
								rowECD.FechaCreacion = DateTime.Now;
								rowECD.IdConexionCreacion = Security.IdConexion;
								rowECD.IdReservado = 0;
								rowECD.IdEmpresa = Security.IdEmpresa;			
								rowECD.IdSucursal = Security.IdSucursal;
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Addtui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow(rowECD);

								foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
								{
									tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowECDEA = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Newtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow();
									rowECDEA.IdPerfil = perfil.IdPerfil;
									rowECDEA.IdConfiguracion = rowEC.IdConfiguracion;
									rowECDEA.IdCondicion = rowECD.IdCondicion;
									rowECDEA.Propiedad = est.Propiedad;
									switch (est.Propiedad)
									{				
										case "BackColor" :
											rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
											break;
										case "Font" :
											if(est.Valor != null)
											{
												System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
												XmlFont xmlFont= new XmlFont(font);
												XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
												System.Text.StringBuilder sb = new System.Text.StringBuilder();
												System.IO.StringWriter writer = new System.IO.StringWriter(sb);
												ser.Serialize(writer, xmlFont);
												rowECDEA.Valor = sb.ToString();
											}
											else
												rowECDEA.Valor = string.Empty;
											break;
										case "ForeColor":
											rowECDEA.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
											break;
										default:
											rowECDEA.Valor = est.Valor.ToString();
											break;
									}		

									rowECDEA.FechaCreacion = DateTime.Now;
									rowECDEA.IdConexionCreacion = Security.IdConexion;
									rowECDEA.IdReservado = 0;
									rowECDEA.IdEmpresa = Security.IdEmpresa;			
									rowECDEA.IdSucursal = Security.IdSucursal;
									_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Addtui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow(rowECDEA);
								}
							}
							else
							{
								rowECDData.Columna = conf.Columna.Name;
								rowECDData.Condicion = conf.Condicion;
								if(!esColumna)
									rowECDData.Valor = conf.Valor.ToString();
								else
									rowECDData.ValorColumna = ((Janus.Windows.GridEX.GridEXColumn)conf.Valor).Key;
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.ImportRow(rowECDData);
								rowECD = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.FindByIdPerfilIdConfiguracionIdCondicion(perfil.IdPerfil, rowECDData.IdConfiguracion, rowECDData.IdCondicion);
					
								foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
								{
									tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetByPk(perfil.IdPerfil, rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
									switch (est.Propiedad)
									{				
										case "BackColor" :
											rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
											break;
										case "Font" :
											if(est.Valor != null)
											{
												System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
												XmlFont xmlFont= new XmlFont(font);
												XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
												System.Text.StringBuilder sb = new System.Text.StringBuilder();
												System.IO.StringWriter writer = new System.IO.StringWriter(sb);
												ser.Serialize(writer, xmlFont);
												rowECDEAData.Valor = sb.ToString();
											}
											else
												rowECDEAData.Valor = string.Empty;
											break;
										case "ForeColor":
											rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
											break;
										default:
											rowECDEAData.Valor = est.Valor.ToString();
											break;
									}		
									_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.ImportRow(rowECDEAData);
								}
							}
						}
					}
					else
					{
						if(conf.Estado.Equals("MODIF_NEW") || conf.Estado.Equals("MODIF"))
						{
							_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.ImportRow(rowECDData);
							rowECD = _dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.FindByIdPerfilIdConfiguracionIdCondicion(perfil.IdPerfil, rowECDData.IdConfiguracion, rowECDData.IdCondicion);
					
							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetByPk(perfil.IdPerfil, rowEC.IdConfiguracion, rowECD.IdCondicion, est.Propiedad);
								switch (est.Propiedad)
								{				
									case "BackColor" :
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();					
										break;
									case "Font" :
										if(est.Valor != null)
										{
											System.Drawing.Font font = ((System.Drawing.Font)est.Valor);
											XmlFont xmlFont= new XmlFont(font);
											XmlSerializer ser = new XmlSerializer(typeof(XmlFont));
											System.Text.StringBuilder sb = new System.Text.StringBuilder();
											System.IO.StringWriter writer = new System.IO.StringWriter(sb);
											ser.Serialize(writer, xmlFont);
											rowECDEAData.Valor = sb.ToString();
										}
										else
											rowECDEAData.Valor = string.Empty;
										break;
									case "ForeColor":
										rowECDEAData.Valor = ((System.Drawing.Color)est.Valor).ToArgb().ToString();	
										break;
									default:
										rowECDEAData.Valor = est.Valor.ToString();
										break;
								}		
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.ImportRow(rowECDEAData);
							}
						}
						else if(conf.Estado.Equals("DEL"))
						{
							foreach(ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados est in conf.EstilosAplicados)
							{
								tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfilesRow rowECDEAData = tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.GetByPk(perfil.IdPerfil, rowEC.IdConfiguracion, rowECDData.IdCondicion, est.Propiedad);
								rowECDEAData.Delete();
								_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.ImportRow(rowECDEAData);
							}
							rowECDData.Delete();
							_dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.ImportRow(rowECDData);
						}
					}
				}

				tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow rowCGEAP = tui_ConfiguracionGrillaEstilosAplicablesPerfiles.GetByPk(IdProceso, IdTarea, Grilla.Name, perfil.IdPerfil, rowEC.IdConfiguracion);
				if(rowCGEAP == null)
				{
					tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow rowEAB = _dataPerfiles.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.FindByIdProcesoIdTareaGrillaIdPerfilIdConfiguracion(IdProceso, IdTarea, Grilla.Name, perfil.IdPerfil, rowEC.IdConfiguracion);
					if(rowEAB == null)
					{
						rowEAB = _dataPerfiles.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Newtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow();
						rowEAB.IdProceso = IdProceso;
						rowEAB.IdTarea = IdTarea;
						rowEAB.Grilla = Grilla.Name;
						rowEAB.IdPerfil = perfil.IdPerfil;
						rowEAB.Formulario = Formulario;
						rowEAB.IdConfiguracion = rowEC.IdConfiguracion;
						rowEAB.FechaCreacion = DateTime.Now;
						rowEAB.IdConexionCreacion = Security.IdConexion;
						rowEAB.IdReservado = 0;
						rowEAB.IdEmpresa = Security.IdEmpresa;
						rowEAB.IdSucursal = Security.IdSucursal;
						_dataPerfiles.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Addtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(rowEAB);
					}
				}

			}

			_replication = GenerateReplication();
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesPerfilesEx.Update(_dataPerfiles, _replication);
			//GUARDO EN MODIFICABLES
			this.SaveModificables(IdProceso, IdTarea, Formulario, Grilla.Name, _configuracionSeleccionada.IdConfiguracion);
			if(ConfiguracionesHasChanged != null)
				ConfiguracionesHasChanged(this, new EventArgs());	
		}

		private void SaveModificables(long IdProceso, long IdTarea, string Formulario, string NombreGrilla, long IdConfiguracion)
		{
			if(this.PermiteModificarAplicablesModificables)
			{
				if(_todosModificables)
				{
					_dataModificables = new tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset();
					tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow rowEAM = tui_ConfiguracionGrillaEstilosAplicablesModificables.GetByPk(IdProceso, IdTarea, NombreGrilla, IdConfiguracion);
					if(rowEAM == null)
					{
						rowEAM = _dataModificables.tui_ConfiguracionGrillaEstilosAplicablesModificables.Newtui_ConfiguracionGrillaEstilosAplicablesModificablesRow();
						rowEAM.IdProceso = IdProceso;
						rowEAM.IdTarea = IdTarea;
						rowEAM.Grilla = NombreGrilla;
						rowEAM.Formulario = Formulario;
						rowEAM.IdConfiguracion = IdConfiguracion;
						rowEAM.FechaCreacion = DateTime.Now;
						rowEAM.IdConexionCreacion = Security.IdConexion;
						rowEAM.IdReservado = 0;
						rowEAM.IdEmpresa = Security.IdEmpresa;
						rowEAM.IdSucursal = Security.IdSucursal;
						_dataModificables.tui_ConfiguracionGrillaEstilosAplicablesModificables.Addtui_ConfiguracionGrillaEstilosAplicablesModificablesRow(rowEAM);						
						dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.Update(_dataModificables.tui_ConfiguracionGrillaEstilosAplicablesModificables);
					}
				}
				else if(_porUsuarioModificables)
				{
					_dataModificablesUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset();
					foreach(UsuarioView usuario in _usuariosAplicablesModificablesSeleccionados)
					{
						tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosRow rowEAMU = tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.GetByPk(IdProceso, IdTarea, NombreGrilla, usuario.IdUsuario, IdConfiguracion);
						if(rowEAMU == null)
						{
							rowEAMU = _dataModificablesUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Newtui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosRow();
							rowEAMU.IdProceso = IdProceso;
							rowEAMU.IdTarea = IdTarea;
							rowEAMU.Grilla = NombreGrilla;
							rowEAMU.Formulario = Formulario;
							rowEAMU.IdUsuario = usuario.IdUsuario;
							rowEAMU.IdConfiguracion = IdConfiguracion;
							rowEAMU.FechaCreacion = DateTime.Now;
							rowEAMU.IdConexionCreacion = Security.IdConexion;
							rowEAMU.IdReservado = 0;
							rowEAMU.IdEmpresa = Security.IdEmpresa;
							rowEAMU.IdSucursal = Security.IdSucursal;
							_dataModificablesUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Addtui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosRow(rowEAMU);						
						}
					}
					dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Update(_dataModificablesUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios);
				}
				else if(_porPerfilModificables)
				{
					_dataModificablesPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset();
					foreach(PerfilView perfil in _perfilesAplicablesModificablesSeleccionados)
					{
						tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesRow rowEAMP = tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.GetByPk(IdProceso, IdTarea, NombreGrilla, perfil.IdPerfil, IdConfiguracion);
						if(rowEAMP == null)
						{
							rowEAMP = _dataModificablesPerfiles.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.Newtui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesRow();
							rowEAMP.IdProceso = IdProceso;
							rowEAMP.IdTarea = IdTarea;
							rowEAMP.Grilla = NombreGrilla;
							rowEAMP.Formulario = Formulario;
							rowEAMP.IdPerfil = perfil.IdPerfil;
							rowEAMP.IdConfiguracion = IdConfiguracion;
							rowEAMP.FechaCreacion = DateTime.Now;
							rowEAMP.IdConexionCreacion = Security.IdConexion;
							rowEAMP.IdReservado = 0;
							rowEAMP.IdEmpresa = Security.IdEmpresa;
							rowEAMP.IdSucursal = Security.IdSucursal;
							_dataModificablesPerfiles.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.Addtui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesRow(rowEAMP);						
						}
					}
					dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.Update(_dataModificablesPerfiles.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles);
				}
			}
		}


		private void AplicarATodos(Janus.Windows.GridEX.GridEX Grilla)
		{
			_dataAplicado = new tui_ConfiguracionGrillaEstiloAplicadoDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			tui_ConfiguracionGrillaEstiloAplicadoDataset dataEA = tui_ConfiguracionGrillaEstiloAplicado.GetList(IdProceso, IdTarea, Grilla.Name, Formulario, _configuracionSeleccionada.IdConfiguracion);
			if(dataEA.tui_ConfiguracionGrillaEstiloAplicado.Rows.Count == 0) // No existe esa configuracion para la grilla
			{
				tui_ConfiguracionGrillaEstiloAplicadoDataset.tui_ConfiguracionGrillaEstiloAplicadoRow rowEAE = tui_ConfiguracionGrillaEstiloAplicado.GetConfiguracionAplicada(IdProceso, IdTarea, Grilla.Name, Formulario);
				if(rowEAE != null)//Hay otra configuracion aplicada
				{
					rowEAE.Delete();
					_dataAplicado.tui_ConfiguracionGrillaEstiloAplicado.ImportRow(rowEAE);
				}
				tui_ConfiguracionGrillaEstiloAplicadoDataset.tui_ConfiguracionGrillaEstiloAplicadoRow rowEA = _dataAplicado.tui_ConfiguracionGrillaEstiloAplicado.Newtui_ConfiguracionGrillaEstiloAplicadoRow();
				if(IdProceso.Equals(long.MinValue))
				{
					rowEA.IdProceso = 0;
					rowEA.IdTarea = 0;
				}
				else
				{
					rowEA.IdProceso = IdProceso;
					rowEA.IdTarea = IdTarea;
				}
				rowEA.Formulario = Formulario;
				rowEA.Grilla = Grilla.Name;
				rowEA.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
				rowEA.FechaCreacion = DateTime.Now;
				rowEA.IdConexionCreacion = Security.IdConexion;
				rowEA.IdReservado = 0;
				rowEA.IdEmpresa = Security.IdEmpresa;			
				rowEA.IdSucursal = Security.IdSucursal;
				_dataAplicado.tui_ConfiguracionGrillaEstiloAplicado.Addtui_ConfiguracionGrillaEstiloAplicadoRow(rowEA);
				dataaccess.tui_ConfiguracionGrillaEstiloAplicado.Update(_dataAplicado);
				IdConfiguracionAplicada = rowEA.IdConfiguracion;
				if(ConfiguracionGrillaHasChanged != null)
					ConfiguracionGrillaHasChanged(this, new EventArgs());	

			}
		}


		private void AplicarAUsuarios(Janus.Windows.GridEX.GridEX Grilla)
		{
			_dataUsuariosAplicado = new tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if(IdProceso.Equals(long.MinValue))
			{
				IdProceso = 0;
				IdTarea = 0;
			}
			foreach(UsuarioView usuario in _usuariosSeleccionados)
			{
				tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset dataEA = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList(usuario.IdUsuario, IdProceso, IdTarea, Grilla.Name, Formulario, _configuracionSeleccionada.IdConfiguracion);
				if(dataEA.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows.Count == 0) // No existe esa configuracion para la grilla
				{
					tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow rowEAEU = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetConfiguracionAplicada(usuario.IdUsuario, IdProceso, IdTarea, Grilla.Name, Formulario);
					if(rowEAEU != null)//Hay otra configuracion aplicada
					{
						rowEAEU.Delete();
						_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.ImportRow(rowEAEU);
					}
					tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow rowEA = _dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Newtui_ConfiguracionGrillaEstiloAplicadoUsuariosRow();
					rowEA.IdProceso = IdProceso;
					rowEA.IdTarea = IdTarea;
					rowEA.IdUsuario = usuario.IdUsuario;
					rowEA.Formulario = Formulario;
					rowEA.Grilla = Grilla.Name;
					rowEA.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
					rowEA.FechaCreacion = DateTime.Now;
					rowEA.IdConexionCreacion = Security.IdConexion;
					rowEA.IdReservado = 0;
					rowEA.IdEmpresa = Security.IdEmpresa;			
					rowEA.IdSucursal = Security.IdSucursal;
					_dataUsuariosAplicado.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Addtui_ConfiguracionGrillaEstiloAplicadoUsuariosRow(rowEA);

				}
			}
			IdConfiguracionAplicada = _configuracionSeleccionada.IdConfiguracion;
			dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update(_dataUsuariosAplicado);
			if(ConfiguracionGrillaHasChanged != null)
				ConfiguracionGrillaHasChanged(this, new EventArgs());	
		}


		private void AplicarAPerfiles(Janus.Windows.GridEX.GridEX Grilla)
		{
			_dataPerfilesAplicado = new tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset();
			long IdProceso = mz.erp.businessrules.Workflow.GetIdProcessByName(ProcessName);
			long IdTarea = mz.erp.businessrules.Workflow.GetIdTakByName(TaskName);
			if(IdProceso.Equals(long.MinValue))
			{
				IdProceso = 0;
				IdTarea = 0;
			}
			foreach(PerfilView perfil in _perfilesSeleccionados)
			{
				tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset dataEA = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList(perfil.IdPerfil, IdProceso, IdTarea, Grilla.Name, Formulario, _configuracionSeleccionada.IdConfiguracion);
				if(dataEA.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows.Count == 0) // No existe esa configuracion para la grilla
				{
					tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow rowEAEP = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetConfiguracionAplicada(perfil.IdPerfil, IdProceso, IdTarea, Grilla.Name, Formulario);
					if(rowEAEP != null)//Hay otra configuracion aplicada
					{
						rowEAEP.Delete();
						_dataPerfilesAplicado.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.ImportRow(rowEAEP);
					}

					tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow rowEA = _dataPerfilesAplicado.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Newtui_ConfiguracionGrillaEstiloAplicadoPerfilesRow();
					rowEA.IdProceso = IdProceso;
					rowEA.IdTarea = IdTarea;
					rowEA.IdPerfil = perfil.IdPerfil;
					rowEA.Formulario = Formulario;
					rowEA.Grilla = Grilla.Name;
					rowEA.IdConfiguracion = _configuracionSeleccionada.IdConfiguracion;
					rowEA.FechaCreacion = DateTime.Now;
					rowEA.IdConexionCreacion = Security.IdConexion;
					rowEA.IdReservado = 0;
					rowEA.IdEmpresa = Security.IdEmpresa;			
					rowEA.IdSucursal = Security.IdSucursal;
					_dataPerfilesAplicado.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Addtui_ConfiguracionGrillaEstiloAplicadoPerfilesRow(rowEA);

				}
			}
			dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update(_dataPerfilesAplicado);
			IdConfiguracionAplicada = _configuracionSeleccionada.IdConfiguracion;
			if(ConfiguracionGrillaHasChanged != null)
				ConfiguracionGrillaHasChanged(this, new EventArgs());	

		}


		private void RemoveModificables()
		{
			_dataModificables = new tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset();
			tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset data = tui_ConfiguracionGrillaEstilosAplicablesModificables.GetList(_configuracionSeleccionada.IdConfiguracion);
			foreach(tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row in data.tui_ConfiguracionGrillaEstilosAplicablesModificables.Rows)
			{
				row.Delete();
                _dataModificables.tui_ConfiguracionGrillaEstilosAplicablesModificables.ImportRow(row);
			}
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.Update(_dataModificables);

			_dataModificablesUsuarios = new tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset();
			tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset dataUsuarios = tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.GetList(_configuracionSeleccionada.IdConfiguracion);
			foreach(tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosRow rowU in dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Rows)
			{
				rowU.Delete();
				_dataModificablesUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.ImportRow(rowU);
			}
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Update(_dataModificablesUsuarios);

			_dataModificablesPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset();
			tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset dataPerfiles = tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.GetList(_configuracionSeleccionada.IdConfiguracion);
			foreach(tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesRow rowP in dataPerfiles.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.Rows)
			{
				rowP.Delete();
				_dataModificablesPerfiles.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.ImportRow(rowP);
			}
			dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.Update(_dataModificablesPerfiles);

		}

		private bool ExisteConfiguracionEnAplicablesTodosPerfiles(string IdUsuario, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			bool existe = this.ExisteConfiguracionEnAplicables(IdProceso, IdTarea, Grilla, IdConfiguracion);
			if(!existe)
			{
				sy_PerfilesUsuariosEmpresasDataset dataPerfilesUsuario = sy_PerfilesUsuariosEmpresas.GetList(IdUsuario, Security.IdEmpresa);
				int i = 0;
				while(!existe && i < dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows.Count)
				{
					sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row = (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow)dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows[i];
					existe = this.ExisteConfiguracionEnAplicablesPerfiles(row.IdPerfil, IdProceso, IdTarea, Grilla, IdConfiguracion);
					i++;
				}
			}
			return existe;
		}


		private bool ExisteConfiguracionEnAplicablesPerfilesUsuarios(string IdUsuario, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			bool existe = this.ExisteConfiguracionEnAplicablesUsuarios(IdUsuario, IdProceso, IdTarea, Grilla, IdConfiguracion);
			if(!existe)
			{
				sy_PerfilesUsuariosEmpresasDataset dataPerfilesUsuario = sy_PerfilesUsuariosEmpresas.GetList(IdUsuario, Security.IdEmpresa);
				int i = 0;
				while(!existe && i < dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows.Count)
				{
					sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row = (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow)dataPerfilesUsuario.sy_PerfilesUsuariosEmpresas.Rows[i];
					existe = this.ExisteConfiguracionEnAplicablesPerfiles(row.IdPerfil, IdProceso, IdTarea, Grilla, IdConfiguracion);
					i++;
				}
			}
			return existe;
		}

		private bool ExisteConfiguracionEnAplicables(long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow row = tui_ConfiguracionGrillaEstilosAplicables.GetByPk(IdProceso, IdTarea, Grilla, IdConfiguracion);
			return (row != null);
		}

		private bool ExisteConfiguracionEnAplicablesTodosUsuarios(string IdUsuario, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow row = tui_ConfiguracionGrillaEstilosAplicablesUsuarios.GetByPk(IdProceso, IdTarea, Grilla, IdUsuario, IdConfiguracion);
			bool existe = row != null;
			if(!existe)
				existe = this.ExisteConfiguracionEnAplicables(IdProceso, IdTarea, Grilla, IdConfiguracion);
			return existe;
		}

		private bool ExisteConfiguracionEnAplicablesPerfiles(long IdPerfil, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow row = tui_ConfiguracionGrillaEstilosAplicablesPerfiles.GetByPk(IdProceso, IdTarea, Grilla, IdPerfil, IdConfiguracion);
			return (row != null);
		}

		private bool ExisteConfiguracionEnAplicablesUsuarios(string IdUsuario, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow row = tui_ConfiguracionGrillaEstilosAplicablesUsuarios.GetByPk(IdProceso, IdTarea, Grilla, IdUsuario, IdConfiguracion);
			return (row != null);
		}

	
		private void SetCombosData()
		{
			DataTable usuariosDT = sy_Usuarios.GetList().sy_Usuarios;
			foreach (System.Data.DataRow row in usuariosDT.Rows)
			{
				string id = row["IdUsuario"].ToString();
				string nombre = row["Nombre"].ToString();
				UsuarioView us = new UsuarioView(id, nombre);
				_usuarios.Add(us);

			}

			DataTable perfilesDT = sy_Perfiles.GetList().sy_Perfiles;
			foreach (System.Data.DataRow row in perfilesDT.Rows)
			{
				long id = (long)row["IdPerfil"];
				string descripcion = row["Descripcion"].ToString();
				PerfilView perfil = new PerfilView(id, descripcion);
				_perfiles.Add(perfil);
			}
		}

		private ArrayList GetColumnas(string type)
		{
			ArrayList cols = new ArrayList();
			foreach(ColumnaView col in _columnas)
			{
				if(col.Type.Equals(type))
					cols.Add(col);
			}
			return cols;
		}

		private int getCondicionConfiguracionIndex(ColumnaView Columna, string Condicion, object Valor)
		{
			int index = -1;
			if(_configuracionSeleccionada != null)
			{
				int i = 0;
				while(index == -1 && i < _configuracionSeleccionada.Detalle.Count)
				{
					ConfiguracionGrillaEstilosCondicionalesDet conf = (ConfiguracionGrillaEstilosCondicionalesDet)_configuracionSeleccionada.Detalle[i];
					if(conf.Columna.Name.Equals(Columna.Name) && conf.Condicion.Equals(Condicion) && conf.Valor.Equals(Valor))
						index = i;
					i++;
				}
			}
			return index;
		}

		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_CuentasObservacionesTipos";			
			return replication;
		}

		#endregion

		public class ColumnaView
		{
			public ColumnaView(string caption, string type, string name, Janus.Windows.GridEX.GridEXColumn realColumn)
			{
				_caption = caption;
				_type = type;
				_name = name;
				_realColumn = realColumn;
			}

			private string _caption;
			public string Caption 
			{
				get {return _caption;}
			}

			private string _type;
			public string Type 
			{
				get {return _type;}
			}

			private string _name;
			public string Name 
			{
				get {return _name;}
			}

			Janus.Windows.GridEX.GridEXColumn _realColumn = null;
			public Janus.Windows.GridEX.GridEXColumn RealColumn
			{
				get {return _realColumn;}
			}
			
			public override System.String ToString()
			{
				return _caption;
			}

			public override System.Boolean Equals ( System.Object obj )
			{
				ColumnaView colView = (ColumnaView) obj;
				return this.Caption.Equals(colView.Caption) && this.Name.Equals(colView.Name) && this.Type.Equals(colView.Type);
			}

			public static string StringType
			{
				get{return "STRING";} 
			}

			public static string DecimalType
			{
				get{return "DECIMAL";} 
			}
			public static string BoolType
			{
				get{return "BOOL";} 
			}
			public static string DateTimeType
			{
				get{return "DATETIME";} 
			}
			public static string IntType
			{
				get{return "INT";} 
			}
		}

		public class ConfiguracionGrillaEstilosCondicionales
		{
			#region Constructores
			public ConfiguracionGrillaEstilosCondicionales(long IdConfiguracion, string Nombre, string IdUsuarioCreador, bool Activo, DateTime Fecha, long IdEmpresa, long IdSucursal, string Estado)
			{		
				_idConfiguracion = IdConfiguracion;
				_nombre = Nombre;		
				_idUsuarioCreador = IdUsuarioCreador;
				_activo = Activo;
				_fecha = Fecha;
				_idEmpresa = IdEmpresa;
				_idSucursal = IdSucursal;
				_estado = Estado;
			}
			#endregion

			#region Propiedades
			private long _idConfiguracion;
			public long IdConfiguracion 
			{
				get {return _idConfiguracion;}
				set {_idConfiguracion = value;}
			}

			private string _nombre;
			public string Nombre 
			{
				get {return _nombre;}
				set {_nombre = value;}
			}

			private string _idUsuarioCreador;
			public string IdUsuarioCreador 
			{
				get {return _idUsuarioCreador;}
				set {_idUsuarioCreador = value;}
			}

			private bool _activo;
			public bool Activo 
			{
				get {return _activo;}
				set {_activo = value;}
			}

			private DateTime _fecha;
			public DateTime Fecha 
			{
				get {return _fecha;}
			}

			private long _idEmpresa;
			public long IdEmpresa 
			{
				get {return _idEmpresa;}
				set {_idEmpresa = value;}
			}

			private long _idSucursal;
			public long IdSucursal 
			{
				get {return _idSucursal;}
				set {_idSucursal = value;}
			}
			
			private ArrayList _detalle = new ArrayList();
			public ArrayList Detalle 
			{
				get {return _detalle;}
			}

			private string _estado;
			public string Estado 
			{
				get {return _estado;}
				set {_estado = value;}
			}

			#endregion

			#region Métodos Públicos
			public void AddCondicion(ConfiguracionGrillaEstilosCondicionalesDet condicion)
			{
				_detalle.Add(condicion);
			}
			#endregion


		}

		public class ConfiguracionGrillaEstilosCondicionalesDet
		{
			#region Constructores
			public ConfiguracionGrillaEstilosCondicionalesDet(long IdCondicion, ColumnaView Columna, string Condicion, object Valor, MyGridEXFormatStyle Estilo, string Estado)
			{		
				_columna = Columna;		
				_condicion = Condicion;
				_valor = Valor;
				_estilosAplicados = Estilo.Propiedades();
				_estilos = Estilo.ToString();
				_estilo = Estilo;
				_estado = Estado;
				_idCondicion = IdCondicion;
			}

			#endregion

			#region Propiedades

			private long _idCondicion;
			public long IdCondicion 
			{
				get {return _idCondicion;}
				set {_idCondicion = value;}
			}

			private ColumnaView _columna;
			public ColumnaView Columna 
			{
				get {return _columna;}
				set {_columna = value;}
			}

			private string _condicion;
			public string Condicion 
			{
				get {return _condicion;}
				set {_condicion  = value;}
			}

			private object _valor;
			public object Valor 
			{
				get {return _valor;}
				set {_valor = value;}
			}
			public string ValorString
			{
				get 
				{
					if(_valor.GetType().Name.Equals("GridEXColumn"))
						return ((Janus.Windows.GridEX.GridEXColumn) _valor).Caption;
					return _valor.ToString();
				}
			}

			private ArrayList _estilosAplicados = new ArrayList();
			public ArrayList EstilosAplicados 
			{
				get {return _estilosAplicados;}
				set {_estilosAplicados = value;}
			}

			private string _estilos;
			public string Estilos
			{
				get {return _estilos;}
				set {_estilos = value;}
			}

			private MyGridEXFormatStyle _estilo;
			public MyGridEXFormatStyle Estilo
			{
				get {return _estilo;}
				set {_estilo = value;}
			}

			private string _estado;
			public string Estado
			{
				get {return _estado;}
				set{_estado = value;}
			}
			#endregion
		}

		public class ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados
		{
			public ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados(string Propiedad, object Valor)
			{		
				_propiedad = Propiedad;		
				_valor = Valor;
			}
			private string _propiedad;
			public string Propiedad 
			{
				get {return _propiedad;}
			}

			private object _valor;
			public object Valor 
			{
				get {return _valor;}
			}

		}

		public class MyGridEXFormatStyle
		{
			public MyGridEXFormatStyle(Janus.Windows.GridEX.GridEXFormatStyle FormatStyle)
			{		
				_formatStyle = FormatStyle;
			}

			private Janus.Windows.GridEX.GridEXFormatStyle _formatStyle;

			public System.Drawing.Color ColorDeFondo 
			{
				get {return _formatStyle.BackColor;}
				set {_formatStyle.BackColor = value;}
			}

			public System.Drawing.Font Fuente 
			{
				get {return _formatStyle.Font;}
				set {_formatStyle.Font = value;}
			}

			public Janus.Windows.GridEX.TriState Negrita 
			{
				get {return _formatStyle.FontBold;}
				set {_formatStyle.FontBold = value;}
			}

			public Janus.Windows.GridEX.TriState Italica 
			{
				get {return _formatStyle.FontItalic;}
				set {_formatStyle.FontItalic = value;}
			}

			public float TamañoLetra 
			{
				get {return _formatStyle.FontSize;}
				set {_formatStyle.FontSize = value;}
			}

			public System.Drawing.Color ColorLetra 
			{
				get {return _formatStyle.ForeColor;}
				set {_formatStyle.ForeColor = value;}
			}

			public Janus.Windows.GridEX.TextAlignment AlineacionTexto 
			{
				get {return _formatStyle.TextAlignment;}
				set {_formatStyle.TextAlignment = value;}
			}

			public ArrayList Propiedades()
			{
				ArrayList prop = new ArrayList();
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("BackColor", _formatStyle.BackColor));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("Font", _formatStyle.Font));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("FontBold", _formatStyle.FontBold));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("FontItalic", _formatStyle.FontItalic));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("FontSize", _formatStyle.FontSize));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("ForeColor", _formatStyle.ForeColor));
				prop.Add(new ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados("TextAlignment", _formatStyle.TextAlignment));
				return prop;
			}

			public override System.String ToString()
			{
				
				string str = "ColorDeFondo: " + _formatStyle.BackColor.ToString() + "; ";
				if(_formatStyle.Font != null)
                    str = str + "Fuente: " + _formatStyle.Font.ToString() + "; ";
				str = str + "Negrita: " + _formatStyle.FontBold.ToString() + "; "
					 + "Itálica: " + _formatStyle.FontItalic.ToString() + "; "
					 + "Tamaño de Letra: " + _formatStyle.FontSize.ToString() + "; "
					 + "Color Letra: " + _formatStyle.ForeColor.ToString() + "; "
					 + "Alineación Texto: " + _formatStyle.TextAlignment.ToString() + "; ";
				return str;
			}

			public Janus.Windows.GridEX.GridEXFormatStyle ToFormatStyle() 
			{
				return _formatStyle;
			}

		}

		public struct XmlFont
		{
			public string FontFamily;
			public GraphicsUnit GraphicsUnit;
			public float Size;
			public FontStyle Style;

			public XmlFont(Font f)
			{
				FontFamily = f.FontFamily.Name;
				GraphicsUnit = f.Unit;
				Size = f.Size;
				Style = f.Style;
			}

			public Font ToFont()
			{
				return new Font(FontFamily, Size, Style, 
					GraphicsUnit);
			}
		}

	}
}
