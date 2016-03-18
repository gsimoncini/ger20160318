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

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProveedores.
	/// </summary>
	public class AbmProveedores
	{
		public AbmProveedores()
		{
			_habilitaJerarquias = Variables.GetValueBool("Proveedores.ABMProveedores.HabilitaJerarquias");
			_idCondicionRetecionGanancias = Convert.ToInt32(Variables.GetValueString("Proveedores.CondicionRetencionGanancias.Default"));

			// ---- Matias - Tarea 279 - 20090716
			_allowEditResponsableIngreso = Variables.GetValueBool("Momentos.ABMProveedores.Editar.ResponsableIngreso");
			_askForPasswordResponsableIngreso = Variables.GetValueBool("Momentos.ABMProveedores.HabilitarContraseña.ResponsableIngreso");
			if (_allowEditResponsableIngreso)
				this.IdResponsableIngreso = null;
			else
				this.IdResponsableIngreso = mz.erp.businessrules.Security.IdPersona;
			// ----- Fin Matias
		}

		public AbmProveedores(string IdProveedor)
		{
			this._idProveedor = IdProveedor; 
			_habilitaJerarquias = Variables.GetValueBool("Proveedores.ABMProveedores.HabilitaJerarquias");
			_idCondicionRetecionGanancias = Convert.ToInt32(Variables.GetValueString("Proveedores.CondicionRetencionGanancias.Default"));
			InitJerarquias();

			// ---- Matias - Tarea 279 - 20090716
			_allowEditResponsableIngreso = Variables.GetValueBool("Momentos.ABMProveedores.Editar.ResponsableIngreso");
			_askForPasswordResponsableIngreso = Variables.GetValueBool("Momentos.ABMProveedores.HabilitarContraseña.ResponsableIngreso");
			if (_allowEditResponsableIngreso)
				this.IdResponsableIngreso = null;
			else
				this.IdResponsableIngreso = mz.erp.businessrules.Security.IdPersona;
		}
		
		#region Métodos  Públicos
		public void GetProveedor()
		{
			this.Init();
			if (this._idProveedor == "")
			{				
				_data = new tpu_ProveedoresDataset();								
				DataRow _row = _data.Tables[0].NewRow();	
				_row["IdProveedor"] = Util.NewStringId();				
				_row["ExcluyeRetenciones"] = false;
				_row["Activo"] = true;
				_row["BonificacionGeneral"] = 0;
				_row["DiasDemoraEntrega"] = 0;
				_row["IdEstado"] = long.MinValue;
				_row["IdSucursal"] = Security.IdSucursal;
				_row["IdEmpresa"] = Security.IdEmpresa;
				_row["IdConexionCreacion"] = Security.IdConexion;
				_row["IdReservado"] = 0;
				_row["CampoAuxiliar1"] = _campoAuxiliar1;
				_row["CampoAuxiliar2"] = _campoAuxiliar2;
				_row["CampoAuxiliar3"] = _campoAuxiliar3;
				_row["CampoAuxiliar4"] = _campoAuxiliar4;
				_row["CampoAuxiliar5"] = _campoAuxiliar5;
				_row["ExcluyeRetencionIIBB"] = false;
				_row["ExcluyeRetencionIVA"] = false;
				_row["CondicionImpuestoGanancias"] = _idCondicionRetecionGanancias;

				_row["AlicuotaRetencionIIBBCompras"] = 0;
				_row["AlicuotaRetencionIIBBServicios"] = 0;
				_row["IdResponsableCreacion"] = this.IdResponsableIngreso;
				_data.Tables[0].Rows.Add(_row);

				
			}
			else 
			{
				_data = businessrules.tpu_Proveedores.GetByPkToDataSet(_idProveedor);				
			}			
			
			row = _data.Tables[0].Rows[0];				
			_nombre = Convert.ToString(	row["Nombre"] );
			_idTitular = Convert.ToString(	row["IdTitular"] );
			_idCategoriaIva = Convert.ToString( row["IdCategoriaIva"] );
			_idTipoDocumento = Convert.ToString( row["IdTipoDocumento"] );
			_numero = Convert.ToString(	row["Numero"] );
			_domicilio = Convert.ToString( row["Domicilio"] );
			_horarioComercial = Convert.ToString( row["HorarioComercial"] );
			_observaciones = Convert.ToString( row["Observaciones"] );
			_telefonos = Convert.ToString( row["Telefonos"] );
			_email = Convert.ToString( row["Email"] );
			_instantMessenger = Convert.ToString( row["InstantMessenger"] );
			_web = Convert.ToString( row["Web"] );
			_bonificacionGeneral = Convert.ToDecimal( row["BonificacionGeneral"] );

			_idLocalidad = Convert.ToString( row["IdLocalidad"] );
			
			DataSet dataPL = mz.erp.businessrules.tsh_ProvinciasLocalidades.GetListByIdLocalidad(_idLocalidad);
			if(dataPL.Tables[0].Rows.Count > 0)
				_idProvinciaEdicion = Convert.ToInt64(dataPL.Tables[0].Rows[0]["IdProvincia"]);
			else _idProvinciaEdicion = long.MinValue;

			DataSet dataPP = mz.erp.businessrules.tsh_PaisesProvincias.GetListByIdProvincia(_idProvinciaEdicion);
			if(dataPP.Tables[0].Rows.Count > 0)
				_idPaisEdicion = Convert.ToInt64(dataPP.Tables[0].Rows[0]["IdPais"]);
			else _idPaisEdicion = long.MinValue;


			_idTipoDeMovimiento = Convert.ToString( row["IdTipoMovimiento"] );
			_idSubTipoDeMovimiento = Convert.ToString( row["IdSubTipoMovimiento"] );
			_excluyeRetenciones = Convert.ToBoolean ( row["ExcluyeRetenciones"] );
			_activo = Convert.ToBoolean ( row["Activo"] );
			_idCondicionDeCompra = Convert.ToString( row["IdCondicionDeCompra"] );
			_diasDemoraEntrega = Convert.ToInt64 ( row["DiasDemoraEntrega"] );
			if (row["IdEstado"] != System.DBNull.Value)							
				_idEstado = Convert.ToInt64 ( row["IdEstado"] );
			_campoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
			_campoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
			_campoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
			_campoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
			_codigo = Convert.ToString(row["Codigo"]);
			if(!row.IsNull("CampoAuxiliar5"))
				_campoAuxiliar5 = Convert.ToDecimal(row["CampoAuxiliar5"]);
			_excluyeRetencionIIBB = Convert.ToBoolean ( row["ExcluyeRetencionIIBB"] );
			_excluyeRetencionIVA = Convert.ToBoolean ( row["ExcluyeRetencionIVA"] );
			_idCondicionRetecionGanancias = Convert.ToInt64(row["CondicionImpuestoGanancias"]);

			_alicuotaRetencionIIBBCompras = Convert.ToDecimal(row["AlicuotaRetencionIIBBCompras"]);
			_alicuotaRetencionIIBBServicios = Convert.ToDecimal(row["AlicuotaRetencionIIBBServicios"]);
			_idResponsableIngreso = Convert.ToString(row["IdResponsableCreacion"]);			

		}

		public void Init()
		{			
			_idCategoriaIvaDefault = "RI";
			_idEstadoDefault = long.MinValue;
			
			//Matias 20100604 - Tarea 17
			DeterminarSigno();
			build_DataTableTiposMovimientos();
			//Fin Matias 20100604 - Tarea 17
		}

		public void Execute()
		{
			/*if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			*/

			//this.IsValid();

			/*if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());*/

			if (this.IsValid())
			{
				Commit();
				Flush("");
			}			
		}

		
		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			/*if ((_claveAnterior != _claveBD) && (_enabledSetPreviousPassword ))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( _leyendaFormulario,"Contraseña anterior","La contraseña anterior es inválida"));
			}			*/
			if(_nombre == null || _nombre.Equals(string.Empty))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Alta de proveedores","Nombre","El Nombre NO puede ser vacío"));
			}
            /* Silvina 20110606 - Tarea 0000152 */
			if (!_codigoAutomatico)
                if ((_codigo == null) || (_codigo.Equals(string.Empty)))
                {
                    IsValid = false;
                    _errores.Add(new ItemDatasetError("Alta de proveedores", "Codigo", "El Código NO puede ser vacío"));
                }
                else
                {
                    tpu_ProveedoresDataset.tpu_ProveedoresRow  rowCod = tpu_Proveedores.GetByCodigo(_codigo);
                    if ((rowCod != null) && !(rowCod.IdProveedor.Equals(IdProveedor)))
                    {
                        IsValid = false;
                        _errores.Add(new ItemDatasetError("Alta de proveedores", "Codigo", "El Código ingresado está asociado a otro Proveedor."));
                        return false;
                    }
                }
            /* Fin Silvina 20110606 - Tarea 0000152 */
			if ( _idResponsableIngreso==null || _idResponsableIngreso.Equals(string.Empty) )
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Alta de proveedores","Responsable","No seleccionó el Responsable del alta"));
			}

            /* Silvina 20110405 - Tarea 0000047 */
            if (!IdTipoDocumento.Equals("CUIT"))
            {
                tpu_ProveedoresDataset.tpu_ProveedoresRow rowDoc = tpu_Proveedores.GetByDocumento(IdTipoDocumento, Numero);
                if ((rowDoc != null) && !(rowDoc.IdProveedor.Equals(IdProveedor)))
                {
                    IsValid = false;
                    _errores.Add(new ItemDatasetError("Alta de proveedores", "Documento", "El numero indicado ya existe para el tipo de documento seleccionado"));
                    return false;
                }
            }
            /* Fin Silvina 20110405 - Tarea 0000047 */
			return IsValid;
		}
		public void Commit()
		{						
			row["Codigo"] = _codigo;
			row["Nombre"] = _nombre;
			row["IdTitular"] = _idTitular;
			row["IdCategoriaIva"] = _idCategoriaIva;
			row["IdTipoDocumento"] = _idTipoDocumento;
			row["Numero"] = _numero;
			row["Domicilio"] = _domicilio;
			row["HorarioComercial"] = _horarioComercial;
			row["Observaciones"] = _observaciones;
			row["Telefonos"] = _telefonos;
			row["Email"] = _email;
			row["InstantMessenger"] = _instantMessenger;
			row["Web"] = _web;
			row["BonificacionGeneral"] = _bonificacionGeneral;
			row["IdLocalidad"] = _idLocalidad;
			row["IdTipoMovimiento"] = _idTipoDeMovimiento;
			row["IdSubTipoMovimiento"] = _idSubTipoDeMovimiento;
			row["ExcluyeRetenciones"] = _excluyeRetenciones;
			row["Activo"] = _activo;
			row["IdCondicionDeCompra"] = _idCondicionDeCompra;
			row["DiasDemoraEntrega"] = _diasDemoraEntrega;
			row["CampoAuxiliar1"] = _campoAuxiliar1;
			row["CampoAuxiliar2"] = _campoAuxiliar2;
			row["CampoAuxiliar3"] = _campoAuxiliar3;
			row["CampoAuxiliar4"] = _campoAuxiliar4;
			row["CampoAuxiliar5"] = _campoAuxiliar5;

			row["ExcluyeRetencionIIBB"] = _excluyeRetencionIIBB;
			row["ExcluyeRetencionIVA"] = _excluyeRetencionIVA;
			row["CondicionImpuestoGanancias"] = _idCondicionRetecionGanancias;

			row["AlicuotaRetencionIIBBServicios"] = _alicuotaRetencionIIBBServicios;
			row["AlicuotaRetencionIIBBCompras"] = _alicuotaRetencionIIBBCompras;
			row["IdResponsableCreacion"] = _idResponsableIngreso;

			if (_idEstado == 0)
				_idEstado = long.MinValue;

			row["IdEstado"] = _idEstado;

			if (this._idProveedor == "")
			{
				row["FechaCreacion"] = Sistema.DateTime.Now;				
			}

			if(_habilitaJerarquias)
			{
				string IdProveedor = string.Empty;
				if(this._idProveedor == "")
				{
					IdProveedor = mz.erp.systemframework.Util.NewStringId();				
				}
				else
				{
					IdProveedor = this._idProveedor;
					_dataAgrupProv.Merge(mz.erp.dataaccess.tpu_AgrupProveedores.GetList(IdProveedor, long.MinValue ).Tables[0]);
					foreach(DataRow rowJ in _dataAgrupProv.tpu_AgrupProveedores.Rows)
					{
						rowJ.Delete();
					}	
					tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow _auxRow=mz.erp.dataaccess.tpu_ProveedoresJerarquias.GetByPk(IdProveedor);
					if ( _auxRow!=null)
						_dataProvJerarquias.tpu_ProveedoresJerarquias.ImportRow(_auxRow);
					foreach(DataRow rowPJ in _dataProvJerarquias.tpu_ProveedoresJerarquias.Rows)
					{
						rowPJ.Delete();
					}

				}
				if(ByJerarquia1)
					foreach(ItemJerarquia item in this._jerarquia1)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia2)
					foreach(ItemJerarquia item in this._jerarquia2)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia3)
					foreach(ItemJerarquia item in this._jerarquia3)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia4)
					foreach(ItemJerarquia item in this._jerarquia4)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia5)
					foreach(ItemJerarquia item in this._jerarquia5)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia6)
					foreach(ItemJerarquia item in this._jerarquia6)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia7)
					foreach(ItemJerarquia item in this._jerarquia7)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);
				if(ByJerarquia8)
					foreach(ItemJerarquia item in this._jerarquia8)
						this.Addtpu_AgrupProveedoresRow(item.NodeKeyPath, IdProveedor);

				ProveedoresJerarquiaAuxiliar p= new ProveedoresJerarquiaAuxiliar();
				p.cargarJerarquias(_dataAgrupProv.tpu_AgrupProveedores);
				Hashtable aux=p.ProveedorJerarquia;
				//Para cada cuenta
				foreach(string idProv in aux.Keys)
				{
					object valor = aux[idProv];
					this.AddTpu_ProveedoresJerarquias(idProv,(ArrayList)valor);
				}

			}
		}
		public void Flush(string IdTransaction)
		{
			/*if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);*/
			string pavada = "";
			businessrules.tpu_Proveedores.Update( (tpu_ProveedoresDataset.tpu_ProveedoresDataTable)_data.Tables[0]);
			_hasErrors = false;						
			foreach (System.Data.DataRow row in _data.Tables[0].Rows)
			{
				if (row.HasErrors)
				{
					_hasErrors = true;											
				}				
			}		
			
			if(_habilitaJerarquias)
			{
				if(this._idProveedor == "")
				{
					string IdProveedor = (string)row["IdProveedor"];				
					foreach(tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow rowAp in _dataAgrupProv.tpu_AgrupProveedores.Rows)
					{
						rowAp.IdProveedor = IdProveedor;
					}
					foreach(tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow rowPJ in _dataProvJerarquias.tpu_ProveedoresJerarquias.Rows)
					{
						rowPJ.IdProveedor = IdProveedor;
					}
				}
                businessrules.tpu_AgrupProveedores.Update(_dataAgrupProv.tpu_AgrupProveedores);
				businessrules.tpu_ProveedoresJerarquias.Update(_dataProvJerarquias.tpu_ProveedoresJerarquias);
			}

						/*if(OnTaskAfterFlush != null)
							OnTaskAfterFlush(this,new EventArgs());*/
					}
		public void GetSubTipos()
		{
			if (_idTipoDeMovimiento != null)
				_subTiposMovimientos = businessrules.tsy_SubTipoMovimiento.GetList(_idTipoDeMovimiento).tsy_SubTipoMovimiento;			
/*			if (_subTipos.Rows.Count == 1)
			{
				_idSubTipo = Convert.ToString(_subTipos.Rows[0]["IdCuentaObservacionTipo"]);
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());					
			}
			if (_subTipos.Rows.Count >= 1)
			{
				DataRow row = _subTipos.NewRow();					
				row["IdCuentaObservacionTipo"] = String.Empty;
				row["Descripcion"] = String.Empty;
				_subTipos.Rows.Add(row);
			}*/
		}
		#endregion

		#region Propiedades
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


		private decimal _alicuotaRetencionIIBBCompras = 0;
		public decimal AlicuotaRetencionIIBBCompras 
		{
			get{return _alicuotaRetencionIIBBCompras;}
			set{_alicuotaRetencionIIBBCompras = value;}
		}
	
		private decimal _alicuotaRetencionIIBBServicios = 0;
		public decimal AlicuotaRetencionIIBBServicios
		{
			get{return _alicuotaRetencionIIBBServicios;}
			set{_alicuotaRetencionIIBBServicios = value;}
		}



		//Para Sabrina B
		private string _codigo = string.Empty;
		public string Codigo
		{
			get
			{
				return _codigo;
			}
			set
			{
				_codigo = value;
			}
		}
		
		private long _idCondicionRetecionGanancias = 0;
		private bool _excluyeRetencionIVA = false;
		private bool _excluyeRetencionIIBB = false;

		public bool ExcluyeRetencionIIBB
		{
			get{return _excluyeRetencionIIBB;}
			set{_excluyeRetencionIIBB = value;}
		}

		public bool ExcluyeRetencionIVA
		{
			get{return _excluyeRetencionIVA;}
			set{_excluyeRetencionIVA = value;}
		}

		public long IdCondicionRetecionGanancias
		{
			get{return _idCondicionRetecionGanancias;}
			set{_idCondicionRetecionGanancias = value;}
		}
		
		private string _campoAuxiliar1 = string.Empty;
		public string CampoAuxiliar1
		{
			get
			{
				return _campoAuxiliar1;
			}
			set
			{
				_campoAuxiliar1 = value;
			}
		}
		
		private string _campoAuxiliar2 = string.Empty;
		public string CampoAuxiliar2
		{
			get
			{
				return _campoAuxiliar2;
			}
			set
			{
				_campoAuxiliar2 = value;
			}
		}
		
		private string _campoAuxiliar3 = string.Empty;
		public string CampoAuxiliar3
		{
			get
			{
				return _campoAuxiliar3;
			}
			set
			{
				_campoAuxiliar3 = value;
			}
		}

		private string _campoAuxiliar4 = string.Empty;
		public string CampoAuxiliar4
		{
			get
			{
				return _campoAuxiliar4;
			}
			set
			{
				_campoAuxiliar4 = value;
			}
		}

		private decimal _campoAuxiliar5 = 0;

		public decimal CampoAuxiliar5
		{
			get
			{
				return _campoAuxiliar5;
			}
			set
			{
				_campoAuxiliar5 = value;
			}
		}


		private string _idProveedor = "";
		public string IdProveedor
		{
			get { return _idProveedor;}
			set { _idProveedor = value;	}
		}
		private string _nombre = "";
		public string Nombre
		{
			get { return _nombre;}
			set { _nombre = value;	}
		}
		
		public DataTable TiposDocumentos
		{
			get { return businessrules.tsy_TiposDocumentos.GetList().tsy_TiposDocumentos;}			
		}
		public DataTable CategoriasIva 
		{
			get { return businessrules.tsy_CategoriasIva.GetList().tsy_CategoriasIva;}			
		}
		public DataTable TiposMovimientos
		{
			//Matias 20100604 - Tarea 17...get {return businessrules.tsy_TiposMovimientos.GetList().tsy_TiposMovimientos;}
			get {return _tiposMovimientos;}
			//Fin Matias 20100604 - Tarea 17
		}
		private DataTable _subTiposMovimientos = businessrules.tsy_SubTipoMovimiento.GetList().tsy_SubTipoMovimiento;
		public DataTable SubTiposMovimientos
		{
			get {return _subTiposMovimientos;}
		}
		public DataTable CondicionesDeCompra
		{
            get
            {
                /* Silvina 20110225 - Tarea 0000074 */
                return businessrules.tpu_CondicionesDeCompras.GetListActivas().tpu_CondicionesDeCompras;
                /* Fin Silvina */
            }
		}
		public DataTable Estados
		{
			get {return businessrules.tpu_ProveedoresEstados.GetList().tpu_ProveedoresEstados;}
		}

		private string _idTitular = "";
		public string IdTitular
		{
			get { return _idTitular;}
			set { _idTitular = value;	}
		}
		private string _idCategoriaIva = "";
		public string IdCategoriaIva
		{
			get { return _idCategoriaIva;}
			set { _idCategoriaIva = value;	}
		}
		private string _idCategoriaIvaDefault;
		public string IdCategoriaIvaDefault
		{
			get { return _idCategoriaIvaDefault;}			
		}
		private string _idTipoDocumento = "";
		public string IdTipoDocumento
		{
			get { return _idTipoDocumento;}
			set { _idTipoDocumento = value;	}
		}
		private string _numero = "";
		public string Numero
		{
			get { return _numero;}
			set { _numero = value;	}
		}
		private string _domicilio = "";
		public string Domicilio
		{
			get { return _domicilio;}
			set { _domicilio = value;	}
		}
		private string _horarioComercial = "";
		public string HorarioComercial
		{
			get { return _horarioComercial;}
			set { _horarioComercial = value;	}
		}
		private string _observaciones = "";
		public string Observaciones
		{
			get { return _observaciones;}
			set { _observaciones = value;	}
		}
		private string _telefonos = "";
		public string Telefonos
		{
			get { return _telefonos;}
			set { _telefonos = value;	}
		}
		private string _email = "";
		public string Email
		{
			get { return _email;}
			set { _email = value;	}
		}

		private string _instantMessenger = "";
		public string InstantMessenger
		{
			get { return _instantMessenger;}
			set { _instantMessenger = value;	}
		}

		private string _web = "";
		public string Web
		{
			get { return _web;}
			set { _web = value;	}
		}

		private decimal _bonificacionGeneral;
		public decimal BonificacionGeneral
		{
			get { return _bonificacionGeneral;}
			set { _bonificacionGeneral = value;	}
		}

		private string _idLocalidad = Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");
		public string IdLocalidad
		{
			get { return _idLocalidad;}
			set { _idLocalidad = value;	}
		}

		private string _idTipoDeMovimiento = "";
		public string IdTipoDeMovimiento
		{
			get { return _idTipoDeMovimiento;}
			set 
			{ 
				_idTipoDeMovimiento = value;	
				GetSubTipos();
				if(TiposHasChanged != null)
					TiposHasChanged(this,new EventArgs());
			}
		}

		private string _idSubTipoDeMovimiento = "";
		public string IdSubTipoDeMovimiento
		{
			get { return _idSubTipoDeMovimiento;}
			set { _idSubTipoDeMovimiento = value;	}
		}

		private bool _excluyeRetenciones;
		public bool ExcluyeRetenciones
		{
			get { return _excluyeRetenciones;}
			set { _excluyeRetenciones = value;	}
		}

		private bool _activo = true;
		public bool Activo
		{
			get { return _activo;}
			set { _activo = value;	}
		}

		private string _idCondicionDeCompra = "";
		public string IdCondicionDeCompra
		{
			get { return _idCondicionDeCompra;}
			set { _idCondicionDeCompra = value;	}
		}

		private long _diasDemoraEntrega;
		public long DiasDemoraEntrega
		{
			get { return _diasDemoraEntrega;}
			set { _diasDemoraEntrega = value;	}
		}

		private long _idEstado = long.MinValue;
		public long IdEstado
		{
			get { return _idEstado;}
			set { _idEstado = value;	}		
		}
		private long _idEstadoDefault;
		public long IdEstadoDefault
		{
			get { return _idEstadoDefault;}			
		}
		
		private bool _hasErrors = true;
		public bool HasErrors
		{
			get { return _hasErrors; }			
		}

		public DataTable Errors
		{
			get 
			{
				return _data.Tables[0];
			}
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

		private ProveedoresJearaquias _jerarquias = new ProveedoresJearaquias();
		public ProveedoresJearaquias Jerarquias
		{
			get{return _jerarquias;}
		}

		// ---- Matias - Tarea 279 - 20090716
		private string _idResponsableIngreso = string.Empty;
		private string _responsableIngreso = string.Empty;
		private bool _allowEditResponsableIngreso = false;
		private bool _askForPasswordResponsableIngreso = false;
		private string _ultimoResponsableClaveCorrecta = string.Empty;
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

		// ---- Fin Matias

		#endregion

		#region Variables privadas
		
		private DataRow row = null;
		private DataTable _table = new DataTable();
		private DataSet _data;		
		private tpu_AgrupProveedoresDataset _dataAgrupProv = new tpu_AgrupProveedoresDataset();
		private tpu_ProveedoresJerarquiasDataset _dataProvJerarquias = new tpu_ProveedoresJerarquiasDataset();
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private bool _habilitaJerarquias = false;
		bool _codigoAutomatico = Variables.GetValueBool("Proveedores.CodigoAutomatico");
		private long _idProvinciaEdicion = Variables.GetValueLong("Proveedores.Domicilios.Provincia.ValorDefault");
		private long _idPaisEdicion = Variables.GetValueLong("Proveedores.Domicilios.Pais.ValorDefault");
		
		//Matias 20100604 - Tarea 17
		private System.Int16 _signo = System.Int16.MinValue;
		private DataTable _tiposMovimientos = new DataTable();
		//Fin Matias 20100604 - Tarea 17


		#endregion

		#region Eventos y delegados
		public event EventHandler TiposHasChanged;
		#endregion

		#region Métodos  Privados
		private void InitJerarquias()
		{	
			if(this._idProveedor != "" && _habilitaJerarquias)
			{
				DataSet _dataAgrup = dataaccess.tpu_AgrupProveedores.GetListEx(this._idProveedor,long.MinValue);
				foreach(DataRow rowJ in _dataAgrup.Tables[0].Rows)
				{
					ProveedorJerarquia pj = new ProveedorJerarquia();
					pj.IdProveedor = this._idProveedor;
					pj.Jerarquia = Convert.ToString(rowJ["Jerarquia"]);
					pj.IdNomenclatura = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetPkByJerarquia(Convert.ToString(rowJ["Jerarquia"]));
					this._jerarquias.Add(pj);
				}
			}


		}

		private void Addtpu_AgrupProveedoresRow(string Jerarquia, string IdProveedor)
		{
			tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow rowAp = _dataAgrupProv.tpu_AgrupProveedores.Newtpu_AgrupProveedoresRow();
			rowAp.IdProveedor = IdProveedor;
			rowAp.Jerarquia = Jerarquia;
			rowAp.FechaCreacion = DateTime.Now;
			rowAp.IdConexionCreacion = Security.IdConexion;
			rowAp.IdReservado = 0;
			rowAp.IdEmpresa = Security.IdEmpresa;								
			_dataAgrupProv.tpu_AgrupProveedores.Addtpu_AgrupProveedoresRow(rowAp);
		}

		private void AddTpu_ProveedoresJerarquias(string idProveedor, ArrayList TodaJerarquia)
		{
			tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow _row = _dataProvJerarquias.tpu_ProveedoresJerarquias.Newtpu_ProveedoresJerarquiasRow();
			_row.IdProveedor = idProveedor;
			_row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			_row.IdConexionCreacion = Security.IdConexion;
			_row.IdConexionUltimaModificacion = Security.IdConexion;
			_row.IdReservado = 0;
			_row.RowId = Guid.Empty;
			_row.IdEmpresa = Security.IdEmpresa;
			_row.IdSucursal=Security.IdSucursal;
			_row=this.MetodoAuxiliarAddTpu_ProveedoresJerarquias(TodaJerarquia,_row);
			_dataProvJerarquias.tpu_ProveedoresJerarquias.Addtpu_ProveedoresJerarquiasRow(_row);
				
		}

		private tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow MetodoAuxiliarAddTpu_ProveedoresJerarquias(ArrayList TodaJerarquia, tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow _row)
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

		//Matias 20100604 - Tarea 17
		private void DeterminarSigno()
		{
			_signo = -1; //Los tipos de movimiento siempre seran "Egresos".			
		}
		private void build_DataTableTiposMovimientos()
		{			
			//DataTable tableTM = (DataTable) tsy_TiposMovimientos.GetListPorSigno(Convert.ToString(_signo)).tsy_TiposMovimientos;
			//_tiposMovimientos =  VariablesListComparer.FilterDataTable(this._process.Process.ProcessName, this.GetTaskName(), "TipoMovimiento", "IdTipoMovimiento", tableTM);
			_tiposMovimientos = (DataTable) tsy_TiposMovimientos.GetListPorSigno(Convert.ToString(_signo)).tsy_TiposMovimientos;
		}
		//Fin Matias 20100604 - Tarea 17

		#endregion

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public class ProveedorJerarquia
		{
			private string _idProveedor = string.Empty;
			private string _jerarquia = string.Empty;
			private string _idNomenclatura = string.Empty;

			public string IdProveedor
			{
				get{return _idProveedor;}
				set{_idProveedor = value;}
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

		public class ProveedoresJearaquias: CollectionBase    
		{                                                  
			public ProveedoresJearaquias()                
			{                                          
			}                                          
			public void Add(object sender)             
			{                                          
				base.List.Add( sender );           
			}                                          
                                                   
		} 

	}

	public class ProveedoresJerarquiaAuxiliar
	{	
		private Hashtable _proveedorJerarquia=new Hashtable();
		private string _jerarquia1 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia1" );
		private string _jerarquia2 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia2" );
		private string _jerarquia3 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia3" );
		private string _jerarquia4 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia4" );
		private string _jerarquia5 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia5" );
		private string _jerarquia6 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia6" );
		private string _jerarquia7 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia7" );
		private string _jerarquia8 = Variables.GetValueString( "Proveedores.BusquedaJerarquica.Jerarquia8" );
		public ProveedoresJerarquiaAuxiliar()
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
		public Hashtable ProveedorJerarquia
		{
			get{return _proveedorJerarquia;}
			set{_proveedorJerarquia = value;}
		}
			
		#endregion properties
			
		public void cargarJerarquias(tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresDataTable tabla)
		{
			
			foreach (tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row in tabla)
			{
				if (!Convert.ToString(row.RowState).Equals("Deleted"))
				{
					string idProveedor= Convert.ToString(row.IdProveedor);
					string jerarquia=Convert.ToString(row.Jerarquia);
					string jerarquiaReal=this.jerarquiaReal(jerarquia);
					ArrayList jerarProveedor;
					ArrayList ArrayNiveles;
					if(_proveedorJerarquia[idProveedor]!=null)
					{
						jerarProveedor=(ArrayList)_proveedorJerarquia[idProveedor];
					}
					else 
					{
						ArrayList aux=new ArrayList(7);
						int contador;
						for( contador=0; contador <= 6; contador++ ) 
						{
							aux.Add(new ArrayList());
						}
						_proveedorJerarquia.Add(idProveedor,aux);
						jerarProveedor=(ArrayList)_proveedorJerarquia[idProveedor];
					}
					
					//Me da 1, 2, 3.....
					int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
					ArrayNiveles=new ArrayList();
					ArrayNiveles = Util.Parse(jerarquia,20);
					//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
					//jerarProducto[posicion-1]=ArrayNiveles;
					posicion--;
					jerarProveedor.Insert(posicion,ArrayNiveles);
				}
			}
		}
		//
		public void cargarJerarquias(string jerarquia,string idProveedor)
		{
			string jerarquiaReal=this.jerarquiaReal(jerarquia);
			ArrayList jerarProveedor;
			ArrayList ArrayNiveles;
			if(_proveedorJerarquia[idProveedor]!=null)
			{
				jerarProveedor=(ArrayList)_proveedorJerarquia[idProveedor];
			}
			else 
			{
				ArrayList aux=new ArrayList(7);
				int contador;
				for( contador=0; contador <= 6; contador++ ) 
				{
					aux.Add(new ArrayList());
				}
				_proveedorJerarquia.Add(idProveedor,aux);
				jerarProveedor=(ArrayList)_proveedorJerarquia[idProveedor];
			}
					
			//Me da 1, 2, 3.....
			int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
			ArrayNiveles=new ArrayList();
			ArrayNiveles = Util.Parse(jerarquia,20);
			//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
			//jerarProducto[posicion-1]=ArrayNiveles;
			posicion--;
			jerarProveedor.Insert(posicion,ArrayNiveles);
									
		}
		private string jerarquiaReal(string jerarquia)
		{
			string resultado=string.Empty;	
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
				resultado="jerarquia8";
			return resultado;
		}

		public string nomenclaturaReal(string jerarquia)
		{
			string resultado=string.Empty;	
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
			return resultado;
		}
			
	}
}

