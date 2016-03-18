using System;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmCuentasController.
	/// </summary>
	public class AbmCuentasController
	{
		#region Contructores
		private mz.erp.businessrules.AbmCuentas _brClass = new AbmCuentas();
		public AbmCuentasController()
		{			
			Init();

		}

		private void Init()
		{
			_contenedoresVisibles = Variables.GetValueString("Momentos.ABMCuentas.ContenedoresVisibles");
			_contenedoresHabilitados = Variables.GetValueString("Momentos.ABMCuentas.ContenedoresHabilitados");
            Console.WriteLine("Empieza InitializeData " + mz.erp.systemframework.Util.GetMilliseconds()); 
			InitializeData();
            Console.WriteLine("Termina InitializeData " + mz.erp.systemframework.Util.GetMilliseconds());
            Console.WriteLine("Empieza InitEvents " + mz.erp.systemframework.Util.GetMilliseconds()); 
			InitEvents();
            Console.WriteLine("Termina InitEvents " + mz.erp.systemframework.Util.GetMilliseconds());
            Console.WriteLine("Empieza SetLayoutDetalles " + mz.erp.systemframework.Util.GetMilliseconds()); 
			SetLayoutDetalles();
            Console.WriteLine("Termina SetLayoutDetalles " + mz.erp.systemframework.Util.GetMilliseconds()); 
		}

		#endregion

		#region Propiedades	
		public bool HabilitaListasDePrecios
		{
			get{return _brClass.HabilitaListasDePrecios;}
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

		private bool _buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Cuentas.BuscadorJerarquico.AllowMultipleSelect");
		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get {return _buscadorJerarquicoAllowMultipleSelect; }
		}		

		public string IdCuenta
		{
			get{return _brClass.IdCuenta;}
			set{_brClass.IdCuenta = value;}
		}

		public AbmCuentas.CuentasJearaquias Jerarquias
		{
			get{return _brClass.Jerarquias;}
		}

        /* Silvina 20111104 - Tarea 0000222 */
        public ArrayList JerarquiasCampoAuxiliar6
        {
            get { return _brClass.JerarquiasCampoAuxiliar6; }
        }

        public string EtiquetaCampoAuxiliar6
        {
            get { return _brClass.EtiquetaCampoAuxiliar6; }
        }

        public string JerarquiaCampoAuxiliar6
        {
            get { return _brClass.JerarquiaCampoAuxiliar6; }
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

        /* Silvina 20111226 - Tarea 0000241 */
        public string Separador
        {
            get { return _brClass.Separador; }
        }

        public bool AllowEditCampoAuxiliar6
        {
            get { return _brClass.AllowEditCampoAuxiliar6; }
        }
        /* Fin Silvina 20111226 - Tarea 0000241 */

		public string LayoutContactos
		{
			get { return _layoutContactos; }
		}

		public string LayoutDomicilios
		{
			get { return _layoutDomicilios; }
		}

		public ArrayList DataContactos
		{
			get{return _brClass.DataContactos;}
		}
		public long LengthRazonSocial
		{
			get{return _brClass.LengthRazonSocial;}
		}
		
		public ArrayList DataDomicilios
		{
			get{return _brClass.DataDomicilios;}
		}

		private mz.erp.commontypes.data.tcs_TiposContactosDataset.tcs_TiposContactosDataTable _tiposContactos = null;
		public mz.erp.commontypes.data.tcs_TiposContactosDataset.tcs_TiposContactosDataTable TiposContactos
		{
			get {return _tiposContactos;}
		}

		private mz.erp.commontypes.data.tcs_CargosDataset.tcs_CargosDataTable _tiposCargos = null;
		public mz.erp.commontypes.data.tcs_CargosDataset.tcs_CargosDataTable TiposCargos
		{
			get {return _tiposCargos;}
		}

		private mz.erp.commontypes.data.tsh_PaisesDataset.tsh_PaisesDataTable _paises = null;
		public mz.erp.commontypes.data.tsh_PaisesDataset.tsh_PaisesDataTable Paises
		{
			get {return _paises;}
		}

		private mz.erp.commontypes.data.tsh_ProvinciasDataset.tsh_ProvinciasDataTable _provincias = null;
		public mz.erp.commontypes.data.tsh_ProvinciasDataset.tsh_ProvinciasDataTable Provincias
		{
			get {return _provincias;}
		}

		private mz.erp.commontypes.data.tsh_LocalidadesDataset.tsh_LocalidadesDataTable _localidades = null;
		public mz.erp.commontypes.data.tsh_LocalidadesDataset.tsh_LocalidadesDataTable Localidades
		{
			get {return _localidades;}
		}
		
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}

		public bool AllowEditAlicuotaPercepcionIngresosBrutos
		{
			get{return _brClass.AllowEditAlicuotaPercepcionIngresosBrutos;}
		}

		public bool AllowEditLimiteDeCredito
		{
			get{return _brClass.AllowEditLimiteDeCredito;}
		}

		public bool AllowEditDiasLimiteDeCredito
		{
			get{return _brClass.AllowEditDiasLimiteDeCredito;}
		}
		public string ResponsableIngreso
		{
			get{return _brClass.ResponsableIngreso;}
			set{_brClass.ResponsableIngreso=value;}
		}
		public string IdResponsableIngreso
		{
			get{return _brClass.IdResponsableIngreso;}
			set{_brClass.IdResponsableIngreso=value;}
		}
		public bool AllowEditResponsableIngreso
		{
			get{return _brClass.AllowEditResponsableIngreso;}
			set{_brClass.AllowEditResponsableIngreso=value;}
		}
		public bool AskForPasswordResponsableIngreso
		{
			get{return _brClass.AskForPasswordResponsableIngreso;}
			set{_brClass.AskForPasswordResponsableIngreso=value;}
		}
		public string UltimoResponsableClaveCorrecta
		{
			get{return _brClass.UltimoResponsableClaveCorrecta;}
			set{_brClass.UltimoResponsableClaveCorrecta=value;}
		}
		
		#endregion

		#region Variables Privadas
			private string _layoutContactos = string.Empty;
		private string _layoutDomicilios = string.Empty;		
		private string _contenedoresVisibles = string.Empty;
		private string _contenedoresHabilitados = string.Empty;		
		

		#endregion

		#region Eventos y delegados	
		#endregion

		#region Métodos  Públicos
		public void InitJerarquias()
		{
			_brClass.InitJerarquias();
		}

		public tsa_CuentasExDataset Commit(tsa_CuentasExDataset data, string IdCuenta)
		{
			return _brClass.Commit(data, IdCuenta);
		}

		public void InitContactos()
		{
			_brClass.InitContactos();
		}

        /* Silvina 20110302 - Tarea 0000081 */
		public bool InitDomicilios()
        /* Fin Silvina */
		{
			return _brClass.InitDomicilios();
		}


		public void AddContacto()
		{
			_brClass.AddContacto();
		}

		public void AddDomicilio()
		{
			_brClass.AddDomicilio();
		}

		public void AddDomicilio(DomicilioCuenta dom)
		{
			_brClass.AddDomicilio(dom);
		}

        /* Silvina 20110804 - Tarea 0000178 */
        public void Cancelar()
        {
            _brClass.Cancelar();
        }

        public void Aceptar()
        {
            _brClass.Aceptar();
        }

        public void ActualizarDomiciliosDefault()
        {
            _brClass.ActualizarDomiciliosDefault();
        }

        /* Fin Silvina 20110804 - Tarea 0000178 */

		public bool ExistContacto(string idPersona)
		{
			return _brClass.ExistContacto(idPersona);
		}

		public void AddContacto(string idPersona, string nombre, string telefonos, string email, string comentarios, string instantMesseger, bool activo)
		{
			_brClass.AddContacto(idPersona, nombre, telefonos, email, comentarios, instantMesseger, activo);
		}

		
		public bool MustShowPersona(int index)
		{
			return _brClass.MustShowPersona(index);
		}

		public void ModifyContacto(int index)
		{
			_brClass.ModifyContacto(index);
		}

		public void ModifyDomicilio(int index)
		{
			_brClass.ModifyDomicilio(index);
		}

		public void ModifyDomicilio(DomicilioCuenta dom)
		{
			_brClass.ModifyDomicilio(dom);
		}

		public void DeleteContacto(int index)
		{
			_brClass.DeleteContacto(index);
		}

		public void DeleteDomicilio(int index)
		{
			_brClass.DeleteDomicilio(index);
		}

		public bool isDefaultDomicilio(int index)
		{
			return _brClass.isDefaultDomicilio(index);
		}

		public mz.erp.commontypes.data.tsa_CuentasExDataset UpdateContactos(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			return _brClass.UpdateContactos(data);
		}
		
		public mz.erp.commontypes.data.tsa_CuentasExDataset UpdateDomicilios(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			return _brClass.UpdateDomicilios(data);
		}

		public bool isDomicilioAdded(string idDomicilio)
		{
			return _brClass.isDomicilioAdded(idDomicilio);
		}

		public DomicilioCuenta GetDomicilio(int index)
		{
			return _brClass.GetDomicilio(index);
		}

		/*
		public mz.erp.commontypes.data.tsh_ProvinciasDataset.tsh_ProvinciasDataTable GetListProvincias(long  idPais)
		{
			mz.erp.commontypes.data.tsh_ProvinciasDataset.tsh_ProvinciasDataTable provinciasPais = mz.erp.businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
			DataRow rowP = provinciasPais.NewRow();
			rowP["IdProvincia"] = 0;
			rowP["Nombre"] = "No Indica";
			rowP["Descripcion"] = string.Empty;
			rowP["IdConexionCreacion"] = 1;
			rowP["FechaCreacion"] = DateTime.Now;
			rowP["IdEmpresa"] = 1;
			rowP["IdSucursal"] = 1;
			provinciasPais.Rows.Add(rowP);
			return provinciasPais;
		}
		*/

		public DataView GetListProvincias(long  idPais)
		{
			mz.erp.commontypes.data.tsh_ProvinciasDataset.tsh_ProvinciasDataTable provinciasPais = mz.erp.businessrules.tsh_PaisesProvincias.GetListProvincias(idPais).tsh_Provincias;
			/*
			DataRow rowP = provinciasPais.NewRow();
			rowP["IdProvincia"] = 0;
			rowP["Nombre"] = "No Indica";
			rowP["Descripcion"] = string.Empty;
			rowP["IdConexionCreacion"] = 1;
			rowP["FechaCreacion"] = DateTime.Now;
			rowP["IdEmpresa"] = 1;
			rowP["IdSucursal"] = 1;
			provinciasPais.Rows.Add(rowP);
			*/
			
			DataView view = provinciasPais.DefaultView;
			view.Sort = "Descripcion";
			return view;

			
		}

	/*
		public mz.erp.commontypes.data.tsh_LocalidadesDataset.tsh_LocalidadesDataTable GetListLocalidades(long  idProvincia)
		{
			mz.erp.commontypes.data.tsh_LocalidadesDataset.tsh_LocalidadesDataTable localidadesProv = mz.erp.businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idProvincia).tsh_Localidades;
			DataRow rowL = localidadesProv.NewRow();
			rowL["IdLocalidad"] = string.Empty;
			rowL["Descripcion"] = "No Indica";
			rowL["IdConexionCreacion"] = 1;
			rowL["FechaCreacion"] = DateTime.Now;
			rowL["IdEmpresa"] = 1;
			rowL["IdSucursal"] = 1;
			localidadesProv.Rows.Add(rowL);

			DataTable table = new DataTable();
			table.DefaultView;

			return localidadesProv;
		}
*/
		public DataView GetListLocalidades(long  idProvincia)
		{
			mz.erp.commontypes.data.tsh_LocalidadesDataset.tsh_LocalidadesDataTable localidadesProv = mz.erp.businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(idProvincia).tsh_Localidades;
			/*
			DataRow rowL = localidadesProv.NewRow();
			rowL["IdLocalidad"] = string.Empty;
			rowL["Descripcion"] = "No Indica";
			rowL["IdConexionCreacion"] = 1;
			rowL["FechaCreacion"] = DateTime.Now;
			rowL["IdEmpresa"] = 1;
			rowL["IdSucursal"] = 1;
			localidadesProv.Rows.Add(rowL);
			*/

			
			DataView view = localidadesProv.DefaultView;
			view.Sort = "Descripcion";

			return view;
		}

		
		public void ClearResponsableDeIngreso() 
		{						
			_brClass.IdResponsableIngreso = string.Empty;
		}

		
		#endregion

		#region Métodos  Privados
		private void InitializeData()
		{
			SetCombosData();
		}
		
		private void InitEvents()
		{
		}

		private void SetLayoutDetalles()
		{
			_layoutContactos = Build_LayoutContactos();
			_layoutDomicilios = Build_LayoutDomicilios();
		}

		private string Build_LayoutContactos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdPersona", "IdPersona" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",250) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoContacto", "Tipo Contacto",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdCargo", "IdCargo",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Telefonos",150) );
			sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Comentarios", "Comentarios",150 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetRow( i++, "InstantMesseger", "InstantMesseger",100) );
			sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 200 ));
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();

		}

		private string Build_LayoutDomicilios()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdDomicilio", "IdDomicilio" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDomicilio", "Tipo de Domicilio",115 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Calle" , 100 ));
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" , 70) );
			sb.Append( LayoutBuilder.GetRow( i++, "Sector", "Sector", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Torre", "Torre", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Piso", "Piso", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Departamento", "Departamento" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Manzana", "Manzana", true ) );
            //German 20101102 - Tarea 890
			//sb.Append( LayoutBuilder.GetRow( i++, "CodigoPostal", "CodigoPostal", true ) );
            //Fin German 20101102 - Tarea 890
			sb.Append( LayoutBuilder.GetRow( i++, "IdPais", "Pais", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdProvincia", "Provincia", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdLocalidad", "Localidad" , 100) );
            //Cristian 20101020 Tarea 890
            sb.Append(LayoutBuilder.GetRow(i++, "CodigoPostal", "Codigo Postal", 100));
            //Fin Tarea 890
			sb.Append( LayoutBuilder.GetRow( i++, "Partido", "Partido", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "Responsable" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Teléfono", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" , true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Default", "Default",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();

		}


		private void SetCombosData()
		{
			_tiposContactos = mz.erp.businessrules.tcs_TiposContactos.GetList().tcs_TiposContactos;
			DataRow rowTC = _tiposContactos.NewRow();					
			rowTC["IdTipoContacto"] = long.MinValue;
			rowTC["Descripcion"] = String.Empty;
			rowTC["IdConexionCreacion"] = 1;
			rowTC["FechaCreacion"] = DateTime.Now;
			rowTC["IdEmpresa"] = 1;
			_tiposContactos.Rows.Add(rowTC);

			_tiposCargos = mz.erp.businessrules.tcs_Cargos.GetList().tcs_Cargos;
			DataRow rowC = _tiposCargos.NewRow();					
			rowC["IdCargo"] = long.MinValue;
			rowC["Descripcion"] = String.Empty;
			rowC["IdConexionCreacion"] = 1;
			rowC["FechaCreacion"] = DateTime.Now;
			rowC["IdEmpresa"] = 1;
			_tiposCargos.Rows.Add(rowC);

			_paises = mz.erp.businessrules.tsh_Paises.GetList().tsh_Paises;
			/*
			DataRow rowPais = _paises.NewRow();
			rowPais["IdPais"] = 0;
			rowPais["Nombre"] = "No Indica";
			rowPais["IdConexionCreacion"] = 1;
			rowPais["FechaCreacion"] = DateTime.Now;
			rowPais["IdEmpresa"] = 1;
			rowPais["IdSucursal"] = 1;
			_paises.Rows.Add(rowPais);
			*/
            Console.WriteLine("Empieza tsh_PaisesProvincias.GetListProvincias " + mz.erp.systemframework.Util.GetMilliseconds()); 
            /* Silvina 20101125 - Tarea 940 */
			//_provincias = mz.erp.businessrules.tsh_Provincias.GetList().tsh_Provincias;
            _provincias = mz.erp.businessrules.tsh_PaisesProvincias.GetListProvincias(Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault")).tsh_Provincias;
            /* Fin Silvina */
            Console.WriteLine("Termina tsh_PaisesProvincias.GetListProvincias " + mz.erp.systemframework.Util.GetMilliseconds()); 

            /* Silvina 20101125 - Tarea 940 */
			//_provincias = mz.erp.businessrules.tsh_Provincias.GetList().tsh_Provincias;
            _provincias = mz.erp.businessrules.tsh_PaisesProvincias.GetListProvincias(Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault")).tsh_Provincias;
            /* Fin Silvina */


			/*
			DataRow rowP = _provincias.NewRow();
			rowP["IdProvincia"] = 0;
			rowP["Nombre"] = "No Indica";
			rowP["Descripcion"] = string.Empty;
			rowP["IdConexionCreacion"] = 1;
			rowP["FechaCreacion"] = DateTime.Now;
			rowP["IdEmpresa"] = 1;
			rowP["IdSucursal"] = 1;
			_provincias.Rows.Add(rowP);
			*/
			/* Silvina 20101125 - Tarea 940 */
            //_localidades = mz.erp.businessrules.tsh_Localidades.GetList().tsh_Localidades;
            _localidades = mz.erp.businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault")).tsh_Localidades;
            /* Fin Silvina */

			/*
			DataRow rowL = _localidades.NewRow();
			rowL["IdLocalidad"] = string.Empty;
			rowL["Descripcion"] = "No Indica";
			rowL["IdConexionCreacion"] = 1;
			rowL["FechaCreacion"] = DateTime.Now;
			rowL["IdEmpresa"] = 1;
			rowL["IdSucursal"] = 1;
			_localidades.Rows.Add(rowL);
			*/

		}

        /* Silvina 20111104 - Tarea 0000222 */
        public void InitCampoAuxiliar6(string CampoAuxiliar6)
        {
            _brClass.InitCampoAuxiliar6(CampoAuxiliar6);
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */

		#endregion
	
		#region Miembros de ITaskController
		#endregion
	
	}
}
