using System;
using System.Data;
using System.Collections;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de mzProveedoresSearchForm.
	/// </summary>
	public class mzProveedoresSearchForm
	{
		

		#region Constructores
		
		public mzProveedoresSearchForm()
		{
		}


		#endregion

		#region Eventos
				
			public event EventHandler DetalleChanged;
				
		#endregion

		#region Variables Privadas
			
			private string _codigo = string.Empty;
			private string _nombre = string.Empty;
			private string _campoAux1 = string.Empty;
			private string _campoAux2 = string.Empty;
			private string _campoAux3 = string.Empty;
		    private string _campoAux4 = string.Empty;
    		private decimal _campoAux5 = 0;
		    private bool _campoAux5Activo = false;
		    private string _idTipoMovimiento = string.Empty;
		    private string _idSubTipoMovimiento = string.Empty;
		    private string _idCondicionDeCompra = string.Empty;
		    private long _condicionImpuestoGanancias = long.MinValue;
		    private bool _excluyeRetencionIVAActivo = false;
	    	private bool _excluyeRetencionIIBBActivo = false;
	    	private bool _excluyeRetencionIVA = false;
    		private bool _excluyeRetencionIIBB = false;
		/*private string _idTipoDec = string.Empty;
			private string _nroDoc = string.Empty;
			private string _idTitular = string.Empty;
			private string _calle = string.Empty;
			private string _idLocalidad = string.Empty;
			private string _email = string.Empty;
			private string _telefonos = string.Empty;*/
			private string _telefonos= string.Empty;
			private string _calle= string.Empty;
			private string _tipoDocumento= string.Empty;
			private string _localidad= string.Empty;
			private string _documento= string.Empty;
			private string _email= string.Empty;
			private string _titular= string.Empty;

			private bool _activo = true;
			private string _processName = string.Empty;
			private string _taskName = string.Empty;
			
			/*private ArrayList _jerarquia1 = new ArrayList();
			private ArrayList _jerarquia2 = new ArrayList();
			private ArrayList _jerarquia3 = new ArrayList();
			private ArrayList _jerarquia4 = new ArrayList();
			private ArrayList _jerarquia5 = new ArrayList();		
			private ArrayList _jerarquia6 = new ArrayList();
			private ArrayList _jerarquia7 = new ArrayList();
			private ArrayList _jerarquia8 = new ArrayList();

			private bool _byJerarquia1 = false;
			private bool _byJerarquia2 = false;
			private bool _byJerarquia3 = false;
			private bool _byJerarquia4 = false;
			private bool _byJerarquia5 = false;
			private bool _byJerarquia6 = false;
			private bool _byJerarquia7 = false;
			private bool _byJerarquia8 = false;

			private ArrayList _dataDirecciones = null;
			private DataTable _dataContactos = null;
			private DataTable _dataJerarquias = null;*/


		/*private string _keyJerarquia1 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia1");
		private string _keyJerarquia2 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia2");
		private string _keyJerarquia3 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia3");
		private string _keyJerarquia4 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia4");
		private string _keyJerarquia5 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia5");
		private string _keyJerarquia6 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia6");
		private string _keyJerarquia7 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia7");
		private string _keyJerarquia8 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia8");*/
		private bool _buscaRazonSocial;//true
		private bool _buscaCodigo;
		private bool _buscaTelefonos;
		private bool _buscaTitular;
		private bool _buscaCalle;
		private bool _buscaLocalidad;
		private bool _buscaTipoDoc;
		private bool _buscaDocumento;
		private bool _buscaEmail;
		private bool _buscaCampoAux1;
		private bool _buscaCampoAux2;
		private bool _buscaCampoAux3;
		private bool _buscaCampoAux4;
		private bool _buscaCampoAuxiliar5;
		private bool _buscaActivoAuxiliar;
		private bool _buscaActivo;
		private bool _buscaNodeChecked1;	
		private bool _buscaNodeChecked2;
		private bool _buscaNodeChecked3;
		private bool _buscaNodeChecked4;
		private bool _buscaNodeChecked5;		
		private bool _buscaNodeChecked6;
		private bool _buscaNodeChecked7;			
		private bool _buscaNodeChecked8;
		#endregion

		#region Variables Publicas
		
		//INICIO VARIABLES CONFIGURACION SEGURAMENTE HAYA Q CAMBIAR EL TIPO PARA Q ANDE
		public bool BuscaActivo 
		{
			get{return _buscaActivo;}
			set{_buscaActivo = value;}
		}
		public bool BuscaActivoAuxiliar 
		{
			get{return _buscaActivoAuxiliar;}
			set{_buscaActivoAuxiliar = value;}
		}

		public bool BuscaCalle 
		{
			get{return _buscaCalle;}
			set{_buscaCalle = value;}
		}
		public bool BuscaCampoAux1 
		{
			get{return _buscaCampoAux1;}
			set{_buscaCampoAux1 = value;}
		}
		public bool BuscaCampoAux2 
		{
			get{return _buscaCampoAux2;}
			set{_buscaCampoAux2 = value;}
		}
		public bool BuscaCampoAux3 
		{
			get{return _buscaCampoAux3;}
			set{_buscaCampoAux3 = value;}
		}
		public bool BuscaCampoAux4 
		{
			get{return _buscaCampoAux4;}
			set{_buscaCampoAux4 = value;}
		}
		public bool BuscaCampoAuxiliar5 
		{
			get{return _buscaCampoAuxiliar5;}
			set{_buscaCampoAuxiliar5 = value;}
		}
		public bool BuscaCodigo 
		{
			get{return _buscaCodigo;}
			set{_buscaCodigo = value;}
		}
		public bool BuscaDocumento 
		{
			get{return _buscaDocumento;}
			set{_buscaDocumento = value;}
		}
		public bool BuscaEmail 
		{
			get{return _buscaEmail;}
			set{_buscaEmail = value;}
		}
		public bool BuscaLocalidad 
		{
			get{return _buscaLocalidad;}
			set{_buscaLocalidad = value;}
		}
		public bool BuscaNodeChecked1 
		{
			get{return _buscaNodeChecked1;}
			set{_buscaNodeChecked1 = value;}
		}
	
		public bool BuscaNodeChecked2
		{
			get{return _buscaNodeChecked2;}
			set{_buscaNodeChecked2 = value;}
		}
		public bool BuscaNodeChecked3 
		{
			get{return _buscaNodeChecked3;}
			set{_buscaNodeChecked3 = value;}
		}
		public bool BuscaNodeChecked4 
		{
			get{return _buscaNodeChecked4;}
			set{_buscaNodeChecked4 = value;}
		}
		public bool BuscaNodeChecked5 
		{
			get{return _buscaNodeChecked5;}
			set{_buscaNodeChecked5 = value;}
		}
		public bool BuscaNodeChecked6
		{
			get{return _buscaNodeChecked6;}
			set{_buscaNodeChecked6= value;}
		}
		public bool BuscaNodeChecked7
		{
			get{return _buscaNodeChecked7;}
			set{_buscaNodeChecked7= value;}
		}
		public bool BuscaNodeChecked8
		{
			get{return _buscaNodeChecked8;}
			set{_buscaNodeChecked8 = value;}
		}
		public bool BuscaRazonSocial 
		{
			get{return _buscaRazonSocial;}
			set{_buscaRazonSocial = value;}
		}
		public bool BuscaTelefonos 
		{
			get{return _buscaTelefonos;}
			set{_buscaTelefonos = value;}
		}
		public bool BuscaTipoDoc 
		{
			get{return _buscaTipoDoc;}
			set{_buscaTipoDoc = value;}
		}
		public bool BuscaTitular 
		{
			get{return _buscaTitular;}
			set{_buscaTitular = value;}
		}
		//FIN VARIABLES CONFIGURACION
		public bool Activo 
		{
			get{return _activo;}
			set{_activo = value;}
		}

		/*public DataTable DataJerarquias
		{
			get{return _dataJerarquias;}
		}


		public ArrayList DataDomicilios
		{
			get{return _dataDirecciones;}
		}

		public DataTable DataContactos
		{
			get{return _dataContactos;}
		}*/

	/*	public bool Activo 
		{
			get{return _activo;}
			set{_activo = value;}
		}*/

		/*public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}*/



		public string ProcessName
		{
			get{return _processName;}
		}
		public string TaskName
		{
			get{return _taskName;}
		}

		public string Codigo
		{
			get{return _codigo;}
			set{_codigo = value;}
		}

		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}

		public string CampoAux1
		{
			get{return _campoAux1;}
			set{_campoAux1 = value;}
		}

		public string CampoAux2
		{
			get{return _campoAux2;}
			set{_campoAux2 = value;}
		}

		public string CampoAux3
		{
			get{return _campoAux3;}
			set{_campoAux3 = value;}
		}

		public string CampoAux4
		{
			get{return _campoAux4;}
			set{_campoAux4 = value;}
		}
		
		public decimal CampoAux5
		{
			get{return _campoAux5;}
			set{_campoAux5 = value;}
		}

		public bool CampoAux5Activo
		{
			get{return _campoAux5Activo;}
			set{_campoAux5Activo = value;}
		}

		public bool ExcluyeRetencionIVAActivo
		{
			get{return _excluyeRetencionIVAActivo;}
			set{_excluyeRetencionIVAActivo = value;}
		}

		public bool ExcluyeRetencionIIBBActivo
		{
			get{return _excluyeRetencionIIBBActivo;}
			set{_excluyeRetencionIIBBActivo = value;}
		}
				
		public bool ExcluyeRetencionIVA
		{
			get{return _excluyeRetencionIVA;}
			set{_excluyeRetencionIVA = value;}
		}

		public bool ExcluyeRetencionIIBB
		{
			get{return _excluyeRetencionIIBB;}
			set{_excluyeRetencionIIBB = value;}
		}		
		
		public string IdTipoMovimiento
		{
			get{return _idTipoMovimiento;}
			set{_idTipoMovimiento = value;}
		}

		public string IdSubTipoMovimiento
		{
			get{return _idSubTipoMovimiento;}
			set{_idSubTipoMovimiento = value;}
		}
		
		public string IdCondicionDeCompra
		{
			get{return _idCondicionDeCompra;}
			set{_idCondicionDeCompra = value;}
		}

		public long CondicionImpuestoGanancias
		{
			get{return _condicionImpuestoGanancias;}
			set{_condicionImpuestoGanancias = value;}
		}

		public DataTable TiposMovimientos
		{
			get {return businessrules.tsy_TiposMovimientos.GetList().tsy_TiposMovimientos;}
		}
		private DataTable _subTiposMovimientos = businessrules.tsy_SubTipoMovimiento.GetList().tsy_SubTipoMovimiento;
		public DataTable SubTiposMovimientos
		{
			get {return _subTiposMovimientos;}
		}
		public DataTable CondicionesDeCompra
		{
			get {return businessrules.tpu_CondicionesDeCompras.GetList().tpu_CondicionesDeCompras;}
		}

		public string Telefonos
		{
			get{return _telefonos;}
			set{_telefonos = value;}
		}

		public string Email
		{
			get{return _email;}
			set{_email = value;}
		}
		public string TipoDocumento
		{
			get{return _tipoDocumento;}
			set{_tipoDocumento = value;}
		}
		
		public string Documento
		{
			get{return _documento;}
			set{_documento = value;}
		}

		public string Titular
		{
			get{return _titular;}
			set{_titular = value;}
		}

		public string Calle
		{
			get{return _calle;}
			set{_calle = value;}
		}

		public string Localidad
		{
			get{return _localidad;}
			set{_localidad = value;}
		}

			
		/*private bool _habilitaVerDetalleVentas = false;
		public bool HabilitaVerDetalleVentas 
		{
			get { return _habilitaVerDetalleVentas; }
		}
		private bool _habilitaVerCuentaCorriente = false;
		public bool HabilitaVerCuentaCorriente 
		{
			get { return _habilitaVerCuentaCorriente; }
		}
		private bool _habilitaVerObservaciones = false;
		public bool HabilitaVerObservaciones 
		{
			get { return _habilitaVerObservaciones; }
		}*/

		private bool _byJerarquia1 = false;
		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}

		private bool _byJerarquia2 = false;
		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}

		private bool _byJerarquia3 = false;
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}

		private bool _byJerarquia4 = false;
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}

		private bool _byJerarquia5 = false;
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}

		private bool _byJerarquia6 = false;
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}

		private bool _byJerarquia7 = false;
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}

		private bool _byJerarquia8 = false;
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		private ArrayList _jerarquia1 = new ArrayList();
		public ArrayList Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}

		private ArrayList _jerarquia2 = new ArrayList();
		public ArrayList Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}

		private ArrayList _jerarquia3 = new ArrayList();
		public ArrayList Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}

		private ArrayList _jerarquia4 = new ArrayList();
		public ArrayList Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4 = value;}
		}

		private ArrayList _jerarquia5 = new ArrayList();		
		public ArrayList Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}

		private ArrayList _jerarquia6 = new ArrayList();
		public ArrayList Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}

		private ArrayList _jerarquia7 = new ArrayList();
		public ArrayList Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}

		private ArrayList _jerarquia8 = new ArrayList();
		public ArrayList Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}

		public string _idResponsable = string.Empty;
		public string IdResponsable
		{
			get{return _idResponsable;}
			set{_idResponsable=value;}
		}

		public DateTime _fechaAltaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaAltaDesde
		{
			get{return _fechaAltaDesde;}
			set{_fechaAltaDesde=value;}
		}

		public DateTime _fechaAltaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
		public DateTime FechaAltaHasta
		{
			get{return _fechaAltaHasta;}
			set{_fechaAltaHasta=value;}
		}

		private bool _buscarPorFechaAlta = false;
		public bool BuscarPorFechaAlta
		{
			get{return _buscarPorFechaAlta;}
			set{_buscarPorFechaAlta=value;}
		}

		public bool _buscarPorResponsable = false;
		public bool BuscarPorResponsable
		{
			get{return _buscarPorResponsable;}
			set{_buscarPorResponsable=value;}
		}
		#endregion

		#region Metodos Publicos


		public void GetDetalle(object SelectedItem)
		{
			if(SelectedItem != null)
			{
				DataRowView row = (DataRowView)SelectedItem;
				string IdProveedor = Convert.ToString(row["IdProveedor"]);
				/*_dataDirecciones = mz.erp.businessrules.tcs_DomiciliosCuentas.GetDomicilios(IdCuenta);
				_dataContactos = mz.erp.businessrules.tsa_Cuentas.GetListContactos(IdCuenta).Tables[0];
				_dataJerarquias = mz.erp.businessrules.tsa_Cuentas.GetListJerarquias(IdCuenta, _keyJerarquia1,_keyJerarquia2,_keyJerarquia3,_keyJerarquia4,_keyJerarquia5,_keyJerarquia6,_keyJerarquia7,_keyJerarquia8).Tables[0];*/
				if(DetalleChanged != null)
					DetalleChanged(this, new EventArgs());
			}
		}

		public DataView RefreshData()
		{
			string j1 = BuildJerarquia(_jerarquia1);
			string j2 = BuildJerarquia(_jerarquia2);
			string j3 = BuildJerarquia(_jerarquia3);
			string j4 = BuildJerarquia(_jerarquia4);
			string j5 = BuildJerarquia(_jerarquia5);
			string j6 = BuildJerarquia(_jerarquia6);
			string j7 = BuildJerarquia(_jerarquia7);
			string j8 = BuildJerarquia(_jerarquia8);

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			
			/**
			string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
			for(int i = 0; i<8;i++)
			{
				if(aux[i])
				{
					for(int j = 0; j<8; j++)
					{
						if(jers[j] == string.Empty)
						{
							jers[j] = jerarquias[i];
							break;
						}
					}
				}
			}
			*/

			if (!_buscarPorResponsable)
				this.IdResponsable=string.Empty;

			if (!_buscarPorFechaAlta)
			{
				this.FechaAltaDesde=DateTime.MinValue;
				this.FechaAltaHasta=DateTime.MinValue;
			}

			j1 = jerarquias[0];
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];
			DataTable result = mz.erp.businessrules.tpu_Proveedores.GetListGeneral(_codigo, _nombre, _campoAux1, _campoAux2, 
				_campoAux3, _campoAux4, _campoAux5, _campoAux5Activo,j1, j2, j3, j4, j5, j6, j7, j8, _calle, 
				_tipoDocumento,_documento,_titular,_activo,_email,_localidad,_telefonos, _idTipoMovimiento, _idSubTipoMovimiento, 
				_idCondicionDeCompra, _condicionImpuestoGanancias, _excluyeRetencionIVAActivo, _excluyeRetencionIVA, 
				_excluyeRetencionIIBBActivo, _excluyeRetencionIIBB, _idResponsable, _fechaAltaDesde, _fechaAltaHasta).Tables[0];

			
			/*@Calle varchar(100) = null,
	@idTipoDocumento varchar(5) = null ,
	@Documento varchar(13) = null ,
	@IdTitular varchar(20) = null ,
	@Activo bit ,
	@Email varchar(100) = null,
	@IdLocalidad varchar (20) = null,
	@Telefonos varchar(255) = null,
	@IdSucursal bigint = null,
	@IdEmpresa bigint = null	*/
			return result.DefaultView;			
		}

		public  void Init()
		{	
			_processName = "ProcesoConsultarProveedores";
			_taskName = "ConsultarProveedores";

			/*
txtRazonSocial true enabled
txtCodigo false
txtTelefonos false
mzCmbSrchEdtTitular false
txtCalle false
mzCmbSrchEdtLocalidad false
mzCETipoDoc
textBox1
txtEmail
txtCampoAux1
txtCampoAux2
txtCampoAux3
txtCampoAux4
uneCampoAuxiliar5
chkActivoCAux5
chkActivo
hierarchicalSearchControl1.NodeChecked1 = false;		
hierarchicalSearchControl1.NodeChecked2 = false;			
hierarchicalSearchControl1.NodeChecked3 = false;			
hierarchicalSearchControl1.NodeChecked4 = false;			
hierarchicalSearchControl1.NodeChecked5 = false;			
hierarchicalSearchControl1.NodeChecked6 = false;			
hierarchicalSearchControl1.NodeChecked7 = false;			
hierarchicalSearchControl1.NodeChecked8 = false;*/
			/*_habilitaVerCuentaCorriente = Variables.GetValueBool(_processName, _taskName, "HabilitaVerCuentaCorriente");
			_habilitaVerDetalleVentas = Variables.GetValueBool(_processName, _taskName, "HabilitaVerDetalleVentas");
			_habilitaVerObservaciones = Variables.GetValueBool(_processName, _taskName, "HabilitaVerObservaciones");*/
		}
		
		#endregion

		#region Metodos Privados

		private string BuildJerarquia(ArrayList je)
		{
				
			ArrayList narray = new ArrayList();
			foreach (object item in je) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				narray.Add(it.NodeKey);				
			}
			return mz.erp.systemframework.Util.PackString(narray);
		}

		#endregion
	}
}
