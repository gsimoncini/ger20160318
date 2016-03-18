using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzCuentasSearchForm.
	/// </summary>
	public class mzProveedoresSearchFormController
	{
		
		#region Constructores

		public mzProveedoresSearchFormController()
		{
			_brClass = new mzProveedoresSearchForm();
			_brClass.Init();
			Init();
		}

		public mzProveedoresSearchFormController(mzProveedoresSearchForm BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		#endregion

		#region Variables Privadas
			
			private mzProveedoresSearchForm _brClass = null;
			private long _idProvinciaDefault = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
			private long _idPaisDefault = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
			private string  _idLocalidadDefault= Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");
			/*private bool _buscadorJerarquicoAllowMultipleSelect = false;
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
			private string _labelCampoAuxiliar3 = string.Empty;*/
			private string _idProveedor = string.Empty;
			private string _nombreProveedor = string.Empty;
			private string _codigoProveedor = string.Empty;
    		private string _etiquetaCampoAuxiliar1 = string.Empty;	
 	    	private string _etiquetaCampoAuxiliar2 = string.Empty;	
		    private string _etiquetaCampoAuxiliar3 = string.Empty;	
		    private string _etiquetaCampoAuxiliar4 = string.Empty;	
		    private string _etiquetaCampoAuxiliar5 = string.Empty;
			
			
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
		public string EtiquetaCampoAuxiliar1
		{
			get
			{
				return this._etiquetaCampoAuxiliar1;
			}
		}
				
		public string EtiquetaCampoAuxiliar2
		{
			get
			{
				return this._etiquetaCampoAuxiliar2;
			}
		}

		public string EtiquetaCampoAuxiliar3
		{
			get
			{
				return this._etiquetaCampoAuxiliar3;
			}
		}

		public string EtiquetaCampoAuxiliar4
		{
			get
			{
				return this._etiquetaCampoAuxiliar4;
			}
		}

		public string EtiquetaCampoAuxiliar5
		{
			get
			{
				return this._etiquetaCampoAuxiliar5;
			}
		}

		public string CodigoSeleccionado
		{
			get{return _codigoProveedor;}
		}
		public string NombreProveedor
		{
			get{return _nombreProveedor;}
		}
		public string IdProveedorSeleccionado
		{
			get{return _idProveedor;}
		}
	
/*
		
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

		}*/

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
		public string Calle
		{
			get{return _brClass.Calle;}
			set{_brClass.Calle = value;}
		}	
		public string TipoDocumento
			{
				get{return _brClass.TipoDocumento;}
				set{_brClass.TipoDocumento = value;}
			}
		public string Localidad
				{
					get{return _brClass.Localidad;}
					set{_brClass.Localidad = value;}
				}	
		public string Documento
					{
						get{return _brClass.Documento;}
						set{_brClass.Documento = value;}
					}
		public string Titular
						{
							get{return _brClass.Titular;}
							set{_brClass.Titular = value;}
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

		public string CampoAux4
		{
			get{return _brClass.CampoAux4;}
			set{_brClass.CampoAux4 = value;}
		}

		public decimal CampoAux5
		{
			get{return _brClass.CampoAux5;}
			set{_brClass.CampoAux5 = value;}
		}

		public bool CampoAux5Activo
		{
			get{return _brClass.CampoAux5Activo;}
			set{_brClass.CampoAux5Activo = value;}
		}

		public bool ExcluyeRetencionIVAActivo
		{
			get{return _brClass.ExcluyeRetencionIVAActivo;}
			set{_brClass.ExcluyeRetencionIVAActivo = value;}
		}

		public bool ExcluyeRetencionIIBBActivo
		{
			get{return _brClass.ExcluyeRetencionIIBBActivo;}
			set{_brClass.ExcluyeRetencionIIBBActivo = value;}
		}
		
		public bool ExcluyeRetencionIVA
		{
			get{return _brClass.ExcluyeRetencionIVA;}
			set{_brClass.ExcluyeRetencionIVA = value;}
		}

		public bool ExcluyeRetencionIIBB
		{
			get{return _brClass.ExcluyeRetencionIIBB;}
			set{_brClass.ExcluyeRetencionIIBB = value;}
		}

		public string IdTipoMovimiento
		{
			get{return _brClass.IdTipoMovimiento;}
			set{_brClass.IdTipoMovimiento = value;}
		}

		public string IdSubTipoMovimiento
		{
			get{return _brClass.IdSubTipoMovimiento;}
			set{_brClass.IdSubTipoMovimiento = value;}
		}
		
		public string IdCondicionDeCompra
		{
			get{return _brClass.IdCondicionDeCompra;}
			set{_brClass.IdCondicionDeCompra = value;}
		}

		public long CondicionImpuestoGanancias
		{
			get{return _brClass.CondicionImpuestoGanancias;}
			set{_brClass.CondicionImpuestoGanancias = value;}
		}

		public DataTable TiposMovimientos
		{
			get {return _brClass.TiposMovimientos;}
		}
		public DataTable SubTiposMovimientos
		{
			get {return _brClass.SubTiposMovimientos;}
		}
		public DataTable CondicionesDeCompra
		{
			get {return _brClass.CondicionesDeCompra;}
		}

		/*public string IdTipoDoc
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
		}*/

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

		private bool _buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Proveedores.BuscadorJerarquico.AllowMultipleSelect");
		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get {return _buscadorJerarquicoAllowMultipleSelect; }
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
			/*_buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Cuentas.BuscadorJerarquico.AllowMultipleSelect");
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
			if(_labelCampoAuxiliar3.Equals(string.Empty)) _labelCampoAuxiliar3 = "CampoAuxiliar3";*/

			InitializeData();
		}

		private void InitializeData()
		{
			this._etiquetaCampoAuxiliar1 = Variables.GetValueString("Proveedores.CampoAuxiliar1.Etiqueta");
			this._etiquetaCampoAuxiliar2 = Variables.GetValueString("Proveedores.CampoAuxiliar2.Etiqueta");
			this._etiquetaCampoAuxiliar3 = Variables.GetValueString("Proveedores.CampoAuxiliar3.Etiqueta");
			this._etiquetaCampoAuxiliar4 = Variables.GetValueString("Proveedores.CampoAuxiliar4.Etiqueta");
			this._etiquetaCampoAuxiliar5 = Variables.GetValueString("Proveedores.CampoAuxiliar5.Etiqueta");
			_paises = businessrules.tsh_Paises.GetList().tsh_Paises;
			//_provincias = businessrules.tsh_Provincias.GetList().tsh_Provincias;
		}

		private void SetLayoutDetalles()
		{
			/*_layoutDirecciones = Build_LayoutDirecciones();
			_layoutContactos = Build_LayoutContactos();
			_layoutJerarquias = Build_LayoutJerarquias();*/
		}

		/*private string Build_LayoutJerarquias()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquía" , 200 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Padre", "Padre" , 200));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}*/


		/*private string Build_LayoutDirecciones()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Calle" , 100 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nro" , 50));
			sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Teléfono", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Localidad", "Localidad", 100 ));
            sb.Append( LayoutBuilder.GetRow( i++, "TipoDomicilio", "Tipo Dom.", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Sector", "Sector", 70));
			sb.Append( LayoutBuilder.GetRow( i++, "Torre", "Torre", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Piso", "Piso", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Departamento", "Depto" , 70));
			sb.Append( LayoutBuilder.GetRow( i++, "Manzana", "Manzana", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Provincia", "Provincia", 70 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Pais", "País", 70 ));
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
		}*/
		
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
			return  Variables.GetValueBool("Proveedores.Habilitar.BotonNuevo");
		}

		public bool HabilitaBotonEditar()
		{
			return Variables.GetValueBool("Proveedores.Habilitar.BotonEditar");
		}
		
		public DataView RefreshData()
		{
			return _brClass.RefreshData();
		}



		public void VerDetalle(object selectedItem)
		{			
			if(selectedItem != null)
			{
				_brClass.GetDetalle(selectedItem); // cambiar anterior
				DataRowView row = (DataRowView)selectedItem;
				_idProveedor = Convert.ToString(row["IdProveedor"]);
				_nombreProveedor = Convert.ToString(row["Nombre"]);
				_codigoProveedor = Convert.ToString(row["Codigo"]);				
			}
		}

		#endregion

		private void _brClass_DetalleChanged(object sender, EventArgs e)
		{
			if(DetalleChanged != null)
				DetalleChanged(this,new EventArgs());
		}
	}
}
