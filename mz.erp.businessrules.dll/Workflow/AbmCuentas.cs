using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;
using mz.erp.systemframework;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmCuentas.
	/// </summary>
	public class AbmCuentas
	{
		public AbmCuentas()
		{
			_habilitaJerarquias = Variables.GetValueBool("Cuentas.ABMCuentas.HabilitaJerarquias");
			_habilitaListasDePrecios = Variables.GetValueBool("Productos.ListasDePrecios");
			_allowEditAlicuotaPercepcionIngresosBrutos = Variables.GetValueBool("Momentos.ABMCuentas.Editar.AlicuotaPercepcionInngresosBrutos");

			_allowEditLimiteDeCredito = Variables.GetValueBool("Momentos.ABMCuentas.Editar.LimiteDeCredito");
			_allowEditDiasLimiteDeCredito = Variables.GetValueBool("Momentos.ABMCuentas.Editar.DiasLimiteDeCredito");
			_allowEditResponsableIngreso = Variables.GetValueBool("Momentos.ABMCuentas.Editar.ResponsableIngreso");
			_askForPasswordResponsableIngreso = Variables.GetValueBool("Momentos.ABMCuentas.HabilitarContraseña.ResponsableIngreso");
			if (_allowEditResponsableIngreso)
				this.IdResponsableIngreso = null;
			else
				this.IdResponsableIngreso = mz.erp.businessrules.Security.IdPersona;
            /* Silvina 20111104 - Tarea 0000222 */
            _etiquetaCampoAuxiliar6 = Variables.GetValueString("Cuentas.CampoAuxiliar6.Etiqueta");
            _jerarquiaCampoAuxiliar6 = Variables.GetValueString("Cuentas.CampoAuxiliar6.JerarquiaAsociada");
            /* Fin Silvina 20111104 - Tarea 0000222 */
            /* Silvina 20111226 - Tarea 0000241 */
            _separador = Variables.GetValueString("Cuentas.CampoAuxiliar6.JerarquiaAsociada.Separador");
            _allowEditCampoAuxiliar6 = Variables.GetValueBool("Momentos.ABMCuentas.Editar.CampoAuxiliar6");
            /* Fin Silvina 20111226 - Tarea 0000241 */
		}

		#region Métodos  Privados

		private void Addtsa_AgrupCuentasRow(string Jerarquia, string IdCuenta)
		{
			
			tsa_CuentasExDataset.tsa_AgrupCuentasRow rowAc = _data.tsa_AgrupCuentas.Newtsa_AgrupCuentasRow();
			rowAc.IdCuenta = IdCuenta;
			rowAc.Jerarquia = Jerarquia;
			rowAc.FechaCreacion = DateTime.Now;
			rowAc.IdConexionCreacion = Security.IdConexion;
			rowAc.IdReservado = 0;
			rowAc.IdEmpresa = Security.IdEmpresa;								
			_data.tsa_AgrupCuentas.Addtsa_AgrupCuentasRow(rowAc);
		}

		private void AddTsa_CuentasJerarquias(string idCuenta, ArrayList TodaJerarquia)
		{
			tsa_CuentasExDataset.tsa_CuentasJerarquiasRow _row = this._data.tsa_CuentasJerarquias.Newtsa_CuentasJerarquiasRow();
			_row.IdCuenta = idCuenta;
			_row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			_row.IdConexionCreacion = Security.IdConexion;
			_row.IdConexionUltimaModificacion = Security.IdConexion;
			_row.IdReservado = 0;
			_row.RowId = Guid.Empty;
			_row.IdEmpresa = Security.IdEmpresa;
			_row.IdSucursal=Security.IdSucursal;
			_row=this.MetodoAuxiliarAddTsa_CuentasJerarquias(TodaJerarquia,_row);
			_data.tsa_CuentasJerarquias.Addtsa_CuentasJerarquiasRow(_row);
				
		}

		private tsa_CuentasExDataset.tsa_CuentasJerarquiasRow MetodoAuxiliarAddTsa_CuentasJerarquias(ArrayList TodaJerarquia,tsa_CuentasExDataset.tsa_CuentasJerarquiasRow _row)
		{
			 
			ArrayList ArrayNiveles1 = (TodaJerarquia.Count >0 && TodaJerarquia[0] != null)? (ArrayList)TodaJerarquia[0] : new ArrayList();
			ArrayList ArrayNiveles2 = (TodaJerarquia.Count >1 && TodaJerarquia[1] != null)? (ArrayList)TodaJerarquia[1] : new ArrayList();
			ArrayList ArrayNiveles3 = (TodaJerarquia.Count >2 && TodaJerarquia[2] != null)? (ArrayList)TodaJerarquia[2] : new ArrayList();
			ArrayList ArrayNiveles4 = (TodaJerarquia.Count >3 && TodaJerarquia[3] != null)? (ArrayList)TodaJerarquia[3] : new ArrayList();
			ArrayList ArrayNiveles5 = (TodaJerarquia.Count >4 && TodaJerarquia[4] != null)? (ArrayList)TodaJerarquia[4] : new ArrayList();
			ArrayList ArrayNiveles6 = (TodaJerarquia.Count >5 && TodaJerarquia[5] != null)? (ArrayList)TodaJerarquia[5] : new ArrayList();
			ArrayList ArrayNiveles7 = (TodaJerarquia.Count >6 && TodaJerarquia[6] != null)? (ArrayList)TodaJerarquia[6] : new ArrayList();
			ArrayList ArrayNiveles8 = (TodaJerarquia.Count >7 && TodaJerarquia[7] != null)? (ArrayList)TodaJerarquia[7] : new ArrayList();
				
									
			int i= ArrayNiveles1.Count;
			if (i>0)
			{
				_row.IdNomenclatura1a= Convert.ToString(ArrayNiveles1[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura1b=Convert.ToString( ArrayNiveles1[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura1c=Convert.ToString( ArrayNiveles1[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura1d= Convert.ToString(ArrayNiveles1[3]);
				i--;
			}
				
			//ArrayNiveles 2
			i= ArrayNiveles2.Count;
			if (i>0)
			{
				_row.IdNomenclatura2a= Convert.ToString(ArrayNiveles2[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura2b= Convert.ToString(ArrayNiveles2[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura2c= Convert.ToString(ArrayNiveles2[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura2d=Convert.ToString( ArrayNiveles2[3]);
				i--;
			}
			//ArrayNiveles3
			i= ArrayNiveles3.Count;
			if (i>0)
			{
				_row.IdNomenclatura3a=Convert.ToString( ArrayNiveles3[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura3b= Convert.ToString(ArrayNiveles3[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura3c= Convert.ToString(ArrayNiveles3[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura3d= Convert.ToString(ArrayNiveles3[3]);
				i--;
			}
			//Array Niveles 4
			i= ArrayNiveles4.Count;
			if (i>0)
			{
				_row.IdNomenclatura4a= Convert.ToString(ArrayNiveles4[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura4b= Convert.ToString(ArrayNiveles4[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura4c= Convert.ToString(ArrayNiveles4[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura4d= Convert.ToString(ArrayNiveles4[3]);
				i--;
			}

			//Array Niveles 5
			i= ArrayNiveles5.Count;
			if (i>0)
			{
				_row.IdNomenclatura5a= Convert.ToString(ArrayNiveles5[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura5b= Convert.ToString(ArrayNiveles5[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura5c= Convert.ToString(ArrayNiveles5[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura5d= Convert.ToString(ArrayNiveles5[3]);
				i--;
			}
			//Array Niveles 6
			i= ArrayNiveles6.Count;
			if (i>0)
			{
				_row.IdNomenclatura6a=Convert.ToString( ArrayNiveles6[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura6b= Convert.ToString(ArrayNiveles6[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura6c= Convert.ToString(ArrayNiveles6[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura6d= Convert.ToString(ArrayNiveles6[3]);
				i--;
			}
			//Array Niveles 7
			i= ArrayNiveles7.Count;
			if (i>0)
			{
				_row.IdNomenclatura7a= Convert.ToString(ArrayNiveles7[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura7b= Convert.ToString(ArrayNiveles7[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura7c= Convert.ToString(ArrayNiveles7[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura7d= Convert.ToString(ArrayNiveles7[3]);
				i--;
			}
			//Array Niveles 8
			i= ArrayNiveles8.Count;
			if (i>0)
			{
				_row.IdNomenclatura8a= Convert.ToString(ArrayNiveles8[0]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura8b= Convert.ToString(ArrayNiveles8[1]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura8c= Convert.ToString(ArrayNiveles8[2]);
				i--;
			}
			if (i>0)
			{
				_row.IdNomenclatura8d= Convert.ToString(ArrayNiveles8[3]);
				i--;
			}
			return _row;
			
		}
			
		#endregion

		#region Propiedades

		public bool AllowEditLimiteDeCredito
		{
			get{return _allowEditLimiteDeCredito;}
		}

		public bool AllowEditDiasLimiteDeCredito
		{
			get{return _allowEditDiasLimiteDeCredito;}
		}

		
		public bool AllowEditAlicuotaPercepcionIngresosBrutos
		{
			get{return _allowEditAlicuotaPercepcionIngresosBrutos;}
		}

		public bool HabilitaListasDePrecios
		{
			get{return _habilitaListasDePrecios;}
		}

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

		private CuentasJearaquias _jerarquias = new CuentasJearaquias();
		public CuentasJearaquias Jerarquias
		{
			get{return _jerarquias;}
		}

        /* Silvina 20111104 - Tarea 0000222 */
        ArrayList _jerarquiasCampoAuxiliar6 = new ArrayList();
        public ArrayList JerarquiasCampoAuxiliar6
        {
            get { return _jerarquiasCampoAuxiliar6; }
        }

        private string _etiquetaCampoAuxiliar6 = string.Empty;
        public string EtiquetaCampoAuxiliar6
        {
            get { return _etiquetaCampoAuxiliar6; }
        }

        private string _jerarquiaCampoAuxiliar6 = string.Empty;
        public string JerarquiaCampoAuxiliar6
        {
            get { return _jerarquiaCampoAuxiliar6; }
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */

        /* Silvina 20111226 - Tarea 0000241 */
        private string _separador = string.Empty;
        public string Separador
        {
            get { return _separador; }
        }

        private bool _allowEditCampoAuxiliar6 = false;
        public bool AllowEditCampoAuxiliar6
        {
            get { return _allowEditCampoAuxiliar6; }
        }

        /* Fin Silvina 20111226 - Tarea 0000241 */

		private string _idCuenta = string.Empty;
		public string IdCuenta
		{
			get{return _idCuenta;}
			set{_idCuenta = value;}
		}

		public ArrayList DataContactos
		{
			get{return _dataContactos;}
		}
		public long LengthRazonSocial
		{
			
			get{
				long length=Variables.GetValueLong("Cuentas.RazonSocial.Length");
				if (length!= long.MinValue)
						_lengthRazonSocial=length;
				return _lengthRazonSocial;}
		}

		
		public ArrayList DataDomicilios
		{
			get{return _dataDomicilios;}
		}
		
		#endregion
	
		#region Variables privadas
		private bool _habilitaJerarquias = false;
		private bool _habilitaListasDePrecios = false;
		private tsa_CuentasExDataset _data;		
		private ArrayList _dataContactos = new ArrayList();
		private long _lengthRazonSocial=500;
		private ArrayList _dataContactosDeleted = new ArrayList();
		private ArrayList _dataDomicilios = new ArrayList();
		private ArrayList _dataDomiciliosDeleted = new ArrayList();
		private long  _idPaisDefault = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
		private long  _idProvinciaDefault = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
		private bool _allowEditAlicuotaPercepcionIngresosBrutos = false;

		private bool _allowEditLimiteDeCredito = false;
		private bool _allowEditDiasLimiteDeCredito = false;

		private string _idResponsableIngreso = string.Empty;
		private string _responsableIngreso = string.Empty;
		private bool _allowEditResponsableIngreso = false;
        private bool _askForPasswordResponsableIngreso = false;
		private string _ultimoResponsableClaveCorrecta = string.Empty;

		#endregion
	
		#region Eventos y delegados
		#endregion

		#region Métodos Públicos
		public void InitJerarquias()
		{
			if(this.IdCuenta != "" && _habilitaJerarquias)
			{
				DataSet _dataAgrup = dataaccess.tsa_AgrupCuentas.GetListEx(this.IdCuenta,long.MinValue);
				foreach(DataRow rowJ in _dataAgrup.Tables[0].Rows)
				{
					CuentaJerarquia pj = new CuentaJerarquia();
					pj.IdCuenta = this.IdCuenta;
					pj.Jerarquia = Convert.ToString(rowJ["Jerarquia"]);
					pj.IdNomenclatura = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetPkByJerarquia(Convert.ToString(rowJ["Jerarquia"]));
					this._jerarquias.Add(pj);
				}
			}

		}

        /* Silvina 20111104 - Tarea 0000222 */

        public void InitCampoAuxiliar6(string CampoAuxiliar6)
        {
            _jerarquiasCampoAuxiliar6.Clear();
            /* Silvina 20111226 - Tarea 0000241 */
            ArrayList CampoAuxiliar6BDList = mz.erp.systemframework.Util.Parse(CampoAuxiliar6, Separador);
            /* Fin Silvina 20111226 - Tarea 0000241 */
            foreach (string aux in CampoAuxiliar6BDList)
            {
                if (aux != null && aux != string.Empty)
                {
                    DataRow row = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetPkByDescripcion(aux);
                    ItemJerarquia pj = new ItemJerarquia("CUENTAS");
                    pj.NodeKeyPath = Convert.ToString(row["Jerarquia"]);
                    pj.NodeKey = Convert.ToString(row["IdNomenclatura"]);
                    _jerarquiasCampoAuxiliar6.Add(pj);

                }
            }
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

		public tsa_CuentasExDataset Commit(tsa_CuentasExDataset data, string IdCuenta)
		{
			_data = data;
			if(_habilitaJerarquias)
			{				
				_data.tsa_AgrupCuentas.Clear();
				_data.Merge(mz.erp.dataaccess.tsa_AgrupCuentas.GetList(IdCuenta, long.MinValue).Tables[0]);
				foreach(DataRow rowJ in data.tsa_AgrupCuentas.Rows)
				{
					rowJ.Delete();
				}	

				_data.tsa_CuentasJerarquias.Clear();
				tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow _auxRow=mz.erp.dataaccess.tsa_CuentasJerarquias.GetByPk(IdCuenta);
				if ( _auxRow!=null)
					_data.tsa_CuentasJerarquias.ImportRow(_auxRow);
				foreach(DataRow rowCJ in _data.tsa_CuentasJerarquias.Rows)
				{
					rowCJ.Delete();
				}

				if(ByJerarquia1)
					foreach(ItemJerarquia item in this._jerarquia1)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia2)
					foreach(ItemJerarquia item in this._jerarquia2)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia3)
					foreach(ItemJerarquia item in this._jerarquia3)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia4)
					foreach(ItemJerarquia item in this._jerarquia4)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia5)
					foreach(ItemJerarquia item in this._jerarquia5)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia6)
					foreach(ItemJerarquia item in this._jerarquia6)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia7)
					foreach(ItemJerarquia item in this._jerarquia7)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);
				if(ByJerarquia8)
					foreach(ItemJerarquia item in this._jerarquia8)
						this.Addtsa_AgrupCuentasRow(item.NodeKeyPath, IdCuenta);

				CuentasJerarquiaAuxiliar c= new CuentasJerarquiaAuxiliar();
				c.cargarJerarquias(_data.tsa_AgrupCuentas);
				Hashtable aux=c.CuentaJerarquia;
				//Para cada cuenta
				foreach(string idCuen in aux.Keys)
				{
					object valor = aux[idCuen];
					this.AddTsa_CuentasJerarquias(idCuen,(ArrayList)valor);
				}


			}
			return _data;
		}


		public void InitContactos()
		{
			if(this._idCuenta != null)
			{
				_dataContactos.Clear();
				DataTable contactos = mz.erp.businessrules.tsa_Cuentas.GetListContactos(_idCuenta).Tables[0];
				foreach( DataRow row in contactos.Rows)
				{
					Contacto cont = new Contacto(row);
					_dataContactos.Add(cont);
				}
			}
		}

        /* Silvina 20110302 - Tarea 0000081 */
        private string _idCuentaAnt = string.Empty;
        public bool InitDomicilios()
        /* Fin Silvina - Tarea 0000081 */
        {
            /* Silvina 20110302 - Tarea 0000081 */
            if ((this._idCuenta != null) && !(_idCuenta.Equals(_idCuentaAnt)))
                /* Fin Silvina - Tarea 0000081 */
            {
                _dataDomicilios.Clear();
                tsa_CuentasExDataset dataCuenta = mz.erp.businessrules.tsa_CuentasEx.GetByPk(_idCuenta);
                DataTable domicilios = dataCuenta.tcs_Domicilios;
                DataTable tableCuentas = dataCuenta.tsa_Cuentas;
                /* Silvina 20101202 - Tarea 940 */
                if (tableCuentas.Rows.Count != 0)
                    /* Fin Silvina */
                {
                    DataRow rowCuenta = tableCuentas.Rows[0];
                    string idDomicilioDefault = Convert.ToString(rowCuenta["IdDomicilioDefault"]);
                    foreach (DataRow row in domicilios.Rows)
                    {
                        DomicilioCuenta dom = new DomicilioCuenta(row, _idCuenta, idDomicilioDefault);
                        _dataDomicilios.Add(dom);
                    }
                }
                /* Silvina 20110302 - Tarea 0000081 */
                _idCuentaAnt = _idCuenta;
                return true;
                /* Fin Silvina - Tarea 0000081 */
            }
                /* Silvina 20110302 - Tarea 0000081 */
            else
                return false;
            /* Fin Silvina - Tarea 0000081 */
        }

	    public void AddContacto()
		{
            Contacto cont = new Contacto(_idCuenta, "NEW");	
			_dataContactos.Insert(0,cont);
		}

		public void AddDomicilio()
		{			
			bool isDefault = _dataDomicilios.Count == 0 ;
			DomicilioCuenta dom = new DomicilioCuenta(_idCuenta, isDefault, "NEW");	
			_dataDomicilios.Insert(0,dom);
		}

	
		public void AddDomicilio(DomicilioCuenta dom)
		{			
			_dataDomicilios.Insert(0,dom);
		}

        /* Silvina 20110804 - Tarea 0000178 */
        public void Cancelar()
        {
            ArrayList DataNew = new ArrayList();
            foreach (DomicilioCuenta dom in _dataDomicilios)
            {
                if (dom.Estado.Equals("NEW"))
                    if (dom.Aceptado)
                        dom.Cancelar();
                    else
                        DataNew.Add(dom);
                if (dom.Estado.Equals("MODIF") && !dom.Aceptado)
                    dom.Cancelar();
            }
            foreach (DomicilioCuenta dom in DataNew)
            {
                DataDomicilios.Remove(dom);
            }
        }

        public void Aceptar()
        {
            foreach (DomicilioCuenta dom in _dataDomicilios)
            {
                if (!dom.Estado.Equals("DEL"))
                    dom.Aceptar();
                dom.Aceptado = true;
            }
        }

        public void ActualizarDomiciliosDefault()
        {
            foreach (DomicilioCuenta domC in _dataDomicilios)
            {
                if (domC.Default)
                {
                    domC.Default = false;
                    if (!domC.Estado.Equals("NEW"))
                        domC.Estado = "MODIF";
                }
            }
        }

        /* Fin Silvina 20110804 - Tarea 0000178 */

		public bool ExistContacto(string idPersona)
		{
			bool exist = false;
			int i = 0;
			while(!exist && i < _dataContactos.Count)
			{
				Contacto cont = (Contacto)_dataContactos[i];
				exist = cont.IdPersona.Equals(idPersona);
				i++;
			}
			return exist;
		}

		public void AddContacto(string idPersona, string nombre, string telefonos, string email, string comentarios, string instantMesseger, bool activo)
		{
			Contacto cont = new Contacto(_idCuenta, idPersona, nombre, telefonos, email, comentarios, instantMesseger, activo, "ADD");	
			_dataContactos.Insert(0,cont);
		}

		public bool MustShowPersona(int index)
		{
			Contacto cont = (Contacto)_dataContactos[index];
			return !cont.Estado.Equals("NEW");
		}


		public void ModifyContacto(int index)
		{
			Contacto cont = (Contacto)_dataContactos[index];
			if(!cont.Estado.Equals("NEW") && !cont.Estado.Equals("ADD"))
                cont.Estado = "MODIF";
		}

		public void ModifyDomicilio(int index)
		{
			DomicilioCuenta dom = (DomicilioCuenta)_dataDomicilios[index];

			if(dom.Default)
			{
				foreach(DomicilioCuenta domC in _dataDomicilios)
				{
					if(domC.Default)
					{
						domC.Default = false;
						if(!domC.Estado.Equals("NEW"))
							domC.Estado = "MODIF";
					}
				}
				dom.Default = true;
			}
			//German 20100118 SP6 647
			else
				if(!dom.Estado.Equals("NEW"))
				dom.Estado = "MODIF";
			//Fin German 20100118 SP6 647

		}

		public void ModifyDomicilio(DomicilioCuenta dom)
		{
			if(!dom.Estado.Equals("NEW"))
                dom.Estado = "MODIF";
		}

		public void DeleteContacto(int index)
		{
			Contacto cont = (Contacto)_dataContactos[index];
			if(!cont.Estado.Equals("NEW"))
			{
				cont.Estado = "DEL";
				//_dataContactos.Remove(cont);
				_dataContactosDeleted.Add(cont);
			}
		}

		public void DeleteDomicilio(int index)
		{
			DomicilioCuenta dom = (DomicilioCuenta)_dataDomicilios[index];
			if(!dom.Estado.Equals("NEW"))
			{
				dom.Estado = "DEL";
                /* Silvina 20101202 - Tarea 940 */
				//_dataDomicilios.Remove(dom);
                /* Fin Silvina */
				_dataDomiciliosDeleted.Add(dom);
			}
            /* Silvina 20110823 - Tarea 0000178 */
            _dataDomicilios.Remove(dom);
            if (_dataDomicilios.Count == 1)
            {
                DomicilioCuenta domDef = (DomicilioCuenta)_dataDomicilios[0];
                domDef.Default = true;
                if (string.IsNullOrEmpty(domDef.Estado))
                    domDef.Estado = "MODIF";
            }
            /* Fin Silvina 20110823 - Tarea 0000178 */
		}

		public bool isDefaultDomicilio(int index)
		{
			DomicilioCuenta dom = (DomicilioCuenta)_dataDomicilios[index];
			return dom.Default;
		}

		public tsa_CuentasExDataset UpdateContactos(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			data.tsh_Personas.Clear();
			data.tsh_Contactos.Clear();
			foreach(Contacto cont in _dataContactos)
			{
				data = cont.Commit(data);
			}

			foreach(Contacto cont in _dataContactosDeleted)
			{
				data = cont.Commit(data);
			}
			
			return data;
		}

		public tsa_CuentasExDataset UpdateDomicilios(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			//data.tcs_DomiciliosCuentas.Clear();
			//data.tcs_Domicilios.Clear();
			foreach(DomicilioCuenta dom in _dataDomiciliosDeleted)
			{
				data = dom.Commit(data);
			}
			foreach(DomicilioCuenta dom in _dataDomicilios)
			{
				data = dom.Commit(data);
			}
			return data;
		}

		public bool isDomicilioAdded(string idDomicilio)
		{
			bool exist = false;
			int i = 0;
			DomicilioCuenta dom = null;
			while(!exist && i < _dataDomicilios.Count)
			{
				dom = (DomicilioCuenta)_dataDomicilios[i];
				exist = dom.IdDomicilio.Equals(idDomicilio);
				i++;
			}
			if(dom == null)
				return false;
			else
                return dom.Estado.Equals("ADDED");
		}

		public DomicilioCuenta GetDomicilio(int index)
		{
			return (DomicilioCuenta)_dataDomicilios[index];
		}
        //Cristian Tarea 890
        public String GetCodigoPostal(string idLcoalidad)
        {
            foreach (mz.erp.businessrules.Domicilio domicilio in this.DataDomicilios )
            {
                //(Domicilio)domicilio;
                if (domicilio.Localidad.Equals(idLcoalidad))
                {
                    return domicilio.CodigoPostal;
                }
            }

            return String.Empty;
        }
        //Fin Tarea 890

		#endregion
		public class CuentaJerarquia
		{
			private string _idCuenta = string.Empty;
			private string _jerarquia = string.Empty;
			private string _idNomenclatura = string.Empty;

			public string IdCuenta
			{
				get{return _idCuenta;}
				set{_idCuenta = value;}
	
			}
			public string IdNomenclatura
			{
				get{return _idNomenclatura;}
				set{_idNomenclatura = value;}
			}
			public string Jerarquia
			{
				get{return _jerarquia;}
				set{_jerarquia = value;}
			}
		}

		public class CuentasJearaquias: CollectionBase    
		{                                                  
			public CuentasJearaquias()                
			{                                          
			}                                          
			public void Add(object sender)             
			{                                          
				base.List.Add( sender );           
			}                                          
                                                   
		} 
		public string IdResponsableIngreso
		{
			get{return _idResponsableIngreso;}
			set
			{
				if(_idResponsableIngreso != value)
				{				
					_idResponsableIngreso = value;					
					if ( _idResponsableIngreso != null && !_idResponsableIngreso.Equals(string.Empty) )
					{
						tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(value);
						_responsableIngreso =  row.Nombre;						
					}
					else 
					{
						_responsableIngreso = string.Empty;
					}
				}
			}
		}
		public string ResponsableIngreso
		{
			get{return _responsableIngreso;}
			set{_responsableIngreso=value;}
		}
		public bool AllowEditResponsableIngreso
		{
			get{return _allowEditResponsableIngreso;}
			set{_allowEditResponsableIngreso=value;}
		}
		public bool AskForPasswordResponsableIngreso
		{
			get{return _askForPasswordResponsableIngreso;}
			set{_askForPasswordResponsableIngreso=value;}
		}
		public string UltimoResponsableClaveCorrecta
		{
			get{return _ultimoResponsableClaveCorrecta;}
			set{_ultimoResponsableClaveCorrecta=value;}
		}
		
	}

	public class CuentasJerarquiaAuxiliar
	{	
		private Hashtable _cuentaJerarquia=new Hashtable();
		private string _jerarquia1 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia1" );
		private string _jerarquia2 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia2" );
		private string _jerarquia3 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia3" );
		private string _jerarquia4 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia4" );
		private string _jerarquia5 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia5" );
		private string _jerarquia6 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia6" );
		private string _jerarquia7 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia7" );
		private string _jerarquia8 = Variables.GetValueString( "Cuentas.BusquedaJerarquica.Jerarquia8" );
		public CuentasJerarquiaAuxiliar()
		{	

		}

		#region properties
			
		public string Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}

		public string Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}
		public string Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}
		public string Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4= value;}
		}
		public string Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}
		public string Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}
		public string Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}
		public string Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}
		public Hashtable CuentaJerarquia
		{
			get{return _cuentaJerarquia;}
			set{_cuentaJerarquia = value;}
		}
			
		#endregion properties
			
		public void cargarJerarquias(tsa_CuentasExDataset.tsa_AgrupCuentasDataTable tabla)
		{
			
			foreach (tsa_CuentasExDataset.tsa_AgrupCuentasRow row in tabla)
			{
				if (!Convert.ToString(row.RowState).Equals("Deleted"))
				{
					string idCuenta= Convert.ToString(row.IdCuenta);
					string jerarquia=Convert.ToString(row.Jerarquia);
					string jerarquiaReal=this.jerarquiaReal(jerarquia);
					ArrayList jerarCuenta;
					ArrayList ArrayNiveles;
					if(_cuentaJerarquia[idCuenta]!=null)
					{
						jerarCuenta=(ArrayList)_cuentaJerarquia[idCuenta];
					}
					else 
					{
						ArrayList aux=new ArrayList(7);
						int contador;
						for( contador=0; contador <= 6; contador++ ) 
						{
							aux.Add(new ArrayList());
						}
						_cuentaJerarquia.Add(idCuenta,aux);
						jerarCuenta=(ArrayList)_cuentaJerarquia[idCuenta];
					}
					
					//Me da 1, 2, 3.....
					int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
					ArrayNiveles=new ArrayList();
					ArrayNiveles = Util.Parse(jerarquia,20);
					//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
					//jerarProducto[posicion-1]=ArrayNiveles;
					posicion--;
					jerarCuenta.Insert(posicion,ArrayNiveles);
				}
			}
		}
		//
		public void cargarJerarquias(string jerarquia,string idCuenta)
		{
			string jerarquiaReal=this.jerarquiaReal(jerarquia);
			ArrayList jerarCuenta;
			ArrayList ArrayNiveles;
			if(_cuentaJerarquia[idCuenta]!=null)
			{
				jerarCuenta=(ArrayList)_cuentaJerarquia[idCuenta];
			}
			else 
			{
				ArrayList aux=new ArrayList(7);
				int contador;
				for( contador=0; contador <= 6; contador++ ) 
				{
					aux.Add(new ArrayList());
				}
				_cuentaJerarquia.Add(idCuenta,aux);
				jerarCuenta=(ArrayList)_cuentaJerarquia[idCuenta];
			}
					
			//Me da 1, 2, 3.....
			int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
			ArrayNiveles=new ArrayList();
			ArrayNiveles = Util.Parse(jerarquia,20);
			//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
			//jerarProducto[posicion-1]=ArrayNiveles;
			posicion--;
			jerarCuenta.Insert(posicion,ArrayNiveles);
									
		}
		private string jerarquiaReal(string jerarquia)
		{
			string resultado=string.Empty;	
			if (!jerarquia.Equals(string.Empty)){
			string aux=jerarquia.Substring(0,20);
			
			if( aux== this._jerarquia1)
				resultado="jerarquia1";
			if( aux== this._jerarquia2)
				resultado="jerarquia2";
			if( aux== this._jerarquia3)
				resultado="jerarquia3";
			if( aux== this._jerarquia4)
				resultado="jerarquia4";
			if( aux== this._jerarquia5)
				resultado="jerarquia5";
			if( aux== this._jerarquia6)
				resultado="jerarquia6";
			if( aux== this._jerarquia7)
				resultado="jerarquia7";
			if( aux== this._jerarquia8)
				resultado="jerarquia8";}
			return resultado;
		}

		public string nomenclaturaReal(string jerarquia)
		{
			string resultado=string.Empty;	
			if (!jerarquia.Equals(string.Empty)){
			string aux=jerarquia.Substring(0,20);
			
			if( aux== this._jerarquia1)
				resultado="IdNomenclatura1";
			if( aux== this._jerarquia2)
				resultado="IdNomenclatura2";
			if( aux== this._jerarquia3)
				resultado="IdNomenclatura3";
			if( aux== this._jerarquia4)
				resultado="IdNomenclatura4";
			if( aux== this._jerarquia5)
				resultado="IdNomenclatura5";
			if( aux== this._jerarquia6)
				resultado="IdNomenclatura6";
			if( aux== this._jerarquia7)
				resultado="IdNomenclatura7";
			if( aux== this._jerarquia8)
				resultado="IdNomenclatura8";
			}
			return resultado;
		}
			
	}
}
