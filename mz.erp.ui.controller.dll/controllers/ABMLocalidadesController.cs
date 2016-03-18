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
	/// Descripción breve de ABMLocalidadesController.
	/// </summary>
	public class ABMLocalidadesController:ITaskController
		
	{
		public ABMLocalidadesController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public ABMLocalidadesController(ABMLocalidades brClass)
		{
			_brClass = brClass;	
			Init();
		}

		#region variables privadas
		private mz.erp.businessrules.ABMLocalidades _brClass;
		private ProcessControllerManager _processManager;
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		
		
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
		
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}
		public void Continue()
		{

		}

		public void Execute()
		{
			_brClass.CodigoPostal=this.CodigoPostal;
			_brClass.NombreLocalidad=this.NombreLocalidad;
			_brClass.IdPais=this.IdPais;
			_brClass.IdProvincia=this.IdProvincia;
			if (!_brClass.Operacion.Equals("new"))
			{
				_brClass.IdLocalidad=this.IdLocalidad;
				_brClass.IdProvinciaAnterior=this.IdProvinciaEdicion;
			
			}
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		#endregion
		#region Propiedades	
		private long _idProvincia = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
		private long _idPais = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
		private long _idProvinciaEdicion = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
		private long _idPaisEdicion = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
		private string _idLocalidad= string.Empty;
		private string _codigoPostal = string.Empty;
		private string _nombreLocalidad=string.Empty;
		
		
		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
				
			}
		}
	
		public string TextoBotonSiguiente
		{
			get 
			{		
				return _brClass.TextoBotonSiguiente;
				
			}
			
			
		}
		public string Leyenda
		{
			get 
			{
				return _brClass.Leyenda;
				
			}
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}

		
		private DataTable _paises = null;
		public DataTable Paises
		{
			get{return _paises;}
		}

		public string KeyValuePaises
		{
			get { return "IdPais" ; }
		}		
		
		public string KeyListPaises
		{
			get { return "Nombre" ; }
		}

		private DataTable _provincias = null;
		public DataTable Provincias
		{
			get{return _provincias;}
		}

		public string KeyValueProvincias
		{
			get { return "IdProvincia" ; }
		}		
		
		public string KeyListProvincias
		{
			get { return "Nombre" ; }
		}
		
		private DataTable _localidades = null;
		public DataTable Localidades
		{
			get{return _localidades;}
		}

		public string KeyValueLocalidades
		{
			get { return "IdLocalidad" ; }
		}		
		
		public string KeyListLocalidades
		{
			get { return "Descripcion" ; }
		}
		
		
		public long IdPais
		{
			get{return _idPais;}
			set{_idPais = value;}
		}
		public long IdProvincia
		{
			get{return _idProvincia;}
			set{_idProvincia = value;}
		}
		public string IdLocalidad
		{
			get{return _idLocalidad;}
			set{_idLocalidad = value;}
		}
		public long IdPaisEdicion
		{
			get{return _idPaisEdicion;}
			set{_idPaisEdicion = value;}
		}
		public long IdProvinciaEdicion
		{
			get{return _idProvinciaEdicion;}
			set{_idProvinciaEdicion = value;}
		}
		public string CodigoPostal
		{
			get{return _codigoPostal;}
			set{_codigoPostal=value;}
		
		}
		public string NombreLocalidad
		{
			get{return _nombreLocalidad;}
			set{_nombreLocalidad=value;}
		}
		#endregion

		#region metodos publicos

		public DataTable ProvinciasPais(long idPais)
		{
			return  businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
		}
		public DataTable LocalidadPcia(long idPcia)
		{
			return  businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idPcia).tsh_Localidades;
		}
		
		public string ContenedoresVisibles()
		{
			//Si es un alta se tiene q ver solo la parte de ingreso de datos, sino la busqueda tambien
			if (_brClass.Operacion.Equals("new"))
			{
				return "DatosGenerales";
			}
			else return "DatosLocalidad";
		}
		public void ActualizarDatos(){
		
			this.IdPais=this.IdPaisEdicion;
			this.IdProvincia=this.IdProvinciaEdicion;
			//Busco la localidad para tener el codigo postal y el nombre
			_brClass.Localidad(this.IdLocalidad);
			this.NombreLocalidad=_brClass.NombreLocalidad;
			this.CodigoPostal=_brClass.CodigoPostal;
			// ---- Matias - 20090620 - guarda los datos de la localidad seleccionada.
			_brClass.IdPaisDB=this.IdPais;
			_brClass.IdProvinciaDB=this.IdProvincia;
			_brClass.NombreLocalidadDB=_brClass.NombreLocalidad;
			_brClass.CodigoPostalDB=_brClass.CodigoPostal;
			// ---- FinMatias
			Refresh();
		}
		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}
		public bool ValidarDatosLocalidad(string Localidad)
		{
			return _brClass.ValidarDatosLocalidad(Localidad);
		}
		public bool ValidarDatosCP(string CP)
		{
			return _brClass.ValidarDatosCP(CP);
		}
		#endregion
		#region metodos privados

		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	
		private void InitData()
		{
			_paises = businessrules.tsh_Paises.GetList().tsh_Paises;
			_provincias = businessrules.tsh_Provincias.GetList().tsh_Provincias;
		}
		
		private void InitEventHandlers()
		{
		}


		#endregion
		#region Eventos y delegados
		public event System.EventHandler ObjectHasChanged;
		#endregion
	}
}
