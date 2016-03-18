using System;
using System.Data;
using System.Collections;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de mzCuentasSerchForm.
	/// </summary>
	public class mzCuentasSearchForm
	{
		

		#region Constructores
		
		public mzCuentasSearchForm()
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
		    private string _idTipoDec = string.Empty;
			private string _nroDoc = string.Empty;
			private string _idTitular = string.Empty;
		    private string _idContacto = string.Empty;
			private string _calle = string.Empty;
			private string _idLocalidad = string.Empty;
			private string _email = string.Empty;
			private string _telefonos = string.Empty;
			private bool _activo = true;
			private string _processName = string.Empty;
			private string _taskName = string.Empty;
			
			private ArrayList _jerarquia1 = new ArrayList();
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
			private DataTable _dataJerarquias = null;


		private string _keyJerarquia1 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia1");
		private string _keyJerarquia2 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia2");
		private string _keyJerarquia3 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia3");
		private string _keyJerarquia4 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia4");
		private string _keyJerarquia5 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia5");
		private string _keyJerarquia6 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia6");
		private string _keyJerarquia7 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia7");
		private string _keyJerarquia8 = Variables.GetValueString("Cuentas.BusquedaJerarquica.Jerarquia8");
		
        /* Silvina 20110906 - Tarea 0000203 */
        private int _cantidad = 0;
        /* Fin Silvina 20110906 - Tarea 0000203 */

        /* Silvina 20111226 - Tarea 0000241 */

        private string _jerarquiaCampoAuxiliar6 = Variables.GetValueString("Cuentas.CampoAuxiliar6.JerarquiaAsociada");
        private string _campoAux6 = string.Empty;
        private string _separador = Variables.GetValueString("Cuentas.CampoAuxiliar6.JerarquiaAsociada.Separador");

        /* Fin Silvina 20111226 - Tarea 0000241 */
		#endregion

		#region Variables Publicas

		public DataTable DataJerarquias
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
		}

		public bool Activo 
		{
			get{return _activo;}
			set{_activo = value;}
		}

		public bool ByJerarquia1
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
		}



		public string ProcessName
		{
			get{return _processName;}
		}
		public string TaskName
		{
			get{return _taskName;}
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

        /* Silvina 20111226 - Tarea 0000241 */

        public string CampoAux6
        {
            get { return _campoAux6; }
            set { _campoAux6 = value; }
        }

        public string JerarquiaCampoAuxiliar6
        {
            get { return _jerarquiaCampoAuxiliar6; }
        }

        public string Separador
        {
            get { return _separador; }
        }

        /* Fin Silvina 20111226 - Tarea 0000241 */

		public string IdTipoDoc
		{
			get{return _idTipoDec;}
			set{_idTipoDec = value;}
		}
		
		public string NroDoc
		{
			get{return _nroDoc;}
			set{_nroDoc = value;}
		}

		public string IdTitular
		{
			get{return _idTitular;}
			set{_idTitular = value;}
		}

		public string IdContacto
		{
			get{return _idContacto;}
			set{_idContacto = value;}
		}

		public string Calle
		{
			get{return _calle;}
			set{_calle = value;}
		}

		public string IdLocalidad
		{
			get{return _idLocalidad;}
			set{_idLocalidad = value;}
		}
			
		private bool _habilitaVerDetalleVentas = false;
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
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
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
				string IdCuenta = Convert.ToString(row["IdCuenta"]);
				_dataDirecciones = mz.erp.businessrules.tcs_DomiciliosCuentas.GetDomicilios(IdCuenta);
				_dataContactos = mz.erp.businessrules.tsa_Cuentas.GetListContactos(IdCuenta).Tables[0];
				_dataJerarquias = mz.erp.businessrules.tsa_Cuentas.GetListJerarquias(IdCuenta, _keyJerarquia1,_keyJerarquia2,_keyJerarquia3,_keyJerarquia4,_keyJerarquia5,_keyJerarquia6,_keyJerarquia7,_keyJerarquia8).Tables[0];
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

			j1 = jerarquias[0];
			j2 = jerarquias[1];
			j3 = jerarquias[2];
			j4 = jerarquias[3];
			j5 = jerarquias[4];
			j6 = jerarquias[5];
			j7 = jerarquias[6];
			j8 = jerarquias[7];

			if (!_buscarPorResponsable)
				this.IdResponsable=string.Empty;

			if (!_buscarPorFechaAlta)
			{
				this.FechaAltaDesde=DateTime.MinValue;
				this.FechaAltaHasta=DateTime.MinValue;
			}

            /* Silvina 20110906 - Tarea 0000203 */
            /* Silvina 20111226 - Tarea 0000241 */
			DataTable result = mz.erp.businessrules.tsa_Cuentas.GetListGeneral(_codigo, _nombre, _idTipoDec, _nroDoc,
				_idTitular, _campoAux1, _campoAux2, _campoAux3, _calle, _idLocalidad, _telefonos, _email, _activo,
				j1, j2, j3, j4, j5, j6, j7, j8,Security.IdSucursal, Security.IdEmpresa, _idContacto, _idResponsable,
				_fechaAltaDesde, _fechaAltaHasta, _cantidad, _campoAux6, _separador).Tables[0];
            /* Fin Silvina 20111226 - Tarea 0000241 */
			/* Fin Silvina 20110906 - Tarea 0000203 */
			return result.DefaultView;

		}

		public  void Init()
		{	
			_processName = "ProcesoConsultarCuentas";
			_taskName = "ConsultarCuentas";
			_habilitaVerCuentaCorriente = Variables.GetValueBool(_processName, _taskName, "HabilitaVerCuentaCorriente");
			_habilitaVerDetalleVentas = Variables.GetValueBool(_processName, _taskName, "HabilitaVerDetalleVentas");
			_habilitaVerObservaciones = Variables.GetValueBool(_processName, _taskName, "HabilitaVerObservaciones");
            /* Silvina 20110906 - Tarea 0000203 */
            _cantidad = (int)Variables.GetValueLong(_processName, _taskName, "CantidadDeClientesAMostrar",100);
            /* Fin Silvina 20110906 - Tarea 0000203 */
			
		}
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            long dias = Variables.GetValueLong(_processName, this._taskName, "RangoFechas.DiasAnteriores");
            this._fechaAltaDesde = fechaDesde;
            if (this.FechaAltaHasta < fechaDesde)
            {
                _fechaAltaHasta = mz.erp.systemframework.Util.GenerateFechaHasta(fechaDesde, dias);
            }
        }
        //Fin Cristian		
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
