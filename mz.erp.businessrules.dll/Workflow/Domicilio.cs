using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Domicilio.
	/// </summary>
	public class DomicilioCuenta
	{
		#region Constructores

		public DomicilioCuenta(string idCuenta, bool isDefault, string estado)			
		{
			_estado = estado;
			_idCuenta = idCuenta;
			_idDomicilio = systemframework.Util.NewStringId();
            /* Silvina 20101125 - Tarea 940 */
            IdPais = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
            IdProvincia = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
            IdLocalidad = Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");
            /* Fin Silvina */
            //German 20101102 - Tarea 890
            _codigoPostal = mz.erp.businessrules.tsh_Localidades.GetByPk(_idLocalidad).CodigoPostal;
            //Fin German 20101102 - Tarea 890
			_default = isDefault;
		}

		public DomicilioCuenta(DataRow row, string idCuenta, string idDomicilioDefault)			
		{
			_idCuenta = idCuenta;
			string idDom = row["IdDomicilio"].ToString();
			_idDomicilio = idDom;
			_idTipoDomicilio = Convert.ToInt64(row["IdTipoDomicilio"]);
			_calle = row["Calle"].ToString();
			_numero = row["Numero"].ToString();
			_sector = row["Sector"].ToString();
			_torre = row["Torre"].ToString();
			_piso = row["Piso"].ToString();
			_departamento = row["Departamento"].ToString();
			_manzana = row["Manzana"].ToString();
            //German 20101110 - Tarea 918
			_codigoPostal =  mz.erp.businessrules.tsh_Localidades.GetByPk(_idLocalidad).CodigoPostal;
            //Fin German 20101110 - Tarea 918

            /* Silvina 20101123 - Tarea 940 */
            /*if(row["IdLocalidad"] == null)
                _idLocalidad = string.Empty;
            else
                _idLocalidad = row["IdLocalidad"].ToString();
            _partido = row["Partido"].ToString();
            _idProvincia = Convert.ToInt64(row["IdProvincia"]);
            _idPais = Convert.ToInt64(row["IdPais"]);*/
            IdPais = Convert.ToInt64(row["IdPais"]);
            IdProvincia = Convert.ToInt64(row["IdProvincia"]);
            if (row["IdLocalidad"] == null)
                IdLocalidad = string.Empty;
            else
                IdLocalidad = row["IdLocalidad"].ToString();
            _partido = row["Partido"].ToString();
            /* Fin Silvina */
			_idResponsable = row["IdResponsable"].ToString();
			_telefono = row["Telefono"].ToString();

			_default = idDom.Equals(idDomicilioDefault);
            /* Silvina 20110804 - Tarea 0000178 */
            _rowBD = row;
            _defaultBD = _default;
            /* Fin Silvina 20110804 - Tarea 0000178 */
		}
		#endregion

		#region Variables Privadas
		string _idDomicilio = string.Empty;
		long _idTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
        string _calle = string.Empty;
		string _numero = "S/N";
		string _sector = string.Empty;
		string _torre = string.Empty;
		string _piso = string.Empty;
		string _departamento = string.Empty;
		string _manzana = string.Empty;
		string _codigoPostal = string.Empty;
        /* Silvina 20101203 - Tarea 940 */
        long _idPais = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
        long _idProvincia = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
		string _idLocalidad = Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");
		string _partido = string.Empty;
        /* Fin Silvina */
		string _idResponsable = string.Empty;
		string _telefono = string.Empty;
		
		string _idCuenta = string.Empty;

		bool _default = false;

		string _estado = string.Empty;

        /* Silvina 20110804 - Tarea 0000178 */
        DataRow _rowBD;
        bool _defaultBD;
        /* Fin Silvina 20110804 - Tarea 0000178 */

		#endregion

		#region Propiedades

		public string IdCuenta
		{
			get{return _idCuenta;}
		}

		public string IdDomicilio
		{
			get{return _idDomicilio;}
		}

		public long IdTipoDomicilio
		{
			get{return _idTipoDomicilio;}
			set{_idTipoDomicilio = value;}
		}
		
		public string Calle
		{
			get{return _calle;}
			set{_calle = value;}
		}

		public string Numero
		{
			get{return _numero;}
			set{_numero = value;}
		}

		public string Sector
		{
			get{return _sector;}
		}

		public string Torre
		{
			get{return _torre;}
		}
		
		public string Piso
		{
			get{return _piso;}
		}
		
		public string Departamento
		{
			get{return _departamento;}
		}

		public string Manzana
		{
			get{return _manzana;}
		}
		
		
		public string Partido
		{
			get{return _partido;}
		}
		
        /* Silvina 20101123 - Tarea 940 */
        private tsh_LocalidadesDataset.tsh_LocalidadesDataTable _localidades = new tsh_LocalidadesDataset.tsh_LocalidadesDataTable();
        public DataView Localidades
        {
            get
            {
                DataView view = _localidades.DefaultView;
                view.Sort = "Descripcion";
                return view;
            }
        }

        private tsh_ProvinciasDataset.tsh_ProvinciasDataTable _provincias = new tsh_ProvinciasDataset.tsh_ProvinciasDataTable();
        public DataView Provincias
        {
            get
            {
                DataView view = _provincias.DefaultView;
                view.Sort = "Nombre";
                return view;
            }
        }

        private tsh_PaisesDataset.tsh_PaisesDataTable _paises = mz.erp.businessrules.tsh_Paises.GetList().tsh_Paises;

        public DataView Paises
        {
            get
            {
                DataView view = _paises.DefaultView;
                view.Sort = "Nombre";
                return view;
            }
        }

        /* Fin Silvina */

        public long IdPais
        {
            get { return _idPais; }
            set
            {
                /* Silvina 20101119 - Tarea 940 */
                /* Silvina 20110302 - Tarea 0000081 */
                if ((_idPais != value) || (_provincias.Rows.Count == 0))
                {
                /* Fin Silvina - Tarea 0000081 */
                    _idPais = value;
                    _provincias.Clear();
                    _provincias = mz.erp.businessrules.tsh_PaisesProvincias.GetListProvincias(value).tsh_Provincias;
                    DataView view = _provincias.DefaultView;
                    view.Sort = "Nombre";
                    IdProvincia = (long)view.Table.Rows[0]["IdProvincia"];
                    /* Fin Silvina */
                }
            }
        }

		public long IdProvincia
		{
			get{return _idProvincia;}
			set{
                /* Silvina 20101119 - Tarea 940 */
                /* Silvina 20110302 - Tarea 0000081 */
                if ((_idProvincia != value) || (_localidades.Rows.Count == 0))
                {
                /* Fin Silvina - Tarea 0000081 */
                    _idProvincia = value;
                    _localidades.Clear();
                    _localidades = mz.erp.businessrules.tsh_ProvinciasLocalidades.GetListLocalidades(value).tsh_Localidades;
                    DataView view = _localidades.DefaultView;
                    view.Sort = "Descripcion";
                    IdLocalidad = view.Table.Rows[0]["IdLocalidad"].ToString();
                    /* Fin Silvina */
                }
            }
		}

        public string IdLocalidad
        {
            get { return _idLocalidad; }
            set
            {
                /* Silvina 20110302 - Tarea 0000081 */
                if (_idLocalidad != value)
                {
                /* Fin Silvina - Tarea 0000081 */
                    /* Silvina 20101119 - Tarea 940 */
                    _idLocalidad = value;
                    if (!_idLocalidad.Equals(string.Empty))
                        CodigoPostal = mz.erp.businessrules.tsh_Localidades.GetByPk(IdLocalidad).CodigoPostal;
                    /* Fin Silvina */
                }
            }
        }

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            //German 20101102 - Tarea 890
            set { _codigoPostal = value; }
            //Fin German 20101102 - Tarea 890
        }

		public string IdResponsable
		{
			get{return _idResponsable;}
		}

		public string Telefono
		{
			get{return _telefono;}
			set{_telefono = value;}
		}

		public bool Default
		{
			get{return _default;}
			set{_default = value;}
		}

		public string Estado
		{
			get{return _estado;}
			set{_estado = value;}
		}

        /* Silvina 20110804 - Tarea 0000178 */
        private bool _aceptado = false;
        public bool Aceptado
        {
            get { return _aceptado; }
            set { _aceptado = value; }
        }
        /* Fin Silvina 20110804 - Tarea 0000178 */

		#endregion

		#region Métodos Públicos

		public tsa_CuentasExDataset Commit(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			switch(_estado)
			{
				case "NEW": //Nuevo domicilio
				{
					tsa_CuentasExDataset.tcs_DomiciliosRow rowD = data.tcs_Domicilios.FindByIdDomicilio(this.IdDomicilio);
					bool existRow = rowD != null;
					if(!existRow)
                        rowD = data.tcs_Domicilios.Newtcs_DomiciliosRow();
					rowD.IdDomicilio = this.IdDomicilio;
					rowD.IdTipoDomicilio = this.IdTipoDomicilio;
					rowD.Calle = this.Calle;
					rowD.Numero = this.Numero;
					rowD.Sector = this.Sector;
					rowD.Torre = this.Torre;
					rowD.Piso = this.Piso;
					rowD.Departamento = this.Departamento;
					rowD.Manzana = this.Manzana;
					rowD.CodigoPostal = this.CodigoPostal;
					rowD.IdLocalidad = this.IdLocalidad;
					rowD.Partido = this.Partido;
					rowD.IdProvincia = this.IdProvincia;
					rowD.IdPais = this.IdPais;
                    rowD.IdResponsable = Security.IdPersona;
                    rowD.Telefono = this.Telefono;

					rowD.FechaCreacion = DateTime.Now;
					rowD.IdConexionCreacion = Security.IdConexion;
					rowD.IdConexionUltimaModificacion = Security.IdConexion;
					rowD.IdReservado = 0;
					rowD.RowId = Guid.Empty;
					rowD.IdEmpresa = Security.IdEmpresa;			
					rowD.IdSucursal = Security.IdSucursal;
					if(!existRow)
                        data.tcs_Domicilios.Addtcs_DomiciliosRow(rowD);

					//Agrego el domicilio
					if(!existRow)
					{
						tsa_CuentasExDataset.tcs_DomiciliosCuentasRow rowDC = data.tcs_DomiciliosCuentas.Newtcs_DomiciliosCuentasRow();
						rowDC.IdCuenta = this.IdCuenta;
						rowDC.idDomicilio = rowD.IdDomicilio;
						rowDC.FechaCreacion = DateTime.Now;
						rowDC.IdConexionCreacion = Security.IdConexion;
						rowDC.IdConexionUltimaModificacion = Security.IdConexion;
						rowDC.IdReservado = 0;
						rowDC.IdEmpresa = Security.IdEmpresa;			
						data.tcs_DomiciliosCuentas.Addtcs_DomiciliosCuentasRow(rowDC);
					}

					if(this.Default)
					{
						tsa_CuentasExDataset.tsa_CuentasRow rowC = data.tsa_Cuentas.FindByIdCuenta(this.IdCuenta);
						rowC.IdDomicilioDefault = this.IdDomicilio;
					}
					break;

				}
				case "MODIF": //Modificacion de domicilio
				{
					DataRow rowD = data.tcs_Domicilios.FindByIdDomicilio(this.IdDomicilio);
					rowD["IdTipoDomicilio"] = this.IdTipoDomicilio;
					rowD["Calle"] = this.Calle;
					rowD["Numero"] = this.Numero;
					rowD["IdPais"] = this.IdPais;
					rowD["IdProvincia"] = this.IdProvincia;
					if(this.IdLocalidad.Equals(string.Empty))
						rowD["IdLocalidad"] = null;
					else
                        rowD["IdLocalidad"] = this.IdLocalidad;
					rowD["Telefono"] = this.Telefono;
					//data.tcs_Domicilios.ImportRow(rowD);

					if(this.Default)
					{
						tsa_CuentasExDataset.tsa_CuentasRow rowC = data.tsa_Cuentas.FindByIdCuenta(this.IdCuenta);
						rowC.IdDomicilioDefault = this.IdDomicilio;
					}
                    /* Silvina 20110823 - Tarea 0000178 */
                    else 
                    {
                        tsa_CuentasExDataset.tsa_CuentasRow rowC = data.tsa_Cuentas.FindByIdCuenta(this.IdCuenta);
                        if (rowC.IdDomicilioDefault == this.IdDomicilio)
                            rowC.IdDomicilioDefault = null;
                    }
                    /* Fin Silvina 20110823 - Tarea 0000178 */

					break;
				}
				case "DEL": //Borrado de domicilios
				{
					DataRow rowDC = data.tcs_DomiciliosCuentas.FindByidDomicilioIdCuenta(this.IdDomicilio, this.IdCuenta);
					if(rowDC == null)
					{
						rowDC = mz.erp.businessrules.tcs_DomiciliosCuentas.GetByPk(this.IdDomicilio, this.IdCuenta);
						rowDC.Delete();
						data.tcs_DomiciliosCuentas.ImportRow(rowDC);
					}
					else
						rowDC.Delete();
                    /* Silvina 20110823 - Tarea 0000178 */
					//if(this.Default)
					//{
						tsa_CuentasExDataset.tsa_CuentasRow rowC = data.tsa_Cuentas.FindByIdCuenta(this.IdCuenta);
                        if (rowC.IdDomicilioDefault == IdDomicilio)
						    rowC.IdDomicilioDefault = null;
					//}
                    /* Fin Silvina 20110823 - Tarea 0000178 */
					break;
				}

				default:
					break;

			}
			return data;

		}

		public tcs_DomiciliosDataset Commit(tcs_DomiciliosDataset data)
		{
			switch(_estado)
			{
				case "NEW": //Nuevo domicilio
				{
					tcs_DomiciliosDataset.tcs_DomiciliosRow rowD = data.tcs_Domicilios.Newtcs_DomiciliosRow();
					rowD.IdDomicilio = this.IdDomicilio;
					rowD.IdTipoDomicilio = this.IdTipoDomicilio;
					rowD.Calle = this.Calle;
					rowD.Numero = this.Numero;
					rowD.Sector = this.Sector;
					rowD.Torre = this.Torre;
					rowD.Piso = this.Piso;
					rowD.Departamento = this.Departamento;
					rowD.Manzana = this.Manzana;
					rowD.CodigoPostal = this.CodigoPostal;
					rowD.IdLocalidad = this.IdLocalidad;
					rowD.Partido = this.Partido;
					rowD.IdProvincia = this.IdProvincia;
					rowD.IdPais = this.IdPais;
					rowD.IdResponsable = Security.IdPersona;
					rowD.Telefono = this.Telefono;

					rowD.FechaCreacion = DateTime.Now;
					rowD.IdConexionCreacion = Security.IdConexion;
					rowD.IdConexionUltimaModificacion = Security.IdConexion;
					rowD.IdReservado = 0;
					rowD.RowId = Guid.Empty;
					rowD.IdEmpresa = Security.IdEmpresa;			
					rowD.IdSucursal = Security.IdSucursal;
					data.tcs_Domicilios.Addtcs_DomiciliosRow(rowD);
					break;

				}
				case "MODIF": //Modificacion de domicilio
				{
					DataRow rowD = data.tcs_Domicilios.FindByIdDomicilio(this.IdDomicilio);
					if(rowD == null)
					{
						rowD = tcs_Domicilios.GetByPk(this.IdDomicilio);
						data.tcs_Domicilios.ImportRow(rowD);
					}
					rowD["IdTipoDomicilio"] = this.IdTipoDomicilio;
					rowD["Calle"] = this.Calle;
					rowD["Numero"] = this.Numero;
					rowD["IdPais"] = this.IdPais;
					rowD["IdProvincia"] = this.IdProvincia;
					rowD["IdLocalidad"] = this.IdLocalidad;
					rowD["Telefono"] = this.Telefono;

					break;
				}

				default:
					break;

			}
			return data;

		}

        /* Silvina 20110804 - Tarea 0000178 */
        public void Cancelar()
        {
            _idTipoDomicilio = Convert.ToInt64(_rowBD["IdTipoDomicilio"]);
            _calle = _rowBD["Calle"].ToString();
            _numero = _rowBD["Numero"].ToString();
            _sector = _rowBD["Sector"].ToString();
            _torre = _rowBD["Torre"].ToString();
            _piso = _rowBD["Piso"].ToString();
            _departamento = _rowBD["Departamento"].ToString();
            _manzana = _rowBD["Manzana"].ToString();
            IdPais = Convert.ToInt64(_rowBD["IdPais"]);
            IdProvincia = Convert.ToInt64(_rowBD["IdProvincia"]);
            if (_rowBD["IdLocalidad"] == null)
                IdLocalidad = string.Empty;
            else
                IdLocalidad = _rowBD["IdLocalidad"].ToString();
            _partido = _rowBD["Partido"].ToString();
            _idResponsable = _rowBD["IdResponsable"].ToString();
            _telefono = _rowBD["Telefono"].ToString();
            if (!_aceptado)
                _estado = string.Empty;
            _default = _defaultBD;
        }

        public void Aceptar()
        {
            if (_rowBD == null)
                _rowBD = mz.erp.businessrules.tsa_CuentasEx.NewRow().tcs_Domicilios.Newtcs_DomiciliosRow();
            _rowBD["IdTipoDomicilio"] = _idTipoDomicilio;
            _rowBD["Calle"] = _calle;
            _rowBD["Numero"] = _numero;
            _rowBD["Sector"] = _sector;
            _rowBD["Torre"]  = _torre;
            _rowBD["Piso"]  = _piso;
            _rowBD["Departamento"]  = _departamento;
            _rowBD["Manzana"]  = _manzana;
            _rowBD["IdPais"]  = IdPais;
            _rowBD["IdProvincia"] = IdProvincia;
            if (string.IsNullOrEmpty(IdLocalidad))
                _rowBD["IdLocalidad"] = null;
            else
                _rowBD["IdLocalidad"] = IdLocalidad;
            _rowBD["Partido"] = _partido;
            _rowBD["IdResponsable"] = _idResponsable;
            _rowBD["Telefono"] = _telefono;
            _defaultBD = _default;
        }
        /* Fin Silvina 20110804 - Tarea 0000178 */

		#endregion

		#region Métodos Privados
		#endregion


	}
}
