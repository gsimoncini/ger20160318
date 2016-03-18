using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
using System.Text;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzCuentasSearchForm.
	/// </summary>
	public class mzCuentasSearchFormController
	{
		
		#region Constructores

		public mzCuentasSearchFormController()
		{
			_brClass = new mzCuentasSearchForm();
			_brClass.Init();
			Init();
		}

		public mzCuentasSearchFormController(mzCuentasSearchForm BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		#endregion

		#region Variables Privadas
			
			private mzCuentasSearchForm _brClass = null;
			private bool _buscadorJerarquicoAllowMultipleSelect = false;
			private bool _solapaDireccionesVisible = true;
			private bool _solapaContactosVisible = true;
			private bool _solapaBuscadorPrincicipalVisible = true;
			private bool _solapaBuscadorSecundarioVisible = true;
			private bool _solapaBuscadorJerarquicoVisible = true;
			private string _filtroDefault = string.Empty;
			private string _layoutDirecciones = string.Empty;
			private string _layoutContactos = string.Empty;
			private string _layoutJerarquias = string.Empty;
			private string _labelCampoAuxiliar1 = string.Empty;
			private string _labelCampoAuxiliar2 = string.Empty;
			private string _labelCampoAuxiliar3 = string.Empty;
			private string _idCuenta = string.Empty;
			private string _nombreCuenta = string.Empty;
			private string _codigoCuenta = string.Empty;

			private long _idProvinciaDefault = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
			private long _idPaisDefault = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
			private string  _idLocalidadDefault= Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");

            
            /* Fin Silvina 20111226 - Tarea 0000241 */
            private string _labelCampoAuxiliar6 = string.Empty;            
            /* Fin Silvina 20111226 - Tarea 0000241 */

			
		
		#endregion

		#region Propiedades
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
		public long IdPaisDefault
		{
			get{return _idPaisDefault;}
			set{_idPaisDefault = value;}
		}
		public long IdProvinciaDefault
		{
			get{return _idProvinciaDefault;}
			set{_idProvinciaDefault = value;}
		}
		public string IdLocalidadDefault
		{
			get{return _idLocalidadDefault;}
			set{_idLocalidadDefault = value;}
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

		public string CodigoSeleccionado
		{
			get{return _codigoCuenta;}
		}

		public string NombreSeleccionado
		{
			get{return _nombreCuenta;}
		}
		public string IdCuentaSeleccionado
		{
			get{return _idCuenta;}
		}

		
		public DataTable DataJerarquias
		{
			get{return _brClass.DataJerarquias;}
		}


		public DataTable DataContactos
		{
			get{return _brClass.DataContactos;}
		}

		public ArrayList DataDomicilios
		{
			get{return _brClass.DataDomicilios;}
		}

		public string LayoutJerarquias
		{
			get { return _layoutJerarquias; }
		}


 
		public string LayoutContactos
		{
			get { return _layoutContactos; }
		}

		public string LayoutDirecciones
		{
			get { return _layoutDirecciones; }
		}

		public string FiltroDefault
		{
			get{return _filtroDefault;}
		}

		public bool SolapaBuscadorJerarquicoVisible
		{
			get{return _solapaBuscadorJerarquicoVisible;}
		}


		public bool SolapaBuscadorSecundarioVisible
		{
			get{return _solapaBuscadorSecundarioVisible;}
		}

		public bool SolapaBuscadorPrincicipalVisible
		{
			get{return _solapaBuscadorPrincicipalVisible;}
		}

		
		public bool SolapaContactosVisible
		{
			get{return _solapaContactosVisible;}
		}
		

		public bool SolapaDireccionesVisible
		{
			get{return _solapaDireccionesVisible;}
		}
		
		
		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
			set{_brClass.Jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
			set{_brClass.Jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
			set{_brClass.Jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
			set{_brClass.Jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
			set{_brClass.Jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
			set{_brClass.Jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
			set{_brClass.Jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
			set{_brClass.Jerarquia8 = value;}
		}


		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get
			{
				return _buscadorJerarquicoAllowMultipleSelect;
			}

		}

		public string ProcessName
		{
			get{return _brClass.ProcessName;}
		}
		public string TaskName
		{
			get{return _brClass.TaskName;}
		}

		public bool Activo 
		{
			get{return _brClass.Activo;}
			set{_brClass.Activo = value;}
		}

		public string Telefonos
		{
			get{return _brClass.Telefonos;}
			set{_brClass.Telefonos = value;}
		}

		public string Email
		{
			get{return _brClass.Email;}
			set{_brClass.Email = value;}
		}

			
		public string Codigo
		{
			get{return _brClass.Codigo;}
			set{_brClass.Codigo = value;}
		}

		public string Nombre
		{
			get{return _brClass.Nombre;}
			set{ _brClass.Nombre = value;}
		}

		public string CampoAux1
		{
			get{return _brClass.CampoAux1;}
			set{_brClass.CampoAux1 = value;}
		}

		public string CampoAux2
		{
			get{return _brClass.CampoAux2;}
			set{_brClass.CampoAux2 = value;}
		}

		public string CampoAux3
		{
			get{return _brClass.CampoAux3;}
			set{_brClass.CampoAux3 = value;}
		}

		public string IdTipoDoc
		{
			get{return _brClass.IdTipoDoc;}
			set{_brClass.IdTipoDoc = value;}
		}
		
		public string NroDoc
		{
			get{return _brClass.NroDoc;}
			set{_brClass.NroDoc = value;}
		}

		public string IdTitular
		{
			get{return _brClass.IdTitular;}
			set{_brClass.IdTitular = value;}
		}

		public string IdContacto
		{
			get{return _brClass.IdContacto;}
			set{_brClass.IdContacto = value;}
		}

		public string Calle
		{
			get{return _brClass.Calle;}
			set{_brClass.Calle = value;}
		}

		public string IdLocalidad
		{
			get{return _brClass.IdLocalidad;}
			set{_brClass.IdLocalidad = value;}
		}


		public bool HabilitaVerDetalleVentas 
		{
			get { return _brClass.HabilitaVerDetalleVentas; }
		}
		public bool HabilitaVerCuentaCorriente 
		{
			get { return _brClass.HabilitaVerCuentaCorriente; }
		}		
		public bool HabilitaVerObservaciones 
		{
			get { return _brClass.HabilitaVerObservaciones; }
		}


		public string LabelCampoAuxiliar1
		{
			get{return _labelCampoAuxiliar1;}
		}
		public string LabelCampoAuxiliar2
		{
			get{return _labelCampoAuxiliar2;}
		}

		public string LabelCampoAuxiliar3
		{
			get{return _labelCampoAuxiliar3;}
		}

        /* Silvina 20111226 - Tarea 0000241 */

        public string CampoAux6
        {
            get { return _brClass.CampoAux6; }
            set { _brClass.CampoAux6 = value; }
        }

        public string LabelCampoAuxiliar6
        {
            get { return _labelCampoAuxiliar6; }
        }

        public string JerarquiaCampoAuxiliar6
        {
            get { return _brClass.JerarquiaCampoAuxiliar6; }
        }

        public string Separador
        {
            get { return _brClass.Separador; }
        }

        /* Fin Silvina 20111226 - Tarea 0000241 */

		Hashtable _parametros = null;
		public Hashtable Parametros 
		{
			get {return _parametros;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string IdResponsable
		{
			get{return _brClass.IdResponsable;}
			set{_brClass.IdResponsable=value;}
		}
		public DateTime FechaAltaDesde
		{
			get{return _brClass.FechaAltaDesde;}
			set{_brClass.FechaAltaDesde=value;}
		}
		public DateTime FechaAltaHasta
		{
			get{return _brClass.FechaAltaHasta;}
			set{_brClass.FechaAltaHasta=value;}
		}
		public bool BuscarPorFechaAlta
		{
			get{return _brClass.BuscarPorFechaAlta;}
			set{_brClass.BuscarPorFechaAlta=value;}
		}
		public bool BuscarPorResponsable
		{
			get{return _brClass.BuscarPorResponsable;}
			set{_brClass.BuscarPorResponsable=value;}
		}


		#endregion

		#region Eventos

			public event EventHandler DetalleChanged;

		#endregion

		#region Metodos Privados
			
		private void Init()
		{
			_buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Cuentas.BuscadorJerarquico.AllowMultipleSelect");
			_solapaDireccionesVisible = Variables.GetValueBool(_brClass.ProcessName, _brClass.TaskName, "Solapas.Direcciones.Visible",_solapaDireccionesVisible);
			_solapaContactosVisible = Variables.GetValueBool(_brClass.ProcessName, _brClass.TaskName, "Solapas.Contactos.Visible", _solapaContactosVisible);
			_solapaBuscadorJerarquicoVisible = Variables.GetValueBool(_brClass.ProcessName, _brClass.TaskName, "Solapas.BuscadorJerarquico.Visible", _solapaBuscadorJerarquicoVisible);
			_solapaBuscadorPrincicipalVisible = Variables.GetValueBool(_brClass.ProcessName, _brClass.TaskName, "Solapas.BuscadorPrincipal.Visible",_solapaBuscadorPrincicipalVisible);
			_solapaBuscadorSecundarioVisible = Variables.GetValueBool(_brClass.ProcessName, _brClass.TaskName, "Solapas.BuscadorSecundario.Visible",_solapaBuscadorSecundarioVisible);
			_filtroDefault = Variables.GetValueString(_brClass.ProcessName, _brClass.TaskName, "Solapas.FiltrosBusqueda.Default");
			SetLayoutDetalles();
			_brClass.DetalleChanged +=new EventHandler(_brClass_DetalleChanged);
			_labelCampoAuxiliar1 = Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta");
			if(_labelCampoAuxiliar1.Equals(string.Empty)) _labelCampoAuxiliar1 = "CampoAuxiliar1";
			_labelCampoAuxiliar2 = Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta");
			if(_labelCampoAuxiliar2.Equals(string.Empty)) _labelCampoAuxiliar2 = "CampoAuxiliar2";
			_labelCampoAuxiliar3 = Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta");
			if(_labelCampoAuxiliar3.Equals(string.Empty)) _labelCampoAuxiliar3 = "CampoAuxiliar3";
			_paises = businessrules.tsh_Paises.GetList().tsh_Paises;
            /*  Silvina 20111226 - Tarea 0000241 */
            _labelCampoAuxiliar6 = Variables.GetValueString("Cuentas.CampoAuxiliar6.Etiqueta");
            if (_labelCampoAuxiliar6.Equals(string.Empty)) _labelCampoAuxiliar6 = "CampoAuxiliar6";
            /* Fin Silvina 20111226 - Tarea 0000241 */
		}


		private void SetLayoutDetalles()
		{
			_layoutDirecciones = Build_LayoutDirecciones();
			_layoutContactos = Build_LayoutContactos();
			_layoutJerarquias = Build_LayoutJerarquias();
		}

		private string Build_LayoutJerarquias()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquía" , 200 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Padre", "Padre" , 200));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}


		private string Build_LayoutDirecciones()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Calle" , 150 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nro" , 50));
			sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Teléfono", 300 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Localidad", "Localidad", 100 ));
			sb.Append( LayoutBuilder.GetRow( i++, "TipoDomicilio", "Tipo Dom.", 150 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Sector", "Sector", 70));
			sb.Append( LayoutBuilder.GetRow( i++, "Torre", "Torre", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Piso", "Piso", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Departamento", "Depto" , 70));
			sb.Append( LayoutBuilder.GetRow( i++, "Manzana", "Manzana", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Provincia", "Provincia", 150 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Pais", "País", 150 ));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		private string Build_LayoutContactos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",250) );
			sb.Append( LayoutBuilder.GetRow( i++, "TipoDeContacto", "Tipo Contacto",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Telefonos",150) );
			sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Comentarios", "Comentarios",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetRow( i++, "InstantMesseger", "InstantMesseger",100) );
			sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 200 ));
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();

		}
		
		#endregion

		#region Metodos Publicos
		public DataTable ProvinciasPais(long idPais)
		{
			return  businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
		}

		public DataTable LocalidadPcia(long idPcia)
		{
			return  businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idPcia).tsh_Localidades;
		}
		

		public bool HabilitaBotonNuevo()
		{
			return (Variables.GetValueBool("Cuentas.Habilitar.BotonNuevo"));
			
		/*	string[] listaPerfilesNuevo = Variables.GetValueString("Cuentas.BotonNuevo.PerfilesHabilitados").Split(',');
			foreach (string str in listaPerfilesNuevo)
			{
				if (str.Equals(Security.IdPerfil.ToString()))
				{
					return true;
				}
			}
			return false;*/
		}

		public bool HabilitaBotonEditar()
		{
			return (Variables.GetValueBool("Cuentas.Habilitar.BotonEditar"));
			/*string[] listaPerfilesEditar = Variables.GetValueString("Cuentas.BotonEditar.PerfilesHabilitados").Split(',');
			foreach (string str in listaPerfilesEditar)
			{
				if (str.Equals(Security.IdPerfil.ToString()))
				{
					return true;
				}
			}
			return false;*/
			
		}
		
		public DataView RefreshData()
		{
			return _brClass.RefreshData();
		}



		public void VerDetalle(object selectedItem)
		{
			
			if(selectedItem != null)
			{
				_brClass.GetDetalle(selectedItem);
				DataRowView row = (DataRowView)selectedItem;
				_idCuenta = Convert.ToString(row["IdCuenta"]);
				_nombreCuenta = Convert.ToString(row["Nombre"]);
				_codigoCuenta = Convert.ToString(row["Codigo"]);
				
			}
		}
		public void GetParameters() 
		{
			_parametros = ProcessParameters.ConvertToHash("ABMCuentasObservaciones", "CodigoCuenta", _codigoCuenta);
		}
        //Cristian Tarea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            _brClass.updateFechas(fechaDesde);
        }
        //Fin Cristian
		
		#endregion

		private void _brClass_DetalleChanged(object sender, EventArgs e)
		{
			if(DetalleChanged != null)
				DetalleChanged(this,new EventArgs());
		}
	}
}
