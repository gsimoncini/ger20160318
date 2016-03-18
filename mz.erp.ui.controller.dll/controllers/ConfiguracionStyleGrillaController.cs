using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConfiguracionStyleGrillaController.
	/// </summary>
	public class ConfiguracionStyleGrillaController
	{

		#region Constructores
		public ConfiguracionStyleGrillaController()
		{
			_brClass = new ConfiguracionStyleGrilla();
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConfiguracionStyleGrilla _brClass;
		
		#endregion

		#region Propiedades

		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}

		public ArrayList Columnas
		{
			get{return _brClass.Columnas;}
			set{_brClass.Columnas = value;}
		}

		public ArrayList ColumnasString
		{
			get{return _brClass.ColumnasString;}
		}

		public ArrayList ColumnasInt
		{
			get{return _brClass.ColumnasInt;}
		}

		public ArrayList ColumnasDecimal
		{
			get{return _brClass.ColumnasDecimal;}
		}
		
		public ArrayList ColumnasBool
		{
			get{return _brClass.ColumnasBool;}
		}
		
		public ArrayList ColumnasDateTime
		{
			get{return _brClass.ColumnasDateTime;}
		}

		public string Condicion
		{
			get {return _brClass.Condicion;}
			set {_brClass.Condicion = value;}
		}

		public ArrayList Configuraciones
		{
			get {return _brClass.Configuraciones;}
		}

		public string NombreConfiguracion
		{
			get{return _brClass.NombreConfiguracion;}
			set{_brClass.NombreConfiguracion = value;}
		}

		public string ProcessName
		{
			get{return _brClass.ProcessName;}
			set{_brClass.ProcessName = value;}
		}

		public string TaskName
		{
			get{return _brClass.TaskName;}
			set{_brClass.TaskName = value;}
		}
		
		public string Formulario
		{
			get{return _brClass.Formulario;}
			set{_brClass.Formulario = value;}
		}
		
		public string TituloFormularioPadre
		{
			get{return _brClass.TituloFormularioPadre;}
			set{_brClass.TituloFormularioPadre = value;}
		}

		public ArrayList Perfiles
		{
			get{return _brClass.Perfiles;}
		}

		public ArrayList PerfilesSeleccionados
		{
			get{return _brClass.PerfilesSeleccionados;}
			set{_brClass.PerfilesSeleccionados = value;}
		}

		public ArrayList PerfilesAplicablesSeleccionados
		{
			get{return _brClass.PerfilesAplicablesSeleccionados;}
			set{_brClass.PerfilesAplicablesSeleccionados = value;}
		}

		public ArrayList PerfilesAplicablesModificablesSeleccionados
		{
			get{return _brClass.PerfilesAplicablesModificablesSeleccionados;}
			set{_brClass.PerfilesAplicablesModificablesSeleccionados = value;}
		}

		public ArrayList Usuarios
		{
			get{return _brClass.Usuarios;}
		}

		public ArrayList UsuariosSeleccionados
		{
			get{return _brClass.UsuariosSeleccionados;}
			set{_brClass.UsuariosSeleccionados = value;}
		}

		public ArrayList UsuariosAplicablesSeleccionados
		{
			get{return _brClass.UsuariosAplicablesSeleccionados;}
			set{_brClass.UsuariosAplicablesSeleccionados = value;}
		}

		public ArrayList UsuariosAplicablesModificablesSeleccionados
		{
			get{return _brClass.UsuariosAplicablesModificablesSeleccionados;}
			set{_brClass.UsuariosAplicablesModificablesSeleccionados = value;}
		}

		public bool PermiteModificarAplicacion
		{
			get{return _brClass.PermiteModificarAplicacion;}
		}

		public bool Todos
		{
			get{return _brClass.Todos;}
			set{_brClass.Todos = value;}
		}

		public bool PorUsuario
		{
			get{return _brClass.PorUsuario;}
			set{_brClass.PorUsuario = value;}
		}

		public bool PorPerfil
		{
			get{return _brClass.PorPerfil;}
			set{_brClass.PorPerfil = value;}
		}

		public bool TodosAplicables
		{
			get{return _brClass.TodosAplicables;}
			set{_brClass.TodosAplicables = value;}
		}

		public bool PorUsuarioAplicables
		{
			get{return _brClass.PorUsuarioAplicables;}
			set{_brClass.PorUsuarioAplicables = value;}
		}

		public bool PorPerfilAplicables
		{
			get{return _brClass.PorPerfilAplicables;}
			set{_brClass.PorPerfilAplicables = value;}
		}

		public bool TodosModificables
		{
			get{return _brClass.TodosModificables;}
			set{_brClass.TodosModificables = value;}
		}

		public bool PorUsuarioModificables
		{
			get{return _brClass.PorUsuarioModificables;}
			set{_brClass.PorUsuarioModificables = value;}
		}

		public bool PorPerfilModificables
		{
			get{return _brClass.PorPerfilModificables;}
			set{_brClass.PorPerfilModificables = value;}
		}

		public string ModoDeAplicacionDefault
		{
			get{return _brClass.ModoDeAplicacionDefault;}
		}

		public long IdConfiguracionSeleccionada
		{
			get{return _brClass.IdConfiguracionSeleccionada;}
			set{_brClass.IdConfiguracionSeleccionada = value;}
		}
		public businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionales ConfiguracionSeleccionada
		{
			get{return _brClass.ConfiguracionSeleccionada;}
		}

		public long IdConfiguracionAplicada
		{
			get{return _brClass.IdConfiguracionAplicada;}
			set{_brClass.IdConfiguracionAplicada = value;}
		}

		public bool PermiteModificarAplicables
		{
			get{return _brClass.PermiteModificarAplicables;}
		}

		public string ModoAplicableDefault
		{
			get{return _brClass.ModoAplicableDefault;}
		}

		public bool PermiteModificarAplicablesModificables
		{
			get{return _brClass.PermiteModificarAplicablesModificables;}
		}

		public string ModoAplicableModificableDefault
		{
			get{return _brClass.ModoAplicableModificableDefault;}
		}
		
		public int CantidadMaximaConfiguracionesVisiblesEnCombo
		{
			get{return _brClass.CantidadMaximaConfiguracionesVisiblesEnCombo;}
		}
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler CondicionesHasChanged;
		public event System.EventHandler ConfiguracionGrillaHasChanged;
		public event System.EventHandler ConfiguracionesHasChanged;
		#endregion

		#region Métodos  Públicos 

		public void InitVariables()
		{
			_brClass.InitVariables();
		}

		public bool PuedeAplicarConfiguracionATodos(string NombreGrilla)
		{
			return _brClass.PuedeAplicarConfiguracionATodos(NombreGrilla);
		}

		public bool PuedeAplicarConfiguracionAPerfiles(string NombreGrilla)
		{
			return _brClass.PuedeAplicarConfiguracionAPerfiles(NombreGrilla);
		}

		public bool PuedeAplicarConfiguracionAUsuarios(string NombreGrilla)
		{
			return _brClass.PuedeAplicarConfiguracionAUsuarios(NombreGrilla);
		}

		public void AddConfiguracionLikeSelected()
		{
			_brClass.AddConfiguracionLikeSelected();
		}

		public bool PuedeBorrarConfiguracionAplicada()
		{
			return _brClass.PuedeBorrarConfiguracionAplicada();
		}

		public bool PuedeBorrarConfiguracion()
		{
			return _brClass.PuedeBorrarConfiguracion();
		}

		public bool PuedeModificarConfiguracion(string NombreGrilla)
		{
			return _brClass.PuedeModificarConfiguracion(NombreGrilla);
		}
        
		public bool PuedeAgregarConfiguracion()
		{
			return _brClass.PuedeAgregarConfiguracion();
		}

		public DataTable ConfiguracionesEnBD(Janus.Windows.GridEX.GridEX grilla)
		{
			return _brClass.ConfiguracionesEnBD(grilla);
		}

		public int GetIndexUsuarioLogueado()
		{
			return _brClass.GetIndexUsuarioLogueado();
		}

		public int GetIndexPerfilLogueado()
		{
			return _brClass.GetIndexPerfilLogueado();
		}

		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.tui_ConfiguracionGrillaEstilosCondicionalesDet( new string[] {"Columna", "Condicion", "ValorString", "Estado"}).GetLayoutEx()); 
		}

		
		public void AddCondicionAConfiguracion(mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView Columna, string Condicion, object Valor, mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle Estilo)
		{
			_brClass.AddCondicionAConfiguracion(Columna, Condicion, Valor, Estilo);
		}

		public void ModifCondicionDeConfiguracion(mz.erp.businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet Condicion, mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView Columna, string NuevaCondicion, object Valor, mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle Estilo)
		{
			_brClass.ModifCondicionDeConfiguracion(Condicion, Columna, NuevaCondicion, Valor, Estilo);
		}
		
		public void AplicarConfiguracion(Janus.Windows.GridEX.GridEX Grilla)
		{
			_brClass.AplicarConfiguracion(Grilla);
		}

		public void Save(Janus.Windows.GridEX.GridEX Grilla)
		{
			_brClass.Save(Grilla);
		}

		public void RemoveCondicion (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet condicion)
		{
			_brClass.RemoveCondicion(condicion);
		}

		public void AddConfiguracion()
		{
			_brClass.AddConfiguracion();
		}

		public void ModificarConfiguracion()
		{
			_brClass.ModificarConfiguracion();
		}

		public void RemoveConfiguracion()
		{
			_brClass.RemoveConfiguracion();
		}

		public string GetNombreCofiguracionSimilar()
		{
			return _brClass.GetNombreCofiguracionSimilar();
		}

		public bool ExisteNombreConfiguracion()
		{
			return _brClass.ExisteNombreConfiguracion();
		}

		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{			
		}

		private void InitEventHandlers()
		{
			this._brClass.CondicionesHasChanged+=new EventHandler(_brClass_CondicionesHasChanged);
			this._brClass.ConfiguracionGrillaHasChanged+=new EventHandler(_brClass_ConfiguracionGrillaHasChanged);
			this._brClass.ConfiguracionesHasChanged+=new EventHandler(_brClass_ConfiguracionesHasChanged);
		}


		#endregion

		private void _brClass_CondicionesHasChanged(object sender, EventArgs e)
		{
			if(CondicionesHasChanged != null)
				CondicionesHasChanged(this, new EventArgs());	
		}
		
		private void _brClass_ConfiguracionGrillaHasChanged(object sender, EventArgs e)
		{
			if(ConfiguracionGrillaHasChanged != null)
				ConfiguracionGrillaHasChanged(this, new EventArgs());	
		}

		private void _brClass_ConfiguracionesHasChanged(object sender, EventArgs e)
		{
			if(ConfiguracionesHasChanged != null)
				ConfiguracionesHasChanged(this, new EventArgs());	
		}
	}
}
